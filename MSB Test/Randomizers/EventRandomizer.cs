using SoulsFormats;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSB_Test.Randomizers
{
    public static class EventRandomizer
    {
        public static void RandomizeEvents(List<string> events)
        {
            GetEventsFromEventsFiles(events);
            /*
            foreach (var map in maps.Where(x => !x.Contains("m21_00_00_00")))   // Exclude the dream(?)
            {
                RandomizeItemLots(map, itemLotList, nonoItemLots);
            }
            */
        }

        public static List<long> GetEventsFromEventsFiles(List<string> events)
        {
            var eventList = new List<long>();
            foreach (var @event in events)
            {
                eventList.AddRange(GetEventsFromeventFile(@event));
            }

            return eventList;
        }

        private static List<long> GetEventsFromeventFile(string currentEvent)
        {
             if (currentEvent.Contains("m24_01"))
            {
                var match = true;
            }
            var tempEvent = EMEVD.Read(currentEvent);
            var eventLotList = new List<EMEVD.Event>();

            foreach (var gameEvent in tempEvent.Events)
            {
                eventLotList.Add(gameEvent);
            }

            return new List<long>();    // eventLotList;
        }
    }
}
