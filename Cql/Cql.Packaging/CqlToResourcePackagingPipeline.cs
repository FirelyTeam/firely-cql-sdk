using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Builders;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Options;
using static System.FormattableString;

namespace Hl7.Cql.Packaging;

internal class CqlToResourcePackagingPipeline
{
    protected readonly ResourcePackager _resourcePackager;
    protected readonly ILibrarySetExpressionBuilder _LibrarySetExpressionBuilder;
    protected readonly AssemblyCompiler _assemblyCompiler;
    protected readonly CqlToResourcePackagingOptions _options;

    public CqlToResourcePackagingPipeline(
        IOptions<CqlToResourcePackagingOptions> options,
        ResourcePackager resourcePackager,
        ILibrarySetExpressionBuilder librarySetExpressionBuilder,
        AssemblyCompiler assemblyCompiler)
    {
        _options = options.Value;
        _resourcePackager = resourcePackager;
        _LibrarySetExpressionBuilder = librarySetExpressionBuilder;
        _assemblyCompiler = assemblyCompiler;
    }

    public IReadOnlyCollection<Resource> ProcessCqlToResources()
    {
        //
        // 1. LOAD ELM FILES
        //

        LibrarySet librarySet;
        try
        {
            librarySet = LoadElmFiles();
        }
        catch (Exception e1)
        {
            throw new CqlToResourcePackagingPipelineErrors(LoadElmFilesException: e1).ToException();
        }

        //
        // 2. BUILD EXPRESSIONS
        //      Build the Elm Libraries as far as we can get. Errors are captured to be thrown later,
        //      while we try to continue building the rest of the artifacts up until the point of failure.

        var definitions = new DefinitionDictionary<LambdaExpression>();
        ExceptionDispatchInfo? expressionBuildingExceptionInfo = null;
        try
        {
            BuildExpressions(librarySet, definitions);
        }
        catch (Exception e)
        {
            var librarySetReplacement = new LibrarySet();
            librarySetReplacement.AddLibraries(definitions.Libraries.Select(lib => librarySet.GetLibrary(lib, true)!));
            librarySet = librarySetReplacement;
            expressionBuildingExceptionInfo = ExceptionDispatchInfo.Capture(e);
        }

        //
        // 3. GENERATE C# ASSEMBLIES
        //

        IReadOnlyDictionary<string, AssemblyData> assembliesByLibraryName;
        try
        {
            assembliesByLibraryName = CompileExpressions(librarySet, definitions);
        }
        catch (Exception e)
        {
            throw new CqlToResourcePackagingPipelineErrors(
                ExpressionBuildingException: expressionBuildingExceptionInfo?.SourceException,
                AssemblyCompilingException: e).ToException();
        }

        //
        // 4. GENERATE FHIR RESOURCES
        //

        try
        {
            var resources = PackageResources(assembliesByLibraryName, librarySet);

            if (expressionBuildingExceptionInfo is not null)
            {
                throw new CqlToResourcePackagingPipelineErrors(
                        LoadElmFilesException: expressionBuildingExceptionInfo.SourceException)
                    .ToException();
            }

            return resources;
        }
        catch (CqlException<CqlToResourcePackagingPipelineErrors>)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new CqlToResourcePackagingPipelineErrors(
                LoadElmFilesException: expressionBuildingExceptionInfo?.SourceException,
                ResourceBuildingException: e).ToException();
        }
    }

    protected virtual IReadOnlyCollection<Resource> PackageResources(IReadOnlyDictionary<string, AssemblyData> assembliesByLibraryName, LibrarySet librarySet) =>
        _resourcePackager.PackageResources(
            _options.ElmDirectory,
            _options.CqlDirectory,
            _options.CanonicalRootUrl?.ToString(), librarySet, assembliesByLibraryName);

    protected virtual IReadOnlyDictionary<string, AssemblyData> CompileExpressions(LibrarySet librarySet, DefinitionDictionary<LambdaExpression> definitions) =>
        _assemblyCompiler.Compile(librarySet, definitions);

    protected virtual void BuildExpressions(LibrarySet librarySet, DefinitionDictionary<LambdaExpression> definitions) =>
        _LibrarySetExpressionBuilder.ProcessLibrarySet(librarySet, definitions);

    protected virtual LibrarySet LoadElmFiles()
    {
        string[] hardcodedSkipFiles = [

            // These contain a union between incompatible tuples,
            // see https://chat.fhir.org/#narrow/stream/179220-cql/topic/Union.20of.20tuples.20with.20convertible.20types
            "AntithromboticTherapyByEndofHospitalDay2FHIR.json",
            "IntensiveCareUnitVenousThromboembolismProphylaxisFHIR.json",
            "VenousThromboembolismProphylaxisFHIR.json",

            // These uses choice types, move into a property on such a choice, and then calls an
            // overloaded function, so we cannot find out which overload to call.
            // A solution is to either a) Introduce choice types in our system instead of object,
            // b) introduce runtime resolution, based on the runtime types of the arguments when one of
            // the arguments is a choice (=object).
            "InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR.json",
            "PCSBMIScreenAndFollowUpFHIR.json",
        ];

        LibrarySet librarySet = new(_options.ElmDirectory.FullName);
        var files = _options.ElmDirectory
            .GetFiles("*.json", SearchOption.AllDirectories)
            .Where(fi => !hardcodedSkipFiles.Contains(fi.Name))
            .ToArray();
        librarySet.LoadLibraries(files);
        return librarySet;
    }
}

internal readonly record struct CqlToResourcePackagingPipelineErrors(
    Exception? LoadElmFilesException = null,
    Exception? ExpressionBuildingException = null,
    Exception? AssemblyCompilingException = null,
    Exception? ResourceBuildingException = null) : ICqlError
{
    public string GetMessage()
    {
        StringBuilder sb = new();
        int i = 1;
        sb.Append("The following exceptions occurred during Library Packaging:");
        if (LoadElmFilesException is { } lefe)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. LoadElmFilesException"));
            sb.Append(lefe);
        }
        if (ExpressionBuildingException is { } ebe)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. ExpressionBuildingException"));
            sb.Append(ebe);
        }
        if (AssemblyCompilingException is { } ace)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. AssemblyCompilingException"));
            sb.Append(ace);
        }
        if (ResourceBuildingException is { } rbe)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. ResourceBuildingException"));
            sb.Append(rbe);
        }
        return sb.ToString();
    }
}