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
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left_ventricular_systolic_dysfunction__disorder_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object czzzzzzzzzzzzzzzzzw_ = context.ResolveParameter("AHAOverall-2.8.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzzzzw_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("isConfirmedActiveDiagnosis")]
    [CqlTag("description", "Returns true if the given Condition is confirmed as active")]
    public bool? isConfirmedActiveDiagnosis(CqlContext context, Condition condition)
    {
        bool? czzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.isActive(context, condition);
        CodeableConcept dzzzzzzzzzzzzzzzzza_ = condition?.VerificationStatus;
        CqlConcept dzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzza_);
        CqlCode dzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.confirmed(context);
        CqlConcept dzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzc_);
        bool? dzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(dzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzd_);
        bool? dzzzzzzzzzzzzzzzzzf_ = context.Operators.And(czzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzze_);

        return dzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("isFinished")]
    [CqlTag("description", "Returns true if the given Encounter is finished")]
    public bool? isFinished(CqlContext context, Encounter Encounter)
    {
        Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzg_ = Encounter?.StatusElement;
        Encounter.EncounterStatus? dzzzzzzzzzzzzzzzzzh_ = dzzzzzzzzzzzzzzzzzg_?.Value;
        Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzzzzzzzzzzh_);
        bool? dzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzi_, "finished");

        return dzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter")]
    [CqlTag("description", "Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: \ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzk_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzm_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzn_);
        CqlValueSet dzzzzzzzzzzzzzzzzzp_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzr_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzt_);
        CqlValueSet dzzzzzzzzzzzzzzzzzv_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzy_(Encounter QualifyingEncounter)
        {
            CqlValueSet ezzzzzzzzzzzzzzzzzc_ = this.Heart_Failure(context);
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? ezzzzzzzzzzzzzzzzze_(Condition HeartFailure)
            {
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
                Period ezzzzzzzzzzzzzzzzzj_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzj_);
                bool? ezzzzzzzzzzzzzzzzzl_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzk_, default);
                bool? ezzzzzzzzzzzzzzzzzm_ = this.isConfirmedActiveDiagnosis(context, HeartFailure);
                bool? ezzzzzzzzzzzzzzzzzn_ = context.Operators.And(ezzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzm_);

                return ezzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Condition> ezzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzze_);
            Encounter ezzzzzzzzzzzzzzzzzg_(Condition HeartFailure) =>
                QualifyingEncounter;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Condition, Encounter>(ezzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzzzzzza_(Encounter QualifyingEncounter)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            Period ezzzzzzzzzzzzzzzzzp_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzp_);
            bool? ezzzzzzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzq_, "day");
            bool? ezzzzzzzzzzzzzzzzzs_ = this.isFinished(context, QualifyingEncounter);
            bool? ezzzzzzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Moderate or Severe LVSD Findings")]
    [CqlTag("description", "Returns a union  of the following:\nObservations where the final, amended or correction ejection fraction result is <= 40\nModerate or Severe LVSD conditions where the diagnosis has been confirmed as active")]
    public IEnumerable<object> Moderate_or_Severe_LVSD_Findings(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzu_ = this.Ejection_Fraction(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? ezzzzzzzzzzzzzzzzzw_(Observation EjectionFraction)
        {
            DataType fzzzzzzzzzzzzzzzzzj_ = EjectionFraction?.Value;
            object fzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzj_);
            CqlQuantity fzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(40m, "%");
            bool? fzzzzzzzzzzzzzzzzzm_ = context.Operators.LessOrEqual(fzzzzzzzzzzzzzzzzzk_ as CqlQuantity, fzzzzzzzzzzzzzzzzzl_);
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzn_ = EjectionFraction?.StatusElement;
            ObservationStatus? fzzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzzn_?.Value;
            Code<ObservationStatus> fzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzo_);
            string fzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzp_);
            string[] fzzzzzzzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? fzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzt_ = context.Operators.And(fzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzs_);

            return fzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzw_);
        CqlValueSet ezzzzzzzzzzzzzzzzzy_ = this.Moderate_or_Severe_LVSD(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlCode fzzzzzzzzzzzzzzzzza_ = this.Left_ventricular_systolic_dysfunction__disorder_(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzza_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzzzzd_(Condition LVSDDiagnosis)
        {
            CodeableConcept fzzzzzzzzzzzzzzzzzu_ = LVSDDiagnosis?.Severity;
            CqlConcept fzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzu_);
            CqlValueSet fzzzzzzzzzzzzzzzzzw_ = this.Moderate_or_Severe(context);
            bool? fzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzw_);

            return fzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(ezzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzze_);
        bool? fzzzzzzzzzzzzzzzzzg_(Condition ModerateOrSevereLVSD)
        {
            bool? fzzzzzzzzzzzzzzzzzy_ = this.isConfirmedActiveDiagnosis(context, ModerateOrSevereLVSD);

            return fzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzg_);
        IEnumerable<object> fzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<object>(ezzzzzzzzzzzzzzzzzx_ as IEnumerable<object>, fzzzzzzzzzzzzzzzzzh_ as IEnumerable<object>);

        return fzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD")]
    [CqlTag("description", "Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding")]
    public IEnumerable<Encounter> Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzz_ = this.Heart_Failure_Outpatient_Encounter(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzza_(Encounter HFOutpatientEncounter)
        {
            IEnumerable<object> gzzzzzzzzzzzzzzzzzc_ = this.Moderate_or_Severe_LVSD_Findings(context);
            bool? gzzzzzzzzzzzzzzzzzd_(object LVSDFindings)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVSDFindings as Condition);
                object gzzzzzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<object>(LVSDFindings, "effective");
                object gzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzh_ ?? gzzzzzzzzzzzzzzzzzk_);
                Period gzzzzzzzzzzzzzzzzzm_ = HFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzm_);
                CqlDateTime gzzzzzzzzzzzzzzzzzo_ = context.Operators.End(gzzzzzzzzzzzzzzzzzn_);
                bool? gzzzzzzzzzzzzzzzzzp_ = context.Operators.Before(gzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzo_, default);

                return gzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<object> gzzzzzzzzzzzzzzzzze_ = context.Operators.Where<object>(gzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzd_);
            Encounter gzzzzzzzzzzzzzzzzzf_(object LVSDFindings) =>
                HFOutpatientEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<object, Encounter>(gzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzf_);

            return gzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Heart Transplant Complications")]
    [CqlTag("description", "Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant_Complications(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzq_ = this.Heart_Transplant_Complications(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzs_(Condition HeartTransplantComplications)
        {
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzx_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? gzzzzzzzzzzzzzzzzzy_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime hzzzzzzzzzzzzzzzzzc_ = HeartTransplantComplications?.RecordedDateElement;
                CqlDateTime hzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartTransplantComplications);
                CqlDateTime hzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(hzzzzzzzzzzzzzzzzze_);
                Period hzzzzzzzzzzzzzzzzzg_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzg_);
                CqlDateTime hzzzzzzzzzzzzzzzzzi_ = context.Operators.End(hzzzzzzzzzzzzzzzzzh_);
                bool? hzzzzzzzzzzzzzzzzzj_ = context.Operators.Before(hzzzzzzzzzzzzzzzzzd_ ?? hzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzi_, default);

                return hzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzy_);
            Condition hzzzzzzzzzzzzzzzzza_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplantComplications;
            IEnumerable<Condition> hzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, Condition>(gzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzza_);

            return hzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Condition, Condition>(gzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzs_);
        bool? gzzzzzzzzzzzzzzzzzu_(Condition HeartTransplantComplications)
        {
            bool? hzzzzzzzzzzzzzzzzzk_ = this.isConfirmedActiveDiagnosis(context, HeartTransplantComplications);

            return hzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzu_);
        bool? gzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzv_);

        return gzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device")]
    [CqlTag("description", "Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzl_ = this.Left_Ventricular_Assist_Device_Placement(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzn_(Procedure LVADOutpatient)
        {
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzs_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? hzzzzzzzzzzzzzzzzzt_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType hzzzzzzzzzzzzzzzzzx_ = LVADOutpatient?.Performed;
                object hzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzy_);
                CqlDateTime izzzzzzzzzzzzzzzzza_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzz_);
                Period izzzzzzzzzzzzzzzzzb_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzb_);
                CqlDateTime izzzzzzzzzzzzzzzzzd_ = context.Operators.End(izzzzzzzzzzzzzzzzzc_);
                bool? izzzzzzzzzzzzzzzzze_ = context.Operators.Before(izzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzd_, default);

                return izzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzt_);
            Procedure hzzzzzzzzzzzzzzzzzv_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADOutpatient;
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, Procedure>(hzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzv_);

            return hzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Procedure, Procedure>(hzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzn_);
        bool? hzzzzzzzzzzzzzzzzzp_(Procedure LVADOutpatient)
        {
            Code<EventStatus> izzzzzzzzzzzzzzzzzf_ = LVADOutpatient?.StatusElement;
            EventStatus? izzzzzzzzzzzzzzzzzg_ = izzzzzzzzzzzzzzzzzf_?.Value;
            string izzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzg_);
            bool? izzzzzzzzzzzzzzzzzi_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzh_, "completed");

            return izzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzp_);
        bool? hzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzzzzq_);

        return hzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Left Ventricular Assist Device Complications")]
    [CqlTag("description", "Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Left_Ventricular_Assist_Device_Complications(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzj_ = this.Left_Ventricular_Assist_Device_Complications(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzl_(Condition LVADComplications)
        {
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzq_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? izzzzzzzzzzzzzzzzzr_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                FhirDateTime izzzzzzzzzzzzzzzzzv_ = LVADComplications?.RecordedDateElement;
                CqlDateTime izzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LVADComplications);
                CqlDateTime izzzzzzzzzzzzzzzzzy_ = context.Operators.Start(izzzzzzzzzzzzzzzzzx_);
                Period izzzzzzzzzzzzzzzzzz_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzz_);
                CqlDateTime jzzzzzzzzzzzzzzzzzb_ = context.Operators.End(jzzzzzzzzzzzzzzzzza_);
                bool? jzzzzzzzzzzzzzzzzzc_ = context.Operators.Before(izzzzzzzzzzzzzzzzzw_ ?? izzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzb_, default);

                return jzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter> izzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzr_);
            Condition izzzzzzzzzzzzzzzzzt_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                LVADComplications;
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, Condition>(izzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzt_);

            return izzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Condition, Condition>(izzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzl_);
        bool? izzzzzzzzzzzzzzzzzn_(Condition LVADComplications)
        {
            bool? jzzzzzzzzzzzzzzzzzd_ = this.isConfirmedActiveDiagnosis(context, LVADComplications);

            return jzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzn_);
        bool? izzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzo_);

        return izzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Qualifying Outpatient Encounter During Measurement Period")]
    [CqlTag("description", "Returns certain finished encounter types that occurred during the measurement period: \noffice visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)\noutpatient consolutations (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)\nnursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)\ncare services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)\nhome healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)\npatient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012)")]
    public IEnumerable<Encounter> Qualifying_Outpatient_Encounter_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzg_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzzzzh_);
        CqlValueSet jzzzzzzzzzzzzzzzzzj_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzl_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzn_);
        CqlValueSet jzzzzzzzzzzzzzzzzzp_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzr_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzzt_);
        bool? jzzzzzzzzzzzzzzzzzv_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzzzzzzzzy_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzy_);
            bool? kzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzz_, "day");
            bool? kzzzzzzzzzzzzzzzzzb_ = this.isFinished(context, ValidEncounter);
            bool? kzzzzzzzzzzzzzzzzzc_ = context.Operators.And(kzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzb_);

            return kzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzv_);

        return jzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Heart Transplant")]
    [CqlTag("description", "Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? Has_Heart_Transplant(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzd_ = this.Heart_Transplant(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzf_(Procedure HeartTransplant)
        {
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzk_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
            bool? kzzzzzzzzzzzzzzzzzl_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
            {
                DataType kzzzzzzzzzzzzzzzzzp_ = HeartTransplant?.Performed;
                object kzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzq_);
                CqlDateTime kzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzr_);
                Period kzzzzzzzzzzzzzzzzzt_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzt_);
                CqlDateTime kzzzzzzzzzzzzzzzzzv_ = context.Operators.End(kzzzzzzzzzzzzzzzzzu_);
                bool? kzzzzzzzzzzzzzzzzzw_ = context.Operators.Before(kzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzv_, default);

                return kzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzl_);
            Procedure kzzzzzzzzzzzzzzzzzn_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter) =>
                HeartTransplant;
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, Procedure>(kzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzn_);

            return kzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Procedure, Procedure>(kzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzf_);
        bool? kzzzzzzzzzzzzzzzzzh_(Procedure HeartTransplant)
        {
            Code<EventStatus> kzzzzzzzzzzzzzzzzzx_ = HeartTransplant?.StatusElement;
            EventStatus? kzzzzzzzzzzzzzzzzzy_ = kzzzzzzzzzzzzzzzzzx_?.Value;
            string kzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzy_);
            bool? lzzzzzzzzzzzzzzzzza_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzz_, "completed");

            return lzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzh_);
        bool? kzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzzi_);

        return kzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period")]
    [CqlTag("description", "Returns true if the patient meets the following criteria:\n18 years of age or older, has two \nHas two Qualifying Outpatient Encounters During Measurement Period\nHas a Heart Failure Outpatient Encounter")]
    public bool? Is_Adults_With_Two_Qualifying_Outpatient_Encounters_and_One_Heart_Failure_Outpatient_Encounter_During_the_Measurement_Period(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string lzzzzzzzzzzzzzzzzzd_ = lzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate lzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzf_);
        CqlDate lzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzg_);
        int? lzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzh_, "year");
        bool? lzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(lzzzzzzzzzzzzzzzzzi_, 18);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzl_(Encounter Encounter1)
        {
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Outpatient_Encounter_During_Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzt_(Encounter Encounter2)
            {
                Id lzzzzzzzzzzzzzzzzzx_ = Encounter2?.IdElement;
                string lzzzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzzzx_?.Value;
                Id lzzzzzzzzzzzzzzzzzz_ = Encounter1?.IdElement;
                string mzzzzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzzzzz_?.Value;
                bool? mzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(lzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzza_);
                bool? mzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(mzzzzzzzzzzzzzzzzzb_);

                return mzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzt_);
            Encounter lzzzzzzzzzzzzzzzzzv_(Encounter Encounter2) =>
                Encounter1;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzv_);

            return lzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzl_);
        bool? lzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzp_ = this.Heart_Failure_Outpatient_Encounter(context);
        bool? lzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzp_);
        bool? lzzzzzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzq_);

        return lzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("isOrderedDuringHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? isOrderedDuringHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzd_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? mzzzzzzzzzzzzzzzzze_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            FhirDateTime mzzzzzzzzzzzzzzzzzh_ = MedicationRequest?.AuthoredOnElement;
            CqlDateTime mzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzh_);
            Period mzzzzzzzzzzzzzzzzzj_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzj_);
            bool? mzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzk_, "day");
            Code<MedicationRequest.MedicationrequestStatus> mzzzzzzzzzzzzzzzzzm_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? mzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzm_?.Value;
            string mzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzn_);
            string[] mzzzzzzzzzzzzzzzzzp_ = [
                "active",
                "completed",
            ];
            bool? mzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzr_ = context.Operators.And(mzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzq_);
            Code<MedicationRequest.MedicationRequestIntent> mzzzzzzzzzzzzzzzzzs_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? mzzzzzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzzzzzs_?.Value;
            string mzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzt_);
            string[] mzzzzzzzzzzzzzzzzzv_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? mzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzx_ = context.Operators.And(mzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzze_);
        bool? mzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzzzzf_);

        return mzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("overlapsHeartFailureOutpatientEncounter")]
    [CqlTag("description", "Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point")]
    public bool? overlapsHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzy_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? mzzzzzzzzzzzzzzzzzz_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period nzzzzzzzzzzzzzzzzzd_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzd_);
            bool? nzzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(nzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzze_, "day");
            bool? nzzzzzzzzzzzzzzzzzg_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? nzzzzzzzzzzzzzzzzzh_ = context.Operators.And(nzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzg_);

            return nzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzz_);
        bool? nzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzza_);

        return nzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Condition Condition)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzi_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? nzzzzzzzzzzzzzzzzzj_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Condition);
            Period nzzzzzzzzzzzzzzzzzn_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzn_);
            bool? nzzzzzzzzzzzzzzzzzp_ = context.Operators.OverlapsAfter(nzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzo_, "day");
            bool? nzzzzzzzzzzzzzzzzzq_ = this.isConfirmedActiveDiagnosis(context, Condition);
            bool? nzzzzzzzzzzzzzzzzzr_ = context.Operators.And(nzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzq_);

            return nzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzj_);
        bool? nzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzk_);

        return nzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Procedure Procedure)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzs_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? nzzzzzzzzzzzzzzzzzt_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType nzzzzzzzzzzzzzzzzzw_ = Procedure?.Performed;
            object nzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzx_);
            Period nzzzzzzzzzzzzzzzzzz_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzz_);
            bool? ozzzzzzzzzzzzzzzzzb_ = context.Operators.OverlapsAfter(nzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzza_, "day");
            Code<EventStatus> ozzzzzzzzzzzzzzzzzc_ = Procedure?.StatusElement;
            EventStatus? ozzzzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzzzzc_?.Value;
            string ozzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzze_, "completed");
            bool? ozzzzzzzzzzzzzzzzzg_ = context.Operators.And(ozzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzf_);

            return ozzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzt_);
        bool? nzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzu_);

        return nzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, AllergyIntolerance AllergyIntolerance)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzh_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? ozzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType ozzzzzzzzzzzzzzzzzl_ = AllergyIntolerance?.Onset;
            object ozzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzm_);
            CqlDateTime ozzzzzzzzzzzzzzzzzo_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzn_);
            FhirDateTime ozzzzzzzzzzzzzzzzzp_ = AllergyIntolerance?.LastOccurrenceElement;
            CqlDateTime ozzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzq_, true, true);
            Period ozzzzzzzzzzzzzzzzzs_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzs_);
            bool? ozzzzzzzzzzzzzzzzzu_ = context.Operators.OverlapsAfter(ozzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzt_, "day");
            CodeableConcept ozzzzzzzzzzzzzzzzzv_ = AllergyIntolerance?.ClinicalStatus;
            CqlConcept ozzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzv_);
            CqlCode ozzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.allergy_active(context);
            CqlConcept ozzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzzzzzzx_);
            bool? ozzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzy_);
            bool? pzzzzzzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzz_);
            CodeableConcept pzzzzzzzzzzzzzzzzzb_ = AllergyIntolerance?.VerificationStatus;
            CqlConcept pzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzb_);
            CqlCode pzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.allergy_confirmed(context);
            CqlConcept pzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzd_);
            bool? pzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzf_);

            return pzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzi_);
        bool? ozzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, MedicationRequest MedicationRequest)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzh_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? pzzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            List<Dosage> pzzzzzzzzzzzzzzzzzl_ = MedicationRequest?.DosageInstruction;
            bool? pzzzzzzzzzzzzzzzzzm_(Dosage @this)
            {
                Timing qzzzzzzzzzzzzzzzzzu_ = @this?.Timing;
                bool? qzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzu_ is null));

                return qzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Dosage> pzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)pzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzm_);
            Timing pzzzzzzzzzzzzzzzzzo_(Dosage @this)
            {
                Timing qzzzzzzzzzzzzzzzzzw_ = @this?.Timing;

                return qzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Timing> pzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Dosage, Timing>(pzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzo_);
            bool? pzzzzzzzzzzzzzzzzzq_(Timing @this)
            {
                Timing.RepeatComponent qzzzzzzzzzzzzzzzzzx_ = @this?.Repeat;
                bool? qzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzx_ is null));

                return qzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Timing> pzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Timing>(pzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzq_);
            Timing.RepeatComponent pzzzzzzzzzzzzzzzzzs_(Timing @this)
            {
                Timing.RepeatComponent qzzzzzzzzzzzzzzzzzz_ = @this?.Repeat;

                return qzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing.RepeatComponent> pzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Timing, Timing.RepeatComponent>(pzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzs_);
            bool? pzzzzzzzzzzzzzzzzzu_(Timing.RepeatComponent @this)
            {
                DataType rzzzzzzzzzzzzzzzzza_ = @this?.Bounds;
                object rzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzza_);
                bool? rzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzb_ is null));

                return rzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Timing.RepeatComponent> pzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Timing.RepeatComponent>(pzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzu_);
            object pzzzzzzzzzzzzzzzzzw_(Timing.RepeatComponent @this)
            {
                DataType rzzzzzzzzzzzzzzzzzd_ = @this?.Bounds;
                object rzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzd_);

                return rzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<object> pzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Timing.RepeatComponent, object>(pzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzy_(object DoseTime)
            {
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return rzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzy_);
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzzzzzzz_);
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzb_ = context.Operators.Collapse(qzzzzzzzzzzzzzzzzza_, default);
            object qzzzzzzzzzzzzzzzzzc_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime rzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(@this);

                return rzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzze_ = context.Operators.First<CqlInterval<CqlDateTime>>(qzzzzzzzzzzzzzzzzzd_);
            Period qzzzzzzzzzzzzzzzzzf_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzf_);
            bool? qzzzzzzzzzzzzzzzzzh_ = context.Operators.OverlapsAfter(qzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzg_, "day");
            Code<MedicationRequest.MedicationrequestStatus> qzzzzzzzzzzzzzzzzzi_ = MedicationRequest?.StatusElement;
            MedicationRequest.MedicationrequestStatus? qzzzzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzzzzi_?.Value;
            string qzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzj_);
            string[] qzzzzzzzzzzzzzzzzzl_ = [
                "active",
                "completed",
            ];
            bool? qzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzm_);
            Code<MedicationRequest.MedicationRequestIntent> qzzzzzzzzzzzzzzzzzo_ = MedicationRequest?.IntentElement;
            MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzzo_?.Value;
            string qzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzp_);
            string[] qzzzzzzzzzzzzzzzzzr_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? qzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? qzzzzzzzzzzzzzzzzzt_ = context.Operators.And(qzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzs_);

            return qzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("overlapsAfterHeartFailureOutpatientEncounter")]
    [CqlTag("overloaded", "")]
    [CqlTag("description", "Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD")]
    public bool? overlapsAfterHeartFailureOutpatientEncounter(CqlContext context, Observation HeartRateObservation)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzh_ = this.Heart_Failure_Outpatient_Encounter_with_History_of_Moderate_or_Severe_LVSD(context);
        bool? rzzzzzzzzzzzzzzzzzi_(Encounter ModerateOrSevereLVSDHFOutpatientEncounter)
        {
            DataType rzzzzzzzzzzzzzzzzzl_ = HeartRateObservation?.Effective;
            object rzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzm_);
            Period rzzzzzzzzzzzzzzzzzo_ = ModerateOrSevereLVSDHFOutpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzo_);
            bool? rzzzzzzzzzzzzzzzzzq_ = context.Operators.OverlapsAfter(rzzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzzp_, "day");
            Code<ObservationStatus> rzzzzzzzzzzzzzzzzzr_ = HeartRateObservation?.StatusElement;
            ObservationStatus? rzzzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzzzr_?.Value;
            string rzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzs_);
            string[] rzzzzzzzzzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? rzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
            bool? rzzzzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzv_);

            return rzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzzzj_);

        return rzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
