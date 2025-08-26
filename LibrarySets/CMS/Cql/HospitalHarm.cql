library HospitalHarm version '1.1.000'
using QICore version '4.1.1'
include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '2.1.000' called QICoreCommon
include CQMCommon version '2.2.000' called CQMCommon


  
// diagnosisPresentOnAdmission
// Given an Encounter, this function returns the Present On Admission code of encounter's diagnosis, if present. Returns null otherwiese. 
// Usage: anEncouner.diagnosisPresentOnAdmission()

define fluent function diagnosisPresentOnAdmission(enc Encounter):
  (singleton from (
    enc.diagnosis.extension E where E.url = 'http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission'
  )).value as Concept

// procedureRank
// Return a singleton from the ranks of procedures performed during an encounter.
// Usage: anEncounter.procedureRank()  
//        to get the rank integer:  anEncounter.procedureRank().rank

define fluent function "procedureRank"(theEncounter Encounter):
  ( singleton from ( theEncounter.extension E
      where E.url = 'http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-procedure'
  ) ) encext
    let erank: encext.extension E
      where E.url = 'rank'
      return E.value as Integer
    return {
      rank: erank
    }

// startsDuringHospitalization
// Given an encounter, returns true if the calling observation effective time or procedure performed starts during that encounter. 
// The interval of the encounter is
// determined by calling the CQCommon function 'HospitalizationWithObservationAndOutpatientSurgeryService'wth the encounter as the argument.
// Usage:   theObservation.startsDuringHospitalization(anEncounter)


define fluent function startsDuringHospitalization(choice Choice<Procedure,Observation>, enc Encounter):
   case
      when choice is Procedure then QICoreCommon.ToInterval ( (choice as Procedure).performed ) starts during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
      when choice is Observation then QICoreCommon.ToInterval ( (choice as Observation).effective ) starts during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
else false
    end


// isDuringHospitalization
// Given an encounter, returns true if the calling observation effective time or procedure performed occurs during that encounter. 
// The interval of the encounter is
// determined by calling the CQCommon function 'HospitalizationWithObservationAndOutpatientSurgeryService'wth the encounter as the argument.
// Usage:   theProcedure.isDuringHospitalization(anEncounter)


define fluent function isDuringHospitalization(choice Choice<Procedure,Observation>, enc Encounter):
   case
      when choice is Procedure then  
        QICoreCommon.ToInterval ( (choice as Procedure).performed )  during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
      when choice is Observation then  
         QICoreCommon.ToInterval ((choice as Observation).effective ) during CQMCommon."HospitalizationWithObservationAndOutpatientSurgeryService" ( enc )
else false
    end

// interval
// Given an encounter, procedure or observation resource, returns a normalized Interval object, calculated using QICoreCommon.ToInterval for the given type of resource. 
// Usage:   theEncounter.interval()


define fluent function interval(choice Choice<Procedure,Observation,Encounter>):
   case
      when choice is Procedure   then QICoreCommon.ToInterval ( (choice as Procedure).performed ) 
      when choice is Observation then QICoreCommon.ToInterval ( (choice as Observation).effective ) 
      when choice is Encounter   then QICoreCommon.ToInterval ( (choice as Encounter).period ) 
  else null as Interval<DateTime>
    end