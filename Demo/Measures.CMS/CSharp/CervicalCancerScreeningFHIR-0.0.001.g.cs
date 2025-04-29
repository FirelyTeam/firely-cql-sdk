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

    [CqlValueSetDefinition("Congenital or Acquired Absence of Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", valueSetVersion: null)]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext _) => _Congenital_or_Acquired_Absence_of_Cervix;
    private static readonly CqlValueSet _Congenital_or_Acquired_Absence_of_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("HPV Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", valueSetVersion: null)]
    public CqlValueSet HPV_Test(CqlContext _) => _HPV_Test;
    private static readonly CqlValueSet _HPV_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlValueSetDefinition("Hysterectomy with No Residual Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", valueSetVersion: null)]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext _) => _Hysterectomy_with_No_Residual_Cervix;
    private static readonly CqlValueSet _Hysterectomy_with_No_Residual_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pap Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext _) => _Pap_Test;
    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzb_ = context.Operators.Interval(izzzzzzzzzzzzzz_, jzzzzzzzzzzzzza_, true, true);
        object jzzzzzzzzzzzzzc_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", jzzzzzzzzzzzzzb_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzi_);
        CqlValueSet jzzzzzzzzzzzzzk_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzm_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzo_);
        CqlValueSet jzzzzzzzzzzzzzq_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet jzzzzzzzzzzzzzs_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, jzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isEncounterPerformed(context, jzzzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzzzx_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            Period kzzzzzzzzzzzzza_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzb_ as object);
            bool? kzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzc_, "day");

            return kzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzx_);

        return jzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient kzzzzzzzzzzzzze_ = this.Patient(context);
        Date kzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzze_?.BirthDateElement;
        string kzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzf_?.Value;
        CqlDate kzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(kzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzzzj_ = context.Operators.End(kzzzzzzzzzzzzzi_);
        CqlDate kzzzzzzzzzzzzzk_ = context.Operators.DateFrom(kzzzzzzzzzzzzzj_);
        int? kzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzk_, "year");
        CqlInterval<int?> kzzzzzzzzzzzzzm_ = context.Operators.Interval(24, 64, true, true);
        bool? kzzzzzzzzzzzzzn_ = context.Operators.In<int?>(kzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzm_, default);
        Code<AdministrativeGender> kzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzze_?.GenderElement;
        AdministrativeGender? kzzzzzzzzzzzzzq_ = kzzzzzzzzzzzzzp_?.Value;
        string kzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzzzs_ = context.Operators.Equal(kzzzzzzzzzzzzzr_, "female");
        bool? kzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzu_ = this.Qualifying_Encounters(context);
        bool? kzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzu_);
        bool? kzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzv_);

        return kzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzx_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzy_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzzzzzzzzzzz_);
        bool? lzzzzzzzzzzzzzb_(Procedure NoCervixProcedure)
        {
            DataType lzzzzzzzzzzzzzi_ = NoCervixProcedure?.Performed;
            object lzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzj_);
            CqlDateTime lzzzzzzzzzzzzzl_ = context.Operators.End(lzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzn_, default);

            return lzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzza_, lzzzzzzzzzzzzzb_);
        CqlValueSet lzzzzzzzzzzzzzd_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> lzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? lzzzzzzzzzzzzzf_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime lzzzzzzzzzzzzzq_ = context.Operators.Start(lzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzs_ = context.Operators.End(lzzzzzzzzzzzzzr_);
            bool? lzzzzzzzzzzzzzt_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzs_, default);

            return lzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzze_, lzzzzzzzzzzzzzf_);
        IEnumerable<object> lzzzzzzzzzzzzzh_ = context.Operators.Union<object>(lzzzzzzzzzzzzzc_ as IEnumerable<object>, lzzzzzzzzzzzzzg_ as IEnumerable<object>);

        return lzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzu_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> lzzzzzzzzzzzzzv_ = this.Absence_of_Cervix(context);
        bool? lzzzzzzzzzzzzzw_ = context.Operators.Exists<object>(lzzzzzzzzzzzzzv_);
        bool? lzzzzzzzzzzzzzx_ = context.Operators.Or(lzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzw_);
        bool? lzzzzzzzzzzzzzy_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzz_ = context.Operators.Or(lzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzy_);

        return lzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzza_ = this.Pap_Test(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> mzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, mzzzzzzzzzzzzzb_);
        bool? mzzzzzzzzzzzzzd_(Observation CervicalCytology)
        {
            object mzzzzzzzzzzzzzf_()
            {
                bool mzzzzzzzzzzzzzt_()
                {
                    DataType mzzzzzzzzzzzzzw_ = CervicalCytology?.Effective;
                    object mzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzw_);
                    bool mzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzx_ is CqlDateTime;

                    return mzzzzzzzzzzzzzy_;
                };
                bool mzzzzzzzzzzzzzu_()
                {
                    DataType mzzzzzzzzzzzzzz_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzz_);
                    bool nzzzzzzzzzzzzzb_ = nzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                    return nzzzzzzzzzzzzzb_;
                };
                bool mzzzzzzzzzzzzzv_()
                {
                    DataType nzzzzzzzzzzzzzc_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzc_);
                    bool nzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzd_ is CqlDateTime;

                    return nzzzzzzzzzzzzze_;
                };
                if (mzzzzzzzzzzzzzt_())
                {
                    DataType nzzzzzzzzzzzzzf_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzf_);

                    return (nzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else if (mzzzzzzzzzzzzzu_())
                {
                    DataType nzzzzzzzzzzzzzh_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzh_);

                    return (nzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (mzzzzzzzzzzzzzv_())
                {
                    DataType nzzzzzzzzzzzzzj_ = CervicalCytology?.Effective;
                    object nzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzj_);

                    return (nzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime mzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.latest(context, mzzzzzzzzzzzzzf_());
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzi_ = context.Operators.Start(mzzzzzzzzzzzzzh_);
            CqlQuantity mzzzzzzzzzzzzzj_ = context.Operators.Quantity(2m, "years");
            CqlDateTime mzzzzzzzzzzzzzk_ = context.Operators.Subtract(mzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzj_);
            CqlDateTime mzzzzzzzzzzzzzm_ = context.Operators.End(mzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzn_ = context.Operators.Interval(mzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzm_, true, true);
            bool? mzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzn_, "day");
            DataType mzzzzzzzzzzzzzp_ = CervicalCytology?.Value;
            object mzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzq_ is null));
            bool? mzzzzzzzzzzzzzs_ = context.Operators.And(mzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzr_);

            return mzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzl_ = this.HPV_Test(context);
        IEnumerable<Observation> nzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, nzzzzzzzzzzzzzm_);
        bool? nzzzzzzzzzzzzzo_(Observation HPVTest)
        {
            Patient nzzzzzzzzzzzzzq_ = this.Patient(context);
            Date nzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzq_?.BirthDateElement;
            string nzzzzzzzzzzzzzs_ = nzzzzzzzzzzzzzr_?.Value;
            CqlDate nzzzzzzzzzzzzzt_ = context.Operators.ConvertStringToDate(nzzzzzzzzzzzzzs_);
            object nzzzzzzzzzzzzzu_()
            {
                bool ozzzzzzzzzzzzzo_()
                {
                    DataType ozzzzzzzzzzzzzr_ = HPVTest?.Effective;
                    object ozzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzr_);
                    bool ozzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzs_ is CqlDateTime;

                    return ozzzzzzzzzzzzzt_;
                };
                bool ozzzzzzzzzzzzzp_()
                {
                    DataType ozzzzzzzzzzzzzu_ = HPVTest?.Effective;
                    object ozzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzu_);
                    bool ozzzzzzzzzzzzzw_ = ozzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return ozzzzzzzzzzzzzw_;
                };
                bool ozzzzzzzzzzzzzq_()
                {
                    DataType ozzzzzzzzzzzzzx_ = HPVTest?.Effective;
                    object ozzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzx_);
                    bool ozzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzy_ is CqlDateTime;

                    return ozzzzzzzzzzzzzz_;
                };
                if (ozzzzzzzzzzzzzo_())
                {
                    DataType pzzzzzzzzzzzzza_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzza_);

                    return (pzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                }
                else if (ozzzzzzzzzzzzzp_())
                {
                    DataType pzzzzzzzzzzzzzc_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzc_);

                    return (pzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ozzzzzzzzzzzzzq_())
                {
                    DataType pzzzzzzzzzzzzze_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzze_);

                    return (pzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime nzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.latest(context, nzzzzzzzzzzzzzu_());
            CqlDate nzzzzzzzzzzzzzw_ = context.Operators.DateFrom(nzzzzzzzzzzzzzv_);
            int? nzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(nzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzw_, "year");
            bool? nzzzzzzzzzzzzzy_ = context.Operators.GreaterOrEqual(nzzzzzzzzzzzzzx_, 30);
            object nzzzzzzzzzzzzzz_()
            {
                bool pzzzzzzzzzzzzzg_()
                {
                    DataType pzzzzzzzzzzzzzj_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzj_);
                    bool pzzzzzzzzzzzzzl_ = pzzzzzzzzzzzzzk_ is CqlDateTime;

                    return pzzzzzzzzzzzzzl_;
                };
                bool pzzzzzzzzzzzzzh_()
                {
                    DataType pzzzzzzzzzzzzzm_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzm_);
                    bool pzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                    return pzzzzzzzzzzzzzo_;
                };
                bool pzzzzzzzzzzzzzi_()
                {
                    DataType pzzzzzzzzzzzzzp_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzp_);
                    bool pzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzq_ is CqlDateTime;

                    return pzzzzzzzzzzzzzr_;
                };
                if (pzzzzzzzzzzzzzg_())
                {
                    DataType pzzzzzzzzzzzzzs_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzs_);

                    return (pzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                }
                else if (pzzzzzzzzzzzzzh_())
                {
                    DataType pzzzzzzzzzzzzzu_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzu_);

                    return (pzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (pzzzzzzzzzzzzzi_())
                {
                    DataType pzzzzzzzzzzzzzw_ = HPVTest?.Effective;
                    object pzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzw_);

                    return (pzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime ozzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.latest(context, nzzzzzzzzzzzzzz_());
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzb_);
            CqlQuantity ozzzzzzzzzzzzzd_ = context.Operators.Quantity(4m, "years");
            CqlDateTime ozzzzzzzzzzzzze_ = context.Operators.Subtract(ozzzzzzzzzzzzzc_, ozzzzzzzzzzzzzd_);
            CqlDateTime ozzzzzzzzzzzzzg_ = context.Operators.End(ozzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzh_ = context.Operators.Interval(ozzzzzzzzzzzzze_, ozzzzzzzzzzzzzg_, true, true);
            bool? ozzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzza_, ozzzzzzzzzzzzzh_, "day");
            bool? ozzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzi_);
            DataType ozzzzzzzzzzzzzk_ = HPVTest?.Value;
            object ozzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzk_);
            bool? ozzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzl_ is null));
            bool? ozzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzj_, ozzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> pzzzzzzzzzzzzzy_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? pzzzzzzzzzzzzzz_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzy_);
        IEnumerable<Observation> qzzzzzzzzzzzzza_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? qzzzzzzzzzzzzzb_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzzzc_ = context.Operators.Or(pzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzb_);

        return qzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

}
