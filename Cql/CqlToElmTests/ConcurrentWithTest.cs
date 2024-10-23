using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class ConcurrentWithTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        // : ('starts' | 'ends' | 'occurs')? 'same' dateTimePrecision? (relativeQualifier | 'as') ('start' | 'end')?               #concurrentWithIntervalOperatorPhrase
        //relativeQualifier
        //    : 'or before'
        //    | 'or after'
        //    ;

        #region Both point terms

        [TestMethod]
        public void Starts_Days_Or_Before_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_Before_Start: Interval[@2023-01-01, @2023-03-31] starts same day or before start Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Start));
                Assert.IsInstanceOfType(same.operand[1], typeof(Start));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_Days_Or_Before_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_Before_End: Interval[@2023-01-01, @2023-03-31] starts same day or before end Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Start));
                Assert.IsInstanceOfType(same.operand[1], typeof(End));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_Days_Or_After_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_After_Start: Interval[@2023-01-01, @2023-03-31] starts same day or after start Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Start));
                Assert.IsInstanceOfType(same.operand[1], typeof(Start));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Starts_Days_Or_After_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_After_End: Interval[@2023-01-01, @2023-03-31] starts same day or after end Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Start));
                Assert.IsInstanceOfType(same.operand[1], typeof(End));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Ends_Months_Or_Before_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Months_Or_Before_Start: Interval[@2023-01, @2023-03] ends same month or before start Interval[@2023-04, @2023-06]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(End));
                Assert.IsInstanceOfType(same.operand[1], typeof(Start));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Ends_Months_Or_Before_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Months_Or_Before_End: Interval[@2023-01, @2023-03] ends same month or before end Interval[@2023-04, @2023-06]

            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(End));
                Assert.IsInstanceOfType(same.operand[1], typeof(End));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Ends_Months_Or_After_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Months_Or_After_Start: Interval[@2023-01, @2023-03] ends same month or after start Interval[@2023-04, @2023-06]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(End));
                Assert.IsInstanceOfType(same.operand[1], typeof(Start));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Ends_Months_Or_After_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Months_Or_After_End: Interval[@2023-01, @2023-03] ends same month or after end Interval[@2023-04, @2023-06]

            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(End));
                Assert.IsInstanceOfType(same.operand[1], typeof(End));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        #endregion

        #region Right point term only

        [TestMethod]
        public void Days_Or_Before_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_Before_Start: Interval[@2023-01-01, @2023-03-31] same day or before start Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Days_Or_Before_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Days_Or_Before_End: Interval[@2023-01-01, @2023-03-31] same day or before end Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Days_Or_After_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Days_Or_After_Start: Interval[@2023-01-01, @2023-03-31] same day or after start Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Days_Or_After_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Days_Or_After_End: Interval[@2023-01-01, @2023-03-31] same day or after end Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Months_Or_Before_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Months_Or_Before_Start: Interval[@2023-01, @2023-03] same month or before start Interval[@2023-04, @2023-06]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Months_Or_Before_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Months_Or_Before_End: Interval[@2023-01, @2023-03] same month or before end Interval[@2023-04, @2023-06]

            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Months_Or_After_Start()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Months_Or_After_Start: Interval[@2023-01, @2023-03] same month or after start Interval[@2023-04, @2023-06]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Months_Or_After_End()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Months_Or_After_End: Interval[@2023-01, @2023-03] same month or after end Interval[@2023-04, @2023-06]

            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        #endregion

        #region Left point term only

        [TestMethod]
        public void Starts_Days_Or_Before()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_Before: Interval[@2023-01-01, @2023-03-31] starts same day or before Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Ends_Days_Or_Before()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Days_Or_Before: Interval[@2023-01-01, @2023-03-31] ends same day or before Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_Days_Or_After()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_After_Start: Interval[@2023-01-01, @2023-03-31] starts same day or after Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);

                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Ends_Months_Or_Before()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Months_Or_Before: Interval[@2023-01, @2023-03] ends same month or before Interval[@2023-04, @2023-06]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);

                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Ends_Months_Or_After()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Ends_Months_Or_After: Interval[@2023-01, @2023-03] ends same month or after Interval[@2023-04, @2023-06]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);

                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        #endregion

        #region Neither point terms

        [TestMethod]
        public void Days_Or_Before()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Starts_Days_Or_Before: Interval[@2023-01-01, @2023-03-31] same day or before Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrBefore));
            {
                var same = (SameOrBefore)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Days_Or_After()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Days_Or_After: Interval[@2023-01-01, @2023-03-31] same day or after Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameOrAfter));
            {
                var same = (SameOrAfter)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }


        [TestMethod]
        public void Days_Same()
        {
            var library = MakeLibrary(@"
                library ConcurrentWithTest version '1.0.0'

                define private Days_Or_After: Interval[@2023-01-01, @2023-03-31] same day as Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(SameAs));
            {
                var same = (SameAs)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Boolean", same.resultTypeName.Name);
                Assert.IsInstanceOfType(same.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)same.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(same.operand);
                Assert.AreEqual(2, same.operand.Length);
                Assert.IsInstanceOfType(same.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(same.operand[1], typeof(Interval));
                var result = Run(same, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        #endregion

    }
}
