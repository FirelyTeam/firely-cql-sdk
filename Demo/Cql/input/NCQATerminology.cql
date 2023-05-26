library NCQATerminology version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "RoleCode": 'http://hl7.org/fhir/v3/RoleCode'
codesystem "Diagnosis Role": 'http://terminology.hl7.org/CodeSystem/diagnosis-role'
codesystem "RequestIntent": 'http://terminology.hl7.org/CodeSystem/request-intent'
codesystem "MedicationRequestCategory": 'http://terminology.hl7.org/CodeSystem/medicationrequest-category'
codesystem "ConditionClinicalStatusCodes": 'http://terminology.hl7.org/CodeSystem/condition-clinical'
codesystem "ConditionVerificationStatusCodes": 'http://terminology.hl7.org/CodeSystem/condition-verification'
codesystem "AllergyIntoleranceClinicalStatusCodes": 'http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical'
codesystem "AllergyIntoleranceVerificationStatusCodes": 'http://terminology.hl7.org/CodeSystem/allergyintolerance-verification'
codesystem "AllergyIntoleranceType": 'http://hl7.org/fhir/allergy-intolerance-type'
codesystem "AllergyIntoleranceCategory": 'http://hl7.org/fhir/allergy-intolerance-category'
codesystem "ConditionCategoryCodes": 'http://terminology.hl7.org/CodeSystem/condition-category'
codesystem "claim-type": 'http://terminology.hl7.org/CodeSystem/claim-type'
codesystem "ActEncounterCodes": 'http://terminology.hl7.org/ValueSet/v3-ActEncounterCode'
codesystem "coverage-type": 'http://terminology.hl7.org/ValueSet/v3-ActCoverageTypeCode'
codesystem "IdentifierType": 'http://terminology.hl7.org/CodeSystem/v2-0203'

// Condition Category Codes

code "problem-list-item": 'problem-list-item' from "ConditionCategoryCodes"
code "encounter-diagnosis": 'encounter-diagnosis' from "ConditionCategoryCodes"

// Condition Clinical Status Codes
code "active": 'active' from "ConditionClinicalStatusCodes"
code "recurrence": 'recurrence' from "ConditionClinicalStatusCodes"
code "relapse": 'relapse' from "ConditionClinicalStatusCodes"
code "inactive": 'inactive' from "ConditionClinicalStatusCodes"
code "remission": 'remission' from "ConditionClinicalStatusCodes"
code "resolved": 'resolved' from "ConditionClinicalStatusCodes"

// Condition Verification Status Codes
code "unconfirmed": 'unconfirmed' from "ConditionVerificationStatusCodes"
code "provisional": 'provisional' from "ConditionVerificationStatusCodes"
code "differential": 'differential' from "ConditionVerificationStatusCodes"
code "confirmed": 'confirmed' from "ConditionVerificationStatusCodes"
code "refuted": 'refuted' from "ConditionVerificationStatusCodes"
code "entered-in-error": 'entered-in-error' from "ConditionVerificationStatusCodes"

// Allergy/Intolerance Clinical Status Codes
code "allergy-active": 'active' from "AllergyIntoleranceClinicalStatusCodes"
code "allergy-inactive": 'inactive' from "AllergyIntoleranceClinicalStatusCodes"
code "allergy-resolved": 'resolved' from "AllergyIntoleranceClinicalStatusCodes"

// Allergy/Intolerance Verification Status Codes
code "allergy-unconfirmed": 'unconfirmed' from "AllergyIntoleranceVerificationStatusCodes"
code "allergy-confirmed": 'confirmed' from "AllergyIntoleranceVerificationStatusCodes"
code "allergy-refuted": 'refuted' from "AllergyIntoleranceVerificationStatusCodes"

// Allergy/Intolerance Category Codes
code "food": 'food' from "AllergyIntoleranceCategory"
code "medication": 'medication' from "AllergyIntoleranceCategory"
code "environment": 'environment' from "AllergyIntoleranceCategory"
code "biologic": 'biologic' from "AllergyIntoleranceCategory"

// AllergyIntolerance Type Codes
code "Allergy": 'allergy' from "AllergyIntoleranceType"
code "Intolerance": 'intolerance' from "AllergyIntoleranceType"

// MedicationRequest Category Codes
code "Inpatient": 'inpatient' from "MedicationRequestCategory"
code "Outpatient": 'outpatient' from "MedicationRequestCategory"
code "Community": 'community' from "MedicationRequestCategory"
code "Discharge": 'discharge' from "MedicationRequestCategory"

// Claim Type Codes
code "Pharmacy": 'pharmacy' from "claim-type"
code "Institutional": 'institutional' from "claim-type"
code "Professional": 'professional' from "claim-type"
code "Oral": 'oral' from "claim-type"
code "Vision": 'vision' from "claim-type"

// ActEncounterCodes
code "virtual": 'VR' from "ActEncounterCodes"
code "ambulatory": 'AMB' from "ActEncounterCodes"
code "home health": 'HH' from "ActEncounterCodes"
code "inpatient non-acute": 'NONAC' from "ActEncounterCodes"
code "emergency": 'EMER' from "ActEncounterCodes"
code "inpatient acute": 'ACUTE' from "ActEncounterCodes"

// Coverage-type
code "drug policy": 'DRUGPOL' from "coverage-type"
code "mental health policy": 'MENTPOL' from "coverage-type"
code "managed care policy": 'MCPOL' from "coverage-type"
code "subsidized health program": 'SUBSIDIZ' from "coverage-type"
code "retiree health program": 'RETIRE' from "coverage-type"
code "substance use policy": 'SUBPOL' from "coverage-type"

// Identifier Type Codes
code "Provider number": 'PRN' from "IdentifierType"
