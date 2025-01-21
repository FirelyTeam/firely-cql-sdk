using CqlSdkPrototype.Cql.Extensibility;

namespace CqlSdkPrototype.Cql.Internal;

/// <summary>
/// Used to gain internal access to the state of the CQL API.
/// </summary>
internal interface ICqlApiInternal : ICqlApi
{
    CqlApiServices Services { get; }
}