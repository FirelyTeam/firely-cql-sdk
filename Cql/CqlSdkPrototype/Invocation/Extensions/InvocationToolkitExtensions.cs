using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class InvocationToolkitExtensions
{
    public static InvocationToolkit AddAssemblyBinaries(
        this InvocationToolkit invocationToolkit,
        params AssemblyBinary[] assemblyBinary)
    {
        return invocationToolkit.AddAssemblyBinaries(assemblyBinary.AsEnumerable());
    }
}