/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
                     .SelectExpressionsForLibrary(CqlVersionedLibraryIdentifier.Parse("CqlNestedTupleTest-1.0.0"))
                     .SelectResults(ctx)
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
            new CqlToolkit()
                .AddCqlLibraries(cqlMeasuresExample)
                .TranslateToElm();

        // WORKAROUND: The cql to elm toolkit doesn't support annotations yet.
        var resultElmLibrary = cqlToolkit.ArtifactsById[cqlMeasuresExample].ResultElmLibrary;
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

    [TestMethod]
    public void TestFunctionInvocation()
    {
        const int arg1 = 2;
        const int arg2 = 3;
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library FunctionTest version '1.0.0'
            define function Add(a Integer, b Integer): a + b
            """);
        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();

        var cqlContext = FhirCqlContext.ForBundle();
        var result =
            librarySetInvoker.InvokeLibraryDefinition(cqlContext, cqlLibraryString.LibraryIdentifier, "Add", arg1, arg2);

        result.Should().Be(arg1 + arg2, "The function should return the sum of the two arguments.");
    }
}
