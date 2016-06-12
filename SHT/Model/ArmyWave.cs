using System;

namespace SHT.Dto
{
    public class ArmyWave
    {
        private long id;
        private long travelTime;
        private int multiplier;
        private string name;

        public ArmyWave(long id, long travelTime, int multiplier, string name)
        {
            this.id = id;
            this.travelTime = travelTime;
            this.multiplier = multiplier;
            this.name = name;
        }

        public long GetId() { return id; }
        public long GetTravelTime() { return travelTime; }
        public int GetMultiplier() { return multiplier; }
        public string GetName() { return name; }

        public string Id
        {
            get { return id.ToString(); }
            set { id = Convert.ToInt32(value); }
        }
        public string TravelTime
        {
            get { return new TimeSpan(travelTime * 10000).ToString(@"dd\.hh\:mm\:ss"); }
            set
            {
                TimeSpan result;
                TimeSpan.TryParseExact(value, @"dd\.hh\:mm\:ss", null, out result);
                travelTime = result.Ticks / 10000;
            }
        }
        public string Multiplier { get { return multiplier.ToString(); } set { multiplier = Convert.ToInt32(value); } }
        public string Name { get { return name; } set { name = value; } }
    }
}
