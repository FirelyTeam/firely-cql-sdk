/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Reflection;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Elm;

namespace CoreTests;

[TestClass]
public class ParameterNameAttributeTests
{
    [TestMethod]
    public void ParameterNameTest_CqlFunctionParameterAttribute_AddedForNormalizedParameters()
    {
        // Arrange: Load the ParameterNameTest ELM file
        var elmFile = new FileInfo(@"Input\ELM\HL7\ParameterNameTest.json");
        var elmLibrary = Library.LoadFromJson(elmFile);

        // Act: Generate C# code and compile to assembly using ElmToolkit
        var elmToolkit = new ElmToolkit()
            .AddElmLibraries(elmLibrary)
            .CompileToAssemblies();

        var assemblyBinary = elmToolkit.ArtifactsById.Values.First().Results.AssemblyBinary;
        assemblyBinary.Should().NotBeNull("Assembly should be compiled successfully");

        var assembly = assemblyBinary!.ToAssembly();

        // Assert: Check that the generated methods have the correct attributes
        var libraryType = assembly.GetTypes().First(t => t.Name.Contains("ParameterNameTest"));

        // Test 1: "Test Function" with "param with spaces" parameter
        var testFunction = libraryType.GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name.Contains("Test_Function"));

        var parameters = testFunction.GetParameters();

        // Should have context parameter + 2 function parameters
        parameters.Length.Should().Be(3);

        // Find the parameter that was normalized from "param with spaces"
        var paramWithSpaces = parameters.FirstOrDefault(p => p.Name.Contains("param_with_spaces"));
        paramWithSpaces.Should().NotBeNull("Parameter 'param with spaces' should be normalized to contain underscores");

        // This parameter should have the CqlFunctionParameterAttribute
        var attribute = paramWithSpaces!.GetCustomAttribute<CqlFunctionParameterAttribute>();
        attribute.Should().NotBeNull("Parameter with spaces should have CqlFunctionParameterAttribute");
        attribute!.CqlParameterName.Should().Be("param with spaces", "Attribute should preserve original CQL parameter name");

        // The normalParam parameter should NOT have the attribute (no normalization needed)
        var normalParam = parameters.FirstOrDefault(p => p.Name == "normalParam");
        normalParam.Should().NotBeNull("normalParam should exist without normalization");

        var normalAttribute = normalParam!.GetCustomAttribute<CqlFunctionParameterAttribute>();
        normalAttribute.Should().BeNull("normalParam should not have CqlFunctionParameterAttribute since no normalization was needed");

        // Test 2: "Another Test" with "param-with-dashes" parameter
        var anotherTest = libraryType.GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name.Contains("Another_Test"));

        var dashParams = anotherTest.GetParameters();
        dashParams.Length.Should().Be(2); // context + 1 function parameter

        var paramWithDashes = dashParams.FirstOrDefault(p => p.Name.Contains("param_minus_with_minus_dashes"));
        paramWithDashes.Should().NotBeNull("Parameter with dashes should be normalized");

        var dashAttribute = paramWithDashes!.GetCustomAttribute<CqlFunctionParameterAttribute>();
        dashAttribute.Should().NotBeNull("Parameter with dashes should have CqlFunctionParameterAttribute");
        dashAttribute!.CqlParameterName.Should().Be("param-with-dashes", "Attribute should preserve original CQL parameter name with dashes");

        // Test 3: "Keyword Test" with C# keyword parameters
        var keywordTest = libraryType.GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name.Contains("Keyword_Test"));

        var keywordParams = keywordTest.GetParameters();
        keywordParams.Length.Should().Be(4); // context + 3 function parameters

        // C# keywords should be escaped with @ but should NOT have CqlFunctionParameterAttribute
        // because the parameter name is the same as the original CQL name
        var intParam = keywordParams.FirstOrDefault(p => p.Name == "@int");
        intParam.Should().NotBeNull("int parameter should be escaped with @");

        var intAttribute = intParam!.GetCustomAttribute<CqlFunctionParameterAttribute>();
        intAttribute.Should().BeNull("C# keyword parameters should not have CqlFunctionParameterAttribute");

        var refParam = keywordParams.FirstOrDefault(p => p.Name == "@ref");
        refParam.Should().NotBeNull("ref parameter should be escaped with @");

        var refAttribute = refParam!.GetCustomAttribute<CqlFunctionParameterAttribute>();
        refAttribute.Should().BeNull("C# keyword parameters should not have CqlFunctionParameterAttribute");

        var classParam = keywordParams.FirstOrDefault(p => p.Name == "@class");
        classParam.Should().NotBeNull("class parameter should be escaped with @");

        var classAttribute = classParam!.GetCustomAttribute<CqlFunctionParameterAttribute>();
        classAttribute.Should().BeNull("C# keyword parameters should not have CqlFunctionParameterAttribute");
    }
}