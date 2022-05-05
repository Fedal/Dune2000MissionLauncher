using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Media;
using MissionLauncher.Feda.Services;
using MissionLauncher.Feda;

namespace MissionLauncher.GUI
{
    public partial class WarOfAssassinsForm : Form
    {
        private string CurrentHouse = "A";

        public WarOfAssassinsForm()
        {
            this.Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height * 96 / 100); //hide the tabs (temporary)

            FormClosing += WarOfAssassinsForm_FormClosing;

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

        private void WarOfAssassinsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModManagerService.RestoreGameFiles();
        }

        private void WarOfAssassinsForm_Load(object sender, EventArgs e)
        {
            var campaignManagerService = new CampaignManagerService();

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
            for (int i = 1; i < 10; i++) MissionListBox.Items.Add(Missions.GetMission(string.Format("D2K_{0}{1}", CurrentHouse, i)).Name);
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
            ShowBriefingTab(Missions.GetMission(string.Format("D2K_{0}{1}", CurrentHouse, MissionListBox.SelectedIndex + 1)));
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
                IntroOutroRichTextBox.Text = string.Format("The Great Spice War caused unimaginable casualties for all sides involved. The Imperial armies have been severely damaged after the conflicts. The 3 great Houses are even in greater trouble: none of them are able to request any more reinforcements from their homeplanets. House Atreides held the lines close to the Shield Wall, and the Sardaukars seemed to be unable to pass through and were forced to retreat. While this allows the Atreides to continue the war, they will need significant time to recover from all the casualties. House Harkonnen successfully stopped the Imperial attacks on Red Chasm. With this defeat, the Sardaukars were forced to retreat back to the Imperial Basin. House Ordos managed to drive out the Imperial troops from Jacarutu. Even that the war did not end, no faction is able to initiate any more offensive actions. All of them need time to recover from the past events. But after a while... the war will surely resume! The story will be continued in the Sandstorm expansion pack which will be released after the main campaigns. The expansion will feature even more twists and even new sides which did not participate in the war before, along with an ending to the Great Spice War. Stay tuned Commander.");
            }
            else
            {
                IntroOutroLabel.Text = "Ending";
                IntroOutroRichTextBox.Text = string.Format("Arrakis... Also known as Dune. The source of spice melange. Spice is a powerful substance. It can modify human processes, can enhance visions, increase intelligence levels. Spice is also the most important economical resource in the Landsraad and the entire empire. The Emperor of House Corrino has always shown his high interest in this substance. He decided to create a 'war of assassins' between 3 powerful Houses: the noble Atreides, the evil Harkonnen and the insidious Ordos. House Atreides is loyal to the Duke, and fight and always will with honor. Their advantages rely in their aircraft and their men's loyalty to the Duke. The Harkonnen are loyal to the Baron, a man with a frightening pleasure towards torture and blood. Although without mercy, he is smart enough to rule the strongest economical and military-wise House. His armies can decimate any opponent with ease. House Ordos is led by the Executrix: four minds sharing a single body, a weird-looking Ixian cyborg-like creature. Their aims and plans are unknown, but one thing is certain: they do not follow the same rules as the other Houses. What matters for Ordos is profit, in any shape it comes. There are no feelings for an Ordos, no fear, no compassion. Logic and focus are the only traits. There's no word for trust in their language.{0}As the Emperor proposed, the House which wins the Great Arrakis Spice War can establish a stable goverment on Dune and control all spice harvest activities. A great gift, as spice controls the universe. A Great Convention has been signed: no nuclear weapons shall be used in the war, and no other Landsraad Houses will be allowed to interfere. The Spacing Guild will deliver troops for any House from their homeworld to Arrakis and reversed, for the prices set by the Guild. Houses are not allowed to attack the Guild Highliners carrying enemy forces before they land on Dune and the Highliner leaves planet's orbit. Which House will prevail? That is unknown. You may select any House: the story is unique for all 3 of them, therefore the ending and twist of events will be similar. But you will witness the events of the war from 3 different perspectives, so playing all 3 campaigns will allow you to feel every single war event. CAREFULLY READ THE BRIEFINGS and follow what's in there. The story is also presented in there. In-game briefings are NOT included, so concentrate when reading the briefing in the mission selector. Good luck, Commander!{0}Dune 2000 War of Assassins by Feda", Environment.NewLine + Environment.NewLine);
            }
        }

        


    }
}
