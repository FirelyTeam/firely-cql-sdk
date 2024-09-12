using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test;

[TestClass]
public class TagsTest : Base
{
    [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
    public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

    [TestMethod]
    [Ignore("The C# CQL-to-ELM does not support capturing annotation tags yet. Once that is ready, this test must be completed. It will be moved to CoreTests.AnnotationTagsTest.TestAttributesWithQuotes for the time being.")]
    public void Tags_Containing_Quotes_Must_Be_Escaped_In_CSharp()
    {
        var lib = MakeLibrary("""
            library Tags version '1.0.0'

            /*
            @publisher: MOH Alpha
            @description: Library used to validate guidance related to Roadrunners Syndrome
            */

            using FHIR version '4.0.1'

            valueset "Injury due to falling rock": 'http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock'

            /*
            @parameter: in
            */
            parameter "Measurement Period" default Interval[@2023-01-01, @2023-12-31]

            context Patient

            /*
            @description: Conditions of type 'Injury due to falling rock' within the measurement period
            @fhirquery: akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]
            @datarequirement: Condition http://hl7.org/fhir/StructureDefinition/Encounter ["code","onset.ofType(DateTime)","subject.ofType(Patient)"]
            @coderequirement: Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock
            */
            define "Injury due to falling rock within measurement period":
                [Condition: "Injury due to falling rock"] C
                   where (C.onset.value as DateTime) during "Measurement Period"

            """);

        const string tagsLibraryName = "Tags-1.0.0";

        LibrarySetDefinitions librarySetDefinitions = BuildLibrarySetDefinitions(lib);
        librarySetDefinitions.Definitions.TryGetTags(
            tagsLibraryName,
            "Injury due to falling rock within measurement period",
            Type.EmptyTypes,
            out var tags)
                             .Should().BeTrue("No tags found.");

        LibrarySetCSharp librarySetCSharp = GenerateCSharp(librarySetDefinitions);
        librarySetCSharp.CSharpCodeByLibraryName.TryGetValue(
                            tagsLibraryName,
                            out var cSharp)
                        .Should()
                        .BeTrue($"Expected C# code for {tagsLibraryName}");

        // Complete this test, by checking that the attributes are correctly escaped in the C# code.
        // See C# screenshot in PR https://github.com/FirelyTeam/firely-cql-sdk/pull/535
        // The syntax tree can be processed by Roslyn
    }

}