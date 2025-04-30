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
        CqlDateTime ezzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> fzzzzzzzzza_ = context.Operators.Interval(ezzzzzzzzzy_, ezzzzzzzzzz_, true, true);
        object fzzzzzzzzzb_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", fzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)fzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient fzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(fzzzzzzzzzc_);

        return fzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet fzzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzg_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzi_ = context.Operators.Union<Encounter>(fzzzzzzzzzf_, fzzzzzzzzzh_);
        CqlValueSet fzzzzzzzzzj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzl_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> fzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzn_ = context.Operators.Union<Encounter>(fzzzzzzzzzk_, fzzzzzzzzzm_);
        IEnumerable<Encounter> fzzzzzzzzzo_ = context.Operators.Union<Encounter>(fzzzzzzzzzi_, fzzzzzzzzzn_);
        CqlValueSet fzzzzzzzzzp_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> fzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzr_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzt_ = context.Operators.Union<Encounter>(fzzzzzzzzzq_, fzzzzzzzzzs_);
        IEnumerable<Encounter> fzzzzzzzzzu_ = context.Operators.Union<Encounter>(fzzzzzzzzzo_, fzzzzzzzzzt_);
        IEnumerable<Encounter> fzzzzzzzzzv_ = Status_1_8_000.Instance.isEncounterPerformed(context, fzzzzzzzzzu_);
        bool? fzzzzzzzzzw_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzy_ = this.Measurement_Period(context);
            Period fzzzzzzzzzz_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzz_);
            CqlInterval<CqlDateTime> gzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzza_ as object);
            bool? gzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzy_, gzzzzzzzzzb_, "day");

            return gzzzzzzzzzc_;
        };
        IEnumerable<Encounter> fzzzzzzzzzx_ = context.Operators.Where<Encounter>(fzzzzzzzzzv_, fzzzzzzzzzw_);

        return fzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient gzzzzzzzzzd_ = this.Patient(context);
        Date gzzzzzzzzze_ = gzzzzzzzzzd_?.BirthDateElement;
        string gzzzzzzzzzf_ = gzzzzzzzzze_?.Value;
        CqlDate gzzzzzzzzzg_ = context.Operators.ConvertStringToDate(gzzzzzzzzzf_);
        CqlInterval<CqlDateTime> gzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzzzi_ = context.Operators.End(gzzzzzzzzzh_);
        CqlDate gzzzzzzzzzj_ = context.Operators.DateFrom(gzzzzzzzzzi_);
        int? gzzzzzzzzzk_ = context.Operators.CalculateAgeAt(gzzzzzzzzzg_, gzzzzzzzzzj_, "year");
        CqlInterval<int?> gzzzzzzzzzl_ = context.Operators.Interval(24, 64, true, true);
        bool? gzzzzzzzzzm_ = context.Operators.In<int?>(gzzzzzzzzzk_, gzzzzzzzzzl_, default);
        Code<AdministrativeGender> gzzzzzzzzzo_ = gzzzzzzzzzd_?.GenderElement;
        AdministrativeGender? gzzzzzzzzzp_ = gzzzzzzzzzo_?.Value;
        string gzzzzzzzzzq_ = context.Operators.Convert<string>(gzzzzzzzzzp_);
        bool? gzzzzzzzzzr_ = context.Operators.Equal(gzzzzzzzzzq_, "female");
        bool? gzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzm_, gzzzzzzzzzr_);
        IEnumerable<Encounter> gzzzzzzzzzt_ = this.Qualifying_Encounters(context);
        bool? gzzzzzzzzzu_ = context.Operators.Exists<Encounter>(gzzzzzzzzzt_);
        bool? gzzzzzzzzzv_ = context.Operators.And(gzzzzzzzzzs_, gzzzzzzzzzu_);

        return gzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzzzzzzzzw_ = this.Initial_Population(context);

        return gzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzx_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> gzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> gzzzzzzzzzz_ = Status_1_8_000.Instance.isProcedurePerformed(context, gzzzzzzzzzy_);
        bool? hzzzzzzzzza_(Procedure NoCervixProcedure)
        {
            DataType hzzzzzzzzzh_ = NoCervixProcedure?.Performed;
            object hzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzh_);
            CqlInterval<CqlDateTime> hzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzi_);
            CqlDateTime hzzzzzzzzzk_ = context.Operators.End(hzzzzzzzzzj_);
            CqlInterval<CqlDateTime> hzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzm_ = context.Operators.End(hzzzzzzzzzl_);
            bool? hzzzzzzzzzn_ = context.Operators.SameOrBefore(hzzzzzzzzzk_, hzzzzzzzzzm_, default);

            return hzzzzzzzzzn_;
        };
        IEnumerable<Procedure> hzzzzzzzzzb_ = context.Operators.Where<Procedure>(gzzzzzzzzzz_, hzzzzzzzzza_);
        CqlValueSet hzzzzzzzzzc_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> hzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzze_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime hzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzo_);
            CqlInterval<CqlDateTime> hzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzr_ = context.Operators.End(hzzzzzzzzzq_);
            bool? hzzzzzzzzzs_ = context.Operators.SameOrBefore(hzzzzzzzzzp_, hzzzzzzzzzr_, default);

            return hzzzzzzzzzs_;
        };
        IEnumerable<Condition> hzzzzzzzzzf_ = context.Operators.Where<Condition>(hzzzzzzzzzd_, hzzzzzzzzze_);
        IEnumerable<object> hzzzzzzzzzg_ = context.Operators.Union<object>(hzzzzzzzzzb_ as IEnumerable<object>, hzzzzzzzzzf_ as IEnumerable<object>);

        return hzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? hzzzzzzzzzt_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> hzzzzzzzzzu_ = this.Absence_of_Cervix(context);
        bool? hzzzzzzzzzv_ = context.Operators.Exists<object>(hzzzzzzzzzu_);
        bool? hzzzzzzzzzw_ = context.Operators.Or(hzzzzzzzzzt_, hzzzzzzzzzv_);
        bool? hzzzzzzzzzx_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? hzzzzzzzzzy_ = context.Operators.Or(hzzzzzzzzzw_, hzzzzzzzzzx_);

        return hzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzz_ = this.Pap_Test(context);
        IEnumerable<Observation> izzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzb_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, izzzzzzzzza_);
        bool? izzzzzzzzzc_(Observation CervicalCytology)
        {
            object izzzzzzzzze_()
            {
                bool izzzzzzzzzs_()
                {
                    DataType izzzzzzzzzv_ = CervicalCytology?.Effective;
                    object izzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzv_);
                    bool izzzzzzzzzx_ = izzzzzzzzzw_ is CqlDateTime;

                    return izzzzzzzzzx_;
                };
                bool izzzzzzzzzt_()
                {
                    DataType izzzzzzzzzy_ = CervicalCytology?.Effective;
                    object izzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzy_);
                    bool jzzzzzzzzza_ = izzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzza_;
                };
                bool izzzzzzzzzu_()
                {
                    DataType jzzzzzzzzzb_ = CervicalCytology?.Effective;
                    object jzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzb_);
                    bool jzzzzzzzzzd_ = jzzzzzzzzzc_ is CqlDateTime;

                    return jzzzzzzzzzd_;
                };
                if (izzzzzzzzzs_())
                {
                    DataType jzzzzzzzzze_ = CervicalCytology?.Effective;
                    object jzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzze_);

                    return (jzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzt_())
                {
                    DataType jzzzzzzzzzg_ = CervicalCytology?.Effective;
                    object jzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzg_);

                    return (jzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzu_())
                {
                    DataType jzzzzzzzzzi_ = CervicalCytology?.Effective;
                    object jzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzi_);

                    return (jzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime izzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.latest(context, izzzzzzzzze_());
            CqlInterval<CqlDateTime> izzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzh_ = context.Operators.Start(izzzzzzzzzg_);
            CqlQuantity izzzzzzzzzi_ = context.Operators.Quantity(2m, "years");
            CqlDateTime izzzzzzzzzj_ = context.Operators.Subtract(izzzzzzzzzh_, izzzzzzzzzi_);
            CqlDateTime izzzzzzzzzl_ = context.Operators.End(izzzzzzzzzg_);
            CqlInterval<CqlDateTime> izzzzzzzzzm_ = context.Operators.Interval(izzzzzzzzzj_, izzzzzzzzzl_, true, true);
            bool? izzzzzzzzzn_ = context.Operators.In<CqlDateTime>(izzzzzzzzzf_, izzzzzzzzzm_, "day");
            DataType izzzzzzzzzo_ = CervicalCytology?.Value;
            object izzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzo_);
            bool? izzzzzzzzzq_ = context.Operators.Not((bool?)(izzzzzzzzzp_ is null));
            bool? izzzzzzzzzr_ = context.Operators.And(izzzzzzzzzn_, izzzzzzzzzq_);

            return izzzzzzzzzr_;
        };
        IEnumerable<Observation> izzzzzzzzzd_ = context.Operators.Where<Observation>(izzzzzzzzzb_, izzzzzzzzzc_);

        return izzzzzzzzzd_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzk_ = this.HPV_Test(context);
        IEnumerable<Observation> jzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzzm_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, jzzzzzzzzzl_);
        bool? jzzzzzzzzzn_(Observation HPVTest)
        {
            Patient jzzzzzzzzzp_ = this.Patient(context);
            Date jzzzzzzzzzq_ = jzzzzzzzzzp_?.BirthDateElement;
            string jzzzzzzzzzr_ = jzzzzzzzzzq_?.Value;
            CqlDate jzzzzzzzzzs_ = context.Operators.ConvertStringToDate(jzzzzzzzzzr_);
            object jzzzzzzzzzt_()
            {
                bool kzzzzzzzzzn_()
                {
                    DataType kzzzzzzzzzq_ = HPVTest?.Effective;
                    object kzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzq_);
                    bool kzzzzzzzzzs_ = kzzzzzzzzzr_ is CqlDateTime;

                    return kzzzzzzzzzs_;
                };
                bool kzzzzzzzzzo_()
                {
                    DataType kzzzzzzzzzt_ = HPVTest?.Effective;
                    object kzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzt_);
                    bool kzzzzzzzzzv_ = kzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return kzzzzzzzzzv_;
                };
                bool kzzzzzzzzzp_()
                {
                    DataType kzzzzzzzzzw_ = HPVTest?.Effective;
                    object kzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzw_);
                    bool kzzzzzzzzzy_ = kzzzzzzzzzx_ is CqlDateTime;

                    return kzzzzzzzzzy_;
                };
                if (kzzzzzzzzzn_())
                {
                    DataType kzzzzzzzzzz_ = HPVTest?.Effective;
                    object lzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzz_);

                    return (lzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (kzzzzzzzzzo_())
                {
                    DataType lzzzzzzzzzb_ = HPVTest?.Effective;
                    object lzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzb_);

                    return (lzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (kzzzzzzzzzp_())
                {
                    DataType lzzzzzzzzzd_ = HPVTest?.Effective;
                    object lzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzd_);

                    return (lzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime jzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.latest(context, jzzzzzzzzzt_());
            CqlDate jzzzzzzzzzv_ = context.Operators.DateFrom(jzzzzzzzzzu_);
            int? jzzzzzzzzzw_ = context.Operators.CalculateAgeAt(jzzzzzzzzzs_, jzzzzzzzzzv_, "year");
            bool? jzzzzzzzzzx_ = context.Operators.GreaterOrEqual(jzzzzzzzzzw_, 30);
            object jzzzzzzzzzy_()
            {
                bool lzzzzzzzzzf_()
                {
                    DataType lzzzzzzzzzi_ = HPVTest?.Effective;
                    object lzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzi_);
                    bool lzzzzzzzzzk_ = lzzzzzzzzzj_ is CqlDateTime;

                    return lzzzzzzzzzk_;
                };
                bool lzzzzzzzzzg_()
                {
                    DataType lzzzzzzzzzl_ = HPVTest?.Effective;
                    object lzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzl_);
                    bool lzzzzzzzzzn_ = lzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return lzzzzzzzzzn_;
                };
                bool lzzzzzzzzzh_()
                {
                    DataType lzzzzzzzzzo_ = HPVTest?.Effective;
                    object lzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzo_);
                    bool lzzzzzzzzzq_ = lzzzzzzzzzp_ is CqlDateTime;

                    return lzzzzzzzzzq_;
                };
                if (lzzzzzzzzzf_())
                {
                    DataType lzzzzzzzzzr_ = HPVTest?.Effective;
                    object lzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzr_);

                    return (lzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else if (lzzzzzzzzzg_())
                {
                    DataType lzzzzzzzzzt_ = HPVTest?.Effective;
                    object lzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzt_);

                    return (lzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (lzzzzzzzzzh_())
                {
                    DataType lzzzzzzzzzv_ = HPVTest?.Effective;
                    object lzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzv_);

                    return (lzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime jzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.latest(context, jzzzzzzzzzy_());
            CqlInterval<CqlDateTime> kzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzza_);
            CqlQuantity kzzzzzzzzzc_ = context.Operators.Quantity(4m, "years");
            CqlDateTime kzzzzzzzzzd_ = context.Operators.Subtract(kzzzzzzzzzb_, kzzzzzzzzzc_);
            CqlDateTime kzzzzzzzzzf_ = context.Operators.End(kzzzzzzzzza_);
            CqlInterval<CqlDateTime> kzzzzzzzzzg_ = context.Operators.Interval(kzzzzzzzzzd_, kzzzzzzzzzf_, true, true);
            bool? kzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzz_, kzzzzzzzzzg_, "day");
            bool? kzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzx_, kzzzzzzzzzh_);
            DataType kzzzzzzzzzj_ = HPVTest?.Value;
            object kzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzj_);
            bool? kzzzzzzzzzl_ = context.Operators.Not((bool?)(kzzzzzzzzzk_ is null));
            bool? kzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzi_, kzzzzzzzzzl_);

            return kzzzzzzzzzm_;
        };
        IEnumerable<Observation> jzzzzzzzzzo_ = context.Operators.Where<Observation>(jzzzzzzzzzm_, jzzzzzzzzzn_);

        return jzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzx_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? lzzzzzzzzzy_ = context.Operators.Exists<Observation>(lzzzzzzzzzx_);
        IEnumerable<Observation> lzzzzzzzzzz_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? mzzzzzzzzza_ = context.Operators.Exists<Observation>(lzzzzzzzzzz_);
        bool? mzzzzzzzzzb_ = context.Operators.Or(lzzzzzzzzzy_, mzzzzzzzzza_);

        return mzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzf_;
    }


    #endregion Expressions

}
