using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Fluent.Extensions;

public static class InvocationToolkitExtensions
{
    public static FluentInvocationToolkit AddAssemblyBinaries(
        this FluentInvocationToolkit invocationToolkit,
        params AssemblyBinary[] assemblyBinary)
    {
        return invocationToolkit.AddAssemblyBinaries(assemblyBinary.AsEnumerable());
    }
}