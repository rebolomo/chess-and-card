//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: hero_type.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HERO_TYPE")]
  public partial class HERO_TYPE : global::ProtoBuf.IExtensible
  {
    public HERO_TYPE() {}
    
    private int _type_id = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }
    private string _desc = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private string _ioc = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ioc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ioc
    {
      get { return _ioc; }
      set { _ioc = value; }
    }
    private string _ioc_title = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ioc_title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ioc_title
    {
      get { return _ioc_title; }
      set { _ioc_title = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HERO_TYPE_ARRAY")]
  public partial class HERO_TYPE_ARRAY : global::ProtoBuf.IExtensible
  {
    public HERO_TYPE_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.HERO_TYPE> _items = new global::System.Collections.Generic.List<deploy.HERO_TYPE>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.HERO_TYPE> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}