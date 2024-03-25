using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using Hl7.Cql.Abstractions.Exceptions;
using System.Text;

using static System.FormattableString;

namespace Hl7.Cql.Packager;

internal class PackagerCliProgram
{
    private readonly OptionsConsoleDumper _optionsConsoleDumper;
    private readonly ResourcePackager _resourcePackager;
    private readonly LibrarySetExpressionBuilder _librarySetExpressionBuilder;
    private readonly AssemblyCompiler _assemblyCompiler;

    private readonly PackagerOptions _packagerOptions;
    private readonly ILogger<PackagerCliProgram> _logger;

    public PackagerCliProgram(
        ILogger<PackagerCliProgram> logger,
        IOptions<PackagerOptions> packageArgsOptions,
        OptionsConsoleDumper optionsConsoleDumper,
        ResourcePackager resourcePackager, 
        LibrarySetExpressionBuilder librarySetExpressionBuilder,
        AssemblyCompiler assemblyCompiler)
    {
        _logger = logger;
        _optionsConsoleDumper = optionsConsoleDumper;
        _resourcePackager = resourcePackager;
        _librarySetExpressionBuilder = librarySetExpressionBuilder;
        _assemblyCompiler = assemblyCompiler;
        _packagerOptions = packageArgsOptions.Value;
    }

    public int Run()
    {
        try
        {
            _optionsConsoleDumper.DumpToConsole();
            RunCore();
            return 0;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An error occurred while running the packager");
            Console.Error.WriteLine("An error occurred while running PackagerCLI. Consult the build.log file for more detail.");
            return -1;
        }
    }

    private void RunCore()
    {
        //
        // 1. LOAD ELM FILES
        //

        LibrarySet librarySet;
        try
        {
            librarySet = new(_packagerOptions.ElmDirectory.FullName);
            librarySet.LoadLibraries(_packagerOptions.ElmDirectory.GetFiles("*.json", SearchOption.AllDirectories));
        }
        catch (Exception e)
        {
            throw new PackagerCliProgramErrors(LoadElmFilesException: e).ToException();
        }

        //
        // 2. BUILD EXPRESSIONS
        //      Build the Elm Libraries as far as we can get. Errors are captured to be thrown later,
        //      while we try to continue building the rest of the artifacts up until the point of failure.

        var definitions = new DefinitionDictionary<LambdaExpression>();
        ExceptionDispatchInfo? expressionBuildingExceptionInfo = null;
        try
        {
            _librarySetExpressionBuilder.ProcessLibrarySet(librarySet, definitions);
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
            assembliesByLibraryName = _assemblyCompiler.Compile(librarySet, definitions);
        }
        catch (Exception e)
        {
            throw new PackagerCliProgramErrors(
                ExpressionBuildingException: expressionBuildingExceptionInfo?.SourceException,
                AssemblyCompilingException: e).ToException();
        }

        //
        // 4. GENERATE FHIR RESOURCES
        //

        try
        {
            _resourcePackager.PackageResources(
                _packagerOptions.ElmDirectory,
                _packagerOptions.CqlDirectory,
                _packagerOptions.CanonicalRootUrl?.ToString(), librarySet, assembliesByLibraryName);

            if (expressionBuildingExceptionInfo is not null)
            {
                throw new PackagerCliProgramErrors(
                        LoadElmFilesException: expressionBuildingExceptionInfo.SourceException)
                    .ToException();
            }
        }
        catch (CqlException<PackagerCliProgramErrors>)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new PackagerCliProgramErrors(
                LoadElmFilesException: expressionBuildingExceptionInfo?.SourceException,
                ResourceBuildingException: e).ToException();
        }
    }
}



internal readonly record struct PackagerCliProgramErrors(
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