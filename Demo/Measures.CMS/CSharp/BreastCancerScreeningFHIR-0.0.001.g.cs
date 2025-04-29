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

    [CqlValueSetDefinition("Bilateral Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext _) => _Bilateral_Mastectomy;
    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlValueSetDefinition("History of bilateral mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", valueSetVersion: null)]
    public CqlValueSet History_of_bilateral_mastectomy(CqlContext _) => _History_of_bilateral_mastectomy;
    private static readonly CqlValueSet _History_of_bilateral_mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlValueSetDefinition("Mammography", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1018", valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext _) => _Mammography;
    private static readonly CqlValueSet _Mammography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1018", null);

    [CqlValueSetDefinition("Status Post Left Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", valueSetVersion: null)]
    public CqlValueSet Status_Post_Left_Mastectomy(CqlContext _) => _Status_Post_Left_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Left_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlValueSetDefinition("Status Post Right Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", valueSetVersion: null)]
    public CqlValueSet Status_Post_Right_Mastectomy(CqlContext _) => _Status_Post_Right_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Right_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Left", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext _) => _Unilateral_Mastectomy_Left;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Right", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext _) => _Unilateral_Mastectomy_Right;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlValueSetDefinition("Unilateral Mastectomy, Unspecified Laterality", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality(CqlContext _) => _Unilateral_Mastectomy__Unspecified_Laterality;
    private static readonly CqlValueSet _Unilateral_Mastectomy__Unspecified_Laterality = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Female", codeId: "F", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender")]
    public CqlCode Female(CqlContext _) => _Female;
    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);

    [CqlCodeDefinition("Left (qualifier value)", codeId: "7771000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext _) => _Left__qualifier_value_;
    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Right (qualifier value)", codeId: "24028007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext _) => _Right__qualifier_value_;
    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime jzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime jzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzs_, true, true);
        object jzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("BreastCancerScreeningFHIR-0.0.001", "Measurement Period", jzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzzzzzzzzv_);

        return jzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient jzzzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date jzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzx_?.BirthDateElement;
        string jzzzzzzzzzzzzzzzzz_ = jzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate kzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzzzzzzzzzzzzc_ = context.Operators.End(kzzzzzzzzzzzzzzzzb_);
        CqlDate kzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzc_);
        int? kzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(kzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzd_, "year");
        CqlInterval<int?> kzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(52, 74, true, true);
        bool? kzzzzzzzzzzzzzzzzg_ = context.Operators.In<int?>(kzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzf_, default);
        Code<AdministrativeGender> kzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzx_?.GenderElement;
        AdministrativeGender? kzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzi_?.Value;
        string kzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzk_, "female");
        bool? kzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzn_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? kzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzzzn_);
        bool? kzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzo_);

        return kzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzr_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet kzzzzzzzzzzzzzzzzt_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzzzzzzzzzzzv_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> lzzzzzzzzzzzzzzzza_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept lzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept lzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return lzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzb_);
            bool? lzzzzzzzzzzzzzzzzd_(CqlConcept S)
            {
                CqlCode lzzzzzzzzzzzzzzzzh_ = this.Right__qualifier_value_(context);
                CqlConcept lzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzh_);
                bool? lzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(S, lzzzzzzzzzzzzzzzzi_);

                return lzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzze_ = context.Operators.Where<CqlConcept>(lzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlConcept>(lzzzzzzzzzzzzzzzze_);

            return lzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(kzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzw_);
        bool? kzzzzzzzzzzzzzzzzy_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RightMastectomy);
            CqlDateTime lzzzzzzzzzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzn_, default);

            return lzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzy_);

        return kzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzp_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, lzzzzzzzzzzzzzzzzq_);
        bool? lzzzzzzzzzzzzzzzzs_(Procedure UnilateralMastectomyRightPerformed)
        {
            DataType lzzzzzzzzzzzzzzzzu_ = UnilateralMastectomyRightPerformed?.Performed;
            object lzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzv_);
            CqlDateTime lzzzzzzzzzzzzzzzzx_ = context.Operators.End(lzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzz_ = context.Operators.End(lzzzzzzzzzzzzzzzzy_);
            bool? mzzzzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzz_, default);

            return mzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzs_);

        return lzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzb_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet mzzzzzzzzzzzzzzzzd_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzzzzzzzzf_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> mzzzzzzzzzzzzzzzzk_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept mzzzzzzzzzzzzzzzzl_(CodeableConcept @this)
            {
                CqlConcept mzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return mzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzl_);
            bool? mzzzzzzzzzzzzzzzzn_(CqlConcept S)
            {
                CqlCode mzzzzzzzzzzzzzzzzr_ = this.Left__qualifier_value_(context);
                CqlConcept mzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzzzzr_);
                bool? mzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(S, mzzzzzzzzzzzzzzzzs_);

                return mzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzzzo_ = context.Operators.Where<CqlConcept>(mzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<CqlConcept>(mzzzzzzzzzzzzzzzzo_);

            return mzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Condition>(mzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzzzzzzi_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LeftMastectomy);
            CqlDateTime mzzzzzzzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzx_ = context.Operators.End(mzzzzzzzzzzzzzzzzw_);
            bool? mzzzzzzzzzzzzzzzzy_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzx_, default);

            return mzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzi_);

        return mzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzz_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzza_);
        bool? nzzzzzzzzzzzzzzzzc_(Procedure UnilateralMastectomyLeftPerformed)
        {
            DataType nzzzzzzzzzzzzzzzze_ = UnilateralMastectomyLeftPerformed?.Performed;
            object nzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzf_);
            CqlDateTime nzzzzzzzzzzzzzzzzh_ = context.Operators.End(nzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzj_ = context.Operators.End(nzzzzzzzzzzzzzzzzi_);
            bool? nzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzj_, default);

            return nzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzc_);

        return nzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzl_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzzzzzzn_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BilateralMastectomyHistory);
            CqlDateTime nzzzzzzzzzzzzzzzzq_ = context.Operators.Start(nzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzs_ = context.Operators.End(nzzzzzzzzzzzzzzzzr_);
            bool? nzzzzzzzzzzzzzzzzt_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzs_, default);

            return nzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzn_);

        return nzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzu_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isProcedurePerformed(context, nzzzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzzzx_(Procedure BilateralMastectomyPerformed)
        {
            DataType nzzzzzzzzzzzzzzzzz_ = BilateralMastectomyPerformed?.Performed;
            object ozzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzza_);
            CqlDateTime ozzzzzzzzzzzzzzzzc_ = context.Operators.End(ozzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzzzzzze_ = context.Operators.End(ozzzzzzzzzzzzzzzzd_);
            bool? ozzzzzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(ozzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzze_, default);

            return ozzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzx_);

        return nzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzg_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzh_ = this.Right_Mastectomy_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzh_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzj_ = this.Right_Mastectomy_Procedure(context);
        bool? ozzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzzzj_);
        bool? ozzzzzzzzzzzzzzzzl_ = context.Operators.Or(ozzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzk_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzm_ = this.Left_Mastectomy_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzm_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzo_ = this.Left_Mastectomy_Procedure(context);
        bool? ozzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzzzq_ = context.Operators.Or(ozzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzq_);
        bool? ozzzzzzzzzzzzzzzzs_ = context.Operators.Or(ozzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzr_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzzzt_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzzzzzv_ = context.Operators.Or(ozzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzu_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzzzw_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? ozzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzzzw_);
        bool? ozzzzzzzzzzzzzzzzy_ = context.Operators.Or(ozzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzx_);
        bool? ozzzzzzzzzzzzzzzzz_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? pzzzzzzzzzzzzzzzza_ = context.Operators.Or(ozzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzz_);
        bool? pzzzzzzzzzzzzzzzzb_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? pzzzzzzzzzzzzzzzzc_ = context.Operators.Or(pzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzb_);
        bool? pzzzzzzzzzzzzzzzzd_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzzze_ = context.Operators.Or(pzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzd_);

        return pzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzzzg_ = context.Operators.Start(pzzzzzzzzzzzzzzzzf_);
        int? pzzzzzzzzzzzzzzzzh_ = context.Operators.DateTimeComponentFrom(pzzzzzzzzzzzzzzzzg_, "year");
        int? pzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzh_, 2);
        decimal? pzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime pzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(pzzzzzzzzzzzzzzzzi_, 10, 1, 0, 0, 0, 0, pzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzl_ = this.Mammography(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, pzzzzzzzzzzzzzzzzm_);
        bool? pzzzzzzzzzzzzzzzzo_(Observation Mammogram)
        {
            DataType pzzzzzzzzzzzzzzzzr_ = Mammogram?.Effective;
            object pzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzs_);
            CqlDateTime pzzzzzzzzzzzzzzzzu_ = context.Operators.End(pzzzzzzzzzzzzzzzzt_);
            CqlDateTime pzzzzzzzzzzzzzzzzv_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzzzx_ = context.Operators.End(pzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzx_, true, true);
            bool? pzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzy_, "day");

            return pzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzo_);
        bool? pzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzzzzp_);

        return pzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzzzzd_;
    }


    #endregion Expressions

}
