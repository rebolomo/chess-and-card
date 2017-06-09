//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SignMsg.proto
namespace SignMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SSigninInfo")]
  public partial class C2SSigninInfo : global::ProtoBuf.IExtensible
  {
    public C2SSigninInfo() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CSigninInfo")]
  public partial class S2CSigninInfo : global::ProtoBuf.IExtensible
  {
    public S2CSigninInfo() {}
    
    private int _signinDays;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"signinDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int signinDays
    {
      get { return _signinDays; }
      set { _signinDays = value; }
    }
    private int _todaySignin;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"todaySignin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int todaySignin
    {
      get { return _todaySignin; }
      set { _todaySignin = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SSigninToday")]
  public partial class C2SSigninToday : global::ProtoBuf.IExtensible
  {
    public C2SSigninToday() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CSigninToday")]
  public partial class S2CSigninToday : global::ProtoBuf.IExtensible
  {
    public S2CSigninToday() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private int _signinDays;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"signinDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int signinDays
    {
      get { return _signinDays; }
      set { _signinDays = value; }
    }
    private int _todaySignin;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"todaySignin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int todaySignin
    {
      get { return _todaySignin; }
      set { _todaySignin = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SCumulativeSiginInfo")]
  public partial class C2SCumulativeSiginInfo : global::ProtoBuf.IExtensible
  {
    public C2SCumulativeSiginInfo() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CCumulativeSiginInfo")]
  public partial class S2CCumulativeSiginInfo : global::ProtoBuf.IExtensible
  {
    public S2CCumulativeSiginInfo() {}
    
    private int _cumulativeSiginDays;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"cumulativeSiginDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int cumulativeSiginDays
    {
      get { return _cumulativeSiginDays; }
      set { _cumulativeSiginDays = value; }
    }
    private int _status;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private int _turnsId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"turnsId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int turnsId
    {
      get { return _turnsId; }
      set { _turnsId = value; }
    }
    private int _historySiginDays;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"historySiginDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int historySiginDays
    {
      get { return _historySiginDays; }
      set { _historySiginDays = value; }
    }
    private int _realTurnsId;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"realTurnsId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int realTurnsId
    {
      get { return _realTurnsId; }
      set { _realTurnsId = value; }
    }
    private int _needSiginDays;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"needSiginDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int needSiginDays
    {
      get { return _needSiginDays; }
      set { _needSiginDays = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SDrawCumulativeSigin")]
  public partial class C2SDrawCumulativeSigin : global::ProtoBuf.IExtensible
  {
    public C2SDrawCumulativeSigin() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CDrawCumulativeSigin")]
  public partial class S2CDrawCumulativeSigin : global::ProtoBuf.IExtensible
  {
    public S2CDrawCumulativeSigin() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SNewPlayerGoodieBag")]
  public partial class C2SNewPlayerGoodieBag : global::ProtoBuf.IExtensible
  {
    public C2SNewPlayerGoodieBag() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CRefluxRewards")]
  public partial class S2CRefluxRewards : global::ProtoBuf.IExtensible
  {
    public S2CRefluxRewards() {}
    
    private int _day;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"day", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int day
    {
      get { return _day; }
      set { _day = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SDrawRefluxRewards")]
  public partial class C2SDrawRefluxRewards : global::ProtoBuf.IExtensible
  {
    public C2SDrawRefluxRewards() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CDrawRefluxRewards")]
  public partial class S2CDrawRefluxRewards : global::ProtoBuf.IExtensible
  {
    public S2CDrawRefluxRewards() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}