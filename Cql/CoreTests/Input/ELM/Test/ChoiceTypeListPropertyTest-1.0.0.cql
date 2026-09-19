// Source for ChoiceTypeListPropertyTest-1.0.0.json. The checked-in ELM is not regenerated from
// this file: its "reasonCode" Property node deliberately carries no resultTypeSpecifier, matching
// the ELM the MADiE translator emits for this construct. That leaves the choice type - erased to
// object - as the compiler's only source of information about the path.

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
