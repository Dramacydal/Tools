// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/game_utilities_types.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol.GameUtilities.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/game_utilities_types.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GameUtilitiesTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/game_utilities_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameUtilitiesTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixiZ3MvbG93L3BiL2NsaWVudC9nYW1lX3V0aWxpdGllc190eXBlcy5wcm90",
            "bxIeYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYxGidiZ3MvbG93L3Bi",
            "L2NsaWVudC9hdHRyaWJ1dGVfdHlwZXMucHJvdG8aJGJncy9sb3cvcGIvY2xp",
            "ZW50L2VudGl0eV90eXBlcy5wcm90byJ3Cg9QbGF5ZXJWYXJpYWJsZXMSKAoI",
            "aWRlbnRpdHkYASABKAsyFi5iZ3MucHJvdG9jb2wuSWRlbnRpdHkSDgoGcmF0",
            "aW5nGAIgASgBEioKCWF0dHJpYnV0ZRgDIAMoCzIXLmJncy5wcm90b2NvbC5B",
            "dHRyaWJ1dGUiQAoKQ2xpZW50SW5mbxIWCg5jbGllbnRfYWRkcmVzcxgBIAEo",
            "CRIaChJwcml2aWxlZ2VkX25ldHdvcmsYAiABKAhCPAofYm5ldC5wcm90b2Nv",
            "bC5nYW1lX3V0aWxpdGllcy52MUIXR2FtZVV0aWxpdGllc1R5cGVzUHJvdG9I",
            "AmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.AttributeTypesReflection.Descriptor, global::Bgs.Protocol.EntityTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.GameUtilities.V1.PlayerVariables), global::Bgs.Protocol.GameUtilities.V1.PlayerVariables.Parser, new[]{ "Identity", "Rating", "Attribute" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.GameUtilities.V1.ClientInfo), global::Bgs.Protocol.GameUtilities.V1.ClientInfo.Parser, new[]{ "ClientAddress", "PrivilegedNetwork" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PlayerVariables : pb::IMessage<PlayerVariables> {
    private static readonly pb::MessageParser<PlayerVariables> _parser = new pb::MessageParser<PlayerVariables>(() => new PlayerVariables());
    public static pb::MessageParser<PlayerVariables> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.GameUtilities.V1.GameUtilitiesTypesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PlayerVariables() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PlayerVariables(PlayerVariables other) : this() {
      Identity = other.identity_ != null ? other.Identity.Clone() : null;
      rating_ = other.rating_;
      attribute_ = other.attribute_.Clone();
    }

    public PlayerVariables Clone() {
      return new PlayerVariables(this);
    }

    /// <summary>Field number for the "identity" field.</summary>
    public const int IdentityFieldNumber = 1;
    private global::Bgs.Protocol.Identity identity_;
    public global::Bgs.Protocol.Identity Identity {
      get { return identity_; }
      set {
        identity_ = value;
      }
    }

    /// <summary>Field number for the "rating" field.</summary>
    public const int RatingFieldNumber = 2;
    private double rating_;
    public double Rating {
      get { return rating_; }
      set {
        rating_ = value;
      }
    }

    /// <summary>Field number for the "attribute" field.</summary>
    public const int AttributeFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Bgs.Protocol.Attribute> _repeated_attribute_codec
        = pb::FieldCodec.ForMessage(26, global::Bgs.Protocol.Attribute.Parser);
    private readonly pbc::RepeatedField<global::Bgs.Protocol.Attribute> attribute_ = new pbc::RepeatedField<global::Bgs.Protocol.Attribute>();
    public pbc::RepeatedField<global::Bgs.Protocol.Attribute> Attribute {
      get { return attribute_; }
    }

    public override bool Equals(object other) {
      return Equals(other as PlayerVariables);
    }

    public bool Equals(PlayerVariables other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Identity, other.Identity)) return false;
      if (Rating != other.Rating) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (identity_ != null) hash ^= Identity.GetHashCode();
      if (Rating != 0D) hash ^= Rating.GetHashCode();
      hash ^= attribute_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (identity_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Identity);
      }
      if (Rating != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Rating);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (identity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Identity);
      }
      if (Rating != 0D) {
        size += 1 + 8;
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      return size;
    }

    public void MergeFrom(PlayerVariables other) {
      if (other == null) {
        return;
      }
      if (other.identity_ != null) {
        if (identity_ == null) {
          identity_ = new global::Bgs.Protocol.Identity();
        }
        Identity.MergeFrom(other.Identity);
      }
      if (other.Rating != 0D) {
        Rating = other.Rating;
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
          case 10: {
            if (identity_ == null) {
              identity_ = new global::Bgs.Protocol.Identity();
            }
            input.ReadMessage(identity_);
            break;
          }
          case 17: {
            Rating = input.ReadDouble();
            break;
          }
          case 26: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ClientInfo : pb::IMessage<ClientInfo> {
    private static readonly pb::MessageParser<ClientInfo> _parser = new pb::MessageParser<ClientInfo>(() => new ClientInfo());
    public static pb::MessageParser<ClientInfo> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.GameUtilities.V1.GameUtilitiesTypesReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ClientInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ClientInfo(ClientInfo other) : this() {
      clientAddress_ = other.clientAddress_;
      privilegedNetwork_ = other.privilegedNetwork_;
    }

    public ClientInfo Clone() {
      return new ClientInfo(this);
    }

    /// <summary>Field number for the "client_address" field.</summary>
    public const int ClientAddressFieldNumber = 1;
    private string clientAddress_ = "";
    public string ClientAddress {
      get { return clientAddress_; }
      set {
        clientAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "privileged_network" field.</summary>
    public const int PrivilegedNetworkFieldNumber = 2;
    private bool privilegedNetwork_;
    public bool PrivilegedNetwork {
      get { return privilegedNetwork_; }
      set {
        privilegedNetwork_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ClientInfo);
    }

    public bool Equals(ClientInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientAddress != other.ClientAddress) return false;
      if (PrivilegedNetwork != other.PrivilegedNetwork) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ClientAddress.Length != 0) hash ^= ClientAddress.GetHashCode();
      if (PrivilegedNetwork != false) hash ^= PrivilegedNetwork.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ClientAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientAddress);
      }
      if (PrivilegedNetwork != false) {
        output.WriteRawTag(16);
        output.WriteBool(PrivilegedNetwork);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ClientAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientAddress);
      }
      if (PrivilegedNetwork != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(ClientInfo other) {
      if (other == null) {
        return;
      }
      if (other.ClientAddress.Length != 0) {
        ClientAddress = other.ClientAddress;
      }
      if (other.PrivilegedNetwork != false) {
        PrivilegedNetwork = other.PrivilegedNetwork;
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
            ClientAddress = input.ReadString();
            break;
          }
          case 16: {
            PrivilegedNetwork = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
