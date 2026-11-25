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
    /// <summary>
    /// SplitOnMatches (§9.B SplitOnMatches) splits a string on each match of a regular expression.
    /// </summary>
    [TestClass]
    public class SplitOnMatchesTest : Base
    {
        private static SplitOnMatches Translate(string expression, out Library library)
        {
            library = CreateCqlToolkit().MakeLibrary($"""
                library SplitOnMatchesTest version '1.0.0'

                define private Result: {expression}
                """);
            return library.statements.Single().expression.Should().BeOfType<SplitOnMatches>().Subject;
        }

        [TestMethod]
        public void SplitOnMatches_TranslatesToItsElmNode()
        {
            var splitOnMatches = Translate("SplitOnMatches('A,B', ',')", out _);

            splitOnMatches.stringToSplit.Should().BeOfType<Literal>().Which.value.Should().Be("A,B");
            splitOnMatches.separatorPattern.Should().BeOfType<Literal>().Which.value.Should().Be(",");
            splitOnMatches.resultTypeSpecifier.Should().BeOfType<ListTypeSpecifier>()
                .Which.elementType.Should().BeOfType<NamedTypeSpecifier>()
                .Which.name.Name.Should().Be($"{{{SystemUri}}}String");
        }

        [DataTestMethod]
        [DataRow("SplitOnMatches('A,B,C', ',')", new[] { "A", "B", "C" })]
        [DataRow("SplitOnMatches('A1B22C', '[0-9]+')", new[] { "A", "B", "C" })]
        [DataRow("SplitOnMatches('ABC', ',')", new[] { "ABC" })]
        [DataRow("SplitOnMatches('A1B2C', '([0-9])')", new[] { "A", "B", "C" })]
        [DataRow("SplitOnMatches('A1B2C', '(?<digit>[0-9])')", new[] { "A", "B", "C" })]
        [DataRow("SplitOnMatches('A,B,,', ',')", new[] { "A", "B", "", "" })]
        [DataRow("SplitOnMatches(',A,B', ',')", new[] { "", "A", "B" })]
        [DataRow("SplitOnMatches('AB', 'x*')", new[] { "", "A", "B", "" })]
        [DataRow("SplitOnMatches(',', ',')", new[] { "", "" })]
        [DataRow("SplitOnMatches('', ',')", new[] { "" })]
        [DataRow("SplitOnMatches('A,B', null as String)", new[] { "A,B" })]
        public void SplitOnMatches_SplitsOnEachMatchOfThePattern(string expression, string[] expected)
        {
            var splitOnMatches = Translate(expression, out var library);

            Run(splitOnMatches, library).Should().BeAssignableTo<IEnumerable<string>>()
                .Which.Should().Equal(expected);
        }

        /// <summary>§9.B SplitOnMatches: if the stringToSplit argument is null, the result is null.</summary>
        [TestMethod]
        public void SplitOnMatches_NullString_IsNull()
        {
            var splitOnMatches = Translate("SplitOnMatches(null, ',')", out var library);

            Run(splitOnMatches, library).Should().BeNull();
        }
    }
}
