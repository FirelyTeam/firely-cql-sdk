/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class SizeTest : Base
    {
        [TestMethod]
        public void Size_Integer()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library SizeTest version '1.0.0'

                define private Size_Integers: Size(Interval[3, 7])
                """);

            var size = library.statements.Single().expression.Should().BeOfType<Size>().Subject;
            Run(size, library).Should().Be(5);
        }

        /// <summary>An interval over Any can only be null, and so is its size (§9.B Size).</summary>
        [TestMethod]
        public void Size_IntervalOfAny_IsNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library SizeTest version '1.0.0'

                define private Size_Any: Size(null as Interval<Any>)
                """);

            var size = library.statements.Single().expression.Should().BeOfType<Size>().Subject;
            Run(size, library).Should().BeNull();
        }
    }
}
