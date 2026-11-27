/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Coalesce over lists and intervals, typed as the reference translator types it: the binary and n-ary forms
    /// take the type of their arguments, the single-list form takes the type of the list's elements.
    /// </summary>
    [TestClass]
    public class CoalesceTest : Base
    {
        [DataTestMethod]
        [DataRow("Coalesce({1, 2}, {3})", "List<Integer>")]
        [DataRow("Coalesce({1}, null, {2})", "List<Integer>")]
        [DataRow("Coalesce(Interval[1, 2], Interval[3, 4])", "Interval<Integer>")]
        [DataRow("Coalesce({ null, 1 })", "Integer")]
        public void Coalesce_Is_Typed_As_The_Reference_Translator_Types_It(string expression, string expectedType)
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression(expression);

            var coalesce = library.statements.Single(s => s.name != "Patient").expression.Should().BeOfType<Coalesce>().Subject;
            coalesce.resultTypeSpecifier.ToString().Should().Be(expectedType);
        }

        [TestMethod]
        public void Coalesce_Of_Lists_Evaluates_To_The_First_Non_Null_List()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Coalesce(null as List<Integer>, {3, 4})");
            var coalesce = library.statements.Single(s => s.name != "Patient").expression;

            Run<IEnumerable<int?>>(coalesce, library).Should().Equal(3, 4);
        }

        [TestMethod]
        public void Coalesce_Of_Intervals_Evaluates_To_The_First_Non_Null_Interval()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Coalesce(null as Interval<Integer>, Interval[3, 4])");
            var coalesce = library.statements.Single(s => s.name != "Patient").expression;

            var result = Run<CqlInterval<int?>>(coalesce, library);
            result.Should().NotBeNull();
            result!.low.Should().Be(3);
            result.high.Should().Be(4);
        }

        [DataTestMethod]
        [DataRow("Coalesce(null as Interval<Integer>, Interval[3.0, 4.0])")]
        [DataRow("Coalesce(null as Interval<Integer>, null, Interval[3.0, 4.0])")]
        public void Coalesce_Of_Intervals_Of_Different_Point_Types_Skips_A_Null_Interval(string expression)
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression(expression);
            var coalesce = library.statements.Single(s => s.name != "Patient").expression;

            var result = Run<CqlInterval<decimal?>>(coalesce, library);
            result.Should().NotBeNull();
            result!.low.Should().Be(3.0m);
            result.high.Should().Be(4.0m);
        }

        /// <summary>
        /// An argument typed Any may hold a value, so it does not give way to an overload that binds to the other
        /// arguments' type: the call stays typed Any, as in the reference translator.
        /// </summary>
        [TestMethod]
        public void Coalesce_Of_An_Any_Typed_Value_And_A_List_Is_Typed_Any()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Coalesce((1 as Any), {2})");

            var coalesce = library.statements.Single(s => s.name != "Patient").expression.Should().BeOfType<Coalesce>().Subject;
            coalesce.resultTypeSpecifier.ToString().Should().Be("Any");
            coalesce.GetErrors().Should().BeEmpty();
        }

        [TestMethod]
        [Ignore("The generated C# does not compile; tracked by #1985.")]
        public void Coalesce_Of_An_Any_Typed_Value_And_A_List_Evaluates_To_The_Value()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Coalesce((1 as Any), {2})");
            var coalesce = library.statements.Single(s => s.name != "Patient").expression;

            Run<object>(coalesce, library).Should().Be(1);
        }
    }
}
