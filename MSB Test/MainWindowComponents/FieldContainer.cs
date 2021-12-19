﻿using SoulsFormats;
using StudioCore;
using StudioCore.MsbEditor;
using System;
using System.Collections.Generic;

namespace MSB_Test
{
    public partial class MainWindow
    {
        // Preconfigured values.
        bool logging = true;
        string new2000 = "";
        string new2001 = "";
        string new2002 = "";
        string new2010 = "";
        string new2011 = "";
        double HemwickChance = 100;
        double OldYharnamChance = 100;
        double CathedralWardChance = 100;
        double CentralYharnamChance = 100;
        double UpperCathedralWardChance = 60;
        double CainhurstChance = 60;
        double NightmareOfMensisChance = 100;
        double WoodsChance = 100;
        double YahargulChance = 100;
        double ByrgenwerthChance = 100;
        double FrontierChance = 100;
        double HuntersNightmareChance = 90;
        double ResearchHallChance = 30;
        double HamletChance = 100;
        int bossCount = 0;
        int totalBossesToReplace = 0;
        long paramNumber = 999999;

        Random universalRand = new Random();
        Random keyitemRand = new Random();
        int seed;

        AssetLocator assetLocator;
        ParamBank paramBank;

        ///regular maps
        private List<string> _allMaps;
        public List<string> allMaps 
        { 
            get 
            { 
                if(_allMaps == null)
                {
                    _allMaps = new List<string>();
                    _allMaps.AddRange(coreMapList);
                    _allMaps.AddRange(chaliceMapList);
                }
                return _allMaps; 
            } 
        }
        List<string> coreMapList = new List<string>();
        List<string> chaliceMapList = new List<string>();

        List<MSBB.Part.Enemy> randEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> newEnemyList = new List<MSBB.Part.Enemy>();
        List<string> enemyData = new List<string>();
        List<string> enemyDataRandomized = new List<string>();
        List<MSBB.Model.Enemy> modelList = new List<MSBB.Model.Enemy>();

        string currentDirectory;
        string parentDir;
        string filePath;

        List<long> masterList = new List<long>();
        List<long> RandList = new List<long>();
        List<PARAM.Cell> cellList = new List<PARAM.Cell>();
        List<string> cellListString = new List<string>();

        List<List<string>> listOfLists = new List<List<string>>();
        List<List<PARAM.Cell>> listOfCellLists = new List<List<PARAM.Cell>>();

        List<PARAM.Cell> paramList = new List<PARAM.Cell>();
        List<PARAM.Cell> randParamList = new List<PARAM.Cell>();


        List<int> numbersInParamToRandomize = new List<int>();
        List<int> gunsToReplace = new List<int>();
        List<string> cutEnemyString = new List<string>();
        bool cutEnemyBool;
        bool GOBAdded = false;
        int totalTime;
        int totalPercent;
        string paramPath;
        string paramDefPath;
        string currentTask;
        bool addedStoneGuyBool;
        bool permaDarknessBool;
        bool meleeMoveset;
        bool gunMoveset;
        int stoneGuyParam;
        int stoneGuyThink;
        string stoneGuyModelName;
        string tempStoneEnemyString;
        MSBB.Part.Enemy stoneGuyEnemy;
        bool addOrphan;
        bool keepGuns;
        bool bossHemwick;
        bool bossCathedralWard;
        bool bossUpperCathedralWard;
        bool bossMensis;
        bool bossYahargul;
        bool bossFrontier;
        bool bossResearchHall;
        bool bossOldYharnam;
        bool bossCentralYharnam;
        bool bossCainhurst;
        bool bossForbiddenWoods;
        bool bossByrgenwerthLecture;
        bool bossNightmare;
        bool bossHamlet;
        bool bossChalices;
        bool easyMultiBossesBool;
        bool easyFailuresBool;
        bool startingWeaponsOnlyBool;
        bool vfxBool;
        bool talkBool;
        bool bloodBool;
        bool gemBool;
        bool faceBool;
        bool sixGemBool;
        bool threeGemBool;
        bool excludeEnemiesBool;
        bool excludeBossesBool;
        bool easyRomBool;
        bool easyWitchesBool;
        bool teamTypeBool;
        bool noScalingBool;
        double sizeOfEnemy;
        string modelFilePath;
        List<long> longList2 = new List<long>();
        List<string> logList2 = new List<string>();
        List<string> unusedList = new List<string>();
        List<string> bossList = new List<string>();
        List<string> combinedBossList = new List<string>();
        List<string> combinedBossList2 = new List<string>();
        int numberOfKeyIemsRandomized;
        List<string> unusedPlusBossList = new List<string>();
        List<string> addedBosses = new List<string>();
        List<int> keyItemLots = new List<int>();
        List<int> nonoItemLots = new List<int>();
        List<int> combinedItemLotList = new List<int>();
        List<MSBB.Part.Enemy> addedEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> addedBossesList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.DummyEnemy> dummyEnemyList = new List<MSBB.Part.DummyEnemy>();
        List<string> dummyEnemyStringList = new List<string>();
        List<string> logList = new List<string>();
        List<long> maxSizeList = new List<long>();
        List<long> npcParams = new List<long>();
        List<long> longList = new List<long>();
        List<string> nameList = new List<string>();
        List<long> sizeList = new List<long>();
        List<MSBB.Part.Enemy> oopsAllEnemyList = new List<MSBB.Part.Enemy>();
        List<string> oopsAllEnemyString = new List<string>();
        string oopsBossString;
        Dictionary<string, long> namesAndSizes = new Dictionary<string, long>();
        List<MSBB.Part.Enemy> oopsAllBossList = new List<MSBB.Part.Enemy>();
        List<string> oopsAllBossString = new List<string>();
        List<string> BossListString = new List<string>();
        List<int> itemLotList = new List<int>();
        List<int> workshopItemsList = new List<int>();
        bool running;
        bool includeNPCs;
        bool shopBool;
        bool enemyDropBool;
        bool includeBosses;
        bool randomizeEnemiesBool;
        bool randomize = true;
        bool oopsAllBosses;
        bool randomizeItemLots;
        bool lesserBossesBool;
        bool bellMaidenBool;
        bool keyItemRandomizeBool;
        bool workshopBool;
        bool customScaling;
        public int dreamScale;
        public int hemwickScale;
        public int cathedralScale;
        public int upperScale;
        public int mensisScale;
        public int yahargulScale;
        public int frontierScale;
        public int researchScale;
        public int oldScale;
        public int centralScale;
        public int cainhurstScale;
        public int woodsScale;
        public int byrgenwerthScale;
        public int nightmareScale;
        public int hamletScale;
        string thisnpc;
        string thismo;
        string thisthink;
        string thisentityID;
        bool insertBossesBool;
        double bossPercentage;
        double chaliceChanceFloat;
        bool chaliceBosses;
        bool chaliceEnemies;
        List<string> chaliceEnemiesString = new List<string>();
        List<MSBB.Part.Enemy> chaliceEnemiesMSB = new List<MSBB.Part.Enemy>();
        string bossLogFilePath;
        string enemyLogFilePath;
        string sizeFilePath;
        string insertedBossPath;
        string randomizedNPCPath;
        string randomizedItemLotPath;
        string dummyFilePath;
        bool oopsAll;
        List<string> oopsAllList = new List<string>();
        string oopsAllString;
        List<string> secondaryBosses = new List<string>();
        List<string> tertiaryBosses = new List<string>();
        List<long> newNPCParam = new List<long>();
        List<long> oldNPCParam = new List<long>();
        List<string> mapsForParamChanges = new List<string>();
        List<string> chaliceBossString = new List<string>();
        List<string> newChaliceBossString = new List<string>();
        List<string> newChaliceBossString2 = new List<string>();
        List<string> npcList = new List<string>();
        List<string> hostileNpcList = new List<string>();
        List<MSBB.Part.Enemy> npcEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> chaliceBossMSB = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> newChaliceBossMSB = new List<MSBB.Part.Enemy>();
        List<string> chaliceBossParams = new List<string>();
        List<string> insertBossesString = new List<string>();
        List<MSBB.Part.Enemy> insertBossesEnemy = new List<MSBB.Part.Enemy>();
        string scaleLogFile;
        List<string> eventFileList = new List<string>();
        string OoKFirstPhase;
        MSBB.Part.Enemy OoKEnemy;
        List<string> rightHandList = new List<string>();
        List<string> leftHandList = new List<string>();
        Window1 win1 = new Window1();
    }
}
