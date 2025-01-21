using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Invocation;

public abstract class DefinitionInvoker(
    string declarationName,
    ILibrary library,
    MethodInfo methodInfo,
    IReadOnlyDictionary<string, string> tagValuesByName,
    string? valueSetId)
{
    public string DeclarationName { get; } = declarationName;
    public Type ReturnType => MethodInfo.ReturnType;
    public IReadOnlyDictionary<string, string> TagValuesByName { get; } = tagValuesByName;
    public string? ValueSetId { get; } = valueSetId;
    private ILibrary Library { get; } = library; // Might decide to make this public later
    private MethodInfo MethodInfo { get; } = methodInfo;
    public abstract object? Invoke(CqlContext cqlContext);

    protected object? InvokeMethod(params object?[] parameters)
    {
        MethodInfo methodInfo = MethodInfo;
        ILibrary library = Library;
        var result = methodInfo.Invoke(library, BindingFlags.DoNotWrapExceptions, null, parameters, CultureInfo.InvariantCulture);
        return result;
    }
}