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
        CqlDateTime tzzzr_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime tzzzs_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> tzzzt_ = context.Operators.Interval(tzzzr_, tzzzs_, true, false);
        object tzzzu_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", tzzzt_);

        return (CqlInterval<CqlDateTime>)tzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient tzzzw_ = context.Operators.SingletonFrom<Patient>(tzzzv_);

        return tzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> tzzzx_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return tzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> tzzzy_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return tzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> tzzzz_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return tzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzza_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return uzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet uzzzb_ = this.Online_Assessments(context);
        IEnumerable<Encounter> uzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet uzzzd_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> uzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> uzzzf_ = context.Operators.Union<Encounter>(uzzzc_, uzzze_);
        bool? uzzzg_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> uzzzi_ = TelehealthEncounter?.StatusElement;
            string uzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzi_);
            bool? uzzzk_ = context.Operators.Equal(uzzzj_, "finished");
            CqlInterval<CqlDateTime> uzzzl_ = this.Measurement_Period(context);
            Period uzzzm_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzm_ as object);
            bool? uzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzl_, uzzzn_, default);
            bool? uzzzp_ = context.Operators.And(uzzzk_, uzzzo_);

            return uzzzp_;
        };
        IEnumerable<Encounter> uzzzh_ = context.Operators.Where<Encounter>(uzzzf_, uzzzg_);

        return uzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient uzzzq_ = this.Patient(context);
        Date uzzzr_ = uzzzq_?.BirthDateElement;
        string uzzzs_ = uzzzr_?.Value;
        CqlDate uzzzt_ = context.Operators.ConvertStringToDate(uzzzs_);
        CqlInterval<CqlDateTime> uzzzu_ = this.Measurement_Period(context);
        CqlDateTime uzzzv_ = context.Operators.Start(uzzzu_);
        CqlDate uzzzw_ = context.Operators.DateFrom(uzzzv_);
        int? uzzzx_ = context.Operators.CalculateAgeAt(uzzzt_, uzzzw_, "year");

        return uzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient uzzzy_ = this.Patient(context);
        Date uzzzz_ = uzzzy_?.BirthDateElement;
        string vzzza_ = uzzzz_?.Value;
        CqlDate vzzzb_ = context.Operators.ConvertStringToDate(vzzza_);
        CqlInterval<CqlDateTime> vzzzc_ = this.Measurement_Period(context);
        CqlDateTime vzzzd_ = context.Operators.Start(vzzzc_);
        CqlDate vzzze_ = context.Operators.DateFrom(vzzzd_);
        int? vzzzf_ = context.Operators.CalculateAgeAt(vzzzb_, vzzze_, "year");
        CqlInterval<int?> vzzzg_ = context.Operators.Interval(51, 74, true, false);
        bool? vzzzh_ = context.Operators.In<int?>(vzzzf_, vzzzg_, default);
        Code<AdministrativeGender> vzzzj_ = uzzzy_?.GenderElement;
        string vzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzj_);
        bool? vzzzl_ = context.Operators.Equal(vzzzk_, "female");
        bool? vzzzm_ = context.Operators.And(vzzzh_, vzzzl_);
        IEnumerable<Encounter> vzzzn_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> vzzzo_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> vzzzp_ = context.Operators.Union<Encounter>(vzzzn_, vzzzo_);
        bool? vzzzq_ = context.Operators.Exists<Encounter>(vzzzp_);
        bool? vzzzr_ = context.Operators.And(vzzzm_, vzzzq_);

        return vzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? vzzzs_ = this.Initial_Population(context);

        return vzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet vzzzt_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> vzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet vzzzv_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> vzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? vzzzx_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> wzzzc_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept wzzzd_(CodeableConcept X)
            {
                CqlConcept wzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return wzzzh_;
            };
            IEnumerable<CqlConcept> wzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)wzzzc_, wzzzd_);
            CqlValueSet wzzzf_ = this.Right(context);
            bool? wzzzg_ = context.Operators.ConceptsInValueSet(wzzze_, wzzzf_);

            return wzzzg_;
        };
        IEnumerable<Condition> vzzzy_ = context.Operators.Where<Condition>(vzzzw_, vzzzx_);
        IEnumerable<Condition> vzzzz_ = context.Operators.Union<Condition>(vzzzu_, vzzzy_);
        bool? wzzza_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> wzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime wzzzj_ = context.Operators.Start(wzzzi_);
            CqlInterval<CqlDateTime> wzzzk_ = this.Measurement_Period(context);
            CqlDateTime wzzzl_ = context.Operators.End(wzzzk_);
            bool? wzzzm_ = context.Operators.SameOrBefore(wzzzj_, wzzzl_, default);

            return wzzzm_;
        };
        IEnumerable<Condition> wzzzb_ = context.Operators.Where<Condition>(vzzzz_, wzzza_);

        return wzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet wzzzn_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> wzzzo_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? wzzzp_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> wzzzr_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string wzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzr_);
            bool? wzzzt_ = context.Operators.Equal(wzzzs_, "completed");
            DataType wzzzu_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> wzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzu_);
            CqlDateTime wzzzw_ = context.Operators.End(wzzzv_);
            CqlInterval<CqlDateTime> wzzzx_ = this.Measurement_Period(context);
            CqlDateTime wzzzy_ = context.Operators.End(wzzzx_);
            bool? wzzzz_ = context.Operators.SameOrBefore(wzzzw_, wzzzy_, default);
            bool? xzzza_ = context.Operators.And(wzzzt_, wzzzz_);

            return xzzza_;
        };
        IEnumerable<Procedure> wzzzq_ = context.Operators.Where<Procedure>(wzzzo_, wzzzp_);

        return wzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet xzzzb_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> xzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzb_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet xzzzd_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> xzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? xzzzf_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> xzzzk_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept xzzzl_(CodeableConcept X)
            {
                CqlConcept xzzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return xzzzp_;
            };
            IEnumerable<CqlConcept> xzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)xzzzk_, xzzzl_);
            CqlValueSet xzzzn_ = this.Left(context);
            bool? xzzzo_ = context.Operators.ConceptsInValueSet(xzzzm_, xzzzn_);

            return xzzzo_;
        };
        IEnumerable<Condition> xzzzg_ = context.Operators.Where<Condition>(xzzze_, xzzzf_);
        IEnumerable<Condition> xzzzh_ = context.Operators.Union<Condition>(xzzzc_, xzzzg_);
        bool? xzzzi_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> xzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime xzzzr_ = context.Operators.Start(xzzzq_);
            CqlInterval<CqlDateTime> xzzzs_ = this.Measurement_Period(context);
            CqlDateTime xzzzt_ = context.Operators.End(xzzzs_);
            bool? xzzzu_ = context.Operators.SameOrBefore(xzzzr_, xzzzt_, default);

            return xzzzu_;
        };
        IEnumerable<Condition> xzzzj_ = context.Operators.Where<Condition>(xzzzh_, xzzzi_);

        return xzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet xzzzv_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> xzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, xzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? xzzzx_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> xzzzz_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string yzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzz_);
            bool? yzzzb_ = context.Operators.Equal(yzzza_, "completed");
            DataType yzzzc_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> yzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzc_);
            CqlDateTime yzzze_ = context.Operators.End(yzzzd_);
            CqlInterval<CqlDateTime> yzzzf_ = this.Measurement_Period(context);
            CqlDateTime yzzzg_ = context.Operators.End(yzzzf_);
            bool? yzzzh_ = context.Operators.SameOrBefore(yzzze_, yzzzg_, default);
            bool? yzzzi_ = context.Operators.And(yzzzb_, yzzzh_);

            return yzzzi_;
        };
        IEnumerable<Procedure> xzzzy_ = context.Operators.Where<Procedure>(xzzzw_, xzzzx_);

        return xzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet yzzzj_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> yzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzj_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? yzzzl_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> yzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime yzzzo_ = context.Operators.Start(yzzzn_);
            CqlInterval<CqlDateTime> yzzzp_ = this.Measurement_Period(context);
            CqlDateTime yzzzq_ = context.Operators.End(yzzzp_);
            bool? yzzzr_ = context.Operators.SameOrBefore(yzzzo_, yzzzq_, default);

            return yzzzr_;
        };
        IEnumerable<Condition> yzzzm_ = context.Operators.Where<Condition>(yzzzk_, yzzzl_);

        return yzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet yzzzs_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> yzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, yzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? yzzzu_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> yzzzw_ = BilateralMastectomyPerformed?.StatusElement;
            string yzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzw_);
            bool? yzzzy_ = context.Operators.Equal(yzzzx_, "completed");
            DataType yzzzz_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> zzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzz_);
            CqlDateTime zzzzb_ = context.Operators.End(zzzza_);
            CqlInterval<CqlDateTime> zzzzc_ = this.Measurement_Period(context);
            CqlDateTime zzzzd_ = context.Operators.End(zzzzc_);
            bool? zzzze_ = context.Operators.SameOrBefore(zzzzb_, zzzzd_, default);
            bool? zzzzf_ = context.Operators.And(yzzzy_, zzzze_);

            return zzzzf_;
        };
        IEnumerable<Procedure> yzzzv_ = context.Operators.Where<Procedure>(yzzzt_, yzzzu_);

        return yzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? zzzzg_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> zzzzh_ = this.Right_Mastectomy_Diagnosis(context);
        bool? zzzzi_ = context.Operators.Exists<Condition>(zzzzh_);
        IEnumerable<Procedure> zzzzj_ = this.Right_Mastectomy_Procedure(context);
        bool? zzzzk_ = context.Operators.Exists<Procedure>(zzzzj_);
        bool? zzzzl_ = context.Operators.Or(zzzzi_, zzzzk_);
        IEnumerable<Condition> zzzzm_ = this.Left_Mastectomy_Diagnosis(context);
        bool? zzzzn_ = context.Operators.Exists<Condition>(zzzzm_);
        IEnumerable<Procedure> zzzzo_ = this.Left_Mastectomy_Procedure(context);
        bool? zzzzp_ = context.Operators.Exists<Procedure>(zzzzo_);
        bool? zzzzq_ = context.Operators.Or(zzzzn_, zzzzp_);
        bool? zzzzr_ = context.Operators.And(zzzzl_, zzzzq_);
        bool? zzzzs_ = context.Operators.Or(zzzzg_, zzzzr_);
        IEnumerable<Condition> zzzzt_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? zzzzu_ = context.Operators.Exists<Condition>(zzzzt_);
        bool? zzzzv_ = context.Operators.Or(zzzzs_, zzzzu_);
        IEnumerable<Procedure> zzzzw_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? zzzzx_ = context.Operators.Exists<Procedure>(zzzzw_);
        bool? zzzzy_ = context.Operators.Or(zzzzv_, zzzzx_);
        bool? zzzzz_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? azzzza_ = context.Operators.Or(zzzzy_, zzzzz_);
        Patient azzzzb_ = this.Patient(context);
        Date azzzzc_ = azzzzb_?.BirthDateElement;
        string azzzzd_ = azzzzc_?.Value;
        CqlDate azzzze_ = context.Operators.ConvertStringToDate(azzzzd_);
        CqlInterval<CqlDateTime> azzzzf_ = this.Measurement_Period(context);
        CqlDateTime azzzzg_ = context.Operators.Start(azzzzf_);
        CqlDate azzzzh_ = context.Operators.DateFrom(azzzzg_);
        int? azzzzi_ = context.Operators.CalculateAgeAt(azzzze_, azzzzh_, "year");
        bool? azzzzj_ = context.Operators.GreaterOrEqual(azzzzi_, 65);
        bool? azzzzk_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? azzzzl_ = context.Operators.And(azzzzj_, azzzzk_);
        bool? azzzzm_ = context.Operators.Or(azzzza_, azzzzl_);
        bool? azzzzn_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? azzzzo_ = context.Operators.Or(azzzzm_, azzzzn_);

        return azzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet azzzzp_ = this.Mammography(context);
        IEnumerable<Observation> azzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? azzzzr_(Observation Mammogram)
        {
            Code<ObservationStatus> azzzzu_ = Mammogram?.StatusElement;
            string azzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzu_);
            string[] azzzzw_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? azzzzx_ = context.Operators.In<string>(azzzzv_, azzzzw_ as IEnumerable<string>);
            DataType azzzzy_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> azzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzy_);
            CqlDateTime bzzzza_ = context.Operators.End(azzzzz_);
            CqlInterval<CqlDateTime> bzzzzb_ = this.Measurement_Period(context);
            CqlDateTime bzzzzc_ = context.Operators.End(bzzzzb_);
            CqlQuantity bzzzzd_ = context.Operators.Quantity(27m, "months");
            CqlDateTime bzzzze_ = context.Operators.Subtract(bzzzzc_, bzzzzd_);
            CqlDateTime bzzzzg_ = context.Operators.End(bzzzzb_);
            CqlInterval<CqlDateTime> bzzzzh_ = context.Operators.Interval(bzzzze_, bzzzzg_, true, true);
            bool? bzzzzi_ = context.Operators.In<CqlDateTime>(bzzzza_, bzzzzh_, default);
            CqlDateTime bzzzzk_ = context.Operators.End(bzzzzb_);
            bool? bzzzzl_ = context.Operators.Not((bool?)(bzzzzk_ is null));
            bool? bzzzzm_ = context.Operators.And(bzzzzi_, bzzzzl_);
            bool? bzzzzn_ = context.Operators.And(azzzzx_, bzzzzm_);

            return bzzzzn_;
        };
        IEnumerable<Observation> azzzzs_ = context.Operators.Where<Observation>(azzzzq_, azzzzr_);
        bool? azzzzt_ = context.Operators.Exists<Observation>(azzzzs_);

        return azzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet bzzzzo_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> bzzzzp_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, bzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? bzzzzq_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> bzzzzt_ = Mammogram?.StatusElement;
            string bzzzzu_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzt_);
            string[] bzzzzv_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? bzzzzw_ = context.Operators.In<string>(bzzzzu_, bzzzzv_ as IEnumerable<string>);
            DataType bzzzzx_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> bzzzzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzzzx_);
            CqlDateTime bzzzzz_ = context.Operators.End(bzzzzy_);
            CqlInterval<CqlDateTime> czzzza_ = this.Measurement_Period(context);
            CqlDateTime czzzzb_ = context.Operators.End(czzzza_);
            CqlQuantity czzzzc_ = context.Operators.Quantity(27m, "months");
            CqlDateTime czzzzd_ = context.Operators.Subtract(czzzzb_, czzzzc_);
            CqlDateTime czzzzf_ = context.Operators.End(czzzza_);
            CqlInterval<CqlDateTime> czzzzg_ = context.Operators.Interval(czzzzd_, czzzzf_, true, true);
            bool? czzzzh_ = context.Operators.In<CqlDateTime>(bzzzzz_, czzzzg_, default);
            CqlDateTime czzzzj_ = context.Operators.End(czzzza_);
            bool? czzzzk_ = context.Operators.Not((bool?)(czzzzj_ is null));
            bool? czzzzl_ = context.Operators.And(czzzzh_, czzzzk_);
            bool? czzzzm_ = context.Operators.And(bzzzzw_, czzzzl_);

            return czzzzm_;
        };
        IEnumerable<DiagnosticReport> bzzzzr_ = context.Operators.Where<DiagnosticReport>(bzzzzp_, bzzzzq_);
        bool? bzzzzs_ = context.Operators.Exists<DiagnosticReport>(bzzzzr_);

        return bzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? czzzzn_ = this.Observation_with_status(context);
        bool? czzzzo_ = this.Diagnostic_Report_with_status(context);
        bool? czzzzp_ = context.Operators.Or(czzzzn_, czzzzo_);

        return czzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? czzzzq_ = this.Numerator(context);
        bool? czzzzr_ = this.Initial_Population(context);
        bool? czzzzs_ = context.Operators.And(czzzzq_, czzzzr_);
        bool? czzzzt_ = this.Denominator(context);
        bool? czzzzu_ = context.Operators.And(czzzzs_, czzzzt_);
        bool? czzzzv_ = this.Denominator_Exclusions(context);
        bool? czzzzw_ = context.Operators.Not(czzzzv_);
        bool? czzzzx_ = context.Operators.And(czzzzu_, czzzzw_);

        return czzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet czzzzy_ = this.Mammography(context);
        IEnumerable<Observation> czzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? dzzzza_(Observation Mammogram)
        {
            Code<ObservationStatus> dzzzzd_ = Mammogram?.StatusElement;
            string dzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, dzzzzd_);
            string[] dzzzzf_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? dzzzzg_ = context.Operators.In<string>(dzzzze_, dzzzzf_ as IEnumerable<string>);
            bool? dzzzzh_ = context.Operators.Not(dzzzzg_);
            DataType dzzzzi_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> dzzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dzzzzi_);
            CqlDateTime dzzzzk_ = context.Operators.End(dzzzzj_);
            CqlInterval<CqlDateTime> dzzzzl_ = this.Measurement_Period(context);
            CqlDateTime dzzzzm_ = context.Operators.End(dzzzzl_);
            CqlQuantity dzzzzn_ = context.Operators.Quantity(27m, "months");
            CqlDateTime dzzzzo_ = context.Operators.Subtract(dzzzzm_, dzzzzn_);
            CqlDateTime dzzzzq_ = context.Operators.End(dzzzzl_);
            CqlInterval<CqlDateTime> dzzzzr_ = context.Operators.Interval(dzzzzo_, dzzzzq_, true, true);
            bool? dzzzzs_ = context.Operators.In<CqlDateTime>(dzzzzk_, dzzzzr_, default);
            CqlDateTime dzzzzu_ = context.Operators.End(dzzzzl_);
            bool? dzzzzv_ = context.Operators.Not((bool?)(dzzzzu_ is null));
            bool? dzzzzw_ = context.Operators.And(dzzzzs_, dzzzzv_);
            bool? dzzzzx_ = context.Operators.And(dzzzzh_, dzzzzw_);

            return dzzzzx_;
        };
        IEnumerable<Observation> dzzzzb_ = context.Operators.Where<Observation>(czzzzz_, dzzzza_);
        bool? dzzzzc_ = context.Operators.Exists<Observation>(dzzzzb_);

        return dzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet dzzzzy_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> dzzzzz_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, dzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? ezzzza_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> ezzzzd_ = Mammogram?.StatusElement;
            string ezzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzd_);
            string[] ezzzzf_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? ezzzzg_ = context.Operators.In<string>(ezzzze_, ezzzzf_ as IEnumerable<string>);
            bool? ezzzzh_ = context.Operators.Not(ezzzzg_);
            DataType ezzzzi_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> ezzzzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ezzzzi_);
            CqlDateTime ezzzzk_ = context.Operators.End(ezzzzj_);
            CqlInterval<CqlDateTime> ezzzzl_ = this.Measurement_Period(context);
            CqlDateTime ezzzzm_ = context.Operators.End(ezzzzl_);
            CqlQuantity ezzzzn_ = context.Operators.Quantity(27m, "months");
            CqlDateTime ezzzzo_ = context.Operators.Subtract(ezzzzm_, ezzzzn_);
            CqlDateTime ezzzzq_ = context.Operators.End(ezzzzl_);
            CqlInterval<CqlDateTime> ezzzzr_ = context.Operators.Interval(ezzzzo_, ezzzzq_, true, true);
            bool? ezzzzs_ = context.Operators.In<CqlDateTime>(ezzzzk_, ezzzzr_, default);
            CqlDateTime ezzzzu_ = context.Operators.End(ezzzzl_);
            bool? ezzzzv_ = context.Operators.Not((bool?)(ezzzzu_ is null));
            bool? ezzzzw_ = context.Operators.And(ezzzzs_, ezzzzv_);
            bool? ezzzzx_ = context.Operators.And(ezzzzh_, ezzzzw_);

            return ezzzzx_;
        };
        IEnumerable<DiagnosticReport> ezzzzb_ = context.Operators.Where<DiagnosticReport>(dzzzzz_, ezzzza_);
        bool? ezzzzc_ = context.Operators.Exists<DiagnosticReport>(ezzzzb_);

        return ezzzzc_;
    }


    #endregion Expressions

}
