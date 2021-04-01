using System;

namespace ExtendedWebBrowser2
{
    [CLSCompliantAttribute(false)]
    public enum BrowserOptions : uint
    {
        None,
        AlwaysOffline = 268435456U,
        BackgroundSounds = 64U,
        DontRunActiveX = 512U,
        IgnoreCache = 8192U,
        IgnoreProxy = 16384U,
        Images = 16U,
        NoActiveXDownload = 1024U,
        NoBehaviours = 32768U,
        NoCharSets = 65536U,
        NoClientPull = 536870912U,
        NoJava = 256U,
        NoFrameDownload = 524288U,
        NoScripts = 128U,
        OfflineIfNotConnected = 2147483648U,
        UTF8 = 262144U,
        Videos = 32U
    }
}
