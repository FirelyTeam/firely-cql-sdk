library PCMaternal version '5.25.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon 

codesystem "LOINC": 'http://loinc.org' 

valueset "Delivery Procedures": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59' 
valueset "ED Visit and OB Triage": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369' 
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307' 
valueset "Estimated Gestational Age at Delivery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26' 
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143' 

code "Date and time of obstetric delivery": '93857-1' from "LOINC" display 'Date and time of obstetric delivery'
code "Delivery date Estimated": '11778-8' from "LOINC" display 'Delivery date Estimated'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Delivery Encounter With Age Range":
  "Encounter With Age Range" EncounterWithAge
                with ["Procedure": "Delivery Procedures"] DeliveryProcedure
                such that DeliveryProcedure.status = 'completed'
                and DeliveryProcedure.performed.toInterval  ( ) starts during EncounterWithAge.hospitalizationWithEDOBTriageObservation ()

define "Encounter With Age Range":
 CQMCommon."Inpatient Encounter" InpatientEncounter
                      where AgeInYearsAt(date from start of InpatientEncounter.period) in Interval[ 8, 65 )
                  

define "Variable Calculated Gestational Age":
 "Delivery Encounter With Age Range" DeliveryEncounter
    let CGA: DeliveryEncounter.calculatedGestationalAge()
    return {
      EncounterID: DeliveryEncounter.id,
      CalculatedCGA: CGA
    }

define fluent function calculatedGestationalAge (TheEncounter Encounter ):
  //Gestational Age = (280 -(Estimated Delivery Date minus Reference Date/Delivery Date))/7
 ( 280 - ( difference in days between TheEncounter.lastTimeOfDelivery () and TheEncounter.lastEstimatedDeliveryDate( )) ) div 7

    
    
define fluent function hospitalizationWithEDOBTriageObservation (TheEncounter Encounter ):
  /*hospitalizationWithEDOBTriageObservation returns the total interval from the start of any immediately prior emergency department visit or OB Triage visit through the observation visit to the discharge of the given encounter*/
  TheEncounter Visit
    let ObsVisit: Last(["Encounter": "Observation Services"] LastObs
        where LastObs.period ends 1 hour or less on or before start of Visit.period
          and LastObs.status = 'finished'
        sort by 
        end of period
    ),
    VisitStart: Coalesce(start of ObsVisit.period, start of Visit.period),
    EDOBTriageVisit: Last(["Encounter": "ED Visit and OB Triage"] LastEDOBTriage
        where LastEDOBTriage.period ends 1 hour or less on or before VisitStart
          and LastEDOBTriage.status = 'finished'
        sort by 
        end of period
    )
    return Interval[Coalesce(start of EDOBTriageVisit.period, VisitStart), 
    end of Visit.period]
  

define fluent function lastEstimatedDeliveryDate (TheEncounter Encounter ):
  /*This function identifies the last time the EDD was assessed 42 weeks or less prior to or on delivery and stores the result of that assessment.*/
  Last(["SimpleObservation": "Delivery date Estimated"] EstimatedDateOfDelivery
      where EstimatedDateOfDelivery.value as DateTime is not null
        and EstimatedDateOfDelivery.status in { 'final', 'amended', 'corrected' }
        and EstimatedDateOfDelivery.effective.earliest ( ) 42 weeks or less before or on TheEncounter.lastTimeOfDelivery ()
      sort by effective.earliest ( )
  ).value as DateTime


  define fluent function lastEstimatedGestationalAge (TheEncounter Encounter ):
  Last(["SimpleObservation": "Estimated Gestational Age at Delivery"] EstimatedGestationalAge
  let EGATiming:  EstimatedGestationalAge.effective.earliest() where 
  (EGATiming 24 hours or less before or on TheEncounter.lastTimeOfDelivery () 
  and EstimatedGestationalAge.value is not null 
  and EstimatedGestationalAge.status in { 'final', 'amended', 'corrected' }) or 
      (EGATiming same day as TheEncounter.lastTimeOfDelivery () 
      and EGATiming during TheEncounter.hospitalizationWithEDOBTriageObservation() 
      and EstimatedGestationalAge.value is not null)
 sort by effective.earliest ())
         .value as Quantity

define fluent function lastTimeOfDelivery (TheEncounter Encounter ):
  Last(["SimpleObservation": "Date and time of obstetric delivery"] TimeOfDelivery
      where TimeOfDelivery.value as DateTime is not null
        and TimeOfDelivery.status in { 'final', 'amended', 'corrected' }
        and TimeOfDelivery.effective.earliest () during TheEncounter.hospitalizationWithEDOBTriageObservation ()
        and TimeOfDelivery.value as DateTime during TheEncounter.hospitalizationWithEDOBTriageObservation()
      sort by effective.earliest()
  ).value as DateTime