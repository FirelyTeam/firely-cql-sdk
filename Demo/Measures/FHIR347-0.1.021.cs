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

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", null);

    [CqlDeclaration("Atherosclerosis and Peripheral Arterial Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21")]
	public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease() => 
		__Atherosclerosis_and_Peripheral_Arterial_Disease.Value;

	private CqlValueSet Breastfeeding_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", null);

    [CqlDeclaration("Breastfeeding")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73")]
	public CqlValueSet Breastfeeding() => 
		__Breastfeeding.Value;

	private CqlValueSet CABG_Surgeries_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", null);

    [CqlDeclaration("CABG Surgeries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694")]
	public CqlValueSet CABG_Surgeries() => 
		__CABG_Surgeries.Value;

	private CqlValueSet CABG__PCI_Procedure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", null);

    [CqlDeclaration("CABG, PCI Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566")]
	public CqlValueSet CABG__PCI_Procedure() => 
		__CABG__PCI_Procedure.Value;

	private CqlValueSet Carotid_Intervention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", null);

    [CqlDeclaration("Carotid Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204")]
	public CqlValueSet Carotid_Intervention() => 
		__Carotid_Intervention.Value;

	private CqlValueSet Cerebrovascular_Disease__Stroke__TIA_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", null);

    [CqlDeclaration("Cerebrovascular Disease, Stroke, TIA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44")]
	public CqlValueSet Cerebrovascular_Disease__Stroke__TIA() => 
		__Cerebrovascular_Disease__Stroke__TIA.Value;

	private CqlValueSet Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes() => 
		__Diabetes.Value;

	private CqlValueSet End_Stage_Renal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
	public CqlValueSet End_Stage_Renal_Disease() => 
		__End_Stage_Renal_Disease.Value;

	private CqlValueSet Hepatitis_A_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", null);

    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
	public CqlValueSet Hepatitis_A() => 
		__Hepatitis_A.Value;

	private CqlValueSet Hepatitis_B_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", null);

    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269")]
	public CqlValueSet Hepatitis_B() => 
		__Hepatitis_B.Value;

	private CqlValueSet High_Intensity_Statin_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", null);

    [CqlDeclaration("High Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572")]
	public CqlValueSet High_Intensity_Statin_Therapy() => 
		__High_Intensity_Statin_Therapy.Value;

	private CqlValueSet Hospice_Care_Ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
	public CqlValueSet Hospice_Care_Ambulatory() => 
		__Hospice_Care_Ambulatory.Value;

	private CqlValueSet Hypercholesterolemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", null);

    [CqlDeclaration("Hypercholesterolemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100")]
	public CqlValueSet Hypercholesterolemia() => 
		__Hypercholesterolemia.Value;

	private CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", null);

    [CqlDeclaration("Ischemic Heart Disease or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46")]
	public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses() => 
		__Ischemic_Heart_Disease_or_Other_Related_Diagnoses.Value;

	private CqlValueSet LDL_Cholesterol_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", null);

    [CqlDeclaration("LDL Cholesterol")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573")]
	public CqlValueSet LDL_Cholesterol() => 
		__LDL_Cholesterol.Value;

	private CqlValueSet Liver_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", null);

    [CqlDeclaration("Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42")]
	public CqlValueSet Liver_Disease() => 
		__Liver_Disease.Value;

	private CqlValueSet Low_Intensity_Statin_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", null);

    [CqlDeclaration("Low Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574")]
	public CqlValueSet Low_Intensity_Statin_Therapy() => 
		__Low_Intensity_Statin_Therapy.Value;

	private CqlValueSet Moderate_Intensity_Statin_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", null);

    [CqlDeclaration("Moderate Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575")]
	public CqlValueSet Moderate_Intensity_Statin_Therapy() => 
		__Moderate_Intensity_Statin_Therapy.Value;

	private CqlValueSet Myocardial_Infarction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", null);

    [CqlDeclaration("Myocardial Infarction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403")]
	public CqlValueSet Myocardial_Infarction() => 
		__Myocardial_Infarction.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Outpatient_Encounters_for_Preventive_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", null);

    [CqlDeclaration("Outpatient Encounters for Preventive Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576")]
	public CqlValueSet Outpatient_Encounters_for_Preventive_Care() => 
		__Outpatient_Encounters_for_Preventive_Care.Value;

	private CqlValueSet Palliative_Care_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", null);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_or_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public CqlValueSet Palliative_or_Hospice_Care() => 
		__Palliative_or_Hospice_Care.Value;

	private CqlValueSet PCI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", null);

    [CqlDeclaration("PCI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67")]
	public CqlValueSet PCI() => 
		__PCI.Value;

	private CqlValueSet Pregnancy_or_Other_Related_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", null);

    [CqlDeclaration("Pregnancy or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623")]
	public CqlValueSet Pregnancy_or_Other_Related_Diagnoses() => 
		__Pregnancy_or_Other_Related_Diagnoses.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services___Other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", null);

    [CqlDeclaration("Preventive Care Services - Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
	public CqlValueSet Preventive_Care_Services___Other() => 
		__Preventive_Care_Services___Other.Value;

	private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling() => 
		__Preventive_Care_Services_Individual_Counseling.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Rhabdomyolysis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", null);

    [CqlDeclaration("Rhabdomyolysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102")]
	public CqlValueSet Rhabdomyolysis() => 
		__Rhabdomyolysis.Value;

	private CqlValueSet Stable_and_Unstable_Angina_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", null);

    [CqlDeclaration("Stable and Unstable Angina")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47")]
	public CqlValueSet Stable_and_Unstable_Angina() => 
		__Stable_and_Unstable_Angina.Value;

	private CqlValueSet Statin_Allergen_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", null);

    [CqlDeclaration("Statin Allergen")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42")]
	public CqlValueSet Statin_Allergen() => 
		__Statin_Allergen.Value;

	private CqlValueSet Statin_Associated_Muscle_Symptoms_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", null);

    [CqlDeclaration("Statin Associated Muscle Symptoms")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85")]
	public CqlValueSet Statin_Associated_Muscle_Symptoms() => 
		__Statin_Associated_Muscle_Symptoms.Value;

	private CqlCode Encounter_for_palliative_care_Value() => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care() => 
		__Encounter_for_palliative_care.Value;

	private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var f_ = context.DataRetriever;
		var g_ = this.Myocardial_Infarction();
		var h_ = f_.RetrieveByValueSet<Condition>(g_, null);
		var j_ = this.Cerebrovascular_Disease__Stroke__TIA();
		var k_ = f_.RetrieveByValueSet<Condition>(j_, null);
		var l_ = a_.ListUnion<Condition>(h_, k_);
		var o_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease();
		var p_ = f_.RetrieveByValueSet<Condition>(o_, null);
		var r_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses();
		var s_ = f_.RetrieveByValueSet<Condition>(r_, null);
		var t_ = a_.ListUnion<Condition>(p_, s_);
		var u_ = a_.ListUnion<Condition>(l_, t_);
		var w_ = this.Stable_and_Unstable_Angina();
		var x_ = f_.RetrieveByValueSet<Condition>(w_, null);
		var y_ = a_.ListUnion<Condition>(u_, x_);
		bool? z_(Condition ASCVDDiagnosis)
		{
			var ax_ = context.Operators;
			var az_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ASCVDDiagnosis);
			var ba_ = ax_.Start(az_);
			var bc_ = this.Measurement_Period();
			var bd_ = ax_.End(bc_);
			var be_ = ax_.Before(ba_, bd_, null);

			return be_;
		};
		var aa_ = a_.WhereOrNull<Condition>(y_, z_);
		var af_ = this.PCI();
		var ag_ = f_.RetrieveByValueSet<Procedure>(af_, null);
		var ai_ = this.CABG_Surgeries();
		var aj_ = f_.RetrieveByValueSet<Procedure>(ai_, null);
		var ak_ = a_.ListUnion<Procedure>(ag_, aj_);
		var an_ = this.Carotid_Intervention();
		var ao_ = f_.RetrieveByValueSet<Procedure>(an_, null);
		var aq_ = this.CABG__PCI_Procedure();
		var ar_ = f_.RetrieveByValueSet<Procedure>(aq_, null);
		var as_ = a_.ListUnion<Procedure>(ao_, ar_);
		var at_ = a_.ListUnion<Procedure>(ak_, as_);
		bool? au_(Procedure ASCVDProcedure)
		{
			var bf_ = context.Operators;
			var bi_ = ASCVDProcedure?.Performed;
			var bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bi_);
			var bk_ = bf_.Start(bj_);
			var bm_ = this.Measurement_Period();
			var bn_ = bf_.End(bm_);
			var bo_ = bf_.Before(bk_, bn_, null);
			var bq_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var br_ = bq_.Operators;
			var bs_ = br_.TypeConverter;
			var bt_ = ASCVDProcedure?.StatusElement;
			var bu_ = bs_.Convert<string>(bt_);
			var bv_ = bf_.Equal(bu_, "completed");
			var bw_ = bf_.And(bo_, bv_);

			return bw_;
		};
		var av_ = a_.WhereOrNull<Procedure>(at_, au_);
		var aw_ = a_.ListUnion<object>((aa_ as IEnumerable<object>), (av_ as IEnumerable<object>));

		return aw_;
	}

    [CqlDeclaration("ASCVD Diagnosis or Procedure before End of Measurement Period")]
	public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period() => 
		__ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var f_ = context.DataRetriever;
		var g_ = this.Annual_Wellness_Visit();
		var h_ = f_.RetrieveByValueSet<Encounter>(g_, null);
		var j_ = this.Office_Visit();
		var k_ = f_.RetrieveByValueSet<Encounter>(j_, null);
		var l_ = a_.ListUnion<Encounter>(h_, k_);
		var o_ = this.Outpatient_Consultation();
		var p_ = f_.RetrieveByValueSet<Encounter>(o_, null);
		var r_ = this.Outpatient_Encounters_for_Preventive_Care();
		var s_ = f_.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = a_.ListUnion<Encounter>(p_, s_);
		var u_ = a_.ListUnion<Encounter>(l_, t_);
		var x_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		var y_ = f_.RetrieveByValueSet<Encounter>(x_, null);
		var aa_ = this.Preventive_Care_Services___Other();
		var ab_ = f_.RetrieveByValueSet<Encounter>(aa_, null);
		var ac_ = a_.ListUnion<Encounter>(y_, ab_);
		var ad_ = a_.ListUnion<Encounter>(u_, ac_);
		var ag_ = this.Preventive_Care_Services_Individual_Counseling();
		var ah_ = f_.RetrieveByValueSet<Encounter>(ag_, null);
		var aj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var ak_ = f_.RetrieveByValueSet<Encounter>(aj_, null);
		var al_ = a_.ListUnion<Encounter>(ah_, ak_);
		var am_ = a_.ListUnion<Encounter>(ad_, al_);
		bool? an_(Encounter ValidEncounter)
		{
			var ap_ = context.Operators;
			var ar_ = this.Measurement_Period();
			var as_ = ValidEncounter?.Period;
			var at_ = FHIRHelpers_4_0_001.ToInterval(as_);
			var au_ = ap_.IntervalIncludesInterval<CqlDateTime>(ar_, at_, null);
			var aw_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ax_ = aw_.Operators;
			var ay_ = ax_.TypeConverter;
			var az_ = ValidEncounter?.StatusElement;
			var ba_ = ay_.Convert<string>(az_);
			var bb_ = ap_.Equal(ba_, "finished");
			var bc_ = ap_.And(au_, bb_);

			return bc_;
		};
		var ao_ = a_.WhereOrNull<Encounter>(am_, an_);

		return ao_;
	}

    [CqlDeclaration("Qualifying Encounter during Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period() => 
		__Qualifying_Encounter_during_Measurement_Period.Value;

	private bool? Initial_Population_1_Value()
	{
		var a_ = context.Operators;
		var c_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		var d_ = a_.ExistsInList<object>(c_);
		var f_ = this.Qualifying_Encounter_during_Measurement_Period();
		var g_ = a_.ExistsInList<Encounter>(f_);
		var h_ = a_.And(d_, g_);

		return h_;
	}

    [CqlDeclaration("Initial Population 1")]
	public bool? Initial_Population_1() => 
		__Initial_Population_1.Value;

	private bool? Denominator_1_Value()
	{
		var a_ = this.Initial_Population_1();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
	public bool? Denominator_1() => 
		__Denominator_1.Value;

	private bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var d_ = this.Patient();
		var e_ = d_?.BirthDateElement;
		var f_ = e_?.Value;
		var g_ = a_.ConvertStringToDateTime(f_);
		var i_ = this.Measurement_Period();
		var j_ = a_.Start(i_);
		var k_ = a_.CalculateAgeAt(g_, j_, "year");
		var l_ = a_.GreaterOrEqual(k_, (int?)20);

		return l_;
	}

    [CqlDeclaration("Patients Age 20 or Older at Start of Measurement Period")]
	public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period() => 
		__Patients_Age_20_or_Older_at_Start_of_Measurement_Period.Value;

	private IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.LDL_Cholesterol();
		var d_ = b_.RetrieveByValueSet<Observation>(c_, null);
		bool? e_(Observation LDL)
		{
			var g_ = context.Operators;
			var j_ = LDL?.Value;
			var k_ = FHIRHelpers_4_0_001.ToQuantity((j_ as Quantity));
			var m_ = g_.Quantity(190m, "mg/dL");
			var n_ = g_.GreaterOrEqual(k_, m_);
			var q_ = LDL?.Effective;
			var r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(q_);
			var s_ = g_.Start(r_);
			var u_ = this.Measurement_Period();
			var v_ = g_.End(u_);
			var w_ = g_.Before(s_, v_, null);
			var x_ = g_.And(n_, w_);
			var z_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var aa_ = z_.Operators;
			var ab_ = aa_.TypeConverter;
			var ac_ = LDL?.StatusElement;
			var ad_ = ab_.Convert<string>(ac_);
			var ae_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"appended",
			};
			var af_ = g_.InList<string>(ad_, (ae_ as IEnumerable<string>));
			var ag_ = g_.And(x_, af_);

			return ag_;
		};
		var f_ = a_.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("LDL Result Greater Than or Equal To 190")]
	public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190() => 
		__LDL_Result_Greater_Than_or_Equal_To_190.Value;

	private IEnumerable<Condition> Hypercholesterolemia_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Hypercholesterolemia();
		var d_ = b_.RetrieveByValueSet<Condition>(c_, null);
		bool? e_(Condition Hypercholesterolemia)
		{
			var g_ = context.Operators;
			var i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Hypercholesterolemia);
			var j_ = g_.Start(i_);
			var l_ = this.Measurement_Period();
			var m_ = g_.End(l_);
			var n_ = g_.Before(j_, m_, null);

			return n_;
		};
		var f_ = a_.WhereOrNull<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Hypercholesterolemia Diagnosis")]
	public IEnumerable<Condition> Hypercholesterolemia_Diagnosis() => 
		__Hypercholesterolemia_Diagnosis.Value;

	private bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period();
		var f_ = this.LDL_Result_Greater_Than_or_Equal_To_190();
		var g_ = this.Hypercholesterolemia_Diagnosis();
		var h_ = a_.ListUnion<object>((f_ as IEnumerable<object>), (g_ as IEnumerable<object>));
		var i_ = a_.ExistsInList<object>(h_);
		var j_ = a_.And(c_, i_);
		var m_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		var n_ = a_.ExistsInList<object>(m_);
		var o_ = a_.Not(n_);
		var p_ = a_.And(j_, o_);

		return p_;
	}

    [CqlDeclaration("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
	public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD() => 
		__Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD.Value;

	private bool? Initial_Population_2_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD();
		var d_ = this.Qualifying_Encounter_during_Measurement_Period();
		var e_ = a_.ExistsInList<Encounter>(d_);
		var f_ = a_.And(b_, e_);

		return f_;
	}

    [CqlDeclaration("Initial Population 2")]
	public bool? Initial_Population_2() => 
		__Initial_Population_2.Value;

	private bool? Denominator_2_Value()
	{
		var a_ = this.Initial_Population_2();

		return a_;
	}

    [CqlDeclaration("Denominator 2")]
	public bool? Denominator_2() => 
		__Denominator_2.Value;

	private bool? Has_Diabetes_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Diabetes();
		var e_ = c_.RetrieveByValueSet<Condition>(d_, null);
		bool? f_(Condition Diabetes)
		{
			var i_ = context.Operators;
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Diabetes);
			var k_ = this.Measurement_Period();
			var l_ = i_.Overlaps(j_, k_, null);

			return l_;
		};
		var g_ = a_.WhereOrNull<Condition>(e_, f_);
		var h_ = a_.ExistsInList<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("Has Diabetes Diagnosis")]
	public bool? Has_Diabetes_Diagnosis() => 
		__Has_Diabetes_Diagnosis.Value;

	private bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Value()
	{
		var a_ = context.Operators;
		var h_ = this.Patient();
		var i_ = h_?.BirthDateElement;
		var j_ = i_?.Value;
		var k_ = a_.ConvertStringToDateTime(j_);
		var m_ = this.Measurement_Period();
		var n_ = a_.Start(m_);
		var o_ = a_.CalculateAgeAt(k_, n_, "year");
		var q_ = a_.Interval((int?)40, (int?)75, true, true);
		var r_ = a_.ElementInInterval<int?>(o_, q_, null);
		var s_ = this.Has_Diabetes_Diagnosis();
		var t_ = a_.And(r_, s_);
		var w_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		var x_ = a_.ExistsInList<object>(w_);
		var y_ = a_.Not(x_);
		var z_ = a_.And(t_, y_);
		var ac_ = this.LDL_Result_Greater_Than_or_Equal_To_190();
		var ad_ = a_.ExistsInList<Observation>(ac_);
		var ae_ = a_.Not(ad_);
		var af_ = a_.And(z_, ae_);
		var ai_ = this.Hypercholesterolemia_Diagnosis();
		var aj_ = a_.ExistsInList<Condition>(ai_);
		var ak_ = a_.Not(aj_);
		var al_ = a_.And(af_, ak_);

		return al_;
	}

    [CqlDeclaration("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
	public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia() => 
		__Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia.Value;

	private bool? Initial_Population_3_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia();
		var d_ = this.Qualifying_Encounter_during_Measurement_Period();
		var e_ = a_.ExistsInList<Encounter>(d_);
		var f_ = a_.And(b_, e_);

		return f_;
	}

    [CqlDeclaration("Initial Population 3")]
	public bool? Initial_Population_3() => 
		__Initial_Population_3.Value;

	private bool? Denominator_3_Value()
	{
		var a_ = this.Initial_Population_3();

		return a_;
	}

    [CqlDeclaration("Denominator 3")]
	public bool? Denominator_3() => 
		__Denominator_3.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private bool? Has_Allergy_to_Statin_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Statin_Allergen();
		var e_ = c_.RetrieveByValueSet<AllergyIntolerance>(d_, null);
		bool? f_(AllergyIntolerance StatinAllergy)
		{
			var i_ = context.Operators;
			var k_ = StatinAllergy?.Onset;
			var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(k_);
			var m_ = i_.Start(l_);
			var o_ = this.Measurement_Period();
			var p_ = i_.End(o_);
			var q_ = i_.Before(m_, p_, null);

			return q_;
		};
		var g_ = a_.WhereOrNull<AllergyIntolerance>(e_, f_);
		var h_ = a_.ExistsInList<AllergyIntolerance>(g_);

		return h_;
	}

    [CqlDeclaration("Has Allergy to Statin")]
	public bool? Has_Allergy_to_Statin() => 
		__Has_Allergy_to_Statin.Value;

	private bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care_Value()
	{
		var a_ = context.Operators;
		var f_ = context.DataRetriever;
		var g_ = this.Hospice_Care_Ambulatory();
		var h_ = f_.RetrieveByValueSet<ServiceRequest>(g_, null);
		var j_ = this.Palliative_or_Hospice_Care();
		var k_ = f_.RetrieveByValueSet<ServiceRequest>(j_, null);
		var l_ = a_.ListUnion<ServiceRequest>(h_, k_);
		bool? m_(ServiceRequest PalliativeOrHospiceCareOrder)
		{
			var ao_ = context.Operators;
			var ar_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
			var as_ = FHIRHelpers_4_0_001.ToDateTime(ar_);
			var au_ = this.Measurement_Period();
			var av_ = ao_.End(au_);
			var aw_ = ao_.SameOrBefore(as_, av_, null);
			var ay_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var az_ = ay_.Operators;
			var ba_ = az_.TypeConverter;
			var bb_ = PalliativeOrHospiceCareOrder?.StatusElement;
			var bc_ = ba_.Convert<string>(bb_);
			var bd_ = new string[]
			{
				"active",
				"on-hold",
				"completed",
			};
			var be_ = ao_.InList<string>(bc_, (bd_ as IEnumerable<string>));
			var bf_ = ao_.And(aw_, be_);
			var bi_ = ay_.Operators;
			var bj_ = bi_.TypeConverter;
			var bk_ = PalliativeOrHospiceCareOrder?.IntentElement;
			var bl_ = bj_.Convert<string>(bk_);
			var bm_ = ao_.Equal(bl_, "order");
			var bn_ = ao_.And(bf_, bm_);

			return bn_;
		};
		var n_ = a_.WhereOrNull<ServiceRequest>(l_, m_);
		var o_ = a_.ExistsInList<ServiceRequest>(n_);
		var u_ = f_.RetrieveByValueSet<Procedure>(g_, null);
		var x_ = f_.RetrieveByValueSet<Procedure>(j_, null);
		var y_ = a_.ListUnion<Procedure>(u_, x_);
		bool? z_(Procedure PalliativeOrHospiceCarePerformed)
		{
			var bo_ = context.Operators;
			var br_ = PalliativeOrHospiceCarePerformed?.Performed;
			var bs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(br_);
			var bt_ = bo_.Start(bs_);
			var bv_ = this.Measurement_Period();
			var bw_ = bo_.End(bv_);
			var bx_ = bo_.SameOrBefore(bt_, bw_, null);
			var bz_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ca_ = bz_.Operators;
			var cb_ = ca_.TypeConverter;
			var cc_ = PalliativeOrHospiceCarePerformed?.StatusElement;
			var cd_ = cb_.Convert<string>(cc_);
			var ce_ = bo_.Equal(cd_, "completed");
			var cf_ = bo_.And(bx_, ce_);

			return cf_;
		};
		var aa_ = a_.WhereOrNull<Procedure>(y_, z_);
		var ab_ = a_.ExistsInList<Procedure>(aa_);
		var ac_ = a_.Or(o_, ab_);
		var ah_ = this.Encounter_for_palliative_care();
		var ai_ = a_.ToList<CqlCode>(ah_);
		var aj_ = f_.RetrieveByCodes<Encounter>(ai_, null);
		bool? ak_(Encounter PalliativeEncounter)
		{
			var cg_ = context.Operators;
			var cj_ = PalliativeEncounter?.Period;
			var ck_ = FHIRHelpers_4_0_001.ToInterval(cj_);
			var cl_ = cg_.Start(ck_);
			var cn_ = this.Measurement_Period();
			var co_ = cg_.End(cn_);
			var cp_ = cg_.SameOrBefore(cl_, co_, null);
			var cr_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var cs_ = cr_.Operators;
			var ct_ = cs_.TypeConverter;
			var cu_ = PalliativeEncounter?.StatusElement;
			var cv_ = ct_.Convert<string>(cu_);
			var cw_ = cg_.Equal(cv_, "finished");
			var cx_ = cg_.And(cp_, cw_);

			return cx_;
		};
		var al_ = a_.WhereOrNull<Encounter>(aj_, ak_);
		var am_ = a_.ExistsInList<Encounter>(al_);
		var an_ = a_.Or(ac_, am_);

		return an_;
	}

    [CqlDeclaration("Has Order or Receiving Hospice Care or Palliative Care")]
	public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care() => 
		__Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care.Value;

	private bool? Has_Hepatitis_or_Liver_Disease_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Hepatitis_A();
		var g_ = e_.RetrieveByValueSet<Condition>(f_, null);
		var i_ = this.Hepatitis_B();
		var j_ = e_.RetrieveByValueSet<Condition>(i_, null);
		var k_ = a_.ListUnion<Condition>(g_, j_);
		var m_ = this.Liver_Disease();
		var n_ = e_.RetrieveByValueSet<Condition>(m_, null);
		var o_ = a_.ListUnion<Condition>(k_, n_);
		bool? p_(Condition HepatitisLiverDisease)
		{
			var s_ = context.Operators;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(HepatitisLiverDisease);
			var u_ = this.Measurement_Period();
			var v_ = s_.Overlaps(t_, u_, null);

			return v_;
		};
		var q_ = a_.WhereOrNull<Condition>(o_, p_);
		var r_ = a_.ExistsInList<Condition>(q_);

		return r_;
	}

    [CqlDeclaration("Has Hepatitis or Liver Disease Diagnosis")]
	public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis() => 
		__Has_Hepatitis_or_Liver_Disease_Diagnosis.Value;

	private bool? Has_Statin_Associated_Muscle_Symptoms_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Statin_Associated_Muscle_Symptoms();
		var e_ = c_.RetrieveByValueSet<Condition>(d_, null);
		bool? f_(Condition StatinMuscleSymptom)
		{
			var i_ = context.Operators;
			var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(StatinMuscleSymptom);
			var l_ = i_.Start(k_);
			var n_ = this.Measurement_Period();
			var o_ = i_.End(n_);
			var p_ = i_.Before(l_, o_, null);

			return p_;
		};
		var g_ = a_.WhereOrNull<Condition>(e_, f_);
		var h_ = a_.ExistsInList<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("Has Statin Associated Muscle Symptoms")]
	public bool? Has_Statin_Associated_Muscle_Symptoms() => 
		__Has_Statin_Associated_Muscle_Symptoms.Value;

	private bool? Has_ESRD_Diagnosis_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.End_Stage_Renal_Disease();
		var e_ = c_.RetrieveByValueSet<Condition>(d_, null);
		bool? f_(Condition ESRD)
		{
			var i_ = context.Operators;
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ESRD);
			var k_ = this.Measurement_Period();
			var l_ = i_.Overlaps(j_, k_, null);

			return l_;
		};
		var g_ = a_.WhereOrNull<Condition>(e_, f_);
		var h_ = a_.ExistsInList<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("Has ESRD Diagnosis")]
	public bool? Has_ESRD_Diagnosis() => 
		__Has_ESRD_Diagnosis.Value;

	private bool? Has_Adverse_Reaction_to_Statin_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Statin_Allergen();
		var e_ = c_.RetrieveByValueSet<AdverseEvent>(d_, null);
		bool? f_(AdverseEvent StatinReaction)
		{
			var i_ = context.Operators;
			var j_ = StatinReaction?.DateElement;
			var k_ = FHIRHelpers_4_0_001.ToDateTime(j_);
			var l_ = this.Measurement_Period();
			var m_ = i_.ElementInInterval<CqlDateTime>(k_, l_, null);

			return m_;
		};
		var g_ = a_.WhereOrNull<AdverseEvent>(e_, f_);
		var h_ = a_.ExistsInList<AdverseEvent>(g_);

		return h_;
	}

    [CqlDeclaration("Has Adverse Reaction to Statin")]
	public bool? Has_Adverse_Reaction_to_Statin() => 
		__Has_Adverse_Reaction_to_Statin.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = context.Operators;
		var f_ = this.Has_Allergy_to_Statin();
		var g_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care();
		var h_ = a_.Or(f_, g_);
		var i_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis();
		var j_ = a_.Or(h_, i_);
		var k_ = this.Has_Statin_Associated_Muscle_Symptoms();
		var l_ = a_.Or(j_, k_);
		var m_ = this.Has_ESRD_Diagnosis();
		var n_ = a_.Or(l_, m_);
		var o_ = this.Has_Adverse_Reaction_to_Statin();
		var p_ = a_.Or(n_, o_);

		return p_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Pregnancy_or_Other_Related_Diagnoses();
		var g_ = e_.RetrieveByValueSet<Condition>(f_, null);
		var i_ = this.Breastfeeding();
		var j_ = e_.RetrieveByValueSet<Condition>(i_, null);
		var k_ = a_.ListUnion<Condition>(g_, j_);
		var m_ = this.Rhabdomyolysis();
		var n_ = e_.RetrieveByValueSet<Condition>(m_, null);
		var o_ = a_.ListUnion<Condition>(k_, n_);
		bool? p_(Condition ExclusionDiagnosis)
		{
			var s_ = context.Operators;
			var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ExclusionDiagnosis);
			var u_ = this.Measurement_Period();
			var v_ = s_.Overlaps(t_, u_, null);

			return v_;
		};
		var q_ = a_.WhereOrNull<Condition>(o_, p_);
		var r_ = a_.ExistsInList<Condition>(q_);

		return r_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Low_Intensity_Statin_Therapy();
		var g_ = e_.RetrieveByValueSet<MedicationRequest>(f_, null);
		var j_ = e_.RetrieveByValueSet<MedicationRequest>(f_, null);
		var k_ = a_.ListUnion<MedicationRequest>(g_, j_);
		var n_ = this.Moderate_Intensity_Statin_Therapy();
		var o_ = e_.RetrieveByValueSet<MedicationRequest>(n_, null);
		var r_ = e_.RetrieveByValueSet<MedicationRequest>(n_, null);
		var s_ = a_.ListUnion<MedicationRequest>(o_, r_);
		var t_ = a_.ListUnion<MedicationRequest>(k_, s_);
		var w_ = this.High_Intensity_Statin_Therapy();
		var x_ = e_.RetrieveByValueSet<MedicationRequest>(w_, null);
		var aa_ = e_.RetrieveByValueSet<MedicationRequest>(w_, null);
		var ab_ = a_.ListUnion<MedicationRequest>(x_, aa_);
		var ac_ = a_.ListUnion<MedicationRequest>(t_, ab_);
		bool? ad_(MedicationRequest StatinOrdered)
		{
			var af_ = context.Operators;
			var ai_ = StatinOrdered?.AuthoredOnElement;
			var aj_ = FHIRHelpers_4_0_001.ToDateTime(ai_);
			var ak_ = this.Measurement_Period();
			var al_ = af_.ElementInInterval<CqlDateTime>(aj_, ak_, null);
			var an_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ao_ = an_.Operators;
			var ap_ = ao_.TypeConverter;
			var aq_ = StatinOrdered?.StatusElement;
			var ar_ = ap_.Convert<string>(aq_);
			var as_ = new string[]
			{
				"active",
				"completed",
			};
			var at_ = af_.InList<string>(ar_, (as_ as IEnumerable<string>));
			var au_ = af_.And(al_, at_);
			var ax_ = an_.Operators;
			var ay_ = ax_.TypeConverter;
			var az_ = StatinOrdered?.IntentElement;
			var ba_ = ay_.Convert<string>(az_);
			var bb_ = af_.Equal(ba_, "order");
			var bc_ = af_.And(au_, bb_);

			return bc_;
		};
		var ae_ = a_.WhereOrNull<MedicationRequest>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("Statin Therapy Ordered during Measurement Period")]
	public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period() => 
		__Statin_Therapy_Ordered_during_Measurement_Period.Value;

	private IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period_Value()
	{
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Low_Intensity_Statin_Therapy();
		var g_ = e_.RetrieveByValueSet<MedicationRequest>(f_, null);
		var j_ = e_.RetrieveByValueSet<MedicationRequest>(f_, null);
		var k_ = a_.ListUnion<MedicationRequest>(g_, j_);
		var n_ = this.Moderate_Intensity_Statin_Therapy();
		var o_ = e_.RetrieveByValueSet<MedicationRequest>(n_, null);
		var r_ = e_.RetrieveByValueSet<MedicationRequest>(n_, null);
		var s_ = a_.ListUnion<MedicationRequest>(o_, r_);
		var t_ = a_.ListUnion<MedicationRequest>(k_, s_);
		var w_ = this.High_Intensity_Statin_Therapy();
		var x_ = e_.RetrieveByValueSet<MedicationRequest>(w_, null);
		var aa_ = e_.RetrieveByValueSet<MedicationRequest>(w_, null);
		var ab_ = a_.ListUnion<MedicationRequest>(x_, aa_);
		var ac_ = a_.ListUnion<MedicationRequest>(t_, ab_);
		bool? ad_(MedicationRequest ActiveStatin)
		{
			var af_ = context.Operators;
			var ak_ = ActiveStatin?.DosageInstruction;
			bool? al_(Dosage @this)
			{
				var bb_ = context.Operators;
				var bc_ = @this?.Timing;
				var bd_ = bb_.Not((bool?)(bc_ is null));

				return bd_;
			};
			var am_ = af_.WhereOrNull<Dosage>(ak_, al_);
			Timing an_(Dosage @this)
			{
				var be_ = @this?.Timing;

				return be_;
			};
			var ao_ = af_.SelectOrNull<Dosage, Timing>(am_, an_);
			bool? ap_(Timing T)
			{
				var bf_ = context.Operators;
				object bg_()
				{
					if (T?.Repeat?.Bounds is Range)
					{
						var bk_ = T?.Repeat;
						var bl_ = bk_?.Bounds;

						return (bl_ as Range);
					}
					else if (T?.Repeat?.Bounds is Period)
					{
						var bm_ = T?.Repeat;
						var bn_ = bm_?.Bounds;

						return (bn_ as Period);
					}
					else
					{
						return null;
					};
				};
				var bh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bg_());
				var bi_ = this.Measurement_Period();
				var bj_ = bf_.Overlaps(bh_, bi_, null);

				return bj_;
			};
			var aq_ = af_.WhereOrNull<Timing>(ao_, ap_);
			var ar_ = af_.ExistsInList<Timing>(aq_);
			var at_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var au_ = at_.Operators;
			var av_ = au_.TypeConverter;
			var aw_ = ActiveStatin?.StatusElement;
			var ax_ = av_.Convert<string>(aw_);
			var ay_ = new string[]
			{
				"active",
				"completed",
			};
			var az_ = af_.InList<string>(ax_, (ay_ as IEnumerable<string>));
			var ba_ = af_.And(ar_, az_);

			return ba_;
		};
		var ae_ = a_.WhereOrNull<MedicationRequest>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("Prescribed Statin Therapy Any Time during Measurement Period")]
	public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period() => 
		__Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period.Value;

	private bool? Numerator_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Statin_Therapy_Ordered_during_Measurement_Period();
		var d_ = a_.ExistsInList<MedicationRequest>(c_);
		var f_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period();
		var g_ = a_.ExistsInList<MedicationRequest>(f_);
		var h_ = a_.Or(d_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}