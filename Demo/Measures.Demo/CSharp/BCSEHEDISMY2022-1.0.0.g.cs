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
        object rzzzzzzzzzzzzzzzza_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzze_ = context.Operators.Start(rzzzzzzzzzzzzzzzzd_);
        int? rzzzzzzzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzzzzze_, "year");
        int? rzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzf_, 2);
        decimal? rzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime rzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(rzzzzzzzzzzzzzzzzg_, 10, 1, 0, 0, 0, 0, rzzzzzzzzzzzzzzzzh_);

        return rzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Participation Period")]
    public CqlInterval<CqlDateTime> Participation_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzzzzzzzzj_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzl_ = context.Operators.End(rzzzzzzzzzzzzzzzzk_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzl_, true, true);

        return rzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage(CqlContext context)
    {
        IEnumerable<Coverage> rzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        bool? rzzzzzzzzzzzzzzzzo_(Coverage C)
        {
            Period rzzzzzzzzzzzzzzzzq_ = C?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, rzzzzzzzzzzzzzzzzq_ as object);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzs_ = this.Participation_Period(context);
            bool? rzzzzzzzzzzzzzzzzt_ = context.Operators.Overlaps(rzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzs_, default);

            return rzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Coverage> rzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Coverage>(rzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzo_);

        return rzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period(CqlContext context)
    {
        IEnumerable<Coverage> rzzzzzzzzzzzzzzzzu_ = this.Member_Coverage(context);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzw_ = context.Operators.End(rzzzzzzzzzzzzzzzzv_);
        CqlDate rzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzw_);
        CqlDateTime rzzzzzzzzzzzzzzzzy_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlDate rzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzy_);
        CqlDateTime szzzzzzzzzzzzzzzzb_ = context.Operators.End(rzzzzzzzzzzzzzzzzv_);
        CqlDate szzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzb_);
        CqlQuantity szzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(2m, "years");
        CqlDate szzzzzzzzzzzzzzzze_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDate> szzzzzzzzzzzzzzzzf_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzzzze_, true, true);
        bool? szzzzzzzzzzzzzzzzg_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, rzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzf_, 0);
        CqlDateTime szzzzzzzzzzzzzzzzj_ = context.Operators.End(rzzzzzzzzzzzzzzzzv_);
        CqlDate szzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzj_);
        CqlDateTime szzzzzzzzzzzzzzzzm_ = context.Operators.Start(rzzzzzzzzzzzzzzzzv_);
        CqlDate szzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzm_);
        CqlQuantity szzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1m, "year");
        CqlDate szzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzo_);
        CqlDateTime szzzzzzzzzzzzzzzzr_ = context.Operators.End(rzzzzzzzzzzzzzzzzv_);
        CqlDate szzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzr_);
        CqlDate szzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDate> szzzzzzzzzzzzzzzzv_ = context.Operators.Interval(szzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzu_, true, true);
        bool? szzzzzzzzzzzzzzzzw_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, rzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzv_, 45);
        bool? szzzzzzzzzzzzzzzzx_ = context.Operators.And(szzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzw_);
        CqlDateTime tzzzzzzzzzzzzzzzza_ = context.Operators.End(rzzzzzzzzzzzzzzzzv_);
        CqlDate tzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzza_);
        CqlDateTime tzzzzzzzzzzzzzzzzd_ = context.Operators.Start(rzzzzzzzzzzzzzzzzv_);
        CqlDate tzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzd_);
        CqlDateTime tzzzzzzzzzzzzzzzzg_ = context.Operators.End(rzzzzzzzzzzzzzzzzv_);
        CqlDate tzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(tzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzh_, true, true);
        bool? tzzzzzzzzzzzzzzzzj_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, rzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzi_, 45);
        bool? tzzzzzzzzzzzzzzzzk_ = context.Operators.And(szzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzj_);

        return tzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient tzzzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date tzzzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzzzl_?.BirthDateElement;
        string tzzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzzm_?.Value;
        CqlDate tzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzzzzzzzq_ = context.Operators.End(tzzzzzzzzzzzzzzzzp_);
        CqlDate tzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzq_);
        int? tzzzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzr_, "year");
        CqlInterval<int?> tzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(52, 74, true, true);
        bool? tzzzzzzzzzzzzzzzzu_ = context.Operators.In<int?>(tzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzt_, default);
        Code<AdministrativeGender> tzzzzzzzzzzzzzzzzw_ = tzzzzzzzzzzzzzzzzl_?.GenderElement;
        AdministrativeGender? tzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzw_?.Value;
        string tzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzx_);
        bool? tzzzzzzzzzzzzzzzzz_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzy_, "female");
        bool? uzzzzzzzzzzzzzzzza_ = context.Operators.And(tzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzzzzzzb_ = this.Enrolled_During_Participation_Period(context);
        bool? uzzzzzzzzzzzzzzzzc_ = context.Operators.And(uzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzb_);

        return uzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzd_ = this.Initial_Population(context);

        return uzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzze_ = this.Absence_of_Right_Breast(context);
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, uzzzzzzzzzzzzzzzzf_);
        bool? uzzzzzzzzzzzzzzzzh_(Condition RightMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
            CqlDateTime uzzzzzzzzzzzzzzzzk_ = context.Operators.Start(uzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzm_ = context.Operators.End(uzzzzzzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(uzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzm_, default);

            return uzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Condition> uzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(uzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzh_);

        return uzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzo_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzq_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, uzzzzzzzzzzzzzzzzp_);
        CqlValueSet uzzzzzzzzzzzzzzzzr_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzt_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, uzzzzzzzzzzzzzzzzs_);
        bool? uzzzzzzzzzzzzzzzzu_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> vzzzzzzzzzzzzzzzzf_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept vzzzzzzzzzzzzzzzzg_(CodeableConcept X)
            {
                CqlConcept vzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return vzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> vzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzg_);
            CqlValueSet vzzzzzzzzzzzzzzzzi_ = this.Right_Modifier(context);
            bool? vzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(vzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzi_);

            return vzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzu_);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Procedure>(uzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzv_);
        CqlValueSet uzzzzzzzzzzzzzzzzx_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, uzzzzzzzzzzzzzzzzy_);
        bool? vzzzzzzzzzzzzzzzza_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> vzzzzzzzzzzzzzzzzl_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept vzzzzzzzzzzzzzzzzm_(CodeableConcept X)
            {
                CqlConcept vzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return vzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> vzzzzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzm_);
            CqlValueSet vzzzzzzzzzzzzzzzzo_ = this.Clinical_Right_Modifier(context);
            bool? vzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(vzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzo_);

            return vzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzza_);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Procedure>(uzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzb_);
        bool? vzzzzzzzzzzzzzzzzd_(Procedure RightMastectomyProcedure)
        {
            DataType vzzzzzzzzzzzzzzzzr_ = RightMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzzzzr_);
            CqlDateTime vzzzzzzzzzzzzzzzzt_ = context.Operators.End(vzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzv_ = context.Operators.End(vzzzzzzzzzzzzzzzzu_);
            bool? vzzzzzzzzzzzzzzzzw_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzv_, default);

            return vzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzx_ = this.Absence_of_Left_Breast(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, vzzzzzzzzzzzzzzzzy_);
        bool? wzzzzzzzzzzzzzzzza_(Condition LeftMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzc_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
            CqlDateTime wzzzzzzzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzzzzzzzf_ = context.Operators.End(wzzzzzzzzzzzzzzzze_);
            bool? wzzzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(wzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzf_, default);

            return wzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzza_);

        return wzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzh_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzj_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, wzzzzzzzzzzzzzzzzi_);
        CqlValueSet wzzzzzzzzzzzzzzzzk_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzm_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, wzzzzzzzzzzzzzzzzl_);
        bool? wzzzzzzzzzzzzzzzzn_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> wzzzzzzzzzzzzzzzzy_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept wzzzzzzzzzzzzzzzzz_(CodeableConcept X)
            {
                CqlConcept xzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return xzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzz_);
            CqlValueSet xzzzzzzzzzzzzzzzzb_ = this.Left_Modifier(context);
            bool? xzzzzzzzzzzzzzzzzc_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzb_);

            return xzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Procedure>(wzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzo_);
        CqlValueSet wzzzzzzzzzzzzzzzzq_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzs_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, wzzzzzzzzzzzzzzzzr_);
        bool? wzzzzzzzzzzzzzzzzt_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> xzzzzzzzzzzzzzzzze_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept xzzzzzzzzzzzzzzzzf_(CodeableConcept X)
            {
                CqlConcept xzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return xzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzf_);
            CqlValueSet xzzzzzzzzzzzzzzzzh_ = this.Clinical_Left_Modifier(context);
            bool? xzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzh_);

            return xzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzt_);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Procedure>(wzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzzzzw_(Procedure LeftMastectomyProcedure)
        {
            DataType xzzzzzzzzzzzzzzzzk_ = LeftMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzzzzzzk_);
            CqlDateTime xzzzzzzzzzzzzzzzzm_ = context.Operators.End(xzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzo_ = context.Operators.End(xzzzzzzzzzzzzzzzzn_);
            bool? xzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzo_, default);

            return xzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(wzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzq_ = this.History_of_Bilateral_Mastectomy(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzs_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, xzzzzzzzzzzzzzzzzr_);
        bool? xzzzzzzzzzzzzzzzzt_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime xzzzzzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzy_ = context.Operators.End(xzzzzzzzzzzzzzzzzx_);
            bool? xzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzy_, default);

            return xzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzt_);

        return xzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzza_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzc_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, yzzzzzzzzzzzzzzzzb_);
        CqlValueSet yzzzzzzzzzzzzzzzzd_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzf_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, yzzzzzzzzzzzzzzzze_);
        bool? yzzzzzzzzzzzzzzzzg_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzzr_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept yzzzzzzzzzzzzzzzzs_(CodeableConcept X)
            {
                CqlConcept yzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return yzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzs_);
            CqlValueSet yzzzzzzzzzzzzzzzzu_ = this.Bilateral_Modifier(context);
            bool? yzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzg_);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Procedure>(yzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzh_);
        CqlValueSet yzzzzzzzzzzzzzzzzj_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzl_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, yzzzzzzzzzzzzzzzzk_);
        bool? yzzzzzzzzzzzzzzzzm_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzzx_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept yzzzzzzzzzzzzzzzzy_(CodeableConcept X)
            {
                CqlConcept zzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return zzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzy_);
            CqlValueSet zzzzzzzzzzzzzzzzza_ = this.Clinical_Bilateral_Modifier(context);
            bool? zzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzza_);

            return zzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzm_);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Procedure>(yzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzn_);
        bool? yzzzzzzzzzzzzzzzzp_(Procedure BilateralMastectomyPerformed)
        {
            DataType zzzzzzzzzzzzzzzzzd_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzzzzd_);
            CqlDateTime zzzzzzzzzzzzzzzzzf_ = context.Operators.End(zzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzh_ = context.Operators.End(zzzzzzzzzzzzzzzzzg_);
            bool? zzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzh_, default);

            return zzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzj_ = this.Right_Mastectomy_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzj_);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzl_ = this.Right_Mastectomy_Procedure(context);
        bool? zzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzl_);
        bool? zzzzzzzzzzzzzzzzzn_ = context.Operators.Or(zzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzm_);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzo_ = this.Left_Mastectomy_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzo_);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzq_ = this.Left_Mastectomy_Procedure(context);
        bool? zzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzq_);
        bool? zzzzzzzzzzzzzzzzzs_ = context.Operators.Or(zzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzzzzzt_ = context.Operators.And(zzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzu_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? zzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Condition>(zzzzzzzzzzzzzzzzzu_);
        bool? zzzzzzzzzzzzzzzzzw_ = context.Operators.Or(zzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzv_);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzx_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? zzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzzzzzzzx_);
        bool? zzzzzzzzzzzzzzzzzz_ = context.Operators.Or(zzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzy_);

        return zzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Exclusions")]
    public bool? Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzza_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);
        bool? azzzzzzzzzzzzzzzzzb_ = this.Mastectomy_Exclusion(context);
        bool? azzzzzzzzzzzzzzzzzc_ = context.Operators.Or(azzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzb_);
        bool? azzzzzzzzzzzzzzzzzd_ = NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? azzzzzzzzzzzzzzzzze_ = context.Operators.Or(azzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        bool? azzzzzzzzzzzzzzzzzg_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, azzzzzzzzzzzzzzzzzf_);
        bool? azzzzzzzzzzzzzzzzzh_ = context.Operators.Or(azzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzg_);

        return azzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzi_ = this.Mammography(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzzzzzzzzzzzzzzk_(Observation Mammogram)
        {
            DataType azzzzzzzzzzzzzzzzzn_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzzzzn_);
            CqlDateTime azzzzzzzzzzzzzzzzzp_ = context.Operators.End(azzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzq_ = this.Participation_Period(context);
            bool? azzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzq_, default);

            return azzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzk_);
        bool? azzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Observation>(azzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzm_;
    }


    #endregion Expressions

}
