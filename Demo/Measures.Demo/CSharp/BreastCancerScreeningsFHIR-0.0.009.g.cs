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
        CqlDateTime pzzzzzzzzzzv_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime pzzzzzzzzzzw_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> pzzzzzzzzzzx_ = context.Operators.Interval(pzzzzzzzzzzv_, pzzzzzzzzzzw_, true, false);
        object pzzzzzzzzzzy_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", pzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)pzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient qzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzzzzz_);

        return qzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzzzb_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> qzzzzzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> qzzzzzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzf_ = this.Online_Assessments(context);
        IEnumerable<Encounter> qzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet qzzzzzzzzzzh_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> qzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzj_ = context.Operators.Union<Encounter>(qzzzzzzzzzzg_, qzzzzzzzzzzi_);
        bool? qzzzzzzzzzzk_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> qzzzzzzzzzzm_ = TelehealthEncounter?.StatusElement;
            string qzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzzm_);
            bool? qzzzzzzzzzzo_ = context.Operators.Equal(qzzzzzzzzzzn_, "finished");
            CqlInterval<CqlDateTime> qzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period qzzzzzzzzzzq_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, qzzzzzzzzzzq_ as object);
            bool? qzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzp_, qzzzzzzzzzzr_, default);
            bool? qzzzzzzzzzzt_ = context.Operators.And(qzzzzzzzzzzo_, qzzzzzzzzzzs_);

            return qzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzl_ = context.Operators.Where<Encounter>(qzzzzzzzzzzj_, qzzzzzzzzzzk_);

        return qzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient qzzzzzzzzzzu_ = this.Patient(context);
        Date qzzzzzzzzzzv_ = qzzzzzzzzzzu_?.BirthDateElement;
        string qzzzzzzzzzzw_ = qzzzzzzzzzzv_?.Value;
        CqlDate qzzzzzzzzzzx_ = context.Operators.ConvertStringToDate(qzzzzzzzzzzw_);
        CqlInterval<CqlDateTime> qzzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzzzzzz_ = context.Operators.Start(qzzzzzzzzzzy_);
        CqlDate rzzzzzzzzzza_ = context.Operators.DateFrom(qzzzzzzzzzzz_);
        int? rzzzzzzzzzzb_ = context.Operators.CalculateAgeAt(qzzzzzzzzzzx_, rzzzzzzzzzza_, "year");

        return rzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzzzc_ = this.Patient(context);
        Date rzzzzzzzzzzd_ = rzzzzzzzzzzc_?.BirthDateElement;
        string rzzzzzzzzzze_ = rzzzzzzzzzzd_?.Value;
        CqlDate rzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(rzzzzzzzzzze_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzh_ = context.Operators.Start(rzzzzzzzzzzg_);
        CqlDate rzzzzzzzzzzi_ = context.Operators.DateFrom(rzzzzzzzzzzh_);
        int? rzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzf_, rzzzzzzzzzzi_, "year");
        CqlInterval<int?> rzzzzzzzzzzk_ = context.Operators.Interval(51, 74, true, false);
        bool? rzzzzzzzzzzl_ = context.Operators.In<int?>(rzzzzzzzzzzj_, rzzzzzzzzzzk_, default);
        Code<AdministrativeGender> rzzzzzzzzzzn_ = rzzzzzzzzzzc_?.GenderElement;
        string rzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzn_);
        bool? rzzzzzzzzzzp_ = context.Operators.Equal(rzzzzzzzzzzo_, "female");
        bool? rzzzzzzzzzzq_ = context.Operators.And(rzzzzzzzzzzl_, rzzzzzzzzzzp_);
        IEnumerable<Encounter> rzzzzzzzzzzr_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> rzzzzzzzzzzs_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> rzzzzzzzzzzt_ = context.Operators.Union<Encounter>(rzzzzzzzzzzr_, rzzzzzzzzzzs_);
        bool? rzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzt_);
        bool? rzzzzzzzzzzv_ = context.Operators.And(rzzzzzzzzzzq_, rzzzzzzzzzzu_);

        return rzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzzzzzw_ = this.Initial_Population(context);

        return rzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzx_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> rzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet rzzzzzzzzzzz_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> szzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? szzzzzzzzzzb_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> szzzzzzzzzzg_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept szzzzzzzzzzh_(CodeableConcept X)
            {
                CqlConcept szzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return szzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzzzzzg_, szzzzzzzzzzh_);
            CqlValueSet szzzzzzzzzzj_ = this.Right(context);
            bool? szzzzzzzzzzk_ = context.Operators.ConceptsInValueSet(szzzzzzzzzzi_, szzzzzzzzzzj_);

            return szzzzzzzzzzk_;
        };
        IEnumerable<Condition> szzzzzzzzzzc_ = context.Operators.Where<Condition>(szzzzzzzzzza_, szzzzzzzzzzb_);
        IEnumerable<Condition> szzzzzzzzzzd_ = context.Operators.Union<Condition>(rzzzzzzzzzzy_, szzzzzzzzzzc_);
        bool? szzzzzzzzzze_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime szzzzzzzzzzn_ = context.Operators.Start(szzzzzzzzzzm_);
            CqlInterval<CqlDateTime> szzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzp_ = context.Operators.End(szzzzzzzzzzo_);
            bool? szzzzzzzzzzq_ = context.Operators.SameOrBefore(szzzzzzzzzzn_, szzzzzzzzzzp_, default);

            return szzzzzzzzzzq_;
        };
        IEnumerable<Condition> szzzzzzzzzzf_ = context.Operators.Where<Condition>(szzzzzzzzzzd_, szzzzzzzzzze_);

        return szzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzr_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> szzzzzzzzzzs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, szzzzzzzzzzr_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? szzzzzzzzzzt_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> szzzzzzzzzzv_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string szzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, szzzzzzzzzzv_);
            bool? szzzzzzzzzzx_ = context.Operators.Equal(szzzzzzzzzzw_, "completed");
            DataType szzzzzzzzzzy_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> szzzzzzzzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, szzzzzzzzzzy_);
            CqlDateTime tzzzzzzzzzza_ = context.Operators.End(szzzzzzzzzzz_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzc_ = context.Operators.End(tzzzzzzzzzzb_);
            bool? tzzzzzzzzzzd_ = context.Operators.SameOrBefore(tzzzzzzzzzza_, tzzzzzzzzzzc_, default);
            bool? tzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzx_, tzzzzzzzzzzd_);

            return tzzzzzzzzzze_;
        };
        IEnumerable<Procedure> szzzzzzzzzzu_ = context.Operators.Where<Procedure>(szzzzzzzzzzs_, szzzzzzzzzzt_);

        return szzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzf_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> tzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzf_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet tzzzzzzzzzzh_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> tzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? tzzzzzzzzzzj_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> tzzzzzzzzzzo_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept tzzzzzzzzzzp_(CodeableConcept X)
            {
                CqlConcept tzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return tzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> tzzzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)tzzzzzzzzzzo_, tzzzzzzzzzzp_);
            CqlValueSet tzzzzzzzzzzr_ = this.Left(context);
            bool? tzzzzzzzzzzs_ = context.Operators.ConceptsInValueSet(tzzzzzzzzzzq_, tzzzzzzzzzzr_);

            return tzzzzzzzzzzs_;
        };
        IEnumerable<Condition> tzzzzzzzzzzk_ = context.Operators.Where<Condition>(tzzzzzzzzzzi_, tzzzzzzzzzzj_);
        IEnumerable<Condition> tzzzzzzzzzzl_ = context.Operators.Union<Condition>(tzzzzzzzzzzg_, tzzzzzzzzzzk_);
        bool? tzzzzzzzzzzm_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime tzzzzzzzzzzv_ = context.Operators.Start(tzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzx_ = context.Operators.End(tzzzzzzzzzzw_);
            bool? tzzzzzzzzzzy_ = context.Operators.SameOrBefore(tzzzzzzzzzzv_, tzzzzzzzzzzx_, default);

            return tzzzzzzzzzzy_;
        };
        IEnumerable<Condition> tzzzzzzzzzzn_ = context.Operators.Where<Condition>(tzzzzzzzzzzl_, tzzzzzzzzzzm_);

        return tzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzz_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> uzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzzz_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? uzzzzzzzzzzb_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> uzzzzzzzzzzd_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string uzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzzzd_);
            bool? uzzzzzzzzzzf_ = context.Operators.Equal(uzzzzzzzzzze_, "completed");
            DataType uzzzzzzzzzzg_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> uzzzzzzzzzzh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzzzzzzg_);
            CqlDateTime uzzzzzzzzzzi_ = context.Operators.End(uzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzk_ = context.Operators.End(uzzzzzzzzzzj_);
            bool? uzzzzzzzzzzl_ = context.Operators.SameOrBefore(uzzzzzzzzzzi_, uzzzzzzzzzzk_, default);
            bool? uzzzzzzzzzzm_ = context.Operators.And(uzzzzzzzzzzf_, uzzzzzzzzzzl_);

            return uzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzc_ = context.Operators.Where<Procedure>(uzzzzzzzzzza_, uzzzzzzzzzzb_);

        return uzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzn_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> uzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, uzzzzzzzzzzn_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? uzzzzzzzzzzp_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzr_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime uzzzzzzzzzzs_ = context.Operators.Start(uzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzu_ = context.Operators.End(uzzzzzzzzzzt_);
            bool? uzzzzzzzzzzv_ = context.Operators.SameOrBefore(uzzzzzzzzzzs_, uzzzzzzzzzzu_, default);

            return uzzzzzzzzzzv_;
        };
        IEnumerable<Condition> uzzzzzzzzzzq_ = context.Operators.Where<Condition>(uzzzzzzzzzzo_, uzzzzzzzzzzp_);

        return uzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzw_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> uzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzw_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? uzzzzzzzzzzy_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> vzzzzzzzzzza_ = BilateralMastectomyPerformed?.StatusElement;
            string vzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzza_);
            bool? vzzzzzzzzzzc_ = context.Operators.Equal(vzzzzzzzzzzb_, "completed");
            DataType vzzzzzzzzzzd_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> vzzzzzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, vzzzzzzzzzzd_);
            CqlDateTime vzzzzzzzzzzf_ = context.Operators.End(vzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzh_ = context.Operators.End(vzzzzzzzzzzg_);
            bool? vzzzzzzzzzzi_ = context.Operators.SameOrBefore(vzzzzzzzzzzf_, vzzzzzzzzzzh_, default);
            bool? vzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzc_, vzzzzzzzzzzi_);

            return vzzzzzzzzzzj_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzz_ = context.Operators.Where<Procedure>(uzzzzzzzzzzx_, uzzzzzzzzzzy_);

        return uzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? vzzzzzzzzzzk_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> vzzzzzzzzzzl_ = this.Right_Mastectomy_Diagnosis(context);
        bool? vzzzzzzzzzzm_ = context.Operators.Exists<Condition>(vzzzzzzzzzzl_);
        IEnumerable<Procedure> vzzzzzzzzzzn_ = this.Right_Mastectomy_Procedure(context);
        bool? vzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzn_);
        bool? vzzzzzzzzzzp_ = context.Operators.Or(vzzzzzzzzzzm_, vzzzzzzzzzzo_);
        IEnumerable<Condition> vzzzzzzzzzzq_ = this.Left_Mastectomy_Diagnosis(context);
        bool? vzzzzzzzzzzr_ = context.Operators.Exists<Condition>(vzzzzzzzzzzq_);
        IEnumerable<Procedure> vzzzzzzzzzzs_ = this.Left_Mastectomy_Procedure(context);
        bool? vzzzzzzzzzzt_ = context.Operators.Exists<Procedure>(vzzzzzzzzzzs_);
        bool? vzzzzzzzzzzu_ = context.Operators.Or(vzzzzzzzzzzr_, vzzzzzzzzzzt_);
        bool? vzzzzzzzzzzv_ = context.Operators.And(vzzzzzzzzzzp_, vzzzzzzzzzzu_);
        bool? vzzzzzzzzzzw_ = context.Operators.Or(vzzzzzzzzzzk_, vzzzzzzzzzzv_);
        IEnumerable<Condition> vzzzzzzzzzzx_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? vzzzzzzzzzzy_ = context.Operators.Exists<Condition>(vzzzzzzzzzzx_);
        bool? vzzzzzzzzzzz_ = context.Operators.Or(vzzzzzzzzzzw_, vzzzzzzzzzzy_);
        IEnumerable<Procedure> wzzzzzzzzzza_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? wzzzzzzzzzzb_ = context.Operators.Exists<Procedure>(wzzzzzzzzzza_);
        bool? wzzzzzzzzzzc_ = context.Operators.Or(vzzzzzzzzzzz_, wzzzzzzzzzzb_);
        bool? wzzzzzzzzzzd_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? wzzzzzzzzzze_ = context.Operators.Or(wzzzzzzzzzzc_, wzzzzzzzzzzd_);
        Patient wzzzzzzzzzzf_ = this.Patient(context);
        Date wzzzzzzzzzzg_ = wzzzzzzzzzzf_?.BirthDateElement;
        string wzzzzzzzzzzh_ = wzzzzzzzzzzg_?.Value;
        CqlDate wzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzh_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime wzzzzzzzzzzk_ = context.Operators.Start(wzzzzzzzzzzj_);
        CqlDate wzzzzzzzzzzl_ = context.Operators.DateFrom(wzzzzzzzzzzk_);
        int? wzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzi_, wzzzzzzzzzzl_, "year");
        bool? wzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzm_, 65);
        bool? wzzzzzzzzzzo_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? wzzzzzzzzzzp_ = context.Operators.And(wzzzzzzzzzzn_, wzzzzzzzzzzo_);
        bool? wzzzzzzzzzzq_ = context.Operators.Or(wzzzzzzzzzze_, wzzzzzzzzzzp_);
        bool? wzzzzzzzzzzr_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? wzzzzzzzzzzs_ = context.Operators.Or(wzzzzzzzzzzq_, wzzzzzzzzzzr_);

        return wzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzt_ = this.Mammography(context);
        IEnumerable<Observation> wzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? wzzzzzzzzzzv_(Observation Mammogram)
        {
            Code<ObservationStatus> wzzzzzzzzzzy_ = Mammogram?.StatusElement;
            string wzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzzzy_);
            string[] xzzzzzzzzzza_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? xzzzzzzzzzzb_ = context.Operators.In<string>(wzzzzzzzzzzz_, xzzzzzzzzzza_ as IEnumerable<string>);
            DataType xzzzzzzzzzzc_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> xzzzzzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzzzzzc_);
            CqlDateTime xzzzzzzzzzze_ = context.Operators.End(xzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzg_ = context.Operators.End(xzzzzzzzzzzf_);
            CqlQuantity xzzzzzzzzzzh_ = context.Operators.Quantity(27m, "months");
            CqlDateTime xzzzzzzzzzzi_ = context.Operators.Subtract(xzzzzzzzzzzg_, xzzzzzzzzzzh_);
            CqlDateTime xzzzzzzzzzzk_ = context.Operators.End(xzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzl_ = context.Operators.Interval(xzzzzzzzzzzi_, xzzzzzzzzzzk_, true, true);
            bool? xzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzze_, xzzzzzzzzzzl_, default);
            CqlDateTime xzzzzzzzzzzo_ = context.Operators.End(xzzzzzzzzzzf_);
            bool? xzzzzzzzzzzp_ = context.Operators.Not((bool?)(xzzzzzzzzzzo_ is null));
            bool? xzzzzzzzzzzq_ = context.Operators.And(xzzzzzzzzzzm_, xzzzzzzzzzzp_);
            bool? xzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzb_, xzzzzzzzzzzq_);

            return xzzzzzzzzzzr_;
        };
        IEnumerable<Observation> wzzzzzzzzzzw_ = context.Operators.Where<Observation>(wzzzzzzzzzzu_, wzzzzzzzzzzv_);
        bool? wzzzzzzzzzzx_ = context.Operators.Exists<Observation>(wzzzzzzzzzzw_);

        return wzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzs_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> xzzzzzzzzzzt_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, xzzzzzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? xzzzzzzzzzzu_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> xzzzzzzzzzzx_ = Mammogram?.StatusElement;
            string xzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzx_);
            string[] xzzzzzzzzzzz_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? yzzzzzzzzzza_ = context.Operators.In<string>(xzzzzzzzzzzy_, xzzzzzzzzzzz_ as IEnumerable<string>);
            DataType yzzzzzzzzzzb_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> yzzzzzzzzzzc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzzzzzb_);
            CqlDateTime yzzzzzzzzzzd_ = context.Operators.End(yzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> yzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzf_ = context.Operators.End(yzzzzzzzzzze_);
            CqlQuantity yzzzzzzzzzzg_ = context.Operators.Quantity(27m, "months");
            CqlDateTime yzzzzzzzzzzh_ = context.Operators.Subtract(yzzzzzzzzzzf_, yzzzzzzzzzzg_);
            CqlDateTime yzzzzzzzzzzj_ = context.Operators.End(yzzzzzzzzzze_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzk_ = context.Operators.Interval(yzzzzzzzzzzh_, yzzzzzzzzzzj_, true, true);
            bool? yzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzd_, yzzzzzzzzzzk_, default);
            CqlDateTime yzzzzzzzzzzn_ = context.Operators.End(yzzzzzzzzzze_);
            bool? yzzzzzzzzzzo_ = context.Operators.Not((bool?)(yzzzzzzzzzzn_ is null));
            bool? yzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzl_, yzzzzzzzzzzo_);
            bool? yzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzza_, yzzzzzzzzzzp_);

            return yzzzzzzzzzzq_;
        };
        IEnumerable<DiagnosticReport> xzzzzzzzzzzv_ = context.Operators.Where<DiagnosticReport>(xzzzzzzzzzzt_, xzzzzzzzzzzu_);
        bool? xzzzzzzzzzzw_ = context.Operators.Exists<DiagnosticReport>(xzzzzzzzzzzv_);

        return xzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? yzzzzzzzzzzr_ = this.Observation_with_status(context);
        bool? yzzzzzzzzzzs_ = this.Diagnostic_Report_with_status(context);
        bool? yzzzzzzzzzzt_ = context.Operators.Or(yzzzzzzzzzzr_, yzzzzzzzzzzs_);

        return yzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? yzzzzzzzzzzu_ = this.Numerator(context);
        bool? yzzzzzzzzzzv_ = this.Initial_Population(context);
        bool? yzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzu_, yzzzzzzzzzzv_);
        bool? yzzzzzzzzzzx_ = this.Denominator(context);
        bool? yzzzzzzzzzzy_ = context.Operators.And(yzzzzzzzzzzw_, yzzzzzzzzzzx_);
        bool? yzzzzzzzzzzz_ = this.Denominator_Exclusions(context);
        bool? zzzzzzzzzzza_ = context.Operators.Not(yzzzzzzzzzzz_);
        bool? zzzzzzzzzzzb_ = context.Operators.And(yzzzzzzzzzzy_, zzzzzzzzzzza_);

        return zzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzc_ = this.Mammography(context);
        IEnumerable<Observation> zzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? zzzzzzzzzzze_(Observation Mammogram)
        {
            Code<ObservationStatus> zzzzzzzzzzzh_ = Mammogram?.StatusElement;
            string zzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzh_);
            string[] zzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? zzzzzzzzzzzk_ = context.Operators.In<string>(zzzzzzzzzzzi_, zzzzzzzzzzzj_ as IEnumerable<string>);
            bool? zzzzzzzzzzzl_ = context.Operators.Not(zzzzzzzzzzzk_);
            DataType zzzzzzzzzzzm_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> zzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzzzzzm_);
            CqlDateTime zzzzzzzzzzzo_ = context.Operators.End(zzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzzzzzq_ = context.Operators.End(zzzzzzzzzzzp_);
            CqlQuantity zzzzzzzzzzzr_ = context.Operators.Quantity(27m, "months");
            CqlDateTime zzzzzzzzzzzs_ = context.Operators.Subtract(zzzzzzzzzzzq_, zzzzzzzzzzzr_);
            CqlDateTime zzzzzzzzzzzu_ = context.Operators.End(zzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzv_ = context.Operators.Interval(zzzzzzzzzzzs_, zzzzzzzzzzzu_, true, true);
            bool? zzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzo_, zzzzzzzzzzzv_, default);
            CqlDateTime zzzzzzzzzzzy_ = context.Operators.End(zzzzzzzzzzzp_);
            bool? zzzzzzzzzzzz_ = context.Operators.Not((bool?)(zzzzzzzzzzzy_ is null));
            bool? azzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzw_, zzzzzzzzzzzz_);
            bool? azzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzl_, azzzzzzzzzzza_);

            return azzzzzzzzzzzb_;
        };
        IEnumerable<Observation> zzzzzzzzzzzf_ = context.Operators.Where<Observation>(zzzzzzzzzzzd_, zzzzzzzzzzze_);
        bool? zzzzzzzzzzzg_ = context.Operators.Exists<Observation>(zzzzzzzzzzzf_);

        return zzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzc_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> azzzzzzzzzzzd_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, azzzzzzzzzzzc_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? azzzzzzzzzzze_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> azzzzzzzzzzzh_ = Mammogram?.StatusElement;
            string azzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzh_);
            string[] azzzzzzzzzzzj_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? azzzzzzzzzzzk_ = context.Operators.In<string>(azzzzzzzzzzzi_, azzzzzzzzzzzj_ as IEnumerable<string>);
            bool? azzzzzzzzzzzl_ = context.Operators.Not(azzzzzzzzzzzk_);
            DataType azzzzzzzzzzzm_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> azzzzzzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzzzzzzzzzzm_);
            CqlDateTime azzzzzzzzzzzo_ = context.Operators.End(azzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzq_ = context.Operators.End(azzzzzzzzzzzp_);
            CqlQuantity azzzzzzzzzzzr_ = context.Operators.Quantity(27m, "months");
            CqlDateTime azzzzzzzzzzzs_ = context.Operators.Subtract(azzzzzzzzzzzq_, azzzzzzzzzzzr_);
            CqlDateTime azzzzzzzzzzzu_ = context.Operators.End(azzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzv_ = context.Operators.Interval(azzzzzzzzzzzs_, azzzzzzzzzzzu_, true, true);
            bool? azzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzo_, azzzzzzzzzzzv_, default);
            CqlDateTime azzzzzzzzzzzy_ = context.Operators.End(azzzzzzzzzzzp_);
            bool? azzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzy_ is null));
            bool? bzzzzzzzzzzza_ = context.Operators.And(azzzzzzzzzzzw_, azzzzzzzzzzzz_);
            bool? bzzzzzzzzzzzb_ = context.Operators.And(azzzzzzzzzzzl_, bzzzzzzzzzzza_);

            return bzzzzzzzzzzzb_;
        };
        IEnumerable<DiagnosticReport> azzzzzzzzzzzf_ = context.Operators.Where<DiagnosticReport>(azzzzzzzzzzzd_, azzzzzzzzzzze_);
        bool? azzzzzzzzzzzg_ = context.Operators.Exists<DiagnosticReport>(azzzzzzzzzzzf_);

        return azzzzzzzzzzzg_;
    }


    #endregion Expressions

}
