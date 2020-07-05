using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FunkyFr3sh
{
    public static class Utils
    {
        public static string PathCombine(string path1, string path2, params string[] pathX)
        {
            string result = Path.Combine(path1, path2);
            foreach (string path in pathX) result = Path.Combine(result, path);
            return result;
        }
    }
}
