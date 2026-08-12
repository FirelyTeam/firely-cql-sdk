/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace CoreTests.Fhir;

using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

/// <summary>
/// Pins the <see cref="FhirDateTime"/> to <see cref="CqlDateTime"/> conversion results across every
/// partial precision and every shape of timezone offset. These are pure result assertions — they say
/// nothing about how, or whether, the conversion is memoized, so they hold for any implementation that
/// produces the same values.
/// </summary>
[TestClass]
public class FhirDateTimeConversionTests
{
    // The converter a default context actually evaluates with, rather than one built for the test, so the
    // assertions below cover whatever the default configuration happens to be.
    private static readonly TypeConverter Converter =
        ((CqlOperators)FhirCqlContext.CreateContext().Operators).TypeConverter;

    // year, month, day, hour, minute, second, millisecond, offset hours, offset minutes.
    // A null component is a precision boundary; a null offset pair means the value carries no offset.
    private static IEnumerable<object[]> PartialPrecisionsAndOffsets =>
    [
        // Date-only precisions carry no time and therefore no offset.
        ["2014", DateTimePrecision.Year, new CqlDateTime(2014, null, null, null, null, null, null, null, null)],
        ["2014-02", DateTimePrecision.Month, new CqlDateTime(2014, 2, null, null, null, null, null, null, null)],
        ["2014-02-01", DateTimePrecision.Day, new CqlDateTime(2014, 2, 1, null, null, null, null, null, null)],

        // Zulu.
        ["2014-02-01T10:30:15Z", DateTimePrecision.Second, new CqlDateTime(2014, 2, 1, 10, 30, 15, null, 0, 0)],
        ["2014-02-01T10:30:15.123Z", DateTimePrecision.Millisecond, new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, 0, 0)],

        // Positive offset, whole hours and with minutes.
        ["2014-02-01T10:30:15+02:00", DateTimePrecision.Second, new CqlDateTime(2014, 2, 1, 10, 30, 15, null, 2, 0)],
        ["2014-02-01T10:30:15.123+05:45", DateTimePrecision.Millisecond, new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, 5, 45)],

        // Negative offset, whole hours and with minutes.
        ["2014-02-01T10:30:15-05:00", DateTimePrecision.Second, new CqlDateTime(2014, 2, 1, 10, 30, 15, null, -5, 0)],
        ["2014-02-01T10:30:15.123-05:30", DateTimePrecision.Millisecond, new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, -5, -30)],
    ];

    [TestMethod]
    [DynamicData(nameof(PartialPrecisionsAndOffsets))]
    public void ConvertFhirDateTime_PartialPrecisionsAndOffsets_ProduceTheExpectedCqlDateTime(
        string fhirValue,
        DateTimePrecision expectedPrecision,
        CqlDateTime expected)
    {
        var converted = Converter.Convert<CqlDateTime>(new FhirDateTime(fhirValue));

        Assert.IsNotNull(converted);
        Assert.AreEqual(expectedPrecision, converted.Precision);
        Assert.AreEqual(expected.ToString(), converted.ToString());
        Assert.AreEqual(expected, converted);
    }

    // Hour- and minute-precision date/times have no native FHIR representation: the value is zero-padded
    // and the precision it really has is declared by the time-precision extension.
    private static IEnumerable<object[]> DeclaredTimePrecisions =>
    [
        ["2014-02-01T10:00:00Z", "h", DateTimePrecision.Hour, new CqlDateTime(2014, 2, 1, 10, null, null, null, 0, 0)],
        ["2014-02-01T10:30:00Z", "min", DateTimePrecision.Minute, new CqlDateTime(2014, 2, 1, 10, 30, null, null, 0, 0)],
        ["2014-02-01T10:30:15Z", "s", DateTimePrecision.Second, new CqlDateTime(2014, 2, 1, 10, 30, 15, null, 0, 0)],
        ["2014-02-01T10:30:15.123Z", "ms", DateTimePrecision.Millisecond, new CqlDateTime(2014, 2, 1, 10, 30, 15, 123, 0, 0)],
        ["2014-02-01T10:00:00+02:00", "h", DateTimePrecision.Hour, new CqlDateTime(2014, 2, 1, 10, null, null, null, 2, 0)],
        ["2014-02-01T10:30:00-05:00", "min", DateTimePrecision.Minute, new CqlDateTime(2014, 2, 1, 10, 30, null, null, -5, 0)],
    ];

    [TestMethod]
    [DynamicData(nameof(DeclaredTimePrecisions))]
    public void ConvertFhirDateTime_DeclaredTimePrecision_TruncatesThePaddedComponents(
        string fhirValue,
        string precisionCode,
        DateTimePrecision expectedPrecision,
        CqlDateTime expected)
    {
        var fhirDateTime = new FhirDateTime(fhirValue);
        fhirDateTime.AddExtension(Hl7.Cql.Fhir.FhirTypeConverter.TimePrecisionExtensionUrl, new Code(precisionCode));

        var converted = Converter.Convert<CqlDateTime>(fhirDateTime);

        Assert.IsNotNull(converted);
        Assert.AreEqual(expectedPrecision, converted.Precision);
        Assert.AreEqual(expected.ToString(), converted.ToString());
        Assert.AreEqual(expected, converted);
    }

    [TestMethod]
    [DynamicData(nameof(PartialPrecisionsAndOffsets))]
    public void ConvertFhirDateTime_ToDate_ProducesTheDateComponent(
        string fhirValue,
        DateTimePrecision expectedPrecision,
        CqlDateTime expected)
    {
        _ = expectedPrecision;

        var converted = Converter.Convert<CqlDate>(new FhirDateTime(fhirValue));

        Assert.IsNotNull(converted);
        Assert.AreEqual(expected.DateOnly.ToString(), converted.ToString());
        Assert.AreEqual(expected.DateOnly, converted);
    }

    [TestMethod]
    [DynamicData(nameof(PartialPrecisionsAndOffsets))]
    public void ConvertFhirDateTime_RepeatedConversionsOfTheSameValue_AreEqual(
        string fhirValue,
        DateTimePrecision expectedPrecision,
        CqlDateTime expected)
    {
        _ = expectedPrecision;
        _ = expected;

        // Two distinct elements holding the same lexical value, converted repeatedly: every result must
        // be equal. Reference identity is deliberately not asserted — it is not part of the contract.
        var first = Converter.Convert<CqlDateTime>(new FhirDateTime(fhirValue));
        var second = Converter.Convert<CqlDateTime>(new FhirDateTime(fhirValue));
        var third = Converter.Convert<CqlDateTime>(new FhirDateTime(fhirValue));

        Assert.AreEqual(first, second);
        Assert.AreEqual(second, third);
        Assert.AreEqual(first!.GetHashCode(), third!.GetHashCode());
        Assert.AreEqual(first.Precision, third.Precision);
    }

    [TestMethod]
    public void ConvertFhirDateTime_WithoutAValue_IsNull()
    {
        Assert.IsNull(Converter.Convert<CqlDateTime>(new FhirDateTime()));
        Assert.IsNull(Converter.Convert<CqlDate>(new FhirDateTime()));
    }
}
