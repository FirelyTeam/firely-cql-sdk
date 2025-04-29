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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("ChildhoodImmunizationStatusFHIR", "0.1.000")]
public partial class ChildhoodImmunizationStatusFHIR_0_1_000 : ILibrary, ISingleton<ChildhoodImmunizationStatusFHIR_0_1_000>
{
    private ChildhoodImmunizationStatusFHIR_0_1_000() {}

    public static ChildhoodImmunizationStatusFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "ChildhoodImmunizationStatusFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    [CqlValueSetDefinition("Haemophilus Influenzae Type B (Hib) Vaccine Administered", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043", valueSetVersion: null)]
    public CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered(CqlContext _) => _Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered;
    private static readonly CqlValueSet _Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043", null);

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

    [CqlValueSetDefinition("Hospice care ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext _) => _Hospice_care_ambulatory;
    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

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

    #region Codes

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)", codeId: "433621000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_ = new CqlCode("433621000124101", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)", codeId: "428321000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_ = new CqlCode("428321000124101", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Anaphylaxis due to rotavirus vaccine (disorder)", codeId: "428331000124103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder_(CqlContext _) => _Anaphylaxis_due_to_rotavirus_vaccine__disorder_;
    private static readonly CqlCode _Anaphylaxis_due_to_rotavirus_vaccine__disorder_ = new CqlCode("428331000124103", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional", codeId: "99211", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext _) => _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;
    private static readonly CqlCode _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("rotavirus, live, monovalent vaccine", codeId: "119", codeSystem: "http://hl7.org/fhir/sid/cvx")]
    public CqlCode rotavirus__live__monovalent_vaccine(CqlContext _) => _rotavirus__live__monovalent_vaccine;
    private static readonly CqlCode _rotavirus__live__monovalent_vaccine = new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default);

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)", codeId: "471311000124103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_ = new CqlCode("471311000124103", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach", codeId: "3E0234Z", codeSystem: "http://www.cms.gov/Medicare/Coding/ICD10")]
    public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(CqlContext _) => _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach;
    private static readonly CqlCode _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach = new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default);

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)", codeId: "471361000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_ = new CqlCode("471361000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)", codeId: "471331000124109", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_ = new CqlCode("471331000124109", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)", codeId: "471141000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_ = new CqlCode("471141000124102", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)", codeId: "471321000124106", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_ = new CqlCode("471321000124106", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)", codeId: "471341000124104", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_ = new CqlCode("471341000124104", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("CVX")]
    public CqlCodeSystem CVX(CqlContext _) => _CVX;
    private static readonly CqlCodeSystem _CVX = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10")]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter E)
        {
            List<CodeableConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = E?.Type;
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(CqlConcept T)
            {
                CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isEncounterPerformed(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "year");
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, 2);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounters(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Initial_Population(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(2m, "years");
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition SevereImmuneDisorder)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition ImmuneDisorder)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.First_Two_Years(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has HIV")]
    public bool? Has_HIV(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.HIV(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition HIV)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition LymphaticMalignantNeoplasm)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Intussusception(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition IntussusceptionDisorder)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Severe_Combined_Immunodeficiency(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Has_Immunodeficiency(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_HIV(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Has_Intussusception(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(42m, "days");
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isImmunizationAdministered(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Immunization DTaPVaccination)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = DTaPVaccination?.Occurrence;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "value");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Immunization> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Immunization>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Immunization DTaPVaccination)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = DTaPVaccination?.Occurrence;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "value");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Immunization, CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure DTaPProcedure)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = DTaPProcedure?.Performed;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure DTaPProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = DTaPProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
        {
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrAfter(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrAfter(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SameOrAfter(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) =>
            tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition DTaPConditions)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.First_Two_Years(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isImmunizationAdministered(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Immunization PolioVaccination)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = PolioVaccination?.Occurrence;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "value");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Immunization>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Immunization PolioVaccination)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = PolioVaccination?.Occurrence;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "value");
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.Earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Immunization, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure PolioProcedure)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PolioProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure PolioProcedure)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = PolioProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1m, "day");
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameOrAfter(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SameOrAfter(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition PolioConditions)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.First_Two_Years(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "year");
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context)
    {
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_of_First_Birthday(context);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isImmunizationAdministered(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Immunization MMRVaccination)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = MMRVaccination?.Occurrence;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "value");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Immunization>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Immunization MMRVaccination)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = MMRVaccination?.Occurrence;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "value");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Immunization, CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure MMRProcedure)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = MMRProcedure?.Performed;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure MMRProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = MMRProcedure?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition MMRConditions)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.First_Two_Years(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measles(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition MeaslesDiagnosis)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.First_Two_Years(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Mumps(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition MumpsDiagnosis)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.First_Two_Years(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Rubella(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition RubellaDiagnosis)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Two_Years(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isImmunizationAdministered(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Immunization ThreeDoseHibVaccine)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "value");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Immunization> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Immunization>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Immunization ThreeDoseHibVaccine)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "value");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Immunization, CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure ThreeDoseHibProcedure)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ThreeDoseHibProcedure?.Performed;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure ThreeDoseHibProcedure)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ThreeDoseHibProcedure?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isImmunizationAdministered(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Immunization HibVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HibVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Immunization>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Immunization HibVaccine)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = HibVaccine?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Immunization, CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isProcedurePerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure HibProcedure)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = HibProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure HibProcedure)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = HibProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Hib_3_or_4_Dose_Immunizations(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(CqlDate HibImmunization)
        {
            IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Count<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Greater(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, 0);
            IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Hib_3_or_4_Dose_Immunizations(context);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(CqlDate HibVaccinations)
            {
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<CqlDate, CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, 4);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Count<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Greater(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, 0);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IsFalse(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(CqlDate HibVaccinations)
            {
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CqlDate, CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, 3);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition HibReaction)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.First_Two_Years(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isImmunizationAdministered(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Immunization HepatitisBVaccination)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "value");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.First_Two_Years(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Immunization> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Immunization>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Immunization HepatitisBVaccination)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "value");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Immunization, CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isProcedurePerformed(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure HepatitisBProcedure)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = HepatitisBProcedure?.Performed;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.First_Two_Years(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure HepatitisBProcedure)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = HepatitisBProcedure?.Performed;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "day");
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrAfter(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrAfter(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure NewBornVaccine)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = NewBornVaccine?.Performed;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Patient mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Date mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(7m, "days");
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure NewBornVaccine)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = NewBornVaccine?.Performed;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context)
    {
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "day");
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameOrAfter(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameOrAfter(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SameOrAfter(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Hepatitis_B(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition HepBConditions)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.First_Two_Years(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isImmunizationAdministered(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Immunization ChickenPoxVaccination)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "value");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Immunization> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Immunization>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Immunization ChickenPoxVaccination)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "value");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Immunization, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isProcedurePerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure ChickenPoxProcedure)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ChickenPoxProcedure?.Performed;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Procedure ChickenPoxProcedure)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ChickenPoxProcedure?.Performed;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Procedure, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition VaricellaZoster)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isImmunizationAdministered(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Immunization PneumococcalVaccination)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "value");
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Immunization> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Immunization>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Immunization PneumococcalVaccination)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "value");
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Immunization, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isProcedurePerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Procedure PneumococcalProcedure)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PneumococcalProcedure?.Performed;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure PneumococcalProcedure)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PneumococcalProcedure?.Performed;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Procedure, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "day");
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrAfter(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrAfter(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition PneumococcalReaction)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.First_Two_Years(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isImmunizationAdministered(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Immunization HepatitisAVaccination)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "value");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Immunization>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Immunization HepatitisAVaccination)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "value");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Immunization, CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isProcedurePerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Procedure HepatitisAProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = HepatitisAProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure HepatitisAProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = HepatitisAProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Hepatitis_A(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition HepatitisADiagnosis)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.First_Two_Years(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Immunization> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isImmunizationAdministered(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "value");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Immunization> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Immunization>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "value");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Immunization, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isProcedurePerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = TwoDoseRotavirusProcedure?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = TwoDoseRotavirusProcedure?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Procedure, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isImmunizationAdministered(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "value");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Immunization>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "value");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Immunization, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isProcedurePerformed(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ThreeDoseRotavirusAdministered?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ThreeDoseRotavirusAdministered?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(CqlDate RotavirusImmunization)
        {
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Greater(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, 0);
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CqlDate, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, 3);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Greater(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, 0);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.IsFalse(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<CqlDate, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            int? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, 2);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition RotavirusConditions)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.First_Two_Years(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
        string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(180m, "days");
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isImmunizationAdministered(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Immunization InfluenzaVaccine)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "value");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Immunization>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Immunization InfluenzaVaccine)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "value");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Immunization, CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isProcedurePerformed(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Procedure InfluenzaAdministration)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = InfluenzaAdministration?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure InfluenzaAdministration)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = InfluenzaAdministration?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CrossJoin<CqlDate, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "day");
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrAfter(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isImmunizationAdministered(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Immunization LAIVVaccine)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = LAIVVaccine?.Occurrence;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "value");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Immunization> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Immunization>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Immunization LAIVVaccine)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = LAIVVaccine?.Occurrence;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "value");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Immunization, CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isProcedurePerformed(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Procedure InfluenzaAdministration)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = InfluenzaAdministration?.Performed;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure InfluenzaAdministration)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = InfluenzaAdministration?.Performed;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.LAIV_Vaccinations(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Influenza_Immunizations_or_Procedures(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition InfluenzaConditions)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Four_DTaP_Vaccinations(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.DTaP_Numerator_Inclusion_Conditions(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Three_Polio_Vaccinations(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Polio_Numerator_Inclusion_Conditions(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.One_MMR_Vaccination(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.MMR_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measles_Indicators(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Mumps_Indicators(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Rubella_Indicators(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Hib_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Three_Hepatitis_B_Vaccinations(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Meets_HepB_Vaccination_Requirement(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.One_Chicken_Pox_Vaccination(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.One_Hepatitis_A_Vaccinations(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Two_Influenza_Vaccinations(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Influenza_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

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
