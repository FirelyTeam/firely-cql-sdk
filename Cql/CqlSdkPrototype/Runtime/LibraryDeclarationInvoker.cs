using System.Globalization;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Runtime;

public abstract class LibraryDeclarationInvoker(
    string declarationName,
    ILibrary library,
    MethodInfo methodInfo)
{
    public string DeclarationName { get; } = declarationName;
    public Type ReturnType => MethodInfo.ReturnType;

    protected ILibrary Library { get; } = library;
    protected MethodInfo MethodInfo { get; } = methodInfo;

    public abstract object? Invoke(CqlContext cqlContext);

    protected object? InvokeMethod(params object?[] parameters)
    {
        MethodInfo methodInfo = MethodInfo;
        ILibrary library = Library;
        System.Diagnostics.Debugger.Launch();
        var result = methodInfo.Invoke(library, BindingFlags.DoNotWrapExceptions, null, parameters, CultureInfo.InvariantCulture);
        return result;
    }
}