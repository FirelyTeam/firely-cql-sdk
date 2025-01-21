using CqlSdkPrototype.Elm.Extensibility;

namespace CqlSdkPrototype.Elm.Internal;

/// <summary>
/// Used to gain internal access to the state of the ELM API.
/// </summary>
internal interface IElmApiInternal : IElmApi
{
    ElmApiServices Services { get; }
}