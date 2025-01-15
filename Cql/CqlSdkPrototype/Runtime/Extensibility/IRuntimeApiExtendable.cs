using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Runtime.Extensibility;

public interface IRuntimeApiExtendable<TRuntimeApi>
    where TRuntimeApi : IRuntimeApiExtendable<TRuntimeApi>
{
    ILoggerFactory LoggerFactory { get; }
    RuntimeApiOptions Options { get; }
    IReadOnlySet<RuntimeApiStateEntry> Entries { get; }
    TRuntimeApi WithOptions(Func<RuntimeApiOptions, RuntimeApiOptions> replaceOptions);
    TRuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblies);
}