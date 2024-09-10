using Cql.WithBuildTasks;
using FluentAssertions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTest
{
    [TestClass]
    public class ArithmeticTest
    {

        private static System_2_0_0 System200 = new SystemLibrary(FhirCqlContext.ForBundle());

        #region Abs

        [TestMethod]
        public void AbsNull() => System200.Abs(null as int?).Should().BeNull();

        [TestMethod]
        public void Abs0() => System200.Abs(0).Should().Be(0);

        [TestMethod]
        public void AbsNeg1() => System200.Abs(-1).Should().Be(1);

        [TestMethod]
        public void AbsNeg1Dec() => System200.Abs(-1m).Should().Be(1m);

        [TestMethod]
        public void Abs0Dec() => System200.Abs(0m).Should().Be(0m);

        [TestMethod]
        public void Abs1cm()
        {
            var result = System200.Abs(new CqlQuantity(-1.0m, "cm"));
            result.Should().NotBeNull();
            result.value.Should().Be(1.0m);
            result.unit.Should().Be("cm");
        }

        [TestMethod]
        public void AbsLong() => System200.Abs(-1L).Should().Be(1L);

        #endregion

        #region Add

        [TestMethod]
        public void AddNull() => System200.Add(1, null).Should().BeNull();

        [TestMethod]
        public void Add11() => System200.Add(1, 1).Should().Be(2);

        [TestMethod]
        public void Add1D1D() => System200.Add(1m, 1m).Should().Be(2m);

        [TestMethod]
        public void Add1Q1Q()
        {
            var result = System200.Add(new CqlQuantity(1, "g/cm3"), new CqlQuantity(1, "g/cm3"));
            result.Should().NotBeNull();
            result.value.Should().Be(2);
            result.unit.Should().Be("g/cm3");
        }

        [TestMethod]
        public void AddIAndD() => System200.Add(1, 2.0m).Should().Be(3m);

        [TestMethod]
        public void Add1L1L() => System200.Add(1L, 1L).Should().Be(2L);

        #endregion

        #region Ceiling

        [TestMethod]
        public void CeilingNull() => System200.Ceiling(null).Should().BeNull();

        [TestMethod]
        public void Ceiling1D() => System200.Ceiling(1m).Should().Be(1);
        [TestMethod]
        public void Ceiling1D1() => System200.Ceiling(1.1m).Should().Be(2);
        [TestMethod]
        public void CeilingNegD1() => System200.Ceiling(-0.1m).Should().Be(0);
        [TestMethod]
        public void CeilingNeg1() => System200.Ceiling(-1.0m).Should().Be(-1);
        [TestMethod]
        public void CeilingNeg1D1() => System200.Ceiling(-1.1m).Should().Be(-1);

        #endregion

        #region Divide

        [TestMethod]
        public void DivideNull() => System200.Divide(1, null).Should().BeNull();

        [TestMethod]
        public void Divide10() => System200.Divide(1, 0).Should().BeNull();

        [TestMethod]
        public void Divide01() => System200.Divide(0, 1).Should().Be(0);

        [TestMethod]
        public void Divide1d1d() => System200.Divide(1m, 1m).Should().Be(1);

        [TestMethod]
        public void Divide103() => System200.Round(System200.Divide(10, 3), 8).Should().Be(3.33333333m);

        [TestMethod]
        public void Divide1Q1Q()
        {
            var q = new CqlQuantity(1, "g/cm3");
            var result = System200.Divide(q, q);
            result.Should().NotBeNull();
            result.value.Should().Be(1m);
            result.unit.Should().Be("1");
        }

        #endregion

        #region Floor

        [TestMethod]
        public void FloorNull() => System200.Floor(null).Should().BeNull();

        [TestMethod]
        public void Floor1D() => System200.Floor(1m).Should().Be(1);

        [TestMethod]
        public void Floor1D1() => System200.Floor(1.1m).Should().Be(1);

        [TestMethod]
        public void FloorNegD1() => System200.Floor(-0.1m).Should().Be(-1);
        [TestMethod]
        public void FloorNeg1() => System200.Floor(-1.0m).Should().Be(-1);
        [TestMethod]
        public void FloorNeg1D1() => System200.Floor(-1.1m).Should().Be(-2);

        #endregion

        #region Exp

        [TestMethod]
        public void ExpNull() => System200.Exp(null).Should().BeNull();

        [TestMethod]
        public void Exp0() => System200.Exp(0m).Should().Be(1m);

        [TestMethod]
        public void Exp1() => System200.Round(System200.Exp(1m), 8).Should().Be(2.71828183m);

        [TestMethod]
        public void ExpNeg1() => System200.Round(System200.Exp(-1m), 8).Should().Be(0.36787944m);

        #endregion

        #region HighBoundary

        [TestMethod]
        public void HighBoundaryDecimal() => System200.HighBoundary(1.587m, 8).Should().Be(1.58799999m);

        [TestMethod]
        [TestCategory("Custom")]
        public void HighBoundaryDecimalNullPrecision() => System200.HighBoundary(1.587m, null).Should().Be(1.58799999m);

        [TestMethod]
        public void HighBoundaryDateMonth() =>
            System200.HighBoundary(new CqlDate(2014,null,null), 6).Should().Be(new CqlDate(2014, 12, null));

        [TestMethod]
        public void HighBoundaryDateTimeMillisecond() =>
            System200.HighBoundary(new CqlDateTime(2014,1,1,8,null,null,null,null,null), 17)
                .Should().Be(new CqlDateTime(2014, 1, 1, 8, 17, 59, 999, null, null));

        [TestMethod]
        public void HighBoundaryTimeMillisecond() =>
            System200.HighBoundary(new CqlTime(10, 30, null, null, null, null), 9).Should().Be(new CqlTime(10, 30, 59, 999, null, null));



        #endregion

        #region Precision

        [TestMethod]
        public void PrecisionDecimal() => System200.Precision(1.58700m).Should().Be(5);

        #endregion


        #region Power

        [TestMethod]
        public void PowerNullToNull() => System200.Power(null, null).Should().BeNull();

        [TestMethod]
        public void Power0To0() => System200.Power(0m, 0m).Should().Be(1m);


        [TestMethod]
        public void Power2To2() => System200.Power(2m, 2m).Should().Be(4m);

        [TestMethod]
        public void PowerNeg2To2() => System200.Power(-2m, 2m).Should().Be(4m);

        [TestMethod]
        public void Power2ToNeg2() => System200.Power(2m, -2m).Should().Be(0.25m);

        #endregion
    }
}