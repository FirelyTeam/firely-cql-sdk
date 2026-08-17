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
[CqlLibrary("CMS0334FHIRPCCesareanBirth", "1.0.000")]
public partial class CMS0334FHIRPCCesareanBirth_1_0_000 : ILibrary, ISingleton<CMS0334FHIRPCCesareanBirth_1_0_000>
{
    #region ValueSets (6)

    [CqlValueSetDefinition("Abnormal Presentation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", valueSetVersion: null)]
    public CqlValueSet Abnormal_Presentation(CqlContext _) => _Abnormal_Presentation;
    private static readonly CqlValueSet _Abnormal_Presentation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", null);

    [CqlValueSetDefinition("Cesarean Birth", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", valueSetVersion: null)]
    public CqlValueSet Cesarean_Birth(CqlContext _) => _Cesarean_Birth;
    private static readonly CqlValueSet _Cesarean_Birth = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", null);

    [CqlValueSetDefinition("Delivery of Singleton", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", valueSetVersion: null)]
    public CqlValueSet Delivery_of_Singleton(CqlContext _) => _Delivery_of_Singleton;
    private static readonly CqlValueSet _Delivery_of_Singleton = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", null);

    [CqlValueSetDefinition("Genital Herpes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049", valueSetVersion: null)]
    public CqlValueSet Genital_Herpes(CqlContext _) => _Genital_Herpes;
    private static readonly CqlValueSet _Genital_Herpes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049", null);

    [CqlValueSetDefinition("Placenta Accreta Spectrum Previa or Vasa Previa", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37", valueSetVersion: null)]
    public CqlValueSet Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(CqlContext _) => _Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa;
    private static readonly CqlValueSet _Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37", null);

    [CqlValueSetDefinition("37 to 42 Plus Weeks Gestation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68", valueSetVersion: null)]
    public CqlValueSet _37_to_42_Plus_Weeks_Gestation(CqlContext _) => __37_to_42_Plus_Weeks_Gestation;
    private static readonly CqlValueSet __37_to_42_Plus_Weeks_Gestation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68", null);

    #endregion ValueSets

    #region Codes (4)

    [CqlCodeDefinition("[#] Births.preterm", codeId: "11637-6", codeSystem: "http://loinc.org")]
    public CqlCode ____Births_preterm(CqlContext _) => _____Births_preterm;
    private static readonly CqlCode _____Births_preterm = new CqlCode("11637-6", "http://loinc.org");

    [CqlCodeDefinition("[#] Births.term", codeId: "11639-2", codeSystem: "http://loinc.org")]
    public CqlCode ____Births_term(CqlContext _) => _____Births_term;
    private static readonly CqlCode _____Births_term = new CqlCode("11639-2", "http://loinc.org");

    [CqlCodeDefinition("[#] Parity", codeId: "11977-6", codeSystem: "http://loinc.org")]
    public CqlCode ____Parity(CqlContext _) => _____Parity;
    private static readonly CqlCode _____Parity = new CqlCode("11977-6", "http://loinc.org");

    [CqlCodeDefinition("[#] Pregnancies", codeId: "11996-6", codeSystem: "http://loinc.org")]
    public CqlCode ____Pregnancies(CqlContext _) => _____Pregnancies;
    private static readonly CqlCode _____Pregnancies = new CqlCode("11996-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _____Births_preterm,
          _____Births_term,
          _____Parity,
          _____Pregnancies]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5698456684161873684L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS0334FHIRPCCesareanBirth-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (24)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5961161382796943919L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Calculated Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks, Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks = 5379338720289974308L;

    private IEnumerable<Encounter> Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? e_ = context.Operators.GreaterOrEqual(d_, 37);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Estimated Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks, Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks = -4717178607510065377L;

    private IEnumerable<Encounter> Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? e_ = (bool?)(d_ is null);
            // CQL 'and' (42:5-43:71): right operand skipped when left is false
            if (e_ is false)
            {
                return false;
            }
            else
            {
                CqlQuantity f_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                CqlQuantity g_ = context.Operators.Quantity(37m, "weeks");
                bool? h_ = context.Operators.GreaterOrEqual(f_, g_);
                return e_ & h_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks Based On Coding")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding, Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding = -4599066492291871118L;

    private IEnumerable<Encounter> Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? e_ = (bool?)(d_ is null);
            bool? f_;
            // CQL 'and' (54:11-55:21): right operand skipped when left is false
            if (e_ is false)
            {
                f_ = false;
            }
            else
            {
                CqlQuantity g_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                f_ = e_ & ((bool?)(g_ is null));
            }
            // CQL 'and' (54:5-58:7): right operand skipped when left is false
            if (f_ is false)
            {
                return false;
            }
            else
            {
                List<CodeableConcept> h_ = DeliveryEncounter?.ReasonCode;

                CqlConcept i_(CodeableConcept @this) {
                    CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return n_;
                }

                IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
                CqlValueSet k_ = this._37_to_42_Plus_Weeks_Gestation(context);
                bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
                bool? m_;
                // CQL 'or' (56:11-58:7): right operand skipped when left is true
                if (l_ is true)
                {
                    m_ = true;
                }
                else
                {
                    IEnumerable<Condition> o_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

                    bool? p_(Condition @this) {
                        CodeableConcept t_ = @this?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        return !((bool?)(u_ is null));
                    }


                    CqlConcept q_(Condition @this) {
                        CodeableConcept v_ = @this?.Code;
                        CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                        return w_;
                    }

                    IEnumerable<CqlConcept> r_ = context.Operators.WhereSelect<Condition, CqlConcept>(o_, p_, q_);
                    bool? s_ = context.Operators.ConceptsInValueSet(r_, k_);
                    m_ = l_ | s_;
                }
                return f_ & m_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks, Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks = 31587007512521178L;

    private IEnumerable<Encounter> Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With Singleton Delivery")]
    public IEnumerable<Encounter> Encounter_With_Singleton_Delivery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Singleton_Delivery, Encounter_With_Singleton_Delivery_Compute);

    private const long _cacheIndex_Encounter_With_Singleton_Delivery = -277690994937978653L;

    private IEnumerable<Encounter> Encounter_With_Singleton_Delivery_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter DeliveryEncounter) {
            List<CodeableConcept> d_ = DeliveryEncounter?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Delivery_of_Singleton(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (124:5-125:81): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

                bool? k_(Condition @this) {
                    CodeableConcept o_ = @this?.Code;
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                    return !((bool?)(p_ is null));
                }


                CqlConcept l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return r_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
                bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
                return h_ | n_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("lastGravida")]
    public int? lastGravida(CqlContext context, Encounter TheEncounter)
    {
        CqlCode a_ = this.____Pregnancies(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation Gravida) {
            DataType k_ = Gravida?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            bool? m_ = !((bool?)(l_ is null));
            bool? n_;
            // CQL 'and' (129:13-130:65): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                Code<ObservationStatus> o_ = Gravida?.StatusElement;
                ObservationStatus? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                string[] r_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                n_ = m_ & s_;
            }
            // CQL 'and' (129:7-131:98): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                object t_;
                DataType ab_ = Gravida?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    DataType ae_ = Gravida?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    t_ = af_ as CqlDateTime;
                }
                else
                {
                    DataType ag_ = Gravida?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    if (ai_)
                    {
                        DataType aj_ = Gravida?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        t_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        DataType al_ = Gravida?.Effective;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            DataType ao_ = Gravida?.Effective;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            t_ = ap_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
                CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
                CqlDateTime v_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
                CqlQuantity w_ = context.Operators.Quantity(42m, "weeks");
                CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, v_, true, false);
                bool? z_ = context.Operators.In<CqlDateTime>(u_, y_, (string)default);
                bool? aa_;
                // CQL 'and' (131:13-131:98): right operand skipped when left is false
                if (z_ is false)
                {
                    aa_ = false;
                }
                else
                {
                    aa_ = z_ & (!((bool?)(v_ is null)));
                }
                return n_ & aa_;
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object aq_;
            DataType as_ = @this?.Effective;
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
            bool au_ = at_ is CqlDateTime;
            if (au_)
            {
                DataType av_ = @this?.Effective;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                aq_ = aw_ as CqlDateTime;
            }
            else
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    DataType ba_ = @this?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    aq_ = bb_ as CqlDateTime;
                }
                else
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlInterval<CqlDateTime>;
                    if (be_)
                    {
                        DataType bf_ = @this?.Effective;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        aq_ = bg_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        aq_ = null;
                    }
                }
            }
            CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
            return ar_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlFunctionDefinition("lastParity")]
    public int? lastParity(CqlContext context, Encounter TheEncounter)
    {
        CqlCode a_ = this.____Parity(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation Parity) {
            object k_;
            DataType t_ = Parity?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                DataType w_ = Parity?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                k_ = x_ as CqlDateTime;
            }
            else
            {
                DataType y_ = Parity?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = Parity?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    k_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = Parity?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType ag_ = Parity?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        k_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        k_ = null;
                    }
                }
            }
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_);
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);
            bool? r_;
            // CQL 'and' (153:13-153:97): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                r_ = q_ & (!((bool?)(m_ is null)));
            }
            bool? s_;
            // CQL 'and' (153:13-154:64): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                Code<ObservationStatus> ai_ = Parity?.StatusElement;
                ObservationStatus? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                s_ = r_ & am_;
            }
            // CQL 'and' (153:7-155:36): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                DataType an_ = Parity?.Value;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                return s_ & (!((bool?)(ao_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ap_;
            DataType ar_ = @this?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            bool at_ = as_ is CqlDateTime;
            if (at_)
            {
                DataType au_ = @this?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                ap_ = av_ as CqlDateTime;
            }
            else
            {
                DataType aw_ = @this?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = @this?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    ap_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = @this?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        DataType be_ = @this?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        ap_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ap_ = null;
                    }
                }
            }
            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
            return aq_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlFunctionDefinition("lastHistoryPretermBirth")]
    public int? lastHistoryPretermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode a_ = this.____Births_preterm(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation PretermBirth) {
            object k_;
            DataType t_ = PretermBirth?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                DataType w_ = PretermBirth?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                k_ = x_ as CqlDateTime;
            }
            else
            {
                DataType y_ = PretermBirth?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = PretermBirth?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    k_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = PretermBirth?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType ag_ = PretermBirth?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        k_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        k_ = null;
                    }
                }
            }
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_);
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);
            bool? r_;
            // CQL 'and' (137:13-137:103): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                r_ = q_ & (!((bool?)(m_ is null)));
            }
            bool? s_;
            // CQL 'and' (137:13-138:70): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                Code<ObservationStatus> ai_ = PretermBirth?.StatusElement;
                ObservationStatus? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                s_ = r_ & am_;
            }
            // CQL 'and' (137:7-139:42): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                DataType an_ = PretermBirth?.Value;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                return s_ & (!((bool?)(ao_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ap_;
            DataType ar_ = @this?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            bool at_ = as_ is CqlDateTime;
            if (at_)
            {
                DataType au_ = @this?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                ap_ = av_ as CqlDateTime;
            }
            else
            {
                DataType aw_ = @this?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = @this?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    ap_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = @this?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        DataType be_ = @this?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        ap_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ap_ = null;
                    }
                }
            }
            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
            return aq_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlFunctionDefinition("lastHistoryTermBirth")]
    public int? lastHistoryTermBirth(CqlContext context, Encounter TheEncounter)
    {
        CqlCode a_ = this.____Births_term(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation TermBirth) {
            object k_;
            DataType t_ = TermBirth?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                DataType w_ = TermBirth?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                k_ = x_ as CqlDateTime;
            }
            else
            {
                DataType y_ = TermBirth?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = TermBirth?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    k_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = TermBirth?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType ag_ = TermBirth?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        k_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        k_ = null;
                    }
                }
            }
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_);
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);
            bool? r_;
            // CQL 'and' (145:13-145:100): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                r_ = q_ & (!((bool?)(m_ is null)));
            }
            bool? s_;
            // CQL 'and' (145:13-146:67): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                Code<ObservationStatus> ai_ = TermBirth?.StatusElement;
                ObservationStatus? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                s_ = r_ & am_;
            }
            // CQL 'and' (145:7-147:39): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                DataType an_ = TermBirth?.Value;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                return s_ & (!((bool?)(ao_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ap_;
            DataType ar_ = @this?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            bool at_ = as_ is CqlDateTime;
            if (at_)
            {
                DataType au_ = @this?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                ap_ = av_ as CqlDateTime;
            }
            else
            {
                DataType aw_ = @this?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = @this?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    ap_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = @this?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        DataType be_ = @this?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        ap_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ap_ = null;
                    }
                }
            }
            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
            return aq_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlExpressionDefinition("Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter> Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births, Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Compute);

    private const long _cacheIndex_Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births = -1799350301391375704L;

    private IEnumerable<Encounter> Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Singleton_Delivery(context);
        IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);

        bool? d_(Encounter SingletonEncounterGE37Weeks) {
            int? f_ = this.lastGravida(context, SingletonEncounterGE37Weeks);
            bool? g_ = context.Operators.Equal(f_, 1);
            bool? h_;
            // CQL 'or' (104:13-105:61): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                int? i_ = this.lastParity(context, SingletonEncounterGE37Weeks);
                bool? j_ = context.Operators.Equal(i_, 0);
                h_ = g_ | j_;
            }
            // CQL 'or' (104:5-109:5): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                int? k_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
                bool? l_ = context.Operators.Equal(k_, 0);
                bool? m_;
                // CQL 'and' (106:12-108:9): right operand skipped when left is false
                if (l_ is false)
                {
                    m_ = false;
                }
                else
                {
                    int? n_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
                    bool? o_ = context.Operators.Equal(n_, 0);
                    m_ = l_ & o_;
                }
                return h_ | m_;
            }
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With Abnormal Presentation")]
    public IEnumerable<Encounter> Encounter_With_Abnormal_Presentation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Abnormal_Presentation, Encounter_With_Abnormal_Presentation_Compute);

    private const long _cacheIndex_Encounter_With_Abnormal_Presentation = 4272829473243556987L;

    private IEnumerable<Encounter> Encounter_With_Abnormal_Presentation_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        bool? b_(Encounter ThirtySevenWeeksPlusEncounter) {
            object d_;
            CqlValueSet i_ = this.Abnormal_Presentation(context);
            IEnumerable<Observation> j_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? k_(Observation AbnormalPresentation) {
                object s_;
                DataType w_ = AbnormalPresentation?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    DataType z_ = AbnormalPresentation?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    s_ = aa_ as CqlDateTime;
                }
                else
                {
                    DataType ab_ = AbnormalPresentation?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlDateTime;
                    if (ad_)
                    {
                        DataType ae_ = AbnormalPresentation?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        s_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ag_ = AbnormalPresentation?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            DataType aj_ = AbnormalPresentation?.Effective;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            s_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            s_ = null;
                        }
                    }
                }
                CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
                CqlDateTime u_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                bool? v_ = context.Operators.SameOrBefore(t_, u_, (string)default);
                // CQL 'and' (114:9-115:80): right operand skipped when left is false
                if (v_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> al_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? am_ = al_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    string[] ao_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
                    return v_ & ap_;
                }
            }

            IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);

            object m_(Observation @this) {
                object aq_;
                DataType as_ = @this?.Effective;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlDateTime;
                if (au_)
                {
                    DataType av_ = @this?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    aq_ = aw_ as CqlDateTime;
                }
                else
                {
                    DataType ax_ = @this?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlDateTime;
                    if (az_)
                    {
                        DataType ba_ = @this?.Effective;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        aq_ = bb_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bc_ = @this?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlDateTime>;
                        if (be_)
                        {
                            DataType bf_ = @this?.Effective;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            aq_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                return ar_;
            }

            IEnumerable<Observation> n_ = context.Operators.SortBy<Observation>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
            Observation o_ = context.Operators.Last<Observation>(n_);
            DataType p_ = o_?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            bool r_ = q_ is CqlDateTime;
            if (r_)
            {
                CqlValueSet bh_ = this.Abnormal_Presentation(context);
                IEnumerable<Observation> bi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                bool? bj_(Observation AbnormalPresentation) {
                    object bq_;
                    DataType bu_ = AbnormalPresentation?.Effective;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlDateTime;
                    if (bw_)
                    {
                        DataType bx_ = AbnormalPresentation?.Effective;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        bq_ = by_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bz_ = AbnormalPresentation?.Effective;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        bool cb_ = ca_ is CqlDateTime;
                        if (cb_)
                        {
                            DataType cc_ = AbnormalPresentation?.Effective;
                            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                            bq_ = cd_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ce_ = AbnormalPresentation?.Effective;
                            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                            bool cg_ = cf_ is CqlInterval<CqlDateTime>;
                            if (cg_)
                            {
                                DataType ch_ = AbnormalPresentation?.Effective;
                                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                                bq_ = ci_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bq_ = null;
                            }
                        }
                    }
                    CqlDateTime br_ = QICoreCommon_4_0_000.Instance.earliest(context, bq_);
                    CqlDateTime bs_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? bt_ = context.Operators.SameOrBefore(br_, bs_, (string)default);
                    // CQL 'and' (114:9-115:80): right operand skipped when left is false
                    if (bt_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> cj_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ck_ = cj_?.Value;
                        string cl_ = context.Operators.Convert<string>(ck_);
                        string[] cm_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cn_ = context.Operators.In<string>(cl_, (IEnumerable<string>)cm_);
                        return bt_ & cn_;
                    }
                }

                IEnumerable<Observation> bk_ = context.Operators.Where<Observation>(bi_, bj_);

                object bl_(Observation @this) {
                    object co_;
                    DataType cq_ = @this?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlDateTime;
                    if (cs_)
                    {
                        DataType ct_ = @this?.Effective;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        co_ = cu_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cv_ = @this?.Effective;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        bool cx_ = cw_ is CqlDateTime;
                        if (cx_)
                        {
                            DataType cy_ = @this?.Effective;
                            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                            co_ = cz_ as CqlDateTime;
                        }
                        else
                        {
                            DataType da_ = @this?.Effective;
                            object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                            bool dc_ = db_ is CqlInterval<CqlDateTime>;
                            if (dc_)
                            {
                                DataType dd_ = @this?.Effective;
                                object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                                co_ = de_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                co_ = null;
                            }
                        }
                    }
                    CqlDateTime cp_ = QICoreCommon_4_0_000.Instance.earliest(context, co_);
                    return cp_;
                }

                IEnumerable<Observation> bm_ = context.Operators.SortBy<Observation>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
                Observation bn_ = context.Operators.Last<Observation>(bm_);
                DataType bo_ = bn_?.Effective;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                d_ = bp_ as CqlDateTime;
            }
            else
            {
                CqlValueSet df_ = this.Abnormal_Presentation(context);
                IEnumerable<Observation> dg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, df_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                bool? dh_(Observation AbnormalPresentation) {
                    object dp_;
                    DataType dt_ = AbnormalPresentation?.Effective;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlDateTime;
                    if (dv_)
                    {
                        DataType dw_ = AbnormalPresentation?.Effective;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        dp_ = dx_ as CqlDateTime;
                    }
                    else
                    {
                        DataType dy_ = AbnormalPresentation?.Effective;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlDateTime;
                        if (ea_)
                        {
                            DataType eb_ = AbnormalPresentation?.Effective;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            dp_ = ec_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ed_ = AbnormalPresentation?.Effective;
                            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            bool ef_ = ee_ is CqlInterval<CqlDateTime>;
                            if (ef_)
                            {
                                DataType eg_ = AbnormalPresentation?.Effective;
                                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                                dp_ = eh_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                dp_ = null;
                            }
                        }
                    }
                    CqlDateTime dq_ = QICoreCommon_4_0_000.Instance.earliest(context, dp_);
                    CqlDateTime dr_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? ds_ = context.Operators.SameOrBefore(dq_, dr_, (string)default);
                    // CQL 'and' (114:9-115:80): right operand skipped when left is false
                    if (ds_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> ei_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ej_ = ei_?.Value;
                        string ek_ = context.Operators.Convert<string>(ej_);
                        string[] el_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? em_ = context.Operators.In<string>(ek_, (IEnumerable<string>)el_);
                        return ds_ & em_;
                    }
                }

                IEnumerable<Observation> di_ = context.Operators.Where<Observation>(dg_, dh_);

                object dj_(Observation @this) {
                    object en_;
                    DataType ep_ = @this?.Effective;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    bool er_ = eq_ is CqlDateTime;
                    if (er_)
                    {
                        DataType es_ = @this?.Effective;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        en_ = et_ as CqlDateTime;
                    }
                    else
                    {
                        DataType eu_ = @this?.Effective;
                        object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                        bool ew_ = ev_ is CqlDateTime;
                        if (ew_)
                        {
                            DataType ex_ = @this?.Effective;
                            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            en_ = ey_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ez_ = @this?.Effective;
                            object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                            bool fb_ = fa_ is CqlInterval<CqlDateTime>;
                            if (fb_)
                            {
                                DataType fc_ = @this?.Effective;
                                object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                                en_ = fd_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                en_ = null;
                            }
                        }
                    }
                    CqlDateTime eo_ = QICoreCommon_4_0_000.Instance.earliest(context, en_);
                    return eo_;
                }

                IEnumerable<Observation> dk_ = context.Operators.SortBy<Observation>(di_, dj_, System.ComponentModel.ListSortDirection.Ascending);
                Observation dl_ = context.Operators.Last<Observation>(dk_);
                DataType dm_ = dl_?.Effective;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                bool do_ = dn_ is CqlDateTime;
                if (do_)
                {
                    CqlValueSet fe_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> ff_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fe_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? fg_(Observation AbnormalPresentation) {
                        object fn_;
                        DataType fr_ = AbnormalPresentation?.Effective;
                        object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                        bool ft_ = fs_ is CqlDateTime;
                        if (ft_)
                        {
                            DataType fu_ = AbnormalPresentation?.Effective;
                            object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                            fn_ = fv_ as CqlDateTime;
                        }
                        else
                        {
                            DataType fw_ = AbnormalPresentation?.Effective;
                            object fx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fw_);
                            bool fy_ = fx_ is CqlDateTime;
                            if (fy_)
                            {
                                DataType fz_ = AbnormalPresentation?.Effective;
                                object ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                                fn_ = ga_ as CqlDateTime;
                            }
                            else
                            {
                                DataType gb_ = AbnormalPresentation?.Effective;
                                object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                                bool gd_ = gc_ is CqlInterval<CqlDateTime>;
                                if (gd_)
                                {
                                    DataType ge_ = AbnormalPresentation?.Effective;
                                    object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                                    fn_ = gf_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    fn_ = null;
                                }
                            }
                        }
                        CqlDateTime fo_ = QICoreCommon_4_0_000.Instance.earliest(context, fn_);
                        CqlDateTime fp_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? fq_ = context.Operators.SameOrBefore(fo_, fp_, (string)default);
                        // CQL 'and' (114:9-115:80): right operand skipped when left is false
                        if (fq_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> gg_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? gh_ = gg_?.Value;
                            string gi_ = context.Operators.Convert<string>(gh_);
                            string[] gj_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? gk_ = context.Operators.In<string>(gi_, (IEnumerable<string>)gj_);
                            return fq_ & gk_;
                        }
                    }

                    IEnumerable<Observation> fh_ = context.Operators.Where<Observation>(ff_, fg_);

                    object fi_(Observation @this) {
                        object gl_;
                        DataType gn_ = @this?.Effective;
                        object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                        bool gp_ = go_ is CqlDateTime;
                        if (gp_)
                        {
                            DataType gq_ = @this?.Effective;
                            object gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                            gl_ = gr_ as CqlDateTime;
                        }
                        else
                        {
                            DataType gs_ = @this?.Effective;
                            object gt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gs_);
                            bool gu_ = gt_ is CqlDateTime;
                            if (gu_)
                            {
                                DataType gv_ = @this?.Effective;
                                object gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                                gl_ = gw_ as CqlDateTime;
                            }
                            else
                            {
                                DataType gx_ = @this?.Effective;
                                object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                                bool gz_ = gy_ is CqlInterval<CqlDateTime>;
                                if (gz_)
                                {
                                    DataType ha_ = @this?.Effective;
                                    object hb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ha_);
                                    gl_ = hb_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    gl_ = null;
                                }
                            }
                        }
                        CqlDateTime gm_ = QICoreCommon_4_0_000.Instance.earliest(context, gl_);
                        return gm_;
                    }

                    IEnumerable<Observation> fj_ = context.Operators.SortBy<Observation>(fh_, fi_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation fk_ = context.Operators.Last<Observation>(fj_);
                    DataType fl_ = fk_?.Effective;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                    d_ = fm_ as CqlDateTime;
                }
                else
                {
                    CqlValueSet hc_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> hd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? he_(Observation AbnormalPresentation) {
                        object hm_;
                        DataType hq_ = AbnormalPresentation?.Effective;
                        object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);
                        bool hs_ = hr_ is CqlDateTime;
                        if (hs_)
                        {
                            DataType ht_ = AbnormalPresentation?.Effective;
                            object hu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ht_);
                            hm_ = hu_ as CqlDateTime;
                        }
                        else
                        {
                            DataType hv_ = AbnormalPresentation?.Effective;
                            object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                            bool hx_ = hw_ is CqlDateTime;
                            if (hx_)
                            {
                                DataType hy_ = AbnormalPresentation?.Effective;
                                object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                                hm_ = hz_ as CqlDateTime;
                            }
                            else
                            {
                                DataType ia_ = AbnormalPresentation?.Effective;
                                object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                                bool ic_ = ib_ is CqlInterval<CqlDateTime>;
                                if (ic_)
                                {
                                    DataType id_ = AbnormalPresentation?.Effective;
                                    object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);
                                    hm_ = ie_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    hm_ = null;
                                }
                            }
                        }
                        CqlDateTime hn_ = QICoreCommon_4_0_000.Instance.earliest(context, hm_);
                        CqlDateTime ho_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? hp_ = context.Operators.SameOrBefore(hn_, ho_, (string)default);
                        // CQL 'and' (114:9-115:80): right operand skipped when left is false
                        if (hp_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> if_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? ig_ = if_?.Value;
                            string ih_ = context.Operators.Convert<string>(ig_);
                            string[] ii_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? ij_ = context.Operators.In<string>(ih_, (IEnumerable<string>)ii_);
                            return hp_ & ij_;
                        }
                    }

                    IEnumerable<Observation> hf_ = context.Operators.Where<Observation>(hd_, he_);

                    object hg_(Observation @this) {
                        object ik_;
                        DataType im_ = @this?.Effective;
                        object in_ = FHIRHelpers_4_4_000.Instance.ToValue(context, im_);
                        bool io_ = in_ is CqlDateTime;
                        if (io_)
                        {
                            DataType ip_ = @this?.Effective;
                            object iq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ip_);
                            ik_ = iq_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ir_ = @this?.Effective;
                            object is_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ir_);
                            bool it_ = is_ is CqlDateTime;
                            if (it_)
                            {
                                DataType iu_ = @this?.Effective;
                                object iv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iu_);
                                ik_ = iv_ as CqlDateTime;
                            }
                            else
                            {
                                DataType iw_ = @this?.Effective;
                                object ix_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iw_);
                                bool iy_ = ix_ is CqlInterval<CqlDateTime>;
                                if (iy_)
                                {
                                    DataType iz_ = @this?.Effective;
                                    object ja_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iz_);
                                    ik_ = ja_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    ik_ = null;
                                }
                            }
                        }
                        CqlDateTime il_ = QICoreCommon_4_0_000.Instance.earliest(context, ik_);
                        return il_;
                    }

                    IEnumerable<Observation> hh_ = context.Operators.SortBy<Observation>(hf_, hg_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation hi_ = context.Operators.Last<Observation>(hh_);
                    DataType hj_ = hi_?.Effective;
                    object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                    bool hl_ = hk_ is CqlInterval<CqlDateTime>;
                    if (hl_)
                    {
                        CqlValueSet jb_ = this.Abnormal_Presentation(context);
                        IEnumerable<Observation> jc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                        bool? jd_(Observation AbnormalPresentation) {
                            object jk_;
                            DataType jo_ = AbnormalPresentation?.Effective;
                            object jp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jo_);
                            bool jq_ = jp_ is CqlDateTime;
                            if (jq_)
                            {
                                DataType jr_ = AbnormalPresentation?.Effective;
                                object js_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jr_);
                                jk_ = js_ as CqlDateTime;
                            }
                            else
                            {
                                DataType jt_ = AbnormalPresentation?.Effective;
                                object ju_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jt_);
                                bool jv_ = ju_ is CqlDateTime;
                                if (jv_)
                                {
                                    DataType jw_ = AbnormalPresentation?.Effective;
                                    object jx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jw_);
                                    jk_ = jx_ as CqlDateTime;
                                }
                                else
                                {
                                    DataType jy_ = AbnormalPresentation?.Effective;
                                    object jz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jy_);
                                    bool ka_ = jz_ is CqlInterval<CqlDateTime>;
                                    if (ka_)
                                    {
                                        DataType kb_ = AbnormalPresentation?.Effective;
                                        object kc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kb_);
                                        jk_ = kc_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        jk_ = null;
                                    }
                                }
                            }
                            CqlDateTime jl_ = QICoreCommon_4_0_000.Instance.earliest(context, jk_);
                            CqlDateTime jm_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                            bool? jn_ = context.Operators.SameOrBefore(jl_, jm_, (string)default);
                            // CQL 'and' (114:9-115:80): right operand skipped when left is false
                            if (jn_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Code<ObservationStatus> kd_ = AbnormalPresentation?.StatusElement;
                                ObservationStatus? ke_ = kd_?.Value;
                                string kf_ = context.Operators.Convert<string>(ke_);
                                string[] kg_ = [
                                    "final",
                                    "amended",
                                    "corrected",
                                ];
                                bool? kh_ = context.Operators.In<string>(kf_, (IEnumerable<string>)kg_);
                                return jn_ & kh_;
                            }
                        }

                        IEnumerable<Observation> je_ = context.Operators.Where<Observation>(jc_, jd_);

                        object jf_(Observation @this) {
                            object ki_;
                            DataType kk_ = @this?.Effective;
                            object kl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kk_);
                            bool km_ = kl_ is CqlDateTime;
                            if (km_)
                            {
                                DataType kn_ = @this?.Effective;
                                object ko_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kn_);
                                ki_ = ko_ as CqlDateTime;
                            }
                            else
                            {
                                DataType kp_ = @this?.Effective;
                                object kq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kp_);
                                bool kr_ = kq_ is CqlDateTime;
                                if (kr_)
                                {
                                    DataType ks_ = @this?.Effective;
                                    object kt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ks_);
                                    ki_ = kt_ as CqlDateTime;
                                }
                                else
                                {
                                    DataType ku_ = @this?.Effective;
                                    object kv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ku_);
                                    bool kw_ = kv_ is CqlInterval<CqlDateTime>;
                                    if (kw_)
                                    {
                                        DataType kx_ = @this?.Effective;
                                        object ky_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kx_);
                                        ki_ = ky_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        ki_ = null;
                                    }
                                }
                            }
                            CqlDateTime kj_ = QICoreCommon_4_0_000.Instance.earliest(context, ki_);
                            return kj_;
                        }

                        IEnumerable<Observation> jg_ = context.Operators.SortBy<Observation>(je_, jf_, System.ComponentModel.ListSortDirection.Ascending);
                        Observation jh_ = context.Operators.Last<Observation>(jg_);
                        DataType ji_ = jh_?.Effective;
                        object jj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ji_);
                        d_ = jj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        d_ = null;
                    }
                }
            }
            CqlDateTime e_ = QICoreCommon_4_0_000.Instance.earliest(context, d_);
            CqlInterval<CqlDateTime> f_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
            bool? g_ = context.Operators.In<CqlDateTime>(e_, f_, (string)default);
            bool? h_;
            // CQL 'or' (118:11-119:93): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                IEnumerable<Condition> kz_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

                bool? la_(Condition @this) {
                    CodeableConcept lf_ = @this?.Code;
                    CqlConcept lg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lf_);
                    return !((bool?)(lg_ is null));
                }


                CqlConcept lb_(Condition @this) {
                    CodeableConcept lh_ = @this?.Code;
                    CqlConcept li_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lh_);
                    return li_;
                }

                IEnumerable<CqlConcept> lc_ = context.Operators.WhereSelect<Condition, CqlConcept>(kz_, la_, lb_);
                CqlValueSet ld_ = this.Abnormal_Presentation(context);
                bool? le_ = context.Operators.ConceptsInValueSet(lc_, ld_);
                h_ = g_ | le_;
            }
            // CQL 'or' (118:5-120:76): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                List<CodeableConcept> lj_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

                CqlConcept lk_(CodeableConcept @this) {
                    CqlConcept lo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return lo_;
                }

                IEnumerable<CqlConcept> ll_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)lj_, lk_);
                CqlValueSet lm_ = this.Abnormal_Presentation(context);
                bool? ln_ = context.Operators.ConceptsInValueSet(ll_, lm_);
                return h_ | ln_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum, Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute);

    private const long _cacheIndex_Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum = -2782160851625608974L;

    private IEnumerable<Encounter> Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        bool? b_(Encounter ThirtySevenWeeksPlusEncounter) {
            IEnumerable<Condition> d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? e_(Condition @this) {
                CodeableConcept l_ = @this?.Code;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                return !((bool?)(m_ is null));
            }


            CqlConcept f_(Condition @this) {
                CodeableConcept n_ = @this?.Code;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                return o_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.WhereSelect<Condition, CqlConcept>(d_, e_, f_);
            CqlValueSet h_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            bool? j_;
            // CQL 'or' (95:13-96:88): right operand skipped when left is true
            if (i_ is true)
            {
                j_ = true;
            }
            else
            {

                bool? p_(Condition @this) {
                    CodeableConcept u_ = @this?.Code;
                    CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                    return !((bool?)(v_ is null));
                }


                CqlConcept q_(Condition @this) {
                    CodeableConcept w_ = @this?.Code;
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                    return x_;
                }

                IEnumerable<CqlConcept> r_ = context.Operators.WhereSelect<Condition, CqlConcept>(d_, p_, q_);
                CqlValueSet s_ = this.Genital_Herpes(context);
                bool? t_ = context.Operators.ConceptsInValueSet(r_, s_);
                j_ = i_ | t_;
            }
            bool? k_;
            // CQL 'or' (95:13-97:71): right operand skipped when left is true
            if (j_ is true)
            {
                k_ = true;
            }
            else
            {
                List<CodeableConcept> y_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

                CqlConcept z_(CodeableConcept @this) {
                    CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ad_;
                }

                IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)y_, z_);
                CqlValueSet ab_ = this.Genital_Herpes(context);
                bool? ac_ = context.Operators.ConceptsInValueSet(aa_, ab_);
                k_ = j_ | ac_;
            }
            // CQL 'or' (95:5-99:5): right operand skipped when left is true
            if (k_ is true)
            {
                return true;
            }
            else
            {
                List<CodeableConcept> ae_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

                CqlConcept af_(CodeableConcept @this) {
                    CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ai_;
                }

                IEnumerable<CqlConcept> ag_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ae_, af_);
                bool? ah_ = context.Operators.ConceptsInValueSet(ag_, h_);
                return k_ | ah_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum, Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum = 8000357963463375481L;

    private IEnumerable<Encounter> Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Abnormal_Presentation(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -8664603006890304414L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2734807720100010848L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(context);
        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1892918681008019555L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);
        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Cesarean Birth")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Cesarean_Birth(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Cesarean_Birth, Delivery_Encounter_With_Cesarean_Birth_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Cesarean_Birth = 4719930836019446583L;

    private IEnumerable<Encounter> Delivery_Encounter_With_Cesarean_Birth_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        bool? b_(Encounter ThirtySevenWeeksPlusEncounter) {
            CqlValueSet d_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure CSection) {
                CqlInterval<CqlDateTime> h_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
                object i_;
                DataType l_ = CSection?.Performed;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool n_ = m_ is CqlDateTime;
                if (n_)
                {
                    DataType o_ = CSection?.Performed;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    i_ = p_ as CqlDateTime;
                }
                else
                {
                    DataType q_ = CSection?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlQuantity;
                    if (s_)
                    {
                        DataType t_ = CSection?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        i_ = u_ as CqlQuantity;
                    }
                    else
                    {
                        DataType v_ = CSection?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlInterval<CqlDateTime>;
                        if (x_)
                        {
                            DataType y_ = CSection?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            i_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType aa_ = CSection?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            bool ac_ = ab_ is CqlInterval<CqlQuantity>;
                            if (ac_)
                            {
                                DataType ad_ = CSection?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                i_ = ae_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);
                // CQL 'and' (90:17-91:41): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    Code<EventStatus> af_ = CSection?.StatusElement;
                    EventStatus? ag_ = af_?.Value;
                    string ah_ = context.Operators.Convert<string>(ag_);
                    bool? ai_ = context.Operators.Equal(ah_, "completed");
                    return k_ & ai_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 3728176582968890656L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Cesarean_Birth(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 9142028828367787573L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7839211395831048092L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -930507570789787426L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 6216205408863169115L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Variable_Calculated_Gestational_Age, SDE_Variable_Calculated_Gestational_Age_Compute);

    private const long _cacheIndex_SDE_Variable_Calculated_Gestational_Age = -5401214914748415782L;

    private IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> a_ = PCMaternal_5_25_000.Instance.Variable_Calculated_Gestational_Age(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS0334FHIRPCCesareanBirth_1_0_000() {}

    public static CMS0334FHIRPCCesareanBirth_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS0334FHIRPCCesareanBirth";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, PCMaternal_5_25_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

}
