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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.2.0")]
[CqlLibrary("NCQAAdvancedIllnessandFrailty", "1.0.0")]
public partial class NCQAAdvancedIllnessandFrailty_1_0_0 : ILibrary, ISingleton<NCQAAdvancedIllnessandFrailty_1_0_0>
{
    #region ValueSets (13)

    [CqlValueSetDefinition("Acute Inpatient", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", valueSetVersion: null)]
    public CqlValueSet Acute_Inpatient(CqlContext _) => _Acute_Inpatient;
    private static readonly CqlValueSet _Acute_Inpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1810", null);

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1465", null);

    [CqlValueSetDefinition("Dementia Medications", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext _) => _Dementia_Medications;
    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1729", null);

    [CqlValueSetDefinition("ED", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", valueSetVersion: null)]
    public CqlValueSet ED(CqlContext _) => _ED;
    private static readonly CqlValueSet _ED = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1086", null);

    [CqlValueSetDefinition("Frailty Device", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext _) => _Frailty_Device;
    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1530", null);

    [CqlValueSetDefinition("Frailty Diagnosis", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext _) => _Frailty_Diagnosis;
    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1531", null);

    [CqlValueSetDefinition("Frailty Encounter", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext _) => _Frailty_Encounter;
    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1532", null);

    [CqlValueSetDefinition("Frailty Symptom", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext _) => _Frailty_Symptom;
    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1533", null);

    [CqlValueSetDefinition("Nonacute Inpatient", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient(CqlContext _) => _Nonacute_Inpatient;
    private static readonly CqlValueSet _Nonacute_Inpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1189", null);

    [CqlValueSetDefinition("Observation", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", valueSetVersion: null)]
    public CqlValueSet Observation(CqlContext _) => _Observation;
    private static readonly CqlValueSet _Observation = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1191", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1446", null);

    [CqlValueSetDefinition("Outpatient", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", valueSetVersion: null)]
    public CqlValueSet Outpatient(CqlContext _) => _Outpatient;
    private static readonly CqlValueSet _Outpatient = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1202", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1246", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8915744558003842889L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (11)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -910321882205837424L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Criteria_Indicating_Frailty, Has_Criteria_Indicating_Frailty_Compute);

    private const long _cacheIndex_Has_Criteria_Indicating_Frailty = 3620167446593460806L;

    private bool? Has_Criteria_Indicating_Frailty_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Frailty_Device(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation FrailtyDeviceApplied) {
            DataType h_ = FrailtyDeviceApplied?.Effective;
            CqlInterval<CqlDateTime> i_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.Overlaps(i_, j_, (string)default);
            return k_;
        }

        bool? d_ = context.Operators.WhereAny<Observation>(b_, c_);

        CqlBoolean e_() {
            CqlValueSet l_ = this.Frailty_Diagnosis(context);
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            IEnumerable<Condition> n_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, m_);

            bool? o_(Condition FrailtyDiagnosis) {
                CqlInterval<CqlDateTime> q_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
                CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
                bool? s_ = context.Operators.Overlaps(q_, r_, (string)default);
                return s_;
            }

            bool? p_ = context.Operators.WhereAny<Condition>(n_, o_);
            return p_;
        }


        CqlBoolean f_() {
            CqlValueSet t_ = this.Frailty_Encounter(context);
            IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
            IEnumerable<Encounter> v_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, u_);

            bool? w_(Encounter FrailtyEncounter) {
                Period y_ = FrailtyEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, y_);
                CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                bool? ab_ = context.Operators.Overlaps(z_, aa_, (string)default);
                return ab_;
            }

            bool? x_ = context.Operators.WhereAny<Encounter>(v_, w_);
            return x_;
        }


        CqlBoolean g_() {
            CqlValueSet ac_ = this.Frailty_Symptom(context);
            IEnumerable<Observation> ad_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ac_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

            bool? ae_(Observation FrailtySymptom) {
                DataType ag_ = FrailtySymptom?.Effective;
                CqlInterval<CqlDateTime> ah_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ag_);
                CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
                bool? aj_ = context.Operators.Overlaps(ah_, ai_, (string)default);
                return aj_;
            }

            bool? af_ = context.Operators.WhereAny<Observation>(ad_, ae_);
            return af_;
        }

        return /* CQL 'or' (58:3-69:5) */ (/* CQL 'or' (58:3-66:5) */ (/* CQL 'or' (58:3-63:5) */ ((CqlBoolean)d_
            || e_())
            || f_())
            || g_());
    }


    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounters_with_Advanced_Illness, Outpatient_Encounters_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Outpatient_Encounters_with_Advanced_Illness = -2766277875631390399L;

    private IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Outpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Observation(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.ED(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet h_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Online_Assessments(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet n_ = this.Nonacute_Inpatient(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        IEnumerable<Encounter> r_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, q_);

        bool? s_(Encounter OutpatientEncounter) {
            CqlValueSet w_ = this.Advanced_Illness(context);
            IEnumerable<Condition> x_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? y_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, x_);

            CqlBoolean z_() {
                Period aa_ = OutpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ab_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlDate ad_ = context.Operators.DateFrom(ac_);
                CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                CqlDateTime af_ = context.Operators.Start(ae_);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlQuantity ah_ = context.Operators.Quantity(1m, "year");
                CqlDate ai_ = context.Operators.Subtract(ag_, ah_);
                CqlDateTime aj_ = context.Operators.End(ae_);
                CqlDate ak_ = context.Operators.DateFrom(aj_);
                CqlInterval<CqlDate> al_ = context.Operators.Interval(ai_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDate>(ad_, al_, (string)default);
                return am_;
            }

            return /* CQL 'and' (96:5-98:34) */ ((CqlBoolean)y_
                && z_());
        }


        CqlDate t_(Encounter EncounterWithDiagnosis) {
            Period an_ = EncounterWithDiagnosis?.Period;
            CqlInterval<CqlDateTime> ao_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, an_);
            CqlDateTime ap_ = context.Operators.End(ao_);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            return aq_;
        }

        IEnumerable<CqlDate> u_ = context.Operators.WhereSelect<Encounter, CqlDate>(r_, s_, t_);
        IEnumerable<CqlDate> v_ = context.Operators.Distinct<CqlDate>(u_);
        return v_;
    }


    [CqlExpressionDefinition("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Nonacute_Inpatient_Discharge_with_Advanced_Illness, Nonacute_Inpatient_Discharge_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Nonacute_Inpatient_Discharge_with_Advanced_Illness = -1708232231082040117L;

    private IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness_Compute(CqlContext context)
    {
        IEnumerable<Claim> a_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
        IEnumerable<Claim> c_ = b_?.NonacuteInpatientDischarge;
        CqlValueSet d_ = this.Advanced_Illness(context);
        IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, c_, e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;

        bool? h_(CqlInterval<CqlDateTime> DischargeWithDiagnosis) {
            CqlDateTime l_ = context.Operators.End(DischargeWithDiagnosis);
            CqlDate m_ = context.Operators.DateFrom(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlQuantity q_ = context.Operators.Quantity(1m, "year");
            CqlDate r_ = context.Operators.Subtract(p_, q_);
            CqlDateTime s_ = context.Operators.End(n_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            CqlInterval<CqlDate> u_ = context.Operators.Interval(r_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDate>(m_, u_, (string)default);
            return v_;
        }


        CqlDate i_(CqlInterval<CqlDateTime> InpatientDischarge) {
            CqlDateTime w_ = context.Operators.End(InpatientDischarge);
            CqlDate x_ = context.Operators.DateFrom(w_);
            return x_;
        }

        IEnumerable<CqlDate> j_ = context.Operators.WhereSelect<CqlInterval<CqlDateTime>, CqlDate>(g_, h_, i_);
        IEnumerable<CqlDate> k_ = context.Operators.Distinct<CqlDate>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounters_or_Discharges_with_Advanced_Illness, Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Outpatient_Encounters_or_Discharges_with_Advanced_Illness = -7890521861787029028L;

    private IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
        IEnumerable<CqlDate> b_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
        IEnumerable<CqlDate> c_ = context.Operators.Union<CqlDate>(a_, b_);
        if ((!((bool?)(c_ is null))) ?? false)
        {
            return c_;
        }
        else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
        {
            return b_;
        }
        else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
        {
            return a_;
        }
        else
        {
            return null as IEnumerable<CqlDate>;
        }
    }


    [CqlExpressionDefinition("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service, Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Compute);

    private const long _cacheIndex_Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service = -2682727164653422667L;

    private bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Compute(CqlContext context)
    {
        IEnumerable<CqlDate> a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
        IEnumerable<ValueTuple<CqlDate, CqlDate>> b_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);

        (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? c_(ValueTuple<CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? i_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? d_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) {
            CqlQuantity j_ = context.Operators.Quantity(1m, "day");
            CqlDate k_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, j_);
            bool? l_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, k_, (string)default);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> e_ = context.Operators.SelectWhere<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(b_, c_, d_);
        CqlDate f_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) => tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
        IEnumerable<CqlDate> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(e_, f_);
        bool? h_ = context.Operators.Exists<CqlDate>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Acute_Inpatient_Encounter_with_Advanced_Illness, Acute_Inpatient_Encounter_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Acute_Inpatient_Encounter_with_Advanced_Illness = 7466754000505614877L;

    private bool? Acute_Inpatient_Encounter_with_Advanced_Illness_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Acute_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> c_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, b_);

        bool? d_(Encounter InpatientEncounter) {
            CqlValueSet f_ = this.Advanced_Illness(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
            bool? h_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, g_);

            CqlBoolean i_() {
                Period j_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlDate m_ = context.Operators.DateFrom(l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDate p_ = context.Operators.DateFrom(o_);
                CqlQuantity q_ = context.Operators.Quantity(1m, "year");
                CqlDate r_ = context.Operators.Subtract(p_, q_);
                CqlDateTime s_ = context.Operators.End(n_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(r_, t_, true, true);
                bool? v_ = context.Operators.In<CqlDate>(m_, u_, (string)default);
                return v_;
            }

            return /* CQL 'and' (116:7-118:36) */ ((CqlBoolean)h_
                && i_());
        }

        bool? e_ = context.Operators.WhereAny<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Acute_Inpatient_Discharge_with_Advanced_Illness, Acute_Inpatient_Discharge_with_Advanced_Illness_Compute);

    private const long _cacheIndex_Acute_Inpatient_Discharge_with_Advanced_Illness = -132452363031990196L;

    private bool? Acute_Inpatient_Discharge_with_Advanced_Illness_Compute(CqlContext context)
    {
        IEnumerable<Claim> a_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
        IEnumerable<Claim> c_ = b_?.AcuteInpatientDischarge;
        CqlValueSet d_ = this.Advanced_Illness(context);
        IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, c_, e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;

        bool? h_(CqlInterval<CqlDateTime> InpatientDischarge) {
            CqlDateTime j_ = context.Operators.End(InpatientDischarge);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlDate n_ = context.Operators.DateFrom(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "year");
            CqlDate p_ = context.Operators.Subtract(n_, o_);
            CqlDateTime q_ = context.Operators.End(l_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlInterval<CqlDate> s_ = context.Operators.Interval(p_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDate>(k_, s_, (string)default);
            return t_;
        }

        bool? i_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Dementia_Medications_In_Year_Before_or_During_Measurement_Period, Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Compute);

    private const long _cacheIndex_Dementia_Medications_In_Year_Before_or_During_Measurement_Period = -6328015377898273548L;

    private bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Dementia_Medications(context);
        IEnumerable<MedicationDispense> b_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
        IEnumerable<MedicationDispense> c_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));

        bool? d_(MedicationDispense MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? k_(Medication M) {
                Id m_ = M?.IdElement;
                string n_ = FHIRHelpers_4_0_001.Instance.ToString(context, m_);
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string p_ = FHIRHelpers_4_0_001.Instance.ToString(context, o_ as FhirString);
                IEnumerable<string> q_ = context.Operators.Split(p_, "/");
                string r_ = context.Operators.Last<string>(q_);
                bool? s_ = context.Operators.Equal(n_, r_);

                CqlBoolean t_() {
                    CodeableConcept u_ = M?.Code;
                    CqlConcept v_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, u_);
                    CqlValueSet w_ = this.Dementia_Medications(context);
                    bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                    return x_;
                }

                return /* CQL 'and' */ ((CqlBoolean)s_
                    && t_());
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationDispense> e_ = context.Operators.Where<MedicationDispense>(c_, d_);
        IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(b_, e_);
        IEnumerable<MedicationDispense> g_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, f_);

        bool? h_(MedicationDispense DementiaMedDispensed) {
            FhirDateTime y_ = DementiaMedDispensed?.WhenHandedOverElement;
            CqlInterval<CqlDateTime> z_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlDate ab_ = context.Operators.DateFrom(aa_);
            CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            CqlDate ae_ = context.Operators.DateFrom(ad_);
            CqlQuantity af_ = context.Operators.Quantity(1m, "year");
            CqlDate ag_ = context.Operators.Subtract(ae_, af_);
            CqlDateTime ah_ = context.Operators.End(ac_);
            CqlDate ai_ = context.Operators.DateFrom(ah_);
            CqlInterval<CqlDate> aj_ = context.Operators.Interval(ag_, ai_, true, true);
            bool? ak_ = context.Operators.In<CqlDate>(ab_, aj_, (string)default);
            return ak_;
        }

        bool? i_ = context.Operators.WhereAny<MedicationDispense>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80, Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Compute);

    private const long _cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80 = 3948105317562077147L;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(66, 80, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);

        CqlBoolean k_() {
            bool? m_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
            return /* CQL 'or' (34:11-38:7) */ (/* CQL 'or' (34:13-36:62) */ (/* CQL 'or' (34:13-35:62) */ ((CqlBoolean)m_
                || this.Acute_Inpatient_Encounter_with_Advanced_Illness(context))
                || this.Acute_Inpatient_Discharge_with_Advanced_Illness(context))
                || this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context));
        }


        CqlBoolean l_() {
            Patient n_ = this.Patient(context);
            Date o_ = n_?.BirthDateElement;
            string p_ = o_?.Value;
            CqlDate q_ = context.Operators.ConvertStringToDate(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            int? u_ = context.Operators.CalculateAgeAt(q_, t_, "year");
            bool? v_ = context.Operators.GreaterOrEqual(u_, 81);
            return /* CQL 'and' (40:8-44:5) */ ((CqlBoolean)v_
                && this.Has_Criteria_Indicating_Frailty(context));
        }

        return /* CQL 'or' (30:3-44:5) */ (/* CQL 'and' (30:3-39:3) */ (/* CQL 'and' (30:5-33:43) */ ((CqlBoolean)j_
            && this.Has_Criteria_Indicating_Frailty(context))
            && k_())
            || l_());
    }


    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80, Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Compute);

    private const long _cacheIndex_Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80 = -3586192422471449037L;

    private bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 66);

        CqlBoolean j_() {
            bool? k_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
            return /* CQL 'or' (51:9-55:5) */ (/* CQL 'or' (51:11-53:60) */ (/* CQL 'or' (51:11-52:60) */ ((CqlBoolean)k_
                || this.Acute_Inpatient_Encounter_with_Advanced_Illness(context))
                || this.Acute_Inpatient_Discharge_with_Advanced_Illness(context))
                || this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context));
        }

        return /* CQL 'and' (47:3-55:5) */ (/* CQL 'and' (47:3-50:41) */ ((CqlBoolean)i_
            && this.Has_Criteria_Indicating_Frailty(context))
            && j_());
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAAdvancedIllnessandFrailty_1_0_0() {}

    public static NCQAAdvancedIllnessandFrailty_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAAdvancedIllnessandFrailty";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQAEncounter_1_0_0.Instance, NCQAClaims_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV = new(
       [typeof(CqlDate), typeof(CqlDate)],
       ["OutpatientVisit1", "OutpatientVisit2"]);

    #endregion CqlTupleMetadata Properties

}
