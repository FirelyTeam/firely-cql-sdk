using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ncqa.Cql.Runtime;
using Ncqa.Fhir.R4.Model;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "TrueAndTrue":
		///	( true and true ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueAndTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueAndTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueAndFalse":
		///	( true and false ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueAndFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueAndFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueAndNull":
		///	( true and null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueAndNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueAndNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "FalseAndTrue":
		///	( false and true ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseAndTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseAndTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseAndFalse":
		///	( false and false ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseAndFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseAndFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseAndNull":
		///	( false and null ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseAndNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseAndNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NullAndTrue":
		///	( null and true ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullAndTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullAndTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NullAndFalse":
		///	( null and false ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullAndFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullAndFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NullAndNull":
		///	( null and null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullAndNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullAndNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "TrueImpliesTrue":
		///	( true implies true ) = true
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueImpliesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueImpliesTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueImpliesFalse":
		///	( true implies false ) = false
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueImpliesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueImpliesFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueImpliesNull":
		///	( true implies null ) = null
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueImpliesNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueImpliesNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "FalseImpliesTrue":
		///	( false implies true ) = true
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseImpliesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseImpliesTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseImpliesFalse":
		///	( false implies false ) = true
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseImpliesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseImpliesFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseImpliesNull":
		///	( false implies null ) = true
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseImpliesNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseImpliesNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NullImpliesTrue":
		///	( null implies true ) = true
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullImpliesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullImpliesTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NullImpliesFalse":
		///	( null implies false ) = null
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullImpliesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullImpliesFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NullImpliesNull":
		///	( null implies null ) = null
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullImpliesNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullImpliesNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NotTrue":
		///	( not true ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NotTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NotTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotFalse":
		///	( not false ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NotFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NotFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotNull":
		///	( not null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NotNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NotNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "TrueOrTrue":
		///	( true or true ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueOrTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueOrTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueOrFalse":
		///	( true or false ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueOrFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueOrFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueOrNull":
		///	( true or null ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueOrNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueOrNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseOrTrue":
		///	( false or true ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseOrTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseOrTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseOrFalse":
		///	( false or false ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseOrFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseOrFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseOrNull":
		///	( false or null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseOrNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseOrNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NullOrTrue":
		///	( null or true ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullOrTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullOrTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NullOrFalse":
		///	( null or false ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullOrFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullOrFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NullOrNull":
		///	( null or null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullOrNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullOrNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "TrueXorTrue":
		///	( true xor true ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueXorTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueXorTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueXorFalse":
		///	( true xor false ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueXorFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueXorFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TrueXorNull":
		///	( true xor null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void TrueXorNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "TrueXorNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "FalseXorTrue":
		///	( false xor true ) = true
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseXorTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseXorTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseXorFalse":
		///	( false xor false ) = false
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseXorFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseXorFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FalseXorNull":
		///	( false xor null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void FalseXorNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "FalseXorNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NullXorTrue":
		///	( null xor true ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullXorTrue_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullXorTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NullXorFalse":
		///	( null xor false ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullXorFalse_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullXorFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "NullXorNull":
		///	( null xor null ) = null
		/// </summary>
        [TestCategory("CqlLogicalOperatorsTest")]
        [TestMethod]
        public void NullXorNull_Test()
        {
            var lambda = LambdasByTestName["CqlLogicalOperatorsTest", "NullXorNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
    }
}
                
