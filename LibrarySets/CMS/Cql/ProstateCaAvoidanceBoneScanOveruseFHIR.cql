library ProstateCaAvoidanceBoneScanOveruseFHIR version '0.2.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Bone Scan": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320'
valueset "Pain Warranting Further Investigation for Prostate Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451'
valueset "Prostate Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319'
valueset "Prostate Cancer Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398'
valueset "Prostate Specific Antigen Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401'
valueset "Salvage Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399'

code "Gleason score in Specimen Qualitative": '35266-6' from "LOINC" display 'Gleason score in Specimen Qualitative'
code "Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)": '433351000124101' from "SNOMEDCT" display 'Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)'
code "Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)": '433361000124104' from "SNOMEDCT" display 'Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)'
code "Procedure reason record (record artifact)": '433611000124109' from "SNOMEDCT" display 'Procedure reason record (record artifact)'
code "T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)": '369833007' from "SNOMEDCT" display 'T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)'
code "T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)": '369834001' from "SNOMEDCT" display 'T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)'
code "Tumor staging (tumor staging)": '254292007' from "SNOMEDCT" display 'Tumor staging (tumor staging)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Denominator Exceptions":
  "Has Diagnosis of Pain related to Prostate Cancer"
    or "Has Salvage Therapy Performed after Prostate Cancer Diagnosis"
    or "Has Bone Scan Study Performed with Documented Reason"

define "First Prostate Cancer Treatment during day of Measurement Period":
  First([Procedure: "Prostate Cancer Treatment"] ProstateCancerTreatment
      where ProstateCancerTreatment.performed.toInterval() ends during day of "Measurement Period"
        and ProstateCancerTreatment.status = 'completed'
      sort by start of performed.toInterval()
  )

define "Has Salvage Therapy Performed after Prostate Cancer Diagnosis":
  exists ( [Procedure: "Salvage Therapy"] SalvageTherapy
      with "Prostate Cancer Diagnosis" ActiveProstateCancer
        such that SalvageTherapy.performed.toInterval ( ) starts after start of ActiveProstateCancer.prevalenceInterval ( )
          and SalvageTherapy.status = 'completed'
  )

define "Initial Population":
  exists "Prostate Cancer Diagnosis"

define "Most Recent Gleason Score is Low":
  ( Last([Observation: "Gleason score in Specimen Qualitative"] GleasonScore
      with "First Prostate Cancer Treatment during day of Measurement Period" FirstProstateCancerTreatment
        such that GleasonScore.effective.toInterval() starts before start of FirstProstateCancerTreatment.performed.toInterval()
          and GleasonScore.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ) ) LastGleasonScore
    return LastGleasonScore.value as Integer <= 6

define "Most Recent Prostate Cancer Staging Tumor Size T1a to T2a":
  ( Last([Observation: "Tumor staging (tumor staging)"] ProstateCancerStaging
      with "First Prostate Cancer Treatment during day of Measurement Period" FirstProstateCancerTreatment
        such that ProstateCancerStaging.effective.toInterval() starts before start of FirstProstateCancerTreatment.performed.toInterval()
          and ProstateCancerStaging.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ) ) LastProstateCancerStaging
    where ( LastProstateCancerStaging.value ~ "T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)"
        or LastProstateCancerStaging.value ~ "T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)"
        or LastProstateCancerStaging.value ~ "Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)"
        or LastProstateCancerStaging.value ~ "Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)"
    )

define "Numerator":
  not exists "Bone Scan Study Performed"

define "Denominator":
  "Initial Population"
    and "First Prostate Cancer Treatment during day of Measurement Period" is not null
    and "Most Recent Prostate Cancer Staging Tumor Size T1a to T2a" is not null
    and "Most Recent PSA Test Result is Low"
    and "Most Recent Gleason Score is Low"

define "Has Bone Scan Study Performed with Documented Reason":
  exists "Bone Scan Study Performed" BoneScanAfterDiagnosis
    where BoneScanAfterDiagnosis.value ~ "Procedure reason record (record artifact)"

define "Bone Scan Study Performed":
  [Observation: "Bone Scan"] BoneScan
    with "Prostate Cancer Diagnosis" ActiveProstateCancer
      such that BoneScan.effective.toInterval ( ) starts after start of ActiveProstateCancer.prevalenceInterval ( )

define "Prostate Cancer Diagnosis":
  [Condition: "Prostate Cancer"] ProstateCancer
    where ProstateCancer.prevalenceInterval ( ) overlaps day of "Measurement Period"
      and ( ProstateCancer.isProblemListItem ( )
          or ProstateCancer.isHealthConcern ( )
      )
      and ProstateCancer.isActive ( )

define "Most Recent PSA Test Result is Low":
  ( Last([Observation: "Prostate Specific Antigen Test"] PSATest
      with "Most Recent Prostate Cancer Staging Tumor Size T1a to T2a" MostRecentProstateCancerStaging
        such that PSATest.effective.toInterval() starts before MostRecentProstateCancerStaging.effective.toInterval()
          and PSATest.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ) ) LastPSATest
    return LastPSATest.value as Quantity < 10 'ng/mL'

define "Has Diagnosis of Pain related to Prostate Cancer":
  exists ( [Condition: "Pain Warranting Further Investigation for Prostate Cancer"] ProstateCancerPain
      with "Prostate Cancer Diagnosis" ActiveProstateCancer
        such that ProstateCancerPain.prevalenceInterval ( ) starts after start of ActiveProstateCancer.prevalenceInterval ( )
          and ( ProstateCancerPain.isProblemListItem ( )
              or ProstateCancerPain.isHealthConcern ( )
          )
          and ProstateCancerPain.isActive ( )
  )