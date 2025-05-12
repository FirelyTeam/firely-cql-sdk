library ConceptDefTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers


codesystem "SNOMED": 'http://snomed.info/sct'

code "Diabetes Mellitus": '44054006' from "SNOMED" display 'Diabetes Mellitus'
code "Hypertension Example": '38341003' from "SNOMED" display 'Hypertension'
code "Medication Example": '763158003' from "SNOMED" display 'Medication Example'

// Define a concept for Diabetes
concept Diabetes:
{
    "Diabetes Mellitus"
}

// Define a concept for Hypertension
concept Hypertension:
{
    "Hypertension Example"
}

// Define a concept for Medication
concept Medication:
{
    "Medication Example"
}

context Patient

// // Define a function to identify patients with Diabetes
// define "Patients with Diabetes":
// [Condition: Code in Diabetes]
//
// // Define a function to identify patients with Hypertension
// define "Patients with Hypertension":
// [Condition: Code in Hypertension]
//
// // Define a function to identify patients on specific Medication
// define "Patients on Medication":
// [MedicationRequest: Code in Medication]
//
// Define a function to identify patients with both Diabetes and Hypertension
//define "Patients with Diabetes and Hypertension":
//"Patients with Diabetes" and "Patients with Hypertension"