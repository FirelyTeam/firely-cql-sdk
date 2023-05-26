library OnAdmission

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001'

include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global
include CumulativeMedicationDurationFHIR4 version '1.0.000' called CMD

valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'
valueset "Immune Modulators": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.124'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2019-01-01T00:00:00.0, @2020-01-01T00:00:00.0)

context Patient

/*
https://oncprojectracking.healthit.gov/support/projects/CQLIT/issues/CQLIT-315

How do we make use of the DiagnosisPresentOnAdmission extension to determine whether
a diagnosis was present on admission?

http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission
*/

//define "Encounter With Diabetes Diagnosis Present on Admission":
//  Global."Inpatient Encounter" IPEncounter
//    where exists (IPEncounter.diagnosis Diagnosis
//      where (singleton from ([Condition] C where C.id = Global.GetId(Diagnosis.condition.reference))).code in "Diabetes"
//        and Global.GetExtension(Diagnosis, 'http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission').value in Global."Present on Admission or Clinically Undetermined"
//    )

/*
Potential improvement?
*/

//define "EncounterDiagnosis":
//  Global."Inpatient Encounter" IPEncounter
//    return IPEncounter.diagnosis

//define "Encounter With Diabetes Diagnosis Present on Admission (2)":
//  Global."Inpatient Encounter" IPEncounter
//    where exists ((Global.PresentOnAdmissionDiagnosis(IPEncounter)) POADiagnosis
//      where POADiagnosis.code in "Diabetes"
//    )

define "Encounter With Diabetes Diagnosis Present on Admission (3)":
  Global."Inpatient Encounter" IPEncounter
    where exists (IPEncounter.diagnosis D
      where Global.GetCondition(D.condition).code in "Diabetes"
        and Global.PresentOnAdmissionIndicator(D) in "Present on Admission or Clinically Undetermined"
    )

//define "Encounter With Diabetes Diagnosis Present on Admission (4)":
//  Global."Inpatient Encounter" IPEncounter
//    where exists (IPEncounter.diagnosis D
//      where Global.GetCondition(D.condition).code in "Diabetes"
//        and diagnosis.presentOnAdmission in "Present on Admission or Clinically Undetermined"
//    )


/*
https://oncprojectracking.healthit.gov/support/projects/CQLIT/issues/CQLIT-316
Medication Active on Admission
*/

/*
define "Encounter With Immune Modifier Active on Admission":
  Global."Inpatient Encounter" IPEncounter
    with ["MedicationRequest": "Immune Modulators"] ImmunoMeds
      such that ImmunoMeds.authoredOn same day as start of Global."HospitalizationWithObservation" ( IPEncounter )
        and exists (ImmunoMeds.category C where C ~ Global."Community")
        and ImmunoMeds.status = 'active'
        and ImmunoMeds.intent = 'order'
*/

/*
The issue I see is that the use of authoredOn implies this will only work for prescriptions that are recorded on admission
It's not clear that MedicationRequest would be used for that purpose, that seems like more of a MedicationStatement use case
Further, if MedicationRequest records are available from the patient record, we would need to use something like the
CumulativeMedicationDuration logic to look at all MedicationRequest, and potentially dispense records to dtermine whether
this is a medication that is "active":
*/

define "Encounter With Immune Modifier Active on Admission (2)":
  Global."Inpatient Encounter" IPEncounter
    with ["MedicationRequest": "Immune Modulators"] ImmunoMeds
      such that ImmunoMeds.status = 'active'
        and (ImmunoMeds.intent = 'order' or (ImmunoMeds.intent = 'plan' and (ImmunoMeds.reported is true or ImmunoMeds.reported is not null)))
        and exists (ImmunoMeds.category C where C ~ Global."Community")
        and CMD.MedicationRequestPeriod(ImmunoMeds) overlaps before IPEncounter.period
