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
[CqlLibrary("CMS996FHIRAptTxforSTEMI", "2.0.000")]
public partial class CMS996FHIRAptTxforSTEMI_2_0_000 : ILibrary, ISingleton<CMS996FHIRAptTxforSTEMI_2_0_000>
{
    private CMS996FHIRAptTxforSTEMI_2_0_000() {}

    public static CMS996FHIRAptTxforSTEMI_2_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS996FHIRAptTxforSTEMI";
    public string Version => "2.0.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    [CqlCodeDefinition("Emergency room", codeId: "ER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode Emergency_room(CqlContext _) => _Emergency_room;
    private static readonly CqlCode _Emergency_room = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

    [CqlCodeDefinition("Emergency trauma unit", codeId: "ETU", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-RoleCode")]
    public CqlCode Emergency_trauma_unit(CqlContext _) => _Emergency_trauma_unit;
    private static readonly CqlCode _Emergency_trauma_unit = new CqlCode("ETU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode");

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

    [CqlCodeSystemDefinition("RoleCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-RoleCode", codeSystemVersion: null)]
    public CqlCodeSystem RoleCode(CqlContext _) => _RoleCode;
    private static readonly CqlCodeSystem _RoleCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, [
          _Emergency_room,
          _Emergency_trauma_unit]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS996FHIRAptTxforSTEMI-2.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
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
        PropertyInfo a_ = typeof(Encounter).GetProperty("Class");
        CqlCode b_ = this.EMER(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(a_, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? e_(Encounter EDEncounter)
        {
            List<CodeableConcept> g_ = EDEncounter?.Type;
            CqlConcept h_(CodeableConcept @this)
            {
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ah_;
            };
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
            CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime ac_ = context.Operators.Start(ab_);
            CqlDate ad_ = context.Operators.DateFrom(ac_);
            int? ae_ = context.Operators.CalculateAgeAt(z_, ad_, "year");
            bool? af_ = context.Operators.GreaterOrEqual(ae_, 18);
            bool? ag_ = context.Operators.And(v_, af_);

            return ag_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_During_MP(context);
        bool? b_(Encounter EDEncounterinMP)
        {
            List<CodeableConcept> d_ = EDEncounterinMP?.ReasonCode;
            CqlConcept e_(CodeableConcept @this)
            {
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return s_;
            };
            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.STEMI(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> m_ = context.Operators.Union<object>(j_ as IEnumerable<object>, l_ as IEnumerable<object>);
            IEnumerable<object> n_ = Status_1_15_000.Instance.verified(context, m_);
            bool? o_(object DxSTEMI)
            {
                IEnumerable<object> t_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, EDEncounterinMP);
                bool? u_(object @this)
                {
                    object ag_ = context.Operators.LateBoundProperty<object>(@this, "code");
                    CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_ as CodeableConcept);
                    bool? ai_ = context.Operators.Not((bool?)(ah_ is null));

                    return ai_;
                };
                IEnumerable<object> v_ = context.Operators.Where<object>(t_, u_);
                CqlConcept w_(object @this)
                {
                    object aj_ = context.Operators.LateBoundProperty<object>(@this, "code");
                    CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_ as CodeableConcept);

                    return ak_;
                };
                IEnumerable<CqlConcept> x_ = context.Operators.Select<object, CqlConcept>(v_, w_);
                CqlValueSet y_ = this.STEMI(context);
                bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                Period ac_ = EDEncounterinMP?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.In<CqlDateTime>(ab_, ad_, default);
                bool? af_ = context.Operators.Or(z_, ae_);

                return af_;
            };
            IEnumerable<object> p_ = context.Operators.Where<object>(n_, o_);
            bool? q_ = context.Operators.Exists<object>(p_);
            bool? r_ = context.Operators.Or(h_, q_);

            return r_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);

        return a_;
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
                CqlCode l_ = QICoreCommon_4_0_000.Instance.allergy_active(context);
                CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
                bool? n_ = context.Operators.Equivalent(k_, m_);
                CodeableConcept o_ = ThrombolyticAllergy?.VerificationStatus;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                bool? q_ = context.Operators.Not((bool?)(p_ is null));
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlCode t_ = QICoreCommon_4_0_000.Instance.allergy_confirmed(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(s_, u_);
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlCode y_ = QICoreCommon_4_0_000.Instance.allergy_unconfirmed(context);
                CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
                bool? aa_ = context.Operators.Equivalent(x_, z_);
                bool? ab_ = context.Operators.Or(v_, aa_);
                bool? ac_ = context.Operators.Implies(q_, ab_);
                bool? ad_ = context.Operators.And(n_, ac_);
                DataType ae_ = ThrombolyticAllergy?.Onset;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                Period ah_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                bool? aj_ = context.Operators.Overlaps(ag_, ai_, default);
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime ao_ = context.Operators.End(an_);
                bool? ap_ = context.Operators.Before(al_ as CqlDateTime, ao_, default);
                bool? aq_ = context.Operators.Or(aj_, ap_);
                bool? ar_ = context.Operators.And(ad_, aq_);

                return ar_;
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
                FhirDateTime j_ = ThrombolyticAdverseEvent?.DateElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                FhirDateTime l_ = ThrombolyticAdverseEvent?.DetectedElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                FhirDateTime n_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
                Period p_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                bool? s_ = context.Operators.Before((k_ ?? m_) ?? o_, r_, default);
                Code<AdverseEvent.AdverseEventActuality> t_ = ThrombolyticAdverseEvent?.ActualityElement;
                AdverseEvent.AdverseEventActuality? u_ = t_?.Value;
                Code<AdverseEvent.AdverseEventActuality> v_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(u_);
                bool? w_ = context.Operators.Equal(v_, "actual");
                bool? x_ = context.Operators.And(s_, w_);

                return x_;
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
            object u_(Condition X) =>
                X as object;
            IEnumerable<object> v_ = context.Operators.Select<Condition, object>(t_, u_);
            IEnumerable<object> w_ = Status_1_15_000.Instance.verified(context, v_);
            bool? x_(object ActiveExclusionDx)
            {
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period ac_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.OverlapsBefore(ab_, ad_, default);

                return ae_;
            };
            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
            Encounter z_(object ActiveExclusionDx) =>
                EDwithSTEMI;
            IEnumerable<Encounter> aa_ = context.Operators.Select<object, Encounter>(y_, z_);

            return aa_;
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
                string[] af_ = [
                    "active",
                    "completed",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                Code<MedicationRequest.MedicationRequestIntent> ah_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
                string aj_ = context.Operators.Convert<string>(ai_);
                bool? ak_ = context.Operators.Equal(aj_, "order");
                bool? al_ = context.Operators.And(ag_, ak_);
                FhirDateTime am_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(am_);
                Period ao_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime aq_ = context.Operators.Start(ap_);
                CqlQuantity ar_ = context.Operators.Quantity(90m, "days");
                CqlDateTime as_ = context.Operators.Subtract(aq_, ar_);
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(as_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDateTime>(an_, aw_, default);
                CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                bool? bb_ = context.Operators.Not((bool?)(ba_ is null));
                bool? bc_ = context.Operators.And(ax_, bb_);
                bool? bd_ = context.Operators.And(al_, bc_);

                return bd_;
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
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> j_ = context.Operators.Union<object>(f_ as IEnumerable<object>, i_ as IEnumerable<object>);
            IEnumerable<object> k_ = Status_1_15_000.Instance.verified(context, j_);
            bool? l_(object LongTermAnticoagulant)
            {
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LongTermAnticoagulant);
                CqlDateTime q_ = context.Operators.Start(p_);
                Period r_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime t_ = context.Operators.Start(s_);
                bool? u_ = context.Operators.SameOrBefore(q_, t_, default);
                CqlDateTime w_ = context.Operators.End(p_);
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime z_ = context.Operators.Start(y_);
                bool? aa_ = context.Operators.SameOrAfter(w_, z_, default);
                bool? ab_ = context.Operators.And(u_, aa_);

                return ab_;
            };
            IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
            Encounter n_(object LongTermAnticoagulant) =>
                EDwithSTEMI;
            IEnumerable<Encounter> o_ = context.Operators.Select<object, Encounter>(m_, n_);

            return o_;
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
            object af_(Condition X) =>
                X as object;
            IEnumerable<object> ag_ = context.Operators.Select<Condition, object>(ae_, af_);
            IEnumerable<object> ah_ = Status_1_15_000.Instance.verified(context, ag_);
            bool? ai_(object ExclusionDiagnosis)
            {
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime an_ = context.Operators.Start(am_);
                Period ao_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                bool? aq_ = context.Operators.In<CqlDateTime>(an_, ap_, default);
                CqlDateTime as_ = context.Operators.Start(am_);
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
                CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ax_, ba_, true, false);
                bool? bc_ = context.Operators.In<CqlDateTime>(as_, bb_, default);
                CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime bf_ = context.Operators.Start(be_);
                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
                bool? bh_ = context.Operators.And(bc_, bg_);
                bool? bi_ = context.Operators.Or(aq_, bh_);

                return bi_;
            };
            IEnumerable<object> aj_ = context.Operators.Where<object>(ah_, ai_);
            Encounter ak_(object ExclusionDiagnosis) =>
                EDwithSTEMI;
            IEnumerable<Encounter> al_ = context.Operators.Select<object, Encounter>(aj_, ak_);

            return al_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
    public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlValueSet d_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure MajorSurgery)
            {
                object j_()
                {
                    bool an_()
                    {
                        DataType ar_ = MajorSurgery?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlDateTime;

                        return at_;
                    };
                    bool ao_()
                    {
                        DataType au_ = MajorSurgery?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;

                        return aw_;
                    };
                    bool ap_()
                    {
                        DataType ax_ = MajorSurgery?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlQuantity;

                        return az_;
                    };
                    bool aq_()
                    {
                        DataType ba_ = MajorSurgery?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlInterval<CqlQuantity>;

                        return bc_;
                    };
                    if (an_())
                    {
                        DataType bd_ = MajorSurgery?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);

                        return (be_ as CqlDateTime) as object;
                    }
                    else if (ao_())
                    {
                        DataType bf_ = MajorSurgery?.Performed;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);

                        return (bg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ap_())
                    {
                        DataType bh_ = MajorSurgery?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);

                        return (bi_ as CqlQuantity) as object;
                    }
                    else if (aq_())
                    {
                        DataType bj_ = MajorSurgery?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);

                        return (bk_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(21m, "days");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(q_, t_, true, false);
                bool? v_ = context.Operators.In<CqlDateTime>(l_, u_, default);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.Not((bool?)(y_ is null));
                bool? aa_ = context.Operators.And(v_, z_);
                object ab_()
                {
                    bool bl_()
                    {
                        DataType bp_ = MajorSurgery?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlDateTime;

                        return br_;
                    };
                    bool bm_()
                    {
                        DataType bs_ = MajorSurgery?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlDateTime>;

                        return bu_;
                    };
                    bool bn_()
                    {
                        DataType bv_ = MajorSurgery?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlQuantity;

                        return bx_;
                    };
                    bool bo_()
                    {
                        DataType by_ = MajorSurgery?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlInterval<CqlQuantity>;

                        return ca_;
                    };
                    if (bl_())
                    {
                        DataType cb_ = MajorSurgery?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);

                        return (cc_ as CqlDateTime) as object;
                    }
                    else if (bm_())
                    {
                        DataType cd_ = MajorSurgery?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);

                        return (ce_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bn_())
                    {
                        DataType cf_ = MajorSurgery?.Performed;
                        object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);

                        return (cg_ as CqlQuantity) as object;
                    }
                    else if (bo_())
                    {
                        DataType ch_ = MajorSurgery?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);

                        return (ci_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_());
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                bool? ag_ = context.Operators.In<CqlDateTime>(ad_, af_, default);
                bool? ah_ = context.Operators.Or(aa_, ag_);
                Code<EventStatus> ai_ = MajorSurgery?.StatusElement;
                EventStatus? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                bool? al_ = context.Operators.Equal(ak_, "completed");
                bool? am_ = context.Operators.And(ah_, al_);

                return am_;
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
            CqlValueSet f_ = this.Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
            bool? i_(Procedure AirwayProcedure)
            {
                object m_()
                {
                    bool aq_()
                    {
                        DataType au_ = AirwayProcedure?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlDateTime;

                        return aw_;
                    };
                    bool ar_()
                    {
                        DataType ax_ = AirwayProcedure?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlDateTime>;

                        return az_;
                    };
                    bool as_()
                    {
                        DataType ba_ = AirwayProcedure?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        bool bc_ = bb_ is CqlQuantity;

                        return bc_;
                    };
                    bool at_()
                    {
                        DataType bd_ = AirwayProcedure?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlQuantity>;

                        return bf_;
                    };
                    if (aq_())
                    {
                        DataType bg_ = AirwayProcedure?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);

                        return (bh_ as CqlDateTime) as object;
                    }
                    else if (ar_())
                    {
                        DataType bi_ = AirwayProcedure?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);

                        return (bj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (as_())
                    {
                        DataType bk_ = AirwayProcedure?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);

                        return (bl_ as CqlQuantity) as object;
                    }
                    else if (at_())
                    {
                        DataType bm_ = AirwayProcedure?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);

                        return (bn_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                CqlDateTime o_ = context.Operators.Start(n_);
                Period p_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                bool? r_ = context.Operators.In<CqlDateTime>(o_, q_, default);
                object s_()
                {
                    bool bo_()
                    {
                        DataType bs_ = AirwayProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlDateTime;

                        return bu_;
                    };
                    bool bp_()
                    {
                        DataType bv_ = AirwayProcedure?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlInterval<CqlDateTime>;

                        return bx_;
                    };
                    bool bq_()
                    {
                        DataType by_ = AirwayProcedure?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        bool ca_ = bz_ is CqlQuantity;

                        return ca_;
                    };
                    bool br_()
                    {
                        DataType cb_ = AirwayProcedure?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlInterval<CqlQuantity>;

                        return cd_;
                    };
                    if (bo_())
                    {
                        DataType ce_ = AirwayProcedure?.Performed;
                        object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);

                        return (cf_ as CqlDateTime) as object;
                    }
                    else if (bp_())
                    {
                        DataType cg_ = AirwayProcedure?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);

                        return (ch_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bq_())
                    {
                        DataType ci_ = AirwayProcedure?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);

                        return (cj_ as CqlQuantity) as object;
                    }
                    else if (br_())
                    {
                        DataType ck_ = AirwayProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);

                        return (cl_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_());
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlQuantity y_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime z_ = context.Operators.Subtract(x_, y_);
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(z_, ac_, true, false);
                bool? ae_ = context.Operators.In<CqlDateTime>(u_, ad_, default);
                CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(ae_, ai_);
                bool? ak_ = context.Operators.Or(r_, aj_);
                Code<EventStatus> al_ = AirwayProcedure?.StatusElement;
                EventStatus? am_ = al_?.Value;
                string an_ = context.Operators.Convert<string>(am_);
                bool? ao_ = context.Operators.Equal(an_, "completed");
                bool? ap_ = context.Operators.And(ak_, ao_);

                return ap_;
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
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            CqlValueSet f_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
            CqlValueSet i_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
            object l_(Condition X) =>
                X as object;
            IEnumerable<object> m_ = context.Operators.Select<Condition, object>(k_, l_);
            IEnumerable<object> n_ = Status_1_15_000.Instance.verified(context, m_);
            bool? o_(object ExclusionCondition)
            {
                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime t_ = context.Operators.Start(s_);
                Period u_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlQuantity x_ = context.Operators.Quantity(90m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(y_, ab_, true, true);
                bool? ad_ = context.Operators.In<CqlDateTime>(t_, ac_, default);

                return ad_;
            };
            IEnumerable<object> p_ = context.Operators.Where<object>(n_, o_);
            Encounter q_(object ExclusionCondition) =>
                EDwSTEMI;
            IEnumerable<Encounter> r_ = context.Operators.Select<object, Encounter>(p_, q_);

            return r_;
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
                object j_()
                {
                    bool ag_()
                    {
                        DataType ak_ = CranialorSpinalSurgery?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;

                        return am_;
                    };
                    bool ah_()
                    {
                        DataType an_ = CranialorSpinalSurgery?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;

                        return ap_;
                    };
                    bool ai_()
                    {
                        DataType aq_ = CranialorSpinalSurgery?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlQuantity;

                        return as_;
                    };
                    bool aj_()
                    {
                        DataType at_ = CranialorSpinalSurgery?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;

                        return av_;
                    };
                    if (ag_())
                    {
                        DataType aw_ = CranialorSpinalSurgery?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);

                        return (ax_ as CqlDateTime) as object;
                    }
                    else if (ah_())
                    {
                        DataType ay_ = CranialorSpinalSurgery?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);

                        return (az_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ai_())
                    {
                        DataType ba_ = CranialorSpinalSurgery?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);

                        return (bb_ as CqlQuantity) as object;
                    }
                    else if (aj_())
                    {
                        DataType bc_ = CranialorSpinalSurgery?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);

                        return (bd_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(90m, "days");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(q_, t_, true, false);
                bool? v_ = context.Operators.In<CqlDateTime>(l_, u_, default);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime y_ = context.Operators.Start(x_);
                bool? z_ = context.Operators.Not((bool?)(y_ is null));
                bool? aa_ = context.Operators.And(v_, z_);
                Code<EventStatus> ab_ = CranialorSpinalSurgery?.StatusElement;
                EventStatus? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                bool? ae_ = context.Operators.Equal(ad_, "completed");
                bool? af_ = context.Operators.And(aa_, ae_);

                return af_;
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
            IEnumerable<Encounter> f_ = Status_1_15_000.Instance.isEncounterPerformed(context, e_);
            bool? g_(Encounter InpatientEncounter)
            {
                Encounter.HospitalizationComponent av_ = InpatientEncounter?.Hospitalization;
                CodeableConcept aw_ = av_?.DischargeDisposition;
                CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aw_);
                CqlCode ay_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                bool? ba_ = context.Operators.Equivalent(ax_, az_);
                CodeableConcept bc_ = av_?.DischargeDisposition;
                CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                CqlCode be_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept bf_ = context.Operators.ConvertCodeToConcept(be_);
                bool? bg_ = context.Operators.Equivalent(bd_, bf_);
                bool? bh_ = context.Operators.Or(ba_, bg_);
                Period bi_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                Period bl_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                bool? bo_ = context.Operators.SameOrBefore(bk_, bn_, default);
                bool? bp_ = context.Operators.And(bh_, bo_);
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bi_);
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                CqlQuantity bv_ = context.Operators.Quantity(6m, "months");
                CqlDateTime bw_ = context.Operators.Subtract(bu_, bv_);
                CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                CqlDateTime bz_ = context.Operators.End(by_);
                CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(bw_, bz_, true, true);
                bool? cb_ = context.Operators.Overlaps(br_, ca_, "day");
                bool? cc_ = context.Operators.And(bp_, cb_);

                return cc_;
            };
            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            bool? i_ = context.Operators.Exists<Encounter>(h_);
            CqlValueSet j_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> k_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> l_ = Status_1_15_000.Instance.isEncounterPerformed(context, k_);
            bool? m_(Encounter HospiceEncounter)
            {
                Period cd_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                Period cg_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                CqlDateTime ci_ = context.Operators.Start(ch_);
                bool? cj_ = context.Operators.SameOrBefore(cf_, ci_, default);
                CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlQuantity cp_ = context.Operators.Quantity(6m, "months");
                CqlDateTime cq_ = context.Operators.Subtract(co_, cp_);
                CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                CqlDateTime ct_ = context.Operators.End(cs_);
                CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(cq_, ct_, true, true);
                bool? cv_ = context.Operators.Overlaps(cl_, cu_, "day");
                bool? cw_ = context.Operators.And(cj_, cv_);

                return cw_;
            };
            IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
            bool? o_ = context.Operators.Exists<Encounter>(n_);
            bool? p_ = context.Operators.Or(i_, o_);
            CqlCode q_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
            IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> t_ = Status_1_15_000.Instance.isAssessmentPerformed(context, s_);
            bool? u_(Observation HospiceAssessment)
            {
                DataType cx_ = (HospiceAssessment as Observation)?.Value;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                CqlCode cz_ = this.Yes__qualifier_value_(context);
                CqlConcept da_ = context.Operators.ConvertCodeToConcept(cz_);
                bool? db_ = context.Operators.Equivalent(cy_ as CqlConcept, da_);
                DataType dc_ = HospiceAssessment?.Effective;
                object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                CqlInterval<CqlDateTime> de_ = QICoreCommon_4_0_000.Instance.toInterval(context, dd_);
                CqlDateTime df_ = context.Operators.Start(de_);
                Period dg_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                CqlDateTime di_ = context.Operators.Start(dh_);
                bool? dj_ = context.Operators.SameOrBefore(df_, di_, default);
                bool? dk_ = context.Operators.And(db_, dj_);
                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                CqlInterval<CqlDateTime> dn_ = QICoreCommon_4_0_000.Instance.toInterval(context, dm_);
                CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                CqlDateTime dq_ = context.Operators.Start(dp_);
                CqlQuantity dr_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ds_ = context.Operators.Subtract(dq_, dr_);
                CqlInterval<CqlDateTime> du_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                CqlDateTime dv_ = context.Operators.End(du_);
                CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(ds_, dv_, true, true);
                bool? dx_ = context.Operators.Overlaps(dn_, dw_, "day");
                bool? dy_ = context.Operators.And(dk_, dx_);

                return dy_;
            };
            IEnumerable<Observation> v_ = context.Operators.Where<Observation>(t_, u_);
            bool? w_ = context.Operators.Exists<Observation>(v_);
            bool? x_ = context.Operators.Or(p_, w_);
            CqlValueSet y_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> z_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> aa_ = Status_1_15_000.Instance.isInterventionOrder(context, z_);
            bool? ab_(ServiceRequest HospiceOrder)
            {
                FhirDateTime dz_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime ea_ = context.Operators.Convert<CqlDateTime>(dz_);
                Period eb_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                CqlDateTime ed_ = context.Operators.Start(ec_);
                CqlQuantity ee_ = context.Operators.Quantity(6m, "months");
                CqlDateTime ef_ = context.Operators.Subtract(ed_, ee_);
                CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                CqlDateTime ei_ = context.Operators.Start(eh_);
                CqlInterval<CqlDateTime> ej_ = context.Operators.Interval(ef_, ei_, true, false);
                bool? ek_ = context.Operators.In<CqlDateTime>(ea_, ej_, default);
                CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                CqlDateTime en_ = context.Operators.Start(em_);
                bool? eo_ = context.Operators.Not((bool?)(en_ is null));
                bool? ep_ = context.Operators.And(ek_, eo_);

                return ep_;
            };
            IEnumerable<ServiceRequest> ac_ = context.Operators.Where<ServiceRequest>(aa_, ab_);
            bool? ad_ = context.Operators.Exists<ServiceRequest>(ac_);
            bool? ae_ = context.Operators.Or(x_, ad_);
            IEnumerable<Procedure> ag_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> ah_ = Status_1_15_000.Instance.isInterventionPerformed(context, ag_);
            bool? ai_(Procedure HospicePerformed)
            {
                object eq_()
                {
                    bool fk_()
                    {
                        DataType fo_ = HospicePerformed?.Performed;
                        object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                        bool fq_ = fp_ is CqlDateTime;

                        return fq_;
                    };
                    bool fl_()
                    {
                        DataType fr_ = HospicePerformed?.Performed;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        bool ft_ = fs_ is CqlInterval<CqlDateTime>;

                        return ft_;
                    };
                    bool fm_()
                    {
                        DataType fu_ = HospicePerformed?.Performed;
                        object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                        bool fw_ = fv_ is CqlQuantity;

                        return fw_;
                    };
                    bool fn_()
                    {
                        DataType fx_ = HospicePerformed?.Performed;
                        object fy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fx_);
                        bool fz_ = fy_ is CqlInterval<CqlQuantity>;

                        return fz_;
                    };
                    if (fk_())
                    {
                        DataType ga_ = HospicePerformed?.Performed;
                        object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);

                        return (gb_ as CqlDateTime) as object;
                    }
                    else if (fl_())
                    {
                        DataType gc_ = HospicePerformed?.Performed;
                        object gd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gc_);

                        return (gd_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (fm_())
                    {
                        DataType ge_ = HospicePerformed?.Performed;
                        object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);

                        return (gf_ as CqlQuantity) as object;
                    }
                    else if (fn_())
                    {
                        DataType gg_ = HospicePerformed?.Performed;
                        object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);

                        return (gh_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> er_ = QICoreCommon_4_0_000.Instance.toInterval(context, eq_());
                CqlDateTime es_ = context.Operators.Start(er_);
                Period et_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> eu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime ev_ = context.Operators.Start(eu_);
                bool? ew_ = context.Operators.SameOrBefore(es_, ev_, default);
                object ex_()
                {
                    bool gi_()
                    {
                        DataType gm_ = HospicePerformed?.Performed;
                        object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                        bool go_ = gn_ is CqlDateTime;

                        return go_;
                    };
                    bool gj_()
                    {
                        DataType gp_ = HospicePerformed?.Performed;
                        object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                        bool gr_ = gq_ is CqlInterval<CqlDateTime>;

                        return gr_;
                    };
                    bool gk_()
                    {
                        DataType gs_ = HospicePerformed?.Performed;
                        object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                        bool gu_ = gt_ is CqlQuantity;

                        return gu_;
                    };
                    bool gl_()
                    {
                        DataType gv_ = HospicePerformed?.Performed;
                        object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                        bool gx_ = gw_ is CqlInterval<CqlQuantity>;

                        return gx_;
                    };
                    if (gi_())
                    {
                        DataType gy_ = HospicePerformed?.Performed;
                        object gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);

                        return (gz_ as CqlDateTime) as object;
                    }
                    else if (gj_())
                    {
                        DataType ha_ = HospicePerformed?.Performed;
                        object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);

                        return (hb_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (gk_())
                    {
                        DataType hc_ = HospicePerformed?.Performed;
                        object hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);

                        return (hd_ as CqlQuantity) as object;
                    }
                    else if (gl_())
                    {
                        DataType he_ = HospicePerformed?.Performed;
                        object hf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, he_);

                        return (hf_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> ey_ = QICoreCommon_4_0_000.Instance.toInterval(context, ex_());
                CqlInterval<CqlDateTime> fa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime fb_ = context.Operators.Start(fa_);
                CqlQuantity fc_ = context.Operators.Quantity(6m, "months");
                CqlDateTime fd_ = context.Operators.Subtract(fb_, fc_);
                CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, et_);
                CqlDateTime fg_ = context.Operators.End(ff_);
                CqlInterval<CqlDateTime> fh_ = context.Operators.Interval(fd_, fg_, true, true);
                bool? fi_ = context.Operators.Overlaps(ey_, fh_, "day");
                bool? fj_ = context.Operators.And(ew_, fi_);

                return fj_;
            };
            IEnumerable<Procedure> aj_ = context.Operators.Where<Procedure>(ah_, ai_);
            bool? ak_ = context.Operators.Exists<Procedure>(aj_);
            bool? al_ = context.Operators.Or(ae_, ak_);
            CqlValueSet am_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> an_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            object ao_(Condition X) =>
                X as object;
            IEnumerable<object> ap_ = context.Operators.Select<Condition, object>(an_, ao_);
            IEnumerable<object> aq_ = Status_1_15_000.Instance.verified(context, ap_);
            bool? ar_(object HospiceCareDiagnosis)
            {
                CqlInterval<CqlDateTime> hg_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlDateTime hh_ = context.Operators.End(hg_);
                Period hi_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> hj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hi_);
                CqlDateTime hk_ = context.Operators.Start(hj_);
                bool? hl_ = context.Operators.SameOrAfter(hh_, hk_, default);

                return hl_;
            };
            IEnumerable<object> as_ = context.Operators.Where<object>(aq_, ar_);
            bool? at_ = context.Operators.Exists<object>(as_);
            bool? au_ = context.Operators.Or(al_, at_);

            return au_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Currently Pregnant")]
    public IEnumerable<Encounter> Currently_Pregnant(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-pregnancystatus"));
            bool? e_(Observation PregStatus)
            {
                Code<ObservationStatus> i_ = PregStatus?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                Code<ObservationStatus> k_ = context.Operators.Convert<Code<ObservationStatus>>(j_);
                bool? l_ = context.Operators.Equal(k_, "final");
                DataType m_ = PregStatus?.Value;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_ as CodeableConcept);
                CqlValueSet o_ = this.Pregnant_State(context);
                bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
                bool? q_ = context.Operators.And(l_, p_);
                DataType r_ = PregStatus?.Effective;
                CqlDateTime s_ = context.Operators.LateBoundProperty<CqlDateTime>(r_, "value");
                Period t_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, default);
                bool? w_ = context.Operators.And(q_, v_);

                return w_;
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            Encounter g_(Observation PregStatus) =>
                EDwSTEMI;
            IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

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
    public IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
        {
            CqlCode d_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> j_ = context.Operators.Union<object>(f_ as IEnumerable<object>, i_ as IEnumerable<object>);
            IEnumerable<object> k_ = Status_1_15_000.Instance.verified(context, j_);
            bool? l_(object TPA)
            {
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime q_ = context.Operators.Start(p_);
                Period r_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, default);

                return t_;
            };
            IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
            Encounter n_(object TPA) =>
                EDwithSTEMI;
            IEnumerable<Encounter> o_ = context.Operators.Select<object, Encounter>(m_, n_);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for No PCI Performed")]
    public IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_No_PCI_Performed(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            CqlValueSet d_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedurenotdone"));
            IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
            bool? i_(Procedure PCINotDone)
            {
                CodeableConcept m_ = PCINotDone?.StatusReason;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlValueSet o_ = this.Patient_Refusal(context);
                bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                CqlValueSet s_ = this.Procedure_Not_Indicated_Contraindicated(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.Or(p_, t_);
                bool? v_(Extension @this)
                {
                    FhirUri ag_ = @this?.UrlElement;
                    FhirString ah_ = context.Operators.Convert<FhirString>(ag_);
                    string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                    bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return aj_;
                };
                IEnumerable<Extension> w_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(PCINotDone is DomainResource
                        ? (PCINotDone as DomainResource).Extension
                        : default), v_);
                DataType x_(Extension @this)
                {
                    DataType ak_ = @this?.Value;

                    return ak_;
                };
                IEnumerable<DataType> y_ = context.Operators.Select<Extension, DataType>(w_, x_);
                DataType z_ = context.Operators.SingletonFrom<DataType>(y_);
                FhirDateTime aa_ = context.Operators.Convert<FhirDateTime>(z_);
                CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
                Period ac_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                bool? ae_ = context.Operators.In<CqlDateTime>(ab_, ad_, default);
                bool? af_ = context.Operators.And(u_, ae_);

                return af_;
            };
            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            Encounter k_(Procedure PCINotDone) =>
                EDwSTEMI;
            IEnumerable<Encounter> l_ = context.Operators.Select<Procedure, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy")]
    public IEnumerable<Encounter> ED_Encounter_with_a_Documented_Reason_for_Not_Administering_Fibrinolytic_Therapy(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter EDwSTEMI)
        {
            CqlValueSet d_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
            IEnumerable<MedicationAdministration> g_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
            IEnumerable<MedicationAdministration> h_ = context.Operators.Union<MedicationAdministration>(e_, g_);
            bool? i_(MedicationAdministration FibrinolyticNoMed)
            {
                List<CodeableConcept> m_ = FibrinolyticNoMed?.StatusReason;
                CqlConcept n_(CodeableConcept @this)
                {
                    CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return ai_;
                };
                IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)m_, n_);
                CqlValueSet p_ = this.Patient_Refusal(context);
                bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
                CqlConcept s_(CodeableConcept @this)
                {
                    CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                    return aj_;
                };
                IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)m_, s_);
                CqlValueSet u_ = this.Drug_Intervention_Not_Indicated_Contraindicated(context);
                bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
                bool? w_ = context.Operators.Or(q_, v_);
                bool? x_(Extension @this)
                {
                    FhirUri ak_ = @this?.UrlElement;
                    FhirString al_ = context.Operators.Convert<FhirString>(ak_);
                    string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                    bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                    return an_;
                };
                IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(FibrinolyticNoMed is DomainResource
                        ? (FibrinolyticNoMed as DomainResource).Extension
                        : default), x_);
                DataType z_(Extension @this)
                {
                    DataType ao_ = @this?.Value;

                    return ao_;
                };
                IEnumerable<DataType> aa_ = context.Operators.Select<Extension, DataType>(y_, z_);
                DataType ab_ = context.Operators.SingletonFrom<DataType>(aa_);
                FhirDateTime ac_ = context.Operators.Convert<FhirDateTime>(ab_);
                CqlDateTime ad_ = context.Operators.Convert<CqlDateTime>(ac_);
                Period ae_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                bool? ag_ = context.Operators.In<CqlDateTime>(ad_, af_, default);
                bool? ah_ = context.Operators.And(w_, ag_);

                return ah_;
            };
            IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);
            Encounter k_(MedicationAdministration FibrinolyticNoMed) =>
                EDwSTEMI;
            IEnumerable<Encounter> l_ = context.Operators.Select<MedicationAdministration, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
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
        bool? b_(Encounter.LocationComponent EDLocation)
        {
            ResourceReference i_ = EDLocation?.Location;
            Location j_ = CQMCommon_4_1_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;
            CqlConcept l_(CodeableConcept @this)
            {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return q_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            bool? n_(CqlConcept LocationType)
            {
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
            };
            IEnumerable<CqlConcept> o_ = context.Operators.Where<CqlConcept>(m_, n_);
            bool? p_ = context.Operators.Exists<CqlConcept>(o_);

            return p_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        CqlDateTime d_(Encounter.LocationComponent EDLocation)
        {
            Period ag_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);

            return ai_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.First<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("Fibrinolytic Therapy Administration within 30 Minutes of Arrival")]
    public IEnumerable<Encounter> Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival(CqlContext context)
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
                string ae_ = context.Operators.Convert<string>(ad_);
                bool? af_ = context.Operators.Equal(ae_, "completed");
                DataType ag_ = Fibrinolytic?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
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
                object j_()
                {
                    bool aa_()
                    {
                        DataType ae_ = PCI?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlDateTime;

                        return ag_;
                    };
                    bool ab_()
                    {
                        DataType ah_ = PCI?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;

                        return aj_;
                    };
                    bool ac_()
                    {
                        DataType ak_ = PCI?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlQuantity;

                        return am_;
                    };
                    bool ad_()
                    {
                        DataType an_ = PCI?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlQuantity>;

                        return ap_;
                    };
                    if (aa_())
                    {
                        DataType aq_ = PCI?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);

                        return (ar_ as CqlDateTime) as object;
                    }
                    else if (ab_())
                    {
                        DataType as_ = PCI?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);

                        return (at_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ac_())
                    {
                        DataType au_ = PCI?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);

                        return (av_ as CqlQuantity) as object;
                    }
                    else if (ad_())
                    {
                        DataType aw_ = PCI?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);

                        return (ax_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlDateTime m_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity o_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime p_ = context.Operators.Add(m_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(m_, p_, false, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, default);
                bool? t_ = context.Operators.Not((bool?)(m_ is null));
                bool? u_ = context.Operators.And(r_, t_);
                Code<EventStatus> v_ = PCI?.StatusElement;
                EventStatus? w_ = v_?.Value;
                string x_ = context.Operators.Convert<string>(w_);
                bool? y_ = context.Operators.Equal(x_, "completed");
                bool? z_ = context.Operators.And(u_, y_);

                return z_;
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
            ResourceReference i_ = EDLocation?.Location;
            Location j_ = CQMCommon_4_1_000.Instance.getLocation(context, i_);
            List<CodeableConcept> k_ = j_?.Type;
            CqlConcept l_(CodeableConcept @this)
            {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return q_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            bool? n_(CqlConcept LocationType)
            {
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
            };
            IEnumerable<CqlConcept> o_ = context.Operators.Where<CqlConcept>(m_, n_);
            bool? p_ = context.Operators.Exists<CqlConcept>(o_);

            return p_;
        };
        IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
        CqlDateTime d_(Encounter.LocationComponent EDLocation)
        {
            Period ag_ = EDLocation?.Period;
            CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.End(ah_);

            return ai_;
        };
        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Encounter.LocationComponent, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        IEnumerable<CqlDateTime> g_ = context.Operators.ListSort<CqlDateTime>(f_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime h_ = context.Operators.Last<CqlDateTime>(g_);

        return h_;
    }


    [CqlExpressionDefinition("ED Departure with Discharge to Acute Care Facility Within 45 Minutes Of Arrival")]
    public IEnumerable<Encounter> ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival(CqlContext context)
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
        IEnumerable<Encounter> a_ = this.Fibrinolytic_Therapy_Administration_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter> b_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.ED_Departure_with_Discharge_to_Acute_Care_Facility_Within_45_Minutes_Of_Arrival(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

}
