/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Abstractions;
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
public class ToolkitTests
{
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

    [TestMethod]
    public void TestSelectExpressionsIncludeDefinitionsWithParameters()
    {
        // Arrange: Create a CQL library with both parameterized and non-parameterized expressions
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library TestLib version '1.0.0'
            using FHIR version '4.0.1'

            // Expression (gets CqlExpressionDefinitionAttribute)
            define SimpleExpression: 42

            // Function with no parameters (gets CqlFunctionDefinitionAttribute)
            define function Zero(): 0

            // Function with parameters, including a parameter containing spaces in the name (gets CqlFunctionDefinitionAttribute)
            define function Add(a Integer, b Integer, "special name" Integer): a + b + "special name"
            """);

        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlLibraryString];

        // Act & Assert: Test for expressions
        var expressions = libraryInvoker
                          .SelectExpressions()
                          .Select(d => d.ToString())
                          .ToList();
        var expressionsString = string.Join("\n", expressions);
        Assert.That.MultilinesAreEqual(
            """
            {LibraryIdentifier: TestLib-1.0.0, ReturnType: System.Nullable`1[System.Int32], Definition: SimpleExpression}
            """, expressionsString);

        // Act & Assert: Test for functions
        // Should include all expressions, including parameterized ones
        var functions = libraryInvoker
                        .SelectExpressions(DefinitionPredicates.FunctionsOnly)
                        .Select(d => d.ToString())
                        .ToList();
        expressionsString = string.Join("\n", functions);
        Assert.That.MultilinesAreEqual(
            """
            {LibraryIdentifier: TestLib-1.0.0, ReturnType: System.Nullable`1[System.Int32], Definition: Zero}
            {LibraryIdentifier: TestLib-1.0.0, ReturnType: System.Nullable`1[System.Int32], Definition: Add(System.Int32? a, System.Int32? b, System.Int32? special name)}
            """, expressionsString);
    }

    [TestMethod]
    public void TestSelectExpressions_DefinitionFilter()
    {
        // Arrange: Create a CQL library with various definition types
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library TestExpressionsAndFunctions version '1.0.0'
            using FHIR version '4.0.1'

            context Patient

            // Simple expression without parameters
            define "SimpleExpression": true

            // Expression with calculation
            define "CalculatedExpression": 2 + 3

            // Function with parameters
            define function "AddIntegers"(a Integer, b Integer): a + b

            // Function with single parameter
            define function "Double"(x Integer): x * 2

            // Function with no parameters (treated as function)
            define function "ZeroFunction"(): 0
            """);

        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlLibraryString];

        // Act: Get expressions and functions using the new method
        var expressionsAndFunctions = libraryInvoker.SelectExpressions(DefinitionPredicates.ExpressionsAndFunctions)
            .Where(d => d.DefinitionName != "Patient") // Filter out the automatic Patient context definition
            .ToList();

        // Assert: Should include both expressions and functions
        expressionsAndFunctions.Should().HaveCount(5, "Should include 2 expressions and 3 functions");

        // Check that all expected definitions are present
        var definitionNames = expressionsAndFunctions.Select(d => d.DefinitionName).ToList();
        definitionNames.Should().Contain(["SimpleExpression", "CalculatedExpression", "AddIntegers", "Double", "ZeroFunction"]);

        // Verify expressions (no parameters)
        var simpleExpression = expressionsAndFunctions.Single(d => d.DefinitionName == "SimpleExpression");
        simpleExpression.ParameterTypes.Should().BeEmpty();
        simpleExpression.CqlDefinitionAttribute.Should().BeOfType<CqlExpressionDefinitionAttribute>();

        var calculatedExpression = expressionsAndFunctions.Single(d => d.DefinitionName == "CalculatedExpression");
        calculatedExpression.ParameterTypes.Should().BeEmpty();
        calculatedExpression.CqlDefinitionAttribute.Should().BeOfType<CqlExpressionDefinitionAttribute>();

        // Verify functions (with parameters)
        var addIntegers = expressionsAndFunctions.Single(d => d.DefinitionName == "AddIntegers");
        addIntegers.ParameterTypes.Should().HaveCount(2);
        addIntegers.CqlDefinitionAttribute.Should().BeOfType<CqlFunctionDefinitionAttribute>();

        var doubleFunction = expressionsAndFunctions.Single(d => d.DefinitionName == "Double");
        doubleFunction.ParameterTypes.Should().HaveCount(1);
        doubleFunction.CqlDefinitionAttribute.Should().BeOfType<CqlFunctionDefinitionAttribute>();

        var zeroFunction = expressionsAndFunctions.Single(d => d.DefinitionName == "ZeroFunction");
        zeroFunction.ParameterTypes.Should().BeEmpty();
        zeroFunction.CqlDefinitionAttribute.Should().BeOfType<CqlFunctionDefinitionAttribute>();
    }

    [TestMethod]
    public void TestSelectExpressions_EmptyLibrary()
    {
        // Arrange: Use an existing simple library
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library TestLib version '1.0.0'
            using FHIR version '4.0.1'

            // Expression without parameters
            define "SimpleExpression": 42
            """);

        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlLibraryString];

        // Act: Get all definitions, then filter to check what we get
        var allDefinitions = libraryInvoker.SelectExpressions(DefinitionPredicates.ExpressionsAndFunctions).ToList();
        var expressionsAndFunctions = allDefinitions.Where(d => d.DefinitionName != "Patient").ToList();

        // Assert - should have only our SimpleExpression
        expressionsAndFunctions.Should().HaveCount(1, "Library has one user-defined expression");
        expressionsAndFunctions[0].DefinitionName.Should().Be("SimpleExpression");
    }

    [TestMethod]
    public void TestSelectExpressions_ComparedToIndividualFilters()
    {
        // Arrange: Create a CQL library with mixed definition types
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library ComparisonTest version '1.0.0'
            using FHIR version '4.0.1'

            define "Expression1": 1
            define "Expression2": 2
            define function "Function1"(a Integer): a
            define function "Function2"(a Integer, b Integer): a + b
            """);

        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlLibraryString];

        // Act
        var expressionsAndFunctions = libraryInvoker.SelectExpressions(DefinitionPredicates.ExpressionsAndFunctions).ToList();
        var expressions = libraryInvoker.SelectExpressions().ToList();
        var functions = libraryInvoker.SelectExpressions(DefinitionPredicates.FunctionsOnly).ToList();

        // Assert: SelectExpressionsAndFunctions should return the union of expressions and functions
        var expectedCount = expressions.Count + functions.Count;
        expressionsAndFunctions.Should().HaveCount(expectedCount);

        // All expressions should be in the combined result
        foreach (var expression in expressions)
        {
            expressionsAndFunctions.Should().Contain(def => def.DefinitionName == expression.DefinitionName);
        }

        // All functions should be in the combined result
        foreach (var function in functions)
        {
            expressionsAndFunctions.Should().Contain(def => def.DefinitionName == function.DefinitionName);
        }

        // Combined result should not have duplicates
        var definitionNames = expressionsAndFunctions.Select(d => d.DefinitionName).ToList();
        definitionNames.Should().OnlyHaveUniqueItems();
    }
}
