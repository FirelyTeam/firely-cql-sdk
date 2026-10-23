/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// Equality and equivalence of Concepts, spec §9.B, Clinical Operators, translated from CQL, compiled and evaluated.
    /// Every comparison runs in both operand orders.
    /// </summary>
    /// <remarks>
    /// <c>"C"</c> and <c>"D"</c> are LOINC codes. <c>"C without system"</c> has the code of <c>"C"</c> but no system, so
    /// whether it equals <c>"C"</c> is unknown. <c>"Code1"</c> is the code of the specification's examples, and
    /// <c>"Concept2"</c> the concept with a null code of its Equivalent examples.
    /// </remarks>
    [TestClass]
    public class ConceptEqualityTest : Base
    {
        #region Equal

        /// <summary>
        /// Spec §9.B, Clinical Operators, Equal: "The equal (=) operator for Codes and Concepts uses tuple equality
        /// semantics. This means that the operator will return true if and only if the values for each element by name
        /// are equal. If either argument is null, or has different components specified, the result is null."
        /// </summary>
        private static IEnumerable<object?[]> EqualCases =>
        [
            // The specification's EqualIsFalse: Concept1 = Concept2.
            ["Concept { codes: { \"Code1\" }, display: 'Concepts' }", "Concept { codes: { \"Code1\" }, display: 'More Concepts' }", false],
            ["Concept { codes: { \"C\" }, display: 'x' }", "Concept { codes: { \"C\" }, display: 'x' }", true],
            ["Concept { codes: { \"C\" } }", "Concept { codes: { \"C\" } }", true],
            ["Concept { codes: { \"C\" }, display: 'x' }", "Concept { codes: { \"D\" }, display: 'x' }", false],
            ["Concept { codes: { \"C\", \"D\" } }", "Concept { codes: { \"D\", \"C\" } }", false],
            ["Concept { display: 'x' }", "Concept { display: 'y' }", false],
            ["Concept { display: 'x' }", "Concept { display: 'x' }", true],
            ["Concept { : }", "Concept { : }", true],
            ["Concept { display: 'x' }", "Concept { codes: { \"C\" }, display: 'x' }", null],
            ["Concept { codes: { \"C\" }, display: 'x' }", "Concept { codes: { \"C\" } }", null],
            ["Concept { codes: { \"C\" }, display: 'x' }", "Concept { codes: { \"D\" } }", null],
            ["Concept { : }", "Concept { display: 'x' }", null],
            ["Concept { codes: { \"C\" } }", "Concept { codes: { \"C without system\" } }", null],
            ["Concept { codes: { \"C\" }, display: 'x' }", "(null as Concept)", null],
            ["Concept { display: 'x' }", "(null as Concept)", null],
        ];

        [TestMethod]
        [DynamicData(nameof(EqualCases))]
        public void Concept_Equal_Concept(string left, string right, bool? expected)
        {
            var results = Evaluate($"{left} = {right}", $"{right} = {left}", $"{left} != {right}");

            results.Should().Equal(expected, expected, !expected);
        }

        #endregion

        #region Equivalent

        /// <summary>
        /// Spec §9.B, Clinical Operators, Equivalent: "For Concept values, equivalence is defined as a non-empty
        /// intersection of the codes in each Concept using Code equivalence to determine the intersection. The display
        /// element is ignored for the purposes of determining Concept equivalence. Note that this operator will always
        /// return true or false, even if either or both of its arguments are null, or contain null components."
        /// </summary>
        private static IEnumerable<object?[]> EquivalentCases =>
        [
            ["Concept { codes: { \"Code1\" }, display: 'Concepts' }", "Concept { codes: { \"Code1\" }, display: 'More Concepts' }", true],
            ["Concept { codes: { \"C\", \"D\" } }", "Concept { codes: { \"D\" }, display: 'x' }", true],
            ["Concept { codes: { \"C\" }, display: 'x' }", "Concept { codes: { \"D\" }, display: 'x' }", false],
            ["Concept { display: 'x' }", "Concept { display: 'y' }", false],
            ["Concept { display: 'x' }", "Concept { display: 'x' }", false],
            ["Concept { : }", "Concept { : }", false],
            ["Concept { display: 'x' }", "Concept { codes: { \"C\" }, display: 'x' }", false],
            ["Concept { display: 'x' }", "(null as Concept)", false],
            ["Concept { codes: { \"C\" } }", "(null as Concept)", false],
            ["(null as Concept)", "(null as Concept)", true],
            // The specification's EquivalentIsFalse: Concept1 ~ Concept2.
            ["Concept { codes: { \"Code1\" }, display: 'Concepts' }", "Concept { codes: { null as Code }, display: 'More Concepts' }", false],
            // As the specification's EquivalentIsAlsoTrue (Concept2 ~ Concept2), with two instances.
            ["Concept { codes: { null as Code }, display: 'More Concepts' }", "Concept { codes: { null as Code }, display: 'More Concepts' }", true],
        ];

        [TestMethod]
        [DynamicData(nameof(EquivalentCases))]
        public void Concept_Equivalent_Concept(string left, string right, bool expected)
        {
            var results = Evaluate($"{left} ~ {right}", $"{right} ~ {left}", $"{left} !~ {right}");

            results.Should().Equal(expected, expected, !expected);
        }

        /// <summary>
        /// The specification's EquivalentIsAlsoTrue, <c>Concept2 ~ Concept2</c>, and a concept without codes against
        /// itself, which shares no code with itself.
        /// </summary>
        [TestMethod]
        public void Concept_Equivalent_Itself()
        {
            var results = Evaluate(
                "\"Concept2\" ~ \"Concept2\"",
                "\"Without codes\" ~ \"Without codes\"");

            results.Should().Equal(true, false);
        }

        #endregion

        /// <summary>
        /// Translates a library that defines each of <paramref name="expressions"/>, compiles it, and evaluates them in
        /// order.
        /// </summary>
        private static object?[] Evaluate(params string[] expressions)
        {
            var definitions = string.Join(
                Environment.NewLine,
                expressions.Select((expression, i) => $"define \"Expression {i}\": {expression}"));

            var library = CreateCqlToolkit().MakeLibrary($$"""
                library ConceptEqualityTest version '1.0.0'

                codesystem "LOINC": 'http://loinc.org'

                code "C": '8480-6' from "LOINC"
                code "D": '8462-4' from "LOINC"

                define "C without system": Code { code: '8480-6' }
                define "Code1": Code { system: 'http://loinc.org', code: '8480-6', version: '1.0', display: 'Systolic blood pressure' }
                define "Concept2": Concept { codes: { null as Code }, display: 'More Concepts' }
                define "Without codes": Concept { display: 'x' }

                {{definitions}}
                """);

            var results = new object?[expressions.Length];
            CreateElmToolkit().UseLibrarySetInvoker(library, invoker =>
            {
                var context = FhirCqlContext.ForBundle();
                for (var i = 0; i < expressions.Length; i++)
                    results[i] = invoker.InvokeLibraryDefinition(context, library.VersionedLibraryIdentifier!, $"Expression {i}");
            });
            return results;
        }
    }
}
