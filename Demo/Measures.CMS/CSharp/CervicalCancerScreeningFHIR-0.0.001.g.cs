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
        CqlDateTime czzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzza_ = context.Operators.Interval(czzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzz_, true, true);
        object dzzzzzzzzzzzzzzzb_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", dzzzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzc_);

        return dzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzh_);
        CqlValueSet dzzzzzzzzzzzzzzzj_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzl_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzn_);
        CqlValueSet dzzzzzzzzzzzzzzzp_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzr_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzzzzzzzu_);
        bool? dzzzzzzzzzzzzzzzw_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            Period dzzzzzzzzzzzzzzzz_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzza_ as object);
            bool? ezzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzb_, "day");

            return ezzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzw_);

        return dzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzd_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzze_ = ezzzzzzzzzzzzzzzd_?.BirthDateElement;
        string ezzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzze_?.Value;
        CqlDate ezzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzi_ = context.Operators.End(ezzzzzzzzzzzzzzzh_);
        CqlDate ezzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzi_);
        int? ezzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzj_, "year");
        CqlInterval<int?> ezzzzzzzzzzzzzzzl_ = context.Operators.Interval(24, 64, true, true);
        bool? ezzzzzzzzzzzzzzzm_ = context.Operators.In<int?>(ezzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzl_, default);
        Code<AdministrativeGender> ezzzzzzzzzzzzzzzo_ = ezzzzzzzzzzzzzzzd_?.GenderElement;
        AdministrativeGender? ezzzzzzzzzzzzzzzp_ = ezzzzzzzzzzzzzzzo_?.Value;
        string ezzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzp_);
        bool? ezzzzzzzzzzzzzzzr_ = context.Operators.Equal(ezzzzzzzzzzzzzzzq_, "female");
        bool? ezzzzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzt_ = this.Qualifying_Encounters(context);
        bool? ezzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzt_);
        bool? ezzzzzzzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzw_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzx_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isProcedurePerformed(context, ezzzzzzzzzzzzzzzy_);
        bool? fzzzzzzzzzzzzzzza_(Procedure NoCervixProcedure)
        {
            DataType fzzzzzzzzzzzzzzzh_ = NoCervixProcedure?.Performed;
            object fzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzi_);
            CqlDateTime fzzzzzzzzzzzzzzzk_ = context.Operators.End(fzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzm_ = context.Operators.End(fzzzzzzzzzzzzzzzl_);
            bool? fzzzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzm_, default);

            return fzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzza_);
        CqlValueSet fzzzzzzzzzzzzzzzc_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzzzze_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzzp_ = context.Operators.Start(fzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzr_ = context.Operators.End(fzzzzzzzzzzzzzzzq_);
            bool? fzzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzr_, default);

            return fzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzze_);
        IEnumerable<object> fzzzzzzzzzzzzzzzg_ = context.Operators.Union<object>(fzzzzzzzzzzzzzzzb_ as IEnumerable<object>, fzzzzzzzzzzzzzzzf_ as IEnumerable<object>);

        return fzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzt_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> fzzzzzzzzzzzzzzzu_ = this.Absence_of_Cervix(context);
        bool? fzzzzzzzzzzzzzzzv_ = context.Operators.Exists<object>(fzzzzzzzzzzzzzzzu_);
        bool? fzzzzzzzzzzzzzzzw_ = context.Operators.Or(fzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzv_);
        bool? fzzzzzzzzzzzzzzzx_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzy_ = context.Operators.Or(fzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzz_ = this.Pap_Test(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, gzzzzzzzzzzzzzzza_);
        bool? gzzzzzzzzzzzzzzzc_(Observation CervicalCytology)
        {
            object gzzzzzzzzzzzzzzze_()
            {
                bool gzzzzzzzzzzzzzzzs_()
                {
                    DataType gzzzzzzzzzzzzzzzv_ = CervicalCytology?.Effective;
                    object gzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzv_);
                    bool gzzzzzzzzzzzzzzzx_ = gzzzzzzzzzzzzzzzw_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzx_;
                };
                bool gzzzzzzzzzzzzzzzt_()
                {
                    DataType gzzzzzzzzzzzzzzzy_ = CervicalCytology?.Effective;
                    object gzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzy_);
                    bool hzzzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzza_;
                };
                bool gzzzzzzzzzzzzzzzu_()
                {
                    DataType hzzzzzzzzzzzzzzzb_ = CervicalCytology?.Effective;
                    object hzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzb_);
                    bool hzzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzzc_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzd_;
                };
                if (gzzzzzzzzzzzzzzzs_())
                {
                    DataType hzzzzzzzzzzzzzzze_ = CervicalCytology?.Effective;
                    object hzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzze_);

                    return (hzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzt_())
                {
                    DataType hzzzzzzzzzzzzzzzg_ = CervicalCytology?.Effective;
                    object hzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzg_);

                    return (hzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzu_())
                {
                    DataType hzzzzzzzzzzzzzzzi_ = CervicalCytology?.Effective;
                    object hzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzi_);

                    return (hzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.latest(context, gzzzzzzzzzzzzzzze_());
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzh_ = context.Operators.Start(gzzzzzzzzzzzzzzzg_);
            CqlQuantity gzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(2m, "years");
            CqlDateTime gzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzi_);
            CqlDateTime gzzzzzzzzzzzzzzzl_ = context.Operators.End(gzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzm_ = context.Operators.Interval(gzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzl_, true, true);
            bool? gzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzm_, "day");
            DataType gzzzzzzzzzzzzzzzo_ = CervicalCytology?.Value;
            object gzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzo_);
            bool? gzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzp_ is null));
            bool? gzzzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzq_);

            return gzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzc_);

        return gzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzk_ = this.HPV_Test(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, hzzzzzzzzzzzzzzzl_);
        bool? hzzzzzzzzzzzzzzzn_(Observation HPVTest)
        {
            Patient hzzzzzzzzzzzzzzzp_ = this.Patient(context);
            Date hzzzzzzzzzzzzzzzq_ = hzzzzzzzzzzzzzzzp_?.BirthDateElement;
            string hzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzq_?.Value;
            CqlDate hzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzzzr_);
            object hzzzzzzzzzzzzzzzt_()
            {
                bool izzzzzzzzzzzzzzzn_()
                {
                    DataType izzzzzzzzzzzzzzzq_ = HPVTest?.Effective;
                    object izzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzq_);
                    bool izzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzr_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzs_;
                };
                bool izzzzzzzzzzzzzzzo_()
                {
                    DataType izzzzzzzzzzzzzzzt_ = HPVTest?.Effective;
                    object izzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzt_);
                    bool izzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                    return izzzzzzzzzzzzzzzv_;
                };
                bool izzzzzzzzzzzzzzzp_()
                {
                    DataType izzzzzzzzzzzzzzzw_ = HPVTest?.Effective;
                    object izzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzw_);
                    bool izzzzzzzzzzzzzzzy_ = izzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return izzzzzzzzzzzzzzzy_;
                };
                if (izzzzzzzzzzzzzzzn_())
                {
                    DataType izzzzzzzzzzzzzzzz_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzz_);

                    return (jzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                }
                else if (izzzzzzzzzzzzzzzo_())
                {
                    DataType jzzzzzzzzzzzzzzzb_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzb_);

                    return (jzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (izzzzzzzzzzzzzzzp_())
                {
                    DataType jzzzzzzzzzzzzzzzd_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzd_);

                    return (jzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.latest(context, hzzzzzzzzzzzzzzzt_());
            CqlDate hzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzu_);
            int? hzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzv_, "year");
            bool? hzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzw_, 30);
            object hzzzzzzzzzzzzzzzy_()
            {
                bool jzzzzzzzzzzzzzzzf_()
                {
                    DataType jzzzzzzzzzzzzzzzi_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzi_);
                    bool jzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzj_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzk_;
                };
                bool jzzzzzzzzzzzzzzzg_()
                {
                    DataType jzzzzzzzzzzzzzzzl_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzl_);
                    bool jzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzn_;
                };
                bool jzzzzzzzzzzzzzzzh_()
                {
                    DataType jzzzzzzzzzzzzzzzo_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzo_);
                    bool jzzzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzzzp_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzq_;
                };
                if (jzzzzzzzzzzzzzzzf_())
                {
                    DataType jzzzzzzzzzzzzzzzr_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzr_);

                    return (jzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzg_())
                {
                    DataType jzzzzzzzzzzzzzzzt_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzt_);

                    return (jzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzh_())
                {
                    DataType jzzzzzzzzzzzzzzzv_ = HPVTest?.Effective;
                    object jzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzv_);

                    return (jzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime hzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.latest(context, hzzzzzzzzzzzzzzzy_());
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzb_ = context.Operators.Start(izzzzzzzzzzzzzzza_);
            CqlQuantity izzzzzzzzzzzzzzzc_ = context.Operators.Quantity(4m, "years");
            CqlDateTime izzzzzzzzzzzzzzzd_ = context.Operators.Subtract(izzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzc_);
            CqlDateTime izzzzzzzzzzzzzzzf_ = context.Operators.End(izzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzg_ = context.Operators.Interval(izzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzf_, true, true);
            bool? izzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzg_, "day");
            bool? izzzzzzzzzzzzzzzi_ = context.Operators.And(hzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzh_);
            DataType izzzzzzzzzzzzzzzj_ = HPVTest?.Value;
            object izzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzj_);
            bool? izzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzk_ is null));
            bool? izzzzzzzzzzzzzzzm_ = context.Operators.And(izzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzl_);

            return izzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzn_);

        return hzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzx_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? jzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzz_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? kzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(jzzzzzzzzzzzzzzzz_);
        bool? kzzzzzzzzzzzzzzzb_ = context.Operators.Or(jzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return kzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> kzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return kzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return kzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return kzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}
