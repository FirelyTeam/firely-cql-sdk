library CRLReceiptofSpecialistReportFHIR version '0.3.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Behavioral/Neuropsych Assessment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023'
valueset "Consultant Report": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Ophthalmological Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Referral": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046'

code "Developmental test administration (including assessment of fine and/or gross motor, language, cognitive level, social, memory and/or executive functions by standardized developmental instruments when performed), by physician or other qualified health care professional, with interpretation and report; first hour": '96112' from "CPT" display 'Developmental test administration (including assessment of fine and/or gross motor, language, cognitive level, social, memory and/or executive functions by standardized developmental instruments when performed), by physician or other qualified health care professional, with interpretation and report; first hour'
code "Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)": '96156' from "CPT" display 'Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)'
code "Psychological or neuropsychological test administration and scoring by physician or other qualified health care professional, two or more tests, any method; first 30 minutes": '96136' from "CPT" display 'Psychological or neuropsychological test administration and scoring by physician or other qualified health care professional, two or more tests, any method; first 30 minutes'
code "Psychological or neuropsychological test administration and scoring by technician, two or more tests, any method; first 30 minutes": '96138' from "CPT" display 'Psychological or neuropsychological test administration and scoring by technician, two or more tests, any method; first 30 minutes'
code "Psychotherapy for crisis; first 60 minutes": '90839' from "CPT" display 'Psychotherapy for crisis; first 60 minutes'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.000Z, @2025-12-31T23:59:59.999Z]

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

define "Has Encounter from Valuesets during Measurement Period":
  exists ( ( [Encounter: "Behavioral/Neuropsych Assessment"]
      union [Encounter: "Office Visit"]
      union [Encounter: "Ophthalmological Services"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Psych Visit Diagnostic Evaluation"] ) Encounter
      where Encounter.status = 'finished'
        and Encounter.period during day of "Measurement Period"
  )

define "Has Encounter from DRCs during Measurement Period":
  exists ( ( [Encounter] EncDRC
      where exists ( ( EncDRC.type ) T
          where T ~ "Psychological or neuropsychological test administration and scoring by physician or other qualified health care professional, two or more tests, any method; first 30 minutes"
      )
        or exists ( ( EncDRC.type ) T
            where T ~ "Psychological or neuropsychological test administration and scoring by technician, two or more tests, any method; first 30 minutes"
        )
        or exists ( ( EncDRC.type ) T
            where T ~ "Psychotherapy for crisis; first 60 minutes"
        )
        or exists ( ( EncDRC.type ) T
            where T ~ "Developmental test administration (including assessment of fine and/or gross motor, language, cognitive level, social, memory and/or executive functions by standardized developmental instruments when performed), by physician or other qualified health care professional, with interpretation and report; first hour"
        )
        or exists ( ( EncDRC.type ) T
            where T ~ "Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)"
        ) ) Encounter
      where Encounter.status = 'finished'
        and Encounter.period during day of "Measurement Period"
  )

define "Has Encounter during Measurement Period":
  "Has Encounter from Valuesets during Measurement Period"
    or "Has Encounter from DRCs during Measurement Period"

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