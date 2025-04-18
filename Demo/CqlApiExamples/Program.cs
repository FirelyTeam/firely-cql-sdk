using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Text;

namespace CqlApiExamples;

using static FormattableString;

internal static class Program
{
    private static readonly string ResourceCanonicalRoot = "https://fire.ly/fhir/";
    private static readonly PackagingToolkitConfig? PackagingToolkitConfig = new() { CanonicalRootUrl = ResourceCanonicalRoot };

    private static void Main(string[] args)
    {
        // Create a logger factory via the Microsoft.Extensions.Logging API
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // AddDuplicates(loggerFactory);
        // Add3And2Example(loggerFactory);
        // InvokeCqlExample(loggerFactory);
        // InvokeCqlFromExamplesFolder(loggerFactory);
        //PackageFromExamplesFolder(loggerFactory);

        string[] exampleSetNames = ["RR23"];
        //string[] exampleSetNames = ["CMS", "Authoring", "CMS", "Demo", "Tests", "RR23"];
        foreach (var exampleSetName in exampleSetNames)
        {
            Directories dirs = Directories.Create(exampleSetName);
            //PackageCqlToFhirExample(loggerFactory, dirs);
            //PackageElmToFhirExample(loggerFactory, dirs);
            InvokeResourceExample(loggerFactory, dirs);
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
                Trace.Fail("Expected an exception when adding duplicate cql libraries.");
            }
            catch (Exception e)
            {
                Trace.Assert(e is not null);
            }

            Trace.Assert(cqlToolkit.Conversions.Count is 0);
        }

        void AddCqlDifferentValuesContinue()
        {
            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);
            try
            {
                cqlToolkit.SetIgnoreEnumerationExceptions(false)
                          .AddCqlLibraries(
                              CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:A"),
                              CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:B"),
                              CqlLibraryString.Parse("library Lib version '0.0.0' define:B"));
            }
            catch (Exception e)
            {
                Trace.Fail("No exception expected");
            }

            Trace.Assert(cqlToolkit.Conversions.Count is 2);
        }

        void AddCqlDifferentValuesBreak()
        {
            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);
            try
            {
                cqlToolkit.SetIgnoreEnumerationExceptions(true)
                          .AddCqlLibraries(
                              CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:A"),
                              CqlLibraryString.Parse("library DuplicateLib version '0.0.0' define:B"),
                              CqlLibraryString.Parse("library Lib version '0.0.0' define:C"));
            }
            catch (Exception e)
            {
                Trace.Fail("No exception expected");
            }

            Trace.Assert(cqlToolkit.Conversions.Count is 1);
        }
    }

    private static void PackageFromExamplesFolder(ILoggerFactory loggerFactory)
    {
        // Create fluent cql toolkit
        var cqlToElmProcessorSettings = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlToElmProcessorSettings);

        // "Directories" is not a part of the API, but a helper class for this example
        var dirs = Directories.Create("Demo");

        // Load CQL libraries from a directory and process them to ELM, C#, and assemblies
        cqlToolkit.AddCqlLibrariesFromDirectory(dirs.CqlFromDirectory).TranslateToElm();
        var elmToolkit = cqlToolkit.CompileToAssemblies();
        var packagingToolkit = elmToolkit.PackageToFhirResources(cqlToolkit, PackagingToolkitConfig);
        var results = packagingToolkit.GetPackagingResults().ToList();
        var fhirHelpersResult = results.FirstOrDefault(r => r.LibraryIdentifier.Identifier == "FHIRHelpers");
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

        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library AdditionLib version '0.0.0'

            define private Three: 1 + 2
            """);
        var cqlContext = FhirCqlContext.ForBundle();
        using var librarySetInvoker = cqlToolkit
                                      .AddCqlLibraries(cqlLibraryString)
                                      .CreateLibrarySetInvoker(new ElmToolkitConfig(AssemblyCompilerDebugInformationFormat.Embedded));
        var result = librarySetInvoker.GetLibraryDefinitionResult(cqlContext, cqlLibraryString.LibraryIdentifier, "Three");
        Trace.Assert(result is 3);
    }

    /// <summary>
    /// This example demonstrates how to load FHIR resources and invoke all library definitions on the set.
    /// </summary>
    private static void InvokeResourceExample(
        ILoggerFactory loggerFactory,
        Directories dirs)
    {
        var logger = loggerFactory.CreateLogger(typeof(Program));
        using var librarySetInvoker =
            new InvocationToolkit(loggerFactory)
                //.SetIgnoreEnumerationExceptions()
                .AddAssemblyBinariesInFhirLibrariesFromDirectory(dirs.FhirOutDirectory)
                .CreateLibrarySetInvoker(dirs.LibrarySetName);

        if (dirs.LibrarySetName == "RR23")
        {
            var bundlesDir = Directories.LibrarySetsDirectory.CreateSubdirectory(dirs.LibrarySetName).CreateSubdirectory("TestData");
            var bundleFile = new FileInfo(Path.Combine(bundlesDir.FullName, "RR23_EX_wile_e_coyote_falling_rock_transaction.json"));
            var bundle = bundleFile.DeserializeResource<Bundle>() ?? throw new SerializationException("Could not deserialize bundle");
            var cqlContext = FhirCqlContext.ForBundle(bundle);
            var result = librarySetInvoker.GetLibraryDefinitionResult(
                cqlContext,
                (CqlVersionedLibraryIdentifier)"RR23-1.0.0",
                "Tiny Umbrella Supply within 7 days after most recent injury due to falling rock");
            logger.LogInformation("{dump}", librarySetInvoker.DumpLibraryDefinitionsResults(cqlContext));
        }
        else
        {
            logger.LogInformation("{dump}", librarySetInvoker.DumpLibraryDefinitions());
        }
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
        using var librarySetInvoker = cqlToolkit.SetIgnoreEnumerationExceptions(false)
                                                .AddCqlLibrariesFromDirectory(dirs.CqlFromDirectory)
                                                .CreateLibrarySetInvoker(name: "Examples");
        logger.LogInformation("{dump}", librarySetInvoker.DumpLibraryDefinitions());
        Trace.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestTime") is 3);
        Trace.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestNull") is 0);
        Trace.Assert(Invoke("CqlStringOperatorsTest-1.0.000", "Combine.CombineABCSepDash") is "a-b-c");

        object? Invoke(string libraryName, string declarationName)
        {
            var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse(libraryName);
            var result = librarySetInvoker.GetLibraryDefinitionResult(cqlContext, libraryIdentifier, declarationName);
            return result;
        }
    }

    /// <summary>
    /// This example loads the CQL libraries, translates them to ELM, and compiles them to assemblies.
    /// Each intermediate format is saved to directory (e.g. ELM, C#, and assembly binaries with their Trace symbols).
    /// </summary>
    private static void PackageCqlToFhirExample(
        ILoggerFactory loggerFactory,
        Directories dirs)
    {
        var logger = loggerFactory.CreateLogger(typeof(Program));
        dirs.GeneratedDirectory.Delete(recursive: true);

        // Create fluent cql toolkit
        var config = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        var cqlToolkit = new CqlToolkit(loggerFactory, config);
        _ =
            cqlToolkit
                .SetIgnoreEnumerationExceptions()
                // CQL -> ELM
                .AddCqlLibrariesFromDirectory(dirs.CqlFromDirectory)
                .TranslateToElm()
                .SaveElmFilesToDirectory(dirs.ElmOutDirectory)
                .With(cqlToolkit =>
                          cqlToolkit.TryGetFirstElmFileLines()
                                    .IfNotNull(t => logger.LogInformation(
                                                   $"""
                                                    First 50 ELM lines for {t.LibraryIdentifier}:
                                                    {t.ElmLibraryJson.TakeLines(50)}
                                                    """)))
                // ELM -> Assemblies
                .CompileToAssemblies(new ElmToolkitConfig(AssemblyCompilerDebugInformationFormat.Embedded))
                .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory)
                .With(elmToolkit =>
                          elmToolkit.TryGetFirstCSharpFileLines()
                                    .IfNotNull(t => logger.LogInformation(
                                                   $"""
                                                    First 50 C# lines for {t.LibraryIdentifier}:
                                                    {t.CSharpSourceCode.TakeLines(50)}
                                                    """)))
                .PackageToFhirResources(cqlToolkit, PackagingToolkitConfig)
                .SaveFhirResourcesToDirectory(dirs.FhirOutDirectory)
                .With(packagingToolkit =>
                {
                    packagingToolkit.TryGetFirstPackageFileLines()
                                    .IfNotNull(t => logger.LogInformation(
                                                   $"""
                                                    First 50 FHIR lines for {t.LibraryIdentifier}:
                                                    {t.FhirLibraryJson.TakeLines(50)}
                                                    """));
                });
    }

    /// <summary>
    /// This example loads the ELM libraries, compiles them to assemblies.
    /// Each intermediate format is saved to directory (e.g. ELM, C#, and assembly binaries with their Trace symbols).
    /// </summary>
    private static void PackageElmToFhirExample(
        ILoggerFactory loggerFactory,
        Directories dirs)
    {
        var logger = loggerFactory.CreateLogger(typeof(Program));
        dirs.GeneratedDirectory.Delete(recursive: true);

        // Create fluent cql toolkit
        var config = new CqlToolkitConfig(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        CqlToolkit cqlToolkit =
            new CqlToolkit(loggerFactory, config).SetIgnoreEnumerationExceptions();

        var elmToolkit =
            cqlToolkit.CreateElmToolkit(new ElmToolkitConfig(AssemblyCompilerDebugInformationFormat.Embedded))
                      .AddElmFilesFromDirectory(dirs.ElmFromDirectory)
                      // ELM -> Assemblies
                      .CompileToAssemblies()
                      .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                      .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory)
                      .With(elmToolkit =>
                                elmToolkit.TryGetFirstCSharpFileLines()
                                          .IfNotNull(t => logger.LogInformation(
                                                         $"""
                                                          First 50 C# lines for {t.LibraryIdentifier}:
                                                          {t.CSharpSourceCode.TakeLines(50)}
                                                          """)))
                      .PackageToFhirResources(cqlToolkit, PackagingToolkitConfig)
                      .SaveFhirResourcesToDirectory(dirs.FhirOutDirectory)
                      .With(packagingToolkit =>
                      {
                          packagingToolkit.TryGetFirstPackageFileLines()
                                          .IfNotNull(t => logger.LogInformation(
                                                         $"""
                                                          First 50 FHIR lines for {t.LibraryIdentifier}:
                                                          {t.FhirLibraryJson.TakeLines(50)}
                                                          """));
                      });
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
            .AddCqlLibrariesFromDirectory(new DirectoryInfo("input/Add/cql"))
            .TranslateToElm()
            .SaveElmFilesToDirectory(new DirectoryInfo("output/Add/elm/"));

        // Create fluent elm toolkit as a continuation of the cql toolkit
        var elmToolkit = cqlToolkit.CreateElmToolkit();

        // Process the ELM files to assemblies, then save the C# files and assembly binaries to directories
        elmToolkit
            .CompileToAssemblies() // TODO:ConvertElmToAssemblies
            .SaveCSharpFilesToDirectory(new DirectoryInfo("output/Add/csharp/"))
            .SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/Add/assemblies/"));

        // Setup RuntimeApi
        var invocationToolkit = elmToolkit.CreateInvocationToolkit();
        using var librarySetInvoker = invocationToolkit.CreateLibrarySetInvoker(); // NOTE: 'librarySetInvoker' is a disposable object!

        // Execute CQL
        var threePlusTwo = librarySetInvoker.GetLibraryDefinitionResult(
            FhirCqlContext.ForBundle(),
            CqlVersionedLibraryIdentifier.ParseFromNameAndVersion("Add3and2", "1.0.0"),
            "ThreePlusTwo");

        Trace.Assert(threePlusTwo is 5);
    }
}

file static class Extensions
{
    public static T With<T>(this T value, Action<T> action)
    {
        action(value);
        return value;
    }

    public static StringBuilder DumpLibraryDefinitions(
        this LibrarySetInvoker scope,
        StringBuilder? sb = null)
    {
        sb ??= new();
        sb.AppendLine("Libraries and Definitions:");
        if (scope.LibrarySetName is {Length:>0})
            sb.AppendLine(scope.LibrarySetName);
        foreach (var (libId, lib) in scope.LibraryInvokers)
        {
            sb.AppendLine(Invariant($"- {libId}"));
            foreach (var (defName, def) in lib.Definitions)
                sb.AppendLine(Invariant($"  - {defName} : {def.ReturnType}"));
        }

        return sb;
    }

    public static StringBuilder DumpLibraryDefinitionsResults(
        this LibrarySetInvoker scope,
        CqlContext cqlContext,
        StringBuilder? sb = null)
    {
        sb ??= new();
        sb.AppendLine("Libraries and Definitions:");
        if (scope.LibrarySetName is { Length: > 0 })
            sb.AppendLine(scope.LibrarySetName);
        foreach (var (libId, lib) in scope.LibraryInvokers)
        {
            sb.AppendLine(Invariant($"- {libId}"));
            foreach (var (defName, def) in lib.Definitions)
                sb.AppendLine(Invariant($"  - {defName} : {def.ReturnType} = {def.Invoke(cqlContext)}"));
        }

        return sb;
    }

    private static string[] SplitLines(this string multilineString) =>
        multilineString.Split([Environment.NewLine], StringSplitOptions.None);

    private static string JoinLines(this IEnumerable<string> lines) =>
        string.Join(Environment.NewLine, lines);

    public static string TakeLines(this string multilineString, int count) =>
        multilineString.SplitLines().Take(count).JoinLines();

    public static (CqlVersionedLibraryIdentifier LibraryIdentifier, string CSharpSourceCode)? TryGetFirstCSharpFileLines(this ElmToolkit elmToolkit) =>
        elmToolkit.GetElmToAssemblyResults()
                  .Select(t => (t.LibraryIdentifier, t.CSharpSourceCode))
                  .FirstOrNull();

    public static (CqlVersionedLibraryIdentifier LibraryIdentifier, string ElmLibraryJson)? TryGetFirstElmFileLines(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCqlToolkitResults()
                  .Select(t => (t.LibraryIdentifier, t.ElmLibrary.SerializeToJson()))
                  .FirstOrNull();

    public static (CqlVersionedLibraryIdentifier LibraryIdentifier, string FhirLibraryJson)? TryGetFirstPackageFileLines(
        this PackagingToolkit packagingToolkit) =>
        packagingToolkit.GetPackagingResults()
                        .Select(t => (
                                         t.LibraryIdentifier,
                                         packagingToolkit.SerializeFhirResourcesToJson([t.FhirLibrary], writeIndented: true).First().resourceJson
                                     ))
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

file static class BundleDeserializationExtensions
{
    private static readonly IFhirSerializationEngine Serializer =
        FhirSerializationEngineFactory.Ostrich(ModelInfo.ModelInspector, new FhirJsonPocoSerializerSettings { });

    public static T? DeserializeResource<T>(this Stream stream)
        where T: Resource
    {
        using var sr = new StreamReader(stream);
        var json = sr.ReadToEnd();
        if (json == "")
            return null;

        var resource = Serializer.DeserializeFromJson(json);
        if (resource is null)
            return null;

        var typed = (resource as T) ?? throw new InvalidOperationException(
                        $"Could not serialize to {typeof(T).Name}, resource type was {resource.GetType().Name}");
        return typed;
    }

    public static T? DeserializeResource<T>(this FileInfo file)
        where T : Resource
    {
        using var stream = file.OpenRead();
        return stream.DeserializeResource<T>();
    }
}