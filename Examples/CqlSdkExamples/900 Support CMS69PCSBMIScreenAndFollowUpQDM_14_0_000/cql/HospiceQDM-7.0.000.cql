library HospiceQDM version '7.0.000'

using QDM version '5.6'

include CQMCommonQDM version '9.0.000' called Global

codesystem "SNOMEDCT": 'urn:oid:2.16.840.1.113883.6.96' 
codesystem "LOINC": 'urn:oid:2.16.840.1.113883.6.1' 

valueset "Encounter Inpatient": 'urn:oid:2.16.840.1.113883.3.666.5.307' 
valueset "Hospice Care Ambulatory": 'urn:oid:2.16.840.1.113883.3.526.3.1584' 
valueset "Hospice Diagnosis": 'urn:oid:2.16.840.1.113883.3.464.1003.1165' 
valueset "Hospice Encounter": 'urn:oid:2.16.840.1.113883.3.464.1003.1003' 

code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428361000124107' from "SNOMEDCT" display 'Discharge to home for hospice care (procedure)'
code "Hospice care [Minimum Data Set]": '45755-6' from "LOINC" display 'Hospice care [Minimum Data Set]'
code "Yes (qualifier value)": '373066001' from "SNOMEDCT" display 'Yes (qualifier value)'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Has Hospice Services":
  exists ( ["Encounter, Performed": "Encounter Inpatient"] InpatientEncounter
      where ( InpatientEncounter.dischargeDisposition ~ "Discharge to home for hospice care (procedure)"
          or InpatientEncounter.dischargeDisposition ~ "Discharge to healthcare facility for hospice care (procedure)"
      )
        and InpatientEncounter.relevantPeriod ends during day of "Measurement Period"
  )
    or exists ( ["Encounter, Performed": "Hospice Encounter"] HospiceEncounter
        where HospiceEncounter.relevantPeriod overlaps day of "Measurement Period"
    )
    or exists ( ["Assessment, Performed": "Hospice care [Minimum Data Set]"] HospiceAssessment
        where HospiceAssessment.result ~ "Yes (qualifier value)"
          and Global."NormalizeInterval" ( HospiceAssessment.relevantDatetime, HospiceAssessment.relevantPeriod ) overlaps day of "Measurement Period"
    )
    or exists ( ["Intervention, Order": "Hospice Care Ambulatory"] HospiceOrder
        where HospiceOrder.authorDatetime during day of "Measurement Period"
    )
    or exists ( ["Intervention, Performed": "Hospice Care Ambulatory"] HospicePerformed
        where Global."NormalizeInterval" ( HospicePerformed.relevantDatetime, HospicePerformed.relevantPeriod ) overlaps day of "Measurement Period"
    )
  or exists ( ["Diagnosis": "Hospice Diagnosis"] HospiceCareDiagnosis
        where HospiceCareDiagnosis.prevalencePeriod overlaps day of "Measurement Period"
    )