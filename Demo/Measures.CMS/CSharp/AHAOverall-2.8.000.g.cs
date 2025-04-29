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
        object lzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("AHAOverall-2.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient lzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    [CqlTag("description", "Returns true if the given Condition is confirmed as active")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzzzn_ = condition?.VerificationStatus;
        CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(lzzzzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("isFinished")]
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzt_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzzzzu_ = lzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
        Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzv_, "finished");

        return lzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter QualifyingEncounter)
        {
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Heart_Failure(context);
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition HeartFailure)
            {
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
                Period mzzzzzzzzzzzzzzzzzzzzzzzzw_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(mzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return nzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter mzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Condition, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            Period nzzzzzzzzzzzzzzzzzzzzzzzzc_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.isFinished(context, QualifyingEncounter);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation EjectionFraction)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzw_ = EjectionFraction?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(40m, "%");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.LessOrEqual(nzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, nzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzza_ = EjectionFraction?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzb_ = ozzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzb_);
            string ozzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] ozzzzzzzzzzzzzzzzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzf_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition LVSDDiagnosis)
        {
            CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzzzh_ = LVSDDiagnosis?.Severity;
            CqlConcept ozzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Moderate_or_Severe(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzzzj_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition ModerateOrSevereLVSD)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzl_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return ozzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<object> nzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<object>(nzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>, nzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<object>);

        return nzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzq_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object ozzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object ozzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzu_ ?? ozzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzz_ = HFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzb_, default);

                return pzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<object>(ozzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzq_);
            Encounter ozzzzzzzzzzzzzzzzzzzzzzzzs_(object LVSDFindings) =>
                HFOutpatientEncounter;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<object, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzs_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition HeartTransplantComplications)
        {
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime pzzzzzzzzzzzzzzzzzzzzzzzzp_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzr_);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzt_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Before(pzzzzzzzzzzzzzzzzzzzzzzzzq_ ?? pzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzv_, default);

                return pzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Condition pzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Condition, Condition>(pzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition HeartTransplantComplications)
        {
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return pzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzza_(Procedure LVADOutpatient)
        {
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzk_ = LVADOutpatient?.Performed;
                object qzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzm_);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzo_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Before(qzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzq_, default);

                return qzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Procedure qzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADOutpatient;
            IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Procedure, Procedure>(pzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzc_(Procedure LVADOutpatient)
        {
            Code<EventStatus> qzzzzzzzzzzzzzzzzzzzzzzzzs_ = LVADOutpatient?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzzzzzzzzzzzzt_ = qzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzzzzzu_, "completed");

            return qzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> qzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Procedure>(qzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return qzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition LVADComplications)
        {
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime rzzzzzzzzzzzzzzzzzzzzzzzzi_ = LVADComplications?.RecordedDateElement;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzm_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Before(rzzzzzzzzzzzzzzzzzzzzzzzzj_ ?? rzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzo_, default);

                return rzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzzze_);
            Condition rzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> qzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Condition, Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzza_(Condition LVADComplications)
        {
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return rzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(qzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Office_Visit(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzze_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period szzzzzzzzzzzzzzzzzzzzzzzzl_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzo_ = this.isFinished(context, ValidEncounter);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzo_);

            return szzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzi_);

        return szzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure HeartTransplant)
        {
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzc_ = HeartTransplant?.Performed;
                object tzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzg_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Before(tzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

                return tzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzy_);
            Procedure tzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplant;
            IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzza_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Procedure, Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure HeartTransplant)
        {
            Code<EventStatus> tzzzzzzzzzzzzzzzzzzzzzzzzk_ = HeartTransplant?.StatusElement;
            EventStatus? tzzzzzzzzzzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            string tzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzm_, "completed");

            return tzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> szzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Procedure>(szzzzzzzzzzzzzzzzzzzzzzzzv_);

        return szzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older, has two \nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
    {
        Patient tzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
        Date tzzzzzzzzzzzzzzzzzzzzzzzzp_ = tzzzzzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
        string tzzzzzzzzzzzzzzzzzzzzzzzzq_ = tzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzt_);
        int? tzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzzzzzzzzzv_, 18);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter Encounter1)
        {
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter Encounter2)
            {
                Id uzzzzzzzzzzzzzzzzzzzzzzzzk_ = Encounter2?.IdElement;
                string uzzzzzzzzzzzzzzzzzzzzzzzzl_ = uzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                Id uzzzzzzzzzzzzzzzzzzzzzzzzm_ = Encounter1?.IdElement;
                string uzzzzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not(uzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Encounter uzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter Encounter2) =>
                Encounter1;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Heart_Failure_Outpatient_Encounter(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return uzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("isOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            FhirDateTime uzzzzzzzzzzzzzzzzzzzzzzzzu_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Period uzzzzzzzzzzzzzzzzzzzzzzzzw_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            Code<MedicationRequest.MedicationrequestStatus> uzzzzzzzzzzzzzzzzzzzzzzzzz_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? vzzzzzzzzzzzzzzzzzzzzzzzza_ = uzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            string vzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzza_);
            string[] vzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Code<MedicationRequest.MedicationRequestIntent> vzzzzzzzzzzzzzzzzzzzzzzzzf_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzzzzzzzzzzzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            string vzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzg_);
            string[] vzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("overlapsHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period vzzzzzzzzzzzzzzzzzzzzzzzzq_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Overlaps(vzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period wzzzzzzzzzzzzzzzzzzzzzzzza_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.OverlapsAfter(vzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return wzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzj_ = Procedure?.Performed;
            object wzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Period wzzzzzzzzzzzzzzzzzzzzzzzzm_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.OverlapsAfter(wzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            Code<EventStatus> wzzzzzzzzzzzzzzzzzzzzzzzzp_ = Procedure?.StatusElement;
            EventStatus? wzzzzzzzzzzzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            string wzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzr_, "completed");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzy_ = AllergyIntolerance?.Onset;
            object wzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzza_);
            FhirDateTime xzzzzzzzzzzzzzzzzzzzzzzzzc_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            Period xzzzzzzzzzzzzzzzzzzzzzzzzf_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.OverlapsAfter(xzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzi_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzo_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.allergy_confirmed(context);
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(xzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            List<Dosage> xzzzzzzzzzzzzzzzzzzzzzzzzy_ = MedicationRequest?.DosageInstruction;
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzz_(Dosage @this)
            {
                Timing zzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Timing;
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));

                return zzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Dosage> yzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Timing yzzzzzzzzzzzzzzzzzzzzzzzzb_(Dosage @this)
            {
                Timing zzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Timing;

                return zzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Timing> yzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Dosage, Timing>(yzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzd_(Timing @this)
            {
                Timing.RepeatComponent zzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Repeat;
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));

                return zzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Timing> yzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Timing>(yzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Timing.RepeatComponent yzzzzzzzzzzzzzzzzzzzzzzzzf_(Timing @this)
            {
                Timing.RepeatComponent zzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Repeat;

                return zzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Timing.RepeatComponent> yzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Timing, Timing.RepeatComponent>(yzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzh_(Timing.RepeatComponent @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Bounds;
                object zzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));

                return zzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Timing.RepeatComponent> yzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Timing.RepeatComponent>(yzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzj_(Timing.RepeatComponent @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Bounds;
                object zzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Timing.RepeatComponent, object>(yzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzl_(object DoseTime)
            {
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return zzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Collapse(yzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
            object yzzzzzzzzzzzzzzzzzzzzzzzzp_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(@this);

                return zzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Period yzzzzzzzzzzzzzzzzzzzzzzzzs_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.OverlapsAfter(yzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            Code<MedicationRequest.MedicationrequestStatus> yzzzzzzzzzzzzzzzzzzzzzzzzv_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? yzzzzzzzzzzzzzzzzzzzzzzzzw_ = yzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            string yzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string[] yzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                "active",
                "completed",
            ];
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzzzzzzzzzzzzzzb_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? zzzzzzzzzzzzzzzzzzzzzzzzzc_ = zzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            string zzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] zzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzy_ = HeartRateObservation?.Effective;
            object zzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Period azzzzzzzzzzzzzzzzzzzzzzzzzb_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.OverlapsAfter(azzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzze_ = HeartRateObservation?.StatusElement;
            ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzf_ = azzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            string azzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzf_);
            string[] azzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
