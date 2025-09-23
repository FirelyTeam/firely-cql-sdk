/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;

namespace CoreTests;

[TestClass]
[TestCategory("UnitTest")]
public class CqlDateTests
{
    [TestMethod]
    public void CqlDate_Subtract_Months_From_Year()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2014", out var baseDate));
        var result = baseDate.Subtract(new CqlQuantity(25m, "month"));
        Assert.AreEqual(2011, result.Value.Year);
        Assert.AreEqual(DateTimePrecision.Year, result.Precision);
    }
}