using SoulsFormats;
using StudioCore.MsbEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MSB_Test.Randomizers
{
    public enum lotItemCategory
    {
        Weapon = 0,
        Armor = 1,
        Good = 4,
        GemAndRune = 8
    }
    public class ItemLotRandomizer
    {
        List<int> nonoItemLots;
        List<int> keyItemLots;
        List<int> workshopItemsList;
        string filePath;
        bool logging;
        Random rand;

        public ItemLotRandomizer(ref Random rand, bool logging = true)
        {
            this.logging = logging;
            this.rand = rand;
        }

        public void RandomizeItems(ParamBank bank, IEnumerable<int> treasureLots)
        {
            /*
            lotItemCategory01
                0 - Weapon
                1 - Armor
                4 - Good
                8 - Gem / Rune
            
            Item Count
                How many of item to get.  Probably do 1x for everything except Goods.  

            Item Slot #     // You can add sequential new lotItemCategorys to add additional item unlocks / create multiple drops.  
                Item ID.                

            Item # Chance Points
                You could LIVE randomize like this?  
                Each item has a chance to be one of x items.  
                Could mean you play a new run on the same randomizer and find new stuff.
                Treat it like Gatcha rolls lol.  Every item is 5 rolls, low rate for good stuff, but you get a lot of chances at it.  
            */
            /*
            Should have an already generated list of randomizable items.  
                Should only have base level weapons.  
                Cut content items should be user configurable. 
            Includes: 
                Item ID 
                Item Name
                Item Category
                Cut Content bool
                ConfigurableItemCount bool
                Rarity(?)   // For Gacha style rolls
                Scaling level(?)    // For scaling-mapped rolls
            */

            /*
            For each ItemLot in ParamBank (Maybe only modify ones explcitly linked to treasure?)
                Check if its a key item.
                If not, continue. 
                Pull a random item from item list. 
                Check category
                If Weapon, 
                    Set random upgrade level(?)
                If Good
                    Set random item count
                Replace item with randomized item
                Check if next slot is used already.  
                If not, maybe add up to 5x item drops?
            Once all modified, save.
            */
            /*
            var itemLotList = GetItemLotListFromMaps(maps);
            foreach (var map in maps.Where(x => !x.Contains("m21_00_00_00")))   // Exclude the dream(?)
            {
                RandomizeItemLots(map, itemLotList, nonoItemLots);
            }
            */

            var objAct = ParamBank.Params.Where(x => x.Key.Equals("ItemLotParam")).FirstOrDefault().Value.Rows.Where(x => treasureLots.Contains(x.ID));

        }

        public List<int> GetItemLotListFromMaps(List<string> maps)
        {
            return null;
        }

        private List<int> GenerateItemList(string currentMap, List<int> nonoItemLots)
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
                using (FileStream sw1 = File.Create(randomizedItemLotPath)) ;

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
                    foreach (var result in results)
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
