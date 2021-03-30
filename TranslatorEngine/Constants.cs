using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorEngine
{
    public class Constants
    {
        public static readonly string WorkingDir = Directory.GetCurrentDirectory();
        public static readonly string AssetsDir = Path.Combine(WorkingDir, "Assets");
        public static readonly string ConfigsDir = Path.Combine(WorkingDir, "Configs");
        public const string DefaultCharset = "GB2312";
    }
}
