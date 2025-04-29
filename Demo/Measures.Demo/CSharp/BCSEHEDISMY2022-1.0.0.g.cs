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

    #region ValueSet: Absence of Left Breast
    [CqlValueSetDefinition(
        definitionName: "Absence of Left Breast",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329",
        valueSetVersion: null)]
    public CqlValueSet Absence_of_Left_Breast(CqlContext context) => _Absence_of_Left_Breast;

    private static readonly CqlValueSet _Absence_of_Left_Breast = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1329", null);
    #endregion

    #region ValueSet: Absence of Right Breast
    [CqlValueSetDefinition(
        definitionName: "Absence of Right Breast",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330",
        valueSetVersion: null)]
    public CqlValueSet Absence_of_Right_Breast(CqlContext context) => _Absence_of_Right_Breast;

    private static readonly CqlValueSet _Absence_of_Right_Breast = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1330", null);
    #endregion

    #region ValueSet: Bilateral Mastectomy
    [CqlValueSetDefinition(
        definitionName: "Bilateral Mastectomy",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042",
        valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext context) => _Bilateral_Mastectomy;

    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1042", null);
    #endregion

    #region ValueSet: Bilateral Modifier
    [CqlValueSetDefinition(
        definitionName: "Bilateral Modifier",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043",
        valueSetVersion: null)]
    public CqlValueSet Bilateral_Modifier(CqlContext context) => _Bilateral_Modifier;

    private static readonly CqlValueSet _Bilateral_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1043", null);
    #endregion

    #region ValueSet: Clinical Bilateral Modifier
    [CqlValueSetDefinition(
        definitionName: "Clinical Bilateral Modifier",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951",
        valueSetVersion: null)]
    public CqlValueSet Clinical_Bilateral_Modifier(CqlContext context) => _Clinical_Bilateral_Modifier;

    private static readonly CqlValueSet _Clinical_Bilateral_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1951", null);
    #endregion

    #region ValueSet: Clinical Left Modifier
    [CqlValueSetDefinition(
        definitionName: "Clinical Left Modifier",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949",
        valueSetVersion: null)]
    public CqlValueSet Clinical_Left_Modifier(CqlContext context) => _Clinical_Left_Modifier;

    private static readonly CqlValueSet _Clinical_Left_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1949", null);
    #endregion

    #region ValueSet: Clinical Right Modifier
    [CqlValueSetDefinition(
        definitionName: "Clinical Right Modifier",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950",
        valueSetVersion: null)]
    public CqlValueSet Clinical_Right_Modifier(CqlContext context) => _Clinical_Right_Modifier;

    private static readonly CqlValueSet _Clinical_Right_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1950", null);
    #endregion

    #region ValueSet: Clinical Unilateral Mastectomy
    [CqlValueSetDefinition(
        definitionName: "Clinical Unilateral Mastectomy",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948",
        valueSetVersion: null)]
    public CqlValueSet Clinical_Unilateral_Mastectomy(CqlContext context) => _Clinical_Unilateral_Mastectomy;

    private static readonly CqlValueSet _Clinical_Unilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1948", null);
    #endregion

    #region ValueSet: History of Bilateral Mastectomy
    [CqlValueSetDefinition(
        definitionName: "History of Bilateral Mastectomy",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331",
        valueSetVersion: null)]
    public CqlValueSet History_of_Bilateral_Mastectomy(CqlContext context) => _History_of_Bilateral_Mastectomy;

    private static readonly CqlValueSet _History_of_Bilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1331", null);
    #endregion

    #region ValueSet: Left Modifier
    [CqlValueSetDefinition(
        definitionName: "Left Modifier",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148",
        valueSetVersion: null)]
    public CqlValueSet Left_Modifier(CqlContext context) => _Left_Modifier;

    private static readonly CqlValueSet _Left_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1148", null);
    #endregion

    #region ValueSet: Mammography
    [CqlValueSetDefinition(
        definitionName: "Mammography",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168",
        valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext context) => _Mammography;

    private static readonly CqlValueSet _Mammography = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1168", null);
    #endregion

    #region ValueSet: Right Modifier
    [CqlValueSetDefinition(
        definitionName: "Right Modifier",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230",
        valueSetVersion: null)]
    public CqlValueSet Right_Modifier(CqlContext context) => _Right_Modifier;

    private static readonly CqlValueSet _Right_Modifier = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1230", null);
    #endregion

    #region ValueSet: Unilateral Mastectomy
    [CqlValueSetDefinition(
        definitionName: "Unilateral Mastectomy",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy(CqlContext context) => _Unilateral_Mastectomy;

    private static readonly CqlValueSet _Unilateral_Mastectomy = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1256", null);
    #endregion

    #region ValueSet: Unilateral Mastectomy Left
    [CqlValueSetDefinition(
        definitionName: "Unilateral Mastectomy Left",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext context) => _Unilateral_Mastectomy_Left;

    private static readonly CqlValueSet _Unilateral_Mastectomy_Left = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1334", null);
    #endregion

    #region ValueSet: Unilateral Mastectomy Right
    [CqlValueSetDefinition(
        definitionName: "Unilateral Mastectomy Right",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext context) => _Unilateral_Mastectomy_Right;

    private static readonly CqlValueSet _Unilateral_Mastectomy_Right = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1335", null);
    #endregion

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object rzzzzzzzzzzo_ = context.ResolveParameter("BCSEHEDISMY2022-1.0.0", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient rzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzp_);

        return rzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> rzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzs_ = context.Operators.Start(rzzzzzzzzzzr_);
        int? rzzzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzs_, "year");
        int? rzzzzzzzzzzu_ = context.Operators.Subtract(rzzzzzzzzzzt_, 2);
        decimal? rzzzzzzzzzzv_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime rzzzzzzzzzzw_ = context.Operators.DateTime(rzzzzzzzzzzu_, 10, 1, 0, 0, 0, 0, rzzzzzzzzzzv_);

        return rzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Participation Period")]
    public CqlInterval<CqlDateTime> Participation_Period(CqlContext context)
    {
        CqlDateTime rzzzzzzzzzzx_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlInterval<CqlDateTime> rzzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzz_ = context.Operators.End(rzzzzzzzzzzy_);
        CqlInterval<CqlDateTime> szzzzzzzzzza_ = context.Operators.Interval(rzzzzzzzzzzx_, rzzzzzzzzzzz_, true, true);

        return szzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Member Coverage")]
    public IEnumerable<Coverage> Member_Coverage(CqlContext context)
    {
        IEnumerable<Coverage> szzzzzzzzzzb_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        bool? szzzzzzzzzzc_(Coverage C)
        {
            Period szzzzzzzzzze_ = C?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzzzzze_ as object);
            CqlInterval<CqlDateTime> szzzzzzzzzzg_ = this.Participation_Period(context);
            bool? szzzzzzzzzzh_ = context.Operators.Overlaps(szzzzzzzzzzf_, szzzzzzzzzzg_, default);

            return szzzzzzzzzzh_;
        };
        IEnumerable<Coverage> szzzzzzzzzzd_ = context.Operators.Where<Coverage>(szzzzzzzzzzb_, szzzzzzzzzzc_);

        return szzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Enrolled During Participation Period")]
    public bool? Enrolled_During_Participation_Period(CqlContext context)
    {
        IEnumerable<Coverage> szzzzzzzzzzi_ = this.Member_Coverage(context);
        CqlInterval<CqlDateTime> szzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime szzzzzzzzzzk_ = context.Operators.End(szzzzzzzzzzj_);
        CqlDate szzzzzzzzzzl_ = context.Operators.DateFrom(szzzzzzzzzzk_);
        CqlDateTime szzzzzzzzzzm_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
        CqlDate szzzzzzzzzzn_ = context.Operators.DateFrom(szzzzzzzzzzm_);
        CqlDateTime szzzzzzzzzzp_ = context.Operators.End(szzzzzzzzzzj_);
        CqlDate szzzzzzzzzzq_ = context.Operators.DateFrom(szzzzzzzzzzp_);
        CqlQuantity szzzzzzzzzzr_ = context.Operators.Quantity(2m, "years");
        CqlDate szzzzzzzzzzs_ = context.Operators.Subtract(szzzzzzzzzzq_, szzzzzzzzzzr_);
        CqlInterval<CqlDate> szzzzzzzzzzt_ = context.Operators.Interval(szzzzzzzzzzn_, szzzzzzzzzzs_, true, true);
        bool? szzzzzzzzzzu_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, szzzzzzzzzzi_, szzzzzzzzzzl_, szzzzzzzzzzt_, 0);
        CqlDateTime szzzzzzzzzzx_ = context.Operators.End(szzzzzzzzzzj_);
        CqlDate szzzzzzzzzzy_ = context.Operators.DateFrom(szzzzzzzzzzx_);
        CqlDateTime tzzzzzzzzzza_ = context.Operators.Start(szzzzzzzzzzj_);
        CqlDate tzzzzzzzzzzb_ = context.Operators.DateFrom(tzzzzzzzzzza_);
        CqlQuantity tzzzzzzzzzzc_ = context.Operators.Quantity(1m, "year");
        CqlDate tzzzzzzzzzzd_ = context.Operators.Subtract(tzzzzzzzzzzb_, tzzzzzzzzzzc_);
        CqlDateTime tzzzzzzzzzzf_ = context.Operators.End(szzzzzzzzzzj_);
        CqlDate tzzzzzzzzzzg_ = context.Operators.DateFrom(tzzzzzzzzzzf_);
        CqlDate tzzzzzzzzzzi_ = context.Operators.Subtract(tzzzzzzzzzzg_, tzzzzzzzzzzc_);
        CqlInterval<CqlDate> tzzzzzzzzzzj_ = context.Operators.Interval(tzzzzzzzzzzd_, tzzzzzzzzzzi_, true, true);
        bool? tzzzzzzzzzzk_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, szzzzzzzzzzi_, szzzzzzzzzzy_, tzzzzzzzzzzj_, 45);
        bool? tzzzzzzzzzzl_ = context.Operators.And(szzzzzzzzzzu_, tzzzzzzzzzzk_);
        CqlDateTime tzzzzzzzzzzo_ = context.Operators.End(szzzzzzzzzzj_);
        CqlDate tzzzzzzzzzzp_ = context.Operators.DateFrom(tzzzzzzzzzzo_);
        CqlDateTime tzzzzzzzzzzr_ = context.Operators.Start(szzzzzzzzzzj_);
        CqlDate tzzzzzzzzzzs_ = context.Operators.DateFrom(tzzzzzzzzzzr_);
        CqlDateTime tzzzzzzzzzzu_ = context.Operators.End(szzzzzzzzzzj_);
        CqlDate tzzzzzzzzzzv_ = context.Operators.DateFrom(tzzzzzzzzzzu_);
        CqlInterval<CqlDate> tzzzzzzzzzzw_ = context.Operators.Interval(tzzzzzzzzzzs_, tzzzzzzzzzzv_, true, true);
        bool? tzzzzzzzzzzx_ = NCQAHealthPlanEnrollment_1_0_0.Instance.Health_Plan_Enrollment_Criteria(context, szzzzzzzzzzi_, tzzzzzzzzzzp_, tzzzzzzzzzzw_, 45);
        bool? tzzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzzl_, tzzzzzzzzzzx_);

        return tzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient tzzzzzzzzzzz_ = this.Patient(context);
        Date uzzzzzzzzzza_ = tzzzzzzzzzzz_?.BirthDateElement;
        string uzzzzzzzzzzb_ = uzzzzzzzzzza_?.Value;
        CqlDate uzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzzzzzze_ = context.Operators.End(uzzzzzzzzzzd_);
        CqlDate uzzzzzzzzzzf_ = context.Operators.DateFrom(uzzzzzzzzzze_);
        int? uzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzc_, uzzzzzzzzzzf_, "year");
        CqlInterval<int?> uzzzzzzzzzzh_ = context.Operators.Interval(52, 74, true, true);
        bool? uzzzzzzzzzzi_ = context.Operators.In<int?>(uzzzzzzzzzzg_, uzzzzzzzzzzh_, default);
        Code<AdministrativeGender> uzzzzzzzzzzk_ = tzzzzzzzzzzz_?.GenderElement;
        AdministrativeGender? uzzzzzzzzzzl_ = uzzzzzzzzzzk_?.Value;
        string uzzzzzzzzzzm_ = context.Operators.Convert<string>(uzzzzzzzzzzl_);
        bool? uzzzzzzzzzzn_ = context.Operators.Equal(uzzzzzzzzzzm_, "female");
        bool? uzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzi_, uzzzzzzzzzzn_);
        bool? uzzzzzzzzzzp_ = this.Enrolled_During_Participation_Period(context);
        bool? uzzzzzzzzzzq_ = context.Operators.And(uzzzzzzzzzzo_, uzzzzzzzzzzp_);

        return uzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? uzzzzzzzzzzr_ = this.Initial_Population(context);

        return uzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzs_ = this.Absence_of_Right_Breast(context);
        IEnumerable<Condition> uzzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> uzzzzzzzzzzu_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, uzzzzzzzzzzt_);
        bool? uzzzzzzzzzzv_(Condition RightMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, RightMastectomyDiagnosis);
            CqlDateTime uzzzzzzzzzzy_ = context.Operators.Start(uzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzza_ = context.Operators.End(uzzzzzzzzzzz_);
            bool? vzzzzzzzzzzb_ = context.Operators.SameOrBefore(uzzzzzzzzzzy_, vzzzzzzzzzza_, default);

            return vzzzzzzzzzzb_;
        };
        IEnumerable<Condition> uzzzzzzzzzzw_ = context.Operators.Where<Condition>(uzzzzzzzzzzu_, uzzzzzzzzzzv_);

        return uzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzc_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> vzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> vzzzzzzzzzze_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, vzzzzzzzzzzd_);
        CqlValueSet vzzzzzzzzzzf_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> vzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> vzzzzzzzzzzh_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, vzzzzzzzzzzg_);
        bool? vzzzzzzzzzzi_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> vzzzzzzzzzzt_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept vzzzzzzzzzzu_(CodeableConcept X)
            {
                CqlConcept vzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return vzzzzzzzzzzy_;
            };
            IEnumerable<CqlConcept> vzzzzzzzzzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzt_, vzzzzzzzzzzu_);
            CqlValueSet vzzzzzzzzzzw_ = this.Right_Modifier(context);
            bool? vzzzzzzzzzzx_ = context.Operators.ConceptsInValueSet(vzzzzzzzzzzv_, vzzzzzzzzzzw_);

            return vzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzj_ = context.Operators.Where<Procedure>(vzzzzzzzzzzh_, vzzzzzzzzzzi_);
        IEnumerable<Procedure> vzzzzzzzzzzk_ = context.Operators.Union<Procedure>(vzzzzzzzzzze_, vzzzzzzzzzzj_);
        CqlValueSet vzzzzzzzzzzl_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> vzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> vzzzzzzzzzzn_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, vzzzzzzzzzzm_);
        bool? vzzzzzzzzzzo_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> vzzzzzzzzzzz_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept wzzzzzzzzzza_(CodeableConcept X)
            {
                CqlConcept wzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return wzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> wzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)vzzzzzzzzzzz_, wzzzzzzzzzza_);
            CqlValueSet wzzzzzzzzzzc_ = this.Clinical_Right_Modifier(context);
            bool? wzzzzzzzzzzd_ = context.Operators.ConceptsInValueSet(wzzzzzzzzzzb_, wzzzzzzzzzzc_);

            return wzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzp_ = context.Operators.Where<Procedure>(vzzzzzzzzzzn_, vzzzzzzzzzzo_);
        IEnumerable<Procedure> vzzzzzzzzzzq_ = context.Operators.Union<Procedure>(vzzzzzzzzzzk_, vzzzzzzzzzzp_);
        bool? vzzzzzzzzzzr_(Procedure RightMastectomyProcedure)
        {
            DataType wzzzzzzzzzzf_ = RightMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> wzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzf_);
            CqlDateTime wzzzzzzzzzzh_ = context.Operators.End(wzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzj_ = context.Operators.End(wzzzzzzzzzzi_);
            bool? wzzzzzzzzzzk_ = context.Operators.SameOrBefore(wzzzzzzzzzzh_, wzzzzzzzzzzj_, default);

            return wzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzs_ = context.Operators.Where<Procedure>(vzzzzzzzzzzq_, vzzzzzzzzzzr_);

        return vzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzl_ = this.Absence_of_Left_Breast(context);
        IEnumerable<Condition> wzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzl_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> wzzzzzzzzzzn_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, wzzzzzzzzzzm_);
        bool? wzzzzzzzzzzo_(Condition LeftMastectomyDiagnosis)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, LeftMastectomyDiagnosis);
            CqlDateTime wzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzzzzzt_ = context.Operators.End(wzzzzzzzzzzs_);
            bool? wzzzzzzzzzzu_ = context.Operators.SameOrBefore(wzzzzzzzzzzr_, wzzzzzzzzzzt_, default);

            return wzzzzzzzzzzu_;
        };
        IEnumerable<Condition> wzzzzzzzzzzp_ = context.Operators.Where<Condition>(wzzzzzzzzzzn_, wzzzzzzzzzzo_);

        return wzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzv_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> wzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> wzzzzzzzzzzx_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, wzzzzzzzzzzw_);
        CqlValueSet wzzzzzzzzzzy_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> wzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> xzzzzzzzzzza_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, wzzzzzzzzzzz_);
        bool? xzzzzzzzzzzb_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> xzzzzzzzzzzm_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept xzzzzzzzzzzn_(CodeableConcept X)
            {
                CqlConcept xzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return xzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzzzzzzzzzm_, xzzzzzzzzzzn_);
            CqlValueSet xzzzzzzzzzzp_ = this.Left_Modifier(context);
            bool? xzzzzzzzzzzq_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzo_, xzzzzzzzzzzp_);

            return xzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzc_ = context.Operators.Where<Procedure>(xzzzzzzzzzza_, xzzzzzzzzzzb_);
        IEnumerable<Procedure> xzzzzzzzzzzd_ = context.Operators.Union<Procedure>(wzzzzzzzzzzx_, xzzzzzzzzzzc_);
        CqlValueSet xzzzzzzzzzze_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> xzzzzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, xzzzzzzzzzzf_);
        bool? xzzzzzzzzzzh_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> xzzzzzzzzzzs_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept xzzzzzzzzzzt_(CodeableConcept X)
            {
                CqlConcept xzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return xzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzzzzzzzzzs_, xzzzzzzzzzzt_);
            CqlValueSet xzzzzzzzzzzv_ = this.Clinical_Left_Modifier(context);
            bool? xzzzzzzzzzzw_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzu_, xzzzzzzzzzzv_);

            return xzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzi_ = context.Operators.Where<Procedure>(xzzzzzzzzzzg_, xzzzzzzzzzzh_);
        IEnumerable<Procedure> xzzzzzzzzzzj_ = context.Operators.Union<Procedure>(xzzzzzzzzzzd_, xzzzzzzzzzzi_);
        bool? xzzzzzzzzzzk_(Procedure LeftMastectomyProcedure)
        {
            DataType xzzzzzzzzzzy_ = LeftMastectomyProcedure?.Performed;
            CqlInterval<CqlDateTime> xzzzzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzy_);
            CqlDateTime yzzzzzzzzzza_ = context.Operators.End(xzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzc_ = context.Operators.End(yzzzzzzzzzzb_);
            bool? yzzzzzzzzzzd_ = context.Operators.SameOrBefore(yzzzzzzzzzza_, yzzzzzzzzzzc_, default);

            return yzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzl_ = context.Operators.Where<Procedure>(xzzzzzzzzzzj_, xzzzzzzzzzzk_);

        return xzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzze_ = this.History_of_Bilateral_Mastectomy(context);
        IEnumerable<Condition> yzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        IEnumerable<Condition> yzzzzzzzzzzg_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, yzzzzzzzzzzf_);
        bool? yzzzzzzzzzzh_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime yzzzzzzzzzzk_ = context.Operators.Start(yzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzm_ = context.Operators.End(yzzzzzzzzzzl_);
            bool? yzzzzzzzzzzn_ = context.Operators.SameOrBefore(yzzzzzzzzzzk_, yzzzzzzzzzzm_, default);

            return yzzzzzzzzzzn_;
        };
        IEnumerable<Condition> yzzzzzzzzzzi_ = context.Operators.Where<Condition>(yzzzzzzzzzzg_, yzzzzzzzzzzh_);

        return yzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzo_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> yzzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzq_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, yzzzzzzzzzzp_);
        CqlValueSet yzzzzzzzzzzr_ = this.Unilateral_Mastectomy(context);
        IEnumerable<Procedure> yzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzt_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, yzzzzzzzzzzs_);
        bool? yzzzzzzzzzzu_(Procedure UnilateralMastectomyProcedure)
        {
            List<CodeableConcept> zzzzzzzzzzzf_ = UnilateralMastectomyProcedure?.BodySite;
            CqlConcept zzzzzzzzzzzg_(CodeableConcept X)
            {
                CqlConcept zzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return zzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzf_, zzzzzzzzzzzg_);
            CqlValueSet zzzzzzzzzzzi_ = this.Bilateral_Modifier(context);
            bool? zzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzh_, zzzzzzzzzzzi_);

            return zzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzv_ = context.Operators.Where<Procedure>(yzzzzzzzzzzt_, yzzzzzzzzzzu_);
        IEnumerable<Procedure> yzzzzzzzzzzw_ = context.Operators.Union<Procedure>(yzzzzzzzzzzq_, yzzzzzzzzzzv_);
        CqlValueSet yzzzzzzzzzzx_ = this.Clinical_Unilateral_Mastectomy(context);
        IEnumerable<Procedure> yzzzzzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzz_ = NCQAStatus_1_0_0.Instance.Completed_Procedure(context, yzzzzzzzzzzy_);
        bool? zzzzzzzzzzza_(Procedure ClinicalUnilateralMastectomyProcedure)
        {
            List<CodeableConcept> zzzzzzzzzzzl_ = ClinicalUnilateralMastectomyProcedure?.BodySite;
            CqlConcept zzzzzzzzzzzm_(CodeableConcept X)
            {
                CqlConcept zzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return zzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzl_, zzzzzzzzzzzm_);
            CqlValueSet zzzzzzzzzzzo_ = this.Clinical_Bilateral_Modifier(context);
            bool? zzzzzzzzzzzp_ = context.Operators.ConceptsInValueSet(zzzzzzzzzzzn_, zzzzzzzzzzzo_);

            return zzzzzzzzzzzp_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzb_ = context.Operators.Where<Procedure>(yzzzzzzzzzzz_, zzzzzzzzzzza_);
        IEnumerable<Procedure> zzzzzzzzzzzc_ = context.Operators.Union<Procedure>(yzzzzzzzzzzw_, zzzzzzzzzzzb_);
        bool? zzzzzzzzzzzd_(Procedure BilateralMastectomyPerformed)
        {
            DataType zzzzzzzzzzzr_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> zzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, zzzzzzzzzzzr_);
            CqlDateTime zzzzzzzzzzzt_ = context.Operators.End(zzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzv_ = context.Operators.End(zzzzzzzzzzzu_);
            bool? zzzzzzzzzzzw_ = context.Operators.SameOrBefore(zzzzzzzzzzzt_, zzzzzzzzzzzv_, default);

            return zzzzzzzzzzzw_;
        };
        IEnumerable<Procedure> zzzzzzzzzzze_ = context.Operators.Where<Procedure>(zzzzzzzzzzzc_, zzzzzzzzzzzd_);

        return zzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Mastectomy Exclusion")]
    public bool? Mastectomy_Exclusion(CqlContext context)
    {
        IEnumerable<Condition> zzzzzzzzzzzx_ = this.Right_Mastectomy_Diagnosis(context);
        bool? zzzzzzzzzzzy_ = context.Operators.Exists<Condition>(zzzzzzzzzzzx_);
        IEnumerable<Procedure> zzzzzzzzzzzz_ = this.Right_Mastectomy_Procedure(context);
        bool? azzzzzzzzzzza_ = context.Operators.Exists<Procedure>(zzzzzzzzzzzz_);
        bool? azzzzzzzzzzzb_ = context.Operators.Or(zzzzzzzzzzzy_, azzzzzzzzzzza_);
        IEnumerable<Condition> azzzzzzzzzzzc_ = this.Left_Mastectomy_Diagnosis(context);
        bool? azzzzzzzzzzzd_ = context.Operators.Exists<Condition>(azzzzzzzzzzzc_);
        IEnumerable<Procedure> azzzzzzzzzzze_ = this.Left_Mastectomy_Procedure(context);
        bool? azzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(azzzzzzzzzzze_);
        bool? azzzzzzzzzzzg_ = context.Operators.Or(azzzzzzzzzzzd_, azzzzzzzzzzzf_);
        bool? azzzzzzzzzzzh_ = context.Operators.And(azzzzzzzzzzzb_, azzzzzzzzzzzg_);
        IEnumerable<Condition> azzzzzzzzzzzi_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? azzzzzzzzzzzj_ = context.Operators.Exists<Condition>(azzzzzzzzzzzi_);
        bool? azzzzzzzzzzzk_ = context.Operators.Or(azzzzzzzzzzzh_, azzzzzzzzzzzj_);
        IEnumerable<Procedure> azzzzzzzzzzzl_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? azzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzl_);
        bool? azzzzzzzzzzzn_ = context.Operators.Or(azzzzzzzzzzzk_, azzzzzzzzzzzm_);

        return azzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Exclusions")]
    public bool? Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzo_ = NCQAHospice_1_0_0.Instance.Hospice_Intervention_or_Encounter(context);
        bool? azzzzzzzzzzzp_ = this.Mastectomy_Exclusion(context);
        bool? azzzzzzzzzzzq_ = context.Operators.Or(azzzzzzzzzzzo_, azzzzzzzzzzzp_);
        bool? azzzzzzzzzzzr_ = NCQAAdvancedIllnessandFrailty_1_0_0.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? azzzzzzzzzzzs_ = context.Operators.Or(azzzzzzzzzzzq_, azzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzt_ = this.Measurement_Period(context);
        bool? azzzzzzzzzzzu_ = NCQAPalliativeCare_1_0_0.Instance.Palliative_Care_Overlapping_Period(context, azzzzzzzzzzzt_);
        bool? azzzzzzzzzzzv_ = context.Operators.Or(azzzzzzzzzzzs_, azzzzzzzzzzzu_);

        return azzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzw_ = this.Mammography(context);
        IEnumerable<Observation> azzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzzzzzzzzy_(Observation Mammogram)
        {
            DataType bzzzzzzzzzzzb_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bzzzzzzzzzzzb_);
            CqlDateTime bzzzzzzzzzzzd_ = context.Operators.End(bzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzze_ = this.Participation_Period(context);
            bool? bzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzd_, bzzzzzzzzzzze_, default);

            return bzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> azzzzzzzzzzzz_ = context.Operators.Where<Observation>(azzzzzzzzzzzx_, azzzzzzzzzzzy_);
        bool? bzzzzzzzzzzza_ = context.Operators.Exists<Observation>(azzzzzzzzzzzz_);

        return bzzzzzzzzzzza_;
    }


    #endregion Expressions

}
