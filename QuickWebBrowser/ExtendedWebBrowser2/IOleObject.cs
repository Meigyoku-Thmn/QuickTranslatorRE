using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace ExtendedWebBrowser2
{
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("00000112-0000-0000-C000-000000000046")]
    [ComImport]
    internal interface IOleObject
    {
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int SetClientSite([MarshalAs(UnmanagedType.Interface)][In] IOleClientSite pClientSite);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int GetClientSite([MarshalAs(UnmanagedType.Interface)] out IOleClientSite site);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int SetHostNames(
            [MarshalAs(UnmanagedType.LPWStr)][In] string szContainerApp,
            [MarshalAs(UnmanagedType.LPWStr)][In] string szContainerObj);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int Close([MarshalAs(UnmanagedType.U4)][In] uint dwSaveOption);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int SetMoniker(
            [MarshalAs(UnmanagedType.U4)][In] uint dwWhichMoniker,
            [MarshalAs(UnmanagedType.Interface)][In] object pmk);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int GetMoniker(
            [MarshalAs(UnmanagedType.U4)][In] uint dwAssign,
            [MarshalAs(UnmanagedType.U4)][In] uint dwWhichMoniker,
            [MarshalAs(UnmanagedType.Interface)] out object moniker);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int InitFromData(
            [MarshalAs(UnmanagedType.Interface)][In] object pDataObject,
            [MarshalAs(UnmanagedType.Bool)][In] bool fCreation,
            [MarshalAs(UnmanagedType.U4)][In] uint dwReserved);

        int GetClipboardData([MarshalAs(UnmanagedType.U4)][In] uint dwReserved, out object data);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int DoVerb(
            [MarshalAs(UnmanagedType.I4)][In] int iVerb,
            [In] IntPtr lpmsg,
            [MarshalAs(UnmanagedType.Interface)][In] IOleClientSite pActiveSite,
            [MarshalAs(UnmanagedType.I4)][In] int lindex,
            [In] IntPtr hwndParent,
            [In] RECT lprcPosRect);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int EnumVerbs(out object e);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int OleUpdate();

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int IsUpToDate();

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int GetUserClassID([In][Out] ref Guid pClsid);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int GetUserType(
            [MarshalAs(UnmanagedType.U4)][In] uint dwFormOfType,
            [MarshalAs(UnmanagedType.LPWStr)] out string userType);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int SetExtent([MarshalAs(UnmanagedType.U4)][In] uint dwDrawAspect, [In] object pSizel);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int GetExtent([MarshalAs(UnmanagedType.U4)][In] uint dwDrawAspect, [Out] object pSizel);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int Advise([MarshalAs(UnmanagedType.Interface)][In] IAdviseSink pAdvSink, out int cookie);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int Unadvise([MarshalAs(UnmanagedType.U4)][In] int dwConnection);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int EnumAdvise(out object e);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int GetMiscStatus([MarshalAs(UnmanagedType.U4)][In] uint dwAspect, out int misc);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.I4)]
        int SetColorScheme([In] object pLogpal);
    }
}
