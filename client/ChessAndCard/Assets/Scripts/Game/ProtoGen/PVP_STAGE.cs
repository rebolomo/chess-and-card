//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: pvp_stage.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVP_STAGE")]
  public partial class PVP_STAGE : global::ProtoBuf.IExtensible
  {
    public PVP_STAGE() {}
    
    private int _index;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _recommand_fight = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"recommand_fight", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int recommand_fight
    {
      get { return _recommand_fight; }
      set { _recommand_fight = value; }
    }
    private int _res_id = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"res_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int res_id
    {
      get { return _res_id; }
      set { _res_id = value; }
    }
    private string _chess_bg = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"chess_bg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chess_bg
    {
      get { return _chess_bg; }
      set { _chess_bg = value; }
    }
    private string _chess_small_bg = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"chess_small_bg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chess_small_bg
    {
      get { return _chess_small_bg; }
      set { _chess_small_bg = value; }
    }
    private string _speed = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"speed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string speed
    {
      get { return _speed; }
      set { _speed = value; }
    }
    private string _clip_copy = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"clip_copy", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clip_copy
    {
      get { return _clip_copy; }
      set { _clip_copy = value; }
    }
    private int _chess_id = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"chess_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int chess_id
    {
      get { return _chess_id; }
      set { _chess_id = value; }
    }
    private int _step_limit = (int)0;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"step_limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int step_limit
    {
      get { return _step_limit; }
      set { _step_limit = value; }
    }
    private string _fractional_segment = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"fractional_segment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fractional_segment
    {
      get { return _fractional_segment; }
      set { _fractional_segment = value; }
    }
    private string _scene_config = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"scene_config", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string scene_config
    {
      get { return _scene_config; }
      set { _scene_config = value; }
    }
    private string _monster_config = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"monster_config", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string monster_config
    {
      get { return _monster_config; }
      set { _monster_config = value; }
    }
    private string _monster_show_list = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"monster_show_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string monster_show_list
    {
      get { return _monster_show_list; }
      set { _monster_show_list = value; }
    }
    private string _monster_show_boss = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"monster_show_boss", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string monster_show_boss
    {
      get { return _monster_show_boss; }
      set { _monster_show_boss = value; }
    }
    private int _the_screen = (int)0;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"the_screen", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int the_screen
    {
      get { return _the_screen; }
      set { _the_screen = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVP_STAGE_ARRAY")]
  public partial class PVP_STAGE_ARRAY : global::ProtoBuf.IExtensible
  {
    public PVP_STAGE_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.PVP_STAGE> _items = new global::System.Collections.Generic.List<deploy.PVP_STAGE>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.PVP_STAGE> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}