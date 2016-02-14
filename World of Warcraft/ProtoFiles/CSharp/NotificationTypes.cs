// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/notification_types.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bnet.Notification.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/notification_types.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class NotificationTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/notification_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotificationTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipiZ3MvbG93L3BiL2NsaWVudC9ub3RpZmljYXRpb25fdHlwZXMucHJvdG8S",
            "HGJncy5wcm90b2NvbC5ub3RpZmljYXRpb24udjEaJWJncy9sb3cvcGIvY2xp",
            "ZW50L2FjY291bnRfdHlwZXMucHJvdG8aJ2Jncy9sb3cvcGIvY2xpZW50L2F0",
            "dHJpYnV0ZV90eXBlcy5wcm90bxokYmdzL2xvdy9wYi9jbGllbnQvZW50aXR5",
            "X3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMucHJv",
            "dG8iSwoGVGFyZ2V0EjMKCGlkZW50aXR5GAEgASgLMiEuYmdzLnByb3RvY29s",
            "LmFjY291bnQudjEuSWRlbnRpdHkSDAoEdHlwZRgCIAEoCSKWAQoMU3Vic2Ny",
            "aXB0aW9uEjQKBnRhcmdldBgBIAMoCzIkLmJncy5wcm90b2NvbC5ub3RpZmlj",
            "YXRpb24udjEuVGFyZ2V0EjUKCnN1YnNjcmliZXIYAiABKAsyIS5iZ3MucHJv",
            "dG9jb2wuYWNjb3VudC52MS5JZGVudGl0eRIZChFkZWxpdmVyeV9yZXF1aXJl",
            "ZBgDIAEoCCKhAwoMTm90aWZpY2F0aW9uEikKCXNlbmRlcl9pZBgBIAEoCzIW",
            "LmJncy5wcm90b2NvbC5FbnRpdHlJZBIpCgl0YXJnZXRfaWQYAiABKAsyFi5i",
            "Z3MucHJvdG9jb2wuRW50aXR5SWQSDAoEdHlwZRgDIAEoCRIqCglhdHRyaWJ1",
            "dGUYBCADKAsyFy5iZ3MucHJvdG9jb2wuQXR0cmlidXRlEjEKEXNlbmRlcl9h",
            "Y2NvdW50X2lkGAUgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEjEKEXRh",
            "cmdldF9hY2NvdW50X2lkGAYgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlk",
            "EhkKEXNlbmRlcl9iYXR0bGVfdGFnGAcgASgJEhkKEXRhcmdldF9iYXR0bGVf",
            "dGFnGAggASgJEiUKBHBlZXIYCSABKAsyFy5iZ3MucHJvdG9jb2wuUHJvY2Vz",
            "c0lkEj4KE2ZvcndhcmRpbmdfaWRlbnRpdHkYCiABKAsyIS5iZ3MucHJvdG9j",
            "b2wuYWNjb3VudC52MS5JZGVudGl0eUICSAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bnet.Account.V1.AccountTypesReflection.Descriptor, global::Bnet.AttributeTypesReflection.Descriptor, global::Bnet.EntityTypesReflection.Descriptor, global::Bnet.RpcTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bnet.Notification.V1.Target), global::Bnet.Notification.V1.Target.Parser, new[]{ "Identity", "Type" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bnet.Notification.V1.Subscription), global::Bnet.Notification.V1.Subscription.Parser, new[]{ "Target", "Subscriber", "DeliveryRequired" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bnet.Notification.V1.Notification), global::Bnet.Notification.V1.Notification.Parser, new[]{ "SenderId", "TargetId", "Type", "Attribute", "SenderAccountId", "TargetAccountId", "SenderBattleTag", "TargetBattleTag", "Peer", "ForwardingIdentity" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Target : pb::IMessage<Target> {
    private static readonly pb::MessageParser<Target> _parser = new pb::MessageParser<Target>(() => new Target());
    public static pb::MessageParser<Target> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bnet.Notification.V1.NotificationTypesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Target() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Target(Target other) : this() {
      Identity = other.identity_ != null ? other.Identity.Clone() : null;
      type_ = other.type_;
    }

    public Target Clone() {
      return new Target(this);
    }

    /// <summary>Field number for the "identity" field.</summary>
    public const int IdentityFieldNumber = 1;
    private global::Bnet.Account.V1.Identity identity_;
    public global::Bnet.Account.V1.Identity Identity {
      get { return identity_; }
      set {
        identity_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private string type_ = "";
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Target);
    }

    public bool Equals(Target other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Identity, other.Identity)) return false;
      if (Type != other.Type) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (identity_ != null) hash ^= Identity.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
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
      if (Type.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Type);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (identity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Identity);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      return size;
    }

    public void MergeFrom(Target other) {
      if (other == null) {
        return;
      }
      if (other.identity_ != null) {
        if (identity_ == null) {
          identity_ = new global::Bnet.Account.V1.Identity();
        }
        Identity.MergeFrom(other.Identity);
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
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
            if (identity_ == null) {
              identity_ = new global::Bnet.Account.V1.Identity();
            }
            input.ReadMessage(identity_);
            break;
          }
          case 18: {
            Type = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Subscription : pb::IMessage<Subscription> {
    private static readonly pb::MessageParser<Subscription> _parser = new pb::MessageParser<Subscription>(() => new Subscription());
    public static pb::MessageParser<Subscription> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bnet.Notification.V1.NotificationTypesReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Subscription() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Subscription(Subscription other) : this() {
      target_ = other.target_.Clone();
      Subscriber = other.subscriber_ != null ? other.Subscriber.Clone() : null;
      deliveryRequired_ = other.deliveryRequired_;
    }

    public Subscription Clone() {
      return new Subscription(this);
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Bnet.Notification.V1.Target> _repeated_target_codec
        = pb::FieldCodec.ForMessage(10, global::Bnet.Notification.V1.Target.Parser);
    private readonly pbc::RepeatedField<global::Bnet.Notification.V1.Target> target_ = new pbc::RepeatedField<global::Bnet.Notification.V1.Target>();
    public pbc::RepeatedField<global::Bnet.Notification.V1.Target> Target {
      get { return target_; }
    }

    /// <summary>Field number for the "subscriber" field.</summary>
    public const int SubscriberFieldNumber = 2;
    private global::Bnet.Account.V1.Identity subscriber_;
    public global::Bnet.Account.V1.Identity Subscriber {
      get { return subscriber_; }
      set {
        subscriber_ = value;
      }
    }

    /// <summary>Field number for the "delivery_required" field.</summary>
    public const int DeliveryRequiredFieldNumber = 3;
    private bool deliveryRequired_;
    public bool DeliveryRequired {
      get { return deliveryRequired_; }
      set {
        deliveryRequired_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Subscription);
    }

    public bool Equals(Subscription other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!target_.Equals(other.target_)) return false;
      if (!object.Equals(Subscriber, other.Subscriber)) return false;
      if (DeliveryRequired != other.DeliveryRequired) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= target_.GetHashCode();
      if (subscriber_ != null) hash ^= Subscriber.GetHashCode();
      if (DeliveryRequired != false) hash ^= DeliveryRequired.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      target_.WriteTo(output, _repeated_target_codec);
      if (subscriber_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Subscriber);
      }
      if (DeliveryRequired != false) {
        output.WriteRawTag(24);
        output.WriteBool(DeliveryRequired);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += target_.CalculateSize(_repeated_target_codec);
      if (subscriber_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Subscriber);
      }
      if (DeliveryRequired != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(Subscription other) {
      if (other == null) {
        return;
      }
      target_.Add(other.target_);
      if (other.subscriber_ != null) {
        if (subscriber_ == null) {
          subscriber_ = new global::Bnet.Account.V1.Identity();
        }
        Subscriber.MergeFrom(other.Subscriber);
      }
      if (other.DeliveryRequired != false) {
        DeliveryRequired = other.DeliveryRequired;
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
            target_.AddEntriesFrom(input, _repeated_target_codec);
            break;
          }
          case 18: {
            if (subscriber_ == null) {
              subscriber_ = new global::Bnet.Account.V1.Identity();
            }
            input.ReadMessage(subscriber_);
            break;
          }
          case 24: {
            DeliveryRequired = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Notification : pb::IMessage<Notification> {
    private static readonly pb::MessageParser<Notification> _parser = new pb::MessageParser<Notification>(() => new Notification());
    public static pb::MessageParser<Notification> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bnet.Notification.V1.NotificationTypesReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Notification() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Notification(Notification other) : this() {
      SenderId = other.senderId_ != null ? other.SenderId.Clone() : null;
      TargetId = other.targetId_ != null ? other.TargetId.Clone() : null;
      type_ = other.type_;
      attribute_ = other.attribute_.Clone();
      SenderAccountId = other.senderAccountId_ != null ? other.SenderAccountId.Clone() : null;
      TargetAccountId = other.targetAccountId_ != null ? other.TargetAccountId.Clone() : null;
      senderBattleTag_ = other.senderBattleTag_;
      targetBattleTag_ = other.targetBattleTag_;
      Peer = other.peer_ != null ? other.Peer.Clone() : null;
      ForwardingIdentity = other.forwardingIdentity_ != null ? other.ForwardingIdentity.Clone() : null;
    }

    public Notification Clone() {
      return new Notification(this);
    }

    /// <summary>Field number for the "sender_id" field.</summary>
    public const int SenderIdFieldNumber = 1;
    private global::Bnet.EntityId senderId_;
    public global::Bnet.EntityId SenderId {
      get { return senderId_; }
      set {
        senderId_ = value;
      }
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 2;
    private global::Bnet.EntityId targetId_;
    public global::Bnet.EntityId TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private string type_ = "";
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attribute" field.</summary>
    public const int AttributeFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Bnet.Attribute> _repeated_attribute_codec
        = pb::FieldCodec.ForMessage(34, global::Bnet.Attribute.Parser);
    private readonly pbc::RepeatedField<global::Bnet.Attribute> attribute_ = new pbc::RepeatedField<global::Bnet.Attribute>();
    public pbc::RepeatedField<global::Bnet.Attribute> Attribute {
      get { return attribute_; }
    }

    /// <summary>Field number for the "sender_account_id" field.</summary>
    public const int SenderAccountIdFieldNumber = 5;
    private global::Bnet.EntityId senderAccountId_;
    public global::Bnet.EntityId SenderAccountId {
      get { return senderAccountId_; }
      set {
        senderAccountId_ = value;
      }
    }

    /// <summary>Field number for the "target_account_id" field.</summary>
    public const int TargetAccountIdFieldNumber = 6;
    private global::Bnet.EntityId targetAccountId_;
    public global::Bnet.EntityId TargetAccountId {
      get { return targetAccountId_; }
      set {
        targetAccountId_ = value;
      }
    }

    /// <summary>Field number for the "sender_battle_tag" field.</summary>
    public const int SenderBattleTagFieldNumber = 7;
    private string senderBattleTag_ = "";
    public string SenderBattleTag {
      get { return senderBattleTag_; }
      set {
        senderBattleTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_battle_tag" field.</summary>
    public const int TargetBattleTagFieldNumber = 8;
    private string targetBattleTag_ = "";
    public string TargetBattleTag {
      get { return targetBattleTag_; }
      set {
        targetBattleTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "peer" field.</summary>
    public const int PeerFieldNumber = 9;
    private global::Bnet.ProcessId peer_;
    public global::Bnet.ProcessId Peer {
      get { return peer_; }
      set {
        peer_ = value;
      }
    }

    /// <summary>Field number for the "forwarding_identity" field.</summary>
    public const int ForwardingIdentityFieldNumber = 10;
    private global::Bnet.Account.V1.Identity forwardingIdentity_;
    public global::Bnet.Account.V1.Identity ForwardingIdentity {
      get { return forwardingIdentity_; }
      set {
        forwardingIdentity_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Notification);
    }

    public bool Equals(Notification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SenderId, other.SenderId)) return false;
      if (!object.Equals(TargetId, other.TargetId)) return false;
      if (Type != other.Type) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      if (!object.Equals(SenderAccountId, other.SenderAccountId)) return false;
      if (!object.Equals(TargetAccountId, other.TargetAccountId)) return false;
      if (SenderBattleTag != other.SenderBattleTag) return false;
      if (TargetBattleTag != other.TargetBattleTag) return false;
      if (!object.Equals(Peer, other.Peer)) return false;
      if (!object.Equals(ForwardingIdentity, other.ForwardingIdentity)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (senderId_ != null) hash ^= SenderId.GetHashCode();
      if (targetId_ != null) hash ^= TargetId.GetHashCode();
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      hash ^= attribute_.GetHashCode();
      if (senderAccountId_ != null) hash ^= SenderAccountId.GetHashCode();
      if (targetAccountId_ != null) hash ^= TargetAccountId.GetHashCode();
      if (SenderBattleTag.Length != 0) hash ^= SenderBattleTag.GetHashCode();
      if (TargetBattleTag.Length != 0) hash ^= TargetBattleTag.GetHashCode();
      if (peer_ != null) hash ^= Peer.GetHashCode();
      if (forwardingIdentity_ != null) hash ^= ForwardingIdentity.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (senderId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SenderId);
      }
      if (targetId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TargetId);
      }
      if (Type.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Type);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
      if (senderAccountId_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SenderAccountId);
      }
      if (targetAccountId_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(TargetAccountId);
      }
      if (SenderBattleTag.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(SenderBattleTag);
      }
      if (TargetBattleTag.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(TargetBattleTag);
      }
      if (peer_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Peer);
      }
      if (forwardingIdentity_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(ForwardingIdentity);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (senderId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SenderId);
      }
      if (targetId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetId);
      }
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      if (senderAccountId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SenderAccountId);
      }
      if (targetAccountId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetAccountId);
      }
      if (SenderBattleTag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SenderBattleTag);
      }
      if (TargetBattleTag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetBattleTag);
      }
      if (peer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Peer);
      }
      if (forwardingIdentity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ForwardingIdentity);
      }
      return size;
    }

    public void MergeFrom(Notification other) {
      if (other == null) {
        return;
      }
      if (other.senderId_ != null) {
        if (senderId_ == null) {
          senderId_ = new global::Bnet.EntityId();
        }
        SenderId.MergeFrom(other.SenderId);
      }
      if (other.targetId_ != null) {
        if (targetId_ == null) {
          targetId_ = new global::Bnet.EntityId();
        }
        TargetId.MergeFrom(other.TargetId);
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      attribute_.Add(other.attribute_);
      if (other.senderAccountId_ != null) {
        if (senderAccountId_ == null) {
          senderAccountId_ = new global::Bnet.EntityId();
        }
        SenderAccountId.MergeFrom(other.SenderAccountId);
      }
      if (other.targetAccountId_ != null) {
        if (targetAccountId_ == null) {
          targetAccountId_ = new global::Bnet.EntityId();
        }
        TargetAccountId.MergeFrom(other.TargetAccountId);
      }
      if (other.SenderBattleTag.Length != 0) {
        SenderBattleTag = other.SenderBattleTag;
      }
      if (other.TargetBattleTag.Length != 0) {
        TargetBattleTag = other.TargetBattleTag;
      }
      if (other.peer_ != null) {
        if (peer_ == null) {
          peer_ = new global::Bnet.ProcessId();
        }
        Peer.MergeFrom(other.Peer);
      }
      if (other.forwardingIdentity_ != null) {
        if (forwardingIdentity_ == null) {
          forwardingIdentity_ = new global::Bnet.Account.V1.Identity();
        }
        ForwardingIdentity.MergeFrom(other.ForwardingIdentity);
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
            if (senderId_ == null) {
              senderId_ = new global::Bnet.EntityId();
            }
            input.ReadMessage(senderId_);
            break;
          }
          case 18: {
            if (targetId_ == null) {
              targetId_ = new global::Bnet.EntityId();
            }
            input.ReadMessage(targetId_);
            break;
          }
          case 26: {
            Type = input.ReadString();
            break;
          }
          case 34: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
            break;
          }
          case 42: {
            if (senderAccountId_ == null) {
              senderAccountId_ = new global::Bnet.EntityId();
            }
            input.ReadMessage(senderAccountId_);
            break;
          }
          case 50: {
            if (targetAccountId_ == null) {
              targetAccountId_ = new global::Bnet.EntityId();
            }
            input.ReadMessage(targetAccountId_);
            break;
          }
          case 58: {
            SenderBattleTag = input.ReadString();
            break;
          }
          case 66: {
            TargetBattleTag = input.ReadString();
            break;
          }
          case 74: {
            if (peer_ == null) {
              peer_ = new global::Bnet.ProcessId();
            }
            input.ReadMessage(peer_);
            break;
          }
          case 82: {
            if (forwardingIdentity_ == null) {
              forwardingIdentity_ = new global::Bnet.Account.V1.Identity();
            }
            input.ReadMessage(forwardingIdentity_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
