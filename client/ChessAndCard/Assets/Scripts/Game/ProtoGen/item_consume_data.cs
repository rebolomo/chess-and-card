//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: item_consume_data.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ITEM_CONSUME_DATA")]
  public partial class ITEM_CONSUME_DATA : global::ProtoBuf.IExtensible
  {
    public ITEM_CONSUME_DATA() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _repeated_use_flag = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"repeated_use_flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int repeated_use_flag
    {
      get { return _repeated_use_flag; }
      set { _repeated_use_flag = value; }
    }
    private int _index;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private deploy.ITEM_CONSUME_DATA.ItemConsume _ItemConsumeTable = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ItemConsumeTable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public deploy.ITEM_CONSUME_DATA.ItemConsume ItemConsumeTable
    {
      get { return _ItemConsumeTable; }
      set { _ItemConsumeTable = value; }
    }
    private int _cost = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"cost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int cost
    {
      get { return _cost; }
      set { _cost = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemConsume")]
  public partial class ItemConsume : global::ProtoBuf.IExtensible
  {
    public ItemConsume() {}
    
    private int _type = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _value = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int value
    {
      get { return _value; }
      set { _value = value; }
    }
    private int _tips = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"tips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int tips
    {
      get { return _tips; }
      set { _tips = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ITEM_CONSUME_DATA_ARRAY")]
  public partial class ITEM_CONSUME_DATA_ARRAY : global::ProtoBuf.IExtensible
  {
    public ITEM_CONSUME_DATA_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.ITEM_CONSUME_DATA> _items = new global::System.Collections.Generic.List<deploy.ITEM_CONSUME_DATA>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.ITEM_CONSUME_DATA> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}