/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using static System.FormattableString;

namespace Hl7.Cql.Packaging;

internal class CqlToResourcePackagingPipeline(
    ILogger<CqlToResourcePackagingPipeline> logger,
    IOptions<CqlToResourcePackagingOptions> options,
    ResourcePackager resourcePackager,
    LibrarySetExpressionBuilder librarySetExpressionBuilder,
    AssemblyCompiler assemblyCompiler)
{
    protected readonly ResourcePackager _resourcePackager = resourcePackager;
    protected readonly LibrarySetExpressionBuilder _LibrarySetExpressionBuilder = librarySetExpressionBuilder;
    protected readonly AssemblyCompiler _assemblyCompiler = assemblyCompiler;
    protected readonly CqlToResourcePackagingOptions _options = options.Value;
    protected readonly ILogger<CqlToResourcePackagingPipeline> _logger = logger;

    public IReadOnlyCollection<Resource> ProcessLibrarySet(LibrarySet librarySet)
    {
        //
        // 2. BUILD EXPRESSIONS
        //      Build the Elm Libraries as far as we can get. Errors are captured to be thrown later,
        //      while we try to continue building the rest of the artifacts up until the point of failure.

        var definitions = new DefinitionDictionary<LambdaExpression>();
        ExceptionDispatchInfo? expressionBuildingExceptionInfo = null;
        try
        {
            BuildExpressions(librarySet, definitions);

            // Important: Do not enumerate the libraryset by getting its Count until after processing.
            if (librarySet.Count == 0)
            {
                _logger.LogWarning("Nothing to do, since no ELM libraries were found.");
                return Array.Empty<Resource>();
            }
        }
        catch (Exception e)
        {
            _logger.LogWarning(e, "Error while building expressions.");

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
            _logger.LogWarning(e, "Error while compiling expressions.");

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
                        ResourceBuildingException: expressionBuildingExceptionInfo.SourceException)
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
                ResourceBuildingException: e).ToException();
        }
    }

    protected virtual IReadOnlyCollection<Resource> PackageResources(IReadOnlyDictionary<string, AssemblyData> assembliesByLibraryName, LibrarySet librarySet) =>
        _resourcePackager.PackageResources(
            _options.ElmDirectory,
            _options.CqlDirectory,
            _options.CanonicalRootUrl?.ToString(),
            librarySet,
            assembliesByLibraryName);

    protected virtual IReadOnlyDictionary<string, AssemblyData> CompileExpressions(LibrarySet librarySet, DefinitionDictionary<LambdaExpression> definitions) =>
        _assemblyCompiler.Compile(librarySet, definitions);

    protected virtual void BuildExpressions(LibrarySet librarySet, DefinitionDictionary<LambdaExpression> definitions) =>
        _LibrarySetExpressionBuilder.ProcessLibrarySet(librarySet, definitions);
}

internal readonly record struct CqlToResourcePackagingPipelineErrors (
    Exception? ExpressionBuildingException = null,
    Exception? AssemblyCompilingException = null,
    Exception? ResourceBuildingException = null) : ICqlError
{
    public string GetMessage()
    {
        StringBuilder sb = new();
        int i = 1;
        sb.Append("The following exceptions occurred during Library Packaging:");
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
