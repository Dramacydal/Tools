// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: bgs/low/pb/client/global_extensions/field_options.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/global_extensions/field_options.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FieldOptionsReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/global_extensions/field_options.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FieldOptionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdiZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9maWVsZF9v",
            "cHRpb25zLnByb3RvEgxiZ3MucHJvdG9jb2waIGdvb2dsZS9wcm90b2J1Zi9k",
            "ZXNjcmlwdG9yLnByb3RvKioKCUxvZ09wdGlvbhIICgROT05FEAASCgoGSElE",
            "REVOEAESBwoDSEVYEAI6RQoDbG9nEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxk",
            "T3B0aW9ucxjQhgMgASgOMhcuYmdzLnByb3RvY29sLkxvZ09wdGlvbkIkCg1i",
            "bmV0LnByb3RvY29sQhFGaWVsZE9wdGlvbnNQcm90b0gCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { pbr::FileDescriptor.DescriptorProtoFileDescriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Bgs.Protocol.LogOption), }, null));
    }
    #endregion

  }
  #region Enums
  public enum LogOption {
    NONE = 0,
    HIDDEN = 1,
    HEX = 2,
  }

  #endregion

}

#endregion Designer generated code