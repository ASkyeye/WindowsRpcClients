//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\LogonController.dll
// Interface ID: f3f09ffd-fbcf-4291-944d-70ad6e0e73bb
// Interface Version: 1.0



namespace rpc_f3f09ffd_fbcf_4291_944d_70ad6e0e73bb_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_4(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(sbyte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<sbyte>(p0, p1, p2);
        }
        public void Write_7(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_8(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_9(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_10(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_11(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_3()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_4()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public sbyte[] Read_6()
        {
            return ReadConformantVaryingArray<sbyte>();
        }
        public sbyte[] Read_7()
        {
            return ReadConformantArray<sbyte>();
        }
        public byte[] Read_8()
        {
            return ReadConformantArray<byte>();
        }
        public int[] Read_9()
        {
            return ReadConformantArray<int>();
        }
        public sbyte[] Read_10()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_11()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_1(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_1 Member4;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, Struct_1 Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.WriteEmbeddedPointer<Struct_3>(Member8, new System.Action<Struct_3>(m.Write_3));
            m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member28, new System.Action<string>(m.WriteTerminatedString));
            m.WriteUInt3264(Member30);
            m.WriteInt16(Member38);
            m.WriteInt16(Member3A);
            m.WriteEnum16(Member3C);
            m.WriteUInt3264(Member40);
            m.WriteUInt3264(Member48);
            m.WriteInt32(Member50);
            m.WriteEmbeddedPointer<sbyte[], long, long>(Member58, new System.Action<sbyte[], long, long>(m.Write_6), Member50, Member50);
            m.WriteInt32(Member60);
            m.WriteInt32(Member64);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member8 = u.ReadEmbeddedPointer<Struct_3>(new System.Func<Struct_3>(u.Read_3), false);
            Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member28 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member30 = u.ReadUInt3264();
            Member38 = u.ReadInt16();
            Member3A = u.ReadInt16();
            Member3C = u.ReadEnum16();
            Member40 = u.ReadUInt3264();
            Member48 = u.ReadUInt3264();
            Member50 = u.ReadInt32();
            Member58 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_6), false);
            Member60 = u.ReadInt32();
            Member64 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_3> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member28;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member30;
        public short Member38;
        public short Member3A;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member3C;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member40;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member48;
        public int Member50;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member58;
        public int Member60;
        public int Member64;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(
                    NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, 
                    System.Nullable<Struct_3> Member8, 
                    string Member10, 
                    string Member18, 
                    string Member20, 
                    string Member28, 
                    NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member30, 
                    short Member38, 
                    short Member3A, 
                    NtApiDotNet.Ndr.Marshal.NdrEnum16 Member3C, 
                    NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member40, 
                    NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member48, 
                    int Member50, 
                    sbyte[] Member58, 
                    int Member60, 
                    int Member64)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member3A = Member3A;
            this.Member3C = Member3C;
            this.Member40 = Member40;
            this.Member48 = Member48;
            this.Member50 = Member50;
            this.Member58 = Member58;
            this.Member60 = Member60;
            this.Member64 = Member64;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(int Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member10);
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<sbyte[], long>(Member28, new System.Action<sbyte[], long>(m.Write_7), Member30);
            m.WriteInt32(Member30);
            m.WriteEmbeddedPointer<System.Guid>(Member38, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteEmbeddedPointer<string>(Member40, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member48, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadInt32();
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member28 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_7), false);
            Member30 = u.ReadInt32();
            Member38 = u.ReadEmbeddedPointer<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
            Member40 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member48 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member28;
        public int Member30;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<System.Guid> Member38;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member40;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member48;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(string Member0, string Member8, int Member10, string Member18, string Member20, sbyte[] Member28, int Member30, System.Nullable<System.Guid> Member38, string Member40, string Member48)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member40 = Member40;
            this.Member48 = Member48;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteEmbeddedPointer<byte[], long>(Member10, new System.Action<byte[], long>(m.Write_8), Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            Member10 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_8), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member10;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(int Member0, int Member4, int Member8, byte[] Member10)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("f3f09ffd-fbcf-4291-944d-70ad6e0e73bb", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int WluirAbort()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int WluirSecureDisplayLocked(string p0, string p1, string p2, NtApiDotNet.Ndr.Marshal.NdrEnum16 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEnum16(p3);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int WluirDisplayLocked(string p0, string p1, string p2, NtApiDotNet.Ndr.Marshal.NdrEnum16 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEnum16(p3);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int WluirWaitForLockScreenDismiss(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(3, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirDisplayMessage(string p0, string p1, int p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirDisplayRequestCredentialsError(int p0, int p1, string p2, string p3, int p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(5, m);
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirDisplaySecurityOptions(Struct_0 p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirDisplayStatus(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int WluirDisplayTSDisconnectOptions(int p0, int[] p1, int p2, out int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            p3 = u.ReadInt32();
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirDisplayWelcome(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirNotifyIsReadyForDesktopSwitch()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int WluirPromptForCredentials(int p0, Struct_2 p1, Struct_4 p2, int p3, int p4, sbyte[] p5, int p6, int p7, int p8, out sbyte[] p9, out int p10, out int p11, out int p12, out int p13)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_2(p1);
            m.Write_4(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<sbyte[], long>(m.Write_10), p6);
            m.WriteInt32(p6);
            m.WriteInt32(p7);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(11, m);
            p9 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_11), false);
            p10 = u.ReadInt32();
            p11 = u.ReadInt32();
            p12 = u.ReadInt32();
            p13 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirReleaseContext()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int WluirClearUIState()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int WluirReportResult(int p0, int p1, int p2, string p3, string p4, string p5, out string p6, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p4, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p5, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(14, m);
            p6 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p7 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int WluirRequestCredentials(int p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, System.Nullable<Struct_6> p2, out Struct_6 p3, ref System.Nullable<int> p4, out string p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteEnum16(p1);
            m.WriteReferent(p2, new System.Action<Struct_6>(m.Write_5));
            m.WriteReferent(p4, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(15, m);
            p3 = u.Read_5();
            p4 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), true);
            p5 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int WluirDisplayTSDisconnectUI(int p0, int[] p1, int p2, out int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(16, m);
            p3 = u.ReadInt32();
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirDisplayTSReconnectUI(int p0, int[] p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            _Unmarshal_Helper u = SendReceive(17, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public void WluirNotifyUserIsLoggedOn(short p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt16(p0);
            _Unmarshal_Helper u = SendReceive(18, m);
        }
        public int WluirFinishOperation(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int WluirInformLogonUI(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadInt32();
        }
        public int WluirDelayLocked(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(21, m);
            return u.ReadInt32();
        }
        public int WluirSecureDelayLocked(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteUInt3264(p1);
            _Unmarshal_Helper u = SendReceive(22, m);
            return u.ReadInt32();
        }
        public int WluirGetShutdownResolverInfo(out int p0, out int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(23, m);
            p0 = u.ReadInt32();
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int WluirSignalShutdown()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(24, m);
            return u.ReadInt32();
        }
        public int WluirPrepareWebDialog(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(25, m);
            return u.ReadInt32();
        }
        public int WluirWaitForWebDialogComplete()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(26, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

