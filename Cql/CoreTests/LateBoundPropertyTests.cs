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
        // Regression test for CMS2 (Depression Screening and Follow-Up).
        // When the follow-up is a choice type surfaced as 'object' (e.g. a
        // MedicationRequest), the generated code reads FollowUpPositiveAdultScreen.authoredOn
        // via LateBoundProperty<object>(...), then reads its 'value' via
        // LateBoundProperty<CqlDateTime>(fhirDateTime, "value"). This used to return
        // null because the raw string value is not assignable to CqlDateTime, which
        // caused the follow-up timing check - and therefore the Numerator - to fail.
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
    }
}
