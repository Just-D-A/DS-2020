// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: job.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BackendApi {

  /// <summary>Holder for reflection information generated from job.proto</summary>
  public static partial class JobReflection {

    #region Descriptor
    /// <summary>File descriptor for job.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JobReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cglqb2IucHJvdG8SA2pvYiI0Cg9SZWdpc3RlclJlcXVlc3QSEwoLZGVzY3Jp",
            "cHRpb24YASABKAkSDAoEdGV4dBgCIAEoCSIsChBSZWdpc3RlclJlc3BvbnNl",
            "EgoKAmlkGAEgASgJEgwKBHRleHQYAiABKAkiNAoQUHJvY2Vzc2luZ1Jlc3Vs",
            "dBIOCgZzdGF0dXMYASABKAkSEAoIcmVzcG9uc2UYAiABKAkygwEKA0pvYhI3",
            "CghSZWdpc3RlchIULmpvYi5SZWdpc3RlclJlcXVlc3QaFS5qb2IuUmVnaXN0",
            "ZXJSZXNwb25zZRJDChNHZXRQcm9jZXNzaW5nUmVzdWx0EhUuam9iLlJlZ2lz",
            "dGVyUmVzcG9uc2UaFS5qb2IuUHJvY2Vzc2luZ1Jlc3VsdEINqgIKQmFja2Vu",
            "ZEFwaWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BackendApi.RegisterRequest), global::BackendApi.RegisterRequest.Parser, new[]{ "Description", "Text" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BackendApi.RegisterResponse), global::BackendApi.RegisterResponse.Parser, new[]{ "Id", "Text" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BackendApi.ProcessingResult), global::BackendApi.ProcessingResult.Parser, new[]{ "Status", "Response" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class RegisterRequest : pb::IMessage<RegisterRequest> {
    private static readonly pb::MessageParser<RegisterRequest> _parser = new pb::MessageParser<RegisterRequest>(() => new RegisterRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegisterRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BackendApi.JobReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterRequest(RegisterRequest other) : this() {
      description_ = other.description_;
      text_ = other.text_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterRequest Clone() {
      return new RegisterRequest(this);
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 1;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 2;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegisterRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegisterRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      if (Text != other.Text) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Description.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Description);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Text);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegisterRequest other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Description = input.ReadString();
            break;
          }
          case 18: {
            Text = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class RegisterResponse : pb::IMessage<RegisterResponse> {
    private static readonly pb::MessageParser<RegisterResponse> _parser = new pb::MessageParser<RegisterResponse>(() => new RegisterResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegisterResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BackendApi.JobReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterResponse(RegisterResponse other) : this() {
      id_ = other.id_;
      text_ = other.text_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterResponse Clone() {
      return new RegisterResponse(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 2;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegisterResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegisterResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Text != other.Text) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Text);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegisterResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Text = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ProcessingResult : pb::IMessage<ProcessingResult> {
    private static readonly pb::MessageParser<ProcessingResult> _parser = new pb::MessageParser<ProcessingResult>(() => new ProcessingResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProcessingResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BackendApi.JobReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProcessingResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProcessingResult(ProcessingResult other) : this() {
      status_ = other.status_;
      response_ = other.response_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProcessingResult Clone() {
      return new ProcessingResult(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private string status_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Status {
      get { return status_; }
      set {
        status_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 2;
    private string response_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Response {
      get { return response_; }
      set {
        response_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProcessingResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProcessingResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (Response != other.Response) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status.Length != 0) hash ^= Status.GetHashCode();
      if (Response.Length != 0) hash ^= Response.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Status);
      }
      if (Response.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Response);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Status);
      }
      if (Response.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Response);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProcessingResult other) {
      if (other == null) {
        return;
      }
      if (other.Status.Length != 0) {
        Status = other.Status;
      }
      if (other.Response.Length != 0) {
        Response = other.Response;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Status = input.ReadString();
            break;
          }
          case 18: {
            Response = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code