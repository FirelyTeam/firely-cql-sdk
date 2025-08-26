library CMS1218HHRFFHIR version '0.0.003'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon
include CQMCommon version '2.2.000' called CQMCommon
include HospitalHarm version '1.1.000' called HospitalHarm

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "HSLOC": 'https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html'

valueset "Acute Respiratory Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.88'
valueset "Albumin lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.221'
valueset "Anesthesia Requiring Monitored Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.255'
valueset "Arterial Blood pH": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.96'
valueset "ASA physical status class": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.217'
valueset "Aspartate transaminase lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.224'
valueset "Bicarbonate lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139'
valueset "Bilirubin lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.223'
valueset "Blood urea nitrogen lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.218'
valueset "Carbon Dioxide Partial Pressure in Arterial Blood": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.95'
valueset "Creatinine lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363'
valueset "Degenerative Neurological Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.241'
valueset "Elective Inpatient Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.85'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "General and Neuraxial Anesthesia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.208'
valueset "Head and Neck Surgeries with High Risk Airway Compromise": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.183'
valueset "Head, Neck, and Thoracic Surgeries with High Risk Airway Compromise": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.251'
valueset "Hematocrit lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114'
valueset "Hemoglobin lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.219'
valueset "Intensive Care Unit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206'
valueset "Intubation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.179'
valueset "Leukocyte count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.222'
valueset "Mechanical Ventilation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.107'
valueset "Neuromuscular Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.239'
valueset "Non Invasive Oxygen Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.213'
valueset "Non Invasive Oxygen Therapy by Nasal Cannula or Mask": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "Obstetrical or Pregnancy Related Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263'
valueset "Outpatient Surgery Service": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.38'
valueset "Oxygen Partial Pressure in Arterial Blood": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.94'
valueset "Platelet count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127'
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'
valueset "Procedural Hospital Locations": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.216'
valueset "Smoking status": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.220'
valueset "Sodium lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119'
valueset "Tracheostomy Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.89'
valueset "Tracheostomy Procedures": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.181'
valueset "White blood cells count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129'

code "American society of anesthesiologists morbidity state": '97816-3' from "LOINC" display 'American society of anesthesiologists morbidity state'
code "Body mass index (BMI) [Ratio]": '39156-5' from "LOINC" display 'Body mass index (BMI) [Ratio]'
code "Body temperature": '8310-5' from "LOINC" display 'Body temperature'
code "Elective (qualifier value)": '103390000' from "SNOMEDCT" display 'Elective (qualifier value)'
code "Heart rate": '8867-4' from "LOINC" display 'Heart rate'
code "Operating Room/Suite": '1096-7' from "HSLOC" display 'Operating Room/Suite'
code "Removal of endotracheal tube (procedure)": '271280005' from "SNOMEDCT" display 'Removal of endotracheal tube (procedure)'
code "Respiratory rate": '9279-1' from "LOINC" display 'Respiratory rate'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic blood pressure'
code "Tobacco smoking status": '72166-2' from "LOINC" display 'Tobacco smoking status'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2026-12-31T23:59:59.999Z]

context Patient

//----------------------  Measure Population Definitions --------------------------------------------------//


define "Initial Population":
  "Elective Inpatient Encounter with OR Procedure within 3 Days"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounter with Degenerative Neurological Disorder"
    union "Encounter with High Risk to Airway Head Neck and Thoracic Surgery"
    union "Encounter with Mechanical Ventilation that Starts More than One Hour Prior to Start of First OR Procedure"
    union "Encounter with Neuromuscular Disorder"
    union "Encounter with PaCO2 Greater Than 50 and Arterial pH Less Than 7.30 within 48 Hours Prior to Start of First OR Procedure"
    union "Encounter with PaO2 Less Than 50 within 48 Hours Prior to Start of First OR Procedure"
    union "Encounter with Principal Diagnosis of Acute Respiratory Failure"
    union "Encounter with Diagnosis of Acute Respiratory Failure Present on Admission"
    union "Encounter with Tracheostomy Present on Admission"
    union "Encounter with Tracheostomy Prior to or on the Same Day of First OR Procedure"

define "Numerator":
  "Encounter with Intubation Outside of Procedural Area within 30 Days of End of First OR Procedure"
    union "Encounter with Mechanical Ventilation Outside of Procedural Area within 30 Days of End of First OR Procedure and Preceded by Non Invasive Oxygen Therapy"
    union "Encounter with Extubation Outside of Procedural Area within 30 Days of End of First OR Procedure More Than 48 Hours After End of Anesthesia"
    union "Encounter with Mechanical Ventilation within 30 Days of End of First OR Procedure and Between 48 and 72 Hours After End of OR Procedure and not Preceded by Non Invasive Oxygen Therapy or Anesthesia"

//----------------------  Initial Population Clauses --------------------------------------------------//

// Initial Population - clause 1  - (referenced throughout the measure definitions)



define "Elective Inpatient Encounter with OR Procedure within 3 Days":
  "Elective Inpatient Encounter with Age and without Obstetrical Condition" ElectiveEncounter
    with ["Procedure": "General and Neuraxial Anesthesia"] SurgeryWithAnesthesia
      such that SurgeryWithAnesthesia.performed.earliest ( ) during ElectiveEncounter.hospitalizationInterval ( )
        and SurgeryWithAnesthesia.performed.earliest ( ) 3 days or less after start of ElectiveEncounter.hospitalizationInterval ( )   

//----------------------  Denominator Exclusion Clauses------------------------------------------------//

// Denominator Exclusions - clause 1



define "Encounter with Degenerative Neurological Disorder":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    where exists ( EncounterWithSurgery.diagnosis EncounterDiagnosis
        where EncounterDiagnosis.condition.getCondition ( ).code in "Degenerative Neurological Disorder"
    )

// Denominator Exclusions - clause 2


define "Encounter with High Risk to Airway Head Neck and Thoracic Surgery":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    with ["Procedure": "Head, Neck, and Thoracic Surgeries with High Risk Airway Compromise"] HeadNeckProcedures
      such that HeadNeckProcedures.startsDuringHospitalization ( EncounterWithSurgery )

// Denominator Exclusions - clause 3


define "Encounter with Mechanical Ventilation that Starts More than One Hour Prior to Start of First OR Procedure":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    with ["Procedure": "Mechanical Ventilation"] Ventilation
      such that Ventilation.interval ( ) starts more than 1 hour before start of FirstAnesthesiaDuringHospitalization(EncounterWithSurgery).interval ( )
        and Ventilation.startsDuringHospitalization ( EncounterWithSurgery )

// Denominator Exclusions - clause 4


define "Encounter with Neuromuscular Disorder":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    where exists ( EncounterWithSurgery.diagnosis EncounterDiagnosis
        where EncounterDiagnosis.condition.getCondition ( ).code in "Neuromuscular Disorder"
    )

// Denominator Exclusions - clause 5


define "Encounter with PaCO2 Greater Than 50 and Arterial pH Less Than 7.30 within 48 Hours Prior to Start of First OR Procedure":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Observation": "Carbon Dioxide Partial Pressure in Arterial Blood"] CarbonDioxide,
    ["Observation": "Arterial Blood pH"] BloodpH
    let FirstProcedure: FirstAnesthesiaDuringHospitalization(EncounterWithSurgery),
    FirstProcedureTime: FirstProcedure.interval ( )
    where CarbonDioxide.interval ( ) starts 48 hours or less before start of FirstProcedureTime
      and CarbonDioxide.value as Quantity > 50 'mm[Hg]'
      and BloodpH.interval ( ) starts 48 hours or less before start of FirstProcedureTime
      and BloodpH.value as Quantity < 7.30 '[pH]'
      and FirstProcedure is not null
    return EncounterWithSurgery
//fix

// Denominator Exclusions - clause 6



define "Encounter with PaO2 Less Than 50 within 48 Hours Prior to Start of First OR Procedure":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    let FirstProcedure: FirstAnesthesiaDuringHospitalization(EncounterWithSurgery)
    with ["Observation": "Oxygen Partial Pressure in Arterial Blood"] Oxygen
      such that Oxygen.interval ( ) starts 48 hours or less before start of FirstProcedure.interval ( )
        and Oxygen.value as Quantity < 50 'mm[Hg]'
        and FirstProcedure is not null
    return EncounterWithSurgery

// Denominator Exclusions - clause 7


define "Encounter with Principal Diagnosis of Acute Respiratory Failure":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    where exists ( EncounterWithSurgery.diagnosis Diagnosis
        where Diagnosis.condition.getCondition ( ).code in "Acute Respiratory Failure"
          and Diagnosis.rank = 1
    )

// Denominator Exclusions - clause 8


define "Encounter with Diagnosis of Acute Respiratory Failure Present on Admission":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    where EncounterWithSurgery.diagnosisPresentOnAdmission ( ) in "Present on Admission or Clinically Undetermined"
      and exists ( EncounterWithSurgery.diagnosis Diagnosis
          where Diagnosis.condition.getCondition ( ).code in "Acute Respiratory Failure"
      )
//fix

// Denominator Exclusions - clause 9



define "Encounter with Tracheostomy Present on Admission":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    where EncounterWithSurgery.diagnosisPresentOnAdmission ( ) in "Present on Admission or Clinically Undetermined"
      and exists ( EncounterWithSurgery.diagnosis Dx
          where Dx.condition.getCondition ( ).code in "Tracheostomy Diagnoses"
      )

// Denominator Exclusions - clause 10


define "Encounter with Tracheostomy Prior to or on the Same Day of First OR Procedure":
  "Encounter with Tracheostomy Before Day of First OR Procedure"
    union "Encounter with Tracheostomy Same Day of First OR Procedure"
//fix

//----------------------  Numerator Clauses --------------------------------------------------//

// Numerator - clause 1




define "Encounter with Intubation Outside of Procedural Area within 30 Days of End of First OR Procedure":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Intubation"] EndotrachealTubeIn
    let IntubationInterval: EndotrachealTubeIn.interval ( ),
    LatestAnesthesiaInterval: "LatestGeneralAnesthesiaOrMAC"(EndotrachealTubeIn).interval ( )
    where EndotrachealTubeIn.starts30DaysOrLessAfterFirstProcedure ( EncounterWithSurgery )
      and EndotrachealTubeIn.startsDuringHospitalization ( EncounterWithSurgery )
      and IntubationInterval starts after end of LatestAnesthesiaInterval
      and EncounterWithSurgery.isNotAtProceduralHospitalLocationDuring ( IntubationInterval )
      and not ( "Intubation During General Anesthesia and MAC".id contains EndotrachealTubeIn.id )
    return EncounterWithSurgery 

// Numerator - clause 2


define "Encounter with Mechanical Ventilation Outside of Procedural Area within 30 Days of End of First OR Procedure and Preceded by Non Invasive Oxygen Therapy":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Mechanical Ventilation"] Ventilation,
    "Noninvasive Oxygen Therapy" OxygenSupport
    let VentilationInterval: Ventilation.interval ( ),
    LatestAnesthesiaInterval: "LatestGeneralAnesthesiaOrMAC"(Ventilation).interval ( )
    where Ventilation.starts30DaysOrLessAfterFirstProcedure ( EncounterWithSurgery )
      and Ventilation.startsDuringHospitalization ( EncounterWithSurgery )
      and VentilationInterval starts after end of LatestAnesthesiaInterval
      and OxygenSupport.interval ( ) starts during Interval[end of LatestAnesthesiaInterval, start of VentilationInterval]
      and EncounterWithSurgery.isNotAtProceduralHospitalLocationDuring ( VentilationInterval )
    return EncounterWithSurgery
//fix


// Numerator - clause 3



define "Encounter with Extubation Outside of Procedural Area within 30 Days of End of First OR Procedure More Than 48 Hours After End of Anesthesia":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Removal of endotracheal tube (procedure)"] Extubation
    let ExtubationInterval: Extubation.interval ( ),
    LatestAnesthesiaInterval: "LatestGeneralAnesthesiaOrMAC"(Extubation).interval ( )
    where Extubation.isDuringHospitalization ( EncounterWithSurgery )
      and Extubation.starts30DaysOrLessAfterFirstProcedure ( EncounterWithSurgery )
      and ExtubationInterval starts more than 48 hours after end of LatestAnesthesiaInterval
      and not ( ( "Extubation with Preceding Noninvasive Oxygen".id contains Extubation.id )
          and not ( "Extubation During General Anesthesia".id contains Extubation.id )
      )
      and EncounterWithSurgery.isNotAtProceduralHospitalLocation ( )
    return EncounterWithSurgery

 
// Numerator - clause 4


define "Encounter with Mechanical Ventilation within 30 Days of End of First OR Procedure and Between 48 and 72 Hours After End of OR Procedure and not Preceded by Non Invasive Oxygen Therapy or Anesthesia":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Mechanical Ventilation"] Ventilation
    let VentilationInterval: Ventilation.interval ( ),
    LatestAnesthesiaInterval: "LatestGeneralAnesthesiaOrMAC"(Ventilation).interval ( )
    where VentilationInterval starts 48 hours or more after end of LatestAnesthesiaInterval
      and VentilationInterval starts 72 hours or less after end of LatestAnesthesiaInterval
      and Ventilation.starts30DaysOrLessAfterFirstProcedure ( EncounterWithSurgery )
      and Ventilation.startsDuringHospitalization ( EncounterWithSurgery )
      and not ( "Encounter with Mechanical Ventilation Outside of Procedural Area within 30 Days of End of First OR Procedure and Preceded by Non Invasive Oxygen Therapy".id contains EncounterWithSurgery.id )
      and EncounterWithSurgery.isNotAtProceduralHospitalLocation ( )
    return EncounterWithSurgery

//----------------------  Supporting definitions for Measure Population Definitions --------------------------------------------------//

// Note: defines that are not referenced elsewhere are at the bottom of this file.

// Supports:  Initial Population clause 1




define "Elective Inpatient Encounter with Age 18 and Older without ED Visit":
  ["Encounter": "Elective Inpatient Encounter"] ElectiveEncounter
    where ElectiveEncounter.period ends during day of "Measurement Period"
      and ElectiveEncounter.priority ~ "Elective (qualifier value)"
      and AgeInYearsAt(date from start of ElectiveEncounter.period) >= 18
      and not exists ( ["Encounter": "Emergency Department Visit"] EDVisit
          where EDVisit.period ends 1 hour or less before or on start of ElectiveEncounter.period
      )

// Supports:  Initial Population clause 1


define "Elective Inpatient Encounter with Age and without Obstetrical Condition":
  "Elective Inpatient Encounter with Age 18 and Older without ED Visit" ElectiveEncounter
    where not exists ElectiveEncounter.diagnosis EncounterDiagnoses
      where EncounterDiagnoses.condition.getCondition ( ).code in "Obstetrical or Pregnancy Related Conditions"

// Supports:  denominator exclusions clause 10


define "Encounter with Tracheostomy Before Day of First OR Procedure":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    let FirstProcedure: FirstAnesthesiaDuringHospitalization(EncounterWithSurgery)
    with ["Procedure": "Tracheostomy Procedures"] TracheostomySurgery
      such that TracheostomySurgery.startsDuringHospitalization ( EncounterWithSurgery )
        and TracheostomySurgery.interval ( ) starts before day of FirstProcedure.interval ( )
        and FirstProcedure is not null 

// Supports:  denominator exclusions clause 10


define "Encounter with Tracheostomy Same Day of First OR Procedure":
  "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery
    let FirstProcedure: FirstAnesthesiaDuringHospitalization(EncounterWithSurgery)
    with ["Procedure": "Tracheostomy Procedures"] TracheostomySurgery
      such that TracheostomySurgery.startsDuringHospitalization ( EncounterWithSurgery )
        and TracheostomySurgery.interval ( ) starts during day of FirstProcedure.interval ( )
        and FirstProcedure is not null

// Referenced in numerator supporting clauses


define "General Anesthesia and MAC":
  ["Procedure": "Anesthesia Requiring Monitored Care"] MAC
    union ["Procedure": "General and Neuraxial Anesthesia"] GA

// Referenced in numerator supporting clauses


define "Noninvasive Oxygen Therapy":
  ["Procedure": "Non Invasive Oxygen Therapy by Nasal Cannula or Mask"]
    union ["Observation": "Non Invasive Oxygen Therapy"] 


// Supports:  numerator clause 1


define "Intubation During General Anesthesia and MAC":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Intubation"] ProceduralIntubation,
    "General Anesthesia and MAC" ProcedureWithAnesthesia
    where ProceduralIntubation.startsDuringAnesthesia ( ProcedureWithAnesthesia, EncounterWithSurgery )
    return ProceduralIntubation

// Supports:  numerator clause 3


define "Extubation During General Anesthesia":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Removal of endotracheal tube (procedure)"] Extubation,
    "General Anesthesia and MAC" Anesthesia
    where Extubation.startsDuringAnesthesia ( Anesthesia, EncounterWithSurgery )
    return Extubation

// Supports:  numerator clause 3


define "Extubation with Preceding Noninvasive Oxygen":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Removal of endotracheal tube (procedure)"] Extubation,
    "Noninvasive Oxygen Therapy" OxygenSupport
    let LatestAnesthesia: "LatestGeneralAnesthesiaOrMAC"(Extubation)
    where Extubation.startsDuringHospitalization ( EncounterWithSurgery )
      and Extubation.startsAfterAnesthesia ( LatestAnesthesia, EncounterWithSurgery )
      and OxygenSupport.interval ( ) starts during Interval[end of LatestAnesthesia.interval ( ), start of Extubation.interval ( )]
    return Extubation


//----------------------  Risk Variable Definitions ----------------------------------------------------//


define "Risk Variable All Encounter Diagnoses with POA Indication":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      diagnosis: QualifyingEncounter.diagnosis.condition,
      POA: QualifyingEncounter.diagnosisPresentOnAdmission ( )
    }

define "Risk Variable ASA Physical Status Class":
  from
    ["Observation": "American society of anesthesiologists morbidity state"] ASAclass
    with "Initial Population" QualifyingEncounter
      such that ASAclass.startsDuringHospitalization ( QualifyingEncounter )
        and ASAclass.value is not null
        and ASAclass.value as Concept in "ASA physical status class"
    return ASAclass.value

define "Risk Variable Body Mass Index (BMI)":
  from
    ["Observation": "Body mass index (BMI) [Ratio]"] BMI
    with "Initial Population" QualifyingEncounter
      such that BMI.startsDuringHospitalization ( QualifyingEncounter )
        and BMI.value is not null
    return ( BMI.value as Quantity ).value
//how to define rank??


define "Risk Variable Encounter Procedures":
  from
    ["Procedure"] Procedure,
    "Initial Population" QualifyingEncounter
    where Procedure.startsDuringHospitalization ( QualifyingEncounter )
    return {
      encounterId: QualifyingEncounter.id,
      procedureId: Procedure.id,
      procedurecode: Procedure.code,
      procedurerank: QualifyingEncounter.procedureRank ( ),
      proceduretime: Procedure.interval ( )
    }

define "Risk Variable First Albumin in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstAlbumin: "FirstAlbumin"(QualifyingEncounter)
    }

define "Risk Variable First Arterial pH in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstArterialpH: "FirstArterialpH"(QualifyingEncounter)
    }

define "Risk Variable First AST in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstAST: "FirstAST"(QualifyingEncounter)
    }

define "Risk Variable First Bicarbonate in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBicarbonate: "FirstBicarbonate"(QualifyingEncounter)
    }

define "Risk Variable First Bilirubin in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBilirubin: "FirstBilirubin"(QualifyingEncounter)
    }

define "Risk Variable First Blood Urea Nitrogen in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBUN: "FirstBloodUreaNitrogen"(QualifyingEncounter)
    }

define "Risk Variable First BMI":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBMI: "FirstBMI"(QualifyingEncounter)
    }

define "Risk Variable First Body Temperature in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBodyTemp: "FirstBodyTemperature"(QualifyingEncounter)
    }

define "Risk Variable First Carbon Dioxide in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstCarbonDioxide: "FirstCarbonDioxide"(QualifyingEncounter)
    }

define "Risk Variable First Creatinine in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstCreatinine: "FirstCreatinine"(QualifyingEncounter)
    }

define "Risk Variable First Heart Rate in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHeartRate: "FirstHeartRate"(QualifyingEncounter)
    }

define "Risk Variable First Hematocrit in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHematocrit: "FirstHematocrit"(QualifyingEncounter)
    }

define "Risk Variable First Hemoglobin in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHemoglobin: "FirstHemoglobin"(QualifyingEncounter)
    }

define "Risk Variable First Leukocyte Count in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstLeukocyte: "FirstLeukocyte"(QualifyingEncounter)
    }

define "Risk Variable First Oxygen in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstOxygen: "FirstOxygen"(QualifyingEncounter)
    }

define "Risk Variable First Platelet Count in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstPlatelet: "FirstPlatelet"(QualifyingEncounter)
    }

define "Risk Variable First Respiratory Rate in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstRespiratoryRate: "FirstRespiratoryRate"(QualifyingEncounter)
    }

define "Risk Variable First Sodium in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstSodium: "FirstSodium"(QualifyingEncounter)
    }

define "Risk Variable First Systolic Blood Pressure in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstSystolic: "FirstSystolicBloodPressure"(QualifyingEncounter)
    }

define "Risk Variable First White Blood Cell Count in Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstWBCcount: "FirstWhiteBloodCellCount"(QualifyingEncounter)
    }

define "Risk Variable Smoking Status":
  Last(["Observation": "Tobacco smoking status"] SmokingStatus
      with "Initial Population" QualifyingEncounter
        such that(SmokingStatus.effective.latest() during QualifyingEncounter.hospitalizationInterval()
            or SmokingStatus.effective.latest() before QualifyingEncounter.hospitalizationInterval()
              and SmokingStatus.value is not null
              and SmokingStatus.value as Concept in "Smoking status"
        )
      sort by effective.latest()
  ).value

//----------------------  End Risk Variables --------------------------------------------//

//----------------------  Supplemental Data Elements ------------------------------------//



define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

//---------------------- Risk Variable Accessory Functions ------------------------------//


define function "FirstAlbumin"(QualifyingEncounter Encounter):
  First([Observation: "Albumin lab test"] FirstAlbuminTest
      where FirstAlbuminTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstArterialpH"(QualifyingEncounter Encounter):
  First([Observation: "Arterial Blood pH"] FirstArterialpHTest
      where FirstArterialpHTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstAST"(QualifyingEncounter Encounter):
  First([Observation: "Aspartate transaminase lab test"] FirstASTTest
      where FirstASTTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstBicarbonate"(QualifyingEncounter Encounter):
  First([Observation: "Bicarbonate lab test"] FirstBicarbonateTest
      where FirstBicarbonateTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstBilirubin"(QualifyingEncounter Encounter):
  First([Observation: "Bilirubin lab test"] FirstBilirubinTest
      where FirstBilirubinTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstBMI"(QualifyingEncounter Encounter):
  First([Observation: "Body mass index (BMI) [Ratio]"] FirstBodyMass
      where FirstBodyMass.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstBodyTemperature"(QualifyingEncounter Encounter):
  First([Observation: "Body temperature"] FirstTemperature
      where FirstTemperature.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstCarbonDioxide"(QualifyingEncounter Encounter):
  First([Observation: "Carbon Dioxide Partial Pressure in Arterial Blood"] FirstCarbonDioxideTest
      where FirstCarbonDioxideTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstCreatinine"(QualifyingEncounter Encounter):
  First([Observation: "Creatinine lab test"] FirstCreatinineTest
      where FirstCreatinineTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstHeartRate"(QualifyingEncounter Encounter):
  First([Observation: "Heart rate"] FirstHeartBeats
      where FirstHeartBeats.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstHematocrit"(QualifyingEncounter Encounter):
  First([Observation: "Hematocrit lab test"] FirstHematocritTest
      where FirstHematocritTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstHemoglobin"(QualifyingEncounter Encounter):
  First([Observation: "Hemoglobin lab test"] FirstHemoglobinTest
      where FirstHemoglobinTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstLeukocyte"(QualifyingEncounter Encounter):
  First([Observation: "Leukocyte count lab test"] FirstLeukocyteCount
      where FirstLeukocyteCount.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstOxygen"(QualifyingEncounter Encounter):
  First([Observation: "Oxygen Partial Pressure in Arterial Blood"] FirstOxygenTest
      where FirstOxygenTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstPlatelet"(QualifyingEncounter Encounter):
  First([Observation: "Platelet count lab test"] FirstPlateletCount
      where FirstPlateletCount.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstRespiratoryRate"(QualifyingEncounter Encounter):
  First([Observation: "Respiratory rate"] FirstRespiration
      where FirstRespiration.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstSodium"(QualifyingEncounter Encounter):
  First([Observation: "Sodium lab test"] FirstSodiumTest
      where FirstSodiumTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstSystolicBloodPressure"(QualifyingEncounter Encounter):
  First([Observation: "Systolic blood pressure"] FirstSystolic
      where FirstSystolic.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "FirstWhiteBloodCellCount"(QualifyingEncounter Encounter):
  First([Observation: "White blood cells count lab test"] FirstWBCCount
      where FirstWBCCount.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define function "GeneralAnesthesiaByTime"(QualifyingEncounter Encounter):
  [Procedure: "General and Neuraxial Anesthesia"] Anesthesia
    where Anesthesia.isEarliestDuringHospitalization ( QualifyingEncounter )
    sort by performed.earliest ( )

define function "MechanicalVentilationByTime"(QualifyingEncounter Encounter):
  [Procedure: "Mechanical Ventilation"] Vent
    where Vent.isEarliestDuringHospitalization ( QualifyingEncounter )
    sort by performed.earliest ( )

define function "NoninvasiveOxygenTherapyByTime"(QualifyingEncounter Encounter):
  "Noninvasive Oxygen Therapy" Oxygen
    where Oxygen.isEarliestDuringHospitalization ( QualifyingEncounter )
    sort by performed.earliest ( )

define function "FirstBloodUreaNitrogen"(QualifyingEncounter Encounter):
  First([Observation: "Blood urea nitrogen lab test"] FirstBUN
      where FirstBUN.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

  
//----------------------  End Risk Variable Accessory Functions -----------------------------//

//---------------------- Utility Functions --------------------------------------------------//

// Used exclusively in "FirstProcedure" function, below




define "Anesthesia Procedure List":
  ["Procedure": "General and Neuraxial Anesthesia"] AnesthesiaProcedures
    where AnesthesiaProcedures.performed.latest ( ) during day of "Measurement Period"

// Returns the first anesthesia procedure that starts during the hospitalization encounter.


define function "FirstAnesthesiaDuringHospitalization"(QualifyingEncounter Encounter):
  First("Anesthesia Procedure List" anesthesia
      where anesthesia.startsDuringHospitalization(QualifyingEncounter)
      sort by start of performed
  )

define function "LatestGeneralAnesthesiaOrMAC"(event Procedure):
  Last("General Anesthesia and MAC" ProcedureList
      where ProcedureList.interval() ends before start of event.interval()
      sort by start of QICoreCommon.ToInterval(performed)
  )


//----------------------  Fluent Functions --------------------------------------------------//

/*

Note: The following fluent functions are defined in the HospitalHarm library:

  diagnosisPresentOnAdmission(encounter)
  procedureRank(encounter)
  isDuringHospitalization(encounter)
  startsDuringHospitalization(encounter)
  interval()

*/



define fluent function "starts 30 days or less after first procedure"(procedure Procedure, EncounterWithSurgery Encounter):
  procedure.interval ( ) starts 30 days or less after end of FirstAnesthesiaDuringHospitalization(EncounterWithSurgery).interval ( )
    and procedure.startsDuringHospitalization ( EncounterWithSurgery )

define fluent function starts30DaysOrLessAfterFirstProcedure(procedure Procedure, encounter Encounter):
  procedure.interval ( ) starts 30 days or less after end of FirstAnesthesiaDuringHospitalization(encounter).interval ( ) 
     // and procedure.startsDuringHospitalization(EncounterWithSurgery)


define fluent function startsDuringAnesthesia(procedure Procedure, anesthesia Procedure, encounterWithSurgery Encounter):
  procedure.interval ( ) starts during anesthesia.interval ( )
    and procedure.startsDuringHospitalization ( encounterWithSurgery )

define fluent function startsAfterAnesthesia(procedure Procedure, anesthesia Procedure, encounterWithSurgery Encounter):
  procedure.interval ( ) starts after anesthesia.interval ( )
    and procedure.startsDuringHospitalization ( encounterWithSurgery )

define fluent function isNotAtProceduralHospitalLocation(encounter Encounter):
  ( not exists ( encounter.location EncounterLocation
        where EncounterLocation.location.type in "Procedural Hospital Locations"
    )
  )

define fluent function isNotAtProceduralHospitalLocationDuring(encounter Encounter, intrvl Interval<DateTime>):
  ( not exists ( encounter.location EncounterLocation
        where EncounterLocation.location.type in "Procedural Hospital Locations"
          and EncounterLocation.period starts during intrvl
    )
  )

define fluent function earliestOccursDuringHospitalization(observation Observation, encounter Encounter):
  observation.effective.earliest ( ) during encounter.hospitalizationInterval ( )
    and observation.value is not null

define fluent function earliestIsDuringHospitalization(procedure Procedure, encounter Encounter):
  procedure.performed.earliest ( ) during encounter.hospitalizationInterval ( )
    and procedure.partOf is not null

// The following is used as a wrapper to the above "earliest" functions to handle the case where the choice is a Procedure or an Observation 


define fluent function isEarliestDuringHospitalization(choice Choice<Procedure, Observation>, encounter Encounter):
  case
    when choice is Procedure then ( choice as Procedure ).earliestIsDuringHospitalization ( encounter )
    when choice is Observation then ( choice as Observation ).earliestOccursDuringHospitalization ( encounter ) 
    else false end

define fluent function hospitalizationInterval(enc Encounter):
  enc.hospitalizationWithObservationAndOutpatientSurgeryService ( )


//---------------------- End  Fluent Functions --------------------------------------------------------//

//----------------------  Unreferenced Definitions ----------------------------------------------------//

/*
// Not referenced
define "General Anesthesia":
  ["Procedure": "General and Neuraxial Anesthesia"] SurgeryWithAnesthesia
    with "Elective Inpatient Encounter with OR Procedure within 3 Days" QualifyingEncounter
      such that SurgeryWithAnesthesia.isDuringHospitalization ( QualifyingEncounter )
    sort by performed.earliest ( )

// Not referenced
define "Anesthesia Exclusion":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Mechanical Ventilation"] Ventilation,
    ["Procedure": "Anesthesia Requiring Monitored Care"] ProcedureWithAnesthesia,
    "Noninvasive Oxygen Therapy" OxygenSupport
    where  Ventilation.starts30DaysOrLessAfterFirstProcedure(EncounterWithSurgery)
      and OxygenSupport.interval() starts during Interval[end of ProcedureWithAnesthesia.interval(), start of Ventilation.interval()]
      and OxygenSupport.isDuringHospitalization(EncounterWithSurgery)
      and ProcedureWithAnesthesia.interval() starts during Interval[start of OxygenSupport.interval(), start of Ventilation.interval()]

    return Tuple {
      O2: start of OxygenSupport.interval(),
      MV: start of Ventilation.interval(),
      excludeInt: Interval[start of OxygenSupport.interval(), start of Ventilation.interval()],
      Anesthesia: ProcedureWithAnesthesia.interval(),
      id: ProcedureWithAnesthesia.id
    }

// Not referenced
define "Encounter with Oxygen Therapy Interrupting Extubation":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Removal of endotracheal tube (procedure)"] AirwayTubeOut,
    ["Procedure": "General and Neuraxial Anesthesia"] ProcedureWithAnesthesia,
    "Noninvasive Oxygen Therapy" Oxygen
    where Oxygen.startsDuringHospitalization( EncounterWithSurgery )
      and AirwayTubeOut.interval() starts during "AIR.HospitalizationWithObservationAndOutpatientSurgeryService"(EncounterWithSurgery)
      and ProcedureWithAnesthesia.startsDuringHospitalization(EncounterWithSurgery )
      and Oxygen.interval() starts during Interval[end of ProcedureWithAnesthesia.interval(), end of AirwayTubeOut.interval()]
    return EncounterWithSurgery

// Only used in "Encounter with Oxygen Therapy Interrupting Extubation" define, which is not referenced.
define function "AIR.HospitalizationWithObservationAndOutpatientSurgeryService"(encounter "Encounter"):
  encounter Visit
    let 
      ObservationVisit: Last([Encounter: "Observation Services"] LastObservation
                              where LastObservation.period ends 1 hour or less on or before start of Visit.period
                              sort by 
                              end of period
                          ),
      VisitStart: Coalesce(start of ObservationVisit.period, start of Visit.period),
      OutpatientSurgeryVisit: Last([Encounter: "Outpatient Surgery Service"] LastSurgeryOutpatient
                                    where LastSurgeryOutpatient.period ends 1 hour or less on or before VisitStart
                                    sort by 
                                    end of period
                                )
    return Interval[Coalesce(start of OutpatientSurgeryVisit.period, VisitStart), end of Visit.period]


// Not referenced
define "Encounter with Oxygen Therapy Interrupting Mechanical Ventilation":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Mechanical Ventilation"] Ventilation,
    ["Procedure": "General and Neuraxial Anesthesia"] ProcedureWithAnesthesia,
    "Noninvasive Oxygen Therapy" Oxygen
    where Oxygen.startsDuringHospitalization( EncounterWithSurgery )
      and Ventilation.startsDuringHospitalization( EncounterWithSurgery )
      and ProcedureWithAnesthesia.startsDuringHospitalization( EncounterWithSurgery )
      and Oxygen.interval() starts during Interval[end of ProcedureWithAnesthesia.interval(), end of Ventilation.interval()]
    return EncounterWithSurgery

// Not referenced
define "Mechanical Ventilation with Preceding Noninvasive Oxygen":
  from
    "Elective Inpatient Encounter with OR Procedure within 3 Days" EncounterWithSurgery,
    ["Procedure": "Mechanical Ventilation"] Ventilation,
    "Noninvasive Oxygen Therapy" OxygenSupport
    let
     LatestAnesthesia: "LatestGeneralAnesthesiaOrMAC"(Ventilation)
    where Ventilation.startsDuringHospitalization(EncounterWithSurgery)
      and Ventilation.startsAfterAnesthesia(LatestAnesthesia, EncounterWithSurgery)
      and OxygenSupport.interval() starts during Interval[end of LatestAnesthesia.interval(), start of Ventilation.interval()]
    return Ventilation

*/


