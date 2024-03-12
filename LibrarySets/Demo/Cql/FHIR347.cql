library FHIR347 version '0.1.021'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global

codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm' 

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240' 
valueset "Atherosclerosis and Peripheral Arterial Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21' 
valueset "Breastfeeding": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73' 
valueset "CABG Surgeries": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694' 
valueset "CABG, PCI Procedure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566' 
valueset "Carotid Intervention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204' 
valueset "Cerebrovascular Disease, Stroke, TIA": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44' 
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001' 
valueset "End Stage Renal Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353' 
valueset "Hepatitis A": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024' 
valueset "Hepatitis B": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269' 
valueset "High Intensity Statin Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572' 
valueset "Hospice Care Ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584' 
valueset "Hypercholesterolemia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100' 
valueset "Ischemic Heart Disease or Other Related Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46' 
valueset "LDL Cholesterol": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573' 
valueset "Liver Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42' 
valueset "Low Intensity Statin Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574' 
valueset "Moderate Intensity Statin Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575' 
valueset "Myocardial Infarction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403' 
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001' 
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008' 
valueset "Outpatient Encounters for Preventive Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576' 
valueset "Palliative Care Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575' 
valueset "Palliative or Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579' 
valueset "PCI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67' 
valueset "Pregnancy or Other Related Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623' 
valueset "Preventive Care Services - Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025' 
valueset "Preventive Care Services - Other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030' 
valueset "Preventive Care Services-Individual Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026' 
valueset "Preventive Care Services-Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023' 
valueset "Rhabdomyolysis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102' 
valueset "Stable and Unstable Angina": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47' 
valueset "Statin Allergen": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42' 
valueset "Statin Associated Muscle Symptoms": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85' 

code "Encounter for palliative care": 'Z51.5' from "ICD10CM" display 'Encounter for palliative care'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Denominator 1":
  "Initial Population 1"

define "Denominator 2":
  "Initial Population 2"

define "Denominator 3":
  "Initial Population 3"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Patients Age 20 or Older at Start of Measurement Period":
  AgeInYearsAt (start of "Measurement Period") >= 20

define "Initial Population 1":
  exists "ASCVD Diagnosis or Procedure before End of Measurement Period" 
    and exists "Qualifying Encounter during Measurement Period"

define "Initial Population 2":
  "Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD" 
    and exists "Qualifying Encounter during Measurement Period"

define "Initial Population 3":
  "Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia" 
    and exists "Qualifying Encounter during Measurement Period"

define "ASCVD Diagnosis or Procedure before End of Measurement Period":
  ( ( [Condition: "Myocardial Infarction"]
        union [Condition: "Cerebrovascular Disease, Stroke, TIA"]
        union [Condition: "Atherosclerosis and Peripheral Arterial Disease"]
        union [Condition: "Ischemic Heart Disease or Other Related Diagnoses"]
        union [Condition: "Stable and Unstable Angina"] ) ASCVDDiagnosis
            where Global."Prevalence Period" ( ASCVDDiagnosis ) starts before end of "Measurement Period")
        union ( ( [Procedure: "PCI"]
        union [Procedure: "CABG Surgeries"]
        union [Procedure: "Carotid Intervention"]
        union [Procedure: "CABG, PCI Procedure"] ) ASCVDProcedure
            where Global."Normalize Interval" ( ASCVDProcedure.performed ) starts before end of "Measurement Period" 
            and ASCVDProcedure.status = 'completed'
    )

define "Denominator Exceptions":
  "Has Allergy to Statin" 
        or "Has Order or Receiving Hospice Care or Palliative Care"
        or "Has Hepatitis or Liver Disease Diagnosis"
        or "Has Statin Associated Muscle Symptoms"
        or "Has ESRD Diagnosis"
        or "Has Adverse Reaction to Statin"

define "Denominator Exclusions":
  exists ( ( [Condition: "Pregnancy or Other Related Diagnoses"]
        union [Condition: "Breastfeeding"]
        union [Condition: "Rhabdomyolysis"] ) ExclusionDiagnosis
        where Global."Prevalence Period" ( ExclusionDiagnosis ) overlaps "Measurement Period")

define "Has Adverse Reaction to Statin":
  exists ([AdverseEvent: "Statin Allergen"] StatinReaction
        where StatinReaction.date during "Measurement Period")

define "Has Allergy to Statin":
  exists ([AllergyIntolerance: "Statin Allergen"] StatinAllergy
        where Global."Normalize Interval"(StatinAllergy.onset) starts before end of "Measurement Period")

define "Has Diabetes Diagnosis":
  exists ( [Condition: "Diabetes"] Diabetes
        where Global."Prevalence Period" ( Diabetes ) overlaps "Measurement Period")

define "Has ESRD Diagnosis":
  exists ( [Condition: "End Stage Renal Disease"] ESRD
        where Global."Prevalence Period" ( ESRD) overlaps "Measurement Period")

define "Has Hepatitis or Liver Disease Diagnosis":
  exists ( ( [Condition: "Hepatitis A"]
        union [Condition: "Hepatitis B"]
        union [Condition: "Liver Disease"] ) HepatitisLiverDisease
        where Global."Prevalence Period" ( HepatitisLiverDisease ) overlaps "Measurement Period")

define "Has Statin Associated Muscle Symptoms":
  exists(["Condition": "Statin Associated Muscle Symptoms"] StatinMuscleSymptom
        where Global."Prevalence Period" ( StatinMuscleSymptom ) starts before end of "Measurement Period")

define "Hypercholesterolemia Diagnosis":
  [Condition: "Hypercholesterolemia"] Hypercholesterolemia 
        where Global."Prevalence Period" (Hypercholesterolemia) starts before end of "Measurement Period"

define "LDL Result Greater Than or Equal To 190":
  [Observation: "LDL Cholesterol"] LDL
        where LDL.value >= 190 'mg/dL'
        and Global."Normalize Interval" (LDL.effective) starts before end of "Measurement Period"
        and LDL.status in { 'final', 'amended', 'corrected', 'appended' }

define "Numerator":
  exists "Statin Therapy Ordered during Measurement Period"
    or exists "Prescribed Statin Therapy Any Time during Measurement Period"

define "Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD":
  "Patients Age 20 or Older at Start of Measurement Period" 
    and exists ("LDL Result Greater Than or Equal To 190" 
        union "Hypercholesterolemia Diagnosis") 
    and not exists ("ASCVD Diagnosis or Procedure before End of Measurement Period")

define "Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia":
  AgeInYearsAt (start of "Measurement Period") in Interval[40,75] 
    and "Has Diabetes Diagnosis" 
    and not exists "ASCVD Diagnosis or Procedure before End of Measurement Period" 
    and not exists "LDL Result Greater Than or Equal To 190" 
    and not exists "Hypercholesterolemia Diagnosis"

define "Qualifying Encounter during Measurement Period":
  ( [Encounter: "Annual Wellness Visit"]
    union [Encounter: "Office Visit"]
    union [Encounter: "Outpatient Consultation"]
    union [Encounter: "Outpatient Encounters for Preventive Care"]
    union [Encounter: "Preventive Care Services - Established Office Visit, 18 and Up"]
    union [Encounter: "Preventive Care Services - Other"]
    union [Encounter: "Preventive Care Services-Individual Counseling"]
    union [Encounter: "Preventive Care Services-Initial Office Visit, 18 and Up"] ) ValidEncounter
        where ValidEncounter.period during "Measurement Period"
        and ValidEncounter.status = 'finished'

define "Statin Therapy Ordered during Measurement Period":
  ( [MedicationRequest: "Low Intensity Statin Therapy"]
    union [MedicationRequest: "Moderate Intensity Statin Therapy"]
    union [MedicationRequest: "High Intensity Statin Therapy"] ) StatinOrdered
        where StatinOrdered.authoredOn during "Measurement Period"
        and StatinOrdered.status in { 'active', 'completed' }
        and StatinOrdered.intent = 'order'

define "Has Order or Receiving Hospice Care or Palliative Care":
  exists ( ( [ServiceRequest: "Hospice Care Ambulatory"]
      union [ServiceRequest: "Palliative or Hospice Care"] ) PalliativeOrHospiceCareOrder
      where PalliativeOrHospiceCareOrder.authoredOn on or before 
      end of "Measurement Period"
        and PalliativeOrHospiceCareOrder.status in { 'active', 'on-hold', 'completed' }
        and PalliativeOrHospiceCareOrder.intent = 'order'
  )
    or exists ( ( [Procedure: "Hospice Care Ambulatory"]
        union [Procedure: "Palliative or Hospice Care"] ) PalliativeOrHospiceCarePerformed
        where Global."Normalize Interval" ( PalliativeOrHospiceCarePerformed.performed ) starts on or before 
        end of "Measurement Period"
          and PalliativeOrHospiceCarePerformed.status = 'completed'
    )
    or exists ( [Encounter: "Encounter for palliative care"] PalliativeEncounter
        where PalliativeEncounter.period starts on or before 
        end of "Measurement Period"
          and PalliativeEncounter.status = 'finished'
    )

define "Prescribed Statin Therapy Any Time during Measurement Period":
  ( [MedicationRequest: "Low Intensity Statin Therapy"]
    union [MedicationRequest: "Moderate Intensity Statin Therapy"]
    union [MedicationRequest: "High Intensity Statin Therapy"] ) ActiveStatin
    where exists ( ActiveStatin.dosageInstruction.timing T
        where Global."Normalize Interval" ( T.repeat.bounds ) overlaps "Measurement Period"
    )
      and ActiveStatin.status in { 'active', 'completed' }

