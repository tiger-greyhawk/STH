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

        public string Id { get { return id.ToString(); } }
        public string TravelTime { get { return new TimeSpan(travelTime * 10000).ToString(); } }
        public string Multiplier { get { return multiplier.ToString(); } }
        public string Name { get { return name; } }
    }
}
