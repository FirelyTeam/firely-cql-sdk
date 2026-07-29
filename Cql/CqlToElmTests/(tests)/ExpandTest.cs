/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ExpandCollapseTest : Base
    {
        [TestMethod]
        public void ExpandUnitUnspecified()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[1, 4], Interval[4, 8], Interval[7, 9] }");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }

        [TestMethod]
        public void ExpandPerDay()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[@2018-01-01, @2018-01-04] } per day");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }

        [TestMethod]
        public void ExpandPer2Days()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[@2018-01-01, @2018-01-04] } per 2 days");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }

        [TestMethod]
        public void ExpandIntervalPer2()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval [1, 10] } per 2");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }


        [TestMethod]
        public void Expand_List_Interval()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[10.0, 10.0] } per 0.1");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            expand.operand.Length.Should().Be(2);
            expand.operand[0].Should().HaveType(SystemTypes.DecimalType.ToIntervalType().ToListType());
            var result = Run(expand, lib);
            // not implemented correctly
        }

        [TestMethod]
        public void ExpandIntegerIntervalPerFractional()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[10, 10] } per 0.1");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            // The spec (§9.B, expand) requires { Interval[10.0, 10.0], ..., Interval[10.9, 10.9] } here, i.e. intervals of
            // Decimal, which the Integer-typed overload cannot represent. The invoker does not wrap exceptions, so the
            // runtime error surfaces directly.
            Assert.ThrowsException<NotSupportedException>(() => Run(expand, lib));
        }

        [TestMethod]
        public void ExpandIntegerIntervalPer0()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[1, 10] } per 0");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandDecimalIntervalPerNegative()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[1.0, 2.0] } per -1");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandLongIntervalPer0()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[1L, 10L] } per 0");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandDateTimeIntervalPer0Milliseconds()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[@2023-01-01T00:00:00.000Z, @2023-01-01T00:00:00.001Z] } per 0 milliseconds");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandTimeIntervalPer0Milliseconds()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[@T00:00:00.000, @T00:00:00.001] } per 0 milliseconds");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandDecimalIntervalPer0D5()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[1.0, 2.0] } per 0.5");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            var result = Run<IEnumerable<CqlInterval<decimal?>>>(expand, lib);
            result.Should().NotBeNull();
            // Each interval is [start, Predecessor(start + per)]. The trailing interval starting at the upper boundary
            // reaches past it; that pre-existing off-by-one is unrelated to the non-positive/fractional per guards.
            result!.Select(i => (i!.low, i.high)).Should().Equal(
                (1.0m, 1.49999999m),
                (1.5m, 1.99999999m),
                (2.0m, 2.49999999m));
        }

        [TestMethod]
        public void ExpandDateIntervalPer0Days()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand { Interval[@2018-01-01, @2018-01-04] } per 0 days");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandSingleIntegerIntervalPer0()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand Interval[1, 10] per 0");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandSingleDecimalIntervalPerNegative()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand Interval[1.0, 2.0] per -1");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandSingleLongIntervalPer0()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand Interval[1L, 10L] per 0");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandSingleDateIntervalPer0Days()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand Interval[@2018-01-01, @2018-01-04] per 0 days");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandSingleDateTimeIntervalPer0Milliseconds()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand Interval[@2023-01-01T00:00:00.000Z, @2023-01-01T00:00:00.001Z] per 0 milliseconds");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void ExpandSingleTimeIntervalPer0Milliseconds()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("expand Interval[@T00:00:00.000, @T00:00:00.001] per 0 milliseconds");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            Run(expand, lib).Should().BeNull();
        }

        [TestMethod]
        public void CollapseUnitUnspecified()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("collapse { Interval[1, 4], Interval[4, 8], Interval[7, 9] }");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
        }


        [TestMethod]
        public void CollapseIntervalPerDay()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("collapse { Interval [1, 10] } per day");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
        }


        [TestMethod]
        public void CollapseIntervalPer2Day()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("collapse { Interval [1, 10] } per 2 day");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
        }

        [TestMethod]
        public void DateTimeCollapse()
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression("collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 10), DateTime(2012, 1, 25)], Interval[DateTime(2012, 5, 10), DateTime(2012, 5, 25)], Interval[DateTime(2012, 5, 20), DateTime(2012, 5, 30)] }");
            var collapse = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
            // expected {Interval [ @2012-01-01T, @2012-01-25T ], Interval [ @2012-05-10T, @2012-05-30T ]}
            var result = Run(collapse, lib);
        }
    }
}
