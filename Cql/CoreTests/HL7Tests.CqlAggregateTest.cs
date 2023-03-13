
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ncqa.Cql.Runtime;
using Ncqa.Fhir.R4.Model;
using System;

namespace CoreTests

{
    public partial class HL7Tests
    {

        /// <summaray>
		///define FactorialOfFive:
		///  ({ 1, 2, 3, 4, 5 }) Num
		///    aggregate Result starting 1: Result * Num
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlAggregateTest")]
        [TestMethod]
        public void FactorialOfFive_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateTest", "FactorialOfFive"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "RolledOutIntervals":
		///  MedicationRequestIntervals M
		///    aggregate R starting (null as List<Interval<DateTime>>): R union ({
		///      M X
		///        let S: Max({ end of Last(R) + 1 day, start of X }),
		///          E: S + duration in days of X
		///        return Interval[S, E]
		///    })
		/// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlAggregateTest")]
        [TestMethod]
        public void RolledOutIntervals_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateTest", "RolledOutIntervals"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
