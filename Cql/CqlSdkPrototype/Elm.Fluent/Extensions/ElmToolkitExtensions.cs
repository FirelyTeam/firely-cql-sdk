using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static partial class ElmToolkitExtensions
{
    public static ElmToolkit SetExceptionHandlingToIgnore(this ElmToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            EnumerationExceptionHandling = stopAfterFirstException
                                                    ? EnumerationExceptionHandling.Break
                                                    : EnumerationExceptionHandling.Continue
        });

    public static ElmToolkit SetAssemblyDebugInformationToEmbedded(this ElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded
        });

    public static ElmToolkit SetAssemblyDebugInformationToPortablePdb(this ElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.PortablePdb
        });


    public static IEnumerable<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, ElmLibrary elmLibrary, string csharpSourceCode, byte[] assemblyBinary, byte[]? debugSymbolsBinary)> GetCompletedElmToAssemblyCompilations(
        this ElmToolkit elmToolkit) =>
        elmToolkit.GetCompletedElmToAssemblyCompilations(t => t);

    public static IEnumerable<TR> GetCompletedElmToAssemblyCompilations<TR>(
        this ElmToolkit elmToolkit,
        Func<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, ElmLibrary elmLibrary, string csharpSourceCode, byte[] assemblyBinary, byte[]? debugSymbolsBinary), TR> selector) =>
        elmToolkit.ElmToAssemblyCompilations
                  .Where(kv => kv.Value is { CSharpSourceCode: not null, AssemblyBinary: not null })
                  .Select(kv => selector((kv.Key, kv.Value.ElmLibrary, kv.Value.CSharpSourceCode!, kv.Value.AssemblyBinary!, kv.Value.DebugSymbolsBinary)));

}