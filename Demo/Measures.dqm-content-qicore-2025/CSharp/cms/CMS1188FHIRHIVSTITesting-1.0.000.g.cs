#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS1188FHIRHIVSTITesting", "1.0.000")]
public partial class CMS1188FHIRHIVSTITesting_1_0_000 : ILibrary, ISingleton<CMS1188FHIRHIVSTITesting_1_0_000>
{
    #region ValueSets (15)

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Chlamydia Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", valueSetVersion: null)]
    public CqlValueSet Chlamydia_Screening(CqlContext _) => _Chlamydia_Screening;
    private static readonly CqlValueSet _Chlamydia_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375", null);

    [CqlValueSetDefinition("Gonorrhea Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.1", valueSetVersion: null)]
    public CqlValueSet Gonorrhea_Screening(CqlContext _) => _Gonorrhea_Screening;
    private static readonly CqlValueSet _Gonorrhea_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.1", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Preventive Care Services Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext _) => _Preventive_Care_Services_Other;
    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

    [CqlValueSetDefinition("Syphilis Tests", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.389", valueSetVersion: null)]
    public CqlValueSet Syphilis_Tests(CqlContext _) => _Syphilis_Tests;
    private static readonly CqlValueSet _Syphilis_Tests = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.389", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -7499856264790728684L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS1188FHIRHIVSTITesting-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (14)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7409433686009501412L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter_During_Measurement_Period, Has_Qualifying_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter_During_Measurement_Period = -44229219208618081L;

    private bool? Has_Qualifying_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? c_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);
        CqlValueSet? f_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter?>? g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? h_ = this.Face_to_Face_Interaction(context);
        IEnumerable<Encounter?>? i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(g_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(e_, j_);
        CqlValueSet? l_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter?>? m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter?>? o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? p_ = context.Operators.Union<Encounter?>(m_, o_);
        IEnumerable<Encounter?>? q_ = context.Operators.Union<Encounter?>(k_, p_);
        CqlValueSet? r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter?>? s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? v_ = context.Operators.Union<Encounter?>(s_, u_);
        IEnumerable<Encounter?>? w_ = context.Operators.Union<Encounter?>(q_, v_);
        CqlValueSet? x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter?>? y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? z_ = this.Telephone_Visits(context);
        IEnumerable<Encounter?>? aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? ab_ = context.Operators.Union<Encounter?>(y_, aa_);
        IEnumerable<Encounter?>? ac_ = context.Operators.Union<Encounter?>(w_, ab_);
        CqlValueSet? ad_ = this.Preventive_Care_Services_Other(context);
        IEnumerable<Encounter?>? ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? af_ = context.Operators.Union<Encounter?>(ac_, ae_);

        bool? ag_(Encounter? QualifyingEncounter) {
            CqlInterval<CqlDateTime?>? ai_ = this.Measurement_Period(context);
            Period? aj_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
            bool? al_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(ai_, ak_, "day");
            Code<Encounter.EncounterStatus>? am_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? an_ = am_?.Value;
            Code<Encounter.EncounterStatus>? ao_ = context.Operators.Convert<Code<Encounter.EncounterStatus>?>(an_);
            bool? ap_ = context.Operators.Equal(ao_, "finished");
            bool? aq_ = context.Operators.And(al_, ap_);
            return aq_;
        }

        bool? ah_ = context.Operators.WhereAny<Encounter?>(af_, ag_);
        return ah_;
    }


    [CqlFunctionDefinition("isVerified")]
    public bool? isVerified(CqlContext context, Condition? condition)
    {
        CodeableConcept? a_ = condition?.VerificationStatus;
        CqlConcept? b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode? d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept? e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode? g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept? h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode? k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept? l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode? o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept? p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Has HIV Diagnosis Before End of Measurement Period")]
    public bool? Has_HIV_Diagnosis_Before_End_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_HIV_Diagnosis_Before_End_of_Measurement_Period, Has_HIV_Diagnosis_Before_End_of_Measurement_Period_Compute);

    private const long _cacheIndex_Has_HIV_Diagnosis_Before_End_of_Measurement_Period = -7292671796849614126L;

    private bool? Has_HIV_Diagnosis_Before_End_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.HIV(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);

        bool? e_(Condition? HIVDx) {
            CqlInterval<CqlDateTime?>? g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime? h_ = context.Operators.Start(g_);
            CqlInterval<CqlDateTime?>? i_ = this.Measurement_Period(context);
            CqlDateTime? j_ = context.Operators.End(i_);
            bool? k_ = context.Operators.SameOrBefore(h_, j_, "day");
            bool? l_ = this.isVerified(context, HIVDx);
            bool? m_ = context.Operators.And(k_, l_);
            return m_;
        }

        bool? f_ = context.Operators.WhereAny<Condition?>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 4471597997769822028L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 13);
        bool? j_ = this.Has_Qualifying_Encounter_During_Measurement_Period(context);
        bool? k_ = context.Operators.And(i_, j_);
        bool? l_ = this.Has_HIV_Diagnosis_Before_End_of_Measurement_Period(context);
        bool? m_ = context.Operators.And(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -2657190060784088045L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Chlamydia Testing")]
    public bool? Has_Chlamydia_Testing(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Chlamydia_Testing, Has_Chlamydia_Testing_Compute);

    private const long _cacheIndex_Has_Chlamydia_Testing = -8881862878889127322L;

    private bool? Has_Chlamydia_Testing_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Chlamydia_Screening(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation? ChlamydiaTest) {
            DataType? e_ = ChlamydiaTest?.Value;
            object? f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            Code<ObservationStatus>? h_ = ChlamydiaTest?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string? j_ = context.Operators.Convert<string?>(i_);
            string?[]? k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string?>(j_, (IEnumerable<string?>?)k_);
            bool? m_ = context.Operators.And(g_, l_);
            object? n_;
            DataType? s_ = ChlamydiaTest?.Effective;
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType? v_ = ChlamydiaTest?.Effective;
                object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                n_ = w_ as CqlDateTime;
            }
            else
            {
                DataType? x_ = ChlamydiaTest?.Effective;
                object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType? aa_ = ChlamydiaTest?.Effective;
                    object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    n_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType? ac_ = ChlamydiaTest?.Effective;
                    object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType? af_ = ChlamydiaTest?.Effective;
                        object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        n_ = ag_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        n_ = null;
                    }
                }
            }
            CqlDateTime? o_ = QICoreCommon_4_0_000.Instance.latest(context, n_);
            CqlInterval<CqlDateTime?>? p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime?>(o_, p_, "day");
            bool? r_ = context.Operators.And(m_, q_);
            return r_;
        }

        bool? d_ = context.Operators.WhereAny<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Gonorrhea Testing")]
    public bool? Has_Gonorrhea_Testing(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Gonorrhea_Testing, Has_Gonorrhea_Testing_Compute);

    private const long _cacheIndex_Has_Gonorrhea_Testing = -8502615815305729511L;

    private bool? Has_Gonorrhea_Testing_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Gonorrhea_Screening(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation? GonorrheaTest) {
            DataType? e_ = GonorrheaTest?.Value;
            object? f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            Code<ObservationStatus>? h_ = GonorrheaTest?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string? j_ = context.Operators.Convert<string?>(i_);
            string?[]? k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string?>(j_, (IEnumerable<string?>?)k_);
            bool? m_ = context.Operators.And(g_, l_);
            object? n_;
            DataType? s_ = GonorrheaTest?.Effective;
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType? v_ = GonorrheaTest?.Effective;
                object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                n_ = w_ as CqlDateTime;
            }
            else
            {
                DataType? x_ = GonorrheaTest?.Effective;
                object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType? aa_ = GonorrheaTest?.Effective;
                    object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    n_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType? ac_ = GonorrheaTest?.Effective;
                    object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType? af_ = GonorrheaTest?.Effective;
                        object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        n_ = ag_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        n_ = null;
                    }
                }
            }
            CqlDateTime? o_ = QICoreCommon_4_0_000.Instance.latest(context, n_);
            CqlInterval<CqlDateTime?>? p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime?>(o_, p_, "day");
            bool? r_ = context.Operators.And(m_, q_);
            return r_;
        }

        bool? d_ = context.Operators.WhereAny<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Syphilis Testing")]
    public bool? Has_Syphilis_Testing(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Syphilis_Testing, Has_Syphilis_Testing_Compute);

    private const long _cacheIndex_Has_Syphilis_Testing = 7686213639457514893L;

    private bool? Has_Syphilis_Testing_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Syphilis_Tests(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation? SyphilisTest) {
            DataType? e_ = SyphilisTest?.Value;
            object? f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            Code<ObservationStatus>? h_ = SyphilisTest?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string? j_ = context.Operators.Convert<string?>(i_);
            string?[]? k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string?>(j_, (IEnumerable<string?>?)k_);
            bool? m_ = context.Operators.And(g_, l_);
            object? n_;
            DataType? s_ = SyphilisTest?.Effective;
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                DataType? v_ = SyphilisTest?.Effective;
                object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                n_ = w_ as CqlDateTime;
            }
            else
            {
                DataType? x_ = SyphilisTest?.Effective;
                object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                bool z_ = y_ is CqlDateTime;
                if (z_)
                {
                    DataType? aa_ = SyphilisTest?.Effective;
                    object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    n_ = ab_ as CqlDateTime;
                }
                else
                {
                    DataType? ac_ = SyphilisTest?.Effective;
                    object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        DataType? af_ = SyphilisTest?.Effective;
                        object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        n_ = ag_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        n_ = null;
                    }
                }
            }
            CqlDateTime? o_ = QICoreCommon_4_0_000.Instance.latest(context, n_);
            CqlInterval<CqlDateTime?>? p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime?>(o_, p_, "day");
            bool? r_ = context.Operators.And(m_, q_);
            return r_;
        }

        bool? d_ = context.Operators.WhereAny<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 5205330117834525639L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Chlamydia_Testing(context);
        bool? b_ = this.Has_Gonorrhea_Testing(context);
        bool? c_ = context.Operators.And(a_, b_);
        bool? d_ = this.Has_Syphilis_Testing(context);
        bool? e_ = context.Operators.And(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 1798453950093290862L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7550824248673390558L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -6756198988775072204L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -5848999743963259095L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1188FHIRHIVSTITesting_1_0_000() {}

    public static CMS1188FHIRHIVSTITesting_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1188FHIRHIVSTITesting";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
