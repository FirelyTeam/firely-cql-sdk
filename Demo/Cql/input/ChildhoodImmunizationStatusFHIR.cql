library ChildhoodImmunizationStatusFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include Hospice version '6.9.000' called Hospice
include Status version '1.6.000' called Status
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "CPT": 'http://www.ama-assn.org/go/cpt'
codesystem "CVX": 'http://hl7.org/fhir/sid/cvx'
codesystem "ICD10": 'http://www.cms.gov/Medicare/Coding/ICD10'

valueset "Anaphylactic Reaction to DTaP Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031'
valueset "Disorders of the Immune System": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001'
valueset "DTaP Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214'
valueset "DTaP Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022'
valueset "Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Haemophilus Influenzae Type B (Hib) Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043'
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
valueset "Hospice care ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15'
valueset "Inactivated Polio Vaccine (IPV)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219'
valueset "Inactivated Polio Vaccine (IPV) Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045'
valueset "Child Influenza Immunization Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218'
valueset "Child Influenza Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044'
valueset "Influenza Virus LAIV Immunization": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087'
valueset "Influenza Virus LAIV Procedure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088'
valueset "Intussusception": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056'
valueset "Malignant Neoplasm of Lymphatic and Hematopoietic Tissue": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009'
valueset "Measles": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053'
valueset "Measles, Mumps and Rubella (MMR) Vaccine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224'
valueset "Measles, Mumps and Rubella (MMR) Vaccine Administered": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031'
valueset "Mumps": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
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

code "Anaphylaxis due to Haemophilus influenzae type b vaccine (disorder)": '433621000124101' from "SNOMEDCT" display 'Anaphylaxis due to Haemophilus influenzae type b vaccine (disorder)'
code "Anaphylaxis due to Hepatitis B vaccine (disorder)": '428321000124101' from "SNOMEDCT" display 'Anaphylaxis due to Hepatitis B vaccine (disorder)'
code "Anaphylaxis due to rotavirus vaccine (disorder)": '428331000124103' from "SNOMEDCT" display 'Anaphylaxis due to rotavirus vaccine (disorder)'
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
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) = 2
    and exists ( "Qualifying Encounters" )

define "Qualifying Encounters":
  ( Status."Finished Encounter" ( [Encounter: "Office Visit"]
    union [Encounter: "Home Healthcare Services"]
    union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
    union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
    union ( [Encounter] E
        where exists ( ( E.type ) T
            where T ~ "Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional"
        )
    )
    union [Encounter: "Online Assessments"]
    union [Encounter: "Telephone Visits"] ) ) ValidEncounters
    where QICoreCommon."ToInterval" ( ValidEncounters.period ) during day of "Measurement Period"

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
  exists ( ( Status."Active Condition" ( [Condition: "Severe Combined Immunodeficiency"] ) ) SevereImmuneDisorder
      where date from start of QICoreCommon."ToPrevalenceInterval" ( SevereImmuneDisorder ) during day of "First Two Years"
  )

define "Has Immunodeficiency":
  exists ( ( Status."Active Condition" ( [Condition: "Disorders of the Immune System"] ) ) ImmuneDisorder
      where date from start of QICoreCommon."ToPrevalenceInterval" ( ImmuneDisorder ) during day of "First Two Years"
  )

define "Has HIV":
  exists ( ( Status."Active Condition" ( [Condition: "HIV"] ) ) HIV
      where date from start of QICoreCommon."ToPrevalenceInterval" ( HIV ) during day of "First Two Years"
  )

define "Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia":
  exists ( ( Status."Active Condition" ( [Condition: "Malignant Neoplasm of Lymphatic and Hematopoietic Tissue"] ) ) LymphaticMalignantNeoplasm
      where date from start of QICoreCommon."ToPrevalenceInterval" ( LymphaticMalignantNeoplasm ) during day of "First Two Years"
  )

define "Has Intussusception":
  exists ( ( Status."Active Condition" ( [Condition: "Intussusception"] ) ) IntussusceptionDisorder
      where date from start of QICoreCommon."ToPrevalenceInterval" ( IntussusceptionDisorder ) during day of "First Two Years"
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
  Patient.birthDate + 2 years

define "Date of First Birthday":
  date from Patient.birthDate + 1 year

define "Date of First Birthday to Date of Second Birthday":
  Interval["Date of First Birthday", "Date of Second Birthday"]

define "Four DTaP Vaccinations":
  from
    "DTaP Immunizations or Procedures" DTaPVaccination1,
    "DTaP Immunizations or Procedures" DTaPVaccination2,
    "DTaP Immunizations or Procedures" DTaPVaccination3,
    "DTaP Immunizations or Procedures" DTaPVaccination4
    where DTaPVaccination2 1 day or more after day of DTaPVaccination1
      and DTaPVaccination3 1 day or more after day of DTaPVaccination2
      and DTaPVaccination4 1 day or more after day of DTaPVaccination3
    return all DTaPVaccination1

define "DTaP Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Anaphylactic Reaction to DTaP Vaccine"]
    union [Condition: "Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine"] ) ) DTaPConditions
    where date from start of QICoreCommon."ToPrevalenceInterval" ( DTaPConditions ) during day of "First Two Years"

define "DTaP Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "DTaP Vaccine"] ) ) DTaPVaccination
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( DTaPVaccination.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return all date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( DTaPVaccination.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "DTaP Vaccine Administered"] ) ) DTaPProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( DTaPProcedure.performed ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
          return all date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( DTaPProcedure.performed ) )
      )
  )

define "Polio Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Inactivated Polio Vaccine (IPV)"] ) ) PolioVaccination
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PolioVaccination.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PolioVaccination.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Inactivated Polio Vaccine (IPV) Administered"] ) ) PolioProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PolioProcedure.performed ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PolioProcedure.performed ) )
      )
  )

define "Three Polio Vaccinations":
  from
    "Polio Immunizations or Procedures" PolioVaccination1,
    "Polio Immunizations or Procedures" PolioVaccination2,
    "Polio Immunizations or Procedures" PolioVaccination3
    where PolioVaccination2 1 day or more after day of PolioVaccination1
      and PolioVaccination3 1 day or more after day of PolioVaccination2
    return PolioVaccination1

define "Polio Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)"] ) ) PolioConditions
    where date from start of QICoreCommon."ToPrevalenceInterval" ( PolioConditions ) during day of "First Two Years"

define "One MMR Vaccination":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Measles, Mumps and Rubella (MMR) Vaccine"] ) ) MMRVaccination
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( MMRVaccination.occurrence ) ) during "Date of First Birthday to Date of Second Birthday"
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Measles, Mumps and Rubella (MMR) Vaccine Administered"] ) ) MMRProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( MMRProcedure.performed ) ) during "Date of First Birthday to Date of Second Birthday"
      )
  )

define "Measles Indicators":
  ( Status."Active Condition" ( [Condition: "Measles"] ) ) MeaslesDiagnosis
    where date from start of QICoreCommon."ToPrevalenceInterval" ( MeaslesDiagnosis ) during day of "First Two Years"

define "Mumps Indicators":
  ( Status."Active Condition" ( [Condition: "Mumps"] ) ) MumpsDiagnosis
    where date from start of QICoreCommon."ToPrevalenceInterval" ( MumpsDiagnosis ) during day of "First Two Years"

define "Rubella Indicators":
  ( ( Status."Active Condition" ( [Condition: "Rubella"] ) ) RubellaDiagnosis
      where date from start of QICoreCommon."ToPrevalenceInterval" ( RubellaDiagnosis ) during day of "First Two Years"
  )

define "MMR Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)"] ) ) MMRConditions
    where date from start of QICoreCommon."ToPrevalenceInterval" ( MMRConditions ) during day of "First Two Years"

define "Has Appropriate Number of Hib Immunizations":
  exists ( "All Hib Vaccinations" HibImmunization //union of 3 and 4 dose immunizations
//4 dose test
      
      
      let HasFourDose: Count("Hib 4 Dose Immunizations or Procedures") > 0
      where ( HasFourDose //if pt had at least one 4 dose code
          
          and Count(distinct("All Hib Vaccinations" HibVaccinations
                return HibVaccinations
            )
          ) >= 4 //pt must have 4 regimens (e.g., 3,3,4,4 or 4,3,4,4)
      
      )
        or ( HasFourDose is false //if pt did not have at least one 4 dose code
            
            and Count(distinct("All Hib Vaccinations" HibVaccinations
                  return HibVaccinations
              )
            ) >= 3 //pt must have 3 regimens of 3 dose codes
        
        )
  )

define "All Hib Vaccinations":
  "Hib 3 or 4 Dose Immunizations" AllHibDoses1
    without "Hib 3 or 4 Dose Immunizations" AllHibDoses2
      such that AllHibDoses1 less than 1 day before AllHibDoses2

define "Hib Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Anaphylaxis due to Haemophilus influenzae type b vaccine (disorder)"] ) ) HibReaction
    where date from start of QICoreCommon."ToPrevalenceInterval" ( HibReaction ) during day of "First Two Years"

define "Hib 3 Dose Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Hib Vaccine (3 dose schedule)"] ) ) ThreeDoseHibVaccine
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseHibVaccine.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseHibVaccine.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Hib Vaccine (3 dose schedule) Administered"] ) ) ThreeDoseHibProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseHibProcedure.performed ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseHibProcedure.performed ) )
      )
  )

define "Hib 3 or 4 Dose Immunizations":
  "Hib 3 Dose Immunizations or Procedures"
    union "Hib 4 Dose Immunizations or Procedures"

define "Hib 4 Dose Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Hib Vaccine (4 dose schedule)"] ) ) HibVaccine
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HibVaccine.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HibVaccine.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Hib Vaccine (4 dose schedule) Administered"] ) ) HibProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HibProcedure.performed ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HibProcedure.performed ) )
      )
  )

define "Hepatitis B Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Anaphylaxis due to Hepatitis B vaccine (disorder)"]
    union [Condition: "Hepatitis B"] ) ) HepBConditions
    where date from start of QICoreCommon."ToPrevalenceInterval" ( HepBConditions ) during day of "First Two Years"

define "Three Hepatitis B Vaccinations":
  from
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination1,
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination2,
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination3
    where HepatitisBVaccination2 1 day or more after day of HepatitisBVaccination1
      and HepatitisBVaccination3 1 day or more after day of HepatitisBVaccination2
    return HepatitisBVaccination1

define "Hepatitis B Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Hepatitis B Vaccine"] ) ) HepatitisBVaccination
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HepatitisBVaccination.occurrence ) ) during day of "First Two Years"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HepatitisBVaccination.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Hepatitis B Vaccine Administered"] ) ) HepatitisBProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HepatitisBProcedure.performed ) ) during day of "First Two Years"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HepatitisBProcedure.performed ) )
      )
  )

define "Meets HepB Vaccination Requirement":
  from
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination1,
    "Hepatitis B Immunizations or Procedures" HepatitisBVaccination2,
    "NewBorn Vaccine Requirement" NewBornVaccine3
    where HepatitisBVaccination2 1 day or more after day of HepatitisBVaccination1
      and HepatitisBVaccination1 1 day or more after day of NewBornVaccine3
      and HepatitisBVaccination2 1 day or more after day of NewBornVaccine3
    return HepatitisBVaccination1

define "NewBorn Vaccine Requirement":
  ( Status."Completed Procedure" ( [Procedure: "Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach"] ) ) NewBornVaccine
    where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( NewBornVaccine.performed ) ) during day of Interval[date from Patient.birthDate, date from Patient.birthDate + 7 days]
    return date from start of QICoreCommon."ToInterval" ( NewBornVaccine.performed )

define "One Chicken Pox Vaccination":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Varicella Zoster Vaccine (VZV)"] ) ) ChickenPoxVaccination
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ChickenPoxVaccination.occurrence ) ) during "Date of First Birthday to Date of Second Birthday"
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Varicella Zoster Vaccine (VZV) Administered"] ) ) ChickenPoxProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ChickenPoxProcedure.performed ) ) during "Date of First Birthday to Date of Second Birthday"
      )
  )

define "Varicella Zoster Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Varicella Zoster"]
    union [Condition: "Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)"] ) ) VaricellaZoster
    where date from start of QICoreCommon."ToPrevalenceInterval" ( VaricellaZoster ) during day of "First Two Years"

define "Four Pneumococcal Conjugate Vaccinations":
  from
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination1,
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination2,
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination3,
    "Pneumococcal Conjugate Immunizations or Procedures" PneumococcalVaccination4
    where PneumococcalVaccination2 1 day or more after day of PneumococcalVaccination1
      and PneumococcalVaccination3 1 day or more after day of PneumococcalVaccination2
      and PneumococcalVaccination4 1 day or more after day of PneumococcalVaccination3
    return PneumococcalVaccination1

define "Pneumococcal Conjugate Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Pneumococcal Conjugate Vaccine"] ) ) PneumococcalVaccination
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PneumococcalVaccination.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PneumococcalVaccination.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Pneumococcal Conjugate Vaccine Administered"] ) ) PneumococcalProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PneumococcalProcedure.performed ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( PneumococcalProcedure.performed ) )
      )
  )

define "Pneumococcal Conjugate Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)"] ) ) PneumococcalReaction
    where date from start of QICoreCommon."ToPrevalenceInterval" ( PneumococcalReaction ) during day of "First Two Years"

define "One Hepatitis A Vaccinations":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Hepatitis A Vaccine"] ) ) HepatitisAVaccination
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HepatitisAVaccination.occurrence ) ) during "Date of First Birthday to Date of Second Birthday"
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Hepatitis A Vaccine Administered"] ) ) HepatitisAProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( HepatitisAProcedure.performed ) ) during "Date of First Birthday to Date of Second Birthday"
      )
  )

define "Hepatitis A Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Hepatitis A"]
    union [Condition: "Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)"] ) ) HepatitisADiagnosis
    where date from start of QICoreCommon."ToPrevalenceInterval" ( HepatitisADiagnosis ) during day of "First Two Years"

define "Has Appropriate Number of Rotavirus Immunizations":
  exists ( "All Rotavirus Vaccinations" RotavirusImmunization
      let HasThreeDose: Count("Rotavirus 3 Dose Immunizations or Procedures") > 0
      where ( HasThreeDose
          and Count(distinct("All Rotavirus Vaccinations" RotavirusVaccinations
                return RotavirusVaccinations
            )
          ) >= 3
      )
        or ( HasThreeDose is false
            and Count(distinct("All Rotavirus Vaccinations" RotavirusVaccinations
                  return RotavirusVaccinations
              )
            ) >= 2
        )
  )

define "All Rotavirus Vaccinations":
  "Rotavirus 2 or 3 Dose Immunizations" AllRotavirusDoses1
    without "Rotavirus 2 or 3 Dose Immunizations" AllRotavirusDoses2
      such that AllRotavirusDoses1 less than 1 day before AllRotavirusDoses2

define "Rotavirus 2 Dose Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "rotavirus, live, monovalent vaccine"] ) ) TwoDoseRotavirusVaccine
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( TwoDoseRotavirusVaccine.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( TwoDoseRotavirusVaccine.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Rotavirus Vaccine (2 dose schedule) Administered"] ) ) TwoDoseRotavirusProcedure
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( TwoDoseRotavirusProcedure.performed ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( TwoDoseRotavirusProcedure.performed ) )
      )
  )

define "Rotavirus 2 or 3 Dose Immunizations":
  "Rotavirus 2 Dose Immunizations or Procedures"
    union "Rotavirus 3 Dose Immunizations or Procedures"

define "Rotavirus Numerator Inclusion Conditions":
  ( ( Status."Active Condition" ( [Condition: "Anaphylaxis due to rotavirus vaccine (disorder)"] ) ) RotavirusConditions
      where date from start of QICoreCommon."ToPrevalenceInterval" ( RotavirusConditions ) during day of "First Two Years"
  )

define "Rotavirus 3 Dose Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Rotavirus Vaccine (3 dose schedule)"] ) ) ThreeDoseRotavirusVaccine
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseRotavirusVaccine.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseRotavirusVaccine.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Rotavirus Vaccine (3 dose schedule) Administered"] ) ) ThreeDoseRotavirusAdministered
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseRotavirusAdministered.performed ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( ThreeDoseRotavirusAdministered.performed ) )
      )
  )

define "Influenza Immunizations or Procedures":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Child Influenza Immunization Administered"] ) ) InfluenzaVaccine
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( InfluenzaVaccine.occurrence ) ) during day of "Vaccine Administration Interval - 42 Days up to 2 Years Old"
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( InfluenzaVaccine.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Child Influenza Vaccine Administered"] ) ) InfluenzaAdministration
          where QICoreCommon."ToInterval" ( InfluenzaAdministration.performed ) during day of "Vaccine Administration Interval - 180 Days up to 2 Years Old"
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( InfluenzaAdministration.performed ) )
      )
  )

define "Two Influenza Vaccinations":
  from
    "Influenza Immunizations or Procedures" FluVaccination1,
    "Influenza Immunizations or Procedures" FluVaccination2
    where FluVaccination2 1 day or more after day of FluVaccination1
    return FluVaccination1

define "Influenza Numerator Inclusion Conditions":
  ( Status."Active Condition" ( [Condition: "Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)"] ) ) InfluenzaConditions
    where date from start of QICoreCommon."ToPrevalenceInterval" ( InfluenzaConditions ) during day of "First Two Years"

define "Two Influenza Vaccinations Including One LAIV Vaccination":
  exists "LAIV Vaccinations"
    and exists "Influenza Immunizations or Procedures"

define "LAIV Vaccinations":
  ( ( ( Status."Completed Immunization" ( [Immunization: "Influenza Virus LAIV Immunization"] ) ) LAIVVaccine
        where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( LAIVVaccine.occurrence ) ) during day of Interval["Date of Second Birthday", "Date of Second Birthday"]
        return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( LAIVVaccine.occurrence ) )
    )
      union ( ( Status."Completed Procedure" ( [Procedure: "Influenza Virus LAIV Procedure"] ) ) InfluenzaAdministration
          where CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( InfluenzaAdministration.performed ) ) during day of Interval["Date of Second Birthday", "Date of Second Birthday"]
          return date from start of CQMCommon."ToDateInterval" ( QICoreCommon."ToInterval" ( InfluenzaAdministration.performed ) )
      )
  )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"