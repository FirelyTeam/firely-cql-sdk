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
[CqlLibrary("HIVScreeningFHIR", "0.2.000")]
public partial class HIVScreeningFHIR_0_2_000 : ILibrary, ISingleton<HIVScreeningFHIR_0_2_000>
{
    private HIVScreeningFHIR_0_2_000() {}

    public static HIVScreeningFHIR_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HIVScreeningFHIR";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50", valueSetVersion: null)]
    public CqlValueSet Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(CqlContext _) => _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_;
    private static readonly CqlValueSet _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("HIV 1 and 2 tests - Meaningful Use set", codeId: "75622-1", codeSystem: "http://loinc.org")]
    public CqlCode HIV_1_and_2_tests___Meaningful_Use_set(CqlContext _) => _HIV_1_and_2_tests___Meaningful_Use_set;
    private static readonly CqlCode _HIV_1_and_2_tests___Meaningful_Use_set = new CqlCode("75622-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("AMB", codeId: "AMB", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext _) => _AMB;
    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlCodeDefinition("active", codeId: "active", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext _) => _active;
    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlCodeDefinition("refuted", codeId: "refuted", codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext _) => _refuted;
    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlCodeDefinition("Dead (finding)", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext _) => _Dead__finding_;
    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionClinicalStatusCodes")]
    public CqlCodeSystem ConditionClinicalStatusCodes(CqlContext _) => _ConditionClinicalStatusCodes;
    private static readonly CqlCodeSystem _ConditionClinicalStatusCodes = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ConditionVerificationStatus")]
    public CqlCodeSystem ConditionVerificationStatus(CqlContext _) => _ConditionVerificationStatus;
    private static readonly CqlCodeSystem _ConditionVerificationStatus = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime szzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzm_ = context.Operators.Interval(szzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzl_, true, true);
        object szzzzzzzzzzzzzzzn_ = context.ResolveParameter("HIVScreeningFHIR-0.2.000", "Measurement Period", szzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzzzzzs_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzt_);
        CqlValueSet szzzzzzzzzzzzzzzv_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzzzzzx_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(szzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzz_);
        CqlValueSet tzzzzzzzzzzzzzzzb_ = this.Office_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzc_);
        bool? tzzzzzzzzzzzzzzze_(Encounter Encounter)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            Period tzzzzzzzzzzzzzzzh_ = Encounter?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzh_);
            bool? tzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzi_, "day");
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzk_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? tzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzk_?.Value;
            Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzzzzzzzzzl_);
            bool? tzzzzzzzzzzzzzzzn_ = context.Operators.Equal(tzzzzzzzzzzzzzzzm_, "finished");
            bool? tzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzn_);

            return tzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzze_);

        return tzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient tzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date tzzzzzzzzzzzzzzzq_ = tzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string tzzzzzzzzzzzzzzzr_ = tzzzzzzzzzzzzzzzq_?.Value;
        CqlDate tzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzzzzzzu_ = context.Operators.Start(tzzzzzzzzzzzzzzzt_);
        CqlDate tzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzu_);
        int? tzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzv_, "year");
        CqlInterval<int?> tzzzzzzzzzzzzzzzx_ = context.Operators.Interval(15, 65, true, true);
        bool? tzzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(tzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzx_, default);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzz_ = this.Qualifying_Encounters(context);
        bool? uzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzza_);

        return uzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);

        return uzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has HIV Test Performed")]
    public bool? Has_HIV_Test_Performed(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzd_ = this.Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(context);
        IEnumerable<Observation> uzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode uzzzzzzzzzzzzzzzf_ = this.HIV_1_and_2_tests___Meaningful_Use_set(context);
        IEnumerable<CqlCode> uzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(uzzzzzzzzzzzzzzzf_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, uzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> uzzzzzzzzzzzzzzzi_ = context.Operators.Union<Observation>(uzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzh_);
        bool? uzzzzzzzzzzzzzzzj_(Observation HIVTest)
        {
            DataType uzzzzzzzzzzzzzzzm_ = HIVTest?.Value;
            object uzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzn_ is null));
            Patient uzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date uzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string uzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzq_?.Value;
            CqlDate uzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzr_);
            DataType uzzzzzzzzzzzzzzzt_ = HIVTest?.Effective;
            object uzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzu_);
            CqlDateTime uzzzzzzzzzzzzzzzw_ = context.Operators.Start(uzzzzzzzzzzzzzzzv_);
            CqlDate uzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzw_);
            int? uzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzx_, "year");
            CqlInterval<int?> uzzzzzzzzzzzzzzzz_ = context.Operators.Interval(15, 65, true, true);
            bool? vzzzzzzzzzzzzzzza_ = context.Operators.In<int?>(uzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzz_, default);
            bool? vzzzzzzzzzzzzzzzb_ = context.Operators.And(uzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzza_);
            object vzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzd_);
            CqlDateTime vzzzzzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzh_ = context.Operators.End(vzzzzzzzzzzzzzzzg_);
            bool? vzzzzzzzzzzzzzzzi_ = context.Operators.Before(vzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzh_, default);
            bool? vzzzzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzi_);
            Code<ObservationStatus> vzzzzzzzzzzzzzzzk_ = HIVTest?.StatusElement;
            ObservationStatus? vzzzzzzzzzzzzzzzl_ = vzzzzzzzzzzzzzzzk_?.Value;
            Code<ObservationStatus> vzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzl_);
            bool? vzzzzzzzzzzzzzzzn_ = context.Operators.Equal(vzzzzzzzzzzzzzzzm_, "final");
            ObservationStatus? vzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzk_?.Value;
            Code<ObservationStatus> vzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzp_);
            bool? vzzzzzzzzzzzzzzzr_ = context.Operators.Equal(vzzzzzzzzzzzzzzzq_, "amended");
            bool? vzzzzzzzzzzzzzzzs_ = context.Operators.Or(vzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzr_);
            ObservationStatus? vzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzk_?.Value;
            Code<ObservationStatus> vzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzu_);
            bool? vzzzzzzzzzzzzzzzw_ = context.Operators.Equal(vzzzzzzzzzzzzzzzv_, "corrected");
            bool? vzzzzzzzzzzzzzzzx_ = context.Operators.Or(vzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzw_);
            bool? vzzzzzzzzzzzzzzzy_ = context.Operators.And(vzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzx_);

            return vzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzj_);
        bool? uzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(uzzzzzzzzzzzzzzzk_);

        return uzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzz_ = this.Has_HIV_Test_Performed(context);

        return vzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzza_ = this.HIV(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? wzzzzzzzzzzzzzzzc_(Condition HIV)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime wzzzzzzzzzzzzzzzg_ = context.Operators.Start(wzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzzi_ = context.Operators.Start(wzzzzzzzzzzzzzzzh_);
            bool? wzzzzzzzzzzzzzzzj_ = context.Operators.Before(wzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzi_, "day");
            CodeableConcept wzzzzzzzzzzzzzzzk_ = HIV?.VerificationStatus;
            CqlConcept wzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzzzzzk_);
            CqlCode wzzzzzzzzzzzzzzzm_ = this.refuted(context);
            CqlConcept wzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzzm_);
            bool? wzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzn_);
            bool? wzzzzzzzzzzzzzzzp_ = context.Operators.Not(wzzzzzzzzzzzzzzzo_);
            bool? wzzzzzzzzzzzzzzzq_ = context.Operators.And(wzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzp_);

            return wzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzd_ = context.Operators.Where<Condition>(wzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzzzr_ = this.Patient(context);
        DataType wzzzzzzzzzzzzzzzs_ = wzzzzzzzzzzzzzzzr_?.Deceased;
        object wzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzv_ = context.Operators.End(wzzzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzzzw_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzzt_ as CqlDateTime, wzzzzzzzzzzzzzzzv_, default);

        return wzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzx_ = this.Patient_Expired(context);

        return wzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
