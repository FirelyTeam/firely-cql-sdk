library HospitalHarm version '2.5.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include CQMCommon version '4.1.000' called CQMCommon



valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'
valueset "Not Present On Admission or Documentation Insufficient to Determine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198'

codesystem "Diagnosis Type": 'http://terminology.hl7.org/CodeSystem/ex-diagnosistype'
codesystem "Procedure Type": 'http://terminology.hl7.org/CodeSystem/ex-procedure-type'
code "Principal Diagnosis": 'principal' from "Diagnosis Type"
code "Primary Procedure": 'primary' from "Procedure Type" 

context Patient

// In QICore 6.0.0, when inquiring about Principal Diagnosis and/or Present On Admission status, use the Claim resource(s) associated
// with the Encounter. Within each Claim resource, reference its included diagnoses elements)
// When inquiring about an Encounter's diagnoses in general, use the Encounter's included diagnoses elements).

// --------------------------- Claim-based Principal Diagnosis and Present On Admission functions ----------------------------
/* 
 @description Given a Claim, this function returns the On Admission code of a given Claim's first diagnosis, if present. Returns null otherwiese. 
 @example aClaim.diagnosisOnAdmission()
 */
 define fluent function diagnosisOnAdmission(claim Claim):
  (singleton from (
    claim.diagnosis.onAdmission 
  )) as Concept
  
// Note: previous versions of QICore (e.g. 4.1.1) determined On Admission via an encounter's diagnosis extension as such: 
// enc.diagnosis.extension E where E.url = 'http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission'
// QI Core 6.0.0 and later uses Claim for this purpose. 

/*
@description Returns a list of an encounter's claims diagnoses where each claim has a status of 'active' and a use of 'claim'
@example  anEncounter.claimDiagnoses()
*/
define fluent function claimDiagnoses(encounter Encounter):
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.diagnosis D where D.sequence in claimItem.diagnosisSequence

/*
@description Returns a list of an encounter's claim diagnoses where each claim has a status of 'active' and a use of 'claim' and the diagnosis.onAdmission value is present
@exammple  anEncounter.claimDiagnosesWithPOA()
*/
define fluent function claimDiagnosesWithPOA(encounter Encounter):
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.diagnosis D where D.sequence in claimItem.diagnosisSequence and D.onAdmission is not null
   
/*
@description Returns a list of an encounter's claims procedures where each claim has a status of 'active' and a use of 'claim'
@example  anEncounter.claimProcedures()
*/
define fluent function claimProcedures(encounter Encounter):
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.procedure P where P.sequence in claimItem.procedureSequence

/*
@description Returns true if an Encounter has a claim with a principal diagnosis, false otherwise
@comment This only considers Claims whose status is 'active' and use is 'claim', and whose type includes code "Principal Diagnosis"
@example  anEncounter.hasPrincipalDiagnosis()
*/
define fluent function hasPrincipalDiagnosis(encounter Encounter):
exists (
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.diagnosis D where D.sequence in claimItem.diagnosisSequence and D.type.includesCode("Principal Diagnosis") 
) 

/*
@description Returns true if an Encounter has a claim whose principal diagnosis is in the given ValueSet, false otherwise
@comment This only considers Claims whose status is 'active' and use is 'claim', and whose type includes code "Principal Diagnosis"
@example  anEncounter.hasPrincipalDiagnosisIn("Acute Respiratory Failure")
*/
define fluent function hasPrincipalDiagnosisIn(encounter Encounter, diagnosisValueSet ValueSet):
exists (
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.diagnosis D where D.sequence in claimItem.diagnosisSequence and D.type.includesCode("Principal Diagnosis") and D.diagnosis as Concept in diagnosisValueSet
) 

/*
@description Returns true if an Encounter has a claim whose diagnosis is in  the given Valueset, and has an onAdmission value within the "Present on Admission or Clinically Undetermined" ValueSet, false otherwise
@comment This only considers Claims whose status is 'active' and use is 'claim'
@example  anEncounter.hasDiagnosisPresentOnAdmission("Acute Respiratory Failure")
*/
define fluent function hasDiagnosisPresentOnAdmission(encounter Encounter, diagnosisValueSet ValueSet):
exists (
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.diagnosis D where D.sequence in claimItem.diagnosisSequence and D.onAdmission in "Present on Admission or Clinically Undetermined" and D.diagnosis in diagnosisValueSet
)

/*
@description Returns true if an Encounter has a claim whose diagnosis is in  the given Valueset, and has an onAdmission value within the "Not Present On Admission or Documentation Insufficient to Determine" ValueSet, false otherwise
@comment This only considers Claims whose status is 'active' and use is 'claim'
@example  anEncounter.hasDiagnosisPresentOnAdmission("Acute Respiratory Failure")
*/
define fluent function hasDiagnosisNotPresentOnAdmission(encounter Encounter, diagnosisValueSet ValueSet):
exists (
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.diagnosis D where D.sequence in claimItem.diagnosisSequence and D.onAdmission in "Not Present On Admission or Documentation Insufficient to Determine" and D.diagnosis in diagnosisValueSet
)


/*
@description Returns true if an Encounter has any claim whose diagnosis has an onAdmission value within the "Not Present On Admission or Documentation Insufficient to Determine" ValueSet, false otherwise
@comment This only considers Claims whose status is 'active' and use is 'claim'
@example  anEncounter.hasDiagnosisPresentOnAdmission()
*/
define fluent function hasDiagnosisNotPresentOnAdmission(encounter Encounter):
exists (
  encounter E
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(E))),
      claimItem: (claim.item I where I.encounter.references(E))
    return claim.diagnosis D where D.sequence in claimItem.diagnosisSequence and D.onAdmission in "Not Present On Admission or Documentation Insufficient to Determine" 
)

/*
@description Given a Claim, return true if the claim has a diagnosis that is in the given ValueSet, false otherwise
@example  aClaim.diagnosisIn("Obstetrics and VTE Obstetrics")
 */
define fluent function hasDiagnosisIn(claim Claim, vset ValueSet) :
    exists (claim.diagnosis.diagnosis D 
            where D  in vset)

// ----------------------------------- end Claim-based diagnosis functions ------------------------------------------

/*
@description Returns the Condition or Procedure referenced by the target reference
@comment the calling reference should be the reference in an Encounter resource diagnosis condition.
@example   enc.getDiagnosis().condition.getDiagnosisCondition()
*/
define fluent function getDiagnosisCondition(reference Reference):
  ([ConditionEncounterDiagnosis] C where reference.references(C.id)) 
                  union
  ([ConditionProblemsHealthConcerns] D where reference.references(D.id))
                  union
  ([Procedure] P where reference.references(P.id))

/*
@description returns a singleton QICore.Encounter.Diagnosis from the calling Encounter
@example enc.getDiagnosis()
*/
define fluent function getDiagnosis(enc Encounter) :
      singleton from (enc.diagnosis diag where  diag.condition.getDiagnosisCondition() is not null)

/*
@description returns a singleton System.Concept of the singleton Diagnosis Condtion from the calling Encounter
@example enc.getDiagnosisCode()
*/
define fluent function getDiagnosisCode(enc Encounter) :
     singleton from (enc.getDiagnosis().condition.getDiagnosisCondition().code)

/*
@description Returns true if the Encounter has a diagnosis whose code is in  the given ValueSet, false otherwise
@example   anEncounter.hasDiagnosisIn("Value set name")
*/
define fluent function hasDiagnosisIn(enc Encounter, vset ValueSet) :
      enc.getDiagnosisCode() in vset

/*
@description Returns true if the Procedure's code is in  the given ValueSet, false otherwise
@example   aProcedure.isIn("Value set name")
*/
define fluent function isIn(proc Procedure, vset ValueSet) :
      proc.code is not null and proc.code as Concept in  vset


/*
@description Returns true if the Encounter has a type code that  is in  the given ValueSet, false otherwise
@example   anEncounter.isIn("Value set name")
*/
define fluent function isIn(enc Encounter, vset ValueSet) :
      exists (enc.type aType where aType as Concept in  vset)

/*
@description Returns true if the Lab result observation's code is in  the given ValueSet, false otherwise
@example   aLaboratoryResultObservatione.isIn("Value set name")
*/
define fluent function isIn(obs LaboratoryResultObservation, vset ValueSet) :
      obs.value is not null and obs.value as Concept in  vset

/*
@description Returns true if the Location has a type code that is  in  the given ValueSet, false otherwise
@example   aLocation.isIn("Value set name")
*/
define fluent function isIn(loc Location, vset ValueSet) :
      exists (loc.type aType where aType is not null and aType as Concept in  vset)

 
/*
@description For  a number of resource types, returns true if the resource has a code or type that is in the given ValueSet
@comment The resource types available are: Procedure, LaboratoryResultObservation, Encounter, Location
@example  anEncounter.isIn("aValusetName")
*/
define fluent function isIn(choice Choice<Procedure, LaboratoryResultObservation, Encounter, Location>, vset ValueSet) :
case
      when choice is Procedure then Tuple { ID: (choice as Procedure).id, isInValueSet: (choice as Procedure).isIn(vset)}
      when choice is LaboratoryResultObservation then Tuple { ID: (choice as LaboratoryResultObservation).id,  isInValueSet: (choice as LaboratoryResultObservation).isIn(vset)}
      when choice is Encounter then Tuple { ID: (choice as Encounter).id,  isInValueSet: (choice as Encounter).isIn(vset)}
      when choice is Location then Tuple { ID: (choice as Location).id,  isInValueSet: (choice as Location).isIn(vset)}

else false
end

/*
@description returns a 'rank' integer value for the procedure, given the procedure's presumed parent encounter. Examines each of the procedures within the encounter's claims and returns the sequence of the procedure if the procedure's id is the same as  the given procedure.
@example  aProcedure.rank(anEncounter)
*/
define fluent function rank(targetProcedure Procedure, parentEncounter Encounter):
  singleton from ( targetProcedure P
    let 
      claim: ([Claim] C where C.status = 'active' and C.use = 'claim' and exists (C.item I where I.encounter.references(parentEncounter))),
      claimProc: (claim.procedure proc where proc.procedure.references(P))
    return claimProc.sequence R 
  )

/*
@description Given an encounter, returns true if the calling observation effective time or procedure performed starts during that encounter. 
@comment The interval of the encounter is determined by calling the CQCommon function 'HospitalizationWithObservationAndOutpatientSurgeryService'wth the encounter as the argument.
@example theObservation.startsDuringHospitalization(anEncounter)
*/

define fluent function startsDuringHospitalization(choice Choice<Procedure,LaboratoryResultObservation>, enc Encounter):
   case
      when choice is Procedure then QICoreCommon.ToInterval ( (choice as Procedure).performed ) starts during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
      when choice is LaboratoryResultObservation then QICoreCommon.ToInterval ( (choice as LaboratoryResultObservation).effective ) starts during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
else false
    end


/*
@description Given an encounter, returns true if the calling observation effective time or procedure performed occurs during that encounter. 
@comment The interval of the encounter is determined by calling the CQCommon function 'HospitalizationWithObservationAndOutpatientSurgeryService'wth the encounter as the argument.
@example   theProcedure.isDuringHospitalization(anEncounter)
*/

define fluent function isDuringHospitalization(choice Choice<Procedure,LaboratoryResultObservation>, enc Encounter):
   case
      when choice is Procedure then  
        QICoreCommon.ToInterval ( (choice as Procedure).performed )  during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
      when choice is LaboratoryResultObservation then  
         QICoreCommon.ToInterval ((choice as LaboratoryResultObservation).effective ) during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
    else false
    end

/*
@description Given an encounter, procedure or observation resource, returns a normalized Interval object, calculated using QICoreCommon.ToInterval for the given type of resource. 
@example   theEncounter.interval()
*/

define fluent function interval(choice Choice<Procedure,LaboratoryResultObservation,Encounter>):
   case
      when choice is Procedure   then QICoreCommon.ToInterval ( (choice as Procedure).performed ) 
      when choice is LaboratoryResultObservation then QICoreCommon.ToInterval ( (choice as LaboratoryResultObservation).effective ) 
      when choice is Encounter   then QICoreCommon.ToInterval ( (choice as Encounter).period ) 
  else null as Interval<DateTime>
    end