using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Runtime;

public class LibraryInvoker_2_0_8_0 : LibraryInvokerOnInstance
{
    private record LibraryMethodInfo(MethodInfo Method, string? ValueSetId, string? DeclarationName)
    {
        public LibraryMethodInfo(MethodInfo Method) : this(
            Method,
            ValueSetId: Method.GetCustomAttribute<CqlValueSetAttribute>()?.Id,
            DeclarationName: Method.GetCustomAttribute<CqlDeclarationAttribute>()?.Name) { }
    }

    public LibraryInvoker_2_0_8_0(
        ILibrary library) : base(library)
    {
        var libraryType = library.GetType();
        var libraryMethodInfos = libraryType
                                 .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                                 .SelectToArray(m => new LibraryMethodInfo(m));
        Declarations = libraryMethodInfos
                       .SelectWhereNotNull(o => o.DeclarationName is { } declarationName
                                                && o.Method.GetParameters() is [{ } p0]
                                                && p0.ParameterType == typeof(CqlContext)
                                                    ? (LibraryDeclarationInvoker)new LibraryDeclarationInvoker_2_0_8_0(declarationName, Library, o.Method)
                                                    : null)
                       .ToImmutableDictionary(o => o.DeclarationName);
    }

    public override IReadOnlyDictionary<string, LibraryDeclarationInvoker> Declarations { get; }
}

public class LibraryDeclarationInvoker_2_0_8_0(
    string declarationName,
    ILibrary library,
    MethodInfo methodInfo) : LibraryDeclarationInvoker(declarationName, library, methodInfo)
{
    public override object? Invoke(CqlContext cqlContext)
    {
        return InvokeMethod(cqlContext);
    }
}