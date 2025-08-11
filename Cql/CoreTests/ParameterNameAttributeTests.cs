/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class ParameterNameAttributeTests
{
    [TestMethod]
    public void ParameterNameTest_CqlFunctionParameterAttribute_AddedForNormalizedParameters()
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
        testFunctionInvoker.Operands.Should().HaveCount(2, "Test Function should have 2 parameters");
        testFunctionInvoker.Operands[0].Name.Should().Be("param with spaces", "First parameter should preserve original CQL name with spaces");
        testFunctionInvoker.Operands[1].Name.Should().Be("normalParam", "Second parameter should have original name");

        // Test 2: "Another Test" with "param-with-dashes" parameter
        var anotherTestInvoker = libraryInvoker.Definitions[new("Another Test", typeof(decimal?))];

        anotherTestInvoker.Should().NotBeNull("Another Test definition should exist");
        anotherTestInvoker.Operands.Should().HaveCount(1, "Another Test should have 1 parameter");
        anotherTestInvoker.Operands[0].Name.Should().Be("param-with-dashes", "Parameter should preserve original CQL name with dashes");

        // Test 3: "Keyword Test" with C# keyword parameters
        var keywordTestInvoker = libraryInvoker.Definitions[new ("Keyword Test", typeof(int?), typeof(string), typeof(bool?))];

        keywordTestInvoker.Should().NotBeNull("Keyword Test definition should exist");
        keywordTestInvoker.Operands.Should().HaveCount(3, "Keyword Test should have 3 parameters");
        keywordTestInvoker.Operands[0].Name.Should().Be("int", "First parameter should preserve original CQL name even if it's a C# keyword");
        keywordTestInvoker.Operands[1].Name.Should().Be("ref", "Second parameter should preserve original CQL name even if it's a C# keyword");
        keywordTestInvoker.Operands[2].Name.Should().Be("class", "Third parameter should preserve original CQL name even if it's a C# keyword");
    }
}