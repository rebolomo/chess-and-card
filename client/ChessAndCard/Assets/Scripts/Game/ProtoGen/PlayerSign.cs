//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PlayerSign.proto
// Note: requires additional types generated from: GuildMsg.proto
using GuildMsg;
namespace PlayerSign
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SCumulativeSigin")]
  public partial class C2SCumulativeSigin : global::ProtoBuf.IExtensible
  {
    public C2SCumulativeSigin() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CCumulativeSigin")]
  public partial class S2CCumulativeSigin : global::ProtoBuf.IExtensible
  {
    public S2CCumulativeSigin() {}
    
    private int _cumulativeSiginDays;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"cumulativeSiginDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int cumulativeSiginDays
    {
      get { return _cumulativeSiginDays; }
      set { _cumulativeSiginDays = value; }
    }
    private bool _status;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SLogonReceive")]
  public partial class C2SLogonReceive : global::ProtoBuf.IExtensible
  {
    public C2SLogonReceive() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CLogonReceive")]
  public partial class S2CLogonReceive : global::ProtoBuf.IExtensible
  {
    public S2CLogonReceive() {}
    
    private int _result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<LogonBoxCardInfo> _Infos = new global::System.Collections.Generic.List<LogonBoxCardInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Infos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<LogonBoxCardInfo> Infos
    {
      get { return _Infos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LogonBoxCardInfo")]
  public partial class LogonBoxCardInfo : global::ProtoBuf.IExtensible
  {
    public LogonBoxCardInfo() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private Item _item;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Item item
    {
      get { return _item; }
      set { _item = value; }
    }
    private int _heroId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"heroId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int heroId
    {
      get { return _heroId; }
      set { _heroId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}