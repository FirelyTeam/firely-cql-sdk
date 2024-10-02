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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031", default);

    [CqlDeclaration("Anaphylactic Reaction to DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1031")]
	public CqlValueSet Anaphylactic_Reaction_to_DTaP_Vaccine() => 
		__Anaphylactic_Reaction_to_DTaP_Vaccine.Value;

	private CqlValueSet Disorders_of_the_Immune_System_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001", default);

    [CqlDeclaration("Disorders of the Immune System")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1001")]
	public CqlValueSet Disorders_of_the_Immune_System() => 
		__Disorders_of_the_Immune_System.Value;

	private CqlValueSet DTaP_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214", default);

    [CqlDeclaration("DTaP Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1214")]
	public CqlValueSet DTaP_Vaccine() => 
		__DTaP_Vaccine.Value;

	private CqlValueSet DTaP_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022", default);

    [CqlDeclaration("DTaP Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1022")]
	public CqlValueSet DTaP_Vaccine_Administered() => 
		__DTaP_Vaccine_Administered.Value;

	private CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164", default);

    [CqlDeclaration("Encephalitis Due to Diphtheria, Tetanus or Pertussis Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1164")]
	public CqlValueSet Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine() => 
		__Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043", default);

    [CqlDeclaration("Haemophilus Influenzae Type B (Hib) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1043")]
	public CqlValueSet Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered() => 
		__Haemophilus_Influenzae_Type_B__Hib__Vaccine_Administered.Value;

	private CqlValueSet Hepatitis_A_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", default);

    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
	public CqlValueSet Hepatitis_A() => 
		__Hepatitis_A.Value;

	private CqlValueSet Hepatitis_A_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215", default);

    [CqlDeclaration("Hepatitis A Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1215")]
	public CqlValueSet Hepatitis_A_Vaccine() => 
		__Hepatitis_A_Vaccine.Value;

	private CqlValueSet Hepatitis_A_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041", default);

    [CqlDeclaration("Hepatitis A Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1041")]
	public CqlValueSet Hepatitis_A_Vaccine_Administered() => 
		__Hepatitis_A_Vaccine_Administered.Value;

	private CqlValueSet Hepatitis_B_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025", default);

    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1025")]
	public CqlValueSet Hepatitis_B() => 
		__Hepatitis_B.Value;

	private CqlValueSet Hepatitis_B_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216", default);

    [CqlDeclaration("Hepatitis B Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1216")]
	public CqlValueSet Hepatitis_B_Vaccine() => 
		__Hepatitis_B_Vaccine.Value;

	private CqlValueSet Hepatitis_B_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042", default);

    [CqlDeclaration("Hepatitis B Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1042")]
	public CqlValueSet Hepatitis_B_Vaccine_Administered() => 
		__Hepatitis_B_Vaccine_Administered.Value;

	private CqlValueSet Hib_Vaccine__3_dose_schedule__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083", default);

    [CqlDeclaration("Hib Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1083")]
	public CqlValueSet Hib_Vaccine__3_dose_schedule_() => 
		__Hib_Vaccine__3_dose_schedule_.Value;

	private CqlValueSet Hib_Vaccine__3_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084", default);

    [CqlDeclaration("Hib Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1084")]
	public CqlValueSet Hib_Vaccine__3_dose_schedule__Administered() => 
		__Hib_Vaccine__3_dose_schedule__Administered.Value;

	private CqlValueSet Hib_Vaccine__4_dose_schedule__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085", default);

    [CqlDeclaration("Hib Vaccine (4 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1085")]
	public CqlValueSet Hib_Vaccine__4_dose_schedule_() => 
		__Hib_Vaccine__4_dose_schedule_.Value;

	private CqlValueSet Hib_Vaccine__4_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086", default);

    [CqlDeclaration("Hib Vaccine (4 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1086")]
	public CqlValueSet Hib_Vaccine__4_dose_schedule__Administered() => 
		__Hib_Vaccine__4_dose_schedule__Administered.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory.Value;

	private CqlValueSet Inactivated_Polio_Vaccine__IPV__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219", default);

    [CqlDeclaration("Inactivated Polio Vaccine (IPV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1219")]
	public CqlValueSet Inactivated_Polio_Vaccine__IPV_() => 
		__Inactivated_Polio_Vaccine__IPV_.Value;

	private CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045", default);

    [CqlDeclaration("Inactivated Polio Vaccine (IPV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1045")]
	public CqlValueSet Inactivated_Polio_Vaccine__IPV__Administered() => 
		__Inactivated_Polio_Vaccine__IPV__Administered.Value;

	private CqlValueSet Child_Influenza_Immunization_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218", default);

    [CqlDeclaration("Child Influenza Immunization Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1218")]
	public CqlValueSet Child_Influenza_Immunization_Administered() => 
		__Child_Influenza_Immunization_Administered.Value;

	private CqlValueSet Child_Influenza_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044", default);

    [CqlDeclaration("Child Influenza Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1044")]
	public CqlValueSet Child_Influenza_Vaccine_Administered() => 
		__Child_Influenza_Vaccine_Administered.Value;

	private CqlValueSet Influenza_Virus_LAIV_Immunization_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087", default);

    [CqlDeclaration("Influenza Virus LAIV Immunization")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1087")]
	public CqlValueSet Influenza_Virus_LAIV_Immunization() => 
		__Influenza_Virus_LAIV_Immunization.Value;

	private CqlValueSet Influenza_Virus_LAIV_Procedure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088", default);

    [CqlDeclaration("Influenza Virus LAIV Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1088")]
	public CqlValueSet Influenza_Virus_LAIV_Procedure() => 
		__Influenza_Virus_LAIV_Procedure.Value;

	private CqlValueSet Intussusception_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056", default);

    [CqlDeclaration("Intussusception")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.199.12.1056")]
	public CqlValueSet Intussusception() => 
		__Intussusception.Value;

	private CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009", default);

    [CqlDeclaration("Malignant Neoplasm of Lymphatic and Hematopoietic Tissue")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1009")]
	public CqlValueSet Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue() => 
		__Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue.Value;

	private CqlValueSet Measles_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053", default);

    [CqlDeclaration("Measles")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1053")]
	public CqlValueSet Measles() => 
		__Measles.Value;

	private CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224", default);

    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1224")]
	public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine() => 
		__Measles__Mumps_and_Rubella__MMR__Vaccine.Value;

	private CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031", default);

    [CqlDeclaration("Measles, Mumps and Rubella (MMR) Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1031")]
	public CqlValueSet Measles__Mumps_and_Rubella__MMR__Vaccine_Administered() => 
		__Measles__Mumps_and_Rubella__MMR__Vaccine_Administered.Value;

	private CqlValueSet Mumps_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032", default);

    [CqlDeclaration("Mumps")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1032")]
	public CqlValueSet Mumps() => 
		__Mumps.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Pneumococcal_Conjugate_Vaccine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221", default);

    [CqlDeclaration("Pneumococcal Conjugate Vaccine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1221")]
	public CqlValueSet Pneumococcal_Conjugate_Vaccine() => 
		__Pneumococcal_Conjugate_Vaccine.Value;

	private CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046", default);

    [CqlDeclaration("Pneumococcal Conjugate Vaccine Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1046")]
	public CqlValueSet Pneumococcal_Conjugate_Vaccine_Administered() => 
		__Pneumococcal_Conjugate_Vaccine_Administered.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048", default);

    [CqlDeclaration("Rotavirus Vaccine (2 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1048")]
	public CqlValueSet Rotavirus_Vaccine__2_dose_schedule__Administered() => 
		__Rotavirus_Vaccine__2_dose_schedule__Administered.Value;

	private CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223", default);

    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1223")]
	public CqlValueSet Rotavirus_Vaccine__3_dose_schedule_() => 
		__Rotavirus_Vaccine__3_dose_schedule_.Value;

	private CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047", default);

    [CqlDeclaration("Rotavirus Vaccine (3 dose schedule) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1047")]
	public CqlValueSet Rotavirus_Vaccine__3_dose_schedule__Administered() => 
		__Rotavirus_Vaccine__3_dose_schedule__Administered.Value;

	private CqlValueSet Rubella_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037", default);

    [CqlDeclaration("Rubella")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1037")]
	public CqlValueSet Rubella() => 
		__Rubella.Value;

	private CqlValueSet Severe_Combined_Immunodeficiency_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007", default);

    [CqlDeclaration("Severe Combined Immunodeficiency")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1007")]
	public CqlValueSet Severe_Combined_Immunodeficiency() => 
		__Severe_Combined_Immunodeficiency.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Varicella_Zoster_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039", default);

    [CqlDeclaration("Varicella Zoster")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1039")]
	public CqlValueSet Varicella_Zoster() => 
		__Varicella_Zoster.Value;

	private CqlValueSet Varicella_Zoster_Vaccine__VZV__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170", default);

    [CqlDeclaration("Varicella Zoster Vaccine (VZV)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1170")]
	public CqlValueSet Varicella_Zoster_Vaccine__VZV_() => 
		__Varicella_Zoster_Vaccine__VZV_.Value;

	private CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040", default);

    [CqlDeclaration("Varicella Zoster Vaccine (VZV) Administered")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1040")]
	public CqlValueSet Varicella_Zoster_Vaccine__VZV__Administered() => 
		__Varicella_Zoster_Vaccine__VZV__Administered.Value;

	private CqlCode Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder__Value() => 
		new CqlCode("433621000124101", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis due to Haemophilus influenzae type b vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_() => 
		__Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_.Value;

	private CqlCode Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder__Value() => 
		new CqlCode("428321000124101", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis due to Hepatitis B vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_() => 
		__Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_.Value;

	private CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder__Value() => 
		new CqlCode("428331000124103", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis due to rotavirus vaccine (disorder)")]
	public CqlCode Anaphylaxis_due_to_rotavirus_vaccine__disorder_() => 
		__Anaphylaxis_due_to_rotavirus_vaccine__disorder_.Value;

	private CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional_Value() => 
		new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlDeclaration("Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional")]
	public CqlCode Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional() => 
		__Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional.Value;

	private CqlCode rotavirus__live__monovalent_vaccine_Value() => 
		new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default);

    [CqlDeclaration("rotavirus, live, monovalent vaccine")]
	public CqlCode rotavirus__live__monovalent_vaccine() => 
		__rotavirus__live__monovalent_vaccine.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder__Value() => 
		new CqlCode("471311000124103", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Hepatitis A virus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_.Value;

	private CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach_Value() => 
		new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default);

    [CqlDeclaration("Introduction of Serum, Toxoid and Vaccine into Muscle, Percutaneous Approach")]
	public CqlCode Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach() => 
		__Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder__Value() => 
		new CqlCode("471361000124100", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Influenza virus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder__Value() => 
		new CqlCode("471331000124109", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Measles morbillivirus and Mumps orthorubulavirus and Rubella virus antigens (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder__Value() => 
		new CqlCode("471141000124102", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing Streptococcus pneumoniae antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder__Value() => 
		new CqlCode("471321000124106", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine product containing human poliovirus antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_.Value;

	private CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder__Value() => 
		new CqlCode("471341000124104", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Anaphylaxis caused by vaccine containing Human alphaherpesvirus 3 antigen (disorder)")]
	public CqlCode Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_() => 
		__Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_.Value;

	private CqlCode[] SNOMEDCT_Value()
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

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("99211", "http://www.ama-assn.org/go/cpt", default, default),
		];

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlCode[] CVX_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("119", "http://hl7.org/fhir/sid/cvx", default, default),
		];

		return a_;
	}

    [CqlDeclaration("CVX")]
	public CqlCode[] CVX() => 
		__CVX.Value;

	private CqlCode[] ICD10_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("3E0234Z", "http://www.cms.gov/Medicare/Coding/ICD10", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD10")]
	public CqlCode[] ICD10() => 
		__ICD10.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ChildhoodImmunizationStatusFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		IEnumerable<Encounter> l_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? m_(Encounter E)
		{
			List<CodeableConcept> y_ = E?.Type;
			CqlConcept z_(CodeableConcept @this)
			{
				CqlConcept ae_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ae_;
			};
			IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
			bool? ab_(CqlConcept T)
			{
				CqlCode af_ = this.Office_or_other_outpatient_visit_for_the_evaluation_and_management_of_an_established_patient_that_may_not_require_the_presence_of_a_physician_or_other_qualified_health_care_professional();
				CqlConcept ag_ = context.Operators.ConvertCodeToConcept(af_);
				bool? ah_ = context.Operators.Equivalent(T, ag_);

				return ah_;
			};
			IEnumerable<CqlConcept> ac_ = context.Operators.Where<CqlConcept>(aa_, ab_);
			bool? ad_ = context.Operators.Exists<CqlConcept>(ac_);

			return ad_;
		};
		IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
		CqlValueSet o_ = this.Online_Assessments();
		IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(k_, q_);
		CqlValueSet s_ = this.Telephone_Visits();
		IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> u_ = context.Operators.Union<Encounter>(r_, t_);
		IEnumerable<Encounter> v_ = Status_1_6_000.Finished_Encounter(u_);
		bool? w_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> ai_ = this.Measurement_Period();
			Period aj_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_3_000.ToInterval(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_ as object);
			bool? am_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ai_, al_, "day");

			return am_;
		};
		IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);

		return x_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.Equal(h_, 2);
		IEnumerable<Encounter> j_ = this.Qualifying_Encounters();
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		bool? l_ = context.Operators.And(i_, k_);

		return l_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private CqlDate Date_of_Second_Birthday_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlQuantity e_ = context.Operators.Quantity(2m, "years");
		CqlDate f_ = context.Operators.Add(d_, e_);

		return f_;
	}

    [CqlDeclaration("Date of Second Birthday")]
	public CqlDate Date_of_Second_Birthday() => 
		__Date_of_Second_Birthday.Value;

	private CqlInterval<CqlDate> First_Two_Years_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
		CqlDate f_ = context.Operators.DateFrom(e_);
		CqlDate g_ = this.Date_of_Second_Birthday();
		CqlInterval<CqlDate> h_ = context.Operators.Interval(f_, g_, true, true);

		return h_;
	}

    [CqlDeclaration("First Two Years")]
	public CqlInterval<CqlDate> First_Two_Years() => 
		__First_Two_Years.Value;

	private bool? Has_Severe_Combined_Immunodeficiency_Value()
	{
		CqlValueSet a_ = this.Severe_Combined_Immunodeficiency();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition SevereImmuneDisorder)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(SevereImmuneDisorder);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Severe Combined Immunodeficiency")]
	public bool? Has_Severe_Combined_Immunodeficiency() => 
		__Has_Severe_Combined_Immunodeficiency.Value;

	private bool? Has_Immunodeficiency_Value()
	{
		CqlValueSet a_ = this.Disorders_of_the_Immune_System();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition ImmuneDisorder)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(ImmuneDisorder);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Immunodeficiency")]
	public bool? Has_Immunodeficiency() => 
		__Has_Immunodeficiency.Value;

	private bool? Has_HIV_Value()
	{
		CqlValueSet a_ = this.HIV();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition HIV)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HIV);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has HIV")]
	public bool? Has_HIV() => 
		__Has_HIV.Value;

	private bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia_Value()
	{
		CqlValueSet a_ = this.Malignant_Neoplasm_of_Lymphatic_and_Hematopoietic_Tissue();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition LymphaticMalignantNeoplasm)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(LymphaticMalignantNeoplasm);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Lymphoreticular Cancer, Multiple Myeloma or Leukemia")]
	public bool? Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia() => 
		__Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia.Value;

	private bool? Has_Intussusception_Value()
	{
		CqlValueSet a_ = this.Intussusception();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition IntussusceptionDisorder)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(IntussusceptionDisorder);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
		bool? f_ = context.Operators.Exists<Condition>(e_);

		return f_;
	}

    [CqlDeclaration("Has Intussusception")]
	public bool? Has_Intussusception() => 
		__Has_Intussusception.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		bool? b_ = this.Has_Severe_Combined_Immunodeficiency();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Immunodeficiency();
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_HIV();
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = this.Has_Lymphoreticular_Cancer__Multiple_Myeloma_or_Leukemia();
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = this.Has_Intussusception();
		bool? k_ = context.Operators.Or(i_, j_);

		return k_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
		CqlDate f_ = context.Operators.DateFrom(e_);
		CqlQuantity g_ = context.Operators.Quantity(42m, "days");
		CqlDate h_ = context.Operators.Add(f_, g_);
		CqlDate i_ = this.Date_of_Second_Birthday();
		CqlInterval<CqlDate> j_ = context.Operators.Interval(h_, i_, true, true);

		return j_;
	}

    [CqlDeclaration("Vaccine Administration Interval - 42 Days up to 2 Years Old")]
	public CqlInterval<CqlDate> Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old() => 
		__Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old.Value;

	private IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.DTaP_Vaccine();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization DTaPVaccination)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType q_ = DTaPVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization DTaPVaccination)
		{
			DataType v_ = DTaPVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.DTaP_Vaccine_Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure DTaPProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType ad_ = DTaPProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.ToDateInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure DTaPProcedure)
		{
			DataType ai_ = DTaPProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("DTaP Immunizations or Procedures")]
	public IEnumerable<CqlDate> DTaP_Immunizations_or_Procedures() => 
		__DTaP_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Four_DTaP_Vaccinations_Value()
	{
		IEnumerable<CqlDate> a_ = this.DTaP_Immunizations_or_Procedures();
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);
		(CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? f_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? l_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

			return l_;
		};
		IEnumerable<(CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(e_, f_);
		bool? h_((CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji)
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
		IEnumerable<(CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?> i_ = context.Operators.Where<(CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?>(g_, h_);
		CqlDate j_((CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)? tuple_emdhflcfhwveravvnflazyxji) => 
			tuple_emdhflcfhwveravvnflazyxji?.DTaPVaccination1;
		IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlDate DTaPVaccination1, CqlDate DTaPVaccination2, CqlDate DTaPVaccination3, CqlDate DTaPVaccination4)?, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Four DTaP Vaccinations")]
	public IEnumerable<CqlDate> Four_DTaP_Vaccinations() => 
		__Four_DTaP_Vaccinations.Value;

	private IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions_Value()
	{
		CqlValueSet a_ = this.Anaphylactic_Reaction_to_DTaP_Vaccine();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet c_ = this.Encephalitis_Due_to_Diphtheria__Tetanus_or_Pertussis_Vaccine();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		IEnumerable<Condition> f_ = Status_1_6_000.Active_Condition(e_);
		bool? g_(Condition DTaPConditions)
		{
			CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.ToPrevalenceInterval(DTaPConditions);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			CqlInterval<CqlDate> l_ = this.First_Two_Years();
			bool? m_ = context.Operators.In<CqlDate>(k_, l_, "day");

			return m_;
		};
		IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);

		return h_;
	}

    [CqlDeclaration("DTaP Numerator Inclusion Conditions")]
	public IEnumerable<Condition> DTaP_Numerator_Inclusion_Conditions() => 
		__DTaP_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Polio_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.Inactivated_Polio_Vaccine__IPV_();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization PolioVaccination)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType q_ = PolioVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization PolioVaccination)
		{
			DataType v_ = PolioVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Inactivated_Polio_Vaccine__IPV__Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure PolioProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType ad_ = PolioProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.ToDateInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure PolioProcedure)
		{
			DataType ai_ = PolioProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Polio Immunizations or Procedures")]
	public IEnumerable<CqlDate> Polio_Immunizations_or_Procedures() => 
		__Polio_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Three_Polio_Vaccinations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Polio_Immunizations_or_Procedures();
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);
		(CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? k_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return k_;
		};
		IEnumerable<(CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(d_, e_);
		bool? g_((CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2, m_, "day");
			CqlDate p_ = context.Operators.Add(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination2, l_);
			bool? q_ = context.Operators.SameOrAfter(tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination3, p_, "day");
			bool? r_ = context.Operators.And(n_, q_);

			return r_;
		};
		IEnumerable<(CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?> h_ = context.Operators.Where<(CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?>(f_, g_);
		CqlDate i_((CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)? tuple_cnghazroxajthpiccbiajbrxv) => 
			tuple_cnghazroxajthpiccbiajbrxv?.PolioVaccination1;
		IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlDate PolioVaccination1, CqlDate PolioVaccination2, CqlDate PolioVaccination3)?, CqlDate>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Three Polio Vaccinations")]
	public IEnumerable<CqlDate> Three_Polio_Vaccinations() => 
		__Three_Polio_Vaccinations.Value;

	private IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions_Value()
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_human_poliovirus_antigen__disorder_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition PolioConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(PolioConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Polio Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Polio_Numerator_Inclusion_Conditions() => 
		__Polio_Numerator_Inclusion_Conditions.Value;

	private CqlDate Date_of_First_Birthday_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
		CqlDate f_ = context.Operators.DateFrom(e_);
		CqlQuantity g_ = context.Operators.Quantity(1m, "year");
		CqlDate h_ = context.Operators.Add(f_, g_);

		return h_;
	}

    [CqlDeclaration("Date of First Birthday")]
	public CqlDate Date_of_First_Birthday() => 
		__Date_of_First_Birthday.Value;

	private CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday_Value()
	{
		CqlDate a_ = this.Date_of_First_Birthday();
		CqlDate b_ = this.Date_of_Second_Birthday();
		CqlInterval<CqlDate> c_ = context.Operators.Interval(a_, b_, true, true);

		return c_;
	}

    [CqlDeclaration("Date of First Birthday to Date of Second Birthday")]
	public CqlInterval<CqlDate> Date_of_First_Birthday_to_Date_of_Second_Birthday() => 
		__Date_of_First_Birthday_to_Date_of_Second_Birthday.Value;

	private IEnumerable<object> One_MMR_Vaccination_Value()
	{
		CqlValueSet a_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization MMRVaccination)
		{
			CqlInterval<CqlDate> l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			DataType m_ = MMRVaccination?.Occurrence;
			CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval(n_ as object);
			CqlInterval<CqlDate> p_ = CQMCommon_2_0_000.ToDateInterval(o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, p_, default);

			return q_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlValueSet f_ = this.Measles__Mumps_and_Rubella__MMR__Vaccine_Administered();
		IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> h_ = Status_1_6_000.Completed_Procedure(g_);
		bool? i_(Procedure MMRProcedure)
		{
			CqlInterval<CqlDate> r_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			DataType s_ = MMRProcedure?.Performed;
			object t_ = FHIRHelpers_4_3_000.ToValue(s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.ToDateInterval(u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, default);

			return w_;
		};
		IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
		IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

		return k_;
	}

    [CqlDeclaration("One MMR Vaccination")]
	public IEnumerable<object> One_MMR_Vaccination() => 
		__One_MMR_Vaccination.Value;

	private IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions_Value()
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Measles_morbillivirus_and_Mumps_orthorubulavirus_and_Rubella_virus_antigens__disorder_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition MMRConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(MMRConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("MMR Numerator Inclusion Conditions")]
	public IEnumerable<Condition> MMR_Numerator_Inclusion_Conditions() => 
		__MMR_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<Condition> Measles_Indicators_Value()
	{
		CqlValueSet a_ = this.Measles();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition MeaslesDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(MeaslesDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			CqlInterval<CqlDate> i_ = this.First_Two_Years();
			bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Measles Indicators")]
	public IEnumerable<Condition> Measles_Indicators() => 
		__Measles_Indicators.Value;

	private IEnumerable<Condition> Mumps_Indicators_Value()
	{
		CqlValueSet a_ = this.Mumps();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition MumpsDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(MumpsDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			CqlInterval<CqlDate> i_ = this.First_Two_Years();
			bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Mumps Indicators")]
	public IEnumerable<Condition> Mumps_Indicators() => 
		__Mumps_Indicators.Value;

	private IEnumerable<Condition> Rubella_Indicators_Value()
	{
		CqlValueSet a_ = this.Rubella();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition RubellaDiagnosis)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(RubellaDiagnosis);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			CqlInterval<CqlDate> i_ = this.First_Two_Years();
			bool? j_ = context.Operators.In<CqlDate>(h_, i_, "day");

			return j_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Rubella Indicators")]
	public IEnumerable<Condition> Rubella_Indicators() => 
		__Rubella_Indicators.Value;

	private IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.Hib_Vaccine__3_dose_schedule_();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization ThreeDoseHibVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType q_ = ThreeDoseHibVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization ThreeDoseHibVaccine)
		{
			DataType v_ = ThreeDoseHibVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Hib_Vaccine__3_dose_schedule__Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure ThreeDoseHibProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType ad_ = ThreeDoseHibProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.ToDateInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure ThreeDoseHibProcedure)
		{
			DataType ai_ = ThreeDoseHibProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Hib 3 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hib_3_Dose_Immunizations_or_Procedures() => 
		__Hib_3_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.Hib_Vaccine__4_dose_schedule_();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization HibVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType q_ = HibVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization HibVaccine)
		{
			DataType v_ = HibVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Hib_Vaccine__4_dose_schedule__Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure HibProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType ad_ = HibProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.ToDateInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure HibProcedure)
		{
			DataType ai_ = HibProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
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
	public IEnumerable<CqlDate> Hib_4_Dose_Immunizations_or_Procedures() => 
		__Hib_4_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Hib_3_Dose_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_ = this.Hib_4_Dose_Immunizations_or_Procedures();
		IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Hib 3 or 4 Dose Immunizations")]
	public IEnumerable<CqlDate> Hib_3_or_4_Dose_Immunizations() => 
		__Hib_3_or_4_Dose_Immunizations.Value;

	private IEnumerable<CqlDate> All_Hib_Vaccinations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Hib_3_or_4_Dose_Immunizations();
		IEnumerable<CqlDate> c_(CqlDate AllHibDoses1)
		{
			IEnumerable<CqlDate> f_ = this.Hib_3_or_4_Dose_Immunizations();
			bool? g_(CqlDate AllHibDoses2)
			{
				CqlQuantity k_ = context.Operators.Quantity(1m, "day");
				CqlDate l_ = context.Operators.Subtract(AllHibDoses2, k_);
				CqlInterval<CqlDate> m_ = context.Operators.Interval(l_, AllHibDoses2, false, false);
				bool? n_ = context.Operators.In<CqlDate>(AllHibDoses1, m_, default);

				return n_;
			};
			IEnumerable<CqlDate> h_ = context.Operators.Where<CqlDate>(f_, g_);
			CqlDate i_(CqlDate AllHibDoses2) => 
				AllHibDoses1;
			IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);

			return j_;
		};
		IEnumerable<CqlDate> d_ = context.Operators.SelectMany<CqlDate, CqlDate>(a_, c_);
		IEnumerable<CqlDate> e_ = context.Operators.Except<CqlDate>(a_, d_);

		return e_;
	}

    [CqlDeclaration("All Hib Vaccinations")]
	public IEnumerable<CqlDate> All_Hib_Vaccinations() => 
		__All_Hib_Vaccinations.Value;

	private bool? Has_Appropriate_Number_of_Hib_Immunizations_Value()
	{
		IEnumerable<CqlDate> a_ = this.All_Hib_Vaccinations();
		bool? b_(CqlDate HibImmunization)
		{
			IEnumerable<CqlDate> e_ = this.Hib_4_Dose_Immunizations_or_Procedures();
			int? f_ = context.Operators.Count<CqlDate>(e_);
			bool? g_ = context.Operators.Greater(f_, 0);
			IEnumerable<CqlDate> h_ = this.All_Hib_Vaccinations();
			CqlDate i_(CqlDate HibVaccinations) => 
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

    [CqlDeclaration("Has Appropriate Number of Hib Immunizations")]
	public bool? Has_Appropriate_Number_of_Hib_Immunizations() => 
		__Has_Appropriate_Number_of_Hib_Immunizations.Value;

	private IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions_Value()
	{
		CqlCode a_ = this.Anaphylaxis_due_to_Haemophilus_influenzae_type_b_vaccine__disorder_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition HibReaction)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HibReaction);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Hib Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hib_Numerator_Inclusion_Conditions() => 
		__Hib_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.Hepatitis_B_Vaccine();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization HepatitisBVaccination)
		{
			CqlInterval<CqlDate> p_ = this.First_Two_Years();
			DataType q_ = HepatitisBVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization HepatitisBVaccination)
		{
			DataType v_ = HepatitisBVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Hepatitis_B_Vaccine_Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure HepatitisBProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.First_Two_Years();
			DataType ad_ = HepatitisBProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.ToDateInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure HepatitisBProcedure)
		{
			DataType ai_ = HepatitisBProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Hepatitis B Immunizations or Procedures")]
	public IEnumerable<CqlDate> Hepatitis_B_Immunizations_or_Procedures() => 
		__Hepatitis_B_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures();
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, a_);
		(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? k_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return k_;
		};
		IEnumerable<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(d_, e_);
		bool? g_((CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw)
		{
			CqlQuantity l_ = context.Operators.Quantity(1m, "day");
			CqlDate m_ = context.Operators.Add(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1, l_);
			bool? n_ = context.Operators.SameOrAfter(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2, m_, "day");
			CqlDate p_ = context.Operators.Add(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination2, l_);
			bool? q_ = context.Operators.SameOrAfter(tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination3, p_, "day");
			bool? r_ = context.Operators.And(n_, q_);

			return r_;
		};
		IEnumerable<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?> h_ = context.Operators.Where<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?>(f_, g_);
		CqlDate i_((CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)? tuple_eztgahauwggsdgadcgqnnipgw) => 
			tuple_eztgahauwggsdgadcgqnnipgw?.HepatitisBVaccination1;
		IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate HepatitisBVaccination3)?, CqlDate>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Three Hepatitis B Vaccinations")]
	public IEnumerable<CqlDate> Three_Hepatitis_B_Vaccinations() => 
		__Three_Hepatitis_B_Vaccinations.Value;

	private IEnumerable<CqlDate> NewBorn_Vaccine_Requirement_Value()
	{
		CqlCode a_ = this.Introduction_of_Serum__Toxoid_and_Vaccine_into_Muscle__Percutaneous_Approach();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Procedure> c_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> d_ = Status_1_6_000.Completed_Procedure(c_);
		bool? e_(Procedure NewBornVaccine)
		{
			Patient i_ = this.Patient();
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
			object y_ = FHIRHelpers_4_3_000.ToValue(x_);
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.ToInterval(y_);
			CqlInterval<CqlDate> aa_ = CQMCommon_2_0_000.ToDateInterval(z_);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDate>(w_, aa_, "day");

			return ab_;
		};
		IEnumerable<Procedure> f_ = context.Operators.Where<Procedure>(d_, e_);
		CqlDate g_(Procedure NewBornVaccine)
		{
			DataType ac_ = NewBornVaccine?.Performed;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
			CqlDateTime af_ = context.Operators.Start(ae_);
			CqlDate ag_ = context.Operators.DateFrom(af_);

			return ag_;
		};
		IEnumerable<CqlDate> h_ = context.Operators.Select<Procedure, CqlDate>(f_, g_);

		return h_;
	}

    [CqlDeclaration("NewBorn Vaccine Requirement")]
	public IEnumerable<CqlDate> NewBorn_Vaccine_Requirement() => 
		__NewBorn_Vaccine_Requirement.Value;

	private IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement_Value()
	{
		IEnumerable<CqlDate> a_ = this.Hepatitis_B_Immunizations_or_Procedures();
		IEnumerable<CqlDate> c_ = this.NewBorn_Vaccine_Requirement();
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate>(a_, a_, c_);
		(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? e_(ValueTuple<CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? k_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

			return k_;
		};
		IEnumerable<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> f_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate>, (CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(d_, e_);
		bool? g_((CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg)
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
		IEnumerable<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?> h_ = context.Operators.Where<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?>(f_, g_);
		CqlDate i_((CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)? tuple_hdfambzgbwdpfetgqnfbceeeg) => 
			tuple_hdfambzgbwdpfetgqnfbceeeg?.HepatitisBVaccination1;
		IEnumerable<CqlDate> j_ = context.Operators.Select<(CqlDate HepatitisBVaccination1, CqlDate HepatitisBVaccination2, CqlDate NewBornVaccine3)?, CqlDate>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Meets HepB Vaccination Requirement")]
	public IEnumerable<CqlDate> Meets_HepB_Vaccination_Requirement() => 
		__Meets_HepB_Vaccination_Requirement.Value;

	private IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions_Value()
	{
		CqlCode a_ = this.Anaphylaxis_due_to_Hepatitis_B_vaccine__disorder_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet d_ = this.Hepatitis_B();
		IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(c_, e_);
		IEnumerable<Condition> g_ = Status_1_6_000.Active_Condition(f_);
		bool? h_(Condition HepBConditions)
		{
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HepBConditions);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDate> m_ = this.First_Two_Years();
			bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");

			return n_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Hepatitis B Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hepatitis_B_Numerator_Inclusion_Conditions() => 
		__Hepatitis_B_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<object> One_Chicken_Pox_Vaccination_Value()
	{
		CqlValueSet a_ = this.Varicella_Zoster_Vaccine__VZV_();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization ChickenPoxVaccination)
		{
			CqlInterval<CqlDate> l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			DataType m_ = ChickenPoxVaccination?.Occurrence;
			CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval(n_ as object);
			CqlInterval<CqlDate> p_ = CQMCommon_2_0_000.ToDateInterval(o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, p_, default);

			return q_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlValueSet f_ = this.Varicella_Zoster_Vaccine__VZV__Administered();
		IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> h_ = Status_1_6_000.Completed_Procedure(g_);
		bool? i_(Procedure ChickenPoxProcedure)
		{
			CqlInterval<CqlDate> r_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			DataType s_ = ChickenPoxProcedure?.Performed;
			object t_ = FHIRHelpers_4_3_000.ToValue(s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.ToDateInterval(u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, default);

			return w_;
		};
		IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
		IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

		return k_;
	}

    [CqlDeclaration("One Chicken Pox Vaccination")]
	public IEnumerable<object> One_Chicken_Pox_Vaccination() => 
		__One_Chicken_Pox_Vaccination.Value;

	private IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions_Value()
	{
		CqlValueSet a_ = this.Varicella_Zoster();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlCode c_ = this.Anaphylaxis_caused_by_vaccine_containing_Human_alphaherpesvirus_3_antigen__disorder_();
		IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
		IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(b_, e_);
		IEnumerable<Condition> g_ = Status_1_6_000.Active_Condition(f_);
		bool? h_(Condition VaricellaZoster)
		{
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToPrevalenceInterval(VaricellaZoster);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDate> m_ = this.First_Two_Years();
			bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");

			return n_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Varicella Zoster Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Varicella_Zoster_Numerator_Inclusion_Conditions() => 
		__Varicella_Zoster_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.Pneumococcal_Conjugate_Vaccine();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization PneumococcalVaccination)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType q_ = PneumococcalVaccination?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization PneumococcalVaccination)
		{
			DataType v_ = PneumococcalVaccination?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Pneumococcal_Conjugate_Vaccine_Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure PneumococcalProcedure)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType ad_ = PneumococcalProcedure?.Performed;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.ToDateInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure PneumococcalProcedure)
		{
			DataType ai_ = PneumococcalProcedure?.Performed;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Pneumococcal Conjugate Immunizations or Procedures")]
	public IEnumerable<CqlDate> Pneumococcal_Conjugate_Immunizations_or_Procedures() => 
		__Pneumococcal_Conjugate_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Pneumococcal_Conjugate_Immunizations_or_Procedures();
		IEnumerable<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>> e_ = context.Operators.CrossJoin<CqlDate, CqlDate, CqlDate, CqlDate>(a_, a_, a_, a_);
		(CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? f_(ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate> _valueTuple)
		{
			(CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? l_ = (_valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

			return l_;
		};
		IEnumerable<(CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> g_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate, CqlDate, CqlDate>, (CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(e_, f_);
		bool? h_((CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp)
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
		IEnumerable<(CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?> i_ = context.Operators.Where<(CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?>(g_, h_);
		CqlDate j_((CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)? tuple_ddpdeojhpyesfhgcocbnoippp) => 
			tuple_ddpdeojhpyesfhgcocbnoippp?.PneumococcalVaccination1;
		IEnumerable<CqlDate> k_ = context.Operators.Select<(CqlDate PneumococcalVaccination1, CqlDate PneumococcalVaccination2, CqlDate PneumococcalVaccination3, CqlDate PneumococcalVaccination4)?, CqlDate>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Four Pneumococcal Conjugate Vaccinations")]
	public IEnumerable<CqlDate> Four_Pneumococcal_Conjugate_Vaccinations() => 
		__Four_Pneumococcal_Conjugate_Vaccinations.Value;

	private IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions_Value()
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Streptococcus_pneumoniae_antigen__disorder_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition PneumococcalReaction)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(PneumococcalReaction);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Pneumococcal Conjugate Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Pneumococcal_Conjugate_Numerator_Inclusion_Conditions() => 
		__Pneumococcal_Conjugate_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<object> One_Hepatitis_A_Vaccinations_Value()
	{
		CqlValueSet a_ = this.Hepatitis_A_Vaccine();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization HepatitisAVaccination)
		{
			CqlInterval<CqlDate> l_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			DataType m_ = HepatitisAVaccination?.Occurrence;
			CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval(n_ as object);
			CqlInterval<CqlDate> p_ = CQMCommon_2_0_000.ToDateInterval(o_);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDate>(l_, p_, default);

			return q_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlValueSet f_ = this.Hepatitis_A_Vaccine_Administered();
		IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> h_ = Status_1_6_000.Completed_Procedure(g_);
		bool? i_(Procedure HepatitisAProcedure)
		{
			CqlInterval<CqlDate> r_ = this.Date_of_First_Birthday_to_Date_of_Second_Birthday();
			DataType s_ = HepatitisAProcedure?.Performed;
			object t_ = FHIRHelpers_4_3_000.ToValue(s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.ToDateInterval(u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, default);

			return w_;
		};
		IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
		IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

		return k_;
	}

    [CqlDeclaration("One Hepatitis A Vaccinations")]
	public IEnumerable<object> One_Hepatitis_A_Vaccinations() => 
		__One_Hepatitis_A_Vaccinations.Value;

	private IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions_Value()
	{
		CqlValueSet a_ = this.Hepatitis_A();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlCode c_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Hepatitis_A_virus_antigen__disorder_();
		IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
		IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> f_ = context.Operators.Union<Condition>(b_, e_);
		IEnumerable<Condition> g_ = Status_1_6_000.Active_Condition(f_);
		bool? h_(Condition HepatitisADiagnosis)
		{
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToPrevalenceInterval(HepatitisADiagnosis);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlInterval<CqlDate> m_ = this.First_Two_Years();
			bool? n_ = context.Operators.In<CqlDate>(l_, m_, "day");

			return n_;
		};
		IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Hepatitis A Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Hepatitis_A_Numerator_Inclusion_Conditions() => 
		__Hepatitis_A_Numerator_Inclusion_Conditions.Value;

	private IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures_Value()
	{
		CqlCode a_ = this.rotavirus__live__monovalent_vaccine();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Immunization> c_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> d_ = Status_1_6_000.Completed_Immunization(c_);
		bool? e_(Immunization TwoDoseRotavirusVaccine)
		{
			CqlInterval<CqlDate> q_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType r_ = TwoDoseRotavirusVaccine?.Occurrence;
			CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
			CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.ToInterval(s_ as object);
			CqlInterval<CqlDate> u_ = CQMCommon_2_0_000.ToDateInterval(t_);
			bool? v_ = context.Operators.IntervalIncludesInterval<CqlDate>(q_, u_, "day");

			return v_;
		};
		IEnumerable<Immunization> f_ = context.Operators.Where<Immunization>(d_, e_);
		CqlDate g_(Immunization TwoDoseRotavirusVaccine)
		{
			DataType w_ = TwoDoseRotavirusVaccine?.Occurrence;
			CqlDateTime x_ = context.Operators.LateBoundProperty<CqlDateTime>(w_, "value");
			CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.ToInterval(x_ as object);
			CqlInterval<CqlDate> z_ = CQMCommon_2_0_000.ToDateInterval(y_);
			CqlDate aa_ = context.Operators.Start(z_);
			CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
			CqlDate ac_ = context.Operators.DateFrom(ab_);

			return ac_;
		};
		IEnumerable<CqlDate> h_ = context.Operators.Select<Immunization, CqlDate>(f_, g_);
		CqlValueSet i_ = this.Rotavirus_Vaccine__2_dose_schedule__Administered();
		IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> k_ = Status_1_6_000.Completed_Procedure(j_);
		bool? l_(Procedure TwoDoseRotavirusProcedure)
		{
			CqlInterval<CqlDate> ad_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType ae_ = TwoDoseRotavirusProcedure?.Performed;
			object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
			CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.ToInterval(af_);
			CqlInterval<CqlDate> ah_ = CQMCommon_2_0_000.ToDateInterval(ag_);
			bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDate>(ad_, ah_, "day");

			return ai_;
		};
		IEnumerable<Procedure> m_ = context.Operators.Where<Procedure>(k_, l_);
		CqlDate n_(Procedure TwoDoseRotavirusProcedure)
		{
			DataType aj_ = TwoDoseRotavirusProcedure?.Performed;
			object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
			CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_);
			CqlInterval<CqlDate> am_ = CQMCommon_2_0_000.ToDateInterval(al_);
			CqlDate an_ = context.Operators.Start(am_);
			CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
			CqlDate ap_ = context.Operators.DateFrom(ao_);

			return ap_;
		};
		IEnumerable<CqlDate> o_ = context.Operators.Select<Procedure, CqlDate>(m_, n_);
		IEnumerable<CqlDate> p_ = context.Operators.Union<CqlDate>(h_, o_);

		return p_;
	}

    [CqlDeclaration("Rotavirus 2 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Rotavirus_2_Dose_Immunizations_or_Procedures() => 
		__Rotavirus_2_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.Rotavirus_Vaccine__3_dose_schedule_();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization ThreeDoseRotavirusVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType q_ = ThreeDoseRotavirusVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization ThreeDoseRotavirusVaccine)
		{
			DataType v_ = ThreeDoseRotavirusVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Rotavirus_Vaccine__3_dose_schedule__Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure ThreeDoseRotavirusAdministered)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType ad_ = ThreeDoseRotavirusAdministered?.Performed;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.ToInterval(ae_);
			CqlInterval<CqlDate> ag_ = CQMCommon_2_0_000.ToDateInterval(af_);
			bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDate>(ac_, ag_, "day");

			return ah_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure ThreeDoseRotavirusAdministered)
		{
			DataType ai_ = ThreeDoseRotavirusAdministered?.Performed;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.ToInterval(aj_);
			CqlInterval<CqlDate> al_ = CQMCommon_2_0_000.ToDateInterval(ak_);
			CqlDate am_ = context.Operators.Start(al_);
			CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
			CqlDate ao_ = context.Operators.DateFrom(an_);

			return ao_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Rotavirus 3 Dose Immunizations or Procedures")]
	public IEnumerable<CqlDate> Rotavirus_3_Dose_Immunizations_or_Procedures() => 
		__Rotavirus_3_Dose_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Rotavirus_2_Dose_Immunizations_or_Procedures();
		IEnumerable<CqlDate> b_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures();
		IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Rotavirus 2 or 3 Dose Immunizations")]
	public IEnumerable<CqlDate> Rotavirus_2_or_3_Dose_Immunizations() => 
		__Rotavirus_2_or_3_Dose_Immunizations.Value;

	private IEnumerable<CqlDate> All_Rotavirus_Vaccinations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Rotavirus_2_or_3_Dose_Immunizations();
		IEnumerable<CqlDate> c_(CqlDate AllRotavirusDoses1)
		{
			IEnumerable<CqlDate> f_ = this.Rotavirus_2_or_3_Dose_Immunizations();
			bool? g_(CqlDate AllRotavirusDoses2)
			{
				CqlQuantity k_ = context.Operators.Quantity(1m, "day");
				CqlDate l_ = context.Operators.Subtract(AllRotavirusDoses2, k_);
				CqlInterval<CqlDate> m_ = context.Operators.Interval(l_, AllRotavirusDoses2, false, false);
				bool? n_ = context.Operators.In<CqlDate>(AllRotavirusDoses1, m_, default);

				return n_;
			};
			IEnumerable<CqlDate> h_ = context.Operators.Where<CqlDate>(f_, g_);
			CqlDate i_(CqlDate AllRotavirusDoses2) => 
				AllRotavirusDoses1;
			IEnumerable<CqlDate> j_ = context.Operators.Select<CqlDate, CqlDate>(h_, i_);

			return j_;
		};
		IEnumerable<CqlDate> d_ = context.Operators.SelectMany<CqlDate, CqlDate>(a_, c_);
		IEnumerable<CqlDate> e_ = context.Operators.Except<CqlDate>(a_, d_);

		return e_;
	}

    [CqlDeclaration("All Rotavirus Vaccinations")]
	public IEnumerable<CqlDate> All_Rotavirus_Vaccinations() => 
		__All_Rotavirus_Vaccinations.Value;

	private bool? Has_Appropriate_Number_of_Rotavirus_Immunizations_Value()
	{
		IEnumerable<CqlDate> a_ = this.All_Rotavirus_Vaccinations();
		bool? b_(CqlDate RotavirusImmunization)
		{
			IEnumerable<CqlDate> e_ = this.Rotavirus_3_Dose_Immunizations_or_Procedures();
			int? f_ = context.Operators.Count<CqlDate>(e_);
			bool? g_ = context.Operators.Greater(f_, 0);
			IEnumerable<CqlDate> h_ = this.All_Rotavirus_Vaccinations();
			CqlDate i_(CqlDate RotavirusVaccinations) => 
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

    [CqlDeclaration("Has Appropriate Number of Rotavirus Immunizations")]
	public bool? Has_Appropriate_Number_of_Rotavirus_Immunizations() => 
		__Has_Appropriate_Number_of_Rotavirus_Immunizations.Value;

	private IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions_Value()
	{
		CqlCode a_ = this.Anaphylaxis_due_to_rotavirus_vaccine__disorder_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition RotavirusConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(RotavirusConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Rotavirus Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Rotavirus_Numerator_Inclusion_Conditions() => 
		__Rotavirus_Numerator_Inclusion_Conditions.Value;

	private CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlDateTime e_ = context.Operators.ConvertDateToDateTime(d_);
		CqlDate f_ = context.Operators.DateFrom(e_);
		CqlQuantity g_ = context.Operators.Quantity(180m, "days");
		CqlDate h_ = context.Operators.Add(f_, g_);
		CqlDate i_ = this.Date_of_Second_Birthday();
		CqlInterval<CqlDate> j_ = context.Operators.Interval(h_, i_, true, true);

		return j_;
	}

    [CqlDeclaration("Vaccine Administration Interval - 180 Days up to 2 Years Old")]
	public CqlInterval<CqlDate> Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old() => 
		__Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old.Value;

	private IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures_Value()
	{
		CqlValueSet a_ = this.Child_Influenza_Immunization_Administered();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization InfluenzaVaccine)
		{
			CqlInterval<CqlDate> p_ = this.Vaccine_Administration_Interval___42_Days_up_to_2_Years_Old();
			DataType q_ = InfluenzaVaccine?.Occurrence;
			CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
			CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.ToInterval(r_ as object);
			CqlInterval<CqlDate> t_ = CQMCommon_2_0_000.ToDateInterval(s_);
			bool? u_ = context.Operators.IntervalIncludesInterval<CqlDate>(p_, t_, "day");

			return u_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization InfluenzaVaccine)
		{
			DataType v_ = InfluenzaVaccine?.Occurrence;
			CqlDateTime w_ = context.Operators.LateBoundProperty<CqlDateTime>(v_, "value");
			CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.ToInterval(w_ as object);
			CqlInterval<CqlDate> y_ = CQMCommon_2_0_000.ToDateInterval(x_);
			CqlDate z_ = context.Operators.Start(y_);
			CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
			CqlDate ab_ = context.Operators.DateFrom(aa_);

			return ab_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Child_Influenza_Vaccine_Administered();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure InfluenzaAdministration)
		{
			CqlInterval<CqlDate> ac_ = this.Vaccine_Administration_Interval___180_Days_up_to_2_Years_Old();
			CqlDate ad_ = ac_?.low;
			CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
			CqlDate ag_ = ac_?.high;
			CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
			bool? aj_ = ac_?.lowClosed;
			bool? al_ = ac_?.highClosed;
			CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ae_, ah_, aj_, al_);
			DataType an_ = InfluenzaAdministration?.Performed;
			object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
			CqlInterval<CqlDateTime> ap_ = QICoreCommon_2_0_000.ToInterval(ao_);
			bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(am_, ap_, "day");

			return aq_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure InfluenzaAdministration)
		{
			DataType ar_ = InfluenzaAdministration?.Performed;
			object as_ = FHIRHelpers_4_3_000.ToValue(ar_);
			CqlInterval<CqlDateTime> at_ = QICoreCommon_2_0_000.ToInterval(as_);
			CqlInterval<CqlDate> au_ = CQMCommon_2_0_000.ToDateInterval(at_);
			CqlDate av_ = context.Operators.Start(au_);
			CqlDateTime aw_ = context.Operators.ConvertDateToDateTime(av_);
			CqlDate ax_ = context.Operators.DateFrom(aw_);

			return ax_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("Influenza Immunizations or Procedures")]
	public IEnumerable<CqlDate> Influenza_Immunizations_or_Procedures() => 
		__Influenza_Immunizations_or_Procedures.Value;

	private IEnumerable<CqlDate> Two_Influenza_Vaccinations_Value()
	{
		IEnumerable<CqlDate> a_ = this.Influenza_Immunizations_or_Procedures();
		IEnumerable<ValueTuple<CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);
		(CqlDate FluVaccination1, CqlDate FluVaccination2)? d_(ValueTuple<CqlDate, CqlDate> _valueTuple)
		{
			(CqlDate FluVaccination1, CqlDate FluVaccination2)? j_ = (_valueTuple.Item1, _valueTuple.Item2);

			return j_;
		};
		IEnumerable<(CqlDate FluVaccination1, CqlDate FluVaccination2)?> e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlDate FluVaccination1, CqlDate FluVaccination2)?>(c_, d_);
		bool? f_((CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq)
		{
			CqlQuantity k_ = context.Operators.Quantity(1m, "day");
			CqlDate l_ = context.Operators.Add(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1, k_);
			bool? m_ = context.Operators.SameOrAfter(tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination2, l_, "day");

			return m_;
		};
		IEnumerable<(CqlDate FluVaccination1, CqlDate FluVaccination2)?> g_ = context.Operators.Where<(CqlDate FluVaccination1, CqlDate FluVaccination2)?>(e_, f_);
		CqlDate h_((CqlDate FluVaccination1, CqlDate FluVaccination2)? tuple_bzhflerdagbpqmnhevjcunfnq) => 
			tuple_bzhflerdagbpqmnhevjcunfnq?.FluVaccination1;
		IEnumerable<CqlDate> i_ = context.Operators.Select<(CqlDate FluVaccination1, CqlDate FluVaccination2)?, CqlDate>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Two Influenza Vaccinations")]
	public IEnumerable<CqlDate> Two_Influenza_Vaccinations() => 
		__Two_Influenza_Vaccinations.Value;

	private IEnumerable<CqlDate> LAIV_Vaccinations_Value()
	{
		CqlValueSet a_ = this.Influenza_Virus_LAIV_Immunization();
		IEnumerable<Immunization> b_ = context.Operators.Retrieve<Immunization>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-immunization"));
		IEnumerable<Immunization> c_ = Status_1_6_000.Completed_Immunization(b_);
		bool? d_(Immunization LAIVVaccine)
		{
			CqlDate p_ = this.Date_of_Second_Birthday();
			CqlInterval<CqlDate> r_ = context.Operators.Interval(p_, p_, true, true);
			DataType s_ = LAIVVaccine?.Occurrence;
			CqlDateTime t_ = context.Operators.LateBoundProperty<CqlDateTime>(s_, "value");
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.ToInterval(t_ as object);
			CqlInterval<CqlDate> v_ = CQMCommon_2_0_000.ToDateInterval(u_);
			bool? w_ = context.Operators.IntervalIncludesInterval<CqlDate>(r_, v_, "day");

			return w_;
		};
		IEnumerable<Immunization> e_ = context.Operators.Where<Immunization>(c_, d_);
		CqlDate f_(Immunization LAIVVaccine)
		{
			DataType x_ = LAIVVaccine?.Occurrence;
			CqlDateTime y_ = context.Operators.LateBoundProperty<CqlDateTime>(x_, "value");
			CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.ToInterval(y_ as object);
			CqlInterval<CqlDate> aa_ = CQMCommon_2_0_000.ToDateInterval(z_);
			CqlDate ab_ = context.Operators.Start(aa_);
			CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(ab_);
			CqlDate ad_ = context.Operators.DateFrom(ac_);

			return ad_;
		};
		IEnumerable<CqlDate> g_ = context.Operators.Select<Immunization, CqlDate>(e_, f_);
		CqlValueSet h_ = this.Influenza_Virus_LAIV_Procedure();
		IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> j_ = Status_1_6_000.Completed_Procedure(i_);
		bool? k_(Procedure InfluenzaAdministration)
		{
			CqlDate ae_ = this.Date_of_Second_Birthday();
			CqlInterval<CqlDate> ag_ = context.Operators.Interval(ae_, ae_, true, true);
			DataType ah_ = InfluenzaAdministration?.Performed;
			object ai_ = FHIRHelpers_4_3_000.ToValue(ah_);
			CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_0_000.ToInterval(ai_);
			CqlInterval<CqlDate> ak_ = CQMCommon_2_0_000.ToDateInterval(aj_);
			bool? al_ = context.Operators.IntervalIncludesInterval<CqlDate>(ag_, ak_, "day");

			return al_;
		};
		IEnumerable<Procedure> l_ = context.Operators.Where<Procedure>(j_, k_);
		CqlDate m_(Procedure InfluenzaAdministration)
		{
			DataType am_ = InfluenzaAdministration?.Performed;
			object an_ = FHIRHelpers_4_3_000.ToValue(am_);
			CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.ToInterval(an_);
			CqlInterval<CqlDate> ap_ = CQMCommon_2_0_000.ToDateInterval(ao_);
			CqlDate aq_ = context.Operators.Start(ap_);
			CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
			CqlDate as_ = context.Operators.DateFrom(ar_);

			return as_;
		};
		IEnumerable<CqlDate> n_ = context.Operators.Select<Procedure, CqlDate>(l_, m_);
		IEnumerable<CqlDate> o_ = context.Operators.Union<CqlDate>(g_, n_);

		return o_;
	}

    [CqlDeclaration("LAIV Vaccinations")]
	public IEnumerable<CqlDate> LAIV_Vaccinations() => 
		__LAIV_Vaccinations.Value;

	private bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination_Value()
	{
		IEnumerable<CqlDate> a_ = this.LAIV_Vaccinations();
		bool? b_ = context.Operators.Exists<CqlDate>(a_);
		IEnumerable<CqlDate> c_ = this.Influenza_Immunizations_or_Procedures();
		bool? d_ = context.Operators.Exists<CqlDate>(c_);
		bool? e_ = context.Operators.And(b_, d_);

		return e_;
	}

    [CqlDeclaration("Two Influenza Vaccinations Including One LAIV Vaccination")]
	public bool? Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination() => 
		__Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination.Value;

	private IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions_Value()
	{
		CqlCode a_ = this.Anaphylaxis_caused_by_vaccine_product_containing_Influenza_virus_antigen__disorder_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> d_ = Status_1_6_000.Active_Condition(c_);
		bool? e_(Condition InfluenzaConditions)
		{
			CqlInterval<CqlDateTime> g_ = QICoreCommon_2_0_000.ToPrevalenceInterval(InfluenzaConditions);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			CqlInterval<CqlDate> j_ = this.First_Two_Years();
			bool? k_ = context.Operators.In<CqlDate>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Influenza Numerator Inclusion Conditions")]
	public IEnumerable<Condition> Influenza_Numerator_Inclusion_Conditions() => 
		__Influenza_Numerator_Inclusion_Conditions.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<CqlDate> a_ = this.Four_DTaP_Vaccinations();
		bool? b_ = context.Operators.Exists<CqlDate>(a_);
		IEnumerable<Condition> c_ = this.DTaP_Numerator_Inclusion_Conditions();
		bool? d_ = context.Operators.Exists<Condition>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<CqlDate> f_ = this.Three_Polio_Vaccinations();
		bool? g_ = context.Operators.Exists<CqlDate>(f_);
		IEnumerable<Condition> h_ = this.Polio_Numerator_Inclusion_Conditions();
		bool? i_ = context.Operators.Exists<Condition>(h_);
		bool? j_ = context.Operators.Or(g_, i_);
		bool? k_ = context.Operators.And(e_, j_);
		IEnumerable<object> l_ = this.One_MMR_Vaccination();
		bool? m_ = context.Operators.Exists<object>(l_);
		IEnumerable<Condition> n_ = this.MMR_Numerator_Inclusion_Conditions();
		bool? o_ = context.Operators.Exists<Condition>(n_);
		bool? p_ = context.Operators.Or(m_, o_);
		IEnumerable<Condition> q_ = this.Measles_Indicators();
		bool? r_ = context.Operators.Exists<Condition>(q_);
		IEnumerable<Condition> s_ = this.Mumps_Indicators();
		bool? t_ = context.Operators.Exists<Condition>(s_);
		bool? u_ = context.Operators.And(r_, t_);
		IEnumerable<Condition> v_ = this.Rubella_Indicators();
		bool? w_ = context.Operators.Exists<Condition>(v_);
		bool? x_ = context.Operators.And(u_, w_);
		bool? y_ = context.Operators.Or(p_, x_);
		bool? z_ = context.Operators.And(k_, y_);
		bool? aa_ = this.Has_Appropriate_Number_of_Hib_Immunizations();
		IEnumerable<Condition> ab_ = this.Hib_Numerator_Inclusion_Conditions();
		bool? ac_ = context.Operators.Exists<Condition>(ab_);
		bool? ad_ = context.Operators.Or(aa_, ac_);
		bool? ae_ = context.Operators.And(z_, ad_);
		IEnumerable<CqlDate> af_ = this.Three_Hepatitis_B_Vaccinations();
		bool? ag_ = context.Operators.Exists<CqlDate>(af_);
		IEnumerable<CqlDate> ah_ = this.Meets_HepB_Vaccination_Requirement();
		bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
		IEnumerable<Condition> aj_ = this.Hepatitis_B_Numerator_Inclusion_Conditions();
		bool? ak_ = context.Operators.Exists<Condition>(aj_);
		bool? al_ = context.Operators.Or(ai_, ak_);
		bool? am_ = context.Operators.Or(ag_, al_);
		bool? an_ = context.Operators.And(ae_, am_);
		IEnumerable<object> ao_ = this.One_Chicken_Pox_Vaccination();
		bool? ap_ = context.Operators.Exists<object>(ao_);
		IEnumerable<Condition> aq_ = this.Varicella_Zoster_Numerator_Inclusion_Conditions();
		bool? ar_ = context.Operators.Exists<Condition>(aq_);
		bool? as_ = context.Operators.Or(ap_, ar_);
		bool? at_ = context.Operators.And(an_, as_);
		IEnumerable<CqlDate> au_ = this.Four_Pneumococcal_Conjugate_Vaccinations();
		bool? av_ = context.Operators.Exists<CqlDate>(au_);
		IEnumerable<Condition> aw_ = this.Pneumococcal_Conjugate_Numerator_Inclusion_Conditions();
		bool? ax_ = context.Operators.Exists<Condition>(aw_);
		bool? ay_ = context.Operators.Or(av_, ax_);
		bool? az_ = context.Operators.And(at_, ay_);
		IEnumerable<object> ba_ = this.One_Hepatitis_A_Vaccinations();
		bool? bb_ = context.Operators.Exists<object>(ba_);
		IEnumerable<Condition> bc_ = this.Hepatitis_A_Numerator_Inclusion_Conditions();
		bool? bd_ = context.Operators.Exists<Condition>(bc_);
		bool? be_ = context.Operators.Or(bb_, bd_);
		bool? bf_ = context.Operators.And(az_, be_);
		bool? bg_ = this.Has_Appropriate_Number_of_Rotavirus_Immunizations();
		IEnumerable<Condition> bh_ = this.Rotavirus_Numerator_Inclusion_Conditions();
		bool? bi_ = context.Operators.Exists<Condition>(bh_);
		bool? bj_ = context.Operators.Or(bg_, bi_);
		bool? bk_ = context.Operators.And(bf_, bj_);
		IEnumerable<CqlDate> bl_ = this.Two_Influenza_Vaccinations();
		bool? bm_ = context.Operators.Exists<CqlDate>(bl_);
		bool? bn_ = this.Two_Influenza_Vaccinations_Including_One_LAIV_Vaccination();
		bool? bo_ = context.Operators.Or(bm_, bn_);
		IEnumerable<Condition> bp_ = this.Influenza_Numerator_Inclusion_Conditions();
		bool? bq_ = context.Operators.Exists<Condition>(bp_);
		bool? br_ = context.Operators.Or(bo_, bq_);
		bool? bs_ = context.Operators.And(bk_, br_);

		return bs_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
