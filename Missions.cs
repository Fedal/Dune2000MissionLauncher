using System;
using System.Collections.Generic;
using System.Text;
using FunkyFr3sh.Dune2000;
using Nyerguds.Ini;
using FunkyFr3sh;
using System.Diagnostics;
using System.IO;
using MissionLauncher.Feda.Services;

namespace MissionLauncher
{
    public struct Mission
    {
        public string FileName;
        public string Briefing;
        public string Name;
        public int SideId;
        public int Number;
        public string TextUib;
        public string CampaignFolder;
        public string ModsFolder;
        public string ColorsFile;
        public string IntelId;

        public Mission(string fileName, string briefing, string name, int sideId, int number, string textUib, string campaignFolder, string colorsFile, string modsFolder, string intelId)
        {
            FileName = fileName;
            SideId = sideId;
            Name = name;
            Briefing = briefing;
            Number = number;
            TextUib = textUib;
            CampaignFolder = campaignFolder;
            ModsFolder = modsFolder;
            ColorsFile = colorsFile;
            IntelId = intelId;
        }
    }

    public static class Missions
    {
        public static List<Mission> AtreidesMissions = new List<Mission>();
        public static List<Mission> HarkonnenMissions = new List<Mission>();
        public static List<Mission> OrdosMissions = new List<Mission>();
        public static List<Mission> EmperorMissions = new List<Mission>();
        public static List<Mission> FremenMissions = new List<Mission>();
        public static List<Mission> SmugglersMissions = new List<Mission>();
        public static List<Mission> MercenariesMissions = new List<Mission>();
        public static Mission CurrentMission;
        public static string CurrentCampaignFolder;
        public static string CurrentModsFolder;
        public static string CurrentColorsFile;
        public static string CurrentIntelId;
        public static UibFile TextUib;
        public static string MissionPath;

        public static void StartMission(int difficultyLevel)
        {
            StartMission(difficultyLevel, CurrentMission);
            CampaignManagerService.RestoreFiles();
            CampaignManagerService.RestoreColors();
        }

        public static void StartMission(int difficultyLevel, Mission mission)
        {
            if (!string.IsNullOrWhiteSpace(CurrentCampaignFolder) && !string.IsNullOrWhiteSpace(CurrentModsFolder))
            {
                CampaignManagerService.InstallMods(CurrentCampaignFolder, CurrentModsFolder);
            }

            if (!string.IsNullOrEmpty(CurrentColorsFile))
            {
                CampaignManagerService.InstallColors(CurrentColorsFile, CurrentCampaignFolder);
            }

            string spawnIniPath = Utils.PathCombine(Program.Path, "spawn.ini");
            if (File.Exists(spawnIniPath)) File.Delete(spawnIniPath);
            var spawnIni = new IniFile(spawnIniPath);
            spawnIni.SetStringValue("Settings", "Scenario", mission.FileName);
            spawnIni.SetIntValue("Settings", "MySideID", mission.SideId);
            spawnIni.SetIntValue("Settings", "MissionNumber", mission.Number);
            spawnIni.SetIntValue("Settings", "DifficultyLevel", difficultyLevel);
            spawnIni.SetIntValue("Settings", "Seed", new Random().Next(int.MaxValue));
            if (mission.TextUib.Length > 0) spawnIni.SetStringValue("Settings", "TextUib", mission.TextUib);
            spawnIni.WriteIni();

            var psi = new ProcessStartInfo(Utils.PathCombine(Program.Path, "dune2000.exe"));
            psi.WorkingDirectory = Program.Path;
            psi.Arguments = "-SPAWN";
            if (Environment.OSVersion.Version >= new Version(6, 2, 9200, 0))
            {
                psi.EnvironmentVariables["__COMPAT_LAYER"] += "DWM8And16BitMitigation 16BITCOLOR ";
                psi.UseShellExecute = false;
            }
            Process.Start(psi)?.WaitForExit();
        }

        public static Mission GetMission(string fileName)
        {
            foreach (var mission in Missions.AtreidesMissions)
                if (mission.FileName.ToLower() == fileName.ToLower()) return mission;
            foreach (var mission in Missions.HarkonnenMissions)
                if (mission.FileName.ToLower() == fileName.ToLower()) return mission;
            foreach (var mission in Missions.OrdosMissions)
                if (mission.FileName.ToLower() == fileName.ToLower()) return mission;
            foreach (var mission in Missions.EmperorMissions)
                if (mission.FileName.ToLower() == fileName.ToLower()) return mission;
            foreach (var mission in Missions.FremenMissions)
                if (mission.FileName.ToLower() == fileName.ToLower()) return mission;
            foreach (var mission in Missions.SmugglersMissions)
                if (mission.FileName.ToLower() == fileName.ToLower()) return mission;
            foreach (var mission in Missions.MercenariesMissions) 
                if (mission.FileName.ToLower() == fileName.ToLower()) return mission;

            throw new Exception(string.Format("Mission '{0}' not found.", fileName));
        }

        public static void Load()
        {
            
            if (TextUib != null) return;
            string resourceCfgPath = Path.Combine(Program.Path, "RESOURCE.CFG");
            var resourceCfg = File.ReadAllLines(resourceCfgPath);
            MissionPath = Path.Combine(Program.Path, resourceCfg[3]);
            string language = new IniFile(Utils.PathCombine(Program.Path, "dune2000.ini")).GetStringValue("Options", "Language", "");
            TextUib = new UibFile(Utils.PathCombine(Program.Path, "data", "UI_DATA", string.Format("text{0}.uib", language)));
            var iniFiles = Directory.GetFiles(MissionPath, "*.ini", SearchOption.TopDirectoryOnly);

            if (iniFiles != null)
                foreach (string iniFile in iniFiles)
                {
                    var mapIni = new IniFile(iniFile);
                    var mission = new Mission();
                    mission.SideId = mapIni.GetIntValue("Basic", "SideId", -1);
                    if (mission.SideId == -1) continue;

                    mission.FileName = Path.GetFileNameWithoutExtension(iniFile);
                    mission.TextUib = mapIni.GetStringValue("Basic", "TextUib", "");
                    mission.Briefing = mapIni.GetStringValue("Basic", "Briefing", "").Replace("_", Environment.NewLine);
                    if (mission.Briefing == "")
                    {
                        string briefingKey = mapIni.GetStringValue("Basic", "TextUibBriefingKey", "ääü+");
                        if (mission.TextUib.Length == 0) mission.Briefing = TextUib.GetValue(briefingKey, "No Briefing...");
                        else mission.Briefing = new UibFile(Utils.PathCombine(Program.Path, "data", "UI_DATA", mission.TextUib)).GetValue(briefingKey, "No Briefing...");
                        mission.Briefing = mission.Briefing.Replace("¬", Environment.NewLine);
                    }
                    mission.Name = mapIni.GetStringValue("Basic", "Name", mission.FileName);
                    mission.Number = mapIni.GetIntValue("Basic", "MissionNumber", 0);
                    mission.CampaignFolder = mapIni.GetStringValue("Data", "CampaignFolder", "");
                    mission.ModsFolder = mapIni.GetStringValue("Data", "ModsFolder", "");
                    mission.ColorsFile = mapIni.GetStringValue("Data", "ColoursFile", "");
                    mission.IntelId = mapIni.GetStringValue("Data", "IntelId", "");
                    switch (mission.SideId)
                    {
                        case 0: AtreidesMissions.Add(mission); break;
                        case 1: HarkonnenMissions.Add(mission); break;
                        case 2: OrdosMissions.Add(mission); break;
                        case 3: EmperorMissions.Add(mission); break;
                        case 4: FremenMissions.Add(mission); break;
                        case 5: SmugglersMissions.Add(mission); break;
                        case 6: MercenariesMissions.Add(mission); break;
                        default: break;
                    }
                }
        }
    }
}
