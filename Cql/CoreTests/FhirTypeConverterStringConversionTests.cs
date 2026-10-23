/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Fhir.Serialization.Extensions;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace CoreTests;

using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

/// <summary>
/// The string conversions of <see cref="FhirTypeConverter"/> to Integer, Long, Decimal and Date give what the matching
/// To* operator gives (spec §9.B, Type Operators), so a string converts alike whether a host converts it or a CQL
/// expression does. A FHIR primitive does not go through them: it converts from the value it holds.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class FhirTypeConverterStringConversionTests
{
    private static readonly TypeConverter Converter = FhirTypeConverter.Create(ModelInfo.ModelInspector);

    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    #region The To* operators' accepted and rejected forms

    [TestMethod]
    [DynamicData(nameof(ToOperatorTests.ToIntegerOfAStringCases), typeof(ToOperatorTests))]
    public void ConvertString_ToInteger_GivesWhatToIntegerGives(string argumentDescription, string argument, int? expected) =>
        Assert.AreEqual(expected, Converter.Convert<int?>(argument), argumentDescription);

    [TestMethod]
    [DynamicData(nameof(ToOperatorTests.ToLongCases), typeof(ToOperatorTests))]
    public void ConvertString_ToLong_GivesWhatToLongGives(string argumentDescription, string argument, long? expected) =>
        Assert.AreEqual(expected, Converter.Convert<long?>(argument), argumentDescription);

    [TestMethod]
    [DynamicData(nameof(ToOperatorTests.ToDecimalCases), typeof(ToOperatorTests))]
    public void ConvertString_ToDecimal_GivesWhatToDecimalGives(string argumentDescription, string argument, decimal? expected) =>
        Assert.AreEqual(expected, Converter.Convert<decimal?>(argument), argumentDescription);

    [TestMethod]
    [DynamicData(nameof(ToOperatorTests.ToDateCases), typeof(ToOperatorTests))]
    public void ConvertString_ToDate_GivesWhatToDateGives(string argumentDescription, string argument, string? expected) =>
        Assert.AreEqual(expected, Converter.Convert<CqlDate>(argument)?.ToString(), argumentDescription);

    #endregion

    #region Forms .NET's number parsing accepts

    /// <summary>
    /// Strings that .NET parses with <see cref="NumberStyles.Integer"/> (Integer, Long) or <see cref="NumberStyles.Number"/>
    /// (Decimal) under the invariant culture, which are outside the format of ToInteger, ToLong or ToDecimal:
    /// whitespace around the number, a group separator, a trailing sign, and a decimal point without a digit on both
    /// sides. Each gives null, from the converter as from the operator.
    /// </summary>
    private static IEnumerable<object?[]> FormsDotNetAcceptsCases =>
    [
        ["Surrounding spaces ' 1 '", "Integer", " 1 "],
        ["Leading tab and trailing line break '\\t1\\r\\n'", "Integer", "\t1\r\n"],
        ["Leading sign after a space ' -1'", "Integer", " -1"],
        ["Surrounding spaces ' 1 '", "Long", " 1 "],
        ["Trailing line feed '1\\n'", "Long", "1\n"],
        ["Surrounding spaces ' 1.5 '", "Decimal", " 1.5 "],
        ["Group separator and decimals '1,000.25'", "Decimal", "1,000.25"],
        ["Decimal comma, read as a group separator, '12,34'", "Decimal", "12,34"],
        ["Misplaced group separators '1,0,0'", "Decimal", "1,0,0"],
        ["Trailing sign '1.5-'", "Decimal", "1.5-"],
        ["Signed, no digit before the point '-.5'", "Decimal", "-.5"],
        ["No digit after the point '1.'", "Decimal", "1."],
    ];

    [TestMethod]
    [DynamicData(nameof(FormsDotNetAcceptsCases))]
    public void ConvertString_ToNumber_GivesNullForAFormOnlyDotNetAccepts(string argumentDescription, string numberType, string argument) =>
        AssertNullFromOperatorAndConverter(argumentDescription, numberType, argument);

    /// <summary>
    /// .NET's number parsing also ignores trailing NUL characters. These cases are kept out of the data rows above, whose
    /// arguments appear verbatim in the test names.
    /// </summary>
    [TestMethod]
    public void ConvertString_ToNumber_GivesNullForATrailingNulCharacter()
    {
        AssertNullFromOperatorAndConverter("Trailing NUL '1\\0'", "Integer", "1\0");
        AssertNullFromOperatorAndConverter("Trailing NUL '1\\0'", "Long", "1\0");
        AssertNullFromOperatorAndConverter("Trailing NUL '1.5\\0'", "Decimal", "1.5\0");
    }

    private static void AssertNullFromOperatorAndConverter(string argumentDescription, string numberType, string argument)
    {
        var operators = Operators();
        var (fromOperator, fromConverter) = numberType switch
        {
            "Integer" => ((object?)operators.ConvertStringToInteger(argument), (object?)Converter.Convert<int?>(argument)),
            "Long" => (operators.ConvertStringToLong(argument), Converter.Convert<long?>(argument)),
            "Decimal" => (operators.ConvertStringToDecimal(argument), Converter.Convert<decimal?>(argument)),
            _ => throw new ArgumentException($"Not a CQL number type: {numberType}", nameof(numberType)),
        };

        Assert.IsNull(fromOperator, $"To{numberType}: {argumentDescription}");
        Assert.IsNull(fromConverter, $"FhirTypeConverter to {numberType}: {argumentDescription}");
    }

    #endregion

    #region FHIR primitives

    /// <summary>
    /// A FHIR primitive converts from the value it holds, never by parsing text, so the CQL number format does not apply
    /// to it.
    /// </summary>
    [TestMethod]
    public void ConvertFhirPrimitive_ConvertsFromTheValueItHolds()
    {
        Converter.Convert<int?>(new Integer(-25)).Should().Be(-25);
        Converter.Convert<decimal?>(new FhirDecimal(1000.25m)).Should().Be(1000.25m);
        Converter.Convert<decimal?>(new Quantity(1000.25m, "mg")).Should().Be(1000.25m);
        Converter.Convert<int?>(new Quantity(25m, "1")).Should().Be(25);
        Converter.Convert<long?>(new Quantity(3000000000m, "1")).Should().Be(3000000000L);
        Converter.Convert<int?>(new Parameters.ParameterComponent { Name = "count", Value = new Integer(7) }).Should().Be(7);
        Converter.Convert<CqlDate>(new Date("2014-01-01"))?.ToString().Should().Be("2014-01-01");
    }

    /// <summary>
    /// FHIR's JSON number format admits an exponent, which the format of ToDecimal does not. A FHIR decimal written
    /// with one still converts, since the FHIR parser has already read its value.
    /// </summary>
    [TestMethod]
    public void ConvertFhirDecimal_WrittenWithAnExponent_ConvertsFromItsValue()
    {
        var observation = """
            {
              "resourceType": "Observation",
              "status": "final",
              "code": { "text": "weight" },
              "valueQuantity": { "value": 1.5e3, "unit": "g" }
            }
            """.DeserializeJsonToFhir<Observation>();
        var quantity = observation.Value.Should().BeOfType<Quantity>().Subject;

        Converter.Convert<decimal?>(quantity.ValueElement).Should().Be(1500m);
        Converter.Convert<decimal?>(quantity).Should().Be(1500m);
        Converter.Convert<decimal?>("1.5e3").Should().BeNull("a string takes the format of ToDecimal");
    }

    #endregion
}
