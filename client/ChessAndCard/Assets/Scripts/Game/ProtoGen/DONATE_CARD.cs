//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: donate_card.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DONATE_CARD")]
  public partial class DONATE_CARD : global::ProtoBuf.IExtensible
  {
    public DONATE_CARD() {}
    
    private int _arena_rank_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"arena_rank_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int arena_rank_id
    {
      get { return _arena_rank_id; }
      set { _arena_rank_id = value; }
    }
    private int _donate_limit = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"donate_limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int donate_limit
    {
      get { return _donate_limit; }
      set { _donate_limit = value; }
    }
    private string _donate_card = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"donate_card", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string donate_card
    {
      get { return _donate_card; }
      set { _donate_card = value; }
    }
    private string _need_card = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"need_card", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string need_card
    {
      get { return _need_card; }
      set { _need_card = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DONATE_CARD_ARRAY")]
  public partial class DONATE_CARD_ARRAY : global::ProtoBuf.IExtensible
  {
    public DONATE_CARD_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.DONATE_CARD> _items = new global::System.Collections.Generic.List<deploy.DONATE_CARD>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.DONATE_CARD> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}