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

    #region ValueSet: HIV
    [CqlValueSetDefinition(
        definitionName: "HIV",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003",
        valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext context) => _HIV;

    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);
    #endregion

    #region ValueSet: Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)
    [CqlValueSetDefinition(
        definitionName: "Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50",
        valueSetVersion: null)]
    public CqlValueSet Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(CqlContext context) => _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_;

    private static readonly CqlValueSet _Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Preventive Care Services - Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services - Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care Services-Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services-Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Birth date
    [CqlCodeDefinition(
        definitionName: "Birth date",
        codeId: "21112-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext context) => _Birth_date;

    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org", default, default);
    #endregion

    #region Code: HIV 1 and 2 tests - Meaningful Use set
    [CqlCodeDefinition(
        definitionName: "HIV 1 and 2 tests - Meaningful Use set",
        codeId: "75622-1",
        codeSystem: "http://loinc.org")]
    public CqlCode HIV_1_and_2_tests___Meaningful_Use_set(CqlContext context) => _HIV_1_and_2_tests___Meaningful_Use_set;

    private static readonly CqlCode _HIV_1_and_2_tests___Meaningful_Use_set = new CqlCode("75622-1", "http://loinc.org", default, default);
    #endregion

    #region Code: AMB
    [CqlCodeDefinition(
        definitionName: "AMB",
        codeId: "AMB",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode AMB(CqlContext context) => _AMB;

    private static readonly CqlCode _AMB = new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);
    #endregion

    #region Code: active
    [CqlCodeDefinition(
        definitionName: "active",
        codeId: "active",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-clinical")]
    public CqlCode active(CqlContext context) => _active;

    private static readonly CqlCode _active = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);
    #endregion

    #region Code: refuted
    [CqlCodeDefinition(
        definitionName: "refuted",
        codeId: "refuted",
        codeSystem: "http://terminology.hl7.org/CodeSystem/condition-ver-status")]
    public CqlCode refuted(CqlContext context) => _refuted;

    private static readonly CqlCode _refuted = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);
    #endregion

    #region Code: Dead (finding)
    [CqlCodeDefinition(
        definitionName: "Dead (finding)",
        codeId: "419099009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext context) => _Dead__finding_;

    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
            new CqlCode("75622-1", "http://loinc.org", default, default),
        ];

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
            new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
        ];

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
            new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
        ];

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ConditionVerificationStatus")]
    public CqlCode[] ConditionVerificationStatus(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
            new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
        ];

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
            new CqlCode("419099009", "http://snomed.info/sct", default, default),
        ];

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.ResolveParameter("HIVScreeningFHIR-0.2.000", "Measurement Period", jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Office_Visit(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter Encounter)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Encounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<Encounter.EncounterStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "finished");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        int? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "year");
        CqlInterval<int?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(15, 65, true, true);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<int?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Encounters(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Initial_Population(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has HIV Test Performed")]
    public bool? Has_HIV_Test_Performed(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Human_Immunodeficiency_Virus__HIV__Laboratory_Test_Codes__Ab_and_Ag_(context);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.HIV_1_and_2_tests___Meaningful_Use_set(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation HIVTest)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = HIVTest?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            Patient mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
            Date mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = HIVTest?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            int? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "year");
            CqlInterval<int?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(15, 65, true, true);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<int?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Before(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = HIVTest?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "final");
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "amended");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "corrected");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_HIV_Test_Performed(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.HIV(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Condition HIV)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HIV);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Before(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = HIV?.VerificationStatus;
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.refuted(context);
            CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Patient Expired")]
    public bool? Patient_Expired(CqlContext context)
    {
        Patient ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Patient(context);
        DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Deceased;
        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient_Expired(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
