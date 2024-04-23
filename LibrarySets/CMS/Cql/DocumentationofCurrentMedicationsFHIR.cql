library DocumentationofCurrentMedicationsFHIR version '0.2.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Encounter to Document Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834'
valueset "Medical Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007'

code "Documentation of current medications (procedure)": '428191000124101' from "SNOMEDCT" display 'Documentation of current medications (procedure)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)
context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Denominator":
  "Initial Population"

define "Qualifying Encounter during day of Measurement Period":
  ["Encounter": "Encounter to Document Medications"] ValidEncounter
    where ValidEncounter.status = 'finished'
      and ValidEncounter.period during day of "Measurement Period"

define "Initial Population":
  "Qualifying Encounter during day of Measurement Period" QualifyingEncounter

define "Numerator":
  "Qualifying Encounter during day of Measurement Period" QualifyingEncounter
    with [Procedure: "Documentation of current medications (procedure)"] MedicationsDocumented
      such that MedicationsDocumented.performed.toInterval ( ) ends during QualifyingEncounter.period
        and MedicationsDocumented.status = 'completed'

define "Denominator Exceptions":
  "Qualifying Encounter during day of Measurement Period" QualifyingEncounter
    with [ProcedureNotDone: code ~ "Documentation of current medications (procedure)"] MedicationsNotDocumented
      such that MedicationsNotDocumented.recorded during QualifyingEncounter.period
        and MedicationsNotDocumented.status = 'not-done'
        and MedicationsNotDocumented.reasonCode in "Medical Reason"