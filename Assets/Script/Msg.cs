// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protobuf/msg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protomsg {

  /// <summary>Holder for reflection information generated from protobuf/msg.proto</summary>
  public static partial class MsgReflection {

    #region Descriptor
    /// <summary>File descriptor for protobuf/msg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJwcm90b2J1Zi9tc2cucHJvdG8SCHByb3RvbXNnIlsKB01zZ0Jhc2USEAoI",
            "TW9kZVR5cGUYASABKAkSCwoDVWlkGAIgASgFEg8KB01zZ1R5cGUYAyABKAkS",
            "EQoJQ29ubmVjdElkGAQgASgFEg0KBURhdGFzGAUgASgMIiUKEU1zZ1JlZ2lz",
            "dGVyVG9HYXRlEhAKCE1vZGVUeXBlGAEgASgJIkUKEENTX01zZ1F1aWNrTG9n",
            "aW4SEAoIUGxhdGZvcm0YASABKAkSEQoJTWFjaGluZWlkGAIgASgJEgwKBE5h",
            "bWUYAyABKAkiZgoIQ1NfTG9naW4SEwoLUGhvbmVudW1iZXIYASABKAkSEAoI",
            "UGxhdGZvcm0YAiABKAkSEQoJTWFjaGluZWlkGAMgASgJEhEKCVdlY2hhdF9p",
            "ZBgEIAEoCRINCgVRUV9pZBgFIAEoCSofCglQaG9uZVR5cGUSCAoESE9NRRAA",
            "EggKBFdPUksQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Protomsg.PhoneType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protomsg.MsgBase), global::Protomsg.MsgBase.Parser, new[]{ "ModeType", "Uid", "MsgType", "ConnectId", "Datas" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protomsg.MsgRegisterToGate), global::Protomsg.MsgRegisterToGate.Parser, new[]{ "ModeType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protomsg.CS_MsgQuickLogin), global::Protomsg.CS_MsgQuickLogin.Parser, new[]{ "Platform", "Machineid", "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protomsg.CS_Login), global::Protomsg.CS_Login.Parser, new[]{ "Phonenumber", "Platform", "Machineid", "WechatId", "QQId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///手机类型
  ///枚举类型第一个字段必须为0
  /// </summary>
  public enum PhoneType {
    [pbr::OriginalName("HOME")] Home = 0,
    [pbr::OriginalName("WORK")] Work = 1,
  }

  #endregion

  #region Messages
  public sealed partial class MsgBase : pb::IMessage<MsgBase> {
    private static readonly pb::MessageParser<MsgBase> _parser = new pb::MessageParser<MsgBase>(() => new MsgBase());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MsgBase> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protomsg.MsgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgBase() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgBase(MsgBase other) : this() {
      modeType_ = other.modeType_;
      uid_ = other.uid_;
      msgType_ = other.msgType_;
      connectId_ = other.connectId_;
      datas_ = other.datas_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgBase Clone() {
      return new MsgBase(this);
    }

    /// <summary>Field number for the "ModeType" field.</summary>
    public const int ModeTypeFieldNumber = 1;
    private string modeType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModeType {
      get { return modeType_; }
      set {
        modeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Uid" field.</summary>
    public const int UidFieldNumber = 2;
    private int uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "MsgType" field.</summary>
    public const int MsgTypeFieldNumber = 3;
    private string msgType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MsgType {
      get { return msgType_; }
      set {
        msgType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ConnectId" field.</summary>
    public const int ConnectIdFieldNumber = 4;
    private int connectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ConnectId {
      get { return connectId_; }
      set {
        connectId_ = value;
      }
    }

    /// <summary>Field number for the "Datas" field.</summary>
    public const int DatasFieldNumber = 5;
    private pb::ByteString datas_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Datas {
      get { return datas_; }
      set {
        datas_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MsgBase);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MsgBase other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModeType != other.ModeType) return false;
      if (Uid != other.Uid) return false;
      if (MsgType != other.MsgType) return false;
      if (ConnectId != other.ConnectId) return false;
      if (Datas != other.Datas) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ModeType.Length != 0) hash ^= ModeType.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (MsgType.Length != 0) hash ^= MsgType.GetHashCode();
      if (ConnectId != 0) hash ^= ConnectId.GetHashCode();
      if (Datas.Length != 0) hash ^= Datas.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ModeType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ModeType);
      }
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Uid);
      }
      if (MsgType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MsgType);
      }
      if (ConnectId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ConnectId);
      }
      if (Datas.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Datas);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ModeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModeType);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Uid);
      }
      if (MsgType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgType);
      }
      if (ConnectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ConnectId);
      }
      if (Datas.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Datas);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MsgBase other) {
      if (other == null) {
        return;
      }
      if (other.ModeType.Length != 0) {
        ModeType = other.ModeType;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.MsgType.Length != 0) {
        MsgType = other.MsgType;
      }
      if (other.ConnectId != 0) {
        ConnectId = other.ConnectId;
      }
      if (other.Datas.Length != 0) {
        Datas = other.Datas;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ModeType = input.ReadString();
            break;
          }
          case 16: {
            Uid = input.ReadInt32();
            break;
          }
          case 26: {
            MsgType = input.ReadString();
            break;
          }
          case 32: {
            ConnectId = input.ReadInt32();
            break;
          }
          case 42: {
            Datas = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MsgRegisterToGate : pb::IMessage<MsgRegisterToGate> {
    private static readonly pb::MessageParser<MsgRegisterToGate> _parser = new pb::MessageParser<MsgRegisterToGate>(() => new MsgRegisterToGate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MsgRegisterToGate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protomsg.MsgReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgRegisterToGate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgRegisterToGate(MsgRegisterToGate other) : this() {
      modeType_ = other.modeType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MsgRegisterToGate Clone() {
      return new MsgRegisterToGate(this);
    }

    /// <summary>Field number for the "ModeType" field.</summary>
    public const int ModeTypeFieldNumber = 1;
    private string modeType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModeType {
      get { return modeType_; }
      set {
        modeType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MsgRegisterToGate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MsgRegisterToGate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModeType != other.ModeType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ModeType.Length != 0) hash ^= ModeType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ModeType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ModeType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ModeType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModeType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MsgRegisterToGate other) {
      if (other == null) {
        return;
      }
      if (other.ModeType.Length != 0) {
        ModeType = other.ModeType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ModeType = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CS_MsgQuickLogin : pb::IMessage<CS_MsgQuickLogin> {
    private static readonly pb::MessageParser<CS_MsgQuickLogin> _parser = new pb::MessageParser<CS_MsgQuickLogin>(() => new CS_MsgQuickLogin());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CS_MsgQuickLogin> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protomsg.MsgReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_MsgQuickLogin() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_MsgQuickLogin(CS_MsgQuickLogin other) : this() {
      platform_ = other.platform_;
      machineid_ = other.machineid_;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_MsgQuickLogin Clone() {
      return new CS_MsgQuickLogin(this);
    }

    /// <summary>Field number for the "Platform" field.</summary>
    public const int PlatformFieldNumber = 1;
    private string platform_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Platform {
      get { return platform_; }
      set {
        platform_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Machineid" field.</summary>
    public const int MachineidFieldNumber = 2;
    private string machineid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Machineid {
      get { return machineid_; }
      set {
        machineid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CS_MsgQuickLogin);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CS_MsgQuickLogin other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Platform != other.Platform) return false;
      if (Machineid != other.Machineid) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Platform.Length != 0) hash ^= Platform.GetHashCode();
      if (Machineid.Length != 0) hash ^= Machineid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Platform.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Platform);
      }
      if (Machineid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Machineid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Platform.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Platform);
      }
      if (Machineid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Machineid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CS_MsgQuickLogin other) {
      if (other == null) {
        return;
      }
      if (other.Platform.Length != 0) {
        Platform = other.Platform;
      }
      if (other.Machineid.Length != 0) {
        Machineid = other.Machineid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Platform = input.ReadString();
            break;
          }
          case 18: {
            Machineid = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CS_Login : pb::IMessage<CS_Login> {
    private static readonly pb::MessageParser<CS_Login> _parser = new pb::MessageParser<CS_Login>(() => new CS_Login());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CS_Login> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protomsg.MsgReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_Login() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_Login(CS_Login other) : this() {
      phonenumber_ = other.phonenumber_;
      platform_ = other.platform_;
      machineid_ = other.machineid_;
      wechatId_ = other.wechatId_;
      qQId_ = other.qQId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CS_Login Clone() {
      return new CS_Login(this);
    }

    /// <summary>Field number for the "Phonenumber" field.</summary>
    public const int PhonenumberFieldNumber = 1;
    private string phonenumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Phonenumber {
      get { return phonenumber_; }
      set {
        phonenumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Platform" field.</summary>
    public const int PlatformFieldNumber = 2;
    private string platform_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Platform {
      get { return platform_; }
      set {
        platform_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Machineid" field.</summary>
    public const int MachineidFieldNumber = 3;
    private string machineid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Machineid {
      get { return machineid_; }
      set {
        machineid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Wechat_id" field.</summary>
    public const int WechatIdFieldNumber = 4;
    private string wechatId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string WechatId {
      get { return wechatId_; }
      set {
        wechatId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "QQ_id" field.</summary>
    public const int QQIdFieldNumber = 5;
    private string qQId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string QQId {
      get { return qQId_; }
      set {
        qQId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CS_Login);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CS_Login other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Phonenumber != other.Phonenumber) return false;
      if (Platform != other.Platform) return false;
      if (Machineid != other.Machineid) return false;
      if (WechatId != other.WechatId) return false;
      if (QQId != other.QQId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Phonenumber.Length != 0) hash ^= Phonenumber.GetHashCode();
      if (Platform.Length != 0) hash ^= Platform.GetHashCode();
      if (Machineid.Length != 0) hash ^= Machineid.GetHashCode();
      if (WechatId.Length != 0) hash ^= WechatId.GetHashCode();
      if (QQId.Length != 0) hash ^= QQId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Phonenumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Phonenumber);
      }
      if (Platform.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Platform);
      }
      if (Machineid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Machineid);
      }
      if (WechatId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(WechatId);
      }
      if (QQId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(QQId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Phonenumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Phonenumber);
      }
      if (Platform.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Platform);
      }
      if (Machineid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Machineid);
      }
      if (WechatId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(WechatId);
      }
      if (QQId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QQId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CS_Login other) {
      if (other == null) {
        return;
      }
      if (other.Phonenumber.Length != 0) {
        Phonenumber = other.Phonenumber;
      }
      if (other.Platform.Length != 0) {
        Platform = other.Platform;
      }
      if (other.Machineid.Length != 0) {
        Machineid = other.Machineid;
      }
      if (other.WechatId.Length != 0) {
        WechatId = other.WechatId;
      }
      if (other.QQId.Length != 0) {
        QQId = other.QQId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Phonenumber = input.ReadString();
            break;
          }
          case 18: {
            Platform = input.ReadString();
            break;
          }
          case 26: {
            Machineid = input.ReadString();
            break;
          }
          case 34: {
            WechatId = input.ReadString();
            break;
          }
          case 42: {
            QQId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
