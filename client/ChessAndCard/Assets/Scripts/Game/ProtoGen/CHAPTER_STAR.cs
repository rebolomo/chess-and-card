//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: chapter_star.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHAPTER_STAR")]
  public partial class CHAPTER_STAR : global::ProtoBuf.IExtensible
  {
    public CHAPTER_STAR() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _chapterId = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"chapterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int chapterId
    {
      get { return _chapterId; }
      set { _chapterId = value; }
    }
    private int _start = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"start", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int start
    {
      get { return _start; }
      set { _start = value; }
    }
    private int _end = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"end", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int end
    {
      get { return _end; }
      set { _end = value; }
    }
    private int _xingxing = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"xingxing", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int xingxing
    {
      get { return _xingxing; }
      set { _xingxing = value; }
    }
    private int _box_type = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"box_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int box_type
    {
      get { return _box_type; }
      set { _box_type = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CHAPTER_STAR_ARRAY")]
  public partial class CHAPTER_STAR_ARRAY : global::ProtoBuf.IExtensible
  {
    public CHAPTER_STAR_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.CHAPTER_STAR> _items = new global::System.Collections.Generic.List<deploy.CHAPTER_STAR>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.CHAPTER_STAR> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}