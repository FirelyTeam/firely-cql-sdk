library AdvancedIllnessandFrailtyExclusionECQMFHIR4 version '5.17.000'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global
include CumulativeMedicationDurationFHIR4 version '1.0.000' called CMD

valueset "Acute Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083' 
valueset "Advanced Illness": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082' 
valueset "Care Services in Long-Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014' 
valueset "Dementia Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510' 
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010' 
valueset "Frailty Device": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300' 
valueset "Frailty Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074' 
valueset "Frailty Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088' 
valueset "Frailty Symptom": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075' 
valueset "Nonacute Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084' 
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012' 
valueset "Observation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086' 
valueset "Outpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087' 

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Dementia Medications In Year Before or During Measurement Period":
  [MedicationRequest: "Dementia Medications"] DementiaMed
                where DementiaMed.status = 'active'
                  and DementiaMed.intent = 'order'
                  and CMD."MedicationPeriod"(DementiaMed)overlaps Interval[( start of "Measurement Period" - 1 year ), 
                  end of "Measurement Period"]

define "Long Term Care Periods During Measurement Period":
  ( [Encounter: "Care Services in Long-Term Residential Facility"]
                union [Encounter: "Nursing Facility Visit"] ) LongTermFacilityEncounter
                where LongTermFacilityEncounter.status = 'finished'
                  and Global."Normalize Interval" ( LongTermFacilityEncounter.period ) overlaps "Measurement Period"
                return Global."Normalize Interval" ( LongTermFacilityEncounter.period )
                  intersect "Measurement Period"

define "Two Outpatient Encounters with Advanced Illness on Different Dates of Service":
  from
                "Outpatient Encounters with Advanced Illness" OutpatientEncounter1,
                "Outpatient Encounters with Advanced Illness" OutpatientEncounter2
                where OutpatientEncounter2.period ends 1 day or more after day of 
                end of OutpatientEncounter1.period
                return OutpatientEncounter1

define "Long Term Care Overlapping Periods":
  collapse ( "Long Term Care Periods During Measurement Period" )

define "Long Term Care Adjacent Periods":
  from
                "Long Term Care Overlapping Periods" LTCPeriod1,
                "Long Term Care Overlapping Periods" LTCPeriod2
                where 
                end of LTCPeriod1 within 1 day of start of LTCPeriod2
                return Interval[start of LTCPeriod1, 
                end of LTCPeriod2]

define "Max Long Term Care Period Length":
  Max((collapse("Long Term Care Overlapping Periods"
                    union "Long Term Care Adjacent Periods"
                ))LTCPeriods
                  return duration in days of LTCPeriods
              )

define "Inpatient Encounter with Advanced Illness":
  ( [Encounter: "Acute Inpatient"] AcuteInpatient
                where AcuteInpatient.status = 'finished' ) InpatientEncounter
                with [Condition: "Advanced Illness"] AdvancedIllnessDiagnosis
                  such that AdvancedIllnessDiagnosis in Global.EncounterDiagnosis ( InpatientEncounter )
                    and Global."Normalize Interval" ( InpatientEncounter.period ) starts 2 years or less on or before 
                    end of "Measurement Period"

define "Outpatient Encounters with Advanced Illness":
  ( ( [Encounter: "Outpatient"]
                union [Encounter: "Observation"]
                union [Encounter: "Emergency Department Visit"]
                union [Encounter: "Nonacute Inpatient"] ) Outpatient
                where Outpatient.status = 'finished' ) OutpatientEncounter
                with [Condition: "Advanced Illness"] AdvancedIllnessDiagnosis
                  such that AdvancedIllnessDiagnosis in Global.EncounterDiagnosis ( OutpatientEncounter )
                    and Global."Normalize Interval" ( OutpatientEncounter.period ) starts 2 years or less on or before 
                    end of "Measurement Period"

define "Advanced Illness and Frailty Exclusion Including Over Age 80":
  ( AgeInYearsAt(date from start of "Measurement Period")in Interval[65, 79]
                  and "Has Criteria Indicating Frailty"
                  and ( exists "Two Outpatient Encounters with Advanced Illness on Different Dates of Service"
                      or exists ( "Inpatient Encounter with Advanced Illness" )
                      or exists "Dementia Medications In Year Before or During Measurement Period"
                  )
              )
                or ( AgeInYearsAt(date from start of "Measurement Period")>= 80
                    and "Has Criteria Indicating Frailty"
                )

define "Advanced Illness and Frailty Exclusion Not Including Over Age 80":
  AgeInYearsAt(date from start of "Measurement Period")>= 65
                and "Has Criteria Indicating Frailty"
                and ( exists "Two Outpatient Encounters with Advanced Illness on Different Dates of Service"
                    or exists ( "Inpatient Encounter with Advanced Illness" )
                    or exists "Dementia Medications In Year Before or During Measurement Period"
                )

define "Has Criteria Indicating Frailty":
  exists ( [DeviceRequest: "Frailty Device"] FrailtyDeviceOrder
                where FrailtyDeviceOrder.status in { 'active', 'on-hold', 'completed' }
                  and FrailtyDeviceOrder.intent = 'order'
                  and Global."Normalize Interval" ( FrailtyDeviceOrder.authoredOn ) during "Measurement Period"
            )
              or exists ( [Observation: "Frailty Device"] FrailtyDeviceApplied
                  where FrailtyDeviceApplied.status in { 'final', 'amended', 'corrected' }
                    and Global."Normalize Interval" ( FrailtyDeviceApplied.effective ) overlaps "Measurement Period"
              )
           or exists  ( [Condition: "Frailty Diagnosis"] FrailtyDiagnosis
                where Global."Prevalence Period" ( FrailtyDiagnosis ) overlaps "Measurement Period"
            )
              or exists ( [Encounter: "Frailty Encounter"] FrailtyEncounter
                  where FrailtyEncounter.status = 'finished'
                    and Global."Normalize Interval" ( FrailtyEncounter.period ) overlaps "Measurement Period"
              )
              or exists ( [Observation: "Frailty Symptom"] FrailtySymptom
                  where FrailtySymptom.status in { 'preliminary', 'final', 'amended', 'corrected' }
                    and Global."Normalize Interval" ( FrailtySymptom.effective ) overlaps "Measurement Period"
              )

define "Has Long Term Care Periods Longer Than 90 Consecutive Days":
  "Max Long Term Care Period Length" > 90

