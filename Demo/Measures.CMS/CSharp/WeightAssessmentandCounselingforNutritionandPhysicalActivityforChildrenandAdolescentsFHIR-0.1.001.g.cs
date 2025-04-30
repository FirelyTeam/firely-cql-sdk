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
[CqlLibrary("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR", "0.1.001")]
public partial class WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_001 : ILibrary, ISingleton<WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_001>
{
    private WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_001() {}

    public static WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Counseling for Nutrition", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003", valueSetVersion: null)]
    public CqlValueSet Counseling_for_Nutrition(CqlContext _) => _Counseling_for_Nutrition;
    private static readonly CqlValueSet _Counseling_for_Nutrition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003", null);

    [CqlValueSetDefinition("Counseling for Physical Activity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035", valueSetVersion: null)]
    public CqlValueSet Counseling_for_Physical_Activity(CqlContext _) => _Counseling_for_Physical_Activity;
    private static readonly CqlValueSet _Counseling_for_Physical_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Pregnancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext _) => _Pregnancy;
    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);

    [CqlValueSetDefinition("Preventive Care Services Group Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext _) => _Preventive_Care_Services_Group_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition("UCUM")]
    public CqlCodeSystem UCUM(CqlContext _) => _UCUM;
    private static readonly CqlCodeSystem _UCUM =
      new CqlCodeSystem("http://unitsofmeasure.org", null);

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null);

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzs_ = context.Operators.Interval(zzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzr_, true, true);
        object zzzzzzzzzzzzzzzt_ = context.ResolveParameter("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.001", "Measurement Period", zzzzzzzzzzzzzzzs_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzu_);

        return zzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return zzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> zzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return zzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? zzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return zzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return zzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzza_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzd_);
        CqlValueSet azzzzzzzzzzzzzzzf_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzj_);
        CqlValueSet azzzzzzzzzzzzzzzl_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzn_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzp_);
        CqlValueSet azzzzzzzzzzzzzzzr_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isEncounterPerformed(context, azzzzzzzzzzzzzzzt_);
        bool? azzzzzzzzzzzzzzzv_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            Period azzzzzzzzzzzzzzzy_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzz_ as object);
            bool? bzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzza_, "day");

            return bzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzzzc_ = this.Patient(context);
        Date bzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzc_?.BirthDateElement;
        string bzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzd_?.Value;
        CqlDate bzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime bzzzzzzzzzzzzzzzh_ = context.Operators.End(bzzzzzzzzzzzzzzzg_);
        CqlDate bzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzh_);
        int? bzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(bzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzi_, "year");
        CqlInterval<int?> bzzzzzzzzzzzzzzzk_ = context.Operators.Interval(3, 17, true, true);
        bool? bzzzzzzzzzzzzzzzl_ = context.Operators.In<int?>(bzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzk_, default);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounters(context);
        bool? bzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzm_);
        bool? bzzzzzzzzzzzzzzzo_ = context.Operators.And(bzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzn_);

        return bzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Pregnancy Diagnosis Which Overlaps Measurement Period")]
    public IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzq_ = this.Pregnancy(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzzs_(Condition Pregnancy)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Pregnancy);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(bzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzv_, default);

            return bzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzs_);

        return bzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzx_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzzy_ = this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(context);
        bool? bzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzy_);
        bool? czzzzzzzzzzzzzzza_ = context.Operators.Or(bzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzz_);

        return czzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("BMI Percentile in Measurement Period")]
    public IEnumerable<Observation> BMI_Percentile_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> czzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isObservationBMI(context, czzzzzzzzzzzzzzzb_);
        bool? czzzzzzzzzzzzzzzd_(Observation BMIPercentile)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            DataType czzzzzzzzzzzzzzzg_ = BMIPercentile?.Effective;
            object czzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzh_);
            bool? czzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzi_, "day");
            DataType czzzzzzzzzzzzzzzk_ = BMIPercentile?.Value;
            CqlQuantity czzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzzzzzk_ as Quantity);
            bool? czzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzl_ is null));
            bool? czzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzm_);

            return czzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzd_);

        return czzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Height in Measurement Period")]
    public IEnumerable<Observation> Height_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyheight"));
        IEnumerable<Observation> czzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isObservationBodyHeight(context, czzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzq_(Observation Height)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            DataType czzzzzzzzzzzzzzzt_ = Height?.Effective;
            object czzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzu_);
            bool? czzzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzv_, "day");
            DataType czzzzzzzzzzzzzzzx_ = Height?.Value;
            CqlQuantity czzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzzzzzx_ as Quantity);
            bool? czzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzy_ is null));
            bool? dzzzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzq_);

        return czzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Weight in Measurement Period")]
    public IEnumerable<Observation> Weight_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isObservationBodyWeight(context, dzzzzzzzzzzzzzzzb_);
        bool? dzzzzzzzzzzzzzzzd_(Observation Weight)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            DataType dzzzzzzzzzzzzzzzg_ = Weight?.Effective;
            object dzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzh_);
            bool? dzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzi_, "day");
            DataType dzzzzzzzzzzzzzzzk_ = Weight?.Value;
            CqlQuantity dzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzzzzzzzk_ as Quantity);
            bool? dzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzl_ is null));
            bool? dzzzzzzzzzzzzzzzn_ = context.Operators.And(dzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzm_);

            return dzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzd_);

        return dzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzo_ = this.BMI_Percentile_in_Measurement_Period(context);
        bool? dzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzq_ = this.Height_in_Measurement_Period(context);
        bool? dzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzzzq_);
        bool? dzzzzzzzzzzzzzzzs_ = context.Operators.And(dzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzt_ = this.Weight_in_Measurement_Period(context);
        bool? dzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(dzzzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzu_);

        return dzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzw_ = this.Counseling_for_Nutrition(context);
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> dzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isInterventionPerformed(context, dzzzzzzzzzzzzzzzx_);
        bool? dzzzzzzzzzzzzzzzz_(Procedure NutritionCounseling)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            DataType ezzzzzzzzzzzzzzzd_ = NutritionCounseling?.Performed;
            object ezzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzze_);
            bool? ezzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzf_, "day");

            return ezzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(dzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzz_);
        bool? ezzzzzzzzzzzzzzzb_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzh_ = this.Counseling_for_Physical_Activity(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isInterventionPerformed(context, ezzzzzzzzzzzzzzzi_);
        bool? ezzzzzzzzzzzzzzzk_(Procedure ActivityCounseling)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            DataType ezzzzzzzzzzzzzzzo_ = ActivityCounseling?.Performed;
            object ezzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzp_);
            bool? ezzzzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzq_, "day");

            return ezzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzk_);
        bool? ezzzzzzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzzzzl_);

        return ezzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Stratifaction 1")]
    public bool? Stratifaction_1(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzs_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzzt_ = ezzzzzzzzzzzzzzzs_?.BirthDateElement;
        string ezzzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzzt_?.Value;
        CqlDate ezzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzu_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzx_ = context.Operators.End(ezzzzzzzzzzzzzzzw_);
        CqlDate ezzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzx_);
        int? ezzzzzzzzzzzzzzzz_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzy_, "year");
        CqlInterval<int?> fzzzzzzzzzzzzzzza_ = context.Operators.Interval(3, 11, true, true);
        bool? fzzzzzzzzzzzzzzzb_ = context.Operators.In<int?>(ezzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzza_, default);

        return fzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Stratifaction 2")]
    public bool? Stratifaction_2(CqlContext context)
    {
        Patient fzzzzzzzzzzzzzzzc_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzd_ = fzzzzzzzzzzzzzzzc_?.BirthDateElement;
        string fzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzd_?.Value;
        CqlDate fzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzzzzh_ = context.Operators.End(fzzzzzzzzzzzzzzzg_);
        CqlDate fzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzh_);
        int? fzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzi_, "year");
        CqlInterval<int?> fzzzzzzzzzzzzzzzk_ = context.Operators.Interval(12, 17, true, true);
        bool? fzzzzzzzzzzzzzzzl_ = context.Operators.In<int?>(fzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzk_, default);

        return fzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
