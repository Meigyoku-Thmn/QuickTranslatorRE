using System;

namespace ExtendedWebBrowser2
{
    internal class ScriptError
    {
        public int LineNumber {
            get; private set;
        }

        public string Description {
            get; private set;
        }

        public Uri Url {
            get; private set;
        }

        public ScriptError(Uri url, string description, int lineNumber)
        {
            Url = url;
            Description = description;
            LineNumber = lineNumber;
        }
    }
}
