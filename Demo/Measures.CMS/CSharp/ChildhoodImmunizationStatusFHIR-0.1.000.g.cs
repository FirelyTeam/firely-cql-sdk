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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("ChildhoodImmunizationStatusFHIR", "0.1.000")]
public partial class ChildhoodImmunizationStatusFHIR_0_1_000 : ILibrary, ISingleton<ChildhoodImmunizationStatusFHIR_0_1_000>
{
    private ChildhoodImmunizationStatusFHIR_0_1_000() {}

    public static ChildhoodImmunizationStatusFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    string ILibrary.Name => "ChildhoodImmunizationStatusFHIR";
    string ILibrary.Version => "0.1.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance, QICoreCommon_2_1_000.Instance];
    #endregion Library Members

    #region Definition Methods

    [CqlDeclaration("Anaphylactic Reaction to DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031")]
    public CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", default);

    [CqlDeclaration("Disorders of the Immune System")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001")]
    public CqlValueSet Disorders_of_the_Immune_System(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", default);

    [CqlDeclaration("DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214")]
    public CqlValueSet DTaP_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", default);

    [CqlDeclaration("DTaP Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022")]
    public CqlValueSet DTaP_Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", default);

    [CqlDeclaration("Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164")]
    public CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", default);

    [CqlDeclaration("Haemophilus Influenzae Type B (Hib) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043")]
    public CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043", default);

    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
    public CqlValueSet Hepatitis_A(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", default);

    [CqlDeclaration("Hepatitis A Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215")]
    public CqlValueSet Hepatitis_A_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", default);

    [CqlDeclaration("Hepatitis A Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041")]
    public CqlValueSet Hepatitis_A_Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", default);

    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025")]
    public CqlValueSet Hepatitis_B(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", default);

    [CqlDeclaration("Hepatitis B Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216")]
    public CqlValueSet Hepatitis_B_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", default);

    [CqlDeclaration("Hepatitis B Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042")]
    public CqlValueSet Hepatitis_B_Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", default);

    [CqlDeclaration("Hib Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083")]
    public CqlValueSet Hib_Vaccine__3_dose_schedule_(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", default);

    [CqlDeclaration("Hib Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084")]
    public CqlValueSet Hib_Vaccine__3_dose_schedule__Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", default);

    [CqlDeclaration("Hib Vaccine (4 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085")]
    public CqlValueSet Hib_Vaccine__4_dose_schedule_(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", default);

    [CqlDeclaration("Hib Vaccine (4 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086")]
    public CqlValueSet Hib_Vaccine__4_dose_schedule__Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
    public CqlValueSet HIV(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Inactivated Polio Vaccine (IPV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219")]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV_(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", default);

    [CqlDeclaration("Inactivated Polio Vaccine (IPV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045")]
    public CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", default);

    [CqlDeclaration("Child Influenza Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218")]
    public CqlValueSet Child_Influenza_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", default);

    [CqlDeclaration("Child Influenza Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044")]
    public CqlValueSet Child_Influenza_Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", default);

    [CqlDeclaration("Influenza Virus LAIV Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087")]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", default);

    [CqlDeclaration("Influenza Virus LAIV Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088")]
    public CqlValueSet Influenza_Virus_LAIV_Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", default);

    [CqlDeclaration("Intussusception")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056")]
    public CqlValueSet Intussusception(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", default);

    [CqlDeclaration("Malignant Neoplasm of Lymphatic and Hematopoietic Tissue")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009")]
    public CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", default);

    [CqlDeclaration("Measles")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053")]
    public CqlValueSet Measles(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", default);

    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224")]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", default);

    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031")]
    public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", default);

    [CqlDeclaration("Mumps")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032")]
    public CqlValueSet Mumps(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Pneumococcal Conjugate Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221")]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", default);

    [CqlDeclaration("Pneumococcal Conjugate Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046")]
    public CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Rotavirus Vaccine (2 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048")]
    public CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", default);

    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223")]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule_(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", default);

    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047")]
    public CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", default);

    [CqlDeclaration("Rubella")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037")]
    public CqlValueSet Rubella(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", default);

    [CqlDeclaration("Severe Combined Immunodeficiency")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007")]
    public CqlValueSet Severe_Combined_Immunodeficiency(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Varicella Zoster")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039")]
    public CqlValueSet Varicella_Zoster(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", default);

    [CqlDeclaration("Varicella Zoster Vaccine (VZV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170")]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV_(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", default);

    [CqlDeclaration("Varicella Zoster Vaccine (VZV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040")]
    public CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing only Haemophilus influenzae type b antigen (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(CqlContext context) =>
        new CqlCode("433621000124101", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Hepatitis B virus antigen (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(CqlContext context) =>
        new CqlCode("428321000124101", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis due to rotavirus vaccine (disorder)")]
    public CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder_(CqlContext context) =>
        new CqlCode("428331000124103", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional")]
    public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(CqlContext context) =>
        new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("rotavirus, live, monovalent vaccine")]
    public CqlCode rotavirus__live__monovalent_vaccine(CqlContext context) =>
        new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(CqlContext context) =>
        new CqlCode("471311000124103", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach")]
    public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(CqlContext context) =>
        new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(CqlContext context) =>
        new CqlCode("471361000124100", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(CqlContext context) =>
        new CqlCode("471331000124109", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(CqlContext context) =>
        new CqlCode("471141000124102", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(CqlContext context) =>
        new CqlCode("471321000124106", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)")]
    public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(CqlContext context) =>
        new CqlCode("471341000124104", "http://snomed.info/sct", default, default);

    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
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

        return a_;
    }

    [CqlDeclaration("CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("CVX")]
    public CqlCode[] CVX(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("ICD10")]
    public CqlCode[] ICD10(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }

    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
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
        bool? m_(Encounter E)
        {
            List<CodeableConcept> y_ = E?.Type;
            CqlConcept z_(CodeableConcept @this)
            {
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ae_;
            };
            IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
            bool? ab_(CqlConcept T)
            {
                CqlCode af_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional(context);
                CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
                bool? ah_ = context.Operators.Equivalent(T, ag_);

                return ah_;
            };
            IEnumerable<CqlConcept> ac_ = context.Operators.Where<CqlConcept>(aa_, ab_);
            bool? ad_ = context.Operators.Exists<CqlConcept>(ac_);

            return ad_;
        };
        IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
        CqlValueSet o_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(k_, q_);
        CqlValueSet s_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
        IEnumerable<Encounter> v_ = Status_1_8_000.Instance.isEncounterPerformed(context, u_);
        bool? w_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
            Period aj_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            bool? am_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ai_, al_, "day");

            return am_;
        };
        IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);

        return x_;
    }

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
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
        IEnumerable<Encounter> j_ = this.Qualifying_Encounters(context);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.And(i_, k_);

        return l_;
    }

    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }

    [CqlDeclaration("Date of Second Birthday")]
    public CqlDate Date_of_Second_Birthday(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlQuantity e_ = context.Operators.Quantity(2m, "years");
        CqlDate f_ = context.Operators.Add(d_, e_);

        return f_;
    }

    [CqlDeclaration("First Two Years")]
    public CqlInterval<CqlDate> First_Two_Years(CqlContext context)
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

    [CqlDeclaration("Has Severe Combined Immunodeficiency")]
    public bool? Has_Severe_Combined_Immunodeficiency(CqlContext context)
    {
        CqlValueSet a_ = this.Severe_Combined_Immunodeficiency(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition SevereImmuneDisorder)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereImmuneDisorder);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }

    [CqlDeclaration("Has Immunodeficiency")]
    public bool? Has_Immunodeficiency(CqlContext context)
    {
        CqlValueSet a_ = this.Disorders_of_the_Immune_System(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition ImmuneDisorder)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ImmuneDisorder);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }

    [CqlDeclaration("Has HIV")]
    public bool? Has_HIV(CqlContext context)
    {
        CqlValueSet a_ = this.HIV(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition HIV)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }

    [CqlDeclaration("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
    public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition LymphaticMalignantNeoplasm)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LymphaticMalignantNeoplasm);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }

    [CqlDeclaration("Has Intussusception")]
    public bool? Has_Intussusception(CqlContext context)
    {
        CqlValueSet a_ = this.Intussusception(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition IntussusceptionDisorder)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, IntussusceptionDisorder);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? b_ = this.Has_Severe_Combined_Immunodeficiency(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_Immunodeficiency(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_HIV(context);
        bool? g_ = context.Operators.Or(e_, f_);
        bool? h_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia(context);
        bool? i_ = context.Operators.Or(g_, h_);
        bool? j_ = this.Has_Intussusception(context);
        bool? k_ = context.Operators.Or(i_, j_);

        return k_;
    }

    [CqlDeclaration("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(CqlContext context)
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

    [CqlDeclaration("DTaP Immunizations or Procedures")]
    public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.DTaP_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization DTaPVaccination)
        {
            DataType r_ = DTaPVaccination?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization DTaPVaccination)
        {
            DataType x_ = DTaPVaccination?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.DTaP_Vaccine_Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure DTaPProcedure)
        {
            DataType ab_ = DTaPProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure DTaPProcedure)
        {
            DataType ah_ = DTaPProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Four DTaP Vaccinations")]
    public IEnumerable<CqlDate> Four_DTaP_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.DTaP_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);
        (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? f_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? l_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(e_, f_);
        bool? h_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
        {
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2 as CqlDate);
            CqlDateTime n_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1 as CqlDate);
            CqlDateTime q_ = QICoreCommon_2_1_000.Instance.earliest(context, p_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "day");
            CqlDate t_ = context.Operators.Add(r_, s_);
            bool? u_ = context.Operators.SameOrAfter(o_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3 as CqlDate);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            CqlDate x_ = context.Operators.DateFrom(w_);
            CqlDateTime y_ = context.Operators.ConvertDateToDateTime(x_);
            CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDateTime ac_ = context.Operators.Add(aa_, s_);
            bool? ad_ = context.Operators.SameOrAfter(y_, ac_, "day");
            bool? ae_ = context.Operators.And(u_, ad_);
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4 as CqlDate);
            CqlDateTime ag_ = QICoreCommon_2_1_000.Instance.earliest(context, af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            CqlDateTime ai_ = context.Operators.ConvertDateToDateTime(ah_);
            CqlDateTime ak_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            CqlDateTime am_ = context.Operators.Add(ak_, s_);
            bool? an_ = context.Operators.SameOrAfter(ai_, am_, "day");
            bool? ao_ = context.Operators.And(ae_, an_);

            return ao_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> i_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(g_, h_);
        CqlDate j_((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) =>
            tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
        IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(i_, j_);

        return k_;
    }

    [CqlDeclaration("DTaP Numerator Inclusion Conditions")]
    public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet a_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet c_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
        bool? f_(Condition DTaPConditions)
        {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DTaPConditions);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDate j_ = context.Operators.DateFrom(i_);
            CqlInterval<CqlDate> k_ = this.First_Two_Years(context);
            bool? l_ = context.Operators.In<CqlDate>(j_, k_, "day");

            return l_;
        };
        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);

        return g_;
    }

    [CqlDeclaration("Polio Immunizations or Procedures")]
    public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Inactivated_Polio_Vaccine__IPV_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization PolioVaccination)
        {
            DataType r_ = PolioVaccination?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization PolioVaccination)
        {
            DataType x_ = PolioVaccination?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.Earliest(context, z_ as object);
            CqlDate ab_ = context.Operators.DateFrom(aa_);

            return ab_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure PolioProcedure)
        {
            DataType ac_ = PolioProcedure?.Performed;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlDateTime ae_ = QICoreCommon_2_1_000.Instance.earliest(context, ad_);
            CqlDate af_ = context.Operators.DateFrom(ae_);
            CqlInterval<CqlDate> ag_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ah_ = context.Operators.In<CqlDate>(af_, ag_, "day");

            return ah_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure PolioProcedure)
        {
            DataType ai_ = PolioProcedure?.Performed;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlDateTime ak_ = QICoreCommon_2_1_000.Instance.earliest(context, aj_);
            CqlDate al_ = context.Operators.DateFrom(ak_);

            return al_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Three Polio Vaccinations")]
    public IEnumerable<CqlDate> Three_Polio_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Polio_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);
        (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? l_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(d_, e_);
        bool? g_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2 as CqlDate);
            CqlDateTime n_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime q_ = QICoreCommon_2_1_000.Instance.earliest(context, p_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "day");
            CqlDate t_ = context.Operators.Add(r_, s_);
            bool? u_ = context.Operators.SameOrAfter(o_, t_, default);
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3 as CqlDate);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            CqlDate x_ = context.Operators.DateFrom(w_);
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            CqlDate ac_ = context.Operators.Add(aa_, s_);
            bool? ad_ = context.Operators.SameOrAfter(x_, ac_, default);
            bool? ae_ = context.Operators.And(u_, ad_);

            return ae_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(f_, g_);
        CqlDate i_((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
        {
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1 as CqlDate);
            CqlDateTime ag_ = QICoreCommon_2_1_000.Instance.earliest(context, af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);

            return ah_;
        };
        IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(h_, i_);
        IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);

        return k_;
    }

    [CqlDeclaration("Polio Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition PolioConditions)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PolioConditions);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }

    [CqlDeclaration("Date of First Birthday")]
    public CqlDate Date_of_First_Birthday(CqlContext context)
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

    [CqlDeclaration("Date of First Birthday to Date of Second Birthday")]
    public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday(CqlContext context)
    {
        CqlDate a_ = this.Date_of_First_Birthday(context);
        CqlDate b_ = this.Date_of_Second_Birthday(context);
        CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);

        return c_;
    }

    [CqlDeclaration("One MMR Vaccination")]
    public IEnumerable<CqlDate> One_MMR_Vaccination(CqlContext context)
    {
        CqlValueSet a_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization MMRVaccination)
        {
            DataType r_ = MMRVaccination?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, default);

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization MMRVaccination)
        {
            DataType x_ = MMRVaccination?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure MMRProcedure)
        {
            DataType ab_ = MMRProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, default);

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure MMRProcedure)
        {
            DataType ah_ = MMRProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("MMR Numerator Inclusion Conditions")]
    public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition MMRConditions)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MMRConditions);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }

    [CqlDeclaration("Measles Indicators")]
    public IEnumerable<Condition> Measles_Indicators(CqlContext context)
    {
        CqlValueSet a_ = this.Measles(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition MeaslesDiagnosis)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MeaslesDiagnosis);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            CqlInterval<CqlDate> h_ = this.First_Two_Years(context);
            bool? i_ = context.Operators.In<CqlDate>(g_, h_, "day");

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }

    [CqlDeclaration("Mumps Indicators")]
    public IEnumerable<Condition> Mumps_Indicators(CqlContext context)
    {
        CqlValueSet a_ = this.Mumps(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition MumpsDiagnosis)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MumpsDiagnosis);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            CqlInterval<CqlDate> h_ = this.First_Two_Years(context);
            bool? i_ = context.Operators.In<CqlDate>(g_, h_, "day");

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }

    [CqlDeclaration("Rubella Indicators")]
    public IEnumerable<Condition> Rubella_Indicators(CqlContext context)
    {
        CqlValueSet a_ = this.Rubella(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition RubellaDiagnosis)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RubellaDiagnosis);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            CqlInterval<CqlDate> h_ = this.First_Two_Years(context);
            bool? i_ = context.Operators.In<CqlDate>(g_, h_, "day");

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }

    [CqlDeclaration("Hib 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Hib_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization ThreeDoseHibVaccine)
        {
            DataType r_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization ThreeDoseHibVaccine)
        {
            DataType x_ = ThreeDoseHibVaccine?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure ThreeDoseHibProcedure)
        {
            DataType ab_ = ThreeDoseHibProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure ThreeDoseHibProcedure)
        {
            DataType ah_ = ThreeDoseHibProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Hib 4 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Hib_Vaccine__4_dose_schedule_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization HibVaccine)
        {
            DataType r_ = HibVaccine?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization HibVaccine)
        {
            DataType x_ = HibVaccine?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure HibProcedure)
        {
            DataType ab_ = HibProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure HibProcedure)
        {
            DataType ah_ = HibProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Hib 3 or 4 Dose Immunizations")]
    public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> b_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);

        return c_;
    }

    [CqlDeclaration("Has Appropriate Number of Hib Immunizations")]
    public bool? Has_Appropriate_Number_of_Hib_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hib_3_or_4_Dose_Immunizations(context);
        bool? b_(CqlDate HibImmunization)
        {
            IEnumerable<CqlDate> e_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
            int? f_ = context.Operators.Count<CqlDate>(e_);
            bool? g_ = context.Operators.Greater(f_, 0);
            IEnumerable<CqlDate> h_ = this.Hib_3_or_4_Dose_Immunizations(context);
            CqlDate i_(CqlDate HibVaccinations)
            {
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
                CqlDate ae_ = context.Operators.DateFrom(ad_);

                return ae_;
            };
            IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
            IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
            IEnumerable<CqlDate> l_ = context.Operators.Distinct<CqlDate>(k_);
            int? m_ = context.Operators.Count<CqlDate>(l_);
            bool? n_ = context.Operators.GreaterOrEqual(m_, 4);
            bool? o_ = context.Operators.And(g_, n_);
            int? q_ = context.Operators.Count<CqlDate>(e_);
            bool? r_ = context.Operators.Greater(q_, 0);
            bool? s_ = context.Operators.IsFalse(r_);
            CqlDate u_(CqlDate HibVaccinations)
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(HibVaccinations as CqlDate);
                CqlDateTime ag_ = QICoreCommon_2_1_000.Instance.earliest(context, af_);
                CqlDate ah_ = context.Operators.DateFrom(ag_);

                return ah_;
            };
            IEnumerable<CqlDate> v_ = context.Operators.Select<CqlDate, CqlDate>(h_, u_);
            IEnumerable<CqlDate> w_ = context.Operators.Distinct<CqlDate>(v_);
            IEnumerable<CqlDate> x_ = context.Operators.Distinct<CqlDate>(w_);
            int? y_ = context.Operators.Count<CqlDate>(x_);
            bool? z_ = context.Operators.GreaterOrEqual(y_, 3);
            bool? aa_ = context.Operators.And(s_, z_);
            bool? ab_ = context.Operators.Or(o_, aa_);

            return ab_;
        };
        IEnumerable<CqlDate> c_ = context.Operators.Where<CqlDate>(a_, b_);
        bool? d_ = context.Operators.Exists<CqlDate>(c_);

        return d_;
    }

    [CqlDeclaration("Hib Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_only_Haemophilus_influenzae_type_b_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition HibReaction)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HibReaction);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }

    [CqlDeclaration("Hepatitis B Immunizations or Procedures")]
    public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_B_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization HepatitisBVaccination)
        {
            DataType r_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.First_Two_Years(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization HepatitisBVaccination)
        {
            DataType x_ = HepatitisBVaccination?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Hepatitis_B_Vaccine_Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure HepatitisBProcedure)
        {
            DataType ab_ = HepatitisBProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.First_Two_Years(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure HepatitisBProcedure)
        {
            DataType ah_ = HepatitisBProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Three Hepatitis B Vaccinations")]
    public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? l_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(d_, e_);
        bool? g_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime n_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime q_ = QICoreCommon_2_1_000.Instance.earliest(context, p_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "day");
            CqlDate t_ = context.Operators.Add(r_, s_);
            bool? u_ = context.Operators.SameOrAfter(o_, t_, default);
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3 as CqlDate);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, v_);
            CqlDate x_ = context.Operators.DateFrom(w_);
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            CqlDate ac_ = context.Operators.Add(aa_, s_);
            bool? ad_ = context.Operators.SameOrAfter(x_, ac_, default);
            bool? ae_ = context.Operators.And(u_, ad_);

            return ae_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(f_, g_);
        CqlDate i_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
        {
            CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime ag_ = QICoreCommon_2_1_000.Instance.earliest(context, af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);

            return ah_;
        };
        IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(h_, i_);
        IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);

        return k_;
    }

    [CqlDeclaration("NewBorn Vaccine Requirement")]
    public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement(CqlContext context)
    {
        CqlCode a_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> d_ = Status_1_8_000.Instance.isProcedurePerformed(context, c_);
        bool? e_(Procedure NewBornVaccine)
        {
            DataType j_ = NewBornVaccine?.Performed;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlDateTime l_ = QICoreCommon_2_1_000.Instance.earliest(context, k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            Patient n_ = this.Patient(context);
            Date o_ = n_?.BirthDateElement;
            string p_ = o_?.Value;
            CqlDate q_ = context.Operators.ConvertStringToDate(p_);
            CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
            CqlDate s_ = context.Operators.DateFrom(r_);
            Date u_ = n_?.BirthDateElement;
            string v_ = u_?.Value;
            CqlDate w_ = context.Operators.ConvertStringToDate(v_);
            CqlDateTime x_ = context.Operators.ConvertDateToDateTime(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            CqlQuantity z_ = context.Operators.Quantity(7m, "days");
            CqlDate aa_ = context.Operators.Add(y_, z_);
            CqlInterval<CqlDate> ab_ = context.Operators.Interval(s_, aa_, true, true);
            bool? ac_ = context.Operators.In<CqlDate>(m_, ab_, "day");

            return ac_;
        };
        IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
        CqlDate g_(Procedure NewBornVaccine)
        {
            DataType ad_ = NewBornVaccine?.Performed;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlDateTime af_ = QICoreCommon_2_1_000.Instance.earliest(context, ae_);
            CqlDate ag_ = context.Operators.DateFrom(af_);

            return ag_;
        };
        IEnumerable<CqlDate> h_ = context.Operators.Select<Procedure, CqlDate>(f_, g_);
        IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);

        return i_;
    }

    [CqlDeclaration("Meets HepB Vaccination Requirement")]
    public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> c_ = this.NewBorn_Vaccine_Requirement(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, c_);
        (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? l_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(d_, e_);
        bool? g_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime m_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2 as CqlDate);
            CqlDateTime n_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlDateTime p_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime q_ = QICoreCommon_2_1_000.Instance.earliest(context, p_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "day");
            CqlDate t_ = context.Operators.Add(r_, s_);
            bool? u_ = context.Operators.SameOrAfter(o_, t_, default);
            CqlDateTime w_ = QICoreCommon_2_1_000.Instance.earliest(context, p_);
            CqlDate x_ = context.Operators.DateFrom(w_);
            CqlDateTime y_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3 as CqlDate);
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            CqlDate ac_ = context.Operators.Add(aa_, s_);
            bool? ad_ = context.Operators.SameOrAfter(x_, ac_, default);
            bool? ae_ = context.Operators.And(u_, ad_);
            CqlDateTime ag_ = QICoreCommon_2_1_000.Instance.earliest(context, m_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, y_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            CqlDate am_ = context.Operators.Add(ak_, s_);
            bool? an_ = context.Operators.SameOrAfter(ah_, am_, default);
            bool? ao_ = context.Operators.And(ae_, an_);

            return ao_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(f_, g_);
        CqlDate i_((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
        {
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1 as CqlDate);
            CqlDateTime aq_ = QICoreCommon_2_1_000.Instance.earliest(context, ap_);
            CqlDate ar_ = context.Operators.DateFrom(aq_);

            return ar_;
        };
        IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(h_, i_);
        IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);

        return k_;
    }

    [CqlDeclaration("Hepatitis B Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_B_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet d_ = this.Hepatitis_B(context);
        IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
        bool? g_(Condition HepBConditions)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepBConditions);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");

            return m_;
        };
        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);

        return h_;
    }

    [CqlDeclaration("One Chicken Pox Vaccination")]
    public IEnumerable<CqlDate> One_Chicken_Pox_Vaccination(CqlContext context)
    {
        CqlValueSet a_ = this.Varicella_Zoster_Vaccine__VZV_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization ChickenPoxVaccination)
        {
            DataType r_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, default);

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization ChickenPoxVaccination)
        {
            DataType x_ = ChickenPoxVaccination?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure ChickenPoxProcedure)
        {
            DataType ab_ = ChickenPoxProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, default);

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure ChickenPoxProcedure)
        {
            DataType ah_ = ChickenPoxProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Varicella Zoster Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet a_ = this.Varicella_Zoster(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode c_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> f_ = context.Operators.Union<Condition>(b_, e_);
        bool? g_(Condition VaricellaZoster)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, VaricellaZoster);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");

            return m_;
        };
        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);

        return h_;
    }

    [CqlDeclaration("Pneumococcal Conjugate Immunizations or Procedures")]
    public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Pneumococcal_Conjugate_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization PneumococcalVaccination)
        {
            DataType r_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization PneumococcalVaccination)
        {
            DataType x_ = PneumococcalVaccination?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure PneumococcalProcedure)
        {
            DataType ab_ = PneumococcalProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure PneumococcalProcedure)
        {
            DataType ah_ = PneumococcalProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Four Pneumococcal Conjugate Vaccinations")]
    public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);
        (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? f_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? m_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(e_, f_);
        bool? h_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime n_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2 as CqlDate);
            CqlDateTime o_ = QICoreCommon_2_1_000.Instance.earliest(context, n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlDateTime q_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime r_ = QICoreCommon_2_1_000.Instance.earliest(context, q_);
            CqlDate s_ = context.Operators.DateFrom(r_);
            CqlQuantity t_ = context.Operators.Quantity(1m, "day");
            CqlDate u_ = context.Operators.Add(s_, t_);
            bool? v_ = context.Operators.SameOrAfter(p_, u_, default);
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3 as CqlDate);
            CqlDateTime x_ = QICoreCommon_2_1_000.Instance.earliest(context, w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, n_);
            CqlDate ab_ = context.Operators.DateFrom(aa_);
            CqlDate ad_ = context.Operators.Add(ab_, t_);
            bool? ae_ = context.Operators.SameOrAfter(y_, ad_, default);
            bool? af_ = context.Operators.And(v_, ae_);
            CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4 as CqlDate);
            CqlDateTime ah_ = QICoreCommon_2_1_000.Instance.earliest(context, ag_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            CqlDateTime ak_ = QICoreCommon_2_1_000.Instance.earliest(context, w_);
            CqlDate al_ = context.Operators.DateFrom(ak_);
            CqlDate an_ = context.Operators.Add(al_, t_);
            bool? ao_ = context.Operators.SameOrAfter(ai_, an_, default);
            bool? ap_ = context.Operators.And(af_, ao_);

            return ap_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> i_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(g_, h_);
        CqlDate j_((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
        {
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1 as CqlDate);
            CqlDateTime ar_ = QICoreCommon_2_1_000.Instance.earliest(context, aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);

            return as_;
        };
        IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(i_, j_);
        IEnumerable<CqlDate> l_ = context.Operators.Distinct<CqlDate>(k_);

        return l_;
    }

    [CqlDeclaration("Pneumococcal Conjugate Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition PneumococcalReaction)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, PneumococcalReaction);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }

    [CqlDeclaration("One Hepatitis A Vaccinations")]
    public IEnumerable<CqlDate> One_Hepatitis_A_Vaccinations(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization HepatitisAVaccination)
        {
            DataType r_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, default);

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization HepatitisAVaccination)
        {
            DataType x_ = HepatitisAVaccination?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Hepatitis_A_Vaccine_Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure HepatitisAProcedure)
        {
            DataType ab_ = HepatitisAProcedure?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, default);

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure HepatitisAProcedure)
        {
            DataType ah_ = HepatitisAProcedure?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Hepatitis A Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlValueSet a_ = this.Hepatitis_A(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode c_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> f_ = context.Operators.Union<Condition>(b_, e_);
        bool? g_(Condition HepatitisADiagnosis)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HepatitisADiagnosis);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
            bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");

            return m_;
        };
        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);

        return h_;
    }

    [CqlDeclaration("Rotavirus 2 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlCode a_ = this.rotavirus__live__monovalent_vaccine(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Immunization> c_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> d_ = Status_1_8_000.Instance.isImmunizationAdministered(context, c_);
        bool? e_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType s_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime t_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
            CqlDateTime u_ = QICoreCommon_2_1_000.Instance.earliest(context, t_ as object);
            CqlDate v_ = context.Operators.DateFrom(u_);
            CqlInterval<CqlDate> w_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? x_ = context.Operators.In<CqlDate>(v_, w_, "day");

            return x_;
        };
        IEnumerable<Immunization> f_ = context.Operators.Where<Immunization>(d_, e_);
        CqlDate g_(Immunization TwoDoseRotavirusVaccine)
        {
            DataType y_ = TwoDoseRotavirusVaccine?.Occurrence;
            CqlDateTime z_ = context.Operators.LateBoundProperty<CqlDateTime>(y_, "value");
            CqlDateTime aa_ = QICoreCommon_2_1_000.Instance.earliest(context, z_ as object);
            CqlDate ab_ = context.Operators.DateFrom(aa_);

            return ab_;
        };
        IEnumerable<CqlDate> h_ = context.Operators.Select<Immunization, CqlDate>(f_, g_);
        IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);
        CqlValueSet j_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
        IEnumerable<Procedure> k_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> l_ = Status_1_8_000.Instance.isProcedurePerformed(context, k_);
        bool? m_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType ac_ = TwoDoseRotavirusProcedure?.Performed;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlDateTime ae_ = QICoreCommon_2_1_000.Instance.earliest(context, ad_);
            CqlDate af_ = context.Operators.DateFrom(ae_);
            CqlInterval<CqlDate> ag_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ah_ = context.Operators.In<CqlDate>(af_, ag_, "day");

            return ah_;
        };
        IEnumerable<Procedure> n_ = context.Operators.Where<Procedure>(l_, m_);
        CqlDate o_(Procedure TwoDoseRotavirusProcedure)
        {
            DataType ai_ = TwoDoseRotavirusProcedure?.Performed;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlDateTime ak_ = QICoreCommon_2_1_000.Instance.earliest(context, aj_);
            CqlDate al_ = context.Operators.DateFrom(ak_);

            return al_;
        };
        IEnumerable<CqlDate> p_ = context.Operators.Select<Procedure, CqlDate>(n_, o_);
        IEnumerable<CqlDate> q_ = context.Operators.Distinct<CqlDate>(p_);
        IEnumerable<CqlDate> r_ = context.Operators.Union<CqlDate>(i_, q_);

        return r_;
    }

    [CqlDeclaration("Rotavirus 3 Dose Immunizations or Procedures")]
    public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType r_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization ThreeDoseRotavirusVaccine)
        {
            DataType x_ = ThreeDoseRotavirusVaccine?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType ab_ = ThreeDoseRotavirusAdministered?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure ThreeDoseRotavirusAdministered)
        {
            DataType ah_ = ThreeDoseRotavirusAdministered?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Rotavirus 2 or 3 Dose Immunizations")]
    public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> b_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
        IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);

        return c_;
    }

    [CqlDeclaration("Has Appropriate Number of Rotavirus Immunizations")]
    public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
        bool? b_(CqlDate RotavirusImmunization)
        {
            IEnumerable<CqlDate> e_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
            int? f_ = context.Operators.Count<CqlDate>(e_);
            bool? g_ = context.Operators.Greater(f_, 0);
            IEnumerable<CqlDate> h_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
            CqlDate i_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
                CqlDate ae_ = context.Operators.DateFrom(ad_);

                return ae_;
            };
            IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
            IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
            IEnumerable<CqlDate> l_ = context.Operators.Distinct<CqlDate>(k_);
            int? m_ = context.Operators.Count<CqlDate>(l_);
            bool? n_ = context.Operators.GreaterOrEqual(m_, 3);
            bool? o_ = context.Operators.And(g_, n_);
            int? q_ = context.Operators.Count<CqlDate>(e_);
            bool? r_ = context.Operators.Greater(q_, 0);
            bool? s_ = context.Operators.IsFalse(r_);
            CqlDate u_(CqlDate RotavirusVaccinations)
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(RotavirusVaccinations as CqlDate);
                CqlDateTime ag_ = QICoreCommon_2_1_000.Instance.earliest(context, af_);
                CqlDate ah_ = context.Operators.DateFrom(ag_);

                return ah_;
            };
            IEnumerable<CqlDate> v_ = context.Operators.Select<CqlDate, CqlDate>(h_, u_);
            IEnumerable<CqlDate> w_ = context.Operators.Distinct<CqlDate>(v_);
            IEnumerable<CqlDate> x_ = context.Operators.Distinct<CqlDate>(w_);
            int? y_ = context.Operators.Count<CqlDate>(x_);
            bool? z_ = context.Operators.GreaterOrEqual(y_, 2);
            bool? aa_ = context.Operators.And(s_, z_);
            bool? ab_ = context.Operators.Or(o_, aa_);

            return ab_;
        };
        IEnumerable<CqlDate> c_ = context.Operators.Where<CqlDate>(a_, b_);
        bool? d_ = context.Operators.Exists<CqlDate>(c_);

        return d_;
    }

    [CqlDeclaration("Rotavirus Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition RotavirusConditions)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RotavirusConditions);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }

    [CqlDeclaration("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
    public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(CqlContext context)
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

    [CqlDeclaration("Influenza Immunizations or Procedures")]
    public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Child_Influenza_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization InfluenzaVaccine)
        {
            DataType r_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlInterval<CqlDate> v_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
            bool? w_ = context.Operators.In<CqlDate>(u_, v_, "day");

            return w_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization InfluenzaVaccine)
        {
            DataType x_ = InfluenzaVaccine?.Occurrence;
            CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
            CqlDateTime z_ = QICoreCommon_2_1_000.Instance.earliest(context, y_ as object);
            CqlDate aa_ = context.Operators.DateFrom(z_);

            return aa_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Child_Influenza_Vaccine_Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure InfluenzaAdministration)
        {
            DataType ab_ = InfluenzaAdministration?.Performed;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlDateTime ad_ = QICoreCommon_2_1_000.Instance.earliest(context, ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlInterval<CqlDate> af_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
            bool? ag_ = context.Operators.In<CqlDate>(ae_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure InfluenzaAdministration)
        {
            DataType ah_ = InfluenzaAdministration?.Performed;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlDateTime aj_ = QICoreCommon_2_1_000.Instance.earliest(context, ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);

            return ak_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Two Influenza Vaccinations")]
    public IEnumerable<CqlDate> Two_Influenza_Vaccinations(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Influenza_Immunizations_or_Procedures(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);
        (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? d_(ValueTuple<CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? k_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(c_, d_);
        bool? f_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime l_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2 as CqlDate);
            CqlDateTime m_ = QICoreCommon_2_1_000.Instance.earliest(context, l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlDateTime o_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime p_ = QICoreCommon_2_1_000.Instance.earliest(context, o_);
            CqlDate q_ = context.Operators.DateFrom(p_);
            CqlQuantity r_ = context.Operators.Quantity(1m, "day");
            CqlDate s_ = context.Operators.Add(q_, r_);
            bool? t_ = context.Operators.SameOrAfter(n_, s_, default);

            return t_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> g_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(e_, f_);
        CqlDate h_((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
        {
            CqlDateTime u_ = context.Operators.ConvertDateToDateTime(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1 as CqlDate);
            CqlDateTime v_ = QICoreCommon_2_1_000.Instance.earliest(context, u_);
            CqlDate w_ = context.Operators.DateFrom(v_);

            return w_;
        };
        IEnumerable<CqlDate> i_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(g_, h_);
        IEnumerable<CqlDate> j_ = context.Operators.Distinct<CqlDate>(i_);

        return j_;
    }

    [CqlDeclaration("LAIV Vaccinations")]
    public IEnumerable<CqlDate> LAIV_Vaccinations(CqlContext context)
    {
        CqlValueSet a_ = this.Influenza_Virus_LAIV_Vaccine(context);
        IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
        IEnumerable<Immunization> c_ = Status_1_8_000.Instance.isImmunizationAdministered(context, b_);
        bool? d_(Immunization LAIVVaccine)
        {
            DataType r_ = LAIVVaccine?.Occurrence;
            CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
            CqlDateTime t_ = QICoreCommon_2_1_000.Instance.earliest(context, s_ as object);
            CqlDate u_ = context.Operators.DateFrom(t_);
            CqlDate v_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> x_ = context.Operators.Interval(v_, v_, true, true);
            bool? y_ = context.Operators.In<CqlDate>(u_, x_, "day");

            return y_;
        };
        IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
        CqlDate f_(Immunization LAIVVaccine)
        {
            DataType z_ = LAIVVaccine?.Occurrence;
            CqlDateTime aa_ = context.Operators.LateBoundProperty<CqlDateTime>(z_, "value");
            CqlDateTime ab_ = QICoreCommon_2_1_000.Instance.earliest(context, aa_ as object);
            CqlDate ac_ = context.Operators.DateFrom(ab_);

            return ac_;
        };
        IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        CqlValueSet i_ = this.Influenza_Virus_LAIV_Vaccine_Administered(context);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> k_ = Status_1_8_000.Instance.isProcedurePerformed(context, j_);
        bool? l_(Procedure InfluenzaAdministration)
        {
            DataType ad_ = InfluenzaAdministration?.Performed;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlDateTime af_ = QICoreCommon_2_1_000.Instance.earliest(context, ae_);
            CqlDate ag_ = context.Operators.DateFrom(af_);
            CqlDate ah_ = this.Date_of_Second_Birthday(context);
            CqlInterval<CqlDate> aj_ = context.Operators.Interval(ah_, ah_, true, true);
            bool? ak_ = context.Operators.In<CqlDate>(ag_, aj_, "day");

            return ak_;
        };
        IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
        CqlDate n_(Procedure InfluenzaAdministration)
        {
            DataType al_ = InfluenzaAdministration?.Performed;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlDateTime an_ = QICoreCommon_2_1_000.Instance.earliest(context, am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        IEnumerable<CqlDate> q_ = context.Operators.Union<CqlDate>(h_, p_);

        return q_;
    }

    [CqlDeclaration("Two Influenza Vaccinations Including One LAIV Vaccination")]
    public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.LAIV_Vaccinations(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        IEnumerable<CqlDate> c_ = this.Influenza_Immunizations_or_Procedures(context);
        bool? d_ = context.Operators.Exists<CqlDate>(c_);
        bool? e_ = context.Operators.And(b_, d_);

        return e_;
    }

    [CqlDeclaration("Influenza Numerator Inclusion Conditions")]
    public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions(CqlContext context)
    {
        CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition InfluenzaConditions)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, InfluenzaConditions);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
            bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

            return j_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

        return e_;
    }

    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Four_DTaP_Vaccinations(context);
        bool? b_ = context.Operators.Exists<CqlDate>(a_);
        IEnumerable<Condition> c_ = this.DTaP_Numerator_Inclusion_Conditions(context);
        bool? d_ = context.Operators.Exists<Condition>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<CqlDate> f_ = this.Three_Polio_Vaccinations(context);
        bool? g_ = context.Operators.Exists<CqlDate>(f_);
        IEnumerable<Condition> h_ = this.Polio_Numerator_Inclusion_Conditions(context);
        bool? i_ = context.Operators.Exists<Condition>(h_);
        bool? j_ = context.Operators.Or(g_, i_);
        bool? k_ = context.Operators.And(e_, j_);
        IEnumerable<CqlDate> l_ = this.One_MMR_Vaccination(context);
        bool? m_ = context.Operators.Exists<CqlDate>(l_);
        IEnumerable<Condition> n_ = this.MMR_Numerator_Inclusion_Conditions(context);
        bool? o_ = context.Operators.Exists<Condition>(n_);
        bool? p_ = context.Operators.Or(m_, o_);
        IEnumerable<Condition> q_ = this.Measles_Indicators(context);
        bool? r_ = context.Operators.Exists<Condition>(q_);
        IEnumerable<Condition> s_ = this.Mumps_Indicators(context);
        bool? t_ = context.Operators.Exists<Condition>(s_);
        bool? u_ = context.Operators.And(r_, t_);
        IEnumerable<Condition> v_ = this.Rubella_Indicators(context);
        bool? w_ = context.Operators.Exists<Condition>(v_);
        bool? x_ = context.Operators.And(u_, w_);
        bool? y_ = context.Operators.Or(p_, x_);
        bool? z_ = context.Operators.And(k_, y_);
        bool? aa_ = this.Has_Appropriate_Number_of_Hib_Immunizations(context);
        IEnumerable<Condition> ab_ = this.Hib_Numerator_Inclusion_Conditions(context);
        bool? ac_ = context.Operators.Exists<Condition>(ab_);
        bool? ad_ = context.Operators.Or(aa_, ac_);
        bool? ae_ = context.Operators.And(z_, ad_);
        IEnumerable<CqlDate> af_ = this.Three_Hepatitis_B_Vaccinations(context);
        bool? ag_ = context.Operators.Exists<CqlDate>(af_);
        IEnumerable<CqlDate> ah_ = this.Meets_HepB_Vaccination_Requirement(context);
        bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
        IEnumerable<Condition> aj_ = this.Hepatitis_B_Numerator_Inclusion_Conditions(context);
        bool? ak_ = context.Operators.Exists<Condition>(aj_);
        bool? al_ = context.Operators.Or(ai_, ak_);
        bool? am_ = context.Operators.Or(ag_, al_);
        bool? an_ = context.Operators.And(ae_, am_);
        IEnumerable<CqlDate> ao_ = this.One_Chicken_Pox_Vaccination(context);
        bool? ap_ = context.Operators.Exists<CqlDate>(ao_);
        IEnumerable<Condition> aq_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions(context);
        bool? ar_ = context.Operators.Exists<Condition>(aq_);
        bool? as_ = context.Operators.Or(ap_, ar_);
        bool? at_ = context.Operators.And(an_, as_);
        IEnumerable<CqlDate> au_ = this.Four_Pneumococcal_Conjugate_Vaccinations(context);
        bool? av_ = context.Operators.Exists<CqlDate>(au_);
        IEnumerable<Condition> aw_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions(context);
        bool? ax_ = context.Operators.Exists<Condition>(aw_);
        bool? ay_ = context.Operators.Or(av_, ax_);
        bool? az_ = context.Operators.And(at_, ay_);
        IEnumerable<CqlDate> ba_ = this.One_Hepatitis_A_Vaccinations(context);
        bool? bb_ = context.Operators.Exists<CqlDate>(ba_);
        IEnumerable<Condition> bc_ = this.Hepatitis_A_Numerator_Inclusion_Conditions(context);
        bool? bd_ = context.Operators.Exists<Condition>(bc_);
        bool? be_ = context.Operators.Or(bb_, bd_);
        bool? bf_ = context.Operators.And(az_, be_);
        bool? bg_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations(context);
        IEnumerable<Condition> bh_ = this.Rotavirus_Numerator_Inclusion_Conditions(context);
        bool? bi_ = context.Operators.Exists<Condition>(bh_);
        bool? bj_ = context.Operators.Or(bg_, bi_);
        bool? bk_ = context.Operators.And(bf_, bj_);
        IEnumerable<CqlDate> bl_ = this.Two_Influenza_Vaccinations(context);
        bool? bm_ = context.Operators.Exists<CqlDate>(bl_);
        bool? bn_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination(context);
        bool? bo_ = context.Operators.Or(bm_, bn_);
        IEnumerable<Condition> bp_ = this.Influenza_Numerator_Inclusion_Conditions(context);
        bool? bq_ = context.Operators.Exists<Condition>(bp_);
        bool? br_ = context.Operators.Or(bo_, bq_);
        bool? bs_ = context.Operators.And(bk_, br_);

        return bs_;
    }

    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }

    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }

    #endregion Definition Methods

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
