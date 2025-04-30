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
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.ResolveParameter("BreastCancerScreeningFHIR-0.0.001", "Measurement Period", rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(52, 74, true, true);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<int?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
        Code<AdministrativeGender> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.GenderElement;
        AdministrativeGender? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        string szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "female");
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = AdultOutpatientEncounters_4_11_000.Instance.Qualifying_Encounters(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlConcept S)
            {
                CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Right__qualifier_value_(context);
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(S, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlConcept>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CqlConcept>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, RightMastectomy);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isProcedurePerformed(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure UnilateralMastectomyRightPerformed)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = UnilateralMastectomyRightPerformed?.Performed;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameOrBefore(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Procedure>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)uzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CqlConcept S)
            {
                CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Left__qualifier_value_(context);
                CqlConcept uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(S, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<CqlConcept>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlConcept>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LeftMastectomy);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Condition> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Condition>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure UnilateralMastectomyLeftPerformed)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = UnilateralMastectomyLeftPerformed?.Performed;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, BilateralMastectomyHistory);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isProcedurePerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Procedure BilateralMastectomyPerformed)
        {
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BilateralMastectomyPerformed?.Performed;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Right_Mastectomy_Diagnosis(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Procedure> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Right_Mastectomy_Procedure(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Left_Mastectomy_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Left_Mastectomy_Procedure(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Procedure> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Procedure>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("October 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime October_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
        int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, 2);
        decimal? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, 10, 1, 0, 0, 0, 0, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Mammography(context);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isDiagnosticStudyPerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation Mammogram)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Mammogram?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.October_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    #endregion Expressions

}
