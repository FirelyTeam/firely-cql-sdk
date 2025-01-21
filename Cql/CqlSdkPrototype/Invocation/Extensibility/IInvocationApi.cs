using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensibility;

public interface IInvocationApi
{
    ILoggerFactory LoggerFactory { get; }
    InvocationApiOptions Options { get; }
    IReadOnlySet<InvokerApiStateEntry> Entries { get; }
    InvocationApi WithOptions(Func<InvocationApiOptions, InvocationApiOptions> replaceOptions);
    InvocationApi AddAssemblies(IEnumerable<AssemblyData> assemblies);
}