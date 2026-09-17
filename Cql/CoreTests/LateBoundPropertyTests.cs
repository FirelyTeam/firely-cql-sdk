/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
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

        // An ELM Property element's path may be qualified, and the code generator passes it to
        // LateBoundProperty verbatim. Reflection resolves one property name at a time, so the whole
        // dotted string used to resolve to nothing and every qualified late-bound path silently
        // evaluated to null. CodeBuilderContext already walks the segments when the types are known at
        // design time ("support paths like birthDate.value on Patient"); late binding has to do the same.
        [TestMethod]
        public void LateBoundProperty_QualifiedPath_WalksEverySegment()
        {
            var operators = FhirCqlContext.ForBundle().Operators;
            var request = new MedicationRequest
            {
                Id = "mr-1",
                Medication = new ResourceReference("Medication/med-1")
            };

            Assert.AreEqual("Medication/med-1", operators.LateBoundProperty<string>(request, "medication.reference.value"));
            Assert.AreEqual("mr-1", operators.LateBoundProperty<string>(request, "id.value"));
        }

        [TestMethod]
        public void LateBoundProperty_QualifiedPath_ConvertsOnlyTheFinalSegment()
        {
            var operators = FhirCqlContext.ForBundle().Operators;
            var request = new MedicationRequest { AuthoredOnElement = new FhirDateTime("2026-01-01T08:14:00.000Z") };

            var value = operators.LateBoundProperty<CqlDateTime>(request, "authoredOn.value");

            Assert.IsNotNull(value);
            Assert.AreEqual(2026, value!.Value.Year);
            Assert.AreEqual(1, value.Value.Month);
            Assert.AreEqual(1, value.Value.Day);
        }

        [TestMethod]
        public void LateBoundProperty_QualifiedPath_NullOrMissingSegment_ReturnsNull()
        {
            var operators = FhirCqlContext.ForBundle().Operators;

            // A null intermediate segment short-circuits: the MedicationRequest carries no medication.
            Assert.IsNull(operators.LateBoundProperty<string>(new MedicationRequest { Id = "mr-1" }, "medication.reference.value"));

            // An unresolvable segment degrades to null rather than throwing, wherever it sits in the path.
            Assert.IsNull(operators.LateBoundProperty<string>(new MedicationRequest { Id = "mr-1" }, "nosuchelement.value"));
            Assert.IsNull(operators.LateBoundProperty<string>(
                new MedicationRequest { Medication = new ResourceReference("Medication/med-1") },
                "medication.nosuchelement.value"));
        }

        /// <summary>
        /// A <c>MedicationRequest.medication</c> that references a bundled <c>Medication</c> is the shape the
        /// qualified path exists for: the CQL content resolves the reference itself, by comparing the
        /// Medication's id against the last segment of <c>medication.reference.value</c>, and both sides of
        /// that comparison are qualified late-bound paths.
        /// </summary>
        [TestMethod]
        public void LateBoundProperty_QualifiedPath_ResolvesAMedicationReferenceAcrossABundle()
        {
            var medication = new Medication
            {
                Id = "med-1",
                Code = new CodeableConcept("http://www.nlm.nih.gov/research/umls/rxnorm", "312836")
            };
            var request = new MedicationRequest
            {
                Id = "mr-1",
                Status = MedicationRequest.MedicationrequestStatus.Active,
                Intent = MedicationRequest.MedicationRequestIntent.Order,
                Medication = new ResourceReference($"Medication/{medication.Id}")
            };
            var bundle = new Bundle { Type = Bundle.BundleType.Collection };
            bundle.Entry.Add(new Bundle.EntryComponent { Resource = new Patient { Id = "p-1" } });
            bundle.Entry.Add(new Bundle.EntryComponent { Resource = medication });
            bundle.Entry.Add(new Bundle.EntryComponent { Resource = request });

            var operators = FhirCqlContext.ForBundle(bundle).Operators;

            var reference = operators.LateBoundProperty<object>(request, "medication.reference.value");
            var referencedId = operators.Last<string>(operators.Split((string)reference, "/")!);
            var medicationId = operators.LateBoundProperty<object>(medication, "id.value");

            Assert.AreEqual("Medication/med-1", reference);
            Assert.AreEqual("med-1", referencedId);
            Assert.AreEqual(true, operators.Equal(medicationId, referencedId));
        }

        private class PropertyHolder
        {
            public Parameters.ParameterComponent? Performed { get; set; }
        }
    }
}
