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
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return n_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet j_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            bool? l_;
            // CQL 'and' (175:11-176:68): right operand skipped when left is false
            if (k_ is false)
            {
                l_ = false;
            }
            else
            {
                Period o_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.End(p_);
                CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
                l_ = k_ & s_;
            }
            bool? m_;
            // CQL 'and' (175:11-177:41): right operand skipped when left is false
            if (l_ is false)
            {
                m_ = false;
            }
            else
            {
                Code<Encounter.EncounterStatus> t_ = EDEncounter?.StatusElement;
                Encounter.EncounterStatus? u_ = t_?.Value;
                Code<Encounter.EncounterStatus> v_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(u_);
                bool? w_ = context.Operators.Equal(v_, "finished");
                m_ = l_ & w_;
            }
            // CQL 'and' (175:5-178:68): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                Patient x_ = this.Patient(context);
                Date y_ = x_?.BirthDateElement;
                string z_ = y_?.Value;
                CqlDate aa_ = context.Operators.ConvertStringToDate(z_);
                Period ab_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlDate ae_ = context.Operators.DateFrom(ad_);
                int? af_ = context.Operators.CalculateAgeAt(aa_, ae_, "year");
                bool? ag_ = context.Operators.GreaterOrEqual(af_, 18);
                return m_ & ag_;
            }
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
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.STEMI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (182:5-190:5): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet j_ = this.STEMI(context);
                IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<Condition> m_ = context.Operators.Union<Condition>(k_ as IEnumerable<Condition>, l_ as IEnumerable<Condition>);
                IEnumerable<Condition> n_ = Status_1_15_000.Instance.verified(context, m_);

                bool? o_(Condition DxSTEMI) {
                    IEnumerable<Condition> q_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EDEncounterinMP);

                    bool? r_(Condition @this) {
                        CodeableConcept w_ = @this?.Code;
                        CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                        return !((bool?)(x_ is null));
                    }


                    CqlConcept s_(Condition @this) {
                        CodeableConcept y_ = @this?.Code;
                        CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                        return z_;
                    }

                    IEnumerable<CqlConcept> t_ = context.Operators.WhereSelect<Condition, CqlConcept>(q_, r_, s_);
                    CqlValueSet u_ = this.STEMI(context);
                    bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
                    // CQL 'or' (186:13-188:13): right operand skipped when left is true
                    if (v_ is true)
                    {
                        return true;
                    }
                    else
                    {
                        CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DxSTEMI);
                        CqlDateTime ab_ = context.Operators.Start(aa_);
                        Period ac_ = EDEncounterinMP?.Period;
                        CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                        bool? ae_ = context.Operators.In<CqlDateTime>(ab_, ad_, (string)default);
                        return v_ | ae_;
                    }
                }

                bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
                return h_ | p_;
            }
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
                bool? l_ = context.Operators.Equivalent(i_, k_);
                bool? m_;
                // CQL 'and' (159:17-163:9): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    CodeableConcept n_ = ThrombolyticAllergy?.VerificationStatus;
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                    CqlCode p_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                    CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                    bool? r_ = context.Operators.Equivalent(o_, q_);
                    bool? s_;
                    // CQL 'or' (160:74-162:11): right operand skipped when left is true
                    if (r_ is true)
                    {
                        s_ = true;
                    }
                    else
                    {
                        CodeableConcept u_ = ThrombolyticAllergy?.VerificationStatus;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlCode w_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
                        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                        bool? y_ = context.Operators.Equivalent(v_, x_);
                        s_ = r_ | y_;
                    }
                    bool? t_ = context.Operators.Implies(!((bool?)(o_ is null)), s_);
                    m_ = l_ & t_;
                }
                // CQL 'and' (159:17-166:9): right operand skipped when left is false
                if (m_ is false)
                {
                    return false;
                }
                else
                {
                    DataType z_ = ThrombolyticAllergy?.Onset;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                    Period ac_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    bool? ae_ = context.Operators.Overlaps(ab_, ad_, (string)default);
                    bool? af_;
                    // CQL 'or' (164:13-166:9): right operand skipped when left is true
                    if (ae_ is true)
                    {
                        af_ = true;
                    }
                    else
                    {
                        DataType ag_ = ThrombolyticAllergy?.Onset;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        Period ai_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                        CqlDateTime ak_ = context.Operators.End(aj_);
                        bool? al_ = context.Operators.Before(ah_ as CqlDateTime, ak_, (string)default);
                        af_ = ae_ | al_;
                    }
                    return m_ & af_;
                }
            }

            bool? g_ = context.Operators.WhereAny<AllergyIntolerance>(e_, f_);
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
                bool? q_ = context.Operators.Before((i_ ?? k_) ?? m_, p_, (string)default);
                // CQL 'and' (153:17-154:57): right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    Code<AdverseEvent.AdverseEventActuality> r_ = ThrombolyticAdverseEvent?.ActualityElement;
                    AdverseEvent.AdverseEventActuality? s_ = r_?.Value;
                    Code<AdverseEvent.AdverseEventActuality> t_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(s_);
                    bool? u_ = context.Operators.Equal(t_, "actual");
                    return q_ & u_;
                }
            }

            bool? g_ = context.Operators.WhereAny<AdverseEvent>(e_, f_);
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
                bool? ac_ = context.Operators.OverlapsBefore(z_, ab_, (string)default);
                return ac_;
            }

            bool? y_ = context.Operators.WhereAny<Condition>(w_, x_);
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
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Oral_Anticoagulant_Medications(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest OralAnticoagulant) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (133:17-134:46): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> ad_ = OralAnticoagulant?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    bool? ag_ = context.Operators.Equal(af_, "order");
                    ac_ = ab_ & ag_;
                }
                // CQL 'and' (133:17-135:97): right operand skipped when left is false
                if (ac_ is false)
                {
                    return false;
                }
                else
                {
                    FhirDateTime ah_ = OralAnticoagulant?.AuthoredOnElement;
                    CqlDateTime ai_ = context.Operators.Convert<CqlDateTime>(ah_);
                    Period aj_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                    CqlDateTime al_ = context.Operators.Start(ak_);
                    CqlQuantity am_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime an_ = context.Operators.Subtract(al_, am_);
                    CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(an_, al_, true, true);
                    bool? ap_ = context.Operators.In<CqlDateTime>(ai_, ao_, (string)default);
                    bool? aq_;
                    // CQL 'and' (135:13-135:97): right operand skipped when left is false
                    if (ap_ is false)
                    {
                        aq_ = false;
                    }
                    else
                    {
                        Period ar_ = EDwithSTEMI?.Period;
                        CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                        CqlDateTime at_ = context.Operators.Start(as_);
                        aq_ = ap_ & (!((bool?)(at_ is null)));
                    }
                    return ac_ & aq_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
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
                bool? q_ = context.Operators.SameOrBefore(m_, p_, (string)default);
                // CQL 'and' (142:17-144:7): right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LongTermAnticoagulant);
                    CqlDateTime s_ = context.Operators.End(r_);
                    Period t_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                    CqlDateTime v_ = context.Operators.Start(u_);
                    bool? w_ = context.Operators.SameOrAfter(s_, v_, (string)default);
                    return q_ & w_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
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
                bool? ao_ = context.Operators.In<CqlDateTime>(al_, an_, (string)default);
                // CQL 'or' (243:17-245:7): right operand skipped when left is true
                if (ao_ is true)
                {
                    return true;
                }
                else
                {
                    CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                    CqlDateTime aq_ = context.Operators.Start(ap_);
                    Period ar_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime at_ = context.Operators.Start(as_);
                    CqlQuantity au_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime av_ = context.Operators.Subtract(at_, au_);
                    CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(av_, at_, true, false);
                    bool? ax_ = context.Operators.In<CqlDateTime>(aq_, aw_, (string)default);
                    bool? ay_;
                    // CQL 'and' (244:14-244:117): right operand skipped when left is false
                    if (ax_ is false)
                    {
                        ay_ = false;
                    }
                    else
                    {
                        Period az_ = EDwithSTEMI?.Period;
                        CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, az_);
                        CqlDateTime bb_ = context.Operators.Start(ba_);
                        ay_ = ax_ & (!((bool?)(bb_ is null)));
                    }
                    return ao_ | ay_;
                }
            }

            bool? aj_ = context.Operators.WhereAny<Condition>(ah_, ai_);
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
                DataType t_ = MajorSurgery?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    DataType w_ = MajorSurgery?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    h_ = x_ as CqlDateTime;
                }
                else
                {
                    DataType y_ = MajorSurgery?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlQuantity;
                    if (aa_)
                    {
                        DataType ab_ = MajorSurgery?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        h_ = ac_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ad_ = MajorSurgery?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlDateTime>;
                        if (af_)
                        {
                            DataType ag_ = MajorSurgery?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            h_ = ah_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ai_ = MajorSurgery?.Performed;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                            if (ak_)
                            {
                                DataType al_ = MajorSurgery?.Performed;
                                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                                h_ = am_ as CqlInterval<CqlQuantity>;
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
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);
                bool? r_;
                // CQL 'and' (294:19-294:113): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    Period an_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                    CqlDateTime ap_ = context.Operators.Start(ao_);
                    r_ = q_ & (!((bool?)(ap_ is null)));
                }
                bool? s_;
                // CQL 'or' (294:17-296:7): right operand skipped when left is true
                if (r_ is true)
                {
                    s_ = true;
                }
                else
                {
                    object aq_;
                    DataType aw_ = MajorSurgery?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    if (ay_)
                    {
                        DataType az_ = MajorSurgery?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        aq_ = ba_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bb_ = MajorSurgery?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlQuantity;
                        if (bd_)
                        {
                            DataType be_ = MajorSurgery?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            aq_ = bf_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bg_ = MajorSurgery?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                            if (bi_)
                            {
                                DataType bj_ = MajorSurgery?.Performed;
                                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                                aq_ = bk_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType bl_ = MajorSurgery?.Performed;
                                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                                bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                                if (bn_)
                                {
                                    DataType bo_ = MajorSurgery?.Performed;
                                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                    aq_ = bp_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    aq_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                    CqlDateTime as_ = context.Operators.Start(ar_);
                    Period at_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                    bool? av_ = context.Operators.In<CqlDateTime>(as_, au_, (string)default);
                    s_ = r_ | av_;
                }
                // CQL 'and' (294:17-297:45): right operand skipped when left is false
                if (s_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> bq_ = MajorSurgery?.StatusElement;
                    EventStatus? br_ = bq_?.Value;
                    string bs_ = context.Operators.Convert<string>(br_);
                    bool? bt_ = context.Operators.Equal(bs_, "completed");
                    return s_ & bt_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
                DataType r_ = AirwayProcedure?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    DataType u_ = AirwayProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    k_ = v_ as CqlDateTime;
                }
                else
                {
                    DataType w_ = AirwayProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlQuantity;
                    if (y_)
                    {
                        DataType z_ = AirwayProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        k_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ab_ = AirwayProcedure?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            DataType ae_ = AirwayProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            k_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ag_ = AirwayProcedure?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                DataType aj_ = AirwayProcedure?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                k_ = ak_ as CqlInterval<CqlQuantity>;
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
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, (string)default);
                bool? q_;
                // CQL 'or' (286:17-288:7): right operand skipped when left is true
                if (p_ is true)
                {
                    q_ = true;
                }
                else
                {
                    object al_;
                    DataType aw_ = AirwayProcedure?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    if (ay_)
                    {
                        DataType az_ = AirwayProcedure?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        al_ = ba_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bb_ = AirwayProcedure?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlQuantity;
                        if (bd_)
                        {
                            DataType be_ = AirwayProcedure?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            al_ = bf_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bg_ = AirwayProcedure?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                            if (bi_)
                            {
                                DataType bj_ = AirwayProcedure?.Performed;
                                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                                al_ = bk_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType bl_ = AirwayProcedure?.Performed;
                                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                                bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                                if (bn_)
                                {
                                    DataType bo_ = AirwayProcedure?.Performed;
                                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                    al_ = bp_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    al_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                    CqlDateTime an_ = context.Operators.Start(am_);
                    Period ao_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                    CqlDateTime aq_ = context.Operators.Start(ap_);
                    CqlQuantity ar_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
                    CqlInterval<CqlDateTime> at_ = context.Operators.Interval(as_, aq_, true, false);
                    bool? au_ = context.Operators.In<CqlDateTime>(an_, at_, (string)default);
                    bool? av_;
                    // CQL 'and' (287:14-287:120): right operand skipped when left is false
                    if (au_ is false)
                    {
                        av_ = false;
                    }
                    else
                    {
                        Period bq_ = EDwithSTEMI?.Period;
                        CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bq_);
                        CqlDateTime bs_ = context.Operators.Start(br_);
                        av_ = au_ & (!((bool?)(bs_ is null)));
                    }
                    q_ = p_ | av_;
                }
                // CQL 'and' (286:17-289:48): right operand skipped when left is false
                if (q_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> bt_ = AirwayProcedure?.StatusElement;
                    EventStatus? bu_ = bt_?.Value;
                    string bv_ = context.Operators.Convert<string>(bu_);
                    bool? bw_ = context.Operators.Equal(bv_, "completed");
                    return q_ & bw_;
                }
            }

            bool? j_ = context.Operators.WhereAny<Procedure>(h_, i_);
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
                bool? y_ = context.Operators.In<CqlDateTime>(r_, x_, (string)default);
                return y_;
            }

            bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
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
                DataType s_ = CranialorSpinalSurgery?.Performed;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlDateTime;
                if (u_)
                {
                    DataType v_ = CranialorSpinalSurgery?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    h_ = w_ as CqlDateTime;
                }
                else
                {
                    DataType x_ = CranialorSpinalSurgery?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlQuantity;
                    if (z_)
                    {
                        DataType aa_ = CranialorSpinalSurgery?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        h_ = ab_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ac_ = CranialorSpinalSurgery?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            DataType af_ = CranialorSpinalSurgery?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            h_ = ag_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ah_ = CranialorSpinalSurgery?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                            if (aj_)
                            {
                                DataType ak_ = CranialorSpinalSurgery?.Performed;
                                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                                h_ = al_ as CqlInterval<CqlQuantity>;
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
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);
                bool? r_;
                // CQL 'and' (279:17-279:125): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    Period am_ = EDwithSTEMI?.Period;
                    CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, am_);
                    CqlDateTime ao_ = context.Operators.Start(an_);
                    r_ = q_ & (!((bool?)(ao_ is null)));
                }
                // CQL 'and' (279:17-280:55): right operand skipped when left is false
                if (r_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> ap_ = CranialorSpinalSurgery?.StatusElement;
                    EventStatus? aq_ = ap_?.Value;
                    string ar_ = context.Operators.Convert<string>(aq_);
                    bool? as_ = context.Operators.Equal(ar_, "completed");
                    return r_ & as_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
                Encounter.HospitalizationComponent m_ = InpatientEncounter?.Hospitalization;
                CodeableConcept n_ = m_?.DischargeDisposition;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                CqlCode p_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_;
                // CQL 'or' (205:17-207:11): right operand skipped when left is true
                if (r_ is true)
                {
                    s_ = true;
                }
                else
                {
                    Encounter.HospitalizationComponent u_ = InpatientEncounter?.Hospitalization;
                    CodeableConcept v_ = u_?.DischargeDisposition;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlCode x_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                    CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                    bool? z_ = context.Operators.Equivalent(w_, y_);
                    s_ = r_ | z_;
                }
                bool? t_;
                // CQL 'and' (205:17-208:90): right operand skipped when left is false
                if (s_ is false)
                {
                    t_ = false;
                }
                else
                {
                    Period aa_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    Period ad_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    bool? ag_ = context.Operators.SameOrBefore(ac_, af_, (string)default);
                    t_ = s_ & ag_;
                }
                // CQL 'and' (205:11-209:85): right operand skipped when left is false
                if (t_ is false)
                {
                    return false;
                }
                else
                {
                    Period ah_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                    Period aj_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                    CqlDateTime al_ = context.Operators.Start(ak_);
                    CqlQuantity am_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime an_ = context.Operators.Subtract(al_, am_);
                    CqlDateTime ao_ = context.Operators.End(ak_);
                    CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(an_, ao_, true, true);
                    bool? aq_ = context.Operators.Overlaps(ai_, ap_, "day");
                    return t_ & aq_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            bool? i_;
            // CQL 'or' (204:13-214:9): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CqlValueSet ar_ = this.Hospice_Encounter(context);
                IEnumerable<Encounter> as_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> at_ = Status_1_15_000.Instance.isEncounterPerformed(context, as_);

                bool? au_(Encounter HospiceEncounter) {
                    Period aw_ = HospiceEncounter?.Period;
                    CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aw_);
                    CqlDateTime ay_ = context.Operators.Start(ax_);
                    Period az_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, az_);
                    CqlDateTime bb_ = context.Operators.Start(ba_);
                    bool? bc_ = context.Operators.SameOrBefore(ay_, bb_, (string)default);
                    // CQL 'and' (212:13-213:89): right operand skipped when left is false
                    if (bc_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period bd_ = HospiceEncounter?.Period;
                        CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
                        Period bf_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                        CqlDateTime bh_ = context.Operators.Start(bg_);
                        CqlQuantity bi_ = context.Operators.Quantity(6m, "months");
                        CqlDateTime bj_ = context.Operators.Subtract(bh_, bi_);
                        CqlDateTime bk_ = context.Operators.End(bg_);
                        CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bj_, bk_, true, true);
                        bool? bm_ = context.Operators.Overlaps(be_, bl_, "day");
                        return bc_ & bm_;
                    }
                }

                bool? av_ = context.Operators.WhereAny<Encounter>(at_, au_);
                i_ = h_ | av_;
            }
            bool? j_;
            // CQL 'or' (204:13-219:9): right operand skipped when left is true
            if (i_ is true)
            {
                j_ = true;
            }
            else
            {
                CqlCode bn_ = this.Hospice_care__Minimum_Data_Set_(context);
                IEnumerable<CqlCode> bo_ = context.Operators.ToList<CqlCode>(bn_);
                IEnumerable<Observation> bp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
                IEnumerable<Observation> bq_ = Status_1_15_000.Instance.isAssessmentPerformed(context, bp_);

                bool? br_(Observation HospiceAssessment) {
                    DataType bt_ = (HospiceAssessment as Observation)?.Value;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    CqlCode bv_ = this.Yes__qualifier_value_(context);
                    CqlConcept bw_ = context.Operators.ConvertCodeToConcept(bv_);
                    bool? bx_ = context.Operators.Equivalent(bu_ as CqlConcept, bw_);
                    bool? by_;
                    // CQL 'and' (216:19-217:109): right operand skipped when left is false
                    if (bx_ is false)
                    {
                        by_ = false;
                    }
                    else
                    {
                        DataType bz_ = HospiceAssessment?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                        CqlDateTime cc_ = context.Operators.Start(cb_);
                        Period cd_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                        CqlDateTime cf_ = context.Operators.Start(ce_);
                        bool? cg_ = context.Operators.SameOrBefore(cc_, cf_, (string)default);
                        by_ = bx_ & cg_;
                    }
                    // CQL 'and' (216:13-218:108): right operand skipped when left is false
                    if (by_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        DataType ch_ = HospiceAssessment?.Effective;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                        Period ck_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                        CqlDateTime cm_ = context.Operators.Start(cl_);
                        CqlQuantity cn_ = context.Operators.Quantity(6m, "months");
                        CqlDateTime co_ = context.Operators.Subtract(cm_, cn_);
                        CqlDateTime cp_ = context.Operators.End(cl_);
                        CqlInterval<CqlDateTime> cq_ = context.Operators.Interval(co_, cp_, true, true);
                        bool? cr_ = context.Operators.Overlaps(cj_, cq_, "day");
                        return by_ & cr_;
                    }
                }

                bool? bs_ = context.Operators.WhereAny<Observation>(bq_, br_);
                j_ = i_ | bs_;
            }
            bool? k_;
            // CQL 'or' (204:13-222:9): right operand skipped when left is true
            if (j_ is true)
            {
                k_ = true;
            }
            else
            {
                CqlValueSet cs_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<ServiceRequest> ct_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, cs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
                IEnumerable<ServiceRequest> cu_ = Status_1_15_000.Instance.isInterventionOrder(context, ct_);

                bool? cv_(ServiceRequest HospiceOrder) {
                    FhirDateTime cx_ = HospiceOrder?.AuthoredOnElement;
                    CqlDateTime cy_ = context.Operators.Convert<CqlDateTime>(cx_);
                    Period cz_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cz_);
                    CqlDateTime db_ = context.Operators.Start(da_);
                    CqlQuantity dc_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime dd_ = context.Operators.Subtract(db_, dc_);
                    CqlInterval<CqlDateTime> de_ = context.Operators.Interval(dd_, db_, true, false);
                    bool? df_ = context.Operators.In<CqlDateTime>(cy_, de_, (string)default);
                    // CQL 'and' (221:13-221:94): right operand skipped when left is false
                    if (df_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period dg_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                        CqlDateTime di_ = context.Operators.Start(dh_);
                        return df_ & (!((bool?)(di_ is null)));
                    }
                }

                bool? cw_ = context.Operators.WhereAny<ServiceRequest>(cu_, cv_);
                k_ = j_ | cw_;
            }
            bool? l_;
            // CQL 'or' (204:13-226:9): right operand skipped when left is true
            if (k_ is true)
            {
                l_ = true;
            }
            else
            {
                CqlValueSet dj_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<Procedure> dk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> dl_ = Status_1_15_000.Instance.isInterventionPerformed(context, dk_);

                bool? dm_(Procedure HospicePerformed) {
                    object do_;
                    DataType dv_ = HospicePerformed?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlDateTime;
                    if (dx_)
                    {
                        DataType dy_ = HospicePerformed?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        do_ = dz_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ea_ = HospicePerformed?.Performed;
                        object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        bool ec_ = eb_ is CqlQuantity;
                        if (ec_)
                        {
                            DataType ed_ = HospicePerformed?.Performed;
                            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            do_ = ee_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ef_ = HospicePerformed?.Performed;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            bool eh_ = eg_ is CqlInterval<CqlDateTime>;
                            if (eh_)
                            {
                                DataType ei_ = HospicePerformed?.Performed;
                                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                                do_ = ej_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ek_ = HospicePerformed?.Performed;
                                object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                                bool em_ = el_ is CqlInterval<CqlQuantity>;
                                if (em_)
                                {
                                    DataType en_ = HospicePerformed?.Performed;
                                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                                    do_ = eo_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    do_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> dp_ = QICoreCommon_4_0_000.Instance.toInterval(context, do_);
                    CqlDateTime dq_ = context.Operators.Start(dp_);
                    Period dr_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                    CqlDateTime dt_ = context.Operators.Start(ds_);
                    bool? du_ = context.Operators.SameOrBefore(dq_, dt_, (string)default);
                    // CQL 'and' (224:13-225:107): right operand skipped when left is false
                    if (du_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        object ep_;
                        DataType ez_ = HospicePerformed?.Performed;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        bool fb_ = fa_ is CqlDateTime;
                        if (fb_)
                        {
                            DataType fc_ = HospicePerformed?.Performed;
                            object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                            ep_ = fd_ as CqlDateTime;
                        }
                        else
                        {
                            DataType fe_ = HospicePerformed?.Performed;
                            object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                            bool fg_ = ff_ is CqlQuantity;
                            if (fg_)
                            {
                                DataType fh_ = HospicePerformed?.Performed;
                                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                                ep_ = fi_ as CqlQuantity;
                            }
                            else
                            {
                                DataType fj_ = HospicePerformed?.Performed;
                                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                                bool fl_ = fk_ is CqlInterval<CqlDateTime>;
                                if (fl_)
                                {
                                    DataType fm_ = HospicePerformed?.Performed;
                                    object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                                    ep_ = fn_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType fo_ = HospicePerformed?.Performed;
                                    object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                                    bool fq_ = fp_ is CqlInterval<CqlQuantity>;
                                    if (fq_)
                                    {
                                        DataType fr_ = HospicePerformed?.Performed;
                                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                                        ep_ = fs_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        ep_ = null;
                                    }
                                }
                            }
                        }
                        CqlInterval<CqlDateTime> eq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ep_);
                        Period er_ = EDwSTEMI?.Period;
                        CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                        CqlDateTime et_ = context.Operators.Start(es_);
                        CqlQuantity eu_ = context.Operators.Quantity(6m, "months");
                        CqlDateTime ev_ = context.Operators.Subtract(et_, eu_);
                        CqlDateTime ew_ = context.Operators.End(es_);
                        CqlInterval<CqlDateTime> ex_ = context.Operators.Interval(ev_, ew_, true, true);
                        bool? ey_ = context.Operators.Overlaps(eq_, ex_, "day");
                        return du_ & ey_;
                    }
                }

                bool? dn_ = context.Operators.WhereAny<Procedure>(dl_, dm_);
                l_ = k_ | dn_;
            }
            // CQL 'or' (204:5-230:5): right operand skipped when left is true
            if (l_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet ft_ = this.Hospice_Diagnosis(context);
                IEnumerable<Condition> fu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ft_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                Condition fv_(Condition X) => X as Condition;
                IEnumerable<Condition> fw_ = context.Operators.Select<Condition, Condition>(fu_, fv_);
                IEnumerable<Condition> fx_ = Status_1_15_000.Instance.verified(context, fw_);

                bool? fy_(Condition HospiceCareDiagnosis) {
                    CqlInterval<CqlDateTime> ga_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                    CqlDateTime gb_ = context.Operators.End(ga_);
                    Period gc_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> gd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gc_);
                    CqlDateTime ge_ = context.Operators.Start(gd_);
                    bool? gf_ = context.Operators.SameOrAfter(gb_, ge_, (string)default);
                    return gf_;
                }

                bool? fz_ = context.Operators.WhereAny<Condition>(fx_, fy_);
                return l_ | fz_;
            }
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
                bool? j_ = context.Operators.Equal(i_, "final");
                bool? k_;
                // CQL 'and' (118:17-119:52): right operand skipped when left is false
                if (j_ is false)
                {
                    k_ = false;
                }
                else
                {
                    DataType l_ = PregStatus?.Value;
                    CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_ as CodeableConcept);
                    CqlValueSet n_ = this.Pregnant_State(context);
                    bool? o_ = context.Operators.ConceptInValueSet(m_, n_);
                    k_ = j_ & o_;
                }
                // CQL 'and' (118:17-120:59): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    DataType p_ = PregStatus?.Effective;
                    CqlDateTime q_ = context.Operators.LateBoundProperty<CqlDateTime>(p_, "value");
                    Period r_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, (string)default);
                    return k_ & t_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);
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
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, (string)default);
                return p_;
            }

            bool? k_ = context.Operators.WhereAny<Condition>(i_, j_);
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
                bool? l_ = context.Operators.ConceptInValueSet(j_, k_);
                bool? m_;
                // CQL 'or' (257:17-259:7): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    CodeableConcept n_ = PCINotDone?.StatusReason;
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                    CqlValueSet p_ = this.Procedure_Not_Indicated_Contraindicated(context);
                    bool? q_ = context.Operators.ConceptInValueSet(o_, p_);
                    m_ = l_ | q_;
                }
                // CQL 'and' (257:17-260:54): right operand skipped when left is false
                if (m_ is false)
                {
                    return false;
                }
                else
                {

                    bool? r_(Extension @this) {
                        FhirUri aa_ = @this?.UrlElement;
                        string ab_ = FHIRHelpers_4_4_000.Instance.ToString(context, aa_);
                        bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                        return ac_;
                    }


                    DataType s_(Extension @this) {
                        DataType ad_ = @this?.Value;
                        return ad_;
                    }

                    IEnumerable<DataType> t_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(PCINotDone is DomainResource
                        ? (PCINotDone as DomainResource).Extension
                        : default), r_, s_);
                    DataType u_ = context.Operators.SingletonFrom<DataType>(t_);
                    FhirDateTime v_ = context.Operators.Convert<FhirDateTime>(u_);
                    CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
                    Period x_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    bool? z_ = context.Operators.In<CqlDateTime>(w_, y_, (string)default);
                    return m_ & z_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
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
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return o_;
                }

                IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
                CqlValueSet l_ = this.Patient_Refusal(context);
                bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
                bool? n_;
                // CQL 'or' (265:17-267:7): right operand skipped when left is true
                if (m_ is true)
                {
                    n_ = true;
                }
                else
                {
                    List<CodeableConcept> p_ = FibrinolyticNoMed?.StatusReason;

                    CqlConcept q_(CodeableConcept @this) {
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return u_;
                    }

                    IEnumerable<CqlConcept> r_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_);
                    CqlValueSet s_ = this.Drug_Intervention_Not_Indicated_Contraindicated(context);
                    bool? t_ = context.Operators.ConceptsInValueSet(r_, s_);
                    n_ = m_ | t_;
                }
                // CQL 'and' (265:17-268:61): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {

                    bool? v_(Extension @this) {
                        FhirUri ae_ = @this?.UrlElement;
                        string af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                        bool? ag_ = context.Operators.Equal(af_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                        return ag_;
                    }


                    DataType w_(Extension @this) {
                        DataType ah_ = @this?.Value;
                        return ah_;
                    }

                    IEnumerable<DataType> x_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(FibrinolyticNoMed is DomainResource
                        ? (FibrinolyticNoMed as DomainResource).Extension
                        : default), v_, w_);
                    DataType y_ = context.Operators.SingletonFrom<DataType>(x_);
                    FhirDateTime z_ = context.Operators.Convert<FhirDateTime>(y_);
                    CqlDateTime aa_ = context.Operators.Convert<CqlDateTime>(z_);
                    Period ab_ = EDwSTEMI?.Period;
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                    bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, (string)default);
                    return n_ & ad_;
                }
            }

            bool? h_ = context.Operators.WhereAny<MedicationAdministration>(f_, g_);
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
                bool? q_ = context.Operators.ConceptInValueSet(LocationType, p_);
                bool? r_;
                // CQL 'or' (320:17-321:48): right operand skipped when left is true
                if (q_ is true)
                {
                    r_ = true;
                }
                else
                {
                    CqlCode t_ = this.Emergency_room(context);
                    CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                    bool? v_ = context.Operators.Equivalent(LocationType, u_);
                    r_ = q_ | v_;
                }
                bool? s_;
                // CQL 'or' (320:16-323:11): right operand skipped when left is true
                if (r_ is true)
                {
                    s_ = true;
                }
                else
                {
                    CqlCode w_ = this.Emergency_trauma_unit(context);
                    CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                    bool? y_ = context.Operators.Equivalent(LocationType, x_);
                    s_ = r_ | y_;
                }
                // CQL 'and' (320:11-324:54): right operand skipped when left is false
                if (s_ is false)
                {
                    return false;
                }
                else
                {
                    Period z_ = EDLocation?.Period;
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    return s_ & (!((bool?)(ab_ is null)));
                }
            }

            IEnumerable<CqlConcept> m_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            return n_;
        }


        CqlDateTime c_(Encounter.LocationComponent EDLocation) {
            Period ac_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            return ae_;
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
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Fibrinolytic_Therapy(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration Fibrinolytic) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> x_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                bool? aa_ = context.Operators.Equal(z_, "completed");
                // CQL 'and' (273:17-274:141): right operand skipped when left is false
                if (aa_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ab_ = Fibrinolytic?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.Start(ad_);
                    CqlDateTime af_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                    CqlQuantity ag_ = context.Operators.Quantity(30m, "minutes");
                    CqlDateTime ah_ = context.Operators.Add(af_, ag_);
                    CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(af_, ah_, false, true);
                    bool? aj_ = context.Operators.In<CqlDateTime>(ae_, ai_, (string)default);
                    bool? ak_;
                    // CQL 'and' (274:13-274:141): right operand skipped when left is false
                    if (aj_ is false)
                    {
                        ak_ = false;
                    }
                    else
                    {
                        CqlDateTime al_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                        ak_ = aj_ & (!((bool?)(al_ is null)));
                    }
                    return aa_ & ak_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
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
                    DataType t_ = PCI?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    h_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType v_ = PCI?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = PCI?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        h_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = PCI?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType ad_ = PCI?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            h_ = ae_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType af_ = PCI?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType ai_ = PCI?.Performed;
                                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                h_ = aj_ as CqlInterval<CqlQuantity>;
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
                bool? o_ = context.Operators.In<CqlDateTime>(j_, n_, (string)default);
                bool? p_;
                // CQL 'and' (302:17-302:130): right operand skipped when left is false
                if (o_ is false)
                {
                    p_ = false;
                }
                else
                {
                    CqlDateTime ak_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                    p_ = o_ & (!((bool?)(ak_ is null)));
                }
                // CQL 'and' (302:17-303:36): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> al_ = PCI?.StatusElement;
                    EventStatus? am_ = al_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "completed");
                    return p_ & ao_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
                bool? q_ = context.Operators.ConceptInValueSet(LocationType, p_);
                bool? r_;
                // CQL 'or' (333:17-334:48): right operand skipped when left is true
                if (q_ is true)
                {
                    r_ = true;
                }
                else
                {
                    CqlCode t_ = this.Emergency_room(context);
                    CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                    bool? v_ = context.Operators.Equivalent(LocationType, u_);
                    r_ = q_ | v_;
                }
                bool? s_;
                // CQL 'or' (333:16-336:11): right operand skipped when left is true
                if (r_ is true)
                {
                    s_ = true;
                }
                else
                {
                    CqlCode w_ = this.Emergency_trauma_unit(context);
                    CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                    bool? y_ = context.Operators.Equivalent(LocationType, x_);
                    s_ = r_ | y_;
                }
                // CQL 'and' (333:11-338:48): right operand skipped when left is false
                if (s_ is false)
                {
                    return false;
                }
                else
                {
                    Period z_ = EDLocation?.Period;
                    CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.End(aa_);
                    return s_ & (!((bool?)(ab_ is null)));
                }
            }

            IEnumerable<CqlConcept> m_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_, l_);
            bool? n_ = context.Operators.Exists<CqlConcept>(m_);
            return n_;
        }


        CqlDateTime c_(Encounter.LocationComponent EDLocation) {
            Period ac_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            return ae_;
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
            bool? i_ = context.Operators.In<CqlDateTime>(d_, h_, (string)default);
            bool? j_;
            // CQL 'and' (170:11-170:141): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                CqlDateTime k_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                j_ = i_ & (!((bool?)(k_ is null)));
            }
            // CQL 'and' (170:5-171:96): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                Encounter.HospitalizationComponent l_ = EDwithSTEMI?.Hospitalization;
                CodeableConcept m_ = l_?.DischargeDisposition;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlValueSet o_ = this.Discharge_To_Acute_Care_Facility(context);
                bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
                return j_ & p_;
            }
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
