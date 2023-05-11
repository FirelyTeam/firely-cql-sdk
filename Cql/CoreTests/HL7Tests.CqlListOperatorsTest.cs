using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;


namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "simpleSortAsc":
		///	( ({4, 5, 1, 6, 2, 1}) sL sort asc ) = {1, 1, 2, 4, 5, 6}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void simpleSortAsc_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "simpleSortAsc"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "simpleSortDesc":
		///	( ({4, 5, 1, 6, 2, 1}) sL sort desc ) = {6, 5, 4, 2, 1, 1}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void simpleSortDesc_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "simpleSortDesc"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "simpleSortStringAsc":
		///	( ({'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo'}) sls sort asc ) = {'Armadillo', 'Wolf', 'aardvark', 'alligator', 'back', 'iguana', 'zebra'}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void simpleSortStringAsc_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "simpleSortStringAsc"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "simpleSortStringDesc":
		///	( ({'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo'}) sls sort desc ) = {'zebra', 'iguana', 'back', 'alligator', 'aardvark', 'Wolf', 'Armadillo'}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void simpleSortStringDesc_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "simpleSortStringDesc"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "SortDatesAsc":
        ///	( ({ DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5) }) S sort asc ) = {DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5), DateTime(2012, 10, 5, 10)}
        /// </summary>
        /// <remarks>
        /// It is not clear why DateTime(2012, 10, 5) is necessarily less than DateTime(2012, 10, 5, 10)
        /// </remarks>
        [TestCategory("CqlListOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void SortDatesAsc_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SortDatesAsc"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SortDatesDesc":
		///	( ({ DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5) }) S sort desc ) = {DateTime(2012, 10, 5, 10), DateTime(2012, 10, 5), DateTime(2012, 1, 1, 12), DateTime(2012, 1, 1)}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void SortDatesDesc_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SortDatesDesc"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ContainsABNullHasNull":
		///	( { 'a', 'b', null } contains null ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsABNullHasNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsABNullHasNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "ContainsNullFirst":
		///	( { null, 'b', 'c' } contains 'a' ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsNullFirst_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsNullFirst"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ContainsABCHasA":
		///	( { 'a', 'b', 'c' } contains 'a' ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsABCHasA_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsABCHasA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ContainsJan2012True":
		///	( { DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 1, 1) } contains DateTime(2012, 1, 1) ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsJan2012True_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsJan2012True"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ContainsJan2012False":
		///	( { DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 1) } contains DateTime(2012, 1, 1) ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsJan2012False_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsJan2012False"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ContainsTimeTrue":
		///	( { @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T05:59:59.999 ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ContainsTimeFalse":
		///	( { @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T08:59:59.999 ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ContainsNullLeft":
		///	( null contains 'a' ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ContainsNullLeft_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ContainsNullLeft"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DescendentsEmptyList":
		///	( (null).descendents() ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DescendentsEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DescendentsEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "DistinctEmptyList":
		///	( distinct {} ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DistinctEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DistinctEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DistinctNullNullNull":
		///	( ( ( distinct { null, null, null } ) = { null } ) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DistinctNullNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DistinctNullNullNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "DistinctANullANull":
		///	( distinct { 'a', null, 'a', null} ) = {'a', null}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DistinctANullANull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DistinctANullANull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Distinct112233":
		///	( distinct { 1, 1, 2, 2, 3, 3} ) = {1,2,3}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Distinct112233_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Distinct112233"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Distinct123123":
		///	( distinct { 1, 2, 3, 1, 2, 3} ) = {1,2,3}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Distinct123123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Distinct123123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DistinctAABBCC":
		///	( distinct { 'a', 'a', 'b', 'b', 'c', 'c'} ) = {'a','b','c'}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DistinctAABBCC_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DistinctAABBCC"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DistinctABCABC":
		///	( distinct { 'a', 'b', 'c', 'a', 'b', 'c'} ) = {'a','b','c'}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DistinctABCABC_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DistinctABCABC"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DistinctDateTime":
		///	( distinct { DateTime(2012, 10, 5), DateTime(2012, 1, 1), DateTime(2012, 1, 1)} ) = { DateTime(2012, 10, 5), DateTime(2012, 1, 1)}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DistinctDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DistinctDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DistinctTime":
		///	( distinct { @T15:59:59.999, @T20:59:59.999 } ) = { @T15:59:59.999, @T20:59:59.999 }
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void DistinctTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "DistinctTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EqualNullNull":
		///	( {null} = {null} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualNullNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "EqualEmptyListNull":
		///	( {} = null ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualEmptyListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualEmptyListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "EqualNullEmptyList":
		///	( null = {} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualNullEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualNullEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "EqualEmptyListAndEmptyList":
		///	( {} = {} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualEmptyListAndEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualEmptyListAndEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Equal12And123":
		///	( { 1, 2 } = { 1, 2, 3 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Equal12And123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Equal12And123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Equal123And12":
		///	( { 1, 2, 3 } = { 1, 2 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Equal123And12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Equal123And12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Equal123And123":
		///	( { 1, 2, 3 } = { 1, 2, 3 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Equal123And123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Equal123And123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EqualDateTimeTrue":
		///	( {DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = {DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EqualDateTimeFalse":
		///	( {DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = {DateTime(2012, 1, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EqualTimeTrue":
		///	( { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EqualTimeFalse":
		///	( { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T10:59:59.999, @T20:59:59.999, @T20:59:59.999 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EqualTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EqualTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExceptEmptyListAndEmptyList":
		///	( {} except {} ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExceptEmptyListAndEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExceptEmptyListAndEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Except1234And23":
		///	( { 1, 2, 3, 4 } except { 2, 3 } ) = { 1, 4 }
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Except1234And23_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Except1234And23"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Except23And1234":
		///	( { 2, 3 } except { 1, 2, 3, 4 } ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Except23And1234_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Except23And1234"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExceptDateTimeList":
		///	( { DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2010, 1, 1)} except {DateTime(2014, 12, 10), DateTime(2010, 1, 1) } ) = {@2012-05-10}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExceptDateTimeList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExceptDateTimeList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExceptTimeList":
		///	( { @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 } except { @T20:59:59.999, @T12:59:59.999 } ) = {@T15:59:59.999}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExceptTimeList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExceptTimeList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExceptNullRight":
		///	( { 1, 4 } except null ) = {1, 4}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExceptNullRight_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExceptNullRight"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExistsEmpty":
		///	( Exists({}) ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExistsEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExistsEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExistsListNull":
		///	( Exists({ null }) ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExistsListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExistsListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Exists1":
		///	( Exists({ 1 }) ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Exists1_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Exists1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Exists12":
		///	( Exists({ 1, 2 }) ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Exists12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Exists12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExistsDateTime":
		///	( Exists({ DateTime(2012, 5, 10), DateTime(2014, 12, 10) }) ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExistsDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExistsDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExistsTime":
		///	( Exists({ @T15:59:59.999, @T20:59:59.999 }) ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExistsTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExistsTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ExistsNull":
		///	( Exists(null) ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ExistsNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ExistsNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FlattenEmpty":
		///	( Flatten({{},{}}) ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FlattenEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FlattenEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FlattenListNullAndNull":
		///	( Flatten({{null}, {null}}) = {null, null} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FlattenListNullAndNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FlattenListNullAndNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "FlattenList12And34":
		///	( Flatten({{1,2}, {3,4}}) ) = {1,2,3,4}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FlattenList12And34_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FlattenList12And34"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FlattenDateTime":
		///	( Flatten({ {DateTime(2012, 5, 10)}, {DateTime(2014, 12, 10)} }) ) = { DateTime(2012, 5, 10), DateTime(2014, 12, 10) }
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FlattenDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FlattenDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FlattenTime":
		///	( Flatten({ {@T15:59:59.999}, {@T20:59:59.999} }) ) = { @T15:59:59.999, @T20:59:59.999 }
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FlattenTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FlattenTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FirstEmpty":
		///	( First({}) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FirstEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FirstEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "FirstNull1":
		///	( First({ null, 1 }) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FirstNull1_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FirstNull1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "First1Null":
		///	( First({ 1, null }) ) = 1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void First1Null_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "First1Null"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "First12":
		///	( First({ 1, 2 }) ) = 1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void First12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "First12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FirstDateTime":
		///	( First({ DateTime(2012, 5, 10), DateTime(2014, 12, 10) }) ) = DateTime(2012, 5, 10)
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FirstDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FirstDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "FirstTime":
		///	( First({ @T15:59:59.999, @T20:59:59.999 }) ) = @T15:59:59.999
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void FirstTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "FirstTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "InNullEmpty":
		///	( null in {} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void InNullEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "InNullEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "InNullAnd1Null":
		///	( null in { 1, null } ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void InNullAnd1Null_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "InNullAnd1Null"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "In1Null":
		///	( 1 in null ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void In1Null_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "In1Null"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "In1And12":
		///	( 1 in { 1, 2 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void In1And12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "In1And12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "In3And12":
		///	( 3 in { 1, 2 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void In3And12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "In3And12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "InDateTimeTrue":
		///	( DateTime(2012, 5, 10) in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void InDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "InDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "InDateTimeFalse":
		///	( DateTime(2012, 6, 10) in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void InDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "InDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "InTimeTrue":
		///	( @T15:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void InTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "InTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "InTimeFalse":
		///	( @T16:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void InTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "InTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludesEmptyAndEmpty":
		///	( {} includes {} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludesEmptyAndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesEmptyAndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludesListNullAndListNull":
		///	( {null} includes {null} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void IncludesListNullAndListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesListNullAndListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Includes123AndEmpty":
		///	( {1, 2, 3} includes {} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Includes123AndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Includes123AndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Includes123And2":
		///	( {1, 2, 3} includes {2} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Includes123And2_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Includes123And2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Includes123And4":
		///	( {1, 2, 3} includes {4} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Includes123And4_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Includes123And4"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludesDateTimeTrue":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes {DateTime(2012, 5, 10)} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludesDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludesDateTimeFalse":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes {DateTime(2012, 5, 11)} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludesDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludesTimeTrue":
		///	( { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T15:59:59.999 ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludesTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludesTimeFalse":
		///	( { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T16:59:59.999 ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludesTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludesNullLeft":
		///	( null includes {2} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludesNullLeft_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesNullLeft"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IncludesNullRight":
		///	( {'s', 'a', 'm'} includes null ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludesNullRight_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludesNullRight"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IncludedInEmptyAndEmpty":
		///	( {} included in {} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInEmptyAndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInEmptyAndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedInListNullAndListNull":
		///	( { null } included in { null } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void IncludedInListNullAndListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInListNullAndListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedInEmptyAnd123":
		///	( {} included in { 1, 2, 3 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInEmptyAnd123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInEmptyAnd123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedIn2And123":
		///	( { 2 } included in { 1, 2, 3 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedIn2And123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedIn2And123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedIn4And123":
		///	( { 4 } included in { 1, 2, 3 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedIn4And123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedIn4And123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedInDateTimeTrue":
		///	( { DateTime(2012, 5, 10)} included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedInDateTimeFalse":
		///	( {DateTime(2012, 5, 11)} included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedInTimeTrue":
		///	( @T15:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedInTimeFalse":
		///	( @T16:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IncludedInNullLeft":
		///	( null included in {2} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInNullLeft_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInNullLeft"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IncludedInNullRight":
		///	( {'s', 'a', 'm'} included in null ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IncludedInNullRight_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IncludedInNullRight"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexerNull1List":
		///	( (null as List<System.Any>)[1] ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexerNull1List_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexerNull1List"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Indexer0Of12":
		///	( { 1, 2 }[0] ) = 1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Indexer0Of12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Indexer0Of12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Indexer1Of12":
		///	( { 1, 2 }[1] ) = 2
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Indexer1Of12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Indexer1Of12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Indexer2Of12":
		///	( { 1, 2 }[2] ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Indexer2Of12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Indexer2Of12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexerNeg1Of12":
		///	( { 1, 2 }[-1] ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexerNeg1Of12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexerNeg1Of12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexerDateTime":
		///	( { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }[1] ) = DateTime(2012, 5, 10)
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexerDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexerDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexerTime":
		///	( { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }[1] ) = @T15:59:59.999
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexerTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexerTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexOfEmptyNull":
		///	( IndexOf({}, null) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOfEmptyNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOfEmptyNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexOfNullEmpty":
		///	( IndexOf(null, {}) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOfNullEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOfNullEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexOfNullIn1Null":
		///	( IndexOf({ 1, null }, null) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOfNullIn1Null_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOfNullIn1Null"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexOf1In12":
		///	( IndexOf({ 1, 2 }, 1) ) = 0
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOf1In12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOf1In12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexOf2In12":
		///	( IndexOf({ 1, 2 }, 2) ) = 1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOf2In12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOf2In12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexOf3In12":
		///	( IndexOf({ 1, 2 }, 3) ) = -1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOf3In12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOf3In12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexOfDateTime":
		///	( IndexOf({ DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }, DateTime(2014, 12, 10)) ) = 2
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOfDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOfDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexOfTime":
		///	( IndexOf({ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }, @T15:59:59.999) ) = 1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IndexOfTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IndexOfTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IntersectEmptyListAndEmptyList":
		///	( {} intersect {} ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IntersectEmptyListAndEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IntersectEmptyListAndEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Intersect1234And23":
		///	( { 1, 2, 3, 4 } intersect { 2, 3 } ) = { 2, 3 }
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Intersect1234And23_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Intersect1234And23"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Intersect23And1234":
		///	( {2, 3} intersect { 1, 2, 3, 4 } ) = { 2, 3 }
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Intersect23And1234_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Intersect23And1234"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IntersectDateTime":
		///	( { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) } intersect { DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2000, 5, 5) } ) = {@2012-05-10, @2014-12-10}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IntersectDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IntersectDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IntersectTime":
		///	( { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } intersect { @T01:29:15.156, @T15:59:59.999, @T20:59:59.999 } ) = {@T15:59:59.999, @T20:59:59.999}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void IntersectTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "IntersectTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LastEmpty":
		///	( Last({}) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LastEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LastEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "LastNull1":
		///	( Last({null, 1}) ) = 1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LastNull1_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LastNull1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Last1Null":
		///	( Last({1, null}) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Last1Null_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Last1Null"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Last12":
		///	( Last({1, 2}) ) = 2
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Last12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Last12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LastDateTime":
		///	( Last({DateTime(2012, 5, 10), DateTime(2014, 12, 10)}) ) = DateTime(2014, 12, 10)
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LastDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LastDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LastTime":
		///	( Last({ @T15:59:59.999, @T20:59:59.999 }) ) = @T20:59:59.999
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LastTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LastTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthEmptyList":
		///	( Length({}) ) = 0
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LengthEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LengthEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthNull1":
		///	( Length({null, 1}) ) = 2
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LengthNull1_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LengthNull1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Length1Null":
		///	( Length({1, null}) ) = 2
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Length1Null_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Length1Null"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Length12":
		///	( Length({1, 2}) ) = 2
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Length12_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Length12"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthDateTime":
		///	( Length({DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}) ) = 3
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LengthDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LengthDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthTime":
		///	( Length({ @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999 }) ) = 6
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LengthTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LengthTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthNullList":
		///	( Length(null as String) ) = 0
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void LengthNullList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "LengthNullList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentEmptyAndEmpty":
		///	( {} ~ {} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentEmptyAndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentEmptyAndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentABCAndABC":
		///	( { 'a', 'b', 'c' } ~ { 'a', 'b', 'c' } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentABCAndABC_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentABCAndABC"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentABCAndAB":
		///	( { 'a', 'b', 'c' } ~ { 'a', 'b' } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentABCAndAB_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentABCAndAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentABCAnd123":
		///	( { 'a', 'b', 'c' } ~ { 1, 2, 3 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentABCAnd123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentABCAnd123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Equivalent123AndABC":
		///	( { 1, 2, 3 } ~ { 'a', 'b', 'c' } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Equivalent123AndABC_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Equivalent123AndABC"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Equivalent123AndString123":
		///	( { 1, 2, 3 } ~ { '1', '2', '3' } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Equivalent123AndString123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Equivalent123AndString123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentDateTimeTrue":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentDateTimeNull":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentDateTimeNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentDateTimeNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentDateTimeFalse":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 1)} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentTimeTrue":
		///	( { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentTimeNull":
		///	( { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999, null } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentTimeNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentTimeNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EquivalentTimeFalse":
		///	( { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.995 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EquivalentTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EquivalentTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EmptyIsNotNull":
		///	( ( {} is not null ) ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void EmptyIsNotNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "EmptyIsNotNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualEmptyAndEmpty":
		///	( {} != {} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualEmptyAndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualEmptyAndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualABCAndABC":
		///	( { 'a', 'b', 'c' } != { 'a', 'b', 'c' } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualABCAndABC_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualABCAndABC"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualABCAndAB":
		///	( { 'a', 'b', 'c' } != { 'a', 'b' } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualABCAndAB_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualABCAndAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualABCAnd123":
		///	( { 'a', 'b', 'c' } != { 1, 2, 3 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualABCAnd123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualABCAnd123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqual123AndABC":
		///	( { 1, 2, 3 } != { 'a', 'b', 'c' } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqual123AndABC_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqual123AndABC"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqual123AndString123":
		///	( { 1, 2, 3 } != { '1', '2', '3' } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqual123AndString123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqual123AndString123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualDateTimeTrue":
		///	( {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 1, 0, 0, 0, 0)} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualDateTimeFalse":
		///	( {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualTimeTrue":
		///	( { @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "NotEqualTimeFalse":
		///	( { @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:49.999 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void NotEqualTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "NotEqualTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperContainsNullRightFalse":
		///	( {'s', 'u', 'n'} properly includes null ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperContainsNullRightFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperContainsNullRightFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperContainsNullRightTrue":
		///	( {'s', 'u', 'n', null} properly includes null ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void ProperContainsNullRightTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperContainsNullRightTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperContainsTimeTrue":
		///	( { @T15:59:59, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59 ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperContainsTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperContainsTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperContainsTimeFalse":
		///	( { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59 ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperContainsTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperContainsTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperInNullRightFalse":
		///	( null properly included in {'s', 'u', 'n'} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperInNullRightFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperInNullRightFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperInNullRightTrue":
		///	( null properly included in {'s', 'u', 'n', null} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [Ignore(DocumentationUnclear)]
        [TestMethod]
        public void ProperInNullRightTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperInNullRightTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperInTimeTrue":
		///	( @T15:59:59 properly included in { @T15:59:59, @T20:59:59.999, @T20:59:49.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperInTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperInTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperInTimeFalse":
		///	( @T15:59:59 properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperInTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperInTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludesEmptyAndEmpty":
		///	( {} properly includes {} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludesEmptyAndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludesEmptyAndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludesListNullAndListNull":
		///	( {null} properly includes {null} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludesListNullAndListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludesListNullAndListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludes123AndEmpty":
		///	( {1, 2, 3} properly includes {} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludes123AndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludes123AndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludes123And2":
		///	( {1, 2, 3} properly includes {2} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludes123And2_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludes123And2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludes123And4":
		///	( {1, 2, 3} properly includes {4} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludes123And4_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludes123And4"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludesDateTimeTrue":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes {DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludesDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludesDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludesDateTimeFalse":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludesDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludesDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludesTimeTrue":
		///	( { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludesTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludesTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludesTimeFalse":
		///	( { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludesTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludesTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperlyIncludesNullLeft":
		///	( null properly includes {2} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperlyIncludesNullLeft_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperlyIncludesNullLeft"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedInEmptyAndEmpty":
		///	( {} properly included in {} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedInEmptyAndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedInEmptyAndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedInListNullAndListNull":
		///	( {null} properly included in {null} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedInListNullAndListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedInListNullAndListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedInEmptyAnd123":
		///	( {} properly included in {1, 2, 3} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedInEmptyAnd123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedInEmptyAnd123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedIn2And123":
		///	( {2} properly included in {1, 2, 3} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedIn2And123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedIn2And123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedIn4And123":
		///	( {4} properly included in {1, 2, 3} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedIn4And123_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedIn4And123"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedInDateTimeTrue":
		///	( {DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedInDateTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedInDateTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedInDateTimeFalse":
		///	( {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedInDateTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedInDateTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedInTimeTrue":
		///	( { @T15:59:59.999, @T20:59:59.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } ) = true
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedInTimeTrue_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedInTimeTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperIncludedInTimeFalse":
		///	( { @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } ) = false
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperIncludedInTimeFalse_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperIncludedInTimeFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ProperlyIncludedInNulRight":
		///	( {'s', 'u', 'n'} properly included in null ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void ProperlyIncludedInNulRight_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "ProperlyIncludedInNulRight"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SingletonFromEmpty":
		///	( singleton from {} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SingletonFromEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SingletonFromEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SingletonFromListNull":
		///	( singleton from {null} ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SingletonFromListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SingletonFromListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SingletonFrom1":
		///	( singleton from { 1 } ) = 1
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SingletonFrom1_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SingletonFrom1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SingletonFromDateTime":
		///	( singleton from { DateTime(2012, 5, 10) } ) = DateTime(2012, 5, 10)
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SingletonFromDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SingletonFromDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SingletonFromTime":
		///	( singleton from { @T15:59:59.999 } ) = @T15:59:59.999
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SingletonFromTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SingletonFromTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SkipNull":
		///	( Skip(null, 3) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SkipNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SkipNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SkipEven":
		///	( Skip({1,2,3,4,5}, 2) ) = {3, 4, 5}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SkipEven_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SkipEven"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SkipOdd":
		///	( Skip({1,2,3,4,5}, 3) ) = {4, 5}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SkipOdd_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SkipOdd"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SkipNone":
		///	( Skip({1,2,3,4,5}, 0) ) = {1,2,3,4,5}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SkipNone_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SkipNone"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SkipAll":
		///	( Skip({1,2,3,4,5}, 5) ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void SkipAll_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "SkipAll"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TailNull":
		///	( Tail(null) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TailNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TailNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "TailEven":
		///	( Tail({1,2,3,4}) ) = {2,3,4}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TailEven_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TailEven"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TailOdd":
		///	( Tail({1,2,3,4,5}) ) = {2,3,4,5}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TailOdd_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TailOdd"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TailEmpty":
		///	( Tail({}) ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TailEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TailEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TailOneElement":
		///	( Tail({1}) ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TailOneElement_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TailOneElement"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TakeNull":
		///	( Take(null, 3) ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TakeNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TakeNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "TakeNullEmpty":
		///	( Take({1,2,3}, null as Integer) ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TakeNullEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TakeNullEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TakeEmpty":
		///	( Take({1,2,3}, 0) ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TakeEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TakeEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TakeEven":
		///	( Take({1,2,3,4}, 2) ) = {1, 2}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TakeEven_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TakeEven"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TakeOdd":
		///	( Take({1,2,3,4}, 3) ) = {1, 2, 3}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TakeOdd_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TakeOdd"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TakeAll":
		///	( Take({1,2,3,4}, 4) ) = {1, 2, 3, 4}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void TakeAll_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "TakeAll"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UnionEmptyAndEmpty":
		///	( {} union {} ) = {}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void UnionEmptyAndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "UnionEmptyAndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UnionListNullAndListNull":
		///	(  ( ( { null } union { null } ) = {null} ) = null ) = null
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void UnionListNullAndListNull_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "UnionListNullAndListNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "Union123AndEmpty":
		///	( { 1, 2, 3 } union {} ) = {1, 2, 3}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Union123AndEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Union123AndEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Union123And2":
		///	( { 1, 2, 3 } union { 2 } ) = {1, 2, 3 }
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Union123And2_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Union123And2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "Union123And4":
		///	( { 1, 2, 3 } union { 4 } ) = {1, 2, 3, 4}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void Union123And4_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "Union123And4"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UnionDateTime":
		///	( { DateTime(2001, 9, 11)} union {DateTime(2012, 5, 10), DateTime(2014, 12, 10) } ) = {@2001-09-11, @2012-05-10, @2014-12-10}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void UnionDateTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "UnionDateTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UnionTime":
		///	( { @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 } union { @T10:59:59.999 } ) = {@T15:59:59.999, @T20:59:59.999, @T12:59:59.999, @T10:59:59.999}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void UnionTime_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "UnionTime"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "intList":
		///	( { 3, 2, 1 } ) = {3, 2, 1}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void intList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "intList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "decimalList":
		///	( { 3.8, 2.4, 1.9 } ) = {3.8, 2.4, 1.9}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void decimalList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "decimalList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "quantityList":
		///	( { 19.99 'lbs', 17.33 'lbs', 10.66 'lbs' } ) = {19.99 'lbs', 17.33 'lbs', 10.66 'lbs'}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void quantityList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "quantityList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "dateTimeList":
		///	( { DateTime(2016), DateTime(2015), DateTime(2010) } ) = {@2016, @2015, @2010}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void dateTimeList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "dateTimeList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "timeList":
		///	( { @T15:59:59.999, @T15:12:59.999, @T15:12:13.999 } ) = {@T15:59:59.999, @T15:12:59.999, @T15:12:13.999}
		/// </summary>
        [TestCategory("CqlListOperatorsTest")]
        [TestMethod]
        public void timeList_Test()
        {
            var lambda = LambdasByTestName["CqlListOperatorsTest", "timeList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
