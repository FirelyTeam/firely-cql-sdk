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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
            CqlQuantity e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity f_ = context.Operators.Quantity(37m, "weeks");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            bool? h_ = context.Operators.And((bool?)(d_ is null), g_);
            return h_;
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
            CqlQuantity e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
            List<CodeableConcept> g_ = DeliveryEncounter?.ReasonCode;

            CqlConcept h_(CodeableConcept @this) {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet j_ = this._37_to_42_Plus_Weeks_Gestation(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            IEnumerable<Condition> l_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? m_(Condition @this) {
                CodeableConcept u_ = @this?.Code;
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                bool? w_ = context.Operators.Not((bool?)(v_ is null));
                return w_;
            }

            IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);

            CqlConcept o_(Condition @this) {
                CodeableConcept x_ = @this?.Code;
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                return y_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<Condition, CqlConcept>(n_, o_);
            bool? q_ = context.Operators.ConceptsInValueSet(p_, j_);
            bool? r_ = context.Operators.Or(k_, q_);
            bool? s_ = context.Operators.And(f_, r_);
            return s_;
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Delivery_of_Singleton(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            return o_;
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
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            Code<ObservationStatus> n_ = Gravida?.StatusElement;
            ObservationStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            bool? s_ = context.Operators.And(m_, r_);

            object t_() {

                bool ad_() {
                    DataType ag_ = Gravida?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = Gravida?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool af_() {
                    DataType am_ = Gravida?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = Gravida?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlDateTime;
                }
                else if (ae_())
                {
                    DataType ar_ = Gravida?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_ as CqlDateTime;
                }
                else if (af_())
                {
                    DataType at_ = Gravida?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
            CqlDateTime v_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity w_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime x_ = context.Operators.Subtract(v_, w_);
            CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, v_, true, false);
            bool? z_ = context.Operators.In<CqlDateTime>(u_, y_, (string)default);
            bool? aa_ = context.Operators.Not((bool?)(v_ is null));
            bool? ab_ = context.Operators.And(z_, aa_);
            bool? ac_ = context.Operators.And(s_, ab_);
            return ac_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object av_() {

                bool ax_() {
                    DataType ba_ = @this?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlDateTime;
                    return bc_;
                }


                bool ay_() {
                    DataType bd_ = @this?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool az_() {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                    return bi_;
                }

                if (ax_())
                {
                    DataType bj_ = @this?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bk_ as CqlDateTime;
                }
                else if (ay_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return bm_ as CqlDateTime;
                }
                else if (az_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            return aw_;
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

            object k_() {

                bool ad_() {
                    DataType ag_ = Parity?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = Parity?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool af_() {
                    DataType am_ = Parity?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = Parity?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlDateTime;
                }
                else if (ae_())
                {
                    DataType ar_ = Parity?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_ as CqlDateTime;
                }
                else if (af_())
                {
                    DataType at_ = Parity?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            Code<ObservationStatus> t_ = Parity?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            string[] w_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType z_ = Parity?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(y_, ab_);
            return ac_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object av_() {

                bool ax_() {
                    DataType ba_ = @this?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlDateTime;
                    return bc_;
                }


                bool ay_() {
                    DataType bd_ = @this?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool az_() {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                    return bi_;
                }

                if (ax_())
                {
                    DataType bj_ = @this?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bk_ as CqlDateTime;
                }
                else if (ay_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return bm_ as CqlDateTime;
                }
                else if (az_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            return aw_;
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

            object k_() {

                bool ad_() {
                    DataType ag_ = PretermBirth?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = PretermBirth?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool af_() {
                    DataType am_ = PretermBirth?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = PretermBirth?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlDateTime;
                }
                else if (ae_())
                {
                    DataType ar_ = PretermBirth?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_ as CqlDateTime;
                }
                else if (af_())
                {
                    DataType at_ = PretermBirth?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            Code<ObservationStatus> t_ = PretermBirth?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            string[] w_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType z_ = PretermBirth?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(y_, ab_);
            return ac_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object av_() {

                bool ax_() {
                    DataType ba_ = @this?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlDateTime;
                    return bc_;
                }


                bool ay_() {
                    DataType bd_ = @this?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool az_() {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                    return bi_;
                }

                if (ax_())
                {
                    DataType bj_ = @this?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bk_ as CqlDateTime;
                }
                else if (ay_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return bm_ as CqlDateTime;
                }
                else if (az_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            return aw_;
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

            object k_() {

                bool ad_() {
                    DataType ag_ = TermBirth?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = TermBirth?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool af_() {
                    DataType am_ = TermBirth?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = TermBirth?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlDateTime;
                }
                else if (ae_())
                {
                    DataType ar_ = TermBirth?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_ as CqlDateTime;
                }
                else if (af_())
                {
                    DataType at_ = TermBirth?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime>(l_, p_, (string)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            Code<ObservationStatus> t_ = TermBirth?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            string[] w_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType z_ = TermBirth?.Value;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(y_, ab_);
            return ac_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object av_() {

                bool ax_() {
                    DataType ba_ = @this?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlDateTime;
                    return bc_;
                }


                bool ay_() {
                    DataType bd_ = @this?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlDateTime;
                    return bf_;
                }


                bool az_() {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                    return bi_;
                }

                if (ax_())
                {
                    DataType bj_ = @this?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bk_ as CqlDateTime;
                }
                else if (ay_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return bm_ as CqlDateTime;
                }
                else if (az_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return bo_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            return aw_;
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
            int? h_ = this.lastParity(context, SingletonEncounterGE37Weeks);
            bool? i_ = context.Operators.Equal(h_, 0);
            bool? j_ = context.Operators.Or(g_, i_);
            int? k_ = this.lastHistoryPretermBirth(context, SingletonEncounterGE37Weeks);
            bool? l_ = context.Operators.Equal(k_, 0);
            int? m_ = this.lastHistoryTermBirth(context, SingletonEncounterGE37Weeks);
            bool? n_ = context.Operators.Equal(m_, 0);
            bool? o_ = context.Operators.And(l_, n_);
            bool? p_ = context.Operators.Or(j_, o_);
            return p_;
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

            object d_() {

                bool u_() {
                    CqlValueSet x_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> y_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? z_(Observation AbnormalPresentation) {

                        object ah_() {

                            bool ar_() {
                                DataType au_ = AbnormalPresentation?.Effective;
                                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                bool aw_ = av_ is CqlDateTime;
                                return aw_;
                            }


                            bool as_() {
                                DataType ax_ = AbnormalPresentation?.Effective;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                bool az_ = ay_ is CqlDateTime;
                                return az_;
                            }


                            bool at_() {
                                DataType ba_ = AbnormalPresentation?.Effective;
                                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                                bool bc_ = bb_ is CqlInterval<CqlDateTime>;
                                return bc_;
                            }

                            if (ar_())
                            {
                                DataType bd_ = AbnormalPresentation?.Effective;
                                object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                                return be_ as CqlDateTime;
                            }
                            else if (as_())
                            {
                                DataType bf_ = AbnormalPresentation?.Effective;
                                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                                return bg_ as CqlDateTime;
                            }
                            else if (at_())
                            {
                                DataType bh_ = AbnormalPresentation?.Effective;
                                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                                return bi_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.earliest(context, ah_());
                        CqlDateTime aj_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ak_ = context.Operators.SameOrBefore(ai_, aj_, (string)default);
                        Code<ObservationStatus> al_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? am_ = al_?.Value;
                        string an_ = context.Operators.Convert<string>(am_);
                        string[] ao_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
                        bool? aq_ = context.Operators.And(ak_, ap_);
                        return aq_;
                    }

                    IEnumerable<Observation> aa_ = context.Operators.Where<Observation>(y_, z_);

                    object ab_(Observation @this) {

                        object bj_() {

                            bool bl_() {
                                DataType bo_ = @this?.Effective;
                                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                bool bq_ = bp_ is CqlDateTime;
                                return bq_;
                            }


                            bool bm_() {
                                DataType br_ = @this?.Effective;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                                bool bt_ = bs_ is CqlDateTime;
                                return bt_;
                            }


                            bool bn_() {
                                DataType bu_ = @this?.Effective;
                                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                                bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                                return bw_;
                            }

                            if (bl_())
                            {
                                DataType bx_ = @this?.Effective;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                return by_ as CqlDateTime;
                            }
                            else if (bm_())
                            {
                                DataType bz_ = @this?.Effective;
                                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                                return ca_ as CqlDateTime;
                            }
                            else if (bn_())
                            {
                                DataType cb_ = @this?.Effective;
                                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                                return cc_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime bk_ = QICoreCommon_4_0_000.Instance.earliest(context, bj_());
                        return bk_;
                    }

                    IEnumerable<Observation> ac_ = context.Operators.SortBy<Observation>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ad_ = context.Operators.Last<Observation>(ac_);
                    DataType ae_ = ad_?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    return ag_;
                }


                bool v_() {
                    CqlValueSet cd_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> ce_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, cd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? cf_(Observation AbnormalPresentation) {

                        object cn_() {

                            bool cx_() {
                                DataType da_ = AbnormalPresentation?.Effective;
                                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                                bool dc_ = db_ is CqlDateTime;
                                return dc_;
                            }


                            bool cy_() {
                                DataType dd_ = AbnormalPresentation?.Effective;
                                object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                                bool df_ = de_ is CqlDateTime;
                                return df_;
                            }


                            bool cz_() {
                                DataType dg_ = AbnormalPresentation?.Effective;
                                object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                                bool di_ = dh_ is CqlInterval<CqlDateTime>;
                                return di_;
                            }

                            if (cx_())
                            {
                                DataType dj_ = AbnormalPresentation?.Effective;
                                object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                                return dk_ as CqlDateTime;
                            }
                            else if (cy_())
                            {
                                DataType dl_ = AbnormalPresentation?.Effective;
                                object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                                return dm_ as CqlDateTime;
                            }
                            else if (cz_())
                            {
                                DataType dn_ = AbnormalPresentation?.Effective;
                                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                                return do_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime co_ = QICoreCommon_4_0_000.Instance.earliest(context, cn_());
                        CqlDateTime cp_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? cq_ = context.Operators.SameOrBefore(co_, cp_, (string)default);
                        Code<ObservationStatus> cr_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? cs_ = cr_?.Value;
                        string ct_ = context.Operators.Convert<string>(cs_);
                        string[] cu_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cv_ = context.Operators.In<string>(ct_, (IEnumerable<string>)cu_);
                        bool? cw_ = context.Operators.And(cq_, cv_);
                        return cw_;
                    }

                    IEnumerable<Observation> cg_ = context.Operators.Where<Observation>(ce_, cf_);

                    object ch_(Observation @this) {

                        object dp_() {

                            bool dr_() {
                                DataType du_ = @this?.Effective;
                                object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                                bool dw_ = dv_ is CqlDateTime;
                                return dw_;
                            }


                            bool ds_() {
                                DataType dx_ = @this?.Effective;
                                object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                                bool dz_ = dy_ is CqlDateTime;
                                return dz_;
                            }


                            bool dt_() {
                                DataType ea_ = @this?.Effective;
                                object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                                bool ec_ = eb_ is CqlInterval<CqlDateTime>;
                                return ec_;
                            }

                            if (dr_())
                            {
                                DataType ed_ = @this?.Effective;
                                object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                                return ee_ as CqlDateTime;
                            }
                            else if (ds_())
                            {
                                DataType ef_ = @this?.Effective;
                                object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                                return eg_ as CqlDateTime;
                            }
                            else if (dt_())
                            {
                                DataType eh_ = @this?.Effective;
                                object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                                return ei_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime dq_ = QICoreCommon_4_0_000.Instance.earliest(context, dp_());
                        return dq_;
                    }

                    IEnumerable<Observation> ci_ = context.Operators.SortBy<Observation>(cg_, ch_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation cj_ = context.Operators.Last<Observation>(ci_);
                    DataType ck_ = cj_?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlDateTime;
                    return cm_;
                }


                bool w_() {
                    CqlValueSet ej_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> ek_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ej_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? el_(Observation AbnormalPresentation) {

                        object et_() {

                            bool fd_() {
                                DataType fg_ = AbnormalPresentation?.Effective;
                                object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                                bool fi_ = fh_ is CqlDateTime;
                                return fi_;
                            }


                            bool fe_() {
                                DataType fj_ = AbnormalPresentation?.Effective;
                                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                                bool fl_ = fk_ is CqlDateTime;
                                return fl_;
                            }


                            bool ff_() {
                                DataType fm_ = AbnormalPresentation?.Effective;
                                object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                                bool fo_ = fn_ is CqlInterval<CqlDateTime>;
                                return fo_;
                            }

                            if (fd_())
                            {
                                DataType fp_ = AbnormalPresentation?.Effective;
                                object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);
                                return fq_ as CqlDateTime;
                            }
                            else if (fe_())
                            {
                                DataType fr_ = AbnormalPresentation?.Effective;
                                object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                                return fs_ as CqlDateTime;
                            }
                            else if (ff_())
                            {
                                DataType ft_ = AbnormalPresentation?.Effective;
                                object fu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ft_);
                                return fu_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime eu_ = QICoreCommon_4_0_000.Instance.earliest(context, et_());
                        CqlDateTime ev_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ew_ = context.Operators.SameOrBefore(eu_, ev_, (string)default);
                        Code<ObservationStatus> ex_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ey_ = ex_?.Value;
                        string ez_ = context.Operators.Convert<string>(ey_);
                        string[] fa_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? fb_ = context.Operators.In<string>(ez_, (IEnumerable<string>)fa_);
                        bool? fc_ = context.Operators.And(ew_, fb_);
                        return fc_;
                    }

                    IEnumerable<Observation> em_ = context.Operators.Where<Observation>(ek_, el_);

                    object en_(Observation @this) {

                        object fv_() {

                            bool fx_() {
                                DataType ga_ = @this?.Effective;
                                object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                                bool gc_ = gb_ is CqlDateTime;
                                return gc_;
                            }


                            bool fy_() {
                                DataType gd_ = @this?.Effective;
                                object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);
                                bool gf_ = ge_ is CqlDateTime;
                                return gf_;
                            }


                            bool fz_() {
                                DataType gg_ = @this?.Effective;
                                object gh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gg_);
                                bool gi_ = gh_ is CqlInterval<CqlDateTime>;
                                return gi_;
                            }

                            if (fx_())
                            {
                                DataType gj_ = @this?.Effective;
                                object gk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gj_);
                                return gk_ as CqlDateTime;
                            }
                            else if (fy_())
                            {
                                DataType gl_ = @this?.Effective;
                                object gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                                return gm_ as CqlDateTime;
                            }
                            else if (fz_())
                            {
                                DataType gn_ = @this?.Effective;
                                object go_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gn_);
                                return go_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime fw_ = QICoreCommon_4_0_000.Instance.earliest(context, fv_());
                        return fw_;
                    }

                    IEnumerable<Observation> eo_ = context.Operators.SortBy<Observation>(em_, en_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ep_ = context.Operators.Last<Observation>(eo_);
                    DataType eq_ = ep_?.Effective;
                    object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                    bool es_ = er_ is CqlInterval<CqlDateTime>;
                    return es_;
                }

                if (u_())
                {
                    CqlValueSet gp_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> gq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? gr_(Observation AbnormalPresentation) {

                        object gy_() {

                            bool hi_() {
                                DataType hl_ = AbnormalPresentation?.Effective;
                                object hm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hl_);
                                bool hn_ = hm_ is CqlDateTime;
                                return hn_;
                            }


                            bool hj_() {
                                DataType ho_ = AbnormalPresentation?.Effective;
                                object hp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ho_);
                                bool hq_ = hp_ is CqlDateTime;
                                return hq_;
                            }


                            bool hk_() {
                                DataType hr_ = AbnormalPresentation?.Effective;
                                object hs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hr_);
                                bool ht_ = hs_ is CqlInterval<CqlDateTime>;
                                return ht_;
                            }

                            if (hi_())
                            {
                                DataType hu_ = AbnormalPresentation?.Effective;
                                object hv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hu_);
                                return hv_ as CqlDateTime;
                            }
                            else if (hj_())
                            {
                                DataType hw_ = AbnormalPresentation?.Effective;
                                object hx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hw_);
                                return hx_ as CqlDateTime;
                            }
                            else if (hk_())
                            {
                                DataType hy_ = AbnormalPresentation?.Effective;
                                object hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                                return hz_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime gz_ = QICoreCommon_4_0_000.Instance.earliest(context, gy_());
                        CqlDateTime ha_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? hb_ = context.Operators.SameOrBefore(gz_, ha_, (string)default);
                        Code<ObservationStatus> hc_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? hd_ = hc_?.Value;
                        string he_ = context.Operators.Convert<string>(hd_);
                        string[] hf_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? hg_ = context.Operators.In<string>(he_, (IEnumerable<string>)hf_);
                        bool? hh_ = context.Operators.And(hb_, hg_);
                        return hh_;
                    }

                    IEnumerable<Observation> gs_ = context.Operators.Where<Observation>(gq_, gr_);

                    object gt_(Observation @this) {

                        object ia_() {

                            bool ic_() {
                                DataType if_ = @this?.Effective;
                                object ig_ = FHIRHelpers_4_4_000.Instance.ToValue(context, if_);
                                bool ih_ = ig_ is CqlDateTime;
                                return ih_;
                            }


                            bool id_() {
                                DataType ii_ = @this?.Effective;
                                object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);
                                bool ik_ = ij_ is CqlDateTime;
                                return ik_;
                            }


                            bool ie_() {
                                DataType il_ = @this?.Effective;
                                object im_ = FHIRHelpers_4_4_000.Instance.ToValue(context, il_);
                                bool in_ = im_ is CqlInterval<CqlDateTime>;
                                return in_;
                            }

                            if (ic_())
                            {
                                DataType io_ = @this?.Effective;
                                object ip_ = FHIRHelpers_4_4_000.Instance.ToValue(context, io_);
                                return ip_ as CqlDateTime;
                            }
                            else if (id_())
                            {
                                DataType iq_ = @this?.Effective;
                                object ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                                return ir_ as CqlDateTime;
                            }
                            else if (ie_())
                            {
                                DataType is_ = @this?.Effective;
                                object it_ = FHIRHelpers_4_4_000.Instance.ToValue(context, is_);
                                return it_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime ib_ = QICoreCommon_4_0_000.Instance.earliest(context, ia_());
                        return ib_;
                    }

                    IEnumerable<Observation> gu_ = context.Operators.SortBy<Observation>(gs_, gt_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation gv_ = context.Operators.Last<Observation>(gu_);
                    DataType gw_ = gv_?.Effective;
                    object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                    return gx_ as CqlDateTime;
                }
                else if (v_())
                {
                    CqlValueSet iu_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> iv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, iu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? iw_(Observation AbnormalPresentation) {

                        object jd_() {

                            bool jn_() {
                                DataType jq_ = AbnormalPresentation?.Effective;
                                object jr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jq_);
                                bool js_ = jr_ is CqlDateTime;
                                return js_;
                            }


                            bool jo_() {
                                DataType jt_ = AbnormalPresentation?.Effective;
                                object ju_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jt_);
                                bool jv_ = ju_ is CqlDateTime;
                                return jv_;
                            }


                            bool jp_() {
                                DataType jw_ = AbnormalPresentation?.Effective;
                                object jx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jw_);
                                bool jy_ = jx_ is CqlInterval<CqlDateTime>;
                                return jy_;
                            }

                            if (jn_())
                            {
                                DataType jz_ = AbnormalPresentation?.Effective;
                                object ka_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jz_);
                                return ka_ as CqlDateTime;
                            }
                            else if (jo_())
                            {
                                DataType kb_ = AbnormalPresentation?.Effective;
                                object kc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kb_);
                                return kc_ as CqlDateTime;
                            }
                            else if (jp_())
                            {
                                DataType kd_ = AbnormalPresentation?.Effective;
                                object ke_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kd_);
                                return ke_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime je_ = QICoreCommon_4_0_000.Instance.earliest(context, jd_());
                        CqlDateTime jf_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? jg_ = context.Operators.SameOrBefore(je_, jf_, (string)default);
                        Code<ObservationStatus> jh_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ji_ = jh_?.Value;
                        string jj_ = context.Operators.Convert<string>(ji_);
                        string[] jk_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? jl_ = context.Operators.In<string>(jj_, (IEnumerable<string>)jk_);
                        bool? jm_ = context.Operators.And(jg_, jl_);
                        return jm_;
                    }

                    IEnumerable<Observation> ix_ = context.Operators.Where<Observation>(iv_, iw_);

                    object iy_(Observation @this) {

                        object kf_() {

                            bool kh_() {
                                DataType kk_ = @this?.Effective;
                                object kl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kk_);
                                bool km_ = kl_ is CqlDateTime;
                                return km_;
                            }


                            bool ki_() {
                                DataType kn_ = @this?.Effective;
                                object ko_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kn_);
                                bool kp_ = ko_ is CqlDateTime;
                                return kp_;
                            }


                            bool kj_() {
                                DataType kq_ = @this?.Effective;
                                object kr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kq_);
                                bool ks_ = kr_ is CqlInterval<CqlDateTime>;
                                return ks_;
                            }

                            if (kh_())
                            {
                                DataType kt_ = @this?.Effective;
                                object ku_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kt_);
                                return ku_ as CqlDateTime;
                            }
                            else if (ki_())
                            {
                                DataType kv_ = @this?.Effective;
                                object kw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kv_);
                                return kw_ as CqlDateTime;
                            }
                            else if (kj_())
                            {
                                DataType kx_ = @this?.Effective;
                                object ky_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kx_);
                                return ky_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime kg_ = QICoreCommon_4_0_000.Instance.earliest(context, kf_());
                        return kg_;
                    }

                    IEnumerable<Observation> iz_ = context.Operators.SortBy<Observation>(ix_, iy_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ja_ = context.Operators.Last<Observation>(iz_);
                    DataType jb_ = ja_?.Effective;
                    object jc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jb_);
                    return jc_ as CqlDateTime;
                }
                else if (w_())
                {
                    CqlValueSet kz_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> la_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? lb_(Observation AbnormalPresentation) {

                        object li_() {

                            bool ls_() {
                                DataType lv_ = AbnormalPresentation?.Effective;
                                object lw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lv_);
                                bool lx_ = lw_ is CqlDateTime;
                                return lx_;
                            }


                            bool lt_() {
                                DataType ly_ = AbnormalPresentation?.Effective;
                                object lz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ly_);
                                bool ma_ = lz_ is CqlDateTime;
                                return ma_;
                            }


                            bool lu_() {
                                DataType mb_ = AbnormalPresentation?.Effective;
                                object mc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mb_);
                                bool md_ = mc_ is CqlInterval<CqlDateTime>;
                                return md_;
                            }

                            if (ls_())
                            {
                                DataType me_ = AbnormalPresentation?.Effective;
                                object mf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, me_);
                                return mf_ as CqlDateTime;
                            }
                            else if (lt_())
                            {
                                DataType mg_ = AbnormalPresentation?.Effective;
                                object mh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mg_);
                                return mh_ as CqlDateTime;
                            }
                            else if (lu_())
                            {
                                DataType mi_ = AbnormalPresentation?.Effective;
                                object mj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mi_);
                                return mj_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime lj_ = QICoreCommon_4_0_000.Instance.earliest(context, li_());
                        CqlDateTime lk_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ll_ = context.Operators.SameOrBefore(lj_, lk_, (string)default);
                        Code<ObservationStatus> lm_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ln_ = lm_?.Value;
                        string lo_ = context.Operators.Convert<string>(ln_);
                        string[] lp_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lq_ = context.Operators.In<string>(lo_, (IEnumerable<string>)lp_);
                        bool? lr_ = context.Operators.And(ll_, lq_);
                        return lr_;
                    }

                    IEnumerable<Observation> lc_ = context.Operators.Where<Observation>(la_, lb_);

                    object ld_(Observation @this) {

                        object mk_() {

                            bool mm_() {
                                DataType mp_ = @this?.Effective;
                                object mq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mp_);
                                bool mr_ = mq_ is CqlDateTime;
                                return mr_;
                            }


                            bool mn_() {
                                DataType ms_ = @this?.Effective;
                                object mt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ms_);
                                bool mu_ = mt_ is CqlDateTime;
                                return mu_;
                            }


                            bool mo_() {
                                DataType mv_ = @this?.Effective;
                                object mw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mv_);
                                bool mx_ = mw_ is CqlInterval<CqlDateTime>;
                                return mx_;
                            }

                            if (mm_())
                            {
                                DataType my_ = @this?.Effective;
                                object mz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, my_);
                                return mz_ as CqlDateTime;
                            }
                            else if (mn_())
                            {
                                DataType na_ = @this?.Effective;
                                object nb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, na_);
                                return nb_ as CqlDateTime;
                            }
                            else if (mo_())
                            {
                                DataType nc_ = @this?.Effective;
                                object nd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nc_);
                                return nd_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                return null;
                            }
                        }

                        CqlDateTime ml_ = QICoreCommon_4_0_000.Instance.earliest(context, mk_());
                        return ml_;
                    }

                    IEnumerable<Observation> le_ = context.Operators.SortBy<Observation>(lc_, ld_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation lf_ = context.Operators.Last<Observation>(le_);
                    DataType lg_ = lf_?.Effective;
                    object lh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lg_);
                    return lh_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime e_ = QICoreCommon_4_0_000.Instance.earliest(context, d_());
            CqlInterval<CqlDateTime> f_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
            bool? g_ = context.Operators.In<CqlDateTime>(e_, f_, (string)default);
            IEnumerable<Condition> h_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? i_(Condition @this) {
                CodeableConcept ne_ = @this?.Code;
                CqlConcept nf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ne_);
                bool? ng_ = context.Operators.Not((bool?)(nf_ is null));
                return ng_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);

            CqlConcept k_(Condition @this) {
                CodeableConcept nh_ = @this?.Code;
                CqlConcept ni_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nh_);
                return ni_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<Condition, CqlConcept>(j_, k_);
            CqlValueSet m_ = this.Abnormal_Presentation(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            bool? o_ = context.Operators.Or(g_, n_);
            List<CodeableConcept> p_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept q_(CodeableConcept @this) {
                CqlConcept nj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return nj_;
            }

            IEnumerable<CqlConcept> r_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_);
            bool? s_ = context.Operators.ConceptsInValueSet(r_, m_);
            bool? t_ = context.Operators.Or(o_, s_);
            return t_;
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
                CodeableConcept aa_ = @this?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                return ac_;
            }

            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

            CqlConcept g_(Condition @this) {
                CodeableConcept ad_ = @this?.Code;
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                return ae_;
            }

            IEnumerable<CqlConcept> h_ = context.Operators.Select<Condition, CqlConcept>(f_, g_);
            CqlValueSet i_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
            bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);

            bool? k_(Condition @this) {
                CodeableConcept af_ = @this?.Code;
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                return ah_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(d_, k_);

            CqlConcept m_(Condition @this) {
                CodeableConcept ai_ = @this?.Code;
                CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ai_);
                return aj_;
            }

            IEnumerable<CqlConcept> n_ = context.Operators.Select<Condition, CqlConcept>(l_, m_);
            CqlValueSet o_ = this.Genital_Herpes(context);
            bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
            bool? q_ = context.Operators.Or(j_, p_);
            List<CodeableConcept> r_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept s_(CodeableConcept @this) {
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ak_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            bool? u_ = context.Operators.ConceptsInValueSet(t_, o_);
            bool? v_ = context.Operators.Or(q_, u_);

            CqlConcept w_(CodeableConcept @this) {
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return al_;
            }

            IEnumerable<CqlConcept> x_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, w_);
            bool? y_ = context.Operators.ConceptsInValueSet(x_, i_);
            bool? z_ = context.Operators.Or(v_, y_);
            return z_;
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
                CqlInterval<CqlDateTime> i_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);

                object j_() {

                    bool r_() {
                        DataType v_ = CSection?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlDateTime;
                        return x_;
                    }


                    bool s_() {
                        DataType y_ = CSection?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlQuantity;
                        return aa_;
                    }


                    bool t_() {
                        DataType ab_ = CSection?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                        return ad_;
                    }


                    bool u_() {
                        DataType ae_ = CSection?.Performed;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlInterval<CqlQuantity>;
                        return ag_;
                    }

                    if (r_())
                    {
                        DataType ah_ = CSection?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        return ai_ as CqlDateTime;
                    }
                    else if (s_())
                    {
                        DataType aj_ = CSection?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return ak_ as CqlQuantity;
                    }
                    else if (t_())
                    {
                        DataType al_ = CSection?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return am_ as CqlInterval<CqlDateTime>;
                    }
                    else if (u_())
                    {
                        DataType an_ = CSection?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return ao_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, k_, (string)default);
                Code<EventStatus> m_ = CSection?.StatusElement;
                EventStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                bool? p_ = context.Operators.Equal(o_, "completed");
                bool? q_ = context.Operators.And(l_, p_);
                return q_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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
