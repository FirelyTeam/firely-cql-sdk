library NCQAStatus version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include NCQATerminology version '1.0.0' called Terminology

context Patient

// AllergyIntolerance
define function "Active Allergy"(Allergy List<FHIR.AllergyIntolerance>):
    Allergy A
         where A.clinicalStatus = Terminology."allergy-active"

// Condition
define function "Active Condition"(Condition List<FHIR.Condition>):
   Condition C
       where C.clinicalStatus = Terminology."active"

// Encounter
define function "Finished Encounter"(Enc List<FHIR.Encounter>):
    Enc E
        where E.status = 'finished'

// Immunization
define function "Completed Immunization"(Immunization List<FHIR.Immunization>):
    Immunization I
        where I.status = 'completed'

// MedicationDispense
define function "Dispensed Medication"(Med List<FHIR.MedicationDispense>):
    Med M
        where M.status = 'completed'

// MedicationRequest
define function "Active Medication"(Med List<FHIR.MedicationRequest>):
    Med M
        where M.status in {'completed'}

// Procedure
define function "Completed Procedure"(Proc List<FHIR.Procedure>):
    Proc P
        where P.status = 'completed'

define function "Completed or Ongoing Procedure"(Proc List<FHIR.Procedure>):
    Proc P
        where P.status in {'completed', 'in-progress'}
