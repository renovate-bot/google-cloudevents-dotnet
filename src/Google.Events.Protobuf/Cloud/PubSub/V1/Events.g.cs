// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/events/cloud/pubsub/v1/events.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Events.Protobuf.Cloud.PubSub.V1 {

  /// <summary>Holder for reflection information generated from google/events/cloud/pubsub/v1/events.proto</summary>
  public static partial class EventsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/events/cloud/pubsub/v1/events.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvZXZlbnRzL2Nsb3VkL3B1YnN1Yi92MS9ldmVudHMucHJvdG8S",
            "HWdvb2dsZS5ldmVudHMuY2xvdWQucHVic3ViLnYxGh5nb29nbGUvZXZlbnRz",
            "L2Nsb3VkZXZlbnQucHJvdG8ijQEKFU1lc3NhZ2VQdWJsaXNoZWRFdmVudBJB",
            "CgRkYXRhGAEgASgLMjMuZ29vZ2xlLmV2ZW50cy5jbG91ZC5wdWJzdWIudjEu",
            "TWVzc2FnZVB1Ymxpc2hlZERhdGE6MYLiCS1nb29nbGUuY2xvdWQucHVic3Vi",
            "LnRvcGljLnYxLm1lc3NhZ2VQdWJsaXNoZWQiawoUTWVzc2FnZVB1Ymxpc2hl",
            "ZERhdGESPQoHbWVzc2FnZRgBIAEoCzIsLmdvb2dsZS5ldmVudHMuY2xvdWQu",
            "cHVic3ViLnYxLlB1YnN1Yk1lc3NhZ2USFAoMc3Vic2NyaXB0aW9uGAIgASgJ",
            "IrYBCg1QdWJzdWJNZXNzYWdlEgwKBGRhdGEYASABKAwSUAoKYXR0cmlidXRl",
            "cxgCIAMoCzI8Lmdvb2dsZS5ldmVudHMuY2xvdWQucHVic3ViLnYxLlB1YnN1",
            "Yk1lc3NhZ2UuQXR0cmlidXRlc0VudHJ5EhIKCm1lc3NhZ2VfaWQYAyABKAka",
            "MQoPQXR0cmlidXRlc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEo",
            "CToCOAFCKaoCJkdvb2dsZS5FdmVudHMuUHJvdG9idWYuQ2xvdWQuUHViU3Vi",
            "LlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Events.Protobuf.CloudeventReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedEvent), global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedEvent.Parser, new[]{ "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedData), global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedData.Parser, new[]{ "Message", "Subscription" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Events.Protobuf.Cloud.PubSub.V1.PubsubMessage), global::Google.Events.Protobuf.Cloud.PubSub.V1.PubsubMessage.Parser, new[]{ "Data", "Attributes", "MessageId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The CloudEvent raised when a PubSub message is published for a topic.
  /// </summary>
  public sealed partial class MessagePublishedEvent : pb::IMessage<MessagePublishedEvent> {
    private static readonly pb::MessageParser<MessagePublishedEvent> _parser = new pb::MessageParser<MessagePublishedEvent>(() => new MessagePublishedEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessagePublishedEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Cloud.PubSub.V1.EventsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePublishedEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePublishedEvent(MessagePublishedEvent other) : this() {
      data_ = other.data_ != null ? other.data_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePublishedEvent Clone() {
      return new MessagePublishedEvent(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedData data_;
    /// <summary>
    /// The data associated with the event.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedData Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessagePublishedEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessagePublishedEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (data_ != null) hash ^= Data.GetHashCode();
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
      if (data_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessagePublishedEvent other) {
      if (other == null) {
        return;
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedData();
        }
        Data.MergeFrom(other.Data);
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
            if (data_ == null) {
              Data = new global::Google.Events.Protobuf.Cloud.PubSub.V1.MessagePublishedData();
            }
            input.ReadMessage(Data);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The data received in an event when a message is published to a topic.
  /// </summary>
  public sealed partial class MessagePublishedData : pb::IMessage<MessagePublishedData> {
    private static readonly pb::MessageParser<MessagePublishedData> _parser = new pb::MessageParser<MessagePublishedData>(() => new MessagePublishedData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessagePublishedData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Cloud.PubSub.V1.EventsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePublishedData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePublishedData(MessagePublishedData other) : this() {
      message_ = other.message_ != null ? other.message_.Clone() : null;
      subscription_ = other.subscription_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePublishedData Clone() {
      return new MessagePublishedData(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private global::Google.Events.Protobuf.Cloud.PubSub.V1.PubsubMessage message_;
    /// <summary>
    /// The message that was published.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Events.Protobuf.Cloud.PubSub.V1.PubsubMessage Message {
      get { return message_; }
      set {
        message_ = value;
      }
    }

    /// <summary>Field number for the "subscription" field.</summary>
    public const int SubscriptionFieldNumber = 2;
    private string subscription_ = "";
    /// <summary>
    /// The resource name of the subscription for which this event was
    /// generated. The format of the value is
    /// `projects/{project-id}/subscriptions/{subscription-id}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Subscription {
      get { return subscription_; }
      set {
        subscription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessagePublishedData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessagePublishedData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Message, other.Message)) return false;
      if (Subscription != other.Subscription) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (message_ != null) hash ^= Message.GetHashCode();
      if (Subscription.Length != 0) hash ^= Subscription.GetHashCode();
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
      if (message_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Message);
      }
      if (Subscription.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Subscription);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (message_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Message);
      }
      if (Subscription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Subscription);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessagePublishedData other) {
      if (other == null) {
        return;
      }
      if (other.message_ != null) {
        if (message_ == null) {
          Message = new global::Google.Events.Protobuf.Cloud.PubSub.V1.PubsubMessage();
        }
        Message.MergeFrom(other.Message);
      }
      if (other.Subscription.Length != 0) {
        Subscription = other.Subscription;
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
            if (message_ == null) {
              Message = new global::Google.Events.Protobuf.Cloud.PubSub.V1.PubsubMessage();
            }
            input.ReadMessage(Message);
            break;
          }
          case 18: {
            Subscription = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A message published to a topic.
  /// </summary>
  public sealed partial class PubsubMessage : pb::IMessage<PubsubMessage> {
    private static readonly pb::MessageParser<PubsubMessage> _parser = new pb::MessageParser<PubsubMessage>(() => new PubsubMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PubsubMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Events.Protobuf.Cloud.PubSub.V1.EventsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PubsubMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PubsubMessage(PubsubMessage other) : this() {
      data_ = other.data_;
      attributes_ = other.attributes_.Clone();
      messageId_ = other.messageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PubsubMessage Clone() {
      return new PubsubMessage(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    /// The binary data in the message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attributes" field.</summary>
    public const int AttributesFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_attributes_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 18);
    private readonly pbc::MapField<string, string> attributes_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Attributes for this message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Attributes {
      get { return attributes_; }
    }

    /// <summary>Field number for the "message_id" field.</summary>
    public const int MessageIdFieldNumber = 3;
    private string messageId_ = "";
    /// <summary>
    /// ID of this message, assigned by the server when the message is published.
    /// Guaranteed to be unique within the topic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MessageId {
      get { return messageId_; }
      set {
        messageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PubsubMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PubsubMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Data != other.Data) return false;
      if (!Attributes.Equals(other.Attributes)) return false;
      if (MessageId != other.MessageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      hash ^= Attributes.GetHashCode();
      if (MessageId.Length != 0) hash ^= MessageId.GetHashCode();
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
      if (Data.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Data);
      }
      attributes_.WriteTo(output, _map_attributes_codec);
      if (MessageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(MessageId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      size += attributes_.CalculateSize(_map_attributes_codec);
      if (MessageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PubsubMessage other) {
      if (other == null) {
        return;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      attributes_.Add(other.attributes_);
      if (other.MessageId.Length != 0) {
        MessageId = other.MessageId;
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
            Data = input.ReadBytes();
            break;
          }
          case 18: {
            attributes_.AddEntriesFrom(input, _map_attributes_codec);
            break;
          }
          case 26: {
            MessageId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code