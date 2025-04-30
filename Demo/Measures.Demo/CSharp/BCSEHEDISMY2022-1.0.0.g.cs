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
[CqlLibrary("BCSEHEDISMY2022", "1.0.0")]
public partial class BCSEHEDISMY2022_1_0_0 : ILibrary, ISingleton<BCSEHEDISMY2022_1_0_0>
{
    private BCSEHEDISMY2022_1_0_0() {}

    public static BCSEHEDISMY2022_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "BCSEHEDISMY2022";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAHealthPlanEnrollment_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAHospice_1_0_0.Instance, NCQAAdvancedIllnessandFrailty_1_0_0.Instance, NCQAPalliativeCare_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Absence of Left Breast", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", valueSetVersion: null)]
    public CqlValueSet Absence_of_Left_Breast(CqlContext _) => _Absence_of_Left_Breast;
    private static readonly CqlValueSet _Absence_of_Left_Breast = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", null);

    [CqlValueSetDefinition("Absence of Right Breast", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", valueSetVersion: null)]
    public CqlValueSet Absence_of_Right_Breast(CqlContext _) => _Absence_of_Right_Breast;
    private static readonly CqlValueSet _Absence_of_Right_Breast = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", null);

    [CqlValueSetDefinition("Bilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext _) => _Bilateral_Mastectomy;
    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", null);

    [CqlValueSetDefinition("Bilateral Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", valueSetVersion: null)]
    public CqlValueSet Bilateral_Modifier(CqlContext _) => _Bilateral_Modifier;
    private static readonly CqlValueSet _Bilateral_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", null);

    [CqlValueSetDefinition("Clinical Bilateral Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", valueSetVersion: null)]
    public CqlValueSet Clinical_Bilateral_Modifier(CqlContext _) => _Clinical_Bilateral_Modifier;
    private static readonly CqlValueSet _Clinical_Bilateral_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", null);

    [CqlValueSetDefinition("Clinical Left Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", valueSetVersion: null)]
    public CqlValueSet Clinical_Left_Modifier(CqlContext _) => _Clinical_Left_Modifier;
    private static readonly CqlValueSet _Clinical_Left_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", null);

    [CqlValueSetDefinition("Clinical Right Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", valueSetVersion: null)]
    public CqlValueSet Clinical_Right_Modifier(CqlContext _) => _Clinical_Right_Modifier;
    private static readonly CqlValueSet _Clinical_Right_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", null);

    [CqlValueSetDefinition("Clinical Unilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", valueSetVersion: null)]
    public CqlValueSet Clinical_Unilateral_Mastectomy(CqlContext _) => _Clinical_Unilateral_Mastectomy;
    private static readonly CqlValueSet _Clinical_Unilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", null);

    [CqlValueSetDefinition("History of Bilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", valueSetVersion: null)]
    public CqlValueSet History_of_Bilateral_Mastectomy(CqlContext _) => _History_of_Bilateral_Mastectomy;
    private static readonly CqlValueSet _History_of_Bilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", null);

    [CqlValueSetDefinition("Left Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", valueSetVersion: null)]
    public CqlValueSet Left_Modifier(CqlContext _) => _Left_Modifier;
    private static readonly CqlValueSet _Left_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", null);

    [CqlValueSetDefinition("Mammography", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext _) => _Mammography;
    private static readonly CqlValueSet _Mammography = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", null);

    [CqlValueSetDefinition("Right Modifier", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", valueSetVersion: null)]
    public CqlValueSet Right_Modifier(CqlContext _) => _Right_Modifier;
    private static readonly CqlValueSet _Right_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", null);

    [CqlValueSetDefinition("Unilateral Mastectomy", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy(CqlContext _) => _Unilateral_Mastectomy;
    private static readonly CqlValueSet _Unilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Left", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext _) => _Unilateral_Mastectomy_Left;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Left = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Right", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext _) => _Unilateral_Mastectomy_Right;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Right = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object czzzzzzzzzzzzzzh_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient czzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzi_);

        return czzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzl_ = context.Operators.Start(czzzzzzzzzzzzzzk_);
        int? czzzzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzzzzzl_, "year");
        int? czzzzzzzzzzzzzzn_ = context.Operators.Subtract(czzzzzzzzzzzzzzm_, 2);
        decimal? czzzzzzzzzzzzzzo_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime czzzzzzzzzzzzzzp_ = context.Operators.DateTime(czzzzzzzzzzzzzzn_, 10, 1, 0, 0, 0, 0, czzzzzzzzzzzzzzo_);

        return czzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Participation Period")]
    public CqlInterval<CqlDateTime> Participation_Period(CqlContext context)
    {
        CqlDateTime czzzzzzzzzzzzzzq_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzs_ = context.Operators.End(czzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzt_ = context.Operators.Interval(czzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzs_, true, true);

        return czzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage(CqlContext context)
    {
        IEnumerable<Coverage> czzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        bool? czzzzzzzzzzzzzzv_(Coverage C)
        {
            Period czzzzzzzzzzzzzzx_ = C?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, czzzzzzzzzzzzzzx_ as object);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzz_ = this.Participation_Period(context);
            bool? dzzzzzzzzzzzzzza_ = context.Operators.Overlaps(czzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzz_, default);

            return dzzzzzzzzzzzzzza_;
        };
        IEnumerable<Coverage> czzzzzzzzzzzzzzw_ = context.Operators.Where<Coverage>(czzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzv_);

        return czzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period(CqlContext context)
    {
        IEnumerable<Coverage> dzzzzzzzzzzzzzzb_ = this.Member_Coverage(context);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzzzzd_ = context.Operators.End(dzzzzzzzzzzzzzzc_);
        CqlDate dzzzzzzzzzzzzzze_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzd_);
        CqlDateTime dzzzzzzzzzzzzzzf_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlDate dzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzf_);
        CqlDateTime dzzzzzzzzzzzzzzi_ = context.Operators.End(dzzzzzzzzzzzzzzc_);
        CqlDate dzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzi_);
        CqlQuantity dzzzzzzzzzzzzzzk_ = context.Operators.Quantity(2m, "years");
        CqlDate dzzzzzzzzzzzzzzl_ = context.Operators.Subtract(dzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDate> dzzzzzzzzzzzzzzm_ = context.Operators.Interval(dzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzl_, true, true);
        bool? dzzzzzzzzzzzzzzn_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, dzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzm_, 0);
        CqlDateTime dzzzzzzzzzzzzzzq_ = context.Operators.End(dzzzzzzzzzzzzzzc_);
        CqlDate dzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzq_);
        CqlDateTime dzzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzzc_);
        CqlDate dzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzt_);
        CqlQuantity dzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "year");
        CqlDate dzzzzzzzzzzzzzzw_ = context.Operators.Subtract(dzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzv_);
        CqlDateTime dzzzzzzzzzzzzzzy_ = context.Operators.End(dzzzzzzzzzzzzzzc_);
        CqlDate dzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzy_);
        CqlDate ezzzzzzzzzzzzzzb_ = context.Operators.Subtract(dzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDate> ezzzzzzzzzzzzzzc_ = context.Operators.Interval(dzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzb_, true, true);
        bool? ezzzzzzzzzzzzzzd_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, dzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzc_, 45);
        bool? ezzzzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzd_);
        CqlDateTime ezzzzzzzzzzzzzzh_ = context.Operators.End(dzzzzzzzzzzzzzzc_);
        CqlDate ezzzzzzzzzzzzzzi_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzh_);
        CqlDateTime ezzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzc_);
        CqlDate ezzzzzzzzzzzzzzl_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzk_);
        CqlDateTime ezzzzzzzzzzzzzzn_ = context.Operators.End(dzzzzzzzzzzzzzzc_);
        CqlDate ezzzzzzzzzzzzzzo_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzn_);
        CqlInterval<CqlDate> ezzzzzzzzzzzzzzp_ = context.Operators.Interval(ezzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzo_, true, true);
        bool? ezzzzzzzzzzzzzzq_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, dzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzp_, 45);
        bool? ezzzzzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzs_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzt_ = ezzzzzzzzzzzzzzs_?.BirthDateElement;
        string ezzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzt_?.Value;
        CqlDate ezzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzx_ = context.Operators.End(ezzzzzzzzzzzzzzw_);
        CqlDate ezzzzzzzzzzzzzzy_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzx_);
        int? ezzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> fzzzzzzzzzzzzzza_ = context.Operators.Interval(52, 74, true, true);
        bool? fzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(ezzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzza_, default);
        Code<AdministrativeGender> fzzzzzzzzzzzzzzd_ = ezzzzzzzzzzzzzzs_?.GenderElement;
        AdministrativeGender? fzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzd_?.Value;
        string fzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzze_);
        bool? fzzzzzzzzzzzzzzg_ = context.Operators.Equal(fzzzzzzzzzzzzzzf_, "female");
        bool? fzzzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzg_);
        bool? fzzzzzzzzzzzzzzi_ = this.Enrolled_During_Participation_Period(context);
        bool? fzzzzzzzzzzzzzzj_ = context.Operators.And(fzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzk_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzl_ = this.Absence_of_Right_Breast(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzn_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, fzzzzzzzzzzzzzzm_);
        bool? fzzzzzzzzzzzzzzo_(Condition RightMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
            CqlDateTime fzzzzzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzt_ = context.Operators.End(fzzzzzzzzzzzzzzs_);
            bool? fzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzt_, default);

            return fzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzv_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzx_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, fzzzzzzzzzzzzzzw_);
        CqlValueSet fzzzzzzzzzzzzzzy_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzza_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, fzzzzzzzzzzzzzzz_);
        bool? gzzzzzzzzzzzzzzb_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> gzzzzzzzzzzzzzzm_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept gzzzzzzzzzzzzzzn_(CodeableConcept X)
            {
                CqlConcept gzzzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return gzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzn_);
            CqlValueSet gzzzzzzzzzzzzzzp_ = this.Right_Modifier(context);
            bool? gzzzzzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzb_);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzd_ = context.Operators.Union<Procedure>(fzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzc_);
        CqlValueSet gzzzzzzzzzzzzzze_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, gzzzzzzzzzzzzzzf_);
        bool? gzzzzzzzzzzzzzzh_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> gzzzzzzzzzzzzzzs_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept gzzzzzzzzzzzzzzt_(CodeableConcept X)
            {
                CqlConcept gzzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return gzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzt_);
            CqlValueSet gzzzzzzzzzzzzzzv_ = this.Clinical_Right_Modifier(context);
            bool? gzzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzv_);

            return gzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzh_);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzj_ = context.Operators.Union<Procedure>(gzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzi_);
        bool? gzzzzzzzzzzzzzzk_(Procedure RightMastectomyProcedure)
        {
            DataType gzzzzzzzzzzzzzzy_ = RightMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzy_);
            CqlDateTime hzzzzzzzzzzzzzza_ = context.Operators.End(gzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzc_ = context.Operators.End(hzzzzzzzzzzzzzzb_);
            bool? hzzzzzzzzzzzzzzd_ = context.Operators.SameOrBefore(hzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzc_, default);

            return hzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzk_);

        return gzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzze_ = this.Absence_of_Left_Breast(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> hzzzzzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, hzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzh_(Condition LeftMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
            CqlDateTime hzzzzzzzzzzzzzzk_ = context.Operators.Start(hzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzm_ = context.Operators.End(hzzzzzzzzzzzzzzl_);
            bool? hzzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(hzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzm_, default);

            return hzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzh_);

        return hzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzo_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzq_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, hzzzzzzzzzzzzzzp_);
        CqlValueSet hzzzzzzzzzzzzzzr_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzt_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, hzzzzzzzzzzzzzzs_);
        bool? hzzzzzzzzzzzzzzu_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> izzzzzzzzzzzzzzf_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept izzzzzzzzzzzzzzg_(CodeableConcept X)
            {
                CqlConcept izzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return izzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzg_);
            CqlValueSet izzzzzzzzzzzzzzi_ = this.Left_Modifier(context);
            bool? izzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzi_);

            return izzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzu_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzw_ = context.Operators.Union<Procedure>(hzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzv_);
        CqlValueSet hzzzzzzzzzzzzzzx_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, hzzzzzzzzzzzzzzy_);
        bool? izzzzzzzzzzzzzza_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> izzzzzzzzzzzzzzl_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept izzzzzzzzzzzzzzm_(CodeableConcept X)
            {
                CqlConcept izzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return izzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> izzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzm_);
            CqlValueSet izzzzzzzzzzzzzzo_ = this.Clinical_Left_Modifier(context);
            bool? izzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(izzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzo_);

            return izzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzza_);
        IEnumerable<Procedure> izzzzzzzzzzzzzzc_ = context.Operators.Union<Procedure>(hzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzb_);
        bool? izzzzzzzzzzzzzzd_(Procedure LeftMastectomyProcedure)
        {
            DataType izzzzzzzzzzzzzzr_ = LeftMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzr_);
            CqlDateTime izzzzzzzzzzzzzzt_ = context.Operators.End(izzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzv_ = context.Operators.End(izzzzzzzzzzzzzzu_);
            bool? izzzzzzzzzzzzzzw_ = context.Operators.SameOrBefore(izzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzv_, default);

            return izzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzd_);

        return izzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzx_ = this.History_of_Bilateral_Mastectomy(context);
        IEnumerable<Condition> izzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> izzzzzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, izzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzza_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzc_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime jzzzzzzzzzzzzzzd_ = context.Operators.Start(jzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzf_ = context.Operators.End(jzzzzzzzzzzzzzze_);
            bool? jzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzf_, default);

            return jzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzh_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, jzzzzzzzzzzzzzzi_);
        CqlValueSet jzzzzzzzzzzzzzzk_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, jzzzzzzzzzzzzzzl_);
        bool? jzzzzzzzzzzzzzzn_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> jzzzzzzzzzzzzzzy_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept jzzzzzzzzzzzzzzz_(CodeableConcept X)
            {
                CqlConcept kzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return kzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzz_);
            CqlValueSet kzzzzzzzzzzzzzzb_ = this.Bilateral_Modifier(context);
            bool? kzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzb_);

            return kzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(jzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzo_);
        CqlValueSet jzzzzzzzzzzzzzzq_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> jzzzzzzzzzzzzzzs_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, jzzzzzzzzzzzzzzr_);
        bool? jzzzzzzzzzzzzzzt_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> kzzzzzzzzzzzzzze_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept kzzzzzzzzzzzzzzf_(CodeableConcept X)
            {
                CqlConcept kzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return kzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzf_);
            CqlValueSet kzzzzzzzzzzzzzzh_ = this.Clinical_Bilateral_Modifier(context);
            bool? kzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzh_);

            return kzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzt_);
        IEnumerable<Procedure> jzzzzzzzzzzzzzzv_ = context.Operators.Union<Procedure>(jzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzu_);
        bool? jzzzzzzzzzzzzzzw_(Procedure BilateralMastectomyPerformed)
        {
            DataType kzzzzzzzzzzzzzzk_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, kzzzzzzzzzzzzzzk_);
            CqlDateTime kzzzzzzzzzzzzzzm_ = context.Operators.End(kzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzo_ = context.Operators.End(kzzzzzzzzzzzzzzn_);
            bool? kzzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(kzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzo_, default);

            return kzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> jzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzw_);

        return jzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> kzzzzzzzzzzzzzzq_ = this.Right_Mastectomy_Diagnosis(context);
        bool? kzzzzzzzzzzzzzzr_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzq_);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzs_ = this.Right_Mastectomy_Procedure(context);
        bool? kzzzzzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzs_);
        bool? kzzzzzzzzzzzzzzu_ = context.Operators.Or(kzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzt_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzv_ = this.Left_Mastectomy_Diagnosis(context);
        bool? kzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzzzzv_);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzx_ = this.Left_Mastectomy_Procedure(context);
        bool? kzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzx_);
        bool? kzzzzzzzzzzzzzzz_ = context.Operators.Or(kzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzy_);
        bool? lzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzz_);
        IEnumerable<Condition> lzzzzzzzzzzzzzzb_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? lzzzzzzzzzzzzzzc_ = context.Operators.Exists<Condition>(lzzzzzzzzzzzzzzb_);
        bool? lzzzzzzzzzzzzzzd_ = context.Operators.Or(lzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> lzzzzzzzzzzzzzze_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? lzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(lzzzzzzzzzzzzzze_);
        bool? lzzzzzzzzzzzzzzg_ = context.Operators.Or(lzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Exclusions")]
    public bool? Exclusions(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzh_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);
        bool? lzzzzzzzzzzzzzzi_ = this.Mastectomy_Exclusion(context);
        bool? lzzzzzzzzzzzzzzj_ = context.Operators.Or(lzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzi_);
        bool? lzzzzzzzzzzzzzzk_ = NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? lzzzzzzzzzzzzzzl_ = context.Operators.Or(lzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzn_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, lzzzzzzzzzzzzzzm_);
        bool? lzzzzzzzzzzzzzzo_ = context.Operators.Or(lzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzn_);

        return lzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzp_ = this.Mammography(context);
        IEnumerable<Observation> lzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? lzzzzzzzzzzzzzzr_(Observation Mammogram)
        {
            DataType lzzzzzzzzzzzzzzu_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzu_);
            CqlDateTime lzzzzzzzzzzzzzzw_ = context.Operators.End(lzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzx_ = this.Participation_Period(context);
            bool? lzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzx_, default);

            return lzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzr_);
        bool? lzzzzzzzzzzzzzzt_ = context.Operators.Exists<Observation>(lzzzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
