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
    private static readonly CqlCode _Birthdate = new CqlCode("21112-8", "http://loinc.org");

    [CqlCodeDefinition("Emergency Department", codeId: "1108-0", codeSystem: "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html")]
    public CqlCode Emergency_Department(CqlContext _) => _Emergency_Department;
    private static readonly CqlCode _Emergency_Department = new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html");

    [CqlCodeDefinition("Patient transfer (procedure)", codeId: "107724000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Patient_transfer__procedure_(CqlContext _) => _Patient_transfer__procedure_;
    private static readonly CqlCode _Patient_transfer__procedure_ = new CqlCode("107724000", "http://snomed.info/sct");

    [CqlCodeDefinition("Streptokinase adverse reaction (disorder)", codeId: "293571007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Streptokinase_adverse_reaction__disorder_(CqlContext _) => _Streptokinase_adverse_reaction__disorder_;
    private static readonly CqlCode _Streptokinase_adverse_reaction__disorder_ = new CqlCode("293571007", "http://snomed.info/sct");

    [CqlCodeDefinition("EMER", codeId: "EMER", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode EMER(CqlContext _) => _EMER;
    private static readonly CqlCode _EMER = new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    [CqlCodeDefinition("Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility", codeId: "Z92.82", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(CqlContext _) => _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility;
    private static readonly CqlCode _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility = new CqlCode("Z92.82", "http://hl7.org/fhir/sid/icd-10-cm");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Birthdate);

    [CqlCodeSystemDefinition("HSLOC")]
    public CqlCodeSystem HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem _HSLOC =
      new CqlCodeSystem("https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", null,
          _Emergency_Department);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Patient_transfer__procedure_,
          _Streptokinase_adverse_reaction__disorder_);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null,
          _EMER);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null,
          _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime yzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzo_ = context.Operators.Interval(yzzzzzzzzm_, yzzzzzzzzn_, true, true);
        object yzzzzzzzzp_ = context.ResolveParameter("AppropriateTreatmentforSTEMIFHIR-1.2.000", "Measurement Period", yzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzq_);

        return yzzzzzzzzr_;
    }


    [CqlExpressionDefinition("ED Encounter During MP")]
    public IEnumerable<Encounter> ED_Encounter_During_MP(CqlContext context)
    {
        CqlValueSet yzzzzzzzzs_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? yzzzzzzzzu_(Encounter EDEncounter)
        {
            Period yzzzzzzzzw_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzw_);
            CqlDateTime yzzzzzzzzy_ = context.Operators.End(yzzzzzzzzx_);
            CqlInterval<CqlDateTime> yzzzzzzzzz_ = this.Measurement_Period(context);
            bool? zzzzzzzzza_ = context.Operators.In<CqlDateTime>(yzzzzzzzzy_, yzzzzzzzzz_, "day");
            Code<Encounter.EncounterStatus> zzzzzzzzzb_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? zzzzzzzzzc_ = zzzzzzzzzb_?.Value;
            Code<Encounter.EncounterStatus> zzzzzzzzzd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzc_);
            bool? zzzzzzzzze_ = context.Operators.Equal(zzzzzzzzzd_, "finished");
            bool? zzzzzzzzzf_ = context.Operators.And(zzzzzzzzza_, zzzzzzzzze_);
            Coding zzzzzzzzzg_ = EDEncounter?.Class;
            CqlCode zzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToCode(context, zzzzzzzzzg_);
            CqlCode zzzzzzzzzi_ = this.EMER(context);
            bool? zzzzzzzzzj_ = context.Operators.Equivalent(zzzzzzzzzh_, zzzzzzzzzi_);
            bool? zzzzzzzzzk_ = context.Operators.And(zzzzzzzzzf_, zzzzzzzzzj_);

            return zzzzzzzzzk_;
        };
        IEnumerable<Encounter> yzzzzzzzzv_ = context.Operators.Where<Encounter>(yzzzzzzzzt_, yzzzzzzzzu_);

        return yzzzzzzzzv_;
    }


    [CqlExpressionDefinition("ED Encounter with Encounter Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzl_ = this.ED_Encounter_During_MP(context);
        bool? zzzzzzzzzm_(Encounter EDEncounter)
        {
            List<CodeableConcept> zzzzzzzzzo_ = EDEncounter?.ReasonCode;
            CqlConcept zzzzzzzzzp_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzy_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzo_, zzzzzzzzzp_);
            CqlValueSet zzzzzzzzzr_ = this.STEMI(context);
            bool? zzzzzzzzzs_ = context.Operators.ConceptsInValueSet(zzzzzzzzzq_, zzzzzzzzzr_);
            IEnumerable<Condition> zzzzzzzzzt_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, EDEncounter);
            bool? zzzzzzzzzu_(Condition EncDiagnosis)
            {
                CodeableConcept zzzzzzzzzz_ = EncDiagnosis?.Code;
                CqlConcept azzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzz_);
                CqlValueSet azzzzzzzzzb_ = this.STEMI(context);
                bool? azzzzzzzzzc_ = context.Operators.ConceptInValueSet(azzzzzzzzza_, azzzzzzzzzb_);

                return azzzzzzzzzc_;
            };
            IEnumerable<Condition> zzzzzzzzzv_ = context.Operators.Where<Condition>(zzzzzzzzzt_, zzzzzzzzzu_);
            bool? zzzzzzzzzw_ = context.Operators.Exists<Condition>(zzzzzzzzzv_);
            bool? zzzzzzzzzx_ = context.Operators.Or(zzzzzzzzzs_, zzzzzzzzzw_);

            return zzzzzzzzzx_;
        };
        IEnumerable<Encounter> zzzzzzzzzn_ = context.Operators.Where<Encounter>(zzzzzzzzzl_, zzzzzzzzzm_);

        return zzzzzzzzzn_;
    }


    [CqlExpressionDefinition("ED Encounter with Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzd_ = this.ED_Encounter_During_MP(context);
        IEnumerable<Encounter> azzzzzzzzze_(Encounter EDEncounter)
        {
            CqlValueSet azzzzzzzzzg_ = this.STEMI(context);
            IEnumerable<Condition> azzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? azzzzzzzzzi_(Condition DxSTEMI)
            {
                CodeableConcept azzzzzzzzzm_ = DxSTEMI?.ClinicalStatus;
                CqlConcept azzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzm_);
                CqlCode azzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.active(context);
                CqlConcept azzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzo_);
                bool? azzzzzzzzzq_ = context.Operators.Equivalent(azzzzzzzzzn_, azzzzzzzzzp_);
                CqlInterval<CqlDateTime> azzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime azzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzr_);
                Period azzzzzzzzzt_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzt_);
                bool? azzzzzzzzzv_ = context.Operators.In<CqlDateTime>(azzzzzzzzzs_, azzzzzzzzzu_, default);
                bool? azzzzzzzzzw_ = context.Operators.And(azzzzzzzzzq_, azzzzzzzzzv_);

                return azzzzzzzzzw_;
            };
            IEnumerable<Condition> azzzzzzzzzj_ = context.Operators.Where<Condition>(azzzzzzzzzh_, azzzzzzzzzi_);
            Encounter azzzzzzzzzk_(Condition DxSTEMI) =>
                EDEncounter;
            IEnumerable<Encounter> azzzzzzzzzl_ = context.Operators.Select<Condition, Encounter>(azzzzzzzzzj_, azzzzzzzzzk_);

            return azzzzzzzzzl_;
        };
        IEnumerable<Encounter> azzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzd_, azzzzzzzzze_);

        return azzzzzzzzzf_;
    }


    [CqlExpressionDefinition("ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzx_ = this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> azzzzzzzzzy_ = this.ED_Encounter_with_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> azzzzzzzzzz_ = context.Operators.Union<Encounter>(azzzzzzzzzx_, azzzzzzzzzy_);

        return azzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzza_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? bzzzzzzzzzb_(Encounter EDwithSTEMI)
        {
            Patient bzzzzzzzzzd_ = this.Patient(context);
            Date bzzzzzzzzze_ = bzzzzzzzzzd_?.BirthDateElement;
            string bzzzzzzzzzf_ = bzzzzzzzzze_?.Value;
            CqlDate bzzzzzzzzzg_ = context.Operators.ConvertStringToDate(bzzzzzzzzzf_);
            Period bzzzzzzzzzh_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzh_);
            CqlDateTime bzzzzzzzzzj_ = context.Operators.Start(bzzzzzzzzzi_);
            CqlDate bzzzzzzzzzk_ = context.Operators.DateFrom(bzzzzzzzzzj_);
            int? bzzzzzzzzzl_ = context.Operators.CalculateAgeAt(bzzzzzzzzzg_, bzzzzzzzzzk_, "year");
            bool? bzzzzzzzzzm_ = context.Operators.GreaterOrEqual(bzzzzzzzzzl_, 18);

            return bzzzzzzzzzm_;
        };
        IEnumerable<Encounter> bzzzzzzzzzc_ = context.Operators.Where<Encounter>(bzzzzzzzzza_, bzzzzzzzzzb_);

        return bzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzn_ = this.Initial_Population(context);

        return bzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
    public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzo_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> bzzzzzzzzzp_(Encounter EDwSTEMI)
        {
            CqlValueSet bzzzzzzzzzr_ = this.Thrombolytic_medications(context);
            IEnumerable<AllergyIntolerance> bzzzzzzzzzs_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, bzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
            bool? bzzzzzzzzzt_(AllergyIntolerance ThrombolyticAllergy)
            {
                CodeableConcept bzzzzzzzzzx_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept bzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzx_);
                CqlCode bzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
                CqlConcept czzzzzzzzza_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzz_);
                bool? czzzzzzzzzb_ = context.Operators.Equivalent(bzzzzzzzzzy_, czzzzzzzzza_);
                DataType czzzzzzzzzc_ = ThrombolyticAllergy?.Onset;
                object czzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzc_);
                CqlInterval<CqlDateTime> czzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzd_);
                Period czzzzzzzzzf_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzf_);
                bool? czzzzzzzzzh_ = context.Operators.Overlaps(czzzzzzzzze_, czzzzzzzzzg_, default);
                bool? czzzzzzzzzi_ = context.Operators.And(czzzzzzzzzb_, czzzzzzzzzh_);

                return czzzzzzzzzi_;
            };
            IEnumerable<AllergyIntolerance> bzzzzzzzzzu_ = context.Operators.Where<AllergyIntolerance>(bzzzzzzzzzs_, bzzzzzzzzzt_);
            Encounter bzzzzzzzzzv_(AllergyIntolerance ThrombolyticAllergy) =>
                EDwSTEMI;
            IEnumerable<Encounter> bzzzzzzzzzw_ = context.Operators.Select<AllergyIntolerance, Encounter>(bzzzzzzzzzu_, bzzzzzzzzzv_);

            return bzzzzzzzzzw_;
        };
        IEnumerable<Encounter> bzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzo_, bzzzzzzzzzp_);

        return bzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
    public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzj_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> czzzzzzzzzk_(Encounter EDwSTEMI)
        {
            CqlValueSet czzzzzzzzzm_ = this.Thrombolytics_Adverse_Event(context);
            IEnumerable<AdverseEvent> czzzzzzzzzn_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, czzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? czzzzzzzzzo_(AdverseEvent ThrombolyticAdverseEvent)
            {
                FhirDateTime czzzzzzzzzs_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime czzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzs_);
                Period czzzzzzzzzu_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzu_);
                CqlDateTime czzzzzzzzzw_ = context.Operators.End(czzzzzzzzzv_);
                bool? czzzzzzzzzx_ = context.Operators.Before(czzzzzzzzzt_, czzzzzzzzzw_, default);
                Code<AdverseEvent.AdverseEventActuality> czzzzzzzzzy_ = ThrombolyticAdverseEvent?.ActualityElement;
                AdverseEvent.AdverseEventActuality? czzzzzzzzzz_ = czzzzzzzzzy_?.Value;
                Code<AdverseEvent.AdverseEventActuality> dzzzzzzzzza_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(czzzzzzzzzz_);
                bool? dzzzzzzzzzb_ = context.Operators.Equal(dzzzzzzzzza_, "actual");
                bool? dzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzx_, dzzzzzzzzzb_);

                return dzzzzzzzzzc_;
            };
            IEnumerable<AdverseEvent> czzzzzzzzzp_ = context.Operators.Where<AdverseEvent>(czzzzzzzzzn_, czzzzzzzzzo_);
            Encounter czzzzzzzzzq_(AdverseEvent ThrombolyticAdverseEvent) =>
                EDwSTEMI;
            IEnumerable<Encounter> czzzzzzzzzr_ = context.Operators.Select<AdverseEvent, Encounter>(czzzzzzzzzp_, czzzzzzzzzq_);

            return czzzzzzzzzr_;
        };
        IEnumerable<Encounter> czzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzj_, czzzzzzzzzk_);

        return czzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis at Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzd_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> dzzzzzzzzze_(Encounter EDwithSTEMI)
        {
            CqlValueSet dzzzzzzzzzg_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(context);
            IEnumerable<Condition> dzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzi_ = this.Malignant_Intracranial_Neoplasm_Group(context);
            IEnumerable<Condition> dzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzzzzzk_ = context.Operators.Union<Condition>(dzzzzzzzzzh_, dzzzzzzzzzj_);
            CqlValueSet dzzzzzzzzzl_ = this.Cerebral_Vascular_Lesion(context);
            IEnumerable<Condition> dzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzn_ = this.Dementia_and_Related_Intracranial_Pathologies(context);
            IEnumerable<Condition> dzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzzzzzp_ = context.Operators.Union<Condition>(dzzzzzzzzzm_, dzzzzzzzzzo_);
            IEnumerable<Condition> dzzzzzzzzzq_ = context.Operators.Union<Condition>(dzzzzzzzzzk_, dzzzzzzzzzp_);
            CqlValueSet dzzzzzzzzzr_ = this.Pregnant_State(context);
            IEnumerable<Condition> dzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet dzzzzzzzzzt_ = this.Allergy_to_thrombolytics(context);
            IEnumerable<Condition> dzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> dzzzzzzzzzv_ = context.Operators.Union<Condition>(dzzzzzzzzzs_, dzzzzzzzzzu_);
            IEnumerable<Condition> dzzzzzzzzzw_ = context.Operators.Union<Condition>(dzzzzzzzzzq_, dzzzzzzzzzv_);
            bool? dzzzzzzzzzx_(Condition ActiveExclusionDx)
            {
                CqlInterval<CqlDateTime> ezzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period ezzzzzzzzzc_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzc_);
                bool? ezzzzzzzzze_ = context.Operators.OverlapsBefore(ezzzzzzzzzb_, ezzzzzzzzzd_, default);

                return ezzzzzzzzze_;
            };
            IEnumerable<Condition> dzzzzzzzzzy_ = context.Operators.Where<Condition>(dzzzzzzzzzw_, dzzzzzzzzzx_);
            Encounter dzzzzzzzzzz_(Condition ActiveExclusionDx) =>
                EDwithSTEMI;
            IEnumerable<Encounter> ezzzzzzzzza_ = context.Operators.Select<Condition, Encounter>(dzzzzzzzzzy_, dzzzzzzzzzz_);

            return ezzzzzzzzza_;
        };
        IEnumerable<Encounter> dzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzd_, dzzzzzzzzze_);

        return dzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzf_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> ezzzzzzzzzg_(Encounter EDwithSTEMI)
        {
            CqlValueSet ezzzzzzzzzi_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> ezzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ezzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ezzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> ezzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(ezzzzzzzzzj_, ezzzzzzzzzl_);
            bool? ezzzzzzzzzn_(MedicationRequest OralAnticoagulant)
            {
                Code<MedicationRequest.MedicationrequestStatus> ezzzzzzzzzr_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ezzzzzzzzzs_ = ezzzzzzzzzr_?.Value;
                string ezzzzzzzzzt_ = context.Operators.Convert<string>(ezzzzzzzzzs_);
                bool? ezzzzzzzzzu_ = context.Operators.Equal(ezzzzzzzzzt_, "active");
                Code<MedicationRequest.MedicationRequestIntent> ezzzzzzzzzv_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ezzzzzzzzzw_ = ezzzzzzzzzv_?.Value;
                string ezzzzzzzzzx_ = context.Operators.Convert<string>(ezzzzzzzzzw_);
                bool? ezzzzzzzzzy_ = context.Operators.Equal(ezzzzzzzzzx_, "order");
                bool? ezzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzu_, ezzzzzzzzzy_);
                FhirDateTime fzzzzzzzzza_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzza_);
                Period fzzzzzzzzzc_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzc_);
                CqlDateTime fzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzd_);
                CqlQuantity fzzzzzzzzzf_ = context.Operators.Quantity(90m, "days");
                CqlDateTime fzzzzzzzzzg_ = context.Operators.Subtract(fzzzzzzzzze_, fzzzzzzzzzf_);
                CqlInterval<CqlDateTime> fzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzc_);
                CqlDateTime fzzzzzzzzzj_ = context.Operators.Start(fzzzzzzzzzi_);
                CqlInterval<CqlDateTime> fzzzzzzzzzk_ = context.Operators.Interval(fzzzzzzzzzg_, fzzzzzzzzzj_, true, true);
                bool? fzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzb_, fzzzzzzzzzk_, default);
                CqlInterval<CqlDateTime> fzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzc_);
                CqlDateTime fzzzzzzzzzo_ = context.Operators.Start(fzzzzzzzzzn_);
                bool? fzzzzzzzzzp_ = context.Operators.Not((bool?)(fzzzzzzzzzo_ is null));
                bool? fzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzl_, fzzzzzzzzzp_);
                bool? fzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzz_, fzzzzzzzzzq_);

                return fzzzzzzzzzr_;
            };
            IEnumerable<MedicationRequest> ezzzzzzzzzo_ = context.Operators.Where<MedicationRequest>(ezzzzzzzzzm_, ezzzzzzzzzn_);
            Encounter ezzzzzzzzzp_(MedicationRequest OralAnticoagulant) =>
                EDwithSTEMI;
            IEnumerable<Encounter> ezzzzzzzzzq_ = context.Operators.Select<MedicationRequest, Encounter>(ezzzzzzzzzo_, ezzzzzzzzzp_);

            return ezzzzzzzzzq_;
        };
        IEnumerable<Encounter> ezzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzf_, ezzzzzzzzzg_);

        return ezzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzs_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> fzzzzzzzzzt_(Encounter EDwithSTEMI)
        {
            CqlValueSet fzzzzzzzzzv_ = this.Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(context);
            IEnumerable<Condition> fzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet fzzzzzzzzzx_ = this.Neurologic_impairment(context);
            IEnumerable<Condition> fzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> fzzzzzzzzzz_ = context.Operators.Union<Condition>(fzzzzzzzzzw_, fzzzzzzzzzy_);
            CqlValueSet gzzzzzzzzza_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> gzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> gzzzzzzzzzc_ = context.Operators.Union<Condition>(fzzzzzzzzzz_, gzzzzzzzzzb_);
            bool? gzzzzzzzzzd_(Condition ExclusionDiagnosis)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime gzzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzzh_);
                Period gzzzzzzzzzj_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzj_);
                bool? gzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzi_, gzzzzzzzzzk_, default);
                CqlDateTime gzzzzzzzzzn_ = context.Operators.Start(gzzzzzzzzzh_);
                CqlInterval<CqlDateTime> gzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzp_);
                CqlQuantity gzzzzzzzzzr_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime gzzzzzzzzzs_ = context.Operators.Subtract(gzzzzzzzzzq_, gzzzzzzzzzr_);
                CqlInterval<CqlDateTime> gzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzv_ = context.Operators.Start(gzzzzzzzzzu_);
                CqlInterval<CqlDateTime> gzzzzzzzzzw_ = context.Operators.Interval(gzzzzzzzzzs_, gzzzzzzzzzv_, true, false);
                bool? gzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzn_, gzzzzzzzzzw_, default);
                CqlInterval<CqlDateTime> gzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzj_);
                CqlDateTime hzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzz_);
                bool? hzzzzzzzzzb_ = context.Operators.Not((bool?)(hzzzzzzzzza_ is null));
                bool? hzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzx_, hzzzzzzzzzb_);
                bool? hzzzzzzzzzd_ = context.Operators.Or(gzzzzzzzzzl_, hzzzzzzzzzc_);

                return hzzzzzzzzzd_;
            };
            IEnumerable<Condition> gzzzzzzzzze_ = context.Operators.Where<Condition>(gzzzzzzzzzc_, gzzzzzzzzzd_);
            Encounter gzzzzzzzzzf_(Condition ExclusionDiagnosis) =>
                EDwithSTEMI;
            IEnumerable<Encounter> gzzzzzzzzzg_ = context.Operators.Select<Condition, Encounter>(gzzzzzzzzze_, gzzzzzzzzzf_);

            return gzzzzzzzzzg_;
        };
        IEnumerable<Encounter> fzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzs_, fzzzzzzzzzt_);

        return fzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
    public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzze_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> hzzzzzzzzzf_(Encounter EDwithSTEMI)
        {
            CqlValueSet hzzzzzzzzzh_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure> hzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? hzzzzzzzzzj_(Procedure MajorSurgery)
            {
                DataType hzzzzzzzzzn_ = MajorSurgery?.Performed;
                object hzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzn_);
                CqlInterval<CqlDateTime> hzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzo_);
                CqlDateTime hzzzzzzzzzq_ = context.Operators.Start(hzzzzzzzzzp_);
                Period hzzzzzzzzzr_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzt_ = context.Operators.Start(hzzzzzzzzzs_);
                CqlQuantity hzzzzzzzzzu_ = context.Operators.Quantity(21m, "days");
                CqlDateTime hzzzzzzzzzv_ = context.Operators.Subtract(hzzzzzzzzzt_, hzzzzzzzzzu_);
                CqlInterval<CqlDateTime> hzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzy_ = context.Operators.Start(hzzzzzzzzzx_);
                CqlInterval<CqlDateTime> hzzzzzzzzzz_ = context.Operators.Interval(hzzzzzzzzzv_, hzzzzzzzzzy_, true, false);
                bool? izzzzzzzzza_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzq_, hzzzzzzzzzz_, default);
                CqlInterval<CqlDateTime> izzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzr_);
                CqlDateTime izzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzc_);
                bool? izzzzzzzzze_ = context.Operators.Not((bool?)(izzzzzzzzzd_ is null));
                bool? izzzzzzzzzf_ = context.Operators.And(izzzzzzzzza_, izzzzzzzzze_);
                Code<EventStatus> izzzzzzzzzg_ = MajorSurgery?.StatusElement;
                EventStatus? izzzzzzzzzh_ = izzzzzzzzzg_?.Value;
                string izzzzzzzzzi_ = context.Operators.Convert<string>(izzzzzzzzzh_);
                bool? izzzzzzzzzj_ = context.Operators.Equal(izzzzzzzzzi_, "completed");
                bool? izzzzzzzzzk_ = context.Operators.And(izzzzzzzzzf_, izzzzzzzzzj_);

                return izzzzzzzzzk_;
            };
            IEnumerable<Procedure> hzzzzzzzzzk_ = context.Operators.Where<Procedure>(hzzzzzzzzzi_, hzzzzzzzzzj_);
            Encounter hzzzzzzzzzl_(Procedure MajorSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> hzzzzzzzzzm_ = context.Operators.Select<Procedure, Encounter>(hzzzzzzzzzk_, hzzzzzzzzzl_);

            return hzzzzzzzzzm_;
        };
        IEnumerable<Encounter> hzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzze_, hzzzzzzzzzf_);

        return hzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzl_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> izzzzzzzzzm_(Encounter EDwithSTEMI)
        {
            CqlValueSet izzzzzzzzzo_ = this.Endotracheal_Intubation(context);
            IEnumerable<Procedure> izzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet izzzzzzzzzq_ = this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure> izzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> izzzzzzzzzs_ = context.Operators.Union<Procedure>(izzzzzzzzzp_, izzzzzzzzzr_);
            bool? izzzzzzzzzt_(Procedure AirwayProcedure)
            {
                DataType izzzzzzzzzx_ = AirwayProcedure?.Performed;
                object izzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzx_);
                CqlInterval<CqlDateTime> izzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzy_);
                CqlDateTime jzzzzzzzzza_ = context.Operators.Start(izzzzzzzzzz_);
                Period jzzzzzzzzzb_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzb_);
                bool? jzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(jzzzzzzzzza_, jzzzzzzzzzc_, default);
                object jzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzx_);
                CqlInterval<CqlDateTime> jzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzf_);
                CqlDateTime jzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzg_);
                CqlInterval<CqlDateTime> jzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzb_);
                CqlDateTime jzzzzzzzzzk_ = context.Operators.Start(jzzzzzzzzzj_);
                CqlQuantity jzzzzzzzzzl_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime jzzzzzzzzzm_ = context.Operators.Subtract(jzzzzzzzzzk_, jzzzzzzzzzl_);
                CqlInterval<CqlDateTime> jzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzb_);
                CqlDateTime jzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzo_);
                CqlInterval<CqlDateTime> jzzzzzzzzzq_ = context.Operators.Interval(jzzzzzzzzzm_, jzzzzzzzzzp_, true, false);
                bool? jzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzh_, jzzzzzzzzzq_, default);
                CqlInterval<CqlDateTime> jzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzb_);
                CqlDateTime jzzzzzzzzzu_ = context.Operators.Start(jzzzzzzzzzt_);
                bool? jzzzzzzzzzv_ = context.Operators.Not((bool?)(jzzzzzzzzzu_ is null));
                bool? jzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzr_, jzzzzzzzzzv_);
                bool? jzzzzzzzzzx_ = context.Operators.Or(jzzzzzzzzzd_, jzzzzzzzzzw_);
                Code<EventStatus> jzzzzzzzzzy_ = AirwayProcedure?.StatusElement;
                EventStatus? jzzzzzzzzzz_ = jzzzzzzzzzy_?.Value;
                string kzzzzzzzzza_ = context.Operators.Convert<string>(jzzzzzzzzzz_);
                bool? kzzzzzzzzzb_ = context.Operators.Equal(kzzzzzzzzza_, "completed");
                bool? kzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzx_, kzzzzzzzzzb_);

                return kzzzzzzzzzc_;
            };
            IEnumerable<Procedure> izzzzzzzzzu_ = context.Operators.Where<Procedure>(izzzzzzzzzs_, izzzzzzzzzt_);
            Encounter izzzzzzzzzv_(Procedure AirwayProcedure) =>
                EDwithSTEMI;
            IEnumerable<Encounter> izzzzzzzzzw_ = context.Operators.Select<Procedure, Encounter>(izzzzzzzzzu_, izzzzzzzzzv_);

            return izzzzzzzzzw_;
        };
        IEnumerable<Encounter> izzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzl_, izzzzzzzzzm_);

        return izzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzd_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> kzzzzzzzzze_(Encounter EDwSTEMI)
        {
            CqlValueSet kzzzzzzzzzg_ = this.Ischemic_Stroke(context);
            IEnumerable<Condition> kzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet kzzzzzzzzzi_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition> kzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> kzzzzzzzzzk_ = context.Operators.Union<Condition>(kzzzzzzzzzh_, kzzzzzzzzzj_);
            CqlValueSet kzzzzzzzzzl_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition> kzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet kzzzzzzzzzn_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> kzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> kzzzzzzzzzp_ = context.Operators.Union<Condition>(kzzzzzzzzzm_, kzzzzzzzzzo_);
            IEnumerable<Condition> kzzzzzzzzzq_ = context.Operators.Union<Condition>(kzzzzzzzzzk_, kzzzzzzzzzp_);
            bool? kzzzzzzzzzr_(Condition ExclusionCondition)
            {
                CqlInterval<CqlDateTime> kzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime kzzzzzzzzzw_ = context.Operators.Start(kzzzzzzzzzv_);
                Period kzzzzzzzzzx_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzx_);
                CqlDateTime kzzzzzzzzzz_ = context.Operators.Start(kzzzzzzzzzy_);
                CqlQuantity lzzzzzzzzza_ = context.Operators.Quantity(90m, "days");
                CqlDateTime lzzzzzzzzzb_ = context.Operators.Subtract(kzzzzzzzzzz_, lzzzzzzzzza_);
                CqlInterval<CqlDateTime> lzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzx_);
                CqlDateTime lzzzzzzzzze_ = context.Operators.Start(lzzzzzzzzzd_);
                CqlInterval<CqlDateTime> lzzzzzzzzzf_ = context.Operators.Interval(lzzzzzzzzzb_, lzzzzzzzzze_, true, true);
                bool? lzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzw_, lzzzzzzzzzf_, default);

                return lzzzzzzzzzg_;
            };
            IEnumerable<Condition> kzzzzzzzzzs_ = context.Operators.Where<Condition>(kzzzzzzzzzq_, kzzzzzzzzzr_);
            Encounter kzzzzzzzzzt_(Condition ExclusionCondition) =>
                EDwSTEMI;
            IEnumerable<Encounter> kzzzzzzzzzu_ = context.Operators.Select<Condition, Encounter>(kzzzzzzzzzs_, kzzzzzzzzzt_);

            return kzzzzzzzzzu_;
        };
        IEnumerable<Encounter> kzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzd_, kzzzzzzzzze_);

        return kzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzh_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> lzzzzzzzzzi_(Encounter EDwithSTEMI)
        {
            CqlValueSet lzzzzzzzzzk_ = this.Intracranial_or_Intraspinal_surgery(context);
            IEnumerable<Procedure> lzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? lzzzzzzzzzm_(Procedure CranialorSpinalSurgery)
            {
                DataType lzzzzzzzzzq_ = CranialorSpinalSurgery?.Performed;
                object lzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzq_);
                CqlInterval<CqlDateTime> lzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzr_);
                CqlDateTime lzzzzzzzzzt_ = context.Operators.Start(lzzzzzzzzzs_);
                Period lzzzzzzzzzu_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzw_ = context.Operators.Start(lzzzzzzzzzv_);
                CqlQuantity lzzzzzzzzzx_ = context.Operators.Quantity(90m, "days");
                CqlDateTime lzzzzzzzzzy_ = context.Operators.Subtract(lzzzzzzzzzw_, lzzzzzzzzzx_);
                CqlInterval<CqlDateTime> mzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzu_);
                CqlDateTime mzzzzzzzzzb_ = context.Operators.Start(mzzzzzzzzza_);
                CqlInterval<CqlDateTime> mzzzzzzzzzc_ = context.Operators.Interval(lzzzzzzzzzy_, mzzzzzzzzzb_, true, false);
                bool? mzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzt_, mzzzzzzzzzc_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzu_);
                CqlDateTime mzzzzzzzzzg_ = context.Operators.Start(mzzzzzzzzzf_);
                bool? mzzzzzzzzzh_ = context.Operators.Not((bool?)(mzzzzzzzzzg_ is null));
                bool? mzzzzzzzzzi_ = context.Operators.And(mzzzzzzzzzd_, mzzzzzzzzzh_);
                Code<EventStatus> mzzzzzzzzzj_ = CranialorSpinalSurgery?.StatusElement;
                EventStatus? mzzzzzzzzzk_ = mzzzzzzzzzj_?.Value;
                string mzzzzzzzzzl_ = context.Operators.Convert<string>(mzzzzzzzzzk_);
                bool? mzzzzzzzzzm_ = context.Operators.Equal(mzzzzzzzzzl_, "completed");
                bool? mzzzzzzzzzn_ = context.Operators.And(mzzzzzzzzzi_, mzzzzzzzzzm_);

                return mzzzzzzzzzn_;
            };
            IEnumerable<Procedure> lzzzzzzzzzn_ = context.Operators.Where<Procedure>(lzzzzzzzzzl_, lzzzzzzzzzm_);
            Encounter lzzzzzzzzzo_(Procedure CranialorSpinalSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> lzzzzzzzzzp_ = context.Operators.Select<Procedure, Encounter>(lzzzzzzzzzn_, lzzzzzzzzzo_);

            return lzzzzzzzzzp_;
        };
        IEnumerable<Encounter> lzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzh_, lzzzzzzzzzi_);

        return lzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Patient Expired")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzo_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? mzzzzzzzzzp_(Encounter EDwithSTEMI)
        {
            Encounter.HospitalizationComponent mzzzzzzzzzr_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept mzzzzzzzzzs_ = mzzzzzzzzzr_?.DischargeDisposition;
            CqlConcept mzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzs_);
            CqlValueSet mzzzzzzzzzu_ = this.Patient_Expired(context);
            bool? mzzzzzzzzzv_ = context.Operators.ConceptInValueSet(mzzzzzzzzzt_, mzzzzzzzzzu_);

            return mzzzzzzzzzv_;
        };
        IEnumerable<Encounter> mzzzzzzzzzq_ = context.Operators.Where<Encounter>(mzzzzzzzzzo_, mzzzzzzzzzp_);

        return mzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzw_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzx_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzy_ = context.Operators.Union<Encounter>(mzzzzzzzzzw_, mzzzzzzzzzx_);
        IEnumerable<Encounter> mzzzzzzzzzz_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzza_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzb_ = context.Operators.Union<Encounter>(mzzzzzzzzzz_, nzzzzzzzzza_);
        IEnumerable<Encounter> nzzzzzzzzzc_ = context.Operators.Union<Encounter>(mzzzzzzzzzy_, nzzzzzzzzzb_);
        IEnumerable<Encounter> nzzzzzzzzzd_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> nzzzzzzzzze_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzf_ = context.Operators.Union<Encounter>(nzzzzzzzzzd_, nzzzzzzzzze_);
        IEnumerable<Encounter> nzzzzzzzzzg_ = context.Operators.Union<Encounter>(nzzzzzzzzzc_, nzzzzzzzzzf_);
        IEnumerable<Encounter> nzzzzzzzzzh_ = this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> nzzzzzzzzzi_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzj_ = context.Operators.Union<Encounter>(nzzzzzzzzzh_, nzzzzzzzzzi_);
        IEnumerable<Encounter> nzzzzzzzzzk_ = context.Operators.Union<Encounter>(nzzzzzzzzzg_, nzzzzzzzzzj_);
        IEnumerable<Encounter> nzzzzzzzzzl_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> nzzzzzzzzzm_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(context);
        IEnumerable<Encounter> nzzzzzzzzzn_ = context.Operators.Union<Encounter>(nzzzzzzzzzl_, nzzzzzzzzzm_);
        IEnumerable<Encounter> nzzzzzzzzzo_ = context.Operators.Union<Encounter>(nzzzzzzzzzk_, nzzzzzzzzzn_);

        return nzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Received tPA in Another Facility within 24 hours Prior to Admission")]
    public IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzp_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> nzzzzzzzzzq_(Encounter EDwithSTEMI)
        {
            CqlCode nzzzzzzzzzs_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode> nzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzs_);
            IEnumerable<Condition> nzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, nzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? nzzzzzzzzzv_(Condition TPA)
            {
                CqlInterval<CqlDateTime> nzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime ozzzzzzzzza_ = context.Operators.Start(nzzzzzzzzzz_);
                Period ozzzzzzzzzb_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzb_);
                bool? ozzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ozzzzzzzzza_, ozzzzzzzzzc_, default);

                return ozzzzzzzzzd_;
            };
            IEnumerable<Condition> nzzzzzzzzzw_ = context.Operators.Where<Condition>(nzzzzzzzzzu_, nzzzzzzzzzv_);
            Encounter nzzzzzzzzzx_(Condition TPA) =>
                EDwithSTEMI;
            IEnumerable<Encounter> nzzzzzzzzzy_ = context.Operators.Select<Condition, Encounter>(nzzzzzzzzzw_, nzzzzzzzzzx_);

            return nzzzzzzzzzy_;
        };
        IEnumerable<Encounter> nzzzzzzzzzr_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzp_, nzzzzzzzzzq_);

        return nzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzze_ = this.Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(context);

        return ozzzzzzzzze_;
    }


    [CqlExpressionDefinition("currentemergencyDepartmentArrivalTime")]
    public CqlDateTime currentemergencyDepartmentArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> ozzzzzzzzzf_ = EDEncounter?.Location;
        bool? ozzzzzzzzzg_(Encounter.LocationComponent EDLocation)
        {
            ResourceReference ozzzzzzzzzm_ = EDLocation?.Location;
            Location ozzzzzzzzzn_ = CQMCommon_2_2_000.Instance.GetLocation(context, ozzzzzzzzzm_);
            List<CodeableConcept> ozzzzzzzzzo_ = ozzzzzzzzzn_?.Type;
            CqlConcept ozzzzzzzzzp_(CodeableConcept @this)
            {
                CqlConcept ozzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ozzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> ozzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozzzzzzzzzo_, ozzzzzzzzzp_);
            CqlValueSet ozzzzzzzzzr_ = this.Emergency_Department_Visit(context);
            bool? ozzzzzzzzzs_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzq_, ozzzzzzzzzr_);

            return ozzzzzzzzzs_;
        };
        IEnumerable<Encounter.LocationComponent> ozzzzzzzzzh_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)ozzzzzzzzzf_, ozzzzzzzzzg_);
        Encounter.LocationComponent ozzzzzzzzzi_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(ozzzzzzzzzh_);
        Period ozzzzzzzzzj_ = ozzzzzzzzzi_?.Period;
        CqlInterval<CqlDateTime> ozzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzj_);
        CqlDateTime ozzzzzzzzzl_ = context.Operators.Start(ozzzzzzzzzk_);

        return ozzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Fibrinolytic Therapy within 30 Minutes of Arrival")]
    public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzu_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> ozzzzzzzzzv_(Encounter EDwithSTEMI)
        {
            CqlValueSet ozzzzzzzzzx_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> ozzzzzzzzzy_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> pzzzzzzzzza_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, ozzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> pzzzzzzzzzb_ = context.Operators.Union<MedicationAdministration>(ozzzzzzzzzy_, pzzzzzzzzza_);
            bool? pzzzzzzzzzc_(MedicationAdministration Fibrinolytic)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> pzzzzzzzzzg_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? pzzzzzzzzzh_ = pzzzzzzzzzg_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> pzzzzzzzzzi_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(pzzzzzzzzzh_);
                bool? pzzzzzzzzzj_ = context.Operators.Equal(pzzzzzzzzzi_, "completed");
                DataType pzzzzzzzzzk_ = Fibrinolytic?.Effective;
                object pzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzk_);
                CqlInterval<CqlDateTime> pzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzl_);
                CqlDateTime pzzzzzzzzzn_ = context.Operators.Start(pzzzzzzzzzm_);
                CqlDateTime pzzzzzzzzzo_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity pzzzzzzzzzq_ = context.Operators.Quantity(30m, "minutes");
                CqlDateTime pzzzzzzzzzr_ = context.Operators.Add(pzzzzzzzzzo_, pzzzzzzzzzq_);
                CqlInterval<CqlDateTime> pzzzzzzzzzs_ = context.Operators.Interval(pzzzzzzzzzo_, pzzzzzzzzzr_, false, true);
                bool? pzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzn_, pzzzzzzzzzs_, default);
                bool? pzzzzzzzzzv_ = context.Operators.Not((bool?)(pzzzzzzzzzo_ is null));
                bool? pzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzt_, pzzzzzzzzzv_);
                bool? pzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzj_, pzzzzzzzzzw_);

                return pzzzzzzzzzx_;
            };
            IEnumerable<MedicationAdministration> pzzzzzzzzzd_ = context.Operators.Where<MedicationAdministration>(pzzzzzzzzzb_, pzzzzzzzzzc_);
            Encounter pzzzzzzzzze_(MedicationAdministration Fibrinolytic) =>
                EDwithSTEMI;
            IEnumerable<Encounter> pzzzzzzzzzf_ = context.Operators.Select<MedicationAdministration, Encounter>(pzzzzzzzzzd_, pzzzzzzzzze_);

            return pzzzzzzzzzf_;
        };
        IEnumerable<Encounter> ozzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzu_, ozzzzzzzzzv_);

        return ozzzzzzzzzw_;
    }


    [CqlExpressionDefinition("PCI within 90 Minutes of Arrival")]
    public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzy_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> pzzzzzzzzzz_(Encounter EDwithSTEMI)
        {
            CqlValueSet qzzzzzzzzzb_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> qzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? qzzzzzzzzzd_(Procedure PCI)
            {
                DataType qzzzzzzzzzh_ = PCI?.Performed;
                object qzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzh_);
                CqlInterval<CqlDateTime> qzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzi_);
                CqlDateTime qzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzj_);
                CqlDateTime qzzzzzzzzzl_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity qzzzzzzzzzn_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime qzzzzzzzzzo_ = context.Operators.Add(qzzzzzzzzzl_, qzzzzzzzzzn_);
                CqlInterval<CqlDateTime> qzzzzzzzzzp_ = context.Operators.Interval(qzzzzzzzzzl_, qzzzzzzzzzo_, false, true);
                bool? qzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzk_, qzzzzzzzzzp_, default);
                bool? qzzzzzzzzzs_ = context.Operators.Not((bool?)(qzzzzzzzzzl_ is null));
                bool? qzzzzzzzzzt_ = context.Operators.And(qzzzzzzzzzq_, qzzzzzzzzzs_);
                Code<EventStatus> qzzzzzzzzzu_ = PCI?.StatusElement;
                EventStatus? qzzzzzzzzzv_ = qzzzzzzzzzu_?.Value;
                string qzzzzzzzzzw_ = context.Operators.Convert<string>(qzzzzzzzzzv_);
                bool? qzzzzzzzzzx_ = context.Operators.Equal(qzzzzzzzzzw_, "completed");
                bool? qzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzt_, qzzzzzzzzzx_);

                return qzzzzzzzzzy_;
            };
            IEnumerable<Procedure> qzzzzzzzzze_ = context.Operators.Where<Procedure>(qzzzzzzzzzc_, qzzzzzzzzzd_);
            Encounter qzzzzzzzzzf_(Procedure PCI) =>
                EDwithSTEMI;
            IEnumerable<Encounter> qzzzzzzzzzg_ = context.Operators.Select<Procedure, Encounter>(qzzzzzzzzze_, qzzzzzzzzzf_);

            return qzzzzzzzzzg_;
        };
        IEnumerable<Encounter> qzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzy_, pzzzzzzzzzz_);

        return qzzzzzzzzza_;
    }


    [CqlExpressionDefinition("ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
    public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzz_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? rzzzzzzzzza_(Encounter EDwithSTEMI)
        {
            Period rzzzzzzzzzc_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzc_);
            CqlDateTime rzzzzzzzzze_ = context.Operators.End(rzzzzzzzzzd_);
            CqlInterval<CqlDateTime> rzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzc_);
            CqlDateTime rzzzzzzzzzh_ = context.Operators.Start(rzzzzzzzzzg_);
            CqlInterval<CqlDateTime> rzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzc_);
            CqlDateTime rzzzzzzzzzk_ = context.Operators.Start(rzzzzzzzzzj_);
            CqlQuantity rzzzzzzzzzl_ = context.Operators.Quantity(45m, "minutes");
            CqlDateTime rzzzzzzzzzm_ = context.Operators.Add(rzzzzzzzzzk_, rzzzzzzzzzl_);
            CqlInterval<CqlDateTime> rzzzzzzzzzn_ = context.Operators.Interval(rzzzzzzzzzh_, rzzzzzzzzzm_, false, true);
            bool? rzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(rzzzzzzzzze_, rzzzzzzzzzn_, default);
            CqlInterval<CqlDateTime> rzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzc_);
            CqlDateTime rzzzzzzzzzr_ = context.Operators.Start(rzzzzzzzzzq_);
            bool? rzzzzzzzzzs_ = context.Operators.Not((bool?)(rzzzzzzzzzr_ is null));
            bool? rzzzzzzzzzt_ = context.Operators.And(rzzzzzzzzzo_, rzzzzzzzzzs_);
            Encounter.HospitalizationComponent rzzzzzzzzzu_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept rzzzzzzzzzv_ = rzzzzzzzzzu_?.DischargeDisposition;
            CqlConcept rzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzv_);
            CqlValueSet rzzzzzzzzzx_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? rzzzzzzzzzy_ = context.Operators.ConceptInValueSet(rzzzzzzzzzw_, rzzzzzzzzzx_);
            bool? rzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzt_, rzzzzzzzzzy_);

            return rzzzzzzzzzz_;
        };
        IEnumerable<Encounter> rzzzzzzzzzb_ = context.Operators.Where<Encounter>(qzzzzzzzzzz_, rzzzzzzzzza_);

        return rzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzza_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter> szzzzzzzzzb_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter> szzzzzzzzzc_ = context.Operators.Union<Encounter>(szzzzzzzzza_, szzzzzzzzzb_);
        IEnumerable<Encounter> szzzzzzzzzd_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(context);
        IEnumerable<Encounter> szzzzzzzzze_ = context.Operators.Union<Encounter>(szzzzzzzzzc_, szzzzzzzzzd_);

        return szzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzi_;
    }


    #endregion Expressions

}
