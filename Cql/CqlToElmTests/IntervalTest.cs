using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    internal class IntervalTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.ValidateLiterals = false;
            co.AllowNullIntervals = true;
            co.LongsRequireSuffix = false; // promote test values of 2147483648 to longs so ExpressionBuilder doesn't throw
            co.EnableListPromotion = true;
            co.EnableListDemotion = true;
            co.EnableIntervalPromotion = true;
            co.EnableIntervalDemotion = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Interval_InvalidType()
        {
            MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private Interval_InvalidType: Interval[{},{}]
            ", "Could not resolve call to operator Interval*");
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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

                var lambda = LibraryExpressionBuilder.Lambda(interval);
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
        public void Interval_Includes_Null()
        {
            var library = MakeLibrary(@"
                library IntervalTest version '1.0.0'

                define private TestIncludesNull: Interval[1, 10] includes null
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


        [TestMethod]
        public void Interval_Properly_Included_in_Interval_Null()
        {
            var library = CreateLibraryForExpression("Interval[1, 10] properly included in Interval[null, null]");
            var pii = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ProperIncludedIn>();
            var result = Run(pii);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Interval_Null_Starts_Interval()
        {
            var library = CreateLibraryForExpression("Interval[null, null] starts Interval[1, 10]");
            var pii = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Starts>();
            var result = Run(pii);
            Assert.IsNull(result);
        }



    }
}
