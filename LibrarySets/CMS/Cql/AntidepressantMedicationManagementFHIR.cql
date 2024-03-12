library AntidepressantMedicationManagementFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include Hospice version '6.9.000' called Hospice
include CumulativeMedicationDuration version '4.0.000' called CMD
include Status version '1.6.000' called Status
include QICoreCommon version '2.0.000' called QICoreCommon
include CQMCommon version '2.0.000' called CQMCommon

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Antidepressant Medication": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Major Depression": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Initial Population":
  AgeInYearsAt(date from "April 30 of the Measurement Period") >= 18
    and "Has Initial Major Depression Diagnosis"
    and exists "Qualifying Encounters"

define "April 30 of the Measurement Period":
  DateTime((year from start of "Measurement Period"), 4, 30, 23, 59, 59, 0, 0)

define "Has Initial Major Depression Diagnosis":
  exists ( ["Condition": "Major Depression"] MajorDepression
      let IPSD: "Earliest Antidepressant Dispensed During Intake Period"
      where IPSD is not null
        and date from start of QICoreCommon."ToPrevalenceInterval" ( MajorDepression ) within 60 days of IPSD
  )

define "Earliest Antidepressant Dispensed During Intake Period":
  First((Status."Dispensed Medication"(["MedicationDispense": "Antidepressant Medication"])) Antidepressant
      where start of CMD."MedicationDispensePeriod"(Antidepressant) in day of "Intake Period"
      return {
        AntidepressantDate: date from start of CMD."MedicationDispensePeriod"(Antidepressant)
      }
      sort by AntidepressantDate
  ).AntidepressantDate

define "Intake Period":
  Interval["May 1 of the Year Prior to the Measurement Period", "April 30 of the Measurement Period"]

define "May 1 of the Year Prior to the Measurement Period":
  DateTime((year from start of "Measurement Period" - 1), 5, 1, 0, 0, 0, 0, 0)

define "Qualifying Encounters":
  ( ["Encounter": "Office Visit"]
    union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
    union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
    union ["Encounter": "Home Healthcare Services"]
    union ["Encounter": "Annual Wellness Visit"]
    union ["Encounter": "Nursing Facility Visit"]
    union ["Encounter": "Psych Visit Diagnostic Evaluation"]
    union ["Encounter": "Psych Visit Psychotherapy"]
    union ["Encounter": "Telephone Visits"]
    union ["Encounter": "Online Assessments"] ) ValidEncounter
    let IPSD: "Earliest Antidepressant Dispensed During Intake Period"
    where date from start of QICoreCommon."ToInterval" ( ValidEncounter.period ) within 60 days of IPSD

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists ( ( Status."Active Medication" ( ["MedicationRequest": "Antidepressant Medication"] ) ) ActiveAntidepressant
        let dosage: singleton from ActiveAntidepressant.dosageInstruction,
        timing: dosage.timing,
        boundsPeriod: timing.repeat.bounds,
        ActiveMedPeriod: boundsPeriod Meds
          return Meds
            intersect Interval[start of "Intake Period", end of "Measurement Period"],
        IPSD: "Earliest Antidepressant Dispensed During Intake Period"
        where IPSD is not null
          and CQMCommon."ToDateInterval" ( ActiveMedPeriod ) overlaps Interval[IPSD - 105 days, IPSD )
    )

define "Numerator 1":
  "Cumulative Medication Duration Greater Than or Equal to 84 Days"

define "Cumulative Medication Duration Greater Than or Equal to 84 Days":
  CMD."CumulativeDuration" ( "Antidepressant Medication Period Between IPSD and 114 Days After IPSD" ) >= 84

define "Antidepressant Medication Period Between IPSD and 114 Days After IPSD":
  ( Status."Dispensed Medication" ( ["MedicationDispense": "Antidepressant Medication"] ) ) Antidepressant
    let IPSD: "Earliest Antidepressant Dispensed During Intake Period",
    MedicationPeriod: CMD."MedicationDispensePeriod" ( Antidepressant )
    return MedicationPeriod
      intersect Interval[IPSD, IPSD + 114 days]

define "Numerator 2":
  "Cumulative Medication Duration Greater Than or Equal to 180 Days"

define "Cumulative Medication Duration Greater Than or Equal to 180 Days":
  CMD."CumulativeDuration" ( "Antidepressant Medication Period Between IPSD and 231 Days After IPSD" ) >= 180

define "Antidepressant Medication Period Between IPSD and 231 Days After IPSD":
  ( Status."Dispensed Medication" ( ["MedicationDispense": "Antidepressant Medication"] ) ) Antidepressant
    let IPSD: "Earliest Antidepressant Dispensed During Intake Period",
    MedicationPeriod: CMD."MedicationDispensePeriod" ( Antidepressant )
    return MedicationPeriod
      intersect Interval[IPSD, IPSD + 231 days]

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"