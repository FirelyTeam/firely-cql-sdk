library PalliativeCareFHIR version '0.6.000'

using FHIR version '4.0.1'

include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global
include FHIRHelpers version '4.0.001' called FHIRHelpers

codesystem "LOINC": 'http://loinc.org' 
codesystem "ObservationCategoryCodes": 'http://terminology.hl7.org/CodeSystem/observation-category' 

valueset "Palliative Care Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090' 
valueset "Palliative Care Intervention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135' 

code "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)": '71007-9' from "LOINC" display 'Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)'
code "survey": 'survey' from "ObservationCategoryCodes" display 'survey'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Palliative Care in the Measurement Period":
  exists ( [Observation: "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)"] PalliativeAssessment
              where PalliativeAssessment.status in { 'final', 'amended', 'corrected' }
                and exists ( PalliativeAssessment.category PalliativeAssessmentCategory
                    where "survey" in FHIRHelpers.ToConcept ( PalliativeAssessmentCategory ).codes
                )
                and Global."Normalize Interval" ( PalliativeAssessment.effective ) overlaps "Measurement Period"
          )
            or exists ( [Encounter: "Palliative Care Encounter"] PalliativeEncounter
                where PalliativeEncounter.status = 'finished'
                  and Global."Normalize Interval" ( PalliativeEncounter.period ) overlaps "Measurement Period"
            )
            or exists ( [Procedure: "Palliative Care Intervention"] PalliativeIntervention
                where PalliativeIntervention.status in { 'completed', 'in-progress' }
                  and Global."Normalize Interval" ( PalliativeIntervention.performed ) overlaps "Measurement Period"
            )

