using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace MSB_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //TalkBox.IsEnabled = false;
            //EasyRomBox.IsEnabled = false;
            //EasyWitchesBox.IsEnabled = false;

            UpperCathedralLabel.Content = String.Format("{0:0.00}", UpperCathedralWardChance);
            CainhurstLabel.Content = String.Format("{0:0.00}", CainhurstChance);
            HuntersNightmareLabel.Content = String.Format("{0:0.00}", HuntersNightmareChance);
            ResearchLabel.Content = String.Format("{0:0.00}", ResearchHallChance);
            MessageBox.Show("READ THIS BEFORE CLOSING THE MESSAGE BOX. Using the new slider: Leaving the slider at 1 will minimize crashing. Putting it at 10 will make the randomizer run as it did before. " +
                "What the slider actually does: Every enemy that is in the game has a value in Megabytes (MB), and the randomizer will now look at that value and replace that enemy with another enemy that " +
                "has an equal or lesser MB value. The slider determines this value ----MB value of original enemy * SliderValue = New MB value limit to replace----. So setting the value to 1 will be the most " +
                "optimal, this will retain the upper MBvalue limit that the new enemy can be (being the actual MBvalue of the original enemy). Setting the slider at a higher value will, therefore, increase the " +
                " upper MBvalue that a new enemy can have. At 10, the upper MBvalue limit will be (MBvalue of original enemy * 10). " +
                "Leaving the slider at a smaller value will lessen the variety of enemies you will see. The higher the value, the greater variety you wil see, but more crashing may happen due to memory issues. " +
                "I have found that a value of 1-1.5 will work with minimal crashing. \r\n \r\n The Ludwig fight and the Failures fight will work correctly. It is recommended that you " +
                "Save and quit then continue before the Ludwig and Failures fights. This will stop a crash from happening during the second phase of the Ludwig fight and the beginning of the " +
                "Failures fight.");
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
            chaliceBossParams = new List<string>{
                "10313090",     "110304090",        "110304098",
                "110304096",        "210501006",        "310501006",
                "10750090",     "110216090",        "210305006",
                "310305006",        "10127090",     "110313080",
                "210209096",        "310209096",        "10304090",
                "10304096",     "10304098",     "110313070",
                "210510096",        "310509006",        "10106090",
                "210305016",        "10216090",     "110501000",
                "210512096",        "110209090",        "210504000",
                "310504000",        "10305006",     "110509010",
                "10218090",     "110504000",        "210508006",
                "310504000",        "110257000",        "210251096",
                "310305016",        "210306016",        "511000"
            };

            unusedList = new List<string>{
                "c2120_9999",       "c2120_9998",       "c0000",
                "c2560",        "c0",       "c1020",
                "c1030",        "c1080",        "c2030",
                "c2300",        "c2310",        "c2800",
                "c2810",        "c2910",        "c3110",
                "c4150",        "c5030",        "c5110",
                "c5140",        "c5150",        "c5400",
                "c5420",        "c5500",        "c5501",
                "c5502",        "c5520",        "c5521",
                "c5522",        "c7000",        "c7010",
                "c7100",        "c8010",        "c8020",
                "c2501",        "c90",      "c9030",
                "c2501",        "c2571",        "c8030_0000",
                "c8040_0000",       "c9020_0000",       "c9020_0001",
                "c9020_0002",       "c9020_0003",       "c8030_0000",
                "c5072_0000",       "c4023_0000",       "c4160_0000",
                "c4160_0001",       "c4160_0002",       "c4160_0003",
                "c4550_0000",       "c7110_0000",       "c5071_0000",
                "c4511_0000",       "c5510_0001",       "c5510_0002",
                "c4540_0000",       "c4543_0000",       "c8070_0000",
                "c5130_0000",       "c4031_0000",       "c4520_0000",
                "c1190",        "c1180",        "c1060_0002"
            };

            bossList = new List<string>
            {
                "5090",     "c2090_0003",       "c2100_0000",
                "c2100_0001",       "c2120_0000",       "c2120_0001",
                "c2120_0002",       "c2320_0000",       "c2500_0000",
                "c2570_0001",       "c2510_0000",       "c2710_0000",
                "c2720_0000",       "c4520_0002",       "c4030_0000",
                "c4030_0001",       "c4030_0002",       "c4030_0003",
                "c4030_0004",       "c4500_0000",       "c4510_0000",
                "c4540_0000",       "c4541_0000",       "c5000_0000",
                "c5020_0000",       "c5070_0000",       "c5080_0000",
                "c5100_0000",       "c5120_0001",       "c5400_0000",
                "c5510_0000",       "c8050_0000",       "c3130_0000",
                "c5010_0000",       "c4510_0002",       "c3050_0000",
                "c3060_0000",       "c5110"
            };

            unusedPlusBossList.AddRange(unusedList);
            unusedPlusBossList.AddRange(bossList);
        }

        private void ParamScalingForBosses(string currentMap)
        {

            var tempMap = MSBB.Read(currentMap);

            List<int> npcParamPositions = new List<int>();
            for (int i = 0; i < npcParams.Count; i++)
            {
                for (int j = 0; j < longList.Count; j++)
                {
                    if (npcParams[i] == longList[j])
                    {
                        npcParamPositions.Add(j);
                    }
                }
            }

            /*
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
            */

            if (logging)
                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                {
                    writetext.WriteLine(currentMap);
                }
            for (int i = 0; i < npcParamPositions.Count; i++)
            {
                for (int j = 0; j < tempMap.Parts.Enemies.Count; j++)
                {
                    if (tempMap.Parts.Enemies[j].NPCParamID == longList[npcParamPositions[i]])
                    {
                        if (logging)
                            using (StreamWriter writetext = File.AppendText(scaleLogFile))
                            {
                                writetext.WriteLine(tempMap.Parts.Enemies[j].NPCParamID);
                            }
                        //filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx"
                        if (currentMap == filePath + "\\map\\mapstudio\\" + "m21_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + dreamScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
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
                            int tempInt = npcParamPositions[i] + hemwickScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m23_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + oldScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + cathedralScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_01_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + centralScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m24_02_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + upperScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m25_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + cainhurstScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m26_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + mensisScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m27_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + woodsScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m28_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + yahargulScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m32_00_00_01.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + byrgenwerthScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m33_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + frontierScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m34_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + nightmareScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m35_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + researchScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
                                using (StreamWriter writetext = File.AppendText(scaleLogFile))
                                {
                                    writetext.WriteLine(tempUInt);
                                }
                        }
                        //filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx"
                        else if (currentMap == filePath + "\\map\\mapstudio\\" + "m36_00_00_00.msb.dcx")
                        {
                            int tempInt = npcParamPositions[i] + hamletScale;
                            var tempUInt = Convert.ToInt32(longList[tempInt]);
                            tempMap.Parts.Enemies[j].NPCParamID = tempUInt;
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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
                            if (logging)
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



            var tempGUY = MSBB.Read(currentMap);

            List<MSBB.Part.Enemy> tempList = new List<MSBB.Part.Enemy>();

            bool addEnemy;

            for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
            {
                addEnemy = true;

                if (!addedStoneGuyBool)
                {
                    if (tempGUY.Parts.Enemies[i].ModelName.Contains("c2521"))
                    {
                        stoneGuyEnemy = tempGUY.Parts.Enemies[i];
                        tempStoneEnemyString = (stoneGuyEnemy.NPCParamID.ToString() + "*" + stoneGuyEnemy.ThinkParamID.ToString() + "*" + stoneGuyEnemy.ModelName);
                        int tempnpcint = tempStoneEnemyString.IndexOf("*");
                        string tempNpcParam = tempStoneEnemyString.Substring(0, tempnpcint);
                        string tempThinkId = tempStoneEnemyString.Substring(tempnpcint + 1, tempStoneEnemyString.LastIndexOf("*") - tempnpcint - 1);
                        stoneGuyModelName = tempStoneEnemyString.Substring(tempStoneEnemyString.LastIndexOf("*") + 1, 5);
                        stoneGuyParam = int.Parse(tempNpcParam);
                        stoneGuyThink = int.Parse(tempThinkId);
                    }
                }

                if (!oopsAll)
                {
                    for (int j = 0; j < noNoList.Count; j++)
                    {
                        if (tempGUY.Parts.Enemies[i].Name.Contains(noNoList[j]))
                        {
                            addEnemy = false;
                            j = noNoList.Count + 1;
                        }
                        else if (tempGUY.Parts.Enemies[i].ThinkParamID <= 1)
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

            for (int i = 0; i < tempMap.Parts.Enemies.Count; i++)
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


        private void EasyModes(string currentMap)
        {
            var tempGUY = MSBB.Read(currentMap);

            for (int i = 0; i < tempGUY.Parts.Enemies.Count; i++)
            {
                //shadows
                if (currentMap.Contains("m27"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2120_0001"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                }
                //rom
                else if (currentMap.Contains("m32_00"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c1400"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                }
                //emissary
                else if (currentMap.Contains("m24_02"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0001"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0002"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0003"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0004"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0005"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0006"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0007"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0008"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0009"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2500_0010"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                }
                //failures
                else if (currentMap.Contains("m35_00"))
                {
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0001"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0002"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0003"))
                    {
                        tempGUY.Parts.Enemies[i].NPCParamID = stoneGuyParam;
                        tempGUY.Parts.Enemies[i].ThinkParamID = stoneGuyThink;
                        tempGUY.Parts.Enemies[i].ModelName = stoneGuyModelName;
                    }
                }
            }

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


                        int randomNumber = universalRand.Next(0, combinedBossList2.Count);
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
                            randomNumber = universalRand.Next(0, combinedBossList2.Count);
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

                        if (logging)
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
                                writetext.WriteLine(modelName + " new model");
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


                        int randomNumber = universalRand.Next(0, combinedBossList2.Count);
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
                            randomNumber = universalRand.Next(0, combinedBossList2.Count);
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

                        if (logging)
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
                                writetext.WriteLine(modelName + " new model");
                            }
                    }
                    if (tempGUY.Parts.Enemies[i].Name.Contains("c2120_0002"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();


                        int randomNumber = universalRand.Next(0, combinedBossList2.Count);
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
                            randomNumber = universalRand.Next(0, combinedBossList2.Count);
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

                        if (logging)
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
                                writetext.WriteLine(modelName + " new model");
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


                        int randomNumber = universalRand.Next(0, combinedBossList2.Count);
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
                            randomNumber = universalRand.Next(0, combinedBossList2.Count);
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

                        if (logging)
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
                                writetext.WriteLine(modelName + " new model");
                            }
                    }

                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0002"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();


                        int randomNumber = universalRand.Next(0, combinedBossList2.Count);
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
                            randomNumber = universalRand.Next(0, combinedBossList2.Count);
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

                        if (logging)
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
                                writetext.WriteLine(modelName + " new model");
                            }
                    }

                    if (tempGUY.Parts.Enemies[i].Name.Contains("c4030_0003"))
                    {
                        thisnpc = tempGUY.Parts.Enemies[i].NPCParamID.ToString();
                        thisthink = tempGUY.Parts.Enemies[i].ThinkParamID.ToString();
                        thismo = tempGUY.Parts.Enemies[i].ModelName;
                        thisentityID = tempGUY.Parts.Enemies[i].EntityID.ToString();


                        int randomNumber = universalRand.Next(0, combinedBossList2.Count);
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
                            randomNumber = universalRand.Next(0, combinedBossList2.Count);
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

                        if (logging)
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
                                writetext.WriteLine(modelName + " new model");
                            }
                    }
                }
            }

            tempGUY.Write(currentMap);
        }

        private void PermaDarknessFunction(string currentEmevd)
        {
            var tempEMEVD = EMEVD.Read(currentEmevd);

            for (int i = 0; i < tempEMEVD.Events.Count; i++)
            {
                if (tempEMEVD.Events[i].ID.ToString() == "6548972")
                {
                    if (permaDarknessBool)
                    {
                        string strOne = "254";
                        string strTwo = "21";
                        string strThree = "0";
                        string strFour = "1";
                        byte bytOne = byte.Parse(strOne);
                        byte bytTwo = byte.Parse(strTwo);
                        byte bytThree = byte.Parse(strThree);
                        byte bytFour = byte.Parse(strFour);

                        tempEMEVD.Events[i].Instructions[0].ArgData[4] = bytOne;
                        tempEMEVD.Events[i].Instructions[0].ArgData[5] = bytTwo;
                        tempEMEVD.Events[i].Instructions[0].ArgData[6] = bytThree;
                        tempEMEVD.Events[i].Instructions[0].ArgData[8] = bytFour;
                    }
                    else if (!permaDarknessBool)
                    {
                        string strOne = "159";
                        string strTwo = "134";
                        string strThree = "1";
                        string strFour = "0";
                        byte bytOne = byte.Parse(strOne);
                        byte bytTwo = byte.Parse(strTwo);
                        byte bytThree = byte.Parse(strThree);
                        byte bytFour = byte.Parse(strFour);

                        tempEMEVD.Events[i].Instructions[0].ArgData[4] = bytOne;
                        tempEMEVD.Events[i].Instructions[0].ArgData[5] = bytTwo;
                        tempEMEVD.Events[i].Instructions[0].ArgData[6] = bytThree;
                        tempEMEVD.Events[i].Instructions[0].ArgData[8] = bytFour;
                    }
                }
            }

            tempEMEVD.Write(currentEmevd);
        }
    }
}
