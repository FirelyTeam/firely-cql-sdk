using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21", default);

    [CqlDeclaration("Atherosclerosis and Peripheral Arterial Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.21")]
	public CqlValueSet Atherosclerosis_and_Peripheral_Arterial_Disease() => 
		__Atherosclerosis_and_Peripheral_Arterial_Disease.Value;

	private CqlValueSet Breastfeeding_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73", default);

    [CqlDeclaration("Breastfeeding")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.73")]
	public CqlValueSet Breastfeeding() => 
		__Breastfeeding.Value;

	private CqlValueSet CABG_Surgeries_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694", default);

    [CqlDeclaration("CABG Surgeries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.694")]
	public CqlValueSet CABG_Surgeries() => 
		__CABG_Surgeries.Value;

	private CqlValueSet CABG__PCI_Procedure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566", default);

    [CqlDeclaration("CABG, PCI Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1138.566")]
	public CqlValueSet CABG__PCI_Procedure() => 
		__CABG__PCI_Procedure.Value;

	private CqlValueSet Carotid_Intervention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204", default);

    [CqlDeclaration("Carotid Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.204")]
	public CqlValueSet Carotid_Intervention() => 
		__Carotid_Intervention.Value;

	private CqlValueSet Cerebrovascular_Disease__Stroke__TIA_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44", default);

    [CqlDeclaration("Cerebrovascular Disease, Stroke, TIA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.44")]
	public CqlValueSet Cerebrovascular_Disease__Stroke__TIA() => 
		__Cerebrovascular_Disease__Stroke__TIA.Value;

	private CqlValueSet Diabetes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
	public CqlValueSet Diabetes() => 
		__Diabetes.Value;

	private CqlValueSet End_Stage_Renal_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", default);

    [CqlDeclaration("End Stage Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353")]
	public CqlValueSet End_Stage_Renal_Disease() => 
		__End_Stage_Renal_Disease.Value;

	private CqlValueSet Hepatitis_A_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024", default);

    [CqlDeclaration("Hepatitis A")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1024")]
	public CqlValueSet Hepatitis_A() => 
		__Hepatitis_A.Value;

	private CqlValueSet Hepatitis_B_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269", default);

    [CqlDeclaration("Hepatitis B")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.269")]
	public CqlValueSet Hepatitis_B() => 
		__Hepatitis_B.Value;

	private CqlValueSet High_Intensity_Statin_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572", default);

    [CqlDeclaration("High Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1572")]
	public CqlValueSet High_Intensity_Statin_Therapy() => 
		__High_Intensity_Statin_Therapy.Value;

	private CqlValueSet Hospice_Care_Ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", default);

    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584")]
	public CqlValueSet Hospice_Care_Ambulatory() => 
		__Hospice_Care_Ambulatory.Value;

	private CqlValueSet Hypercholesterolemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100", default);

    [CqlDeclaration("Hypercholesterolemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.100")]
	public CqlValueSet Hypercholesterolemia() => 
		__Hypercholesterolemia.Value;

	private CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46", default);

    [CqlDeclaration("Ischemic Heart Disease or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.46")]
	public CqlValueSet Ischemic_Heart_Disease_or_Other_Related_Diagnoses() => 
		__Ischemic_Heart_Disease_or_Other_Related_Diagnoses.Value;

	private CqlValueSet LDL_Cholesterol_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573", default);

    [CqlDeclaration("LDL Cholesterol")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1573")]
	public CqlValueSet LDL_Cholesterol() => 
		__LDL_Cholesterol.Value;

	private CqlValueSet Liver_Disease_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42", default);

    [CqlDeclaration("Liver Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.42")]
	public CqlValueSet Liver_Disease() => 
		__Liver_Disease.Value;

	private CqlValueSet Low_Intensity_Statin_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574", default);

    [CqlDeclaration("Low Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1574")]
	public CqlValueSet Low_Intensity_Statin_Therapy() => 
		__Low_Intensity_Statin_Therapy.Value;

	private CqlValueSet Moderate_Intensity_Statin_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575", default);

    [CqlDeclaration("Moderate Intensity Statin Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1575")]
	public CqlValueSet Moderate_Intensity_Statin_Therapy() => 
		__Moderate_Intensity_Statin_Therapy.Value;

	private CqlValueSet Myocardial_Infarction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403", default);

    [CqlDeclaration("Myocardial Infarction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403")]
	public CqlValueSet Myocardial_Infarction() => 
		__Myocardial_Infarction.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Outpatient_Encounters_for_Preventive_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576", default);

    [CqlDeclaration("Outpatient Encounters for Preventive Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1576")]
	public CqlValueSet Outpatient_Encounters_for_Preventive_Care() => 
		__Outpatient_Encounters_for_Preventive_Care.Value;

	private CqlValueSet Palliative_Care_Encounter_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575", default);

    [CqlDeclaration("Palliative Care Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1575")]
	public CqlValueSet Palliative_Care_Encounter() => 
		__Palliative_Care_Encounter.Value;

	private CqlValueSet Palliative_or_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", default);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public CqlValueSet Palliative_or_Hospice_Care() => 
		__Palliative_or_Hospice_Care.Value;

	private CqlValueSet PCI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67", default);

    [CqlDeclaration("PCI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.67")]
	public CqlValueSet PCI() => 
		__PCI.Value;

	private CqlValueSet Pregnancy_or_Other_Related_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623", default);

    [CqlDeclaration("Pregnancy or Other Related Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1623")]
	public CqlValueSet Pregnancy_or_Other_Related_Diagnoses() => 
		__Pregnancy_or_Other_Related_Diagnoses.Value;

	private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services___Other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", default);

    [CqlDeclaration("Preventive Care Services - Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
	public CqlValueSet Preventive_Care_Services___Other() => 
		__Preventive_Care_Services___Other.Value;

	private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);

    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling() => 
		__Preventive_Care_Services_Individual_Counseling.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Rhabdomyolysis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102", default);

    [CqlDeclaration("Rhabdomyolysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.102")]
	public CqlValueSet Rhabdomyolysis() => 
		__Rhabdomyolysis.Value;

	private CqlValueSet Stable_and_Unstable_Angina_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47", default);

    [CqlDeclaration("Stable and Unstable Angina")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.47")]
	public CqlValueSet Stable_and_Unstable_Angina() => 
		__Stable_and_Unstable_Angina.Value;

	private CqlValueSet Statin_Allergen_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42", default);

    [CqlDeclaration("Statin Allergen")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.42")]
	public CqlValueSet Statin_Allergen() => 
		__Statin_Allergen.Value;

	private CqlValueSet Statin_Associated_Muscle_Symptoms_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85", default);

    [CqlDeclaration("Statin Associated Muscle Symptoms")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.85")]
	public CqlValueSet Statin_Associated_Muscle_Symptoms() => 
		__Statin_Associated_Muscle_Symptoms.Value;

	private CqlCode Encounter_for_palliative_care_Value() => 
		new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlDeclaration("Encounter for palliative care")]
	public CqlCode Encounter_for_palliative_care() => 
		__Encounter_for_palliative_care.Value;

	private CqlCode[] ICD10CM_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("Z51.5", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("FHIR347-0.1.021", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Myocardial_Infarction();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		CqlValueSet c_ = this.Cerebrovascular_Disease__Stroke__TIA();
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Atherosclerosis_and_Peripheral_Arterial_Disease();
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		CqlValueSet h_ = this.Ischemic_Heart_Disease_or_Other_Related_Diagnoses();
		IEnumerable<Condition> i_ = context.Operators.RetrieveByValueSet<Condition>(h_, default);
		IEnumerable<Condition> j_ = context.Operators.Union<Condition>(g_, i_);
		IEnumerable<Condition> k_ = context.Operators.Union<Condition>(e_, j_);
		CqlValueSet l_ = this.Stable_and_Unstable_Angina();
		IEnumerable<Condition> m_ = context.Operators.RetrieveByValueSet<Condition>(l_, default);
		IEnumerable<Condition> n_ = context.Operators.Union<Condition>(k_, m_);
		bool? o_(Condition ASCVDDiagnosis)
		{
			CqlInterval<CqlDateTime> ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ASCVDDiagnosis);
			CqlDateTime af_ = context.Operators.Start(ae_);
			CqlInterval<CqlDateTime> ag_ = this.Measurement_Period();
			CqlDateTime ah_ = context.Operators.End(ag_);
			bool? ai_ = context.Operators.Before(af_, ah_, default);

			return ai_;
		};
		IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
		CqlValueSet q_ = this.PCI();
		IEnumerable<Procedure> r_ = context.Operators.RetrieveByValueSet<Procedure>(q_, default);
		CqlValueSet s_ = this.CABG_Surgeries();
		IEnumerable<Procedure> t_ = context.Operators.RetrieveByValueSet<Procedure>(s_, default);
		IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(r_, t_);
		CqlValueSet v_ = this.Carotid_Intervention();
		IEnumerable<Procedure> w_ = context.Operators.RetrieveByValueSet<Procedure>(v_, default);
		CqlValueSet x_ = this.CABG__PCI_Procedure();
		IEnumerable<Procedure> y_ = context.Operators.RetrieveByValueSet<Procedure>(x_, default);
		IEnumerable<Procedure> z_ = context.Operators.Union<Procedure>(w_, y_);
		IEnumerable<Procedure> aa_ = context.Operators.Union<Procedure>(u_, z_);
		bool? ab_(Procedure ASCVDProcedure)
		{
			DataType aj_ = ASCVDProcedure?.Performed;
			CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);
			CqlInterval<CqlDateTime> am_ = this.Measurement_Period();
			CqlDateTime an_ = context.Operators.End(am_);
			bool? ao_ = context.Operators.Before(al_, an_, default);
			Code<EventStatus> ap_ = ASCVDProcedure?.StatusElement;
			string aq_ = FHIRHelpers_4_0_001.ToString(ap_);
			bool? ar_ = context.Operators.Equal(aq_, "completed");
			bool? as_ = context.Operators.And(ao_, ar_);

			return as_;
		};
		IEnumerable<Procedure> ac_ = context.Operators.Where<Procedure>(aa_, ab_);
		IEnumerable<object> ad_ = context.Operators.Union<object>(p_ as IEnumerable<object>, ac_ as IEnumerable<object>);

		return ad_;
	}

    [CqlDeclaration("ASCVD Diagnosis or Procedure before End of Measurement Period")]
	public IEnumerable<object> ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period() => 
		__ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Office_Visit();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Outpatient_Encounters_for_Preventive_Care();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Preventive_Care_Services___Other();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		bool? x_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> z_ = this.Measurement_Period();
			Period aa_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.ToInterval(aa_);
			bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(z_, ab_, default);
			Code<Encounter.EncounterStatus> ad_ = ValidEncounter?.StatusElement;
			string ae_ = FHIRHelpers_4_0_001.ToString(ad_);
			bool? af_ = context.Operators.Equal(ae_, "finished");
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);

		return y_;
	}

    [CqlDeclaration("Qualifying Encounter during Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_during_Measurement_Period() => 
		__Qualifying_Encounter_during_Measurement_Period.Value;

	private bool? Initial_Population_1_Value()
	{
		IEnumerable<object> a_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		bool? b_ = context.Operators.Exists<object>(a_);
		IEnumerable<Encounter> c_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? d_ = context.Operators.Exists<Encounter>(c_);
		bool? e_ = context.Operators.And(b_, d_);

		return e_;
	}

    [CqlDeclaration("Initial Population 1")]
	public bool? Initial_Population_1() => 
		__Initial_Population_1.Value;

	private bool? Denominator_1_Value()
	{
		bool? a_ = this.Initial_Population_1();

		return a_;
	}

    [CqlDeclaration("Denominator 1")]
	public bool? Denominator_1() => 
		__Denominator_1.Value;

	private bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		bool? h_ = context.Operators.GreaterOrEqual(g_, 20);

		return h_;
	}

    [CqlDeclaration("Patients Age 20 or Older at Start of Measurement Period")]
	public bool? Patients_Age_20_or_Older_at_Start_of_Measurement_Period() => 
		__Patients_Age_20_or_Older_at_Start_of_Measurement_Period.Value;

	private IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190_Value()
	{
		CqlValueSet a_ = this.LDL_Cholesterol();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation LDL)
		{
			DataType e_ = LDL?.Value;
			Quantity f_ = e_ switch { null => null , Quantity a => a/* , CodeableConcept => ???, FhirString => ???, FhirBoolean => ???, Integer => ???, Range => ???, Ratio => ???, SampledData => ???, Time => ???, FhirDateTime => ???, Period => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			CqlQuantity g_ = FHIRHelpers_4_0_001.ToQuantity(f_);
			CqlQuantity h_ = context.Operators.Quantity(190m, "mg/dL");
			bool? i_ = context.Operators.GreaterOrEqual(g_, h_);
			DataType j_ = LDL?.Effective;
			CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(j_);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			CqlDateTime n_ = context.Operators.End(m_);
			bool? o_ = context.Operators.Before(l_, n_, default);
			bool? p_ = context.Operators.And(i_, o_);
			Code<ObservationStatus> q_ = LDL?.StatusElement;
			string r_ = FHIRHelpers_4_0_001.ToString(q_);
			string[] s_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(p_, t_);

			return u_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("LDL Result Greater Than or Equal To 190")]
	public IEnumerable<Observation> LDL_Result_Greater_Than_or_Equal_To_190() => 
		__LDL_Result_Greater_Than_or_Equal_To_190.Value;

	private IEnumerable<Condition> Hypercholesterolemia_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Hypercholesterolemia();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition Hypercholesterolemia)
		{
			CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Hypercholesterolemia);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.Before(f_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Hypercholesterolemia Diagnosis")]
	public IEnumerable<Condition> Hypercholesterolemia_Diagnosis() => 
		__Hypercholesterolemia_Diagnosis.Value;

	private bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD_Value()
	{
		bool? a_ = this.Patients_Age_20_or_Older_at_Start_of_Measurement_Period();
		IEnumerable<Observation> b_ = this.LDL_Result_Greater_Than_or_Equal_To_190();
		IEnumerable<Condition> c_ = this.Hypercholesterolemia_Diagnosis();
		IEnumerable<object> d_ = context.Operators.Union<object>(b_ as IEnumerable<object>, c_ as IEnumerable<object>);
		bool? e_ = context.Operators.Exists<object>(d_);
		bool? f_ = context.Operators.And(a_, e_);
		IEnumerable<object> g_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		bool? h_ = context.Operators.Exists<object>(g_);
		bool? i_ = context.Operators.Not(h_);
		bool? j_ = context.Operators.And(f_, i_);

		return j_;
	}

    [CqlDeclaration("Patients Age 20 Years and Older with LDL Cholesterol Result Greater than or Equal to 190 or Hypercholesterolemia without ASCVD")]
	public bool? Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD() => 
		__Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD.Value;

	private bool? Initial_Population_2_Value()
	{
		bool? a_ = this.Patients_Age_20_Years_and_Older_with_LDL_Cholesterol_Result_Greater_than_or_Equal_to_190_or_Hypercholesterolemia_without_ASCVD();
		IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? c_ = context.Operators.Exists<Encounter>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Initial Population 2")]
	public bool? Initial_Population_2() => 
		__Initial_Population_2.Value;

	private bool? Denominator_2_Value()
	{
		bool? a_ = this.Initial_Population_2();

		return a_;
	}

    [CqlDeclaration("Denominator 2")]
	public bool? Denominator_2() => 
		__Denominator_2.Value;

	private bool? Has_Diabetes_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Diabetes();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition Diabetes)
		{
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Diabetes);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			bool? h_ = context.Operators.Overlaps(f_, g_, default);

			return h_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Diabetes Diagnosis")]
	public bool? Has_Diabetes_Diagnosis() => 
		__Has_Diabetes_Diagnosis.Value;

	private bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		CqlInterval<int?> h_ = context.Operators.Interval(40, 75, true, true);
		bool? i_ = context.Operators.In<int?>(g_, h_, default);
		bool? j_ = this.Has_Diabetes_Diagnosis();
		bool? k_ = context.Operators.And(i_, j_);
		IEnumerable<object> l_ = this.ASCVD_Diagnosis_or_Procedure_before_End_of_Measurement_Period();
		bool? m_ = context.Operators.Exists<object>(l_);
		bool? n_ = context.Operators.Not(m_);
		bool? o_ = context.Operators.And(k_, n_);
		IEnumerable<Observation> p_ = this.LDL_Result_Greater_Than_or_Equal_To_190();
		bool? q_ = context.Operators.Exists<Observation>(p_);
		bool? r_ = context.Operators.Not(q_);
		bool? s_ = context.Operators.And(o_, r_);
		IEnumerable<Condition> t_ = this.Hypercholesterolemia_Diagnosis();
		bool? u_ = context.Operators.Exists<Condition>(t_);
		bool? v_ = context.Operators.Not(u_);
		bool? w_ = context.Operators.And(s_, v_);

		return w_;
	}

    [CqlDeclaration("Patients Age 40 to 75 Years with Diabetes without ASCVD or LDL Greater than 190 or Hypercholesterolemia")]
	public bool? Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia() => 
		__Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia.Value;

	private bool? Initial_Population_3_Value()
	{
		bool? a_ = this.Patients_Age_40_to_75_Years_with_Diabetes_without_ASCVD_or_LDL_Greater_than_190_or_Hypercholesterolemia();
		IEnumerable<Encounter> b_ = this.Qualifying_Encounter_during_Measurement_Period();
		bool? c_ = context.Operators.Exists<Encounter>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Initial Population 3")]
	public bool? Initial_Population_3() => 
		__Initial_Population_3.Value;

	private bool? Denominator_3_Value()
	{
		bool? a_ = this.Initial_Population_3();

		return a_;
	}

    [CqlDeclaration("Denominator 3")]
	public bool? Denominator_3() => 
		__Denominator_3.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private bool? Has_Allergy_to_Statin_Value()
	{
		CqlValueSet a_ = this.Statin_Allergen();
		IEnumerable<AllergyIntolerance> b_ = context.Operators.RetrieveByValueSet<AllergyIntolerance>(a_, default);
		bool? c_(AllergyIntolerance StatinAllergy)
		{
			DataType f_ = StatinAllergy?.Onset;
			CqlInterval<CqlDateTime> g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			CqlDateTime j_ = context.Operators.End(i_);
			bool? k_ = context.Operators.Before(h_, j_, default);

			return k_;
		};
		IEnumerable<AllergyIntolerance> d_ = context.Operators.Where<AllergyIntolerance>(b_, c_);
		bool? e_ = context.Operators.Exists<AllergyIntolerance>(d_);

		return e_;
	}

    [CqlDeclaration("Has Allergy to Statin")]
	public bool? Has_Allergy_to_Statin() => 
		__Has_Allergy_to_Statin.Value;

	private bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care_Value()
	{
		CqlValueSet a_ = this.Hospice_Care_Ambulatory();
		IEnumerable<ServiceRequest> b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, default);
		CqlValueSet c_ = this.Palliative_or_Hospice_Care();
		IEnumerable<ServiceRequest> d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, default);
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		bool? f_(ServiceRequest PalliativeOrHospiceCareOrder)
		{
			FhirDateTime y_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
			CqlDateTime z_ = FHIRHelpers_4_0_001.ToDateTime(y_);
			CqlInterval<CqlDateTime> aa_ = this.Measurement_Period();
			CqlDateTime ab_ = context.Operators.End(aa_);
			bool? ac_ = context.Operators.SameOrBefore(z_, ab_, default);
			Code<RequestStatus> ad_ = PalliativeOrHospiceCareOrder?.StatusElement;
			string ae_ = FHIRHelpers_4_0_001.ToString(ad_);
			string[] af_ = [
				"active",
				"on-hold",
				"completed",
			];
			bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
			bool? ah_ = context.Operators.And(ac_, ag_);
			Code<RequestIntent> ai_ = PalliativeOrHospiceCareOrder?.IntentElement;
			string aj_ = FHIRHelpers_4_0_001.ToString(ai_);
			bool? ak_ = context.Operators.Equal(aj_, "order");
			bool? al_ = context.Operators.And(ah_, ak_);

			return al_;
		};
		IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);
		bool? h_ = context.Operators.Exists<ServiceRequest>(g_);
		IEnumerable<Procedure> j_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		IEnumerable<Procedure> l_ = context.Operators.RetrieveByValueSet<Procedure>(c_, default);
		IEnumerable<Procedure> m_ = context.Operators.Union<Procedure>(j_, l_);
		bool? n_(Procedure PalliativeOrHospiceCarePerformed)
		{
			DataType am_ = PalliativeOrHospiceCarePerformed?.Performed;
			CqlInterval<CqlDateTime> an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(am_);
			CqlDateTime ao_ = context.Operators.Start(an_);
			CqlInterval<CqlDateTime> ap_ = this.Measurement_Period();
			CqlDateTime aq_ = context.Operators.End(ap_);
			bool? ar_ = context.Operators.SameOrBefore(ao_, aq_, default);
			Code<EventStatus> as_ = PalliativeOrHospiceCarePerformed?.StatusElement;
			string at_ = FHIRHelpers_4_0_001.ToString(as_);
			bool? au_ = context.Operators.Equal(at_, "completed");
			bool? av_ = context.Operators.And(ar_, au_);

			return av_;
		};
		IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
		bool? p_ = context.Operators.Exists<Procedure>(o_);
		bool? q_ = context.Operators.Or(h_, p_);
		CqlCode r_ = this.Encounter_for_palliative_care();
		IEnumerable<CqlCode> s_ = context.Operators.ToList<CqlCode>(r_);
		IEnumerable<Encounter> t_ = context.Operators.RetrieveByCodes<Encounter>(s_, default);
		bool? u_(Encounter PalliativeEncounter)
		{
			Period aw_ = PalliativeEncounter?.Period;
			CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
			CqlDateTime ay_ = context.Operators.Start(ax_);
			CqlInterval<CqlDateTime> az_ = this.Measurement_Period();
			CqlDateTime ba_ = context.Operators.End(az_);
			bool? bb_ = context.Operators.SameOrBefore(ay_, ba_, default);
			Code<Encounter.EncounterStatus> bc_ = PalliativeEncounter?.StatusElement;
			string bd_ = FHIRHelpers_4_0_001.ToString(bc_);
			bool? be_ = context.Operators.Equal(bd_, "finished");
			bool? bf_ = context.Operators.And(bb_, be_);

			return bf_;
		};
		IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
		bool? w_ = context.Operators.Exists<Encounter>(v_);
		bool? x_ = context.Operators.Or(q_, w_);

		return x_;
	}

    [CqlDeclaration("Has Order or Receiving Hospice Care or Palliative Care")]
	public bool? Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care() => 
		__Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care.Value;

	private bool? Has_Hepatitis_or_Liver_Disease_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Hepatitis_A();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		CqlValueSet c_ = this.Hepatitis_B();
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Liver_Disease();
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
		bool? i_(Condition HepatitisLiverDisease)
		{
			CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(HepatitisLiverDisease);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			bool? n_ = context.Operators.Overlaps(l_, m_, default);

			return n_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);

		return k_;
	}

    [CqlDeclaration("Has Hepatitis or Liver Disease Diagnosis")]
	public bool? Has_Hepatitis_or_Liver_Disease_Diagnosis() => 
		__Has_Hepatitis_or_Liver_Disease_Diagnosis.Value;

	private bool? Has_Statin_Associated_Muscle_Symptoms_Value()
	{
		CqlValueSet a_ = this.Statin_Associated_Muscle_Symptoms();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition StatinMuscleSymptom)
		{
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(StatinMuscleSymptom);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.End(h_);
			bool? j_ = context.Operators.Before(g_, i_, default);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Statin Associated Muscle Symptoms")]
	public bool? Has_Statin_Associated_Muscle_Symptoms() => 
		__Has_Statin_Associated_Muscle_Symptoms.Value;

	private bool? Has_ESRD_Diagnosis_Value()
	{
		CqlValueSet a_ = this.End_Stage_Renal_Disease();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition ESRD)
		{
			CqlInterval<CqlDateTime> f_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ESRD);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			bool? h_ = context.Operators.Overlaps(f_, g_, default);

			return h_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has ESRD Diagnosis")]
	public bool? Has_ESRD_Diagnosis() => 
		__Has_ESRD_Diagnosis.Value;

	private bool? Has_Adverse_Reaction_to_Statin_Value()
	{
		CqlValueSet a_ = this.Statin_Allergen();
		IEnumerable<AdverseEvent> b_ = context.Operators.RetrieveByValueSet<AdverseEvent>(a_, default);
		bool? c_(AdverseEvent StatinReaction)
		{
			FhirDateTime f_ = StatinReaction?.DateElement;
			CqlDateTime g_ = FHIRHelpers_4_0_001.ToDateTime(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, default);

			return i_;
		};
		IEnumerable<AdverseEvent> d_ = context.Operators.Where<AdverseEvent>(b_, c_);
		bool? e_ = context.Operators.Exists<AdverseEvent>(d_);

		return e_;
	}

    [CqlDeclaration("Has Adverse Reaction to Statin")]
	public bool? Has_Adverse_Reaction_to_Statin() => 
		__Has_Adverse_Reaction_to_Statin.Value;

	private bool? Denominator_Exceptions_Value()
	{
		bool? a_ = this.Has_Allergy_to_Statin();
		bool? b_ = this.Has_Order_or_Receiving_Hospice_Care_or_Palliative_Care();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Hepatitis_or_Liver_Disease_Diagnosis();
		bool? e_ = context.Operators.Or(c_, d_);
		bool? f_ = this.Has_Statin_Associated_Muscle_Symptoms();
		bool? g_ = context.Operators.Or(e_, f_);
		bool? h_ = this.Has_ESRD_Diagnosis();
		bool? i_ = context.Operators.Or(g_, h_);
		bool? j_ = this.Has_Adverse_Reaction_to_Statin();
		bool? k_ = context.Operators.Or(i_, j_);

		return k_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private bool? Denominator_Exclusions_Value()
	{
		CqlValueSet a_ = this.Pregnancy_or_Other_Related_Diagnoses();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		CqlValueSet c_ = this.Breastfeeding();
		IEnumerable<Condition> d_ = context.Operators.RetrieveByValueSet<Condition>(c_, default);
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Rhabdomyolysis();
		IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
		IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
		bool? i_(Condition ExclusionDiagnosis)
		{
			CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(ExclusionDiagnosis);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			bool? n_ = context.Operators.Overlaps(l_, m_, default);

			return n_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);

		return k_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Low_Intensity_Statin_Therapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		CqlValueSet f_ = this.Moderate_Intensity_Statin_Therapy();
		IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
		CqlValueSet l_ = this.High_Intensity_Statin_Therapy();
		IEnumerable<MedicationRequest> m_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
		IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
		bool? r_(MedicationRequest StatinOrdered)
		{
			FhirDateTime t_ = StatinOrdered?.AuthoredOnElement;
			CqlDateTime u_ = FHIRHelpers_4_0_001.ToDateTime(t_);
			CqlInterval<CqlDateTime> v_ = this.Measurement_Period();
			bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, default);
			Code<MedicationRequest.MedicationrequestStatus> x_ = StatinOrdered?.StatusElement;
			string y_ = FHIRHelpers_4_0_001.ToString(x_);
			string[] z_ = [
				"active",
				"completed",
			];
			bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
			bool? ab_ = context.Operators.And(w_, aa_);
			Code<MedicationRequest.MedicationRequestIntent> ac_ = StatinOrdered?.IntentElement;
			string ad_ = FHIRHelpers_4_0_001.ToString(ac_);
			bool? ae_ = context.Operators.Equal(ad_, "order");
			bool? af_ = context.Operators.And(ab_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> s_ = context.Operators.Where<MedicationRequest>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Statin Therapy Ordered during Measurement Period")]
	public IEnumerable<MedicationRequest> Statin_Therapy_Ordered_during_Measurement_Period() => 
		__Statin_Therapy_Ordered_during_Measurement_Period.Value;

	private IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Low_Intensity_Statin_Therapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		CqlValueSet f_ = this.Moderate_Intensity_Statin_Therapy();
		IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, default);
		IEnumerable<MedicationRequest> j_ = context.Operators.Union<MedicationRequest>(g_, i_);
		IEnumerable<MedicationRequest> k_ = context.Operators.Union<MedicationRequest>(e_, j_);
		CqlValueSet l_ = this.High_Intensity_Statin_Therapy();
		IEnumerable<MedicationRequest> m_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> o_ = context.Operators.RetrieveByValueSet<MedicationRequest>(l_, default);
		IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(m_, o_);
		IEnumerable<MedicationRequest> q_ = context.Operators.Union<MedicationRequest>(k_, p_);
		bool? r_(MedicationRequest ActiveStatin)
		{
			List<Dosage> t_ = ActiveStatin?.DosageInstruction;
			bool? u_(Dosage @this)
			{
				Timing ag_ = @this?.Timing;
				bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

				return ah_;
			};
			IEnumerable<Dosage> v_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)t_, u_);
			Timing w_(Dosage @this)
			{
				Timing ai_ = @this?.Timing;

				return ai_;
			};
			IEnumerable<Timing> x_ = context.Operators.Select<Dosage, Timing>(v_, w_);
			bool? y_(Timing T)
			{
				object aj_()
				{
					bool an_()
					{
						Timing.RepeatComponent ap_ = T?.Repeat;
						DataType aq_ = ap_?.Bounds;
						bool ar_ = aq_ is Range;

						return ar_;
					};
					bool ao_()
					{
						Timing.RepeatComponent as_ = T?.Repeat;
						DataType at_ = as_?.Bounds;
						bool au_ = at_ is Period;

						return au_;
					};
					if (an_())
					{
						Timing.RepeatComponent av_ = T?.Repeat;
						DataType aw_ = av_?.Bounds;
						Range ax_ = aw_ switch { null => null , Range a => a/* , Duration => ???, Period => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return ax_ as object;
					}
					else if (ao_())
					{
						Timing.RepeatComponent ay_ = T?.Repeat;
						DataType az_ = ay_?.Bounds;
						Period ba_ = az_ switch { null => null , Period b => b/* , Duration => ???, Range => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

						return ba_ as object;
					}
					else
					{
						return null;
					}
				};
				CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(aj_());
				CqlInterval<CqlDateTime> al_ = this.Measurement_Period();
				bool? am_ = context.Operators.Overlaps(ak_, al_, default);

				return am_;
			};
			IEnumerable<Timing> z_ = context.Operators.Where<Timing>(x_, y_);
			bool? aa_ = context.Operators.Exists<Timing>(z_);
			Code<MedicationRequest.MedicationrequestStatus> ab_ = ActiveStatin?.StatusElement;
			string ac_ = FHIRHelpers_4_0_001.ToString(ab_);
			string[] ad_ = [
				"active",
				"completed",
			];
			bool? ae_ = context.Operators.In<string>(ac_, ad_ as IEnumerable<string>);
			bool? af_ = context.Operators.And(aa_, ae_);

			return af_;
		};
		IEnumerable<MedicationRequest> s_ = context.Operators.Where<MedicationRequest>(q_, r_);

		return s_;
	}

    [CqlDeclaration("Prescribed Statin Therapy Any Time during Measurement Period")]
	public IEnumerable<MedicationRequest> Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period() => 
		__Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<MedicationRequest> a_ = this.Statin_Therapy_Ordered_during_Measurement_Period();
		bool? b_ = context.Operators.Exists<MedicationRequest>(a_);
		IEnumerable<MedicationRequest> c_ = this.Prescribed_Statin_Therapy_Any_Time_during_Measurement_Period();
		bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
