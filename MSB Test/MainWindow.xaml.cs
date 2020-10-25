using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SoulsFormats;
using System.IO;
using System.Linq;
using System.Threading;
using System.CodeDom;
using System.ComponentModel;
using System.Security.Cryptography.Xml;
using Ookii.Dialogs.Wpf;

namespace MSB_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string new2000 = "";
        string new2001 = "";
        string new2002 = "";
        string new2010 = "";
        string new2011 = "";
        bool GOBAdded = false;
        int totalTime;
        int totalPercent;
        string paramPath;
        string paramDefPath;
        string currentTask;
        bool keepGuns;
        bool dummyEnemyBool;
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
        bool allChalices;
        string thisnpc;
        string thismo;
        string thisthink;
        string thisentityID;
        bool insertBossesBool;
        double bossPercentage;
        double chaliceChanceFloat;
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
        string chaliceMapPaths;
        bool oopsAll;
        List<string> oopsAllList = new List<string>();
        string oopsAllString;
        List<string> secondaryBosses = new List<string>();
        List<string> tertiaryBosses = new List<string>();
        int totalBossesToReplace = 0;
        List<long> newNPCParam = new List<long>();
        List<long> oldNPCParam = new List<long>();
        long paramNumber = 999999;
        List<string> mapsForParamChanges = new List<string>();
        List<string> chaliceBossString = new List<string>();
        List<string> npcList = new List<string>();
        List<string> hostileNpcList = new List<string>();
        List<MSBB.Part.Enemy> npcEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> chaliceBossMSB = new List<MSBB.Part.Enemy>();
        List<string> chaliceBossParams = new List<string>();
        List<string> insertBossesString = new List<string>();
        List<MSBB.Part.Enemy> insertBossesEnemy = new List<MSBB.Part.Enemy>();
        string scaleLogFile;
        List<string> eventFileList = new List<string>();
        string OoKFirstPhase;
        MSBB.Part.Enemy OoKEnemy;
        List<string> rightHandList = new List<string>();
        List<string> leftHandList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);

            DummyEnemyBox.IsEnabled = false;
            RandomizeKeyItemsBox.IsEnabled = false;

            /*
            HemwickCheckBox.IsChecked = true;
            CathedralWardBossBox.IsChecked = true;
            UpperCathedralBossBox.IsChecked = false;
            MensisBossBox.IsChecked = true;
            FrontierBossBox.IsChecked = true;
            YahargulBossBox.IsChecked = true;
            ResearchHallBossBox.IsChecked = false;
            OldYharnamBossBox.IsChecked = true;
            CentralYharnamBossBox.IsChecked = true;
            CainhurstBossBox.IsChecked = false;
            ByrgenwerthBossBox.IsChecked = true;
            WoodsBossBox.IsChecked = true;
            NightmareBossBox.IsChecked = true;
            HamletBossBox.IsChecked = true;
            */

            chaliceBossParams.Add("10313090");
            chaliceBossParams.Add("110304090");
            chaliceBossParams.Add("110304098");
            chaliceBossParams.Add("110304096");
            chaliceBossParams.Add("210501006");
            chaliceBossParams.Add("310501006");
            chaliceBossParams.Add("10750090");
            chaliceBossParams.Add("110216090");
            chaliceBossParams.Add("210305006");
            chaliceBossParams.Add("310305006");
            chaliceBossParams.Add("10127090");
            chaliceBossParams.Add("110313080");
            chaliceBossParams.Add("210209096");
            chaliceBossParams.Add("310209096");
            chaliceBossParams.Add("10304090");
            chaliceBossParams.Add("10304096");
            chaliceBossParams.Add("10304098");
            chaliceBossParams.Add("110313070");
            chaliceBossParams.Add("210510096");
            chaliceBossParams.Add("310509006");
            chaliceBossParams.Add("10106090");
            chaliceBossParams.Add("210305016");
            chaliceBossParams.Add("10216090");
            chaliceBossParams.Add("110501000");
            chaliceBossParams.Add("210512096");
            chaliceBossParams.Add("110209090");
            chaliceBossParams.Add("210504000");
            chaliceBossParams.Add("310504000");
            chaliceBossParams.Add("10305006");
            chaliceBossParams.Add("110509010");
            chaliceBossParams.Add("10218090");
            chaliceBossParams.Add("110504000");
            chaliceBossParams.Add("210508006");
            chaliceBossParams.Add("310504000");
            chaliceBossParams.Add("110257000");
            chaliceBossParams.Add("210251096");
            chaliceBossParams.Add("310305016");
            chaliceBossParams.Add("210306016");
            chaliceBossParams.Add("511000");

            unusedList.Add("c2120_9999");
            unusedList.Add("c2120_9998");
            unusedList.Add("c0000");
            unusedList.Add("c0");
            unusedList.Add("c1020");
            unusedList.Add("c1030");
            unusedList.Add("c1080");
            unusedList.Add("c2030");
            unusedList.Add("c2300");
            unusedList.Add("c2310");
            unusedList.Add("c2800");
            unusedList.Add("c2810");
            unusedList.Add("c2910");
            unusedList.Add("c3110");
            unusedList.Add("c4150");
            unusedList.Add("c5030");
            unusedList.Add("c5110");
            unusedList.Add("c5140");
            unusedList.Add("c5150");
            unusedList.Add("c5400");
            unusedList.Add("c5420");
            unusedList.Add("c5500");
            unusedList.Add("c5501");
            unusedList.Add("c5502");
            unusedList.Add("c5520");
            unusedList.Add("c5521");
            unusedList.Add("c5522");
            unusedList.Add("c7000");
            unusedList.Add("c7010");
            unusedList.Add("c7100");
            unusedList.Add("c8010");
            unusedList.Add("c8020");
            unusedList.Add("c2501");
            unusedList.Add("c90");
            unusedList.Add("c9030");
            unusedList.Add("c2501");
            unusedList.Add("c2571");
            unusedList.Add("c8030_0000");
            unusedList.Add("c8040_0000");
            unusedList.Add("c9020_0000");
            unusedList.Add("c9020_0001");
            unusedList.Add("c9020_0002");
            unusedList.Add("c9020_0003");
            unusedList.Add("c8030_0000");
            unusedList.Add("c5072_0000");
            unusedList.Add("c4023_0000");
            unusedList.Add("c4160_0000");
            unusedList.Add("c4160_0001");
            unusedList.Add("c4160_0002");
            unusedList.Add("c4160_0003");
            unusedList.Add("c4550_0000");
            unusedList.Add("c7110_0000");
            unusedList.Add("c5071_0000");
            unusedList.Add("c4511_0000");
            unusedList.Add("c5510_0001");
            unusedList.Add("c5510_0002");
            unusedList.Add("c4540_0000");
            unusedList.Add("c4543_0000");
            unusedList.Add("c8070_0000");
            unusedList.Add("c5130_0000");
            unusedList.Add("c4031_0000");
            unusedList.Add("c4520_0000");

            bossList.Add("5090");
            bossList.Add("c2090_0003");
            bossList.Add("c2100_0000");
            bossList.Add("c2100_0001");
            bossList.Add("c2120_0000");
            bossList.Add("c2120_0001");
            bossList.Add("c2120_0002");
            bossList.Add("c2320_0000");
            bossList.Add("c2500_0000");
            bossList.Add("c2570_0001");
            bossList.Add("c2510_0000");
            bossList.Add("c2710_0000");
            bossList.Add("c2720_0000");
            bossList.Add("c4520_0002");
            bossList.Add("c4030_0000");
            bossList.Add("c4030_0001");
            bossList.Add("c4030_0002");
            bossList.Add("c4030_0003");
            bossList.Add("c4030_0004");
            bossList.Add("c4500_0000");
            bossList.Add("c4510_0000");
            bossList.Add("c4540_0000");
            bossList.Add("c4541_0000");
            bossList.Add("c5000_0000");
            bossList.Add("c5020_0000");
            bossList.Add("c5070_0000");
            bossList.Add("c5080_0000");
            bossList.Add("c5100_0000");
            bossList.Add("c5120_0001");
            bossList.Add("c5400_0000");
            bossList.Add("c5510_0000");
            bossList.Add("c8050_0000");
            bossList.Add("c3130_0000");
            bossList.Add("c5010_0000");
            bossList.Add("c4510_0002");
            bossList.Add("c3050_0000");
            bossList.Add("c3060_0000");
            bossList.Add("c5110");


            for (int i = 0; i < unusedList.Count; i ++)
            {
                unusedPlusBossList.Add(unusedList[i]);
            }
            for(int i = 0; i < bossList.Count; i ++)
            {
                unusedPlusBossList.Add(bossList[i]);
            }
        }

        string currentDirectory;
        string filePath;


        ///regular maps
        List<string> mapList = new List<string>();

        List<MSBB.Part.Enemy> randEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> newEnemyList = new List<MSBB.Part.Enemy>();
        List<string> enemyData = new List<string>();
        List<string> enemyDataRandomized = new List<string>();
        List<MSBB.Model.Enemy> modelList = new List<MSBB.Model.Enemy>();

        private void ParamScalingForBosses(string currentMap)
        {
            var tempMap = MSBB.Read(currentMap);
            
            List<int> npcParamPositions = new List<int>();
            for(int i = 0; i < npcParams.Count; i ++)
            {
                for(int j = 0; j < longList.Count; j ++)
                {
                    if(npcParams[i] == longList[j])
                    {
                        npcParamPositions.Add(j);
                    }
                }
            }

            //int position = 0;

            //m21_00 Hunter's Dream														 7021 7022
            //m21_01 Abandoned Old Workshop
            //m22_00 Hemwick Charnel Lane                                                7008
            //m23_00 Old Yharnam                                                         7004
            //m24_00 Cathedral Ward                                                      7006 7023 7024
            //m24_01 Central Yharnam, Iosefka's Clinic									 7001 7002 7003
            //m24_02 Upper Cathedral Ward, Healing Church Workshop, Altar of Despair     7007 7016 7017
            //m25_00 Forsaken Castle Cainhurst                                           7014
            //m26_00 Nightmare of Mensis                                                 7019 7020
            //m27_00 Forbidden Woods                                                     7010
            //m28_00 Yahar'gul, Unseen Village											 7009 7015
            //m32_00 Byrgenwerth, Lecture Building, Moonside Lake                        7013
            //m33_00 Nightmare Frontier                                                  7011
            //m34_00 Hunter's Nightmare													 7480 7481 7484
            //m35_00 Research Hall                                                       7482 7483 7487
            //m36_00 Fishing Hamlet                                                      7485
            //
            //7001 1
            //7002 2
            //7003 3
            //7004 4
            //7006 5
            //7007 6
            //7008 7
            //7009 8
            //7010 9
            //7011 10
            //7013 11
            //7014 12
            //7015 13
            //7016 14
            //7016 15
            //7017 16
            //7019 17
            //7020 18
            //7021 19
            //7022 20
            //7023 21
            //7024 22
            //7480 23
            //7481 24
            //7482 25
            //7483 26
            //7483 27
            //7484 28
            //7485 29
            //7486 30
            //7487 31
            using (StreamWriter writetext = File.AppendText(scaleLogFile))
            {
                writetext.WriteLine(currentMap);
            }
            for (int i = 0; i < npcParamPositions.Count; i ++)
            {
                for(int j = 0; j < tempMap.Parts.Enemies.Count; j ++)
                {
                    if(tempMap.Parts.Enemies[j].NPCParamID == longList[npcParamPositions[i]])
                    {
                        using (StreamWriter writetext = File.AppendText(scaleLogFile))
                        {
                            writetext.WriteLine(tempMap.Parts.Enemies[j].NPCParamID);
                        }
                        //filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx"
                        if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 20;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx")
                        {
                            
                        }
                        //filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 7;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 4;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 21;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 1;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 14;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 12;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 17;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 9;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 13;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 11;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 10;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 24;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 27;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 29;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //CHALICE SCALING
                        //filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 1;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7001
                        //filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 1;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7003
                        //filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 2;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7004
                        //filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 2;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7006
                        //filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 3;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7006
                        //filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 4;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7007
                        //filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 4;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7008
                        //filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 5;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7009
                        //filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 6;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7010
                        //filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 6;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7011
                        //filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 7;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7013
                        //filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 7;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7014
                        //filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 8;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7016
                        //filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 8;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7017
                        //filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 9;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7019
                        //filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 9;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7020
                        //filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 10;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7021
                        //filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx");
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + 10;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempUInt);
                            }
                        }
                        //7023
                    }
                }
            }

            tempMap.Write(currentMap);
        }

        private void GenerateEnemyList(string currentMap, List<string> noNoList)
        {
            string enemyEntityID;

                Random rand = new Random();

                var tempGUY = MSBB.Read(currentMap);

                List<MSBB.Part.Enemy> tempList = new List<MSBB.Part.Enemy>();

                bool addEnemy;

                for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                {
                    addEnemy = true;

                    if (!oopsAll)
                    {
                        for (int j = 0; j < noNoList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(noNoList[j]))
                            {
                                addEnemy = false;
                                j = noNoList.Count + 1;
                            }
                            else if(tempGUY.Parts.Enemies[i].ThinkParamID <= 1)
                            {
                                addEnemy = false;
                                j = noNoList.Count + 1;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID <= 1)
                            {
                                addEnemy = false;
                                j = noNoList.Count + 1;
                            }
                        }

                        if (currentMap.Contains("m29"))
                        {
                            for (int j = 0; j < chaliceBossParams.Count; j++)
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[j])
                                {
                                    addEnemy = false;
                                }
                            }
                        }

                        if (addEnemy)
                        {
                            if (randomize)
                            {
                                if (!tempList.Contains(tempGUY.Parts.Enemies[i]))
                                {
                                    if (tempGUY.Parts.Enemies[i].Name.Contains("c1110_0000"))
                                    {
                                        if (tempGUY.Parts.Enemies[i].TalkID != 111010)
                                        {
                                            bool add = true;

                                            for (int n = 0; n < tempList.Count; n++)
                                            {
                                                if (tempGUY.Parts.Enemies[i].NPCParamID == tempList[n].NPCParamID)
                                                {
                                                    add = false;
                                                }
                                            }
                                            if (add)
                                            {
                                                if (currentMap.Contains("m29"))
                                                {
                                                    chaliceEnemiesMSB.Add(tempGUY.Parts.Enemies[i]);
                                                    addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                                }
                                                else
                                                {
                                                    tempList.Add(tempGUY.Parts.Enemies[i]);
                                                    addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        bool add = true;

                                        for (int n = 0; n < tempList.Count; n++)
                                        {
                                            if (tempGUY.Parts.Enemies[i].NPCParamID == tempList[n].NPCParamID)
                                            {
                                                add = false;
                                            }
                                        }

                                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2561"))
                                    {
                                        add = false;
                                    }

                                    if (add)
                                        {
                                            if (currentMap.Contains("m29"))
                                            {
                                                chaliceEnemiesMSB.Add(tempGUY.Parts.Enemies[i]);
                                                addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                            }
                                            else
                                            {
                                                tempList.Add(tempGUY.Parts.Enemies[i]);
                                                addedEnemyList.Add(tempGUY.Parts.Enemies[i]);
                                                enemyEntityID = tempGUY.Parts.Enemies[i].EntityID.ToString();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            if (!oopsAll)
            {
                for (int i = 0; i < tempList.Count; i++)
                {
                    string tempString = tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName;
                    ////ShowText.Text += tempString;
                    if (tempList[i].ThinkParamID.ToString() != "1")
                    {
                        enemyData.Add(tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName);

                    }
                }
                if (chaliceEnemies)
                {
                    chaliceEnemiesString.Add("110123000*123000*c1230");
                }
                for (int i = 0; i < chaliceEnemiesMSB.Count; i++)
                {
                    string tempString = chaliceEnemiesMSB[i].NPCParamID.ToString() + "*" + chaliceEnemiesMSB[i].ThinkParamID.ToString() + "*" + chaliceEnemiesMSB[i].ModelName;
                    ////ShowText.Text += tempString;
                    if (chaliceEnemiesMSB[i].ThinkParamID.ToString() != "1")
                    {
                        chaliceEnemiesString.Add(chaliceEnemiesMSB[i].NPCParamID.ToString() + "*" + chaliceEnemiesMSB[i].ThinkParamID.ToString() + "*" + chaliceEnemiesMSB[i].ModelName);

                    }
                }
            }
        }

        

        private void OopsAll(string currentMap)
        {
            var tempMap = MSBB.Read(currentMap);

            for(int i = 0; i < tempMap.Parts.Enemies.Count; i ++)
            {
                for (int j = 0; j < oopsAllList.Count; j++)
                {
                    if (tempMap.Parts.Enemies[i].Name.Contains(oopsAllList[j]))
                    {
                        oopsAllEnemyList.Add(tempMap.Parts.Enemies[i]);
                    }
                }
            }
        }

        private void OopsAllBoss(string currentMap)
        {
            var tempMap = MSBB.Read(currentMap);

            for (int i = 0; i < tempMap.Parts.Enemies.Count; i++)
            {
                for (int j = 0; j < oopsAllBossString.Count; j++)
                {
                    if (tempMap.Parts.Enemies[i].Name.Contains(oopsAllBossString[j]))
                    {
                        oopsAllBossList.Add(tempMap.Parts.Enemies[i]);
                    }
                }
            }
        }

        private void DoSomething2()
        {
            running = true;

            while(running)
            {
                Thread.Sleep(1000);
                totalTime += 1;

                var span = new TimeSpan(0, 0, totalTime);
                var yourStr = string.Format("{0}:{1:00}", (int)span.TotalMinutes, span.Seconds);

                this.Dispatcher.Invoke(() =>
                {
                    TotalTime.Content = yourStr;
                });
            }
        }

        private void DoSomething()
        {
            this.Dispatcher.Invoke(() =>
            {
                if (ChaliceBossBox.IsChecked == true)
                {
                    bossChalices = true;
                }
                else bossChalices = false;

                if (HamletBossBox.IsChecked == true)
                {
                    bossHamlet = true;
                }
                else bossHamlet = false;

                if (NightmareBossBox.IsChecked == true)
                {
                    bossNightmare = true;
                }
                else bossNightmare = false;

                if (WoodsBossBox.IsChecked == true)
                {
                    bossForbiddenWoods = true;
                }
                else bossForbiddenWoods = false;

                if (ByrgenwerthBossBox.IsChecked == true)
                {
                    bossByrgenwerthLecture = true;
                }
                else bossByrgenwerthLecture = false;

                if (CainhurstBossBox.IsChecked == true)
                {
                    bossCainhurst = true;
                }
                else bossCainhurst = false;

                if (CentralYharnamBossBox.IsChecked == true)
                {
                    bossCentralYharnam = true;
                }
                else bossCentralYharnam = false;

                if (OldYharnamBossBox.IsChecked == true)
                {
                    bossOldYharnam = true;
                }
                else bossOldYharnam = false;

                if (ResearchHallBossBox.IsChecked == true)
                {
                    bossResearchHall = true;
                }
                else bossResearchHall = false;

                if (YahargulBossBox.IsChecked == true)
                {
                    bossYahargul = true;
                }
                else bossYahargul = false;

                if (FrontierBossBox.IsChecked == true)
                {
                    bossFrontier = true;
                }
                else bossFrontier = false;

                if (MensisBossBox.IsChecked == true)
                {
                    bossMensis = true;
                }
                else bossMensis = false;

                if (UpperCathedralBossBox.IsChecked == true)
                {
                    bossUpperCathedralWard = true;
                }
                else bossUpperCathedralWard = false;

                if (CathedralWardBossBox.IsChecked == true)
                {
                    bossCathedralWard = true;
                }
                else bossCathedralWard = false;

                if (HemwickCheckBox.IsChecked == true)
                {
                    bossHemwick = true;
                }
                else bossHemwick = false;

                if (DummyEnemyBox.IsChecked == true)
                {
                    dummyEnemyBool = true;
                }
                else dummyEnemyBool = false;

                if (KeepGunsBox.IsChecked == true)
                {
                    keepGuns = true;
                }
                else keepGuns = false;

                if (ArmorRandomizerCheckBox.IsChecked == true)
                {
                    randomizeItemLots = true;
                }
                else randomizeItemLots = false;

                if (AddNPCS.IsChecked == true)
                {
                    includeNPCs = true;
                }
                else includeNPCs = false;

                if (RandomizeEnemiesCheck.IsChecked == true)
                {
                    randomizeEnemiesBool = true;
                }
                else randomizeEnemiesBool = false;

                if (OopsAllBossesCheck.IsChecked == true)
                {
                    oopsAllBosses = true;
                }
                else
                {
                    oopsAllBosses = false;
                }

                if (BossCheckBox.IsChecked == true)
                {
                    includeBosses = true;
                    chaliceBosses = true;
                }
                else includeBosses = false;

                if (OopsAllCheck.IsChecked == true)
                {
                    oopsAll = true;
                }
                else oopsAll = false;

                if (InsertBosses.IsChecked == true)
                {
                    insertBossesBool = true;
                }
                else insertBossesBool = false;

                if (ChaliceEnemies.IsChecked == true)
                {
                    chaliceEnemies = true;
                }
                else chaliceEnemies = false;

                if (BellMaidenBox.IsChecked == true)
                {
                    bellMaidenBool = true;
                }
                else bellMaidenBool = false;

                if (LesserBossesBox.IsChecked == true)
                {
                    lesserBossesBool = true;
                }
                else lesserBossesBool = false;

                if (RandomizeKeyItemsBox.IsChecked == true)
                {
                    keyItemRandomizeBool = true;
                }
                else keyItemRandomizeBool = false;

                if (RandomizeShopBox.IsChecked == true)
                {
                    shopBool = true;
                }
                else shopBool = false;

                if (EnemyDropBox.IsChecked == true)
                {
                    enemyDropBool = true;
                }
                else enemyDropBool = false;

                if (WorkshopBox.IsChecked == true)
                {
                    workshopBool = true;
                }
                else workshopBool = false;

                TEST.IsEnabled = false;
                RandomizeEnemiesCheck.IsEnabled = false;
                BossCheckBox.IsEnabled = false;
                InsertBosses.IsEnabled = false;
                ChaliceBoss.IsEnabled = false;
                ChaliceEnemies.IsEnabled = false;
                ArmorRandomizerCheckBox.IsEnabled = false;
                AddNPCS.IsEnabled = false;
                OopsAllCheck.IsEnabled = false;
                OopsAllBossesCheck.IsEnabled = false;
                OopsAllStringName.IsEnabled = false;
                OopsBoss.IsEnabled = false;
                BellMaidenBox.IsEnabled = false;
                LesserBossesBox.IsEnabled = false;
                RandomizeKeyItemsBox.IsEnabled = false;
                RandomizeShopBox.IsEnabled = false;
                EnemyDropBox.IsEnabled = false;
                WorkshopBox.IsEnabled = false;

                BossDownTen.IsEnabled = false;
                BossUpOne.IsEnabled = false;
                BossUpPointOne.IsEnabled = false;
                BossUpTen.IsEnabled = false;
                BossUpOne_Copy.IsEnabled = false;
                BossUpPointOne_Copy.IsEnabled = false;

                HCDT.IsEnabled = false;
                HCDO.IsEnabled = false;
                HCDPO.IsEnabled = false;
                HCUPO.IsEnabled = false;
                HCUO.IsEnabled = false;
                HCUT.IsEnabled = false;

                CWDT.IsEnabled = false;
                CWDO.IsEnabled = false;
                CWDPO.IsEnabled = false;
                CWUPO.IsEnabled = false;
                CWUO.IsEnabled = false;
                CWUT.IsEnabled = false;

                UCDT.IsEnabled = false;
                UCDO.IsEnabled = false;
                UCDPO.IsEnabled = false;
                UCUPO.IsEnabled = false;
                UCUO.IsEnabled = false;
                UCUT.IsEnabled = false;

                MDT.IsEnabled = false;
                MDO.IsEnabled = false;
                MDPO.IsEnabled = false;
                MUPO.IsEnabled = false;
                MUO.IsEnabled = false;
                MUT.IsEnabled = false;

                YDT.IsEnabled = false;
                YDO.IsEnabled = false;
                YDPO.IsEnabled = false;
                YUPO.IsEnabled = false;
                YUO.IsEnabled = false;
                YUT.IsEnabled = false;

                FDT.IsEnabled = false;
                FDO.IsEnabled = false;
                FDPO.IsEnabled = false;
                FUPO.IsEnabled = false;
                FUO.IsEnabled = false;
                FUT.IsEnabled = false;

                OYDT.IsEnabled = false;
                OYDO.IsEnabled = false;
                OYDPO.IsEnabled = false;
                OYUPO.IsEnabled = false;
                OYUO.IsEnabled = false;
                OYUT.IsEnabled = false;

                CYDT.IsEnabled = false;
                CYDO.IsEnabled = false;
                CYDPO.IsEnabled = false;
                CYUPO.IsEnabled = false;
                CYUO.IsEnabled = false;
                CYUT.IsEnabled = false;

                CDT.IsEnabled = false;
                CDO.IsEnabled = false;
                CDPO.IsEnabled = false;
                CUPO.IsEnabled = false;
                CUO.IsEnabled = false;
                CUT.IsEnabled = false;

                WDT.IsEnabled = false;
                WDO.IsEnabled = false;
                WDPO.IsEnabled = false;
                WUPO.IsEnabled = false;
                WUO.IsEnabled = false;
                WUT.IsEnabled = false;

                BDT.IsEnabled = false;
                BDO.IsEnabled = false;
                BDPO.IsEnabled = false;
                BUPO.IsEnabled = false;
                BUO.IsEnabled = false;
                BUT.IsEnabled = false;

                HDT.IsEnabled = false;
                HDO.IsEnabled = false;
                HDPO.IsEnabled = false;
                HUPO.IsEnabled = false;
                HUO.IsEnabled = false;
                HUT.IsEnabled = false;

                FHDT.IsEnabled = false;
                FHDO.IsEnabled = false;
                FHDPO.IsEnabled = false;
                FHUPO.IsEnabled = false;
                FHUO.IsEnabled = false;
                FHUT.IsEnabled = false;

                RDT.IsEnabled = false;
                RDO.IsEnabled = false;
                RDPO.IsEnabled = false;
                RUPO.IsEnabled = false;
                RUO.IsEnabled = false;
                RUT.IsEnabled = false;

                ChaliceUpOne.IsEnabled = false;
                ChaliceUpPointOne.IsEnabled = false;
                ChaliceUpTen.IsEnabled = false;
                ChaliceUpOne_Copy.IsEnabled = false;
                ChaliceUpPointOne_Copy.IsEnabled = false;
                ChaliceDownTen.IsEnabled = false;
            });

            if (bellMaidenBool)
            {
                unusedPlusBossList.Add("c1050");
                unusedPlusBossList.Add("c1051");
                unusedPlusBossList.Add("c1055");
            }

            currentDirectory = Directory.GetCurrentDirectory();
            var parentDir = Directory.GetParent(currentDirectory);
            filePath = parentDir + "\\dvdroot_ps4";

            var logFile = File.ReadAllLines(filePath + "\\Mod Files\\NPC Scaling File\\NPCScalingFile.txt");
            logList = new List<string>(logFile);

            longList = new List<long>();
            for (int i = 0; i < logList.Count; i++)
            {
                longList.Add(long.Parse(logList[i]));
            }

            var loggFile = File.ReadAllLines(filePath + "\\Mod Files\\NPC Scaling File\\NPCParamsFile.txt");
            logList = new List<string>(loggFile);

            npcParams = new List<long>();
            for (int i = 0; i < logList.Count; i++)
            {
                npcParams.Add(long.Parse(logList[i]));
            }

            var nameFile = File.ReadAllLines(filePath + "\\Mod Files\\NPC Scaling File\\Names.txt");
            for (int i = 0; i < nameFile.Length; i++)
            {
                nameList.Add(nameFile[i]);
            }

            var sizeFile = File.ReadAllLines(filePath + "\\Mod Files\\NPC Scaling File\\Sizes.txt");
            for (int i = 0; i < sizeFile.Length; i++)
            {
                sizeList.Add(long.Parse(sizeFile[i]));
            }

            for (int i = 0; i < nameList.Count; i++)
            {
                namesAndSizes.Add(nameList[i], sizeList[i]);
            }

            mapList = new List<string>();

            this.Dispatcher.Invoke(() =>
            {
                totalPercent = 5;
                currentTask = "Backing up Files...";
                UpdateUI();
            });

            mapList.Add(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx");

            if (File.Exists(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx"))
            {
                mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx");
                GOBAdded = true;
            }

            eventFileList.Add(filePath + "\\event\\m21_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m21_01_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m22_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m23_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m24_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m24_01_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m24_02_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m25_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m26_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m27_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m28_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m32_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m33_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m34_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m35_00_00_00.emevd.dcx");
            eventFileList.Add(filePath + "\\event\\m36_00_00_00.emevd.dcx");

            string dateNowww = DateTime.Now.ToString("h:mm:ss tt");
            string buttsss = dateNowww.Replace(":", "-");
            sizeFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + buttsss + "-EnemySizes.txt";
            using (FileStream sw1 = File.Create(sizeFilePath))
            {

            }

            string dateNowwww = DateTime.Now.ToString("h:mm:ss tt");
            string buttssss = dateNowwww.Replace(":", "-");
            insertedBossPath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + buttssss + "-InsertedBossesLog.txt";
            using (FileStream sw1 = File.Create(insertedBossPath))
            {

            }

            string dateNowwwww = DateTime.Now.ToString("h:mm:ss tt");
            string buttsssss = dateNowwwww.Replace(":", "-");
            randomizedNPCPath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + buttsssss + "-RandomizedNPCLog.txt";
            using (FileStream sw1 = File.Create(randomizedNPCPath))
            {

            }

            string dateNowwwwww = DateTime.Now.ToString("h:mm:ss tt");
            string buttssssss = dateNowwwwww.Replace(":", "-");
            randomizedItemLotPath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + buttssssss + "-RandomizedItemLog.txt";
            using (FileStream sw1 = File.Create(randomizedItemLotPath))
            {

            }

            for (int i = 0; i < mapList.Count; i++)
            {
                if (File.Exists(mapList[i] + ".bak"))
                {
                    var tempMapRead = MSBB.Read(mapList[i] + ".bak");

                    long maxSizeLong = 0;

                    for (int j = 0; j < tempMapRead.Parts.Enemies.Count; j++)
                    {
                        for (int k = 0; k < nameList.Count; k++)
                        {
                            if (tempMapRead.Parts.Enemies[j].ModelName.Contains(nameList[k]))
                            {
                                maxSizeLong += sizeList[k];
                                k = nameList.Count + 1;
                            }
                        }
                    }

                    //maxSizeList.Add(maxSizeLong);

                    using (StreamWriter writetext = File.AppendText(sizeFilePath))
                    {
                        //writetext.WriteLine("MAX SIZE " + mapList[i] + " " + maxSizeLong + " " + tempMapRead.Parts.Enemies.Count);
                    }
                }
            }

            paramPath = filePath + "\\param\\gameparam\\gameparam.parambnd.dcx";
            paramDefPath = filePath + "\\paramdef\\paramdef.paramdefbnd.dcx";

            if (File.Exists(paramPath + ".bak"))
            {
                File.Delete(paramPath);
                File.Copy(paramPath + ".bak", paramPath);
            }

            if (File.Exists(paramPath + ".bak"))
            {
                File.Delete(paramPath + ".bak");
            }
            File.Copy(paramPath, paramPath + ".bak");

            if (File.Exists(eventFileList[0] + ".bak"))
            {
                for (int i = 0; i < eventFileList.Count; i++)
                {
                    File.Delete(eventFileList[i]);
                }

                for (int i = 0; i < eventFileList.Count; i++)
                {
                    File.Copy(eventFileList[i] + ".bak", eventFileList[i]);
                    File.Delete(eventFileList[i] + ".bak");
                }
            }

            for (int i = 0; i < eventFileList.Count; i++)
            {
                File.Copy(eventFileList[i], eventFileList[i] + ".bak");
            }

            List<string> tempDirList = new List<string>();
            List<string> chaliceMapListString = new List<string>();

            //if(seedString == "" || seedString == "Insert Seed.... Numbers Only")
            Random rand = new Random();

            for(int i = 0; i < mapList.Count; i ++)
            {
                if(!File.Exists(mapList[i] + ".bak"))
                {
                    File.Copy(mapList[i], mapList[i] + ".bak");
                }

                else if(File.Exists(mapList[i] + ".bak"))
                {
                    File.Delete(mapList[i]);
                    File.Copy(mapList[i] + ".bak", mapList[i]);
                }
            }

            /*
            if (File.Exists(mapList[0] + ".bak"))
            {
                for (int i = 0; i < mapList.Count; i++)
                {
                    File.Delete(mapList[i]);
                }

                for (int i = 0; i < mapList.Count; i++)
                {
                    File.Copy(mapList[i] + ".bak", mapList[i]);
                    File.Delete(mapList[i] + ".bak");
                }
            }

            for (int i = 0; i < mapList.Count; i++)
            {
                File.Copy(mapList[i], mapList[i] + ".bak");
            }
            */
            string dateNo = DateTime.Now.ToString("h:mm:ss tt");
            string butt = dateNo.Replace(":", "-");
            modelFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + butt + "-ModelLog.txt";
            using (FileStream sw = File.Create(modelFilePath))
            {

            }

            //setting models in list to paste into all maps
            for (int i = 0; i < mapList.Count; i++)
            {
                var tempAss = MSBB.Read(mapList[i]);

                for (int j = 0; j < tempAss.Models.Enemies.Count; j++)
                {
                    modelList.Add(tempAss.Models.Enemies[j]);
                }
            }

            var tempMap = MSBB.Read(filePath + "\\map\\mapstudio\\" + "\\m29_52_01_00\\m29_52_01_91.msb.dcx");

            for (int i = 0; i < tempMap.Models.Enemies.Count; i++)
            {
                modelList.Add(tempMap.Models.Enemies[i]);
            }

            for(int i = 0; i < modelList.Count; i ++)
            {
                using (StreamWriter writetext = File.AppendText(modelFilePath))
                {
                    //writetext.WriteLine("NAME " + modelList[i].Name);
                    //writetext.WriteLine("PLCH " + modelList[i].Placeholder);
                }
            }

            for (int i = 0; i < mapList.Count; i++)
            {
                var tempAss = MSBB.Read(mapList[i]);

                for (int j = 0; j < modelList.Count; j++)
                {
                    if (!tempAss.Models.Enemies.Contains(modelList[j]))
                    {
                        tempAss.Models.Enemies.Add(modelList[j]);
                    }
                }

                tempAss.Write(mapList[i]);
            }

            if (oopsAll)
            {

                if (oopsAllString.Length > 5)
                {
                    string tempOopsString = oopsAllString.Replace(" ", "");
                    int totalStrings = tempOopsString.Length / 5;
                    int startingNumber = 0;
                    for (int i = 0; i < totalStrings; i++)
                    {
                        oopsAllList.Add(tempOopsString.Substring(startingNumber, 5));
                        startingNumber = startingNumber + 5;
                    }
                }
                else if (oopsAllString.Length == 5)
                {
                    oopsAllList.Add(oopsAllString);
                }

                oopsAllEnemyList = new List<MSBB.Part.Enemy>();

                for (int i = 0; i < mapList.Count; i++)
                {
                    OopsAll(mapList[i]);
                }


                for (int i = 0; i < oopsAllEnemyList.Count; i++)
                {
                    string tempString = oopsAllEnemyList[i].NPCParamID.ToString() + "*" + oopsAllEnemyList[i].ThinkParamID.ToString() + "*" + oopsAllEnemyList[i].ModelName;
                    if (oopsAllEnemyList[i].ThinkParamID.ToString() != "1")
                    {
                        oopsAllEnemyString.Add(oopsAllEnemyList[i].NPCParamID.ToString() + "*" + oopsAllEnemyList[i].ThinkParamID.ToString() + "*" + oopsAllEnemyList[i].ModelName);

                    }
                }
                if (oopsAllString.Contains("c1230"))
                {
                    oopsAllEnemyString.Add("110123000*123000*c1230");
                }
            }

            if (oopsAllBosses)
            {
                if (oopsBossString.Length > 5)
                {
                    string tempOopsString = oopsBossString.Replace(" ", "");
                    int totalStrings = tempOopsString.Length / 5;
                    int startingNumber = 0;
                    for (int i = 0; i < totalStrings; i++)
                    {
                        oopsAllBossString.Add(tempOopsString.Substring(startingNumber, 5));
                        startingNumber = startingNumber + 5;
                    }
                }
                else if (oopsBossString.Length == 5)
                {
                    oopsAllBossString.Add(oopsBossString);
                }

                oopsAllBossList = new List<MSBB.Part.Enemy>();

                for (int i = 0; i < mapList.Count; i++)
                {
                    OopsAllBoss(mapList[i]);
                }

                for (int i = 0; i < oopsAllBossList.Count; i++)
                {
                    string tempString = oopsAllBossList[i].NPCParamID.ToString() + "*" + oopsAllBossList[i].ThinkParamID.ToString() + "*" + oopsAllBossList[i].ModelName;
                    if (oopsAllBossList[i].ThinkParamID.ToString() != "1")
                    {
                        BossListString.Add(oopsAllBossList[i].NPCParamID.ToString() + "*" + oopsAllBossList[i].ThinkParamID.ToString() + "*" + oopsAllBossList[i].ModelName);

                    }
                }

                if (oopsBossString.Contains("c1230"))
                {
                    BossListString.Add("110123000*123000*c1230");
                }
            }

            if (!oopsAll)
            {
                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 15;
                    currentTask = "Generating Enemy List...";
                    UpdateUI();
                });

                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
                if (chaliceEnemies)
                {
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", nonoList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuff(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", nonoList);
                    /*
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_00.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_33.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_36.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_45.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_99.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_01_02_00\\m29_01_02_03.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_01_99_00\\m29_01_99_99.msb.dcx", unusedPlusBossList);
                    GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_09_00_00\\m29_09_00_00.msb.dcx", unusedPlusBossList);
                    */
                    if (GOBAdded)
                    {
                        GenerateEnemyList(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx", unusedPlusBossList);
                    }
                }

                if (randomizeEnemiesBool)
                {
                    while (enemyData.Count > 0)
                    {
                        int index = rand.Next(0, enemyData.Count);
                        enemyDataRandomized.Add(enemyData[index]);
                        enemyData.RemoveAt(index);
                    }

                    List<string> uniqueEnemyList = enemyDataRandomized.Distinct().ToList();
                    enemyDataRandomized = new List<string>();

                    for (int i = 0; i < uniqueEnemyList.Count; i++)
                    {
                        enemyDataRandomized.Add(uniqueEnemyList[i]);
                    }

                    if (chaliceEnemies)
                    {
                        List<string> uniqueEnemyListc = chaliceEnemiesString.Distinct().ToList();
                        chaliceEnemiesString = new List<string>();

                        for (int i = 0; i < uniqueEnemyList.Count; i++)
                        {
                            chaliceEnemiesString.Add(uniqueEnemyListc[i]);
                        }
                    }
                }
            }

            string dateNow = DateTime.Now.ToString("h:mm:ss tt");
            string butts = dateNow.Replace(":", "-");
            enemyLogFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + butts + "-EnemyLog.txt";
            using (FileStream sw1 = File.Create(enemyLogFilePath))
            {

            }

            this.Dispatcher.Invoke(() =>
            {
                totalPercent = 25;
                currentTask = "Randomizing Enemies...";
                UpdateUI();
            });

            Randomize(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
            Randomize(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
            if (chaliceEnemies && randomizeEnemiesBool || oopsAll)
            {
                
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                //(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", unusedPlusBossList);
                //Randomize(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", nonoList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", unusedPlusBossList);
                /*
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_00.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_33.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_36.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_45.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_01_00_00\\m29_01_00_99.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_01_02_00\\m29_01_02_03.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_01_99_00\\m29_01_99_99.msb.dcx", unusedPlusBossList);
                Randomize(filePath + "\\map\\mapstudio\\" + "m29_09_00_00\\m29_09_00_00.msb.dcx", unusedPlusBossList);
                */
                
                if (GOBAdded)
                {
                    Randomize(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx", unusedPlusBossList);
                }

            }

                enemyData = new List<string>();
                enemyDataRandomized = new List<string>();

            if (!oopsAll)
            {
                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 35;
                    currentTask = "Generating Boss List...";
                    UpdateUI();
                });

                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", nonoList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", nonoList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                GenerateBossList(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
                if (chaliceBosses)
                {
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", nonoList);
                    GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", unusedPlusBossList);
                    //DoStuffBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", nonoList);
                    if (GOBAdded)
                    {
                        GenerateBossList(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx", unusedPlusBossList);
                    }
                }


                chaliceBossParams.Add("210306015");

                List<string> uniqueEnemyList = enemyData.Distinct().ToList();
                enemyData = new List<string>();

                for (int i = 0; i < uniqueEnemyList.Count; i++)
                {
                    enemyData.Add(uniqueEnemyList[i]);
                }

                List<string> uniqueEnemyList2 = chaliceBossString.Distinct().ToList();
                chaliceBossString = new List<string>();

                for (int i = 0; i < uniqueEnemyList2.Count; i++)
                {
                    chaliceBossString.Add(uniqueEnemyList2[i]);
                }

                if (includeBosses)
                {
                    for (int i = 0; i < enemyData.Count; i++)
                    {
                        secondaryBosses.Add(enemyData[i]);
                        tertiaryBosses.Add(enemyData[i]);
                    }

                    if (chaliceBosses)
                    {
                        for (int i = 0; i < chaliceBossString.Count; i++)
                        {
                            combinedBossList.Add(chaliceBossString[i]);
                        }
                        for (int i = 0; i < enemyData.Count; i ++)
                        {
                            combinedBossList.Add(enemyData[i]);
                        }
                    }

                    for(int i = 0; i < combinedBossList.Count; i ++)
                    {
                        combinedBossList2.Add(combinedBossList[i]);
                    }

                    for(int i = 0; i < combinedBossList2.Count; i ++)
                    {
                        for (int j = combinedBossList2.Count - 1; j >= 0; j--)
                        {
                            string modelString = combinedBossList2[i].Substring(combinedBossList2[i].Length - 5, 5);

                            if (combinedBossList2[j].Contains(modelString) && j != i)
                            {
                                combinedBossList2.RemoveAt(j);
                            }
                        }
                    }

                    while (secondaryBosses.Count > 0)
                    {
                        int index = rand.Next(0, secondaryBosses.Count);
                        enemyDataRandomized.Add(secondaryBosses[index]);
                        secondaryBosses.RemoveAt(index);
                    }



                }
            }
                dateNow = DateTime.Now.ToString("h:mm:ss tt");
                butts = dateNow.Replace(":", "-");
                bossLogFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + butts + "-BossLog.txt";
                using (FileStream sw = File.Create(bossLogFilePath))
                {

                }

                dateNow = DateTime.Now.ToString("h:mm:ss tt");
                butts = dateNow.Replace(":", "-");
                dummyFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + butts + "-DummyLog.txt";
                using (FileStream sw = File.Create(dummyFilePath))
                {

                }

            if (includeBosses)
            {
                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 45;
                    currentTask = "Randomizing Bosses...";
                    UpdateUI();
                });

                Random rando = new Random();
                int thisOne = rando.Next(0, 3);

                if (!oopsAllBosses)
                {
                    if (thisOne == 0)
                    {
                        AddOrphanPhaseOne(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
                    }
                    else if (thisOne == 1)
                    {
                        AddOrphanPhaseOne(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                    }
                    else if (thisOne == 2)
                    {
                        AddOrphanPhaseOne(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                    }
                }

                using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                {
                    writetext.WriteLine("Number of bosses in combined boss list");
                    for (int i = 0; i < combinedBossList.Count; i++)
                    {
                        writetext.WriteLine(combinedBossList[i]);
                    }

                    writetext.WriteLine("Enemy Pool Count: " + chaliceBossString.Count + Environment.NewLine + Environment.NewLine);
                }

                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);

                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", nonoList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", nonoList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);

                if (!oopsAllBosses)
                {
                    AddTheRest(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                    AddTheRest(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                    AddTheRest(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                }

                if (chaliceBosses || oopsAllBosses)
                {
                    
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", unusedPlusBossList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", unusedPlusBossList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", unusedPlusBossList);
                    //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", nonoList);
                    RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", unusedPlusBossList);
                    if (GOBAdded)
                    {
                        RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx", unusedPlusBossList);
                    }

                }
            }
            if (insertBossesBool)
            {
                List<string> uniqueLst = insertBossesString.Distinct().ToList();
                insertBossesString = new List<string>();

                for(int i = 0; i < uniqueLst.Count; i ++)
                {
                    insertBossesString.Add(uniqueLst[i]);
                }



                using (StreamWriter writetext = File.AppendText(insertedBossPath))
                {
                    writetext.WriteLine("INSERTING BOSSES STARTING BELOW THIS LINE");
                    writetext.WriteLine("" + Environment.NewLine + Environment.NewLine);
                }

                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 55;
                    currentTask = "Replacing Enemies With Bosses...";
                    UpdateUI();
                });

                if (bossHemwick)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                }
                if (bossOldYharnam)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                }
                if (bossCathedralWard)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                }
                if (bossCentralYharnam)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", unusedPlusBossList);
                }
                if (bossUpperCathedralWard)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
                }
                if (bossCainhurst)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                }
                if (bossMensis)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                }
                if (bossForbiddenWoods)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                }
                if (bossYahargul)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                }
                if (bossByrgenwerthLecture)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                }
                if (bossFrontier)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                }
                if (bossNightmare)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                }
                if (bossResearchHall)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                }
                if (bossHamlet)
                {
                    InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
                }

                if (chaliceBosses)
                {
                    if (bossChalices)
                    {
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx", unusedPlusBossList);
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx", unusedPlusBossList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx", unusedPlusBossList);
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx", unusedPlusBossList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx", unusedPlusBossList);
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx", unusedPlusBossList);
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx", unusedPlusBossList);
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx", unusedPlusBossList);
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx", unusedPlusBossList);
                        //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx", nonoList);
                        InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx", unusedPlusBossList);
                    }
                }
            }

            if(includeNPCs)
            {
                using (StreamWriter writetext = File.AppendText(randomizedNPCPath))
                {
                    writetext.WriteLine("RANDOMIZED NPC'S STARTING BELOW THIS LINE");
                    writetext.WriteLine("" + Environment.NewLine + Environment.NewLine);
                }

                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 65;
                    currentTask = "Generating NPC List...";
                    UpdateUI();
                });

                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx");
                GenerateNPCList(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx");

                for (int i = 0; i < npcEnemyList.Count; i++)
                {
                    string tempString = npcEnemyList[i].NPCParamID.ToString() + "*" + npcEnemyList[i].ThinkParamID.ToString() + "*" + npcEnemyList[i].UnkT07.ToString();
                    npcList.Add(npcEnemyList[i].NPCParamID.ToString() + "*" + npcEnemyList[i].ThinkParamID.ToString() + "*" + npcEnemyList[i].UnkT07.ToString());
                }

                for(int i = 0; i < npcList.Count; i ++)
                {
                    if (npcList[i].Contains("*6300") || npcList[i].Contains("*6301") || npcList[i].Contains("*6380")
                        || npcList[i].Contains("*6310") || npcList[i].Contains("*6340") || npcList[i].Contains("*6350")
                        || npcList[i].Contains("*6360") || npcList[i].Contains("*6400") || npcList[i].Contains("*6410")
                        || npcList[i].Contains("*6160") || npcList[i].Contains("*6161") || npcList[i].Contains("*6162")
                        || npcList[i].Contains("*6430") || npcList[i].Contains("*6420") || npcList[i].Contains("*6545")
                        || npcList[i].Contains("*6390") || npcList[i].Contains("*6395") || npcList[i].Contains("*6450")
                        || npcList[i].Contains("*6580") || npcList[i].Contains("*6585") || npcList[i].Contains("*6610")
                        || npcList[i].Contains("*6520") || npcList[i].Contains("*6570") || npcList[i].Contains("*6630"))
                    {
                        hostileNpcList.Add(npcList[i]);
                    }
                }

                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 75;
                    currentTask = "Randomizing NPC's...";
                    UpdateUI();
                });

                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
                RandomizeNPCs(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
            }

            if(randomizeItemLots)
            {
                nonoItemLots.Add(2600550); //Evil Eye Bridge key (key in nightmare of mensis?)
                nonoItemLots.Add(2400450); //The key to the Old Town (gascoigne key?)
                nonoItemLots.Add(3500800); //The key to the dungeon usually door (braidor key?)
                keyItemLots.Add(2800290); //The key to Cathedral Street C (UCW key)
                keyItemLots.Add(3200720); //The key to nightmare classroom (byrgenworth lower floor key)
                keyItemLots.Add(3200810); //Veranda of key (key to rom fight)
                keyItemLots.Add(2410990); //Invitation to the castle (cainhurst summons)
                keyItemLots.Add(3502000); //Parish length Ω Startup Item (laurence skull)
                keyItemLots.Add(3401810); //Altar Elevator Startup Item (eye pendant)
                workshopItemsList.Add(2411000); //Blood gem workshop tool (chest after gascoigne)
                workshopItemsList.Add(2200360); //Rune tool (after witches)

                for(int i = 0; i < keyItemLots.Count; i ++)
                {
                    nonoItemLots.Add(keyItemLots[i]);
                }

                if(!workshopBool)
                {
                    for(int i = 0; i < workshopItemsList.Count; i ++)
                    {
                        nonoItemLots.Add(workshopItemsList[i]);
                    }
                }

                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 85;
                    currentTask = "Generating Item List...";
                    UpdateUI();
                });

                //GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
                GenerateItemLotList(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");

                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 90;
                    currentTask = "Randomizing Items...";
                    UpdateUI();
                });

                //RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
                RandomizeItemLots(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
            }

            if(enemyDropBool)
            {
                RandomizeItemDrops();
            }

            if(shopBool)
            {
                RandomizeShopItems();
            }

            string dateNoww = DateTime.Now.ToString("h:mm:ss tt");
            string buttss = dateNoww.Replace(":", "-");
            scaleLogFile = filePath + "\\Mod Files\\Logs. Don't Delete\\" + buttss + "-ScaleLog.txt";
            using (FileStream sw1 = File.Create(scaleLogFile))
            {

            }

            this.Dispatcher.Invoke(() =>
            {
                totalPercent = 98;
                currentTask = "Scaling All Enemies And Bosses...";
                UpdateUI();
            });

            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx");
            ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx");
            if (GOBAdded)
            {
                ParamScalingForBosses(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx");
            }

            mapList = new List<string>();

            mapList.Add(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_10_90_00\\m29_10_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_20_90_00\\m29_20_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_21_90_00\\m29_21_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_30_90_00\\m29_30_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_31_90_00\\m29_31_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_40_90_00\\m29_40_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_42_90_00\\m29_42_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_90_00\\m29_50_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_52_90_00\\m29_52_90_01.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_00.msb.dcx");
            mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_53_90_00\\m29_53_90_01.msb.dcx");
            
            if (GOBAdded)
            {
                mapList.Add(filePath + "\\map\\mapstudio\\" + "m29_50_40_00\\m29_50_40_00.msb.dcx");
            }

            for (int i = 0; i < mapList.Count; i++)
            {
                var tempMapRead = MSBB.Read(mapList[i]);

                long maxSizeLong = 0;

                for (int j = 0; j < tempMapRead.Parts.Enemies.Count; j++)
                {
                    for (int k = 0; k < nameList.Count; k++)
                    {
                        if (tempMapRead.Parts.Enemies[j].ModelName.Contains(nameList[k]))
                        {
                            maxSizeLong += sizeList[k];
                            k = nameList.Count + 1;
                        }
                    }
                }
            }

            this.Dispatcher.Invoke(() =>
            {
                totalPercent = 100;
                currentTask = "FINISHED!";
                UpdateUI();
            });


            running = false;

            MessageBox.Show("Finished.");

            this.Dispatcher.Invoke(() =>
            {
                currentTask = "CURRENT TASK";
                totalPercent = 0;
                UpdateUI();
                totalTime = 0;
                TotalTime.Content = "0:00";

                TEST.IsEnabled = true;
                RandomizeEnemiesCheck.IsEnabled = true;
                BossCheckBox.IsEnabled = true;
                InsertBosses.IsEnabled = true;
                ChaliceBoss.IsEnabled = true;
                ChaliceEnemies.IsEnabled = true;
                ArmorRandomizerCheckBox.IsEnabled = true;
                AddNPCS.IsEnabled = true;
                OopsAllCheck.IsEnabled = true;
                OopsAllBossesCheck.IsEnabled = true;
                OopsAllStringName.IsEnabled = true;
                OopsBoss.IsEnabled = true;
                BellMaidenBox.IsEnabled = true;
                LesserBossesBox.IsEnabled = true;
                RandomizeKeyItemsBox.IsEnabled = true;
                RandomizeShopBox.IsEnabled = true;
                EnemyDropBox.IsEnabled = true;
                WorkshopBox.IsEnabled = true;
            });

            Environment.Exit(0);
        }

        
        private void RandomizeShopItems()
        {
            var paramdefs = new List<PARAMDEF>();
            var paramdefbnd = BND4.Read(paramDefPath);
            foreach (BinderFile file in paramdefbnd.Files)
            {
                var paramdef = PARAMDEF.Read(file.Bytes);
                paramdefs.Add(paramdef);
            }

            var parms = new Dictionary<string, PARAM>();
            var parambnd = BND4.Read(paramPath);
            foreach (BinderFile file in parambnd.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                var param = PARAM.Read(file.Bytes);

                param.ApplyParamdef(paramdefs.Find(def => def.ParamType == param.ParamType));
                parms[name] = param;
            }

            PARAM shopLineupParams = parms["ShopLineupParam"];
            PARAM weaponParams = parms["EquipParamWeapon"];

            Random rand = new Random();

            List<string> vialAndBulletIDsList = new List<string>();
            vialAndBulletIDsList.Add("1000");
            vialAndBulletIDsList.Add("900");
            vialAndBulletIDsList.Add("240");
            if (keepGuns)
            {
                vialAndBulletIDsList.Add("14000000");
                vialAndBulletIDsList.Add("6000000");
            }

            List<string> shopWeaponList = new List<string>();
            List<string> shopConsumableList = new List<string>();
            List<string> shopArmorList = new List<string>();

            //EQUIP ID'S

            //RIGHT HAND WEAPONS
            //Parasite 38000000
            //Amygdalan Arm? 25000000
            //ax 5000000
            //cane 22000000
            //lost blood sword 2020000
            //chikage 2000000
            //hammer 8000000
            //war pick? 30000000
            //lost war pick? 30020000
            //lost hammer 8020000
            //cut off the lost meat??? 24020000
            //double edged decidious??? 27000000
            //gun hammer? 28000000
            //funeral blade 5100000
            //gatling gun 33000000
            //chigatana heterogenity 2010000
            //Heterogeneity of church stone mallet 8010000
            //Heterogeneity of deciduous 27010000
            //Heterogeneity of Funeral blade 5110000
            //Heterogeneity of Juyari 10010000
            //Heterogeneity of Leyte Rupa rush 10110000
            //Heterogeneity of mercy blade 4010000
            //Heterogeneity of moonlight Seiken 26010000
            //Heterogeneity of parasite 38010000
            //Heterogeneity of phlebotomy mallet 29010000
            //Heterogeneity of rotation sawtooth 31010000
            //Heterogeneity of Shishitsume 9010000
            //Heterogeneity of small Amun arm 25010000
            //Heterogeneity of the beast hunting ax 5010000
            //Heterogeneity of the beast hunting songs sword 23010000
            //Heterogeneity of the bow sword 32010000
            //Heterogeneity of the church pile 30010000
            //Heterogeneity of the explosion hammer 28010000
            //Heterogeneity of the feed wand 22010000
            //Heterogeneity of the holy sword 8110000
            //Heterogeneity of the meat cut off 24010000
            //Heterogeneity of the pile hammer 11010000
            //Heterogeneity of the sawtooth hatchet 7010000
            //Heterogeneity of the wheels 12010000
            //Heterogeneity of Tonitorusu 13010000
            //Holy sword of moonlight (moonlight sword) 26000000
            //Holy sword of Rudouiku (sword sword) 8100000
            //Juyari (Juyari) 10000000
            //Juyari lost 10020000
            //Leyte Rupa Rush (bayonet) 10100000
            //Lost beast hunting ax 5020000
            //Lost beast hunting songs sword 23020000
            //Lost bow sword 32020000
            //Lost charged cane 22020000
            //Lost deciduous 27020000
            //Lost explosion hammer 28020000
            //Lost Funeral blade 5120000
            //Lost Leyte Rupa rush 10120000
            //Lost mercy blade 4020000
            //Lost moonlight Seiken 26020000
            //Lost parasites 38020000
            //Lost pile hammer 11020000
            //Lost wheel 12020000
            //Meat cut off (Nokomuchi) 24000000
            //Mercy of the blade (twin sword) 4000000
            //Nokonata 7000000
            //Phlebotomy hammer lost 29020000
            //Phlebotomy of the mallet (cross Mace) 29000000
            //Pile hammer (Kenkui) 11000000
            //Pole ax 5000000
            //Rogeriusu of the wheel (wheel) 12000000
            //Rotation sawtooth (circular saw chain saw) 31000000
            //Rotation sawtooth lost 31020000
            //Sawtooth hatchet(Nokonata) 7000000
            //Sawtooth hatchet that lost 7020000
            //Sawtooth spear (Nokoyari) 7100000
            //Sawtooth spear lost 7120000
            //Shishitsume lost 9020000
            //Simon bow sword (deformation bow) 32000000
            //Small Amun arm that was lost 25020000
            //Song sword of the beast hunting (saw song sword) 23000000
            //St. sword that was lost 8120000
            //Stick whip 22000000
            //Tonitorusu (爆槌) 13000000
            //Tonitorusu lost 13020000

            rightHandList.Add("38000000");
            rightHandList.Add("25000000");
            rightHandList.Add("5000000");
            rightHandList.Add("22000000");
            rightHandList.Add("2020000");
            rightHandList.Add("2000000");
            rightHandList.Add("8000000");
            rightHandList.Add("30000000");
            rightHandList.Add("30020000");
            rightHandList.Add("8020000");
            rightHandList.Add("24020000");
            rightHandList.Add("27000000");
            rightHandList.Add("28000000");
            rightHandList.Add("5100000");
            rightHandList.Add("2010000");
            rightHandList.Add("8010000");
            rightHandList.Add("27010000");
            rightHandList.Add("5110000");
            rightHandList.Add("10010000");
            rightHandList.Add("10110000");
            rightHandList.Add("4010000");
            rightHandList.Add("26010000");
            rightHandList.Add("38010000");
            rightHandList.Add("29010000");
            rightHandList.Add("31010000");
            rightHandList.Add("9010000");
            rightHandList.Add("25010000");
            rightHandList.Add("5010000");
            rightHandList.Add("23010000");
            rightHandList.Add("32010000");
            rightHandList.Add("30010000");
            rightHandList.Add("28010000");
            rightHandList.Add("22010000");
            rightHandList.Add("8110000");
            rightHandList.Add("24010000");
            rightHandList.Add("11010000");
            rightHandList.Add("7010000");
            rightHandList.Add("12010000");
            rightHandList.Add("13010000");
            rightHandList.Add("26000000");
            rightHandList.Add("8100000");
            rightHandList.Add("10000000");
            rightHandList.Add("10020000");
            rightHandList.Add("10100000");
            rightHandList.Add("5020000");
            rightHandList.Add("23020000");
            rightHandList.Add("32020000");
            rightHandList.Add("22020000");
            rightHandList.Add("27020000");
            rightHandList.Add("28020000");
            rightHandList.Add("5120000");
            rightHandList.Add("10120000");
            rightHandList.Add("4020000");
            rightHandList.Add("26020000");
            rightHandList.Add("38020000");
            rightHandList.Add("11020000");
            rightHandList.Add("12020000");
            rightHandList.Add("24000000");
            rightHandList.Add("4000000");
            rightHandList.Add("7000000");
            rightHandList.Add("29020000");
            rightHandList.Add("/29000000");
            rightHandList.Add("11000000");
            rightHandList.Add("5000000");
            rightHandList.Add("12000000");
            rightHandList.Add("31000000");
            rightHandList.Add("31020000");
            rightHandList.Add("7000000");
            rightHandList.Add("7020000");
            rightHandList.Add("7100000");
            rightHandList.Add("7120000");
            rightHandList.Add("9020000");
            rightHandList.Add("32000000");
            rightHandList.Add("25020000");
            rightHandList.Add("23000000");
            rightHandList.Add("8120000");
            rightHandList.Add("22000000");
            rightHandList.Add("13000000");
            rightHandList.Add("13020000");

            //LEFT HAND WEAPONS
            //cannon 15000000
            //church cannon 35000000
            //evelyn 14100000
            //flamethrower 18100000
            //fist of gratia 34000000
            //Long gun Rudouiku (church length gun)??? 6100000
            //Of the beast hunting handguns (workshop handguns) 14000000
            //Of the beast hunting shotgun (workshop Nagaju) 6000000
            //Rosmarinus (sprayer) 18000000\
            //Shield of the lake (attribute shield) 19100000
            //Through gun (through gun) 36000000
            //Torches of the beast hunting (torches of the hunter) 20000000
            //Twin gun of the Church (Church handguns) 14200000
            //Workshop handgun 14000000
            //Workshop Nagaju 6000000

            leftHandList.Add("15000000");
            leftHandList.Add("35000000");
            leftHandList.Add("14100000");
            leftHandList.Add("18100000");
            leftHandList.Add("34000000");
            leftHandList.Add("6100000");
            leftHandList.Add("14000000");
            leftHandList.Add("6000000");
            leftHandList.Add("18000000");
            leftHandList.Add("19100000");
            leftHandList.Add("36000000");
            leftHandList.Add("20000000");
            leftHandList.Add("14200000");
            leftHandList.Add("14000000");
            leftHandList.Add("6000000");
            leftHandList.Add("33000000");

            for (int i = 0; i < shopLineupParams.Rows.Count; i ++)
            {
                bool addToList = true;

                for (int j = 0; j < vialAndBulletIDsList.Count; j++)
                {
                    if (shopLineupParams.Rows[i].Cells[0].Value.ToString() == vialAndBulletIDsList[j])
                    {
                        addToList = false;
                    }
                }

                if (addToList)
                {
                    if (shopLineupParams.Rows[i].Cells[7].Value.ToString() == "0")
                    {
                        shopWeaponList.Add(shopLineupParams.Rows[i].Cells[0].Value.ToString());
                    }
                    else if (shopLineupParams.Rows[i].Cells[7].Value.ToString() == "1")
                    {
                        shopArmorList.Add(shopLineupParams.Rows[i].Cells[0].Value.ToString());
                    }
                    else if (shopLineupParams.Rows[i].Cells[7].Value.ToString() == "3")
                    {
                        shopConsumableList.Add(shopLineupParams.Rows[i].Cells[0].Value.ToString());
                    }
                }
            }

            for(int i = 0; i < shopLineupParams.Rows.Count; i ++)
            {
                bool changeData = true;

                for (int j = 0; j < vialAndBulletIDsList.Count; j++)
                {
                    if (shopLineupParams.Rows[i].Cells[0].Value.ToString() == vialAndBulletIDsList[j])
                    {
                        changeData = false;
                    }
                }

                if(changeData)
                {
                    if (shopLineupParams.Rows[i].Cells[7].Value.ToString() == "0" && shopWeaponList.Count > 0)
                    {
                        int randomNumber = rand.Next(0, shopWeaponList.Count);

                        while(shopWeaponList[randomNumber].Contains(shopLineupParams.Rows[i].Cells[0].ToString()))
                        {
                            randomNumber = rand.Next(0, shopWeaponList.Count);
                        }

                        if(shopLineupParams.Rows[i].Cells[0].ToString().Contains("7000000")
                            || shopLineupParams.Rows[i].Cells[0].ToString().Contains("5000000")
                            || shopLineupParams.Rows[i].Cells[0].ToString().Contains("22000000"))
                        {
                            bool rightHand = false;

                            while(!rightHand)
                            {
                                if(!rightHandList.Contains(shopWeaponList[randomNumber]))
                                {
                                    randomNumber = rand.Next(0, shopWeaponList.Count);
                                }
                                else
                                {
                                    rightHand = true;
                                }
                            }

                        }

                        if (shopLineupParams.Rows[i].Cells[0].ToString().Contains("14000000")
                            || shopLineupParams.Rows[i].Cells[0].ToString().Contains("6000000"))
                        {
                            bool leftHand = false;

                            while(!leftHand)
                            {
                                if (!leftHandList.Contains(shopWeaponList[randomNumber]))
                                {
                                    randomNumber = rand.Next(0, shopWeaponList.Count);
                                }
                                else
                                {
                                    leftHand = true;
                                }
                            }

                        }

                        if(shopLineupParams.Rows[i].ID.ToString() == "2000")
                        {
                            new2000 = shopWeaponList[randomNumber];
                        }

                        if (shopLineupParams.Rows[i].ID.ToString() == "2001")
                        {
                            new2001 = shopWeaponList[randomNumber];
                        }

                        if (shopLineupParams.Rows[i].ID.ToString() == "2002")
                        {
                            new2002 = shopWeaponList[randomNumber];
                        }

                        if (!keepGuns)
                        {
                            if (shopLineupParams.Rows[i].ID.ToString() == "2010")
                            {
                                new2010 = shopWeaponList[randomNumber];
                            }

                            if (shopLineupParams.Rows[i].ID.ToString() == "2011")
                            {
                                new2011 = shopWeaponList[randomNumber];
                            }
                        }

                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("Old Shop Item");
                            writetext.WriteLine(shopLineupParams.Rows[i].Cells[0].Value);
                            writetext.WriteLine("New Shop Item");
                            writetext.WriteLine(shopWeaponList[randomNumber]);
                        }

                        shopLineupParams.Rows[i].Cells[0].Value = Int32.Parse(shopWeaponList[randomNumber]);

                        shopWeaponList.RemoveAt(randomNumber);
                    }
                    else if (shopLineupParams.Rows[i].Cells[7].Value.ToString() == "1" && shopArmorList.Count > 0)
                    {
                        int randomNumber = rand.Next(0, shopArmorList.Count);

                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("Old Shop Item");
                            writetext.WriteLine(shopLineupParams.Rows[i].Cells[0].Value);
                            writetext.WriteLine("New Shop Item");
                            writetext.WriteLine(shopArmorList[randomNumber]);
                        }

                        shopLineupParams.Rows[i].Cells[0].Value = Int32.Parse(shopArmorList[randomNumber]);

                        shopArmorList.RemoveAt(randomNumber);
                    }
                    else if (shopLineupParams.Rows[i].Cells[7].Value.ToString() == "3" && shopConsumableList.Count > 0)
                    {
                        int randomNumber = rand.Next(0, shopConsumableList.Count);

                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("Old Shop Item");
                            writetext.WriteLine(shopLineupParams.Rows[i].Cells[0].Value);
                            writetext.WriteLine("New Shop Item");
                            writetext.WriteLine(shopConsumableList[randomNumber]);
                        }

                        shopLineupParams.Rows[i].Cells[0].Value = Int32.Parse(shopConsumableList[randomNumber]);

                        shopConsumableList.RemoveAt(randomNumber);
                    }
                }
            }

            //for(int i = 0; i < )

            //7000000 8 7 0 0
            //5000000 9 8 0 0
            //22000000 7 9 0 0
            //14000000 7 9 5 0
            //6000000 7 9 5 0

            //2000
            //2001
            //2002
            //2010
            //2011

            //79
            //80
            //81
            //82

            using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
            {
                writetext.WriteLine("Starting Required Stat Changing...");
            }

            byte nine = 9;
            byte eight = 8;
            byte seven = 7;
            byte five = 5;
            byte zero = 0;

            List<string> new2000StringList = new List<string>();
            List<string> new2001StringList = new List<string>();
            List<string> new2002StringList = new List<string>();
            List<string> new2010StringList = new List<string>();
            List<string> new2011StringList = new List<string>();

            int new2000Int = int.Parse(new2000);
            int new2001Int = int.Parse(new2001);
            int new2002Int = int.Parse(new2002);
            int new2010Int = int.Parse(new2010);
            int new2011Int = int.Parse(new2011);

            for (int i = 0; i < 10; i ++)
            {
                new2000Int += 100;
                new2000StringList.Add(new2000Int.ToString());

                new2001Int += 100;
                new2001StringList.Add(new2001Int.ToString());

                new2002Int += 100;
                new2002StringList.Add(new2002Int.ToString());

                new2010Int += 100;
                new2010StringList.Add(new2010Int.ToString());

                new2011Int += 100;
                new2011StringList.Add(new2011Int.ToString());
            }

            for (int i = 0; i < weaponParams.Rows.Count; i ++)
            {
                if(weaponParams.Rows[i].ID.ToString() == new2000)
                {
                    using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                    {
                        writetext.WriteLine("New starting item");
                        writetext.WriteLine(weaponParams.Rows[i].ID);
                    }

                    //7000000 8 7 0 0
                    weaponParams.Rows[i].Cells[80].Value = eight;
                    weaponParams.Rows[i].Cells[81].Value = seven;
                    weaponParams.Rows[i].Cells[82].Value = zero;
                    weaponParams.Rows[i].Cells[83].Value = zero;
                }

                if (weaponParams.Rows[i].ID.ToString() == new2001)
                {
                    using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                    {
                        writetext.WriteLine("New starting item");
                        writetext.WriteLine(weaponParams.Rows[i].ID);
                    }

                    //5000000 9 8 0 0
                    weaponParams.Rows[i].Cells[80].Value = nine;
                    weaponParams.Rows[i].Cells[81].Value = eight;
                    weaponParams.Rows[i].Cells[82].Value = zero;
                    weaponParams.Rows[i].Cells[83].Value = zero;
                }

                if (weaponParams.Rows[i].ID.ToString() == new2002)
                {
                    using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                    {
                        writetext.WriteLine("New starting item");
                        writetext.WriteLine(weaponParams.Rows[i].ID);
                    }

                    //22000000 7 9 0 0
                    weaponParams.Rows[i].Cells[80].Value = seven;
                    weaponParams.Rows[i].Cells[81].Value = nine;
                    weaponParams.Rows[i].Cells[82].Value = zero;
                    weaponParams.Rows[i].Cells[83].Value = zero;
                }

                if (!keepGuns)
                {
                    if (weaponParams.Rows[i].ID.ToString() == new2010)
                    {
                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("New starting item");
                            writetext.WriteLine(weaponParams.Rows[i].ID);
                        }

                        //14000000 7 9 5 0
                        weaponParams.Rows[i].Cells[80].Value = seven;
                        weaponParams.Rows[i].Cells[81].Value = nine;
                        weaponParams.Rows[i].Cells[82].Value = five;
                        weaponParams.Rows[i].Cells[83].Value = zero;
                    }

                    if (weaponParams.Rows[i].ID.ToString() == new2011)
                    {
                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("New starting item");
                            writetext.WriteLine(weaponParams.Rows[i].ID);
                        }

                        //6000000 7 9 5 0
                        weaponParams.Rows[i].Cells[80].Value = seven;
                        weaponParams.Rows[i].Cells[81].Value = nine;
                        weaponParams.Rows[i].Cells[82].Value = five;
                        weaponParams.Rows[i].Cells[83].Value = zero;
                    }
                }
            }

            //scaling the rest of the items (+ items)

            //1
            for(int i = 0; i < new2000StringList.Count; i ++)
            {
                for (int j = 0; j < weaponParams.Rows.Count; j++)
                {
                    if (weaponParams.Rows[j].ID.ToString() == new2000StringList[i])
                    {
                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("New starting item");
                            writetext.WriteLine(weaponParams.Rows[j].ID);
                        }

                        //7000000 8 7 0 0
                        weaponParams.Rows[j].Cells[80].Value = eight;
                        weaponParams.Rows[j].Cells[81].Value = seven;
                        weaponParams.Rows[j].Cells[82].Value = zero;
                        weaponParams.Rows[j].Cells[83].Value = zero;
                    }
                }
            }

            //2
            for(int i = 0; i < new2001StringList.Count; i ++)
            {
                for (int j = 0; j < weaponParams.Rows.Count; j++)
                {
                    if (weaponParams.Rows[j].ID.ToString() == new2001StringList[i])
                    {
                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("New starting item");
                            writetext.WriteLine(weaponParams.Rows[j].ID);
                        }

                        //5000000 9 8 0 0
                        weaponParams.Rows[j].Cells[80].Value = nine;
                        weaponParams.Rows[j].Cells[81].Value = eight;
                        weaponParams.Rows[j].Cells[82].Value = zero;
                        weaponParams.Rows[j].Cells[83].Value = zero;
                    }
                }
            }

            //3
            for(int i = 0; i < new2002StringList.Count; i ++)
            {
                for (int j = 0; j < weaponParams.Rows.Count; j++)
                {
                    if (weaponParams.Rows[j].ID.ToString() == new2002StringList[i])
                    {
                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("New starting item");
                            writetext.WriteLine(weaponParams.Rows[j].ID);
                        }

                        //22000000 7 9 0 0
                        weaponParams.Rows[j].Cells[80].Value = seven;
                        weaponParams.Rows[j].Cells[81].Value = nine;
                        weaponParams.Rows[j].Cells[82].Value = zero;
                        weaponParams.Rows[j].Cells[83].Value = zero;
                    }
                }
            }

            if (!keepGuns)
            {
                //4
                for (int i = 0; i < new2010StringList.Count; i++)
                {
                    for (int j = 0; j < weaponParams.Rows.Count; j++)
                    {
                        if (weaponParams.Rows[j].ID.ToString() == new2010StringList[i])
                        {
                            using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                            {
                                writetext.WriteLine("New starting item");
                                writetext.WriteLine(weaponParams.Rows[j].ID);
                            }

                            //14000000 7 9 5 0
                            weaponParams.Rows[j].Cells[80].Value = seven;
                            weaponParams.Rows[j].Cells[81].Value = nine;
                            weaponParams.Rows[j].Cells[82].Value = five;
                            weaponParams.Rows[j].Cells[83].Value = zero;
                        }
                    }
                }

                //5
                for(int i = 0; i < new2011StringList.Count; i ++)
                {
                    for (int j = 0; j < weaponParams.Rows.Count; j++)
                    {
                        if (weaponParams.Rows[j].ID.ToString() == new2011StringList[i])
                        {
                            using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                            {
                                writetext.WriteLine("New starting item");
                                writetext.WriteLine(weaponParams.Rows[j].ID);
                            }

                            //6000000 7 9 5 0
                            weaponParams.Rows[j].Cells[80].Value = seven;
                            weaponParams.Rows[j].Cells[81].Value = nine;
                            weaponParams.Rows[j].Cells[82].Value = five;
                            weaponParams.Rows[j].Cells[83].Value = zero;
                        }
                    }
                }
            }

            using(StreamWriter writetext = File.AppendText(randomizedItemLotPath))
            {
                writetext.WriteLine("Ending Required Stat Changing...");
            }

            foreach (BinderFile file in parambnd.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                if (parms.ContainsKey(name))
                    file.Bytes = parms[name].Write();
            }
            parambnd.Write(paramPath);
        }

        private void GenerateNPCList(string currentMap)
        {
            var tempGuy = MSBB.Read(currentMap);

            for(int i = 0; i < tempGuy.Parts.Enemies.Count; i ++)
            {
                if(tempGuy.Parts.Enemies[i].ModelName.Contains("c0000") && tempGuy.Parts.Enemies[i].ThinkParamID != 1)
                {
                    npcEnemyList.Add(tempGuy.Parts.Enemies[i]);
                }
            }
        }

        private void RandomizeNPCs(string currentMap)
        {
            var tempGuy = MSBB.Read(currentMap);

            for(int i = 0; i < tempGuy.Parts.Enemies.Count; i ++)
            {
                if(tempGuy.Parts.Enemies[i].ModelName.Contains("c0000") && tempGuy.Parts.Enemies[i].ThinkParamID != 1)
                {
                    bool addHostile = false;


                    for (int k = 0; k < hostileNpcList.Count; k++)
                    {
                        if (tempGuy.Parts.Enemies[i].UnkT07.ToString().Contains(hostileNpcList[k]))
                        {
                            addHostile = true;
                        }
                    }

                    Random rand = new Random();
                    int random = rand.Next(0, npcList.Count);
                    string thisEnemy = "";

                    if (addHostile)
                    {
                        random = rand.Next(0, hostileNpcList.Count);

                        while (hostileNpcList[random].Contains(tempGuy.Parts.Enemies[i].UnkT07.ToString()))
                        {
                            random = rand.Next(0, hostileNpcList.Count);
                            thisentityID = hostileNpcList[random];
                        }
                    }
                    else
                    {
                        thisEnemy = npcList[random];
                    }

                    string tempNpcParam;
                    string tempThinkId;
                    string modelName;

                    int tempNpcParamInt;
                    int tempThinkIdInt;

                    string npc = tempGuy.Parts.Enemies[i].NPCParamID.ToString();
                    string think = tempGuy.Parts.Enemies[i].ThinkParamID.ToString();
                    string mo = tempGuy.Parts.Enemies[i].UnkT07.ToString();
                    string entityID = tempGuy.Parts.Enemies[i].EntityID.ToString();

                    int tempnpcint = thisEnemy.IndexOf("*");
                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 4);

                    tempNpcParamInt = int.Parse(tempNpcParam);
                    tempThinkIdInt = int.Parse(tempThinkId);

                    if (tempGuy.Parts.Enemies[i].NPCParamID != 6380)
                    {
                        using (StreamWriter writetext = File.AppendText(randomizedNPCPath))
                        {
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(npcList.Count);
                            writetext.WriteLine("Old NPC");
                            writetext.WriteLine(npc + " npcParam");
                            writetext.WriteLine(think + " thinkID");
                            writetext.WriteLine(mo + " UNKT07");

                            writetext.WriteLine("New NPC");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " UNKT07");

                            writetext.WriteLine("" + Environment.NewLine + Environment.NewLine);
                        }

                        tempGuy.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGuy.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGuy.Parts.Enemies[i].UnkT07 = int.Parse(modelName);
                    }
                    else if (tempGuy.Parts.Enemies[i].NPCParamID == 6380)
                    {
                        int randoHostile = rand.Next(0, hostileNpcList.Count);

                        thisEnemy = hostileNpcList[randoHostile];

                        npc = tempGuy.Parts.Enemies[i].NPCParamID.ToString();
                        think = tempGuy.Parts.Enemies[i].ThinkParamID.ToString();
                        mo = tempGuy.Parts.Enemies[i].UnkT07.ToString();
                        entityID = tempGuy.Parts.Enemies[i].EntityID.ToString();

                        tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 4);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        using (StreamWriter writetext = File.AppendText(randomizedNPCPath))
                        {
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(npcList.Count);
                            writetext.WriteLine("Old NPC");
                            writetext.WriteLine(npc + " npcParam");
                            writetext.WriteLine(think + " thinkID");
                            writetext.WriteLine(mo + "UNKT07");

                            writetext.WriteLine("New NPC");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " UNKT07");

                            writetext.WriteLine("" + Environment.NewLine + Environment.NewLine);
                        }

                        tempGuy.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGuy.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGuy.Parts.Enemies[i].UnkT07 = int.Parse(modelName);
                    }

                    npcList.RemoveAt(random);
                }
            }

            tempGuy.Write(currentMap);
        }

        private void InsertBossesVoid(string currentMap, List<string> nonoList)
        {
            for(int i = 0; i < insertBossesString.Count; i ++)
            {
                if(insertBossesString[i].Contains("c5400"))
                {
                    insertBossesString.RemoveAt(i);
                    i = insertBossesString.Count + 3;
                }
            }

            if (randomize)
            {
                var tempGUY = MSBB.Read(currentMap);

                bool changeData;

                for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                {
                    changeData = true;

                    for (int j = 0; j < nonoList.Count; j++)
                    {
                        if (tempGUY.Parts.Enemies[i].Name.Contains(nonoList[j]))
                        {
                            changeData = false;
                        }
                    }


                    if (changeData && insertBossesString.Count > 0)
                    {
                        Random rand = new Random();
                        int random = rand.Next(0, insertBossesString.Count);
                        int randomChalice = rand.Next(0,chaliceBossString.Count);
                        string thisEnemy;
                        if (currentMap.Contains("m29"))
                        {
                            thisEnemy = chaliceBossString[randomChalice];
                        }
                        else
                        {
                            thisEnemy = insertBossesString[random];
                        }


                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        Console.WriteLine(enemyData[0]);

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);
                        Random ass = new Random();
                        float assass = ass.Next(0,101);
                        if (assass <= bossPercentage)
                        {
                            using (StreamWriter writetext = File.AppendText(insertedBossPath))
                            {
                                writetext.WriteLine(currentMap);
                                writetext.WriteLine("Inserted Boss");
                                writetext.WriteLine(tempNpcParam + " npcParam");
                                writetext.WriteLine(tempThinkId + " thinkID");
                                writetext.WriteLine(modelName + " model");

                                writetext.WriteLine("" + Environment.NewLine + Environment.NewLine);
                            }

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            if (tempNpcParamInt == 551000)
                            {
                                tempThinkIdInt = 551111;
                            }
                            else
                            {
                                tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            }
                            tempGUY.Parts.Enemies[i].ModelName = modelName;
                        }
                    }
                }
                tempGUY.Write(currentMap);
            }
        }

        private void RandomizeMultipleBossBossFights(string currentMap, List<string> noNoList)
        {

        }

        private void GenerateBossList(string currentMap, List<string> noNoList)
        {
            Random rand = new Random();

            var tempGUY = MSBB.Read(currentMap);

            List<MSBB.Part.Enemy> tempList = new List<MSBB.Part.Enemy>();


            bool addEnemy;

            if (!oopsAll)
            {
                for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                {
                    addEnemy = false;
                    
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4540_0000"))
                    {
                        OoKEnemy = tempGUY.Parts.Enemies[i];
                    }

                    for (int j = 0; j < bossList.Count; j++)
                    {
                        if (tempGUY.Parts.Enemies[i].Name.Contains(bossList[j]))
                        {
                            if (tempGUY.Parts.Enemies[i].NPCParamID == 250060)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 250070)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 250090)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 212600)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 212610)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].NPCParamID == 212620)
                            {
                                addEnemy = false;
                            }
                            else if(tempGUY.Parts.Enemies[i].EntityID == -1)
                            {
                                addEnemy = false;
                            }
                            else if (tempList.Contains(tempGUY.Parts.Enemies[i]))
                            {
                                addEnemy = false;
                            }
                            else if(tempGUY.Parts.Enemies[i].NPCParamID == 0 || tempGUY.Parts.Enemies[i].NPCParamID == -1)
                            {
                                addEnemy = false;
                            }
                            else if (tempGUY.Parts.Enemies[i].ThinkParamID == -1)
                            {
                                addEnemy = false;
                            }
                            else if(tempGUY.Parts.Enemies[i].Name.Contains("c5070") && !lesserBossesBool)
                            {
                                addEnemy = false;
                            }
                            else if(tempGUY.Parts.Enemies[i].Name.Contains("c3060") && tempGUY.Parts.Enemies[i].NPCParamID != 210306016)
                            {
                                addEnemy = false;
                            }
                            else
                            {
                                addEnemy = true;

                                if (currentMap.Contains("m29"))
                                {
                                    for (int k = 0; k < chaliceBossParams.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[k])
                                        {
                                            chaliceBossMSB.Add(tempGUY.Parts.Enemies[i]);
                                            insertBossesEnemy.Add(tempGUY.Parts.Enemies[i]);
                                        }
                                    }
                                }

                                if (!currentMap.Contains("m29"))
                                {
                                    insertBossesEnemy.Add(tempGUY.Parts.Enemies[i]);
                                }

                                if(!currentMap.Contains("m26"))
                                {
                                    if(tempGUY.Parts.Enemies[i].Name.Contains("c0000_0005"))
                                    {
                                        addEnemy = false;
                                    }
                                }
                            }

                            if (currentMap.Contains("34"))
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID == 210030)
                                {
                                    addEnemy = false;
                                }
                            }

                            if(currentMap.Contains("m28"))
                            {
                                if(tempGUY.Parts.Enemies[i].Name.Contains("c2100"))
                                {
                                    addEnemy = false;
                                }
                            }

                            
                        }
                    }

                    if (addEnemy)
                    {
                        if (randomize)
                        {
                            if (!tempList.Contains(tempGUY.Parts.Enemies[i]))
                            {
                                if (!tempGUY.Parts.Enemies[i].Name.Contains("c2500_0000") && !tempGUY.Parts.Enemies[i].Name.Contains("c5071_0000") 
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0004") && !tempGUY.Parts.Enemies[i].Name.Contains("c2100_0000")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2100_0001") && !tempGUY.Parts.Enemies[i].Name.Contains("c4540_0000")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0001") && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0002")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0003") && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0001")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0000") && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2570") && !tempGUY.Parts.Enemies[i].Name.Contains("c2571")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0000") && !lesserBossesBool)
                                {
                                    bool add = true;

                                    for (int n = 0; n < tempList.Count; n++)
                                    {
                                        if (tempGUY.Parts.Enemies[i].NPCParamID == tempList[n].NPCParamID)
                                        {
                                            add = false;
                                        }
                                    }
                                    if (add)
                                    {
                                        bool addThisBoss = true;
                                        if (currentMap.Contains("m29"))
                                        {
                                            if (addedBossesList.Count > 0 && addedBossesList != null)
                                            {
                                                for (int n = 0; n < addedBossesList.Count; n++)
                                                {
                                                    if (tempGUY.Parts.Enemies[i].ModelName == addedBossesList[n].ModelName)
                                                    {
                                                        addThisBoss = false;
                                                    }
                                                }
                                                if(addThisBoss)
                                                {
                                                    tempList.Add(tempGUY.Parts.Enemies[i]);
                                                    addedBossesList.Add(tempGUY.Parts.Enemies[i]);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            tempList.Add(tempGUY.Parts.Enemies[i]);
                                            addedBossesList.Add(tempGUY.Parts.Enemies[i]);
                                        }
                                    }
                                }
                                else if(!tempGUY.Parts.Enemies[i].Name.Contains("c2500_0000") && !tempGUY.Parts.Enemies[i].Name.Contains("c5071_0000")
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c4540_0000") && !tempGUY.Parts.Enemies[i].Name.Contains("c2571")
                                    && lesserBossesBool)
                                {
                                    bool add = true;

                                    for (int n = 0; n < tempList.Count; n++)
                                    {
                                        if (tempGUY.Parts.Enemies[i].NPCParamID == tempList[n].NPCParamID)
                                        {
                                            add = false;
                                        }
                                    }
                                    if (add)
                                    {
                                        bool addThisBoss = true;
                                        if (currentMap.Contains("m29"))
                                        {
                                            if (addedBossesList.Count > 0 && addedBossesList != null)
                                            {
                                                for (int n = 0; n < addedBossesList.Count; n++)
                                                {
                                                    if (tempGUY.Parts.Enemies[i].ModelName == addedBossesList[n].ModelName)
                                                    {
                                                        addThisBoss = false;
                                                    }
                                                }
                                                if (addThisBoss)
                                                {
                                                    tempList.Add(tempGUY.Parts.Enemies[i]);
                                                    addedBossesList.Add(tempGUY.Parts.Enemies[i]);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            tempList.Add(tempGUY.Parts.Enemies[i]);
                                            addedBossesList.Add(tempGUY.Parts.Enemies[i]);
                                        }
                                    }
                                }
                                totalBossesToReplace++;
                            }
                        }
                    }
                }

                for (int i = 0; i < tempList.Count; i++)
                {
                    string tempString = tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName;
                    if (tempList[i].ThinkParamID.ToString() != "1")
                    {
                        enemyData.Add(tempList[i].NPCParamID.ToString() + "*" + tempList[i].ThinkParamID.ToString() + "*" + tempList[i].ModelName);

                    }
                }

                if (currentMap.Contains("m36"))
                {
                    OoKFirstPhase = OoKEnemy.NPCParamID.ToString() + "*" + OoKEnemy.ThinkParamID.ToString() + "*" + OoKEnemy.ModelName;
                }

                for (int i = 0; i < chaliceBossMSB.Count; i++)
                {
                    string tempString = chaliceBossMSB[i].NPCParamID.ToString() + "*" + chaliceBossMSB[i].ThinkParamID.ToString() + "*" + chaliceBossMSB[i].ModelName;
                    if (chaliceBossMSB[i].ThinkParamID.ToString() != "1")
                    {
                        chaliceBossString.Add(chaliceBossMSB[i].NPCParamID.ToString() + "*" + chaliceBossMSB[i].ThinkParamID.ToString() + "*" + chaliceBossMSB[i].ModelName);

                    }
                }

                for (int i = 0; i < insertBossesEnemy.Count; i++)
                {
                    string tempString = insertBossesEnemy[i].NPCParamID.ToString() + "*" + insertBossesEnemy[i].ThinkParamID.ToString() + "*" + insertBossesEnemy[i].ModelName;
                    if (insertBossesEnemy[i].ThinkParamID.ToString() != "1")
                    {
                        insertBossesString.Add(insertBossesEnemy[i].NPCParamID.ToString() + "*" + insertBossesEnemy[i].ThinkParamID.ToString() + "*" + insertBossesEnemy[i].ModelName);

                    }
                }
            }
        }

        private void AddOrphanPhaseOne(string currentMap, List<string> nonoList)
        {
            var tempGUY = MSBB.Read(currentMap);

            for(int i = 0; i < tempGUY.Parts.Enemies.Count; i ++)
            {
                

                if (currentMap.Contains("m24_01"))
                {
                    if(tempGUY.Parts.Enemies[i].Name.Contains("c2710_0000"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        string thisEnemy = OoKFirstPhase;

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                            writetext.WriteLine("This is first phase Orphan.");
                        }
                    }
                }
                else if (currentMap.Contains("m24_02"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0000"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        string thisEnemy = OoKFirstPhase;

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                            writetext.WriteLine("This is first phase Orphan.");
                        }
                    }
                }
                else if (currentMap.Contains("m34_00"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4510_0000"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        string thisEnemy = OoKFirstPhase;

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                            writetext.WriteLine("This is first phase Orphan.");
                        }
                    }
                }
            }

            tempGUY.Write(currentMap);
            tempGUY.Write(currentMap);
        }

        private void AddTheRest(string currentMap, List<string> nonoList)
        {
            var tempGUY = MSBB.Read(currentMap);

            for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
            {
                if (currentMap.Contains("m22"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2100_0001"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        Random rand = new Random();
                        int randomNumber = rand.Next(0, combinedBossList2.Count);
                        string thisEnemy = combinedBossList2[randomNumber];
                        combinedBossList2.RemoveAt(randomNumber);


                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                        {
                            randomNumber = rand.Next(0, combinedBossList2.Count);
                            thisEnemy = combinedBossList2[randomNumber];

                            tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);
                        }

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                        }
                    }
                }
                else if (currentMap.Contains("m27"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2120_0001"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        Random rand = new Random();
                        int randomNumber = rand.Next(0, combinedBossList2.Count);
                        string thisEnemy = combinedBossList2[randomNumber];
                        combinedBossList2.RemoveAt(randomNumber);

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                        {
                            randomNumber = rand.Next(0, combinedBossList2.Count);
                            thisEnemy = combinedBossList2[randomNumber];

                            tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);
                        }

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                        }
                    }

                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        Random rand = new Random();
                        int randomNumber = rand.Next(0, combinedBossList2.Count);
                        string thisEnemy = combinedBossList2[randomNumber];
                        combinedBossList2.RemoveAt(randomNumber);

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                        {
                            randomNumber = rand.Next(0, combinedBossList2.Count);
                            thisEnemy = combinedBossList2[randomNumber];

                            tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);
                        }

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                        }
                    }
                }
                else if (currentMap.Contains("m35_00"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0001"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        Random rand = new Random();
                        int randomNumber = rand.Next(0, combinedBossList2.Count);
                        string thisEnemy = combinedBossList2[randomNumber];
                        combinedBossList2.RemoveAt(randomNumber);

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                        {
                            randomNumber = rand.Next(0, combinedBossList2.Count);
                            thisEnemy = combinedBossList2[randomNumber];

                            tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);
                        }

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                        }
                    }

                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0002"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        Random rand = new Random();
                        int randomNumber = rand.Next(0, combinedBossList2.Count);
                        string thisEnemy = combinedBossList2[randomNumber];
                        combinedBossList2.RemoveAt(randomNumber);

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                        {
                            randomNumber = rand.Next(0, combinedBossList2.Count);
                            thisEnemy = combinedBossList2[randomNumber];

                            tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);
                        }

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                        }
                    }

                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0003"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                        Random rand = new Random();
                        int randomNumber = rand.Next(0, combinedBossList2.Count);
                        string thisEnemy = combinedBossList2[randomNumber];
                        combinedBossList2.RemoveAt(randomNumber);

                        string tempNpcParam;
                        string tempThinkId;
                        string modelName;

                        int tempNpcParamInt;
                        int tempThinkIdInt;

                        int tempnpcint = thisEnemy.IndexOf("*");
                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                        tempNpcParamInt = int.Parse(tempNpcParam);
                        tempThinkIdInt = int.Parse(tempThinkId);

                        while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                        {
                            randomNumber = rand.Next(0, combinedBossList2.Count);
                            thisEnemy = combinedBossList2[randomNumber];

                            tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);
                        }

                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                        using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                        {
                            writetext.WriteLine(bossCount);
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine(i + " Number in map list");
                            writetext.WriteLine("Old Boss");
                            writetext.WriteLine(thisnpc + " npcParam");
                            writetext.WriteLine(thisthink + " thinkID");
                            writetext.WriteLine(thismo + " model");
                            writetext.WriteLine(thisentityID);

                            writetext.WriteLine("New Boss");
                            writetext.WriteLine(tempNpcParam + " npcParam");
                            writetext.WriteLine(tempThinkId + " thinkID");
                            writetext.WriteLine(modelName + " model");
                        }
                    }
                }
            }

            tempGUY.Write(currentMap);
        }

        private void RandomizeBosses(string currentMap, List<string> nonoList)
        {
            int removalNumber = 0;

            if (randomize)
            {
                var tempGUY = MSBB.Read(currentMap);

                bool changeData;

                int addCounter = 0;

                
                if (!oopsAllBosses)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        
                        if(combinedBossList.Count <= 0)
                        {
                            combinedBossList = new List<string>();

                            for(int j = 0; j < combinedBossList2.Count; j ++)
                            {
                                combinedBossList.Add(combinedBossList2[j]);
                            }
                        }

                        changeData = false;

                        for (int j = 0; j < bossList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(bossList[j]))
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID == 250060)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250070)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250090)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212600)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212610)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212620)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].EntityID == -1)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 0 || tempGUY.Parts.Enemies[i].NPCParamID == -1)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].Name.Contains("c3060") && !currentMap.Contains("m29"))
                                {
                                    changeData = false;
                                }
                                else if(!currentMap.Contains("m36") && tempGUY.Parts.Enemies[i].ThinkParamID == 454000)
                                {
                                    changeData = false;
                                }
                                else if(currentMap.Contains("m22") && tempGUY.Parts.Enemies[i].Name.Contains("c2100_0001"))
                                {
                                    changeData = false;
                                }
                                else if(currentMap.Contains("m27") && tempGUY.Parts.Enemies[i].Name.Contains("c2120_0001"))
                                {
                                    changeData = false;
                                }
                                else if (currentMap.Contains("m27") && tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002"))
                                {
                                    changeData = false;
                                }
                                else if (currentMap.Contains("m35") && tempGUY.Parts.Enemies[i].Name.Contains("c4030_0001"))
                                {
                                    changeData = false;
                                }
                                else if (currentMap.Contains("m35") && tempGUY.Parts.Enemies[i].Name.Contains("c4030_0002"))
                                {
                                    changeData = false;
                                }
                                else if (currentMap.Contains("m35") && tempGUY.Parts.Enemies[i].Name.Contains("c4030_0003"))
                                {
                                    changeData = false;
                                }
                                else if(!currentMap.Contains("m26") && tempGUY.Parts.Enemies[i].Name.Contains("c0000_0005"))
                                {
                                    changeData = false;
                                    List<long> tempLong = new List<long>();
                                    tempLong.Add(tempGUY.Parts.Enemies[i].NPCParamID);
                                }
                                else if (tempGUY.Parts.Enemies[i].Name.Contains("c3060") && !currentMap.Contains("m29"))
                                {
                                    changeData = false;
                                }
                                else if(tempGUY.Parts.Enemies[i].Name.Contains("c4030_0004") && currentMap.Contains("m35"))
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    changeData = true;
                                    thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                    thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                    thismo = tempGUY.Parts.Enemies[i].ModelName;
                                    thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();
                                }

                                if (currentMap.Contains("34"))
                                {
                                    if (tempGUY.Parts.Enemies[i].NPCParamID == 210030)
                                    {
                                        changeData = false;
                                    }
                                }

                                if (currentMap.Contains("m28"))
                                {
                                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2100"))
                                    {
                                        changeData = false;
                                    }
                                }
                            }
                        }

                        if (currentMap.Contains("m29"))
                        {
                            changeData = false;

                            for (int k = 0; k < chaliceBossParams.Count; k++)
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[k])
                                {
                                    Random rand = new Random();
                                    int random = rand.Next(0, chaliceBossString.Count);
                                    string thisEnemy;

                                    thisEnemy = chaliceBossString[random];

                                    removalNumber = random;

                                    string tempNpcParam;
                                    string tempThinkId;
                                    string modelName;

                                    int tempNpcParamInt;
                                    int tempThinkIdInt;

                                    int tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                    tempNpcParamInt = int.Parse(tempNpcParam);
                                    tempThinkIdInt = int.Parse(tempThinkId);

                                    tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                    tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                    tempGUY.Parts.Enemies[i].ModelName = modelName;

                                    while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                    {
                                        random = rand.Next(0, chaliceBossString.Count);
                                        thisEnemy = chaliceBossString[random];
                                        removalNumber = random;

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        addCounter++;
                                        if (addCounter >= chaliceBossString.Count)
                                        {
                                            //enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
                                        }
                                    }

                                    string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                    string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                    string mo = tempGUY.Parts.Enemies[i].ModelName;
                                    string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                    tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                    tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                    tempGUY.Parts.Enemies[i].ModelName = modelName;

                                    using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                                    {
                                        writetext.WriteLine(bossCount);
                                        writetext.WriteLine(currentMap);
                                        writetext.WriteLine(i + " Number in map list");
                                        writetext.WriteLine("Old Boss");
                                        writetext.WriteLine(thisnpc + " npcParam");
                                        writetext.WriteLine(thisthink + " thinkID");
                                        writetext.WriteLine(thismo + " model");
                                        writetext.WriteLine(thisentityID);

                                        writetext.WriteLine("New Boss");
                                        writetext.WriteLine(tempNpcParam + " npcParam");
                                        writetext.WriteLine(tempThinkId + " thinkID");
                                        writetext.WriteLine(modelName + " model");

                                        writetext.WriteLine("Enemy Pool Count: " + chaliceBossString.Count + Environment.NewLine + Environment.NewLine);
                                    }
                                }
                            }
                        }

                        

                        if (changeData && combinedBossList.Count > 0)
                        {
                            oldNPCParam.Add(tempGUY.Parts.Enemies[i].NPCParamID);

                            Random rand = new Random();
                            int random = rand.Next(0, combinedBossList.Count);
                            string thisEnemy;

                            thisEnemy = combinedBossList[random];

                            removalNumber = random;

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            
                            if(currentMap.Contains("m24_00"))
                            {
                                while(modelName.Contains("4500"))
                                {
                                    random = rand.Next(0, combinedBossList.Count);
                                    thisEnemy = combinedBossList[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }
                            

                            
                            if (currentMap.Contains("m24_02"))
                            {
                                while (modelName.Contains("5100") || modelName.Contains("8050") || modelName.Contains("4520") || modelName.Contains("4500"))
                                {
                                    random = rand.Next(0, combinedBossList.Count);
                                    thisEnemy = combinedBossList[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }
                            

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;

                            if (!currentMap.Contains("m29"))
                            {
                                while (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                {
                                    random = rand.Next(0, combinedBossList.Count);
                                    thisEnemy = combinedBossList[random];
                                    removalNumber = random;

                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                    tempNpcParamInt = int.Parse(tempNpcParam);
                                    tempThinkIdInt = int.Parse(tempThinkId);

                                    addCounter++;
                                    if (addCounter >= combinedBossList.Count)
                                    {
                                        //enemyDataRandomized.Add(secondaryBosses[random]);
                                        addCounter = 0;
                                    }
                                }

                                string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                string mo = tempGUY.Parts.Enemies[i].ModelName;
                                string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                tempGUY.Parts.Enemies[i].ModelName = modelName;
                                if (tempNpcParamInt == 507200)
                                {
                                    tempGUY.Parts.Enemies[i].ThinkParamID = 507200;
                                }
                                //Emissary fix
                                if (tempGUY.Parts.Enemies[i].Name == "c2500_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c2570_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //wet nurse fix
                                if (tempGUY.Parts.Enemies[i].Name == "c5510_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0002")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //maria fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4520_0002")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4520_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //living failures fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4030_0004")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4030_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                
                                

                                using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                                {
                                    writetext.WriteLine(bossCount);
                                    writetext.WriteLine(currentMap);
                                    writetext.WriteLine(i + " Number in map list");
                                    writetext.WriteLine("Old Boss");
                                    writetext.WriteLine(thisnpc + " npcParam");
                                    writetext.WriteLine(thisthink + " thinkID");
                                    writetext.WriteLine(thismo + " model");
                                    writetext.WriteLine(thisentityID);

                                    writetext.WriteLine("New Boss");
                                    writetext.WriteLine(tempNpcParam + " npcParam");
                                    writetext.WriteLine(tempThinkId + " thinkID");
                                    writetext.WriteLine(modelName + " model");

                                    combinedBossList.RemoveAt(random);
                                    writetext.WriteLine("Enemy Pool Count: " + combinedBossList.Count);

                                    for (int m = combinedBossList.Count - 1; m >= 0; m--)
                                    {
                                        if(combinedBossList[m].Contains("*" + modelName) && !combinedBossList[m].Contains("*4510"))
                                        {
                                            combinedBossList.RemoveAt(m);
                                        }
                                    }

                                    writetext.WriteLine("New count after removing similar bosses " + combinedBossList.Count + Environment.NewLine + Environment.NewLine);
                                }
                            }
                            

                            bossCount++;
                            newNPCParam.Add(paramNumber);
                            mapsForParamChanges.Add(currentMap);
                            paramNumber--;

                        }
                    }
                }
                
                if(oopsAllBosses)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        changeData = false;

                        for (int j = 0; j < bossList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(bossList[j]))
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID == 250060)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250070)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 250090)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212600)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212610)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 212620)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].EntityID == -1)
                                {
                                    changeData = false;
                                }
                                else if (tempGUY.Parts.Enemies[i].NPCParamID == 0 || tempGUY.Parts.Enemies[i].NPCParamID == -1)
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    if (currentMap.Contains("m29"))
                                    {
                                        changeData = false;

                                        for (int k = 0; k < chaliceBossParams.Count; k++)
                                        {
                                            if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[k])
                                            {
                                                changeData = true;
                                                thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                                thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                                thismo = tempGUY.Parts.Enemies[i].ModelName;
                                                thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        changeData = true;
                                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();
                                    }
                                }

                                if (currentMap.Contains("34"))
                                {
                                    if (tempGUY.Parts.Enemies[i].NPCParamID == 210030)
                                    {
                                        changeData = false;
                                    }
                                }
                            }
                        }


                        if (changeData && BossListString.Count > 0)
                        {

                            Random rand = new Random();
                            int random = rand.Next(0, BossListString.Count);
                            string thisEnemy = BossListString[random];

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;


                            if (!currentMap.Contains("m29"))
                            {

                                string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                string mo = tempGUY.Parts.Enemies[i].ModelName;
                                string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                tempGUY.Parts.Enemies[i].ModelName = modelName;

                                if (tempNpcParamInt == 507200)
                                {
                                    tempGUY.Parts.Enemies[i].ThinkParamID = 507200;
                                }
                                //emissary fix
                                if (tempGUY.Parts.Enemies[i].Name == "c2500_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c2570_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //wet nurse fix
                                if (tempGUY.Parts.Enemies[i].Name == "c5510_0000")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0001")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                        if (tempGUY.Parts.Enemies[k].Name == "c5510_0002")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //maria fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4520_0002")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4520_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }
                                //living failures fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4030_0004")
                                {
                                    for (int k = 0; k < tempGUY.Parts.Enemies.Count; k++)
                                    {
                                        if (tempGUY.Parts.Enemies[k].Name == "c4030_0000")
                                        {
                                            tempGUY.Parts.Enemies[k].NPCParamID = tempNpcParamInt;
                                            tempGUY.Parts.Enemies[k].ThinkParamID = tempThinkIdInt;
                                            tempGUY.Parts.Enemies[k].ModelName = modelName;
                                        }
                                    }
                                }

                                using (StreamWriter writetext = File.AppendText(bossLogFilePath))
                                {
                                    writetext.WriteLine(bossCount);
                                    writetext.WriteLine(currentMap);
                                    writetext.WriteLine(i + " Number in map list");
                                    writetext.WriteLine("Old Boss");
                                    writetext.WriteLine(thisnpc + " npcParam");
                                    writetext.WriteLine(thisthink + " thinkID");
                                    writetext.WriteLine(thismo + " model");
                                    writetext.WriteLine(thisentityID);

                                    writetext.WriteLine("New Boss");
                                    writetext.WriteLine(tempNpcParam + " npcParam");
                                    writetext.WriteLine(tempThinkId + " thinkID");
                                    writetext.WriteLine(modelName + " model");

                                    writetext.WriteLine("Enemy Pool Count: " + BossListString.Count + Environment.NewLine + Environment.NewLine);
                                }
                            }
                            bossCount++;
                            newNPCParam.Add(paramNumber);
                            mapsForParamChanges.Add(currentMap);
                            paramNumber--;

                        }

                    }
                }

                tempGUY.Write(currentMap);
            }
        }

        private void Chalice_Checked(object sender, RoutedEventArgs e)
        {
            chaliceEnemies = ChaliceEnemies.IsChecked.Value;
        }



        private void Randomize(string currentMap, List<string> nonoList)
        {
            if(randomize)
            {
                var tempGUY = MSBB.Read(currentMap);

                bool changeData;
                bool cc = true;

                if (!oopsAll && randomizeEnemiesBool)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        changeData = true;

                        for (int j = 0; j < nonoList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(nonoList[j]))
                            {
                                changeData = false;
                                cc = false;
                            }
                        }

                        if (currentMap.Contains("m29"))
                        {
                            for (int j = 0; j < chaliceBossParams.Count; j++)
                            {
                                if (tempGUY.Parts.Enemies[i].NPCParamID.ToString() == chaliceBossParams[j])
                                {
                                    changeData = false;
                                }

                                if (tempGUY.Parts.Enemies[i].ModelName.Contains("1050"))
                                {
                                    changeData = false;
                                }
                            }
                        }

                        if (currentMap.Contains("22_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= HemwickChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("23_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= OldYharnamChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("24_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= CathedralWardChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("24_01"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= CentralYharnamChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("24_02"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= UpperCathedralWardChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("25_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= CainhurstChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("26_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= NightmareOfMensisChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("27_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= WoodsChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("28_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= YahargulChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("32_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= ByrgenwerthChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("33_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= FrontierChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("34_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= HuntersNightmareChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("35_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= ResearchHallChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("36_00"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 101);
                            if (randChoose >= HamletChance)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cc)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("m28"))
                        {
                            if(tempGUY.Parts.Enemies[i].Name.Contains("c1050_0117"))
                            {
                                changeData = true;
                            }

                            if (tempGUY.Parts.Enemies[i].Name.Contains("c1050_0115"))
                            {
                                changeData = true;
                            }

                            if (tempGUY.Parts.Enemies[i].Name.Contains("c1050_0119"))
                            {
                                changeData = true;
                            }

                            if (tempGUY.Parts.Enemies[i].Name.Contains("c1050_0110"))
                            {
                                changeData = true;
                            }

                            if (tempGUY.Parts.Enemies[i].Name.Contains("c1050_0112"))
                            {
                                changeData = true;
                            }

                            if (tempGUY.Parts.Enemies[i].Name.Contains("c1050_0114"))
                            {
                                changeData = true;
                            }
                        }

                        if (changeData && enemyDataRandomized.Count > 0)
                        {
                            Random rand = new Random();
                            float chaliceRandom = rand.Next(0, 101);
                            int randomChalice = 0;
                            if (chaliceEnemies)
                            {
                                randomChalice = rand.Next(0, chaliceEnemiesString.Count);
                            }
                            int random = rand.Next(0, enemyDataRandomized.Count);
                            string thisEnemy;
                            if (chaliceRandom <= chaliceChanceFloat && chaliceEnemies)
                            {
                                thisEnemy = chaliceEnemiesString[random];
                            }
                            else if (currentMap.Contains("m29") && chaliceEnemies)
                            {
                                thisEnemy = chaliceEnemiesString[randomChalice];
                            }
                            else
                            {
                                thisEnemy = enemyDataRandomized[random];
                            }

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            Console.WriteLine(enemyDataRandomized[0]);

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            string originalModelName = tempGUY.Parts.Enemies[i].ModelName;
                            long originalModelValue = 0;
                            long newModelValue = 0;

                            int tries = 0;

                            for(int j = 0; j < nameList.Count; j ++)
                            {
                                if(nameList[j].Contains(originalModelName))
                                {
                                    originalModelValue = sizeList[j];
                                }

                                if(nameList[j].Contains(modelName))
                                {
                                    newModelValue = sizeList[j];
                                }
                            }

                            if (currentMap.Contains("m24_02") || currentMap.Contains("m35"))
                            {
                                while (newModelValue >= (originalModelValue) && tries < 30)
                                {
                                    if (chaliceEnemies)
                                    {
                                        randomChalice = rand.Next(0, chaliceEnemiesString.Count);
                                    }
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    if (chaliceRandom <= chaliceChanceFloat && chaliceEnemies)
                                    {
                                        thisEnemy = chaliceEnemiesString[random];
                                    }
                                    else if (currentMap.Contains("m29") && chaliceEnemies)
                                    {
                                        thisEnemy = chaliceEnemiesString[randomChalice];
                                    }
                                    else
                                    {
                                        thisEnemy = enemyDataRandomized[random];
                                    }

                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                    for (int j = 0; j < nameList.Count; j++)
                                    {
                                        if (nameList[j].Contains(originalModelName))
                                        {
                                            originalModelValue = sizeList[j];
                                        }

                                        if (nameList[j].Contains(modelName))
                                        {
                                            newModelValue = sizeList[j];

                                        }
                                    }

                                    tries++;
                                }
                            }
                            else
                            {
                                while (newModelValue > (originalModelValue + 20000000) && tries < 30)
                                {
                                    if (chaliceEnemies)
                                    {
                                        randomChalice = rand.Next(0, chaliceEnemiesString.Count);
                                    }
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    if (chaliceRandom <= chaliceChanceFloat && chaliceEnemies)
                                    {
                                        thisEnemy = chaliceEnemiesString[random];
                                    }
                                    else if (currentMap.Contains("m29") && chaliceEnemies)
                                    {
                                        thisEnemy = chaliceEnemiesString[randomChalice];
                                    }
                                    else
                                    {
                                        thisEnemy = enemyDataRandomized[random];
                                    }

                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                    for (int j = 0; j < nameList.Count; j++)
                                    {
                                        if (nameList[j].Contains(originalModelName))
                                        {
                                            originalModelValue = sizeList[j];
                                        }

                                        if (nameList[j].Contains(modelName))
                                        {
                                            newModelValue = sizeList[j];

                                        }
                                    }

                                    tries++;
                                }
                            }

                            if (currentMap.Contains("m24_02"))
                            {
                                while (modelName.Contains("c1000") || modelName.Contains("c5040") || modelName.Contains("2630")
                                    || modelName.Contains("1051") || modelName.Contains("c1180"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }

                            if (currentMap.Contains("m35"))
                            {
                                while (modelName.Contains("c1000") || modelName.Contains("c5040") || modelName.Contains("2630")
                                    || modelName.Contains("1051") || modelName.Contains("c1180") || modelName.Contains("c1111")
                                     || modelName.Contains("c2620") || modelName.Contains("2090") || modelName.Contains("1250")
                                      || modelName.Contains("1260"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }


                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                            string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                            string mo = tempGUY.Parts.Enemies[i].ModelName;
                            string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;

                            using (StreamWriter writetext = File.AppendText(enemyLogFilePath))
                            {
                                writetext.WriteLine(currentMap);
                                writetext.WriteLine(i + " Number in map list");
                                writetext.WriteLine("Old Enemy");
                                writetext.WriteLine(npc + " npcParam");
                                writetext.WriteLine(think + " thinkID");
                                writetext.WriteLine(mo + " model");
                                writetext.WriteLine(entityID);

                                writetext.WriteLine("New Enemy");
                                writetext.WriteLine(tempNpcParam + " npcParam");
                                writetext.WriteLine(tempThinkId + " thinkID");
                                writetext.WriteLine(modelName + " model" + Environment.NewLine);
                            }
                        }


                    }
                }
                else if(oopsAll)
                {
                    for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
                    {
                        changeData = true;

                        for (int j = 0; j < unusedList.Count; j++)
                        {
                            if (tempGUY.Parts.Enemies[i].Name.Contains(nonoList[j]))
                            {
                                changeData = false;
                            }
                        }

                        if (changeData && oopsAllEnemyString.Count > 0)
                        {
                            Random rand = new Random();
                            int random = rand.Next(0, oopsAllEnemyString.Count);
                            string thisEnemy;
                            thisEnemy = oopsAllEnemyString[random];

                            string tempNpcParam;
                            string tempThinkId;
                            string modelName;

                            int tempNpcParamInt;
                            int tempThinkIdInt;

                            Console.WriteLine(oopsAllEnemyString[0]);

                            int tempnpcint = thisEnemy.IndexOf("*");
                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                            tempNpcParamInt = int.Parse(tempNpcParam);
                            tempThinkIdInt = int.Parse(tempThinkId);

                            string npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                            string think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                            string mo = tempGUY.Parts.Enemies[i].ModelName;
                            string entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                            tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                            tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                            tempGUY.Parts.Enemies[i].ModelName = modelName;

                            using (StreamWriter writetext = File.AppendText(enemyLogFilePath))
                            {
                                writetext.WriteLine(currentMap);
                                writetext.WriteLine(i + " Number in map list");
                                writetext.WriteLine("Old Enemy");
                                writetext.WriteLine(npc + " npcParam");
                                writetext.WriteLine(think + " thinkID");
                                writetext.WriteLine(mo + " model");
                                writetext.WriteLine(entityID);

                                writetext.WriteLine("New Enemy");
                                writetext.WriteLine(tempNpcParam + " npcParam");
                                writetext.WriteLine(tempThinkId + " thinkID");
                                writetext.WriteLine(modelName + " model" + Environment.NewLine);
                            }
                        }


                    }
                }
                tempGUY.Write(currentMap);
            }
        }
        
        private void RandomizeItemDrops()
        {
            string newItemLotToSet = "-1";

            Random rand = new Random();

            List<string> newItemLotList = new List<string>();

            List<int> npcParamList = new List<int>();

            List<string> dontUseList = new List<string>();

            for (int i = 0; i < unusedList.Count; i++)
            {
                dontUseList.Add(unusedList[i]);
            }
            for(int i = 0; i < bossList.Count; i ++)
            {
                dontUseList.Add(bossList[i]);
            }

            for (int i = 0; i < mapList.Count; i++)
            {
                var tempGUY = MSBB.Read(mapList[i]);

                for (int j = 0; j < tempGUY.Parts.Enemies.Count; j++)
                {
                    bool add = true;

                    for (int h = 0; h < dontUseList.Count; h++)
                    {
                        if (tempGUY.Parts.Enemies[j].Name.Contains(dontUseList[h]))
                        {
                            add = false;
                            h = dontUseList.Count + 1;
                        }
                    }

                    if (add)
                    {
                        npcParamList.Add(tempGUY.Parts.Enemies[j].NPCParamID);
                    }
                }
            }

            List<int> uniqueNPCList = npcParamList.Distinct().ToList();
            npcParamList = new List<int>();

            for (int i = 0; i < uniqueNPCList.Count; i++)
            {
                npcParamList.Add(uniqueNPCList[i]);
            }

            var logFile = File.ReadAllLines(filePath + "\\Mod Files\\NPC Scaling File\\NPCScalingFile.txt");
            logList2 = new List<string>(logFile);

            longList2 = new List<long>();
            for (int i = 0; i < logList2.Count; i++)
            {
                longList2.Add(long.Parse(logList2[i]));
            }

            //////////////////////////////////////////////////////////////////////////


            var paramdefs = new List<PARAMDEF>();
            var paramdefbnd = BND4.Read(paramDefPath);
            foreach (BinderFile file in paramdefbnd.Files)
            {
                var paramdef = PARAMDEF.Read(file.Bytes);
                paramdefs.Add(paramdef);
            }

            var parms = new Dictionary<string, PARAM>();
            var parambnd = BND4.Read(paramPath);
            foreach (BinderFile file in parambnd.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                var param = PARAM.Read(file.Bytes);

                param.ApplyParamdef(paramdefs.Find(def => def.ParamType == param.ParamType));
                parms[name] = param;
            }

            PARAM npcParamRow = parms["NpcParam"];

            for (int i = 0; i < npcParamRow.Rows.Count; i ++)
            {
                for(int j = 0; j < npcParamList.Count; j ++)
                {
                    if(npcParamRow.Rows[i].ID == Convert.ToInt64(npcParamList[j]))
                    {
                        if (npcParamRow.Rows[i].Cells[11].Value != null)
                        {

                            string testString = npcParamRow.Rows[i].Cells[11].Value.ToString();

                            if (testString != "-1")
                            {
                                newItemLotList.Add(npcParamRow.Rows[i].Cells[11].Value.ToString());
                            }
                            else
                            {
                                npcParamList.RemoveAt(j);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < npcParamRow.Rows.Count; i ++)
            {
                for(int j = 0; j < npcParamList.Count; j ++)
                {
                    if (npcParamRow.Rows[i].ID == npcParamList[j] && newItemLotList.Count > 0)
                    {
                        int randomNumber = rand.Next(0,newItemLotList.Count);

                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("Old item lot");
                            writetext.WriteLine(npcParamRow.Rows[i]);
                            writetext.WriteLine(npcParamRow.Rows[i].Cells[11].Value.ToString());
                            writetext.WriteLine("New item lot");
                            writetext.WriteLine(newItemLotList[randomNumber]);
                            writetext.WriteLine(Environment.NewLine);
                        }

                        npcParamRow.Rows[i].Cells[11].Value = Int32.Parse(newItemLotList[randomNumber]);

                        newItemLotList.RemoveAt(randomNumber);
                    }
                }
            }

            for (int i = 0; i < npcParamList.Count; i ++)
            {
                List<int> newParamList = new List<int>();

                for(int j = 0; j < longList2.Count; j ++)
                {
                    if(npcParamList[i] == longList2[j])
                    {
                        for(int k = 1; k < 30; k ++)
                        {
                            newParamList.Add(Convert.ToInt32(longList2[k]));
                            j = longList2.Count + 1;
                        }
                    }
                }

                for (int j = 0; j < npcParamRow.Rows.Count; j ++)
                {
                    if(npcParamRow.Rows[j].ID == Convert.ToInt64(npcParamList[i]))
                    {
                        newItemLotToSet = npcParamRow.Rows[j].Cells[11].Value.ToString();
                        j = npcParamRow.Rows.Count;
                    }
                }

                int stopAt31 = 0;

                for(int j = 0; j < npcParamRow.Rows.Count; j ++)
                {
                    for(int k = 0; k < newParamList.Count; k ++)
                    {
                        if(npcParamRow.Rows[j].ID == newParamList[k])
                        {
                            stopAt31++;
                            npcParamRow.Rows[j].Cells[11].Value = Int32.Parse(newItemLotToSet);
                            k = newParamList.Count + 1;
                        }
                    }

                    if(stopAt31 == 31)
                    {
                        j = npcParamRow.Rows.Count;
                    }
                }
            }

            foreach (BinderFile file in parambnd.Files)
            {
                string name = Path.GetFileNameWithoutExtension(file.Name);
                if (parms.ContainsKey(name))
                    file.Bytes = parms[name].Write();
            }
            parambnd.Write(paramPath);
        }

        private void RandomizeKeys()
        {
            List<string> mapList = new List<string>();

            List<string> mapsThatByrgenwerthClassroomKeyCanBeIn = new List<string>();
            List<string> mapsThatRomFightKeyCanBeIn = new List<string>();
            List<string> mapsThatCainhurstSummonsCanBeIn = new List<string>();
            List<string> mapsThatEyePendantCanBeIn = new List<string>();

            mapList.Add("m21_01"); // Abandoned Old Workshop
            mapList.Add("m22_00"); // Hemwick Charnel Lane
            mapList.Add("m23_00"); // Old Yharnam
            mapList.Add("m24_00"); // Cathedral Ward
            mapList.Add("m24_01"); // Central Yharnam, Iosefka's Clinic
            mapList.Add("m24_02"); // Upper Cathedral Ward, Healing Church Workshop, Altar of Despair
            mapList.Add("m25_00"); // Forsaken Castle Cainhurst
            mapList.Add("m26_00"); // Nightmare of Mensis
            mapList.Add("m27_00"); // Forbidden Woods
            mapList.Add("m28_00"); // Yahar'gul, Unseen Village
            mapList.Add("m32_00"); // Byrgenwerth, Lecture Building, Moonside Lake
            mapList.Add("m33_00"); // Nightmare Frontier
            mapList.Add("m34_00"); // Hunter's Nightmare
            mapList.Add("m35_00"); // Research Hall
            mapList.Add("m36_00"); // Fishing Hamlet

            Random rand = new Random();

            bool continueSelectingAMap = true;

            int randomNumber = 0;

            while (continueSelectingAMap)
            {
                randomNumber = rand.Next(0, mapList.Count);

                if(mapList[randomNumber] != "m24_02")
                {
                    continueSelectingAMap = false;
                }
            }

            string startingMap = mapList[randomNumber];

            switch(startingMap)
            {
                case "m21_01":
                    // Abandoned Old Workshop
                    break;
                case "m22_00":
                    // Hemwick Charnel Lane
                    break;
                case "m23_00":
                    // Old Yharnam
                    break;
                case "m24_00":
                    // Cathedral Ward
                    break;
                case "m24_01":
                    // Central Yharnam, Iosefka's Clinic
                    break;
                case "m25_00":
                    // Forsaken Castle Cainhurst
                    break;
                case "m26_00":
                    // Nightmare of Mensis
                    break;
                case "m27_00":
                    // Forbidden Woods
                    break;
                case "m28_00":
                    // Yahar'gul, Unseen Village
                    break;
                case "m32_00":
                    // Byrgenwerth, Lecture Building, Moonside Lake
                    break;
                case "m33_00":
                    // Nightmare Frontier
                    break;
                case "m34_00":
                    // Hunter's Nightmare
                    break;
                case "m35_00":
                    // Research Hall
                    break;
                case "m36_00":
                    // Fishing Hamlet
                    break;
            }
        }

        private void GenerateItemLotList(string currentMap)
        {
            var tempGuy = MSBB.Read(currentMap);

            for (int i = 0; i < tempGuy.Events.Treasures.Count; i++)
            {
                bool changeKey = true;

                for (int j = 0; j < nonoItemLots.Count; j++)
                {
                    if (tempGuy.Events.Treasures[i].ItemLot1 == nonoItemLots[j])
                    {
                        changeKey = false;
                    }
                }

                if (tempGuy.Events.Treasures[i].ItemLot1 > 1 && changeKey)
                {
                    itemLotList.Add(tempGuy.Events.Treasures[i].ItemLot1);
                }
            }
        }

        private void GenerateDummyEnemyList(string currentMap)
        {
            var tempGuy = MSBB.Read(currentMap);

            for(int i = 0; i < tempGuy.Parts.DummyEnemies.Count; i ++)
            {
                if(tempGuy.Parts.DummyEnemies[i].Description == "【カットシーン用】")
                {
                    dummyEnemyList.Add(tempGuy.Parts.DummyEnemies[i]);
                }
            }

            for (int i = 0; i < dummyEnemyList.Count; i++)
            {
                dummyEnemyStringList.Add(dummyEnemyList[i].NPCParamID.ToString() + "*" + dummyEnemyList[i].ThinkParamID.ToString() + "*" + dummyEnemyList[i].ModelName);
            }
        }

        private void RandomizeDummyEnemies(string currentMap)
        {
            var tempGuy = MSBB.Read(currentMap);

            for(int i = 0; i < tempGuy.Parts.DummyEnemies.Count; i ++)
            {
                if (tempGuy.Parts.DummyEnemies[i].Description == "【カットシーン用】")
                {
                    Random rand = new Random();

                    int randomNumber = rand.Next(0, dummyEnemyStringList.Count);
                    string thisEnemy = dummyEnemyStringList[randomNumber];

                    int removalNumber;

                    removalNumber = randomNumber;

                    string tempNpcParam;
                    string tempThinkId;
                    string modelName;

                    int tempNpcParamInt;
                    int tempThinkIdInt;

                    int tempnpcint = thisEnemy.IndexOf("*");
                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                    tempNpcParamInt = int.Parse(tempNpcParam);
                    tempThinkIdInt = int.Parse(tempThinkId);

                    thisnpc = tempGuy.Parts.DummyEnemies[i].NPCParamID.ToString();
                    thisthink = tempGuy.Parts.DummyEnemies[i].ThinkParamID.ToString();
                    thismo = tempGuy.Parts.DummyEnemies[i].ModelName;
                    thisentityID = tempGuy.Parts.DummyEnemies[i].EntityID.ToString();

                    tempGuy.Parts.DummyEnemies[i].NPCParamID = tempNpcParamInt;
                    tempGuy.Parts.DummyEnemies[i].ThinkParamID = tempThinkIdInt;
                    tempGuy.Parts.DummyEnemies[i].ModelName = modelName;

                    using (StreamWriter writetext = File.AppendText(dummyFilePath))
                    {
                        writetext.WriteLine(currentMap);
                        writetext.WriteLine(i + " Number in map list");
                        writetext.WriteLine("Old Model");
                        writetext.WriteLine(thisnpc + " npcParam");
                        writetext.WriteLine(thisthink + " thinkID");
                        writetext.WriteLine(thismo + " model");
                        writetext.WriteLine(thisentityID);

                        writetext.WriteLine("New Model");
                        writetext.WriteLine(tempNpcParam + " npcParam");
                        writetext.WriteLine(tempThinkId + " thinkID");
                        writetext.WriteLine(modelName + " model");
                        writetext.WriteLine(Environment.NewLine);
                    }

                    dummyEnemyStringList.RemoveAt(removalNumber);
                }
            }

            tempGuy.Write(currentMap);
        }

        private void RandomizeItemLots(string currentMap)
        {
            var tempGuy = MSBB.Read(currentMap);

            Random rand = new Random();

            int randomNumber;

            if (itemLotList.Count > 0)
            {
                for (int i = 0; i < tempGuy.Events.Treasures.Count; i++)
                {
                    bool changeKey = true;

                    for (int j = 0; j < nonoItemLots.Count; j++)
                    {
                        if (tempGuy.Events.Treasures[i].ItemLot1 == nonoItemLots[j])
                        {
                            changeKey = false;
                        }
                    }

                    if (tempGuy.Events.Treasures[i].ItemLot1 > 0 && changeKey)
                    {
                        numberOfKeyIemsRandomized++;

                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine(currentMap);
                            writetext.WriteLine("Number of items randomized so far " + numberOfKeyIemsRandomized);
                            writetext.WriteLine("Old item lot");
                            writetext.WriteLine(tempGuy.Events.Treasures[i].ItemLot1);
                        }
                            
                        randomNumber = rand.Next(0, itemLotList.Count);
                        tempGuy.Events.Treasures[i].ItemLot1 = itemLotList[randomNumber];

                        using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
                        {
                            writetext.WriteLine("New item lot");
                            writetext.WriteLine(itemLotList[randomNumber]);
                            writetext.WriteLine(Environment.NewLine);
                        }

                        itemLotList.RemoveAt(randomNumber);
                    }
                }
            }

            tempGuy.Write(currentMap);
        }

        private void BossCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            includeBosses = BossCheckBox.IsChecked.Value;
            chaliceBosses = BossCheckBox.IsChecked.Value;
        }

        private void InsertBosses_Checked(object sender, RoutedEventArgs e)
        {
            insertBossesBool = InsertBosses.IsChecked.Value;
            MessageBox.Show("This may make the game unstable\r\nand cause crashing.\r\nUse this feature at your own risk.");
        }

        private void ChaliceBoss_Checked(object sender, RoutedEventArgs e)
        {
            //chaliceBosses = ChaliceBoss.IsChecked.Value;
        }

        private void OopsAllCheck_Checked(object sender, RoutedEventArgs e)
        {
            oopsAll = OopsAllCheck.IsChecked.Value;
        }

        private void SeedBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OopsAllStringName_TextChanged(object sender, TextChangedEventArgs e)
        {
            oopsAllString = OopsAllStringName.Text;
        }

        private void ItemRandoCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void KeyItemCheck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void GetItemLot_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void VFXCheck_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void TalkCheck_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void SpEffectCheck_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void BulletCheck_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void GemEffectCheck_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void MagicCheck_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void OopsBoss_TextChanged(object sender, TextChangedEventArgs e)
        {
            oopsBossString = OopsBoss.Text;
        }

        private void OopsAllBossesCheck_Checked(object sender, RoutedEventArgs e)
        {
            oopsAllBosses = OopsAllBossesCheck.IsChecked.Value;
            includeBosses = OopsAllBossesCheck.IsChecked.Value;
        }

        private void RandomizeEnemiesCheck_Checked(object sender, RoutedEventArgs e)
        {
            randomizeEnemiesBool = RandomizeEnemiesCheck.IsChecked.Value;
        }

        private void AddNPCS_Checked(object sender, RoutedEventArgs e)
        {
            includeNPCs = AddNPCS.IsChecked.Value;
        }

        private void ArmorRandomizerCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            randomizeItemLots = ArmorRandomizerCheckBox.IsChecked.Value;
        }

        private void TotalProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void UpdateUI()
        {
            CurrentTaskLabel.Content = currentTask; ;
            TotalProgressBar.Value = totalPercent;
        }

        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (running)
            {
                UpdateUI();
            }
        }

        private void TEST_Click(object sender, RoutedEventArgs e)
        {
            new Thread(DoSomething).Start();
            new Thread(DoSomething2).Start();
        }

        private void BellMaidenBox_Checked(object sender, RoutedEventArgs e)
        {
            bellMaidenBool = BellMaidenBox.IsChecked.Value;
        }

        private void LesserBossesBox_Checked(object sender, RoutedEventArgs e)
        {
            lesserBossesBool = LesserBossesBox.IsChecked.Value;
        }

        private void RandomizeKeyItemsBox_Checked(object sender, RoutedEventArgs e)
        {
            keyItemRandomizeBool = RandomizeKeyItemsBox.IsChecked.Value;
        }

        private void RandomizeShopBox_Checked(object sender, RoutedEventArgs e)
        {
            shopBool = RandomizeShopBox.IsChecked.Value;
        }

        private void EnemyDropBox_Checked(object sender, RoutedEventArgs e)
        {
            enemyDropBool = EnemyDropBox.IsChecked.Value;
        }

        private void WorkshopBox_Checked(object sender, RoutedEventArgs e)
        {
            workshopBool = WorkshopBox.IsChecked.Value;
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void BossUpPointOne_Click(object sender, RoutedEventArgs e)
        {
            if (bossPercentage < 100)
            {
                bossPercentage += .1f;

                if (bossPercentage > 100)
                {
                    bossPercentage = 100;
                }

                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
            else
            {
                bossPercentage = 100;
                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
        }

        private void BossUpOne_Click(object sender, RoutedEventArgs e)
        {
            if (bossPercentage < 100)
            {
                bossPercentage += 1f;

                if(bossPercentage > 100)
                {
                    bossPercentage = 100;
                }

                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
            else
            {
                bossPercentage = 100;
                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
        }

        private void BossUpPointOne_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (bossPercentage >= .1f)
            {
                bossPercentage -= .1f;

                if(bossPercentage < 0)
                {
                    bossPercentage = 0;
                }

                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
            else
            {
                bossPercentage = 0;
                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
        }

        private void BossUpOne_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (bossPercentage >= 1)
            {
                bossPercentage -= 1f;

                if (bossPercentage < 0)
                {
                    bossPercentage = 0;
                }

                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
            else
            {
                bossPercentage = 0;
                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
        }


        private void BossUpTen_Click(object sender, RoutedEventArgs e)
        {
            if (bossPercentage < 100)
            {
                bossPercentage += 10f;

                if (bossPercentage > 100)
                {
                    bossPercentage = 100;
                }

                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
            else
            {
                bossPercentage = 100;
                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
        }

        private void BossDownTen_Click(object sender, RoutedEventArgs e)
        {
            if (bossPercentage >= 10)
            {
                bossPercentage -= 10f;

                if (bossPercentage < 0)
                {
                    bossPercentage = 0;
                }

                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
            else
            {
                bossPercentage = 0;
                BossPercentageLabel.Content = String.Format("{0:0.00}", bossPercentage);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void ChaliceUpPointOne_Click(object sender, RoutedEventArgs e)
        {
            if (chaliceChanceFloat < 100)
            {
                chaliceChanceFloat += .1f;

                if (chaliceChanceFloat > 100)
                {
                    chaliceChanceFloat = 100;
                }

                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
            else
            {
                chaliceChanceFloat = 100;
                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
        }

        private void ChaliceUpOne_Click(object sender, RoutedEventArgs e)
        {
            if (chaliceChanceFloat < 100)
            {
                chaliceChanceFloat += 1f;

                if (chaliceChanceFloat > 100)
                {
                    chaliceChanceFloat = 100;
                }

                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
            else
            {
                chaliceChanceFloat = 100;
                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
        }

        private void ChaliceUpPointOne_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (chaliceChanceFloat >= .1f)
            {
                chaliceChanceFloat -= .1f;

                if (chaliceChanceFloat < 0)
                {
                    chaliceChanceFloat = 0;
                }

                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
            else
            {
                chaliceChanceFloat = 0;
                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
        }

        private void ChaliceUpOne_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (chaliceChanceFloat >= 1)
            {
                chaliceChanceFloat -= 1f;

                if (chaliceChanceFloat < 0)
                {
                    chaliceChanceFloat = 0;
                }

                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
            else
            {
                chaliceChanceFloat = 0;
                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
        }

        private void ChaliceUpTen_Click(object sender, RoutedEventArgs e)
        {
            if (chaliceChanceFloat < 100)
            {
                chaliceChanceFloat += 10f;

                if (chaliceChanceFloat > 100)
                {
                    chaliceChanceFloat = 100;
                }

                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
            else
            {
                chaliceChanceFloat = 100;
                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
        }

        private void ChaliceDownTen_Click(object sender, RoutedEventArgs e)
        {
            if (chaliceChanceFloat >= 10)
            {
                chaliceChanceFloat -= 10f;

                if (chaliceChanceFloat < 0)
                {
                    chaliceChanceFloat = 0;
                }

                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
            else
            {
                chaliceChanceFloat = 0;
                ChalicePercentLabel.Content = String.Format("{0:0.00}", chaliceChanceFloat);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void HCUPO_Click(object sender, RoutedEventArgs e)
        {
            if (HemwickChance < 100)
            {
                HemwickChance += .1f;

                if (HemwickChance > 100)
                {
                    HemwickChance = 100;
                }

                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
            else
            {
                HemwickChance = 100;
                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
        }

        private void HCUO_Click(object sender, RoutedEventArgs e)
        {
            if (HemwickChance < 100)
            {
                HemwickChance += 1f;

                if (HemwickChance > 100)
                {
                    HemwickChance = 100;
                }

                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
            else
            {
                HemwickChance = 100;
                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
        }

        private void HCDPO_Click(object sender, RoutedEventArgs e)
        {
            if (HemwickChance >= .1f)
            {
                HemwickChance -= .1f;

                if (HemwickChance < 0)
                {
                    HemwickChance = 0;
                }

                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
            else
            {
                HemwickChance = 0;
                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
        }

        private void HCDO_Click(object sender, RoutedEventArgs e)
        {
            if (HemwickChance >= 1)
            {
                HemwickChance -= 1f;

                if (HemwickChance < 0)
                {
                    HemwickChance = 0;
                }

                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
            else
            {
                HemwickChance = 0;
                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
        }

        private void HCUT_Click(object sender, RoutedEventArgs e)
        {
            if (HemwickChance < 100)
            {
                HemwickChance += 10f;

                if (HemwickChance > 100)
                {
                    HemwickChance = 100;
                }

                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
            else
            {
                HemwickChance = 100;
                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
        }

        private void HCDT_Click(object sender, RoutedEventArgs e)
        {
            if (HemwickChance >= 10)
            {
                HemwickChance -= 10f;

                if (HemwickChance < 0)
                {
                    HemwickChance = 0;
                }

                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
            else
            {
                HemwickChance = 0;
                HemwickLabel.Content = String.Format("{0:0.00}", HemwickChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void CWUPO_Click(object sender, RoutedEventArgs e)
        {
            if (CathedralWardChance < 100)
            {
                CathedralWardChance += .1f;

                if (CathedralWardChance > 100)
                {
                    CathedralWardChance = 100;
                }

                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
            else
            {
                CathedralWardChance = 100;
                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
        }

        private void CWUO_Click(object sender, RoutedEventArgs e)
        {
            if (CathedralWardChance < 100)
            {
                CathedralWardChance += 1f;

                if (CathedralWardChance > 100)
                {
                    CathedralWardChance = 100;
                }

                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
            else
            {
                CathedralWardChance = 100;
                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
        }

        private void CWDPO_Click(object sender, RoutedEventArgs e)
        {
            if (CathedralWardChance >= .1f)
            {
                CathedralWardChance -= .1f;

                if (CathedralWardChance < 0)
                {
                    CathedralWardChance = 0;
                }

                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
            else
            {
                CathedralWardChance = 0;
                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
        }

        private void CWDO_Click(object sender, RoutedEventArgs e)
        {
            if (CathedralWardChance >= 1)
            {
                CathedralWardChance -= 1f;

                if (CathedralWardChance < 0)
                {
                    CathedralWardChance = 0;
                }

                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
            else
            {
                CathedralWardChance = 0;
                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
        }

        private void CWUT_Click(object sender, RoutedEventArgs e)
        {
            if (CathedralWardChance < 100)
            {
                CathedralWardChance += 10f;

                if (CathedralWardChance > 100)
                {
                    CathedralWardChance = 100;
                }

                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
            else
            {
                CathedralWardChance = 100;
                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
        }

        private void CWDT_Click(object sender, RoutedEventArgs e)
        {
            if (CathedralWardChance >= 10)
            {
                CathedralWardChance -= 10f;

                if (CathedralWardChance < 0)
                {
                    CathedralWardChance = 0;
                }

                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
            else
            {
                CathedralWardChance = 0;
                CathedralWardLabel.Content = String.Format("{0:0.00}", CathedralWardChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void UCUPO_Click(object sender, RoutedEventArgs e)
        {
            if (UpperCathedralWardChance < 100)
            {
                UpperCathedralWardChance += .1f;

                if (UpperCathedralWardChance > 100)
                {
                    UpperCathedralWardChance = 100;
                }

                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
            else
            {
                UpperCathedralWardChance = 100;
                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
        }

        private void UCUO_Click(object sender, RoutedEventArgs e)
        {
            if (UpperCathedralWardChance < 100)
            {
                UpperCathedralWardChance += 1f;

                if (UpperCathedralWardChance > 100)
                {
                    UpperCathedralWardChance = 100;
                }

                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
            else
            {
                UpperCathedralWardChance = 100;
                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
        }

        private void UCDPO_Click(object sender, RoutedEventArgs e)
        {
            if (UpperCathedralWardChance >= .1f)
            {
                UpperCathedralWardChance -= .1f;

                if (UpperCathedralWardChance < 0)
                {
                    UpperCathedralWardChance = 0;
                }

                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
            else
            {
                UpperCathedralWardChance = 0;
                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
        }

        private void UCDO_Click(object sender, RoutedEventArgs e)
        {
            if (UpperCathedralWardChance >= 1)
            {
                UpperCathedralWardChance -= 1f;

                if (UpperCathedralWardChance < 0)
                {
                    UpperCathedralWardChance = 0;
                }

                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
            else
            {
                UpperCathedralWardChance = 0;
                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
        }

        private void UCUT_Click(object sender, RoutedEventArgs e)
        {
            if (UpperCathedralWardChance < 100)
            {
                UpperCathedralWardChance += 10f;

                if (UpperCathedralWardChance > 100)
                {
                    UpperCathedralWardChance = 100;
                }

                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
            else
            {
                UpperCathedralWardChance = 100;
                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
        }

        private void UCDT_Click(object sender, RoutedEventArgs e)
        {
            if (UpperCathedralWardChance >= 10)
            {
                UpperCathedralWardChance -= 10f;

                if (UpperCathedralWardChance < 0)
                {
                    UpperCathedralWardChance = 0;
                }

                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
            else
            {
                UpperCathedralWardChance = 0;
                UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void MUPO_Click(object sender, RoutedEventArgs e)
        {
            if (NightmareOfMensisChance < 100)
            {
                NightmareOfMensisChance += .1f;

                if (NightmareOfMensisChance > 100)
                {
                    NightmareOfMensisChance = 100;
                }

                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
            else
            {
                NightmareOfMensisChance = 100;
                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
        }

        private void MUO_Click(object sender, RoutedEventArgs e)
        {
            if (NightmareOfMensisChance < 100)
            {
                NightmareOfMensisChance += 1f;

                if (NightmareOfMensisChance > 100)
                {
                    NightmareOfMensisChance = 100;
                }

                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
            else
            {
                NightmareOfMensisChance = 100;
                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
        }

        private void MDPO_Click(object sender, RoutedEventArgs e)
        {
            if (NightmareOfMensisChance >= .1f)
            {
                NightmareOfMensisChance -= .1f;

                if (NightmareOfMensisChance < 0)
                {
                    NightmareOfMensisChance = 0;
                }

                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
            else
            {
                NightmareOfMensisChance = 0;
                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
        }

        private void MDO_Click(object sender, RoutedEventArgs e)
        {
            if (NightmareOfMensisChance >= 1)
            {
                NightmareOfMensisChance -= 1f;

                if (NightmareOfMensisChance < 0)
                {
                    NightmareOfMensisChance = 0;
                }

                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
            else
            {
                NightmareOfMensisChance = 0;
                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
        }

        private void MUT_Click(object sender, RoutedEventArgs e)
        {
            if (NightmareOfMensisChance < 100)
            {
                NightmareOfMensisChance += 10f;

                if (NightmareOfMensisChance > 100)
                {
                    NightmareOfMensisChance = 100;
                }

                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
            else
            {
                NightmareOfMensisChance = 100;
                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
        }

        private void MDT_Click(object sender, RoutedEventArgs e)
        {
            if (NightmareOfMensisChance >= 10)
            {
                NightmareOfMensisChance -= 10f;

                if (NightmareOfMensisChance < 0)
                {
                    NightmareOfMensisChance = 0;
                }

                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
            else
            {
                NightmareOfMensisChance = 0;
                MensisLabel.Content = String.Format("{0:0.00}", NightmareOfMensisChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void YUPO_Click(object sender, RoutedEventArgs e)
        {
            if (YahargulChance < 100)
            {
                YahargulChance += .1f;

                if (YahargulChance > 100)
                {
                    YahargulChance = 100;
                }

                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
            else
            {
                YahargulChance = 100;
                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
        }

        private void YUO_Click(object sender, RoutedEventArgs e)
        {
            if (YahargulChance < 100)
            {
                YahargulChance += 1f;

                if (YahargulChance > 100)
                {
                    YahargulChance = 100;
                }

                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
            else
            {
                YahargulChance = 100;
                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
        }

        private void YDPO_Click(object sender, RoutedEventArgs e)
        {
            if (YahargulChance >= .1f)
            {
                YahargulChance -= .1f;

                if (YahargulChance < 0)
                {
                    YahargulChance = 0;
                }

                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
            else
            {
                YahargulChance = 0;
                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
        }

        private void YDO_Click(object sender, RoutedEventArgs e)
        {
            if (YahargulChance >= 1)
            {
                YahargulChance -= 1f;

                if (YahargulChance < 0)
                {
                    YahargulChance = 0;
                }

                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
            else
            {
                YahargulChance = 0;
                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
        }

        private void YUT_Click(object sender, RoutedEventArgs e)
        {
            if (YahargulChance < 100)
            {
                YahargulChance += 10f;

                if (YahargulChance > 100)
                {
                    YahargulChance = 100;
                }

                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
            else
            {
                YahargulChance = 100;
                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
        }

        private void YDT_Click(object sender, RoutedEventArgs e)
        {
            if (YahargulChance >= 10)
            {
                YahargulChance -= 10f;

                if (YahargulChance < 0)
                {
                    YahargulChance = 0;
                }

                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
            else
            {
                YahargulChance = 0;
                YahargulLabel.Content = String.Format("{0:0.00}", YahargulChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void FUPO_Click(object sender, RoutedEventArgs e)
        {
            if (FrontierChance < 100)
            {
                FrontierChance += .1f;

                if (FrontierChance > 100)
                {
                    FrontierChance = 100;
                }

                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
            else
            {
                FrontierChance = 100;
                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void FUO_Click(object sender, RoutedEventArgs e)
        {
            if (FrontierChance < 100)
            {
                FrontierChance += 1f;

                if (FrontierChance > 100)
                {
                    FrontierChance = 100;
                }

                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
            else
            {
                FrontierChance = 100;
                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void FDPO_Click(object sender, RoutedEventArgs e)
        {
            if (FrontierChance >= .1f)
            {
                FrontierChance -= .1f;

                if (FrontierChance < 0)
                {
                    FrontierChance = 0;
                }

                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
            else
            {
                FrontierChance = 0;
                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void FDO_Click(object sender, RoutedEventArgs e)
        {
            if (FrontierChance >= 1)
            {
                FrontierChance -= 1f;

                if (FrontierChance < 0)
                {
                    FrontierChance = 0;
                }

                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
            else
            {
                FrontierChance = 0;
                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void FUT_Click(object sender, RoutedEventArgs e)
        {
            if (FrontierChance < 100)
            {
                FrontierChance += 10f;

                if (FrontierChance > 100)
                {
                    FrontierChance = 100;
                }

                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
            else
            {
                FrontierChance = 100;
                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void FDT_Click(object sender, RoutedEventArgs e)
        {
            if (FrontierChance >= 10)
            {
                FrontierChance -= 10f;

                if (FrontierChance < 0)
                {
                    FrontierChance = 0;
                }

                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
            else
            {
                FrontierChance = 0;
                FrontierLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void RUPO_Click(object sender, RoutedEventArgs e)
        {
            if (ResearchHallChance < 100)
            {
                ResearchHallChance += .1f;

                if (ResearchHallChance > 100)
                {
                    ResearchHallChance = 100;
                }

                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
            else
            {
                ResearchHallChance = 100;
                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
        }

        private void RUO_Click(object sender, RoutedEventArgs e)
        {
            if (ResearchHallChance < 100)
            {
                ResearchHallChance += 1f;

                if (ResearchHallChance > 100)
                {
                    ResearchHallChance = 100;
                }

                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
            else
            {
                ResearchHallChance = 100;
                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
        }

        private void RDPO_Click(object sender, RoutedEventArgs e)
        {
            if (ResearchHallChance >= .1f)
            {
                ResearchHallChance -= .1f;

                if (ResearchHallChance < 0)
                {
                    ResearchHallChance = 0;
                }

                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
            else
            {
                ResearchHallChance = 0;
                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
        }

        private void RDO_Click(object sender, RoutedEventArgs e)
        {
            if (ResearchHallChance >= 1)
            {
                ResearchHallChance -= 1f;

                if (ResearchHallChance < 0)
                {
                    ResearchHallChance = 0;
                }

                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
            else
            {
                ResearchHallChance = 0;
                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
        }

        private void RUT_Click(object sender, RoutedEventArgs e)
        {
            if (ResearchHallChance < 100)
            {
                ResearchHallChance += 10f;

                if (ResearchHallChance > 100)
                {
                    ResearchHallChance = 100;
                }

                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
            else
            {
                ResearchHallChance = 100;
                ResearchLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void RDT_Click(object sender, RoutedEventArgs e)
        {
            if (ResearchHallChance >= 10)
            {
                ResearchHallChance -= 10f;

                if (ResearchHallChance < 0)
                {
                    ResearchHallChance = 0;
                }

                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
            else
            {
                ResearchHallChance = 0;
                ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void OYUPO_Click(object sender, RoutedEventArgs e)
        {
            if (OldYharnamChance < 100)
            {
                OldYharnamChance += .1f;

                if (OldYharnamChance > 100)
                {
                    OldYharnamChance = 100;
                }

                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
            else
            {
                OldYharnamChance = 100;
                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
        }

        private void OYUO_Click(object sender, RoutedEventArgs e)
        {
            if (OldYharnamChance < 100)
            {
                OldYharnamChance += 1f;

                if (OldYharnamChance > 100)
                {
                    OldYharnamChance = 100;
                }

                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
            else
            {
                OldYharnamChance = 100;
                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
        }

        private void OYDPO_Click(object sender, RoutedEventArgs e)
        {
            if (OldYharnamChance >= .1f)
            {
                OldYharnamChance -= .1f;

                if (OldYharnamChance < 0)
                {
                    OldYharnamChance = 0;
                }

                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
            else
            {
                OldYharnamChance = 0;
                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
        }

        private void OYDO_Click(object sender, RoutedEventArgs e)
        {
            if (OldYharnamChance >= 1)
            {
                OldYharnamChance -= 1f;

                if (OldYharnamChance < 0)
                {
                    OldYharnamChance = 0;
                }

                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
            else
            {
                OldYharnamChance = 0;
                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
        }

        private void OYUT_Click(object sender, RoutedEventArgs e)
        {
            if (OldYharnamChance < 100)
            {
                OldYharnamChance += 10f;

                if (OldYharnamChance > 100)
                {
                    OldYharnamChance = 100;
                }

                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
            else
            {
                OldYharnamChance = 100;
                OldYharnamLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void OYDT_Click(object sender, RoutedEventArgs e)
        {
            if (OldYharnamChance >= 10)
            {
                OldYharnamChance -= 10f;

                if (OldYharnamChance < 0)
                {
                    OldYharnamChance = 0;
                }

                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
            else
            {
                OldYharnamChance = 0;
                OldYharnamLabel.Content = String.Format("{0:0.00}", OldYharnamChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void CYUPO_Click(object sender, RoutedEventArgs e)
        {
            if (CentralYharnamChance < 100)
            {
                CentralYharnamChance += .1f;

                if (CentralYharnamChance > 100)
                {
                    CentralYharnamChance = 100;
                }

                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
            else
            {
                CentralYharnamChance = 100;
                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
        }

        private void CYUO_Click(object sender, RoutedEventArgs e)
        {
            if (CentralYharnamChance < 100)
            {
                CentralYharnamChance += 1f;

                if (CentralYharnamChance > 100)
                {
                    CentralYharnamChance = 100;
                }

                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
            else
            {
                CentralYharnamChance = 100;
                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
        }

        private void CYDPO_Click(object sender, RoutedEventArgs e)
        {
            if (CentralYharnamChance >= .1f)
            {
                CentralYharnamChance -= .1f;

                if (CentralYharnamChance < 0)
                {
                    CentralYharnamChance = 0;
                }

                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
            else
            {
                CentralYharnamChance = 0;
                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
        }

        private void CYDO_Click(object sender, RoutedEventArgs e)
        {
            if (CentralYharnamChance >= 1)
            {
                CentralYharnamChance -= 1f;

                if (CentralYharnamChance < 0)
                {
                    CentralYharnamChance = 0;
                }

                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
            else
            {
                CentralYharnamChance = 0;
                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
        }

        private void CYUT_Click(object sender, RoutedEventArgs e)
        {
            if (CentralYharnamChance < 100)
            {
                CentralYharnamChance += 10f;

                if (CentralYharnamChance > 100)
                {
                    CentralYharnamChance = 100;
                }

                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
            else
            {
                CentralYharnamChance = 100;
                CentralYharnamLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void CYDT_Click(object sender, RoutedEventArgs e)
        {
            if (CentralYharnamChance >= 10)
            {
                CentralYharnamChance -= 10f;

                if (CentralYharnamChance < 0)
                {
                    CentralYharnamChance = 0;
                }

                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
            else
            {
                CentralYharnamChance = 0;
                CentralYharnamLabel.Content = String.Format("{0:0.00}", CentralYharnamChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void CUPO_Click(object sender, RoutedEventArgs e)
        {
            if (CainhurstChance < 100)
            {
                CainhurstChance += .1f;

                if (CainhurstChance > 100)
                {
                    CainhurstChance = 100;
                }

                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
            else
            {
                CainhurstChance = 100;
                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
        }

        private void CUO_Click(object sender, RoutedEventArgs e)
        {
            if (CainhurstChance < 100)
            {
                CainhurstChance += 1f;

                if (CainhurstChance > 100)
                {
                    CainhurstChance = 100;
                }

                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
            else
            {
                CainhurstChance = 100;
                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
        }

        private void CDPO_Click(object sender, RoutedEventArgs e)
        {
            if (CainhurstChance >= .1f)
            {
                CainhurstChance -= .1f;

                if (CainhurstChance < 0)
                {
                    CainhurstChance = 0;
                }

                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
            else
            {
                CainhurstChance = 0;
                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
        }

        private void CDO_Click(object sender, RoutedEventArgs e)
        {
            if (CainhurstChance >= 1)
            {
                CainhurstChance -= 1f;

                if (CainhurstChance < 0)
                {
                    CainhurstChance = 0;
                }

                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
            else
            {
                CainhurstChance = 0;
                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
        }

        private void CUT_Click(object sender, RoutedEventArgs e)
        {
            if (CainhurstChance < 100)
            {
                CainhurstChance += 10f;

                if (CainhurstChance > 100)
                {
                    CainhurstChance = 100;
                }

                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
            else
            {
                CainhurstChance = 100;
                CainhurstLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void CDT_Click(object sender, RoutedEventArgs e)
        {
            if (CainhurstChance >= 10)
            {
                CainhurstChance -= 10f;

                if (CainhurstChance < 0)
                {
                    CainhurstChance = 0;
                }

                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
            else
            {
                CainhurstChance = 0;
                CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void WUPO_Click(object sender, RoutedEventArgs e)
        {
            if (WoodsChance < 100)
            {
                WoodsChance += .1f;

                if (WoodsChance > 100)
                {
                    WoodsChance = 100;
                }

                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
            else
            {
                WoodsChance = 100;
                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
        }

        private void WUO_Click(object sender, RoutedEventArgs e)
        {
            if (WoodsChance < 100)
            {
                WoodsChance += 1f;

                if (WoodsChance > 100)
                {
                    WoodsChance = 100;
                }

                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
            else
            {
                WoodsChance = 100;
                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
        }

        private void WDPO_Click(object sender, RoutedEventArgs e)
        {
            if (WoodsChance >= .1f)
            {
                WoodsChance -= .1f;

                if (WoodsChance < 0)
                {
                    WoodsChance = 0;
                }

                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
            else
            {
                WoodsChance = 0;
                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
        }

        private void WDO_Click(object sender, RoutedEventArgs e)
        {
            if (WoodsChance >= 1)
            {
                WoodsChance -= 1f;

                if (WoodsChance < 0)
                {
                    WoodsChance = 0;
                }

                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
            else
            {
                WoodsChance = 0;
                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
        }

        private void WUT_Click(object sender, RoutedEventArgs e)
        {
            if (WoodsChance < 100)
            {
                WoodsChance += 10f;

                if (WoodsChance > 100)
                {
                    WoodsChance = 100;
                }

                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
            else
            {
                WoodsChance = 100;
                WoodsLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void WDT_Click(object sender, RoutedEventArgs e)
        {
            if (WoodsChance >= 10)
            {
                WoodsChance -= 10f;

                if (WoodsChance < 0)
                {
                    WoodsChance = 0;
                }

                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
            else
            {
                WoodsChance = 0;
                WoodsLabel.Content = String.Format("{0:0.00}", WoodsChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void BUPO_Click(object sender, RoutedEventArgs e)
        {
            if (ByrgenwerthChance < 100)
            {
                ByrgenwerthChance += .1f;

                if (ByrgenwerthChance > 100)
                {
                    ByrgenwerthChance = 100;
                }

                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
            else
            {
                ByrgenwerthChance = 100;
                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
        }

        private void BUO_Click(object sender, RoutedEventArgs e)
        {
            if (ByrgenwerthChance < 100)
            {
                ByrgenwerthChance += 1f;

                if (ByrgenwerthChance > 100)
                {
                    ByrgenwerthChance = 100;
                }

                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
            else
            {
                ByrgenwerthChance = 100;
                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
        }

        private void BDPO_Click(object sender, RoutedEventArgs e)
        {
            if (ByrgenwerthChance >= .1f)
            {
                ByrgenwerthChance -= .1f;

                if (ByrgenwerthChance < 0)
                {
                    ByrgenwerthChance = 0;
                }

                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
            else
            {
                ByrgenwerthChance = 0;
                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
        }

        private void BDO_Click(object sender, RoutedEventArgs e)
        {
            if (ByrgenwerthChance >= 1)
            {
                ByrgenwerthChance -= 1f;

                if (ByrgenwerthChance < 0)
                {
                    ByrgenwerthChance = 0;
                }

                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
            else
            {
                ByrgenwerthChance = 0;
                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
        }

        private void BUT_Click(object sender, RoutedEventArgs e)
        {
            if (ByrgenwerthChance < 100)
            {
                ByrgenwerthChance += 10f;

                if (ByrgenwerthChance > 100)
                {
                    ByrgenwerthChance = 100;
                }

                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
            else
            {
                ByrgenwerthChance = 100;
                ByrgenwerthLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void BDT_Click(object sender, RoutedEventArgs e)
        {
            if (ByrgenwerthChance >= 10)
            {
                ByrgenwerthChance -= 10f;

                if (ByrgenwerthChance < 0)
                {
                    ByrgenwerthChance = 0;
                }

                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
            else
            {
                ByrgenwerthChance = 0;
                ByrgenwerthLabel.Content = String.Format("{0:0.00}", ByrgenwerthChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void HUPO_Click(object sender, RoutedEventArgs e)
        {
            if (HuntersNightmareChance < 100)
            {
                HuntersNightmareChance += .1f;

                if (HuntersNightmareChance > 100)
                {
                    HuntersNightmareChance = 100;
                }

                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
            else
            {
                HuntersNightmareChance = 100;
                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
        }

        private void HUO_Click(object sender, RoutedEventArgs e)
        {
            if (HuntersNightmareChance < 100)
            {
                HuntersNightmareChance += 1f;

                if (HuntersNightmareChance > 100)
                {
                    HuntersNightmareChance = 100;
                }

                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
            else
            {
                HuntersNightmareChance = 100;
                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
        }

        private void HDPO_Click(object sender, RoutedEventArgs e)
        {
            if (HuntersNightmareChance >= .1f)
            {
                HuntersNightmareChance -= .1f;

                if (HuntersNightmareChance < 0)
                {
                    HuntersNightmareChance = 0;
                }

                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
            else
            {
                HuntersNightmareChance = 0;
                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
        }

        private void HDO_Click(object sender, RoutedEventArgs e)
        {
            if (HuntersNightmareChance >= 1)
            {
                HuntersNightmareChance -= 1f;

                if (HuntersNightmareChance < 0)
                {
                    HuntersNightmareChance = 0;
                }

                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
            else
            {
                HuntersNightmareChance = 0;
                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
        }

        private void HUT_Click(object sender, RoutedEventArgs e)
        {
            if (HuntersNightmareChance < 100)
            {
                HuntersNightmareChance += 10f;

                if (HuntersNightmareChance > 100)
                {
                    HuntersNightmareChance = 100;
                }

                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
            else
            {
                HuntersNightmareChance = 100;
                HuntersNightmareLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void HDT_Click(object sender, RoutedEventArgs e)
        {
            if (HuntersNightmareChance >= 10)
            {
                HuntersNightmareChance -= 10f;

                if (HuntersNightmareChance < 0)
                {
                    HuntersNightmareChance = 0;
                }

                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
            else
            {
                HuntersNightmareChance = 0;
                HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        private void FHUPO_Click(object sender, RoutedEventArgs e)
        {
            if (HamletChance < 100)
            {
                HamletChance += .1f;

                if (HamletChance > 100)
                {
                    HamletChance = 100;
                }

                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
            else
            {
                HamletChance = 100;
                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
        }

        private void FHUO_Click(object sender, RoutedEventArgs e)
        {
            if (HamletChance < 100)
            {
                HamletChance += 1f;

                if (HamletChance > 100)
                {
                    HamletChance = 100;
                }

                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
            else
            {
                HamletChance = 100;
                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
        }

        private void FHDPO_Click(object sender, RoutedEventArgs e)
        {
            if (HamletChance >= .1f)
            {
                HamletChance -= .1f;

                if (HamletChance < 0)
                {
                    HamletChance = 0;
                }

                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
            else
            {
                HamletChance = 0;
                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
        }

        private void FHDO_Click(object sender, RoutedEventArgs e)
        {
            if (HamletChance >= 1)
            {
                HamletChance -= 1f;

                if (HamletChance < 0)
                {
                    HamletChance = 0;
                }

                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
            else
            {
                HamletChance = 0;
                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
        }

        private void FHUT_Click(object sender, RoutedEventArgs e)
        {
            if (HamletChance < 100)
            {
                HamletChance += 10f;

                if (HamletChance > 100)
                {
                    HamletChance = 100;
                }

                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
            else
            {
                HamletChance = 100;
                FishingHamletLabel.Content = String.Format("{0:0.00}", FrontierChance);
            }
        }

        private void FHDT_Click(object sender, RoutedEventArgs e)
        {
            if (HamletChance >= 10)
            {
                HamletChance -= 10f;

                if (HamletChance < 0)
                {
                    HamletChance = 0;
                }

                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
            else
            {
                HamletChance = 0;
                FishingHamletLabel.Content = String.Format("{0:0.00}", HamletChance);
            }
        }

        private void KeepGunsBox_Checked(object sender, RoutedEventArgs e)
        {
            keepGuns = KeepGunsBox.IsChecked.Value;
        }

        private void DummyEnemyBox_Checked(object sender, RoutedEventArgs e)
        {
            dummyEnemyBool = DummyEnemyBox.IsChecked.Value;
        }

        private void HemwickCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bossHemwick = HemwickCheckBox.IsChecked.Value;
        }

        private void CathedralWardBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossCathedralWard = CathedralWardBossBox.IsChecked.Value;
        }

        private void UpperCathedralBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossUpperCathedralWard = UpperCathedralBossBox.IsChecked.Value;
        }

        private void MensisBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossMensis = MensisBossBox.IsChecked.Value;
        }

        private void FrontierBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossFrontier = FrontierBossBox.IsChecked.Value;
        }

        private void YahargulBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossYahargul = YahargulBossBox.IsChecked.Value;
        }

        private void ResearchHallBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossResearchHall = ResearchHallBossBox.IsChecked.Value;
        }

        private void OldYharnamBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossOldYharnam = OldYharnamBossBox.IsChecked.Value;
        }

        private void CentralYharnamBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossCentralYharnam = CentralYharnamBossBox.IsChecked.Value;
        }

        private void CainhurstBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossCainhurst = CainhurstBossBox.IsChecked.Value;
        }

        private void ByrgenwerthBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossByrgenwerthLecture = ByrgenwerthBossBox.IsChecked.Value;
        }

        private void WoodsBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossForbiddenWoods = WoodsBossBox.IsChecked.Value;
        }

        private void NightmareBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossNightmare = NightmareBossBox.IsChecked.Value;
        }

        private void HamletBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossHamlet = HamletBossBox.IsChecked.Value;
        }

        private void ChaliceBossBox_Checked(object sender, RoutedEventArgs e)
        {
            bossChalices = ChaliceBossBox.IsChecked.Value;
        }

        /////////////////////////////////////////////////////////////////////////////////////

    }
}
