
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests

{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "AllTrueAllTrue":
		///	( AllTrue({true,true}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AllTrueAllTrue_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AllTrueAllTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AllTrueTrueFirst":
		///	( AllTrue({true,false}) ) = false
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AllTrueTrueFirst_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AllTrueTrueFirst"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AllTrueFalseFirst":
		///	( AllTrue({false,true}) ) = false
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AllTrueFalseFirst_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AllTrueFalseFirst"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AllTrueAllTrueFalseTrue":
		///	( AllTrue({true,false,true}) ) = false
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AllTrueAllTrueFalseTrue_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AllTrueAllTrueFalseTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AllTrueAllFalseTrueFalse":
		///	( AllTrue({false,true,false}) ) = false
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AllTrueAllFalseTrueFalse_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AllTrueAllFalseTrueFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AllTrueNullFirst":
		///	( AllTrue({null,true,true}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AllTrueNullFirst_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AllTrueNullFirst"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AllTrueEmptyList":
		///	( AllTrue({}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AllTrueEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AllTrueEmptyList"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueAllTrue":
		///	( AnyTrue({true,true}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueAllTrue_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueAllTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueAllFalse":
		///	( AnyTrue({false,false}) ) = false
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueAllFalse_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueAllFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueAllTrueFalseTrue":
		///	( AnyTrue({true,false,true}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueAllTrueFalseTrue_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueAllTrueFalseTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueAllFalseTrueFalse":
		///	( AnyTrue({false,true,false}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueAllFalseTrueFalse_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueAllFalseTrueFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueTrueFirst":
		///	( AnyTrue({true,false}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueTrueFirst_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueTrueFirst"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueFalseFirst":
		///	( AnyTrue({false,true}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueFalseFirst_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueFalseFirst"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueNullFirstThenTrue":
		///	( AnyTrue({null,true}) ) = true
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueNullFirstThenTrue_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueNullFirstThenTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueNullFirstThenFalse":
		///	( AnyTrue({null,false}) ) = false
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueNullFirstThenFalse_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueNullFirstThenFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AnyTrueEmptyList":
		///	( AnyTrue({}) ) = false
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AnyTrueEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AnyTrueEmptyList"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "AvgTest1":
		///	( Avg({ 1.0, 2.0, 3.0, 6.0 }) ) = 3.0
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void AvgTest1_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "AvgTest1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CountTest1":
		///	( Count({ 15, 5, 99, null, 1 }) ) = 4
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void CountTest1_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "CountTest1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CountTestDateTime":
		///	( Count({ DateTime(2014), DateTime(2001), DateTime(2010) }) ) = 3
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void CountTestDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "CountTestDateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CountTestTime":
		///	( Count({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 }) ) = 3
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void CountTestTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "CountTestTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CountTestNull":
		///	( Count({}) ) = 0
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void CountTestNull_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "CountTestNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MaxTestInteger":
		///	( Max({ 5, 12, 1, 15, 0, 4, 90, 44 }) ) = 90
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MaxTestInteger_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MaxTestInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MaxTestString":
		///	( Max({ 'hi', 'bye', 'zebra' }) ) = 'zebra'
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MaxTestString_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MaxTestString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MaxTestDateTime":
		///	( Max({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6) }) ) = DateTime(2012, 10, 6)
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MaxTestDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MaxTestDateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MaxTestTime":
		///	( Max({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 }) ) = @T20:59:59.999
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MaxTestTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MaxTestTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MedianTestDecimal":
		///	( Median({6.0, 5.0, 4.0, 3.0, 2.0, 1.0}) ) = 3.5
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MedianTestDecimal_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MedianTestDecimal"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MinTestInteger":
		///	( Min({5, 12, 1, 15, 0, 4, 90, 44}) ) = 0
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MinTestInteger_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MinTestInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MinTestString":
		///	( Min({'hi', 'bye', 'zebra'}) ) = 'bye'
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MinTestString_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MinTestString"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MinTestDateTime":
		///	( Min({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6) }) ) = DateTime(2012, 9, 5)
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MinTestDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MinTestDateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MinTestTime":
		///	( Min({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 }) ) = @T05:59:59.999
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void MinTestTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "MinTestTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ModeTestInteger":
		///	( Mode({ 2, 1, 8, 2, 9, 1, 9, 9 }) ) = 9
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void ModeTestInteger_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "ModeTestInteger"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ModeTestDateTime":
		///	( Mode({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6), DateTime(2012, 9, 5) }) ) = DateTime(2012, 9, 5)
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void ModeTestDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "ModeTestDateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ModeTestTime":
		///	( Mode({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999, @T05:59:59.999 }) ) = @T05:59:59.999
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void ModeTestTime_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "ModeTestTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PopStdDevTest1":
		///	( PopulationStdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 }) ) = 1.41421356
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void PopStdDevTest1_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "PopStdDevTest1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PopVarianceTest1":
		///	( PopulationVariance({ 1.0, 2.0, 3.0, 4.0, 5.0 }) ) = 2.0
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void PopVarianceTest1_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "PopVarianceTest1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "StdDevTest1":
		///	( StdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 }) ) = 1.58113883
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void StdDevTest1_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "StdDevTest1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SumTest1":
		///	( Sum({ 6.0, 2.0, 3.0, 4.0, 5.0 }) ) = 20.0
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void SumTest1_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "SumTest1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SumTestNull":
		///	( Sum({ null, 1, null }) ) = 1
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void SumTestNull_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "SumTestNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "VarianceTest1":
		///	( Variance({ 1.0, 2.0, 3.0, 4.0, 5.0 }) ) = 2.5
		/// </summary>
        [TestCategory("CqlAggregateFunctionsTest")]
        [TestMethod]
        public void VarianceTest1_Test()
        {
            var lambda = LambdasByTestName["CqlAggregateFunctionsTest", "VarianceTest1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
