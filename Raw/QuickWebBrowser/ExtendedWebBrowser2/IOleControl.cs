using System;
using System.Runtime.InteropServices;

namespace ExtendedWebBrowser2
{
    [Guid("B196B288-BAB4-101A-B69C-00AA00341D07")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface IOleControl
    {
        [PreserveSig]
        int GetControlInfo([Out] object pCI);

        [PreserveSig]
        int OnMnemonic([In] ref MSG pMsg);

        [PreserveSig]
        int OnAmbientPropertyChange(int dispID);

        [PreserveSig]
        int FreezeEvents(int bFreeze);
    }
}
