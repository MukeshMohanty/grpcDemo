// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: messages.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.Messages {

  /// <summary>Holder for reflection information generated from messages.proto</summary>
  public static partial class MessagesReflection {

    #region Descriptor
    /// <summary>File descriptor for messages.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5tZXNzYWdlcy5wcm90byKHAQoIRW1wbG95ZWUSCgoCaWQYASABKAUSEwoL",
            "YmFkZ2VOdW1iZXIYAiABKAUSEQoJZmlyc3ROYW1lGAMgASgJEhAKCGxhc3RO",
            "YW1lGAQgASgJEhwKFHZhY2F0aW9uQWNjdXJhdGVSYXRlGAUgASgCEhcKD3Zh",
            "Y2F0aW9uQWNjdXJlZBgGIAEoAiIPCg1HZXRBbGxSZXF1ZXN0Ii4KF0dldEJ5",
            "QmFkZ2VOdW1iZXJSZXF1ZXN0EhMKC2JhZGdlTnVtYmVyGAEgASgFIi4KD0Vt",
            "cGxveWVlUmVxdWVzdBIbCghlbXBsb3llZRgBIAEoCzIJLkVtcGxveWVlIi8K",
            "EEVtcGxveWVlUmVzcG9uc2USGwoIZW1wbG95ZWUYASABKAsyCS5FbXBsb3ll",
            "ZSIfCg9BZGRQaG90b1JlcXVlc3QSDAoEZGF0YRgBIAEoDCIgChBBZGRQaG90",
            "b1Jlc3BvbnNlEgwKBGlzT2sYASABKAgylQIKD0VtcGxveWVlU2VydmljZRI/",
            "ChBHZXRCeUJhZGdlTnVtYmVyEhguR2V0QnlCYWRnZU51bWJlclJlcXVlc3Qa",
            "ES5FbXBsb3llZVJlc3BvbnNlEi0KBkdldEFsbBIOLkdldEFsbFJlcXVlc3Qa",
            "ES5FbXBsb3llZVJlc3BvbnNlMAESKwoEU2F2ZRIQLkVtcGxveWVlUmVxdWVz",
            "dBoRLkVtcGxveWVlUmVzcG9uc2USMgoHU2F2ZUFsbBIQLkVtcGxveWVlUmVx",
            "dWVzdBoRLkVtcGxveWVlUmVzcG9uc2UoATABEjEKCEFkZFBob3RvEhAuQWRk",
            "UGhvdG9SZXF1ZXN0GhEuQWRkUGhvdG9SZXNwb25zZSgBQh1aC2dycGNkZW1v",
            "L3BiqgINR3JwYy5NZXNzYWdlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Messages.Employee), global::Grpc.Messages.Employee.Parser, new[]{ "Id", "BadgeNumber", "FirstName", "LastName", "VacationAccurateRate", "VacationAccured" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Messages.GetAllRequest), global::Grpc.Messages.GetAllRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Messages.GetByBadgeNumberRequest), global::Grpc.Messages.GetByBadgeNumberRequest.Parser, new[]{ "BadgeNumber" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Messages.EmployeeRequest), global::Grpc.Messages.EmployeeRequest.Parser, new[]{ "Employee" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Messages.EmployeeResponse), global::Grpc.Messages.EmployeeResponse.Parser, new[]{ "Employee" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Messages.AddPhotoRequest), global::Grpc.Messages.AddPhotoRequest.Parser, new[]{ "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Messages.AddPhotoResponse), global::Grpc.Messages.AddPhotoResponse.Parser, new[]{ "IsOk" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Employee : pb::IMessage<Employee> {
    private static readonly pb::MessageParser<Employee> _parser = new pb::MessageParser<Employee>(() => new Employee());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Employee> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Messages.MessagesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee(Employee other) : this() {
      id_ = other.id_;
      badgeNumber_ = other.badgeNumber_;
      firstName_ = other.firstName_;
      lastName_ = other.lastName_;
      vacationAccurateRate_ = other.vacationAccurateRate_;
      vacationAccured_ = other.vacationAccured_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee Clone() {
      return new Employee(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "badgeNumber" field.</summary>
    public const int BadgeNumberFieldNumber = 2;
    private int badgeNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BadgeNumber {
      get { return badgeNumber_; }
      set {
        badgeNumber_ = value;
      }
    }

    /// <summary>Field number for the "firstName" field.</summary>
    public const int FirstNameFieldNumber = 3;
    private string firstName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FirstName {
      get { return firstName_; }
      set {
        firstName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lastName" field.</summary>
    public const int LastNameFieldNumber = 4;
    private string lastName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastName {
      get { return lastName_; }
      set {
        lastName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vacationAccurateRate" field.</summary>
    public const int VacationAccurateRateFieldNumber = 5;
    private float vacationAccurateRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float VacationAccurateRate {
      get { return vacationAccurateRate_; }
      set {
        vacationAccurateRate_ = value;
      }
    }

    /// <summary>Field number for the "vacationAccured" field.</summary>
    public const int VacationAccuredFieldNumber = 6;
    private float vacationAccured_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float VacationAccured {
      get { return vacationAccured_; }
      set {
        vacationAccured_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Employee);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Employee other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (BadgeNumber != other.BadgeNumber) return false;
      if (FirstName != other.FirstName) return false;
      if (LastName != other.LastName) return false;
      if (VacationAccurateRate != other.VacationAccurateRate) return false;
      if (VacationAccured != other.VacationAccured) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (BadgeNumber != 0) hash ^= BadgeNumber.GetHashCode();
      if (FirstName.Length != 0) hash ^= FirstName.GetHashCode();
      if (LastName.Length != 0) hash ^= LastName.GetHashCode();
      if (VacationAccurateRate != 0F) hash ^= VacationAccurateRate.GetHashCode();
      if (VacationAccured != 0F) hash ^= VacationAccured.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (BadgeNumber != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BadgeNumber);
      }
      if (FirstName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(FirstName);
      }
      if (LastName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LastName);
      }
      if (VacationAccurateRate != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(VacationAccurateRate);
      }
      if (VacationAccured != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(VacationAccured);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (BadgeNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeNumber);
      }
      if (FirstName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FirstName);
      }
      if (LastName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LastName);
      }
      if (VacationAccurateRate != 0F) {
        size += 1 + 4;
      }
      if (VacationAccured != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Employee other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.BadgeNumber != 0) {
        BadgeNumber = other.BadgeNumber;
      }
      if (other.FirstName.Length != 0) {
        FirstName = other.FirstName;
      }
      if (other.LastName.Length != 0) {
        LastName = other.LastName;
      }
      if (other.VacationAccurateRate != 0F) {
        VacationAccurateRate = other.VacationAccurateRate;
      }
      if (other.VacationAccured != 0F) {
        VacationAccured = other.VacationAccured;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            BadgeNumber = input.ReadInt32();
            break;
          }
          case 26: {
            FirstName = input.ReadString();
            break;
          }
          case 34: {
            LastName = input.ReadString();
            break;
          }
          case 45: {
            VacationAccurateRate = input.ReadFloat();
            break;
          }
          case 53: {
            VacationAccured = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetAllRequest : pb::IMessage<GetAllRequest> {
    private static readonly pb::MessageParser<GetAllRequest> _parser = new pb::MessageParser<GetAllRequest>(() => new GetAllRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Messages.MessagesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest(GetAllRequest other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest Clone() {
      return new GetAllRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllRequest other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class GetByBadgeNumberRequest : pb::IMessage<GetByBadgeNumberRequest> {
    private static readonly pb::MessageParser<GetByBadgeNumberRequest> _parser = new pb::MessageParser<GetByBadgeNumberRequest>(() => new GetByBadgeNumberRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetByBadgeNumberRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Messages.MessagesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest(GetByBadgeNumberRequest other) : this() {
      badgeNumber_ = other.badgeNumber_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetByBadgeNumberRequest Clone() {
      return new GetByBadgeNumberRequest(this);
    }

    /// <summary>Field number for the "badgeNumber" field.</summary>
    public const int BadgeNumberFieldNumber = 1;
    private int badgeNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BadgeNumber {
      get { return badgeNumber_; }
      set {
        badgeNumber_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetByBadgeNumberRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetByBadgeNumberRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BadgeNumber != other.BadgeNumber) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BadgeNumber != 0) hash ^= BadgeNumber.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BadgeNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BadgeNumber);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BadgeNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BadgeNumber);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetByBadgeNumberRequest other) {
      if (other == null) {
        return;
      }
      if (other.BadgeNumber != 0) {
        BadgeNumber = other.BadgeNumber;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            BadgeNumber = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmployeeRequest : pb::IMessage<EmployeeRequest> {
    private static readonly pb::MessageParser<EmployeeRequest> _parser = new pb::MessageParser<EmployeeRequest>(() => new EmployeeRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmployeeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Messages.MessagesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeRequest(EmployeeRequest other) : this() {
      Employee = other.employee_ != null ? other.Employee.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeRequest Clone() {
      return new EmployeeRequest(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private global::Grpc.Messages.Employee employee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.Messages.Employee Employee {
      get { return employee_; }
      set {
        employee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmployeeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmployeeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Employee, other.Employee)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (employee_ != null) hash ^= Employee.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (employee_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Employee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (employee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Employee);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmployeeRequest other) {
      if (other == null) {
        return;
      }
      if (other.employee_ != null) {
        if (employee_ == null) {
          employee_ = new global::Grpc.Messages.Employee();
        }
        Employee.MergeFrom(other.Employee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (employee_ == null) {
              employee_ = new global::Grpc.Messages.Employee();
            }
            input.ReadMessage(employee_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmployeeResponse : pb::IMessage<EmployeeResponse> {
    private static readonly pb::MessageParser<EmployeeResponse> _parser = new pb::MessageParser<EmployeeResponse>(() => new EmployeeResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmployeeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Messages.MessagesReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeResponse(EmployeeResponse other) : this() {
      Employee = other.employee_ != null ? other.Employee.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmployeeResponse Clone() {
      return new EmployeeResponse(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private global::Grpc.Messages.Employee employee_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.Messages.Employee Employee {
      get { return employee_; }
      set {
        employee_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmployeeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmployeeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Employee, other.Employee)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (employee_ != null) hash ^= Employee.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (employee_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Employee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (employee_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Employee);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmployeeResponse other) {
      if (other == null) {
        return;
      }
      if (other.employee_ != null) {
        if (employee_ == null) {
          employee_ = new global::Grpc.Messages.Employee();
        }
        Employee.MergeFrom(other.Employee);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (employee_ == null) {
              employee_ = new global::Grpc.Messages.Employee();
            }
            input.ReadMessage(employee_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddPhotoRequest : pb::IMessage<AddPhotoRequest> {
    private static readonly pb::MessageParser<AddPhotoRequest> _parser = new pb::MessageParser<AddPhotoRequest>(() => new AddPhotoRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddPhotoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Messages.MessagesReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoRequest(AddPhotoRequest other) : this() {
      data_ = other.data_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoRequest Clone() {
      return new AddPhotoRequest(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddPhotoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddPhotoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data != other.Data) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Data.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Data);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddPhotoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AddPhotoResponse : pb::IMessage<AddPhotoResponse> {
    private static readonly pb::MessageParser<AddPhotoResponse> _parser = new pb::MessageParser<AddPhotoResponse>(() => new AddPhotoResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddPhotoResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Messages.MessagesReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoResponse(AddPhotoResponse other) : this() {
      isOk_ = other.isOk_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddPhotoResponse Clone() {
      return new AddPhotoResponse(this);
    }

    /// <summary>Field number for the "isOk" field.</summary>
    public const int IsOkFieldNumber = 1;
    private bool isOk_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsOk {
      get { return isOk_; }
      set {
        isOk_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddPhotoResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddPhotoResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOk != other.IsOk) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOk != false) hash ^= IsOk.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IsOk != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsOk);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsOk != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddPhotoResponse other) {
      if (other == null) {
        return;
      }
      if (other.IsOk != false) {
        IsOk = other.IsOk;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            IsOk = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
