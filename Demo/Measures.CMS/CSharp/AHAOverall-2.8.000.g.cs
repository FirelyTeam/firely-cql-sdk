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

    #region ValueSet: Care Services in Long Term Residential Facility
    [CqlValueSetDefinition(
        definitionName: "Care Services in Long Term Residential Facility",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => _Care_Services_in_Long_Term_Residential_Facility;

    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);
    #endregion

    #region ValueSet: Ejection Fraction
    [CqlValueSetDefinition(
        definitionName: "Ejection Fraction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134",
        valueSetVersion: null)]
    public CqlValueSet Ejection_Fraction(CqlContext context) => _Ejection_Fraction;

    private static readonly CqlValueSet _Ejection_Fraction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134", null);
    #endregion

    #region ValueSet: Heart Failure
    [CqlValueSetDefinition(
        definitionName: "Heart Failure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376",
        valueSetVersion: null)]
    public CqlValueSet Heart_Failure(CqlContext context) => _Heart_Failure;

    private static readonly CqlValueSet _Heart_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);
    #endregion

    #region ValueSet: Heart Transplant
    [CqlValueSetDefinition(
        definitionName: "Heart Transplant",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33",
        valueSetVersion: null)]
    public CqlValueSet Heart_Transplant(CqlContext context) => _Heart_Transplant;

    private static readonly CqlValueSet _Heart_Transplant = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33", null);
    #endregion

    #region ValueSet: Heart Transplant Complications
    [CqlValueSetDefinition(
        definitionName: "Heart Transplant Complications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56",
        valueSetVersion: null)]
    public CqlValueSet Heart_Transplant_Complications(CqlContext context) => _Heart_Transplant_Complications;

    private static readonly CqlValueSet _Heart_Transplant_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Left Ventricular Assist Device Complications
    [CqlValueSetDefinition(
        definitionName: "Left Ventricular Assist Device Complications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58",
        valueSetVersion: null)]
    public CqlValueSet Left_Ventricular_Assist_Device_Complications(CqlContext context) => _Left_Ventricular_Assist_Device_Complications;

    private static readonly CqlValueSet _Left_Ventricular_Assist_Device_Complications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58", null);
    #endregion

    #region ValueSet: Left Ventricular Assist Device Placement
    [CqlValueSetDefinition(
        definitionName: "Left Ventricular Assist Device Placement",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61",
        valueSetVersion: null)]
    public CqlValueSet Left_Ventricular_Assist_Device_Placement(CqlContext context) => _Left_Ventricular_Assist_Device_Placement;

    private static readonly CqlValueSet _Left_Ventricular_Assist_Device_Placement = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61", null);
    #endregion

    #region ValueSet: Moderate or Severe
    [CqlValueSetDefinition(
        definitionName: "Moderate or Severe",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092",
        valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe(CqlContext context) => _Moderate_or_Severe;

    private static readonly CqlValueSet _Moderate_or_Severe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092", null);
    #endregion

    #region ValueSet: Moderate or Severe LVSD
    [CqlValueSetDefinition(
        definitionName: "Moderate or Severe LVSD",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090",
        valueSetVersion: null)]
    public CqlValueSet Moderate_or_Severe_LVSD(CqlContext context) => _Moderate_or_Severe_LVSD;

    private static readonly CqlValueSet _Moderate_or_Severe_LVSD = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090", null);
    #endregion

    #region ValueSet: Nursing Facility Visit
    [CqlValueSetDefinition(
        definitionName: "Nursing Facility Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012",
        valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext context) => _Nursing_Facility_Visit;

    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Patient Provider Interaction
    [CqlValueSetDefinition(
        definitionName: "Patient Provider Interaction",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012",
        valueSetVersion: null)]
    public CqlValueSet Patient_Provider_Interaction(CqlContext context) => _Patient_Provider_Interaction;

    private static readonly CqlValueSet _Patient_Provider_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Left ventricular systolic dysfunction (disorder)
    [CqlCodeDefinition(
        definitionName: "Left ventricular systolic dysfunction (disorder)",
        codeId: "134401001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Left_ventricular_systolic_dysfunction__disorder_(CqlContext context) => _Left_ventricular_systolic_dysfunction__disorder_;

    private static readonly CqlCode _Left_ventricular_systolic_dysfunction__disorder_ = new CqlCode("134401001", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] fzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("134401001", "http://snomed.info/sct", default, default),
        ];

        return fzzzzzzzzzzzzzzzzm_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object fzzzzzzzzzzzzzzzzn_ = context.ResolveParameter("AHAOverall-2.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given Condition is confirmed as active")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? fzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept fzzzzzzzzzzzzzzzzr_ = condition?.VerificationStatus;
        CqlConcept fzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzr_);
        CqlCode fzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept fzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzt_);
        bool? fzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(fzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzv_);

        return fzzzzzzzzzzzzzzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzx_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? fzzzzzzzzzzzzzzzzy_ = fzzzzzzzzzzzzzzzzx_?.Value;
        Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzzzzzzzzzy_);
        bool? gzzzzzzzzzzzzzzzza_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzz_, "finished");

        return gzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzb_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzd_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzze_);
        CqlValueSet gzzzzzzzzzzzzzzzzg_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzi_ = this.Office_Visit(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzk_);
        CqlValueSet gzzzzzzzzzzzzzzzzm_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzp_(Encounter QualifyingEncounter)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzt_ = this.Heart_Failure(context);
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? gzzzzzzzzzzzzzzzzv_(Condition HeartFailure)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
                Period hzzzzzzzzzzzzzzzza_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzza_);
                bool? hzzzzzzzzzzzzzzzzc_ = context.Operators.Overlaps(gzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzb_, default);
                bool? hzzzzzzzzzzzzzzzzd_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? hzzzzzzzzzzzzzzzze_ = context.Operators.And(hzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzd_);

                return hzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzv_);
            Encounter gzzzzzzzzzzzzzzzzx_(Condition HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Condition, Encounter>(gzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzx_);

            return gzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzp_);
        bool? gzzzzzzzzzzzzzzzzr_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            Period hzzzzzzzzzzzzzzzzg_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzg_);
            bool? hzzzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzh_, "day");
            bool? hzzzzzzzzzzzzzzzzj_ = this.isFinished(context, QualifyingEncounter);
            bool? hzzzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzj_);

            return hzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzr_);

        return gzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzl_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? hzzzzzzzzzzzzzzzzn_(Observation EjectionFraction)
        {
            DataType izzzzzzzzzzzzzzzza_ = EjectionFraction?.Value;
            object izzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzza_);
            CqlQuantity izzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(40m, "%");
            bool? izzzzzzzzzzzzzzzzd_ = context.Operators.LessOrEqual(izzzzzzzzzzzzzzzzb_ as CqlQuantity, izzzzzzzzzzzzzzzzc_);
            Code<ObservationStatus> izzzzzzzzzzzzzzzze_ = EjectionFraction?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzze_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzf_);
            string izzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzg_);
            string[] izzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? izzzzzzzzzzzzzzzzk_ = context.Operators.And(izzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzj_);

            return izzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzn_);
        CqlValueSet hzzzzzzzzzzzzzzzzp_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode hzzzzzzzzzzzzzzzzr_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzzu_(Condition LVSDDiagnosis)
        {
            CodeableConcept izzzzzzzzzzzzzzzzl_ = LVSDDiagnosis?.Severity;
            CqlConcept izzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzl_);
            CqlValueSet izzzzzzzzzzzzzzzzn_ = this.Moderate_or_Severe(context);
            bool? izzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzu_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Condition>(hzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzzzzzzx_(Condition ModerateOrSevereLVSD)
        {
            bool? izzzzzzzzzzzzzzzzp_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return izzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzx_);
        IEnumerable<object> hzzzzzzzzzzzzzzzzz_ = context.Operators.Union<object>(hzzzzzzzzzzzzzzzzo_ as IEnumerable<object>, hzzzzzzzzzzzzzzzzy_ as IEnumerable<object>);

        return hzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzq_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzr_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> izzzzzzzzzzzzzzzzt_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? izzzzzzzzzzzzzzzzu_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object izzzzzzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object jzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzza_);
                CqlDateTime jzzzzzzzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzzzzzzy_ ?? jzzzzzzzzzzzzzzzzb_);
                Period jzzzzzzzzzzzzzzzzd_ = HFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzd_);
                CqlDateTime jzzzzzzzzzzzzzzzzf_ = context.Operators.End(jzzzzzzzzzzzzzzzze_);
                bool? jzzzzzzzzzzzzzzzzg_ = context.Operators.Before(jzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzf_, default);

                return jzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<object> izzzzzzzzzzzzzzzzv_ = context.Operators.Where<object>(izzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzu_);
            Encounter izzzzzzzzzzzzzzzzw_(object LVSDFindings) =>
                HFOutpatientEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzx_ = context.Operators.Select<object, Encounter>(izzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzw_);

            return izzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzr_);

        return izzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzh_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzj_(Condition HeartTransplantComplications)
        {
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzo_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? jzzzzzzzzzzzzzzzzp_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime jzzzzzzzzzzzzzzzzt_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime jzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime jzzzzzzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzzzzzzv_);
                Period jzzzzzzzzzzzzzzzzx_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzx_);
                CqlDateTime jzzzzzzzzzzzzzzzzz_ = context.Operators.End(jzzzzzzzzzzzzzzzzy_);
                bool? kzzzzzzzzzzzzzzzza_ = context.Operators.Before(jzzzzzzzzzzzzzzzzu_ ?? jzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzz_, default);

                return kzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzp_);
            Condition jzzzzzzzzzzzzzzzzr_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, Condition>(jzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzr_);

            return jzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Condition, Condition>(jzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzj_);
        bool? jzzzzzzzzzzzzzzzzl_(Condition HeartTransplantComplications)
        {
            bool? kzzzzzzzzzzzzzzzzb_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return kzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzl_);
        bool? jzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzm_);

        return jzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzc_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzze_(Procedure LVADOutpatient)
        {
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzj_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? kzzzzzzzzzzzzzzzzk_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType kzzzzzzzzzzzzzzzzo_ = LVADOutpatient?.Performed;
                object kzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzp_);
                CqlDateTime kzzzzzzzzzzzzzzzzr_ = context.Operators.Start(kzzzzzzzzzzzzzzzzq_);
                Period kzzzzzzzzzzzzzzzzs_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzs_);
                CqlDateTime kzzzzzzzzzzzzzzzzu_ = context.Operators.End(kzzzzzzzzzzzzzzzzt_);
                bool? kzzzzzzzzzzzzzzzzv_ = context.Operators.Before(kzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzu_, default);

                return kzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzk_);
            Procedure kzzzzzzzzzzzzzzzzm_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADOutpatient;
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, Procedure>(kzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzm_);

            return kzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Procedure, Procedure>(kzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzze_);
        bool? kzzzzzzzzzzzzzzzzg_(Procedure LVADOutpatient)
        {
            Code<EventStatus> kzzzzzzzzzzzzzzzzw_ = LVADOutpatient?.StatusElement;
            EventStatus? kzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzw_?.Value;
            string kzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzx_);
            bool? kzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzy_, "completed");

            return kzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzg_);
        bool? kzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzh_);

        return kzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzza_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzc_(Condition LVADComplications)
        {
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzh_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? lzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime lzzzzzzzzzzzzzzzzm_ = LVADComplications?.RecordedDateElement;
                CqlDateTime lzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime lzzzzzzzzzzzzzzzzp_ = context.Operators.Start(lzzzzzzzzzzzzzzzzo_);
                Period lzzzzzzzzzzzzzzzzq_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzq_);
                CqlDateTime lzzzzzzzzzzzzzzzzs_ = context.Operators.End(lzzzzzzzzzzzzzzzzr_);
                bool? lzzzzzzzzzzzzzzzzt_ = context.Operators.Before(lzzzzzzzzzzzzzzzzn_ ?? lzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzs_, default);

                return lzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzi_);
            Condition lzzzzzzzzzzzzzzzzk_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<Condition> lzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, Condition>(lzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzk_);

            return lzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Condition, Condition>(lzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzc_);
        bool? lzzzzzzzzzzzzzzzze_(Condition LVADComplications)
        {
            bool? lzzzzzzzzzzzzzzzzu_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return lzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzze_);
        bool? lzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzv_ = this.Office_Visit(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet lzzzzzzzzzzzzzzzzx_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzy_);
        CqlValueSet mzzzzzzzzzzzzzzzza_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzc_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzze_);
        CqlValueSet mzzzzzzzzzzzzzzzzg_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzzzzzzzzzzzzi_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzk_);
        bool? mzzzzzzzzzzzzzzzzm_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            Period mzzzzzzzzzzzzzzzzp_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(mzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzq_, "day");
            bool? mzzzzzzzzzzzzzzzzs_ = this.isFinished(context, ValidEncounter);
            bool? mzzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzs_);

            return mzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzm_);

        return mzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzu_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzw_(Procedure HeartTransplant)
        {
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzb_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? nzzzzzzzzzzzzzzzzc_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType nzzzzzzzzzzzzzzzzg_ = HeartTransplant?.Performed;
                object nzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzh_);
                CqlDateTime nzzzzzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzzzzzi_);
                Period nzzzzzzzzzzzzzzzzk_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzk_);
                CqlDateTime nzzzzzzzzzzzzzzzzm_ = context.Operators.End(nzzzzzzzzzzzzzzzzl_);
                bool? nzzzzzzzzzzzzzzzzn_ = context.Operators.Before(nzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzm_, default);

                return nzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzc_);
            Procedure nzzzzzzzzzzzzzzzze_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplant;
            IEnumerable<Procedure> nzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, Procedure>(nzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzze_);

            return nzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Procedure, Procedure>(mzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzw_);
        bool? mzzzzzzzzzzzzzzzzy_(Procedure HeartTransplant)
        {
            Code<EventStatus> nzzzzzzzzzzzzzzzzo_ = HeartTransplant?.StatusElement;
            EventStatus? nzzzzzzzzzzzzzzzzp_ = nzzzzzzzzzzzzzzzzo_?.Value;
            string nzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzp_);
            bool? nzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzq_, "completed");

            return nzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzy_);
        bool? nzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(mzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older, has two \nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
    {
        Patient nzzzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date nzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzs_?.BirthDateElement;
        string nzzzzzzzzzzzzzzzzu_ = nzzzzzzzzzzzzzzzzt_?.Value;
        CqlDate nzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzzzzzzzzzzzzx_ = context.Operators.Start(nzzzzzzzzzzzzzzzzw_);
        CqlDate nzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzx_);
        int? nzzzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzy_, "year");
        bool? ozzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzzzzz_, 18);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzb_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzc_(Encounter Encounter1)
        {
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzj_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
            bool? ozzzzzzzzzzzzzzzzk_(Encounter Encounter2)
            {
                Id ozzzzzzzzzzzzzzzzo_ = Encounter2?.IdElement;
                string ozzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzo_?.Value;
                Id ozzzzzzzzzzzzzzzzq_ = Encounter1?.IdElement;
                string ozzzzzzzzzzzzzzzzr_ = ozzzzzzzzzzzzzzzzq_?.Value;
                bool? ozzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzr_);
                bool? ozzzzzzzzzzzzzzzzt_ = context.Operators.Not(ozzzzzzzzzzzzzzzzs_);

                return ozzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzk_);
            Encounter ozzzzzzzzzzzzzzzzm_(Encounter Encounter2) =>
                Encounter1;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, Encounter>(ozzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzc_);
        bool? ozzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzd_);
        bool? ozzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzg_ = this.Heart_Failure_Outpatient_Encounter(context);
        bool? ozzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzg_);
        bool? ozzzzzzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzh_);

        return ozzzzzzzzzzzzzzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzu_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? ozzzzzzzzzzzzzzzzv_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            FhirDateTime ozzzzzzzzzzzzzzzzy_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime ozzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzy_);
            Period pzzzzzzzzzzzzzzzza_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzb_, "day");
            Code<MedicationRequest.MedicationrequestStatus> pzzzzzzzzzzzzzzzzd_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? pzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzd_?.Value;
            string pzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzze_);
            string[] pzzzzzzzzzzzzzzzzg_ = [
                "active",
                "completed",
            ];
            bool? pzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzh_);
            Code<MedicationRequest.MedicationRequestIntent> pzzzzzzzzzzzzzzzzj_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? pzzzzzzzzzzzzzzzzk_ = pzzzzzzzzzzzzzzzzj_?.Value;
            string pzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzk_);
            string[] pzzzzzzzzzzzzzzzzm_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? pzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            bool? pzzzzzzzzzzzzzzzzo_ = context.Operators.And(pzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzv_);
        bool? ozzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzw_);

        return ozzzzzzzzzzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzp_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? pzzzzzzzzzzzzzzzzq_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period pzzzzzzzzzzzzzzzzu_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(pzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzv_, "day");
            bool? pzzzzzzzzzzzzzzzzx_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? pzzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzq_);
        bool? pzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzr_);

        return pzzzzzzzzzzzzzzzzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzz_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? qzzzzzzzzzzzzzzzza_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period qzzzzzzzzzzzzzzzze_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzze_);
            bool? qzzzzzzzzzzzzzzzzg_ = context.Operators.OverlapsAfter(qzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzf_, "day");
            bool? qzzzzzzzzzzzzzzzzh_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? qzzzzzzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzh_);

            return qzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzb_);

        return qzzzzzzzzzzzzzzzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzj_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? qzzzzzzzzzzzzzzzzk_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType qzzzzzzzzzzzzzzzzn_ = Procedure?.Performed;
            object qzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzo_);
            Period qzzzzzzzzzzzzzzzzq_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzq_);
            bool? qzzzzzzzzzzzzzzzzs_ = context.Operators.OverlapsAfter(qzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzr_, "day");
            Code<EventStatus> qzzzzzzzzzzzzzzzzt_ = Procedure?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzzzzu_ = qzzzzzzzzzzzzzzzzt_?.Value;
            string qzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzu_);
            bool? qzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzv_, "completed");
            bool? qzzzzzzzzzzzzzzzzx_ = context.Operators.And(qzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzw_);

            return qzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzk_);
        bool? qzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzl_);

        return qzzzzzzzzzzzzzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzy_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? qzzzzzzzzzzzzzzzzz_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType rzzzzzzzzzzzzzzzzc_ = AllergyIntolerance?.Onset;
            object rzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzd_);
            CqlDateTime rzzzzzzzzzzzzzzzzf_ = context.Operators.Start(rzzzzzzzzzzzzzzzze_);
            FhirDateTime rzzzzzzzzzzzzzzzzg_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime rzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzh_, true, true);
            Period rzzzzzzzzzzzzzzzzj_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzj_);
            bool? rzzzzzzzzzzzzzzzzl_ = context.Operators.OverlapsAfter(rzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzk_, "day");
            CodeableConcept rzzzzzzzzzzzzzzzzm_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept rzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzm_);
            CqlCode rzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept rzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzo_);
            bool? rzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzp_);
            bool? rzzzzzzzzzzzzzzzzr_ = context.Operators.And(rzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzq_);
            CodeableConcept rzzzzzzzzzzzzzzzzs_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept rzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzzzs_);
            CqlCode rzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.allergy_confirmed(context);
            CqlConcept rzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzu_);
            bool? rzzzzzzzzzzzzzzzzw_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzv_);
            bool? rzzzzzzzzzzzzzzzzx_ = context.Operators.And(rzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzw_);

            return rzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzz_);
        bool? rzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzza_);

        return rzzzzzzzzzzzzzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzy_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? rzzzzzzzzzzzzzzzzz_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            List<Dosage> szzzzzzzzzzzzzzzzc_ = MedicationRequest?.DosageInstruction;
            bool? szzzzzzzzzzzzzzzzd_(Dosage @this)
            {
                Timing tzzzzzzzzzzzzzzzzl_ = @this?.Timing;
                bool? tzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzl_ is null));

                return tzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Dosage> szzzzzzzzzzzzzzzze_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)szzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzd_);
            Timing szzzzzzzzzzzzzzzzf_(Dosage @this)
            {
                Timing tzzzzzzzzzzzzzzzzn_ = @this?.Timing;

                return tzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Timing> szzzzzzzzzzzzzzzzg_ = context.Operators.Select<Dosage, Timing>(szzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzf_);
            bool? szzzzzzzzzzzzzzzzh_(Timing @this)
            {
                Timing.RepeatComponent tzzzzzzzzzzzzzzzzo_ = @this?.Repeat;
                bool? tzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzo_ is null));

                return tzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Timing> szzzzzzzzzzzzzzzzi_ = context.Operators.Where<Timing>(szzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzh_);
            Timing.RepeatComponent szzzzzzzzzzzzzzzzj_(Timing @this)
            {
                Timing.RepeatComponent tzzzzzzzzzzzzzzzzq_ = @this?.Repeat;

                return tzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Timing.RepeatComponent> szzzzzzzzzzzzzzzzk_ = context.Operators.Select<Timing, Timing.RepeatComponent>(szzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzj_);
            bool? szzzzzzzzzzzzzzzzl_(Timing.RepeatComponent @this)
            {
                DataType tzzzzzzzzzzzzzzzzr_ = @this?.Bounds;
                object tzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzr_);
                bool? tzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzs_ is null));

                return tzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Timing.RepeatComponent> szzzzzzzzzzzzzzzzm_ = context.Operators.Where<Timing.RepeatComponent>(szzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzl_);
            object szzzzzzzzzzzzzzzzn_(Timing.RepeatComponent @this)
            {
                DataType tzzzzzzzzzzzzzzzzu_ = @this?.Bounds;
                object tzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzu_);

                return tzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<object> szzzzzzzzzzzzzzzzo_ = context.Operators.Select<Timing.RepeatComponent, object>(szzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzp_(object DoseTime)
            {
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return tzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzzzzq_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(szzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzp_);
            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(szzzzzzzzzzzzzzzzq_);
            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzzzzs_ = context.Operators.Collapse(szzzzzzzzzzzzzzzzr_, default);
            object szzzzzzzzzzzzzzzzt_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime tzzzzzzzzzzzzzzzzx_ = context.Operators.Start(@this);

                return tzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(szzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzv_ = context.Operators.First<CqlInterval<CqlDateTime>>(szzzzzzzzzzzzzzzzu_);
            Period szzzzzzzzzzzzzzzzw_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzw_);
            bool? szzzzzzzzzzzzzzzzy_ = context.Operators.OverlapsAfter(szzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzx_, "day");
            Code<MedicationRequest.MedicationrequestStatus> szzzzzzzzzzzzzzzzz_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? tzzzzzzzzzzzzzzzza_ = szzzzzzzzzzzzzzzzz_?.Value;
            string tzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzza_);
            string[] tzzzzzzzzzzzzzzzzc_ = [
                "active",
                "completed",
            ];
            bool? tzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzd_);
            Code<MedicationRequest.MedicationRequestIntent> tzzzzzzzzzzzzzzzzf_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? tzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzf_?.Value;
            string tzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzg_);
            string[] tzzzzzzzzzzzzzzzzi_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? tzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzj_);

            return tzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzza_);

        return szzzzzzzzzzzzzzzzb_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzy_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? tzzzzzzzzzzzzzzzzz_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType uzzzzzzzzzzzzzzzzc_ = HeartRateObservation?.Effective;
            object uzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzd_);
            Period uzzzzzzzzzzzzzzzzf_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzf_);
            bool? uzzzzzzzzzzzzzzzzh_ = context.Operators.OverlapsAfter(uzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzg_, "day");
            Code<ObservationStatus> uzzzzzzzzzzzzzzzzi_ = HeartRateObservation?.StatusElement;
            ObservationStatus? uzzzzzzzzzzzzzzzzj_ = uzzzzzzzzzzzzzzzzi_?.Value;
            string uzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzj_);
            string[] uzzzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? uzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? uzzzzzzzzzzzzzzzzn_ = context.Operators.And(uzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzm_);

            return uzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzza_);

        return uzzzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
