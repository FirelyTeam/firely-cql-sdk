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
        CqlDateTime zzzzzzzzzq_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime zzzzzzzzzr_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> zzzzzzzzzs_ = context.Operators.Interval(zzzzzzzzzq_, zzzzzzzzzr_, true, false);
        object zzzzzzzzzt_ = context.ResolveParameter("Exam125FHIR-0.0.009", "Measurement Period", zzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient zzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzu_);

        return zzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> zzzzzzzzzw_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> zzzzzzzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return zzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> zzzzzzzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return zzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return zzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet azzzzzzzzza_ = this.Online_Assessments(context);
        IEnumerable<Encounter> azzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet azzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> azzzzzzzzze_ = context.Operators.Union<Encounter>(azzzzzzzzzb_, azzzzzzzzzd_);
        bool? azzzzzzzzzf_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> azzzzzzzzzh_ = TelehealthEncounter?.StatusElement;
            string azzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzh_);
            bool? azzzzzzzzzj_ = context.Operators.Equal(azzzzzzzzzi_, "finished");
            CqlInterval<CqlDateTime> azzzzzzzzzk_ = this.Measurement_Period(context);
            Period azzzzzzzzzl_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzl_ as object);
            bool? azzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzk_, azzzzzzzzzm_, default);
            bool? azzzzzzzzzo_ = context.Operators.And(azzzzzzzzzj_, azzzzzzzzzn_);

            return azzzzzzzzzo_;
        };
        IEnumerable<Encounter> azzzzzzzzzg_ = context.Operators.Where<Encounter>(azzzzzzzzze_, azzzzzzzzzf_);

        return azzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient azzzzzzzzzp_ = this.Patient(context);
        Date azzzzzzzzzq_ = azzzzzzzzzp_?.BirthDateElement;
        string azzzzzzzzzr_ = azzzzzzzzzq_?.Value;
        CqlDate azzzzzzzzzs_ = context.Operators.ConvertStringToDate(azzzzzzzzzr_);
        CqlInterval<CqlDateTime> azzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzt_);
        CqlDate azzzzzzzzzv_ = context.Operators.DateFrom(azzzzzzzzzu_);
        int? azzzzzzzzzw_ = context.Operators.CalculateAgeAt(azzzzzzzzzs_, azzzzzzzzzv_, "year");

        return azzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient azzzzzzzzzx_ = this.Patient(context);
        Date azzzzzzzzzy_ = azzzzzzzzzx_?.BirthDateElement;
        string azzzzzzzzzz_ = azzzzzzzzzy_?.Value;
        CqlDate bzzzzzzzzza_ = context.Operators.ConvertStringToDate(azzzzzzzzzz_);
        CqlInterval<CqlDateTime> bzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzc_ = context.Operators.Start(bzzzzzzzzzb_);
        CqlDate bzzzzzzzzzd_ = context.Operators.DateFrom(bzzzzzzzzzc_);
        int? bzzzzzzzzze_ = context.Operators.CalculateAgeAt(bzzzzzzzzza_, bzzzzzzzzzd_, "year");
        CqlInterval<int?> bzzzzzzzzzf_ = context.Operators.Interval(51, 74, true, false);
        bool? bzzzzzzzzzg_ = context.Operators.In<int?>(bzzzzzzzzze_, bzzzzzzzzzf_, default);
        Code<AdministrativeGender> bzzzzzzzzzi_ = azzzzzzzzzx_?.GenderElement;
        string bzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzi_);
        bool? bzzzzzzzzzk_ = context.Operators.Equal(bzzzzzzzzzj_, "female");
        bool? bzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzg_, bzzzzzzzzzk_);
        IEnumerable<Encounter> bzzzzzzzzzm_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> bzzzzzzzzzn_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> bzzzzzzzzzo_ = context.Operators.Union<Encounter>(bzzzzzzzzzm_, bzzzzzzzzzn_);
        bool? bzzzzzzzzzp_ = context.Operators.Exists<Encounter>(bzzzzzzzzzo_);
        bool? bzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzl_, bzzzzzzzzzp_);

        return bzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzr_ = this.Initial_Population(context);

        return bzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzs_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> bzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet bzzzzzzzzzu_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> bzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? bzzzzzzzzzw_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> czzzzzzzzzb_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept czzzzzzzzzc_(CodeableConcept X)
            {
                CqlConcept czzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return czzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzb_, czzzzzzzzzc_);
            CqlValueSet czzzzzzzzze_ = this.Right(context);
            bool? czzzzzzzzzf_ = context.Operators.ConceptsInValueSet(czzzzzzzzzd_, czzzzzzzzze_);

            return czzzzzzzzzf_;
        };
        IEnumerable<Condition> bzzzzzzzzzx_ = context.Operators.Where<Condition>(bzzzzzzzzzv_, bzzzzzzzzzw_);
        IEnumerable<Condition> bzzzzzzzzzy_ = context.Operators.Union<Condition>(bzzzzzzzzzt_, bzzzzzzzzzx_);
        bool? bzzzzzzzzzz_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime czzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzh_);
            CqlInterval<CqlDateTime> czzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzk_ = context.Operators.End(czzzzzzzzzj_);
            bool? czzzzzzzzzl_ = context.Operators.SameOrBefore(czzzzzzzzzi_, czzzzzzzzzk_, default);

            return czzzzzzzzzl_;
        };
        IEnumerable<Condition> czzzzzzzzza_ = context.Operators.Where<Condition>(bzzzzzzzzzy_, bzzzzzzzzzz_);

        return czzzzzzzzza_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet czzzzzzzzzm_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> czzzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, czzzzzzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? czzzzzzzzzo_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> czzzzzzzzzq_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string czzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzq_);
            bool? czzzzzzzzzs_ = context.Operators.Equal(czzzzzzzzzr_, "completed");
            DataType czzzzzzzzzt_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> czzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, czzzzzzzzzt_);
            CqlDateTime czzzzzzzzzv_ = context.Operators.End(czzzzzzzzzu_);
            CqlInterval<CqlDateTime> czzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzx_ = context.Operators.End(czzzzzzzzzw_);
            bool? czzzzzzzzzy_ = context.Operators.SameOrBefore(czzzzzzzzzv_, czzzzzzzzzx_, default);
            bool? czzzzzzzzzz_ = context.Operators.And(czzzzzzzzzs_, czzzzzzzzzy_);

            return czzzzzzzzzz_;
        };
        IEnumerable<Procedure> czzzzzzzzzp_ = context.Operators.Where<Procedure>(czzzzzzzzzn_, czzzzzzzzzo_);

        return czzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet dzzzzzzzzza_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> dzzzzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet dzzzzzzzzzc_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> dzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? dzzzzzzzzze_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> dzzzzzzzzzj_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept dzzzzzzzzzk_(CodeableConcept X)
            {
                CqlConcept dzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return dzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzj_, dzzzzzzzzzk_);
            CqlValueSet dzzzzzzzzzm_ = this.Left(context);
            bool? dzzzzzzzzzn_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzl_, dzzzzzzzzzm_);

            return dzzzzzzzzzn_;
        };
        IEnumerable<Condition> dzzzzzzzzzf_ = context.Operators.Where<Condition>(dzzzzzzzzzd_, dzzzzzzzzze_);
        IEnumerable<Condition> dzzzzzzzzzg_ = context.Operators.Union<Condition>(dzzzzzzzzzb_, dzzzzzzzzzf_);
        bool? dzzzzzzzzzh_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime dzzzzzzzzzq_ = context.Operators.Start(dzzzzzzzzzp_);
            CqlInterval<CqlDateTime> dzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzs_ = context.Operators.End(dzzzzzzzzzr_);
            bool? dzzzzzzzzzt_ = context.Operators.SameOrBefore(dzzzzzzzzzq_, dzzzzzzzzzs_, default);

            return dzzzzzzzzzt_;
        };
        IEnumerable<Condition> dzzzzzzzzzi_ = context.Operators.Where<Condition>(dzzzzzzzzzg_, dzzzzzzzzzh_);

        return dzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzu_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> dzzzzzzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? dzzzzzzzzzw_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> dzzzzzzzzzy_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string dzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzzzzzzy_);
            bool? ezzzzzzzzza_ = context.Operators.Equal(dzzzzzzzzzz_, "completed");
            DataType ezzzzzzzzzb_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> ezzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzb_);
            CqlDateTime ezzzzzzzzzd_ = context.Operators.End(ezzzzzzzzzc_);
            CqlInterval<CqlDateTime> ezzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzf_ = context.Operators.End(ezzzzzzzzze_);
            bool? ezzzzzzzzzg_ = context.Operators.SameOrBefore(ezzzzzzzzzd_, ezzzzzzzzzf_, default);
            bool? ezzzzzzzzzh_ = context.Operators.And(ezzzzzzzzza_, ezzzzzzzzzg_);

            return ezzzzzzzzzh_;
        };
        IEnumerable<Procedure> dzzzzzzzzzx_ = context.Operators.Where<Procedure>(dzzzzzzzzzv_, dzzzzzzzzzw_);

        return dzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzi_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> ezzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? ezzzzzzzzzk_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime ezzzzzzzzzn_ = context.Operators.Start(ezzzzzzzzzm_);
            CqlInterval<CqlDateTime> ezzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzp_ = context.Operators.End(ezzzzzzzzzo_);
            bool? ezzzzzzzzzq_ = context.Operators.SameOrBefore(ezzzzzzzzzn_, ezzzzzzzzzp_, default);

            return ezzzzzzzzzq_;
        };
        IEnumerable<Condition> ezzzzzzzzzl_ = context.Operators.Where<Condition>(ezzzzzzzzzj_, ezzzzzzzzzk_);

        return ezzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzr_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> ezzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? ezzzzzzzzzt_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> ezzzzzzzzzv_ = BilateralMastectomyPerformed?.StatusElement;
            string ezzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzv_);
            bool? ezzzzzzzzzx_ = context.Operators.Equal(ezzzzzzzzzw_, "completed");
            DataType ezzzzzzzzzy_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> ezzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzzzzzzy_);
            CqlDateTime fzzzzzzzzza_ = context.Operators.End(ezzzzzzzzzz_);
            CqlInterval<CqlDateTime> fzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzc_ = context.Operators.End(fzzzzzzzzzb_);
            bool? fzzzzzzzzzd_ = context.Operators.SameOrBefore(fzzzzzzzzza_, fzzzzzzzzzc_, default);
            bool? fzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzx_, fzzzzzzzzzd_);

            return fzzzzzzzzze_;
        };
        IEnumerable<Procedure> ezzzzzzzzzu_ = context.Operators.Where<Procedure>(ezzzzzzzzzs_, ezzzzzzzzzt_);

        return ezzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? fzzzzzzzzzf_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> fzzzzzzzzzg_ = this.Right_Mastectomy_Diagnosis(context);
        bool? fzzzzzzzzzh_ = context.Operators.Exists<Condition>(fzzzzzzzzzg_);
        IEnumerable<Procedure> fzzzzzzzzzi_ = this.Right_Mastectomy_Procedure(context);
        bool? fzzzzzzzzzj_ = context.Operators.Exists<Procedure>(fzzzzzzzzzi_);
        bool? fzzzzzzzzzk_ = context.Operators.Or(fzzzzzzzzzh_, fzzzzzzzzzj_);
        IEnumerable<Condition> fzzzzzzzzzl_ = this.Left_Mastectomy_Diagnosis(context);
        bool? fzzzzzzzzzm_ = context.Operators.Exists<Condition>(fzzzzzzzzzl_);
        IEnumerable<Procedure> fzzzzzzzzzn_ = this.Left_Mastectomy_Procedure(context);
        bool? fzzzzzzzzzo_ = context.Operators.Exists<Procedure>(fzzzzzzzzzn_);
        bool? fzzzzzzzzzp_ = context.Operators.Or(fzzzzzzzzzm_, fzzzzzzzzzo_);
        bool? fzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzk_, fzzzzzzzzzp_);
        bool? fzzzzzzzzzr_ = context.Operators.Or(fzzzzzzzzzf_, fzzzzzzzzzq_);
        IEnumerable<Condition> fzzzzzzzzzs_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? fzzzzzzzzzt_ = context.Operators.Exists<Condition>(fzzzzzzzzzs_);
        bool? fzzzzzzzzzu_ = context.Operators.Or(fzzzzzzzzzr_, fzzzzzzzzzt_);
        IEnumerable<Procedure> fzzzzzzzzzv_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? fzzzzzzzzzw_ = context.Operators.Exists<Procedure>(fzzzzzzzzzv_);
        bool? fzzzzzzzzzx_ = context.Operators.Or(fzzzzzzzzzu_, fzzzzzzzzzw_);
        bool? fzzzzzzzzzy_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? fzzzzzzzzzz_ = context.Operators.Or(fzzzzzzzzzx_, fzzzzzzzzzy_);
        Patient gzzzzzzzzza_ = this.Patient(context);
        Date gzzzzzzzzzb_ = gzzzzzzzzza_?.BirthDateElement;
        string gzzzzzzzzzc_ = gzzzzzzzzzb_?.Value;
        CqlDate gzzzzzzzzzd_ = context.Operators.ConvertStringToDate(gzzzzzzzzzc_);
        CqlInterval<CqlDateTime> gzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzzzf_ = context.Operators.Start(gzzzzzzzzze_);
        CqlDate gzzzzzzzzzg_ = context.Operators.DateFrom(gzzzzzzzzzf_);
        int? gzzzzzzzzzh_ = context.Operators.CalculateAgeAt(gzzzzzzzzzd_, gzzzzzzzzzg_, "year");
        bool? gzzzzzzzzzi_ = context.Operators.GreaterOrEqual(gzzzzzzzzzh_, 65);
        bool? gzzzzzzzzzj_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? gzzzzzzzzzk_ = context.Operators.And(gzzzzzzzzzi_, gzzzzzzzzzj_);
        bool? gzzzzzzzzzl_ = context.Operators.Or(fzzzzzzzzzz_, gzzzzzzzzzk_);
        bool? gzzzzzzzzzm_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? gzzzzzzzzzn_ = context.Operators.Or(gzzzzzzzzzl_, gzzzzzzzzzm_);

        return gzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzo_ = this.Mammography(context);
        IEnumerable<Observation> gzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? gzzzzzzzzzq_(Observation Mammogram)
        {
            Code<ObservationStatus> gzzzzzzzzzt_ = Mammogram?.StatusElement;
            string gzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzt_);
            string[] gzzzzzzzzzv_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? gzzzzzzzzzw_ = context.Operators.In<string>(gzzzzzzzzzu_, gzzzzzzzzzv_ as IEnumerable<string>);
            DataType gzzzzzzzzzx_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> gzzzzzzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzzzzzzx_);
            CqlDateTime gzzzzzzzzzz_ = context.Operators.End(gzzzzzzzzzy_);
            CqlInterval<CqlDateTime> hzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzb_ = context.Operators.End(hzzzzzzzzza_);
            CqlQuantity hzzzzzzzzzc_ = context.Operators.Quantity(27m, "months");
            CqlDateTime hzzzzzzzzzd_ = context.Operators.Subtract(hzzzzzzzzzb_, hzzzzzzzzzc_);
            CqlDateTime hzzzzzzzzzf_ = context.Operators.End(hzzzzzzzzza_);
            CqlInterval<CqlDateTime> hzzzzzzzzzg_ = context.Operators.Interval(hzzzzzzzzzd_, hzzzzzzzzzf_, true, true);
            bool? hzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzz_, hzzzzzzzzzg_, default);
            CqlDateTime hzzzzzzzzzj_ = context.Operators.End(hzzzzzzzzza_);
            bool? hzzzzzzzzzk_ = context.Operators.Not((bool?)(hzzzzzzzzzj_ is null));
            bool? hzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzh_, hzzzzzzzzzk_);
            bool? hzzzzzzzzzm_ = context.Operators.And(gzzzzzzzzzw_, hzzzzzzzzzl_);

            return hzzzzzzzzzm_;
        };
        IEnumerable<Observation> gzzzzzzzzzr_ = context.Operators.Where<Observation>(gzzzzzzzzzp_, gzzzzzzzzzq_);
        bool? gzzzzzzzzzs_ = context.Operators.Exists<Observation>(gzzzzzzzzzr_);

        return gzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzn_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> hzzzzzzzzzo_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, hzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? hzzzzzzzzzp_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> hzzzzzzzzzs_ = Mammogram?.StatusElement;
            string hzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzzzzzzs_);
            string[] hzzzzzzzzzu_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? hzzzzzzzzzv_ = context.Operators.In<string>(hzzzzzzzzzt_, hzzzzzzzzzu_ as IEnumerable<string>);
            DataType hzzzzzzzzzw_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> hzzzzzzzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzzzzzzw_);
            CqlDateTime hzzzzzzzzzy_ = context.Operators.End(hzzzzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzza_ = context.Operators.End(hzzzzzzzzzz_);
            CqlQuantity izzzzzzzzzb_ = context.Operators.Quantity(27m, "months");
            CqlDateTime izzzzzzzzzc_ = context.Operators.Subtract(izzzzzzzzza_, izzzzzzzzzb_);
            CqlDateTime izzzzzzzzze_ = context.Operators.End(hzzzzzzzzzz_);
            CqlInterval<CqlDateTime> izzzzzzzzzf_ = context.Operators.Interval(izzzzzzzzzc_, izzzzzzzzze_, true, true);
            bool? izzzzzzzzzg_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzy_, izzzzzzzzzf_, default);
            CqlDateTime izzzzzzzzzi_ = context.Operators.End(hzzzzzzzzzz_);
            bool? izzzzzzzzzj_ = context.Operators.Not((bool?)(izzzzzzzzzi_ is null));
            bool? izzzzzzzzzk_ = context.Operators.And(izzzzzzzzzg_, izzzzzzzzzj_);
            bool? izzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzv_, izzzzzzzzzk_);

            return izzzzzzzzzl_;
        };
        IEnumerable<DiagnosticReport> hzzzzzzzzzq_ = context.Operators.Where<DiagnosticReport>(hzzzzzzzzzo_, hzzzzzzzzzp_);
        bool? hzzzzzzzzzr_ = context.Operators.Exists<DiagnosticReport>(hzzzzzzzzzq_);

        return hzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? izzzzzzzzzm_ = this.Observation_with_status(context);
        bool? izzzzzzzzzn_ = this.Diagnostic_Report_with_status(context);
        bool? izzzzzzzzzo_ = context.Operators.Or(izzzzzzzzzm_, izzzzzzzzzn_);

        return izzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? izzzzzzzzzp_ = this.Numerator(context);
        bool? izzzzzzzzzq_ = this.Initial_Population(context);
        bool? izzzzzzzzzr_ = context.Operators.And(izzzzzzzzzp_, izzzzzzzzzq_);
        bool? izzzzzzzzzs_ = this.Denominator(context);
        bool? izzzzzzzzzt_ = context.Operators.And(izzzzzzzzzr_, izzzzzzzzzs_);
        bool? izzzzzzzzzu_ = this.Denominator_Exclusions(context);
        bool? izzzzzzzzzv_ = context.Operators.Not(izzzzzzzzzu_);
        bool? izzzzzzzzzw_ = context.Operators.And(izzzzzzzzzt_, izzzzzzzzzv_);

        return izzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet izzzzzzzzzx_ = this.Mammography(context);
        IEnumerable<Observation> izzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? izzzzzzzzzz_(Observation Mammogram)
        {
            Code<ObservationStatus> jzzzzzzzzzc_ = Mammogram?.StatusElement;
            string jzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzzc_);
            string[] jzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? jzzzzzzzzzf_ = context.Operators.In<string>(jzzzzzzzzzd_, jzzzzzzzzze_ as IEnumerable<string>);
            bool? jzzzzzzzzzg_ = context.Operators.Not(jzzzzzzzzzf_);
            DataType jzzzzzzzzzh_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> jzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzzzzzzh_);
            CqlDateTime jzzzzzzzzzj_ = context.Operators.End(jzzzzzzzzzi_);
            CqlInterval<CqlDateTime> jzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzl_ = context.Operators.End(jzzzzzzzzzk_);
            CqlQuantity jzzzzzzzzzm_ = context.Operators.Quantity(27m, "months");
            CqlDateTime jzzzzzzzzzn_ = context.Operators.Subtract(jzzzzzzzzzl_, jzzzzzzzzzm_);
            CqlDateTime jzzzzzzzzzp_ = context.Operators.End(jzzzzzzzzzk_);
            CqlInterval<CqlDateTime> jzzzzzzzzzq_ = context.Operators.Interval(jzzzzzzzzzn_, jzzzzzzzzzp_, true, true);
            bool? jzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzj_, jzzzzzzzzzq_, default);
            CqlDateTime jzzzzzzzzzt_ = context.Operators.End(jzzzzzzzzzk_);
            bool? jzzzzzzzzzu_ = context.Operators.Not((bool?)(jzzzzzzzzzt_ is null));
            bool? jzzzzzzzzzv_ = context.Operators.And(jzzzzzzzzzr_, jzzzzzzzzzu_);
            bool? jzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzg_, jzzzzzzzzzv_);

            return jzzzzzzzzzw_;
        };
        IEnumerable<Observation> jzzzzzzzzza_ = context.Operators.Where<Observation>(izzzzzzzzzy_, izzzzzzzzzz_);
        bool? jzzzzzzzzzb_ = context.Operators.Exists<Observation>(jzzzzzzzzza_);

        return jzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzx_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> jzzzzzzzzzy_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, jzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? jzzzzzzzzzz_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> kzzzzzzzzzc_ = Mammogram?.StatusElement;
            string kzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzc_);
            string[] kzzzzzzzzze_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? kzzzzzzzzzf_ = context.Operators.In<string>(kzzzzzzzzzd_, kzzzzzzzzze_ as IEnumerable<string>);
            bool? kzzzzzzzzzg_ = context.Operators.Not(kzzzzzzzzzf_);
            DataType kzzzzzzzzzh_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> kzzzzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzzzzzzh_);
            CqlDateTime kzzzzzzzzzj_ = context.Operators.End(kzzzzzzzzzi_);
            CqlInterval<CqlDateTime> kzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzl_ = context.Operators.End(kzzzzzzzzzk_);
            CqlQuantity kzzzzzzzzzm_ = context.Operators.Quantity(27m, "months");
            CqlDateTime kzzzzzzzzzn_ = context.Operators.Subtract(kzzzzzzzzzl_, kzzzzzzzzzm_);
            CqlDateTime kzzzzzzzzzp_ = context.Operators.End(kzzzzzzzzzk_);
            CqlInterval<CqlDateTime> kzzzzzzzzzq_ = context.Operators.Interval(kzzzzzzzzzn_, kzzzzzzzzzp_, true, true);
            bool? kzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzj_, kzzzzzzzzzq_, default);
            CqlDateTime kzzzzzzzzzt_ = context.Operators.End(kzzzzzzzzzk_);
            bool? kzzzzzzzzzu_ = context.Operators.Not((bool?)(kzzzzzzzzzt_ is null));
            bool? kzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzr_, kzzzzzzzzzu_);
            bool? kzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzg_, kzzzzzzzzzv_);

            return kzzzzzzzzzw_;
        };
        IEnumerable<DiagnosticReport> kzzzzzzzzza_ = context.Operators.Where<DiagnosticReport>(jzzzzzzzzzy_, jzzzzzzzzzz_);
        bool? kzzzzzzzzzb_ = context.Operators.Exists<DiagnosticReport>(kzzzzzzzzza_);

        return kzzzzzzzzzb_;
    }


    #endregion Expressions

}
