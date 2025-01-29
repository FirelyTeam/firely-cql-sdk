using System.Diagnostics;
using System.Text;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Cql.Fluent.Extensions;
using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Fluent.Extensions;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Invocation;
using CqlSdkPrototype.Invocation.Extensions;
using CqlSdkPrototype.Invocation.Fluent.Extensions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlApiExamples;

using static FormattableString;

internal static class Program
{
    private static void Main(string[] args)
    {
        // Create a logger factory via the Microsoft.Extensions.Logging API
        var loggerFactory = CreateConsoleLoggerFactory();

        Add3And2Example(loggerFactory);
        InvokeCqlExample(loggerFactory);
        InvokeCqlFromExamplesFolder(loggerFactory);

        var shouldBuildCqlToElm = true;
        string[] exampleSetNames = ["CMS", "Authoring", "CMS", "Demo", "Tests"];
        foreach (var exampleSetName in exampleSetNames)
        {
            Directories dirs = Directories.Create(exampleSetName);
            FullExample(loggerFactory, dirs, shouldBuildCqlToElm);
        }
    }

    private static void InvokeCqlExample(
        ILoggerFactory loggerFactory)
    {
        // INTRO:
        // This example demonstrates how to add a CqlLibraryString to the CqlToolkit and invoke a library declaration directly.

        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToElmTranslatorConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        FluentCqlToolkit cqlToolkit = new FluentCqlToolkit(loggerFactory, cqlToElmProcessorSettings);


        // NICE TO HAVE: Would be nice to parse the CqlLibraryString only from the CQL and extract the identifier from the CQL
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library AdditionLib version '0.0.0'

            define private Three: 1 + 2
            """);
        var cqlContext = FhirCqlContext.ForBundle();
        using var librarySetInvoker = cqlToolkit
                                      .AddCqlLibraryString(cqlLibraryString)
                                      .ToLibrarySetInvoker(elmOpt => elmOpt with
                                      {
                                          AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded
                                      });
        var result = librarySetInvoker.GetLibraryDefinitionResult(cqlContext, cqlLibraryString.VersionedLibraryIdentifier, "Three");
        Debug.Assert(result is 3);
    }

    private static void InvokeCqlFromExamplesFolder(
        ILoggerFactory loggerFactory)
    {
        // INTRO:
        // This example demonstrates how to load CQL libraries from a directory and invoke a library declarations directly.

        var logger = loggerFactory.CreateLogger(typeof(Program));

        // "Directories" is not a part of the API, but a helper class for this example
        var dirs = Directories.Create("Tests");

        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToElmTranslatorConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        FluentCqlToolkit cqlToolkit = new FluentCqlToolkit(loggerFactory, cqlToElmProcessorSettings);

        // We can write extensions to make it even easier to change exception handling
        var cqlContext = FhirCqlContext.ForBundle();

        // We need a disposable invocation scope, which contains the AssemblyLoadContext and the related library Assemblies.
        using var librarySetInvoker = cqlToolkit
                                      .Reconfigure(o => o with
                                      {
                                          ProcessBatchItemExceptionHandling = ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue
                                      })
                                      .AddCqlLibrariesFromDirectory(dirs.CqlInDirectory)
                                      .ToLibrarySetInvoker();
        logger.LogInformation("{dump}", librarySetInvoker.DumpLibraryDeclarations());
        Debug.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestTime") is 3);
        Debug.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestNull") is 0);
        Debug.Assert(Invoke("CqlStringOperatorsTest-1.0.000", "Combine.CombineABCSepDash") is "a-b-c");

        object? Invoke(string libraryName, string declarationName)
        {
            var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse(libraryName);
            var result = librarySetInvoker.GetLibraryDefinitionResult(cqlContext, libraryIdentifier, declarationName);
            return result;
        }
    }

    private static void FullExample(
        ILoggerFactory loggerFactory,
        Directories dirs,
        bool shouldBuildCqlToElm = false)
    {
        // INTRO:
        // This example loads the CQL libraries, translates them to ELM, and compiles them to assemblies.
        // Each intermediate format is saved to directory (e.g. ELM, C#, and assembly binaries with their debug symbols).
        // It also demonstrates how to execute a library.

        var logger = loggerFactory.CreateLogger(typeof(Program));
        dirs.GeneratedDirectory.Delete(recursive: true);

        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToElmTranslatorConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        FluentCqlToolkit cqlToolkit =
            new FluentCqlToolkit(loggerFactory, cqlToElmProcessorSettings)
                .ConfigIgnoreExceptions();

        if (shouldBuildCqlToElm)
        {
            cqlToolkit
                .AddCqlLibrariesFromDirectory(dirs.CqlInDirectory)
                .TranslateCqlToElm()
                .SaveElmFilesToDirectory(dirs.ElmOutDirectory)
                ;
        }

        var elmToolkit = cqlToolkit
                         .ToFluentElmToolkit()
                         .ConfigAssemblyDebugInformationToEmbedded()
                         .AddElmFilesFromDirectory(dirs.ElmInDirectory)
                         .CompileElmToAssemblies()
                         .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                         .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory);

        cqlToolkit.TryGetFirstElmFileLines()
                  .Switch(t => logger.LogInformation(
                              $"""
                               First 50 ELM lines for {t.id}:
                               {t.elmJson.TakeLines(50)}
                               """));

        elmToolkit.TryGetFirstCSharpFileLines()
                  .Switch(t => logger.LogInformation(
                              $"""
                               First 50 C# lines for {t.id}:
                               {t.cSharpSourceCode.TakeLines(50)}
                               """));
    }


    private static void Add3And2Example(
        ILoggerFactory loggerFactory)
    {
        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToElmTranslatorConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        FluentCqlToolkit cqlToolkit = new FluentCqlToolkit(loggerFactory, cqlToElmProcessorSettings);

        // Add CQL libraries from a directory and process them to ELM, then save the ELM files to a directory
        cqlToolkit
            .AddCqlLibrariesFromDirectory(new DirectoryInfo("input/1/cql"))
            .TranslateCqlToElm()
            .SaveElmFilesToDirectory(new DirectoryInfo("output/1/elm/"));

        // Create fluent elm toolkit as a continuation of the cql toolkit
        var elmToolkit = cqlToolkit.ToFluentElmToolkit();

        // Process the ELM files to assemblies, then save the C# files and assembly binaries to directories
        elmToolkit
            .CompileElmToAssemblies() // TODO:ConvertElmToAssemblies
            .SaveCSharpFilesToDirectory(new DirectoryInfo("output/1/csharp/"))
            .SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/1/assemblies/"));

        // Setup RuntimeApi
        var invocationToolkit = elmToolkit.ToFluentInvocationToolkit();
        using var librarySetInvoker = invocationToolkit.ToLibrarySetInvoker(); // NOTE: 'librarySetInvoker' is a disposable object!

        // Execute CQL
        var threePlusTwo = librarySetInvoker.GetLibraryDefinitionResult(
            FhirCqlContext.ForBundle(),
            CqlVersionedLibraryIdentifier.ParseFromNameAndVersion("Add3and2", "1.0.0"),
            "ThreePlusTwo");

        Debug.Assert(threePlusTwo is 5);
    }

    private static ILoggerFactory CreateConsoleLoggerFactory()
    {
        var services = new ServiceCollection();
        services.AddLogging(builder => builder.AddConsole());
        IServiceProvider serviceProvider = services.BuildServiceProvider();
        var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
        return loggerFactory;
    }
}

file static class Extensions
{
    internal static StringBuilder DumpLibraryDeclarations(
        this LibrarySetInvoker scope,
        StringBuilder? sb = null)
    {
        sb ??= new();
        sb.AppendLine("Libraries and Declarations:");
        foreach (var (libId, lib) in scope.LibraryInvokers)
        {
            sb.AppendLine(Invariant($"- {libId}"));
            foreach (var (declId, decl) in lib.Definitions)
                sb.AppendLine(Invariant($"  - {declId} : {decl.ReturnType}"));
        }

        return sb;
    }

    public static string[] SplitLines(this string multilineString) =>
        multilineString.Split([Environment.NewLine], StringSplitOptions.None);

    public static string JoinLines(this IEnumerable<string> lines) =>
        string.Join(Environment.NewLine, lines);

    public static string TakeLines(this string multilineString, int count) =>
        multilineString.SplitLines().Take(count).JoinLines();

    public static Maybe<TSource> TryGetFirst<TSource>(this IEnumerable<TSource> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        if (source is IList<TSource> list)
        {
            if (list.Count > 0)
            {
                return list[0];
            }
        }
        else
        {
            using IEnumerator<TSource> e = source.GetEnumerator();
            if (e.MoveNext())
            {
                return e.Current;
            }
        }

        return Maybe<TSource>.NoValue;
    }

    public static Maybe<TSource> TryGetFirst<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        foreach (TSource element in source)
        {
            if (predicate(element))
            {
                return element;
            }
        }

        return Maybe<TSource>.NoValue;
    }

    public static Maybe<(CqlVersionedLibraryIdentifier id, string cSharpSourceCode)> TryGetFirstCSharpFileLines(this FluentElmToolkit elmToolkit) =>
        elmToolkit.ElmToAssemblyCompilations
                  .TryGetFirst(kv => kv.Value.CSharpSourceCode is not null)
                  .TryReturn(kv => (kv.Key, kv.Value.CSharpSourceCode!));

    public static Maybe<(CqlVersionedLibraryIdentifier id, string elmJson)> TryGetFirstElmFileLines(
        this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit.CqlToElmTranslations
                  .TryGetFirst(kv => kv.Value.ElmLibrary is not null)
                  .TryReturn(kv => (kv.Key, kv.Value.ElmLibrary!.SerializeToJson()!));
}