// Source for ChoiceTypeListPropertyTest-1.0.0.json. The checked-in ELM is plain translator output:
// the cql-to-elm CLI as Demo/Cql/Build/CqlTooling.Targets.xml invokes it (-locators true
// -result-types true -signatures All, with FHIRHelpers-4.0.1.cql alongside this file), pretty-printed
// the way that targets file does. No project regenerates Input/ELM/Test automatically. The shapes
// the tests need - a "reasonCode" Property without a result type, as the MADiE translator emits it
// for a choice-typed alias; a choice member that does not resolve; a nested choice member - are
// derived from that ELM in code, in ChoiceTypeListPropertyTests.

library ChoiceTypeListPropertyTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

valueset "Reasons": 'http://fire.ly/ValueSet/late-bound-reasons'

context Patient

// The union of two resource types is a choice type, so "reasonCode" - a list-valued element - can
// only be reached by late binding.
define "Interventions With Reason":
    ( [ServiceRequest] union [MedicationRequest] ) Intervention
        where Intervention.reasonCode in "Reasons"

// The same filter over a single, strongly typed retrieve. Both definitions must agree on which
// resources they keep.
define "Procedures With Reason":
    [Procedure] P
        where P.reasonCode in "Reasons"
