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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR", "0.1.001")]
public partial class WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_minus_0_1_001 : ILibrary, ISingleton<WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_minus_0_1_001>
{
    private WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_minus_0_1_001() {}

    public static WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_minus_0_1_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR";
    public string Version => "0.1.001";
    public ILibrary[] Dependencies => [FHIRHelpers_minus_4_4_000.Instance, QICoreCommon_minus_2_1_000.Instance, SupplementalDataElements_minus_3_5_000.Instance, Hospice_minus_6_12_000.Instance, Status_minus_1_8_000.Instance];

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

    [CqlCodeSystemDefinition("UCUM", codeSystemId: "http://unitsofmeasure.org", codeSystemVersion: null)]
    public CqlCodeSystem UCUM(CqlContext _) => _UCUM;
    private static readonly CqlCodeSystem _UCUM =
      new CqlCodeSystem("http://unitsofmeasure.org", null, []);

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(q_, s_);
        IEnumerable<Encounter> u_ = Status_minus_1_8_000.Instance.isEncounterPerformed(context, t_);
        bool? v_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
            Period y_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, y_);
            CqlInterval<CqlDateTime> aa_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, z_ as object);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, "day");

            return ab_;
        };
        IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);

        return w_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(3, 17, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.And(j_, l_);

        return m_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Pregnancy Diagnosis Which Overlaps Measurement Period")]
    public IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Pregnancy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition Pregnancy)
        {
            CqlInterval<CqlDateTime> e_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, Pregnancy);
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            bool? g_ = context.Operators.Overlaps(e_, f_, default);

            return g_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_minus_6_12_000.Instance.Has_Hospice_Services(context);
        IEnumerable<Condition> b_ = this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Condition>(b_);
        bool? d_ = context.Operators.Or(a_, c_);

        return d_;
    }


    [CqlExpressionDefinition("BMI Percentile in Measurement Period")]
    public IEnumerable<Observation> BMI_Percentile_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
        IEnumerable<Observation> b_ = Status_minus_1_8_000.Instance.isObservationBMI(context, a_);
        bool? c_(Observation BMIPercentile)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            DataType f_ = BMIPercentile?.Effective;
            object g_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
            DataType j_ = BMIPercentile?.Value;
            CqlQuantity k_ = FHIRHelpers_minus_4_4_000.Instance.ToQuantity(context, j_ as Quantity);
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            bool? m_ = context.Operators.And(i_, l_);

            return m_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Height in Measurement Period")]
    public IEnumerable<Observation> Height_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyheight"));
        IEnumerable<Observation> b_ = Status_minus_1_8_000.Instance.isObservationBodyHeight(context, a_);
        bool? c_(Observation Height)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            DataType f_ = Height?.Effective;
            object g_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
            DataType j_ = Height?.Value;
            CqlQuantity k_ = FHIRHelpers_minus_4_4_000.Instance.ToQuantity(context, j_ as Quantity);
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            bool? m_ = context.Operators.And(i_, l_);

            return m_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Weight in Measurement Period")]
    public IEnumerable<Observation> Weight_in_Measurement_Period(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
        IEnumerable<Observation> b_ = Status_minus_1_8_000.Instance.isObservationBodyWeight(context, a_);
        bool? c_(Observation Weight)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            DataType f_ = Weight?.Effective;
            object g_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, g_);
            bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
            DataType j_ = Weight?.Value;
            CqlQuantity k_ = FHIRHelpers_minus_4_4_000.Instance.ToQuantity(context, j_ as Quantity);
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            bool? m_ = context.Operators.And(i_, l_);

            return m_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.BMI_Percentile_in_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.Height_in_Measurement_Period(context);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        bool? e_ = context.Operators.And(b_, d_);
        IEnumerable<Observation> f_ = this.Weight_in_Measurement_Period(context);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        bool? h_ = context.Operators.And(e_, g_);

        return h_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        CqlValueSet a_ = this.Counseling_for_Nutrition(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_minus_1_8_000.Instance.isInterventionPerformed(context, b_);
        bool? d_(Procedure NutritionCounseling)
        {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            DataType h_ = NutritionCounseling?.Performed;
            object i_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, i_);
            bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

            return k_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        bool? f_ = context.Operators.Exists<Procedure>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        CqlValueSet a_ = this.Counseling_for_Physical_Activity(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_minus_1_8_000.Instance.isInterventionPerformed(context, b_);
        bool? d_(Procedure ActivityCounseling)
        {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            DataType h_ = ActivityCounseling?.Performed;
            object i_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, i_);
            bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

            return k_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        bool? f_ = context.Operators.Exists<Procedure>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Stratifaction 1")]
    public bool? Stratifaction_1(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(3, 11, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }


    [CqlExpressionDefinition("Stratifaction 2")]
    public bool? Stratifaction_2(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(12, 17, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);

        return j_;
    }


    #endregion Functions and Expressions

}
