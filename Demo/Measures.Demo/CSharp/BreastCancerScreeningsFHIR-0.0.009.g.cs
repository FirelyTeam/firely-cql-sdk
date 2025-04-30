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
        CqlDateTime kzzzzzzzzzx_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime kzzzzzzzzzy_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> kzzzzzzzzzz_ = context.Operators.Interval(kzzzzzzzzzx_, kzzzzzzzzzy_, true, false);
        object lzzzzzzzzza_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", kzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)lzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> lzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient lzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(lzzzzzzzzzb_);

        return lzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return lzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> lzzzzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return lzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> lzzzzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return lzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return lzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzh_ = this.Online_Assessments(context);
        IEnumerable<Encounter> lzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet lzzzzzzzzzj_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> lzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, lzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> lzzzzzzzzzl_ = context.Operators.Union<Encounter>(lzzzzzzzzzi_, lzzzzzzzzzk_);
        bool? lzzzzzzzzzm_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> lzzzzzzzzzo_ = TelehealthEncounter?.StatusElement;
            string lzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzo_);
            bool? lzzzzzzzzzq_ = context.Operators.Equal(lzzzzzzzzzp_, "finished");
            CqlInterval<CqlDateTime> lzzzzzzzzzr_ = this.Measurement_Period(context);
            Period lzzzzzzzzzs_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzs_ as object);
            bool? lzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzr_, lzzzzzzzzzt_, default);
            bool? lzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzq_, lzzzzzzzzzu_);

            return lzzzzzzzzzv_;
        };
        IEnumerable<Encounter> lzzzzzzzzzn_ = context.Operators.Where<Encounter>(lzzzzzzzzzl_, lzzzzzzzzzm_);

        return lzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient lzzzzzzzzzw_ = this.Patient(context);
        Date lzzzzzzzzzx_ = lzzzzzzzzzw_?.BirthDateElement;
        string lzzzzzzzzzy_ = lzzzzzzzzzx_?.Value;
        CqlDate lzzzzzzzzzz_ = context.Operators.ConvertStringToDate(lzzzzzzzzzy_);
        CqlInterval<CqlDateTime> mzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime mzzzzzzzzzb_ = context.Operators.Start(mzzzzzzzzza_);
        CqlDate mzzzzzzzzzc_ = context.Operators.DateFrom(mzzzzzzzzzb_);
        int? mzzzzzzzzzd_ = context.Operators.CalculateAgeAt(lzzzzzzzzzz_, mzzzzzzzzzc_, "year");

        return mzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient mzzzzzzzzze_ = this.Patient(context);
        Date mzzzzzzzzzf_ = mzzzzzzzzze_?.BirthDateElement;
        string mzzzzzzzzzg_ = mzzzzzzzzzf_?.Value;
        CqlDate mzzzzzzzzzh_ = context.Operators.ConvertStringToDate(mzzzzzzzzzg_);
        CqlInterval<CqlDateTime> mzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime mzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzi_);
        CqlDate mzzzzzzzzzk_ = context.Operators.DateFrom(mzzzzzzzzzj_);
        int? mzzzzzzzzzl_ = context.Operators.CalculateAgeAt(mzzzzzzzzzh_, mzzzzzzzzzk_, "year");
        CqlInterval<int?> mzzzzzzzzzm_ = context.Operators.Interval(51, 74, true, false);
        bool? mzzzzzzzzzn_ = context.Operators.In<int?>(mzzzzzzzzzl_, mzzzzzzzzzm_, default);
        Code<AdministrativeGender> mzzzzzzzzzp_ = mzzzzzzzzze_?.GenderElement;
        string mzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzp_);
        bool? mzzzzzzzzzr_ = context.Operators.Equal(mzzzzzzzzzq_, "female");
        bool? mzzzzzzzzzs_ = context.Operators.And(mzzzzzzzzzn_, mzzzzzzzzzr_);
        IEnumerable<Encounter> mzzzzzzzzzt_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> mzzzzzzzzzu_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> mzzzzzzzzzv_ = context.Operators.Union<Encounter>(mzzzzzzzzzt_, mzzzzzzzzzu_);
        bool? mzzzzzzzzzw_ = context.Operators.Exists<Encounter>(mzzzzzzzzzv_);
        bool? mzzzzzzzzzx_ = context.Operators.And(mzzzzzzzzzs_, mzzzzzzzzzw_);

        return mzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? mzzzzzzzzzy_ = this.Initial_Population(context);

        return mzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzz_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> nzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet nzzzzzzzzzb_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> nzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzzzzzd_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> nzzzzzzzzzi_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept nzzzzzzzzzj_(CodeableConcept X)
            {
                CqlConcept nzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return nzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> nzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)nzzzzzzzzzi_, nzzzzzzzzzj_);
            CqlValueSet nzzzzzzzzzl_ = this.Right(context);
            bool? nzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(nzzzzzzzzzk_, nzzzzzzzzzl_);

            return nzzzzzzzzzm_;
        };
        IEnumerable<Condition> nzzzzzzzzze_ = context.Operators.Where<Condition>(nzzzzzzzzzc_, nzzzzzzzzzd_);
        IEnumerable<Condition> nzzzzzzzzzf_ = context.Operators.Union<Condition>(nzzzzzzzzza_, nzzzzzzzzze_);
        bool? nzzzzzzzzzg_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime nzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzo_);
            CqlInterval<CqlDateTime> nzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzr_ = context.Operators.End(nzzzzzzzzzq_);
            bool? nzzzzzzzzzs_ = context.Operators.SameOrBefore(nzzzzzzzzzp_, nzzzzzzzzzr_, default);

            return nzzzzzzzzzs_;
        };
        IEnumerable<Condition> nzzzzzzzzzh_ = context.Operators.Where<Condition>(nzzzzzzzzzf_, nzzzzzzzzzg_);

        return nzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzt_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> nzzzzzzzzzu_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? nzzzzzzzzzv_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> nzzzzzzzzzx_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string nzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzx_);
            bool? nzzzzzzzzzz_ = context.Operators.Equal(nzzzzzzzzzy_, "completed");
            DataType ozzzzzzzzza_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> ozzzzzzzzzb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzzzzzza_);
            CqlDateTime ozzzzzzzzzc_ = context.Operators.End(ozzzzzzzzzb_);
            CqlInterval<CqlDateTime> ozzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzze_ = context.Operators.End(ozzzzzzzzzd_);
            bool? ozzzzzzzzzf_ = context.Operators.SameOrBefore(ozzzzzzzzzc_, ozzzzzzzzze_, default);
            bool? ozzzzzzzzzg_ = context.Operators.And(nzzzzzzzzzz_, ozzzzzzzzzf_);

            return ozzzzzzzzzg_;
        };
        IEnumerable<Procedure> nzzzzzzzzzw_ = context.Operators.Where<Procedure>(nzzzzzzzzzu_, nzzzzzzzzzv_);

        return nzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzh_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> ozzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet ozzzzzzzzzj_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> ozzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ozzzzzzzzzl_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> ozzzzzzzzzq_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept ozzzzzzzzzr_(CodeableConcept X)
            {
                CqlConcept ozzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return ozzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> ozzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ozzzzzzzzzq_, ozzzzzzzzzr_);
            CqlValueSet ozzzzzzzzzt_ = this.Left(context);
            bool? ozzzzzzzzzu_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzs_, ozzzzzzzzzt_);

            return ozzzzzzzzzu_;
        };
        IEnumerable<Condition> ozzzzzzzzzm_ = context.Operators.Where<Condition>(ozzzzzzzzzk_, ozzzzzzzzzl_);
        IEnumerable<Condition> ozzzzzzzzzn_ = context.Operators.Union<Condition>(ozzzzzzzzzi_, ozzzzzzzzzm_);
        bool? ozzzzzzzzzo_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime ozzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzw_);
            CqlInterval<CqlDateTime> ozzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzz_ = context.Operators.End(ozzzzzzzzzy_);
            bool? pzzzzzzzzza_ = context.Operators.SameOrBefore(ozzzzzzzzzx_, ozzzzzzzzzz_, default);

            return pzzzzzzzzza_;
        };
        IEnumerable<Condition> ozzzzzzzzzp_ = context.Operators.Where<Condition>(ozzzzzzzzzn_, ozzzzzzzzzo_);

        return ozzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzb_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> pzzzzzzzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? pzzzzzzzzzd_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> pzzzzzzzzzf_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string pzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzf_);
            bool? pzzzzzzzzzh_ = context.Operators.Equal(pzzzzzzzzzg_, "completed");
            DataType pzzzzzzzzzi_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> pzzzzzzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzi_);
            CqlDateTime pzzzzzzzzzk_ = context.Operators.End(pzzzzzzzzzj_);
            CqlInterval<CqlDateTime> pzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzm_ = context.Operators.End(pzzzzzzzzzl_);
            bool? pzzzzzzzzzn_ = context.Operators.SameOrBefore(pzzzzzzzzzk_, pzzzzzzzzzm_, default);
            bool? pzzzzzzzzzo_ = context.Operators.And(pzzzzzzzzzh_, pzzzzzzzzzn_);

            return pzzzzzzzzzo_;
        };
        IEnumerable<Procedure> pzzzzzzzzze_ = context.Operators.Where<Procedure>(pzzzzzzzzzc_, pzzzzzzzzzd_);

        return pzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzp_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> pzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? pzzzzzzzzzr_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> pzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime pzzzzzzzzzu_ = context.Operators.Start(pzzzzzzzzzt_);
            CqlInterval<CqlDateTime> pzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzw_ = context.Operators.End(pzzzzzzzzzv_);
            bool? pzzzzzzzzzx_ = context.Operators.SameOrBefore(pzzzzzzzzzu_, pzzzzzzzzzw_, default);

            return pzzzzzzzzzx_;
        };
        IEnumerable<Condition> pzzzzzzzzzs_ = context.Operators.Where<Condition>(pzzzzzzzzzq_, pzzzzzzzzzr_);

        return pzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzy_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> pzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, pzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? qzzzzzzzzza_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> qzzzzzzzzzc_ = BilateralMastectomyPerformed?.StatusElement;
            string qzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzc_);
            bool? qzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzd_, "completed");
            DataType qzzzzzzzzzf_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> qzzzzzzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzf_);
            CqlDateTime qzzzzzzzzzh_ = context.Operators.End(qzzzzzzzzzg_);
            CqlInterval<CqlDateTime> qzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzj_ = context.Operators.End(qzzzzzzzzzi_);
            bool? qzzzzzzzzzk_ = context.Operators.SameOrBefore(qzzzzzzzzzh_, qzzzzzzzzzj_, default);
            bool? qzzzzzzzzzl_ = context.Operators.And(qzzzzzzzzze_, qzzzzzzzzzk_);

            return qzzzzzzzzzl_;
        };
        IEnumerable<Procedure> qzzzzzzzzzb_ = context.Operators.Where<Procedure>(pzzzzzzzzzz_, qzzzzzzzzza_);

        return qzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? qzzzzzzzzzm_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> qzzzzzzzzzn_ = this.Right_Mastectomy_Diagnosis(context);
        bool? qzzzzzzzzzo_ = context.Operators.Exists<Condition>(qzzzzzzzzzn_);
        IEnumerable<Procedure> qzzzzzzzzzp_ = this.Right_Mastectomy_Procedure(context);
        bool? qzzzzzzzzzq_ = context.Operators.Exists<Procedure>(qzzzzzzzzzp_);
        bool? qzzzzzzzzzr_ = context.Operators.Or(qzzzzzzzzzo_, qzzzzzzzzzq_);
        IEnumerable<Condition> qzzzzzzzzzs_ = this.Left_Mastectomy_Diagnosis(context);
        bool? qzzzzzzzzzt_ = context.Operators.Exists<Condition>(qzzzzzzzzzs_);
        IEnumerable<Procedure> qzzzzzzzzzu_ = this.Left_Mastectomy_Procedure(context);
        bool? qzzzzzzzzzv_ = context.Operators.Exists<Procedure>(qzzzzzzzzzu_);
        bool? qzzzzzzzzzw_ = context.Operators.Or(qzzzzzzzzzt_, qzzzzzzzzzv_);
        bool? qzzzzzzzzzx_ = context.Operators.And(qzzzzzzzzzr_, qzzzzzzzzzw_);
        bool? qzzzzzzzzzy_ = context.Operators.Or(qzzzzzzzzzm_, qzzzzzzzzzx_);
        IEnumerable<Condition> qzzzzzzzzzz_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? rzzzzzzzzza_ = context.Operators.Exists<Condition>(qzzzzzzzzzz_);
        bool? rzzzzzzzzzb_ = context.Operators.Or(qzzzzzzzzzy_, rzzzzzzzzza_);
        IEnumerable<Procedure> rzzzzzzzzzc_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? rzzzzzzzzzd_ = context.Operators.Exists<Procedure>(rzzzzzzzzzc_);
        bool? rzzzzzzzzze_ = context.Operators.Or(rzzzzzzzzzb_, rzzzzzzzzzd_);
        bool? rzzzzzzzzzf_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? rzzzzzzzzzg_ = context.Operators.Or(rzzzzzzzzze_, rzzzzzzzzzf_);
        Patient rzzzzzzzzzh_ = this.Patient(context);
        Date rzzzzzzzzzi_ = rzzzzzzzzzh_?.BirthDateElement;
        string rzzzzzzzzzj_ = rzzzzzzzzzi_?.Value;
        CqlDate rzzzzzzzzzk_ = context.Operators.ConvertStringToDate(rzzzzzzzzzj_);
        CqlInterval<CqlDateTime> rzzzzzzzzzl_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzm_ = context.Operators.Start(rzzzzzzzzzl_);
        CqlDate rzzzzzzzzzn_ = context.Operators.DateFrom(rzzzzzzzzzm_);
        int? rzzzzzzzzzo_ = context.Operators.CalculateAgeAt(rzzzzzzzzzk_, rzzzzzzzzzn_, "year");
        bool? rzzzzzzzzzp_ = context.Operators.GreaterOrEqual(rzzzzzzzzzo_, 65);
        bool? rzzzzzzzzzq_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? rzzzzzzzzzr_ = context.Operators.And(rzzzzzzzzzp_, rzzzzzzzzzq_);
        bool? rzzzzzzzzzs_ = context.Operators.Or(rzzzzzzzzzg_, rzzzzzzzzzr_);
        bool? rzzzzzzzzzt_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? rzzzzzzzzzu_ = context.Operators.Or(rzzzzzzzzzs_, rzzzzzzzzzt_);

        return rzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzv_ = this.Mammography(context);
        IEnumerable<Observation> rzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzx_(Observation Mammogram)
        {
            Code<ObservationStatus> szzzzzzzzza_ = Mammogram?.StatusElement;
            string szzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzza_);
            string[] szzzzzzzzzc_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? szzzzzzzzzd_ = context.Operators.In<string>(szzzzzzzzzb_, szzzzzzzzzc_ as IEnumerable<string>);
            DataType szzzzzzzzze_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> szzzzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzze_);
            CqlDateTime szzzzzzzzzg_ = context.Operators.End(szzzzzzzzzf_);
            CqlInterval<CqlDateTime> szzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzi_ = context.Operators.End(szzzzzzzzzh_);
            CqlQuantity szzzzzzzzzj_ = context.Operators.Quantity(27m, "months");
            CqlDateTime szzzzzzzzzk_ = context.Operators.Subtract(szzzzzzzzzi_, szzzzzzzzzj_);
            CqlDateTime szzzzzzzzzm_ = context.Operators.End(szzzzzzzzzh_);
            CqlInterval<CqlDateTime> szzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzk_, szzzzzzzzzm_, true, true);
            bool? szzzzzzzzzo_ = context.Operators.In<CqlDateTime>(szzzzzzzzzg_, szzzzzzzzzn_, default);
            CqlDateTime szzzzzzzzzq_ = context.Operators.End(szzzzzzzzzh_);
            bool? szzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzq_ is null));
            bool? szzzzzzzzzs_ = context.Operators.And(szzzzzzzzzo_, szzzzzzzzzr_);
            bool? szzzzzzzzzt_ = context.Operators.And(szzzzzzzzzd_, szzzzzzzzzs_);

            return szzzzzzzzzt_;
        };
        IEnumerable<Observation> rzzzzzzzzzy_ = context.Operators.Where<Observation>(rzzzzzzzzzw_, rzzzzzzzzzx_);
        bool? rzzzzzzzzzz_ = context.Operators.Exists<Observation>(rzzzzzzzzzy_);

        return rzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet szzzzzzzzzu_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> szzzzzzzzzv_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, szzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? szzzzzzzzzw_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> szzzzzzzzzz_ = Mammogram?.StatusElement;
            string tzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzz_);
            string[] tzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? tzzzzzzzzzc_ = context.Operators.In<string>(tzzzzzzzzza_, tzzzzzzzzzb_ as IEnumerable<string>);
            DataType tzzzzzzzzzd_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> tzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzd_);
            CqlDateTime tzzzzzzzzzf_ = context.Operators.End(tzzzzzzzzze_);
            CqlInterval<CqlDateTime> tzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzg_);
            CqlQuantity tzzzzzzzzzi_ = context.Operators.Quantity(27m, "months");
            CqlDateTime tzzzzzzzzzj_ = context.Operators.Subtract(tzzzzzzzzzh_, tzzzzzzzzzi_);
            CqlDateTime tzzzzzzzzzl_ = context.Operators.End(tzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzm_ = context.Operators.Interval(tzzzzzzzzzj_, tzzzzzzzzzl_, true, true);
            bool? tzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzf_, tzzzzzzzzzm_, default);
            CqlDateTime tzzzzzzzzzp_ = context.Operators.End(tzzzzzzzzzg_);
            bool? tzzzzzzzzzq_ = context.Operators.Not((bool?)(tzzzzzzzzzp_ is null));
            bool? tzzzzzzzzzr_ = context.Operators.And(tzzzzzzzzzn_, tzzzzzzzzzq_);
            bool? tzzzzzzzzzs_ = context.Operators.And(tzzzzzzzzzc_, tzzzzzzzzzr_);

            return tzzzzzzzzzs_;
        };
        IEnumerable<DiagnosticReport> szzzzzzzzzx_ = context.Operators.Where<DiagnosticReport>(szzzzzzzzzv_, szzzzzzzzzw_);
        bool? szzzzzzzzzy_ = context.Operators.Exists<DiagnosticReport>(szzzzzzzzzx_);

        return szzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? tzzzzzzzzzt_ = this.Observation_with_status(context);
        bool? tzzzzzzzzzu_ = this.Diagnostic_Report_with_status(context);
        bool? tzzzzzzzzzv_ = context.Operators.Or(tzzzzzzzzzt_, tzzzzzzzzzu_);

        return tzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? tzzzzzzzzzw_ = this.Numerator(context);
        bool? tzzzzzzzzzx_ = this.Initial_Population(context);
        bool? tzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzw_, tzzzzzzzzzx_);
        bool? tzzzzzzzzzz_ = this.Denominator(context);
        bool? uzzzzzzzzza_ = context.Operators.And(tzzzzzzzzzy_, tzzzzzzzzzz_);
        bool? uzzzzzzzzzb_ = this.Denominator_Exclusions(context);
        bool? uzzzzzzzzzc_ = context.Operators.Not(uzzzzzzzzzb_);
        bool? uzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzza_, uzzzzzzzzzc_);

        return uzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet uzzzzzzzzze_ = this.Mammography(context);
        IEnumerable<Observation> uzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? uzzzzzzzzzg_(Observation Mammogram)
        {
            Code<ObservationStatus> uzzzzzzzzzj_ = Mammogram?.StatusElement;
            string uzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzj_);
            string[] uzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? uzzzzzzzzzm_ = context.Operators.In<string>(uzzzzzzzzzk_, uzzzzzzzzzl_ as IEnumerable<string>);
            bool? uzzzzzzzzzn_ = context.Operators.Not(uzzzzzzzzzm_);
            DataType uzzzzzzzzzo_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> uzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzzzzzo_);
            CqlDateTime uzzzzzzzzzq_ = context.Operators.End(uzzzzzzzzzp_);
            CqlInterval<CqlDateTime> uzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzs_ = context.Operators.End(uzzzzzzzzzr_);
            CqlQuantity uzzzzzzzzzt_ = context.Operators.Quantity(27m, "months");
            CqlDateTime uzzzzzzzzzu_ = context.Operators.Subtract(uzzzzzzzzzs_, uzzzzzzzzzt_);
            CqlDateTime uzzzzzzzzzw_ = context.Operators.End(uzzzzzzzzzr_);
            CqlInterval<CqlDateTime> uzzzzzzzzzx_ = context.Operators.Interval(uzzzzzzzzzu_, uzzzzzzzzzw_, true, true);
            bool? uzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzq_, uzzzzzzzzzx_, default);
            CqlDateTime vzzzzzzzzza_ = context.Operators.End(uzzzzzzzzzr_);
            bool? vzzzzzzzzzb_ = context.Operators.Not((bool?)(vzzzzzzzzza_ is null));
            bool? vzzzzzzzzzc_ = context.Operators.And(uzzzzzzzzzy_, vzzzzzzzzzb_);
            bool? vzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzzn_, vzzzzzzzzzc_);

            return vzzzzzzzzzd_;
        };
        IEnumerable<Observation> uzzzzzzzzzh_ = context.Operators.Where<Observation>(uzzzzzzzzzf_, uzzzzzzzzzg_);
        bool? uzzzzzzzzzi_ = context.Operators.Exists<Observation>(uzzzzzzzzzh_);

        return uzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet vzzzzzzzzze_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> vzzzzzzzzzf_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, vzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? vzzzzzzzzzg_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> vzzzzzzzzzj_ = Mammogram?.StatusElement;
            string vzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzj_);
            string[] vzzzzzzzzzl_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? vzzzzzzzzzm_ = context.Operators.In<string>(vzzzzzzzzzk_, vzzzzzzzzzl_ as IEnumerable<string>);
            bool? vzzzzzzzzzn_ = context.Operators.Not(vzzzzzzzzzm_);
            DataType vzzzzzzzzzo_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> vzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzo_);
            CqlDateTime vzzzzzzzzzq_ = context.Operators.End(vzzzzzzzzzp_);
            CqlInterval<CqlDateTime> vzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzs_ = context.Operators.End(vzzzzzzzzzr_);
            CqlQuantity vzzzzzzzzzt_ = context.Operators.Quantity(27m, "months");
            CqlDateTime vzzzzzzzzzu_ = context.Operators.Subtract(vzzzzzzzzzs_, vzzzzzzzzzt_);
            CqlDateTime vzzzzzzzzzw_ = context.Operators.End(vzzzzzzzzzr_);
            CqlInterval<CqlDateTime> vzzzzzzzzzx_ = context.Operators.Interval(vzzzzzzzzzu_, vzzzzzzzzzw_, true, true);
            bool? vzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzq_, vzzzzzzzzzx_, default);
            CqlDateTime wzzzzzzzzza_ = context.Operators.End(vzzzzzzzzzr_);
            bool? wzzzzzzzzzb_ = context.Operators.Not((bool?)(wzzzzzzzzza_ is null));
            bool? wzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzy_, wzzzzzzzzzb_);
            bool? wzzzzzzzzzd_ = context.Operators.And(vzzzzzzzzzn_, wzzzzzzzzzc_);

            return wzzzzzzzzzd_;
        };
        IEnumerable<DiagnosticReport> vzzzzzzzzzh_ = context.Operators.Where<DiagnosticReport>(vzzzzzzzzzf_, vzzzzzzzzzg_);
        bool? vzzzzzzzzzi_ = context.Operators.Exists<DiagnosticReport>(vzzzzzzzzzh_);

        return vzzzzzzzzzi_;
    }


    #endregion Expressions

}
