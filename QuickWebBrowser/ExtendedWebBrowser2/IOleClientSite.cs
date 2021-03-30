using System;
using System.Runtime.InteropServices;

namespace ExtendedWebBrowser2
{
    [Guid("00000118-0000-0000-C000-000000000046")]
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleClientSite
    {
        [PreserveSig]
        int SaveObject();

        [PreserveSig]
        int GetMoniker([MarshalAs(UnmanagedType.U4)][In] int dwAssign, [MarshalAs(UnmanagedType.U4)][In] int dwWhichMoniker, [MarshalAs(UnmanagedType.Interface)] out object moniker);

        [PreserveSig]
        int GetContainer(out object container);

        [PreserveSig]
        int ShowObject();

        [PreserveSig]
        int OnShowWindow(int fShow);

        [PreserveSig]
        int RequestNewObjectLayout();
    }
}
