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
parameter "Measurement Period" default Interval[@2023-01-01, @2023-12-31]

context Patient

/*
@description: Conditions of type 'Injury due to falling rock' within the measurement period
@fhirquery: akin to Condition?code:in=http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock&onset-date=sa[Period-start]&onset-date=eb[Period-end]
@datarequirement: Condition http://hl7.org/fhir/StructureDefinition/Encounter ["code","onset.ofType(DateTime)","subject.ofType(Patient)"]
@coderequirement: Condition.code http://moh.alpha.alp/ValueSet/DiagnosisInjuryDueToFallingRock
*/
define "Injury due to falling rock within measurement period": 1




