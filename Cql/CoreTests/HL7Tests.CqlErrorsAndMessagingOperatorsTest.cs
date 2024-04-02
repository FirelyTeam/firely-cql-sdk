using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summary>
		///define "TestMessageInfo":
		///	( Message(1, true, '100', 'Message', 'Test Message') ) = 1
		/// </summary>
        [TestCategory("CqlErrorsAndMessagingOperatorsTest")]
        [TestMethod]
        public void TestMessageInfo_Test()
        {
            var lambda = LambdasByTestName["CqlErrorsAndMessagingOperatorsTest", "TestMessageInfo"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestMessageWarn":
		///	( Message(2, true, '200', 'Warning', 'You have been warned!') ) = 2
		/// </summary>
        [TestCategory("CqlErrorsAndMessagingOperatorsTest")]
        [TestMethod]
        public void TestMessageWarn_Test()
        {
            var lambda = LambdasByTestName["CqlErrorsAndMessagingOperatorsTest", "TestMessageWarn"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summary>
		///define "TestMessageTrace":
		///	( Message({3, 4, 5}, true, '300', 'Trace', 'This is a trace') ) = {3, 4, 5}
		/// </summary>
        [TestCategory("CqlErrorsAndMessagingOperatorsTest")]
        [TestMethod]
        public void TestMessageTrace_Test()
        {
            var lambda = LambdasByTestName["CqlErrorsAndMessagingOperatorsTest", "TestMessageTrace"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
