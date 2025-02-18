using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class ElmToolkitExtensions
{
    public static InvocationToolkit CreateInvocationToolkit(
        this ElmToolkit elmToolkit)
    {
        var assemblyBinaries =
            elmToolkit.GetElmToAssemblyResults().Select(t => t.GetAssemblyBinary());

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
