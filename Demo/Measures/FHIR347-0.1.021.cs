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
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

		return a_;
	}

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit() => __Annual_Wellness_Visit.Value;

    private CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", null);

		return a_;
	}

    [CqlDeclaration("Atherosclerosis and Peripheral Arterial Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21")]
    public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease() => __Atherosclerosis_and_Peripheral_Arterial_Disease.Value;

    private CqlValueSet Breastfeeding_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", null);

		return a_;
	}

    [CqlDeclaration("Breastfeeding")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73")]
    public CqlValueSet Breastfeeding() => __Breastfeeding.Value;

    private CqlValueSet CABG_Surgeries_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", null);

		return a_;
	}

    [CqlDeclaration("CABG Surgeries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694")]
    public CqlValueSet CABG_Surgeries() => __CABG_Surgeries.Value;

    private CqlValueSet CABG__PCI_Procedure_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", null);

		return a_;
	}

    [CqlDeclaration("CABG, PCI Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566")]
    public CqlValueSet CABG__PCI_Procedure() => __CABG__PCI_Procedure.Value;

    private CqlValueSet Carotid_Intervention_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", null);

		return a_;
	}

    [CqlDeclaration("Carotid Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204")]
    public CqlValueSet Carotid_Intervention() => __Carotid_Intervention.Value;

    private CqlValueSet Cerebrovascular_Disease__Stroke__TIA_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", null);

		return a_;
	}

    [CqlDeclaration("Cerebrovascular Disease, Stroke, TIA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44")]
    public CqlValueSet Cerebrovascular_Disease__Stroke__TIA() => __Cerebrovascular_Disease__Stroke__TIA.Value;

    private CqlValueSet Diabetes_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet End_Stage_Renal_Disease_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

		return a_;
	}

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
    public CqlValueSet End_Stage_Renal_Disease() => __End_Stage_Renal_Disease.Value;

    private CqlValueSet Hepatitis_A_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);

		return a_;
	}

    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
    public CqlValueSet Hepatitis_A() => __Hepatitis_A.Value;

    private CqlValueSet Hepatitis_B_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", null);

		return a_;
	}

    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269")]
    public CqlValueSet Hepatitis_B() => __Hepatitis_B.Value;

    private CqlValueSet High_Intensity_Statin_Therapy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", null);

		return a_;
	}

    [CqlDeclaration("High Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572")]
    public CqlValueSet High_Intensity_Statin_Therapy() => __High_Intensity_Statin_Therapy.Value;

    private CqlValueSet Hospice_Care_Ambulatory_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

		return a_;
	}

    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
    public CqlValueSet Hospice_Care_Ambulatory() => __Hospice_Care_Ambulatory.Value;

    private CqlValueSet Hypercholesterolemia_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", null);

		return a_;
	}

    [CqlDeclaration("Hypercholesterolemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100")]
    public CqlValueSet Hypercholesterolemia() => __Hypercholesterolemia.Value;

    private CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", null);

		return a_;
	}

    [CqlDeclaration("Ischemic Heart Disease or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46")]
    public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses() => __Ischemic_Heart_Disease_or_Other_Related_Diagnoses.Value;

    private CqlValueSet LDL_Cholesterol_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", null);

		return a_;
	}

    [CqlDeclaration("LDL Cholesterol")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573")]
    public CqlValueSet LDL_Cholesterol() => __LDL_Cholesterol.Value;

    private CqlValueSet Liver_Disease_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", null);

		return a_;
	}

    [CqlDeclaration("Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42")]
    public CqlValueSet Liver_Disease() => __Liver_Disease.Value;

    private CqlValueSet Low_Intensity_Statin_Therapy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", null);

		return a_;
	}

    [CqlDeclaration("Low Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574")]
    public CqlValueSet Low_Intensity_Statin_Therapy() => __Low_Intensity_Statin_Therapy.Value;

    private CqlValueSet Moderate_Intensity_Statin_Therapy_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", null);

		return a_;
	}

    [CqlDeclaration("Moderate Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575")]
    public CqlValueSet Moderate_Intensity_Statin_Therapy() => __Moderate_Intensity_Statin_Therapy.Value;

    private CqlValueSet Myocardial_Infarction_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", null);

		return a_;
	}

    [CqlDeclaration("Myocardial Infarction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403")]
    public CqlValueSet Myocardial_Infarction() => __Myocardial_Infarction.Value;

    private CqlValueSet Office_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Outpatient_Consultation_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

		return a_;
	}

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation() => __Outpatient_Consultation.Value;

    private CqlValueSet Outpatient_Encounters_for_Preventive_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", null);

		return a_;
	}

    [CqlDeclaration("Outpatient Encounters for Preventive Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576")]
    public CqlValueSet Outpatient_Encounters_for_Preventive_Care() => __Outpatient_Encounters_for_Preventive_Care.Value;

    private CqlValueSet Palliative_Care_Encounter_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", null);

		return a_;
	}

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575")]
    public CqlValueSet Palliative_Care_Encounter() => __Palliative_Care_Encounter.Value;

    private CqlValueSet Palliative_or_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

		return a_;
	}

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
    public CqlValueSet Palliative_or_Hospice_Care() => __Palliative_or_Hospice_Care.Value;

    private CqlValueSet PCI_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", null);

		return a_;
	}

    [CqlDeclaration("PCI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67")]
    public CqlValueSet PCI() => __PCI.Value;

    private CqlValueSet Pregnancy_or_Other_Related_Diagnoses_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", null);

		return a_;
	}

    [CqlDeclaration("Pregnancy or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623")]
    public CqlValueSet Pregnancy_or_Other_Related_Diagnoses() => __Pregnancy_or_Other_Related_Diagnoses.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services___Other_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services - Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
    public CqlValueSet Preventive_Care_Services___Other() => __Preventive_Care_Services___Other.Value;

    private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling() => __Preventive_Care_Services_Individual_Counseling.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Rhabdomyolysis_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", null);

		return a_;
	}

    [CqlDeclaration("Rhabdomyolysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102")]
    public CqlValueSet Rhabdomyolysis() => __Rhabdomyolysis.Value;

    private CqlValueSet Stable_and_Unstable_Angina_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", null);

		return a_;
	}

    [CqlDeclaration("Stable and Unstable Angina")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47")]
    public CqlValueSet Stable_and_Unstable_Angina() => __Stable_and_Unstable_Angina.Value;

    private CqlValueSet Statin_Allergen_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", null);

		return a_;
	}

    [CqlDeclaration("Statin Allergen")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42")]
    public CqlValueSet Statin_Allergen() => __Statin_Allergen.Value;

    private CqlValueSet Statin_Associated_Muscle_Symptoms_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", null);

		return a_;
	}

    [CqlDeclaration("Statin Associated Muscle Symptoms")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85")]
    public CqlValueSet Statin_Associated_Muscle_Symptoms() => __Statin_Associated_Muscle_Symptoms.Value;

    private CqlCode Encounter_for_palliative_care_Value()
	{
		var a_ = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

		return a_;
	}

    [CqlDeclaration("Encounter for palliative care")]
    public CqlCode Encounter_for_palliative_care() => __Encounter_for_palliative_care.Value;

    private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("ICD10CM")]
    public CqlCode[] ICD10CM() => __ICD10CM.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);
		var b_ = (CqlInterval<CqlDateTime>)a_;

		return b_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Value()
	{
		var a_ = this.Myocardial_Infarction();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = this.Cerebrovascular_Disease__Stroke__TIA();
		var f_ = b_.RetrieveByValueSet<Condition>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Condition>(c_, f_);
		var i_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease();
		var k_ = b_.RetrieveByValueSet<Condition>(i_, null);
		var l_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses();
		var n_ = b_.RetrieveByValueSet<Condition>(l_, null);
		var p_ = g_.ListUnion<Condition>(k_, n_);
		var r_ = g_.ListUnion<Condition>(h_, p_);
		var s_ = this.Stable_and_Unstable_Angina();
		var u_ = b_.RetrieveByValueSet<Condition>(s_, null);
		var w_ = g_.ListUnion<Condition>(r_, u_);
		var x_ = (Condition ASCVDDiagnosis) =>
		{
			var az_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ASCVDDiagnosis);
			var ba_ = context.Operators;
			var bb_ = ba_.Start(az_);
			var bc_ = this.Measurement_Period();
			var be_ = ba_.End(bc_);
			var bg_ = ba_.Before(bb_, be_, null);

			return bg_;
		};
		var z_ = g_.WhereOrNull<Condition>(w_, x_);
		var aa_ = (z_ as IEnumerable<object>);
		var ab_ = this.PCI();
		var ad_ = b_.RetrieveByValueSet<Procedure>(ab_, null);
		var ae_ = this.CABG_Surgeries();
		var ag_ = b_.RetrieveByValueSet<Procedure>(ae_, null);
		var ai_ = g_.ListUnion<Procedure>(ad_, ag_);
		var aj_ = this.Carotid_Intervention();
		var al_ = b_.RetrieveByValueSet<Procedure>(aj_, null);
		var am_ = this.CABG__PCI_Procedure();
		var ao_ = b_.RetrieveByValueSet<Procedure>(am_, null);
		var aq_ = g_.ListUnion<Procedure>(al_, ao_);
		var as_ = g_.ListUnion<Procedure>(ai_, aq_);
		var at_ = (Procedure ASCVDProcedure) =>
		{
			var bh_ = ASCVDProcedure.Performed;
			var bi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bh_);
			var bj_ = context.Operators;
			var bk_ = bj_.Start(bi_);
			var bl_ = this.Measurement_Period();
			var bn_ = bj_.End(bl_);
			var bp_ = bj_.Before(bk_, bn_, null);
			var bq_ = ASCVDProcedure.StatusElement;
			var br_ = new CallStackEntry("ToString", null, null);
			var bs_ = context.Deeper(br_);
			var bt_ = bs_.Operators;
			var bu_ = bt_.TypeConverter;
			var bv_ = bu_.Convert<string>(bq_);
			var bx_ = bj_.Equal(bv_, "completed");
			var bz_ = bj_.And(bp_, bx_);

			return bz_;
		};
		var av_ = g_.WhereOrNull<Procedure>(as_, at_);
		var aw_ = (av_ as IEnumerable<object>);
		var ay_ = g_.ListUnion<object>(aa_, aw_);

		return ay_;
	}

    [CqlDeclaration("ASCVD Diagnosis or Procedure before End of Measurement Period")]
    public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period() => __ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
	{
		var a_ = this.Annual_Wellness_Visit();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Office_Visit();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		var i_ = this.Outpatient_Consultation();
		var k_ = b_.RetrieveByValueSet<Encounter>(i_, null);
		var l_ = this.Outpatient_Encounters_for_Preventive_Care();
		var n_ = b_.RetrieveByValueSet<Encounter>(l_, null);
		var p_ = g_.ListUnion<Encounter>(k_, n_);
		var r_ = g_.ListUnion<Encounter>(h_, p_);
		var s_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var u_ = b_.RetrieveByValueSet<Encounter>(s_, null);
		var v_ = this.Preventive_Care_Services___Other();
		var x_ = b_.RetrieveByValueSet<Encounter>(v_, null);
		var z_ = g_.ListUnion<Encounter>(u_, x_);
		var ab_ = g_.ListUnion<Encounter>(r_, z_);
		var ac_ = this.Preventive_Care_Services_Individual_Counseling();
		var ae_ = b_.RetrieveByValueSet<Encounter>(ac_, null);
		var af_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var ah_ = b_.RetrieveByValueSet<Encounter>(af_, null);
		var aj_ = g_.ListUnion<Encounter>(ae_, ah_);
		var al_ = g_.ListUnion<Encounter>(ab_, aj_);
		var am_ = (Encounter ValidEncounter) =>
		{
			var ap_ = this.Measurement_Period();
			var aq_ = ValidEncounter.Period;
			var ar_ = FHIRHelpers_4_0_001.ToInterval(aq_);
			var as_ = context.Operators;
			var at_ = as_.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, null);
			var au_ = ValidEncounter.StatusElement;
			var av_ = new CallStackEntry("ToString", null, null);
			var aw_ = context.Deeper(av_);
			var ax_ = aw_.Operators;
			var ay_ = ax_.TypeConverter;
			var az_ = ay_.Convert<string>(au_);
			var bb_ = as_.Equal(az_, "finished");
			var bd_ = as_.And(at_, bb_);

			return bd_;
		};
		var ao_ = g_.WhereOrNull<Encounter>(al_, am_);

		return ao_;
	}

    [CqlDeclaration("Qualifying Encounter during Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period() => __Qualifying_Encounter_during_Measurement_Period.Value;

    private bool? Initial_Population_1_Value()
	{
		var a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<object>(a_);
		var d_ = this.Qualifying_Encounter_during_Measurement_Period();
		var f_ = b_.ExistsInList<Encounter>(d_);
		var h_ = b_.And(c_, f_);

		return h_;
	}

    [CqlDeclaration("Initial Population 1")]
    public bool? Initial_Population_1() => __Initial_Population_1.Value;

    private bool? Denominator_1_Value()
	{
		var a_ = this.Initial_Population_1();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
    public bool? Denominator_1() => __Denominator_1.Value;

    private bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.ConvertStringToDateTime(c_);
		var f_ = this.Measurement_Period();
		var h_ = d_.Start(f_);
		var j_ = d_.CalculateAgeAt(e_, h_, "year");
		var k_ = j_;
		var l_ = (int?)20;
		var m_ = l_;
		var o_ = d_.GreaterOrEqual(k_, m_);

		return o_;
	}

    [CqlDeclaration("Patients Age 20 or Older at Start of Measurement Period")]
    public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period() => __Patients_Age_20_or_Older_at_Start_of_Measurement_Period.Value;

    private IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190_Value()
	{
		var a_ = this.LDL_Cholesterol();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation LDL) =>
		{
			var g_ = LDL.Value;
			var h_ = (g_ as Quantity);
			var i_ = FHIRHelpers_4_0_001.ToQuantity(h_);
			var j_ = context.Operators;
			var k_ = j_.Quantity(190m, "mg/dL");
			var m_ = j_.GreaterOrEqual(i_, k_);
			var n_ = LDL.Effective;
			var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(n_);
			var q_ = j_.Start(o_);
			var r_ = this.Measurement_Period();
			var t_ = j_.End(r_);
			var v_ = j_.Before(q_, t_, null);
			var x_ = j_.And(m_, v_);
			var y_ = LDL.StatusElement;
			var z_ = new CallStackEntry("ToString", null, null);
			var aa_ = context.Deeper(z_);
			var ab_ = aa_.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = ac_.Convert<string>(y_);
			var ae_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var af_ = (ae_ as IEnumerable<string>);
			var ah_ = j_.InList<string>(ad_, af_);
			var aj_ = j_.And(x_, ah_);

			return aj_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);

		return f_;
	}

    [CqlDeclaration("LDL Result Greater Than or Equal To 190")]
    public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190() => __LDL_Result_Greater_Than_or_Equal_To_190.Value;

    private IEnumerable<Condition> Hypercholesterolemia_Diagnosis_Value()
	{
		var a_ = this.Hypercholesterolemia();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = (Condition Hypercholesterolemia) =>
		{
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Hypercholesterolemia);
			var h_ = context.Operators;
			var i_ = h_.Start(g_);
			var j_ = this.Measurement_Period();
			var l_ = h_.End(j_);
			var n_ = h_.Before(i_, l_, null);

			return n_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Condition>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Hypercholesterolemia Diagnosis")]
    public IEnumerable<Condition> Hypercholesterolemia_Diagnosis() => __Hypercholesterolemia_Diagnosis.Value;

    private bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Value()
	{
		var a_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period();
		var b_ = this.LDL_Result_Greater_Than_or_Equal_To_190();
		var c_ = (b_ as IEnumerable<object>);
		var d_ = this.Hypercholesterolemia_Diagnosis();
		var e_ = (d_ as IEnumerable<object>);
		var f_ = context.Operators;
		var g_ = f_.ListUnion<object>(c_, e_);
		var i_ = f_.ExistsInList<object>(g_);
		var k_ = f_.And(a_, i_);
		var l_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		var n_ = f_.ExistsInList<object>(l_);
		var p_ = f_.Not(n_);
		var r_ = f_.And(k_, p_);

		return r_;
	}

    [CqlDeclaration("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
    public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD() => __Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD.Value;

    private bool? Initial_Population_2_Value()
	{
		var a_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD();
		var b_ = this.Qualifying_Encounter_during_Measurement_Period();
		var c_ = context.Operators;
		var d_ = c_.ExistsInList<Encounter>(b_);
		var f_ = c_.And(a_, d_);

		return f_;
	}

    [CqlDeclaration("Initial Population 2")]
    public bool? Initial_Population_2() => __Initial_Population_2.Value;

    private bool? Denominator_2_Value()
	{
		var a_ = this.Initial_Population_2();

		return a_;
	}

    [CqlDeclaration("Denominator 2")]
    public bool? Denominator_2() => __Denominator_2.Value;

    private bool? Has_Diabetes_Diagnosis_Value()
	{
		var a_ = this.Diabetes();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = (Condition Diabetes) =>
		{
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Diabetes);
			var j_ = this.Measurement_Period();
			var k_ = context.Operators;
			var l_ = k_.Overlaps(i_, j_, null);

			return l_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Condition>(c_, d_);
		var h_ = e_.ExistsInList<Condition>(f_);

		return h_;
	}

    [CqlDeclaration("Has Diabetes Diagnosis")]
    public bool? Has_Diabetes_Diagnosis() => __Has_Diabetes_Diagnosis.Value;

    private bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.ConvertStringToDateTime(c_);
		var f_ = this.Measurement_Period();
		var h_ = d_.Start(f_);
		var j_ = d_.CalculateAgeAt(e_, h_, "year");
		var k_ = (int?)40;
		var l_ = (int?)75;
		var n_ = d_.Interval(k_, l_, true, true);
		var p_ = d_.ElementInInterval<int?>(j_, n_, null);
		var q_ = this.Has_Diabetes_Diagnosis();
		var s_ = d_.And(p_, q_);
		var t_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		var v_ = d_.ExistsInList<object>(t_);
		var x_ = d_.Not(v_);
		var z_ = d_.And(s_, x_);
		var aa_ = this.LDL_Result_Greater_Than_or_Equal_To_190();
		var ac_ = d_.ExistsInList<Observation>(aa_);
		var ae_ = d_.Not(ac_);
		var ag_ = d_.And(z_, ae_);
		var ah_ = this.Hypercholesterolemia_Diagnosis();
		var aj_ = d_.ExistsInList<Condition>(ah_);
		var al_ = d_.Not(aj_);
		var an_ = d_.And(ag_, al_);

		return an_;
	}

    [CqlDeclaration("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
    public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia() => __Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia.Value;

    private bool? Initial_Population_3_Value()
	{
		var a_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia();
		var b_ = this.Qualifying_Encounter_during_Measurement_Period();
		var c_ = context.Operators;
		var d_ = c_.ExistsInList<Encounter>(b_);
		var f_ = c_.And(a_, d_);

		return f_;
	}

    [CqlDeclaration("Initial Population 3")]
    public bool? Initial_Population_3() => __Initial_Population_3.Value;

    private bool? Denominator_3_Value()
	{
		var a_ = this.Initial_Population_3();

		return a_;
	}

    [CqlDeclaration("Denominator 3")]
    public bool? Denominator_3() => __Denominator_3.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private bool? Has_Allergy_to_Statin_Value()
	{
		var a_ = this.Statin_Allergen();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<AllergyIntolerance>(a_, null);
		var d_ = (AllergyIntolerance StatinAllergy) =>
		{
			var i_ = StatinAllergy.Onset;
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(i_);
			var k_ = context.Operators;
			var l_ = k_.Start(j_);
			var m_ = this.Measurement_Period();
			var o_ = k_.End(m_);
			var q_ = k_.Before(l_, o_, null);

			return q_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<AllergyIntolerance>(c_, d_);
		var h_ = e_.ExistsInList<AllergyIntolerance>(f_);

		return h_;
	}

    [CqlDeclaration("Has Allergy to Statin")]
    public bool? Has_Allergy_to_Statin() => __Has_Allergy_to_Statin.Value;

    private bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care_Value()
	{
		var a_ = this.Hospice_Care_Ambulatory();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<ServiceRequest>(a_, null);
		var d_ = this.Palliative_or_Hospice_Care();
		var f_ = b_.RetrieveByValueSet<ServiceRequest>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<ServiceRequest>(c_, f_);
		var i_ = (ServiceRequest PalliativeOrHospiceCareOrder) =>
		{
			var ao_ = PalliativeOrHospiceCareOrder.AuthoredOnElement;
			var ap_ = FHIRHelpers_4_0_001.ToDateTime(ao_);
			var aq_ = this.Measurement_Period();
			var ar_ = context.Operators;
			var as_ = ar_.End(aq_);
			var au_ = ar_.SameOrBefore(ap_, as_, null);
			var av_ = PalliativeOrHospiceCareOrder.StatusElement;
			var aw_ = new CallStackEntry("ToString", null, null);
			var ax_ = context.Deeper(aw_);
			var ay_ = ax_.Operators;
			var az_ = ay_.TypeConverter;
			var ba_ = az_.Convert<string>(av_);
			var bb_ = new string[]
			{
				"active",
				"on-hold",
				"completed",
			};
			var bc_ = (bb_ as IEnumerable<string>);
			var be_ = ar_.InList<string>(ba_, bc_);
			var bg_ = ar_.And(au_, be_);
			var bh_ = PalliativeOrHospiceCareOrder.IntentElement;
			var bj_ = context.Deeper(aw_);
			var bk_ = bj_.Operators;
			var bl_ = bk_.TypeConverter;
			var bm_ = bl_.Convert<string>(bh_);
			var bo_ = ar_.Equal(bm_, "order");
			var bq_ = ar_.And(bg_, bo_);

			return bq_;
		};
		var k_ = g_.WhereOrNull<ServiceRequest>(h_, i_);
		var m_ = g_.ExistsInList<ServiceRequest>(k_);
		var p_ = b_.RetrieveByValueSet<Procedure>(a_, null);
		var s_ = b_.RetrieveByValueSet<Procedure>(d_, null);
		var u_ = g_.ListUnion<Procedure>(p_, s_);
		var v_ = (Procedure PalliativeOrHospiceCarePerformed) =>
		{
			var br_ = PalliativeOrHospiceCarePerformed.Performed;
			var bs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(br_);
			var bt_ = context.Operators;
			var bu_ = bt_.Start(bs_);
			var bv_ = this.Measurement_Period();
			var bx_ = bt_.End(bv_);
			var bz_ = bt_.SameOrBefore(bu_, bx_, null);
			var ca_ = PalliativeOrHospiceCarePerformed.StatusElement;
			var cb_ = new CallStackEntry("ToString", null, null);
			var cc_ = context.Deeper(cb_);
			var cd_ = cc_.Operators;
			var ce_ = cd_.TypeConverter;
			var cf_ = ce_.Convert<string>(ca_);
			var ch_ = bt_.Equal(cf_, "completed");
			var cj_ = bt_.And(bz_, ch_);

			return cj_;
		};
		var x_ = g_.WhereOrNull<Procedure>(u_, v_);
		var z_ = g_.ExistsInList<Procedure>(x_);
		var ab_ = g_.Or(m_, z_);
		var ac_ = this.Encounter_for_palliative_care();
		var ae_ = g_.ToList<CqlCode>(ac_);
		var ag_ = b_.RetrieveByCodes<Encounter>(ae_, null);
		var ah_ = (Encounter PalliativeEncounter) =>
		{
			var ck_ = PalliativeEncounter.Period;
			var cl_ = FHIRHelpers_4_0_001.ToInterval(ck_);
			var cm_ = context.Operators;
			var cn_ = cm_.Start(cl_);
			var co_ = this.Measurement_Period();
			var cq_ = cm_.End(co_);
			var cs_ = cm_.SameOrBefore(cn_, cq_, null);
			var ct_ = PalliativeEncounter.StatusElement;
			var cu_ = new CallStackEntry("ToString", null, null);
			var cv_ = context.Deeper(cu_);
			var cw_ = cv_.Operators;
			var cx_ = cw_.TypeConverter;
			var cy_ = cx_.Convert<string>(ct_);
			var da_ = cm_.Equal(cy_, "finished");
			var dc_ = cm_.And(cs_, da_);

			return dc_;
		};
		var aj_ = g_.WhereOrNull<Encounter>(ag_, ah_);
		var al_ = g_.ExistsInList<Encounter>(aj_);
		var an_ = g_.Or(ab_, al_);

		return an_;
	}

    [CqlDeclaration("Has Order or Receiving Hospice Care or Palliative Care")]
    public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care() => __Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care.Value;

    private bool? Has_Hepatitis_or_Liver_Disease_Diagnosis_Value()
	{
		var a_ = this.Hepatitis_A();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = this.Hepatitis_B();
		var f_ = b_.RetrieveByValueSet<Condition>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Condition>(c_, f_);
		var i_ = this.Liver_Disease();
		var k_ = b_.RetrieveByValueSet<Condition>(i_, null);
		var m_ = g_.ListUnion<Condition>(h_, k_);
		var n_ = (Condition HepatitisLiverDisease) =>
		{
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(HepatitisLiverDisease);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators;
			var v_ = u_.Overlaps(s_, t_, null);

			return v_;
		};
		var p_ = g_.WhereOrNull<Condition>(m_, n_);
		var r_ = g_.ExistsInList<Condition>(p_);

		return r_;
	}

    [CqlDeclaration("Has Hepatitis or Liver Disease Diagnosis")]
    public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis() => __Has_Hepatitis_or_Liver_Disease_Diagnosis.Value;

    private bool? Has_Statin_Associated_Muscle_Symptoms_Value()
	{
		var a_ = this.Statin_Associated_Muscle_Symptoms();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = (Condition StatinMuscleSymptom) =>
		{
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(StatinMuscleSymptom);
			var j_ = context.Operators;
			var k_ = j_.Start(i_);
			var l_ = this.Measurement_Period();
			var n_ = j_.End(l_);
			var p_ = j_.Before(k_, n_, null);

			return p_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Condition>(c_, d_);
		var h_ = e_.ExistsInList<Condition>(f_);

		return h_;
	}

    [CqlDeclaration("Has Statin Associated Muscle Symptoms")]
    public bool? Has_Statin_Associated_Muscle_Symptoms() => __Has_Statin_Associated_Muscle_Symptoms.Value;

    private bool? Has_ESRD_Diagnosis_Value()
	{
		var a_ = this.End_Stage_Renal_Disease();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = (Condition ESRD) =>
		{
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ESRD);
			var j_ = this.Measurement_Period();
			var k_ = context.Operators;
			var l_ = k_.Overlaps(i_, j_, null);

			return l_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Condition>(c_, d_);
		var h_ = e_.ExistsInList<Condition>(f_);

		return h_;
	}

    [CqlDeclaration("Has ESRD Diagnosis")]
    public bool? Has_ESRD_Diagnosis() => __Has_ESRD_Diagnosis.Value;

    private bool? Has_Adverse_Reaction_to_Statin_Value()
	{
		var a_ = this.Statin_Allergen();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<AdverseEvent>(a_, null);
		var d_ = (AdverseEvent StatinReaction) =>
		{
			var i_ = StatinReaction.DateElement;
			var j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators;
			var m_ = l_.ElementInInterval<CqlDateTime>(j_, k_, null);

			return m_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<AdverseEvent>(c_, d_);
		var h_ = e_.ExistsInList<AdverseEvent>(f_);

		return h_;
	}

    [CqlDeclaration("Has Adverse Reaction to Statin")]
    public bool? Has_Adverse_Reaction_to_Statin() => __Has_Adverse_Reaction_to_Statin.Value;

    private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Has_Allergy_to_Statin();
		var b_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care();
		var c_ = context.Operators;
		var d_ = c_.Or(a_, b_);
		var e_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis();
		var g_ = c_.Or(d_, e_);
		var h_ = this.Has_Statin_Associated_Muscle_Symptoms();
		var j_ = c_.Or(g_, h_);
		var k_ = this.Has_ESRD_Diagnosis();
		var m_ = c_.Or(j_, k_);
		var n_ = this.Has_Adverse_Reaction_to_Statin();
		var p_ = c_.Or(m_, n_);

		return p_;
	}

    [CqlDeclaration("Denominator Exceptions")]
    public bool? Denominator_Exceptions() => __Denominator_Exceptions.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = this.Pregnancy_or_Other_Related_Diagnoses();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Condition>(a_, null);
		var d_ = this.Breastfeeding();
		var f_ = b_.RetrieveByValueSet<Condition>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Condition>(c_, f_);
		var i_ = this.Rhabdomyolysis();
		var k_ = b_.RetrieveByValueSet<Condition>(i_, null);
		var m_ = g_.ListUnion<Condition>(h_, k_);
		var n_ = (Condition ExclusionDiagnosis) =>
		{
			var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ExclusionDiagnosis);
			var t_ = this.Measurement_Period();
			var u_ = context.Operators;
			var v_ = u_.Overlaps(s_, t_, null);

			return v_;
		};
		var p_ = g_.WhereOrNull<Condition>(m_, n_);
		var r_ = g_.ExistsInList<Condition>(p_);

		return r_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period_Value()
	{
		var a_ = this.Low_Intensity_Statin_Therapy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		var f_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<MedicationRequest>(c_, f_);
		var i_ = this.Moderate_Intensity_Statin_Therapy();
		var k_ = b_.RetrieveByValueSet<MedicationRequest>(i_, null);
		var n_ = b_.RetrieveByValueSet<MedicationRequest>(i_, null);
		var p_ = g_.ListUnion<MedicationRequest>(k_, n_);
		var r_ = g_.ListUnion<MedicationRequest>(h_, p_);
		var s_ = this.High_Intensity_Statin_Therapy();
		var u_ = b_.RetrieveByValueSet<MedicationRequest>(s_, null);
		var x_ = b_.RetrieveByValueSet<MedicationRequest>(s_, null);
		var z_ = g_.ListUnion<MedicationRequest>(u_, x_);
		var ab_ = g_.ListUnion<MedicationRequest>(r_, z_);
		var ac_ = (MedicationRequest StatinOrdered) =>
		{
			var af_ = StatinOrdered.AuthoredOnElement;
			var ag_ = FHIRHelpers_4_0_001.ToDateTime(af_);
			var ah_ = this.Measurement_Period();
			var ai_ = context.Operators;
			var aj_ = ai_.ElementInInterval<CqlDateTime>(ag_, ah_, null);
			var ak_ = StatinOrdered.StatusElement;
			var al_ = new CallStackEntry("ToString", null, null);
			var am_ = context.Deeper(al_);
			var an_ = am_.Operators;
			var ao_ = an_.TypeConverter;
			var ap_ = ao_.Convert<string>(ak_);
			var aq_ = new string[]
			{
				"active",
				"completed",
			};
			var ar_ = (aq_ as IEnumerable<string>);
			var at_ = ai_.InList<string>(ap_, ar_);
			var av_ = ai_.And(aj_, at_);
			var aw_ = StatinOrdered.IntentElement;
			var ay_ = context.Deeper(al_);
			var az_ = ay_.Operators;
			var ba_ = az_.TypeConverter;
			var bb_ = ba_.Convert<string>(aw_);
			var bd_ = ai_.Equal(bb_, "order");
			var bf_ = ai_.And(av_, bd_);

			return bf_;
		};
		var ae_ = g_.WhereOrNull<MedicationRequest>(ab_, ac_);

		return ae_;
	}

    [CqlDeclaration("Statin Therapy Ordered during Measurement Period")]
    public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period() => __Statin_Therapy_Ordered_during_Measurement_Period.Value;

    private IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period_Value()
	{
		var a_ = this.Low_Intensity_Statin_Therapy();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		var f_ = b_.RetrieveByValueSet<MedicationRequest>(a_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<MedicationRequest>(c_, f_);
		var i_ = this.Moderate_Intensity_Statin_Therapy();
		var k_ = b_.RetrieveByValueSet<MedicationRequest>(i_, null);
		var n_ = b_.RetrieveByValueSet<MedicationRequest>(i_, null);
		var p_ = g_.ListUnion<MedicationRequest>(k_, n_);
		var r_ = g_.ListUnion<MedicationRequest>(h_, p_);
		var s_ = this.High_Intensity_Statin_Therapy();
		var u_ = b_.RetrieveByValueSet<MedicationRequest>(s_, null);
		var x_ = b_.RetrieveByValueSet<MedicationRequest>(s_, null);
		var z_ = g_.ListUnion<MedicationRequest>(u_, x_);
		var ab_ = g_.ListUnion<MedicationRequest>(r_, z_);
		var ac_ = (MedicationRequest ActiveStatin) =>
		{
			var af_ = ActiveStatin.DosageInstruction;
			var ag_ = (Dosage @this) =>
			{
				var bd_ = @this.Timing;
				var be_ = (bd_ == null);
				var bf_ = (bool?)be_;
				var bg_ = context.Operators;
				var bh_ = bg_.Not(bf_);

				return bh_;
			};
			var ah_ = context.Operators;
			var ai_ = ah_.WhereOrNull<Dosage>(af_, ag_);
			var aj_ = (Dosage @this) =>
			{
				var bi_ = @this.Timing;

				return bi_;
			};
			var al_ = ah_.SelectOrNull<Dosage, Timing>(ai_, aj_);
			var am_ = (Timing T) =>
			{
				var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(((((T.Repeat.Bounds is Range as bool?) ?? false))
						? ((T.Repeat.Bounds as Range))
						: (((((T.Repeat.Bounds is Period as bool?) ?? false))
								? ((T.Repeat.Bounds as Period))
								: (null))
))
);
				var bk_ = this.Measurement_Period();
				var bl_ = context.Operators;
				var bm_ = bl_.Overlaps(bj_, bk_, null);

				return bm_;
			};
			var ao_ = ah_.WhereOrNull<Timing>(al_, am_);
			var aq_ = ah_.ExistsInList<Timing>(ao_);
			var ar_ = ActiveStatin.StatusElement;
			var as_ = new CallStackEntry("ToString", null, null);
			var at_ = context.Deeper(as_);
			var au_ = at_.Operators;
			var av_ = au_.TypeConverter;
			var aw_ = av_.Convert<string>(ar_);
			var ax_ = new string[]
			{
				"active",
				"completed",
			};
			var ay_ = (ax_ as IEnumerable<string>);
			var ba_ = ah_.InList<string>(aw_, ay_);
			var bc_ = ah_.And(aq_, ba_);

			return bc_;
		};
		var ae_ = g_.WhereOrNull<MedicationRequest>(ab_, ac_);

		return ae_;
	}

    [CqlDeclaration("Prescribed Statin Therapy Any Time during Measurement Period")]
    public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period() => __Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Statin_Therapy_Ordered_during_Measurement_Period();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<MedicationRequest>(a_);
		var d_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period();
		var f_ = b_.ExistsInList<MedicationRequest>(d_);
		var h_ = b_.Or(c_, f_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}