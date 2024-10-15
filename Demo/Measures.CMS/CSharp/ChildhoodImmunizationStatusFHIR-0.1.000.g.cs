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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("ChildhoodImmunizationStatusFHIR", "0.1.000")]
public partial class ChildhoodImmunizationStatusFHIR_0_1_000 : ILibrary, ISingleton<ChildhoodImmunizationStatusFHIR_0_1_000>
{
    private ChildhoodImmunizationStatusFHIR_0_1_000() {}

    public static ChildhoodImmunizationStatusFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "ChildhoodImmunizationStatusFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, CQMCommon_2_0_000.Instance, Hospice_6_9_000.Instance, Status_1_6_000.Instance, QICoreCommon_2_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Anaphylactic Reaction to DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031")]
	public CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", default);


    [CqlDeclaration("Disorders of the Immune System")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001")]
	public CqlValueSet Disorders_of_the_Immune_System	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", default);


    [CqlDeclaration("DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214")]
	public CqlValueSet DTaP_Vaccine	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", default);


    [CqlDeclaration("DTaP Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022")]
	public CqlValueSet DTaP_Vaccine_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", default);


    [CqlDeclaration("Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164")]
	public CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Haemophilus Influenzae Type B (Hib) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043")]
	public CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043", default);


    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
	public CqlValueSet Hepatitis_A	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", default);


    [CqlDeclaration("Hepatitis A Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215")]
	public CqlValueSet Hepatitis_A_Vaccine	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", default);


    [CqlDeclaration("Hepatitis A Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041")]
	public CqlValueSet Hepatitis_A_Vaccine_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", default);


    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025")]
	public CqlValueSet Hepatitis_B	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", default);


    [CqlDeclaration("Hepatitis B Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216")]
	public CqlValueSet Hepatitis_B_Vaccine	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", default);


    [CqlDeclaration("Hepatitis B Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042")]
	public CqlValueSet Hepatitis_B_Vaccine_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", default);


    [CqlDeclaration("Hib Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083")]
	public CqlValueSet Hib_Vaccine__3_dose_schedule_	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", default);


    [CqlDeclaration("Hib Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084")]
	public CqlValueSet Hib_Vaccine__3_dose_schedule__Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", default);


    [CqlDeclaration("Hib Vaccine (4 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085")]
	public CqlValueSet Hib_Vaccine__4_dose_schedule_	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", default);


    [CqlDeclaration("Hib Vaccine (4 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086")]
	public CqlValueSet Hib_Vaccine__4_dose_schedule__Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", default);


    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);


    [CqlDeclaration("Inactivated Polio Vaccine (IPV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219")]
	public CqlValueSet Inactivated_Polio_Vaccine__IPV_	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", default);


    [CqlDeclaration("Inactivated Polio Vaccine (IPV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045")]
	public CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", default);


    [CqlDeclaration("Child Influenza Immunization Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218")]
	public CqlValueSet Child_Influenza_Immunization_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", default);


    [CqlDeclaration("Child Influenza Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044")]
	public CqlValueSet Child_Influenza_Vaccine_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", default);


    [CqlDeclaration("Influenza Virus LAIV Immunization")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087")]
	public CqlValueSet Influenza_Virus_LAIV_Immunization	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", default);


    [CqlDeclaration("Influenza Virus LAIV Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088")]
	public CqlValueSet Influenza_Virus_LAIV_Procedure	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", default);


    [CqlDeclaration("Intussusception")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056")]
	public CqlValueSet Intussusception	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", default);


    [CqlDeclaration("Malignant Neoplasm of Lymphatic and Hematopoietic Tissue")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009")]
	public CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", default);


    [CqlDeclaration("Measles")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053")]
	public CqlValueSet Measles	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", default);


    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224")]
	public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", default);


    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031")]
	public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", default);


    [CqlDeclaration("Mumps")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032")]
	public CqlValueSet Mumps	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Pneumococcal Conjugate Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221")]
	public CqlValueSet Pneumococcal_Conjugate_Vaccine	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", default);


    [CqlDeclaration("Pneumococcal Conjugate Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046")]
	public CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", default);


    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);


    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);


    [CqlDeclaration("Rotavirus Vaccine (2 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048")]
	public CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", default);


    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223")]
	public CqlValueSet Rotavirus_Vaccine__3_dose_schedule_	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", default);


    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047")]
	public CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", default);


    [CqlDeclaration("Rubella")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037")]
	public CqlValueSet Rubella	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", default);


    [CqlDeclaration("Severe Combined Immunodeficiency")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007")]
	public CqlValueSet Severe_Combined_Immunodeficiency	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Varicella Zoster")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039")]
	public CqlValueSet Varicella_Zoster	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", default);


    [CqlDeclaration("Varicella Zoster Vaccine (VZV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170")]
	public CqlValueSet Varicella_Zoster_Vaccine__VZV_	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", default);


    [CqlDeclaration("Varicella Zoster Vaccine (VZV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040")]
	public CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered	(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", default);


    [CqlDeclaration("Anaphylaxis due to Haemophilus influenzae type b vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_	(CqlContext context) => 
		new CqlCode("433621000124101", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Anaphylaxis due to Hepatitis B vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_	(CqlContext context) => 
		new CqlCode("428321000124101", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Anaphylaxis due to rotavirus vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder_	(CqlContext context) => 
		new CqlCode("428331000124103", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional")]
	public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional	(CqlContext context) => 
		new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("rotavirus, live, monovalent vaccine")]
	public CqlCode rotavirus__live__monovalent_vaccine	(CqlContext context) => 
		new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default);


    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_	(CqlContext context) => 
		new CqlCode("471311000124103", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach")]
	public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach	(CqlContext context) => 
		new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default);


    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_	(CqlContext context) => 
		new CqlCode("471361000124100", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_	(CqlContext context) => 
		new CqlCode("471331000124109", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_	(CqlContext context) => 
		new CqlCode("471141000124102", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_	(CqlContext context) => 
		new CqlCode("471321000124106", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_	(CqlContext context) => 
		new CqlCode("471341000124104", "http://snomed.info/sct", default, default);


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT	(CqlContext context)
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
	public CqlCode[] CPT	(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}


    [CqlDeclaration("CVX")]
	public CqlCode[] CVX	(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default),
		];

		return a_;
	}


    [CqlDeclaration("ICD10")]
	public CqlCode[] ICD10	(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period	(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient	(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters	(CqlContext context)
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
		bool? m_		(Encounter E)
		{
			List<CodeableConcept> y_ = E?.Type;
			CqlConcept z_			(CodeableConcept @this)
			{
				CqlConcept ae_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ae_;
			};
			IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
			bool? ab_			(CqlConcept T)
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
		CqlValueSet o_ = this.Online_Assessments(context);
		IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(k_, q_);
		CqlValueSet s_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
		IEnumerable<Encounter> v_ = Status_1_6_000.Instance.Finished_Encounter(context, u_);
		bool? w_		(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
			Period aj_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_ as object);
			bool? am_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ai_, al_, "day");

			return am_;
		};
		IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);

		return x_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population	(CqlContext context)
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
	public bool? Denominator	(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Date of Second Birthday")]
	public CqlDate Date_of_Second_Birthday	(CqlContext context)
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
	public CqlInterval<CqlDate> First_Two_Years	(CqlContext context)
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
	public bool? Has_Severe_Combined_Immunodeficiency	(CqlContext context)
	{
		CqlValueSet a_ = this.Severe_Combined_Immunodeficiency(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition SevereImmuneDisorder)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, SevereImmuneDisorder);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}


    [CqlDeclaration("Has Immunodeficiency")]
	public bool? Has_Immunodeficiency	(CqlContext context)
	{
		CqlValueSet a_ = this.Disorders_of_the_Immune_System(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition ImmuneDisorder)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, ImmuneDisorder);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}


    [CqlDeclaration("Has HIV")]
	public bool? Has_HIV	(CqlContext context)
	{
		CqlValueSet a_ = this.HIV(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition HIV)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, HIV);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}


    [CqlDeclaration("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
	public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia	(CqlContext context)
	{
		CqlValueSet a_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition LymphaticMalignantNeoplasm)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, LymphaticMalignantNeoplasm);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}


    [CqlDeclaration("Has Intussusception")]
	public bool? Has_Intussusception	(CqlContext context)
	{
		CqlValueSet a_ = this.Intussusception(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition IntussusceptionDisorder)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, IntussusceptionDisorder);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions	(CqlContext context)
	{
		bool? a_ = Hospice_6_9_000.Instance.Has_Hospice_Services(context);
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
	public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old	(CqlContext context)
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
	public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.DTaP_Vaccine(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization DTaPVaccination)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType q_ = DTaPVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization DTaPVaccination)
		{
			DataType v_ = DTaPVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.DTaP_Vaccine_Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure DTaPProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType ad_ = DTaPProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure DTaPProcedure)
		{
			DataType ai_ = DTaPProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Four DTaP Vaccinations")]
	public IEnumerable<CqlDate> Four_DTaP_Vaccinations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.DTaP_Immunizations_or_Procedures(context);
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);
		(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? f_		(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? l_ = (CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

			return l_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(e_, f_);
		bool? h_		((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
		{
			CqlQuantity m_ = context.Operators.Quantity(1m, "day");
			CqlDate n_ = context.Operators.Add(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1, m_);
			bool? o_ = context.Operators.SameOrAfter(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2, n_, "day");
			CqlDate q_ = context.Operators.Add(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination2, m_);
			bool? r_ = context.Operators.SameOrAfter(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3, q_, "day");
			bool? s_ = context.Operators.And(o_, r_);
			CqlDate u_ = context.Operators.Add(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination3, m_);
			bool? v_ = context.Operators.SameOrAfter(tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination4, u_, "day");
			bool? w_ = context.Operators.And(s_, v_);

			return w_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> i_ = context.Operators.Where<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(g_, h_);
		CqlDate j_		((CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) => 
			tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
		IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlTupleMetadata, CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(i_, j_);

		return k_;
	}


    [CqlDeclaration("DTaP Numerator Inclusion Conditions")]
	public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlValueSet a_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet c_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine(context);
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		IEnumerable<Condition> f_ = Status_1_6_000.Instance.Active_Condition(context, e_);
		bool? g_		(Condition DTaPConditions)
		{
			CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, DTaPConditions);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			CqlInterval<CqlDate> l_ = this.First_Two_Years(context);
			bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");

			return m_;
		};
		IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);

		return h_;
	}


    [CqlDeclaration("Polio Immunizations or Procedures")]
	public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.Inactivated_Polio_Vaccine__IPV_(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization PolioVaccination)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType q_ = PolioVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization PolioVaccination)
		{
			DataType v_ = PolioVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Inactivated_Polio_Vaccine__IPV__Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure PolioProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType ad_ = PolioProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure PolioProcedure)
		{
			DataType ai_ = PolioProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Three Polio Vaccinations")]
	public IEnumerable<CqlDate> Three_Polio_Vaccinations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Polio_Immunizations_or_Procedures(context);
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);
		(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? e_		(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? k_ = (CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2, m_, "day");
			CqlDate p_ = context.Operators.Add(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2, l_);
			bool? q_ = context.Operators.SameOrAfter(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3, p_, "day");
			bool? r_ = context.Operators.And(n_, q_);

			return r_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(f_, g_);
		CqlDate i_		((CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv) => 
			tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1;
		IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Polio Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Instance.Active_Condition(context, c_);
		bool? e_		(Condition PolioConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, PolioConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}


    [CqlDeclaration("Date of First Birthday")]
	public CqlDate Date_of_First_Birthday	(CqlContext context)
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
	public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday	(CqlContext context)
	{
		CqlDate a_ = this.Date_of_First_Birthday(context);
		CqlDate b_ = this.Date_of_Second_Birthday(context);
		CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);

		return c_;
	}


    [CqlDeclaration("One MMR Vaccination")]
	public IEnumerable<object> One_MMR_Vaccination	(CqlContext context)
	{
		CqlValueSet a_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization MMRVaccination)
		{
			CqlInterval<CqlDate> l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
			DataType m_ = MMRVaccination?.Occurrence;
			CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
			CqlInterval<CqlDate> p_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, p_, default);

			return q_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlValueSet f_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered(context);
		IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> h_ = Status_1_6_000.Instance.Completed_Procedure(context, g_);
		bool? i_		(Procedure MMRProcedure)
		{
			CqlInterval<CqlDate> r_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
			DataType s_ = MMRProcedure?.Performed;
			object t_ = FHIRHelpers_4_3_000.Instance.ToValue(context, s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.Instance.ToInterval(context, t_);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, default);

			return w_;
		};
		IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
		IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

		return k_;
	}


    [CqlDeclaration("MMR Numerator Inclusion Conditions")]
	public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Instance.Active_Condition(context, c_);
		bool? e_		(Condition MMRConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, MMRConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}


    [CqlDeclaration("Measles Indicators")]
	public IEnumerable<Condition> Measles_Indicators	(CqlContext context)
	{
		CqlValueSet a_ = this.Measles(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition MeaslesDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, MeaslesDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
			bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Mumps Indicators")]
	public IEnumerable<Condition> Mumps_Indicators	(CqlContext context)
	{
		CqlValueSet a_ = this.Mumps(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition MumpsDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, MumpsDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
			bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Rubella Indicators")]
	public IEnumerable<Condition> Rubella_Indicators	(CqlContext context)
	{
		CqlValueSet a_ = this.Rubella(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Instance.Active_Condition(context, b_);
		bool? d_		(Condition RubellaDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, RubellaDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			CqlInterval<CqlDate> i_ = this.First_Two_Years(context);
			bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Hib 3 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.Hib_Vaccine__3_dose_schedule_(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization ThreeDoseHibVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType q_ = ThreeDoseHibVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization ThreeDoseHibVaccine)
		{
			DataType v_ = ThreeDoseHibVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Hib_Vaccine__3_dose_schedule__Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure ThreeDoseHibProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType ad_ = ThreeDoseHibProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure ThreeDoseHibProcedure)
		{
			DataType ai_ = ThreeDoseHibProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Hib 4 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.Hib_Vaccine__4_dose_schedule_(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization HibVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType q_ = HibVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization HibVaccine)
		{
			DataType v_ = HibVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Hib_Vaccine__4_dose_schedule__Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure HibProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType ad_ = HibProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure HibProcedure)
		{
			DataType ai_ = HibProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Hib 3 or 4 Dose Immunizations")]
	public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Hib_3_Dose_Immunizations_or_Procedures(context);
		IEnumerable<CqlDate> b_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
		IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);

		return c_;
	}


    [CqlDeclaration("All Hib Vaccinations")]
	public IEnumerable<CqlDate> All_Hib_Vaccinations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Hib_3_or_4_Dose_Immunizations(context);
		IEnumerable<CqlDate> c_		(CqlDate AllHibDoses1)
		{
			IEnumerable<CqlDate> f_ = this.Hib_3_or_4_Dose_Immunizations(context);
			bool? g_			(CqlDate AllHibDoses2)
			{
				CqlQuantity k_ = context.Operators.Quantity(1m, "day");
				CqlDate l_ = context.Operators.Subtract(AllHibDoses2, k_);
				CqlInterval<CqlDate> m_ = context.Operators.Interval(l_, AllHibDoses2, false, false);
				bool? n_ = context.Operators.In<CqlDate>(AllHibDoses1, m_, default);

				return n_;
			};
			IEnumerable<CqlDate> h_ = context.Operators.Where<CqlDate>(f_, g_);
			CqlDate i_			(CqlDate AllHibDoses2) => 
				AllHibDoses1;
			IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);

			return j_;
		};
		IEnumerable<CqlDate> d_ = context.Operators.SelectMany<CqlDate, CqlDate>(a_, c_);
		IEnumerable<CqlDate> e_ = context.Operators.Except<CqlDate>(a_, d_);

		return e_;
	}


    [CqlDeclaration("Has Appropriate Number of Hib Immunizations")]
	public bool? Has_Appropriate_Number_of_Hib_Immunizations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.All_Hib_Vaccinations(context);
		bool? b_		(CqlDate HibImmunization)
		{
			IEnumerable<CqlDate> e_ = this.Hib_4_Dose_Immunizations_or_Procedures(context);
			int? f_ = context.Operators.Count<CqlDate>(e_);
			bool? g_ = context.Operators.Greater(f_, 0);
			IEnumerable<CqlDate> h_ = this.All_Hib_Vaccinations(context);
			CqlDate i_			(CqlDate HibVaccinations) => 
				HibVaccinations;
			IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
			IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
			int? l_ = context.Operators.Count<CqlDate>(k_);
			bool? m_ = context.Operators.GreaterOrEqual(l_, 4);
			bool? n_ = context.Operators.And(g_, m_);
			int? p_ = context.Operators.Count<CqlDate>(e_);
			bool? q_ = context.Operators.Greater(p_, 0);
			bool? r_ = context.Operators.IsFalse(q_);
			IEnumerable<CqlDate> u_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
			IEnumerable<CqlDate> v_ = context.Operators.Distinct<CqlDate>(u_);
			int? w_ = context.Operators.Count<CqlDate>(v_);
			bool? x_ = context.Operators.GreaterOrEqual(w_, 3);
			bool? y_ = context.Operators.And(r_, x_);
			bool? z_ = context.Operators.Or(n_, y_);

			return z_;
		};
		IEnumerable<CqlDate> c_ = context.Operators.Where<CqlDate>(a_, b_);
		bool? d_ = context.Operators.Exists<CqlDate>(c_);

		return d_;
	}


    [CqlDeclaration("Hib Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlCode a_ = this.Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Instance.Active_Condition(context, c_);
		bool? e_		(Condition HibReaction)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, HibReaction);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}


    [CqlDeclaration("Hepatitis B Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.Hepatitis_B_Vaccine(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization HepatitisBVaccination)
		{
			CqlInterval<CqlDate> p_ = this.First_Two_Years(context);
			DataType q_ = HepatitisBVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization HepatitisBVaccination)
		{
			DataType v_ = HepatitisBVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Hepatitis_B_Vaccine_Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure HepatitisBProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.First_Two_Years(context);
			DataType ad_ = HepatitisBProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure HepatitisBProcedure)
		{
			DataType ai_ = HepatitisBProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Three Hepatitis B Vaccinations")]
	public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);
		(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? e_		(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? k_ = (CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2, m_, "day");
			CqlDate p_ = context.Operators.Add(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2, l_);
			bool? q_ = context.Operators.SameOrAfter(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3, p_, "day");
			bool? r_ = context.Operators.And(n_, q_);

			return r_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(f_, g_);
		CqlDate i_		((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw) => 
			tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1;
		IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(h_, i_);

		return j_;
	}


    [CqlDeclaration("NewBorn Vaccine Requirement")]
	public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement	(CqlContext context)
	{
		CqlCode a_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> d_ = Status_1_6_000.Instance.Completed_Procedure(context, c_);
		bool? e_		(Procedure NewBornVaccine)
		{
			Patient i_ = this.Patient(context);
			Date j_ = i_?.BirthDateElement;
			string k_ = j_?.Value;
			CqlDate l_ = context.Operators.ConvertStringToDate(k_);
			CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
			CqlDate n_ = context.Operators.DateFrom(m_);
			Date p_ = i_?.BirthDateElement;
			string q_ = p_?.Value;
			CqlDate r_ = context.Operators.ConvertStringToDate(q_);
			CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
			CqlDate t_ = context.Operators.DateFrom(s_);
			CqlQuantity u_ = context.Operators.Quantity(7m, "days");
			CqlDate v_ = context.Operators.Add(t_, u_);
			CqlInterval<CqlDate> w_ = context.Operators.Interval(n_, v_, true, true);
			DataType x_ = NewBornVaccine?.Performed;
			object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.ToInterval(context, y_);
			CqlInterval<CqlDate> aa_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, z_);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDate>(w_, aa_, "day");

			return ab_;
		};
		IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
		CqlDate g_		(Procedure NewBornVaccine)
		{
			DataType ac_ = NewBornVaccine?.Performed;
			object ad_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ac_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_);
			CqlDateTime af_ = context.Operators.Start(ae_);
			CqlDate ag_ = context.Operators.DateFrom(af_);

			return ag_;
		};
		IEnumerable<CqlDate> h_ = context.Operators.Select<Procedure, CqlDate>(f_, g_);

		return h_;
	}


    [CqlDeclaration("Meets HepB Vaccination Requirement")]
	public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures(context);
		IEnumerable<CqlDate> c_ = this.NewBorn_Vaccine_Requirement(context);
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, c_);
		(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? e_		(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? k_ = (CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return k_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(d_, e_);
		bool? g_		((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2, m_, "day");
			CqlDate p_ = context.Operators.Add(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3, l_);
			bool? q_ = context.Operators.SameOrAfter(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1, p_, "day");
			bool? r_ = context.Operators.And(n_, q_);
			CqlDate t_ = context.Operators.Add(tuple_hdfambzgbwdpfetgqnfbceeeg?.NewBornVaccine3, l_);
			bool? u_ = context.Operators.SameOrAfter(tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination2, t_, "day");
			bool? v_ = context.Operators.And(r_, u_);

			return v_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> h_ = context.Operators.Where<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(f_, g_);
		CqlDate i_		((CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg) => 
			tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1;
		IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlTupleMetadata, CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(h_, i_);

		return j_;
	}


    [CqlDeclaration("Hepatitis B Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlCode a_ = this.Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet d_ = this.Hepatitis_B(context);
		IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
		IEnumerable<Condition> g_ = Status_1_6_000.Instance.Active_Condition(context, f_);
		bool? h_		(Condition HepBConditions)
		{
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, HepBConditions);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
			bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");

			return n_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}


    [CqlDeclaration("One Chicken Pox Vaccination")]
	public IEnumerable<object> One_Chicken_Pox_Vaccination	(CqlContext context)
	{
		CqlValueSet a_ = this.Varicella_Zoster_Vaccine__VZV_(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization ChickenPoxVaccination)
		{
			CqlInterval<CqlDate> l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
			DataType m_ = ChickenPoxVaccination?.Occurrence;
			CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
			CqlInterval<CqlDate> p_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, p_, default);

			return q_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlValueSet f_ = this.Varicella_Zoster_Vaccine__VZV__Administered(context);
		IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> h_ = Status_1_6_000.Instance.Completed_Procedure(context, g_);
		bool? i_		(Procedure ChickenPoxProcedure)
		{
			CqlInterval<CqlDate> r_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
			DataType s_ = ChickenPoxProcedure?.Performed;
			object t_ = FHIRHelpers_4_3_000.Instance.ToValue(context, s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.Instance.ToInterval(context, t_);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, default);

			return w_;
		};
		IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
		IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

		return k_;
	}


    [CqlDeclaration("Varicella Zoster Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlValueSet a_ = this.Varicella_Zoster(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlCode c_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_(context);
		IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
		IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(b_, e_);
		IEnumerable<Condition> g_ = Status_1_6_000.Instance.Active_Condition(context, f_);
		bool? h_		(Condition VaricellaZoster)
		{
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, VaricellaZoster);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
			bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");

			return n_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}


    [CqlDeclaration("Pneumococcal Conjugate Immunizations or Procedures")]
	public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.Pneumococcal_Conjugate_Vaccine(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization PneumococcalVaccination)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType q_ = PneumococcalVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization PneumococcalVaccination)
		{
			DataType v_ = PneumococcalVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Pneumococcal_Conjugate_Vaccine_Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure PneumococcalProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType ad_ = PneumococcalProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure PneumococcalProcedure)
		{
			DataType ai_ = PneumococcalProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Four Pneumococcal Conjugate Vaccinations")]
	public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures(context);
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);
		(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? f_		(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? l_ = (CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

			return l_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(e_, f_);
		bool? h_		((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
		{
			CqlQuantity m_ = context.Operators.Quantity(1m, "day");
			CqlDate n_ = context.Operators.Add(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1, m_);
			bool? o_ = context.Operators.SameOrAfter(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2, n_, "day");
			CqlDate q_ = context.Operators.Add(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination2, m_);
			bool? r_ = context.Operators.SameOrAfter(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3, q_, "day");
			bool? s_ = context.Operators.And(o_, r_);
			CqlDate u_ = context.Operators.Add(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination3, m_);
			bool? v_ = context.Operators.SameOrAfter(tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination4, u_, "day");
			bool? w_ = context.Operators.And(s_, v_);

			return w_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> i_ = context.Operators.Where<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(g_, h_);
		CqlDate j_		((CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp) => 
			tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1;
		IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlTupleMetadata, CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(i_, j_);

		return k_;
	}


    [CqlDeclaration("Pneumococcal Conjugate Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Instance.Active_Condition(context, c_);
		bool? e_		(Condition PneumococcalReaction)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, PneumococcalReaction);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}


    [CqlDeclaration("One Hepatitis A Vaccinations")]
	public IEnumerable<object> One_Hepatitis_A_Vaccinations	(CqlContext context)
	{
		CqlValueSet a_ = this.Hepatitis_A_Vaccine(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization HepatitisAVaccination)
		{
			CqlInterval<CqlDate> l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
			DataType m_ = HepatitisAVaccination?.Occurrence;
			CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
			CqlInterval<CqlDate> p_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, p_, default);

			return q_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlValueSet f_ = this.Hepatitis_A_Vaccine_Administered(context);
		IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> h_ = Status_1_6_000.Instance.Completed_Procedure(context, g_);
		bool? i_		(Procedure HepatitisAProcedure)
		{
			CqlInterval<CqlDate> r_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday(context);
			DataType s_ = HepatitisAProcedure?.Performed;
			object t_ = FHIRHelpers_4_3_000.Instance.ToValue(context, s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.Instance.ToInterval(context, t_);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, default);

			return w_;
		};
		IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
		IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

		return k_;
	}


    [CqlDeclaration("Hepatitis A Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlValueSet a_ = this.Hepatitis_A(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlCode c_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_(context);
		IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
		IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(b_, e_);
		IEnumerable<Condition> g_ = Status_1_6_000.Instance.Active_Condition(context, f_);
		bool? h_		(Condition HepatitisADiagnosis)
		{
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, HepatitisADiagnosis);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDate> m_ = this.First_Two_Years(context);
			bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");

			return n_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}


    [CqlDeclaration("Rotavirus 2 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlCode a_ = this.rotavirus__live__monovalent_vaccine(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Immunization> c_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> d_ = Status_1_6_000.Instance.Completed_Immunization(context, c_);
		bool? e_		(Immunization TwoDoseRotavirusVaccine)
		{
			CqlInterval<CqlDate> q_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType r_ = TwoDoseRotavirusVaccine?.Occurrence;
			CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.Instance.ToInterval(context, s_ as object);
			CqlInterval<CqlDate> u_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, t_);
			bool? v_ = context.Operators.IntervalIncludesInterval<CqlDate>(q_, u_, "day");

			return v_;
		};
		IEnumerable<Immunization> f_ = context.Operators.Where<Immunization>(d_, e_);
		CqlDate g_		(Immunization TwoDoseRotavirusVaccine)
		{
			DataType w_ = TwoDoseRotavirusVaccine?.Occurrence;
			CqlDateTime x_ = context.Operators.LateBoundProperty<CqlDateTime>(w_, "value");
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
			CqlInterval<CqlDate> z_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, y_);
			CqlDate aa_ = context.Operators.Start(z_);
			CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
			CqlDate ac_ = context.Operators.DateFrom(ab_);

			return ac_;
		};
		IEnumerable<CqlDate> h_ = context.Operators.Select<Immunization, CqlDate>(f_, g_);
		CqlValueSet i_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered(context);
		IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> k_ = Status_1_6_000.Instance.Completed_Procedure(context, j_);
		bool? l_		(Procedure TwoDoseRotavirusProcedure)
		{
			CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType ae_ = TwoDoseRotavirusProcedure?.Performed;
			object af_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ae_);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.Instance.ToInterval(context, af_);
			CqlInterval<CqlDate> ah_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ag_);
			bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDate>(ad_, ah_, "day");

			return ai_;
		};
		IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
		CqlDate n_		(Procedure TwoDoseRotavirusProcedure)
		{
			DataType aj_ = TwoDoseRotavirusProcedure?.Performed;
			object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
			CqlInterval<CqlDate> am_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, al_);
			CqlDate an_ = context.Operators.Start(am_);
			CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
			CqlDate ap_ = context.Operators.DateFrom(ao_);

			return ap_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
		IEnumerable<CqlDate> p_ = context.Operators.Union<CqlDate>(h_, o_);

		return p_;
	}


    [CqlDeclaration("Rotavirus 3 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.Rotavirus_Vaccine__3_dose_schedule_(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization ThreeDoseRotavirusVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType q_ = ThreeDoseRotavirusVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization ThreeDoseRotavirusVaccine)
		{
			DataType v_ = ThreeDoseRotavirusVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure ThreeDoseRotavirusAdministered)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType ad_ = ThreeDoseRotavirusAdministered?.Performed;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure ThreeDoseRotavirusAdministered)
		{
			DataType ai_ = ThreeDoseRotavirusAdministered?.Performed;
			object aj_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Rotavirus 2 or 3 Dose Immunizations")]
	public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures(context);
		IEnumerable<CqlDate> b_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
		IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);

		return c_;
	}


    [CqlDeclaration("All Rotavirus Vaccinations")]
	public IEnumerable<CqlDate> All_Rotavirus_Vaccinations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
		IEnumerable<CqlDate> c_		(CqlDate AllRotavirusDoses1)
		{
			IEnumerable<CqlDate> f_ = this.Rotavirus_2_or_3_Dose_Immunizations(context);
			bool? g_			(CqlDate AllRotavirusDoses2)
			{
				CqlQuantity k_ = context.Operators.Quantity(1m, "day");
				CqlDate l_ = context.Operators.Subtract(AllRotavirusDoses2, k_);
				CqlInterval<CqlDate> m_ = context.Operators.Interval(l_, AllRotavirusDoses2, false, false);
				bool? n_ = context.Operators.In<CqlDate>(AllRotavirusDoses1, m_, default);

				return n_;
			};
			IEnumerable<CqlDate> h_ = context.Operators.Where<CqlDate>(f_, g_);
			CqlDate i_			(CqlDate AllRotavirusDoses2) => 
				AllRotavirusDoses1;
			IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);

			return j_;
		};
		IEnumerable<CqlDate> d_ = context.Operators.SelectMany<CqlDate, CqlDate>(a_, c_);
		IEnumerable<CqlDate> e_ = context.Operators.Except<CqlDate>(a_, d_);

		return e_;
	}


    [CqlDeclaration("Has Appropriate Number of Rotavirus Immunizations")]
	public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.All_Rotavirus_Vaccinations(context);
		bool? b_		(CqlDate RotavirusImmunization)
		{
			IEnumerable<CqlDate> e_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures(context);
			int? f_ = context.Operators.Count<CqlDate>(e_);
			bool? g_ = context.Operators.Greater(f_, 0);
			IEnumerable<CqlDate> h_ = this.All_Rotavirus_Vaccinations(context);
			CqlDate i_			(CqlDate RotavirusVaccinations) => 
				RotavirusVaccinations;
			IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
			IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
			int? l_ = context.Operators.Count<CqlDate>(k_);
			bool? m_ = context.Operators.GreaterOrEqual(l_, 3);
			bool? n_ = context.Operators.And(g_, m_);
			int? p_ = context.Operators.Count<CqlDate>(e_);
			bool? q_ = context.Operators.Greater(p_, 0);
			bool? r_ = context.Operators.IsFalse(q_);
			IEnumerable<CqlDate> u_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);
			IEnumerable<CqlDate> v_ = context.Operators.Distinct<CqlDate>(u_);
			int? w_ = context.Operators.Count<CqlDate>(v_);
			bool? x_ = context.Operators.GreaterOrEqual(w_, 2);
			bool? y_ = context.Operators.And(r_, x_);
			bool? z_ = context.Operators.Or(n_, y_);

			return z_;
		};
		IEnumerable<CqlDate> c_ = context.Operators.Where<CqlDate>(a_, b_);
		bool? d_ = context.Operators.Exists<CqlDate>(c_);

		return d_;
	}


    [CqlDeclaration("Rotavirus Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlCode a_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Instance.Active_Condition(context, c_);
		bool? e_		(Condition RotavirusConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, RotavirusConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}


    [CqlDeclaration("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
	public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old	(CqlContext context)
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
	public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures	(CqlContext context)
	{
		CqlValueSet a_ = this.Child_Influenza_Immunization_Administered(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization InfluenzaVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old(context);
			DataType q_ = InfluenzaVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization InfluenzaVaccine)
		{
			DataType v_ = InfluenzaVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Child_Influenza_Vaccine_Administered(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure InfluenzaAdministration)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old(context);
			CqlDate ad_ = ac_?.low;
			CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
			CqlDate ag_ = ac_?.high;
			CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
			bool? aj_ = ac_?.lowClosed;
			bool? al_ = ac_?.highClosed;
			CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ae_, ah_, aj_, al_);
			DataType an_ = InfluenzaAdministration?.Performed;
			object ao_ = FHIRHelpers_4_3_000.Instance.ToValue(context, an_);
			CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ao_);
			bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(am_, ap_, "day");

			return aq_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure InfluenzaAdministration)
		{
			DataType ar_ = InfluenzaAdministration?.Performed;
			object as_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ar_);
			CqlInterval<CqlDateTime> at_ = QICoreCommon_2_0_000.Instance.ToInterval(context, as_);
			CqlInterval<CqlDate> au_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, at_);
			CqlDate av_ = context.Operators.Start(au_);
			CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
			CqlDate ax_ = context.Operators.DateFrom(aw_);

			return ax_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Two Influenza Vaccinations")]
	public IEnumerable<CqlDate> Two_Influenza_Vaccinations	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.Influenza_Immunizations_or_Procedures(context);
		IEnumerable<ValueTuple<CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);
		(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? d_		(ValueTuple<CqlDate, CqlDate> _valueTuple)
		{
			(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? j_ = (CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ, _valueTuple.Item1, _valueTuple.Item2);

			return j_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(c_, d_);
		bool? f_		((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
		{
			CqlQuantity k_ = context.Operators.Quantity(1m, "day");
			CqlDate l_ = context.Operators.Add(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1, k_);
			bool? m_ = context.Operators.SameOrAfter(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2, l_, "day");

			return m_;
		};
		IEnumerable<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?> g_ = context.Operators.Where<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?>(e_, f_);
		CqlDate h_		((CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq) => 
			tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1;
		IEnumerable<CqlDate> i_ = context.Operators.Select<(CqlTupleMetadata, CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(g_, h_);

		return i_;
	}


    [CqlDeclaration("LAIV Vaccinations")]
	public IEnumerable<CqlDate> LAIV_Vaccinations	(CqlContext context)
	{
		CqlValueSet a_ = this.Influenza_Virus_LAIV_Immunization(context);
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Instance.Completed_Immunization(context, b_);
		bool? d_		(Immunization LAIVVaccine)
		{
			CqlDate p_ = this.Date_of_Second_Birthday(context);
			CqlInterval<CqlDate> r_ = context.Operators.Interval(p_, p_, true, true);
			DataType s_ = LAIVVaccine?.Occurrence;
			CqlDateTime t_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.Instance.ToInterval(context, t_ as object);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, "day");

			return w_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_		(Immunization LAIVVaccine)
		{
			DataType x_ = LAIVVaccine?.Occurrence;
			CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.ToInterval(context, y_ as object);
			CqlInterval<CqlDate> aa_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, z_);
			CqlDate ab_ = context.Operators.Start(aa_);
			CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
			CqlDate ad_ = context.Operators.DateFrom(ac_);

			return ad_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Influenza_Virus_LAIV_Procedure(context);
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Instance.Completed_Procedure(context, i_);
		bool? k_		(Procedure InfluenzaAdministration)
		{
			CqlDate ae_ = this.Date_of_Second_Birthday(context);
			CqlInterval<CqlDate> ag_ = context.Operators.Interval(ae_, ae_, true, true);
			DataType ah_ = InfluenzaAdministration?.Performed;
			object ai_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ah_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ai_);
			CqlInterval<CqlDate> ak_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, aj_);
			bool? al_ = context.Operators.IntervalIncludesInterval<CqlDate>(ag_, ak_, "day");

			return al_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_		(Procedure InfluenzaAdministration)
		{
			DataType am_ = InfluenzaAdministration?.Performed;
			object an_ = FHIRHelpers_4_3_000.Instance.ToValue(context, am_);
			CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.Instance.ToInterval(context, an_);
			CqlInterval<CqlDate> ap_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, ao_);
			CqlDate aq_ = context.Operators.Start(ap_);
			CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);

			return as_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}


    [CqlDeclaration("Two Influenza Vaccinations Including One LAIV Vaccination")]
	public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination	(CqlContext context)
	{
		IEnumerable<CqlDate> a_ = this.LAIV_Vaccinations(context);
		bool? b_ = context.Operators.Exists<CqlDate>(a_);
		IEnumerable<CqlDate> c_ = this.Influenza_Immunizations_or_Procedures(context);
		bool? d_ = context.Operators.Exists<CqlDate>(c_);
		bool? e_ = context.Operators.And(b_, d_);

		return e_;
	}


    [CqlDeclaration("Influenza Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions	(CqlContext context)
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Instance.Active_Condition(context, c_);
		bool? e_		(Condition InfluenzaConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, InfluenzaConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years(context);
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator	(CqlContext context)
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
		IEnumerable<object> l_ = this.One_MMR_Vaccination(context);
		bool? m_ = context.Operators.Exists<object>(l_);
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
		IEnumerable<object> ao_ = this.One_Chicken_Pox_Vaccination(context);
		bool? ap_ = context.Operators.Exists<object>(ao_);
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
		IEnumerable<object> ba_ = this.One_Hepatitis_A_Vaccinations(context);
		bool? bb_ = context.Operators.Exists<object>(ba_);
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
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity	(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer	(CqlContext context)
	{
		IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race	(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex	(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

    private static CqlTupleMetadata CqlTupleMetadata_EMDhFLcFhWVERAVVNfLAZYXJi = new([typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)], ["DTaPVaccination1", "DTaPVaccination2", "DTaPVaccination3", "DTaPVaccination4"]);
    private static CqlTupleMetadata CqlTupleMetadata_CNGHaZROXaJTHPICcbIaJbRXV = new([typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)], ["PolioVaccination1", "PolioVaccination2", "PolioVaccination3"]);
    private static CqlTupleMetadata CqlTupleMetadata_EZTgahAUWGgSdGaDCgQNNIPGW = new([typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)], ["HepatitisBVaccination1", "HepatitisBVaccination2", "HepatitisBVaccination3"]);
    private static CqlTupleMetadata CqlTupleMetadata_HDfaMbZGBWDPFETGQNFbceEeg = new([typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)], ["HepatitisBVaccination1", "HepatitisBVaccination2", "NewBornVaccine3"]);
    private static CqlTupleMetadata CqlTupleMetadata_DdPDeOJhPYESfHGCOcBNOiPPP = new([typeof(CqlDate), typeof(CqlDate), typeof(CqlDate), typeof(CqlDate)], ["PneumococcalVaccination1", "PneumococcalVaccination2", "PneumococcalVaccination3", "PneumococcalVaccination4"]);
    private static CqlTupleMetadata CqlTupleMetadata_BZhFLeRDagbPQMNheVJcUNfNQ = new([typeof(CqlDate), typeof(CqlDate)], ["FluVaccination1", "FluVaccination2"]);
}
