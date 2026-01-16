library CMS129FHIRProstCaBoneScanUse version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "UCUM": 'http://unitsofmeasure.org'

valueset "Bone Scan": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320'
valueset "Pain Warranting Further Investigation for Prostate Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451'
valueset "Prostate Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319'
valueset "Prostate Cancer Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398'
valueset "Prostate Specific Antigen Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401'
valueset "Salvage Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399'

code "American Joint Committee on Cancer cT1a (qualifier value)": '1228892002' from "SNOMEDCT" display 'American Joint Committee on Cancer cT1a (qualifier value)'
code "American Joint Committee on Cancer cT1b (qualifier value)": '1228895000' from "SNOMEDCT" display 'American Joint Committee on Cancer cT1b (qualifier value)'
code "American Joint Committee on Cancer cT1c (qualifier value)": '1228899006' from "SNOMEDCT" display 'American Joint Committee on Cancer cT1c (qualifier value)'
code "American Joint Committee on Cancer cT2a (qualifier value)": '1228931008' from "SNOMEDCT" display 'American Joint Committee on Cancer cT2a (qualifier value)'
code "Gleason score in Specimen Qualitative": '35266-6' from "LOINC" display 'Gleason score in Specimen Qualitative'
code "Procedure reason record (record artifact)": '433611000124109' from "SNOMEDCT" display 'Procedure reason record (record artifact)'
code "Tumor staging (tumor staging)": '254292007' from "SNOMEDCT" display 'Tumor staging (tumor staging)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

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
  exists "Prostate Cancer Diagnosis"

define "Denominator":
  "Initial Population"
    and "First Prostate Cancer Treatment during day of Measurement Period" is not null
    and "Most Recent Prostate Cancer Staging Tumor Size T1a to T2a" is not null
    and "Most Recent PSA Test Result is Low"
    and "Most Recent Gleason Score is Low"

define "Numerator":
  not exists "Bone Scan Study Performed"

define "Denominator Exceptions":
  "Has Diagnosis of Pain related to Prostate Cancer"
    or "Has Salvage Therapy Performed after Prostate Cancer Diagnosis"
    or "Has Bone Scan Study Performed with Documented Reason"

define "Bone Scan Study Performed":
  [ObservationClinicalResult: "Bone Scan"] BoneScan
    with "Prostate Cancer Diagnosis" ActiveProstateCancer
      such that BoneScan.effective.toInterval ( ) starts after start of ActiveProstateCancer.prevalenceInterval ( )
    where BoneScan.effective.toInterval ( ) ends during day of "Measurement Period"
      and BoneScan.status in { 'final', 'amended', 'corrected' }

define "Has Bone Scan Study Performed with Documented Reason":
  exists "Bone Scan Study Performed" BoneScanAfterDiagnosis
    where BoneScanAfterDiagnosis.value ~ "Procedure reason record (record artifact)"

define "Has Diagnosis of Pain related to Prostate Cancer":
  exists ( ( [ConditionProblemsHealthConcerns: "Pain Warranting Further Investigation for Prostate Cancer"]
      union [ConditionEncounterDiagnosis: "Pain Warranting Further Investigation for Prostate Cancer"] ) ProstateCancerPain
      with "Prostate Cancer Diagnosis" ActiveProstateCancer
        such that ProstateCancerPain.prevalenceInterval ( ) starts after start of ActiveProstateCancer.prevalenceInterval ( )
          and ProstateCancerPain.isVerified ( )
  )

define "First Prostate Cancer Treatment during day of Measurement Period":
  First([Procedure: "Prostate Cancer Treatment"] ProstateCancerTreatment
      where ProstateCancerTreatment.performed.toInterval() ends during day of "Measurement Period"
        and ProstateCancerTreatment.status = 'completed'
      sort by start of performed.toInterval()
  )

define "Most Recent PSA Test Result is Low":
  ( Last([LaboratoryResultObservation: "Prostate Specific Antigen Test"] PSATest
      with "Most Recent Prostate Cancer Staging Tumor Size T1a to T2a" MostRecentProstateCancerStaging
        such that PSATest.effective.toInterval() starts before MostRecentProstateCancerStaging.effective.toInterval()
          and PSATest.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ) ) LastPSATest
    return LastPSATest.value as Quantity < 10 'ng/mL'

define "Has Salvage Therapy Performed after Prostate Cancer Diagnosis":
  exists ( [Procedure: "Salvage Therapy"] SalvageTherapy
      with "Prostate Cancer Diagnosis" ActiveProstateCancer
        such that SalvageTherapy.performed.toInterval ( ) starts after start of ActiveProstateCancer.prevalenceInterval ( )
          and SalvageTherapy.status = 'completed'
  )

define "Most Recent Gleason Score is Low":
  ( Last([ObservationClinicalResult: "Gleason score in Specimen Qualitative"] GleasonScore
      with "First Prostate Cancer Treatment during day of Measurement Period" FirstProstateCancerTreatment
        such that GleasonScore.effective.toInterval() starts before start of FirstProstateCancerTreatment.performed.toInterval()
          and GleasonScore.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ) ) LastGleasonScore
    return LastGleasonScore.value as Integer <= 6

define "Most Recent Prostate Cancer Staging Tumor Size T1a to T2a":
  ( Last(([ObservationClinicalResult: "Tumor staging (tumor staging)"] TumorStaging
    // TODO: determine feasibility of ObservationClinicalResult having basedOn reference to Condition
    // where exists("Prostate Cancer Diagnosis" ActiveProstateCancer where TumorStaging.basedOn.references(ActiveProstateCancer))
    
    ) ProstateCancerStaging
      with "First Prostate Cancer Treatment during day of Measurement Period" FirstProstateCancerTreatment
        such that ProstateCancerStaging.effective.toInterval() starts before start of FirstProstateCancerTreatment.performed.toInterval()
          and ProstateCancerStaging.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ) ) LastProstateCancerStaging
    where ( LastProstateCancerStaging.value ~ "American Joint Committee on Cancer cT1a (qualifier value)"
        or LastProstateCancerStaging.value ~ "American Joint Committee on Cancer cT1b (qualifier value)"
        or LastProstateCancerStaging.value ~ "American Joint Committee on Cancer cT1c (qualifier value)"
        or LastProstateCancerStaging.value ~ "American Joint Committee on Cancer cT2a (qualifier value)"
    )

define "Prostate Cancer Diagnosis":
  [ConditionProblemsHealthConcerns: "Prostate Cancer"] ProstateCancer
    where ProstateCancer.prevalenceInterval ( ) overlaps day of "Measurement Period"
      and ProstateCancer.isVerified ( )

/*
@note: When possible, this function should be migrated to QICoreCommon.
@description: Returns true if the given Condition has a verification status of "confirmed", "unconfirmed", "provisional", or "differential"
*/


define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )