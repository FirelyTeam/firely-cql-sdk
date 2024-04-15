using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summary>
		///define "AsQuantity":
		///	( 45.5 'g' as Quantity ) = 45.5 'g'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void AsQuantity_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "AsQuantity"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "CastAsQuantity":
		///	( cast 45.5 'g' as Quantity ) = 45.5 'g'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void CastAsQuantity_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "CastAsQuantity"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "AsDateTime":
		///	( DateTime(2014, 01, 01) as DateTime ) = @2014-01-01
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void AsDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "AsDateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerToDecimal":
		///	( convert 5 to Decimal ) = 5.0
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void IntegerToDecimal_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "IntegerToDecimal"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerToString":
		///	( convert 5 to String ) = '5'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void IntegerToString_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "IntegerToString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "StringToDateTime":
		///	( convert '2014-01-01' to DateTime ) = @2014-01-01
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void StringToDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "StringToDateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "StringToTime":
		///	( convert 'T14:30:00.0' to Time ) = @T14:30:00.000
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void StringToTime_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "StringToTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerIsInteger":
		///	( 5 is Integer ) = true
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void IntegerIsInteger_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "IntegerIsInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "StringIsInteger":
		///	( '5' is Integer ) = false
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void StringIsInteger_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "StringIsInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "StringNoToBoolean":
		///	( ToBoolean('NO') ) = false
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void StringNoToBoolean_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "StringNoToBoolean"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "CodeToConcept1":
		///	( ToConcept(Code { code: '8480-6' }) ) = 
		///				Concept {
		///					codes: Code { code: '8480-6' }
		///				}
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void CodeToConcept1_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "CodeToConcept1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToDateTime1":
		///	( ToDateTime('2014-01-01') ) = @2014-01-01
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToDateTime1_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToDateTime1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToDateTime2":
		///	( ToDateTime('2014-01-01T12:05') ) = @2014-01-01T12:05
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToDateTime2_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToDateTime2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToDateTime3":
		///	( ToDateTime('2014-01-01T12:05:05.955') ) = @2014-01-01T12:05:05.955
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToDateTime3_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToDateTime3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToDateTime4":
		///	( ToDateTime('2014-01-01T12:05:05.955+01:30') ) = @2014-01-01T12:05:05.955
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToDateTime4_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToDateTime4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToDateTime5":
		///	( ToDateTime('2014-01-01T12:05:05.955-01:15') ) = @2014-01-01T12:05:05.955
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToDateTime5_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToDateTime5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToDateTime6":
		///	( ToDateTime('2014-01-01T12:05:05.955Z') ) = @2014-01-01T12:05:05.955
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToDateTime6_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToDateTime6"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "String25D5ToDecimal":
		///	( ToDecimal('+25.5') ) = 25.5
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void String25D5ToDecimal_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "String25D5ToDecimal"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "StringNeg25ToInteger":
		///	( ToInteger('-25') ) = -25
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void StringNeg25ToInteger_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "StringNeg25ToInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "String5D5CMToQuantity":
		///	( ToQuantity('5.5 cm') ) = 5.5'cm'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void String5D5CMToQuantity_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "String5D5CMToQuantity"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "IntegerNeg5ToString":
		///	( ToString(-5) ) = '-5'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void IntegerNeg5ToString_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "IntegerNeg5ToString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "Decimal18D55ToString":
		///	( ToString(18.55) ) = '18.55'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void Decimal18D55ToString_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "Decimal18D55ToString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "Quantity5D5CMToString":
		///	( ToString(5.5 'cm') ) = '5.5cm'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void Quantity5D5CMToString_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "Quantity5D5CMToString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "BooleanTrueToString":
		///	( ToString(true) ) = 'true'
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void BooleanTrueToString_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "BooleanTrueToString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToTime1":
		///	( ToTime('T14:30:00.0') ) = @T14:30:00.000
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToTime1_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToTime1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToTime2":
		///	( ToTime('T14:30:00.0+05:30') ) = @T14:30:00.000
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToTime2_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToTime2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToTime3":
		///	( ToTime('T14:30:00.0-05:45') ) = @T14:30:00.000
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToTime3_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToTime3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "ToTime4":
		///	( ToTime('T14:30:00.0Z') ) = @T14:30:00.000
		/// </summary>
        [TestCategory("CqlTypeOperatorsTest")]
        [TestMethod]
        public void ToTime4_Test()
        {
            var lambda = LambdasByTestName["CqlTypeOperatorsTest", "ToTime4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
