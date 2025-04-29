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
[CqlLibrary("BreastCancerScreeningFHIR", "0.0.001")]
public partial class BreastCancerScreeningFHIR_0_0_001 : ILibrary, ISingleton<BreastCancerScreeningFHIR_0_0_001>
{
    private BreastCancerScreeningFHIR_0_0_001() {}

    public static BreastCancerScreeningFHIR_0_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "BreastCancerScreeningFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, AdultOutpatientEncounters_4_11_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance, PalliativeCare_1_11_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Bilateral Mastectomy
    [CqlValueSetDefinition(
        definitionName: "Bilateral Mastectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005",
        valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext context) => _Bilateral_Mastectomy;

    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);
    #endregion

    #region ValueSet: History of bilateral mastectomy
    [CqlValueSetDefinition(
        definitionName: "History of bilateral mastectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068",
        valueSetVersion: null)]
    public CqlValueSet History_of_bilateral_mastectomy(CqlContext context) => _History_of_bilateral_mastectomy;

    private static readonly CqlValueSet _History_of_bilateral_mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);
    #endregion

    #region ValueSet: Mammography
    [CqlValueSetDefinition(
        definitionName: "Mammography",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1018",
        valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext context) => _Mammography;

    private static readonly CqlValueSet _Mammography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1018", null);
    #endregion

    #region ValueSet: Status Post Left Mastectomy
    [CqlValueSetDefinition(
        definitionName: "Status Post Left Mastectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069",
        valueSetVersion: null)]
    public CqlValueSet Status_Post_Left_Mastectomy(CqlContext context) => _Status_Post_Left_Mastectomy;

    private static readonly CqlValueSet _Status_Post_Left_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);
    #endregion

    #region ValueSet: Status Post Right Mastectomy
    [CqlValueSetDefinition(
        definitionName: "Status Post Right Mastectomy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070",
        valueSetVersion: null)]
    public CqlValueSet Status_Post_Right_Mastectomy(CqlContext context) => _Status_Post_Right_Mastectomy;

    private static readonly CqlValueSet _Status_Post_Right_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);
    #endregion

    #region ValueSet: Unilateral Mastectomy Left
    [CqlValueSetDefinition(
        definitionName: "Unilateral Mastectomy Left",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext context) => _Unilateral_Mastectomy_Left;

    private static readonly CqlValueSet _Unilateral_Mastectomy_Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);
    #endregion

    #region ValueSet: Unilateral Mastectomy Right
    [CqlValueSetDefinition(
        definitionName: "Unilateral Mastectomy Right",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext context) => _Unilateral_Mastectomy_Right;

    private static readonly CqlValueSet _Unilateral_Mastectomy_Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);
    #endregion

    #region ValueSet: Unilateral Mastectomy, Unspecified Laterality
    [CqlValueSetDefinition(
        definitionName: "Unilateral Mastectomy, Unspecified Laterality",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071",
        valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality(CqlContext context) => _Unilateral_Mastectomy__Unspecified_Laterality;

    private static readonly CqlValueSet _Unilateral_Mastectomy__Unspecified_Laterality = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Female
    [CqlCodeDefinition(
        definitionName: "Female",
        codeId: "F",
        codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext context) => _Female;

    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);
    #endregion

    #region Code: Left (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Left (qualifier value)",
        codeId: "7771000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext context) => _Left__qualifier_value_;

    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Right (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Right (qualifier value)",
        codeId: "24028007",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext context) => _Right__qualifier_value_;

    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "AdministrativeGender")]
    public CqlCode[] AdministrativeGender(CqlContext context)
    {
        CqlCode[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
            new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
        ];

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
            new CqlCode("7771000", "http://snomed.info/sct", default, default),
            new CqlCode("24028007", "http://snomed.info/sct", default, default),
        ];

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = []
;

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
        object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.ResolveParameter("BreastCancerScreeningFHIR-0.0.001", "Measurement Period", vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
        Date wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
        string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "year");
        CqlInterval<int?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(52, 74, true, true);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<int?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
        Code<AdministrativeGender> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.GenderElement;
        AdministrativeGender? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "female");
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Initial_Population(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CodeableConcept @this)
            {
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(CqlConcept S)
            {
                CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Right__qualifier_value_(context);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(S, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<CqlConcept>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<CqlConcept>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RightMastectomy);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isProcedurePerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure UnilateralMastectomyRightPerformed)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = UnilateralMastectomyRightPerformed?.Performed;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlConcept S)
            {
                CqlCode yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Left__qualifier_value_(context);
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(S, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlConcept>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CqlConcept>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LeftMastectomy);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure UnilateralMastectomyLeftPerformed)
        {
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = UnilateralMastectomyLeftPerformed?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BilateralMastectomyHistory);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isProcedurePerformed(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure BilateralMastectomyPerformed)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = BilateralMastectomyPerformed?.Performed;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Right_Mastectomy_Diagnosis(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Right_Mastectomy_Procedure(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Left_Mastectomy_Diagnosis(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Left_Mastectomy_Procedure(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "year");
        int? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, 2);
        decimal? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, 10, 1, 0, 0, 0, 0, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Mammography(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation Mammogram)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Mammogram?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

}
