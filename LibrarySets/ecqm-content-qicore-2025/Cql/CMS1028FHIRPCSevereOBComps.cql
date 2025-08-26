library CMS1028FHIRPCSevereOBComps version '0.3.000'

using QICore version '6.0.0'

include CQMCommon version '4.1.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include PCMaternal version '5.25.000' called PCMaternal
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

code "Heart rate": '8867-4' from "LOINC" display 'Heart rate'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic BP'

codesystem "Present On Admission Indicators": 'https://www.cms.gov/Medicare/Medicare-Fee-for-Service-Payment/HospitalAcqCond/Coding'

code "POA-Y": 'Y' from "Present On Admission Indicators"
code "POA-N": 'N' from "Present On Admission Indicators"
code "POA-W": 'W' from "Present On Admission Indicators"
code "POA-1": '1' from "Present On Admission Indicators"

valueset "20 to 42 Plus Weeks Gestation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67'
valueset "Acute Heart Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.233'
valueset "Acute Myocardial Infarction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.623'
valueset "Acute or Persistent Asthma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271'
valueset "Acute Renal Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.53'
valueset "Acute Respiratory Distress Syndrome": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.214'
valueset "Air and Thrombotic Embolism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.243'
valueset "Amniotic Fluid Embolism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.217'
valueset "Anemia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323'
valueset "Aortic Aneurysm": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.219'
valueset "Autoimmune Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311'
valueset "Bariatric Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317'
valueset "Bleeding Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287'
valueset "Blood Transfusion": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213'
valueset "Cardiac Arrest Ventricular Fibrillation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.221'
valueset "Cardiac Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341'
valueset "Conversion of Cardiac Rhythm": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.357'
valueset "Delivery Procedures": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59'
valueset "Disseminated Intravascular Coagulation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.223'
valueset "Eclampsia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.225'
valueset "Economic Housing Instability": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292'
valueset "ED Visit and OB Triage": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Estimated Gestational Age at Delivery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26'
valueset "Ethnicity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837'
valueset "Gastrointestinal Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338'
valueset "Gestational Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269'
valueset "Heart Failure Cardiac Arrest Related to Procedure or Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.227'
valueset "Hematocrit lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114'
valueset "HIV in Pregnancy Childbirth and Puerperium": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272'
valueset "Hypertension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332'
valueset "Hysterectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.358'
valueset "Long Term Anticoagulant Use": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366'
valueset "Mental Health Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314'
valueset "Mild or Moderate Preeclampsia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329'
valueset "Morbid or Severe Obesity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290'
valueset "Multiple Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284'
valueset "Neuromuscular Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "ONC Administrative Sex": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'
valueset "Payer Type": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591'
valueset "Placenta Accreta": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302'
valueset "Placenta Increta or Percreta": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.388'
valueset "Placenta Previa": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.78'
valueset "Placental Abruption": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305'
valueset "Placental Accreta Spectrum": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302'
valueset "Preexisting Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275'
valueset "Present on Admission is No or Unable To Determine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370'
valueset "Present On Admission is Yes or Exempt": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63'
valueset "Preterm Birth": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299'
valueset "Previous Cesarean": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278'
valueset "Puerperal Cerebrovascular Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.229'
valueset "Pulmonary Edema": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.231'
valueset "Pulmonary Hypertension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281'
valueset "Race": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836'
valueset "Renal Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335'
valueset "Sepsis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.237'
valueset "Severe Anesthesia Complications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.235'
valueset "Severe Maternal Morbidity Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255'
valueset "Severe Maternal Morbidity Procedures": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256'
valueset "Severe Preeclampsia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327'
valueset "Shock": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.239'
valueset "Sickle Cell Disease with Crisis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.241'
valueset "Substance Abuse": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320'
valueset "Thyrotoxicosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296'
valueset "Tracheostomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.359'
valueset "Venous Thromboembolism in Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363'
valueset "Ventilation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.360'
valueset "White blood cells count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Initial Population":
  PCMaternal."Delivery Encounter With Age Range"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "SDE Delivery Encounters With Severe Obstetric Complication Diagnosis":
  ( "Delivery Encounters With Severe Obstetric Complications"
    except "SOC With Hysterectomy Or Blood Transfusion With Placenta Increta Or Placenta Percreta Without Additional SOC" ) Encounter
    where Encounter.isDiagnosisPresentOnAdmission ( "Severe Maternal Morbidity Diagnoses", "Present on Admission is No or Unable To Determine" )

define "SDE Delivery Encounters With Severe Obstetric Complication Procedures":
  ( "Delivery Encounters With Severe Obstetric Complications"
    except "SOC With Hysterectomy Or Blood Transfusion With Placenta Increta Or Placenta Percreta Without Additional SOC" ) Encounter
    where exists ( ["Procedure": "Severe Maternal Morbidity Procedures"]
      union ["Procedure": "Blood Transfusion"] ) SMMProcedures
      where SMMProcedures.status = 'completed'
        and SMMProcedures.performed.toInterval ( ) starts during Encounter.hospitalizationWithEDOBTriageObservation ( )

define "SDE SOC Diagnoses Detail":
  "SDE Delivery Encounters With Severe Obstetric Complication Diagnosis" Encounter
    let complication: Encounter.pOAIsNoOrUTD ( )
    return {
      id: Encounter.id,
      code: Encounter.type,
      complications: complication C
        where C in "Severe Maternal Morbidity Diagnoses"
          or C.getCondition ( ).code in "Severe Maternal Morbidity Diagnoses"
        return {
          code: C,
          SOCDxCategory: C.sOCDxCategory ( )
        }
    }

define "SDE SOC Procedure Detail":
  "SDE Delivery Encounters With Severe Obstetric Complication Procedures" Encounter
    let procedure: Encounter.sOCProcedures ( )
    return {
      id: Encounter.id,
      code: Encounter.type,
      procedures: procedure P
        return {
          code: P,
          SOCProcedureCategory: P.sOCProcedureCategory ( )
        }
    }

define "SOC With Hysterectomy Or Blood Transfusion With Placenta Increta Or Placenta Percreta Without Additional SOC":
  ( "Delivery Encounters With Severe Obstetric Complications" SOCEncounter
      where exists ( ( SOCEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
          where EncounterDiagnosis.code in "Placenta Increta or Percreta"
      )
        and ( exists "Delivery Encounters With Blood Transfusion"
            or exists "Delivery Encounters With Hysterectomy"
        )
  )
	//The following logic keeps encounter in the numerator if there is an additional SOC besides Blood Transfusion or Hysterectomy
    
    except ( ( "Delivery Encounters With Severe Obstetric Complications" SOCEncounter
          where SOCEncounter.isDiagnosisPresentOnAdmission ( "Severe Maternal Morbidity Diagnoses", "Present on Admission is No or Unable To Determine" )
      )
        union "Delivery Encounters With Cardiac Conversion, Tracheostomy Or Ventilation Procedures"
        union "Delivery Encounters With Expiration"
    )

define "Delivery Encounters With Severe Obstetric Complications Excluding Blood Transfusions":
  "Delivery Encounters With Severe Obstetric Complications Diagnosis Or Procedure Excluding Blood Transfusion"
    union "Delivery Encounters With Expiration"

define "Numerator":
  "Delivery Encounters With Severe Obstetric Complications"

define "Delivery Encounters With Calculated Gestational Age Greater Than Or Equal To 20 Weeks":
  PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
    where DeliveryEncounter.calculatedGestationalAge ( ) >= 20

define "Delivery Encounters With Estimated Gestational Age Assessment Greater Than Or Equal To 20 Weeks":
  PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
    where DeliveryEncounter.calculatedGestationalAge ( ) is null
      and ( DeliveryEncounter.lastEstimatedGestationalAge ( ) >= 20 weeks )

define "SDE Variable Calculated Gestational Age":
  //This definition establishes a variable of CGA (Calculated Gestational Age).  CGA is a supplemental data element to store the calculated gestational age result from the "CalculatedGestationalAge" function.  The data element enables the capturing and saving of the CGA for data analysis post data receipt. Hospitals do not need to submit any additional data to comply with this definition. 
  
  PCMaternal."Variable Calculated Gestational Age"

define "Cardiac Conversion, Tracheostomy Or Ventilation Procedures":
  ["Procedure": "Conversion of Cardiac Rhythm"]
    union ["Procedure": "Tracheostomy"]
    union ["Procedure": "Ventilation"]

define "Delivery Encounters With Cardiac Conversion, Tracheostomy Or Ventilation Procedures":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    with "Cardiac Conversion, Tracheostomy Or Ventilation Procedures" ConvTrachVentProcedures
      such that ConvTrachVentProcedures.status = 'completed'
        and ConvTrachVentProcedures.performed.toInterval ( ) starts during TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation ( )

define "Denominator":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation"

define "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation":
  "Delivery Encounters With Calculated Gestational Age Greater Than Or Equal To 20 Weeks"
    union "Delivery Encounters With Estimated Gestational Age Assessment Greater Than Or Equal To 20 Weeks"
    union "Delivery Encounters With Gestational Age Greater Than Or Equal To 20 Weeks Based On Coding"

define "Delivery Encounters With Hysterectomy":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    with ["Procedure": "Hysterectomy"] Hysterectomy
      such that Hysterectomy.status = 'completed'
        and Hysterectomy.performed.toInterval ( ) starts during TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation ( )

define "Delivery Encounters With Expiration":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.hospitalization.dischargeDisposition in "Patient Expired"

define "Delivery Encounters With Gestational Age Greater Than Or Equal To 20 Weeks Based On Coding":
  PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
    let CGA: DeliveryEncounter.calculatedGestationalAge ( ),
    EGA: DeliveryEncounter.lastEstimatedGestationalAge ( )
    where CGA is null
      and EGA is null
      and exists ( ( DeliveryEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
          where EncounterDiagnosis.code in "20 to 42 Plus Weeks Gestation"
      )

define "Delivery Encounters With Severe Obstetric Complications":
  "Delivery Encounters With Severe Obstetric Complications Diagnosis Or Procedure Excluding Blood Transfusion"
    union "Delivery Encounters With Expiration"
    union "Delivery Encounters With Blood Transfusion"

define "Delivery Encounters With Severe Obstetric Complications Diagnosis Or Procedure Excluding Blood Transfusion":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Severe Maternal Morbidity Diagnoses", "Present on Admission is No or Unable To Determine" )
      or ( exists ( ["Procedure": "Severe Maternal Morbidity Procedures"] SMMProcedures
            where SMMProcedures.status = 'completed'
              and SMMProcedures.performed.toInterval ( ) starts during TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation ( )
        )
      )

define "Delivery Encounters With Severe Obstetric Complications Excluding Blood Transfusions Only":
  "Delivery Encounters With Severe Obstetric Complications"
    intersect "Delivery Encounters With Severe Obstetric Complications Excluding Blood Transfusions"

define "SOC Excluding Blood Transfusions Only With Hysterectomy Or Blood Transfusion With Placenta Increta Or Placenta Percreta Without Additional SOC":
  ( "Delivery Encounters With Severe Obstetric Complications Excluding Blood Transfusions Only" SOCExcludingTransfusion
      where exists ( ( SOCExcludingTransfusion.encounterDiagnosis ( ) ) EncounterDiagnoses
          where EncounterDiagnoses.code in "Placenta Increta or Percreta"
      )
        and ( exists "Delivery Encounters With Blood Transfusion"
            or exists "Delivery Encounters With Hysterectomy"
        )
  )
	
	//The following logic keeps encounter in the numerator if there is an additional SOC besides Blood Transfusion or Hysterectomy
    
    except ( ( "Delivery Encounters With Severe Obstetric Complications Excluding Blood Transfusions Only" SOCExcludingTransfusion
          where SOCExcludingTransfusion.isDiagnosisPresentOnAdmission ( "Severe Maternal Morbidity Diagnoses", "Present on Admission is No or Unable To Determine" )
      )
        union "Delivery Encounters With Cardiac Conversion, Tracheostomy Or Ventilation Procedures"
        union "Delivery Encounters With Expiration"
    )

define "Risk Variable Anemia":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Anemia", "Present On Admission is Yes or Exempt" )

define "Risk Variable Asthma":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Acute or Persistent Asthma", "Present On Admission is Yes or Exempt" )

define "Risk Variable Autoimmune Disease":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Autoimmune Disease", "Present On Admission is Yes or Exempt" )

define "Risk Variable Bariatric Surgery":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Bariatric Surgery", "Present On Admission is Yes or Exempt" )

define "Risk Variable Bleeding Disorder":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Bleeding Disorder", "Present On Admission is Yes or Exempt" )

define "Risk Variable Cardiac Disease":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Cardiac Disease", "Present On Admission is Yes or Exempt" )

define "Risk Variable Economic Housing Instability":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Economic Housing Instability", "Present On Admission is Yes or Exempt" )

define "Risk Variable Gastrointestinal Disease":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Gastrointestinal Disease", "Present On Admission is Yes or Exempt" )

define "Risk Variable Gestational Diabetes":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Gestational Diabetes", "Present On Admission is Yes or Exempt" )

define "Risk Variable HIV":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "HIV in Pregnancy Childbirth and Puerperium", "Present On Admission is Yes or Exempt" )

define "Risk Variable Hypertension":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Hypertension", "Present On Admission is Yes or Exempt" )

define "Risk Variable Long Term Anticoagulant Use":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Long Term Anticoagulant Use", "Present On Admission is Yes or Exempt" )

define "Risk Variable Maternal Age":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    let MaternalAge: AgeInYearsAt(date from start of TwentyWeeksPlusEncounter.period)
    return { TwentyWeeksPlusEncounter, MaternalAge }

define "Risk Variable Mental Health Disorder":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Mental Health Disorder", "Present On Admission is Yes or Exempt" )

define "Risk Variable Morbid Obesity":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Morbid or Severe Obesity", "Present On Admission is Yes or Exempt" )

define "Risk Variable Multiple Pregnancy":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Multiple Pregnancy", "Present On Admission is Yes or Exempt" )

define "Risk Variable Neuromuscular Disease":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Neuromuscular Disease", "Present On Admission is Yes or Exempt" )

define "Risk Variable Obstetrical VTE":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Venous Thromboembolism in Pregnancy", "Present On Admission is Yes or Exempt" )

define "Risk Variable Other Preeclampsia":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Mild or Moderate Preeclampsia", "Present On Admission is Yes or Exempt" )

define "Risk Variable Placenta Previa":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Placenta Previa", "Present On Admission is Yes or Exempt" )

define "Risk Variable Placental Abruption":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Placental Abruption", "Present On Admission is Yes or Exempt" )

define "Risk Variable Placental Accreta Spectrum":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Placenta Accreta", "Present On Admission is Yes or Exempt" )
      or TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Placenta Increta or Percreta", "Present On Admission is Yes or Exempt" )

define "Risk Variable Preexisting Diabetes":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Preexisting Diabetes", "Present On Admission is Yes or Exempt" )

define "Risk Variable Previous Cesarean":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Previous Cesarean", "Present On Admission is Yes or Exempt" )

define "Risk Variable Pulmonary Hypertension":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Pulmonary Hypertension", "Present On Admission is Yes or Exempt" )

define "Risk Variable Renal Disease":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Renal Disease", "Present On Admission is Yes or Exempt" )

define "Risk Variable Severe Preeclampsia":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Severe Preeclampsia", "Present On Admission is Yes or Exempt" )

define "Risk Variable Substance Abuse":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Substance Abuse", "Present On Admission is Yes or Exempt" )

define "Risk Variable Thyrotoxicosis":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    where TwentyWeeksPlusEncounter.isDiagnosisPresentOnAdmission ( "Thyrotoxicosis", "Present On Admission is Yes or Exempt" )

define "Risk Variable Preterm Birth":
/*  CGA = Calculated Gestational Age.  EGA = Estimated Gestational Age. */
  
  ( PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
      let CGA: DeliveryEncounter.calculatedGestationalAge ( ),
      EGA: DeliveryEncounter.lastEstimatedGestationalAge ( )
      where CGA in Interval[20, 36]
        or ( CGA is null
            and ( EGA >= 20 weeks
                and EGA <= 36 weeks
            )
        )
  )
    union ( PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
        let CGA: DeliveryEncounter.calculatedGestationalAge ( ),
        EGA: DeliveryEncounter.lastEstimatedGestationalAge ( )
        where CGA is null
          and EGA is null
          and /*DeliveryEncounter.isDiagnosisPresentOnAdmission("Preterm Birth","Present On Admission is Yes or Exempt")*/
                
                /*where DeliveryEncounter.isDiagnosisPresentOnAdmission("Preterm Birth","Present On Admission is Yes or Exempt")*/
          
          exists ( ( DeliveryEncounter.claimDiagnosis ( ) ) D
              where D.onAdmission ~ "POA-Y"
                and ( D.diagnosis in "Preterm Birth"
                    or D.diagnosis.getCondition ( ).code in "Preterm Birth"
                )
          )
    )

define "Delivery Encounters With Blood Transfusion":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    with ["Procedure": "Blood Transfusion"] BloodTransfusion
      such that BloodTransfusion.status = 'completed'
        and BloodTransfusion.performed.toInterval ( ) starts during TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation ( )


 //First resulted value 24 hours prior to start of encounter and before time of delivery
 //Report hematocrit as %



define "Risk Variable First Hematocrit Lab Test":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    let FirstHematocrit: First(["LaboratoryResultObservation": "Hematocrit lab test"] Hematocrit
        where Hematocrit.issued during Interval[start of TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation() - 1440 minutes, TwentyWeeksPlusEncounter.lastTimeOfDelivery()]
          and Hematocrit.status in { 'final', 'amended', 'corrected' }
          and Hematocrit.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: TwentyWeeksPlusEncounter.id,
      FirstHematocritResult: FirstHematocrit.value as Quantity,
      Timing: FirstHematocrit.issued
    }


 //First resulted value 24 hours prior to start of encounter and before time of delivery
 //Report white blood cell count as 10*3/uL



define "Risk Variable First White Blood Cell Count Lab Test":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    let FirstWBC: First(["LaboratoryResultObservation": "White blood cells count lab test"] WBC
        where WBC.issued during Interval[start of TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation() - 1440 minutes, TwentyWeeksPlusEncounter.lastTimeOfDelivery()]
          and WBC.status in { 'final', 'amended', 'corrected' }
          and WBC.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: TwentyWeeksPlusEncounter.id,
      FirstWBCResult: FirstWBC.value as Quantity,
      Timing: FirstWBC.issued
    }


 //First resulted value 24 hours prior to start of encounter and before time of delivery
 //Report heart rate as beats/min
 //Heart rate value cannot be null per QICore profile requirement.




define "Risk Variable Heart Rate":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    let FirstHeartRate: First([USCoreHeartRateProfile] HeartRate
        where HeartRate.effective.earliest() during Interval[start of TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation() - 1440 minutes, TwentyWeeksPlusEncounter.lastTimeOfDelivery()]
          and HeartRate.status in { 'final', 'amended', 'corrected' }
        sort by effective.earliest()
    )
    return {
      EncounterId: TwentyWeeksPlusEncounter.id,
      FirstHRResult: FirstHeartRate.value as Quantity,
      Timing: FirstHeartRate.effective.earliest ( )
    }
      
      
//First resulted value 24 hours prior to start of encounter and before time of delivery
//Report systolic blood pressure as mm[Hg]
//Systolic blood pressure value cannot be null per QICore profile requirement.




define "Risk Variable Systolic Blood Pressure":
  "Delivery Encounters At Greater Than Or Equal To 20 Weeks Gestation" TwentyWeeksPlusEncounter
    let FirstSystolicBP: First(["USCoreBloodPressureProfile"] BP
        where BP.effective.earliest() during Interval[start of TwentyWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation() - 1440 minutes, TwentyWeeksPlusEncounter.lastTimeOfDelivery()]
          and BP.status in { 'final', 'amended', 'corrected' }
          and BP.component.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: TwentyWeeksPlusEncounter.id,
      FirstSBPResult: FirstSystolicBP.component C
        where C.code ~ "Systolic blood pressure"
        return C.value as Quantity,
      Timing: FirstSystolicBP.effective.earliest ( )
    }

define fluent function pOAIsNoOrUTD(TheEncounter Encounter):
  ( TheEncounter.claimDiagnosis ( ) ) CDiagnoses
    where CDiagnoses.onAdmission in "Present on Admission is No or Unable To Determine"
    return CDiagnoses.diagnosis

define fluent function pOAIsYesOrExempt(TheEncounter Encounter):
  TheEncounter E
    where exists ( ( E.claimDiagnosis ( ) ) CDiagnoses
        where CDiagnoses.onAdmission in "Present On Admission is Yes or Exempt"
    )
    return E.claimDiagnosis ( )

define fluent function sOCDxCategory(Dx Concept):
  case
    when Dx in "Acute Heart Failure" then 'Acute Heart Failure'
    when Dx in "Acute Myocardial Infarction" then 'Acute Myocardial Infarction'
    when Dx in "Acute Renal Failure" then 'Acute Renal Failure'
    when Dx in "Acute Respiratory Distress Syndrome" then 'Acute Respiratory Distress Syndrome'
    when Dx in "Air and Thrombotic Embolism" then 'Air and Thrombotic Embolism'
    when Dx in "Amniotic Fluid Embolism" then 'Amniotic Fluid Embolism'
    when Dx in "Aortic Aneurysm" then 'Aortic Aneurysm'
    when Dx in "Cardiac Arrest Ventricular Fibrillation" then 'Cardiac Arrest Ventricular Fibrillation'
    when Dx in "Disseminated Intravascular Coagulation" then 'Disseminated Intravascular Coagulation'
    when Dx in "Eclampsia" then 'Eclampsia'
    when Dx in "Heart Failure Cardiac Arrest Related to Procedure or Surgery" then 'Heart Failure Cardiac Arrest Related to Procedure or Surgery'
    when Dx in "Puerperal Cerebrovascular Disorder" then 'Puerperal Cerebrovascular Disorder'
    when Dx in "Pulmonary Edema" then 'Pulmonary Edema'
    when Dx in "Sepsis" then 'Sepsis'
    when Dx in "Severe Anesthesia Complications" then 'Severe Anesthesia Complications'
    when Dx in "Shock" then 'Shock'
    when Dx in "Sickle Cell Disease with Crisis" then 'Sickle Cell Disease with Crisis' 
    else null end

define fluent function sOCProcedureCategory(TheProcedure Procedure):
  case
    when TheProcedure.code in "Blood Transfusion" then 'Blood Transfusion'
    when TheProcedure.code in "Conversion of Cardiac Rhythm" then 'Conversion of cardiac rhythm'
    when TheProcedure.code in "Hysterectomy" then 'Hysterectomy'
    when TheProcedure.code in "Tracheostomy" then 'Tracheostomy'
    when TheProcedure.code in "Ventilation" then 'Ventilation' 
    else null end

define fluent function sOCProcedures(TheEncounter Encounter):
  ( ["Procedure": "Severe Maternal Morbidity Procedures"]
    union ["Procedure": "Blood Transfusion"] ) SMMProcedures
    where SMMProcedures.status = 'completed'
      and SMMProcedures.performed.toInterval ( ) starts during TheEncounter.hospitalizationWithEDOBTriageObservation ( )