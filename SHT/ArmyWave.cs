using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHT
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

        public string Id { get { return id.ToString(); } }
        public string TravelTime { get { return travelTime.ToString(); } }
        public string Multiplier { get { return multiplier.ToString(); } }
        public string Name { get { return name; } }
    }
}
