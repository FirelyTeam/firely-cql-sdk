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
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_ = new CqlCode("433621000124101", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)", codeId: "428321000124101", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(CqlContext _) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_;
    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_ = new CqlCode("428321000124101", "http://snomed.info/sct");

    [CqlCodeDefinition("Anaphylaxis due to rotavirus vaccine (disorder)", codeId: "428331000124103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder_(CqlContext _) => _Anaphylaxis_due_to_rotavirus_vaccine__disorder_;
    private static readonly CqlCode _Anaphylaxis_due_to_rotavirus_vaccine__disorder_ = new CqlCode("428331000124103", "http://snomed.info/sct");

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

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_,
          _Anaphylaxis_due_to_rotavirus_vaccine__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_);

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null,
          _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional);

    [CqlCodeSystemDefinition("CVX")]
    public CqlCodeSystem CVX(CqlContext _) => _CVX;
    private static readonly CqlCodeSystem _CVX =
      new CqlCodeSystem("http://hl7.org/fhir/sid/cvx", null,
          _rotavirus__live__monovalent_vaccine);

    [CqlCodeSystemDefinition("ICD10")]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 =
      new CqlCodeSystem("http://www.cms.gov/Medicare/Coding/ICD10", null,
          _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
        object mzzzzzzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", mzzzzzzzzzzzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzzzzzzzzy_);

        return mzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzza_ = this.Office_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzc_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzf_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzm_(Encounter E)
        {
            List<CodeableConcept> nzzzzzzzzzzzzzzzzzzzzzzy_ = E?.Type;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzz_(CodeableConcept @this)
            {
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ozzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzb_(CqlConcept T)
            {
                CqlCode ozzzzzzzzzzzzzzzzzzzzzzf_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzzzzzzzzzzzf_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(T, ozzzzzzzzzzzzzzzzzzzzzzg_);

                return ozzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<CqlConcept>(ozzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzb_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlConcept>(ozzzzzzzzzzzzzzzzzzzzzzc_);

            return ozzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzo_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzs_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isEncounterPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzw_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            Period ozzzzzzzzzzzzzzzzzzzzzzj_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzk_ as object);
            bool? ozzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return ozzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzw_);

        return nzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
        Date ozzzzzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
        string ozzzzzzzzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzs_);
        int? ozzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzt_, "year");
        bool? ozzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzu_, 2);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzw_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzx_);

        return ozzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context)
    {
        Patient pzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date pzzzzzzzzzzzzzzzzzzzzzzb_ = pzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string pzzzzzzzzzzzzzzzzzzzzzzc_ = pzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(2m, "years");
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzze_);

        return pzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context)
    {
        Patient pzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient(context);
        Date pzzzzzzzzzzzzzzzzzzzzzzh_ = pzzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
        string pzzzzzzzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(pzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzm_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzm_, true, true);

        return pzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzo_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzq_(Condition SevereImmuneDisorder)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzw_ = this.First_Two_Years(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return pzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzy_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzzzzzzzzzzzzzza_(Condition ImmuneDisorder)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzg_ = this.First_Two_Years(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzb_);

        return qzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has HIV")]
    public bool? Has_HIV(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzi_ = this.HIV(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzk_(Condition HIV)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Two_Years(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzl_);

        return qzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzs_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzzzzzzzzzzzzzzzzu_(Condition LymphaticMalignantNeoplasm)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzza_ = this.First_Two_Years(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzzzzzzv_);

        return qzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzc_ = this.Intussusception(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzzzzzzzzzzzzzzze_(Condition IntussusceptionDisorder)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzzzzzzzf_);

        return rzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzzzzzzzzzm_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Severe_Combined_Immunodeficiency(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzp_ = this.Has_Immunodeficiency(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_HIV(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzt_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Intussusception(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzv_);

        return rzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzb_);
        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(42m, "days");
        CqlDate szzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzf_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzf_, true, true);

        return szzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzh_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isImmunizationAdministered(context, szzzzzzzzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzzzzzzzk_(Immunization DTaPVaccination)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzy_ = DTaPVaccination?.Occurrence;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzy_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzc_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzc_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Immunization>(szzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzm_(Immunization DTaPVaccination)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzze_ = DTaPVaccination?.Occurrence;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzze_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzg_);

            return tzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Immunization, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzp_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzzzzzzzzzzzzzzzzzzzzq_);
        bool? szzzzzzzzzzzzzzzzzzzzzzs_(Procedure DTaPProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzi_ = DTaPProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzm_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzm_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzu_(Procedure DTaPProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzo_ = DTaPProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzq_);

            return tzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzw_);

        return szzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzs_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> tzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tzzzzzzzzzzzzzzzzzzzzzzx_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? uzzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return uzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> tzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(tzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
        {
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1m, "day");
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            bool? uzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameOrAfter(vzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzze_, "day");
            bool? vzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzf_);

            return vzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> uzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(tzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) =>
            tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(uzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzh_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzj_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Condition>(vzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzm_(Condition DTaPConditions)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzr_ = this.First_Two_Years(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzm_);

        return vzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzt_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isImmunizationAdministered(context, vzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzw_(Immunization PolioVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzk_ = PolioVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzk_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzo_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzo_, "day");

            return wzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Immunization>(vzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzy_(Immunization PolioVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzq_ = PolioVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzq_, "value");
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.Earliest(context, wzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzt_);

            return wzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Immunization, CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzb_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzzzzzzzzzzze_(Procedure PolioProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzv_ = PolioProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzz_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzg_(Procedure PolioProcedure)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzb_ = PolioProcedure?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzd_);

            return xzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzf_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> xzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? xzzzzzzzzzzzzzzzzzzzzzzj_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? xzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return xzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> xzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(xzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "day");
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrAfter(xzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzy_, default);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrAfter(yzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? yzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzi_);

            return yzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> xzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(xzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzl_);

            return yzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzo_);

        return xzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzn_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzq_(Condition PolioConditions)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzv_ = this.First_Two_Years(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzv_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzq_);

        return yzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date yzzzzzzzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzzz_ = yzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "year");
        CqlDate zzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context)
    {
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzf_ = this.Date_of_First_Birthday(context);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzg_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzg_, true, true);

        return zzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isImmunizationAdministered(context, zzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzl_(Immunization MMRVaccination)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzz_ = MMRVaccination?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzz_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzd_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzd_, default);

            return azzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Immunization>(zzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzn_(Immunization MMRVaccination)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzf_ = MMRVaccination?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzf_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzg_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzh_);

            return azzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Immunization, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzt_(Procedure MMRProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzj_ = MMRProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzn_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzn_, default);

            return azzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzv_(Procedure MMRProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzp_ = MMRProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzt_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzzzzzzzw_(Condition MMRConditions)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzb_ = this.First_Two_Years(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzw_);

        return azzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measles(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzf_(Condition MeaslesDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzf_);

        return bzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Mumps(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzo_(Condition MumpsDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzt_ = this.First_Two_Years(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzo_);

        return bzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Rubella(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzx_(Condition RubellaDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzc_ = this.First_Two_Years(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzc_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzx_);

        return bzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzze_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isImmunizationAdministered(context, czzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzh_(Immunization ThreeDoseHibVaccine)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzv_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzv_, "value");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzz_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Immunization>(czzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzj_(Immunization ThreeDoseHibVaccine)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzb_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzb_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzd_);

            return dzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Immunization, CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzm_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isProcedurePerformed(context, czzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzp_(Procedure ThreeDoseHibProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzf_ = ThreeDoseHibProcedure?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzr_(Procedure ThreeDoseHibProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzl_ = ThreeDoseHibProcedure?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzn_);

            return dzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzt_);

        return czzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isImmunizationAdministered(context, dzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzs_(Immunization HibVaccine)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzg_ = HibVaccine?.Occurrence;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzg_, "value");
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzk_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Immunization>(dzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzu_(Immunization HibVaccine)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzm_ = HibVaccine?.Occurrence;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzm_, "value");
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzo_);

            return ezzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Immunization, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzza_(Procedure HibProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzq_ = HibProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzu_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzc_(Procedure HibProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzw_ = HibProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzy_);

            return ezzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Procedure, CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzze_);

        return ezzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzza_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzb_);

        return fzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Hib_3_or_4_Dose_Immunizations(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzze_(CqlDate HibImmunization)
        {
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? fzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Count<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Greater(fzzzzzzzzzzzzzzzzzzzzzzzi_, 0);
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hib_3_or_4_Dose_Immunizations(context);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzl_(CqlDate HibVaccinations)
            {
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDate gzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzg_);

                return gzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CqlDate, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzn_);
            int? fzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Count<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzzp_, 4);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzq_);
            int? fzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Count<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Greater(fzzzzzzzzzzzzzzzzzzzzzzzt_, 0);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.IsFalse(fzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzx_(CqlDate HibVaccinations)
            {
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDate gzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzj_);

                return gzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CqlDate, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzz_);
            int? gzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Count<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzb_, 3);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzd_);

            return gzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzf_);

        return fzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzo_(Condition HibReaction)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzt_ = this.First_Two_Years(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzo_);

        return gzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isImmunizationAdministered(context, gzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzy_(Immunization HepatitisBVaccination)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzm_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzm_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Two_Years(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return hzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Immunization>(gzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzza_(Immunization HepatitisBVaccination)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzs_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzs_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzt_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzu_);

            return hzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Immunization, CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, hzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure HepatitisBProcedure)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzw_ = HepatitisBProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzza_ = this.First_Two_Years(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return izzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure HepatitisBProcedure)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzc_ = HepatitisBProcedure?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzze_);

            return izzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzg_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? izzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? izzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return izzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> izzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(izzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrAfter(izzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzz_, default);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrAfter(jzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzi_, default);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzj_);

            return jzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> izzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(izzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzm_);

            return jzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, jzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure NewBornVaccine)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzx_ = NewBornVaccine?.Performed;
            object jzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzz_);
            Patient kzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
            Date kzzzzzzzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
            string kzzzzzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzf_);
            Date kzzzzzzzzzzzzzzzzzzzzzzzi_ = kzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
            string kzzzzzzzzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(7m, "days");
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate jzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure NewBornVaccine)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzr_ = NewBornVaccine?.Performed;
            object kzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzt_);

            return kzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzv_);

        return jzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context)
    {
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzx_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> kzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? kzzzzzzzzzzzzzzzzzzzzzzzz_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? lzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return lzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> lzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(kzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "day");
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrAfter(lzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrAfter(lzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrAfter(mzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzh_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> lzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(lzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzl_);

            return mzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzze_);

        return lzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Hepatitis_B(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzt_(Condition HepBConditions)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzy_ = this.First_Two_Years(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return mzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzt_);

        return mzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzza_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> nzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> nzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isImmunizationAdministered(context, nzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzd_(Immunization ChickenPoxVaccination)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzr_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzr_, "value");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzv_, default);

            return nzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Immunization> nzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Immunization>(nzzzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzf_(Immunization ChickenPoxVaccination)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzx_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzx_, "value");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzz_);

            return ozzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Immunization, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzl_(Procedure ChickenPoxProcedure)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzb_ = ChickenPoxProcedure?.Performed;
            object ozzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzf_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzf_, default);

            return ozzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure ChickenPoxProcedure)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzh_ = ChickenPoxProcedure?.Performed;
            object ozzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzj_);

            return ozzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzl_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzn_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzr_(Condition VaricellaZoster)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzw_ = this.First_Two_Years(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return ozzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzy_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> ozzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> pzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isImmunizationAdministered(context, ozzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzb_(Immunization PneumococcalVaccination)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzp_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzp_, "value");
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

            return pzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Immunization> pzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Immunization>(pzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzd_(Immunization PneumococcalVaccination)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzv_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzv_, "value");
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Immunization, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isProcedurePerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure PneumococcalProcedure)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzz_ = PneumococcalProcedure?.Performed;
            object qzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzzl_(Procedure PneumococcalProcedure)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzf_ = PneumococcalProcedure?.Performed;
            object qzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzh_);

            return qzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Procedure, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> qzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? qzzzzzzzzzzzzzzzzzzzzzzzo_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? qzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return qzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> qzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(qzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "day");
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrAfter(qzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzd_, default);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameOrAfter(rzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzm_, default);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrAfter(rzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzx_);

            return rzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> qzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(qzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate qzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzza_);

            return szzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzt_);

        return qzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzc_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzf_(Condition PneumococcalReaction)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzzf_);

        return szzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzm_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isImmunizationAdministered(context, szzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzp_(Immunization HepatitisAVaccination)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzd_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzd_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzzzzzh_, default);

            return tzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Immunization>(szzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzr_(Immunization HepatitisAVaccination)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzj_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzj_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzl_);

            return tzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Immunization, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzu_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzx_(Procedure HepatitisAProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzn_ = HepatitisAProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzr_, default);

            return tzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzz_(Procedure HepatitisAProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzt_ = HepatitisAProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzv_);

            return tzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Procedure, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzb_);

        return tzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Hepatitis_A(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzd_(Condition HepatitisADiagnosis)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzi_ = this.First_Two_Years(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzd_);

        return uzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzk_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Immunization> uzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> uzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isImmunizationAdministered(context, uzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzo_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzc_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzc_, "value");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Immunization> uzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Immunization>(uzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzq_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzi_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzi_, "value");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzk_);

            return vzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Immunization, CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzm_ = TwoDoseRotavirusProcedure?.Performed;
            object vzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzs_ = TwoDoseRotavirusProcedure?.Performed;
            object vzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzu_);

            return vzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzza_);

        return vzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isImmunizationAdministered(context, vzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzz_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzn_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzn_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzo_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return wzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Immunization> wzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Immunization>(vzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzb_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzt_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzt_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzv_);

            return wzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Immunization, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzze_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzx_ = ThreeDoseRotavirusAdministered?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzd_ = ThreeDoseRotavirusAdministered?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzf_);

            return xzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzl_(CqlDate RotavirusImmunization)
        {
            IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? xzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Count<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Greater(xzzzzzzzzzzzzzzzzzzzzzzzp_, 0);
            IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzs_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzn_);

                return yzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<CqlDate, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzu_);
            int? xzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Count<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzzzzzzzzzzw_, 3);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzx_);
            int? yzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Count<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Greater(yzzzzzzzzzzzzzzzzzzzzzzza_, 0);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.IsFalse(yzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzze_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzq_);

                return yzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<CqlDate, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzg_);
            int? yzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Count<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzi_, 2);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(xzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzk_);

            return yzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzv_(Condition RotavirusConditions)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzza_ = this.First_Two_Years(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(180m, "days");
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);

        return zzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isImmunizationAdministered(context, zzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzp_(Immunization InfluenzaVaccine)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzd_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzd_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Immunization>(zzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzr_(Immunization InfluenzaVaccine)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzj_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzj_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzl_);

            return azzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Immunization, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzx_(Procedure InfluenzaAdministration)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzn_ = InfluenzaAdministration?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzz_(Procedure InfluenzaAdministration)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzt_ = InfluenzaAdministration?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzv_);

            return azzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Procedure, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzb_);

        return azzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> azzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<CqlDate, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? bzzzzzzzzzzzzzzzzzzzzzzzza_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? bzzzzzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> bzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(azzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "day");
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrAfter(bzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

            return bzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> bzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(bzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> bzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> bzzzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isImmunizationAdministered(context, bzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzx_(Immunization LAIVVaccine)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzl_ = LAIVVaccine?.Occurrence;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzl_, "value");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Immunization> bzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Immunization>(bzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzz_(Immunization LAIVVaccine)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzt_ = LAIVVaccine?.Occurrence;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzt_, "value");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzv_);

            return czzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Immunization, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isProcedurePerformed(context, czzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure InfluenzaAdministration)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzx_ = InfluenzaAdministration?.Performed;
            object czzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure InfluenzaAdministration)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzf_ = InfluenzaAdministration?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzj_);

        return czzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context)
    {
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.LAIV_Vaccinations(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Influenza_Immunizations_or_Procedures(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition InfluenzaConditions)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.First_Two_Years(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Four_DTaP_Vaccinations(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzza_ = this.DTaP_Numerator_Inclusion_Conditions(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Three_Polio_Vaccinations(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Polio_Numerator_Inclusion_Conditions(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzj_ = this.One_MMR_Vaccination(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzl_ = this.MMR_Numerator_Inclusion_Conditions(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measles_Indicators(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Mumps_Indicators(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Rubella_Indicators(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Hib_Numerator_Inclusion_Conditions(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Three_Hepatitis_B_Vaccinations(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Meets_HepB_Vaccination_Requirement(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.One_Chicken_Pox_Vaccination(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.One_Hepatitis_A_Vaccinations(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Two_Influenza_Vaccinations(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Influenza_Numerator_Inclusion_Conditions(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(gzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> gzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzu_;
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
