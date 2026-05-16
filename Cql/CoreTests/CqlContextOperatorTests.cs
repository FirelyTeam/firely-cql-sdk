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
using Hl7.Fhir.Model;

namespace CoreTests;

[TestClass]
public class CqlContextOperatorTests
{
    private static ICqlOperators Sut() => FhirCqlContext.WithDataSource().Operators; // Service under test

    #region Power

    [TestMethod]
    public void Power_Operator_Overloads_Must_All_Return_Decimal()
    {
        // Arrange
        var powerOverloads = typeof(ICqlOperators).GetMethods().Where(m => m.Name == nameof(ICqlOperators.Power));

        // Assert
        powerOverloads.Should().OnlyContain(overload => overload.ReturnType == typeof(decimal?));
    }

    [TestMethod]
    public void Power_IntegerArguments_Must_Return_Fractional_Decimal_Result()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Power(2, -2);

        // Assert
        result.Should().Be(0.25m);
    }

    [TestMethod]
    public void Power_LongArguments_Must_Return_Fractional_Decimal_Result()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Power(2L, -2L);

        // Assert
        result.Should().Be(0.25m);
    }

    [TestMethod]
    public void Power_IntegerArguments_With_NonRepresentable_Result_Must_Return_Null()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var overflowResult = cqlOperators.Power(2, 1000);
        var infinityResult = cqlOperators.Power(0, -1);

        // Assert
        overflowResult.Should().BeNull();
        infinityResult.Should().BeNull();
    }

    [TestMethod]
    public void Power_LongArguments_With_NonRepresentable_Result_Must_Return_Null()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var overflowResult = cqlOperators.Power(2L, 1000L);
        var infinityResult = cqlOperators.Power(0L, -1L);

        // Assert
        overflowResult.Should().BeNull();
        infinityResult.Should().BeNull();
    }

    #endregion

    #region Equal

    [TestMethod]
    public void Equal_FhirCodeAndString_MustEqual()
    {
        // Arrange
        var cqlOperators = Sut();

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
        var cqlOperators = Sut();

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
        var cqlOperators = Sut();

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
        var cqlOperators = Sut();

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
        var cqlOperators = Sut();

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
        var cqlOperators = Sut();
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
        var cqlOperators = Sut();

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
        var cqlOperators = Sut();

        var enumVal = Encounter.EncounterStatus.Cancelled;
        var fhirCode = new Code<Encounter.EncounterStatus>(enumVal);
        var cqlCode = new CqlCode("cancelled", null, null, null);

        // Act
        var isEquivalent = cqlOperators.Equivalent(cqlCode, fhirCode);

        // Assert
        isEquivalent.Should().BeTrue("CqlCode and equivalent FHIR Code should be equivalent");
    }

    #endregion

    #region Sum (Quantity)

    [TestMethod]
    public void Sum_QuantityOfSameUnits_MustSumValuesWithSameUnit()
    {
        // Arrange
        var cqlOperators = Sut();

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

    [TestMethod]
    public void Sum_QuantityNullSource_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        IEnumerable<CqlQuantity?>? inputSource = null;

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        computedValue.Should().BeNull();
    }

    [TestMethod]
    public void Sum_QuantityIgnoresNullEntries_MustSumNonNullValues()
    {
        // Arrange
        var cqlOperators = Sut();

        List<CqlQuantity?> inputSource =
        [
            new(value: 1, unit: "day"),
            null,
            new(value: 2, unit: "day")
        ];
        CqlQuantity expectedValue = new(value: 3, unit: "day");

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        bool? areEqual = cqlOperators.Equal(expectedValue, computedValue);
        Assert.IsTrue(areEqual);
    }

    [TestMethod]
    public void Sum_QuantityWithInconsistentUnits_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        List<CqlQuantity?> inputSource =
        [
            new(value: 1, unit: "day"),
            new(value: 1, unit: "week")
        ];

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        computedValue.Should().BeNull();
    }

    [TestMethod]
    public void Sum_QuantityWithNullUnits_MustSumValuesWithDefaultUnit()
    {
        // Arrange
        var cqlOperators = Sut();

        List<CqlQuantity?> inputSource =
        [
            new(value: 1, unit: null),
            new(value: 2, unit: null)
        ];
        CqlQuantity expectedValue = new(value: 3, unit: "1");

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        bool? areEqual = cqlOperators.Equal(expectedValue, computedValue);
        Assert.IsTrue(areEqual);
    }

    #endregion

    #region Sum (int)

    [TestMethod]
    public void Sum_IntegerNullSource_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        IEnumerable<int?>? inputSource = null;

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        computedValue.Should().BeNull();
    }

    [TestMethod]
    public void Sum_IntegerEmpty_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();
        int?[] inputSource = [];

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        computedValue.Should().BeNull();
    }

    [TestMethod]
    public void Sum_IntegerIgnoresNullEntries_MustSumNonNullValues()
    {
        // Arrange
        var cqlOperators = Sut();
        int?[] inputSource = [1, null, 4];

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        computedValue.Should().Be(5);
    }

    [TestMethod]
    public void Sum_IntegerOverflow_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        int?[] inputSource = [int.MaxValue, 1];

        // Act
        var computedValue = cqlOperators.Sum(inputSource);

        // Assert
        computedValue.Should().BeNull();
    }

    #endregion

    #region Log

    [TestMethod]
    public void Log_ValidInput_ReturnsExpectedValue()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(8m, 2m);

        // Assert
        result.Should().Be(3m);
    }

    [TestMethod]
    public void Log_BaseOne_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(2m, 1m);

        // Assert
        result.Should().BeNull();
    }

    [TestMethod]
    public void Log_ArgumentOneAndBaseOne_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(1m, 1m);

        // Assert
        result.Should().BeNull();
    }

    [TestMethod]
    public void Log_ArgumentZero_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(0m, 2m);

        // Assert
        result.Should().BeNull();
    }

    [TestMethod]
    public void Log_NegativeArgument_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(-1m, 2m);

        // Assert
        result.Should().BeNull();
    }

    [TestMethod]
    public void Log_BaseZero_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(2m, 0m);

        // Assert
        result.Should().BeNull();
    }

    [TestMethod]
    public void Log_NegativeBase_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(2m, -1m);

        // Assert
        result.Should().BeNull();
    }

    [TestMethod]
    public void Log_NullArgument_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(null, 2m);

        // Assert
        result.Should().BeNull();
    }

    [TestMethod]
    public void Log_NullBase_ReturnsNull()
    {
        // Arrange
        var cqlOperators = Sut();

        // Act
        var result = cqlOperators.Log(2m, null);

        // Assert
        result.Should().BeNull();
    }

    #endregion
}
