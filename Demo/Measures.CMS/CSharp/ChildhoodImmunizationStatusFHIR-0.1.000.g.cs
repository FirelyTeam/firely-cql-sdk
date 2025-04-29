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

    #region ValueSet: Anaphylactic Reaction to DTaP Vaccine
    [CqlValueSetDefinition(
        definitionName: "Anaphylactic Reaction to DTaP Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031",
        valueSetVersion: null)]
    public CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine(CqlContext context) => _Anaphylactic_Reaction_to_DTaP_Vaccine;

    private static readonly CqlValueSet _Anaphylactic_Reaction_to_DTaP_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", null);
    #endregion

    #region ValueSet: Disorders of the Immune System
    [CqlValueSetDefinition(
        definitionName: "Disorders of the Immune System",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Disorders_of_the_Immune_System(CqlContext context) => _Disorders_of_the_Immune_System;

    private static readonly CqlValueSet _Disorders_of_the_Immune_System = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", null);
    #endregion

    #region ValueSet: DTaP Vaccine
    [CqlValueSetDefinition(
        definitionName: "DTaP Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214",
        valueSetVersion: null)]
    public CqlValueSet DTaP_Vaccine(CqlContext context) => _DTaP_Vaccine;

    private static readonly CqlValueSet _DTaP_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", null);
    #endregion

    #region ValueSet: DTaP Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "DTaP Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022",
        valueSetVersion: null)]
    public CqlValueSet DTaP_Vaccine_Administered(CqlContext context) => _DTaP_Vaccine_Administered;

    private static readonly CqlValueSet _DTaP_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", null);
    #endregion

    #region ValueSet: Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine
    [CqlValueSetDefinition(
        definitionName: "Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164",
        valueSetVersion: null)]
    public CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(CqlContext context) => _Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine;

    private static readonly CqlValueSet _Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", null);
    #endregion

    #region ValueSet: Haemophilus Influenzae Type B (Hib) Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "Haemophilus Influenzae Type B (Hib) Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043",
        valueSetVersion: null)]
    public CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered(CqlContext context) => _Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered;

    private static readonly CqlValueSet _Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043", null);
    #endregion

    #region ValueSet: Hepatitis A
    [CqlValueSetDefinition(
        definitionName: "Hepatitis A",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_A(CqlContext context) => _Hepatitis_A;

    private static readonly CqlValueSet _Hepatitis_A = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);
    #endregion

    #region ValueSet: Hepatitis A Vaccine
    [CqlValueSetDefinition(
        definitionName: "Hepatitis A Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_A_Vaccine(CqlContext context) => _Hepatitis_A_Vaccine;

    private static readonly CqlValueSet _Hepatitis_A_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", null);
    #endregion

    #region ValueSet: Hepatitis A Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "Hepatitis A Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_A_Vaccine_Administered(CqlContext context) => _Hepatitis_A_Vaccine_Administered;

    private static readonly CqlValueSet _Hepatitis_A_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", null);
    #endregion

    #region ValueSet: Hepatitis B
    [CqlValueSetDefinition(
        definitionName: "Hepatitis B",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_B(CqlContext context) => _Hepatitis_B;

    private static readonly CqlValueSet _Hepatitis_B = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", null);
    #endregion

    #region ValueSet: Hepatitis B Vaccine
    [CqlValueSetDefinition(
        definitionName: "Hepatitis B Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_B_Vaccine(CqlContext context) => _Hepatitis_B_Vaccine;

    private static readonly CqlValueSet _Hepatitis_B_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", null);
    #endregion

    #region ValueSet: Hepatitis B Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "Hepatitis B Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042",
        valueSetVersion: null)]
    public CqlValueSet Hepatitis_B_Vaccine_Administered(CqlContext context) => _Hepatitis_B_Vaccine_Administered;

    private static readonly CqlValueSet _Hepatitis_B_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", null);
    #endregion

    #region ValueSet: Hib Vaccine (3 dose schedule)
    [CqlValueSetDefinition(
        definitionName: "Hib Vaccine (3 dose schedule)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083",
        valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__3_dose_schedule_(CqlContext context) => _Hib_Vaccine__3_dose_schedule_;

    private static readonly CqlValueSet _Hib_Vaccine__3_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", null);
    #endregion

    #region ValueSet: Hib Vaccine (3 dose schedule) Administered
    [CqlValueSetDefinition(
        definitionName: "Hib Vaccine (3 dose schedule) Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084",
        valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__3_dose_schedule__Administered(CqlContext context) => _Hib_Vaccine__3_dose_schedule__Administered;

    private static readonly CqlValueSet _Hib_Vaccine__3_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", null);
    #endregion

    #region ValueSet: Hib Vaccine (4 dose schedule)
    [CqlValueSetDefinition(
        definitionName: "Hib Vaccine (4 dose schedule)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085",
        valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__4_dose_schedule_(CqlContext context) => _Hib_Vaccine__4_dose_schedule_;

    private static readonly CqlValueSet _Hib_Vaccine__4_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", null);
    #endregion

    #region ValueSet: Hib Vaccine (4 dose schedule) Administered
    [CqlValueSetDefinition(
        definitionName: "Hib Vaccine (4 dose schedule) Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086",
        valueSetVersion: null)]
    public CqlValueSet Hib_Vaccine__4_dose_schedule__Administered(CqlContext context) => _Hib_Vaccine__4_dose_schedule__Administered;

    private static readonly CqlValueSet _Hib_Vaccine__4_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", null);
    #endregion

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Hospice care ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice care ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15",
        valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext context) => _Hospice_care_ambulatory;

    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);
    #endregion

    #region ValueSet: Inactivated Polio Vaccine (IPV)
    [CqlValueSetDefinition(
        definitionName: "Inactivated Polio Vaccine (IPV)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219",
        valueSetVersion: null)]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV_(CqlContext context) => _Inactivated_Polio_Vaccine__IPV_;

    private static readonly CqlValueSet _Inactivated_Polio_Vaccine__IPV_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", null);
    #endregion

    #region ValueSet: Inactivated Polio Vaccine (IPV) Administered
    [CqlValueSetDefinition(
        definitionName: "Inactivated Polio Vaccine (IPV) Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045",
        valueSetVersion: null)]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered(CqlContext context) => _Inactivated_Polio_Vaccine__IPV__Administered;

    private static readonly CqlValueSet _Inactivated_Polio_Vaccine__IPV__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", null);
    #endregion

    #region ValueSet: Child Influenza Vaccine
    [CqlValueSetDefinition(
        definitionName: "Child Influenza Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218",
        valueSetVersion: null)]
    public CqlValueSet Child_Influenza_Vaccine(CqlContext context) => _Child_Influenza_Vaccine;

    private static readonly CqlValueSet _Child_Influenza_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", null);
    #endregion

    #region ValueSet: Child Influenza Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "Child Influenza Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044",
        valueSetVersion: null)]
    public CqlValueSet Child_Influenza_Vaccine_Administered(CqlContext context) => _Child_Influenza_Vaccine_Administered;

    private static readonly CqlValueSet _Child_Influenza_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", null);
    #endregion

    #region ValueSet: Influenza Virus LAIV Vaccine
    [CqlValueSetDefinition(
        definitionName: "Influenza Virus LAIV Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087",
        valueSetVersion: null)]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine(CqlContext context) => _Influenza_Virus_LAIV_Vaccine;

    private static readonly CqlValueSet _Influenza_Virus_LAIV_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", null);
    #endregion

    #region ValueSet: Influenza Virus LAIV Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "Influenza Virus LAIV Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088",
        valueSetVersion: null)]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine_Administered(CqlContext context) => _Influenza_Virus_LAIV_Vaccine_Administered;

    private static readonly CqlValueSet _Influenza_Virus_LAIV_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", null);
    #endregion

    #region ValueSet: Intussusception
    [CqlValueSetDefinition(
        definitionName: "Intussusception",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056",
        valueSetVersion: null)]
    public CqlValueSet Intussusception(CqlContext context) => _Intussusception;

    private static readonly CqlValueSet _Intussusception = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", null);
    #endregion

    #region ValueSet: Malignant Neoplasm of Lymphatic and Hematopoietic Tissue
    [CqlValueSetDefinition(
        definitionName: "Malignant Neoplasm of Lymphatic and Hematopoietic Tissue",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009",
        valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(CqlContext context) => _Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue;

    private static readonly CqlValueSet _Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", null);
    #endregion

    #region ValueSet: Measles
    [CqlValueSetDefinition(
        definitionName: "Measles",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053",
        valueSetVersion: null)]
    public CqlValueSet Measles(CqlContext context) => _Measles;

    private static readonly CqlValueSet _Measles = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", null);
    #endregion

    #region ValueSet: Measles, Mumps and Rubella (MMR) Vaccine
    [CqlValueSetDefinition(
        definitionName: "Measles, Mumps and Rubella (MMR) Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224",
        valueSetVersion: null)]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine(CqlContext context) => _Measles__Mumps_and_Rubella__MMR__Vaccine;

    private static readonly CqlValueSet _Measles__Mumps_and_Rubella__MMR__Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", null);
    #endregion

    #region ValueSet: Measles, Mumps and Rubella (MMR) Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "Measles, Mumps and Rubella (MMR) Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031",
        valueSetVersion: null)]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(CqlContext context) => _Measles__Mumps_and_Rubella__MMR__Vaccine_Administered;

    private static readonly CqlValueSet _Measles__Mumps_and_Rubella__MMR__Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", null);
    #endregion

    #region ValueSet: Mumps
    [CqlValueSetDefinition(
        definitionName: "Mumps",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032",
        valueSetVersion: null)]
    public CqlValueSet Mumps(CqlContext context) => _Mumps;

    private static readonly CqlValueSet _Mumps = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Pneumococcal Conjugate Vaccine
    [CqlValueSetDefinition(
        definitionName: "Pneumococcal Conjugate Vaccine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221",
        valueSetVersion: null)]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine(CqlContext context) => _Pneumococcal_Conjugate_Vaccine;

    private static readonly CqlValueSet _Pneumococcal_Conjugate_Vaccine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", null);
    #endregion

    #region ValueSet: Pneumococcal Conjugate Vaccine Administered
    [CqlValueSetDefinition(
        definitionName: "Pneumococcal Conjugate Vaccine Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046",
        valueSetVersion: null)]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered(CqlContext context) => _Pneumococcal_Conjugate_Vaccine_Administered;

    private static readonly CqlValueSet _Pneumococcal_Conjugate_Vaccine_Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Rotavirus Vaccine (2 dose schedule) Administered
    [CqlValueSetDefinition(
        definitionName: "Rotavirus Vaccine (2 dose schedule) Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048",
        valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered(CqlContext context) => _Rotavirus_Vaccine__2_dose_schedule__Administered;

    private static readonly CqlValueSet _Rotavirus_Vaccine__2_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", null);
    #endregion

    #region ValueSet: Rotavirus Vaccine (3 dose schedule)
    [CqlValueSetDefinition(
        definitionName: "Rotavirus Vaccine (3 dose schedule)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223",
        valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule_(CqlContext context) => _Rotavirus_Vaccine__3_dose_schedule_;

    private static readonly CqlValueSet _Rotavirus_Vaccine__3_dose_schedule_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", null);
    #endregion

    #region ValueSet: Rotavirus Vaccine (3 dose schedule) Administered
    [CqlValueSetDefinition(
        definitionName: "Rotavirus Vaccine (3 dose schedule) Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047",
        valueSetVersion: null)]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered(CqlContext context) => _Rotavirus_Vaccine__3_dose_schedule__Administered;

    private static readonly CqlValueSet _Rotavirus_Vaccine__3_dose_schedule__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", null);
    #endregion

    #region ValueSet: Rubella
    [CqlValueSetDefinition(
        definitionName: "Rubella",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037",
        valueSetVersion: null)]
    public CqlValueSet Rubella(CqlContext context) => _Rubella;

    private static readonly CqlValueSet _Rubella = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", null);
    #endregion

    #region ValueSet: Severe Combined Immunodeficiency
    [CqlValueSetDefinition(
        definitionName: "Severe Combined Immunodeficiency",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007",
        valueSetVersion: null)]
    public CqlValueSet Severe_Combined_Immunodeficiency(CqlContext context) => _Severe_Combined_Immunodeficiency;

    private static readonly CqlValueSet _Severe_Combined_Immunodeficiency = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: Varicella Zoster
    [CqlValueSetDefinition(
        definitionName: "Varicella Zoster",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039",
        valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster(CqlContext context) => _Varicella_Zoster;

    private static readonly CqlValueSet _Varicella_Zoster = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", null);
    #endregion

    #region ValueSet: Varicella Zoster Vaccine (VZV)
    [CqlValueSetDefinition(
        definitionName: "Varicella Zoster Vaccine (VZV)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170",
        valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV_(CqlContext context) => _Varicella_Zoster_Vaccine__VZV_;

    private static readonly CqlValueSet _Varicella_Zoster_Vaccine__VZV_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", null);
    #endregion

    #region ValueSet: Varicella Zoster Vaccine (VZV) Administered
    [CqlValueSetDefinition(
        definitionName: "Varicella Zoster Vaccine (VZV) Administered",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040",
        valueSetVersion: null)]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered(CqlContext context) => _Varicella_Zoster_Vaccine__VZV__Administered;

    private static readonly CqlValueSet _Varicella_Zoster_Vaccine__VZV__Administered = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)",
        codeId: "433621000124101",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_ = new CqlCode("433621000124101", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)",
        codeId: "428321000124101",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_ = new CqlCode("428321000124101", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Anaphylaxis due to rotavirus vaccine (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis due to rotavirus vaccine (disorder)",
        codeId: "428331000124103",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder_(CqlContext context) => _Anaphylaxis_due_to_rotavirus_vaccine__disorder_;

    private static readonly CqlCode _Anaphylaxis_due_to_rotavirus_vaccine__disorder_ = new CqlCode("428331000124103", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional
    [CqlCodeDefinition(
        definitionName: "Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional",
        codeId: "99211",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext context) => _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;

    private static readonly CqlCode _Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: rotavirus, live, monovalent vaccine
    [CqlCodeDefinition(
        definitionName: "rotavirus, live, monovalent vaccine",
        codeId: "119",
        codeSystem: "http://hl7.org/fhir/sid/cvx")]
    public CqlCode rotavirus__live__monovalent_vaccine(CqlContext context) => _rotavirus__live__monovalent_vaccine;

    private static readonly CqlCode _rotavirus__live__monovalent_vaccine = new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default);
    #endregion

    #region Code: Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)",
        codeId: "471311000124103",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_ = new CqlCode("471311000124103", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach
    [CqlCodeDefinition(
        definitionName: "Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach",
        codeId: "3E0234Z",
        codeSystem: "http://www.cms.gov/Medicare/Coding/ICD10")]
    public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(CqlContext context) => _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach;

    private static readonly CqlCode _Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach = new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default);
    #endregion

    #region Code: Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)",
        codeId: "471361000124100",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_ = new CqlCode("471361000124100", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)",
        codeId: "471331000124109",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_ = new CqlCode("471331000124109", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)",
        codeId: "471141000124102",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_ = new CqlCode("471141000124102", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)",
        codeId: "471321000124106",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_ = new CqlCode("471321000124106", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)
    [CqlCodeDefinition(
        definitionName: "Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)",
        codeId: "471341000124104",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(CqlContext context) => _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_;

    private static readonly CqlCode _Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_ = new CqlCode("471341000124104", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
            new CqlCode("433621000124101", "http://snomed.info/sct", default, default),
            new CqlCode("428321000124101", "http://snomed.info/sct", default, default),
            new CqlCode("428331000124103", "http://snomed.info/sct", default, default),
            new CqlCode("471311000124103", "http://snomed.info/sct", default, default),
            new CqlCode("471361000124100", "http://snomed.info/sct", default, default),
            new CqlCode("471331000124109", "http://snomed.info/sct", default, default),
            new CqlCode("471141000124102", "http://snomed.info/sct", default, default),
            new CqlCode("471321000124106", "http://snomed.info/sct", default, default),
            new CqlCode("471341000124104", "http://snomed.info/sct", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
            new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "CVX")]
    public CqlCode[] CVX(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
            new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10")]
    public CqlCode[] ICD10(CqlContext context)
    {
        CqlCode[] qzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
            new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default),
        ];

        return qzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
        object qzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", qzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter E)
        {
            List<CodeableConcept> rzzzzzzzzzzzzzzzzzzzzzzzzn_ = E?.Type;
            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzo_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzq_(CqlConcept T)
            {
                CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(T, rzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isEncounterPerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            Period rzzzzzzzzzzzzzzzzzzzzzzzzy_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzza_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzzzzzzzzzd_ = szzzzzzzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzh_);
        int? szzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(szzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzi_, "year");
        bool? szzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzj_, 2);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounters(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzm_);

        return szzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzzzzzzzzzr_ = szzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(2m, "years");
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzt_);

        return szzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context)
    {
        Patient szzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Patient(context);
        Date szzzzzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzzzzv_?.BirthDateElement;
        string szzzzzzzzzzzzzzzzzzzzzzzzx_ = szzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(szzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);

        return tzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition SevereImmuneDisorder)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzp_(Condition ImmuneDisorder)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.First_Two_Years(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has HIV")]
    public bool? Has_HIV(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.HIV(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition HIV)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.First_Two_Years(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzza_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzj_(Condition LymphaticMalignantNeoplasm)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.First_Two_Years(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Intussusception(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition IntussusceptionDisorder)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.First_Two_Years(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Severe_Combined_Immunodeficiency(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Immunodeficiency(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_HIV(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Intussusception(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date vzzzzzzzzzzzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string vzzzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(42m, "days");
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);

        return vzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> vzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isImmunizationAdministered(context, vzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzz_(Immunization DTaPVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzn_ = DTaPVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzn_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return wzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Immunization> wzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Immunization>(vzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzb_(Immunization DTaPVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzt_ = DTaPVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzt_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Immunization, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzze_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure DTaPProcedure)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzx_ = DTaPProcedure?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure DTaPProcedure)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzd_ = DTaPProcedure?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> xzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? xzzzzzzzzzzzzzzzzzzzzzzzzm_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? xzzzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return xzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> xzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(xzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
        {
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "day");
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrAfter(xzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrAfter(yzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrAfter(yzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> xzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(xzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) =>
            tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition DTaPConditions)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.First_Two_Years(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isImmunizationAdministered(context, zzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzl_(Immunization PolioVaccination)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzz_ = PolioVaccination?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.LateBoundProperty<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzz_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Immunization>(zzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzn_(Immunization PolioVaccination)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzf_ = PolioVaccination?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzf_, "value");
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.Earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Immunization, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzt_(Procedure PolioProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzk_ = PolioProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure PolioProcedure)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzq_ = PolioProcedure?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Procedure, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> azzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? azzzzzzzzzzzzzzzzzzzzzzzzzy_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? bzzzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> azzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(azzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1m, "day");
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrAfter(bzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrAfter(bzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> bzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(azzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzza_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition PolioConditions)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.First_Two_Years(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzzzzzzzzzn_ = czzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "year");
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context)
    {
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_of_First_Birthday(context);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);

        return czzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> czzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isImmunizationAdministered(context, czzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzza_(Immunization MMRVaccination)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzo_ = MMRVaccination?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzo_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzp_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Immunization>(czzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzc_(Immunization MMRVaccination)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzu_ = MMRVaccination?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzu_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Immunization, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure MMRProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzy_ = MMRProcedure?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzc_, default);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure MMRProcedure)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzze_ = MMRProcedure?.Performed;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Procedure, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition MMRConditions)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.First_Two_Years(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measles(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition MeaslesDiagnosis)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.First_Two_Years(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Mumps(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition MumpsDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.First_Two_Years(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Rubella(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition RubellaDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.First_Two_Years(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isImmunizationAdministered(context, fzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzw_(Immunization ThreeDoseHibVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzk_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Immunization>(fzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzy_(Immunization ThreeDoseHibVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzq_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Immunization, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isProcedurePerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure ThreeDoseHibProcedure)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ThreeDoseHibProcedure?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure ThreeDoseHibProcedure)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzza_ = ThreeDoseHibProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> hzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> hzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isImmunizationAdministered(context, hzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzh_(Immunization HibVaccine)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzv_ = HibVaccine?.Occurrence;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.LateBoundProperty<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzv_, "value");
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return izzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Immunization> hzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Immunization>(hzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzj_(Immunization HibVaccine)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzb_ = HibVaccine?.Occurrence;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzb_, "value");
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return izzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Immunization, CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isProcedurePerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure HibProcedure)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzf_ = HibProcedure?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return izzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure HibProcedure)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzl_ = HibProcedure?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Hib_3_or_4_Dose_Immunizations(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlDate HibImmunization)
        {
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? izzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Greater(izzzzzzzzzzzzzzzzzzzzzzzzzx_, 0);
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Hib_3_or_4_Dose_Immunizations(context);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzza_(CqlDate HibVaccinations)
            {
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Count<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzzzzzze_, 4);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Count<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Greater(jzzzzzzzzzzzzzzzzzzzzzzzzzi_, 0);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IsFalse(jzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzm_(CqlDate HibVaccinations)
            {
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            int? jzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Count<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzzzzzzzzzzzzzzzq_, 3);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition HibReaction)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.First_Two_Years(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isImmunizationAdministered(context, kzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzn_(Immunization HepatitisBVaccination)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzb_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzb_, "value");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.First_Two_Years(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return lzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Immunization> kzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Immunization>(kzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzp_(Immunization HepatitisBVaccination)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzh_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzh_, "value");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Immunization, CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure HepatitisBProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzl_ = HepatitisBProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.First_Two_Years(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

            return lzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzx_(Procedure HepatitisBProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HepatitisBProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Procedure, CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> lzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? lzzzzzzzzzzzzzzzzzzzzzzzzzz_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? mzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> mzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "day");
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrAfter(mzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrAfter(mzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> mzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(mzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure NewBornVaccine)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzm_ = NewBornVaccine?.Performed;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Patient nzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Patient(context);
            Date nzzzzzzzzzzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Date nzzzzzzzzzzzzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzzzzzzzzzzzzq_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(7m, "days");
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return ozzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzj_(Procedure NewBornVaccine)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzg_ = NewBornVaccine?.Performed;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Procedure, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> nzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context)
    {
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> ozzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzm_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? ozzzzzzzzzzzzzzzzzzzzzzzzzo_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? ozzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> ozzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "day");
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrAfter(ozzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameOrAfter(pzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrAfter(pzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> ozzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> qzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, qzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Hepatitis_B(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition HepBConditions)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.First_Two_Years(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return qzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> qzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> qzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isImmunizationAdministered(context, qzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzs_(Immunization ChickenPoxVaccination)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzg_, "value");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Immunization> qzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Immunization>(qzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzu_(Immunization ChickenPoxVaccination)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzm_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzm_, "value");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Immunization, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isProcedurePerformed(context, qzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure ChickenPoxProcedure)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ChickenPoxProcedure?.Performed;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure ChickenPoxProcedure)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ChickenPoxProcedure?.Performed;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Procedure, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition VaricellaZoster)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.First_Two_Years(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return szzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isImmunizationAdministered(context, szzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzq_(Immunization PneumococcalVaccination)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzze_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzze_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Immunization> szzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Immunization>(szzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzs_(Immunization PneumococcalVaccination)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzk_, "value");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Immunization, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isProcedurePerformed(context, szzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure PneumococcalProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzo_ = PneumococcalProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

            return tzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure PneumococcalProcedure)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzu_ = PneumococcalProcedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Procedure, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> uzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? uzzzzzzzzzzzzzzzzzzzzzzzzzd_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? uzzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> uzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "day");
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameOrAfter(uzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameOrAfter(vzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> uzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(uzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition PneumococcalReaction)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.First_Two_Years(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return wzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> wzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> wzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isImmunizationAdministered(context, wzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzze_(Immunization HepatitisAVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzs_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzs_, "value");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Immunization> wzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Immunization>(wzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzg_(Immunization HepatitisAVaccination)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzy_, "value");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Immunization, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isProcedurePerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure HepatitisAProcedure)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzc_ = HepatitisAProcedure?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure HepatitisAProcedure)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzi_ = HepatitisAProcedure?.Performed;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Procedure, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Hepatitis_A(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzs_(Condition HepatitisADiagnosis)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.First_Two_Years(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isImmunizationAdministered(context, yzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzd_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzr_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzr_, "value");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Immunization> yzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Immunization>(yzzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzf_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzx_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.LateBoundProperty<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzx_, "value");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Immunization, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isProcedurePerformed(context, yzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzl_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzb_ = TwoDoseRotavirusProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return zzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzh_ = TwoDoseRotavirusProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Procedure, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isImmunizationAdministered(context, zzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzo_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzc_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Immunization> zzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Immunization>(zzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzq_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzi_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzi_, "value");
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Immunization, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzm_ = ThreeDoseRotavirusAdministered?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return azzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ThreeDoseRotavirusAdministered?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzza_(CqlDate RotavirusImmunization)
        {
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? bzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Count<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Greater(bzzzzzzzzzzzzzzzzzzzzzzzzzze_, 0);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CqlDate, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            int? bzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Count<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzl_, 3);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            int? bzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Count<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Greater(bzzzzzzzzzzzzzzzzzzzzzzzzzzp_, 0);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.IsFalse(bzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CqlDate, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            int? bzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Count<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzzzzzzzzzzzzzx_, 2);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> czzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition RotavirusConditions)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> czzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.First_Two_Years(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzzzzzzzzzzs_ = czzzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzzzzzzzzzzt_ = czzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(180m, "days");
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isImmunizationAdministered(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzze_(Immunization InfluenzaVaccine)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "value");
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Immunization> dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Immunization>(dzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Immunization InfluenzaVaccine)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "value");
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Immunization, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isProcedurePerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure InfluenzaAdministration)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ = InfluenzaAdministration?.Performed;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure InfluenzaAdministration)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ = InfluenzaAdministration?.Performed;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Procedure, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> ezzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CrossJoin<CqlDate, CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? ezzzzzzzzzzzzzzzzzzzzzzzzzzp_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? ezzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "day");
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameOrAfter(ezzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isImmunizationAdministered(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Immunization LAIVVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzza_ = LAIVVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzza_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Immunization> fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Immunization>(fzzzzzzzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Immunization LAIVVaccine)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = LAIVVaccine?.Occurrence;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "value");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Immunization, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure InfluenzaAdministration)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = InfluenzaAdministration?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure InfluenzaAdministration)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = InfluenzaAdministration?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context)
    {
        IEnumerable<CqlDate> gzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.LAIV_Vaccinations(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Influenza_Immunizations_or_Procedures(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition InfluenzaConditions)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.First_Two_Years(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Four_DTaP_Vaccinations(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.DTaP_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Three_Polio_Vaccinations(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Polio_Numerator_Inclusion_Conditions(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.One_MMR_Vaccination(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.MMR_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measles_Indicators(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Mumps_Indicators(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Rubella_Indicators(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Hib_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Three_Hepatitis_B_Vaccinations(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Meets_HepB_Vaccination_Requirement(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.One_Chicken_Pox_Vaccination(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.One_Hepatitis_A_Vaccinations(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Two_Influenza_Vaccinations(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Influenza_Numerator_Inclusion_Conditions(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
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
