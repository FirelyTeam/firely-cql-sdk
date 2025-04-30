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
    private static readonly CqlCode _Left_ventricular_systolic_dysfunction__disorder_ = new CqlCode("134401001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Left_ventricular_systolic_dysfunction__disorder_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object izzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("AHAOverall-2.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    [CqlTag("description", "Returns true if the given Condition is confirmed as active")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? izzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept izzzzzzzzzzzzzzzzzzzzk_ = condition?.VerificationStatus;
        CqlConcept izzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzk_);
        CqlCode izzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept izzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzm_);
        bool? izzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzn_);
        bool? izzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzo_);

        return izzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("isFinished")]
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzq_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? izzzzzzzzzzzzzzzzzzzzr_ = izzzzzzzzzzzzzzzzzzzzq_?.Value;
        Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzzzzzzzr_);
        bool? izzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzs_, "finished");

        return izzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzu_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzzzzzw_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzz_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzf_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzi_(Encounter QualifyingEncounter)
        {
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzm_ = this.Heart_Failure(context);
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? jzzzzzzzzzzzzzzzzzzzzo_(Condition HeartFailure)
            {
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
                Period jzzzzzzzzzzzzzzzzzzzzt_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzt_);
                bool? jzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(jzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzu_, default);
                bool? jzzzzzzzzzzzzzzzzzzzzw_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? jzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzw_);

                return jzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(jzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzo_);
            Encounter jzzzzzzzzzzzzzzzzzzzzq_(Condition HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Condition, Encounter>(jzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzi_);
        bool? jzzzzzzzzzzzzzzzzzzzzk_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzzzzzzzzzzzz_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzz_);
            bool? kzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzc_ = this.isFinished(context, QualifyingEncounter);
            bool? kzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzc_);

            return kzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzze_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? kzzzzzzzzzzzzzzzzzzzzg_(Observation EjectionFraction)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzt_ = EjectionFraction?.Value;
            object kzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(40m, "%");
            bool? kzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.LessOrEqual(kzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, kzzzzzzzzzzzzzzzzzzzzv_);
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzx_ = EjectionFraction?.StatusElement;
            ObservationStatus? kzzzzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzzzzx_?.Value;
            Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzy_);
            string lzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzz_);
            string[] lzzzzzzzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? lzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzc_);

            return lzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzi_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode kzzzzzzzzzzzzzzzzzzzzk_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzzzzzzzzzzzzzzzn_(Condition LVSDDiagnosis)
        {
            CodeableConcept lzzzzzzzzzzzzzzzzzzzze_ = LVSDDiagnosis?.Severity;
            CqlConcept lzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzze_);
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzg_ = this.Moderate_or_Severe(context);
            bool? lzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzg_);

            return lzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(kzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzo_);
        bool? kzzzzzzzzzzzzzzzzzzzzq_(Condition ModerateOrSevereLVSD)
        {
            bool? lzzzzzzzzzzzzzzzzzzzzi_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return lzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<object> kzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<object>(kzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<object>, kzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<object>);

        return kzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzj_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzk_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> lzzzzzzzzzzzzzzzzzzzzm_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? lzzzzzzzzzzzzzzzzzzzzn_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object lzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object lzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzr_ ?? lzzzzzzzzzzzzzzzzzzzzu_);
                Period lzzzzzzzzzzzzzzzzzzzzw_ = HFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzx_);
                bool? lzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Before(lzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzy_, default);

                return lzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<object> lzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<object>(lzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzn_);
            Encounter lzzzzzzzzzzzzzzzzzzzzp_(object LVSDFindings) =>
                HFOutpatientEncounter;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<object, Encounter>(lzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzp_);

            return lzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzza_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzc_(Condition HeartTransplantComplications)
        {
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzh_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? mzzzzzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime mzzzzzzzzzzzzzzzzzzzzm_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzo_);
                Period mzzzzzzzzzzzzzzzzzzzzq_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzr_);
                bool? mzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Before(mzzzzzzzzzzzzzzzzzzzzn_ ?? mzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzs_, default);

                return mzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzi_);
            Condition mzzzzzzzzzzzzzzzzzzzzk_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, Condition>(mzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzk_);

            return mzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Condition, Condition>(mzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzzzzzzze_(Condition HeartTransplantComplications)
        {
            bool? mzzzzzzzzzzzzzzzzzzzzu_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return mzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzze_);
        bool? mzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzzzzf_);

        return mzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzv_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzx_(Procedure LVADOutpatient)
        {
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzc_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? nzzzzzzzzzzzzzzzzzzzzd_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzh_ = LVADOutpatient?.Performed;
                object nzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzj_);
                Period nzzzzzzzzzzzzzzzzzzzzl_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzm_);
                bool? nzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Before(nzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzn_, default);

                return nzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzzzzd_);
            Procedure nzzzzzzzzzzzzzzzzzzzzf_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADOutpatient;
            IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Procedure>(nzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzf_);

            return nzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Procedure, Procedure>(mzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzx_);
        bool? mzzzzzzzzzzzzzzzzzzzzz_(Procedure LVADOutpatient)
        {
            Code<EventStatus> nzzzzzzzzzzzzzzzzzzzzp_ = LVADOutpatient?.StatusElement;
            EventStatus? nzzzzzzzzzzzzzzzzzzzzq_ = nzzzzzzzzzzzzzzzzzzzzp_?.Value;
            string nzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzq_);
            bool? nzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzr_, "completed");

            return nzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzz_);
        bool? nzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Procedure>(nzzzzzzzzzzzzzzzzzzzza_);

        return nzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzt_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzv_(Condition LVADComplications)
        {
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzza_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? ozzzzzzzzzzzzzzzzzzzzb_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime ozzzzzzzzzzzzzzzzzzzzf_ = LVADComplications?.RecordedDateElement;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzh_);
                Period ozzzzzzzzzzzzzzzzzzzzj_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzk_);
                bool? ozzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Before(ozzzzzzzzzzzzzzzzzzzzg_ ?? ozzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzl_, default);

                return ozzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzb_);
            Condition ozzzzzzzzzzzzzzzzzzzzd_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<Condition> ozzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, Condition>(ozzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzd_);

            return ozzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Condition, Condition>(nzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzzzzzzzx_(Condition LVADComplications)
        {
            bool? ozzzzzzzzzzzzzzzzzzzzn_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return ozzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzx_);
        bool? nzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzy_);

        return nzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzo_ = this.Office_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzq_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzt_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzv_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzz_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzb_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzd_);
        bool? pzzzzzzzzzzzzzzzzzzzzf_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzzzzzzzzi_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzi_);
            bool? pzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzl_ = this.isFinished(context, ValidEncounter);
            bool? pzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzl_);

            return pzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzf_);

        return pzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzn_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzp_(Procedure HeartTransplant)
        {
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzu_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? pzzzzzzzzzzzzzzzzzzzzv_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzz_ = HeartTransplant?.Performed;
                object qzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzb_);
                Period qzzzzzzzzzzzzzzzzzzzzd_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzze_);
                bool? qzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Before(qzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzf_, default);

                return qzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzv_);
            Procedure pzzzzzzzzzzzzzzzzzzzzx_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplant;
            IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, Procedure>(pzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzx_);

            return pzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SelectMany<Procedure, Procedure>(pzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzp_);
        bool? pzzzzzzzzzzzzzzzzzzzzr_(Procedure HeartTransplant)
        {
            Code<EventStatus> qzzzzzzzzzzzzzzzzzzzzh_ = HeartTransplant?.StatusElement;
            EventStatus? qzzzzzzzzzzzzzzzzzzzzi_ = qzzzzzzzzzzzzzzzzzzzzh_?.Value;
            string qzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzi_);
            bool? qzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzzzj_, "completed");

            return qzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> pzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Procedure>(pzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzr_);
        bool? pzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(pzzzzzzzzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older, has two \nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
    {
        Patient qzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date qzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string qzzzzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate qzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate qzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzq_);
        int? qzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzr_, "year");
        bool? qzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.GreaterOrEqual(qzzzzzzzzzzzzzzzzzzzzs_, 18);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzv_(Encounter Encounter1)
        {
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzc_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzzzzd_(Encounter Encounter2)
            {
                Id rzzzzzzzzzzzzzzzzzzzzh_ = Encounter2?.IdElement;
                string rzzzzzzzzzzzzzzzzzzzzi_ = rzzzzzzzzzzzzzzzzzzzzh_?.Value;
                Id rzzzzzzzzzzzzzzzzzzzzj_ = Encounter1?.IdElement;
                string rzzzzzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzzzzzj_?.Value;
                bool? rzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(rzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzk_);
                bool? rzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not(rzzzzzzzzzzzzzzzzzzzzl_);

                return rzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzd_);
            Encounter rzzzzzzzzzzzzzzzzzzzzf_(Encounter Encounter2) =>
                Encounter1;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzf_);

            return rzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzv_);
        bool? qzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzw_);
        bool? qzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzz_ = this.Heart_Failure_Outpatient_Encounter(context);
        bool? rzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzz_);
        bool? rzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzza_);

        return rzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("isOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzn_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? rzzzzzzzzzzzzzzzzzzzzo_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            FhirDateTime rzzzzzzzzzzzzzzzzzzzzr_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzr_);
            Period rzzzzzzzzzzzzzzzzzzzzt_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzt_);
            bool? rzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzu_, "day");
            Code<MedicationRequest.MedicationrequestStatus> rzzzzzzzzzzzzzzzzzzzzw_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? rzzzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzzzw_?.Value;
            string rzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzx_);
            string[] rzzzzzzzzzzzzzzzzzzzzz_ = [
                "active",
                "completed",
            ];
            bool? szzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzza_);
            Code<MedicationRequest.MedicationRequestIntent> szzzzzzzzzzzzzzzzzzzzc_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? szzzzzzzzzzzzzzzzzzzzd_ = szzzzzzzzzzzzzzzzzzzzc_?.Value;
            string szzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzd_);
            string[] szzzzzzzzzzzzzzzzzzzzf_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? szzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzg_);

            return szzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzzzzo_);
        bool? rzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzzzzzzp_);

        return rzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("overlapsHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzi_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? szzzzzzzzzzzzzzzzzzzzj_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period szzzzzzzzzzzzzzzzzzzzn_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzn_);
            bool? szzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(szzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzq_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? szzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzq_);

            return szzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzj_);
        bool? szzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzs_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? szzzzzzzzzzzzzzzzzzzzt_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period szzzzzzzzzzzzzzzzzzzzx_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzx_);
            bool? szzzzzzzzzzzzzzzzzzzzz_ = context.Operators.OverlapsAfter(szzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzy_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzza_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? tzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzza_);

            return tzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzt_);
        bool? szzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzzzzu_);

        return szzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzc_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? tzzzzzzzzzzzzzzzzzzzzd_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzg_ = Procedure?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzh_);
            Period tzzzzzzzzzzzzzzzzzzzzj_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.OverlapsAfter(tzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzk_, "day");
            Code<EventStatus> tzzzzzzzzzzzzzzzzzzzzm_ = Procedure?.StatusElement;
            EventStatus? tzzzzzzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzzzzzzm_?.Value;
            string tzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzn_);
            bool? tzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzo_, "completed");
            bool? tzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzp_);

            return tzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzd_);
        bool? tzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzzzzzzzze_);

        return tzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzr_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? tzzzzzzzzzzzzzzzzzzzzs_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzv_ = AllergyIntolerance?.Onset;
            object tzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzx_);
            FhirDateTime tzzzzzzzzzzzzzzzzzzzzz_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime uzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzza_, true, true);
            Period uzzzzzzzzzzzzzzzzzzzzc_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzc_);
            bool? uzzzzzzzzzzzzzzzzzzzze_ = context.Operators.OverlapsAfter(uzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzd_, "day");
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzf_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzf_);
            CqlCode uzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept uzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzzzzzh_);
            bool? uzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzi_);
            bool? uzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzj_);
            CodeableConcept uzzzzzzzzzzzzzzzzzzzzl_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzzzzzzzl_);
            CqlCode uzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.allergy_confirmed(context);
            CqlConcept uzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzzzzzn_);
            bool? uzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(uzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzo_);
            bool? uzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzp_);

            return uzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzs_);
        bool? tzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzr_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? uzzzzzzzzzzzzzzzzzzzzs_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            List<Dosage> uzzzzzzzzzzzzzzzzzzzzv_ = MedicationRequest?.DosageInstruction;
            bool? uzzzzzzzzzzzzzzzzzzzzw_(Dosage @this)
            {
                Timing wzzzzzzzzzzzzzzzzzzzze_ = @this?.Timing;
                bool? wzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzze_ is null));

                return wzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Dosage> uzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)uzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzw_);
            Timing uzzzzzzzzzzzzzzzzzzzzy_(Dosage @this)
            {
                Timing wzzzzzzzzzzzzzzzzzzzzg_ = @this?.Timing;

                return wzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Timing> uzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Dosage, Timing>(uzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzy_);
            bool? vzzzzzzzzzzzzzzzzzzzza_(Timing @this)
            {
                Timing.RepeatComponent wzzzzzzzzzzzzzzzzzzzzh_ = @this?.Repeat;
                bool? wzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzh_ is null));

                return wzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Timing> vzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Timing>(uzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzza_);
            Timing.RepeatComponent vzzzzzzzzzzzzzzzzzzzzc_(Timing @this)
            {
                Timing.RepeatComponent wzzzzzzzzzzzzzzzzzzzzj_ = @this?.Repeat;

                return wzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Timing.RepeatComponent> vzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Timing, Timing.RepeatComponent>(vzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzc_);
            bool? vzzzzzzzzzzzzzzzzzzzze_(Timing.RepeatComponent @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzk_ = @this?.Bounds;
                object wzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzk_);
                bool? wzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzl_ is null));

                return wzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Timing.RepeatComponent> vzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Timing.RepeatComponent>(vzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzze_);
            object vzzzzzzzzzzzzzzzzzzzzg_(Timing.RepeatComponent @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzn_ = @this?.Bounds;
                object wzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzn_);

                return wzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Timing.RepeatComponent, object>(vzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzi_(object DoseTime)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return wzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzi_);
            IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Collapse(vzzzzzzzzzzzzzzzzzzzzk_, default);
            object vzzzzzzzzzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(@this);

                return wzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzzzzzzzzn_);
            Period vzzzzzzzzzzzzzzzzzzzzp_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzp_);
            bool? vzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.OverlapsAfter(vzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzq_, "day");
            Code<MedicationRequest.MedicationrequestStatus> vzzzzzzzzzzzzzzzzzzzzs_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? vzzzzzzzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzzzzzzzs_?.Value;
            string vzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzt_);
            string[] vzzzzzzzzzzzzzzzzzzzzv_ = [
                "active",
                "completed",
            ];
            bool? vzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? vzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzw_);
            Code<MedicationRequest.MedicationRequestIntent> vzzzzzzzzzzzzzzzzzzzzy_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? vzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzy_?.Value;
            string wzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzz_);
            string[] wzzzzzzzzzzzzzzzzzzzzb_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? wzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? wzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzs_);
        bool? uzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzr_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? wzzzzzzzzzzzzzzzzzzzzs_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzv_ = HeartRateObservation?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzw_);
            Period wzzzzzzzzzzzzzzzzzzzzy_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzy_);
            bool? xzzzzzzzzzzzzzzzzzzzza_ = context.Operators.OverlapsAfter(wzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzz_, "day");
            Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzb_ = HeartRateObservation?.StatusElement;
            ObservationStatus? xzzzzzzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzzzzzzb_?.Value;
            string xzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzc_);
            string[] xzzzzzzzzzzzzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? xzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzf_);

            return xzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzzzzt_);

        return wzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

}
