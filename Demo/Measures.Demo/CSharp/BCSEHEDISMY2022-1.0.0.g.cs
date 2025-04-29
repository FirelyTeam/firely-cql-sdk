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
        object wzzzzzzzzzzza_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient wzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzb_);

        return wzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> wzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzze_ = context.Operators.Start(wzzzzzzzzzzzd_);
        int? wzzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzze_, "year");
        int? wzzzzzzzzzzzg_ = context.Operators.Subtract(wzzzzzzzzzzzf_, 2);
        decimal? wzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime wzzzzzzzzzzzi_ = context.Operators.DateTime(wzzzzzzzzzzzg_, 10, 1, 0, 0, 0, 0, wzzzzzzzzzzzh_);

        return wzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Participation Period")]
    public CqlInterval<CqlDateTime> Participation_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzj_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzl_ = context.Operators.End(wzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzm_ = context.Operators.Interval(wzzzzzzzzzzzj_, wzzzzzzzzzzzl_, true, true);

        return wzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage(CqlContext context)
    {
        IEnumerable<Coverage> wzzzzzzzzzzzn_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        bool? wzzzzzzzzzzzo_(Coverage C)
        {
            Period wzzzzzzzzzzzq_ = C?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzq_ as object);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzs_ = this.Participation_Period(context);
            bool? wzzzzzzzzzzzt_ = context.Operators.Overlaps(wzzzzzzzzzzzr_, wzzzzzzzzzzzs_, default);

            return wzzzzzzzzzzzt_;
        };
        IEnumerable<Coverage> wzzzzzzzzzzzp_ = context.Operators.Where<Coverage>(wzzzzzzzzzzzn_, wzzzzzzzzzzzo_);

        return wzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period(CqlContext context)
    {
        IEnumerable<Coverage> wzzzzzzzzzzzu_ = this.Member_Coverage(context);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzw_ = context.Operators.End(wzzzzzzzzzzzv_);
        CqlDate wzzzzzzzzzzzx_ = context.Operators.DateFrom(wzzzzzzzzzzzw_);
        CqlDateTime wzzzzzzzzzzzy_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlDate wzzzzzzzzzzzz_ = context.Operators.DateFrom(wzzzzzzzzzzzy_);
        CqlDateTime xzzzzzzzzzzzb_ = context.Operators.End(wzzzzzzzzzzzv_);
        CqlDate xzzzzzzzzzzzc_ = context.Operators.DateFrom(xzzzzzzzzzzzb_);
        CqlQuantity xzzzzzzzzzzzd_ = context.Operators.Quantity(2m, "years");
        CqlDate xzzzzzzzzzzze_ = context.Operators.Subtract(xzzzzzzzzzzzc_, xzzzzzzzzzzzd_);
        CqlInterval<CqlDate> xzzzzzzzzzzzf_ = context.Operators.Interval(wzzzzzzzzzzzz_, xzzzzzzzzzzze_, true, true);
        bool? xzzzzzzzzzzzg_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, wzzzzzzzzzzzu_, wzzzzzzzzzzzx_, xzzzzzzzzzzzf_, 0);
        CqlDateTime xzzzzzzzzzzzj_ = context.Operators.End(wzzzzzzzzzzzv_);
        CqlDate xzzzzzzzzzzzk_ = context.Operators.DateFrom(xzzzzzzzzzzzj_);
        CqlDateTime xzzzzzzzzzzzm_ = context.Operators.Start(wzzzzzzzzzzzv_);
        CqlDate xzzzzzzzzzzzn_ = context.Operators.DateFrom(xzzzzzzzzzzzm_);
        CqlQuantity xzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "year");
        CqlDate xzzzzzzzzzzzp_ = context.Operators.Subtract(xzzzzzzzzzzzn_, xzzzzzzzzzzzo_);
        CqlDateTime xzzzzzzzzzzzr_ = context.Operators.End(wzzzzzzzzzzzv_);
        CqlDate xzzzzzzzzzzzs_ = context.Operators.DateFrom(xzzzzzzzzzzzr_);
        CqlDate xzzzzzzzzzzzu_ = context.Operators.Subtract(xzzzzzzzzzzzs_, xzzzzzzzzzzzo_);
        CqlInterval<CqlDate> xzzzzzzzzzzzv_ = context.Operators.Interval(xzzzzzzzzzzzp_, xzzzzzzzzzzzu_, true, true);
        bool? xzzzzzzzzzzzw_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, wzzzzzzzzzzzu_, xzzzzzzzzzzzk_, xzzzzzzzzzzzv_, 45);
        bool? xzzzzzzzzzzzx_ = context.Operators.And(xzzzzzzzzzzzg_, xzzzzzzzzzzzw_);
        CqlDateTime yzzzzzzzzzzza_ = context.Operators.End(wzzzzzzzzzzzv_);
        CqlDate yzzzzzzzzzzzb_ = context.Operators.DateFrom(yzzzzzzzzzzza_);
        CqlDateTime yzzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzzv_);
        CqlDate yzzzzzzzzzzze_ = context.Operators.DateFrom(yzzzzzzzzzzzd_);
        CqlDateTime yzzzzzzzzzzzg_ = context.Operators.End(wzzzzzzzzzzzv_);
        CqlDate yzzzzzzzzzzzh_ = context.Operators.DateFrom(yzzzzzzzzzzzg_);
        CqlInterval<CqlDate> yzzzzzzzzzzzi_ = context.Operators.Interval(yzzzzzzzzzzze_, yzzzzzzzzzzzh_, true, true);
        bool? yzzzzzzzzzzzj_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, wzzzzzzzzzzzu_, yzzzzzzzzzzzb_, yzzzzzzzzzzzi_, 45);
        bool? yzzzzzzzzzzzk_ = context.Operators.And(xzzzzzzzzzzzx_, yzzzzzzzzzzzj_);

        return yzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient yzzzzzzzzzzzl_ = this.Patient(context);
        Date yzzzzzzzzzzzm_ = yzzzzzzzzzzzl_?.BirthDateElement;
        string yzzzzzzzzzzzn_ = yzzzzzzzzzzzm_?.Value;
        CqlDate yzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime yzzzzzzzzzzzq_ = context.Operators.End(yzzzzzzzzzzzp_);
        CqlDate yzzzzzzzzzzzr_ = context.Operators.DateFrom(yzzzzzzzzzzzq_);
        int? yzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(yzzzzzzzzzzzo_, yzzzzzzzzzzzr_, "year");
        CqlInterval<int?> yzzzzzzzzzzzt_ = context.Operators.Interval(52, 74, true, true);
        bool? yzzzzzzzzzzzu_ = context.Operators.In<int?>(yzzzzzzzzzzzs_, yzzzzzzzzzzzt_, default);
        Code<AdministrativeGender> yzzzzzzzzzzzw_ = yzzzzzzzzzzzl_?.GenderElement;
        AdministrativeGender? yzzzzzzzzzzzx_ = yzzzzzzzzzzzw_?.Value;
        string yzzzzzzzzzzzy_ = context.Operators.Convert<string>(yzzzzzzzzzzzx_);
        bool? yzzzzzzzzzzzz_ = context.Operators.Equal(yzzzzzzzzzzzy_, "female");
        bool? zzzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzzu_, yzzzzzzzzzzzz_);
        bool? zzzzzzzzzzzzb_ = this.Enrolled_During_Participation_Period(context);
        bool? zzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzza_, zzzzzzzzzzzzb_);

        return zzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? zzzzzzzzzzzzd_ = this.Initial_Population(context);

        return zzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzze_ = this.Absence_of_Right_Breast(context);
        IEnumerable<Condition> zzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> zzzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, zzzzzzzzzzzzf_);
        bool? zzzzzzzzzzzzh_(Condition RightMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
            CqlDateTime zzzzzzzzzzzzk_ = context.Operators.Start(zzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzm_ = context.Operators.End(zzzzzzzzzzzzl_);
            bool? zzzzzzzzzzzzn_ = context.Operators.SameOrBefore(zzzzzzzzzzzzk_, zzzzzzzzzzzzm_, default);

            return zzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzi_ = context.Operators.Where<Condition>(zzzzzzzzzzzzg_, zzzzzzzzzzzzh_);

        return zzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzo_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> zzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzq_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, zzzzzzzzzzzzp_);
        CqlValueSet zzzzzzzzzzzzr_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> zzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzt_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, zzzzzzzzzzzzs_);
        bool? zzzzzzzzzzzzu_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> azzzzzzzzzzzzf_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept azzzzzzzzzzzzg_(CodeableConcept X)
            {
                CqlConcept azzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return azzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzf_, azzzzzzzzzzzzg_);
            CqlValueSet azzzzzzzzzzzzi_ = this.Right_Modifier(context);
            bool? azzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzh_, azzzzzzzzzzzzi_);

            return azzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzt_, zzzzzzzzzzzzu_);
        IEnumerable<Procedure> zzzzzzzzzzzzw_ = context.Operators.Union<Procedure>(zzzzzzzzzzzzq_, zzzzzzzzzzzzv_);
        CqlValueSet zzzzzzzzzzzzx_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> zzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, zzzzzzzzzzzzy_);
        bool? azzzzzzzzzzzza_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> azzzzzzzzzzzzl_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept azzzzzzzzzzzzm_(CodeableConcept X)
            {
                CqlConcept azzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return azzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzl_, azzzzzzzzzzzzm_);
            CqlValueSet azzzzzzzzzzzzo_ = this.Clinical_Right_Modifier(context);
            bool? azzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzn_, azzzzzzzzzzzzo_);

            return azzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzz_, azzzzzzzzzzzza_);
        IEnumerable<Procedure> azzzzzzzzzzzzc_ = context.Operators.Union<Procedure>(zzzzzzzzzzzzw_, azzzzzzzzzzzzb_);
        bool? azzzzzzzzzzzzd_(Procedure RightMastectomyProcedure)
        {
            DataType azzzzzzzzzzzzr_ = RightMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, azzzzzzzzzzzzr_);
            CqlDateTime azzzzzzzzzzzzt_ = context.Operators.End(azzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzv_ = context.Operators.End(azzzzzzzzzzzzu_);
            bool? azzzzzzzzzzzzw_ = context.Operators.SameOrBefore(azzzzzzzzzzzzt_, azzzzzzzzzzzzv_, default);

            return azzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzze_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzc_, azzzzzzzzzzzzd_);

        return azzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzx_ = this.Absence_of_Left_Breast(context);
        IEnumerable<Condition> azzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> azzzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, azzzzzzzzzzzzy_);
        bool? bzzzzzzzzzzzza_(Condition LeftMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzc_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
            CqlDateTime bzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzf_ = context.Operators.End(bzzzzzzzzzzzze_);
            bool? bzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzd_, bzzzzzzzzzzzzf_, default);

            return bzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(azzzzzzzzzzzzz_, bzzzzzzzzzzzza_);

        return bzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzh_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, bzzzzzzzzzzzzi_);
        CqlValueSet bzzzzzzzzzzzzk_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, bzzzzzzzzzzzzl_);
        bool? bzzzzzzzzzzzzn_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> bzzzzzzzzzzzzy_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept bzzzzzzzzzzzzz_(CodeableConcept X)
            {
                CqlConcept czzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return czzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzy_, bzzzzzzzzzzzzz_);
            CqlValueSet czzzzzzzzzzzzb_ = this.Left_Modifier(context);
            bool? czzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzza_, czzzzzzzzzzzzb_);

            return czzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzm_, bzzzzzzzzzzzzn_);
        IEnumerable<Procedure> bzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(bzzzzzzzzzzzzj_, bzzzzzzzzzzzzo_);
        CqlValueSet bzzzzzzzzzzzzq_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> bzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> bzzzzzzzzzzzzs_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, bzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzt_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> czzzzzzzzzzzze_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept czzzzzzzzzzzzf_(CodeableConcept X)
            {
                CqlConcept czzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return czzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzze_, czzzzzzzzzzzzf_);
            CqlValueSet czzzzzzzzzzzzh_ = this.Clinical_Left_Modifier(context);
            bool? czzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(czzzzzzzzzzzzg_, czzzzzzzzzzzzh_);

            return czzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzs_, bzzzzzzzzzzzzt_);
        IEnumerable<Procedure> bzzzzzzzzzzzzv_ = context.Operators.Union<Procedure>(bzzzzzzzzzzzzp_, bzzzzzzzzzzzzu_);
        bool? bzzzzzzzzzzzzw_(Procedure LeftMastectomyProcedure)
        {
            DataType czzzzzzzzzzzzk_ = LeftMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, czzzzzzzzzzzzk_);
            CqlDateTime czzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzo_ = context.Operators.End(czzzzzzzzzzzzn_);
            bool? czzzzzzzzzzzzp_ = context.Operators.SameOrBefore(czzzzzzzzzzzzm_, czzzzzzzzzzzzo_, default);

            return czzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> bzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(bzzzzzzzzzzzzv_, bzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzq_ = this.History_of_Bilateral_Mastectomy(context);
        IEnumerable<Condition> czzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> czzzzzzzzzzzzs_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, czzzzzzzzzzzzr_);
        bool? czzzzzzzzzzzzt_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime czzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzy_ = context.Operators.End(czzzzzzzzzzzzx_);
            bool? czzzzzzzzzzzzz_ = context.Operators.SameOrBefore(czzzzzzzzzzzzw_, czzzzzzzzzzzzy_, default);

            return czzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzu_ = context.Operators.Where<Condition>(czzzzzzzzzzzzs_, czzzzzzzzzzzzt_);

        return czzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzza_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzc_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, dzzzzzzzzzzzzb_);
        CqlValueSet dzzzzzzzzzzzzd_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> dzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzf_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, dzzzzzzzzzzzze_);
        bool? dzzzzzzzzzzzzg_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> dzzzzzzzzzzzzr_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept dzzzzzzzzzzzzs_(CodeableConcept X)
            {
                CqlConcept dzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return dzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzzzzr_, dzzzzzzzzzzzzs_);
            CqlValueSet dzzzzzzzzzzzzu_ = this.Bilateral_Modifier(context);
            bool? dzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzt_, dzzzzzzzzzzzzu_);

            return dzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzf_, dzzzzzzzzzzzzg_);
        IEnumerable<Procedure> dzzzzzzzzzzzzi_ = context.Operators.Union<Procedure>(dzzzzzzzzzzzzc_, dzzzzzzzzzzzzh_);
        CqlValueSet dzzzzzzzzzzzzj_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzl_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, dzzzzzzzzzzzzk_);
        bool? dzzzzzzzzzzzzm_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> dzzzzzzzzzzzzx_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept dzzzzzzzzzzzzy_(CodeableConcept X)
            {
                CqlConcept ezzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return ezzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzzzzx_, dzzzzzzzzzzzzy_);
            CqlValueSet ezzzzzzzzzzzza_ = this.Clinical_Bilateral_Modifier(context);
            bool? ezzzzzzzzzzzzb_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzz_, ezzzzzzzzzzzza_);

            return ezzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzl_, dzzzzzzzzzzzzm_);
        IEnumerable<Procedure> dzzzzzzzzzzzzo_ = context.Operators.Union<Procedure>(dzzzzzzzzzzzzi_, dzzzzzzzzzzzzn_);
        bool? dzzzzzzzzzzzzp_(Procedure BilateralMastectomyPerformed)
        {
            DataType ezzzzzzzzzzzzd_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ezzzzzzzzzzzzd_);
            CqlDateTime ezzzzzzzzzzzzf_ = context.Operators.End(ezzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzh_ = context.Operators.End(ezzzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzzi_ = context.Operators.SameOrBefore(ezzzzzzzzzzzzf_, ezzzzzzzzzzzzh_, default);

            return ezzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> dzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzo_, dzzzzzzzzzzzzp_);

        return dzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> ezzzzzzzzzzzzj_ = this.Right_Mastectomy_Diagnosis(context);
        bool? ezzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzj_);
        IEnumerable<Procedure> ezzzzzzzzzzzzl_ = this.Right_Mastectomy_Procedure(context);
        bool? ezzzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzn_ = context.Operators.Or(ezzzzzzzzzzzzk_, ezzzzzzzzzzzzm_);
        IEnumerable<Condition> ezzzzzzzzzzzzo_ = this.Left_Mastectomy_Diagnosis(context);
        bool? ezzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzo_);
        IEnumerable<Procedure> ezzzzzzzzzzzzq_ = this.Left_Mastectomy_Procedure(context);
        bool? ezzzzzzzzzzzzr_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzq_);
        bool? ezzzzzzzzzzzzs_ = context.Operators.Or(ezzzzzzzzzzzzp_, ezzzzzzzzzzzzr_);
        bool? ezzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzn_, ezzzzzzzzzzzzs_);
        IEnumerable<Condition> ezzzzzzzzzzzzu_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? ezzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzu_);
        bool? ezzzzzzzzzzzzw_ = context.Operators.Or(ezzzzzzzzzzzzt_, ezzzzzzzzzzzzv_);
        IEnumerable<Procedure> ezzzzzzzzzzzzx_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? ezzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzx_);
        bool? ezzzzzzzzzzzzz_ = context.Operators.Or(ezzzzzzzzzzzzw_, ezzzzzzzzzzzzy_);

        return ezzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Exclusions")]
    public bool? Exclusions(CqlContext context)
    {
        bool? fzzzzzzzzzzzza_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);
        bool? fzzzzzzzzzzzzb_ = this.Mastectomy_Exclusion(context);
        bool? fzzzzzzzzzzzzc_ = context.Operators.Or(fzzzzzzzzzzzza_, fzzzzzzzzzzzzb_);
        bool? fzzzzzzzzzzzzd_ = NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? fzzzzzzzzzzzze_ = context.Operators.Or(fzzzzzzzzzzzzc_, fzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        bool? fzzzzzzzzzzzzg_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, fzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzh_ = context.Operators.Or(fzzzzzzzzzzzze_, fzzzzzzzzzzzzg_);

        return fzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzi_ = this.Mammography(context);
        IEnumerable<Observation> fzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? fzzzzzzzzzzzzk_(Observation Mammogram)
        {
            DataType fzzzzzzzzzzzzn_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, fzzzzzzzzzzzzn_);
            CqlDateTime fzzzzzzzzzzzzp_ = context.Operators.End(fzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzq_ = this.Participation_Period(context);
            bool? fzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzp_, fzzzzzzzzzzzzq_, default);

            return fzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzj_, fzzzzzzzzzzzzk_);
        bool? fzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(fzzzzzzzzzzzzl_);

        return fzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
