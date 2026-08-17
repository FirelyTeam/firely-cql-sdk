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
                    t_ = ac_ as CqlDateTime;
                }
                else
                {
                    if (ad_)
                    {
                        t_ = ac_ as CqlDateTime;
                    }
                    else
                    {
                        bool ae_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            t_ = ac_ as CqlInterval<CqlDateTime>;
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
            object af_;
            DataType ah_ = @this?.Effective;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            bool aj_ = ai_ is CqlDateTime;
            if (aj_)
            {
                af_ = ai_ as CqlDateTime;
            }
            else
            {
                if (aj_)
                {
                    af_ = ai_ as CqlDateTime;
                }
                else
                {
                    bool ak_ = ai_ is CqlInterval<CqlDateTime>;
                    if (ak_)
                    {
                        af_ = ai_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        af_ = null;
                    }
                }
            }
            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
            return ag_;
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
                k_ = u_ as CqlDateTime;
            }
            else
            {
                if (v_)
                {
                    k_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlInterval<CqlDateTime>;
                    if (w_)
                    {
                        k_ = u_ as CqlInterval<CqlDateTime>;
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
                Code<ObservationStatus> x_ = Parity?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                s_ = r_ & ab_;
            }
            // CQL 'and' (153:7-155:36): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                DataType ac_ = Parity?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return s_ & (!((bool?)(ad_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ae_;
            DataType ag_ = @this?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool ai_ = ah_ is CqlDateTime;
            if (ai_)
            {
                ae_ = ah_ as CqlDateTime;
            }
            else
            {
                if (ai_)
                {
                    ae_ = ah_ as CqlDateTime;
                }
                else
                {
                    bool aj_ = ah_ is CqlInterval<CqlDateTime>;
                    if (aj_)
                    {
                        ae_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ae_ = null;
                    }
                }
            }
            CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
            return af_;
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
                k_ = u_ as CqlDateTime;
            }
            else
            {
                if (v_)
                {
                    k_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlInterval<CqlDateTime>;
                    if (w_)
                    {
                        k_ = u_ as CqlInterval<CqlDateTime>;
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
                Code<ObservationStatus> x_ = PretermBirth?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                s_ = r_ & ab_;
            }
            // CQL 'and' (137:7-139:42): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                DataType ac_ = PretermBirth?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return s_ & (!((bool?)(ad_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ae_;
            DataType ag_ = @this?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool ai_ = ah_ is CqlDateTime;
            if (ai_)
            {
                ae_ = ah_ as CqlDateTime;
            }
            else
            {
                if (ai_)
                {
                    ae_ = ah_ as CqlDateTime;
                }
                else
                {
                    bool aj_ = ah_ is CqlInterval<CqlDateTime>;
                    if (aj_)
                    {
                        ae_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ae_ = null;
                    }
                }
            }
            CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
            return af_;
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
                k_ = u_ as CqlDateTime;
            }
            else
            {
                if (v_)
                {
                    k_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlInterval<CqlDateTime>;
                    if (w_)
                    {
                        k_ = u_ as CqlInterval<CqlDateTime>;
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
                Code<ObservationStatus> x_ = TermBirth?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                s_ = r_ & ab_;
            }
            // CQL 'and' (145:7-147:39): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                DataType ac_ = TermBirth?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return s_ & (!((bool?)(ad_ is null)));
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ae_;
            DataType ag_ = @this?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool ai_ = ah_ is CqlDateTime;
            if (ai_)
            {
                ae_ = ah_ as CqlDateTime;
            }
            else
            {
                if (ai_)
                {
                    ae_ = ah_ as CqlDateTime;
                }
                else
                {
                    bool aj_ = ah_ is CqlInterval<CqlDateTime>;
                    if (aj_)
                    {
                        ae_ = ah_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ae_ = null;
                    }
                }
            }
            CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
            return af_;
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
                    s_ = x_ as CqlDateTime;
                }
                else
                {
                    if (y_)
                    {
                        s_ = x_ as CqlDateTime;
                    }
                    else
                    {
                        bool z_ = x_ is CqlInterval<CqlDateTime>;
                        if (z_)
                        {
                            s_ = x_ as CqlInterval<CqlDateTime>;
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
                    Code<ObservationStatus> aa_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? ab_ = aa_?.Value;
                    string ac_ = context.Operators.Convert<string>(ab_);
                    string[] ad_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                    return v_ & ae_;
                }
            }

            IEnumerable<Observation> l_ = context.Operators.Where<Observation>(j_, k_);

            object m_(Observation @this) {
                object af_;
                DataType ah_ = @this?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlDateTime;
                if (aj_)
                {
                    af_ = ai_ as CqlDateTime;
                }
                else
                {
                    if (aj_)
                    {
                        af_ = ai_ as CqlDateTime;
                    }
                    else
                    {
                        bool ak_ = ai_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            af_ = ai_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            af_ = null;
                        }
                    }
                }
                CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
                return ag_;
            }

            IEnumerable<Observation> n_ = context.Operators.SortBy<Observation>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
            Observation o_ = context.Operators.Last<Observation>(n_);
            DataType p_ = o_?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            bool r_ = q_ is CqlDateTime;
            if (r_)
            {

                bool? al_(Observation AbnormalPresentation) {
                    object as_;
                    DataType aw_ = AbnormalPresentation?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    if (ay_)
                    {
                        as_ = ax_ as CqlDateTime;
                    }
                    else
                    {
                        if (ay_)
                        {
                            as_ = ax_ as CqlDateTime;
                        }
                        else
                        {
                            bool az_ = ax_ is CqlInterval<CqlDateTime>;
                            if (az_)
                            {
                                as_ = ax_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                as_ = null;
                            }
                        }
                    }
                    CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
                    CqlDateTime au_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? av_ = context.Operators.SameOrBefore(at_, au_, (string)default);
                    // CQL 'and' (114:9-115:80): right operand skipped when left is false
                    if (av_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> ba_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? bb_ = ba_?.Value;
                        string bc_ = context.Operators.Convert<string>(bb_);
                        string[] bd_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? be_ = context.Operators.In<string>(bc_, (IEnumerable<string>)bd_);
                        return av_ & be_;
                    }
                }

                IEnumerable<Observation> am_ = context.Operators.Where<Observation>(j_, al_);

                object an_(Observation @this) {
                    object bf_;
                    DataType bh_ = @this?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    if (bj_)
                    {
                        bf_ = bi_ as CqlDateTime;
                    }
                    else
                    {
                        if (bj_)
                        {
                            bf_ = bi_ as CqlDateTime;
                        }
                        else
                        {
                            bool bk_ = bi_ is CqlInterval<CqlDateTime>;
                            if (bk_)
                            {
                                bf_ = bi_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bf_ = null;
                            }
                        }
                    }
                    CqlDateTime bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_);
                    return bg_;
                }

                IEnumerable<Observation> ao_ = context.Operators.SortBy<Observation>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ap_ = context.Operators.Last<Observation>(ao_);
                DataType aq_ = ap_?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                d_ = ar_ as CqlDateTime;
            }
            else
            {

                bool? bl_(Observation AbnormalPresentation) {
                    object bt_;
                    DataType bx_ = AbnormalPresentation?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    if (bz_)
                    {
                        bt_ = by_ as CqlDateTime;
                    }
                    else
                    {
                        if (bz_)
                        {
                            bt_ = by_ as CqlDateTime;
                        }
                        else
                        {
                            bool ca_ = by_ is CqlInterval<CqlDateTime>;
                            if (ca_)
                            {
                                bt_ = by_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bt_ = null;
                            }
                        }
                    }
                    CqlDateTime bu_ = QICoreCommon_4_0_000.Instance.earliest(context, bt_);
                    CqlDateTime bv_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? bw_ = context.Operators.SameOrBefore(bu_, bv_, (string)default);
                    // CQL 'and' (114:9-115:80): right operand skipped when left is false
                    if (bw_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<ObservationStatus> cb_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? cc_ = cb_?.Value;
                        string cd_ = context.Operators.Convert<string>(cc_);
                        string[] ce_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cf_ = context.Operators.In<string>(cd_, (IEnumerable<string>)ce_);
                        return bw_ & cf_;
                    }
                }

                IEnumerable<Observation> bm_ = context.Operators.Where<Observation>(j_, bl_);

                object bn_(Observation @this) {
                    object cg_;
                    DataType ci_ = @this?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlDateTime;
                    if (ck_)
                    {
                        cg_ = cj_ as CqlDateTime;
                    }
                    else
                    {
                        if (ck_)
                        {
                            cg_ = cj_ as CqlDateTime;
                        }
                        else
                        {
                            bool cl_ = cj_ is CqlInterval<CqlDateTime>;
                            if (cl_)
                            {
                                cg_ = cj_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                cg_ = null;
                            }
                        }
                    }
                    CqlDateTime ch_ = QICoreCommon_4_0_000.Instance.earliest(context, cg_);
                    return ch_;
                }

                IEnumerable<Observation> bo_ = context.Operators.SortBy<Observation>(bm_, bn_, System.ComponentModel.ListSortDirection.Ascending);
                Observation bp_ = context.Operators.Last<Observation>(bo_);
                DataType bq_ = bp_?.Effective;
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlDateTime;
                if (bs_)
                {

                    bool? cm_(Observation AbnormalPresentation) {
                        object ct_;
                        DataType cx_ = AbnormalPresentation?.Effective;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        bool cz_ = cy_ is CqlDateTime;
                        if (cz_)
                        {
                            ct_ = cy_ as CqlDateTime;
                        }
                        else
                        {
                            if (cz_)
                            {
                                ct_ = cy_ as CqlDateTime;
                            }
                            else
                            {
                                bool da_ = cy_ is CqlInterval<CqlDateTime>;
                                if (da_)
                                {
                                    ct_ = cy_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    ct_ = null;
                                }
                            }
                        }
                        CqlDateTime cu_ = QICoreCommon_4_0_000.Instance.earliest(context, ct_);
                        CqlDateTime cv_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? cw_ = context.Operators.SameOrBefore(cu_, cv_, (string)default);
                        // CQL 'and' (114:9-115:80): right operand skipped when left is false
                        if (cw_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> db_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? dc_ = db_?.Value;
                            string dd_ = context.Operators.Convert<string>(dc_);
                            string[] de_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? df_ = context.Operators.In<string>(dd_, (IEnumerable<string>)de_);
                            return cw_ & df_;
                        }
                    }

                    IEnumerable<Observation> cn_ = context.Operators.Where<Observation>(j_, cm_);

                    object co_(Observation @this) {
                        object dg_;
                        DataType di_ = @this?.Effective;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlDateTime;
                        if (dk_)
                        {
                            dg_ = dj_ as CqlDateTime;
                        }
                        else
                        {
                            if (dk_)
                            {
                                dg_ = dj_ as CqlDateTime;
                            }
                            else
                            {
                                bool dl_ = dj_ is CqlInterval<CqlDateTime>;
                                if (dl_)
                                {
                                    dg_ = dj_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    dg_ = null;
                                }
                            }
                        }
                        CqlDateTime dh_ = QICoreCommon_4_0_000.Instance.earliest(context, dg_);
                        return dh_;
                    }

                    IEnumerable<Observation> cp_ = context.Operators.SortBy<Observation>(cn_, co_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation cq_ = context.Operators.Last<Observation>(cp_);
                    DataType cr_ = cq_?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    d_ = cs_ as CqlDateTime;
                }
                else
                {

                    bool? dm_(Observation AbnormalPresentation) {
                        object du_;
                        DataType dy_ = AbnormalPresentation?.Effective;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlDateTime;
                        if (ea_)
                        {
                            du_ = dz_ as CqlDateTime;
                        }
                        else
                        {
                            if (ea_)
                            {
                                du_ = dz_ as CqlDateTime;
                            }
                            else
                            {
                                bool eb_ = dz_ is CqlInterval<CqlDateTime>;
                                if (eb_)
                                {
                                    du_ = dz_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    du_ = null;
                                }
                            }
                        }
                        CqlDateTime dv_ = QICoreCommon_4_0_000.Instance.earliest(context, du_);
                        CqlDateTime dw_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? dx_ = context.Operators.SameOrBefore(dv_, dw_, (string)default);
                        // CQL 'and' (114:9-115:80): right operand skipped when left is false
                        if (dx_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<ObservationStatus> ec_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? ed_ = ec_?.Value;
                            string ee_ = context.Operators.Convert<string>(ed_);
                            string[] ef_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? eg_ = context.Operators.In<string>(ee_, (IEnumerable<string>)ef_);
                            return dx_ & eg_;
                        }
                    }

                    IEnumerable<Observation> dn_ = context.Operators.Where<Observation>(j_, dm_);

                    object do_(Observation @this) {
                        object eh_;
                        DataType ej_ = @this?.Effective;
                        object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                        bool el_ = ek_ is CqlDateTime;
                        if (el_)
                        {
                            eh_ = ek_ as CqlDateTime;
                        }
                        else
                        {
                            if (el_)
                            {
                                eh_ = ek_ as CqlDateTime;
                            }
                            else
                            {
                                bool em_ = ek_ is CqlInterval<CqlDateTime>;
                                if (em_)
                                {
                                    eh_ = ek_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    eh_ = null;
                                }
                            }
                        }
                        CqlDateTime ei_ = QICoreCommon_4_0_000.Instance.earliest(context, eh_);
                        return ei_;
                    }

                    IEnumerable<Observation> dp_ = context.Operators.SortBy<Observation>(dn_, do_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dq_ = context.Operators.Last<Observation>(dp_);
                    DataType dr_ = dq_?.Effective;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    bool dt_ = ds_ is CqlInterval<CqlDateTime>;
                    if (dt_)
                    {

                        bool? en_(Observation AbnormalPresentation) {
                            object eu_;
                            DataType ey_ = AbnormalPresentation?.Effective;
                            object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                            bool fa_ = ez_ is CqlDateTime;
                            if (fa_)
                            {
                                eu_ = ez_ as CqlDateTime;
                            }
                            else
                            {
                                if (fa_)
                                {
                                    eu_ = ez_ as CqlDateTime;
                                }
                                else
                                {
                                    bool fb_ = ez_ is CqlInterval<CqlDateTime>;
                                    if (fb_)
                                    {
                                        eu_ = ez_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        eu_ = null;
                                    }
                                }
                            }
                            CqlDateTime ev_ = QICoreCommon_4_0_000.Instance.earliest(context, eu_);
                            CqlDateTime ew_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                            bool? ex_ = context.Operators.SameOrBefore(ev_, ew_, (string)default);
                            // CQL 'and' (114:9-115:80): right operand skipped when left is false
                            if (ex_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Code<ObservationStatus> fc_ = AbnormalPresentation?.StatusElement;
                                ObservationStatus? fd_ = fc_?.Value;
                                string fe_ = context.Operators.Convert<string>(fd_);
                                string[] ff_ = [
                                    "final",
                                    "amended",
                                    "corrected",
                                ];
                                bool? fg_ = context.Operators.In<string>(fe_, (IEnumerable<string>)ff_);
                                return ex_ & fg_;
                            }
                        }

                        IEnumerable<Observation> eo_ = context.Operators.Where<Observation>(j_, en_);

                        object ep_(Observation @this) {
                            object fh_;
                            DataType fj_ = @this?.Effective;
                            object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                            bool fl_ = fk_ is CqlDateTime;
                            if (fl_)
                            {
                                fh_ = fk_ as CqlDateTime;
                            }
                            else
                            {
                                if (fl_)
                                {
                                    fh_ = fk_ as CqlDateTime;
                                }
                                else
                                {
                                    bool fm_ = fk_ is CqlInterval<CqlDateTime>;
                                    if (fm_)
                                    {
                                        fh_ = fk_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        fh_ = null;
                                    }
                                }
                            }
                            CqlDateTime fi_ = QICoreCommon_4_0_000.Instance.earliest(context, fh_);
                            return fi_;
                        }

                        IEnumerable<Observation> eq_ = context.Operators.SortBy<Observation>(eo_, ep_, System.ComponentModel.ListSortDirection.Ascending);
                        Observation er_ = context.Operators.Last<Observation>(eq_);
                        DataType es_ = er_?.Effective;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        d_ = et_ as CqlInterval<CqlDateTime>;
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
                IEnumerable<Condition> fn_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

                bool? fo_(Condition @this) {
                    CodeableConcept ft_ = @this?.Code;
                    CqlConcept fu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ft_);
                    return !((bool?)(fu_ is null));
                }


                CqlConcept fp_(Condition @this) {
                    CodeableConcept fv_ = @this?.Code;
                    CqlConcept fw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fv_);
                    return fw_;
                }

                IEnumerable<CqlConcept> fq_ = context.Operators.WhereSelect<Condition, CqlConcept>(fn_, fo_, fp_);
                CqlValueSet fr_ = this.Abnormal_Presentation(context);
                bool? fs_ = context.Operators.ConceptsInValueSet(fq_, fr_);
                h_ = g_ | fs_;
            }
            // CQL 'or' (118:5-120:76): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                List<CodeableConcept> fx_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

                CqlConcept fy_(CodeableConcept @this) {
                    CqlConcept gc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return gc_;
                }

                IEnumerable<CqlConcept> fz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fx_, fy_);
                CqlValueSet ga_ = this.Abnormal_Presentation(context);
                bool? gb_ = context.Operators.ConceptsInValueSet(fz_, ga_);
                return h_ | gb_;
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
                    i_ = m_ as CqlDateTime;
                }
                else
                {
                    bool o_ = m_ is CqlQuantity;
                    if (o_)
                    {
                        i_ = m_ as CqlQuantity;
                    }
                    else
                    {
                        bool p_ = m_ is CqlInterval<CqlDateTime>;
                        if (p_)
                        {
                            i_ = m_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool q_ = m_ is CqlInterval<CqlQuantity>;
                            if (q_)
                            {
                                i_ = m_ as CqlInterval<CqlQuantity>;
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
                    Code<EventStatus> r_ = CSection?.StatusElement;
                    EventStatus? s_ = r_?.Value;
                    string t_ = context.Operators.Convert<string>(s_);
                    bool? u_ = context.Operators.Equal(t_, "completed");
                    return k_ & u_;
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
