using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SoulsFormats;
using System.Linq;
using System.Threading;
using System.Diagnostics;

namespace StudioCore.MsbEditor
{
    /// <summary>
    /// Utilities for dealing with global params for a game
    /// </summary>
    public class ParamBank
    {
        private static AssetLocator AssetLocator = null;

        private static Dictionary<string, PARAM> _params = null;
        private static Dictionary<string, PARAM> _vanillaParams = null;
        private static Dictionary<string, PARAMDEF> _paramdefs = null;
        private static Dictionary<string, HashSet<int>> _paramDirtyCache = null; //If param != vanillaparam

        public static bool IsDefsLoaded { get; private set; } = false;
        public static bool IsMetaLoaded { get; private set; } = false;
        public static bool IsParamsLoaded { get; private set; } = false;
        public static bool IsLoadingParams { get; private set; } = false;
        public static bool IsLoadingVParams { get; private set; } = false;

        public static IReadOnlyDictionary<string, PARAM> Params
        {
            get
            {
                if (IsLoadingParams)
                {
                    return null;
                }
                return _params;
            }
        }
        public static IReadOnlyDictionary<string, PARAM> VanillaParams
        {
            get
            {
                if (IsLoadingVParams)
                {
                    return null;
                }
                return _vanillaParams;
            }
        }
        public static IReadOnlyDictionary<string, HashSet<int>> DirtyParamCache
        {
            get
            {
                if (IsLoadingParams)
                {
                    return null;
                }
                return _paramDirtyCache;
            }
        }

        //DS2 Only
        private static PARAM GetParam(BND4 parambnd, string paramfile)
        {
            var bndfile = parambnd.Files.Find(x => Path.GetFileName(x.Name) == paramfile);
            if (bndfile != null)
            {
                return PARAM.Read(bndfile.Bytes);
            }

            // Otherwise the param is a loose param
            if (File.Exists($@"{AssetLocator.GameModDirectory}\Param\{paramfile}"))
            {
                return PARAM.Read($@"{AssetLocator.GameModDirectory}\Param\{paramfile}");
            }
            if (File.Exists($@"{AssetLocator.GameRootDirectory}\Param\{paramfile}"))
            {
                return PARAM.Read($@"{AssetLocator.GameRootDirectory}\Param\{paramfile}");
            }
            return null;
        }

        private static List<(string, PARAMDEF)> LoadParamdefs()
        {
            _paramdefs = new Dictionary<string, PARAMDEF>();
            var dir = AssetLocator.GetParamdefDir();
            var files = Directory.GetFiles(dir, "*.xml");
            List<(string, PARAMDEF)> defPairs = new List<(string, PARAMDEF)>();
            foreach (var f in files)
            {
                var pdef = PARAMDEF.XmlDeserialize(f);
                _paramdefs.Add(pdef.ParamType, pdef);
                defPairs.Add((f, pdef));
            }
            return defPairs;
        }

        public static void LoadParamMeta(List<(string, PARAMDEF)> defPairs)
        {
            var mdir = AssetLocator.GetParammetaDir();
            foreach ((string f, PARAMDEF pdef) in defPairs)
            {
                var fName = f.Substring(f.LastIndexOf('\\') + 1);
                ParamMetaData.XmlDeserialize($@"{mdir}\{fName}", pdef);
            }
        }

        public static void LoadParamDefaultNames()
        {
            var dir = AssetLocator.GetParamNamesDir();
            var files = Directory.GetFiles(dir, "*.txt");
            while (IsLoadingParams); //super hack
                Thread.Sleep(100);
            foreach (var f in files)
            {
                int last = f.LastIndexOf('\\') + 1;
                string file = f.Substring(last);
                string param = file.Substring(0, file.Length - 4);
                if (!_params.ContainsKey(param))
                    continue;
                string names = File.ReadAllText(f);
                MassEditResult r = MassParamEditCSV.PerformSingleMassEdit(names, new ActionManager(), param, "Name", true);
            }
        }

        private static void LoadParamFromBinder(IBinder parambnd, ref Dictionary<string, PARAM> paramBank)
        {
            // Load every param in the regulation
            // _params = new Dictionary<string, PARAM>();
            foreach (var f in parambnd.Files)
            {
                if (!f.Name.ToUpper().EndsWith(".PARAM") || Path.GetFileNameWithoutExtension(f.Name).StartsWith("default_"))
                {
                    continue;
                }
                if (f.Name.EndsWith("LoadBalancerParam.param"))
                {
                    continue;
                }
                if (paramBank.ContainsKey(Path.GetFileNameWithoutExtension(f.Name)))
                {
                    continue;
                }
                PARAM p = PARAM.Read(f.Bytes);
                if (!_paramdefs.ContainsKey(p.ParamType))
                {
                    continue;
                }
                p.ApplyParamdef(_paramdefs[p.ParamType]);
                paramBank.Add(Path.GetFileNameWithoutExtension(f.Name), p);
            }
        }

        private static string LoadParamsBBSekrio()
        {
            var dir = AssetLocator.GameRootDirectory;
            var mod = AssetLocator.GameModDirectory;
            if (!File.Exists($@"{dir}\\param\gameparam\gameparam.parambnd.dcx"))
            {
                MessageBox.Show("Could not find param file. Functionality will be limited.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Load params
            var param = $@"{mod}\param\gameparam\gameparam.parambnd.dcx";
            if (!File.Exists(param))
            {
                param = $@"{dir}\param\gameparam\gameparam.parambnd.dcx";
            }
            BND4 paramBnd = BND4.Read(param);

            LoadParamFromBinder(paramBnd, ref _params);
            return dir;
        }
        private static void LoadVParamsBBSekrio(string dir)
        {
            LoadParamFromBinder(BND4.Read($@"{dir}\param\gameparam\gameparam.parambnd.dcx"), ref _vanillaParams);
        }

        //Some returns and repetition, but it keeps all threading and loading-flags visible inside this method
        public static void ReloadParams()
        {
            _paramdefs = new Dictionary<string, PARAMDEF>();
            _params = new Dictionary<string, PARAM>();
            _vanillaParams = new Dictionary<string, PARAM>();
            IsDefsLoaded = false;
            IsMetaLoaded = false;
            IsParamsLoaded = false;
            IsLoadingParams = true;
            IsLoadingVParams = true;

            TaskManager.Run("PB:LoadParams", true, false, () =>
            {
                if (AssetLocator.Type != GameType.Undefined)
                {
                    List<(string, PARAMDEF)> defPairs = LoadParamdefs();
                    IsDefsLoaded = true;
                    TaskManager.Run("PB:LoadParamMeta", true, false, () =>
                    {
                        LoadParamMeta(defPairs);
                        IsMetaLoaded = true;
                    });
                }
                string vparamDir = null;
                if (AssetLocator.Type == GameType.Bloodborne || AssetLocator.Type == GameType.Sekiro)
                {
                    vparamDir = LoadParamsBBSekrio();
                }
                _paramDirtyCache = new Dictionary<string, HashSet<int>>();
                foreach (string param in _params.Keys)
                    _paramDirtyCache.Add(param, new HashSet<int>());
                IsLoadingParams = false;

                if (vparamDir != null)
                {
                    TaskManager.Run("PB:LoadVParams", true, false, () => {
                        if (AssetLocator.Type == GameType.Bloodborne || AssetLocator.Type == GameType.Sekiro)
                        {
                            LoadVParamsBBSekrio(vparamDir);
                        }
                        IsLoadingVParams = false;
                        TaskManager.Run("PB:RefreshDirtyCache", false, true, () => refreshParamDirtyCache());
                    });
                }
                IsParamsLoaded = true;
            });
        }

        public static void refreshParamDirtyCache()
        {
            if (IsLoadingParams || IsLoadingVParams)
                return;
            Dictionary<string, HashSet<int>> newCache = new Dictionary<string, HashSet<int>>();
            foreach (string param in _params.Keys)
            {
                HashSet<int> cache = new HashSet<int>();
                newCache.Add(param, cache);
                PARAM p = _params[param];
                if (!_vanillaParams.ContainsKey(param))
                {
                    Console.WriteLine("Missing vanilla param "+param);
                    continue;
                }
                PARAM vp = _vanillaParams[param];
                foreach (PARAM.Row row in _params[param].Rows.ToList())
                {
                    refreshParamRowDirtyCache(row, vp, cache);
                }
            }
            _paramDirtyCache = newCache;
        }
        public static void refreshParamRowDirtyCache(PARAM.Row row, PARAM vanillaParam, HashSet<int> cache)
        {
            PARAM.Row vrow = vanillaParam[row.ID];
            if (vrow == null)
            {
                cache.Add(row.ID);
                return;
            }
            foreach (PARAMDEF.Field field in row.Def.Fields)
            {
                if (field.InternalType == "dummy8")
                    continue;
                if (!row[field.InternalName].Value.Equals(vrow[field.InternalName].Value))
                {
                    cache.Add(row.ID);
                    return;
                }
            }
            cache.Remove(row.ID);
        }

        public static void SetAssetLocator(AssetLocator l)
        {
            AssetLocator = l;
            //ReloadParams();
        }

        private static void SaveParamsBBSekiro()
        {
            var dir = AssetLocator.GameRootDirectory;
            var mod = AssetLocator.GameModDirectory;
            if (!File.Exists($@"{dir}\\param\gameparam\gameparam.parambnd.dcx"))
            {
                MessageBox.Show("Could not find param file. Cannot save.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load params
            var param = $@"{mod}\param\gameparam\gameparam.parambnd.dcx";
            if (!File.Exists(param))
            {
                param = $@"{dir}\param\gameparam\gameparam.parambnd.dcx";
            }
            BND4 paramBnd = BND4.Read(param);

            // Replace params with edited ones
            foreach (var p in paramBnd.Files)
            {
                if (_params.ContainsKey(Path.GetFileNameWithoutExtension(p.Name)))
                {
                    p.Bytes = _params[Path.GetFileNameWithoutExtension(p.Name)].Write();
                }
            }
            Utils.WriteWithBackup(dir, mod, @"param\gameparam\gameparam.parambnd.dcx", paramBnd);
        }

        public static void SaveParams(bool loose = false)
        {
            if (_params == null)
            {
                return;
            }
            if (AssetLocator.Type == GameType.Bloodborne || AssetLocator.Type == GameType.Sekiro)
            {
                SaveParamsBBSekiro();
            }
        }
    }
}
