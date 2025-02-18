using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class ElmToolkitExtensions
{
    public static InvocationToolkit CreateInvocationToolkit(
        this ElmToolkit elmToolkit)
    {
        var assemblyBinaries =
            elmToolkit.GetCompletedElmToAssemblyCompilations(t => new AssemblyBinary(t.assemblyBinary, t.debugSymbolsBinary));

        var invocationToolkit = new InvocationToolkit(elmToolkit.LoggerFactory).AddAssemblyBinaries(assemblyBinaries);
        return invocationToolkit;
    }

    public static LibrarySetInvoker CreateLibrarySetInvoker(
        this ElmToolkit elmToolkit,
        string name = "") =>
        elmToolkit
            .ConvertElmToAssemblies()
            .CreateInvocationToolkit()
            .CreateLibrarySetInvoker(name);
}
