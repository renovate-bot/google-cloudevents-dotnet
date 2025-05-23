// Copyright 2025, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/events/cloud/beyondcorp/clientgateways/v1/data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1 {

  /// <summary>Holder for reflection information generated from google/events/cloud/beyondcorp/clientgateways/v1/data.proto</summary>
  public static partial class DataReflection {

    #region Descriptor
    /// <summary>File descriptor for google/events/cloud/beyondcorp/clientgateways/v1/data.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvZXZlbnRzL2Nsb3VkL2JleW9uZGNvcnAvY2xpZW50Z2F0ZXdh",
            "eXMvdjEvZGF0YS5wcm90bxIwZ29vZ2xlLmV2ZW50cy5jbG91ZC5iZXlvbmRj",
            "b3JwLmNsaWVudGdhdGV3YXlzLnYxGh9nb29nbGUvcHJvdG9idWYvdGltZXN0",
            "YW1wLnByb3RvIu8CCg1DbGllbnRHYXRld2F5EgwKBG5hbWUYASABKAkSLwoL",
            "Y3JlYXRlX3RpbWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "Ei8KC3VwZGF0ZV90aW1lGAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
            "dGFtcBJUCgVzdGF0ZRgEIAEoDjJFLmdvb2dsZS5ldmVudHMuY2xvdWQuYmV5",
            "b25kY29ycC5jbGllbnRnYXRld2F5cy52MS5DbGllbnRHYXRld2F5LlN0YXRl",
            "EgoKAmlkGAUgASgJEiAKGGNsaWVudF9jb25uZWN0b3Jfc2VydmljZRgGIAEo",
            "CSJqCgVTdGF0ZRIVChFTVEFURV9VTlNQRUNJRklFRBAAEgwKCENSRUFUSU5H",
            "EAESDAoIVVBEQVRJTkcQAhIMCghERUxFVElORxADEgsKB1JVTk5JTkcQBBII",
            "CgRET1dOEAUSCQoFRVJST1IQBiJ7ChZDbGllbnRHYXRld2F5RXZlbnREYXRh",
            "ElUKB3BheWxvYWQYASABKAsyPy5nb29nbGUuZXZlbnRzLmNsb3VkLmJleW9u",
            "ZGNvcnAuY2xpZW50Z2F0ZXdheXMudjEuQ2xpZW50R2F0ZXdheUgAiAEBQgoK",
            "CF9wYXlsb2FkQqcBqgI5R29vZ2xlLkV2ZW50cy5Qcm90b2J1Zi5DbG91ZC5C",
            "ZXlvbmRDb3JwLkNsaWVudEdhdGV3YXlzLlYxygIwR29vZ2xlXEV2ZW50c1xD",
            "bG91ZFxCZXlvbmRDb3JwXENsaWVudEdhdGV3YXlzXFYx6gI1R29vZ2xlOjpF",
            "dmVudHM6OkNsb3VkOjpCZXlvbmRDb3JwOjpDbGllbnRHYXRld2F5czo6VjFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway), global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Parser, new[]{ "Name", "CreateTime", "UpdateTime", "State", "Id", "ClientConnectorService" }, null, new[]{ typeof(global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGatewayEventData), global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGatewayEventData.Parser, new[]{ "Payload" }, new[]{ "Payload" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing ClientGateway object.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ClientGateway : pb::IMessage<ClientGateway>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientGateway> _parser = new pb::MessageParser<ClientGateway>(() => new ClientGateway());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientGateway> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.DataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGateway() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGateway(ClientGateway other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      state_ = other.state_;
      id_ = other.id_;
      clientConnectorService_ = other.clientConnectorService_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGateway Clone() {
      return new ClientGateway(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. name of resource. The name is ignored during creation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. [Output only] Create time stamp.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. [Output only] Update time stamp.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State state_ = global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State.Unspecified;
    /// <summary>
    /// Output only. The operational state of the gateway.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 5;
    private string id_ = "";
    /// <summary>
    /// Output only. A unique identifier for the instance generated by the system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_connector_service" field.</summary>
    public const int ClientConnectorServiceFieldNumber = 6;
    private string clientConnectorService_ = "";
    /// <summary>
    /// Output only. The client connector service name that the client gateway is
    /// associated to. Client Connector Services, named as follows:
    ///   `projects/{project_id}/locations/{location_id}/client_connector_services/{client_connector_service_id}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientConnectorService {
      get { return clientConnectorService_; }
      set {
        clientConnectorService_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientGateway);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientGateway other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (State != other.State) return false;
      if (Id != other.Id) return false;
      if (ClientConnectorService != other.ClientConnectorService) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (State != global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (ClientConnectorService.Length != 0) hash ^= ClientConnectorService.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UpdateTime);
      }
      if (State != global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Id);
      }
      if (ClientConnectorService.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ClientConnectorService);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UpdateTime);
      }
      if (State != global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Id);
      }
      if (ClientConnectorService.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ClientConnectorService);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (State != global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (ClientConnectorService.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientConnectorService);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientGateway other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.State != global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.ClientConnectorService.Length != 0) {
        ClientConnectorService = other.ClientConnectorService;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 32: {
            State = (global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            Id = input.ReadString();
            break;
          }
          case 50: {
            ClientConnectorService = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 32: {
            State = (global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            Id = input.ReadString();
            break;
          }
          case 50: {
            ClientConnectorService = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ClientGateway message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Represents the different states of a gateway.
      /// </summary>
      public enum State {
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Gateway is being created.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// Gateway is being updated.
        /// </summary>
        [pbr::OriginalName("UPDATING")] Updating = 2,
        /// <summary>
        /// Gateway is being deleted.
        /// </summary>
        [pbr::OriginalName("DELETING")] Deleting = 3,
        /// <summary>
        /// Gateway is running.
        /// </summary>
        [pbr::OriginalName("RUNNING")] Running = 4,
        /// <summary>
        /// Gateway is down and may be restored in the future.
        /// This happens when CCFE sends ProjectState = OFF.
        /// </summary>
        [pbr::OriginalName("DOWN")] Down = 5,
        /// <summary>
        /// ClientGateway encountered an error and is in indeterministic state.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 6,
      }

    }
    #endregion

  }

  /// <summary>
  /// The data within all ClientGateway events.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ClientGatewayEventData : pb::IMessage<ClientGatewayEventData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientGatewayEventData> _parser = new pb::MessageParser<ClientGatewayEventData>(() => new ClientGatewayEventData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientGatewayEventData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.DataReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGatewayEventData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGatewayEventData(ClientGatewayEventData other) : this() {
      payload_ = other.payload_ != null ? other.payload_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGatewayEventData Clone() {
      return new ClientGatewayEventData(this);
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 1;
    private global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway payload_;
    /// <summary>
    /// Optional. The ClientGateway event payload. Unset for deletion events.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientGatewayEventData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientGatewayEventData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Payload, other.Payload)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (payload_ != null) hash ^= Payload.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (payload_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (payload_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientGatewayEventData other) {
      if (other == null) {
        return;
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          Payload = new global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway();
        }
        Payload.MergeFrom(other.Payload);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (payload_ == null) {
              Payload = new global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway();
            }
            input.ReadMessage(Payload);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (payload_ == null) {
              Payload = new global::Google.Events.Protobuf.Cloud.BeyondCorp.ClientGateways.V1.ClientGateway();
            }
            input.ReadMessage(Payload);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
