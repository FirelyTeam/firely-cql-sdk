using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    [TestClass]
    public class OperatorTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Operators = CqlOperators.Create(FhirTypeResolver.Default, FhirTypeConverter.Default);
        }

        internal static CqlOperators Operators;


        [TestMethod]
        public void CqlInteger_Add()
        {
            CqlInteger x = 2;
            CqlInteger y = 3;

            var sum = Operators.Add(x, y);;
            Assert.IsNotNull(sum);
            Assert.IsFalse(sum.IsUncertain);
            Assert.AreEqual(5, sum.Value);
            Assert.IsNull(sum.Uncertainty);

            sum = x + y;
            Assert.IsNotNull(sum);
            Assert.IsFalse(sum.IsUncertain);
            Assert.AreEqual(5, sum.Value);
            Assert.IsNull(sum.Uncertainty);
        }

        [TestMethod]
        public void CqlInteger_Add_Uncertain()
        {
            CqlInteger x = 2;
            var y = new CqlInteger(3, 4);

            var sum = Operators.Add(x, y);
            Assert.IsNotNull(sum);
            Assert.IsTrue(sum.IsUncertain);
            Assert.IsNotNull(sum.Uncertainty);
            Assert.IsTrue(sum.Uncertainty.lowClosed);
            Assert.AreEqual(5, sum.Uncertainty.low);
            Assert.IsTrue(sum.Uncertainty.highClosed);
            Assert.AreEqual(6, sum.Uncertainty.high);

            sum = Operators.Add(y, x);
            Assert.IsNotNull(sum);
            Assert.IsTrue(sum.IsUncertain);
            Assert.IsNotNull(sum.Uncertainty);
            Assert.IsTrue(sum.Uncertainty.lowClosed);
            Assert.AreEqual(5, sum.Uncertainty.low);
            Assert.IsTrue(sum.Uncertainty.highClosed);
            Assert.AreEqual(6, sum.Uncertainty.high);
        }

        [TestMethod]
        public void CqlInteger_Add_Uncertain_Null_High()
        {
            CqlInteger x = 2;
            var y = new CqlInteger(3, null);

            var sum = Operators.Add(x, y);;
            Assert.IsNotNull(sum);
            Assert.IsTrue(sum.IsUncertain);
            Assert.IsNotNull(sum.Uncertainty);
            Assert.IsTrue(sum.Uncertainty.lowClosed);
            Assert.AreEqual(5, sum.Uncertainty.low);
            Assert.IsTrue(sum.Uncertainty.highClosed);
            Assert.IsNull(sum.Uncertainty.high);

            sum = Operators.Add(y,x);
            Assert.IsNotNull(sum);
            Assert.IsTrue(sum.IsUncertain);
            Assert.IsNotNull(sum.Uncertainty);
            Assert.IsTrue(sum.Uncertainty.lowClosed);
            Assert.AreEqual(5, sum.Uncertainty.low);
            Assert.IsTrue(sum.Uncertainty.highClosed);
            Assert.IsNull(sum.Uncertainty.high);
        }

        [TestMethod]
        public void CqlInteger_Add_Uncertain_Null_Low()
        {
            CqlInteger x = 2;
            var y = new CqlInteger(null, 4);

            var sum = Operators.Add(x, y);;
            Assert.IsNotNull(sum);
            Assert.IsTrue(sum.IsUncertain);
            Assert.IsNotNull(sum.Uncertainty);
            Assert.IsTrue(sum.Uncertainty.lowClosed);
            Assert.IsNull(sum.Uncertainty.low);
            Assert.IsTrue(sum.Uncertainty.highClosed);
            Assert.AreEqual(6, sum.Uncertainty.high);

            sum = Operators.Add(y,x);
            Assert.IsNotNull(sum);
            Assert.IsTrue(sum.IsUncertain);
            Assert.IsNotNull(sum.Uncertainty);
            Assert.IsTrue(sum.Uncertainty.lowClosed);
            Assert.IsNull(sum.Uncertainty.low);
            Assert.IsTrue(sum.Uncertainty.highClosed);
            Assert.AreEqual(6, sum.Uncertainty.high);
        }

        [TestMethod]
        public void CqlInteger_Add_Uncertain_Null_Both()
        {
            CqlInteger x = 2;
            var y = CqlInteger.PointNullUncertainty;

            var sum = Operators.Add(x, y);;
            Assert.IsNotNull(sum);
            Assert.IsFalse(sum.IsUncertain);
            Assert.IsNull(sum.Uncertainty);
            Assert.IsNull(sum.Value);

            sum = Operators.Add(y,x);
            Assert.IsNotNull(sum);
            Assert.IsFalse(sum.IsUncertain);
            Assert.IsNull(sum.Uncertainty);
            Assert.IsNull(sum.Value);
        }

        [TestMethod]
        public void CqlInteger_Add_Null_Operands()
        {
            CqlInteger x = 2;
            CqlInteger y = null;

            var sum = Operators.Add(x, y);;
            Assert.IsNull(sum);

            sum = Operators.Add(y, x);
            Assert.IsNull(sum);
        }

    }
}
