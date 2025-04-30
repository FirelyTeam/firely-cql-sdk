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

    [CqlValueSetDefinition("birth date", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext _) => _birth_date;
    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

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

    [CqlValueSetDefinition("Fibrinolytic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020", valueSetVersion: null)]
    public CqlValueSet Fibrinolytic_Therapy(CqlContext _) => _Fibrinolytic_Therapy;
    private static readonly CqlValueSet _Fibrinolytic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020", null);

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

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birthdate", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birthdate(CqlContext _) => _Birthdate;
    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Emergency Department", codeId: "1108-0", codeSystem: "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html")]
    public CqlCode Emergency_Department(CqlContext _) => _Emergency_Department;
    private static readonly CqlCode _Emergency_Department = new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", default, default);

    [CqlCodeDefinition("Patient transfer (procedure)", codeId: "107724000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Patient_transfer__procedure_(CqlContext _) => _Patient_transfer__procedure_;
    private static readonly CqlCode _Patient_transfer__procedure_ = new CqlCode("107724000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Streptokinase adverse reaction (disorder)", codeId: "293571007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Streptokinase_adverse_reaction__disorder_(CqlContext _) => _Streptokinase_adverse_reaction__disorder_;
    private static readonly CqlCode _Streptokinase_adverse_reaction__disorder_ = new CqlCode("293571007", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("EMER", codeId: "EMER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode EMER(CqlContext _) => _EMER;
    private static readonly CqlCode _EMER = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility", codeId: "Z92.82", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(CqlContext _) => _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility;
    private static readonly CqlCode _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility = new CqlCode("Z92.82", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("HSLOC")]
    public CqlCodeSystem HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem _HSLOC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzy_, true, true);
        object tzzzzzzzzzzzzzzzzzzzza_ = context.ResolveParameter("AppropriateTreatmentforSTEMIFHIR-1.2.000", "Measurement Period", szzzzzzzzzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzzzb_);

        return tzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("ED Encounter During MP")]
    public IEnumerable<Encounter> ED_Encounter_During_MP(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzd_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? tzzzzzzzzzzzzzzzzzzzzf_(Encounter EDEncounter)
        {
            Period tzzzzzzzzzzzzzzzzzzzzh_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? tzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzk_, "day");
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzzzzzzm_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? tzzzzzzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzzzzzzzzzzzzzzn_);
            bool? tzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzo_, "finished");
            bool? tzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzp_);
            Coding tzzzzzzzzzzzzzzzzzzzzr_ = EDEncounter?.Class;
            CqlCode tzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToCode(context, tzzzzzzzzzzzzzzzzzzzzr_);
            CqlCode tzzzzzzzzzzzzzzzzzzzzt_ = this.EMER(context);
            bool? tzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(tzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzt_);
            bool? tzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzu_);

            return tzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzf_);

        return tzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("ED Encounter with Encounter Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzw_ = this.ED_Encounter_During_MP(context);
        bool? tzzzzzzzzzzzzzzzzzzzzx_(Encounter EDEncounter)
        {
            List<CodeableConcept> tzzzzzzzzzzzzzzzzzzzzz_ = EDEncounter?.ReasonCode;
            CqlConcept uzzzzzzzzzzzzzzzzzzzza_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzc_ = this.STEMI(context);
            bool? uzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, EDEncounter);
            bool? uzzzzzzzzzzzzzzzzzzzzf_(Condition EncDiagnosis)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzzzk_ = EncDiagnosis?.Code;
                CqlConcept uzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzk_);
                CqlValueSet uzzzzzzzzzzzzzzzzzzzzm_ = this.STEMI(context);
                bool? uzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzm_);

                return uzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzf_);
            bool? uzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(uzzzzzzzzzzzzzzzzzzzzg_);
            bool? uzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzh_);

            return uzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzx_);

        return tzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("ED Encounter with Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzo_ = this.ED_Encounter_During_MP(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzp_(Encounter EDEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzr_ = this.STEMI(context);
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? uzzzzzzzzzzzzzzzzzzzzt_(Condition DxSTEMI)
            {
                CodeableConcept uzzzzzzzzzzzzzzzzzzzzx_ = DxSTEMI?.ClinicalStatus;
                CqlConcept uzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzx_);
                CqlCode uzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.active(context);
                CqlConcept vzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzzzzzz_);
                bool? vzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzc_);
                Period vzzzzzzzzzzzzzzzzzzzze_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzze_);
                bool? vzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzf_, default);
                bool? vzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzg_);

                return vzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> uzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzt_);
            Encounter uzzzzzzzzzzzzzzzzzzzzv_(Condition DxSTEMI) =>
                EDEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Condition, Encounter>(uzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzv_);

            return uzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzp_);

        return uzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzi_ = this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzj_ = this.ED_Encounter_with_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzj_);

        return vzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzl_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? vzzzzzzzzzzzzzzzzzzzzm_(Encounter EDwithSTEMI)
        {
            Patient vzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
            Date vzzzzzzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzzzzzzzp_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzq_);
            Period vzzzzzzzzzzzzzzzzzzzzs_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzu_);
            int? vzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzv_, "year");
            bool? vzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzzzzzw_, 18);

            return vzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzm_);

        return vzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return vzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
    public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzz_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzza_(Encounter EDwSTEMI)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzc_ = this.Thrombolytic_medications(context);
            IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
            bool? wzzzzzzzzzzzzzzzzzzzze_(AllergyIntolerance ThrombolyticAllergy)
            {
                CodeableConcept wzzzzzzzzzzzzzzzzzzzzi_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept wzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzi_);
                CqlCode wzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
                CqlConcept wzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzzzzzzzk_);
                bool? wzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzl_);
                DataType wzzzzzzzzzzzzzzzzzzzzn_ = ThrombolyticAllergy?.Onset;
                object wzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzo_);
                Period wzzzzzzzzzzzzzzzzzzzzq_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzq_);
                bool? wzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Overlaps(wzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzr_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzs_);

                return wzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<AllergyIntolerance> wzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<AllergyIntolerance>(wzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzze_);
            Encounter wzzzzzzzzzzzzzzzzzzzzg_(AllergyIntolerance ThrombolyticAllergy) =>
                EDwSTEMI;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<AllergyIntolerance, Encounter>(wzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzg_);

            return wzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzza_);

        return wzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
    public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzu_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzv_(Encounter EDwSTEMI)
        {
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzx_ = this.Thrombolytics_Adverse_Event(context);
            IEnumerable<AdverseEvent> wzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? wzzzzzzzzzzzzzzzzzzzzz_(AdverseEvent ThrombolyticAdverseEvent)
            {
                FhirDateTime xzzzzzzzzzzzzzzzzzzzzd_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzd_);
                Period xzzzzzzzzzzzzzzzzzzzzf_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzg_);
                bool? xzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Before(xzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<AdverseEvent.AdverseEventActuality> xzzzzzzzzzzzzzzzzzzzzj_ = ThrombolyticAdverseEvent?.ActualityElement;
                AdverseEvent.AdverseEventActuality? xzzzzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzzzzj_?.Value;
                Code<AdverseEvent.AdverseEventActuality> xzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(xzzzzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzl_, "actual");
                bool? xzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzm_);

                return xzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<AdverseEvent> xzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<AdverseEvent>(wzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzz_);
            Encounter xzzzzzzzzzzzzzzzzzzzzb_(AdverseEvent ThrombolyticAdverseEvent) =>
                EDwSTEMI;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<AdverseEvent, Encounter>(xzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzb_);

            return xzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzv_);

        return wzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis at Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzo_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzp_(Encounter EDwithSTEMI)
        {
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzr_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzt_ = this.Malignant_Intracranial_Neoplasm_Group(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzw_ = this.Cerebral_Vascular_Lesion(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzy_ = this.Dementia_and_Related_Intracranial_Pathologies(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzc_ = this.Pregnant_State(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet yzzzzzzzzzzzzzzzzzzzze_ = this.Allergy_to_thrombolytics(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzg_);
            bool? yzzzzzzzzzzzzzzzzzzzzi_(Condition ActiveExclusionDx)
            {
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period yzzzzzzzzzzzzzzzzzzzzn_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzn_);
                bool? yzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.OverlapsBefore(yzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzo_, default);

                return yzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzi_);
            Encounter yzzzzzzzzzzzzzzzzzzzzk_(Condition ActiveExclusionDx) =>
                EDwithSTEMI;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Condition, Encounter>(yzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzk_);

            return yzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzp_);

        return xzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzq_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzr_(Encounter EDwithSTEMI)
        {
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzt_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzw_);
            bool? yzzzzzzzzzzzzzzzzzzzzy_(MedicationRequest OralAnticoagulant)
            {
                Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzzzzzzzzzzc_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzzzzc_?.Value;
                string zzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzd_);
                bool? zzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzze_, "active");
                Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzzzzzzzzzzg_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? zzzzzzzzzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzh_);
                bool? zzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzzi_, "order");
                bool? zzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzj_);
                FhirDateTime zzzzzzzzzzzzzzzzzzzzzl_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzl_);
                Period zzzzzzzzzzzzzzzzzzzzzn_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(90m, "days");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzv_, default);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzy_);
                bool? azzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzb_);

                return azzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzy_);
            Encounter zzzzzzzzzzzzzzzzzzzzza_(MedicationRequest OralAnticoagulant) =>
                EDwithSTEMI;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<MedicationRequest, Encounter>(yzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzza_);

            return zzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzr_);

        return yzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzd_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzze_(Encounter EDwithSTEMI)
        {
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzg_ = this.Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzi_ = this.Neurologic_impairment(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzl_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzm_);
            bool? azzzzzzzzzzzzzzzzzzzzzo_(Condition ExclusionDiagnosis)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzs_);
                Period azzzzzzzzzzzzzzzzzzzzzu_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzu_);
                bool? azzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzv_, default);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzg_, true, false);
                bool? bzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzh_, default);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzl_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzm_);
                bool? bzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzn_);

                return bzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzo_);
            Encounter azzzzzzzzzzzzzzzzzzzzzq_(Condition ExclusionDiagnosis) =>
                EDwithSTEMI;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Condition, Encounter>(azzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzq_);

            return azzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzze_);

        return azzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
    public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzp_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzq_(Encounter EDwithSTEMI)
        {
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzs_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? bzzzzzzzzzzzzzzzzzzzzzu_(Procedure MajorSurgery)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzy_ = MajorSurgery?.Performed;
                object bzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzza_);
                Period czzzzzzzzzzzzzzzzzzzzzc_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(21m, "days");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzj_, true, false);
                bool? czzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzk_, default);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzn_);
                bool? czzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzp_);
                Code<EventStatus> czzzzzzzzzzzzzzzzzzzzzr_ = MajorSurgery?.StatusElement;
                EventStatus? czzzzzzzzzzzzzzzzzzzzzs_ = czzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string czzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzs_);
                bool? czzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzzzzzt_, "completed");
                bool? czzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzu_);

                return czzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter bzzzzzzzzzzzzzzzzzzzzzw_(Procedure MajorSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, Encounter>(bzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzw_);

            return bzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzq_);

        return bzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzw_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzx_(Encounter EDwithSTEMI)
        {
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzz_ = this.Endotracheal_Intubation(context);
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzb_ = this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Procedure>(dzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzzzzzzzzzze_(Procedure AirwayProcedure)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzi_ = AirwayProcedure?.Performed;
                object dzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzk_);
                Period dzzzzzzzzzzzzzzzzzzzzzm_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzm_);
                bool? dzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzn_, default);
                object dzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzza_, true, false);
                bool? ezzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzb_, default);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzze_);
                bool? ezzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzg_);
                bool? ezzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzh_);
                Code<EventStatus> ezzzzzzzzzzzzzzzzzzzzzj_ = AirwayProcedure?.StatusElement;
                EventStatus? ezzzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string ezzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzk_);
                bool? ezzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzl_, "completed");
                bool? ezzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzm_);

                return ezzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzze_);
            Encounter dzzzzzzzzzzzzzzzzzzzzzg_(Procedure AirwayProcedure) =>
                EDwithSTEMI;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Procedure, Encounter>(dzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzg_);

            return dzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzo_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzp_(Encounter EDwSTEMI)
        {
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzr_ = this.Ischemic_Stroke(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzt_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzu_);
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzw_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzy_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzza_);
            bool? fzzzzzzzzzzzzzzzzzzzzzc_(Condition ExclusionCondition)
            {
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzg_);
                Period fzzzzzzzzzzzzzzzzzzzzzi_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(90m, "days");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzq_, default);

                return fzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzc_);
            Encounter fzzzzzzzzzzzzzzzzzzzzze_(Condition ExclusionCondition) =>
                EDwSTEMI;
            IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Condition, Encounter>(fzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzze_);

            return fzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzp_);

        return ezzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzs_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzt_(Encounter EDwithSTEMI)
        {
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzv_ = this.Intracranial_or_Intraspinal_surgery(context);
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? fzzzzzzzzzzzzzzzzzzzzzx_(Procedure CranialorSpinalSurgery)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzb_ = CranialorSpinalSurgery?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzd_);
                Period gzzzzzzzzzzzzzzzzzzzzzf_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(90m, "days");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzm_, true, false);
                bool? gzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzn_, default);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzq_);
                bool? gzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzs_);
                Code<EventStatus> gzzzzzzzzzzzzzzzzzzzzzu_ = CranialorSpinalSurgery?.StatusElement;
                EventStatus? gzzzzzzzzzzzzzzzzzzzzzv_ = gzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzv_);
                bool? gzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzw_, "completed");
                bool? gzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzx_);

                return gzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzx_);
            Encounter fzzzzzzzzzzzzzzzzzzzzzz_(Procedure CranialorSpinalSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Procedure, Encounter>(fzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzz_);

            return gzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Patient Expired")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzz_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? hzzzzzzzzzzzzzzzzzzzzza_(Encounter EDwithSTEMI)
        {
            Encounter.HospitalizationComponent hzzzzzzzzzzzzzzzzzzzzzc_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept hzzzzzzzzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzzzzzzzzc_?.DischargeDisposition;
            CqlConcept hzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzf_ = this.Patient_Expired(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzf_);

            return hzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzza_);

        return hzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzh_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzi_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzk_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzl_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzo_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzp_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzs_ = this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzt_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzw_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzx_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzy_);

        return hzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Received tPA in Another Facility within 24 hours Prior to Admission")]
    public IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzza_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzb_(Encounter EDwithSTEMI)
        {
            CqlCode izzzzzzzzzzzzzzzzzzzzzd_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? izzzzzzzzzzzzzzzzzzzzzg_(Condition TPA)
            {
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzk_);
                Period izzzzzzzzzzzzzzzzzzzzzm_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzm_);
                bool? izzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzn_, default);

                return izzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzg_);
            Encounter izzzzzzzzzzzzzzzzzzzzzi_(Condition TPA) =>
                EDwithSTEMI;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Condition, Encounter>(izzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzi_);

            return izzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzb_);

        return izzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzp_ = this.Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(context);

        return izzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("currentemergencyDepartmentArrivalTime")]
    public CqlDateTime currentemergencyDepartmentArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> izzzzzzzzzzzzzzzzzzzzzq_ = EDEncounter?.Location;
        bool? izzzzzzzzzzzzzzzzzzzzzr_(Encounter.LocationComponent EDLocation)
        {
            ResourceReference izzzzzzzzzzzzzzzzzzzzzx_ = EDLocation?.Location;
            Location izzzzzzzzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.GetLocation(context, izzzzzzzzzzzzzzzzzzzzzx_);
            List<CodeableConcept> izzzzzzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzzzzzy_?.Type;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzza_(CodeableConcept @this)
            {
                CqlConcept jzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return jzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzza_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzc_ = this.Emergency_Department_Visit(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(jzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzc_);

            return jzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter.LocationComponent> izzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)izzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzr_);
        Encounter.LocationComponent izzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(izzzzzzzzzzzzzzzzzzzzzs_);
        Period izzzzzzzzzzzzzzzzzzzzzu_ = izzzzzzzzzzzzzzzzzzzzzt_?.Period;
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzu_);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzv_);

        return izzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Fibrinolytic Therapy within 30 Minutes of Arrival")]
    public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzf_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzg_(Encounter EDwithSTEMI)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzi_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationAdministration>(jzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzl_);
            bool? jzzzzzzzzzzzzzzzzzzzzzn_(MedicationAdministration Fibrinolytic)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> jzzzzzzzzzzzzzzzzzzzzzr_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? jzzzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> jzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(jzzzzzzzzzzzzzzzzzzzzzs_);
                bool? jzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzt_, "completed");
                DataType jzzzzzzzzzzzzzzzzzzzzzv_ = Fibrinolytic?.Effective;
                object jzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzz_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(30m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzc_, false, true);
                bool? kzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzd_, default);
                bool? kzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzg_);
                bool? kzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzh_);

                return kzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<MedicationAdministration> jzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<MedicationAdministration>(jzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter jzzzzzzzzzzzzzzzzzzzzzp_(MedicationAdministration Fibrinolytic) =>
                EDwithSTEMI;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<MedicationAdministration, Encounter>(jzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzp_);

            return jzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzg_);

        return jzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("PCI within 90 Minutes of Arrival")]
    public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzj_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzk_(Encounter EDwithSTEMI)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzm_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? kzzzzzzzzzzzzzzzzzzzzzo_(Procedure PCI)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzs_ = PCI?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzw_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzz_, false, true);
                bool? lzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzza_, default);
                bool? lzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzw_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzd_);
                Code<EventStatus> lzzzzzzzzzzzzzzzzzzzzzf_ = PCI?.StatusElement;
                EventStatus? lzzzzzzzzzzzzzzzzzzzzzg_ = lzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzg_);
                bool? lzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzh_, "completed");
                bool? lzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzi_);

                return lzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzo_);
            Encounter kzzzzzzzzzzzzzzzzzzzzzq_(Procedure PCI) =>
                EDwithSTEMI;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, Encounter>(kzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzq_);

            return kzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
    public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzk_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzl_(Encounter EDwithSTEMI)
        {
            Period lzzzzzzzzzzzzzzzzzzzzzn_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(45m, "minutes");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzx_, false, true);
            bool? lzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzy_, default);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzb_);
            bool? mzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzd_);
            Encounter.HospitalizationComponent mzzzzzzzzzzzzzzzzzzzzzf_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept mzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzf_?.DischargeDisposition;
            CqlConcept mzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzg_);
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzi_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzj_);

            return mzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzl_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzm_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzo_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzo_);

        return mzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
