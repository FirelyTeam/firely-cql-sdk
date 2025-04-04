#nullable enable
using CoreTests.Tuples;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Elm;

namespace CoreTests;

[TestClass]
public class InvocationToolkitTests
{
    /// <seealso cref="CqlTupleTests.ExpressionReturningNestedTuplesFromAssemblyLoadedLibraryInstance_ResultCanBeSerialized"/>
    [TestMethod]
    public void TestRuntimeScopeAgainstLibraryDefinitionResults()
    {
        // Arrange
        var filePath = new DirectoryInfo(Directory.GetCurrentDirectory())
                       .SelfAndParents()
                       .Select(dir => Path.GetFullPath(Path.Combine(dir.FullName, "Dlls", "CqlNestedTupleTest-1.0.0.dll")))
                       .First(File.Exists);
        var ctx = FhirCqlContext.ForBundle();
        using var librarySetInvoker = new InvocationToolkit()
                                      .AddAssemblyBinaries(AssemblyBinary.Default.LoadFromFile(new FileInfo(filePath)))
                                      .CreateLibrarySetInvoker();

        // Act
        var result = librarySetInvoker
                     .EnumerateLibraryDefinitionsResults(ctx, CqlVersionedLibraryIdentifier.Parse("CqlNestedTupleTest-1.0.0"))
                     .ToDictionary(t => t.definitionInvoker.DefinitionName);

        // Assert
        Assert.IsNotNull(result);
        result.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
    }

    [TestMethod]
    public void TestLibraryWithDuplicateTagNames()
    {
        var cqlMeasuresExample =
            (CqlLibraryString)"""
                              library MeasureExample version'0.0.1'

                              using FHIR version '4.0.1'

                              context Patient

                              /*
                               * @group: 1
                               * @group: 2
                               * @population: initial-population
                               * @description: Patients in the IP
                               */
                              define "Initial population": true
                              """;

        var cqlToolkit =
            new CqlToolkit(config: CqlToolkitConfig.Default with
                {
                    Models = [CqlModel.ElmR1, CqlModel.Fhir401],
                })
                .AddCqlLibraries(cqlMeasuresExample)
                .ConvertCqlToElm();

        // WORKAROUND: The cql to elm toolkit doesn't support annotations yet.
        var resultElmLibrary = cqlToolkit.Conversions[cqlMeasuresExample].ResultElmLibrary;
        resultElmLibrary.Should().NotBeNull();
        var stmtInitialPopulation = resultElmLibrary!.statements.Single(s => s.Name == "Initial population");
        stmtInitialPopulation.annotation.Should().BeNull(
            "Actually we should have annotations, but the cql to elm toolkit doesn't "
            + "support it yet. Once it does, this test need to be modified to remove this "
            + "assertion and the workaround code below to manually create the annotations in the ELM.");

        stmtInitialPopulation.annotation = new[]
        {
            new Annotation()
            {
                t =
                [
                    new Tag { name = "group", value = "1", },
                    new Tag { name = "group", value = "2", },
                    new Tag { name = "population", value = "initial-population", },
                    new Tag { name = "description", value = "Patients in the IP", },
                ]
            }
        };
        // END WORKAROUND

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();

        librarySetInvoker.LibraryInvokers[cqlMeasuresExample]
                         .Definitions["Initial population"]
                         .TagValuesByName
                         .Should().BeEquivalentTo(
                             new Dictionary<string, string[]>
                             {
                                 { "group", ["1", "2"] },
                                 { "population", ["initial-population"] },
                                 { "description", ["Patients in the IP"] }
                             });
    }
}