using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MissionLauncher
{
    class Dune2000Score
    {
        const int LightInfantryProductionSpeed = 180;
        const int TrooperProductionSpeed = 132;
        const int EngineerProductionSpeed = 90;
        const int ThumperInfantryProductionSpeed = 90;
        const int SardaukarProductionSpeed = 120;
        const int GrenadierProductionSpeed = 120;
        const int SardaukarMPProductionSpeed = 70;
        //const int StealthFremenProductionSpeed = 5;
        //const int FremenProductionSpeed = 5;
        //const int SandwormProductionSpeed = 30;
        //const int SaboteurProductionSpeed = 5;

        const int TrikeProductionSpeed = 50;
        const int RaiderProductionSpeed = 50;
        const int QuadProductionSpeed = 35;
        const int StealthRaiderProductionSpeed = 50;

        const int HarvesterProductionSpeed = 18;
        const int CombatTankAtreidesProductionSpeed = 26;
        const int CombatTankHarkonnenProductionSpeed = 26;
        const int CombatTankOrdosProductionSpeed = 26;
        const int MCVProductionSpeed = 15;
        const int MissileTankProductionSpeed = 22;
        const int DeviatorProductionSpeed = 20;
        const int SiegeTankProductionSpeed = 30;
        const int SonicTankProductionSpeed = 20;
        const int DevastatorProductionSpeed = 18;

        //const int ChoamFrigateProductionSpeed = 30;
        //const int CarryallProductionSpeed = 15;
        //const int Carryall2ProductionSpeed = 15;
        //const int OrnithopterProductionSpeed = 2;
        //const int DeathHandRocketProductionSpeed = 2;

        public double[] InfantryProductionEfficiency = new double[8];
        public double[] HeavyVehiclesProductionEfficiency = new double[8];
        public double[] LightVehiclesProductionEfficiency = new double[8];
        public double[] TotalProductionEfficiency = new double[8];

        private Dune2000StatsDump StatsDump;

        public Dune2000Score(Dune2000StatsDump statsDump)
        {
            StatsDump = statsDump;
            CalculateProductionEfficiency();
        }

        private void CalculateProductionEfficiency()
        {
            for (int house = 0; house < StatsDump.PlayerCount; house++)
            {
                int boost = 125 + GetHandicapBoost(StatsDump.Handicaps[house]);

                InfantryProductionEfficiency[house] += GetEfficiency(boost, LightInfantryProductionSpeed, StatsDump.LightInfantryOwned[house]);
                InfantryProductionEfficiency[house] += GetEfficiency(boost, TrooperProductionSpeed, StatsDump.TrooperOwned[house]);
                InfantryProductionEfficiency[house] += GetEfficiency(boost, EngineerProductionSpeed, StatsDump.EngineerOwned[house]);
                InfantryProductionEfficiency[house] += GetEfficiency(boost, ThumperInfantryProductionSpeed, StatsDump.ThumperInfantryOwned[house]);
                InfantryProductionEfficiency[house] += GetEfficiency(boost, SardaukarProductionSpeed, StatsDump.SardaukarOwned[house]);
                InfantryProductionEfficiency[house] += GetEfficiency(boost, GrenadierProductionSpeed, StatsDump.GrenadierOwned[house]);
                InfantryProductionEfficiency[house] += GetEfficiency(boost, SardaukarMPProductionSpeed, StatsDump.SardaukarMPOwned[house]);

                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, HarvesterProductionSpeed, StatsDump.HarvesterOwned[house] - (StatsDump.RefineryAtreidesOwned[house] + StatsDump.RefineryHarkonnenOwned[house] + StatsDump.RefineryOrdosOwned[house]));
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, CombatTankAtreidesProductionSpeed, StatsDump.CombatTankAtreidesOwned[house]);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, CombatTankHarkonnenProductionSpeed, StatsDump.CombatTankHarkonnenOwned[house]);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, CombatTankOrdosProductionSpeed, StatsDump.CombatTankOrdosOwned[house]);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, MCVProductionSpeed, StatsDump.MCVOwned[house] - 1);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, MissileTankProductionSpeed, StatsDump.MissileTankOwned[house]);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, DeviatorProductionSpeed, StatsDump.DeviatorOwned[house]);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, SiegeTankProductionSpeed, StatsDump.SiegeTankOwned[house]);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, SonicTankProductionSpeed, StatsDump.SonicTankOwned[house]);
                HeavyVehiclesProductionEfficiency[house] += GetEfficiency(boost, DevastatorProductionSpeed, StatsDump.DevastatorOwned[house]);

                LightVehiclesProductionEfficiency[house] += GetEfficiency(boost, TrikeProductionSpeed, StatsDump.TrikeOwned[house]);
                LightVehiclesProductionEfficiency[house] += GetEfficiency(boost, RaiderProductionSpeed, StatsDump.RaiderOwned[house]);
                LightVehiclesProductionEfficiency[house] += GetEfficiency(boost, QuadProductionSpeed, StatsDump.QuadOwned[house]);
                LightVehiclesProductionEfficiency[house] += GetEfficiency(boost, StealthRaiderProductionSpeed, StatsDump.StealthRaiderOwned[house]);

                TotalProductionEfficiency[house] = (InfantryProductionEfficiency[house] * 0.1) + (HeavyVehiclesProductionEfficiency[house] * 0.6) + (LightVehiclesProductionEfficiency[house] * 0.3);
            }
        }

        private double GetEfficiency(int boost, int productionSpeed, int unitsOwned)
        {
            int buildTimeTicks = 23040 / (boost * productionSpeed / 100);
            uint maxProduction = (uint)(StatsDump.GameTicks / buildTimeTicks);
            if (maxProduction == 0 || unitsOwned <= 0) return 0;
            return (Convert.ToDouble(unitsOwned) / maxProduction) * 100;
        }

        private int GetHandicapBoost(int handicap)
        {
            switch (handicap)
            {
                case 1: return 125;
                case 2: return 100;
                case 3: return 75;
                default: return 100;
            }
        }

    }
}
