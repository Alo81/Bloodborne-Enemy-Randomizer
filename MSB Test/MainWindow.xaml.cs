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
        int totalTime;
        int totalPercent;
        string paramPath;
        string paramDefPath;
        string currentTask;
        List<long> longList2 = new List<long>();
        List<string> logList2 = new List<string>();
        List<string> unusedList = new List<string>();
        List<string> bossList = new List<string>();
        int numberOfKeyIemsRandomized;
        List<string> unusedPlusBossList = new List<string>();
        List<string> addedBosses = new List<string>();
        List<int> keyItemLots = new List<int>();
        List<int> nonoItemLots = new List<int>();
        List<int> combinedItemLotList = new List<int>();
        List<MSBB.Part.Enemy> addedEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> addedBossesList = new List<MSBB.Part.Enemy>();
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
        bool bossMusicBool;
        bool includeBosses;
        bool randomizeEnemiesBool;
        bool randomize = true;
        bool oopsAllBosses;
        bool randomizeItemLots;
        bool lesserBossesBool;
        bool bellMaidenBool;
        bool keyItemRandomizeBool;
        bool workshopBool;
        string thisnpc;
        string thismo;
        string thisthink;
        string thisentityID;
        bool insertBossesBool;
        double bossPercentage;
        double chaliceChanceFloat;
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
        int ludwigCount = 0;
        string scaleLogFile;
        List<string> eventFileList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            RandomizeKeyItemsBox.IsEnabled = false;

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
            chaliceBossParams.Add("210306016");
            chaliceBossParams.Add("10218090");
            chaliceBossParams.Add("110504000");
            chaliceBossParams.Add("210508006");
            chaliceBossParams.Add("310504000");
            chaliceBossParams.Add("110257000");
            chaliceBossParams.Add("210251096");
            chaliceBossParams.Add("310305016");
            chaliceBossParams.Add("210306015");

            unusedList.Add("c2120_9999");
            unusedList.Add("c2120_9998");
            unusedList.Add("c0000");
            unusedList.Add("c0");
            unusedList.Add("c1020");
            unusedList.Add("c1030");
            unusedList.Add("c1040");
            unusedList.Add("c1070");
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
            unusedList.Add("c1130_0000");
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
            unusedList.Add("c3060_0000");
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
                            int tempInt = npcParamPositions[i] + 11;
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
                            int tempInt = npcParamPositions[i] + 11;
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
                TEST.IsEnabled = false;
                RandomizeEnemiesCheck.IsEnabled = false;
                BossCheckBox.IsEnabled = false;
                InsertBosses.IsEnabled = false;
                ChaliceBoss.IsEnabled = false;
                ChaliceEnemies.IsEnabled = false;
                ArmorRandomizerCheckBox.IsEnabled = false;
                AddNPCS.IsEnabled = false;
                bossSlider.IsEnabled = false;
                ChaliceSliderThing.IsEnabled = false;
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
            });

            if(bellMaidenBool)
            {
                unusedList.Add("c1050");
                unusedList.Add("c1051");
                unusedList.Add("c1055");
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
                    writetext.WriteLine("MAX SIZE " + mapList[i] + " " + maxSizeLong + " " + tempMapRead.Parts.Enemies.Count);
                }
            }

            paramPath = filePath + "\\param\\gameparam\\gameparam.parambnd.dcx";
            paramDefPath = filePath + "\\paramdef\\paramdef.paramdefbnd.dcx";

            if (File.Exists(paramPath + ".bak"))
            {
                File.Delete(paramPath);
                File.Copy(paramPath + ".bak", paramPath);
            }

            File.Delete(paramPath + ".bak");
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
                }

                if (includeBosses)
                {
                    for (int i = 0; i < enemyData.Count; i++)
                    {
                        secondaryBosses.Add(enemyData[i]);
                        tertiaryBosses.Add(enemyData[1]);
                    }

                    while (secondaryBosses.Count > 0)
                    {
                        int index = rand.Next(0, secondaryBosses.Count);
                        enemyDataRandomized.Add(secondaryBosses[index]);
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

            if (includeBosses)
            {
                this.Dispatcher.Invoke(() =>
                {
                    totalPercent = 45;
                    currentTask = "Randomizing Bosses...";
                    UpdateUI();
                });

                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", nonoList);
                //RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", nonoList);
                RandomizeBosses(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
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

                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m21_01_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m22_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m23_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_01_00_11.msb.dcx", unusedPlusBossList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", unusedPlusBossList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", unusedPlusBossList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", unusedPlusBossList);
                if (chaliceBosses)
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


                for (int i = 0; i < npcEnemyList.Count; i++)
                {
                    string tempString = npcEnemyList[i].NPCParamID.ToString() + "*" + npcEnemyList[i].ThinkParamID.ToString() + "*" + npcEnemyList[i].UnkT07.ToString();
                    npcList.Add(npcEnemyList[i].NPCParamID.ToString() + "*" + npcEnemyList[i].ThinkParamID.ToString() + "*" + npcEnemyList[i].UnkT07.ToString());
                }

                for(int i = 0; i < npcList.Count; i ++)
                {
                    if(npcList[i].Contains("6070") || npcList[i].Contains("6300") || npcList[i].Contains("6301") ||
                        npcList[i].Contains("6310") || npcList[i].Contains("6340") || npcList[i].Contains("6350") ||
                        npcList[i].Contains("6360"))
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
                    totalPercent = 95;
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

                //maxSizeList.Add(maxSizeLong);

                using (StreamWriter writetext = File.AppendText(sizeFilePath))
                {
                    writetext.WriteLine("MAX SIZE " + mapList[i] + " " + maxSizeLong + " " + tempMapRead.Parts.Enemies.Count);
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
                bossSlider.IsEnabled = true;
                ChaliceSliderThing.IsEnabled = true;
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

            Random rand = new Random();

            List<string> vialAndBulletIDsList = new List<string>();
            vialAndBulletIDsList.Add("100000");
            vialAndBulletIDsList.Add("110000");
            vialAndBulletIDsList.Add("120000");
            vialAndBulletIDsList.Add("130000");
            vialAndBulletIDsList.Add("140000");
            vialAndBulletIDsList.Add("510000");
            vialAndBulletIDsList.Add("520000");
            vialAndBulletIDsList.Add("530000");
            vialAndBulletIDsList.Add("540000");
            vialAndBulletIDsList.Add("610000");
            vialAndBulletIDsList.Add("620000");
            vialAndBulletIDsList.Add("630000");
            vialAndBulletIDsList.Add("640000");
            vialAndBulletIDsList.Add("100001");
            vialAndBulletIDsList.Add("110001");
            vialAndBulletIDsList.Add("120001");
            vialAndBulletIDsList.Add("130001");
            vialAndBulletIDsList.Add("140001");
            vialAndBulletIDsList.Add("240");

            List<string> shopWeaponList = new List<string>();
            List<string> shopConsumableList = new List<string>();
            List<string> shopArmorList = new List<string>();

            for(int i = 0; i < shopLineupParams.Rows.Count; i ++)
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
                    Random rand = new Random();
                    int random = rand.Next(0, npcList.Count);
                    string thisEnemy;

                    thisEnemy = npcList[random];

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
                        float assass = ass.Next(0,100);
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
                            else if(ludwigCount >= 2 && tempGUY.Parts.Enemies[i].Name.Contains("c4510"))
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
                                else if(!currentMap.Contains("m26") && tempGUY.Parts.Enemies[i].Name.Contains("c0000_0005"))
                                {
                                    changeData = false;
                                    List<long> tempLong = new List<long>();
                                    tempLong.Add(tempGUY.Parts.Enemies[i].NPCParamID);
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
                                    changeData = true;
                                }
                            }
                        }

                        if(enemyDataRandomized.Count <= 1)
                        {
                            for (int k = 0; k < tertiaryBosses.Count; k++)
                            {
                                enemyDataRandomized.Add(tertiaryBosses[k]);
                            }
                        }

                        if (changeData && enemyDataRandomized.Count > 0)
                        {
                            oldNPCParam.Add(tempGUY.Parts.Enemies[i].NPCParamID);

                            Random rand = new Random();
                            int random = rand.Next(0, enemyDataRandomized.Count);
                            int randomChalice = rand.Next(0, chaliceBossString.Count);
                            string thisEnemy;
                            if (currentMap.Contains("m29"))
                            {
                                thisEnemy = chaliceBossString[randomChalice];

                            }
                            else
                            {
                                thisEnemy = enemyDataRandomized[random];
                            }
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
                                while(modelName.Contains("4500") || modelName.Contains("4520"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                }
                            }

                            if (currentMap.Contains("m24_02"))
                            {
                                while (modelName.Contains("5100") || modelName.Contains("8050") || modelName.Contains("4520"))
                                {
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
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
                                    random = rand.Next(0, enemyDataRandomized.Count);
                                    thisEnemy = enemyDataRandomized[random];
                                    removalNumber = random;

                                    tempnpcint = thisEnemy.IndexOf("*");
                                    tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                    tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                    modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                    tempNpcParamInt = int.Parse(tempNpcParam);
                                    tempThinkIdInt = int.Parse(tempThinkId);

                                    addCounter++;
                                    if (addCounter >= enemyDataRandomized.Count)
                                    {
                                        //enemyDataRandomized.Add(secondaryBosses[random]);
                                        addCounter = 0;
                                    }
                                }

                                if (addedBosses != null && addedBosses.Count >= 2)
                                {
                                    int counter = 0;
                                    for (int l = 0; l < addedBosses.Count; l++)
                                    {
                                        if (tempNpcParamInt.ToString().Contains(addedBosses[l]))
                                        {
                                            counter++;
                                            if (counter >= 2)
                                            {
                                                random = rand.Next(0, enemyDataRandomized.Count);
                                                thisEnemy = enemyDataRandomized[random];
                                                removalNumber = random;

                                                tempnpcint = thisEnemy.IndexOf("*");
                                                tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                                tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                                modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                                tempNpcParamInt = int.Parse(tempNpcParam);
                                                tempThinkIdInt = int.Parse(tempThinkId);
                                            }
                                        }
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
                                //celestial emissary fix
                                if (tempGUY.Parts.Enemies[i].Name == "c2570_0001")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

                                            tempnpcint = thisEnemy.IndexOf("*");
                                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                            tempNpcParamInt = int.Parse(tempNpcParam);
                                            tempThinkIdInt = int.Parse(tempThinkId);
                                        }

                                        npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                        think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                        mo = tempGUY.Parts.Enemies[i].ModelName;
                                        entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            //enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
                                        }
                                    }
                                }
                                else if (tempGUY.Parts.Enemies[i].Name == "c2500_0000")
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
                                //enemyDataRandomized.RemoveAt(0);
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
                                //ludwig fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4510_0002")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

                                            tempnpcint = thisEnemy.IndexOf("*");
                                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                            tempNpcParamInt = int.Parse(tempNpcParam);
                                            tempThinkIdInt = int.Parse(tempThinkId);
                                        }

                                        npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                        think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                        mo = tempGUY.Parts.Enemies[i].ModelName;
                                        entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            //enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
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
                                //Orphan fix
                                if (tempGUY.Parts.Enemies[i].Name == "c4541_0000")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

                                            tempnpcint = thisEnemy.IndexOf("*");
                                            tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                            tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                            modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);
                                            tempNpcParamInt = int.Parse(tempNpcParam);
                                            tempThinkIdInt = int.Parse(tempThinkId);
                                        }

                                        npc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                                        think = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                                        mo = tempGUY.Parts.Enemies[i].ModelName;
                                        entityID = tempGUY.Parts.Enemies[i].EntityID.ToString();

                                        tempGUY.Parts.Enemies[i].NPCParamID = tempNpcParamInt;
                                        tempGUY.Parts.Enemies[i].ThinkParamID = tempThinkIdInt;
                                        tempGUY.Parts.Enemies[i].ModelName = modelName;

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            //enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
                                        }
                                    }
                                }
                                //gascoigne fix
                                if (tempGUY.Parts.Enemies[i].Name == "c2720_0000")
                                {
                                    while (modelName.Contains("c5100") || modelName.Contains("c5000"))
                                    {
                                        random = rand.Next(0, enemyDataRandomized.Count);
                                        thisEnemy = enemyDataRandomized[random];
                                        removalNumber = random;

                                        Console.WriteLine(enemyDataRandomized[0]);

                                        tempnpcint = thisEnemy.IndexOf("*");
                                        tempNpcParam = thisEnemy.Substring(0, tempnpcint);
                                        tempThinkId = thisEnemy.Substring(tempnpcint + 1, thisEnemy.LastIndexOf("*") - tempnpcint - 1);
                                        modelName = thisEnemy.Substring(thisEnemy.LastIndexOf("*") + 1, 5);

                                        tempNpcParamInt = int.Parse(tempNpcParam);
                                        tempThinkIdInt = int.Parse(tempThinkId);

                                        if (tempGUY.Parts.Enemies[i].Name.Contains(modelName))
                                        {
                                            random = rand.Next(0, enemyDataRandomized.Count);
                                            thisEnemy = enemyDataRandomized[random];
                                            removalNumber = random;

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

                                        addCounter++;
                                        if (addCounter >= enemyDataRandomized.Count)
                                        {
                                            //enemyDataRandomized.Add(secondaryBosses[random]);
                                            addCounter = 0;
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

                                    enemyDataRandomized.RemoveAt(removalNumber);
                                    writetext.WriteLine("Enemy Pool Count: " + enemyDataRandomized.Count + Environment.NewLine + Environment.NewLine);
                                }
                            }
                            if (currentMap.Contains("m29"))
                            {
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

                                    writetext.WriteLine("Enemy Pool Count: " + enemyDataRandomized.Count + Environment.NewLine + Environment.NewLine);
                                }
                            }

                            bossCount++;
                            newNPCParam.Add(paramNumber);
                            mapsForParamChanges.Add(currentMap);
                            paramNumber--;

                        }

                    }
                }
                else if(oopsAllBosses)
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
                bool ucw = true;
                bool rh = true;
                bool ch = true;
                bool cp = true;

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
                                ucw = false;
                                rh = false;
                                ch = false;
                                cp = false;
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

                        if (currentMap.Contains("24_02"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 11);
                            if (randChoose >= 6)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (ucw)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("25"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 11);
                            if (randChoose >= 6)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (ch)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("34"))
                        {
                            Random chooseRand = new Random();
                            int randChoose = chooseRand.Next(0, 11);
                            if (randChoose >= 9)
                            {
                                changeData = false;
                            }
                            else
                            {
                                if (cp)
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("35"))
                        {
                                Random chooseRand = new Random();
                                int randChoose = chooseRand.Next(0, 11);
                                if (randChoose >= 3)
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    if (rh)
                                    {
                                        changeData = true;
                                    }
                                }
                        }

                        if (changeData && enemyDataRandomized.Count > 0)
                        {
                            Random rand = new Random();
                            float chaliceRandom = rand.Next(0, 100);
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
        }

        private void InsertBosses_Checked(object sender, RoutedEventArgs e)
        {
            insertBossesBool = InsertBosses.IsChecked.Value;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bossPercentage = bossSlider.Value * 10;
            sliderValue.Content = (bossPercentage).ToString("0.0");

        }

        private void ChaliceBoss_Checked(object sender, RoutedEventArgs e)
        {
            chaliceBosses = ChaliceBoss.IsChecked.Value;
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

        private void ChaliceSliderThing_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            chaliceChanceFloat = ChaliceSliderThing.Value * 10;
            ChaliceSliderValue.Content = (chaliceChanceFloat).ToString("0.0");
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
    }
}
