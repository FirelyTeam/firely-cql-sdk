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
    private static readonly CqlCodeSystem _UCUM = new CqlCodeSystem();

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ObservationCategoryCodes")]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
        object qzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.ResolveParameter("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.001", "Measurement Period", qzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> qzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode qzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isEncounterPerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            Period rzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return rzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient rzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
        Date rzzzzzzzzzzzzzzzzzzzzzzzzzo_ = rzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
        string rzzzzzzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? rzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> rzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(3, 17, true, true);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<int?>(rzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Qualifying_Encounters(context);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Pregnancy Diagnosis Which Overlaps Measurement Period")]
    public IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Pregnancy(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzd_(Condition Pregnancy)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Pregnancy);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(szzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzg_, default);

            return szzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return szzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzi_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> szzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Condition>(szzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("BMI Percentile in Measurement Period")]
    public IEnumerable<Observation> BMI_Percentile_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isObservationBMI(context, szzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation BMIPercentile)
        {
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzr_ = BMIPercentile?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzv_ = BMIPercentile?.Value;
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzzzzzzzzzv_ as Quantity);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Height in Measurement Period")]
    public IEnumerable<Observation> Height_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyheight"));
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isObservationBodyHeight(context, szzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation Height)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzze_ = Height?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Height?.Value;
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzzzzzzzzzzzzzzzzzzzzzzzi_ as Quantity);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Weight in Measurement Period")]
    public IEnumerable<Observation> Weight_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isObservationBodyWeight(context, tzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation Weight)
        {
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Weight?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Weight?.Value;
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzzzzzzzzzzzzzzzzzzzzzzzv_ as Quantity);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.BMI_Percentile_in_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Height_in_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Weight_in_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Counseling_for_Nutrition(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isInterventionPerformed(context, uzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure NutritionCounseling)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzo_ = NutritionCounseling?.Performed;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");

            return uzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Counseling_for_Physical_Activity(context);
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isInterventionPerformed(context, uzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzv_(Procedure ActivityCounseling)
        {
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ActivityCounseling?.Performed;
            object vzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

            return vzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Procedure>(uzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Stratifaction 1")]
    public bool? Stratifaction_1(CqlContext context)
    {
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
        Date vzzzzzzzzzzzzzzzzzzzzzzzzze_ = vzzzzzzzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
        string vzzzzzzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        int? vzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzj_, "year");
        CqlInterval<int?> vzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(3, 11, true, true);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<int?>(vzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Stratifaction 2")]
    public bool? Stratifaction_2(CqlContext context)
    {
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
        Date vzzzzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
        string vzzzzzzzzzzzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        int? vzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzt_, "year");
        CqlInterval<int?> vzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(12, 17, true, true);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<int?>(vzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Expressions

}
