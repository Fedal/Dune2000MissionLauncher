using Nyerguds.Ini;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MissionLauncher.Feda.Services
{
    public class CampaignManagerService
    {
        private static List<string> _modifiedFiles = new List<string>();
        private static bool _colorsModified;

        public static bool IsWol;

        public static void HandleWolSpecialCase(bool isWol)
        {
            IsWol = isWol;
            if (!IsWol)
                return;

            var d2kDir = Program.Path;
            var legacyFile = Path.Combine(d2kDir, "CustomCampaignData", "WarOfTheLandsraad", "Legacy", "DUNE2000.EXE");
            var fileToBackup = Path.Combine(d2kDir, "DUNE2000.EXE");

            try
            {
                var backupFilePath = Path.Combine(d2kDir, "D2K.BACKUP");
                File.Copy(fileToBackup, backupFilePath, true);
                File.Copy(legacyFile, fileToBackup, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);


            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        public static void InstallMods(string campaignFolder, string modsFolder)
        {
            var finalPath = Path.Combine(Program.CampaignFolder, campaignFolder, modsFolder);
            ProcessDirectory(finalPath);
        }

        // Process all files in the directory passed in, recurse on any directories
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string [] fileEntries = Directory.GetFiles(targetDirectory);
            foreach(string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string [] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach(string subdirectory in subdirectoryEntries.Where(x => !x.Contains("Colours") && !x.Contains("Missions") && !x.Contains("Images") && !x.Contains("Intel")))
                ProcessDirectory(subdirectory);
        }

        public static void InstallColors(string coloursFile, string currentCampaignFolder)
        {
            var dataFolder = Program.DataFolder;
            coloursFile = Path.Combine(Program.CampaignFolder, currentCampaignFolder, "Colours", coloursFile);

            var targetFile = Path.Combine(dataFolder, "bin", "COLOURS.BIN");

            try
            {
                File.Copy(targetFile, $"{targetFile}.bak", true);
                File.Copy(coloursFile, targetFile, true);
                _colorsModified = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void RestoreColors()
        {
            if (!_colorsModified)
                return;

            var dataFolder = Program.DataFolder;
            var targetFile = Path.Combine(dataFolder, "bin", "COLOURS.BIN");
            try
            {
                File.Copy($"{targetFile}.bak", targetFile, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            _colorsModified = false;
        }

        public static void RestoreFiles()
        {
            if (!IsWol)
            {
                ProcessFilesForRestore();
                return;
            }

            IsWol = false;
            var d2kDir = Program.Path;
            var fileToBackup = Path.Combine(d2kDir, "DUNE2000.EXE");

            try
            {
                var backupFilePath = Path.Combine(d2kDir, "D2K.BACKUP");
                File.Copy(backupFilePath, fileToBackup, true);
                File.Delete(backupFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            ProcessFilesForRestore();
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            FileInfo fi = new FileInfo(path);

            if (fi.Extension.Equals(".exe", StringComparison.InvariantCultureIgnoreCase) ||
                fi.Extension.Equals(".dat", StringComparison.InvariantCultureIgnoreCase))
                return;

            if (fi.Name.Equals("COLOURS.BIN"))
                return;

            var relativePath = path.Replace(Path.Combine(Program.CampaignFolder, Missions.CurrentCampaignFolder, Missions.CurrentModsFolder), "").Remove(0,1);
            var targetPath = Path.Combine(Program.Path, relativePath);

            if (!File.Exists(targetPath))
            {
                try
                {
                    File.Copy(path, targetPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return;
            }

            try
            {
                File.Copy(targetPath, $"{targetPath}.bak", true);
                CreateSecondaryBackups(targetPath);
                File.Copy(path, targetPath, true);
                _modifiedFiles.Add(targetPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void ProcessFilesForRestore()
        {
            if (!_modifiedFiles.Any())
                return;

            foreach (var file in _modifiedFiles)
            {
                if (!File.Exists($"{file}.bak"))
                    continue;

                try
                {
                    File.Copy($"{file}.bak", file, true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }

            _modifiedFiles.Clear();
            ClearSecondaryBackupFolder();
        }

        private static void CreateSecondaryBackups(string path)
        {
            var safetyBackupFolder = Path.Combine(Program.Path, Constants.FileAndFolderNames.SecondaryBackupFolderName);
            var relativePath = path.Replace(Program.Path, "");
            var targetPath = Path.Combine(safetyBackupFolder, relativePath);
            var finalPath = Path.GetDirectoryName(targetPath);
            if (finalPath == null)
                return;

            FileInfo fi = new FileInfo(path);

            DirectoryInfo di = Directory.CreateDirectory(finalPath);
            var target = Path.Combine(finalPath, fi.Name);
            try
            {
                File.Copy(path, target, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void ClearSecondaryBackupFolder()
        {
            //Directory.Delete(Path.Combine(Program.Path, Constants.FileAndFolderNames.SecondaryBackupFolderName), true);
        }
    }
}
