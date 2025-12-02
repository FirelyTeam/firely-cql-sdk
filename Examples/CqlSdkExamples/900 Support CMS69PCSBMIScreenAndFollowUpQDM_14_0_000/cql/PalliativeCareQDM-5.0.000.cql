library PalliativeCareQDM version '5.0.000'

using QDM version '5.6'

include CQMCommonQDM version '9.0.000' called Global

codesystem "LOINC": 'urn:oid:2.16.840.1.113883.6.1' 

valueset "Palliative Care Diagnosis": 'urn:oid:2.16.840.1.113883.3.464.1003.1167' 
valueset "Palliative Care Encounter": 'urn:oid:2.16.840.1.113883.3.464.1003.101.12.1090' 
valueset "Palliative Care Intervention": 'urn:oid:2.16.840.1.113883.3.464.1003.198.12.1135' 

code "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)": '71007-9' from "LOINC" display 'Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Has Palliative Care in the Measurement Period":
  exists ( ["Assessment, Performed": "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)"] PalliativeAssessment
      where Global."NormalizeInterval" ( PalliativeAssessment.relevantDatetime, PalliativeAssessment.relevantPeriod ) overlaps day of "Measurement Period"
  )
    or exists ( ["Diagnosis": "Palliative Care Diagnosis"] PalliativeDiagnosis
        where PalliativeDiagnosis.prevalencePeriod overlaps day of "Measurement Period"
    )
    or exists ( ["Encounter, Performed": "Palliative Care Encounter"] PalliativeEncounter
        where PalliativeEncounter.relevantPeriod overlaps day of "Measurement Period"
    )
    or exists ( ["Intervention, Performed": "Palliative Care Intervention"] PalliativeIntervention
        where Global."NormalizeInterval" ( PalliativeIntervention.relevantDatetime, PalliativeIntervention.relevantPeriod ) overlaps day of "Measurement Period"
    )