using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

internal class Program
{
    public static void Main(string[] args)
    {
        using ILoggerFactory loggerFactory =
            LoggerFactory
                .Create(lb => lb
                              .ClearProviders()
                              .AddConsole());
        try
        {
            //ExecuteBasicCqlHelloWorld(loggerFactory);
            //ExecuteBasicCqlHelloWorldWithDebugging(loggerFactory);
            ExecuteCrossLibraryCalls(loggerFactory);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
            throw;
        }
    }

    private static void ExecuteBasicCqlHelloWorld(ILoggerFactory loggerFactory)
    {
        CqlToolkit cqlToolkit = new();

        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(
                    (CqlLibraryString)"""
                                      library ExecuteBasicCql version '1.0.0'

                                      define "HelloWorld" : 'CQL Says: "Hello, DevDays!"'
                                      """)
                .CreateLibrarySetInvoker();

        CqlContext cqlContext = FhirCqlContext.WithDataSource();

        object? result = librarySetInvoker.InvokeLibraryDefinition(
            cqlContext: cqlContext,
            libraryIdentifier: (CqlVersionedLibraryIdentifier)"ExecuteBasicCql-1.0.0",
            definitionSignature: (DefinitionSignature)"HelloWorld");

        Console.WriteLine(result);
    }

    private static void ExecuteBasicCqlHelloWorldWithDebugging(ILoggerFactory loggerFactory)
    {
        CqlToolkit cqlToolkit = new();

        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(
                    (CqlLibraryString)"""
                                      library ExecuteBasicCql version '1.0.0'

                                      define "HelloWorld" : 'CQL Says: "Hello, DevDays!"'
                                      """)
                .CreateLibrarySetInvoker(
                    elmToolkitConfig: new ElmToolkitConfig(
                        // In Visual Studio,
                        // - go to: Tools > Options > Debugging > Require source files to exactly match the original source code
                        // - uncheck the box
                        AssemblyCompilerDebugInformationFormat: AssemblyCompilerDebugInformationFormat.Embedded));

        CqlContext cqlContext = FhirCqlContext.WithDataSource();

        object? result = librarySetInvoker.InvokeLibraryDefinition(
            cqlContext: cqlContext,
            libraryIdentifier: (CqlVersionedLibraryIdentifier)"ExecuteBasicCql-1.0.0",
            definitionSignature: (DefinitionSignature)"HelloWorld");

        Console.WriteLine(result);
    }

    private static void ExecuteCrossLibraryCalls(ILoggerFactory loggerFactory)
    {
        CqlToolkit cqlToolkit = new(loggerFactory);

        using LibrarySetInvoker librarySetInvoker =
            cqlToolkit
                .AddCqlLibraries(
                    /* When copying code from any AI bot, be sure to remove zero-width spaces and tabs! */

                    (CqlLibraryString)"""
                                      library CommonFunctions version '1.0.0'

                                      define function IsAdult(ageInYears Integer): 
                                        ageInYears >= 18

                                      define function CalculateAge(birthDate Date):
                                        difference in years between birthDate and Today()
                                      """,

                    (CqlLibraryString)"""
                                      library PatientEligibility version '1.0.0'

                                      include CommonFunctions version '1.0.0'

                                      define function IsEligible(patientBirthDate Date):
                                        CommonFunctions.IsAdult(CommonFunctions.CalculateAge(patientBirthDate))
                                      """)
                .TranslateToElm()
                .With(cql => { ; })
                .CreateElmToolkit(
                    elmToolkitConfig: new ElmToolkitConfig(
                        // In Visual Studio,
                        // - go to: Tools > Options > Debugging > Require source files to exactly match the original source code
                        // - uncheck the box
                        AssemblyCompilerDebugInformationFormat: AssemblyCompilerDebugInformationFormat.Embedded))
                .CompileToAssemblies()
                .With(elm => {; })
                .CreateInvocationToolkit()
                .CreateLibrarySetInvoker();

        CqlContext cqlContext = FhirCqlContext.WithDataSource();

        object? result = librarySetInvoker.InvokeLibraryDefinition(
            cqlContext: cqlContext,
            libraryIdentifier: (CqlVersionedLibraryIdentifier)"PatientEligibility-1.0.0",
            definitionSignature: new DefinitionSignature("IsEligible", [typeof(CqlDate)]),
            [new CqlDate(2025, 06, 10)
                .Add(new CqlQuantity(-18, "year"))]);

        Console.WriteLine(result);
    }
}

file static class Extensions
{
    public static T With<T>(this T item, Action<T> action)
    {
        action(item);
        return item;
    }
}