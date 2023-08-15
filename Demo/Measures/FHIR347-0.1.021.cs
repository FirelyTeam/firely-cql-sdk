using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("FHIR347", "0.1.021")]
public class FHIR347_0_1_021
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Atherosclerosis_and_Peripheral_Arterial_Disease;
    internal Lazy<CqlValueSet> __Breastfeeding;
    internal Lazy<CqlValueSet> __CABG_Surgeries;
    internal Lazy<CqlValueSet> __CABG__PCI_Procedure;
    internal Lazy<CqlValueSet> __Carotid_Intervention;
    internal Lazy<CqlValueSet> __Cerebrovascular_Disease__Stroke__TIA;
    internal Lazy<CqlValueSet> __Diabetes;
    internal Lazy<CqlValueSet> __End_Stage_Renal_Disease;
    internal Lazy<CqlValueSet> __Hepatitis_A;
    internal Lazy<CqlValueSet> __Hepatitis_B;
    internal Lazy<CqlValueSet> __High_Intensity_Statin_Therapy;
    internal Lazy<CqlValueSet> __Hospice_Care_Ambulatory;
    internal Lazy<CqlValueSet> __Hypercholesterolemia;
    internal Lazy<CqlValueSet> __Ischemic_Heart_Disease_or_Other_Related_Diagnoses;
    internal Lazy<CqlValueSet> __LDL_Cholesterol;
    internal Lazy<CqlValueSet> __Liver_Disease;
    internal Lazy<CqlValueSet> __Low_Intensity_Statin_Therapy;
    internal Lazy<CqlValueSet> __Moderate_Intensity_Statin_Therapy;
    internal Lazy<CqlValueSet> __Myocardial_Infarction;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Outpatient_Encounters_for_Preventive_Care;
    internal Lazy<CqlValueSet> __Palliative_Care_Encounter;
    internal Lazy<CqlValueSet> __Palliative_or_Hospice_Care;
    internal Lazy<CqlValueSet> __PCI;
    internal Lazy<CqlValueSet> __Pregnancy_or_Other_Related_Diagnoses;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Other;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Individual_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Rhabdomyolysis;
    internal Lazy<CqlValueSet> __Stable_and_Unstable_Angina;
    internal Lazy<CqlValueSet> __Statin_Allergen;
    internal Lazy<CqlValueSet> __Statin_Associated_Muscle_Symptoms;
    internal Lazy<CqlCode> __Encounter_for_palliative_care;
    internal Lazy<CqlCode[]> __ICD10CM;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<object>> __ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_during_Measurement_Period;
    internal Lazy<bool?> __Initial_Population_1;
    internal Lazy<bool?> __Denominator_1;
    internal Lazy<bool?> __Patients_Age_20_or_Older_at_Start_of_Measurement_Period;
    internal Lazy<IEnumerable<Observation>> __LDL_Result_Greater_Than_or_Equal_To_190;
    internal Lazy<IEnumerable<Condition>> __Hypercholesterolemia_Diagnosis;
    internal Lazy<bool?> __Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD;
    internal Lazy<bool?> __Initial_Population_2;
    internal Lazy<bool?> __Denominator_2;
    internal Lazy<bool?> __Has_Diabetes_Diagnosis;
    internal Lazy<bool?> __Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia;
    internal Lazy<bool?> __Initial_Population_3;
    internal Lazy<bool?> __Denominator_3;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<bool?> __Has_Allergy_to_Statin;
    internal Lazy<bool?> __Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care;
    internal Lazy<bool?> __Has_Hepatitis_or_Liver_Disease_Diagnosis;
    internal Lazy<bool?> __Has_Statin_Associated_Muscle_Symptoms;
    internal Lazy<bool?> __Has_ESRD_Diagnosis;
    internal Lazy<bool?> __Has_Adverse_Reaction_to_Statin;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<MedicationRequest>> __Statin_Therapy_Ordered_during_Measurement_Period;
    internal Lazy<IEnumerable<MedicationRequest>> __Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period;
    internal Lazy<bool?> __Numerator;

    #endregion
    public FHIR347_0_1_021(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Atherosclerosis_and_Peripheral_Arterial_Disease = new Lazy<CqlValueSet>(this.Atherosclerosis_and_Peripheral_Arterial_Disease_Value);
        __Breastfeeding = new Lazy<CqlValueSet>(this.Breastfeeding_Value);
        __CABG_Surgeries = new Lazy<CqlValueSet>(this.CABG_Surgeries_Value);
        __CABG__PCI_Procedure = new Lazy<CqlValueSet>(this.CABG__PCI_Procedure_Value);
        __Carotid_Intervention = new Lazy<CqlValueSet>(this.Carotid_Intervention_Value);
        __Cerebrovascular_Disease__Stroke__TIA = new Lazy<CqlValueSet>(this.Cerebrovascular_Disease__Stroke__TIA_Value);
        __Diabetes = new Lazy<CqlValueSet>(this.Diabetes_Value);
        __End_Stage_Renal_Disease = new Lazy<CqlValueSet>(this.End_Stage_Renal_Disease_Value);
        __Hepatitis_A = new Lazy<CqlValueSet>(this.Hepatitis_A_Value);
        __Hepatitis_B = new Lazy<CqlValueSet>(this.Hepatitis_B_Value);
        __High_Intensity_Statin_Therapy = new Lazy<CqlValueSet>(this.High_Intensity_Statin_Therapy_Value);
        __Hospice_Care_Ambulatory = new Lazy<CqlValueSet>(this.Hospice_Care_Ambulatory_Value);
        __Hypercholesterolemia = new Lazy<CqlValueSet>(this.Hypercholesterolemia_Value);
        __Ischemic_Heart_Disease_or_Other_Related_Diagnoses = new Lazy<CqlValueSet>(this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses_Value);
        __LDL_Cholesterol = new Lazy<CqlValueSet>(this.LDL_Cholesterol_Value);
        __Liver_Disease = new Lazy<CqlValueSet>(this.Liver_Disease_Value);
        __Low_Intensity_Statin_Therapy = new Lazy<CqlValueSet>(this.Low_Intensity_Statin_Therapy_Value);
        __Moderate_Intensity_Statin_Therapy = new Lazy<CqlValueSet>(this.Moderate_Intensity_Statin_Therapy_Value);
        __Myocardial_Infarction = new Lazy<CqlValueSet>(this.Myocardial_Infarction_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Outpatient_Encounters_for_Preventive_Care = new Lazy<CqlValueSet>(this.Outpatient_Encounters_for_Preventive_Care_Value);
        __Palliative_Care_Encounter = new Lazy<CqlValueSet>(this.Palliative_Care_Encounter_Value);
        __Palliative_or_Hospice_Care = new Lazy<CqlValueSet>(this.Palliative_or_Hospice_Care_Value);
        __PCI = new Lazy<CqlValueSet>(this.PCI_Value);
        __Pregnancy_or_Other_Related_Diagnoses = new Lazy<CqlValueSet>(this.Pregnancy_or_Other_Related_Diagnoses_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services___Other = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Other_Value);
        __Preventive_Care_Services_Individual_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Individual_Counseling_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Rhabdomyolysis = new Lazy<CqlValueSet>(this.Rhabdomyolysis_Value);
        __Stable_and_Unstable_Angina = new Lazy<CqlValueSet>(this.Stable_and_Unstable_Angina_Value);
        __Statin_Allergen = new Lazy<CqlValueSet>(this.Statin_Allergen_Value);
        __Statin_Associated_Muscle_Symptoms = new Lazy<CqlValueSet>(this.Statin_Associated_Muscle_Symptoms_Value);
        __Encounter_for_palliative_care = new Lazy<CqlCode>(this.Encounter_for_palliative_care_Value);
        __ICD10CM = new Lazy<CqlCode[]>(this.ICD10CM_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period = new Lazy<IEnumerable<object>>(this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Value);
        __Qualifying_Encounter_during_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_during_Measurement_Period_Value);
        __Initial_Population_1 = new Lazy<bool?>(this.Initial_Population_1_Value);
        __Denominator_1 = new Lazy<bool?>(this.Denominator_1_Value);
        __Patients_Age_20_or_Older_at_Start_of_Measurement_Period = new Lazy<bool?>(this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period_Value);
        __LDL_Result_Greater_Than_or_Equal_To_190 = new Lazy<IEnumerable<Observation>>(this.LDL_Result_Greater_Than_or_Equal_To_190_Value);
        __Hypercholesterolemia_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Hypercholesterolemia_Diagnosis_Value);
        __Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD = new Lazy<bool?>(this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Value);
        __Initial_Population_2 = new Lazy<bool?>(this.Initial_Population_2_Value);
        __Denominator_2 = new Lazy<bool?>(this.Denominator_2_Value);
        __Has_Diabetes_Diagnosis = new Lazy<bool?>(this.Has_Diabetes_Diagnosis_Value);
        __Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia = new Lazy<bool?>(this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Value);
        __Initial_Population_3 = new Lazy<bool?>(this.Initial_Population_3_Value);
        __Denominator_3 = new Lazy<bool?>(this.Denominator_3_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Has_Allergy_to_Statin = new Lazy<bool?>(this.Has_Allergy_to_Statin_Value);
        __Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care = new Lazy<bool?>(this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care_Value);
        __Has_Hepatitis_or_Liver_Disease_Diagnosis = new Lazy<bool?>(this.Has_Hepatitis_or_Liver_Disease_Diagnosis_Value);
        __Has_Statin_Associated_Muscle_Symptoms = new Lazy<bool?>(this.Has_Statin_Associated_Muscle_Symptoms_Value);
        __Has_ESRD_Diagnosis = new Lazy<bool?>(this.Has_ESRD_Diagnosis_Value);
        __Has_Adverse_Reaction_to_Statin = new Lazy<bool?>(this.Has_Adverse_Reaction_to_Statin_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Statin_Therapy_Ordered_during_Measurement_Period = new Lazy<IEnumerable<MedicationRequest>>(this.Statin_Therapy_Ordered_during_Measurement_Period_Value);
        __Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period = new Lazy<IEnumerable<MedicationRequest>>(this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

    private CqlValueSet Annual_Wellness_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", 
			null);
    }

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit() => __Annual_Wellness_Visit.Value;

    private CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", 
			null);
    }

    [CqlDeclaration("Atherosclerosis and Peripheral Arterial Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21")]
    public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease() => __Atherosclerosis_and_Peripheral_Arterial_Disease.Value;

    private CqlValueSet Breastfeeding_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", 
			null);
    }

    [CqlDeclaration("Breastfeeding")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73")]
    public CqlValueSet Breastfeeding() => __Breastfeeding.Value;

    private CqlValueSet CABG_Surgeries_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", 
			null);
    }

    [CqlDeclaration("CABG Surgeries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694")]
    public CqlValueSet CABG_Surgeries() => __CABG_Surgeries.Value;

    private CqlValueSet CABG__PCI_Procedure_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", 
			null);
    }

    [CqlDeclaration("CABG, PCI Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566")]
    public CqlValueSet CABG__PCI_Procedure() => __CABG__PCI_Procedure.Value;

    private CqlValueSet Carotid_Intervention_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", 
			null);
    }

    [CqlDeclaration("Carotid Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204")]
    public CqlValueSet Carotid_Intervention() => __Carotid_Intervention.Value;

    private CqlValueSet Cerebrovascular_Disease__Stroke__TIA_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", 
			null);
    }

    [CqlDeclaration("Cerebrovascular Disease, Stroke, TIA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44")]
    public CqlValueSet Cerebrovascular_Disease__Stroke__TIA() => __Cerebrovascular_Disease__Stroke__TIA.Value;

    private CqlValueSet Diabetes_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", 
			null);
    }

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet End_Stage_Renal_Disease_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", 
			null);
    }

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
    public CqlValueSet End_Stage_Renal_Disease() => __End_Stage_Renal_Disease.Value;

    private CqlValueSet Hepatitis_A_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", 
			null);
    }

    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
    public CqlValueSet Hepatitis_A() => __Hepatitis_A.Value;

    private CqlValueSet Hepatitis_B_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", 
			null);
    }

    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269")]
    public CqlValueSet Hepatitis_B() => __Hepatitis_B.Value;

    private CqlValueSet High_Intensity_Statin_Therapy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", 
			null);
    }

    [CqlDeclaration("High Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572")]
    public CqlValueSet High_Intensity_Statin_Therapy() => __High_Intensity_Statin_Therapy.Value;

    private CqlValueSet Hospice_Care_Ambulatory_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", 
			null);
    }

    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
    public CqlValueSet Hospice_Care_Ambulatory() => __Hospice_Care_Ambulatory.Value;

    private CqlValueSet Hypercholesterolemia_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", 
			null);
    }

    [CqlDeclaration("Hypercholesterolemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100")]
    public CqlValueSet Hypercholesterolemia() => __Hypercholesterolemia.Value;

    private CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", 
			null);
    }

    [CqlDeclaration("Ischemic Heart Disease or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46")]
    public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses() => __Ischemic_Heart_Disease_or_Other_Related_Diagnoses.Value;

    private CqlValueSet LDL_Cholesterol_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", 
			null);
    }

    [CqlDeclaration("LDL Cholesterol")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573")]
    public CqlValueSet LDL_Cholesterol() => __LDL_Cholesterol.Value;

    private CqlValueSet Liver_Disease_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", 
			null);
    }

    [CqlDeclaration("Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42")]
    public CqlValueSet Liver_Disease() => __Liver_Disease.Value;

    private CqlValueSet Low_Intensity_Statin_Therapy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", 
			null);
    }

    [CqlDeclaration("Low Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574")]
    public CqlValueSet Low_Intensity_Statin_Therapy() => __Low_Intensity_Statin_Therapy.Value;

    private CqlValueSet Moderate_Intensity_Statin_Therapy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", 
			null);
    }

    [CqlDeclaration("Moderate Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575")]
    public CqlValueSet Moderate_Intensity_Statin_Therapy() => __Moderate_Intensity_Statin_Therapy.Value;

    private CqlValueSet Myocardial_Infarction_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", 
			null);
    }

    [CqlDeclaration("Myocardial Infarction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403")]
    public CqlValueSet Myocardial_Infarction() => __Myocardial_Infarction.Value;

    private CqlValueSet Office_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", 
			null);
    }

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Outpatient_Consultation_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", 
			null);
    }

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation() => __Outpatient_Consultation.Value;

    private CqlValueSet Outpatient_Encounters_for_Preventive_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", 
			null);
    }

    [CqlDeclaration("Outpatient Encounters for Preventive Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576")]
    public CqlValueSet Outpatient_Encounters_for_Preventive_Care() => __Outpatient_Encounters_for_Preventive_Care.Value;

    private CqlValueSet Palliative_Care_Encounter_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", 
			null);
    }

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_or_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", 
			null);
    }

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
    public CqlValueSet Palliative_or_Hospice_Care() => __Palliative_or_Hospice_Care.Value;

    private CqlValueSet PCI_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", 
			null);
    }

    [CqlDeclaration("PCI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67")]
    public CqlValueSet PCI() => __PCI.Value;

    private CqlValueSet Pregnancy_or_Other_Related_Diagnoses_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", 
			null);
    }

    [CqlDeclaration("Pregnancy or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623")]
    public CqlValueSet Pregnancy_or_Other_Related_Diagnoses() => __Pregnancy_or_Other_Related_Diagnoses.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", 
			null);
    }

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services___Other_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", 
			null);
    }

    [CqlDeclaration("Preventive Care Services - Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
    public CqlValueSet Preventive_Care_Services___Other() => __Preventive_Care_Services___Other.Value;

    private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", 
			null);
    }

    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling() => __Preventive_Care_Services_Individual_Counseling.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", 
			null);
    }

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Rhabdomyolysis_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", 
			null);
    }

    [CqlDeclaration("Rhabdomyolysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102")]
    public CqlValueSet Rhabdomyolysis() => __Rhabdomyolysis.Value;

    private CqlValueSet Stable_and_Unstable_Angina_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", 
			null);
    }

    [CqlDeclaration("Stable and Unstable Angina")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47")]
    public CqlValueSet Stable_and_Unstable_Angina() => __Stable_and_Unstable_Angina.Value;

    private CqlValueSet Statin_Allergen_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", 
			null);
    }

    [CqlDeclaration("Statin Allergen")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42")]
    public CqlValueSet Statin_Allergen() => __Statin_Allergen.Value;

    private CqlValueSet Statin_Associated_Muscle_Symptoms_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", 
			null);
    }

    [CqlDeclaration("Statin Associated Muscle Symptoms")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85")]
    public CqlValueSet Statin_Associated_Muscle_Symptoms() => __Statin_Associated_Muscle_Symptoms.Value;

    private CqlCode Encounter_for_palliative_care_Value()
    {
        return new CqlCode("Z51.5", 
			"http://hl7.org/fhir/sid/icd-10-cm", 
			null, 
			null);
    }

    [CqlDeclaration("Encounter for palliative care")]
    public CqlCode Encounter_for_palliative_care() => __Encounter_for_palliative_care.Value;

    private CqlCode[] ICD10CM_Value()
    {
        var a_ = new CqlCode("Z51.5", 
			"http://hl7.org/fhir/sid/icd-10-cm", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("ICD10CM")]
    public CqlCode[] ICD10CM() => __ICD10CM.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("FHIR347-0.1.021", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Value()
    {
        var b_ = this.Myocardial_Infarction();
        var c_ = typeof(Condition).GetProperty("Code");
        var d_ = context?.DataRetriever.RetrieveByValueSet<Condition>(b_, 
			c_);
        var e_ = this.Cerebrovascular_Disease__Stroke__TIA();
        var g_ = context?.DataRetriever.RetrieveByValueSet<Condition>(e_, 
			c_);
        var h_ = context?.Operators.ListUnion<Condition>(d_, 
			g_);
        var i_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease();
        var k_ = context?.DataRetriever.RetrieveByValueSet<Condition>(i_, 
			c_);
        var l_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses();
        var n_ = context?.DataRetriever.RetrieveByValueSet<Condition>(l_, 
			c_);
        var o_ = context?.Operators.ListUnion<Condition>(k_, 
			n_);
        var p_ = context?.Operators.ListUnion<Condition>(h_, 
			o_);
        var q_ = this.Stable_and_Unstable_Angina();
        var s_ = context?.DataRetriever.RetrieveByValueSet<Condition>(q_, 
			c_);
        var t_ = context?.Operators.ListUnion<Condition>(p_, 
			s_);
        Func<Condition,bool?> y_ = (ASCVDDiagnosis) => 
        {
            var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ASCVDDiagnosis);
            var u_ = (context?.Operators.Start(v_) as object);
            var x_ = this.Measurement_Period();
            var w_ = (context?.Operators.End(x_) as object);
            return context?.Operators.Before(u_, 
				w_, 
				null);
        };
        var a_ = (context?.Operators.WhereOrNull<Condition>(t_, 
			y_) as IEnumerable<object>);
        var aa_ = this.PCI();
        var ab_ = typeof(Procedure).GetProperty("Code");
        var ac_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(aa_, 
			ab_);
        var ad_ = this.CABG_Surgeries();
        var af_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(ad_, 
			ab_);
        var ag_ = context?.Operators.ListUnion<Procedure>(ac_, 
			af_);
        var ah_ = this.Carotid_Intervention();
        var aj_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(ah_, 
			ab_);
        var ak_ = this.CABG__PCI_Procedure();
        var am_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(ak_, 
			ab_);
        var an_ = context?.Operators.ListUnion<Procedure>(aj_, 
			am_);
        var ao_ = context?.Operators.ListUnion<Procedure>(ag_, 
			an_);
        Func<Procedure,bool?> az_ = (ASCVDProcedure) => 
        {
            var aq_ = (ASCVDProcedure?.Performed as object);
            var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aq_);
            var ap_ = (context?.Operators.Start(ar_) as object);
            var at_ = this.Measurement_Period();
            var as_ = (context?.Operators.End(at_) as object);
            var au_ = context?.Operators.Before(ap_, 
				as_, 
				null);
            var aw_ = (ASCVDProcedure?.StatusElement as object);
            var av_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aw_) as object);
            var ax_ = ("completed" as object);
            var ay_ = context?.Operators.Equal(av_, 
				ax_);
            return context?.Operators.And(au_, 
				ay_);
        };
        var z_ = (context?.Operators.WhereOrNull<Procedure>(ao_, 
			az_) as IEnumerable<object>);
        return context?.Operators.ListUnion<object>(a_, 
			z_);
    }
    [CqlDeclaration("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period() => __ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
    {
        var a_ = this.Annual_Wellness_Visit();
        var b_ = typeof(Encounter).GetProperty("Type");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(a_, 
			b_);
        var d_ = this.Office_Visit();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Encounter>(c_, 
			f_);
        var h_ = this.Outpatient_Consultation();
        var j_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(h_, 
			b_);
        var k_ = this.Outpatient_Encounters_for_Preventive_Care();
        var m_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(k_, 
			b_);
        var n_ = context?.Operators.ListUnion<Encounter>(j_, 
			m_);
        var o_ = context?.Operators.ListUnion<Encounter>(g_, 
			n_);
        var p_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
        var r_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(p_, 
			b_);
        var s_ = this.Preventive_Care_Services___Other();
        var u_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(s_, 
			b_);
        var v_ = context?.Operators.ListUnion<Encounter>(r_, 
			u_);
        var w_ = context?.Operators.ListUnion<Encounter>(o_, 
			v_);
        var x_ = this.Preventive_Care_Services_Individual_Counseling();
        var z_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(x_, 
			b_);
        var aa_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
        var ac_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(aa_, 
			b_);
        var ad_ = context?.Operators.ListUnion<Encounter>(z_, 
			ac_);
        var ae_ = context?.Operators.ListUnion<Encounter>(w_, 
			ad_);
        Func<Encounter,bool?> an_ = (ValidEncounter) => 
        {
            var af_ = this.Measurement_Period();
            var ag_ = ValidEncounter?.Period;
            var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
            var ai_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(af_, 
				ah_, 
				null);
            var ak_ = (ValidEncounter?.StatusElement as object);
            var aj_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ak_) as object);
            var al_ = ("finished" as object);
            var am_ = context?.Operators.Equal(aj_, 
				al_);
            return context?.Operators.And(ai_, 
				am_);
        };
        return context?.Operators.WhereOrNull<Encounter>(ae_, 
			an_);
    }
    [CqlDeclaration("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period() => __Qualifying_Encounter_during_Measurement_Period.Value;

    private bool? Initial_Population_1_Value()
    {
        var a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
        var b_ = context?.Operators.ExistsInList<object>(a_);
        var c_ = this.Qualifying_Encounter_during_Measurement_Period();
        var d_ = context?.Operators.ExistsInList<Encounter>(c_);
        return context?.Operators.And(b_, 
			d_);
    }
    [CqlDeclaration("Initial Population 1")]
    public bool? Initial_Population_1() => __Initial_Population_1.Value;

    private bool? Denominator_1_Value()
    {
        return this.Initial_Population_1();
    }
    [CqlDeclaration("Denominator 1")]
    public bool? Denominator_1() => __Denominator_1.Value;

    private bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period_Value()
    {
        var b_ = this.Patient()?.BirthDateElement?.Value;
        var c_ = context?.Operators.ConvertStringToDateTime(b_);
        var d_ = this.Measurement_Period();
        var e_ = context?.Operators.Start(d_);
        var a_ = (context?.Operators.CalculateAgeAt(c_, 
			e_, 
			"year") as object);
        var f_ = (((int?)20) as object);
        return context?.Operators.GreaterOrEqual(a_, 
			f_);
    }
    [CqlDeclaration("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period() => __Patients_Age_20_or_Older_at_Start_of_Measurement_Period.Value;

    private IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190_Value()
    {
        var a_ = this.LDL_Cholesterol();
        var b_ = typeof(Observation).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Observation>(a_, 
			b_);
        Func<Observation,bool?> w_ = (LDL) => 
        {
            var e_ = ((LDL?.Value as object) as Quantity);
            var d_ = (FHIRHelpers_4_0_001.ToQuantity(e_) as object);
            var f_ = (context?.Operators.Quantity(190m, 
				"mg/dL") as object);
            var g_ = context?.Operators.GreaterOrEqual(d_, 
				f_);
            var i_ = (LDL?.Effective as object);
            var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
            var h_ = (context?.Operators.Start(j_) as object);
            var l_ = this.Measurement_Period();
            var k_ = (context?.Operators.End(l_) as object);
            var m_ = context?.Operators.Before(h_, 
				k_, 
				null);
            var n_ = context?.Operators.And(g_, 
				m_);
            var o_ = (LDL?.StatusElement as object);
            var p_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(o_);
            var r_ = "final";
            var s_ = "amended";
            var t_ = "corrected";
            var u_ = "appended";
            var q_ = (new string[]
			{
				r_,
				s_,
				t_,
				u_,
			} as IEnumerable<string>);
            var v_ = context?.Operators.InList<string>(p_, 
				q_);
            return context?.Operators.And(n_, 
				v_);
        };
        return context?.Operators.WhereOrNull<Observation>(c_, 
			w_);
    }
    [CqlDeclaration("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190() => __LDL_Result_Greater_Than_or_Equal_To_190.Value;

    private IEnumerable<Condition> Hypercholesterolemia_Diagnosis_Value()
    {
        var a_ = this.Hypercholesterolemia();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        Func<Condition,bool?> h_ = (Hypercholesterolemia) => 
        {
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Hypercholesterolemia);
            var d_ = (context?.Operators.Start(e_) as object);
            var g_ = this.Measurement_Period();
            var f_ = (context?.Operators.End(g_) as object);
            return context?.Operators.Before(d_, 
				f_, 
				null);
        };
        return context?.Operators.WhereOrNull<Condition>(c_, 
			h_);
    }
    [CqlDeclaration("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis() => __Hypercholesterolemia_Diagnosis.Value;

    private bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Value()
    {
        var a_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period();
        var b_ = (this.LDL_Result_Greater_Than_or_Equal_To_190() as IEnumerable<object>);
        var c_ = (this.Hypercholesterolemia_Diagnosis() as IEnumerable<object>);
        var d_ = context?.Operators.ListUnion<object>(b_, 
			c_);
        var e_ = context?.Operators.ExistsInList<object>(d_);
        var f_ = context?.Operators.And(a_, 
			e_);
        var g_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
        var h_ = context?.Operators.ExistsInList<object>(g_);
        var i_ = context?.Operators.Not(h_);
        return context?.Operators.And(f_, 
			i_);
    }
    [CqlDeclaration("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD() => __Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD.Value;

    private bool? Initial_Population_2_Value()
    {
        var a_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD();
        var b_ = this.Qualifying_Encounter_during_Measurement_Period();
        var c_ = context?.Operators.ExistsInList<Encounter>(b_);
        return context?.Operators.And(a_, 
			c_);
    }
    [CqlDeclaration("Initial Population 2")]
    public bool? Initial_Population_2() => __Initial_Population_2.Value;

    private bool? Denominator_2_Value()
    {
        return this.Initial_Population_2();
    }
    [CqlDeclaration("Denominator 2")]
    public bool? Denominator_2() => __Denominator_2.Value;

    private bool? Has_Diabetes_Diagnosis_Value()
    {
        var a_ = this.Diabetes();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        Func<Condition,bool?> f_ = (Diabetes) => 
        {
            var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Diabetes);
            var e_ = this.Measurement_Period();
            return context?.Operators.Overlaps(d_, 
				e_, 
				null);
        };
        var g_ = context?.Operators.WhereOrNull<Condition>(c_, 
			f_);
        return context?.Operators.ExistsInList<Condition>(g_);
    }
    [CqlDeclaration("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis() => __Has_Diabetes_Diagnosis.Value;

    private bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Value()
    {
        var a_ = this.Patient()?.BirthDateElement?.Value;
        var b_ = context?.Operators.ConvertStringToDateTime(a_);
        var c_ = this.Measurement_Period();
        var d_ = context?.Operators.Start(c_);
        var e_ = context?.Operators.CalculateAgeAt(b_, 
			d_, 
			"year");
        var f_ = context?.Operators.Interval(((int?)40), 
			((int?)75), 
			true, 
			true);
        var g_ = context?.Operators.ElementInInterval<int?>(e_, 
			f_, 
			null);
        var h_ = this.Has_Diabetes_Diagnosis();
        var i_ = context?.Operators.And(g_, 
			h_);
        var j_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
        var k_ = context?.Operators.ExistsInList<object>(j_);
        var l_ = context?.Operators.Not(k_);
        var m_ = context?.Operators.And(i_, 
			l_);
        var n_ = this.LDL_Result_Greater_Than_or_Equal_To_190();
        var o_ = context?.Operators.ExistsInList<Observation>(n_);
        var p_ = context?.Operators.Not(o_);
        var q_ = context?.Operators.And(m_, 
			p_);
        var r_ = this.Hypercholesterolemia_Diagnosis();
        var s_ = context?.Operators.ExistsInList<Condition>(r_);
        var t_ = context?.Operators.Not(s_);
        return context?.Operators.And(q_, 
			t_);
    }
    [CqlDeclaration("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia() => __Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia.Value;

    private bool? Initial_Population_3_Value()
    {
        var a_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia();
        var b_ = this.Qualifying_Encounter_during_Measurement_Period();
        var c_ = context?.Operators.ExistsInList<Encounter>(b_);
        return context?.Operators.And(a_, 
			c_);
    }
    [CqlDeclaration("Initial Population 3")]
    public bool? Initial_Population_3() => __Initial_Population_3.Value;

    private bool? Denominator_3_Value()
    {
        return this.Initial_Population_3();
    }
    [CqlDeclaration("Denominator 3")]
    public bool? Denominator_3() => __Denominator_3.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
    }
    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private bool? Has_Allergy_to_Statin_Value()
    {
        var a_ = this.Statin_Allergen();
        var b_ = typeof(AllergyIntolerance).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<AllergyIntolerance>(a_, 
			b_);
        Func<AllergyIntolerance,bool?> i_ = (StatinAllergy) => 
        {
            var e_ = (StatinAllergy?.Onset as object);
            var f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(e_);
            var d_ = (context?.Operators.Start(f_) as object);
            var h_ = this.Measurement_Period();
            var g_ = (context?.Operators.End(h_) as object);
            return context?.Operators.Before(d_, 
				g_, 
				null);
        };
        var j_ = context?.Operators.WhereOrNull<AllergyIntolerance>(c_, 
			i_);
        return context?.Operators.ExistsInList<AllergyIntolerance>(j_);
    }
    [CqlDeclaration("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin() => __Has_Allergy_to_Statin.Value;

    private bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care_Value()
    {
        var a_ = this.Hospice_Care_Ambulatory();
        var b_ = typeof(ServiceRequest).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(a_, 
			b_);
        var d_ = this.Palliative_or_Hospice_Care();
        var f_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<ServiceRequest>(c_, 
			f_);
        Func<ServiceRequest,bool?> y_ = (PalliativeOrHospiceCareOrder) => 
        {
            var h_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
            var i_ = FHIRHelpers_4_0_001.ToDateTime(h_);
            var j_ = this.Measurement_Period();
            var k_ = context?.Operators.End(j_);
            var l_ = context?.Operators.SameOrBefore(i_, 
				k_, 
				null);
            var m_ = (PalliativeOrHospiceCareOrder?.StatusElement as object);
            var n_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(m_);
            var p_ = "active";
            var q_ = "on-hold";
            var r_ = "completed";
            var o_ = (new string[]
			{
				p_,
				q_,
				r_,
			} as IEnumerable<string>);
            var s_ = context?.Operators.InList<string>(n_, 
				o_);
            var t_ = context?.Operators.And(l_, 
				s_);
            var v_ = (PalliativeOrHospiceCareOrder?.IntentElement as object);
            var u_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(v_) as object);
            var w_ = ("order" as object);
            var x_ = context?.Operators.Equal(u_, 
				w_);
            return context?.Operators.And(t_, 
				x_);
        };
        var z_ = context?.Operators.WhereOrNull<ServiceRequest>(g_, 
			y_);
        var aa_ = context?.Operators.ExistsInList<ServiceRequest>(z_);
        var ac_ = typeof(Procedure).GetProperty("Code");
        var ad_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(a_, 
			ac_);
        var ag_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(d_, 
			ac_);
        var ah_ = context?.Operators.ListUnion<Procedure>(ad_, 
			ag_);
        Func<Procedure,bool?> as_ = (PalliativeOrHospiceCarePerformed) => 
        {
            var ai_ = (PalliativeOrHospiceCarePerformed?.Performed as object);
            var aj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ai_);
            var ak_ = context?.Operators.Start(aj_);
            var al_ = this.Measurement_Period();
            var am_ = context?.Operators.End(al_);
            var an_ = context?.Operators.SameOrBefore(ak_, 
				am_, 
				null);
            var ap_ = (PalliativeOrHospiceCarePerformed?.StatusElement as object);
            var ao_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ap_) as object);
            var aq_ = ("completed" as object);
            var ar_ = context?.Operators.Equal(ao_, 
				aq_);
            return context?.Operators.And(an_, 
				ar_);
        };
        var at_ = context?.Operators.WhereOrNull<Procedure>(ah_, 
			as_);
        var au_ = context?.Operators.ExistsInList<Procedure>(at_);
        var av_ = context?.Operators.Or(aa_, 
			au_);
        var aw_ = this.Encounter_for_palliative_care();
        var ax_ = context?.Operators.ToList<CqlCode>(aw_);
        var ay_ = typeof(Encounter).GetProperty("Type");
        var az_ = context?.DataRetriever.RetrieveByCodes<Encounter>(ax_, 
			ay_);
        Func<Encounter,bool?> bk_ = (PalliativeEncounter) => 
        {
            var ba_ = PalliativeEncounter?.Period;
            var bb_ = FHIRHelpers_4_0_001.ToInterval(ba_);
            var bc_ = context?.Operators.Start(bb_);
            var bd_ = this.Measurement_Period();
            var be_ = context?.Operators.End(bd_);
            var bf_ = context?.Operators.SameOrBefore(bc_, 
				be_, 
				null);
            var bh_ = (PalliativeEncounter?.StatusElement as object);
            var bg_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(bh_) as object);
            var bi_ = ("finished" as object);
            var bj_ = context?.Operators.Equal(bg_, 
				bi_);
            return context?.Operators.And(bf_, 
				bj_);
        };
        var bl_ = context?.Operators.WhereOrNull<Encounter>(az_, 
			bk_);
        var bm_ = context?.Operators.ExistsInList<Encounter>(bl_);
        return context?.Operators.Or(av_, 
			bm_);
    }
    [CqlDeclaration("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care() => __Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care.Value;

    private bool? Has_Hepatitis_or_Liver_Disease_Diagnosis_Value()
    {
        var a_ = this.Hepatitis_A();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        var d_ = this.Hepatitis_B();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Condition>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Condition>(c_, 
			f_);
        var h_ = this.Liver_Disease();
        var j_ = context?.DataRetriever.RetrieveByValueSet<Condition>(h_, 
			b_);
        var k_ = context?.Operators.ListUnion<Condition>(g_, 
			j_);
        Func<Condition,bool?> n_ = (HepatitisLiverDisease) => 
        {
            var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(HepatitisLiverDisease);
            var m_ = this.Measurement_Period();
            return context?.Operators.Overlaps(l_, 
				m_, 
				null);
        };
        var o_ = context?.Operators.WhereOrNull<Condition>(k_, 
			n_);
        return context?.Operators.ExistsInList<Condition>(o_);
    }
    [CqlDeclaration("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis() => __Has_Hepatitis_or_Liver_Disease_Diagnosis.Value;

    private bool? Has_Statin_Associated_Muscle_Symptoms_Value()
    {
        var a_ = this.Statin_Associated_Muscle_Symptoms();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        Func<Condition,bool?> h_ = (StatinMuscleSymptom) => 
        {
            var e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(StatinMuscleSymptom);
            var d_ = (context?.Operators.Start(e_) as object);
            var g_ = this.Measurement_Period();
            var f_ = (context?.Operators.End(g_) as object);
            return context?.Operators.Before(d_, 
				f_, 
				null);
        };
        var i_ = context?.Operators.WhereOrNull<Condition>(c_, 
			h_);
        return context?.Operators.ExistsInList<Condition>(i_);
    }
    [CqlDeclaration("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms() => __Has_Statin_Associated_Muscle_Symptoms.Value;

    private bool? Has_ESRD_Diagnosis_Value()
    {
        var a_ = this.End_Stage_Renal_Disease();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        Func<Condition,bool?> f_ = (ESRD) => 
        {
            var d_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ESRD);
            var e_ = this.Measurement_Period();
            return context?.Operators.Overlaps(d_, 
				e_, 
				null);
        };
        var g_ = context?.Operators.WhereOrNull<Condition>(c_, 
			f_);
        return context?.Operators.ExistsInList<Condition>(g_);
    }
    [CqlDeclaration("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis() => __Has_ESRD_Diagnosis.Value;

    private bool? Has_Adverse_Reaction_to_Statin_Value()
    {
        var a_ = this.Statin_Allergen();
        var b_ = typeof(AdverseEvent).GetProperty("Event");
        var c_ = context?.DataRetriever.RetrieveByValueSet<AdverseEvent>(a_, 
			b_);
        Func<AdverseEvent,bool?> g_ = (StatinReaction) => 
        {
            var d_ = StatinReaction?.DateElement;
            var e_ = FHIRHelpers_4_0_001.ToDateTime(d_);
            var f_ = this.Measurement_Period();
            return context?.Operators.ElementInInterval<CqlDateTime>(e_, 
				f_, 
				null);
        };
        var h_ = context?.Operators.WhereOrNull<AdverseEvent>(c_, 
			g_);
        return context?.Operators.ExistsInList<AdverseEvent>(h_);
    }
    [CqlDeclaration("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin() => __Has_Adverse_Reaction_to_Statin.Value;

    private bool? Denominator_Exceptions_Value()
    {
        var a_ = this.Has_Allergy_to_Statin();
        var b_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care();
        var c_ = context?.Operators.Or(a_, 
			b_);
        var d_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis();
        var e_ = context?.Operators.Or(c_, 
			d_);
        var f_ = this.Has_Statin_Associated_Muscle_Symptoms();
        var g_ = context?.Operators.Or(e_, 
			f_);
        var h_ = this.Has_ESRD_Diagnosis();
        var i_ = context?.Operators.Or(g_, 
			h_);
        var j_ = this.Has_Adverse_Reaction_to_Statin();
        return context?.Operators.Or(i_, 
			j_);
    }
    [CqlDeclaration("Denominator Exceptions")]
    public bool? Denominator_Exceptions() => __Denominator_Exceptions.Value;

    private bool? Denominator_Exclusions_Value()
    {
        var a_ = this.Pregnancy_or_Other_Related_Diagnoses();
        var b_ = typeof(Condition).GetProperty("Code");
        var c_ = context?.DataRetriever.RetrieveByValueSet<Condition>(a_, 
			b_);
        var d_ = this.Breastfeeding();
        var f_ = context?.DataRetriever.RetrieveByValueSet<Condition>(d_, 
			b_);
        var g_ = context?.Operators.ListUnion<Condition>(c_, 
			f_);
        var h_ = this.Rhabdomyolysis();
        var j_ = context?.DataRetriever.RetrieveByValueSet<Condition>(h_, 
			b_);
        var k_ = context?.Operators.ListUnion<Condition>(g_, 
			j_);
        Func<Condition,bool?> n_ = (ExclusionDiagnosis) => 
        {
            var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ExclusionDiagnosis);
            var m_ = this.Measurement_Period();
            return context?.Operators.Overlaps(l_, 
				m_, 
				null);
        };
        var o_ = context?.Operators.WhereOrNull<Condition>(k_, 
			n_);
        return context?.Operators.ExistsInList<Condition>(o_);
    }
    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period_Value()
    {
        var a_ = this.Low_Intensity_Statin_Therapy();
        var b_ = typeof(MedicationRequest).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, 
			b_);
        var g_ = context?.Operators.ListUnion<MedicationRequest>(c_, 
			c_);
        var h_ = this.Moderate_Intensity_Statin_Therapy();
        var j_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(h_, 
			b_);
        var n_ = context?.Operators.ListUnion<MedicationRequest>(j_, 
			j_);
        var o_ = context?.Operators.ListUnion<MedicationRequest>(g_, 
			n_);
        var p_ = this.High_Intensity_Statin_Therapy();
        var r_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(p_, 
			b_);
        var v_ = context?.Operators.ListUnion<MedicationRequest>(r_, 
			r_);
        var w_ = context?.Operators.ListUnion<MedicationRequest>(o_, 
			v_);
        Func<MedicationRequest,bool?> am_ = (StatinOrdered) => 
        {
            var x_ = StatinOrdered?.AuthoredOnElement;
            var y_ = FHIRHelpers_4_0_001.ToDateTime(x_);
            var z_ = this.Measurement_Period();
            var aa_ = context?.Operators.ElementInInterval<CqlDateTime>(y_, 
				z_, 
				null);
            var ab_ = (StatinOrdered?.StatusElement as object);
            var ac_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ab_);
            var ae_ = "active";
            var af_ = "completed";
            var ad_ = (new string[]
			{
				ae_,
				af_,
			} as IEnumerable<string>);
            var ag_ = context?.Operators.InList<string>(ac_, 
				ad_);
            var ah_ = context?.Operators.And(aa_, 
				ag_);
            var aj_ = (StatinOrdered?.IntentElement as object);
            var ai_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aj_) as object);
            var ak_ = ("order" as object);
            var al_ = context?.Operators.Equal(ai_, 
				ak_);
            return context?.Operators.And(ah_, 
				al_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(w_, 
			am_);
    }
    [CqlDeclaration("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period() => __Statin_Therapy_Ordered_during_Measurement_Period.Value;

    private IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period_Value()
    {
        var a_ = this.Low_Intensity_Statin_Therapy();
        var b_ = typeof(MedicationRequest).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, 
			b_);
        var g_ = context?.Operators.ListUnion<MedicationRequest>(c_, 
			c_);
        var h_ = this.Moderate_Intensity_Statin_Therapy();
        var j_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(h_, 
			b_);
        var n_ = context?.Operators.ListUnion<MedicationRequest>(j_, 
			j_);
        var o_ = context?.Operators.ListUnion<MedicationRequest>(g_, 
			n_);
        var p_ = this.High_Intensity_Statin_Therapy();
        var r_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(p_, 
			b_);
        var v_ = context?.Operators.ListUnion<MedicationRequest>(r_, 
			r_);
        var w_ = context?.Operators.ListUnion<MedicationRequest>(o_, 
			v_);
        Func<MedicationRequest,bool?> ap_ = (ActiveStatin) => 
        {
            var x_ = ActiveStatin?.DosageInstruction;
            Func<Dosage,bool?> z_ = (@this) => 
            {
                bool? y_ = ((bool?)(@this?.Timing == null));
                return context?.Operators.Not(y_);
            };
            var aa_ = context?.Operators.WhereOrNull<Dosage>(x_, 
				z_);
            Func<Dosage,Timing> ab_ = (@this) => 
            {
                return @this?.Timing;
            };
            var ac_ = context?.Operators.SelectOrNull<Dosage, Timing>(aa_, 
				ab_);
            Func<Timing,bool?> ag_ = (T) => 
            {
                var ad_ = (((((T?.Repeat?.Bounds as object) is Range as bool?) ?? false))
					? ((((T?.Repeat?.Bounds as object) as Range) as object))
					: ((((((T?.Repeat?.Bounds as object) is Period as bool?) ?? false))
							? ((((T?.Repeat?.Bounds as object) as Period) as object))
							: (null))
))
;
                var ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ad_);
                var af_ = this.Measurement_Period();
                return context?.Operators.Overlaps(ae_, 
					af_, 
					null);
            };
            var ah_ = context?.Operators.WhereOrNull<Timing>(ac_, 
				ag_);
            var ai_ = context?.Operators.ExistsInList<Timing>(ah_);
            var aj_ = (ActiveStatin?.StatusElement as object);
            var ak_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(aj_);
            var am_ = "active";
            var an_ = "completed";
            var al_ = (new string[]
			{
				am_,
				an_,
			} as IEnumerable<string>);
            var ao_ = context?.Operators.InList<string>(ak_, 
				al_);
            return context?.Operators.And(ai_, 
				ao_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(w_, 
			ap_);
    }
    [CqlDeclaration("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period() => __Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period.Value;

    private bool? Numerator_Value()
    {
        var a_ = this.Statin_Therapy_Ordered_during_Measurement_Period();
        var b_ = context?.Operators.ExistsInList<MedicationRequest>(a_);
        var c_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period();
        var d_ = context?.Operators.ExistsInList<MedicationRequest>(c_);
        return context?.Operators.Or(b_, 
			d_);
    }
    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}