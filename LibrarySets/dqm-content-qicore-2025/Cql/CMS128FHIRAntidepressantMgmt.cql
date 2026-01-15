library CMS128FHIRAntidepressantMgmt version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include Hospice version '6.18.000' called Hospice
include CumulativeMedicationDuration version '6.0.000' called CMD
include Status version '1.15.000' called Status
include QICoreCommon version '4.0.000' called QICoreCommon
include CQMCommon version '4.1.000' called CQMCommon

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Antidepressant Medication": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Major Depression": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(date from "IPSD") >= 18
    and "Has IPSD and Major Depression Diagnosis"
    and exists "Qualifying Encounters"

define "April 30 of the Measurement Period":
  DateTime((year from start of "Measurement Period"), 4, 30, 23, 59, 59, 0, 0)

define "Has IPSD and Major Depression Diagnosis":
  exists ( ( ( [ConditionProblemsHealthConcerns: "Major Depression"]
        union [ConditionEncounterDiagnosis: "Major Depression"]
    ).verified ( ) ) MajorDepression
      where "IPSD" is not null
        and date from start of MajorDepression.prevalenceInterval ( ) within 60 days of "IPSD"
  )

define "IPSD":
  First((([MedicationDispense: "Antidepressant Medication"]).isMedicationDispensed()) Antidepressant
      where start of Antidepressant.medicationDispensePeriod() in day of "Intake Period"
      return {
        AntidepressantDate: date from start of Antidepressant.medicationDispensePeriod()
      }
      sort by AntidepressantDate
  ).AntidepressantDate

define "Intake Period":
  Interval["May 1 of the Year Prior to the Measurement Period", "April 30 of the Measurement Period"]

define "May 1 of the Year Prior to the Measurement Period":
  DateTime((year from start of "Measurement Period" - 1), 5, 1, 0, 0, 0, 0, 0)

define "Qualifying Encounters":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Annual Wellness Visit"]
      union [Encounter: "Nursing Facility Visit"]
      union [Encounter: "Psych Visit Diagnostic Evaluation"]
      union [Encounter: "Psych Visit Psychotherapy"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Virtual Encounter"]
  ).isEncounterPerformed ( ) ) ValidEncounter
    where date from start of ValidEncounter.period within 60 days of "IPSD"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists ( ( ( [MedicationRequest: "Antidepressant Medication"] ).isMedicationActive ( ) ) ActiveAntidepressant
        where "IPSD" is not null
          and CQMCommon.ToDateInterval ( ActiveAntidepressant.medicationRequestPeriod ( ) ) overlaps Interval["IPSD" - 105 days, "IPSD" )
    )

define "Numerator 1":
  "Cumulative Medication Duration Greater Than or Equal to 84 Days"

define "Cumulative Medication Duration Greater Than or Equal to 84 Days":
  ( "Antidepressant Medication Period Between IPSD and 114 Days After IPSD".cumulativeDuration ( ) ) >= 84

define "Antidepressant Medication Period Between IPSD and 114 Days After IPSD":
  ( ( [MedicationDispense: "Antidepressant Medication"] ).isMedicationDispensed ( ) ) Antidepressant
    let MedicationPeriod: Antidepressant.medicationDispensePeriod ( )
    return MedicationPeriod
      intersect Interval["IPSD", "IPSD" + 114 days]

define "Numerator 2":
  "Cumulative Medication Duration Greater Than or Equal to 180 Days"

define "Cumulative Medication Duration Greater Than or Equal to 180 Days":
  ( "Antidepressant Medication Period Between IPSD and 231 Days After IPSD".cumulativeDuration ( ) ) >= 180

define "Antidepressant Medication Period Between IPSD and 231 Days After IPSD":
  ( ( [MedicationDispense: "Antidepressant Medication"] ).isMedicationDispensed ( ) ) Antidepressant
    let MedicationPeriod: Antidepressant.medicationDispensePeriod ( )
    return MedicationPeriod
      intersect Interval["IPSD", "IPSD" + 231 days]

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"