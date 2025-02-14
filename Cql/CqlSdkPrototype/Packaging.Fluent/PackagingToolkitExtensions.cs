using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging.Fluent;

public static partial class PackagingToolkitExtensions
{
    public static PackagingToolkit SetExceptionHandlingToIgnore(this PackagingToolkit packagingToolkit, bool stopAfterFirstException = false) =>
        packagingToolkit.Reconfigure(o => o with
        {
            ErroredEnumerationContinuation = stopAfterFirstException
                                                    ? ErroredEnumerationContinuation.Break
                                                    : ErroredEnumerationContinuation.Continue
        });


    public static PackagingToolkit AddPackagingInputsFromCqlAndElmToolkits(
        this PackagingToolkit packagingToolkit,
        CqlToolkit cqlToolkit,
        ElmToolkit elmToolkit)
    {
        var cqlToElmTranslations = cqlToolkit.Conversions.Values.Select(o => o.InCqlLibraryString);
        var completedElmToAssemblyCompilations = elmToolkit.GetCompletedElmToAssemblyCompilations();
        var inputs =
            cqlToElmTranslations
                .Join(completedElmToAssemblyCompilations,
                      l => l.LibraryIdentifier, r => r.versionedLibraryIdentifier,
                      (l, r) => new FhirResourcePackagingSources(l, r.elmLibrary, r.csharpSourceCode, r.assemblyBinary));
        return packagingToolkit.AddPackagingInputs(inputs);
    }
}