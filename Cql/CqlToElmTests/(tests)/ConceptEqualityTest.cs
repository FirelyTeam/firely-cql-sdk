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
    /// whether it equals <c>"C"</c> is unknown. <c>"Code1"</c> is the code of the specification's examples.
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
