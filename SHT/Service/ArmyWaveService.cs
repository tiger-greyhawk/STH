using SHT.Dto;
using System.Collections.Generic;

namespace SHT.Service
{
    class ArmyWaveService
    {
        private List<ArmyWave> armyWaves = new List<ArmyWave>
        {
                    new ArmyWave(0, 1234, 2, "Nieaset"),
                    new ArmyWave(1, 37712313, 2, "Bolivian"),
                    new ArmyWave(2, 137712222, 2, "Olivastr")
        };

        public List<ArmyWave> FindAll()
        {
            return armyWaves;
        }

    }
}
