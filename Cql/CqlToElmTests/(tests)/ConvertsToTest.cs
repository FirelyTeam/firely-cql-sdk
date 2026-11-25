/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;

namespace Hl7.Cql.CqlToElm.Test
{
    /// <summary>
    /// The ConvertsTo* operators and CanConvertQuantity of CQL 1.5.3, Appendix B - CQL Reference, Type Operators,
    /// translated and evaluated end to end.
    /// </summary>
    [TestClass]
    public class ConvertsToTest : Base
    {
        [TestMethod]
        [DataRow("ConvertsToBoolean('true')", true)]
        [DataRow("ConvertsToBoolean(1)", true)]
        [DataRow("ConvertsToBoolean('maybe')", false)]
        [DataRow("ConvertsToBoolean(@2014-01-01)", false)]
        [DataRow("ConvertsToDate('2014-01-01')", true)]
        [DataRow("ConvertsToDate(@2014-01-01T10:00:00)", true)]
        [DataRow("ConvertsToDate('2014-13-01')", false)]
        [DataRow("ConvertsToDate(1)", false)]
        [DataRow("ConvertsToDateTime('2014-01-01T10:00:00')", true)]
        [DataRow("ConvertsToDateTime(@2014-01-01)", true)]
        [DataRow("ConvertsToDateTime('not a date')", false)]
        [DataRow("ConvertsToDecimal('1.5')", true)]
        [DataRow("ConvertsToDecimal(1)", true)]
        [DataRow("ConvertsToDecimal('one')", false)]
        [DataRow("ConvertsToInteger('12')", true)]
        [DataRow("ConvertsToInteger(12L)", true)]
        [DataRow("ConvertsToInteger(2147483648L)", false)]
        [DataRow("ConvertsToInteger('1.5')", false)]
        [DataRow("ConvertsToLong('12')", true)]
        [DataRow("ConvertsToLong(12)", true)]
        [DataRow("ConvertsToLong('twelve')", false)]
        [DataRow("""ConvertsToQuantity('5 \'mg\'')""", true)]
        [DataRow("ConvertsToQuantity(5)", true)]
        [DataRow("ConvertsToQuantity('five')", false)]
        [DataRow("ConvertsToRatio('1:128')", true)]
        [DataRow("ConvertsToRatio(5)", false)]
        [DataRow("ConvertsToString(5)", true)]
        [DataRow("ConvertsToString(@T10:00)", true)]
        [DataRow("ConvertsToString({ 1 })", false)]
        [DataRow("ConvertsToTime('10:00:00')", true)]
        [DataRow("ConvertsToTime('25:00:00')", false)]
        [DataRow("ConvertsToTime(@2014-01-01)", false)]
        public void ConvertsTo_returns_whether_the_argument_converts(string expression, bool expected) =>
            Evaluate(expression).Should().Be(expected);

        [TestMethod]
        [DataRow("ConvertsToBoolean")]
        [DataRow("ConvertsToDate")]
        [DataRow("ConvertsToDateTime")]
        [DataRow("ConvertsToDecimal")]
        [DataRow("ConvertsToInteger")]
        [DataRow("ConvertsToLong")]
        [DataRow("ConvertsToQuantity")]
        [DataRow("ConvertsToRatio")]
        [DataRow("ConvertsToString")]
        [DataRow("ConvertsToTime")]
        public void ConvertsTo_null_is_null(string function) =>
            Evaluate($"{function}(null)").Should().BeNull();

        [TestMethod]
        [DataRow("CanConvertQuantity(5 'mg', 'g')", true)]
        [DataRow("CanConvertQuantity(12 '[in_i]', '[ft_i]')", true)]
        [DataRow("CanConvertQuantity(5 'mg', 's')", false)]
        [DataRow("CanConvertQuantity(null, 'g')", null)]
        [DataRow("CanConvertQuantity(5 'mg', null)", null)]
        public void CanConvertQuantity_returns_whether_the_quantity_converts(string expression, bool? expected) =>
            Evaluate(expression).Should().Be(expected);

        [TestMethod]
        [DataRow("ConvertsToBoolean(FHIR.boolean { value: true })", true)]
        [DataRow("ConvertsToBoolean(FHIR.string { value: 'maybe' })", false)]
        [DataRow("ConvertsToDate(FHIR.date { value: @2014-01-01 })", true)]
        [DataRow("ConvertsToDate(FHIR.dateTime { value: @2014-01-01T10:00:00.000Z })", true)]
        [DataRow("ConvertsToDate(FHIR.string { value: '2014-13-01' })", false)]
        [DataRow("ConvertsToDateTime(FHIR.date { value: @2014-01-01 })", true)]
        [DataRow("ConvertsToDecimal(FHIR.decimal { value: 1.5 })", true)]
        [DataRow("ConvertsToInteger(FHIR.integer { value: 12 })", true)]
        [DataRow("ConvertsToInteger(FHIR.string { value: '12' })", true)]
        [DataRow("ConvertsToInteger(FHIR.string { value: 'twelve' })", false)]
        [DataRow("ConvertsToLong(FHIR.integer { value: 12 })", true)]
        [DataRow("ConvertsToQuantity(FHIR.Quantity { value: FHIR.decimal { value: 5.0 }, unit: FHIR.string { value: 'mg' } })", true)]
        [DataRow("ConvertsToQuantity(FHIR.Patient { active: FHIR.boolean { value: true } })", false)]
        [DataRow("ConvertsToRatio(FHIR.string { value: '1:128' })", true)]
        [DataRow("ConvertsToString(FHIR.code { value: 'final' })", true)]
        [DataRow("ConvertsToTime(FHIR.time { value: @T10:00:00 })", true)]
        [DataRow("ConvertsToTime(FHIR.date { value: @2014-01-01 })", false)]
        [DataRow("ConvertsToInteger(null as FHIR.string)", null)]
        // Observation.value is a choice, converted by the type the value has at run time.
        [DataRow("ConvertsToInteger(FHIR.Observation { value: FHIR.string { value: '12' } }.value)", true)]
        [DataRow("ConvertsToInteger(FHIR.Observation { value: FHIR.integer { value: 12 } }.value)", true)]
        [DataRow("ConvertsToInteger(FHIR.Observation { value: FHIR.string { value: 'twelve' } }.value)", false)]
        [DataRow("ConvertsToInteger(FHIR.Observation { value: FHIR.dateTime { value: @2014-01-01T10:00:00.000Z } }.value)", false)]
        [DataRow("ConvertsToQuantity(FHIR.Observation { value: FHIR.Quantity { value: FHIR.decimal { value: 5.0 } } }.value)", true)]
        [DataRow("ConvertsToDateTime(FHIR.Observation { value: FHIR.dateTime { value: @2014-01-01T10:00:00.000Z } }.value)", true)]
        [DataRow("ConvertsToInteger(FHIR.Observation { status: FHIR.ObservationStatus { value: 'final' } }.value)", null)]
        // A model value that has no System value does not convert.
        [DataRow("ConvertsToInteger(FHIR.string { id: 'no-value' })", false)]
        [DataRow("ConvertsToQuantity(FHIR.Quantity { value: FHIR.decimal { value: 5.0 }, system: FHIR.uri { value: 'http://snomed.info/sct' }, code: FHIR.code { value: '258682000' } })", false)]
        [DataRow("ConvertsToQuantity(FHIR.Observation { value: FHIR.Quantity { value: FHIR.decimal { value: 5.0 }, system: FHIR.uri { value: 'http://snomed.info/sct' }, code: FHIR.code { value: '258682000' } } }.value)", false)]
        [DataRow("ConvertsToString(FHIR.Observation { value: FHIR.string { id: 'no-value' } }.value)", false)]
        public void ConvertsTo_converts_a_model_value_to_its_System_value_first(string expression, bool? expected) =>
            EvaluateWithFhir(expression).Should().Be(expected);

        [TestMethod]
        [DataRow("FHIR.string { value: '12' }", true)]
        [DataRow("FHIR.string { value: 'twelve' }", false)]
        [DataRow("FHIR.string { id: 'no-value' }", false)]
        [DataRow("FHIR.integer { value: 12 }", true)]
        [DataRow("FHIR.time { value: @T10:00:00 }", false)]
        [DataRow("null", null)]
        public void ConvertsTo_reads_an_operand_of_a_choice_type_by_reference(string value, bool? expected) =>
            EvaluateWithFhir($"Test(FHIR.Observation {{ status: FHIR.ObservationStatus {{ value: 'final' }}, value: {value} }})",
                "define function Test(observation FHIR.Observation): (observation.value) V return ConvertsToInteger(V)")
                .Should().Be(expected);

        [TestMethod]
        public void ConvertsTo_binds_an_argument_that_is_not_a_reference_once()
        {
            var cql = CqlLibraryString.Parse("""
                library ConvertsToFhir version '1.0.0'
                using FHIR version '4.0.1'
                include FHIRHelpers version '4.0.1'
                define function Inline(observation FHIR.Observation): ConvertsToInteger(observation.value)
                define function Reference(value FHIR.string): ConvertsToInteger(value)
                """);
            var lib = CreateCqlToolkit().AddFHIRHelpers().AddCqlLibraries([cql]).TranslateToElm().ArtifactsById[cql].ResultElmLibrary!;
            lib.ShouldSucceed();

            var query = lib.statements.Single(statement => statement.name == "Inline").expression.Should().BeOfType<Query>().Subject;
            query.source.Should().ContainSingle().Which.expression.Should().BeOfType<Property>();
            lib.statements.Single(statement => statement.name == "Reference").expression.Should().BeOfType<If>();
        }

        /// <summary>
        /// Translates <paramref name="expression"/> in a library that uses FHIR and includes FHIRHelpers, checks it
        /// has a Boolean result, and evaluates it.
        /// </summary>
        private static bool? EvaluateWithFhir(string expression, string declarations = "")
        {
            var cql = CqlLibraryString.Parse($"""
                library ConvertsToFhir version '1.0.0'
                using FHIR version '4.0.1'
                include FHIRHelpers version '4.0.1'
                {declarations}
                define "Result": {expression}
                """);
            var toolkit = CreateCqlToolkit().AddFHIRHelpers().AddCqlLibraries([cql]);
            var lib = toolkit.TranslateToElm().ArtifactsById[cql].ResultElmLibrary!;
            lib.ShouldSucceed();
            lib.statements.Single(statement => statement.name == "Result").expression.Should().HaveType(SystemTypes.BooleanType);
            using var invoker = toolkit.CreateLibrarySetInvoker();
            return (bool?)invoker.InvokeLibraryDefinition(FhirCqlContext.CreateContext(), cql.LibraryIdentifier, "Result");
        }

        /// <summary>
        /// Translates <paramref name="expression"/>, checks it becomes the ELM node of the function it calls with a
        /// Boolean result, and evaluates it.
        /// </summary>
        private static bool? Evaluate(string expression)
        {
            var lib = CreateCqlToolkit().MakeLibraryFromExpression(expression);
            lib.Should().NotBeNull();
            lib.statements.Should().ContainSingle();
            var node = lib.statements[0].expression;
            node.GetType().Name.Should().Be(expression[..expression.IndexOf('(')]);
            node.Should().HaveType(SystemTypes.BooleanType);
            return Run<bool?>(node, lib);
        }
    }
}
