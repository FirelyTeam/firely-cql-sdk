using CqlSdkPrototype.Invocation.Extensibility;

namespace CqlSdkPrototype.Invocation.Internal;

internal interface IInvocationApiInternal : IInvocationApi
{
    InvocationApiServices Services { get; }
}