//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: skillconfig.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SKILLCONFIG")]
  public partial class SKILLCONFIG : global::ProtoBuf.IExtensible
  {
    public SKILLCONFIG() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _type = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private int _next_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"next_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int next_id
    {
      get { return _next_id; }
      set { _next_id = value; }
    }
    private int _default_next_id;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"default_next_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int default_next_id
    {
      get { return _default_next_id; }
      set { _default_next_id = value; }
    }
    private int _default_return_id;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"default_return_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int default_return_id
    {
      get { return _default_return_id; }
      set { _default_return_id = value; }
    }
    private int _default_behit_id;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"default_behit_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int default_behit_id
    {
      get { return _default_behit_id; }
      set { _default_behit_id = value; }
    }
    private int _default_becrit_id;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"default_becrit_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int default_becrit_id
    {
      get { return _default_becrit_id; }
      set { _default_becrit_id = value; }
    }
    private int _state = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int state
    {
      get { return _state; }
      set { _state = value; }
    }
    private int _mutex = (int)0;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"mutex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int mutex
    {
      get { return _mutex; }
      set { _mutex = value; }
    }
    private int _priority = (int)0;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int priority
    {
      get { return _priority; }
      set { _priority = value; }
    }
    private int _damage_type = (int)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"damage_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int damage_type
    {
      get { return _damage_type; }
      set { _damage_type = value; }
    }
    private int _switch_skill_id;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"switch_skill_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int switch_skill_id
    {
      get { return _switch_skill_id; }
      set { _switch_skill_id = value; }
    }
    private int _skill_count_type = (int)0;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"skill_count_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int skill_count_type
    {
      get { return _skill_count_type; }
      set { _skill_count_type = value; }
    }
    private int _effect_type = (int)0;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"effect_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int effect_type
    {
      get { return _effect_type; }
      set { _effect_type = value; }
    }
    private string _offset_position = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"offset_position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string offset_position
    {
      get { return _offset_position; }
      set { _offset_position = value; }
    }
    private int _attr_id;
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"attr_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attr_id
    {
      get { return _attr_id; }
      set { _attr_id = value; }
    }
    private string _anim_id = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"anim_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string anim_id
    {
      get { return _anim_id; }
      set { _anim_id = value; }
    }
    private int _anim_crossfade = (int)0;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"anim_crossfade", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int anim_crossfade
    {
      get { return _anim_crossfade; }
      set { _anim_crossfade = value; }
    }
    private string _effect_id = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"effect_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string effect_id
    {
      get { return _effect_id; }
      set { _effect_id = value; }
    }
    private string _audio_id = "";
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"audio_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string audio_id
    {
      get { return _audio_id; }
      set { _audio_id = value; }
    }
    private int _audio_frame = (int)0;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"audio_frame", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int audio_frame
    {
      get { return _audio_frame; }
      set { _audio_frame = value; }
    }
    private int _effect_frame = (int)0;
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"effect_frame", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int effect_frame
    {
      get { return _effect_frame; }
      set { _effect_frame = value; }
    }
    private string _switch_skill_frame = "";
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"switch_skill_frame", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string switch_skill_frame
    {
      get { return _switch_skill_frame; }
      set { _switch_skill_frame = value; }
    }
    private string _damage_frame = "";
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"damage_frame", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string damage_frame
    {
      get { return _damage_frame; }
      set { _damage_frame = value; }
    }
    private float _hud_delay_time = (float)0;
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"hud_delay_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float hud_delay_time
    {
      get { return _hud_delay_time; }
      set { _hud_delay_time = value; }
    }
    private int _move_frame = (int)0;
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"move_frame", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int move_frame
    {
      get { return _move_frame; }
      set { _move_frame = value; }
    }
    private int _camera_shake_frame = (int)0;
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"camera_shake_frame", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int camera_shake_frame
    {
      get { return _camera_shake_frame; }
      set { _camera_shake_frame = value; }
    }
    private int _move_trail_type = (int)0;
    [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"move_trail_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int move_trail_type
    {
      get { return _move_trail_type; }
      set { _move_trail_type = value; }
    }
    private float _move_time = (float)0;
    [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"move_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float move_time
    {
      get { return _move_time; }
      set { _move_time = value; }
    }
    private string _effect_point = "";
    [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"effect_point", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string effect_point
    {
      get { return _effect_point; }
      set { _effect_point = value; }
    }
    private string _begin_position = "";
    [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"begin_position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string begin_position
    {
      get { return _begin_position; }
      set { _begin_position = value; }
    }
    private string _target_position = "";
    [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"target_position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string target_position
    {
      get { return _target_position; }
      set { _target_position = value; }
    }
    private int _range_type = (int)0;
    [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"range_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int range_type
    {
      get { return _range_type; }
      set { _range_type = value; }
    }
    private float _effect_loop_count = (float)0;
    [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"effect_loop_count", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float effect_loop_count
    {
      get { return _effect_loop_count; }
      set { _effect_loop_count = value; }
    }
    private float _effect_time = (float)0;
    [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"effect_time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float effect_time
    {
      get { return _effect_time; }
      set { _effect_time = value; }
    }
    private int _effect_time_control_type = (int)0;
    [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"effect_time_control_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int effect_time_control_type
    {
      get { return _effect_time_control_type; }
      set { _effect_time_control_type = value; }
    }
    private int _gost_count = (int)0;
    [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"gost_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int gost_count
    {
      get { return _gost_count; }
      set { _gost_count = value; }
    }
    private int _actor_visible = (int)0;
    [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"actor_visible", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int actor_visible
    {
      get { return _actor_visible; }
      set { _actor_visible = value; }
    }
    private int _rotate_type = (int)0;
    [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"rotate_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int rotate_type
    {
      get { return _rotate_type; }
      set { _rotate_type = value; }
    }
    private int _camera_control_id = (int)0;
    [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"camera_control_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int camera_control_id
    {
      get { return _camera_control_id; }
      set { _camera_control_id = value; }
    }
    private int _camera_shake_id = (int)0;
    [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"camera_shake_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int camera_shake_id
    {
      get { return _camera_shake_id; }
      set { _camera_shake_id = value; }
    }
    private int _effect_lookat = (int)0;
    [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"effect_lookat", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int effect_lookat
    {
      get { return _effect_lookat; }
      set { _effect_lookat = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SKILLCONFIG_ARRAY")]
  public partial class SKILLCONFIG_ARRAY : global::ProtoBuf.IExtensible
  {
    public SKILLCONFIG_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.SKILLCONFIG> _items = new global::System.Collections.Generic.List<deploy.SKILLCONFIG>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.SKILLCONFIG> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}