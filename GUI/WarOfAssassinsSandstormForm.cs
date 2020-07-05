using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MissionLauncher.GUI
{
    public partial class WarOfAssassinsSandstormForm : Form
    {
        private string CurrentHouse = "A";
        private string Intro = "The outcome of the past battles resulted in heavy casualties on all sides. The three main Houses suffered the most, as they have fought each other before the Emperor betrayed them all and joined the war. Now they must recover and strike hard, fight for their very survival. The Emperor represents a threat not only for their Arrakis campaign, but for their homeworlds too. However, the Emperor doesn't seem to be alone in this whole thing. The ease he transported so many forces so fast, the constant shipments he receives, not even the Golden Lion Throne can fund so many activities. Could the Emperor not be alone? Could he have a hidden ally? You are about to find out..." + Environment.NewLine +
                     "The sandstorm campaign was created by Feda. It is HIGHLY recommended to play ALL War of Assassins campaigns before starting the Sandstorm missions, as these missions are the sequel to the War of Assassins ones. You must also make sure that TILEDATA.BIN is copied into your Dune2000/Data/bin folder. The file can be obtained from the New Map and Mission Editor(1.2), or from Feda's download link on FED2K, or from the mission launcher files." + Environment.NewLine +
                     "In case you dont have it, here's a direct link for the file: http://www.mediafire.com/download/w96l84k8n32pxew/TILEDATA.BIN";
           
        private string Ending = "With Emperor Shaddam IV of House Corrino dead, the mighty Sardaukars have surrendered, as with no emperor, they serve no purpose. The Spacing Guild has been left without allies, and has retreated to remote areas of Arrakis. Surprisingly enough, they did not flee completely. However, the Guild frigates and transports ceased, and most Guild Starports have been destroyed by the Arrakis Landsraad Coalition soon after the fall of the Emperor. Without an Emperor the empire is pretty unstable, and the Landsraad council is forced to create a small coalition of strong Houses that can make order until a new emperor will be chosen." + Environment.NewLine +
                     "The three Great Houses have now full control over Arrakis, and are hunting down the rest of the Guild forces still scattered around the planet. For now, the war is over, and all three Houses have declared peace for an indefinite amount of time, possibly until they manage to recover from the very costly war. The Smugglers became extremely busy, as their frigates have been hired by the Houses to transport forces on route homeworld-Arrakis. The Spacing Guild has been sued for its actions against the Landsraad. Now that the Emperor is dead, they no longer have a strong ally to protect them against the Landsraad. Guild's plan on Arrakis is still unknown though; no one knows why they were aiding the Emperor. "+ Environment.NewLine +
                     "It could be said that, literally, the winners of the Great Spice War and the Sandstorm crisis are the three main Houses, Atreides, Harkonnen and Ordos, who started out as the main opponents.";

        public WarOfAssassinsSandstormForm()
        {
            this.Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height * 96 / 100); //hide the tabs (temporary)
            IntroOutroRichTextBox.Text = Intro;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void WarOfAssassinsSandstormForm_Load(object sender, EventArgs e)
        {
            OKLabel.Text = Missions.TextUib.GetValue("OK", "Ok");
            BackToCampaignSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            StartGameLabel.Text = Missions.TextUib.GetValue("StartGame", "Start");
            BackToMissionSelectionLabel.Text = Missions.TextUib.GetValue("Back", "Back");
            DifficultyLevelLabel.Text = Missions.TextUib.GetValue("EnterDifficulty", "Enter Difficulty Level");
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Easy", "Easy"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Normal", "Normal"));
            DifficultyLevelComboBox.Items.Add(Missions.TextUib.GetValue("Hard", "Hard"));
            DifficultyLevelComboBox.SelectedIndex = 1;
        }

        private void FillMissionListBox()
        {
            MissionListBox.Items.Clear();
            for (int i = 1; i < 8; i++) MissionListBox.Items.Add(Missions.GetMission(string.Format("SS_{0}{1}", CurrentHouse, i)).Name);
            MissionListBox.SelectedIndex = 0;
        }

        private void tTabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void ShowBriefingTab(Mission mission)
        {
            Missions.CurrentMission = mission;
            BriefingRichTextBox.Text = mission.Briefing;
            BriefingRichTextBox.ForeColor = BriefingRichTextBox.ForeColor;
            tTabControl1.SelectTab("BriefingTab");
        }

        private void BackToMissionSelectionLabel_Click(object sender, EventArgs e)
        {
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void StartGameLabel_Click(object sender, EventArgs e)
        {
            Missions.StartMission(DifficultyLevelComboBox.SelectedIndex);
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void BriefingRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void AtreidesCampaignLabel_Click(object sender, EventArgs e)
        {
            CurrentHouse = "A";
            FillMissionListBox();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void HarkonnenCampaignLabel_Click(object sender, EventArgs e)
        {
            CurrentHouse = "H";
            FillMissionListBox();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void OrdosCampaignLabel_Click(object sender, EventArgs e)
        {
            CurrentHouse = "O";
            FillMissionListBox();
            tTabControl1.SelectTab("MissionSelectionTab");
        }

        private void OKLabel_Click(object sender, EventArgs e)
        {
            ShowBriefingTab(Missions.GetMission(string.Format("SS_{0}{1}", CurrentHouse, MissionListBox.SelectedIndex + 1)));
        }

        private void BackToCampaignSelectionLabel_Click(object sender, EventArgs e)
        {
            tTabControl1.SelectTab("CampaignSelectionTab");
        }

        private void IntroOutroLabel_Click(object sender, EventArgs e)
        {
            if (IntroOutroLabel.Text == "Ending")
            {
                IntroOutroLabel.Text = "Intro";
                IntroOutroRichTextBox.Text = Ending;
                }
            else
            {
                IntroOutroLabel.Text = "Ending";
                IntroOutroRichTextBox.Text = Intro;
            }
        }

        private void BackLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
