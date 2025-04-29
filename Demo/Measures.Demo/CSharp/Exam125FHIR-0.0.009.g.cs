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

    #region ValueSet: Left
    [CqlValueSetDefinition(
        definitionName: "Left",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036",
        valueSetVersion: null)]
    public CqlValueSet Left(CqlContext context) => _Left;

    private static readonly CqlValueSet _Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);
    #endregion

    #region ValueSet: Mammography
    [CqlValueSetDefinition(
        definitionName: "Mammography",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047",
        valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext context) => _Mammography;

    private static readonly CqlValueSet _Mammography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);
    #endregion

    #region ValueSet: Online Assessments
    [CqlValueSetDefinition(
        definitionName: "Online Assessments",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext context) => _Online_Assessments;

    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Right
    [CqlValueSetDefinition(
        definitionName: "Right",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035",
        valueSetVersion: null)]
    public CqlValueSet Right(CqlContext context) => _Right;

    private static readonly CqlValueSet _Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);
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

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
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

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzy_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime ezzzzz_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> fzzzza_ = context.Operators.Interval(ezzzzy_, ezzzzz_, true, false);
        object fzzzzb_ = context.ResolveParameter("Exam125FHIR-0.0.009", "Measurement Period", fzzzza_);

        return (CqlInterval<CqlDateTime>)fzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient fzzzzd_ = context.Operators.SingletonFrom<Patient>(fzzzzc_);

        return fzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> fzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return fzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> fzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return fzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> fzzzzg_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return fzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode fzzzzh_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return fzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet fzzzzi_ = this.Online_Assessments(context);
        IEnumerable<Encounter> fzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet fzzzzk_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> fzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> fzzzzm_ = context.Operators.Union<Encounter>(fzzzzj_, fzzzzl_);
        bool? fzzzzn_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> fzzzzp_ = TelehealthEncounter?.StatusElement;
            string fzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzp_);
            bool? fzzzzr_ = context.Operators.Equal(fzzzzq_, "finished");
            CqlInterval<CqlDateTime> fzzzzs_ = this.Measurement_Period(context);
            Period fzzzzt_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, fzzzzt_ as object);
            bool? fzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzs_, fzzzzu_, default);
            bool? fzzzzw_ = context.Operators.And(fzzzzr_, fzzzzv_);

            return fzzzzw_;
        };
        IEnumerable<Encounter> fzzzzo_ = context.Operators.Where<Encounter>(fzzzzm_, fzzzzn_);

        return fzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient fzzzzx_ = this.Patient(context);
        Date fzzzzy_ = fzzzzx_?.BirthDateElement;
        string fzzzzz_ = fzzzzy_?.Value;
        CqlDate gzzzza_ = context.Operators.ConvertStringToDate(fzzzzz_);
        CqlInterval<CqlDateTime> gzzzzb_ = this.Measurement_Period(context);
        CqlDateTime gzzzzc_ = context.Operators.Start(gzzzzb_);
        CqlDate gzzzzd_ = context.Operators.DateFrom(gzzzzc_);
        int? gzzzze_ = context.Operators.CalculateAgeAt(gzzzza_, gzzzzd_, "year");

        return gzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient gzzzzf_ = this.Patient(context);
        Date gzzzzg_ = gzzzzf_?.BirthDateElement;
        string gzzzzh_ = gzzzzg_?.Value;
        CqlDate gzzzzi_ = context.Operators.ConvertStringToDate(gzzzzh_);
        CqlInterval<CqlDateTime> gzzzzj_ = this.Measurement_Period(context);
        CqlDateTime gzzzzk_ = context.Operators.Start(gzzzzj_);
        CqlDate gzzzzl_ = context.Operators.DateFrom(gzzzzk_);
        int? gzzzzm_ = context.Operators.CalculateAgeAt(gzzzzi_, gzzzzl_, "year");
        CqlInterval<int?> gzzzzn_ = context.Operators.Interval(51, 74, true, false);
        bool? gzzzzo_ = context.Operators.In<int?>(gzzzzm_, gzzzzn_, default);
        Code<AdministrativeGender> gzzzzq_ = gzzzzf_?.GenderElement;
        string gzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzq_);
        bool? gzzzzs_ = context.Operators.Equal(gzzzzr_, "female");
        bool? gzzzzt_ = context.Operators.And(gzzzzo_, gzzzzs_);
        IEnumerable<Encounter> gzzzzu_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> gzzzzv_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> gzzzzw_ = context.Operators.Union<Encounter>(gzzzzu_, gzzzzv_);
        bool? gzzzzx_ = context.Operators.Exists<Encounter>(gzzzzw_);
        bool? gzzzzy_ = context.Operators.And(gzzzzt_, gzzzzx_);

        return gzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzzzz_ = this.Initial_Population(context);

        return gzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet hzzzza_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> hzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet hzzzzc_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> hzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? hzzzze_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> hzzzzj_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept hzzzzk_(CodeableConcept X)
            {
                CqlConcept hzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return hzzzzo_;
            };
            IEnumerable<CqlConcept> hzzzzl_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzzj_, hzzzzk_);
            CqlValueSet hzzzzm_ = this.Right(context);
            bool? hzzzzn_ = context.Operators.ConceptsInValueSet(hzzzzl_, hzzzzm_);

            return hzzzzn_;
        };
        IEnumerable<Condition> hzzzzf_ = context.Operators.Where<Condition>(hzzzzd_, hzzzze_);
        IEnumerable<Condition> hzzzzg_ = context.Operators.Union<Condition>(hzzzzb_, hzzzzf_);
        bool? hzzzzh_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> hzzzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime hzzzzq_ = context.Operators.Start(hzzzzp_);
            CqlInterval<CqlDateTime> hzzzzr_ = this.Measurement_Period(context);
            CqlDateTime hzzzzs_ = context.Operators.End(hzzzzr_);
            bool? hzzzzt_ = context.Operators.SameOrBefore(hzzzzq_, hzzzzs_, default);

            return hzzzzt_;
        };
        IEnumerable<Condition> hzzzzi_ = context.Operators.Where<Condition>(hzzzzg_, hzzzzh_);

        return hzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet hzzzzu_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> hzzzzv_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? hzzzzw_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> hzzzzy_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string hzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzy_);
            bool? izzzza_ = context.Operators.Equal(hzzzzz_, "completed");
            DataType izzzzb_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> izzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, izzzzb_);
            CqlDateTime izzzzd_ = context.Operators.End(izzzzc_);
            CqlInterval<CqlDateTime> izzzze_ = this.Measurement_Period(context);
            CqlDateTime izzzzf_ = context.Operators.End(izzzze_);
            bool? izzzzg_ = context.Operators.SameOrBefore(izzzzd_, izzzzf_, default);
            bool? izzzzh_ = context.Operators.And(izzzza_, izzzzg_);

            return izzzzh_;
        };
        IEnumerable<Procedure> hzzzzx_ = context.Operators.Where<Procedure>(hzzzzv_, hzzzzw_);

        return hzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet izzzzi_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> izzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet izzzzk_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> izzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzk_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? izzzzm_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> izzzzr_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept izzzzs_(CodeableConcept X)
            {
                CqlConcept izzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return izzzzw_;
            };
            IEnumerable<CqlConcept> izzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzr_, izzzzs_);
            CqlValueSet izzzzu_ = this.Left(context);
            bool? izzzzv_ = context.Operators.ConceptsInValueSet(izzzzt_, izzzzu_);

            return izzzzv_;
        };
        IEnumerable<Condition> izzzzn_ = context.Operators.Where<Condition>(izzzzl_, izzzzm_);
        IEnumerable<Condition> izzzzo_ = context.Operators.Union<Condition>(izzzzj_, izzzzn_);
        bool? izzzzp_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> izzzzx_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime izzzzy_ = context.Operators.Start(izzzzx_);
            CqlInterval<CqlDateTime> izzzzz_ = this.Measurement_Period(context);
            CqlDateTime jzzzza_ = context.Operators.End(izzzzz_);
            bool? jzzzzb_ = context.Operators.SameOrBefore(izzzzy_, jzzzza_, default);

            return jzzzzb_;
        };
        IEnumerable<Condition> izzzzq_ = context.Operators.Where<Condition>(izzzzo_, izzzzp_);

        return izzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet jzzzzc_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> jzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? jzzzze_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> jzzzzg_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string jzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzg_);
            bool? jzzzzi_ = context.Operators.Equal(jzzzzh_, "completed");
            DataType jzzzzj_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> jzzzzk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, jzzzzj_);
            CqlDateTime jzzzzl_ = context.Operators.End(jzzzzk_);
            CqlInterval<CqlDateTime> jzzzzm_ = this.Measurement_Period(context);
            CqlDateTime jzzzzn_ = context.Operators.End(jzzzzm_);
            bool? jzzzzo_ = context.Operators.SameOrBefore(jzzzzl_, jzzzzn_, default);
            bool? jzzzzp_ = context.Operators.And(jzzzzi_, jzzzzo_);

            return jzzzzp_;
        };
        IEnumerable<Procedure> jzzzzf_ = context.Operators.Where<Procedure>(jzzzzd_, jzzzze_);

        return jzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet jzzzzq_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> jzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? jzzzzs_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> jzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime jzzzzv_ = context.Operators.Start(jzzzzu_);
            CqlInterval<CqlDateTime> jzzzzw_ = this.Measurement_Period(context);
            CqlDateTime jzzzzx_ = context.Operators.End(jzzzzw_);
            bool? jzzzzy_ = context.Operators.SameOrBefore(jzzzzv_, jzzzzx_, default);

            return jzzzzy_;
        };
        IEnumerable<Condition> jzzzzt_ = context.Operators.Where<Condition>(jzzzzr_, jzzzzs_);

        return jzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet jzzzzz_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> kzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? kzzzzb_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> kzzzzd_ = BilateralMastectomyPerformed?.StatusElement;
            string kzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzd_);
            bool? kzzzzf_ = context.Operators.Equal(kzzzze_, "completed");
            DataType kzzzzg_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> kzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, kzzzzg_);
            CqlDateTime kzzzzi_ = context.Operators.End(kzzzzh_);
            CqlInterval<CqlDateTime> kzzzzj_ = this.Measurement_Period(context);
            CqlDateTime kzzzzk_ = context.Operators.End(kzzzzj_);
            bool? kzzzzl_ = context.Operators.SameOrBefore(kzzzzi_, kzzzzk_, default);
            bool? kzzzzm_ = context.Operators.And(kzzzzf_, kzzzzl_);

            return kzzzzm_;
        };
        IEnumerable<Procedure> kzzzzc_ = context.Operators.Where<Procedure>(kzzzza_, kzzzzb_);

        return kzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? kzzzzn_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> kzzzzo_ = this.Right_Mastectomy_Diagnosis(context);
        bool? kzzzzp_ = context.Operators.Exists<Condition>(kzzzzo_);
        IEnumerable<Procedure> kzzzzq_ = this.Right_Mastectomy_Procedure(context);
        bool? kzzzzr_ = context.Operators.Exists<Procedure>(kzzzzq_);
        bool? kzzzzs_ = context.Operators.Or(kzzzzp_, kzzzzr_);
        IEnumerable<Condition> kzzzzt_ = this.Left_Mastectomy_Diagnosis(context);
        bool? kzzzzu_ = context.Operators.Exists<Condition>(kzzzzt_);
        IEnumerable<Procedure> kzzzzv_ = this.Left_Mastectomy_Procedure(context);
        bool? kzzzzw_ = context.Operators.Exists<Procedure>(kzzzzv_);
        bool? kzzzzx_ = context.Operators.Or(kzzzzu_, kzzzzw_);
        bool? kzzzzy_ = context.Operators.And(kzzzzs_, kzzzzx_);
        bool? kzzzzz_ = context.Operators.Or(kzzzzn_, kzzzzy_);
        IEnumerable<Condition> lzzzza_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? lzzzzb_ = context.Operators.Exists<Condition>(lzzzza_);
        bool? lzzzzc_ = context.Operators.Or(kzzzzz_, lzzzzb_);
        IEnumerable<Procedure> lzzzzd_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? lzzzze_ = context.Operators.Exists<Procedure>(lzzzzd_);
        bool? lzzzzf_ = context.Operators.Or(lzzzzc_, lzzzze_);
        bool? lzzzzg_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? lzzzzh_ = context.Operators.Or(lzzzzf_, lzzzzg_);
        Patient lzzzzi_ = this.Patient(context);
        Date lzzzzj_ = lzzzzi_?.BirthDateElement;
        string lzzzzk_ = lzzzzj_?.Value;
        CqlDate lzzzzl_ = context.Operators.ConvertStringToDate(lzzzzk_);
        CqlInterval<CqlDateTime> lzzzzm_ = this.Measurement_Period(context);
        CqlDateTime lzzzzn_ = context.Operators.Start(lzzzzm_);
        CqlDate lzzzzo_ = context.Operators.DateFrom(lzzzzn_);
        int? lzzzzp_ = context.Operators.CalculateAgeAt(lzzzzl_, lzzzzo_, "year");
        bool? lzzzzq_ = context.Operators.GreaterOrEqual(lzzzzp_, 65);
        bool? lzzzzr_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? lzzzzs_ = context.Operators.And(lzzzzq_, lzzzzr_);
        bool? lzzzzt_ = context.Operators.Or(lzzzzh_, lzzzzs_);
        bool? lzzzzu_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? lzzzzv_ = context.Operators.Or(lzzzzt_, lzzzzu_);

        return lzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet lzzzzw_ = this.Mammography(context);
        IEnumerable<Observation> lzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? lzzzzy_(Observation Mammogram)
        {
            Code<ObservationStatus> mzzzzb_ = Mammogram?.StatusElement;
            string mzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzb_);
            string[] mzzzzd_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? mzzzze_ = context.Operators.In<string>(mzzzzc_, mzzzzd_ as IEnumerable<string>);
            DataType mzzzzf_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> mzzzzg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, mzzzzf_);
            CqlDateTime mzzzzh_ = context.Operators.End(mzzzzg_);
            CqlInterval<CqlDateTime> mzzzzi_ = this.Measurement_Period(context);
            CqlDateTime mzzzzj_ = context.Operators.End(mzzzzi_);
            CqlQuantity mzzzzk_ = context.Operators.Quantity(27m, "months");
            CqlDateTime mzzzzl_ = context.Operators.Subtract(mzzzzj_, mzzzzk_);
            CqlDateTime mzzzzn_ = context.Operators.End(mzzzzi_);
            CqlInterval<CqlDateTime> mzzzzo_ = context.Operators.Interval(mzzzzl_, mzzzzn_, true, true);
            bool? mzzzzp_ = context.Operators.In<CqlDateTime>(mzzzzh_, mzzzzo_, default);
            CqlDateTime mzzzzr_ = context.Operators.End(mzzzzi_);
            bool? mzzzzs_ = context.Operators.Not((bool?)(mzzzzr_ is null));
            bool? mzzzzt_ = context.Operators.And(mzzzzp_, mzzzzs_);
            bool? mzzzzu_ = context.Operators.And(mzzzze_, mzzzzt_);

            return mzzzzu_;
        };
        IEnumerable<Observation> lzzzzz_ = context.Operators.Where<Observation>(lzzzzx_, lzzzzy_);
        bool? mzzzza_ = context.Operators.Exists<Observation>(lzzzzz_);

        return mzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet mzzzzv_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> mzzzzw_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, mzzzzv_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? mzzzzx_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> nzzzza_ = Mammogram?.StatusElement;
            string nzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, nzzzza_);
            string[] nzzzzc_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? nzzzzd_ = context.Operators.In<string>(nzzzzb_, nzzzzc_ as IEnumerable<string>);
            DataType nzzzze_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> nzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, nzzzze_);
            CqlDateTime nzzzzg_ = context.Operators.End(nzzzzf_);
            CqlInterval<CqlDateTime> nzzzzh_ = this.Measurement_Period(context);
            CqlDateTime nzzzzi_ = context.Operators.End(nzzzzh_);
            CqlQuantity nzzzzj_ = context.Operators.Quantity(27m, "months");
            CqlDateTime nzzzzk_ = context.Operators.Subtract(nzzzzi_, nzzzzj_);
            CqlDateTime nzzzzm_ = context.Operators.End(nzzzzh_);
            CqlInterval<CqlDateTime> nzzzzn_ = context.Operators.Interval(nzzzzk_, nzzzzm_, true, true);
            bool? nzzzzo_ = context.Operators.In<CqlDateTime>(nzzzzg_, nzzzzn_, default);
            CqlDateTime nzzzzq_ = context.Operators.End(nzzzzh_);
            bool? nzzzzr_ = context.Operators.Not((bool?)(nzzzzq_ is null));
            bool? nzzzzs_ = context.Operators.And(nzzzzo_, nzzzzr_);
            bool? nzzzzt_ = context.Operators.And(nzzzzd_, nzzzzs_);

            return nzzzzt_;
        };
        IEnumerable<DiagnosticReport> mzzzzy_ = context.Operators.Where<DiagnosticReport>(mzzzzw_, mzzzzx_);
        bool? mzzzzz_ = context.Operators.Exists<DiagnosticReport>(mzzzzy_);

        return mzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? nzzzzu_ = this.Observation_with_status(context);
        bool? nzzzzv_ = this.Diagnostic_Report_with_status(context);
        bool? nzzzzw_ = context.Operators.Or(nzzzzu_, nzzzzv_);

        return nzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? nzzzzx_ = this.Numerator(context);
        bool? nzzzzy_ = this.Initial_Population(context);
        bool? nzzzzz_ = context.Operators.And(nzzzzx_, nzzzzy_);
        bool? ozzzza_ = this.Denominator(context);
        bool? ozzzzb_ = context.Operators.And(nzzzzz_, ozzzza_);
        bool? ozzzzc_ = this.Denominator_Exclusions(context);
        bool? ozzzzd_ = context.Operators.Not(ozzzzc_);
        bool? ozzzze_ = context.Operators.And(ozzzzb_, ozzzzd_);

        return ozzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet ozzzzf_ = this.Mammography(context);
        IEnumerable<Observation> ozzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? ozzzzh_(Observation Mammogram)
        {
            Code<ObservationStatus> ozzzzk_ = Mammogram?.StatusElement;
            string ozzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzk_);
            string[] ozzzzm_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ozzzzn_ = context.Operators.In<string>(ozzzzl_, ozzzzm_ as IEnumerable<string>);
            bool? ozzzzo_ = context.Operators.Not(ozzzzn_);
            DataType ozzzzp_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> ozzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ozzzzp_);
            CqlDateTime ozzzzr_ = context.Operators.End(ozzzzq_);
            CqlInterval<CqlDateTime> ozzzzs_ = this.Measurement_Period(context);
            CqlDateTime ozzzzt_ = context.Operators.End(ozzzzs_);
            CqlQuantity ozzzzu_ = context.Operators.Quantity(27m, "months");
            CqlDateTime ozzzzv_ = context.Operators.Subtract(ozzzzt_, ozzzzu_);
            CqlDateTime ozzzzx_ = context.Operators.End(ozzzzs_);
            CqlInterval<CqlDateTime> ozzzzy_ = context.Operators.Interval(ozzzzv_, ozzzzx_, true, true);
            bool? ozzzzz_ = context.Operators.In<CqlDateTime>(ozzzzr_, ozzzzy_, default);
            CqlDateTime pzzzzb_ = context.Operators.End(ozzzzs_);
            bool? pzzzzc_ = context.Operators.Not((bool?)(pzzzzb_ is null));
            bool? pzzzzd_ = context.Operators.And(ozzzzz_, pzzzzc_);
            bool? pzzzze_ = context.Operators.And(ozzzzo_, pzzzzd_);

            return pzzzze_;
        };
        IEnumerable<Observation> ozzzzi_ = context.Operators.Where<Observation>(ozzzzg_, ozzzzh_);
        bool? ozzzzj_ = context.Operators.Exists<Observation>(ozzzzi_);

        return ozzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet pzzzzf_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> pzzzzg_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, pzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? pzzzzh_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> pzzzzk_ = Mammogram?.StatusElement;
            string pzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzk_);
            string[] pzzzzm_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? pzzzzn_ = context.Operators.In<string>(pzzzzl_, pzzzzm_ as IEnumerable<string>);
            bool? pzzzzo_ = context.Operators.Not(pzzzzn_);
            DataType pzzzzp_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> pzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzp_);
            CqlDateTime pzzzzr_ = context.Operators.End(pzzzzq_);
            CqlInterval<CqlDateTime> pzzzzs_ = this.Measurement_Period(context);
            CqlDateTime pzzzzt_ = context.Operators.End(pzzzzs_);
            CqlQuantity pzzzzu_ = context.Operators.Quantity(27m, "months");
            CqlDateTime pzzzzv_ = context.Operators.Subtract(pzzzzt_, pzzzzu_);
            CqlDateTime pzzzzx_ = context.Operators.End(pzzzzs_);
            CqlInterval<CqlDateTime> pzzzzy_ = context.Operators.Interval(pzzzzv_, pzzzzx_, true, true);
            bool? pzzzzz_ = context.Operators.In<CqlDateTime>(pzzzzr_, pzzzzy_, default);
            CqlDateTime qzzzzb_ = context.Operators.End(pzzzzs_);
            bool? qzzzzc_ = context.Operators.Not((bool?)(qzzzzb_ is null));
            bool? qzzzzd_ = context.Operators.And(pzzzzz_, qzzzzc_);
            bool? qzzzze_ = context.Operators.And(pzzzzo_, qzzzzd_);

            return qzzzze_;
        };
        IEnumerable<DiagnosticReport> pzzzzi_ = context.Operators.Where<DiagnosticReport>(pzzzzg_, pzzzzh_);
        bool? pzzzzj_ = context.Operators.Exists<DiagnosticReport>(pzzzzi_);

        return pzzzzj_;
    }


    #endregion Expressions

}
