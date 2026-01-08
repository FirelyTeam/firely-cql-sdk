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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("NCQAAdvancedIllnessandFrailty", "1.0.0")]
public partial class NCQAAdvancedIllnessandFrailty_1_0_0 : ILibrary, ISingleton<NCQAAdvancedIllnessandFrailty_1_0_0>
{
    #region ValueSets

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

    #region Parameters

    private readonly Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("NCQAAdvancedIllnessandFrailty-1.0.0", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private readonly Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private readonly Cached<bool?> _Has_Criteria_Indicating_Frailty_Cached = new();

    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context) =>
        _Has_Criteria_Indicating_Frailty_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Frailty_Device(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

                bool? c_(Observation FrailtyDeviceApplied) {
                    DataType z_ = FrailtyDeviceApplied?.Effective;
                    CqlInterval<CqlDateTime> aa_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, z_);
                    CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
                    bool? ac_ = context.Operators.Overlaps(aa_, ab_, default);
                    return ac_;
                }

                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                bool? e_ = context.Operators.Exists<Observation>(d_);
                CqlValueSet f_ = this.Frailty_Diagnosis(context);
                IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                IEnumerable<Condition> h_ = NCQAStatus_1_0_0.Instance.Active_Condition(context, g_);

                bool? i_(Condition FrailtyDiagnosis) {
                    CqlInterval<CqlDateTime> ad_ = NCQAFHIRBase_1_0_0.Instance.Prevalence_Period(context, FrailtyDiagnosis);
                    CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                    bool? af_ = context.Operators.Overlaps(ad_, ae_, default);
                    return af_;
                }

                IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
                bool? k_ = context.Operators.Exists<Condition>(j_);
                bool? l_ = context.Operators.Or(e_, k_);
                CqlValueSet m_ = this.Frailty_Encounter(context);
                IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> o_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, n_);

                bool? p_(Encounter FrailtyEncounter) {
                    Period ag_ = FrailtyEncounter?.Period;
                    CqlInterval<CqlDateTime> ah_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ag_ as object);
                    CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
                    bool? aj_ = context.Operators.Overlaps(ah_, ai_, default);
                    return aj_;
                }

                IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
                bool? r_ = context.Operators.Exists<Encounter>(q_);
                bool? s_ = context.Operators.Or(l_, r_);
                CqlValueSet t_ = this.Frailty_Symptom(context);
                IEnumerable<Observation> u_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

                bool? v_(Observation FrailtySymptom) {
                    DataType ak_ = FrailtySymptom?.Effective;
                    CqlInterval<CqlDateTime> al_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ak_);
                    CqlInterval<CqlDateTime> am_ = this.Measurement_Period(context);
                    bool? an_ = context.Operators.Overlaps(al_, am_, default);
                    return an_;
                }

                IEnumerable<Observation> w_ = context.Operators.Where<Observation>(u_, v_);
                bool? x_ = context.Operators.Exists<Observation>(w_);
                bool? y_ = context.Operators.Or(s_, x_);
                return y_;
            });


    private readonly Cached<IEnumerable<CqlDate>> _Outpatient_Encounters_with_Advanced_Illness_Cached = new();

    [CqlExpressionDefinition("Outpatient Encounters with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_with_Advanced_Illness(CqlContext context) =>
        _Outpatient_Encounters_with_Advanced_Illness_Cached.GetOrReplace(
            context,
            () => {
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
                    CqlValueSet x_ = this.Advanced_Illness(context);
                    IEnumerable<Condition> y_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                    bool? z_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, OutpatientEncounter, y_);
                    Period aa_ = OutpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ab_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, aa_ as object);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlDate ad_ = context.Operators.DateFrom(ac_);
                    CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    CqlDate ag_ = context.Operators.DateFrom(af_);
                    CqlQuantity ah_ = context.Operators.Quantity(1m, "year");
                    CqlDate ai_ = context.Operators.Subtract(ag_, ah_);
                    CqlDateTime ak_ = context.Operators.End(ae_);
                    CqlDate al_ = context.Operators.DateFrom(ak_);
                    CqlInterval<CqlDate> am_ = context.Operators.Interval(ai_, al_, true, true);
                    bool? an_ = context.Operators.In<CqlDate>(ad_, am_, default);
                    bool? ao_ = context.Operators.And(z_, an_);
                    return ao_;
                }

                IEnumerable<Encounter> t_ = context.Operators.Where<Encounter>(r_, s_);

                CqlDate u_(Encounter EncounterWithDiagnosis) {
                    Period ap_ = EncounterWithDiagnosis?.Period;
                    CqlInterval<CqlDateTime> aq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ap_ as object);
                    CqlDateTime ar_ = context.Operators.End(aq_);
                    CqlDate as_ = context.Operators.DateFrom(ar_);
                    return as_;
                }

                IEnumerable<CqlDate> v_ = context.Operators.Select<Encounter, CqlDate>(t_, u_);
                IEnumerable<CqlDate> w_ = context.Operators.Distinct<CqlDate>(v_);
                return w_;
            });


    private readonly Cached<IEnumerable<CqlDate>> _Nonacute_Inpatient_Discharge_with_Advanced_Illness_Cached = new();

    [CqlExpressionDefinition("Nonacute Inpatient Discharge with Advanced Illness")]
    public IEnumerable<CqlDate> Nonacute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context) =>
        _Nonacute_Inpatient_Discharge_with_Advanced_Illness_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Claim> a_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
                IEnumerable<Claim> c_ = b_?.NonacuteInpatientDischarge;
                CqlValueSet d_ = this.Advanced_Illness(context);
                IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, c_, e_);
                IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;

                bool? h_(CqlInterval<CqlDateTime> DischargeWithDiagnosis) {
                    CqlDateTime m_ = context.Operators.End(DischargeWithDiagnosis);
                    CqlDate n_ = context.Operators.DateFrom(m_);
                    CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                    CqlDateTime p_ = context.Operators.Start(o_);
                    CqlDate q_ = context.Operators.DateFrom(p_);
                    CqlQuantity r_ = context.Operators.Quantity(1m, "year");
                    CqlDate s_ = context.Operators.Subtract(q_, r_);
                    CqlDateTime u_ = context.Operators.End(o_);
                    CqlDate v_ = context.Operators.DateFrom(u_);
                    CqlInterval<CqlDate> w_ = context.Operators.Interval(s_, v_, true, true);
                    bool? x_ = context.Operators.In<CqlDate>(n_, w_, default);
                    return x_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Where<CqlInterval<CqlDateTime>>(g_, h_);

                CqlDate j_(CqlInterval<CqlDateTime> InpatientDischarge) {
                    CqlDateTime y_ = context.Operators.End(InpatientDischarge);
                    CqlDate z_ = context.Operators.DateFrom(y_);
                    return z_;
                }

                IEnumerable<CqlDate> k_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDate>(i_, j_);
                IEnumerable<CqlDate> l_ = context.Operators.Distinct<CqlDate>(k_);
                return l_;
            });


    private readonly Cached<IEnumerable<CqlDate>> _Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Cached = new();

    [CqlExpressionDefinition("Outpatient Encounters or Discharges with Advanced Illness")]
    public IEnumerable<CqlDate> Outpatient_Encounters_or_Discharges_with_Advanced_Illness(CqlContext context) =>
        _Outpatient_Encounters_or_Discharges_with_Advanced_Illness_Cached.GetOrReplace(
            context,
            () => {

                IEnumerable<CqlDate> a_() {

                    bool b_() {
                        IEnumerable<CqlDate> c_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                        IEnumerable<CqlDate> d_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                        IEnumerable<CqlDate> e_ = context.Operators.Union<CqlDate>(c_, d_);
                        bool? f_ = context.Operators.Not((bool?)(e_ is null));
                        return f_ ?? false;
                    }

                    if (b_())
                    {
                        IEnumerable<CqlDate> g_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                        IEnumerable<CqlDate> h_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                        IEnumerable<CqlDate> i_ = context.Operators.Union<CqlDate>(g_, h_);
                        return i_;
                    }
                    else if ((this.Outpatient_Encounters_with_Advanced_Illness(context)) is null)
                    {
                        IEnumerable<CqlDate> j_ = this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context);
                        return j_;
                    }
                    else if ((this.Nonacute_Inpatient_Discharge_with_Advanced_Illness(context)) is null)
                    {
                        IEnumerable<CqlDate> k_ = this.Outpatient_Encounters_with_Advanced_Illness(context);
                        return k_;
                    }
                    else
                    {
                        return null as IEnumerable<CqlDate>;
                    };
                }

                return a_();
            });


    private readonly Cached<bool?> _Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Cached = new();

    [CqlExpressionDefinition("Two Outpatient Visits with Advanced Illness on Different Dates of Service")]
    public bool? Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(CqlContext context) =>
        _Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<CqlDate> a_ = this.Outpatient_Encounters_or_Discharges_with_Advanced_Illness(context);
                IEnumerable<ValueTuple<CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<CqlDate, CqlDate>(a_, a_);

                (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? d_(ValueTuple<CqlDate, CqlDate> _valueTuple) {
                    (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? l_ = (CqlTupleMetadata_CMSeRgTJgKISKSQUcNZWKegGV, _valueTuple.Item1, _valueTuple.Item2);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> e_ = context.Operators.Select<ValueTuple<CqlDate, CqlDate>, (CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(c_, d_);

                bool? f_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) {
                    CqlQuantity m_ = context.Operators.Quantity(1m, "day");
                    CqlDate n_ = context.Operators.Add(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1, m_);
                    bool? o_ = context.Operators.SameOrAfter(tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit2, n_, default);
                    return o_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?> g_ = context.Operators.Where<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?>(e_, f_);
                CqlDate h_((CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)? tuple_cmsergtjgkisksqucnzwkeggv) => tuple_cmsergtjgkisksqucnzwkeggv?.OutpatientVisit1;
                IEnumerable<CqlDate> i_ = context.Operators.Select<(CqlTupleMetadata, CqlDate OutpatientVisit1, CqlDate OutpatientVisit2)?, CqlDate>(g_, h_);
                IEnumerable<CqlDate> j_ = context.Operators.Distinct<CqlDate>(i_);
                bool? k_ = context.Operators.Exists<CqlDate>(j_);
                return k_;
            });


    private readonly Cached<bool?> _Acute_Inpatient_Encounter_with_Advanced_Illness_Cached = new();

    [CqlExpressionDefinition("Acute Inpatient Encounter with Advanced Illness")]
    public bool? Acute_Inpatient_Encounter_with_Advanced_Illness(CqlContext context) =>
        _Acute_Inpatient_Encounter_with_Advanced_Illness_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Acute_Inpatient(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> c_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, b_);

                bool? d_(Encounter InpatientEncounter) {
                    CqlValueSet g_ = this.Advanced_Illness(context);
                    IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                    bool? i_ = NCQAEncounter_1_0_0.Instance.Encounter_Has_Diagnosis(context, InpatientEncounter, h_);
                    Period j_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> k_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, j_ as object);
                    CqlDateTime l_ = context.Operators.Start(k_);
                    CqlDate m_ = context.Operators.DateFrom(l_);
                    CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlDate p_ = context.Operators.DateFrom(o_);
                    CqlQuantity q_ = context.Operators.Quantity(1m, "year");
                    CqlDate r_ = context.Operators.Subtract(p_, q_);
                    CqlDateTime t_ = context.Operators.End(n_);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    CqlInterval<CqlDate> v_ = context.Operators.Interval(r_, u_, true, true);
                    bool? w_ = context.Operators.In<CqlDate>(m_, v_, default);
                    bool? x_ = context.Operators.And(i_, w_);
                    return x_;
                }

                IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
                bool? f_ = context.Operators.Exists<Encounter>(e_);
                return f_;
            });


    private readonly Cached<bool?> _Acute_Inpatient_Discharge_with_Advanced_Illness_Cached = new();

    [CqlExpressionDefinition("Acute Inpatient Discharge with Advanced Illness")]
    public bool? Acute_Inpatient_Discharge_with_Advanced_Illness(CqlContext context) =>
        _Acute_Inpatient_Discharge_with_Advanced_Illness_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Claim> a_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Claim"));
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? b_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(context, a_);
                IEnumerable<Claim> c_ = b_?.AcuteInpatientDischarge;
                CqlValueSet d_ = this.Advanced_Illness(context);
                IValueSetFacade e_ = context.Operators.CreateValueSetFacade(d_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = NCQAClaims_1_0_0.Instance.Medical_Claims_With_Diagnosis(context, c_, e_);
                IEnumerable<CqlInterval<CqlDateTime>> g_ = f_?.ServicePeriod;

                bool? h_(CqlInterval<CqlDateTime> InpatientDischarge) {
                    CqlDateTime k_ = context.Operators.End(InpatientDischarge);
                    CqlDate l_ = context.Operators.DateFrom(k_);
                    CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlDate o_ = context.Operators.DateFrom(n_);
                    CqlQuantity p_ = context.Operators.Quantity(1m, "year");
                    CqlDate q_ = context.Operators.Subtract(o_, p_);
                    CqlDateTime s_ = context.Operators.End(m_);
                    CqlDate t_ = context.Operators.DateFrom(s_);
                    CqlInterval<CqlDate> u_ = context.Operators.Interval(q_, t_, true, true);
                    bool? v_ = context.Operators.In<CqlDate>(l_, u_, default);
                    return v_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Where<CqlInterval<CqlDateTime>>(g_, h_);
                bool? j_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(i_);
                return j_;
            });


    private readonly Cached<bool?> _Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Dementia Medications In Year Before or During Measurement Period")]
    public bool? Dementia_Medications_In_Year_Before_or_During_Measurement_Period(CqlContext context) =>
        _Dementia_Medications_In_Year_Before_or_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Dementia_Medications(context);
                IEnumerable<MedicationDispense> b_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));
                IEnumerable<MedicationDispense> c_ = context.Operators.Retrieve<MedicationDispense>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationDispense"));

                IEnumerable<MedicationDispense> d_(MedicationDispense MR) {
                    IEnumerable<Medication> k_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

                    bool? l_(Medication M) {
                        Id p_ = M?.IdElement;
                        string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
                        object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                        string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_ as FhirString);
                        IEnumerable<string> t_ = context.Operators.Split(s_, "/");
                        string u_ = context.Operators.Last<string>(t_);
                        bool? v_ = context.Operators.Equal(q_, u_);
                        CodeableConcept w_ = M?.Code;
                        CqlConcept x_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, w_);
                        CqlValueSet y_ = this.Dementia_Medications(context);
                        bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                        bool? aa_ = context.Operators.And(v_, z_);
                        return aa_;
                    }

                    IEnumerable<Medication> m_ = context.Operators.Where<Medication>(k_, l_);
                    MedicationDispense n_(Medication M) => MR;
                    IEnumerable<MedicationDispense> o_ = context.Operators.Select<Medication, MedicationDispense>(m_, n_);
                    return o_;
                }

                IEnumerable<MedicationDispense> e_ = context.Operators.SelectMany<MedicationDispense, MedicationDispense>(c_, d_);
                IEnumerable<MedicationDispense> f_ = context.Operators.Union<MedicationDispense>(b_, e_);
                IEnumerable<MedicationDispense> g_ = NCQAStatus_1_0_0.Instance.Dispensed_Medication(context, f_);

                bool? h_(MedicationDispense DementiaMedDispensed) {
                    FhirDateTime ab_ = DementiaMedDispensed?.WhenHandedOverElement;
                    CqlInterval<CqlDateTime> ac_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ab_ as object);
                    CqlDateTime ad_ = context.Operators.Start(ac_);
                    CqlDate ae_ = context.Operators.DateFrom(ad_);
                    CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                    CqlDateTime ag_ = context.Operators.Start(af_);
                    CqlDate ah_ = context.Operators.DateFrom(ag_);
                    CqlQuantity ai_ = context.Operators.Quantity(1m, "year");
                    CqlDate aj_ = context.Operators.Subtract(ah_, ai_);
                    CqlDateTime al_ = context.Operators.End(af_);
                    CqlDate am_ = context.Operators.DateFrom(al_);
                    CqlInterval<CqlDate> an_ = context.Operators.Interval(aj_, am_, true, true);
                    bool? ao_ = context.Operators.In<CqlDate>(ae_, an_, default);
                    return ao_;
                }

                IEnumerable<MedicationDispense> i_ = context.Operators.Where<MedicationDispense>(g_, h_);
                bool? j_ = context.Operators.Exists<MedicationDispense>(i_);
                return j_;
            });


    private readonly Cached<bool?> _Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Cached = new();

    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80(CqlContext context) =>
        _Advanced_Illness_and_Frailty_Exclusion_Including_Over_Age_80_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.End(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(66, 80, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                bool? k_ = this.Has_Criteria_Indicating_Frailty(context);
                bool? l_ = context.Operators.And(j_, k_);
                bool? m_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
                bool? n_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
                bool? o_ = context.Operators.Or(m_, n_);
                bool? p_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
                bool? q_ = context.Operators.Or(o_, p_);
                bool? r_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
                bool? s_ = context.Operators.Or(q_, r_);
                bool? t_ = context.Operators.And(l_, s_);
                Date v_ = a_?.BirthDateElement;
                string w_ = v_?.Value;
                CqlDate x_ = context.Operators.ConvertStringToDate(w_);
                CqlDateTime z_ = context.Operators.End(e_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                int? ab_ = context.Operators.CalculateAgeAt(x_, aa_, "year");
                bool? ac_ = context.Operators.GreaterOrEqual(ab_, 81);
                bool? ae_ = context.Operators.And(ac_, k_);
                bool? af_ = context.Operators.Or(t_, ae_);
                return af_;
            });


    private readonly Cached<bool?> _Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Cached = new();

    [CqlExpressionDefinition("Advanced Illness and Frailty Exclusion Not Including Over Age 80")]
    public bool? Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(CqlContext context) =>
        _Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.End(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                bool? i_ = context.Operators.GreaterOrEqual(h_, 66);
                bool? j_ = this.Has_Criteria_Indicating_Frailty(context);
                bool? k_ = context.Operators.And(i_, j_);
                bool? l_ = this.Two_Outpatient_Visits_with_Advanced_Illness_on_Different_Dates_of_Service(context);
                bool? m_ = this.Acute_Inpatient_Encounter_with_Advanced_Illness(context);
                bool? n_ = context.Operators.Or(l_, m_);
                bool? o_ = this.Acute_Inpatient_Discharge_with_Advanced_Illness(context);
                bool? p_ = context.Operators.Or(n_, o_);
                bool? q_ = this.Dementia_Medications_In_Year_Before_or_During_Measurement_Period(context);
                bool? r_ = context.Operators.Or(p_, q_);
                bool? s_ = context.Operators.And(k_, r_);
                return s_;
            });


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

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

}
