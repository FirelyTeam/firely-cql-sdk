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
[CqlLibrary("DiabetesEyeExamFHIR", "0.0.002")]
public partial class DiabetesEyeExamFHIR_0_0_002 : ILibrary, ISingleton<DiabetesEyeExamFHIR_0_0_002>
{
    private DiabetesEyeExamFHIR_0_0_002() {}

    public static DiabetesEyeExamFHIR_0_0_002 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DiabetesEyeExamFHIR";
    public string Version => "0.0.002";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance, PalliativeCare_1_11_000.Instance, AdvancedIllnessandFrailty_1_16_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Diabetic Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext _) => _Diabetic_Retinopathy;
    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Retinal or Dilated Eye Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088", valueSetVersion: null)]
    public CqlValueSet Retinal_or_Dilated_Eye_Exam(CqlContext _) => _Retinal_or_Dilated_Eye_Exam;
    private static readonly CqlValueSet _Retinal_or_Dilated_Eye_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime lzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime lzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> mzzzzza_ = context.Operators.Interval(lzzzzzy_, lzzzzzz_, true, true);
        object mzzzzzb_ = context.ResolveParameter("DiabetesEyeExamFHIR-0.0.002", "Measurement Period", mzzzzza_);

        return (CqlInterval<CqlDateTime>)mzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> mzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient mzzzzzd_ = context.Operators.SingletonFrom<Patient>(mzzzzzc_);

        return mzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet mzzzzze_ = this.Office_Visit(context);
        IEnumerable<Encounter> mzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzg_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> mzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzi_ = context.Operators.Union<Encounter>(mzzzzzf_, mzzzzzh_);
        CqlValueSet mzzzzzj_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzl_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> mzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzn_ = context.Operators.Union<Encounter>(mzzzzzk_, mzzzzzm_);
        IEnumerable<Encounter> mzzzzzo_ = context.Operators.Union<Encounter>(mzzzzzi_, mzzzzzn_);
        CqlValueSet mzzzzzp_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> mzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet mzzzzzr_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> mzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzt_ = context.Operators.Union<Encounter>(mzzzzzq_, mzzzzzs_);
        IEnumerable<Encounter> mzzzzzu_ = context.Operators.Union<Encounter>(mzzzzzo_, mzzzzzt_);
        CqlValueSet mzzzzzv_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> mzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> mzzzzzx_ = context.Operators.Union<Encounter>(mzzzzzu_, mzzzzzw_);
        IEnumerable<Encounter> mzzzzzy_ = Status_1_8_000.Instance.isEncounterPerformed(context, mzzzzzx_);
        bool? mzzzzzz_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> nzzzzzb_ = this.Measurement_Period(context);
            Period nzzzzzc_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> nzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzd_ as object);
            bool? nzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzb_, nzzzzze_, "day");

            return nzzzzzf_;
        };
        IEnumerable<Encounter> nzzzzza_ = context.Operators.Where<Encounter>(mzzzzzy_, mzzzzzz_);

        return nzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient nzzzzzg_ = this.Patient(context);
        Date nzzzzzh_ = nzzzzzg_?.BirthDateElement;
        string nzzzzzi_ = nzzzzzh_?.Value;
        CqlDate nzzzzzj_ = context.Operators.ConvertStringToDate(nzzzzzi_);
        CqlInterval<CqlDateTime> nzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime nzzzzzl_ = context.Operators.End(nzzzzzk_);
        CqlDate nzzzzzm_ = context.Operators.DateFrom(nzzzzzl_);
        int? nzzzzzn_ = context.Operators.CalculateAgeAt(nzzzzzj_, nzzzzzm_, "year");
        CqlInterval<int?> nzzzzzo_ = context.Operators.Interval(18, 75, true, true);
        bool? nzzzzzp_ = context.Operators.In<int?>(nzzzzzn_, nzzzzzo_, default);
        IEnumerable<Encounter> nzzzzzq_ = this.Qualifying_Encounters(context);
        bool? nzzzzzr_ = context.Operators.Exists<Encounter>(nzzzzzq_);
        bool? nzzzzzs_ = context.Operators.And(nzzzzzp_, nzzzzzr_);
        CqlValueSet nzzzzzt_ = this.Diabetes(context);
        IEnumerable<Condition> nzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzv_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> nzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> ozzzzza_ = this.Measurement_Period(context);
            bool? ozzzzzb_ = context.Operators.Overlaps(nzzzzzz_, ozzzzza_, "day");

            return ozzzzzb_;
        };
        IEnumerable<Condition> nzzzzzw_ = context.Operators.Where<Condition>(nzzzzzu_, nzzzzzv_);
        bool? nzzzzzx_ = context.Operators.Exists<Condition>(nzzzzzw_);
        bool? nzzzzzy_ = context.Operators.And(nzzzzzs_, nzzzzzx_);

        return nzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ozzzzzc_ = this.Initial_Population(context);

        return ozzzzzc_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ozzzzzd_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? ozzzzze_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? ozzzzzf_ = context.Operators.Or(ozzzzzd_, ozzzzze_);
        bool? ozzzzzg_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? ozzzzzh_ = context.Operators.Or(ozzzzzf_, ozzzzzg_);
        bool? ozzzzzi_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? ozzzzzj_ = context.Operators.Or(ozzzzzh_, ozzzzzi_);

        return ozzzzzj_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Overlapping Measurement Period")]
    public bool? Diabetic_Retinopathy_Overlapping_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzk_ = this.Diabetic_Retinopathy(context);
        IEnumerable<Condition> ozzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ozzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ozzzzzm_(Condition Retinopathy)
        {
            CqlInterval<CqlDateTime> ozzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Retinopathy);
            CqlInterval<CqlDateTime> ozzzzzq_ = this.Measurement_Period(context);
            bool? ozzzzzr_ = context.Operators.Overlaps(ozzzzzp_, ozzzzzq_, "day");

            return ozzzzzr_;
        };
        IEnumerable<Condition> ozzzzzn_ = context.Operators.Where<Condition>(ozzzzzl_, ozzzzzm_);
        bool? ozzzzzo_ = context.Operators.Exists<Condition>(ozzzzzn_);

        return ozzzzzo_;
    }


    [CqlExpressionDefinition("Retinal Exam in Measurement Period")]
    public IEnumerable<Observation> Retinal_Exam_in_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzs_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> ozzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzu_ = Status_1_8_000.Instance.isPhysicalExamPerformed(context, ozzzzzt_);
        bool? ozzzzzv_(Observation RetinalExam)
        {
            CqlInterval<CqlDateTime> ozzzzzx_ = this.Measurement_Period(context);
            DataType ozzzzzy_ = RetinalExam?.Effective;
            object ozzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzy_);
            CqlInterval<CqlDateTime> pzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzz_);
            bool? pzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ozzzzzx_, pzzzzza_, "day");

            return pzzzzzb_;
        };
        IEnumerable<Observation> ozzzzzw_ = context.Operators.Where<Observation>(ozzzzzu_, ozzzzzv_);

        return ozzzzzw_;
    }


    [CqlExpressionDefinition("Retinal Exam in Measurement Period or Year Prior")]
    public IEnumerable<Observation> Retinal_Exam_in_Measurement_Period_or_Year_Prior(CqlContext context)
    {
        CqlValueSet pzzzzzc_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> pzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzze_ = Status_1_8_000.Instance.isPhysicalExamPerformed(context, pzzzzzd_);
        bool? pzzzzzf_(Observation RetinalExam)
        {
            CqlInterval<CqlDateTime> pzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime pzzzzzi_ = context.Operators.Start(pzzzzzh_);
            CqlQuantity pzzzzzj_ = context.Operators.Quantity(1m, "year");
            CqlDateTime pzzzzzk_ = context.Operators.Subtract(pzzzzzi_, pzzzzzj_);
            CqlDateTime pzzzzzm_ = context.Operators.End(pzzzzzh_);
            CqlInterval<CqlDateTime> pzzzzzn_ = context.Operators.Interval(pzzzzzk_, pzzzzzm_, true, true);
            DataType pzzzzzo_ = RetinalExam?.Effective;
            object pzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzo_);
            CqlInterval<CqlDateTime> pzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzp_);
            bool? pzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzn_, pzzzzzq_, "day");

            return pzzzzzr_;
        };
        IEnumerable<Observation> pzzzzzg_ = context.Operators.Where<Observation>(pzzzzze_, pzzzzzf_);

        return pzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? pzzzzzs_ = this.Diabetic_Retinopathy_Overlapping_Measurement_Period(context);
        IEnumerable<Observation> pzzzzzt_ = this.Retinal_Exam_in_Measurement_Period(context);
        bool? pzzzzzu_ = context.Operators.Exists<Observation>(pzzzzzt_);
        bool? pzzzzzv_ = context.Operators.And(pzzzzzs_, pzzzzzu_);
        bool? pzzzzzx_ = context.Operators.Not(pzzzzzs_);
        IEnumerable<Observation> pzzzzzy_ = this.Retinal_Exam_in_Measurement_Period_or_Year_Prior(context);
        bool? pzzzzzz_ = context.Operators.Exists<Observation>(pzzzzzy_);
        bool? qzzzzza_ = context.Operators.And(pzzzzzx_, pzzzzzz_);
        bool? qzzzzzb_ = context.Operators.Or(pzzzzzv_, qzzzzza_);

        return qzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzze_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzf_;
    }


    #endregion Expressions

}
