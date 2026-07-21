/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace CoreTests
{
    [TestClass]
    public class LateBoundPropertyTests
    {
        // Regression test for late-bound access to a FHIR primitive's value.
        // When a resource is reached through a choice or union type surfaced as
        // 'object', the generated code reads elements such as authoredOn via
        // LateBoundProperty<object>(...), then reads their 'value' via
        // LateBoundProperty<CqlDateTime>(fhirDateTime, "value"). This used to return
        // null because the raw string value is not assignable to CqlDateTime, which
        // made timing checks on such elements silently evaluate to null.
        [TestMethod]
        public void LateBoundProperty_FhirDateTimeValue_ConvertsToCqlDateTime()
        {
            var operators = FhirCqlContext.ForBundle().Operators;
            var authoredOn = new FhirDateTime("2026-01-01T08:14:00.000Z");

            var value = operators.LateBoundProperty<CqlDateTime>(authoredOn, "value");

            Assert.IsNotNull(value, "FhirDateTime.value should resolve to a CqlDateTime, not null");
            Assert.AreEqual(2026, value.Value.Year);
            Assert.AreEqual(1, value.Value.Month);
            Assert.AreEqual(1, value.Value.Day);
        }

        [TestMethod]
        public void LateBoundProperty_MissingProperty_ReturnsNull()
        {
            var operators = FhirCqlContext.ForBundle().Operators;

            // MedicationRequest has no 'performed' element; this must degrade to null,
            // not throw, so the CQL choice-type dispatch can fall through.
            var value = operators.LateBoundProperty<object>(new MedicationRequest(), "performed");

            Assert.IsNull(value);
        }

        [TestMethod]
        public void LateBoundProperty_ThrowingConversion_ReturnsNull()
        {
            var operators = FhirCqlContext.ForBundle().Operators;

            // A ParameterComponent -> CqlDateTime conversion is registered, but its
            // delegate throws when the component's value has no conversion to the
            // target type (here: a CodeableConcept). Late-bound access must swallow
            // that and return null rather than fail the whole expression.
            var holder = new PropertyHolder
            {
                Performed = new Parameters.ParameterComponent
                {
                    Name = "example",
                    Value = new CodeableConcept("http://example.org", "example")
                }
            };

            var value = operators.LateBoundProperty<CqlDateTime>(holder, "Performed");

            Assert.IsNull(value);
        }

        private class PropertyHolder
        {
            public Parameters.ParameterComponent? Performed { get; set; }
        }
    }
}
