using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NTUOSC.Vote
{
    public partial class CardReader : IDisposable
    {
        protected IntPtr icdev;
        protected byte targetSector;

        public void Initialize()
        {
            icdev = Native.Init(Native.PORT_USB, Native.BAUD_RATE);
            if (icdev == IntPtr.Zero) throw new CardReaderException("找不到讀卡機");

            byte version = 0;
            if (Native.GetVer(icdev, ref version) != 0) throw new CardReaderException("測試讀卡機版號失敗");

            // Beep feedback
            if (Native.Beep(icdev, 100) != 0) throw new CardReaderException("測試讀卡機嗶嗶叫失敗");

            Program.Log("Initialize card reader ver {0}", version);
        }

        public CardData ReadCard() // These statuses are basically guessed.
        {
            if (icdev == IntPtr.Zero)
                throw new CardReaderException("讀卡機尚未初始化");

            Assert(Native.Reset(icdev, 0), "重設讀卡機狀態失敗");

            ushort tagType = 0;
            Assert(Native.Request(icdev, 0, ref tagType), "未偵測到卡片");
            Program.Log("Detected card type {0}", tagType);

            uint serial = 0;
            Assert(Native.AntiColl(icdev, 0, ref serial), "偵測到多張卡片");
            Program.Log("Card collision serial {0} passed", serial);

            byte size = 0;
            Assert(Native.Select(icdev, serial, ref size), "無法選擇卡片");

            Assert(Native.Authentication(icdev, 0, targetSector), "無法驗證卡片，可能不是有效的學生證");

            StringBuilder builder = new StringBuilder(16);
            Assert(Native.Read(icdev, (byte)(targetSector * 4), builder), "卡片讀取失敗");

            string rawData = builder.ToString();
            Program.Log("Card loaded: {0}", rawData);

            try {
                return new CardData {
                    InternalId = serial.ToString("x"),
                    StudentId = rawData.Substring(0, 9),
                    Revision = int.Parse(rawData.Substring(9, rawData.Length > 10 ? 2 : 1).Trim())
                };
            } catch {
                throw new CardReaderException("卡片磁區資料不正確，請聯絡發卡單位");
            }
        }

        public bool Initialized
        {
            get { return icdev != IntPtr.Zero; }
        }

        public static string ByteArrayToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", "");
        }

        protected static void Assert(short returnValue, string errorMessage)
        {
            if (returnValue != 0)
            {
                Program.Log(String.Format("Card read error ret {0} ({1})", returnValue, errorMessage));
                throw new CardReaderException(errorMessage);
            }
        }

        public static class Native
        {
            public const short PORT_USB = 100;
            public const int BAUD_RATE = 115200;

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
            public extern static short Select(IntPtr icdev, uint snr, ref byte size);

            [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication")]
            public extern static short Authentication(IntPtr icdev, byte mode, byte secNr);

            [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read")]
            public extern static short Read(IntPtr icdev, byte adr, [MarshalAs(UnmanagedType.LPStr)] StringBuilder data);

            [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_load_key")]
            public extern static short LoadKey(IntPtr icdev, byte mode, byte secNr, [In] byte[] nKey);

            [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_card")]
            public extern static short Card(IntPtr icdev, byte mode, ref uint snr);

            [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getver")]
            public extern static short GetVer(IntPtr icdev, ref byte sver);

            [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_reset")]
            public extern static short Reset(IntPtr icdev, ushort msec);

            [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_beep")]
            public extern static short Beep(IntPtr icdev, ushort msec);
        }

        #region IDisposable Support
        private bool disposedValue = false; // 偵測多餘的呼叫

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 處置受控狀態 (受控物件)。
                }

                // TODO: 釋放非受控資源 (非受控物件) 並覆寫下方的完成項。
                // TODO: 將大型欄位設為 null。
                if (icdev != IntPtr.Zero)
                {
                    Native.Exit(icdev);
                    icdev = IntPtr.Zero;
                }

                disposedValue = true;
            }
        }

        // TODO: 僅當上方的 Dispose(bool disposing) 具有會釋放非受控資源的程式碼時，才覆寫完成項。
        // ~CardReader() {
        //   // 請勿變更這個程式碼。請將清除程式碼放入上方的 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 加入這個程式碼的目的在正確實作可處置的模式。
        public void Dispose()
        {
            // 請勿變更這個程式碼。請將清除程式碼放入上方的 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果上方的完成項已被覆寫，即取消下行的註解狀態。
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    public class CardData
    {
        public string InternalId { get; set; }
        public string StudentId { get; set; }
        public int Revision { get; set; }
    }

    public class CardReaderException : Exception
    {
        public CardReaderException(string message) : base(message)
        {
            //
        }
    }
}
