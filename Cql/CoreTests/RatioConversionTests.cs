/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// The Ratio conversions of CQL 1.5.3, Appendix B - CQL Reference, Type Operators:
/// ToRatio(String), ConvertsToRatio(Any) and ToQuantity(Ratio).
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class RatioConversionTests
{
    private static ICqlOperators GetOperators() => FhirCqlContext.WithDataSource().Operators;

    [TestMethod]
    [DataRow("1.0 'mg':2.0 'mg'", 1.0, "mg", 2.0, "mg", DisplayName = "Spec example")]
    [DataRow("1:128", 1.0, "1", 128.0, "1", DisplayName = "Without units")]
    [DataRow("1 'mg':128", 1.0, "mg", 128.0, "1", DisplayName = "Unit on the numerator only")]
    [DataRow("1'mg':2'mL'", 1.0, "mg", 2.0, "mL", DisplayName = "No space before the unit")]
    [DataRow("1   'mg':2\t'mL'", 1.0, "mg", 2.0, "mL", DisplayName = "Several spaces or a tab before the unit")]
    [DataRow(" 1 'mg' : 2 'mL' ", 1.0, "mg", 2.0, "mL", DisplayName = "Spaces around the colon and the string")]
    [DataRow("-1.5 'mg':+2.25 'mL'", -1.5, "mg", 2.25, "mL", DisplayName = "Polarity indicators")]
    [DataRow("0.001 'g':1 'kg'", 0.001, "g", 1.0, "kg", DisplayName = "Fractional value")]
    [DataRow("5 '{beats:min}':1 'min'", 5.0, "{beats:min}", 1.0, "min", DisplayName = "Colon inside a unit")]
    public void ConvertStringToRatio_WellFormedString_ReturnsRatio(
        string input,
        double numeratorValue,
        string numeratorUnit,
        double denominatorValue,
        string denominatorUnit)
    {
        var ratio = GetOperators().ConvertStringToRatio(input);

        ratio.Should().NotBeNull();
        ratio!.numerator.Should().BeEquivalentTo(new CqlQuantity((decimal)numeratorValue, numeratorUnit));
        ratio.denominator.Should().BeEquivalentTo(new CqlQuantity((decimal)denominatorValue, denominatorUnit));
    }

    [TestMethod]
    [DataRow("1.0 'mg';2.0 'mg'", DisplayName = "Spec example, semicolon instead of colon")]
    [DataRow("1.0 'mg'", DisplayName = "No colon")]
    [DataRow("1.0 'mg':", DisplayName = "Missing denominator")]
    [DataRow(":2.0 'mg'", DisplayName = "Missing numerator")]
    [DataRow("1:2:3", DisplayName = "Three parts")]
    [DataRow("", DisplayName = "Empty string")]
    [DataRow(":", DisplayName = "Colon only")]
    [DataRow("1 'mg:2 'mg'", DisplayName = "Unterminated unit")]
    [DataRow("1 mg':2 'mg'", DisplayName = "Unit without opening quote")]
    [DataRow("1 mg:2 mg", DisplayName = "Unquoted units")]
    [DataRow("1 '':2", DisplayName = "Empty unit")]
    [DataRow("1 'mg' x:2", DisplayName = "Text after the unit")]
    [DataRow("1 'm'g':2", DisplayName = "Quote inside the unit")]
    [DataRow("one:two", DisplayName = "Not a number")]
    [DataRow(".5:1", DisplayName = "No digit before the decimal point")]
    [DataRow("1.:2", DisplayName = "No digit after the decimal point")]
    [DataRow("1,000:2", DisplayName = "Thousands separator")]
    [DataRow("1e3:2", DisplayName = "Exponent")]
    [DataRow("--1:2", DisplayName = "Two polarity indicators")]
    [DataRow("99999999999999999999999999999999:1", DisplayName = "Value out of the Decimal range")]
    public void ConvertStringToRatio_MalformedString_ReturnsNull(string input)
    {
        GetOperators().ConvertStringToRatio(input).Should().BeNull();
        GetOperators().ConvertsToRatio(input).Should().BeFalse();
    }

    [TestMethod]
    public void ConvertStringToRatio_Null_ReturnsNull() =>
        GetOperators().ConvertStringToRatio(null).Should().BeNull();

    [TestMethod]
    public void ConvertRatioToString_ThenConvertStringToRatio_RoundTrips()
    {
        var operators = GetOperators();
        var ratio = new CqlRatio(new CqlQuantity(-1.50m, "mg"), new CqlQuantity(3m, "{beats:min}"));

        var text = operators.ConvertRatioToString(ratio);
        var parsed = operators.ConvertStringToRatio(text);

        text.Should().Be("-1.50 'mg':3 '{beats:min}'");
        parsed.Should().BeEquivalentTo(ratio);
        operators.Equal(parsed, ratio).Should().BeTrue();
    }

    [TestMethod]
    public void Convert_StringToRatio_ParsesLikeConvertStringToRatio()
    {
        var operators = GetOperators();

        operators.Convert<CqlRatio>("1 'mg':2 'mL'").Should().BeEquivalentTo(operators.ConvertStringToRatio("1 'mg':2 'mL'"));
        operators.Convert<CqlRatio>("1 'mg';2 'mL'").Should().BeNull();
    }

    [TestMethod]
    [DataRow("1.0 'mg':2.0 'mg'")]
    [DataRow("1:128")]
    public void ConvertsToRatio_WellFormedString_ReturnsTrue(string input) =>
        GetOperators().ConvertsToRatio(input).Should().BeTrue();

    [TestMethod]
    public void ConvertsToRatio_Ratio_ReturnsTrue() =>
        GetOperators().ConvertsToRatio(new CqlRatio(new CqlQuantity(1m, "mg"), new CqlQuantity(2m, "mL"))).Should().BeTrue();

    [TestMethod]
    public void ConvertsToRatio_Null_ReturnsNull() =>
        GetOperators().ConvertsToRatio(null).Should().BeNull();

    [TestMethod]
    public void ConvertsToRatio_OtherType_ReturnsFalse()
    {
        var operators = GetOperators();
        operators.ConvertsToRatio(1).Should().BeFalse();
        operators.ConvertsToRatio(1.5m).Should().BeFalse();
        operators.ConvertsToRatio(new CqlQuantity(1m, "mg")).Should().BeFalse();
    }

    [TestMethod]
    public void ConvertRatioToQuantity_DifferentUnits_DividesValuesAndUnits()
    {
        var operators = GetOperators();
        var ratio = new CqlRatio(new CqlQuantity(6m, "mg"), new CqlQuantity(2m, "mL"));

        var quantity = operators.ConvertRatioToQuantity(ratio);

        // The result is the quotient of the parts, as the Divide operator computes it. Divide
        // expresses a quotient of different units in UCUM canonical units, so the unit is not
        // spelled 'mg/mL', but the quantity is equal to 3 'mg/mL'.
        quantity.Should().NotBeNull();
        quantity.Should().BeEquivalentTo(operators.Divide(ratio.numerator, ratio.denominator));
        operators.Equal(quantity, new CqlQuantity(3m, "mg/mL")).Should().BeTrue();
        operators.Equal(quantity, new CqlQuantity(3.1m, "mg/mL")).Should().BeFalse();
    }

    [TestMethod]
    public void ConvertRatioToQuantity_SameUnits_ReturnsDefaultUnit()
    {
        var quantity = GetOperators().ConvertRatioToQuantity(new CqlRatio(new CqlQuantity(1m, "mg"), new CqlQuantity(4m, "mg")));

        quantity.Should().BeEquivalentTo(new CqlQuantity(0.25m, "1"));
    }

    [TestMethod]
    public void ConvertRatioToQuantity_DefaultUnitDenominator_KeepsNumeratorUnit()
    {
        var quantity = GetOperators().ConvertRatioToQuantity(new CqlRatio(new CqlQuantity(10m, "mg"), new CqlQuantity(4m, "1")));

        quantity.Should().BeEquivalentTo(new CqlQuantity(2.5m, "mg"));
    }

    [TestMethod]
    public void ConvertRatioToQuantity_ZeroDenominator_ReturnsNull() =>
        GetOperators().ConvertRatioToQuantity(new CqlRatio(new CqlQuantity(1m, "mg"), new CqlQuantity(0m, "mL"))).Should().BeNull();

    [TestMethod]
    public void ConvertRatioToQuantity_Null_ReturnsNull() =>
        GetOperators().ConvertRatioToQuantity(null).Should().BeNull();

    [TestMethod]
    public void ConvertRatioToQuantity_NullPart_ReturnsNull()
    {
        var operators = GetOperators();
        operators.ConvertRatioToQuantity(new CqlRatio(null, new CqlQuantity(1m, "mL"))).Should().BeNull();
        operators.ConvertRatioToQuantity(new CqlRatio(new CqlQuantity(1m, "mg"), null)).Should().BeNull();
    }
}
