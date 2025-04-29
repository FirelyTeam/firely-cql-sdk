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
[CqlLibrary("BreastCancerScreeningsFHIR", "0.0.009")]
public partial class BreastCancerScreeningsFHIR_0_0_009 : ILibrary, ISingleton<BreastCancerScreeningsFHIR_0_0_009>
{
    private BreastCancerScreeningsFHIR_0_0_009() {}

    public static BreastCancerScreeningsFHIR_0_0_009 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "BreastCancerScreeningsFHIR";
    public string Version => "0.0.009";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, PalliativeCareFHIR_0_6_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance, HospiceFHIR4_2_3_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Bilateral Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext _) => _Bilateral_Mastectomy;
    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlValueSetDefinition("History of bilateral mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", valueSetVersion: null)]
    public CqlValueSet History_of_bilateral_mastectomy(CqlContext _) => _History_of_bilateral_mastectomy;
    private static readonly CqlValueSet _History_of_bilateral_mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlValueSetDefinition("Left", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", valueSetVersion: null)]
    public CqlValueSet Left(CqlContext _) => _Left;
    private static readonly CqlValueSet _Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);

    [CqlValueSetDefinition("Mammography", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext _) => _Mammography;
    private static readonly CqlValueSet _Mammography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Right", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", valueSetVersion: null)]
    public CqlValueSet Right(CqlContext _) => _Right;
    private static readonly CqlValueSet _Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);

    [CqlValueSetDefinition("Status Post Left Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", valueSetVersion: null)]
    public CqlValueSet Status_Post_Left_Mastectomy(CqlContext _) => _Status_Post_Left_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Left_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlValueSetDefinition("Status Post Right Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", valueSetVersion: null)]
    public CqlValueSet Status_Post_Right_Mastectomy(CqlContext _) => _Status_Post_Right_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Right_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime uzzzzzzzzzzzzzx_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime uzzzzzzzzzzzzzy_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzz_ = context.Operators.Interval(uzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzy_, true, false);
        object vzzzzzzzzzzzzza_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", uzzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> vzzzzzzzzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> vzzzzzzzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzh_ = this.Online_Assessments(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet vzzzzzzzzzzzzzj_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzk_);
        bool? vzzzzzzzzzzzzzm_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> vzzzzzzzzzzzzzo_ = TelehealthEncounter?.StatusElement;
            string vzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzzq_ = context.Operators.Equal(vzzzzzzzzzzzzzp_, "finished");
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period vzzzzzzzzzzzzzs_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzzzzs_ as object);
            bool? vzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzt_, default);
            bool? vzzzzzzzzzzzzzv_ = context.Operators.And(vzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzu_);

            return vzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzm_);

        return vzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient vzzzzzzzzzzzzzw_ = this.Patient(context);
        Date vzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzw_?.BirthDateElement;
        string vzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzx_?.Value;
        CqlDate vzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzy_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzb_ = context.Operators.Start(wzzzzzzzzzzzzza_);
        CqlDate wzzzzzzzzzzzzzc_ = context.Operators.DateFrom(wzzzzzzzzzzzzzb_);
        int? wzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzc_, "year");

        return wzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient wzzzzzzzzzzzzze_ = this.Patient(context);
        Date wzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzze_?.BirthDateElement;
        string wzzzzzzzzzzzzzg_ = wzzzzzzzzzzzzzf_?.Value;
        CqlDate wzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzzzzj_ = context.Operators.Start(wzzzzzzzzzzzzzi_);
        CqlDate wzzzzzzzzzzzzzk_ = context.Operators.DateFrom(wzzzzzzzzzzzzzj_);
        int? wzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzk_, "year");
        CqlInterval<int?> wzzzzzzzzzzzzzm_ = context.Operators.Interval(51, 74, true, false);
        bool? wzzzzzzzzzzzzzn_ = context.Operators.In<int?>(wzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzm_, default);
        Code<AdministrativeGender> wzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzze_?.GenderElement;
        string wzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzzzzp_);
        bool? wzzzzzzzzzzzzzr_ = context.Operators.Equal(wzzzzzzzzzzzzzq_, "female");
        bool? wzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzt_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzu_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(wzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzu_);
        bool? wzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzx_ = context.Operators.And(wzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? wzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return wzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzz_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> xzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, wzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet xzzzzzzzzzzzzzb_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? xzzzzzzzzzzzzzd_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> xzzzzzzzzzzzzzi_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept xzzzzzzzzzzzzzj_(CodeableConcept X)
            {
                CqlConcept xzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return xzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> xzzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzj_);
            CqlValueSet xzzzzzzzzzzzzzl_ = this.Right(context);
            bool? xzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(xzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzl_);

            return xzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzd_);
        IEnumerable<Condition> xzzzzzzzzzzzzzf_ = context.Operators.Union<Condition>(xzzzzzzzzzzzzza_, xzzzzzzzzzzzzze_);
        bool? xzzzzzzzzzzzzzg_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime xzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzr_ = context.Operators.End(xzzzzzzzzzzzzzq_);
            bool? xzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzr_, default);

            return xzzzzzzzzzzzzzs_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzg_);

        return xzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzt_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> xzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? xzzzzzzzzzzzzzv_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> xzzzzzzzzzzzzzx_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string xzzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzzx_);
            bool? xzzzzzzzzzzzzzz_ = context.Operators.Equal(xzzzzzzzzzzzzzy_, "completed");
            DataType yzzzzzzzzzzzzza_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzzzza_);
            CqlDateTime yzzzzzzzzzzzzzc_ = context.Operators.End(yzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzze_ = context.Operators.End(yzzzzzzzzzzzzzd_);
            bool? yzzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzc_, yzzzzzzzzzzzzze_, default);
            bool? yzzzzzzzzzzzzzg_ = context.Operators.And(xzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzf_);

            return yzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> xzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(xzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzv_);

        return xzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzh_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet yzzzzzzzzzzzzzj_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> yzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? yzzzzzzzzzzzzzl_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> yzzzzzzzzzzzzzq_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept yzzzzzzzzzzzzzr_(CodeableConcept X)
            {
                CqlConcept yzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return yzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzr_);
            CqlValueSet yzzzzzzzzzzzzzt_ = this.Left(context);
            bool? yzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(yzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzt_);

            return yzzzzzzzzzzzzzu_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzl_);
        IEnumerable<Condition> yzzzzzzzzzzzzzn_ = context.Operators.Union<Condition>(yzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzm_);
        bool? yzzzzzzzzzzzzzo_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime yzzzzzzzzzzzzzx_ = context.Operators.Start(yzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzz_ = context.Operators.End(yzzzzzzzzzzzzzy_);
            bool? zzzzzzzzzzzzzza_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzz_, default);

            return zzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> yzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzb_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? zzzzzzzzzzzzzzd_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> zzzzzzzzzzzzzzf_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string zzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzzzf_);
            bool? zzzzzzzzzzzzzzh_ = context.Operators.Equal(zzzzzzzzzzzzzzg_, "completed");
            DataType zzzzzzzzzzzzzzi_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzzzzi_);
            CqlDateTime zzzzzzzzzzzzzzk_ = context.Operators.End(zzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzm_ = context.Operators.End(zzzzzzzzzzzzzzl_);
            bool? zzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzm_, default);
            bool? zzzzzzzzzzzzzzo_ = context.Operators.And(zzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzn_);

            return zzzzzzzzzzzzzzo_;
        };
        IEnumerable<Procedure> zzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzp_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> zzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? zzzzzzzzzzzzzzr_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime zzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzzzzw_ = context.Operators.End(zzzzzzzzzzzzzzv_);
            bool? zzzzzzzzzzzzzzx_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzw_, default);

            return zzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> zzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(zzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzr_);

        return zzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzy_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> zzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? azzzzzzzzzzzzzza_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> azzzzzzzzzzzzzzc_ = BilateralMastectomyPerformed?.StatusElement;
            string azzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzzzc_);
            bool? azzzzzzzzzzzzzze_ = context.Operators.Equal(azzzzzzzzzzzzzzd_, "completed");
            DataType azzzzzzzzzzzzzzf_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzzzzf_);
            CqlDateTime azzzzzzzzzzzzzzh_ = context.Operators.End(azzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzzzj_ = context.Operators.End(azzzzzzzzzzzzzzi_);
            bool? azzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(azzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzj_, default);
            bool? azzzzzzzzzzzzzzl_ = context.Operators.And(azzzzzzzzzzzzzze_, azzzzzzzzzzzzzzk_);

            return azzzzzzzzzzzzzzl_;
        };
        IEnumerable<Procedure> azzzzzzzzzzzzzzb_ = context.Operators.Where<Procedure>(zzzzzzzzzzzzzzz_, azzzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzm_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzn_ = this.Right_Mastectomy_Diagnosis(context);
        bool? azzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzn_);
        IEnumerable<Procedure> azzzzzzzzzzzzzzp_ = this.Right_Mastectomy_Procedure(context);
        bool? azzzzzzzzzzzzzzq_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzp_);
        bool? azzzzzzzzzzzzzzr_ = context.Operators.Or(azzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzq_);
        IEnumerable<Condition> azzzzzzzzzzzzzzs_ = this.Left_Mastectomy_Diagnosis(context);
        bool? azzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzs_);
        IEnumerable<Procedure> azzzzzzzzzzzzzzu_ = this.Left_Mastectomy_Procedure(context);
        bool? azzzzzzzzzzzzzzv_ = context.Operators.Exists<Procedure>(azzzzzzzzzzzzzzu_);
        bool? azzzzzzzzzzzzzzw_ = context.Operators.Or(azzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzx_ = context.Operators.And(azzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzw_);
        bool? azzzzzzzzzzzzzzy_ = context.Operators.Or(azzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzx_);
        IEnumerable<Condition> azzzzzzzzzzzzzzz_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? bzzzzzzzzzzzzzza_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzzzzb_ = context.Operators.Or(azzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzza_);
        IEnumerable<Procedure> bzzzzzzzzzzzzzzc_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? bzzzzzzzzzzzzzzd_ = context.Operators.Exists<Procedure>(bzzzzzzzzzzzzzzc_);
        bool? bzzzzzzzzzzzzzze_ = context.Operators.Or(bzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzd_);
        bool? bzzzzzzzzzzzzzzf_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? bzzzzzzzzzzzzzzg_ = context.Operators.Or(bzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzf_);
        Patient bzzzzzzzzzzzzzzh_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzh_?.BirthDateElement;
        string bzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzi_?.Value;
        CqlDate bzzzzzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzj_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzm_ = context.Operators.Start(bzzzzzzzzzzzzzzl_);
        CqlDate bzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzm_);
        int? bzzzzzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzn_, "year");
        bool? bzzzzzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(bzzzzzzzzzzzzzzo_, 65);
        bool? bzzzzzzzzzzzzzzq_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? bzzzzzzzzzzzzzzr_ = context.Operators.And(bzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzq_);
        bool? bzzzzzzzzzzzzzzs_ = context.Operators.Or(bzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzt_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzu_ = context.Operators.Or(bzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzv_ = this.Mammography(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? bzzzzzzzzzzzzzzx_(Observation Mammogram)
        {
            Code<ObservationStatus> czzzzzzzzzzzzzza_ = Mammogram?.StatusElement;
            string czzzzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzza_);
            string[] czzzzzzzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? czzzzzzzzzzzzzzd_ = context.Operators.In<string>(czzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzc_ as IEnumerable<string>);
            DataType czzzzzzzzzzzzzze_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzzzzzze_);
            CqlDateTime czzzzzzzzzzzzzzg_ = context.Operators.End(czzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzi_ = context.Operators.End(czzzzzzzzzzzzzzh_);
            CqlQuantity czzzzzzzzzzzzzzj_ = context.Operators.Quantity(27m, "months");
            CqlDateTime czzzzzzzzzzzzzzk_ = context.Operators.Subtract(czzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzj_);
            CqlDateTime czzzzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzn_ = context.Operators.Interval(czzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzm_, true, true);
            bool? czzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzn_, default);
            CqlDateTime czzzzzzzzzzzzzzq_ = context.Operators.End(czzzzzzzzzzzzzzh_);
            bool? czzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzq_ is null));
            bool? czzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzs_);

            return czzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzzz_ = context.Operators.Exists<Observation>(bzzzzzzzzzzzzzzy_);

        return bzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzu_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> czzzzzzzzzzzzzzv_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, czzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? czzzzzzzzzzzzzzw_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> czzzzzzzzzzzzzzz_ = Mammogram?.StatusElement;
            string dzzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzzzz_);
            string[] dzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? dzzzzzzzzzzzzzzc_ = context.Operators.In<string>(dzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            DataType dzzzzzzzzzzzzzzd_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzzzzzzzzd_);
            CqlDateTime dzzzzzzzzzzzzzzf_ = context.Operators.End(dzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzh_ = context.Operators.End(dzzzzzzzzzzzzzzg_);
            CqlQuantity dzzzzzzzzzzzzzzi_ = context.Operators.Quantity(27m, "months");
            CqlDateTime dzzzzzzzzzzzzzzj_ = context.Operators.Subtract(dzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzi_);
            CqlDateTime dzzzzzzzzzzzzzzl_ = context.Operators.End(dzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzm_ = context.Operators.Interval(dzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzl_, true, true);
            bool? dzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzm_, default);
            CqlDateTime dzzzzzzzzzzzzzzp_ = context.Operators.End(dzzzzzzzzzzzzzzg_);
            bool? dzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzp_ is null));
            bool? dzzzzzzzzzzzzzzr_ = context.Operators.And(dzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzq_);
            bool? dzzzzzzzzzzzzzzs_ = context.Operators.And(dzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzr_);

            return dzzzzzzzzzzzzzzs_;
        };
        IEnumerable<DiagnosticReport> czzzzzzzzzzzzzzx_ = context.Operators.Where<DiagnosticReport>(czzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzw_);
        bool? czzzzzzzzzzzzzzy_ = context.Operators.Exists<DiagnosticReport>(czzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzt_ = this.Observation_with_status(context);
        bool? dzzzzzzzzzzzzzzu_ = this.Diagnostic_Report_with_status(context);
        bool? dzzzzzzzzzzzzzzv_ = context.Operators.Or(dzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzu_);

        return dzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzw_ = this.Numerator(context);
        bool? dzzzzzzzzzzzzzzx_ = this.Initial_Population(context);
        bool? dzzzzzzzzzzzzzzy_ = context.Operators.And(dzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzx_);
        bool? dzzzzzzzzzzzzzzz_ = this.Denominator(context);
        bool? ezzzzzzzzzzzzzza_ = context.Operators.And(dzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzz_);
        bool? ezzzzzzzzzzzzzzb_ = this.Denominator_Exclusions(context);
        bool? ezzzzzzzzzzzzzzc_ = context.Operators.Not(ezzzzzzzzzzzzzzb_);
        bool? ezzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzze_ = this.Mammography(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ezzzzzzzzzzzzzzg_(Observation Mammogram)
        {
            Code<ObservationStatus> ezzzzzzzzzzzzzzj_ = Mammogram?.StatusElement;
            string ezzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzzj_);
            string[] ezzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ezzzzzzzzzzzzzzm_ = context.Operators.In<string>(ezzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? ezzzzzzzzzzzzzzn_ = context.Operators.Not(ezzzzzzzzzzzzzzm_);
            DataType ezzzzzzzzzzzzzzo_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzzzzzzo_);
            CqlDateTime ezzzzzzzzzzzzzzq_ = context.Operators.End(ezzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzs_ = context.Operators.End(ezzzzzzzzzzzzzzr_);
            CqlQuantity ezzzzzzzzzzzzzzt_ = context.Operators.Quantity(27m, "months");
            CqlDateTime ezzzzzzzzzzzzzzu_ = context.Operators.Subtract(ezzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzt_);
            CqlDateTime ezzzzzzzzzzzzzzw_ = context.Operators.End(ezzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzx_ = context.Operators.Interval(ezzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzw_, true, true);
            bool? ezzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzx_, default);
            CqlDateTime fzzzzzzzzzzzzzza_ = context.Operators.End(ezzzzzzzzzzzzzzr_);
            bool? fzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzza_ is null));
            bool? fzzzzzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzb_);
            bool? fzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzg_);
        bool? ezzzzzzzzzzzzzzi_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzh_);

        return ezzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzze_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> fzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, fzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? fzzzzzzzzzzzzzzg_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> fzzzzzzzzzzzzzzj_ = Mammogram?.StatusElement;
            string fzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzzzzzzzj_);
            string[] fzzzzzzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? fzzzzzzzzzzzzzzm_ = context.Operators.In<string>(fzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzl_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzn_ = context.Operators.Not(fzzzzzzzzzzzzzzm_);
            DataType fzzzzzzzzzzzzzzo_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzzzzzzzzo_);
            CqlDateTime fzzzzzzzzzzzzzzq_ = context.Operators.End(fzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzs_ = context.Operators.End(fzzzzzzzzzzzzzzr_);
            CqlQuantity fzzzzzzzzzzzzzzt_ = context.Operators.Quantity(27m, "months");
            CqlDateTime fzzzzzzzzzzzzzzu_ = context.Operators.Subtract(fzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzt_);
            CqlDateTime fzzzzzzzzzzzzzzw_ = context.Operators.End(fzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzx_ = context.Operators.Interval(fzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzw_, true, true);
            bool? fzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzx_, default);
            CqlDateTime gzzzzzzzzzzzzzza_ = context.Operators.End(fzzzzzzzzzzzzzzr_);
            bool? gzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzza_ is null));
            bool? gzzzzzzzzzzzzzzc_ = context.Operators.And(fzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzb_);
            bool? gzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzc_);

            return gzzzzzzzzzzzzzzd_;
        };
        IEnumerable<DiagnosticReport> fzzzzzzzzzzzzzzh_ = context.Operators.Where<DiagnosticReport>(fzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzg_);
        bool? fzzzzzzzzzzzzzzi_ = context.Operators.Exists<DiagnosticReport>(fzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
