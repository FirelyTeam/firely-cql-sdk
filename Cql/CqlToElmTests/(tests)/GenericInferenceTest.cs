/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Expression = Hl7.Cql.Elm.Expression;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// A generic operand that an argument of <c>Any</c> (or a list or interval of it) matches without binding its
    /// parameter gets the parameter bound to <c>Any</c>, so the call is typed by its signature with <c>Any</c> in place of the
    /// parameter (for example <c>Interval&lt;Any&gt;</c>) instead of failing translation.
    /// </summary>
    [TestClass]
    public class GenericInferenceTest : Base
    {
        [TestMethod]
        public void Coalesce_Of_Intervals_Of_Any_Types_As_Interval_Of_Any()
        {
            // Coalesce over intervals resolves only through interval promotion and demotion until a generic parameter
            // can bind to an interval type (#1673).
            var library = CreateCqlToolkit(EnableIntervalPromotion: true, EnableIntervalDemotion: true).MakeLibrary("""
                library GenericInferenceTest version '1.0.0'

                define C: Coalesce(Interval[null, null], Interval[null, null])
                """);

            var coalesce = library.statements.Single(s => s.name == "C").expression.Should().BeOfType<Coalesce>().Subject;
            coalesce.resultTypeSpecifier.Should().Be(SystemTypes.AnyType.ToIntervalType());
            ShouldHaveNoUnboundParameters(coalesce.operand);
        }

        [TestMethod]
        public void Coalesce_Of_Lists_Of_Any_With_List_Demotion_Types_As_List_Of_Any()
        {
            var library = CreateCqlToolkit(DisableListDemotion: false).MakeLibrary("""
                library GenericInferenceTest version '1.0.0'

                define C: Coalesce({ null }, { null })
                """);

            var coalesce = library.statements.Single(s => s.name == "C").expression.Should().BeOfType<Coalesce>().Subject;
            coalesce.resultTypeSpecifier.Should().Be(SystemTypes.AnyType.ToListType());
            ShouldHaveNoUnboundParameters(coalesce.operand);
        }

        /// <summary>
        /// Overload sets that combine specialisations for fixed types with a generic variant resolve null and Any operands
        /// as the reference translator does: the generic variant bound to Any is not passed over for a specialisation.
        /// </summary>
        [DataTestMethod]
        [DataRow("null in { null }", nameof(In), "Boolean")]
        [DataRow("{} except {}", nameof(Except), "List<Any>")]
        [DataRow("{ null } intersect { null }", nameof(Intersect), "List<Any>")]
        [DataRow("{ null } includes null", nameof(Contains), "Boolean")]
        public void Mixed_Overloads_With_Null_Or_Any_Operands_Resolve_As_The_Reference_Translator_Does(
            string expression, string expectedNode, string expectedType)
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression(expression);

            var result = library.statements.Single(s => s.name != "Patient").expression;
            result.GetErrors().Should().BeEmpty();
            result.GetType().Name.Should().Be(expectedNode);
            result.resultTypeSpecifier.ToString().Should().Be(expectedType);
        }

        /// <summary>
        /// The reference translator binds the generic parameter to <c>Any</c> here, where this translator binds it to the
        /// type of the other operand.
        /// </summary>
        [DataTestMethod]
        [Ignore("Diverges from the reference translator; tracked by #1982.")]
        [DataRow("(null as Any) in { 1 }", "Any")]
        [DataRow("null union { 1 }", "List<Any>")]
        [DataRow("Coalesce((1 as Any), 'a')", "Any")]
        public void Null_Or_Any_Operand_Binds_The_Generic_Parameter_To_Any(string expression, string expectedFirstOperandType)
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression(expression);

            var result = library.statements.Single(s => s.name != "Patient").expression;
            var firstOperand = result switch
            {
                BinaryExpression binary => binary.operand[0],
                NaryExpression nary => nary.operand[0],
                _ => throw new InvalidOperationException($"Unexpected {result.GetType().Name}."),
            };
            firstOperand.resultTypeSpecifier.ToString().Should().Be(expectedFirstOperandType);
        }

        [TestMethod]
        [Ignore("The reference translator reports this call as ambiguous; this translator does not. Tracked by #1982.")]
        public void Same_As_Of_Nulls_Is_Ambiguous()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("null same as null");

            var result = library.statements.Single(s => s.name != "Patient").expression;
            result.GetErrors().Should().ContainSingle().Which.message.Should().Contain("ambiguous");
        }

        /// <summary>
        /// The operands are coerced to the bound operand type, so neither an unbound parameter nor an interval or list demotion to it remains.
        /// </summary>
        private static void ShouldHaveNoUnboundParameters(Expression[] operands)
        {
            foreach (var operand in operands)
            {
                operand.resultTypeSpecifier.Should().NotBeOfType<ParameterTypeSpecifier>();
                operand.Should().NotBeOfType<Start>();
                operand.Should().NotBeOfType<SingletonFrom>();
                if (operand is As @as)
                {
                    @as.asTypeSpecifier.Should().NotBeOfType<ParameterTypeSpecifier>();
                    @as.operand.Should().NotBeOfType<Start>();
                    @as.operand.Should().NotBeOfType<SingletonFrom>();
                }
            }
        }
    }
}
