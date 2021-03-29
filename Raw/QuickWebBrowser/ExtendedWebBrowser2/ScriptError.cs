using System;

namespace ExtendedWebBrowser2
{
    internal class ScriptError
    {
        public ScriptError(Uri url, string description, int lineNumber)
        {
            _url = url;
            _description = description;
            _lineNumber = lineNumber;
        }

        public int LineNumber {
            get {
                return _lineNumber;
            }
        }

        public string Description {
            get {
                return _description;
            }
        }

        public Uri Url {
            get {
                return _url;
            }
        }

        private int _lineNumber;

        private string _description;

        private Uri _url;
    }
}
