//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: box.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BOX")]
  public partial class BOX : global::ProtoBuf.IExtensible
  {
    public BOX() {}
    
    private int _box_id = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"box_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int box_id
    {
      get { return _box_id; }
      set { _box_id = value; }
    }
    private int _box_name = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"box_name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int box_name
    {
      get { return _box_name; }
      set { _box_name = value; }
    }
    private string _gold_fluctuation = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"gold_fluctuation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gold_fluctuation
    {
      get { return _gold_fluctuation; }
      set { _gold_fluctuation = value; }
    }
    private string _diamond_wave = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"diamond_wave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string diamond_wave
    {
      get { return _diamond_wave; }
      set { _diamond_wave = value; }
    }
    private string _item_reward = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"item_reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string item_reward
    {
      get { return _item_reward; }
      set { _item_reward = value; }
    }
    private string _item_reward_number_wave = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"item_reward_number_wave", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string item_reward_number_wave
    {
      get { return _item_reward_number_wave; }
      set { _item_reward_number_wave = value; }
    }
    private int _generals_reward_amount = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"generals_reward_amount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int generals_reward_amount
    {
      get { return _generals_reward_amount; }
      set { _generals_reward_amount = value; }
    }
    private int _generals_type_amount = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"generals_type_amount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int generals_type_amount
    {
      get { return _generals_type_amount; }
      set { _generals_type_amount = value; }
    }
    private string _amount1 = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"amount1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string amount1
    {
      get { return _amount1; }
      set { _amount1 = value; }
    }
    private string _amount2 = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"amount2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string amount2
    {
      get { return _amount2; }
      set { _amount2 = value; }
    }
    private string _rare_amount = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"rare_amount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string rare_amount
    {
      get { return _rare_amount; }
      set { _rare_amount = value; }
    }
    private string _epic_amount = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"epic_amount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string epic_amount
    {
      get { return _epic_amount; }
      set { _epic_amount = value; }
    }
    private string _legend_amount = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"legend_amount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string legend_amount
    {
      get { return _legend_amount; }
      set { _legend_amount = value; }
    }
    private string _ordinary_hero = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ordinary_hero", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ordinary_hero
    {
      get { return _ordinary_hero; }
      set { _ordinary_hero = value; }
    }
    private string _rare_hero = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"rare_hero", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string rare_hero
    {
      get { return _rare_hero; }
      set { _rare_hero = value; }
    }
    private string _epic_hero = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"epic_hero", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string epic_hero
    {
      get { return _epic_hero; }
      set { _epic_hero = value; }
    }
    private string _legend_hero = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"legend_hero", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string legend_hero
    {
      get { return _legend_hero; }
      set { _legend_hero = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BOX_ARRAY")]
  public partial class BOX_ARRAY : global::ProtoBuf.IExtensible
  {
    public BOX_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.BOX> _items = new global::System.Collections.Generic.List<deploy.BOX>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.BOX> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}