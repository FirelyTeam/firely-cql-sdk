library IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR version '1.3.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE
include CumulativeMedicationDuration version '4.0.000' called CMD

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'
codesystem "LOINC": 'http://loinc.org'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'

valueset "Active Tuberculosis for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56'
valueset "BCG Bacillus Calmette Guerin for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52'
valueset "Bladder Cancer for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45'
valueset "Chemotherapy Agents for Advanced Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60'
valueset "Cystectomy for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55'
valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Immunocompromised Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940'
valueset "Immunosuppressive Drugs for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32'
valueset "Mixed histology urothelial cell carcinoma for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Unavailability of Bacillus Calmette Guerin for urology care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44'

code "Carcinoma in situ of bladder": 'D09.0' from "ICD10CM" display 'Carcinoma in situ of bladder'
code "Combined radiotherapy (procedure)": '169331000' from "SNOMEDCT" display 'Combined radiotherapy (procedure)'
code "T1: Urinary tract tumor invades subepithelial connective tissue (finding)": '369935001' from "SNOMEDCT" display 'T1: Urinary tract tumor invades subepithelial connective tissue (finding)'
code "Ta: Noninvasive papillary carcinoma (urinary tract) (finding)": '369949005' from "SNOMEDCT" display 'Ta: Noninvasive papillary carcinoma (urinary tract) (finding)'
code "Tis: Carcinoma in situ (flat tumor of urinary bladder) (finding)": '369934002' from "SNOMEDCT" display 'Tis: Carcinoma in situ (flat tumor of urinary bladder) (finding)'
code "Tumor staging (tumor staging)": '254292007' from "SNOMEDCT" display 'Tumor staging (tumor staging)'
code "Dead (finding)": '419099009' from "SNOMEDCT" display 'Dead (finding'
code "virtual": 'VR' from "ActCode" display 'virtual'
code "Stage group.pathology Cancer": '21902-2' from "LOINC" display 'Stage group.pathology Cancer'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "Denominator":
  "Initial Population"

define "Denominator Exception":
  exists "BCG Not Available Within 6 Months After Bladder Cancer Staging"

define "Numerator":
  "First BCG Administered" is not null

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Has Qualifying Encounter":
  exists ( [Encounter: "Office Visit"] ValidEncounter
      where ValidEncounter.period during "Measurement Period"
        and ValidEncounter.class !~ "virtual"
        and ValidEncounter.status = 'finished'
  )

define "First Qualifying Bladder Cancer Staging Procedure":
  "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
    where FirstBladderCancerStaging.performed.toInterval ( ) during day of Interval["July 1 of Year Prior to the Measurement Period", "June 30 of the Measurement Period"]


/*Ta High Grade only to be included.  Ta low grade is to be excluded from this measure.*/


define "Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1":
  exists ( [Observation: "Stage group.pathology Cancer"] StagingObservation
      where StagingObservation.getStagingProcedure ( ) is not null
        and ( StagingObservation.value as Concept ~ "T1: Urinary tract tumor invades subepithelial connective tissue (finding)"
            or StagingObservation.value as Concept ~ "Ta: Noninvasive papillary carcinoma (urinary tract) (finding)"
            or StagingObservation.value as Concept ~ "Tis: Carcinoma in situ (flat tumor of urinary bladder) (finding)"
            or StagingObservation.value as Concept ~ "Carcinoma in situ of bladder"
        )
        and StagingObservation.status in { 'final', 'amended', 'corrected' }
  )

define fluent function getStagingProcedure(StagingObservation Observation):
  StagingObservation.partOf StagingReference
    return "First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period" FirstBladderCancerStagingMP
      where FirstBladderCancerStagingMP.id = StagingReference.reference.getId ( )

define "Initial Population":
  "First Qualifying Bladder Cancer Staging Procedure" is not null
    and "Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1"
    and "Has Qualifying Encounter"

define "Bladder Cancer Diagnosis":
  [Condition: "Bladder Cancer for Urology Care"] BladderCancer
    where BladderCancer.prevalenceInterval ( ) starts before end of "Measurement Period"
      and BladderCancer.isConfirmedActiveDiagnosis ( )

define "Denominator Exclusion":
  exists "Acute Tuberculosis Diagnosis"
    or exists "Immunosuppressive Drugs"
    or exists "Cystectomy Done"
    or "Has Excluding  HIV, Immunocompromised Conditions or Mixed Histology Before Staging"
    or "Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging"

define "Acute Tuberculosis Diagnosis":
  [Condition: "Active Tuberculosis for Urology Care"] ActiveTuberculosis
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that ActiveTuberculosis.prevalenceInterval ( ) overlaps after FirstBladderCancerStaging.performed.toInterval ( )
    where ActiveTuberculosis.isConfirmedActiveDiagnosis ( )

define "BCG Not Available Within 6 Months After Bladder Cancer Staging":
  [MedicationAdministrationNotDone: "BCG Bacillus Calmette Guerin for Urology Care"] BCGNotGiven
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that BCGNotGiven.recorded 6 months or less after start of FirstBladderCancerStaging.performed.toInterval ( )
        and BCGNotGiven.recorded during "Measurement Period"
    where BCGNotGiven.statusReason in "Unavailability of Bacillus Calmette Guerin for urology care"

define "Cystectomy Done":
  [Procedure: "Cystectomy for Urology Care"] Cystectomy
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that Cystectomy.performed.toInterval ( ) 6 months or less before start of FirstBladderCancerStaging.performed.toInterval ( )
    where Cystectomy.status = 'completed'

define "Has Excluding  HIV, Immunocompromised Conditions or Mixed Histology Before Staging":
  exists ( ( [Condition: "HIV"]
      union [Condition: "Immunocompromised Conditions"]
      union [Condition: "Mixed histology urothelial cell carcinoma for Urology Care"] ) ExclusionDiagnosis
      with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
        such that ExclusionDiagnosis.prevalenceInterval ( ) starts on or before start of FirstBladderCancerStaging.performed.toInterval ( )
      where ExclusionDiagnosis.isConfirmedActiveDiagnosis ( )
  )

define "Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging":
  exists ( ( [MedicationRequest: "Chemotherapy Agents for Advanced Cancer"] ExclusionMed
        let medicationPeriod: CMD.MedicationRequestPeriod ( ExclusionMed )
        with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
          such that medicationPeriod starts 6 months or less before FirstBladderCancerStaging.performed.toInterval ( )
        where ExclusionMed.status in { 'active', 'completed' }
          and ExclusionMed.intent = 'order'
          and ExclusionMed.doNotPerform is not true
    )
      union ( [Procedure: "Combined radiotherapy (procedure)"] ExclusionProcedure
          with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
            such that ExclusionProcedure.performed.toInterval ( ) starts 6 months or less before FirstBladderCancerStaging.performed.toInterval ( )
          where ExclusionProcedure.status = 'completed'
      )
  )

define "First Bladder Cancer Staging Procedure":
  First([Procedure: "Tumor staging (tumor staging)"] BladderCancerStaging
      with "Bladder Cancer Diagnosis" BladderCancer
        such that BladderCancerStaging.performed.toInterval() starts on or before day of start BladderCancer.prevalenceInterval()
          and BladderCancerStaging.performed.toInterval() overlaps day of BladderCancer.prevalenceInterval()
      where BladderCancerStaging.status = 'completed'
      sort by start of performed.toInterval()
  )

define "First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period":
  "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
    where FirstBladderCancerStaging.performed.toInterval ( ) during day of Interval["July 1 of Year Prior to the Measurement Period", "June 30 of the Measurement Period"]

define "First BCG Administered":
  First([MedicationAdministration: "BCG Bacillus Calmette Guerin for Urology Care"] BCG
      with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
        such that BCG.effective.toInterval() starts 6 months or less after start of FirstBladderCancerStaging.performed.toInterval()
          and BCG.effective.toInterval() starts during "Measurement Period"
      where BCG.status in { 'in-progress', 'completed' }
      sort by start of effective.toInterval()
  )

define "Immunosuppressive Drugs":
  [MedicationRequest: "Immunosuppressive Drugs for Urology Care"] ImmunosuppressiveDrugs
    let medicationPeriod: CMD.MedicationRequestPeriod ( ImmunosuppressiveDrugs )
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that medicationPeriod starts on or before start of FirstBladderCancerStaging.performed.toInterval ( )

define "July 1 of Year Prior to the Measurement Period":
  DateTime((year from start of "Measurement Period" - 1), 7, 1, 0, 0, 0, 0, 0)

define "June 30 of the Measurement Period":
  DateTime((year from start of "Measurement Period"), 6, 30, 23, 59, 59, 0, 0)

define function "NormalizePeriod"(pointInTime DateTime, dateTimeInterval Interval<DateTime>):
  if pointInTime is not null then Interval[pointInTime, pointInTime]
    else if dateTimeInterval is not null then dateTimeInterval
    else null as Interval<DateTime>

define fluent function isConfirmedActiveDiagnosis(Condition Condition):
  ( Condition Diagnosis
      where Diagnosis.clinicalStatus ~ QICoreCommon."active"
        and not ( Diagnosis.verificationStatus ~ QICoreCommon."unconfirmed"
            or Diagnosis.verificationStatus ~ QICoreCommon."refuted"
            or Diagnosis.verificationStatus ~ QICoreCommon."entered-in-error"
        )
  ) is not null
