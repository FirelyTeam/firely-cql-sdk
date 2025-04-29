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
[CqlLibrary("Exam125FHIR", "0.0.009")]
public partial class Exam125FHIR_0_0_009 : ILibrary, ISingleton<Exam125FHIR_0_0_009>
{
    private Exam125FHIR_0_0_009() {}

    public static Exam125FHIR_0_0_009 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Exam125FHIR";
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
        CqlDateTime hzzzzq_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime hzzzzr_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> hzzzzs_ = context.Operators.Interval(hzzzzq_, hzzzzr_, true, false);
        object hzzzzt_ = context.ResolveParameter("Exam125FHIR-0.0.009", "Measurement Period", hzzzzs_);

        return (CqlInterval<CqlDateTime>)hzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient hzzzzv_ = context.Operators.SingletonFrom<Patient>(hzzzzu_);

        return hzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> hzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return hzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> hzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return hzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> hzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return hzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return hzzzzz_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet izzzza_ = this.Online_Assessments(context);
        IEnumerable<Encounter> izzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet izzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> izzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> izzzze_ = context.Operators.Union<Encounter>(izzzzb_, izzzzd_);
        bool? izzzzf_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> izzzzh_ = TelehealthEncounter?.StatusElement;
            string izzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzh_);
            bool? izzzzj_ = context.Operators.Equal(izzzzi_, "finished");
            CqlInterval<CqlDateTime> izzzzk_ = this.Measurement_Period(context);
            Period izzzzl_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzl_ as object);
            bool? izzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzk_, izzzzm_, default);
            bool? izzzzo_ = context.Operators.And(izzzzj_, izzzzn_);

            return izzzzo_;
        };
        IEnumerable<Encounter> izzzzg_ = context.Operators.Where<Encounter>(izzzze_, izzzzf_);

        return izzzzg_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient izzzzp_ = this.Patient(context);
        Date izzzzq_ = izzzzp_?.BirthDateElement;
        string izzzzr_ = izzzzq_?.Value;
        CqlDate izzzzs_ = context.Operators.ConvertStringToDate(izzzzr_);
        CqlInterval<CqlDateTime> izzzzt_ = this.Measurement_Period(context);
        CqlDateTime izzzzu_ = context.Operators.Start(izzzzt_);
        CqlDate izzzzv_ = context.Operators.DateFrom(izzzzu_);
        int? izzzzw_ = context.Operators.CalculateAgeAt(izzzzs_, izzzzv_, "year");

        return izzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient izzzzx_ = this.Patient(context);
        Date izzzzy_ = izzzzx_?.BirthDateElement;
        string izzzzz_ = izzzzy_?.Value;
        CqlDate jzzzza_ = context.Operators.ConvertStringToDate(izzzzz_);
        CqlInterval<CqlDateTime> jzzzzb_ = this.Measurement_Period(context);
        CqlDateTime jzzzzc_ = context.Operators.Start(jzzzzb_);
        CqlDate jzzzzd_ = context.Operators.DateFrom(jzzzzc_);
        int? jzzzze_ = context.Operators.CalculateAgeAt(jzzzza_, jzzzzd_, "year");
        CqlInterval<int?> jzzzzf_ = context.Operators.Interval(51, 74, true, false);
        bool? jzzzzg_ = context.Operators.In<int?>(jzzzze_, jzzzzf_, default);
        Code<AdministrativeGender> jzzzzi_ = izzzzx_?.GenderElement;
        string jzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzi_);
        bool? jzzzzk_ = context.Operators.Equal(jzzzzj_, "female");
        bool? jzzzzl_ = context.Operators.And(jzzzzg_, jzzzzk_);
        IEnumerable<Encounter> jzzzzm_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> jzzzzn_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> jzzzzo_ = context.Operators.Union<Encounter>(jzzzzm_, jzzzzn_);
        bool? jzzzzp_ = context.Operators.Exists<Encounter>(jzzzzo_);
        bool? jzzzzq_ = context.Operators.And(jzzzzl_, jzzzzp_);

        return jzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? jzzzzr_ = this.Initial_Population(context);

        return jzzzzr_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet jzzzzs_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> jzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet jzzzzu_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> jzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? jzzzzw_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> kzzzzb_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept kzzzzc_(CodeableConcept X)
            {
                CqlConcept kzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return kzzzzg_;
            };
            IEnumerable<CqlConcept> kzzzzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzzzzb_, kzzzzc_);
            CqlValueSet kzzzze_ = this.Right(context);
            bool? kzzzzf_ = context.Operators.ConceptsInValueSet(kzzzzd_, kzzzze_);

            return kzzzzf_;
        };
        IEnumerable<Condition> jzzzzx_ = context.Operators.Where<Condition>(jzzzzv_, jzzzzw_);
        IEnumerable<Condition> jzzzzy_ = context.Operators.Union<Condition>(jzzzzt_, jzzzzx_);
        bool? jzzzzz_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> kzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime kzzzzi_ = context.Operators.Start(kzzzzh_);
            CqlInterval<CqlDateTime> kzzzzj_ = this.Measurement_Period(context);
            CqlDateTime kzzzzk_ = context.Operators.End(kzzzzj_);
            bool? kzzzzl_ = context.Operators.SameOrBefore(kzzzzi_, kzzzzk_, default);

            return kzzzzl_;
        };
        IEnumerable<Condition> kzzzza_ = context.Operators.Where<Condition>(jzzzzy_, jzzzzz_);

        return kzzzza_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet kzzzzm_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> kzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzo_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> kzzzzq_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string kzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzq_);
            bool? kzzzzs_ = context.Operators.Equal(kzzzzr_, "completed");
            DataType kzzzzt_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> kzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzt_);
            CqlDateTime kzzzzv_ = context.Operators.End(kzzzzu_);
            CqlInterval<CqlDateTime> kzzzzw_ = this.Measurement_Period(context);
            CqlDateTime kzzzzx_ = context.Operators.End(kzzzzw_);
            bool? kzzzzy_ = context.Operators.SameOrBefore(kzzzzv_, kzzzzx_, default);
            bool? kzzzzz_ = context.Operators.And(kzzzzs_, kzzzzy_);

            return kzzzzz_;
        };
        IEnumerable<Procedure> kzzzzp_ = context.Operators.Where<Procedure>(kzzzzn_, kzzzzo_);

        return kzzzzp_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet lzzzza_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> lzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet lzzzzc_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> lzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? lzzzze_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> lzzzzj_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept lzzzzk_(CodeableConcept X)
            {
                CqlConcept lzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return lzzzzo_;
            };
            IEnumerable<CqlConcept> lzzzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lzzzzj_, lzzzzk_);
            CqlValueSet lzzzzm_ = this.Left(context);
            bool? lzzzzn_ = context.Operators.ConceptsInValueSet(lzzzzl_, lzzzzm_);

            return lzzzzn_;
        };
        IEnumerable<Condition> lzzzzf_ = context.Operators.Where<Condition>(lzzzzd_, lzzzze_);
        IEnumerable<Condition> lzzzzg_ = context.Operators.Union<Condition>(lzzzzb_, lzzzzf_);
        bool? lzzzzh_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> lzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime lzzzzq_ = context.Operators.Start(lzzzzp_);
            CqlInterval<CqlDateTime> lzzzzr_ = this.Measurement_Period(context);
            CqlDateTime lzzzzs_ = context.Operators.End(lzzzzr_);
            bool? lzzzzt_ = context.Operators.SameOrBefore(lzzzzq_, lzzzzs_, default);

            return lzzzzt_;
        };
        IEnumerable<Condition> lzzzzi_ = context.Operators.Where<Condition>(lzzzzg_, lzzzzh_);

        return lzzzzi_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet lzzzzu_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> lzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? lzzzzw_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> lzzzzy_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string lzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzy_);
            bool? mzzzza_ = context.Operators.Equal(lzzzzz_, "completed");
            DataType mzzzzb_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> mzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzb_);
            CqlDateTime mzzzzd_ = context.Operators.End(mzzzzc_);
            CqlInterval<CqlDateTime> mzzzze_ = this.Measurement_Period(context);
            CqlDateTime mzzzzf_ = context.Operators.End(mzzzze_);
            bool? mzzzzg_ = context.Operators.SameOrBefore(mzzzzd_, mzzzzf_, default);
            bool? mzzzzh_ = context.Operators.And(mzzzza_, mzzzzg_);

            return mzzzzh_;
        };
        IEnumerable<Procedure> lzzzzx_ = context.Operators.Where<Procedure>(lzzzzv_, lzzzzw_);

        return lzzzzx_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet mzzzzi_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> mzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? mzzzzk_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> mzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime mzzzzn_ = context.Operators.Start(mzzzzm_);
            CqlInterval<CqlDateTime> mzzzzo_ = this.Measurement_Period(context);
            CqlDateTime mzzzzp_ = context.Operators.End(mzzzzo_);
            bool? mzzzzq_ = context.Operators.SameOrBefore(mzzzzn_, mzzzzp_, default);

            return mzzzzq_;
        };
        IEnumerable<Condition> mzzzzl_ = context.Operators.Where<Condition>(mzzzzj_, mzzzzk_);

        return mzzzzl_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet mzzzzr_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> mzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? mzzzzt_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> mzzzzv_ = BilateralMastectomyPerformed?.StatusElement;
            string mzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzv_);
            bool? mzzzzx_ = context.Operators.Equal(mzzzzw_, "completed");
            DataType mzzzzy_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> mzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzy_);
            CqlDateTime nzzzza_ = context.Operators.End(mzzzzz_);
            CqlInterval<CqlDateTime> nzzzzb_ = this.Measurement_Period(context);
            CqlDateTime nzzzzc_ = context.Operators.End(nzzzzb_);
            bool? nzzzzd_ = context.Operators.SameOrBefore(nzzzza_, nzzzzc_, default);
            bool? nzzzze_ = context.Operators.And(mzzzzx_, nzzzzd_);

            return nzzzze_;
        };
        IEnumerable<Procedure> mzzzzu_ = context.Operators.Where<Procedure>(mzzzzs_, mzzzzt_);

        return mzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? nzzzzf_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> nzzzzg_ = this.Right_Mastectomy_Diagnosis(context);
        bool? nzzzzh_ = context.Operators.Exists<Condition>(nzzzzg_);
        IEnumerable<Procedure> nzzzzi_ = this.Right_Mastectomy_Procedure(context);
        bool? nzzzzj_ = context.Operators.Exists<Procedure>(nzzzzi_);
        bool? nzzzzk_ = context.Operators.Or(nzzzzh_, nzzzzj_);
        IEnumerable<Condition> nzzzzl_ = this.Left_Mastectomy_Diagnosis(context);
        bool? nzzzzm_ = context.Operators.Exists<Condition>(nzzzzl_);
        IEnumerable<Procedure> nzzzzn_ = this.Left_Mastectomy_Procedure(context);
        bool? nzzzzo_ = context.Operators.Exists<Procedure>(nzzzzn_);
        bool? nzzzzp_ = context.Operators.Or(nzzzzm_, nzzzzo_);
        bool? nzzzzq_ = context.Operators.And(nzzzzk_, nzzzzp_);
        bool? nzzzzr_ = context.Operators.Or(nzzzzf_, nzzzzq_);
        IEnumerable<Condition> nzzzzs_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? nzzzzt_ = context.Operators.Exists<Condition>(nzzzzs_);
        bool? nzzzzu_ = context.Operators.Or(nzzzzr_, nzzzzt_);
        IEnumerable<Procedure> nzzzzv_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? nzzzzw_ = context.Operators.Exists<Procedure>(nzzzzv_);
        bool? nzzzzx_ = context.Operators.Or(nzzzzu_, nzzzzw_);
        bool? nzzzzy_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? nzzzzz_ = context.Operators.Or(nzzzzx_, nzzzzy_);
        Patient ozzzza_ = this.Patient(context);
        Date ozzzzb_ = ozzzza_?.BirthDateElement;
        string ozzzzc_ = ozzzzb_?.Value;
        CqlDate ozzzzd_ = context.Operators.ConvertStringToDate(ozzzzc_);
        CqlInterval<CqlDateTime> ozzzze_ = this.Measurement_Period(context);
        CqlDateTime ozzzzf_ = context.Operators.Start(ozzzze_);
        CqlDate ozzzzg_ = context.Operators.DateFrom(ozzzzf_);
        int? ozzzzh_ = context.Operators.CalculateAgeAt(ozzzzd_, ozzzzg_, "year");
        bool? ozzzzi_ = context.Operators.GreaterOrEqual(ozzzzh_, 65);
        bool? ozzzzj_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? ozzzzk_ = context.Operators.And(ozzzzi_, ozzzzj_);
        bool? ozzzzl_ = context.Operators.Or(nzzzzz_, ozzzzk_);
        bool? ozzzzm_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? ozzzzn_ = context.Operators.Or(ozzzzl_, ozzzzm_);

        return ozzzzn_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet ozzzzo_ = this.Mammography(context);
        IEnumerable<Observation> ozzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzq_(Observation Mammogram)
        {
            Code<ObservationStatus> ozzzzt_ = Mammogram?.StatusElement;
            string ozzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzt_);
            string[] ozzzzv_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ozzzzw_ = context.Operators.In<string>(ozzzzu_, ozzzzv_ as IEnumerable<string>);
            DataType ozzzzx_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> ozzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzx_);
            CqlDateTime ozzzzz_ = context.Operators.End(ozzzzy_);
            CqlInterval<CqlDateTime> pzzzza_ = this.Measurement_Period(context);
            CqlDateTime pzzzzb_ = context.Operators.End(pzzzza_);
            CqlQuantity pzzzzc_ = context.Operators.Quantity(27m, "months");
            CqlDateTime pzzzzd_ = context.Operators.Subtract(pzzzzb_, pzzzzc_);
            CqlDateTime pzzzzf_ = context.Operators.End(pzzzza_);
            CqlInterval<CqlDateTime> pzzzzg_ = context.Operators.Interval(pzzzzd_, pzzzzf_, true, true);
            bool? pzzzzh_ = context.Operators.In<CqlDateTime>(ozzzzz_, pzzzzg_, default);
            CqlDateTime pzzzzj_ = context.Operators.End(pzzzza_);
            bool? pzzzzk_ = context.Operators.Not((bool?)(pzzzzj_ is null));
            bool? pzzzzl_ = context.Operators.And(pzzzzh_, pzzzzk_);
            bool? pzzzzm_ = context.Operators.And(ozzzzw_, pzzzzl_);

            return pzzzzm_;
        };
        IEnumerable<Observation> ozzzzr_ = context.Operators.Where<Observation>(ozzzzp_, ozzzzq_);
        bool? ozzzzs_ = context.Operators.Exists<Observation>(ozzzzr_);

        return ozzzzs_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet pzzzzn_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> pzzzzo_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, pzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? pzzzzp_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> pzzzzs_ = Mammogram?.StatusElement;
            string pzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzs_);
            string[] pzzzzu_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? pzzzzv_ = context.Operators.In<string>(pzzzzt_, pzzzzu_ as IEnumerable<string>);
            DataType pzzzzw_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> pzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzw_);
            CqlDateTime pzzzzy_ = context.Operators.End(pzzzzx_);
            CqlInterval<CqlDateTime> pzzzzz_ = this.Measurement_Period(context);
            CqlDateTime qzzzza_ = context.Operators.End(pzzzzz_);
            CqlQuantity qzzzzb_ = context.Operators.Quantity(27m, "months");
            CqlDateTime qzzzzc_ = context.Operators.Subtract(qzzzza_, qzzzzb_);
            CqlDateTime qzzzze_ = context.Operators.End(pzzzzz_);
            CqlInterval<CqlDateTime> qzzzzf_ = context.Operators.Interval(qzzzzc_, qzzzze_, true, true);
            bool? qzzzzg_ = context.Operators.In<CqlDateTime>(pzzzzy_, qzzzzf_, default);
            CqlDateTime qzzzzi_ = context.Operators.End(pzzzzz_);
            bool? qzzzzj_ = context.Operators.Not((bool?)(qzzzzi_ is null));
            bool? qzzzzk_ = context.Operators.And(qzzzzg_, qzzzzj_);
            bool? qzzzzl_ = context.Operators.And(pzzzzv_, qzzzzk_);

            return qzzzzl_;
        };
        IEnumerable<DiagnosticReport> pzzzzq_ = context.Operators.Where<DiagnosticReport>(pzzzzo_, pzzzzp_);
        bool? pzzzzr_ = context.Operators.Exists<DiagnosticReport>(pzzzzq_);

        return pzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? qzzzzm_ = this.Observation_with_status(context);
        bool? qzzzzn_ = this.Diagnostic_Report_with_status(context);
        bool? qzzzzo_ = context.Operators.Or(qzzzzm_, qzzzzn_);

        return qzzzzo_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? qzzzzp_ = this.Numerator(context);
        bool? qzzzzq_ = this.Initial_Population(context);
        bool? qzzzzr_ = context.Operators.And(qzzzzp_, qzzzzq_);
        bool? qzzzzs_ = this.Denominator(context);
        bool? qzzzzt_ = context.Operators.And(qzzzzr_, qzzzzs_);
        bool? qzzzzu_ = this.Denominator_Exclusions(context);
        bool? qzzzzv_ = context.Operators.Not(qzzzzu_);
        bool? qzzzzw_ = context.Operators.And(qzzzzt_, qzzzzv_);

        return qzzzzw_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet qzzzzx_ = this.Mammography(context);
        IEnumerable<Observation> qzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? qzzzzz_(Observation Mammogram)
        {
            Code<ObservationStatus> rzzzzc_ = Mammogram?.StatusElement;
            string rzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzc_);
            string[] rzzzze_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? rzzzzf_ = context.Operators.In<string>(rzzzzd_, rzzzze_ as IEnumerable<string>);
            bool? rzzzzg_ = context.Operators.Not(rzzzzf_);
            DataType rzzzzh_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> rzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzh_);
            CqlDateTime rzzzzj_ = context.Operators.End(rzzzzi_);
            CqlInterval<CqlDateTime> rzzzzk_ = this.Measurement_Period(context);
            CqlDateTime rzzzzl_ = context.Operators.End(rzzzzk_);
            CqlQuantity rzzzzm_ = context.Operators.Quantity(27m, "months");
            CqlDateTime rzzzzn_ = context.Operators.Subtract(rzzzzl_, rzzzzm_);
            CqlDateTime rzzzzp_ = context.Operators.End(rzzzzk_);
            CqlInterval<CqlDateTime> rzzzzq_ = context.Operators.Interval(rzzzzn_, rzzzzp_, true, true);
            bool? rzzzzr_ = context.Operators.In<CqlDateTime>(rzzzzj_, rzzzzq_, default);
            CqlDateTime rzzzzt_ = context.Operators.End(rzzzzk_);
            bool? rzzzzu_ = context.Operators.Not((bool?)(rzzzzt_ is null));
            bool? rzzzzv_ = context.Operators.And(rzzzzr_, rzzzzu_);
            bool? rzzzzw_ = context.Operators.And(rzzzzg_, rzzzzv_);

            return rzzzzw_;
        };
        IEnumerable<Observation> rzzzza_ = context.Operators.Where<Observation>(qzzzzy_, qzzzzz_);
        bool? rzzzzb_ = context.Operators.Exists<Observation>(rzzzza_);

        return rzzzzb_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet rzzzzx_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> rzzzzy_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, rzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? rzzzzz_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> szzzzc_ = Mammogram?.StatusElement;
            string szzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzc_);
            string[] szzzze_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? szzzzf_ = context.Operators.In<string>(szzzzd_, szzzze_ as IEnumerable<string>);
            bool? szzzzg_ = context.Operators.Not(szzzzf_);
            DataType szzzzh_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> szzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzh_);
            CqlDateTime szzzzj_ = context.Operators.End(szzzzi_);
            CqlInterval<CqlDateTime> szzzzk_ = this.Measurement_Period(context);
            CqlDateTime szzzzl_ = context.Operators.End(szzzzk_);
            CqlQuantity szzzzm_ = context.Operators.Quantity(27m, "months");
            CqlDateTime szzzzn_ = context.Operators.Subtract(szzzzl_, szzzzm_);
            CqlDateTime szzzzp_ = context.Operators.End(szzzzk_);
            CqlInterval<CqlDateTime> szzzzq_ = context.Operators.Interval(szzzzn_, szzzzp_, true, true);
            bool? szzzzr_ = context.Operators.In<CqlDateTime>(szzzzj_, szzzzq_, default);
            CqlDateTime szzzzt_ = context.Operators.End(szzzzk_);
            bool? szzzzu_ = context.Operators.Not((bool?)(szzzzt_ is null));
            bool? szzzzv_ = context.Operators.And(szzzzr_, szzzzu_);
            bool? szzzzw_ = context.Operators.And(szzzzg_, szzzzv_);

            return szzzzw_;
        };
        IEnumerable<DiagnosticReport> szzzza_ = context.Operators.Where<DiagnosticReport>(rzzzzy_, rzzzzz_);
        bool? szzzzb_ = context.Operators.Exists<DiagnosticReport>(szzzza_);

        return szzzzb_;
    }


    #endregion Expressions

}
