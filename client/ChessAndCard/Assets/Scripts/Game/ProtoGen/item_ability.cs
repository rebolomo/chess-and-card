//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: item_ability.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ITEM_ABILITY")]
  public partial class ITEM_ABILITY : global::ProtoBuf.IExtensible
  {
    public ITEM_ABILITY() {}
    
    private int _ability_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ability_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ability_id
    {
      get { return _ability_id; }
      set { _ability_id = value; }
    }
    private int _range;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"range", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int range
    {
      get { return _range; }
      set { _range = value; }
    }
    private int _count_up;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"count_up", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int count_up
    {
      get { return _count_up; }
      set { _count_up = value; }
    }
    private int _start_random_4xiao;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"start_random_4xiao", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int start_random_4xiao
    {
      get { return _start_random_4xiao; }
      set { _start_random_4xiao = value; }
    }
    private int _start_random_dazhao;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"start_random_dazhao", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int start_random_dazhao
    {
      get { return _start_random_dazhao; }
      set { _start_random_dazhao = value; }
    }
    private int _fraction_up;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"fraction_up", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fraction_up
    {
      get { return _fraction_up; }
      set { _fraction_up = value; }
    }
    private string _random_item;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"random_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string random_item
    {
      get { return _random_item; }
      set { _random_item = value; }
    }
    private int _add_4xiao;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"add_4xiao", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int add_4xiao
    {
      get { return _add_4xiao; }
      set { _add_4xiao = value; }
    }
    private int _hammer;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"hammer", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hammer
    {
      get { return _hammer; }
      set { _hammer = value; }
    }
    private int _exchange;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"exchange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int exchange
    {
      get { return _exchange; }
      set { _exchange = value; }
    }
    private int _again;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"again", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int again
    {
      get { return _again; }
      set { _again = value; }
    }
    private int _limit;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int limit
    {
      get { return _limit; }
      set { _limit = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ITEM_ABILITY_ARRAY")]
  public partial class ITEM_ABILITY_ARRAY : global::ProtoBuf.IExtensible
  {
    public ITEM_ABILITY_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.ITEM_ABILITY> _items = new global::System.Collections.Generic.List<deploy.ITEM_ABILITY>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.ITEM_ABILITY> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}