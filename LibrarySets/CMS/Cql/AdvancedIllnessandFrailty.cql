library AdvancedIllnessandFrailty version '1.8.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include CQMCommon version '2.0.000' called CQMCommon
include CumulativeMedicationDuration version '4.0.000' called CMD
include Status version '1.6.000' called Status

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Acute Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083'
valueset "Advanced Illness": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082'
valueset "Dementia Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Frailty Device": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300'
valueset "Frailty Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074'
valueset "Frailty Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088'
valueset "Frailty Symptom": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075'
valueset "Nonacute Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084'
valueset "Observation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086'
valueset "Outpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087'

code "Housing status": '71802-3' from "LOINC" display 'Housing status'
code "Lives in a nursing home (finding)": '160734000' from "SNOMEDCT" display 'Lives in a nursing home (finding)'
code "Medical equipment used": '98181-1' from "LOINC" display 'Medical equipment used'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Is Age 66 or Older with Advanced Illness and Frailty":
   AgeInYearsAt(date from end of "Measurement Period")>= 66
    and "Has Criteria Indicating Frailty"
    and ( "Has Two Outpatient Encounters with Advanced Illness on Different Dates of Service"
        or "Has Inpatient Encounter with Advanced Illness"
        or "Has Dementia Medications in Year Before or During Measurement Period"
    )

define "Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty":
  ( AgeInYearsAt(date from end of "Measurement Period")in Interval[66, 80]
      and "Has Criteria Indicating Frailty"
      and ( "Has Two Outpatient Encounters with Advanced Illness on Different Dates of Service"
          or "Has Inpatient Encounter with Advanced Illness"
          or "Has Dementia Medications in Year Before or During Measurement Period"
      )
  )
    or ( AgeInYearsAt(date from end of "Measurement Period")>= 81
        and "Has Criteria Indicating Frailty"
    )

define "Has Criteria Indicating Frailty":
  exists ( (([DeviceRequest: "Frailty Device"]).isDeviceOrder()) FrailtyDeviceOrder
      where FrailtyDeviceOrder.doNotPerform() is not true
      and FrailtyDeviceOrder.authoredOn.toInterval() during day of "Measurement Period"
  )
    or exists ( (([Observation: "Medical equipment used"]).isAssessmentPerformed()) EquipmentUsed
        where EquipmentUsed.value as Concept in "Frailty Device" 
        and EquipmentUsed.effective.toInterval() ends during day of "Measurement Period"
    )
    or exists ( ([Condition: "Frailty Diagnosis"]) FrailtyDiagnosis
        where FrailtyDiagnosis.prevalenceInterval() overlaps day of "Measurement Period"
    )
    or exists ( (([Encounter: "Frailty Encounter"]).isEncounterPerformed()) FrailtyEncounter
        where FrailtyEncounter.period.toInterval() overlaps day of "Measurement Period"
    )
    or exists ( (([Observation: "Frailty Symptom"]).isSymptom()) FrailtySymptom
        where FrailtySymptom.effective.toInterval() overlaps day of "Measurement Period"
    )

define "Has Two Outpatient Encounters with Advanced Illness on Different Dates of Service":
  exists ( from
      "Outpatient Encounters with Advanced Illness" OutpatientEncounter1,
      "Outpatient Encounters with Advanced Illness" OutpatientEncounter2
      where OutpatientEncounter2.period ends 1 day or more after day of 
      end of OutpatientEncounter1.period
      return OutpatientEncounter1
  )

define "Outpatient Encounters with Advanced Illness":
   (( [Encounter: "Outpatient"]
    union [Encounter: "Observation"]
    union [Encounter: "Emergency Department Evaluation and Management Visit"]
    union [Encounter: "Nonacute Inpatient"] ).isEncounterPerformed()) OutpatientEncounter
      where exists ((OutpatientEncounter.encounterDiagnosis()) Diagnosis where Diagnosis.code in "Advanced Illness")
        and OutpatientEncounter.period.toInterval() starts during day of Interval[start of "Measurement Period" - 1 year, 
        end of "Measurement Period"]

define "Has Inpatient Encounter with Advanced Illness":
  exists ( ( ([Encounter: "Acute Inpatient"]).isEncounterPerformed()) InpatientEncounter
      where exists ((InpatientEncounter.encounterDiagnosis()) Diagnosis where Diagnosis.code in "Advanced Illness")
        and InpatientEncounter.period.toInterval() starts during day of Interval[start of "Measurement Period" - 1 year, 
          end of "Measurement Period"]
  )

define "Has Dementia Medications in Year Before or During Measurement Period":
  exists (( ([MedicationRequest: "Dementia Medications"]).isMedicationActive()) DementiaMedication
      where DementiaMedication.doNotPerform is not true and
      CMD."MedicationRequestPeriod" ( DementiaMedication ) overlaps day of Interval[start of "Measurement Period" - 1 year, 
        end of "Measurement Period"]
  )

define "Is Age 66 or Older Living Long Term in a Nursing Home":
  AgeInYearsAt(date from 
     end of "Measurement Period"
  )>= 66
    and ( ( Last( (([Observation: "Housing status"]).isAssessmentPerformed()) HousingStatus    
          where HousingStatus.effective.toInterval() ends on or before 
          day of end of "Measurement Period"
          sort by 
          end of effective.toInterval() asc
      )) LastHousingStatus
        where LastHousingStatus.value ~ "Lives in a nursing home (finding)"
    ) is not null