using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MissionLauncher
{
    public partial class Dune2000ScoreScreen : Form
    {
        Dune2000StatsDump StatsDump;

        public Dune2000ScoreScreen(Dune2000StatsDump statsDump)
        {
            this.Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
            StatsDump = statsDump;
        }

        private void Dune2000ScoreScreen_Load(object sender, EventArgs e)
        {
            Text = string.Format("Game Duration: {0} | {1} | {2} | {3}", 
                StatsDump.GameDuration, StatsDump.MapName, StatsDump.EndStatus, StatsDump.GameTicks);

            foreach (DataGridViewColumn column in dataGridView1.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Rows.Clear();

            AddRow("Credits", new List<int>(StatsDump.Credits).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Finishing Place", new List<int>(StatsDump.FinishingPlaces).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Money Harvested", new List<int>(StatsDump.SpiceHarvested).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Buildings Destroyed", new List<int>(StatsDump.BuildingsDestroyed).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Buildings Lost", new List<int>(StatsDump.BuildingsLost).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Units Killed", new List<int>(StatsDump.UnitsKilled).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Units Lost", new List<int>(StatsDump.UnitsLost).ConvertAll(i => i.ToString()).ToArray());

            AddRow("Buildings Owned", new List<int>(StatsDump.BuildingsOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Infantry Owned", new List<int>(StatsDump.InfantryOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Heavy Vehicles Owned", new List<int>(StatsDump.HeavyVehiclesOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Light Vehicles Owned", new List<int>(StatsDump.LightVehiclesOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Air Units Owned", new List<int>(StatsDump.AirUnitsOwned).ConvertAll(i => i.ToString()).ToArray());

            var score = new Dune2000Score(StatsDump);
            AddRow("Infantry Prod. Efficiency", new List<double>(score.InfantryProductionEfficiency).ConvertAll(i => i.ToString("0.00") + "%").ToArray());
            AddRow("Heavy Vehicles Prod. Efficiency", new List<double>(score.HeavyVehiclesProductionEfficiency).ConvertAll(i => i.ToString("0.00") + "%").ToArray());
            AddRow("Light Vehicles Prod. Efficiency", new List<double>(score.LightVehiclesProductionEfficiency).ConvertAll(i => i.ToString("0.00") + "%").ToArray());
            AddRow("Total Prod. Efficiency", new List<double>(score.TotalProductionEfficiency).ConvertAll(i => i.ToString("0.00") + "%").ToArray());

            for (int i = StatsDump.PlayerCount; i < dataGridView1.Rows[0].Cells.Count; i++)
                for (int x = 0; x < dataGridView1.Rows.Count; x++)
                    dataGridView1.Rows[x].Cells[i].Value = null;

            dataGridView1.CurrentCell = null;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            ViewDetailsButton.Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            AddRow("LightInfantry Owned", new List<int>(StatsDump.LightInfantryOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Trooper Owned", new List<int>(StatsDump.TrooperOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Engineer Owned", new List<int>(StatsDump.EngineerOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("ThumperInfantry Owned", new List<int>(StatsDump.ThumperInfantryOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Sardaukar Owned", new List<int>(StatsDump.SardaukarOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("StealthFremen Owned", new List<int>(StatsDump.StealthFremenOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Fremen Owned", new List<int>(StatsDump.FremenOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Saboteur Owned", new List<int>(StatsDump.SaboteurOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("SardaukarMP Owned", new List<int>(StatsDump.SardaukarMPOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Grenadier Owned", new List<int>(StatsDump.GrenadierOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Sandworm Owned", new List<int>(StatsDump.SandwormOwned).ConvertAll(i => i.ToString()).ToArray());

            AddRow("Trike Owned", new List<int>(StatsDump.TrikeOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Raider Owned", new List<int>(StatsDump.RaiderOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Quad Owned", new List<int>(StatsDump.QuadOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("StealthRaider Owned", new List<int>(StatsDump.StealthRaiderOwned).ConvertAll(i => i.ToString()).ToArray());

            AddRow("Harvester Owned", new List<int>(StatsDump.HarvesterOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("CombatTank Owned", new List<int>(StatsDump.CombatTankAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("MCV Owned", new List<int>(StatsDump.MCVOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("MissileTank Owned", new List<int>(StatsDump.MissileTankOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Deviator Owned", new List<int>(StatsDump.DeviatorOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("SiegeTank Owned", new List<int>(StatsDump.SiegeTankOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("SonicTank Owned", new List<int>(StatsDump.SonicTankOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Devastator Owned", new List<int>(StatsDump.DevastatorOwned).ConvertAll(i => i.ToString()).ToArray());

            AddRow("Carryall Owned", new List<int>(StatsDump.CarryallOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Carryall2 Owned", new List<int>(StatsDump.Carryall2Owned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Ornithopter Owned", new List<int>(StatsDump.OrnithopterOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("DeathHandRocket Owned", new List<int>(StatsDump.DeathHandRocketOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("ChoamFrigate Owned", new List<int>(StatsDump.ChoamFrigateOwned).ConvertAll(i => i.ToString()).ToArray());

            AddRow("ConstructionYard Owned", new List<int>(StatsDump.ConstructionYardAllOwned).ConvertAll(i => i.ToString()).ToArray()); //id 0
            //AddRow("Unknown1 Owned", new List<int>(statsDump.Unknown1Owned).ConvertAll(i => i.ToString()).ToArray()); //Building type is concrete - display.cpp
            //AddRow("Unknown2 Owned", new List<int>(statsDump.Unknown2Owned).ConvertAll(i => i.ToString()).ToArray()); //Building type is concrete - display.cpp
            //AddRow("Unknown3 Owned", new List<int>(statsDump.Unknown3Owned).ConvertAll(i => i.ToString()).ToArray()); //Building type is concrete - display.cpp
            //AddRow("Unknown4 Owned", new List<int>(statsDump.Unknown4Owned).ConvertAll(i => i.ToString()).ToArray()); //Building type is concrete - display.cpp
            //AddRow("Unknown5 Owned", new List<int>(statsDump.Unknown5Owned).ConvertAll(i => i.ToString()).ToArray()); //Building type is concrete - display.cpp
            AddRow("WindTrap Owned", new List<int>(StatsDump.WindTrapAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Barracks Owned", new List<int>(StatsDump.BarracksAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Sietch Owned", new List<int>(StatsDump.SietchOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Wall Owned", new List<int>(StatsDump.WallAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Refinery Owned", new List<int>(StatsDump.RefineryAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("GunTurret Owned", new List<int>(StatsDump.GunTurretAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Outpost Owned", new List<int>(StatsDump.OutpostAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("RocketTurret Owned", new List<int>(StatsDump.RocketTurretAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("HighTechFactory Owned", new List<int>(StatsDump.HighTechFactoryAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("LightFactory Owned", new List<int>(StatsDump.LightFactoryAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("Silo Owned", new List<int>(StatsDump.SiloAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("HeavyFactory Owned", new List<int>(StatsDump.HeavyFactoryAllOwned).ConvertAll(i => i.ToString()).ToArray()); //black
            AddRow("Starport Owned", new List<int>(StatsDump.StarportAllOwned).ConvertAll(i => i.ToString()).ToArray()); //gold
            AddRow("RepairPad Owned", new List<int>(StatsDump.RepairPadAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("IXResearchCenter Owned", new List<int>(StatsDump.IXResearchCenterAllOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("AtreidesPalace Owned", new List<int>(StatsDump.AtreidesPalaceOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("HarkonnenPalace Owned", new List<int>(StatsDump.HarkonnenPalaceOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("OrdosPalace Owned", new List<int>(StatsDump.OrdosPalaceOwned).ConvertAll(i => i.ToString()).ToArray());
            AddRow("EmperorsPalace Owned", new List<int>(StatsDump.EmperorsPalaceOwned).ConvertAll(i => i.ToString()).ToArray()); //60
            AddRow("ModifiedOutpost Owned", new List<int>(StatsDump.ModifiedOutpostAllOwned).ConvertAll(i => i.ToString()).ToArray());

            for (int i = StatsDump.PlayerCount; i < dataGridView1.Rows[0].Cells.Count; i++)
                for (int x = 0; x < dataGridView1.Rows.Count; x++)
                    dataGridView1.Rows[x].Cells[i].Value = null;

            dataGridView1.CurrentCell = null;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AddRow(string headerCellValue, params object[] values)
        {
            dataGridView1.Rows.Add(values);
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].HeaderCell.Value = headerCellValue;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (DontShowAgainCheckBox.Checked)
            {
                Program.SettingsIni.SetBoolValue("Settings", "ShowScoreScreen", false);
                Program.SettingsIni.WriteIni();
            }
            this.Close();
        }
    }
}
