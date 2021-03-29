using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ExtendedWebBrowser2.Properties
{
    [CompilerGenerated]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [DebuggerNonUserCode]
    internal class Resources
    {
        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(Resources.resourceMan, null))
                {
                    ResourceManager resourceManager = new ResourceManager("ExtendedWebBrowser2.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = resourceManager;
                }
                return Resources.resourceMan;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return Resources.resourceCulture;
            }
            set {
                Resources.resourceCulture = value;
            }
        }

        internal static string DefaultBrowserTitle {
            get {
                return Resources.ResourceManager.GetString("DefaultBrowserTitle", Resources.resourceCulture);
            }
        }

        internal static string OpenFileDialogFilter {
            get {
                return Resources.ResourceManager.GetString("OpenFileDialogFilter", Resources.resourceCulture);
            }
        }

        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;
    }
}
