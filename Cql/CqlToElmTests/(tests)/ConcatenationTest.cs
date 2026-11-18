/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]

    public class ConcatenationTest : Base
    {
        [TestMethod]
        public void AddStringToString()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library AddStringToString version '1.0.0'

                define private Three: 'hello' & 'world'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Concatenate));
            {
                var concatenate = (Concatenate)library.statements[0].expression;
                Assert.IsNotNull(concatenate.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}String", concatenate.resultTypeName.Name);
                Assert.IsNotNull(concatenate.resultTypeSpecifier);
                Assert.IsInstanceOfType(concatenate.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)concatenate.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}String", nts.name.Name);
                Assert.IsNotNull(concatenate.operand);
                Assert.AreEqual(2, concatenate.operand.Length);
                {
                    var lhs = CoalescedOperand(concatenate.operand[0]) as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhsnts.name.Name);
                    Assert.AreEqual("hello", lhs.value);
                }
                {
                    var rhs = CoalescedOperand(concatenate.operand[1]) as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhsnts.name.Name);
                    Assert.AreEqual("world", rhs.value);
                }

                var result = Run(concatenate, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(string));
                Assert.AreEqual("helloworld", result);
            }



        }

        [TestMethod]
        public void AddThreeStrings()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library AddThreeStrings version '1.0.0'

                define private Three: 'hello' & (' ' & 'world')
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Concatenate));
            {
                var concatenate = (Concatenate)library.statements[0].expression;
                Assert.IsNotNull(concatenate.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}String", concatenate.resultTypeName.Name);
                Assert.IsNotNull(concatenate.resultTypeSpecifier);
                Assert.IsInstanceOfType(concatenate.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)concatenate.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}String", nts.name.Name);
                Assert.IsNotNull(concatenate.operand);
                Assert.AreEqual(2, concatenate.operand.Length);
                {
                    var lhs = CoalescedOperand(concatenate.operand[0]) as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhsnts.name.Name);
                }
                {
                    var rhs = CoalescedOperand(concatenate.operand[1]) as Concatenate;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhsnts.name.Name);
                }

                var result = Run(concatenate, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(string));
                Assert.AreEqual("hello world", result);
            }



        }

        /// <summary>
        /// Spec §9.B, Concatenate: "When using &amp;, null arguments are treated as an empty string ('')."
        /// </summary>
        [TestMethod]
        [DataRow("'a' & null", "a")]
        [DataRow("null & 'a'", "a")]
        [DataRow("'John' & null & ' Doe'", "John Doe")]
        [DataRow("(null as String) & (null as String)", "")]
        public void AmpersandTreatsNullAsEmptyString(string expression, string expected)
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library AmpersandTreatsNullAsEmptyString version '1.0.0'

                define private Result: {expression}
                """);
            var concatenate = (Concatenate)library.statements[0].expression;
            Assert.AreEqual(2, concatenate.operand.Length);

            var result = Run(concatenate, library, FhirCqlContext.ForBundle());

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Spec §9.B, Concatenate: "When using +, if either argument is null, the result is null."
        /// </summary>
        [TestMethod]
        public void PlusWithNullIsNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library PlusWithNullIsNull version '1.0.0'

                define private Result: 'a' + null
                """);
            var concatenate = (Concatenate)library.statements[0].expression;
            Assert.IsNotInstanceOfType(concatenate.operand[1], typeof(Coalesce));

            var result = Run(concatenate, library, FhirCqlContext.ForBundle());

            Assert.IsNull(result);
        }

        /// <summary>
        /// Spec §6 Translation Semantics: for &amp;, "a Coalesce(X, '') is applied to each operand" of the Concatenate.
        /// Returns the operand inside that Coalesce.
        /// </summary>
        private static Expression CoalescedOperand(Expression operand)
        {
            Assert.IsInstanceOfType(operand, typeof(Coalesce));
            var coalesce = (Coalesce)operand;
            Assert.AreEqual(2, coalesce.operand.Length);
            Assert.IsInstanceOfType(coalesce.operand[1], typeof(Literal));
            Assert.AreEqual(string.Empty, ((Literal)coalesce.operand[1]).value);
            return coalesce.operand[0];
        }

    }
}
