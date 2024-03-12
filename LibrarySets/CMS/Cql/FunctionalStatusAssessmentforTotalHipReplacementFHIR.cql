library FunctionalStatusAssessmentforTotalHipReplacementFHIR version '0.0.008'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include Hospice version '6.9.000' called Hospice
include Status version '1.6.000' called Status

codesystem "LOINC": 'http://loinc.org'
codesystem "CPT": 'http://www.ama-assn.org/go/cpt'
codesystem "ConditionCategoryCodes": 'http://terminology.hl7.org/CodeSystem/condition-category'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ObservationCategoryCodes": 'http://terminology.hl7.org/CodeSystem/v3-ObservationCategory'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Ethnicity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837'
valueset "Lower Body Fractures Excluding Ankle and Foot": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178'
valueset "Malignant Neoplasms of Lower and Unspecified Limbs": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180'
valueset "Mechanical Complications Excluding Upper Body": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "ONC Administrative Sex": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Partial Arthroplasty of Hip": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184'
valueset "Payer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591'
valueset "Primary THA Procedure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006'
valueset "Race": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836'
valueset "Removal, Revision and Supplement Procedures of the Lower Body and Spine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

code "Activities of daily living score [HOOS]": '72095-3' from "LOINC" display 'Activities of daily living score [HOOS]'
code "Dead (finding)": '419099009' from "SNOMEDCT" display 'Dead (finding)'
code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to home for hospice care (procedure)'
code "Hospice care [Minimum Data Set]": '45755-6' from "LOINC" display 'Hospice care [Minimum Data Set]'
code "Pain score [HOOS]": '72097-9' from "LOINC" display 'Pain score [HOOS]'
code "Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure": '99024' from "CPT" display 'Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure'
code "PROMIS-10 Global Mental Health (GMH) score T-score": '71969-0' from "LOINC" display 'PROMIS-10 Global Mental Health (GMH) score T-score'
code "PROMIS-10 Global Physical Health (GPH) score T-score": '71971-6' from "LOINC" display 'PROMIS-10 Global Physical Health (GPH) score T-score'
code "Quality of life score [HOOS]": '72093-8' from "LOINC" display 'Quality of life score [HOOS]'
code "Severe cognitive impairment (finding)": '702956004' from "SNOMEDCT" display 'Severe cognitive impairment (finding)'
code "Sport-recreation score [HOOS]": '72094-6' from "LOINC" display 'Sport-recreation score [HOOS]'
code "survey": 'survey' from "ObservationCategoryCodes" display 'Survey'
code "Symptoms score [HOOS]": '72096-1' from "LOINC" display 'Symptoms score [HOOS]'
code "Total interval score [HOOSJR]": '82323-7' from "LOINC" display 'Total interval score [HOOSJR]'
code "VR-12 Mental component summary (MCS) score - oblique method T-score": '72026-8' from "LOINC" display 'VR-12 Mental component summary (MCS) score - oblique method T-score'
code "VR-12 Mental component summary (MCS) score - orthogonal method T-score": '72028-4' from "LOINC" display 'VR-12 Mental component summary (MCS) score - orthogonal method T-score'
code "VR-12 Physical component summary (PCS) score - oblique method T-score": '72025-0' from "LOINC" display 'VR-12 Physical component summary (PCS) score - oblique method T-score'
code "VR-12 Physical component summary (PCS) score - orthogonal method T-score": '72027-6' from "LOINC" display 'VR-12 Physical component summary (PCS) score - orthogonal method T-score'
code "Yes (qualifier value)": '373066001' from "SNOMEDCT" display 'Yes (qualifier value)'

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

define "Initial Population":
  "Has Qualifying Encounter"
    and exists ( "Total Hip Arthroplasty Procedure" )
    and AgeInYearsAt(date from start of "Measurement Period") >= 19

define "Has Qualifying Encounter":
  exists ( ( ( [Encounter: "Outpatient Consultation"]
        union [Encounter: "Office Visit"]
        union ( [Encounter] E
            where exists ( ( E.type ) T
                where T ~ "Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure"
            )
        )
        union [Encounter: "Telephone Visits"]
        union [Encounter: "Online Assessments"]
    ).isEncounterPerformed ( ) ) ValidEncounters
      where ValidEncounters.period.toInterval ( ) during day of Interval["November 1 Year Prior to the Measurement Period", end of "Measurement Period"]
  )

define "November 1 Year Prior to the Measurement Period":
  DateTime((year from start of "Measurement Period" - 1), 11, 1, 0, 0, 0, 0, 0)

define "Total Hip Arthroplasty Procedure":
  ( ( [Procedure: "Primary THA Procedure"] ).isProcedurePerformed ( ) ) THAProcedure
    where THAProcedure.performed.toInterval ( ) starts during day of Interval["November 1 Two Years Prior to the Measurement Period", "October 31 Year Prior to the Measurement Period"]

define "November 1 Two Years Prior to the Measurement Period":
  DateTime((year from start of "Measurement Period" - 2), 11, 1, 0, 0, 0, 0, 0)

define "October 31 Year Prior to the Measurement Period":
  DateTime((year from start of "Measurement Period" - 1), 10, 31, 23, 59, 59, 0, 0)

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or "Has Severe Cognitive Impairment"
    or "Has Total Hip Arthroplasty with 1 or More Lower Body Fractures"
    or "Has Partial Hip Arthroplasty Procedure"
    or "Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure"
    or "Has Malignant Neoplasm of Lower and Unspecified Limbs"
    or "Has Mechanical Complication"
    or "Has More Than One Elective Primary Total Hip Arthroplasty Performed"
    or "Death Within 300 Days of the THA Procedure"

define "Has Severe Cognitive Impairment":
  exists [Condition: "Severe cognitive impairment (finding)"] Dementia
    where Dementia.prevalenceInterval ( ) overlaps "Measurement Period"

define "Has Total Hip Arthroplasty with 1 or More Lower Body Fractures":
  exists ( "Total Hip Arthroplasty Procedure" THAProcedure
      with [Condition: "Lower Body Fractures Excluding Ankle and Foot"] LowerBodyFracture
        such that LowerBodyFracture.prevalenceInterval ( ) starts 24 hours or less on or before start of THAProcedure.performed."toInterval" ( )
  )

define "Has Partial Hip Arthroplasty Procedure":
  exists ( ( ( [Procedure: "Partial Arthroplasty of Hip"] ).isProcedurePerformed ( ) ) PartialTHAProcedure
      with "Total Hip Arthroplasty Procedure" THAProcedure
        such that PartialTHAProcedure.performed.toInterval ( ) during day of THAProcedure.performed.toInterval ( )
  )

define "Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure":
  exists ( "Total Hip Arthroplasty Procedure" THAProcedure
      with ( ( [Procedure: "Removal, Revision and Supplement Procedures of the Lower Body and Spine"] ).isProcedurePerformed ( ) ) RevisionTHAProcedure
        such that RevisionTHAProcedure.performed.toInterval ( ) during day of THAProcedure.performed.toInterval ( )
  )

define "Has Malignant Neoplasm of Lower and Unspecified Limbs":
  exists ( [Condition: "Malignant Neoplasms of Lower and Unspecified Limbs"] MalignantNeoplasm
      with "Total Hip Arthroplasty Procedure" THAProcedure
        such that MalignantNeoplasm.prevalenceInterval ( ) overlaps THAProcedure.performed.toInterval ( )
  )

define "Has Mechanical Complication":
  exists ( [Condition: "Mechanical Complications Excluding Upper Body"] MechanicalComplications
      with "Total Hip Arthroplasty Procedure" THAProcedure
        such that MechanicalComplications.prevalenceInterval ( ) overlaps THAProcedure.performed.toInterval ( )
  )

define "Has More Than One Elective Primary Total Hip Arthroplasty Performed":
  exists ( "Total Hip Arthroplasty Procedure" THAProcedure
      with ( ( [Procedure: "Primary THA Procedure"] ).isProcedurePerformed ( ) ) ElectiveTHAProcedure
        such that THAProcedure.id !~ ElectiveTHAProcedure.id
          and start of ElectiveTHAProcedure.performed.toInterval ( ) during day of Interval[( start of THAProcedure.performed.toInterval ( ) ) - 1 year, ( start of THAProcedure.performed.toInterval ( ) ) + 1 year]
  )

define "Death Within 300 Days of the THA Procedure":
  exists "Total Hip Arthroplasty Procedure" THAProcedure
    where date from Patient.deceased during day of Interval[date from start of THAProcedure.performed.toInterval ( ), date from start of THAProcedure.performed.toInterval ( ) + 300 days]

define "Numerator":
  ( "Has THA with Initial and Follow Up HOOS Assessments" )
    or ( "Has THA with Initial and Follow Up HOOSJr Assessments" )
    or ( "Has THA with Initial and Follow Up PROMIS10 Assessments" )
    or ( "Has THA with Initial and Follow Up VR12 Oblique Assessments" )
    or ( "Has THA with Initial and Follow Up VR12 Orthogonal Assessments" )

define "Has THA with Initial and Follow Up HOOS Assessments":
  exists ( ( "Total Hip Arthroplasty Procedure" THAProcedure
      return THAProcedure.performed.toInterval ( ) ) TotalHip
      with "Date HOOS Total Assessment Completed" InitialHipAssessmentHOOS
        such that TotalHip starts 90 days or less on or after day of InitialHipAssessmentHOOS
      with "Date HOOS Total Assessment Completed" FollowUpHipAssessmentHOOS
        such that date from FollowUpHipAssessmentHOOS during day of Interval[date from end of TotalHip + 300 days, date from end of TotalHip + 425 days]
  )

define "Date HOOS Total Assessment Completed":
  from
    ( ( [Observation: "Quality of life score [HOOS]"] ).isAssessmentPerformed ( ) ) HOOSLifeQuality,
    ( ( [Observation: "Sport-recreation score [HOOS]"] ).isAssessmentPerformed ( ) ) HOOSSport,
    ( ( [Observation: "Activities of daily living score [HOOS]"] ).isAssessmentPerformed ( ) ) HOOSActivityScore,
    ( ( [Observation: "Symptoms score [HOOS]"] ).isAssessmentPerformed ( ) ) HOOSSymptoms,
    ( ( [Observation: "Pain score [HOOS]"] ).isAssessmentPerformed ( ) ) HOOSPain
    let HOOSLifeQualityDate: date from start of HOOSLifeQuality.effective.toInterval ( ),
    HOOSSportDate: date from start of HOOSSport.effective.toInterval ( ),
    HOOSActivityScoreDate: date from start of HOOSActivityScore.effective.toInterval ( ),
    HOOSSymptomsDate: date from start of HOOSSymptoms.effective.toInterval ( ),
    HOOSPainDate: date from start of HOOSPain.effective.toInterval ( )
    where HOOSLifeQualityDate same day as HOOSSportDate
      and HOOSSport.value is not null
      and HOOSLifeQualityDate same day as HOOSActivityScoreDate
      and HOOSActivityScore.value is not null
      and HOOSLifeQualityDate same day as HOOSSymptomsDate
      and HOOSSymptoms.value is not null
      and HOOSLifeQualityDate same day as HOOSPainDate
      and HOOSPain.value is not null
      and HOOSLifeQuality.value is not null
    return Max({ HOOSLifeQualityDate, HOOSSportDate, HOOSActivityScoreDate, HOOSSymptomsDate, HOOSPainDate })

define "Has THA with Initial and Follow Up HOOSJr Assessments":
  exists ( ( "Total Hip Arthroplasty Procedure" THAProcedure
      return THAProcedure.performed.toInterval ( ) ) TotalHip
      with "Date HOOSJr Total Assessment Completed" InitialHipAssessment
        such that TotalHip starts 90 days or less on or after day of InitialHipAssessment
      with "Date HOOSJr Total Assessment Completed" FollowUpHipAssessment
        such that date from FollowUpHipAssessment during day of Interval[date from end of TotalHip + 300 days, date from end of TotalHip + 425 days]
  )

define "Date HOOSJr Total Assessment Completed":
  ( [Observation: "Total interval score [HOOSJR]"] HOOSJr
    where HOOSJr.value is not null ) DocumentedHOOSJr
    return date from start of DocumentedHOOSJr.effective.toInterval ( )

define "Has THA with Initial and Follow Up PROMIS10 Assessments":
  exists ( ( "Total Hip Arthroplasty Procedure" THAProcedure
      return THAProcedure.performed.toInterval ( ) ) TotalHip
      with "Date PROMIS10 Total Assessment Completed" InitialHipAssessmentPROMIS10
        such that TotalHip starts 90 days or less on or after day of InitialHipAssessmentPROMIS10
      with "Date PROMIS10 Total Assessment Completed" FollowUpHipAssessmentPROMIS10
        such that date from FollowUpHipAssessmentPROMIS10 during day of Interval[date from end of TotalHip + 300 days, date from end of TotalHip + 425 days]
  )

define "Date PROMIS10 Total Assessment Completed":
  from
    [Observation: "PROMIS-10 Global Mental Health (GMH) score T-score"] PROMIS10MentalScore,
    [Observation: "PROMIS-10 Global Physical Health (GPH) score T-score"] PROMIS10PhysicalScore
    let PROMIS10MentalScoreDate: date from start of PROMIS10MentalScore.effective.toInterval ( ),
    PROMIS10PhysicalScoreDate: date from start of PROMIS10PhysicalScore.effective.toInterval ( )
    where PROMIS10MentalScoreDate same day as PROMIS10PhysicalScoreDate
      and PROMIS10PhysicalScore.value is not null
      and PROMIS10MentalScore.value is not null
    return Max({ PROMIS10MentalScoreDate, PROMIS10PhysicalScoreDate })

define "Has THA with Initial and Follow Up VR12 Oblique Assessments":
  exists ( ( "Total Hip Arthroplasty Procedure" THAProcedure
      return THAProcedure.performed.toInterval ( ) ) TotalHip
      with "Date VR12 Oblique Total Assessment Completed" InitialHipAssessmentOblique
        such that TotalHip starts 90 days or less on or after day of InitialHipAssessmentOblique
      with "Date VR12 Oblique Total Assessment Completed" FollowUpHipAssessmentOblique
        such that date from FollowUpHipAssessmentOblique during day of Interval[date from end of TotalHip + 300 days, date from end of TotalHip + 425 days]
  )

define "Date VR12 Oblique Total Assessment Completed":
  from
    [Observation: "VR-12 Mental component summary (MCS) score - oblique method T-score"] VR12MentalAssessment,
    [Observation: "VR-12 Physical component summary (PCS) score - oblique method T-score"] VR12PhysicalAssessment
    let VR12MentalAssessmentDate: date from start of VR12MentalAssessment.effective.toInterval ( ),
    VR12PhysicalAssessmentDate: date from start of VR12PhysicalAssessment.effective.toInterval ( )
    where VR12MentalAssessmentDate same day as VR12PhysicalAssessmentDate
      and VR12MentalAssessment.value is not null
      and VR12PhysicalAssessment.value is not null
    return Max({ VR12MentalAssessmentDate, VR12PhysicalAssessmentDate })

define "Has THA with Initial and Follow Up VR12 Orthogonal Assessments":
  exists ( ( "Total Hip Arthroplasty Procedure" THAProcedure
      return THAProcedure.performed.toInterval ( ) ) TotalHip
      with "Date VR12 Orthogonal Total Assessment Completed" InitialHipAssessmentOrthogonal
        such that TotalHip starts 90 days or less on or after day of InitialHipAssessmentOrthogonal
      with "Date VR12 Orthogonal Total Assessment Completed" FollowUpHipAssessmentOrthogonal
        such that date from FollowUpHipAssessmentOrthogonal during day of Interval[date from end of TotalHip + 300 days, date from end of TotalHip + 425 days]
  )

define "Date VR12 Orthogonal Total Assessment Completed":
  from
    [Observation: "VR-12 Mental component summary (MCS) score - orthogonal method T-score"] VR12MentalAssessment,
    [Observation: "VR-12 Physical component summary (PCS) score - orthogonal method T-score"] VR12PhysicalAssessment
    let VR12MentalAssessmentDate: date from start of VR12MentalAssessment.effective.toInterval ( ),
    VR12PhysicalAssessmentDate: date from start of VR12PhysicalAssessment.effective.toInterval ( )
    where VR12MentalAssessmentDate same day as VR12PhysicalAssessmentDate
      and VR12MentalAssessment.value is not null
      and VR12PhysicalAssessment.value is not null
    return Max({ VR12MentalAssessmentDate, VR12PhysicalAssessmentDate })