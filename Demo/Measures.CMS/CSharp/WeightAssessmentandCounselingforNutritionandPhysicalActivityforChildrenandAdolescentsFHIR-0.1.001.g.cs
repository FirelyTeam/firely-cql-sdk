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

    #region ValueSet: Counseling for Nutrition
    [CqlValueSetDefinition(
        definitionName: "Counseling for Nutrition",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003",
        valueSetVersion: null)]
    public CqlValueSet Counseling_for_Nutrition(CqlContext context) => _Counseling_for_Nutrition;

    private static readonly CqlValueSet _Counseling_for_Nutrition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003", null);
    #endregion

    #region ValueSet: Counseling for Physical Activity
    [CqlValueSetDefinition(
        definitionName: "Counseling for Physical Activity",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035",
        valueSetVersion: null)]
    public CqlValueSet Counseling_for_Physical_Activity(CqlContext context) => _Counseling_for_Physical_Activity;

    private static readonly CqlValueSet _Counseling_for_Physical_Activity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Pregnancy
    [CqlValueSetDefinition(
        definitionName: "Pregnancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378",
        valueSetVersion: null)]
    public CqlValueSet Pregnancy(CqlContext context) => _Pregnancy;

    private static readonly CqlValueSet _Pregnancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);
    #endregion

    #region ValueSet: Preventive Care Services Group Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Group Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => _Preventive_Care_Services_Group_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care Services Individual Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Individual Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => _Preventive_Care_Services_Individual_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "UCUM")]
    public CqlCode[] UCUM(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzm_ = []
;

        return azzzzzzzzzzzzzzzzzm_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzn_ = []
;

        return azzzzzzzzzzzzzzzzzn_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ObservationCategoryCodes")]
    public CqlCode[] ObservationCategoryCodes(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzo_ = []
;

        return azzzzzzzzzzzzzzzzzo_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzq_, true, true);
        object azzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.001", "Measurement Period", azzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzt_);

        return azzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzz_ = this.Office_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzc_);
        CqlValueSet bzzzzzzzzzzzzzzzzze_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzi_);
        CqlValueSet bzzzzzzzzzzzzzzzzzk_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzm_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzo_);
        CqlValueSet bzzzzzzzzzzzzzzzzzq_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isEncounterPerformed(context, bzzzzzzzzzzzzzzzzzs_);
        bool? bzzzzzzzzzzzzzzzzzu_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzzzzzx_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzy_ as object);
            bool? czzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzz_, "day");

            return czzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzu_);

        return bzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzd_ = czzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate czzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzzzzg_ = context.Operators.End(czzzzzzzzzzzzzzzzzf_);
        CqlDate czzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzg_);
        int? czzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzh_, "year");
        CqlInterval<int?> czzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(3, 17, true, true);
        bool? czzzzzzzzzzzzzzzzzk_ = context.Operators.In<int?>(czzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzj_, default);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzl_ = this.Qualifying_Encounters(context);
        bool? czzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzzzzzl_);
        bool? czzzzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzm_);

        return czzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzo_ = this.Initial_Population(context);

        return czzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Pregnancy Diagnosis Which Overlaps Measurement Period")]
    public IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzp_ = this.Pregnancy(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzzr_(Condition Pregnancy)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Pregnancy);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzv_ = context.Operators.Overlaps(czzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzu_, default);

            return czzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzr_);

        return czzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? czzzzzzzzzzzzzzzzzw_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzx_ = this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(context);
        bool? czzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzx_);
        bool? czzzzzzzzzzzzzzzzzz_ = context.Operators.Or(czzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzy_);

        return czzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "BMI Percentile in Measurement Period")]
    public IEnumerable<Observation> BMI_Percentile_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isObservationBMI(context, dzzzzzzzzzzzzzzzzza_);
        bool? dzzzzzzzzzzzzzzzzzc_(Observation BMIPercentile)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            DataType dzzzzzzzzzzzzzzzzzf_ = BMIPercentile?.Effective;
            object dzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzg_);
            bool? dzzzzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzh_, "day");
            DataType dzzzzzzzzzzzzzzzzzj_ = BMIPercentile?.Value;
            CqlQuantity dzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzzzzzzzzzj_ as Quantity);
            bool? dzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzk_ is null));
            bool? dzzzzzzzzzzzzzzzzzm_ = context.Operators.And(dzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzl_);

            return dzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzc_);

        return dzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Height in Measurement Period")]
    public IEnumerable<Observation> Height_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyheight"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isObservationBodyHeight(context, dzzzzzzzzzzzzzzzzzn_);
        bool? dzzzzzzzzzzzzzzzzzp_(Observation Height)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            DataType dzzzzzzzzzzzzzzzzzs_ = Height?.Effective;
            object dzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzt_);
            bool? dzzzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzu_, "day");
            DataType dzzzzzzzzzzzzzzzzzw_ = Height?.Value;
            CqlQuantity dzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzzzzzzzzzw_ as Quantity);
            bool? dzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzx_ is null));
            bool? dzzzzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzy_);

            return dzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzp_);

        return dzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Weight in Measurement Period")]
    public IEnumerable<Observation> Weight_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isObservationBodyWeight(context, ezzzzzzzzzzzzzzzzza_);
        bool? ezzzzzzzzzzzzzzzzzc_(Observation Weight)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            DataType ezzzzzzzzzzzzzzzzzf_ = Weight?.Effective;
            object ezzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzh_, "day");
            DataType ezzzzzzzzzzzzzzzzzj_ = Weight?.Value;
            CqlQuantity ezzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ezzzzzzzzzzzzzzzzzj_ as Quantity);
            bool? ezzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzk_ is null));
            bool? ezzzzzzzzzzzzzzzzzm_ = context.Operators.And(ezzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzn_ = this.BMI_Percentile_in_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzp_ = this.Height_in_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzp_);
        bool? ezzzzzzzzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzs_ = this.Weight_in_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzs_);
        bool? ezzzzzzzzzzzzzzzzzu_ = context.Operators.And(ezzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzt_);

        return ezzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzv_ = this.Counseling_for_Nutrition(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isInterventionPerformed(context, ezzzzzzzzzzzzzzzzzw_);
        bool? ezzzzzzzzzzzzzzzzzy_(Procedure NutritionCounseling)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            DataType fzzzzzzzzzzzzzzzzzc_ = NutritionCounseling?.Performed;
            object fzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzd_);
            bool? fzzzzzzzzzzzzzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzze_, "day");

            return fzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Procedure> ezzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzy_);
        bool? fzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Procedure>(ezzzzzzzzzzzzzzzzzz_);

        return fzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzg_ = this.Counseling_for_Physical_Activity(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isInterventionPerformed(context, fzzzzzzzzzzzzzzzzzh_);
        bool? fzzzzzzzzzzzzzzzzzj_(Procedure ActivityCounseling)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            DataType fzzzzzzzzzzzzzzzzzn_ = ActivityCounseling?.Performed;
            object fzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzo_);
            bool? fzzzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzp_, "day");

            return fzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzj_);
        bool? fzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzzzk_);

        return fzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratifaction 1")]
    public bool? Stratifaction_1(CqlContext context)
    {
        Patient fzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzzzs_ = fzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate fzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzzzzzzw_ = context.Operators.End(fzzzzzzzzzzzzzzzzzv_);
        CqlDate fzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzw_);
        int? fzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzx_, "year");
        CqlInterval<int?> fzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(3, 11, true, true);
        bool? gzzzzzzzzzzzzzzzzza_ = context.Operators.In<int?>(fzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzz_, default);

        return gzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Stratifaction 2")]
    public bool? Stratifaction_2(CqlContext context)
    {
        Patient gzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date gzzzzzzzzzzzzzzzzzc_ = gzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string gzzzzzzzzzzzzzzzzzd_ = gzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate gzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzzzzzzzzzzzg_ = context.Operators.End(gzzzzzzzzzzzzzzzzzf_);
        CqlDate gzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzg_);
        int? gzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzh_, "year");
        CqlInterval<int?> gzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(12, 17, true, true);
        bool? gzzzzzzzzzzzzzzzzzk_ = context.Operators.In<int?>(gzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzj_, default);

        return gzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
