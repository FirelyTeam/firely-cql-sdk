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
        object vzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.ResolveParameter("AHAOverall-2.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    [CqlTag("description", "Returns true if the given Condition is confirmed as active")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept wzzzzzzzzzzzzzzzzzzzzzzzzzb_ = condition?.VerificationStatus;
        CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept wzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("isFinished")]
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzi_ = wzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
        Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzj_, "finished");

        return wzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Office_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter QualifyingEncounter)
        {
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Heart_Failure(context);
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition HeartFailure)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Condition, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period xzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.isFinished(context, QualifyingEncounter);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation EjectionFraction)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EjectionFraction?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(40m, "%");
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.LessOrEqual(yzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EjectionFraction?.StatusElement;
            ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzp_ = yzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            string yzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string[] yzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, yzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition LVSDDiagnosis)
        {
            CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzv_ = LVSDDiagnosis?.Severity;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Moderate_or_Severe(context);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzh_(Condition ModerateOrSevereLVSD)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<object> yzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<object>, yzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzze_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object zzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object zzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzi_ ?? zzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzn_ = HFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Before(zzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<object>(zzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzzzg_(object LVSDFindings) =>
                HFOutpatientEncounter;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<object, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition HeartTransplantComplications)
        {
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzd_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Before(azzzzzzzzzzzzzzzzzzzzzzzzzze_ ?? azzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Condition azzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Condition, Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition HeartTransplantComplications)
        {
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure LVADOutpatient)
        {
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzy_ = LVADOutpatient?.Performed;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Before(bzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Procedure azzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADOutpatient;
            IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Procedure, Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure LVADOutpatient)
        {
            Code<EventStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = LVADOutpatient?.StatusElement;
            EventStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "completed");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition LVADComplications)
        {
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = LVADComplications?.RecordedDateElement;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzza_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Before(bzzzzzzzzzzzzzzzzzzzzzzzzzzx_ ?? bzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Condition bzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Condition, Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition LVADComplications)
        {
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return czzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.isFinished(context, ValidEncounter);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Procedure HeartTransplant)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = HeartTransplant?.Performed;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Before(dzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Procedure dzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplant;
            IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Procedure, Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure HeartTransplant)
        {
            Code<EventStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HeartTransplant?.StatusElement;
            EventStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            string ezzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzzza_, "completed");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(dzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older, has two \nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzc_?.BirthDateElement;
        string ezzzzzzzzzzzzzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        int? ezzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzi_, "year");
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzzzzzj_, 18);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter Encounter1)
        {
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter Encounter2)
            {
                Id ezzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Encounter2?.IdElement;
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                Id fzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Encounter1?.IdElement;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = fzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Encounter ezzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter Encounter2) =>
                Encounter1;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Heart_Failure_Outpatient_Encounter(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("isOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            FhirDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Period fzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            Code<MedicationRequest.MedicationrequestStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                "active",
                "completed",
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Code<MedicationRequest.MedicationRequestIntent> fzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("overlapsHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period gzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Overlaps(gzzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period gzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.OverlapsAfter(gzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Procedure?.Performed;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Period hzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.OverlapsAfter(gzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            Code<EventStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Procedure?.StatusElement;
            EventStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "completed");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = AllergyIntolerance?.Onset;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            FhirDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
            Period hzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.OverlapsAfter(hzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzc_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.allergy_confirmed(context);
            CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            List<Dosage> izzzzzzzzzzzzzzzzzzzzzzzzzzm_ = MedicationRequest?.DosageInstruction;
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzn_(Dosage @this)
            {
                Timing jzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Timing;
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Dosage> izzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)izzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Timing izzzzzzzzzzzzzzzzzzzzzzzzzzp_(Dosage @this)
            {
                Timing jzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Timing;

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Timing> izzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Dosage, Timing>(izzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzr_(Timing @this)
            {
                Timing.RepeatComponent jzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Repeat;
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing> izzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Timing>(izzzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Timing.RepeatComponent izzzzzzzzzzzzzzzzzzzzzzzzzzt_(Timing @this)
            {
                Timing.RepeatComponent kzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Repeat;

                return kzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Timing.RepeatComponent> izzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Timing, Timing.RepeatComponent>(izzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzv_(Timing.RepeatComponent @this)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Bounds;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Timing.RepeatComponent> izzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Timing.RepeatComponent>(izzzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzzx_(Timing.RepeatComponent @this)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Bounds;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Timing.RepeatComponent, object>(izzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzz_(object DoseTime)
            {
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Collapse(jzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(@this);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Period jzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.OverlapsAfter(jzzzzzzzzzzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Code<MedicationRequest.MedicationRequestIntent> jzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? jzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = HeartRateObservation?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Period kzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.OverlapsAfter(kzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = HeartRateObservation?.StatusElement;
            ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            string kzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
