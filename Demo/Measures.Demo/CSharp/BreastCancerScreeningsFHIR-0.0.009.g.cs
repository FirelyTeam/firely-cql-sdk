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
        CqlDateTime ozzzzzzw_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime ozzzzzzx_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> ozzzzzzy_ = context.Operators.Interval(ozzzzzzw_, ozzzzzzx_, true, false);
        object ozzzzzzz_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", ozzzzzzy_);

        return (CqlInterval<CqlDateTime>)ozzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient pzzzzzzb_ = context.Operators.SingletonFrom<Patient>(pzzzzzza_);

        return pzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> pzzzzzzc_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> pzzzzzzd_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return pzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> pzzzzzze_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return pzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzf_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return pzzzzzzf_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet pzzzzzzg_ = this.Online_Assessments(context);
        IEnumerable<Encounter> pzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet pzzzzzzi_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> pzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> pzzzzzzk_ = context.Operators.Union<Encounter>(pzzzzzzh_, pzzzzzzj_);
        bool? pzzzzzzl_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> pzzzzzzn_ = TelehealthEncounter?.StatusElement;
            string pzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzn_);
            bool? pzzzzzzp_ = context.Operators.Equal(pzzzzzzo_, "finished");
            CqlInterval<CqlDateTime> pzzzzzzq_ = this.Measurement_Period(context);
            Period pzzzzzzr_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, pzzzzzzr_ as object);
            bool? pzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzq_, pzzzzzzs_, default);
            bool? pzzzzzzu_ = context.Operators.And(pzzzzzzp_, pzzzzzzt_);

            return pzzzzzzu_;
        };
        IEnumerable<Encounter> pzzzzzzm_ = context.Operators.Where<Encounter>(pzzzzzzk_, pzzzzzzl_);

        return pzzzzzzm_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
    {
        Patient pzzzzzzv_ = this.Patient(context);
        Date pzzzzzzw_ = pzzzzzzv_?.BirthDateElement;
        string pzzzzzzx_ = pzzzzzzw_?.Value;
        CqlDate pzzzzzzy_ = context.Operators.ConvertStringToDate(pzzzzzzx_);
        CqlInterval<CqlDateTime> pzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzza_ = context.Operators.Start(pzzzzzzz_);
        CqlDate qzzzzzzb_ = context.Operators.DateFrom(qzzzzzza_);
        int? qzzzzzzc_ = context.Operators.CalculateAgeAt(pzzzzzzy_, qzzzzzzb_, "year");

        return qzzzzzzc_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient qzzzzzzd_ = this.Patient(context);
        Date qzzzzzze_ = qzzzzzzd_?.BirthDateElement;
        string qzzzzzzf_ = qzzzzzze_?.Value;
        CqlDate qzzzzzzg_ = context.Operators.ConvertStringToDate(qzzzzzzf_);
        CqlInterval<CqlDateTime> qzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime qzzzzzzi_ = context.Operators.Start(qzzzzzzh_);
        CqlDate qzzzzzzj_ = context.Operators.DateFrom(qzzzzzzi_);
        int? qzzzzzzk_ = context.Operators.CalculateAgeAt(qzzzzzzg_, qzzzzzzj_, "year");
        CqlInterval<int?> qzzzzzzl_ = context.Operators.Interval(51, 74, true, false);
        bool? qzzzzzzm_ = context.Operators.In<int?>(qzzzzzzk_, qzzzzzzl_, default);
        Code<AdministrativeGender> qzzzzzzo_ = qzzzzzzd_?.GenderElement;
        string qzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzo_);
        bool? qzzzzzzq_ = context.Operators.Equal(qzzzzzzp_, "female");
        bool? qzzzzzzr_ = context.Operators.And(qzzzzzzm_, qzzzzzzq_);
        IEnumerable<Encounter> qzzzzzzs_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> qzzzzzzt_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> qzzzzzzu_ = context.Operators.Union<Encounter>(qzzzzzzs_, qzzzzzzt_);
        bool? qzzzzzzv_ = context.Operators.Exists<Encounter>(qzzzzzzu_);
        bool? qzzzzzzw_ = context.Operators.And(qzzzzzzr_, qzzzzzzv_);

        return qzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? qzzzzzzx_ = this.Initial_Population(context);

        return qzzzzzzx_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet qzzzzzzy_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> qzzzzzzz_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzy_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet rzzzzzza_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> rzzzzzzb_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? rzzzzzzc_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> rzzzzzzh_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept rzzzzzzi_(CodeableConcept X)
            {
                CqlConcept rzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return rzzzzzzm_;
            };
            IEnumerable<CqlConcept> rzzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)rzzzzzzh_, rzzzzzzi_);
            CqlValueSet rzzzzzzk_ = this.Right(context);
            bool? rzzzzzzl_ = context.Operators.ConceptsInValueSet(rzzzzzzj_, rzzzzzzk_);

            return rzzzzzzl_;
        };
        IEnumerable<Condition> rzzzzzzd_ = context.Operators.Where<Condition>(rzzzzzzb_, rzzzzzzc_);
        IEnumerable<Condition> rzzzzzze_ = context.Operators.Union<Condition>(qzzzzzzz_, rzzzzzzd_);
        bool? rzzzzzzf_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> rzzzzzzn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime rzzzzzzo_ = context.Operators.Start(rzzzzzzn_);
            CqlInterval<CqlDateTime> rzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzq_ = context.Operators.End(rzzzzzzp_);
            bool? rzzzzzzr_ = context.Operators.SameOrBefore(rzzzzzzo_, rzzzzzzq_, default);

            return rzzzzzzr_;
        };
        IEnumerable<Condition> rzzzzzzg_ = context.Operators.Where<Condition>(rzzzzzze_, rzzzzzzf_);

        return rzzzzzzg_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet rzzzzzzs_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> rzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, rzzzzzzs_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? rzzzzzzu_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> rzzzzzzw_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string rzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzw_);
            bool? rzzzzzzy_ = context.Operators.Equal(rzzzzzzx_, "completed");
            DataType rzzzzzzz_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> szzzzzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, rzzzzzzz_);
            CqlDateTime szzzzzzb_ = context.Operators.End(szzzzzza_);
            CqlInterval<CqlDateTime> szzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzd_ = context.Operators.End(szzzzzzc_);
            bool? szzzzzze_ = context.Operators.SameOrBefore(szzzzzzb_, szzzzzzd_, default);
            bool? szzzzzzf_ = context.Operators.And(rzzzzzzy_, szzzzzze_);

            return szzzzzzf_;
        };
        IEnumerable<Procedure> rzzzzzzv_ = context.Operators.Where<Procedure>(rzzzzzzt_, rzzzzzzu_);

        return rzzzzzzv_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet szzzzzzg_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> szzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzg_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet szzzzzzi_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> szzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzi_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? szzzzzzk_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> szzzzzzp_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept szzzzzzq_(CodeableConcept X)
            {
                CqlConcept szzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return szzzzzzu_;
            };
            IEnumerable<CqlConcept> szzzzzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)szzzzzzp_, szzzzzzq_);
            CqlValueSet szzzzzzs_ = this.Left(context);
            bool? szzzzzzt_ = context.Operators.ConceptsInValueSet(szzzzzzr_, szzzzzzs_);

            return szzzzzzt_;
        };
        IEnumerable<Condition> szzzzzzl_ = context.Operators.Where<Condition>(szzzzzzj_, szzzzzzk_);
        IEnumerable<Condition> szzzzzzm_ = context.Operators.Union<Condition>(szzzzzzh_, szzzzzzl_);
        bool? szzzzzzn_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> szzzzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime szzzzzzw_ = context.Operators.Start(szzzzzzv_);
            CqlInterval<CqlDateTime> szzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzy_ = context.Operators.End(szzzzzzx_);
            bool? szzzzzzz_ = context.Operators.SameOrBefore(szzzzzzw_, szzzzzzy_, default);

            return szzzzzzz_;
        };
        IEnumerable<Condition> szzzzzzo_ = context.Operators.Where<Condition>(szzzzzzm_, szzzzzzn_);

        return szzzzzzo_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet tzzzzzza_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> tzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzza_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? tzzzzzzc_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> tzzzzzze_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string tzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzze_);
            bool? tzzzzzzg_ = context.Operators.Equal(tzzzzzzf_, "completed");
            DataType tzzzzzzh_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> tzzzzzzi_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, tzzzzzzh_);
            CqlDateTime tzzzzzzj_ = context.Operators.End(tzzzzzzi_);
            CqlInterval<CqlDateTime> tzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzl_ = context.Operators.End(tzzzzzzk_);
            bool? tzzzzzzm_ = context.Operators.SameOrBefore(tzzzzzzj_, tzzzzzzl_, default);
            bool? tzzzzzzn_ = context.Operators.And(tzzzzzzg_, tzzzzzzm_);

            return tzzzzzzn_;
        };
        IEnumerable<Procedure> tzzzzzzd_ = context.Operators.Where<Procedure>(tzzzzzzb_, tzzzzzzc_);

        return tzzzzzzd_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet tzzzzzzo_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> tzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzo_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? tzzzzzzq_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> tzzzzzzs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime tzzzzzzt_ = context.Operators.Start(tzzzzzzs_);
            CqlInterval<CqlDateTime> tzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzv_ = context.Operators.End(tzzzzzzu_);
            bool? tzzzzzzw_ = context.Operators.SameOrBefore(tzzzzzzt_, tzzzzzzv_, default);

            return tzzzzzzw_;
        };
        IEnumerable<Condition> tzzzzzzr_ = context.Operators.Where<Condition>(tzzzzzzp_, tzzzzzzq_);

        return tzzzzzzr_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet tzzzzzzx_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> tzzzzzzy_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzx_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? tzzzzzzz_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> uzzzzzzb_ = BilateralMastectomyPerformed?.StatusElement;
            string uzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzb_);
            bool? uzzzzzzd_ = context.Operators.Equal(uzzzzzzc_, "completed");
            DataType uzzzzzze_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> uzzzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, uzzzzzze_);
            CqlDateTime uzzzzzzg_ = context.Operators.End(uzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzi_ = context.Operators.End(uzzzzzzh_);
            bool? uzzzzzzj_ = context.Operators.SameOrBefore(uzzzzzzg_, uzzzzzzi_, default);
            bool? uzzzzzzk_ = context.Operators.And(uzzzzzzd_, uzzzzzzj_);

            return uzzzzzzk_;
        };
        IEnumerable<Procedure> uzzzzzza_ = context.Operators.Where<Procedure>(tzzzzzzy_, tzzzzzzz_);

        return uzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? uzzzzzzl_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> uzzzzzzm_ = this.Right_Mastectomy_Diagnosis(context);
        bool? uzzzzzzn_ = context.Operators.Exists<Condition>(uzzzzzzm_);
        IEnumerable<Procedure> uzzzzzzo_ = this.Right_Mastectomy_Procedure(context);
        bool? uzzzzzzp_ = context.Operators.Exists<Procedure>(uzzzzzzo_);
        bool? uzzzzzzq_ = context.Operators.Or(uzzzzzzn_, uzzzzzzp_);
        IEnumerable<Condition> uzzzzzzr_ = this.Left_Mastectomy_Diagnosis(context);
        bool? uzzzzzzs_ = context.Operators.Exists<Condition>(uzzzzzzr_);
        IEnumerable<Procedure> uzzzzzzt_ = this.Left_Mastectomy_Procedure(context);
        bool? uzzzzzzu_ = context.Operators.Exists<Procedure>(uzzzzzzt_);
        bool? uzzzzzzv_ = context.Operators.Or(uzzzzzzs_, uzzzzzzu_);
        bool? uzzzzzzw_ = context.Operators.And(uzzzzzzq_, uzzzzzzv_);
        bool? uzzzzzzx_ = context.Operators.Or(uzzzzzzl_, uzzzzzzw_);
        IEnumerable<Condition> uzzzzzzy_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? uzzzzzzz_ = context.Operators.Exists<Condition>(uzzzzzzy_);
        bool? vzzzzzza_ = context.Operators.Or(uzzzzzzx_, uzzzzzzz_);
        IEnumerable<Procedure> vzzzzzzb_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? vzzzzzzc_ = context.Operators.Exists<Procedure>(vzzzzzzb_);
        bool? vzzzzzzd_ = context.Operators.Or(vzzzzzza_, vzzzzzzc_);
        bool? vzzzzzze_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? vzzzzzzf_ = context.Operators.Or(vzzzzzzd_, vzzzzzze_);
        Patient vzzzzzzg_ = this.Patient(context);
        Date vzzzzzzh_ = vzzzzzzg_?.BirthDateElement;
        string vzzzzzzi_ = vzzzzzzh_?.Value;
        CqlDate vzzzzzzj_ = context.Operators.ConvertStringToDate(vzzzzzzi_);
        CqlInterval<CqlDateTime> vzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzl_ = context.Operators.Start(vzzzzzzk_);
        CqlDate vzzzzzzm_ = context.Operators.DateFrom(vzzzzzzl_);
        int? vzzzzzzn_ = context.Operators.CalculateAgeAt(vzzzzzzj_, vzzzzzzm_, "year");
        bool? vzzzzzzo_ = context.Operators.GreaterOrEqual(vzzzzzzn_, 65);
        bool? vzzzzzzp_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? vzzzzzzq_ = context.Operators.And(vzzzzzzo_, vzzzzzzp_);
        bool? vzzzzzzr_ = context.Operators.Or(vzzzzzzf_, vzzzzzzq_);
        bool? vzzzzzzs_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? vzzzzzzt_ = context.Operators.Or(vzzzzzzr_, vzzzzzzs_);

        return vzzzzzzt_;
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet vzzzzzzu_ = this.Mammography(context);
        IEnumerable<Observation> vzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzu_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? vzzzzzzw_(Observation Mammogram)
        {
            Code<ObservationStatus> vzzzzzzz_ = Mammogram?.StatusElement;
            string wzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzz_);
            string[] wzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? wzzzzzzc_ = context.Operators.In<string>(wzzzzzza_, wzzzzzzb_ as IEnumerable<string>);
            DataType wzzzzzzd_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> wzzzzzze_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzzzzzzd_);
            CqlDateTime wzzzzzzf_ = context.Operators.End(wzzzzzze_);
            CqlInterval<CqlDateTime> wzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime wzzzzzzh_ = context.Operators.End(wzzzzzzg_);
            CqlQuantity wzzzzzzi_ = context.Operators.Quantity(27m, "months");
            CqlDateTime wzzzzzzj_ = context.Operators.Subtract(wzzzzzzh_, wzzzzzzi_);
            CqlDateTime wzzzzzzl_ = context.Operators.End(wzzzzzzg_);
            CqlInterval<CqlDateTime> wzzzzzzm_ = context.Operators.Interval(wzzzzzzj_, wzzzzzzl_, true, true);
            bool? wzzzzzzn_ = context.Operators.In<CqlDateTime>(wzzzzzzf_, wzzzzzzm_, default);
            CqlDateTime wzzzzzzp_ = context.Operators.End(wzzzzzzg_);
            bool? wzzzzzzq_ = context.Operators.Not((bool?)(wzzzzzzp_ is null));
            bool? wzzzzzzr_ = context.Operators.And(wzzzzzzn_, wzzzzzzq_);
            bool? wzzzzzzs_ = context.Operators.And(wzzzzzzc_, wzzzzzzr_);

            return wzzzzzzs_;
        };
        IEnumerable<Observation> vzzzzzzx_ = context.Operators.Where<Observation>(vzzzzzzv_, vzzzzzzw_);
        bool? vzzzzzzy_ = context.Operators.Exists<Observation>(vzzzzzzx_);

        return vzzzzzzy_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet wzzzzzzt_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> wzzzzzzu_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, wzzzzzzt_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? wzzzzzzv_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> wzzzzzzy_ = Mammogram?.StatusElement;
            string wzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzy_);
            string[] xzzzzzza_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? xzzzzzzb_ = context.Operators.In<string>(wzzzzzzz_, xzzzzzza_ as IEnumerable<string>);
            DataType xzzzzzzc_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> xzzzzzzd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzzzzc_);
            CqlDateTime xzzzzzze_ = context.Operators.End(xzzzzzzd_);
            CqlInterval<CqlDateTime> xzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzg_ = context.Operators.End(xzzzzzzf_);
            CqlQuantity xzzzzzzh_ = context.Operators.Quantity(27m, "months");
            CqlDateTime xzzzzzzi_ = context.Operators.Subtract(xzzzzzzg_, xzzzzzzh_);
            CqlDateTime xzzzzzzk_ = context.Operators.End(xzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzl_ = context.Operators.Interval(xzzzzzzi_, xzzzzzzk_, true, true);
            bool? xzzzzzzm_ = context.Operators.In<CqlDateTime>(xzzzzzze_, xzzzzzzl_, default);
            CqlDateTime xzzzzzzo_ = context.Operators.End(xzzzzzzf_);
            bool? xzzzzzzp_ = context.Operators.Not((bool?)(xzzzzzzo_ is null));
            bool? xzzzzzzq_ = context.Operators.And(xzzzzzzm_, xzzzzzzp_);
            bool? xzzzzzzr_ = context.Operators.And(xzzzzzzb_, xzzzzzzq_);

            return xzzzzzzr_;
        };
        IEnumerable<DiagnosticReport> wzzzzzzw_ = context.Operators.Where<DiagnosticReport>(wzzzzzzu_, wzzzzzzv_);
        bool? wzzzzzzx_ = context.Operators.Exists<DiagnosticReport>(wzzzzzzw_);

        return wzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? xzzzzzzs_ = this.Observation_with_status(context);
        bool? xzzzzzzt_ = this.Diagnostic_Report_with_status(context);
        bool? xzzzzzzu_ = context.Operators.Or(xzzzzzzs_, xzzzzzzt_);

        return xzzzzzzu_;
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? xzzzzzzv_ = this.Numerator(context);
        bool? xzzzzzzw_ = this.Initial_Population(context);
        bool? xzzzzzzx_ = context.Operators.And(xzzzzzzv_, xzzzzzzw_);
        bool? xzzzzzzy_ = this.Denominator(context);
        bool? xzzzzzzz_ = context.Operators.And(xzzzzzzx_, xzzzzzzy_);
        bool? yzzzzzza_ = this.Denominator_Exclusions(context);
        bool? yzzzzzzb_ = context.Operators.Not(yzzzzzza_);
        bool? yzzzzzzc_ = context.Operators.And(xzzzzzzz_, yzzzzzzb_);

        return yzzzzzzc_;
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet yzzzzzzd_ = this.Mammography(context);
        IEnumerable<Observation> yzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? yzzzzzzf_(Observation Mammogram)
        {
            Code<ObservationStatus> yzzzzzzi_ = Mammogram?.StatusElement;
            string yzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzi_);
            string[] yzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? yzzzzzzl_ = context.Operators.In<string>(yzzzzzzj_, yzzzzzzk_ as IEnumerable<string>);
            bool? yzzzzzzm_ = context.Operators.Not(yzzzzzzl_);
            DataType yzzzzzzn_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> yzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzzzzn_);
            CqlDateTime yzzzzzzp_ = context.Operators.End(yzzzzzzo_);
            CqlInterval<CqlDateTime> yzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzr_ = context.Operators.End(yzzzzzzq_);
            CqlQuantity yzzzzzzs_ = context.Operators.Quantity(27m, "months");
            CqlDateTime yzzzzzzt_ = context.Operators.Subtract(yzzzzzzr_, yzzzzzzs_);
            CqlDateTime yzzzzzzv_ = context.Operators.End(yzzzzzzq_);
            CqlInterval<CqlDateTime> yzzzzzzw_ = context.Operators.Interval(yzzzzzzt_, yzzzzzzv_, true, true);
            bool? yzzzzzzx_ = context.Operators.In<CqlDateTime>(yzzzzzzp_, yzzzzzzw_, default);
            CqlDateTime yzzzzzzz_ = context.Operators.End(yzzzzzzq_);
            bool? zzzzzzza_ = context.Operators.Not((bool?)(yzzzzzzz_ is null));
            bool? zzzzzzzb_ = context.Operators.And(yzzzzzzx_, zzzzzzza_);
            bool? zzzzzzzc_ = context.Operators.And(yzzzzzzm_, zzzzzzzb_);

            return zzzzzzzc_;
        };
        IEnumerable<Observation> yzzzzzzg_ = context.Operators.Where<Observation>(yzzzzzze_, yzzzzzzf_);
        bool? yzzzzzzh_ = context.Operators.Exists<Observation>(yzzzzzzg_);

        return yzzzzzzh_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet zzzzzzzd_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> zzzzzzze_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, zzzzzzzd_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? zzzzzzzf_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> zzzzzzzi_ = Mammogram?.StatusElement;
            string zzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzi_);
            string[] zzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? zzzzzzzl_ = context.Operators.In<string>(zzzzzzzj_, zzzzzzzk_ as IEnumerable<string>);
            bool? zzzzzzzm_ = context.Operators.Not(zzzzzzzl_);
            DataType zzzzzzzn_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> zzzzzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, zzzzzzzn_);
            CqlDateTime zzzzzzzp_ = context.Operators.End(zzzzzzzo_);
            CqlInterval<CqlDateTime> zzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime zzzzzzzr_ = context.Operators.End(zzzzzzzq_);
            CqlQuantity zzzzzzzs_ = context.Operators.Quantity(27m, "months");
            CqlDateTime zzzzzzzt_ = context.Operators.Subtract(zzzzzzzr_, zzzzzzzs_);
            CqlDateTime zzzzzzzv_ = context.Operators.End(zzzzzzzq_);
            CqlInterval<CqlDateTime> zzzzzzzw_ = context.Operators.Interval(zzzzzzzt_, zzzzzzzv_, true, true);
            bool? zzzzzzzx_ = context.Operators.In<CqlDateTime>(zzzzzzzp_, zzzzzzzw_, default);
            CqlDateTime zzzzzzzz_ = context.Operators.End(zzzzzzzq_);
            bool? azzzzzzza_ = context.Operators.Not((bool?)(zzzzzzzz_ is null));
            bool? azzzzzzzb_ = context.Operators.And(zzzzzzzx_, azzzzzzza_);
            bool? azzzzzzzc_ = context.Operators.And(zzzzzzzm_, azzzzzzzb_);

            return azzzzzzzc_;
        };
        IEnumerable<DiagnosticReport> zzzzzzzg_ = context.Operators.Where<DiagnosticReport>(zzzzzzze_, zzzzzzzf_);
        bool? zzzzzzzh_ = context.Operators.Exists<DiagnosticReport>(zzzzzzzg_);

        return zzzzzzzh_;
    }


    #endregion Expressions

}
