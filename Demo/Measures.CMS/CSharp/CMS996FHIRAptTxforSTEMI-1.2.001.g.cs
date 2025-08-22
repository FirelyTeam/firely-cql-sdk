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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS996FHIRAptTxforSTEMI", "1.2.001")]
public partial class CMS996FHIRAptTxforSTEMI_1_2_001 : ILibrary, ISingleton<CMS996FHIRAptTxforSTEMI_1_2_001>
{
    private CMS996FHIRAptTxforSTEMI_1_2_001() {}

    public static CMS996FHIRAptTxforSTEMI_1_2_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS996FHIRAptTxforSTEMI";
    public string Version => "1.2.001";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Active Bleeding Excluding Menses or Bleeding Diathesis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", valueSetVersion: null)]
    public CqlValueSet Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(CqlContext _) => _Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis;
    private static readonly CqlValueSet _Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", null);

    [CqlValueSetDefinition("Active Peptic Ulcer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", valueSetVersion: null)]
    public CqlValueSet Active_Peptic_Ulcer(CqlContext _) => _Active_Peptic_Ulcer;
    private static readonly CqlValueSet _Active_Peptic_Ulcer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", null);

    [CqlValueSetDefinition("Thrombolytics Adverse Event", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", valueSetVersion: null)]
    public CqlValueSet Thrombolytics_Adverse_Event(CqlContext _) => _Thrombolytics_Adverse_Event;
    private static readonly CqlValueSet _Thrombolytics_Adverse_Event = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", null);

    [CqlValueSetDefinition("Allergy to thrombolytics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", valueSetVersion: null)]
    public CqlValueSet Allergy_to_thrombolytics(CqlContext _) => _Allergy_to_thrombolytics;
    private static readonly CqlValueSet _Allergy_to_thrombolytics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", null);

    [CqlValueSetDefinition("Oral Anticoagulant Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", valueSetVersion: null)]
    public CqlValueSet Oral_Anticoagulant_Medications(CqlContext _) => _Oral_Anticoagulant_Medications;
    private static readonly CqlValueSet _Oral_Anticoagulant_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", null);

    [CqlValueSetDefinition("Aortic Dissection or Ruptured Aortic Aneurysm", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", valueSetVersion: null)]
    public CqlValueSet Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(CqlContext _) => _Aortic_Dissection_or_Ruptured_Aortic_Aneurysm;
    private static readonly CqlValueSet _Aortic_Dissection_or_Ruptured_Aortic_Aneurysm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", null);

    [CqlValueSetDefinition("Cardiopulmonary Arrest", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", valueSetVersion: null)]
    public CqlValueSet Cardiopulmonary_Arrest(CqlContext _) => _Cardiopulmonary_Arrest;
    private static readonly CqlValueSet _Cardiopulmonary_Arrest = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", null);

    [CqlValueSetDefinition("Cerebral Vascular Lesion", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", valueSetVersion: null)]
    public CqlValueSet Cerebral_Vascular_Lesion(CqlContext _) => _Cerebral_Vascular_Lesion;
    private static readonly CqlValueSet _Cerebral_Vascular_Lesion = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", null);

    [CqlValueSetDefinition("Closed Head and Facial Trauma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", valueSetVersion: null)]
    public CqlValueSet Closed_Head_and_Facial_Trauma(CqlContext _) => _Closed_Head_and_Facial_Trauma;
    private static readonly CqlValueSet _Closed_Head_and_Facial_Trauma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", null);

    [CqlValueSetDefinition("Dementia and Related Intracranial Pathologies", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", valueSetVersion: null)]
    public CqlValueSet Dementia_and_Related_Intracranial_Pathologies(CqlContext _) => _Dementia_and_Related_Intracranial_Pathologies;
    private static readonly CqlValueSet _Dementia_and_Related_Intracranial_Pathologies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Endotracheal Intubation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", valueSetVersion: null)]
    public CqlValueSet Endotracheal_Intubation(CqlContext _) => _Endotracheal_Intubation;
    private static readonly CqlValueSet _Endotracheal_Intubation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", null);

    [CqlValueSetDefinition("Fibrinolytic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4019", valueSetVersion: null)]
    public CqlValueSet Fibrinolytic_Therapy(CqlContext _) => _Fibrinolytic_Therapy;
    private static readonly CqlValueSet _Fibrinolytic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4019", null);

    [CqlValueSetDefinition("Intracranial or Intraspinal surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", valueSetVersion: null)]
    public CqlValueSet Intracranial_or_Intraspinal_surgery(CqlContext _) => _Intracranial_or_Intraspinal_surgery;
    private static readonly CqlValueSet _Intracranial_or_Intraspinal_surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Major Surgical Procedure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", valueSetVersion: null)]
    public CqlValueSet Major_Surgical_Procedure(CqlContext _) => _Major_Surgical_Procedure;
    private static readonly CqlValueSet _Major_Surgical_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", null);

    [CqlValueSetDefinition("Malignant Intracranial Neoplasm Group", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", valueSetVersion: null)]
    public CqlValueSet Malignant_Intracranial_Neoplasm_Group(CqlContext _) => _Malignant_Intracranial_Neoplasm_Group;
    private static readonly CqlValueSet _Malignant_Intracranial_Neoplasm_Group = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", null);

    [CqlValueSetDefinition("Insertion or Replacement of Mechanical Circulatory Assist Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", valueSetVersion: null)]
    public CqlValueSet Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(CqlContext _) => _Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device;
    private static readonly CqlValueSet _Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", null);

    [CqlValueSetDefinition("Neurologic impairment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", valueSetVersion: null)]
    public CqlValueSet Neurologic_impairment(CqlContext _) => _Neurologic_impairment;
    private static readonly CqlValueSet _Neurologic_impairment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Percutaneous Coronary Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", valueSetVersion: null)]
    public CqlValueSet Percutaneous_Coronary_Intervention(CqlContext _) => _Percutaneous_Coronary_Intervention;
    private static readonly CqlValueSet _Percutaneous_Coronary_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", null);

    [CqlValueSetDefinition("Pregnant State", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", valueSetVersion: null)]
    public CqlValueSet Pregnant_State(CqlContext _) => _Pregnant_State;
    private static readonly CqlValueSet _Pregnant_State = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", null);

    [CqlValueSetDefinition("STEMI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", valueSetVersion: null)]
    public CqlValueSet STEMI(CqlContext _) => _STEMI;
    private static readonly CqlValueSet _STEMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", null);

    [CqlValueSetDefinition("Thrombolytic medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", valueSetVersion: null)]
    public CqlValueSet Thrombolytic_medications(CqlContext _) => _Thrombolytic_medications;
    private static readonly CqlValueSet _Thrombolytic_medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Hospice Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", valueSetVersion: null)]
    public CqlValueSet Hospice_Diagnosis(CqlContext _) => _Hospice_Diagnosis;
    private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);

    [CqlValueSetDefinition("Insertion, Replacement, or Removal of Mechanical Circulatory Assist Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", valueSetVersion: null)]
    public CqlValueSet Insertion__Replacement__or_Removal_of_Mechanical_Circulatory_Assist_Device(CqlContext _) => _Insertion__Replacement__or_Removal_of_Mechanical_Circulatory_Assist_Device;
    private static readonly CqlValueSet _Insertion__Replacement__or_Removal_of_Mechanical_Circulatory_Assist_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Drug Intervention Not Indicated/Contraindicated", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.1", valueSetVersion: null)]
    public CqlValueSet Drug_Intervention_Not_Indicated_Contraindicated(CqlContext _) => _Drug_Intervention_Not_Indicated_Contraindicated;
    private static readonly CqlValueSet _Drug_Intervention_Not_Indicated_Contraindicated = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.1", null);

    [CqlValueSetDefinition("Procedure Not Indicated/Contraindicated", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.2", valueSetVersion: null)]
    public CqlValueSet Procedure_Not_Indicated_Contraindicated(CqlContext _) => _Procedure_Not_Indicated_Contraindicated;
    private static readonly CqlValueSet _Procedure_Not_Indicated_Contraindicated = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.2", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("EMER", codeId: "EMER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode EMER(CqlContext _) => _EMER;
    private static readonly CqlCode _EMER = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility", codeId: "Z92.82", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(CqlContext _) => _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility;
    private static readonly CqlCode _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility = new CqlCode("Z92.82", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Angina pectoris with documented spasm", codeId: "I20.1", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Angina_pectoris_with_documented_spasm(CqlContext _) => _Angina_pectoris_with_documented_spasm;
    private static readonly CqlCode _Angina_pectoris_with_documented_spasm = new CqlCode("I20.1", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Long term (current) use of anticoagulants", codeId: "Z79.01", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Long_term__current__use_of_anticoagulants(CqlContext _) => _Long_term__current__use_of_anticoagulants;
    private static readonly CqlCode _Long_term__current__use_of_anticoagulants = new CqlCode("Z79.01", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Takotsubo cardiomyopathy (disorder)", codeId: "441541008", codeSystem: "http://snomed.info/sct")]
    public CqlCode Takotsubo_cardiomyopathy__disorder_(CqlContext _) => _Takotsubo_cardiomyopathy__disorder_;
    private static readonly CqlCode _Takotsubo_cardiomyopathy__disorder_ = new CqlCode("441541008", "http://snomed.info/sct");

    [CqlCodeDefinition("Takotsubo syndrome", codeId: "I51.81", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Takotsubo_syndrome(CqlContext _) => _Takotsubo_syndrome;
    private static readonly CqlCode _Takotsubo_syndrome = new CqlCode("I51.81", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Ventricular aneurysm due to and following acute myocardial infarction (disorder)", codeId: "723858002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_(CqlContext _) => _Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_;
    private static readonly CqlCode _Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_ = new CqlCode("723858002", "http://snomed.info/sct");

    [CqlCodeDefinition("Aneurysm of heart", codeId: "I25.3", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Aneurysm_of_heart(CqlContext _) => _Aneurysm_of_heart;
    private static readonly CqlCode _Aneurysm_of_heart = new CqlCode("I25.3", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Hospice_care__Minimum_Data_Set_]);

    [CqlCodeSystemDefinition("HSLOC", codeSystemId: "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", codeSystemVersion: null)]
    public CqlCodeSystem HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem _HSLOC =
      new CqlCodeSystem("https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", null, []);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Takotsubo_cardiomyopathy__disorder_,
          _Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_,
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _EMER]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility,
          _Angina_pectoris_with_documented_spasm,
          _Long_term__current__use_of_anticoagulants,
          _Takotsubo_syndrome,
          _Aneurysm_of_heart]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2026, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("CMS996FHIRAptTxforSTEMI-1.2.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("ED Encounter During MP")]
    public IEnumerable<Encounter> ED_Encounter_During_MP(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter EDEncounter)
        {
            Period e_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, "day");
            Code<Encounter.EncounterStatus> j_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? k_ = j_?.Value;
            Code<Encounter.EncounterStatus> l_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(k_);
            bool? m_ = context.Operators.Equal(l_, "finished");
            bool? n_ = context.Operators.And(i_, m_);
            Coding o_ = EDEncounter?.Class;
            CqlCode p_ = FHIRHelpers_4_4_000.Instance.ToCode(context, o_);
            CqlCode q_ = this.EMER(context);
            bool? r_ = context.Operators.Equivalent(p_, q_);
            bool? s_ = context.Operators.And(n_, r_);

            return s_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_During_MP(context);
        bool? b_(Encounter EDEncounter)
        {
            List<CodeableConcept> d_ = EDEncounter?.ReasonCode;
            CqlConcept e_(CodeableConcept @this)
            {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return t_;
            };
            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.STEMI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, EDEncounter);
            bool? j_(Condition EncDiagnosis)
            {
                CodeableConcept u_ = EncDiagnosis?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.STEMI(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);

                return x_;
            };
            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            bool? m_ = context.Operators.Or(h_, l_);
            IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? p_(Condition DxSTEMI)
            {
                CodeableConcept y_ = DxSTEMI?.ClinicalStatus;
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                CqlCode aa_ = QICoreCommon_2_1_000.Instance.active(context);
                CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                bool? ac_ = context.Operators.Equivalent(z_, ab_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                Period af_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                bool? ah_ = context.Operators.In<CqlDateTime>(ae_, ag_, default);
                bool? ai_ = context.Operators.And(ac_, ah_);

                return ai_;
            };
            IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
            bool? r_ = context.Operators.Exists<Condition>(q_);
            bool? s_ = context.Operators.Or(m_, r_);

            return s_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? b_(Encounter EDwithSTEMI)
        {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);

            return m_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
    public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            CqlValueSet d_ = this.Thrombolytic_medications(context);
            IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
            bool? f_(AllergyIntolerance ThrombolyticAllergy)
            {
                CodeableConcept j_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlCode l_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                DataType o_ = ThrombolyticAllergy?.Onset;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_2_1_000.Instance.toInterval(context, p_);
                Period r_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
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


    [CqlExpressionDefinition("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
    public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            CqlValueSet d_ = this.Thrombolytics_Adverse_Event(context);
            IEnumerable<AdverseEvent> e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? f_(AdverseEvent ThrombolyticAdverseEvent)
            {
                FhirDateTime j_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                Period l_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
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


    [CqlExpressionDefinition("Active Exclusion Diagnosis at Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet f_ = this.Malignant_Intracranial_Neoplasm_Group(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet i_ = this.Cerebral_Vascular_Lesion(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet k_ = this.Dementia_and_Related_Intracranial_Pathologies(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
            IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
            CqlValueSet o_ = this.Pregnant_State(context);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet q_ = this.Allergy_to_thrombolytics(context);
            IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_, r_);
            IEnumerable<Condition> t_ = context.Operators.Union<Condition>(n_, s_);
            bool? u_(Condition ActiveExclusionDx)
            {
                CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period z_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
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


    [CqlExpressionDefinition("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> g_(MedicationRequest MR)
            {
                IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? o_(Medication M)
                {
                    object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(s_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Oral_Anticoagulant_Medications(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);

                    return ab_;
                };
                IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                MedicationRequest q_(Medication M) =>
                    MR;
                IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);

                return r_;
            };
            IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);
            bool? j_(MedicationRequest OralAnticoagulant)
            {
                Code<MedicationRequest.MedicationrequestStatus> ac_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                bool? af_ = context.Operators.Equal(ae_, "active");
                Code<MedicationRequest.MedicationRequestIntent> ag_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ah_ = ag_?.Value;
                string ai_ = context.Operators.Convert<string>(ah_);
                bool? aj_ = context.Operators.Equal(ai_, "order");
                bool? ak_ = context.Operators.And(af_, aj_);
                FhirDateTime al_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime am_ = context.Operators.Convert<CqlDateTime>(al_);
                Period an_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlInterval<CqlDateTime> av_ = context.Operators.Interval(ar_, au_, true, true);
                bool? aw_ = context.Operators.In<CqlDateTime>(am_, av_, default);
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                bool? ba_ = context.Operators.Not((bool?)(az_ is null));
                bool? bb_ = context.Operators.And(aw_, ba_);
                bool? bc_ = context.Operators.And(ak_, bb_);

                return bc_;
            };
            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            Encounter l_(MedicationRequest OralAnticoagulant) =>
                EDwithSTEMI;
            IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);

            return m_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Active Long Term use of Anticoagulants")]
    public IEnumerable<Encounter> Active_Long_Term_use_of_Anticoagulants(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlCode d_ = this.Long_term__current__use_of_anticoagulants(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? g_(Condition LongTermAnticoagulant)
            {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LongTermAnticoagulant);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                bool? p_ = context.Operators.SameOrBefore(l_, o_, default);
                CqlDateTime r_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime u_ = context.Operators.Start(t_);
                bool? v_ = context.Operators.SameOrAfter(r_, u_, default);
                bool? w_ = context.Operators.And(p_, v_);

                return w_;
            };
            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Encounter i_(Condition LongTermAnticoagulant) =>
                EDwithSTEMI;
            IEnumerable<Encounter> j_ = context.Operators.Select<Condition, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Active use of Anticoagulants")]
    public IEnumerable<Encounter> Active_use_of_Anticoagulants(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> b_ = this.Active_Long_Term_use_of_Anticoagulants(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet f_ = this.Neurologic_impairment(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlCode i_ = this.Angina_pectoris_with_documented_spasm(context);
            IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlCode l_ = this.Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_(context);
            IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
            IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> o_ = context.Operators.Union<Condition>(k_, n_);
            IEnumerable<Condition> p_ = context.Operators.Union<Condition>(h_, o_);
            CqlCode q_ = this.Aneurysm_of_heart(context);
            IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
            IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlCode t_ = this.Takotsubo_cardiomyopathy__disorder_(context);
            IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
            IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> w_ = context.Operators.Union<Condition>(s_, v_);
            IEnumerable<Condition> x_ = context.Operators.Union<Condition>(p_, w_);
            CqlCode y_ = this.Takotsubo_syndrome(context);
            IEnumerable<CqlCode> z_ = context.Operators.ToList<CqlCode>(y_);
            IEnumerable<Condition> aa_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ab_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> ac_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ad_ = context.Operators.Union<Condition>(aa_, ac_);
            IEnumerable<Condition> ae_ = context.Operators.Union<Condition>(x_, ad_);
            bool? af_(Condition ExclusionDiagnosis)
            {
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                Period al_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                bool? an_ = context.Operators.In<CqlDateTime>(ak_, am_, default);
                CqlDateTime ap_ = context.Operators.Start(aj_);
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlQuantity at_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime au_ = context.Operators.Subtract(as_, at_);
                CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlDateTime ax_ = context.Operators.Start(aw_);
                CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(au_, ax_, true, false);
                bool? az_ = context.Operators.In<CqlDateTime>(ap_, ay_, default);
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
                bool? be_ = context.Operators.And(az_, bd_);
                bool? bf_ = context.Operators.Or(an_, be_);

                return bf_;
            };
            IEnumerable<Condition> ag_ = context.Operators.Where<Condition>(ae_, af_);
            Encounter ah_(Condition ExclusionDiagnosis) =>
                EDwithSTEMI;
            IEnumerable<Encounter> ai_ = context.Operators.Select<Condition, Encounter>(ag_, ah_);

            return ai_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Major Surgical Procedure 21 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure MajorSurgery)
            {
                DataType j_ = MajorSurgery?.Performed;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.toInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                Period n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(21m, "days");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
                bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
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


    [CqlExpressionDefinition("Intubation or Mechanical Circulatory Assist Device Placement or Removal Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Endotracheal_Intubation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet f_ = this.Insertion__Replacement__or_Removal_of_Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
            bool? i_(Procedure AirwayProcedure)
            {
                DataType m_ = AirwayProcedure?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                Period q_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, default);
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_2_1_000.Instance.toInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlQuantity aa_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ab_, ae_, true, false);
                bool? ag_ = context.Operators.In<CqlDateTime>(w_, af_, default);
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
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


    [CqlExpressionDefinition("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            CqlValueSet d_ = this.Ischemic_Stroke(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet f_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet i_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
            bool? l_(Condition ExclusionCondition)
            {
                CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime q_ = context.Operators.Start(p_);
                Period r_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlQuantity u_ = context.Operators.Quantity(90m, "days");
                CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, default);

                return aa_;
            };
            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            Encounter n_(Condition ExclusionCondition) =>
                EDwSTEMI;
            IEnumerable<Encounter> o_ = context.Operators.Select<Condition, Encounter>(m_, n_);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Intracranial_or_Intraspinal_surgery(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure CranialorSpinalSurgery)
            {
                DataType j_ = CranialorSpinalSurgery?.Performed;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.toInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                Period n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(90m, "days");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
                bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
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


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Patient Expired")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? b_(Encounter EDwithSTEMI)
        {
            Encounter.HospitalizationComponent d_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Patient_Expired(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Left Against Medical Advice")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? b_(Encounter EDwSTEMI)
        {
            Encounter.HospitalizationComponent d_ = EDwSTEMI?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Left_Against_Medical_Advice(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Hospice Services")]
    public IEnumerable<Encounter> ED_Encounter_with_Hospice_Services(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? b_(Encounter EDwSTEMI)
        {
            CqlValueSet d_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> e_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> f_ = Status_1_8_000.Instance.isEncounterPerformed(context, e_);
            bool? g_(Encounter InpatientEncounter)
            {
                Encounter.HospitalizationComponent as_ = InpatientEncounter?.Hospitalization;
                CodeableConcept at_ = as_?.DischargeDisposition;
                CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, at_);
                CqlCode av_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept aw_ = context.Operators.ConvertCodeToConcept(av_);
                bool? ax_ = context.Operators.Equivalent(au_, aw_);
                CodeableConcept az_ = as_?.DischargeDisposition;
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                CqlCode bb_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                bool? be_ = context.Operators.Or(ax_, bd_);
                Period bf_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_2_1_000.Instance.toInterval(context, bg_ as object);
                CqlDateTime bi_ = context.Operators.Start(bh_);
                Period bj_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                bool? bm_ = context.Operators.SameOrBefore(bi_, bl_, default);
                bool? bn_ = context.Operators.And(be_, bm_);
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlInterval<CqlDateTime> bq_ = QICoreCommon_2_1_000.Instance.toInterval(context, bp_ as object);
                CqlDateTime br_ = context.Operators.End(bq_);
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                CqlQuantity bv_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bw_ = context.Operators.Subtract(bu_, bv_);
                CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bz_ = context.Operators.Start(by_);
                CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bw_, bz_, true, false);
                bool? cb_ = context.Operators.In<CqlDateTime>(br_, ca_, "day");
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                bool? cf_ = context.Operators.Not((bool?)(ce_ is null));
                bool? cg_ = context.Operators.And(cb_, cf_);
                CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ci_ as object);
                CqlDateTime ck_ = context.Operators.End(cj_);
                CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime cn_ = context.Operators.Start(cm_);
                bool? co_ = context.Operators.SameOrAfter(ck_, cn_, default);
                bool? cp_ = context.Operators.Or(cg_, co_);
                bool? cq_ = context.Operators.And(bn_, cp_);

                return cq_;
            };
            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            bool? i_ = context.Operators.Exists<Encounter>(h_);
            CqlValueSet j_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> k_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> l_ = Status_1_8_000.Instance.isEncounterPerformed(context, k_);
            bool? m_(Encounter HospiceEncounter)
            {
                Period cr_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_1_000.Instance.toInterval(context, cs_ as object);
                CqlDateTime cu_ = context.Operators.Start(ct_);
                Period cv_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                bool? cy_ = context.Operators.SameOrBefore(cu_, cx_, default);
                CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                CqlInterval<CqlDateTime> db_ = QICoreCommon_2_1_000.Instance.toInterval(context, da_ as object);
                CqlDateTime dc_ = context.Operators.End(db_);
                CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime df_ = context.Operators.Start(de_);
                CqlQuantity dg_ = context.Operators.Quantity(6m, "months");
                CqlDateTime dh_ = context.Operators.Subtract(df_, dg_);
                CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime dk_ = context.Operators.Start(dj_);
                CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(dh_, dk_, true, false);
                bool? dm_ = context.Operators.In<CqlDateTime>(dc_, dl_, "day");
                CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime dp_ = context.Operators.Start(do_);
                bool? dq_ = context.Operators.Not((bool?)(dp_ is null));
                bool? dr_ = context.Operators.And(dm_, dq_);
                CqlInterval<CqlDateTime> dt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                CqlInterval<CqlDateTime> du_ = QICoreCommon_2_1_000.Instance.toInterval(context, dt_ as object);
                CqlDateTime dv_ = context.Operators.End(du_);
                CqlInterval<CqlDateTime> dx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime dy_ = context.Operators.Start(dx_);
                bool? dz_ = context.Operators.SameOrAfter(dv_, dy_, default);
                bool? ea_ = context.Operators.Or(dr_, dz_);
                bool? eb_ = context.Operators.And(cy_, ea_);

                return eb_;
            };
            IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
            bool? o_ = context.Operators.Exists<Encounter>(n_);
            bool? p_ = context.Operators.Or(i_, o_);
            CqlCode q_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
            IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            IEnumerable<Observation> t_ = Status_1_8_000.Instance.isAssessmentPerformed(context, s_);
            bool? u_(Observation HospiceAssessment)
            {
                DataType ec_ = HospiceAssessment?.Value;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                CqlCode ee_ = this.Yes__qualifier_value_(context);
                CqlConcept ef_ = context.Operators.ConvertCodeToConcept(ee_);
                bool? eg_ = context.Operators.Equivalent(ed_ as CqlConcept, ef_);
                DataType eh_ = HospiceAssessment?.Effective;
                object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                CqlInterval<CqlDateTime> ej_ = QICoreCommon_2_1_000.Instance.toInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.Start(ej_);
                Period el_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                CqlDateTime en_ = context.Operators.Start(em_);
                bool? eo_ = context.Operators.SameOrBefore(ek_, en_, default);
                bool? ep_ = context.Operators.And(eg_, eo_);
                object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                CqlInterval<CqlDateTime> es_ = QICoreCommon_2_1_000.Instance.toInterval(context, er_);
                CqlDateTime et_ = context.Operators.End(es_);
                CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                CqlDateTime ew_ = context.Operators.Start(ev_);
                CqlQuantity ex_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ey_ = context.Operators.Subtract(ew_, ex_);
                CqlInterval<CqlDateTime> fa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                CqlDateTime fb_ = context.Operators.Start(fa_);
                CqlInterval<CqlDateTime> fc_ = context.Operators.Interval(ey_, fb_, true, false);
                bool? fd_ = context.Operators.In<CqlDateTime>(et_, fc_, "day");
                CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                CqlDateTime fg_ = context.Operators.Start(ff_);
                bool? fh_ = context.Operators.Not((bool?)(fg_ is null));
                bool? fi_ = context.Operators.And(fd_, fh_);
                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                CqlInterval<CqlDateTime> fl_ = QICoreCommon_2_1_000.Instance.toInterval(context, fk_);
                CqlDateTime fm_ = context.Operators.End(fl_);
                CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                CqlDateTime fp_ = context.Operators.Start(fo_);
                bool? fq_ = context.Operators.SameOrAfter(fm_, fp_, default);
                bool? fr_ = context.Operators.Or(fi_, fq_);
                bool? fs_ = context.Operators.And(ep_, fr_);

                return fs_;
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(t_, u_);
            bool? w_ = context.Operators.Exists<Observation>(v_);
            bool? x_ = context.Operators.Or(p_, w_);
            CqlValueSet y_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> z_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> aa_ = Status_1_8_000.Instance.isInterventionOrder(context, z_);
            bool? ab_(ServiceRequest HospiceOrder)
            {
                FhirDateTime ft_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime fu_ = context.Operators.Convert<CqlDateTime>(ft_);
                CqlInterval<CqlDateTime> fv_ = QICoreCommon_2_1_000.Instance.toInterval(context, fu_ as object);
                CqlDateTime fw_ = context.Operators.End(fv_);
                Period fx_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> fy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fx_);
                CqlDateTime fz_ = context.Operators.Start(fy_);
                CqlQuantity ga_ = context.Operators.Quantity(6m, "months");
                CqlDateTime gb_ = context.Operators.Subtract(fz_, ga_);
                CqlInterval<CqlDateTime> gd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fx_);
                CqlDateTime ge_ = context.Operators.Start(gd_);
                CqlInterval<CqlDateTime> gf_ = context.Operators.Interval(gb_, ge_, true, false);
                bool? gg_ = context.Operators.In<CqlDateTime>(fw_, gf_, default);
                CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fx_);
                CqlDateTime gj_ = context.Operators.Start(gi_);
                bool? gk_ = context.Operators.Not((bool?)(gj_ is null));
                bool? gl_ = context.Operators.And(gg_, gk_);

                return gl_;
            };
            IEnumerable<ServiceRequest> ac_ = context.Operators.Where<ServiceRequest>(aa_, ab_);
            bool? ad_ = context.Operators.Exists<ServiceRequest>(ac_);
            bool? ae_ = context.Operators.Or(x_, ad_);
            IEnumerable<Procedure> ag_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> ah_ = Status_1_8_000.Instance.isInterventionPerformed(context, ag_);
            bool? ai_(Procedure HospicePerformed)
            {
                DataType gm_ = HospicePerformed?.Performed;
                object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                CqlInterval<CqlDateTime> go_ = QICoreCommon_2_1_000.Instance.toInterval(context, gn_);
                CqlDateTime gp_ = context.Operators.Start(go_);
                Period gq_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> gr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                CqlDateTime gs_ = context.Operators.Start(gr_);
                bool? gt_ = context.Operators.SameOrBefore(gp_, gs_, default);
                object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                CqlInterval<CqlDateTime> gw_ = QICoreCommon_2_1_000.Instance.toInterval(context, gv_);
                CqlDateTime gx_ = context.Operators.End(gw_);
                CqlInterval<CqlDateTime> gz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                CqlDateTime ha_ = context.Operators.Start(gz_);
                CqlQuantity hb_ = context.Operators.Quantity(6m, "months");
                CqlDateTime hc_ = context.Operators.Subtract(ha_, hb_);
                CqlInterval<CqlDateTime> he_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                CqlDateTime hf_ = context.Operators.Start(he_);
                CqlInterval<CqlDateTime> hg_ = context.Operators.Interval(hc_, hf_, true, false);
                bool? hh_ = context.Operators.In<CqlDateTime>(gx_, hg_, "day");
                CqlInterval<CqlDateTime> hj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                CqlDateTime hk_ = context.Operators.Start(hj_);
                bool? hl_ = context.Operators.Not((bool?)(hk_ is null));
                bool? hm_ = context.Operators.And(hh_, hl_);
                object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                CqlInterval<CqlDateTime> hp_ = QICoreCommon_2_1_000.Instance.toInterval(context, ho_);
                CqlDateTime hq_ = context.Operators.End(hp_);
                CqlInterval<CqlDateTime> hs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gq_);
                CqlDateTime ht_ = context.Operators.Start(hs_);
                bool? hu_ = context.Operators.SameOrAfter(hq_, ht_, default);
                bool? hv_ = context.Operators.Or(hm_, hu_);
                bool? hw_ = context.Operators.And(gt_, hv_);

                return hw_;
            };
            IEnumerable<Procedure> aj_ = context.Operators.Where<Procedure>(ah_, ai_);
            bool? ak_ = context.Operators.Exists<Procedure>(aj_);
            bool? al_ = context.Operators.Or(ae_, ak_);
            CqlValueSet am_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ao_(Condition HospiceCareDiagnosis)
            {
                CqlInterval<CqlDateTime> hx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlDateTime hy_ = context.Operators.End(hx_);
                Period hz_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ia_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hz_);
                CqlDateTime ib_ = context.Operators.Start(ia_);
                bool? ic_ = context.Operators.SameOrAfter(hy_, ib_, default);

                return ic_;
            };
            IEnumerable<Condition> ap_ = context.Operators.Where<Condition>(an_, ao_);
            bool? aq_ = context.Operators.Exists<Condition>(ap_);
            bool? ar_ = context.Operators.Or(al_, aq_);

            return ar_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
        IEnumerable<Encounter> b_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> e_ = this.Active_use_of_Anticoagulants(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> i_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
        IEnumerable<Encounter> l_ = this.Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> m_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(k_, n_);
        IEnumerable<Encounter> p_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> q_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(context);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
        IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(o_, r_);
        IEnumerable<Encounter> t_ = this.ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice(context);
        IEnumerable<Encounter> u_ = this.ED_Encounter_with_Hospice_Services(context);
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(t_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(s_, v_);

        return w_;
    }


    [CqlExpressionDefinition("Received tPA in Another Facility within 24 hours Prior to Admission")]
    public IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlCode d_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? g_(Condition TPA)
            {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? o_ = context.Operators.In<CqlDateTime>(l_, n_, default);

                return o_;
            };
            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Encounter i_(Condition TPA) =>
                EDwithSTEMI;
            IEnumerable<Encounter> j_ = context.Operators.Select<Condition, Encounter>(h_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Documented Reason for No PCI Performed Within 90 Minutes of ED Arrival")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> Documented_Reason_for_No_PCI_Performed_Within_90_Minutes_of_ED_Arrival(CqlContext context)
    {
        CqlValueSet a_ = this.Percutaneous_Coronary_Intervention(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> d_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
        IEnumerable<Procedure> e_ = context.Operators.Union<Procedure>(b_, d_);
        bool? f_(Procedure PCINotDone)
        {
            CodeableConcept k_ = PCINotDone?.StatusReason;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlValueSet m_ = this.Patient_Refusal(context);
            bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlValueSet q_ = this.Procedure_Not_Indicated_Contraindicated(context);
            bool? r_ = context.Operators.ConceptInValueSet(p_, q_);
            bool? s_ = context.Operators.Or(n_, r_);

            return s_;
        };
        IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? h_(Procedure PCINotDone)
        {
            Id t_ = PCINotDone?.IdElement;
            string u_ = t_?.Value;
            bool? v_(Extension @this)
            {
                string ac_ = @this?.Url;
                FhirString ad_ = context.Operators.Convert<FhirString>(ac_);
                string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                return af_;
            };
            IEnumerable<Extension> w_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(PCINotDone is DomainResource
                    ? (PCINotDone as DomainResource).Extension
                    : default), v_);
            DataType x_(Extension @this)
            {
                DataType ag_ = @this?.Value;

                return ag_;
            };
            IEnumerable<DataType> y_ = context.Operators.Select<Extension, DataType>(w_, x_);
            DataType z_ = context.Operators.SingletonFrom<DataType>(y_);
            FhirDateTime aa_ = context.Operators.Convert<FhirDateTime>(z_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? ab_ = (CqlTupleMetadata_DYHTbOXdfZQfUafHTIcSiQAgf, u_, default, aa_);

            return ab_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> i_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?>(i_);

        return j_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for No PCI Performed Within 90 Minutes of ED Arrival")]
    public IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed_Within_90_Minutes_of_ED_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> d_ = this.Documented_Reason_for_No_PCI_Performed_Within_90_Minutes_of_ED_Arrival(context);
            bool? e_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? NoPCI)
            {
                FhirDateTime i_ = NoPCI?.authoredOn;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                Period k_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

                return m_;
            };
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?>(d_, e_);
            Encounter g_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? NoPCI) =>
                EDwSTEMI;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Documented Reason for Not Administering Fibrinolytic Therapy Within 30 Minutes of ED Arrival")]
    public IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Within_30_Minutes_of_ED_Arrival(CqlContext context)
    {
        CqlValueSet a_ = this.Fibrinolytic_Therapy(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotadministered"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
        bool? f_(MedicationAdministration FibrinolyticNoMed)
        {
            List<CodeableConcept> k_ = FibrinolyticNoMed?.StatusReason;
            CqlConcept l_(CodeableConcept @this)
            {
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return v_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Patient_Refusal(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            CqlConcept q_(CodeableConcept @this)
            {
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return w_;
            };
            IEnumerable<CqlConcept> r_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, q_);
            CqlValueSet s_ = this.Drug_Intervention_Not_Indicated_Contraindicated(context);
            bool? t_ = context.Operators.ConceptsInValueSet(r_, s_);
            bool? u_ = context.Operators.Or(o_, t_);

            return u_;
        };
        IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);
        (CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? h_(MedicationAdministration FibrinolyticNoMed)
        {
            Id x_ = FibrinolyticNoMed?.IdElement;
            string y_ = x_?.Value;
            bool? z_(Extension @this)
            {
                string ag_ = @this?.Url;
                FhirString ah_ = context.Operators.Convert<FhirString>(ag_);
                string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                return aj_;
            };
            IEnumerable<Extension> aa_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FibrinolyticNoMed is DomainResource
                    ? (FibrinolyticNoMed as DomainResource).Extension
                    : default), z_);
            DataType ab_(Extension @this)
            {
                DataType ak_ = @this?.Value;

                return ak_;
            };
            IEnumerable<DataType> ac_ = context.Operators.Select<Extension, DataType>(aa_, ab_);
            DataType ad_ = context.Operators.SingletonFrom<DataType>(ac_);
            FhirDateTime ae_ = context.Operators.Convert<FhirDateTime>(ad_);
            (CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? af_ = (CqlTupleMetadata_DYHTbOXdfZQfUafHTIcSiQAgf, y_, default, ae_);

            return af_;
        };
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> i_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?>(i_);

        return j_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy Within 30 Minutes of ED Arrival")]
    public IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Within_30_Minutes_of_ED_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> d_ = this.Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Within_30_Minutes_of_ED_Arrival(context);
            bool? e_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? NoFibrinolytic)
            {
                FhirDateTime i_ = NoFibrinolytic?.authoredOn;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                Period k_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

                return m_;
            };
            IEnumerable<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?>(d_, e_);
            Encounter g_((CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)? NoFibrinolytic) =>
                EDwSTEMI;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, IEnumerable<CqlConcept> MedicationStatusReason, FhirDateTime authoredOn)?, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(context);
        IEnumerable<Encounter> b_ = this.ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed_Within_90_Minutes_of_ED_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Within_30_Minutes_of_ED_Arrival(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlFunctionDefinition("currentemergencyDepartmentArrivalTime")]
    public CqlDateTime currentemergencyDepartmentArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;
        bool? b_(Encounter.LocationComponent EDLocation)
        {
            ResourceReference h_ = EDLocation?.Location;
            Location i_ = CQMCommon_2_2_000.Instance.GetLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;
            CqlConcept k_(CodeableConcept @this)
            {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return o_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

            return n_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.Start(f_);

        return g_;
    }


    [CqlExpressionDefinition("Fibrinolytic Therapy within 30 Minutes of Arrival")]
    public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> g_(MedicationAdministration MR)
            {
                IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? o_(Medication M)
                {
                    object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(s_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Fibrinolytic_Therapy(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);

                    return ab_;
                };
                IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                MedicationAdministration q_(Medication M) =>
                    MR;
                IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Medication, MedicationAdministration>(p_, q_);

                return r_;
            };
            IEnumerable<MedicationAdministration> h_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(f_, g_);
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(e_, h_);
            bool? j_(MedicationAdministration Fibrinolytic)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> ac_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ad_ = ac_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> ae_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(ad_);
                bool? af_ = context.Operators.Equal(ae_, "completed");
                DataType ag_ = Fibrinolytic?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_2_1_000.Instance.toInterval(context, ah_);
                CqlDateTime aj_ = context.Operators.Start(ai_);
                CqlDateTime ak_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity am_ = context.Operators.Quantity(30m, "minutes");
                CqlDateTime an_ = context.Operators.Add(ak_, am_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(ak_, an_, false, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(aj_, ao_, default);
                bool? ar_ = context.Operators.Not((bool?)(ak_ is null));
                bool? as_ = context.Operators.And(ap_, ar_);
                bool? at_ = context.Operators.And(af_, as_);

                return at_;
            };
            IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
            Encounter l_(MedicationAdministration Fibrinolytic) =>
                EDwithSTEMI;
            IEnumerable<Encounter> m_ = context.Operators.Select<MedicationAdministration, Encounter>(k_, l_);

            return m_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("PCI within 90 Minutes of Arrival")]
    public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure PCI)
            {
                DataType j_ = PCI?.Performed;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_2_1_000.Instance.toInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlDateTime n_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
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


    [CqlFunctionDefinition("currentemergencyDepartmentDepartTime")]
    public CqlDateTime currentemergencyDepartmentDepartTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;
        bool? b_(Encounter.LocationComponent EDLocation)
        {
            ResourceReference h_ = EDLocation?.Location;
            Location i_ = CQMCommon_2_2_000.Instance.GetLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;
            CqlConcept k_(CodeableConcept @this)
            {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return o_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

            return n_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
        Period e_ = d_?.Period;
        CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime g_ = context.Operators.End(f_);

        return g_;
    }


    [CqlExpressionDefinition("ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
    public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? b_(Encounter EDwithSTEMI)
        {
            CqlDateTime d_ = this.currentemergencyDepartmentDepartTime(context, EDwithSTEMI);
            CqlDateTime e_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
            CqlQuantity g_ = context.Operators.Quantity(45m, "minutes");
            CqlDateTime h_ = context.Operators.Add(e_, g_);
            CqlInterval<CqlDateTime> i_ = context.Operators.Interval(e_, h_, false, true);
            bool? j_ = context.Operators.In<CqlDateTime>(d_, i_, default);
            bool? l_ = context.Operators.Not((bool?)(e_ is null));
            bool? m_ = context.Operators.And(j_, l_);
            Encounter.HospitalizationComponent n_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept o_ = n_?.DischargeDisposition;
            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
            CqlValueSet q_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? r_ = context.Operators.ConceptInValueSet(p_, q_);
            bool? s_ = context.Operators.And(m_, r_);

            return s_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter> b_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DYHTbOXdfZQfUafHTIcSiQAgf = new(
      [typeof(string), typeof(IEnumerable<CqlConcept>), typeof(FhirDateTime)],
      ["id", "MedicationStatusReason", "authoredOn"]);

    #endregion CqlTupleMetadata Properties

}
