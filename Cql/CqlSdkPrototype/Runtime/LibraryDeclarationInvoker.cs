using System.Globalization;
using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Runtime;

public abstract record LibraryDeclarationInvoker(string DeclarationName)
{
    public abstract object? Invoke(CqlContext cqlContext);

    protected static object? InvokeMethod(
        ILibrary library,
        MethodInfo methodInfo,
        object?[] parameters)
    {
        var result = methodInfo.Invoke(library, BindingFlags.DoNotWrapExceptions, null, parameters, CultureInfo.InvariantCulture);
        return result;
    }
}