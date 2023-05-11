using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "CoalesceANull":
		///	( Coalesce('a', null) ) = 'a'
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void CoalesceANull_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "CoalesceANull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CoalesceNullA":
		///	( Coalesce(null, 'a') ) = 'a'
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void CoalesceNullA_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "CoalesceNullA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CoalesceEmptyList":
		///	( Coalesce({}) ) = null
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void CoalesceEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "CoalesceEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "CoalesceListFirstA":
		///	( Coalesce({'a', null, null}) ) = 'a'
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void CoalesceListFirstA_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "CoalesceListFirstA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CoalesceListLastA":
		///	( Coalesce({null, null, 'a'}) ) = 'a'
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void CoalesceListLastA_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "CoalesceListLastA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CoalesceFirstList":
		///	( Coalesce({'a'},null, null) ) = {'a'}
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void CoalesceFirstList_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "CoalesceFirstList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CoalesceLastList":
		///	( Coalesce(null, null, {'a'}) ) = {'a'}
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void CoalesceLastList_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "CoalesceLastList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeCoalesce":
		///	( Coalesce(null, null, DateTime(2012, 5, 18)) ) = DateTime(2012, 5, 18)
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void DateTimeCoalesce_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "DateTimeCoalesce"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeListCoalesce":
		///	( Coalesce({ null, null, DateTime(2012, 5, 18) }) ) = DateTime(2012, 5, 18)
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void DateTimeListCoalesce_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "DateTimeListCoalesce"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeCoalesce":
		///	( Coalesce(null, null, @T05:15:33.556) ) = @T05:15:33.556
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void TimeCoalesce_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "TimeCoalesce"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeListCoalesce":
		///	( Coalesce({ null, null, @T05:15:33.556 }) ) = @T05:15:33.556
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void TimeListCoalesce_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "TimeListCoalesce"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsNullTrue":
		///	( IsNull(null) ) = true
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsNullTrue_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsNullTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsNullFalseEmptyString":
		///	( IsNull('') ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsNullFalseEmptyString_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsNullFalseEmptyString"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsNullAlsoFalseAbcString":
		///	( IsNull('abc') ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsNullAlsoFalseAbcString_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsNullAlsoFalseAbcString"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsNullAlsoFalseNumber1":
		///	( IsNull(1) ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsNullAlsoFalseNumber1_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsNullAlsoFalseNumber1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsNullAlsoFalseNumberZero":
		///	( IsNull(0) ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsNullAlsoFalseNumberZero_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsNullAlsoFalseNumberZero"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsFalseFalse":
		///	( IsFalse(false) ) = true
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsFalseFalse_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsFalseFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsFalseTrue":
		///	( IsFalse(true) ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsFalseTrue_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsFalseTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsFalseNull":
		///	( IsFalse(null) ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsFalseNull_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsFalseNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsTrueTrue":
		///	( IsTrue(true) ) = true
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsTrueTrue_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsTrueTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsTrueFalse":
		///	( IsTrue(false) ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsTrueFalse_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsTrueFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IsTrueNull":
		///	( IsTrue(null) ) = false
		/// </summary>
        [TestCategory("CqlNullologicalOperatorsTest")]
        [TestMethod]
        public void IsTrueNull_Test()
        {
            var lambda = LambdasByTestName["CqlNullologicalOperatorsTest", "IsTrueNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
