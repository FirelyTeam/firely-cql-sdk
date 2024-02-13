using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class IntervalTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Interval_InvalidType()
        {
            MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_InvalidType: Interval['hello','world']
            ", "Intervals can only be constructed for orderable types*");
        }

        [TestMethod]
        public void Interval_Quantity_Incompatible_Units()
        {
            MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_InvalidType: Interval[100 'a', 200 'kg']
            ", "Intervals of quantities must be of compatible units.");
        }

        [TestMethod]
        public void Interval_Integer()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_Integer: Interval[1,2]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<int?>));
                var cqlInterval = (CqlInterval<int?>)result;
                Assert.AreEqual(1, cqlInterval.low);
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(2, cqlInterval.high);
                Assert.IsTrue(cqlInterval.highClosed);
            }
        }

        [TestMethod]
        public void Interval_Integer_Null_High()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_Integer: Interval[1,null)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<int?>));
                var cqlInterval = (CqlInterval<int?>)result;
                Assert.AreEqual(1, cqlInterval.low);
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(null, cqlInterval.high);
                Assert.IsFalse(cqlInterval.highClosed);
            }
        }

        [TestMethod]
        public void Interval_Integer_Null_Low()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_Integer: Interval[null, 1)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<int?>));
                var cqlInterval = (CqlInterval<int?>)result;
                Assert.AreEqual(null, cqlInterval.low);
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(0, cqlInterval.high);
                Assert.IsTrue(cqlInterval.highClosed); // we close all intervals
            }
        }

        [TestMethod]
        public void Interval_Long()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_Long: Interval(-100L,20L]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<long?>));
                var cqlInterval = (CqlInterval<long?>)result;
                Assert.AreEqual(-99L, cqlInterval.low); // SDK always closes intervals upon creation
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(20L, cqlInterval.high);
                Assert.IsTrue(cqlInterval.highClosed);
            }
        }

        [TestMethod]
        public void Interval_Decimal()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_Decimal: Interval[-0.00000001, 0.0)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<decimal?>));
                var cqlInterval = (CqlInterval<decimal?>)result;
                Assert.AreEqual(-0.00000001m, cqlInterval.low); // SDK always closes intervals upon creation
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(-0.00000001m, cqlInterval.high);
                Assert.IsTrue(cqlInterval.highClosed);
            }
        }

        [TestMethod]
        public void Interval_Quantity()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_Decimal: Interval(100 '1', 200 '1')
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<CqlQuantity?>));
                var cqlInterval = (CqlInterval<CqlQuantity?>)result;
                Assert.AreEqual(100.00000001m, cqlInterval.low?.value); // SDK always closes intervals upon creation
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(199.99999999m, cqlInterval.high?.value);
                Assert.IsTrue(cqlInterval.highClosed);
            }
        }

        [TestMethod]
        public void Interval_Date()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_Date: Interval[@2023-01-01, @2023-12-31]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<CqlDate?>));
                var cqlInterval = (CqlInterval<CqlDate?>)result;
                Assert.AreEqual(new CqlDate(2023, 1, 1), cqlInterval.low);
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(new CqlDate(2023, 12, 31), cqlInterval.high);
                Assert.IsTrue(cqlInterval.highClosed);
            }
        }

        [TestMethod]
        public void Interval_DateTime()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_DateTime: Interval[@2023-01-01T00:00:00.000Z, @2023-12-31T23:59:59.999Z]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<CqlDateTime?>));
                var cqlInterval = (CqlInterval<CqlDateTime?>)result;
                Assert.AreEqual(new CqlDateTime(2023, 1, 1, 0, 0, 0, 0, 0, 0), cqlInterval.low);
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(new CqlDateTime(2023, 12, 31, 23, 59, 59, 999, 0, 0), cqlInterval.high);
                Assert.IsTrue(cqlInterval.highClosed);
            }
        }


        [TestMethod]
        public void Interval_Time()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_DateTime: Interval[@T00:00:00.000, @T23:59:59.999]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Interval));
            {
                var interval = (Interval)library.statements[0].expression;
                Assert.IsNull(interval.resultTypeName);
                Assert.IsNotNull(interval.resultTypeSpecifier);
                Assert.IsInstanceOfType(interval.resultTypeSpecifier, typeof(IntervalTypeSpecifier));
                var its = (IntervalTypeSpecifier)interval.resultTypeSpecifier;
                Assert.IsNotNull(its.pointType);
                Assert.IsInstanceOfType(its.pointType, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)its.pointType;
                Assert.IsNotNull(nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name?.Name);

                var lambda = ExpressionBuilder.Lambda(interval);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlInterval<CqlTime?>));
                var cqlInterval = (CqlInterval<CqlTime?>)result;
                Assert.AreEqual(new CqlTime(0, 0, 0, 0, default, default), cqlInterval.low);
                Assert.IsTrue(cqlInterval.lowClosed);
                Assert.AreEqual(new CqlTime(23, 59, 59, 999, default, default), cqlInterval.high);
                Assert.IsTrue(cqlInterval.highClosed);
            }
        }


        [TestMethod]
        public void Interval_Same_Or_After()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Issue32: Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00] starts 1 day or less on or after day of start of Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]
            ");
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
            var result = Run(and);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Interval_Includes_Null()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private TestIncludesNull: Interval[1, 10] includes null
            ", "Call to operator Includes(Interval<Integer>, Any) is ambiguous*");

            library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private TestIncludesNull: Interval[1, 10] includes null as Integer
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Contains));
            var includes = (Contains)library.statements[0].expression;
            var result = Run(includes);
            Assert.IsNull(result);

        }
    }
}
