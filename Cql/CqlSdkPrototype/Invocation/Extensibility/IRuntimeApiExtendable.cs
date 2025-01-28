using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensibility;

public interface IRuntimeApiExtendable<TRuntimeApi>
    where TRuntimeApi : IRuntimeApiExtendable<TRuntimeApi>
{
    ILoggerFactory LoggerFactory { get; }
    LibrarySetInvokerBuilderSettings Options { get; }
    IReadOnlySet<RuntimeApiStateEntry> Entries { get; }
    TRuntimeApi WithOptions(Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings> replaceOptions);
    TRuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblies);
}