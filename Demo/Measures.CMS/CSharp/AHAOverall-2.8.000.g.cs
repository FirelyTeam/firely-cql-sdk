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
[CqlLibrary("AHAOverall", "2.8.000")]
public partial class AHAOverall_2_8_000 : ILibrary, ISingleton<AHAOverall_2_8_000>
{
    private AHAOverall_2_8_000() {}

    public static AHAOverall_2_8_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AHAOverall";
    public string Version => "2.8.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Ejection Fraction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", valueSetVersion: null)]
    public CqlValueSet Ejection_Fraction(CqlContext _) => _Ejection_Fraction;
    private static readonly CqlValueSet _Ejection_Fraction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", null);

    [CqlValueSetDefinition("Heart Failure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", valueSetVersion: null)]
    public CqlValueSet Heart_Failure(CqlContext _) => _Heart_Failure;
    private static readonly CqlValueSet _Heart_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);

    [CqlValueSetDefinition("Heart Transplant", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", valueSetVersion: null)]
    public CqlValueSet Heart_Transplant(CqlContext _) => _Heart_Transplant;
    private static readonly CqlValueSet _Heart_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", null);

    [CqlValueSetDefinition("Heart Transplant Complications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", valueSetVersion: null)]
    public CqlValueSet Heart_Transplant_Complications(CqlContext _) => _Heart_Transplant_Complications;
    private static readonly CqlValueSet _Heart_Transplant_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Left Ventricular Assist Device Complications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", valueSetVersion: null)]
    public CqlValueSet Left_Ventricular_Assist_Device_Complications(CqlContext _) => _Left_Ventricular_Assist_Device_Complications;
    private static readonly CqlValueSet _Left_Ventricular_Assist_Device_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", null);

    [CqlValueSetDefinition("Left Ventricular Assist Device Placement", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", valueSetVersion: null)]
    public CqlValueSet Left_Ventricular_Assist_Device_Placement(CqlContext _) => _Left_Ventricular_Assist_Device_Placement;
    private static readonly CqlValueSet _Left_Ventricular_Assist_Device_Placement = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", null);

    [CqlValueSetDefinition("Moderate or Severe", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe(CqlContext _) => _Moderate_or_Severe;
    private static readonly CqlValueSet _Moderate_or_Severe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", null);

    [CqlValueSetDefinition("Moderate or Severe LVSD", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext _) => _Moderate_or_Severe_LVSD;
    private static readonly CqlValueSet _Moderate_or_Severe_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Patient Provider Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", valueSetVersion: null)]
    public CqlValueSet Patient_Provider_Interaction(CqlContext _) => _Patient_Provider_Interaction;
    private static readonly CqlValueSet _Patient_Provider_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Left ventricular systolic dysfunction (disorder)", codeId: "134401001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left_ventricular_systolic_dysfunction__disorder_(CqlContext _) => _Left_ventricular_systolic_dysfunction__disorder_;
    private static readonly CqlCode _Left_ventricular_systolic_dysfunction__disorder_ = new CqlCode("134401001", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzzzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("AHAOverall-2.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzzzr_);

        return yzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    [CqlTag("description", "Returns true if the given Condition is confirmed as active")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? yzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept yzzzzzzzzzzzzzzzzzzzu_ = condition?.VerificationStatus;
        CqlConcept yzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzu_);
        CqlCode yzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept yzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzw_);
        bool? yzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(yzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzx_);
        bool? yzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzy_);

        return yzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("isFinished")]
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzzza_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? zzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzza_?.Value;
        Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(zzzzzzzzzzzzzzzzzzzzb_);
        bool? zzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzzzzc_, "finished");

        return zzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzze_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzg_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzj_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet zzzzzzzzzzzzzzzzzzzzp_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzs_(Encounter QualifyingEncounter)
        {
            CqlValueSet zzzzzzzzzzzzzzzzzzzzw_ = this.Heart_Failure(context);
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? zzzzzzzzzzzzzzzzzzzzy_(Condition HeartFailure)
            {
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
                Period azzzzzzzzzzzzzzzzzzzzd_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzd_);
                bool? azzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(azzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzze_, default);
                bool? azzzzzzzzzzzzzzzzzzzzg_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? azzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzg_);

                return azzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzy_);
            Encounter azzzzzzzzzzzzzzzzzzzza_(Condition HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Condition, Encounter>(zzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzza_);

            return azzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzs_);
        bool? zzzzzzzzzzzzzzzzzzzzu_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            Period azzzzzzzzzzzzzzzzzzzzj_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzk_, "day");
            bool? azzzzzzzzzzzzzzzzzzzzm_ = this.isFinished(context, QualifyingEncounter);
            bool? azzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzm_);

            return azzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzo_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? azzzzzzzzzzzzzzzzzzzzq_(Observation EjectionFraction)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzd_ = EjectionFraction?.Value;
            object bzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(40m, "%");
            bool? bzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.LessOrEqual(bzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzf_);
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzh_ = EjectionFraction?.StatusElement;
            ObservationStatus? bzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzh_?.Value;
            Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzzzzzzzzzzzzzzzzzzi_);
            string bzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzj_);
            string[] bzzzzzzzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? bzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? bzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzm_);

            return bzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzs_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode azzzzzzzzzzzzzzzzzzzzu_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzzzzx_(Condition LVSDDiagnosis)
        {
            CodeableConcept bzzzzzzzzzzzzzzzzzzzzo_ = LVSDDiagnosis?.Severity;
            CqlConcept bzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzq_ = this.Moderate_or_Severe(context);
            bool? bzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzq_);

            return bzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(azzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzy_);
        bool? bzzzzzzzzzzzzzzzzzzzza_(Condition ModerateOrSevereLVSD)
        {
            bool? bzzzzzzzzzzzzzzzzzzzzs_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return bzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<object>(azzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<object>, bzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<object>);

        return bzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzt_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzu_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzw_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? bzzzzzzzzzzzzzzzzzzzzx_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object czzzzzzzzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object czzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzb_ ?? czzzzzzzzzzzzzzzzzzzze_);
                Period czzzzzzzzzzzzzzzzzzzzg_ = HFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzh_);
                bool? czzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Before(czzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzi_, default);

                return czzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<object> bzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<object>(bzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzx_);
            Encounter bzzzzzzzzzzzzzzzzzzzzz_(object LVSDFindings) =>
                HFOutpatientEncounter;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<object, Encounter>(bzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzz_);

            return czzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzu_);

        return bzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzk_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzm_(Condition HeartTransplantComplications)
        {
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzr_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? czzzzzzzzzzzzzzzzzzzzs_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime czzzzzzzzzzzzzzzzzzzzw_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzy_);
                Period dzzzzzzzzzzzzzzzzzzzza_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzb_);
                bool? dzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Before(czzzzzzzzzzzzzzzzzzzzx_ ?? czzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzc_, default);

                return dzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzs_);
            Condition czzzzzzzzzzzzzzzzzzzzu_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, Condition>(czzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzu_);

            return czzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Condition, Condition>(czzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzm_);
        bool? czzzzzzzzzzzzzzzzzzzzo_(Condition HeartTransplantComplications)
        {
            bool? dzzzzzzzzzzzzzzzzzzzze_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return dzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzf_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzh_(Procedure LVADOutpatient)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzm_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? dzzzzzzzzzzzzzzzzzzzzn_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzr_ = LVADOutpatient?.Performed;
                object dzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzt_);
                Period dzzzzzzzzzzzzzzzzzzzzv_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzw_);
                bool? dzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Before(dzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzx_, default);

                return dzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzn_);
            Procedure dzzzzzzzzzzzzzzzzzzzzp_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADOutpatient;
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Procedure>(dzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzp_);

            return dzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Procedure, Procedure>(dzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzh_);
        bool? dzzzzzzzzzzzzzzzzzzzzj_(Procedure LVADOutpatient)
        {
            Code<EventStatus> dzzzzzzzzzzzzzzzzzzzzz_ = LVADOutpatient?.StatusElement;
            EventStatus? ezzzzzzzzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzzzzzzzz_?.Value;
            string ezzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzza_);
            bool? ezzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzb_, "completed");

            return ezzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzj_);
        bool? dzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzd_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzf_(Condition LVADComplications)
        {
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzk_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? ezzzzzzzzzzzzzzzzzzzzl_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime ezzzzzzzzzzzzzzzzzzzzp_ = LVADComplications?.RecordedDateElement;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzr_);
                Period ezzzzzzzzzzzzzzzzzzzzt_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Before(ezzzzzzzzzzzzzzzzzzzzq_ ?? ezzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzv_, default);

                return ezzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzl_);
            Condition ezzzzzzzzzzzzzzzzzzzzn_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, Condition>(ezzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzn_);

            return ezzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Condition, Condition>(ezzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzzzzzzzh_(Condition LVADComplications)
        {
            bool? ezzzzzzzzzzzzzzzzzzzzx_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return ezzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzh_);
        bool? ezzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzi_);

        return ezzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzy_ = this.Office_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzza_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzd_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzf_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzj_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzl_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzn_);
        bool? fzzzzzzzzzzzzzzzzzzzzp_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period fzzzzzzzzzzzzzzzzzzzzs_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzs_);
            bool? fzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? fzzzzzzzzzzzzzzzzzzzzv_ = this.isFinished(context, ValidEncounter);
            bool? fzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzv_);

            return fzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzp_);

        return fzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzx_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzz_(Procedure HeartTransplant)
        {
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzze_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? gzzzzzzzzzzzzzzzzzzzzf_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzj_ = HeartTransplant?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzl_);
                Period gzzzzzzzzzzzzzzzzzzzzn_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzo_);
                bool? gzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Before(gzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzp_, default);

                return gzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzf_);
            Procedure gzzzzzzzzzzzzzzzzzzzzh_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplant;
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, Procedure>(gzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzh_);

            return gzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Procedure, Procedure>(fzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzz_);
        bool? gzzzzzzzzzzzzzzzzzzzzb_(Procedure HeartTransplant)
        {
            Code<EventStatus> gzzzzzzzzzzzzzzzzzzzzr_ = HeartTransplant?.StatusElement;
            EventStatus? gzzzzzzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzzzzzzr_?.Value;
            string gzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzs_);
            bool? gzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzt_, "completed");

            return gzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzb_);
        bool? gzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(gzzzzzzzzzzzzzzzzzzzzc_);

        return gzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older, has two \nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
    {
        Patient gzzzzzzzzzzzzzzzzzzzzv_ = this.Patient(context);
        Date gzzzzzzzzzzzzzzzzzzzzw_ = gzzzzzzzzzzzzzzzzzzzzv_?.BirthDateElement;
        string gzzzzzzzzzzzzzzzzzzzzx_ = gzzzzzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate gzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzza_);
        int? hzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzb_, "year");
        bool? hzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzzzzzc_, 18);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzf_(Encounter Encounter1)
        {
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzzzzn_(Encounter Encounter2)
            {
                Id hzzzzzzzzzzzzzzzzzzzzr_ = Encounter2?.IdElement;
                string hzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzr_?.Value;
                Id hzzzzzzzzzzzzzzzzzzzzt_ = Encounter1?.IdElement;
                string hzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzt_?.Value;
                bool? hzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzu_);
                bool? hzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not(hzzzzzzzzzzzzzzzzzzzzv_);

                return hzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzn_);
            Encounter hzzzzzzzzzzzzzzzzzzzzp_(Encounter Encounter2) =>
                Encounter1;
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzg_);
        bool? hzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzj_ = this.Heart_Failure_Outpatient_Encounter(context);
        bool? hzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzj_);
        bool? hzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("isOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzx_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? hzzzzzzzzzzzzzzzzzzzzy_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            FhirDateTime izzzzzzzzzzzzzzzzzzzzb_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzb_);
            Period izzzzzzzzzzzzzzzzzzzzd_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzd_);
            bool? izzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzze_, "day");
            Code<MedicationRequest.MedicationrequestStatus> izzzzzzzzzzzzzzzzzzzzg_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? izzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzg_?.Value;
            string izzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzh_);
            string[] izzzzzzzzzzzzzzzzzzzzj_ = [
                "active",
                "completed",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzk_);
            Code<MedicationRequest.MedicationRequestIntent> izzzzzzzzzzzzzzzzzzzzm_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? izzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzm_?.Value;
            string izzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzn_);
            string[] izzzzzzzzzzzzzzzzzzzzp_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? izzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzq_);

            return izzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzy_);
        bool? izzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzz_);

        return izzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("overlapsHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzs_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? izzzzzzzzzzzzzzzzzzzzt_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period izzzzzzzzzzzzzzzzzzzzx_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(izzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzy_, "day");
            bool? jzzzzzzzzzzzzzzzzzzzza_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? jzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzza_);

            return jzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzt_);
        bool? izzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzzzzzu_);

        return izzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzc_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? jzzzzzzzzzzzzzzzzzzzzd_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period jzzzzzzzzzzzzzzzzzzzzh_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzh_);
            bool? jzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.OverlapsAfter(jzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? jzzzzzzzzzzzzzzzzzzzzk_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? jzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzk_);

            return jzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzd_);
        bool? jzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzze_);

        return jzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzm_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? jzzzzzzzzzzzzzzzzzzzzn_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzq_ = Procedure?.Performed;
            object jzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzr_);
            Period jzzzzzzzzzzzzzzzzzzzzt_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzt_);
            bool? jzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.OverlapsAfter(jzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzu_, "day");
            Code<EventStatus> jzzzzzzzzzzzzzzzzzzzzw_ = Procedure?.StatusElement;
            EventStatus? jzzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzzw_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzx_);
            bool? jzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzy_, "completed");
            bool? kzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzz_);

            return kzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzn_);
        bool? jzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzo_);

        return jzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzb_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? kzzzzzzzzzzzzzzzzzzzzc_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzf_ = AllergyIntolerance?.Onset;
            object kzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzh_);
            FhirDateTime kzzzzzzzzzzzzzzzzzzzzj_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzk_, true, true);
            Period kzzzzzzzzzzzzzzzzzzzzm_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.OverlapsAfter(kzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzn_, "day");
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzp_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzp_);
            CqlCode kzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept kzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzzzr_);
            bool? kzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzt_);
            CodeableConcept kzzzzzzzzzzzzzzzzzzzzv_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept kzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzv_);
            CqlCode kzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.allergy_confirmed(context);
            CqlConcept kzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzzzx_);
            bool? kzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzy_);
            bool? lzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzz_);

            return lzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzzzzzzzd_);

        return kzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzb_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? lzzzzzzzzzzzzzzzzzzzzc_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            List<Dosage> lzzzzzzzzzzzzzzzzzzzzf_ = MedicationRequest?.DosageInstruction;
            bool? lzzzzzzzzzzzzzzzzzzzzg_(Dosage @this)
            {
                Timing mzzzzzzzzzzzzzzzzzzzzo_ = @this?.Timing;
                bool? mzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzo_ is null));

                return mzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Dosage> lzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)lzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzg_);
            Timing lzzzzzzzzzzzzzzzzzzzzi_(Dosage @this)
            {
                Timing mzzzzzzzzzzzzzzzzzzzzq_ = @this?.Timing;

                return mzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Timing> lzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Dosage, Timing>(lzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzi_);
            bool? lzzzzzzzzzzzzzzzzzzzzk_(Timing @this)
            {
                Timing.RepeatComponent mzzzzzzzzzzzzzzzzzzzzr_ = @this?.Repeat;
                bool? mzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzr_ is null));

                return mzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Timing> lzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Timing>(lzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzk_);
            Timing.RepeatComponent lzzzzzzzzzzzzzzzzzzzzm_(Timing @this)
            {
                Timing.RepeatComponent mzzzzzzzzzzzzzzzzzzzzt_ = @this?.Repeat;

                return mzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Timing.RepeatComponent> lzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Timing, Timing.RepeatComponent>(lzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzzzzzo_(Timing.RepeatComponent @this)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzu_ = @this?.Bounds;
                object mzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzu_);
                bool? mzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzv_ is null));

                return mzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Timing.RepeatComponent> lzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Timing.RepeatComponent>(lzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzo_);
            object lzzzzzzzzzzzzzzzzzzzzq_(Timing.RepeatComponent @this)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzx_ = @this?.Bounds;
                object mzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzx_);

                return mzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<object> lzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Timing.RepeatComponent, object>(lzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzs_(object DoseTime)
            {
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return mzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Collapse(lzzzzzzzzzzzzzzzzzzzzu_, default);
            object lzzzzzzzzzzzzzzzzzzzzw_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime nzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(@this);

                return nzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzzzzzzzzzx_);
            Period lzzzzzzzzzzzzzzzzzzzzz_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzz_);
            bool? mzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.OverlapsAfter(lzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzza_, "day");
            Code<MedicationRequest.MedicationrequestStatus> mzzzzzzzzzzzzzzzzzzzzc_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? mzzzzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzzzzc_?.Value;
            string mzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzd_);
            string[] mzzzzzzzzzzzzzzzzzzzzf_ = [
                "active",
                "completed",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzg_);
            Code<MedicationRequest.MedicationRequestIntent> mzzzzzzzzzzzzzzzzzzzzi_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? mzzzzzzzzzzzzzzzzzzzzj_ = mzzzzzzzzzzzzzzzzzzzzi_?.Value;
            string mzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzj_);
            string[] mzzzzzzzzzzzzzzzzzzzzl_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzm_);

            return mzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzc_);
        bool? lzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzd_);

        return lzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzb_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? nzzzzzzzzzzzzzzzzzzzzc_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzf_ = HeartRateObservation?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzg_);
            Period nzzzzzzzzzzzzzzzzzzzzi_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzi_);
            bool? nzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.OverlapsAfter(nzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzj_, "day");
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzl_ = HeartRateObservation?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzm_ = nzzzzzzzzzzzzzzzzzzzzl_?.Value;
            string nzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzm_);
            string[] nzzzzzzzzzzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? nzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzp_);

            return nzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzd_);

        return nzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Expressions

}
