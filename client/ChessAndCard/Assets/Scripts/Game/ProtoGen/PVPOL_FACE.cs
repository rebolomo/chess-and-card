//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: pvpol_face.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVPOL_FACE")]
  public partial class PVPOL_FACE : global::ProtoBuf.IExtensible
  {
    public PVPOL_FACE() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _type = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private string _content = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVPOL_FACE_ARRAY")]
  public partial class PVPOL_FACE_ARRAY : global::ProtoBuf.IExtensible
  {
    public PVPOL_FACE_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.PVPOL_FACE> _items = new global::System.Collections.Generic.List<deploy.PVPOL_FACE>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.PVPOL_FACE> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}