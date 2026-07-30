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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8608999970669603967L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("AdvancedIllnessandFrailtyExclusionECQMFHIR4-5.17.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5859119640024438432L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Dementia_Medications_In_Year_Before_or_During_Measurement_Period, Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Compute);

    private const long _cacheIndex_Dementia_Medications_In_Year_Before_or_During_Measurement_Period = -9005185825297618471L;

    private IEnumerable<MedicationRequest> Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? j_(Medication M) {
                Id m_ = M?.IdElement;
                string n_ = FHIRHelpers_4_0_001.Instance.ToString(context, m_);
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string p_ = FHIRHelpers_4_0_001.Instance.ToString(context, o_ as FhirString);
                IEnumerable<string> q_ = context.Operators.Split(p_, "/");
                string r_ = context.Operators.Last<string>(q_);
                bool? s_ = context.Operators.Equal(n_, r_);
                CodeableConcept t_ = M?.Code;
                CqlConcept u_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, t_);
                CqlValueSet v_ = this.Dementia_Medications(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest DementiaMed) {
            Code<MedicationRequest.MedicationrequestStatus> y_ = DementiaMed?.StatusElement;
            string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
            bool? aa_ = context.Operators.Equal(z_, "active");
            Code<MedicationRequest.MedicationRequestIntent> ab_ = DementiaMed?.IntentElement;
            string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
            bool? ad_ = context.Operators.Equal(ac_, "order");
            bool? ae_ = context.Operators.And(aa_, ad_);
            CqlInterval<CqlDateTime> af_ = CumulativeMedicationDurationFHIR4_1_0_000.Instance.MedicationPeriod(context, DementiaMed);
            CqlInterval<CqlDateTime> ag_ = this.Measurement_Period(context);
            CqlDateTime ah_ = context.Operators.Start(ag_);
            CqlQuantity ai_ = context.Operators.Quantity(1m, "year");
            CqlDateTime aj_ = context.Operators.Subtract(ah_, ai_);
            CqlDateTime ak_ = context.Operators.End(ag_);
            CqlInterval<CqlDateTime> al_ = context.Operators.Interval(aj_, ak_, true, true);
            bool? am_ = context.Operators.Overlaps(af_, al_, (string)default);
            bool? an_ = context.Operators.And(ae_, am_);
            return an_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Long Term Care Periods During Measurement Period")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Long_Term_Care_Periods_During_Measurement_Period, Long_Term_Care_Periods_During_Measurement_Period_Compute);

    private const long _cacheIndex_Long_Term_Care_Periods_During_Measurement_Period = 6704162323021068453L;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Periods_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);

        bool? f_(Encounter LongTermFacilityEncounter) {
            Code<Encounter.EncounterStatus> k_ = LongTermFacilityEncounter?.StatusElement;
            string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
            bool? m_ = context.Operators.Equal(l_, "finished");
            Period n_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, n_);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.Overlaps(o_, p_, (string)default);
            bool? r_ = context.Operators.And(m_, q_);
            return r_;
        }

        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);

        CqlInterval<CqlDateTime> h_(Encounter LongTermFacilityEncounter) {
            Period s_ = LongTermFacilityEncounter?.Period;
            CqlInterval<CqlDateTime> t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, s_);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> v_ = context.Operators.Intersect<CqlDateTime>(t_, u_);
            return v_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(g_, h_);
        IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounters_with_Advanced_Illness, Outpatient_Encounters_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Outpatient_Encounters_with_Advanced_Illness = -1203071861351544790L;

    private IEnumerable<Encounter> Outpatient_Encounters_with_Advanced_Illness_Compute(CqlContext context)
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

        bool? l_(Encounter Outpatient) {
            Code<Encounter.EncounterStatus> p_ = Outpatient?.StatusElement;
            string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
            bool? r_ = context.Operators.Equal(q_, "finished");
            return r_;
        }

        IEnumerable<Encounter> m_ = context.Operators.Where<Encounter>(k_, l_);

        bool? n_(Encounter OutpatientEncounter) {
            CqlValueSet s_ = this.Advanced_Illness(context);
            IEnumerable<Condition> t_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? u_(Condition AdvancedIllnessDiagnosis) {
                IEnumerable<Condition> x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, OutpatientEncounter);
                bool? y_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, x_);
                Period z_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlQuantity ae_ = context.Operators.Quantity(2m, "years");
                CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
                CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(af_, ad_, true, true);
                bool? ah_ = context.Operators.In<CqlDateTime>(ab_, ag_, (string)default);
                bool? ai_ = context.Operators.Not((bool?)(ad_ is null));
                bool? aj_ = context.Operators.And(ah_, ai_);
                bool? ak_ = context.Operators.And(y_, aj_);
                return ak_;
            }

            IEnumerable<Condition> v_ = context.Operators.Where<Condition>(t_, u_);
            bool? w_ = context.Operators.Exists<Condition>(v_);
            return w_;
        }

        IEnumerable<Encounter> o_ = context.Operators.Where<Encounter>(m_, n_);
        return o_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters with Advanced Illness on Different Dates of Service")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service, Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Compute);

    private const long _cacheIndex_Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service = 5677122492849480325L;

    private IEnumerable<Encounter> Two_Outpatient_Encounters_with_Advanced_Illness_on_Different_Dates_of_Service_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> b_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);

        (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? c_(ValueTuple<Encounter, Encounter> _valueTuple) {
            (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? j_ = (CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> d_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(b_, c_);

        bool? e_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) {
            Period k_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter2?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            Period n_ = tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlQuantity q_ = context.Operators.Quantity(1m, "day");
            CqlDateTime r_ = context.Operators.Add(p_, q_);
            bool? s_ = context.Operators.SameOrAfter(m_, r_, "day");
            return s_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?> f_ = context.Operators.Where<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?>(d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)? tuple_ealaedgldgrryalbkiicbtoia) => tuple_ealaedgldgrryalbkiicbtoia?.OutpatientEncounter1;
        IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, Encounter OutpatientEncounter1, Encounter OutpatientEncounter2)?, Encounter>(f_, g_);
        IEnumerable<Encounter> i_ = context.Operators.Distinct<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Long Term Care Overlapping Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Long_Term_Care_Overlapping_Periods, Long_Term_Care_Overlapping_Periods_Compute);

    private const long _cacheIndex_Long_Term_Care_Overlapping_Periods = -25046034067202445L;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Overlapping_Periods_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Periods_During_Measurement_Period(context);
        IEnumerable<CqlInterval<CqlDateTime>> b_ = context.Operators.Collapse(a_, (string)default);
        return b_;
    }


    [CqlExpressionDefinition("Long Term Care Adjacent Periods")]
    public IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Long_Term_Care_Adjacent_Periods, Long_Term_Care_Adjacent_Periods_Compute);

    private const long _cacheIndex_Long_Term_Care_Adjacent_Periods = 4645789520322337496L;

    private IEnumerable<CqlInterval<CqlDateTime>> Long_Term_Care_Adjacent_Periods_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>> b_ = context.Operators.CrossJoin<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, a_);

        (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? c_(ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>> _valueTuple) {
            (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? j_ = (CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> d_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>, (CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(b_, c_);

        bool? e_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb) {
            CqlDateTime k_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime l_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlQuantity m_ = context.Operators.Quantity(1m, "day");
            CqlDateTime n_ = context.Operators.Subtract(l_, m_);
            CqlDateTime o_ = context.Operators.Add(l_, m_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, o_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
            bool? r_ = context.Operators.Not((bool?)(l_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            return s_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?> f_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?>(d_, e_);

        CqlInterval<CqlDateTime> g_((CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)? tuple_cgadvoxeqbmgmpcpzothiiddb) {
            CqlDateTime t_ = context.Operators.Start(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod1);
            CqlDateTime u_ = context.Operators.End(tuple_cgadvoxeqbmgmpcpzothiiddb?.LTCPeriod2);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(t_, u_, true, true);
            return v_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> LTCPeriod1, CqlInterval<CqlDateTime> LTCPeriod2)?, CqlInterval<CqlDateTime>>(f_, g_);
        IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Max Long Term Care Period Length")]
    public int? Max_Long_Term_Care_Period_Length(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Max_Long_Term_Care_Period_Length, Max_Long_Term_Care_Period_Length_Compute);

    private const long _cacheIndex_Max_Long_Term_Care_Period_Length = -4265280958747828452L;

    private int? Max_Long_Term_Care_Period_Length_Compute(CqlContext context)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Long_Term_Care_Overlapping_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> b_ = this.Long_Term_Care_Adjacent_Periods(context);
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Union<CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Collapse(c_, (string)default);

        int? e_(CqlInterval<CqlDateTime> LTCPeriods) {
            CqlDateTime i_ = context.Operators.Start(LTCPeriods);
            CqlDateTime j_ = context.Operators.End(LTCPeriods);
            int? k_ = context.Operators.DurationBetween(i_, j_, "day");
            return k_;
        }

        IEnumerable<int?> f_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(d_, e_);
        IEnumerable<int?> g_ = context.Operators.Distinct<int?>(f_);
        int? h_ = context.Operators.Max<int?>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Inpatient Encounter with Advanced Illness")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_with_Advanced_Illness, Inpatient_Encounter_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Inpatient_Encounter_with_Advanced_Illness = -6583149385975442652L;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Advanced_Illness_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter AcuteInpatient) {
            Code<Encounter.EncounterStatus> g_ = AcuteInpatient?.StatusElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            bool? i_ = context.Operators.Equal(h_, "finished");
            return i_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        bool? e_(Encounter InpatientEncounter) {
            CqlValueSet j_ = this.Advanced_Illness(context);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

            bool? l_(Condition AdvancedIllnessDiagnosis) {
                IEnumerable<Condition> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
                bool? p_ = context.Operators.In<Condition>(AdvancedIllnessDiagnosis, o_);
                Period q_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlQuantity v_ = context.Operators.Quantity(2m, "years");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, u_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, (string)default);
                bool? z_ = context.Operators.Not((bool?)(u_ is null));
                bool? aa_ = context.Operators.And(y_, z_);
                bool? ab_ = context.Operators.And(p_, aa_);
                return ab_;
            }

            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            return n_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Criteria_Indicating_Frailty, Has_Criteria_Indicating_Frailty_Compute);

    private const long _cacheIndex_Has_Criteria_Indicating_Frailty = 8009958552057876719L;

    private bool? Has_Criteria_Indicating_Frailty_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> b_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DeviceRequest"));
        IEnumerable<DeviceRequest> c_ = context.Operators.Union<DeviceRequest>(b_, b_);

        bool? d_(DeviceRequest FrailtyDeviceOrder) {
            Code<RequestStatus> ad_ = FrailtyDeviceOrder?.StatusElement;
            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
            string[] af_ = [
                "active",
                "on-hold",
                "completed",
            ];
            bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
            Code<RequestIntent> ah_ = FrailtyDeviceOrder?.IntentElement;
            string ai_ = FHIRHelpers_4_0_001.Instance.ToString(context, ah_);
            bool? aj_ = context.Operators.Equal(ai_, "order");
            bool? ak_ = context.Operators.And(ag_, aj_);
            CqlInterval<CqlDateTime> al_ = this.Measurement_Period(context);
            FhirDateTime am_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, am_);
            bool? ao_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(al_, an_, (string)default);
            bool? ap_ = context.Operators.And(ak_, ao_);
            return ap_;
        }

        IEnumerable<DeviceRequest> e_ = context.Operators.Where<DeviceRequest>(c_, d_);
        bool? f_ = context.Operators.Exists<DeviceRequest>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? h_(Observation FrailtyDeviceApplied) {
            Code<ObservationStatus> aq_ = FrailtyDeviceApplied?.StatusElement;
            string ar_ = FHIRHelpers_4_0_001.Instance.ToString(context, aq_);
            string[] as_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? at_ = context.Operators.In<string>(ar_, (IEnumerable<string>)as_);
            DataType au_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> av_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, au_);
            CqlInterval<CqlDateTime> aw_ = this.Measurement_Period(context);
            bool? ax_ = context.Operators.Overlaps(av_, aw_, (string)default);
            bool? ay_ = context.Operators.And(at_, ax_);
            return ay_;
        }

        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
        bool? j_ = context.Operators.Exists<Observation>(i_);
        bool? k_ = context.Operators.Or(f_, j_);
        CqlValueSet l_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? n_(Condition FrailtyDiagnosis) {
            CqlInterval<CqlDateTime> az_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> ba_ = this.Measurement_Period(context);
            bool? bb_ = context.Operators.Overlaps(az_, ba_, (string)default);
            return bb_;
        }

        IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
        bool? p_ = context.Operators.Exists<Condition>(o_);
        bool? q_ = context.Operators.Or(k_, p_);
        CqlValueSet r_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? t_(Encounter FrailtyEncounter) {
            Code<Encounter.EncounterStatus> bc_ = FrailtyEncounter?.StatusElement;
            string bd_ = FHIRHelpers_4_0_001.Instance.ToString(context, bc_);
            bool? be_ = context.Operators.Equal(bd_, "finished");
            Period bf_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> bg_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bf_);
            CqlInterval<CqlDateTime> bh_ = this.Measurement_Period(context);
            bool? bi_ = context.Operators.Overlaps(bg_, bh_, (string)default);
            bool? bj_ = context.Operators.And(be_, bi_);
            return bj_;
        }

        IEnumerable<Encounter> u_ = context.Operators.Where<Encounter>(s_, t_);
        bool? v_ = context.Operators.Exists<Encounter>(u_);
        bool? w_ = context.Operators.Or(q_, v_);
        CqlValueSet x_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> y_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? z_(Observation FrailtySymptom) {
            Code<ObservationStatus> bk_ = FrailtySymptom?.StatusElement;
            string bl_ = FHIRHelpers_4_0_001.Instance.ToString(context, bk_);
            string[] bm_ = [
                "preliminary",
                "final",
                "amended",
                "corrected",
            ];
            bool? bn_ = context.Operators.In<string>(bl_, (IEnumerable<string>)bm_);
            DataType bo_ = FrailtySymptom?.Effective;
            CqlInterval<CqlDateTime> bp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bo_);
            CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
            bool? br_ = context.Operators.Overlaps(bp_, bq_, (string)default);
            bool? bs_ = context.Operators.And(bn_, br_);
            return bs_;
        }

        IEnumerable<Observation> aa_ = context.Operators.Where<Observation>(y_, z_);
        bool? ab_ = context.Operators.Exists<Observation>(aa_);
        bool? ac_ = context.Operators.Or(w_, ab_);
        return ac_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80, Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Compute);

    private const long _cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80 = -1176185432942245714L;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Compute(CqlContext context)
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
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
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
