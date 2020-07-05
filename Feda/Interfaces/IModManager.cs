using System;
using System.Collections.Generic;
using System.Text;

namespace MissionLauncher.Feda
{
    public interface IModManager
    {
        void CopyModFiles(string sourcePath, string destinationPath);
    }
}
