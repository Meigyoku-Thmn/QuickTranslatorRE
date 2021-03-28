using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorEngine
{
    public class Constant
    {
        public static readonly string EngineDirPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public const string DefaultCharset = "GB2312";
    }
}
