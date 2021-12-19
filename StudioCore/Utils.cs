//using Microsoft.Xna.Framework;
using System;
using System.Text;
using System.Numerics;
using System.IO;
using SoulsFormats;
using System.Collections.Generic;
using Microsoft.Win32;

namespace StudioCore
{
    public static class Utils
    {
        public const float Pi = (float)Math.PI;
        public const float PiOver2 = (float)Math.PI / 2.0f;
        public const float Rad2Deg = 180.0f / Pi;
        public const float Deg2Rad = Pi / 180.0f;

        public static float DegToRadians(float deg)
        {
            return deg * Pi / 180.0f;
        }

        public static float RadiansToDeg(float rad)
        {
            return rad * 180.0f / Pi;
        }

        public static float Clamp(float f, float min, float max)
        {
            if (f < min)
                return min;
            if (f > max)
                return max;
            return f;
        }

        public static float Lerp(float a, float b, float d)
        {
            return (a * (1.0f - d) + b * d);
        }

        public static bool IsPowerTwo(uint a)
        {
            if (a > 0)
            {
                while (a % 2 == 0)
                {
                    a >>= 1;
                }
                if (a == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public static System.Numerics.Matrix4x4 Inverse(this System.Numerics.Matrix4x4 src)
        {
            System.Numerics.Matrix4x4.Invert(src, out System.Numerics.Matrix4x4 result);
            return result;
        }

        private static double GetColorComponent(double temp1, double temp2, double temp3)
        {
            double num;
            temp3 = Utils.MoveIntoRange(temp3);
            if (temp3 < 0.166666666666667)
            {
                num = temp1 + (temp2 - temp1) * 6 * temp3;
            }
            else if (temp3 >= 0.5)
            {
                num = (temp3 >= 0.666666666666667 ? temp1 : temp1 + (temp2 - temp1) * (0.666666666666667 - temp3) * 6);
            }
            else
            {
                num = temp2;
            }
            return num;
        }

        private static double GetTemp2(float H, float S, float L)
        {
            double temp2;
            temp2 = ((double)L >= 0.5 ? (double)(L + S - L * S) : (double)L * (1 + (double)S));
            return temp2;
        }

        /*public static Color HSLtoRGB(float H, float S, float L)
        {
            double r = 0;
            double g = 0;
            double b = 0;
            if (L != 0f)
            {
                if (S != 0f)
                {
                    double temp2 = Utils.GetTemp2(H, S, L);
                    double temp1 = 2 * (double)L - temp2;
                    r = Utils.GetColorComponent(temp1, temp2, (double)H + 0.333333333333333);
                    g = Utils.GetColorComponent(temp1, temp2, (double)H);
                    b = Utils.GetColorComponent(temp1, temp2, (double)H - 0.333333333333333);
                }
                else
                {
                    double l = (double)L;
                    b = l;
                    g = l;
                    r = l;
                }
            }
            Color color = Color.FromNonPremultiplied(new Vector4((float)r, (float)g, (float)b, 1f));
            return color;
        }*/

        private static double MoveIntoRange(double temp3)
        {
            if (temp3 < 0)
            {
                temp3 += 1;
            }
            else if (temp3 > 1)
            {
                temp3 -= 1;
            }
            return temp3;
        }

        public static string Frankenpath(params string[] pathParts)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < pathParts.Length; i++)
            {
                sb.Append(pathParts[i].Trim('\\'));
                if (i < pathParts.Length - 1)
                    sb.Append('\\');
            }

            return sb.ToString();
        }

        public static string GetShortIngameFileName(string fileName)
        {
            return GetFileNameWithoutAnyExtensions(GetFileNameWithoutDirectoryOrExtension(fileName));
        }

        private static readonly char[] _dirSep = new char[] { '\\', '/' };
        public static string GetFileNameWithoutDirectoryOrExtension(string fileName)
        {
            if (fileName.EndsWith("\\") || fileName.EndsWith("/"))
                fileName = fileName.TrimEnd(_dirSep);

            if (fileName.Contains("\\") || fileName.Contains("/"))
                fileName = fileName.Substring(fileName.LastIndexOfAny(_dirSep) + 1);

            if (fileName.Contains("."))
                fileName = fileName.Substring(0, fileName.LastIndexOf('.'));

            return fileName;
        }

        public static string GetFileNameWithoutAnyExtensions(string fileName)
        {
            var dirSepIndex = fileName.LastIndexOfAny(_dirSep);
            if (dirSepIndex >= 0)
            {
                var dotIndex = -1;
                bool doContinue = true;
                do
                {
                    dotIndex = fileName.LastIndexOf('.');
                    doContinue = dotIndex > dirSepIndex;
                    if (doContinue)
                        fileName = fileName.Substring(0, dotIndex);
                }
                while (doContinue);
            }
            else
            {
                var dotIndex = -1;
                bool doContinue = true;
                do
                {
                    dotIndex = fileName.LastIndexOf('.');
                    doContinue = dotIndex >= 0;
                    if (doContinue)
                        fileName = fileName.Substring(0, dotIndex);
                }
                while (doContinue);
            }

            return fileName;
        }

        public static void WriteWithBackup<T>(string gamedir, string moddir, string assetpath, T item, bool ds3reg=false) where T : SoulsFile<T>, new()
        {
            var assetgamepath = $@"{gamedir}\{assetpath}";
            var assetmodpath = $@"{moddir}\{assetpath}";

            if (moddir != null)
            {
                if (!Directory.Exists(Path.GetDirectoryName(assetmodpath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(assetmodpath));
                }
            }

            // Make a backup of the original file if a mod path doesn't exist
            if (moddir == null && !File.Exists($@"{assetgamepath}.bak") && File.Exists(assetgamepath))
            {
                File.Copy(assetgamepath, $@"{assetgamepath}.bak", true);
            }

            var writepath = (moddir == null) ? assetgamepath : assetmodpath;

            try
            {
                if (File.Exists(writepath + ".temp"))
                {
                    File.Delete(writepath + ".temp");
                }
                if (ds3reg && item is BND4 bnd)
                {
                    SFUtil.EncryptDS3Regulation(writepath + ".temp", bnd);
                }
                else
                {
                    item.Write(writepath + ".temp");
                }

                if (File.Exists(writepath))
                {
                    File.Copy(writepath, writepath + ".prev", true);
                    File.Delete(writepath);
                }
                File.Move(writepath + ".temp", writepath);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error saving file: "+writepath+"\nOther files will be saved.", "Error Saving", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.None);
            }
        }

        public static void WriteStringWithBackup(string gamedir, string moddir, string assetpath, string item)
        {
            var assetgamepath = $@"{gamedir}\{assetpath}";
            var assetmodpath = $@"{moddir}\{assetpath}";

            if (moddir != null)
            {
                if (!Directory.Exists(Path.GetDirectoryName(assetmodpath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(assetmodpath));
                }
            }

            // Make a backup of the original file if a mod path doesn't exist
            if (moddir == null && !File.Exists($@"{assetgamepath}.bak") && File.Exists(assetgamepath))
            {
                File.Copy(assetgamepath, $@"{assetgamepath}.bak", true);
            }

            var writepath = (moddir == null) ? assetgamepath : assetmodpath;

            if (File.Exists(writepath + ".temp"))
            {
                File.Delete(writepath + ".temp");
            }
            File.WriteAllText(writepath + ".temp", item);

            if (File.Exists(writepath))
            {
                File.Copy(writepath, writepath + ".prev", true);
                File.Delete(writepath);
            }
            File.Move(writepath + ".temp", writepath);
        }

        private static System.Numerics.Matrix4x4 CreatePerspective(float fov, float aspectRatio, float near, float far)
        {
            if (fov <= 0.0f || fov >= Math.PI)
                throw new ArgumentOutOfRangeException(nameof(fov));

            if (near <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(near));

            if (far <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(far));

            float yScale = 1.0f / (float)Math.Tan((double)fov * 0.5f);
            float xScale = yScale / aspectRatio;

            System.Numerics.Matrix4x4 result;

            result.M11 = xScale;
            result.M12 = result.M13 = result.M14 = 0.0f;

            result.M22 = yScale;
            result.M21 = result.M23 = result.M24 = 0.0f;

            result.M31 = result.M32 = 0.0f;
            var negFarRange = float.IsPositiveInfinity(far) ? -1.0f : far / (near - far);
            result.M33 = -negFarRange;
            result.M34 = 1.0f;

            result.M41 = result.M42 = result.M44 = 0.0f;
            result.M43 = near * negFarRange;

            return result;
        }

        public static void ExtractScale(Matrix4x4 mat, out Vector3 scale, out Matrix4x4 post)
        {
            post = mat;
            var sx = new Vector3(post.M11, post.M12, post.M13).Length();
            var sy = new Vector3(post.M21, post.M22, post.M23).Length();
            var sz = new Vector3(post.M31, post.M32, post.M33).Length();
            scale = new Vector3(sx, sy, sz);
            post.M11 /= sx;
            post.M12 /= sx;
            post.M13 /= sx;
            post.M21 /= sy;
            post.M22 /= sy;
            post.M23 /= sy;
            post.M31 /= sz;
            post.M32 /= sz;
            post.M33 /= sz;
        }

        public enum RayCastCull
        {
            CullNone,
            CullFront,
            CullBack
        }


        public static void Swap(ref float a, ref float b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static bool RayPlaneIntersection(Vector3 origin,
            Vector3 direction,
            Vector3 planePoint,
            Vector3 normal,
            out float dist)
        {
            float d = Vector3.Dot(direction, normal);
            if (d == 0)
            {
                dist = float.PositiveInfinity;
                return false;
            }
            dist = Vector3.Dot(planePoint - origin, normal) / d;
            return true;
        }

        public static bool RayCylinderIntersection(Vector3 origin,
            Vector3 direction,
            Vector3 center,
            float height,
            float radius,
            out float dist)
        {
            dist = float.MaxValue;
            Vector3 torigin = origin - center;
            float a = direction.X * direction.X + direction.Z * direction.Z;
            float b = direction.X * torigin.X + direction.Z * torigin.Z;
            float c = torigin.X * torigin.X + torigin.Z * torigin.Z - radius * radius;

            float delta = b * b - a * c;

            if (delta < 0.0000001)
            {
                return false;
            }

            dist = (-b - MathF.Sqrt(delta)) / a;
            if (dist < 0.0000001)
            {
                return false;
            }

            float y = torigin.Y + dist * direction.Y;
            if (y > height || y < 0)
            {
                return false;
            }

            return true;
        }

        public static Matrix4x4 GetBoneObjectMatrix(FLVER.Bone bone, List<FLVER.Bone> bones)
        {
            var res = Matrix4x4.Identity;
            var parentBone = bone;
            do
            {
                res *= bone.ComputeLocalTransform();
                if (parentBone.ParentIndex >= 0)
                {
                    parentBone = bones[parentBone.ParentIndex];
                }
                else
                {
                    parentBone = null;
                }
            }
            while (parentBone != null);

            return res;
        }

        public static void setRegistry(string name, string value)
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey($@"Software\DSParamStudio");
            rkey.SetValue(name, value);
        }
        
        public static string readRegistry(string name)
        {
            RegistryKey rkey = Registry.CurrentUser.CreateSubKey($@"Software\DSParamStudio");
            var v = rkey.GetValue(name);
            return v == null ? null : v.ToString();
        }

        public static string ImGuiEscape(string str, string nullStr)
        {
            return str==null ? nullStr : str.Replace("#", "\xFF03"); //eastern block #
        }
    }
}