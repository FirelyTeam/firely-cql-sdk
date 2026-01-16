library CMS646FHIRIntravesicalBCGTherapy version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'

valueset "Bacillus Calmette Guerin for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.353'
valueset "Bladder Cancer for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.354'
valueset "Chemotherapy Agents for Advanced Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.355'
valueset "Cystectomy for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.358'
valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Immunocompromised Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.363'
valueset "Immunosuppressive Drugs for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.364'
valueset "Mixed Histology Urothelial Cell Carcinoma for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.365'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Tuberculosis for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.351'
valueset "Unavailability of Bacillus Calmette Guerin for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.369'

code "American Joint Committee on Cancer cT1 (qualifier value)": '1228889001' from "SNOMEDCT" display 'American Joint Committee on Cancer cT1 (qualifier value)'
code "American Joint Committee on Cancer cTa (qualifier value)": '1228883000' from "SNOMEDCT" display 'American Joint Committee on Cancer cTa (qualifier value)'
code "American Joint Committee on Cancer cTis (qualifier value)": '1228884006' from "SNOMEDCT" display 'American Joint Committee on Cancer cTis (qualifier value)'
code "Carcinoma in situ of bladder": 'D09.0' from "ICD10CM" display 'Carcinoma in situ of bladder'
code "Combined radiotherapy (procedure)": '169331000' from "SNOMEDCT" display 'Combined radiotherapy (procedure)'
code "Tumor staging (tumor staging)": '254292007' from "SNOMEDCT" display 'Tumor staging (tumor staging)'
code "virtual": 'VR' from "ActCode" display 'virtual'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  "Has Most Recent Bladder Cancer Tumor Staging is T1, Tis, Ta HG"
    and "Has Qualifying Encounter"

define "Denominator":
  "Initial Population"

define "Denominator Exclusion":
  exists "Acute Tuberculosis Diagnosis"
    or exists "Immunosuppressive Drugs"
    or exists "Cystectomy Done"
    or "Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging"
    or "Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging"

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

define "July 1 of Year Prior to the Measurement Period":
  Date((year from start of "Measurement Period" - 1), 7, 1)

define "June 30 of the Measurement Period":
  Date((year from start of "Measurement Period"), 6, 30)

define "Acute Tuberculosis Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Tuberculosis for Urology Care"]
    union [ConditionEncounterDiagnosis: "Tuberculosis for Urology Care"] ) ActiveTuberculosis
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that ( ( ActiveTuberculosis.prevalenceInterval ( ) overlaps after day of FirstBladderCancerStaging.performed.toInterval ( ) )
          or ( ActiveTuberculosis.onset.toInterval ( ) overlaps after day of FirstBladderCancerStaging.performed.toInterval ( )
              and ( ( ActiveTuberculosis.abatement.toInterval ( ) overlaps after day of FirstBladderCancerStaging.performed.toInterval ( ) )
                  or ( ActiveTuberculosis.abatement is null )
              )
          )
      )
    where ActiveTuberculosis.isVerified ( )

define "Cystectomy Done":
  [Procedure: "Cystectomy for Urology Care"] Cystectomy
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that Cystectomy.performed.toInterval ( ) 6 months or less before day of start of FirstBladderCancerStaging.performed.toInterval ( )
    where Cystectomy.status = 'completed'

define "Has Excluding HIV, Immunocompromised Conditions or Mixed Histology Before Staging":
  exists ( ( ( [ConditionProblemsHealthConcerns: "HIV"]
        union [ConditionEncounterDiagnosis: "HIV"]
    )
      union ( [ConditionProblemsHealthConcerns: "Immunocompromised Conditions"]
          union [ConditionEncounterDiagnosis: "Immunocompromised Conditions"]
      )
      union ( [ConditionProblemsHealthConcerns: "Mixed Histology Urothelial Cell Carcinoma for Urology Care"]
          union [ConditionEncounterDiagnosis: "Mixed Histology Urothelial Cell Carcinoma for Urology Care"]
      ) ) ExclusionDiagnosis
      with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
        such that ( ( ExclusionDiagnosis.prevalenceInterval ( ) starts on or before day of start of FirstBladderCancerStaging.performed.toInterval ( ) )
            or ( ExclusionDiagnosis.onset.toInterval ( ) starts on or before day of start of FirstBladderCancerStaging.performed.toInterval ( ) )
        )
      where ExclusionDiagnosis.isVerified ( )
  )

define "Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging":
  exists ( ( [MedicationRequest: "Chemotherapy Agents for Advanced Cancer"] ExclusionMed
        let firstMedicationPeriod: First((collapse(ExclusionMed.dosageInstruction.timing.repeat.bounds DoseTime
              return DoseTime.toInterval()
          )) DrugPeriods
            sort by start of $this
        )
        with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
          such that firstMedicationPeriod starts 6 months or less before FirstBladderCancerStaging.performed.toInterval ( )
        where ExclusionMed.status in { 'active', 'completed' }
          and ExclusionMed.intent = 'order'
    )
      union ( [Procedure: "Combined radiotherapy (procedure)"] ExclusionProcedure
          with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
            such that ExclusionProcedure.performed.toInterval ( ) starts 6 months or less before FirstBladderCancerStaging.performed.toInterval ( )
          where ExclusionProcedure.status in { 'completed', 'in-progress' }
      )
  )

define "First Bladder Cancer Staging Procedure":
  First([Procedure: "Tumor staging (tumor staging)"] BladderCancerStaging
      with "Bladder Cancer Diagnosis" BladderCancer
        such that BladderCancerStaging.performed.toInterval() starts on or before day of start of BladderCancer.prevalenceInterval()
      where BladderCancerStaging.status = 'completed'
      sort by start of performed.toInterval()
  )

define "Has Qualifying Encounter":
  exists ( [Encounter: "Office Visit"] ValidEncounter
      where ValidEncounter.period during day of "Measurement Period"
        and ValidEncounter.class !~ "virtual"
        and ValidEncounter.status = 'finished'
  )

define "Bladder Cancer Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Bladder Cancer for Urology Care"]
    union [ConditionEncounterDiagnosis: "Bladder Cancer for Urology Care"] ) BladderCancer
    where ( BladderCancer.prevalenceInterval ( ) starts before day of end of "Measurement Period"
        or BladderCancer.onset.toInterval ( ) before day of end of "Measurement Period"
    )
      and BladderCancer.isVerified ( )

define "BCG Not Available Within 6 Months After Bladder Cancer Staging":
  [MedicationAdministrationNotDone: "Bacillus Calmette Guerin for Urology Care"] BCGNotGiven
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that BCGNotGiven.recorded 6 months or less after day of start of FirstBladderCancerStaging.performed.toInterval ( )
    where BCGNotGiven.statusReason in "Unavailability of Bacillus Calmette Guerin for Urology Care"

define "First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period":
  "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
    where FirstBladderCancerStaging.performed.toInterval ( ) during day of Interval["July 1 of Year Prior to the Measurement Period", "June 30 of the Measurement Period"]

define "First BCG Administered":
  First([MedicationAdministration: "Bacillus Calmette Guerin for Urology Care"] BCG
      with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
        such that BCG.effective.toInterval() starts 6 months or less after day of start of FirstBladderCancerStaging.performed.toInterval()
          and BCG.effective.toInterval() starts during day of "Measurement Period"
      where BCG.status in { 'in-progress', 'completed' }
      sort by start of effective.toInterval()
  )

/*Ta High Grade only to be included.  Ta low grade is to be excluded from this measure.*/


define "Has Most Recent Bladder Cancer Tumor Staging is T1, Tis, Ta HG":
  exists ( [LaboratoryResultObservation] StagingObservation
      where StagingObservation.getStagingProcedure ( ) is not null
        and ( StagingObservation.value as Concept ~ "American Joint Committee on Cancer cT1 (qualifier value)"
            or StagingObservation.value as Concept ~ "American Joint Committee on Cancer cTis (qualifier value)"
            or StagingObservation.value as Concept ~ "American Joint Committee on Cancer cTa (qualifier value)"
            or StagingObservation.value as Concept ~ "Carcinoma in situ of bladder"
        )
        and StagingObservation.status in { 'final', 'amended', 'corrected' }
  )

define fluent function getStagingProcedure(StagingObservation LaboratoryResultObservation):
  StagingObservation.partOf StagingReference
    return "First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period" FirstBladderCancerStagingMP
      where FirstBladderCancerStagingMP.id = StagingReference.reference.getId ( )

define "Immunosuppressive Drugs":
  [MedicationRequest: "Immunosuppressive Drugs for Urology Care"] ImmunosuppressiveDrugs
    let firstMedicationPeriod: First((collapse(ImmunosuppressiveDrugs.dosageInstruction.timing.repeat.bounds DoseTime
          return DoseTime.toInterval()
      )) DrugPeriods
        sort by start of $this
    ),
    //get the very first event
    
    firstMedicationEvent: First((ImmunosuppressiveDrugs.dosageInstruction.timing dosageTiming
        //return first event for the specific dosageTiming
        
        return First(dosageTiming.event dosageTimingEvents
            sort ascending
        )) firstEvents
        sort ascending
    ),
    medicationPeriod: Coalesce(firstMedicationEvent.toInterval(), firstMedicationPeriod)
    with "First Bladder Cancer Staging Procedure" FirstBladderCancerStaging
      such that medicationPeriod starts on or before day of start of FirstBladderCancerStaging.performed.toInterval ( )
    where ImmunosuppressiveDrugs.status in { 'active', 'completed' }
      and ImmunosuppressiveDrugs.intent = 'order'

define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )