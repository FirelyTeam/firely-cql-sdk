library CMS645FHIRBoneDensityPCADTherapy version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Androgen Deprivation Therapy for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.352'
valueset "DEXA Bone Density for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.359'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Patient Declined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582'
valueset "Prostate Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319'

code "Injection of leuprolide acetate for twelve month period (regime/therapy)": '456381000124102' from "SNOMEDCT" display 'Injection of leuprolide acetate for twelve month period (regime/therapy)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  "Has Qualifying Encounter"
    and exists "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period"

define "Denominator":
  "Initial Population"

define "Numerator":
  "Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT"

define "Denominator Exception":
  exists ( "No Bone Density Scan Ordered Due to Patient Refusal" )
    or exists ( "No Bone Density Scan Performed Due to Patient Refusal" )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT":
  exists ( ( [ServiceRequest: "DEXA Bone Density for Urology Care"] DEXAOrdered
        with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
          such that DEXAOrdered.authoredOn 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
            or DEXAOrdered.authoredOn 2 years or less before day of OrderTwelveMonthsADT.authoredOn
        where DEXAOrdered.status in { 'active', 'completed' }
          and DEXAOrdered.intent = 'order'
    )
      union ( [ObservationClinicalResult: "DEXA Bone Density for Urology Care"] DEXAPerformed
          with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
            such that DEXAPerformed.effective.toInterval ( ) 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
              or DEXAPerformed.effective.toInterval ( ) 2 years or less before day of OrderTwelveMonthsADT.authoredOn
          where DEXAPerformed.status in { 'final', 'amended', 'corrected' }
      )
  )

define "No Bone Density Scan Ordered Due to Patient Refusal":
  [ServiceNotRequested: "DEXA Bone Density for Urology Care"] DEXANotOrdered
    with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
      such that DEXANotOrdered.authoredOn 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
        and DEXANotOrdered.reasonRefused in "Patient Declined"

define "No Bone Density Scan Performed Due to Patient Refusal":
  [ObservationCancelled: "DEXA Bone Density for Urology Care"] DEXANotPerformed
    with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
      such that DEXANotPerformed.issued 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
        and DEXANotPerformed.notDoneReason in "Patient Declined"

define "First ADT in 3 Months Before to 9 Months After Start of Measurement Period":
  First(("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates"
      union "Androgen Deprivation Therapy for Urology Care Medication Order Start Dates") ADTDateTime
      with "Prostate Cancer Diagnosis" ProstateCancer
        such that ADTDateTime during day of ProstateCancer.prevalenceInterval()
          and ADTDateTime during day of Interval[start of "Measurement Period" - 3 months, start of "Measurement Period" + 9 months]
      sort ascending
  )

define "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period":
  [ServiceRequest: "Injection of leuprolide acetate for twelve month period (regime/therapy)"] OrderTwelveMonthADT
    with "First ADT in 3 Months Before to 9 Months After Start of Measurement Period" FirstADTMP
      such that OrderTwelveMonthADT.authoredOn on or after day of FirstADTMP
        and OrderTwelveMonthADT.authoredOn during day of Interval[start of "Measurement Period" - 3 months, start of "Measurement Period" + 9 months]
        and OrderTwelveMonthADT.status in { 'active', 'completed' }
        and OrderTwelveMonthADT.intent = 'order'

define "Androgen Deprivation Therapy for Urology Care Medication Active Start Dates":
  [MedicationRequest: "Androgen Deprivation Therapy for Urology Care"] ADTActive
    let firstMedicationPeriod: First((collapse(ADTActive.dosageInstruction.timing.repeat.bounds DoseTime
          return DoseTime.toInterval()
      )) DrugPeriods
        sort by start of $this
    ),

    //get the very first event as interval
    
    firstMedicationEvent: First((ADTActive.dosageInstruction.timing dosageTiming
        //returns first event for the specific dosageTiming
        
        return First(dosageTiming.event dosageTimingEvents
            sort ascending
        )) firstEvents
        sort ascending
    ),
    medicationDateTime: Min({ firstMedicationEvent, start of firstMedicationPeriod, 
      end of firstMedicationPeriod }
    )
    where ADTActive.status in { 'active', 'completed' }
      and ADTActive.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
    return medicationDateTime

define "Androgen Deprivation Therapy for Urology Care Medication Order Start Dates":
  [MedicationRequest: "Androgen Deprivation Therapy for Urology Care"] ADTOrder
    let firstMedicationPeriod: First((collapse(ADTOrder.dosageInstruction.timing.repeat.bounds DoseTime
          return DoseTime.toInterval()
      )) DrugPeriods
        sort by start of $this
    ),
    medicationDateTime: Min({ ADTOrder.authoredOn, start of firstMedicationPeriod, 
      end of firstMedicationPeriod }
    )
    where ADTOrder.status in { 'active', 'completed' }
      and ADTOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
    return medicationDateTime

define "Has Qualifying Encounter":
  exists ( ["Encounter": "Office Visit"] OfficeVisit
      where OfficeVisit.period during day of "Measurement Period"
        and OfficeVisit.status = 'finished'
  )

define "Prostate Cancer Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Prostate Cancer"]
    union [ConditionEncounterDiagnosis: "Prostate Cancer"] ) ProstateCancer
    where ProstateCancer.prevalenceInterval ( ) overlaps day of "Measurement Period"
      and ProstateCancer.isVerified ( )

/*      
@description: Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential
*/


define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )