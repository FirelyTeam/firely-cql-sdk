using System.Diagnostics;
using System.Text;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Invocation;
using CqlSdkPrototype.Invocation.Extensions;
using CqlSdkPrototype.Packaging;
using CqlSdkPrototype.Packaging.Extensions;
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

        AddDuplicates(loggerFactory);
        Add3And2Example(loggerFactory);
        InvokeCqlExample(loggerFactory);
        InvokeCqlFromExamplesFolder(loggerFactory);
        PackageFromExamplesFolder(loggerFactory);

        var shouldBuildCqlToElm = true;
        string[] exampleSetNames = ["CMS", "Authoring", "CMS", "Demo", "Tests"];
        foreach (var exampleSetName in exampleSetNames)
        {
            Directories dirs = Directories.Create(exampleSetName);
            FullExample(loggerFactory, dirs, shouldBuildCqlToElm);
        }
    }

    private static void AddDuplicates(ILoggerFactory loggerFactory)
    {
        AddCqlDifferentValuesThrow();
        AddCqlDifferentValuesContinue();
        AddCqlDifferentValuesBreak();


        void AddCqlDifferentValuesThrow()
        {
            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);
            try
            {
                cqlToolkit.AddCqlLibraries(
                    CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:A"),
                    CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:B"),
                    CqlLibraryString.Parse("library Lib version '0.0.0' define:B"));
                Debug.Fail("Expected an exception when adding duplicate cql libraries.");
            }
            catch (Exception e)
            {
                Debug.Assert(e is not null);
            }

            Debug.Assert(cqlToolkit.Conversions.Count is 0);
        }

        void AddCqlDifferentValuesContinue()
        {
            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);
            try
            {
                cqlToolkit
                    .SetExceptionHandlingToIgnore()
                    .AddCqlLibraries(
                        CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:A"),
                        CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:B"),
                        CqlLibraryString.Parse("library Lib version '0.0.0' define:B"));
            }
            catch (Exception e)
            {
                Debug.Fail("No exception expected");
            }

            Debug.Assert(cqlToolkit.Conversions.Count is 2);
        }

        void AddCqlDifferentValuesBreak()
        {
            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);
            try
            {
                cqlToolkit
                    .SetExceptionHandlingToIgnore(stopAfterFirstException: true)
                    .AddCqlLibraries(
                        CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:A"),
                        CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:B"),
                        CqlLibraryString.Parse("library Lib version '0.0.0' define:C"));
            }
            catch (Exception e)
            {
                Debug.Fail("No exception expected");
            }

            Debug.Assert(cqlToolkit.Conversions.Count is 1);
        }
    }

    private static void PackageFromExamplesFolder(ILoggerFactory loggerFactory)
    {
        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlToElmProcessorSettings);

        // "Directories" is not a part of the API, but a helper class for this example
        var dirs = Directories.Create("Examples");

        // Load CQL libraries from a directory and process them to ELM, C#, and assemblies
        cqlToolkit.AddCqlLibrariesFromDirectory(dirs.CqlInDirectory).ConvertCqlToElm();
        var elmToolkit = cqlToolkit.CreateElmToolkit().ConvertElmToAssemblies();
        var packagingToolkit = new PackagingToolkit(loggerFactory);
        packagingToolkit.AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit);
    }

    /// <summary>
    /// This example demonstrates how to add a CqlLibraryString to the CqlToolkit and invoke a library declaration directly.
    /// </summary>
    private static void InvokeCqlExample(
        ILoggerFactory loggerFactory)
    {
        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlToElmProcessorSettings);


        // NICE TO HAVE: Would be nice to parse the CqlLibraryString only from the CQL and extract the identifier from the CQL
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library AdditionLib version '0.0.0'

            define private Three: 1 + 2
            """);
        var cqlContext = FhirCqlContext.ForBundle();
        using var librarySetInvoker = cqlToolkit
                                      .AddCqlLibraries(cqlLibraryString)
                                      .CreateLibrarySetInvoker(elmOpt => elmOpt with
                                      {
                                          AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded
                                      });
        var result = librarySetInvoker.GetLibraryDefinitionResult(cqlContext, cqlLibraryString.LibraryIdentifier, "Three");
        Debug.Assert(result is 3);
    }

    /// <summary>
    /// This example demonstrates how to load CQL libraries from a directory and invoke a library declarations directly.
    /// </summary>
    private static void InvokeCqlFromExamplesFolder(
        ILoggerFactory loggerFactory)
    {
        var logger = loggerFactory.CreateLogger(typeof(Program));

        // "Directories" is not a part of the API, but a helper class for this example
        var dirs = Directories.Create("Tests");

        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlToElmProcessorSettings);

        // We can write extensions to make it even easier to change exception handling
        var cqlContext = FhirCqlContext.ForBundle();

        // We need a disposable invocation scope, which contains the AssemblyLoadContext and the related library Assemblies.
        using var librarySetInvoker = cqlToolkit
                                      .SetExceptionHandlingToIgnore()
                                      .AddCqlLibrariesFromDirectory(dirs.CqlInDirectory)
                                      .CreateLibrarySetInvoker();
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

    /// <summary>
    /// This example loads the CQL libraries, translates them to ELM, and compiles them to assemblies.
    /// Each intermediate format is saved to directory (e.g. ELM, C#, and assembly binaries with their debug symbols).
    /// It also demonstrates how to execute a library.
    /// </summary>
    private static void FullExample(
        ILoggerFactory loggerFactory,
        Directories dirs,
        bool shouldBuildCqlToElm = false)
    {
        var logger = loggerFactory.CreateLogger(typeof(Program));
        dirs.GeneratedDirectory.Delete(recursive: true);

        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        CqlToolkit cqlToolkit =
            new CqlToolkit(loggerFactory, cqlToElmProcessorSettings)
                .SetExceptionHandlingToIgnore();

        if (shouldBuildCqlToElm)
        {
            cqlToolkit
                .AddCqlLibrariesFromDirectory(dirs.CqlInDirectory)
                .ConvertCqlToElm()
                .SaveElmFilesToDirectory(dirs.ElmOutDirectory)
                ;
        }

        var elmToolkit = cqlToolkit
                         .CreateElmToolkit()
                         .SetAssemblyDebugInformationToEmbedded()
                         .AddElmFilesFromDirectory(dirs.ElmInDirectory)
                         .ConvertElmToAssemblies()
                         .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                         .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory);

        cqlToolkit.TryGetFirstElmFileLines()
                  .IfNotNull(t => logger.LogInformation(
                                 $"""
                                  First 50 ELM lines for {t.id}:
                                  {t.elmJson.TakeLines(50)}
                                  """));

        elmToolkit.TryGetFirstCSharpFileLines()
                  .IfNotNull(t => logger.LogInformation(
                                 $"""
                                  First 50 C# lines for {t.id}:
                                  {t.cSharpSourceCode.TakeLines(50)}
                                  """));
    }

    /// <summary>
    /// This example demonstrates how to add a CqlLibraryString to the CqlToolkit and invoke a library declaration directly.
    /// </summary>
    private static void Add3And2Example(
        ILoggerFactory loggerFactory)
    {
        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlToElmProcessorSettings);

        // Add CQL libraries from a directory and process them to ELM, then save the ELM files to a directory
        cqlToolkit
            .AddCqlLibrariesFromDirectory(new DirectoryInfo("input/1/cql"))
            .ConvertCqlToElm()
            .SaveElmFilesToDirectory(new DirectoryInfo("output/1/elm/"));

        // Create fluent elm toolkit as a continuation of the cql toolkit
        var elmToolkit = cqlToolkit.CreateElmToolkit();

        // Process the ELM files to assemblies, then save the C# files and assembly binaries to directories
        elmToolkit
            .ConvertElmToAssemblies() // TODO:ConvertElmToAssemblies
            .SaveCSharpFilesToDirectory(new DirectoryInfo("output/1/csharp/"))
            .SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/1/assemblies/"));

        // Setup RuntimeApi
        var invocationToolkit = elmToolkit.CreateInvocationToolkit();
        using var librarySetInvoker = invocationToolkit.CreateLibrarySetInvoker(); // NOTE: 'librarySetInvoker' is a disposable object!

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
    public static StringBuilder DumpLibraryDeclarations(
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

    private static string[] SplitLines(this string multilineString) =>
        multilineString.Split([Environment.NewLine], StringSplitOptions.None);

    private static string JoinLines(this IEnumerable<string> lines) =>
        string.Join(Environment.NewLine, lines);

    public static string TakeLines(this string multilineString, int count) =>
        multilineString.SplitLines().Take(count).JoinLines();

    private static T? TryGetFirst<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        where T : struct
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        foreach (T element in source)
        {
            if (predicate(element))
            {
                return element;
            }
        }

        return null;
    }

    public static (CqlVersionedLibraryIdentifier id, string cSharpSourceCode)? TryGetFirstCSharpFileLines(this ElmToolkit elmToolkit) =>
        elmToolkit.GetCompletedElmToAssemblyCompilations(t => (t.versionedLibraryIdentifier, t.csharpSourceCode))
                  .FirstOrNull();

    public static (CqlVersionedLibraryIdentifier id, string elmJson)? TryGetFirstElmFileLines(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCompletedCqlToElmTranslations(t => (t.versionedLibraryIdentifier, t.elmLibrary.SerializeToJson()))
                  .FirstOrNull();

    public static void IfNotNull<T>(this T? value, Action<T> withNotNullValue)
        where T : struct
    {
        if (value is { } v)
            withNotNullValue(v);
    }

    /// <summary>
    /// This method is similar to <see cref="Enumerable.FirstOrDefault{TSource}(System.Collections.Generic.IEnumerable{TSource})"/>
    /// which returns the first element of a sequence of values if it is not empty;
    /// however, for value types this might not be the desired behavior as there isn't a way to distinguish between the default value and a value in the sequence.
    /// Therefore, this method returns null for value types if the sequence is empty.
    /// </summary>
    public static T? FirstOrNull<T>(this IEnumerable<T> source)
        where T : struct
    {
        foreach (var item in source)
            return item;
        return null;
    }
}