
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests

{
    public partial class HL7Tests
    {

        /// <summary>
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
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "RolledOutIntervals":
        ///  MedicationRequestIntervals M
        ///    aggregate R starting (null as List&lt;Interval&lt;DateTime>>): R union ({
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
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            var result = function(Context);
            Assert.AreEqual(true, result);
        }

    }
}

