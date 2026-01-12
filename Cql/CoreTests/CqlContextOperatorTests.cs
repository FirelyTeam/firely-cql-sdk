/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;

namespace CoreTests;

[TestClass]
public class CqlContextOperatorTests
{
	private static CqlContext GetNewContext() => FhirCqlContext.WithDataSource();
	private static ICqlOperators GetNewOperators() => GetNewContext().Operators;

    #region Equal

    [TestMethod]
	public void Equal_FhirCodeAndString_MustEqual()
	{
        // Arrange
        var cqlOperators = GetNewOperators();

        var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
        var isEqual = cqlOperators.Equal(codeVal, stringVal);

		// Assert
		isEqual.Should().BeTrue();
	}

	[TestMethod]
	public void Equal_StringAndFhirCode_MustEqual()
	{
        // Arrange
        var cqlOperators = GetNewOperators();

        var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		var isEqual = cqlOperators.Equal(stringVal, codeVal);

		// Assert
		isEqual.Should().BeTrue();
	}

    [TestMethod]
    public void Equivalent_ConceptAtLeastOneCodeEquivalent_MustBeEquivalent()
    {
        // Arrange
        var cqlOperators = GetNewOperators();

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
        bool? isEqualLessOnLeftConcept = cqlOperators.Equivalent(divorcedConcept, notMarriedConcept);
        bool? isEqualLessOnRightConcept = cqlOperators.Equivalent(notMarriedConcept, divorcedConcept);

        // Assert
        isEqualLessOnLeftConcept.Should().BeTrue();
        isEqualLessOnRightConcept.Should().BeTrue();
    }

    [TestMethod]
    public void Equivalent_ConceptAtLeastOneCodeEquivalentOnNull_MustBeEquivalent()
    {
        // Arrange
        var cqlOperators = GetNewOperators();

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
        bool? isEqualLessOnLeftConcept = cqlOperators.Equivalent(divorcedConcept, notMarriedConcept);
        bool? isEqualLessOnRightConcept = cqlOperators.Equivalent(notMarriedConcept, divorcedConcept);

        // Assert
        isEqualLessOnLeftConcept.Should().BeTrue();
        isEqualLessOnRightConcept.Should().BeTrue();
    }

    #endregion

    #region Convert

    [TestMethod]
	public void Convert_FhirCodeToString_MustReturnValueFromEnumLiteral()
	{
        // Arrange
        var cqlOperators = GetNewOperators();

        var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		var stringValConverted = cqlOperators.Convert<string>(codeVal);

		// Assert
		Assert.AreEqual(stringVal, stringValConverted);
	}

	[TestMethod]
	public void Convert_StringToFhirCode_ThrowNoConversionIsDefined()
	{
        // Arrange
        var cqlOperators = GetNewOperators();
        const string stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		Action act = () => cqlOperators.Convert<Code<Encounter.EncounterStatus>>(stringVal);

		// Assert
		act.Should().Throw<InvalidOperationException>()
		   .WithMessage("No conversion from * to * is defined.");
	}

	#endregion

	#region Equivalent

	[TestMethod]
	public void Equivalent_FhirCodeAndCqlCode_MustBeEquivalent()
	{
        // Arrange
        var cqlOperators = GetNewOperators();

        var enumVal = Encounter.EncounterStatus.Cancelled;
		var fhirCode = new Code<Encounter.EncounterStatus>(enumVal);
		var cqlCode = new CqlCode("cancelled", null, null, null); // This represents the string "CancelledObservationStatus" converted to CqlCode

		// Act
		var isEquivalent = cqlOperators.Equivalent(fhirCode, cqlCode);

		// Assert
		isEquivalent.Should().BeTrue("FHIR Code and equivalent CqlCode should be equivalent");
	}

	[TestMethod]
	public void Equivalent_CqlCodeAndFhirCode_MustBeEquivalent()
	{
        // Arrange
        var cqlOperators = GetNewOperators();

        var enumVal = Encounter.EncounterStatus.Cancelled;
		var fhirCode = new Code<Encounter.EncounterStatus>(enumVal);
		var cqlCode = new CqlCode("cancelled", null, null, null);

		// Act
		var isEquivalent = cqlOperators.Equivalent(cqlCode, fhirCode);

		// Assert
		isEquivalent.Should().BeTrue("CqlCode and equivalent FHIR Code should be equivalent");
	}

	#endregion

    #region Sum

    [TestMethod]
    public void Sum_QuantityOfSameUnits_MustSumValuesWithSameUnit()
    {
        // Arrange
        var cqlOperators = GetNewOperators();

        List<CqlQuantity?> inputSource =
        [
            new(value: 1, unit: "day"),
            new(value: 5, unit: "day")
        ];
        CqlQuantity expectedValue = new CqlQuantity(value: 6, unit: "day");

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        bool? areEqual = cqlOperators.Equal(expectedValue, computedValue); // NOTE: Cannot call Equal directly on CqlQuantity!
        Assert.IsTrue(areEqual);
    }

    #endregion
}