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
        CqlDateTime azzzzzzzd_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime azzzzzzze_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> azzzzzzzf_ = context.Operators.Interval(azzzzzzzd_, azzzzzzze_, true, false);
        object azzzzzzzg_ = context.ResolveParameter("Exam125FHIR-0.0.009", "Measurement Period", azzzzzzzf_);

        return (CqlInterval<CqlDateTime>)azzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient azzzzzzzi_ = context.Operators.SingletonFrom<Patient>(azzzzzzzh_);

        return azzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzj_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> azzzzzzzk_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return azzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> azzzzzzzl_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return azzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzm_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return azzzzzzzm_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet azzzzzzzn_ = this.Online_Assessments(context);
        IEnumerable<Encounter> azzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet azzzzzzzp_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> azzzzzzzr_ = context.Operators.Union<Encounter>(azzzzzzzo_, azzzzzzzq_);
        bool? azzzzzzzs_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> azzzzzzzu_ = TelehealthEncounter?.StatusElement;
            string azzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzu_);
            bool? azzzzzzzw_ = context.Operators.Equal(azzzzzzzv_, "finished");
            CqlInterval<CqlDateTime> azzzzzzzx_ = this.Measurement_Period(context);
            Period azzzzzzzy_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzy_ as object);
            bool? bzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzx_, azzzzzzzz_, default);
            bool? bzzzzzzzb_ = context.Operators.And(azzzzzzzw_, bzzzzzzza_);

            return bzzzzzzzb_;
        };
        IEnumerable<Encounter> azzzzzzzt_ = context.Operators.Where<Encounter>(azzzzzzzr_, azzzzzzzs_);

        return azzzzzzzt_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient bzzzzzzzc_ = this.Patient(context);
        Date bzzzzzzzd_ = bzzzzzzzc_?.BirthDateElement;
        string bzzzzzzze_ = bzzzzzzzd_?.Value;
        CqlDate bzzzzzzzf_ = context.Operators.ConvertStringToDate(bzzzzzzze_);
        CqlInterval<CqlDateTime> bzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzh_ = context.Operators.Start(bzzzzzzzg_);
        CqlDate bzzzzzzzi_ = context.Operators.DateFrom(bzzzzzzzh_);
        int? bzzzzzzzj_ = context.Operators.CalculateAgeAt(bzzzzzzzf_, bzzzzzzzi_, "year");

        return bzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzk_ = this.Patient(context);
        Date bzzzzzzzl_ = bzzzzzzzk_?.BirthDateElement;
        string bzzzzzzzm_ = bzzzzzzzl_?.Value;
        CqlDate bzzzzzzzn_ = context.Operators.ConvertStringToDate(bzzzzzzzm_);
        CqlInterval<CqlDateTime> bzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzp_ = context.Operators.Start(bzzzzzzzo_);
        CqlDate bzzzzzzzq_ = context.Operators.DateFrom(bzzzzzzzp_);
        int? bzzzzzzzr_ = context.Operators.CalculateAgeAt(bzzzzzzzn_, bzzzzzzzq_, "year");
        CqlInterval<int?> bzzzzzzzs_ = context.Operators.Interval(51, 74, true, false);
        bool? bzzzzzzzt_ = context.Operators.In<int?>(bzzzzzzzr_, bzzzzzzzs_, default);
        Code<AdministrativeGender> bzzzzzzzv_ = bzzzzzzzk_?.GenderElement;
        string bzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzv_);
        bool? bzzzzzzzx_ = context.Operators.Equal(bzzzzzzzw_, "female");
        bool? bzzzzzzzy_ = context.Operators.And(bzzzzzzzt_, bzzzzzzzx_);
        IEnumerable<Encounter> bzzzzzzzz_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> czzzzzzza_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> czzzzzzzb_ = context.Operators.Union<Encounter>(bzzzzzzzz_, czzzzzzza_);
        bool? czzzzzzzc_ = context.Operators.Exists<Encounter>(czzzzzzzb_);
        bool? czzzzzzzd_ = context.Operators.And(bzzzzzzzy_, czzzzzzzc_);

        return czzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? czzzzzzze_ = this.Initial_Population(context);

        return czzzzzzze_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet czzzzzzzf_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> czzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet czzzzzzzh_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> czzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? czzzzzzzj_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> czzzzzzzo_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept czzzzzzzp_(CodeableConcept X)
            {
                CqlConcept czzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return czzzzzzzt_;
            };
            IEnumerable<CqlConcept> czzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzo_, czzzzzzzp_);
            CqlValueSet czzzzzzzr_ = this.Right(context);
            bool? czzzzzzzs_ = context.Operators.ConceptsInValueSet(czzzzzzzq_, czzzzzzzr_);

            return czzzzzzzs_;
        };
        IEnumerable<Condition> czzzzzzzk_ = context.Operators.Where<Condition>(czzzzzzzi_, czzzzzzzj_);
        IEnumerable<Condition> czzzzzzzl_ = context.Operators.Union<Condition>(czzzzzzzg_, czzzzzzzk_);
        bool? czzzzzzzm_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> czzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime czzzzzzzv_ = context.Operators.Start(czzzzzzzu_);
            CqlInterval<CqlDateTime> czzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzx_ = context.Operators.End(czzzzzzzw_);
            bool? czzzzzzzy_ = context.Operators.SameOrBefore(czzzzzzzv_, czzzzzzzx_, default);

            return czzzzzzzy_;
        };
        IEnumerable<Condition> czzzzzzzn_ = context.Operators.Where<Condition>(czzzzzzzl_, czzzzzzzm_);

        return czzzzzzzn_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet czzzzzzzz_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> dzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? dzzzzzzzb_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> dzzzzzzzd_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string dzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzd_);
            bool? dzzzzzzzf_ = context.Operators.Equal(dzzzzzzze_, "completed");
            DataType dzzzzzzzg_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> dzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzzzzg_);
            CqlDateTime dzzzzzzzi_ = context.Operators.End(dzzzzzzzh_);
            CqlInterval<CqlDateTime> dzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzk_ = context.Operators.End(dzzzzzzzj_);
            bool? dzzzzzzzl_ = context.Operators.SameOrBefore(dzzzzzzzi_, dzzzzzzzk_, default);
            bool? dzzzzzzzm_ = context.Operators.And(dzzzzzzzf_, dzzzzzzzl_);

            return dzzzzzzzm_;
        };
        IEnumerable<Procedure> dzzzzzzzc_ = context.Operators.Where<Procedure>(dzzzzzzza_, dzzzzzzzb_);

        return dzzzzzzzc_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet dzzzzzzzn_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> dzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet dzzzzzzzp_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> dzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? dzzzzzzzr_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> dzzzzzzzw_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept dzzzzzzzx_(CodeableConcept X)
            {
                CqlConcept ezzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return ezzzzzzzb_;
            };
            IEnumerable<CqlConcept> dzzzzzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzw_, dzzzzzzzx_);
            CqlValueSet dzzzzzzzz_ = this.Left(context);
            bool? ezzzzzzza_ = context.Operators.ConceptsInValueSet(dzzzzzzzy_, dzzzzzzzz_);

            return ezzzzzzza_;
        };
        IEnumerable<Condition> dzzzzzzzs_ = context.Operators.Where<Condition>(dzzzzzzzq_, dzzzzzzzr_);
        IEnumerable<Condition> dzzzzzzzt_ = context.Operators.Union<Condition>(dzzzzzzzo_, dzzzzzzzs_);
        bool? dzzzzzzzu_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> ezzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime ezzzzzzzd_ = context.Operators.Start(ezzzzzzzc_);
            CqlInterval<CqlDateTime> ezzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzf_ = context.Operators.End(ezzzzzzze_);
            bool? ezzzzzzzg_ = context.Operators.SameOrBefore(ezzzzzzzd_, ezzzzzzzf_, default);

            return ezzzzzzzg_;
        };
        IEnumerable<Condition> dzzzzzzzv_ = context.Operators.Where<Condition>(dzzzzzzzt_, dzzzzzzzu_);

        return dzzzzzzzv_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet ezzzzzzzh_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> ezzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? ezzzzzzzj_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> ezzzzzzzl_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string ezzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzl_);
            bool? ezzzzzzzn_ = context.Operators.Equal(ezzzzzzzm_, "completed");
            DataType ezzzzzzzo_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> ezzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzo_);
            CqlDateTime ezzzzzzzq_ = context.Operators.End(ezzzzzzzp_);
            CqlInterval<CqlDateTime> ezzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzs_ = context.Operators.End(ezzzzzzzr_);
            bool? ezzzzzzzt_ = context.Operators.SameOrBefore(ezzzzzzzq_, ezzzzzzzs_, default);
            bool? ezzzzzzzu_ = context.Operators.And(ezzzzzzzn_, ezzzzzzzt_);

            return ezzzzzzzu_;
        };
        IEnumerable<Procedure> ezzzzzzzk_ = context.Operators.Where<Procedure>(ezzzzzzzi_, ezzzzzzzj_);

        return ezzzzzzzk_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet ezzzzzzzv_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> ezzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ezzzzzzzx_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> ezzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime fzzzzzzza_ = context.Operators.Start(ezzzzzzzz_);
            CqlInterval<CqlDateTime> fzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzc_ = context.Operators.End(fzzzzzzzb_);
            bool? fzzzzzzzd_ = context.Operators.SameOrBefore(fzzzzzzza_, fzzzzzzzc_, default);

            return fzzzzzzzd_;
        };
        IEnumerable<Condition> ezzzzzzzy_ = context.Operators.Where<Condition>(ezzzzzzzw_, ezzzzzzzx_);

        return ezzzzzzzy_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet fzzzzzzze_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> fzzzzzzzf_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzze_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? fzzzzzzzg_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> fzzzzzzzi_ = BilateralMastectomyPerformed?.StatusElement;
            string fzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzi_);
            bool? fzzzzzzzk_ = context.Operators.Equal(fzzzzzzzj_, "completed");
            DataType fzzzzzzzl_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> fzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzzzzl_);
            CqlDateTime fzzzzzzzn_ = context.Operators.End(fzzzzzzzm_);
            CqlInterval<CqlDateTime> fzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzp_ = context.Operators.End(fzzzzzzzo_);
            bool? fzzzzzzzq_ = context.Operators.SameOrBefore(fzzzzzzzn_, fzzzzzzzp_, default);
            bool? fzzzzzzzr_ = context.Operators.And(fzzzzzzzk_, fzzzzzzzq_);

            return fzzzzzzzr_;
        };
        IEnumerable<Procedure> fzzzzzzzh_ = context.Operators.Where<Procedure>(fzzzzzzzf_, fzzzzzzzg_);

        return fzzzzzzzh_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? fzzzzzzzs_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> fzzzzzzzt_ = this.Right_Mastectomy_Diagnosis(context);
        bool? fzzzzzzzu_ = context.Operators.Exists<Condition>(fzzzzzzzt_);
        IEnumerable<Procedure> fzzzzzzzv_ = this.Right_Mastectomy_Procedure(context);
        bool? fzzzzzzzw_ = context.Operators.Exists<Procedure>(fzzzzzzzv_);
        bool? fzzzzzzzx_ = context.Operators.Or(fzzzzzzzu_, fzzzzzzzw_);
        IEnumerable<Condition> fzzzzzzzy_ = this.Left_Mastectomy_Diagnosis(context);
        bool? fzzzzzzzz_ = context.Operators.Exists<Condition>(fzzzzzzzy_);
        IEnumerable<Procedure> gzzzzzzza_ = this.Left_Mastectomy_Procedure(context);
        bool? gzzzzzzzb_ = context.Operators.Exists<Procedure>(gzzzzzzza_);
        bool? gzzzzzzzc_ = context.Operators.Or(fzzzzzzzz_, gzzzzzzzb_);
        bool? gzzzzzzzd_ = context.Operators.And(fzzzzzzzx_, gzzzzzzzc_);
        bool? gzzzzzzze_ = context.Operators.Or(fzzzzzzzs_, gzzzzzzzd_);
        IEnumerable<Condition> gzzzzzzzf_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? gzzzzzzzg_ = context.Operators.Exists<Condition>(gzzzzzzzf_);
        bool? gzzzzzzzh_ = context.Operators.Or(gzzzzzzze_, gzzzzzzzg_);
        IEnumerable<Procedure> gzzzzzzzi_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? gzzzzzzzj_ = context.Operators.Exists<Procedure>(gzzzzzzzi_);
        bool? gzzzzzzzk_ = context.Operators.Or(gzzzzzzzh_, gzzzzzzzj_);
        bool? gzzzzzzzl_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? gzzzzzzzm_ = context.Operators.Or(gzzzzzzzk_, gzzzzzzzl_);
        Patient gzzzzzzzn_ = this.Patient(context);
        Date gzzzzzzzo_ = gzzzzzzzn_?.BirthDateElement;
        string gzzzzzzzp_ = gzzzzzzzo_?.Value;
        CqlDate gzzzzzzzq_ = context.Operators.ConvertStringToDate(gzzzzzzzp_);
        CqlInterval<CqlDateTime> gzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzs_ = context.Operators.Start(gzzzzzzzr_);
        CqlDate gzzzzzzzt_ = context.Operators.DateFrom(gzzzzzzzs_);
        int? gzzzzzzzu_ = context.Operators.CalculateAgeAt(gzzzzzzzq_, gzzzzzzzt_, "year");
        bool? gzzzzzzzv_ = context.Operators.GreaterOrEqual(gzzzzzzzu_, 65);
        bool? gzzzzzzzw_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? gzzzzzzzx_ = context.Operators.And(gzzzzzzzv_, gzzzzzzzw_);
        bool? gzzzzzzzy_ = context.Operators.Or(gzzzzzzzm_, gzzzzzzzx_);
        bool? gzzzzzzzz_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? hzzzzzzza_ = context.Operators.Or(gzzzzzzzy_, gzzzzzzzz_);

        return hzzzzzzza_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet hzzzzzzzb_ = this.Mammography(context);
        IEnumerable<Observation> hzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? hzzzzzzzd_(Observation Mammogram)
        {
            Code<ObservationStatus> hzzzzzzzg_ = Mammogram?.StatusElement;
            string hzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzg_);
            string[] hzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? hzzzzzzzj_ = context.Operators.In<string>(hzzzzzzzh_, hzzzzzzzi_ as IEnumerable<string>);
            DataType hzzzzzzzk_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> hzzzzzzzl_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzk_);
            CqlDateTime hzzzzzzzm_ = context.Operators.End(hzzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzo_ = context.Operators.End(hzzzzzzzn_);
            CqlQuantity hzzzzzzzp_ = context.Operators.Quantity(27m, "months");
            CqlDateTime hzzzzzzzq_ = context.Operators.Subtract(hzzzzzzzo_, hzzzzzzzp_);
            CqlDateTime hzzzzzzzs_ = context.Operators.End(hzzzzzzzn_);
            CqlInterval<CqlDateTime> hzzzzzzzt_ = context.Operators.Interval(hzzzzzzzq_, hzzzzzzzs_, true, true);
            bool? hzzzzzzzu_ = context.Operators.In<CqlDateTime>(hzzzzzzzm_, hzzzzzzzt_, default);
            CqlDateTime hzzzzzzzw_ = context.Operators.End(hzzzzzzzn_);
            bool? hzzzzzzzx_ = context.Operators.Not((bool?)(hzzzzzzzw_ is null));
            bool? hzzzzzzzy_ = context.Operators.And(hzzzzzzzu_, hzzzzzzzx_);
            bool? hzzzzzzzz_ = context.Operators.And(hzzzzzzzj_, hzzzzzzzy_);

            return hzzzzzzzz_;
        };
        IEnumerable<Observation> hzzzzzzze_ = context.Operators.Where<Observation>(hzzzzzzzc_, hzzzzzzzd_);
        bool? hzzzzzzzf_ = context.Operators.Exists<Observation>(hzzzzzzze_);

        return hzzzzzzzf_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet izzzzzzza_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> izzzzzzzb_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, izzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? izzzzzzzc_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> izzzzzzzf_ = Mammogram?.StatusElement;
            string izzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzf_);
            string[] izzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? izzzzzzzi_ = context.Operators.In<string>(izzzzzzzg_, izzzzzzzh_ as IEnumerable<string>);
            DataType izzzzzzzj_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> izzzzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzzzzj_);
            CqlDateTime izzzzzzzl_ = context.Operators.End(izzzzzzzk_);
            CqlInterval<CqlDateTime> izzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzn_ = context.Operators.End(izzzzzzzm_);
            CqlQuantity izzzzzzzo_ = context.Operators.Quantity(27m, "months");
            CqlDateTime izzzzzzzp_ = context.Operators.Subtract(izzzzzzzn_, izzzzzzzo_);
            CqlDateTime izzzzzzzr_ = context.Operators.End(izzzzzzzm_);
            CqlInterval<CqlDateTime> izzzzzzzs_ = context.Operators.Interval(izzzzzzzp_, izzzzzzzr_, true, true);
            bool? izzzzzzzt_ = context.Operators.In<CqlDateTime>(izzzzzzzl_, izzzzzzzs_, default);
            CqlDateTime izzzzzzzv_ = context.Operators.End(izzzzzzzm_);
            bool? izzzzzzzw_ = context.Operators.Not((bool?)(izzzzzzzv_ is null));
            bool? izzzzzzzx_ = context.Operators.And(izzzzzzzt_, izzzzzzzw_);
            bool? izzzzzzzy_ = context.Operators.And(izzzzzzzi_, izzzzzzzx_);

            return izzzzzzzy_;
        };
        IEnumerable<DiagnosticReport> izzzzzzzd_ = context.Operators.Where<DiagnosticReport>(izzzzzzzb_, izzzzzzzc_);
        bool? izzzzzzze_ = context.Operators.Exists<DiagnosticReport>(izzzzzzzd_);

        return izzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? izzzzzzzz_ = this.Observation_with_status(context);
        bool? jzzzzzzza_ = this.Diagnostic_Report_with_status(context);
        bool? jzzzzzzzb_ = context.Operators.Or(izzzzzzzz_, jzzzzzzza_);

        return jzzzzzzzb_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? jzzzzzzzc_ = this.Numerator(context);
        bool? jzzzzzzzd_ = this.Initial_Population(context);
        bool? jzzzzzzze_ = context.Operators.And(jzzzzzzzc_, jzzzzzzzd_);
        bool? jzzzzzzzf_ = this.Denominator(context);
        bool? jzzzzzzzg_ = context.Operators.And(jzzzzzzze_, jzzzzzzzf_);
        bool? jzzzzzzzh_ = this.Denominator_Exclusions(context);
        bool? jzzzzzzzi_ = context.Operators.Not(jzzzzzzzh_);
        bool? jzzzzzzzj_ = context.Operators.And(jzzzzzzzg_, jzzzzzzzi_);

        return jzzzzzzzj_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet jzzzzzzzk_ = this.Mammography(context);
        IEnumerable<Observation> jzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? jzzzzzzzm_(Observation Mammogram)
        {
            Code<ObservationStatus> jzzzzzzzp_ = Mammogram?.StatusElement;
            string jzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzp_);
            string[] jzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? jzzzzzzzs_ = context.Operators.In<string>(jzzzzzzzq_, jzzzzzzzr_ as IEnumerable<string>);
            bool? jzzzzzzzt_ = context.Operators.Not(jzzzzzzzs_);
            DataType jzzzzzzzu_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> jzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzu_);
            CqlDateTime jzzzzzzzw_ = context.Operators.End(jzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzy_ = context.Operators.End(jzzzzzzzx_);
            CqlQuantity jzzzzzzzz_ = context.Operators.Quantity(27m, "months");
            CqlDateTime kzzzzzzza_ = context.Operators.Subtract(jzzzzzzzy_, jzzzzzzzz_);
            CqlDateTime kzzzzzzzc_ = context.Operators.End(jzzzzzzzx_);
            CqlInterval<CqlDateTime> kzzzzzzzd_ = context.Operators.Interval(kzzzzzzza_, kzzzzzzzc_, true, true);
            bool? kzzzzzzze_ = context.Operators.In<CqlDateTime>(jzzzzzzzw_, kzzzzzzzd_, default);
            CqlDateTime kzzzzzzzg_ = context.Operators.End(jzzzzzzzx_);
            bool? kzzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzzg_ is null));
            bool? kzzzzzzzi_ = context.Operators.And(kzzzzzzze_, kzzzzzzzh_);
            bool? kzzzzzzzj_ = context.Operators.And(jzzzzzzzt_, kzzzzzzzi_);

            return kzzzzzzzj_;
        };
        IEnumerable<Observation> jzzzzzzzn_ = context.Operators.Where<Observation>(jzzzzzzzl_, jzzzzzzzm_);
        bool? jzzzzzzzo_ = context.Operators.Exists<Observation>(jzzzzzzzn_);

        return jzzzzzzzo_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet kzzzzzzzk_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> kzzzzzzzl_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, kzzzzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? kzzzzzzzm_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> kzzzzzzzp_ = Mammogram?.StatusElement;
            string kzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzp_);
            string[] kzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? kzzzzzzzs_ = context.Operators.In<string>(kzzzzzzzq_, kzzzzzzzr_ as IEnumerable<string>);
            bool? kzzzzzzzt_ = context.Operators.Not(kzzzzzzzs_);
            DataType kzzzzzzzu_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> kzzzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzu_);
            CqlDateTime kzzzzzzzw_ = context.Operators.End(kzzzzzzzv_);
            CqlInterval<CqlDateTime> kzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzy_ = context.Operators.End(kzzzzzzzx_);
            CqlQuantity kzzzzzzzz_ = context.Operators.Quantity(27m, "months");
            CqlDateTime lzzzzzzza_ = context.Operators.Subtract(kzzzzzzzy_, kzzzzzzzz_);
            CqlDateTime lzzzzzzzc_ = context.Operators.End(kzzzzzzzx_);
            CqlInterval<CqlDateTime> lzzzzzzzd_ = context.Operators.Interval(lzzzzzzza_, lzzzzzzzc_, true, true);
            bool? lzzzzzzze_ = context.Operators.In<CqlDateTime>(kzzzzzzzw_, lzzzzzzzd_, default);
            CqlDateTime lzzzzzzzg_ = context.Operators.End(kzzzzzzzx_);
            bool? lzzzzzzzh_ = context.Operators.Not((bool?)(lzzzzzzzg_ is null));
            bool? lzzzzzzzi_ = context.Operators.And(lzzzzzzze_, lzzzzzzzh_);
            bool? lzzzzzzzj_ = context.Operators.And(kzzzzzzzt_, lzzzzzzzi_);

            return lzzzzzzzj_;
        };
        IEnumerable<DiagnosticReport> kzzzzzzzn_ = context.Operators.Where<DiagnosticReport>(kzzzzzzzl_, kzzzzzzzm_);
        bool? kzzzzzzzo_ = context.Operators.Exists<DiagnosticReport>(kzzzzzzzn_);

        return kzzzzzzzo_;
    }


    #endregion Expressions

}
