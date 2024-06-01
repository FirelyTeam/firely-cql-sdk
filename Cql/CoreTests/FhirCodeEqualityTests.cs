/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class FhirCodeEqualityTests
{
	private static CqlContext GetNewContext() => FhirCqlContext.WithDataSource();


	[TestMethod]
	public void Equal_FhirCode_vs_String()
	{
		// Arrange
		var rtx = GetNewContext();

		var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		var stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		var equals = rtx.Operators.Comparer.Equals(codeVal, stringVal, null);

		// Assert
		Assert.IsTrue(equals);
	}

	[TestMethod]
	public void Equal_String_vs_FhirCode()
	{
		// Arrange
		var rtx = GetNewContext();

		var enumVal = Encounter.EncounterStatus.Finished;
		var codeVal = new Code<Encounter.EncounterStatus>(enumVal);
		var stringVal = "finished"; // EnumLiteral[xxx]

		// Act
		var equals = rtx.Operators.Comparer.Equals(stringVal, codeVal, null);

		// Assert
		Assert.IsTrue(equals);
	}
}