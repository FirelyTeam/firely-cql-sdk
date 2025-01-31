using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{
    public static FluentElmToolkit ConfigIgnoreExceptions(this FluentElmToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            ProcessBatchItemExceptionHandling = stopAfterFirstException
                                                    ? ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak
                                                    : ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue
        });

    public static FluentElmToolkit ConfigAssemblyDebugInformationToEmbedded(this FluentElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded
        });

    public static FluentElmToolkit ConfigAssemblyDebugInformationToPortablePdb(this FluentElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.PortablePdb
        });


    public static IEnumerable<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, ElmLibrary elmLibrary, string csharpSourceCode, byte[] assemblyBinary, byte[]? debugSymbolsBinary)> GetCompletedElmToAssemblyCompilations(
        this FluentElmToolkit elmToolkit) =>
        elmToolkit.GetCompletedElmToAssemblyCompilations(t => t);

    public static IEnumerable<TR> GetCompletedElmToAssemblyCompilations<TR>(
        this FluentElmToolkit elmToolkit,
        Func<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, ElmLibrary elmLibrary, string csharpSourceCode, byte[] assemblyBinary, byte[]? debugSymbolsBinary), TR> selector) =>
        elmToolkit.ElmToAssemblyCompilations
                  .Where(kv => kv.Value is { CSharpSourceCode: not null, AssemblyBinary: not null })
                  .Select(kv => selector((kv.Key, kv.Value.ElmLibrary, kv.Value.CSharpSourceCode!, kv.Value.AssemblyBinary!, kv.Value.DebugSymbolsBinary)));

}