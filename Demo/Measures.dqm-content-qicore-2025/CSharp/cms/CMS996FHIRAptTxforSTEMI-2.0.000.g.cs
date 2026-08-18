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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet j_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
            CqlBoolean k_ = context.Operators.ConceptsInValueSet(i_, j_);

            CqlBoolean l_() {
                Period p_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                CqlBoolean t_ = context.Operators.In<CqlDateTime>(r_, s_, "day");
                return t_;
            }


            CqlBoolean m_() {
                Code<Encounter.EncounterStatus> u_ = EDEncounter?.StatusElement;
                Encounter.EncounterStatus? v_ = u_?.Value;
                Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                CqlBoolean x_ = context.Operators.Equal(w_, "finished");
                return x_;
            }


            CqlBoolean n_() {
                Patient y_ = this.Patient(context);
                Date z_ = y_?.BirthDateElement;
                string aa_ = z_?.Value;
                CqlDate ab_ = context.Operators.ConvertStringToDate(aa_);
                Period ac_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                int? ag_ = context.Operators.CalculateAgeAt(ab_, af_, "year");
                CqlBoolean ah_ = context.Operators.GreaterOrEqual(ag_, 18);
                return ah_;
            }

            return k_
                /* CQL 'and' (175:11-176:68) */ && l_()
                /* CQL 'and' (175:11-177:41) */ && m_()
                /* CQL 'and' (175:5-178:68) */ && n_();
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.STEMI(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);

            CqlBoolean i_() {
                CqlValueSet k_ = this.STEMI(context);
                IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> n_ = context.Operators.Union<Condition>(l_ as IEnumerable<Condition>, m_ as IEnumerable<Condition>);
                IEnumerable<Condition> o_ = Status_1_15_000.Instance.verified(context, n_);

                bool? p_(Condition DxSTEMI) {
                    IEnumerable<Condition> r_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EDEncounterinMP);

                    bool? s_(Condition @this) {
                        CodeableConcept y_ = @this?.Code;
                        CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                        return !((bool?)(z_ is null));
                    }


                    CqlConcept t_(Condition @this) {
                        CodeableConcept aa_ = @this?.Code;
                        CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                        return ab_;
                    }

                    IEnumerable<CqlConcept> u_ = context.Operators.WhereSelect<Condition, CqlConcept>(r_, s_, t_);
                    CqlValueSet v_ = this.STEMI(context);
                    CqlBoolean w_ = context.Operators.ConceptsInValueSet(u_, v_);

                    CqlBoolean x_() {
                        CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DxSTEMI);
                        CqlDateTime ad_ = context.Operators.Start(ac_);
                        Period ae_ = EDEncounterinMP?.Period;
                        CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                        CqlBoolean ag_ = context.Operators.In<CqlDateTime>(ad_, af_, (string)default);
                        return ag_;
                    }

                    return w_
                        /* CQL 'or' (186:13-188:13) */ || x_();
                }

                CqlBoolean q_ = context.Operators.WhereAny<Condition>(o_, p_);
                return q_;
            }

            return h_
                /* CQL 'or' (182:5-190:5) */ || i_();
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
                CodeableConcept h_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                CqlCode j_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
                CqlBoolean l_ = context.Operators.Equivalent(i_, k_);

                CqlBoolean m_() {
                    CodeableConcept o_ = ThrombolyticAllergy?.VerificationStatus;
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);

                    CqlBoolean q_() {
                        CodeableConcept r_ = ThrombolyticAllergy?.VerificationStatus;
                        CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                        CqlCode t_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                        CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                        CqlBoolean v_ = context.Operators.Equivalent(s_, u_);

                        CqlBoolean w_() {
                            CodeableConcept x_ = ThrombolyticAllergy?.VerificationStatus;
                            CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                            CqlCode z_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
                            CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                            CqlBoolean ab_ = context.Operators.Equivalent(y_, aa_);
                            return ab_;
                        }

                        return v_
                            /* CQL 'or' (160:74-162:11) */ || w_();
                    }

                    return (CqlBoolean)(!(!((bool?)(p_ is null))))
                        /* CQL 'implies' (160:13-163:9) */ || q_();
                }


                CqlBoolean n_() {
                    DataType ac_ = ThrombolyticAllergy?.Onset;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                    Period af_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                    CqlBoolean ah_ = context.Operators.Overlaps(ae_, ag_, (string)default);

                    CqlBoolean ai_() {
                        DataType aj_ = ThrombolyticAllergy?.Onset;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        Period al_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                        CqlDateTime an_ = context.Operators.End(am_);
                        CqlBoolean ao_ = context.Operators.Before(ak_ as CqlDateTime, an_, (string)default);
                        return ao_;
                    }

                    return ah_
                        /* CQL 'or' (164:13-166:9) */ || ai_();
                }

                return l_
                    /* CQL 'and' (159:17-163:9) */ && m_()
                    /* CQL 'and' (159:17-166:9) */ && n_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<AllergyIntolerance>(e_, f_);
            return g_;
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
                FhirDateTime h_ = ThrombolyticAdverseEvent?.DateElement;
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                FhirDateTime j_ = ThrombolyticAdverseEvent?.DetectedElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                FhirDateTime l_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlBoolean q_ = context.Operators.Before((i_ ?? k_) ?? m_, p_, (string)default);

                CqlBoolean r_() {
                    Code<AdverseEvent.AdverseEventActuality> s_ = ThrombolyticAdverseEvent?.ActualityElement;
                    AdverseEvent.AdverseEventActuality? t_ = s_?.Value;
                    Code<AdverseEvent.AdverseEventActuality> u_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(t_);
                    CqlBoolean v_ = context.Operators.Equal(u_, "actual");
                    return v_;
                }

                return q_
                    /* CQL 'and' (153:17-154:57) */ && r_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<AdverseEvent>(e_, f_);
            return g_;
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
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period aa_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                CqlBoolean ac_ = context.Operators.OverlapsBefore(z_, ab_, (string)default);
                return ac_;
            }

            CqlBoolean y_ = context.Operators.WhereAny<Condition>(w_, x_);
            return y_;
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
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    CqlBoolean s_ = context.Operators.Equal(o_, r_);

                    CqlBoolean t_() {
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Oral_Anticoagulant_Medications(context);
                        CqlBoolean x_ = context.Operators.ConceptInValueSet(v_, w_);
                        return x_;
                    }

                    return s_
                        /* CQL 'and' */ && t_();
                }

                CqlBoolean n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest OralAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> y_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);

                CqlBoolean ad_() {
                    Code<MedicationRequest.MedicationRequestIntent> af_ = OralAnticoagulant?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                    string ah_ = context.Operators.Convert<string>(ag_);
                    CqlBoolean ai_ = context.Operators.Equal(ah_, "order");
                    return ai_;
                }


                CqlBoolean ae_() {
                    FhirDateTime aj_ = OralAnticoagulant?.AuthoredOnElement;
                    CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(aj_);
                    Period al_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                    CqlDateTime an_ = context.Operators.Start(am_);
                    CqlQuantity ao_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
                    CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(ap_, an_, true, true);
                    CqlBoolean ar_ = context.Operators.In<CqlDateTime>(ak_, aq_, (string)default);

                    CqlBoolean as_() {
                        Period at_ = EDwithSTEMI?.Period;
                        CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                        CqlDateTime av_ = context.Operators.Start(au_);
                        return !((bool?)(av_ is null));
                    }

                    return ar_
                        /* CQL 'and' (135:13-135:97) */ && as_();
                }

                return ac_
                    /* CQL 'and' (133:17-134:46) */ && ad_()
                    /* CQL 'and' (133:17-135:97) */ && ae_();
            }

            CqlBoolean k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
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
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LongTermAnticoagulant);
                CqlDateTime m_ = context.Operators.Start(l_);
                Period n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlBoolean q_ = context.Operators.SameOrBefore(m_, p_, (string)default);

                CqlBoolean r_() {
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LongTermAnticoagulant);
                    CqlDateTime t_ = context.Operators.End(s_);
                    Period u_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlBoolean x_ = context.Operators.SameOrAfter(t_, w_, (string)default);
                    return x_;
                }

                return q_
                    /* CQL 'and' (142:17-144:7) */ && r_();
            }

            CqlBoolean k_ = context.Operators.WhereAny<Condition>(i_, j_);
            return k_;
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
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime al_ = context.Operators.Start(ak_);
                Period am_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                CqlBoolean ao_ = context.Operators.In<CqlDateTime>(al_, an_, (string)default);

                CqlBoolean ap_() {
                    CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                    CqlDateTime ar_ = context.Operators.Start(aq_);
                    Period as_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                    CqlDateTime au_ = context.Operators.Start(at_);
                    CqlQuantity av_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
                    CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(aw_, au_, true, false);
                    CqlBoolean ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, (string)default);

                    CqlBoolean az_() {
                        Period ba_ = EDwithSTEMI?.Period;
                        CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                        CqlDateTime bc_ = context.Operators.Start(bb_);
                        return !((bool?)(bc_ is null));
                    }

                    return ay_
                        /* CQL 'and' (244:14-244:117) */ && az_();
                }

                return ao_
                    /* CQL 'or' (243:17-245:7) */ || ap_();
            }

            CqlBoolean aj_ = context.Operators.WhereAny<Condition>(ah_, ai_);
            return aj_;
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
                object h_;
                DataType u_ = MajorSurgery?.Performed;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                bool w_ = v_ is CqlDateTime;
                if (w_)
                {
                    h_ = v_ as CqlDateTime;
                }
                else
                {
                    bool x_ = v_ is CqlQuantity;
                    if (x_)
                    {
                        h_ = v_ as CqlQuantity;
                    }
                    else
                    {
                        bool y_ = v_ is CqlInterval<CqlDateTime>;
                        if (y_)
                        {
                            h_ = v_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool z_ = v_ is CqlInterval<CqlQuantity>;
                            if (z_)
                            {
                                h_ = v_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(21m, "days");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
                CqlBoolean q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);

                CqlBoolean r_() {
                    Period aa_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    return !((bool?)(ac_ is null));
                }


                CqlBoolean s_() {
                    object ad_;
                    DataType aj_ = MajorSurgery?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    if (al_)
                    {
                        ad_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        bool am_ = ak_ is CqlQuantity;
                        if (am_)
                        {
                            ad_ = ak_ as CqlQuantity;
                        }
                        else
                        {
                            bool an_ = ak_ is CqlInterval<CqlDateTime>;
                            if (an_)
                            {
                                ad_ = ak_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ao_ = ak_ is CqlInterval<CqlQuantity>;
                                if (ao_)
                                {
                                    ad_ = ak_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ad_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    Period ag_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                    CqlBoolean ai_ = context.Operators.In<CqlDateTime>(af_, ah_, (string)default);
                    return ai_;
                }


                CqlBoolean t_() {
                    Code<EventStatus> ap_ = MajorSurgery?.StatusElement;
                    EventStatus? aq_ = ap_?.Value;
                    string ar_ = context.Operators.Convert<string>(aq_);
                    CqlBoolean as_ = context.Operators.Equal(ar_, "completed");
                    return as_;
                }

                return q_
                    /* CQL 'and' (294:19-294:113) */ && r_()
                    /* CQL 'or' (294:17-296:7) */ || s_()
                    /* CQL 'and' (294:17-297:45) */ && t_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
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
                object k_;
                DataType s_ = AirwayProcedure?.Performed;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlDateTime;
                if (u_)
                {
                    k_ = t_ as CqlDateTime;
                }
                else
                {
                    bool v_ = t_ is CqlQuantity;
                    if (v_)
                    {
                        k_ = t_ as CqlQuantity;
                    }
                    else
                    {
                        bool w_ = t_ is CqlInterval<CqlDateTime>;
                        if (w_)
                        {
                            k_ = t_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool x_ = t_ is CqlInterval<CqlQuantity>;
                            if (x_)
                            {
                                k_ = t_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                Period n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(m_, o_, (string)default);

                CqlBoolean q_() {
                    object y_;
                    DataType aj_ = AirwayProcedure?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    if (al_)
                    {
                        y_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        bool am_ = ak_ is CqlQuantity;
                        if (am_)
                        {
                            y_ = ak_ as CqlQuantity;
                        }
                        else
                        {
                            bool an_ = ak_ is CqlInterval<CqlDateTime>;
                            if (an_)
                            {
                                y_ = ak_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ao_ = ak_ is CqlInterval<CqlQuantity>;
                                if (ao_)
                                {
                                    y_ = ak_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    y_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                    CqlDateTime aa_ = context.Operators.Start(z_);
                    Period ab_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                    CqlDateTime ad_ = context.Operators.Start(ac_);
                    CqlQuantity ae_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                    CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(af_, ad_, true, false);
                    CqlBoolean ah_ = context.Operators.In<CqlDateTime>(aa_, ag_, (string)default);

                    CqlBoolean ai_() {
                        Period ap_ = EDwithSTEMI?.Period;
                        CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                        CqlDateTime ar_ = context.Operators.Start(aq_);
                        return !((bool?)(ar_ is null));
                    }

                    return ah_
                        /* CQL 'and' (287:14-287:120) */ && ai_();
                }


                CqlBoolean r_() {
                    Code<EventStatus> as_ = AirwayProcedure?.StatusElement;
                    EventStatus? at_ = as_?.Value;
                    string au_ = context.Operators.Convert<string>(at_);
                    CqlBoolean av_ = context.Operators.Equal(au_, "completed");
                    return av_;
                }

                return p_
                    /* CQL 'or' (286:17-288:7) */ || q_()
                    /* CQL 'and' (286:17-289:48) */ && r_();
            }

            CqlBoolean j_ = context.Operators.WhereAny<Procedure>(h_, i_);
            return j_;
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
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime r_ = context.Operators.Start(q_);
                Period s_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlQuantity v_ = context.Operators.Quantity(90m, "days");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, u_, true, true);
                CqlBoolean y_ = context.Operators.In<CqlDateTime>(r_, x_, (string)default);
                return y_;
            }

            CqlBoolean p_ = context.Operators.WhereAny<Condition>(n_, o_);
            return p_;
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
                object h_;
                DataType t_ = CranialorSpinalSurgery?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    h_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlQuantity;
                    if (w_)
                    {
                        h_ = u_ as CqlQuantity;
                    }
                    else
                    {
                        bool x_ = u_ is CqlInterval<CqlDateTime>;
                        if (x_)
                        {
                            h_ = u_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool y_ = u_ is CqlInterval<CqlQuantity>;
                            if (y_)
                            {
                                h_ = u_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(90m, "days");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
                CqlBoolean q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);

                CqlBoolean r_() {
                    Period z_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    return !((bool?)(ab_ is null));
                }


                CqlBoolean s_() {
                    Code<EventStatus> ac_ = CranialorSpinalSurgery?.StatusElement;
                    EventStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    CqlBoolean af_ = context.Operators.Equal(ae_, "completed");
                    return af_;
                }

                return q_
                    /* CQL 'and' (279:17-279:125) */ && r_()
                    /* CQL 'and' (279:17-280:55) */ && s_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
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
            CqlBoolean h_ = context.Operators.ConceptInValueSet(f_, g_);
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
            CqlBoolean h_ = context.Operators.ConceptInValueSet(f_, g_);
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
                Encounter.HospitalizationComponent n_ = InpatientEncounter?.Hospitalization;
                CodeableConcept o_ = n_?.DischargeDisposition;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlCode q_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                CqlBoolean s_ = context.Operators.Equivalent(p_, r_);

                CqlBoolean t_() {
                    Encounter.HospitalizationComponent w_ = InpatientEncounter?.Hospitalization;
                    CodeableConcept x_ = w_?.DischargeDisposition;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlCode z_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                    CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                    CqlBoolean ab_ = context.Operators.Equivalent(y_, aa_);
                    return ab_;
                }


                CqlBoolean u_() {
                    Period ac_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.Start(ad_);
                    Period af_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlBoolean ai_ = context.Operators.SameOrBefore(ae_, ah_, (string)default);
                    return ai_;
                }


                CqlBoolean v_() {
                    Period aj_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                    Period al_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, al_);
                    CqlDateTime an_ = context.Operators.Start(am_);
                    CqlQuantity ao_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime ap_ = context.Operators.Subtract(an_, ao_);
                    CqlDateTime aq_ = context.Operators.End(am_);
                    CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(ap_, aq_, true, true);
                    CqlBoolean as_ = context.Operators.Overlaps(ak_, ar_, "day");
                    return as_;
                }

                return s_
                    /* CQL 'or' (205:17-207:11) */ || t_()
                    /* CQL 'and' (205:17-208:90) */ && u_()
                    /* CQL 'and' (205:11-209:85) */ && v_();
            }

            CqlBoolean h_ = context.Operators.WhereAny<Encounter>(f_, g_);

            CqlBoolean i_() {
                CqlValueSet at_ = this.Hospice_Encounter(context);
                IEnumerable<Encounter> au_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, at_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> av_ = Status_1_15_000.Instance.isEncounterPerformed(context, au_);

                bool? aw_(Encounter HospiceEncounter) {
                    Period ay_ = HospiceEncounter?.Period;
                    CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
                    CqlDateTime ba_ = context.Operators.Start(az_);
                    Period bb_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                    CqlDateTime bd_ = context.Operators.Start(bc_);
                    CqlBoolean be_ = context.Operators.SameOrBefore(ba_, bd_, (string)default);

                    CqlBoolean bf_() {
                        Period bg_ = HospiceEncounter?.Period;
                        CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                        Period bi_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                        CqlDateTime bk_ = context.Operators.Start(bj_);
                        CqlQuantity bl_ = context.Operators.Quantity(6m, "months");
                        CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                        CqlDateTime bn_ = context.Operators.End(bj_);
                        CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bm_, bn_, true, true);
                        CqlBoolean bp_ = context.Operators.Overlaps(bh_, bo_, "day");
                        return bp_;
                    }

                    return be_
                        /* CQL 'and' (212:13-213:89) */ && bf_();
                }

                CqlBoolean ax_ = context.Operators.WhereAny<Encounter>(av_, aw_);
                return ax_;
            }


            CqlBoolean j_() {
                CqlCode bq_ = this.Hospice_care__Minimum_Data_Set_(context);
                IEnumerable<CqlCode> br_ = context.Operators.ToList<CqlCode>(bq_);
                IEnumerable<Observation> bs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, br_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
                IEnumerable<Observation> bt_ = Status_1_15_000.Instance.isAssessmentPerformed(context, bs_);

                bool? bu_(Observation HospiceAssessment) {
                    DataType bw_ = (HospiceAssessment as Observation)?.Value;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    CqlCode by_ = this.Yes__qualifier_value_(context);
                    CqlConcept bz_ = context.Operators.ConvertCodeToConcept(by_);
                    CqlBoolean ca_ = context.Operators.Equivalent(bx_ as CqlConcept, bz_);

                    CqlBoolean cb_() {
                        DataType cd_ = HospiceAssessment?.Effective;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        CqlInterval<CqlDateTime> cf_ = QICoreCommon_4_0_000.Instance.toInterval(context, ce_);
                        CqlDateTime cg_ = context.Operators.Start(cf_);
                        Period ch_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ch_);
                        CqlDateTime cj_ = context.Operators.Start(ci_);
                        CqlBoolean ck_ = context.Operators.SameOrBefore(cg_, cj_, (string)default);
                        return ck_;
                    }


                    CqlBoolean cc_() {
                        DataType cl_ = HospiceAssessment?.Effective;
                        object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                        CqlInterval<CqlDateTime> cn_ = QICoreCommon_4_0_000.Instance.toInterval(context, cm_);
                        Period co_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                        CqlDateTime cq_ = context.Operators.Start(cp_);
                        CqlQuantity cr_ = context.Operators.Quantity(6m, "months");
                        CqlDateTime cs_ = context.Operators.Subtract(cq_, cr_);
                        CqlDateTime ct_ = context.Operators.End(cp_);
                        CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(cs_, ct_, true, true);
                        CqlBoolean cv_ = context.Operators.Overlaps(cn_, cu_, "day");
                        return cv_;
                    }

                    return ca_
                        /* CQL 'and' (216:19-217:109) */ && cb_()
                        /* CQL 'and' (216:13-218:108) */ && cc_();
                }

                CqlBoolean bv_ = context.Operators.WhereAny<Observation>(bt_, bu_);
                return bv_;
            }


            CqlBoolean k_() {
                CqlValueSet cw_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<ServiceRequest> cx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, cw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> cy_ = Status_1_15_000.Instance.isInterventionOrder(context, cx_);

                bool? cz_(ServiceRequest HospiceOrder) {
                    FhirDateTime db_ = HospiceOrder?.AuthoredOnElement;
                    CqlDateTime dc_ = context.Operators.Convert<CqlDateTime>(db_);
                    Period dd_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dd_);
                    CqlDateTime df_ = context.Operators.Start(de_);
                    CqlQuantity dg_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime dh_ = context.Operators.Subtract(df_, dg_);
                    CqlInterval<CqlDateTime> di_ = context.Operators.Interval(dh_, df_, true, false);
                    CqlBoolean dj_ = context.Operators.In<CqlDateTime>(dc_, di_, (string)default);

                    CqlBoolean dk_() {
                        Period dl_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dl_);
                        CqlDateTime dn_ = context.Operators.Start(dm_);
                        return !((bool?)(dn_ is null));
                    }

                    return dj_
                        /* CQL 'and' (221:13-221:94) */ && dk_();
                }

                CqlBoolean da_ = context.Operators.WhereAny<ServiceRequest>(cy_, cz_);
                return da_;
            }


            CqlBoolean l_() {
                CqlValueSet do_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<Procedure> dp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, do_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> dq_ = Status_1_15_000.Instance.isInterventionPerformed(context, dp_);

                bool? dr_(Procedure HospicePerformed) {
                    object dt_;
                    DataType eb_ = HospicePerformed?.Performed;
                    object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                    bool ed_ = ec_ is CqlDateTime;
                    if (ed_)
                    {
                        dt_ = ec_ as CqlDateTime;
                    }
                    else
                    {
                        bool ee_ = ec_ is CqlQuantity;
                        if (ee_)
                        {
                            dt_ = ec_ as CqlQuantity;
                        }
                        else
                        {
                            bool ef_ = ec_ is CqlInterval<CqlDateTime>;
                            if (ef_)
                            {
                                dt_ = ec_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool eg_ = ec_ is CqlInterval<CqlQuantity>;
                                if (eg_)
                                {
                                    dt_ = ec_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    dt_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> du_ = QICoreCommon_4_0_000.Instance.toInterval(context, dt_);
                    CqlDateTime dv_ = context.Operators.Start(du_);
                    Period dw_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> dx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dw_);
                    CqlDateTime dy_ = context.Operators.Start(dx_);
                    CqlBoolean dz_ = context.Operators.SameOrBefore(dv_, dy_, (string)default);

                    CqlBoolean ea_() {
                        object eh_;
                        DataType er_ = HospicePerformed?.Performed;
                        object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                        bool et_ = es_ is CqlDateTime;
                        if (et_)
                        {
                            eh_ = es_ as CqlDateTime;
                        }
                        else
                        {
                            bool eu_ = es_ is CqlQuantity;
                            if (eu_)
                            {
                                eh_ = es_ as CqlQuantity;
                            }
                            else
                            {
                                bool ev_ = es_ is CqlInterval<CqlDateTime>;
                                if (ev_)
                                {
                                    eh_ = es_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool ew_ = es_ is CqlInterval<CqlQuantity>;
                                    if (ew_)
                                    {
                                        eh_ = es_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        eh_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> ei_ = QICoreCommon_4_0_000.Instance.toInterval(context, eh_);
                        Period ej_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                        CqlDateTime el_ = context.Operators.Start(ek_);
                        CqlQuantity em_ = context.Operators.Quantity(6m, "months");
                        CqlDateTime en_ = context.Operators.Subtract(el_, em_);
                        CqlDateTime eo_ = context.Operators.End(ek_);
                        CqlInterval<CqlDateTime> ep_ = context.Operators.Interval(en_, eo_, true, true);
                        CqlBoolean eq_ = context.Operators.Overlaps(ei_, ep_, "day");
                        return eq_;
                    }

                    return dz_
                        /* CQL 'and' (224:13-225:107) */ && ea_();
                }

                CqlBoolean ds_ = context.Operators.WhereAny<Procedure>(dq_, dr_);
                return ds_;
            }


            CqlBoolean m_() {
                CqlValueSet ex_ = this.Hospice_Diagnosis(context);
                IEnumerable<Condition> ey_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ex_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                Condition ez_(Condition X) => X as Condition;
                IEnumerable<Condition> fa_ = context.Operators.Select<Condition, Condition>(ey_, ez_);
                IEnumerable<Condition> fb_ = Status_1_15_000.Instance.verified(context, fa_);

                bool? fc_(Condition HospiceCareDiagnosis) {
                    CqlInterval<CqlDateTime> fe_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                    CqlDateTime ff_ = context.Operators.End(fe_);
                    Period fg_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> fh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fg_);
                    CqlDateTime fi_ = context.Operators.Start(fh_);
                    CqlBoolean fj_ = context.Operators.SameOrAfter(ff_, fi_, (string)default);
                    return fj_;
                }

                CqlBoolean fd_ = context.Operators.WhereAny<Condition>(fb_, fc_);
                return fd_;
            }

            return h_
                /* CQL 'or' (204:13-214:9) */ || i_()
                /* CQL 'or' (204:13-219:9) */ || j_()
                /* CQL 'or' (204:13-222:9) */ || k_()
                /* CQL 'or' (204:13-226:9) */ || l_()
                /* CQL 'or' (204:5-230:5) */ || m_();
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
                Code<ObservationStatus> g_ = PregStatus?.StatusElement;
                ObservationStatus? h_ = g_?.Value;
                Code<ObservationStatus> i_ = context.Operators.Convert<Code<ObservationStatus>>(h_);
                CqlBoolean j_ = context.Operators.Equal(i_, "final");

                CqlBoolean k_() {
                    DataType m_ = PregStatus?.Value;
                    CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_ as CodeableConcept);
                    CqlValueSet o_ = this.Pregnant_State(context);
                    CqlBoolean p_ = context.Operators.ConceptInValueSet(n_, o_);
                    return p_;
                }


                CqlBoolean l_() {
                    DataType q_ = PregStatus?.Effective;
                    CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
                    Period s_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                    CqlBoolean u_ = context.Operators.In<CqlDateTime>(r_, t_, (string)default);
                    return u_;
                }

                return j_
                    /* CQL 'and' (118:17-119:52) */ && k_()
                    /* CQL 'and' (118:17-120:59) */ && l_();
            }

            CqlBoolean f_ = context.Operators.WhereAny<Observation>(d_, e_);
            return f_;
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
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime m_ = context.Operators.Start(l_);
                Period n_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(m_, o_, (string)default);
                return p_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Condition>(i_, j_);
            return k_;
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
                CodeableConcept i_ = PCINotDone?.StatusReason;
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, i_);
                CqlValueSet k_ = this.Patient_Refusal(context);
                CqlBoolean l_ = context.Operators.ConceptInValueSet(j_, k_);

                CqlBoolean m_() {
                    CodeableConcept o_ = PCINotDone?.StatusReason;
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                    CqlValueSet q_ = this.Procedure_Not_Indicated_Contraindicated(context);
                    CqlBoolean r_ = context.Operators.ConceptInValueSet(p_, q_);
                    return r_;
                }


                CqlBoolean n_() {

                    bool? s_(Extension @this) {
                        FhirUri ab_ = @this?.UrlElement;
                        string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                        CqlBoolean ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                        return ad_;
                    }


                    DataType t_(Extension @this) {
                        DataType ae_ = @this?.Value;
                        return ae_;
                    }

                    IEnumerable<DataType> u_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(PCINotDone is DomainResource
                        ? (PCINotDone as DomainResource).Extension
                        : default), s_, t_);
                    DataType v_ = context.Operators.SingletonFrom<DataType>(u_);
                    FhirDateTime w_ = context.Operators.Convert<FhirDateTime>(v_);
                    CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
                    Period y_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                    CqlBoolean aa_ = context.Operators.In<CqlDateTime>(x_, z_, (string)default);
                    return aa_;
                }

                return l_
                    /* CQL 'or' (257:17-259:7) */ || m_()
                    /* CQL 'and' (257:17-260:54) */ && n_();
            }

            CqlBoolean h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
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
                List<CodeableConcept> i_ = FibrinolyticNoMed?.StatusReason;

                CqlConcept j_(CodeableConcept @this) {
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return p_;
                }

                IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                CqlValueSet l_ = this.Patient_Refusal(context);
                CqlBoolean m_ = context.Operators.ConceptsInValueSet(k_, l_);

                CqlBoolean n_() {
                    List<CodeableConcept> q_ = FibrinolyticNoMed?.StatusReason;

                    CqlConcept r_(CodeableConcept @this) {
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return v_;
                    }

                    IEnumerable<CqlConcept> s_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)q_, r_);
                    CqlValueSet t_ = this.Drug_Intervention_Not_Indicated_Contraindicated(context);
                    CqlBoolean u_ = context.Operators.ConceptsInValueSet(s_, t_);
                    return u_;
                }


                CqlBoolean o_() {

                    bool? w_(Extension @this) {
                        FhirUri af_ = @this?.UrlElement;
                        string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                        CqlBoolean ah_ = context.Operators.Equal(ag_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                        return ah_;
                    }


                    DataType x_(Extension @this) {
                        DataType ai_ = @this?.Value;
                        return ai_;
                    }

                    IEnumerable<DataType> y_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(FibrinolyticNoMed is DomainResource
                        ? (FibrinolyticNoMed as DomainResource).Extension
                        : default), w_, x_);
                    DataType z_ = context.Operators.SingletonFrom<DataType>(y_);
                    FhirDateTime aa_ = context.Operators.Convert<FhirDateTime>(z_);
                    CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
                    Period ac_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlBoolean ae_ = context.Operators.In<CqlDateTime>(ab_, ad_, (string)default);
                    return ae_;
                }

                return m_
                    /* CQL 'or' (265:17-267:7) */ || n_()
                    /* CQL 'and' (265:17-268:61) */ && o_();
            }

            CqlBoolean h_ = context.Operators.WhereAny<MedicationAdministration>(f_, g_);
            return h_;
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
            ResourceReference h_ = EDLocation?.Location;
            Location i_ = CQMCommon_4_1_000.Instance.getLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;

            CqlConcept k_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }


            bool? l_(CqlConcept LocationType) {
                CqlValueSet p_ = this.Emergency_Department_Visit(context);
                CqlBoolean q_ = context.Operators.ConceptInValueSet(LocationType, p_);

                CqlBoolean r_() {
                    CqlCode u_ = this.Emergency_room(context);
                    CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                    CqlBoolean w_ = context.Operators.Equivalent(LocationType, v_);
                    return w_;
                }


                CqlBoolean s_() {
                    CqlCode x_ = this.Emergency_trauma_unit(context);
                    CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                    CqlBoolean z_ = context.Operators.Equivalent(LocationType, y_);
                    return z_;
                }


                CqlBoolean t_() {
                    Period aa_ = EDLocation?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    return !((bool?)(ac_ is null));
                }

                return q_
                    /* CQL 'or' (320:17-321:48) */ || r_()
                    /* CQL 'or' (320:16-323:11) */ || s_()
                    /* CQL 'and' (320:11-324:54) */ && t_();
            }

            IEnumerable<CqlConcept> m_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_, l_);
            CqlBoolean n_ = context.Operators.Exists<CqlConcept>(m_);
            return n_;
        }


        CqlDateTime c_(Encounter.LocationComponent EDLocation) {
            Period ad_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);
            return af_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>((IEnumerable<Encounter.LocationComponent>)a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.First<CqlDateTime>(f_);
        return g_;
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
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    CqlBoolean s_ = context.Operators.Equal(o_, r_);

                    CqlBoolean t_() {
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Fibrinolytic_Therapy(context);
                        CqlBoolean x_ = context.Operators.ConceptInValueSet(v_, w_);
                        return x_;
                    }

                    return s_
                        /* CQL 'and' */ && t_();
                }

                CqlBoolean n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration Fibrinolytic) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> y_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                CqlBoolean ab_ = context.Operators.Equal(aa_, "completed");

                CqlBoolean ac_() {
                    DataType ad_ = Fibrinolytic?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
                    CqlDateTime ag_ = context.Operators.Start(af_);
                    CqlDateTime ah_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                    CqlQuantity ai_ = context.Operators.Quantity(30m, "minutes");
                    CqlDateTime aj_ = context.Operators.Add(ah_, ai_);
                    CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ah_, aj_, false, true);
                    CqlBoolean al_ = context.Operators.In<CqlDateTime>(ag_, ak_, (string)default);
                    return al_
                        /* CQL 'and' (274:13-274:141) */ && !((bool?)((this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI)) is null));
                }

                return ab_
                    /* CQL 'and' (273:17-274:141) */ && ac_();
            }

            CqlBoolean k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
            return k_;
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
                object h_;
                DataType q_ = PCI?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    h_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlQuantity;
                    if (t_)
                    {
                        h_ = r_ as CqlQuantity;
                    }
                    else
                    {
                        bool u_ = r_ is CqlInterval<CqlDateTime>;
                        if (u_)
                        {
                            h_ = r_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool v_ = r_ is CqlInterval<CqlQuantity>;
                            if (v_)
                            {
                                h_ = r_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                h_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlDateTime k_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity l_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime m_ = context.Operators.Add(k_, l_);
                CqlInterval<CqlDateTime> n_ = context.Operators.Interval(k_, m_, false, true);
                CqlBoolean o_ = context.Operators.In<CqlDateTime>(j_, n_, (string)default);

                CqlBoolean p_() {
                    Code<EventStatus> w_ = PCI?.StatusElement;
                    EventStatus? x_ = w_?.Value;
                    string y_ = context.Operators.Convert<string>(x_);
                    CqlBoolean z_ = context.Operators.Equal(y_, "completed");
                    return z_;
                }

                return o_
                    /* CQL 'and' (302:17-302:130) */ && !((bool?)((this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI)) is null))
                    /* CQL 'and' (302:17-303:36) */ && p_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("currentemergencyDepartmentDepartTime")]
    public CqlDateTime currentemergencyDepartmentDepartTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> a_ = EDEncounter?.Location;

        bool? b_(Encounter.LocationComponent EDLocation) {
            ResourceReference h_ = EDLocation?.Location;
            Location i_ = CQMCommon_4_1_000.Instance.getLocation(context, h_);
            List<CodeableConcept> j_ = i_?.Type;

            CqlConcept k_(CodeableConcept @this) {
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }


            bool? l_(CqlConcept LocationType) {
                CqlValueSet p_ = this.Emergency_Department_Visit(context);
                CqlBoolean q_ = context.Operators.ConceptInValueSet(LocationType, p_);

                CqlBoolean r_() {
                    CqlCode u_ = this.Emergency_room(context);
                    CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                    CqlBoolean w_ = context.Operators.Equivalent(LocationType, v_);
                    return w_;
                }


                CqlBoolean s_() {
                    CqlCode x_ = this.Emergency_trauma_unit(context);
                    CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                    CqlBoolean z_ = context.Operators.Equivalent(LocationType, y_);
                    return z_;
                }


                CqlBoolean t_() {
                    Period aa_ = EDLocation?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.End(ab_);
                    return !((bool?)(ac_ is null));
                }

                return q_
                    /* CQL 'or' (333:17-334:48) */ || r_()
                    /* CQL 'or' (333:16-336:11) */ || s_()
                    /* CQL 'and' (333:11-338:48) */ && t_();
            }

            IEnumerable<CqlConcept> m_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_, l_);
            CqlBoolean n_ = context.Operators.Exists<CqlConcept>(m_);
            return n_;
        }


        CqlDateTime c_(Encounter.LocationComponent EDLocation) {
            Period ad_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
            CqlDateTime af_ = context.Operators.End(ae_);
            return af_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<Encounter.LocationComponent, CqlDateTime>((IEnumerable<Encounter.LocationComponent>)a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.ListSort<CqlDateTime>(e_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime g_ = context.Operators.Last<CqlDateTime>(f_);
        return g_;
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
            CqlBoolean i_ = context.Operators.In<CqlDateTime>(d_, h_, (string)default);

            CqlBoolean j_() {
                Encounter.HospitalizationComponent k_ = EDwithSTEMI?.Hospitalization;
                CodeableConcept l_ = k_?.DischargeDisposition;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlValueSet n_ = this.Discharge_To_Acute_Care_Facility(context);
                CqlBoolean o_ = context.Operators.ConceptInValueSet(m_, n_);
                return o_;
            }

            return i_
                /* CQL 'and' (170:11-170:141) */ && !((bool?)((this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI)) is null))
                /* CQL 'and' (170:5-171:96) */ && j_();
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
