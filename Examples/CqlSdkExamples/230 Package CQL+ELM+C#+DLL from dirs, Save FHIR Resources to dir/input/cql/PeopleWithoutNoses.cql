library PeopleWithoutNoses version '1.0.0'

using FHIR version '4.0.1'

parameter "Measurement Period" Interval<DateTime>

include FHIRHelpers version '4.0.001' called FHIRHelpers

codesystem "SNOMED": 'http://snomed.info/sct'

code "Absent nose": '249300009' from "SNOMED" display 'Absence of nose (disorder)'

context Patient

define "Absent Nose Condition":
  [Condition] C
    where exists(C.code.coding coding where coding ~ "Absent nose")
      and (C.onset as FHIR.dateTime) in "Measurement Period"

define "Initial population":
  exists("Absent Nose Condition")