using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MissionLauncher
{
    public class Dune2000StatsDump
    {
        public string[] Names = new string[8];
        public string[] Sides = new string[8];
        public string[] Colors = new string[8];
        public int[] Handicaps = new int[8];
        public int[] FinishingPlaces = new int[8];
        public int[] SpiceHarvested = new int[8];
        public int[] BuildingsOwned = new int[8];
        public int[] BuildingsLost = new int[8];
        public int[] BuildingsDestroyed = new int[8];
        public int[] UnitsOwned = new int[8];
        public int[] UnitsLost = new int[8];
        public int[] UnitsKilled = new int[8];
        //public int[] Ips = new int[8];
        public int[] Credits = new int[8];

        public int[] InfantryOwned = new int[8];
        public int[] HeavyVehiclesOwned = new int[8];
        public int[] LightVehiclesOwned = new int[8];
        public int[] AirUnitsOwned = new int[8];

        public int[] LightInfantryOwned = new int[8];
        public int[] TrooperOwned = new int[8];
        public int[] EngineerOwned = new int[8];
        public int[] ThumperInfantryOwned = new int[8];
        public int[] SardaukarOwned = new int[8];
        public int[] TrikeOwned = new int[8];
        public int[] RaiderOwned = new int[8];
        public int[] QuadOwned = new int[8];
        public int[] HarvesterOwned = new int[8];
        public int[] CombatTankAtreidesOwned = new int[8];
        public int[] CombatTankHarkonnenOwned = new int[8];
        public int[] CombatTankOrdosOwned = new int[8];
        public int[] CombatTankAllOwned = new int[8];
        public int[] MCVOwned = new int[8];
        public int[] MissileTankOwned = new int[8];
        public int[] DeviatorOwned = new int[8];
        public int[] SiegeTankOwned = new int[8];
        public int[] SonicTankOwned = new int[8];
        public int[] DevastatorOwned = new int[8];
        public int[] CarryallOwned = new int[8];
        public int[] Carryall2Owned = new int[8];
        public int[] OrnithopterOwned = new int[8];
        public int[] StealthFremenOwned = new int[8];
        public int[] FremenOwned = new int[8];
        public int[] SaboteurOwned = new int[8];
        public int[] DeathHandRocketOwned = new int[8];
        public int[] SandwormOwned = new int[8];
        public int[] ChoamFrigateOwned = new int[8];
        public int[] GrenadierOwned = new int[8];
        public int[] StealthRaiderOwned = new int[8];
        public int[] SardaukarMPOwned = new int[8];

        public int[] ConstructionYardAtreidesOwned = new int[8]; //id 0
        public int[] ConstructionYardHarkonnenOwned = new int[8]; //id 1 ...
        public int[] ConstructionYardOrdosOwned = new int[8];
        public int[] ConstructionYardUnknown1Owned = new int[8]; //black
        public int[] ConstructionYardAllOwned = new int[8];
        public int[] Unknown1Owned = new int[8]; //Building type is concrete - display.cpp
        public int[] Unknown2Owned = new int[8]; //Building type is concrete - display.cpp
        public int[] Unknown3Owned = new int[8]; //Building type is concrete - display.cpp
        public int[] Unknown4Owned = new int[8]; //Building type is concrete - display.cpp
        public int[] Unknown5Owned = new int[8]; //Building type is concrete - display.cpp
        public int[] ConstructionYardUnknown2Owned = new int[8]; //white
        public int[] WindTrapAtreidesOwned = new int[8];
        public int[] WindTrapHarkonnenOwned = new int[8];
        public int[] WindTrapOrdosOwned = new int[8];
        public int[] WindTrapAllOwned = new int[8];
        public int[] BarracksAtreidesOwned = new int[8];
        public int[] BarracksHarkonnenOwned = new int[8];
        public int[] BarracksOrdosOwned = new int[8];
        public int[] BarracksAllOwned = new int[8];
        public int[] SietchOwned = new int[8];
        public int[] WallAtreidesOwned = new int[8];
        public int[] WallHarkonnenOwned = new int[8];
        public int[] WallOrdosOwned = new int[8];
        public int[] WallAllOwned = new int[8];
        public int[] RefineryAtreidesOwned = new int[8];
        public int[] RefineryHarkonnenOwned = new int[8];
        public int[] RefineryOrdosOwned = new int[8];
        public int[] RefineryAllOwned = new int[8];
        public int[] GunTurretAtreidesOwned = new int[8];
        public int[] GunTurretHarkonnenOwned = new int[8];
        public int[] GunTurretOrdosOwned = new int[8];
        public int[] GunTurretAllOwned = new int[8];
        public int[] OutpostAtreidesOwned = new int[8];
        public int[] OutpostHarkonnenOwned = new int[8];
        public int[] OutpostOrdosOwned = new int[8];
        public int[] OutpostAllOwned = new int[8];
        public int[] RocketTurretAtreidesOwned = new int[8];
        public int[] RocketTurretHarkonnenOwned = new int[8];
        public int[] RocketTurretOrdosOwned = new int[8];
        public int[] RocketTurretAllOwned = new int[8];
        public int[] HighTechFactoryAtreidesOwned = new int[8];
        public int[] HighTechFactoryHarkonnenOwned = new int[8];
        public int[] HighTechFactoryOrdosOwned = new int[8];
        public int[] HighTechFactoryAllOwned = new int[8];
        public int[] LightFactoryAtreidesOwned = new int[8];
        public int[] LightFactoryHarkonnenOwned = new int[8];
        public int[] LightFactoryOrdosOwned = new int[8];
        public int[] LightFactoryAllOwned = new int[8];
        public int[] SiloAtreidesOwned = new int[8];
        public int[] SiloHarkonnenOwned = new int[8];
        public int[] SiloOrdosOwned = new int[8];
        public int[] SiloAllOwned = new int[8];
        public int[] HeavyFactoryAtreidesOwned = new int[8];
        public int[] HeavyFactoryHarkonnenOwned = new int[8];
        public int[] HeavyFactoryOrdosOwned = new int[8];
        public int[] HeavyFactoryUnknown1Owned = new int[8]; //gold
        public int[] HeavyFactoryUnknown2Owned = new int[8]; //black
        public int[] HeavyFactoryAllOwned = new int[8];
        public int[] StarportAtreidesOwned = new int[8];
        public int[] StarportHarkonnenOwned = new int[8];
        public int[] StarportOrdosOwned = new int[8];
        public int[] StarportUnknownOwned = new int[8]; //gold
        public int[] StarportAllOwned = new int[8];
        public int[] RepairPadAtreidesOwned = new int[8];
        public int[] RepairPadHarkonnenOwned = new int[8];
        public int[] RepairPadOrdosOwned = new int[8];
        public int[] RepairPadAllOwned = new int[8];
        public int[] IXResearchCenterAtreidesOwned = new int[8];
        public int[] IXResearchCenterHarkonnenOwned = new int[8];
        public int[] IXResearchCenterOrdosOwned = new int[8];
        public int[] IXResearchCenterAllOwned = new int[8];
        public int[] AtreidesPalaceOwned = new int[8];
        public int[] HarkonnenPalaceOwned = new int[8];
        public int[] OrdosPalaceOwned = new int[8];
        public int[] EmperorsPalaceOwned = new int[8]; //60
        public int[] ModifiedOutpost1Owned = new int[8];
        public int[] ModifiedOutpost2Owned = new int[8];
        public int[] ModifiedOutpostAllOwned = new int[8];

        public bool SuddenDisconnect = false;
        public string EndStatus = "";
        public bool TournamentGame = false;
        public uint GameId = 0;
        public string GameDuration = "";
        public string MapName = "";
        public uint GameTicks = 0;
        public byte PlayerCount = 0;

        public int Worms = -1;
        public uint StartingCredits = 0;
        public bool Crates = false;
        public int TechLevel = -1;
        public uint UnitCount = 0;

        private string FileName;

        public Dune2000StatsDump(string fileName)
        {
            FileName = fileName;
            ReadStatsDump();
        }

        private void ReadStatsDump()
        {
            using (var fileStream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                fileStream.Position = 4;
                while (fileStream.Position + 4 < fileStream.Length)
                {
                    string id = Encoding.Default.GetString(binaryReader.ReadBytes(4));
                    ushort dataType = BitConverter.ToUInt16(Reverse(binaryReader.ReadBytes(2)), 0);
                    ushort length = BitConverter.ToUInt16(Reverse(binaryReader.ReadBytes(2)), 0);
                    byte[] data;
                    if (dataType == 7)
                    {
                        data = binaryReader.ReadBytes(length - 1);
                        fileStream.Position++;
                    }
                    else data = binaryReader.ReadBytes(length);
                    SaveStats(id, data);
                    while ((fileStream.Position % 4) != 0) fileStream.Position++;
                }
            }
        }

        private void SaveStats(string id, byte[] data)
        {
            byte house;
            switch (id)
            {
                case "TIME":
                    var timeSpan = TimeSpan.FromSeconds(BitConverter.ToUInt32(Reverse(data), 0));
                    GameDuration = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                    break;
                case "SCR0":
                case "SCR1":
                case "SCR2":
                case "SCR3":
                case "SCR4":
                case "SCR5":
                case "SCR6":
                case "SCR7":
                    string[] score = Encoding.Default.GetString(data).Split('/');
                    house = Convert.ToByte(id[id.Length - 1].ToString());
                    FinishingPlaces[house] = Convert.ToInt32(score[0]) + 1;
                    BuildingsOwned[house] = Convert.ToInt32(score[1]);
                    BuildingsLost[house] = Convert.ToInt32(score[2]);
                    BuildingsDestroyed[house] = Convert.ToInt32(score[3]);
                    UnitsOwned[house] = Convert.ToInt32(score[4]);
                    UnitsLost[house] = Convert.ToInt32(score[5]);
                    UnitsKilled[house] = Convert.ToInt32(score[6]);
                    SpiceHarvested[house] = Convert.ToInt32(score[7]);
                    break;
                case "GEND":
                    EndStatus = Encoding.Default.GetString(data);
                    break;
                case "GMAP":
                    MapName = Encoding.Default.GetString(data);
                    break;
                case "GSET":
                    string[] gameSettings = Encoding.Default.GetString(data).Split(' ');
                    Worms = Convert.ToInt32(gameSettings[1]);
                    Crates = gameSettings[3] == "1";
                    StartingCredits = Convert.ToUInt32(gameSettings[5]);
                    TechLevel = Convert.ToInt32(gameSettings[7]);
                    break;
                case "PL_0":
                case "PL_1":
                case "PL_2":
                case "PL_3":
                case "PL_4":
                case "PL_5":
                case "PL_6":
                case "PL_7":
                    PlayerCount++;
                    string[] playerSettings = Encoding.Default.GetString(data).Split('/');
                    house = Convert.ToByte(id[id.Length - 1].ToString());
                    Names[house] = playerSettings[0];
                    Sides[house] = playerSettings[1];
                    Colors[house] = NumberToColor(playerSettings[2]);
                    Handicaps[house] = Convert.ToInt32(playerSettings[3]) + 1;
                    break;
                case "SDFX":
                    SuddenDisconnect = data[0] == 1;
                    break;
                case "TRNY":
                    TournamentGame = data[0] == 1;
                    break;
                case "GMID":
                    GameId = BitConverter.ToUInt32(Reverse(data), 0);
                    break;
                case "TICK":
                    GameTicks = BitConverter.ToUInt32(Reverse(data), 0);
                    break;
                case "UNIT":
                    UnitCount = BitConverter.ToUInt32(Reverse(data), 0);
                    break;
                case "UNB0":
                case "UNB1":
                case "UNB2":
                case "UNB3":
                case "UNB4":
                case "UNB5":
                case "UNB6":
                case "UNB7":
                    house = Convert.ToByte(id[id.Length - 1].ToString());
                    SaveUnitsOwned(house, data);
                    break;
                case "BLB0":
                case "BLB1":
                case "BLB2":
                case "BLB3":
                case "BLB4":
                case "BLB5":
                case "BLB6":
                case "BLB7":
                    house = Convert.ToByte(id[id.Length - 1].ToString());
                    SaveBuildingsOwned(house, data);
                    break;
                case "CRD0":
                case "CRD1":
                case "CRD2":
                case "CRD3":
                case "CRD4":
                case "CRD5":
                case "CRD6":
                case "CRD7":
                    house = Convert.ToByte(id[id.Length - 1].ToString());
                    Credits[house] = BitConverter.ToInt32(Reverse(data), 0);
                    break;
            }
        }

        private void SaveUnitsOwned(int house, byte[] data)
        {
            using (var memoryStream = new MemoryStream(data))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                LightInfantryOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                TrooperOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                EngineerOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                ThumperInfantryOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SardaukarOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                TrikeOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RaiderOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                QuadOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HarvesterOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                CombatTankAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                CombatTankHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                CombatTankOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                CombatTankAllOwned[house] = CombatTankAtreidesOwned[house] + CombatTankHarkonnenOwned[house] + CombatTankOrdosOwned[house];
                MCVOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                MissileTankOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                DeviatorOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SiegeTankOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SonicTankOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                DevastatorOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                CarryallOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                Carryall2Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                OrnithopterOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                StealthFremenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                FremenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SaboteurOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                DeathHandRocketOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SandwormOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                ChoamFrigateOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                GrenadierOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                StealthRaiderOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SardaukarMPOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);

                InfantryOwned[house] = LightInfantryOwned[house] + TrooperOwned[house] + EngineerOwned[house] + ThumperInfantryOwned[house] +
                    SardaukarOwned[house] + StealthFremenOwned[house] + FremenOwned[house] + SaboteurOwned[house] +
                    SandwormOwned[house] + GrenadierOwned[house] + SardaukarMPOwned[house];

                HeavyVehiclesOwned[house] = HarvesterOwned[house] + CombatTankAtreidesOwned[house] + CombatTankHarkonnenOwned[house] +
                    CombatTankOrdosOwned[house] + MCVOwned[house] + MissileTankOwned[house] + DeviatorOwned[house] + SiegeTankOwned[house] +
                    SonicTankOwned[house] + DevastatorOwned[house];

                LightVehiclesOwned[house] = TrikeOwned[house] + RaiderOwned[house] + QuadOwned[house] + StealthRaiderOwned[house];

                AirUnitsOwned[house] = DeathHandRocketOwned[house] + ChoamFrigateOwned[house] + CarryallOwned[house] + Carryall2Owned[house] +
                    OrnithopterOwned[house];
            }
        }

        private void SaveBuildingsOwned(int house, byte[] data)
        {
            using (var memoryStream = new MemoryStream(data))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                ConstructionYardAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //id 0
                ConstructionYardHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //id 1 ...
                ConstructionYardOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                ConstructionYardUnknown1Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //black
                Unknown1Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //Building type is concrete - display.cpp
                Unknown2Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //Building type is concrete - display.cpp
                Unknown3Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //Building type is concrete - display.cpp
                Unknown4Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //Building type is concrete - display.cpp
                Unknown5Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //Building type is concrete - display.cpp
                ConstructionYardUnknown2Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //white
                ConstructionYardAllOwned[house] = ConstructionYardAtreidesOwned[house] + ConstructionYardHarkonnenOwned[house] +
                    ConstructionYardOrdosOwned[house] + ConstructionYardUnknown1Owned[house] + ConstructionYardUnknown2Owned[house];
                WindTrapAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                WindTrapHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                WindTrapOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                WindTrapAllOwned[house] = WindTrapAtreidesOwned[house] + WindTrapHarkonnenOwned[house] + WindTrapOrdosOwned[house];
                BarracksAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                BarracksHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                BarracksOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                BarracksAllOwned[house] = BarracksAtreidesOwned[house] + BarracksHarkonnenOwned[house] + BarracksOrdosOwned[house];
                SietchOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                WallAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                WallHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                WallOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                WallAllOwned[house] = WallAtreidesOwned[house] + WallHarkonnenOwned[house] + WallOrdosOwned[house];
                RefineryAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RefineryHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RefineryOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RefineryAllOwned[house] = RefineryAtreidesOwned[house] + RefineryHarkonnenOwned[house] + RefineryOrdosOwned[house];
                GunTurretAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                GunTurretHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                GunTurretOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                GunTurretAllOwned[house] = GunTurretAtreidesOwned[house] + GunTurretHarkonnenOwned[house] + GunTurretOrdosOwned[house];
                OutpostAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                OutpostHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                OutpostOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                OutpostAllOwned[house] = OutpostAtreidesOwned[house] + OutpostHarkonnenOwned[house] + OutpostOrdosOwned[house];
                RocketTurretAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RocketTurretHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RocketTurretOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RocketTurretAllOwned[house] = RocketTurretAtreidesOwned[house] + RocketTurretHarkonnenOwned[house] + 
                    RocketTurretOrdosOwned[house];
                HighTechFactoryAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HighTechFactoryHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HighTechFactoryOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HighTechFactoryAllOwned[house] = HighTechFactoryAtreidesOwned[house] + HighTechFactoryHarkonnenOwned[house] + 
                    HighTechFactoryOrdosOwned[house];
                LightFactoryAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                LightFactoryHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                LightFactoryOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                LightFactoryAllOwned[house] = LightFactoryAtreidesOwned[house] + LightFactoryHarkonnenOwned[house] + 
                    LightFactoryOrdosOwned[house];
                SiloAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SiloHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SiloOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                SiloAllOwned[house] = SiloAtreidesOwned[house] + SiloHarkonnenOwned[house] + SiloOrdosOwned[house];
                HeavyFactoryAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HeavyFactoryHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HeavyFactoryOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HeavyFactoryUnknown1Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //gold
                HeavyFactoryUnknown2Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //black
                HeavyFactoryAllOwned[house] = HeavyFactoryAtreidesOwned[house] + HeavyFactoryHarkonnenOwned[house] +
                    HeavyFactoryOrdosOwned[house] + HeavyFactoryUnknown1Owned[house] + HeavyFactoryUnknown2Owned[house];
                StarportAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                StarportHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                StarportOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                StarportUnknownOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //gold
                StarportAllOwned[house] = StarportAtreidesOwned[house] + StarportHarkonnenOwned[house] +
                    StarportOrdosOwned[house] + StarportUnknownOwned[house];
                RepairPadAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RepairPadHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RepairPadOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                RepairPadAllOwned[house] = RepairPadAtreidesOwned[house] + RepairPadHarkonnenOwned[house] + RepairPadOrdosOwned[house];
                IXResearchCenterAtreidesOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                IXResearchCenterHarkonnenOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                IXResearchCenterOrdosOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                IXResearchCenterAllOwned[house] = IXResearchCenterAtreidesOwned[house] + IXResearchCenterHarkonnenOwned[house] +
                    IXResearchCenterOrdosOwned[house];
                AtreidesPalaceOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                HarkonnenPalaceOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                OrdosPalaceOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                EmperorsPalaceOwned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0); //60
                ModifiedOutpost1Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                ModifiedOutpost2Owned[house] = BitConverter.ToInt32(Reverse(binaryReader.ReadBytes(4)), 0);
                ModifiedOutpostAllOwned[house] = ModifiedOutpost1Owned[house] + ModifiedOutpost2Owned[house];
            }
        }

        private byte[] Reverse(byte[] bytes)
        {
            Array.Reverse(bytes);
            return bytes;
        }

        private string NumberToColor(string number)
        {
            switch (number)
            {
                case "0": return "Blue";
                case "1": return "Red";
                case "2": return "Teal";
                case "3": return "Purple";
                case "4": return "Gray";
                case "5": return "Brown";
                case "6": return "Gold";
                case "7": return "LightBrown";
                default: return number;
            }
        }

    }
}
