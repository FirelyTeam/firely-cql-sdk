using System.Globalization;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Runtime.Invokers;

public abstract class LibraryDefinitionInvoker(
    string declarationName,
    ILibrary library,
    MethodInfo methodInfo,
    string? valueSetId)
{
    public string DeclarationName { get; } = declarationName;
    public Type ReturnType => MethodInfo.ReturnType;
    private ILibrary Library { get; } = library;
    private MethodInfo MethodInfo { get; } = methodInfo;
    public string? ValueSetId { get; } = valueSetId;

    public abstract object? Invoke(CqlContext cqlContext);

    protected object? InvokeMethod(params object?[] parameters)
    {
        MethodInfo methodInfo = MethodInfo;
        ILibrary library = Library;
        var result = methodInfo.Invoke(library, BindingFlags.DoNotWrapExceptions, null, parameters, CultureInfo.InvariantCulture);
        return result;
    }
}