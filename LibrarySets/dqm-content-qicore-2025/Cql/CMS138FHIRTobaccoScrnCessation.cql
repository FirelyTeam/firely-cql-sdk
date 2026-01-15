library CMS138FHIRTobaccoScrnCessation version '1.0.000'

using QICore version '6.0.0'

include Status version '1.15.000' called Status
include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include Hospice version '6.18.000' called Hospice
include CumulativeMedicationDuration version '6.0.000' called CMD

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'
codesystem "TaskCode": 'http://hl7.org/fhir/CodeSystem/task-code'

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Nutrition Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006'
valueset "Occupational Therapy Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Ophthalmological Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285'
valueset "Physical Therapy Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Group Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027'
valueset "Preventive Care Services Individual Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Psychoanalysis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141'
valueset "Speech and Hearing Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Tobacco Non User": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189'
valueset "Tobacco Use Cessation Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509'
valueset "Tobacco Use Cessation Pharmacotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190'
valueset "Tobacco Use Screening": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278'
valueset "Tobacco User": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

code "Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)": '96156' from "CPT" display 'Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)'
code "Health behavior intervention, individual, face-to-face; initial 30 minutes": '96158' from "CPT" display 'Health behavior intervention, individual, face-to-face; initial 30 minutes'
code "Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure": '99024' from "CPT" display 'Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure'
code "Tobacco abuse counseling": 'Z71.6' from "ICD10CM" display 'Tobacco abuse counseling'
code "Unlisted preventive medicine service": '99429' from "CPT" display 'Unlisted preventive medicine service'
code "fulfill": 'fulfill' from "TaskCode" display 'Fulfill the focal request'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator 1":
  "Initial Population"

define "Denominator 2":
  "Initial Population"
    and "Most Recent Tobacco Use Screening Indicates Tobacco User" is not null

define "Denominator 3":
  "Initial Population"

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") >= 12
    and ( Count("Qualifying Visit During Measurement Period") >= 2
        or exists "Preventive Visit During Measurement Period"
    )

define "Numerator 1":
  "Most Recent Tobacco Use Screening Indicates Tobacco Non User" is not null
    or "Most Recent Tobacco Use Screening Indicates Tobacco User" is not null

define "Numerator 2":
  exists "Tobacco Cessation Counseling Given"
    or exists "Tobacco Cessation Pharmacotherapy Ordered"
    or exists "Active Pharmacotherapy for Tobacco Cessation"

define "Numerator 3":
  "Most Recent Tobacco Use Screening Indicates Tobacco Non User" is not null
    or ( "Most Recent Tobacco Use Screening Indicates Tobacco User" is not null
        and ( exists "Tobacco Cessation Counseling Given"
            or exists "Tobacco Cessation Pharmacotherapy Ordered"
            or exists "Active Pharmacotherapy for Tobacco Cessation"
        )
    )

define "Most Recent Tobacco Use Screening Indicates Tobacco Non User":
  ( Last((([USCoreSmokingStatusProfile]).isObservationSmokingStatus()) TobaccoUseScreening
      where TobaccoUseScreening.effective.toInterval() during day of "Measurement Period"
      sort by start of effective.toInterval()
  ) ) MostRecentTobaccoUseScreening
    where MostRecentTobaccoUseScreening.value as Concept in "Tobacco Non User"

define "Active Pharmacotherapy for Tobacco Cessation":
  ( ( [MedicationRequest: "Tobacco Use Cessation Pharmacotherapy"] ).isMedicationActive ( ) ) TakingCessationPharmacotherapy
    where TakingCessationPharmacotherapy.medicationRequestPeriod ( ) during day of Interval[start of "Measurement Period" - 6 months, end of "Measurement Period"]

define "Most Recent Tobacco Use Screening Indicates Tobacco User":
  ( Last((([USCoreSmokingStatusProfile]).isObservationSmokingStatus()) TobaccoUseScreening
      where TobaccoUseScreening.effective.toInterval() during day of "Measurement Period"
      sort by start of effective.toInterval()
  ) ) MostRecentTobaccoUseScreening
    where MostRecentTobaccoUseScreening.value as Concept in "Tobacco User"

define "Tobacco Cessation Pharmacotherapy Ordered":
  ( ( [MedicationRequest: "Tobacco Use Cessation Pharmacotherapy"] ).isMedicationOrder ( ) ) CessationPharmacotherapyOrdered
    where CessationPharmacotherapyOrdered.authoredOn during day of Interval[start of "Measurement Period" - 6 months, end of "Measurement Period"]
      and not exists ( [TaskRejected] TaskReject
          where TaskReject.focus.references ( CessationPharmacotherapyOrdered )
            and TaskReject.code ~ "fulfill"
      )

define "Tobacco Cessation Counseling Given":
  ( ( ( [Procedure: "Tobacco Use Cessation Counseling"] ).isInterventionPerformed ( ) ) TobaccoCessationCounseling
      where TobaccoCessationCounseling.performed.toInterval ( ) during day of Interval[start of "Measurement Period" - 6 months, end of "Measurement Period"]
  )
    union ( ( ( [ConditionProblemsHealthConcerns: "Tobacco abuse counseling"]
          union [ConditionEncounterDiagnosis: "Tobacco abuse counseling"]
      ).verified ( ) ) TobaccoCounseling
        where TobaccoCounseling.prevalenceInterval ( ) starts during day of Interval[start of "Measurement Period" - 6 months, end of "Measurement Period"]
    )

define "Preventive Visit During Measurement Period":
  ( ( [Encounter: "Annual Wellness Visit"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services Group Counseling"]
      union [Encounter: "Preventive Care Services Individual Counseling"]
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Unlisted preventive medicine service"
          )
      )
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure"
          )
      )
      union [Encounter: "Nutrition Services"]
  ).isEncounterPerformed ( ) ) PreventiveEncounter
    where PreventiveEncounter.period during day of "Measurement Period"

define "Qualifying Visit During Measurement Period":
  ( ( ( [Encounter] E
        where exists ( ( E.type ) T
            where T ~ "Health behavior intervention, individual, face-to-face; initial 30 minutes"
        )
    )
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)"
          )
      )
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Occupational Therapy Evaluation"]
      union [Encounter: "Office Visit"]
      union [Encounter: "Ophthalmological Services"]
      union [Encounter: "Physical Therapy Evaluation"]
      union [Encounter: "Psych Visit Diagnostic Evaluation"]
      union [Encounter: "Psych Visit Psychotherapy"]
      union [Encounter: "Psychoanalysis"]
      union [Encounter: "Speech and Hearing Evaluation"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Virtual Encounter"]
  ).isEncounterPerformed ( ) ) OfficeBasedEncounter
    where OfficeBasedEncounter.period during day of "Measurement Period"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"