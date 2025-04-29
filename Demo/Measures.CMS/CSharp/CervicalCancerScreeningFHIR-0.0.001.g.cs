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
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.001")]
public partial class CervicalCancerScreeningFHIR_0_0_001 : ILibrary, ISingleton<CervicalCancerScreeningFHIR_0_0_001>
{
    private CervicalCancerScreeningFHIR_0_0_001() {}

    public static CervicalCancerScreeningFHIR_0_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CervicalCancerScreeningFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, Hospice_6_12_000.Instance, PalliativeCare_1_11_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Congenital or Acquired Absence of Cervix
    [CqlValueSetDefinition(
        definitionName: "Congenital or Acquired Absence of Cervix",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext context) => _Congenital_or_Acquired_Absence_of_Cervix;

    private static readonly CqlValueSet _Congenital_or_Acquired_Absence_of_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: HPV Test
    [CqlValueSetDefinition(
        definitionName: "HPV Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059",
        valueSetVersion: null)]
    public CqlValueSet HPV_Test(CqlContext context) => _HPV_Test;

    private static readonly CqlValueSet _HPV_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);
    #endregion

    #region ValueSet: Hysterectomy with No Residual Cervix
    [CqlValueSetDefinition(
        definitionName: "Hysterectomy with No Residual Cervix",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014",
        valueSetVersion: null)]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext context) => _Hysterectomy_with_No_Residual_Cervix;

    private static readonly CqlValueSet _Hysterectomy_with_No_Residual_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Pap Test
    [CqlValueSetDefinition(
        definitionName: "Pap Test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017",
        valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext context) => _Pap_Test;

    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isEncounterPerformed(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        int? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "year");
        CqlInterval<int?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(24, 64, true, true);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<int?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
        Code<AdministrativeGender> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.GenderElement;
        AdministrativeGender? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "female");
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounters(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Initial_Population(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure NoCervixProcedure)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = NoCervixProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<object> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<object>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<object>, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<object>);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Absence_of_Cervix(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<object>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Pap_Test(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation CervicalCytology)
        {
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
            {
                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                };
                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                    bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                    return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                };
                if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                {
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.latest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_());
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(2m, "years");
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CervicalCytology?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.HPV_Test(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation HPVTest)
        {
            Patient nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
            Date nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HPVTest?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.latest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_());
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            int? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "year");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, 30);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
            {
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = HPVTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = HPVTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = HPVTest?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                    return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.latest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(4m, "years");
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HPVTest?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Expressions

}
