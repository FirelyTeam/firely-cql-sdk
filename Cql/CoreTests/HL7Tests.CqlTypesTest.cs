using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summary>
		///define "AnyQuantity":
		///	( 5.0 'g' ) = 5.0'g'
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void AnyQuantity_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "AnyQuantity"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "AnyDateTime":
		///	( DateTime(2012, 4, 4) ) = @2012-04-04
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void AnyDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "AnyDateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "AnyTime":
		///	( @T09:00:00.000 ) = @T09:00:00.000
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void AnyTime_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "AnyTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "AnyInterval":
		///	( Interval[2, 7] ) = Interval[2, 7]
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void AnyInterval_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "AnyInterval"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "AnyList":
		///	( {1, 2, 3} ) = {1, 2, 3}
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void AnyList_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "AnyList"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "AnyTuple":
		///	( Tuple { id: 5, name: 'Chris'} ) = Tuple { id: 5, name: 'Chris'}
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void AnyTuple_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "AnyTuple"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "AnyString":
		///	( Tuple { id: 5, name: 'Chris'}.name ) = 'Chris'
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void AnyString_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "AnyString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeNull":
		///	( DateTime(null) ) = null
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void DateTimeNull_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "DateTimeNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summary>
		///define "DateTimeProper":
		///	( DateTime(2016, 7, 7, 6, 25, 33, 910) ) = @2016-07-07T06:25:33.910
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void DateTimeProper_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "DateTimeProper"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeIncomplete":
		///	( DateTime(2015, 2, 10) ) = @2015-02-10
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void DateTimeIncomplete_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "DateTimeIncomplete"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeUncertain":
		///	( days between DateTime(2015, 2, 10) and DateTime(2015, 3) ) = Interval [ 19, 49 ]
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void DateTimeUncertain_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "DateTimeUncertain"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMin":
		///	( DateTime(0001, 1, 1, 0, 0, 0, 0) ) = @0001-01-01T00:00:00.000
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void DateTimeMin_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "DateTimeMin"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "DateTimeMax":
		///	( DateTime(9999, 12, 31, 23, 59, 59, 999) ) = @9999-12-31T23:59:59.999
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void DateTimeMax_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "DateTimeMax"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityTest":
		///	( 150.2 'lbs' ) = 150.2 'lbs'
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void QuantityTest_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "QuantityTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityTest2":
		///	( 2.5589 'eskimo kisses' ) = 2.5589 'eskimo kisses'
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void QuantityTest2_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "QuantityTest2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "QuantityFractionalTooBig":
		///	( 5.999999999 'g' ) = 5.999999999 'g'
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void QuantityFractionalTooBig_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "QuantityFractionalTooBig"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "StringTestEscapeQuotes":
		///	( '\'I start with a single quote and end with a double quote\"' ) = '\u0027I start with a single quote and end with a double quote\u0022'
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void StringTestEscapeQuotes_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "StringTestEscapeQuotes"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "StringUnicodeTest":
		///	( '\u0048\u0069' ) = 'Hi'
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void StringUnicodeTest_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "StringUnicodeTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeProper":
		///	( @T10:25:12.863 ) = @T10:25:12.863
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void TimeProper_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "TimeProper"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeAllMax":
		///	( @T23:59:59.999 ) = @T23:59:59.999
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void TimeAllMax_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "TimeAllMax"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TimeAllMin":
		///	( @T00:00:00.000 ) = @T00:00:00.000
		/// </summary>
        [TestCategory("CqlTypesTest")]
        [TestMethod]
        public void TimeAllMin_Test()
        {
            var lambda = LambdasByTestName["CqlTypesTest", "TimeAllMin"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
