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
        CqlDateTime qzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(qzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzf_, true, true);
        object qzzzzzzzzzzzzzzzzh_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", qzzzzzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzk_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzm_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzn_);
        CqlValueSet qzzzzzzzzzzzzzzzzp_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzr_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? qzzzzzzzzzzzzzzzzw_(Encounter E)
        {
            List<CodeableConcept> rzzzzzzzzzzzzzzzzi_ = E?.Type;
            CqlConcept rzzzzzzzzzzzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzj_);
            bool? rzzzzzzzzzzzzzzzzl_(CqlConcept T)
            {
                CqlCode rzzzzzzzzzzzzzzzzp_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept rzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzp_);
                bool? rzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(T, rzzzzzzzzzzzzzzzzq_);

                return rzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzm_ = context.Operators.Where<CqlConcept>(rzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzl_);
            bool? rzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzzzzzzzm_);

            return rzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzw_);
        CqlValueSet qzzzzzzzzzzzzzzzzy_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzza_);
        CqlValueSet rzzzzzzzzzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isEncounterPerformed(context, rzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzg_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            Period rzzzzzzzzzzzzzzzzt_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzu_ as object);
            bool? rzzzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzv_, "day");

            return rzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzg_);

        return rzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzx_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate szzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzc_ = context.Operators.End(szzzzzzzzzzzzzzzzb_);
        CqlDate szzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzc_);
        int? szzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzd_, "year");
        bool? szzzzzzzzzzzzzzzzf_ = context.Operators.Equal(szzzzzzzzzzzzzzzze_, 2);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounters(context);
        bool? szzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzh_);

        return szzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzk_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzl_ = szzzzzzzzzzzzzzzzk_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzzzl_?.Value;
        CqlDate szzzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzm_);
        CqlQuantity szzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(2m, "years");
        CqlDate szzzzzzzzzzzzzzzzp_ = context.Operators.Add(szzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzq_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzzq_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzs_ = szzzzzzzzzzzzzzzzr_?.Value;
        CqlDate szzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzs_);
        CqlDateTime szzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzt_);
        CqlDate szzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzu_);
        CqlDate szzzzzzzzzzzzzzzzw_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> szzzzzzzzzzzzzzzzx_ = context.Operators.Interval(szzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzw_, true, true);

        return szzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzy_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzza_(Condition SevereImmuneDisorder)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime tzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzd_);
            CqlDate tzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzg_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzg_, "day");

            return tzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzza_);
        bool? tzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzb_);

        return tzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzi_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzk_(Condition ImmuneDisorder)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime tzzzzzzzzzzzzzzzzo_ = context.Operators.Start(tzzzzzzzzzzzzzzzzn_);
            CqlDate tzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzq_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzq_, "day");

            return tzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzk_);
        bool? tzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzl_);

        return tzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has HIV")]
    public bool? Has_HIV(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzs_ = this.HIV(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzu_(Condition HIV)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime tzzzzzzzzzzzzzzzzy_ = context.Operators.Start(tzzzzzzzzzzzzzzzzx_);
            CqlDate tzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzza_ = this.First_Two_Years(context);
            bool? uzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzza_, "day");

            return uzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzu_);
        bool? tzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzv_);

        return tzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzc_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzzzzze_(Condition LymphaticMalignantNeoplasm)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime uzzzzzzzzzzzzzzzzi_ = context.Operators.Start(uzzzzzzzzzzzzzzzzh_);
            CqlDate uzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? uzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzk_, "day");

            return uzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzze_);
        bool? uzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzm_ = this.Intussusception(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzzzzzo_(Condition IntussusceptionDisorder)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime uzzzzzzzzzzzzzzzzs_ = context.Operators.Start(uzzzzzzzzzzzzzzzzr_);
            CqlDate uzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzu_ = this.First_Two_Years(context);
            bool? uzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzu_, "day");

            return uzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzo_);
        bool? uzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzp_);

        return uzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzw_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? uzzzzzzzzzzzzzzzzx_ = this.Has_Severe_Combined_Immunodeficiency(context);
        bool? uzzzzzzzzzzzzzzzzy_ = context.Operators.Or(uzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzzzzzz_ = this.Has_Immunodeficiency(context);
        bool? vzzzzzzzzzzzzzzzza_ = context.Operators.Or(uzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzz_);
        bool? vzzzzzzzzzzzzzzzzb_ = this.Has_HIV(context);
        bool? vzzzzzzzzzzzzzzzzc_ = context.Operators.Or(vzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzzzzd_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
        bool? vzzzzzzzzzzzzzzzze_ = context.Operators.Or(vzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzd_);
        bool? vzzzzzzzzzzzzzzzzf_ = this.Has_Intussusception(context);
        bool? vzzzzzzzzzzzzzzzzg_ = context.Operators.Or(vzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzf_);

        return vzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient vzzzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date vzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzh_?.BirthDateElement;
        string vzzzzzzzzzzzzzzzzj_ = vzzzzzzzzzzzzzzzzi_?.Value;
        CqlDate vzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzj_);
        CqlDateTime vzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzk_);
        CqlDate vzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzl_);
        CqlQuantity vzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(42m, "days");
        CqlDate vzzzzzzzzzzzzzzzzo_ = context.Operators.Add(vzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzn_);
        CqlDate vzzzzzzzzzzzzzzzzp_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzp_, true, true);

        return vzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzr_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isImmunizationAdministered(context, vzzzzzzzzzzzzzzzzs_);
        bool? vzzzzzzzzzzzzzzzzu_(Immunization DTaPVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzi_ = DTaPVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzi_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzj_ as object);
            CqlDate wzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzm_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? wzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzm_, "day");

            return wzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Immunization>(vzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzu_);
        CqlDate vzzzzzzzzzzzzzzzzw_(Immunization DTaPVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzo_ = DTaPVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzo_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzp_ as object);
            CqlDate wzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzq_);

            return wzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Immunization, CqlDate>(vzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzzzzzzzx_);
        CqlValueSet vzzzzzzzzzzzzzzzzz_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzzzza_);
        bool? wzzzzzzzzzzzzzzzzc_(Procedure DTaPProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzs_ = DTaPProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzs_);
            CqlDateTime wzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzt_);
            CqlDate wzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzw_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? wzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzw_, "day");

            return wzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzc_);
        CqlDate wzzzzzzzzzzzzzzzze_(Procedure DTaPProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzy_ = DTaPProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzy_);
            CqlDateTime xzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzz_);
            CqlDate xzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Procedure, CqlDate>(wzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzh_ = context.Operators.Union<CqlDate>(vzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzg_);

        return wzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzc_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> xzzzzzzzzzzzzzzzzg_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(xzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? xzzzzzzzzzzzzzzzzh_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? xzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return xzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> xzzzzzzzzzzzzzzzzi_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(xzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzh_);
        bool? xzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
        {
            CqlDateTime xzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzo_);
            CqlDate xzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzp_);
            CqlDateTime xzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzr_);
            CqlDate xzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzs_);
            CqlQuantity xzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "day");
            CqlDate xzzzzzzzzzzzzzzzzv_ = context.Operators.Add(xzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzu_);
            bool? xzzzzzzzzzzzzzzzzw_ = context.Operators.SameOrAfter(xzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzv_, "day");
            CqlDateTime xzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzx_);
            CqlDate xzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzy_);
            CqlDateTime yzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(xzzzzzzzzzzzzzzzzz_);
            CqlDateTime yzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzo_);
            CqlDateTime yzzzzzzzzzzzzzzzze_ = context.Operators.Add(yzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzzzzzzf_ = context.Operators.SameOrAfter(yzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzze_, "day");
            bool? yzzzzzzzzzzzzzzzzg_ = context.Operators.And(xzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzf_);
            CqlDateTime yzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
            CqlDateTime yzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzh_);
            CqlDate yzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzi_);
            CqlDateTime yzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzj_);
            CqlDateTime yzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzx_);
            CqlDateTime yzzzzzzzzzzzzzzzzo_ = context.Operators.Add(yzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrAfter(yzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzo_, "day");
            bool? yzzzzzzzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzp_);

            return yzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> xzzzzzzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(xzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzj_);
        CqlDate xzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) =>
            tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(xzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzl_);

        return xzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzr_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet yzzzzzzzzzzzzzzzzt_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzzzw_(Condition DTaPConditions)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime yzzzzzzzzzzzzzzzzz_ = context.Operators.Start(yzzzzzzzzzzzzzzzzy_);
            CqlDate zzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzb_ = this.First_Two_Years(context);
            bool? zzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzb_, "day");

            return zzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzw_);

        return yzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzd_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isImmunizationAdministered(context, zzzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzzg_(Immunization PolioVaccination)
        {
            DataType zzzzzzzzzzzzzzzzzu_ = PolioVaccination?.Occurrence;
            CqlDateTime zzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(zzzzzzzzzzzzzzzzzu_, "value");
            CqlDateTime zzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzv_ as object);
            CqlDate zzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzy_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? zzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzy_, "day");

            return zzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Immunization>(zzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzg_);
        CqlDate zzzzzzzzzzzzzzzzzi_(Immunization PolioVaccination)
        {
            DataType azzzzzzzzzzzzzzzzza_ = PolioVaccination?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzza_, "value");
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzb_ as object);
            CqlDateTime azzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.Earliest(context, azzzzzzzzzzzzzzzzzc_ as object);
            CqlDate azzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzd_);

            return azzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Immunization, CqlDate>(zzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzj_);
        CqlValueSet zzzzzzzzzzzzzzzzzl_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzm_);
        bool? zzzzzzzzzzzzzzzzzo_(Procedure PolioProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzf_ = PolioProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzf_);
            CqlDateTime azzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzg_);
            CqlDate azzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzj_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzj_, "day");

            return azzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzo_);
        CqlDate zzzzzzzzzzzzzzzzzq_(Procedure PolioProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzl_ = PolioProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzl_);
            CqlDateTime azzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzm_);
            CqlDate azzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzn_);

            return azzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, CqlDate>(zzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzt_ = context.Operators.Union<CqlDate>(zzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzp_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> azzzzzzzzzzzzzzzzzs_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(azzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? azzzzzzzzzzzzzzzzzt_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? bzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return bzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> azzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(azzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzt_);
        bool? azzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime bzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzb_);
            CqlDate bzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzc_);
            CqlDateTime bzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzze_);
            CqlDate bzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzf_);
            CqlQuantity bzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "day");
            CqlDate bzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzh_);
            bool? bzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrAfter(bzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzi_, default);
            CqlDateTime bzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzk_);
            CqlDate bzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzl_);
            CqlDateTime bzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzb_);
            CqlDate bzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzo_);
            CqlDate bzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzh_);
            bool? bzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrAfter(bzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzr_, default);
            bool? bzzzzzzzzzzzzzzzzzt_ = context.Operators.And(bzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzs_);

            return bzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> azzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(azzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzv_);
        CqlDate azzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime bzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzu_);
            CqlDate bzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzv_);

            return bzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(azzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzy_);

        return azzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode bzzzzzzzzzzzzzzzzzx_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzza_(Condition PolioConditions)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime czzzzzzzzzzzzzzzzzd_ = context.Operators.Start(czzzzzzzzzzzzzzzzzc_);
            CqlDate czzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzf_ = this.First_Two_Years(context);
            bool? czzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzf_, "day");

            return czzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzza_);

        return czzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzi_ = czzzzzzzzzzzzzzzzzh_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzzzzi_?.Value;
        CqlDate czzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzj_);
        CqlDateTime czzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzk_);
        CqlDate czzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzl_);
        CqlQuantity czzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "year");
        CqlDate czzzzzzzzzzzzzzzzzo_ = context.Operators.Add(czzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzn_);

        return czzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context)
    {
        CqlDate czzzzzzzzzzzzzzzzzp_ = this.Date_of_First_Birthday(context);
        CqlDate czzzzzzzzzzzzzzzzzq_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzq_, true, true);

        return czzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzs_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isImmunizationAdministered(context, czzzzzzzzzzzzzzzzzt_);
        bool? czzzzzzzzzzzzzzzzzv_(Immunization MMRVaccination)
        {
            DataType dzzzzzzzzzzzzzzzzzj_ = MMRVaccination?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzj_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzk_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzn_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? dzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzn_, default);

            return dzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Immunization>(czzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzv_);
        CqlDate czzzzzzzzzzzzzzzzzx_(Immunization MMRVaccination)
        {
            DataType dzzzzzzzzzzzzzzzzzp_ = MMRVaccination?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzp_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzq_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzr_);

            return dzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Immunization, CqlDate>(czzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> czzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(czzzzzzzzzzzzzzzzzy_);
        CqlValueSet dzzzzzzzzzzzzzzzzza_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzzb_);
        bool? dzzzzzzzzzzzzzzzzzd_(Procedure MMRProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzt_ = MMRProcedure?.Performed;
            object dzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzt_);
            CqlDateTime dzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzu_);
            CqlDate dzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzx_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? dzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzx_, default);

            return dzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzd_);
        CqlDate dzzzzzzzzzzzzzzzzzf_(Procedure MMRProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzz_ = MMRProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzz_);
            CqlDateTime ezzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzza_);
            CqlDate ezzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzb_);

            return ezzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, CqlDate>(dzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<CqlDate>(czzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzh_);

        return dzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzd_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzg_(Condition MMRConditions)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime ezzzzzzzzzzzzzzzzzj_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzi_);
            CqlDate ezzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzl_ = this.First_Two_Years(context);
            bool? ezzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzl_, "day");

            return ezzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzn_ = this.Measles(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzp_(Condition MeaslesDiagnosis)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime ezzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzr_);
            CqlDate ezzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzu_ = this.First_Two_Years(context);
            bool? ezzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzu_, "day");

            return ezzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzw_ = this.Mumps(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzy_(Condition MumpsDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzzzzzzzzzza_);
            CqlDate fzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzd_ = this.First_Two_Years(context);
            bool? fzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzd_, "day");

            return fzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzy_);

        return ezzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzf_ = this.Rubella(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzh_(Condition RubellaDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzj_);
            CqlDate fzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzm_ = this.First_Two_Years(context);
            bool? fzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzm_, "day");

            return fzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzo_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isImmunizationAdministered(context, fzzzzzzzzzzzzzzzzzp_);
        bool? fzzzzzzzzzzzzzzzzzr_(Immunization ThreeDoseHibVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzf_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzf_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzg_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzj_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? gzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzj_, "day");

            return gzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Immunization>(fzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzr_);
        CqlDate fzzzzzzzzzzzzzzzzzt_(Immunization ThreeDoseHibVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzl_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzl_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzm_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzn_);

            return gzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Immunization, CqlDate>(fzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzu_);
        CqlValueSet fzzzzzzzzzzzzzzzzzw_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzx_);
        bool? fzzzzzzzzzzzzzzzzzz_(Procedure ThreeDoseHibProcedure)
        {
            DataType gzzzzzzzzzzzzzzzzzp_ = ThreeDoseHibProcedure?.Performed;
            object gzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzq_);
            CqlDate gzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzt_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? gzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzt_, "day");

            return gzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzz_);
        CqlDate gzzzzzzzzzzzzzzzzzb_(Procedure ThreeDoseHibProcedure)
        {
            DataType gzzzzzzzzzzzzzzzzzv_ = ThreeDoseHibProcedure?.Performed;
            object gzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzv_);
            CqlDateTime gzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzw_);
            CqlDate gzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzx_);

            return gzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Procedure, CqlDate>(gzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzze_ = context.Operators.Union<CqlDate>(fzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzd_);

        return gzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzz_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> hzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> hzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isImmunizationAdministered(context, hzzzzzzzzzzzzzzzzza_);
        bool? hzzzzzzzzzzzzzzzzzc_(Immunization HibVaccine)
        {
            DataType hzzzzzzzzzzzzzzzzzq_ = HibVaccine?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzq_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzr_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzu_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? hzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzu_, "day");

            return hzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Immunization> hzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Immunization>(hzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzc_);
        CqlDate hzzzzzzzzzzzzzzzzze_(Immunization HibVaccine)
        {
            DataType hzzzzzzzzzzzzzzzzzw_ = HibVaccine?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzw_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzx_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzy_);

            return hzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Immunization, CqlDate>(hzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzf_);
        CqlValueSet hzzzzzzzzzzzzzzzzzh_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isProcedurePerformed(context, hzzzzzzzzzzzzzzzzzi_);
        bool? hzzzzzzzzzzzzzzzzzk_(Procedure HibProcedure)
        {
            DataType izzzzzzzzzzzzzzzzza_ = HibProcedure?.Performed;
            object izzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzza_);
            CqlDateTime izzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzb_);
            CqlDate izzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzze_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? izzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(izzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzze_, "day");

            return izzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzk_);
        CqlDate hzzzzzzzzzzzzzzzzzm_(Procedure HibProcedure)
        {
            DataType izzzzzzzzzzzzzzzzzg_ = HibProcedure?.Performed;
            object izzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzg_);
            CqlDateTime izzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzh_);
            CqlDate izzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzi_);

            return izzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Procedure, CqlDate>(hzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<CqlDate>(hzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzk_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzl_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzm_ = context.Operators.Union<CqlDate>(izzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzl_);

        return izzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzn_ = this.Hib_3_or_4_Dose_Immunizations(context);
        bool? izzzzzzzzzzzzzzzzzo_(CqlDate HibImmunization)
        {
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzr_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? izzzzzzzzzzzzzzzzzs_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzzzzzt_ = context.Operators.Greater(izzzzzzzzzzzzzzzzzs_, 0);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzu_ = this.Hib_3_or_4_Dose_Immunizations(context);
            CqlDate izzzzzzzzzzzzzzzzzv_(CqlDate HibVaccinations)
            {
                CqlDateTime jzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime jzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzp_);
                CqlDate jzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzq_);

                return jzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzv_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzw_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzx_);
            int? izzzzzzzzzzzzzzzzzz_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzy_);
            bool? jzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzz_, 4);
            bool? jzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzza_);
            int? jzzzzzzzzzzzzzzzzzd_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzr_);
            bool? jzzzzzzzzzzzzzzzzze_ = context.Operators.Greater(jzzzzzzzzzzzzzzzzzd_, 0);
            bool? jzzzzzzzzzzzzzzzzzf_ = context.Operators.IsFalse(jzzzzzzzzzzzzzzzzze_);
            CqlDate jzzzzzzzzzzzzzzzzzh_(CqlDate HibVaccinations)
            {
                CqlDateTime jzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime jzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzs_);
                CqlDate jzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzt_);

                return jzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzh_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzi_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzj_);
            int? jzzzzzzzzzzzzzzzzzl_ = context.Operators.Count<CqlDate>(jzzzzzzzzzzzzzzzzzk_);
            bool? jzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzl_, 3);
            bool? jzzzzzzzzzzzzzzzzzn_ = context.Operators.And(jzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzm_);
            bool? jzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzn_);

            return jzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzp_ = context.Operators.Where<CqlDate>(izzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzo_);
        bool? izzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzv_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzzy_(Condition HibReaction)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime kzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzzzza_);
            CqlDate kzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzd_ = this.First_Two_Years(context);
            bool? kzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzd_, "day");

            return kzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzy_);

        return jzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzf_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isImmunizationAdministered(context, kzzzzzzzzzzzzzzzzzg_);
        bool? kzzzzzzzzzzzzzzzzzi_(Immunization HepatitisBVaccination)
        {
            DataType kzzzzzzzzzzzzzzzzzw_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime kzzzzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<CqlDateTime>(kzzzzzzzzzzzzzzzzzw_, "value");
            CqlDateTime kzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzx_ as object);
            CqlDate kzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzza_ = this.First_Two_Years(context);
            bool? lzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzza_, "day");

            return lzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Immunization>(kzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzi_);
        CqlDate kzzzzzzzzzzzzzzzzzk_(Immunization HepatitisBVaccination)
        {
            DataType lzzzzzzzzzzzzzzzzzc_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime lzzzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(lzzzzzzzzzzzzzzzzzc_, "value");
            CqlDateTime lzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzd_ as object);
            CqlDate lzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzze_);

            return lzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Immunization, CqlDate>(kzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzzl_);
        CqlValueSet kzzzzzzzzzzzzzzzzzn_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzzzzzzzzzzzzzzo_);
        bool? kzzzzzzzzzzzzzzzzzq_(Procedure HepatitisBProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzzg_ = HepatitisBProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzg_);
            CqlDateTime lzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzh_);
            CqlDate lzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? lzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzk_, "day");

            return lzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzq_);
        CqlDate kzzzzzzzzzzzzzzzzzs_(Procedure HepatitisBProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzzm_ = HepatitisBProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzm_);
            CqlDateTime lzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzn_);
            CqlDate lzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Procedure, CqlDate>(kzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<CqlDate>(kzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzu_);

        return kzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzq_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> lzzzzzzzzzzzzzzzzzt_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(lzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? lzzzzzzzzzzzzzzzzzu_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? mzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return mzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> lzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(lzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzu_);
        bool? lzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzc_);
            CqlDate mzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzd_);
            CqlDateTime mzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzf_);
            CqlDate mzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzg_);
            CqlQuantity mzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1m, "day");
            CqlDate mzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrAfter(mzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzj_, default);
            CqlDateTime mzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzl_);
            CqlDate mzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzm_);
            CqlDateTime mzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzc_);
            CqlDate mzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzp_);
            CqlDate mzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzzt_ = context.Operators.SameOrAfter(mzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzs_, default);
            bool? mzzzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzt_);

            return mzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> lzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(lzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzw_);
        CqlDate lzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzv_);
            CqlDate mzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(lzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(lzzzzzzzzzzzzzzzzzz_);

        return mzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzy_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzza_);
        bool? nzzzzzzzzzzzzzzzzzc_(Procedure NewBornVaccine)
        {
            DataType nzzzzzzzzzzzzzzzzzh_ = NewBornVaccine?.Performed;
            object nzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzh_);
            CqlDateTime nzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzi_);
            CqlDate nzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzj_);
            Patient nzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
            Date nzzzzzzzzzzzzzzzzzm_ = nzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzm_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzn_);
            CqlDateTime nzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzzo_);
            CqlDate nzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzp_);
            Date nzzzzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzt_);
            CqlDateTime nzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzzu_);
            CqlDate nzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzv_);
            CqlQuantity nzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(7m, "days");
            CqlDate nzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzy_, true, true);
            bool? ozzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzz_, "day");

            return ozzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzc_);
        CqlDate nzzzzzzzzzzzzzzzzze_(Procedure NewBornVaccine)
        {
            DataType ozzzzzzzzzzzzzzzzzb_ = NewBornVaccine?.Performed;
            object ozzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzb_);
            CqlDateTime ozzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzc_);
            CqlDate ozzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzd_);

            return ozzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Procedure, CqlDate>(nzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzf_);

        return nzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context)
    {
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzf_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzh_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> ozzzzzzzzzzzzzzzzzi_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(ozzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? ozzzzzzzzzzzzzzzzzj_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? ozzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return ozzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> ozzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(ozzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzj_);
        bool? ozzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime ozzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime ozzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzr_);
            CqlDate ozzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzs_);
            CqlDateTime ozzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime ozzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzu_);
            CqlDate ozzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzv_);
            CqlQuantity ozzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "day");
            CqlDate ozzzzzzzzzzzzzzzzzy_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzx_);
            bool? ozzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrAfter(ozzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzy_, default);
            CqlDateTime pzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzu_);
            CqlDate pzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzb_);
            CqlDateTime pzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
            CqlDateTime pzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzd_);
            CqlDate pzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzze_);
            CqlDate pzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzx_);
            bool? pzzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrAfter(pzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzh_, default);
            bool? pzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzi_);
            CqlDateTime pzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzr_);
            CqlDate pzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzl_);
            CqlDateTime pzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzd_);
            CqlDate pzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzo_);
            CqlDate pzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzx_);
            bool? pzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrAfter(pzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzr_, default);
            bool? pzzzzzzzzzzzzzzzzzt_ = context.Operators.And(pzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzs_);

            return pzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> ozzzzzzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(ozzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzl_);
        CqlDate ozzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime pzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime pzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzu_);
            CqlDate pzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzv_);

            return pzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(ozzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzzzzzzzo_);

        return ozzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzx_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet qzzzzzzzzzzzzzzzzza_ = this.Hepatitis_B(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzb_);
        bool? qzzzzzzzzzzzzzzzzzd_(Condition HepBConditions)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime qzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzf_);
            CqlDate qzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzi_ = this.First_Two_Years(context);
            bool? qzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzi_, "day");

            return qzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzd_);

        return qzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzk_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> qzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> qzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isImmunizationAdministered(context, qzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzn_(Immunization ChickenPoxVaccination)
        {
            DataType rzzzzzzzzzzzzzzzzzb_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime rzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(rzzzzzzzzzzzzzzzzzb_, "value");
            CqlDateTime rzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzc_ as object);
            CqlDate rzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzf_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? rzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzf_, default);

            return rzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Immunization> qzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Immunization>(qzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzn_);
        CqlDate qzzzzzzzzzzzzzzzzzp_(Immunization ChickenPoxVaccination)
        {
            DataType rzzzzzzzzzzzzzzzzzh_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime rzzzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<CqlDateTime>(rzzzzzzzzzzzzzzzzzh_, "value");
            CqlDateTime rzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzi_ as object);
            CqlDate rzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzj_);

            return rzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Immunization, CqlDate>(qzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzzq_);
        CqlValueSet qzzzzzzzzzzzzzzzzzs_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isProcedurePerformed(context, qzzzzzzzzzzzzzzzzzt_);
        bool? qzzzzzzzzzzzzzzzzzv_(Procedure ChickenPoxProcedure)
        {
            DataType rzzzzzzzzzzzzzzzzzl_ = ChickenPoxProcedure?.Performed;
            object rzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzl_);
            CqlDateTime rzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzm_);
            CqlDate rzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzp_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? rzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzp_, default);

            return rzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzv_);
        CqlDate qzzzzzzzzzzzzzzzzzx_(Procedure ChickenPoxProcedure)
        {
            DataType rzzzzzzzzzzzzzzzzzr_ = ChickenPoxProcedure?.Performed;
            object rzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzr_);
            CqlDateTime rzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzs_);
            CqlDate rzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzt_);

            return rzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, CqlDate>(qzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzza_ = context.Operators.Union<CqlDate>(qzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzz_);

        return rzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzv_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode rzzzzzzzzzzzzzzzzzx_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> szzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzzzzzb_(Condition VaricellaZoster)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime szzzzzzzzzzzzzzzzze_ = context.Operators.Start(szzzzzzzzzzzzzzzzzd_);
            CqlDate szzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzg_ = this.First_Two_Years(context);
            bool? szzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzg_, "day");

            return szzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzi_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isImmunizationAdministered(context, szzzzzzzzzzzzzzzzzj_);
        bool? szzzzzzzzzzzzzzzzzl_(Immunization PneumococcalVaccination)
        {
            DataType szzzzzzzzzzzzzzzzzz_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime tzzzzzzzzzzzzzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzzzzzzzzzzzzzzz_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzza_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzd_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? tzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzd_, "day");

            return tzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Immunization>(szzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzl_);
        CqlDate szzzzzzzzzzzzzzzzzn_(Immunization PneumococcalVaccination)
        {
            DataType tzzzzzzzzzzzzzzzzzf_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime tzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(tzzzzzzzzzzzzzzzzzf_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzg_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzh_);

            return tzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Immunization, CqlDate>(szzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzo_);
        CqlValueSet szzzzzzzzzzzzzzzzzq_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzzzzzzzzzzzzzzzr_);
        bool? szzzzzzzzzzzzzzzzzt_(Procedure PneumococcalProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzj_ = PneumococcalProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzj_);
            CqlDateTime tzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzk_);
            CqlDate tzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzn_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? tzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzn_, "day");

            return tzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzt_);
        CqlDate szzzzzzzzzzzzzzzzzv_(Procedure PneumococcalProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzp_ = PneumococcalProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzp_);
            CqlDateTime tzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzq_);
            CqlDate tzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzr_);

            return tzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, CqlDate>(szzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzy_ = context.Operators.Union<CqlDate>(szzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzx_);

        return szzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzt_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> tzzzzzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(tzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tzzzzzzzzzzzzzzzzzy_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? uzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return uzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> tzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(tzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzy_);
        bool? uzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime uzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzg_);
            CqlDate uzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzh_);
            CqlDateTime uzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzj_);
            CqlDate uzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzk_);
            CqlQuantity uzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "day");
            CqlDate uzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzn_, default);
            CqlDateTime uzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzp_);
            CqlDate uzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzq_);
            CqlDateTime uzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzg_);
            CqlDate uzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzt_);
            CqlDate uzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzw_, default);
            bool? uzzzzzzzzzzzzzzzzzy_ = context.Operators.And(uzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzx_);
            CqlDateTime uzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
            CqlDateTime vzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzz_);
            CqlDate vzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzza_);
            CqlDateTime vzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzp_);
            CqlDate vzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzd_);
            CqlDate vzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(vzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzm_);
            bool? vzzzzzzzzzzzzzzzzzh_ = context.Operators.SameOrAfter(vzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzg_, default);
            bool? vzzzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzh_);

            return vzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> uzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(tzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzza_);
        CqlDate uzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime vzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime vzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzj_);
            CqlDate vzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzk_);

            return vzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(uzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzzzzzzd_);

        return uzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzm_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzp_(Condition PneumococcalReaction)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime vzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzr_);
            CqlDate vzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzu_ = this.First_Two_Years(context);
            bool? vzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzu_, "day");

            return vzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzp_);

        return vzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzw_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isImmunizationAdministered(context, vzzzzzzzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzzzzzzzz_(Immunization HepatitisAVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzn_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzn_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzo_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzr_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? wzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzr_, default);

            return wzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Immunization> wzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Immunization>(vzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzz_);
        CqlDate wzzzzzzzzzzzzzzzzzb_(Immunization HepatitisAVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzt_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzt_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzu_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzv_);

            return wzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Immunization, CqlDate>(wzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzc_);
        CqlValueSet wzzzzzzzzzzzzzzzzze_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzzzzzf_);
        bool? wzzzzzzzzzzzzzzzzzh_(Procedure HepatitisAProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzzx_ = HepatitisAProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzx_);
            CqlDateTime wzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzy_);
            CqlDate xzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzb_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? xzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzb_, default);

            return xzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzh_);
        CqlDate wzzzzzzzzzzzzzzzzzj_(Procedure HepatitisAProcedure)
        {
            DataType xzzzzzzzzzzzzzzzzzd_ = HepatitisAProcedure?.Performed;
            object xzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzd_);
            CqlDateTime xzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzze_);
            CqlDate xzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzf_);

            return xzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlDate>(wzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<CqlDate>(wzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzh_ = this.Hepatitis_A(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode xzzzzzzzzzzzzzzzzzj_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzl_);
        bool? xzzzzzzzzzzzzzzzzzn_(Condition HepatitisADiagnosis)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime xzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzp_);
            CqlDate xzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzs_ = this.First_Two_Years(context);
            bool? xzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzs_, "day");

            return xzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzn_);

        return xzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzzu_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Immunization> xzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> xzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isImmunizationAdministered(context, xzzzzzzzzzzzzzzzzzw_);
        bool? xzzzzzzzzzzzzzzzzzy_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType yzzzzzzzzzzzzzzzzzm_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime yzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<CqlDateTime>(yzzzzzzzzzzzzzzzzzm_, "value");
            CqlDateTime yzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzn_ as object);
            CqlDate yzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzq_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? yzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzq_, "day");

            return yzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Immunization> xzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Immunization>(xzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzy_);
        CqlDate yzzzzzzzzzzzzzzzzza_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType yzzzzzzzzzzzzzzzzzs_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime yzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(yzzzzzzzzzzzzzzzzzs_, "value");
            CqlDateTime yzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzt_ as object);
            CqlDate yzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Immunization, CqlDate>(xzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzb_);
        CqlValueSet yzzzzzzzzzzzzzzzzzd_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, yzzzzzzzzzzzzzzzzze_);
        bool? yzzzzzzzzzzzzzzzzzg_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType yzzzzzzzzzzzzzzzzzw_ = TwoDoseRotavirusProcedure?.Performed;
            object yzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzw_);
            CqlDateTime yzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzx_);
            CqlDate yzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzza_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? zzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzza_, "day");

            return zzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzg_);
        CqlDate yzzzzzzzzzzzzzzzzzi_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType zzzzzzzzzzzzzzzzzzc_ = TwoDoseRotavirusProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzc_);
            CqlDateTime zzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzd_);
            CqlDate zzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzze_);

            return zzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlDate>(yzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<CqlDate>(yzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzg_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isImmunizationAdministered(context, zzzzzzzzzzzzzzzzzzh_);
        bool? zzzzzzzzzzzzzzzzzzj_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType zzzzzzzzzzzzzzzzzzx_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime zzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(zzzzzzzzzzzzzzzzzzx_, "value");
            CqlDateTime zzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzy_ as object);
            CqlDate azzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzb_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzb_, "day");

            return azzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Immunization>(zzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzj_);
        CqlDate zzzzzzzzzzzzzzzzzzl_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType azzzzzzzzzzzzzzzzzzd_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzd_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzze_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzf_);

            return azzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Immunization, CqlDate>(zzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzm_);
        CqlValueSet zzzzzzzzzzzzzzzzzzo_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzzzzzzzr_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType azzzzzzzzzzzzzzzzzzh_ = ThreeDoseRotavirusAdministered?.Performed;
            object azzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzh_);
            CqlDateTime azzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzi_);
            CqlDate azzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzl_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzl_, "day");

            return azzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzr_);
        CqlDate zzzzzzzzzzzzzzzzzzt_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType azzzzzzzzzzzzzzzzzzn_ = ThreeDoseRotavirusAdministered?.Performed;
            object azzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzn_);
            CqlDateTime azzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzo_);
            CqlDate azzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzp_);

            return azzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Procedure, CqlDate>(zzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<CqlDate>(zzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzv_);

        return zzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzr_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzs_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<CqlDate>(azzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzs_);

        return azzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzu_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
        bool? azzzzzzzzzzzzzzzzzzv_(CqlDate RotavirusImmunization)
        {
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzy_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? azzzzzzzzzzzzzzzzzzz_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzzzzzy_);
            bool? bzzzzzzzzzzzzzzzzzza_ = context.Operators.Greater(azzzzzzzzzzzzzzzzzzz_, 0);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzb_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
            CqlDate bzzzzzzzzzzzzzzzzzzc_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime bzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime bzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzw_);
                CqlDate bzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzx_);

                return bzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<CqlDate, CqlDate>(bzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzze_);
            int? bzzzzzzzzzzzzzzzzzzg_ = context.Operators.Count<CqlDate>(bzzzzzzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzg_, 3);
            bool? bzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzh_);
            int? bzzzzzzzzzzzzzzzzzzk_ = context.Operators.Count<CqlDate>(azzzzzzzzzzzzzzzzzzy_);
            bool? bzzzzzzzzzzzzzzzzzzl_ = context.Operators.Greater(bzzzzzzzzzzzzzzzzzzk_, 0);
            bool? bzzzzzzzzzzzzzzzzzzm_ = context.Operators.IsFalse(bzzzzzzzzzzzzzzzzzzl_);
            CqlDate bzzzzzzzzzzzzzzzzzzo_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime bzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime czzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzz_);
                CqlDate czzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzza_);

                return czzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<CqlDate, CqlDate>(bzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzq_);
            int? bzzzzzzzzzzzzzzzzzzs_ = context.Operators.Count<CqlDate>(bzzzzzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzs_, 2);
            bool? bzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlDate>(azzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CqlDate>(azzzzzzzzzzzzzzzzzzw_);

        return azzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzc_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzzzf_(Condition RotavirusConditions)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime czzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzh_);
            CqlDate czzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? czzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzk_, "day");

            return czzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzf_);

        return czzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzzn_ = czzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate czzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzzo_);
        CqlDateTime czzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzp_);
        CqlDate czzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzq_);
        CqlQuantity czzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(180m, "days");
        CqlDate czzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzs_);
        CqlDate czzzzzzzzzzzzzzzzzzu_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzu_, true, true);

        return czzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzw_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isImmunizationAdministered(context, czzzzzzzzzzzzzzzzzzx_);
        bool? czzzzzzzzzzzzzzzzzzz_(Immunization InfluenzaVaccine)
        {
            DataType dzzzzzzzzzzzzzzzzzzn_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzn_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzo_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzr_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? dzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzr_, "day");

            return dzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Immunization>(czzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzz_);
        CqlDate dzzzzzzzzzzzzzzzzzzb_(Immunization InfluenzaVaccine)
        {
            DataType dzzzzzzzzzzzzzzzzzzt_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzt_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzv_);

            return dzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Immunization, CqlDate>(dzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet dzzzzzzzzzzzzzzzzzze_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzzzf_);
        bool? dzzzzzzzzzzzzzzzzzzh_(Procedure InfluenzaAdministration)
        {
            DataType dzzzzzzzzzzzzzzzzzzx_ = InfluenzaAdministration?.Performed;
            object dzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzy_);
            CqlDate ezzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzb_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? ezzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzb_, "day");

            return ezzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzh_);
        CqlDate dzzzzzzzzzzzzzzzzzzj_(Procedure InfluenzaAdministration)
        {
            DataType ezzzzzzzzzzzzzzzzzzd_ = InfluenzaAdministration?.Performed;
            object ezzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzd_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzze_);
            CqlDate ezzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzf_);

            return ezzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlDate>(dzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<CqlDate>(dzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzh_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> ezzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<CqlDate, CqlDate>(ezzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? ezzzzzzzzzzzzzzzzzzk_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? ezzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

            return ezzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> ezzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(ezzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzk_);
        bool? ezzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime ezzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime ezzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzs_);
            CqlDate ezzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzt_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime ezzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzv_);
            CqlDate ezzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzw_);
            CqlQuantity ezzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
            CqlDate ezzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzy_);
            bool? fzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrAfter(ezzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzz_, default);

            return fzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> ezzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(ezzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzm_);
        CqlDate ezzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime fzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime fzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzb_);
            CqlDate fzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(ezzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzze_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isImmunizationAdministered(context, fzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzh_(Immunization LAIVVaccine)
        {
            DataType fzzzzzzzzzzzzzzzzzzv_ = LAIVVaccine?.Occurrence;
            CqlDateTime fzzzzzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<CqlDateTime>(fzzzzzzzzzzzzzzzzzzv_, "value");
            CqlDateTime fzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDate fzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzx_);
            CqlDate fzzzzzzzzzzzzzzzzzzz_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzz_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzb_, "day");

            return gzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Immunization>(fzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzh_);
        CqlDate fzzzzzzzzzzzzzzzzzzj_(Immunization LAIVVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzzd_ = LAIVVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzzd_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzze_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzf_);

            return gzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Immunization, CqlDate>(fzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzm_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzn_);
        bool? fzzzzzzzzzzzzzzzzzzp_(Procedure InfluenzaAdministration)
        {
            DataType gzzzzzzzzzzzzzzzzzzh_ = InfluenzaAdministration?.Performed;
            object gzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzi_);
            CqlDate gzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzj_);
            CqlDate gzzzzzzzzzzzzzzzzzzl_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzl_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzn_, "day");

            return gzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzp_);
        CqlDate fzzzzzzzzzzzzzzzzzzr_(Procedure InfluenzaAdministration)
        {
            DataType gzzzzzzzzzzzzzzzzzzp_ = InfluenzaAdministration?.Performed;
            object gzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzq_);
            CqlDate gzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzr_);

            return gzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, CqlDate>(fzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<CqlDate>(fzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context)
    {
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzt_ = this.LAIV_Vaccinations(context);
        bool? gzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzv_ = this.Influenza_Immunizations_or_Procedures(context);
        bool? gzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzzzzzzzzzv_);
        bool? gzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzw_);

        return gzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzy_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzzzzb_(Condition InfluenzaConditions)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime hzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzd_);
            CqlDate hzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzg_ = this.First_Two_Years(context);
            bool? hzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzg_, "day");

            return hzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzb_);

        return hzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzi_ = this.Four_DTaP_Vaccinations(context);
        bool? hzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzk_ = this.DTaP_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzn_ = this.Three_Polio_Vaccinations(context);
        bool? hzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzp_ = this.Polio_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzp_);
        bool? hzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzq_);
        bool? hzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzt_ = this.One_MMR_Vaccination(context);
        bool? hzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzv_ = this.MMR_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzy_ = this.Measles_Indicators(context);
        bool? hzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzza_ = this.Mumps_Indicators(context);
        bool? izzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzza_);
        bool? izzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzd_ = this.Rubella_Indicators(context);
        bool? izzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzd_);
        bool? izzzzzzzzzzzzzzzzzzf_ = context.Operators.And(izzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzze_);
        bool? izzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzf_);
        bool? izzzzzzzzzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzzzi_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzj_ = this.Hib_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzj_);
        bool? izzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzk_);
        bool? izzzzzzzzzzzzzzzzzzm_ = context.Operators.And(izzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzn_ = this.Three_Hepatitis_B_Vaccinations(context);
        bool? izzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzp_ = this.Meets_HepB_Vaccination_Requirement(context);
        bool? izzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzr_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzr_);
        bool? izzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzs_);
        bool? izzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzt_);
        bool? izzzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzw_ = this.One_Chicken_Pox_Vaccination(context);
        bool? izzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzy_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzz_);
        bool? jzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzc_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
        bool? jzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlDate>(jzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzze_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzze_);
        bool? jzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzf_);
        bool? jzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzi_ = this.One_Hepatitis_A_Vaccinations(context);
        bool? jzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlDate>(jzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzk_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzl_);
        bool? jzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzm_);
        bool? jzzzzzzzzzzzzzzzzzzo_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzp_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzt_ = this.Two_Influenza_Vaccinations(context);
        bool? jzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<CqlDate>(jzzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzzv_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
        bool? jzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzx_ = this.Influenza_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzx_);
        bool? jzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzy_);
        bool? kzzzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzz_);

        return kzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return kzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> kzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return kzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return kzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return kzzzzzzzzzzzzzzzzzze_;
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
