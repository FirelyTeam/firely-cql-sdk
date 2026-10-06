// Source for FhirRatioTest-1.0.0.json. The checked-in ELM is plain translator output: the
// cql-to-elm CLI as Demo/Cql/Build/CqlTooling.Targets.xml invokes it (-locators true
// -result-types true -signatures All, with FHIRHelpers-4.0.1.cql alongside this file), pretty-printed
// the way that targets file does. No project regenerates Input/ELM/Test automatically. The shape in
// which a FHIR Ratio reaches a System Ratio parameter without the FHIRHelpers conversion is derived
// from that ELM in code, in FhirRatioConversionTests.

library FhirRatioTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

// Every query returns 'all': a plain 'return' removes duplicates, which compares the ratios for
// equality, and Ratio equality is not under test here.

// A FHIR Ratio read from a choice-typed element and converted to a System Ratio through FHIRHelpers.
define "Observation Ratio":
    First([Observation] O return all FHIRHelpers.ToRatio(O.value as FHIR.Ratio))

// A FHIR Ratio read from a nested, choice-typed element of a list-valued backbone element.
define "Dose Rate Ratio":
    First(
        [MedicationRequest] M
            return all FHIRHelpers.ToRatio(First(First(M.dosageInstruction).doseAndRate).rate as FHIR.Ratio)
    )

// A function over the System Ratio. Called with a FHIR Ratio, its argument is converted implicitly,
// through the FHIRHelpers.ToRatio conversion the FHIR model info declares.
define function "Ratio Of"(ratio System.Ratio):
    ratio

define "Observation Ratio Implicitly Converted":
    First([Observation] O return all "Ratio Of"(O.value as FHIR.Ratio))
