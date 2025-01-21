using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensibility;

public interface IInvokerApiExtendable<TInvokerApi>
    where TInvokerApi : IInvokerApiExtendable<TInvokerApi>
{
    ILoggerFactory LoggerFactory { get; }
    InvokerApiOptions Options { get; }
    IReadOnlySet<InvokerApiStateEntry> Entries { get; }
    TInvokerApi WithOptions(Func<InvokerApiOptions, InvokerApiOptions> replaceOptions);
    TInvokerApi AddAssemblies(IEnumerable<AssemblyData> assemblies);
}