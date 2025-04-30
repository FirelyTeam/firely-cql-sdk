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
        CqlDateTime szzzzzzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime szzzzzzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> szzzzzzzzzzzq_ = context.Operators.Interval(szzzzzzzzzzzo_, szzzzzzzzzzzp_, true, true);
        object szzzzzzzzzzzr_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", szzzzzzzzzzzq_);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzzzs_);

        return szzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> szzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet szzzzzzzzzzzw_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> szzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzzzy_ = context.Operators.Union<Encounter>(szzzzzzzzzzzv_, szzzzzzzzzzzx_);
        CqlValueSet szzzzzzzzzzzz_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> tzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> tzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(tzzzzzzzzzzza_, tzzzzzzzzzzzc_);
        IEnumerable<Encounter> tzzzzzzzzzzze_ = context.Operators.Union<Encounter>(szzzzzzzzzzzy_, tzzzzzzzzzzzd_);
        CqlValueSet tzzzzzzzzzzzf_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> tzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzh_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzg_, tzzzzzzzzzzzi_);
        IEnumerable<Encounter> tzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(tzzzzzzzzzzze_, tzzzzzzzzzzzj_);
        IEnumerable<Encounter> tzzzzzzzzzzzl_ = Status_1_8_000.Instance.isEncounterPerformed(context, tzzzzzzzzzzzk_);
        bool? tzzzzzzzzzzzm_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzo_ = this.Measurement_Period(context);
            Period tzzzzzzzzzzzp_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzq_ as object);
            bool? tzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzo_, tzzzzzzzzzzzr_, "day");

            return tzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzl_, tzzzzzzzzzzzm_);

        return tzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient tzzzzzzzzzzzt_ = this.Patient(context);
        Date tzzzzzzzzzzzu_ = tzzzzzzzzzzzt_?.BirthDateElement;
        string tzzzzzzzzzzzv_ = tzzzzzzzzzzzu_?.Value;
        CqlDate tzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzzy_ = context.Operators.End(tzzzzzzzzzzzx_);
        CqlDate tzzzzzzzzzzzz_ = context.Operators.DateFrom(tzzzzzzzzzzzy_);
        int? uzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzw_, tzzzzzzzzzzzz_, "year");
        CqlInterval<int?> uzzzzzzzzzzzb_ = context.Operators.Interval(24, 64, true, true);
        bool? uzzzzzzzzzzzc_ = context.Operators.In<int?>(uzzzzzzzzzzza_, uzzzzzzzzzzzb_, default);
        Code<AdministrativeGender> uzzzzzzzzzzze_ = tzzzzzzzzzzzt_?.GenderElement;
        AdministrativeGender? uzzzzzzzzzzzf_ = uzzzzzzzzzzze_?.Value;
        string uzzzzzzzzzzzg_ = context.Operators.Convert<string>(uzzzzzzzzzzzf_);
        bool? uzzzzzzzzzzzh_ = context.Operators.Equal(uzzzzzzzzzzzg_, "female");
        bool? uzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzc_, uzzzzzzzzzzzh_);
        IEnumerable<Encounter> uzzzzzzzzzzzj_ = this.Qualifying_Encounters(context);
        bool? uzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzj_);
        bool? uzzzzzzzzzzzl_ = context.Operators.And(uzzzzzzzzzzzi_, uzzzzzzzzzzzk_);

        return uzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? uzzzzzzzzzzzm_ = this.Initial_Population(context);

        return uzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzn_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> uzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzp_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzzo_);
        bool? uzzzzzzzzzzzq_(Procedure NoCervixProcedure)
        {
            DataType uzzzzzzzzzzzx_ = NoCervixProcedure?.Performed;
            object uzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzy_);
            CqlDateTime vzzzzzzzzzzza_ = context.Operators.End(uzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzc_ = context.Operators.End(vzzzzzzzzzzzb_);
            bool? vzzzzzzzzzzzd_ = context.Operators.SameOrBefore(vzzzzzzzzzzza_, vzzzzzzzzzzzc_, default);

            return vzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzp_, uzzzzzzzzzzzq_);
        CqlValueSet uzzzzzzzzzzzs_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> uzzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? uzzzzzzzzzzzu_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime vzzzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzh_ = context.Operators.End(vzzzzzzzzzzzg_);
            bool? vzzzzzzzzzzzi_ = context.Operators.SameOrBefore(vzzzzzzzzzzzf_, vzzzzzzzzzzzh_, default);

            return vzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzv_ = context.Operators.Where<Condition>(uzzzzzzzzzzzt_, uzzzzzzzzzzzu_);
        IEnumerable<object> uzzzzzzzzzzzw_ = context.Operators.Union<object>(uzzzzzzzzzzzr_ as IEnumerable<object>, uzzzzzzzzzzzv_ as IEnumerable<object>);

        return uzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? vzzzzzzzzzzzj_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> vzzzzzzzzzzzk_ = this.Absence_of_Cervix(context);
        bool? vzzzzzzzzzzzl_ = context.Operators.Exists<object>(vzzzzzzzzzzzk_);
        bool? vzzzzzzzzzzzm_ = context.Operators.Or(vzzzzzzzzzzzj_, vzzzzzzzzzzzl_);
        bool? vzzzzzzzzzzzn_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? vzzzzzzzzzzzo_ = context.Operators.Or(vzzzzzzzzzzzm_, vzzzzzzzzzzzn_);

        return vzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzp_ = this.Pap_Test(context);
        IEnumerable<Observation> vzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzr_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, vzzzzzzzzzzzq_);
        bool? vzzzzzzzzzzzs_(Observation CervicalCytology)
        {
            object vzzzzzzzzzzzu_()
            {
                bool wzzzzzzzzzzzi_()
                {
                    DataType wzzzzzzzzzzzl_ = CervicalCytology?.Effective;
                    object wzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzl_);
                    bool wzzzzzzzzzzzn_ = wzzzzzzzzzzzm_ is CqlDateTime;

                    return wzzzzzzzzzzzn_;
                };
                bool wzzzzzzzzzzzj_()
                {
                    DataType wzzzzzzzzzzzo_ = CervicalCytology?.Effective;
                    object wzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzo_);
                    bool wzzzzzzzzzzzq_ = wzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return wzzzzzzzzzzzq_;
                };
                bool wzzzzzzzzzzzk_()
                {
                    DataType wzzzzzzzzzzzr_ = CervicalCytology?.Effective;
                    object wzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzr_);
                    bool wzzzzzzzzzzzt_ = wzzzzzzzzzzzs_ is CqlDateTime;

                    return wzzzzzzzzzzzt_;
                };
                if (wzzzzzzzzzzzi_())
                {
                    DataType wzzzzzzzzzzzu_ = CervicalCytology?.Effective;
                    object wzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzu_);

                    return (wzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzj_())
                {
                    DataType wzzzzzzzzzzzw_ = CervicalCytology?.Effective;
                    object wzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzw_);

                    return (wzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzk_())
                {
                    DataType wzzzzzzzzzzzy_ = CervicalCytology?.Effective;
                    object wzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzy_);

                    return (wzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime vzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.latest(context, vzzzzzzzzzzzu_());
            CqlInterval<CqlDateTime> vzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzx_ = context.Operators.Start(vzzzzzzzzzzzw_);
            CqlQuantity vzzzzzzzzzzzy_ = context.Operators.Quantity(2m, "years");
            CqlDateTime vzzzzzzzzzzzz_ = context.Operators.Subtract(vzzzzzzzzzzzx_, vzzzzzzzzzzzy_);
            CqlDateTime wzzzzzzzzzzzb_ = context.Operators.End(vzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzc_ = context.Operators.Interval(vzzzzzzzzzzzz_, wzzzzzzzzzzzb_, true, true);
            bool? wzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzv_, wzzzzzzzzzzzc_, "day");
            DataType wzzzzzzzzzzze_ = CervicalCytology?.Value;
            object wzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzze_);
            bool? wzzzzzzzzzzzg_ = context.Operators.Not((bool?)(wzzzzzzzzzzzf_ is null));
            bool? wzzzzzzzzzzzh_ = context.Operators.And(wzzzzzzzzzzzd_, wzzzzzzzzzzzg_);

            return wzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzt_ = context.Operators.Where<Observation>(vzzzzzzzzzzzr_, vzzzzzzzzzzzs_);

        return vzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzza_ = this.HPV_Test(context);
        IEnumerable<Observation> xzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzzzzzzzc_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, xzzzzzzzzzzzb_);
        bool? xzzzzzzzzzzzd_(Observation HPVTest)
        {
            Patient xzzzzzzzzzzzf_ = this.Patient(context);
            Date xzzzzzzzzzzzg_ = xzzzzzzzzzzzf_?.BirthDateElement;
            string xzzzzzzzzzzzh_ = xzzzzzzzzzzzg_?.Value;
            CqlDate xzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzh_);
            object xzzzzzzzzzzzj_()
            {
                bool yzzzzzzzzzzzd_()
                {
                    DataType yzzzzzzzzzzzg_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzg_);
                    bool yzzzzzzzzzzzi_ = yzzzzzzzzzzzh_ is CqlDateTime;

                    return yzzzzzzzzzzzi_;
                };
                bool yzzzzzzzzzzze_()
                {
                    DataType yzzzzzzzzzzzj_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzj_);
                    bool yzzzzzzzzzzzl_ = yzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzl_;
                };
                bool yzzzzzzzzzzzf_()
                {
                    DataType yzzzzzzzzzzzm_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzm_);
                    bool yzzzzzzzzzzzo_ = yzzzzzzzzzzzn_ is CqlDateTime;

                    return yzzzzzzzzzzzo_;
                };
                if (yzzzzzzzzzzzd_())
                {
                    DataType yzzzzzzzzzzzp_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzp_);

                    return (yzzzzzzzzzzzq_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzze_())
                {
                    DataType yzzzzzzzzzzzr_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzr_);

                    return (yzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzf_())
                {
                    DataType yzzzzzzzzzzzt_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzt_);

                    return (yzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.latest(context, xzzzzzzzzzzzj_());
            CqlDate xzzzzzzzzzzzl_ = context.Operators.DateFrom(xzzzzzzzzzzzk_);
            int? xzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzi_, xzzzzzzzzzzzl_, "year");
            bool? xzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzm_, 30);
            object xzzzzzzzzzzzo_()
            {
                bool yzzzzzzzzzzzv_()
                {
                    DataType yzzzzzzzzzzzy_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzy_);
                    bool zzzzzzzzzzzza_ = yzzzzzzzzzzzz_ is CqlDateTime;

                    return zzzzzzzzzzzza_;
                };
                bool yzzzzzzzzzzzw_()
                {
                    DataType zzzzzzzzzzzzb_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzb_);
                    bool zzzzzzzzzzzzd_ = zzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzd_;
                };
                bool yzzzzzzzzzzzx_()
                {
                    DataType zzzzzzzzzzzze_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzze_);
                    bool zzzzzzzzzzzzg_ = zzzzzzzzzzzzf_ is CqlDateTime;

                    return zzzzzzzzzzzzg_;
                };
                if (yzzzzzzzzzzzv_())
                {
                    DataType zzzzzzzzzzzzh_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzh_);

                    return (zzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzw_())
                {
                    DataType zzzzzzzzzzzzj_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzj_);

                    return (zzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzx_())
                {
                    DataType zzzzzzzzzzzzl_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzl_);

                    return (zzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.latest(context, xzzzzzzzzzzzo_());
            CqlInterval<CqlDateTime> xzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzq_);
            CqlQuantity xzzzzzzzzzzzs_ = context.Operators.Quantity(4m, "years");
            CqlDateTime xzzzzzzzzzzzt_ = context.Operators.Subtract(xzzzzzzzzzzzr_, xzzzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzzzv_ = context.Operators.End(xzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzt_, xzzzzzzzzzzzv_, true, true);
            bool? xzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzp_, xzzzzzzzzzzzw_, "day");
            bool? xzzzzzzzzzzzy_ = context.Operators.And(xzzzzzzzzzzzn_, xzzzzzzzzzzzx_);
            DataType xzzzzzzzzzzzz_ = HPVTest?.Value;
            object yzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzz_);
            bool? yzzzzzzzzzzzb_ = context.Operators.Not((bool?)(yzzzzzzzzzzza_ is null));
            bool? yzzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzzy_, yzzzzzzzzzzzb_);

            return yzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> xzzzzzzzzzzze_ = context.Operators.Where<Observation>(xzzzzzzzzzzzc_, xzzzzzzzzzzzd_);

        return xzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> zzzzzzzzzzzzn_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? zzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzn_);
        IEnumerable<Observation> zzzzzzzzzzzzp_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? zzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(zzzzzzzzzzzzp_);
        bool? zzzzzzzzzzzzr_ = context.Operators.Or(zzzzzzzzzzzzo_, zzzzzzzzzzzzq_);

        return zzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
