/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// The .NET equality of <see cref="CqlDate"/>, <see cref="CqlDateTime"/> and <see cref="CqlTime"/>, and the CQL
/// operators that build on it: <c>=</c>, <c>~</c>, <c>distinct</c>, <c>union</c>, <c>intersect</c> and <c>except</c>.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class CqlTemporalEqualityTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    private static CqlDateTime DateTime(string text)
    {
        Assert.IsTrue(CqlDateTime.TryParse(text, out var value), text);
        Assert.IsNotNull(value);
        return value;
    }

    private static CqlDate Date(string text)
    {
        Assert.IsTrue(CqlDate.TryParse(text, out var value), text);
        Assert.IsNotNull(value);
        return value;
    }

    private static CqlTime Time(string text)
    {
        Assert.IsTrue(CqlTime.TryParse(text, out var value), text);
        Assert.IsNotNull(value);
        return value;
    }

    private static IEnumerable<object[]> SameValueWrittenTwoWays =>
    [
        [DateTime("2024-03-15T10:00:00Z"), DateTime("2024-03-15T10:00:00+00:00")],
        [DateTime("2024-03-15T10:00:00+01"), DateTime("2024-03-15T10:00:00+01:00")],
        [DateTime("2024-03-15T10:00:00.000Z"), new CqlDateTime(2024, 3, 15, 10, 0, 0, 0, 0, 0)],
        [Date("2024-03-15"), new CqlDate(2024, 3, 15)],
        [Time("T10:00:00Z"), Time("T10:00:00+00:00")],
        [Time("T10:30:00"), new CqlTime(10, 30, 0, null, null, null)],
    ];

    private static IEnumerable<object[]> DifferentValues =>
    [
        [DateTime("2024-03-15T10:00:00Z"), DateTime("2024-03-15T10:00:01Z")],
        [DateTime("2024-03-15T10:00:00Z"), DateTime("2024-03-16T10:00:00Z")],
        [Date("2024-03-15"), Date("2024-03-16")],
        [Time("T10:00:00"), Time("T10:00:01")],
    ];

    [TestMethod]
    [DynamicData(nameof(SameValueWrittenTwoWays))]
    public void Equals_SameValueWrittenTwoWays_IsTrueWithTheSameHashCode(object left, object right)
    {
        Assert.IsTrue(left.Equals(right));
        Assert.IsTrue(right.Equals(left));
        Assert.AreEqual(left.GetHashCode(), right.GetHashCode());
    }

    [TestMethod]
    [DynamicData(nameof(DifferentValues))]
    public void Equals_DifferentValues_IsFalse(object left, object right)
    {
        Assert.IsFalse(left.Equals(right));
        Assert.IsFalse(right.Equals(left));
    }

    [TestMethod]
    public void Equals_TypedOverload_AgreesWithTheObjectOverload()
    {
        var dateTime = DateTime("2024-03-15T10:00:00Z");
        var date = Date("2024-03-15");
        var time = Time("T10:00:00Z");

        Assert.IsTrue(EqualityComparer<CqlDateTime>.Default.Equals(dateTime, DateTime("2024-03-15T10:00:00+00:00")));
        Assert.IsTrue(EqualityComparer<CqlDate>.Default.Equals(date, new CqlDate(2024, 3, 15)));
        Assert.IsTrue(EqualityComparer<CqlTime>.Default.Equals(time, Time("T10:00:00+00:00")));
        Assert.IsFalse(dateTime.Equals((CqlDateTime?)null));
        Assert.IsFalse(date.Equals((CqlDate?)null));
        Assert.IsFalse(time.Equals((CqlTime?)null));
        Assert.IsFalse(dateTime.Equals((object?)null));
        Assert.IsFalse(date.Equals((object?)null));
        Assert.IsFalse(time.Equals((object?)null));
    }

    [TestMethod]
    public void Equals_AnotherTypeWithTheSameText_IsFalse()
    {
        var date = Date("2024-03-15");
        var dateTime = DateTime("2024-03-15");

        Assert.AreEqual(date.ToString(), dateTime.ToString());
        Assert.IsFalse(date.Equals(dateTime));
        Assert.IsFalse(dateTime.Equals(date));
        Assert.IsFalse(date.Equals(date.ToString()));
    }

    [TestMethod]
    [DynamicData(nameof(SameValueWrittenTwoWays))]
    public void CqlEqualAndEquivalent_SameValueWrittenTwoWays_AreTrue(object left, object right)
    {
        var operators = Operators();

        Assert.IsTrue(operators.Equal(left, right));
        Assert.IsTrue(operators.Equal(right, left));
        Assert.IsTrue(operators.Equivalent(left, right));
    }

    [TestMethod]
    [DynamicData(nameof(DifferentValues))]
    public void CqlEqualAndEquivalent_DifferentValues_AreFalse(object left, object right)
    {
        var operators = Operators();

        Assert.IsFalse(operators.Equal(left, right));
        Assert.IsFalse(operators.Equivalent(left, right));
    }

    [TestMethod]
    [DynamicData(nameof(SameValueWrittenTwoWays))]
    public void CqlSetOperators_SameValueWrittenTwoWays_TreatThemAsOneValue(object left, object right)
    {
        var operators = Operators();
        object[] both = [left, right];
        object[] onlyLeft = [left];
        object[] onlyRight = [right];

        Assert.HasCount(1, operators.Distinct(both)!.ToList());
        Assert.HasCount(1, operators.Union(onlyLeft, onlyRight)!.ToList());
        Assert.HasCount(1, operators.Intersect(onlyLeft, onlyRight)!.ToList());
        Assert.IsEmpty(operators.Except(onlyLeft, onlyRight)!.ToList());
    }

    [TestMethod]
    [DynamicData(nameof(DifferentValues))]
    public void CqlSetOperators_DifferentValues_KeepBoth(object left, object right)
    {
        var operators = Operators();
        object[] both = [left, right];
        object[] onlyLeft = [left];
        object[] onlyRight = [right];

        Assert.HasCount(2, operators.Distinct(both)!.ToList());
        Assert.HasCount(2, operators.Union(onlyLeft, onlyRight)!.ToList());
        Assert.IsEmpty(operators.Intersect(onlyLeft, onlyRight)!.ToList());
        Assert.HasCount(1, operators.Except(onlyLeft, onlyRight)!.ToList());
    }

    private static IEnumerable<object[]> EqualDateTimesOfSecondPrecision =>
    [
        [DateTime("2024-03-15T10:00:00Z"), DateTime("2024-03-15T10:00:00Z")],
        [DateTime("2024-03-15T10:00:00Z"), DateTime("2024-03-15T10:00:00+00:00")],
    ];

    [TestMethod]
    [DynamicData(nameof(EqualDateTimesOfSecondPrecision))]
    public void ComparisonToAPrecision_EqualValuesThatLackIt_IsNull(CqlDateTime left, CqlDateTime right)
    {
        var operators = Operators();

        Assert.IsNull(operators.SameAs(left, right, "millisecond"));
        Assert.IsNull(operators.SameOrBefore(left, right, "millisecond"));
        Assert.IsNull(operators.SameOrAfter(left, right, "millisecond"));
        Assert.IsNull(operators.Before(left, right, "millisecond"));
        Assert.IsNull(operators.After(left, right, "millisecond"));
    }

    [TestMethod]
    [DynamicData(nameof(EqualDateTimesOfSecondPrecision))]
    public void ComparisonToAPrecision_EqualValuesThatHaveIt_IsKnown(CqlDateTime left, CqlDateTime right)
    {
        var operators = Operators();

        Assert.IsTrue(operators.SameAs(left, right, "second"));
        Assert.IsTrue(operators.SameOrBefore(left, right, "second"));
        Assert.IsTrue(operators.SameOrAfter(left, right, "second"));
        Assert.IsFalse(operators.Before(left, right, "second"));
        Assert.IsFalse(operators.After(left, right, "second"));
    }

    [TestMethod]
    [DynamicData(nameof(EqualDateTimesOfSecondPrecision))]
    public void ComparisonWithoutAPrecision_EqualValues_IsKnown(CqlDateTime left, CqlDateTime right)
    {
        var operators = Operators();

        Assert.IsTrue(operators.SameAs(left, right, null));
        Assert.IsFalse(operators.Before(left, right, null));
        Assert.IsFalse(operators.After(left, right, null));
    }
}
