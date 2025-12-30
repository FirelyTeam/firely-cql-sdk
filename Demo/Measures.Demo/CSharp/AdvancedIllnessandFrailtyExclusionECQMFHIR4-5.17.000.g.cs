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
[CqlLibrary("AdvancedIllnessandFrailtyExclusionECQMFHIR4", "5.17.000")]
public partial class AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 : ILibrary, ISingleton<AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000>
{
    private AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000() {}

    public static AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AdvancedIllnessandFrailtyExclusionECQMFHIR4";
    public string Version => "5.17.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheToken, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            if (cqlContext.CacheToken is null)
            {
                // No caching
                CacheToken = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheToken, cqlContext.CacheToken))
            {
                return CachedValue;
            }
            else
            {
                var value = factory();
                CachedValue = value;
                CacheToken = cqlContext.CacheToken;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Acute Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext _) => _Acute_Inpatient;
    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", null);

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlValueSetDefinition("Care Services in Long-Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Dementia Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext _) => _Dementia_Medications;
    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlValueSetDefinition("Frailty Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext _) => _Frailty_Device;
    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlValueSetDefinition("Frailty Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext _) => _Frailty_Diagnosis;
    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlValueSetDefinition("Frailty Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext _) => _Frailty_Encounter;
    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlValueSetDefinition("Frailty Symptom", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext _) => _Frailty_Symptom;
    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    [CqlValueSetDefinition("Nonacute Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext _) => _Nonacute_Inpatient;
    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Observation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext _) => _Observation;
    private static readonly CqlValueSet _Observation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", null);

    [CqlValueSetDefinition("Outpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext _) => _Outpatient;
    private static readonly CqlValueSet _Outpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    #endregion ValueSets

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<MedicationRequest>> _Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        _Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Dementia_Medications(context);
                IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
                IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
                IEnumerable<MedicationRequest> d_(MedicationRequest MR)
                {
                    IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
                    bool? j_(Medication M)
                    {
                        Id n_ = M?.IdElement;
                        string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
                        object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                        string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_ as FhirString);
                        IEnumerable<string> r_ = context.Operators.Split(q_, "/");
                        string s_ = context.Operators.Last<string>(r_);
                        bool? t_ = context.Operators.Equal(o_, s_);
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Dementia_Medications(context);
                        bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                        bool? y_ = context.Operators.And(t_, x_);
                        return y_;
                    };
                    IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
                    MedicationRequest l_(Medication M) =>
                    MR;
                    IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);
                    return m_;
                };
                IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
                IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
                bool? g_(MedicationRequest DementiaMed)
                {
                    Code<MedicationRequest.MedicationrequestStatus> z_ = DementiaMed?.StatusElement;
                    string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                    bool? ab_ = context.Operators.Equal(aa_, "active");
                    Code<MedicationRequest.MedicationRequestIntent> ac_ = DementiaMed?.IntentElement;
                    string ad_ = FHIRHelpers_4_0_001.Instance.ToString(context, ac_);
                    bool? ae_ = context.Operators.Equal(ad_, "order");
                    bool? af_ = context.Operators.And(ab_, ae_);
                    CqlInterval<CqlDateTime> ag_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed as object);
                    CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
                    CqlDateTime ai_ = context.Operators.Start(ah_);
                    CqlQuantity aj_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
                    CqlDateTime am_ = context.Operators.End(ah_);
                    CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ak_, am_, true, true);
                    bool? ao_ = context.Operators.Overlaps(ag_, an_, default);
                    bool? ap_ = context.Operators.And(af_, ao_);
                    return ap_;
                };
                IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
                return h_;
            });


    private Cached<IEnumerable<CqlInterval<CqlDateTime>>> _Long_Term_Care_Periods_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context) =>
        _Long_Term_Care_Periods_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                CqlValueSet c_ = this.Nursing_Facility_Visit(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                bool? f_(Encounter LongTermFacilityEncounter)
                {
                    Code<Encounter.EncounterStatus> k_ = LongTermFacilityEncounter?.StatusElement;
                    string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                    bool? m_ = context.Operators.Equal(l_, "finished");
                    Period n_ = LongTermFacilityEncounter?.Period;
                    CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, n_ as object);
                    CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                    bool? q_ = context.Operators.Overlaps(o_, p_, default);
                    bool? r_ = context.Operators.And(m_, q_);
                    return r_;
                };
                IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
                CqlInterval<CqlDateTime> h_(Encounter LongTermFacilityEncounter)
                {
                    Period s_ = LongTermFacilityEncounter?.Period;
                    CqlInterval<CqlDateTime> t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, s_ as object);
                    CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                    CqlInterval<CqlDateTime> v_ = context.Operators.Intersect<CqlDateTime>(t_, u_);
                    return v_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(g_, h_);
                IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(i_);
                return j_;
            });


    private Cached<IEnumerable<Encounter>> _Outpatient_Encounters_with_Advanced_Illness_Cached = new();

    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context) =>
        _Outpatient_Encounters_with_Advanced_Illness_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Outpatient(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                CqlValueSet c_ = this.Observation(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                CqlValueSet h_ = this.Nonacute_Inpatient(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                bool? l_(Encounter Outpatient)
                {
                    Code<Encounter.EncounterStatus> p_ = Outpatient?.StatusElement;
                    string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
                    bool? r_ = context.Operators.Equal(q_, "finished");
                    return r_;
                };
                IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);
                IEnumerable<Encounter> n_(Encounter OutpatientEncounter)
                {
                    CqlValueSet s_ = this.Advanced_Illness(context);
                    IEnumerable<Condition> t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                    bool? u_(Condition AdvancedIllnessDiagnosis)
                    {
                        IEnumerable<Condition> y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                        bool? z_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, y_);
                        Period aa_ = OutpatientEncounter?.Period;
                        CqlInterval<CqlDateTime> ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aa_ as object);
                        CqlDateTime ac_ = context.Operators.Start(ab_);
                        CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
                        CqlDateTime ae_ = context.Operators.End(ad_);
                        CqlQuantity af_ = context.Operators.Quantity(2m, "years");
                        CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                        CqlDateTime ai_ = context.Operators.End(ad_);
                        CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ag_, ai_, true, true);
                        bool? ak_ = context.Operators.In<CqlDateTime>(ac_, aj_, default);
                        CqlDateTime am_ = context.Operators.End(ad_);
                        bool? an_ = context.Operators.Not((bool?)(am_ is null));
                        bool? ao_ = context.Operators.And(ak_, an_);
                        bool? ap_ = context.Operators.And(z_, ao_);
                        return ap_;
                    };
                    IEnumerable<Condition> v_ = context.Operators.Where<Condition>(t_, u_);
                    Encounter w_(Condition AdvancedIllnessDiagnosis) =>
                    OutpatientEncounter;
                    IEnumerable<Encounter> x_ = context.Operators.Select<Condition, Encounter>(v_, w_);
                    return x_;
                };
                IEnumerable<Encounter> o_ = context.Operators.SelectMany<Encounter, Encounter>(m_, n_);
                return o_;
            });


    private Cached<IEnumerable<Encounter>> _Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Cached = new();

    [CqlExpressionDefinition("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context) =>
        _Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                IEnumerable<ValueTuple<Encounter, Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
                (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? d_(ValueTuple<Encounter, Encounter> _valueTuple)
                {
                    (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? k_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);
                    return k_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(c_, d_);
                bool? f_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia)
                {
                    Period l_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
                    CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
                    CqlDateTime n_ = context.Operators.End(m_);
                    Period o_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
                    CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_);
                    CqlDateTime q_ = context.Operators.End(p_);
                    CqlQuantity r_ = context.Operators.Quantity(1m, "day");
                    CqlDateTime s_ = context.Operators.Add(q_, r_);
                    bool? t_ = context.Operators.SameOrAfter(n_, s_, "day");
                    return t_;
                };
                IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(e_, f_);
                Encounter h_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) =>
                tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
                IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(g_, h_);
                IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);
                return j_;
            });


    private Cached<IEnumerable<CqlInterval<CqlDateTime>>> _Long_Term_Care_Overlapping_Periods_Cached = new();

    [CqlExpressionDefinition("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context) =>
        _Long_Term_Care_Overlapping_Periods_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
                IEnumerable<CqlInterval<CqlDateTime>> b_ = context.Operators.Collapse(a_, default);
                return b_;
            });


    private Cached<IEnumerable<CqlInterval<CqlDateTime>>> _Long_Term_Care_Adjacent_Periods_Cached = new();

    [CqlExpressionDefinition("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context) =>
        _Long_Term_Care_Adjacent_Periods_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Overlapping_Periods(context);
                IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>> c_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, a_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? d_(ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>> _valueTuple)
                {
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? k_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);
                    return k_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> e_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>, (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(c_, d_);
                bool? f_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
                {
                    CqlDateTime l_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
                    CqlDateTime m_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
                    CqlQuantity n_ = context.Operators.Quantity(1m, "day");
                    CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                    CqlDateTime r_ = context.Operators.Add(m_, n_);
                    CqlInterval<CqlDateTime> s_ = context.Operators.Interval(o_, r_, true, true);
                    bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
                    bool? v_ = context.Operators.Not((bool?)(m_ is null));
                    bool? w_ = context.Operators.And(t_, v_);
                    return w_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> g_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(e_, f_);
                CqlInterval<CqlDateTime> h_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb)
                {
                    CqlDateTime x_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
                    CqlDateTime y_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
                    CqlInterval<CqlDateTime> z_ = context.Operators.Interval(x_, y_, true, true);
                    return z_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?, CqlInterval<CqlDateTime>>(g_, h_);
                IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(i_);
                return j_;
            });


    private Cached<int?> _Max_Long_Term_Care_Period_Length_Cached = new();

    [CqlExpressionDefinition("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context) =>
        _Max_Long_Term_Care_Period_Length_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Overlapping_Periods(context);
                IEnumerable<CqlInterval<CqlDateTime>> b_ = this.Long_Term_Care_Adjacent_Periods(context);
                IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Union<CqlInterval<CqlDateTime>>(a_, b_);
                IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Collapse(c_, default);
                int? e_(CqlInterval<CqlDateTime> LTCPeriods)
                {
                    CqlDateTime i_ = context.Operators.Start(LTCPeriods);
                    CqlDateTime j_ = context.Operators.End(LTCPeriods);
                    int? k_ = context.Operators.DurationBetween(i_, j_, "day");
                    return k_;
                };
                IEnumerable<int?> f_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(d_, e_);
                IEnumerable<int?> g_ = context.Operators.Distinct<int?>(f_);
                int? h_ = context.Operators.Max<int?>(g_);
                return h_;
            });


    private Cached<IEnumerable<Encounter>> _Inpatient_Encounter_with_Advanced_Illness_Cached = new();

    [CqlExpressionDefinition("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context) =>
        _Inpatient_Encounter_with_Advanced_Illness_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Acute_Inpatient(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? c_(Encounter AcuteInpatient)
                {
                    Code<Encounter.EncounterStatus> g_ = AcuteInpatient?.StatusElement;
                    string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
                    bool? i_ = context.Operators.Equal(h_, "finished");
                    return i_;
                };
                IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
                IEnumerable<Encounter> e_(Encounter InpatientEncounter)
                {
                    CqlValueSet j_ = this.Advanced_Illness(context);
                    IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                    bool? l_(Condition AdvancedIllnessDiagnosis)
                    {
                        IEnumerable<Condition> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                        bool? q_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, p_);
                        Period r_ = InpatientEncounter?.Period;
                        CqlInterval<CqlDateTime> s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, r_ as object);
                        CqlDateTime t_ = context.Operators.Start(s_);
                        CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                        CqlDateTime v_ = context.Operators.End(u_);
                        CqlQuantity w_ = context.Operators.Quantity(2m, "years");
                        CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                        CqlDateTime z_ = context.Operators.End(u_);
                        CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(x_, z_, true, true);
                        bool? ab_ = context.Operators.In<CqlDateTime>(t_, aa_, default);
                        CqlDateTime ad_ = context.Operators.End(u_);
                        bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                        bool? af_ = context.Operators.And(ab_, ae_);
                        bool? ag_ = context.Operators.And(q_, af_);
                        return ag_;
                    };
                    IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
                    Encounter n_(Condition AdvancedIllnessDiagnosis) =>
                    InpatientEncounter;
                    IEnumerable<Encounter> o_ = context.Operators.Select<Condition, Encounter>(m_, n_);
                    return o_;
                };
                IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(d_, e_);
                return f_;
            });


    private Cached<bool?> _Has_Criteria_Indicating_Frailty_Cached = new();

    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context) =>
        _Has_Criteria_Indicating_Frailty_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Frailty_Device(context);
                IEnumerable<DeviceRequest> b_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
                IEnumerable<DeviceRequest> d_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
                IEnumerable<DeviceRequest> e_ = context.Operators.Union<DeviceRequest>(b_, d_);
                bool? f_(DeviceRequest FrailtyDeviceOrder)
                {
                    Code<RequestStatus> ag_ = FrailtyDeviceOrder?.StatusElement;
                    string ah_ = FHIRHelpers_4_0_001.Instance.ToString(context, ag_);
                    string[] ai_ = [
                        "active",
                        "on-hold",
                        "completed",
                    ];
                    bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                    Code<RequestIntent> ak_ = FrailtyDeviceOrder?.IntentElement;
                    string al_ = FHIRHelpers_4_0_001.Instance.ToString(context, ak_);
                    bool? am_ = context.Operators.Equal(al_, "order");
                    bool? an_ = context.Operators.And(aj_, am_);
                    CqlInterval<CqlDateTime> ao_ = this.Measurement_Period(context);
                    FhirDateTime ap_ = FrailtyDeviceOrder?.AuthoredOnElement;
                    CqlInterval<CqlDateTime> aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ap_ as object);
                    bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, default);
                    bool? as_ = context.Operators.And(an_, ar_);
                    return as_;
                };
                IEnumerable<DeviceRequest> g_ = context.Operators.Where<DeviceRequest>(e_, f_);
                bool? h_ = context.Operators.Exists<DeviceRequest>(g_);
                IEnumerable<Observation> j_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? k_(Observation FrailtyDeviceApplied)
                {
                    Code<ObservationStatus> at_ = FrailtyDeviceApplied?.StatusElement;
                    string au_ = FHIRHelpers_4_0_001.Instance.ToString(context, at_);
                    string[] av_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aw_ = context.Operators.In<string>(au_, (IEnumerable<string>)av_);
                    DataType ax_ = FrailtyDeviceApplied?.Effective;
                    CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ax_);
                    CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
                    bool? ba_ = context.Operators.Overlaps(ay_, az_, default);
                    bool? bb_ = context.Operators.And(aw_, ba_);
                    return bb_;
                };
                IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);
                bool? m_ = context.Operators.Exists<Observation>(l_);
                bool? n_ = context.Operators.Or(h_, m_);
                CqlValueSet o_ = this.Frailty_Diagnosis(context);
                IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                bool? q_(Condition FrailtyDiagnosis)
                {
                    CqlInterval<CqlDateTime> bc_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
                    CqlInterval<CqlDateTime> bd_ = this.Measurement_Period(context);
                    bool? be_ = context.Operators.Overlaps(bc_, bd_, default);
                    return be_;
                };
                IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
                bool? s_ = context.Operators.Exists<Condition>(r_);
                bool? t_ = context.Operators.Or(n_, s_);
                CqlValueSet u_ = this.Frailty_Encounter(context);
                IEnumerable<Encounter> v_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                bool? w_(Encounter FrailtyEncounter)
                {
                    Code<Encounter.EncounterStatus> bf_ = FrailtyEncounter?.StatusElement;
                    string bg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bf_);
                    bool? bh_ = context.Operators.Equal(bg_, "finished");
                    Period bi_ = FrailtyEncounter?.Period;
                    CqlInterval<CqlDateTime> bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bi_ as object);
                    CqlInterval<CqlDateTime> bk_ = this.Measurement_Period(context);
                    bool? bl_ = context.Operators.Overlaps(bj_, bk_, default);
                    bool? bm_ = context.Operators.And(bh_, bl_);
                    return bm_;
                };
                IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);
                bool? y_ = context.Operators.Exists<Encounter>(x_);
                bool? z_ = context.Operators.Or(t_, y_);
                CqlValueSet aa_ = this.Frailty_Symptom(context);
                IEnumerable<Observation> ab_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? ac_(Observation FrailtySymptom)
                {
                    Code<ObservationStatus> bn_ = FrailtySymptom?.StatusElement;
                    string bo_ = FHIRHelpers_4_0_001.Instance.ToString(context, bn_);
                    string[] bp_ = [
                        "preliminary",
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                    DataType br_ = FrailtySymptom?.Effective;
                    CqlInterval<CqlDateTime> bs_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, br_);
                    CqlInterval<CqlDateTime> bt_ = this.Measurement_Period(context);
                    bool? bu_ = context.Operators.Overlaps(bs_, bt_, default);
                    bool? bv_ = context.Operators.And(bq_, bu_);
                    return bv_;
                };
                IEnumerable<Observation> ad_ = context.Operators.Where<Observation>(ab_, ac_);
                bool? ae_ = context.Operators.Exists<Observation>(ad_);
                bool? af_ = context.Operators.Or(z_, ae_);
                return af_;
            });


    private Cached<bool?> _Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Cached = new();

    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context) =>
        _Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Cached.GetOrReplace(
            context,
            () =>
            {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(65, 79, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                bool? k_ = this.Has_Criteria_Indicating_Frailty(context);
                bool? l_ = context.Operators.And(j_, k_);
                IEnumerable<Encounter> m_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
                bool? n_ = context.Operators.Exists<Encounter>(m_);
                IEnumerable<Encounter> o_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
                bool? p_ = context.Operators.Exists<Encounter>(o_);
                bool? q_ = context.Operators.Or(n_, p_);
                IEnumerable<MedicationRequest> r_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
                bool? s_ = context.Operators.Exists<MedicationRequest>(r_);
                bool? t_ = context.Operators.Or(q_, s_);
                bool? u_ = context.Operators.And(l_, t_);
                Date w_ = a_?.BirthDateElement;
                string x_ = w_?.Value;
                CqlDate y_ = context.Operators.ConvertStringToDate(x_);
                CqlDateTime aa_ = context.Operators.Start(e_);
                CqlDate ab_ = context.Operators.DateFrom(aa_);
                int? ac_ = context.Operators.CalculateAgeAt(y_, ab_, "year");
                bool? ad_ = context.Operators.GreaterOrEqual(ac_, 80);
                bool? af_ = context.Operators.And(ad_, k_);
                bool? ag_ = context.Operators.Or(u_, af_);
                return ag_;
            });


    private Cached<bool?> _Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Cached = new();

    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context) =>
        _Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Cached.GetOrReplace(
            context,
            () =>
            {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
                bool? j_ = this.Has_Criteria_Indicating_Frailty(context);
                bool? k_ = context.Operators.And(i_, j_);
                IEnumerable<Encounter> l_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
                bool? m_ = context.Operators.Exists<Encounter>(l_);
                IEnumerable<Encounter> n_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
                bool? o_ = context.Operators.Exists<Encounter>(n_);
                bool? p_ = context.Operators.Or(m_, o_);
                IEnumerable<MedicationRequest> q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
                bool? r_ = context.Operators.Exists<MedicationRequest>(q_);
                bool? s_ = context.Operators.Or(p_, r_);
                bool? t_ = context.Operators.And(k_, s_);
                return t_;
            });


    private Cached<bool?> _Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Cached = new();

    [CqlExpressionDefinition("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context) =>
        _Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Cached.GetOrReplace(
            context,
            () =>
            {
                int? a_ = this.Max_Long_Term_Care_Period_Length(context);
                bool? b_ = context.Operators.Greater(a_, 90);
                return b_;
            });


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb = new(
      [typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>)],
      ["LTCPeriod1", "LTCPeriod2"]);

    private static CqlTupleMetadata CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA = new(
      [typeof(Encounter), typeof(Encounter)],
      ["OutpatientEncounter1", "OutpatientEncounter2"]);

    #endregion CqlTupleMetadata Properties

}
