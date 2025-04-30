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
[CqlLibrary("KidneyHealthEvaluationFHIR", "0.1.000")]
public partial class KidneyHealthEvaluationFHIR_0_1_000 : ILibrary, ISingleton<KidneyHealthEvaluationFHIR_0_1_000>
{
    private KidneyHealthEvaluationFHIR_0_1_000() {}

    public static KidneyHealthEvaluationFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "KidneyHealthEvaluationFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Acute Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext _) => _Acute_Inpatient;
    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Chronic Kidney Disease, Stage 5", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", valueSetVersion: null)]
    public CqlValueSet Chronic_Kidney_Disease__Stage_5(CqlContext _) => _Chronic_Kidney_Disease__Stage_5;
    private static readonly CqlValueSet _Chronic_Kidney_Disease__Stage_5 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("End Stage Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext _) => _End_Stage_Renal_Disease;
    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlValueSetDefinition("Estimated Glomerular Filtration Rate", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000", valueSetVersion: null)]
    public CqlValueSet Estimated_Glomerular_Filtration_Rate(CqlContext _) => _Estimated_Glomerular_Filtration_Rate;
    private static readonly CqlValueSet _Estimated_Glomerular_Filtration_Rate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Palliative or Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", valueSetVersion: null)]
    public CqlValueSet Palliative_or_Hospice_Care(CqlContext _) => _Palliative_or_Hospice_Care;
    private static readonly CqlValueSet _Palliative_or_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Urine Albumin Creatinine Ratio", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007", valueSetVersion: null)]
    public CqlValueSet Urine_Albumin_Creatinine_Ratio(CqlContext _) => _Urine_Albumin_Creatinine_Ratio;
    private static readonly CqlValueSet _Urine_Albumin_Creatinine_Ratio = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.ResolveParameter("KidneyHealthEvaluationFHIR-0.1.000", "Measurement Period", mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Has Active Diabetes Overlaps Measurement Period")]
    public bool? Has_Active_Diabetes_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Diabetes(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Diabetes?.ClinicalStatus;
            CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.active(context);
            CqlConcept mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Outpatient Visit During Measurement Period")]
    public bool? Has_Outpatient_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Office_Visit(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
            Code<Encounter.EncounterStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<Encounter.EncounterStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "finished");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(18, 85, true, true);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Active_Diabetes_Overlaps_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Outpatient_Visit_During_Measurement_Period(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has CKD Stage 5 or ESRD Diagnosis Overlaps Measurement Period")]
    public IEnumerable<Condition> Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Chronic_Kidney_Disease__Stage_5(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.End_Stage_Renal_Disease(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Condition CKDOrESRD)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, CKDOrESRD);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = CKDOrESRD?.ClinicalStatus;
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.active(context);
            CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Has_CKD_Stage_5_or_ESRD_Diagnosis_Overlaps_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Kidney Panel Performed During Measurement Period")]
    public bool? Has_Kidney_Panel_Performed_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Estimated_Glomerular_Filtration_Rate(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation eGFRTest)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = eGFRTest?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = eGFRTest?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = eGFRTest?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Urine_Albumin_Creatinine_Ratio(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation uACRTest)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = uACRTest?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = uACRTest?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = uACRTest?.StatusElement;
            ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Kidney_Panel_Performed_During_Measurement_Period(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

}
