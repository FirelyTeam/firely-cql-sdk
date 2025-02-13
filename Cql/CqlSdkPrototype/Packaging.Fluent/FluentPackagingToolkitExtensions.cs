using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging.Fluent;

public static partial class FluentPackagingToolkitExtensions
{
    public static FluentPackagingToolkit SetExceptionHandlingToIgnore(this FluentPackagingToolkit packagingToolkit, bool stopAfterFirstException = false) =>
        packagingToolkit.Reconfigure(o => o with
        {
            EnumerationExceptionHandling = stopAfterFirstException
                                                    ? EnumerationExceptionHandling.Break
                                                    : EnumerationExceptionHandling.Continue
        });


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
                      (l, r) => new FhirResourcePackagingSources(l, r.elmLibrary, r.csharpSourceCode, r.assemblyBinary));
        return packagingToolkit.AddPackagingInputs(inputs);
    }
}