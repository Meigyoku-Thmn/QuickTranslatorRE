﻿using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using QuickTranslatorCore;

namespace QuickVietPhraseOneMeaningExtracter
{
    internal sealed class Program
    {
        [STAThread]
        private static void Main()
        {
            Logger.SetUpErrorHandler();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
