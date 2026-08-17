using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS117FHIRChildImmunStatus", "1.0.000")]
public partial class CMS117FHIRChildImmunStatus_1_0_000 : ILibrary, ISingleton<CMS117FHIRChildImmunStatus_1_0_000>
{
    #region ValueSets (44)

    [CqlValueSetDefinition("Anaphylactic Reaction to DTaP Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", valueSetVersion: null)]
    public CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine(CqlContext _) => _Anaphylactic_Reaction_to_DTaP_Vaccine;
    private static readonly CqlValueSet _Anaphylactic_Reaction_to_DTaP_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", null);

    [CqlValueSetDefinition("Disorders of the Immune System", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", valueSetVersion: null)]
    public CqlValueSet Disorders_of_the_Immune_System(CqlContext _) => _Disorders_of_the_Immune_System;
    private static readonly CqlValueSet _Disorders_of_the_Immune_System = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", null);

    [CqlValueSetDefinition("DTaP Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", valueSetVersion: null)]
    public CqlValueSet DTaP_Vaccine(CqlContext _) => _DTaP_Vaccine;
    private static readonly CqlValueSet _DTaP_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", null);

    [CqlValueSetDefinition("DTaP Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", valueSetVersion: null)]
    public CqlValueSet DTaP_Vaccine_Administered(CqlContext _) => _DTaP_Vaccine_Administered;
    private static readonly CqlValueSet _DTaP_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", null);

    [CqlValueSetDefinition("Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", valueSetVersion: null)]
    public CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(CqlContext _) => _Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine;
    private static readonly CqlValueSet _Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", null);

    [CqlValueSetDefinition("Hepatitis A", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A(CqlContext _) => _Hepatitis_A;
    private static readonly CqlValueSet _Hepatitis_A = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);

    [CqlValueSetDefinition("Hepatitis A Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A_Vaccine(CqlContext _) => _Hepatitis_A_Vaccine;
    private static readonly CqlValueSet _Hepatitis_A_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", null);

    [CqlValueSetDefinition("Hepatitis A Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", valueSetVersion: null)]
    public CqlValueSet Hepatitis_A_Vaccine_Administered(CqlContext _) => _Hepatitis_A_Vaccine_Administered;
    private static readonly CqlValueSet _Hepatitis_A_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", null);

    [CqlValueSetDefinition("Hepatitis B", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B(CqlContext _) => _Hepatitis_B;
    private static readonly CqlValueSet _Hepatitis_B = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", null);

    [CqlValueSetDefinition("Hepatitis B Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B_Vaccine(CqlContext _) => _Hepatitis_B_Vaccine;
    private static readonly CqlValueSet _Hepatitis_B_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", null);

    [CqlValueSetDefinition("Hepatitis B Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", valueSetVersion: null)]
    public CqlValueSet Hepatitis_B_Vaccine_Administered(CqlContext _) => _Hepatitis_B_Vaccine_Administered;
    private static readonly CqlValueSet _Hepatitis_B_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", null);

    [CqlValueSetDefinition("Hib Vaccine (3 dose schedule)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__3_dose_schedule_(CqlContext _) => _Hib_Vaccine__3_dose_schedule_;
    private static readonly CqlValueSet _Hib_Vaccine__3_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", null);

    [CqlValueSetDefinition("Hib Vaccine (3 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__3_dose_schedule__Administered(CqlContext _) => _Hib_Vaccine__3_dose_schedule__Administered;
    private static readonly CqlValueSet _Hib_Vaccine__3_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", null);

    [CqlValueSetDefinition("Hib Vaccine (4 dose schedule)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__4_dose_schedule_(CqlContext _) => _Hib_Vaccine__4_dose_schedule_;
    private static readonly CqlValueSet _Hib_Vaccine__4_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", null);

    [CqlValueSetDefinition("Hib Vaccine (4 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__4_dose_schedule__Administered(CqlContext _) => _Hib_Vaccine__4_dose_schedule__Administered;
    private static readonly CqlValueSet _Hib_Vaccine__4_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Inactivated Polio Vaccine (IPV)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", valueSetVersion: null)]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV_(CqlContext _) => _Inactivated_Polio_Vaccine__IPV_;
    private static readonly CqlValueSet _Inactivated_Polio_Vaccine__IPV_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", null);

    [CqlValueSetDefinition("Inactivated Polio Vaccine (IPV) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", valueSetVersion: null)]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered(CqlContext _) => _Inactivated_Polio_Vaccine__IPV__Administered;
    private static readonly CqlValueSet _Inactivated_Polio_Vaccine__IPV__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", null);

    [CqlValueSetDefinition("Child Influenza Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", valueSetVersion: null)]
    public CqlValueSet Child_Influenza_Vaccine(CqlContext _) => _Child_Influenza_Vaccine;
    private static readonly CqlValueSet _Child_Influenza_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", null);

    [CqlValueSetDefinition("Child Influenza Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", valueSetVersion: null)]
    public CqlValueSet Child_Influenza_Vaccine_Administered(CqlContext _) => _Child_Influenza_Vaccine_Administered;
    private static readonly CqlValueSet _Child_Influenza_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", null);

    [CqlValueSetDefinition("Influenza Virus LAIV Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", valueSetVersion: null)]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine(CqlContext _) => _Influenza_Virus_LAIV_Vaccine;
    private static readonly CqlValueSet _Influenza_Virus_LAIV_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", null);

    [CqlValueSetDefinition("Influenza Virus LAIV Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", valueSetVersion: null)]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine_Administered(CqlContext _) => _Influenza_Virus_LAIV_Vaccine_Administered;
    private static readonly CqlValueSet _Influenza_Virus_LAIV_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", null);

    [CqlValueSetDefinition("Intussusception", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", valueSetVersion: null)]
    public CqlValueSet Intussusception(CqlContext _) => _Intussusception;
    private static readonly CqlValueSet _Intussusception = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", null);

    [CqlValueSetDefinition("Malignant Neoplasm of Lymphatic and Hematopoietic Tissue", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(CqlContext _) => _Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue;
    private static readonly CqlValueSet _Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", null);

    [CqlValueSetDefinition("Measles", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", valueSetVersion: null)]
    public CqlValueSet Measles(CqlContext _) => _Measles;
    private static readonly CqlValueSet _Measles = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", null);

    [CqlValueSetDefinition("Measles, Mumps and Rubella (MMR) Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", valueSetVersion: null)]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine(CqlContext _) => _Measles__Mumps_and_Rubella__MMR__Vaccine;
    private static readonly CqlValueSet _Measles__Mumps_and_Rubella__MMR__Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", null);

    [CqlValueSetDefinition("Measles, Mumps and Rubella (MMR) Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", valueSetVersion: null)]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(CqlContext _) => _Measles__Mumps_and_Rubella__MMR__Vaccine_Administered;
    private static readonly CqlValueSet _Measles__Mumps_and_Rubella__MMR__Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", null);

    [CqlValueSetDefinition("Mumps", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", valueSetVersion: null)]
    public CqlValueSet Mumps(CqlContext _) => _Mumps;
    private static readonly CqlValueSet _Mumps = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pneumococcal Conjugate Vaccine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", valueSetVersion: null)]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine(CqlContext _) => _Pneumococcal_Conjugate_Vaccine;
    private static readonly CqlValueSet _Pneumococcal_Conjugate_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", null);

    [CqlValueSetDefinition("Pneumococcal Conjugate Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", valueSetVersion: null)]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered(CqlContext _) => _Pneumococcal_Conjugate_Vaccine_Administered;
    private static readonly CqlValueSet _Pneumococcal_Conjugate_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Rotavirus Vaccine (2 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered(CqlContext _) => _Rotavirus_Vaccine__2_dose_schedule__Administered;
    private static readonly CqlValueSet _Rotavirus_Vaccine__2_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", null);

    [CqlValueSetDefinition("Rotavirus Vaccine (3 dose schedule)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule_(CqlContext _) => _Rotavirus_Vaccine__3_dose_schedule_;
    private static readonly CqlValueSet _Rotavirus_Vaccine__3_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", null);

    [CqlValueSetDefinition("Rotavirus Vaccine (3 dose schedule) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered(CqlContext _) => _Rotavirus_Vaccine__3_dose_schedule__Administered;
    private static readonly CqlValueSet _Rotavirus_Vaccine__3_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", null);

    [CqlValueSetDefinition("Rubella", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", valueSetVersion: null)]
    public CqlValueSet Rubella(CqlContext _) => _Rubella;
    private static readonly CqlValueSet _Rubella = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", null);

    [CqlValueSetDefinition("Severe Combined Immunodeficiency", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", valueSetVersion: null)]
    public CqlValueSet Severe_Combined_Immunodeficiency(CqlContext _) => _Severe_Combined_Immunodeficiency;
    private static readonly CqlValueSet _Severe_Combined_Immunodeficiency = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Varicella Zoster", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster(CqlContext _) => _Varicella_Zoster;
    private static readonly CqlValueSet _Varicella_Zoster = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", null);

    [CqlValueSetDefinition("Varicella Zoster Vaccine (VZV)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV_(CqlContext _) => _Varicella_Zoster_Vaccine__VZV_;
    private static readonly CqlValueSet _Varicella_Zoster_Vaccine__VZV_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", null);

    [CqlValueSetDefinition("Varicella Zoster Vaccine (VZV) Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered(CqlContext _) => _Varicella_Zoster_Vaccine__VZV__Administered;
    private static readonly CqlValueSet _Varicella_Zoster_Vaccine__VZV__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", null);

    #endregion ValueSets

    #region Codes (12)

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)", codeId: "433621000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_ = new CqlCode("433621000124101", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)", codeId: "428321000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_ = new CqlCode("428321000124101", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by rotavirus vaccine (disorder)", codeId: "428331000124103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_rotavirus_vaccine__disorder_(CqlContext _) => _Anaphylaxis_caused_by_rotavirus_vaccine__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_rotavirus_vaccine__disorder_ = new CqlCode("428331000124103", "http://snomed.info/sct");

    [CqlCodeDefinition("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional", codeId: "99211", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext _) => _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;
    private static readonly CqlCode _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new CqlCode("99211", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("rotavirus, live, monovalent vaccine", codeId: "119", codeSystem: "http://hl7.org/fhir/sid/cvx")]
    public CqlCode rotavirus__live__monovalent_vaccine(CqlContext _) => _rotavirus__live__monovalent_vaccine;
    private static readonly CqlCode _rotavirus__live__monovalent_vaccine = new CqlCode("119", "http://hl7.org/fhir/sid/cvx");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)", codeId: "471311000124103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_ = new CqlCode("471311000124103", "http://snomed.info/sct");

    [CqlCodeDefinition("Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach", codeId: "3E0234Z", codeSystem: "http://www.cms.gov/Medicare/Coding/ICD10")]
    public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(CqlContext _) => _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach;
    private static readonly CqlCode _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach = new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)", codeId: "471361000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_ = new CqlCode("471361000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)", codeId: "471331000124109", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_ = new CqlCode("471331000124109", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)", codeId: "471141000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_ = new CqlCode("471141000124102", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)", codeId: "471321000124106", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_ = new CqlCode("471321000124106", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)", codeId: "471341000124104", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_ = new CqlCode("471341000124104", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (4)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_rotavirus_vaccine__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_]);

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional]);

    [CqlCodeSystemDefinition("CVX", codeSystemId: "http://hl7.org/fhir/sid/cvx", codeSystemVersion: null)]
    public CqlCodeSystem CVX(CqlContext _) => _CVX;
    private static readonly CqlCodeSystem _CVX =
      new CqlCodeSystem("http://hl7.org/fhir/sid/cvx", null, [
          _rotavirus__live__monovalent_vaccine]);

    [CqlCodeSystemDefinition("ICD10", codeSystemId: "http://www.cms.gov/Medicare/Coding/ICD10", codeSystemVersion: null)]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 =
      new CqlCodeSystem("http://www.cms.gov/Medicare/Coding/ICD10", null, [
          _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4169139436206072456L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS117FHIRChildImmunStatus-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (59)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3255434830720907340L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 3890715647931438728L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? m_(Encounter E) {
            List<CodeableConcept> y_ = E?.Type;

            CqlConcept z_(CodeableConcept @this) {
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ad_;
            }


            bool? aa_(CqlConcept T) {
                CqlCode ae_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
                bool? ag_ = context.Operators.Equivalent(T, af_);
                return ag_;
            }

            IEnumerable<CqlConcept> ab_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_, aa_);
            bool? ac_ = context.Operators.Exists<CqlConcept>(ab_);
            return ac_;
        }

        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
        CqlValueSet o_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(k_, q_);
        CqlValueSet s_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
        IEnumerable<Encounter> v_ = Status_1_15_000.Instance.isEncounterPerformed(context, u_);

        bool? w_(Encounter ValidEncounters) {
            CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
            Period ai_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            bool? ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, aj_, "day");
            return ak_;
        }

        IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);
        return x_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 1840103070889693489L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.Equal(h_, 2);
        // CQL 'and' (80:3-83:42): right operand skipped when left is false
        if (i_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> j_ = this.Qualifying_Encounters(context);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return i_ & k_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 6100922097112111507L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_of_Second_Birthday, Date_of_Second_Birthday_Compute);

    private const long _cacheIndex_Date_of_Second_Birthday = -8905780261144196986L;

    private CqlDate Date_of_Second_Birthday_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlQuantity g_ = context.Operators.Quantity(2m, "years");
        CqlDate h_ = context.Operators.Add(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Two_Years, First_Two_Years_Compute);

    private const long _cacheIndex_First_Two_Years = -5417161313911528722L;

    private CqlInterval<CqlDate> First_Two_Years_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlDate g_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> h_ = context.Operators.Interval(f_, g_, true, true);
        return h_;
    }


    [CqlExpressionDefinition("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Severe_Combined_Immunodeficiency, Has_Severe_Combined_Immunodeficiency_Compute);

    private const long _cacheIndex_Has_Severe_Combined_Immunodeficiency = 9038569657881816316L;

    private bool? Has_Severe_Combined_Immunodeficiency_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition SevereImmuneDisorder) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");
            return l_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Immunodeficiency, Has_Immunodeficiency_Compute);

    private const long _cacheIndex_Has_Immunodeficiency = -6514596558769833938L;

    private bool? Has_Immunodeficiency_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition ImmuneDisorder) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");
            return l_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has HIV")]
    public bool? Has_HIV(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_HIV, Has_HIV_Compute);

    private const long _cacheIndex_Has_HIV = 2919788375854472653L;

    private bool? Has_HIV_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.HIV(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition HIVDiagnosis) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HIVDiagnosis);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");
            return l_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia, Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia_Compute);

    private const long _cacheIndex_Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia = 8404119248587868221L;

    private bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition LymphaticMalignantNeoplasm) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");
            return l_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Intussusception, Has_Intussusception_Compute);

    private const long _cacheIndex_Has_Intussusception = 5536229043570992142L;

    private bool? Has_Intussusception_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Intussusception(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition IntussusceptionDisorder) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");
            return l_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4709410818624606766L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_;
        // CQL 'or' (104:3-105:45): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            bool? f_ = this.Has_Severe_Combined_Immunodeficiency(context);
            b_ = a_ | f_;
        }
        bool? c_;
        // CQL 'or' (104:3-106:29): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            bool? g_ = this.Has_Immunodeficiency(context);
            c_ = b_ | g_;
        }
        bool? d_;
        // CQL 'or' (104:3-107:16): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            bool? h_ = this.Has_HIV(context);
            d_ = c_ | h_;
        }
        bool? e_;
        // CQL 'or' (104:3-108:65): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? i_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
            e_ = d_ | i_;
        }
        // CQL 'or' (104:3-109:28): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            bool? j_ = this.Has_Intussusception(context);
            return e_ | j_;
        }
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old, Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old_Compute);

    private const long _cacheIndex_Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old = -2143539727822132663L;

    private CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlQuantity g_ = context.Operators.Quantity(42m, "days");
        CqlDate h_ = context.Operators.Add(f_, g_);
        CqlDate i_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> j_ = context.Operators.Interval(h_, i_, true, true);
        return j_;
    }


    [CqlExpressionDefinition("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_DTaP_Immunizations_or_Procedures, DTaP_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_DTaP_Immunizations_or_Procedures = 3604694627530575211L;

    private IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization DTaPVaccination) {
            DataType p_ = DTaPVaccination?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization DTaPVaccination) {
            DataType v_ = DTaPVaccination?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure DTaPProcedure) {
            DataType z_ = DTaPProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure DTaPProcedure) {
            DataType af_ = DTaPProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Four_DTaP_Vaccinations, Four_DTaP_Vaccinations_Compute);

    private const long _cacheIndex_Four_DTaP_Vaccinations = 6243834148034002710L;

    private IEnumerable<CqlDate> Four_DTaP_Vaccinations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> b_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);

        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? c_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? h_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
            return h_;
        }


        bool? d_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) {
            CqlDateTime i_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "day");
            CqlDate p_ = context.Operators.Add(n_, o_);
            bool? q_ = context.Operators.SameOrAfter(k_, p_, "day");
            bool? r_;
            // CQL 'and' (212:11-213:106): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                CqlDateTime s_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
                CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
                CqlDate u_ = context.Operators.DateFrom(t_);
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
                CqlDateTime w_ = context.Operators.Add(j_, o_);
                bool? x_ = context.Operators.SameOrAfter(v_, w_, "day");
                r_ = q_ & x_;
            }
            // CQL 'and' (212:5-214:106): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime y_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
                CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_);
                CqlDateTime ae_ = context.Operators.Add(ad_, o_);
                bool? af_ = context.Operators.SameOrAfter(ab_, ae_, "day");
                return r_ & af_;
            }
        }

        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> e_ = context.Operators.SelectWhere<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(b_, c_, d_);
        CqlDate f_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) => tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> g_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_DTaP_Numerator_Inclusion_Conditions, DTaP_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_DTaP_Numerator_Inclusion_Conditions = 3639701423704147375L;

    private IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlValueSet e_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> i_ = context.Operators.Union<Condition>(g_ as IEnumerable<Condition>, h_ as IEnumerable<Condition>);
        IEnumerable<Condition> j_ = Status_1_15_000.Instance.verified(context, i_);

        bool? k_(Condition DTaPConditions) {
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlInterval<CqlDate> p_ = this.First_Two_Years(context);
            bool? q_ = context.Operators.In<CqlDate>(o_, p_, "day");
            return q_;
        }

        IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
        return l_;
    }


    [CqlExpressionDefinition("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Polio_Immunizations_or_Procedures, Polio_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Polio_Immunizations_or_Procedures = 417576683605254862L;

    private IEnumerable<CqlDate> Polio_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization PolioVaccination) {
            DataType p_ = PolioVaccination?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization PolioVaccination) {
            DataType v_ = PolioVaccination?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure PolioProcedure) {
            DataType z_ = PolioProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure PolioProcedure) {
            DataType af_ = PolioProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Three_Polio_Vaccinations, Three_Polio_Vaccinations_Compute);

    private const long _cacheIndex_Three_Polio_Vaccinations = 4897392299194826373L;

    private IEnumerable<CqlDate> Three_Polio_Vaccinations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> b_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);

        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? c_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? h_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return h_;
        }


        bool? d_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv) {
            CqlDateTime i_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "day");
            CqlDate p_ = context.Operators.Add(n_, o_);
            bool? q_ = context.Operators.SameOrAfter(k_, p_, (string)default);
            // CQL 'and' (253:5-254:111): right operand skipped when left is false
            if (q_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
                CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                CqlDate u_ = context.Operators.Add(k_, o_);
                bool? v_ = context.Operators.SameOrAfter(t_, u_, (string)default);
                return q_ & v_;
            }
        }

        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> e_ = context.Operators.SelectWhere<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(b_, c_, d_);

        CqlDate f_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv) {
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Polio_Numerator_Inclusion_Conditions, Polio_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Polio_Numerator_Inclusion_Conditions = 7826064777224418101L;

    private IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition PolioConditions) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_of_First_Birthday, Date_of_First_Birthday_Compute);

    private const long _cacheIndex_Date_of_First_Birthday = 3716909235403770431L;

    private CqlDate Date_of_First_Birthday_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlQuantity g_ = context.Operators.Quantity(1m, "year");
        CqlDate h_ = context.Operators.Add(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_of_First_Birthday_to_Date_of_Second_Birthday, Date_of_First_Birthday_to_Date_of_Second_Birthday_Compute);

    private const long _cacheIndex_Date_of_First_Birthday_to_Date_of_Second_Birthday = 8282639147346491549L;

    private CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday_Compute(CqlContext context)
    {
        CqlDate a_ = this.Date_of_First_Birthday(context);
        CqlDate b_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);
        return c_;
    }


    [CqlExpressionDefinition("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_One_MMR_Vaccination, One_MMR_Vaccination_Compute);

    private const long _cacheIndex_One_MMR_Vaccination = 156261906265107921L;

    private IEnumerable<CqlDate> One_MMR_Vaccination_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization MMRVaccination) {
            DataType p_ = MMRVaccination?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, (string)default);
            return u_;
        }


        CqlDate e_(Immunization MMRVaccination) {
            DataType v_ = MMRVaccination?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure MMRProcedure) {
            DataType z_ = MMRProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, (string)default);
            return ae_;
        }


        CqlDate l_(Procedure MMRProcedure) {
            DataType af_ = MMRProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_MMR_Numerator_Inclusion_Conditions, MMR_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_MMR_Numerator_Inclusion_Conditions = -514019637682845694L;

    private IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition MMRConditions) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measles_Indicators, Measles_Indicators_Compute);

    private const long _cacheIndex_Measles_Indicators = 8441168455424622173L;

    private IEnumerable<Condition> Measles_Indicators_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Measles(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Union<Condition>(b_, b_);
        Condition d_(Condition X) => X as Condition;
        IEnumerable<Condition> e_ = context.Operators.Select<Condition, Condition>(c_, d_);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition MeaslesDiagnosis) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Mumps_Indicators, Mumps_Indicators_Compute);

    private const long _cacheIndex_Mumps_Indicators = -5597829872438947286L;

    private IEnumerable<Condition> Mumps_Indicators_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mumps(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition MumpsDiagnosis) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");
            return l_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Rubella_Indicators, Rubella_Indicators_Compute);

    private const long _cacheIndex_Rubella_Indicators = -7817904464631049752L;

    private IEnumerable<Condition> Rubella_Indicators_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Rubella(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        IEnumerable<Condition> e_ = Status_1_15_000.Instance.verified(context, d_);

        bool? f_(Condition RubellaDiagnosis) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");
            return l_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hib_3_Dose_Immunizations_or_Procedures, Hib_3_Dose_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Hib_3_Dose_Immunizations_or_Procedures = -2629041367058582986L;

    private IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization ThreeDoseHibVaccine) {
            DataType p_ = ThreeDoseHibVaccine?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization ThreeDoseHibVaccine) {
            DataType v_ = ThreeDoseHibVaccine?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure ThreeDoseHibProcedure) {
            DataType z_ = ThreeDoseHibProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure ThreeDoseHibProcedure) {
            DataType af_ = ThreeDoseHibProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hib_4_Dose_Immunizations_or_Procedures, Hib_4_Dose_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Hib_4_Dose_Immunizations_or_Procedures = -4666232502681983773L;

    private IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization HibVaccine) {
            DataType p_ = HibVaccine?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization HibVaccine) {
            DataType v_ = HibVaccine?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure HibProcedure) {
            DataType z_ = HibProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure HibProcedure) {
            DataType af_ = HibProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hib_3_or_4_Dose_Immunizations, Hib_3_or_4_Dose_Immunizations_Compute);

    private const long _cacheIndex_Hib_3_or_4_Dose_Immunizations = -674850233977361458L;

    private IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> b_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Appropriate_Number_of_Hib_Immunizations, Has_Appropriate_Number_of_Hib_Immunizations_Compute);

    private const long _cacheIndex_Has_Appropriate_Number_of_Hib_Immunizations = 5542750103430990637L;

    private bool? Has_Appropriate_Number_of_Hib_Immunizations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hib_3_or_4_Dose_Immunizations(context);

        bool? b_(CqlDate HibImmunization) {
            IEnumerable<CqlDate> d_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? e_ = context.Operators.Count<CqlDate>(d_);
            bool? f_ = context.Operators.Greater(e_, 0);
            bool? g_;
            // CQL 'and' (307:13-314:7): right operand skipped when left is false
            if (f_ is false)
            {
                g_ = false;
            }
            else
            {
                IEnumerable<CqlDate> h_ = this.Hib_3_or_4_Dose_Immunizations(context);

                CqlDate i_(CqlDate HibVaccinations) {
                    CqlDateTime n_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                    CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    return p_;
                }

                IEnumerable<CqlDate> j_ = context.Operators.SelectDistinct<CqlDate, CqlDate>(h_, i_);
                IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
                int? l_ = context.Operators.Count<CqlDate>(k_);
                bool? m_ = context.Operators.GreaterOrEqual(l_, 4);
                g_ = f_ & m_;
            }
            // CQL 'or' (307:7-322:9): right operand skipped when left is true
            if (g_ is true)
            {
                return true;
            }
            else
            {
                bool? q_ = context.Operators.IsFalse(f_);
                bool? r_;
                // CQL 'and' (315:12-322:9): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    IEnumerable<CqlDate> s_ = this.Hib_3_or_4_Dose_Immunizations(context);

                    CqlDate t_(CqlDate HibVaccinations) {
                        CqlDateTime y_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                        CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                        CqlDate aa_ = context.Operators.DateFrom(z_);
                        return aa_;
                    }

                    IEnumerable<CqlDate> u_ = context.Operators.SelectDistinct<CqlDate, CqlDate>(s_, t_);
                    IEnumerable<CqlDate> v_ = context.Operators.Distinct<CqlDate>(u_);
                    int? w_ = context.Operators.Count<CqlDate>(v_);
                    bool? x_ = context.Operators.GreaterOrEqual(w_, 3);
                    r_ = q_ & x_;
                }
                return g_ | r_;
            }
        }

        bool? c_ = context.Operators.WhereAny<CqlDate>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hib_Numerator_Inclusion_Conditions, Hib_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Hib_Numerator_Inclusion_Conditions = 8608192977694466541L;

    private IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition HibReaction) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hepatitis_B_Immunizations_or_Procedures, Hepatitis_B_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Hepatitis_B_Immunizations_or_Procedures = 1973141662449076015L;

    private IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization HepatitisBVaccination) {
            DataType p_ = HepatitisBVaccination?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.First_Two_Years(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization HepatitisBVaccination) {
            DataType v_ = HepatitisBVaccination?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure HepatitisBProcedure) {
            DataType z_ = HepatitisBProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.First_Two_Years(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure HepatitisBProcedure) {
            DataType af_ = HepatitisBProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Three_Hepatitis_B_Vaccinations, Three_Hepatitis_B_Vaccinations_Compute);

    private const long _cacheIndex_Three_Hepatitis_B_Vaccinations = 1495990690705974579L;

    private IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> b_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);

        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? c_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? h_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return h_;
        }


        bool? d_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw) {
            CqlDateTime i_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "day");
            CqlDate p_ = context.Operators.Add(n_, o_);
            bool? q_ = context.Operators.SameOrAfter(k_, p_, (string)default);
            // CQL 'and' (371:5-372:121): right operand skipped when left is false
            if (q_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
                CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                CqlDate u_ = context.Operators.Add(k_, o_);
                bool? v_ = context.Operators.SameOrAfter(t_, u_, (string)default);
                return q_ & v_;
            }
        }

        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> e_ = context.Operators.SelectWhere<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(b_, c_, d_);

        CqlDate f_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw) {
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_NewBorn_Vaccine_Requirement, NewBorn_Vaccine_Requirement_Compute);

    private const long _cacheIndex_NewBorn_Vaccine_Requirement = -5347679566276507507L;

    private IEnumerable<CqlDate> NewBorn_Vaccine_Requirement_Compute(CqlContext context)
    {
        CqlCode a_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_ = Status_1_15_000.Instance.isProcedurePerformed(context, c_);

        bool? e_(Procedure NewBornVaccine) {
            DataType i_ = NewBornVaccine?.Performed;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            Patient m_ = this.Patient(context);
            Date n_ = m_?.BirthDateElement;
            string o_ = n_?.Value;
            CqlDate p_ = context.Operators.ConvertStringToDate(o_);
            CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlQuantity s_ = context.Operators.Quantity(7m, "days");
            CqlDate t_ = context.Operators.Add(r_, s_);
            CqlInterval<CqlDate> u_ = context.Operators.Interval(r_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDate>(l_, u_, "day");
            return v_;
        }


        CqlDate f_(Procedure NewBornVaccine) {
            DataType w_ = NewBornVaccine?.Performed;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            return z_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.WhereSelect<Procedure, CqlDate>(d_, e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Meets_HepB_Vaccination_Requirement, Meets_HepB_Vaccination_Requirement_Compute);

    private const long _cacheIndex_Meets_HepB_Vaccination_Requirement = -1645875262351447058L;

    private IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> b_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, b_);

        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? d_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? i_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return i_;
        }


        bool? e_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg) {
            CqlDateTime j_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlQuantity p_ = context.Operators.Quantity(1m, "day");
            CqlDate q_ = context.Operators.Add(o_, p_);
            bool? r_ = context.Operators.SameOrAfter(l_, q_, (string)default);
            bool? s_;
            // CQL 'and' (390:11-391:114): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
                CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                CqlDate w_ = context.Operators.Add(v_, p_);
                bool? x_ = context.Operators.SameOrAfter(o_, w_, (string)default);
                s_ = r_ & x_;
            }
            // CQL 'and' (390:5-392:114): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime y_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
                CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                CqlDate ab_ = context.Operators.Add(aa_, p_);
                bool? ac_ = context.Operators.SameOrAfter(l_, ab_, (string)default);
                return s_ & ac_;
            }
        }

        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> f_ = context.Operators.SelectWhere<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(c_, d_, e_);

        CqlDate g_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg) {
            CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime ae_ = QICoreCommon_4_0_000.Instance.earliest(context, ad_);
            CqlDate af_ = context.Operators.DateFrom(ae_);
            return af_;
        }

        IEnumerable<CqlDate> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hepatitis_B_Numerator_Inclusion_Conditions, Hepatitis_B_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Hepatitis_B_Numerator_Inclusion_Conditions = 7662563679654604977L;

    private IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        CqlValueSet f_ = this.Hepatitis_B(context);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);
        IEnumerable<Condition> k_ = Status_1_15_000.Instance.verified(context, j_);

        bool? l_(Condition HepBConditions) {
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlInterval<CqlDate> q_ = this.First_Two_Years(context);
            bool? r_ = context.Operators.In<CqlDate>(p_, q_, "day");
            return r_;
        }

        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_One_Chicken_Pox_Vaccination, One_Chicken_Pox_Vaccination_Compute);

    private const long _cacheIndex_One_Chicken_Pox_Vaccination = -8423925841763101892L;

    private IEnumerable<CqlDate> One_Chicken_Pox_Vaccination_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization ChickenPoxVaccination) {
            DataType p_ = ChickenPoxVaccination?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, (string)default);
            return u_;
        }


        CqlDate e_(Immunization ChickenPoxVaccination) {
            DataType v_ = ChickenPoxVaccination?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure ChickenPoxProcedure) {
            DataType z_ = ChickenPoxProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, (string)default);
            return ae_;
        }


        CqlDate l_(Procedure ChickenPoxProcedure) {
            DataType af_ = ChickenPoxProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Varicella_Zoster_Numerator_Inclusion_Conditions, Varicella_Zoster_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Varicella_Zoster_Numerator_Inclusion_Conditions = -4280058124122922461L;

    private IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlCode e_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);
        IEnumerable<Condition> k_ = Status_1_15_000.Instance.verified(context, j_);

        bool? l_(Condition VaricellaZoster) {
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlInterval<CqlDate> q_ = this.First_Two_Years(context);
            bool? r_ = context.Operators.In<CqlDate>(p_, q_, "day");
            return r_;
        }

        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pneumococcal_Conjugate_Immunizations_or_Procedures, Pneumococcal_Conjugate_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Pneumococcal_Conjugate_Immunizations_or_Procedures = 4378322687267757945L;

    private IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization PneumococcalVaccination) {
            DataType p_ = PneumococcalVaccination?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization PneumococcalVaccination) {
            DataType v_ = PneumococcalVaccination?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure PneumococcalProcedure) {
            DataType z_ = PneumococcalProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure PneumococcalProcedure) {
            DataType af_ = PneumococcalProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Four_Pneumococcal_Conjugate_Vaccinations, Four_Pneumococcal_Conjugate_Vaccinations_Compute);

    private const long _cacheIndex_Four_Pneumococcal_Conjugate_Vaccinations = -4797540516230867295L;

    private IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> b_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);

        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? c_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? h_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
            return h_;
        }


        bool? d_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp) {
            CqlDateTime i_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "day");
            CqlDate p_ = context.Operators.Add(n_, o_);
            bool? q_ = context.Operators.SameOrAfter(k_, p_, (string)default);
            bool? r_;
            // CQL 'and' (430:11-431:125): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                CqlDateTime s_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
                CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
                CqlDate u_ = context.Operators.DateFrom(t_);
                CqlDate v_ = context.Operators.Add(k_, o_);
                bool? w_ = context.Operators.SameOrAfter(u_, v_, (string)default);
                r_ = q_ & w_;
            }
            // CQL 'and' (430:5-432:125): right operand skipped when left is false
            if (r_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime x_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlDate z_ = context.Operators.DateFrom(y_);
                CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
                CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
                CqlDate ac_ = context.Operators.DateFrom(ab_);
                CqlDate ad_ = context.Operators.Add(ac_, o_);
                bool? ae_ = context.Operators.SameOrAfter(z_, ad_, (string)default);
                return r_ & ae_;
            }
        }

        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> e_ = context.Operators.SelectWhere<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(b_, c_, d_);

        CqlDate f_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp) {
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            return ah_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pneumococcal_Conjugate_Numerator_Inclusion_Conditions, Pneumococcal_Conjugate_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Pneumococcal_Conjugate_Numerator_Inclusion_Conditions = -4666451470684867839L;

    private IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition PneumococcalReaction) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_One_Hepatitis_A_Vaccinations, One_Hepatitis_A_Vaccinations_Compute);

    private const long _cacheIndex_One_Hepatitis_A_Vaccinations = -8296023591192323560L;

    private IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization HepatitisAVaccination) {
            DataType p_ = HepatitisAVaccination?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, (string)default);
            return u_;
        }


        CqlDate e_(Immunization HepatitisAVaccination) {
            DataType v_ = HepatitisAVaccination?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure HepatitisAProcedure) {
            DataType z_ = HepatitisAProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, (string)default);
            return ae_;
        }


        CqlDate l_(Procedure HepatitisAProcedure) {
            DataType af_ = HepatitisAProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hepatitis_A_Numerator_Inclusion_Conditions, Hepatitis_A_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Hepatitis_A_Numerator_Inclusion_Conditions = 8952629932293432625L;

    private IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);
        CqlCode e_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> h_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);
        IEnumerable<Condition> k_ = Status_1_15_000.Instance.verified(context, j_);

        bool? l_(Condition HepatitisADiagnosis) {
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlInterval<CqlDate> q_ = this.First_Two_Years(context);
            bool? r_ = context.Operators.In<CqlDate>(p_, q_, "day");
            return r_;
        }

        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Rotavirus_2_Dose_Immunizations_or_Procedures, Rotavirus_2_Dose_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Rotavirus_2_Dose_Immunizations_or_Procedures = 7665404411040489453L;

    private IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlCode a_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Immunization> c_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> d_ = Status_1_15_000.Instance.isImmunizationAdministered(context, c_);

        bool? e_(Immunization TwoDoseRotavirusVaccine) {
            DataType q_ = TwoDoseRotavirusVaccine?.Occurrence;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_ as CqlDateTime);
            CqlDate t_ = context.Operators.DateFrom(s_);
            CqlInterval<CqlDate> u_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? v_ = context.Operators.In<CqlDate>(t_, u_, "day");
            return v_;
        }


        CqlDate f_(Immunization TwoDoseRotavirusVaccine) {
            DataType w_ = TwoDoseRotavirusVaccine?.Occurrence;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_ as CqlDateTime);
            CqlDate z_ = context.Operators.DateFrom(y_);
            return z_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.WhereSelect<Immunization, CqlDate>(d_, e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_15_000.Instance.isProcedurePerformed(context, j_);

        bool? l_(Procedure TwoDoseRotavirusProcedure) {
            DataType aa_ = TwoDoseRotavirusProcedure?.Performed;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlDateTime ac_ = QICoreCommon_4_0_000.Instance.earliest(context, ab_);
            CqlDate ad_ = context.Operators.DateFrom(ac_);
            CqlInterval<CqlDate> ae_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? af_ = context.Operators.In<CqlDate>(ad_, ae_, "day");
            return af_;
        }


        CqlDate m_(Procedure TwoDoseRotavirusProcedure) {
            DataType ag_ = TwoDoseRotavirusProcedure?.Performed;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.earliest(context, ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.WhereSelect<Procedure, CqlDate>(k_, l_, m_);
        IEnumerable<CqlDate> o_ = context.Operators.Distinct<CqlDate>(n_);
        IEnumerable<CqlDate> p_ = context.Operators.Union<CqlDate>(h_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Rotavirus_3_Dose_Immunizations_or_Procedures, Rotavirus_3_Dose_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Rotavirus_3_Dose_Immunizations_or_Procedures = -2704249126383813516L;

    private IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization ThreeDoseRotavirusVaccine) {
            DataType p_ = ThreeDoseRotavirusVaccine?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization ThreeDoseRotavirusVaccine) {
            DataType v_ = ThreeDoseRotavirusVaccine?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure ThreeDoseRotavirusAdministered) {
            DataType z_ = ThreeDoseRotavirusAdministered?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure ThreeDoseRotavirusAdministered) {
            DataType af_ = ThreeDoseRotavirusAdministered?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Rotavirus_2_or_3_Dose_Immunizations, Rotavirus_2_or_3_Dose_Immunizations_Compute);

    private const long _cacheIndex_Rotavirus_2_or_3_Dose_Immunizations = 5526688681713129333L;

    private IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> b_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Appropriate_Number_of_Rotavirus_Immunizations, Has_Appropriate_Number_of_Rotavirus_Immunizations_Compute);

    private const long _cacheIndex_Has_Appropriate_Number_of_Rotavirus_Immunizations = -5340818168674935883L;

    private bool? Has_Appropriate_Number_of_Rotavirus_Immunizations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);

        bool? b_(CqlDate RotavirusImmunization) {
            IEnumerable<CqlDate> d_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? e_ = context.Operators.Count<CqlDate>(d_);
            bool? f_ = context.Operators.Greater(e_, 0);
            bool? g_;
            // CQL 'and' (478:13-483:7): right operand skipped when left is false
            if (f_ is false)
            {
                g_ = false;
            }
            else
            {
                IEnumerable<CqlDate> h_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);

                CqlDate i_(CqlDate RotavirusVaccinations) {
                    CqlDateTime n_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                    CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    return p_;
                }

                IEnumerable<CqlDate> j_ = context.Operators.SelectDistinct<CqlDate, CqlDate>(h_, i_);
                IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
                int? l_ = context.Operators.Count<CqlDate>(k_);
                bool? m_ = context.Operators.GreaterOrEqual(l_, 3);
                g_ = f_ & m_;
            }
            // CQL 'or' (478:7-489:9): right operand skipped when left is true
            if (g_ is true)
            {
                return true;
            }
            else
            {
                bool? q_ = context.Operators.IsFalse(f_);
                bool? r_;
                // CQL 'and' (484:12-489:9): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    IEnumerable<CqlDate> s_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);

                    CqlDate t_(CqlDate RotavirusVaccinations) {
                        CqlDateTime y_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                        CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                        CqlDate aa_ = context.Operators.DateFrom(z_);
                        return aa_;
                    }

                    IEnumerable<CqlDate> u_ = context.Operators.SelectDistinct<CqlDate, CqlDate>(s_, t_);
                    IEnumerable<CqlDate> v_ = context.Operators.Distinct<CqlDate>(u_);
                    int? w_ = context.Operators.Count<CqlDate>(v_);
                    bool? x_ = context.Operators.GreaterOrEqual(w_, 2);
                    r_ = q_ & x_;
                }
                return g_ | r_;
            }
        }

        bool? c_ = context.Operators.WhereAny<CqlDate>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Rotavirus_Numerator_Inclusion_Conditions, Rotavirus_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Rotavirus_Numerator_Inclusion_Conditions = 5452965153709958714L;

    private IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition RotavirusConditions) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old, Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old_Compute);

    private const long _cacheIndex_Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old = 6360531842329858811L;

    private CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
        CqlDate f_ = context.Operators.DateFrom(e_);
        CqlQuantity g_ = context.Operators.Quantity(180m, "days");
        CqlDate h_ = context.Operators.Add(f_, g_);
        CqlDate i_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> j_ = context.Operators.Interval(h_, i_, true, true);
        return j_;
    }


    [CqlExpressionDefinition("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Influenza_Immunizations_or_Procedures, Influenza_Immunizations_or_Procedures_Compute);

    private const long _cacheIndex_Influenza_Immunizations_or_Procedures = 1828458576964917662L;

    private IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization InfluenzaVaccine) {
            DataType p_ = InfluenzaVaccine?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlInterval<CqlDate> t_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? u_ = context.Operators.In<CqlDate>(s_, t_, "day");
            return u_;
        }


        CqlDate e_(Immunization InfluenzaVaccine) {
            DataType v_ = InfluenzaVaccine?.Occurrence;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_ as CqlDateTime);
            CqlDate y_ = context.Operators.DateFrom(x_);
            return y_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure InfluenzaAdministration) {
            DataType z_ = InfluenzaAdministration?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            CqlDateTime ab_ = QICoreCommon_4_0_000.Instance.earliest(context, aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? ae_ = context.Operators.In<CqlDate>(ac_, ad_, "day");
            return ae_;
        }


        CqlDate l_(Procedure InfluenzaAdministration) {
            DataType af_ = InfluenzaAdministration?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            return ai_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_Influenza_Vaccinations, Two_Influenza_Vaccinations_Compute);

    private const long _cacheIndex_Two_Influenza_Vaccinations = -8964713766866174121L;

    private IEnumerable<CqlDate> Two_Influenza_Vaccinations_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> b_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);

        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? c_(ValueTuple<CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? h_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);
            return h_;
        }


        bool? d_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq) {
            CqlDateTime i_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime j_ = QICoreCommon_4_0_000.Instance.earliest(context, i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "day");
            CqlDate p_ = context.Operators.Add(n_, o_);
            bool? q_ = context.Operators.SameOrAfter(k_, p_, (string)default);
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> e_ = context.Operators.SelectWhere<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(b_, c_, d_);

        CqlDate f_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq) {
            CqlDateTime r_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            return t_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_LAIV_Vaccinations, LAIV_Vaccinations_Compute);

    private const long _cacheIndex_LAIV_Vaccinations = -941360384475517972L;

    private IEnumerable<CqlDate> LAIV_Vaccinations_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_15_000.Instance.isImmunizationAdministered(context, b_);

        bool? d_(Immunization LAIVVaccine) {
            DataType p_ = LAIVVaccine?.Occurrence;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlDateTime r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_ as CqlDateTime);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlDate t_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> u_ = context.Operators.Interval(t_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDate>(s_, u_, "day");
            return v_;
        }


        CqlDate e_(Immunization LAIVVaccine) {
            DataType w_ = LAIVVaccine?.Occurrence;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_ as CqlDateTime);
            CqlDate z_ = context.Operators.DateFrom(y_);
            return z_;
        }

        IEnumerable<CqlDate> f_ = context.Operators.WhereSelect<Immunization, CqlDate>(c_, d_, e_);
        IEnumerable<CqlDate> g_ = context.Operators.Distinct<CqlDate>(f_);
        CqlValueSet h_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> j_ = Status_1_15_000.Instance.isProcedurePerformed(context, i_);

        bool? k_(Procedure InfluenzaAdministration) {
            DataType aa_ = InfluenzaAdministration?.Performed;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlDateTime ac_ = QICoreCommon_4_0_000.Instance.earliest(context, ab_);
            CqlDate ad_ = context.Operators.DateFrom(ac_);
            CqlDate ae_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> af_ = context.Operators.Interval(ae_, ae_, true, true);
            bool? ag_ = context.Operators.In<CqlDate>(ad_, af_, "day");
            return ag_;
        }


        CqlDate l_(Procedure InfluenzaAdministration) {
            DataType ah_ = InfluenzaAdministration?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            return ak_;
        }

        IEnumerable<CqlDate> m_ = context.Operators.WhereSelect<Procedure, CqlDate>(j_, k_, l_);
        IEnumerable<CqlDate> n_ = context.Operators.Distinct<CqlDate>(m_);
        IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination, Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination_Compute);

    private const long _cacheIndex_Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination = -5305512655750921341L;

    private bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.LAIV_Vaccinations(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        // CQL 'and' (549:3-550:54): right operand skipped when left is false
        if (b_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<CqlDate> c_ = this.Influenza_Immunizations_or_Procedures(context);
            bool? d_ = context.Operators.Exists<CqlDate>(c_);
            return b_ & d_;
        }
    }


    [CqlExpressionDefinition("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Influenza_Numerator_Inclusion_Conditions, Influenza_Numerator_Inclusion_Conditions_Compute);

    private const long _cacheIndex_Influenza_Numerator_Inclusion_Conditions = 1126846549515768438L;

    private IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);
        IEnumerable<Condition> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(Condition InfluenzaConditions) {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");
            return m_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1317748112751385423L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Four_DTaP_Vaccinations(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        bool? c_;
        // CQL 'or' (147:3-149:3): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Condition> l_ = this.DTaP_Numerator_Inclusion_Conditions(context);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            c_ = b_ | m_;
        }
        bool? d_;
        // CQL 'and' (147:3-152:5): right operand skipped when left is false
        if (c_ is false)
        {
            d_ = false;
        }
        else
        {
            IEnumerable<CqlDate> n_ = this.Three_Polio_Vaccinations(context);
            bool? o_ = context.Operators.Exists<CqlDate>(n_);
            bool? p_;
            // CQL 'or' (150:9-152:5): right operand skipped when left is true
            if (o_ is true)
            {
                p_ = true;
            }
            else
            {
                IEnumerable<Condition> q_ = this.Polio_Numerator_Inclusion_Conditions(context);
                bool? r_ = context.Operators.Exists<Condition>(q_);
                p_ = o_ | r_;
            }
            d_ = c_ & p_;
        }
        bool? e_;
        // CQL 'and' (147:3-159:5): right operand skipped when left is false
        if (d_ is false)
        {
            e_ = false;
        }
        else
        {
            IEnumerable<CqlDate> s_ = this.One_MMR_Vaccination(context);
            bool? t_ = context.Operators.Exists<CqlDate>(s_);
            bool? u_;
            // CQL 'or' (153:11-154:58): right operand skipped when left is true
            if (t_ is true)
            {
                u_ = true;
            }
            else
            {
                IEnumerable<Condition> w_ = this.MMR_Numerator_Inclusion_Conditions(context);
                bool? x_ = context.Operators.Exists<Condition>(w_);
                u_ = t_ | x_;
            }
            bool? v_;
            // CQL 'or' (153:9-159:5): right operand skipped when left is true
            if (u_ is true)
            {
                v_ = true;
            }
            else
            {
                IEnumerable<Condition> y_ = this.Measles_Indicators(context);
                bool? z_ = context.Operators.Exists<Condition>(y_);
                bool? aa_;
                // CQL 'and' (155:14-156:45): right operand skipped when left is false
                if (z_ is false)
                {
                    aa_ = false;
                }
                else
                {
                    IEnumerable<Condition> ac_ = this.Mumps_Indicators(context);
                    bool? ad_ = context.Operators.Exists<Condition>(ac_);
                    aa_ = z_ & ad_;
                }
                bool? ab_;
                // CQL 'and' (155:12-158:9): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    IEnumerable<Condition> ae_ = this.Rubella_Indicators(context);
                    bool? af_ = context.Operators.Exists<Condition>(ae_);
                    ab_ = aa_ & af_;
                }
                v_ = u_ | ab_;
            }
            e_ = d_ & v_;
        }
        bool? f_;
        // CQL 'and' (147:3-162:5): right operand skipped when left is false
        if (e_ is false)
        {
            f_ = false;
        }
        else
        {
            bool? ag_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
            bool? ah_;
            // CQL 'or' (160:9-162:5): right operand skipped when left is true
            if (ag_ is true)
            {
                ah_ = true;
            }
            else
            {
                IEnumerable<Condition> ai_ = this.Hib_Numerator_Inclusion_Conditions(context);
                bool? aj_ = context.Operators.Exists<Condition>(ai_);
                ah_ = ag_ | aj_;
            }
            f_ = e_ & ah_;
        }
        bool? g_;
        // CQL 'and' (147:3-167:5): right operand skipped when left is false
        if (f_ is false)
        {
            g_ = false;
        }
        else
        {
            IEnumerable<CqlDate> ak_ = this.Three_Hepatitis_B_Vaccinations(context);
            bool? al_ = context.Operators.Exists<CqlDate>(ak_);
            bool? am_;
            // CQL 'or' (163:9-167:5): right operand skipped when left is true
            if (al_ is true)
            {
                am_ = true;
            }
            else
            {
                IEnumerable<CqlDate> an_ = this.Meets_HepB_Vaccination_Requirement(context);
                bool? ao_ = context.Operators.Exists<CqlDate>(an_);
                bool? ap_;
                // CQL 'or' (164:12-166:9): right operand skipped when left is true
                if (ao_ is true)
                {
                    ap_ = true;
                }
                else
                {
                    IEnumerable<Condition> aq_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
                    bool? ar_ = context.Operators.Exists<Condition>(aq_);
                    ap_ = ao_ | ar_;
                }
                am_ = al_ | ap_;
            }
            g_ = f_ & am_;
        }
        bool? h_;
        // CQL 'and' (147:3-170:5): right operand skipped when left is false
        if (g_ is false)
        {
            h_ = false;
        }
        else
        {
            IEnumerable<CqlDate> as_ = this.One_Chicken_Pox_Vaccination(context);
            bool? at_ = context.Operators.Exists<CqlDate>(as_);
            bool? au_;
            // CQL 'or' (168:9-170:5): right operand skipped when left is true
            if (at_ is true)
            {
                au_ = true;
            }
            else
            {
                IEnumerable<Condition> av_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
                bool? aw_ = context.Operators.Exists<Condition>(av_);
                au_ = at_ | aw_;
            }
            h_ = g_ & au_;
        }
        bool? i_;
        // CQL 'and' (147:3-173:5): right operand skipped when left is false
        if (h_ is false)
        {
            i_ = false;
        }
        else
        {
            IEnumerable<CqlDate> ax_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
            bool? ay_ = context.Operators.Exists<CqlDate>(ax_);
            bool? az_;
            // CQL 'or' (171:9-173:5): right operand skipped when left is true
            if (ay_ is true)
            {
                az_ = true;
            }
            else
            {
                IEnumerable<Condition> ba_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
                bool? bb_ = context.Operators.Exists<Condition>(ba_);
                az_ = ay_ | bb_;
            }
            i_ = h_ & az_;
        }
        bool? j_;
        // CQL 'and' (147:3-176:5): right operand skipped when left is false
        if (i_ is false)
        {
            j_ = false;
        }
        else
        {
            IEnumerable<CqlDate> bc_ = this.One_Hepatitis_A_Vaccinations(context);
            bool? bd_ = context.Operators.Exists<CqlDate>(bc_);
            bool? be_;
            // CQL 'or' (174:9-176:5): right operand skipped when left is true
            if (bd_ is true)
            {
                be_ = true;
            }
            else
            {
                IEnumerable<Condition> bf_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
                bool? bg_ = context.Operators.Exists<Condition>(bf_);
                be_ = bd_ | bg_;
            }
            j_ = i_ & be_;
        }
        bool? k_;
        // CQL 'and' (147:3-179:5): right operand skipped when left is false
        if (j_ is false)
        {
            k_ = false;
        }
        else
        {
            bool? bh_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
            bool? bi_;
            // CQL 'or' (177:9-179:5): right operand skipped when left is true
            if (bh_ is true)
            {
                bi_ = true;
            }
            else
            {
                IEnumerable<Condition> bj_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
                bool? bk_ = context.Operators.Exists<Condition>(bj_);
                bi_ = bh_ | bk_;
            }
            k_ = j_ & bi_;
        }
        // CQL 'and' (147:3-183:5): right operand skipped when left is false
        if (k_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<CqlDate> bl_ = this.Two_Influenza_Vaccinations(context);
            bool? bm_ = context.Operators.Exists<CqlDate>(bl_);
            bool? bn_;
            // CQL 'or' (180:11-181:74): right operand skipped when left is true
            if (bm_ is true)
            {
                bn_ = true;
            }
            else
            {
                bool? bp_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
                bn_ = bm_ | bp_;
            }
            bool? bo_;
            // CQL 'or' (180:9-183:5): right operand skipped when left is true
            if (bn_ is true)
            {
                bo_ = true;
            }
            else
            {
                IEnumerable<Condition> bq_ = this.Influenza_Numerator_Inclusion_Conditions(context);
                bool? br_ = context.Operators.Exists<Condition>(bq_);
                bo_ = bn_ | br_;
            }
            return k_ & bo_;
        }
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 524785351674798207L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -9208410771258428013L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 1692700376086300175L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5331407242333771865L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS117FHIRChildImmunStatus_1_0_000() {}

    public static CMS117FHIRChildImmunStatus_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS117FHIRChildImmunStatus";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ = new(
       [typeof(CqlDate), typeof(CqlDate)],
       ["FluVaccination1", "FluVaccination2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["PolioVaccination1", "PolioVaccination2", "PolioVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["PneumococcalVaccination1", "PneumococcalVaccination2", "PneumococcalVaccination3", "PneumococcalVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["DTaPVaccination1", "DTaPVaccination2", "DTaPVaccination3", "DTaPVaccination4"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["HepatitisBVaccination1", "HepatitisBVaccination2", "HepatitisBVaccination3"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg = new(
       [typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)],
       ["HepatitisBVaccination1", "HepatitisBVaccination2", "NewBornVaccine3"]);

    #endregion CqlTupleMetadata Properties

}
