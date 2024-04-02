using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summary>
		///define "Null":
		///	( @2000 &lt; @2000-01 ) = null
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Null_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Null"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }

        /// <summary>
		///define "BooleanFalse":
		///	( false ) = (1~0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void BooleanFalse_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "BooleanFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "BooleanTrue":
		///	( true ) = (1~1)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void BooleanTrue_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "BooleanTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerZero":
		///	( 0 ) = 42-42
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerZero_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerZero"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerPosZero":
		///	( +0 ) = 42-42
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerPosZero_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerPosZero"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerNegZero":
		///	( -0 ) = 42-42
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerNegZero_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerNegZero"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerOne":
		///	( 1 ) = 42-41
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerOne_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerOne"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerPosOne":
		///	( +1 ) = 42-41
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerPosOne_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerPosOne"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerNegOne":
		///	( -1 ) = 42-43
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerNegOne_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerNegOne"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerTwo":
		///	( 2 ) = 42-40
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerTwo_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerTwo"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerPosTwo":
		///	( +2 ) = 42-40
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerPosTwo_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerPosTwo"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerNegTwo":
		///	( -2 ) = 42-44
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerNegTwo_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerNegTwo"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "Integer10Pow9":
		///	( 1000000000 ) = Power(10,9)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Integer10Pow9_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Integer10Pow9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerPos10Pow9":
		///	( +1000000000 ) = +Power(10,9)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerPos10Pow9_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerPos10Pow9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerNeg10Pow9":
		///	( -1000000000 ) = -Power(10,9)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerNeg10Pow9_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerNeg10Pow9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "Integer2Pow31ToZero1IntegerMaxValue":
		///	( 2147483647 ) = Power(2,30)-1+Power(2,30)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Integer2Pow31ToZero1IntegerMaxValue_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Integer2Pow31ToZero1IntegerMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerPos2Pow31ToZero1IntegerMaxValue":
		///	( +2147483647 ) = +Power(2,30)-1+Power(2,30)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerPos2Pow31ToZero1IntegerMaxValue_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerPos2Pow31ToZero1IntegerMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerNeg2Pow31ToZero1":
		///	( -2147483647 ) = -Power(2,30)+1-Power(2,30)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerNeg2Pow31ToZero1_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerNeg2Pow31ToZero1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "IntegerNeg2Pow31IntegerMinValue":
		///	( -2147483648 ) = -Power(2,30)-Power(2,30)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void IntegerNeg2Pow31IntegerMinValue_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "IntegerNeg2Pow31IntegerMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalZero":
		///	( 0.0 ) = 42.0-42.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalZero_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalZero"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPosZero":
		///	( +0.0 ) = 42.0-42.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPosZero_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPosZero"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNegZero":
		///	( -0.0 ) = 42.0-42.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNegZero_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNegZero"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalOne":
		///	( 1.0 ) = 42.0-41.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalOne_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalOne"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPosOne":
		///	( +1.0 ) = 42.0-41.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPosOne_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPosOne"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNegOne":
		///	( -1.0 ) = 42.0-43.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNegOne_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNegOne"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalTwo":
		///	( 2.0 ) = 42.0-40.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalTwo_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalTwo"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPosTwo":
		///	( +2.0 ) = 42.0-40.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPosTwo_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPosTwo"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNegTwo":
		///	( -2.0 ) = 42.0-44.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNegTwo_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNegTwo"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "Decimal10Pow9":
		///	( 1000000000.0 ) = Power(10.0,9.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Decimal10Pow9_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Decimal10Pow9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPos10Pow9":
		///	( +1000000000.0 ) = +Power(10.0,9.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPos10Pow9_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPos10Pow9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNeg10Pow9":
		///	( -1000000000.0 ) = -Power(10.0,9.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNeg10Pow9_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNeg10Pow9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "Decimal2Pow31ToZero1":
		///	( 2147483647.0 ) = Power(2.0,30.0)-1+Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Decimal2Pow31ToZero1_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Decimal2Pow31ToZero1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPos2Pow31ToZero1":
		///	( +2147483647.0 ) = +Power(2.0,30.0)-1+Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPos2Pow31ToZero1_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPos2Pow31ToZero1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNeg2Pow31ToZero1":
		///	( -2147483647.0 ) = -Power(2.0,30.0)+1.0-Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNeg2Pow31ToZero1_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNeg2Pow31ToZero1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "Decimal2Pow31":
		///	( 2147483648.0 ) = Power(2.0,30.0)+Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Decimal2Pow31_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Decimal2Pow31"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPos2Pow31":
		///	( +2147483648.0 ) = +Power(2.0,30.0)+Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPos2Pow31_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPos2Pow31"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNeg2Pow31":
		///	( -2147483648.0 ) = -Power(2.0,30.0)-Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNeg2Pow31_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNeg2Pow31"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "Decimal2Pow31ToInf1":
		///	( 2147483649.0 ) = Power(2.0,30.0)+1.0+Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Decimal2Pow31ToInf1_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Decimal2Pow31ToInf1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPos2Pow31ToInf1":
		///	( +2147483649.0 ) = +Power(2.0,30.0)+1.0+Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPos2Pow31ToInf1_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPos2Pow31ToInf1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNeg2Pow31ToInf1":
		///	( -2147483649.0 ) = -Power(2.0,30.0)-1.0-Power(2.0,30.0)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNeg2Pow31ToInf1_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNeg2Pow31ToInf1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalZeroStep":
		///	( 0.00000000 ) = 42.0-42.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalZeroStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalZeroStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPosZeroStep":
		///	( +0.00000000 ) = 42.0-42.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPosZeroStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPosZeroStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNegZeroStep":
		///	( -0.00000000 ) = 42.0-42.0
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNegZeroStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNegZeroStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalOneStep":
		///	( 0.00000001 ) = Power(10.0,-8)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalOneStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalOneStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPosOneStep":
		///	( +0.00000001 ) = +Power(10.0,-8)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPosOneStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPosOneStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNegOneStep":
		///	( -0.00000001 ) = -Power(10.0,-8)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNegOneStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNegOneStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalTwoStep":
		///	( 0.00000002 ) = 2.0*Power(10.0,-8)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalTwoStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalTwoStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPosTwoStep":
		///	( +0.00000002 ) = +2.0*Power(10.0,-8)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPosTwoStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPosTwoStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNegTwoStep":
		///	( -0.00000002 ) = -2.0*Power(10.0,-8)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNegTwoStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNegTwoStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalTenStep":
		///	( 0.0000001 ) = Power(10.0,-7)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalTenStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalTenStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPosTenStep":
		///	( +0.0000001 ) = +Power(10.0,-7)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPosTenStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPosTenStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNegTenStep":
		///	( -0.0000001 ) = -Power(10.0,-7)
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNegTenStep_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNegTenStep"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "Decimal10Pow28ToZeroOneStepDecimalMaxValue":
		///	( 9999999999999999999999999999.99999999 ) = 10*1000000000000000000000000000.00000000-0.00000001
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void Decimal10Pow28ToZeroOneStepDecimalMaxValue_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "Decimal10Pow28ToZeroOneStepDecimalMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue":
		///	( +9999999999999999999999999999.99999999 ) = +10*1000000000000000000000000000.00000000-0.00000001
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalPos10Pow28ToZeroOneStepDecimalMaxValue_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
		///define "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue":
		///	( -9999999999999999999999999999.99999999 ) = -10*1000000000000000000000000000.00000000+0.00000001
		/// </summary>
        [TestCategory("ValueLiteralsAndSelectors")]
        [TestMethod]
        public void DecimalNeg10Pow28ToZeroOneStepDecimalMinValue_Test()
        {
            var lambda = LambdasByTestName["ValueLiteralsAndSelectors", "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

    }
}

