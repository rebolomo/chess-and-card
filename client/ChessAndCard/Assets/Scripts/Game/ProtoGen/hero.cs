//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: hero.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HERO")]
  public partial class HERO : global::ProtoBuf.IExtensible
  {
    public HERO() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _hero_res = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"hero_res", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_res
    {
      get { return _hero_res; }
      set { _hero_res = value; }
    }
    private int _hero_name = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"hero_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int hero_name
    {
      get { return _hero_name; }
      set { _hero_name = value; }
    }
    private int _hero_quality = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hero_quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int hero_quality
    {
      get { return _hero_quality; }
      set { _hero_quality = value; }
    }
    private int _card_id = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"card_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int card_id
    {
      get { return _card_id; }
      set { _card_id = value; }
    }
    private int _fangdashuxing_shengming = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"fangdashuxing_shengming", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int fangdashuxing_shengming
    {
      get { return _fangdashuxing_shengming; }
      set { _fangdashuxing_shengming = value; }
    }
    private int _soul_stone = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"soul_stone", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int soul_stone
    {
      get { return _soul_stone; }
      set { _soul_stone = value; }
    }
    private int _open_level = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"open_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int open_level
    {
      get { return _open_level; }
      set { _open_level = value; }
    }
    private int _hero_title = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"hero_title", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int hero_title
    {
      get { return _hero_title; }
      set { _hero_title = value; }
    }
    private string _hero_tu = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"hero_tu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_tu
    {
      get { return _hero_tu; }
      set { _hero_tu = value; }
    }
    private string _hero_icon = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"hero_icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_icon
    {
      get { return _hero_icon; }
      set { _hero_icon = value; }
    }
    private int _position = (int)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int position
    {
      get { return _position; }
      set { _position = value; }
    }
    private int _hero_desc = (int)0;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"hero_desc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int hero_desc
    {
      get { return _hero_desc; }
      set { _hero_desc = value; }
    }
    private string _hero_dialog = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"hero_dialog", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_dialog
    {
      get { return _hero_dialog; }
      set { _hero_dialog = value; }
    }
    private string _general_location = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"general_location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string general_location
    {
      get { return _general_location; }
      set { _general_location = value; }
    }
    private int _herotype = (int)0;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"herotype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int herotype
    {
      get { return _herotype; }
      set { _herotype = value; }
    }
    private int _main_type = (int)0;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"main_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int main_type
    {
      get { return _main_type; }
      set { _main_type = value; }
    }
    private int _group = (int)0;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"group", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int group
    {
      get { return _group; }
      set { _group = value; }
    }
    private int _gender = (int)0;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"gender", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int gender
    {
      get { return _gender; }
      set { _gender = value; }
    }
    private int _attribute = (int)0;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"attribute", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int attribute
    {
      get { return _attribute; }
      set { _attribute = value; }
    }
    private string _initequip = "";
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"initequip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string initequip
    {
      get { return _initequip; }
      set { _initequip = value; }
    }
    private string _active_skill = "";
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"active_skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string active_skill
    {
      get { return _active_skill; }
      set { _active_skill = value; }
    }
    private string _passive_skill = "";
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"passive_skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string passive_skill
    {
      get { return _passive_skill; }
      set { _passive_skill = value; }
    }
    private int _juiaoxue_wujiang;
    [global::ProtoBuf.ProtoMember(24, IsRequired = true, Name=@"juiaoxue_wujiang", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int juiaoxue_wujiang
    {
      get { return _juiaoxue_wujiang; }
      set { _juiaoxue_wujiang = value; }
    }
    private string _hero_Img = "";
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"hero_Img", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_Img
    {
      get { return _hero_Img; }
      set { _hero_Img = value; }
    }
    private int _content_title = (int)0;
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"content_title", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int content_title
    {
      get { return _content_title; }
      set { _content_title = value; }
    }
    private int _content = (int)0;
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int content
    {
      get { return _content; }
      set { _content = value; }
    }
    private string _hero_link = "";
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"hero_link", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hero_link
    {
      get { return _hero_link; }
      set { _hero_link = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HERO_ARRAY")]
  public partial class HERO_ARRAY : global::ProtoBuf.IExtensible
  {
    public HERO_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.HERO> _items = new global::System.Collections.Generic.List<deploy.HERO>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.HERO> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}