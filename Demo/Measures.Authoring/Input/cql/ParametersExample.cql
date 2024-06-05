library ParametersExample version '0.0.1'

using FHIR version '4.0.1'

include FHIRHelpers version '4.3.000'

valueset "Marital Status": 'http://hl7.org/fhir/ValueSet/marital-status'

parameter "AgeThreshold" Integer default 30

context Patient

define "CurrentDate":
  Today()

define "Patient Filter":
  Patient P
    where P.gender = 'male'
      and P.active is true
      and not(P.deceased)
      and P.maritalStatus in "Marital Status"

define "Patient Birthdate":
  "Patient Filter".birthDate

define "Patient Age in Years":
  years between "Patient Birthdate" and "CurrentDate"

define "Patient Older Than AgeThreshold":
  "Patient Age in Years" > "AgeThreshold"
