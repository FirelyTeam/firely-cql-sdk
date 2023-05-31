using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests

{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "AbsNull":
		///	( Abs(null as Integer) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void AbsNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "AbsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Abs0":
		///	( Abs(0) ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Abs0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Abs0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AbsNeg1":
		///	( Abs(-1) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void AbsNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "AbsNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AbsNeg1Dec":
		///	( Abs(-1.0) ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void AbsNeg1Dec_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "AbsNeg1Dec"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Abs0Dec":
		///	( Abs(0.0) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Abs0Dec_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Abs0Dec"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Abs1cm":
		///	( Abs(-1.0'cm') ) = 1.0'cm'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Abs1cm_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Abs1cm"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AbsLong":
		///	( Abs(-1L) ) = 1L
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void AbsLong_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "AbsLong"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AddNull":
		///	( 1 + null ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void AddNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "AddNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Add11":
		///	( 1 + 1 ) = 2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Add11_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Add11"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Add1D1D":
		///	( 1.0 + 1.0 ) = 2.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Add1D1D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Add1D1D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Add1Q1Q":
		///	( 1'g/cm3' + 1'g/cm3' ) = 2.0'g/cm3'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Add1Q1Q_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Add1Q1Q"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AddIAndD":
		///	( 1 + 2.0 ) = 3.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void AddIAndD_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "AddIAndD"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Add1L1L":
		///	( 1L + 1L ) = 2L
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Add1L1L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Add1L1L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CeilingNull":
		///	( Ceiling(null as Decimal) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void CeilingNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "CeilingNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Ceiling1D":
		///	( Ceiling(1.0) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Ceiling1D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Ceiling1D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Ceiling1D1":
		///	( Ceiling(1.1) ) = 2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Ceiling1D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Ceiling1D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CeilingNegD1":
		///	( Ceiling(-0.1) ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void CeilingNegD1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "CeilingNegD1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CeilingNeg1":
		///	( Ceiling(-1.0) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void CeilingNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "CeilingNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CeilingNeg1D1":
		///	( Ceiling(-1.1) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void CeilingNeg1D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "CeilingNeg1D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Ceiling1I":
		///	( Ceiling(1) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Ceiling1I_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Ceiling1I"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DivideNull":
		///	( 1 / null ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void DivideNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "DivideNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Divide10":
		///	( 1 / 0 ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide10_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Divide01":
		///	( 0 / 1 ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide01_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide01"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide11":
		///	( 1 / 1 ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide11_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide11"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide1d1d":
		///	( 1.0 / 1.0 ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide1d1d_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide1d1d"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide103":
		///	( 10 / 3 ) = 3.33333333
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide103_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide103"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide1Q1":
		///	( 1'g/cm3' / 1.0 ) = 1.0'g/cm3'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide1Q1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide1Q1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide1Q1Q":
		///	( 1'g/cm3' / 1'g/cm3' ) = 1.0'1'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide1Q1Q_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide1Q1Q"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide10I5D":
		///	( 10 / 5.0 ) = 2.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide10I5D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide10I5D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide10I5I":
		///	( 10 / 5 ) = 2.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide10I5I_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide10I5I"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Divide10Q5I":
		///	( 10.0 'g' / 5 ) = 2.0'g'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Divide10Q5I_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Divide10Q5I"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FloorNull":
		///	( Floor(null as Decimal) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void FloorNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "FloorNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Floor1":
		///	( Floor(1) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Floor1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Floor1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Floor1D":
		///	( Floor(1.0) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Floor1D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Floor1D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Floor1D1":
		///	( Floor(1.1) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Floor1D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Floor1D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FloorNegD1":
		///	( Floor(-0.1) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void FloorNegD1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "FloorNegD1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FloorNeg1":
		///	( Floor(-1.0) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void FloorNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "FloorNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FloorNeg1D1":
		///	( Floor(-1.1) ) = -2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void FloorNeg1D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "FloorNeg1D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Floor2I":
		///	( Floor(2) ) = 2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Floor2I_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Floor2I"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExpNull":
		///	( Exp(null as Decimal) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void ExpNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "ExpNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Exp0":
		///	( Exp(0) ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Exp0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Exp0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExpNeg0":
		///	( Exp(-0) ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void ExpNeg0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "ExpNeg0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Exp1":
		///	( Exp(1) ) = 2.718281828459045090795598298427648842334747314453125
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Exp1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Exp1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExpNeg1":
		///	( Exp(-1) ) = 0.367879441171442334024277442949824035167694091796875
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void ExpNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "ExpNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "HighBoundaryDecimal":
		///	( HighBoundary(1.587, 8) ) = 1.58799999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void HighBoundaryDecimal_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "HighBoundaryDecimal"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "HighBoundaryDateMonth":
		///	( HighBoundary(@2014, 6) ) = @2014-12
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void HighBoundaryDateMonth_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "HighBoundaryDateMonth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "HighBoundaryDateTimeMillisecond":
		///	( HighBoundary(@2014-01-01T08, 17) ) = @2014-01-01T08:59:59.999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void HighBoundaryDateTimeMillisecond_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "HighBoundaryDateTimeMillisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "HighBoundaryTimeMillisecond":
		///	( HighBoundary(@T10:30, 9) ) = @T10:30:59.999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void HighBoundaryTimeMillisecond_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "HighBoundaryTimeMillisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LogNullNull":
		///	( Log(null, null) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LogNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LogNullNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Log1BaseNull":
		///	( Log(1, null) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Log1BaseNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Log1BaseNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Log1Base1":
		///	( Log(1, 1) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Log1Base1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Log1Base1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Log1Base2":
		///	( Log(1, 2) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Log1Base2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Log1Base2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Log1Base100":
		///	( Log(1, 100) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Log1Base100_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Log1Base100"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Log16Base2":
		///	( Log(16, 2) ) = 4.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Log16Base2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Log16Base2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LogD125Base2":
		///	( Log(0.125, 2) ) = -3.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LogD125Base2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LogD125Base2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowBoundaryDecimal":
		///	( LowBoundary(1.587, 8) ) = 1.58700000
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LowBoundaryDecimal_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LowBoundaryDecimal"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowBoundaryDateMonth":
		///	( LowBoundary(@2014, 6) ) = @2014-01
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LowBoundaryDateMonth_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LowBoundaryDateMonth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowBoundaryDateTimeMillisecond":
		///	( LowBoundary(@2014-01-01T08, 17) ) = @2014-01-01T08:00:00.000
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LowBoundaryDateTimeMillisecond_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LowBoundaryDateTimeMillisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowBoundaryTimeMillisecond":
		///	( LowBoundary(@T10:30, 9) ) = @T10:30:00.000
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LowBoundaryTimeMillisecond_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LowBoundaryTimeMillisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LnNull":
		///	( Ln(null) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LnNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LnNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Ln1":
		///	( Ln(1) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Ln1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Ln1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LnNeg1":
		///	( Ln(-1) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LnNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LnNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Ln1000":
		///	( Ln(1000) ) = 6.907755278982136815102421678602695465087890625
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Ln1000_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Ln1000"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Ln1000D":
		///	( Ln(1000.0) ) = 6.907755278982136815102421678602695465087890625
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Ln1000D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Ln1000D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IntegerMinValue":
		///	( minimum Integer ) = -2147483648
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void IntegerMinValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "IntegerMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LongMinValue":
		///	( minimum Long ) = -9223372036854775808
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LongMinValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LongMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DecimalMinValue":
		///	( minimum Decimal ) = -9999999999999999999999999999.99999999
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void DecimalMinValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "DecimalMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeMinValue":
		///	( minimum DateTime ) = @0001-01-01T00:00:00.000
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void DateTimeMinValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "DateTimeMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateMinValue":
		///	( minimum Date ) = @0001-01-01
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void DateMinValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "DateMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeMinValue":
		///	( minimum Time ) = @T00:00:00.000
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TimeMinValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TimeMinValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IntegerMaxValue":
		///	( maximum Integer ) = 2147483647
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void IntegerMaxValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "IntegerMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LongMaxValue":
		///	( maximum Long ) = 9223372036854775807
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void LongMaxValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "LongMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DecimalMaxValue":
		///	( maximum Decimal ) = 9999999999999999999999999999.99999999
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void DecimalMaxValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "DecimalMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeMaxValue":
		///	( maximum DateTime ) = @9999-12-31T23:59:59.999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void DateTimeMaxValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "DateTimeMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateMaxValue":
		///	( maximum Date ) = @9999-12-31
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void DateMaxValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "DateMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeMaxValue":
		///	( maximum Time ) = @T23:59:59.999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TimeMaxValue_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TimeMaxValue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ModuloNull":
		///	( 1 mod null ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void ModuloNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "ModuloNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Modulo0By0":
		///	( 0 mod 0 ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Modulo0By0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Modulo0By0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Modulo4By2":
		///	( 4 mod 2 ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Modulo4By2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Modulo4By2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Modulo4LBy2L":
		///	( 4L mod 2L ) = 0L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Modulo4LBy2L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Modulo4LBy2L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Modulo4DBy2D":
		///	( 4.0 mod 2.0 ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Modulo4DBy2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Modulo4DBy2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Modulo10By3":
		///	( 10 mod 3 ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Modulo10By3_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Modulo10By3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Modulo10DBy3D":
		///	( 10.0 mod 3.0 ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Modulo10DBy3D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Modulo10DBy3D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Modulo10IBy3D":
		///	( 10 mod 3.0 ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Modulo10IBy3D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Modulo10IBy3D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ModuloDResult":
		///	( 3.5 mod 3 ) = 0.5
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void ModuloDResult_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "ModuloDResult"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ModuloQuantity":
		///	( 3.5 'gm' mod 3 'gm' ) = 0.5 'gm'
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void ModuloQuantity_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "ModuloQuantity"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MultiplyNull":
		///	( 1 * null ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void MultiplyNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "MultiplyNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Multiply1By1":
		///	( 1 * 1 ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Multiply1By1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Multiply1By1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Multiply1DBy2D":
		///	( 1.0 * 2.0 ) = 2.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Multiply1DBy2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Multiply1DBy2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Multiply1By1L":
		///	( 1 * 1L ) = 1L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Multiply1By1L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Multiply1By1L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Multiply1IBy2D":
		///	( 1 * 2.0 ) = 2.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Multiply1IBy2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Multiply1IBy2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Multiply1CMBy2CM":
		///	( 1.0 'cm' * 2.0 'cm' ) = 2.0'cm2'
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Multiply1CMBy2CM_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Multiply1CMBy2CM"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NegateNull":
		///	( -(null as Integer) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void NegateNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "NegateNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Negate0":
		///	( -0 ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Negate0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Negate0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NegateNeg0":
		///	( -(-0) ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void NegateNeg0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "NegateNeg0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Negate1":
		///	( -1 ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Negate1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Negate1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NegateNeg1":
		///	( -(-1) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void NegateNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "NegateNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NegateNeg1L":
		///	( -(-1L) ) = 1L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void NegateNeg1L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "NegateNeg1L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Negate0D":
		///	( -(0.0) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Negate0D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Negate0D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NegateNeg0D":
		///	( -(-0.0) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void NegateNeg0D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "NegateNeg0D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Negate1D":
		///	( -(1.0) ) = -1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Negate1D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Negate1D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NegateNeg1D":
		///	( -(-1.0) ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void NegateNeg1D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "NegateNeg1D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Negate1CM":
		///	( -(1'cm') ) = -1.0'cm'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Negate1CM_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Negate1CM"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PrecisionDecimal":
		///	( Precision(1.58700) ) = 5
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PrecisionDecimal_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PrecisionDecimal"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PrecisionYear":
		///	( Precision(@2014) ) = 4
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PrecisionYear_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PrecisionYear"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PrecisionDateTimeMilliseconds":
		///	( Precision(@2014-01-05T10:30:00.000) ) = 17
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PrecisionDateTimeMilliseconds_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PrecisionDateTimeMilliseconds"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PrecisionTimeMinutes":
		///	( Precision(@T10:30) ) = 4
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PrecisionTimeMinutes_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PrecisionTimeMinutes"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PrecisionTimeMilliseconds":
		///	( Precision(@T10:30:00.000) ) = 9
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PrecisionTimeMilliseconds_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PrecisionTimeMilliseconds"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorNull":
		///	( predecessor of (null as Integer) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOf0":
		///	( predecessor of 0 ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOf0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOf0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOf1":
		///	( predecessor of 1 ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOf1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOf1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOf1L":
		///	( predecessor of 1L ) = 0L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOf1L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOf1L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOf1D":
		///	( predecessor of 1.0 ) = 0.99999999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOf1D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOf1D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOf101D":
		///	( predecessor of 1.01 ) = 1.00999999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOf101D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOf101D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOf1QCM":
		///	( predecessor of 1.0 'cm' ) = 0.99999999'cm'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOf1QCM_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOf1QCM"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOfJan12000":
		///	( predecessor of DateTime(2000,1,1) ) = @1999-12-31
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOfJan12000_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOfJan12000"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PredecessorOfNoon":
		///	( predecessor of @T12:00:00.000 ) = @T11:59:59.999
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PredecessorOfNoon_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PredecessorOfNoon"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PowerNullToNull":
		///	( Power(null as Integer, null as Integer) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PowerNullToNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PowerNullToNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Power0To0":
		///	( Power(0, 0) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power0To0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power0To0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2To2":
		///	( Power(2, 2) ) = 4
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2To2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2To2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PowerNeg2To2":
		///	( Power(-2, 2) ) = 4
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PowerNeg2To2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PowerNeg2To2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2ToNeg2":
		///	( Power(2.0, -2.0) ) = 0.25
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2ToNeg2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2ToNeg2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2LTo2L":
		///	( Power(2L, 2L) ) = 4L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2LTo2L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2LTo2L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2DTo2D":
		///	( Power(2.0, 2.0) ) = 4.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2DTo2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2DTo2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PowerNeg2DTo2D":
		///	( Power(-2.0, 2.0) ) = 4.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void PowerNeg2DTo2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "PowerNeg2DTo2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2DToNeg2D":
		///	( Power(2.0, -2.0) ) = 0.25
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2DToNeg2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2DToNeg2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2DTo2":
		///	( Power(2.0, 2) ) = 4.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2DTo2_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2DTo2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2To2D":
		///	( Power(2, 2.0) ) = 4.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2To2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2To2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2To4":
		///	( 2^4 ) = 16
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2To4_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2To4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2DTo4D":
		///	( 2.0^4.0 ) = 16.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2DTo4D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2DTo4D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Power2DToNeg2DEquivalence":
		///	( Power(2.0, -2.0) ~ 0.25 ) = true
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Power2DToNeg2DEquivalence_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Power2DToNeg2DEquivalence"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RoundNull":
		///	( Round(null as Decimal) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void RoundNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "RoundNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Round1":
		///	( Round(1) ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Round1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Round1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Round0D5":
		///	( Round(0.5) ) = 1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Round0D5_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Round0D5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Round0D4":
		///	( Round(0.4) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Round0D4_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Round0D4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Round3D14159":
		///	( Round(3.14159, 2) ) = 3.14
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Round3D14159_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Round3D14159"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RoundNeg0D5":
		///	( Round(-0.5) ) = 0.0
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void RoundNeg0D5_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "RoundNeg0D5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RoundNeg0D4":
		///	( Round(-0.4) ) = 0.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void RoundNeg0D4_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "RoundNeg0D4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RoundNeg0D6":
		///	( Round(-0.6) ) = -1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void RoundNeg0D6_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "RoundNeg0D6"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RoundNeg1D1":
		///	( Round(-1.1) ) = -1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void RoundNeg1D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "RoundNeg1D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RoundNeg1D5":
		///	( Round(-1.5) ) = -1.0
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void RoundNeg1D5_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "RoundNeg1D5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RoundNeg1D6":
		///	( Round(-1.6) ) = -2.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void RoundNeg1D6_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "RoundNeg1D6"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SubtractNull":
		///	( 1 - null ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SubtractNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SubtractNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Subtract1And1":
		///	( 1 - 1 ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Subtract1And1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Subtract1And1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Subtract1LAnd1L":
		///	( 1L - 1L ) = 0L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Subtract1LAnd1L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Subtract1LAnd1L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Subtract1DAnd2D":
		///	( 1.0 - 2.0 ) = -1.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Subtract1DAnd2D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Subtract1DAnd2D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Subtract1CMAnd2CM":
		///	( 1.0 'cm' - 2.0 'cm' ) = -1.0'cm'
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Subtract1CMAnd2CM_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Subtract1CMAnd2CM"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Subtract2And11D":
		///	( 2 - 1.1 ) = 0.9
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Subtract2And11D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Subtract2And11D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SuccessorNull":
		///	( successor of (null as Integer) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SuccessorOf0":
		///	( successor of 0 ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorOf0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorOf0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SuccessorOf1":
		///	( successor of 1 ) = 2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorOf1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorOf1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SuccessorOf1L":
		///	( successor of 1L ) = 2L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorOf1L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorOf1L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SuccessorOf1D":
		///	( successor of 1.0 ) = 1.00000001
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorOf1D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorOf1D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SuccessorOf101D":
		///	( successor of 1.01 ) = 1.01000001
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorOf101D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorOf101D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SuccessorOfJan12000":
		///	( successor of DateTime(2000,1,1) ) = @2000-01-02
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorOfJan12000_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorOfJan12000"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SuccessorOfNoon":
		///	( successor of @T12:00:00.000 ) = @T12:00:00.001
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void SuccessorOfNoon_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "SuccessorOfNoon"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncateNull":
		///	( Truncate(null as Decimal) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncateNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncateNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Truncate0":
		///	( Truncate(0) ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Truncate0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Truncate0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Truncate0D0":
		///	( Truncate(0.0) ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Truncate0D0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Truncate0D0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Truncate0D1":
		///	( Truncate(0.1) ) = 0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Truncate0D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Truncate0D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Truncate1":
		///	( Truncate(1) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Truncate1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Truncate1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Truncate1D0":
		///	( Truncate(1.0) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Truncate1D0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Truncate1D0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Truncate1D1":
		///	( Truncate(1.1) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Truncate1D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Truncate1D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Truncate1D9":
		///	( Truncate(1.9) ) = 1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void Truncate1D9_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "Truncate1D9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncateNeg1":
		///	( Truncate(-1) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncateNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncateNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncateNeg1D0":
		///	( Truncate(-1.0) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncateNeg1D0_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncateNeg1D0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncateNeg1D1":
		///	( Truncate(-1.1) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncateNeg1D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncateNeg1D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncateNeg1D9":
		///	( Truncate(-1.9) ) = -1
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncateNeg1D9_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncateNeg1D9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivideNull":
		///	( (null as Integer) div (null as Integer) ) = null
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivideNull_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivideNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide2By1":
		///	( 2 div 1 ) = 2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide2By1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide2By1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide10By3":
		///	( 10 div 3 ) = 3
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide10By3_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide10By3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide10LBy3L":
		///	( 10L div 3L ) = 3L
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide10LBy3L_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide10LBy3L"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide10d1By3D1":
		///	( 10.1 div 3.1 ) = 3.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide10d1By3D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide10d1By3D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivideNeg2ByNeg1":
		///	( -2 div -1 ) = 2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivideNeg2ByNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivideNeg2ByNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivideNeg10ByNeg3":
		///	( -10 div -3 ) = 3
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivideNeg10ByNeg3_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivideNeg10ByNeg3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivideNeg10d1ByNeg3D1":
		///	( -10.1 div -3.1 ) = 3.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivideNeg10d1ByNeg3D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivideNeg10d1ByNeg3D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivideNeg2By1":
		///	( -2 div 1 ) = -2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivideNeg2By1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivideNeg2By1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivideNeg10By3":
		///	( -10 div 3 ) = -3
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivideNeg10By3_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivideNeg10By3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivideNeg10d1By3D1":
		///	( -10.1 div 3.1 ) = -3.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivideNeg10d1By3D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivideNeg10d1By3D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide2ByNeg1":
		///	( 2 div -1 ) = -2
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide2ByNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide2ByNeg1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide10ByNeg3":
		///	( 10 div -3 ) = -3
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide10ByNeg3_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide10ByNeg3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide10d1ByNeg3D1":
		///	( 10.1 div -3.1 ) = -3.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide10d1ByNeg3D1_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide10d1ByNeg3D1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide10By5D":
		///	( 10 div 5.0 ) = 2.0
		/// </summary>
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide10By5D_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide10By5D"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TruncatedDivide10d1ByNeg3D1Quantity":
		///	( 10.1 'gm' div -3.1 'gm' ) = -3.0 'gm'
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlArithmeticFunctionsTest")]
        [TestMethod]
        public void TruncatedDivide10d1ByNeg3D1Quantity_Test()
        {
            var lambda = LambdasByTestName["CqlArithmeticFunctionsTest", "TruncatedDivide10d1ByNeg3D1Quantity"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
