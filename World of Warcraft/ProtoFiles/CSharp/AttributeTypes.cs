// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/attribute_types.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/attribute_types.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class AttributeTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/attribute_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttributeTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidiZ3MvbG93L3BiL2NsaWVudC9hdHRyaWJ1dGVfdHlwZXMucHJvdG8SDGJn",
            "cy5wcm90b2NvbBokYmdzL2xvdy9wYi9jbGllbnQvZW50aXR5X3R5cGVzLnBy",
            "b3RvIuEBCgdWYXJpYW50EhIKCmJvb2xfdmFsdWUYAiABKAgSEQoJaW50X3Zh",
            "bHVlGAMgASgDEhMKC2Zsb2F0X3ZhbHVlGAQgASgBEhQKDHN0cmluZ192YWx1",
            "ZRgFIAEoCRISCgpibG9iX3ZhbHVlGAYgASgMEhUKDW1lc3NhZ2VfdmFsdWUY",
            "ByABKAwSFAoMZm91cmNjX3ZhbHVlGAggASgJEhIKCnVpbnRfdmFsdWUYCSAB",
            "KAQSLwoPZW50aXR5X2lkX3ZhbHVlGAogASgLMhYuYmdzLnByb3RvY29sLkVu",
            "dGl0eUlkIj8KCUF0dHJpYnV0ZRIMCgRuYW1lGAEgASgJEiQKBXZhbHVlGAIg",
            "ASgLMhUuYmdzLnByb3RvY29sLlZhcmlhbnQiygEKD0F0dHJpYnV0ZUZpbHRl",
            "chIzCgJvcBgBIAEoDjInLmJncy5wcm90b2NvbC5BdHRyaWJ1dGVGaWx0ZXIu",
            "T3BlcmF0aW9uEioKCWF0dHJpYnV0ZRgCIAMoCzIXLmJncy5wcm90b2NvbC5B",
            "dHRyaWJ1dGUiVgoJT3BlcmF0aW9uEg4KCk1BVENIX05PTkUQABINCglNQVRD",
            "SF9BTlkQARINCglNQVRDSF9BTEwQAhIbChdNQVRDSF9BTExfTU9TVF9TUEVD",
            "SUZJQxADQiEKDWJuZXQucHJvdG9jb2xCDkF0dHJpYnV0ZVByb3RvSAJiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.EntityTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Variant), global::Bgs.Protocol.Variant.Parser, new[]{ "BoolValue", "IntValue", "FloatValue", "StringValue", "BlobValue", "MessageValue", "FourccValue", "UintValue", "EntityIdValue" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Attribute), global::Bgs.Protocol.Attribute.Parser, new[]{ "Name", "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.AttributeFilter), global::Bgs.Protocol.AttributeFilter.Parser, new[]{ "Op", "Attribute" }, null, new[]{ typeof(global::Bgs.Protocol.AttributeFilter.Types.Operation) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Variant : pb::IMessage<Variant> {
    private static readonly pb::MessageParser<Variant> _parser = new pb::MessageParser<Variant>(() => new Variant());
    public static pb::MessageParser<Variant> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.AttributeTypesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Variant() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Variant(Variant other) : this() {
      boolValue_ = other.boolValue_;
      intValue_ = other.intValue_;
      floatValue_ = other.floatValue_;
      stringValue_ = other.stringValue_;
      blobValue_ = other.blobValue_;
      messageValue_ = other.messageValue_;
      fourccValue_ = other.fourccValue_;
      uintValue_ = other.uintValue_;
      EntityIdValue = other.entityIdValue_ != null ? other.EntityIdValue.Clone() : null;
    }

    public Variant Clone() {
      return new Variant(this);
    }

    /// <summary>Field number for the "bool_value" field.</summary>
    public const int BoolValueFieldNumber = 2;
    private bool boolValue_;
    public bool BoolValue {
      get { return boolValue_; }
      set {
        boolValue_ = value;
      }
    }

    /// <summary>Field number for the "int_value" field.</summary>
    public const int IntValueFieldNumber = 3;
    private long intValue_;
    public long IntValue {
      get { return intValue_; }
      set {
        intValue_ = value;
      }
    }

    /// <summary>Field number for the "float_value" field.</summary>
    public const int FloatValueFieldNumber = 4;
    private double floatValue_;
    public double FloatValue {
      get { return floatValue_; }
      set {
        floatValue_ = value;
      }
    }

    /// <summary>Field number for the "string_value" field.</summary>
    public const int StringValueFieldNumber = 5;
    private string stringValue_ = "";
    public string StringValue {
      get { return stringValue_; }
      set {
        stringValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "blob_value" field.</summary>
    public const int BlobValueFieldNumber = 6;
    private pb::ByteString blobValue_ = pb::ByteString.Empty;
    public pb::ByteString BlobValue {
      get { return blobValue_; }
      set {
        blobValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message_value" field.</summary>
    public const int MessageValueFieldNumber = 7;
    private pb::ByteString messageValue_ = pb::ByteString.Empty;
    public pb::ByteString MessageValue {
      get { return messageValue_; }
      set {
        messageValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fourcc_value" field.</summary>
    public const int FourccValueFieldNumber = 8;
    private string fourccValue_ = "";
    public string FourccValue {
      get { return fourccValue_; }
      set {
        fourccValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uint_value" field.</summary>
    public const int UintValueFieldNumber = 9;
    private ulong uintValue_;
    public ulong UintValue {
      get { return uintValue_; }
      set {
        uintValue_ = value;
      }
    }

    /// <summary>Field number for the "entity_id_value" field.</summary>
    public const int EntityIdValueFieldNumber = 10;
    private global::Bgs.Protocol.EntityId entityIdValue_;
    public global::Bgs.Protocol.EntityId EntityIdValue {
      get { return entityIdValue_; }
      set {
        entityIdValue_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Variant);
    }

    public bool Equals(Variant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BoolValue != other.BoolValue) return false;
      if (IntValue != other.IntValue) return false;
      if (FloatValue != other.FloatValue) return false;
      if (StringValue != other.StringValue) return false;
      if (BlobValue != other.BlobValue) return false;
      if (MessageValue != other.MessageValue) return false;
      if (FourccValue != other.FourccValue) return false;
      if (UintValue != other.UintValue) return false;
      if (!object.Equals(EntityIdValue, other.EntityIdValue)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (BoolValue != false) hash ^= BoolValue.GetHashCode();
      if (IntValue != 0L) hash ^= IntValue.GetHashCode();
      if (FloatValue != 0D) hash ^= FloatValue.GetHashCode();
      if (StringValue.Length != 0) hash ^= StringValue.GetHashCode();
      if (BlobValue.Length != 0) hash ^= BlobValue.GetHashCode();
      if (MessageValue.Length != 0) hash ^= MessageValue.GetHashCode();
      if (FourccValue.Length != 0) hash ^= FourccValue.GetHashCode();
      if (UintValue != 0UL) hash ^= UintValue.GetHashCode();
      if (entityIdValue_ != null) hash ^= EntityIdValue.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (BoolValue != false) {
        output.WriteRawTag(16);
        output.WriteBool(BoolValue);
      }
      if (IntValue != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(IntValue);
      }
      if (FloatValue != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(FloatValue);
      }
      if (StringValue.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StringValue);
      }
      if (BlobValue.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(BlobValue);
      }
      if (MessageValue.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(MessageValue);
      }
      if (FourccValue.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(FourccValue);
      }
      if (UintValue != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(UintValue);
      }
      if (entityIdValue_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(EntityIdValue);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (BoolValue != false) {
        size += 1 + 1;
      }
      if (IntValue != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(IntValue);
      }
      if (FloatValue != 0D) {
        size += 1 + 8;
      }
      if (StringValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (BlobValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(BlobValue);
      }
      if (MessageValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(MessageValue);
      }
      if (FourccValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FourccValue);
      }
      if (UintValue != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UintValue);
      }
      if (entityIdValue_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityIdValue);
      }
      return size;
    }

    public void MergeFrom(Variant other) {
      if (other == null) {
        return;
      }
      if (other.BoolValue != false) {
        BoolValue = other.BoolValue;
      }
      if (other.IntValue != 0L) {
        IntValue = other.IntValue;
      }
      if (other.FloatValue != 0D) {
        FloatValue = other.FloatValue;
      }
      if (other.StringValue.Length != 0) {
        StringValue = other.StringValue;
      }
      if (other.BlobValue.Length != 0) {
        BlobValue = other.BlobValue;
      }
      if (other.MessageValue.Length != 0) {
        MessageValue = other.MessageValue;
      }
      if (other.FourccValue.Length != 0) {
        FourccValue = other.FourccValue;
      }
      if (other.UintValue != 0UL) {
        UintValue = other.UintValue;
      }
      if (other.entityIdValue_ != null) {
        if (entityIdValue_ == null) {
          entityIdValue_ = new global::Bgs.Protocol.EntityId();
        }
        EntityIdValue.MergeFrom(other.EntityIdValue);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 16: {
            BoolValue = input.ReadBool();
            break;
          }
          case 24: {
            IntValue = input.ReadInt64();
            break;
          }
          case 33: {
            FloatValue = input.ReadDouble();
            break;
          }
          case 42: {
            StringValue = input.ReadString();
            break;
          }
          case 50: {
            BlobValue = input.ReadBytes();
            break;
          }
          case 58: {
            MessageValue = input.ReadBytes();
            break;
          }
          case 66: {
            FourccValue = input.ReadString();
            break;
          }
          case 72: {
            UintValue = input.ReadUInt64();
            break;
          }
          case 82: {
            if (entityIdValue_ == null) {
              entityIdValue_ = new global::Bgs.Protocol.EntityId();
            }
            input.ReadMessage(entityIdValue_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Attribute : pb::IMessage<Attribute> {
    private static readonly pb::MessageParser<Attribute> _parser = new pb::MessageParser<Attribute>(() => new Attribute());
    public static pb::MessageParser<Attribute> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.AttributeTypesReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Attribute() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Attribute(Attribute other) : this() {
      name_ = other.name_;
      Value = other.value_ != null ? other.Value.Clone() : null;
    }

    public Attribute Clone() {
      return new Attribute(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Bgs.Protocol.Variant value_;
    public global::Bgs.Protocol.Variant Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Attribute);
    }

    public bool Equals(Attribute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      return size;
    }

    public void MergeFrom(Attribute other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          value_ = new global::Bgs.Protocol.Variant();
        }
        Value.MergeFrom(other.Value);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (value_ == null) {
              value_ = new global::Bgs.Protocol.Variant();
            }
            input.ReadMessage(value_);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class AttributeFilter : pb::IMessage<AttributeFilter> {
    private static readonly pb::MessageParser<AttributeFilter> _parser = new pb::MessageParser<AttributeFilter>(() => new AttributeFilter());
    public static pb::MessageParser<AttributeFilter> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.AttributeTypesReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public AttributeFilter() {
      OnConstruction();
    }

    partial void OnConstruction();

    public AttributeFilter(AttributeFilter other) : this() {
      op_ = other.op_;
      attribute_ = other.attribute_.Clone();
    }

    public AttributeFilter Clone() {
      return new AttributeFilter(this);
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private global::Bgs.Protocol.AttributeFilter.Types.Operation op_ = global::Bgs.Protocol.AttributeFilter.Types.Operation.MATCH_NONE;
    public global::Bgs.Protocol.AttributeFilter.Types.Operation Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    /// <summary>Field number for the "attribute" field.</summary>
    public const int AttributeFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.Attribute> _repeated_attribute_codec
        = pb::FieldCodec.ForMessage(18, global::Bgs.Protocol.Attribute.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.Attribute> attribute_ = new pbc::RepeatedField<global::Bgs.Protocol.Attribute>();
    public pbc::RepeatedField<global::Bgs.Protocol.Attribute> Attribute {
      get { return attribute_; }
    }

    public override bool Equals(object other) {
      return Equals(other as AttributeFilter);
    }

    public bool Equals(AttributeFilter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Op != other.Op) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Op != global::Bgs.Protocol.AttributeFilter.Types.Operation.MATCH_NONE) hash ^= Op.GetHashCode();
      hash ^= attribute_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Op != global::Bgs.Protocol.AttributeFilter.Types.Operation.MATCH_NONE) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Op);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (Op != global::Bgs.Protocol.AttributeFilter.Types.Operation.MATCH_NONE) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Op);
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      return size;
    }

    public void MergeFrom(AttributeFilter other) {
      if (other == null) {
        return;
      }
      if (other.Op != global::Bgs.Protocol.AttributeFilter.Types.Operation.MATCH_NONE) {
        Op = other.Op;
      }
      attribute_.Add(other.attribute_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            op_ = (global::Bgs.Protocol.AttributeFilter.Types.Operation) input.ReadEnum();
            break;
          }
          case 18: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AttributeFilter message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Operation {
        MATCH_NONE = 0,
        MATCH_ANY = 1,
        MATCH_ALL = 2,
        MATCH_ALL_MOST_SPECIFIC = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
