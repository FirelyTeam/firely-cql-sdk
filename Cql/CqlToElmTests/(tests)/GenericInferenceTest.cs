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
    /// parameter gets the parameter bound to <c>Any</c>, so the call is typed <c>Any</c> instead of failing translation.
    /// </summary>
    [TestClass]
    public class GenericInferenceTest : Base
    {
        [TestMethod]
        public void Coalesce_Of_Intervals_Of_Any_Types_As_Any()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library GenericInferenceTest version '1.0.0'

                define C: Coalesce(Interval[null, null], Interval[null, null])
                """);

            var coalesce = library.statements.Single(s => s.name == "C").expression.Should().BeOfType<Coalesce>().Subject;
            coalesce.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
            ShouldHaveNoUnboundParameters(coalesce.operand);
        }

        [TestMethod]
        public void Coalesce_Of_Lists_Of_Any_With_List_Demotion_Types_As_Any()
        {
            var library = CreateCqlToolkit(DisableListDemotion: false).MakeLibrary("""
                library GenericInferenceTest version '1.0.0'

                define C: Coalesce({ null }, { null })
                """);

            var coalesce = library.statements.Single(s => s.name == "C").expression.Should().BeOfType<Coalesce>().Subject;
            coalesce.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
            ShouldHaveNoUnboundParameters(coalesce.operand);
        }

        /// <summary>
        /// The operands are coerced to the bound operand type, so neither an unbound parameter nor a demotion to it remains.
        /// </summary>
        private static void ShouldHaveNoUnboundParameters(Expression[] operands)
        {
            foreach (var operand in operands)
            {
                operand.resultTypeSpecifier.Should().NotBeOfType<ParameterTypeSpecifier>();
                operand.Should().NotBeOfType<Start>();
                if (operand is As @as)
                {
                    @as.asTypeSpecifier.Should().NotBeOfType<ParameterTypeSpecifier>();
                    @as.operand.Should().NotBeOfType<Start>();
                }
            }
        }
    }
}
