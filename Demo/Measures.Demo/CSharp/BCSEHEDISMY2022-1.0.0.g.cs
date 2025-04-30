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
        object yzzzzzzzzzzzzzu_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzx_);
        int? yzzzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzzzzzzy_, "year");
        int? zzzzzzzzzzzzzza_ = context.Operators.Subtract(yzzzzzzzzzzzzzz_, 2);
        decimal? zzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime zzzzzzzzzzzzzzc_ = context.Operators.DateTime(zzzzzzzzzzzzzza_, 10, 1, 0, 0, 0, 0, zzzzzzzzzzzzzzb_);

        return zzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Participation Period")]
    public CqlInterval<CqlDateTime> Participation_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzzd_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzf_ = context.Operators.End(zzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzg_ = context.Operators.Interval(zzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzf_, true, true);

        return zzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage(CqlContext context)
    {
        IEnumerable<Coverage> zzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        bool? zzzzzzzzzzzzzzi_(Coverage C)
        {
            Period zzzzzzzzzzzzzzk_ = C?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzk_ as object);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzm_ = this.Participation_Period(context);
            bool? zzzzzzzzzzzzzzn_ = context.Operators.Overlaps(zzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzm_, default);

            return zzzzzzzzzzzzzzn_;
        };
        IEnumerable<Coverage> zzzzzzzzzzzzzzj_ = context.Operators.Where<Coverage>(zzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period(CqlContext context)
    {
        IEnumerable<Coverage> zzzzzzzzzzzzzzo_ = this.Member_Coverage(context);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzq_ = context.Operators.End(zzzzzzzzzzzzzzp_);
        CqlDate zzzzzzzzzzzzzzr_ = context.Operators.DateFrom(zzzzzzzzzzzzzzq_);
        CqlDateTime zzzzzzzzzzzzzzs_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlDate zzzzzzzzzzzzzzt_ = context.Operators.DateFrom(zzzzzzzzzzzzzzs_);
        CqlDateTime zzzzzzzzzzzzzzv_ = context.Operators.End(zzzzzzzzzzzzzzp_);
        CqlDate zzzzzzzzzzzzzzw_ = context.Operators.DateFrom(zzzzzzzzzzzzzzv_);
        CqlQuantity zzzzzzzzzzzzzzx_ = context.Operators.Quantity(2m, "years");
        CqlDate zzzzzzzzzzzzzzy_ = context.Operators.Subtract(zzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzx_);
        CqlInterval<CqlDate> zzzzzzzzzzzzzzz_ = context.Operators.Interval(zzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzy_, true, true);
        bool? azzzzzzzzzzzzzza_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, zzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzz_, 0);
        CqlDateTime azzzzzzzzzzzzzzd_ = context.Operators.End(zzzzzzzzzzzzzzp_);
        CqlDate azzzzzzzzzzzzzze_ = context.Operators.DateFrom(azzzzzzzzzzzzzzd_);
        CqlDateTime azzzzzzzzzzzzzzg_ = context.Operators.Start(zzzzzzzzzzzzzzp_);
        CqlDate azzzzzzzzzzzzzzh_ = context.Operators.DateFrom(azzzzzzzzzzzzzzg_);
        CqlQuantity azzzzzzzzzzzzzzi_ = context.Operators.Quantity(1m, "year");
        CqlDate azzzzzzzzzzzzzzj_ = context.Operators.Subtract(azzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzi_);
        CqlDateTime azzzzzzzzzzzzzzl_ = context.Operators.End(zzzzzzzzzzzzzzp_);
        CqlDate azzzzzzzzzzzzzzm_ = context.Operators.DateFrom(azzzzzzzzzzzzzzl_);
        CqlDate azzzzzzzzzzzzzzo_ = context.Operators.Subtract(azzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzi_);
        CqlInterval<CqlDate> azzzzzzzzzzzzzzp_ = context.Operators.Interval(azzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzo_, true, true);
        bool? azzzzzzzzzzzzzzq_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, zzzzzzzzzzzzzzo_, azzzzzzzzzzzzzze_, azzzzzzzzzzzzzzp_, 45);
        bool? azzzzzzzzzzzzzzr_ = context.Operators.And(azzzzzzzzzzzzzza_, azzzzzzzzzzzzzzq_);
        CqlDateTime azzzzzzzzzzzzzzu_ = context.Operators.End(zzzzzzzzzzzzzzp_);
        CqlDate azzzzzzzzzzzzzzv_ = context.Operators.DateFrom(azzzzzzzzzzzzzzu_);
        CqlDateTime azzzzzzzzzzzzzzx_ = context.Operators.Start(zzzzzzzzzzzzzzp_);
        CqlDate azzzzzzzzzzzzzzy_ = context.Operators.DateFrom(azzzzzzzzzzzzzzx_);
        CqlDateTime bzzzzzzzzzzzzzza_ = context.Operators.End(zzzzzzzzzzzzzzp_);
        CqlDate bzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(bzzzzzzzzzzzzzza_);
        CqlInterval<CqlDate> bzzzzzzzzzzzzzzc_ = context.Operators.Interval(azzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzb_, true, true);
        bool? bzzzzzzzzzzzzzzd_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, zzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzc_, 45);
        bool? bzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzd_);

        return bzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzf_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzg_ = bzzzzzzzzzzzzzzf_?.BirthDateElement;
        string bzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzg_?.Value;
        CqlDate bzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzh_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzk_ = context.Operators.End(bzzzzzzzzzzzzzzj_);
        CqlDate bzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzk_);
        int? bzzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzl_, "year");
        CqlInterval<int?> bzzzzzzzzzzzzzzn_ = context.Operators.Interval(52, 74, true, true);
        bool? bzzzzzzzzzzzzzzo_ = context.Operators.In<int?>(bzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzn_, default);
        Code<AdministrativeGender> bzzzzzzzzzzzzzzq_ = bzzzzzzzzzzzzzzf_?.GenderElement;
        AdministrativeGender? bzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzq_?.Value;
        string bzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzt_ = context.Operators.Equal(bzzzzzzzzzzzzzzs_, "female");
        bool? bzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzt_);
        bool? bzzzzzzzzzzzzzzv_ = this.Enrolled_During_Participation_Period(context);
        bool? bzzzzzzzzzzzzzzw_ = context.Operators.And(bzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzv_);

        return bzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzx_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzy_ = this.Absence_of_Right_Breast(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> czzzzzzzzzzzzzza_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, bzzzzzzzzzzzzzzz_);
        bool? czzzzzzzzzzzzzzb_(Condition RightMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
            CqlDateTime czzzzzzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzg_ = context.Operators.End(czzzzzzzzzzzzzzf_);
            bool? czzzzzzzzzzzzzzh_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzze_, czzzzzzzzzzzzzzg_, default);

            return czzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzza_, czzzzzzzzzzzzzzb_);

        return czzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzi_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzk_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, czzzzzzzzzzzzzzj_);
        CqlValueSet czzzzzzzzzzzzzzl_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzn_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, czzzzzzzzzzzzzzm_);
        bool? czzzzzzzzzzzzzzo_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzz_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept dzzzzzzzzzzzzzza_(CodeableConcept X)
            {
                CqlConcept dzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return dzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzza_);
            CqlValueSet dzzzzzzzzzzzzzzc_ = this.Right_Modifier(context);
            bool? dzzzzzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzc_);

            return dzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzo_);
        IEnumerable<Procedure> czzzzzzzzzzzzzzq_ = context.Operators.Union<Procedure>(czzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzp_);
        CqlValueSet czzzzzzzzzzzzzzr_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> czzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> czzzzzzzzzzzzzzt_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, czzzzzzzzzzzzzzs_);
        bool? czzzzzzzzzzzzzzu_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> dzzzzzzzzzzzzzzf_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept dzzzzzzzzzzzzzzg_(CodeableConcept X)
            {
                CqlConcept dzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return dzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzg_);
            CqlValueSet dzzzzzzzzzzzzzzi_ = this.Clinical_Right_Modifier(context);
            bool? dzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzu_);
        IEnumerable<Procedure> czzzzzzzzzzzzzzw_ = context.Operators.Union<Procedure>(czzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzv_);
        bool? czzzzzzzzzzzzzzx_(Procedure RightMastectomyProcedure)
        {
            DataType dzzzzzzzzzzzzzzl_ = RightMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzzl_);
            CqlDateTime dzzzzzzzzzzzzzzn_ = context.Operators.End(dzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzp_ = context.Operators.End(dzzzzzzzzzzzzzzo_);
            bool? dzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(dzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzp_, default);

            return dzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> czzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(czzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzr_ = this.Absence_of_Left_Breast(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> dzzzzzzzzzzzzzzt_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, dzzzzzzzzzzzzzzs_);
        bool? dzzzzzzzzzzzzzzu_(Condition LeftMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
            CqlDateTime dzzzzzzzzzzzzzzx_ = context.Operators.Start(dzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzz_ = context.Operators.End(dzzzzzzzzzzzzzzy_);
            bool? ezzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(dzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzz_, default);

            return ezzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzu_);

        return dzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzb_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzd_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, ezzzzzzzzzzzzzzc_);
        CqlValueSet ezzzzzzzzzzzzzze_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, ezzzzzzzzzzzzzzf_);
        bool? ezzzzzzzzzzzzzzh_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> ezzzzzzzzzzzzzzs_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept ezzzzzzzzzzzzzzt_(CodeableConcept X)
            {
                CqlConcept ezzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return ezzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzt_);
            CqlValueSet ezzzzzzzzzzzzzzv_ = this.Left_Modifier(context);
            bool? ezzzzzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzv_);

            return ezzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzi_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzh_);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzj_ = context.Operators.Union<Procedure>(ezzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzi_);
        CqlValueSet ezzzzzzzzzzzzzzk_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, ezzzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzzn_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> ezzzzzzzzzzzzzzy_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept ezzzzzzzzzzzzzzz_(CodeableConcept X)
            {
                CqlConcept fzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return fzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzz_);
            CqlValueSet fzzzzzzzzzzzzzzb_ = this.Clinical_Left_Modifier(context);
            bool? fzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(fzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzb_);

            return fzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(ezzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzo_);
        bool? ezzzzzzzzzzzzzzq_(Procedure LeftMastectomyProcedure)
        {
            DataType fzzzzzzzzzzzzzze_ = LeftMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzze_);
            CqlDateTime fzzzzzzzzzzzzzzg_ = context.Operators.End(fzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzi_ = context.Operators.End(fzzzzzzzzzzzzzzh_);
            bool? fzzzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzi_, default);

            return fzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzr_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzq_);

        return ezzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzk_ = this.History_of_Bilateral_Mastectomy(context);
        IEnumerable<Condition> fzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> fzzzzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, fzzzzzzzzzzzzzzl_);
        bool? fzzzzzzzzzzzzzzn_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime fzzzzzzzzzzzzzzq_ = context.Operators.Start(fzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzs_ = context.Operators.End(fzzzzzzzzzzzzzzr_);
            bool? fzzzzzzzzzzzzzzt_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzs_, default);

            return fzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzn_);

        return fzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzu_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzw_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, fzzzzzzzzzzzzzzv_);
        CqlValueSet fzzzzzzzzzzzzzzx_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, fzzzzzzzzzzzzzzy_);
        bool? gzzzzzzzzzzzzzza_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> gzzzzzzzzzzzzzzl_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept gzzzzzzzzzzzzzzm_(CodeableConcept X)
            {
                CqlConcept gzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return gzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzm_);
            CqlValueSet gzzzzzzzzzzzzzzo_ = this.Bilateral_Modifier(context);
            bool? gzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzo_);

            return gzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzza_);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzc_ = context.Operators.Union<Procedure>(fzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzb_);
        CqlValueSet gzzzzzzzzzzzzzzd_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> gzzzzzzzzzzzzzzf_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, gzzzzzzzzzzzzzze_);
        bool? gzzzzzzzzzzzzzzg_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> gzzzzzzzzzzzzzzr_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept gzzzzzzzzzzzzzzs_(CodeableConcept X)
            {
                CqlConcept gzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return gzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> gzzzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzs_);
            CqlValueSet gzzzzzzzzzzzzzzu_ = this.Clinical_Bilateral_Modifier(context);
            bool? gzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(gzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzu_);

            return gzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzg_);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzi_ = context.Operators.Union<Procedure>(gzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzh_);
        bool? gzzzzzzzzzzzzzzj_(Procedure BilateralMastectomyPerformed)
        {
            DataType gzzzzzzzzzzzzzzx_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzzzzzzx_);
            CqlDateTime gzzzzzzzzzzzzzzz_ = context.Operators.End(gzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzb_ = context.Operators.End(hzzzzzzzzzzzzzza_);
            bool? hzzzzzzzzzzzzzzc_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzb_, default);

            return hzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(gzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzj_);

        return gzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> hzzzzzzzzzzzzzzd_ = this.Right_Mastectomy_Diagnosis(context);
        bool? hzzzzzzzzzzzzzze_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzd_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzf_ = this.Right_Mastectomy_Procedure(context);
        bool? hzzzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzf_);
        bool? hzzzzzzzzzzzzzzh_ = context.Operators.Or(hzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzg_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzi_ = this.Left_Mastectomy_Diagnosis(context);
        bool? hzzzzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzi_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzk_ = this.Left_Mastectomy_Procedure(context);
        bool? hzzzzzzzzzzzzzzl_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzm_ = context.Operators.Or(hzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzl_);
        bool? hzzzzzzzzzzzzzzn_ = context.Operators.And(hzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzo_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? hzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzo_);
        bool? hzzzzzzzzzzzzzzq_ = context.Operators.Or(hzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzp_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzr_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? hzzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzr_);
        bool? hzzzzzzzzzzzzzzt_ = context.Operators.Or(hzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzs_);

        return hzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Exclusions")]
    public bool? Exclusions(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzu_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);
        bool? hzzzzzzzzzzzzzzv_ = this.Mastectomy_Exclusion(context);
        bool? hzzzzzzzzzzzzzzw_ = context.Operators.Or(hzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzv_);
        bool? hzzzzzzzzzzzzzzx_ = NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? hzzzzzzzzzzzzzzy_ = context.Operators.Or(hzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
        bool? izzzzzzzzzzzzzza_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, hzzzzzzzzzzzzzzz_);
        bool? izzzzzzzzzzzzzzb_ = context.Operators.Or(hzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzza_);

        return izzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzc_ = this.Mammography(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzzzzzzzzzzzzze_(Observation Mammogram)
        {
            DataType izzzzzzzzzzzzzzh_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzzzzzzh_);
            CqlDateTime izzzzzzzzzzzzzzj_ = context.Operators.End(izzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzk_ = this.Participation_Period(context);
            bool? izzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzk_, default);

            return izzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzd_, izzzzzzzzzzzzzze_);
        bool? izzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzzf_);

        return izzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

}
