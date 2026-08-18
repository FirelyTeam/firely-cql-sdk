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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
            CqlQuantity e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity f_ = context.Operators.Quantity(37m, "weeks");
            CqlBoolean g_ = context.Operators.GreaterOrEqual(e_, f_);
            CqlBoolean h_ = g_;
            return (CqlBoolean)(d_ is null)
                /* CQL 'and' (42:5-43:71) */ && h_;
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
            List<CodeableConcept> e_ = DeliveryEncounter?.ReasonCode;

            CqlConcept f_(CodeableConcept @this) {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)e_, f_);
            CqlValueSet h_ = this._37_to_42_Plus_Weeks_Gestation(context);
            CqlBoolean i_ = context.Operators.ConceptsInValueSet(g_, h_);
            IEnumerable<Condition> j_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? k_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                return s_ is not null;
            }


            CqlConcept l_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
            CqlBoolean n_ = context.Operators.ConceptsInValueSet(m_, h_);
            CqlBoolean o_ = n_;
            CqlBoolean p_ = i_
                /* CQL 'or' (56:11-58:7) */ || o_;
            return (CqlBoolean)(d_ is null)
                /* CQL 'and' (54:11-55:21) */ && ((PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter)) is null)
                /* CQL 'and' (54:5-58:7) */ && p_;
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Delivery_of_Singleton(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? j_(Condition @this) {
                CodeableConcept p_ = @this?.Code;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                return q_ is not null;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept r_ = @this?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                return s_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(i_, j_, k_);
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(l_, g_);
            CqlBoolean n_ = m_;
            return h_
                /* CQL 'or' (124:5-125:81) */ || n_;
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
            Code<ObservationStatus> m_ = Gravida?.StatusElement;
            ObservationStatus? n_ = m_?.Value;
            string o_ = context.Operators.Convert<string>(n_);
            string[] p_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
            CqlBoolean r_ = q_;
            object s_;
            DataType aa_ = Gravida?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                s_ = ab_ as CqlDateTime;
            }
            else
            {
                if (ac_)
                {
                    s_ = ab_ as CqlDateTime;
                }
                else
                {
                    bool ad_ = ab_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        s_ = ab_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        s_ = null;
                    }
                }
            }
            CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
            CqlDateTime u_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity v_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime w_ = context.Operators.Subtract(u_, v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, u_, true, false);
            CqlBoolean y_ = context.Operators.In<CqlDateTime>(t_, x_, (string)default);
            CqlBoolean z_ = y_
                /* CQL 'and' (131:13-131:98) */ && ((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is not null);
            return (CqlBoolean)(l_ is not null)
                /* CQL 'and' (129:13-130:65) */ && r_
                /* CQL 'and' (129:7-131:98) */ && z_;
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
            DataType aa_ = Parity?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                k_ = ab_ as CqlDateTime;
            }
            else
            {
                if (ac_)
                {
                    k_ = ab_ as CqlDateTime;
                }
                else
                {
                    bool ad_ = ab_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        k_ = ab_ as CqlInterval<CqlDateTime>;
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
            Code<ObservationStatus> r_ = Parity?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            CqlBoolean w_ = v_;
            DataType x_ = Parity?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlBoolean z_ = (CqlBoolean)(y_ is not null);
            return q_
                /* CQL 'and' (153:13-153:97) */ && ((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is not null)
                /* CQL 'and' (153:13-154:64) */ && w_
                /* CQL 'and' (153:7-155:36) */ && z_;
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
            DataType aa_ = PretermBirth?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                k_ = ab_ as CqlDateTime;
            }
            else
            {
                if (ac_)
                {
                    k_ = ab_ as CqlDateTime;
                }
                else
                {
                    bool ad_ = ab_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        k_ = ab_ as CqlInterval<CqlDateTime>;
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
            Code<ObservationStatus> r_ = PretermBirth?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            CqlBoolean w_ = v_;
            DataType x_ = PretermBirth?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlBoolean z_ = (CqlBoolean)(y_ is not null);
            return q_
                /* CQL 'and' (137:13-137:103) */ && ((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is not null)
                /* CQL 'and' (137:13-138:70) */ && w_
                /* CQL 'and' (137:7-139:42) */ && z_;
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
            DataType aa_ = TermBirth?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                k_ = ab_ as CqlDateTime;
            }
            else
            {
                if (ac_)
                {
                    k_ = ab_ as CqlDateTime;
                }
                else
                {
                    bool ad_ = ab_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        k_ = ab_ as CqlInterval<CqlDateTime>;
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
            Code<ObservationStatus> r_ = TermBirth?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            CqlBoolean w_ = v_;
            DataType x_ = TermBirth?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlBoolean z_ = (CqlBoolean)(y_ is not null);
            return q_
                /* CQL 'and' (145:13-145:100) */ && ((PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter)) is not null)
                /* CQL 'and' (145:13-146:67) */ && w_
                /* CQL 'and' (145:7-147:39) */ && z_;
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
            int? h_ = this.lastParity(context, SingletonEncounterGE37Weeks);
            CqlBoolean i_ = context.Operators.Equal(h_, 0);
            CqlBoolean j_ = i_;
            int? k_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
            CqlBoolean l_ = context.Operators.Equal(k_, 0);
            int? m_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
            CqlBoolean n_ = context.Operators.Equal(m_, 0);
            CqlBoolean o_ = n_;
            CqlBoolean p_ = l_
                /* CQL 'and' (106:12-108:9) */ && o_;
            return g_
                /* CQL 'or' (104:13-105:61) */ || j_
                /* CQL 'or' (104:5-109:5) */ || p_;
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
            CqlValueSet t_ = this.Abnormal_Presentation(context);
            IEnumerable<Observation> u_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? v_(Observation AbnormalPresentation) {
                object ad_;
                DataType an_ = AbnormalPresentation?.Effective;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlDateTime;
                if (ap_)
                {
                    ad_ = ao_ as CqlDateTime;
                }
                else
                {
                    if (ap_)
                    {
                        ad_ = ao_ as CqlDateTime;
                    }
                    else
                    {
                        bool aq_ = ao_ is CqlInterval<CqlDateTime>;
                        if (aq_)
                        {
                            ad_ = ao_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ad_ = null;
                        }
                    }
                }
                CqlDateTime ae_ = QICoreCommon_4_0_000.Instance.earliest(context, ad_);
                CqlDateTime af_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                CqlBoolean ag_ = context.Operators.SameOrBefore(ae_, af_, (string)default);
                Code<ObservationStatus> ah_ = AbnormalPresentation?.StatusElement;
                ObservationStatus? ai_ = ah_?.Value;
                string aj_ = context.Operators.Convert<string>(ai_);
                string[] ak_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                CqlBoolean am_ = al_;
                return ag_
                    /* CQL 'and' (114:9-115:80) */ && am_;
            }

            IEnumerable<Observation> w_ = context.Operators.Where<Observation>(u_, v_);

            object x_(Observation @this) {
                object ar_;
                DataType at_ = @this?.Effective;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlDateTime;
                if (av_)
                {
                    ar_ = au_ as CqlDateTime;
                }
                else
                {
                    if (av_)
                    {
                        ar_ = au_ as CqlDateTime;
                    }
                    else
                    {
                        bool aw_ = au_ is CqlInterval<CqlDateTime>;
                        if (aw_)
                        {
                            ar_ = au_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                return as_;
            }

            IEnumerable<Observation> y_ = context.Operators.SortBy<Observation>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
            Observation z_ = context.Operators.Last<Observation>(y_);
            DataType aa_ = z_?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {

                bool? ax_(Observation AbnormalPresentation) {
                    object be_;
                    DataType bo_ = AbnormalPresentation?.Effective;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlDateTime;
                    if (bq_)
                    {
                        be_ = bp_ as CqlDateTime;
                    }
                    else
                    {
                        if (bq_)
                        {
                            be_ = bp_ as CqlDateTime;
                        }
                        else
                        {
                            bool br_ = bp_ is CqlInterval<CqlDateTime>;
                            if (br_)
                            {
                                be_ = bp_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                be_ = null;
                            }
                        }
                    }
                    CqlDateTime bf_ = QICoreCommon_4_0_000.Instance.earliest(context, be_);
                    CqlDateTime bg_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    CqlBoolean bh_ = context.Operators.SameOrBefore(bf_, bg_, (string)default);
                    Code<ObservationStatus> bi_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? bj_ = bi_?.Value;
                    string bk_ = context.Operators.Convert<string>(bj_);
                    string[] bl_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean bm_ = context.Operators.In<string>(bk_, (IEnumerable<string>)bl_);
                    CqlBoolean bn_ = bm_;
                    return bh_
                        /* CQL 'and' (114:9-115:80) */ && bn_;
                }

                IEnumerable<Observation> ay_ = context.Operators.Where<Observation>(u_, ax_);

                object az_(Observation @this) {
                    object bs_;
                    DataType bu_ = @this?.Effective;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlDateTime;
                    if (bw_)
                    {
                        bs_ = bv_ as CqlDateTime;
                    }
                    else
                    {
                        if (bw_)
                        {
                            bs_ = bv_ as CqlDateTime;
                        }
                        else
                        {
                            bool bx_ = bv_ is CqlInterval<CqlDateTime>;
                            if (bx_)
                            {
                                bs_ = bv_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bs_ = null;
                            }
                        }
                    }
                    CqlDateTime bt_ = QICoreCommon_4_0_000.Instance.earliest(context, bs_);
                    return bt_;
                }

                IEnumerable<Observation> ba_ = context.Operators.SortBy<Observation>(ay_, az_, System.ComponentModel.ListSortDirection.Ascending);
                Observation bb_ = context.Operators.Last<Observation>(ba_);
                DataType bc_ = bb_?.Effective;
                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                d_ = bd_ as CqlDateTime;
            }
            else
            {

                bool? by_(Observation AbnormalPresentation) {
                    object cg_;
                    DataType cq_ = AbnormalPresentation?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlDateTime;
                    if (cs_)
                    {
                        cg_ = cr_ as CqlDateTime;
                    }
                    else
                    {
                        if (cs_)
                        {
                            cg_ = cr_ as CqlDateTime;
                        }
                        else
                        {
                            bool ct_ = cr_ is CqlInterval<CqlDateTime>;
                            if (ct_)
                            {
                                cg_ = cr_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                cg_ = null;
                            }
                        }
                    }
                    CqlDateTime ch_ = QICoreCommon_4_0_000.Instance.earliest(context, cg_);
                    CqlDateTime ci_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    CqlBoolean cj_ = context.Operators.SameOrBefore(ch_, ci_, (string)default);
                    Code<ObservationStatus> ck_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? cl_ = ck_?.Value;
                    string cm_ = context.Operators.Convert<string>(cl_);
                    string[] cn_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean co_ = context.Operators.In<string>(cm_, (IEnumerable<string>)cn_);
                    CqlBoolean cp_ = co_;
                    return cj_
                        /* CQL 'and' (114:9-115:80) */ && cp_;
                }

                IEnumerable<Observation> bz_ = context.Operators.Where<Observation>(u_, by_);

                object ca_(Observation @this) {
                    object cu_;
                    DataType cw_ = @this?.Effective;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    bool cy_ = cx_ is CqlDateTime;
                    if (cy_)
                    {
                        cu_ = cx_ as CqlDateTime;
                    }
                    else
                    {
                        if (cy_)
                        {
                            cu_ = cx_ as CqlDateTime;
                        }
                        else
                        {
                            bool cz_ = cx_ is CqlInterval<CqlDateTime>;
                            if (cz_)
                            {
                                cu_ = cx_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                cu_ = null;
                            }
                        }
                    }
                    CqlDateTime cv_ = QICoreCommon_4_0_000.Instance.earliest(context, cu_);
                    return cv_;
                }

                IEnumerable<Observation> cb_ = context.Operators.SortBy<Observation>(bz_, ca_, System.ComponentModel.ListSortDirection.Ascending);
                Observation cc_ = context.Operators.Last<Observation>(cb_);
                DataType cd_ = cc_?.Effective;
                object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                bool cf_ = ce_ is CqlDateTime;
                if (cf_)
                {

                    bool? da_(Observation AbnormalPresentation) {
                        object dh_;
                        DataType dr_ = AbnormalPresentation?.Effective;
                        object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                        bool dt_ = ds_ is CqlDateTime;
                        if (dt_)
                        {
                            dh_ = ds_ as CqlDateTime;
                        }
                        else
                        {
                            if (dt_)
                            {
                                dh_ = ds_ as CqlDateTime;
                            }
                            else
                            {
                                bool du_ = ds_ is CqlInterval<CqlDateTime>;
                                if (du_)
                                {
                                    dh_ = ds_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    dh_ = null;
                                }
                            }
                        }
                        CqlDateTime di_ = QICoreCommon_4_0_000.Instance.earliest(context, dh_);
                        CqlDateTime dj_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        CqlBoolean dk_ = context.Operators.SameOrBefore(di_, dj_, (string)default);
                        Code<ObservationStatus> dl_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? dm_ = dl_?.Value;
                        string dn_ = context.Operators.Convert<string>(dm_);
                        string[] do_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean dp_ = context.Operators.In<string>(dn_, (IEnumerable<string>)do_);
                        CqlBoolean dq_ = dp_;
                        return dk_
                            /* CQL 'and' (114:9-115:80) */ && dq_;
                    }

                    IEnumerable<Observation> db_ = context.Operators.Where<Observation>(u_, da_);

                    object dc_(Observation @this) {
                        object dv_;
                        DataType dx_ = @this?.Effective;
                        object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                        bool dz_ = dy_ is CqlDateTime;
                        if (dz_)
                        {
                            dv_ = dy_ as CqlDateTime;
                        }
                        else
                        {
                            if (dz_)
                            {
                                dv_ = dy_ as CqlDateTime;
                            }
                            else
                            {
                                bool ea_ = dy_ is CqlInterval<CqlDateTime>;
                                if (ea_)
                                {
                                    dv_ = dy_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    dv_ = null;
                                }
                            }
                        }
                        CqlDateTime dw_ = QICoreCommon_4_0_000.Instance.earliest(context, dv_);
                        return dw_;
                    }

                    IEnumerable<Observation> dd_ = context.Operators.SortBy<Observation>(db_, dc_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation de_ = context.Operators.Last<Observation>(dd_);
                    DataType df_ = de_?.Effective;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    d_ = dg_ as CqlDateTime;
                }
                else
                {

                    bool? eb_(Observation AbnormalPresentation) {
                        object ej_;
                        DataType et_ = AbnormalPresentation?.Effective;
                        object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                        bool ev_ = eu_ is CqlDateTime;
                        if (ev_)
                        {
                            ej_ = eu_ as CqlDateTime;
                        }
                        else
                        {
                            if (ev_)
                            {
                                ej_ = eu_ as CqlDateTime;
                            }
                            else
                            {
                                bool ew_ = eu_ is CqlInterval<CqlDateTime>;
                                if (ew_)
                                {
                                    ej_ = eu_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    ej_ = null;
                                }
                            }
                        }
                        CqlDateTime ek_ = QICoreCommon_4_0_000.Instance.earliest(context, ej_);
                        CqlDateTime el_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        CqlBoolean em_ = context.Operators.SameOrBefore(ek_, el_, (string)default);
                        Code<ObservationStatus> en_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? eo_ = en_?.Value;
                        string ep_ = context.Operators.Convert<string>(eo_);
                        string[] eq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        CqlBoolean er_ = context.Operators.In<string>(ep_, (IEnumerable<string>)eq_);
                        CqlBoolean es_ = er_;
                        return em_
                            /* CQL 'and' (114:9-115:80) */ && es_;
                    }

                    IEnumerable<Observation> ec_ = context.Operators.Where<Observation>(u_, eb_);

                    object ed_(Observation @this) {
                        object ex_;
                        DataType ez_ = @this?.Effective;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        bool fb_ = fa_ is CqlDateTime;
                        if (fb_)
                        {
                            ex_ = fa_ as CqlDateTime;
                        }
                        else
                        {
                            if (fb_)
                            {
                                ex_ = fa_ as CqlDateTime;
                            }
                            else
                            {
                                bool fc_ = fa_ is CqlInterval<CqlDateTime>;
                                if (fc_)
                                {
                                    ex_ = fa_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    ex_ = null;
                                }
                            }
                        }
                        CqlDateTime ey_ = QICoreCommon_4_0_000.Instance.earliest(context, ex_);
                        return ey_;
                    }

                    IEnumerable<Observation> ee_ = context.Operators.SortBy<Observation>(ec_, ed_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ef_ = context.Operators.Last<Observation>(ee_);
                    DataType eg_ = ef_?.Effective;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlInterval<CqlDateTime>;
                    if (ei_)
                    {

                        bool? fd_(Observation AbnormalPresentation) {
                            object fk_;
                            DataType fu_ = AbnormalPresentation?.Effective;
                            object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                            bool fw_ = fv_ is CqlDateTime;
                            if (fw_)
                            {
                                fk_ = fv_ as CqlDateTime;
                            }
                            else
                            {
                                if (fw_)
                                {
                                    fk_ = fv_ as CqlDateTime;
                                }
                                else
                                {
                                    bool fx_ = fv_ is CqlInterval<CqlDateTime>;
                                    if (fx_)
                                    {
                                        fk_ = fv_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        fk_ = null;
                                    }
                                }
                            }
                            CqlDateTime fl_ = QICoreCommon_4_0_000.Instance.earliest(context, fk_);
                            CqlDateTime fm_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                            CqlBoolean fn_ = context.Operators.SameOrBefore(fl_, fm_, (string)default);
                            Code<ObservationStatus> fo_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? fp_ = fo_?.Value;
                            string fq_ = context.Operators.Convert<string>(fp_);
                            string[] fr_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            CqlBoolean fs_ = context.Operators.In<string>(fq_, (IEnumerable<string>)fr_);
                            CqlBoolean ft_ = fs_;
                            return fn_
                                /* CQL 'and' (114:9-115:80) */ && ft_;
                        }

                        IEnumerable<Observation> fe_ = context.Operators.Where<Observation>(u_, fd_);

                        object ff_(Observation @this) {
                            object fy_;
                            DataType ga_ = @this?.Effective;
                            object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                            bool gc_ = gb_ is CqlDateTime;
                            if (gc_)
                            {
                                fy_ = gb_ as CqlDateTime;
                            }
                            else
                            {
                                if (gc_)
                                {
                                    fy_ = gb_ as CqlDateTime;
                                }
                                else
                                {
                                    bool gd_ = gb_ is CqlInterval<CqlDateTime>;
                                    if (gd_)
                                    {
                                        fy_ = gb_ as CqlInterval<CqlDateTime>;
                                    }
                                    else
                                    {
                                        fy_ = null;
                                    }
                                }
                            }
                            CqlDateTime fz_ = QICoreCommon_4_0_000.Instance.earliest(context, fy_);
                            return fz_;
                        }

                        IEnumerable<Observation> fg_ = context.Operators.SortBy<Observation>(fe_, ff_, System.ComponentModel.ListSortDirection.Ascending);
                        Observation fh_ = context.Operators.Last<Observation>(fg_);
                        DataType fi_ = fh_?.Effective;
                        object fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                        d_ = fj_ as CqlInterval<CqlDateTime>;
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
            IEnumerable<Condition> h_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? i_(Condition @this) {
                CodeableConcept ge_ = @this?.Code;
                CqlConcept gf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ge_);
                return gf_ is not null;
            }


            CqlConcept j_(Condition @this) {
                CodeableConcept gg_ = @this?.Code;
                CqlConcept gh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gg_);
                return gh_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.WhereSelect<Condition, CqlConcept>(h_, i_, j_);
            CqlValueSet l_ = this.Abnormal_Presentation(context);
            CqlBoolean m_ = context.Operators.ConceptsInValueSet(k_, l_);
            CqlBoolean n_ = m_;
            List<CodeableConcept> o_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept p_(CodeableConcept @this) {
                CqlConcept gi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return gi_;
            }

            IEnumerable<CqlConcept> q_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)o_, p_);
            CqlBoolean r_ = context.Operators.ConceptsInValueSet(q_, l_);
            CqlBoolean s_ = r_;
            return g_
                /* CQL 'or' (118:11-119:93) */ || n_
                /* CQL 'or' (118:5-120:76) */ || s_;
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
                CodeableConcept y_ = @this?.Code;
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                return z_ is not null;
            }


            CqlConcept f_(Condition @this) {
                CodeableConcept aa_ = @this?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                return ab_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.WhereSelect<Condition, CqlConcept>(d_, e_, f_);
            CqlValueSet h_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
            CqlBoolean i_ = context.Operators.ConceptsInValueSet(g_, h_);

            bool? j_(Condition @this) {
                CodeableConcept ac_ = @this?.Code;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                return ad_ is not null;
            }


            CqlConcept k_(Condition @this) {
                CodeableConcept ae_ = @this?.Code;
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                return af_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.WhereSelect<Condition, CqlConcept>(d_, j_, k_);
            CqlValueSet m_ = this.Genital_Herpes(context);
            CqlBoolean n_ = context.Operators.ConceptsInValueSet(l_, m_);
            CqlBoolean o_ = n_;
            List<CodeableConcept> p_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept q_(CodeableConcept @this) {
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ag_;
            }

            IEnumerable<CqlConcept> r_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_);
            CqlBoolean s_ = context.Operators.ConceptsInValueSet(r_, m_);
            CqlBoolean t_ = s_;

            CqlConcept u_(CodeableConcept @this) {
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ah_;
            }

            IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, u_);
            CqlBoolean w_ = context.Operators.ConceptsInValueSet(v_, h_);
            CqlBoolean x_ = w_;
            return i_
                /* CQL 'or' (95:13-96:88) */ || o_
                /* CQL 'or' (95:13-97:71) */ || t_
                /* CQL 'or' (95:5-99:5) */ || x_;
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
                DataType q_ = CSection?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    i_ = r_ as CqlDateTime;
                }
                else
                {
                    bool t_ = r_ is CqlQuantity;
                    if (t_)
                    {
                        i_ = r_ as CqlQuantity;
                    }
                    else
                    {
                        bool u_ = r_ is CqlInterval<CqlDateTime>;
                        if (u_)
                        {
                            i_ = r_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool v_ = r_ is CqlInterval<CqlQuantity>;
                            if (v_)
                            {
                                i_ = r_ as CqlInterval<CqlQuantity>;
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
                Code<EventStatus> l_ = CSection?.StatusElement;
                EventStatus? m_ = l_?.Value;
                string n_ = context.Operators.Convert<string>(m_);
                CqlBoolean o_ = context.Operators.Equal(n_, "completed");
                CqlBoolean p_ = o_;
                return k_
                    /* CQL 'and' (90:17-91:41) */ && p_;
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
