/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Primitives;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace CoreTests.Infrastructure;

[TestClass]
public class ElmTupleTypeUtilityTests
{
    [TestMethod]
    public void AreCompatibleForUnionOperation_TuplePropertiesWithRegisteredConversion_ReturnsTrue()
    {
        var typeConverter = TypeConverter.Create();

        var result = ElmTupleTypeUtility.AreCompatibleForUnionOperation(typeof(TupleWithUri), typeof(TupleWithString), typeConverter);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanConvertForUnionOperation_OnlyConsidersConversionsTowardsTheTarget()
    {
        // The default converter registers CqlDate -> CqlDateTime but not the reverse,
        // so the tuple converts in that direction only.
        var typeConverter = TypeConverter.Create();

        Assert.IsTrue(ElmTupleTypeUtility.CanConvertForUnionOperation(typeof(TupleWithDate), typeof(TupleWithDateTime), typeConverter));
        Assert.IsFalse(ElmTupleTypeUtility.CanConvertForUnionOperation(typeof(TupleWithDateTime), typeof(TupleWithDate), typeConverter));

        // The symmetric compatibility check accepts both orders.
        Assert.IsTrue(ElmTupleTypeUtility.AreCompatibleForUnionOperation(typeof(TupleWithDateTime), typeof(TupleWithDate), typeConverter));
    }

    [TestMethod]
    public void CanConvertForUnionOperation_SameOrAssignableTypes_ReturnsTrue()
    {
        var typeConverter = TypeConverter.Create();

        Assert.IsTrue(ElmTupleTypeUtility.CanConvertForUnionOperation(typeof(TupleWithUri), typeof(TupleWithUri), typeConverter));
        Assert.IsTrue(ElmTupleTypeUtility.CanConvertForUnionOperation(typeof(TupleWithUri), typeof(object), typeConverter));
        Assert.IsFalse(ElmTupleTypeUtility.CanConvertForUnionOperation(typeof(object), typeof(TupleWithUri), typeConverter));
    }

    private sealed class TupleWithUri : TupleBaseType
    {
        public Uri Value { get; set; } = new("https://example.org");
    }

    private sealed class TupleWithString : TupleBaseType
    {
        public string Value { get; set; } = string.Empty;
    }

    private sealed class TupleWithDate : TupleBaseType
    {
        public Hl7.Cql.Primitives.CqlDate? Value { get; set; }
    }

    private sealed class TupleWithDateTime : TupleBaseType
    {
        public Hl7.Cql.Primitives.CqlDateTime? Value { get; set; }
    }
}
