library CRLReceiptofSpecialistReportFHIR version '0.2.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

valueset "Consultant Report": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Ophthalmological Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285'
valueset "Preventive Care Services - Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care Services-Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Referral": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "Denominator":
  "Initial Population"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  "Has Encounter during Measurement Period"
    and "First Referral during First 10 Months of Measurement Period" is not null

define "Has Encounter during Measurement Period":
  exists ( ( [Encounter: "Office Visit"]
      union [Encounter: "Ophthalmological Services"]
      union [Encounter: "Preventive Care Services - Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services-Initial Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"] ) Encounter
      where Encounter.status = 'finished'
        and Encounter.period during day of "Measurement Period"
  )

define "First Referral during First 10 Months of Measurement Period":
  First([ServiceRequest: "Referral"] ReferralOrder
      where ReferralOrder.status in { 'active', 'completed' }
        and ReferralOrder.intent = 'order'
        and ReferralOrder.authoredOn during day of Interval[start of "Measurement Period", Date(year from start of "Measurement Period", 10, 31)]
      return {
        ID: ReferralOrder.id,
        AuthorDate: ReferralOrder.authoredOn
      }
      sort by AuthorDate ascending
  )

define "Numerator":
  "Referring Clinician Receives Consultant Report to Close Referral Loop"

define "Referring Clinician Receives Consultant Report to Close Referral Loop":
  exists ( [Task: "Consultant Report"] ConsultantReportObtained
      with "First Referral during First 10 Months of Measurement Period" FirstReferral
        such that FirstReferral.ID in "TaskGetRequestID"(ConsultantReportObtained)
          and ConsultantReportObtained.executionPeriod ends after FirstReferral.AuthorDate
          and ConsultantReportObtained.status = 'completed'
          and ConsultantReportObtained.executionPeriod ends during day of "Measurement Period"
  )

define function "TaskGetRequestID"(task Task):
  task.basedOn Task
    return QICoreCommon."GetId" ( Task.reference )
