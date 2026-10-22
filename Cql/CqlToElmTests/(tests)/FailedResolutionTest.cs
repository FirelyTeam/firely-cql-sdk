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

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// An ambiguous or failed overload resolution reports one error at the call and types the call as Any,
    /// so that nothing downstream reports errors over the result type of a guessed candidate.
    /// </summary>
    [TestClass]
    public class FailedResolutionTest : Base
    {
        [TestMethod]
        public void Union_Of_Unrelated_Lists_Types_As_Any_And_Exists_Adds_No_Error()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library FailedResolutionTest version '1.0.0'

                using FHIR version '4.0.1'

                context Patient

                define U: [Encounter] union [Observation]
                define E: exists U
                """, "Could not resolve call to operator Union*");

            var union = library.statements.Single(s => s.name == "U").expression;
            union.Should().BeOfType<Union>();
            union.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);

            var exists = library.statements.Single(s => s.name == "E").expression;
            exists.Should().BeOfType<Exists>();
            exists.GetErrors().Should().BeEmpty();
        }

        [TestMethod]
        public void Ambiguous_Call_To_User_Defined_Overloads_Types_As_Any()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library FailedResolutionTest version '1.0.0'

                define function f(x Long): x
                define function f(x Decimal): x

                define C: f(null)
                """, "Call to operator f(Any) is ambiguous with*");

            var call = library.statements.Single(s => s.name == "C").expression;
            call.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
        }

        [TestMethod]
        public void Ambiguous_Call_To_System_Overloads_Types_As_Any()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library FailedResolutionTest version '1.0.0'

                define C: difference in weeks between null and null
                """, "Call to operator DifferenceBetween(Any, Any, String) is ambiguous with*");

            var call = library.statements.Single(s => s.name == "C").expression;
            call.Should().BeOfType<DifferenceBetween>();
            call.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
        }

        [TestMethod]
        public void Failed_Call_To_Single_User_Defined_Function_Types_As_Any()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library FailedResolutionTest version '1.0.0'

                define function g(x Integer): x

                define C: g('a')
                """, "Could not resolve call to operator g with signature (String).");

            var call = library.statements.Single(s => s.name == "C").expression;
            call.Should().BeOfType<FunctionRef>();
            call.resultTypeSpecifier.Should().Be(SystemTypes.AnyType);
        }
    }
}
