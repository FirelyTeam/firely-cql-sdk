/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Grammar rules without a translation must yield an error node in place of the construct,
    /// wherever the construct appears, instead of terminating the translation.
    /// </summary>
    [TestClass]
    public class UnhandledConstructTest : Base
    {
        private const string CodeSystem = """codesystem "cs": 'http://example.org/cs'""";

        [TestMethod]
        public void ExternalConstant_AsOperand_ReportsError()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library UnhandledConstructTest version '1.0.0'

                define private ExternalConstantOperand: %x + 1
                """,
                "Translation of externalConstant '%x' is not implemented.");

            assertErrorNode(library, "externalConstant");
        }

        [TestMethod]
        public void CodeSelector_AsOperand_ReportsError()
        {
            var library = CreateCqlToolkit().MakeLibrary($$"""
                library UnhandledConstructTest version '1.0.0'

                {{CodeSystem}}

                define private CodeSelectorOperand: Code '1' from "cs" display 'x' ~ Code '1' from "cs"
                """,
                "Translation of codeSelector 'Code '1' from \"cs\" display 'x'' is not implemented.",
                "Translation of codeSelector 'Code '1' from \"cs\"' is not implemented.");

            assertErrorNode(library, "codeSelector");
        }

        [TestMethod]
        public void ConceptSelector_AsFunctionArgument_ReportsError()
        {
            var library = CreateCqlToolkit().MakeLibrary($$"""
                library UnhandledConstructTest version '1.0.0'

                {{CodeSystem}}

                define function "Display"(c Concept): c.display

                define private ConceptSelectorArgument: "Display"(Concept { Code '1' from "cs", Code '2' from "cs" } display 'y')
                """,
                "Translation of conceptSelector 'Concept { Code '1' from \"cs\", Code '2' from \"cs\" } display 'y'' is not implemented.");

            assertErrorNode(library, "conceptSelector");
        }

        private static void assertErrorNode(Library library, string ruleName)
        {
            var errorNodes = new List<Null>();
            new ElmTreeWalker(node =>
            {
                if (node is Null n
                    && n.annotation?.OfType<CqlToElmError>().Any(e => e.message.StartsWith($"Translation of {ruleName} ")) == true)
                    errorNodes.Add(n);
                return false;
            }).Start(library);

            errorNodes.Should().NotBeEmpty();
            foreach (var node in errorNodes)
            {
                node.locator.Should().NotBeNullOrEmpty();
                node.resultTypeSpecifier.Should().BeEquivalentTo(SystemTypes.AnyType);
            }
        }
    }
}
