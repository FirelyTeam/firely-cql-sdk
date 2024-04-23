library BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR version '1.3.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon
include CumulativeMedicationDuration version '4.0.000' called CMD

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Androgen deprivation therapy for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.48'
valueset "DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.38'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Patient Declined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582'
valueset "Prostate Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319'

code "Injection of leuprolide acetate for twelve month period (regime/therapy)": '456381000124102' from "SNOMEDCT" display 'Injection of leuprolide acetate for twelve month period (regime/therapy)'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "Initial Population":
  "Patient is Male"
    and "Has Qualifying Encounter"
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

define "Androgen Deprivation Therapy for Urology Care Medication Active Start Dates":
  [MedicationRequest: "Androgen deprivation therapy for Urology Care"] ADTActive
    let medicationRequestPeriod: CMD.MedicationRequestPeriod ( ADTActive ),
    medicationDateTime: medicationRequestPeriod.earliest ( )
    where ADTActive.status in { 'active', 'completed' }
      and ADTActive.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
    return medicationDateTime

define "Androgen Deprivation Therapy for Urology Care Medication Order Start Dates":
  [MedicationRequest: "Androgen deprivation therapy for Urology Care"] ADTOrder
    let medicationRequestPeriod: CMD.MedicationRequestPeriod ( ADTOrder ),
    medicationDateTime: start of "NormalizePeriod"(ADTOrder.authoredOn, medicationRequestPeriod)
    where ADTOrder.status in { 'active', 'completed' }
      and ADTOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
    return medicationDateTime

define "First ADT in 3 Months Before to 9 Months After Start of Measurement Period":
  First(("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates"
      union "Androgen Deprivation Therapy for Urology Care Medication Order Start Dates") ADTDateTime
      with "Prostate Cancer Diagnosis" ProstateCancer
        such that ADTDateTime during day of ProstateCancer.prevalenceInterval()
          and ADTDateTime during day of Interval[start of "Measurement Period" - 3 months, start of "Measurement Period" + 9 months]
      sort ascending
  )

define "Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT":
  exists ( ( [ServiceRequest: "DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care"] DEXAOrdered
        with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
          such that DEXAOrdered.authoredOn 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
            or DEXAOrdered.authoredOn 2 years or less before day of OrderTwelveMonthsADT.authoredOn
        where DEXAOrdered.status in { 'active', 'completed' }
          and DEXAOrdered.intent = 'order'
          and DEXAOrdered.doNotPerform is not true
    )
      union ( [Observation: "DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care"] DEXAPerformed
          with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
            such that DEXAPerformed.effective.toInterval ( ) 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
              or DEXAPerformed.effective.toInterval ( ) 2 years or less before OrderTwelveMonthsADT.authoredOn
          where DEXAPerformed.status in { 'final', 'amended', 'corrected' }
      )
  )

define "Has Qualifying Encounter":
  exists ( ["Encounter": "Office Visit"] OfficeVisit
      where OfficeVisit.period during "Measurement Period"
        and OfficeVisit.status = 'finished'
  )

define "No Bone Density Scan Ordered Due to Patient Refusal":
  [ServiceNotRequested: "DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care"] DEXANotOrdered
    with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
      such that DEXANotOrdered.authoredOn 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
        and DEXANotOrdered.reasonRefused in "Patient Declined"

define "No Bone Density Scan Performed Due to Patient Refusal":
  [ObservationNotDone: "DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care"] DEXANotPerformed
    with "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period" OrderTwelveMonthsADT
      such that DEXANotPerformed.issued 3 months or less on or after day of OrderTwelveMonthsADT.authoredOn
        and DEXANotPerformed.notDoneReason in "Patient Declined"

define "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period":
  [ServiceRequest: "Injection of leuprolide acetate for twelve month period (regime/therapy)"] OrderTwelveMonthADT
    with "First ADT in 3 Months Before to 9 Months After Start of Measurement Period" FirstADTMP
      such that date from OrderTwelveMonthADT.authoredOn on or after FirstADTMP
        and OrderTwelveMonthADT.authoredOn during day of Interval[start of "Measurement Period" - 3 months, start of "Measurement Period" + 9 months]
        and OrderTwelveMonthADT.status in { 'active', 'completed' }
        and OrderTwelveMonthADT.intent = 'order'

define "Patient is Male":
  Patient.gender = 'male'

define "Prostate Cancer Diagnosis":
  [Condition: "Prostate Cancer"] ProstateCancer
    where ProstateCancer.prevalenceInterval ( ) overlaps "Measurement Period"
      and ProstateCancer.clinicalStatus ~ QICoreCommon."active"
      and ProstateCancer.verificationStatus ~ QICoreCommon."confirmed"

define function "NormalizePeriod"(pointInTime DateTime, dateTimeInterval Interval<DateTime>):
  if pointInTime is not null then Interval[pointInTime, pointInTime]
    else if dateTimeInterval is not null then dateTimeInterval
    else null as Interval<DateTime>
