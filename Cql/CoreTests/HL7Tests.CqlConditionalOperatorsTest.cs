using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "IfTrue1":
		///	( if 10 > 5 then 5 else 10 ) = 5
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void IfTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "IfTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IfFalse1":
		///	( if 10 = 5 then 10 + 5 else 10 - 5 ) = 5
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void IfFalse1_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "IfFalse1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IfNull1":
		///	( if 10 = null then 5 else 10 ) = 10
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void IfNull1_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "IfNull1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "StandardCase1":
		///	( 
		///				case
		///					when 10 > 5 then 5
		///					when 5 > 10 then 10
		///					else null
		///				end
		///			 ) = 5
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void StandardCase1_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "StandardCase1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "StandardCase2":
		///	( 
		///				case
		///					when 5 > 10 then 5 + 10
		///					when 5 = 10 then 5
		///					else 10 - 5
		///				end
		///			 ) = 5
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void StandardCase2_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "StandardCase2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "StandardCase3":
		///	( 
		///				case
		///					when null ~ 10 then null + 10
		///					when null ~ 5 then 5
		///					else 5 + 10
		///				end
		///			 ) = 15
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void StandardCase3_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "StandardCase3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SelectedCase1":
		///	( 
		///				case 5
		///					when 5 then 12
		///					when 10 then 10 + 5
		///					else 10 - 5
		///				end
		///			 ) = 12
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void SelectedCase1_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "SelectedCase1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SelectedCase2":
		///	( 
		///				case 10
		///					when 5 then 12
		///					when 10 then 10 + 5
		///					else 10 - 5
		///				end
		///			 ) = 15
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void SelectedCase2_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "SelectedCase2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SelectedCase3":
		///	( 
		///				case 10 + 5
		///					when 5 then 12
		///					when 10 then 10 + 5
		///					else 10 - 5
		///				end
		///			 ) = 5
		/// </summary>
        [TestCategory("CqlConditionalOperatorsTest")]
        [TestMethod]
        public void SelectedCase3_Test()
        {
            var lambda = LambdasByTestName["CqlConditionalOperatorsTest", "SelectedCase3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
