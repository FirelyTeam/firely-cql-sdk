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
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
        object czzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("DiabetesEyeExamFHIR-0.0.002", "Measurement Period", czzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Office_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
        Date dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.BirthDateElement;
        string dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        int? dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "year");
        CqlInterval<int?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(18, 75, true, true);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<int?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounters(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Diabetes(context);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = AdvancedIllnessandFrailty_1_16_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = PalliativeCare_1_11_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Overlapping Measurement Period")]
    public bool? Diabetic_Retinopathy_Overlapping_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Diabetic_Retinopathy(context);
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition Retinopathy)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Retinopathy);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Retinal Exam in Measurement Period")]
    public IEnumerable<Observation> Retinal_Exam_in_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isPhysicalExamPerformed(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation RetinalExam)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = RetinalExam?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Retinal Exam in Measurement Period or Year Prior")]
    public IEnumerable<Observation> Retinal_Exam_in_Measurement_Period_or_Year_Prior(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isPhysicalExamPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation RetinalExam)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1m, "year");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = RetinalExam?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Diabetic_Retinopathy_Overlapping_Measurement_Period(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Retinal_Exam_in_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not(fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Retinal_Exam_in_Measurement_Period_or_Year_Prior(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion Expressions

}
