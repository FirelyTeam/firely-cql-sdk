using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;

namespace CqlSdkPrototype.Packaging.Fluent;

public static partial class FluentPackagingToolkitExtensions
{
    public static FluentPackagingToolkit AddPackagingInputsFromCqlAndElmToolkits(
        this FluentPackagingToolkit packagingToolkit,
        FluentCqlToolkit cqlToolkit,
        FluentElmToolkit elmToolkit)
    {
        var cqlToElmTranslations = cqlToolkit.CqlToElmTranslations.Values.Select(o => o.CqlLibraryString);
        var completedElmToAssemblyCompilations = elmToolkit.GetCompletedElmToAssemblyCompilations();
        var inputs =
            cqlToElmTranslations
                .Join(completedElmToAssemblyCompilations,
                      l => l.VersionedLibraryIdentifier, r => r.versionedLibraryIdentifier,
                      (l, r) => new FhirResourcePackagingInput(l, r.elmLibrary, r.csharpSourceCode, r.assemblyBinary));
        return packagingToolkit.AddPackagingInputs(inputs);
    }
}