using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("ChildhoodImmunizationStatusFHIR", "0.1.000")]
public class ChildhoodImmunizationStatusFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Anaphylactic_Reaction_to_DTaP_Vaccine;
    internal Lazy<CqlValueSet> __Disorders_of_the_Immune_System;
    internal Lazy<CqlValueSet> __DTaP_Vaccine;
    internal Lazy<CqlValueSet> __DTaP_Vaccine_Administered;
    internal Lazy<CqlValueSet> __Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered;
    internal Lazy<CqlValueSet> __Hepatitis_A;
    internal Lazy<CqlValueSet> __Hepatitis_A_Vaccine;
    internal Lazy<CqlValueSet> __Hepatitis_A_Vaccine_Administered;
    internal Lazy<CqlValueSet> __Hepatitis_B;
    internal Lazy<CqlValueSet> __Hepatitis_B_Vaccine;
    internal Lazy<CqlValueSet> __Hepatitis_B_Vaccine_Administered;
    internal Lazy<CqlValueSet> __Hib_Vaccine__3_dose_schedule_;
    internal Lazy<CqlValueSet> __Hib_Vaccine__3_dose_schedule__Administered;
    internal Lazy<CqlValueSet> __Hib_Vaccine__4_dose_schedule_;
    internal Lazy<CqlValueSet> __Hib_Vaccine__4_dose_schedule__Administered;
    internal Lazy<CqlValueSet> __HIV;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Hospice_care_ambulatory;
    internal Lazy<CqlValueSet> __Inactivated_Polio_Vaccine__IPV_;
    internal Lazy<CqlValueSet> __Inactivated_Polio_Vaccine__IPV__Administered;
    internal Lazy<CqlValueSet> __Child_Influenza_Immunization_Administered;
    internal Lazy<CqlValueSet> __Child_Influenza_Vaccine_Administered;
    internal Lazy<CqlValueSet> __Influenza_Virus_LAIV_Immunization;
    internal Lazy<CqlValueSet> __Influenza_Virus_LAIV_Procedure;
    internal Lazy<CqlValueSet> __Intussusception;
    internal Lazy<CqlValueSet> __Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue;
    internal Lazy<CqlValueSet> __Measles;
    internal Lazy<CqlValueSet> __Measles__Mumps_and_Rubella__MMR__Vaccine;
    internal Lazy<CqlValueSet> __Measles__Mumps_and_Rubella__MMR__Vaccine_Administered;
    internal Lazy<CqlValueSet> __Mumps;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Pneumococcal_Conjugate_Vaccine;
    internal Lazy<CqlValueSet> __Pneumococcal_Conjugate_Vaccine_Administered;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Rotavirus_Vaccine__2_dose_schedule__Administered;
    internal Lazy<CqlValueSet> __Rotavirus_Vaccine__3_dose_schedule_;
    internal Lazy<CqlValueSet> __Rotavirus_Vaccine__3_dose_schedule__Administered;
    internal Lazy<CqlValueSet> __Rubella;
    internal Lazy<CqlValueSet> __Severe_Combined_Immunodeficiency;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Varicella_Zoster;
    internal Lazy<CqlValueSet> __Varicella_Zoster_Vaccine__VZV_;
    internal Lazy<CqlValueSet> __Varicella_Zoster_Vaccine__VZV__Administered;
    internal Lazy<CqlCode> __Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_;
    internal Lazy<CqlCode> __Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_;
    internal Lazy<CqlCode> __Anaphylaxis_due_to_rotavirus_vaccine__disorder_;
    internal Lazy<CqlCode> __Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional;
    internal Lazy<CqlCode> __rotavirus__live__monovalent_vaccine;
    internal Lazy<CqlCode> __Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_;
    internal Lazy<CqlCode> __Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach;
    internal Lazy<CqlCode> __Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_;
    internal Lazy<CqlCode> __Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_;
    internal Lazy<CqlCode> __Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_;
    internal Lazy<CqlCode> __Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_;
    internal Lazy<CqlCode> __Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlCode[]> __CVX;
    internal Lazy<CqlCode[]> __ICD10;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<CqlDate> __Date_of_Second_Birthday;
    internal Lazy<CqlInterval<CqlDate>> __First_Two_Years;
    internal Lazy<bool?> __Has_Severe_Combined_Immunodeficiency;
    internal Lazy<bool?> __Has_Immunodeficiency;
    internal Lazy<bool?> __Has_HIV;
    internal Lazy<bool?> __Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia;
    internal Lazy<bool?> __Has_Intussusception;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<CqlInterval<CqlDate>> __Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old;
    internal Lazy<IEnumerable<CqlDate>> __DTaP_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Four_DTaP_Vaccinations;
    internal Lazy<IEnumerable<Condition>> __DTaP_Numerator_Inclusion_Conditions;
    internal Lazy<IEnumerable<CqlDate>> __Polio_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Three_Polio_Vaccinations;
    internal Lazy<IEnumerable<Condition>> __Polio_Numerator_Inclusion_Conditions;
    internal Lazy<CqlDate> __Date_of_First_Birthday;
    internal Lazy<CqlInterval<CqlDate>> __Date_of_First_Birthday_to_Date_of_Second_Birthday;
    internal Lazy<IEnumerable<object>> __One_MMR_Vaccination;
    internal Lazy<IEnumerable<Condition>> __MMR_Numerator_Inclusion_Conditions;
    internal Lazy<IEnumerable<Condition>> __Measles_Indicators;
    internal Lazy<IEnumerable<Condition>> __Mumps_Indicators;
    internal Lazy<IEnumerable<Condition>> __Rubella_Indicators;
    internal Lazy<IEnumerable<CqlDate>> __Hib_3_Dose_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Hib_4_Dose_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Hib_3_or_4_Dose_Immunizations;
    internal Lazy<IEnumerable<CqlDate>> __All_Hib_Vaccinations;
    internal Lazy<bool?> __Has_Appropriate_Number_of_Hib_Immunizations;
    internal Lazy<IEnumerable<Condition>> __Hib_Numerator_Inclusion_Conditions;
    internal Lazy<IEnumerable<CqlDate>> __Hepatitis_B_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Three_Hepatitis_B_Vaccinations;
    internal Lazy<IEnumerable<CqlDate>> __NewBorn_Vaccine_Requirement;
    internal Lazy<IEnumerable<CqlDate>> __Meets_HepB_Vaccination_Requirement;
    internal Lazy<IEnumerable<Condition>> __Hepatitis_B_Numerator_Inclusion_Conditions;
    internal Lazy<IEnumerable<object>> __One_Chicken_Pox_Vaccination;
    internal Lazy<IEnumerable<Condition>> __Varicella_Zoster_Numerator_Inclusion_Conditions;
    internal Lazy<IEnumerable<CqlDate>> __Pneumococcal_Conjugate_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Four_Pneumococcal_Conjugate_Vaccinations;
    internal Lazy<IEnumerable<Condition>> __Pneumococcal_Conjugate_Numerator_Inclusion_Conditions;
    internal Lazy<IEnumerable<object>> __One_Hepatitis_A_Vaccinations;
    internal Lazy<IEnumerable<Condition>> __Hepatitis_A_Numerator_Inclusion_Conditions;
    internal Lazy<IEnumerable<CqlDate>> __Rotavirus_2_Dose_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Rotavirus_3_Dose_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Rotavirus_2_or_3_Dose_Immunizations;
    internal Lazy<IEnumerable<CqlDate>> __All_Rotavirus_Vaccinations;
    internal Lazy<bool?> __Has_Appropriate_Number_of_Rotavirus_Immunizations;
    internal Lazy<IEnumerable<Condition>> __Rotavirus_Numerator_Inclusion_Conditions;
    internal Lazy<CqlInterval<CqlDate>> __Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old;
    internal Lazy<IEnumerable<CqlDate>> __Influenza_Immunizations_or_Procedures;
    internal Lazy<IEnumerable<CqlDate>> __Two_Influenza_Vaccinations;
    internal Lazy<IEnumerable<CqlDate>> __LAIV_Vaccinations;
    internal Lazy<bool?> __Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination;
    internal Lazy<IEnumerable<Condition>> __Influenza_Numerator_Inclusion_Conditions;
    internal Lazy<bool?> __Numerator;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public ChildhoodImmunizationStatusFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Anaphylactic_Reaction_to_DTaP_Vaccine = new Lazy<CqlValueSet>(this.Anaphylactic_Reaction_to_DTaP_Vaccine_Value);
        __Disorders_of_the_Immune_System = new Lazy<CqlValueSet>(this.Disorders_of_the_Immune_System_Value);
        __DTaP_Vaccine = new Lazy<CqlValueSet>(this.DTaP_Vaccine_Value);
        __DTaP_Vaccine_Administered = new Lazy<CqlValueSet>(this.DTaP_Vaccine_Administered_Value);
        __Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine = new Lazy<CqlValueSet>(this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered = new Lazy<CqlValueSet>(this.Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered_Value);
        __Hepatitis_A = new Lazy<CqlValueSet>(this.Hepatitis_A_Value);
        __Hepatitis_A_Vaccine = new Lazy<CqlValueSet>(this.Hepatitis_A_Vaccine_Value);
        __Hepatitis_A_Vaccine_Administered = new Lazy<CqlValueSet>(this.Hepatitis_A_Vaccine_Administered_Value);
        __Hepatitis_B = new Lazy<CqlValueSet>(this.Hepatitis_B_Value);
        __Hepatitis_B_Vaccine = new Lazy<CqlValueSet>(this.Hepatitis_B_Vaccine_Value);
        __Hepatitis_B_Vaccine_Administered = new Lazy<CqlValueSet>(this.Hepatitis_B_Vaccine_Administered_Value);
        __Hib_Vaccine__3_dose_schedule_ = new Lazy<CqlValueSet>(this.Hib_Vaccine__3_dose_schedule__Value);
        __Hib_Vaccine__3_dose_schedule__Administered = new Lazy<CqlValueSet>(this.Hib_Vaccine__3_dose_schedule__Administered_Value);
        __Hib_Vaccine__4_dose_schedule_ = new Lazy<CqlValueSet>(this.Hib_Vaccine__4_dose_schedule__Value);
        __Hib_Vaccine__4_dose_schedule__Administered = new Lazy<CqlValueSet>(this.Hib_Vaccine__4_dose_schedule__Administered_Value);
        __HIV = new Lazy<CqlValueSet>(this.HIV_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Hospice_care_ambulatory = new Lazy<CqlValueSet>(this.Hospice_care_ambulatory_Value);
        __Inactivated_Polio_Vaccine__IPV_ = new Lazy<CqlValueSet>(this.Inactivated_Polio_Vaccine__IPV__Value);
        __Inactivated_Polio_Vaccine__IPV__Administered = new Lazy<CqlValueSet>(this.Inactivated_Polio_Vaccine__IPV__Administered_Value);
        __Child_Influenza_Immunization_Administered = new Lazy<CqlValueSet>(this.Child_Influenza_Immunization_Administered_Value);
        __Child_Influenza_Vaccine_Administered = new Lazy<CqlValueSet>(this.Child_Influenza_Vaccine_Administered_Value);
        __Influenza_Virus_LAIV_Immunization = new Lazy<CqlValueSet>(this.Influenza_Virus_LAIV_Immunization_Value);
        __Influenza_Virus_LAIV_Procedure = new Lazy<CqlValueSet>(this.Influenza_Virus_LAIV_Procedure_Value);
        __Intussusception = new Lazy<CqlValueSet>(this.Intussusception_Value);
        __Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue = new Lazy<CqlValueSet>(this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue_Value);
        __Measles = new Lazy<CqlValueSet>(this.Measles_Value);
        __Measles__Mumps_and_Rubella__MMR__Vaccine = new Lazy<CqlValueSet>(this.Measles__Mumps_and_Rubella__MMR__Vaccine_Value);
        __Measles__Mumps_and_Rubella__MMR__Vaccine_Administered = new Lazy<CqlValueSet>(this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered_Value);
        __Mumps = new Lazy<CqlValueSet>(this.Mumps_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Pneumococcal_Conjugate_Vaccine = new Lazy<CqlValueSet>(this.Pneumococcal_Conjugate_Vaccine_Value);
        __Pneumococcal_Conjugate_Vaccine_Administered = new Lazy<CqlValueSet>(this.Pneumococcal_Conjugate_Vaccine_Administered_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Rotavirus_Vaccine__2_dose_schedule__Administered = new Lazy<CqlValueSet>(this.Rotavirus_Vaccine__2_dose_schedule__Administered_Value);
        __Rotavirus_Vaccine__3_dose_schedule_ = new Lazy<CqlValueSet>(this.Rotavirus_Vaccine__3_dose_schedule__Value);
        __Rotavirus_Vaccine__3_dose_schedule__Administered = new Lazy<CqlValueSet>(this.Rotavirus_Vaccine__3_dose_schedule__Administered_Value);
        __Rubella = new Lazy<CqlValueSet>(this.Rubella_Value);
        __Severe_Combined_Immunodeficiency = new Lazy<CqlValueSet>(this.Severe_Combined_Immunodeficiency_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Varicella_Zoster = new Lazy<CqlValueSet>(this.Varicella_Zoster_Value);
        __Varicella_Zoster_Vaccine__VZV_ = new Lazy<CqlValueSet>(this.Varicella_Zoster_Vaccine__VZV__Value);
        __Varicella_Zoster_Vaccine__VZV__Administered = new Lazy<CqlValueSet>(this.Varicella_Zoster_Vaccine__VZV__Administered_Value);
        __Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder__Value);
        __Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder__Value);
        __Anaphylaxis_due_to_rotavirus_vaccine__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_due_to_rotavirus_vaccine__disorder__Value);
        __Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional = new Lazy<CqlCode>(this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional_Value);
        __rotavirus__live__monovalent_vaccine = new Lazy<CqlCode>(this.rotavirus__live__monovalent_vaccine_Value);
        __Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder__Value);
        __Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach = new Lazy<CqlCode>(this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach_Value);
        __Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder__Value);
        __Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder__Value);
        __Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder__Value);
        __Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder__Value);
        __Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_ = new Lazy<CqlCode>(this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder__Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __CVX = new Lazy<CqlCode[]>(this.CVX_Value);
        __ICD10 = new Lazy<CqlCode[]>(this.ICD10_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Date_of_Second_Birthday = new Lazy<CqlDate>(this.Date_of_Second_Birthday_Value);
        __First_Two_Years = new Lazy<CqlInterval<CqlDate>>(this.First_Two_Years_Value);
        __Has_Severe_Combined_Immunodeficiency = new Lazy<bool?>(this.Has_Severe_Combined_Immunodeficiency_Value);
        __Has_Immunodeficiency = new Lazy<bool?>(this.Has_Immunodeficiency_Value);
        __Has_HIV = new Lazy<bool?>(this.Has_HIV_Value);
        __Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia = new Lazy<bool?>(this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia_Value);
        __Has_Intussusception = new Lazy<bool?>(this.Has_Intussusception_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old = new Lazy<CqlInterval<CqlDate>>(this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old_Value);
        __DTaP_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.DTaP_Immunizations_or_Procedures_Value);
        __Four_DTaP_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.Four_DTaP_Vaccinations_Value);
        __DTaP_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.DTaP_Numerator_Inclusion_Conditions_Value);
        __Polio_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Polio_Immunizations_or_Procedures_Value);
        __Three_Polio_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.Three_Polio_Vaccinations_Value);
        __Polio_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Polio_Numerator_Inclusion_Conditions_Value);
        __Date_of_First_Birthday = new Lazy<CqlDate>(this.Date_of_First_Birthday_Value);
        __Date_of_First_Birthday_to_Date_of_Second_Birthday = new Lazy<CqlInterval<CqlDate>>(this.Date_of_First_Birthday_to_Date_of_Second_Birthday_Value);
        __One_MMR_Vaccination = new Lazy<IEnumerable<object>>(this.One_MMR_Vaccination_Value);
        __MMR_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.MMR_Numerator_Inclusion_Conditions_Value);
        __Measles_Indicators = new Lazy<IEnumerable<Condition>>(this.Measles_Indicators_Value);
        __Mumps_Indicators = new Lazy<IEnumerable<Condition>>(this.Mumps_Indicators_Value);
        __Rubella_Indicators = new Lazy<IEnumerable<Condition>>(this.Rubella_Indicators_Value);
        __Hib_3_Dose_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Hib_3_Dose_Immunizations_or_Procedures_Value);
        __Hib_4_Dose_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Hib_4_Dose_Immunizations_or_Procedures_Value);
        __Hib_3_or_4_Dose_Immunizations = new Lazy<IEnumerable<CqlDate>>(this.Hib_3_or_4_Dose_Immunizations_Value);
        __All_Hib_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.All_Hib_Vaccinations_Value);
        __Has_Appropriate_Number_of_Hib_Immunizations = new Lazy<bool?>(this.Has_Appropriate_Number_of_Hib_Immunizations_Value);
        __Hib_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Hib_Numerator_Inclusion_Conditions_Value);
        __Hepatitis_B_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Hepatitis_B_Immunizations_or_Procedures_Value);
        __Three_Hepatitis_B_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.Three_Hepatitis_B_Vaccinations_Value);
        __NewBorn_Vaccine_Requirement = new Lazy<IEnumerable<CqlDate>>(this.NewBorn_Vaccine_Requirement_Value);
        __Meets_HepB_Vaccination_Requirement = new Lazy<IEnumerable<CqlDate>>(this.Meets_HepB_Vaccination_Requirement_Value);
        __Hepatitis_B_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Hepatitis_B_Numerator_Inclusion_Conditions_Value);
        __One_Chicken_Pox_Vaccination = new Lazy<IEnumerable<object>>(this.One_Chicken_Pox_Vaccination_Value);
        __Varicella_Zoster_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Varicella_Zoster_Numerator_Inclusion_Conditions_Value);
        __Pneumococcal_Conjugate_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Pneumococcal_Conjugate_Immunizations_or_Procedures_Value);
        __Four_Pneumococcal_Conjugate_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.Four_Pneumococcal_Conjugate_Vaccinations_Value);
        __Pneumococcal_Conjugate_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions_Value);
        __One_Hepatitis_A_Vaccinations = new Lazy<IEnumerable<object>>(this.One_Hepatitis_A_Vaccinations_Value);
        __Hepatitis_A_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Hepatitis_A_Numerator_Inclusion_Conditions_Value);
        __Rotavirus_2_Dose_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Rotavirus_2_Dose_Immunizations_or_Procedures_Value);
        __Rotavirus_3_Dose_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Rotavirus_3_Dose_Immunizations_or_Procedures_Value);
        __Rotavirus_2_or_3_Dose_Immunizations = new Lazy<IEnumerable<CqlDate>>(this.Rotavirus_2_or_3_Dose_Immunizations_Value);
        __All_Rotavirus_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.All_Rotavirus_Vaccinations_Value);
        __Has_Appropriate_Number_of_Rotavirus_Immunizations = new Lazy<bool?>(this.Has_Appropriate_Number_of_Rotavirus_Immunizations_Value);
        __Rotavirus_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Rotavirus_Numerator_Inclusion_Conditions_Value);
        __Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old = new Lazy<CqlInterval<CqlDate>>(this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old_Value);
        __Influenza_Immunizations_or_Procedures = new Lazy<IEnumerable<CqlDate>>(this.Influenza_Immunizations_or_Procedures_Value);
        __Two_Influenza_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.Two_Influenza_Vaccinations_Value);
        __LAIV_Vaccinations = new Lazy<IEnumerable<CqlDate>>(this.LAIV_Vaccinations_Value);
        __Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination = new Lazy<bool?>(this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination_Value);
        __Influenza_Numerator_Inclusion_Conditions = new Lazy<IEnumerable<Condition>>(this.Influenza_Numerator_Inclusion_Conditions_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", null);

    [CqlDeclaration("Anaphylactic Reaction to DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031")]
	public CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine() => 
		__Anaphylactic_Reaction_to_DTaP_Vaccine.Value;

	private CqlValueSet Disorders_of_the_Immune_System_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", null);

    [CqlDeclaration("Disorders of the Immune System")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001")]
	public CqlValueSet Disorders_of_the_Immune_System() => 
		__Disorders_of_the_Immune_System.Value;

	private CqlValueSet DTaP_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", null);

    [CqlDeclaration("DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214")]
	public CqlValueSet DTaP_Vaccine() => 
		__DTaP_Vaccine.Value;

	private CqlValueSet DTaP_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", null);

    [CqlDeclaration("DTaP Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022")]
	public CqlValueSet DTaP_Vaccine_Administered() => 
		__DTaP_Vaccine_Administered.Value;

	private CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", null);

    [CqlDeclaration("Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164")]
	public CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine() => 
		__Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043", null);

    [CqlDeclaration("Haemophilus Influenzae Type B (Hib) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043")]
	public CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered() => 
		__Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered.Value;

	private CqlValueSet Hepatitis_A_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);

    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
	public CqlValueSet Hepatitis_A() => 
		__Hepatitis_A.Value;

	private CqlValueSet Hepatitis_A_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", null);

    [CqlDeclaration("Hepatitis A Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215")]
	public CqlValueSet Hepatitis_A_Vaccine() => 
		__Hepatitis_A_Vaccine.Value;

	private CqlValueSet Hepatitis_A_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", null);

    [CqlDeclaration("Hepatitis A Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041")]
	public CqlValueSet Hepatitis_A_Vaccine_Administered() => 
		__Hepatitis_A_Vaccine_Administered.Value;

	private CqlValueSet Hepatitis_B_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", null);

    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025")]
	public CqlValueSet Hepatitis_B() => 
		__Hepatitis_B.Value;

	private CqlValueSet Hepatitis_B_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", null);

    [CqlDeclaration("Hepatitis B Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216")]
	public CqlValueSet Hepatitis_B_Vaccine() => 
		__Hepatitis_B_Vaccine.Value;

	private CqlValueSet Hepatitis_B_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", null);

    [CqlDeclaration("Hepatitis B Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042")]
	public CqlValueSet Hepatitis_B_Vaccine_Administered() => 
		__Hepatitis_B_Vaccine_Administered.Value;

	private CqlValueSet Hib_Vaccine__3_dose_schedule__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", null);

    [CqlDeclaration("Hib Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083")]
	public CqlValueSet Hib_Vaccine__3_dose_schedule_() => 
		__Hib_Vaccine__3_dose_schedule_.Value;

	private CqlValueSet Hib_Vaccine__3_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", null);

    [CqlDeclaration("Hib Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084")]
	public CqlValueSet Hib_Vaccine__3_dose_schedule__Administered() => 
		__Hib_Vaccine__3_dose_schedule__Administered.Value;

	private CqlValueSet Hib_Vaccine__4_dose_schedule__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", null);

    [CqlDeclaration("Hib Vaccine (4 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085")]
	public CqlValueSet Hib_Vaccine__4_dose_schedule_() => 
		__Hib_Vaccine__4_dose_schedule_.Value;

	private CqlValueSet Hib_Vaccine__4_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", null);

    [CqlDeclaration("Hib Vaccine (4 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086")]
	public CqlValueSet Hib_Vaccine__4_dose_schedule__Administered() => 
		__Hib_Vaccine__4_dose_schedule__Administered.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory.Value;

	private CqlValueSet Inactivated_Polio_Vaccine__IPV__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", null);

    [CqlDeclaration("Inactivated Polio Vaccine (IPV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219")]
	public CqlValueSet Inactivated_Polio_Vaccine__IPV_() => 
		__Inactivated_Polio_Vaccine__IPV_.Value;

	private CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", null);

    [CqlDeclaration("Inactivated Polio Vaccine (IPV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045")]
	public CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered() => 
		__Inactivated_Polio_Vaccine__IPV__Administered.Value;

	private CqlValueSet Child_Influenza_Immunization_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", null);

    [CqlDeclaration("Child Influenza Immunization Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218")]
	public CqlValueSet Child_Influenza_Immunization_Administered() => 
		__Child_Influenza_Immunization_Administered.Value;

	private CqlValueSet Child_Influenza_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", null);

    [CqlDeclaration("Child Influenza Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044")]
	public CqlValueSet Child_Influenza_Vaccine_Administered() => 
		__Child_Influenza_Vaccine_Administered.Value;

	private CqlValueSet Influenza_Virus_LAIV_Immunization_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", null);

    [CqlDeclaration("Influenza Virus LAIV Immunization")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087")]
	public CqlValueSet Influenza_Virus_LAIV_Immunization() => 
		__Influenza_Virus_LAIV_Immunization.Value;

	private CqlValueSet Influenza_Virus_LAIV_Procedure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", null);

    [CqlDeclaration("Influenza Virus LAIV Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088")]
	public CqlValueSet Influenza_Virus_LAIV_Procedure() => 
		__Influenza_Virus_LAIV_Procedure.Value;

	private CqlValueSet Intussusception_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", null);

    [CqlDeclaration("Intussusception")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056")]
	public CqlValueSet Intussusception() => 
		__Intussusception.Value;

	private CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", null);

    [CqlDeclaration("Malignant Neoplasm of Lymphatic and Hematopoietic Tissue")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009")]
	public CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue() => 
		__Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue.Value;

	private CqlValueSet Measles_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", null);

    [CqlDeclaration("Measles")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053")]
	public CqlValueSet Measles() => 
		__Measles.Value;

	private CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", null);

    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224")]
	public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine() => 
		__Measles__Mumps_and_Rubella__MMR__Vaccine.Value;

	private CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", null);

    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031")]
	public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered() => 
		__Measles__Mumps_and_Rubella__MMR__Vaccine_Administered.Value;

	private CqlValueSet Mumps_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", null);

    [CqlDeclaration("Mumps")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032")]
	public CqlValueSet Mumps() => 
		__Mumps.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Pneumococcal_Conjugate_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", null);

    [CqlDeclaration("Pneumococcal Conjugate Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221")]
	public CqlValueSet Pneumococcal_Conjugate_Vaccine() => 
		__Pneumococcal_Conjugate_Vaccine.Value;

	private CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", null);

    [CqlDeclaration("Pneumococcal Conjugate Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046")]
	public CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered() => 
		__Pneumococcal_Conjugate_Vaccine_Administered.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", null);

    [CqlDeclaration("Rotavirus Vaccine (2 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048")]
	public CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered() => 
		__Rotavirus_Vaccine__2_dose_schedule__Administered.Value;

	private CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", null);

    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223")]
	public CqlValueSet Rotavirus_Vaccine__3_dose_schedule_() => 
		__Rotavirus_Vaccine__3_dose_schedule_.Value;

	private CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", null);

    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047")]
	public CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered() => 
		__Rotavirus_Vaccine__3_dose_schedule__Administered.Value;

	private CqlValueSet Rubella_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", null);

    [CqlDeclaration("Rubella")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037")]
	public CqlValueSet Rubella() => 
		__Rubella.Value;

	private CqlValueSet Severe_Combined_Immunodeficiency_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", null);

    [CqlDeclaration("Severe Combined Immunodeficiency")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007")]
	public CqlValueSet Severe_Combined_Immunodeficiency() => 
		__Severe_Combined_Immunodeficiency.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Varicella_Zoster_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", null);

    [CqlDeclaration("Varicella Zoster")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039")]
	public CqlValueSet Varicella_Zoster() => 
		__Varicella_Zoster.Value;

	private CqlValueSet Varicella_Zoster_Vaccine__VZV__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", null);

    [CqlDeclaration("Varicella Zoster Vaccine (VZV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170")]
	public CqlValueSet Varicella_Zoster_Vaccine__VZV_() => 
		__Varicella_Zoster_Vaccine__VZV_.Value;

	private CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", null);

    [CqlDeclaration("Varicella Zoster Vaccine (VZV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040")]
	public CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered() => 
		__Varicella_Zoster_Vaccine__VZV__Administered.Value;

	private CqlCode Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder__Value() => 
		new CqlCode("433621000124101", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis due to Haemophilus influenzae type b vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_() => 
		__Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_.Value;

	private CqlCode Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder__Value() => 
		new CqlCode("428321000124101", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis due to Hepatitis B vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_() => 
		__Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_.Value;

	private CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder__Value() => 
		new CqlCode("428331000124103", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis due to rotavirus vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder_() => 
		__Anaphylaxis_due_to_rotavirus_vaccine__disorder_.Value;

	private CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional_Value() => 
		new CqlCode("99211", "http://www.ama-assn.org/go/cpt", null, null);

    [CqlDeclaration("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional")]
	public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional() => 
		__Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional.Value;

	private CqlCode rotavirus__live__monovalent_vaccine_Value() => 
		new CqlCode("119", "http://hl7.org/fhir/sid/cvx", null, null);

    [CqlDeclaration("rotavirus, live, monovalent vaccine")]
	public CqlCode rotavirus__live__monovalent_vaccine() => 
		__rotavirus__live__monovalent_vaccine.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder__Value() => 
		new CqlCode("471311000124103", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_.Value;

	private CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach_Value() => 
		new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", null, null);

    [CqlDeclaration("Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach")]
	public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach() => 
		__Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder__Value() => 
		new CqlCode("471361000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder__Value() => 
		new CqlCode("471331000124109", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder__Value() => 
		new CqlCode("471141000124102", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder__Value() => 
		new CqlCode("471321000124106", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder__Value() => 
		new CqlCode("471341000124104", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("433621000124101", "http://snomed.info/sct", null, null),
			new CqlCode("428321000124101", "http://snomed.info/sct", null, null),
			new CqlCode("428331000124103", "http://snomed.info/sct", null, null),
			new CqlCode("471311000124103", "http://snomed.info/sct", null, null),
			new CqlCode("471361000124100", "http://snomed.info/sct", null, null),
			new CqlCode("471331000124109", "http://snomed.info/sct", null, null),
			new CqlCode("471141000124102", "http://snomed.info/sct", null, null),
			new CqlCode("471321000124106", "http://snomed.info/sct", null, null),
			new CqlCode("471341000124104", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] CPT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("99211", "http://www.ama-assn.org/go/cpt", null, null),
		};

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlCode[] CVX_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("119", "http://hl7.org/fhir/sid/cvx", null, null),
		};

		return a_;
	}

    [CqlDeclaration("CVX")]
	public CqlCode[] CVX() => 
		__CVX.Value;

	private CqlCode[] ICD10_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD10")]
	public CqlCode[] ICD10() => 
		__ICD10.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Home_Healthcare_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = context.Operators.RetrieveByValueSet<Encounter>(null, null);
		bool? m_(Encounter E)
		{
			CqlConcept y_(CodeableConcept @this)
			{
				var ad_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ad_;
			};
			var z_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(E?.Type, y_);
			bool? aa_(CqlConcept T)
			{
				var ae_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional();
				var af_ = context.Operators.ConvertCodeToConcept(ae_);
				var ag_ = context.Operators.Equivalent(T, af_);

				return ag_;
			};
			var ab_ = context.Operators.WhereOrNull<CqlConcept>(z_, aa_);
			var ac_ = context.Operators.ExistsInList<CqlConcept>(ab_);

			return ac_;
		};
		var n_ = context.Operators.WhereOrNull<Encounter>(l_, m_);
		var o_ = this.Online_Assessments();
		var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
		var q_ = context.Operators.ListUnion<Encounter>(n_, p_);
		var r_ = context.Operators.ListUnion<Encounter>(k_, q_);
		var s_ = this.Telephone_Visits();
		var t_ = context.Operators.RetrieveByValueSet<Encounter>(s_, null);
		var u_ = context.Operators.ListUnion<Encounter>(r_, t_);
		var v_ = Status_1_6_000.Finished_Encounter(u_);
		bool? w_(Encounter ValidEncounters)
		{
			var ah_ = this.Measurement_Period();
			var ai_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounters?.Period);
			var aj_ = QICoreCommon_2_0_000.ToInterval((ai_ as object));
			var ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, aj_, "day");

			return ak_;
		};
		var x_ = context.Operators.WhereOrNull<Encounter>(v_, w_);

		return x_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Equal(f_, (int?)2);
		var h_ = this.Qualifying_Encounters();
		var i_ = context.Operators.ExistsInList<Encounter>(h_);
		var j_ = context.Operators.And(g_, i_);

		return j_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private CqlDate Date_of_Second_Birthday_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.ConvertStringToDate(a_?.BirthDateElement?.Value);
		var c_ = context.Operators.Quantity(2m, "years");
		var d_ = context.Operators.Add(b_, c_);

		return d_;
	}

    [CqlDeclaration("Date of Second Birthday")]
	public CqlDate Date_of_Second_Birthday() => 
		__Date_of_Second_Birthday.Value;

	private CqlInterval<CqlDate> First_Two_Years_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.ConvertStringToDate(a_?.BirthDateElement?.Value);
		var c_ = context.Operators.ConvertDateToDateTime(b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = this.Date_of_Second_Birthday();
		var f_ = context.Operators.Interval(d_, e_, true, true);

		return f_;
	}

    [CqlDeclaration("First Two Years")]
	public CqlInterval<CqlDate> First_Two_Years() => 
		__First_Two_Years.Value;

	private bool? Has_Severe_Combined_Immunodeficiency_Value()
	{
		var a_ = this.Severe_Combined_Immunodeficiency();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition SevereImmuneDisorder)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(SevereImmuneDisorder);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
		var f_ = context.Operators.ExistsInList<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Severe Combined Immunodeficiency")]
	public bool? Has_Severe_Combined_Immunodeficiency() => 
		__Has_Severe_Combined_Immunodeficiency.Value;

	private bool? Has_Immunodeficiency_Value()
	{
		var a_ = this.Disorders_of_the_Immune_System();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition ImmuneDisorder)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(ImmuneDisorder);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
		var f_ = context.Operators.ExistsInList<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Immunodeficiency")]
	public bool? Has_Immunodeficiency() => 
		__Has_Immunodeficiency.Value;

	private bool? Has_HIV_Value()
	{
		var a_ = this.HIV();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition HIV)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HIV);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
		var f_ = context.Operators.ExistsInList<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has HIV")]
	public bool? Has_HIV() => 
		__Has_HIV.Value;

	private bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia_Value()
	{
		var a_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition LymphaticMalignantNeoplasm)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(LymphaticMalignantNeoplasm);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
		var f_ = context.Operators.ExistsInList<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
	public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia() => 
		__Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia.Value;

	private bool? Has_Intussusception_Value()
	{
		var a_ = this.Intussusception();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition IntussusceptionDisorder)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(IntussusceptionDisorder);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);
		var f_ = context.Operators.ExistsInList<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Intussusception")]
	public bool? Has_Intussusception() => 
		__Has_Intussusception.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Has_Severe_Combined_Immunodeficiency();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_Immunodeficiency();
		var e_ = context.Operators.Or(c_, d_);
		var f_ = this.Has_HIV();
		var g_ = context.Operators.Or(e_, f_);
		var h_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia();
		var i_ = context.Operators.Or(g_, h_);
		var j_ = this.Has_Intussusception();
		var k_ = context.Operators.Or(i_, j_);

		return k_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.ConvertStringToDate(a_?.BirthDateElement?.Value);
		var c_ = context.Operators.ConvertDateToDateTime(b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = context.Operators.Quantity(42m, "days");
		var f_ = context.Operators.Add(d_, e_);
		var g_ = this.Date_of_Second_Birthday();
		var h_ = context.Operators.Interval(f_, g_, true, true);

		return h_;
	}

    [CqlDeclaration("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
	public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old() => 
		__Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old.Value;

	private IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures_Value()
	{
		var a_ = this.DTaP_Vaccine();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization DTaPVaccination)
		{
			var p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(DTaPVaccination?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization DTaPVaccination)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(DTaPVaccination?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.DTaP_Vaccine_Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure DTaPProcedure)
		{
			var aa_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var ab_ = FHIRHelpers_4_3_000.ToValue(DTaPProcedure?.Performed);
			var ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			var ad_ = CQMCommon_2_0_000.ToDateInterval(ac_);
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDate>(aa_, ad_, "day");

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure DTaPProcedure)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(DTaPProcedure?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.ConvertDateToDateTime(ai_);
			var ak_ = context.Operators.DateFrom(aj_);

			return ak_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("DTaP Immunizations or Procedures")]
	public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures() => 
		__DTaP_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Four_DTaP_Vaccinations_Value()
	{
		var a_ = this.DTaP_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_(CqlDate _DTaPVaccination1)
		{
			var o_ = this.DTaP_Immunizations_or_Procedures();

			return o_;
		};
		Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS c_(CqlDate _DTaPVaccination1, CqlDate _DTaPVaccination2)
		{
			var p_ = new Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS
			{
				DTaPVaccination1 = _DTaPVaccination1,
				DTaPVaccination2 = _DTaPVaccination2,
			};

			return p_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS _DTaPVaccination1DTaPVaccination2)
		{
			var q_ = this.DTaP_Immunizations_or_Procedures();

			return q_;
		};
		Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS f_(Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS DTaPVaccination1DTaPVaccination2, CqlDate _DTaPVaccination3)
		{
			var r_ = new Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS
			{
				DTaPVaccination1 = DTaPVaccination1DTaPVaccination2.DTaPVaccination1,
				DTaPVaccination2 = DTaPVaccination1DTaPVaccination2.DTaPVaccination2,
				DTaPVaccination3 = _DTaPVaccination3,
			};

			return r_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS, CqlDate, Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS>(d_, e_, f_);
		IEnumerable<CqlDate> h_(Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS _DTaPVaccination1DTaPVaccination2DTaPVaccination3)
		{
			var s_ = this.DTaP_Immunizations_or_Procedures();

			return s_;
		};
		Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS i_(Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS DTaPVaccination1DTaPVaccination2DTaPVaccination3, CqlDate _DTaPVaccination4)
		{
			var t_ = new Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS
			{
				DTaPVaccination1 = DTaPVaccination1DTaPVaccination2DTaPVaccination3.DTaPVaccination1,
				DTaPVaccination2 = DTaPVaccination1DTaPVaccination2DTaPVaccination3.DTaPVaccination2,
				DTaPVaccination3 = DTaPVaccination1DTaPVaccination2DTaPVaccination3.DTaPVaccination3,
				DTaPVaccination4 = _DTaPVaccination4,
			};

			return t_;
		};
		var j_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS, CqlDate, Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS>(g_, h_, i_);
		bool? k_(Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS tuple_edfaenkghpzdhfzcdmcgebfcs)
		{
			var u_ = context.Operators.Quantity(1m, "day");
			var v_ = context.Operators.Add(tuple_edfaenkghpzdhfzcdmcgebfcs.DTaPVaccination1, u_);
			var w_ = context.Operators.SameOrAfter(tuple_edfaenkghpzdhfzcdmcgebfcs.DTaPVaccination2, v_, "day");
			var y_ = context.Operators.Add(tuple_edfaenkghpzdhfzcdmcgebfcs.DTaPVaccination2, u_);
			var z_ = context.Operators.SameOrAfter(tuple_edfaenkghpzdhfzcdmcgebfcs.DTaPVaccination3, y_, "day");
			var aa_ = context.Operators.And(w_, z_);
			var ac_ = context.Operators.Add(tuple_edfaenkghpzdhfzcdmcgebfcs.DTaPVaccination3, u_);
			var ad_ = context.Operators.SameOrAfter(tuple_edfaenkghpzdhfzcdmcgebfcs.DTaPVaccination4, ac_, "day");
			var ae_ = context.Operators.And(aa_, ad_);

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS>(j_, k_);
		CqlDate m_(Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS tuple_edfaenkghpzdhfzcdmcgebfcs) => 
			tuple_edfaenkghpzdhfzcdmcgebfcs.DTaPVaccination1;
		var n_ = context.Operators.SelectOrNull<Tuples.Tuple_EDFAENKgHPZdhfZCdMcGebfcS, CqlDate>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Four DTaP Vaccinations")]
	public IEnumerable<CqlDate> Four_DTaP_Vaccinations() => 
		__Four_DTaP_Vaccinations.Value;

	private IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		var e_ = context.Operators.ListUnion<Condition>(b_, d_);
		var f_ = Status_1_6_000.Active_Condition(e_);
		bool? g_(Condition DTaPConditions)
		{
			var i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(DTaPConditions);
			var j_ = context.Operators.Start(i_);
			var k_ = context.Operators.DateFrom(j_);
			var l_ = this.First_Two_Years();
			var m_ = context.Operators.ElementInInterval<CqlDate>(k_, l_, "day");

			return m_;
		};
		var h_ = context.Operators.WhereOrNull<Condition>(f_, g_);

		return h_;
	}

    [CqlDeclaration("DTaP Numerator Inclusion Conditions")]
	public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions() => 
		__DTaP_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Polio_Immunizations_or_Procedures_Value()
	{
		var a_ = this.Inactivated_Polio_Vaccine__IPV_();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization PolioVaccination)
		{
			var p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(PolioVaccination?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization PolioVaccination)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(PolioVaccination?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Inactivated_Polio_Vaccine__IPV__Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure PolioProcedure)
		{
			var aa_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var ab_ = FHIRHelpers_4_3_000.ToValue(PolioProcedure?.Performed);
			var ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			var ad_ = CQMCommon_2_0_000.ToDateInterval(ac_);
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDate>(aa_, ad_, "day");

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure PolioProcedure)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(PolioProcedure?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.ConvertDateToDateTime(ai_);
			var ak_ = context.Operators.DateFrom(aj_);

			return ak_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Polio Immunizations or Procedures")]
	public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures() => 
		__Polio_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Three_Polio_Vaccinations_Value()
	{
		var a_ = this.Polio_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_(CqlDate _PolioVaccination1)
		{
			var l_ = this.Polio_Immunizations_or_Procedures();

			return l_;
		};
		Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS c_(CqlDate _PolioVaccination1, CqlDate _PolioVaccination2)
		{
			var m_ = new Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS
			{
				PolioVaccination1 = _PolioVaccination1,
				PolioVaccination2 = _PolioVaccination2,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS _PolioVaccination1PolioVaccination2)
		{
			var n_ = this.Polio_Immunizations_or_Procedures();

			return n_;
		};
		Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS f_(Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS PolioVaccination1PolioVaccination2, CqlDate _PolioVaccination3)
		{
			var o_ = new Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS
			{
				PolioVaccination1 = PolioVaccination1PolioVaccination2.PolioVaccination1,
				PolioVaccination2 = PolioVaccination1PolioVaccination2.PolioVaccination2,
				PolioVaccination3 = _PolioVaccination3,
			};

			return o_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS, CqlDate, Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS>(d_, e_, f_);
		bool? h_(Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS tuple_goxkbgtpjadgqhxfdgxgtmijs)
		{
			var p_ = context.Operators.Quantity(1m, "day");
			var q_ = context.Operators.Add(tuple_goxkbgtpjadgqhxfdgxgtmijs.PolioVaccination1, p_);
			var r_ = context.Operators.SameOrAfter(tuple_goxkbgtpjadgqhxfdgxgtmijs.PolioVaccination2, q_, "day");
			var t_ = context.Operators.Add(tuple_goxkbgtpjadgqhxfdgxgtmijs.PolioVaccination2, p_);
			var u_ = context.Operators.SameOrAfter(tuple_goxkbgtpjadgqhxfdgxgtmijs.PolioVaccination3, t_, "day");
			var v_ = context.Operators.And(r_, u_);

			return v_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS>(g_, h_);
		CqlDate j_(Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS tuple_goxkbgtpjadgqhxfdgxgtmijs) => 
			tuple_goxkbgtpjadgqhxfdgxgtmijs.PolioVaccination1;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_GOXKBgTPjADgQhXfdgXgTMIJS, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Three Polio Vaccinations")]
	public IEnumerable<CqlDate> Three_Polio_Vaccinations() => 
		__Three_Polio_Vaccinations.Value;

	private IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		var d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition PolioConditions)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(PolioConditions);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Polio Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions() => 
		__Polio_Numerator_Inclusion_Conditions.Value;

	private CqlDate Date_of_First_Birthday_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.ConvertStringToDate(a_?.BirthDateElement?.Value);
		var c_ = context.Operators.ConvertDateToDateTime(b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = context.Operators.Quantity(1m, "year");
		var f_ = context.Operators.Add(d_, e_);

		return f_;
	}

    [CqlDeclaration("Date of First Birthday")]
	public CqlDate Date_of_First_Birthday() => 
		__Date_of_First_Birthday.Value;

	private CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday_Value()
	{
		var a_ = this.Date_of_First_Birthday();
		var b_ = this.Date_of_Second_Birthday();
		var c_ = context.Operators.Interval(a_, b_, true, true);

		return c_;
	}

    [CqlDeclaration("Date of First Birthday to Date of Second Birthday")]
	public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday() => 
		__Date_of_First_Birthday_to_Date_of_Second_Birthday.Value;

	private IEnumerable<object> One_MMR_Vaccination_Value()
	{
		var a_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization MMRVaccination)
		{
			var l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			var m_ = context.Operators.LateBoundProperty<CqlDateTime>(MMRVaccination?.Occurrence, "value");
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = CQMCommon_2_0_000.ToDateInterval(n_);
			var p_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, o_, null);

			return p_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		var f_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered();
		var g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, null);
		var h_ = Status_1_6_000.Completed_Procedure(g_);
		bool? i_(Procedure MMRProcedure)
		{
			var q_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			var r_ = FHIRHelpers_4_3_000.ToValue(MMRProcedure?.Performed);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			var u_ = context.Operators.IntervalIncludesInterval<CqlDate>(q_, t_, null);

			return u_;
		};
		var j_ = context.Operators.WhereOrNull<Procedure>(h_, i_);
		var k_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (j_ as IEnumerable<object>));

		return k_;
	}

    [CqlDeclaration("One MMR Vaccination")]
	public IEnumerable<object> One_MMR_Vaccination() => 
		__One_MMR_Vaccination.Value;

	private IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		var d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition MMRConditions)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(MMRConditions);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("MMR Numerator Inclusion Conditions")]
	public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions() => 
		__MMR_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<Condition> Measles_Indicators_Value()
	{
		var a_ = this.Measles();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition MeaslesDiagnosis)
		{
			var f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(MeaslesDiagnosis);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = this.First_Two_Years();
			var j_ = context.Operators.ElementInInterval<CqlDate>(h_, i_, "day");

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Measles Indicators")]
	public IEnumerable<Condition> Measles_Indicators() => 
		__Measles_Indicators.Value;

	private IEnumerable<Condition> Mumps_Indicators_Value()
	{
		var a_ = this.Mumps();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition MumpsDiagnosis)
		{
			var f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(MumpsDiagnosis);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = this.First_Two_Years();
			var j_ = context.Operators.ElementInInterval<CqlDate>(h_, i_, "day");

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Mumps Indicators")]
	public IEnumerable<Condition> Mumps_Indicators() => 
		__Mumps_Indicators.Value;

	private IEnumerable<Condition> Rubella_Indicators_Value()
	{
		var a_ = this.Rubella();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition RubellaDiagnosis)
		{
			var f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(RubellaDiagnosis);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = this.First_Two_Years();
			var j_ = context.Operators.ElementInInterval<CqlDate>(h_, i_, "day");

			return j_;
		};
		var e_ = context.Operators.WhereOrNull<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Rubella Indicators")]
	public IEnumerable<Condition> Rubella_Indicators() => 
		__Rubella_Indicators.Value;

	private IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures_Value()
	{
		var a_ = this.Hib_Vaccine__3_dose_schedule_();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization ThreeDoseHibVaccine)
		{
			var p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(ThreeDoseHibVaccine?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization ThreeDoseHibVaccine)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(ThreeDoseHibVaccine?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Hib_Vaccine__3_dose_schedule__Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure ThreeDoseHibProcedure)
		{
			var aa_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var ab_ = FHIRHelpers_4_3_000.ToValue(ThreeDoseHibProcedure?.Performed);
			var ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			var ad_ = CQMCommon_2_0_000.ToDateInterval(ac_);
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDate>(aa_, ad_, "day");

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure ThreeDoseHibProcedure)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(ThreeDoseHibProcedure?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.ConvertDateToDateTime(ai_);
			var ak_ = context.Operators.DateFrom(aj_);

			return ak_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Hib 3 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures() => 
		__Hib_3_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures_Value()
	{
		var a_ = this.Hib_Vaccine__4_dose_schedule_();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization HibVaccine)
		{
			var p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(HibVaccine?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization HibVaccine)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(HibVaccine?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Hib_Vaccine__4_dose_schedule__Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure HibProcedure)
		{
			var aa_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var ab_ = FHIRHelpers_4_3_000.ToValue(HibProcedure?.Performed);
			var ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			var ad_ = CQMCommon_2_0_000.ToDateInterval(ac_);
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDate>(aa_, ad_, "day");

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure HibProcedure)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(HibProcedure?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.ConvertDateToDateTime(ai_);
			var ak_ = context.Operators.DateFrom(aj_);

			return ak_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Hib 4 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures() => 
		__Hib_4_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations_Value()
	{
		var a_ = this.Hib_3_Dose_Immunizations_or_Procedures();
		var b_ = this.Hib_4_Dose_Immunizations_or_Procedures();
		var c_ = context.Operators.ListUnion<CqlDate>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Hib 3 or 4 Dose Immunizations")]
	public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations() => 
		__Hib_3_or_4_Dose_Immunizations.Value;

	private IEnumerable<CqlDate> All_Hib_Vaccinations_Value()
	{
		var a_ = this.Hib_3_or_4_Dose_Immunizations();
		IEnumerable<CqlDate> c_(CqlDate AllHibDoses1)
		{
			var f_ = this.Hib_3_or_4_Dose_Immunizations();
			bool? g_(CqlDate AllHibDoses2)
			{
				var k_ = context.Operators.Quantity(1m, "day");
				var l_ = context.Operators.Subtract(AllHibDoses2, k_);
				var m_ = context.Operators.Interval(l_, AllHibDoses2, false, false);
				var n_ = context.Operators.ElementInInterval<CqlDate>(AllHibDoses1, m_, null);

				return n_;
			};
			var h_ = context.Operators.WhereOrNull<CqlDate>(f_, g_);
			CqlDate i_(CqlDate AllHibDoses2) => 
				AllHibDoses1;
			var j_ = context.Operators.SelectOrNull<CqlDate, CqlDate>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectManyOrNull<CqlDate, CqlDate>(a_, c_);
		var e_ = context.Operators.ListExcept<CqlDate>(a_, d_);

		return e_;
	}

    [CqlDeclaration("All Hib Vaccinations")]
	public IEnumerable<CqlDate> All_Hib_Vaccinations() => 
		__All_Hib_Vaccinations.Value;

	private bool? Has_Appropriate_Number_of_Hib_Immunizations_Value()
	{
		var a_ = this.All_Hib_Vaccinations();
		bool? b_(CqlDate HibImmunization)
		{
			var e_ = this.Hib_4_Dose_Immunizations_or_Procedures();
			var f_ = context.Operators.CountOrNull<CqlDate>(e_);
			var g_ = context.Operators.Greater(f_, (int?)0);
			var h_ = this.All_Hib_Vaccinations();
			CqlDate i_(CqlDate HibVaccinations) => 
				HibVaccinations;
			var j_ = context.Operators.SelectOrNull<CqlDate, CqlDate>(h_, i_);
			var k_ = context.Operators.ListDistinct<CqlDate>(j_);
			var l_ = context.Operators.CountOrNull<CqlDate>(k_);
			var m_ = context.Operators.GreaterOrEqual(l_, (int?)4);
			var n_ = context.Operators.And(g_, m_);
			var p_ = context.Operators.CountOrNull<CqlDate>(e_);
			var q_ = context.Operators.Greater(p_, (int?)0);
			var r_ = context.Operators.IsFalse(q_);
			var u_ = context.Operators.SelectOrNull<CqlDate, CqlDate>(h_, i_);
			var v_ = context.Operators.ListDistinct<CqlDate>(u_);
			var w_ = context.Operators.CountOrNull<CqlDate>(v_);
			var x_ = context.Operators.GreaterOrEqual(w_, (int?)3);
			var y_ = context.Operators.And(r_, x_);
			var z_ = context.Operators.Or(n_, y_);

			return z_;
		};
		var c_ = context.Operators.WhereOrNull<CqlDate>(a_, b_);
		var d_ = context.Operators.ExistsInList<CqlDate>(c_);

		return d_;
	}

    [CqlDeclaration("Has Appropriate Number of Hib Immunizations")]
	public bool? Has_Appropriate_Number_of_Hib_Immunizations() => 
		__Has_Appropriate_Number_of_Hib_Immunizations.Value;

	private IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		var d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition HibReaction)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HibReaction);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Hib Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions() => 
		__Hib_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures_Value()
	{
		var a_ = this.Hepatitis_B_Vaccine();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization HepatitisBVaccination)
		{
			var p_ = this.First_Two_Years();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(HepatitisBVaccination?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization HepatitisBVaccination)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(HepatitisBVaccination?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Hepatitis_B_Vaccine_Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure HepatitisBProcedure)
		{
			var aa_ = this.First_Two_Years();
			var ab_ = FHIRHelpers_4_3_000.ToValue(HepatitisBProcedure?.Performed);
			var ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			var ad_ = CQMCommon_2_0_000.ToDateInterval(ac_);
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDate>(aa_, ad_, "day");

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure HepatitisBProcedure)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(HepatitisBProcedure?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.ConvertDateToDateTime(ai_);
			var ak_ = context.Operators.DateFrom(aj_);

			return ak_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Hepatitis B Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures() => 
		__Hepatitis_B_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations_Value()
	{
		var a_ = this.Hepatitis_B_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_(CqlDate _HepatitisBVaccination1)
		{
			var l_ = this.Hepatitis_B_Immunizations_or_Procedures();

			return l_;
		};
		Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg c_(CqlDate _HepatitisBVaccination1, CqlDate _HepatitisBVaccination2)
		{
			var m_ = new Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg
			{
				HepatitisBVaccination1 = _HepatitisBVaccination1,
				HepatitisBVaccination2 = _HepatitisBVaccination2,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg _HepatitisBVaccination1HepatitisBVaccination2)
		{
			var n_ = this.Hepatitis_B_Immunizations_or_Procedures();

			return n_;
		};
		Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg f_(Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg HepatitisBVaccination1HepatitisBVaccination2, CqlDate _HepatitisBVaccination3)
		{
			var o_ = new Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg
			{
				HepatitisBVaccination1 = HepatitisBVaccination1HepatitisBVaccination2.HepatitisBVaccination1,
				HepatitisBVaccination2 = HepatitisBVaccination1HepatitisBVaccination2.HepatitisBVaccination2,
				HepatitisBVaccination3 = _HepatitisBVaccination3,
			};

			return o_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg, CqlDate, Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg>(d_, e_, f_);
		bool? h_(Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg tuple_bgioadwjfavaafwakdfwjcfog)
		{
			var p_ = context.Operators.Quantity(1m, "day");
			var q_ = context.Operators.Add(tuple_bgioadwjfavaafwakdfwjcfog.HepatitisBVaccination1, p_);
			var r_ = context.Operators.SameOrAfter(tuple_bgioadwjfavaafwakdfwjcfog.HepatitisBVaccination2, q_, "day");
			var t_ = context.Operators.Add(tuple_bgioadwjfavaafwakdfwjcfog.HepatitisBVaccination2, p_);
			var u_ = context.Operators.SameOrAfter(tuple_bgioadwjfavaafwakdfwjcfog.HepatitisBVaccination3, t_, "day");
			var v_ = context.Operators.And(r_, u_);

			return v_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg>(g_, h_);
		CqlDate j_(Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg tuple_bgioadwjfavaafwakdfwjcfog) => 
			tuple_bgioadwjfavaafwakdfwjcfog.HepatitisBVaccination1;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_BGiOaDWjFAVaAFWAKdFWJcFOg, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Three Hepatitis B Vaccinations")]
	public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations() => 
		__Three_Hepatitis_B_Vaccinations.Value;

	private IEnumerable<CqlDate> NewBorn_Vaccine_Requirement_Value()
	{
		var a_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Procedure>(b_, null);
		var d_ = Status_1_6_000.Completed_Procedure(c_);
		bool? e_(Procedure NewBornVaccine)
		{
			var i_ = this.Patient();
			var j_ = context.Operators.ConvertStringToDate(i_?.BirthDateElement?.Value);
			var k_ = context.Operators.ConvertDateToDateTime(j_);
			var l_ = context.Operators.DateFrom(k_);
			var n_ = context.Operators.ConvertStringToDate(i_?.BirthDateElement?.Value);
			var o_ = context.Operators.ConvertDateToDateTime(n_);
			var p_ = context.Operators.DateFrom(o_);
			var q_ = context.Operators.Quantity(7m, "days");
			var r_ = context.Operators.Add(p_, q_);
			var s_ = context.Operators.Interval(l_, r_, true, true);
			var t_ = FHIRHelpers_4_3_000.ToValue(NewBornVaccine?.Performed);
			var u_ = QICoreCommon_2_0_000.ToInterval(t_);
			var v_ = CQMCommon_2_0_000.ToDateInterval(u_);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDate>(s_, v_, "day");

			return w_;
		};
		var f_ = context.Operators.WhereOrNull<Procedure>(d_, e_);
		CqlDate g_(Procedure NewBornVaccine)
		{
			var x_ = FHIRHelpers_4_3_000.ToValue(NewBornVaccine?.Performed);
			var y_ = QICoreCommon_2_0_000.ToInterval(x_);
			var z_ = context.Operators.Start(y_);
			var aa_ = context.Operators.DateFrom(z_);

			return aa_;
		};
		var h_ = context.Operators.SelectOrNull<Procedure, CqlDate>(f_, g_);

		return h_;
	}

    [CqlDeclaration("NewBorn Vaccine Requirement")]
	public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement() => 
		__NewBorn_Vaccine_Requirement.Value;

	private IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement_Value()
	{
		var a_ = this.Hepatitis_B_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_(CqlDate _HepatitisBVaccination1)
		{
			var l_ = this.Hepatitis_B_Immunizations_or_Procedures();

			return l_;
		};
		Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH c_(CqlDate _HepatitisBVaccination1, CqlDate _HepatitisBVaccination2)
		{
			var m_ = new Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH
			{
				HepatitisBVaccination1 = _HepatitisBVaccination1,
				HepatitisBVaccination2 = _HepatitisBVaccination2,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH _HepatitisBVaccination1HepatitisBVaccination2)
		{
			var n_ = this.NewBorn_Vaccine_Requirement();

			return n_;
		};
		Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH f_(Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH HepatitisBVaccination1HepatitisBVaccination2, CqlDate _NewBornVaccine3)
		{
			var o_ = new Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH
			{
				HepatitisBVaccination1 = HepatitisBVaccination1HepatitisBVaccination2.HepatitisBVaccination1,
				HepatitisBVaccination2 = HepatitisBVaccination1HepatitisBVaccination2.HepatitisBVaccination2,
				NewBornVaccine3 = _NewBornVaccine3,
			};

			return o_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH, CqlDate, Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH>(d_, e_, f_);
		bool? h_(Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH tuple_bbghrjamveqthbctrucdhsbqh)
		{
			var p_ = context.Operators.Quantity(1m, "day");
			var q_ = context.Operators.Add(tuple_bbghrjamveqthbctrucdhsbqh.HepatitisBVaccination1, p_);
			var r_ = context.Operators.SameOrAfter(tuple_bbghrjamveqthbctrucdhsbqh.HepatitisBVaccination2, q_, "day");
			var t_ = context.Operators.Add(tuple_bbghrjamveqthbctrucdhsbqh.NewBornVaccine3, p_);
			var u_ = context.Operators.SameOrAfter(tuple_bbghrjamveqthbctrucdhsbqh.HepatitisBVaccination1, t_, "day");
			var v_ = context.Operators.And(r_, u_);
			var x_ = context.Operators.Add(tuple_bbghrjamveqthbctrucdhsbqh.NewBornVaccine3, p_);
			var y_ = context.Operators.SameOrAfter(tuple_bbghrjamveqthbctrucdhsbqh.HepatitisBVaccination2, x_, "day");
			var z_ = context.Operators.And(v_, y_);

			return z_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH>(g_, h_);
		CqlDate j_(Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH tuple_bbghrjamveqthbctrucdhsbqh) => 
			tuple_bbghrjamveqthbctrucdhsbqh.HepatitisBVaccination1;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_BbghRjaMVeQThBCTRUcdHSBQH, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Meets HepB Vaccination Requirement")]
	public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement() => 
		__Meets_HepB_Vaccination_Requirement.Value;

	private IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		var d_ = this.Hepatitis_B();
		var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
		var f_ = context.Operators.ListUnion<Condition>(c_, e_);
		var g_ = Status_1_6_000.Active_Condition(f_);
		bool? h_(Condition HepBConditions)
		{
			var j_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HepBConditions);
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = this.First_Two_Years();
			var n_ = context.Operators.ElementInInterval<CqlDate>(l_, m_, "day");

			return n_;
		};
		var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Hepatitis B Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions() => 
		__Hepatitis_B_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<object> One_Chicken_Pox_Vaccination_Value()
	{
		var a_ = this.Varicella_Zoster_Vaccine__VZV_();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization ChickenPoxVaccination)
		{
			var l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			var m_ = context.Operators.LateBoundProperty<CqlDateTime>(ChickenPoxVaccination?.Occurrence, "value");
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = CQMCommon_2_0_000.ToDateInterval(n_);
			var p_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, o_, null);

			return p_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		var f_ = this.Varicella_Zoster_Vaccine__VZV__Administered();
		var g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, null);
		var h_ = Status_1_6_000.Completed_Procedure(g_);
		bool? i_(Procedure ChickenPoxProcedure)
		{
			var q_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			var r_ = FHIRHelpers_4_3_000.ToValue(ChickenPoxProcedure?.Performed);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			var u_ = context.Operators.IntervalIncludesInterval<CqlDate>(q_, t_, null);

			return u_;
		};
		var j_ = context.Operators.WhereOrNull<Procedure>(h_, i_);
		var k_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (j_ as IEnumerable<object>));

		return k_;
	}

    [CqlDeclaration("One Chicken Pox Vaccination")]
	public IEnumerable<object> One_Chicken_Pox_Vaccination() => 
		__One_Chicken_Pox_Vaccination.Value;

	private IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Varicella_Zoster();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_();
		var d_ = context.Operators.ToList<CqlCode>(c_);
		var e_ = context.Operators.RetrieveByCodes<Condition>(d_, null);
		var f_ = context.Operators.ListUnion<Condition>(b_, e_);
		var g_ = Status_1_6_000.Active_Condition(f_);
		bool? h_(Condition VaricellaZoster)
		{
			var j_ = QICoreCommon_2_0_000.ToPrevalenceInterval(VaricellaZoster);
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = this.First_Two_Years();
			var n_ = context.Operators.ElementInInterval<CqlDate>(l_, m_, "day");

			return n_;
		};
		var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Varicella Zoster Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions() => 
		__Varicella_Zoster_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures_Value()
	{
		var a_ = this.Pneumococcal_Conjugate_Vaccine();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization PneumococcalVaccination)
		{
			var p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(PneumococcalVaccination?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization PneumococcalVaccination)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(PneumococcalVaccination?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Pneumococcal_Conjugate_Vaccine_Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure PneumococcalProcedure)
		{
			var aa_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var ab_ = FHIRHelpers_4_3_000.ToValue(PneumococcalProcedure?.Performed);
			var ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			var ad_ = CQMCommon_2_0_000.ToDateInterval(ac_);
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDate>(aa_, ad_, "day");

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure PneumococcalProcedure)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(PneumococcalProcedure?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.ConvertDateToDateTime(ai_);
			var ak_ = context.Operators.DateFrom(aj_);

			return ak_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Pneumococcal Conjugate Immunizations or Procedures")]
	public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures() => 
		__Pneumococcal_Conjugate_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations_Value()
	{
		var a_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_(CqlDate _PneumococcalVaccination1)
		{
			var o_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures();

			return o_;
		};
		Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh c_(CqlDate _PneumococcalVaccination1, CqlDate _PneumococcalVaccination2)
		{
			var p_ = new Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh
			{
				PneumococcalVaccination1 = _PneumococcalVaccination1,
				PneumococcalVaccination2 = _PneumococcalVaccination2,
			};

			return p_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh>(a_, b_, c_);
		IEnumerable<CqlDate> e_(Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh _PneumococcalVaccination1PneumococcalVaccination2)
		{
			var q_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures();

			return q_;
		};
		Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh f_(Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh PneumococcalVaccination1PneumococcalVaccination2, CqlDate _PneumococcalVaccination3)
		{
			var r_ = new Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh
			{
				PneumococcalVaccination1 = PneumococcalVaccination1PneumococcalVaccination2.PneumococcalVaccination1,
				PneumococcalVaccination2 = PneumococcalVaccination1PneumococcalVaccination2.PneumococcalVaccination2,
				PneumococcalVaccination3 = _PneumococcalVaccination3,
			};

			return r_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh, CqlDate, Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh>(d_, e_, f_);
		IEnumerable<CqlDate> h_(Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh _PneumococcalVaccination1PneumococcalVaccination2PneumococcalVaccination3)
		{
			var s_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures();

			return s_;
		};
		Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh i_(Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh PneumococcalVaccination1PneumococcalVaccination2PneumococcalVaccination3, CqlDate _PneumococcalVaccination4)
		{
			var t_ = new Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh
			{
				PneumococcalVaccination1 = PneumococcalVaccination1PneumococcalVaccination2PneumococcalVaccination3.PneumococcalVaccination1,
				PneumococcalVaccination2 = PneumococcalVaccination1PneumococcalVaccination2PneumococcalVaccination3.PneumococcalVaccination2,
				PneumococcalVaccination3 = PneumococcalVaccination1PneumococcalVaccination2PneumococcalVaccination3.PneumococcalVaccination3,
				PneumococcalVaccination4 = _PneumococcalVaccination4,
			};

			return t_;
		};
		var j_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh, CqlDate, Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh>(g_, h_, i_);
		bool? k_(Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh tuple_bvcgrhsdcrlnscbmjukidnajh)
		{
			var u_ = context.Operators.Quantity(1m, "day");
			var v_ = context.Operators.Add(tuple_bvcgrhsdcrlnscbmjukidnajh.PneumococcalVaccination1, u_);
			var w_ = context.Operators.SameOrAfter(tuple_bvcgrhsdcrlnscbmjukidnajh.PneumococcalVaccination2, v_, "day");
			var y_ = context.Operators.Add(tuple_bvcgrhsdcrlnscbmjukidnajh.PneumococcalVaccination2, u_);
			var z_ = context.Operators.SameOrAfter(tuple_bvcgrhsdcrlnscbmjukidnajh.PneumococcalVaccination3, y_, "day");
			var aa_ = context.Operators.And(w_, z_);
			var ac_ = context.Operators.Add(tuple_bvcgrhsdcrlnscbmjukidnajh.PneumococcalVaccination3, u_);
			var ad_ = context.Operators.SameOrAfter(tuple_bvcgrhsdcrlnscbmjukidnajh.PneumococcalVaccination4, ac_, "day");
			var ae_ = context.Operators.And(aa_, ad_);

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh>(j_, k_);
		CqlDate m_(Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh tuple_bvcgrhsdcrlnscbmjukidnajh) => 
			tuple_bvcgrhsdcrlnscbmjukidnajh.PneumococcalVaccination1;
		var n_ = context.Operators.SelectOrNull<Tuples.Tuple_BVCGRhSDCRLNScbMJUKidNAJh, CqlDate>(l_, m_);

		return n_;
	}

    [CqlDeclaration("Four Pneumococcal Conjugate Vaccinations")]
	public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations() => 
		__Four_Pneumococcal_Conjugate_Vaccinations.Value;

	private IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		var d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition PneumococcalReaction)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(PneumococcalReaction);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Pneumococcal Conjugate Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions() => 
		__Pneumococcal_Conjugate_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<object> One_Hepatitis_A_Vaccinations_Value()
	{
		var a_ = this.Hepatitis_A_Vaccine();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization HepatitisAVaccination)
		{
			var l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			var m_ = context.Operators.LateBoundProperty<CqlDateTime>(HepatitisAVaccination?.Occurrence, "value");
			var n_ = QICoreCommon_2_0_000.ToInterval((m_ as object));
			var o_ = CQMCommon_2_0_000.ToDateInterval(n_);
			var p_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, o_, null);

			return p_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		var f_ = this.Hepatitis_A_Vaccine_Administered();
		var g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, null);
		var h_ = Status_1_6_000.Completed_Procedure(g_);
		bool? i_(Procedure HepatitisAProcedure)
		{
			var q_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			var r_ = FHIRHelpers_4_3_000.ToValue(HepatitisAProcedure?.Performed);
			var s_ = QICoreCommon_2_0_000.ToInterval(r_);
			var t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			var u_ = context.Operators.IntervalIncludesInterval<CqlDate>(q_, t_, null);

			return u_;
		};
		var j_ = context.Operators.WhereOrNull<Procedure>(h_, i_);
		var k_ = context.Operators.ListUnion<object>((e_ as IEnumerable<object>), (j_ as IEnumerable<object>));

		return k_;
	}

    [CqlDeclaration("One Hepatitis A Vaccinations")]
	public IEnumerable<object> One_Hepatitis_A_Vaccinations() => 
		__One_Hepatitis_A_Vaccinations.Value;

	private IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Hepatitis_A();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_();
		var d_ = context.Operators.ToList<CqlCode>(c_);
		var e_ = context.Operators.RetrieveByCodes<Condition>(d_, null);
		var f_ = context.Operators.ListUnion<Condition>(b_, e_);
		var g_ = Status_1_6_000.Active_Condition(f_);
		bool? h_(Condition HepatitisADiagnosis)
		{
			var j_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HepatitisADiagnosis);
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = this.First_Two_Years();
			var n_ = context.Operators.ElementInInterval<CqlDate>(l_, m_, "day");

			return n_;
		};
		var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Hepatitis A Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions() => 
		__Hepatitis_A_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures_Value()
	{
		var a_ = this.rotavirus__live__monovalent_vaccine();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Immunization>(b_, null);
		var d_ = Status_1_6_000.Completed_Immunization(c_);
		bool? e_(Immunization TwoDoseRotavirusVaccine)
		{
			var q_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var r_ = context.Operators.LateBoundProperty<CqlDateTime>(TwoDoseRotavirusVaccine?.Occurrence, "value");
			var s_ = QICoreCommon_2_0_000.ToInterval((r_ as object));
			var t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			var u_ = context.Operators.IntervalIncludesInterval<CqlDate>(q_, t_, "day");

			return u_;
		};
		var f_ = context.Operators.WhereOrNull<Immunization>(d_, e_);
		CqlDate g_(Immunization TwoDoseRotavirusVaccine)
		{
			var v_ = context.Operators.LateBoundProperty<CqlDateTime>(TwoDoseRotavirusVaccine?.Occurrence, "value");
			var w_ = QICoreCommon_2_0_000.ToInterval((v_ as object));
			var x_ = CQMCommon_2_0_000.ToDateInterval(w_);
			var y_ = context.Operators.Start(x_);
			var z_ = context.Operators.ConvertDateToDateTime(y_);
			var aa_ = context.Operators.DateFrom(z_);

			return aa_;
		};
		var h_ = context.Operators.SelectOrNull<Immunization, CqlDate>(f_, g_);
		var i_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered();
		var j_ = context.Operators.RetrieveByValueSet<Procedure>(i_, null);
		var k_ = Status_1_6_000.Completed_Procedure(j_);
		bool? l_(Procedure TwoDoseRotavirusProcedure)
		{
			var ab_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var ac_ = FHIRHelpers_4_3_000.ToValue(TwoDoseRotavirusProcedure?.Performed);
			var ad_ = QICoreCommon_2_0_000.ToInterval(ac_);
			var ae_ = CQMCommon_2_0_000.ToDateInterval(ad_);
			var af_ = context.Operators.IntervalIncludesInterval<CqlDate>(ab_, ae_, "day");

			return af_;
		};
		var m_ = context.Operators.WhereOrNull<Procedure>(k_, l_);
		CqlDate n_(Procedure TwoDoseRotavirusProcedure)
		{
			var ag_ = FHIRHelpers_4_3_000.ToValue(TwoDoseRotavirusProcedure?.Performed);
			var ah_ = QICoreCommon_2_0_000.ToInterval(ag_);
			var ai_ = CQMCommon_2_0_000.ToDateInterval(ah_);
			var aj_ = context.Operators.Start(ai_);
			var ak_ = context.Operators.ConvertDateToDateTime(aj_);
			var al_ = context.Operators.DateFrom(ak_);

			return al_;
		};
		var o_ = context.Operators.SelectOrNull<Procedure, CqlDate>(m_, n_);
		var p_ = context.Operators.ListUnion<CqlDate>(h_, o_);

		return p_;
	}

    [CqlDeclaration("Rotavirus 2 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures() => 
		__Rotavirus_2_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures_Value()
	{
		var a_ = this.Rotavirus_Vaccine__3_dose_schedule_();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization ThreeDoseRotavirusVaccine)
		{
			var p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(ThreeDoseRotavirusVaccine?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization ThreeDoseRotavirusVaccine)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(ThreeDoseRotavirusVaccine?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure ThreeDoseRotavirusAdministered)
		{
			var aa_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var ab_ = FHIRHelpers_4_3_000.ToValue(ThreeDoseRotavirusAdministered?.Performed);
			var ac_ = QICoreCommon_2_0_000.ToInterval(ab_);
			var ad_ = CQMCommon_2_0_000.ToDateInterval(ac_);
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDate>(aa_, ad_, "day");

			return ae_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure ThreeDoseRotavirusAdministered)
		{
			var af_ = FHIRHelpers_4_3_000.ToValue(ThreeDoseRotavirusAdministered?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.ConvertDateToDateTime(ai_);
			var ak_ = context.Operators.DateFrom(aj_);

			return ak_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Rotavirus 3 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures() => 
		__Rotavirus_3_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations_Value()
	{
		var a_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures();
		var b_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures();
		var c_ = context.Operators.ListUnion<CqlDate>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Rotavirus 2 or 3 Dose Immunizations")]
	public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations() => 
		__Rotavirus_2_or_3_Dose_Immunizations.Value;

	private IEnumerable<CqlDate> All_Rotavirus_Vaccinations_Value()
	{
		var a_ = this.Rotavirus_2_or_3_Dose_Immunizations();
		IEnumerable<CqlDate> c_(CqlDate AllRotavirusDoses1)
		{
			var f_ = this.Rotavirus_2_or_3_Dose_Immunizations();
			bool? g_(CqlDate AllRotavirusDoses2)
			{
				var k_ = context.Operators.Quantity(1m, "day");
				var l_ = context.Operators.Subtract(AllRotavirusDoses2, k_);
				var m_ = context.Operators.Interval(l_, AllRotavirusDoses2, false, false);
				var n_ = context.Operators.ElementInInterval<CqlDate>(AllRotavirusDoses1, m_, null);

				return n_;
			};
			var h_ = context.Operators.WhereOrNull<CqlDate>(f_, g_);
			CqlDate i_(CqlDate AllRotavirusDoses2) => 
				AllRotavirusDoses1;
			var j_ = context.Operators.SelectOrNull<CqlDate, CqlDate>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectManyOrNull<CqlDate, CqlDate>(a_, c_);
		var e_ = context.Operators.ListExcept<CqlDate>(a_, d_);

		return e_;
	}

    [CqlDeclaration("All Rotavirus Vaccinations")]
	public IEnumerable<CqlDate> All_Rotavirus_Vaccinations() => 
		__All_Rotavirus_Vaccinations.Value;

	private bool? Has_Appropriate_Number_of_Rotavirus_Immunizations_Value()
	{
		var a_ = this.All_Rotavirus_Vaccinations();
		bool? b_(CqlDate RotavirusImmunization)
		{
			var e_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures();
			var f_ = context.Operators.CountOrNull<CqlDate>(e_);
			var g_ = context.Operators.Greater(f_, (int?)0);
			var h_ = this.All_Rotavirus_Vaccinations();
			CqlDate i_(CqlDate RotavirusVaccinations) => 
				RotavirusVaccinations;
			var j_ = context.Operators.SelectOrNull<CqlDate, CqlDate>(h_, i_);
			var k_ = context.Operators.ListDistinct<CqlDate>(j_);
			var l_ = context.Operators.CountOrNull<CqlDate>(k_);
			var m_ = context.Operators.GreaterOrEqual(l_, (int?)3);
			var n_ = context.Operators.And(g_, m_);
			var p_ = context.Operators.CountOrNull<CqlDate>(e_);
			var q_ = context.Operators.Greater(p_, (int?)0);
			var r_ = context.Operators.IsFalse(q_);
			var u_ = context.Operators.SelectOrNull<CqlDate, CqlDate>(h_, i_);
			var v_ = context.Operators.ListDistinct<CqlDate>(u_);
			var w_ = context.Operators.CountOrNull<CqlDate>(v_);
			var x_ = context.Operators.GreaterOrEqual(w_, (int?)2);
			var y_ = context.Operators.And(r_, x_);
			var z_ = context.Operators.Or(n_, y_);

			return z_;
		};
		var c_ = context.Operators.WhereOrNull<CqlDate>(a_, b_);
		var d_ = context.Operators.ExistsInList<CqlDate>(c_);

		return d_;
	}

    [CqlDeclaration("Has Appropriate Number of Rotavirus Immunizations")]
	public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations() => 
		__Has_Appropriate_Number_of_Rotavirus_Immunizations.Value;

	private IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		var d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition RotavirusConditions)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(RotavirusConditions);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Rotavirus Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions() => 
		__Rotavirus_Numerator_Inclusion_Conditions.Value;

	private CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.ConvertStringToDate(a_?.BirthDateElement?.Value);
		var c_ = context.Operators.ConvertDateToDateTime(b_);
		var d_ = context.Operators.DateFrom(c_);
		var e_ = context.Operators.Quantity(180m, "days");
		var f_ = context.Operators.Add(d_, e_);
		var g_ = this.Date_of_Second_Birthday();
		var h_ = context.Operators.Interval(f_, g_, true, true);

		return h_;
	}

    [CqlDeclaration("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
	public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old() => 
		__Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old.Value;

	private IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures_Value()
	{
		var a_ = this.Child_Influenza_Immunization_Administered();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization InfluenzaVaccine)
		{
			var p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			var q_ = context.Operators.LateBoundProperty<CqlDateTime>(InfluenzaVaccine?.Occurrence, "value");
			var r_ = QICoreCommon_2_0_000.ToInterval((q_ as object));
			var s_ = CQMCommon_2_0_000.ToDateInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, s_, "day");

			return t_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization InfluenzaVaccine)
		{
			var u_ = context.Operators.LateBoundProperty<CqlDateTime>(InfluenzaVaccine?.Occurrence, "value");
			var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
			var w_ = CQMCommon_2_0_000.ToDateInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = context.Operators.ConvertDateToDateTime(x_);
			var z_ = context.Operators.DateFrom(y_);

			return z_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Child_Influenza_Vaccine_Administered();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure InfluenzaAdministration)
		{
			var aa_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old();
			var ab_ = context.Operators.ConvertDateToDateTime(aa_?.low);
			var ad_ = context.Operators.ConvertDateToDateTime(aa_?.high);
			var ag_ = context.Operators.Interval(ab_, ad_, aa_?.lowClosed, aa_?.highClosed);
			var ah_ = FHIRHelpers_4_3_000.ToValue(InfluenzaAdministration?.Performed);
			var ai_ = QICoreCommon_2_0_000.ToInterval(ah_);
			var aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, ai_, "day");

			return aj_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure InfluenzaAdministration)
		{
			var ak_ = FHIRHelpers_4_3_000.ToValue(InfluenzaAdministration?.Performed);
			var al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			var am_ = CQMCommon_2_0_000.ToDateInterval(al_);
			var an_ = context.Operators.Start(am_);
			var ao_ = context.Operators.ConvertDateToDateTime(an_);
			var ap_ = context.Operators.DateFrom(ao_);

			return ap_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Influenza Immunizations or Procedures")]
	public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures() => 
		__Influenza_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Two_Influenza_Vaccinations_Value()
	{
		var a_ = this.Influenza_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_(CqlDate _FluVaccination1)
		{
			var i_ = this.Influenza_Immunizations_or_Procedures();

			return i_;
		};
		Tuples.Tuple_ESUAOONTBOMCFNSgVCeZOQUbj c_(CqlDate _FluVaccination1, CqlDate _FluVaccination2)
		{
			var j_ = new Tuples.Tuple_ESUAOONTBOMCFNSgVCeZOQUbj
			{
				FluVaccination1 = _FluVaccination1,
				FluVaccination2 = _FluVaccination2,
			};

			return j_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<CqlDate, CqlDate, Tuples.Tuple_ESUAOONTBOMCFNSgVCeZOQUbj>(a_, b_, c_);
		bool? e_(Tuples.Tuple_ESUAOONTBOMCFNSgVCeZOQUbj tuple_esuaoontbomcfnsgvcezoqubj)
		{
			var k_ = context.Operators.Quantity(1m, "day");
			var l_ = context.Operators.Add(tuple_esuaoontbomcfnsgvcezoqubj.FluVaccination1, k_);
			var m_ = context.Operators.SameOrAfter(tuple_esuaoontbomcfnsgvcezoqubj.FluVaccination2, l_, "day");

			return m_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_ESUAOONTBOMCFNSgVCeZOQUbj>(d_, e_);
		CqlDate g_(Tuples.Tuple_ESUAOONTBOMCFNSgVCeZOQUbj tuple_esuaoontbomcfnsgvcezoqubj) => 
			tuple_esuaoontbomcfnsgvcezoqubj.FluVaccination1;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_ESUAOONTBOMCFNSgVCeZOQUbj, CqlDate>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Two Influenza Vaccinations")]
	public IEnumerable<CqlDate> Two_Influenza_Vaccinations() => 
		__Two_Influenza_Vaccinations.Value;

	private IEnumerable<CqlDate> LAIV_Vaccinations_Value()
	{
		var a_ = this.Influenza_Virus_LAIV_Immunization();
		var b_ = context.Operators.RetrieveByValueSet<Immunization>(a_, null);
		var c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization LAIVVaccine)
		{
			var p_ = this.Date_of_Second_Birthday();
			var r_ = context.Operators.Interval(p_, p_, true, true);
			var s_ = context.Operators.LateBoundProperty<CqlDateTime>(LAIVVaccine?.Occurrence, "value");
			var t_ = QICoreCommon_2_0_000.ToInterval((s_ as object));
			var u_ = CQMCommon_2_0_000.ToDateInterval(t_);
			var v_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, u_, "day");

			return v_;
		};
		var e_ = context.Operators.WhereOrNull<Immunization>(c_, d_);
		CqlDate f_(Immunization LAIVVaccine)
		{
			var w_ = context.Operators.LateBoundProperty<CqlDateTime>(LAIVVaccine?.Occurrence, "value");
			var x_ = QICoreCommon_2_0_000.ToInterval((w_ as object));
			var y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			var z_ = context.Operators.Start(y_);
			var aa_ = context.Operators.ConvertDateToDateTime(z_);
			var ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		var g_ = context.Operators.SelectOrNull<Immunization, CqlDate>(e_, f_);
		var h_ = this.Influenza_Virus_LAIV_Procedure();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure InfluenzaAdministration)
		{
			var ac_ = this.Date_of_Second_Birthday();
			var ae_ = context.Operators.Interval(ac_, ac_, true, true);
			var af_ = FHIRHelpers_4_3_000.ToValue(InfluenzaAdministration?.Performed);
			var ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			var ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			var ai_ = context.Operators.IntervalIncludesInterval<CqlDate>(ae_, ah_, "day");

			return ai_;
		};
		var l_ = context.Operators.WhereOrNull<Procedure>(j_, k_);
		CqlDate m_(Procedure InfluenzaAdministration)
		{
			var aj_ = FHIRHelpers_4_3_000.ToValue(InfluenzaAdministration?.Performed);
			var ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			var al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
			var am_ = context.Operators.Start(al_);
			var an_ = context.Operators.ConvertDateToDateTime(am_);
			var ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		var n_ = context.Operators.SelectOrNull<Procedure, CqlDate>(l_, m_);
		var o_ = context.Operators.ListUnion<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("LAIV Vaccinations")]
	public IEnumerable<CqlDate> LAIV_Vaccinations() => 
		__LAIV_Vaccinations.Value;

	private bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination_Value()
	{
		var a_ = this.LAIV_Vaccinations();
		var b_ = context.Operators.ExistsInList<CqlDate>(a_);
		var c_ = this.Influenza_Immunizations_or_Procedures();
		var d_ = context.Operators.ExistsInList<CqlDate>(c_);
		var e_ = context.Operators.And(b_, d_);

		return e_;
	}

    [CqlDeclaration("Two Influenza Vaccinations Including One LAIV Vaccination")]
	public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination() => 
		__Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination.Value;

	private IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions_Value()
	{
		var a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Condition>(b_, null);
		var d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition InfluenzaConditions)
		{
			var g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(InfluenzaConditions);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = this.First_Two_Years();
			var k_ = context.Operators.ElementInInterval<CqlDate>(i_, j_, "day");

			return k_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Influenza Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions() => 
		__Influenza_Numerator_Inclusion_Conditions.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Four_DTaP_Vaccinations();
		var b_ = context.Operators.ExistsInList<CqlDate>(a_);
		var c_ = this.DTaP_Numerator_Inclusion_Conditions();
		var d_ = context.Operators.ExistsInList<Condition>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Three_Polio_Vaccinations();
		var g_ = context.Operators.ExistsInList<CqlDate>(f_);
		var h_ = this.Polio_Numerator_Inclusion_Conditions();
		var i_ = context.Operators.ExistsInList<Condition>(h_);
		var j_ = context.Operators.Or(g_, i_);
		var k_ = context.Operators.And(e_, j_);
		var l_ = this.One_MMR_Vaccination();
		var m_ = context.Operators.ExistsInList<object>(l_);
		var n_ = this.MMR_Numerator_Inclusion_Conditions();
		var o_ = context.Operators.ExistsInList<Condition>(n_);
		var p_ = context.Operators.Or(m_, o_);
		var q_ = this.Measles_Indicators();
		var r_ = context.Operators.ExistsInList<Condition>(q_);
		var s_ = this.Mumps_Indicators();
		var t_ = context.Operators.ExistsInList<Condition>(s_);
		var u_ = context.Operators.And(r_, t_);
		var v_ = this.Rubella_Indicators();
		var w_ = context.Operators.ExistsInList<Condition>(v_);
		var x_ = context.Operators.And(u_, w_);
		var y_ = context.Operators.Or(p_, x_);
		var z_ = context.Operators.And(k_, y_);
		var aa_ = this.Has_Appropriate_Number_of_Hib_Immunizations();
		var ab_ = this.Hib_Numerator_Inclusion_Conditions();
		var ac_ = context.Operators.ExistsInList<Condition>(ab_);
		var ad_ = context.Operators.Or(aa_, ac_);
		var ae_ = context.Operators.And(z_, ad_);
		var af_ = this.Three_Hepatitis_B_Vaccinations();
		var ag_ = context.Operators.ExistsInList<CqlDate>(af_);
		var ah_ = this.Meets_HepB_Vaccination_Requirement();
		var ai_ = context.Operators.ExistsInList<CqlDate>(ah_);
		var aj_ = this.Hepatitis_B_Numerator_Inclusion_Conditions();
		var ak_ = context.Operators.ExistsInList<Condition>(aj_);
		var al_ = context.Operators.Or(ai_, ak_);
		var am_ = context.Operators.Or(ag_, al_);
		var an_ = context.Operators.And(ae_, am_);
		var ao_ = this.One_Chicken_Pox_Vaccination();
		var ap_ = context.Operators.ExistsInList<object>(ao_);
		var aq_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions();
		var ar_ = context.Operators.ExistsInList<Condition>(aq_);
		var as_ = context.Operators.Or(ap_, ar_);
		var at_ = context.Operators.And(an_, as_);
		var au_ = this.Four_Pneumococcal_Conjugate_Vaccinations();
		var av_ = context.Operators.ExistsInList<CqlDate>(au_);
		var aw_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions();
		var ax_ = context.Operators.ExistsInList<Condition>(aw_);
		var ay_ = context.Operators.Or(av_, ax_);
		var az_ = context.Operators.And(at_, ay_);
		var ba_ = this.One_Hepatitis_A_Vaccinations();
		var bb_ = context.Operators.ExistsInList<object>(ba_);
		var bc_ = this.Hepatitis_A_Numerator_Inclusion_Conditions();
		var bd_ = context.Operators.ExistsInList<Condition>(bc_);
		var be_ = context.Operators.Or(bb_, bd_);
		var bf_ = context.Operators.And(az_, be_);
		var bg_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations();
		var bh_ = this.Rotavirus_Numerator_Inclusion_Conditions();
		var bi_ = context.Operators.ExistsInList<Condition>(bh_);
		var bj_ = context.Operators.Or(bg_, bi_);
		var bk_ = context.Operators.And(bf_, bj_);
		var bl_ = this.Two_Influenza_Vaccinations();
		var bm_ = context.Operators.ExistsInList<CqlDate>(bl_);
		var bn_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination();
		var bo_ = context.Operators.Or(bm_, bn_);
		var bp_ = this.Influenza_Numerator_Inclusion_Conditions();
		var bq_ = context.Operators.ExistsInList<Condition>(bp_);
		var br_ = context.Operators.Or(bo_, bq_);
		var bs_ = context.Operators.And(bk_, br_);

		return bs_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}