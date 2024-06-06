/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using FluentAssertions;
using Hl7.Cql.Fhir;
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
    public void Equal_ConceptAtLeastOneCodeMatch_MustEqual()
    {
        // Arrange
        var rtx = GetNewContext();

        var divorcedCode = new CqlCode[]
        {
            new CqlCode("D", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null),
        };

        var divorcedConcept = new CqlConcept((divorcedCode as IEnumerable<CqlCode>), "Divorced Concept");

        var notMarriedCode = new CqlCode[]
        {
            new CqlCode("L", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null),
            new CqlCode("D", "http://terminology.hl7.org/CodeSystem/v3-MaritalStatus", null, null),
        };

        var notMarriedConcept = new CqlConcept((notMarriedCode as IEnumerable<CqlCode>), "Not Married Concept");


        // Act
        //This should work according to https://cql.hl7.org/02-authorsguide.html#comparison-operators
        //Quote: For Concept values, equivalence means the values have at least one equivalent code.
        //commented items that crash.
        var isEqualLessOnLeftConcept = rtx.Operators.Equivalent(divorcedConcept, notMarriedConcept);
        //var isEqualLessOnRightConcept = rtx.Operators.Equivalent(notMarriedConcept, divorcedConcept);

        // Assert
        isEqualLessOnLeftConcept.Should().BeTrue();
        //isEqualLessOnRighConcept.Should().BeTrue();


        // Act
        //Unclear if these should work from documentation
        //var isEqualLessOnLeftCode = rtx.Operators.Equivalent(divorcedCode, notMarriedConcept);
        //var isEqualLessOnRightCode = rtx.Operators.Equivalent(notMarriedConcept, divorcedCode);

        // Assert
        //isEqualLessOnLeftCode.Should().BeTrue();
        //isEqualLessOnRightCode.Should().BeTrue();
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
}