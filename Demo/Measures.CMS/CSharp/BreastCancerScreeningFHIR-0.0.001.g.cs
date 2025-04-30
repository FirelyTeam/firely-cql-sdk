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
    private static readonly CqlCode _Female = new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender");

    [CqlCodeDefinition("Left (qualifier value)", codeId: "7771000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Left__qualifier_value_(CqlContext _) => _Left__qualifier_value_;
    private static readonly CqlCode _Left__qualifier_value_ = new CqlCode("7771000", "http://snomed.info/sct");

    [CqlCodeDefinition("Right (qualifier value)", codeId: "24028007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Right__qualifier_value_(CqlContext _) => _Right__qualifier_value_;
    private static readonly CqlCode _Right__qualifier_value_ = new CqlCode("24028007", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("AdministrativeGender")]
    public CqlCodeSystem AdministrativeGender(CqlContext _) => _AdministrativeGender;
    private static readonly CqlCodeSystem _AdministrativeGender =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, [
          _Female]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Left__qualifier_value_,
          _Right__qualifier_value_]);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzk_, true, true);
        object wzzzzzzzzzzzzzzzzm_ = context.ResolveParameter("BreastCancerScreeningFHIR-0.0.001", "Measurement Period", wzzzzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzzn_);

        return wzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date wzzzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string wzzzzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzzzzq_?.Value;
        CqlDate wzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzzu_ = context.Operators.End(wzzzzzzzzzzzzzzzzt_);
        CqlDate wzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzu_);
        int? wzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzv_, "year");
        CqlInterval<int?> wzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(52, 74, true, true);
        bool? wzzzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(wzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzx_, default);
        Code<AdministrativeGender> xzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzp_?.GenderElement;
        AdministrativeGender? xzzzzzzzzzzzzzzzzb_ = xzzzzzzzzzzzzzzzza_?.Value;
        string xzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzb_);
        bool? xzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzc_, "female");
        bool? xzzzzzzzzzzzzzzzze_ = context.Operators.And(wzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzf_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? xzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzzzzzzf_);
        bool? xzzzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzg_);

        return xzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? xzzzzzzzzzzzzzzzzi_ = this.Initial_Population(context);

        return xzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzj_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet xzzzzzzzzzzzzzzzzl_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? xzzzzzzzzzzzzzzzzn_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> xzzzzzzzzzzzzzzzzs_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept xzzzzzzzzzzzzzzzzt_(CodeableConcept @this)
            {
                CqlConcept xzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return xzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzt_);
            bool? xzzzzzzzzzzzzzzzzv_(CqlConcept S)
            {
                CqlCode xzzzzzzzzzzzzzzzzz_ = this.Right__qualifier_value_(context);
                CqlConcept yzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzzzzzzzzz_);
                bool? yzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(S, yzzzzzzzzzzzzzzzza_);

                return yzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlConcept>(xzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzv_);
            bool? xzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CqlConcept>(xzzzzzzzzzzzzzzzzw_);

            return xzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzn_);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzo_);
        bool? xzzzzzzzzzzzzzzzzq_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RightMastectomy);
            CqlDateTime yzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzf_ = context.Operators.End(yzzzzzzzzzzzzzzzze_);
            bool? yzzzzzzzzzzzzzzzzg_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzf_, default);

            return yzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzq_);

        return xzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzh_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isProcedurePerformed(context, yzzzzzzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzzzzzzk_(Procedure UnilateralMastectomyRightPerformed)
        {
            DataType yzzzzzzzzzzzzzzzzm_ = UnilateralMastectomyRightPerformed?.Performed;
            object yzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzn_);
            CqlDateTime yzzzzzzzzzzzzzzzzp_ = context.Operators.End(yzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzr_ = context.Operators.End(yzzzzzzzzzzzzzzzzq_);
            bool? yzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzr_, default);

            return yzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(yzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzt_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet yzzzzzzzzzzzzzzzzv_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzzzzzzzzx_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> zzzzzzzzzzzzzzzzzc_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept zzzzzzzzzzzzzzzzzd_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzd_);
            bool? zzzzzzzzzzzzzzzzzf_(CqlConcept S)
            {
                CqlCode zzzzzzzzzzzzzzzzzj_ = this.Left__qualifier_value_(context);
                CqlConcept zzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzj_);
                bool? zzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(S, zzzzzzzzzzzzzzzzzk_);

                return zzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlConcept>(zzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzf_);
            bool? zzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlConcept>(zzzzzzzzzzzzzzzzzg_);

            return zzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzx_);
        IEnumerable<Condition> yzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzy_);
        bool? zzzzzzzzzzzzzzzzza_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LeftMastectomy);
            CqlDateTime zzzzzzzzzzzzzzzzzn_ = context.Operators.Start(zzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzzzzp_ = context.Operators.End(zzzzzzzzzzzzzzzzzo_);
            bool? zzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzp_, default);

            return zzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzza_);

        return zzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzr_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isProcedurePerformed(context, zzzzzzzzzzzzzzzzzs_);
        bool? zzzzzzzzzzzzzzzzzu_(Procedure UnilateralMastectomyLeftPerformed)
        {
            DataType zzzzzzzzzzzzzzzzzw_ = UnilateralMastectomyLeftPerformed?.Performed;
            object zzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzx_);
            CqlDateTime zzzzzzzzzzzzzzzzzz_ = context.Operators.End(zzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzb_ = context.Operators.End(azzzzzzzzzzzzzzzzza_);
            bool? azzzzzzzzzzzzzzzzzc_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzb_, default);

            return azzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzd_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzf_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BilateralMastectomyHistory);
            CqlDateTime azzzzzzzzzzzzzzzzzi_ = context.Operators.Start(azzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzk_ = context.Operators.End(azzzzzzzzzzzzzzzzzj_);
            bool? azzzzzzzzzzzzzzzzzl_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzk_, default);

            return azzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzf_);

        return azzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzm_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isProcedurePerformed(context, azzzzzzzzzzzzzzzzzn_);
        bool? azzzzzzzzzzzzzzzzzp_(Procedure BilateralMastectomyPerformed)
        {
            DataType azzzzzzzzzzzzzzzzzr_ = BilateralMastectomyPerformed?.Performed;
            object azzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzs_);
            CqlDateTime azzzzzzzzzzzzzzzzzu_ = context.Operators.End(azzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzzzzw_ = context.Operators.End(azzzzzzzzzzzzzzzzzv_);
            bool? azzzzzzzzzzzzzzzzzx_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzw_, default);

            return azzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(azzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzp_);

        return azzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzy_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzz_ = this.Right_Mastectomy_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzz_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzb_ = this.Right_Mastectomy_Procedure(context);
        bool? bzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzb_);
        bool? bzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(bzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzze_ = this.Left_Mastectomy_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzze_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzg_ = this.Left_Mastectomy_Procedure(context);
        bool? bzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzg_);
        bool? bzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzh_);
        bool? bzzzzzzzzzzzzzzzzzj_ = context.Operators.And(bzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(azzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzzzl_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? bzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzl_);
        bool? bzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzzzzo_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? bzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzzzzo_);
        bool? bzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzp_);
        bool? bzzzzzzzzzzzzzzzzzr_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? bzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzzzzt_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? bzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzt_);
        bool? bzzzzzzzzzzzzzzzzzv_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(bzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzv_);

        return bzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzx_);
        int? bzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzzzzzzzzy_, "year");
        int? czzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzz_, 2);
        decimal? czzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime czzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(czzzzzzzzzzzzzzzzza_, 10, 1, 0, 0, 0, 0, czzzzzzzzzzzzzzzzzb_);

        return czzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzd_ = this.Mammography(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, czzzzzzzzzzzzzzzzze_);
        bool? czzzzzzzzzzzzzzzzzg_(Observation Mammogram)
        {
            DataType czzzzzzzzzzzzzzzzzj_ = Mammogram?.Effective;
            object czzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzk_);
            CqlDateTime czzzzzzzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzzzzzzl_);
            CqlDateTime czzzzzzzzzzzzzzzzzn_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzzzp_ = context.Operators.End(czzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzp_, true, true);
            bool? czzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzq_, "day");

            return czzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzg_);
        bool? czzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
