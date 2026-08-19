#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS996FHIRAptTxforSTEMI", "2.0.000")]
public partial class CMS996FHIRAptTxforSTEMI_2_0_000 : ILibrary, ISingleton<CMS996FHIRAptTxforSTEMI_2_0_000>
{
    #region ValueSets (34)

    [CqlValueSetDefinition("Active Bleeding or Bleeding Diathesis, Excluding Menses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", valueSetVersion: null)]
    public CqlValueSet? Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses(CqlContext _) => _Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses;
    private static readonly CqlValueSet? _Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", null);

    [CqlValueSetDefinition("Active Peptic Ulcer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", valueSetVersion: null)]
    public CqlValueSet? Active_Peptic_Ulcer(CqlContext _) => _Active_Peptic_Ulcer;
    private static readonly CqlValueSet? _Active_Peptic_Ulcer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", null);

    [CqlValueSetDefinition("Thrombolytics Adverse Event", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", valueSetVersion: null)]
    public CqlValueSet? Thrombolytics_Adverse_Event(CqlContext _) => _Thrombolytics_Adverse_Event;
    private static readonly CqlValueSet? _Thrombolytics_Adverse_Event = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", null);

    [CqlValueSetDefinition("Allergy to thrombolytics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", valueSetVersion: null)]
    public CqlValueSet? Allergy_to_thrombolytics(CqlContext _) => _Allergy_to_thrombolytics;
    private static readonly CqlValueSet? _Allergy_to_thrombolytics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", null);

    [CqlValueSetDefinition("Oral Anticoagulant Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", valueSetVersion: null)]
    public CqlValueSet? Oral_Anticoagulant_Medications(CqlContext _) => _Oral_Anticoagulant_Medications;
    private static readonly CqlValueSet? _Oral_Anticoagulant_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", null);

    [CqlValueSetDefinition("Aortic Dissection or Ruptured Aortic Aneurysm", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", valueSetVersion: null)]
    public CqlValueSet? Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(CqlContext _) => _Aortic_Dissection_or_Ruptured_Aortic_Aneurysm;
    private static readonly CqlValueSet? _Aortic_Dissection_or_Ruptured_Aortic_Aneurysm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", null);

    [CqlValueSetDefinition("Cardiopulmonary Emergency", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", valueSetVersion: null)]
    public CqlValueSet? Cardiopulmonary_Emergency(CqlContext _) => _Cardiopulmonary_Emergency;
    private static readonly CqlValueSet? _Cardiopulmonary_Emergency = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", null);

    [CqlValueSetDefinition("Cerebral Vascular Lesion", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", valueSetVersion: null)]
    public CqlValueSet? Cerebral_Vascular_Lesion(CqlContext _) => _Cerebral_Vascular_Lesion;
    private static readonly CqlValueSet? _Cerebral_Vascular_Lesion = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", null);

    [CqlValueSetDefinition("Closed Head and Facial Trauma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", valueSetVersion: null)]
    public CqlValueSet? Closed_Head_and_Facial_Trauma(CqlContext _) => _Closed_Head_and_Facial_Trauma;
    private static readonly CqlValueSet? _Closed_Head_and_Facial_Trauma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", null);

    [CqlValueSetDefinition("Dementia and Related Intracranial Pathologies", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", valueSetVersion: null)]
    public CqlValueSet? Dementia_and_Related_Intracranial_Pathologies(CqlContext _) => _Dementia_and_Related_Intracranial_Pathologies;
    private static readonly CqlValueSet? _Dementia_and_Related_Intracranial_Pathologies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet? Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet? _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Emergency Department Evaluation and Management Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet? Emergency_Department_Evaluation_and_Management_Visit(CqlContext _) => _Emergency_Department_Evaluation_and_Management_Visit;
    private static readonly CqlValueSet? _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet? Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet? _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Endotracheal Intubation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", valueSetVersion: null)]
    public CqlValueSet? Endotracheal_Intubation(CqlContext _) => _Endotracheal_Intubation;
    private static readonly CqlValueSet? _Endotracheal_Intubation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", null);

    [CqlValueSetDefinition("Fibrinolytic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4019", valueSetVersion: null)]
    public CqlValueSet? Fibrinolytic_Therapy(CqlContext _) => _Fibrinolytic_Therapy;
    private static readonly CqlValueSet? _Fibrinolytic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4019", null);

    [CqlValueSetDefinition("Intracranial or Intraspinal surgery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", valueSetVersion: null)]
    public CqlValueSet? Intracranial_or_Intraspinal_surgery(CqlContext _) => _Intracranial_or_Intraspinal_surgery;
    private static readonly CqlValueSet? _Intracranial_or_Intraspinal_surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet? Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet? _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Major Surgical Procedure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", valueSetVersion: null)]
    public CqlValueSet? Major_Surgical_Procedure(CqlContext _) => _Major_Surgical_Procedure;
    private static readonly CqlValueSet? _Major_Surgical_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", null);

    [CqlValueSetDefinition("Malignant Intracranial Neoplasm Group", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", valueSetVersion: null)]
    public CqlValueSet? Malignant_Intracranial_Neoplasm_Group(CqlContext _) => _Malignant_Intracranial_Neoplasm_Group;
    private static readonly CqlValueSet? _Malignant_Intracranial_Neoplasm_Group = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", null);

    [CqlValueSetDefinition("Mechanical Circulatory Assist Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", valueSetVersion: null)]
    public CqlValueSet? Mechanical_Circulatory_Assist_Device(CqlContext _) => _Mechanical_Circulatory_Assist_Device;
    private static readonly CqlValueSet? _Mechanical_Circulatory_Assist_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", null);

    [CqlValueSetDefinition("Neurologic impairment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", valueSetVersion: null)]
    public CqlValueSet? Neurologic_impairment(CqlContext _) => _Neurologic_impairment;
    private static readonly CqlValueSet? _Neurologic_impairment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet? Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet? _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Percutaneous Coronary Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", valueSetVersion: null)]
    public CqlValueSet? Percutaneous_Coronary_Intervention(CqlContext _) => _Percutaneous_Coronary_Intervention;
    private static readonly CqlValueSet? _Percutaneous_Coronary_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", null);

    [CqlValueSetDefinition("Pregnant State", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", valueSetVersion: null)]
    public CqlValueSet? Pregnant_State(CqlContext _) => _Pregnant_State;
    private static readonly CqlValueSet? _Pregnant_State = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", null);

    [CqlValueSetDefinition("STEMI", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", valueSetVersion: null)]
    public CqlValueSet? STEMI(CqlContext _) => _STEMI;
    private static readonly CqlValueSet? _STEMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", null);

    [CqlValueSetDefinition("Thrombolytic medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", valueSetVersion: null)]
    public CqlValueSet? Thrombolytic_medications(CqlContext _) => _Thrombolytic_medications;
    private static readonly CqlValueSet? _Thrombolytic_medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet? Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet? _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
    public CqlValueSet? Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet? _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Hospice Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", valueSetVersion: null)]
    public CqlValueSet? Hospice_Diagnosis(CqlContext _) => _Hospice_Diagnosis;
    private static readonly CqlValueSet? _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", valueSetVersion: null)]
    public CqlValueSet? Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet? _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet? Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet? _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet? Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet? _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Drug Intervention Not Indicated/Contraindicated", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.1", valueSetVersion: null)]
    public CqlValueSet? Drug_Intervention_Not_Indicated_Contraindicated(CqlContext _) => _Drug_Intervention_Not_Indicated_Contraindicated;
    private static readonly CqlValueSet? _Drug_Intervention_Not_Indicated_Contraindicated = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.1", null);

    [CqlValueSetDefinition("Procedure Not Indicated/Contraindicated", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.2", valueSetVersion: null)]
    public CqlValueSet? Procedure_Not_Indicated_Contraindicated(CqlContext _) => _Procedure_Not_Indicated_Contraindicated;
    private static readonly CqlValueSet? _Procedure_Not_Indicated_Contraindicated = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.2", null);

    #endregion ValueSets

    #region Codes (14)

    [CqlCodeDefinition("EMER", codeId: "EMER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode? EMER(CqlContext _) => _EMER;
    private static readonly CqlCode? _EMER = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility", codeId: "Z92.82", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode? Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(CqlContext _) => _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility;
    private static readonly CqlCode? _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility = new CqlCode("Z92.82", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Angina pectoris with documented spasm", codeId: "I20.1", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode? Angina_pectoris_with_documented_spasm(CqlContext _) => _Angina_pectoris_with_documented_spasm;
    private static readonly CqlCode? _Angina_pectoris_with_documented_spasm = new CqlCode("I20.1", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Long term (current) use of anticoagulants", codeId: "Z79.01", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode? Long_term__current__use_of_anticoagulants(CqlContext _) => _Long_term__current__use_of_anticoagulants;
    private static readonly CqlCode? _Long_term__current__use_of_anticoagulants = new CqlCode("Z79.01", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Takotsubo cardiomyopathy (disorder)", codeId: "441541008", codeSystem: "http://snomed.info/sct")]
    public CqlCode? Takotsubo_cardiomyopathy__disorder_(CqlContext _) => _Takotsubo_cardiomyopathy__disorder_;
    private static readonly CqlCode? _Takotsubo_cardiomyopathy__disorder_ = new CqlCode("441541008", "http://snomed.info/sct");

    [CqlCodeDefinition("Takotsubo syndrome", codeId: "I51.81", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode? Takotsubo_syndrome(CqlContext _) => _Takotsubo_syndrome;
    private static readonly CqlCode? _Takotsubo_syndrome = new CqlCode("I51.81", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Ventricular aneurysm due to and following acute myocardial infarction (disorder)", codeId: "723858002", codeSystem: "http://snomed.info/sct")]
    public CqlCode? Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_(CqlContext _) => _Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_;
    private static readonly CqlCode? _Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_ = new CqlCode("723858002", "http://snomed.info/sct");

    [CqlCodeDefinition("Aneurysm of heart", codeId: "I25.3", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode? Aneurysm_of_heart(CqlContext _) => _Aneurysm_of_heart;
    private static readonly CqlCode? _Aneurysm_of_heart = new CqlCode("I25.3", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode? Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode? _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode? Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode? _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode? Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode? _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode? Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode? _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    [CqlCodeDefinition("Emergency room", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode? Emergency_room(CqlContext _) => _Emergency_room;
    private static readonly CqlCode? _Emergency_room = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("Emergency trauma unit", codeId: "ETU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode? Emergency_trauma_unit(CqlContext _) => _Emergency_trauma_unit;
    private static readonly CqlCode? _Emergency_trauma_unit = new CqlCode("ETU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    #endregion Codes

    #region CodeSystems (6)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem? LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem? _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Hospice_care__Minimum_Data_Set_]);

    [CqlCodeSystemDefinition("HSLOC", codeSystemId: "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", codeSystemVersion: null)]
    public CqlCodeSystem? HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem? _HSLOC =
      new CqlCodeSystem("https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", null, []);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem? SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem? _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Takotsubo_cardiomyopathy__disorder_,
          _Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_,
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem? ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem? _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _EMER]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem? ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem? _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility,
          _Angina_pectoris_with_documented_spasm,
          _Long_term__current__use_of_anticoagulants,
          _Takotsubo_syndrome,
          _Aneurysm_of_heart]);

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem? RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem? _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _Emergency_room,
          _Emergency_trauma_unit]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -1830887859865804800L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS996FHIRAptTxforSTEMI-2.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (35)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 9042567821391586271L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("ED Encounter During MP")]
    public IEnumerable<Encounter?>? ED_Encounter_During_MP(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_During_MP, ED_Encounter_During_MP_Compute);

    private const long _cacheIndex_ED_Encounter_During_MP = 5306044393397104968L;

    private IEnumerable<Encounter?>? ED_Encounter_During_MP_Compute(CqlContext context)
    {
        PropertyInfo? a_ = (typeof(Encounter)).GetProperty("Class");
        CqlCode? b_ = this.EMER(context);
        IEnumerable<CqlCode?>? c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(a_, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? e_(Encounter? EDEncounter) {
            List<CodeableConcept?>? g_ = EDEncounter?.Type;

            CqlConcept? h_(CodeableConcept? @this) {
                CqlConcept? af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return af_;
            }

            IEnumerable<CqlConcept?>? i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet? j_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            Period? l_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.End(m_);
            CqlInterval<CqlDateTime?>? o_ = this.Measurement_Period(context);
            bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
            bool? q_ = context.Operators.And(k_, p_);
            Code<Encounter.EncounterStatus>? r_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? s_ = r_?.Value;
            Code<Encounter.EncounterStatus>? t_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(s_);
            bool? u_ = context.Operators.Equal(t_, "finished");
            bool? v_ = context.Operators.And(q_, u_);
            Patient? w_ = this.Patient(context);
            Date? x_ = w_?.BirthDateElement;
            string? y_ = x_?.Value;
            CqlDate? z_ = context.Operators.ConvertStringToDate(y_);
            CqlDateTime? aa_ = context.Operators.Start(m_);
            CqlDate? ab_ = context.Operators.DateFrom(aa_);
            int? ac_ = context.Operators.CalculateAgeAt(z_, ab_, "year");
            bool? ad_ = context.Operators.GreaterOrEqual(ac_, 18);
            bool? ae_ = context.Operators.And(v_, ad_);
            return ae_;
        }

        IEnumerable<Encounter?>? f_ = context.Operators.Where<Encounter>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter?>? ED_Encounter_with_STEMI_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_STEMI_Diagnosis, ED_Encounter_with_STEMI_Diagnosis_Compute);

    private const long _cacheIndex_ED_Encounter_with_STEMI_Diagnosis = 2834645475702299712L;

    private IEnumerable<Encounter?>? ED_Encounter_with_STEMI_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_During_MP(context);

        bool? b_(Encounter? EDEncounterinMP) {
            List<CodeableConcept?>? d_ = EDEncounterinMP?.ReasonCode;

            CqlConcept? e_(CodeableConcept? @this) {
                CqlConcept? p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept?>? f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet? g_ = this.STEMI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition?>? i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? k_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, j_ as IEnumerable<Condition>);
            IEnumerable<Condition?>? l_ = Status_1_15_000.Instance.verified(context, k_);

            bool? m_(Condition? DxSTEMI) {
                IEnumerable<Condition?>? q_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EDEncounterinMP);

                bool? r_(Condition? @this) {
                    CodeableConcept? ac_ = @this?.Code;
                    CqlConcept? ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                    bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                    return ae_;
                }


                CqlConcept? s_(Condition? @this) {
                    CodeableConcept? af_ = @this?.Code;
                    CqlConcept? ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_);
                    return ag_;
                }

                IEnumerable<CqlConcept?>? t_ = context.Operators.WhereSelect<Condition, CqlConcept>(q_, r_, s_);
                CqlValueSet? u_ = this.STEMI(context);
                bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
                CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime? x_ = context.Operators.Start(w_);
                Period? y_ = EDEncounterinMP?.Period;
                CqlInterval<CqlDateTime?>? z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, (string)default);
                bool? ab_ = context.Operators.Or(v_, aa_);
                return ab_;
            }

            bool? n_ = context.Operators.WhereAny<Condition>(l_, m_);
            bool? o_ = context.Operators.Or(h_, n_);
            return o_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter?>? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 2152524893633359082L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 3055380145274978900L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
    public IEnumerable<Encounter?>? Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter, Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter_Compute);

    private const long _cacheIndex_Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter = 502537557117955598L;

    private IEnumerable<Encounter?>? Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            CqlValueSet? d_ = this.Thrombolytic_medications(context);
            IEnumerable<AllergyIntolerance?>? e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));

            bool? f_(AllergyIntolerance? ThrombolyticAllergy) {
                CodeableConcept? h_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept? i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                CqlCode? j_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                CqlConcept? k_ = context.Operators.ConvertCodeToConcept(j_);
                bool? l_ = context.Operators.Equivalent(i_, k_);
                CodeableConcept? m_ = ThrombolyticAllergy?.VerificationStatus;
                CqlConcept? n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                bool? o_ = context.Operators.Not((bool?)(n_ is null));
                CqlCode? p_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                CqlConcept? q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(n_, q_);
                CqlCode? s_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
                CqlConcept? t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(n_, t_);
                bool? v_ = context.Operators.Or(r_, u_);
                bool? w_ = context.Operators.Implies(o_, v_);
                bool? x_ = context.Operators.And(l_, w_);
                DataType? y_ = ThrombolyticAllergy?.Onset;
                object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                CqlInterval<CqlDateTime?>? aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                Period? ab_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                bool? ad_ = context.Operators.Overlaps(aa_, ac_, (string)default);
                CqlDateTime? ae_ = context.Operators.End(ac_);
                bool? af_ = context.Operators.Before(z_ as CqlDateTime, ae_, (string)default);
                bool? ag_ = context.Operators.Or(ad_, af_);
                bool? ah_ = context.Operators.And(x_, ag_);
                return ah_;
            }

            bool? g_ = context.Operators.WhereAny<AllergyIntolerance>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
    public IEnumerable<Encounter?>? Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter, Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter_Compute);

    private const long _cacheIndex_Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter = -2540394215636061597L;

    private IEnumerable<Encounter?>? Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            CqlValueSet? d_ = this.Thrombolytics_Adverse_Event(context);
            IEnumerable<AdverseEvent?>? e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));

            bool? f_(AdverseEvent? ThrombolyticAdverseEvent) {
                FhirDateTime? h_ = ThrombolyticAdverseEvent?.DateElement;
                CqlDateTime? i_ = context.Operators.Convert<CqlDateTime>(h_);
                FhirDateTime? j_ = ThrombolyticAdverseEvent?.DetectedElement;
                CqlDateTime? k_ = context.Operators.Convert<CqlDateTime>(j_);
                FhirDateTime? l_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime? m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period? n_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime? p_ = context.Operators.End(o_);
                bool? q_ = context.Operators.Before((i_ ?? k_) ?? m_, p_, (string)default);
                Code<AdverseEvent.AdverseEventActuality>? r_ = ThrombolyticAdverseEvent?.ActualityElement;
                AdverseEvent.AdverseEventActuality? s_ = r_?.Value;
                Code<AdverseEvent.AdverseEventActuality>? t_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(s_);
                bool? u_ = context.Operators.Equal(t_, "actual");
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            bool? g_ = context.Operators.WhereAny<AdverseEvent>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis at Start of ED Encounter")]
    public IEnumerable<Encounter?>? Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter, Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter = -6244540683477294420L;

    private IEnumerable<Encounter?>? Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlValueSet? d_ = this.Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses(context);
            IEnumerable<Condition?>? e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet? f_ = this.Malignant_Intracranial_Neoplasm_Group(context);
            IEnumerable<Condition?>? g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet? i_ = this.Cerebral_Vascular_Lesion(context);
            IEnumerable<Condition?>? j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet? k_ = this.Dementia_and_Related_Intracranial_Pathologies(context);
            IEnumerable<Condition?>? l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? m_ = context.Operators.Union<Condition>(j_, l_);
            IEnumerable<Condition?>? n_ = context.Operators.Union<Condition>(h_, m_);
            CqlValueSet? o_ = this.Pregnant_State(context);
            IEnumerable<Condition?>? p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet? q_ = this.Allergy_to_thrombolytics(context);
            IEnumerable<Condition?>? r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? s_ = context.Operators.Union<Condition>(p_, r_);
            IEnumerable<Condition?>? t_ = context.Operators.Union<Condition>(n_, s_);
            Condition? u_(Condition? X) => X as Condition;
            IEnumerable<Condition?>? v_ = context.Operators.Select<Condition, Condition>(t_, u_);
            IEnumerable<Condition?>? w_ = Status_1_15_000.Instance.verified(context, v_);

            bool? x_(Condition? ActiveExclusionDx) {
                CqlInterval<CqlDateTime?>? z_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period? aa_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                bool? ac_ = context.Operators.OverlapsBefore(z_, ab_, (string)default);
                return ac_;
            }

            bool? y_ = context.Operators.WhereAny<Condition>(w_, x_);
            return y_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
    public IEnumerable<Encounter?>? Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter, Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter = 2002931957464647766L;

    private IEnumerable<Encounter?>? Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            IEnumerable<MedicationRequest?>? d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest? MR) {
                IEnumerable<Medication?>? l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication? M) {
                    object? o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object? p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string?>? q_ = context.Operators.Split((string)p_, "/");
                    string? r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    CodeableConcept? t_ = M?.Code;
                    CqlConcept? u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet? v_ = this.Oral_Anticoagulant_Medications(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                    bool? x_ = context.Operators.And(s_, w_);
                    return x_;
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest?>? f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet? g_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest?>? h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest?>? i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest? OralAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus>? y_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string? aa_ = context.Operators.Convert<string>(z_);
                string?[]? ab_ = [
                    "active",
                    "completed",
                ];
                bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                Code<MedicationRequest.MedicationRequestIntent>? ad_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                string? af_ = context.Operators.Convert<string>(ae_);
                bool? ag_ = context.Operators.Equal(af_, "order");
                bool? ah_ = context.Operators.And(ac_, ag_);
                FhirDateTime? ai_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime? aj_ = context.Operators.Convert<CqlDateTime>(ai_);
                Period? ak_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime? am_ = context.Operators.Start(al_);
                CqlQuantity? an_ = context.Operators.Quantity(90m, "days");
                CqlDateTime? ao_ = context.Operators.Subtract(am_, an_);
                CqlInterval<CqlDateTime?>? ap_ = context.Operators.Interval(ao_, am_, true, true);
                bool? aq_ = context.Operators.In<CqlDateTime>(aj_, ap_, (string)default);
                bool? ar_ = context.Operators.Not((bool?)(am_ is null));
                bool? as_ = context.Operators.And(aq_, ar_);
                bool? at_ = context.Operators.And(ah_, as_);
                return at_;
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Long Term use of Anticoagulants")]
    public IEnumerable<Encounter?>? Active_Long_Term_use_of_Anticoagulants(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Long_Term_use_of_Anticoagulants, Active_Long_Term_use_of_Anticoagulants_Compute);

    private const long _cacheIndex_Active_Long_Term_use_of_Anticoagulants = -6249883915813703985L;

    private IEnumerable<Encounter?>? Active_Long_Term_use_of_Anticoagulants_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlCode? d_ = this.Long_term__current__use_of_anticoagulants(context);
            IEnumerable<CqlCode?>? e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition?>? f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
            IEnumerable<Condition?>? i_ = Status_1_15_000.Instance.verified(context, h_);

            bool? j_(Condition? LongTermAnticoagulant) {
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LongTermAnticoagulant);
                CqlDateTime? m_ = context.Operators.Start(l_);
                Period? n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime? p_ = context.Operators.Start(o_);
                bool? q_ = context.Operators.SameOrBefore(m_, p_, (string)default);
                CqlDateTime? r_ = context.Operators.End(l_);
                bool? s_ = context.Operators.SameOrAfter(r_, p_, (string)default);
                bool? t_ = context.Operators.And(q_, s_);
                return t_;
            }

            bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active use of Anticoagulants")]
    public IEnumerable<Encounter?>? Active_use_of_Anticoagulants(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_use_of_Anticoagulants, Active_use_of_Anticoagulants_Compute);

    private const long _cacheIndex_Active_use_of_Anticoagulants = 6407732073469548509L;

    private IEnumerable<Encounter?>? Active_use_of_Anticoagulants_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter?>? b_ = this.Active_Long_Term_use_of_Anticoagulants(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter?>? Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start, Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute);

    private const long _cacheIndex_Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start = 5358861958155102662L;

    private IEnumerable<Encounter?>? Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlValueSet? d_ = this.Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(context);
            IEnumerable<Condition?>? e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet? f_ = this.Neurologic_impairment(context);
            IEnumerable<Condition?>? g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? h_ = context.Operators.Union<Condition>(e_, g_);
            CqlCode? i_ = this.Angina_pectoris_with_documented_spasm(context);
            IEnumerable<CqlCode?>? j_ = context.Operators.ToList<CqlCode>(i_);
            IEnumerable<Condition?>? k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlCode? l_ = this.Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_(context);
            IEnumerable<CqlCode?>? m_ = context.Operators.ToList<CqlCode>(l_);
            IEnumerable<Condition?>? n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? o_ = context.Operators.Union<Condition>(k_, n_);
            IEnumerable<Condition?>? p_ = context.Operators.Union<Condition>(h_, o_);
            CqlCode? q_ = this.Aneurysm_of_heart(context);
            IEnumerable<CqlCode?>? r_ = context.Operators.ToList<CqlCode>(q_);
            IEnumerable<Condition?>? s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlCode? t_ = this.Takotsubo_cardiomyopathy__disorder_(context);
            IEnumerable<CqlCode?>? u_ = context.Operators.ToList<CqlCode>(t_);
            IEnumerable<Condition?>? v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? w_ = context.Operators.Union<Condition>(s_, v_);
            IEnumerable<Condition?>? x_ = context.Operators.Union<Condition>(p_, w_);
            CqlCode? y_ = this.Takotsubo_syndrome(context);
            IEnumerable<CqlCode?>? z_ = context.Operators.ToList<CqlCode>(y_);
            IEnumerable<Condition?>? aa_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet? ab_ = this.Cardiopulmonary_Emergency(context);
            IEnumerable<Condition?>? ac_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? ad_ = context.Operators.Union<Condition>(aa_, ac_);
            IEnumerable<Condition?>? ae_ = context.Operators.Union<Condition>(x_, ad_);
            Condition? af_(Condition? X) => X as Condition;
            IEnumerable<Condition?>? ag_ = context.Operators.Select<Condition, Condition>(ae_, af_);
            IEnumerable<Condition?>? ah_ = Status_1_15_000.Instance.verified(context, ag_);

            bool? ai_(Condition? ExclusionDiagnosis) {
                CqlInterval<CqlDateTime?>? ak_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime? al_ = context.Operators.Start(ak_);
                Period? am_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                bool? ao_ = context.Operators.In<CqlDateTime>(al_, an_, (string)default);
                CqlDateTime? ap_ = context.Operators.Start(an_);
                CqlQuantity? aq_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime? ar_ = context.Operators.Subtract(ap_, aq_);
                CqlInterval<CqlDateTime?>? as_ = context.Operators.Interval(ar_, ap_, true, false);
                bool? at_ = context.Operators.In<CqlDateTime>(al_, as_, (string)default);
                bool? au_ = context.Operators.Not((bool?)(ap_ is null));
                bool? av_ = context.Operators.And(at_, au_);
                bool? aw_ = context.Operators.Or(ao_, av_);
                return aw_;
            }

            bool? aj_ = context.Operators.WhereAny<Condition>(ah_, ai_);
            return aj_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
    public IEnumerable<Encounter?>? Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter, Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter_Compute);

    private const long _cacheIndex_Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter = -3071350002189155271L;

    private IEnumerable<Encounter?>? Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlValueSet? d_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure? MajorSurgery) {
                object? h_;
                DataType? ad_ = MajorSurgery?.Performed;
                object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    DataType? ag_ = MajorSurgery?.Performed;
                    object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    h_ = ah_ as CqlDateTime;
                }
                else
                {
                    DataType? ai_ = MajorSurgery?.Performed;
                    object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlQuantity;
                    if (ak_)
                    {
                        DataType? al_ = MajorSurgery?.Performed;
                        object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        h_ = am_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? an_ = MajorSurgery?.Performed;
                        object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        if (ap_)
                        {
                            DataType? aq_ = MajorSurgery?.Performed;
                            object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            h_ = ar_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? as_ = MajorSurgery?.Performed;
                            object? at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            bool au_ = at_ is CqlInterval<CqlQuantity>;
                            if (au_)
                            {
                                DataType? av_ = MajorSurgery?.Performed;
                                object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                h_ = aw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                Period? k_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime? m_ = context.Operators.Start(l_);
                CqlQuantity? n_ = context.Operators.Quantity(21m, "days");
                CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, false);
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(q_, r_);
                object? t_;
                DataType? ax_ = MajorSurgery?.Performed;
                object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    DataType? ba_ = MajorSurgery?.Performed;
                    object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    t_ = bb_ as CqlDateTime;
                }
                else
                {
                    DataType? bc_ = MajorSurgery?.Performed;
                    object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    if (be_)
                    {
                        DataType? bf_ = MajorSurgery?.Performed;
                        object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        t_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? bh_ = MajorSurgery?.Performed;
                        object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            DataType? bk_ = MajorSurgery?.Performed;
                            object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            t_ = bl_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? bm_ = MajorSurgery?.Performed;
                            object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                            if (bo_)
                            {
                                DataType? bp_ = MajorSurgery?.Performed;
                                object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                t_ = bq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime? v_ = context.Operators.Start(u_);
                bool? w_ = context.Operators.In<CqlDateTime>(v_, l_, (string)default);
                bool? x_ = context.Operators.Or(s_, w_);
                Code<EventStatus>? y_ = MajorSurgery?.StatusElement;
                EventStatus? z_ = y_?.Value;
                string? aa_ = context.Operators.Convert<string>(z_);
                bool? ab_ = context.Operators.Equal(aa_, "completed");
                bool? ac_ = context.Operators.And(x_, ab_);
                return ac_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intubation or Mechanical Circulatory Assist Device Placement or Removal Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter?>? Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start, Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute);

    private const long _cacheIndex_Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start = -780558220455665998L;

    private IEnumerable<Encounter?>? Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlValueSet? d_ = this.Endotracheal_Intubation(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet? f_ = this.Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure?>? g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure?>? h_ = context.Operators.Union<Procedure>(e_, g_);

            bool? i_(Procedure? AirwayProcedure) {
                object? k_;
                DataType? ag_ = AirwayProcedure?.Performed;
                object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool ai_ = ah_ is CqlDateTime;
                if (ai_)
                {
                    DataType? aj_ = AirwayProcedure?.Performed;
                    object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    k_ = ak_ as CqlDateTime;
                }
                else
                {
                    DataType? al_ = AirwayProcedure?.Performed;
                    object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlQuantity;
                    if (an_)
                    {
                        DataType? ao_ = AirwayProcedure?.Performed;
                        object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        k_ = ap_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? aq_ = AirwayProcedure?.Performed;
                        object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlInterval<CqlDateTime>;
                        if (as_)
                        {
                            DataType? at_ = AirwayProcedure?.Performed;
                            object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            k_ = au_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? av_ = AirwayProcedure?.Performed;
                            object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            bool ax_ = aw_ is CqlInterval<CqlQuantity>;
                            if (ax_)
                            {
                                DataType? ay_ = AirwayProcedure?.Performed;
                                object? az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                                k_ = az_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                CqlDateTime? m_ = context.Operators.Start(l_);
                Period? n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, (string)default);
                object? q_;
                DataType? ba_ = AirwayProcedure?.Performed;
                object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                bool bc_ = bb_ is CqlDateTime;
                if (bc_)
                {
                    DataType? bd_ = AirwayProcedure?.Performed;
                    object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    q_ = be_ as CqlDateTime;
                }
                else
                {
                    DataType? bf_ = AirwayProcedure?.Performed;
                    object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlQuantity;
                    if (bh_)
                    {
                        DataType? bi_ = AirwayProcedure?.Performed;
                        object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        q_ = bj_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? bk_ = AirwayProcedure?.Performed;
                        object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                        if (bm_)
                        {
                            DataType? bn_ = AirwayProcedure?.Performed;
                            object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            q_ = bo_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? bp_ = AirwayProcedure?.Performed;
                            object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                            bool br_ = bq_ is CqlInterval<CqlQuantity>;
                            if (br_)
                            {
                                DataType? bs_ = AirwayProcedure?.Performed;
                                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                                q_ = bt_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime? s_ = context.Operators.Start(r_);
                CqlDateTime? t_ = context.Operators.Start(o_);
                CqlQuantity? u_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime? v_ = context.Operators.Subtract(t_, u_);
                CqlInterval<CqlDateTime?>? w_ = context.Operators.Interval(v_, t_, true, false);
                bool? x_ = context.Operators.In<CqlDateTime>(s_, w_, (string)default);
                bool? y_ = context.Operators.Not((bool?)(t_ is null));
                bool? z_ = context.Operators.And(x_, y_);
                bool? aa_ = context.Operators.Or(p_, z_);
                Code<EventStatus>? ab_ = AirwayProcedure?.StatusElement;
                EventStatus? ac_ = ab_?.Value;
                string? ad_ = context.Operators.Convert<string>(ac_);
                bool? ae_ = context.Operators.Equal(ad_, "completed");
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            bool? j_ = context.Operators.WhereAny<Procedure>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
    public IEnumerable<Encounter?>? Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter, Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter = 1408893699383217546L;

    private IEnumerable<Encounter?>? Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            CqlValueSet? d_ = this.Ischemic_Stroke(context);
            IEnumerable<Condition?>? e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet? f_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition?>? g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet? i_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition?>? j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? k_ = context.Operators.Union<Condition>(h_, j_);
            Condition? l_(Condition? X) => X as Condition;
            IEnumerable<Condition?>? m_ = context.Operators.Select<Condition, Condition>(k_, l_);
            IEnumerable<Condition?>? n_ = Status_1_15_000.Instance.verified(context, m_);

            bool? o_(Condition? ExclusionCondition) {
                CqlInterval<CqlDateTime?>? q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime? r_ = context.Operators.Start(q_);
                Period? s_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime? u_ = context.Operators.Start(t_);
                CqlQuantity? v_ = context.Operators.Quantity(90m, "days");
                CqlDateTime? w_ = context.Operators.Subtract(u_, v_);
                CqlInterval<CqlDateTime?>? x_ = context.Operators.Interval(w_, u_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(r_, x_, (string)default);
                return y_;
            }

            bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
            return p_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter?>? Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter, Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter = -6569882930745692123L;

    private IEnumerable<Encounter?>? Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlValueSet? d_ = this.Intracranial_or_Intraspinal_surgery(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure? CranialorSpinalSurgery) {
                object? h_;
                DataType? y_ = CranialorSpinalSurgery?.Performed;
                object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType? ab_ = CranialorSpinalSurgery?.Performed;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    h_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType? ad_ = CranialorSpinalSurgery?.Performed;
                    object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlQuantity;
                    if (af_)
                    {
                        DataType? ag_ = CranialorSpinalSurgery?.Performed;
                        object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        h_ = ah_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ai_ = CranialorSpinalSurgery?.Performed;
                        object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            DataType? al_ = CranialorSpinalSurgery?.Performed;
                            object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            h_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? an_ = CranialorSpinalSurgery?.Performed;
                            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                            if (ap_)
                            {
                                DataType? aq_ = CranialorSpinalSurgery?.Performed;
                                object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                h_ = ar_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                Period? k_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime? m_ = context.Operators.Start(l_);
                CqlQuantity? n_ = context.Operators.Quantity(90m, "days");
                CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, false);
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(q_, r_);
                Code<EventStatus>? t_ = CranialorSpinalSurgery?.StatusElement;
                EventStatus? u_ = t_?.Value;
                string? v_ = context.Operators.Convert<string>(u_);
                bool? w_ = context.Operators.Equal(v_, "completed");
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Patient Expired")]
    public IEnumerable<Encounter?>? ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Patient_Expired, ED_Encounter_with_Discharge_Disposition_as_Patient_Expired_Compute);

    private const long _cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Patient_Expired = -5706805016315765911L;

    private IEnumerable<Encounter?>? ED_Encounter_with_Discharge_Disposition_as_Patient_Expired_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            Encounter.HospitalizationComponent? d_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept? e_ = d_?.DischargeDisposition;
            CqlConcept? f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet? g_ = this.Patient_Expired(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Left Against Medical Advice")]
    public IEnumerable<Encounter?>? ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice, ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice_Compute);

    private const long _cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice = -731904171393251097L;

    private IEnumerable<Encounter?>? ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            Encounter.HospitalizationComponent? d_ = EDwSTEMI?.Hospitalization;
            CodeableConcept? e_ = d_?.DischargeDisposition;
            CqlConcept? f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet? g_ = this.Left_Against_Medical_Advice(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Hospice Services")]
    public IEnumerable<Encounter?>? ED_Encounter_with_Hospice_Services(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_Hospice_Services, ED_Encounter_with_Hospice_Services_Compute);

    private const long _cacheIndex_ED_Encounter_with_Hospice_Services = -4226681865471752242L;

    private IEnumerable<Encounter?>? ED_Encounter_with_Hospice_Services_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            CqlValueSet? d_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter?>? e_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter?>? f_ = Status_1_15_000.Instance.isEncounterPerformed(context, e_);

            bool? g_(Encounter? InpatientEncounter) {
                Encounter.HospitalizationComponent? ao_ = InpatientEncounter?.Hospitalization;
                CodeableConcept? ap_ = ao_?.DischargeDisposition;
                CqlConcept? aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                CqlCode? ar_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept? as_ = context.Operators.ConvertCodeToConcept(ar_);
                bool? at_ = context.Operators.Equivalent(aq_, as_);
                CqlCode? au_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept? av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(aq_, av_);
                bool? ax_ = context.Operators.Or(at_, aw_);
                Period? ay_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
                CqlDateTime? ba_ = context.Operators.Start(az_);
                Period? bb_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                CqlDateTime? bd_ = context.Operators.Start(bc_);
                bool? be_ = context.Operators.SameOrBefore(ba_, bd_, (string)default);
                bool? bf_ = context.Operators.And(ax_, be_);
                CqlQuantity? bg_ = context.Operators.Quantity(6m, "months");
                CqlDateTime? bh_ = context.Operators.Subtract(bd_, bg_);
                CqlDateTime? bi_ = context.Operators.End(bc_);
                CqlInterval<CqlDateTime?>? bj_ = context.Operators.Interval(bh_, bi_, true, true);
                bool? bk_ = context.Operators.Overlaps(az_, bj_, "day");
                bool? bl_ = context.Operators.And(bf_, bk_);
                return bl_;
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            CqlValueSet? i_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter?>? j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter?>? k_ = Status_1_15_000.Instance.isEncounterPerformed(context, j_);

            bool? l_(Encounter? HospiceEncounter) {
                Period? bm_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime?>? bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                CqlDateTime? bo_ = context.Operators.Start(bn_);
                Period? bp_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? bq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bp_);
                CqlDateTime? br_ = context.Operators.Start(bq_);
                bool? bs_ = context.Operators.SameOrBefore(bo_, br_, (string)default);
                CqlQuantity? bt_ = context.Operators.Quantity(6m, "months");
                CqlDateTime? bu_ = context.Operators.Subtract(br_, bt_);
                CqlDateTime? bv_ = context.Operators.End(bq_);
                CqlInterval<CqlDateTime?>? bw_ = context.Operators.Interval(bu_, bv_, true, true);
                bool? bx_ = context.Operators.Overlaps(bn_, bw_, "day");
                bool? by_ = context.Operators.And(bs_, bx_);
                return by_;
            }

            bool? m_ = context.Operators.WhereAny<Encounter>(k_, l_);
            bool? n_ = context.Operators.Or(h_, m_);
            CqlCode? o_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode?>? p_ = context.Operators.ToList<CqlCode>(o_);
            IEnumerable<Observation?>? q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation?>? r_ = Status_1_15_000.Instance.isAssessmentPerformed(context, q_);

            bool? s_(Observation? HospiceAssessment) {
                DataType? bz_ = (HospiceAssessment as Observation)?.Value;
                object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                CqlCode? cb_ = this.Yes__qualifier_value_(context);
                CqlConcept? cc_ = context.Operators.ConvertCodeToConcept(cb_);
                bool? cd_ = context.Operators.Equivalent(ca_ as CqlConcept, cc_);
                DataType? ce_ = HospiceAssessment?.Effective;
                object? cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                CqlInterval<CqlDateTime?>? cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_);
                CqlDateTime? ch_ = context.Operators.Start(cg_);
                Period? ci_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? cj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ci_);
                CqlDateTime? ck_ = context.Operators.Start(cj_);
                bool? cl_ = context.Operators.SameOrBefore(ch_, ck_, (string)default);
                bool? cm_ = context.Operators.And(cd_, cl_);
                CqlQuantity? cn_ = context.Operators.Quantity(6m, "months");
                CqlDateTime? co_ = context.Operators.Subtract(ck_, cn_);
                CqlDateTime? cp_ = context.Operators.End(cj_);
                CqlInterval<CqlDateTime?>? cq_ = context.Operators.Interval(co_, cp_, true, true);
                bool? cr_ = context.Operators.Overlaps(cg_, cq_, "day");
                bool? cs_ = context.Operators.And(cm_, cr_);
                return cs_;
            }

            bool? t_ = context.Operators.WhereAny<Observation>(r_, s_);
            bool? u_ = context.Operators.Or(n_, t_);
            CqlValueSet? v_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest?>? w_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest?>? x_ = Status_1_15_000.Instance.isInterventionOrder(context, w_);

            bool? y_(ServiceRequest? HospiceOrder) {
                FhirDateTime? ct_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime? cu_ = context.Operators.Convert<CqlDateTime>(ct_);
                Period? cv_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime? cx_ = context.Operators.Start(cw_);
                CqlQuantity? cy_ = context.Operators.Quantity(6m, "months");
                CqlDateTime? cz_ = context.Operators.Subtract(cx_, cy_);
                CqlInterval<CqlDateTime?>? da_ = context.Operators.Interval(cz_, cx_, true, false);
                bool? db_ = context.Operators.In<CqlDateTime>(cu_, da_, (string)default);
                bool? dc_ = context.Operators.Not((bool?)(cx_ is null));
                bool? dd_ = context.Operators.And(db_, dc_);
                return dd_;
            }

            bool? z_ = context.Operators.WhereAny<ServiceRequest>(x_, y_);
            bool? aa_ = context.Operators.Or(u_, z_);
            IEnumerable<Procedure?>? ab_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure?>? ac_ = Status_1_15_000.Instance.isInterventionPerformed(context, ab_);

            bool? ad_(Procedure? HospicePerformed) {
                object? de_;
                DataType? dt_ = HospicePerformed?.Performed;
                object? du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                bool dv_ = du_ is CqlDateTime;
                if (dv_)
                {
                    DataType? dw_ = HospicePerformed?.Performed;
                    object? dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    de_ = dx_ as CqlDateTime;
                }
                else
                {
                    DataType? dy_ = HospicePerformed?.Performed;
                    object? dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                    bool ea_ = dz_ is CqlQuantity;
                    if (ea_)
                    {
                        DataType? eb_ = HospicePerformed?.Performed;
                        object? ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                        de_ = ec_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ed_ = HospicePerformed?.Performed;
                        object? ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        bool ef_ = ee_ is CqlInterval<CqlDateTime>;
                        if (ef_)
                        {
                            DataType? eg_ = HospicePerformed?.Performed;
                            object? eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                            de_ = eh_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? ei_ = HospicePerformed?.Performed;
                            object? ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                            bool ek_ = ej_ is CqlInterval<CqlQuantity>;
                            if (ek_)
                            {
                                DataType? el_ = HospicePerformed?.Performed;
                                object? em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                                de_ = em_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                de_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
                CqlDateTime? dg_ = context.Operators.Start(df_);
                Period? dh_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? di_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dh_);
                CqlDateTime? dj_ = context.Operators.Start(di_);
                bool? dk_ = context.Operators.SameOrBefore(dg_, dj_, (string)default);
                object? dl_;
                DataType? en_ = HospicePerformed?.Performed;
                object? eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                bool ep_ = eo_ is CqlDateTime;
                if (ep_)
                {
                    DataType? eq_ = HospicePerformed?.Performed;
                    object? er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    dl_ = er_ as CqlDateTime;
                }
                else
                {
                    DataType? es_ = HospicePerformed?.Performed;
                    object? et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                    bool eu_ = et_ is CqlQuantity;
                    if (eu_)
                    {
                        DataType? ev_ = HospicePerformed?.Performed;
                        object? ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        dl_ = ew_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ex_ = HospicePerformed?.Performed;
                        object? ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                        bool ez_ = ey_ is CqlInterval<CqlDateTime>;
                        if (ez_)
                        {
                            DataType? fa_ = HospicePerformed?.Performed;
                            object? fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                            dl_ = fb_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? fc_ = HospicePerformed?.Performed;
                            object? fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                            bool fe_ = fd_ is CqlInterval<CqlQuantity>;
                            if (fe_)
                            {
                                DataType? ff_ = HospicePerformed?.Performed;
                                object? fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                                dl_ = fg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dl_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? dm_ = QICoreCommon_4_0_000.Instance.toInterval(context, dl_);
                CqlQuantity? dn_ = context.Operators.Quantity(6m, "months");
                CqlDateTime? do_ = context.Operators.Subtract(dj_, dn_);
                CqlDateTime? dp_ = context.Operators.End(di_);
                CqlInterval<CqlDateTime?>? dq_ = context.Operators.Interval(do_, dp_, true, true);
                bool? dr_ = context.Operators.Overlaps(dm_, dq_, "day");
                bool? ds_ = context.Operators.And(dk_, dr_);
                return ds_;
            }

            bool? ae_ = context.Operators.WhereAny<Procedure>(ac_, ad_);
            bool? af_ = context.Operators.Or(aa_, ae_);
            CqlValueSet? ag_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition?>? ah_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            Condition? ai_(Condition? X) => X as Condition;
            IEnumerable<Condition?>? aj_ = context.Operators.Select<Condition, Condition>(ah_, ai_);
            IEnumerable<Condition?>? ak_ = Status_1_15_000.Instance.verified(context, aj_);

            bool? al_(Condition? HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime?>? fh_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlDateTime? fi_ = context.Operators.End(fh_);
                Period? fj_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? fk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fj_);
                CqlDateTime? fl_ = context.Operators.Start(fk_);
                bool? fm_ = context.Operators.SameOrAfter(fi_, fl_, (string)default);
                return fm_;
            }

            bool? am_ = context.Operators.WhereAny<Condition>(ak_, al_);
            bool? an_ = context.Operators.Or(af_, am_);
            return an_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Currently Pregnant")]
    public IEnumerable<Encounter?>? Currently_Pregnant(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Currently_Pregnant, Currently_Pregnant_Compute);

    private const long _cacheIndex_Currently_Pregnant = 4224761559664591920L;

    private IEnumerable<Encounter?>? Currently_Pregnant_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            IEnumerable<Observation?>? d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

            bool? e_(Observation? PregStatus) {
                Code<ObservationStatus>? g_ = PregStatus?.StatusElement;
                ObservationStatus? h_ = g_?.Value;
                Code<ObservationStatus>? i_ = context.Operators.Convert<Code<ObservationStatus>>(h_);
                bool? j_ = context.Operators.Equal(i_, "final");
                DataType? k_ = PregStatus?.Value;
                CqlConcept? l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_ as CodeableConcept);
                CqlValueSet? m_ = this.Pregnant_State(context);
                bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
                bool? o_ = context.Operators.And(j_, n_);
                DataType? p_ = PregStatus?.Effective;
                CqlDateTime? q_ = context.Operators.LateBoundProperty<CqlDateTime>(p_, "value");
                Period? r_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, (string)default);
                bool? u_ = context.Operators.And(o_, t_);
                return u_;
            }

            bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter?>? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -1489138186020577646L;

    private IEnumerable<Encounter?>? Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
        IEnumerable<Encounter?>? b_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter?>? d_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
        IEnumerable<Encounter?>? e_ = this.Active_use_of_Anticoagulants(context);
        IEnumerable<Encounter?>? f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter?>? g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter?>? h_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter?>? i_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(context);
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter>(h_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter>(g_, j_);
        IEnumerable<Encounter?>? l_ = this.Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter?>? m_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter?>? n_ = context.Operators.Union<Encounter>(l_, m_);
        IEnumerable<Encounter?>? o_ = context.Operators.Union<Encounter>(k_, n_);
        IEnumerable<Encounter?>? p_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(context);
        IEnumerable<Encounter?>? q_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(context);
        IEnumerable<Encounter?>? r_ = context.Operators.Union<Encounter>(p_, q_);
        IEnumerable<Encounter?>? s_ = context.Operators.Union<Encounter>(o_, r_);
        IEnumerable<Encounter?>? t_ = this.ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice(context);
        IEnumerable<Encounter?>? u_ = this.ED_Encounter_with_Hospice_Services(context);
        IEnumerable<Encounter?>? v_ = context.Operators.Union<Encounter>(t_, u_);
        IEnumerable<Encounter?>? w_ = context.Operators.Union<Encounter>(s_, v_);
        IEnumerable<Encounter?>? x_ = this.Currently_Pregnant(context);
        IEnumerable<Encounter?>? y_ = context.Operators.Union<Encounter>(w_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Received tPA in Another Facility within 24 hours Prior to Admission")]
    public IEnumerable<Encounter?>? Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission, Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission_Compute);

    private const long _cacheIndex_Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission = 5761351899677059903L;

    private IEnumerable<Encounter?>? Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlCode? d_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode?>? e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition?>? f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
            IEnumerable<Condition?>? i_ = Status_1_15_000.Instance.verified(context, h_);

            bool? j_(Condition? TPA) {
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime? m_ = context.Operators.Start(l_);
                Period? n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, (string)default);
                return p_;
            }

            bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for No PCI Performed")]
    public IEnumerable<Encounter?>? ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed, ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed_Compute);

    private const long _cacheIndex_ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed = 4861476912755213235L;

    private IEnumerable<Encounter?>? ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            CqlValueSet? d_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            IEnumerable<Procedure?>? f_ = context.Operators.Union<Procedure>(e_, e_);

            bool? g_(Procedure? PCINotDone) {
                CodeableConcept? i_ = PCINotDone?.StatusReason;
                CqlConcept? j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, i_);
                CqlValueSet? k_ = this.Patient_Refusal(context);
                bool? l_ = context.Operators.ConceptInValueSet(j_, k_);
                CqlValueSet? m_ = this.Procedure_Not_Indicated_Contraindicated(context);
                bool? n_ = context.Operators.ConceptInValueSet(j_, m_);
                bool? o_ = context.Operators.Or(l_, n_);

                bool? p_(Extension? @this) {
                    FhirUri? z_ = @this?.UrlElement;
                    string? aa_ = FHIRHelpers_4_4_000.Instance.ToString(context, z_);
                    bool? ab_ = context.Operators.Equal(aa_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ab_;
                }


                DataType? q_(Extension? @this) {
                    DataType? ac_ = @this?.Value;
                    return ac_;
                }

                IEnumerable<DataType?>? r_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(PCINotDone is DomainResource
                    ? (PCINotDone as DomainResource).Extension
                    : default), p_, q_);
                DataType? s_ = context.Operators.SingletonFrom<DataType>(r_);
                FhirDateTime? t_ = context.Operators.Convert<FhirDateTime>(s_);
                CqlDateTime? u_ = context.Operators.Convert<CqlDateTime>(t_);
                Period? v_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
                bool? x_ = context.Operators.In<CqlDateTime>(u_, w_, (string)default);
                bool? y_ = context.Operators.And(o_, x_);
                return y_;
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy")]
    public IEnumerable<Encounter?>? ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy, ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Compute);

    private const long _cacheIndex_ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy = 2696627271993019511L;

    private IEnumerable<Encounter?>? ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwSTEMI) {
            CqlValueSet? d_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration?>? e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
            IEnumerable<MedicationAdministration?>? f_ = context.Operators.Union<MedicationAdministration>(e_, e_);

            bool? g_(MedicationAdministration? FibrinolyticNoMed) {
                List<CodeableConcept?>? i_ = FibrinolyticNoMed?.StatusReason;

                CqlConcept? j_(CodeableConcept? @this) {
                    CqlConcept? ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ac_;
                }

                IEnumerable<CqlConcept?>? k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                CqlValueSet? l_ = this.Patient_Refusal(context);
                bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);

                CqlConcept? n_(CodeableConcept? @this) {
                    CqlConcept? ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ad_;
                }

                IEnumerable<CqlConcept?>? o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, n_);
                CqlValueSet? p_ = this.Drug_Intervention_Not_Indicated_Contraindicated(context);
                bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
                bool? r_ = context.Operators.Or(m_, q_);

                bool? s_(Extension? @this) {
                    FhirUri? ae_ = @this?.UrlElement;
                    string? af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                    bool? ag_ = context.Operators.Equal(af_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ag_;
                }


                DataType? t_(Extension? @this) {
                    DataType? ah_ = @this?.Value;
                    return ah_;
                }

                IEnumerable<DataType?>? u_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(FibrinolyticNoMed is DomainResource
                    ? (FibrinolyticNoMed as DomainResource).Extension
                    : default), s_, t_);
                DataType? v_ = context.Operators.SingletonFrom<DataType>(u_);
                FhirDateTime? w_ = context.Operators.Convert<FhirDateTime>(v_);
                CqlDateTime? x_ = context.Operators.Convert<CqlDateTime>(w_);
                Period? y_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime?>? z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                bool? aa_ = context.Operators.In<CqlDateTime>(x_, z_, (string)default);
                bool? ab_ = context.Operators.And(r_, aa_);
                return ab_;
            }

            bool? h_ = context.Operators.WhereAny<MedicationAdministration>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter?>? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -6308283377563653028L;

    private IEnumerable<Encounter?>? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(context);
        IEnumerable<Encounter?>? b_ = this.ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter?>? d_ = this.ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy(context);
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlFunctionDefinition("currentemergencyDepartmentArrivalTime")]
    public CqlDateTime? currentemergencyDepartmentArrivalTime(CqlContext context, Encounter? EDEncounter)
    {
        List<Encounter.LocationComponent?>? a_ = EDEncounter?.Location;

        bool? b_(Encounter.LocationComponent? EDLocation) {
            ResourceReference? h_ = EDLocation?.Location;
            Location? i_ = CQMCommon_4_1_000.Instance.getLocation(context, h_);
            List<CodeableConcept?>? j_ = i_?.Type;

            CqlConcept? k_(CodeableConcept? @this) {
                CqlConcept? o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }


            bool? l_(CqlConcept? LocationType) {
                CqlValueSet? p_ = this.Emergency_Department_Visit(context);
                bool? q_ = context.Operators.ConceptInValueSet(LocationType, p_);
                CqlCode? r_ = this.Emergency_room(context);
                CqlConcept? s_ = context.Operators.ConvertCodeToConcept(r_);
                bool? t_ = context.Operators.Equivalent(LocationType, s_);
                bool? u_ = context.Operators.Or(q_, t_);
                CqlCode? v_ = this.Emergency_trauma_unit(context);
                CqlConcept? w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(LocationType, w_);
                bool? y_ = context.Operators.Or(u_, x_);
                Period? z_ = EDLocation?.Period;
                CqlInterval<CqlDateTime?>? aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlDateTime? ab_ = context.Operators.Start(aa_);
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            IEnumerable<CqlConcept?>? m_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            return n_;
        }


        CqlDateTime? c_(Encounter.LocationComponent? EDLocation) {
            Period? ae_ = EDLocation?.Period;
            CqlInterval<CqlDateTime?>? af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
            CqlDateTime? ag_ = context.Operators.Start(af_);
            return ag_;
        }

        IEnumerable<CqlDateTime?>? d_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>((IEnumerable<Encounter.LocationComponent>)a_, b_, c_);
        IEnumerable<CqlDateTime?>? e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime?>? f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime? g_ = context.Operators.First<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Fibrinolytic Therapy Administration within 30 Minutes of Arrival")]
    public IEnumerable<Encounter?>? Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival, Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival_Compute);

    private const long _cacheIndex_Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival = -7313533688387407620L;

    private IEnumerable<Encounter?>? Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            IEnumerable<MedicationAdministration?>? d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? e_(MedicationAdministration? MR) {
                IEnumerable<Medication?>? l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication? M) {
                    object? o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object? p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string?>? q_ = context.Operators.Split((string)p_, "/");
                    string? r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    CodeableConcept? t_ = M?.Code;
                    CqlConcept? u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                    CqlValueSet? v_ = this.Fibrinolytic_Therapy(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                    bool? x_ = context.Operators.And(s_, w_);
                    return x_;
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration?>? f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet? g_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration?>? h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration?>? i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration? Fibrinolytic) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes>? y_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? z_ = y_?.Value;
                string? aa_ = context.Operators.Convert<string>(z_);
                bool? ab_ = context.Operators.Equal(aa_, "completed");
                DataType? ac_ = Fibrinolytic?.Effective;
                object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlInterval<CqlDateTime?>? ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                CqlDateTime? af_ = context.Operators.Start(ae_);
                CqlDateTime? ag_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity? ah_ = context.Operators.Quantity(30m, "minutes");
                CqlDateTime? ai_ = context.Operators.Add(ag_, ah_);
                CqlInterval<CqlDateTime?>? aj_ = context.Operators.Interval(ag_, ai_, false, true);
                bool? ak_ = context.Operators.In<CqlDateTime>(af_, aj_, (string)default);
                bool? al_ = context.Operators.Not((bool?)(ag_ is null));
                bool? am_ = context.Operators.And(ak_, al_);
                bool? an_ = context.Operators.And(ab_, am_);
                return an_;
            }

            bool? k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("PCI within 90 Minutes of Arrival")]
    public IEnumerable<Encounter?>? PCI_within_90_Minutes_of_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_PCI_within_90_Minutes_of_Arrival, PCI_within_90_Minutes_of_Arrival_Compute);

    private const long _cacheIndex_PCI_within_90_Minutes_of_Arrival = -5463400308575938821L;

    private IEnumerable<Encounter?>? PCI_within_90_Minutes_of_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlValueSet? d_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure? PCI) {
                object? h_;
                DataType? w_ = PCI?.Performed;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType? z_ = PCI?.Performed;
                    object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    h_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType? ab_ = PCI?.Performed;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    if (ad_)
                    {
                        DataType? ae_ = PCI?.Performed;
                        object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        h_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? ag_ = PCI?.Performed;
                        object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            DataType? aj_ = PCI?.Performed;
                            object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            h_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType? al_ = PCI?.Performed;
                            object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlQuantity>;
                            if (an_)
                            {
                                DataType? ao_ = PCI?.Performed;
                                object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                h_ = ap_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                CqlDateTime? k_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity? l_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime? m_ = context.Operators.Add(k_, l_);
                CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(k_, m_, false, true);
                bool? o_ = context.Operators.In<CqlDateTime>(j_, n_, (string)default);
                bool? p_ = context.Operators.Not((bool?)(k_ is null));
                bool? q_ = context.Operators.And(o_, p_);
                Code<EventStatus>? r_ = PCI?.StatusElement;
                EventStatus? s_ = r_?.Value;
                string? t_ = context.Operators.Convert<string>(s_);
                bool? u_ = context.Operators.Equal(t_, "completed");
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("currentemergencyDepartmentDepartTime")]
    public CqlDateTime? currentemergencyDepartmentDepartTime(CqlContext context, Encounter? EDEncounter)
    {
        List<Encounter.LocationComponent?>? a_ = EDEncounter?.Location;

        bool? b_(Encounter.LocationComponent? EDLocation) {
            ResourceReference? h_ = EDLocation?.Location;
            Location? i_ = CQMCommon_4_1_000.Instance.getLocation(context, h_);
            List<CodeableConcept?>? j_ = i_?.Type;

            CqlConcept? k_(CodeableConcept? @this) {
                CqlConcept? o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }


            bool? l_(CqlConcept? LocationType) {
                CqlValueSet? p_ = this.Emergency_Department_Visit(context);
                bool? q_ = context.Operators.ConceptInValueSet(LocationType, p_);
                CqlCode? r_ = this.Emergency_room(context);
                CqlConcept? s_ = context.Operators.ConvertCodeToConcept(r_);
                bool? t_ = context.Operators.Equivalent(LocationType, s_);
                bool? u_ = context.Operators.Or(q_, t_);
                CqlCode? v_ = this.Emergency_trauma_unit(context);
                CqlConcept? w_ = context.Operators.ConvertCodeToConcept(v_);
                bool? x_ = context.Operators.Equivalent(LocationType, w_);
                bool? y_ = context.Operators.Or(u_, x_);
                Period? z_ = EDLocation?.Period;
                CqlInterval<CqlDateTime?>? aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                CqlDateTime? ab_ = context.Operators.End(aa_);
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            IEnumerable<CqlConcept?>? m_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            return n_;
        }


        CqlDateTime? c_(Encounter.LocationComponent? EDLocation) {
            Period? ae_ = EDLocation?.Period;
            CqlInterval<CqlDateTime?>? af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
            CqlDateTime? ag_ = context.Operators.End(af_);
            return ag_;
        }

        IEnumerable<CqlDateTime?>? d_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>((IEnumerable<Encounter.LocationComponent>)a_, b_, c_);
        IEnumerable<CqlDateTime?>? e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime?>? f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime? g_ = context.Operators.Last<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("ED Departure with Discharge to Acute Care Facility Within 45 Minutes Of Arrival")]
    public IEnumerable<Encounter?>? ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival, ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival_Compute);

    private const long _cacheIndex_ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival = 8151977692912060192L;

    private IEnumerable<Encounter?>? ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter? EDwithSTEMI) {
            CqlDateTime? d_ = this.currentemergencyDepartmentDepartTime(context, EDwithSTEMI);
            CqlDateTime? e_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
            CqlQuantity? f_ = context.Operators.Quantity(45m, "minutes");
            CqlDateTime? g_ = context.Operators.Add(e_, f_);
            CqlInterval<CqlDateTime?>? h_ = context.Operators.Interval(e_, g_, false, true);
            bool? i_ = context.Operators.In<CqlDateTime>(d_, h_, (string)default);
            bool? j_ = context.Operators.Not((bool?)(e_ is null));
            bool? k_ = context.Operators.And(i_, j_);
            Encounter.HospitalizationComponent? l_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept? m_ = l_?.DischargeDisposition;
            CqlConcept? n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet? o_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
            bool? q_ = context.Operators.And(k_, p_);
            return q_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1584714117989118305L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter?>? b_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter?>? d_ = this.ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival(context);
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 965101041482449971L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3876543663401552806L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -5966982971653611671L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -8295183991178300754L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS996FHIRAptTxforSTEMI_2_0_000() {}

    public static CMS996FHIRAptTxforSTEMI_2_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS996FHIRAptTxforSTEMI";
    public string Version => "2.0.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
