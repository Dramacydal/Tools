// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/content_handle_types.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bnet {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/content_handle_types.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ContentHandleTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/content_handle_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContentHandleTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixiZ3MvbG93L3BiL2NsaWVudC9jb250ZW50X2hhbmRsZV90eXBlcy5wcm90",
            "bxIMYmdzLnByb3RvY29sIk8KDUNvbnRlbnRIYW5kbGUSDgoGcmVnaW9uGAEg",
            "ASgHEg0KBXVzYWdlGAIgASgHEgwKBGhhc2gYAyABKAwSEQoJcHJvdG9fdXJs",
            "GAQgASgJQiUKDWJuZXQucHJvdG9jb2xCEkNvbnRlbnRIYW5kbGVQcm90b0gC",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bnet.ContentHandle), global::Bnet.ContentHandle.Parser, new[]{ "Region", "Usage", "Hash", "ProtoUrl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ContentHandle : pb::IMessage<ContentHandle> {
    private static readonly pb::MessageParser<ContentHandle> _parser = new pb::MessageParser<ContentHandle>(() => new ContentHandle());
    public static pb::MessageParser<ContentHandle> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bnet.ContentHandleTypesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ContentHandle() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ContentHandle(ContentHandle other) : this() {
      region_ = other.region_;
      usage_ = other.usage_;
      hash_ = other.hash_;
      protoUrl_ = other.protoUrl_;
    }

    public ContentHandle Clone() {
      return new ContentHandle(this);
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 1;
    private uint region_;
    public uint Region {
      get { return region_; }
      set {
        region_ = value;
      }
    }

    /// <summary>Field number for the "usage" field.</summary>
    public const int UsageFieldNumber = 2;
    private uint usage_;
    public uint Usage {
      get { return usage_; }
      set {
        usage_ = value;
      }
    }

    /// <summary>Field number for the "hash" field.</summary>
    public const int HashFieldNumber = 3;
    private pb::ByteString hash_ = pb::ByteString.Empty;
    public pb::ByteString Hash {
      get { return hash_; }
      set {
        hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "proto_url" field.</summary>
    public const int ProtoUrlFieldNumber = 4;
    private string protoUrl_ = "";
    public string ProtoUrl {
      get { return protoUrl_; }
      set {
        protoUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ContentHandle);
    }

    public bool Equals(ContentHandle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Region != other.Region) return false;
      if (Usage != other.Usage) return false;
      if (Hash != other.Hash) return false;
      if (ProtoUrl != other.ProtoUrl) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Region != 0) hash ^= Region.GetHashCode();
      if (Usage != 0) hash ^= Usage.GetHashCode();
      if (Hash.Length != 0) hash ^= Hash.GetHashCode();
      if (ProtoUrl.Length != 0) hash ^= ProtoUrl.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Region != 0) {
        output.WriteRawTag(13);
        output.WriteFixed32(Region);
      }
      if (Usage != 0) {
        output.WriteRawTag(21);
        output.WriteFixed32(Usage);
      }
      if (Hash.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Hash);
      }
      if (ProtoUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ProtoUrl);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Region != 0) {
        size += 1 + 4;
      }
      if (Usage != 0) {
        size += 1 + 4;
      }
      if (Hash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Hash);
      }
      if (ProtoUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProtoUrl);
      }
      return size;
    }

    public void MergeFrom(ContentHandle other) {
      if (other == null) {
        return;
      }
      if (other.Region != 0) {
        Region = other.Region;
      }
      if (other.Usage != 0) {
        Usage = other.Usage;
      }
      if (other.Hash.Length != 0) {
        Hash = other.Hash;
      }
      if (other.ProtoUrl.Length != 0) {
        ProtoUrl = other.ProtoUrl;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            Region = input.ReadFixed32();
            break;
          }
          case 21: {
            Usage = input.ReadFixed32();
            break;
          }
          case 26: {
            Hash = input.ReadBytes();
            break;
          }
          case 34: {
            ProtoUrl = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
