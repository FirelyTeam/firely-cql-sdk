library CMS1017FHIRHHFI version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include CumulativeMedicationDuration version '6.0.000' called CMD

codesystem "LOINC": 'http://loinc.org'

valueset "Abnormal Weight Loss": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.2'
valueset "Anticoagulants for All Indications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22'
valueset "Antidepressants": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163'
valueset "Antihypertensives": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164'
valueset "Central Nervous System Depressants": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134'
valueset "Coagulation Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23'
valueset "Delirium, Dementia, and Other Psychoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168'
valueset "Depression": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169'
valueset "Diuretics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170'
valueset "Epilepsy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171'
valueset "Inpatient Falls": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171'
valueset "Leukemia or Lymphoma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136'
valueset "Liver Disease Moderate to Severe": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137'
valueset "Major Injuries": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.120'
valueset "Malignant Bone Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24'
valueset "Malnutrition": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1272.1'
valueset "Moderate Injuries": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205'
valueset "Neurologic Movement and Related Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174'
valueset "Not Present On Admission or Documentation Insufficient to Determine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198'
valueset "Obesity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162'
valueset "Opioids": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120'
valueset "Osteoporosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147'
valueset "Peripheral Neuropathy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175'
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'
valueset "Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176'
valueset "Suicide Attempt": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Qualifying Encounter":
  CQMCommon."Inpatient Encounter" InpatientEncounter
    where InpatientEncounter.hospitalizationWithObservation ( ).lengthInDays ( ) <= 120
      and AgeInYearsAt(date from start of InpatientEncounter.period) >= 18

define "Initial Population":
  "Qualifying Encounter"

define "Denominator":
  "Initial Population"

define "Numerator":
  "Encounter Where A Fall And Major Injury Occurred Not POA"
    union "Encounter Where A Fall And Moderate Injury Occurred Not POA"

define "Encounter Where A Fall And Moderate Injury Occurred Not POA":
  "Encounter With A Fall Not Present On Admission" FallOccurred
    where exists ( ( FallOccurred.claimDiagnosis ( ) ) ModerateFallOccurred
        where ( ModerateFallOccurred.onAdmission is null
            or ModerateFallOccurred.onAdmission in "Not Present On Admission or Documentation Insufficient to Determine"
        )
          and ( ModerateFallOccurred.diagnosis in "Moderate Injuries"
              or ModerateFallOccurred.diagnosis.getCondition ( ).code in "Moderate Injuries"
          )
    )

define "Encounter Where A Fall And Major Injury Occurred Not POA":
  "Encounter With A Fall Not Present On Admission" FallOccurred
    where exists ( ( FallOccurred.claimDiagnosis ( ) ) MajorFallOccurred
        where ( MajorFallOccurred.onAdmission is null
            or MajorFallOccurred.onAdmission in "Not Present On Admission or Documentation Insufficient to Determine"
        )
          and ( MajorFallOccurred.diagnosis in "Major Injuries"
              or MajorFallOccurred.diagnosis.getCondition ( ).code in "Major Injuries"
          )
    )

define "Encounter Where A Fall Occurred":
  "Encounter With A Fall Diagnosis" EncounterFallDiagnosis
    union "Encounter With A Fall Event" EncounterFallEvent

define "Encounter With A Fall Not Present On Admission":
  "Encounter Where A Fall Occurred" EncounterFallDiagnosis
    where EncounterFallDiagnosis.hasDiagnosisNotPresentOnAdmissionOrNull ( "Inpatient Falls" )

define "Encounter With A Fall Diagnosis":
  "Qualifying Encounter" QualifyingFall
    where QualifyingFall.reasonCode in "Inpatient Falls"
      or QualifyingFall.encountersDiagnosis ( ).code in "Inpatient Falls"

define "Encounter With A Fall Event":
  "Qualifying Encounter" InpatientEncounter
    with [AdverseEvent: "Inpatient Falls"] FallsDocumentation
      such that Coalesce(FallsDocumentation.date, FallsDocumentation.recordedDate) during InpatientEncounter.hospitalizationWithObservation ( )

define "Denominator Exclusions":
  "Encounter With A Fall Present On Admission"

define "Numerator Exclusions":
  "Encounter With A Fall Present On Admission"

define "Encounter With A Fall Present On Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Inpatient Falls", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Body Mass Index (BMI)":
  from
    ["USCoreBMIProfile"] BMI
    with "Qualifying Encounter" InpatientEncounter
      such that BMI.effective.toInterval ( ) starts during InpatientEncounter.hospitalizationWithObservation ( )
        and BMI.value is not null
        and BMI.status in { 'final', 'amended', 'corrected' }
    return BMI.value as Quantity

define "Risk Variable All Encounter Diagnoses with Rank and POA Indication":
  from
    "Qualifying Encounter" InpatientEncounter
    let claim: ( [Claim] C
        where C.status = 'active'
          and C.use = 'claim'
          and exists ( C.item ClaimItem
              where ClaimItem.encounter.references ( InpatientEncounter )
          )
    ),
    claimItem: ( claim.item ClaimItem
        where ClaimItem.encounter.references ( InpatientEncounter )
    )
    return Tuple {
      encounterId: InpatientEncounter.id,
      diagnosis: claim.diagnosis,
      rank: claim.diagnosis.sequence,
      POA: claim.diagnosis Diag
        where Diag.onAdmission in "Present on Admission or Clinically Undetermined"
          or Diag.onAdmission in "Not Present On Admission or Documentation Insufficient to Determine"
    }

define "Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Abnormal Weight Loss", "Present on Admission or Clinically Undetermined" )
      or InpatientEncounter.isDiagnosisPresentOnAdmission ( "Malnutrition", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Anticoagulant Active at Admission":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationRequest": "Anticoagulants for All Indications"] Anticoagulants
      such that Anticoagulants.status in { 'active', 'completed' }
        and ( Anticoagulants.intent = 'order'
            or ( Anticoagulants.intent = 'plan'
                and Anticoagulants.subject.reference.getId ( ) = Patient.id
            )
        )
        and Anticoagulants.isCommunity ( )
        and Anticoagulants.medicationRequestPeriod ( ) overlaps before day of InpatientEncounter.period

define "Risk Variable Encounter with Anticoagulant Administration During Encounter":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationAdministration": "Anticoagulants for All Indications"] Anticoagulants
      such that Anticoagulants.effective.toInterval ( ) starts during InpatientEncounter.hospitalizationWithObservation ( )
        and Anticoagulants.status in { 'in-progress', 'completed' }

define "Risk Variable Encounter with Antidepressant Active at Admission":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationRequest": "Antidepressants"] AntidepressantMed
      such that AntidepressantMed.status in { 'active', 'completed' }
        and ( AntidepressantMed.intent = 'order'
            or ( AntidepressantMed.intent = 'plan'
                and AntidepressantMed.subject.reference.getId ( ) = Patient.id
            )
        )
        and AntidepressantMed.isCommunity ( )
        and AntidepressantMed.medicationRequestPeriod ( ) overlaps before day of InpatientEncounter.period

define "Risk Variable Encounter with Antihypertensive Active at Admission":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationRequest": "Antihypertensives"] BPMed
      such that BPMed.status in { 'active', 'completed' }
        and ( BPMed.intent = 'order'
            or ( BPMed.intent = 'plan'
                and BPMed.subject.reference.getId ( ) = Patient.id
            )
        )
        and BPMed.isCommunity ( )
        and BPMed.medicationRequestPeriod ( ) overlaps before day of InpatientEncounter.period

define "Risk Variable Encounter with CNS Depressant Active at Admission":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationRequest": "Central Nervous System Depressants"] CNSMed
      such that CNSMed.status in { 'active', 'completed' }
        and ( CNSMed.intent = 'order'
            or ( CNSMed.intent = 'plan'
                and CNSMed.subject.reference.getId ( ) = Patient.id
            )
        )
        and CNSMed.isCommunity ( )
        and CNSMed.medicationRequestPeriod ( ) overlaps before day of InpatientEncounter.period

define "Risk Variable Encounter with Diuretic Active at Admission":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationRequest": "Diuretics"] DiureticMed
      such that DiureticMed.status in { 'active', 'completed' }
        and ( DiureticMed.intent = 'order'
            or ( DiureticMed.intent = 'plan'
                and DiureticMed.subject.reference.getId ( ) = Patient.id
            )
        )
        and DiureticMed.isCommunity ( )
        and DiureticMed.medicationRequestPeriod ( ) overlaps before day of InpatientEncounter.period

define "Risk Variable Encounter with Opioid Medication Active at Admission":
  "Qualifying Encounter" InpatientEncounter
    with ["MedicationRequest": "Opioids"] OpioidMed
      such that OpioidMed.status in { 'active', 'completed' }
        and ( OpioidMed.intent = 'order'
            or ( OpioidMed.intent = 'plan'
                and OpioidMed.subject.reference.getId ( ) = Patient.id
            )
        )
        and OpioidMed.isCommunity ( )
        and OpioidMed.medicationRequestPeriod ( ) overlaps before day of InpatientEncounter.period

define "Risk Variable Encounter with Coagulation Disorder Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Coagulation Disorders", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Delirium or Dementia or Other Psychosis Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Delirium, Dementia, and Other Psychoses", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Depression Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Depression", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Epilepsy Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Epilepsy", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Leukemia or Lymphoma Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Leukemia or Lymphoma", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Liver Disease Moderate to Severe", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Malignant Bone Disease Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Malignant Bone Disease", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Neurologic Disorder Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Neurologic Movement and Related Disorders", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Obesity Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Obesity", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Osteoporosis Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Osteoporosis", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Peripheral Neuropathy Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Peripheral Neuropathy", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Stroke Present on Admission":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.isDiagnosisPresentOnAdmission ( "Stroke", "Present on Admission or Clinically Undetermined" )

define "Risk Variable Encounter with Suicide Attempt":
  "Qualifying Encounter" InpatientEncounter
    where InpatientEncounter.encountersDiagnosis ( ).code in "Suicide Attempt"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define function "Denominator Observation"(QualifyingEncounter Encounter):
  duration in days of QualifyingEncounter.hospitalizationWithObservation ( )

define function "Numerator Observation"(QualifyingEncounter Encounter):
  Count("Numerator" FallsEncounter
      where FallsEncounter.period ends during QualifyingEncounter.hospitalizationWithObservation()
  )

define fluent function hasDiagnosisNotPresentOnAdmissionOrNull(encounter Encounter, diagnosisValueSet ValueSet):
  exists ( [Claim] C
      where C.status = 'active'
        and C.use = 'claim'
        and exists ( C.item I
            where I.encounter.references ( encounter )
        )
      return C.diagnosis D
        where exists ( C.item I
            where I.encounter.references ( encounter )
              and D.sequence in I.diagnosisSequence
        )
          and ( D.onAdmission is null
              or D.onAdmission in "Not Present On Admission or Documentation Insufficient to Determine"
          )
          and D.diagnosis in diagnosisValueSet
  )

define fluent function encountersDiagnosis(Encounter Encounter):
  Encounter.reasonReference EncDiag
    return singleton from ( ( [ConditionEncounterDiagnosis] ConditionED
        union [ConditionProblemsHealthConcerns] ConditionPHC ) Cond
        where EncDiag.references ( Cond.id )
    )