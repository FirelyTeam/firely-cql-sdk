/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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

    private sealed class TupleWithUri : TupleBaseType
    {
        public Uri Value { get; set; } = new("https://example.org");
    }

    private sealed class TupleWithString : TupleBaseType
    {
        public string Value { get; set; } = string.Empty;
    }
}
