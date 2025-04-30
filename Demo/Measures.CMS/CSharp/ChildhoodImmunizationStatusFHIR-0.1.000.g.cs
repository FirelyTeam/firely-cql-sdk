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
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_,
          _Anaphylaxis_due_to_rotavirus_vaccine__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_,
          _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_]);

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional]);

    [CqlCodeSystemDefinition("CVX")]
    public CqlCodeSystem CVX(CqlContext _) => _CVX;
    private static readonly CqlCodeSystem _CVX =
      new CqlCodeSystem("http://hl7.org/fhir/sid/cvx", null, [
          _rotavirus__live__monovalent_vaccine]);

    [CqlCodeSystemDefinition("ICD10")]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 =
      new CqlCodeSystem("http://www.cms.gov/Medicare/Coding/ICD10", null, [
          _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime czzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzm_ = context.Operators.Interval(czzzk_, czzzl_, true, true);
        object czzzn_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", czzzm_);

        return (CqlInterval<CqlDateTime>)czzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzp_ = context.Operators.SingletonFrom<Patient>(czzzo_);

        return czzzp_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet czzzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> czzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzs_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> czzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzu_ = context.Operators.Union<Encounter>(czzzr_, czzzt_);
        CqlValueSet czzzv_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> czzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzx_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> czzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzz_ = context.Operators.Union<Encounter>(czzzw_, czzzy_);
        IEnumerable<Encounter> dzzza_ = context.Operators.Union<Encounter>(czzzu_, czzzz_);
        IEnumerable<Encounter> dzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzc_(Encounter E)
        {
            List<CodeableConcept> dzzzo_ = E?.Type;
            CqlConcept dzzzp_(CodeableConcept @this)
            {
                CqlConcept dzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzu_;
            };
            IEnumerable<CqlConcept> dzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzo_, dzzzp_);
            bool? dzzzr_(CqlConcept T)
            {
                CqlCode dzzzv_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept dzzzw_ = context.Operators.ConvertCodeToConcept(dzzzv_);
                bool? dzzzx_ = context.Operators.Equivalent(T, dzzzw_);

                return dzzzx_;
            };
            IEnumerable<CqlConcept> dzzzs_ = context.Operators.Where<CqlConcept>(dzzzq_, dzzzr_);
            bool? dzzzt_ = context.Operators.Exists<CqlConcept>(dzzzs_);

            return dzzzt_;
        };
        IEnumerable<Encounter> dzzzd_ = context.Operators.Where<Encounter>(dzzzb_, dzzzc_);
        CqlValueSet dzzze_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> dzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzg_ = context.Operators.Union<Encounter>(dzzzd_, dzzzf_);
        IEnumerable<Encounter> dzzzh_ = context.Operators.Union<Encounter>(dzzza_, dzzzg_);
        CqlValueSet dzzzi_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> dzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzk_ = context.Operators.Union<Encounter>(dzzzh_, dzzzj_);
        IEnumerable<Encounter> dzzzl_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzk_);
        bool? dzzzm_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> dzzzy_ = this.Measurement_Period(context);
            Period dzzzz_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ezzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzz_);
            CqlInterval<CqlDateTime> ezzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzza_ as object);
            bool? ezzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzy_, ezzzb_, "day");

            return ezzzc_;
        };
        IEnumerable<Encounter> dzzzn_ = context.Operators.Where<Encounter>(dzzzl_, dzzzm_);

        return dzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ezzzd_ = this.Patient(context);
        Date ezzze_ = ezzzd_?.BirthDateElement;
        string ezzzf_ = ezzze_?.Value;
        CqlDate ezzzg_ = context.Operators.ConvertStringToDate(ezzzf_);
        CqlInterval<CqlDateTime> ezzzh_ = this.Measurement_Period(context);
        CqlDateTime ezzzi_ = context.Operators.End(ezzzh_);
        CqlDate ezzzj_ = context.Operators.DateFrom(ezzzi_);
        int? ezzzk_ = context.Operators.CalculateAgeAt(ezzzg_, ezzzj_, "year");
        bool? ezzzl_ = context.Operators.Equal(ezzzk_, 2);
        IEnumerable<Encounter> ezzzm_ = this.Qualifying_Encounters(context);
        bool? ezzzn_ = context.Operators.Exists<Encounter>(ezzzm_);
        bool? ezzzo_ = context.Operators.And(ezzzl_, ezzzn_);

        return ezzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ezzzp_ = this.Initial_Population(context);

        return ezzzp_;
    }


    [CqlExpressionDefinition("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context)
    {
        Patient ezzzq_ = this.Patient(context);
        Date ezzzr_ = ezzzq_?.BirthDateElement;
        string ezzzs_ = ezzzr_?.Value;
        CqlDate ezzzt_ = context.Operators.ConvertStringToDate(ezzzs_);
        CqlQuantity ezzzu_ = context.Operators.Quantity(2m, "years");
        CqlDate ezzzv_ = context.Operators.Add(ezzzt_, ezzzu_);

        return ezzzv_;
    }


    [CqlExpressionDefinition("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context)
    {
        Patient ezzzw_ = this.Patient(context);
        Date ezzzx_ = ezzzw_?.BirthDateElement;
        string ezzzy_ = ezzzx_?.Value;
        CqlDate ezzzz_ = context.Operators.ConvertStringToDate(ezzzy_);
        CqlDateTime fzzza_ = context.Operators.ConvertDateToDateTime(ezzzz_);
        CqlDate fzzzb_ = context.Operators.DateFrom(fzzza_);
        CqlDate fzzzc_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> fzzzd_ = context.Operators.Interval(fzzzb_, fzzzc_, true, true);

        return fzzzd_;
    }


    [CqlExpressionDefinition("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context)
    {
        CqlValueSet fzzze_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> fzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzg_(Condition SevereImmuneDisorder)
        {
            CqlInterval<CqlDateTime> fzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime fzzzk_ = context.Operators.Start(fzzzj_);
            CqlDate fzzzl_ = context.Operators.DateFrom(fzzzk_);
            CqlInterval<CqlDate> fzzzm_ = this.First_Two_Years(context);
            bool? fzzzn_ = context.Operators.In<CqlDate>(fzzzl_, fzzzm_, "day");

            return fzzzn_;
        };
        IEnumerable<Condition> fzzzh_ = context.Operators.Where<Condition>(fzzzf_, fzzzg_);
        bool? fzzzi_ = context.Operators.Exists<Condition>(fzzzh_);

        return fzzzi_;
    }


    [CqlExpressionDefinition("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context)
    {
        CqlValueSet fzzzo_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> fzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzq_(Condition ImmuneDisorder)
        {
            CqlInterval<CqlDateTime> fzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime fzzzu_ = context.Operators.Start(fzzzt_);
            CqlDate fzzzv_ = context.Operators.DateFrom(fzzzu_);
            CqlInterval<CqlDate> fzzzw_ = this.First_Two_Years(context);
            bool? fzzzx_ = context.Operators.In<CqlDate>(fzzzv_, fzzzw_, "day");

            return fzzzx_;
        };
        IEnumerable<Condition> fzzzr_ = context.Operators.Where<Condition>(fzzzp_, fzzzq_);
        bool? fzzzs_ = context.Operators.Exists<Condition>(fzzzr_);

        return fzzzs_;
    }


    [CqlExpressionDefinition("Has HIV")]
    public bool? Has_HIV(CqlContext context)
    {
        CqlValueSet fzzzy_ = this.HIV(context);
        IEnumerable<Condition> fzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzza_(Condition HIV)
        {
            CqlInterval<CqlDateTime> gzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime gzzze_ = context.Operators.Start(gzzzd_);
            CqlDate gzzzf_ = context.Operators.DateFrom(gzzze_);
            CqlInterval<CqlDate> gzzzg_ = this.First_Two_Years(context);
            bool? gzzzh_ = context.Operators.In<CqlDate>(gzzzf_, gzzzg_, "day");

            return gzzzh_;
        };
        IEnumerable<Condition> gzzzb_ = context.Operators.Where<Condition>(fzzzz_, gzzza_);
        bool? gzzzc_ = context.Operators.Exists<Condition>(gzzzb_);

        return gzzzc_;
    }


    [CqlExpressionDefinition("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context)
    {
        CqlValueSet gzzzi_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> gzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzzk_(Condition LymphaticMalignantNeoplasm)
        {
            CqlInterval<CqlDateTime> gzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime gzzzo_ = context.Operators.Start(gzzzn_);
            CqlDate gzzzp_ = context.Operators.DateFrom(gzzzo_);
            CqlInterval<CqlDate> gzzzq_ = this.First_Two_Years(context);
            bool? gzzzr_ = context.Operators.In<CqlDate>(gzzzp_, gzzzq_, "day");

            return gzzzr_;
        };
        IEnumerable<Condition> gzzzl_ = context.Operators.Where<Condition>(gzzzj_, gzzzk_);
        bool? gzzzm_ = context.Operators.Exists<Condition>(gzzzl_);

        return gzzzm_;
    }


    [CqlExpressionDefinition("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context)
    {
        CqlValueSet gzzzs_ = this.Intussusception(context);
        IEnumerable<Condition> gzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzzu_(Condition IntussusceptionDisorder)
        {
            CqlInterval<CqlDateTime> gzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime gzzzy_ = context.Operators.Start(gzzzx_);
            CqlDate gzzzz_ = context.Operators.DateFrom(gzzzy_);
            CqlInterval<CqlDate> hzzza_ = this.First_Two_Years(context);
            bool? hzzzb_ = context.Operators.In<CqlDate>(gzzzz_, hzzza_, "day");

            return hzzzb_;
        };
        IEnumerable<Condition> gzzzv_ = context.Operators.Where<Condition>(gzzzt_, gzzzu_);
        bool? gzzzw_ = context.Operators.Exists<Condition>(gzzzv_);

        return gzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? hzzzc_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? hzzzd_ = this.Has_Severe_Combined_Immunodeficiency(context);
        bool? hzzze_ = context.Operators.Or(hzzzc_, hzzzd_);
        bool? hzzzf_ = this.Has_Immunodeficiency(context);
        bool? hzzzg_ = context.Operators.Or(hzzze_, hzzzf_);
        bool? hzzzh_ = this.Has_HIV(context);
        bool? hzzzi_ = context.Operators.Or(hzzzg_, hzzzh_);
        bool? hzzzj_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
        bool? hzzzk_ = context.Operators.Or(hzzzi_, hzzzj_);
        bool? hzzzl_ = this.Has_Intussusception(context);
        bool? hzzzm_ = context.Operators.Or(hzzzk_, hzzzl_);

        return hzzzm_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient hzzzn_ = this.Patient(context);
        Date hzzzo_ = hzzzn_?.BirthDateElement;
        string hzzzp_ = hzzzo_?.Value;
        CqlDate hzzzq_ = context.Operators.ConvertStringToDate(hzzzp_);
        CqlDateTime hzzzr_ = context.Operators.ConvertDateToDateTime(hzzzq_);
        CqlDate hzzzs_ = context.Operators.DateFrom(hzzzr_);
        CqlQuantity hzzzt_ = context.Operators.Quantity(42m, "days");
        CqlDate hzzzu_ = context.Operators.Add(hzzzs_, hzzzt_);
        CqlDate hzzzv_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> hzzzw_ = context.Operators.Interval(hzzzu_, hzzzv_, true, true);

        return hzzzw_;
    }


    [CqlExpressionDefinition("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet hzzzx_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> hzzzy_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, hzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> hzzzz_ = Status_1_8_000.Instance.isImmunizationAdministered(context, hzzzy_);
        bool? izzza_(Immunization DTaPVaccination)
        {
            DataType izzzo_ = DTaPVaccination?.Occurrence;
            CqlDateTime izzzp_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzo_, "value");
            CqlDateTime izzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzp_ as object);
            CqlDate izzzr_ = context.Operators.DateFrom(izzzq_);
            CqlInterval<CqlDate> izzzs_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? izzzt_ = context.Operators.In<CqlDate>(izzzr_, izzzs_, "day");

            return izzzt_;
        };
        IEnumerable<Immunization> izzzb_ = context.Operators.Where<Immunization>(hzzzz_, izzza_);
        CqlDate izzzc_(Immunization DTaPVaccination)
        {
            DataType izzzu_ = DTaPVaccination?.Occurrence;
            CqlDateTime izzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzu_, "value");
            CqlDateTime izzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzv_ as object);
            CqlDate izzzx_ = context.Operators.DateFrom(izzzw_);

            return izzzx_;
        };
        IEnumerable<CqlDate> izzzd_ = context.Operators.Select<Immunization, CqlDate>(izzzb_, izzzc_);
        IEnumerable<CqlDate> izzze_ = context.Operators.Distinct<CqlDate>(izzzd_);
        CqlValueSet izzzf_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> izzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> izzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, izzzg_);
        bool? izzzi_(Procedure DTaPProcedure)
        {
            DataType izzzy_ = DTaPProcedure?.Performed;
            object izzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzy_);
            CqlDateTime jzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzz_);
            CqlDate jzzzb_ = context.Operators.DateFrom(jzzza_);
            CqlInterval<CqlDate> jzzzc_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? jzzzd_ = context.Operators.In<CqlDate>(jzzzb_, jzzzc_, "day");

            return jzzzd_;
        };
        IEnumerable<Procedure> izzzj_ = context.Operators.Where<Procedure>(izzzh_, izzzi_);
        CqlDate izzzk_(Procedure DTaPProcedure)
        {
            DataType jzzze_ = DTaPProcedure?.Performed;
            object jzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzze_);
            CqlDateTime jzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzf_);
            CqlDate jzzzh_ = context.Operators.DateFrom(jzzzg_);

            return jzzzh_;
        };
        IEnumerable<CqlDate> izzzl_ = context.Operators.Select<Procedure, CqlDate>(izzzj_, izzzk_);
        IEnumerable<CqlDate> izzzm_ = context.Operators.Distinct<CqlDate>(izzzl_);
        IEnumerable<CqlDate> izzzn_ = context.Operators.Union<CqlDate>(izzze_, izzzm_);

        return izzzn_;
    }


    [CqlExpressionDefinition("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> jzzzi_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> jzzzm_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(jzzzi_, jzzzi_, jzzzi_, jzzzi_);
        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? jzzzn_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? jzzzt_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return jzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> jzzzo_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(jzzzm_, jzzzn_);
        bool? jzzzp_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
        {
            CqlDateTime jzzzu_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime jzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzu_);
            CqlDate jzzzw_ = context.Operators.DateFrom(jzzzv_);
            CqlDateTime jzzzx_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime jzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzx_);
            CqlDate jzzzz_ = context.Operators.DateFrom(jzzzy_);
            CqlQuantity kzzza_ = context.Operators.Quantity(1m, "day");
            CqlDate kzzzb_ = context.Operators.Add(jzzzz_, kzzza_);
            bool? kzzzc_ = context.Operators.SameOrAfter(jzzzw_, kzzzb_, "day");
            CqlDateTime kzzzd_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
            CqlDateTime kzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzd_);
            CqlDate kzzzf_ = context.Operators.DateFrom(kzzze_);
            CqlDateTime kzzzg_ = context.Operators.ConvertDateToDateTime(kzzzf_);
            CqlDateTime kzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzu_);
            CqlDateTime kzzzk_ = context.Operators.Add(kzzzi_, kzzza_);
            bool? kzzzl_ = context.Operators.SameOrAfter(kzzzg_, kzzzk_, "day");
            bool? kzzzm_ = context.Operators.And(kzzzc_, kzzzl_);
            CqlDateTime kzzzn_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
            CqlDateTime kzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzn_);
            CqlDate kzzzp_ = context.Operators.DateFrom(kzzzo_);
            CqlDateTime kzzzq_ = context.Operators.ConvertDateToDateTime(kzzzp_);
            CqlDateTime kzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzd_);
            CqlDateTime kzzzu_ = context.Operators.Add(kzzzs_, kzzza_);
            bool? kzzzv_ = context.Operators.SameOrAfter(kzzzq_, kzzzu_, "day");
            bool? kzzzw_ = context.Operators.And(kzzzm_, kzzzv_);

            return kzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> jzzzq_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(jzzzo_, jzzzp_);
        CqlDate jzzzr_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) =>
            tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> jzzzs_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(jzzzq_, jzzzr_);

        return jzzzs_;
    }


    [CqlExpressionDefinition("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet kzzzx_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> kzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet kzzzz_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> lzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzb_ = context.Operators.Union<Condition>(kzzzy_, lzzza_);
        bool? lzzzc_(Condition DTaPConditions)
        {
            CqlInterval<CqlDateTime> lzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime lzzzf_ = context.Operators.Start(lzzze_);
            CqlDate lzzzg_ = context.Operators.DateFrom(lzzzf_);
            CqlInterval<CqlDate> lzzzh_ = this.First_Two_Years(context);
            bool? lzzzi_ = context.Operators.In<CqlDate>(lzzzg_, lzzzh_, "day");

            return lzzzi_;
        };
        IEnumerable<Condition> lzzzd_ = context.Operators.Where<Condition>(lzzzb_, lzzzc_);

        return lzzzd_;
    }


    [CqlExpressionDefinition("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet lzzzj_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> lzzzk_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, lzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> lzzzl_ = Status_1_8_000.Instance.isImmunizationAdministered(context, lzzzk_);
        bool? lzzzm_(Immunization PolioVaccination)
        {
            DataType mzzza_ = PolioVaccination?.Occurrence;
            CqlDateTime mzzzb_ = context.Operators.LateBoundProperty<CqlDateTime>(mzzza_, "value");
            CqlDateTime mzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzb_ as object);
            CqlDate mzzzd_ = context.Operators.DateFrom(mzzzc_);
            CqlInterval<CqlDate> mzzze_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? mzzzf_ = context.Operators.In<CqlDate>(mzzzd_, mzzze_, "day");

            return mzzzf_;
        };
        IEnumerable<Immunization> lzzzn_ = context.Operators.Where<Immunization>(lzzzl_, lzzzm_);
        CqlDate lzzzo_(Immunization PolioVaccination)
        {
            DataType mzzzg_ = PolioVaccination?.Occurrence;
            CqlDateTime mzzzh_ = context.Operators.LateBoundProperty<CqlDateTime>(mzzzg_, "value");
            CqlInterval<CqlDateTime> mzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzh_ as object);
            CqlDateTime mzzzj_ = QICoreCommon_2_1_000.Instance.Earliest(context, mzzzi_ as object);
            CqlDate mzzzk_ = context.Operators.DateFrom(mzzzj_);

            return mzzzk_;
        };
        IEnumerable<CqlDate> lzzzp_ = context.Operators.Select<Immunization, CqlDate>(lzzzn_, lzzzo_);
        IEnumerable<CqlDate> lzzzq_ = context.Operators.Distinct<CqlDate>(lzzzp_);
        CqlValueSet lzzzr_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> lzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzt_ = Status_1_8_000.Instance.isProcedurePerformed(context, lzzzs_);
        bool? lzzzu_(Procedure PolioProcedure)
        {
            DataType mzzzl_ = PolioProcedure?.Performed;
            object mzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzl_);
            CqlDateTime mzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzm_);
            CqlDate mzzzo_ = context.Operators.DateFrom(mzzzn_);
            CqlInterval<CqlDate> mzzzp_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? mzzzq_ = context.Operators.In<CqlDate>(mzzzo_, mzzzp_, "day");

            return mzzzq_;
        };
        IEnumerable<Procedure> lzzzv_ = context.Operators.Where<Procedure>(lzzzt_, lzzzu_);
        CqlDate lzzzw_(Procedure PolioProcedure)
        {
            DataType mzzzr_ = PolioProcedure?.Performed;
            object mzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzr_);
            CqlDateTime mzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzs_);
            CqlDate mzzzu_ = context.Operators.DateFrom(mzzzt_);

            return mzzzu_;
        };
        IEnumerable<CqlDate> lzzzx_ = context.Operators.Select<Procedure, CqlDate>(lzzzv_, lzzzw_);
        IEnumerable<CqlDate> lzzzy_ = context.Operators.Distinct<CqlDate>(lzzzx_);
        IEnumerable<CqlDate> lzzzz_ = context.Operators.Union<CqlDate>(lzzzq_, lzzzy_);

        return lzzzz_;
    }


    [CqlExpressionDefinition("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> mzzzv_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> mzzzy_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(mzzzv_, mzzzv_, mzzzv_);
        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? mzzzz_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? nzzzg_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return nzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> nzzza_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(mzzzy_, mzzzz_);
        bool? nzzzb_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime nzzzh_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime nzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzh_);
            CqlDate nzzzj_ = context.Operators.DateFrom(nzzzi_);
            CqlDateTime nzzzk_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime nzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzk_);
            CqlDate nzzzm_ = context.Operators.DateFrom(nzzzl_);
            CqlQuantity nzzzn_ = context.Operators.Quantity(1m, "day");
            CqlDate nzzzo_ = context.Operators.Add(nzzzm_, nzzzn_);
            bool? nzzzp_ = context.Operators.SameOrAfter(nzzzj_, nzzzo_, default);
            CqlDateTime nzzzq_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
            CqlDateTime nzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzq_);
            CqlDate nzzzs_ = context.Operators.DateFrom(nzzzr_);
            CqlDateTime nzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzh_);
            CqlDate nzzzv_ = context.Operators.DateFrom(nzzzu_);
            CqlDate nzzzx_ = context.Operators.Add(nzzzv_, nzzzn_);
            bool? nzzzy_ = context.Operators.SameOrAfter(nzzzs_, nzzzx_, default);
            bool? nzzzz_ = context.Operators.And(nzzzp_, nzzzy_);

            return nzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> nzzzc_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(nzzza_, nzzzb_);
        CqlDate nzzzd_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime ozzza_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime ozzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzza_);
            CqlDate ozzzc_ = context.Operators.DateFrom(ozzzb_);

            return ozzzc_;
        };
        IEnumerable<CqlDate> nzzze_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(nzzzc_, nzzzd_);
        IEnumerable<CqlDate> nzzzf_ = context.Operators.Distinct<CqlDate>(nzzze_);

        return nzzzf_;
    }


    [CqlExpressionDefinition("Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode ozzzd_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> ozzze_ = context.Operators.ToList<CqlCode>(ozzzd_);
        IEnumerable<Condition> ozzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ozzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzg_(Condition PolioConditions)
        {
            CqlInterval<CqlDateTime> ozzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime ozzzj_ = context.Operators.Start(ozzzi_);
            CqlDate ozzzk_ = context.Operators.DateFrom(ozzzj_);
            CqlInterval<CqlDate> ozzzl_ = this.First_Two_Years(context);
            bool? ozzzm_ = context.Operators.In<CqlDate>(ozzzk_, ozzzl_, "day");

            return ozzzm_;
        };
        IEnumerable<Condition> ozzzh_ = context.Operators.Where<Condition>(ozzzf_, ozzzg_);

        return ozzzh_;
    }


    [CqlExpressionDefinition("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context)
    {
        Patient ozzzn_ = this.Patient(context);
        Date ozzzo_ = ozzzn_?.BirthDateElement;
        string ozzzp_ = ozzzo_?.Value;
        CqlDate ozzzq_ = context.Operators.ConvertStringToDate(ozzzp_);
        CqlDateTime ozzzr_ = context.Operators.ConvertDateToDateTime(ozzzq_);
        CqlDate ozzzs_ = context.Operators.DateFrom(ozzzr_);
        CqlQuantity ozzzt_ = context.Operators.Quantity(1m, "year");
        CqlDate ozzzu_ = context.Operators.Add(ozzzs_, ozzzt_);

        return ozzzu_;
    }


    [CqlExpressionDefinition("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context)
    {
        CqlDate ozzzv_ = this.Date_of_First_Birthday(context);
        CqlDate ozzzw_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> ozzzx_ = context.Operators.Interval(ozzzv_, ozzzw_, true, true);

        return ozzzx_;
    }


    [CqlExpressionDefinition("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context)
    {
        CqlValueSet ozzzy_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> ozzzz_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, ozzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> pzzza_ = Status_1_8_000.Instance.isImmunizationAdministered(context, ozzzz_);
        bool? pzzzb_(Immunization MMRVaccination)
        {
            DataType pzzzp_ = MMRVaccination?.Occurrence;
            CqlDateTime pzzzq_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzp_, "value");
            CqlDateTime pzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzq_ as object);
            CqlDate pzzzs_ = context.Operators.DateFrom(pzzzr_);
            CqlInterval<CqlDate> pzzzt_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? pzzzu_ = context.Operators.In<CqlDate>(pzzzs_, pzzzt_, default);

            return pzzzu_;
        };
        IEnumerable<Immunization> pzzzc_ = context.Operators.Where<Immunization>(pzzza_, pzzzb_);
        CqlDate pzzzd_(Immunization MMRVaccination)
        {
            DataType pzzzv_ = MMRVaccination?.Occurrence;
            CqlDateTime pzzzw_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzv_, "value");
            CqlDateTime pzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzw_ as object);
            CqlDate pzzzy_ = context.Operators.DateFrom(pzzzx_);

            return pzzzy_;
        };
        IEnumerable<CqlDate> pzzze_ = context.Operators.Select<Immunization, CqlDate>(pzzzc_, pzzzd_);
        IEnumerable<CqlDate> pzzzf_ = context.Operators.Distinct<CqlDate>(pzzze_);
        CqlValueSet pzzzg_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> pzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> pzzzi_ = Status_1_8_000.Instance.isProcedurePerformed(context, pzzzh_);
        bool? pzzzj_(Procedure MMRProcedure)
        {
            DataType pzzzz_ = MMRProcedure?.Performed;
            object qzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzz_);
            CqlDateTime qzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzza_);
            CqlDate qzzzc_ = context.Operators.DateFrom(qzzzb_);
            CqlInterval<CqlDate> qzzzd_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? qzzze_ = context.Operators.In<CqlDate>(qzzzc_, qzzzd_, default);

            return qzzze_;
        };
        IEnumerable<Procedure> pzzzk_ = context.Operators.Where<Procedure>(pzzzi_, pzzzj_);
        CqlDate pzzzl_(Procedure MMRProcedure)
        {
            DataType qzzzf_ = MMRProcedure?.Performed;
            object qzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzf_);
            CqlDateTime qzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzg_);
            CqlDate qzzzi_ = context.Operators.DateFrom(qzzzh_);

            return qzzzi_;
        };
        IEnumerable<CqlDate> pzzzm_ = context.Operators.Select<Procedure, CqlDate>(pzzzk_, pzzzl_);
        IEnumerable<CqlDate> pzzzn_ = context.Operators.Distinct<CqlDate>(pzzzm_);
        IEnumerable<CqlDate> pzzzo_ = context.Operators.Union<CqlDate>(pzzzf_, pzzzn_);

        return pzzzo_;
    }


    [CqlExpressionDefinition("MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode qzzzj_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> qzzzk_ = context.Operators.ToList<CqlCode>(qzzzj_);
        IEnumerable<Condition> qzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, qzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzm_(Condition MMRConditions)
        {
            CqlInterval<CqlDateTime> qzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime qzzzp_ = context.Operators.Start(qzzzo_);
            CqlDate qzzzq_ = context.Operators.DateFrom(qzzzp_);
            CqlInterval<CqlDate> qzzzr_ = this.First_Two_Years(context);
            bool? qzzzs_ = context.Operators.In<CqlDate>(qzzzq_, qzzzr_, "day");

            return qzzzs_;
        };
        IEnumerable<Condition> qzzzn_ = context.Operators.Where<Condition>(qzzzl_, qzzzm_);

        return qzzzn_;
    }


    [CqlExpressionDefinition("Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context)
    {
        CqlValueSet qzzzt_ = this.Measles(context);
        IEnumerable<Condition> qzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzv_(Condition MeaslesDiagnosis)
        {
            CqlInterval<CqlDateTime> qzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime qzzzy_ = context.Operators.Start(qzzzx_);
            CqlDate qzzzz_ = context.Operators.DateFrom(qzzzy_);
            CqlInterval<CqlDate> rzzza_ = this.First_Two_Years(context);
            bool? rzzzb_ = context.Operators.In<CqlDate>(qzzzz_, rzzza_, "day");

            return rzzzb_;
        };
        IEnumerable<Condition> qzzzw_ = context.Operators.Where<Condition>(qzzzu_, qzzzv_);

        return qzzzw_;
    }


    [CqlExpressionDefinition("Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context)
    {
        CqlValueSet rzzzc_ = this.Mumps(context);
        IEnumerable<Condition> rzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzze_(Condition MumpsDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime rzzzh_ = context.Operators.Start(rzzzg_);
            CqlDate rzzzi_ = context.Operators.DateFrom(rzzzh_);
            CqlInterval<CqlDate> rzzzj_ = this.First_Two_Years(context);
            bool? rzzzk_ = context.Operators.In<CqlDate>(rzzzi_, rzzzj_, "day");

            return rzzzk_;
        };
        IEnumerable<Condition> rzzzf_ = context.Operators.Where<Condition>(rzzzd_, rzzze_);

        return rzzzf_;
    }


    [CqlExpressionDefinition("Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context)
    {
        CqlValueSet rzzzl_ = this.Rubella(context);
        IEnumerable<Condition> rzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzn_(Condition RubellaDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime rzzzq_ = context.Operators.Start(rzzzp_);
            CqlDate rzzzr_ = context.Operators.DateFrom(rzzzq_);
            CqlInterval<CqlDate> rzzzs_ = this.First_Two_Years(context);
            bool? rzzzt_ = context.Operators.In<CqlDate>(rzzzr_, rzzzs_, "day");

            return rzzzt_;
        };
        IEnumerable<Condition> rzzzo_ = context.Operators.Where<Condition>(rzzzm_, rzzzn_);

        return rzzzo_;
    }


    [CqlExpressionDefinition("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet rzzzu_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> rzzzv_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, rzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> rzzzw_ = Status_1_8_000.Instance.isImmunizationAdministered(context, rzzzv_);
        bool? rzzzx_(Immunization ThreeDoseHibVaccine)
        {
            DataType szzzl_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime szzzm_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzl_, "value");
            CqlDateTime szzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzm_ as object);
            CqlDate szzzo_ = context.Operators.DateFrom(szzzn_);
            CqlInterval<CqlDate> szzzp_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? szzzq_ = context.Operators.In<CqlDate>(szzzo_, szzzp_, "day");

            return szzzq_;
        };
        IEnumerable<Immunization> rzzzy_ = context.Operators.Where<Immunization>(rzzzw_, rzzzx_);
        CqlDate rzzzz_(Immunization ThreeDoseHibVaccine)
        {
            DataType szzzr_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime szzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzr_, "value");
            CqlDateTime szzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzs_ as object);
            CqlDate szzzu_ = context.Operators.DateFrom(szzzt_);

            return szzzu_;
        };
        IEnumerable<CqlDate> szzza_ = context.Operators.Select<Immunization, CqlDate>(rzzzy_, rzzzz_);
        IEnumerable<CqlDate> szzzb_ = context.Operators.Distinct<CqlDate>(szzza_);
        CqlValueSet szzzc_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> szzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzze_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzd_);
        bool? szzzf_(Procedure ThreeDoseHibProcedure)
        {
            DataType szzzv_ = ThreeDoseHibProcedure?.Performed;
            object szzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzv_);
            CqlDateTime szzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzw_);
            CqlDate szzzy_ = context.Operators.DateFrom(szzzx_);
            CqlInterval<CqlDate> szzzz_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? tzzza_ = context.Operators.In<CqlDate>(szzzy_, szzzz_, "day");

            return tzzza_;
        };
        IEnumerable<Procedure> szzzg_ = context.Operators.Where<Procedure>(szzze_, szzzf_);
        CqlDate szzzh_(Procedure ThreeDoseHibProcedure)
        {
            DataType tzzzb_ = ThreeDoseHibProcedure?.Performed;
            object tzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzb_);
            CqlDateTime tzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzc_);
            CqlDate tzzze_ = context.Operators.DateFrom(tzzzd_);

            return tzzze_;
        };
        IEnumerable<CqlDate> szzzi_ = context.Operators.Select<Procedure, CqlDate>(szzzg_, szzzh_);
        IEnumerable<CqlDate> szzzj_ = context.Operators.Distinct<CqlDate>(szzzi_);
        IEnumerable<CqlDate> szzzk_ = context.Operators.Union<CqlDate>(szzzb_, szzzj_);

        return szzzk_;
    }


    [CqlExpressionDefinition("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet tzzzf_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> tzzzg_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, tzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> tzzzh_ = Status_1_8_000.Instance.isImmunizationAdministered(context, tzzzg_);
        bool? tzzzi_(Immunization HibVaccine)
        {
            DataType tzzzw_ = HibVaccine?.Occurrence;
            CqlDateTime tzzzx_ = context.Operators.LateBoundProperty<CqlDateTime>(tzzzw_, "value");
            CqlDateTime tzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzx_ as object);
            CqlDate tzzzz_ = context.Operators.DateFrom(tzzzy_);
            CqlInterval<CqlDate> uzzza_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? uzzzb_ = context.Operators.In<CqlDate>(tzzzz_, uzzza_, "day");

            return uzzzb_;
        };
        IEnumerable<Immunization> tzzzj_ = context.Operators.Where<Immunization>(tzzzh_, tzzzi_);
        CqlDate tzzzk_(Immunization HibVaccine)
        {
            DataType uzzzc_ = HibVaccine?.Occurrence;
            CqlDateTime uzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(uzzzc_, "value");
            CqlDateTime uzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzd_ as object);
            CqlDate uzzzf_ = context.Operators.DateFrom(uzzze_);

            return uzzzf_;
        };
        IEnumerable<CqlDate> tzzzl_ = context.Operators.Select<Immunization, CqlDate>(tzzzj_, tzzzk_);
        IEnumerable<CqlDate> tzzzm_ = context.Operators.Distinct<CqlDate>(tzzzl_);
        CqlValueSet tzzzn_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> tzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> tzzzp_ = Status_1_8_000.Instance.isProcedurePerformed(context, tzzzo_);
        bool? tzzzq_(Procedure HibProcedure)
        {
            DataType uzzzg_ = HibProcedure?.Performed;
            object uzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzg_);
            CqlDateTime uzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzh_);
            CqlDate uzzzj_ = context.Operators.DateFrom(uzzzi_);
            CqlInterval<CqlDate> uzzzk_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? uzzzl_ = context.Operators.In<CqlDate>(uzzzj_, uzzzk_, "day");

            return uzzzl_;
        };
        IEnumerable<Procedure> tzzzr_ = context.Operators.Where<Procedure>(tzzzp_, tzzzq_);
        CqlDate tzzzs_(Procedure HibProcedure)
        {
            DataType uzzzm_ = HibProcedure?.Performed;
            object uzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzm_);
            CqlDateTime uzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzn_);
            CqlDate uzzzp_ = context.Operators.DateFrom(uzzzo_);

            return uzzzp_;
        };
        IEnumerable<CqlDate> tzzzt_ = context.Operators.Select<Procedure, CqlDate>(tzzzr_, tzzzs_);
        IEnumerable<CqlDate> tzzzu_ = context.Operators.Distinct<CqlDate>(tzzzt_);
        IEnumerable<CqlDate> tzzzv_ = context.Operators.Union<CqlDate>(tzzzm_, tzzzu_);

        return tzzzv_;
    }


    [CqlExpressionDefinition("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> uzzzq_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> uzzzr_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> uzzzs_ = context.Operators.Union<CqlDate>(uzzzq_, uzzzr_);

        return uzzzs_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> uzzzt_ = this.Hib_3_or_4_Dose_Immunizations(context);
        bool? uzzzu_(CqlDate HibImmunization)
        {
            IEnumerable<CqlDate> uzzzx_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? uzzzy_ = context.Operators.Count<CqlDate>(uzzzx_);
            bool? uzzzz_ = context.Operators.Greater(uzzzy_, 0);
            IEnumerable<CqlDate> vzzza_ = this.Hib_3_or_4_Dose_Immunizations(context);
            CqlDate vzzzb_(CqlDate HibVaccinations)
            {
                CqlDateTime vzzzv_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime vzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzv_);
                CqlDate vzzzx_ = context.Operators.DateFrom(vzzzw_);

                return vzzzx_;
            };
            IEnumerable<CqlDate> vzzzc_ = context.Operators.Select<CqlDate, CqlDate>(vzzza_, vzzzb_);
            IEnumerable<CqlDate> vzzzd_ = context.Operators.Distinct<CqlDate>(vzzzc_);
            IEnumerable<CqlDate> vzzze_ = context.Operators.Distinct<CqlDate>(vzzzd_);
            int? vzzzf_ = context.Operators.Count<CqlDate>(vzzze_);
            bool? vzzzg_ = context.Operators.GreaterOrEqual(vzzzf_, 4);
            bool? vzzzh_ = context.Operators.And(uzzzz_, vzzzg_);
            int? vzzzj_ = context.Operators.Count<CqlDate>(uzzzx_);
            bool? vzzzk_ = context.Operators.Greater(vzzzj_, 0);
            bool? vzzzl_ = context.Operators.IsFalse(vzzzk_);
            CqlDate vzzzn_(CqlDate HibVaccinations)
            {
                CqlDateTime vzzzy_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime vzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzy_);
                CqlDate wzzza_ = context.Operators.DateFrom(vzzzz_);

                return wzzza_;
            };
            IEnumerable<CqlDate> vzzzo_ = context.Operators.Select<CqlDate, CqlDate>(vzzza_, vzzzn_);
            IEnumerable<CqlDate> vzzzp_ = context.Operators.Distinct<CqlDate>(vzzzo_);
            IEnumerable<CqlDate> vzzzq_ = context.Operators.Distinct<CqlDate>(vzzzp_);
            int? vzzzr_ = context.Operators.Count<CqlDate>(vzzzq_);
            bool? vzzzs_ = context.Operators.GreaterOrEqual(vzzzr_, 3);
            bool? vzzzt_ = context.Operators.And(vzzzl_, vzzzs_);
            bool? vzzzu_ = context.Operators.Or(vzzzh_, vzzzt_);

            return vzzzu_;
        };
        IEnumerable<CqlDate> uzzzv_ = context.Operators.Where<CqlDate>(uzzzt_, uzzzu_);
        bool? uzzzw_ = context.Operators.Exists<CqlDate>(uzzzv_);

        return uzzzw_;
    }


    [CqlExpressionDefinition("Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode wzzzb_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> wzzzc_ = context.Operators.ToList<CqlCode>(wzzzb_);
        IEnumerable<Condition> wzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, wzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzze_(Condition HibReaction)
        {
            CqlInterval<CqlDateTime> wzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime wzzzh_ = context.Operators.Start(wzzzg_);
            CqlDate wzzzi_ = context.Operators.DateFrom(wzzzh_);
            CqlInterval<CqlDate> wzzzj_ = this.First_Two_Years(context);
            bool? wzzzk_ = context.Operators.In<CqlDate>(wzzzi_, wzzzj_, "day");

            return wzzzk_;
        };
        IEnumerable<Condition> wzzzf_ = context.Operators.Where<Condition>(wzzzd_, wzzze_);

        return wzzzf_;
    }


    [CqlExpressionDefinition("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet wzzzl_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> wzzzm_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, wzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> wzzzn_ = Status_1_8_000.Instance.isImmunizationAdministered(context, wzzzm_);
        bool? wzzzo_(Immunization HepatitisBVaccination)
        {
            DataType xzzzc_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime xzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(xzzzc_, "value");
            CqlDateTime xzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzd_ as object);
            CqlDate xzzzf_ = context.Operators.DateFrom(xzzze_);
            CqlInterval<CqlDate> xzzzg_ = this.First_Two_Years(context);
            bool? xzzzh_ = context.Operators.In<CqlDate>(xzzzf_, xzzzg_, "day");

            return xzzzh_;
        };
        IEnumerable<Immunization> wzzzp_ = context.Operators.Where<Immunization>(wzzzn_, wzzzo_);
        CqlDate wzzzq_(Immunization HepatitisBVaccination)
        {
            DataType xzzzi_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime xzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(xzzzi_, "value");
            CqlDateTime xzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzj_ as object);
            CqlDate xzzzl_ = context.Operators.DateFrom(xzzzk_);

            return xzzzl_;
        };
        IEnumerable<CqlDate> wzzzr_ = context.Operators.Select<Immunization, CqlDate>(wzzzp_, wzzzq_);
        IEnumerable<CqlDate> wzzzs_ = context.Operators.Distinct<CqlDate>(wzzzr_);
        CqlValueSet wzzzt_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> wzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzv_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzu_);
        bool? wzzzw_(Procedure HepatitisBProcedure)
        {
            DataType xzzzm_ = HepatitisBProcedure?.Performed;
            object xzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzm_);
            CqlDateTime xzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzn_);
            CqlDate xzzzp_ = context.Operators.DateFrom(xzzzo_);
            CqlInterval<CqlDate> xzzzq_ = this.First_Two_Years(context);
            bool? xzzzr_ = context.Operators.In<CqlDate>(xzzzp_, xzzzq_, "day");

            return xzzzr_;
        };
        IEnumerable<Procedure> wzzzx_ = context.Operators.Where<Procedure>(wzzzv_, wzzzw_);
        CqlDate wzzzy_(Procedure HepatitisBProcedure)
        {
            DataType xzzzs_ = HepatitisBProcedure?.Performed;
            object xzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzs_);
            CqlDateTime xzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzt_);
            CqlDate xzzzv_ = context.Operators.DateFrom(xzzzu_);

            return xzzzv_;
        };
        IEnumerable<CqlDate> wzzzz_ = context.Operators.Select<Procedure, CqlDate>(wzzzx_, wzzzy_);
        IEnumerable<CqlDate> xzzza_ = context.Operators.Distinct<CqlDate>(wzzzz_);
        IEnumerable<CqlDate> xzzzb_ = context.Operators.Union<CqlDate>(wzzzs_, xzzza_);

        return xzzzb_;
    }


    [CqlExpressionDefinition("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> xzzzw_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> xzzzz_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(xzzzw_, xzzzw_, xzzzw_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? yzzza_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? yzzzh_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return yzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> yzzzb_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(xzzzz_, yzzza_);
        bool? yzzzc_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime yzzzi_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime yzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzi_);
            CqlDate yzzzk_ = context.Operators.DateFrom(yzzzj_);
            CqlDateTime yzzzl_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime yzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzl_);
            CqlDate yzzzn_ = context.Operators.DateFrom(yzzzm_);
            CqlQuantity yzzzo_ = context.Operators.Quantity(1m, "day");
            CqlDate yzzzp_ = context.Operators.Add(yzzzn_, yzzzo_);
            bool? yzzzq_ = context.Operators.SameOrAfter(yzzzk_, yzzzp_, default);
            CqlDateTime yzzzr_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
            CqlDateTime yzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzr_);
            CqlDate yzzzt_ = context.Operators.DateFrom(yzzzs_);
            CqlDateTime yzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzi_);
            CqlDate yzzzw_ = context.Operators.DateFrom(yzzzv_);
            CqlDate yzzzy_ = context.Operators.Add(yzzzw_, yzzzo_);
            bool? yzzzz_ = context.Operators.SameOrAfter(yzzzt_, yzzzy_, default);
            bool? zzzza_ = context.Operators.And(yzzzq_, yzzzz_);

            return zzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> yzzzd_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(yzzzb_, yzzzc_);
        CqlDate yzzze_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime zzzzb_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime zzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzb_);
            CqlDate zzzzd_ = context.Operators.DateFrom(zzzzc_);

            return zzzzd_;
        };
        IEnumerable<CqlDate> yzzzf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(yzzzd_, yzzze_);
        IEnumerable<CqlDate> yzzzg_ = context.Operators.Distinct<CqlDate>(yzzzf_);

        return yzzzg_;
    }


    [CqlExpressionDefinition("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context)
    {
        CqlCode zzzze_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> zzzzf_ = context.Operators.ToList<CqlCode>(zzzze_);
        IEnumerable<Procedure> zzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, zzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzg_);
        bool? zzzzi_(Procedure NewBornVaccine)
        {
            DataType zzzzn_ = NewBornVaccine?.Performed;
            object zzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzn_);
            CqlDateTime zzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzo_);
            CqlDate zzzzq_ = context.Operators.DateFrom(zzzzp_);
            Patient zzzzr_ = this.Patient(context);
            Date zzzzs_ = zzzzr_?.BirthDateElement;
            string zzzzt_ = zzzzs_?.Value;
            CqlDate zzzzu_ = context.Operators.ConvertStringToDate(zzzzt_);
            CqlDateTime zzzzv_ = context.Operators.ConvertDateToDateTime(zzzzu_);
            CqlDate zzzzw_ = context.Operators.DateFrom(zzzzv_);
            Date zzzzy_ = zzzzr_?.BirthDateElement;
            string zzzzz_ = zzzzy_?.Value;
            CqlDate azzzza_ = context.Operators.ConvertStringToDate(zzzzz_);
            CqlDateTime azzzzb_ = context.Operators.ConvertDateToDateTime(azzzza_);
            CqlDate azzzzc_ = context.Operators.DateFrom(azzzzb_);
            CqlQuantity azzzzd_ = context.Operators.Quantity(7m, "days");
            CqlDate azzzze_ = context.Operators.Add(azzzzc_, azzzzd_);
            CqlInterval<CqlDate> azzzzf_ = context.Operators.Interval(zzzzw_, azzzze_, true, true);
            bool? azzzzg_ = context.Operators.In<CqlDate>(zzzzq_, azzzzf_, "day");

            return azzzzg_;
        };
        IEnumerable<Procedure> zzzzj_ = context.Operators.Where<Procedure>(zzzzh_, zzzzi_);
        CqlDate zzzzk_(Procedure NewBornVaccine)
        {
            DataType azzzzh_ = NewBornVaccine?.Performed;
            object azzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzh_);
            CqlDateTime azzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzi_);
            CqlDate azzzzk_ = context.Operators.DateFrom(azzzzj_);

            return azzzzk_;
        };
        IEnumerable<CqlDate> zzzzl_ = context.Operators.Select<Procedure, CqlDate>(zzzzj_, zzzzk_);
        IEnumerable<CqlDate> zzzzm_ = context.Operators.Distinct<CqlDate>(zzzzl_);

        return zzzzm_;
    }


    [CqlExpressionDefinition("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzl_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> azzzzn_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> azzzzo_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(azzzzl_, azzzzl_, azzzzn_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? azzzzp_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? azzzzw_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return azzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> azzzzq_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(azzzzo_, azzzzp_);
        bool? azzzzr_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime azzzzx_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime azzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzx_);
            CqlDate azzzzz_ = context.Operators.DateFrom(azzzzy_);
            CqlDateTime bzzzza_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime bzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzza_);
            CqlDate bzzzzc_ = context.Operators.DateFrom(bzzzzb_);
            CqlQuantity bzzzzd_ = context.Operators.Quantity(1m, "day");
            CqlDate bzzzze_ = context.Operators.Add(bzzzzc_, bzzzzd_);
            bool? bzzzzf_ = context.Operators.SameOrAfter(azzzzz_, bzzzze_, default);
            CqlDateTime bzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzza_);
            CqlDate bzzzzi_ = context.Operators.DateFrom(bzzzzh_);
            CqlDateTime bzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
            CqlDateTime bzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzj_);
            CqlDate bzzzzl_ = context.Operators.DateFrom(bzzzzk_);
            CqlDate bzzzzn_ = context.Operators.Add(bzzzzl_, bzzzzd_);
            bool? bzzzzo_ = context.Operators.SameOrAfter(bzzzzi_, bzzzzn_, default);
            bool? bzzzzp_ = context.Operators.And(bzzzzf_, bzzzzo_);
            CqlDateTime bzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzx_);
            CqlDate bzzzzs_ = context.Operators.DateFrom(bzzzzr_);
            CqlDateTime bzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzj_);
            CqlDate bzzzzv_ = context.Operators.DateFrom(bzzzzu_);
            CqlDate bzzzzx_ = context.Operators.Add(bzzzzv_, bzzzzd_);
            bool? bzzzzy_ = context.Operators.SameOrAfter(bzzzzs_, bzzzzx_, default);
            bool? bzzzzz_ = context.Operators.And(bzzzzp_, bzzzzy_);

            return bzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> azzzzs_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(azzzzq_, azzzzr_);
        CqlDate azzzzt_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime czzzza_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime czzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzza_);
            CqlDate czzzzc_ = context.Operators.DateFrom(czzzzb_);

            return czzzzc_;
        };
        IEnumerable<CqlDate> azzzzu_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(azzzzs_, azzzzt_);
        IEnumerable<CqlDate> azzzzv_ = context.Operators.Distinct<CqlDate>(azzzzu_);

        return azzzzv_;
    }


    [CqlExpressionDefinition("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode czzzzd_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> czzzze_ = context.Operators.ToList<CqlCode>(czzzzd_);
        IEnumerable<Condition> czzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, czzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet czzzzg_ = this.Hepatitis_B(context);
        IEnumerable<Condition> czzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzi_ = context.Operators.Union<Condition>(czzzzf_, czzzzh_);
        bool? czzzzj_(Condition HepBConditions)
        {
            CqlInterval<CqlDateTime> czzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime czzzzm_ = context.Operators.Start(czzzzl_);
            CqlDate czzzzn_ = context.Operators.DateFrom(czzzzm_);
            CqlInterval<CqlDate> czzzzo_ = this.First_Two_Years(context);
            bool? czzzzp_ = context.Operators.In<CqlDate>(czzzzn_, czzzzo_, "day");

            return czzzzp_;
        };
        IEnumerable<Condition> czzzzk_ = context.Operators.Where<Condition>(czzzzi_, czzzzj_);

        return czzzzk_;
    }


    [CqlExpressionDefinition("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context)
    {
        CqlValueSet czzzzq_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> czzzzr_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, czzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> czzzzs_ = Status_1_8_000.Instance.isImmunizationAdministered(context, czzzzr_);
        bool? czzzzt_(Immunization ChickenPoxVaccination)
        {
            DataType dzzzzh_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime dzzzzi_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzh_, "value");
            CqlDateTime dzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzi_ as object);
            CqlDate dzzzzk_ = context.Operators.DateFrom(dzzzzj_);
            CqlInterval<CqlDate> dzzzzl_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? dzzzzm_ = context.Operators.In<CqlDate>(dzzzzk_, dzzzzl_, default);

            return dzzzzm_;
        };
        IEnumerable<Immunization> czzzzu_ = context.Operators.Where<Immunization>(czzzzs_, czzzzt_);
        CqlDate czzzzv_(Immunization ChickenPoxVaccination)
        {
            DataType dzzzzn_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime dzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzn_, "value");
            CqlDateTime dzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzo_ as object);
            CqlDate dzzzzq_ = context.Operators.DateFrom(dzzzzp_);

            return dzzzzq_;
        };
        IEnumerable<CqlDate> czzzzw_ = context.Operators.Select<Immunization, CqlDate>(czzzzu_, czzzzv_);
        IEnumerable<CqlDate> czzzzx_ = context.Operators.Distinct<CqlDate>(czzzzw_);
        CqlValueSet czzzzy_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> czzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzza_ = Status_1_8_000.Instance.isProcedurePerformed(context, czzzzz_);
        bool? dzzzzb_(Procedure ChickenPoxProcedure)
        {
            DataType dzzzzr_ = ChickenPoxProcedure?.Performed;
            object dzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzr_);
            CqlDateTime dzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzs_);
            CqlDate dzzzzu_ = context.Operators.DateFrom(dzzzzt_);
            CqlInterval<CqlDate> dzzzzv_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? dzzzzw_ = context.Operators.In<CqlDate>(dzzzzu_, dzzzzv_, default);

            return dzzzzw_;
        };
        IEnumerable<Procedure> dzzzzc_ = context.Operators.Where<Procedure>(dzzzza_, dzzzzb_);
        CqlDate dzzzzd_(Procedure ChickenPoxProcedure)
        {
            DataType dzzzzx_ = ChickenPoxProcedure?.Performed;
            object dzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzx_);
            CqlDateTime dzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzy_);
            CqlDate ezzzza_ = context.Operators.DateFrom(dzzzzz_);

            return ezzzza_;
        };
        IEnumerable<CqlDate> dzzzze_ = context.Operators.Select<Procedure, CqlDate>(dzzzzc_, dzzzzd_);
        IEnumerable<CqlDate> dzzzzf_ = context.Operators.Distinct<CqlDate>(dzzzze_);
        IEnumerable<CqlDate> dzzzzg_ = context.Operators.Union<CqlDate>(czzzzx_, dzzzzf_);

        return dzzzzg_;
    }


    [CqlExpressionDefinition("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet ezzzzb_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> ezzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode ezzzzd_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> ezzzze_ = context.Operators.ToList<CqlCode>(ezzzzd_);
        IEnumerable<Condition> ezzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ezzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzg_ = context.Operators.Union<Condition>(ezzzzc_, ezzzzf_);
        bool? ezzzzh_(Condition VaricellaZoster)
        {
            CqlInterval<CqlDateTime> ezzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime ezzzzk_ = context.Operators.Start(ezzzzj_);
            CqlDate ezzzzl_ = context.Operators.DateFrom(ezzzzk_);
            CqlInterval<CqlDate> ezzzzm_ = this.First_Two_Years(context);
            bool? ezzzzn_ = context.Operators.In<CqlDate>(ezzzzl_, ezzzzm_, "day");

            return ezzzzn_;
        };
        IEnumerable<Condition> ezzzzi_ = context.Operators.Where<Condition>(ezzzzg_, ezzzzh_);

        return ezzzzi_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet ezzzzo_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> ezzzzp_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, ezzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> ezzzzq_ = Status_1_8_000.Instance.isImmunizationAdministered(context, ezzzzp_);
        bool? ezzzzr_(Immunization PneumococcalVaccination)
        {
            DataType fzzzzf_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime fzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(fzzzzf_, "value");
            CqlDateTime fzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzg_ as object);
            CqlDate fzzzzi_ = context.Operators.DateFrom(fzzzzh_);
            CqlInterval<CqlDate> fzzzzj_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? fzzzzk_ = context.Operators.In<CqlDate>(fzzzzi_, fzzzzj_, "day");

            return fzzzzk_;
        };
        IEnumerable<Immunization> ezzzzs_ = context.Operators.Where<Immunization>(ezzzzq_, ezzzzr_);
        CqlDate ezzzzt_(Immunization PneumococcalVaccination)
        {
            DataType fzzzzl_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime fzzzzm_ = context.Operators.LateBoundProperty<CqlDateTime>(fzzzzl_, "value");
            CqlDateTime fzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzm_ as object);
            CqlDate fzzzzo_ = context.Operators.DateFrom(fzzzzn_);

            return fzzzzo_;
        };
        IEnumerable<CqlDate> ezzzzu_ = context.Operators.Select<Immunization, CqlDate>(ezzzzs_, ezzzzt_);
        IEnumerable<CqlDate> ezzzzv_ = context.Operators.Distinct<CqlDate>(ezzzzu_);
        CqlValueSet ezzzzw_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> ezzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzy_ = Status_1_8_000.Instance.isProcedurePerformed(context, ezzzzx_);
        bool? ezzzzz_(Procedure PneumococcalProcedure)
        {
            DataType fzzzzp_ = PneumococcalProcedure?.Performed;
            object fzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzp_);
            CqlDateTime fzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzq_);
            CqlDate fzzzzs_ = context.Operators.DateFrom(fzzzzr_);
            CqlInterval<CqlDate> fzzzzt_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? fzzzzu_ = context.Operators.In<CqlDate>(fzzzzs_, fzzzzt_, "day");

            return fzzzzu_;
        };
        IEnumerable<Procedure> fzzzza_ = context.Operators.Where<Procedure>(ezzzzy_, ezzzzz_);
        CqlDate fzzzzb_(Procedure PneumococcalProcedure)
        {
            DataType fzzzzv_ = PneumococcalProcedure?.Performed;
            object fzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzv_);
            CqlDateTime fzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzw_);
            CqlDate fzzzzy_ = context.Operators.DateFrom(fzzzzx_);

            return fzzzzy_;
        };
        IEnumerable<CqlDate> fzzzzc_ = context.Operators.Select<Procedure, CqlDate>(fzzzza_, fzzzzb_);
        IEnumerable<CqlDate> fzzzzd_ = context.Operators.Distinct<CqlDate>(fzzzzc_);
        IEnumerable<CqlDate> fzzzze_ = context.Operators.Union<CqlDate>(ezzzzv_, fzzzzd_);

        return fzzzze_;
    }


    [CqlExpressionDefinition("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> fzzzzz_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> gzzzzd_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(fzzzzz_, fzzzzz_, fzzzzz_, fzzzzz_);
        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? gzzzze_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? gzzzzl_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return gzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> gzzzzf_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(gzzzzd_, gzzzze_);
        bool? gzzzzg_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime gzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime gzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzm_);
            CqlDate gzzzzo_ = context.Operators.DateFrom(gzzzzn_);
            CqlDateTime gzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime gzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzp_);
            CqlDate gzzzzr_ = context.Operators.DateFrom(gzzzzq_);
            CqlQuantity gzzzzs_ = context.Operators.Quantity(1m, "day");
            CqlDate gzzzzt_ = context.Operators.Add(gzzzzr_, gzzzzs_);
            bool? gzzzzu_ = context.Operators.SameOrAfter(gzzzzo_, gzzzzt_, default);
            CqlDateTime gzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
            CqlDateTime gzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzv_);
            CqlDate gzzzzx_ = context.Operators.DateFrom(gzzzzw_);
            CqlDateTime gzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzm_);
            CqlDate hzzzza_ = context.Operators.DateFrom(gzzzzz_);
            CqlDate hzzzzc_ = context.Operators.Add(hzzzza_, gzzzzs_);
            bool? hzzzzd_ = context.Operators.SameOrAfter(gzzzzx_, hzzzzc_, default);
            bool? hzzzze_ = context.Operators.And(gzzzzu_, hzzzzd_);
            CqlDateTime hzzzzf_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
            CqlDateTime hzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzf_);
            CqlDate hzzzzh_ = context.Operators.DateFrom(hzzzzg_);
            CqlDateTime hzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzv_);
            CqlDate hzzzzk_ = context.Operators.DateFrom(hzzzzj_);
            CqlDate hzzzzm_ = context.Operators.Add(hzzzzk_, gzzzzs_);
            bool? hzzzzn_ = context.Operators.SameOrAfter(hzzzzh_, hzzzzm_, default);
            bool? hzzzzo_ = context.Operators.And(hzzzze_, hzzzzn_);

            return hzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> gzzzzh_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(gzzzzf_, gzzzzg_);
        CqlDate gzzzzi_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime hzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime hzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzp_);
            CqlDate hzzzzr_ = context.Operators.DateFrom(hzzzzq_);

            return hzzzzr_;
        };
        IEnumerable<CqlDate> gzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(gzzzzh_, gzzzzi_);
        IEnumerable<CqlDate> gzzzzk_ = context.Operators.Distinct<CqlDate>(gzzzzj_);

        return gzzzzk_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode hzzzzs_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> hzzzzt_ = context.Operators.ToList<CqlCode>(hzzzzs_);
        IEnumerable<Condition> hzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, hzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzv_(Condition PneumococcalReaction)
        {
            CqlInterval<CqlDateTime> hzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime hzzzzy_ = context.Operators.Start(hzzzzx_);
            CqlDate hzzzzz_ = context.Operators.DateFrom(hzzzzy_);
            CqlInterval<CqlDate> izzzza_ = this.First_Two_Years(context);
            bool? izzzzb_ = context.Operators.In<CqlDate>(hzzzzz_, izzzza_, "day");

            return izzzzb_;
        };
        IEnumerable<Condition> hzzzzw_ = context.Operators.Where<Condition>(hzzzzu_, hzzzzv_);

        return hzzzzw_;
    }


    [CqlExpressionDefinition("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context)
    {
        CqlValueSet izzzzc_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> izzzzd_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, izzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> izzzze_ = Status_1_8_000.Instance.isImmunizationAdministered(context, izzzzd_);
        bool? izzzzf_(Immunization HepatitisAVaccination)
        {
            DataType izzzzt_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime izzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzt_, "value");
            CqlDateTime izzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzu_ as object);
            CqlDate izzzzw_ = context.Operators.DateFrom(izzzzv_);
            CqlInterval<CqlDate> izzzzx_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? izzzzy_ = context.Operators.In<CqlDate>(izzzzw_, izzzzx_, default);

            return izzzzy_;
        };
        IEnumerable<Immunization> izzzzg_ = context.Operators.Where<Immunization>(izzzze_, izzzzf_);
        CqlDate izzzzh_(Immunization HepatitisAVaccination)
        {
            DataType izzzzz_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime jzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzz_, "value");
            CqlDateTime jzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzza_ as object);
            CqlDate jzzzzc_ = context.Operators.DateFrom(jzzzzb_);

            return jzzzzc_;
        };
        IEnumerable<CqlDate> izzzzi_ = context.Operators.Select<Immunization, CqlDate>(izzzzg_, izzzzh_);
        IEnumerable<CqlDate> izzzzj_ = context.Operators.Distinct<CqlDate>(izzzzi_);
        CqlValueSet izzzzk_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> izzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> izzzzm_ = Status_1_8_000.Instance.isProcedurePerformed(context, izzzzl_);
        bool? izzzzn_(Procedure HepatitisAProcedure)
        {
            DataType jzzzzd_ = HepatitisAProcedure?.Performed;
            object jzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzd_);
            CqlDateTime jzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzze_);
            CqlDate jzzzzg_ = context.Operators.DateFrom(jzzzzf_);
            CqlInterval<CqlDate> jzzzzh_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? jzzzzi_ = context.Operators.In<CqlDate>(jzzzzg_, jzzzzh_, default);

            return jzzzzi_;
        };
        IEnumerable<Procedure> izzzzo_ = context.Operators.Where<Procedure>(izzzzm_, izzzzn_);
        CqlDate izzzzp_(Procedure HepatitisAProcedure)
        {
            DataType jzzzzj_ = HepatitisAProcedure?.Performed;
            object jzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzj_);
            CqlDateTime jzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzk_);
            CqlDate jzzzzm_ = context.Operators.DateFrom(jzzzzl_);

            return jzzzzm_;
        };
        IEnumerable<CqlDate> izzzzq_ = context.Operators.Select<Procedure, CqlDate>(izzzzo_, izzzzp_);
        IEnumerable<CqlDate> izzzzr_ = context.Operators.Distinct<CqlDate>(izzzzq_);
        IEnumerable<CqlDate> izzzzs_ = context.Operators.Union<CqlDate>(izzzzj_, izzzzr_);

        return izzzzs_;
    }


    [CqlExpressionDefinition("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet jzzzzn_ = this.Hepatitis_A(context);
        IEnumerable<Condition> jzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode jzzzzp_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> jzzzzq_ = context.Operators.ToList<CqlCode>(jzzzzp_);
        IEnumerable<Condition> jzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, jzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzs_ = context.Operators.Union<Condition>(jzzzzo_, jzzzzr_);
        bool? jzzzzt_(Condition HepatitisADiagnosis)
        {
            CqlInterval<CqlDateTime> jzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime jzzzzw_ = context.Operators.Start(jzzzzv_);
            CqlDate jzzzzx_ = context.Operators.DateFrom(jzzzzw_);
            CqlInterval<CqlDate> jzzzzy_ = this.First_Two_Years(context);
            bool? jzzzzz_ = context.Operators.In<CqlDate>(jzzzzx_, jzzzzy_, "day");

            return jzzzzz_;
        };
        IEnumerable<Condition> jzzzzu_ = context.Operators.Where<Condition>(jzzzzs_, jzzzzt_);

        return jzzzzu_;
    }


    [CqlExpressionDefinition("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlCode kzzzza_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> kzzzzb_ = context.Operators.ToList<CqlCode>(kzzzza_);
        IEnumerable<Immunization> kzzzzc_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, kzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> kzzzzd_ = Status_1_8_000.Instance.isImmunizationAdministered(context, kzzzzc_);
        bool? kzzzze_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType kzzzzs_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime kzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(kzzzzs_, "value");
            CqlDateTime kzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzt_ as object);
            CqlDate kzzzzv_ = context.Operators.DateFrom(kzzzzu_);
            CqlInterval<CqlDate> kzzzzw_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? kzzzzx_ = context.Operators.In<CqlDate>(kzzzzv_, kzzzzw_, "day");

            return kzzzzx_;
        };
        IEnumerable<Immunization> kzzzzf_ = context.Operators.Where<Immunization>(kzzzzd_, kzzzze_);
        CqlDate kzzzzg_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType kzzzzy_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime kzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(kzzzzy_, "value");
            CqlDateTime lzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzz_ as object);
            CqlDate lzzzzb_ = context.Operators.DateFrom(lzzzza_);

            return lzzzzb_;
        };
        IEnumerable<CqlDate> kzzzzh_ = context.Operators.Select<Immunization, CqlDate>(kzzzzf_, kzzzzg_);
        IEnumerable<CqlDate> kzzzzi_ = context.Operators.Distinct<CqlDate>(kzzzzh_);
        CqlValueSet kzzzzj_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> kzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzl_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzk_);
        bool? kzzzzm_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType lzzzzc_ = TwoDoseRotavirusProcedure?.Performed;
            object lzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzc_);
            CqlDateTime lzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzd_);
            CqlDate lzzzzf_ = context.Operators.DateFrom(lzzzze_);
            CqlInterval<CqlDate> lzzzzg_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? lzzzzh_ = context.Operators.In<CqlDate>(lzzzzf_, lzzzzg_, "day");

            return lzzzzh_;
        };
        IEnumerable<Procedure> kzzzzn_ = context.Operators.Where<Procedure>(kzzzzl_, kzzzzm_);
        CqlDate kzzzzo_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType lzzzzi_ = TwoDoseRotavirusProcedure?.Performed;
            object lzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzi_);
            CqlDateTime lzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzj_);
            CqlDate lzzzzl_ = context.Operators.DateFrom(lzzzzk_);

            return lzzzzl_;
        };
        IEnumerable<CqlDate> kzzzzp_ = context.Operators.Select<Procedure, CqlDate>(kzzzzn_, kzzzzo_);
        IEnumerable<CqlDate> kzzzzq_ = context.Operators.Distinct<CqlDate>(kzzzzp_);
        IEnumerable<CqlDate> kzzzzr_ = context.Operators.Union<CqlDate>(kzzzzi_, kzzzzq_);

        return kzzzzr_;
    }


    [CqlExpressionDefinition("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet lzzzzm_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> lzzzzn_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, lzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> lzzzzo_ = Status_1_8_000.Instance.isImmunizationAdministered(context, lzzzzn_);
        bool? lzzzzp_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType mzzzzd_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime mzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(mzzzzd_, "value");
            CqlDateTime mzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzze_ as object);
            CqlDate mzzzzg_ = context.Operators.DateFrom(mzzzzf_);
            CqlInterval<CqlDate> mzzzzh_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? mzzzzi_ = context.Operators.In<CqlDate>(mzzzzg_, mzzzzh_, "day");

            return mzzzzi_;
        };
        IEnumerable<Immunization> lzzzzq_ = context.Operators.Where<Immunization>(lzzzzo_, lzzzzp_);
        CqlDate lzzzzr_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType mzzzzj_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime mzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(mzzzzj_, "value");
            CqlDateTime mzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzk_ as object);
            CqlDate mzzzzm_ = context.Operators.DateFrom(mzzzzl_);

            return mzzzzm_;
        };
        IEnumerable<CqlDate> lzzzzs_ = context.Operators.Select<Immunization, CqlDate>(lzzzzq_, lzzzzr_);
        IEnumerable<CqlDate> lzzzzt_ = context.Operators.Distinct<CqlDate>(lzzzzs_);
        CqlValueSet lzzzzu_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> lzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzw_ = Status_1_8_000.Instance.isProcedurePerformed(context, lzzzzv_);
        bool? lzzzzx_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType mzzzzn_ = ThreeDoseRotavirusAdministered?.Performed;
            object mzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzn_);
            CqlDateTime mzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzo_);
            CqlDate mzzzzq_ = context.Operators.DateFrom(mzzzzp_);
            CqlInterval<CqlDate> mzzzzr_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? mzzzzs_ = context.Operators.In<CqlDate>(mzzzzq_, mzzzzr_, "day");

            return mzzzzs_;
        };
        IEnumerable<Procedure> lzzzzy_ = context.Operators.Where<Procedure>(lzzzzw_, lzzzzx_);
        CqlDate lzzzzz_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType mzzzzt_ = ThreeDoseRotavirusAdministered?.Performed;
            object mzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzt_);
            CqlDateTime mzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzu_);
            CqlDate mzzzzw_ = context.Operators.DateFrom(mzzzzv_);

            return mzzzzw_;
        };
        IEnumerable<CqlDate> mzzzza_ = context.Operators.Select<Procedure, CqlDate>(lzzzzy_, lzzzzz_);
        IEnumerable<CqlDate> mzzzzb_ = context.Operators.Distinct<CqlDate>(mzzzza_);
        IEnumerable<CqlDate> mzzzzc_ = context.Operators.Union<CqlDate>(lzzzzt_, mzzzzb_);

        return mzzzzc_;
    }


    [CqlExpressionDefinition("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> mzzzzx_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> mzzzzy_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> mzzzzz_ = context.Operators.Union<CqlDate>(mzzzzx_, mzzzzy_);

        return mzzzzz_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> nzzzza_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
        bool? nzzzzb_(CqlDate RotavirusImmunization)
        {
            IEnumerable<CqlDate> nzzzze_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? nzzzzf_ = context.Operators.Count<CqlDate>(nzzzze_);
            bool? nzzzzg_ = context.Operators.Greater(nzzzzf_, 0);
            IEnumerable<CqlDate> nzzzzh_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
            CqlDate nzzzzi_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime ozzzzc_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime ozzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzc_);
                CqlDate ozzzze_ = context.Operators.DateFrom(ozzzzd_);

                return ozzzze_;
            };
            IEnumerable<CqlDate> nzzzzj_ = context.Operators.Select<CqlDate, CqlDate>(nzzzzh_, nzzzzi_);
            IEnumerable<CqlDate> nzzzzk_ = context.Operators.Distinct<CqlDate>(nzzzzj_);
            IEnumerable<CqlDate> nzzzzl_ = context.Operators.Distinct<CqlDate>(nzzzzk_);
            int? nzzzzm_ = context.Operators.Count<CqlDate>(nzzzzl_);
            bool? nzzzzn_ = context.Operators.GreaterOrEqual(nzzzzm_, 3);
            bool? nzzzzo_ = context.Operators.And(nzzzzg_, nzzzzn_);
            int? nzzzzq_ = context.Operators.Count<CqlDate>(nzzzze_);
            bool? nzzzzr_ = context.Operators.Greater(nzzzzq_, 0);
            bool? nzzzzs_ = context.Operators.IsFalse(nzzzzr_);
            CqlDate nzzzzu_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime ozzzzf_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime ozzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzf_);
                CqlDate ozzzzh_ = context.Operators.DateFrom(ozzzzg_);

                return ozzzzh_;
            };
            IEnumerable<CqlDate> nzzzzv_ = context.Operators.Select<CqlDate, CqlDate>(nzzzzh_, nzzzzu_);
            IEnumerable<CqlDate> nzzzzw_ = context.Operators.Distinct<CqlDate>(nzzzzv_);
            IEnumerable<CqlDate> nzzzzx_ = context.Operators.Distinct<CqlDate>(nzzzzw_);
            int? nzzzzy_ = context.Operators.Count<CqlDate>(nzzzzx_);
            bool? nzzzzz_ = context.Operators.GreaterOrEqual(nzzzzy_, 2);
            bool? ozzzza_ = context.Operators.And(nzzzzs_, nzzzzz_);
            bool? ozzzzb_ = context.Operators.Or(nzzzzo_, ozzzza_);

            return ozzzzb_;
        };
        IEnumerable<CqlDate> nzzzzc_ = context.Operators.Where<CqlDate>(nzzzza_, nzzzzb_);
        bool? nzzzzd_ = context.Operators.Exists<CqlDate>(nzzzzc_);

        return nzzzzd_;
    }


    [CqlExpressionDefinition("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode ozzzzi_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> ozzzzj_ = context.Operators.ToList<CqlCode>(ozzzzi_);
        IEnumerable<Condition> ozzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ozzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzl_(Condition RotavirusConditions)
        {
            CqlInterval<CqlDateTime> ozzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime ozzzzo_ = context.Operators.Start(ozzzzn_);
            CqlDate ozzzzp_ = context.Operators.DateFrom(ozzzzo_);
            CqlInterval<CqlDate> ozzzzq_ = this.First_Two_Years(context);
            bool? ozzzzr_ = context.Operators.In<CqlDate>(ozzzzp_, ozzzzq_, "day");

            return ozzzzr_;
        };
        IEnumerable<Condition> ozzzzm_ = context.Operators.Where<Condition>(ozzzzk_, ozzzzl_);

        return ozzzzm_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient ozzzzs_ = this.Patient(context);
        Date ozzzzt_ = ozzzzs_?.BirthDateElement;
        string ozzzzu_ = ozzzzt_?.Value;
        CqlDate ozzzzv_ = context.Operators.ConvertStringToDate(ozzzzu_);
        CqlDateTime ozzzzw_ = context.Operators.ConvertDateToDateTime(ozzzzv_);
        CqlDate ozzzzx_ = context.Operators.DateFrom(ozzzzw_);
        CqlQuantity ozzzzy_ = context.Operators.Quantity(180m, "days");
        CqlDate ozzzzz_ = context.Operators.Add(ozzzzx_, ozzzzy_);
        CqlDate pzzzza_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> pzzzzb_ = context.Operators.Interval(ozzzzz_, pzzzza_, true, true);

        return pzzzzb_;
    }


    [CqlExpressionDefinition("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet pzzzzc_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> pzzzzd_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, pzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> pzzzze_ = Status_1_8_000.Instance.isImmunizationAdministered(context, pzzzzd_);
        bool? pzzzzf_(Immunization InfluenzaVaccine)
        {
            DataType pzzzzt_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime pzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzzt_, "value");
            CqlDateTime pzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzu_ as object);
            CqlDate pzzzzw_ = context.Operators.DateFrom(pzzzzv_);
            CqlInterval<CqlDate> pzzzzx_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? pzzzzy_ = context.Operators.In<CqlDate>(pzzzzw_, pzzzzx_, "day");

            return pzzzzy_;
        };
        IEnumerable<Immunization> pzzzzg_ = context.Operators.Where<Immunization>(pzzzze_, pzzzzf_);
        CqlDate pzzzzh_(Immunization InfluenzaVaccine)
        {
            DataType pzzzzz_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime qzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzzz_, "value");
            CqlDateTime qzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzza_ as object);
            CqlDate qzzzzc_ = context.Operators.DateFrom(qzzzzb_);

            return qzzzzc_;
        };
        IEnumerable<CqlDate> pzzzzi_ = context.Operators.Select<Immunization, CqlDate>(pzzzzg_, pzzzzh_);
        IEnumerable<CqlDate> pzzzzj_ = context.Operators.Distinct<CqlDate>(pzzzzi_);
        CqlValueSet pzzzzk_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> pzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> pzzzzm_ = Status_1_8_000.Instance.isProcedurePerformed(context, pzzzzl_);
        bool? pzzzzn_(Procedure InfluenzaAdministration)
        {
            DataType qzzzzd_ = InfluenzaAdministration?.Performed;
            object qzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzd_);
            CqlDateTime qzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzze_);
            CqlDate qzzzzg_ = context.Operators.DateFrom(qzzzzf_);
            CqlInterval<CqlDate> qzzzzh_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? qzzzzi_ = context.Operators.In<CqlDate>(qzzzzg_, qzzzzh_, "day");

            return qzzzzi_;
        };
        IEnumerable<Procedure> pzzzzo_ = context.Operators.Where<Procedure>(pzzzzm_, pzzzzn_);
        CqlDate pzzzzp_(Procedure InfluenzaAdministration)
        {
            DataType qzzzzj_ = InfluenzaAdministration?.Performed;
            object qzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzj_);
            CqlDateTime qzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzk_);
            CqlDate qzzzzm_ = context.Operators.DateFrom(qzzzzl_);

            return qzzzzm_;
        };
        IEnumerable<CqlDate> pzzzzq_ = context.Operators.Select<Procedure, CqlDate>(pzzzzo_, pzzzzp_);
        IEnumerable<CqlDate> pzzzzr_ = context.Operators.Distinct<CqlDate>(pzzzzq_);
        IEnumerable<CqlDate> pzzzzs_ = context.Operators.Union<CqlDate>(pzzzzj_, pzzzzr_);

        return pzzzzs_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> qzzzzn_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> qzzzzp_ = context.Operators.CrossJoin<CqlDate, CqlDate>(qzzzzn_, qzzzzn_);
        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? qzzzzq_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? qzzzzx_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

            return qzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> qzzzzr_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(qzzzzp_, qzzzzq_);
        bool? qzzzzs_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime qzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime qzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzy_);
            CqlDate rzzzza_ = context.Operators.DateFrom(qzzzzz_);
            CqlDateTime rzzzzb_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime rzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzb_);
            CqlDate rzzzzd_ = context.Operators.DateFrom(rzzzzc_);
            CqlQuantity rzzzze_ = context.Operators.Quantity(1m, "day");
            CqlDate rzzzzf_ = context.Operators.Add(rzzzzd_, rzzzze_);
            bool? rzzzzg_ = context.Operators.SameOrAfter(rzzzza_, rzzzzf_, default);

            return rzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> qzzzzt_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(qzzzzr_, qzzzzs_);
        CqlDate qzzzzu_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime rzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime rzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzh_);
            CqlDate rzzzzj_ = context.Operators.DateFrom(rzzzzi_);

            return rzzzzj_;
        };
        IEnumerable<CqlDate> qzzzzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(qzzzzt_, qzzzzu_);
        IEnumerable<CqlDate> qzzzzw_ = context.Operators.Distinct<CqlDate>(qzzzzv_);

        return qzzzzw_;
    }


    [CqlExpressionDefinition("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context)
    {
        CqlValueSet rzzzzk_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> rzzzzl_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, rzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> rzzzzm_ = Status_1_8_000.Instance.isImmunizationAdministered(context, rzzzzl_);
        bool? rzzzzn_(Immunization LAIVVaccine)
        {
            DataType szzzzb_ = LAIVVaccine?.Occurrence;
            CqlDateTime szzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzb_, "value");
            CqlDateTime szzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzc_ as object);
            CqlDate szzzze_ = context.Operators.DateFrom(szzzzd_);
            CqlDate szzzzf_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> szzzzh_ = context.Operators.Interval(szzzzf_, szzzzf_, true, true);
            bool? szzzzi_ = context.Operators.In<CqlDate>(szzzze_, szzzzh_, "day");

            return szzzzi_;
        };
        IEnumerable<Immunization> rzzzzo_ = context.Operators.Where<Immunization>(rzzzzm_, rzzzzn_);
        CqlDate rzzzzp_(Immunization LAIVVaccine)
        {
            DataType szzzzj_ = LAIVVaccine?.Occurrence;
            CqlDateTime szzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzj_, "value");
            CqlDateTime szzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzk_ as object);
            CqlDate szzzzm_ = context.Operators.DateFrom(szzzzl_);

            return szzzzm_;
        };
        IEnumerable<CqlDate> rzzzzq_ = context.Operators.Select<Immunization, CqlDate>(rzzzzo_, rzzzzp_);
        IEnumerable<CqlDate> rzzzzr_ = context.Operators.Distinct<CqlDate>(rzzzzq_);
        CqlValueSet rzzzzs_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> rzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> rzzzzu_ = Status_1_8_000.Instance.isProcedurePerformed(context, rzzzzt_);
        bool? rzzzzv_(Procedure InfluenzaAdministration)
        {
            DataType szzzzn_ = InfluenzaAdministration?.Performed;
            object szzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzn_);
            CqlDateTime szzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzo_);
            CqlDate szzzzq_ = context.Operators.DateFrom(szzzzp_);
            CqlDate szzzzr_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> szzzzt_ = context.Operators.Interval(szzzzr_, szzzzr_, true, true);
            bool? szzzzu_ = context.Operators.In<CqlDate>(szzzzq_, szzzzt_, "day");

            return szzzzu_;
        };
        IEnumerable<Procedure> rzzzzw_ = context.Operators.Where<Procedure>(rzzzzu_, rzzzzv_);
        CqlDate rzzzzx_(Procedure InfluenzaAdministration)
        {
            DataType szzzzv_ = InfluenzaAdministration?.Performed;
            object szzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzv_);
            CqlDateTime szzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzw_);
            CqlDate szzzzy_ = context.Operators.DateFrom(szzzzx_);

            return szzzzy_;
        };
        IEnumerable<CqlDate> rzzzzy_ = context.Operators.Select<Procedure, CqlDate>(rzzzzw_, rzzzzx_);
        IEnumerable<CqlDate> rzzzzz_ = context.Operators.Distinct<CqlDate>(rzzzzy_);
        IEnumerable<CqlDate> szzzza_ = context.Operators.Union<CqlDate>(rzzzzr_, rzzzzz_);

        return szzzza_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context)
    {
        IEnumerable<CqlDate> szzzzz_ = this.LAIV_Vaccinations(context);
        bool? tzzzza_ = context.Operators.Exists<CqlDate>(szzzzz_);
        IEnumerable<CqlDate> tzzzzb_ = this.Influenza_Immunizations_or_Procedures(context);
        bool? tzzzzc_ = context.Operators.Exists<CqlDate>(tzzzzb_);
        bool? tzzzzd_ = context.Operators.And(tzzzza_, tzzzzc_);

        return tzzzzd_;
    }


    [CqlExpressionDefinition("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode tzzzze_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> tzzzzf_ = context.Operators.ToList<CqlCode>(tzzzze_);
        IEnumerable<Condition> tzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, tzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzh_(Condition InfluenzaConditions)
        {
            CqlInterval<CqlDateTime> tzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime tzzzzk_ = context.Operators.Start(tzzzzj_);
            CqlDate tzzzzl_ = context.Operators.DateFrom(tzzzzk_);
            CqlInterval<CqlDate> tzzzzm_ = this.First_Two_Years(context);
            bool? tzzzzn_ = context.Operators.In<CqlDate>(tzzzzl_, tzzzzm_, "day");

            return tzzzzn_;
        };
        IEnumerable<Condition> tzzzzi_ = context.Operators.Where<Condition>(tzzzzg_, tzzzzh_);

        return tzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<CqlDate> tzzzzo_ = this.Four_DTaP_Vaccinations(context);
        bool? tzzzzp_ = context.Operators.Exists<CqlDate>(tzzzzo_);
        IEnumerable<Condition> tzzzzq_ = this.DTaP_Numerator_Inclusion_Conditions(context);
        bool? tzzzzr_ = context.Operators.Exists<Condition>(tzzzzq_);
        bool? tzzzzs_ = context.Operators.Or(tzzzzp_, tzzzzr_);
        IEnumerable<CqlDate> tzzzzt_ = this.Three_Polio_Vaccinations(context);
        bool? tzzzzu_ = context.Operators.Exists<CqlDate>(tzzzzt_);
        IEnumerable<Condition> tzzzzv_ = this.Polio_Numerator_Inclusion_Conditions(context);
        bool? tzzzzw_ = context.Operators.Exists<Condition>(tzzzzv_);
        bool? tzzzzx_ = context.Operators.Or(tzzzzu_, tzzzzw_);
        bool? tzzzzy_ = context.Operators.And(tzzzzs_, tzzzzx_);
        IEnumerable<CqlDate> tzzzzz_ = this.One_MMR_Vaccination(context);
        bool? uzzzza_ = context.Operators.Exists<CqlDate>(tzzzzz_);
        IEnumerable<Condition> uzzzzb_ = this.MMR_Numerator_Inclusion_Conditions(context);
        bool? uzzzzc_ = context.Operators.Exists<Condition>(uzzzzb_);
        bool? uzzzzd_ = context.Operators.Or(uzzzza_, uzzzzc_);
        IEnumerable<Condition> uzzzze_ = this.Measles_Indicators(context);
        bool? uzzzzf_ = context.Operators.Exists<Condition>(uzzzze_);
        IEnumerable<Condition> uzzzzg_ = this.Mumps_Indicators(context);
        bool? uzzzzh_ = context.Operators.Exists<Condition>(uzzzzg_);
        bool? uzzzzi_ = context.Operators.And(uzzzzf_, uzzzzh_);
        IEnumerable<Condition> uzzzzj_ = this.Rubella_Indicators(context);
        bool? uzzzzk_ = context.Operators.Exists<Condition>(uzzzzj_);
        bool? uzzzzl_ = context.Operators.And(uzzzzi_, uzzzzk_);
        bool? uzzzzm_ = context.Operators.Or(uzzzzd_, uzzzzl_);
        bool? uzzzzn_ = context.Operators.And(tzzzzy_, uzzzzm_);
        bool? uzzzzo_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
        IEnumerable<Condition> uzzzzp_ = this.Hib_Numerator_Inclusion_Conditions(context);
        bool? uzzzzq_ = context.Operators.Exists<Condition>(uzzzzp_);
        bool? uzzzzr_ = context.Operators.Or(uzzzzo_, uzzzzq_);
        bool? uzzzzs_ = context.Operators.And(uzzzzn_, uzzzzr_);
        IEnumerable<CqlDate> uzzzzt_ = this.Three_Hepatitis_B_Vaccinations(context);
        bool? uzzzzu_ = context.Operators.Exists<CqlDate>(uzzzzt_);
        IEnumerable<CqlDate> uzzzzv_ = this.Meets_HepB_Vaccination_Requirement(context);
        bool? uzzzzw_ = context.Operators.Exists<CqlDate>(uzzzzv_);
        IEnumerable<Condition> uzzzzx_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
        bool? uzzzzy_ = context.Operators.Exists<Condition>(uzzzzx_);
        bool? uzzzzz_ = context.Operators.Or(uzzzzw_, uzzzzy_);
        bool? vzzzza_ = context.Operators.Or(uzzzzu_, uzzzzz_);
        bool? vzzzzb_ = context.Operators.And(uzzzzs_, vzzzza_);
        IEnumerable<CqlDate> vzzzzc_ = this.One_Chicken_Pox_Vaccination(context);
        bool? vzzzzd_ = context.Operators.Exists<CqlDate>(vzzzzc_);
        IEnumerable<Condition> vzzzze_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
        bool? vzzzzf_ = context.Operators.Exists<Condition>(vzzzze_);
        bool? vzzzzg_ = context.Operators.Or(vzzzzd_, vzzzzf_);
        bool? vzzzzh_ = context.Operators.And(vzzzzb_, vzzzzg_);
        IEnumerable<CqlDate> vzzzzi_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
        bool? vzzzzj_ = context.Operators.Exists<CqlDate>(vzzzzi_);
        IEnumerable<Condition> vzzzzk_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
        bool? vzzzzl_ = context.Operators.Exists<Condition>(vzzzzk_);
        bool? vzzzzm_ = context.Operators.Or(vzzzzj_, vzzzzl_);
        bool? vzzzzn_ = context.Operators.And(vzzzzh_, vzzzzm_);
        IEnumerable<CqlDate> vzzzzo_ = this.One_Hepatitis_A_Vaccinations(context);
        bool? vzzzzp_ = context.Operators.Exists<CqlDate>(vzzzzo_);
        IEnumerable<Condition> vzzzzq_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
        bool? vzzzzr_ = context.Operators.Exists<Condition>(vzzzzq_);
        bool? vzzzzs_ = context.Operators.Or(vzzzzp_, vzzzzr_);
        bool? vzzzzt_ = context.Operators.And(vzzzzn_, vzzzzs_);
        bool? vzzzzu_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
        IEnumerable<Condition> vzzzzv_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
        bool? vzzzzw_ = context.Operators.Exists<Condition>(vzzzzv_);
        bool? vzzzzx_ = context.Operators.Or(vzzzzu_, vzzzzw_);
        bool? vzzzzy_ = context.Operators.And(vzzzzt_, vzzzzx_);
        IEnumerable<CqlDate> vzzzzz_ = this.Two_Influenza_Vaccinations(context);
        bool? wzzzza_ = context.Operators.Exists<CqlDate>(vzzzzz_);
        bool? wzzzzb_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
        bool? wzzzzc_ = context.Operators.Or(wzzzza_, wzzzzb_);
        IEnumerable<Condition> wzzzzd_ = this.Influenza_Numerator_Inclusion_Conditions(context);
        bool? wzzzze_ = context.Operators.Exists<Condition>(wzzzzd_);
        bool? wzzzzf_ = context.Operators.Or(wzzzzc_, wzzzze_);
        bool? wzzzzg_ = context.Operators.And(vzzzzy_, wzzzzf_);

        return wzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzk_;
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
