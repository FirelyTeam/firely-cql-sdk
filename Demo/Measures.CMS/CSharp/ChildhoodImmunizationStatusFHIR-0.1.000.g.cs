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
        CqlDateTime xzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzv_ = context.Operators.Interval(xzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzu_, true, true);
        object xzzzzzzzzzzzzzzzw_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", xzzzzzzzzzzzzzzzv_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzx_);

        return xzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzz_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzc_);
        CqlValueSet yzzzzzzzzzzzzzzze_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? yzzzzzzzzzzzzzzzl_(Encounter E)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzx_ = E?.Type;
            CqlConcept yzzzzzzzzzzzzzzzy_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzy_);
            bool? zzzzzzzzzzzzzzzza_(CqlConcept T)
            {
                CqlCode zzzzzzzzzzzzzzzze_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept zzzzzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(T, zzzzzzzzzzzzzzzzf_);

                return zzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzb_ = context.Operators.Where<CqlConcept>(yzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CqlConcept>(zzzzzzzzzzzzzzzzb_);

            return zzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzl_);
        CqlValueSet yzzzzzzzzzzzzzzzn_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzp_);
        CqlValueSet yzzzzzzzzzzzzzzzr_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzzzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzzzzv_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            Period zzzzzzzzzzzzzzzzi_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzj_ as object);
            bool? zzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzk_, "day");

            return zzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzn_?.Value;
        CqlDate zzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzr_ = context.Operators.End(zzzzzzzzzzzzzzzzq_);
        CqlDate zzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzr_);
        int? zzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzs_, "year");
        bool? zzzzzzzzzzzzzzzzu_ = context.Operators.Equal(zzzzzzzzzzzzzzzzt_, 2);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounters(context);
        bool? zzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzzzx_ = context.Operators.And(zzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzw_);

        return zzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return zzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzz_ = this.Patient(context);
        Date azzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzz_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzza_?.Value;
        CqlDate azzzzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzb_);
        CqlQuantity azzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(2m, "years");
        CqlDate azzzzzzzzzzzzzzzze_ = context.Operators.Add(azzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzd_);

        return azzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context)
    {
        Patient azzzzzzzzzzzzzzzzf_ = this.Patient(context);
        Date azzzzzzzzzzzzzzzzg_ = azzzzzzzzzzzzzzzzf_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzg_?.Value;
        CqlDate azzzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzh_);
        CqlDateTime azzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(azzzzzzzzzzzzzzzzi_);
        CqlDate azzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzj_);
        CqlDate azzzzzzzzzzzzzzzzl_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> azzzzzzzzzzzzzzzzm_ = context.Operators.Interval(azzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzl_, true, true);

        return azzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzn_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzp_(Condition SevereImmuneDisorder)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime azzzzzzzzzzzzzzzzt_ = context.Operators.Start(azzzzzzzzzzzzzzzzs_);
            CqlDate azzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzv_ = this.First_Two_Years(context);
            bool? azzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzv_, "day");

            return azzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzp_);
        bool? azzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzq_);

        return azzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzx_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzz_(Condition ImmuneDisorder)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime bzzzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzzzc_);
            CqlDate bzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzf_ = this.First_Two_Years(context);
            bool? bzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzf_, "day");

            return bzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzza_);

        return bzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has HIV")]
    public bool? Has_HIV(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzh_ = this.HIV(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzj_(Condition HIV)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime bzzzzzzzzzzzzzzzzn_ = context.Operators.Start(bzzzzzzzzzzzzzzzzm_);
            CqlDate bzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzp_ = this.First_Two_Years(context);
            bool? bzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzp_, "day");

            return bzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzj_);
        bool? bzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzr_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzzt_(Condition LymphaticMalignantNeoplasm)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime bzzzzzzzzzzzzzzzzx_ = context.Operators.Start(bzzzzzzzzzzzzzzzzw_);
            CqlDate bzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzz_ = this.First_Two_Years(context);
            bool? czzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzz_, "day");

            return czzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzt_);
        bool? bzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzu_);

        return bzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzb_ = this.Intussusception(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzd_(Condition IntussusceptionDisorder)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime czzzzzzzzzzzzzzzzh_ = context.Operators.Start(czzzzzzzzzzzzzzzzg_);
            CqlDate czzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzj_ = this.First_Two_Years(context);
            bool? czzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzj_, "day");

            return czzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzd_);
        bool? czzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzze_);

        return czzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzl_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? czzzzzzzzzzzzzzzzm_ = this.Has_Severe_Combined_Immunodeficiency(context);
        bool? czzzzzzzzzzzzzzzzn_ = context.Operators.Or(czzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzm_);
        bool? czzzzzzzzzzzzzzzzo_ = this.Has_Immunodeficiency(context);
        bool? czzzzzzzzzzzzzzzzp_ = context.Operators.Or(czzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzzq_ = this.Has_HIV(context);
        bool? czzzzzzzzzzzzzzzzr_ = context.Operators.Or(czzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzq_);
        bool? czzzzzzzzzzzzzzzzs_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
        bool? czzzzzzzzzzzzzzzzt_ = context.Operators.Or(czzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzs_);
        bool? czzzzzzzzzzzzzzzzu_ = this.Has_Intussusception(context);
        bool? czzzzzzzzzzzzzzzzv_ = context.Operators.Or(czzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzw_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzx_ = czzzzzzzzzzzzzzzzw_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzx_?.Value;
        CqlDate czzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzy_);
        CqlDateTime dzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzz_);
        CqlDate dzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzza_);
        CqlQuantity dzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(42m, "days");
        CqlDate dzzzzzzzzzzzzzzzzd_ = context.Operators.Add(dzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzc_);
        CqlDate dzzzzzzzzzzzzzzzze_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzze_, true, true);

        return dzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzg_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isImmunizationAdministered(context, dzzzzzzzzzzzzzzzzh_);
        bool? dzzzzzzzzzzzzzzzzj_(Immunization DTaPVaccination)
        {
            DataType dzzzzzzzzzzzzzzzzx_ = DTaPVaccination?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzx_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzy_ as object);
            CqlDate ezzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzb_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ezzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzb_, "day");

            return ezzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Immunization>(dzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzj_);
        CqlDate dzzzzzzzzzzzzzzzzl_(Immunization DTaPVaccination)
        {
            DataType ezzzzzzzzzzzzzzzzd_ = DTaPVaccination?.Occurrence;
            CqlDateTime ezzzzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzzzzzd_, "value");
            CqlDateTime ezzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzze_ as object);
            CqlDate ezzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzf_);

            return ezzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Immunization, CqlDate>(dzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzm_);
        CqlValueSet dzzzzzzzzzzzzzzzzo_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzp_);
        bool? dzzzzzzzzzzzzzzzzr_(Procedure DTaPProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzh_ = DTaPProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzh_);
            CqlDateTime ezzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzi_);
            CqlDate ezzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzl_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ezzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzl_, "day");

            return ezzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzr_);
        CqlDate dzzzzzzzzzzzzzzzzt_(Procedure DTaPProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzn_ = DTaPProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzn_);
            CqlDateTime ezzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzo_);
            CqlDate ezzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzp_);

            return ezzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Procedure, CqlDate>(dzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzw_ = context.Operators.Union<CqlDate>(dzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzv_);

        return dzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzr_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> ezzzzzzzzzzzzzzzzv_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(ezzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? ezzzzzzzzzzzzzzzzw_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? fzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return fzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> ezzzzzzzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(ezzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzw_);
        bool? ezzzzzzzzzzzzzzzzy_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
        {
            CqlDateTime fzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime fzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzd_);
            CqlDate fzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzze_);
            CqlDateTime fzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime fzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzg_);
            CqlDate fzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzh_);
            CqlQuantity fzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1m, "day");
            CqlDate fzzzzzzzzzzzzzzzzk_ = context.Operators.Add(fzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzj_);
            bool? fzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrAfter(fzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzk_, "day");
            CqlDateTime fzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
            CqlDateTime fzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzm_);
            CqlDate fzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzn_);
            CqlDateTime fzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzo_);
            CqlDateTime fzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzd_);
            CqlDateTime fzzzzzzzzzzzzzzzzt_ = context.Operators.Add(fzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzj_);
            bool? fzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrAfter(fzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzt_, "day");
            bool? fzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzu_);
            CqlDateTime fzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
            CqlDateTime fzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzw_);
            CqlDate fzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzx_);
            CqlDateTime fzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzy_);
            CqlDateTime gzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzm_);
            CqlDateTime gzzzzzzzzzzzzzzzzd_ = context.Operators.Add(gzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzj_);
            bool? gzzzzzzzzzzzzzzzze_ = context.Operators.SameOrAfter(fzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzd_, "day");
            bool? gzzzzzzzzzzzzzzzzf_ = context.Operators.And(fzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> ezzzzzzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(ezzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzy_);
        CqlDate fzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) =>
            tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(ezzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzza_);

        return fzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzg_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet gzzzzzzzzzzzzzzzzi_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(gzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzj_);
        bool? gzzzzzzzzzzzzzzzzl_(Condition DTaPConditions)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime gzzzzzzzzzzzzzzzzo_ = context.Operators.Start(gzzzzzzzzzzzzzzzzn_);
            CqlDate gzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzq_ = this.First_Two_Years(context);
            bool? gzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzq_, "day");

            return gzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzl_);

        return gzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzs_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isImmunizationAdministered(context, gzzzzzzzzzzzzzzzzt_);
        bool? gzzzzzzzzzzzzzzzzv_(Immunization PolioVaccination)
        {
            DataType hzzzzzzzzzzzzzzzzj_ = PolioVaccination?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzj_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzk_ as object);
            CqlDate hzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzn_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? hzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzn_, "day");

            return hzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Immunization>(gzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzv_);
        CqlDate gzzzzzzzzzzzzzzzzx_(Immunization PolioVaccination)
        {
            DataType hzzzzzzzzzzzzzzzzp_ = PolioVaccination?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzq_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzp_, "value");
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzq_ as object);
            CqlDateTime hzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.Earliest(context, hzzzzzzzzzzzzzzzzr_ as object);
            CqlDate hzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzs_);

            return hzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Immunization, CqlDate>(gzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzzzzzzzy_);
        CqlValueSet hzzzzzzzzzzzzzzzza_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isProcedurePerformed(context, hzzzzzzzzzzzzzzzzb_);
        bool? hzzzzzzzzzzzzzzzzd_(Procedure PolioProcedure)
        {
            DataType hzzzzzzzzzzzzzzzzu_ = PolioProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzu_);
            CqlDateTime hzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzv_);
            CqlDate hzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzy_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? hzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzy_, "day");

            return hzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzd_);
        CqlDate hzzzzzzzzzzzzzzzzf_(Procedure PolioProcedure)
        {
            DataType izzzzzzzzzzzzzzzza_ = PolioProcedure?.Performed;
            object izzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzza_);
            CqlDateTime izzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzb_);
            CqlDate izzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzc_);

            return izzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, CqlDate>(hzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzi_ = context.Operators.Union<CqlDate>(gzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzh_);

        return hzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzze_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> izzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(izzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzze_);
        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? izzzzzzzzzzzzzzzzi_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? izzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return izzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> izzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(izzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzi_);
        bool? izzzzzzzzzzzzzzzzk_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime izzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime izzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzq_);
            CqlDate izzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzr_);
            CqlDateTime izzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime izzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzt_);
            CqlDate izzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzu_);
            CqlQuantity izzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1m, "day");
            CqlDate izzzzzzzzzzzzzzzzx_ = context.Operators.Add(izzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzzzy_ = context.Operators.SameOrAfter(izzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzx_, default);
            CqlDateTime izzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
            CqlDateTime jzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzz_);
            CqlDate jzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzza_);
            CqlDateTime jzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzq_);
            CqlDate jzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzd_);
            CqlDate jzzzzzzzzzzzzzzzzg_ = context.Operators.Add(jzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzw_);
            bool? jzzzzzzzzzzzzzzzzh_ = context.Operators.SameOrAfter(jzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzg_, default);
            bool? jzzzzzzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> izzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(izzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzk_);
        CqlDate izzzzzzzzzzzzzzzzm_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime jzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime jzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzj_);
            CqlDate jzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzk_);

            return jzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(izzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzn_);

        return izzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzm_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzp_(Condition PolioConditions)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime jzzzzzzzzzzzzzzzzs_ = context.Operators.Start(jzzzzzzzzzzzzzzzzr_);
            CqlDate jzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzu_ = this.First_Two_Years(context);
            bool? jzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(jzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzu_, "day");

            return jzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzp_);

        return jzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context)
    {
        Patient jzzzzzzzzzzzzzzzzw_ = this.Patient(context);
        Date jzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzw_?.BirthDateElement;
        string jzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzx_?.Value;
        CqlDate jzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzy_);
        CqlDateTime kzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzzzzzz_);
        CqlDate kzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzza_);
        CqlQuantity kzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "year");
        CqlDate kzzzzzzzzzzzzzzzzd_ = context.Operators.Add(kzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context)
    {
        CqlDate kzzzzzzzzzzzzzzzze_ = this.Date_of_First_Birthday(context);
        CqlDate kzzzzzzzzzzzzzzzzf_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(kzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzf_, true, true);

        return kzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzh_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isImmunizationAdministered(context, kzzzzzzzzzzzzzzzzi_);
        bool? kzzzzzzzzzzzzzzzzk_(Immunization MMRVaccination)
        {
            DataType kzzzzzzzzzzzzzzzzy_ = MMRVaccination?.Occurrence;
            CqlDateTime kzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(kzzzzzzzzzzzzzzzzy_, "value");
            CqlDateTime lzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzz_ as object);
            CqlDate lzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzc_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? lzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzc_, default);

            return lzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Immunization>(kzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzk_);
        CqlDate kzzzzzzzzzzzzzzzzm_(Immunization MMRVaccination)
        {
            DataType lzzzzzzzzzzzzzzzze_ = MMRVaccination?.Occurrence;
            CqlDateTime lzzzzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<CqlDateTime>(lzzzzzzzzzzzzzzzze_, "value");
            CqlDateTime lzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzf_ as object);
            CqlDate lzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzg_);

            return lzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Immunization, CqlDate>(kzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzn_);
        CqlValueSet kzzzzzzzzzzzzzzzzp_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzzzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzzzzzzs_(Procedure MMRProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzi_ = MMRProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzi_);
            CqlDateTime lzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzj_);
            CqlDate lzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzm_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? lzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzm_, default);

            return lzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzs_);
        CqlDate kzzzzzzzzzzzzzzzzu_(Procedure MMRProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzo_ = MMRProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzo_);
            CqlDateTime lzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzp_);
            CqlDate lzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzq_);

            return lzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, CqlDate>(kzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzx_ = context.Operators.Union<CqlDate>(kzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzzzs_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? lzzzzzzzzzzzzzzzzv_(Condition MMRConditions)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime lzzzzzzzzzzzzzzzzy_ = context.Operators.Start(lzzzzzzzzzzzzzzzzx_);
            CqlDate lzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzza_ = this.First_Two_Years(context);
            bool? mzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzza_, "day");

            return mzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzv_);

        return lzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzc_ = this.Measles(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzze_(Condition MeaslesDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime mzzzzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzzzzg_);
            CqlDate mzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzj_ = this.First_Two_Years(context);
            bool? mzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(mzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzj_, "day");

            return mzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzl_ = this.Mumps(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzn_(Condition MumpsDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime mzzzzzzzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzzzzzzzp_);
            CqlDate mzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzs_ = this.First_Two_Years(context);
            bool? mzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(mzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzs_, "day");

            return mzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzn_);

        return mzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzu_ = this.Rubella(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzw_(Condition RubellaDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime mzzzzzzzzzzzzzzzzz_ = context.Operators.Start(mzzzzzzzzzzzzzzzzy_);
            CqlDate nzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzb_ = this.First_Two_Years(context);
            bool? nzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzb_, "day");

            return nzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzw_);

        return mzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzd_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> nzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> nzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isImmunizationAdministered(context, nzzzzzzzzzzzzzzzze_);
        bool? nzzzzzzzzzzzzzzzzg_(Immunization ThreeDoseHibVaccine)
        {
            DataType nzzzzzzzzzzzzzzzzu_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime nzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(nzzzzzzzzzzzzzzzzu_, "value");
            CqlDateTime nzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzv_ as object);
            CqlDate nzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzy_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? nzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzy_, "day");

            return nzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Immunization> nzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Immunization>(nzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzg_);
        CqlDate nzzzzzzzzzzzzzzzzi_(Immunization ThreeDoseHibVaccine)
        {
            DataType ozzzzzzzzzzzzzzzza_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime ozzzzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<CqlDateTime>(ozzzzzzzzzzzzzzzza_, "value");
            CqlDateTime ozzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzb_ as object);
            CqlDate ozzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzc_);

            return ozzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Immunization, CqlDate>(nzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzj_);
        CqlValueSet nzzzzzzzzzzzzzzzzl_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzm_);
        bool? nzzzzzzzzzzzzzzzzo_(Procedure ThreeDoseHibProcedure)
        {
            DataType ozzzzzzzzzzzzzzzze_ = ThreeDoseHibProcedure?.Performed;
            object ozzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzze_);
            CqlDateTime ozzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzf_);
            CqlDate ozzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzi_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ozzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzi_, "day");

            return ozzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzo_);
        CqlDate nzzzzzzzzzzzzzzzzq_(Procedure ThreeDoseHibProcedure)
        {
            DataType ozzzzzzzzzzzzzzzzk_ = ThreeDoseHibProcedure?.Performed;
            object ozzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzk_);
            CqlDateTime ozzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzl_);
            CqlDate ozzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, CqlDate>(nzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzt_ = context.Operators.Union<CqlDate>(nzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzo_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> ozzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> ozzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isImmunizationAdministered(context, ozzzzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzzzr_(Immunization HibVaccine)
        {
            DataType pzzzzzzzzzzzzzzzzf_ = HibVaccine?.Occurrence;
            CqlDateTime pzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzzzzzzzzzzzzzzf_, "value");
            CqlDateTime pzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzg_ as object);
            CqlDate pzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzj_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? pzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzj_, "day");

            return pzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Immunization> ozzzzzzzzzzzzzzzzs_ = context.Operators.Where<Immunization>(ozzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzr_);
        CqlDate ozzzzzzzzzzzzzzzzt_(Immunization HibVaccine)
        {
            DataType pzzzzzzzzzzzzzzzzl_ = HibVaccine?.Occurrence;
            CqlDateTime pzzzzzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<CqlDateTime>(pzzzzzzzzzzzzzzzzl_, "value");
            CqlDateTime pzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzm_ as object);
            CqlDate pzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzu_ = context.Operators.Select<Immunization, CqlDate>(ozzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzzzzzzu_);
        CqlValueSet ozzzzzzzzzzzzzzzzw_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isProcedurePerformed(context, ozzzzzzzzzzzzzzzzx_);
        bool? ozzzzzzzzzzzzzzzzz_(Procedure HibProcedure)
        {
            DataType pzzzzzzzzzzzzzzzzp_ = HibProcedure?.Performed;
            object pzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzp_);
            CqlDateTime pzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzq_);
            CqlDate pzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> pzzzzzzzzzzzzzzzzt_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? pzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzt_, "day");

            return pzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzz_);
        CqlDate pzzzzzzzzzzzzzzzzb_(Procedure HibProcedure)
        {
            DataType pzzzzzzzzzzzzzzzzv_ = HibProcedure?.Performed;
            object pzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzv_);
            CqlDateTime pzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzw_);
            CqlDate pzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Procedure, CqlDate>(pzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzze_ = context.Operators.Union<CqlDate>(ozzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzz_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzza_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzb_ = context.Operators.Union<CqlDate>(pzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzc_ = this.Hib_3_or_4_Dose_Immunizations(context);
        bool? qzzzzzzzzzzzzzzzzd_(CqlDate HibImmunization)
        {
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzg_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? qzzzzzzzzzzzzzzzzh_ = context.Operators.Count<CqlDate>(qzzzzzzzzzzzzzzzzg_);
            bool? qzzzzzzzzzzzzzzzzi_ = context.Operators.Greater(qzzzzzzzzzzzzzzzzh_, 0);
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzj_ = this.Hib_3_or_4_Dose_Immunizations(context);
            CqlDate qzzzzzzzzzzzzzzzzk_(CqlDate HibVaccinations)
            {
                CqlDateTime rzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime rzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzze_);
                CqlDate rzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzf_);

                return rzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzl_ = context.Operators.Select<CqlDate, CqlDate>(qzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzk_);
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzl_);
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzm_);
            int? qzzzzzzzzzzzzzzzzo_ = context.Operators.Count<CqlDate>(qzzzzzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzzo_, 4);
            bool? qzzzzzzzzzzzzzzzzq_ = context.Operators.And(qzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzp_);
            int? qzzzzzzzzzzzzzzzzs_ = context.Operators.Count<CqlDate>(qzzzzzzzzzzzzzzzzg_);
            bool? qzzzzzzzzzzzzzzzzt_ = context.Operators.Greater(qzzzzzzzzzzzzzzzzs_, 0);
            bool? qzzzzzzzzzzzzzzzzu_ = context.Operators.IsFalse(qzzzzzzzzzzzzzzzzt_);
            CqlDate qzzzzzzzzzzzzzzzzw_(CqlDate HibVaccinations)
            {
                CqlDateTime rzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime rzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzh_);
                CqlDate rzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzi_);

                return rzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CqlDate, CqlDate>(qzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzw_);
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzx_);
            IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzy_);
            int? rzzzzzzzzzzzzzzzza_ = context.Operators.Count<CqlDate>(qzzzzzzzzzzzzzzzzz_);
            bool? rzzzzzzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzzzzzzza_, 3);
            bool? rzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzb_);
            bool? rzzzzzzzzzzzzzzzzd_ = context.Operators.Or(qzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzc_);

            return rzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzze_ = context.Operators.Where<CqlDate>(qzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzd_);
        bool? qzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlDate>(qzzzzzzzzzzzzzzzze_);

        return qzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzk_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzk_);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzzzzzzzzzn_(Condition HibReaction)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime rzzzzzzzzzzzzzzzzq_ = context.Operators.Start(rzzzzzzzzzzzzzzzzp_);
            CqlDate rzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzs_ = this.First_Two_Years(context);
            bool? rzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzs_, "day");

            return rzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzn_);

        return rzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzu_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> rzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> rzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isImmunizationAdministered(context, rzzzzzzzzzzzzzzzzv_);
        bool? rzzzzzzzzzzzzzzzzx_(Immunization HepatitisBVaccination)
        {
            DataType szzzzzzzzzzzzzzzzl_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime szzzzzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzzzzzzzzzzzzzl_, "value");
            CqlDateTime szzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzm_ as object);
            CqlDate szzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzp_ = this.First_Two_Years(context);
            bool? szzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzp_, "day");

            return szzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Immunization> rzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Immunization>(rzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzx_);
        CqlDate rzzzzzzzzzzzzzzzzz_(Immunization HepatitisBVaccination)
        {
            DataType szzzzzzzzzzzzzzzzr_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime szzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(szzzzzzzzzzzzzzzzr_, "value");
            CqlDateTime szzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzs_ as object);
            CqlDate szzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzt_);

            return szzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzza_ = context.Operators.Select<Immunization, CqlDate>(rzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzza_);
        CqlValueSet szzzzzzzzzzzzzzzzc_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzzzzzzzzzzzzzzd_);
        bool? szzzzzzzzzzzzzzzzf_(Procedure HepatitisBProcedure)
        {
            DataType szzzzzzzzzzzzzzzzv_ = HepatitisBProcedure?.Performed;
            object szzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzv_);
            CqlDateTime szzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzw_);
            CqlDate szzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzz_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzz_, "day");

            return tzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzf_);
        CqlDate szzzzzzzzzzzzzzzzh_(Procedure HepatitisBProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzb_ = HepatitisBProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzb_);
            CqlDateTime tzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzc_);
            CqlDate tzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzd_);

            return tzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, CqlDate>(szzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzk_ = context.Operators.Union<CqlDate>(szzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzf_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> tzzzzzzzzzzzzzzzzi_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(tzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tzzzzzzzzzzzzzzzzj_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return tzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> tzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(tzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzj_);
        bool? tzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime tzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime tzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzr_);
            CqlDate tzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzs_);
            CqlDateTime tzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime tzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzu_);
            CqlDate tzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzv_);
            CqlQuantity tzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "day");
            CqlDate tzzzzzzzzzzzzzzzzy_ = context.Operators.Add(tzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzx_);
            bool? tzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrAfter(tzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzy_, default);
            CqlDateTime uzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzza_);
            CqlDate uzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzb_);
            CqlDateTime uzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzr_);
            CqlDate uzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzze_);
            CqlDate uzzzzzzzzzzzzzzzzh_ = context.Operators.Add(uzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzx_);
            bool? uzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzh_, default);
            bool? uzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> tzzzzzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(tzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzl_);
        CqlDate tzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime uzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzk_);
            CqlDate uzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzl_);

            return uzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(tzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(tzzzzzzzzzzzzzzzzo_);

        return tzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzn_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzzzzzzzp_);
        bool? uzzzzzzzzzzzzzzzzr_(Procedure NewBornVaccine)
        {
            DataType uzzzzzzzzzzzzzzzzw_ = NewBornVaccine?.Performed;
            object uzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzw_);
            CqlDateTime uzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzx_);
            CqlDate uzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzy_);
            Patient vzzzzzzzzzzzzzzzza_ = this.Patient(context);
            Date vzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzza_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzc_ = vzzzzzzzzzzzzzzzzb_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzc_);
            CqlDateTime vzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzd_);
            CqlDate vzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzze_);
            Date vzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzza_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzh_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzi_);
            CqlDateTime vzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzj_);
            CqlDate vzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzk_);
            CqlQuantity vzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(7m, "days");
            CqlDate vzzzzzzzzzzzzzzzzn_ = context.Operators.Add(vzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzn_, true, true);
            bool? vzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzo_, "day");

            return vzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzr_);
        CqlDate uzzzzzzzzzzzzzzzzt_(Procedure NewBornVaccine)
        {
            DataType vzzzzzzzzzzzzzzzzq_ = NewBornVaccine?.Performed;
            object vzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzq_);
            CqlDateTime vzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzr_);
            CqlDate vzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzs_);

            return vzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Procedure, CqlDate>(uzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzzzzzu_);

        return uzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context)
    {
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzu_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzw_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> vzzzzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(vzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzw_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? vzzzzzzzzzzzzzzzzy_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? wzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return wzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> vzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(vzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzy_);
        bool? wzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime wzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime wzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzg_);
            CqlDate wzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzh_);
            CqlDateTime wzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime wzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzj_);
            CqlDate wzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzk_);
            CqlQuantity wzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "day");
            CqlDate wzzzzzzzzzzzzzzzzn_ = context.Operators.Add(wzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzm_);
            bool? wzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrAfter(wzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzn_, default);
            CqlDateTime wzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzj_);
            CqlDate wzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzq_);
            CqlDateTime wzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
            CqlDateTime wzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzs_);
            CqlDate wzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzt_);
            CqlDate wzzzzzzzzzzzzzzzzw_ = context.Operators.Add(wzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzm_);
            bool? wzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrAfter(wzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzw_, default);
            bool? wzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzx_);
            CqlDateTime xzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzg_);
            CqlDate xzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzza_);
            CqlDateTime xzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzs_);
            CqlDate xzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzd_);
            CqlDate xzzzzzzzzzzzzzzzzg_ = context.Operators.Add(xzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzm_);
            bool? xzzzzzzzzzzzzzzzzh_ = context.Operators.SameOrAfter(xzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzg_, default);
            bool? xzzzzzzzzzzzzzzzzi_ = context.Operators.And(wzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzh_);

            return xzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> wzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(vzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzza_);
        CqlDate wzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime xzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzj_);
            CqlDate xzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzk_);

            return xzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(wzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzm_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet xzzzzzzzzzzzzzzzzp_ = this.Hepatitis_B(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzq_);
        bool? xzzzzzzzzzzzzzzzzs_(Condition HepBConditions)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime xzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzu_);
            CqlDate xzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzx_ = this.First_Two_Years(context);
            bool? xzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzx_, "day");

            return xzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzz_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isImmunizationAdministered(context, yzzzzzzzzzzzzzzzza_);
        bool? yzzzzzzzzzzzzzzzzc_(Immunization ChickenPoxVaccination)
        {
            DataType yzzzzzzzzzzzzzzzzq_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime yzzzzzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<CqlDateTime>(yzzzzzzzzzzzzzzzzq_, "value");
            CqlDateTime yzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzr_ as object);
            CqlDate yzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzu_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? yzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzu_, default);

            return yzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Immunization>(yzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzc_);
        CqlDate yzzzzzzzzzzzzzzzze_(Immunization ChickenPoxVaccination)
        {
            DataType yzzzzzzzzzzzzzzzzw_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime yzzzzzzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<CqlDateTime>(yzzzzzzzzzzzzzzzzw_, "value");
            CqlDateTime yzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzx_ as object);
            CqlDate yzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzy_);

            return yzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Immunization, CqlDate>(yzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzf_);
        CqlValueSet yzzzzzzzzzzzzzzzzh_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isProcedurePerformed(context, yzzzzzzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzzzzzzk_(Procedure ChickenPoxProcedure)
        {
            DataType zzzzzzzzzzzzzzzzza_ = ChickenPoxProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzza_);
            CqlDateTime zzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzb_);
            CqlDate zzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzze_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? zzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzze_, default);

            return zzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzk_);
        CqlDate yzzzzzzzzzzzzzzzzm_(Procedure ChickenPoxProcedure)
        {
            DataType zzzzzzzzzzzzzzzzzg_ = ChickenPoxProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzg_);
            CqlDateTime zzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzh_);
            CqlDate zzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzi_);

            return zzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Procedure, CqlDate>(yzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzp_ = context.Operators.Union<CqlDate>(yzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzk_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode zzzzzzzzzzzzzzzzzm_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(zzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzo_);
        bool? zzzzzzzzzzzzzzzzzq_(Condition VaricellaZoster)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime zzzzzzzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzzzzzzs_);
            CqlDate zzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzv_ = this.First_Two_Years(context);
            bool? zzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzv_, "day");

            return zzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzx_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isImmunizationAdministered(context, zzzzzzzzzzzzzzzzzy_);
        bool? azzzzzzzzzzzzzzzzza_(Immunization PneumococcalVaccination)
        {
            DataType azzzzzzzzzzzzzzzzzo_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzo_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzp_ as object);
            CqlDate azzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzs_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzs_, "day");

            return azzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Immunization> azzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Immunization>(zzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzza_);
        CqlDate azzzzzzzzzzzzzzzzzc_(Immunization PneumococcalVaccination)
        {
            DataType azzzzzzzzzzzzzzzzzu_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzu_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzv_ as object);
            CqlDate azzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzw_);

            return azzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Immunization, CqlDate>(azzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzd_);
        CqlValueSet azzzzzzzzzzzzzzzzzf_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, azzzzzzzzzzzzzzzzzg_);
        bool? azzzzzzzzzzzzzzzzzi_(Procedure PneumococcalProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzy_ = PneumococcalProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzy_);
            CqlDateTime bzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzz_);
            CqlDate bzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzzzzzc_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? bzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(bzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzc_, "day");

            return bzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzi_);
        CqlDate azzzzzzzzzzzzzzzzzk_(Procedure PneumococcalProcedure)
        {
            DataType bzzzzzzzzzzzzzzzzze_ = PneumococcalProcedure?.Performed;
            object bzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzze_);
            CqlDateTime bzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzf_);
            CqlDate bzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzg_);

            return bzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Procedure, CqlDate>(azzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzn_ = context.Operators.Union<CqlDate>(azzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzm_);

        return azzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzi_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> bzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(bzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? bzzzzzzzzzzzzzzzzzn_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? bzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return bzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> bzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(bzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzn_);
        bool? bzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime bzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzv_);
            CqlDate bzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzw_);
            CqlDateTime bzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzy_);
            CqlDate czzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzz_);
            CqlQuantity czzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1m, "day");
            CqlDate czzzzzzzzzzzzzzzzzc_ = context.Operators.Add(czzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzzzd_ = context.Operators.SameOrAfter(bzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzc_, default);
            CqlDateTime czzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
            CqlDateTime czzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzze_);
            CqlDate czzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzf_);
            CqlDateTime czzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzv_);
            CqlDate czzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzi_);
            CqlDate czzzzzzzzzzzzzzzzzl_ = context.Operators.Add(czzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzzzm_ = context.Operators.SameOrAfter(czzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzl_, default);
            bool? czzzzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzm_);
            CqlDateTime czzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
            CqlDateTime czzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzo_);
            CqlDate czzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzp_);
            CqlDateTime czzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzze_);
            CqlDate czzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzs_);
            CqlDate czzzzzzzzzzzzzzzzzv_ = context.Operators.Add(czzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzzzw_ = context.Operators.SameOrAfter(czzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzv_, default);
            bool? czzzzzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzw_);

            return czzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> bzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(bzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzp_);
        CqlDate bzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime czzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime czzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzy_);
            CqlDate dzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(bzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzs_);

        return bzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzb_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzze_(Condition PneumococcalReaction)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime dzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzg_);
            CqlDate dzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzj_ = this.First_Two_Years(context);
            bool? dzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzj_, "day");

            return dzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzze_);

        return dzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzl_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isImmunizationAdministered(context, dzzzzzzzzzzzzzzzzzm_);
        bool? dzzzzzzzzzzzzzzzzzo_(Immunization HepatitisAVaccination)
        {
            DataType ezzzzzzzzzzzzzzzzzc_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime ezzzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzzzzzzc_, "value");
            CqlDateTime ezzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzd_ as object);
            CqlDate ezzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzg_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ezzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzg_, default);

            return ezzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Immunization>(dzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzo_);
        CqlDate dzzzzzzzzzzzzzzzzzq_(Immunization HepatitisAVaccination)
        {
            DataType ezzzzzzzzzzzzzzzzzi_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime ezzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(ezzzzzzzzzzzzzzzzzi_, "value");
            CqlDateTime ezzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzj_ as object);
            CqlDate ezzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzk_);

            return ezzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Immunization, CqlDate>(dzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzr_);
        CqlValueSet dzzzzzzzzzzzzzzzzzt_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzzu_);
        bool? dzzzzzzzzzzzzzzzzzw_(Procedure HepatitisAProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzzm_ = HepatitisAProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzm_);
            CqlDateTime ezzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzn_);
            CqlDate ezzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzq_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ezzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzq_, default);

            return ezzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzw_);
        CqlDate dzzzzzzzzzzzzzzzzzy_(Procedure HepatitisAProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzzs_ = HepatitisAProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzs_);
            CqlDateTime ezzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzt_);
            CqlDate ezzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzu_);

            return ezzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, CqlDate>(dzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzb_ = context.Operators.Union<CqlDate>(dzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzw_ = this.Hepatitis_A(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode ezzzzzzzzzzzzzzzzzy_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzza_);
        bool? fzzzzzzzzzzzzzzzzzc_(Condition HepatitisADiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(fzzzzzzzzzzzzzzzzze_);
            CqlDate fzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzh_ = this.First_Two_Years(context);
            bool? fzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzh_, "day");

            return fzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlCode fzzzzzzzzzzzzzzzzzj_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isImmunizationAdministered(context, fzzzzzzzzzzzzzzzzzl_);
        bool? fzzzzzzzzzzzzzzzzzn_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzb_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzb_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzc_ as object);
            CqlDate gzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzf_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? gzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzf_, "day");

            return gzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Immunization>(fzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzn_);
        CqlDate fzzzzzzzzzzzzzzzzzp_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzh_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzh_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzi_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Immunization, CqlDate>(fzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzq_);
        CqlValueSet fzzzzzzzzzzzzzzzzzs_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzt_);
        bool? fzzzzzzzzzzzzzzzzzv_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType gzzzzzzzzzzzzzzzzzl_ = TwoDoseRotavirusProcedure?.Performed;
            object gzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzl_);
            CqlDateTime gzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzm_);
            CqlDate gzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzp_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? gzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzp_, "day");

            return gzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzv_);
        CqlDate fzzzzzzzzzzzzzzzzzx_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType gzzzzzzzzzzzzzzzzzr_ = TwoDoseRotavirusProcedure?.Performed;
            object gzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzr_);
            CqlDateTime gzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzs_);
            CqlDate gzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzt_);

            return gzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, CqlDate>(fzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzza_ = context.Operators.Union<CqlDate>(fzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzz_);

        return gzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzv_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isImmunizationAdministered(context, gzzzzzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzzzzzy_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType hzzzzzzzzzzzzzzzzzm_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzm_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzn_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzq_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? hzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzq_, "day");

            return hzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Immunization> gzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Immunization>(gzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzy_);
        CqlDate hzzzzzzzzzzzzzzzzza_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType hzzzzzzzzzzzzzzzzzs_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzs_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzt_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzu_);

            return hzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Immunization, CqlDate>(gzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzb_);
        CqlValueSet hzzzzzzzzzzzzzzzzzd_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isProcedurePerformed(context, hzzzzzzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzzzzzzg_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType hzzzzzzzzzzzzzzzzzw_ = ThreeDoseRotavirusAdministered?.Performed;
            object hzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzw_);
            CqlDateTime hzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzx_);
            CqlDate hzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzza_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? izzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzza_, "day");

            return izzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzg_);
        CqlDate hzzzzzzzzzzzzzzzzzi_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType izzzzzzzzzzzzzzzzzc_ = ThreeDoseRotavirusAdministered?.Performed;
            object izzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzc_);
            CqlDateTime izzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzd_);
            CqlDate izzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzze_);

            return izzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, CqlDate>(hzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<CqlDate>(hzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzg_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzh_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzi_ = context.Operators.Union<CqlDate>(izzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzj_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
        bool? izzzzzzzzzzzzzzzzzk_(CqlDate RotavirusImmunization)
        {
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzn_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? izzzzzzzzzzzzzzzzzo_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzn_);
            bool? izzzzzzzzzzzzzzzzzp_ = context.Operators.Greater(izzzzzzzzzzzzzzzzzo_, 0);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzq_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
            CqlDate izzzzzzzzzzzzzzzzzr_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime jzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime jzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzl_);
                CqlDate jzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzm_);

                return jzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzr_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzs_);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzt_);
            int? izzzzzzzzzzzzzzzzzv_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzu_);
            bool? izzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzv_, 3);
            bool? izzzzzzzzzzzzzzzzzx_ = context.Operators.And(izzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzw_);
            int? izzzzzzzzzzzzzzzzzz_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzzzzza_ = context.Operators.Greater(izzzzzzzzzzzzzzzzzz_, 0);
            bool? jzzzzzzzzzzzzzzzzzb_ = context.Operators.IsFalse(jzzzzzzzzzzzzzzzzza_);
            CqlDate jzzzzzzzzzzzzzzzzzd_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime jzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime jzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzo_);
                CqlDate jzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzp_);

                return jzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzze_ = context.Operators.Select<CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzd_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzze_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzf_);
            int? jzzzzzzzzzzzzzzzzzh_ = context.Operators.Count<CqlDate>(jzzzzzzzzzzzzzzzzzg_);
            bool? jzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzh_, 2);
            bool? jzzzzzzzzzzzzzzzzzj_ = context.Operators.And(jzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzi_);
            bool? jzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(izzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzj_);

            return jzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzl_ = context.Operators.Where<CqlDate>(izzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzk_);
        bool? izzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzl_);

        return izzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzr_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzzzzzzzu_(Condition RotavirusConditions)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime jzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzw_);
            CqlDate jzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzzz_ = this.First_Two_Years(context);
            bool? kzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(jzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzz_, "day");

            return kzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzu_);

        return jzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient kzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date kzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string kzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate kzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzd_);
        CqlDateTime kzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzze_);
        CqlDate kzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzf_);
        CqlQuantity kzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(180m, "days");
        CqlDate kzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzh_);
        CqlDate kzzzzzzzzzzzzzzzzzj_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzj_, true, true);

        return kzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzl_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isImmunizationAdministered(context, kzzzzzzzzzzzzzzzzzm_);
        bool? kzzzzzzzzzzzzzzzzzo_(Immunization InfluenzaVaccine)
        {
            DataType lzzzzzzzzzzzzzzzzzc_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime lzzzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(lzzzzzzzzzzzzzzzzzc_, "value");
            CqlDateTime lzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzd_ as object);
            CqlDate lzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzg_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? lzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzg_, "day");

            return lzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Immunization>(kzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzo_);
        CqlDate kzzzzzzzzzzzzzzzzzq_(Immunization InfluenzaVaccine)
        {
            DataType lzzzzzzzzzzzzzzzzzi_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime lzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(lzzzzzzzzzzzzzzzzzi_, "value");
            CqlDateTime lzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzj_ as object);
            CqlDate lzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzk_);

            return lzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Immunization, CqlDate>(kzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzzr_);
        CqlValueSet kzzzzzzzzzzzzzzzzzt_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzzzzzzzzzzzzzzu_);
        bool? kzzzzzzzzzzzzzzzzzw_(Procedure InfluenzaAdministration)
        {
            DataType lzzzzzzzzzzzzzzzzzm_ = InfluenzaAdministration?.Performed;
            object lzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzm_);
            CqlDateTime lzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzn_);
            CqlDate lzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzq_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? lzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzq_, "day");

            return lzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzw_);
        CqlDate kzzzzzzzzzzzzzzzzzy_(Procedure InfluenzaAdministration)
        {
            DataType lzzzzzzzzzzzzzzzzzs_ = InfluenzaAdministration?.Performed;
            object lzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzs_);
            CqlDateTime lzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzt_);
            CqlDate lzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzu_);

            return lzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, CqlDate>(kzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<CqlDate>(kzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzza_);

        return lzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzw_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> lzzzzzzzzzzzzzzzzzy_ = context.Operators.CrossJoin<CqlDate, CqlDate>(lzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzw_);
        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? lzzzzzzzzzzzzzzzzzz_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? mzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

            return mzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> mzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(lzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzz_);
        bool? mzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzh_);
            CqlDate mzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzi_);
            CqlDateTime mzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzk_);
            CqlDate mzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzl_);
            CqlQuantity mzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "day");
            CqlDate mzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrAfter(mzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzo_, default);

            return mzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> mzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(mzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzb_);
        CqlDate mzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzq_);
            CqlDate mzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzr_);

            return mzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(mzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDate>(mzzzzzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzt_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> mzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> mzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isImmunizationAdministered(context, mzzzzzzzzzzzzzzzzzu_);
        bool? mzzzzzzzzzzzzzzzzzw_(Immunization LAIVVaccine)
        {
            DataType nzzzzzzzzzzzzzzzzzk_ = LAIVVaccine?.Occurrence;
            CqlDateTime nzzzzzzzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<CqlDateTime>(nzzzzzzzzzzzzzzzzzk_, "value");
            CqlDateTime nzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzl_ as object);
            CqlDate nzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzm_);
            CqlDate nzzzzzzzzzzzzzzzzzo_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzo_, true, true);
            bool? nzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzq_, "day");

            return nzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Immunization> mzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Immunization>(mzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzw_);
        CqlDate mzzzzzzzzzzzzzzzzzy_(Immunization LAIVVaccine)
        {
            DataType nzzzzzzzzzzzzzzzzzs_ = LAIVVaccine?.Occurrence;
            CqlDateTime nzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(nzzzzzzzzzzzzzzzzzs_, "value");
            CqlDateTime nzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzt_ as object);
            CqlDate nzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzu_);

            return nzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Immunization, CqlDate>(mzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(mzzzzzzzzzzzzzzzzzz_);
        CqlValueSet nzzzzzzzzzzzzzzzzzb_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzze_(Procedure InfluenzaAdministration)
        {
            DataType nzzzzzzzzzzzzzzzzzw_ = InfluenzaAdministration?.Performed;
            object nzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzw_);
            CqlDateTime nzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzx_);
            CqlDate nzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzy_);
            CqlDate ozzzzzzzzzzzzzzzzza_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzza_, true, true);
            bool? ozzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzc_, "day");

            return ozzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzze_);
        CqlDate nzzzzzzzzzzzzzzzzzg_(Procedure InfluenzaAdministration)
        {
            DataType ozzzzzzzzzzzzzzzzze_ = InfluenzaAdministration?.Performed;
            object ozzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzze_);
            CqlDateTime ozzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzf_);
            CqlDate ozzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzg_);

            return ozzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, CqlDate>(nzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<CqlDate>(nzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context)
    {
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzi_ = this.LAIV_Vaccinations(context);
        bool? ozzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlDate>(ozzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzk_ = this.Influenza_Immunizations_or_Procedures(context);
        bool? ozzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<CqlDate>(ozzzzzzzzzzzzzzzzzk_);
        bool? ozzzzzzzzzzzzzzzzzm_ = context.Operators.And(ozzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzl_);

        return ozzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzn_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzzzzzzzzzzzzzq_(Condition InfluenzaConditions)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime ozzzzzzzzzzzzzzzzzt_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzs_);
            CqlDate ozzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzv_ = this.First_Two_Years(context);
            bool? ozzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzv_, "day");

            return ozzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzq_);

        return ozzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzx_ = this.Four_DTaP_Vaccinations(context);
        bool? ozzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<CqlDate>(ozzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzz_ = this.DTaP_Numerator_Inclusion_Conditions(context);
        bool? pzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzc_ = this.Three_Polio_Vaccinations(context);
        bool? pzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlDate>(pzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzze_ = this.Polio_Numerator_Inclusion_Conditions(context);
        bool? pzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzi_ = this.One_MMR_Vaccination(context);
        bool? pzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlDate>(pzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzk_ = this.MMR_Numerator_Inclusion_Conditions(context);
        bool? pzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzn_ = this.Measles_Indicators(context);
        bool? pzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzp_ = this.Mumps_Indicators(context);
        bool? pzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzzzzzr_ = context.Operators.And(pzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzs_ = this.Rubella_Indicators(context);
        bool? pzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzs_);
        bool? pzzzzzzzzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzt_);
        bool? pzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzu_);
        bool? pzzzzzzzzzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzv_);
        bool? pzzzzzzzzzzzzzzzzzx_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzy_ = this.Hib_Numerator_Inclusion_Conditions(context);
        bool? pzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzzzzzza_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzz_);
        bool? qzzzzzzzzzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzc_ = this.Three_Hepatitis_B_Vaccinations(context);
        bool? qzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlDate>(qzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzze_ = this.Meets_HepB_Vaccination_Requirement(context);
        bool? qzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlDate>(qzzzzzzzzzzzzzzzzze_);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzg_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
        bool? qzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzg_);
        bool? qzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzl_ = this.One_Chicken_Pox_Vaccination(context);
        bool? qzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CqlDate>(qzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzn_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
        bool? qzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzn_);
        bool? qzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzo_);
        bool? qzzzzzzzzzzzzzzzzzq_ = context.Operators.And(qzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzr_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
        bool? qzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<CqlDate>(qzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzt_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
        bool? qzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzt_);
        bool? qzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzu_);
        bool? qzzzzzzzzzzzzzzzzzw_ = context.Operators.And(qzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzx_ = this.One_Hepatitis_A_Vaccinations(context);
        bool? qzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<CqlDate>(qzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzz_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
        bool? rzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(qzzzzzzzzzzzzzzzzzz_);
        bool? rzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzb_);
        bool? rzzzzzzzzzzzzzzzzzd_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzze_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
        bool? rzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzf_);
        bool? rzzzzzzzzzzzzzzzzzh_ = context.Operators.And(rzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzi_ = this.Two_Influenza_Vaccinations(context);
        bool? rzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlDate>(rzzzzzzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzzzzzzk_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
        bool? rzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzm_ = this.Influenza_Numerator_Inclusion_Conditions(context);
        bool? rzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzzm_);
        bool? rzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzn_);
        bool? rzzzzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzt_;
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
