using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Runtime;
using System;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summaray>
		///define "CombineNull":
		///	( Combine(null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void CombineNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "CombineNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "CombineEmptyList":
		///	( Combine({}) ) = ''
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void CombineEmptyList_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "CombineEmptyList"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CombineABC":
		///	( Combine({'a', 'b', 'c'}) ) = 'abc'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void CombineABC_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "CombineABC"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "CombineABCSepDash":
		///	( Combine({'a', 'b', 'c'}, '-') ) = 'a-b-c'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void CombineABCSepDash_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "CombineABCSepDash"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ConcatenateNullNull":
		///	( Concatenate(null, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ConcatenateNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ConcatenateNullNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "ConcatenateANull":
		///	( Concatenate('a', null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ConcatenateANull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ConcatenateANull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "ConcatenateNullB":
		///	( Concatenate(null, 'b') ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ConcatenateNullB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ConcatenateNullB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "ConcatenateAB":
		///	( Concatenate('a', 'b') ) = 'ab'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ConcatenateAB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ConcatenateAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ConcatenateABWithAdd":
		///	( 'a' + 'b' ) = 'ab'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ConcatenateABWithAdd_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ConcatenateABWithAdd"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EndsWithNull":
		///	( EndsWith(null, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void EndsWithNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "EndsWithNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "EndsWithTrue":
		///	( EndsWith('Chris Schuler is the man!!', 'n!!') ) = true
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void EndsWithTrue_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "EndsWithTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "EndsWithFalse":
		///	( EndsWith('Chris Schuler is the man!!', 'n!') ) = false
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void EndsWithFalse_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "EndsWithFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexerNullNull":
		///	( Indexer(null as String, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void IndexerNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "IndexerNullNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexerANull":
		///	( Indexer('a', null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void IndexerANull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "IndexerANull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexerNull1String":
		///	( Indexer(null as String, 1) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void IndexerNull1String_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "IndexerNull1String"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexerAB0":
		///	( Indexer('ab', 0) ) = 'a'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void IndexerAB0_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "IndexerAB0"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexerAB1":
		///	( Indexer('ab', 1) ) = 'b'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void IndexerAB1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "IndexerAB1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "IndexerAB2":
		///	( Indexer('ab', 2) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void IndexerAB2_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "IndexerAB2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "IndexerABNeg1":
		///	( Indexer('ab', -1) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void IndexerABNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "IndexerABNeg1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "LastPositionOfNull":
		///	( LastPositionOf(null, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LastPositionOfNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LastPositionOfNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "LastPositionOfNull1":
		///	( LastPositionOf(null, 'hi') ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LastPositionOfNull1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LastPositionOfNull1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "LastPositionOfNull2":
		///	( LastPositionOf('hi', null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LastPositionOfNull2_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LastPositionOfNull2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "LastPositionOf1":
		///	( LastPositionOf('hi', 'Ohio is the place to be!') ) = 1
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LastPositionOf1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LastPositionOf1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LastPositionOf2":
		///	( LastPositionOf('hi', 'Say hi to Ohio!') ) = 11
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LastPositionOf2_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LastPositionOf2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthNullString":
		///	( Length(null as String) ) = 0
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LengthNullString_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LengthNullString"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthEmptyString":
		///	( Length('') ) = 0
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LengthEmptyString_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LengthEmptyString"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthA":
		///	( Length('a') ) = 1
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LengthA_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LengthA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LengthAB":
		///	( Length('ab') ) = 2
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LengthAB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LengthAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowerNull":
		///	( Lower(null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LowerNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LowerNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "LowerEmpty":
		///	( Lower('') ) = ''
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LowerEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LowerEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowerA":
		///	( Lower('A') ) = 'a'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LowerA_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LowerA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowerB":
		///	( Lower('b') ) = 'b'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LowerB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LowerB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "LowerAB":
		///	( Lower('Ab') ) = 'ab'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void LowerAB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "LowerAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MatchesNull":
		///	( Matches('Not all who wander are lost', null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "MatchesNumberFalse":
		///	( Matches('Not all who wander are lost', '.*\\d+') ) = false
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesNumberFalse_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesNumberFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MatchesNumberTrue":
		///	( Matches('Not all who wander are lost - circa 2017', '.*\\d+') ) = true
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesNumberTrue_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesNumberTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MatchesAllTrue":
		///	( Matches('Not all who wander are lost', '.*') ) = true
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesAllTrue_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesAllTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MatchesWordsAndSpacesTrue":
		///	( Matches('Not all who wander are lost', '[\\w|\\s]+') ) = true
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesWordsAndSpacesTrue_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesWordsAndSpacesTrue"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MatchesWordsAndSpacesFalse":
		///	( Matches('Not all who wander are lost - circa 2017', '[\\w]+') ) = false
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesWordsAndSpacesFalse_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesWordsAndSpacesFalse"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MatchesNotWords":
		///	( Matches('   ', '\\W+') ) = true
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesNotWords_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesNotWords"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "MatchesWhiteSpace":
		///	( Matches(' \n\t', '\\s+') ) = true
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void MatchesWhiteSpace_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "MatchesWhiteSpace"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PositionOfNullNull":
		///	( PositionOf(null, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void PositionOfNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "PositionOfNullNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "PositionOfANull":
		///	( PositionOf('a', null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void PositionOfANull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "PositionOfANull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "PositionOfNullA":
		///	( PositionOf(null, 'a') ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void PositionOfNullA_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "PositionOfNullA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "PositionOfAInAB":
		///	( PositionOf('a', 'ab') ) = 0
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void PositionOfAInAB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "PositionOfAInAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PositionOfBInAB":
		///	( PositionOf('b', 'ab') ) = 1
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void PositionOfBInAB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "PositionOfBInAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "PositionOfCInAB":
		///	( PositionOf('c', 'ab') ) = -1
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void PositionOfCInAB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "PositionOfCInAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ReplaceMatchesNull":
		///	( ReplaceMatches('Not all who wander are lost', null, 'But I am...') ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ReplaceMatchesNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ReplaceMatchesNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "ReplaceMatchesAll":
		///	( ReplaceMatches('Not all who wander are lost', 'Not all who wander are lost', 'But still waters run deep') ) = 'But still waters run deep'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ReplaceMatchesAll_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ReplaceMatchesAll"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ReplaceMatchesMany":
		///	( ReplaceMatches('Who put the bop in the bop she bop she bop?', 'bop', 'bang') ) = 'Who put the bang in the bang she bang she bang?'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ReplaceMatchesMany_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ReplaceMatchesMany"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "ReplaceMatchesSpaces":
		///	( ReplaceMatches('All that glitters is not gold', '\\s', '$') ) = 'All$that$glitters$is$not$gold'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void ReplaceMatchesSpaces_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "ReplaceMatchesSpaces"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SplitNullNull":
		///	( Split(null, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SplitNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SplitNullNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SplitNullComma":
		///	( Split(null, ',') ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SplitNullComma_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SplitNullComma"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SplitABNull":
		///	( Split('a,b', null) ) = {'a,b'}
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SplitABNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SplitABNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SplitABDash":
		///	( Split('a,b', '-') ) = {'a,b'}
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SplitABDash_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SplitABDash"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SplitABComma":
		///	( Split('a,b', ',') ) = {'a','b'}
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SplitABComma_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SplitABComma"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "StartsWithNull":
		///	( StartsWith(null, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void StartsWithNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "StartsWithNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "StartsWithNull1":
		///	( StartsWith('hi', null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void StartsWithNull1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "StartsWithNull1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "StartsWithNull2":
		///	( StartsWith(null, 'hi') ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void StartsWithNull2_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "StartsWithNull2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "StartsWithTrue1":
		///	( StartsWith('Breathe deep the gathering gloom', 'Bre') ) = true
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void StartsWithTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "StartsWithTrue1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "StartsWithFalse1":
		///	( StartsWith('Breathe deep the gathering gloom', 'bre') ) = false
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void StartsWithFalse1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "StartsWithFalse1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SubstringNullNull":
		///	( Substring(null, null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringNullNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringNullNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SubstringANull":
		///	( Substring('a', null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringANull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringANull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SubstringNull1":
		///	( Substring(null, 1) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringNull1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringNull1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SubstringAB0":
		///	( Substring('ab', 0) ) = 'ab'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringAB0_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringAB0"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SubstringAB1":
		///	( Substring('ab', 1) ) = 'b'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringAB1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringAB1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SubstringAB2":
		///	( Substring('ab', 2) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringAB2_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringAB2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SubstringABNeg1":
		///	( Substring('ab', -1) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringABNeg1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringABNeg1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "SubstringAB0To1":
		///	( Substring('ab', 0, 1) ) = 'a'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringAB0To1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringAB0To1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SubstringABC1To1":
		///	( Substring('abc', 1, 1) ) = 'b'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringABC1To1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringABC1To1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "SubstringAB0To3":
		///	( Substring('ab', 0, 3) ) = 'ab'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void SubstringAB0To3_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "SubstringAB0To3"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UpperNull":
		///	( Upper(null) ) = null
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void UpperNull_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "UpperNull"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(null, result);
        }
                                        
        /// <summaray>
		///define "UpperEmpty":
		///	( Upper('') ) = ''
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void UpperEmpty_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "UpperEmpty"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UpperA":
		///	( Upper('a') ) = 'A'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void UpperA_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "UpperA"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UpperB":
		///	( Upper('B') ) = 'B'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void UpperB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "UpperB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "UpperAB":
		///	( Upper('aB') ) = 'AB'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void UpperAB_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "UpperAB"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "QuantityToString":
		///	( ToString(125 'cm') ) = '125cm'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void QuantityToString_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "QuantityToString"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeToString1":
		///	( ToString(DateTime(2000, 1, 1)) ) = '2000-01-01'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void DateTimeToString1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "DateTimeToString1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "DateTimeToString2":
		///	( ToString(DateTime(2000, 1, 1, 15, 25, 25, 300)) ) = '2000-01-01T15:25:25.300'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void DateTimeToString2_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "DateTimeToString2"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }

        /// <summaray>
        ///define "DateTimeToString3":
        ///	( ToString(DateTime(2000, 1, 1, 8, 25, 25, 300, -7)) ) = '2000-01-01T08:25:25.300'
        /// </summary>
        /// <remarks>
        /// The specification clearly states:
        /// The result of any ToString must be round-trippable back to the source value.
        /// If we ignore timezone in the call to ToString, this is no longer true.
        /// </remarks>
        [Ignore(DoesNotConformToSpec)]
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void DateTimeToString3_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "DateTimeToString3"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
        /// <summaray>
		///define "TimeToString1":
		///	( ToString(@T09:30:01.003) ) = '09:30:01.003'
		/// </summary>
        [TestCategory("CqlStringOperatorsTest")]
        [TestMethod]
        public void TimeToString1_Test()
        {
            var lambda = LambdasByTestName["CqlStringOperatorsTest", "TimeToString1"];
            var function = (Func<RuntimeContext, bool?>)lambda.Compile();
            bool? result = function(RuntimeContext);
            Assert.AreEqual(true, result);
        }
                                        
    }
}
                
