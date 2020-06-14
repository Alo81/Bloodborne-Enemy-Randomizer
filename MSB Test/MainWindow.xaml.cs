using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using SoulsFormats;
using System.IO;

namespace MSB_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int newNumber = 9999;
        List<string> unusedList = new List<string>();
        List<string> bossList = new List<string>();
        List<string> unusedPlusBossList = new List<string>();
        List<string> addedBosses = new List<string>();
        List<MSBB.Part.Enemy> addedEnemyList = new List<MSBB.Part.Enemy>();
        List<MSBB.Part.Enemy> addedBossesList = new List<MSBB.Part.Enemy>();
        List<string> logList = new List<string>();
        List<long> npcParams = new List<long>();
        List<long> longList = new List<long>();
        List<MSBB.Part.Enemy> oopsAllEnemyList = new List<MSBB.Part.Enemy>();
        List<string> oopsAllEnemyString = new List<string>();
        string oopsBossString;
        List<MSBB.Part.Enemy> oopsAllBossList = new List<MSBB.Part.Enemy>();
        List<string> oopsAllBossString = new List<string>();
        List<string> BossListString = new List<string>();
        bool includeBosses;
        bool randomizeEnemiesBool;
        bool randomize = true;
        bool oopsAllBosses;
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
        bool oopsAll;
        List<string> oopsAllList = new List<string>();
        string oopsAllString;
        List<string> secondaryBosses = new List<string>();
        int totalBossesToReplace = 0;
        List<long> newNPCParam = new List<long>();
        List<long> oldNPCParam = new List<long>();
        long paramNumber = 999999;
        List<string> mapsForParamChanges = new List<string>();
        List<string> chaliceBossString = new List<string>();
        List<MSBB.Part.Enemy> chaliceBossMSB = new List<MSBB.Part.Enemy>();
        List<string> chaliceBossParams = new List<string>();
        List<string> insertBossesString = new List<string>();
        List<MSBB.Part.Enemy> insertBossesEnemy = new List<MSBB.Part.Enemy>();
        string scaleLogFile;

        public MainWindow()
        {
            InitializeComponent();

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
                            int tempInt = npcParamPositions[i] + 18;
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
                    }
                }
            }

            tempMap.Write(currentMap);
        }

        private void GenerateEnemyList(string currentMap, List<string> noNoList)
        {
            string enemyEntityID;
            //var asstwo = LUAGNL.Read(ass);
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

        private void Open_MSB_Click(object sender, RoutedEventArgs e)
        {

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

            List<string> tempDirList = new List<string>();
            List<string> chaliceMapListString = new List<string>();

            //if(seedString == "" || seedString == "Insert Seed.... Numbers Only")
            Random rand = new Random();

            if (File.Exists(mapList[0] + ".bak"))
            {
                for(int i = 0; i < mapList.Count; i ++)
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
            for (int i = 0; i < mapList.Count; i ++)
            {
                var tempAss = MSBB.Read(mapList[i]);

                for(int j = 0; j < tempAss.Models.Enemies.Count; j ++)
                {
                    modelList.Add(tempAss.Models.Enemies[j]);
                }
            }

            var tempMap = MSBB.Read(filePath + "\\map\\mapstudio\\" + "\\m29_52_01_00\\m29_52_01_91.msb.dcx");

            for(int i = 0; i < tempMap.Models.Enemies.Count; i ++)
            {
                modelList.Add(tempMap.Models.Enemies[i]);
            }

            for(int i = 0; i < mapList.Count; i ++)
            {
                var tempAss = MSBB.Read(mapList[i]);

                for(int j = 0; j < modelList.Count; j ++)
                {
                    tempAss.Models.Add(modelList[j]);
                }

                tempAss.Write(mapList[i]);
            }

            if (oopsAll)
            {

                if(oopsAllString.Length > 5)
                {
                    string tempOopsString = oopsAllString.Replace(" ","");
                    int totalStrings = tempOopsString.Length / 5;
                    int startingNumber = 0;
                    for(int i = 0; i < totalStrings; i ++)
                    {
                        oopsAllList.Add(tempOopsString.Substring(startingNumber, 5));
                        startingNumber = startingNumber + 5;
                    }
                }
                else if(oopsAllString.Length == 5)
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
                if(oopsAllString.Contains("c1230"))
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

                while (enemyData.Count > 0)
                {
                    int index = rand.Next(0, enemyData.Count);
                    enemyDataRandomized.Add(enemyData[index]);
                    enemyData.RemoveAt(index);
                }
            }

            string dateNow = DateTime.Now.ToString("h:mm:ss tt");
            string butts = dateNow.Replace(":", "-");
            enemyLogFilePath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + butts + "-EnemyLog.txt";
            using (FileStream sw1 = File.Create(enemyLogFilePath))
            {

            }

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

                for (int i = 0; i < enemyData.Count; i++)
                {
                    secondaryBosses.Add(enemyData[i]);
                }

                while (secondaryBosses.Count <= totalBossesToReplace + 1)
                {
                    int ass = rand.Next(0, enemyData.Count);
                    secondaryBosses.Add(enemyData[ass]);
                }

                while (secondaryBosses.Count > 0)
                {
                    int index = rand.Next(0, secondaryBosses.Count);
                    enemyDataRandomized.Add(secondaryBosses[index]);
                    secondaryBosses.RemoveAt(index);
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
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_00.msb.dcx", nonoList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx", nonoList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_00.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx", unusedPlusBossList);
                InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx", unusedPlusBossList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx", nonoList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx", nonoList);
                //InsertBossesVoid(filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx", nonoList);
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

            string dateNoww = DateTime.Now.ToString("h:mm:ss tt");
            string buttss = dateNoww.Replace(":", "-");
            scaleLogFile = filePath + "\\Mod Files\\Logs. Don't Delete\\" + buttss + "-ScaleLog.txt";
            using (FileStream sw1 = File.Create(scaleLogFile))
            {

            }

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

            MessageBox.Show("Finished.");
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
                            else if(tempGUY.Parts.Enemies[i].Name.Contains("c5070"))
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
                                    && !tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002") && !tempGUY.Parts.Enemies[i].Name.Contains("c4030_0000"))
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


                        if (changeData && enemyDataRandomized.Count > 0)
                        {
                            oldNPCParam.Add(tempGUY.Parts.Enemies[i].NPCParamID);

                            if (enemyDataRandomized.Count <= 2)
                            {
                                for (int k = 0; k < secondaryBosses.Count; k++)
                                {
                                    enemyDataRandomized.Add(secondaryBosses[k]);
                                }
                            }

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
                                while(modelName.Contains("4500"))
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
                                while (modelName.Contains("5100") || modelName.Contains("8050"))
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
                                        enemyDataRandomized.Add(secondaryBosses[random]);
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
                                            enemyDataRandomized.Add(secondaryBosses[random]);
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
                                            enemyDataRandomized.Add(secondaryBosses[random]);
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
                                            enemyDataRandomized.Add(secondaryBosses[random]);
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
                                            enemyDataRandomized.Add(secondaryBosses[random]);
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
                            if (tempGUY.Parts.Enemies[i].ModelName.Contains("2520"))
                            {

                                Random chooseRand = new Random();
                                int randChoose = chooseRand.Next(0, 11);
                                if (randChoose >= 3)
                                {
                                    changeData = false;
                                }
                                else
                                {
                                    changeData = true;
                                }
                            }
                        }

                        if (currentMap.Contains("35"))
                        {
                            if (tempGUY.Parts.Enemies[i].ModelName.Contains("4020"))
                            {

                                Random chooseRand = new Random();
                                int randChoose = chooseRand.Next(0, 11);
                                if (randChoose >= 3)
                                {
                                    changeData = false;
                                }
                                else
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
    }
}
