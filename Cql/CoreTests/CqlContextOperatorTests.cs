#nullable enable

using System;
using System.Collections.Generic;
using System.Reflection;
using FluentAssertions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class CqlContextOperatorTests
{
	private static CqlContext GetNewContext() => FhirCqlContext.WithDataSource();


	#region Equal

	[TestMethod]
	public void Equal_FhirCodeAndString_MustEqual()
	{
		// Arrange
		var rtx = GetNewContext();

		var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		var isEqual = rtx.Operators.Equal(codeVal, stringVal);

		// Assert
		isEqual.Should().BeTrue();
	}

	[TestMethod]
	public void Equal_StringAndFhirCode_MustEqual()
	{
		// Arrange
		var rtx = GetNewContext();

		var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		var isEqual = rtx.Operators.Equal(stringVal, codeVal);

		// Assert
		isEqual.Should().BeTrue();
	}

    [TestMethod]
    public void Equivalent_ConceptAtLeastOneCodeEquivalent_MustBeEquivalent()
    {
        // Arrange
        CqlContext rtx = GetNewContext();

        CqlCode[] divorcedCodes =
        [
            new CqlCode("D", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null)
        ];

        CqlConcept divorcedConcept = new(divorcedCodes, "Divorced Concept");

        CqlCode[] notMarriedCodes =
        [
            new CqlCode("L", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null),
            new CqlCode("D", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null)
        ];

        CqlConcept notMarriedConcept = new(notMarriedCodes, "Not Married Concept");


        // Act
        bool? isEqualLessOnLeftConcept = rtx.Operators.Equivalent(divorcedConcept, notMarriedConcept);
        bool? isEqualLessOnRightConcept = rtx.Operators.Equivalent(notMarriedConcept, divorcedConcept);

        // Assert
        isEqualLessOnLeftConcept.Should().BeTrue();
        isEqualLessOnRightConcept.Should().BeTrue();
    }

    [TestMethod]
    public void Equivalent_ConceptAtLeastOneCodeEquivalentOnNull_MustBeEquivalent()
    {
        // Arrange
        CqlContext rtx = GetNewContext();

        CqlCode?[] divorcedCodes =
        [
			null,
            new CqlCode("X", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null)
        ];

        CqlConcept divorcedConcept = new(divorcedCodes!, "Divorced Concept");

        CqlCode?[] notMarriedCodes =
        [
            new CqlCode("Y", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null),
			null,
            new CqlCode("Z", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null)
        ];

        CqlConcept notMarriedConcept = new(notMarriedCodes!, "Not Married Concept");


        // Act
        bool? isEqualLessOnLeftConcept = rtx.Operators.Equivalent(divorcedConcept, notMarriedConcept);
        bool? isEqualLessOnRightConcept = rtx.Operators.Equivalent(notMarriedConcept, divorcedConcept);

        // Assert
        isEqualLessOnLeftConcept.Should().BeTrue();
        isEqualLessOnRightConcept.Should().BeTrue();
    }

	#endregion

	#region Convert (FHIR Code <--> String)

	[TestMethod]
	public void Convert_FhirCodeToString_MustReturnValueFromEnumLiteral()
	{
		// Arrange
		var rtx = GetNewContext();

		var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		var stringValConverted = rtx.Operators.Convert<string>(codeVal);

		// Assert
		Assert.AreEqual(stringVal, stringValConverted);
	}

	[TestMethod]
	public void Convert_StringToFhirCode_ThrowNoConversionIsDefined()
	{
		// Arrange
		var rtx = GetNewContext();
		const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		Action act = () => rtx.Operators.Convert<Code<Encounter.EncounterStatus>>(stringVal);

		// Assert
		act.Should().Throw<InvalidOperationException>()
		   .WithMessage("No conversion from * to * is defined.");
	}

    #endregion

    #region Convert (String --> XXX)

    [TestMethod]
    [DynamicData(nameof(TestDataFor_Convert_StringTo), DynamicDataSourceType.Method/*, DynamicDataDisplayName = nameof(TestDataNameFor_Convert_StringTo)*/)]
    public void Convert_StringToCqlDate_ReturnsConvertedValue(string input, object expectedConvertOutput)
    {
        // Arrange
        var rtx = GetNewContext();

        // Act
        var converted = ReflectionUtility
                        .GenericMethodDefinitionOf(() => rtx.Operators.Convert<object>(default))
                        .MakeGenericMethod(expectedConvertOutput.GetType())
                        .Invoke(rtx.Operators, [input]);

        // Assert
        converted.Should().Be(expectedConvertOutput);
    }

    private static string TestDataNameFor_Convert_StringTo(MethodInfo methodInfo, object[] input) =>
        $"Converting string '{input[0]}' to {input[1].GetType().ToCSharpString()}";

    private static IEnumerable<object[]> TestDataFor_Convert_StringTo()
    {
        object[][] testData =
        [
            ["2024-02-03", CqlDate(2024, 2, 3)],
            ["2024-02", CqlDate(2024, 2)],
            ["2024", CqlDate(2024)],
            ["2024-02-03", CqlDateTime(2024, 2, 3)],
            ["2024-02", CqlDateTime(2024, 2)],
            ["2024", CqlDateTime(2024)],
        ];
        return testData;

        CqlDate CqlDate(int year, int? month = null, int? day = null) => new(year, month, day);

        CqlDateTime CqlDateTime(int year, int? month = null, int? day = null) => new(year, month, day, null, null, null, null, null, null);
    }

    #endregion
}