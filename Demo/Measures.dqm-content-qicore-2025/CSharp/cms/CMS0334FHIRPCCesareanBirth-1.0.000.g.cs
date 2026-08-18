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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
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
            CqlBoolean e_ = context.Operators.GreaterOrEqual(d_, 37);
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

            CqlBoolean e_() {
                CqlQuantity f_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
                CqlQuantity g_ = context.Operators.Quantity(37m, "weeks");
                CqlBoolean h_ = context.Operators.GreaterOrEqual(f_, g_);
                return h_;
            }

            return (CqlBoolean)(d_ is null)
                /* CQL 'and' (42:5-43:71) */ && e_();
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

            CqlBoolean e_() {
                List<CodeableConcept> f_ = DeliveryEncounter?.ReasonCode;

                CqlConcept g_(CodeableConcept @this) {
                    CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return l_;
                }

                IEnumerable<CqlConcept> h_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)f_, g_);
                CqlValueSet i_ = this._37_to_42_Plus_Weeks_Gestation(context);
                CqlBoolean j_ = context.Operators.ConceptsInValueSet(h_, i_);

                CqlBoolean k_() {
                    IEnumerable<Condition> m_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

                    bool? n_(Condition @this) {
                        CodeableConcept s_ = @this?.Code;
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                        return !((bool?)(t_ is null));
                    }


                    CqlConcept o_(Condition @this) {
                        CodeableConcept u_ = @this?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        return v_;
                    }

                    IEnumerable<CqlConcept> p_ = context.Operators.WhereSelect<Condition, CqlConcept>(m_, n_, o_);
                    CqlValueSet q_ = this._37_to_42_Plus_Weeks_Gestation(context);
                    CqlBoolean r_ = context.Operators.ConceptsInValueSet(p_, q_);
                    return r_;
                }

                return j_
                    /* CQL 'or' (56:11-58:7) */ || k_();
            }

            return (CqlBoolean)(d_ is null)
                /* CQL 'and' (54:11-55:21) */ && ((PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter)) is null)
                /* CQL 'and' (54:5-58:7) */ && e_();
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Delivery_of_Singleton(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);

            CqlBoolean i_() {
                IEnumerable<Condition> k_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

                bool? l_(Condition @this) {
                    CodeableConcept q_ = @this?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return !((bool?)(r_ is null));
                }


                CqlConcept m_(Condition @this) {
                    CodeableConcept s_ = @this?.Code;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    return t_;
                }

                IEnumerable<CqlConcept> n_ = context.Operators.WhereSelect<Condition, CqlConcept>(k_, l_, m_);
                CqlValueSet o_ = this.Delivery_of_Singleton(context);
                CqlBoolean p_ = context.Operators.ConceptsInValueSet(n_, o_);
                return p_;
            }

            return h_
                /* CQL 'or' (124:5-125:81) */ || i_();
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

            CqlBoolean m_() {
                Code<ObservationStatus> o_ = Gravida?.StatusElement;
                ObservationStatus? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                string[] r_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                return s_;
            }


            CqlBoolean n_() {
                object t_;
                DataType aa_ = Gravida?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                bool ac_ = ab_ is CqlDateTime;
                if (ac_)
                {
                    t_ = ab_ as CqlDateTime;
                }
                else
                {
                    if (ac_)
                    {
                        t_ = ab_ as CqlDateTime;
                    }
                    else
                    {
                        bool ad_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            t_ = ab_ as CqlInterval<CqlDateTime>;
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
                CqlBoolean z_ = context.Operators.In<CqlDateTime>(u_, y_, (string)default);
                return z_
                    /* CQL 'and' (131:13-131:98) */ && !((bool?)((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is null));
            }

            return (CqlBoolean)(!((bool?)(l_ is null)))
                /* CQL 'and' (129:13-130:65) */ && m_()
                /* CQL 'and' (129:7-131:98) */ && n_();
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
            CqlBoolean q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);

            CqlBoolean r_() {
                Code<ObservationStatus> x_ = Parity?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return ab_;
            }


            CqlBoolean s_() {
                DataType ac_ = Parity?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return !((bool?)(ad_ is null));
            }

            return q_
                /* CQL 'and' (153:13-153:97) */ && !((bool?)((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is null))
                /* CQL 'and' (153:13-154:64) */ && r_()
                /* CQL 'and' (153:7-155:36) */ && s_();
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
            CqlBoolean q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);

            CqlBoolean r_() {
                Code<ObservationStatus> x_ = PretermBirth?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return ab_;
            }


            CqlBoolean s_() {
                DataType ac_ = PretermBirth?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return !((bool?)(ad_ is null));
            }

            return q_
                /* CQL 'and' (137:13-137:103) */ && !((bool?)((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is null))
                /* CQL 'and' (137:13-138:70) */ && r_()
                /* CQL 'and' (137:7-139:42) */ && s_();
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
            CqlBoolean q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);

            CqlBoolean r_() {
                Code<ObservationStatus> x_ = TermBirth?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                return ab_;
            }


            CqlBoolean s_() {
                DataType ac_ = TermBirth?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return !((bool?)(ad_ is null));
            }

            return q_
                /* CQL 'and' (145:13-145:100) */ && !((bool?)((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is null))
                /* CQL 'and' (145:13-146:67) */ && r_()
                /* CQL 'and' (145:7-147:39) */ && s_();
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
            CqlBoolean g_ = context.Operators.Equal(f_, 1);

            CqlBoolean h_() {
                int? j_ = this.lastParity(context, SingletonEncounterGE37Weeks);
                CqlBoolean k_ = context.Operators.Equal(j_, 0);
                return k_;
            }


            CqlBoolean i_() {
                int? l_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
                CqlBoolean m_ = context.Operators.Equal(l_, 0);

                CqlBoolean n_() {
                    int? o_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
                    CqlBoolean p_ = context.Operators.Equal(o_, 0);
                    return p_;
                }

                return m_
                    /* CQL 'and' (106:12-108:9) */ && n_();
            }

            return g_
                /* CQL 'or' (104:13-105:61) */ || h_()
                /* CQL 'or' (104:5-109:5) */ || i_();
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
            CqlValueSet j_ = this.Abnormal_Presentation(context);
            IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? l_(Observation AbnormalPresentation) {
                object t_;
                DataType y_ = AbnormalPresentation?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    t_ = z_ as CqlDateTime;
                }
                else
                {
                    if (aa_)
                    {
                        t_ = z_ as CqlDateTime;
                    }
                    else
                    {
                        bool ab_ = z_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            t_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
                CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
                CqlDateTime v_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                CqlBoolean w_ = context.Operators.SameOrBefore(u_, v_, (string)default);

                CqlBoolean x_() {
                    Code<ObservationStatus> ac_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    return ag_;
                }

                return w_
                    /* CQL 'and' (114:9-115:80) */ && x_();
            }

            IEnumerable<Observation> m_ = context.Operators.Where<Observation>(k_, l_);

            object n_(Observation @this) {
                object ah_;
                DataType aj_ = @this?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool al_ = ak_ is CqlDateTime;
                if (al_)
                {
                    ah_ = ak_ as CqlDateTime;
                }
                else
                {
                    if (al_)
                    {
                        ah_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        bool am_ = ak_ is CqlInterval<CqlDateTime>;
                        if (am_)
                        {
                            ah_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ah_ = null;
                        }
                    }
                }
                CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.earliest(context, ah_);
                return ai_;
            }

            IEnumerable<Observation> o_ = context.Operators.SortBy<Observation>(m_, n_, System.ComponentModel.ListSortDirection.Ascending);
            Observation p_ = context.Operators.Last<Observation>(o_);
            DataType q_ = p_?.Effective;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            bool s_ = r_ is CqlDateTime;
            if (s_)
            {

                bool? an_(Observation AbnormalPresentation) {
                    object au_;
                    DataType az_ = AbnormalPresentation?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlDateTime;
                    if (bb_)
                    {
                        au_ = ba_ as CqlDateTime;
                    }
                    else
                    {
                        if (bb_)
                        {
                            au_ = ba_ as CqlDateTime;
                        }
                        else
                        {
                            bool bc_ = ba_ is CqlInterval<CqlDateTime>;
                            if (bc_)
                            {
                                au_ = ba_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                au_ = null;
                            }
                        }
                    }
                    CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
                    CqlDateTime aw_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    CqlBoolean ax_ = context.Operators.SameOrBefore(av_, aw_, (string)default);

                    CqlBoolean ay_() {
                        Code<ObservationStatus> bd_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? be_ = bd_?.Value;
                        string bf_ = context.Operators.Convert<string>(be_);
                        string[] bg_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean bh_ = context.Operators.In<string>(bf_, (IEnumerable<string>)bg_);
                        return bh_;
                    }

                    return ax_
                        /* CQL 'and' (114:9-115:80) */ && ay_();
                }

                IEnumerable<Observation> ao_ = context.Operators.Where<Observation>(k_, an_);

                object ap_(Observation @this) {
                    object bi_;
                    DataType bk_ = @this?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlDateTime;
                    if (bm_)
                    {
                        bi_ = bl_ as CqlDateTime;
                    }
                    else
                    {
                        if (bm_)
                        {
                            bi_ = bl_ as CqlDateTime;
                        }
                        else
                        {
                            bool bn_ = bl_ is CqlInterval<CqlDateTime>;
                            if (bn_)
                            {
                                bi_ = bl_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bi_ = null;
                            }
                        }
                    }
                    CqlDateTime bj_ = QICoreCommon_4_0_000.Instance.earliest(context, bi_);
                    return bj_;
                }

                IEnumerable<Observation> aq_ = context.Operators.SortBy<Observation>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ar_ = context.Operators.Last<Observation>(aq_);
                DataType as_ = ar_?.Effective;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                d_ = at_ as CqlDateTime;
            }
            else
            {

                bool? bo_(Observation AbnormalPresentation) {
                    object bw_;
                    DataType cb_ = AbnormalPresentation?.Effective;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    bool cd_ = cc_ is CqlDateTime;
                    if (cd_)
                    {
                        bw_ = cc_ as CqlDateTime;
                    }
                    else
                    {
                        if (cd_)
                        {
                            bw_ = cc_ as CqlDateTime;
                        }
                        else
                        {
                            bool ce_ = cc_ is CqlInterval<CqlDateTime>;
                            if (ce_)
                            {
                                bw_ = cc_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bw_ = null;
                            }
                        }
                    }
                    CqlDateTime bx_ = QICoreCommon_4_0_000.Instance.earliest(context, bw_);
                    CqlDateTime by_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    CqlBoolean bz_ = context.Operators.SameOrBefore(bx_, by_, (string)default);

                    CqlBoolean ca_() {
                        Code<ObservationStatus> cf_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? cg_ = cf_?.Value;
                        string ch_ = context.Operators.Convert<string>(cg_);
                        string[] ci_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean cj_ = context.Operators.In<string>(ch_, (IEnumerable<string>)ci_);
                        return cj_;
                    }

                    return bz_
                        /* CQL 'and' (114:9-115:80) */ && ca_();
                }

                IEnumerable<Observation> bp_ = context.Operators.Where<Observation>(k_, bo_);

                object bq_(Observation @this) {
                    object ck_;
                    DataType cm_ = @this?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlDateTime;
                    if (co_)
                    {
                        ck_ = cn_ as CqlDateTime;
                    }
                    else
                    {
                        if (co_)
                        {
                            ck_ = cn_ as CqlDateTime;
                        }
                        else
                        {
                            bool cp_ = cn_ is CqlInterval<CqlDateTime>;
                            if (cp_)
                            {
                                ck_ = cn_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                ck_ = null;
                            }
                        }
                    }
                    CqlDateTime cl_ = QICoreCommon_4_0_000.Instance.earliest(context, ck_);
                    return cl_;
                }

                IEnumerable<Observation> br_ = context.Operators.SortBy<Observation>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
                Observation bs_ = context.Operators.Last<Observation>(br_);
                DataType bt_ = bs_?.Effective;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                bool bv_ = bu_ is CqlDateTime;
                if (bv_)
                {

                    bool? cq_(Observation AbnormalPresentation) {
                        object cx_;
                        DataType dc_ = AbnormalPresentation?.Effective;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlDateTime;
                        if (de_)
                        {
                            cx_ = dd_ as CqlDateTime;
                        }
                        else
                        {
                            if (de_)
                            {
                                cx_ = dd_ as CqlDateTime;
                            }
                            else
                            {
                                bool df_ = dd_ is CqlInterval<CqlDateTime>;
                                if (df_)
                                {
                                    cx_ = dd_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    cx_ = null;
                                }
                            }
                        }
                        CqlDateTime cy_ = QICoreCommon_4_0_000.Instance.earliest(context, cx_);
                        CqlDateTime cz_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        CqlBoolean da_ = context.Operators.SameOrBefore(cy_, cz_, (string)default);

                        CqlBoolean db_() {
                            Code<ObservationStatus> dg_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? dh_ = dg_?.Value;
                            string di_ = context.Operators.Convert<string>(dh_);
                            string[] dj_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            CqlBoolean dk_ = context.Operators.In<string>(di_, (IEnumerable<string>)dj_);
                            return dk_;
                        }

                        return da_
                            /* CQL 'and' (114:9-115:80) */ && db_();
                    }

                    IEnumerable<Observation> cr_ = context.Operators.Where<Observation>(k_, cq_);

                    object cs_(Observation @this) {
                        object dl_;
                        DataType dn_ = @this?.Effective;
                        object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                        bool dp_ = do_ is CqlDateTime;
                        if (dp_)
                        {
                            dl_ = do_ as CqlDateTime;
                        }
                        else
                        {
                            if (dp_)
                            {
                                dl_ = do_ as CqlDateTime;
                            }
                            else
                            {
                                bool dq_ = do_ is CqlInterval<CqlDateTime>;
                                if (dq_)
                                {
                                    dl_ = do_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    dl_ = null;
                                }
                            }
                        }
                        CqlDateTime dm_ = QICoreCommon_4_0_000.Instance.earliest(context, dl_);
                        return dm_;
                    }

                    IEnumerable<Observation> ct_ = context.Operators.SortBy<Observation>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation cu_ = context.Operators.Last<Observation>(ct_);
                    DataType cv_ = cu_?.Effective;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    d_ = cw_ as CqlDateTime;
                }
                else
                {

                    bool? dr_(Observation AbnormalPresentation) {
                        object dz_;
                        DataType ee_ = AbnormalPresentation?.Effective;
                        object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                        bool eg_ = ef_ is CqlDateTime;
                        if (eg_)
                        {
                            dz_ = ef_ as CqlDateTime;
                        }
                        else
                        {
                            if (eg_)
                            {
                                dz_ = ef_ as CqlDateTime;
                            }
                            else
                            {
                                bool eh_ = ef_ is CqlInterval<CqlDateTime>;
                                if (eh_)
                                {
                                    dz_ = ef_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    dz_ = null;
                                }
                            }
                        }
                        CqlDateTime ea_ = QICoreCommon_4_0_000.Instance.earliest(context, dz_);
                        CqlDateTime eb_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        CqlBoolean ec_ = context.Operators.SameOrBefore(ea_, eb_, (string)default);

                        CqlBoolean ed_() {
                            Code<ObservationStatus> ei_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? ej_ = ei_?.Value;
                            string ek_ = context.Operators.Convert<string>(ej_);
                            string[] el_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            CqlBoolean em_ = context.Operators.In<string>(ek_, (IEnumerable<string>)el_);
                            return em_;
                        }

                        return ec_
                            /* CQL 'and' (114:9-115:80) */ && ed_();
                    }

                    IEnumerable<Observation> ds_ = context.Operators.Where<Observation>(k_, dr_);

                    object dt_(Observation @this) {
                        object en_;
                        DataType ep_ = @this?.Effective;
                        object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        bool er_ = eq_ is CqlDateTime;
                        if (er_)
                        {
                            en_ = eq_ as CqlDateTime;
                        }
                        else
                        {
                            if (er_)
                            {
                                en_ = eq_ as CqlDateTime;
                            }
                            else
                            {
                                bool es_ = eq_ is CqlInterval<CqlDateTime>;
                                if (es_)
                                {
                                    en_ = eq_ as CqlInterval<CqlDateTime>;
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

                    IEnumerable<Observation> du_ = context.Operators.SortBy<Observation>(ds_, dt_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation dv_ = context.Operators.Last<Observation>(du_);
                    DataType dw_ = dv_?.Effective;
                    object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                    bool dy_ = dx_ is CqlInterval<CqlDateTime>;
                    if (dy_)
                    {

                        bool? et_(Observation AbnormalPresentation) {
                            object fa_;
                            DataType ff_ = AbnormalPresentation?.Effective;
                            object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                            bool fh_ = fg_ is CqlDateTime;
                            if (fh_)
                            {
                                fa_ = fg_ as CqlDateTime;
                            }
                            else
                            {
                                if (fh_)
                                {
                                    fa_ = fg_ as CqlDateTime;
                                }
                                else
                                {
                                    bool fi_ = fg_ is CqlInterval<CqlDateTime>;
                                    if (fi_)
                                    {
                                        fa_ = fg_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        fa_ = null;
                                    }
                                }
                            }
                            CqlDateTime fb_ = QICoreCommon_4_0_000.Instance.earliest(context, fa_);
                            CqlDateTime fc_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                            CqlBoolean fd_ = context.Operators.SameOrBefore(fb_, fc_, (string)default);

                            CqlBoolean fe_() {
                                Code<ObservationStatus> fj_ = AbnormalPresentation?.StatusElement;
                                ObservationStatus? fk_ = fj_?.Value;
                                string fl_ = context.Operators.Convert<string>(fk_);
                                string[] fm_ = [
                                    "final",
                                    "amended",
                                    "corrected",
                                ];
                                CqlBoolean fn_ = context.Operators.In<string>(fl_, (IEnumerable<string>)fm_);
                                return fn_;
                            }

                            return fd_
                                /* CQL 'and' (114:9-115:80) */ && fe_();
                        }

                        IEnumerable<Observation> eu_ = context.Operators.Where<Observation>(k_, et_);

                        object ev_(Observation @this) {
                            object fo_;
                            DataType fq_ = @this?.Effective;
                            object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                            bool fs_ = fr_ is CqlDateTime;
                            if (fs_)
                            {
                                fo_ = fr_ as CqlDateTime;
                            }
                            else
                            {
                                if (fs_)
                                {
                                    fo_ = fr_ as CqlDateTime;
                                }
                                else
                                {
                                    bool ft_ = fr_ is CqlInterval<CqlDateTime>;
                                    if (ft_)
                                    {
                                        fo_ = fr_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        fo_ = null;
                                    }
                                }
                            }
                            CqlDateTime fp_ = QICoreCommon_4_0_000.Instance.earliest(context, fo_);
                            return fp_;
                        }

                        IEnumerable<Observation> ew_ = context.Operators.SortBy<Observation>(eu_, ev_, System.ComponentModel.ListSortDirection.Ascending);
                        Observation ex_ = context.Operators.Last<Observation>(ew_);
                        DataType ey_ = ex_?.Effective;
                        object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                        d_ = ez_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        d_ = null;
                    }
                }
            }
            CqlDateTime e_ = QICoreCommon_4_0_000.Instance.earliest(context, d_);
            CqlInterval<CqlDateTime> f_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
            CqlBoolean g_ = context.Operators.In<CqlDateTime>(e_, f_, (string)default);

            CqlBoolean h_() {
                IEnumerable<Condition> fu_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

                bool? fv_(Condition @this) {
                    CodeableConcept ga_ = @this?.Code;
                    CqlConcept gb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ga_);
                    return !((bool?)(gb_ is null));
                }


                CqlConcept fw_(Condition @this) {
                    CodeableConcept gc_ = @this?.Code;
                    CqlConcept gd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gc_);
                    return gd_;
                }

                IEnumerable<CqlConcept> fx_ = context.Operators.WhereSelect<Condition, CqlConcept>(fu_, fv_, fw_);
                CqlValueSet fy_ = this.Abnormal_Presentation(context);
                CqlBoolean fz_ = context.Operators.ConceptsInValueSet(fx_, fy_);
                return fz_;
            }


            CqlBoolean i_() {
                List<CodeableConcept> ge_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

                CqlConcept gf_(CodeableConcept @this) {
                    CqlConcept gj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return gj_;
                }

                IEnumerable<CqlConcept> gg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ge_, gf_);
                CqlValueSet gh_ = this.Abnormal_Presentation(context);
                CqlBoolean gi_ = context.Operators.ConceptsInValueSet(gg_, gh_);
                return gi_;
            }

            return g_
                /* CQL 'or' (118:11-119:93) */ || h_()
                /* CQL 'or' (118:5-120:76) */ || i_();
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
                CodeableConcept m_ = @this?.Code;
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, m_);
                return !((bool?)(n_ is null));
            }


            CqlConcept f_(Condition @this) {
                CodeableConcept o_ = @this?.Code;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                return p_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.WhereSelect<Condition, CqlConcept>(d_, e_, f_);
            CqlValueSet h_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
            CqlBoolean i_ = context.Operators.ConceptsInValueSet(g_, h_);

            CqlBoolean j_() {
                IEnumerable<Condition> q_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

                bool? r_(Condition @this) {
                    CodeableConcept w_ = @this?.Code;
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                    return !((bool?)(x_ is null));
                }


                CqlConcept s_(Condition @this) {
                    CodeableConcept y_ = @this?.Code;
                    CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                    return z_;
                }

                IEnumerable<CqlConcept> t_ = context.Operators.WhereSelect<Condition, CqlConcept>(q_, r_, s_);
                CqlValueSet u_ = this.Genital_Herpes(context);
                CqlBoolean v_ = context.Operators.ConceptsInValueSet(t_, u_);
                return v_;
            }


            CqlBoolean k_() {
                List<CodeableConcept> aa_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

                CqlConcept ab_(CodeableConcept @this) {
                    CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return af_;
                }

                IEnumerable<CqlConcept> ac_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aa_, ab_);
                CqlValueSet ad_ = this.Genital_Herpes(context);
                CqlBoolean ae_ = context.Operators.ConceptsInValueSet(ac_, ad_);
                return ae_;
            }


            CqlBoolean l_() {
                List<CodeableConcept> ag_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

                CqlConcept ah_(CodeableConcept @this) {
                    CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return al_;
                }

                IEnumerable<CqlConcept> ai_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ag_, ah_);
                CqlValueSet aj_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
                CqlBoolean ak_ = context.Operators.ConceptsInValueSet(ai_, aj_);
                return ak_;
            }

            return i_
                /* CQL 'or' (95:13-96:88) */ || j_()
                /* CQL 'or' (95:13-97:71) */ || k_()
                /* CQL 'or' (95:5-99:5) */ || l_();
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
                DataType m_ = CSection?.Performed;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                bool o_ = n_ is CqlDateTime;
                if (o_)
                {
                    i_ = n_ as CqlDateTime;
                }
                else
                {
                    bool p_ = n_ is CqlQuantity;
                    if (p_)
                    {
                        i_ = n_ as CqlQuantity;
                    }
                    else
                    {
                        bool q_ = n_ is CqlInterval<CqlDateTime>;
                        if (q_)
                        {
                            i_ = n_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool r_ = n_ is CqlInterval<CqlQuantity>;
                            if (r_)
                            {
                                i_ = n_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                CqlBoolean k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, (string)default);

                CqlBoolean l_() {
                    Code<EventStatus> s_ = CSection?.StatusElement;
                    EventStatus? t_ = s_?.Value;
                    string u_ = context.Operators.Convert<string>(t_);
                    CqlBoolean v_ = context.Operators.Equal(u_, "completed");
                    return v_;
                }

                return k_
                    /* CQL 'and' (90:17-91:41) */ && l_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
