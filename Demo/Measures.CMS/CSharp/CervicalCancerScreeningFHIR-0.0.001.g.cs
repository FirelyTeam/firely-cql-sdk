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
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzc_, true, true);
        object tzzzzzzzzzzzzzzzzzzzzze_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.001", "Measurement Period", tzzzzzzzzzzzzzzzzzzzzzd_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzzzzf_);

        return tzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzh_ = this.Office_Visit(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzj_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzm_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzo_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzs_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzu_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isEncounterPerformed(context, tzzzzzzzzzzzzzzzzzzzzzx_);
        bool? tzzzzzzzzzzzzzzzzzzzzzz_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            Period uzzzzzzzzzzzzzzzzzzzzzc_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzd_ as object);
            bool? uzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzze_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(tzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzz_);

        return uzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient uzzzzzzzzzzzzzzzzzzzzzg_ = this.Patient(context);
        Date uzzzzzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzzzzzzg_?.BirthDateElement;
        string uzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzh_?.Value;
        CqlDate uzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzl_);
        int? uzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzm_, "year");
        CqlInterval<int?> uzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(24, 64, true, true);
        bool? uzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<int?>(uzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzo_, default);
        Code<AdministrativeGender> uzzzzzzzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzzzzzzzg_?.GenderElement;
        AdministrativeGender? uzzzzzzzzzzzzzzzzzzzzzs_ = uzzzzzzzzzzzzzzzzzzzzzr_?.Value;
        string uzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzs_);
        bool? uzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzt_, "female");
        bool? uzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzw_);
        bool? uzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzx_);

        return uzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return uzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzza_ = this.Hysterectomy_with_No_Residual_Cervix(context);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isProcedurePerformed(context, vzzzzzzzzzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzzzzzzzzzd_(Procedure NoCervixProcedure)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzk_ = NoCervixProcedure?.Performed;
            object vzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzp_, default);

            return vzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzf_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzzzzzh_(Condition NoCervixDiagnosis)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, NoCervixDiagnosis);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzt_);
            bool? vzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzu_, default);

            return vzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(vzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<object>, vzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<object>);

        return vzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzw_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<object> vzzzzzzzzzzzzzzzzzzzzzx_ = this.Absence_of_Cervix(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<object>(vzzzzzzzzzzzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzy_);
        bool? wzzzzzzzzzzzzzzzzzzzzza_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzza_);

        return wzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzc_ = this.Pap_Test(context);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, wzzzzzzzzzzzzzzzzzzzzzd_);
        bool? wzzzzzzzzzzzzzzzzzzzzzf_(Observation CervicalCytology)
        {
            object wzzzzzzzzzzzzzzzzzzzzzh_()
            {
                bool wzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    DataType wzzzzzzzzzzzzzzzzzzzzzy_ = CervicalCytology?.Effective;
                    object wzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzy_);
                    bool xzzzzzzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzza_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzzw_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzb_ = CervicalCytology?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzb_);
                    bool xzzzzzzzzzzzzzzzzzzzzzd_ = xzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                    return xzzzzzzzzzzzzzzzzzzzzzd_;
                };
                bool wzzzzzzzzzzzzzzzzzzzzzx_()
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzze_ = CervicalCytology?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzze_);
                    bool xzzzzzzzzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                    return xzzzzzzzzzzzzzzzzzzzzzg_;
                };
                if (wzzzzzzzzzzzzzzzzzzzzzv_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzh_ = CervicalCytology?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzh_);

                    return (xzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzzw_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzj_ = CervicalCytology?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzj_);

                    return (xzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (wzzzzzzzzzzzzzzzzzzzzzx_())
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzl_ = CervicalCytology?.Effective;
                    object xzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzl_);

                    return (xzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.latest(context, wzzzzzzzzzzzzzzzzzzzzzh_());
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(2m, "years");
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzo_, true, true);
            bool? wzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzp_, "day");
            DataType wzzzzzzzzzzzzzzzzzzzzzr_ = CervicalCytology?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzr_);
            bool? wzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzt_);

            return wzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzf_);

        return wzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzn_ = this.HPV_Test(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isLaboratoryTestPerformed(context, xzzzzzzzzzzzzzzzzzzzzzo_);
        bool? xzzzzzzzzzzzzzzzzzzzzzq_(Observation HPVTest)
        {
            Patient xzzzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
            Date xzzzzzzzzzzzzzzzzzzzzzt_ = xzzzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
            string xzzzzzzzzzzzzzzzzzzzzzu_ = xzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlDate xzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(xzzzzzzzzzzzzzzzzzzzzzu_);
            object xzzzzzzzzzzzzzzzzzzzzzw_()
            {
                bool yzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzt_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzt_);
                    bool yzzzzzzzzzzzzzzzzzzzzzv_ = yzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                    return yzzzzzzzzzzzzzzzzzzzzzv_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzw_ = HPVTest?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzw_);
                    bool yzzzzzzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzzzzzzzzzzzy_;
                };
                bool yzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    DataType yzzzzzzzzzzzzzzzzzzzzzz_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzz_);
                    bool zzzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzb_;
                };
                if (yzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzc_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzc_);

                    return (zzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzze_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzze_);

                    return (zzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (yzzzzzzzzzzzzzzzzzzzzzs_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzg_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzg_);

                    return (zzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.latest(context, xzzzzzzzzzzzzzzzzzzzzzw_());
            CqlDate xzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzx_);
            int? xzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(xzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzy_, "year");
            bool? yzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(xzzzzzzzzzzzzzzzzzzzzzz_, 30);
            object yzzzzzzzzzzzzzzzzzzzzzb_()
            {
                bool zzzzzzzzzzzzzzzzzzzzzzi_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzl_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzl_);
                    bool zzzzzzzzzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzn_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzo_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzo_);
                    bool zzzzzzzzzzzzzzzzzzzzzzq_ = zzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                    return zzzzzzzzzzzzzzzzzzzzzzq_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzr_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzr_);
                    bool zzzzzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzt_;
                };
                if (zzzzzzzzzzzzzzzzzzzzzzi_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzu_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzu_);

                    return (zzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzj_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzw_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzw_);

                    return (zzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    DataType zzzzzzzzzzzzzzzzzzzzzzy_ = HPVTest?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzy_);

                    return (zzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.latest(context, yzzzzzzzzzzzzzzzzzzzzzb_());
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(4m, "years");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzi_, true, true);
            bool? yzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? yzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzk_);
            DataType yzzzzzzzzzzzzzzzzzzzzzm_ = HPVTest?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzm_);
            bool? yzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzo_);

            return yzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzq_);

        return xzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzza_ = this.Cervical_Cytology_Within_3_Years(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Observation>(azzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzc_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(azzzzzzzzzzzzzzzzzzzzzzc_);
        bool? azzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzd_);

        return azzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
