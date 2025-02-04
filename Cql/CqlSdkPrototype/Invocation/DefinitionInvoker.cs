using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Invocation;


/// <summary>
/// Abstract class representing a definition invoker.
/// </summary>
/// <param name="definitionName">The name of the definition.</param>
/// <param name="library">The library containing the definition.</param>
/// <param name="methodInfo">The method information for the definition.</param>
/// <param name="tagValuesByName">The tag values associated with the definition.</param>
/// <param name="valueSetId">The value set identifier, if any.</param>
public abstract class DefinitionInvoker(
    string definitionName,
    ILibrary library,
    MethodInfo methodInfo,
    IReadOnlyDictionary<string, string> tagValuesByName,
    string? valueSetId)
{
    /// <summary>
    /// Gets the name of the definition.
    /// </summary>
    public string DefinitionName { get; } = definitionName;

    /// <summary>
    /// Gets the return type of the method.
    /// </summary>
    public Type ReturnType => MethodInfo.ReturnType;

    /// <summary>
    /// Gets the tag values associated with the definition.
    /// </summary>
    public IReadOnlyDictionary<string, string> TagValuesByName { get; } = tagValuesByName;

    /// <summary>
    /// Gets the value set identifier, if any.
    /// </summary>
    public string? ValueSetId { get; } = valueSetId;

    /// <summary>
    /// Gets the library containing the definition.
    /// </summary>
    private ILibrary Library { get; } = library; // Might decide to make this public later

    /// <summary>
    /// Gets the method information for the definition.
    /// </summary>
    private MethodInfo MethodInfo { get; } = methodInfo;

    /// <summary>
    /// Invokes the definition with the given CQL context.
    /// </summary>
    /// <param name="cqlContext">The CQL context.</param>
    /// <returns>The result of the invocation.</returns>
    public abstract object? Invoke(CqlContext cqlContext);

    /// <summary>
    /// Invokes the method with the specified parameters.
    /// </summary>
    /// <param name="parameters">The parameters to pass to the method.</param>
    /// <returns>The result of the method invocation.</returns>
    protected object? InvokeMethod(params object?[] parameters)
    {
        MethodInfo methodInfo = MethodInfo;
        ILibrary library = Library;
        var result = methodInfo.Invoke(library, BindingFlags.DoNotWrapExceptions, null, parameters, CultureInfo.InvariantCulture);
        return result;
    }
}
