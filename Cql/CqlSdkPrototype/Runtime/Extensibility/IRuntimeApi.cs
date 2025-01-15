using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Runtime.Extensibility;

internal interface IRuntimeApiExtensible<TRuntimeApi>
    where TRuntimeApi : IRuntimeApiExtensible<TRuntimeApi>
{
    ILoggerFactory LoggerFactory { get; }
    RuntimeApiOptions Options { get; }
    IReadOnlySet<RuntimeApiStateEntry> Entries { get; }
    TRuntimeApi WithOptions(Func<RuntimeApiOptions, RuntimeApiOptions> replaceOptions);
    TRuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblies);
}