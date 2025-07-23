using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class TimingExpressionTest : Base
    {
        [TestMethod]
        public void OnOrAfterMonthOf()
        {
            // https://cql.hl7.org/09-b-cqlreference.html#same-or-after-2
            var library = CreateCqlToolkit(EnableIntervalPromotion: true).MakeLibraryFromExpression("Interval[@2012-12-01, @2013-12-01] on or after month of @2012-11-15");
            var sameOrAfter = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SameOrAfter>();
            sameOrAfter.Should().HaveType(SystemTypes.BooleanType);
            sameOrAfter.operand.Should().NotBeNull();
            sameOrAfter.operand.Should().HaveCount(2);
            sameOrAfter.precisionSpecified.Should().BeTrue();
            sameOrAfter.precision.Should().Be(DateTimePrecision.Month);
            sameOrAfter.operand[0].Should().HaveType(SystemTypes.DateType.ToIntervalType());
            sameOrAfter.operand[1].Should().HaveType(SystemTypes.DateType.ToIntervalType());
        }

        [TestMethod]
        public void Starts1DayOrLessOnOrAfter()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library IntervalTest version '1.0.0'

                define private Issue32: Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00] starts 1 day or less on or after day of start of Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]
                """);

            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(And));
            var and = (And)library.statements[0].expression;
            Assert.AreEqual(SystemTypes.BooleanType, and.resultTypeSpecifier);
            Assert.IsNotNull(and.operand);
            Assert.AreEqual(2, and.operand.Length);
            Assert.IsInstanceOfType(and.operand[0], typeof(In));
            {
                var @in = (In)and.operand[0];
                Assert.AreEqual(SystemTypes.BooleanType, @in.resultTypeSpecifier);
                Assert.IsTrue(@in.precisionSpecified);
                Assert.IsNotNull(@in.precision);
                Assert.AreEqual(DateTimePrecision.Day, @in.precision);
                Assert.IsNotNull(@in.operand);
                Assert.AreEqual(2, @in.operand.Length);
                Assert.IsInstanceOfType(@in.operand[0], typeof(Start));
                {
                    var start = (Start)@in.operand[0];
                    Assert.AreEqual(SystemTypes.DateTimeType, start.resultTypeSpecifier);
                    Assert.IsNotNull(start.operand);
                    Assert.IsInstanceOfType(start.operand, typeof(Interval));
                    AssertIntervalType(start.operand.resultTypeSpecifier, SystemTypes.DateTimeType);
                    {
                        var interval = (Interval)start.operand;
                        Assert.IsTrue(interval.lowClosed);
                        Assert.IsTrue(interval.highClosed);
                        Assert.AreEqual("2017-12-20T10:30:00", interval.low.ToString());
                        Assert.AreEqual("2017-12-20T12:00:00", interval.high.ToString());
                    }
                }
                Assert.IsInstanceOfType(@in.operand[1], typeof(Interval));
                {
                    var interval = (Interval)@in.operand[1];
                    Assert.IsInstanceOfType(interval.low, typeof(Start));
                    {
                        var start = (Start)interval.low;
                        Assert.IsNotNull(start.operand);
                        Assert.IsInstanceOfType(start.operand, typeof(Interval));
                        {
                            var lowInterval = (Interval)start.operand;
                            Assert.IsTrue(lowInterval.lowClosed);
                            Assert.IsTrue(lowInterval.highClosed);
                            Assert.AreEqual("2017-12-20T11:00:00", lowInterval.low.ToString());
                            Assert.AreEqual("2017-12-21T21:00:00", lowInterval.high.ToString());
                        }
                    }
                    Assert.IsInstanceOfType(interval.high, typeof(Add));
                    {
                        var add = (Add)interval.high;
                        Assert.IsNotNull(add.operand);
                        Assert.AreEqual(2, add.operand.Length);
                        Assert.IsInstanceOfType(add.operand[0], typeof(Start));
                        {
                            var highStart = (Start)add.operand[0];
                            Assert.AreEqual(SystemTypes.DateTimeType, highStart.resultTypeSpecifier);
                            Assert.IsNotNull(highStart.operand);
                            Assert.IsInstanceOfType(highStart.operand, typeof(Interval));
                            {
                                var highInterval = (Interval)highStart.operand;
                                Assert.IsTrue(highInterval.lowClosed);
                                Assert.IsTrue(highInterval.highClosed);
                                Assert.AreEqual("2017-12-20T11:00:00", highInterval.low.ToString());
                                Assert.AreEqual("2017-12-21T21:00:00", highInterval.high.ToString());
                            }
                        }
                        Assert.IsInstanceOfType(add.operand[1], typeof(Quantity));
                        {
                            var quantity = (Quantity)add.operand[1];
                            Assert.AreEqual(1m, quantity.value);
                            Assert.AreEqual("day", quantity.unit);
                        }
                    }
                }

            }
            Assert.IsInstanceOfType(and.operand[1], typeof(Not));
            {
                var not = (Not)and.operand[1];
                Assert.IsNotNull(not.operand);
                Assert.IsInstanceOfType(not.operand, typeof(IsNull));
                {
                    var isNull = (IsNull)not.operand;
                    Assert.IsNotNull(isNull.operand);
                    Assert.IsInstanceOfType(isNull.operand, typeof(Start));
                    {
                        var start = (Start)isNull.operand;
                        Assert.IsNotNull(start.operand);
                        Assert.IsInstanceOfType(start.operand, typeof(Interval));
                        {
                            var interval = (Interval)start.operand;
                            Assert.IsTrue(interval.lowClosed);
                            Assert.IsTrue(interval.highClosed);
                            Assert.AreEqual("2017-12-20T11:00:00", interval.low.ToString());
                            Assert.AreEqual("2017-12-21T21:00:00", interval.high.ToString());
                        }
                    }
                }
            }
            var result = Run(and, library);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Overlaps()
        {
            var library = CreateCqlToolkit(
                DisableListPromotion: false,
                DisableListDemotion: false,
                EnableIntervalPromotion: true,
                EnableIntervalDemotion: true,
                AllowNullIntervals: true
                ).MakeLibraryFromExpression("Interval[null, null] overlaps Interval[1, 10]");
            var overlaps = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Overlaps>();
            overlaps.Should().HaveType(SystemTypes.BooleanType);
            overlaps.operand.Should().NotBeNull();
            overlaps.operand.Should().HaveCount(2);
            overlaps.precisionSpecified.Should().BeFalse();
            overlaps.operand[0].Should().HaveType(SystemTypes.IntegerType.ToIntervalType());
            overlaps.operand[1].Should().HaveType(SystemTypes.IntegerType.ToIntervalType());
        }

        [TestMethod]
        public void TestOnOrAfterDateTrue()
        {
            var library = CreateCqlToolkit(EnableIntervalPromotion: true).MakeLibraryFromExpression("Interval[@2012-12-01, @2013-12-01] on or after month of @2012-11-15");
            var sameOrAfter = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SameOrAfter>();
            var result = Run<bool?>(sameOrAfter, library);
            result.Should().BeTrue();
        }

        [TestMethod]
        public void TestOnOrBeforeDateTrue()
        {
            var library = CreateCqlToolkit(EnableIntervalPromotion: true).MakeLibraryFromExpression("Interval[@2012-10-01, @2012-11-01] on or before month of @2012-11-15");
            var sameOrBefore = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SameOrBefore>();
            var result = Run<bool?>(sameOrBefore, library);
            result.Should().BeTrue();
        }

        [TestMethod]
        public void TestOnOrBeforeWithRelativeQuantity()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-11 7 days or less before @2025-07-18");
            var sameOrBefore = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            var result = Run<bool?>(sameOrBefore, library);
            result.Should().BeTrue();

            library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-11 7 days or less before @2025-07-19");
            sameOrBefore = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            result = Run<bool?>(sameOrBefore, library);
            result.Should().BeFalse();
        }

        [TestMethod]
        public void TestBeforeExclusive()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-10 before @2025-07-11");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Before>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestBeforeInclusive()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-10 on or before @2025-07-10");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SameOrBefore>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAfterExclusive()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-12 after @2025-07-11");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<After>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAfterInclusive()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-11 on or after @2025-07-11");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SameOrAfter>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestBeforeWithQuantityOffset()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-10 1 day before @2025-07-11");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SameAs>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAfterWithQuantityOffset()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-12 1 day after @2025-07-11");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SameAs>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestBeforeWithMoreThan()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-09 more than 1 day before @2025-07-11");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Before>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAfterWithMoreThan()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-13 more than 1 day after @2025-07-11");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<After>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestBeforeWithLessThan()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-11 less than 2 days before @2025-07-12");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAfterWithLessThan()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-11 less than 2 days after @2025-07-10");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<In>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestBeforeWithOrLess()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-10 2 days or less before @2025-07-12");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestAfterWithOrLess()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("@2025-07-12 2 days or less after @2025-07-10");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            var result = Run<bool?>(expr, library);
            Assert.IsTrue(result);
        }

    }
}