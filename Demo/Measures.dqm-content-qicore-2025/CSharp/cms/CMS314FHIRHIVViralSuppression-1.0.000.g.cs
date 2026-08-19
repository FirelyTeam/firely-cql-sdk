#nullable enable

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
[CqlLibrary("CMS314FHIRHIVViralSuppression", "1.0.000")]
public partial class CMS314FHIRHIVViralSuppression_1_0_000 : ILibrary, ISingleton<CMS314FHIRHIVViralSuppression_1_0_000>
{
    #region ValueSets (13)

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375", null);

    [CqlValueSetDefinition("HIV", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", valueSetVersion: null)]
    public CqlValueSet HIV(CqlContext _) => _HIV;
    private static readonly CqlValueSet _HIV = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlValueSetDefinition("HIV Viral Load Tests", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.377", valueSetVersion: null)]
    public CqlValueSet HIV_Viral_Load_Tests(CqlContext _) => _HIV_Viral_Load_Tests;
    private static readonly CqlValueSet _HIV_Viral_Load_Tests = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.377", null);

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

    [CqlValueSetDefinition("Preventive Care Services Other", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Other(CqlContext _) => _Preventive_Care_Services_Other;
    private static readonly CqlValueSet _Preventive_Care_Services_Other = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Below threshold level (qualifier value)", codeId: "260988000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Below_threshold_level__qualifier_value_(CqlContext _) => _Below_threshold_level__qualifier_value_;
    private static readonly CqlCode _Below_threshold_level__qualifier_value_ = new CqlCode("260988000", "http://snomed.info/sct");

    [CqlCodeDefinition("Not detected (qualifier value)", codeId: "260415000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Not_detected__qualifier_value_(CqlContext _) => _Not_detected__qualifier_value_;
    private static readonly CqlCode _Not_detected__qualifier_value_ = new CqlCode("260415000", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Below_threshold_level__qualifier_value_,
          _Not_detected__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -6927895824144681510L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS314FHIRHIVViralSuppression-1.0.000"!, ("Measurement Period")!, c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (12)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 1508344630371504510L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
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


    [CqlExpressionDefinition("Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period")]
    public bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period, Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period = 9084217600003640711L;

    private bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.HIV(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition?>(b_ as IEnumerable<Condition?>, c_ as IEnumerable<Condition?>);

        bool? e_(Condition? HIVDx) {
            CqlInterval<CqlDateTime?>? g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HIVDx);
            CqlDateTime? h_ = context.Operators.Start(g_);
            CqlInterval<CqlDateTime?>? i_ = this.Measurement_Period(context);
            CqlDateTime? j_ = context.Operators.Start(i_);
            CqlQuantity? k_ = context.Operators.Quantity(90m, "days");
            CqlDateTime? l_ = context.Operators.Add(j_, k_);
            bool? m_ = context.Operators.Before(h_, l_, "day");
            bool? n_ = this.isVerified(context, HIVDx);
            bool? o_ = context.Operators.And(m_, n_);
            return o_;
        }

        bool? f_ = context.Operators.WhereAny<Condition?>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter During First 240 Days of Measurement Period")]
    public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period, Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period = 5598016734118204379L;

    private bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Compute(CqlContext context)
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
            CqlDateTime? aj_ = context.Operators.Start(ai_);
            CqlQuantity? ak_ = context.Operators.Quantity(240m, "days");
            CqlDateTime? al_ = context.Operators.Add(aj_, ak_);
            CqlInterval<CqlDateTime?>? am_ = context.Operators.Interval(aj_, al_, true, true);
            Period? an_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime?>? ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
            bool? ap_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(am_, ao_, "day");
            Code<Encounter.EncounterStatus>? aq_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? ar_ = aq_?.Value;
            Code<Encounter.EncounterStatus>? as_ = context.Operators.Convert<Code<Encounter.EncounterStatus>?>(ar_);
            bool? at_ = context.Operators.Equal(as_, "finished");
            bool? au_ = context.Operators.And(ap_, at_);
            return au_;
        }

        bool? ah_ = context.Operators.WhereAny<Encounter?>(af_, ag_);
        return ah_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -163170386306154998L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(context);
        bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
        bool? c_ = context.Operators.And(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 8675153568766099078L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Most Recent Viral Load Test During Measurement Period")]
    public Observation? Most_Recent_Viral_Load_Test_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Viral_Load_Test_During_Measurement_Period, Most_Recent_Viral_Load_Test_During_Measurement_Period_Compute);

    private const long _cacheIndex_Most_Recent_Viral_Load_Test_During_Measurement_Period = -2919481681531419562L;

    private Observation? Most_Recent_Viral_Load_Test_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.HIV_Viral_Load_Tests(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

        bool? c_(Observation? ViralLoad) {
            Code<ObservationStatus>? h_ = ViralLoad?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string? j_ = context.Operators.Convert<string?>(i_);
            string?[]? k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string?>(j_, (IEnumerable<string?>?)k_);
            object? m_;
            DataType? r_ = ViralLoad?.Effective;
            object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            bool t_ = s_ is CqlDateTime;
            if (t_)
            {
                DataType? u_ = ViralLoad?.Effective;
                object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                m_ = v_ as CqlDateTime;
            }
            else
            {
                DataType? w_ = ViralLoad?.Effective;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType? z_ = ViralLoad?.Effective;
                    object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    m_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType? ab_ = ViralLoad?.Effective;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        DataType? ae_ = ViralLoad?.Effective;
                        object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        m_ = af_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        m_ = null;
                    }
                }
            }
            CqlDateTime? n_ = QICoreCommon_4_0_000.Instance.latest(context, m_);
            CqlInterval<CqlDateTime?>? o_ = this.Measurement_Period(context);
            bool? p_ = context.Operators.In<CqlDateTime?>(n_, o_, "day");
            bool? q_ = context.Operators.And(l_, p_);
            return q_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);

        object e_(Observation? @this) {
            object? ag_;
            DataType? ai_ = @this?.Effective;
            object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            bool ak_ = aj_ is CqlDateTime;
            if (ak_)
            {
                DataType? al_ = @this?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                ag_ = am_ as CqlDateTime;
            }
            else
            {
                DataType? an_ = @this?.Effective;
                object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlDateTime;
                if (ap_)
                {
                    DataType? aq_ = @this?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    ag_ = ar_ as CqlDateTime;
                }
                else
                {
                    DataType? as_ = @this?.Effective;
                    object? at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlInterval<CqlDateTime>;
                    if (au_)
                    {
                        DataType? av_ = @this?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        ag_ = aw_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        ag_ = null;
                    }
                }
            }
            CqlDateTime? ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            return ah_!;
        }

        IEnumerable<Observation?>? f_ = context.Operators.SortBy<Observation?>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? g_ = context.Operators.Last<Observation?>(f_!);
        return g_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -1138962506797556328L;

    private bool? Numerator_Compute(CqlContext context)
    {
        Observation? a_ = this.Most_Recent_Viral_Load_Test_During_Measurement_Period(context);
        DataType? b_ = a_?.Value;
        object? c_ = FHIRHelpers_4_4_000.Instance.ToValue(context, b_);
        CqlQuantity? d_ = context.Operators.Quantity(200m, "{copies}/mL");
        bool? e_ = context.Operators.Less(c_ as CqlQuantity, d_);
        CqlCode? f_ = this.Below_threshold_level__qualifier_value_(context);
        CqlConcept? g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(c_ as CqlConcept, g_);
        bool? i_ = context.Operators.Or(e_, h_);
        CqlCode? j_ = this.Not_detected__qualifier_value_(context);
        CqlConcept? k_ = context.Operators.ConvertCodeToConcept(j_);
        bool? l_ = context.Operators.Equivalent(c_ as CqlConcept, k_);
        bool? m_ = context.Operators.Or(i_, l_);
        return m_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 4660943779846174823L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -744218048430331554L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 3734889542787538106L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -3747546672814054468L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS314FHIRHIVViralSuppression_1_0_000() {}

    public static CMS314FHIRHIVViralSuppression_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS314FHIRHIVViralSuppression";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
