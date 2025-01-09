using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Logging;

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
        Definitions = libraryMethodInfos
                       .SelectWhereNotNull(o => o.DeclarationName is { } declarationName
                                                && o.Method.GetParameters() is [{ } p0]
                                                && p0.ParameterType == typeof(CqlContext)
                                                    ? (LibraryDefinitionInvoker)new DefinitionInvoker(declarationName, Library, o.Method)
                                                    : null)
                       .ToImmutableDictionary(o => o.DeclarationName);
    }

    public override IReadOnlyDictionary<string, LibraryDefinitionInvoker> Definitions { get; }

    private static object GetLibraryFromStaticInstanceProperty(Type libraryType)
    {
        return libraryType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
               ?? throw new InvalidOperationException($"Unable to create an instance of {libraryType.FullName}");
    }

    public new static bool TryCreateFromType(
        CqlRuntimeApi cqlRuntimeApi,
        Type libraryType,
        [NotNullWhen(true)] out LibraryInvoker? libraryInvoker)
    {
        var logger = cqlRuntimeApi.Options.ServiceProvider.GetLogger<LibraryInvoker_2_0_8_0>();
        libraryInvoker = null;
        if (GetLibraryFromStaticInstanceProperty(libraryType) is not ILibrary asILibrary)
        {
            logger?.LogDebug(
                "Skipping type {type} because it does not implement ILibrary.",
                libraryType.FullName);
            return false;
        }
        libraryInvoker = new LibraryInvoker_2_0_8_0(asILibrary);
        return true;
    }

    public static bool SupportsVersion(Version cqlToolVersion)
    {
        return cqlToolVersion.IsBetween(new Version(2, 0, 8), new Version(2, 1));
    }

    private class DefinitionInvoker(
        string declarationName,
        ILibrary library,
        MethodInfo methodInfo) : LibraryDefinitionInvoker(declarationName, library, methodInfo)
    {
        public override object? Invoke(CqlContext cqlContext)
        {
            return InvokeMethod(cqlContext);
        }
    }
}

