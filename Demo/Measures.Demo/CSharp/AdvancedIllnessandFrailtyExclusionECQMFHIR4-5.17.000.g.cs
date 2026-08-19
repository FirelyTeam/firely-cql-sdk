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
[CqlLibrary("AdvancedIllnessandFrailtyExclusionECQMFHIR4", "5.17.000")]
public partial class AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 : ILibrary, ISingleton<AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000>
{
    #region ValueSets (13)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8608999970669603967L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        object? a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", (object?)null);
        return (CqlInterval<CqlDateTime?>?)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5859119640024438432L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest?>? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Dementia_Medications_In_Year_Before_or_During_Measurement_Period, Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Compute);

    private const long _cacheIndex_Dementia_Medications_In_Year_Before_or_During_Measurement_Period = -9005185825297618471L;

    private IEnumerable<MedicationRequest?>? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest?>? b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest?>? c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? d_(MedicationRequest? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? j_(Medication? M) {
                Id? l_ = M?.IdElement;
                string? m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                object? n_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference");
                string? o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_ as FhirString);
                IEnumerable<string?>? p_ = context.Operators.Split(o_!, "/");
                string? q_ = context.Operators.Last<string?>(p_!);
                bool? r_ = context.Operators.Equal(m_, q_);
                CodeableConcept? s_ = M?.Code;
                CqlConcept? t_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, s_);
                CqlValueSet? u_ = this.Dementia_Medications(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest?>? e_ = context.Operators.Where<MedicationRequest?>(c_, d_);
        IEnumerable<MedicationRequest?>? f_ = context.Operators.Union<MedicationRequest?>(b_, e_);

        bool? g_(MedicationRequest? DementiaMed) {
            Code<MedicationRequest.MedicationrequestStatus>? x_ = DementiaMed?.StatusElement;
            string? y_ = FHIRHelpers_4_0_001.Instance.ToString(context, x_);
            bool? z_ = context.Operators.Equal(y_, "active");
            Code<MedicationRequest.MedicationRequestIntent>? aa_ = DementiaMed?.IntentElement;
            string? ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
            bool? ac_ = context.Operators.Equal(ab_, "order");
            bool? ad_ = context.Operators.And(z_, ac_);
            CqlInterval<CqlDateTime?>? ae_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed);
            CqlInterval<CqlDateTime?>? af_ = this.Measurement_Period(context);
            CqlDateTime? ag_ = context.Operators.Start(af_);
            CqlQuantity? ah_ = context.Operators.Quantity(1m, "year");
            CqlDateTime? ai_ = context.Operators.Subtract(ag_, ah_);
            CqlDateTime? aj_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime?>? ak_ = context.Operators.Interval(ai_, aj_, true, true);
            bool? al_ = context.Operators.Overlaps(ae_!, ak_!, (string?)default);
            bool? am_ = context.Operators.And(ad_, al_);
            return am_;
        }

        IEnumerable<MedicationRequest?>? h_ = context.Operators.Where<MedicationRequest?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime?>?>? Long_Term_Care_Periods_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Long_Term_Care_Periods_During_Measurement_Period, Long_Term_Care_Periods_During_Measurement_Period_Compute);

    private const long _cacheIndex_Long_Term_Care_Periods_During_Measurement_Period = 6704162323021068453L;

    private IEnumerable<CqlInterval<CqlDateTime?>?>? Long_Term_Care_Periods_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet? c_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);

        bool? f_(Encounter? LongTermFacilityEncounter) {
            Code<Encounter.EncounterStatus>? j_ = LongTermFacilityEncounter?.StatusElement;
            string? k_ = FHIRHelpers_4_0_001.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "finished");
            Period? m_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime?>? n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, m_);
            CqlInterval<CqlDateTime?>? o_ = this.Measurement_Period(context);
            bool? p_ = context.Operators.Overlaps(n_!, o_!, (string?)default);
            bool? q_ = context.Operators.And(l_, p_);
            return q_;
        }


        CqlInterval<CqlDateTime?>? g_(Encounter? LongTermFacilityEncounter) {
            Period? r_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime?>? s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, r_);
            CqlInterval<CqlDateTime?>? t_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime?>? u_ = context.Operators.Intersect<CqlDateTime?>(s_, t_);
            return u_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? h_ = context.Operators.WhereSelect<Encounter?, CqlInterval<CqlDateTime?>?>(e_, f_, g_);
        IEnumerable<CqlInterval<CqlDateTime?>?>? i_ = context.Operators.Distinct<CqlInterval<CqlDateTime?>?>(((IEnumerable<CqlInterval<CqlDateTime>>)h_)!);
        return i_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter?>? Outpatient_Encounters_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounters_with_Advanced_Illness, Outpatient_Encounters_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Outpatient_Encounters_with_Advanced_Illness = -1203071861351544790L;

    private IEnumerable<Encounter?>? Outpatient_Encounters_with_Advanced_Illness_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Outpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet? c_ = this.Observation(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);
        CqlValueSet? f_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter?>? g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet? h_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter?>? i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter?>? j_ = context.Operators.Union<Encounter?>(g_, i_);
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter?>(e_, j_);

        bool? l_(Encounter? Outpatient) {
            Code<Encounter.EncounterStatus>? p_ = Outpatient?.StatusElement;
            string? q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
            bool? r_ = context.Operators.Equal(q_, "finished");
            return r_;
        }

        IEnumerable<Encounter?>? m_ = context.Operators.Where<Encounter?>(k_, l_);

        bool? n_(Encounter? OutpatientEncounter) {
            CqlValueSet? s_ = this.Advanced_Illness(context);
            IEnumerable<Condition?>? t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? u_(Condition? AdvancedIllnessDiagnosis) {
                IEnumerable<Condition?>? w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                bool? x_ = context.Operators.In<Condition?>(AdvancedIllnessDiagnosis, w_);
                Period? y_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, y_);
                CqlDateTime? aa_ = context.Operators.Start(z_);
                CqlInterval<CqlDateTime?>? ab_ = this.Measurement_Period(context);
                CqlDateTime? ac_ = context.Operators.End(ab_);
                CqlQuantity? ad_ = context.Operators.Quantity(2m, "years");
                CqlDateTime? ae_ = context.Operators.Subtract(ac_, ad_);
                CqlInterval<CqlDateTime?>? af_ = context.Operators.Interval(ae_, ac_, true, true);
                bool? ag_ = context.Operators.In<CqlDateTime?>(aa_, af_, (string?)default);
                bool? ah_ = context.Operators.Not((bool?)(ac_ is null));
                bool? ai_ = context.Operators.And(ag_, ah_);
                bool? aj_ = context.Operators.And(x_, ai_);
                return aj_;
            }

            bool? v_ = context.Operators.WhereAny<Condition?>(t_, u_);
            return v_;
        }

        IEnumerable<Encounter?>? o_ = context.Operators.Where<Encounter?>(m_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter?>? Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service, Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Compute);

    private const long _cacheIndex_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service = 5677122492849480325L;

    private IEnumerable<Encounter?>? Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter?, Encounter?>>? b_ = context.Operators.CrossJoin<Encounter?, Encounter?>(a_, a_);

        (CqlTupleMetadata, Encounter? OutpatientEncounter1, Encounter? OutpatientEncounter2)? c_(ValueTuple<Encounter?, Encounter?> _valueTuple) {
            (CqlTupleMetadata, Encounter? OutpatientEncounter1, Encounter? OutpatientEncounter2)? h_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);
            return h_;
        }


        bool? d_((CqlTupleMetadata, Encounter? OutpatientEncounter1, Encounter? OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) {
            Period? i_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime?>? j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, i_);
            CqlDateTime? k_ = context.Operators.End(j_);
            Period? l_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.End(m_);
            CqlQuantity? o_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? p_ = context.Operators.Add(n_, o_);
            bool? q_ = context.Operators.SameOrAfter(k_, p_, "day");
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? OutpatientEncounter1, Encounter? OutpatientEncounter2)?>? e_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Encounter?>, (CqlTupleMetadata, Encounter? OutpatientEncounter1, Encounter? OutpatientEncounter2)?>((IEnumerable<ValueTuple<Encounter, Encounter>>?)b_, c_, d_);
        Encounter? f_((CqlTupleMetadata, Encounter? OutpatientEncounter1, Encounter? OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) => tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter?>? g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? OutpatientEncounter1, Encounter? OutpatientEncounter2)?, Encounter?>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime?>?>? Long_Term_Care_Overlapping_Periods(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Long_Term_Care_Overlapping_Periods, Long_Term_Care_Overlapping_Periods_Compute);

    private const long _cacheIndex_Long_Term_Care_Overlapping_Periods = -25046034067202445L;

    private IEnumerable<CqlInterval<CqlDateTime?>?>? Long_Term_Care_Overlapping_Periods_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime?>?>? a_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
        IEnumerable<CqlInterval<CqlDateTime?>?>? b_ = context.Operators.Collapse(a_, (string?)default);
        return b_;
    }


    [CqlExpressionDefinition("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime?>?>? Long_Term_Care_Adjacent_Periods(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Long_Term_Care_Adjacent_Periods, Long_Term_Care_Adjacent_Periods_Compute);

    private const long _cacheIndex_Long_Term_Care_Adjacent_Periods = 4645789520322337496L;

    private IEnumerable<CqlInterval<CqlDateTime?>?>? Long_Term_Care_Adjacent_Periods_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime?>?>? a_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<ValueTuple<CqlInterval<CqlDateTime?>?, CqlInterval<CqlDateTime?>?>>? b_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime?>?, CqlInterval<CqlDateTime?>?>(a_, a_);

        (CqlTupleMetadata, CqlInterval<CqlDateTime?>? LTCPeriod1, CqlInterval<CqlDateTime?>? LTCPeriod2)? c_(ValueTuple<CqlInterval<CqlDateTime?>?, CqlInterval<CqlDateTime?>?> _valueTuple) {
            (CqlTupleMetadata, CqlInterval<CqlDateTime?>? LTCPeriod1, CqlInterval<CqlDateTime?>? LTCPeriod2)? h_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);
            return h_;
        }


        bool? d_((CqlTupleMetadata, CqlInterval<CqlDateTime?>? LTCPeriod1, CqlInterval<CqlDateTime?>? LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb) {
            CqlDateTime? i_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime? j_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlQuantity? k_ = context.Operators.Quantity(1m, "day");
            CqlDateTime? l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime? m_ = context.Operators.Add(j_, k_);
            CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(l_, m_, true, true);
            bool? o_ = context.Operators.In<CqlDateTime?>(i_, n_, (string?)default);
            bool? p_ = context.Operators.Not((bool?)(j_ is null));
            bool? q_ = context.Operators.And(o_, p_);
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? LTCPeriod1, CqlInterval<CqlDateTime?>? LTCPeriod2)?>? e_ = context.Operators.SelectWhere<ValueTuple<CqlInterval<CqlDateTime?>?, CqlInterval<CqlDateTime?>?>, (CqlTupleMetadata, CqlInterval<CqlDateTime?>? LTCPeriod1, CqlInterval<CqlDateTime?>? LTCPeriod2)?>((IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>>?)b_, c_, d_);

        CqlInterval<CqlDateTime?>? f_((CqlTupleMetadata, CqlInterval<CqlDateTime?>? LTCPeriod1, CqlInterval<CqlDateTime?>? LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb) {
            CqlDateTime? r_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime? s_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlInterval<CqlDateTime?>? t_ = context.Operators.Interval(r_, s_, true, true);
            return t_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? LTCPeriod1, CqlInterval<CqlDateTime?>? LTCPeriod2)?, CqlInterval<CqlDateTime?>?>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Max_Long_Term_Care_Period_Length, Max_Long_Term_Care_Period_Length_Compute);

    private const long _cacheIndex_Max_Long_Term_Care_Period_Length = -4265280958747828452L;

    private int? Max_Long_Term_Care_Period_Length_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime?>?>? a_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime?>?>? b_ = this.Long_Term_Care_Adjacent_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.Union<CqlInterval<CqlDateTime?>?>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime?>?>? d_ = context.Operators.Collapse(c_, (string?)default);

        int? e_(CqlInterval<CqlDateTime?>? LTCPeriods) {
            CqlDateTime? h_ = context.Operators.Start(LTCPeriods);
            CqlDateTime? i_ = context.Operators.End(LTCPeriods);
            int? j_ = context.Operators.DurationBetween(h_, i_, "day");
            return j_;
        }

        IEnumerable<int?>? f_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime?>?, int?>(d_, e_);
        int? g_ = context.Operators.Max<int?>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter?>? Inpatient_Encounter_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_with_Advanced_Illness, Inpatient_Encounter_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Inpatient_Encounter_with_Advanced_Illness = -6583149385975442652L;

    private IEnumerable<Encounter?>? Inpatient_Encounter_with_Advanced_Illness_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter? AcuteInpatient) {
            Code<Encounter.EncounterStatus>? g_ = AcuteInpatient?.StatusElement;
            string? h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            bool? i_ = context.Operators.Equal(h_, "finished");
            return i_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter?>(b_, c_);

        bool? e_(Encounter? InpatientEncounter) {
            CqlValueSet? j_ = this.Advanced_Illness(context);
            IEnumerable<Condition?>? k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? l_(Condition? AdvancedIllnessDiagnosis) {
                IEnumerable<Condition?>? n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                bool? o_ = context.Operators.In<Condition?>(AdvancedIllnessDiagnosis, n_);
                Period? p_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime?>? q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, p_);
                CqlDateTime? r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime?>? s_ = this.Measurement_Period(context);
                CqlDateTime? t_ = context.Operators.End(s_);
                CqlQuantity? u_ = context.Operators.Quantity(2m, "years");
                CqlDateTime? v_ = context.Operators.Subtract(t_, u_);
                CqlInterval<CqlDateTime?>? w_ = context.Operators.Interval(v_, t_, true, true);
                bool? x_ = context.Operators.In<CqlDateTime?>(r_, w_, (string?)default);
                bool? y_ = context.Operators.Not((bool?)(t_ is null));
                bool? z_ = context.Operators.And(x_, y_);
                bool? aa_ = context.Operators.And(o_, z_);
                return aa_;
            }

            bool? m_ = context.Operators.WhereAny<Condition?>(k_, l_);
            return m_;
        }

        IEnumerable<Encounter?>? f_ = context.Operators.Where<Encounter?>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Criteria_Indicating_Frailty, Has_Criteria_Indicating_Frailty_Compute);

    private const long _cacheIndex_Has_Criteria_Indicating_Frailty = 8009958552057876719L;

    private bool? Has_Criteria_Indicating_Frailty_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest?>? b_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest?>? c_ = context.Operators.Union<DeviceRequest?>(b_, b_);

        bool? d_(DeviceRequest? FrailtyDeviceOrder) {
            Code<RequestStatus>? y_ = FrailtyDeviceOrder?.StatusElement;
            string? z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
            string?[]? aa_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? ab_ = context.Operators.In<string?>(z_, (IEnumerable<string?>?)aa_);
            Code<RequestIntent>? ac_ = FrailtyDeviceOrder?.IntentElement;
            string? ad_ = FHIRHelpers_4_0_001.Instance.ToString(context, ac_);
            bool? ae_ = context.Operators.Equal(ad_, "order");
            bool? af_ = context.Operators.And(ab_, ae_);
            CqlInterval<CqlDateTime?>? ag_ = this.Measurement_Period(context);
            FhirDateTime? ah_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime?>? ai_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ah_);
            bool? aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(ag_, ai_, (string?)default);
            bool? ak_ = context.Operators.And(af_, aj_);
            return ak_;
        }

        bool? e_ = context.Operators.WhereAny<DeviceRequest?>(c_, d_);
        IEnumerable<Observation?>? f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? g_(Observation? FrailtyDeviceApplied) {
            Code<ObservationStatus>? al_ = FrailtyDeviceApplied?.StatusElement;
            string? am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
            string?[]? an_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ao_ = context.Operators.In<string?>(am_, (IEnumerable<string?>?)an_);
            DataType? ap_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime?>? aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ap_);
            CqlInterval<CqlDateTime?>? ar_ = this.Measurement_Period(context);
            bool? as_ = context.Operators.Overlaps(aq_!, ar_!, (string?)default);
            bool? at_ = context.Operators.And(ao_, as_);
            return at_;
        }

        bool? h_ = context.Operators.WhereAny<Observation?>(f_, g_);
        bool? i_ = context.Operators.Or(e_, h_);
        CqlValueSet? j_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition?>? k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? l_(Condition? FrailtyDiagnosis) {
            CqlInterval<CqlDateTime?>? au_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime?>? av_ = this.Measurement_Period(context);
            bool? aw_ = context.Operators.Overlaps(au_!, av_!, (string?)default);
            return aw_;
        }

        bool? m_ = context.Operators.WhereAny<Condition?>(k_, l_);
        bool? n_ = context.Operators.Or(i_, m_);
        CqlValueSet? o_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter?>? p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? q_(Encounter? FrailtyEncounter) {
            Code<Encounter.EncounterStatus>? ax_ = FrailtyEncounter?.StatusElement;
            string? ay_ = FHIRHelpers_4_0_001.Instance.ToString(context, ax_);
            bool? az_ = context.Operators.Equal(ay_, "finished");
            Period? ba_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime?>? bb_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ba_);
            CqlInterval<CqlDateTime?>? bc_ = this.Measurement_Period(context);
            bool? bd_ = context.Operators.Overlaps(bb_!, bc_!, (string?)default);
            bool? be_ = context.Operators.And(az_, bd_);
            return be_;
        }

        bool? r_ = context.Operators.WhereAny<Encounter?>(p_, q_);
        bool? s_ = context.Operators.Or(n_, r_);
        CqlValueSet? t_ = this.Frailty_Symptom(context);
        IEnumerable<Observation?>? u_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? v_(Observation? FrailtySymptom) {
            Code<ObservationStatus>? bf_ = FrailtySymptom?.StatusElement;
            string? bg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bf_);
            string?[]? bh_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? bi_ = context.Operators.In<string?>(bg_, (IEnumerable<string?>?)bh_);
            DataType? bj_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime?>? bk_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bj_);
            CqlInterval<CqlDateTime?>? bl_ = this.Measurement_Period(context);
            bool? bm_ = context.Operators.Overlaps(bk_!, bl_!, (string?)default);
            bool? bn_ = context.Operators.And(bi_, bm_);
            return bn_;
        }

        bool? w_ = context.Operators.WhereAny<Observation?>(u_, v_);
        bool? x_ = context.Operators.Or(s_, w_);
        return x_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80, Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Compute);

    private const long _cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80 = -1176185432942245714L;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?>? i_ = context.Operators.Interval(65, 79, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string?)default);
        bool? k_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? l_ = context.Operators.And(j_, k_);
        IEnumerable<Encounter?>? m_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? n_ = context.Operators.Exists<Encounter?>(m_!);
        IEnumerable<Encounter?>? o_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? p_ = context.Operators.Exists<Encounter?>(o_!);
        bool? q_ = context.Operators.Or(n_, p_);
        IEnumerable<MedicationRequest?>? r_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? s_ = context.Operators.Exists<MedicationRequest?>(r_!);
        bool? t_ = context.Operators.Or(q_, s_);
        bool? u_ = context.Operators.And(l_, t_);
        bool? v_ = context.Operators.GreaterOrEqual(h_, 80);
        bool? w_ = context.Operators.And(v_, k_);
        bool? x_ = context.Operators.Or(u_, w_);
        return x_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80, Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Compute);

    private const long _cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80 = -8909740527187213041L;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Date? b_ = a_?.BirthDateElement;
        string? c_ = b_?.Value;
        CqlDate? d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
        CqlDateTime? f_ = context.Operators.Start(e_);
        CqlDate? g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 65);
        bool? j_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? k_ = context.Operators.And(i_, j_);
        IEnumerable<Encounter?>? l_ = this.Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(context);
        bool? m_ = context.Operators.Exists<Encounter?>(l_!);
        IEnumerable<Encounter?>? n_ = this.Inpatient_Encounter_with_Advanced_Illness(context);
        bool? o_ = context.Operators.Exists<Encounter?>(n_!);
        bool? p_ = context.Operators.Or(m_, o_);
        IEnumerable<MedicationRequest?>? q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
        bool? r_ = context.Operators.Exists<MedicationRequest?>(q_!);
        bool? s_ = context.Operators.Or(p_, r_);
        bool? t_ = context.Operators.And(k_, s_);
        return t_;
    }


    [CqlExpressionDefinition("Has Long Term Care Periods Longer Than 90 Consecutive Days")]
    public bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days, Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Compute);

    private const long _cacheIndex_Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days = 4455315533900385902L;

    private bool? Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days_Compute(CqlContext context)
    {
        int? a_ = this.Max_Long_Term_Care_Period_Length(context);
        bool? b_ = context.Operators.Greater(a_, 90);
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000() {}

    public static AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "AdvancedIllnessandFrailtyExclusionECQMFHIR4";
    public string Version => "5.17.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb = new(
       [typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>)],
       ["LTCPeriod1", "LTCPeriod2"]);

    private static CqlTupleMetadata CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA = new(
       [typeof(Encounter), typeof(Encounter)],
       ["OutpatientEncounter1", "OutpatientEncounter2"]);

    #endregion CqlTupleMetadata Properties

}
