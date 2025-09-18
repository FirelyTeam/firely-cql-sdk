/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class ToolkitTests
{
    [TestMethod]
    public void TestNestedTupleResult_ToString_MatchesExpectedFormat()
    {
        // Arrange
        var cqlNestedTuples =
            (CqlLibraryString)"""
                              library CqlNestedTupleTest version '1.0.0'

                              define "Result":
                                Tuple{
                                  status: 'success',
                                  result: Tuple{
                                      result1: 'some first result',
                                      result2: 'some second result'
                                      }
                                }
                              """;

        var ctx = FhirCqlContext.ForBundle();
        using var librarySetInvoker =
            new CqlToolkit()
                .AddCqlLibraries(cqlNestedTuples)
                .CreateLibrarySetInvoker();

        // Act
        var results = librarySetInvoker
                     .SelectExpressionsForLibrary(CqlVersionedLibraryIdentifier.Parse("CqlNestedTupleTest-1.0.0"))
                     .SelectResults(ctx)
                     .ToDictionary(t => t.definitionInvoker.DefinitionName);

        // Assert
        Assert.IsNotNull(results);
        results.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
        Assert.IsNotNull(obj.invocationResult);
        Assert.AreEqual(
            // NOTE: This is the raw ToString() output of the value tuple returned from the CQL library.
            // It is not a JSON string, but a C# value tuple string representation.
            """
            (["result", "status"], (["result1", "result2"], some first result, some second result), success)
            """, obj.invocationResult.ToString());
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
            {LibraryIdentifier: TestLib-1.0.0, DefinitionName: SimpleExpression, DefinitionType: Expression, ReturnType: System.Int32?}
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
            {LibraryIdentifier: TestLib-1.0.0, DefinitionName: Zero, DefinitionType: Function, ReturnType: System.Int32?}
            {LibraryIdentifier: TestLib-1.0.0, DefinitionName: Add, DefinitionType: Function, ReturnType: System.Int32?, Parameters: {System.Int32? 'a', System.Int32? 'b', System.Int32? 'special name'}}
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
        simpleExpression.Parameters.Should().BeEmpty();
        simpleExpression.CqlDefinitionAttribute.Should().BeOfType<CqlExpressionDefinitionAttribute>();

        var calculatedExpression = expressionsAndFunctions.Single(d => d.DefinitionName == "CalculatedExpression");
        calculatedExpression.Parameters.Should().BeEmpty();
        calculatedExpression.CqlDefinitionAttribute.Should().BeOfType<CqlExpressionDefinitionAttribute>();

        // Verify functions (with parameters)
        var addIntegers = expressionsAndFunctions.Single(d => d.DefinitionName == "AddIntegers");
        addIntegers.Parameters.Should().HaveCount(2);
        addIntegers.CqlDefinitionAttribute.Should().BeOfType<CqlFunctionDefinitionAttribute>();

        var doubleFunction = expressionsAndFunctions.Single(d => d.DefinitionName == "Double");
        doubleFunction.Parameters.Should().HaveCount(1);
        doubleFunction.CqlDefinitionAttribute.Should().BeOfType<CqlFunctionDefinitionAttribute>();

        var zeroFunction = expressionsAndFunctions.Single(d => d.DefinitionName == "ZeroFunction");
        zeroFunction.Parameters.Should().BeEmpty();
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

    [TestMethod]
    public void DefinitionInvokerParameters_Tests()
    {
        // Arrange: Load the ParameterNameTest ELM file
        var elmFile = new FileInfo(Path.Combine("Input", "ELM", "HL7", "ParameterNameTest.json"));
        var elmLibrary = Library.LoadFromJson(elmFile);

        // Act: Generate C# code and compile to assembly using ElmToolkit
        var elmToolkit = new ElmToolkit()
                         .AddElmLibraries([elmLibrary])
                         .CompileToAssemblies();

        var assemblyResult = elmToolkit.GetElmToAssemblyResults().First();
        var assemblyBinary = assemblyResult.assemblyBinary;
        assemblyBinary.Should().NotBeNull("Assembly should be compiled successfully");

        // Create InvocationToolkit and LibrarySetInvoker
        var invocationToolkit = elmToolkit.CreateInvocationToolkit();

        using var librarySetInvoker = invocationToolkit.CreateLibrarySetInvoker();

        // Assert: Check that the DefinitionInvokers have the correct parameter names
        var libraryInvoker = librarySetInvoker.LibraryInvokers.Values.Single();

        // Test 1: "Test Function" with "param with spaces" parameter
        var testFunctionInvoker = libraryInvoker.Definitions[new("Test Function", typeof(int?), typeof(string))];

        testFunctionInvoker.Should().NotBeNull("Test Function definition should exist");
        testFunctionInvoker.Parameters.Should().HaveCount(2, "Test Function should have 2 parameters");
        testFunctionInvoker.Parameters[0].Name.Should().Be("param with spaces", "First parameter should preserve original CQL name with spaces");
        testFunctionInvoker.Parameters[1].Name.Should().Be("normalParam", "Second parameter should have original name");

        // Test 2: "Another Test" with "param-with-dashes" parameter
        var anotherTestInvoker = libraryInvoker.Definitions[new("Another Test", typeof(decimal?))];

        anotherTestInvoker.Should().NotBeNull("Another Test definition should exist");
        anotherTestInvoker.Parameters.Should().HaveCount(1, "Another Test should have 1 parameter");
        anotherTestInvoker.Parameters[0].Name.Should().Be("param-with-dashes", "Parameter should preserve original CQL name with dashes");

        // Test 3: "Keyword Test" with C# keyword parameters
        var keywordTestInvoker = libraryInvoker.Definitions[new("Keyword Test", typeof(int?), typeof(string), typeof(bool?))];

        keywordTestInvoker.Should().NotBeNull("Keyword Test definition should exist");
        keywordTestInvoker.Parameters.Should().HaveCount(3, "Keyword Test should have 3 parameters");
        keywordTestInvoker.Parameters[0].Name.Should().Be("int", "First parameter should preserve original CQL name even if it's a C# keyword");
        keywordTestInvoker.Parameters[1].Name.Should().Be("ref", "Second parameter should preserve original CQL name even if it's a C# keyword");
        keywordTestInvoker.Parameters[2].Name.Should().Be("class", "Third parameter should preserve original CQL name even if it's a C# keyword");
    }

    [TestMethod]
    public void TestLargeTupleParameterInvocation_9Items()
    {
        // Arrange: Create a CQL library with a function that takes a large tuple parameter (9 items)
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library LargeTupleInvocationTest version '1.0.0'
            using FHIR version '4.0.1'

            context Patient

            define function "ProcessLargeTuple"(largeTuple Tuple{
                item1 String,
                item2 Integer,
                item3 Boolean,
                item4 Decimal,
                item5 String,
                item6 Integer,
                item7 Boolean,
                item8 Decimal,
                item9 String
            }): 
                'Processed: ' + largeTuple.item1 + ', ' + largeTuple.item9
            """);

        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
        var ctx = FhirCqlContext.ForBundle();
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlLibraryString];

        // Act: Inspect the function signature that was actually created by the CQL compiler
        var processTupleFunction = libraryInvoker.Definitions.Values
                                                .FirstOrDefault(d => d.DefinitionName == "ProcessLargeTuple");

        // Assert: Function should be found and have the expected structure
        processTupleFunction.Should().NotBeNull("ProcessLargeTuple function should exist");
        processTupleFunction!.Parameters.Should().HaveCount(1, "Function should have exactly one parameter");

        var parameterType = processTupleFunction.Parameters[0].Type;
        parameterType.Should().NotBeNull("Parameter should have a type");

        // Let's examine what type the CQL compiler actually generated
        var underlyingType = parameterType.IsGenericType && parameterType.GetGenericTypeDefinition() == typeof(Nullable<>) 
                           ? parameterType.GetGenericArguments()[0] 
                           : parameterType;

        // Verify this is indeed a large tuple with nested structure
        underlyingType.IsCqlValueTuple().Should().BeTrue("The underlying ValueTuple should be recognized as a CQL value tuple");
        typeof(ITuple).IsAssignableFrom(underlyingType).Should().BeTrue("The underlying ValueTuple should implement ITuple");

        // Create a tuple instance that matches the discovered structure
        var metadata = new CqlTupleMetadata([
            typeof(string), typeof(int?), typeof(bool?), typeof(decimal?), typeof(string),
            typeof(int?), typeof(bool?), typeof(decimal?), typeof(string)
        ], ["item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9"]);

        // Create the large tuple (9 items) that will have the nested structure
        var largeTuple9 = (metadata, "first", (int?)42, (bool?)true, (decimal?)3.14m, "middle", 
                          (int?)100, (bool?)false, (decimal?)99.99m, "last");

        // Verify the created tuple matches the expected underlying type
        largeTuple9.GetType().Should().Be(underlyingType, "Created tuple type should match the underlying function parameter type");

        // Act: Invoke the function with the large tuple
        var result = processTupleFunction.Invoke(ctx, largeTuple9);

        // Assert: Function should execute successfully with large tuple
        result.Should().NotBeNull("Function invocation should return a result");
        result.Should().Be("Processed: first, last", "Function should process the large tuple correctly");
        
        // Verify that large tuple signature matching works properly for finding definitions
        var signature = processTupleFunction.DefinitionSignature;
        var foundBySignature = libraryInvoker.Definitions.GetValueOrDefault(signature);
        
        foundBySignature.Should().Be(processTupleFunction, "Should be able to find function by its signature");
        foundBySignature!.DefinitionSignature.ParameterTypes.Should().HaveCount(1, "Signature should show one parameter");
        foundBySignature.DefinitionSignature.ParameterTypes[0].Should().Be(parameterType, "Signature should include correct parameter type");
    }

    [TestMethod]
    public void TestLargeTupleParameterSignature_15Items()
    {
        // Arrange: Create a CQL library with a function that takes a very large tuple parameter (15 items)
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library VerifyLargeTupleSignatureTest version '1.0.0'
            using FHIR version '4.0.1'

            context Patient

            define function "ProcessVeryLargeTuple"(veryLargeTuple Tuple{
                item1 String, item2 Integer, item3 Boolean, item4 Decimal, item5 String,
                item6 Integer, item7 Boolean, item8 Decimal, item9 String, item10 Integer,
                item11 Boolean, item12 Decimal, item13 String, item14 Integer, item15 Boolean
            }): 'Processed 15 items'
            """);

        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlLibraryString];

        // Act: Find the function and inspect its signature
        var processFunction = libraryInvoker.Definitions.Values
                                           .FirstOrDefault(d => d.DefinitionName == "ProcessVeryLargeTuple");

        // Assert: Function should be found with very large tuple parameter
        processFunction.Should().NotBeNull("ProcessVeryLargeTuple function should exist");
        processFunction!.Parameters.Should().HaveCount(1, "Function should have exactly one parameter");

        var parameterType = processFunction.Parameters[0].Type;
        
        // Get underlying type (removing Nullable wrapper if present)
        var underlyingType = parameterType!.IsGenericType && parameterType.GetGenericTypeDefinition() == typeof(Nullable<>) 
                           ? parameterType.GetGenericArguments()[0] 
                           : parameterType;

        // Verify this is a large tuple that uses nested ValueTuple structures
        underlyingType.IsCqlValueTuple().Should().BeTrue("15-item tuple parameter should be recognized as a CQL value tuple");
        typeof(ITuple).IsAssignableFrom(underlyingType).Should().BeTrue("15-item tuple should implement ITuple");

        // Verify the function signature can be used for lookup
        var signature = processFunction.DefinitionSignature;
        var foundBySignature = libraryInvoker.Definitions.GetValueOrDefault(signature);
        
        foundBySignature.Should().Be(processFunction, "Should be able to find very large tuple function by its signature");
        
        // The fact that we can create a function with 15 tuple items and find it by signature
        // demonstrates that large tuple signature discovery works correctly with the invocation toolkit
    }

    [TestMethod]
    public void TestMultipleLargeTupleFunctions_SignatureDistinction()
    {
        // Arrange: Create CQL library with multiple functions having different large tuple signatures
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library MultipleLargeTupleFunctionsTest version '1.0.0'
            using FHIR version '4.0.1'

            context Patient

            define function "ProcessTuple9"(tuple9 Tuple{
                a String, b Integer, c Boolean, d Decimal, e String,
                f Integer, g Boolean, h Decimal, i String
            }): 'Tuple9 processed'

            define function "ProcessTuple10"(tuple10 Tuple{
                a String, b Integer, c Boolean, d Decimal, e String,
                f Integer, g Boolean, h Decimal, i String, j Integer
            }): 'Tuple10 processed'
            """);

        var cqlToolkit = new CqlToolkit()
            .AddCqlLibraries(cqlLibraryString);

        using var librarySetInvoker = cqlToolkit.CreateLibrarySetInvoker();
        var libraryInvoker = librarySetInvoker.LibraryInvokers[cqlLibraryString];

        // Act: Find both functions and verify they have different signatures
        var tuple9Function = libraryInvoker.Definitions.Values
                                          .FirstOrDefault(d => d.DefinitionName == "ProcessTuple9");
        var tuple10Function = libraryInvoker.Definitions.Values
                                           .FirstOrDefault(d => d.DefinitionName == "ProcessTuple10");

        // Assert: Both functions should be found with distinct signatures
        tuple9Function.Should().NotBeNull("ProcessTuple9 should be found");
        tuple10Function.Should().NotBeNull("ProcessTuple10 should be found");

        tuple9Function!.Parameters.Should().HaveCount(1, "ProcessTuple9 should have 1 parameter");
        tuple10Function!.Parameters.Should().HaveCount(1, "ProcessTuple10 should have 1 parameter");

        // Verify they have different parameter types (9 vs 10 items)
        var param9Type = tuple9Function.Parameters[0].Type;
        var param10Type = tuple10Function.Parameters[0].Type;

        param9Type.Should().NotBe(param10Type, "9-item and 10-item tuple functions should have different parameter types");

        // Both underlying types should be recognized as CQL value tuples
        var underlying9 = param9Type!.IsGenericType && param9Type.GetGenericTypeDefinition() == typeof(Nullable<>)
                        ? param9Type.GetGenericArguments()[0] : param9Type;
        var underlying10 = param10Type!.IsGenericType && param10Type.GetGenericTypeDefinition() == typeof(Nullable<>)
                         ? param10Type.GetGenericArguments()[0] : param10Type;

        underlying9.IsCqlValueTuple().Should().BeTrue("9-item tuple parameter should be recognized as CQL value tuple");
        underlying10.IsCqlValueTuple().Should().BeTrue("10-item tuple parameter should be recognized as CQL value tuple");

        // Verify signature distinction works by looking up functions by their complete signatures
        var signature9 = tuple9Function.DefinitionSignature;
        var signature10 = tuple10Function.DefinitionSignature;

        signature9.Should().NotBe(signature10, "Functions should have distinct signatures");

        var foundBySignature9 = libraryInvoker.Definitions.GetValueOrDefault(signature9);
        var foundBySignature10 = libraryInvoker.Definitions.GetValueOrDefault(signature10);

        foundBySignature9.Should().Be(tuple9Function, "Should find ProcessTuple9 by its signature");
        foundBySignature10.Should().Be(tuple10Function, "Should find ProcessTuple10 by its signature");
        
        // This demonstrates that the invocation toolkit can distinguish between 
        // different large tuple signatures and find the correct definitions
    }
}