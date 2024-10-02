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
[CqlLibrary("AppropriateTreatmentforSTEMIFHIR", "1.0.000")]
public class AppropriateTreatmentforSTEMIFHIR_1_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis;
    internal Lazy<CqlValueSet> __Active_Peptic_Ulcer;
    internal Lazy<CqlValueSet> __Adverse_reaction_to_thrombolytics;
    internal Lazy<CqlValueSet> __Allergy_to_thrombolytics;
    internal Lazy<CqlValueSet> __Oral_Anticoagulant_Medications;
    internal Lazy<CqlValueSet> __Aortic_Dissection_and_Rupture;
    internal Lazy<CqlValueSet> __birth_date;
    internal Lazy<CqlValueSet> __Cardiopulmonary_Arrest;
    internal Lazy<CqlValueSet> __Cerebral_Vascular_Lesion;
    internal Lazy<CqlValueSet> __Closed_Head_and_Facial_Trauma;
    internal Lazy<CqlValueSet> __Dementia;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __ED;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Endotracheal_Intubation;
    internal Lazy<CqlValueSet> __Fibrinolytic_Therapy;
    internal Lazy<CqlValueSet> __Intracranial_or_Intraspinal_surgery;
    internal Lazy<CqlValueSet> __Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Major_Surgical_Procedure;
    internal Lazy<CqlValueSet> __Malignant_Intracranial_Neoplasm_Group;
    internal Lazy<CqlValueSet> __Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device;
    internal Lazy<CqlValueSet> __Neurologic_impairment;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Percutaneous_Coronary_Intervention;
    internal Lazy<CqlValueSet> __Pregnancy_ICD10_SNOMEDCT;
    internal Lazy<CqlValueSet> __STEMI;
    internal Lazy<CqlValueSet> __Thrombolytic_medications;
    internal Lazy<CqlCode> __Birthdate;
    internal Lazy<CqlCode> __Emergency_Department;
    internal Lazy<CqlCode> __Patient_transfer__procedure_;
    internal Lazy<CqlCode> __Streptokinase_adverse_reaction__disorder_;
    internal Lazy<CqlCode> __EMER;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __HSLOC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __ED_Encounter_with_Encounter_Diagnosis_of_STEMI;
    internal Lazy<IEnumerable<Encounter>> __ED_Encounter_with_Diagnosis_of_STEMI;
    internal Lazy<IEnumerable<Encounter>> __ED_Encounter_with_STEMI_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start;
    internal Lazy<IEnumerable<Encounter>> __Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start;
    internal Lazy<IEnumerable<Encounter>> __Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter;
    internal Lazy<IEnumerable<Encounter>> __Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter;
    internal Lazy<IEnumerable<Encounter>> __ED_Encounter_with_Discharge_Disposition_as_Patient_Expired;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Fibrinolytic_Therapy_within_30_Minutes_of_Arrival;
    internal Lazy<IEnumerable<Encounter>> __PCI_within_90_Minutes_of_Arrival;
    internal Lazy<IEnumerable<Encounter>> __ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public AppropriateTreatmentforSTEMIFHIR_1_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);

        __Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis = new Lazy<CqlValueSet>(this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis_Value);
        __Active_Peptic_Ulcer = new Lazy<CqlValueSet>(this.Active_Peptic_Ulcer_Value);
        __Adverse_reaction_to_thrombolytics = new Lazy<CqlValueSet>(this.Adverse_reaction_to_thrombolytics_Value);
        __Allergy_to_thrombolytics = new Lazy<CqlValueSet>(this.Allergy_to_thrombolytics_Value);
        __Oral_Anticoagulant_Medications = new Lazy<CqlValueSet>(this.Oral_Anticoagulant_Medications_Value);
        __Aortic_Dissection_and_Rupture = new Lazy<CqlValueSet>(this.Aortic_Dissection_and_Rupture_Value);
        __birth_date = new Lazy<CqlValueSet>(this.birth_date_Value);
        __Cardiopulmonary_Arrest = new Lazy<CqlValueSet>(this.Cardiopulmonary_Arrest_Value);
        __Cerebral_Vascular_Lesion = new Lazy<CqlValueSet>(this.Cerebral_Vascular_Lesion_Value);
        __Closed_Head_and_Facial_Trauma = new Lazy<CqlValueSet>(this.Closed_Head_and_Facial_Trauma_Value);
        __Dementia = new Lazy<CqlValueSet>(this.Dementia_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __ED = new Lazy<CqlValueSet>(this.ED_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Endotracheal_Intubation = new Lazy<CqlValueSet>(this.Endotracheal_Intubation_Value);
        __Fibrinolytic_Therapy = new Lazy<CqlValueSet>(this.Fibrinolytic_Therapy_Value);
        __Intracranial_or_Intraspinal_surgery = new Lazy<CqlValueSet>(this.Intracranial_or_Intraspinal_surgery_Value);
        __Ischemic_Stroke = new Lazy<CqlValueSet>(this.Ischemic_Stroke_Value);
        __Major_Surgical_Procedure = new Lazy<CqlValueSet>(this.Major_Surgical_Procedure_Value);
        __Malignant_Intracranial_Neoplasm_Group = new Lazy<CqlValueSet>(this.Malignant_Intracranial_Neoplasm_Group_Value);
        __Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device = new Lazy<CqlValueSet>(this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device_Value);
        __Neurologic_impairment = new Lazy<CqlValueSet>(this.Neurologic_impairment_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Percutaneous_Coronary_Intervention = new Lazy<CqlValueSet>(this.Percutaneous_Coronary_Intervention_Value);
        __Pregnancy_ICD10_SNOMEDCT = new Lazy<CqlValueSet>(this.Pregnancy_ICD10_SNOMEDCT_Value);
        __STEMI = new Lazy<CqlValueSet>(this.STEMI_Value);
        __Thrombolytic_medications = new Lazy<CqlValueSet>(this.Thrombolytic_medications_Value);
        __Birthdate = new Lazy<CqlCode>(this.Birthdate_Value);
        __Emergency_Department = new Lazy<CqlCode>(this.Emergency_Department_Value);
        __Patient_transfer__procedure_ = new Lazy<CqlCode>(this.Patient_transfer__procedure__Value);
        __Streptokinase_adverse_reaction__disorder_ = new Lazy<CqlCode>(this.Streptokinase_adverse_reaction__disorder__Value);
        __EMER = new Lazy<CqlCode>(this.EMER_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __HSLOC = new Lazy<CqlCode[]>(this.HSLOC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __ED_Encounter_with_Encounter_Diagnosis_of_STEMI = new Lazy<IEnumerable<Encounter>>(this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI_Value);
        __ED_Encounter_with_Diagnosis_of_STEMI = new Lazy<IEnumerable<Encounter>>(this.ED_Encounter_with_Diagnosis_of_STEMI_Value);
        __ED_Encounter_with_STEMI_Diagnosis = new Lazy<IEnumerable<Encounter>>(this.ED_Encounter_with_STEMI_Diagnosis_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter = new Lazy<IEnumerable<Encounter>>(this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter_Value);
        __Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter = new Lazy<IEnumerable<Encounter>>(this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter_Value);
        __Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter = new Lazy<IEnumerable<Encounter>>(this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter_Value);
        __Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter = new Lazy<IEnumerable<Encounter>>(this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter_Value);
        __Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start = new Lazy<IEnumerable<Encounter>>(this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Value);
        __Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter = new Lazy<IEnumerable<Encounter>>(this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter_Value);
        __Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start = new Lazy<IEnumerable<Encounter>>(this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Value);
        __Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter = new Lazy<IEnumerable<Encounter>>(this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter_Value);
        __Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter = new Lazy<IEnumerable<Encounter>>(this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter_Value);
        __ED_Encounter_with_Discharge_Disposition_as_Patient_Expired = new Lazy<IEnumerable<Encounter>>(this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Fibrinolytic_Therapy_within_30_Minutes_of_Arrival = new Lazy<IEnumerable<Encounter>>(this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival_Value);
        __PCI_within_90_Minutes_of_Arrival = new Lazy<IEnumerable<Encounter>>(this.PCI_within_90_Minutes_of_Arrival_Value);
        __ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival = new Lazy<IEnumerable<Encounter>>(this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", default);

    [CqlDeclaration("Active Bleeding Excluding Menses or Bleeding Diathesis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036")]
	public CqlValueSet Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis() => 
		__Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis.Value;

	private CqlValueSet Active_Peptic_Ulcer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", default);

    [CqlDeclaration("Active Peptic Ulcer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031")]
	public CqlValueSet Active_Peptic_Ulcer() => 
		__Active_Peptic_Ulcer.Value;

	private CqlValueSet Adverse_reaction_to_thrombolytics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", default);

    [CqlDeclaration("Adverse reaction to thrombolytics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6")]
	public CqlValueSet Adverse_reaction_to_thrombolytics() => 
		__Adverse_reaction_to_thrombolytics.Value;

	private CqlValueSet Allergy_to_thrombolytics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", default);

    [CqlDeclaration("Allergy to thrombolytics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5")]
	public CqlValueSet Allergy_to_thrombolytics() => 
		__Allergy_to_thrombolytics.Value;

	private CqlValueSet Oral_Anticoagulant_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", default);

    [CqlDeclaration("Oral Anticoagulant Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045")]
	public CqlValueSet Oral_Anticoagulant_Medications() => 
		__Oral_Anticoagulant_Medications.Value;

	private CqlValueSet Aortic_Dissection_and_Rupture_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", default);

    [CqlDeclaration("Aortic Dissection and Rupture")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028")]
	public CqlValueSet Aortic_Dissection_and_Rupture() => 
		__Aortic_Dissection_and_Rupture.Value;

	private CqlValueSet birth_date_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", default);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

	private CqlValueSet Cardiopulmonary_Arrest_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", default);

    [CqlDeclaration("Cardiopulmonary Arrest")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048")]
	public CqlValueSet Cardiopulmonary_Arrest() => 
		__Cardiopulmonary_Arrest.Value;

	private CqlValueSet Cerebral_Vascular_Lesion_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", default);

    [CqlDeclaration("Cerebral Vascular Lesion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025")]
	public CqlValueSet Cerebral_Vascular_Lesion() => 
		__Cerebral_Vascular_Lesion.Value;

	private CqlValueSet Closed_Head_and_Facial_Trauma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", default);

    [CqlDeclaration("Closed Head and Facial Trauma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026")]
	public CqlValueSet Closed_Head_and_Facial_Trauma() => 
		__Closed_Head_and_Facial_Trauma.Value;

	private CqlValueSet Dementia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", default);

    [CqlDeclaration("Dementia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043")]
	public CqlValueSet Dementia() => 
		__Dementia.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet ED_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1085", default);

    [CqlDeclaration("ED")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1085")]
	public CqlValueSet ED() => 
		__ED.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Endotracheal_Intubation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", default);

    [CqlDeclaration("Endotracheal Intubation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69")]
	public CqlValueSet Endotracheal_Intubation() => 
		__Endotracheal_Intubation.Value;

	private CqlValueSet Fibrinolytic_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020", default);

    [CqlDeclaration("Fibrinolytic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020")]
	public CqlValueSet Fibrinolytic_Therapy() => 
		__Fibrinolytic_Therapy.Value;

	private CqlValueSet Intracranial_or_Intraspinal_surgery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", default);

    [CqlDeclaration("Intracranial or Intraspinal surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2")]
	public CqlValueSet Intracranial_or_Intraspinal_surgery() => 
		__Intracranial_or_Intraspinal_surgery.Value;

	private CqlValueSet Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1024", default);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1024")]
	public CqlValueSet Ischemic_Stroke() => 
		__Ischemic_Stroke.Value;

	private CqlValueSet Major_Surgical_Procedure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", default);

    [CqlDeclaration("Major Surgical Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056")]
	public CqlValueSet Major_Surgical_Procedure() => 
		__Major_Surgical_Procedure.Value;

	private CqlValueSet Malignant_Intracranial_Neoplasm_Group_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", default);

    [CqlDeclaration("Malignant Intracranial Neoplasm Group")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3")]
	public CqlValueSet Malignant_Intracranial_Neoplasm_Group() => 
		__Malignant_Intracranial_Neoplasm_Group.Value;

	private CqlValueSet Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", default);

    [CqlDeclaration("Insertion or Replacement of Mechanical Circulatory Assist Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052")]
	public CqlValueSet Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device() => 
		__Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device.Value;

	private CqlValueSet Neurologic_impairment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", default);

    [CqlDeclaration("Neurologic impairment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012")]
	public CqlValueSet Neurologic_impairment() => 
		__Neurologic_impairment.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Percutaneous_Coronary_Intervention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", default);

    [CqlDeclaration("Percutaneous Coronary Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5")]
	public CqlValueSet Percutaneous_Coronary_Intervention() => 
		__Percutaneous_Coronary_Intervention.Value;

	private CqlValueSet Pregnancy_ICD10_SNOMEDCT_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", default);

    [CqlDeclaration("Pregnancy ICD10 SNOMEDCT")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055")]
	public CqlValueSet Pregnancy_ICD10_SNOMEDCT() => 
		__Pregnancy_ICD10_SNOMEDCT.Value;

	private CqlValueSet STEMI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", default);

    [CqlDeclaration("STEMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017")]
	public CqlValueSet STEMI() => 
		__STEMI.Value;

	private CqlValueSet Thrombolytic_medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", default);

    [CqlDeclaration("Thrombolytic medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4")]
	public CqlValueSet Thrombolytic_medications() => 
		__Thrombolytic_medications.Value;

	private CqlCode Birthdate_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birthdate")]
	public CqlCode Birthdate() => 
		__Birthdate.Value;

	private CqlCode Emergency_Department_Value() => 
		new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", default, default);

    [CqlDeclaration("Emergency Department")]
	public CqlCode Emergency_Department() => 
		__Emergency_Department.Value;

	private CqlCode Patient_transfer__procedure__Value() => 
		new CqlCode("107724000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Patient transfer (procedure)")]
	public CqlCode Patient_transfer__procedure_() => 
		__Patient_transfer__procedure_.Value;

	private CqlCode Streptokinase_adverse_reaction__disorder__Value() => 
		new CqlCode("293571007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Streptokinase adverse reaction (disorder)")]
	public CqlCode Streptokinase_adverse_reaction__disorder_() => 
		__Streptokinase_adverse_reaction__disorder_.Value;

	private CqlCode EMER_Value() => 
		new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("EMER")]
	public CqlCode EMER() => 
		__EMER.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] HSLOC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", default, default),
		];

		return a_;
	}

    [CqlDeclaration("HSLOC")]
	public CqlCode[] HSLOC() => 
		__HSLOC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("107724000", "http://snomed.info/sct", default, default),
			new CqlCode("293571007", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AppropriateTreatmentforSTEMIFHIR-1.0.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI_Value()
	{
		CqlValueSet a_ = this.ED();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_(Encounter EDEncounter)
		{
			Code<Encounter.EncounterStatus> e_ = EDEncounter?.StatusElement;
			Encounter.EncounterStatus? f_ = e_?.Value;
			Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
			bool? h_ = context.Operators.Equal(g_, "finished");
			Coding i_ = EDEncounter?.Class;
			CqlCode j_ = FHIRHelpers_4_3_000.ToCode(i_);
			CqlCode k_ = this.EMER();
			bool? l_ = context.Operators.Equivalent(j_, k_);
			bool? m_ = context.Operators.And(h_, l_);
			List<CodeableConcept> n_ = EDEncounter?.ReasonCode;
			CqlConcept o_(CodeableConcept @this)
			{
				CqlConcept ad_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ad_;
			};
			IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
			CqlValueSet q_ = this.STEMI();
			bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);
			IEnumerable<Condition> s_ = CQMCommon_2_0_000.encounterDiagnosis(EDEncounter);
			bool? t_(Condition EncDiagnosis)
			{
				CodeableConcept ae_ = EncDiagnosis?.Code;
				CqlConcept af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
				CqlValueSet ag_ = this.STEMI();
				bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);

				return ah_;
			};
			IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
			bool? v_ = context.Operators.Exists<Condition>(u_);
			bool? w_ = context.Operators.Or(r_, v_);
			bool? x_ = context.Operators.And(m_, w_);
			CqlInterval<CqlDateTime> y_ = this.Measurement_Period();
			Period z_ = EDEncounter?.Period;
			CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, aa_, default);
			bool? ac_ = context.Operators.And(x_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("ED Encounter with Encounter Diagnosis of STEMI")]
	public IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI() => 
		__ED_Encounter_with_Encounter_Diagnosis_of_STEMI.Value;

	private IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI_Value()
	{
		CqlValueSet a_ = this.ED();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_(Encounter EDEncounter)
		{
			CqlValueSet e_ = this.STEMI();
			IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? g_(Condition DxSTEMI)
			{
				CodeableConcept k_ = DxSTEMI?.ClinicalStatus;
				CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(k_);
				CqlCode m_ = QICoreCommon_2_0_000.active();
				CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
				bool? o_ = context.Operators.Equivalent(l_, n_);
				Code<Encounter.EncounterStatus> p_ = EDEncounter?.StatusElement;
				Encounter.EncounterStatus? q_ = p_?.Value;
				Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
				bool? s_ = context.Operators.Equal(r_, "finished");
				bool? t_ = context.Operators.And(o_, s_);
				Coding u_ = EDEncounter?.Class;
				CqlCode v_ = FHIRHelpers_4_3_000.ToCode(u_);
				CqlCode w_ = this.EMER();
				bool? x_ = context.Operators.Equivalent(v_, w_);
				bool? y_ = context.Operators.And(t_, x_);
				CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.prevalenceInterval(DxSTEMI);
				CqlDateTime aa_ = context.Operators.Start(z_);
				Period ab_ = EDEncounter?.Period;
				CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.ToInterval(ab_);
				bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, default);
				bool? ae_ = context.Operators.And(y_, ad_);
				CqlInterval<CqlDateTime> af_ = this.Measurement_Period();
				CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_3_000.ToInterval(ab_);
				bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(af_, ah_, "day");
				bool? aj_ = context.Operators.And(ae_, ai_);

				return aj_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Encounter i_(Condition DxSTEMI) => 
				EDEncounter;
			IEnumerable<Encounter> j_ = context.Operators.Select<Condition, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("ED Encounter with Diagnosis of STEMI")]
	public IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI() => 
		__ED_Encounter_with_Diagnosis_of_STEMI.Value;

	private IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI();
		IEnumerable<Encounter> b_ = this.ED_Encounter_with_Diagnosis_of_STEMI();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("ED Encounter with STEMI Diagnosis")]
	public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis() => 
		__ED_Encounter_with_STEMI_Diagnosis.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		bool? b_(Encounter EDwithSTEMI)
		{
			Patient d_ = this.Patient();
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			Period h_ = EDwithSTEMI?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.ToInterval(h_);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			bool? m_ = context.Operators.GreaterOrEqual(l_, 18);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			CqlValueSet d_ = this.Thrombolytic_medications();
			IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
			bool? f_(AllergyIntolerance ThrombolyticAllergy)
			{
				CodeableConcept j_ = ThrombolyticAllergy?.ClinicalStatus;
				CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				CqlCode l_ = QICoreCommon_2_0_000.allergy_active();
				CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
				bool? n_ = context.Operators.Equivalent(k_, m_);
				DataType o_ = ThrombolyticAllergy?.Onset;
				object p_ = FHIRHelpers_4_3_000.ToValue(o_);
				CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.toInterval(p_);
				Period r_ = EDwSTEMI?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				bool? t_ = context.Operators.Overlaps(q_, s_, default);
				bool? u_ = context.Operators.And(n_, t_);

				return u_;
			};
			IEnumerable<AllergyIntolerance> g_ = context.Operators.Where<AllergyIntolerance>(e_, f_);
			Encounter h_(AllergyIntolerance ThrombolyticAllergy) => 
				EDwSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<AllergyIntolerance, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
	public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter() => 
		__Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter.Value;

	private IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			CqlValueSet d_ = this.Adverse_reaction_to_thrombolytics();
			IEnumerable<AdverseEvent> e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
			bool? f_(AdverseEvent ThrombolyticAdverseEvent)
			{
				FhirDateTime j_ = ThrombolyticAdverseEvent?.RecordedDateElement;
				CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
				Period l_ = EDwSTEMI?.Period;
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				CqlDateTime n_ = context.Operators.End(m_);
				bool? o_ = context.Operators.Before(k_, n_, default);
				Code<AdverseEvent.AdverseEventActuality> p_ = ThrombolyticAdverseEvent?.ActualityElement;
				AdverseEvent.AdverseEventActuality? q_ = p_?.Value;
				Code<AdverseEvent.AdverseEventActuality> r_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(q_);
				bool? s_ = context.Operators.Equal(r_, "actual");
				bool? t_ = context.Operators.And(o_, s_);

				return t_;
			};
			IEnumerable<AdverseEvent> g_ = context.Operators.Where<AdverseEvent>(e_, f_);
			Encounter h_(AdverseEvent ThrombolyticAdverseEvent) => 
				EDwSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<AdverseEvent, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
	public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter() => 
		__Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis();
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet f_ = this.Malignant_Intracranial_Neoplasm_Group();
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
			CqlValueSet i_ = this.Cerebral_Vascular_Lesion();
			IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet k_ = this.Dementia();
			IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
			IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
			CqlValueSet o_ = this.Pregnancy_ICD10_SNOMEDCT();
			IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet q_ = this.Allergy_to_thrombolytics();
			IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_, r_);
			IEnumerable<Condition> t_ = context.Operators.Union<Condition>(n_, s_);
			bool? u_(Condition ActiveExclusionDx)
			{
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveExclusionDx);
				Period z_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(z_);
				bool? ab_ = context.Operators.OverlapsBefore(y_, aa_, default);

				return ab_;
			};
			IEnumerable<Condition> v_ = context.Operators.Where<Condition>(t_, u_);
			Encounter w_(Condition ActiveExclusionDx) => 
				EDwithSTEMI;
			IEnumerable<Encounter> x_ = context.Operators.Select<Condition, Encounter>(v_, w_);

			return x_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Active Exclusion Diagnosis at Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter() => 
		__Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Oral_Anticoagulant_Medications();
			IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest OralAnticoagulant)
			{
				Code<MedicationRequest.MedicationrequestStatus> m_ = OralAnticoagulant?.StatusElement;
				MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
				string o_ = context.Operators.Convert<string>(n_);
				bool? p_ = context.Operators.Equal(o_, "active");
				Code<MedicationRequest.MedicationRequestIntent> q_ = OralAnticoagulant?.IntentElement;
				MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
				string s_ = context.Operators.Convert<string>(r_);
				bool? t_ = context.Operators.Equal(s_, "order");
				bool? u_ = context.Operators.And(p_, t_);
				FhirDateTime v_ = OralAnticoagulant?.AuthoredOnElement;
				CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
				Period x_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.SameOrBefore(w_, z_, default);
				bool? ab_ = context.Operators.And(u_, aa_);

				return ab_;
			};
			IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest OralAnticoagulant) => 
				EDwithSTEMI;
			IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter() => 
		__Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Aortic_Dissection_and_Rupture();
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet f_ = this.Neurologic_impairment();
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
			CqlValueSet i_ = this.Cardiopulmonary_Arrest();
			IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
			bool? l_(Condition ExclusionDiagnosis)
			{
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.prevalenceInterval(ExclusionDiagnosis);
				CqlDateTime q_ = context.Operators.Start(p_);
				Period r_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
				bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, default);
				CqlDateTime v_ = context.Operators.Start(p_);
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(r_);
				CqlDateTime y_ = context.Operators.Start(x_);
				CqlQuantity z_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
				CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.ToInterval(r_);
				CqlDateTime ad_ = context.Operators.Start(ac_);
				CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, false);
				bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, default);
				CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_3_000.ToInterval(r_);
				CqlDateTime ai_ = context.Operators.Start(ah_);
				bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
				bool? ak_ = context.Operators.And(af_, aj_);
				bool? al_ = context.Operators.Or(t_, ak_);

				return al_;
			};
			IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
			Encounter n_(Condition ExclusionDiagnosis) => 
				EDwithSTEMI;
			IEnumerable<Encounter> o_ = context.Operators.Select<Condition, Encounter>(m_, n_);

			return o_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
	public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start() => 
		__Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start.Value;

	private IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Major_Surgical_Procedure();
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure MajorSurgery)
			{
				DataType j_ = MajorSurgery?.Performed;
				object k_ = FHIRHelpers_4_3_000.ToValue(j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				Period n_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(21m, "days");
				CqlDateTime r_ = context.Operators.Subtract(p_, q_);
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime u_ = context.Operators.Start(t_);
				CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
				bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Not((bool?)(z_ is null));
				bool? ab_ = context.Operators.And(w_, aa_);
				Code<EventStatus> ac_ = MajorSurgery?.StatusElement;
				EventStatus? ad_ = ac_?.Value;
				string ae_ = context.Operators.Convert<string>(ad_);
				bool? af_ = context.Operators.Equal(ae_, "completed");
				bool? ag_ = context.Operators.And(ab_, af_);

				return ag_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure MajorSurgery) => 
				EDwithSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
	public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter() => 
		__Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter.Value;

	private IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Endotracheal_Intubation();
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			CqlValueSet f_ = this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device();
			IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
			bool? i_(Procedure AirwayProcedure)
			{
				DataType m_ = AirwayProcedure?.Performed;
				object n_ = FHIRHelpers_4_3_000.ToValue(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.toInterval(n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(q_);
				bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, default);
				object u_ = FHIRHelpers_4_3_000.ToValue(m_);
				CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.toInterval(u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(q_);
				CqlDateTime z_ = context.Operators.Start(y_);
				CqlQuantity aa_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
				CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.ToInterval(q_);
				CqlDateTime ae_ = context.Operators.Start(ad_);
				CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ab_, ae_, true, false);
				bool? ag_ = context.Operators.In<CqlDateTime>(w_, af_, default);
				CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_3_000.ToInterval(q_);
				CqlDateTime aj_ = context.Operators.Start(ai_);
				bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
				bool? al_ = context.Operators.And(ag_, ak_);
				bool? am_ = context.Operators.Or(s_, al_);
				Code<EventStatus> an_ = AirwayProcedure?.StatusElement;
				EventStatus? ao_ = an_?.Value;
				string ap_ = context.Operators.Convert<string>(ao_);
				bool? aq_ = context.Operators.Equal(ap_, "completed");
				bool? ar_ = context.Operators.And(am_, aq_);

				return ar_;
			};
			IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
			Encounter k_(Procedure AirwayProcedure) => 
				EDwithSTEMI;
			IEnumerable<Encounter> l_ = context.Operators.Select<Procedure, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
	public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start() => 
		__Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start.Value;

	private IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			CqlValueSet d_ = this.Ischemic_Stroke();
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet f_ = this.Closed_Head_and_Facial_Trauma();
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
			CqlValueSet i_ = this.Active_Peptic_Ulcer();
			IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet k_ = this.Cardiopulmonary_Arrest();
			IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
			IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
			bool? o_(Condition ExclusionCondition)
			{
				CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.prevalenceInterval(ExclusionCondition);
				CqlDateTime t_ = context.Operators.Start(s_);
				Period u_ = EDwSTEMI?.Period;
				CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.ToInterval(u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlQuantity x_ = context.Operators.Quantity(90m, "days");
				CqlDateTime y_ = context.Operators.Subtract(w_, x_);
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(u_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(y_, ab_, true, true);
				bool? ad_ = context.Operators.In<CqlDateTime>(t_, ac_, default);

				return ad_;
			};
			IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
			Encounter q_(Condition ExclusionCondition) => 
				EDwSTEMI;
			IEnumerable<Encounter> r_ = context.Operators.Select<Condition, Encounter>(p_, q_);

			return r_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter() => 
		__Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Intracranial_or_Intraspinal_surgery();
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure CranialorSpinalSurgery)
			{
				DataType j_ = CranialorSpinalSurgery?.Performed;
				object k_ = FHIRHelpers_4_3_000.ToValue(j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				Period n_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(90m, "days");
				CqlDateTime r_ = context.Operators.Subtract(p_, q_);
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime u_ = context.Operators.Start(t_);
				CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
				bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.ToInterval(n_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Not((bool?)(z_ is null));
				bool? ab_ = context.Operators.And(w_, aa_);
				Code<EventStatus> ac_ = CranialorSpinalSurgery?.StatusElement;
				EventStatus? ad_ = ac_?.Value;
				string ae_ = context.Operators.Convert<string>(ad_);
				bool? af_ = context.Operators.Equal(ae_, "completed");
				bool? ag_ = context.Operators.And(ab_, af_);

				return ag_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure CranialorSpinalSurgery) => 
				EDwithSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
	public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter() => 
		__Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		bool? b_(Encounter EDwithSTEMI)
		{
			Encounter.HospitalizationComponent d_ = EDwithSTEMI?.Hospitalization;
			CodeableConcept e_ = d_?.DischargeDisposition;
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(e_);
			CqlValueSet g_ = this.Patient_Expired();
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("ED Encounter with Discharge Disposition as Patient Expired")]
	public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired() => 
		__ED_Encounter_with_Discharge_Disposition_as_Patient_Expired.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter();
		IEnumerable<Encounter> b_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter();
		IEnumerable<Encounter> e_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter();
		IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
		IEnumerable<Encounter> h_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start();
		IEnumerable<Encounter> i_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter();
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
		IEnumerable<Encounter> l_ = this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start();
		IEnumerable<Encounter> m_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter();
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(l_, m_);
		IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(k_, n_);
		IEnumerable<Encounter> p_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter();
		IEnumerable<Encounter> q_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired();
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(o_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

    [CqlDeclaration("currentemergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
	public CqlDateTime currentemergencyDepartmentArrivalTime(Encounter EDEncounter)
	{
		List<Encounter.LocationComponent> a_ = EDEncounter?.Location;
		bool? b_(Encounter.LocationComponent EDLocation)
		{
			ResourceReference h_ = EDLocation?.Location;
			Location i_ = CQMCommon_2_0_000.GetLocation(h_);
			List<CodeableConcept> j_ = i_?.Type;
			CqlConcept k_(CodeableConcept @this)
			{
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return o_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
			CqlValueSet m_ = this.Emergency_Department_Visit();
			bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

			return n_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
		Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
	}

	private IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Fibrinolytic_Therapy();
			IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
			IEnumerable<MedicationAdministration> g_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
			IEnumerable<MedicationAdministration> h_ = context.Operators.Union<MedicationAdministration>(e_, g_);
			bool? i_(MedicationAdministration Fibrinolytic)
			{
				Code<MedicationAdministration.MedicationAdministrationStatusCodes> m_ = Fibrinolytic?.StatusElement;
				MedicationAdministration.MedicationAdministrationStatusCodes? n_ = m_?.Value;
				Code<MedicationAdministration.MedicationAdministrationStatusCodes> o_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(n_);
				bool? p_ = context.Operators.Equal(o_, "completed");
				DataType q_ = Fibrinolytic?.Effective;
				object r_ = FHIRHelpers_4_3_000.ToValue(q_);
				CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.toInterval(r_);
				CqlDateTime t_ = context.Operators.Start(s_);
				CqlDateTime u_ = this.currentemergencyDepartmentArrivalTime(EDwithSTEMI);
				CqlQuantity w_ = context.Operators.Quantity(30m, "minutes");
				CqlDateTime x_ = context.Operators.Add(u_, w_);
				CqlInterval<CqlDateTime> y_ = context.Operators.Interval(u_, x_, false, true);
				bool? z_ = context.Operators.In<CqlDateTime>(t_, y_, default);
				bool? ab_ = context.Operators.Not((bool?)(u_ is null));
				bool? ac_ = context.Operators.And(z_, ab_);
				bool? ad_ = context.Operators.And(p_, ac_);

				return ad_;
			};
			IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);
			Encounter k_(MedicationAdministration Fibrinolytic) => 
				EDwithSTEMI;
			IEnumerable<Encounter> l_ = context.Operators.Select<MedicationAdministration, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Fibrinolytic Therapy within 30 Minutes of Arrival")]
	public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival() => 
		__Fibrinolytic_Therapy_within_30_Minutes_of_Arrival.Value;

	private IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Percutaneous_Coronary_Intervention();
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure PCI)
			{
				DataType j_ = PCI?.Performed;
				object k_ = FHIRHelpers_4_3_000.ToValue(j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlDateTime n_ = this.currentemergencyDepartmentArrivalTime(EDwithSTEMI);
				CqlQuantity p_ = context.Operators.Quantity(90m, "minutes");
				CqlDateTime q_ = context.Operators.Add(n_, p_);
				CqlInterval<CqlDateTime> r_ = context.Operators.Interval(n_, q_, false, true);
				bool? s_ = context.Operators.In<CqlDateTime>(m_, r_, default);
				bool? u_ = context.Operators.Not((bool?)(n_ is null));
				bool? v_ = context.Operators.And(s_, u_);
				Code<EventStatus> w_ = PCI?.StatusElement;
				EventStatus? x_ = w_?.Value;
				string y_ = context.Operators.Convert<string>(x_);
				bool? z_ = context.Operators.Equal(y_, "completed");
				bool? aa_ = context.Operators.And(v_, z_);

				return aa_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure PCI) => 
				EDwithSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("PCI within 90 Minutes of Arrival")]
	public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival() => 
		__PCI_within_90_Minutes_of_Arrival.Value;

	private IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival_Value()
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		bool? b_(Encounter EDwithSTEMI)
		{
			Period d_ = EDwithSTEMI?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_);
			CqlDateTime f_ = context.Operators.End(e_);
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(d_);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(d_);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlQuantity m_ = context.Operators.Quantity(45m, "minutes");
			CqlDateTime n_ = context.Operators.Add(l_, m_);
			CqlInterval<CqlDateTime> o_ = context.Operators.Interval(i_, n_, false, true);
			bool? p_ = context.Operators.In<CqlDateTime>(f_, o_, default);
			CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(d_);
			CqlDateTime s_ = context.Operators.Start(r_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			bool? u_ = context.Operators.And(p_, t_);
			Encounter.HospitalizationComponent v_ = EDwithSTEMI?.Hospitalization;
			CodeableConcept w_ = v_?.DischargeDisposition;
			CqlConcept x_ = FHIRHelpers_4_3_000.ToConcept(w_);
			CqlValueSet y_ = this.Discharge_To_Acute_Care_Facility();
			bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
			bool? aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
	public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival() => 
		__ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival();
		IEnumerable<Encounter> b_ = this.PCI_within_90_Minutes_of_Arrival();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival();
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
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
