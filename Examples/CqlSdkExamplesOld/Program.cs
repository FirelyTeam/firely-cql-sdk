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
using Hl7.Cql.Abstractions;

namespace CqlApiExamples;

internal static class Program
{
    private static readonly string ResourceCanonicalRoot = "https://fire.ly/fhir/";
    private static readonly PackagingToolkitConfig? PackagingToolkitConfig = new() { CanonicalRootUrl = ResourceCanonicalRoot };

    private static void Main(string[] args)
    {
        // Confirm that the CqlToolkitConfig is set to use these models by default
        Debug.Assert(CqlToolkitConfig.DefaultCqlModels.SetEquals([CqlModel.ElmR1, CqlModel.Fhir401]));

        // Create a logger factory via the Microsoft.Extensions.Logging API
        using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        AddDuplicates(loggerFactory);
        Add3And2Example(loggerFactory);
        InvokeCqlExample(loggerFactory);
        InvokeCqlFromExamplesFolder(loggerFactory);
        PackageFromExamplesFolder(loggerFactory);

        string[] exampleSetNames = ["CMS", "Authoring", "CMS", "Demo", "Tests", "RR23"];
        foreach (var exampleSetName in exampleSetNames)
        {
            Directories dirs = Directories.Create(exampleSetName);
            //PackageCqlToFhirExample(loggerFactory, dirs);
            PackageElmToFhirExample(loggerFactory, dirs);
            dirs = dirs with { FhirInDirectory = dirs.FhirOutDirectory };
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
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);

        // "Directories" is not a part of the API, but a helper class for this example
        var dirs = Directories.Create("Demo");

        // Load CQL libraries from a directory and process them to ELM, C#, and assemblies
        cqlToolkit.AddCqlLibrariesFromDirectory(dirs.CqlFromDirectory).TranslateToElm();
        var elmToolkit = cqlToolkit.CompileToAssemblies();
        var packagingToolkit = elmToolkit.PackageToFhirResources(cqlToolkit, PackagingToolkitConfig);
        var results = packagingToolkit.GetPackagingResults().ToList();
        var fhirHelpersResult = results.FirstOrDefault(r => r.libraryIdentifier.Identifier == "FHIRHelpers");
    }

    /// <summary>
    /// This example demonstrates how to add a CqlLibraryString to the CqlToolkit and invoke a library declaration directly.
    /// </summary>
    private static void InvokeCqlExample(
        ILoggerFactory loggerFactory)
    {
        // Create fluent cql toolkit
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);

        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library "num-con-mon" version '1.0.0'

            define private Three: 1 + 2
            """);
        var cqlContext = FhirCqlContext.ForBundle();
        using var librarySetInvoker = cqlToolkit
                                      .AddCqlLibraries(cqlLibraryString)
                                      .CreateLibrarySetInvoker(new ElmToolkitConfig(AssemblyCompilerDebugInformationFormat.Embedded));
        var result = librarySetInvoker.InvokeLibraryDefinition(cqlContext, cqlLibraryString.LibraryIdentifier, "Three");
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

        var dir = dirs.FhirInDirectory;
        if (!dir.Exists)
        {
            logger.LogWarning("Directory doesnt exist: {dir}", dir);
            return;
        }

        if (!dir.EnumerateFiles("Library-*.json").Any())
        {
            logger.LogWarning("Directory has no resource files: {dir}", dir);
            return;
        }

        using var librarySetInvoker =
            new InvocationToolkit(loggerFactory)
                //.SetIgnoreEnumerationExceptions()
                .AddAssemblyBinariesInFhirLibrariesFromDirectory(dir)
                .CreateLibrarySetInvoker(dirs.LibrarySetName);
        if (librarySetInvoker.LibraryInvokers.Count == 0)
        {
            logger.LogWarning("No library invokers.");
            return;
        }

        if (dirs.LibrarySetName == "RR23")
        {
            var bundlesDir = Directories.LibrarySetsDirectory.CreateSubdirectory(dirs.LibrarySetName).CreateSubdirectory("TestData");
            var bundleFile = new FileInfo(Path.Combine(bundlesDir.FullName, "RR23_EX_wile_e_coyote_falling_rock_transaction.json"));
            var bundle = bundleFile.DeserializeResource<Bundle>() ?? throw new SerializationException("Could not deserialize bundle");
            var cqlContext = FhirCqlContext.ForBundle(bundle);
            var result = librarySetInvoker.InvokeLibraryDefinition(
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
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);

        // We can write extensions to make it even easier to change exception handling
        var cqlContext = FhirCqlContext.ForBundle();

        // We need a disposable invocation scope, which contains the AssemblyLoadContext and the related library Assemblies.
        using var librarySetInvoker = cqlToolkit.SetIgnoreEnumerationExceptions(false)
                                                .AddCqlLibrariesFromDirectory(dirs.CqlFromDirectory)
                                                .CreateLibrarySetInvoker(name: "Examples");

        //logger.LogInformation("{dump}", librarySetInvoker.DumpLibraryDefinitions());

        // Calling invocations individually
        Trace.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestTime") is 3);
        Trace.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestNull") is 0);
        Trace.Assert(Invoke("CqlStringOperatorsTest-1.0.000", "Combine.CombineABCSepDash") is "a-b-c");

        // Invoking all expressions in a library
        var results = librarySetInvoker
                      .SelectExpressions()
                      .SelectResults(
                          cqlContext,
                          SelectResultsOptions.Default with
                          {
                              PreInvokeDefinitionCallback = (
                                      invoker,
                                      context,
                                      arguments) =>
                                  logger.LogInformation("Invoking definition {definition} with arguments [{arguments}]", invoker, arguments),
                              PostInvokeDefinitionCallback = (
                                      invoker,
                                      context,
                                      arguments,
                                      result) =>
                                  logger.LogInformation("Invoked definition {definition} with result {result}", invoker, result),
                          })
                      .ToList(); // Important to enumerate the results here, otherwise nothing will be invoked

        object? Invoke(string libraryName, string declarationName)
        {
            var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse(libraryName);
            var result = librarySetInvoker.InvokeLibraryDefinition(cqlContext, libraryIdentifier, declarationName);
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
        var cqlToolkit = new CqlToolkit(loggerFactory);
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
        CqlToolkit cqlToolkit =
            new CqlToolkit(loggerFactory)
                .SetIgnoreEnumerationExceptions()
                .AddCqlLibrariesFromDirectory(dirs.CqlFromDirectory);

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
        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory);

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
        var threePlusTwo = librarySetInvoker.InvokeLibraryDefinition(
            FhirCqlContext.ForBundle(),
            CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("Add3and2", "1.0.0"),
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
        this LibrarySetInvoker librarySetInvoker,
        StringBuilder? sb = null,
        CqlContext? cqlContext = null)
    {
        sb ??= new();
        sb.AppendLine("LibrarySet:");
        if (librarySetInvoker.LibrarySetName is { Length: > 0 } name)
            sb.AppendLine($"- LibrarySetName: {name}");
        sb.AppendLine("- Libraries:");

        IEnumerable<(DefinitionInvoker definitionInvoker, object? result)> definitions =
            cqlContext is null
                ? librarySetInvoker
                  .SelectExpressions()
                  .Select(definitionInvoker => (definitionInvoker, default(object)))
                : librarySetInvoker
                  .SelectExpressions()
                  .SelectResults(cqlContext);

        foreach (var groupedByLibrary in
                 definitions.GroupBy(o => o.definitionInvoker.LibraryIdentifier))
        {
            var libraryIdentifier = groupedByLibrary.Key;
            sb.AppendLine($"  - LibraryName: {libraryIdentifier}");
            foreach (var (index, (definitionInvoker, result)) in groupedByLibrary
                                                                 .OrderBy(t =>
                                                                              t.definitionInvoker.CqlDefinitionAttribute switch
                                                                              {
                                                                                  CqlFunctionDefinitionAttribute   => 10,
                                                                                  CqlExpressionDefinitionAttribute => 8,
                                                                                  CqlConceptDefinitionAttribute    => 6,
                                                                                  CqlCodeDefinitionAttribute       => 4,
                                                                                  CqlCodeSystemDefinitionAttribute => 2,
                                                                                  CqlValueSetDefinitionAttribute   => 0,
                                                                                  _                                => 20,
                                                                              })
                                                                 .GroupBy(def => def.definitionInvoker.CqlDefinitionAttribute.GetType().Name)
                                                                 .SelectMany(g => g.Indexed())
                     //.Indexed()
                    )
            {
                string attrName = definitionInvoker.CqlDefinitionAttribute.GetType().Name["Cql".Length .. ^"DefinitionAttribute".Length];
                if (index is 0)
                    sb.AppendLine($"    {attrName}s:");
                sb.AppendLine($"      - Name: {definitionInvoker.DefinitionName}");

                switch (definitionInvoker.CqlDefinitionAttribute)
                {
                    case CqlValueSetDefinitionAttribute vsda:
                        sb.AppendLine($"      - Id: {vsda.ValueSetId}");
                        sb.AppendLine($"      - Version: {vsda.ValueSetVersion}");
                        break;

                    case CqlCodeDefinitionAttribute cda:
                        sb.AppendLine($"      - Id: {cda.CodeId}");
                        sb.AppendLine($"      - Version: {cda.CodeVersion}");
                        sb.AppendLine($"      - System: {cda.CodeSystem}");
                        sb.AppendLine($"      - Display: {cda.CodeDisplay}");
                        break;

                    case CqlExpressionDefinitionAttribute eda:
                        sb.AppendLine($"        ReturnType: {TypeHierarchy(definitionInvoker.ReturnType)}");
                        if (cqlContext is not null)
                            sb.AppendLine($"        Result: {result}");
                        foreach (var (tagIndex, (tagName, tagValues)) in definitionInvoker.TagValuesByName.Indexed())
                        {
                            if (tagIndex == 0)
                                sb.AppendLine($"        Tags:");
                            sb.AppendLine($"          - {tagName}: {string.Join(", ", tagValues)}");
                        }

                        break;
                }
            }
        }

        // Code: [FhirType("code","http://hl7.org/fhir/StructureDefinition/code")]
        // Code<>: [FhirType("codeOfT")]
        // CodeSystem: [FhirType("CodeSystem","http://hl7.org/fhir/StructureDefinition/CodeSystem", IsResource=true)]
        // ValueSet: [FhirType("ValueSet","http://hl7.org/fhir/StructureDefinition/ValueSet", IsResource=true)]

        static string TypeHierarchy(Type t) => string.Join(
            " -> ",
            BaseTypes(t).Select(t => t.ToString()));


        static IEnumerable<Type> BaseTypes(Type t)
        {
            while (t is not null)
            {
                yield return t;
                t = t.BaseType;

                if (t == typeof(object) || t == typeof(ValueType) || t == typeof(System.Array))
                    break;
            }
        }

        return sb;
    }

    public static StringBuilder DumpLibraryDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        StringBuilder? sb = null) =>
        librarySetInvoker.DumpLibraryDefinitions(sb, cqlContext);

    private static string[] SplitLines(this string multilineString) =>
        multilineString.Split([Environment.NewLine], StringSplitOptions.None);

    private static string JoinLines(this IEnumerable<string> lines) =>
        string.Join(Environment.NewLine, lines);

    public static string TakeLines(this string multilineString, int count) =>
        multilineString.SplitLines().Take(count).JoinLines();

    public static (CqlVersionedLibraryIdentifier LibraryIdentifier, string CSharpSourceCode)? TryGetFirstCSharpFileLines(this ElmToolkit elmToolkit) =>
        elmToolkit.GetElmToCSharpResults()
                  .Select(t => (t.libraryIdentifier, t.cSharp))
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
                                         t.libraryIdentifier,
                                         packagingToolkit.SerializeFhirResourcesToJson([t.resultArtifacts.FhirLibrary], writeIndented: true).First().resourceJson
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

    public static IEnumerable<(int Index, T Value)> Indexed<T>(this IEnumerable<T> source) =>
        source.Select((v, i) => (i, v));
}

file static class BundleDeserializationExtensions
{
    private static readonly IFhirSerializationEngine Serializer =
        FhirSerializationEngineFactory.Ostrich(ModelInfo.ModelInspector, new FhirJsonPocoSerializerSettings { });

    public static T? DeserializeResource<T>(this Stream stream)
        where T : Resource
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