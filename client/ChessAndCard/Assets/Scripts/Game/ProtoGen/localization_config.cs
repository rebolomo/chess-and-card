//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: localization_config.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LOCALIZATION_CONFIG")]
  public partial class LOCALIZATION_CONFIG : global::ProtoBuf.IExtensible
  {
    public LOCALIZATION_CONFIG() {}
    
    private string _key;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }
    private string _chinese = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"chinese", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chinese
    {
      get { return _chinese; }
      set { _chinese = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LOCALIZATION_CONFIG_ARRAY")]
  public partial class LOCALIZATION_CONFIG_ARRAY : global::ProtoBuf.IExtensible
  {
    public LOCALIZATION_CONFIG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.LOCALIZATION_CONFIG> _items = new global::System.Collections.Generic.List<deploy.LOCALIZATION_CONFIG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.LOCALIZATION_CONFIG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}