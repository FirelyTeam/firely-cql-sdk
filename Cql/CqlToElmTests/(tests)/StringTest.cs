/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class StringTest : Base
    {
        [TestMethod]
        public void SplitOnMatches_SplitsOnRegex()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("SplitOnMatches('A1B2C', '[0-9]')");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SplitOnMatches>();
            Run<IEnumerable<string>?>(expr, library).Should().Equal("A", "B", "C");
        }

        [TestMethod]
        public void SplitOnMatches_SeparatorNotFound()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("SplitOnMatches('ABC', ',')");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<SplitOnMatches>();
            Run<IEnumerable<string>?>(expr, library).Should().Equal("ABC");
        }

        [TestMethod]
        public void Combine_EmptyListIsNull()
        {
            // Spec: "If the source argument is null, or the source list is empty, the result is null."
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Combine({})");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Combine>();
            Run<string?>(expr, library).Should().BeNull();
        }

        [TestMethod]
        public void Combine_IgnoresNullElements()
        {
            // Spec: "null elements in the input list are ignored." Without a separator this held by
            // accident; with one, a null element used to leave a trailing separator behind.
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Combine({'a', 'b', 'c', null}, '-')");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Combine>();
            Run<string?>(expr, library).Should().Be("a-b-c");
        }

        [TestMethod]
        public void ReplaceMatchesSpaces()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("ReplaceMatches('All that glitters is not gold', '\\\\s', '\\$')");
            var replace = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ReplaceMatches>();
            var result = Run<string?>(replace, library);
            result.Should().Be("All$that$glitters$is$not$gold");
        }

        [TestMethod]
        public void SubstringWithLength_SpecExample()
        {
            // Spec example: Substring('ABCDE', 2, 1) // 'C'
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Substring('ABCDE', 2, 1)");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Substring>();
            var result = Run<string?>(expr, library);
            result.Should().Be("C");
        }

        [TestMethod]
        public void SubstringWithLength_LengthExceedsRemaining()
        {
            // Length exceeds remaining characters: Substring('abcdef', 3, 5) -> 'def'
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Substring('abcdef', 3, 5)");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Substring>();
            var result = Run<string?>(expr, library);
            result.Should().Be("def");
        }

        [TestMethod]
        public void SubstringWithLength_LengthExceedsRemainingFromStart()
        {
            // Substring('ABC', 1, 10) -> 'BC'
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Substring('ABC', 1, 10)");
            var expr = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Substring>();
            var result = Run<string?>(expr, library);
            result.Should().Be("BC");
        }
    }
}
