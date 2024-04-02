using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summary>
		///define "TestAfterNull":
		///	( null as Interval&lt;Integer> after Interval[1, 10] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestAfterNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestAfterNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalAfterTrue":
		///	( Interval[11, 20] after Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalAfterFalse":
		///	( Interval[1, 10] after Interval[11, 20] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalPointAfterTrue":
		///	( 12 after Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalPointAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalPointAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalPointAfterFalse":
		///	( 9 after Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalPointAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalPointAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalAfterPointTrue":
		///	( Interval[11, 20] after 5 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalAfterPointTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalAfterPointTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalAfterPointFalse":
		///	( Interval[11, 20] after 12 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalAfterPointFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalAfterPointFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalAfterTrue":
		///	( Interval[11.0, 20.0] after Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalAfterFalse":
		///	( Interval[1.0, 10.0] after Interval[11.0, 20.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalPointAfterTrue":
		///	( 12.0 after Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalPointAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalPointAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalPointAfterFalse":
		///	( 9.0 after Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalPointAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalPointAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalAfterPointTrue":
		///	( Interval[11.0, 20.0] after 5.0 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalAfterPointTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalAfterPointTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalAfterPointFalse":
		///	( Interval[11.0, 20.0] after 12.0 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalAfterPointFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalAfterPointFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalAfterTrue":
		///	( Interval[11.0 'g', 20.0 'g'] after Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalAfterFalse":
		///	( Interval[1.0 'g', 10.0 'g'] after Interval[11.0 'g', 20.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalPointAfterTrue":
		///	( 12.0'g' after Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalPointAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalPointAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalPointAfterFalse":
		///	( 9.0'g' after Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalPointAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalPointAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalAfterPointTrue":
		///	( Interval[11.0 'g', 20.0 'g'] after 5.0'g' ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalAfterPointTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalAfterPointTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalAfterPointFalse":
		///	( Interval[11.0 'g', 20.0 'g'] after 12.0'g' ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalAfterPointFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalAfterPointFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeAfterTrue":
		///	( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] after DateTime(2011, 12, 31) ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeAfterFalse":
		///	( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] after DateTime(2012, 12, 31) ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeAfterTrue":
		///	( Interval[@T15:59:59.999, @T20:59:59.999] after @T12:59:59.999 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeAfterFalse":
		///	( Interval[@T15:59:59.999, @T20:59:59.999] after @T17:59:59.999 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TestBeforeNull":
        ///	( null as Interval&lt;Integer> before Interval[1, 10] ) = null
        /// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestBeforeNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestBeforeNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalBeforeFalse":
		///	( Interval[11, 20] before Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalBeforeTrue":
		///	( Interval[1, 10] before Interval[11, 20] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalPointBeforeTrue":
		///	( 9 before Interval[11, 20] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalPointBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalPointBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalPointBeforeFalse":
		///	( 9 before Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalPointBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalPointBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalBeforePointTrue":
		///	( Interval[1, 10] before 11 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalBeforePointTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalBeforePointTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalBeforePointFalse":
		///	( Interval[1, 10] before 8 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalBeforePointFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalBeforePointFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalBeforeFalse":
		///	( Interval[11.0, 20.0] before Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalBeforeTrue":
		///	( Interval[1.0, 10.0] before Interval[11.0, 20.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalPointBeforeTrue":
		///	( 9.0 before Interval[11.0, 20.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalPointBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalPointBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalPointBeforeFalse":
		///	( 9.0 before Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalPointBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalPointBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalBeforePointTrue":
		///	( Interval[1.0, 10.0] before 11.0 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalBeforePointTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalBeforePointTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalBeforePointFalse":
		///	( Interval[1.0, 10.0] before 8.0 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalBeforePointFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalBeforePointFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalBeforeTrue":
		///	( Interval[1.0 'g', 10.0 'g'] before Interval[11.0 'g', 20.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalBeforeFalse":
		///	( Interval[11.0 'g', 20.0 'g'] before Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalPointBeforeTrue":
		///	( Interval[1.0 'g', 10.0 'g'] before 12.0'g' ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalPointBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalPointBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalPointBeforeFalse":
		///	( Interval[1.0 'g', 10.0 'g'] before 9.0'g' ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalPointBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalPointBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalBeforePointTrue":
		///	( 5.0'g' before Interval[11.0 'g', 20.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalBeforePointTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalBeforePointTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalBeforePointFalse":
		///	( 12.0'g' before Interval[11.0 'g', 20.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalBeforePointFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalBeforePointFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeBeforeTrue":
		///	( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] before DateTime(2012, 2, 27) ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeBeforeFalse":
		///	( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] before DateTime(2011, 12, 31) ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeBeforeTrue":
		///	( Interval[@T15:59:59.999, @T20:59:59.999] before @T22:59:59.999 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeBeforeFalse":
		///	( Interval[@T15:59:59.999, @T20:59:59.999] before @T10:59:59.999 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TestCollapseNull":
        ///	( collapse {Interval(null as Integer, null as Integer)} ) = null as List&lt;Interval&lt;Integer>>
        /// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestCollapseNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestCollapseNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalCollapse":
		///	( collapse { Interval[1,5], Interval[3,7], Interval[12,19], Interval[7,10] } ) = {Interval [ 1, 10 ], Interval [ 12, 19 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalCollapse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalCollapse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalCollapse2":
		///	( collapse { Interval[1,2], Interval[3,7], Interval[10,19], Interval[7,10] } ) = {Interval [ 1, 19 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalCollapse2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalCollapse2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalCollapse3":
		///	( collapse { Interval[4,6], Interval[7,8] } ) = {Interval [ 4, 8 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalCollapse3_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalCollapse3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalCollapse":
		///	( collapse { Interval[1.0,5.0], Interval[3.0,7.0], Interval[12.0,19.0], Interval[7.0,10.0] } ) = {Interval [ 1.0, 10.0 ], Interval [ 12.0, 19.0 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalCollapse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalCollapse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalCollapse2":
		///	( collapse { Interval[4.0,6.0], Interval[6.00000001,8.0] } ) = {Interval [ 4.0, 8.0 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalCollapse2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalCollapse2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalCollapse":
		///	( collapse { Interval[1.0 'g',5.0 'g'], Interval[3.0 'g',7.0 'g'], Interval[12.0 'g',19.0 'g'], Interval[7.0 'g',10.0 'g'] } ) = {Interval [ 1.0 'g', 10.0 'g' ], Interval [ 12.0 'g', 19.0 'g' ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalCollapse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalCollapse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeCollapse":
		///	( collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 10), DateTime(2012, 1, 25)], Interval[DateTime(2012, 5, 10), DateTime(2012, 5, 25)], Interval[DateTime(2012, 5, 20), DateTime(2012, 5, 30)] } ) = {Interval [ @2012-01-01, @2012-01-25 ], Interval [ @2012-05-10, @2012-05-30 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeCollapse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeCollapse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeCollapse2":
		///	( collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 16), DateTime(2012, 5, 25)] } ) = {Interval [ @2012-01-01, @2012-05-25 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeCollapse2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeCollapse2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeCollapse":
		///	( collapse { Interval[@T01:59:59.999, @T10:59:59.999], Interval[@T08:59:59.999, @T15:59:59.999], Interval[@T17:59:59.999, @T20:59:59.999], Interval[@T18:59:59.999, @T22:59:59.999] } ) = {Interval [ @T01:59:59.999, @T15:59:59.999 ], Interval [ @T17:59:59.999, @T22:59:59.999 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeCollapse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeCollapse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeCollapse2":
		///	( collapse { Interval[@T01:59:59.999, @T10:59:59.999], Interval[@T11:00:00.000, @T15:59:59.999] } ) = {Interval [ @T01:59:59.999, @T15:59:59.999 ]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeCollapse2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeCollapse2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExpandPerDay":
		///	( expand { Interval[@2018-01-01, @2018-01-04] } per day ) = { Interval[@2018-01-01, @2018-01-01], Interval[@2018-01-02, @2018-01-02], Interval[@2018-01-03, @2018-01-03], Interval[@2018-01-04, @2018-01-04] }
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExpandPerDay_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExpandPerDay"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExpandPer2Days":
		///	( expand { Interval[@2018-01-01, @2018-01-04] } per 2 days ) = { Interval[@2018-01-01, @2018-01-02], Interval[@2018-01-03, @2018-01-04] }
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExpandPer2Days_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExpandPer2Days"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExpandPerHour":
		///	( expand { Interval[@T10:00, @T12:30] } per hour ) = { Interval[@T10, @T10], Interval[@T11, @T11], Interval[@T12, @T12] }
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExpandPerHour_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExpandPerHour"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExpandPerMinute":
		///	( expand { Interval[@T10, @T10] } per minute ) = { }
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExpandPerMinute_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExpandPerMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestContainsNull":
		///	( Interval[1, 10] contains null ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestContainsNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestContainsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TestNullElement1":
		///	( null contains 5 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestNullElement1_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestNullElement1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestNullElement2":
		///	( Interval[null, 5] contains 10 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestNullElement2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestNullElement2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalContainsTrue":
		///	( Interval[1, 10] contains 5 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalContainsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalContainsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalContainsFalse":
		///	( Interval[1, 10] contains 25 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalContainsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalContainsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalContainsTrue":
		///	( Interval[1.0, 10.0] contains 8.0 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalContainsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalContainsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalContainsFalse":
		///	( Interval[1.0, 10.0] contains 255.0 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalContainsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalContainsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalContainsTrue":
		///	( Interval[1.0 'g', 10.0 'g'] contains 2.0 'g' ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalContainsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalContainsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalContainsFalse":
		///	( Interval[1.0 'g', 10.0 'g'] contains 100.0 'g' ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalContainsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalContainsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeContainsTrue":
		///	( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] contains DateTime(2012, 1, 10) ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeContainsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeContainsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeContainsFalse":
		///	( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] contains DateTime(2012, 1, 16) ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeContainsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeContainsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeContainsTrue":
		///	( Interval[@T01:59:59.999, @T10:59:59.999] contains @T05:59:59.999 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeContainsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeContainsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeContainsFalse":
		///	( Interval[@T01:59:59.999, @T10:59:59.999] contains @T15:59:59.999 ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeContainsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeContainsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalEnd":
		///	( end of Interval[1, 10] ) = 10
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalEnd_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalEnd"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalEnd":
		///	( end of Interval[1.0, 10.0] ) = 10.0
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalEnd_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalEnd"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalEnd":
		///	( end of Interval[1.0 'g', 10.0 'g'] ) = 10.0'g'
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalEnd_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalEnd"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIntervalEnd":
		///	( end of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000] ) = @2016-05-02T00:00:00.000
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIntervalEnd_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIntervalEnd"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIntervalEnd":
		///	( end of Interval[@T00:00:00.000, @T23:59:59.599] ) = @T23:59:59.599
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIntervalEnd_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIntervalEnd"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestEndsNull":
		///	( Interval[1, 10] ends Interval(null, null) ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestEndsNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestEndsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalEndsTrue":
		///	( Interval[4, 10] ends Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalEndsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalEndsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalEndsFalse":
		///	( Interval[44, 50] ends Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalEndsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalEndsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalEndsTrue":
		///	( Interval[4.0, 10.0] ends Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalEndsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalEndsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalEndsFalse":
		///	( Interval[11.0, 20.0] ends Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalEndsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalEndsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalEndsTrue":
		///	( Interval[5.0 'g', 10.0 'g'] ends Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalEndsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalEndsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalEndsFalse":
		///	( Interval[11.0 'g', 20.0 'g'] ends Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalEndsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalEndsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeEndsTrue":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeEndsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeEndsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeEndsFalse":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 16)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeEndsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeEndsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeEndsTrue":
		///	( Interval[@T05:59:59.999, @T10:59:59.999] ends Interval[@T01:59:59.999, @T10:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeEndsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeEndsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeEndsFalse":
		///	( Interval[@T05:59:59.999, @T10:59:59.999] ends Interval[@T01:59:59.999, @T11:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeEndsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeEndsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestEqualNull":
		///	( Interval[1, 10] = Interval(null, null) ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestEqualNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestEqualNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalEqualTrue":
		///	( Interval[1, 10] = Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalEqualFalse":
		///	( Interval[1, 10] = Interval[11, 20] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalEqualTrue":
		///	( Interval[1.0, 10.0] = Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalEqualFalse":
		///	( Interval[1.0, 10.0] = Interval[11.0, 20.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalEqualTrue":
		///	( Interval[1.0 'g', 10.0 'g'] = Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalEqualFalse":
		///	( Interval[1.0 'g', 10.0 'g'] = Interval[11.0 'g', 20.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeEqualTrue":
		///	( Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)] = Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeEqualFalse":
		///	( Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)] = Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 16, 0, 0, 0, 0)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeEqualTrue":
		///	( Interval[@T05:59:59.999, @T10:59:59.999] = Interval[@T05:59:59.999, @T10:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeEqualFalse":
		///	( Interval[@T05:59:59.999, @T10:59:59.999] = Interval[@T05:59:59.999, @T10:58:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "NullInterval":
        ///	( Interval[null as Integer, null as Integer] ) = null as Interval&lt;Integer>
        /// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void NullInterval_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "NullInterval"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }

        /// <summary>
        ///define "TestExceptNull":
        ///	( Interval[null as Integer, null as Integer] except Interval[null as Integer, null as Integer] ) = null as Interval&lt;Integer>
        /// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestExceptNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestExceptNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalExcept1to3":
		///	( Interval[1, 10] except Interval[4, 10] ) = Interval [ 1, 3 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalExcept1to3_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalExcept1to3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalExceptNull":
		///	( Interval[1, 10] except Interval[3, 7] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalExceptNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalExceptNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalExcept1to3":
		///	( Interval[1.0, 10.0] except Interval[4.0, 10.0] ) = Interval [ 1.0, 3.99999999 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalExcept1to3_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalExcept1to3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalExceptNull":
		///	( Interval[1.0, 10.0] except Interval[3.0, 7.0] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalExceptNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalExceptNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalExcept1to4":
		///	( Interval[1.0 'g', 10.0 'g'] except Interval[5.0 'g', 10.0 'g'] ) = Interval [ 1.0 'g', 4.99999999 'g' ]
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalExcept1to4_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalExcept1to4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "Except12":
		///	( Interval[1, 4] except Interval[3, 6] ) = Interval [ 1, 2 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void Except12_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "Except12"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExceptDateTimeInterval":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] except Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)] ) = Interval [ @2012-01-05, @2012-01-06 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExceptDateTimeInterval_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExceptDateTimeInterval"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExceptDateTime2":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 16)] except Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 12)] ) = Interval [ @2012-01-13, @2012-01-16 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExceptDateTime2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExceptDateTime2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExceptTimeInterval":
		///	( Interval[@T05:59:59.999, @T10:59:59.999] except Interval[@T08:59:59.999, @T10:59:59.999] ) = Interval [ @T05:59:59.999, @T08:59:59.998 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExceptTimeInterval_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExceptTimeInterval"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ExceptTime2":
		///	( Interval[@T08:59:59.999, @T11:59:59.999] except Interval[@T05:59:59.999, @T10:59:59.999] ) = Interval [ @T11:00:00.000, @T11:59:59.999 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void ExceptTime2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "ExceptTime2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestInNull":
		///	( 5 in Interval[null as Integer, null as Integer] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void TestInNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestInNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalInTrue":
		///	( 5 in Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalInFalse":
		///	( 500 in Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalInTrue":
		///	( 9.0 in Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalInFalse":
		///	( -2.0 in Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalInTrue":
		///	( 1.0 'g' in Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalInFalse":
		///	( 55.0 'g' in Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeInTrue":
		///	( DateTime(2012, 1, 7) in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeInFalse":
		///	( DateTime(2012, 1, 17) in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeInNullTrue":
		///	( DateTime(2012, 1, 7) in Interval[DateTime(2012, 1, 5), null] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeInNullTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeInNullTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeInTrue":
		///	( @T07:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeInFalse":
		///	( @T17:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeInNull":
		///	( null in Interval[@T05:59:59.999, @T10:59:59.999] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeInNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeInNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TestPeriod1":
		///	( Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00] ) = Interval [ @2017-12-20T11:00:00, @2017-12-21T21:00:00 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestPeriod1_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestPeriod1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestPeriod2":
		///	( Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00] ) = Interval [ @2017-12-20T10:30:00, @2017-12-20T12:00:00 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestPeriod2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestPeriod2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "Issue32Interval":
		///	( 
		///				Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]
		///				starts 1 day or less on or after day of start of
		///				Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]
		///			 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void Issue32Interval_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "Issue32Interval"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestIncludesNull":
		///	( Interval[1, 10] includes null ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestIncludesNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestIncludesNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalIncludesTrue":
		///	( Interval[1, 10] includes Interval[4, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalIncludesFalse":
		///	( Interval[1, 10] includes Interval[44, 50] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalIncludesTrue":
		///	( Interval[1.0, 10.0] includes Interval[4.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalIncludesFalse":
		///	( Interval[1.0, 10.0] includes Interval[11.0, 20.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalIncludesTrue":
		///	( Interval[1.0 'g', 10.0 'g'] includes Interval[5.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalIncludesFalse":
		///	( Interval[1.0 'g', 10.0 'g'] includes Interval[11.0 'g', 20.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncludesTrue":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] includes Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncludesFalse":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] includes Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIncludesTrue":
		///	( Interval[@T05:59:59.999, @T10:59:59.999] includes Interval[@T06:59:59.999, @T09:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIncludesFalse":
		///	( Interval[@T05:59:59.999, @T10:59:59.999] includes Interval[@T04:59:59.999, @T09:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestIncludedInNull":
		///	( null included in Interval[1, 10] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestIncludedInNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestIncludedInNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalIncludedInTrue":
		///	( Interval[4, 10] included in Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalIncludedInFalse":
		///	( Interval[44, 50] included in Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalIncludedInTrue":
		///	( Interval[4.0, 10.0] included in Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalIncludedInFalse":
		///	( Interval[11.0, 20.0] included in Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalIncludedInTrue":
		///	( Interval[5.0 'g', 10.0 'g'] included in Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalIncludedInFalse":
		///	( Interval[11.0 'g', 20.0 'g'] included in Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncludedInTrue":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncludedInFalse":
		///	( Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)] included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIncludedInTrue":
		///	( Interval[@T06:59:59.999, @T09:59:59.999] included in Interval[@T05:59:59.999, @T10:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIncludedInFalse":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] included in Interval[@T05:59:59.999, @T10:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncludedInNull":
		///	( Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIncludedInNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIncludedInNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncludedInPrecisionTrue":
		///	( Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in day of Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIncludedInPrecisionTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIncludedInPrecisionTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncludedInPrecisionNull":
		///	( Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in millisecond of Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIncludedInPrecisionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIncludedInPrecisionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TestIntersectNull":
		///	( Interval[1, 10] intersect Interval[5, null) ) = null
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestIntersectNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestIntersectNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalIntersectTest4to10":
		///	( Interval[1, 10] intersect Interval[4, 10] ) = Interval [ 4, 10 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalIntersectTest4to10_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalIntersectTest4to10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalIntersectTestNull":
		///	( Interval[1, 10] intersect Interval[11, 20] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalIntersectTestNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalIntersectTestNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalIntersectTest4to10":
		///	( Interval[1.0, 10.0] intersect Interval[4.0, 10.0] ) = Interval [ 4.0, 10.0 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalIntersectTest4to10_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalIntersectTest4to10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalIntersectTestNull":
		///	( Interval[1.0, 10.0] intersect Interval[11.0, 20.0] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalIntersectTestNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalIntersectTestNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalIntersectTest5to10":
		///	( Interval[1.0 'g', 10.0 'g'] intersect Interval[5.0 'g', 10.0 'g'] ) = Interval [ 5.0 'g', 10.0 'g' ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalIntersectTest5to10_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalIntersectTest5to10"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalIntersectTestNull":
		///	( Interval[1.0 'g', 10.0 'g'] intersect Interval[11.0 'g', 20.0 'g'] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalIntersectTestNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalIntersectTestNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DateTimeIntersect":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] intersect Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 10)] ) = Interval [ @2012-01-07, @2012-01-10 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIntersect_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIntersect"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIntersect":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] intersect Interval[@T04:59:59.999, @T06:59:59.999] ) = Interval [ @T04:59:59.999, @T06:59:59.999 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIntersect_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIntersect"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalEquivalentTrue":
		///	( Interval[1, 10] ~ Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalEquivalentTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalEquivalentTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalEquivalentFalse":
		///	( Interval[44, 50] ~ Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalEquivalentFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalEquivalentFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalEquivalentTrue":
		///	( Interval[1.0, 10.0] ~ Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalEquivalentTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalEquivalentTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalEquivalentFalse":
		///	( Interval[11.0, 20.0] ~ Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalEquivalentFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalEquivalentFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalEquivalentTrue":
		///	( Interval[1.0 'g', 10.0 'g'] ~ Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalEquivalentTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalEquivalentTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalEquivalentFalse":
		///	( Interval[11.0 'g', 20.0 'g'] ~ Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalEquivalentFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalEquivalentFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeEquivalentTrue":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeEquivalentTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeEquivalentTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeEquivalentFalse":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeEquivalentFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeEquivalentFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeEquivalentTrue":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] ~ Interval[@T04:59:59.999, @T09:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeEquivalentTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeEquivalentTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeEquivalentFalse":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] ~ Interval[@T04:58:59.999, @T09:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeEquivalentFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeEquivalentFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestMeetsNull":
		///	( Interval(null, 5] meets Interval(null, 15) ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestMeetsNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestMeetsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalMeetsTrue":
		///	( Interval[1, 10] meets Interval[11, 20] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalMeetsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalMeetsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalMeetsFalse":
		///	( Interval[1, 10] meets Interval[44, 50] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalMeetsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalMeetsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalMeetsTrue":
		///	( Interval[3.01, 5.00000001] meets Interval[5.00000002, 8.50] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalMeetsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalMeetsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalMeetsFalse":
		///	( Interval[3.01, 5.00000001] meets Interval[5.5, 8.50] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalMeetsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalMeetsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalMeetsTrue":
		///	( Interval[3.01 'g', 5.00000001 'g'] meets Interval[5.00000002 'g', 8.50 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalMeetsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalMeetsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalMeetsFalse":
		///	( Interval[3.01 'g', 5.00000001 'g'] meets Interval[5.5 'g', 8.50 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalMeetsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalMeetsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMeetsTrue":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeMeetsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeMeetsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMeetsFalse":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeMeetsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeMeetsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeMeetsTrue":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:00:00.000, @T19:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeMeetsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeMeetsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeMeetsFalse":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:12:00.000, @T19:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeMeetsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeMeetsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestMeetsBeforeNull":
		///	( Interval(null, 5] meets before Interval(null, 25] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestMeetsBeforeNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestMeetsBeforeNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalMeetsBeforeTrue":
		///	( Interval[1, 10] meets before Interval[11, 20] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalMeetsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalMeetsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalMeetsBeforeFalse":
		///	( Interval[1, 10] meets before Interval[44, 50] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalMeetsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalMeetsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalMeetsBeforeTrue":
		///	( Interval[3.50000001, 5.00000011] meets before Interval[5.00000012, 8.50] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalMeetsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalMeetsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalMeetsBeforeFalse":
		///	( Interval[8.01, 15.00000001] meets before Interval[15.00000000, 18.50] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalMeetsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalMeetsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalMeetsBeforeTrue":
		///	( Interval[3.50000001 'g', 5.00000011 'g'] meets before Interval[5.00000012 'g', 8.50 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalMeetsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalMeetsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalMeetsBeforeFalse":
		///	( Interval[8.01 'g', 15.00000001 'g'] meets before Interval[15.00000000 'g', 18.50 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalMeetsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalMeetsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMeetsBeforeTrue":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeMeetsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeMeetsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMeetsBeforeFalse":
		///	( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeMeetsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeMeetsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeMeetsBeforeTrue":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:00:00.000, @T19:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeMeetsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeMeetsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeMeetsBeforeFalse":
		///	( Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:12:00.000, @T19:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeMeetsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeMeetsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestMeetsAfterNull":
		///	( Interval(null, 5] meets after Interval[11, null) ) = null
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestMeetsAfterNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestMeetsAfterNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalMeetsAfterTrue":
		///	( Interval[11, 20] meets after Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalMeetsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalMeetsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalMeetsAfterFalse":
		///	( Interval[44, 50] meets after Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalMeetsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalMeetsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalMeetsAfterTrue":
		///	( Interval[55.00000123, 128.032156] meets after Interval[12.00258, 55.00000122] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalMeetsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalMeetsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalMeetsAfterFalse":
		///	( Interval[55.00000124, 150.222222] meets after Interval[12.00258, 55.00000122] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalMeetsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalMeetsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalMeetsAfterTrue":
		///	( Interval[55.00000123 'g', 128.032156 'g'] meets after Interval[12.00258 'g', 55.00000122 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalMeetsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalMeetsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalMeetsAfterFalse":
		///	( Interval[55.00000124 'g', 150.222222 'g'] meets after Interval[12.00258 'g', 55.00000122 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalMeetsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalMeetsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMeetsAfterTrue":
		///	( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)] meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeMeetsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeMeetsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMeetsAfterFalse":
		///	( Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)] meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeMeetsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeMeetsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeMeetsAfterTrue":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] meets Interval[@T04:59:59.999, @T09:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeMeetsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeMeetsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeMeetsAfterFalse":
		///	( Interval[@T10:12:00.000, @T19:59:59.999] meets Interval[@T04:59:59.999, @T09:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeMeetsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeMeetsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalNotEqualTrue":
		///	( Interval[1, 10] != Interval[11, 20] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalNotEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalNotEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalNotEqualFalse":
		///	( Interval[1, 10] != Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalNotEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalNotEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalNotEqualTrue":
		///	( Interval[1.0, 10.0] != Interval[11.0, 20.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalNotEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalNotEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalNotEqualFalse":
		///	( Interval[1.0, 10.0] != Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalNotEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalNotEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalNotEqualTrue":
		///	( Interval[1.0 'g', 10.0 'g'] != Interval[11.0 'g', 20.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalNotEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalNotEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalNotEqualFalse":
		///	( Interval[1.0 'g', 10.0 'g'] != Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalNotEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalNotEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeNotEqualTrue":
		///	( Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)] != Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 22)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeNotEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeNotEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeNotEqualFalse":
		///	( Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)] != Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeNotEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeNotEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeNotEqualTrue":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] != Interval[@T10:10:00.000, @T19:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeNotEqualTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeNotEqualTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeNotEqualFalse":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] != Interval[@T10:00:00.000, @T19:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeNotEqualFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeNotEqualFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterNull":
		///	( Interval[@2012-12-01, @2013-12-01] on or after null ) = null
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterDateTrue":
		///	( Interval[@2012-12-01, @2013-12-01] on or after month of @2012-11-15 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterDateTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterDateTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterDateFalse":
		///	( @2012-11-15 on or after month of Interval[@2012-12-01, @2013-12-01] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterDateFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterDateFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterTimeTrue":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] on or after hour of Interval[@T08:00:00.000, @T09:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterTimeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterTimeFalse":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] on or after hour of Interval[@T08:00:00.000, @T11:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterTimeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterIntegerTrue":
		///	( Interval[6, 10] on or after 6 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterIntegerTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterIntegerTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterDecimalFalse":
		///	( 2.5 on or after Interval[1.666, 2.50000001] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterDecimalFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterDecimalFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrAfterQuantityTrue":
		///	( 2.5 'mg' on or after Interval[1.666 'mg', 2.50000000 'mg'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrAfterQuantityTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrAfterQuantityTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeNull":
		///	( Interval[@2012-12-01, @2013-12-01] on or before null ) = null
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeDateTrue":
		///	( Interval[@2012-10-01, @2012-11-01] on or before month of @2012-11-15 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeDateTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeDateTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeDateFalse":
		///	( @2012-11-15 on or before month of Interval[@2012-10-01, @2013-12-01] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeDateFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeDateFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeTimeTrue":
		///	( Interval[@T05:00:00.000, @T07:59:59.999] on or before hour of Interval[@T08:00:00.000, @T09:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeTimeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeTimeFalse":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] on or before hour of Interval[@T08:00:00.000, @T11:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeTimeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeIntegerTrue":
		///	( Interval[4, 6] on or before 6 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeIntegerTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeIntegerTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeDecimalFalse":
		///	( 1.6667 on or before Interval[1.666, 2.50000001] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeDecimalFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeDecimalFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOnOrBeforeQuantityTrue":
		///	( 1.666 'mg' on or before Interval[1.666 'mg', 2.50000000 'mg'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOnOrBeforeQuantityTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOnOrBeforeQuantityTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOverlapsNull":
		///	( Interval[null as Integer, null as Integer] overlaps Interval[1, 10] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOverlapsNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOverlapsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalOverlapsTrue":
		///	( Interval[1, 10] overlaps Interval[4, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalOverlapsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalOverlapsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalOverlapsFalse":
		///	( Interval[1, 10] overlaps Interval[11, 20] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalOverlapsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalOverlapsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalOverlapsTrue":
		///	( Interval[1.0, 10.0] overlaps Interval[4.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalOverlapsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalOverlapsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalOverlapsFalse":
		///	( Interval[1.0, 10.0] overlaps Interval[11.0, 20.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalOverlapsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalOverlapsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalOverlapsTrue":
		///	( Interval[1.0 'g', 10.0 'g'] overlaps Interval[5.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalOverlapsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalOverlapsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalOverlapsFalse":
		///	( Interval[1.0 'g', 10.0 'g'] overlaps Interval[11.0 'g', 20.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalOverlapsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalOverlapsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeOverlapsTrue":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeOverlapsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeOverlapsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeOverlapsFalse":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeOverlapsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeOverlapsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeOverlapsTrue":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T12:00:00.000, @T21:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeOverlapsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeOverlapsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeOverlapsFalse":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T20:00:00.000, @T21:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeOverlapsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeOverlapsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOverlapsBeforeNull":
		///	( Interval[null as Integer, null as Integer] overlaps before Interval[1, 10] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOverlapsBeforeNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOverlapsBeforeNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalOverlapsBeforeTrue":
		///	( Interval[1, 10] overlaps before Interval[4, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalOverlapsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalOverlapsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalOverlapsBeforeFalse":
		///	( Interval[4, 10] overlaps before Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalOverlapsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalOverlapsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalOverlapsBeforeTrue":
		///	( Interval[1.0, 10.0] overlaps before Interval[4.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalOverlapsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalOverlapsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalOverlapsBeforeFalse":
		///	( Interval[4.0, 10.0] overlaps before Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalOverlapsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalOverlapsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalOverlapsBeforeTrue":
		///	( Interval[1.0 'g', 10.0 'g'] overlaps before Interval[5.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalOverlapsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalOverlapsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalOverlapsBeforeFalse":
		///	( Interval[5.0 'g', 10.0 'g'] overlaps before Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalOverlapsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalOverlapsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeOverlapsBeforeTrue":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeOverlapsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeOverlapsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeOverlapsBeforeFalse":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeOverlapsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeOverlapsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeOverlapsBeforeTrue":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T12:00:00.000, @T21:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeOverlapsBeforeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeOverlapsBeforeTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeOverlapsBeforeFalse":
		///	( Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T20:00:00.000, @T21:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeOverlapsBeforeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeOverlapsBeforeFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestOverlapsAfterNull":
		///	( Interval[null as Integer, null as Integer] overlaps after Interval[1, 10] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestOverlapsAfterNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestOverlapsAfterNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalOverlapsAfterTrue":
		///	( Interval[4, 15] overlaps after Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalOverlapsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalOverlapsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalOverlapsAfterFalse":
		///	( Interval[4, 10] overlaps after Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalOverlapsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalOverlapsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalOverlapsAfterTrue":
		///	( Interval[4.0, 15.0] overlaps after Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalOverlapsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalOverlapsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalOverlapsAfterFalse":
		///	( Interval[4.0, 10.0] overlaps after Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalOverlapsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalOverlapsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalOverlapsAfterTrue":
		///	( Interval[5.0 'g', 15.0 'g'] overlaps after Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalOverlapsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalOverlapsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalOverlapsAfterFalse":
		///	( Interval[5.0 'g', 10.0 'g'] overlaps after Interval[1.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalOverlapsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalOverlapsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeOverlapsAfterTrue":
		///	( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeOverlapsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeOverlapsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeOverlapsAfterFalse":
		///	( Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)] overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeOverlapsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeOverlapsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeOverlapsAfterTrue":
		///	( Interval[@T12:00:00.000, @T21:59:59.999] overlaps Interval[@T10:00:00.000, @T19:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeOverlapsAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeOverlapsAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeOverlapsAfterFalse":
		///	( Interval[@T20:00:00.000, @T21:59:59.999] overlaps Interval[@T10:00:00.000, @T19:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeOverlapsAfterFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeOverlapsAfterFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestPointFromNull":
		///	( point from Interval[null as Integer, null as Integer] ) = null as Integer
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestPointFromNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestPointFromNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TestPointFromInteger":
		///	( point from Interval[1, 1] ) = 1
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestPointFromInteger_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestPointFromInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestPointFromDecimal":
		///	( point from Interval[1.0, 1.0] ) = 1.0
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestPointFromDecimal_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestPointFromDecimal"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestPointFromQuantity":
		///	( point from Interval[1.0 'cm', 1.0 'cm'] ) = 1.0'cm'
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestPointFromQuantity_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestPointFromQuantity"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperContainsTrue":
		///	( Interval[@T12:00:00.000, @T21:59:59.999] properly includes @T12:00:00.001 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperContainsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperContainsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperContainsFalse":
		///	( Interval[@T12:00:00.000, @T21:59:59.999] properly includes @T12:00:00.000 ) = false
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperContainsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperContainsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperContainsNull":
		///	( Interval[@T12:00:00.001, @T21:59:59.999] properly includes @T12:00:00 ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperContainsNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperContainsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TimeProperContainsPrecisionTrue":
		///	( Interval[@T12:00:00.000, @T21:59:59.999] properly includes second of @T12:00:01 ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperContainsPrecisionTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperContainsPrecisionTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperContainsPrecisionFalse":
		///	( Interval[@T12:00:00.001, @T21:59:59.999] properly includes second of @T12:00:00 ) = false
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperContainsPrecisionFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperContainsPrecisionFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperContainsPrecisionNull":
		///	( Interval[@T12:00:00.001, @T21:59:59.999] properly includes millisecond of @T12:00:00 ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperContainsPrecisionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperContainsPrecisionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TimeProperInTrue":
		///	( @T12:00:00.001 properly included in Interval[@T12:00:00.000, @T21:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperInFalse":
		///	( @T12:00:00.000 properly included in  Interval[@T12:00:00.000, @T21:59:59.999] ) = false
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperInNull":
		///	( @T12:00:00 properly included in Interval[@T12:00:00.001, @T21:59:59.999] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperInNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperInNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TimeProperInPrecisionTrue":
		///	( @T12:00:01 properly included in second of Interval[@T12:00:00.000, @T21:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperInPrecisionTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperInPrecisionTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperInPrecisionFalse":
		///	( @T12:00:00 properly included in second of Interval[@T12:00:00.001, @T21:59:59.999] ) = false
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperInPrecisionFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperInPrecisionFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperInPrecisionNull":
		///	( @T12:00:00 properly included in millisecond of Interval[@T12:00:00.001, @T21:59:59.999] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperInPrecisionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperInPrecisionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TestProperlyIncludesNull":
		///	( Interval[null as Integer, null as Integer] properly includes Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void TestProperlyIncludesNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestProperlyIncludesNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalProperlyIncludesTrue":
		///	( Interval[1, 10] properly includes Interval[4, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalProperlyIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalProperlyIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalProperlyIncludesFalse":
		///	( Interval[1, 10] properly includes Interval[4, 15] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalProperlyIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalProperlyIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalProperlyIncludesTrue":
		///	( Interval[1.0, 10.0] properly includes Interval[4.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalProperlyIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalProperlyIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalProperlyIncludesFalse":
		///	( Interval[1.0, 10.0] properly includes Interval[4.0, 15.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalProperlyIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalProperlyIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalProperlyIncludesTrue":
		///	( Interval[1.0 'g', 10.0 'g'] properly includes Interval[5.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalProperlyIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalProperlyIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalProperlyIncludesFalse":
		///	( Interval[1.0 'g', 10.0 'g'] properly includes Interval[5.0 'g', 15.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalProperlyIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalProperlyIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeProperlyIncludesTrue":
		///	( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeProperlyIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeProperlyIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeProperlyIncludesFalse":
		///	( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeProperlyIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeProperlyIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperlyIncludesTrue":
		///	( Interval[@T12:00:00.000, @T21:59:59.999] properly includes Interval[@T12:01:01.000, @T21:59:59.998] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperlyIncludesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperlyIncludesTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperlyIncludesFalse":
		///	( Interval[@T12:00:00.000, @T21:59:59.999] properly includes Interval[@T12:01:01.000, @T22:00:00.000] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperlyIncludesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperlyIncludesFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestProperlyIncludedInNull":
		///	( Interval[1, 10] properly included in Interval[null as Integer, null as Integer] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void TestProperlyIncludedInNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestProperlyIncludedInNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalProperlyIncludedInTrue":
		///	( Interval[4, 10] properly included in Interval[1, 10] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalProperlyIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalProperlyIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalProperlyIncludedInFalse":
		///	( Interval[4, 15] properly included in Interval[1, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalProperlyIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalProperlyIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalProperlyIncludedInTrue":
		///	( Interval[4.0, 10.0] properly included in Interval[1.0, 10.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalProperlyIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalProperlyIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalProperlyIncludedInFalse":
		///	( Interval[4.0, 15.0] properly included in Interval[1.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalProperlyIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalProperlyIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalProperlyIncludedInTrue":
		///	( Interval[5.0 'g', 10.0 'g'] properly included in Interval[1.0 'g', 10.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalProperlyIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalProperlyIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalProperlyIncludedInFalse":
		///	( Interval[1.0 'g', 10.0 'g'] properly included in Interval[5.0 'g', 15.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalProperlyIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalProperlyIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeProperlyIncludedInTrue":
		///	( Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)] properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeProperlyIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeProperlyIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeProperlyIncludedInFalse":
		///	( Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)] properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeProperlyIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeProperlyIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperlyIncludedInTrue":
		///	( Interval[@T12:01:01.000, @T21:59:59.998] properly included in Interval[@T12:00:00.000, @T21:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperlyIncludedInTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperlyIncludedInTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProperlyIncludedInFalse":
		///	( Interval[@T12:01:01.000, @T22:00:00.000] properly included in Interval[@T12:00:00.000, @T21:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeProperlyIncludedInFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeProperlyIncludedInFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalStart":
		///	( start of Interval[1, 10] ) = 1
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalStart_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalStart"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalStart":
		///	( start of Interval[1.0, 10.0] ) = 1.0
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalStart_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalStart"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalStart":
		///	( start of Interval[1.0 'g', 10.0 'g'] ) = 1.0'g'
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalStart_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalStart"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIntervalStart":
		///	( start of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000] ) = @2016-05-01T00:00:00.000
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIntervalStart_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIntervalStart"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIntervalStart":
		///	( start of Interval[@T00:00:00.000, @T23:59:59.599] ) = @T00:00:00.000
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIntervalStart_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIntervalStart"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestStartsNull":
		///	( Interval[null as Integer, null as Integer] starts Interval[1, 10] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestStartsNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestStartsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalStartsTrue":
		///	( Interval[4, 10] starts Interval[4, 15] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalStartsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalStartsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalStartsFalse":
		///	( Interval[1, 10] starts Interval[4, 10] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalStartsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalStartsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalStartsTrue":
		///	( Interval[4.0, 10.0] starts Interval[4.0, 15.0] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalStartsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalStartsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalStartsFalse":
		///	( Interval[1.0, 10.0] starts Interval[4.0, 10.0] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalStartsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalStartsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalStartsTrue":
		///	( Interval[5.0 'g', 10.0 'g'] starts Interval[5.0 'g', 15.0 'g'] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalStartsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalStartsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalStartsFalse":
		///	( Interval[1.0 'g', 10.0 'g'] starts Interval[5.0 'g', 10.0 'g'] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalStartsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalStartsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeStartsTrue":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] starts Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 27)] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeStartsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeStartsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeStartsFalse":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] starts Interval[DateTime(2012, 1, 6), DateTime(2012, 1, 27)] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeStartsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeStartsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeStartsTrue":
		///	( Interval[@T05:59:59.999, @T15:59:59.999] starts Interval[@T05:59:59.999, @T17:59:59.999] ) = true
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeStartsTrue_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeStartsTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeStartsFalse":
		///	( Interval[@T05:59:59.999, @T15:59:59.999] starts Interval[@T04:59:59.999, @T17:59:59.999] ) = false
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeStartsFalse_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeStartsFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestUnionNull":
		///	( Interval[null as Integer, null as Integer] union Interval[1, 10] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TestUnionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TestUnionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalUnion1To15":
		///	( Interval[1, 10] union Interval[4, 15] ) = Interval [ 1, 15 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalUnion1To15_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalUnion1To15"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalUnionNull":
		///	( Interval[1, 10] union Interval[44, 50] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalUnionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalUnionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalUnion1To15":
		///	( Interval[1.0, 10.0] union Interval[4.0, 15.0] ) = Interval [ 1.0, 15.0 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalUnion1To15_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalUnion1To15"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalUnionNull":
		///	( Interval[1.0, 10.0] union Interval[14.0, 15.0] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalUnionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalUnionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalUnion1To15":
		///	( Interval[1.0 'g', 10.0 'g'] union Interval[5.0 'g', 15.0 'g'] ) = Interval [ 1.0 'g', 15.0 'g' ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalUnion1To15_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalUnion1To15"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalUnionNull":
		///	( Interval[1.0 'g', 10.0 'g'] union Interval[14.0 'g', 15.0 'g'] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalUnionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalUnionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DateTimeUnion":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] union Interval[DateTime(2012, 1, 25), DateTime(2012, 1, 28)] ) = Interval [ @2012-01-05, @2012-01-28 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeUnion_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeUnion"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeUnionNull":
		///	( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] union Interval[DateTime(2012, 1, 27), DateTime(2012, 1, 28)] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeUnionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeUnionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "TimeUnion":
		///	( Interval[@T05:59:59.999, @T15:59:59.999] union Interval[@T10:59:59.999, @T20:59:59.999] ) = Interval [ @T05:59:59.999, @T20:59:59.999 ]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeUnion_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeUnion"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeUnionNull":
		///	( Interval[@T05:59:59.999, @T15:59:59.999] union Interval[@T16:59:59.999, @T20:59:59.999] ) = null
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeUnionNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeUnionNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalTestWidth9":
		///	( width of Interval[1, 10] ) = 9
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalTestWidth9_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalTestWidth9"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "IntervalTestWidthNull":
        ///	( width of (null as Interval&lt;Any>) ) = null as Integer
        /// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntervalTestWidthNull_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntervalTestWidthNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalTestWidth11":
		///	( width of Interval[4.0, 15.0] ) = 11.0
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalTestWidth11_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalTestWidth11"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalTestWidth5":
		///	( width of Interval[5.0 'g', 10.0 'g'] ) = 5.0'g'
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalTestWidth5_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalTestWidth5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeWidth":
		///	( width of Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] ) = 20 days
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeWidth_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeWidth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeWidth":
		///	( width of Interval[@T05:59:59.999, @T15:59:59.999] ) = 36000000 milliseconds
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeWidth_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeWidth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalTest":
		///	( Interval[1, 10] ) = Interval[1, 10]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalTest_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalTest2":
		///	( Interval[11, 20] ) = Interval[11, 20]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalTest2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalTest2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalTest3":
		///	( Interval[44, 50] ) = Interval[44, 50]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalTest3_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalTest3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalTest4":
		///	( Interval[4, 10] ) = Interval[4, 10]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalTest4_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalTest4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIntervalTest5":
		///	( Interval[4, 15] ) = Interval[4, 15]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void IntegerIntervalTest5_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "IntegerIntervalTest5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalTest":
		///	( Interval[1.0, 10.0] ) = Interval[1.0, 10.0]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalTest_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalTest2":
		///	( Interval[11.0, 20.0] ) = Interval[11.0, 20.0]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalTest2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalTest2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalTest3":
		///	( Interval[4.0, 10.0] ) = Interval[4.0, 10.0]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalTest3_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalTest3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalTest4":
		///	( Interval[4.0, 15.0] ) = Interval[4.0, 15.0]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalTest4_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalTest4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DecimalIntervalTest5":
		///	( Interval[14.0, 15.0] ) = Interval[14.0, 15.0]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DecimalIntervalTest5_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DecimalIntervalTest5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalTest":
		///	( Interval[1.0 'g', 10.0 'g'] ) = Interval[1.0 'g', 10.0 'g']
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalTest_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalTest2":
		///	( Interval[11.0 'g', 20.0 'g'] ) = Interval[11.0 'g', 20.0 'g']
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalTest2_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalTest2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalTest3":
		///	( Interval[5.0 'g', 10.0 'g'] ) = Interval[5.0 'g', 10.0 'g']
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalTest3_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalTest3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalTest4":
		///	( Interval[5.0 'g', 15.0 'g'] ) = Interval[5.0 'g', 15.0 'g']
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalTest4_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalTest4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityIntervalTest5":
		///	( Interval[14.0 'g', 15.0 'g'] ) = Interval[14.0 'g', 15.0 'g']
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void QuantityIntervalTest5_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "QuantityIntervalTest5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIntervalTest":
		///	( Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000] ) = Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void DateTimeIntervalTest_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "DateTimeIntervalTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeIntervalTest":
		///	( Interval[@T00:00:00.000, @T23:59:59.599] ) = Interval[@T00:00:00.000, @T23:59:59.599]
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void TimeIntervalTest_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "TimeIntervalTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "CollapseIntervalTestInteger":
		///	( {Interval[1, 10], Interval[11, 20], Interval[44, 50]} ) = {Interval[1, 10], Interval[11, 20], Interval[44, 50]}
		/// </summary>
        [TestCategory("CqlIntervalOperatorsTest")]
        [TestMethod]
        public void CollapseIntervalTestInteger_Test()
        {
            var lambda = LambdasByTestName["CqlIntervalOperatorsTest", "CollapseIntervalTestInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
