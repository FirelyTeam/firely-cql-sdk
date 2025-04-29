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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("AppropriateTreatmentforSTEMIFHIR", "1.2.000")]
public partial class AppropriateTreatmentforSTEMIFHIR_1_2_000 : ILibrary, ISingleton<AppropriateTreatmentforSTEMIFHIR_1_2_000>
{
    private AppropriateTreatmentforSTEMIFHIR_1_2_000() {}

    public static AppropriateTreatmentforSTEMIFHIR_1_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AppropriateTreatmentforSTEMIFHIR";
    public string Version => "1.2.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Active Bleeding Excluding Menses or Bleeding Diathesis
    [CqlValueSetDefinition(
        definitionName: "Active Bleeding Excluding Menses or Bleeding Diathesis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036",
        valueSetVersion: null)]
    public CqlValueSet Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(CqlContext context) => _Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis;

    private static readonly CqlValueSet _Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", null);
    #endregion

    #region ValueSet: Active Peptic Ulcer
    [CqlValueSetDefinition(
        definitionName: "Active Peptic Ulcer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031",
        valueSetVersion: null)]
    public CqlValueSet Active_Peptic_Ulcer(CqlContext context) => _Active_Peptic_Ulcer;

    private static readonly CqlValueSet _Active_Peptic_Ulcer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", null);
    #endregion

    #region ValueSet: Thrombolytics Adverse Event
    [CqlValueSetDefinition(
        definitionName: "Thrombolytics Adverse Event",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6",
        valueSetVersion: null)]
    public CqlValueSet Thrombolytics_Adverse_Event(CqlContext context) => _Thrombolytics_Adverse_Event;

    private static readonly CqlValueSet _Thrombolytics_Adverse_Event = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", null);
    #endregion

    #region ValueSet: Allergy to thrombolytics
    [CqlValueSetDefinition(
        definitionName: "Allergy to thrombolytics",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5",
        valueSetVersion: null)]
    public CqlValueSet Allergy_to_thrombolytics(CqlContext context) => _Allergy_to_thrombolytics;

    private static readonly CqlValueSet _Allergy_to_thrombolytics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", null);
    #endregion

    #region ValueSet: Oral Anticoagulant Medications
    [CqlValueSetDefinition(
        definitionName: "Oral Anticoagulant Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045",
        valueSetVersion: null)]
    public CqlValueSet Oral_Anticoagulant_Medications(CqlContext context) => _Oral_Anticoagulant_Medications;

    private static readonly CqlValueSet _Oral_Anticoagulant_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", null);
    #endregion

    #region ValueSet: Aortic Dissection or Ruptured Aortic Aneurysm
    [CqlValueSetDefinition(
        definitionName: "Aortic Dissection or Ruptured Aortic Aneurysm",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028",
        valueSetVersion: null)]
    public CqlValueSet Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(CqlContext context) => _Aortic_Dissection_or_Ruptured_Aortic_Aneurysm;

    private static readonly CqlValueSet _Aortic_Dissection_or_Ruptured_Aortic_Aneurysm = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", null);
    #endregion

    #region ValueSet: birth date
    [CqlValueSetDefinition(
        definitionName: "birth date",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4",
        valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext context) => _birth_date;

    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);
    #endregion

    #region ValueSet: Cardiopulmonary Arrest
    [CqlValueSetDefinition(
        definitionName: "Cardiopulmonary Arrest",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048",
        valueSetVersion: null)]
    public CqlValueSet Cardiopulmonary_Arrest(CqlContext context) => _Cardiopulmonary_Arrest;

    private static readonly CqlValueSet _Cardiopulmonary_Arrest = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", null);
    #endregion

    #region ValueSet: Cerebral Vascular Lesion
    [CqlValueSetDefinition(
        definitionName: "Cerebral Vascular Lesion",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025",
        valueSetVersion: null)]
    public CqlValueSet Cerebral_Vascular_Lesion(CqlContext context) => _Cerebral_Vascular_Lesion;

    private static readonly CqlValueSet _Cerebral_Vascular_Lesion = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", null);
    #endregion

    #region ValueSet: Closed Head and Facial Trauma
    [CqlValueSetDefinition(
        definitionName: "Closed Head and Facial Trauma",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026",
        valueSetVersion: null)]
    public CqlValueSet Closed_Head_and_Facial_Trauma(CqlContext context) => _Closed_Head_and_Facial_Trauma;

    private static readonly CqlValueSet _Closed_Head_and_Facial_Trauma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", null);
    #endregion

    #region ValueSet: Dementia and Related Intracranial Pathologies
    [CqlValueSetDefinition(
        definitionName: "Dementia and Related Intracranial Pathologies",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043",
        valueSetVersion: null)]
    public CqlValueSet Dementia_and_Related_Intracranial_Pathologies(CqlContext context) => _Dementia_and_Related_Intracranial_Pathologies;

    private static readonly CqlValueSet _Dementia_and_Related_Intracranial_Pathologies = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", null);
    #endregion

    #region ValueSet: Discharge To Acute Care Facility
    [CqlValueSetDefinition(
        definitionName: "Discharge To Acute Care Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87",
        valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => _Discharge_To_Acute_Care_Facility;

    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);
    #endregion

    #region ValueSet: Emergency Department Evaluation and Management Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Evaluation and Management Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Evaluation_and_Management_Visit(CqlContext context) => _Emergency_Department_Evaluation_and_Management_Visit;

    private static readonly CqlValueSet _Emergency_Department_Evaluation_and_Management_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);
    #endregion

    #region ValueSet: Emergency Department Visit
    [CqlValueSetDefinition(
        definitionName: "Emergency Department Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292",
        valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext context) => _Emergency_Department_Visit;

    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);
    #endregion

    #region ValueSet: Endotracheal Intubation
    [CqlValueSetDefinition(
        definitionName: "Endotracheal Intubation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69",
        valueSetVersion: null)]
    public CqlValueSet Endotracheal_Intubation(CqlContext context) => _Endotracheal_Intubation;

    private static readonly CqlValueSet _Endotracheal_Intubation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", null);
    #endregion

    #region ValueSet: Fibrinolytic Therapy
    [CqlValueSetDefinition(
        definitionName: "Fibrinolytic Therapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020",
        valueSetVersion: null)]
    public CqlValueSet Fibrinolytic_Therapy(CqlContext context) => _Fibrinolytic_Therapy;

    private static readonly CqlValueSet _Fibrinolytic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020", null);
    #endregion

    #region ValueSet: Intracranial or Intraspinal surgery
    [CqlValueSetDefinition(
        definitionName: "Intracranial or Intraspinal surgery",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2",
        valueSetVersion: null)]
    public CqlValueSet Intracranial_or_Intraspinal_surgery(CqlContext context) => _Intracranial_or_Intraspinal_surgery;

    private static readonly CqlValueSet _Intracranial_or_Intraspinal_surgery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", null);
    #endregion

    #region ValueSet: Ischemic Stroke
    [CqlValueSetDefinition(
        definitionName: "Ischemic Stroke",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247",
        valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext context) => _Ischemic_Stroke;

    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);
    #endregion

    #region ValueSet: Major Surgical Procedure
    [CqlValueSetDefinition(
        definitionName: "Major Surgical Procedure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056",
        valueSetVersion: null)]
    public CqlValueSet Major_Surgical_Procedure(CqlContext context) => _Major_Surgical_Procedure;

    private static readonly CqlValueSet _Major_Surgical_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", null);
    #endregion

    #region ValueSet: Malignant Intracranial Neoplasm Group
    [CqlValueSetDefinition(
        definitionName: "Malignant Intracranial Neoplasm Group",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3",
        valueSetVersion: null)]
    public CqlValueSet Malignant_Intracranial_Neoplasm_Group(CqlContext context) => _Malignant_Intracranial_Neoplasm_Group;

    private static readonly CqlValueSet _Malignant_Intracranial_Neoplasm_Group = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", null);
    #endregion

    #region ValueSet: Insertion or Replacement of Mechanical Circulatory Assist Device
    [CqlValueSetDefinition(
        definitionName: "Insertion or Replacement of Mechanical Circulatory Assist Device",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052",
        valueSetVersion: null)]
    public CqlValueSet Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(CqlContext context) => _Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device;

    private static readonly CqlValueSet _Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", null);
    #endregion

    #region ValueSet: Neurologic impairment
    [CqlValueSetDefinition(
        definitionName: "Neurologic impairment",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Neurologic_impairment(CqlContext context) => _Neurologic_impairment;

    private static readonly CqlValueSet _Neurologic_impairment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", null);
    #endregion

    #region ValueSet: Patient Expired
    [CqlValueSetDefinition(
        definitionName: "Patient Expired",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309",
        valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext context) => _Patient_Expired;

    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);
    #endregion

    #region ValueSet: Percutaneous Coronary Intervention
    [CqlValueSetDefinition(
        definitionName: "Percutaneous Coronary Intervention",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5",
        valueSetVersion: null)]
    public CqlValueSet Percutaneous_Coronary_Intervention(CqlContext context) => _Percutaneous_Coronary_Intervention;

    private static readonly CqlValueSet _Percutaneous_Coronary_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", null);
    #endregion

    #region ValueSet: Pregnant State
    [CqlValueSetDefinition(
        definitionName: "Pregnant State",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055",
        valueSetVersion: null)]
    public CqlValueSet Pregnant_State(CqlContext context) => _Pregnant_State;

    private static readonly CqlValueSet _Pregnant_State = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", null);
    #endregion

    #region ValueSet: STEMI
    [CqlValueSetDefinition(
        definitionName: "STEMI",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017",
        valueSetVersion: null)]
    public CqlValueSet STEMI(CqlContext context) => _STEMI;

    private static readonly CqlValueSet _STEMI = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", null);
    #endregion

    #region ValueSet: Thrombolytic medications
    [CqlValueSetDefinition(
        definitionName: "Thrombolytic medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4",
        valueSetVersion: null)]
    public CqlValueSet Thrombolytic_medications(CqlContext context) => _Thrombolytic_medications;

    private static readonly CqlValueSet _Thrombolytic_medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Birthdate
    [CqlCodeDefinition(
        definitionName: "Birthdate",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birthdate(CqlContext context) => _Birthdate;

    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Emergency Department
    [CqlCodeDefinition(
        definitionName: "Emergency Department",
        codeId: "1108-0",
        codeSystem: "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html")]
    public CqlCode Emergency_Department(CqlContext context) => _Emergency_Department;

    private static readonly CqlCode _Emergency_Department = new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", default, default);
    #endregion

    #region Code: Patient transfer (procedure)
    [CqlCodeDefinition(
        definitionName: "Patient transfer (procedure)",
        codeId: "107724000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Patient_transfer__procedure_(CqlContext context) => _Patient_transfer__procedure_;

    private static readonly CqlCode _Patient_transfer__procedure_ = new CqlCode("107724000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Streptokinase adverse reaction (disorder)
    [CqlCodeDefinition(
        definitionName: "Streptokinase adverse reaction (disorder)",
        codeId: "293571007",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Streptokinase_adverse_reaction__disorder_(CqlContext context) => _Streptokinase_adverse_reaction__disorder_;

    private static readonly CqlCode _Streptokinase_adverse_reaction__disorder_ = new CqlCode("293571007", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: EMER
    [CqlCodeDefinition(
        definitionName: "EMER",
        codeId: "EMER",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode EMER(CqlContext context) => _EMER;

    private static readonly CqlCode _EMER = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility
    [CqlCodeDefinition(
        definitionName: "Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility",
        codeId: "Z92.82",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(CqlContext context) => _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility;

    private static readonly CqlCode _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility = new CqlCode("Z92.82", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
        ];

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "HSLOC")]
    public CqlCode[] HSLOC(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
            new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", default, default),
        ];

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("107724000", "http://snomed.info/sct", default, default),
            new CqlCode("293571007", "http://snomed.info/sct", default, default),
        ];

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
            new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] kzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
            new CqlCode("Z92.82", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
        object kzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("AppropriateTreatmentforSTEMIFHIR-1.2.000", "Measurement Period", kzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "ED Encounter During MP")]
    public IEnumerable<Encounter> ED_Encounter_During_MP(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EDEncounter)
        {
            Period kzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = lzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "finished");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Coding lzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EDEncounter?.Class;
            CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToCode(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.EMER(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(lzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "ED Encounter with Encounter Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.ED_Encounter_During_MP(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EDEncounter)
        {
            List<CodeableConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EDEncounter?.ReasonCode;
            CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzs_(CodeableConcept @this)
            {
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.STEMI(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, EDEncounter);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Condition EncDiagnosis)
            {
                CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncDiagnosis?.Code;
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.STEMI(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "ED Encounter with Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.ED_Encounter_During_MP(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter EDEncounter)
        {
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.STEMI(context);
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition DxSTEMI)
            {
                CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = DxSTEMI?.ClinicalStatus;
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.active(context);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(mzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                Period mzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Encounter mzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition DxSTEMI) =>
                EDEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Condition, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.ED_Encounter_with_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter EDwithSTEMI)
        {
            Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient(context);
            Date nzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Period nzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            int? nzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "year");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzzzzzzzzzzzo_, 18);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
    public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter EDwSTEMI)
        {
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Thrombolytic_medications(context);
            IEnumerable<AllergyIntolerance> nzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzw_(AllergyIntolerance ThrombolyticAllergy)
            {
                CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzzza_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzf_ = ThrombolyticAllergy?.Onset;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<AllergyIntolerance> nzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<AllergyIntolerance>(nzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzy_(AllergyIntolerance ThrombolyticAllergy) =>
                EDwSTEMI;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<AllergyIntolerance, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
    public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter EDwSTEMI)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Thrombolytics_Adverse_Event(context);
            IEnumerable<AdverseEvent> ozzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzr_(AdverseEvent ThrombolyticAdverseEvent)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                Code<AdverseEvent.AdverseEventActuality> pzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ThrombolyticAdverseEvent?.ActualityElement;
                AdverseEvent.AdverseEventActuality? pzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                Code<AdverseEvent.AdverseEventActuality> pzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "actual");
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<AdverseEvent> ozzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<AdverseEvent>(ozzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter ozzzzzzzzzzzzzzzzzzzzzzzzzzt_(AdverseEvent ThrombolyticAdverseEvent) =>
                EDwSTEMI;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<AdverseEvent, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Active Exclusion Diagnosis at Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter EDwithSTEMI)
        {
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(context);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Malignant_Intracranial_Neoplasm_Group(context);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Cerebral_Vascular_Lesion(context);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Dementia_and_Related_Intracranial_Pathologies(context);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Pregnant_State(context);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Allergy_to_thrombolytics(context);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition ActiveExclusionDx)
            {
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.OverlapsBefore(qzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Condition ActiveExclusionDx) =>
                EDwithSTEMI;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Condition, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Active Oral Anticoagulant Medication at the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter EDwithSTEMI)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzq_(MedicationRequest OralAnticoagulant)
            {
                Code<MedicationRequest.MedicationrequestStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "active");
                Code<MedicationRequest.MedicationRequestIntent> qzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzza_, "order");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                FhirDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(90m, "days");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzzzzzzs_(MedicationRequest OralAnticoagulant) =>
                EDwithSTEMI;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<MedicationRequest, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter EDwithSTEMI)
        {
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(context);
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Neurologic_impairment(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzg_(Condition ExclusionDiagnosis)
            {
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Period szzzzzzzzzzzzzzzzzzzzzzzzzzm_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, false);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter szzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition ExclusionDiagnosis) =>
                EDwithSTEMI;
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Condition, Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
    public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EDwithSTEMI)
        {
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure MajorSurgery)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = MajorSurgery?.Performed;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(21m, "days");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, false);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Code<EventStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = MajorSurgery?.StatusElement;
                EventStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "completed");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(tzzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Encounter tzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure MajorSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Procedure, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EDwithSTEMI)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Endotracheal_Intubation(context);
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure AirwayProcedure)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzza_ = AirwayProcedure?.Performed;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, false);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = AirwayProcedure?.StatusElement;
                EventStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "completed");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure AirwayProcedure) =>
                EDwithSTEMI;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter EDwSTEMI)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Ischemic_Stroke(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition ExclusionCondition)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(90m, "days");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Condition ExclusionCondition) =>
                EDwSTEMI;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Condition, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter EDwithSTEMI)
        {
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Intracranial_or_Intraspinal_surgery(context);
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Procedure CranialorSpinalSurgery)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CranialorSpinalSurgery?.Performed;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(90m, "days");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, false);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Code<EventStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CranialorSpinalSurgery?.StatusElement;
                EventStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(yzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "completed");
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure CranialorSpinalSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "ED Encounter with Discharge Disposition as Patient Expired")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter EDwithSTEMI)
        {
            Encounter.HospitalizationComponent yzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.DischargeDisposition;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient_Expired(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Received tPA in Another Facility within 24 hours Prior to Admission")]
    public IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter EDwithSTEMI)
        {
            CqlCode zzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition TPA)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzza_(Condition TPA) =>
                EDwithSTEMI;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Condition, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime currentemergencyDepartmentArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> azzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EDEncounter?.Location;
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter.LocationComponent EDLocation)
        {
            ResourceReference azzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EDLocation?.Location;
            Location azzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.GetLocation(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            List<CodeableConcept> azzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Type;
            CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzs_(CodeableConcept @this)
            {
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Emergency_Department_Visit(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter.LocationComponent> azzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)azzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        Encounter.LocationComponent azzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(azzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        Period azzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Period;
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Fibrinolytic Therapy within 30 Minutes of Arrival")]
    public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter EDwithSTEMI)
        {
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationAdministration>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(MedicationAdministration Fibrinolytic)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "completed");
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Fibrinolytic?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(30m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, false, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationAdministration> bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<MedicationAdministration>(bzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationAdministration Fibrinolytic) =>
                EDwithSTEMI;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<MedicationAdministration, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "PCI within 90 Minutes of Arrival")]
    public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EDwithSTEMI)
        {
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure PCI)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PCI?.Performed;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzr_, false, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Code<EventStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PCI?.StatusElement;
                EventStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "completed");
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter czzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure PCI) =>
                EDwithSTEMI;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
    public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter EDwithSTEMI)
        {
            Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(45m, "minutes");
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, false, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Encounter.HospitalizationComponent dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.DischargeDisposition;
            CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
