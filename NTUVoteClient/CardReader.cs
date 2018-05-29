using System;
using System.Runtime.InteropServices;

namespace NTUOSC.Vote
{
    public class CardReader
    {
        public const string LibraryName = "dcrf32.dll";

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_init")]
        public extern static IntPtr Init(Int16 port, Int32 baud);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_exit")]
        public extern static Int16 Exit(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_config")]
        public extern static Int16 Config(IntPtr icdev, Byte mode, Byte baud);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_request")]
        public extern static Int16 Request(IntPtr icdev, Byte mode, UInt16[] tagType);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_anticoll")]
        public extern static Int16 AntiColl(IntPtr icdev, Byte bcnt, UInt32[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_select")]
        public extern static Int16 Select(IntPtr icdev, UInt32 snr, Byte[] size);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication")]
        public extern static Int16 Authentication(IntPtr icdev, Byte mode, Byte secNr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_halt")]
        public extern static Int16 Halt(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read")]
        public extern static Int16 Read(IntPtr icdev, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_hex")]
        public extern static Int16 ReadHex(IntPtr icdev, Byte adr, SByte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write")]
        public extern static Int16 Write(IntPtr icdev, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_hex")]
        public extern static Int16 WriteHex(IntPtr icdev, Byte adr, SByte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_load_key")]
        public extern static Int16 LoadKey(IntPtr icdev, Byte mode, Byte secNr, Byte[] nKey);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_load_key_hex")]
        public extern static Int16 LoadKeyHex(IntPtr icdev, Byte mode, Byte secNr, SByte[] nKey);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_card")]
        public extern static Int16 Card(IntPtr icdev, Byte mode, UInt32[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_card_hex")]
        public extern static Int16 CardHex(IntPtr icdev, Byte mode, Byte[] snrstr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_changeb3")]
        public extern static Int16 ChangeB3(IntPtr icdev, Byte secNr, Byte[] keyA, Byte b0, Byte b1, Byte b2, Byte b3, Byte bk, Byte[] keyB);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_restore")]
        public extern static Int16 Restore(IntPtr icdev, Byte adr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_transfer")]
        public extern static Int16 Transfer(IntPtr icdev, Byte adr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_increment")]
        public extern static Int16 Increment(IntPtr icdev, Byte adr, UInt32 value);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_decrement")]
        public extern static Int16 Decrement(IntPtr icdev, Byte adr, UInt32 value);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_initval")]
        public extern static Int16 InitVal(IntPtr icdev, Byte adr, UInt32 value);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readval")]
        public extern static Int16 ReadVal(IntPtr icdev, Byte adr, UInt32[] value);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_initval_ml")]
        public extern static Int16 InitValML(IntPtr icdev, UInt16 value);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readval_ml")]
        public extern static Int16 ReadValML(IntPtr icdev, UInt16[] value);
        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_decrement_ml")]
        public extern static Int16 DecrementML(IntPtr icdev, UInt16 value);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication_2")]
        public extern static Int16 Authentication2(IntPtr icdev, Byte mode, Byte KeyNr, Byte adr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_anticoll2")]
        public extern static Int16 AntiColl2(IntPtr icdev, Byte bcnt, UInt32[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_select2")]
        public extern static Int16 Select2(IntPtr icdev, UInt32 snr, Byte[] size);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_HL_write")]
        public extern static Int16 HLWrite(IntPtr icdev, Byte mode, Byte adr, UInt32[] snr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_HL_writehex")]
        public extern static Int16 HLWriteHex(IntPtr icdev, Byte mode, Byte adr, UInt32[] snr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_HL_read")]
        public extern static Int16 HLRead(IntPtr icdev, Byte mode, Byte adr, UInt32 snr, Byte[] data, UInt32[] nSnr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_HL_readhex")]
        public extern static Int16 HLReadHex(IntPtr icdev, Byte mode, Byte adr, UInt32 snr, Byte[] data, UInt32[] nSnr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_HL_authentication")]
        public extern static Int16 HLAuthentication(IntPtr icdev, Byte reqmode, UInt32 snr, Byte authmode, Byte secnr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_check_write")]
        public extern static Int16 CheckWrite(IntPtr icdev, UInt32 Snr, Byte authmode, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_check_writehex")]
        public extern static Int16 CheckWriteHex(IntPtr icdev, UInt32 Snr, Byte authmode, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getver")]
        public extern static Int16 GetVer(IntPtr icdev, Byte[] sver);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_clr_control_bit")]
        public extern static Int16 ClrControlBit(IntPtr icdev, Byte b);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_set_control_bit")]
        public extern static Int16 SetControlBit(IntPtr icdev, Byte b);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_reset")]
        public extern static Int16 Reset(IntPtr icdev, UInt16 msec);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_beep")]
        public extern static Int16 Beep(IntPtr icdev, UInt16 msec);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_disp_str")]
        public extern static Int16 DispStr(IntPtr icdev, SByte[] dispstr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_srd_eeprom")]
        public extern static Int16 SrdEEPROM(IntPtr icdev, Int16 offset, Int16 length, Byte[] recBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_swr_eeprom")]
        public extern static Int16 SwrEEPROM(IntPtr icdev, Int16 offset, Int16 length, Byte[] sendBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_srd_eepromhex")]
        public extern static Int16 SrdEEPROMHex(IntPtr icdev, Int16 offset, Int16 length, Byte[] recBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_swr_eepromhex")]
        public extern static Int16 SwrEEPROMHex(IntPtr icdev, Int16 offset, Int16 length, Byte[] sendBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_gettime")]
        public extern static Int16 GetTime(IntPtr icdev, Byte[] time);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_gettimehex")]
        public extern static Int16 GetTimeHex(IntPtr icdev, SByte[] time);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_settime")]
        public extern static Int16 SetTime(IntPtr icdev, Byte[] time);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_settimehex")]
        public extern static Int16 SetTimeHex(IntPtr icdev, SByte[] time);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_setbright")]
        public extern static Int16 Setbright(IntPtr icdev, Byte bright);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_ctl_mode")]
        public extern static Int16 CtlMode(IntPtr icdev, Byte mode);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_disp_mode")]
        public extern static Int16 DispMode(IntPtr icdev, Byte mode);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dcdeshex")]
        public extern static Int16 DESHex(Byte[] key, Byte[] sour, Byte[] dest, Int16 m);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dcdes")]
        public extern static Int16 DES(Byte[] key, Byte[] sour, Byte[] dest, Int16 m);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_light")]
        public extern static Int16 Light(IntPtr icdev, UInt16 onOff);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_high_disp")]
        public extern static Int16 HighDisp(IntPtr icdev, Byte offset, Byte displen, Byte[] dispstr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_setcpu")]
        public extern static Int16 SetCPU(IntPtr icdev, Byte byte);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpureset")]
        public extern static Int16 CPUReset(IntPtr icdev, Byte[] rlen, Byte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpuapdusource")]
        public extern static Int16 CPUAPDUSource(IntPtr icdev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpuapdu")]
        public extern static Int16 CPUAPDU(IntPtr icdev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpureset_hex")]
        public extern static Int16 CPUResetHex(IntPtr icdev, Byte[] rlen, SByte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpuapdusource_hex")]
        public extern static Int16 CPUAPDUSourceHex(IntPtr icdev, Byte slen, SByte[] sendbuffer, Byte[] rlen, SByte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpuapdu_hex")]
        public extern static Int16 CPUAPDUHex(IntPtr icdev, Byte slen, SByte[] sendbuffer, Byte[] rlen, SByte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpuapdurespon")]
        public extern static Int16 CPUAPDURespon(IntPtr idComDev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpuapdurespon_hex")]
        public extern static Int16 CPUAPDUResponHex(IntPtr idComDev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_cpudown")]
        public extern static Int16 CPUDown(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_set_addr")]
        public extern static Int16 SetAddr(Byte saddr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_init_485")]
        public extern static IntPtr Init485(Int16 port, Int32 baud);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_changebaud_485")]
        public extern static Int16 ChangeBAUD485(IntPtr icdev, Int32 baud);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_change_addr")]
        public extern static Int16 ChangeAddr(IntPtr icdev, Byte saddr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_reset")]
        public extern static Int16 ProReset(IntPtr icdev, Byte[] rlen, Byte[] receive_data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_command")]
        public extern static Int16 ProCommand(IntPtr idComDev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer, Byte timeout);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_resethex")]
        public extern static Int16 ProResetHex(IntPtr icdev, Byte[] rlen, SByte[] receive_data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_commandhex")]
        public extern static Int16 ProCommandHex(IntPtr idComDev, Byte slen, SByte[] sendbuffer, Byte[] rlen, SByte[] databuffer, Byte timeout);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_commandsource")]
        public extern static Int16 ProCommandSource(IntPtr idComDev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer, Byte timeout);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_commandsourcehex")]
        public extern static Int16 ProCommandSourceHex(IntPtr idComDev, Byte slen, SByte[] sendbuffer, Byte[] rlen, SByte[] databuffer, Byte timeout);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_halt")]
        public extern static Int16 ProHalt(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_request_shc1102")]
        public extern static Int16 RequestSHC1102(IntPtr icdev, Byte mode, UInt16[] TagType);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_auth_shc1102")]
        public extern static Int16 AuthSHC1102(IntPtr icdev, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_shc1102")]
        public extern static Int16 ReadSHC1102(IntPtr icdev, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_shc1102")]
        public extern static Int16 WriteSHC1102(IntPtr icdev, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_halt_shc1102")]
        public extern static Int16 HaltSHC1102(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "")]
        public extern static Int16 HexA(Byte[] hex, Byte[] a, Int16 length);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "")]
        public extern static Int16 AHex(Byte[] a, Byte[] hex, Int16 len);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_config_card")]
        public extern static Int16 ConfigCard(IntPtr icdev, Byte cardtype);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_request_b")]
        public extern static Int16 RequestB(IntPtr icdev, Byte mode, Byte AFI, Byte N, Byte[] ATQB);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_slotmarker")]
        public extern static Int16 SlotMarker(IntPtr icdev, Byte N, Byte[] ATQB);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_attrib")]
        public extern static Int16 Attrib(IntPtr icdev, Byte[] PUPI, Byte CID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_open_door")]
        public extern static Int16 OpenDoor(IntPtr icdev, Byte cflag);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_open_timedoor")]
        public extern static Int16 OpenTimeDoor(IntPtr icdev, UInt16 utime);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_random")]
        public extern static Int16 ReadRandom(IntPtr icdev, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_random")]
        public extern static Int16 WriteRandom(IntPtr icdev, Int16 len, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_random_hex")]
        public extern static Int16 ReadRandomHex(IntPtr icdev, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_random_hex")]
        public extern static Int16 WriteRandomHex(IntPtr icdev, Int16 len, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_erase_random")]
        public extern static Int16 EraseRandom(IntPtr icdev, Int16 len);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_mfdes_auth")]
        public extern static Int16 MFDESAuth(IntPtr icdev, Byte keyno, Byte keylen, Byte[] authkey, Byte[] randAdata, Byte[] randBdata);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication_pass")]
        public extern static Int16 AuthenticationPass(IntPtr icdev, Byte mode, Byte addr, Byte[] passbuff);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_disp_neg")]
        public extern static Int16 DispNeg(IntPtr icdev, SByte[] dispstr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_commandlink")]
        public extern static Int16 ProCommandLink(IntPtr idComDev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer, Byte timeout, Byte FG);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_commandlink_hex")]
        public extern static Int16 ProCommandLinkHex(IntPtr idComDev, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer, Byte timeout, Byte FG);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_card_double")]
        public extern static Int16 CardDouble(IntPtr icdev, Byte mode, Byte[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_card_double_hex")]
        public extern static Int16 CardDoubleHex(IntPtr icdev, Byte mode, Byte[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_idcard")]
        public extern static Int16 ReadIDCard(IntPtr icdev, Byte times, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_idcard_hex")]
        public extern static Int16 ReadIDCardHex(IntPtr icdev, Byte times, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication_pass_hex")]
        public extern static Int16 AuthenticationPassHex(IntPtr icdev, Byte mode, Byte addr, Byte[] passbuff);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_setcpupara")]
        public extern static Int16 SetCPUPara(IntPtr icdev, Byte cputype, Byte cpupro, Byte cpuetu);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_command")]
        public extern static Int16 Command(IntPtr idComDev, Byte cmd, Byte slen, Byte[] sendbuffer, Byte[] rlen, Byte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_command_hex")]
        public extern static Int16 CommandHex(IntPtr idComDev, Byte cmd, Byte slen, SByte[] sendbuffer, Byte[] rlen, SByte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_creat_mac")]
        public extern static Int16 CreatMAC(Byte KeyLen, Byte[] Key, UInt16 DataLen, Byte[] Data, Byte[] InitData, Byte AutoFixFlag, Byte FixSByte, Byte[] MacData);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_creat_mac_hex")]
        public extern static Int16 CreatMACHex(Byte KeyLen, Byte[] Key, UInt16 DataLen, Byte[] Data, Byte[] InitData, Byte AutoFixFlag, Byte FixSByte, Byte[] MacData);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_HL_write_hex")]
        public extern static Int16 HLWriteHex(IntPtr icdev, Byte mode, Byte adr, UInt32[] snr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_HL_read_hex")]
        public extern static Int16 HLReadHex(IntPtr icdev, Byte mode, Byte adr, UInt32 snr, Byte[] data, UInt32[] nSnr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_check_write_hex")]
        public extern static Int16 CheckWriteHex(IntPtr icdev, UInt32 Snr, Byte authmode, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_srd_eeprom_hex")]
        public extern static Int16 SrdEEPROMHex(IntPtr icdev, Int16 offset, Int16 length, Byte[] recBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_swr_eeprom_hex")]
        public extern static Int16 SwrEEPROMHex(IntPtr icdev, Int16 offset, Int16 length, Byte[] sendBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_gettime_hex")]
        public extern static Int16 GetTimeHex(IntPtr icdev, SByte[] time);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_settime_hex")]
        public extern static Int16 SetTimeHex(IntPtr icdev, SByte[] time);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_des_hex")]
        public extern static Int16 DESHex(Byte[] key, Byte[] sour, Byte[] dest, Int16 m);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_des")]
        public extern static Int16 DES(Byte[] key, Byte[] sour, Byte[] dest, Int16 m);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_reset_hex")]
        public extern static Int16 ProresetHex(IntPtr icdev, Byte[] rlen, SByte[] receive_data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_command_hex")]
        public extern static Int16 ProcommandHex(IntPtr idComDev, Byte slen, SByte[] sendbuffer, Byte[] rlen, SByte[] databuffer, Byte timeout);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_commandsource_hex")]
        public extern static Int16 ProCommandSourceHex(IntPtr idComDev, Byte slen, SByte[] sendbuffer, Byte[] rlen, SByte[] databuffer, Byte timeout);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_switch_unix")]
        public extern static Int16 SwitchUnix(IntPtr icdev, Int32 baud);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication_passaddr")]
        public extern static Int16 AuthenticationPassAddr(IntPtr icdev, Byte mode, Byte addr, Byte[] passbuff);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_authentication_passaddr_hex")]
        public extern static Int16 AuthenticationPassAddrHex(IntPtr icdev, Byte mode, Byte addr, Byte[] passbuff);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_card_fm11rf005")]
        public extern static Int16 CardFM11RF005(IntPtr icdev, Byte mode, UInt32[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_setusbtimeout")]
        public extern static Int16 SetUSBTimeout(Byte ntimes);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_mfdes_baud")]
        public extern static Int16 MFDESBaud(IntPtr icdev, Byte mode, Byte para);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_tripledes")]
        public extern static Int16 TripleDES(Byte[] key, Byte[] src, Byte[] dest, Int16 m);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_tripledes_hex")]
        public extern static Int16 TripledDESHex(Byte[] key, Byte[] src, Byte[] dest, Int16 m);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_mfdes_auth_hex")]
        public extern static Int16 MFDESAuthHex(IntPtr icdev, Byte keyno, Byte keylen, Byte[] authkey, Byte[] randAdata, Byte[] randBdata);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_sendcommandsource")]
        public extern static Int16 ProSendCommandSource(IntPtr idComDev, Byte slen, Byte[] sendbuffer, Byte timeout);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_pro_receivecommandsource")]
        public extern static Int16 ProReceiveCommandSource(IntPtr idComDev, Byte[] rlen, Byte[] databuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_inventory")]
        public extern static Int16 Inventory(IntPtr icdev, Byte flags, Byte AFI, Byte masklen, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_inventory_hex")]
        public extern static Int16 InventoryHex(IntPtr icdev, Byte flags, Byte AFI, Byte masklen, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_stay_quiet")]
        public extern static Int16 Stay_quiet(IntPtr icdev, Byte flags, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_stay_quiet_hex")]
        public extern static Int16 Stay_quietHex(IntPtr icdev, Byte flags, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_select_uid")]
        public extern static Int16 SelectUID(IntPtr icdev, Byte flags, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_select_uid_hex")]
        public extern static Int16 SelectUIDHex(IntPtr icdev, Byte flags, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_reset_to_ready")]
        public extern static Int16 ResetToReady(IntPtr icdev, Byte flags, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_reset_to_ready_hex")]
        public extern static Int16 ResetToReadyHex(IntPtr icdev, Byte flags, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readblock")]
        public extern static Int16 ReadBlock(IntPtr icdev, Byte flags, Byte startblock, Byte blocknum, Byte[] UID, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readblock_hex")]
        public extern static Int16 ReadBlockHex(IntPtr icdev, Byte flags, Byte startblock, Byte blocknum, Byte[] UID, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_writeblock")]
        public extern static Int16 WriteBlock(IntPtr icdev, Byte flags, Byte startblock, Byte blocknum, Byte[] UID, Byte wlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_writeblock_hex")]
        public extern static Int16 WriteBlockHex(IntPtr icdev, Byte flags, Byte startblock, Byte blocknum, Byte[] UID, Byte wlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_lock_block")]
        public extern static Int16 LockBlock(IntPtr icdev, Byte flags, Byte block, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_lock_block_hex")]
        public extern static Int16 LockBlockHex(IntPtr icdev, Byte flags, Byte block, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_afi")]
        public extern static Int16 WriteAFI(IntPtr icdev, Byte flags, Byte AFI, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_afi_hex")]
        public extern static Int16 WriteAFIHex(IntPtr icdev, Byte flags, Byte AFI, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_lock_afi")]
        public extern static Int16 LockAFI(IntPtr icdev, Byte flags, Byte AFI, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_lock_afi_hex")]
        public extern static Int16 LockAFIHex(IntPtr icdev, Byte flags, Byte AFI, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_dsfid")]
        public extern static Int16 WriteDSFID(IntPtr icdev, Byte flags, Byte DSFID, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_dsfid_hex")]
        public extern static Int16 WriteDSFIDHex(IntPtr icdev, Byte flags, Byte DSFID, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_lock_dsfid")]
        public extern static Int16 LockDSFID(IntPtr icdev, Byte flags, Byte DSFID, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_lock_dsfid_hex")]
        public extern static Int16 LockDSFIDHex(IntPtr icdev, Byte flags, Byte DSFID, Byte[] UID);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_get_systeminfo")]
        public extern static Int16 GetSystemInfo(IntPtr icdev, Byte flags, Byte[] UID, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_get_systeminfo_hex")]
        public extern static Int16 GetSystemInfoHex(IntPtr icdev, Byte flags, Byte[] UID, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_get_securityinfo")]
        public extern static Int16 GetSecurityUnfo(IntPtr icdev, Byte flags, Byte startblock, Byte blocknum, Byte[] UID, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_get_securityinfo_hex")]
        public extern static Int16 GetSecurityInfoHex(IntPtr icdev, Byte flags, Byte startblock, Byte blocknum, Byte[] UID, Byte[] rlen, Byte[] rbuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getsnr_fm11rf005")]
        public extern static Int16 GetSNRFM11RF005(IntPtr icdev, UInt32[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getsnr_fm11rf005_hex")]
        public extern static Int16 GetSNRFM11RF005Hex(IntPtr icdev, Byte[] snrstr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_fm11rf005")]
        public extern static Int16 WriteFM11RF005(IntPtr icdev, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_fm11rf005")]
        public extern static Int16 ReadFM11RF005(IntPtr icdev, Byte adr, Byte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_fm11rf005_hex")]
        public extern static Int16 ReadFM11RF005Hex(IntPtr icdev, Byte adr, SByte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_fm11rf005_hex")]
        public extern static Int16 WriteFM11RF005Hex(IntPtr icdev, Byte adr, SByte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_displcd")]
        public extern static Int16 DispLCD(IntPtr idComDev, Byte flag);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getinputpass")]
        public extern static Int16 GetInputPass(IntPtr idComDev, Byte ctime, Byte[] rlen, Byte[] cpass);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readmagcard")]
        public extern static Int16 ReadMagCard(IntPtr idComDev, Byte ctime, Byte[] pTrack2Data, UInt32[] pTrack2Len, Byte[] pTrack3Data, UInt32[] pTrack3Len);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_testdevicecomm")]
        public extern static Int16 TestDeviceComm(IntPtr idComDev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_dispmainmenu")]
        public extern static Int16 DispMainMenu(IntPtr idComDev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_setdevicetime")]
        public extern static Int16 SetDeviceTime(IntPtr idComDev, Byte year, Byte month, Byte date, Byte hour, Byte minute, Byte second);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getdevicetime")]
        public extern static Int16 GetDeviceTime(IntPtr idComDev, Byte[] year, Byte[] month, Byte[] date, Byte[] hour, Byte[] minute, Byte[] second);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_dispinfo")]
        public extern static Int16 DispInfo(IntPtr idComDev, Byte line, Byte offset, SByte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_dispmaininfo")]
        public extern static Int16 DispMainInfo(IntPtr idComDev, Byte offset, SByte[] data);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_posbeep")]
        public extern static Int16 PosBeep(IntPtr idComDev, Byte beeptime);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_ctlbacklight")]
        public extern static Int16 CtlBacklight(IntPtr idComDev, Byte cOpenFlag);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_ctlled")]
        public extern static Int16 CtlLED(IntPtr idComDev, Byte cLed, Byte cOpenFlag);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_lcdclrscrn")]
        public extern static Int16 LCDClrScrn(IntPtr idComDev, Byte cLine);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_passin")]
        public extern static Int16 PassIn(IntPtr idComDev, Byte ctime);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_passget")]
        public extern static Int16 PassGet(IntPtr idComDev, Byte[] rlen, Byte[] cpass);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_passcancel")]
        public extern static Int16 PassCancel(IntPtr idComDev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getinputkey")]
        public extern static Int16 GetInputKey(IntPtr idComDev, Byte disptype, Byte line, Byte ctime, Byte[] rlen, Byte[] ckeydata);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_resetdevice")]
        public extern static Int16 ResetDevice(IntPtr idComDev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_displcd_ext")]
        public extern static Int16 DispLCDExt(IntPtr idComDev, Byte flag, Byte row, Byte offset);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readmagcardall")]
        public extern static Int16 ReadMagCardAll(IntPtr idComDev, Byte ctime, Byte[] pTrack1Data, UInt32[] pTrack1Len, Byte[] pTrack2Data, UInt32[] pTrack2Len, Byte[] pTrack3Data, UInt32[] pTrack3Len);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readdevsnr")]
        public extern static Int16 ReadDevSNR(IntPtr idComDev, Byte[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readreadersnr")]
        public extern static Int16 ReadReaderSNR(IntPtr idComDev, Byte[] snr);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_4442")]
        public extern static Int16 Read4442(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_4442_hex")]
        public extern static Int16 Read4442Hex(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_4442")]
        public extern static Int16 Write4442(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_4442_hex")]
        public extern static Int16 Write4442Hex(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_verifypin_4442")]
        public extern static Int16 VerifyPin4442(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_verifypin_4442_hex")]
        public extern static Int16 VerifyPin4442Hex(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readpin_4442")]
        public extern static Int16 ReadPin4442(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readpin_4442_hex")]
        public extern static Int16 ReadPin4442Hex(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readpincount_4442")]
        public extern static Int16 ReadPinCount4442(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_changepin_4442")]
        public extern static Int16 ChangePin4442(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_changepin_4442_hex")]
        public extern static Int16 ChangePin4442Hex(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readwrotect_4442")]
        public extern static Int16 ReadWrotect4442(IntPtr icdev, Int16 offset, Int16 leng, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readwrotect_4442_hex")]
        public extern static Int16 ReadWrotect4442Hex(IntPtr icdev, Int16 offset, Int16 leng, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_writeprotect_4442")]
        public extern static Int16 WriteProtect4442(IntPtr icdev, Int16 offset, Int16 leng, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_writeprotect_4442_hex")]
        public extern static Int16 WriteProtect4442Hex(IntPtr icdev, Int16 offset, Int16 leng, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_24c")]
        public extern static Int16 Write24C(IntPtr icdev, Int16 offset, Int16 length, Byte[] sndBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_24c_hex")]
        public extern static Int16 Write24CHex(IntPtr icdev, Int16 offset, Int16 length, Byte[] sndBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_24c64")]
        public extern static Int16 Write24C64(IntPtr icdev, Int16 offset, Int16 length, Byte[] sndBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_24c64_hex")]
        public extern static Int16 Write24C64Hex(IntPtr icdev, Int16 offset, Int16 length, Byte[] sndBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_24c")]
        public extern static Int16 Read24C(IntPtr icdev, Int16 offset, Int16 length, Byte[] receiveBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_24c_hex")]
        public extern static Int16 Read24CHex(IntPtr icdev, Int16 offset, Int16 length, Byte[] receiveBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_24c64")]
        public extern static Int16 Read24C64(IntPtr icdev, Int16 offset, Int16 length, Byte[] receiveBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_24c64_hex")]
        public extern static Int16 Read24C64Hex(IntPtr icdev, Int16 offset, Int16 length, Byte[] receiveBuffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_4428")]
        public extern static Int16 Read4428(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_read_4428_hex")]
        public extern static Int16 Read4428Hex(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_4428")]
        public extern static Int16 Write4428(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_write_4428_hex")]
        public extern static Int16 Write4428Hex(IntPtr icdev, Int16 offset, Int16 length, Byte[] buffer);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_verifypin_4428")]
        public extern static Int16 VerifyPin4428(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_verifypin_4428_hex")]
        public extern static Int16 VerifyPin4428Hex(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readpin_4428")]
        public extern static Int16 ReadPin4428(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readpin_4428_hex")]
        public extern static Int16 ReadPin4428Hex(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_readpincount_4428")]
        public extern static Int16 ReadPinCount4428(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_changepin_4428")]
        public extern static Int16 ChangePin4428(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_changepin_4428_hex")]
        public extern static Int16 ChangePin4428Hex(IntPtr icdev, Byte[] passwd);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_4442")]
        public extern static Int16 Check4442(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_4428")]
        public extern static Int16 Check4428(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_24C01")]
        public extern static Int16 Check24C01(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_24C02")]
        public extern static Int16 Check24C02(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_24C04")]
        public extern static Int16 Check24C04(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_24C08")]
        public extern static Int16 Check24C08(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_24C16")]
        public extern static Int16 Check24C16(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_24C64")]
        public extern static Int16 Check24C64(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_Check_CPU")]
        public extern static Int16 CheckCPU(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_CheckCard")]
        public extern static Int16 CheckCard(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getrcinfo")]
        public extern static Int16 GetRCInfo(IntPtr icdev, Byte[] info);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getrcinfo_hex")]
        public extern static Int16 GetRCInfoHex(IntPtr icdev, Byte[] info);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getInt32ver")]
        public extern static Int16 GetInt32Ver(IntPtr icdev, Byte[] sver);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getrcinfo")]
        public extern static Int16 GetRCInfo(IntPtr icdev, Byte[] info);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getrcinfo_hex")]
        public extern static Int16 GetRCInfoHex(IntPtr icdev, Byte[] info);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getInt32ver")]
        public extern static Int16 GetInt32Ver(IntPtr icdev, Byte[] sver);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_CheckCard")]
        public extern static Int16 CheckCard(IntPtr icdev);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getrcinfo")]
        public extern static Int16 GetRCInfo(IntPtr icdev, Byte[] info);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getrcinfo_hex")]
        public extern static Int16 GetRCInfoHex(IntPtr icdev, Byte[] info);

        [DllImport(LibraryName, CallingConvention = CallingConvention.StdCall, EntryPoint = "dc_getInt32ver")]
        public extern static Int16 GetInt32Ver(IntPtr icdev, Byte[] sver);

    }
}
