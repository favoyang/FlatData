// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatBufferGenerated.Worldreaver.Idle.User
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct UserProfile : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static UserProfile GetRootAsUserProfile(ByteBuffer _bb) { return GetRootAsUserProfile(_bb, new UserProfile()); }
  public static UserProfile GetRootAsUserProfile(ByteBuffer _bb, UserProfile obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public UserProfile __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Id { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetIdArray() { return __p.__vector_as_array<byte>(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CurrentExp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string SoftCurrency { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSoftCurrencyBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetSoftCurrencyBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetSoftCurrencyArray() { return __p.__vector_as_array<byte>(12); }
  public string HardCurrency { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetHardCurrencyBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetHardCurrencyBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetHardCurrencyArray() { return __p.__vector_as_array<byte>(14); }
  public string MilkCurrency { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMilkCurrencyBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetMilkCurrencyBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetMilkCurrencyArray() { return __p.__vector_as_array<byte>(16); }
  public int Revolution { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatBufferGenerated.Worldreaver.Idle.User.UserProfile> CreateUserProfile(FlatBufferBuilder builder,
      StringOffset IdOffset = default(StringOffset),
      StringOffset NameOffset = default(StringOffset),
      int Level = 0,
      int CurrentExp = 0,
      StringOffset SoftCurrencyOffset = default(StringOffset),
      StringOffset HardCurrencyOffset = default(StringOffset),
      StringOffset MilkCurrencyOffset = default(StringOffset),
      int Revolution = 0) {
    builder.StartTable(8);
    UserProfile.AddRevolution(builder, Revolution);
    UserProfile.AddMilkCurrency(builder, MilkCurrencyOffset);
    UserProfile.AddHardCurrency(builder, HardCurrencyOffset);
    UserProfile.AddSoftCurrency(builder, SoftCurrencyOffset);
    UserProfile.AddCurrentExp(builder, CurrentExp);
    UserProfile.AddLevel(builder, Level);
    UserProfile.AddName(builder, NameOffset);
    UserProfile.AddId(builder, IdOffset);
    return UserProfile.EndUserProfile(builder);
  }

  public static void StartUserProfile(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, StringOffset IdOffset) { builder.AddOffset(0, IdOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(2, Level, 0); }
  public static void AddCurrentExp(FlatBufferBuilder builder, int CurrentExp) { builder.AddInt(3, CurrentExp, 0); }
  public static void AddSoftCurrency(FlatBufferBuilder builder, StringOffset SoftCurrencyOffset) { builder.AddOffset(4, SoftCurrencyOffset.Value, 0); }
  public static void AddHardCurrency(FlatBufferBuilder builder, StringOffset HardCurrencyOffset) { builder.AddOffset(5, HardCurrencyOffset.Value, 0); }
  public static void AddMilkCurrency(FlatBufferBuilder builder, StringOffset MilkCurrencyOffset) { builder.AddOffset(6, MilkCurrencyOffset.Value, 0); }
  public static void AddRevolution(FlatBufferBuilder builder, int Revolution) { builder.AddInt(7, Revolution, 0); }
  public static Offset<FlatBufferGenerated.Worldreaver.Idle.User.UserProfile> EndUserProfile(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatBufferGenerated.Worldreaver.Idle.User.UserProfile>(o);
  }
  public UserProfileT UnPack() {
    var _o = new UserProfileT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(UserProfileT _o) {
    _o.Id = this.Id;
    _o.Name = this.Name;
    _o.Level = this.Level;
    _o.CurrentExp = this.CurrentExp;
    _o.SoftCurrency = this.SoftCurrency;
    _o.HardCurrency = this.HardCurrency;
    _o.MilkCurrency = this.MilkCurrency;
    _o.Revolution = this.Revolution;
  }
  public static Offset<FlatBufferGenerated.Worldreaver.Idle.User.UserProfile> Pack(FlatBufferBuilder builder, UserProfileT _o) {
    if (_o == null) return default(Offset<FlatBufferGenerated.Worldreaver.Idle.User.UserProfile>);
    var _Id = _o.Id == null ? default(StringOffset) : builder.CreateString(_o.Id);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _SoftCurrency = _o.SoftCurrency == null ? default(StringOffset) : builder.CreateString(_o.SoftCurrency);
    var _HardCurrency = _o.HardCurrency == null ? default(StringOffset) : builder.CreateString(_o.HardCurrency);
    var _MilkCurrency = _o.MilkCurrency == null ? default(StringOffset) : builder.CreateString(_o.MilkCurrency);
    return CreateUserProfile(
      builder,
      _Id,
      _Name,
      _o.Level,
      _o.CurrentExp,
      _SoftCurrency,
      _HardCurrency,
      _MilkCurrency,
      _o.Revolution);
  }
};

public class UserProfileT
{
  public string Id { get; set; }
  public string Name { get; set; }
  public int Level { get; set; }
  public int CurrentExp { get; set; }
  public string SoftCurrency { get; set; }
  public string HardCurrency { get; set; }
  public string MilkCurrency { get; set; }
  public int Revolution { get; set; }

  public UserProfileT() {
    this.Id = null;
    this.Name = null;
    this.Level = 0;
    this.CurrentExp = 0;
    this.SoftCurrency = null;
    this.HardCurrency = null;
    this.MilkCurrency = null;
    this.Revolution = 0;
  }
}


}
