using System;
using System.Runtime.InteropServices;

namespace NTUOSC.Vote
{
    public class CardReader
    {
        public const string LibraryName = "dcrf32.dll";

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_init")]
        public extern static IntPtr Init(short port, int baud);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_exit")]
        public extern static short Exit(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_request")]
        public extern static short Request(IntPtr icdev, byte mode, ref ushort tagType);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_anticoll")]
        public extern static short AntiColl(IntPtr icdev, byte bcnt, ref uint snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_select")]
        public extern static short Select(IntPtr icdev, uint snr, out byte[] size);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication")]
        public extern static short Authentication(IntPtr icdev, byte mode, byte secNr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read")]
        public extern static short Read(IntPtr icdev, byte adr, out byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_load_key")]
        public extern static short LoadKey(IntPtr icdev, byte mode, byte secNr, [In] byte[] nKey);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_card")]
        public extern static short Card(IntPtr icdev, byte mode, ref uint snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getver")]
        public extern static short GetVer(IntPtr icdev, out byte[] sver);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_reset")]
        public extern static short Reset(IntPtr icdev, ushort msec);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_beep")]
        public extern static short Beep(IntPtr icdev, ushort msec);
    }
}
