using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", null);

    [CqlDeclaration("Active Bleeding Excluding Menses or Bleeding Diathesis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036")]
	public CqlValueSet Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis() => 
		__Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis.Value;

	private CqlValueSet Active_Peptic_Ulcer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", null);

    [CqlDeclaration("Active Peptic Ulcer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031")]
	public CqlValueSet Active_Peptic_Ulcer() => 
		__Active_Peptic_Ulcer.Value;

	private CqlValueSet Adverse_reaction_to_thrombolytics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", null);

    [CqlDeclaration("Adverse reaction to thrombolytics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6")]
	public CqlValueSet Adverse_reaction_to_thrombolytics() => 
		__Adverse_reaction_to_thrombolytics.Value;

	private CqlValueSet Allergy_to_thrombolytics_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", null);

    [CqlDeclaration("Allergy to thrombolytics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5")]
	public CqlValueSet Allergy_to_thrombolytics() => 
		__Allergy_to_thrombolytics.Value;

	private CqlValueSet Oral_Anticoagulant_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", null);

    [CqlDeclaration("Oral Anticoagulant Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045")]
	public CqlValueSet Oral_Anticoagulant_Medications() => 
		__Oral_Anticoagulant_Medications.Value;

	private CqlValueSet Aortic_Dissection_and_Rupture_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", null);

    [CqlDeclaration("Aortic Dissection and Rupture")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028")]
	public CqlValueSet Aortic_Dissection_and_Rupture() => 
		__Aortic_Dissection_and_Rupture.Value;

	private CqlValueSet birth_date_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

	private CqlValueSet Cardiopulmonary_Arrest_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", null);

    [CqlDeclaration("Cardiopulmonary Arrest")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048")]
	public CqlValueSet Cardiopulmonary_Arrest() => 
		__Cardiopulmonary_Arrest.Value;

	private CqlValueSet Cerebral_Vascular_Lesion_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", null);

    [CqlDeclaration("Cerebral Vascular Lesion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025")]
	public CqlValueSet Cerebral_Vascular_Lesion() => 
		__Cerebral_Vascular_Lesion.Value;

	private CqlValueSet Closed_Head_and_Facial_Trauma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", null);

    [CqlDeclaration("Closed Head and Facial Trauma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026")]
	public CqlValueSet Closed_Head_and_Facial_Trauma() => 
		__Closed_Head_and_Facial_Trauma.Value;

	private CqlValueSet Dementia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", null);

    [CqlDeclaration("Dementia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043")]
	public CqlValueSet Dementia() => 
		__Dementia.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet ED_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1085", null);

    [CqlDeclaration("ED")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1085")]
	public CqlValueSet ED() => 
		__ED.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Endotracheal_Intubation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", null);

    [CqlDeclaration("Endotracheal Intubation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69")]
	public CqlValueSet Endotracheal_Intubation() => 
		__Endotracheal_Intubation.Value;

	private CqlValueSet Fibrinolytic_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020", null);

    [CqlDeclaration("Fibrinolytic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020")]
	public CqlValueSet Fibrinolytic_Therapy() => 
		__Fibrinolytic_Therapy.Value;

	private CqlValueSet Intracranial_or_Intraspinal_surgery_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", null);

    [CqlDeclaration("Intracranial or Intraspinal surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2")]
	public CqlValueSet Intracranial_or_Intraspinal_surgery() => 
		__Intracranial_or_Intraspinal_surgery.Value;

	private CqlValueSet Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1024", null);

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1024")]
	public CqlValueSet Ischemic_Stroke() => 
		__Ischemic_Stroke.Value;

	private CqlValueSet Major_Surgical_Procedure_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", null);

    [CqlDeclaration("Major Surgical Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056")]
	public CqlValueSet Major_Surgical_Procedure() => 
		__Major_Surgical_Procedure.Value;

	private CqlValueSet Malignant_Intracranial_Neoplasm_Group_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", null);

    [CqlDeclaration("Malignant Intracranial Neoplasm Group")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3")]
	public CqlValueSet Malignant_Intracranial_Neoplasm_Group() => 
		__Malignant_Intracranial_Neoplasm_Group.Value;

	private CqlValueSet Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", null);

    [CqlDeclaration("Insertion or Replacement of Mechanical Circulatory Assist Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052")]
	public CqlValueSet Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device() => 
		__Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device.Value;

	private CqlValueSet Neurologic_impairment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", null);

    [CqlDeclaration("Neurologic impairment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012")]
	public CqlValueSet Neurologic_impairment() => 
		__Neurologic_impairment.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Percutaneous_Coronary_Intervention_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", null);

    [CqlDeclaration("Percutaneous Coronary Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5")]
	public CqlValueSet Percutaneous_Coronary_Intervention() => 
		__Percutaneous_Coronary_Intervention.Value;

	private CqlValueSet Pregnancy_ICD10_SNOMEDCT_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", null);

    [CqlDeclaration("Pregnancy ICD10 SNOMEDCT")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055")]
	public CqlValueSet Pregnancy_ICD10_SNOMEDCT() => 
		__Pregnancy_ICD10_SNOMEDCT.Value;

	private CqlValueSet STEMI_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", null);

    [CqlDeclaration("STEMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017")]
	public CqlValueSet STEMI() => 
		__STEMI.Value;

	private CqlValueSet Thrombolytic_medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", null);

    [CqlDeclaration("Thrombolytic medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4")]
	public CqlValueSet Thrombolytic_medications() => 
		__Thrombolytic_medications.Value;

	private CqlCode Birthdate_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birthdate")]
	public CqlCode Birthdate() => 
		__Birthdate.Value;

	private CqlCode Emergency_Department_Value() => 
		new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", null, null);

    [CqlDeclaration("Emergency Department")]
	public CqlCode Emergency_Department() => 
		__Emergency_Department.Value;

	private CqlCode Patient_transfer__procedure__Value() => 
		new CqlCode("107724000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Patient transfer (procedure)")]
	public CqlCode Patient_transfer__procedure_() => 
		__Patient_transfer__procedure_.Value;

	private CqlCode Streptokinase_adverse_reaction__disorder__Value() => 
		new CqlCode("293571007", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Streptokinase adverse reaction (disorder)")]
	public CqlCode Streptokinase_adverse_reaction__disorder_() => 
		__Streptokinase_adverse_reaction__disorder_.Value;

	private CqlCode EMER_Value() => 
		new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("EMER")]
	public CqlCode EMER() => 
		__EMER.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] HSLOC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", null, null),
		};

		return a_;
	}

    [CqlDeclaration("HSLOC")]
	public CqlCode[] HSLOC() => 
		__HSLOC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("107724000", "http://snomed.info/sct", null, null),
			new CqlCode("293571007", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("AppropriateTreatmentforSTEMIFHIR-1.0.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI_Value()
	{
		var a_ = this.ED();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EDEncounter)
		{
			var e_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EDEncounter?.StatusElement?.Value);
			var f_ = context.Operators.Equal(e_, "finished");
			var g_ = FHIRHelpers_4_3_000.ToCode(EDEncounter?.Class);
			var h_ = this.EMER();
			var i_ = context.Operators.Equivalent(g_, h_);
			var j_ = context.Operators.And(f_, i_);
			CqlConcept k_(CodeableConcept @this)
			{
				var y_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return y_;
			};
			var l_ = context.Operators.Select<CodeableConcept, CqlConcept>(EDEncounter?.ReasonCode, k_);
			var m_ = this.STEMI();
			var n_ = context.Operators.ConceptsInValueSet(l_, m_);
			var o_ = CQMCommon_2_0_000.encounterDiagnosis(EDEncounter);
			bool? p_(Condition EncDiagnosis)
			{
				var z_ = FHIRHelpers_4_3_000.ToConcept(EncDiagnosis?.Code);
				var aa_ = this.STEMI();
				var ab_ = context.Operators.ConceptInValueSet(z_, aa_);

				return ab_;
			};
			var q_ = context.Operators.Where<Condition>(o_, p_);
			var r_ = context.Operators.Exists<Condition>(q_);
			var s_ = context.Operators.Or(n_, r_);
			var t_ = context.Operators.And(j_, s_);
			var u_ = this.Measurement_Period();
			var v_ = FHIRHelpers_4_3_000.ToInterval(EDEncounter?.Period);
			var w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, v_, null);
			var x_ = context.Operators.And(t_, w_);

			return x_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("ED Encounter with Encounter Diagnosis of STEMI")]
	public IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI() => 
		__ED_Encounter_with_Encounter_Diagnosis_of_STEMI.Value;

	private IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI_Value()
	{
		var a_ = this.ED();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		IEnumerable<Encounter> c_(Encounter EDEncounter)
		{
			var e_ = this.STEMI();
			var f_ = context.Operators.RetrieveByValueSet<Condition>(e_, null);
			bool? g_(Condition DxSTEMI)
			{
				var k_ = FHIRHelpers_4_3_000.ToConcept(DxSTEMI?.ClinicalStatus);
				var l_ = QICoreCommon_2_0_000.active();
				var m_ = context.Operators.ConvertCodeToConcept(l_);
				var n_ = context.Operators.Equivalent(k_, m_);
				var o_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(EDEncounter?.StatusElement?.Value);
				var p_ = context.Operators.Equal(o_, "finished");
				var q_ = context.Operators.And(n_, p_);
				var r_ = FHIRHelpers_4_3_000.ToCode(EDEncounter?.Class);
				var s_ = this.EMER();
				var t_ = context.Operators.Equivalent(r_, s_);
				var u_ = context.Operators.And(q_, t_);
				var v_ = QICoreCommon_2_0_000.prevalenceInterval(DxSTEMI);
				var w_ = context.Operators.Start(v_);
				var x_ = FHIRHelpers_4_3_000.ToInterval(EDEncounter?.Period);
				var y_ = context.Operators.In<CqlDateTime>(w_, x_, null);
				var z_ = context.Operators.And(u_, y_);
				var aa_ = this.Measurement_Period();
				var ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, x_, "day");
				var ad_ = context.Operators.And(z_, ac_);

				return ad_;
			};
			var h_ = context.Operators.Where<Condition>(f_, g_);
			Encounter i_(Condition DxSTEMI) => 
				EDEncounter;
			var j_ = context.Operators.Select<Condition, Encounter>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("ED Encounter with Diagnosis of STEMI")]
	public IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI() => 
		__ED_Encounter_with_Diagnosis_of_STEMI.Value;

	private IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis_Value()
	{
		var a_ = this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI();
		var b_ = this.ED_Encounter_with_Diagnosis_of_STEMI();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("ED Encounter with STEMI Diagnosis")]
	public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis() => 
		__ED_Encounter_with_STEMI_Diagnosis.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		bool? b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Patient();
			var e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			var f_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			var j_ = context.Operators.GreaterOrEqual(i_, 18);

			return j_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			var d_ = this.Thrombolytic_medications();
			var e_ = context.Operators.RetrieveByValueSet<AllergyIntolerance>(d_, null);
			bool? f_(AllergyIntolerance ThrombolyticAllergy)
			{
				var j_ = FHIRHelpers_4_3_000.ToConcept(ThrombolyticAllergy?.ClinicalStatus);
				var k_ = QICoreCommon_2_0_000.allergy_active();
				var l_ = context.Operators.ConvertCodeToConcept(k_);
				var m_ = context.Operators.Equivalent(j_, l_);
				var n_ = FHIRHelpers_4_3_000.ToValue(ThrombolyticAllergy?.Onset);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = FHIRHelpers_4_3_000.ToInterval(EDwSTEMI?.Period);
				var q_ = context.Operators.Overlaps(o_, p_, null);
				var r_ = context.Operators.And(m_, q_);

				return r_;
			};
			var g_ = context.Operators.Where<AllergyIntolerance>(e_, f_);
			Encounter h_(AllergyIntolerance ThrombolyticAllergy) => 
				EDwSTEMI;
			var i_ = context.Operators.Select<AllergyIntolerance, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
	public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter() => 
		__Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter.Value;

	private IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			var d_ = this.Adverse_reaction_to_thrombolytics();
			var e_ = context.Operators.RetrieveByValueSet<AdverseEvent>(d_, null);
			bool? f_(AdverseEvent ThrombolyticAdverseEvent)
			{
				var j_ = context.Operators.Convert<CqlDateTime>(ThrombolyticAdverseEvent?.RecordedDateElement);
				var k_ = FHIRHelpers_4_3_000.ToInterval(EDwSTEMI?.Period);
				var l_ = context.Operators.End(k_);
				var m_ = context.Operators.Before(j_, l_, null);
				var n_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(ThrombolyticAdverseEvent?.ActualityElement?.Value);
				var o_ = context.Operators.Equal(n_, "actual");
				var p_ = context.Operators.And(m_, o_);

				return p_;
			};
			var g_ = context.Operators.Where<AdverseEvent>(e_, f_);
			Encounter h_(AdverseEvent ThrombolyticAdverseEvent) => 
				EDwSTEMI;
			var i_ = context.Operators.Select<AdverseEvent, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
	public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter() => 
		__Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			var f_ = this.Malignant_Intracranial_Neoplasm_Group();
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			var h_ = context.Operators.ListUnion<Condition>(e_, g_);
			var i_ = this.Cerebral_Vascular_Lesion();
			var j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			var k_ = this.Dementia();
			var l_ = context.Operators.RetrieveByValueSet<Condition>(k_, null);
			var m_ = context.Operators.ListUnion<Condition>(j_, l_);
			var n_ = context.Operators.ListUnion<Condition>(h_, m_);
			var o_ = this.Pregnancy_ICD10_SNOMEDCT();
			var p_ = context.Operators.RetrieveByValueSet<Condition>(o_, null);
			var q_ = this.Allergy_to_thrombolytics();
			var r_ = context.Operators.RetrieveByValueSet<Condition>(q_, null);
			var s_ = context.Operators.ListUnion<Condition>(p_, r_);
			var t_ = context.Operators.ListUnion<Condition>(n_, s_);
			bool? u_(Condition ActiveExclusionDx)
			{
				var y_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveExclusionDx);
				var z_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
				var aa_ = context.Operators.OverlapsBefore(y_, z_, null);

				return aa_;
			};
			var v_ = context.Operators.Where<Condition>(t_, u_);
			Encounter w_(Condition ActiveExclusionDx) => 
				EDwithSTEMI;
			var x_ = context.Operators.Select<Condition, Encounter>(v_, w_);

			return x_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Active Exclusion Diagnosis at Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter() => 
		__Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Oral_Anticoagulant_Medications();
			var e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var h_ = context.Operators.ListUnion<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest OralAnticoagulant)
			{
				var m_ = context.Operators.Equal(OralAnticoagulant?.StatusElement?.Value, "active");
				var n_ = context.Operators.Equal(OralAnticoagulant?.IntentElement?.Value, "order");
				var o_ = context.Operators.And(m_, n_);
				var p_ = context.Operators.Convert<CqlDateTime>(OralAnticoagulant?.AuthoredOnElement);
				var q_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
				var r_ = context.Operators.Start(q_);
				var s_ = context.Operators.SameOrBefore(p_, r_, null);
				var t_ = context.Operators.And(o_, s_);

				return t_;
			};
			var j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest OralAnticoagulant) => 
				EDwithSTEMI;
			var l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter() => 
		__Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Aortic_Dissection_and_Rupture();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			var f_ = this.Neurologic_impairment();
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			var h_ = context.Operators.ListUnion<Condition>(e_, g_);
			var i_ = this.Cardiopulmonary_Arrest();
			var j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			var k_ = context.Operators.ListUnion<Condition>(h_, j_);
			bool? l_(Condition ExclusionDiagnosis)
			{
				var p_ = QICoreCommon_2_0_000.prevalenceInterval(ExclusionDiagnosis);
				var q_ = context.Operators.Start(p_);
				var r_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
				var s_ = context.Operators.In<CqlDateTime>(q_, r_, null);
				var u_ = context.Operators.Start(p_);
				var w_ = context.Operators.Start(r_);
				var x_ = context.Operators.Quantity(24m, "hours");
				var y_ = context.Operators.Subtract(w_, x_);
				var aa_ = context.Operators.Start(r_);
				var ab_ = context.Operators.Interval(y_, aa_, true, false);
				var ac_ = context.Operators.In<CqlDateTime>(u_, ab_, null);
				var ae_ = context.Operators.Start(r_);
				var af_ = context.Operators.Not((bool?)(ae_ is null));
				var ag_ = context.Operators.And(ac_, af_);
				var ah_ = context.Operators.Or(s_, ag_);

				return ah_;
			};
			var m_ = context.Operators.Where<Condition>(k_, l_);
			Encounter n_(Condition ExclusionDiagnosis) => 
				EDwithSTEMI;
			var o_ = context.Operators.Select<Condition, Encounter>(m_, n_);

			return o_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
	public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start() => 
		__Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start.Value;

	private IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Major_Surgical_Procedure();
			var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure MajorSurgery)
			{
				var j_ = FHIRHelpers_4_3_000.ToValue(MajorSurgery?.Performed);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
				var n_ = context.Operators.Start(m_);
				var o_ = context.Operators.Quantity(21m, "days");
				var p_ = context.Operators.Subtract(n_, o_);
				var r_ = context.Operators.Start(m_);
				var s_ = context.Operators.Interval(p_, r_, true, false);
				var t_ = context.Operators.In<CqlDateTime>(l_, s_, null);
				var v_ = context.Operators.Start(m_);
				var w_ = context.Operators.Not((bool?)(v_ is null));
				var x_ = context.Operators.And(t_, w_);
				var y_ = context.Operators.Equal(MajorSurgery?.StatusElement?.Value, "completed");
				var z_ = context.Operators.And(x_, y_);

				return z_;
			};
			var g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure MajorSurgery) => 
				EDwithSTEMI;
			var i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
	public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter() => 
		__Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter.Value;

	private IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Endotracheal_Intubation();
			var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			var f_ = this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device();
			var g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, null);
			var h_ = context.Operators.ListUnion<Procedure>(e_, g_);
			bool? i_(Procedure AirwayProcedure)
			{
				var m_ = FHIRHelpers_4_3_000.ToValue(AirwayProcedure?.Performed);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.Start(n_);
				var p_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
				var q_ = context.Operators.In<CqlDateTime>(o_, p_, null);
				var s_ = QICoreCommon_2_0_000.toInterval(m_);
				var t_ = context.Operators.Start(s_);
				var v_ = context.Operators.Start(p_);
				var w_ = context.Operators.Quantity(24m, "hours");
				var x_ = context.Operators.Subtract(v_, w_);
				var z_ = context.Operators.Start(p_);
				var aa_ = context.Operators.Interval(x_, z_, true, false);
				var ab_ = context.Operators.In<CqlDateTime>(t_, aa_, null);
				var ad_ = context.Operators.Start(p_);
				var ae_ = context.Operators.Not((bool?)(ad_ is null));
				var af_ = context.Operators.And(ab_, ae_);
				var ag_ = context.Operators.Or(q_, af_);
				var ah_ = context.Operators.Equal(AirwayProcedure?.StatusElement?.Value, "completed");
				var ai_ = context.Operators.And(ag_, ah_);

				return ai_;
			};
			var j_ = context.Operators.Where<Procedure>(h_, i_);
			Encounter k_(Procedure AirwayProcedure) => 
				EDwithSTEMI;
			var l_ = context.Operators.Select<Procedure, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
	public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start() => 
		__Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start.Value;

	private IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			var d_ = this.Ischemic_Stroke();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			var f_ = this.Closed_Head_and_Facial_Trauma();
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			var h_ = context.Operators.ListUnion<Condition>(e_, g_);
			var i_ = this.Active_Peptic_Ulcer();
			var j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			var k_ = this.Cardiopulmonary_Arrest();
			var l_ = context.Operators.RetrieveByValueSet<Condition>(k_, null);
			var m_ = context.Operators.ListUnion<Condition>(j_, l_);
			var n_ = context.Operators.ListUnion<Condition>(h_, m_);
			bool? o_(Condition ExclusionCondition)
			{
				var s_ = QICoreCommon_2_0_000.prevalenceInterval(ExclusionCondition);
				var t_ = context.Operators.Start(s_);
				var u_ = FHIRHelpers_4_3_000.ToInterval(EDwSTEMI?.Period);
				var v_ = context.Operators.Start(u_);
				var w_ = context.Operators.Quantity(90m, "days");
				var x_ = context.Operators.Subtract(v_, w_);
				var z_ = context.Operators.Start(u_);
				var aa_ = context.Operators.Interval(x_, z_, true, true);
				var ab_ = context.Operators.In<CqlDateTime>(t_, aa_, null);

				return ab_;
			};
			var p_ = context.Operators.Where<Condition>(n_, o_);
			Encounter q_(Condition ExclusionCondition) => 
				EDwSTEMI;
			var r_ = context.Operators.Select<Condition, Encounter>(p_, q_);

			return r_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter() => 
		__Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Intracranial_or_Intraspinal_surgery();
			var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure CranialorSpinalSurgery)
			{
				var j_ = FHIRHelpers_4_3_000.ToValue(CranialorSpinalSurgery?.Performed);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
				var n_ = context.Operators.Start(m_);
				var o_ = context.Operators.Quantity(90m, "days");
				var p_ = context.Operators.Subtract(n_, o_);
				var r_ = context.Operators.Start(m_);
				var s_ = context.Operators.Interval(p_, r_, true, false);
				var t_ = context.Operators.In<CqlDateTime>(l_, s_, null);
				var v_ = context.Operators.Start(m_);
				var w_ = context.Operators.Not((bool?)(v_ is null));
				var x_ = context.Operators.And(t_, w_);
				var y_ = context.Operators.Equal(CranialorSpinalSurgery?.StatusElement?.Value, "completed");
				var z_ = context.Operators.And(x_, y_);

				return z_;
			};
			var g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure CranialorSpinalSurgery) => 
				EDwithSTEMI;
			var i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
	public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter() => 
		__Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter.Value;

	private IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		bool? b_(Encounter EDwithSTEMI)
		{
			var d_ = FHIRHelpers_4_3_000.ToConcept(EDwithSTEMI?.Hospitalization?.DischargeDisposition);
			var e_ = this.Patient_Expired();
			var f_ = context.Operators.ConceptInValueSet(d_, e_);

			return f_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("ED Encounter with Discharge Disposition as Patient Expired")]
	public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired() => 
		__ED_Encounter_with_Discharge_Disposition_as_Patient_Expired.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter();
		var b_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter();
		var e_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter();
		var f_ = context.Operators.ListUnion<Encounter>(d_, e_);
		var g_ = context.Operators.ListUnion<Encounter>(c_, f_);
		var h_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start();
		var i_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter();
		var j_ = context.Operators.ListUnion<Encounter>(h_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(g_, j_);
		var l_ = this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start();
		var m_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter();
		var n_ = context.Operators.ListUnion<Encounter>(l_, m_);
		var o_ = context.Operators.ListUnion<Encounter>(k_, n_);
		var p_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter();
		var q_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired();
		var r_ = context.Operators.ListUnion<Encounter>(p_, q_);
		var s_ = context.Operators.ListUnion<Encounter>(o_, r_);

		return s_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

    [CqlDeclaration("currentemergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
	public CqlDateTime currentemergencyDepartmentArrivalTime(Encounter EDEncounter)
	{
		bool? a_(Encounter.LocationComponent EDLocation)
		{
			var f_ = CQMCommon_2_0_000.GetLocation(EDLocation?.Location);
			CqlConcept g_(CodeableConcept @this)
			{
				var k_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return k_;
			};
			var h_ = context.Operators.Select<CodeableConcept, CqlConcept>(f_?.Type, g_);
			var i_ = this.Emergency_Department_Visit();
			var j_ = context.Operators.ConceptsInValueSet(h_, i_);

			return j_;
		};
		var b_ = context.Operators.Where<Encounter.LocationComponent>((EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>), a_);
		var c_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(b_);
		var d_ = FHIRHelpers_4_3_000.ToInterval(c_?.Period);
		var e_ = context.Operators.Start(d_);

		return e_;
	}

	private IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Fibrinolytic_Therapy();
			var e_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(d_, null);
			var h_ = context.Operators.ListUnion<MedicationAdministration>(e_, g_);
			bool? i_(MedicationAdministration Fibrinolytic)
			{
				var m_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(Fibrinolytic?.StatusElement?.Value);
				var n_ = context.Operators.Equal(m_, "completed");
				var o_ = FHIRHelpers_4_3_000.ToValue(Fibrinolytic?.Effective);
				var p_ = QICoreCommon_2_0_000.toInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = this.currentemergencyDepartmentArrivalTime(EDwithSTEMI);
				var t_ = context.Operators.Quantity(30m, "minutes");
				var u_ = context.Operators.Add(r_, t_);
				var v_ = context.Operators.Interval(r_, u_, false, true);
				var w_ = context.Operators.In<CqlDateTime>(q_, v_, null);
				var y_ = context.Operators.Not((bool?)(r_ is null));
				var z_ = context.Operators.And(w_, y_);
				var aa_ = context.Operators.And(n_, z_);

				return aa_;
			};
			var j_ = context.Operators.Where<MedicationAdministration>(h_, i_);
			Encounter k_(MedicationAdministration Fibrinolytic) => 
				EDwithSTEMI;
			var l_ = context.Operators.Select<MedicationAdministration, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Fibrinolytic Therapy within 30 Minutes of Arrival")]
	public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival() => 
		__Fibrinolytic_Therapy_within_30_Minutes_of_Arrival.Value;

	private IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			var d_ = this.Percutaneous_Coronary_Intervention();
			var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure PCI)
			{
				var j_ = FHIRHelpers_4_3_000.ToValue(PCI?.Performed);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = this.currentemergencyDepartmentArrivalTime(EDwithSTEMI);
				var o_ = context.Operators.Quantity(90m, "minutes");
				var p_ = context.Operators.Add(m_, o_);
				var q_ = context.Operators.Interval(m_, p_, false, true);
				var r_ = context.Operators.In<CqlDateTime>(l_, q_, null);
				var t_ = context.Operators.Not((bool?)(m_ is null));
				var u_ = context.Operators.And(r_, t_);
				var v_ = context.Operators.Equal(PCI?.StatusElement?.Value, "completed");
				var w_ = context.Operators.And(u_, v_);

				return w_;
			};
			var g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure PCI) => 
				EDwithSTEMI;
			var i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("PCI within 90 Minutes of Arrival")]
	public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival() => 
		__PCI_within_90_Minutes_of_Arrival.Value;

	private IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival_Value()
	{
		var a_ = this.ED_Encounter_with_STEMI_Diagnosis();
		bool? b_(Encounter EDwithSTEMI)
		{
			var d_ = FHIRHelpers_4_3_000.ToInterval(EDwithSTEMI?.Period);
			var e_ = context.Operators.End(d_);
			var g_ = context.Operators.Start(d_);
			var i_ = context.Operators.Start(d_);
			var j_ = context.Operators.Quantity(45m, "minutes");
			var k_ = context.Operators.Add(i_, j_);
			var l_ = context.Operators.Interval(g_, k_, false, true);
			var m_ = context.Operators.In<CqlDateTime>(e_, l_, null);
			var o_ = context.Operators.Start(d_);
			var p_ = context.Operators.Not((bool?)(o_ is null));
			var q_ = context.Operators.And(m_, p_);
			var r_ = FHIRHelpers_4_3_000.ToConcept(EDwithSTEMI?.Hospitalization?.DischargeDisposition);
			var s_ = this.Discharge_To_Acute_Care_Facility();
			var t_ = context.Operators.ConceptInValueSet(r_, s_);
			var u_ = context.Operators.And(q_, t_);

			return u_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
	public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival() => 
		__ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival();
		var b_ = this.PCI_within_90_Minutes_of_Arrival();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival();
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
