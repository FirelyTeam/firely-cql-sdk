using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    public static ElmToolkit SetExceptionHandlingToIgnore(this ElmToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            ErroredEnumerationContinuation = stopAfterFirstException
                                                    ? ErroredEnumerationContinuation.Break
                                                    : ErroredEnumerationContinuation.Continue
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
        elmToolkit.Conversions
                  .Where(kv => kv.Value is { OutCSharpSourceCode: not null, OutAssemblyBinary: not null })
                  .Select(kv => selector((kv.Key, kv.Value.InElmLibrary, kv.Value.OutCSharpSourceCode!, kv.Value.OutAssemblyBinary!, kv.Value.OutDebugSymbolsBinary)));

}