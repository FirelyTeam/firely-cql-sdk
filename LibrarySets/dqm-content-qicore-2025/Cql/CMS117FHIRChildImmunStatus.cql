library CMS117FHIRChildImmunStatus version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include Hospice version '6.18.000' called Hospice
include Status version '1.15.000' called Status
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "CPT": 'http://www.ama-assn.org/go/cpt'
codesystem "CVX": 'http://hl7.org/fhir/sid/cvx'
codesystem "ICD10": 'http://www.cms.gov/Medicare/Coding/ICD10'

valueset "Anaphylactic Reaction to DTaP Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031'
valueset "Disorders of the Immune System": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001'
valueset "DTaP Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214'
valueset "DTaP Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022'
valueset "Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164'
valueset "Hepatitis A": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024'
valueset "Hepatitis A Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215'
valueset "Hepatitis A Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041'
valueset "Hepatitis B": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025'
valueset "Hepatitis B Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216'
valueset "Hepatitis B Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042'
valueset "Hib Vaccine (3 dose schedule)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083'
valueset "Hib Vaccine (3 dose schedule) Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084'
valueset "Hib Vaccine (4 dose schedule)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085'
valueset "Hib Vaccine (4 dose schedule) Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086'
valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Inactivated Polio Vaccine (IPV)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219'
valueset "Inactivated Polio Vaccine (IPV) Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045'
valueset "Child Influenza Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218'
valueset "Child Influenza Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044'
valueset "Influenza Virus LAIV Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087'
valueset "Influenza Virus LAIV Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088'
valueset "Intussusception": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056'
valueset "Malignant Neoplasm of Lymphatic and Hematopoietic Tissue": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009'
valueset "Measles": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053'
valueset "Measles, Mumps and Rubella (MMR) Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224'
valueset "Measles, Mumps and Rubella (MMR) Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031'
valueset "Mumps": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Pneumococcal Conjugate Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221'
valueset "Pneumococcal Conjugate Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Rotavirus Vaccine (2 dose schedule) Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048'
valueset "Rotavirus Vaccine (3 dose schedule)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223'
valueset "Rotavirus Vaccine (3 dose schedule) Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047'
valueset "Rubella": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037'
valueset "Severe Combined Immunodeficiency": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Varicella Zoster": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039'
valueset "Varicella Zoster Vaccine (VZV)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170'
valueset "Varicella Zoster Vaccine (VZV) Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040'

code "Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)": '433621000124101' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)'
code "Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)": '428321000124101' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)'
code "Anaphylaxis caused by rotavirus vaccine (disorder)": '428331000124103' from "SNOMEDCT" display 'Anaphylaxis caused by rotavirus vaccine (disorder)'
code "Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional": '99211' from "CPT" display 'Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional'
code "rotavirus, live, monovalent vaccine": '119' from "CVX" display 'rotavirus, live, monovalent vaccine'
code "Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)": '471311000124103' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)'
code "Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach": '3E0234Z' from "ICD10" display 'Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach'
code "Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)": '471361000124100' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)'
code "Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)": '471331000124109' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)'
code "Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)": '471141000124102' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)'
code "Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)": '471321000124106' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)'
code "Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)": '471341000124104' from "SNOMEDCT" display 'Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) = 2
    and exists ( "Qualifying Encounters" )

define "Qualifying Encounters":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional"
          )
      )
      union [Encounter: "Virtual Encounter"]
      union [Encounter: "Telephone Visits"]
  ).isEncounterPerformed ( ) ) ValidEncounters
    where ValidEncounters.period during day of "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or "Has Severe Combined Immunodeficiency"
    or "Has Immunodeficiency"
    or "Has HIV"
    or "Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia"
    or "Has Intussusception"

define "Has Severe Combined Immunodeficiency":
  exists ( ( ( [ConditionEncounterDiagnosis: "Severe Combined Immunodeficiency"]
        union [ConditionProblemsHealthConcerns: "Severe Combined Immunodeficiency"]
    ).verified ( ) ) SevereImmuneDisorder
      where date from start of SevereImmuneDisorder.prevalenceInterval ( ) during day of "First Two Years"
  )

define "Has Immunodeficiency":
  exists ( ( ( [ConditionEncounterDiagnosis: "Disorders of the Immune System"]
        union [ConditionProblemsHealthConcerns: "Disorders of the Immune System"]
    ).verified ( ) ) ImmuneDisorder
      where date from start of ImmuneDisorder.prevalenceInterval ( ) during day of "First Two Years"
  )

define "Has HIV":
  exists ( ( ( [ConditionEncounterDiagnosis: "HIV"]
        union [ConditionProblemsHealthConcerns: "HIV"]
    ).verified ( ) ) HIVDiagnosis
      where date from start of HIVDiagnosis.prevalenceInterval ( ) during day of "First Two Years"
  )

define "Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia":
  exists ( ( ( [ConditionEncounterDiagnosis: "Malignant Neoplasm of Lymphatic and Hematopoietic Tissue"]
        union [ConditionProblemsHealthConcerns: "Malignant Neoplasm of Lymphatic and Hematopoietic Tissue"]
    ).verified ( ) ) LymphaticMalignantNeoplasm
      where date from start of LymphaticMalignantNeoplasm.prevalenceInterval ( ) during day of "First Two Years"
  )

define "Has Intussusception":
  exists ( ( ( [ConditionEncounterDiagnosis: "Intussusception"]
        union [ConditionProblemsHealthConcerns: "Intussusception"]
    ).verified ( ) ) IntussusceptionDisorder
      where date from start of IntussusceptionDisorder.prevalenceInterval ( ) during day of "First Two Years"
  )

define "Numerator":
  ( exists ( "Four DTaP Vaccinations" )
      or exists ( "DTaP Numerator Inclusion Conditions" )
  )
    and ( exists ( "Three Polio Vaccinations" )
        or exists ( "Polio Numerator Inclusion Conditions" )
    )
    and ( exists ( "One MMR Vaccination" )
        or exists ( "MMR Numerator Inclusion Conditions" )
        or ( exists ( "Measles Indicators" )
            and exists ( "Mumps Indicators" )
            and exists ( "Rubella Indicators" )
        )
    )
    and ( "Has Appropriate Number of Hib Immunizations"
        or exists ( "Hib Numerator Inclusion Conditions" )
    )
    and ( exists ( "Three Hepatitis B Vaccinations" )
        or ( exists ( "Meets HepB Vaccination Requirement" )
            or exists ( "Hepatitis B Numerator Inclusion Conditions" )
        )
    )
    and ( exists ( "One Chicken Pox Vaccination" )
        or exists ( "Varicella Zoster Numerator Inclusion Conditions" )
    )
    and ( exists ( "Four Pneumococcal Conjugate Vaccinations" )
        or exists ( "Pneumococcal Conjugate Numerator Inclusion Conditions" )
    )
    and ( exists ( "One Hepatitis A Vaccinations" )
        or exists ( "Hepatitis A Numerator Inclusion Conditions" )
    )
    and ( "Has Appropriate Number of Rotavirus Immunizations"
        or exists ( "Rotavirus Numerator Inclusion Conditions" )
    )
    and ( exists ( "Two Influenza Vaccinations" )
        or ( "Two Influenza Vaccinations Including One LAIV Vaccination" )
        or exists ( "Influenza Numerator Inclusion Conditions" )
    )

define "Vaccine Administration Interval - 180 Days up to 2 Years Old":
  Interval[date from Patient.birthDate + 180 days, "Date of Second Birthday"]

define "First Two Years":
  Interval[date from Patient.birthDate, "Date of Second Birthday"]

define "Vaccine Administration Interval - 42 Days up to 2 Years Old":
  Interval[date from Patient.birthDate + 42 days, "Date of Second Birthday"]

define "Date of Second Birthday":
  date from Patient.birthDate + 2 years

define "Date of First Birthday":
  date from Patient.birthDate + 1 year

define "Date of First Birthday to Date of Second Birthday":
  Interval["Date of First Birthday", "Date of Second Birthday"]

//DTaP


define "Four DTaP Vaccinations":
  from
    "DTaP Immunizations or Procedures" DTaPVaccination1,
    "DTaP Immunizations or Procedures" DTaPVaccination2,
    "DTaP Immunizations or Procedures" DTaPVaccination3,
    "DTaP Immunizations or Procedures" DTaPVaccination4
    where date from DTaPVaccination2.earliest ( ) 1 day or more after day of date from DTaPVaccination1.earliest ( )
      and date from DTaPVaccination3.earliest ( ) 1 day or more after day of DTaPVaccination2.earliest ( )
      and date from DTaPVaccination4.earliest ( ) 1 day or more after day of DTaPVaccination3.earliest ( )
    return all DTaPVaccination1

define "DTaP Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylactic Reaction to DTaP Vaccine"]
      union [ConditionProblemsHealthConcerns: "Anaphylactic Reaction to DTaP Vaccine"]
      union [ConditionEncounterDiagnosis: "Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine"]
      union [ConditionProblemsHealthConcerns: "Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine"]
  ).verified ( ) ) DTaPConditions
    where date from start of DTaPConditions.prevalenceInterval ( ) during day of "First Two Years"

define "DTaP Immunizations or Procedures":
  ( ( ( [Immunization: "DTaP Vaccine"] ).isImmunizationAdministered ( ) ) DTaPVaccination
      where date from DTaPVaccination.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
      return date from DTaPVaccination.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "DTaP Vaccine Administered"] ).isProcedurePerformed ( ) ) DTaPProcedure
        where date from DTaPProcedure.performed.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from DTaPProcedure.performed.earliest ( )
    )

//Polio


define "Polio Immunizations or Procedures":
  ( ( ( [Immunization: "Inactivated Polio Vaccine (IPV)"] ).isImmunizationAdministered ( ) ) PolioVaccination
      where date from PolioVaccination.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
      return date from PolioVaccination.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Inactivated Polio Vaccine (IPV) Administered"] ).isProcedurePerformed ( ) ) PolioProcedure
        where date from PolioProcedure.performed.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from PolioProcedure.performed.earliest ( )
    )

define "Three Polio Vaccinations":
  from
    "Polio Immunizations or Procedures" PolioVaccination1,
    "Polio Immunizations or Procedures" PolioVaccination2,
    "Polio Immunizations or Procedures" PolioVaccination3
    where date from PolioVaccination2.earliest ( ) 1 day or more after date from PolioVaccination1.earliest ( )
      and date from PolioVaccination3.earliest ( ) 1 day or more after date from PolioVaccination2.earliest ( )
    return date from PolioVaccination1.earliest ( )

define "Polio Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)"]
  ).verified ( ) ) PolioConditions
    where date from start of PolioConditions.prevalenceInterval ( ) during day of "First Two Years"

//MMR


define "One MMR Vaccination":
  ( ( ( [Immunization: "Measles, Mumps and Rubella (MMR) Vaccine"] ).isImmunizationAdministered ( ) ) MMRVaccination
      where date from MMRVaccination.occurrence.earliest ( ) during "Date of First Birthday to Date of Second Birthday"
      return date from MMRVaccination.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Measles, Mumps and Rubella (MMR) Vaccine Administered"] ).isProcedurePerformed ( ) ) MMRProcedure
        where date from MMRProcedure.performed.earliest ( ) during "Date of First Birthday to Date of Second Birthday"
        return date from MMRProcedure.performed.earliest ( )
    )

define "Measles Indicators":
  ( ( [ConditionEncounterDiagnosis: "Measles"]
      union [ConditionEncounterDiagnosis: "Measles"]
  ).verified ( ) ) MeaslesDiagnosis
    where date from start of MeaslesDiagnosis.prevalenceInterval ( ) during day of "First Two Years"

define "Mumps Indicators":
  ( ( [ConditionEncounterDiagnosis: "Mumps"]
      union [ConditionProblemsHealthConcerns: "Mumps"]
  ).verified ( ) ) MumpsDiagnosis
    where date from start of MumpsDiagnosis.prevalenceInterval ( ) during day of "First Two Years"

define "Rubella Indicators":
  ( ( [ConditionEncounterDiagnosis: "Rubella"]
      union [ConditionProblemsHealthConcerns: "Rubella"]
  ).verified ( ) ) RubellaDiagnosis
    where date from start of RubellaDiagnosis.prevalenceInterval ( ) during day of "First Two Years"

define "MMR Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)"]
  ).verified ( ) ) MMRConditions
    where date from start of MMRConditions.prevalenceInterval ( ) during day of "First Two Years"

//HiB


define "Has Appropriate Number of Hib Immunizations":
  exists ( "Hib 3 or 4 Dose Immunizations" HibImmunization //4 dose test
      
      let HasFourDose: Count("Hib 4 Dose Immunizations or Procedures") > 0
      where ( HasFourDose //if pt had at least one 4 dose code
          
          and Count(distinct("Hib 3 or 4 Dose Immunizations" HibVaccinations
                return date from HibVaccinations.earliest()
            )
          ) >= 4 //pt must have 4 regimens (e.g., 3,3,4,4 or 4,3,4,4)
      
      )
        or ( HasFourDose is false //if pt did not have at least one 4 dose code
            
            and Count(distinct("Hib 3 or 4 Dose Immunizations" HibVaccinations
                  return date from HibVaccinations.earliest()
              )
            ) >= 3 //pt must have 3 regimens of 3 dose codes
        
        )
  )

define "Hib Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)"]
  ).verified ( ) ) HibReaction
    where date from start of HibReaction.prevalenceInterval ( ) during day of "First Two Years"

define "Hib 3 Dose Immunizations or Procedures":
  ( ( ( [Immunization: "Hib Vaccine (3 dose schedule)"] ).isImmunizationAdministered ( ) ) ThreeDoseHibVaccine
      where date from ThreeDoseHibVaccine.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
      return date from ThreeDoseHibVaccine.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Hib Vaccine (3 dose schedule) Administered"] ).isProcedurePerformed ( ) ) ThreeDoseHibProcedure
        where date from ThreeDoseHibProcedure.performed.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from ThreeDoseHibProcedure.performed.earliest ( )
    )

define "Hib 3 or 4 Dose Immunizations":
  "Hib 3 Dose Immunizations or Procedures"
    union "Hib 4 Dose Immunizations or Procedures"

define "Hib 4 Dose Immunizations or Procedures":
  ( ( ( [Immunization: "Hib Vaccine (4 dose schedule)"] ).isImmunizationAdministered ( ) ) HibVaccine
      where date from HibVaccine.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
      return date from HibVaccine.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Hib Vaccine (4 dose schedule) Administered"] ).isProcedurePerformed ( ) ) HibProcedure
        where date from HibProcedure.performed.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from HibProcedure.performed.earliest ( )
    )

//HepB


define "Hepatitis B Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)"]
      union [ConditionEncounterDiagnosis: "Hepatitis B"]
      union [ConditionProblemsHealthConcerns: "Hepatitis B"]
  ).verified ( ) ) HepBConditions
    where date from start of HepBConditions.prevalenceInterval ( ) during day of "First Two Years"

define "Three Hepatitis B Vaccinations":
  from
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination1,
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination2,
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination3
    where date from HepatitisBVaccination2.earliest ( ) 1 day or more after date from HepatitisBVaccination1.earliest ( )
      and date from HepatitisBVaccination3.earliest ( ) 1 day or more after date from HepatitisBVaccination2.earliest ( )
    return date from HepatitisBVaccination1.earliest ( )

define "Hepatitis B Immunizations or Procedures":
  ( ( ( [Immunization: "Hepatitis B Vaccine"] ).isImmunizationAdministered ( ) ) HepatitisBVaccination
      where date from HepatitisBVaccination.occurrence.earliest ( ) during day of "First Two Years"
      return date from HepatitisBVaccination.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Hepatitis B Vaccine Administered"] ).isProcedurePerformed ( ) ) HepatitisBProcedure
        where date from HepatitisBProcedure.performed.earliest ( ) during day of "First Two Years"
        return date from HepatitisBProcedure.performed.earliest ( )
    )

define "Meets HepB Vaccination Requirement":
  from
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination1,
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination2,
    "NewBorn Vaccine Requirement" NewBornVaccine3
    where date from HepatitisBVaccination2.earliest ( ) 1 day or more after date from HepatitisBVaccination1.earliest ( )
      and date from HepatitisBVaccination1.earliest ( ) 1 day or more after date from NewBornVaccine3.earliest ( )
      and date from HepatitisBVaccination2.earliest ( ) 1 day or more after date from NewBornVaccine3.earliest ( )
    return date from HepatitisBVaccination1.earliest ( )

define "NewBorn Vaccine Requirement":
  ( ( [Procedure: "Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach"] ).isProcedurePerformed ( ) ) NewBornVaccine
    where date from NewBornVaccine.performed.earliest ( ) during day of Interval[date from Patient.birthDate, date from Patient.birthDate + 7 days]
    return date from NewBornVaccine.performed.earliest ( )

//VZV


define "One Chicken Pox Vaccination":
  ( ( ( [Immunization: "Varicella Zoster Vaccine (VZV)"] ).isImmunizationAdministered ( ) ) ChickenPoxVaccination
      where date from ChickenPoxVaccination.occurrence.earliest ( ) during "Date of First Birthday to Date of Second Birthday"
      return date from ChickenPoxVaccination.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Varicella Zoster Vaccine (VZV) Administered"] ).isProcedurePerformed ( ) ) ChickenPoxProcedure
        where date from ChickenPoxProcedure.performed.earliest ( ) during "Date of First Birthday to Date of Second Birthday"
        return date from ChickenPoxProcedure.performed.earliest ( )
    )

define "Varicella Zoster Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Varicella Zoster"]
      union [ConditionProblemsHealthConcerns: "Varicella Zoster"]
      union [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)"]
  ).verified ( ) ) VaricellaZoster
    where date from start of VaricellaZoster.prevalenceInterval ( ) during day of "First Two Years"

//PCV


define "Four Pneumococcal Conjugate Vaccinations":
  from
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination1,
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination2,
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination3,
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination4
    where date from PneumococcalVaccination2.earliest ( ) 1 day or more after date from PneumococcalVaccination1.earliest ( )
      and date from PneumococcalVaccination3.earliest ( ) 1 day or more after date from PneumococcalVaccination2.earliest ( )
      and date from PneumococcalVaccination4.earliest ( ) 1 day or more after date from PneumococcalVaccination3.earliest ( )
    return date from PneumococcalVaccination1.earliest ( )

define "Pneumococcal Conjugate Immunizations or Procedures":
  ( ( ( [Immunization: "Pneumococcal Conjugate Vaccine"] ).isImmunizationAdministered ( ) ) PneumococcalVaccination
      where date from PneumococcalVaccination.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
      return date from PneumococcalVaccination.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Pneumococcal Conjugate Vaccine Administered"] ).isProcedurePerformed ( ) ) PneumococcalProcedure
        where date from PneumococcalProcedure.performed.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from PneumococcalProcedure.performed.earliest ( )
    )

define "Pneumococcal Conjugate Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)"]
  ).verified ( ) ) PneumococcalReaction
    where date from start of PneumococcalReaction.prevalenceInterval ( ) during day of "First Two Years"

//HepA


define "One Hepatitis A Vaccinations":
  ( ( ( [Immunization: "Hepatitis A Vaccine"] ).isImmunizationAdministered ( ) ) HepatitisAVaccination
      where date from HepatitisAVaccination.occurrence.earliest ( ) during "Date of First Birthday to Date of Second Birthday"
      return date from HepatitisAVaccination.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Hepatitis A Vaccine Administered"] ).isProcedurePerformed ( ) ) HepatitisAProcedure
        where date from HepatitisAProcedure.performed.earliest ( ) during "Date of First Birthday to Date of Second Birthday"
        return date from HepatitisAProcedure.performed.earliest ( )
    )

define "Hepatitis A Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Hepatitis A"]
      union [ConditionProblemsHealthConcerns: "Hepatitis A"]
      union [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)"]
  ).verified ( ) ) HepatitisADiagnosis
    where date from start of HepatitisADiagnosis.prevalenceInterval ( ) during day of "First Two Years"

//RV


define "Has Appropriate Number of Rotavirus Immunizations":
  exists ( "Rotavirus 2 or 3 Dose Immunizations" RotavirusImmunization
      let HasThreeDose: Count("Rotavirus 3 Dose Immunizations or Procedures") > 0
      where ( HasThreeDose
          and Count(distinct("Rotavirus 2 or 3 Dose Immunizations" RotavirusVaccinations
                return date from RotavirusVaccinations.earliest()
            )
          ) >= 3
      )
        or ( HasThreeDose is false
            and Count(distinct("Rotavirus 2 or 3 Dose Immunizations" RotavirusVaccinations
                  return date from RotavirusVaccinations.earliest()
              )
            ) >= 2
        )
  )

define "Rotavirus 2 Dose Immunizations or Procedures":
  ( ( ( [Immunization: "rotavirus, live, monovalent vaccine"] ).isImmunizationAdministered ( ) ) TwoDoseRotavirusVaccine
      where date from TwoDoseRotavirusVaccine.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
      return date from TwoDoseRotavirusVaccine.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Rotavirus Vaccine (2 dose schedule) Administered"] ).isProcedurePerformed ( ) ) TwoDoseRotavirusProcedure
        where date from TwoDoseRotavirusProcedure.performed.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from TwoDoseRotavirusProcedure.performed.earliest ( )
    )

define "Rotavirus 2 or 3 Dose Immunizations":
  "Rotavirus 2 Dose Immunizations or Procedures"
    union "Rotavirus 3 Dose Immunizations or Procedures"

define "Rotavirus Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylaxis caused by rotavirus vaccine (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by rotavirus vaccine (disorder)"]
  ).verified ( ) ) RotavirusConditions
    where date from start of RotavirusConditions.prevalenceInterval ( ) during day of "First Two Years"

define "Rotavirus 3 Dose Immunizations or Procedures":
  ( ( ( [Immunization: "Rotavirus Vaccine (3 dose schedule)"] ).isImmunizationAdministered ( ) ) ThreeDoseRotavirusVaccine
      where date from ThreeDoseRotavirusVaccine.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
      return date from ThreeDoseRotavirusVaccine.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Rotavirus Vaccine (3 dose schedule) Administered"] ).isProcedurePerformed ( ) ) ThreeDoseRotavirusAdministered
        where date from ThreeDoseRotavirusAdministered.performed.earliest ( ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from ThreeDoseRotavirusAdministered.performed.earliest ( )
    )

//Flu


define "Influenza Immunizations or Procedures":
  ( ( ( [Immunization: "Child Influenza Vaccine"] ).isImmunizationAdministered ( ) ) InfluenzaVaccine
      where date from InfluenzaVaccine.occurrence.earliest ( ) during day of "Vaccine Administration Interval - 180 Days up to 2 Years Old"
      return date from InfluenzaVaccine.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Child Influenza Vaccine Administered"] ).isProcedurePerformed ( ) ) InfluenzaAdministration
        where date from InfluenzaAdministration.performed.earliest ( ) during day of "Vaccine Administration Interval - 180 Days up to 2 Years Old"
        return date from InfluenzaAdministration.performed.earliest ( )
    )

define "Two Influenza Vaccinations":
  from
    "Influenza Immunizations or Procedures" FluVaccination1,
    "Influenza Immunizations or Procedures" FluVaccination2
    where date from FluVaccination2.earliest ( ) 1 day or more after date from FluVaccination1.earliest ( )
    return date from FluVaccination1.earliest ( )

define "Influenza Numerator Inclusion Conditions":
  ( ( [ConditionEncounterDiagnosis: "Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)"]
      union [ConditionProblemsHealthConcerns: "Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)"]
  ).verified ( ) ) InfluenzaConditions
    where date from start of InfluenzaConditions.prevalenceInterval ( ) during day of "First Two Years"

define "Two Influenza Vaccinations Including One LAIV Vaccination":
  exists "LAIV Vaccinations"
    and exists "Influenza Immunizations or Procedures"

define "LAIV Vaccinations":
  ( ( ( [Immunization: "Influenza Virus LAIV Vaccine"] ).isImmunizationAdministered ( ) ) LAIVVaccine
      where date from LAIVVaccine.occurrence.earliest ( ) during day of Interval["Date of Second Birthday", "Date of Second Birthday"]
      return date from LAIVVaccine.occurrence.earliest ( )
  )
    union ( ( ( [Procedure: "Influenza Virus LAIV Vaccine Administered"] ).isProcedurePerformed ( ) ) InfluenzaAdministration
        where date from InfluenzaAdministration.performed.earliest ( ) during day of Interval["Date of Second Birthday", "Date of Second Birthday"]
        return date from InfluenzaAdministration.performed.earliest ( )
    )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"