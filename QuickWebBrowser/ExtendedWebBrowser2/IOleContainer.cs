using System;
using System.Runtime.InteropServices;

namespace ExtendedWebBrowser2
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("0000011B-0000-0000-C000-000000000046")]
    [ComVisible(true)]
    [CLSCompliantAttribute(false)]
    public interface IOleContainer
    {
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int ParseDisplayName([MarshalAs(UnmanagedType.Interface)][In] object pbc, [MarshalAs(UnmanagedType.LPWStr)][In] string pszDisplayName, [MarshalAs(UnmanagedType.LPArray)][Out] int[] pchEaten, [MarshalAs(UnmanagedType.LPArray)][Out] object[] ppmkOut);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int EnumObjects([MarshalAs(UnmanagedType.U4)][In] uint grfFlags, [MarshalAs(UnmanagedType.LPArray)][Out] object[] ppenum);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int LockContainer([MarshalAs(UnmanagedType.Bool)][In] bool fLock);
    }
}
