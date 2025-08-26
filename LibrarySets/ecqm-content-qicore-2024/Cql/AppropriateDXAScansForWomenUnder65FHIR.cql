library AppropriateDXAScansForWomenUnder65FHIR version '0.2.001'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon
include Status version '1.8.000' called Status
include CumulativeMedicationDuration version '4.1.000' called CMD
include Hospice version '6.12.000' called Hospice

codesystem "LOINC": 'http://loinc.org'
codesystem "AdministrativeGender": 'http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Amenorrhea": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1022'
valueset "Ankylosing Spondylitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1045'
valueset "Aromatase Inhibitors": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1265'
valueset "Bilateral Oophorectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.471'
valueset "Bone Marrow Transplant": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.336'
valueset "Chemotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.485'
valueset "Chronic Liver Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1035'
valueset "Chronic Malnutrition": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1036'
valueset "Cushings Syndrome": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1009'
valueset "DXA (Dual energy Xray Absorptiometry) Scan": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1051'
valueset "Eating Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1039'
valueset "Ehlers Danlos Syndrome": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1047'
valueset "End Stage Renal Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353'
valueset "Evidence of Bilateral Oophorectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1048'
valueset "Gastric Bypass Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1050'
valueset "Glucocorticoids (oral only)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1266'
valueset "History of hip fracture in parent": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1040'
valueset "Hyperparathyroidism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1016'
valueset "Hyperthyroidism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1015'
valueset "Kidney Transplant": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012'
valueset "Lupus": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.117.12.1010'
valueset "Major Transplant": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1075'
valueset "Malabsorption Syndromes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1050'
valueset "Marfan's Syndrome": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1048'
valueset "Multiple Myeloma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1011'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Osteogenesis Imperfecta": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1044'
valueset "Osteopenia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1049'
valueset "Osteoporosis Without Current Fracture": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1038'
valueset "Osteoporosis With Current Fracture": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1050'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Premature Menopause": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1013'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Psoriatic Arthritis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1046'
valueset "Rheumatoid Arthritis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1005'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Type 1 Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1020'
valueset "Unilateral Oophorectomy Left": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1028'
valueset "Unilateral Oophorectomy Right": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1032'
valueset "Unilateral Oophorectomy, Unspecified Laterality": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1035'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

code "Alcoholic drinks per day": '74013-4' from "LOINC" display 'Alcoholic drinks per day'
code "Body mass index (BMI) [Ratio]": '39156-5' from "LOINC" display 'Body mass index (BMI) [Ratio]'
code "Female": 'F' from "AdministrativeGender" display 'Female'
code "Left (qualifier value)": '7771000' from "SNOMEDCT" display 'Left (qualifier value)'
code "Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment": '90265-0' from "LOINC" display 'Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment'
code "Osteoporosis Index of Risk panel": '98133-2' from "LOINC" display 'Osteoporosis Index of Risk panel'
code "Osteoporosis Risk Assessment Instrument": '98139-9' from "LOINC" display 'Osteoporosis Risk Assessment Instrument'
code "Osteoporosis Self-Assessment Tool": '98146-4' from "LOINC" display 'Osteoporosis Self-Assessment Tool'
code "Right (qualifier value)": '24028007' from "SNOMEDCT" display 'Right (qualifier value)'
code "Unlisted preventive medicine service": '99429' from "CPT" display 'Unlisted preventive medicine service'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.000Z, @2025-12-31T23:59:59.999Z]

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") in Interval[50, 63]
    and Patient.gender = 'female'
    and exists "Qualifying Encounter"

define "Qualifying Encounter":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Unlisted preventive medicine service"
          )
      )
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Outpatient Consultation"]
      union [Encounter: "Virtual Encounter"]
      union [Encounter: "Telephone Visits"]
  ).isEncounterPerformed ( ) ) ValidEncounters
    where ValidEncounters.period.toInterval ( ) during day of "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Has Risk Factor Active During the Measurement Period"
    or "Has Risk Factor Any Time in History Prior to Measurement Period"
    or "Has Risk Factor Any Time in History or During Measurement Period"

define "Has Risk Factor Active During the Measurement Period":
  "First BMI in Measurement Period Less Than or Equal to 20 kg m2" is not null
    or "First Average Number of Drinks Assessments Indicating More Than Two Per Day" is not null

define "First BMI in Measurement Period Less Than or Equal to 20 kg m2":
  "First BMI in Measurement Period" FirstBMI
    where FirstBMI.value as Quantity <= 20 'kg/m2'

define "First BMI in Measurement Period":
  First(((["observation-bmi"]).isObservationBMI()) BMIRatio
      where BMIRatio.effective.toInterval() during "Measurement Period"
        and BMIRatio.value as Quantity is not null
      sort by start of effective.toInterval()
  )

define "First Average Number of Drinks Assessments Indicating More Than Two Per Day":
  First((([Observation: "Alcoholic drinks per day"]).isAssessmentPerformed()) AverageDrinks
      where start of AverageDrinks.effective.toInterval() during "Measurement Period"
        and AverageDrinks.value as Quantity > 2 '{drinks}/d'
      sort by start of effective.toInterval()
  )

define "Has Risk Factor Any Time in History Prior to Measurement Period":
  exists ( ( [Condition: "Osteoporosis Without Current Fracture"] OsteoporosisDiagnosis
        where OsteoporosisDiagnosis.prevalenceInterval ( ) starts before start of "Measurement Period"
    )
      union ( [Condition: "Osteopenia"] OsteopeniaDiagnosis
          where OsteopeniaDiagnosis.prevalenceInterval ( ) starts before start of "Measurement Period"
      )
      union ( ( ( ( [Procedure: "Gastric Bypass Surgery"] ).isProcedurePerformed ( ) ) GastricBypass
            where GastricBypass.performed.toInterval ( ) ends before start of "Measurement Period"
        )
          union ( ( ( [MedicationRequest: "Aromatase Inhibitors"] ).isMedicationActive ( ) ) AromataseInhibitorActive
              where CMD."MedicationRequestPeriod" ( AromataseInhibitorActive ) starts before start of "Measurement Period"
          )
          union ( ( ( [MedicationRequest: "Aromatase Inhibitors"] ).isMedicationOrder ( ) ) AromataseInhibitorOrder
              where AromataseInhibitorOrder.authoredOn.toInterval ( ) before start of "Measurement Period"
          )
          union ( ( [Observation: "History of hip fracture in parent"] ).isAssessmentPerformed ( ) ) ParentFractureHistory
            where start of ParentFractureHistory.effective.toInterval ( ) before start of "Measurement Period"
      )
  )

define "Has Risk Factor Any Time in History or During Measurement Period":
  "Has 90 or More Active Glucocorticoid Medication Days"
    or exists ( [Condition: "Osteoporosis With Current Fracture"]
        union [Condition: "Malabsorption Syndromes"]
        union [Condition: "Chronic Malnutrition"]
        union [Condition: "Chronic Liver Disease"]
        union [Condition: "Rheumatoid Arthritis"]
        union [Condition: "Hyperthyroidism"]
        union [Condition: "Type 1 Diabetes"]
        union [Condition: "End Stage Renal Disease"]
        union [Condition: "Osteogenesis Imperfecta"]
        union [Condition: "Ankylosing Spondylitis"]
        union [Condition: "Psoriatic Arthritis"]
        union [Condition: "Ehlers Danlos Syndrome"]
        union [Condition: "Cushings Syndrome"]
        union [Condition: "Hyperparathyroidism"]
        union [Condition: "Marfan's Syndrome"]
        union [Condition: "Lupus"]
        union [Condition: "Multiple Myeloma"]
        union [Condition: "Premature Menopause"]
        union [Condition: "Eating Disorders"]
        union [Condition: "Amenorrhea"]
    ).diagnosisInPatientHistory ( )
    or exists ( [Procedure: "Chemotherapy"] ).procedureInPatientHistory ( )
    or "Has Double or Bilateral Oophorectomy"
    or "Has Organ Transplants"

define "Has 90 or More Active Glucocorticoid Medication Days":
  "Glucocorticoid Active Medication Days" >= 90

define "Glucocorticoid Active Medication Days":
  ( ( ( ( [MedicationRequest: "Glucocorticoids (oral only)"] ).isMedicationActive ( ) ) OralGlucocorticoid
      where ( OralGlucocorticoid ).medicationRequestPeriod ( ) starts before end of "Measurement Period" ) Glucocorticoid
      return ( Glucocorticoid ).medicationRequestPeriod ( )
        intersect Interval[Patient.birthDate, date from end of "Measurement Period"]
  ).cumulativeDuration ( )

define "Has Organ Transplants":
  exists ( [Procedure: "Major Transplant"]
      union [Procedure: "Kidney Transplant"]
      union [Procedure: "Bone Marrow Transplant"]
  ).procedureInPatientHistory ( )

define "Has Double or Bilateral Oophorectomy":
  exists ( ( [Procedure: "Bilateral Oophorectomy"] ).procedureInPatientHistory ( ) )
    or exists ( ( [Procedure: "Evidence of Bilateral Oophorectomy"] ).procedureInPatientHistory ( ) )
    or ( exists ( ( ( [Procedure: "Unilateral Oophorectomy, Unspecified Laterality"] UnilateralOophorectomy
              where exists ( UnilateralOophorectomy.bodySite C
                  where C ~ "Right (qualifier value)"
              )
          )
            union [Procedure: "Unilateral Oophorectomy Right"]
        ).procedureInPatientHistory ( )
      )
        and exists ( ( ( [Procedure: "Unilateral Oophorectomy, Unspecified Laterality"] UnilateralOophorectomy
                where exists ( UnilateralOophorectomy.bodySite D
                    where D ~ "Left (qualifier value)"
                )
            )
              union [Procedure: "Unilateral Oophorectomy Left"]
          ).procedureInPatientHistory ( )
        )
    )

define "Numerator":
  exists "DXA Scan Order During Measurement Period"

define "DXA Scan Order During Measurement Period":
  ( ( [ServiceRequest: "DXA (Dual energy Xray Absorptiometry) Scan"] ).isDiagnosticStudyOrder ( ) ) DXA
    where DXA.authoredOn.toInterval ( ) during "Measurement Period"
    // and DXA.doNotPerform is not true
    // https://oncprojectracking.healthit.gov/support/browse/CQLIT-447 
    
    
    sort by authoredOn asc

define "Numerator Exclusion":
  exists "Osteoporosis Fracture Risk Assessment Prior to First DXA Scan"

define "Osteoporosis Fracture Risk Assessment Prior to First DXA Scan":
  ( ( ( ( [Observation: "Major osteoporotic fracture 10-year probability [Likelihood] Fracture Risk Assessment"] ).isAssessmentPerformed ( ) ) FRAX
      where FRAX.value >= 8.4 '%'
  )
    union ( ( ( [Observation: "Osteoporosis Risk Assessment Instrument"] ).isAssessmentPerformed ( ) ) ORAI
        where ORAI.value as Integer >= 9
    )
    union ( ( ( [Observation: "Osteoporosis Index of Risk panel"] ).isAssessmentPerformed ( ) ) OSIRIS
        where OSIRIS.value as Quantity < 1.0
    )
    union ( ( ( [Observation: "Osteoporosis Self-Assessment Tool"] ).isAssessmentPerformed ( ) ) OST
        where OST.value as Quantity < 2.0
    ) ) RiskAssessment
    where start of RiskAssessment.effective.toInterval ( ) before First("DXA Scan Order During Measurement Period").authoredOn

define fluent function "procedureInPatientHistory"(Procedure List<"Procedure">):
  ( ( Procedure ).isProcedurePerformed ( ) ) Proc
    where Proc.performed.toInterval ( ) ends on or before day of end of "Measurement Period"

define fluent function "diagnosisInPatientHistory"(Condition List<"Condition">):
  ( Condition ) Dx
    where Dx.prevalenceInterval ( ) starts on or before day of end of "Measurement Period"