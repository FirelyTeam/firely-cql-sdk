using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Runtime.Extensibility;

internal interface IRuntimeApiExtensible<TRuntimeApi>
    where TRuntimeApi : IRuntimeApiExtensible<TRuntimeApi>
{
    static abstract TRuntimeApi Create(RuntimeApiOptions options);
    RuntimeApiOptions Options { get; }
    IReadOnlySet<AssemblyData> Entries { get; }
    TRuntimeApi WithOptions(Func<RuntimeApiOptions, RuntimeApiOptions> replaceOptions);
    TRuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblies);
    TResult UseLogger<TResult>(Func<TRuntimeApi, ILogger<TRuntimeApi>, TResult> action); // Useful for extensions methods
}