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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("CMS996FHIRAptTxforSTEMI", "2.0.000")]
public partial class CMS996FHIRAptTxforSTEMI_2_0_000 : ILibrary, ISingleton<CMS996FHIRAptTxforSTEMI_2_0_000>
{
    #region ValueSets (34)

    [CqlValueSetDefinition("Active Bleeding or Bleeding Diathesis, Excluding Menses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", valueSetVersion: null)]
    public CqlValueSet Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses(CqlContext _) => _Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses;
    private static readonly CqlValueSet _Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", null);

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

    [CqlValueSetDefinition("Cardiopulmonary Emergency", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", valueSetVersion: null)]
    public CqlValueSet Cardiopulmonary_Emergency(CqlContext _) => _Cardiopulmonary_Emergency;
    private static readonly CqlValueSet _Cardiopulmonary_Emergency = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", null);

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

    [CqlValueSetDefinition("Mechanical Circulatory Assist Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", valueSetVersion: null)]
    public CqlValueSet Mechanical_Circulatory_Assist_Device(CqlContext _) => _Mechanical_Circulatory_Assist_Device;
    private static readonly CqlValueSet _Mechanical_Circulatory_Assist_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", null);

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

    #region Codes (14)

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

    [CqlCodeDefinition("Emergency room", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode Emergency_room(CqlContext _) => _Emergency_room;
    private static readonly CqlCode _Emergency_room = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("Emergency trauma unit", codeId: "ETU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode Emergency_trauma_unit(CqlContext _) => _Emergency_trauma_unit;
    private static readonly CqlCode _Emergency_trauma_unit = new CqlCode("ETU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    #endregion Codes

    #region CodeSystems (6)

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

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _Emergency_room,
          _Emergency_trauma_unit]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -1830887859865804800L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS996FHIRAptTxforSTEMI-2.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (35)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 9042567821391586271L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("ED Encounter During MP")]
    public IEnumerable<Encounter> ED_Encounter_During_MP(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_During_MP, ED_Encounter_During_MP_Compute);

    private const long _cacheIndex_ED_Encounter_During_MP = 5306044393397104968L;

    private IEnumerable<Encounter> ED_Encounter_During_MP_Compute(CqlContext context)
    {
        PropertyInfo a_ = (typeof(Encounter)).GetProperty("Class");
        CqlCode b_ = this.EMER(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(a_, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? e_(Encounter EDEncounter) {
            List<CodeableConcept> g_ = EDEncounter?.Type;

            CqlConcept h_(CodeableConcept @this) {
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return af_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet j_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            Period l_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
            bool? q_ = context.Operators.And(k_, p_);
            Code<Encounter.EncounterStatus> r_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? s_ = r_?.Value;
            Code<Encounter.EncounterStatus> t_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(s_);
            bool? u_ = context.Operators.Equal(t_, "finished");
            bool? v_ = context.Operators.And(q_, u_);
            Patient w_ = this.Patient(context);
            Date x_ = w_?.BirthDateElement;
            string y_ = x_?.Value;
            CqlDate z_ = context.Operators.ConvertStringToDate(y_);
            CqlDateTime aa_ = context.Operators.Start(m_);
            CqlDate ab_ = context.Operators.DateFrom(aa_);
            int? ac_ = context.Operators.CalculateAgeAt(z_, ab_, "year");
            bool? ad_ = context.Operators.GreaterOrEqual(ac_, 18);
            bool? ae_ = context.Operators.And(v_, ad_);
            return ae_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_STEMI_Diagnosis, ED_Encounter_with_STEMI_Diagnosis_Compute);

    private const long _cacheIndex_ED_Encounter_with_STEMI_Diagnosis = 2834645475702299712L;

    private IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_During_MP(context);

        bool? b_(Encounter EDEncounterinMP) {
            List<CodeableConcept> d_ = EDEncounterinMP?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.STEMI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> k_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, j_ as IEnumerable<Condition>);
            IEnumerable<Condition> l_ = Status_1_15_000.Instance.verified(context, k_);

            bool? m_(Condition DxSTEMI) {
                IEnumerable<Condition> r_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EDEncounterinMP);

                bool? s_(Condition @this) {
                    CodeableConcept ae_ = @this?.Code;
                    CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                    bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                    return ag_;
                }

                IEnumerable<Condition> t_ = context.Operators.Where<Condition>(r_, s_);

                CqlConcept u_(Condition @this) {
                    CodeableConcept ah_ = @this?.Code;
                    CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_);
                    return ai_;
                }

                IEnumerable<CqlConcept> v_ = context.Operators.Select<Condition, CqlConcept>(t_, u_);
                CqlValueSet w_ = this.STEMI(context);
                bool? x_ = context.Operators.ConceptsInValueSet(v_, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime z_ = context.Operators.Start(y_);
                Period aa_ = EDEncounterinMP?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                bool? ac_ = context.Operators.In<CqlDateTime>(z_, ab_, (string)default);
                bool? ad_ = context.Operators.Or(x_, ac_);
                return ad_;
            }

            IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
            bool? o_ = context.Operators.Exists<Condition>(n_);
            bool? p_ = context.Operators.Or(h_, o_);
            return p_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 2152524893633359082L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 3055380145274978900L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
    public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter, Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter_Compute);

    private const long _cacheIndex_Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter = 502537557117955598L;

    private IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            CqlValueSet d_ = this.Thrombolytic_medications(context);
            IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));

            bool? f_(AllergyIntolerance ThrombolyticAllergy) {
                CodeableConcept i_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, i_);
                CqlCode k_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
                bool? m_ = context.Operators.Equivalent(j_, l_);
                CodeableConcept n_ = ThrombolyticAllergy?.VerificationStatus;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                bool? p_ = context.Operators.Not((bool?)(o_ is null));
                CqlCode q_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(o_, r_);
                CqlCode t_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(o_, u_);
                bool? w_ = context.Operators.Or(s_, v_);
                bool? x_ = context.Operators.Implies(p_, w_);
                bool? y_ = context.Operators.And(m_, x_);
                DataType z_ = ThrombolyticAllergy?.Onset;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                Period ac_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.Overlaps(ab_, ad_, (string)default);
                CqlDateTime af_ = context.Operators.End(ad_);
                bool? ag_ = context.Operators.Before(aa_ as CqlDateTime, af_, (string)default);
                bool? ah_ = context.Operators.Or(ae_, ag_);
                bool? ai_ = context.Operators.And(y_, ah_);
                return ai_;
            }

            IEnumerable<AllergyIntolerance> g_ = context.Operators.Where<AllergyIntolerance>(e_, f_);
            bool? h_ = context.Operators.Exists<AllergyIntolerance>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
    public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter, Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter_Compute);

    private const long _cacheIndex_Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter = -2540394215636061597L;

    private IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            CqlValueSet d_ = this.Thrombolytics_Adverse_Event(context);
            IEnumerable<AdverseEvent> e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));

            bool? f_(AdverseEvent ThrombolyticAdverseEvent) {
                FhirDateTime i_ = ThrombolyticAdverseEvent?.DateElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                FhirDateTime k_ = ThrombolyticAdverseEvent?.DetectedElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                FhirDateTime m_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.End(p_);
                bool? r_ = context.Operators.Before((j_ ?? l_) ?? n_, q_, (string)default);
                Code<AdverseEvent.AdverseEventActuality> s_ = ThrombolyticAdverseEvent?.ActualityElement;
                AdverseEvent.AdverseEventActuality? t_ = s_?.Value;
                Code<AdverseEvent.AdverseEventActuality> u_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(t_);
                bool? v_ = context.Operators.Equal(u_, "actual");
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            IEnumerable<AdverseEvent> g_ = context.Operators.Where<AdverseEvent>(e_, f_);
            bool? h_ = context.Operators.Exists<AdverseEvent>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis at Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter, Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter = -6244540683477294420L;

    private IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlValueSet d_ = this.Active_Bleeding_or_Bleeding_Diathesis__Excluding_Menses(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet f_ = this.Malignant_Intracranial_Neoplasm_Group(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet i_ = this.Cerebral_Vascular_Lesion(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet k_ = this.Dementia_and_Related_Intracranial_Pathologies(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
            IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
            CqlValueSet o_ = this.Pregnant_State(context);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet q_ = this.Allergy_to_thrombolytics(context);
            IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_, r_);
            IEnumerable<Condition> t_ = context.Operators.Union<Condition>(n_, s_);
            Condition u_(Condition X) => X as Condition;
            IEnumerable<Condition> v_ = context.Operators.Select<Condition, Condition>(t_, u_);
            IEnumerable<Condition> w_ = Status_1_15_000.Instance.verified(context, v_);

            bool? x_(Condition ActiveExclusionDx) {
                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period ab_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                bool? ad_ = context.Operators.OverlapsBefore(aa_, ac_, (string)default);
                return ad_;
            }

            IEnumerable<Condition> y_ = context.Operators.Where<Condition>(w_, x_);
            bool? z_ = context.Operators.Exists<Condition>(y_);
            return z_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter, Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter = 2002931957464647766L;

    private IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Oral_Anticoagulant_Medications(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest OralAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "order");
                bool? aj_ = context.Operators.And(ae_, ai_);
                FhirDateTime ak_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(ak_);
                Period am_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlQuantity ap_ = context.Operators.Quantity(90m, "days");
                CqlDateTime aq_ = context.Operators.Subtract(ao_, ap_);
                CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(aq_, ao_, true, true);
                bool? as_ = context.Operators.In<CqlDateTime>(al_, ar_, (string)default);
                bool? at_ = context.Operators.Not((bool?)(ao_ is null));
                bool? au_ = context.Operators.And(as_, at_);
                bool? av_ = context.Operators.And(aj_, au_);
                return av_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Long Term use of Anticoagulants")]
    public IEnumerable<Encounter> Active_Long_Term_use_of_Anticoagulants(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Long_Term_use_of_Anticoagulants, Active_Long_Term_use_of_Anticoagulants_Compute);

    private const long _cacheIndex_Active_Long_Term_use_of_Anticoagulants = -6249883915813703985L;

    private IEnumerable<Encounter> Active_Long_Term_use_of_Anticoagulants_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlCode d_ = this.Long_term__current__use_of_anticoagulants(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
            IEnumerable<Condition> i_ = Status_1_15_000.Instance.verified(context, h_);

            bool? j_(Condition LongTermAnticoagulant) {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LongTermAnticoagulant);
                CqlDateTime n_ = context.Operators.Start(m_);
                Period o_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                bool? r_ = context.Operators.SameOrBefore(n_, q_, (string)default);
                CqlDateTime s_ = context.Operators.End(m_);
                bool? t_ = context.Operators.SameOrAfter(s_, q_, (string)default);
                bool? u_ = context.Operators.And(r_, t_);
                return u_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active use of Anticoagulants")]
    public IEnumerable<Encounter> Active_use_of_Anticoagulants(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_use_of_Anticoagulants, Active_use_of_Anticoagulants_Compute);

    private const long _cacheIndex_Active_use_of_Anticoagulants = 6407732073469548509L;

    private IEnumerable<Encounter> Active_use_of_Anticoagulants_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> b_ = this.Active_Long_Term_use_of_Anticoagulants(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start, Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute);

    private const long _cacheIndex_Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start = 5358861958155102662L;

    private IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlValueSet d_ = this.Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet f_ = this.Neurologic_impairment(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlCode i_ = this.Angina_pectoris_with_documented_spasm(context);
            IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlCode l_ = this.Ventricular_aneurysm_due_to_and_following_acute_myocardial_infarction__disorder_(context);
            IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
            IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> o_ = context.Operators.Union<Condition>(k_, n_);
            IEnumerable<Condition> p_ = context.Operators.Union<Condition>(h_, o_);
            CqlCode q_ = this.Aneurysm_of_heart(context);
            IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
            IEnumerable<Condition> s_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlCode t_ = this.Takotsubo_cardiomyopathy__disorder_(context);
            IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
            IEnumerable<Condition> v_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> w_ = context.Operators.Union<Condition>(s_, v_);
            IEnumerable<Condition> x_ = context.Operators.Union<Condition>(p_, w_);
            CqlCode y_ = this.Takotsubo_syndrome(context);
            IEnumerable<CqlCode> z_ = context.Operators.ToList<CqlCode>(y_);
            IEnumerable<Condition> aa_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet ab_ = this.Cardiopulmonary_Emergency(context);
            IEnumerable<Condition> ac_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> ad_ = context.Operators.Union<Condition>(aa_, ac_);
            IEnumerable<Condition> ae_ = context.Operators.Union<Condition>(x_, ad_);
            Condition af_(Condition X) => X as Condition;
            IEnumerable<Condition> ag_ = context.Operators.Select<Condition, Condition>(ae_, af_);
            IEnumerable<Condition> ah_ = Status_1_15_000.Instance.verified(context, ag_);

            bool? ai_(Condition ExclusionDiagnosis) {
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime am_ = context.Operators.Start(al_);
                Period an_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                bool? ap_ = context.Operators.In<CqlDateTime>(am_, ao_, (string)default);
                CqlDateTime aq_ = context.Operators.Start(ao_);
                CqlQuantity ar_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(as_, aq_, true, false);
                bool? au_ = context.Operators.In<CqlDateTime>(am_, at_, (string)default);
                bool? av_ = context.Operators.Not((bool?)(aq_ is null));
                bool? aw_ = context.Operators.And(au_, av_);
                bool? ax_ = context.Operators.Or(ap_, aw_);
                return ax_;
            }

            IEnumerable<Condition> aj_ = context.Operators.Where<Condition>(ah_, ai_);
            bool? ak_ = context.Operators.Exists<Condition>(aj_);
            return ak_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
    public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter, Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter_Compute);

    private const long _cacheIndex_Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter = -3071350002189155271L;

    private IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlValueSet d_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure MajorSurgery) {

                object i_() {

                    bool ae_() {
                        DataType ai_ = MajorSurgery?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlDateTime;
                        return ak_;
                    }


                    bool af_() {
                        DataType al_ = MajorSurgery?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlQuantity;
                        return an_;
                    }


                    bool ag_() {
                        DataType ao_ = MajorSurgery?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                        return aq_;
                    }


                    bool ah_() {
                        DataType ar_ = MajorSurgery?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlInterval<CqlQuantity>;
                        return at_;
                    }

                    if (ae_())
                    {
                        DataType au_ = MajorSurgery?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        return av_ as CqlDateTime;
                    }
                    else if (af_())
                    {
                        DataType aw_ = MajorSurgery?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return ax_ as CqlQuantity;
                    }
                    else if (ag_())
                    {
                        DataType ay_ = MajorSurgery?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return az_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ah_())
                    {
                        DataType ba_ = MajorSurgery?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return bb_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(21m, "days");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(p_, n_, true, false);
                bool? r_ = context.Operators.In<CqlDateTime>(k_, q_, (string)default);
                bool? s_ = context.Operators.Not((bool?)(n_ is null));
                bool? t_ = context.Operators.And(r_, s_);

                object u_() {

                    bool bc_() {
                        DataType bg_ = MajorSurgery?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlDateTime;
                        return bi_;
                    }


                    bool bd_() {
                        DataType bj_ = MajorSurgery?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlQuantity;
                        return bl_;
                    }


                    bool be_() {
                        DataType bm_ = MajorSurgery?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                        return bo_;
                    }


                    bool bf_() {
                        DataType bp_ = MajorSurgery?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlQuantity>;
                        return br_;
                    }

                    if (bc_())
                    {
                        DataType bs_ = MajorSurgery?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        return bt_ as CqlDateTime;
                    }
                    else if (bd_())
                    {
                        DataType bu_ = MajorSurgery?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        return bv_ as CqlQuantity;
                    }
                    else if (be_())
                    {
                        DataType bw_ = MajorSurgery?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        return bx_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bf_())
                    {
                        DataType by_ = MajorSurgery?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        return bz_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                CqlDateTime w_ = context.Operators.Start(v_);
                bool? x_ = context.Operators.In<CqlDateTime>(w_, m_, (string)default);
                bool? y_ = context.Operators.Or(t_, x_);
                Code<EventStatus> z_ = MajorSurgery?.StatusElement;
                EventStatus? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                bool? ac_ = context.Operators.Equal(ab_, "completed");
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intubation or Mechanical Circulatory Assist Device Placement or Removal Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start, Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute);

    private const long _cacheIndex_Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start = -780558220455665998L;

    private IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Device_Placement_or_Removal_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlValueSet d_ = this.Endotracheal_Intubation(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet f_ = this.Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);

            bool? i_(Procedure AirwayProcedure) {

                object l_() {

                    bool ah_() {
                        DataType al_ = AirwayProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlDateTime;
                        return an_;
                    }


                    bool ai_() {
                        DataType ao_ = AirwayProcedure?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlQuantity;
                        return aq_;
                    }


                    bool aj_() {
                        DataType ar_ = AirwayProcedure?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlInterval<CqlDateTime>;
                        return at_;
                    }


                    bool ak_() {
                        DataType au_ = AirwayProcedure?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlQuantity>;
                        return aw_;
                    }

                    if (ah_())
                    {
                        DataType ax_ = AirwayProcedure?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        return ay_ as CqlDateTime;
                    }
                    else if (ai_())
                    {
                        DataType az_ = AirwayProcedure?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        return ba_ as CqlQuantity;
                    }
                    else if (aj_())
                    {
                        DataType bb_ = AirwayProcedure?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        return bc_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ak_())
                    {
                        DataType bd_ = AirwayProcedure?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        return be_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_());
                CqlDateTime n_ = context.Operators.Start(m_);
                Period o_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, (string)default);

                object r_() {

                    bool bf_() {
                        DataType bj_ = AirwayProcedure?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlDateTime;
                        return bl_;
                    }


                    bool bg_() {
                        DataType bm_ = AirwayProcedure?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlQuantity;
                        return bo_;
                    }


                    bool bh_() {
                        DataType bp_ = AirwayProcedure?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlInterval<CqlDateTime>;
                        return br_;
                    }


                    bool bi_() {
                        DataType bs_ = AirwayProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        return bu_;
                    }

                    if (bf_())
                    {
                        DataType bv_ = AirwayProcedure?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        return bw_ as CqlDateTime;
                    }
                    else if (bg_())
                    {
                        DataType bx_ = AirwayProcedure?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        return by_ as CqlQuantity;
                    }
                    else if (bh_())
                    {
                        DataType bz_ = AirwayProcedure?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        return ca_ as CqlInterval<CqlDateTime>;
                    }
                    else if (bi_())
                    {
                        DataType cb_ = AirwayProcedure?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        return cc_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlDateTime u_ = context.Operators.Start(p_);
                CqlQuantity v_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, u_, true, false);
                bool? y_ = context.Operators.In<CqlDateTime>(t_, x_, (string)default);
                bool? z_ = context.Operators.Not((bool?)(u_ is null));
                bool? aa_ = context.Operators.And(y_, z_);
                bool? ab_ = context.Operators.Or(q_, aa_);
                Code<EventStatus> ac_ = AirwayProcedure?.StatusElement;
                EventStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                bool? af_ = context.Operators.Equal(ae_, "completed");
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter, Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter = 1408893699383217546L;

    private IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            CqlValueSet d_ = this.Ischemic_Stroke(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet f_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet i_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
            Condition l_(Condition X) => X as Condition;
            IEnumerable<Condition> m_ = context.Operators.Select<Condition, Condition>(k_, l_);
            IEnumerable<Condition> n_ = Status_1_15_000.Instance.verified(context, m_);

            bool? o_(Condition ExclusionCondition) {
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime s_ = context.Operators.Start(r_);
                Period t_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlQuantity w_ = context.Operators.Quantity(90m, "days");
                CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, v_, true, true);
                bool? z_ = context.Operators.In<CqlDateTime>(s_, y_, (string)default);
                return z_;
            }

            IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
            bool? q_ = context.Operators.Exists<Condition>(p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter, Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter_Compute);

    private const long _cacheIndex_Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter = -6569882930745692123L;

    private IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlValueSet d_ = this.Intracranial_or_Intraspinal_surgery(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure CranialorSpinalSurgery) {

                object i_() {

                    bool z_() {
                        DataType ad_ = CranialorSpinalSurgery?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlDateTime;
                        return af_;
                    }


                    bool aa_() {
                        DataType ag_ = CranialorSpinalSurgery?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlQuantity;
                        return ai_;
                    }


                    bool ab_() {
                        DataType aj_ = CranialorSpinalSurgery?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlInterval<CqlDateTime>;
                        return al_;
                    }


                    bool ac_() {
                        DataType am_ = CranialorSpinalSurgery?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlQuantity>;
                        return ao_;
                    }

                    if (z_())
                    {
                        DataType ap_ = CranialorSpinalSurgery?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return aq_ as CqlDateTime;
                    }
                    else if (aa_())
                    {
                        DataType ar_ = CranialorSpinalSurgery?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return as_ as CqlQuantity;
                    }
                    else if (ab_())
                    {
                        DataType at_ = CranialorSpinalSurgery?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return au_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ac_())
                    {
                        DataType av_ = CranialorSpinalSurgery?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        return aw_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(90m, "days");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(p_, n_, true, false);
                bool? r_ = context.Operators.In<CqlDateTime>(k_, q_, (string)default);
                bool? s_ = context.Operators.Not((bool?)(n_ is null));
                bool? t_ = context.Operators.And(r_, s_);
                Code<EventStatus> u_ = CranialorSpinalSurgery?.StatusElement;
                EventStatus? v_ = u_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "completed");
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Patient Expired")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Patient_Expired, ED_Encounter_with_Discharge_Disposition_as_Patient_Expired_Compute);

    private const long _cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Patient_Expired = -5706805016315765911L;

    private IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            Encounter.HospitalizationComponent d_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Patient_Expired(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Left Against Medical Advice")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice, ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice_Compute);

    private const long _cacheIndex_ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice = -731904171393251097L;

    private IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Left_Against_Medical_Advice_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            Encounter.HospitalizationComponent d_ = EDwSTEMI?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Left_Against_Medical_Advice(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with Hospice Services")]
    public IEnumerable<Encounter> ED_Encounter_with_Hospice_Services(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_Hospice_Services, ED_Encounter_with_Hospice_Services_Compute);

    private const long _cacheIndex_ED_Encounter_with_Hospice_Services = -4226681865471752242L;

    private IEnumerable<Encounter> ED_Encounter_with_Hospice_Services_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            CqlValueSet d_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> e_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> f_ = Status_1_15_000.Instance.isEncounterPerformed(context, e_);

            bool? g_(Encounter InpatientEncounter) {
                Encounter.HospitalizationComponent au_ = InpatientEncounter?.Hospitalization;
                CodeableConcept av_ = au_?.DischargeDisposition;
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, av_);
                CqlCode ax_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
                bool? az_ = context.Operators.Equivalent(aw_, ay_);
                CqlCode ba_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(aw_, bb_);
                bool? bd_ = context.Operators.Or(az_, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                Period bh_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                bool? bk_ = context.Operators.SameOrBefore(bg_, bj_, (string)default);
                bool? bl_ = context.Operators.And(bd_, bk_);
                CqlQuantity bm_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bn_ = context.Operators.Subtract(bj_, bm_);
                CqlDateTime bo_ = context.Operators.End(bi_);
                CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bn_, bo_, true, true);
                bool? bq_ = context.Operators.Overlaps(bf_, bp_, "day");
                bool? br_ = context.Operators.And(bl_, bq_);
                return br_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            bool? i_ = context.Operators.Exists<Encounter>(h_);
            CqlValueSet j_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> k_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> l_ = Status_1_15_000.Instance.isEncounterPerformed(context, k_);

            bool? m_(Encounter HospiceEncounter) {
                Period bs_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                Period bv_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                CqlDateTime bx_ = context.Operators.Start(bw_);
                bool? by_ = context.Operators.SameOrBefore(bu_, bx_, (string)default);
                CqlQuantity bz_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ca_ = context.Operators.Subtract(bx_, bz_);
                CqlDateTime cb_ = context.Operators.End(bw_);
                CqlInterval<CqlDateTime> cc_ = context.Operators.Interval(ca_, cb_, true, true);
                bool? cd_ = context.Operators.Overlaps(bt_, cc_, "day");
                bool? ce_ = context.Operators.And(by_, cd_);
                return ce_;
            }

            IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
            bool? o_ = context.Operators.Exists<Encounter>(n_);
            bool? p_ = context.Operators.Or(i_, o_);
            CqlCode q_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
            IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> t_ = Status_1_15_000.Instance.isAssessmentPerformed(context, s_);

            bool? u_(Observation HospiceAssessment) {
                DataType cf_ = (HospiceAssessment as Observation)?.Value;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                CqlCode ch_ = this.Yes__qualifier_value_(context);
                CqlConcept ci_ = context.Operators.ConvertCodeToConcept(ch_);
                bool? cj_ = context.Operators.Equivalent(cg_ as CqlConcept, ci_);
                DataType ck_ = HospiceAssessment?.Effective;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                CqlInterval<CqlDateTime> cm_ = QICoreCommon_4_0_000.Instance.toInterval(context, cl_);
                CqlDateTime cn_ = context.Operators.Start(cm_);
                Period co_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                bool? cr_ = context.Operators.SameOrBefore(cn_, cq_, (string)default);
                bool? cs_ = context.Operators.And(cj_, cr_);
                CqlQuantity ct_ = context.Operators.Quantity(6m, "months");
                CqlDateTime cu_ = context.Operators.Subtract(cq_, ct_);
                CqlDateTime cv_ = context.Operators.End(cp_);
                CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(cu_, cv_, true, true);
                bool? cx_ = context.Operators.Overlaps(cm_, cw_, "day");
                bool? cy_ = context.Operators.And(cs_, cx_);
                return cy_;
            }

            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(t_, u_);
            bool? w_ = context.Operators.Exists<Observation>(v_);
            bool? x_ = context.Operators.Or(p_, w_);
            CqlValueSet y_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> z_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> aa_ = Status_1_15_000.Instance.isInterventionOrder(context, z_);

            bool? ab_(ServiceRequest HospiceOrder) {
                FhirDateTime cz_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime da_ = context.Operators.Convert<CqlDateTime>(cz_);
                Period db_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, db_);
                CqlDateTime dd_ = context.Operators.Start(dc_);
                CqlQuantity de_ = context.Operators.Quantity(6m, "months");
                CqlDateTime df_ = context.Operators.Subtract(dd_, de_);
                CqlInterval<CqlDateTime> dg_ = context.Operators.Interval(df_, dd_, true, false);
                bool? dh_ = context.Operators.In<CqlDateTime>(da_, dg_, (string)default);
                bool? di_ = context.Operators.Not((bool?)(dd_ is null));
                bool? dj_ = context.Operators.And(dh_, di_);
                return dj_;
            }

            IEnumerable<ServiceRequest> ac_ = context.Operators.Where<ServiceRequest>(aa_, ab_);
            bool? ad_ = context.Operators.Exists<ServiceRequest>(ac_);
            bool? ae_ = context.Operators.Or(x_, ad_);
            IEnumerable<Procedure> af_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> ag_ = Status_1_15_000.Instance.isInterventionPerformed(context, af_);

            bool? ah_(Procedure HospicePerformed) {

                object dk_() {

                    bool dz_() {
                        DataType ed_ = HospicePerformed?.Performed;
                        object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                        bool ef_ = ee_ is CqlDateTime;
                        return ef_;
                    }


                    bool ea_() {
                        DataType eg_ = HospicePerformed?.Performed;
                        object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                        bool ei_ = eh_ is CqlQuantity;
                        return ei_;
                    }


                    bool eb_() {
                        DataType ej_ = HospicePerformed?.Performed;
                        object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                        bool el_ = ek_ is CqlInterval<CqlDateTime>;
                        return el_;
                    }


                    bool ec_() {
                        DataType em_ = HospicePerformed?.Performed;
                        object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                        bool eo_ = en_ is CqlInterval<CqlQuantity>;
                        return eo_;
                    }

                    if (dz_())
                    {
                        DataType ep_ = HospicePerformed?.Performed;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        return eq_ as CqlDateTime;
                    }
                    else if (ea_())
                    {
                        DataType er_ = HospicePerformed?.Performed;
                        object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                        return es_ as CqlQuantity;
                    }
                    else if (eb_())
                    {
                        DataType et_ = HospicePerformed?.Performed;
                        object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                        return eu_ as CqlInterval<CqlDateTime>;
                    }
                    else if (ec_())
                    {
                        DataType ev_ = HospicePerformed?.Performed;
                        object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                        return ew_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> dl_ = QICoreCommon_4_0_000.Instance.toInterval(context, dk_());
                CqlDateTime dm_ = context.Operators.Start(dl_);
                Period dn_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                CqlDateTime dp_ = context.Operators.Start(do_);
                bool? dq_ = context.Operators.SameOrBefore(dm_, dp_, (string)default);

                object dr_() {

                    bool ex_() {
                        DataType fb_ = HospicePerformed?.Performed;
                        object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                        bool fd_ = fc_ is CqlDateTime;
                        return fd_;
                    }


                    bool ey_() {
                        DataType fe_ = HospicePerformed?.Performed;
                        object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                        bool fg_ = ff_ is CqlQuantity;
                        return fg_;
                    }


                    bool ez_() {
                        DataType fh_ = HospicePerformed?.Performed;
                        object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                        bool fj_ = fi_ is CqlInterval<CqlDateTime>;
                        return fj_;
                    }


                    bool fa_() {
                        DataType fk_ = HospicePerformed?.Performed;
                        object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                        bool fm_ = fl_ is CqlInterval<CqlQuantity>;
                        return fm_;
                    }

                    if (ex_())
                    {
                        DataType fn_ = HospicePerformed?.Performed;
                        object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                        return fo_ as CqlDateTime;
                    }
                    else if (ey_())
                    {
                        DataType fp_ = HospicePerformed?.Performed;
                        object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                        return fq_ as CqlQuantity;
                    }
                    else if (ez_())
                    {
                        DataType fr_ = HospicePerformed?.Performed;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        return fs_ as CqlInterval<CqlDateTime>;
                    }
                    else if (fa_())
                    {
                        DataType ft_ = HospicePerformed?.Performed;
                        object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                        return fu_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> ds_ = QICoreCommon_4_0_000.Instance.toInterval(context, dr_());
                CqlQuantity dt_ = context.Operators.Quantity(6m, "months");
                CqlDateTime du_ = context.Operators.Subtract(dp_, dt_);
                CqlDateTime dv_ = context.Operators.End(do_);
                CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(du_, dv_, true, true);
                bool? dx_ = context.Operators.Overlaps(ds_, dw_, "day");
                bool? dy_ = context.Operators.And(dq_, dx_);
                return dy_;
            }

            IEnumerable<Procedure> ai_ = context.Operators.Where<Procedure>(ag_, ah_);
            bool? aj_ = context.Operators.Exists<Procedure>(ai_);
            bool? ak_ = context.Operators.Or(ae_, aj_);
            CqlValueSet al_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            Condition an_(Condition X) => X as Condition;
            IEnumerable<Condition> ao_ = context.Operators.Select<Condition, Condition>(am_, an_);
            IEnumerable<Condition> ap_ = Status_1_15_000.Instance.verified(context, ao_);

            bool? aq_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> fv_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlDateTime fw_ = context.Operators.End(fv_);
                Period fx_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> fy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fx_);
                CqlDateTime fz_ = context.Operators.Start(fy_);
                bool? ga_ = context.Operators.SameOrAfter(fw_, fz_, (string)default);
                return ga_;
            }

            IEnumerable<Condition> ar_ = context.Operators.Where<Condition>(ap_, aq_);
            bool? as_ = context.Operators.Exists<Condition>(ar_);
            bool? at_ = context.Operators.Or(ak_, as_);
            return at_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Currently Pregnant")]
    public IEnumerable<Encounter> Currently_Pregnant(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Currently_Pregnant, Currently_Pregnant_Compute);

    private const long _cacheIndex_Currently_Pregnant = 4224761559664591920L;

    private IEnumerable<Encounter> Currently_Pregnant_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));

            bool? e_(Observation PregStatus) {
                Code<ObservationStatus> h_ = PregStatus?.StatusElement;
                ObservationStatus? i_ = h_?.Value;
                Code<ObservationStatus> j_ = context.Operators.Convert<Code<ObservationStatus>>(i_);
                bool? k_ = context.Operators.Equal(j_, "final");
                DataType l_ = PregStatus?.Value;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_ as CodeableConcept);
                CqlValueSet n_ = this.Pregnant_State(context);
                bool? o_ = context.Operators.ConceptInValueSet(m_, n_);
                bool? p_ = context.Operators.And(k_, o_);
                DataType q_ = PregStatus?.Effective;
                CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
                Period s_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                bool? u_ = context.Operators.In<CqlDateTime>(r_, t_, (string)default);
                bool? v_ = context.Operators.And(p_, u_);
                return v_;
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            bool? g_ = context.Operators.Exists<Observation>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -1489138186020577646L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
        IEnumerable<Encounter> b_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> e_ = this.Active_use_of_Anticoagulants(context);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        IEnumerable<Encounter> h_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> i_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(context);
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
        IEnumerable<Encounter> x_ = this.Currently_Pregnant(context);
        IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(w_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Received tPA in Another Facility within 24 hours Prior to Admission")]
    public IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission, Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission_Compute);

    private const long _cacheIndex_Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission = 5761351899677059903L;

    private IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlCode d_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);
            IEnumerable<Condition> i_ = Status_1_15_000.Instance.verified(context, h_);

            bool? j_(Condition TPA) {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime n_ = context.Operators.Start(m_);
                Period o_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, (string)default);
                return q_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for No PCI Performed")]
    public IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed, ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed_Compute);

    private const long _cacheIndex_ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed = 4861476912755213235L;

    private IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            CqlValueSet d_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            IEnumerable<Procedure> f_ = context.Operators.Union<Procedure>(e_, e_);

            bool? g_(Procedure PCINotDone) {
                CodeableConcept j_ = PCINotDone?.StatusReason;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Patient_Refusal(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                CqlValueSet n_ = this.Procedure_Not_Indicated_Contraindicated(context);
                bool? o_ = context.Operators.ConceptInValueSet(k_, n_);
                bool? p_ = context.Operators.Or(m_, o_);

                bool? q_(Extension @this) {
                    FhirUri ab_ = @this?.UrlElement;
                    string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                    bool? ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ad_;
                }

                IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(PCINotDone is DomainResource
                    ? (PCINotDone as DomainResource).Extension
                    : default), q_);

                DataType s_(Extension @this) {
                    DataType ae_ = @this?.Value;
                    return ae_;
                }

                IEnumerable<DataType> t_ = context.Operators.Select<Extension, DataType>(r_, s_);
                DataType u_ = context.Operators.SingletonFrom<DataType>(t_);
                FhirDateTime v_ = context.Operators.Convert<FhirDateTime>(u_);
                CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
                Period x_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, (string)default);
                bool? aa_ = context.Operators.And(p_, z_);
                return aa_;
            }

            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            bool? i_ = context.Operators.Exists<Procedure>(h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy")]
    public IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy, ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Compute);

    private const long _cacheIndex_ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy = 2696627271993019511L;

    private IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwSTEMI) {
            CqlValueSet d_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
            IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(e_, e_);

            bool? g_(MedicationAdministration FibrinolyticNoMed) {
                List<CodeableConcept> j_ = FibrinolyticNoMed?.StatusReason;

                CqlConcept k_(CodeableConcept @this) {
                    CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ae_;
                }

                IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
                CqlValueSet m_ = this.Patient_Refusal(context);
                bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

                CqlConcept o_(CodeableConcept @this) {
                    CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return af_;
                }

                IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, o_);
                CqlValueSet q_ = this.Drug_Intervention_Not_Indicated_Contraindicated(context);
                bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);
                bool? s_ = context.Operators.Or(n_, r_);

                bool? t_(Extension @this) {
                    FhirUri ag_ = @this?.UrlElement;
                    string ah_ = FHIRHelpers_4_4_000.Instance.ToString(context, ag_);
                    bool? ai_ = context.Operators.Equal(ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                    return ai_;
                }

                IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FibrinolyticNoMed is DomainResource
                    ? (FibrinolyticNoMed as DomainResource).Extension
                    : default), t_);

                DataType v_(Extension @this) {
                    DataType aj_ = @this?.Value;
                    return aj_;
                }

                IEnumerable<DataType> w_ = context.Operators.Select<Extension, DataType>(u_, v_);
                DataType x_ = context.Operators.SingletonFrom<DataType>(w_);
                FhirDateTime y_ = context.Operators.Convert<FhirDateTime>(x_);
                CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
                Period aa_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                bool? ac_ = context.Operators.In<CqlDateTime>(z_, ab_, (string)default);
                bool? ad_ = context.Operators.And(s_, ac_);
                return ad_;
            }

            IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
            bool? i_ = context.Operators.Exists<MedicationAdministration>(h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = -6308283377563653028L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(context);
        IEnumerable<Encounter> b_ = this.ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlFunctionDefinition("currentemergencyDepartmentArrivalTime")]
    public CqlDateTime currentemergencyDepartmentArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;

        bool? b_(Encounter.LocationComponent EDLocation) {
            ResourceReference i_ = EDLocation?.Location;
            Location j_ = CQMCommon_4_1_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;

            CqlConcept l_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);

            bool? n_(CqlConcept LocationType) {
                CqlValueSet r_ = this.Emergency_Department_Visit(context);
                bool? s_ = context.Operators.ConceptInValueSet(LocationType, r_);
                CqlCode t_ = this.Emergency_room(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(LocationType, u_);
                bool? w_ = context.Operators.Or(s_, v_);
                CqlCode x_ = this.Emergency_trauma_unit(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(LocationType, y_);
                bool? aa_ = context.Operators.Or(w_, z_);
                Period ab_ = EDLocation?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            IEnumerable<CqlConcept> o_ = context.Operators.Where<CqlConcept>(m_, n_);
            bool? p_ = context.Operators.Exists<CqlConcept>(o_);
            return p_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);

        CqlDateTime d_(Encounter.LocationComponent EDLocation) {
            Period ag_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            return ai_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.First<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Fibrinolytic Therapy Administration within 30 Minutes of Arrival")]
    public IEnumerable<Encounter> Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival, Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival_Compute);

    private const long _cacheIndex_Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival = -7313533688387407620L;

    private IEnumerable<Encounter> Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? e_(MedicationAdministration MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Fibrinolytic_Therapy(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration Fibrinolytic) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> aa_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                bool? ad_ = context.Operators.Equal(ac_, "completed");
                DataType ae_ = Fibrinolytic?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlDateTime ai_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "minutes");
                CqlDateTime ak_ = context.Operators.Add(ai_, aj_);
                CqlInterval<CqlDateTime> al_ = context.Operators.Interval(ai_, ak_, false, true);
                bool? am_ = context.Operators.In<CqlDateTime>(ah_, al_, (string)default);
                bool? an_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ao_ = context.Operators.And(am_, an_);
                bool? ap_ = context.Operators.And(ad_, ao_);
                return ap_;
            }

            IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationAdministration>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("PCI within 90 Minutes of Arrival")]
    public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_PCI_within_90_Minutes_of_Arrival, PCI_within_90_Minutes_of_Arrival_Compute);

    private const long _cacheIndex_PCI_within_90_Minutes_of_Arrival = -5463400308575938821L;

    private IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlValueSet d_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure PCI) {

                object i_() {

                    bool x_() {
                        DataType ab_ = PCI?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlDateTime;
                        return ad_;
                    }


                    bool y_() {
                        DataType ae_ = PCI?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlQuantity;
                        return ag_;
                    }


                    bool z_() {
                        DataType ah_ = PCI?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        return aj_;
                    }


                    bool aa_() {
                        DataType ak_ = PCI?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlQuantity>;
                        return am_;
                    }

                    if (x_())
                    {
                        DataType an_ = PCI?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return ao_ as CqlDateTime;
                    }
                    else if (y_())
                    {
                        DataType ap_ = PCI?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return aq_ as CqlQuantity;
                    }
                    else if (z_())
                    {
                        DataType ar_ = PCI?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return as_ as CqlInterval<CqlDateTime>;
                    }
                    else if (aa_())
                    {
                        DataType at_ = PCI?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return au_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlDateTime l_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity m_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime n_ = context.Operators.Add(l_, m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, false, true);
                bool? p_ = context.Operators.In<CqlDateTime>(k_, o_, (string)default);
                bool? q_ = context.Operators.Not((bool?)(l_ is null));
                bool? r_ = context.Operators.And(p_, q_);
                Code<EventStatus> s_ = PCI?.StatusElement;
                EventStatus? t_ = s_?.Value;
                string u_ = context.Operators.Convert<string>(t_);
                bool? v_ = context.Operators.Equal(u_, "completed");
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("currentemergencyDepartmentDepartTime")]
    public CqlDateTime currentemergencyDepartmentDepartTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;

        bool? b_(Encounter.LocationComponent EDLocation) {
            ResourceReference i_ = EDLocation?.Location;
            Location j_ = CQMCommon_4_1_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;

            CqlConcept l_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);

            bool? n_(CqlConcept LocationType) {
                CqlValueSet r_ = this.Emergency_Department_Visit(context);
                bool? s_ = context.Operators.ConceptInValueSet(LocationType, r_);
                CqlCode t_ = this.Emergency_room(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(LocationType, u_);
                bool? w_ = context.Operators.Or(s_, v_);
                CqlCode x_ = this.Emergency_trauma_unit(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(LocationType, y_);
                bool? aa_ = context.Operators.Or(w_, z_);
                Period ab_ = EDLocation?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            IEnumerable<CqlConcept> o_ = context.Operators.Where<CqlConcept>(m_, n_);
            bool? p_ = context.Operators.Exists<CqlConcept>(o_);
            return p_;
        }

        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);

        CqlDateTime d_(Encounter.LocationComponent EDLocation) {
            Period ag_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.End(ah_);
            return ai_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);
        return h_;
    }


    [CqlExpressionDefinition("ED Departure with Discharge to Acute Care Facility Within 45 Minutes Of Arrival")]
    public IEnumerable<Encounter> ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival, ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival_Compute);

    private const long _cacheIndex_ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival = 8151977692912060192L;

    private IEnumerable<Encounter> ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        bool? b_(Encounter EDwithSTEMI) {
            CqlDateTime d_ = this.currentemergencyDepartmentDepartTime(context, EDwithSTEMI);
            CqlDateTime e_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
            CqlQuantity f_ = context.Operators.Quantity(45m, "minutes");
            CqlDateTime g_ = context.Operators.Add(e_, f_);
            CqlInterval<CqlDateTime> h_ = context.Operators.Interval(e_, g_, false, true);
            bool? i_ = context.Operators.In<CqlDateTime>(d_, h_, (string)default);
            bool? j_ = context.Operators.Not((bool?)(e_ is null));
            bool? k_ = context.Operators.And(i_, j_);
            Encounter.HospitalizationComponent l_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept m_ = l_?.DischargeDisposition;
            CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
            CqlValueSet o_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
            bool? q_ = context.Operators.And(k_, p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1584714117989118305L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter> b_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
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
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3876543663401552806L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
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
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -8295183991178300754L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
