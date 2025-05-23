// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/person.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PersonApi.Protos {
  public static partial class PersonService
  {
    static readonly string __ServiceName = "PersonService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PersonApi.Protos.Person> __Marshaller_Person = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PersonApi.Protos.Person.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PersonApi.Protos.PersonResponse> __Marshaller_PersonResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PersonApi.Protos.PersonResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PersonApi.Protos.PersonIdRequest> __Marshaller_PersonIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PersonApi.Protos.PersonIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PersonApi.Protos.PersonList> __Marshaller_PersonList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PersonApi.Protos.PersonList.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PersonApi.Protos.Person, global::PersonApi.Protos.PersonResponse> __Method_CreatePerson = new grpc::Method<global::PersonApi.Protos.Person, global::PersonApi.Protos.PersonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreatePerson",
        __Marshaller_Person,
        __Marshaller_PersonResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PersonApi.Protos.PersonIdRequest, global::PersonApi.Protos.Person> __Method_GetPerson = new grpc::Method<global::PersonApi.Protos.PersonIdRequest, global::PersonApi.Protos.Person>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPerson",
        __Marshaller_PersonIdRequest,
        __Marshaller_Person);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PersonApi.Protos.Person, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdatePerson = new grpc::Method<global::PersonApi.Protos.Person, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePerson",
        __Marshaller_Person,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PersonApi.Protos.PersonIdRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeletePerson = new grpc::Method<global::PersonApi.Protos.PersonIdRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePerson",
        __Marshaller_PersonIdRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PersonApi.Protos.PersonList> __Method_GetAllPersons = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::PersonApi.Protos.PersonList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPersons",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_PersonList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PersonApi.Protos.PersonReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PersonService</summary>
    [grpc::BindServiceMethod(typeof(PersonService), "BindService")]
    public abstract partial class PersonServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PersonApi.Protos.PersonResponse> CreatePerson(global::PersonApi.Protos.Person request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PersonApi.Protos.Person> GetPerson(global::PersonApi.Protos.PersonIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdatePerson(global::PersonApi.Protos.Person request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeletePerson(global::PersonApi.Protos.PersonIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PersonApi.Protos.PersonList> GetAllPersons(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PersonServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreatePerson, serviceImpl.CreatePerson)
          .AddMethod(__Method_GetPerson, serviceImpl.GetPerson)
          .AddMethod(__Method_UpdatePerson, serviceImpl.UpdatePerson)
          .AddMethod(__Method_DeletePerson, serviceImpl.DeletePerson)
          .AddMethod(__Method_GetAllPersons, serviceImpl.GetAllPersons).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PersonServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreatePerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PersonApi.Protos.Person, global::PersonApi.Protos.PersonResponse>(serviceImpl.CreatePerson));
      serviceBinder.AddMethod(__Method_GetPerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PersonApi.Protos.PersonIdRequest, global::PersonApi.Protos.Person>(serviceImpl.GetPerson));
      serviceBinder.AddMethod(__Method_UpdatePerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PersonApi.Protos.Person, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdatePerson));
      serviceBinder.AddMethod(__Method_DeletePerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PersonApi.Protos.PersonIdRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeletePerson));
      serviceBinder.AddMethod(__Method_GetAllPersons, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::PersonApi.Protos.PersonList>(serviceImpl.GetAllPersons));
    }

  }
}
#endregion
