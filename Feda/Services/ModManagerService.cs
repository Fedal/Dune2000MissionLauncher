using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MissionLauncher.Feda.Services
{
    public static class ModManagerService
    {
        #region Fields



        #endregion

        #region Properties

        public static Campaign CurrentCampaign = Campaign.AllMissions;

        #endregion

        #region Public Methods

        public static void BackupGameFiles()
        {
            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (var filePath in BackupFiles.FilesToBackup)
            {
                var completeFileName = Path.Combine(Program.Path, filePath);
                
                var backedUpFilePath = completeFileName + ".bak";
                if (File.Exists(backedUpFilePath))
                    continue;

                if (!File.Exists(completeFileName))
                    continue;

                try
                {
                    File.Copy(completeFileName, backedUpFilePath);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public static void RestoreGameFiles()
        {
            var workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            foreach(var filePath in BackupFiles.FilesToBackup)
            {
                var completeFileName = Path.Combine(Program.Path, filePath);
                var backedUpFilePath = completeFileName + ".bak";
                try
                {
                    File.Copy(backedUpFilePath, completeFileName, true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public static void CopyDirectoryWithContents(string sourcePath, string destinationPath)
        {


            var dirSource = new DirectoryInfo(sourcePath);
            var dirTarget = new DirectoryInfo(destinationPath);

            CopyAll(dirSource, dirTarget);
        }

        #endregion

        #region Private Methods

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

        private static void GetModFilePath()
        {
            
        }

        #endregion


    }
}
