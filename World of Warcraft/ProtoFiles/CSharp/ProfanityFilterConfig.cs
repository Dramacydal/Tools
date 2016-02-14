// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/profanity_filter_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bnet.Profanity.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/profanity_filter_config.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ProfanityFilterConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/profanity_filter_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProfanityFilterConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9iZ3MvbG93L3BiL2NsaWVudC9wcm9mYW5pdHlfZmlsdGVyX2NvbmZpZy5w",
            "cm90bxIZYmdzLnByb3RvY29sLnByb2Zhbml0eS52MSIpCgpXb3JkRmlsdGVy",
            "EgwKBHR5cGUYASABKAkSDQoFcmVnZXgYAiABKAkiRQoLV29yZEZpbHRlcnMS",
            "NgoHZmlsdGVycxgBIAMoCzIlLmJncy5wcm90b2NvbC5wcm9mYW5pdHkudjEu",
            "V29yZEZpbHRlckICSAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bnet.Profanity.V1.WordFilter), global::Bnet.Profanity.V1.WordFilter.Parser, new[]{ "Type", "Regex" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bnet.Profanity.V1.WordFilters), global::Bnet.Profanity.V1.WordFilters.Parser, new[]{ "Filters" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class WordFilter : pb::IMessage<WordFilter> {
    private static readonly pb::MessageParser<WordFilter> _parser = new pb::MessageParser<WordFilter>(() => new WordFilter());
    public static pb::MessageParser<WordFilter> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bnet.Profanity.V1.ProfanityFilterConfigReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public WordFilter() {
      OnConstruction();
    }

    partial void OnConstruction();

    public WordFilter(WordFilter other) : this() {
      type_ = other.type_;
      regex_ = other.regex_;
    }

    public WordFilter Clone() {
      return new WordFilter(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "regex" field.</summary>
    public const int RegexFieldNumber = 2;
    private string regex_ = "";
    public string Regex {
      get { return regex_; }
      set {
        regex_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as WordFilter);
    }

    public bool Equals(WordFilter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Regex != other.Regex) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Regex.Length != 0) hash ^= Regex.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (Regex.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Regex);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Regex.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Regex);
      }
      return size;
    }

    public void MergeFrom(WordFilter other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Regex.Length != 0) {
        Regex = other.Regex;
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
            Type = input.ReadString();
            break;
          }
          case 18: {
            Regex = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class WordFilters : pb::IMessage<WordFilters> {
    private static readonly pb::MessageParser<WordFilters> _parser = new pb::MessageParser<WordFilters>(() => new WordFilters());
    public static pb::MessageParser<WordFilters> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bnet.Profanity.V1.ProfanityFilterConfigReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public WordFilters() {
      OnConstruction();
    }

    partial void OnConstruction();

    public WordFilters(WordFilters other) : this() {
      filters_ = other.filters_.Clone();
    }

    public WordFilters Clone() {
      return new WordFilters(this);
    }

    /// <summary>Field number for the "filters" field.</summary>
    public const int FiltersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Bnet.Profanity.V1.WordFilter> _repeated_filters_codec
        = pb::FieldCodec.ForMessage(10, global::Bnet.Profanity.V1.WordFilter.Parser);
    private readonly pbc::RepeatedField<global::Bnet.Profanity.V1.WordFilter> filters_ = new pbc::RepeatedField<global::Bnet.Profanity.V1.WordFilter>();
    public pbc::RepeatedField<global::Bnet.Profanity.V1.WordFilter> Filters {
      get { return filters_; }
    }

    public override bool Equals(object other) {
      return Equals(other as WordFilters);
    }

    public bool Equals(WordFilters other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!filters_.Equals(other.filters_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= filters_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      filters_.WriteTo(output, _repeated_filters_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += filters_.CalculateSize(_repeated_filters_codec);
      return size;
    }

    public void MergeFrom(WordFilters other) {
      if (other == null) {
        return;
      }
      filters_.Add(other.filters_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            filters_.AddEntriesFrom(input, _repeated_filters_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
