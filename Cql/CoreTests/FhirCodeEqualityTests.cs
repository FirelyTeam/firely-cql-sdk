/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;

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

    #region Convert

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

	#region Equivalent

	[TestMethod]
	public void Equivalent_FhirCodeAndCqlCode_MustBeEquivalent()
	{
		// Arrange
		var rtx = GetNewContext();

		var enumVal = Encounter.EncounterStatus.Cancelled;
		var fhirCode = new Code<Encounter.EncounterStatus>(enumVal);
		var cqlCode = new CqlCode("cancelled", null, null, null); // This represents the string "CancelledObservationStatus" converted to CqlCode

		// Act
		var isEquivalent = rtx.Operators.Equivalent(fhirCode, cqlCode);

		// Assert
		isEquivalent.Should().BeTrue("FHIR Code and equivalent CqlCode should be equivalent");
	}

	[TestMethod]
	public void Equivalent_CqlCodeAndFhirCode_MustBeEquivalent()
	{
		// Arrange
		var rtx = GetNewContext();

		var enumVal = Encounter.EncounterStatus.Cancelled;
		var fhirCode = new Code<Encounter.EncounterStatus>(enumVal);
		var cqlCode = new CqlCode("cancelled", null, null, null);

		// Act
		var isEquivalent = rtx.Operators.Equivalent(cqlCode, fhirCode);

		// Assert
		isEquivalent.Should().BeTrue("CqlCode and equivalent FHIR Code should be equivalent");
	}

	#endregion
}
