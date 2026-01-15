library CMS1218FHIRHHRF version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "LocationRoles": 'http://terminology.hl7.org/CodeSystem/v3-RoleCode'

valueset "Acute Respiratory Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.88'
valueset "Albumin Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.221'
valueset "Anesthesia Requiring Monitored Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.255'
valueset "Arterial Blood pH": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.96'
valueset "ASA Physical Status Class": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.217'
valueset "Aspartate transaminase Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.224'
valueset "Bicarbonate Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139'
valueset "Bilirubin Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.223'
valueset "Blood Urea Nitrogen Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.218'
valueset "Carbon Dioxide Partial Pressure In Arterial Blood": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.95'
valueset "Creatinine Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363'
valueset "Degenerative Neurological Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.241'
valueset "Elective Inpatient Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.85'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "General And Neuraxial Anesthesia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.208'
valueset "Head, Neck, And Thoracic Surgeries With High Risk Airway Compromise": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.251'
valueset "Hematocrit Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114'
valueset "Hemoglobin Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.219'
valueset "Intubation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.179'
valueset "Leukocyte Count Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.222'
valueset "Mechanical Ventilation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.107'
valueset "Neuromuscular Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.239'
valueset "Non Invasive Oxygen Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.213'
valueset "Non Invasive Oxygen Therapy By Nasal Cannula Or Mask": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209'
valueset "Obstetrical Or Pregnancy Related Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263'
valueset "Oxygen Partial Pressure In Arterial Blood": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.94'
valueset "Platelet Count Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127'
valueset "Present On Admission Or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'
valueset "Procedural Hospital Locations": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.216'
valueset "Smoking Status": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.220'
valueset "Sodium Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119'
valueset "Tracheostomy Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.89'
valueset "Tracheostomy Procedures": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.181'
valueset "White Blood Cells Count Lab Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129'

code "American society of anesthesiologists morbidity state": '97816-3' from "LOINC" display 'American society of anesthesiologists morbidity state'
code "Body temperature": '8310-5' from "LOINC" display 'Body temperature'
code "Elective (qualifier value)": '103390000' from "SNOMEDCT" display 'Elective (qualifier value)'
code "Heart rate": '8867-4' from "LOINC" display 'Heart rate'
code "Removal of endotracheal tube (procedure)": '271280005' from "SNOMEDCT" display 'Removal of endotracheal tube (procedure)'
code "Respiratory rate": '9279-1' from "LOINC" display 'Respiratory rate'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic blood pressure'
code "ER": 'ER' from "LocationRoles" display 'Emergency room'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounter With Degenerative Neurological Disorder"
    union "Encounter With High Risk To Airway Head Neck And Thoracic Surgery"
    union "Encounter With Mechanical Ventilation That Starts More Than One Hour Prior To Start Of First OR Procedure"
    union "Encounter With Neuromuscular Disorder"
    union "Encounter With PaCO2 Greater Than 50 And Arterial pH Less Than 7.30 Within 48 Hours Prior To Start Of First OR Procedure"
    union "Encounter With PaO2 Less Than 50 Within 48 Hours Prior To Start Of First OR Procedure"
    union "Encounter With Principal Diagnosis Of Acute Respiratory Failure"
    union "Encounter With Diagnosis Of Acute Respiratory Failure Present On Admission"
    union "Encounter With Tracheostomy Present On Admission"
    union "Encounter With Tracheostomy Prior To Or On The Same Day Of First OR Procedure"

define "Numerator":
  "Encounter With Intubation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure"
    union "Encounter With Mechanical Ventilation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure And Preceded By Non Invasive Oxygen Therapy"
    union "Encounter With Extubation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure More Than 48 Hours After End Of Anesthesia"
    union "Encounter With Mechanical Ventilation Within 30 Days Of End Of First OR Procedure And Between 48 And 72 Hours After End Of OR Procedure And Not Preceded By Non Invasive Oxygen Therapy Or Anesthesia"

define "Elective Inpatient Encounter With OR Procedure Within 3 Days":
  "Elective Inpatient Encounter With Age And Without Obstetrical Condition" ElectiveEncounter
    with ["Procedure": "General And Neuraxial Anesthesia"] SurgeryWithAnesthesia
      such that SurgeryWithAnesthesia.status = 'completed'
        and SurgeryWithAnesthesia.performed.earliest ( ) during ElectiveEncounter.hospitalizationWithObservationAndOutpatientSurgeryService ( )
        and SurgeryWithAnesthesia.performed.earliest ( ) 3 days or less after start of ElectiveEncounter.hospitalizationWithObservationAndOutpatientSurgeryService ( )

define "Encounter With Degenerative Neurological Disorder":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    where EncounterWithSurgery.reasonCode in "Degenerative Neurological Disorder"
      or EncounterWithSurgery.encounterReason ( ).code in "Degenerative Neurological Disorder"

define "Encounter With High Risk To Airway Head Neck And Thoracic Surgery":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    with ["Procedure": "Head, Neck, And Thoracic Surgeries With High Risk Airway Compromise"] HeadNeckProcedures
      such that HeadNeckProcedures.status = 'completed'
        and HeadNeckProcedures.startsDuringHospitalization ( EncounterWithSurgery )

define "Encounter With Mechanical Ventilation That Starts More Than One Hour Prior To Start Of First OR Procedure":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    with ["Procedure": "Mechanical Ventilation"] Ventilation
      such that Ventilation.status = 'completed'
        and Ventilation.performed.toInterval ( ) starts more than 1 hour before start of EncounterWithSurgery.firstAnesthesiaDuringHospitalization ( ).performed.toInterval ( )
        and Ventilation.startsDuringHospitalization ( EncounterWithSurgery )

define "Encounter With Neuromuscular Disorder":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    where EncounterWithSurgery.reasonCode in "Neuromuscular Disorder"
      or EncounterWithSurgery.encounterReason ( ).code in "Neuromuscular Disorder"

define "Encounter With PaCO2 Greater Than 50 And Arterial pH Less Than 7.30 Within 48 Hours Prior To Start Of First OR Procedure":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    let FirstProcedureTime: EncounterWithSurgery.firstAnesthesiaDuringHospitalization ( ).performed.toInterval ( )
    with ["LaboratoryResultObservation": "Carbon Dioxide Partial Pressure In Arterial Blood"] CarbonDioxide
      such that CarbonDioxide.status in { 'final', 'amended', 'corrected' }
        and CarbonDioxide.effective.toInterval ( ) starts 48 hours or less before start of FirstProcedureTime
        and CarbonDioxide.value as Quantity > 50 'mm[Hg]'
    with ["LaboratoryResultObservation": "Arterial Blood pH"] BloodpH
      such that BloodpH.status in { 'final', 'amended', 'corrected' }
        and BloodpH.effective.toInterval ( ) starts 48 hours or less before start of FirstProcedureTime
        and BloodpH.value as Quantity < 7.30 '[pH]'

define "Encounter With PaO2 Less Than 50 Within 48 Hours Prior To Start Of First OR Procedure":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    let FirstProcedure: EncounterWithSurgery.firstAnesthesiaDuringHospitalization ( )
    with ["LaboratoryResultObservation": "Oxygen Partial Pressure In Arterial Blood"] Oxygen
      such that Oxygen.status in { 'final', 'amended', 'corrected' }
        and Oxygen.effective.toInterval ( ) starts 48 hours or less before start of FirstProcedure.performed.toInterval ( )
        and Oxygen.value as Quantity < 50 'mm[Hg]'

define "Encounter With Principal Diagnosis Of Acute Respiratory Failure":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    where EncounterWithSurgery.hasPrincipalDiagnosisOf ( "Acute Respiratory Failure" )

define "Encounter With Diagnosis Of Acute Respiratory Failure Present On Admission":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    where EncounterWithSurgery.isDiagnosisPresentOnAdmission ( "Acute Respiratory Failure", "Present On Admission Or Clinically Undetermined" )

define "Encounter With Tracheostomy Present On Admission":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    where EncounterWithSurgery.isDiagnosisPresentOnAdmission ( "Tracheostomy Diagnoses", "Present On Admission Or Clinically Undetermined" )

define "Encounter With Tracheostomy Prior To Or On The Same Day Of First OR Procedure":
  "Encounter With Tracheostomy Before Day Of First OR Procedure"
    union "Encounter With Tracheostomy Same Day Of First OR Procedure"

define "Encounter With Intubation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    with ["Procedure": "Intubation"] EndotrachealTubeIn
      such that EndotrachealTubeIn.status = 'completed'
        and EndotrachealTubeIn.starts30DaysOrLessAfterFirstAnesthesia ( EncounterWithSurgery )
        and EndotrachealTubeIn.startsDuringHospitalization ( EncounterWithSurgery )
        and EndotrachealTubeIn.performed.toInterval ( ) starts after end of EndotrachealTubeIn.latestGeneralAnesthesiaOrMAC ( ).performed.toInterval ( )
        and EncounterWithSurgery.isNotAtProceduralHospitalLocationDuring ( EndotrachealTubeIn.performed.toInterval ( ) )
        and not ( "Intubation During General Anesthesia And MAC".id contains EndotrachealTubeIn.id )

define "Encounter With Mechanical Ventilation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure And Preceded By Non Invasive Oxygen Therapy":
  from
    "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery,
    ["Procedure": "Mechanical Ventilation"] Ventilation,
    "Noninvasive Oxygen Therapy" OxygenSupport
    let VentilationInterval: Ventilation.performed.toInterval ( ),
    LatestAnesthesiaInterval: Ventilation.latestGeneralAnesthesiaOrMAC ( ).performed.toInterval ( )
    where Ventilation.status = 'completed'
      and Ventilation.starts30DaysOrLessAfterFirstAnesthesia ( EncounterWithSurgery )
      and Ventilation.startsDuringHospitalization ( EncounterWithSurgery )
      and VentilationInterval starts after end of LatestAnesthesiaInterval
      and OxygenSupport.interval ( ) starts during Interval[end of LatestAnesthesiaInterval, start of VentilationInterval]
      and EncounterWithSurgery.isNotAtProceduralHospitalLocationDuring ( VentilationInterval )
    return EncounterWithSurgery

define "Encounter With Extubation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure More Than 48 Hours After End Of Anesthesia":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    with ["Procedure": "Removal of endotracheal tube (procedure)"] Extubation
      such that Extubation.status = 'completed'
        and Extubation.isDuringHospitalization ( EncounterWithSurgery )
        and Extubation.starts30DaysOrLessAfterFirstAnesthesia ( EncounterWithSurgery )
        and Extubation.performed.toInterval ( ) starts more than 48 hours after end of Extubation.latestGeneralAnesthesiaOrMAC ( ).performed.toInterval ( )
        and not ( ( "Extubation With Preceding Noninvasive Oxygen".id contains Extubation.id )
            and not ( "Extubation During General Anesthesia".id contains Extubation.id )
        )
        and EncounterWithSurgery.isNotAtProceduralHospitalLocation ( )

define "Encounter With Mechanical Ventilation Within 30 Days Of End Of First OR Procedure And Between 48 And 72 Hours After End Of OR Procedure And Not Preceded By Non Invasive Oxygen Therapy Or Anesthesia":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    with ["Procedure": "Mechanical Ventilation"] Ventilation
      such that Ventilation.status = 'completed'
        and Ventilation.performed.toInterval ( ) starts 48 hours or more after end of Ventilation.latestGeneralAnesthesiaOrMAC ( ).performed.toInterval ( )
        and Ventilation.performed.toInterval ( ) starts 72 hours or less after end of Ventilation.latestGeneralAnesthesiaOrMAC ( ).performed.toInterval ( )
        and Ventilation.starts30DaysOrLessAfterFirstAnesthesia ( EncounterWithSurgery )
        and Ventilation.startsDuringHospitalization ( EncounterWithSurgery )
        and not ( "Encounter With Mechanical Ventilation Outside Of Procedural Area Within 30 Days Of End Of First OR Procedure And Preceded By Non Invasive Oxygen Therapy".id contains EncounterWithSurgery.id )
        and EncounterWithSurgery.isNotAtProceduralHospitalLocation ( )

define "Elective Inpatient Encounter With Age 18 And Older Without ED Visit":
  ["Encounter": "Elective Inpatient Encounter"] ElectiveEncounter
    where ElectiveEncounter.status = 'finished'
      and ElectiveEncounter.period ends during day of "Measurement Period"
      and ElectiveEncounter.priority is not null implies ElectiveEncounter.priority ~ "Elective (qualifier value)"
      and AgeInYearsAt(date from start of ElectiveEncounter.period) >= 18
      and not exists ( ["Encounter": "Emergency Department Visit"] EDVisit
          where EDVisit.status = 'finished'
            and EDVisit.period ends 1 hour or less before or on start of ElectiveEncounter.period
      )

define "Elective Inpatient Encounter With Age And Without Obstetrical Condition":
  "Elective Inpatient Encounter With Age 18 And Older Without ED Visit" ElectiveEncounter
    where not ( ElectiveEncounter.reasonCode in "Obstetrical Or Pregnancy Related Conditions"
        or ElectiveEncounter.encounterReason ( ).code in "Obstetrical Or Pregnancy Related Conditions"
    )

define "Encounter With Tracheostomy Before Day Of First OR Procedure":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    let FirstProcedure: EncounterWithSurgery.firstAnesthesiaDuringHospitalization ( )
    with ["Procedure": "Tracheostomy Procedures"] TracheostomySurgery
      such that TracheostomySurgery.status = 'completed'
        and TracheostomySurgery.startsDuringHospitalization ( EncounterWithSurgery )
        and TracheostomySurgery.performed.toInterval ( ) starts before day of FirstProcedure.performed.toInterval ( )

define "Encounter With Tracheostomy Same Day Of First OR Procedure":
  "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery
    let FirstProcedure: EncounterWithSurgery.firstAnesthesiaDuringHospitalization ( )
    with ["Procedure": "Tracheostomy Procedures"] TracheostomySurgery
      such that TracheostomySurgery.status = 'completed'
        and TracheostomySurgery.startsDuringHospitalization ( EncounterWithSurgery )
        and TracheostomySurgery.performed.toInterval ( ) starts during day of FirstProcedure.performed.toInterval ( )

define "General Anesthesia And MAC":
  ["Procedure": "Anesthesia Requiring Monitored Care"] MAC
    union ["Procedure": "General And Neuraxial Anesthesia"]

define "Noninvasive Oxygen Therapy":
  ( ["Procedure": "Non Invasive Oxygen Therapy By Nasal Cannula Or Mask"] P
      where P.status = 'completed'
  )
    union ( ["LaboratoryResultObservation": "Non Invasive Oxygen Therapy"] O
        where O.status in { 'final', 'amended', 'corrected' }
    )

define "Intubation During General Anesthesia And MAC":
  from
    "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery,
    ["Procedure": "Intubation"] ProceduralIntubation,
    "General Anesthesia And MAC" Anesthesia
    where ProceduralIntubation.status = 'completed'
      and ProceduralIntubation.startsDuringHospitalization ( EncounterWithSurgery )
      and ProceduralIntubation.performed.toInterval ( ) starts during Anesthesia.performed.toInterval ( )
    return ProceduralIntubation

define "Extubation During General Anesthesia":
  from
    "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery,
    ["Procedure": "Removal of endotracheal tube (procedure)"] Extubation,
    "General Anesthesia And MAC" Anesthesia
    where Extubation.status = 'completed'
      and Extubation.startsDuringHospitalization ( EncounterWithSurgery )
      and Extubation.performed.toInterval ( ) starts during Anesthesia.performed.toInterval ( )
    return Extubation

define "Extubation With Preceding Noninvasive Oxygen":
  from
    "Elective Inpatient Encounter With OR Procedure Within 3 Days" EncounterWithSurgery,
    ["Procedure": "Removal of endotracheal tube (procedure)"] Extubation,
    "Noninvasive Oxygen Therapy" OxygenSupport
    let LatestAnesthesia: Extubation.latestGeneralAnesthesiaOrMAC ( )
    where Extubation.status = 'completed'
      and Extubation.startsDuringHospitalization ( EncounterWithSurgery )
      and Extubation.performed.toInterval ( ) starts after LatestAnesthesia.performed.toInterval ( )
      and OxygenSupport.interval ( ) starts during Interval[end of LatestAnesthesia.performed.toInterval ( ), start of Extubation.performed.toInterval ( )]
    return Extubation

define "Risk Variable All Encounter Diagnoses With POA Indication":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      diagnoses: QualifyingEncounter.claimDiagnosesWithPOA ( )
    }

define "Risk Variable ASA Physical Status Class":
  ["ObservationScreeningAssessment": "American society of anesthesiologists morbidity state"] ASAclass
    with "Initial Population" QualifyingEncounter
      such that ASAclass.status in { 'final', 'amended', 'corrected' }
        and ASAclass.startsDuringHospitalization ( QualifyingEncounter )
        and ASAclass.value as Concept in "ASA Physical Status Class"
    return ASAclass.value as Concept

define "Risk Variable Body Mass Index (BMI)":
  ["USCoreBMIProfile"] BMI
    with "Initial Population" InpatientEncounter
      such that BMI.effective.toInterval ( ) starts during InpatientEncounter.hospitalizationWithObservation ( )
        and BMI.value is not null
        and BMI.status in { 'final', 'amended', 'corrected' }
    return BMI.value as Quantity

define "Risk Variable Encounter Procedures":
  from
    ["Procedure"] TheProcedure,
    "Initial Population" QualifyingEncounter
    where TheProcedure.status = 'completed'
      and TheProcedure.startsDuringHospitalization ( QualifyingEncounter )
    return {
      encounterId: QualifyingEncounter.id,
      procedureId: TheProcedure.id,
      procedureCode: TheProcedure.code,
      procedureRank: TheProcedure.rank ( QualifyingEncounter ),
      procedureTime: TheProcedure.performed.toInterval ( )
    }

define "Risk Variable First Albumin In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstAlbumin: QualifyingEncounter.firstAlbumin ( )
    }

define "Risk Variable First Arterial pH In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstArterialpH: QualifyingEncounter.firstArterialpH ( )
    }

define "Risk Variable First AST In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstAST: QualifyingEncounter.firstAST ( )
    }

define "Risk Variable First Bicarbonate In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBicarbonate: QualifyingEncounter.firstBicarbonate ( )
    }

define "Risk Variable First Bilirubin In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBilirubin: QualifyingEncounter.firstBilirubin ( )
    }

define "Risk Variable First Blood Urea Nitrogen In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBUN: QualifyingEncounter.firstBloodUreaNitrogen ( )
    }

define "Risk Variable First BMI":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBMI: QualifyingEncounter.firstBMI ( )
    }

define "Risk Variable First Body Temperature In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstBodyTemp: QualifyingEncounter.firstBodyTemperature ( )
    }

define "Risk Variable First Carbon Dioxide In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstCarbonDioxide: QualifyingEncounter.firstCarbonDioxide ( )
    }

define "Risk Variable First Creatinine In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstCreatinine: QualifyingEncounter.firstCreatinine ( )
    }

define "Risk Variable First Heart Rate In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHeartRate: QualifyingEncounter.firstHeartRate ( )
    }

define "Risk Variable First Hematocrit In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHematocrit: QualifyingEncounter.firstHematocrit ( )
    }

define "Risk Variable First Hemoglobin In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHemoglobin: QualifyingEncounter.firstHemoglobin ( )
    }

define "Risk Variable First Leukocyte Count In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstLeukocyte: QualifyingEncounter.firstLeukocyte ( )
    }

define "Risk Variable First Oxygen In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstOxygen: QualifyingEncounter.firstOxygen ( )
    }

define "Risk Variable First Platelet Count In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstPlatelet: QualifyingEncounter.firstPlatelet ( )
    }

define "Risk Variable First Respiratory Rate In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstRespiratoryRate: QualifyingEncounter.firstRespiratoryRate ( )
    }

define "Risk Variable First Sodium In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstSodium: QualifyingEncounter.firstSodium ( )
    }

define "Risk Variable First Systolic Blood Pressure In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstSystolic: QualifyingEncounter.firstSystolicBloodPressure ( )
    }

define "Risk Variable First White Blood Cell Count In Encounter":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstWBCcount: QualifyingEncounter.firstWhiteBloodCellCount ( )
    }

define "Risk Variable Principal Procedure":
  from
    ["Procedure"] TheProcedure,
    "Initial Population" QualifyingEncounter
    where TheProcedure.status = 'completed'
      and TheProcedure.rank ( QualifyingEncounter ) is not null
      and TheProcedure.startsDuringHospitalization ( QualifyingEncounter )
    return Tuple {
      encounterId: QualifyingEncounter.id,
      procedureId: TheProcedure.id,
      procedureCode: TheProcedure.code,
      procedureRank: TheProcedure.rank ( QualifyingEncounter ),
      procedureTime: TheProcedure.performed.toInterval ( )
    }

define "Risk Variable Latest Smoking Status":
  "Initial Population" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      latestSmokingStatus: QualifyingEncounter.latestSmokingStatus ( )
    }

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define fluent function firstAlbumin(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Albumin Lab Test"] FirstAlbuminTest
      where FirstAlbuminTest.status in { 'final', 'amended', 'corrected' }
        and FirstAlbuminTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstArterialpH(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Arterial Blood pH"] FirstArterialpHTest
      where FirstArterialpHTest.status in { 'final', 'amended', 'corrected' }
        and FirstArterialpHTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstAST(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Aspartate transaminase Lab Test"] FirstASTTest
      where FirstASTTest.status in { 'final', 'amended', 'corrected' }
        and FirstASTTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstBicarbonate(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Bicarbonate Lab Test"] FirstBicarbonateTest
      where FirstBicarbonateTest.status in { 'final', 'amended', 'corrected' }
        and FirstBicarbonateTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstBilirubin(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Bilirubin Lab Test"] FirstBilirubinTest
      where FirstBilirubinTest.status in { 'final', 'amended', 'corrected' }
        and FirstBilirubinTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstBMI(QualifyingEncounter Encounter):
  First([USCoreBMIProfile] FirstBodyMass
      where FirstBodyMass.status in { 'final', 'amended', 'corrected' }
        and FirstBodyMass.effective.toInterval() starts during QualifyingEncounter.hospitalizationWithObservation()
        and FirstBodyMass.value is not null
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstBodyTemperature(QualifyingEncounter Encounter):
  First(["USCoreBodyTemperatureProfile": "Body temperature"] FirstTemperature
      where FirstTemperature.status in { 'final', 'amended', 'corrected' }
        and FirstTemperature.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstTemperature.value is not null
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstCarbonDioxide(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Carbon Dioxide Partial Pressure In Arterial Blood"] FirstCarbonDioxideTest
      where FirstCarbonDioxideTest.status in { 'final', 'amended', 'corrected' }
        and FirstCarbonDioxideTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstCreatinine(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Creatinine Lab Test"] FirstCreatinineTest
      where FirstCreatinineTest.status in { 'final', 'amended', 'corrected' }
        and FirstCreatinineTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstHeartRate(QualifyingEncounter Encounter):
  First(["USCoreHeartRateProfile": "Heart rate"] FirstHeartBeats
      where FirstHeartBeats.status in { 'final', 'amended', 'corrected' }
        and FirstHeartBeats.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstHeartBeats.value is not null
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstHematocrit(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Hematocrit Lab Test"] FirstHematocritTest
      where FirstHematocritTest.status in { 'final', 'amended', 'corrected' }
        and FirstHematocritTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstHemoglobin(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Hemoglobin Lab Test"] FirstHemoglobinTest
      where FirstHemoglobinTest.status in { 'final', 'amended', 'corrected' }
        and FirstHemoglobinTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstLeukocyte(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Leukocyte Count Lab Test"] FirstLeukocyteCount
      where FirstLeukocyteCount.status in { 'final', 'amended', 'corrected' }
        and FirstLeukocyteCount.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstOxygen(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Oxygen Partial Pressure In Arterial Blood"] FirstOxygenTest
      where FirstOxygenTest.status in { 'final', 'amended', 'corrected' }
        and FirstOxygenTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstPlatelet(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Platelet Count Lab Test"] FirstPlateletCount
      where FirstPlateletCount.status in { 'final', 'amended', 'corrected' }
        and FirstPlateletCount.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstRespiratoryRate(QualifyingEncounter Encounter):
  First([USCoreRespiratoryRateProfile: "Respiratory rate"] FirstRespiration
      where FirstRespiration.status in { 'final', 'amended', 'corrected' }
        and FirstRespiration.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstRespiration.value is not null
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstSodium(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Sodium Lab Test"] FirstSodiumTest
      where FirstSodiumTest.status in { 'final', 'amended', 'corrected' }
        and FirstSodiumTest.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define "Qualifying Systolic Blood Pressure Reading":
  ["USCoreBloodPressureProfile"] BloodPressure
    where BloodPressure.effective.earliest ( ) during day of "Measurement Period"

define fluent function "firstSystolicBloodPressure"(QualifyingEncounter Encounter):
  First("Qualifying Systolic Blood Pressure Reading" SBPReading
      where SBPReading.status in { 'final', 'amended', 'corrected' }
        and SBPReading.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
      return singleton from(SBPReading.component SBPComponent
          where SBPComponent.code ~ "Systolic blood pressure"
          return SBPComponent.value as Quantity
      )
  )

define fluent function firstWhiteBloodCellCount(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "White Blood Cells Count Lab Test"] FirstWBCCount
      where FirstWBCCount.status in { 'final', 'amended', 'corrected' }
        and FirstWBCCount.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define fluent function firstBloodUreaNitrogen(QualifyingEncounter Encounter):
  First([LaboratoryResultObservation: "Blood Urea Nitrogen Lab Test"] FirstBUN
      where FirstBUN.status in { 'final', 'amended', 'corrected' }
        and FirstBUN.isEarliestDuringHospitalization(QualifyingEncounter)
      sort by effective.earliest()
  ).value as Quantity

define "Anesthesia Procedure List":
  ["Procedure": "General And Neuraxial Anesthesia"] AnesthesiaProcedures
    where AnesthesiaProcedures.performed.latest ( ) during day of "Measurement Period"

define fluent function "firstAnesthesiaDuringHospitalization"(QualifyingEncounter Encounter):
  First("Anesthesia Procedure List" anesthesia
      where anesthesia.status = 'completed'
        and anesthesia.startsDuringHospitalization(QualifyingEncounter)
      sort by start of performed.toInterval()
  )

define fluent function latestGeneralAnesthesiaOrMAC(event Procedure):
  Last("General Anesthesia And MAC" ProcedureList
      where ProcedureList.status = 'completed'
        and ProcedureList.performed.toInterval() ends before start of event.performed.toInterval()
      sort by start of performed.toInterval()
  )

define fluent function latestSmokingStatus(QualifyingEncounter Encounter):
  First(["USCoreSmokingStatusProfile"] SMStatus
      let statusInterval: SMStatus.effective.latest().toInterval()
      where SMStatus.status in { 'final', 'amended', 'corrected' }
        and(statusInterval during QualifyingEncounter.hospitalizationWithObservationAndOutpatientSurgeryService()
            or statusInterval before QualifyingEncounter.hospitalizationWithObservationAndOutpatientSurgeryService()
        )
        and SMStatus.value as Concept in "Smoking Status"
  ).value as Concept

define fluent function startsDuringHospitalization(choice Choice<Procedure, LaboratoryResultObservation, ObservationScreeningAssessment>, enc Encounter):
  case
    when choice is Procedure then ( choice as Procedure ).performed.toInterval ( ) starts during enc.hospitalizationWithObservationAndOutpatientSurgeryService ( )
    when choice is LaboratoryResultObservation then ( choice as LaboratoryResultObservation ).effective.toInterval ( ) starts during enc.hospitalizationWithObservationAndOutpatientSurgeryService ( )
    when choice is ObservationScreeningAssessment then ( choice as ObservationScreeningAssessment ).effective.toInterval ( ) starts during enc.hospitalizationWithObservationAndOutpatientSurgeryService ( ) 
    else false end

define fluent function starts30DaysOrLessAfterFirstAnesthesia(procedure Procedure, encounter Encounter):
  procedure.performed.toInterval ( ) starts 30 days or less after end of encounter.firstAnesthesiaDuringHospitalization ( ).performed.toInterval ( )

define fluent function isNotAtProceduralHospitalLocation(encounter Encounter):
  not exists ( encounter.location EncounterLocation
      with [Location] Location
        such that EncounterLocation.location.references ( Location )
          and Location.type.includesCode ( "ER" )
  )

define fluent function isNotAtProceduralHospitalLocationDuring(encounter Encounter, intrvl Interval<DateTime>):
  not exists ( encounter.location EncounterLocation
      with [Location] Location
        such that EncounterLocation.location.references ( Location )
          and Location.type.includesCode ( "ER" )
          and EncounterLocation.period starts during intrvl
  )

define fluent function isDuringHospitalization(choice Choice<Procedure, LaboratoryResultObservation>, enc Encounter):
  case
    when choice is Procedure then ( choice as Procedure ).performed.toInterval ( ) during enc.hospitalizationWithObservationAndOutpatientSurgeryService ( )
    when choice is LaboratoryResultObservation then ( choice as LaboratoryResultObservation ).effective.toInterval ( ) during enc.hospitalizationWithObservationAndOutpatientSurgeryService ( ) 
    else false end

define fluent function earliestOccursDuringHospitalization(observation LaboratoryResultObservation, encounter Encounter):
  observation.effective.earliest ( ) during encounter.hospitalizationWithObservationAndOutpatientSurgeryService ( )
    and observation.value is not null

define fluent function earliestIsDuringHospitalization(procedure Procedure, encounter Encounter):
  procedure.performed.earliest ( ) during encounter.hospitalizationWithObservationAndOutpatientSurgeryService ( )
    and procedure.partOf is not null

define fluent function isEarliestDuringHospitalization(choice Choice<Procedure, LaboratoryResultObservation>, encounter Encounter):
  case
    when choice is Procedure then ( choice as Procedure ).earliestIsDuringHospitalization ( encounter )
    when choice is LaboratoryResultObservation then ( choice as LaboratoryResultObservation ).earliestOccursDuringHospitalization ( encounter ) 
    else false end

define fluent function interval(choice Choice<Procedure, LaboratoryResultObservation, Encounter>):
  case
    when choice is Procedure then ( choice as Procedure ).performed.toInterval ( )
    when choice is LaboratoryResultObservation then ( choice as LaboratoryResultObservation ).effective.toInterval ( )
    when choice is Encounter then ( choice as Encounter ).period.toInterval ( ) 
    else null as Interval<DateTime>end

define fluent function rank(targetProcedure Procedure, parentEncounter Encounter):
  singleton from ( targetProcedure P
      let claim: ( [Claim] C
          where C.status = 'active'
            and C.use = 'claim'
            and exists ( C.item I
                where I.encounter.references ( parentEncounter )
            )
      ),
      claimProc: ( claim.procedure proc
          where proc.procedure.references ( P )
      )
      return claimProc.sequence R
  )

define fluent function claimDiagnosesWithPOA(encounter Encounter):
  encounter E
    let claim: ( [Claim] C
        where C.status = 'active'
          and C.use = 'claim'
          and exists ( C.item I
              where I.encounter.references ( E )
          )
    ),
    claimItem: ( claim.item I
        where I.encounter.references ( E )
    )
    return claim.diagnosis D
      where D.sequence in claimItem.diagnosisSequence
        and D.onAdmission is not null

define fluent function encounterReason(Encounter Encounter):
  Encounter.reasonReference D
    return singleton from ( ( [ConditionEncounterDiagnosis] cA
        union [ConditionProblemsHealthConcerns] cB ) C
        where D.references ( C.id )
    )