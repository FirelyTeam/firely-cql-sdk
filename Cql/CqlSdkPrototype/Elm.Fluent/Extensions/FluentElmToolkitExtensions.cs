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
}