using SoulsFormats;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MSB_Test.Randomizers
{
    public class ItemRandomizer
    {
        List<int> nonoItemLots;
        List<int> keyItemLots;
        List<int> workshopItemsList;
        string filePath;
        bool logging;
        Random rand;

        public ItemRandomizer(string filePath, ref Random rand, bool workshopBool = false, bool logging = true)
        {
            this.filePath = filePath;
            this.logging = logging;
            this.rand = rand;

            nonoItemLots = new List<int>
            {
                2600550,     //Evil Eye Bridge key (key in nightmare of mensis?)
                2400450,     //The key to the Old Town (gascoigne key?)
                3500800      //The key to the dungeon usually door (braidor key?)
            };
            keyItemLots = new List<int>
            {
                2800290,    //The key to Cathedral Street C (UCW key)
                3200720,    //The key to nightmare classroom (byrgenworth lower floor key)
                3200810,    //Veranda of key (key to rom fight)
                2410990,    //Invitation to the castle (cainhurst summons)
                3502000,    //Parish length Ω Startup Item (laurence skull)
                3401810     //Altar Elevator Startup Item (eye pendant)
            };
            workshopItemsList = new List<int>
            {
                2411000,    //Blood gem workshop tool (chest after gascoigne)
                2200360     //Rune tool (after witches)
            };

            nonoItemLots.AddRange(keyItemLots);

            if (!workshopBool)
            {
                nonoItemLots.AddRange(workshopItemsList);
            }
        }

        public void RandomizeItems(List<string> maps, List<long> eventList = null)
        {
            var itemLotList = new List<int>();
            foreach (var map in maps.Where(x => !x.Contains("m21_00_00_00")))   // Exclude the dream(?)
            {
                itemLotList.AddRange(GenerateItemLotList(map, nonoItemLots, eventList));
            }
            foreach (var map in maps.Where(x => !x.Contains("m21_00_00_00")))   // Exclude the dream(?)
            {
                RandomizeItemLots(map, itemLotList, nonoItemLots);
            }
        }

        private List<int> GenerateItemLotList(string currentMap, List<int> nonoItemLots, List<long> eventList = null)
        {
            var tempGuy = MSBB.Read(currentMap);
            var itemLotList = new List<int>();

            foreach (var treasure in tempGuy.Events.Treasures)
            {
                if (currentMap.Contains("m24_01"))
                {
                    var match = true;
                }
                if (treasure.ItemLot1 > 1 && !nonoItemLots.Contains(treasure.ItemLot1))
                {
                    itemLotList.Add(treasure.ItemLot1);
                }
                if (treasure.ItemLot2 > 1 && !nonoItemLots.Contains(treasure.ItemLot2))
                {
                    itemLotList.Add(treasure.ItemLot2);
                }
                if (treasure.ItemLot3 > 1 && !nonoItemLots.Contains(treasure.ItemLot3))
                {
                    itemLotList.Add(treasure.ItemLot3);
                }
            }

            return itemLotList;
        }

        private void RandomizeItemLots(string currentMap, List<int> itemLotList, List<int> nonoItemLots)
        {
            var randomizedItemLotPath = filePath + "\\Mod Files\\Logs. Don't Delete\\" + DateTime.Now.ToString("h:mm:ss tt").Replace(":", "-") + "-RandomizedItemLog.txt";
            if (logging)
                using (FileStream sw1 = File.Create(randomizedItemLotPath));

            var tempGuy = MSBB.Read(currentMap);
            int numberOfKeyIemsRandomized = 0;

            if (!(itemLotList.Count > 0))
                return;

            foreach (var treasure in tempGuy.Events.Treasures)
            {
                var results = new List<Tuple<int, int>>();
                if (treasure.ItemLot1 > 0 && !nonoItemLots.Contains(treasure.ItemLot1))
                {
                    results.Add(RandomizeTreasureWithResult(treasure, ref itemLotList, 1));
                }
                if (treasure.ItemLot2 > 0 && !nonoItemLots.Contains(treasure.ItemLot2))
                {
                    results.Add(RandomizeTreasureWithResult(treasure, ref itemLotList, 2));
                }
                if (treasure.ItemLot3 > 0 && !nonoItemLots.Contains(treasure.ItemLot3))
                {
                    results.Add(RandomizeTreasureWithResult(treasure, ref itemLotList, 3));
                }
                if (logging)
                {
                    foreach(var result in results)
                    {
                        WriteOldLog(randomizedItemLotPath, currentMap, numberOfKeyIemsRandomized, result.Item1);
                        numberOfKeyIemsRandomized++;
                        WriteNewLog(randomizedItemLotPath, currentMap, numberOfKeyIemsRandomized, result.Item2);
                    }
                }
            }

            tempGuy.Write(currentMap);
        }

        private Tuple<int, int> RandomizeTreasureWithResult(MSBB.Event.Treasure treasure, ref List<int> itemLotList, int lotNumber = 1)
        {
            var randomNumber = rand.Next(0, itemLotList.Count);
            int old = 0;
            int newVal = 0;
            switch (lotNumber)
            {
                case 2:
                    old = treasure.ItemLot2;
                    treasure.ItemLot2 = itemLotList[randomNumber];
                    newVal = treasure.ItemLot2;
                    break;
                case 3:
                    old = treasure.ItemLot3;
                    treasure.ItemLot3 = itemLotList[randomNumber];
                    newVal = treasure.ItemLot3;
                    break;
                case 1:
                default:
                    old = treasure.ItemLot1;
                    treasure.ItemLot1 = itemLotList[randomNumber];
                    newVal = treasure.ItemLot1;
                    break;
            }
            itemLotList.RemoveAt(randomNumber);
            return new Tuple<int, int>(old, newVal);
        }

        private void WriteOldLog(string randomizedItemLotPath, string currentMap, int numberOfKeyIemsRandomized, int treasure)
        {
            using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
            {
                writetext.WriteLine(currentMap);
                writetext.WriteLine("Number of items randomized so far " + numberOfKeyIemsRandomized);
                writetext.WriteLine("Old item lot");
                writetext.WriteLine(treasure);
            }

        }
        private void WriteNewLog(string randomizedItemLotPath, string currentMap, int numberOfKeyIemsRandomized, int treasure)
        {
            using (StreamWriter writetext = File.AppendText(randomizedItemLotPath))
            {
                writetext.WriteLine("New item lot");
                writetext.WriteLine(treasure);
                writetext.WriteLine(Environment.NewLine);
            }
        }
    }
}
