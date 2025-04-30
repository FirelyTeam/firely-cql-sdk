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
        CqlDateTime izzzzzzzzzzzzzzm_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime izzzzzzzzzzzzzzn_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzo_ = context.Operators.Interval(izzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzn_, true, false);
        object izzzzzzzzzzzzzzp_ = context.ResolveParameter("Exam125FHIR-0.0.009", "Measurement Period", izzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient izzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzzzzzq_);

        return izzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzzzzs_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> izzzzzzzzzzzzzzt_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> izzzzzzzzzzzzzzu_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzv_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzw_ = this.Online_Assessments(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet izzzzzzzzzzzzzzy_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> jzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzz_);
        bool? jzzzzzzzzzzzzzzb_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> jzzzzzzzzzzzzzzd_ = TelehealthEncounter?.StatusElement;
            string jzzzzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzzzzf_ = context.Operators.Equal(jzzzzzzzzzzzzzze_, "finished");
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzzzzzh_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzzzzzzh_ as object);
            bool? jzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzi_, default);
            bool? jzzzzzzzzzzzzzzk_ = context.Operators.And(jzzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzzj_);

            return jzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzb_);

        return jzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient jzzzzzzzzzzzzzzl_ = this.Patient(context);
        Date jzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzl_?.BirthDateElement;
        string jzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzm_?.Value;
        CqlDate jzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzn_);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
        CqlDateTime jzzzzzzzzzzzzzzq_ = context.Operators.Start(jzzzzzzzzzzzzzzp_);
        CqlDate jzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzq_);
        int? jzzzzzzzzzzzzzzs_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzr_, "year");

        return jzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient jzzzzzzzzzzzzzzt_ = this.Patient(context);
        Date jzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzt_?.BirthDateElement;
        string jzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzu_?.Value;
        CqlDate jzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime jzzzzzzzzzzzzzzy_ = context.Operators.Start(jzzzzzzzzzzzzzzx_);
        CqlDate jzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzy_);
        int? kzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzz_, "year");
        CqlInterval<int?> kzzzzzzzzzzzzzzb_ = context.Operators.Interval(51, 74, true, false);
        bool? kzzzzzzzzzzzzzzc_ = context.Operators.In<int?>(kzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzb_, default);
        Code<AdministrativeGender> kzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzt_?.GenderElement;
        string kzzzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzze_);
        bool? kzzzzzzzzzzzzzzg_ = context.Operators.Equal(kzzzzzzzzzzzzzzf_, "female");
        bool? kzzzzzzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzi_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzj_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzj_);
        bool? kzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(kzzzzzzzzzzzzzzk_);
        bool? kzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzl_);

        return kzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzn_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzo_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet kzzzzzzzzzzzzzzq_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> kzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? kzzzzzzzzzzzzzzs_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> kzzzzzzzzzzzzzzx_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept kzzzzzzzzzzzzzzy_(CodeableConcept X)
            {
                CqlConcept lzzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return lzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)kzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzy_);
            CqlValueSet lzzzzzzzzzzzzzza_ = this.Right(context);
            bool? lzzzzzzzzzzzzzzb_ = context.Operators.ConceptsInValueSet(kzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzza_);

            return lzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzs_);
        IEnumerable<Condition> kzzzzzzzzzzzzzzu_ = context.Operators.Union<Condition>(kzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzt_);
        bool? kzzzzzzzzzzzzzzv_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime lzzzzzzzzzzzzzze_ = context.Operators.Start(lzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzg_ = context.Operators.End(lzzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzzh_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzg_, default);

            return lzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(kzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzv_);

        return kzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzi_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? lzzzzzzzzzzzzzzk_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> lzzzzzzzzzzzzzzm_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string lzzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzo_ = context.Operators.Equal(lzzzzzzzzzzzzzzn_, "completed");
            DataType lzzzzzzzzzzzzzzp_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, lzzzzzzzzzzzzzzp_);
            CqlDateTime lzzzzzzzzzzzzzzr_ = context.Operators.End(lzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzt_ = context.Operators.End(lzzzzzzzzzzzzzzs_);
            bool? lzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(lzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzt_, default);
            bool? lzzzzzzzzzzzzzzv_ = context.Operators.And(lzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzu_);

            return lzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzw_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet lzzzzzzzzzzzzzzy_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> lzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, lzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? mzzzzzzzzzzzzzza_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> mzzzzzzzzzzzzzzf_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept mzzzzzzzzzzzzzzg_(CodeableConcept X)
            {
                CqlConcept mzzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return mzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> mzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)mzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzg_);
            CqlValueSet mzzzzzzzzzzzzzzi_ = this.Left(context);
            bool? mzzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(mzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzzb_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzza_);
        IEnumerable<Condition> mzzzzzzzzzzzzzzc_ = context.Operators.Union<Condition>(lzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzb_);
        bool? mzzzzzzzzzzzzzzd_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime mzzzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzo_ = context.Operators.End(mzzzzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzo_, default);

            return mzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Condition> mzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzq_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> mzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, mzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? mzzzzzzzzzzzzzzs_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> mzzzzzzzzzzzzzzu_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string mzzzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzzzu_);
            bool? mzzzzzzzzzzzzzzw_ = context.Operators.Equal(mzzzzzzzzzzzzzzv_, "completed");
            DataType mzzzzzzzzzzzzzzx_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzzzzzzzzzzzx_);
            CqlDateTime mzzzzzzzzzzzzzzz_ = context.Operators.End(mzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzb_ = context.Operators.End(nzzzzzzzzzzzzzza_);
            bool? nzzzzzzzzzzzzzzc_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzb_, default);
            bool? nzzzzzzzzzzzzzzd_ = context.Operators.And(mzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzc_);

            return nzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Procedure> mzzzzzzzzzzzzzzt_ = context.Operators.Where<Procedure>(mzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzze_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> nzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? nzzzzzzzzzzzzzzg_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime nzzzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzl_ = context.Operators.End(nzzzzzzzzzzzzzzk_);
            bool? nzzzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzl_, default);

            return nzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> nzzzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(nzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzg_);

        return nzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzn_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> nzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, nzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? nzzzzzzzzzzzzzzp_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> nzzzzzzzzzzzzzzr_ = BilateralMastectomyPerformed?.StatusElement;
            string nzzzzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzzzzzzzzzzzzr_);
            bool? nzzzzzzzzzzzzzzt_ = context.Operators.Equal(nzzzzzzzzzzzzzzs_, "completed");
            DataType nzzzzzzzzzzzzzzu_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzzzzzzzzzzzzu_);
            CqlDateTime nzzzzzzzzzzzzzzw_ = context.Operators.End(nzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzy_ = context.Operators.End(nzzzzzzzzzzzzzzx_);
            bool? nzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzy_, default);
            bool? ozzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzz_);

            return ozzzzzzzzzzzzzza_;
        };
        IEnumerable<Procedure> nzzzzzzzzzzzzzzq_ = context.Operators.Where<Procedure>(nzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzp_);

        return nzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzb_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> ozzzzzzzzzzzzzzc_ = this.Right_Mastectomy_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzc_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzze_ = this.Right_Mastectomy_Procedure(context);
        bool? ozzzzzzzzzzzzzzf_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzze_);
        bool? ozzzzzzzzzzzzzzg_ = context.Operators.Or(ozzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzf_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzh_ = this.Left_Mastectomy_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzh_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzj_ = this.Left_Mastectomy_Procedure(context);
        bool? ozzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzj_);
        bool? ozzzzzzzzzzzzzzl_ = context.Operators.Or(ozzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzk_);
        bool? ozzzzzzzzzzzzzzm_ = context.Operators.And(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzl_);
        bool? ozzzzzzzzzzzzzzn_ = context.Operators.Or(ozzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzm_);
        IEnumerable<Condition> ozzzzzzzzzzzzzzo_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? ozzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(ozzzzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzzzq_ = context.Operators.Or(ozzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzp_);
        IEnumerable<Procedure> ozzzzzzzzzzzzzzr_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? ozzzzzzzzzzzzzzs_ = context.Operators.Exists<Procedure>(ozzzzzzzzzzzzzzr_);
        bool? ozzzzzzzzzzzzzzt_ = context.Operators.Or(ozzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzs_);
        bool? ozzzzzzzzzzzzzzu_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? ozzzzzzzzzzzzzzv_ = context.Operators.Or(ozzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzu_);
        Patient ozzzzzzzzzzzzzzw_ = this.Patient(context);
        Date ozzzzzzzzzzzzzzx_ = ozzzzzzzzzzzzzzw_?.BirthDateElement;
        string ozzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzx_?.Value;
        CqlDate ozzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(ozzzzzzzzzzzzzzy_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzzzzzzb_ = context.Operators.Start(pzzzzzzzzzzzzzza_);
        CqlDate pzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzb_);
        int? pzzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(ozzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzc_, "year");
        bool? pzzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(pzzzzzzzzzzzzzzd_, 65);
        bool? pzzzzzzzzzzzzzzf_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? pzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzf_);
        bool? pzzzzzzzzzzzzzzh_ = context.Operators.Or(ozzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzg_);
        bool? pzzzzzzzzzzzzzzi_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? pzzzzzzzzzzzzzzj_ = context.Operators.Or(pzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzi_);

        return pzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzk_ = this.Mammography(context);
        IEnumerable<Observation> pzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? pzzzzzzzzzzzzzzm_(Observation Mammogram)
        {
            Code<ObservationStatus> pzzzzzzzzzzzzzzp_ = Mammogram?.StatusElement;
            string pzzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzzzp_);
            string[] pzzzzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? pzzzzzzzzzzzzzzs_ = context.Operators.In<string>(pzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            DataType pzzzzzzzzzzzzzzt_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzzzzzzzzzt_);
            CqlDateTime pzzzzzzzzzzzzzzv_ = context.Operators.End(pzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzzzzzzzzzzx_ = context.Operators.End(pzzzzzzzzzzzzzzw_);
            CqlQuantity pzzzzzzzzzzzzzzy_ = context.Operators.Quantity(27m, "months");
            CqlDateTime pzzzzzzzzzzzzzzz_ = context.Operators.Subtract(pzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzy_);
            CqlDateTime qzzzzzzzzzzzzzzb_ = context.Operators.End(pzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzc_ = context.Operators.Interval(pzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzb_, true, true);
            bool? qzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzc_, default);
            CqlDateTime qzzzzzzzzzzzzzzf_ = context.Operators.End(pzzzzzzzzzzzzzzw_);
            bool? qzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzf_ is null));
            bool? qzzzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzg_);
            bool? qzzzzzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzh_);

            return qzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzm_);
        bool? pzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzj_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> qzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, qzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? qzzzzzzzzzzzzzzl_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> qzzzzzzzzzzzzzzo_ = Mammogram?.StatusElement;
            string qzzzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzzzzzo_);
            string[] qzzzzzzzzzzzzzzq_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? qzzzzzzzzzzzzzzr_ = context.Operators.In<string>(qzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzq_ as IEnumerable<string>);
            DataType qzzzzzzzzzzzzzzs_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzzzzzs_);
            CqlDateTime qzzzzzzzzzzzzzzu_ = context.Operators.End(qzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzw_ = context.Operators.End(qzzzzzzzzzzzzzzv_);
            CqlQuantity qzzzzzzzzzzzzzzx_ = context.Operators.Quantity(27m, "months");
            CqlDateTime qzzzzzzzzzzzzzzy_ = context.Operators.Subtract(qzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzx_);
            CqlDateTime rzzzzzzzzzzzzzza_ = context.Operators.End(qzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzb_ = context.Operators.Interval(qzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzza_, true, true);
            bool? rzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzb_, default);
            CqlDateTime rzzzzzzzzzzzzzze_ = context.Operators.End(qzzzzzzzzzzzzzzv_);
            bool? rzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzze_ is null));
            bool? rzzzzzzzzzzzzzzg_ = context.Operators.And(rzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzf_);
            bool? rzzzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzg_);

            return rzzzzzzzzzzzzzzh_;
        };
        IEnumerable<DiagnosticReport> qzzzzzzzzzzzzzzm_ = context.Operators.Where<DiagnosticReport>(qzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzn_ = context.Operators.Exists<DiagnosticReport>(qzzzzzzzzzzzzzzm_);

        return qzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzi_ = this.Observation_with_status(context);
        bool? rzzzzzzzzzzzzzzj_ = this.Diagnostic_Report_with_status(context);
        bool? rzzzzzzzzzzzzzzk_ = context.Operators.Or(rzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzj_);

        return rzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? rzzzzzzzzzzzzzzl_ = this.Numerator(context);
        bool? rzzzzzzzzzzzzzzm_ = this.Initial_Population(context);
        bool? rzzzzzzzzzzzzzzn_ = context.Operators.And(rzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzm_);
        bool? rzzzzzzzzzzzzzzo_ = this.Denominator(context);
        bool? rzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzo_);
        bool? rzzzzzzzzzzzzzzq_ = this.Denominator_Exclusions(context);
        bool? rzzzzzzzzzzzzzzr_ = context.Operators.Not(rzzzzzzzzzzzzzzq_);
        bool? rzzzzzzzzzzzzzzs_ = context.Operators.And(rzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzr_);

        return rzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzt_ = this.Mammography(context);
        IEnumerable<Observation> rzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? rzzzzzzzzzzzzzzv_(Observation Mammogram)
        {
            Code<ObservationStatus> rzzzzzzzzzzzzzzy_ = Mammogram?.StatusElement;
            string rzzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzzzzy_);
            string[] szzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? szzzzzzzzzzzzzzb_ = context.Operators.In<string>(rzzzzzzzzzzzzzzz_, szzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? szzzzzzzzzzzzzzc_ = context.Operators.Not(szzzzzzzzzzzzzzb_);
            DataType szzzzzzzzzzzzzzd_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzzzzzd_);
            CqlDateTime szzzzzzzzzzzzzzf_ = context.Operators.End(szzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzh_ = context.Operators.End(szzzzzzzzzzzzzzg_);
            CqlQuantity szzzzzzzzzzzzzzi_ = context.Operators.Quantity(27m, "months");
            CqlDateTime szzzzzzzzzzzzzzj_ = context.Operators.Subtract(szzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzi_);
            CqlDateTime szzzzzzzzzzzzzzl_ = context.Operators.End(szzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzm_ = context.Operators.Interval(szzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzl_, true, true);
            bool? szzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzm_, default);
            CqlDateTime szzzzzzzzzzzzzzp_ = context.Operators.End(szzzzzzzzzzzzzzg_);
            bool? szzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzp_ is null));
            bool? szzzzzzzzzzzzzzr_ = context.Operators.And(szzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzq_);
            bool? szzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzr_);

            return szzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzv_);
        bool? rzzzzzzzzzzzzzzx_ = context.Operators.Exists<Observation>(rzzzzzzzzzzzzzzw_);

        return rzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzt_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> szzzzzzzzzzzzzzu_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, szzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? szzzzzzzzzzzzzzv_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> szzzzzzzzzzzzzzy_ = Mammogram?.StatusElement;
            string szzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzzzzzy_);
            string[] tzzzzzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? tzzzzzzzzzzzzzzb_ = context.Operators.In<string>(szzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzza_ as IEnumerable<string>);
            bool? tzzzzzzzzzzzzzzc_ = context.Operators.Not(tzzzzzzzzzzzzzzb_);
            DataType tzzzzzzzzzzzzzzd_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzzzzzzzzzd_);
            CqlDateTime tzzzzzzzzzzzzzzf_ = context.Operators.End(tzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzzzzzzg_);
            CqlQuantity tzzzzzzzzzzzzzzi_ = context.Operators.Quantity(27m, "months");
            CqlDateTime tzzzzzzzzzzzzzzj_ = context.Operators.Subtract(tzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzi_);
            CqlDateTime tzzzzzzzzzzzzzzl_ = context.Operators.End(tzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzm_ = context.Operators.Interval(tzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzl_, true, true);
            bool? tzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzm_, default);
            CqlDateTime tzzzzzzzzzzzzzzp_ = context.Operators.End(tzzzzzzzzzzzzzzg_);
            bool? tzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzp_ is null));
            bool? tzzzzzzzzzzzzzzr_ = context.Operators.And(tzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzzzs_ = context.Operators.And(tzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzr_);

            return tzzzzzzzzzzzzzzs_;
        };
        IEnumerable<DiagnosticReport> szzzzzzzzzzzzzzw_ = context.Operators.Where<DiagnosticReport>(szzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzv_);
        bool? szzzzzzzzzzzzzzx_ = context.Operators.Exists<DiagnosticReport>(szzzzzzzzzzzzzzw_);

        return szzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
