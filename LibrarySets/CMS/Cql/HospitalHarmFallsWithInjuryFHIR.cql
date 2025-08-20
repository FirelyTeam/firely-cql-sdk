library FallsWithInjuryFHIR version '0.0.024'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon
include CQMCommon version '2.2.000' called CQMCommon
include CumulativeMedicationDuration version '4.1.000' called CMD

codesystem "LOINC": 'http://loinc.org' 

valueset "Abnormal Weight Loss and Malnutrition": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.177' 
valueset "Anticoagulants for All Indications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22' 
valueset "Antidepressants": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163' 
valueset "Antihypertensives": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164' 
valueset "Central Nervous System Depressants": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134' 
valueset "Coagulation Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23' 
valueset "Delirium, Dementia, and Other Psychoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168' 
valueset "Depression": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169' 
valueset "Diuretics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170' 
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292' 
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307' 
valueset "Epilepsy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171' 
valueset "Inpatient Falls": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171' 
valueset "Leukemia or Lymphoma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136' 
valueset "Liver Disease Moderate to Severe": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137' 
valueset "Major Injuries": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.174' 
valueset "Malignant Bone Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24' 
valueset "Moderate Injuries": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205' 
valueset "Neurologic Movement and Related Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174' 
valueset "Not Present On Admission or Documentation Insufficient to Determine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198' 
valueset "Obesity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162' 
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143' 
valueset "Opioids": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120' 
valueset "Osteoporosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147' 
valueset "Peripheral Neuropathy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175' 
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197' 
valueset "Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176' 
valueset "Suicide Attempt": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130' 

code "Body mass index (BMI) [Ratio]": '39156-5' from "LOINC" display 'Body mass index (BMI) [Ratio]'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Denominator":
  "Initial Population"

define "Encounter where a Fall and Major Injury Occurred":
  "Encounter where a Fall Occurred" FallOccurred
    where exists ( FallOccurred.diagnosis Dx
        where CQMCommon."GetCondition" ( Dx.condition ).code in "Major Injuries"
          and ( Dx.diagnosisPresentOnAdmission in "Not Present On Admission or Documentation Insufficient to Determine"
              or Dx.diagnosisPresentOnAdmission is null
          )
    )

define "Encounter where a Fall Occurred":
  "Encounter with a Fall Not Present on Admission"
        union "Encounter with a Fall Event"

define "Encounter with a Fall Event":
  "Qualifying Encounter" InpatientEncounter
    with ["AdverseEvent": event in "Inpatient Falls"] FallsDocumentation
      such that Coalesce(FallsDocumentation.date, FallsDocumentation.recordedDate)during CQMCommon."HospitalizationWithObservation" ( InpatientEncounter )

define "Encounter with a Fall Not Present on Admission":
  "Qualifying Encounter" InpatientEncounter
        where exists ( InpatientEncounter.diagnosis Dx
            where CQMCommon."GetCondition" ( Dx.condition ).code in "Inpatient Falls"
              and Dx.diagnosisPresentOnAdmission in "Not Present On Admission or Documentation Insufficient to Determine"
        )

define "Encounter with a Fall Present on Admission":
  "Qualifying Encounter" InpatientEncounter
        where exists ( InpatientEncounter.diagnosis Dx
            where CQMCommon."GetCondition" ( Dx.condition ).code in "Inpatient Falls"
              and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
        )

define "Initial Population":
  "Qualifying Encounter"

define "Risk Variable All Encounter Diagnoses with Rank and POA Indication":
  "Qualifying Encounter" InpatientEncounter
    return Tuple {
      encounterId: InpatientEncounter.id,
      condition: InpatientEncounter.diagnosis.condition,
      rank: InpatientEncounter.diagnosis.rank,
      POA: InpatientEncounter.diagnosis Dx
        where Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
    }

define "Risk Variable All Encounter Principal Diagnoses":
  "Qualifying Encounter" InpatientEncounter
              return Tuple {
                encounter: InpatientEncounter,
                condition: CQMCommon."PrincipalDiagnosis" ( InpatientEncounter ).code
              }

define "Risk Variable Body Mass Index (BMI)":
  from
    ["Observation": "Body mass index (BMI) [Ratio]"] BMI
    with "Qualifying Encounter" InpatientEncounter
      such that QICoreCommon.ToInterval( BMI.effective ) starts during CQMCommon."HospitalizationWithObservation" ( InpatientEncounter )
        and BMI.value is not null
        and BMI.status in { 'final', 'amended', 'corrected' }
    return BMI.value as Quantity

define "Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where exists ( InpatientEncounter.diagnosis Dx
        where CQMCommon."GetCondition" ( Dx.condition ).code in "Abnormal Weight Loss and Malnutrition"
          and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
    )

define "Risk Variable Encounter with Anticoagulant Active at Admission":
  "Qualifying Encounter" InpatientEncounter
        with ["MedicationRequest": "Anticoagulants for All Indications"] Anticoagulants
          such that Anticoagulants.status = 'active'
            and ( Anticoagulants.intent = 'order'
                or ( Anticoagulants.intent = 'plan'
                    and Anticoagulants.reported.reference.getId() = Patient.id
                )
            )
            and Anticoagulants.isCommunity()
            and CMD.MedicationRequestPeriod ( Anticoagulants ) overlaps before InpatientEncounter.period

define "Risk Variable Encounter with Anticoagulant Administration During Encounter":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationAdministration": "Anticoagulants for All Indications"] Anticoagulants
      such that QICoreCommon.ToInterval ( Anticoagulants.effective ) starts during CQMCommon."HospitalizationWithObservation" ( InpatientEncounter )
        and Anticoagulants.status in { 'in-progress', 'completed' }

define "Risk Variable Encounter with Antidepressant Active at Admission":
  "Qualifying Encounter" InpatientEncounter
        with ["MedicationRequest": "Antidepressants"] AntidepressantMed
          such that AntidepressantMed.status = 'active'
            and ( AntidepressantMed.intent = 'order'
                or ( AntidepressantMed.intent = 'plan'
                    and AntidepressantMed.reported.reference.getId() = Patient.id
                )
            )
            and AntidepressantMed.isCommunity()
            and CMD.MedicationRequestPeriod ( AntidepressantMed ) overlaps before InpatientEncounter.period

define "Risk Variable Encounter with Antihypertensive Active at Admission":
  "Qualifying Encounter" InpatientEncounter
          with ["MedicationRequest": "Antihypertensives"] BPMed
            such that BPMed.status = 'active'
              and ( BPMed.intent = 'order'
                  or ( BPMed.intent = 'plan'
                      and BPMed.reported.reference.getId() = Patient.id
                  )
              )
              and BPMed.isCommunity()
              and CMD.MedicationRequestPeriod ( BPMed ) overlaps before InpatientEncounter.period

define "Risk Variable Encounter with CNS Depressant Active at Admission":
  "Qualifying Encounter" InpatientEncounter
          with ["MedicationRequest": "Central Nervous System Depressants"] CNSMed
            such that CNSMed.status = 'active'
              and ( CNSMed.intent = 'order'
                  or ( CNSMed.intent = 'plan'
                      and CNSMed.reported.reference.getId() = Patient.id
                  )
              )
              and CNSMed.isCommunity()
              and CMD.MedicationRequestPeriod ( CNSMed ) overlaps before InpatientEncounter.period

define "Risk Variable Encounter with Coagulation Disorder Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Coagulation Disorders"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Delirium, Dementia or Other Psychosis Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Delirium, Dementia, and Other Psychoses"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Depression Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Depression"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Diuretic Active at Admission":
  "Qualifying Encounter" InpatientEncounter
          with ["MedicationRequest": "Diuretics"] DiureticMed
            such that DiureticMed.status = 'active'
              and ( DiureticMed.intent = 'order'
                  or ( DiureticMed.intent = 'plan'
                      and DiureticMed.reported.reference.getId() = Patient.id
                  )
              )
              and DiureticMed.isCommunity()
              and CMD.MedicationRequestPeriod ( DiureticMed ) overlaps before InpatientEncounter.period

define "Risk Variable Encounter with Epilepsy Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Epilepsy"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with High BMI by Exam":
  "Qualifying Encounter" InpatientEncounter
    with ["Observation": "Body mass index (BMI) [Ratio]"] BMI
      such that QICoreCommon.ToInterval ( BMI.effective ) starts during CQMCommon."HospitalizationWithObservation" ( InpatientEncounter )
        and BMI.value >= 25 'kg/m2'

define "Risk Variable Encounter with Leukemia or Lymphoma Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Leukemia or Lymphoma"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Liver Disease Moderate to Severe"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Low BMI":
  "Qualifying Encounter" InpatientEncounter
                    with ["Observation": "Body mass index (BMI) [Ratio]"] BMI
                      such that QICoreCommon.ToInterval ( BMI.effective ) starts during CQMCommon."HospitalizationWithObservation" ( InpatientEncounter )
                        and BMI.value < 18.5 'kg/m2'

define "Risk Variable Encounter with Malignant Bone Disease Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Malignant Bone Disease"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Neurologic Disorder Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Neurologic Movement and Related Disorders"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Obesity Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Obesity"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Opioid Medication Active at Admission":
  "Qualifying Encounter" InpatientEncounter
          with ["MedicationRequest": "Opioids"] OpioidMed
            such that OpioidMed.status = 'active'
              and ( OpioidMed.intent = 'order'
                  or ( OpioidMed.intent = 'plan'
                      and OpioidMed.reported.reference.getId() = Patient.id
                  )
              )
              and OpioidMed.isCommunity()
              and CMD.MedicationRequestPeriod ( OpioidMed ) overlaps before InpatientEncounter.period

define "Risk Variable Encounter with Osteoporosis Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Osteoporosis"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Peripheral Neuropathy Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Peripheral Neuropathy"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Stroke Present on Admission":
  "Qualifying Encounter" InpatientEncounter
          where exists ( InpatientEncounter.diagnosis Dx
              where CQMCommon."GetCondition" ( Dx.condition ).code in "Stroke"
                and Dx.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
          )

define "Risk Variable Encounter with Suicide Attempt":
  "Qualifying Encounter" InpatientEncounter
                    where CQMCommon."EncounterDiagnosis" ( InpatientEncounter ).code in "Suicide Attempt"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Denominator Exclusions":
  "Encounter with a Fall Present on Admission"

define "Encounter where a Fall and Moderate Injury Occurred":
  "Encounter where a Fall Occurred" FallOccurred
    where exists ( FallOccurred.diagnosis Dx
        where CQMCommon."GetCondition" ( Dx.condition ).code in "Moderate Injuries"
          and ( Dx.diagnosisPresentOnAdmission in "Not Present On Admission or Documentation Insufficient to Determine"
              or Dx.diagnosisPresentOnAdmission is null
          )
    )

define "Numerator":
  "Encounter where a Fall and Major Injury Occurred"
    union "Encounter where a Fall and Moderate Injury Occurred"

define "Qualifying Encounter":
  CQMCommon."Inpatient Encounter" InpatientEncounter
    where AgeInYearsAt(date from start of InpatientEncounter.period)>= 18

define function "Denominator Observation"(QualifyingEncounter Encounter ):
  duration in days of CQMCommon.HospitalizationWithObservation ( QualifyingEncounter )

define function "Numerator Observation"(QualifyingEncounter Encounter ):
  Count("Encounter where a Fall and Major Injury Occurred" FallsEncounter
      where FallsEncounter.period ends during CQMCommon.HospitalizationWithObservation(QualifyingEncounter)
  )

