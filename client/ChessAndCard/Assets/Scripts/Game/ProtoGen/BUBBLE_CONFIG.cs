//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: bubble_config.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BUBBLE_CONFIG")]
  public partial class BUBBLE_CONFIG : global::ProtoBuf.IExtensible
  {
    public BUBBLE_CONFIG() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _monsterid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"monsterid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int monsterid
    {
      get { return _monsterid; }
      set { _monsterid = value; }
    }
    private int _buff_type = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"buff_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int buff_type
    {
      get { return _buff_type; }
      set { _buff_type = value; }
    }
    private int _stageid = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"stageid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int stageid
    {
      get { return _stageid; }
      set { _stageid = value; }
    }
    private int _round = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"round", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int round
    {
      get { return _round; }
      set { _round = value; }
    }
    private string _content = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private int _type;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _facetype = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"facetype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int facetype
    {
      get { return _facetype; }
      set { _facetype = value; }
    }
    private int _localpos;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"localpos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int localpos
    {
      get { return _localpos; }
      set { _localpos = value; }
    }
    private int _destorytype;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"destorytype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int destorytype
    {
      get { return _destorytype; }
      set { _destorytype = value; }
    }
    private string _arg = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"arg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string arg
    {
      get { return _arg; }
      set { _arg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BUBBLE_CONFIG_ARRAY")]
  public partial class BUBBLE_CONFIG_ARRAY : global::ProtoBuf.IExtensible
  {
    public BUBBLE_CONFIG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.BUBBLE_CONFIG> _items = new global::System.Collections.Generic.List<deploy.BUBBLE_CONFIG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.BUBBLE_CONFIG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}