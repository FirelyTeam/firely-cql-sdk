library CMS68FHIRDocumentationCurrentMeds version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Encounter to Document Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1834'

code "Acute health crisis (finding)": '705016005' from "SNOMEDCT" display 'Acute health crisis (finding)'
code "Documentation of current medications (procedure)": '428191000124101' from "SNOMEDCT" display 'Documentation of current medications (procedure)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

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

define "Qualifying Encounter During Day of Measurement Period":
  ["Encounter": "Encounter to Document Medications"] ValidEncounter
    where ValidEncounter.status = 'finished'
      and ValidEncounter.period during day of "Measurement Period"

define "Initial Population":
  "Qualifying Encounter During Day of Measurement Period" QualifyingEncounter

define "Numerator":
  "Qualifying Encounter During Day of Measurement Period" QualifyingEncounter
    with [Procedure: "Documentation of current medications (procedure)"] MedicationsDocumented
      such that MedicationsDocumented.performed.toInterval ( ) starts during day of QualifyingEncounter.period
        and MedicationsDocumented.performed.toInterval ( ).hasEnd ( )
        and MedicationsDocumented.status = 'completed'

define "Denominator Exceptions":
  "Qualifying Encounter During Day of Measurement Period" QualifyingEncounter
    with [ProcedureNotDone: code ~ "Documentation of current medications (procedure)"] MedicationsNotDocumented
      such that MedicationsNotDocumented.recorded during day of QualifyingEncounter.period
        and MedicationsNotDocumented.status = 'not-done'
        and exists ( MedicationsNotDocumented.reasonCode reasonItem
            where reasonItem ~ "Acute health crisis (finding)"
        )