/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using FhirString = Hl7.Fhir.Model.FhirString;

namespace CoreTests;

/// <summary>
/// Point comparisons between two values of different types.
/// </summary>
/// <remarks>
/// <para>
/// CQL is statically typed: the comparison operators are declared over two operands of one type
/// (§9.B Greater: <c>&gt;(left Date, right Date)</c>, <c>&gt;(left DateTime, right DateTime)</c>, …;
/// After: <c>after precision of(left Date, right Date)</c>, …), and where the CQL types allow it the
/// translator inserts the implicit conversion that makes the operands agree (§3 Implicit
/// Conversions: "the language will also automatically apply implicit conversions when appropriate
/// to produce a correctly typed expression").
/// </para>
/// <para>
/// A pair of values of different types that still reaches the runtime has no order: the ordering
/// operators give null, as they do for other values that cannot be compared, such as quantities
/// whose units have different dimensions. The two values are never equal, so equality gives false
/// and equivalence false. Most importantly, no pair may be <c>after</c> each other in both
/// directions.
/// </para>
/// <para>
/// The operands are passed as <see cref="object"/>, so the <c>(object?, object?)</c> overloads that
/// generated code calls for point comparisons bind.
/// </para>
/// </remarks>
[TestClass]
[TestCategory("UnitTest")]
public class MismatchedTypeComparisonTests
{
    private static ICqlOperators Operators => FhirCqlContext.WithDataSource().Operators;

    private static readonly CqlDate Date2024 = new(2024, 1, 1);

    private static readonly CqlDateTime DateTime2030 = new(2030, 1, 1, null, null, null, null, null, null);

    private static readonly CqlTime Time10 = new(10, 0, 0, null, null, null);

    /// <summary>
    /// Each pair once, with a description for the test output; every test evaluates it in both
    /// orders. Integer and Decimal, and a Quantity and a Decimal, have a System type on one side,
    /// which the comparer otherwise moves to the right of the comparison.
    /// </summary>
    private static IEnumerable<object[]> MismatchedPairs =>
    [
        ["Date and DateTime", Date2024, DateTime2030],
        ["Date and Time", Date2024, Time10],
        ["DateTime and Time", DateTime2030, Time10],
        ["Integer and Decimal", 1, 2.0m],
        ["Integer and Long", 1, 2L],
        ["Integer and String", 1, "2"],
        ["Quantity and Decimal", new CqlQuantity(1m, "1"), 2.0m],
    ];

    #region The pair from the issue

    [TestMethod]
    public void After_DateAndDateTime_IsNotTrueInBothDirections()
    {
        var operators = Operators;
        var dateAfterDateTime = operators.After(Date2024, DateTime2030, null);
        var dateTimeAfterDate = operators.After(DateTime2030, Date2024, null);

        Assert.IsFalse(dateAfterDateTime == true && dateTimeAfterDate == true,
            $"After(Date 2024, DateTime 2030) = {dateAfterDateTime} and After(DateTime 2030, Date 2024) = {dateTimeAfterDate}.");
    }

    [TestMethod]
    public void Greater_DateAndDateTime_IsNotTrueInBothDirections()
    {
        var operators = Operators;
        var dateGreater = operators.Greater(Date2024, DateTime2030);
        var dateTimeGreater = operators.Greater(DateTime2030, Date2024);

        Assert.IsFalse(dateGreater == true && dateTimeGreater == true,
            $"Greater(Date 2024, DateTime 2030) = {dateGreater} and Greater(DateTime 2030, Date 2024) = {dateTimeGreater}.");
    }

    #endregion

    #region Ordering operators give null in both orders

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void After_OfMismatchedTypes_IsNull(string pair, object a, object b)
    {
        Assert.IsNull(Operators.After(a, b, null), $"{pair}: a after b");
        Assert.IsNull(Operators.After(b, a, null), $"{pair}: b after a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void Before_OfMismatchedTypes_IsNull(string pair, object a, object b)
    {
        Assert.IsNull(Operators.Before(a, b, null), $"{pair}: a before b");
        Assert.IsNull(Operators.Before(b, a, null), $"{pair}: b before a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void After_WithPrecision_OfMismatchedTypes_IsNull(string pair, object a, object b)
    {
        Assert.IsNull(Operators.After(a, b, "year"), $"{pair}: a after year of b");
        Assert.IsNull(Operators.After(b, a, "year"), $"{pair}: b after year of a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void Greater_OfMismatchedTypes_IsNull(string pair, object a, object b)
    {
        Assert.IsNull(Operators.Greater(a, b), $"{pair}: a > b");
        Assert.IsNull(Operators.Greater(b, a), $"{pair}: b > a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void GreaterOrEqual_OfMismatchedTypes_IsNull(string pair, object a, object b)
    {
        Assert.IsNull(Operators.GreaterOrEqual(a, b), $"{pair}: a >= b");
        Assert.IsNull(Operators.GreaterOrEqual(b, a), $"{pair}: b >= a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void Less_OfMismatchedTypes_IsNull(string pair, object a, object b)
    {
        Assert.IsNull(Operators.Less(a, b), $"{pair}: a < b");
        Assert.IsNull(Operators.Less(b, a), $"{pair}: b < a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void LessOrEqual_OfMismatchedTypes_IsNull(string pair, object a, object b)
    {
        Assert.IsNull(Operators.LessOrEqual(a, b), $"{pair}: a <= b");
        Assert.IsNull(Operators.LessOrEqual(b, a), $"{pair}: b <= a");
    }

    #endregion

    #region Equality and equivalence: values of different types are never equal

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void Equal_OfMismatchedTypes_IsFalse(string pair, object a, object b)
    {
        Assert.AreEqual(false, Operators.Equal(a, b), $"{pair}: a = b");
        Assert.AreEqual(false, Operators.Equal(b, a), $"{pair}: b = a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void NotEqual_OfMismatchedTypes_IsTrue(string pair, object a, object b)
    {
        Assert.AreEqual(true, Operators.NotEqual(a, b), $"{pair}: a != b");
        Assert.AreEqual(true, Operators.NotEqual(b, a), $"{pair}: b != a");
    }

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void Equivalent_OfMismatchedTypes_IsFalse(string pair, object a, object b)
    {
        Assert.AreEqual(false, Operators.Equivalent(a, b), $"{pair}: a ~ b");
        Assert.AreEqual(false, Operators.Equivalent(b, a), $"{pair}: b ~ a");
    }

    /// <summary>
    /// Lists are equal only if their elements are of the same type (§9.B Equal: "For list types,
    /// this means that equality returns true if and only if the lists contain elements of the same
    /// type, …"), so elements that have no order against each other still make the lists unequal,
    /// also when the lists are themselves elements.
    /// </summary>
    [TestMethod]
    public void Lists_WhoseElementsDifferInType_AreUnequal()
    {
        var operators = Operators;
        object[] integers = [1, 2];
        object[] strings = ["1", "2"];

        Assert.AreEqual(false, operators.Equal(integers, strings));
        Assert.AreEqual(false, operators.Equal(strings, integers));
        Assert.AreEqual(false, operators.Equal(new object[] { integers }, new object[] { strings }));
        Assert.AreEqual(false, operators.Equal(new object[] { strings }, new object[] { integers }));
    }

    /// <summary>
    /// Tuple equality is "a conjunction of equality comparisons" of the elements (§9.B Equal), so an
    /// element whose values differ in type makes the tuples unequal.
    /// </summary>
    [TestMethod]
    public void Tuples_WhoseElementsDifferInType_AreUnequal()
    {
        var operators = Operators;
        var metadata = new CqlTupleMetadata([typeof(object)], ["x"]);
        (CqlTupleMetadata, object? x) integerElement = (metadata, 1);
        (CqlTupleMetadata, object? x) stringElement = (metadata, "1");

        Assert.AreEqual(false, operators.Equal(integerElement, stringElement));
        Assert.AreEqual(false, operators.Equal(stringElement, integerElement));
    }

    #endregion

    #region The comparers themselves

    [TestMethod]
    [DynamicData(nameof(MismatchedPairs))]
    public void CqlComparers_OfMismatchedTypes_HaveNoOrderAndAreUnequal(string pair, object a, object b)
    {
        ICqlComparer comparers = new CqlComparers();

        Assert.IsNull(comparers.Compare(a, b, null), $"{pair}: Compare(a, b)");
        Assert.IsNull(comparers.Compare(b, a, null), $"{pair}: Compare(b, a)");
        Assert.IsNull(comparers.CompareValues(a, b, null), $"{pair}: CompareValues(a, b)");
        Assert.IsNull(comparers.CompareValues(b, a, null), $"{pair}: CompareValues(b, a)");
        Assert.AreEqual(false, comparers.Equals(a, b, null), $"{pair}: Equals(a, b)");
        Assert.AreEqual(false, comparers.Equals(b, a, null), $"{pair}: Equals(b, a)");
        Assert.AreEqual(false, comparers.EqualsValues(a, b, null), $"{pair}: EqualsValues(a, b)");
        Assert.AreEqual(false, comparers.EqualsValues(b, a, null), $"{pair}: EqualsValues(b, a)");
    }

    /// <summary>
    /// A comparer for one type has no order for a value of another type, whichever side it is on,
    /// through both the null-aware entry point and the one for values known to be non-null.
    /// </summary>
    [TestMethod]
    public void TypedComparer_OfAValueOfAnotherType_HasNoOrderAndIsUnequal()
    {
        ICqlComparer dateComparer = new CqlComparers.InterfaceCqlComparer<CqlDate>();

        Assert.IsNull(dateComparer.Compare(Date2024, DateTime2030, null));
        Assert.IsNull(dateComparer.Compare(DateTime2030, Date2024, null));
        Assert.IsNull(dateComparer.CompareValues(Date2024, DateTime2030, null));
        Assert.IsNull(dateComparer.CompareValues(DateTime2030, Date2024, null));
        Assert.AreEqual(false, dateComparer.Equals(Date2024, DateTime2030, null));
        Assert.AreEqual(false, dateComparer.EqualsValues(Date2024, DateTime2030, null));

        ICqlComparer integerComparer = new DefaultCqlComparer<int>();

        Assert.IsNull(integerComparer.Compare(1, 2L, null));
        Assert.IsNull(integerComparer.Compare(2L, 1, null));
        Assert.IsNull(integerComparer.CompareValues(1, 2L, null));
        Assert.IsNull(integerComparer.CompareValues(2L, 1, null));
    }

    /// <summary>
    /// The null operands still have the total order the comparers give them for sorting, before any
    /// type is inspected.
    /// </summary>
    [TestMethod]
    public void TypedComparer_NullOperands_KeepTheirOrder()
    {
        ICqlComparer dateComparer = new CqlComparers.InterfaceCqlComparer<CqlDate>();

        Assert.AreEqual(0, dateComparer.Compare(null, null, null));
        Assert.AreEqual(1, dateComparer.Compare(null, DateTime2030, null));
        Assert.AreEqual(-1, dateComparer.Compare(DateTime2030, null, null));
    }

    #endregion

    #region Members of lists, tuples and key-value pairs nested in each other

    private const int NestingDepth = 16;

    private static readonly CqlTupleMetadata NestingMetadata = new([typeof(object)], ["x"]);

    /// <summary>
    /// <paramref name="member"/> as the only member of <see cref="NestingDepth"/> lists, tuples or
    /// key-value pairs nested in each other, each allocated anew.
    /// </summary>
    private static object Nest(string nesting, object member)
    {
        for (var level = 0; level < NestingDepth; level++)
        {
            member = nesting switch
            {
                "lists"           => new List<object> { member },
                "tuples"          => (NestingMetadata, (object?)member),
                "key-value pairs" => new KeyValuePair<object, object>("key", member),
                _                 => throw new ArgumentOutOfRangeException(nameof(nesting), nesting, null),
            };
        }

        return member;
    }

    /// <summary>
    /// A value whose comparison with another is unknown, as it is for two DateTimes of different
    /// precisions.
    /// </summary>
    private sealed class Uncertain;

    private sealed class CountingUncertainComparer : CqlComparer<Uncertain>
    {
        public int Comparisons { get; private set; }

        protected override int? CompareValues(Uncertain x, Uncertain y, string? precision)
        {
            Comparisons++;
            return null;
        }
    }

    /// <summary>
    /// Whether two members are of different types comes from the dispatch that compares them, so
    /// values nested in each other compare the members whose comparison is unknown once, not once
    /// for every level they are nested in (2^16 times at this depth).
    /// </summary>
    [TestMethod]
    [DataRow("lists")]
    [DataRow("tuples")]
    [DataRow("key-value pairs")]
    public void NestedMembers_WhoseComparisonIsUnknown_AreComparedOnce(string nesting)
    {
        var uncertainComparer = new CountingUncertainComparer();
        ICqlComparer comparers = new CqlComparers().Register(typeof(Uncertain), uncertainComparer);
        var x = Nest(nesting, new Uncertain());
        var y = Nest(nesting, new Uncertain());

        Assert.IsNull(comparers.Compare(x, y, null), $"{nesting}: Compare");
        Assert.AreEqual(1, uncertainComparer.Comparisons, $"{nesting}: comparisons by Compare");

        Assert.IsNull(comparers.Equals(x, y, null), $"{nesting}: Equals");
        Assert.AreEqual(2, uncertainComparer.Comparisons, $"{nesting}: comparisons by Compare and Equals");
    }

    /// <summary>
    /// Members of different types make the values they are nested in unequal at any depth, in both
    /// orders.
    /// </summary>
    [TestMethod]
    [DataRow("lists")]
    [DataRow("tuples")]
    [DataRow("key-value pairs")]
    public void NestedMembers_OfDifferentTypes_AreUnequal(string nesting)
    {
        var operators = Operators;
        var integers = Nest(nesting, 1);
        var strings = Nest(nesting, "1");

        Assert.AreEqual(false, operators.Equal(integers, strings), $"{nesting}: integers = strings");
        Assert.AreEqual(false, operators.Equal(strings, integers), $"{nesting}: strings = integers");
    }

    #endregion

    #region Controls: comparisons that are not between mismatched types are unchanged

    [TestMethod]
    public void SameTypePairs_StillCompare()
    {
        var operators = Operators;
        Assert.AreEqual(true, operators.After(new CqlDate(2030, 1, 1), Date2024, null));
        Assert.AreEqual(false, operators.After(Date2024, new CqlDate(2030, 1, 1), null));
        Assert.AreEqual(true, operators.Greater(2, 1));
        Assert.AreEqual(false, operators.Greater(1, 2));
        Assert.AreEqual(true, operators.Less(1.0m, 2.0m));
        Assert.AreEqual(true, operators.Equal(Date2024, new CqlDate(2024, 1, 1)));
        Assert.AreEqual(false, operators.Equal(Date2024, new CqlDate(2025, 1, 1)));
    }

    /// <summary>
    /// <c>@2012-01-01T = @2012-01-01T12</c> stays null for the reason the spec gives, so
    /// a null from insufficient precision is not mistaken for a pair the comparer cannot order.
    /// </summary>
    [TestMethod]
    public void SameTypePair_WithUncertainPrecision_IsStillNull()
    {
        var operators = Operators;
        var dayPrecision = new CqlDateTime(2012, 1, 1, null, null, null, null, null, null);
        var hourPrecision = new CqlDateTime(2012, 1, 1, 12, null, null, null, null, null);

        Assert.IsNull(operators.Equal(dayPrecision, hourPrecision));
        Assert.IsNull(operators.Greater(dayPrecision, hourPrecision));
    }

    /// <summary>
    /// A FHIR primitive and the value it carries are compared by the comparer registered for the
    /// FHIR type, which compares the two different types on purpose, in either order.
    /// </summary>
    [TestMethod]
    public void FhirPrimitiveAndItsValue_StillCompare()
    {
        var operators = Operators;
        Assert.AreEqual(true, operators.Equal(new FhirString("a"), "a"));
        Assert.AreEqual(true, operators.Equal("a", new FhirString("a")));
        Assert.AreEqual(false, operators.Equal(new FhirString("a"), "b"));
        Assert.AreEqual(true, operators.Greater(new FhirString("b"), "a"));
        Assert.AreEqual(true, operators.Less("a", new FhirString("b")));
    }

    /// <summary>
    /// A list whose elements have a choice type holds values of different types, and membership and
    /// list equality compare each element against values of the other types along the way.
    /// </summary>
    [TestMethod]
    public void ListOfMixedTypes_MembershipAndEquality_StillWork()
    {
        var operators = Operators;
        object?[] mixed = [1, "a"];

        Assert.AreEqual(true, operators.In<object>("a", mixed));
        Assert.AreEqual(true, operators.In<object>(1, mixed));
        Assert.AreEqual(false, operators.In<object>(2, mixed));
        Assert.AreEqual(true, operators.ListEqual<object?>(mixed, [1, "a"]));
        Assert.AreEqual(false, operators.ListEqual<object?>(mixed, ["a", 1]));
    }

    #endregion
}
