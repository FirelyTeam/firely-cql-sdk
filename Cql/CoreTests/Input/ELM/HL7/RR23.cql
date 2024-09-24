library RR23 version '1.0.0'

/*
@publisher: MOH Alpha
@description: Library used to validate guidance related to Roadrunners Syndrome
*/

using FHIR version '4.0.1'
include FHIRHelpers version '4.0.1'

codesystem "ACME Product Catalog": 'http://acme.org/product-catalog'
codesystem "ConditionVerificationStatusCodes": 'http://terminology.hl7.org/CodeSystem/condition-ver-status'

valueset "Injury due to falling rock": 'http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock'
valueset "Roadrunners Syndrome Indicators": 'http://moh.alpha.alp/ValueSet/DiagnosisRoadrunnerSyndrome'

code "Tiny Umbrella": 'U707' from "ACME Product Catalog" display 'ACME Tiny Umbrella'
code "entered-in-error": 'entered-in-error' from ConditionVerificationStatusCodes

/*
@parameter: in
*/
parameter "Measurement Period" default Interval[@2023-01-01T, @2023-12-31T]

context Patient

/*
@description: Is Patient in Initial Population ? Patients aged 16 and older who have sustained injuries due to falling rock.
@parameter: out
*/
define "Initial Population":
  (AgeInYearsAt(start of "Measurement Period") >= 16) and exists("Injury due to falling rock within measurement period")

/*
@description: Is Patient in Denominator ? Denominator equals the initial population.
@parameter: out
*/
define "Denominator":
    "Initial Population"

/*
@description: In Numerator ? Supply of 'ACME Umbrella' within 7 days of "recording of the (latestmost recent) rock fall condition within the measurement period"
@parameter: out
*/
define "Numerator":
    exists "Tiny Umbrella Supply within 7 days after most recent injury due to falling rock"

/*
@description: Conditions of type 'Injury due to falling rock' within the measurement period
@fhirquery: akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]
@datarequirement: Condition http://hl7.org/fhir/StructureDefinition/Encounter ["code","onset.ofType(DateTime)","subject.ofType(Patient)"]
@coderequirement: Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock
*/
define "Injury due to falling rock within measurement period":
    [Condition: "Injury due to falling rock"] C
       where (C.onset.value as DateTime) during "Measurement Period"

define "Last injury due to falling rock":
      Last( "Injury due to falling rock within measurement period" C sort by (onset.value as DateTime) )

define "Date of last injury due to falling rock":
      "Last injury due to falling rock".onset.value as DateTime
/*
@description: Is there a supply of a 'ACME Umbrella' within 7 days of "recording of the (latest) rock fall condition within the measurement period"
@fhirquery: akin to /SupplyDelivery?supplied-item=http://acme.org/product-catalog|U707&ocurrence-datetime=lt[Condition onset date+7 days]
@datarequirement: SupplyDelivery http://hl7.org/fhir/StructureDefinition/SupplyDelivery ["suppliedItem.item.ofType(CodeableConcept)","occurrenceDateTime","patient"]
@coderequirement: SupplyDelivery.item.orfType(CodeableConcept) http://acme.org/product-catalog|U707
*/
define "Tiny Umbrella Supply within 7 days after most recent injury due to falling rock":
    [SupplyDelivery] SD
      where (SD.suppliedItem.item ~ "Tiny Umbrella")
       and ("Date of last injury due to falling rock" 7 days or less before (SD.occurrence.value as DateTime))