// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/report_service.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol.Report.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/report_service.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ReportServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/report_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZiZ3MvbG93L3BiL2NsaWVudC9yZXBvcnRfc2VydmljZS5wcm90bxIWYmdz",
            "LnByb3RvY29sLnJlcG9ydC52MRonYmdzL2xvdy9wYi9jbGllbnQvYXR0cmli",
            "dXRlX3R5cGVzLnByb3RvGiRiZ3MvbG93L3BiL2NsaWVudC9lbnRpdHlfdHlw",
            "ZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3JwY190eXBlcy5wcm90byLi",
            "AQoGUmVwb3J0EhMKC3JlcG9ydF90eXBlGAEgASgJEioKCWF0dHJpYnV0ZRgC",
            "IAMoCzIXLmJncy5wcm90b2NvbC5BdHRyaWJ1dGUSEgoKcmVwb3J0X3FvcxgD",
            "IAEoBRIxChFyZXBvcnRpbmdfYWNjb3VudBgEIAEoCzIWLmJncy5wcm90b2Nv",
            "bC5FbnRpdHlJZBI2ChZyZXBvcnRpbmdfZ2FtZV9hY2NvdW50GAUgASgLMhYu",
            "YmdzLnByb3RvY29sLkVudGl0eUlkEhgKEHJlcG9ydF90aW1lc3RhbXAYBiAB",
            "KAYiQwoRU2VuZFJlcG9ydFJlcXVlc3QSLgoGcmVwb3J0GAEgASgLMh4uYmdz",
            "LnByb3RvY29sLnJlcG9ydC52MS5SZXBvcnQyXgoNUmVwb3J0U2VydmljZRJN",
            "CgpTZW5kUmVwb3J0EikuYmdzLnByb3RvY29sLnJlcG9ydC52MS5TZW5kUmVw",
            "b3J0UmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGFCBUgCgAEAYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.AttributeTypesReflection.Descriptor, global::Bgs.Protocol.EntityTypesReflection.Descriptor, global::Bgs.Protocol.RpcTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Report.V1.Report), global::Bgs.Protocol.Report.V1.Report.Parser, new[]{ "ReportType", "Attribute", "ReportQos", "ReportingAccount", "ReportingGameAccount", "ReportTimestamp" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Report.V1.SendReportRequest), global::Bgs.Protocol.Report.V1.SendReportRequest.Parser, new[]{ "Report" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Report : pb::IMessage<Report> {
    private static readonly pb::MessageParser<Report> _parser = new pb::MessageParser<Report>(() => new Report());
    public static pb::MessageParser<Report> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Report.V1.ReportServiceReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Report() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Report(Report other) : this() {
      reportType_ = other.reportType_;
      attribute_ = other.attribute_.Clone();
      reportQos_ = other.reportQos_;
      ReportingAccount = other.reportingAccount_ != null ? other.ReportingAccount.Clone() : null;
      ReportingGameAccount = other.reportingGameAccount_ != null ? other.ReportingGameAccount.Clone() : null;
      reportTimestamp_ = other.reportTimestamp_;
    }

    public Report Clone() {
      return new Report(this);
    }

    /// <summary>Field number for the "report_type" field.</summary>
    public const int ReportTypeFieldNumber = 1;
    private string reportType_ = "";
    public string ReportType {
      get { return reportType_; }
      set {
        reportType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "report_qos" field.</summary>
    public const int ReportQosFieldNumber = 3;
    private int reportQos_;
    public int ReportQos {
      get { return reportQos_; }
      set {
        reportQos_ = value;
      }
    }

    /// <summary>Field number for the "reporting_account" field.</summary>
    public const int ReportingAccountFieldNumber = 4;
    private global::Bgs.Protocol.EntityId reportingAccount_;
    public global::Bgs.Protocol.EntityId ReportingAccount {
      get { return reportingAccount_; }
      set {
        reportingAccount_ = value;
      }
    }

    /// <summary>Field number for the "reporting_game_account" field.</summary>
    public const int ReportingGameAccountFieldNumber = 5;
    private global::Bgs.Protocol.EntityId reportingGameAccount_;
    public global::Bgs.Protocol.EntityId ReportingGameAccount {
      get { return reportingGameAccount_; }
      set {
        reportingGameAccount_ = value;
      }
    }

    /// <summary>Field number for the "report_timestamp" field.</summary>
    public const int ReportTimestampFieldNumber = 6;
    private ulong reportTimestamp_;
    public ulong ReportTimestamp {
      get { return reportTimestamp_; }
      set {
        reportTimestamp_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Report);
    }

    public bool Equals(Report other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReportType != other.ReportType) return false;
      if(!attribute_.Equals(other.attribute_)) return false;
      if (ReportQos != other.ReportQos) return false;
      if (!object.Equals(ReportingAccount, other.ReportingAccount)) return false;
      if (!object.Equals(ReportingGameAccount, other.ReportingGameAccount)) return false;
      if (ReportTimestamp != other.ReportTimestamp) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (ReportType.Length != 0) hash ^= ReportType.GetHashCode();
      hash ^= attribute_.GetHashCode();
      if (ReportQos != 0) hash ^= ReportQos.GetHashCode();
      if (reportingAccount_ != null) hash ^= ReportingAccount.GetHashCode();
      if (reportingGameAccount_ != null) hash ^= ReportingGameAccount.GetHashCode();
      if (ReportTimestamp != 0UL) hash ^= ReportTimestamp.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (ReportType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ReportType);
      }
      attribute_.WriteTo(output, _repeated_attribute_codec);
      if (ReportQos != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ReportQos);
      }
      if (reportingAccount_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ReportingAccount);
      }
      if (reportingGameAccount_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ReportingGameAccount);
      }
      if (ReportTimestamp != 0UL) {
        output.WriteRawTag(49);
        output.WriteFixed64(ReportTimestamp);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (ReportType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReportType);
      }
      size += attribute_.CalculateSize(_repeated_attribute_codec);
      if (ReportQos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReportQos);
      }
      if (reportingAccount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReportingAccount);
      }
      if (reportingGameAccount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReportingGameAccount);
      }
      if (ReportTimestamp != 0UL) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(Report other) {
      if (other == null) {
        return;
      }
      if (other.ReportType.Length != 0) {
        ReportType = other.ReportType;
      }
      attribute_.Add(other.attribute_);
      if (other.ReportQos != 0) {
        ReportQos = other.ReportQos;
      }
      if (other.reportingAccount_ != null) {
        if (reportingAccount_ == null) {
          reportingAccount_ = new global::Bgs.Protocol.EntityId();
        }
        ReportingAccount.MergeFrom(other.ReportingAccount);
      }
      if (other.reportingGameAccount_ != null) {
        if (reportingGameAccount_ == null) {
          reportingGameAccount_ = new global::Bgs.Protocol.EntityId();
        }
        ReportingGameAccount.MergeFrom(other.ReportingGameAccount);
      }
      if (other.ReportTimestamp != 0UL) {
        ReportTimestamp = other.ReportTimestamp;
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
            ReportType = input.ReadString();
            break;
          }
          case 18: {
            attribute_.AddEntriesFrom(input, _repeated_attribute_codec);
            break;
          }
          case 24: {
            ReportQos = input.ReadInt32();
            break;
          }
          case 34: {
            if (reportingAccount_ == null) {
              reportingAccount_ = new global::Bgs.Protocol.EntityId();
            }
            input.ReadMessage(reportingAccount_);
            break;
          }
          case 42: {
            if (reportingGameAccount_ == null) {
              reportingGameAccount_ = new global::Bgs.Protocol.EntityId();
            }
            input.ReadMessage(reportingGameAccount_);
            break;
          }
          case 49: {
            ReportTimestamp = input.ReadFixed64();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SendReportRequest : pb::IMessage<SendReportRequest> {
    private static readonly pb::MessageParser<SendReportRequest> _parser = new pb::MessageParser<SendReportRequest>(() => new SendReportRequest());
    public static pb::MessageParser<SendReportRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Report.V1.ReportServiceReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SendReportRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SendReportRequest(SendReportRequest other) : this() {
      Report = other.report_ != null ? other.Report.Clone() : null;
    }

    public SendReportRequest Clone() {
      return new SendReportRequest(this);
    }

    /// <summary>Field number for the "report" field.</summary>
    public const int ReportFieldNumber = 1;
    private global::Bgs.Protocol.Report.V1.Report report_;
    public global::Bgs.Protocol.Report.V1.Report Report {
      get { return report_; }
      set {
        report_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SendReportRequest);
    }

    public bool Equals(SendReportRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Report, other.Report)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (report_ != null) hash ^= Report.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (report_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Report);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (report_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Report);
      }
      return size;
    }

    public void MergeFrom(SendReportRequest other) {
      if (other == null) {
        return;
      }
      if (other.report_ != null) {
        if (report_ == null) {
          report_ = new global::Bgs.Protocol.Report.V1.Report();
        }
        Report.MergeFrom(other.Report);
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
            if (report_ == null) {
              report_ = new global::Bgs.Protocol.Report.V1.Report();
            }
            input.ReadMessage(report_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
