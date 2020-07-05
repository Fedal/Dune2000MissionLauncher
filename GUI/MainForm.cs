using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.IO;
using System.Reflection;
using MissionLauncher.Feda.Services;

namespace MissionLauncher.GUI
{
    public partial class MainForm : Form
    {
        string statsDmpPath = Path.Combine(Program.Path, "stats.dmp");

        public MainForm()
        {
            this.Icon = Properties.Resources.Dune2000Icon;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(statsDmpPath)) File.Delete(statsDmpPath);
            var statsThread = new Thread(new ThreadStart(ShowStats));
            statsThread.IsBackground = true;
            statsThread.CurrentCulture = new CultureInfo("en-US");
            statsThread.CurrentUICulture = new CultureInfo("en-US");
            statsThread.Start();

            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var customCampaignFolderPath = Path.Combine(workingDirectory, "CustomCampaignData");
            Directory.CreateDirectory(customCampaignFolderPath);

            ModManagerService.BackupGameFiles();
        }

        private void ShowStats()
        {
            while (true)
            {
                Thread.Sleep(3000);
                if (File.Exists(statsDmpPath))
                {
                    this.Invoke((MethodInvoker)delegate()
                    {
                        if (Program.SettingsIni.GetBoolValue("Settings", "ShowScoreScreen", true))
                        {
                            var statsDump = new Dune2000StatsDump(statsDmpPath);
                            new Dune2000ScoreScreen(statsDump).Show();
                        }
                        File.Delete(statsDmpPath);
                    });
                }
            }
        }

        private void AllMissionsPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new AllMissionsForm()) form.ShowDialog();
            this.Show();
        }

        private void RiseOfTheMercenariesPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new RiseOfTheMercenariesForm()) form.ShowDialog();
            this.Show();
        }

        private void WarOfAssassinsPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new WarOfAssassinsForm()) form.ShowDialog();
            this.Show();
        }

        private void WarOfAssassinsSandstormPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new WarOfAssassinsSandstormForm()) form.ShowDialog();
            this.Show();
        }

        private void WarOfTheLandsraadPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new WarOfTheLandsraadForm()) form.ShowDialog();
            this.Show();
        }
    }
}
