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
      new CqlCodeSystem("http://loinc.org", null, [
          _Birthdate]);

    [CqlCodeSystemDefinition("HSLOC")]
    public CqlCodeSystem HSLOC(CqlContext _) => _HSLOC;
    private static readonly CqlCodeSystem _HSLOC =
      new CqlCodeSystem("https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", null, [
          _Emergency_Department]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Patient_transfer__procedure_,
          _Streptokinase_adverse_reaction__disorder_]);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _EMER]);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzh_, true, true);
        object ezzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("AppropriateTreatmentforSTEMIFHIR-1.2.000", "Measurement Period", ezzzzzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzzk_);

        return ezzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("ED Encounter During MP")]
    public IEnumerable<Encounter> ED_Encounter_During_MP(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzm_ = this.Emergency_Department_Evaluation_and_Management_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? ezzzzzzzzzzzzzzzzzzzzzo_(Encounter EDEncounter)
        {
            Period ezzzzzzzzzzzzzzzzzzzzzq_ = EDEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzt_, "day");
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzv_ = EDEncounter?.StatusElement;
            Encounter.EncounterStatus? ezzzzzzzzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzzzzzzzzzzzzzzw_);
            bool? ezzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzx_, "finished");
            bool? ezzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzy_);
            Coding fzzzzzzzzzzzzzzzzzzzzza_ = EDEncounter?.Class;
            CqlCode fzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToCode(context, fzzzzzzzzzzzzzzzzzzzzza_);
            CqlCode fzzzzzzzzzzzzzzzzzzzzzc_ = this.EMER(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzc_);
            bool? fzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzd_);

            return fzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzo_);

        return ezzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("ED Encounter with Encounter Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzf_ = this.ED_Encounter_During_MP(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzg_(Encounter EDEncounter)
        {
            List<CodeableConcept> fzzzzzzzzzzzzzzzzzzzzzi_ = EDEncounter?.ReasonCode;
            CqlConcept fzzzzzzzzzzzzzzzzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return fzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzl_ = this.STEMI(context);
            bool? fzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.encounterDiagnosis(context, EDEncounter);
            bool? fzzzzzzzzzzzzzzzzzzzzzo_(Condition EncDiagnosis)
            {
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzt_ = EncDiagnosis?.Code;
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzt_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzv_ = this.STEMI(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzv_);

                return fzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Condition> fzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzo_);
            bool? fzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(fzzzzzzzzzzzzzzzzzzzzzp_);
            bool? fzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzq_);

            return fzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzg_);

        return fzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("ED Encounter with Diagnosis of STEMI")]
    public IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzx_ = this.ED_Encounter_During_MP(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzy_(Encounter EDEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzza_ = this.STEMI(context);
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? gzzzzzzzzzzzzzzzzzzzzzc_(Condition DxSTEMI)
            {
                CodeableConcept gzzzzzzzzzzzzzzzzzzzzzg_ = DxSTEMI?.ClinicalStatus;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzg_);
                CqlCode gzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.active(context);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzzzzzzzzzi_);
                bool? gzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equivalent(gzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, DxSTEMI);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzl_);
                Period gzzzzzzzzzzzzzzzzzzzzzn_ = EDEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzn_);
                bool? gzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzo_, default);
                bool? gzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzp_);

                return gzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzc_);
            Encounter gzzzzzzzzzzzzzzzzzzzzze_(Condition DxSTEMI) =>
                EDEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Condition, Encounter>(gzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzy_);

        return fzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("ED Encounter with STEMI Diagnosis")]
    public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzr_ = this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzs_ = this.ED_Encounter_with_Diagnosis_of_STEMI(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzs_);

        return gzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzu_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzv_(Encounter EDwithSTEMI)
        {
            Patient gzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
            Date gzzzzzzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
            string gzzzzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDate hzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzzzzzz_);
            Period hzzzzzzzzzzzzzzzzzzzzzb_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzd_);
            int? hzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzze_, "year");
            bool? hzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzzf_, 18);

            return hzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzv_);

        return gzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
    public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzi_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzj_(Encounter EDwSTEMI)
        {
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzl_ = this.Thrombolytic_medications(context);
            IEnumerable<AllergyIntolerance> hzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
            bool? hzzzzzzzzzzzzzzzzzzzzzn_(AllergyIntolerance ThrombolyticAllergy)
            {
                CodeableConcept hzzzzzzzzzzzzzzzzzzzzzr_ = ThrombolyticAllergy?.ClinicalStatus;
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzr_);
                CqlCode hzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzzzzt_);
                bool? hzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzu_);
                DataType hzzzzzzzzzzzzzzzzzzzzzw_ = ThrombolyticAllergy?.Onset;
                object hzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzx_);
                Period hzzzzzzzzzzzzzzzzzzzzzz_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzz_);
                bool? izzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Overlaps(hzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzza_, default);
                bool? izzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzb_);

                return izzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<AllergyIntolerance> hzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<AllergyIntolerance>(hzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter hzzzzzzzzzzzzzzzzzzzzzp_(AllergyIntolerance ThrombolyticAllergy) =>
                EDwSTEMI;
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<AllergyIntolerance, Encounter>(hzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzj_);

        return hzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
    public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzd_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzze_(Encounter EDwSTEMI)
        {
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzg_ = this.Thrombolytics_Adverse_Event(context);
            IEnumerable<AdverseEvent> izzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? izzzzzzzzzzzzzzzzzzzzzi_(AdverseEvent ThrombolyticAdverseEvent)
            {
                FhirDateTime izzzzzzzzzzzzzzzzzzzzzm_ = ThrombolyticAdverseEvent?.RecordedDateElement;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzm_);
                Period izzzzzzzzzzzzzzzzzzzzzo_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzp_);
                bool? izzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Before(izzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<AdverseEvent.AdverseEventActuality> izzzzzzzzzzzzzzzzzzzzzs_ = ThrombolyticAdverseEvent?.ActualityElement;
                AdverseEvent.AdverseEventActuality? izzzzzzzzzzzzzzzzzzzzzt_ = izzzzzzzzzzzzzzzzzzzzzs_?.Value;
                Code<AdverseEvent.AdverseEventActuality> izzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(izzzzzzzzzzzzzzzzzzzzzt_);
                bool? izzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzu_, "actual");
                bool? izzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzv_);

                return izzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<AdverseEvent> izzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<AdverseEvent>(izzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzi_);
            Encounter izzzzzzzzzzzzzzzzzzzzzk_(AdverseEvent ThrombolyticAdverseEvent) =>
                EDwSTEMI;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<AdverseEvent, Encounter>(izzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzk_);

            return izzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzze_);

        return izzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis at Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzx_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzy_(Encounter EDwithSTEMI)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzza_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzc_ = this.Malignant_Intracranial_Neoplasm_Group(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzf_ = this.Cerebral_Vascular_Lesion(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzh_ = this.Dementia_and_Related_Intracranial_Pathologies(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzl_ = this.Pregnant_State(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzn_ = this.Allergy_to_thrombolytics(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Condition>(jzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzzzzzzzr_(Condition ActiveExclusionDx)
            {
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
                Period jzzzzzzzzzzzzzzzzzzzzzw_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzw_);
                bool? jzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.OverlapsBefore(jzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzx_, default);

                return jzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter jzzzzzzzzzzzzzzzzzzzzzt_(Condition ActiveExclusionDx) =>
                EDwithSTEMI;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Condition, Encounter>(jzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzy_);

        return izzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzz_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzza_(Encounter EDwithSTEMI)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzc_ = this.Oral_Anticoagulant_Medications(context);
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzf_);
            bool? kzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest OralAnticoagulant)
            {
                Code<MedicationRequest.MedicationrequestStatus> kzzzzzzzzzzzzzzzzzzzzzl_ = OralAnticoagulant?.StatusElement;
                MedicationRequest.MedicationrequestStatus? kzzzzzzzzzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzm_);
                bool? kzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzn_, "active");
                Code<MedicationRequest.MedicationRequestIntent> kzzzzzzzzzzzzzzzzzzzzzp_ = OralAnticoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? kzzzzzzzzzzzzzzzzzzzzzq_ = kzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzr_, "order");
                bool? kzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzs_);
                FhirDateTime kzzzzzzzzzzzzzzzzzzzzzu_ = OralAnticoagulant?.AuthoredOnElement;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzu_);
                Period kzzzzzzzzzzzzzzzzzzzzzw_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(90m, "days");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? lzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzze_, default);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzh_);
                bool? lzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzi_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzj_);
                bool? lzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzk_);

                return lzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter kzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest OralAnticoagulant) =>
                EDwithSTEMI;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<MedicationRequest, Encounter>(kzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzj_);

            return kzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzm_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzn_(Encounter EDwithSTEMI)
        {
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzp_ = this.Aortic_Dissection_or_Ruptured_Aortic_Aneurysm(context);
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzr_ = this.Neurologic_impairment(context);
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzs_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzu_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzzzzzzzx_(Condition ExclusionDiagnosis)
            {
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzb_);
                Period mzzzzzzzzzzzzzzzzzzzzzd_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzd_);
                bool? mzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzze_, default);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzp_, true, false);
                bool? mzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzq_, default);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzt_);
                bool? mzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzv_);
                bool? mzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzw_);

                return mzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzx_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzz_(Condition ExclusionDiagnosis) =>
                EDwithSTEMI;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Condition, Encounter>(lzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzz_);

            return mzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
    public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzy_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzz_(Encounter EDwithSTEMI)
        {
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzb_ = this.Major_Surgical_Procedure(context);
            IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? nzzzzzzzzzzzzzzzzzzzzzd_(Procedure MajorSurgery)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzh_ = MajorSurgery?.Performed;
                object nzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzj_);
                Period nzzzzzzzzzzzzzzzzzzzzzl_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(21m, "days");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzs_, true, false);
                bool? nzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzt_, default);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzw_);
                bool? nzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzy_);
                Code<EventStatus> ozzzzzzzzzzzzzzzzzzzzza_ = MajorSurgery?.StatusElement;
                EventStatus? ozzzzzzzzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzzzzzzzza_?.Value;
                string ozzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzb_);
                bool? ozzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzc_, "completed");
                bool? ozzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzd_);

                return ozzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzzd_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzf_(Procedure MajorSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Procedure, Encounter>(nzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzf_);

            return nzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
    public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzf_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzg_(Encounter EDwithSTEMI)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzi_ = this.Endotracheal_Intubation(context);
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzk_ = this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(context);
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Procedure>(ozzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzzzzzzzn_(Procedure AirwayProcedure)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzr_ = AirwayProcedure?.Performed;
                object ozzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzt_);
                Period ozzzzzzzzzzzzzzzzzzzzzv_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzv_);
                bool? ozzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzw_, default);
                object ozzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzj_, true, false);
                bool? pzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzk_, default);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzp_);
                bool? pzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzq_);
                Code<EventStatus> pzzzzzzzzzzzzzzzzzzzzzs_ = AirwayProcedure?.StatusElement;
                EventStatus? pzzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzt_);
                bool? pzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzu_, "completed");
                bool? pzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzv_);

                return pzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Procedure> ozzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(ozzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzn_);
            Encounter ozzzzzzzzzzzzzzzzzzzzzp_(Procedure AirwayProcedure) =>
                EDwithSTEMI;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Procedure, Encounter>(ozzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzp_);

            return ozzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzg_);

        return ozzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
    public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzx_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzy_(Encounter EDwSTEMI)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzza_ = this.Ischemic_Stroke(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzc_ = this.Closed_Head_and_Facial_Trauma(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzd_);
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzf_ = this.Active_Peptic_Ulcer(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzh_ = this.Cardiopulmonary_Arrest(context);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Condition>(qzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzj_);
            bool? qzzzzzzzzzzzzzzzzzzzzzl_(Condition ExclusionCondition)
            {
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ExclusionCondition);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzp_);
                Period qzzzzzzzzzzzzzzzzzzzzzr_ = EDwSTEMI?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(90m, "days");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzz_, default);

                return rzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzl_);
            Encounter qzzzzzzzzzzzzzzzzzzzzzn_(Condition ExclusionCondition) =>
                EDwSTEMI;
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Condition, Encounter>(qzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzn_);

            return qzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(pzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzy_);

        return pzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
    public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzb_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzc_(Encounter EDwithSTEMI)
        {
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzze_ = this.Intracranial_or_Intraspinal_surgery(context);
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? rzzzzzzzzzzzzzzzzzzzzzg_(Procedure CranialorSpinalSurgery)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzk_ = CranialorSpinalSurgery?.Performed;
                object rzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzm_);
                Period rzzzzzzzzzzzzzzzzzzzzzo_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(90m, "days");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzv_, true, false);
                bool? rzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzzw_, default);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzz_);
                bool? szzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzb_);
                Code<EventStatus> szzzzzzzzzzzzzzzzzzzzzd_ = CranialorSpinalSurgery?.StatusElement;
                EventStatus? szzzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzzd_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzze_);
                bool? szzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzf_, "completed");
                bool? szzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzg_);

                return szzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(rzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter rzzzzzzzzzzzzzzzzzzzzzi_(Procedure CranialorSpinalSurgery) =>
                EDwithSTEMI;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Procedure, Encounter>(rzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzi_);

            return rzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzc_);

        return rzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("ED Encounter with Discharge Disposition as Patient Expired")]
    public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzi_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? szzzzzzzzzzzzzzzzzzzzzj_(Encounter EDwithSTEMI)
        {
            Encounter.HospitalizationComponent szzzzzzzzzzzzzzzzzzzzzl_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept szzzzzzzzzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzzzzzzzzl_?.DischargeDisposition;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzzzzm_);
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzo_ = this.Patient_Expired(context);
            bool? szzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzo_);

            return szzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzq_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzr_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzt_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzu_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzx_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzy_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzb_ = this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzc_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzf_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzg_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzh_);

        return tzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Received tPA in Another Facility within 24 hours Prior to Admission")]
    public IEnumerable<Encounter> Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzj_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzk_(Encounter EDwithSTEMI)
        {
            CqlCode tzzzzzzzzzzzzzzzzzzzzzm_ = this.Status_post_administration_of_tPA__rtPA__in_a_different_facility_within_the_last_24_hours_prior_to_admission_to_current_facility(context);
            IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? tzzzzzzzzzzzzzzzzzzzzzp_(Condition TPA)
            {
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TPA);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzt_);
                Period tzzzzzzzzzzzzzzzzzzzzzv_ = EDwithSTEMI?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzv_);
                bool? tzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzw_, default);

                return tzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzp_);
            Encounter tzzzzzzzzzzzzzzzzzzzzzr_(Condition TPA) =>
                EDwithSTEMI;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Condition, Encounter>(tzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzr_);

            return tzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzy_ = this.Received_tPA_in_Another_Facility_within_24_hours_Prior_to_Admission(context);

        return tzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("currentemergencyDepartmentArrivalTime")]
    public CqlDateTime currentemergencyDepartmentArrivalTime(CqlContext context, Encounter EDEncounter)
    {
        List<Encounter.LocationComponent> tzzzzzzzzzzzzzzzzzzzzzz_ = EDEncounter?.Location;
        bool? uzzzzzzzzzzzzzzzzzzzzza_(Encounter.LocationComponent EDLocation)
        {
            ResourceReference uzzzzzzzzzzzzzzzzzzzzzg_ = EDLocation?.Location;
            Location uzzzzzzzzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.GetLocation(context, uzzzzzzzzzzzzzzzzzzzzzg_);
            List<CodeableConcept> uzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzh_?.Type;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzj_);
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzl_ = this.Emergency_Department_Visit(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(uzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzl_);

            return uzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter.LocationComponent> uzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)tzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzza_);
        Encounter.LocationComponent uzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(uzzzzzzzzzzzzzzzzzzzzzb_);
        Period uzzzzzzzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzzzzzzzc_?.Period;
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzze_);

        return uzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Fibrinolytic Therapy within 30 Minutes of Arrival")]
    public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzo_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzp_(Encounter EDwithSTEMI)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzr_ = this.Fibrinolytic_Therapy(context);
            IEnumerable<MedicationAdministration> uzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> uzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> uzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<MedicationAdministration>(uzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzu_);
            bool? uzzzzzzzzzzzzzzzzzzzzzw_(MedicationAdministration Fibrinolytic)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> vzzzzzzzzzzzzzzzzzzzzza_ = Fibrinolytic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? vzzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzzza_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> vzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(vzzzzzzzzzzzzzzzzzzzzzb_);
                bool? vzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzc_, "completed");
                DataType vzzzzzzzzzzzzzzzzzzzzze_ = Fibrinolytic?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzi_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(30m, "minutes");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzl_, false, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzm_, default);
                bool? vzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzi_ is null));
                bool? vzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzp_);
                bool? vzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzq_);

                return vzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<MedicationAdministration> uzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<MedicationAdministration>(uzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzw_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzy_(MedicationAdministration Fibrinolytic) =>
                EDwithSTEMI;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<MedicationAdministration, Encounter>(uzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzy_);

            return uzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzp_);

        return uzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("PCI within 90 Minutes of Arrival")]
    public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzs_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzt_(Encounter EDwithSTEMI)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzv_ = this.Percutaneous_Coronary_Intervention(context);
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? vzzzzzzzzzzzzzzzzzzzzzx_(Procedure PCI)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzb_ = PCI?.Performed;
                object wzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzf_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(90m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzi_, false, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzj_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzm_);
                Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzo_ = PCI?.StatusElement;
                EventStatus? wzzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzp_);
                bool? wzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzq_, "completed");
                bool? wzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzr_);

                return wzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzx_);
            Encounter vzzzzzzzzzzzzzzzzzzzzzz_(Procedure PCI) =>
                EDwithSTEMI;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Procedure, Encounter>(vzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzz_);

            return wzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzt_);

        return vzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
    public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzt_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzu_(Encounter EDwithSTEMI)
        {
            Period wzzzzzzzzzzzzzzzzzzzzzw_ = EDwithSTEMI?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(45m, "minutes");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzg_, false, true);
            bool? xzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzh_, default);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzk_);
            bool? xzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzm_);
            Encounter.HospitalizationComponent xzzzzzzzzzzzzzzzzzzzzzo_ = EDwithSTEMI?.Hospitalization;
            CodeableConcept xzzzzzzzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzzzzzzzo_?.DischargeDisposition;
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzr_ = this.Discharge_To_Acute_Care_Facility(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzs_);

            return xzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzu_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzv_ = this.PCI_within_90_Minutes_of_Arrival(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzx_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzx_);

        return xzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> yzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return yzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? yzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return yzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return yzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

}
