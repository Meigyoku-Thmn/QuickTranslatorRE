using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorEngine
{
    public static class Helper
    {
        /// <summary>
        /// Copy file from sourceFileName to destFileName if sourceFileName exists. Params are the same as File.Copy
        /// </summary>
        /// <returns>true if successful, false if sourceFileName doesn't exists</returns>
        public static bool CopyIfSourceExists(string sourceFileName, string destFileName, bool overwrite = false)
        {
            try
            {
                File.Copy(sourceFileName, destFileName, true);
                return true;
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is DirectoryNotFoundException)
            {
                return false;
            }
        }
    }
}
