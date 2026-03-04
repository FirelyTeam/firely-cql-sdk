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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
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
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return u_;
            }

            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            CqlValueSet j_ = this._37_to_42_Plus_Weeks_Gestation(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            IEnumerable<object> l_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? m_(object @this) {
                object v_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                return x_;
            }

            IEnumerable<object> n_ = context.Operators.Where<object>(l_, m_);

            CqlConcept o_(object @this) {
                object y_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
                return z_;
            }

            IEnumerable<CqlConcept> p_ = context.Operators.Select<object, CqlConcept>(n_, o_);
            bool? r_ = context.Operators.ConceptsInValueSet(p_, j_);
            bool? s_ = context.Operators.Or(k_, r_);
            bool? t_ = context.Operators.And(f_, s_);
            return t_;
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
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return q_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Delivery_of_Singleton(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<object> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? j_(object @this) {
                object r_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);

            CqlConcept l_(object @this) {
                object u_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
                return v_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<object, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);
            return p_;
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

                bool af_() {
                    DataType ai_ = Gravida?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    return ak_;
                }


                bool ag_() {
                    DataType al_ = Gravida?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    return an_;
                }


                bool ah_() {
                    DataType ao_ = Gravida?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    return aq_;
                }

                if (af_())
                {
                    DataType ar_ = Gravida?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlDateTime) as object;
                }
                else if (ag_())
                {
                    DataType at_ = Gravida?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ah_())
                {
                    DataType av_ = Gravida?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
            CqlDateTime v_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity w_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime x_ = context.Operators.Subtract(v_, w_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(x_, v_, true, false);
            bool? aa_ = context.Operators.In<CqlDateTime>(u_, z_, (string)default);
            bool? ac_ = context.Operators.Not((bool?)(v_ is null));
            bool? ad_ = context.Operators.And(aa_, ac_);
            bool? ae_ = context.Operators.And(s_, ad_);
            return ae_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object ax_() {

                bool az_() {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;
                    return be_;
                }


                bool ba_() {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                    return bh_;
                }


                bool bb_() {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;
                    return bk_;
                }

                if (az_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bm_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return (bo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bp_ = @this?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());
            return ay_;
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

                bool af_() {
                    DataType ai_ = Parity?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    return ak_;
                }


                bool ag_() {
                    DataType al_ = Parity?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    return an_;
                }


                bool ah_() {
                    DataType ao_ = Parity?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    return aq_;
                }

                if (af_())
                {
                    DataType ar_ = Parity?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlDateTime) as object;
                }
                else if (ag_())
                {
                    DataType at_ = Parity?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ah_())
                {
                    DataType av_ = Parity?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? t_ = context.Operators.Not((bool?)(m_ is null));
            bool? u_ = context.Operators.And(r_, t_);
            Code<ObservationStatus> v_ = Parity?.StatusElement;
            ObservationStatus? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(u_, z_);
            DataType ab_ = Parity?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            return ae_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object ax_() {

                bool az_() {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;
                    return be_;
                }


                bool ba_() {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                    return bh_;
                }


                bool bb_() {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;
                    return bk_;
                }

                if (az_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bm_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return (bo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bp_ = @this?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());
            return ay_;
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

                bool af_() {
                    DataType ai_ = PretermBirth?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    return ak_;
                }


                bool ag_() {
                    DataType al_ = PretermBirth?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    return an_;
                }


                bool ah_() {
                    DataType ao_ = PretermBirth?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    return aq_;
                }

                if (af_())
                {
                    DataType ar_ = PretermBirth?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlDateTime) as object;
                }
                else if (ag_())
                {
                    DataType at_ = PretermBirth?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ah_())
                {
                    DataType av_ = PretermBirth?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? t_ = context.Operators.Not((bool?)(m_ is null));
            bool? u_ = context.Operators.And(r_, t_);
            Code<ObservationStatus> v_ = PretermBirth?.StatusElement;
            ObservationStatus? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(u_, z_);
            DataType ab_ = PretermBirth?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            return ae_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object ax_() {

                bool az_() {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;
                    return be_;
                }


                bool ba_() {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                    return bh_;
                }


                bool bb_() {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;
                    return bk_;
                }

                if (az_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bm_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return (bo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bp_ = @this?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());
            return ay_;
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

                bool af_() {
                    DataType ai_ = TermBirth?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    return ak_;
                }


                bool ag_() {
                    DataType al_ = TermBirth?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    return an_;
                }


                bool ah_() {
                    DataType ao_ = TermBirth?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    return aq_;
                }

                if (af_())
                {
                    DataType ar_ = TermBirth?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlDateTime) as object;
                }
                else if (ag_())
                {
                    DataType at_ = TermBirth?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ah_())
                {
                    DataType av_ = TermBirth?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? t_ = context.Operators.Not((bool?)(m_ is null));
            bool? u_ = context.Operators.And(r_, t_);
            Code<ObservationStatus> v_ = TermBirth?.StatusElement;
            ObservationStatus? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            bool? aa_ = context.Operators.And(u_, z_);
            DataType ab_ = TermBirth?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            return ae_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object ax_() {

                bool az_() {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;
                    return be_;
                }


                bool ba_() {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                    return bh_;
                }


                bool bb_() {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;
                    return bk_;
                }

                if (az_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bm_ as CqlDateTime) as object;
                }
                else if (ba_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return (bo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bb_())
                {
                    DataType bp_ = @this?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    return (bq_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());
            return ay_;
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

                bool v_() {
                    CqlValueSet y_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> z_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? aa_(Observation AbnormalPresentation) {

                        object ai_() {

                            bool as_() {
                                DataType av_ = AbnormalPresentation?.Effective;
                                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                bool ax_ = aw_ is CqlDateTime;
                                return ax_;
                            }


                            bool at_() {
                                DataType ay_ = AbnormalPresentation?.Effective;
                                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                                bool ba_ = az_ is CqlInterval<CqlDateTime>;
                                return ba_;
                            }


                            bool au_() {
                                DataType bb_ = AbnormalPresentation?.Effective;
                                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                                bool bd_ = bc_ is CqlDateTime;
                                return bd_;
                            }

                            if (as_())
                            {
                                DataType be_ = AbnormalPresentation?.Effective;
                                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                                return (bf_ as CqlDateTime) as object;
                            }
                            else if (at_())
                            {
                                DataType bg_ = AbnormalPresentation?.Effective;
                                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                                return (bh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (au_())
                            {
                                DataType bi_ = AbnormalPresentation?.Effective;
                                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                                return (bj_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_());
                        CqlDateTime ak_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? al_ = context.Operators.SameOrBefore(aj_, ak_, (string)default);
                        Code<ObservationStatus> am_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? an_ = am_?.Value;
                        string ao_ = context.Operators.Convert<string>(an_);
                        string[] ap_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);
                        bool? ar_ = context.Operators.And(al_, aq_);
                        return ar_;
                    }

                    IEnumerable<Observation> ab_ = context.Operators.Where<Observation>(z_, aa_);

                    object ac_(Observation @this) {

                        object bk_() {

                            bool bm_() {
                                DataType bp_ = @this?.Effective;
                                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                bool br_ = bq_ is CqlDateTime;
                                return br_;
                            }


                            bool bn_() {
                                DataType bs_ = @this?.Effective;
                                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                                bool bu_ = bt_ is CqlInterval<CqlDateTime>;
                                return bu_;
                            }


                            bool bo_() {
                                DataType bv_ = @this?.Effective;
                                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                                bool bx_ = bw_ is CqlDateTime;
                                return bx_;
                            }

                            if (bm_())
                            {
                                DataType by_ = @this?.Effective;
                                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                                return (bz_ as CqlDateTime) as object;
                            }
                            else if (bn_())
                            {
                                DataType ca_ = @this?.Effective;
                                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                                return (cb_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bo_())
                            {
                                DataType cc_ = @this?.Effective;
                                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                                return (cd_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime bl_ = QICoreCommon_4_0_000.Instance.earliest(context, bk_());
                        return bl_;
                    }

                    IEnumerable<Observation> ad_ = context.Operators.SortBy<Observation>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ae_ = context.Operators.Last<Observation>(ad_);
                    DataType af_ = ae_?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlDateTime;
                    return ah_;
                }


                bool w_() {
                    CqlValueSet ce_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> cf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ce_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? cg_(Observation AbnormalPresentation) {

                        object co_() {

                            bool cy_() {
                                DataType db_ = AbnormalPresentation?.Effective;
                                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                                bool dd_ = dc_ is CqlDateTime;
                                return dd_;
                            }


                            bool cz_() {
                                DataType de_ = AbnormalPresentation?.Effective;
                                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                                bool dg_ = df_ is CqlInterval<CqlDateTime>;
                                return dg_;
                            }


                            bool da_() {
                                DataType dh_ = AbnormalPresentation?.Effective;
                                object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                                bool dj_ = di_ is CqlDateTime;
                                return dj_;
                            }

                            if (cy_())
                            {
                                DataType dk_ = AbnormalPresentation?.Effective;
                                object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                                return (dl_ as CqlDateTime) as object;
                            }
                            else if (cz_())
                            {
                                DataType dm_ = AbnormalPresentation?.Effective;
                                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                                return (dn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (da_())
                            {
                                DataType do_ = AbnormalPresentation?.Effective;
                                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                                return (dp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime cp_ = QICoreCommon_4_0_000.Instance.earliest(context, co_());
                        CqlDateTime cq_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? cr_ = context.Operators.SameOrBefore(cp_, cq_, (string)default);
                        Code<ObservationStatus> cs_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ct_ = cs_?.Value;
                        string cu_ = context.Operators.Convert<string>(ct_);
                        string[] cv_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cw_ = context.Operators.In<string>(cu_, (IEnumerable<string>)cv_);
                        bool? cx_ = context.Operators.And(cr_, cw_);
                        return cx_;
                    }

                    IEnumerable<Observation> ch_ = context.Operators.Where<Observation>(cf_, cg_);

                    object ci_(Observation @this) {

                        object dq_() {

                            bool ds_() {
                                DataType dv_ = @this?.Effective;
                                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                                bool dx_ = dw_ is CqlDateTime;
                                return dx_;
                            }


                            bool dt_() {
                                DataType dy_ = @this?.Effective;
                                object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                                bool ea_ = dz_ is CqlInterval<CqlDateTime>;
                                return ea_;
                            }


                            bool du_() {
                                DataType eb_ = @this?.Effective;
                                object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                                bool ed_ = ec_ is CqlDateTime;
                                return ed_;
                            }

                            if (ds_())
                            {
                                DataType ee_ = @this?.Effective;
                                object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                                return (ef_ as CqlDateTime) as object;
                            }
                            else if (dt_())
                            {
                                DataType eg_ = @this?.Effective;
                                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                                return (eh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (du_())
                            {
                                DataType ei_ = @this?.Effective;
                                object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                                return (ej_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime dr_ = QICoreCommon_4_0_000.Instance.earliest(context, dq_());
                        return dr_;
                    }

                    IEnumerable<Observation> cj_ = context.Operators.SortBy<Observation>(ch_, ci_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ck_ = context.Operators.Last<Observation>(cj_);
                    DataType cl_ = ck_?.Effective;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlInterval<CqlDateTime>;
                    return cn_;
                }


                bool x_() {
                    CqlValueSet ek_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> el_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ek_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? em_(Observation AbnormalPresentation) {

                        object eu_() {

                            bool fe_() {
                                DataType fh_ = AbnormalPresentation?.Effective;
                                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                                bool fj_ = fi_ is CqlDateTime;
                                return fj_;
                            }


                            bool ff_() {
                                DataType fk_ = AbnormalPresentation?.Effective;
                                object fl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fk_);
                                bool fm_ = fl_ is CqlInterval<CqlDateTime>;
                                return fm_;
                            }


                            bool fg_() {
                                DataType fn_ = AbnormalPresentation?.Effective;
                                object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                                bool fp_ = fo_ is CqlDateTime;
                                return fp_;
                            }

                            if (fe_())
                            {
                                DataType fq_ = AbnormalPresentation?.Effective;
                                object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                                return (fr_ as CqlDateTime) as object;
                            }
                            else if (ff_())
                            {
                                DataType fs_ = AbnormalPresentation?.Effective;
                                object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                                return (ft_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fg_())
                            {
                                DataType fu_ = AbnormalPresentation?.Effective;
                                object fv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fu_);
                                return (fv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime ev_ = QICoreCommon_4_0_000.Instance.earliest(context, eu_());
                        CqlDateTime ew_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ex_ = context.Operators.SameOrBefore(ev_, ew_, (string)default);
                        Code<ObservationStatus> ey_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ez_ = ey_?.Value;
                        string fa_ = context.Operators.Convert<string>(ez_);
                        string[] fb_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? fc_ = context.Operators.In<string>(fa_, (IEnumerable<string>)fb_);
                        bool? fd_ = context.Operators.And(ex_, fc_);
                        return fd_;
                    }

                    IEnumerable<Observation> en_ = context.Operators.Where<Observation>(el_, em_);

                    object eo_(Observation @this) {

                        object fw_() {

                            bool fy_() {
                                DataType gb_ = @this?.Effective;
                                object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);
                                bool gd_ = gc_ is CqlDateTime;
                                return gd_;
                            }


                            bool fz_() {
                                DataType ge_ = @this?.Effective;
                                object gf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ge_);
                                bool gg_ = gf_ is CqlInterval<CqlDateTime>;
                                return gg_;
                            }


                            bool ga_() {
                                DataType gh_ = @this?.Effective;
                                object gi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gh_);
                                bool gj_ = gi_ is CqlDateTime;
                                return gj_;
                            }

                            if (fy_())
                            {
                                DataType gk_ = @this?.Effective;
                                object gl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gk_);
                                return (gl_ as CqlDateTime) as object;
                            }
                            else if (fz_())
                            {
                                DataType gm_ = @this?.Effective;
                                object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                                return (gn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ga_())
                            {
                                DataType go_ = @this?.Effective;
                                object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                                return (gp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime fx_ = QICoreCommon_4_0_000.Instance.earliest(context, fw_());
                        return fx_;
                    }

                    IEnumerable<Observation> ep_ = context.Operators.SortBy<Observation>(en_, eo_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation eq_ = context.Operators.Last<Observation>(ep_);
                    DataType er_ = eq_?.Effective;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlDateTime;
                    return et_;
                }

                if (v_())
                {
                    CqlValueSet gq_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> gr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? gs_(Observation AbnormalPresentation) {

                        object gz_() {

                            bool hj_() {
                                DataType hm_ = AbnormalPresentation?.Effective;
                                object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                                bool ho_ = hn_ is CqlDateTime;
                                return ho_;
                            }


                            bool hk_() {
                                DataType hp_ = AbnormalPresentation?.Effective;
                                object hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                                bool hr_ = hq_ is CqlInterval<CqlDateTime>;
                                return hr_;
                            }


                            bool hl_() {
                                DataType hs_ = AbnormalPresentation?.Effective;
                                object ht_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hs_);
                                bool hu_ = ht_ is CqlDateTime;
                                return hu_;
                            }

                            if (hj_())
                            {
                                DataType hv_ = AbnormalPresentation?.Effective;
                                object hw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hv_);
                                return (hw_ as CqlDateTime) as object;
                            }
                            else if (hk_())
                            {
                                DataType hx_ = AbnormalPresentation?.Effective;
                                object hy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hx_);
                                return (hy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hl_())
                            {
                                DataType hz_ = AbnormalPresentation?.Effective;
                                object ia_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hz_);
                                return (ia_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime ha_ = QICoreCommon_4_0_000.Instance.earliest(context, gz_());
                        CqlDateTime hb_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? hc_ = context.Operators.SameOrBefore(ha_, hb_, (string)default);
                        Code<ObservationStatus> hd_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? he_ = hd_?.Value;
                        string hf_ = context.Operators.Convert<string>(he_);
                        string[] hg_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? hh_ = context.Operators.In<string>(hf_, (IEnumerable<string>)hg_);
                        bool? hi_ = context.Operators.And(hc_, hh_);
                        return hi_;
                    }

                    IEnumerable<Observation> gt_ = context.Operators.Where<Observation>(gr_, gs_);

                    object gu_(Observation @this) {

                        object ib_() {

                            bool id_() {
                                DataType ig_ = @this?.Effective;
                                object ih_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ig_);
                                bool ii_ = ih_ is CqlDateTime;
                                return ii_;
                            }


                            bool ie_() {
                                DataType ij_ = @this?.Effective;
                                object ik_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ij_);
                                bool il_ = ik_ is CqlInterval<CqlDateTime>;
                                return il_;
                            }


                            bool if_() {
                                DataType im_ = @this?.Effective;
                                object in_ = FHIRHelpers_4_4_000.Instance.ToValue(context, im_);
                                bool io_ = in_ is CqlDateTime;
                                return io_;
                            }

                            if (id_())
                            {
                                DataType ip_ = @this?.Effective;
                                object iq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ip_);
                                return (iq_ as CqlDateTime) as object;
                            }
                            else if (ie_())
                            {
                                DataType ir_ = @this?.Effective;
                                object is_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ir_);
                                return (is_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (if_())
                            {
                                DataType it_ = @this?.Effective;
                                object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                                return (iu_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime ic_ = QICoreCommon_4_0_000.Instance.earliest(context, ib_());
                        return ic_;
                    }

                    IEnumerable<Observation> gv_ = context.Operators.SortBy<Observation>(gt_, gu_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation gw_ = context.Operators.Last<Observation>(gv_);
                    DataType gx_ = gw_?.Effective;
                    object gy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gx_);
                    return (gy_ as CqlDateTime) as object;
                }
                else if (w_())
                {
                    CqlValueSet iv_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> iw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, iv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? ix_(Observation AbnormalPresentation) {

                        object je_() {

                            bool jo_() {
                                DataType jr_ = AbnormalPresentation?.Effective;
                                object js_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jr_);
                                bool jt_ = js_ is CqlDateTime;
                                return jt_;
                            }


                            bool jp_() {
                                DataType ju_ = AbnormalPresentation?.Effective;
                                object jv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ju_);
                                bool jw_ = jv_ is CqlInterval<CqlDateTime>;
                                return jw_;
                            }


                            bool jq_() {
                                DataType jx_ = AbnormalPresentation?.Effective;
                                object jy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jx_);
                                bool jz_ = jy_ is CqlDateTime;
                                return jz_;
                            }

                            if (jo_())
                            {
                                DataType ka_ = AbnormalPresentation?.Effective;
                                object kb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ka_);
                                return (kb_ as CqlDateTime) as object;
                            }
                            else if (jp_())
                            {
                                DataType kc_ = AbnormalPresentation?.Effective;
                                object kd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kc_);
                                return (kd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jq_())
                            {
                                DataType ke_ = AbnormalPresentation?.Effective;
                                object kf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ke_);
                                return (kf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime jf_ = QICoreCommon_4_0_000.Instance.earliest(context, je_());
                        CqlDateTime jg_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? jh_ = context.Operators.SameOrBefore(jf_, jg_, (string)default);
                        Code<ObservationStatus> ji_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? jj_ = ji_?.Value;
                        string jk_ = context.Operators.Convert<string>(jj_);
                        string[] jl_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? jm_ = context.Operators.In<string>(jk_, (IEnumerable<string>)jl_);
                        bool? jn_ = context.Operators.And(jh_, jm_);
                        return jn_;
                    }

                    IEnumerable<Observation> iy_ = context.Operators.Where<Observation>(iw_, ix_);

                    object iz_(Observation @this) {

                        object kg_() {

                            bool ki_() {
                                DataType kl_ = @this?.Effective;
                                object km_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kl_);
                                bool kn_ = km_ is CqlDateTime;
                                return kn_;
                            }


                            bool kj_() {
                                DataType ko_ = @this?.Effective;
                                object kp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ko_);
                                bool kq_ = kp_ is CqlInterval<CqlDateTime>;
                                return kq_;
                            }


                            bool kk_() {
                                DataType kr_ = @this?.Effective;
                                object ks_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kr_);
                                bool kt_ = ks_ is CqlDateTime;
                                return kt_;
                            }

                            if (ki_())
                            {
                                DataType ku_ = @this?.Effective;
                                object kv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ku_);
                                return (kv_ as CqlDateTime) as object;
                            }
                            else if (kj_())
                            {
                                DataType kw_ = @this?.Effective;
                                object kx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kw_);
                                return (kx_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kk_())
                            {
                                DataType ky_ = @this?.Effective;
                                object kz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ky_);
                                return (kz_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime kh_ = QICoreCommon_4_0_000.Instance.earliest(context, kg_());
                        return kh_;
                    }

                    IEnumerable<Observation> ja_ = context.Operators.SortBy<Observation>(iy_, iz_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation jb_ = context.Operators.Last<Observation>(ja_);
                    DataType jc_ = jb_?.Effective;
                    object jd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jc_);
                    return (jd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (x_())
                {
                    CqlValueSet la_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> lb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, la_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? lc_(Observation AbnormalPresentation) {

                        object lj_() {

                            bool lt_() {
                                DataType lw_ = AbnormalPresentation?.Effective;
                                object lx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lw_);
                                bool ly_ = lx_ is CqlDateTime;
                                return ly_;
                            }


                            bool lu_() {
                                DataType lz_ = AbnormalPresentation?.Effective;
                                object ma_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lz_);
                                bool mb_ = ma_ is CqlInterval<CqlDateTime>;
                                return mb_;
                            }


                            bool lv_() {
                                DataType mc_ = AbnormalPresentation?.Effective;
                                object md_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mc_);
                                bool me_ = md_ is CqlDateTime;
                                return me_;
                            }

                            if (lt_())
                            {
                                DataType mf_ = AbnormalPresentation?.Effective;
                                object mg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mf_);
                                return (mg_ as CqlDateTime) as object;
                            }
                            else if (lu_())
                            {
                                DataType mh_ = AbnormalPresentation?.Effective;
                                object mi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mh_);
                                return (mi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lv_())
                            {
                                DataType mj_ = AbnormalPresentation?.Effective;
                                object mk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mj_);
                                return (mk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime lk_ = QICoreCommon_4_0_000.Instance.earliest(context, lj_());
                        CqlDateTime ll_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? lm_ = context.Operators.SameOrBefore(lk_, ll_, (string)default);
                        Code<ObservationStatus> ln_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? lo_ = ln_?.Value;
                        string lp_ = context.Operators.Convert<string>(lo_);
                        string[] lq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lr_ = context.Operators.In<string>(lp_, (IEnumerable<string>)lq_);
                        bool? ls_ = context.Operators.And(lm_, lr_);
                        return ls_;
                    }

                    IEnumerable<Observation> ld_ = context.Operators.Where<Observation>(lb_, lc_);

                    object le_(Observation @this) {

                        object ml_() {

                            bool mn_() {
                                DataType mq_ = @this?.Effective;
                                object mr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mq_);
                                bool ms_ = mr_ is CqlDateTime;
                                return ms_;
                            }


                            bool mo_() {
                                DataType mt_ = @this?.Effective;
                                object mu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mt_);
                                bool mv_ = mu_ is CqlInterval<CqlDateTime>;
                                return mv_;
                            }


                            bool mp_() {
                                DataType mw_ = @this?.Effective;
                                object mx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mw_);
                                bool my_ = mx_ is CqlDateTime;
                                return my_;
                            }

                            if (mn_())
                            {
                                DataType mz_ = @this?.Effective;
                                object na_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mz_);
                                return (na_ as CqlDateTime) as object;
                            }
                            else if (mo_())
                            {
                                DataType nb_ = @this?.Effective;
                                object nc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nb_);
                                return (nc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mp_())
                            {
                                DataType nd_ = @this?.Effective;
                                object ne_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nd_);
                                return (ne_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime mm_ = QICoreCommon_4_0_000.Instance.earliest(context, ml_());
                        return mm_;
                    }

                    IEnumerable<Observation> lf_ = context.Operators.SortBy<Observation>(ld_, le_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation lg_ = context.Operators.Last<Observation>(lf_);
                    DataType lh_ = lg_?.Effective;
                    object li_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lh_);
                    return (li_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime e_ = QICoreCommon_4_0_000.Instance.earliest(context, d_());
            CqlInterval<CqlDateTime> f_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
            bool? g_ = context.Operators.In<CqlDateTime>(e_, f_, (string)default);
            IEnumerable<object> h_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? i_(object @this) {
                object nf_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept ng_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nf_ as CodeableConcept);
                bool? nh_ = context.Operators.Not((bool?)(ng_ is null));
                return nh_;
            }

            IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);

            CqlConcept k_(object @this) {
                object ni_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept nj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ni_ as CodeableConcept);
                return nj_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<object, CqlConcept>(j_, k_);
            CqlValueSet m_ = this.Abnormal_Presentation(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            bool? o_ = context.Operators.Or(g_, n_);
            List<CodeableConcept> p_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept q_(CodeableConcept @this) {
                CqlConcept nk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return nk_;
            }

            IEnumerable<CqlConcept> r_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)p_, q_);
            bool? t_ = context.Operators.ConceptsInValueSet(r_, m_);
            bool? u_ = context.Operators.Or(o_, t_);
            return u_;
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
            IEnumerable<object> d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? e_(object @this) {
                object ae_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_ as CodeableConcept);
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                return ag_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);

            CqlConcept g_(object @this) {
                object ah_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_ as CodeableConcept);
                return ai_;
            }

            IEnumerable<CqlConcept> h_ = context.Operators.Select<object, CqlConcept>(f_, g_);
            CqlValueSet i_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
            bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);

            bool? l_(object @this) {
                object aj_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_ as CodeableConcept);
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                return al_;
            }

            IEnumerable<object> m_ = context.Operators.Where<object>(d_, l_);

            CqlConcept n_(object @this) {
                object am_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_ as CodeableConcept);
                return an_;
            }

            IEnumerable<CqlConcept> o_ = context.Operators.Select<object, CqlConcept>(m_, n_);
            CqlValueSet p_ = this.Genital_Herpes(context);
            bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
            bool? r_ = context.Operators.Or(j_, q_);
            List<CodeableConcept> s_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept t_(CodeableConcept @this) {
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ao_;
            }

            IEnumerable<CqlConcept> u_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)s_, t_);
            bool? w_ = context.Operators.ConceptsInValueSet(u_, p_);
            bool? x_ = context.Operators.Or(r_, w_);

            CqlConcept z_(CodeableConcept @this) {
                CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ap_;
            }

            IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)s_, z_);
            bool? ac_ = context.Operators.ConceptsInValueSet(aa_, i_);
            bool? ad_ = context.Operators.Or(x_, ac_);
            return ad_;
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

        IEnumerable<Encounter> b_(Encounter ThirtySevenWeeksPlusEncounter) {
            CqlValueSet d_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure CSection) {
                CqlInterval<CqlDateTime> j_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);

                object k_() {

                    bool s_() {
                        DataType w_ = CSection?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;
                        return y_;
                    }


                    bool t_() {
                        DataType z_ = CSection?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        return ab_;
                    }


                    bool u_() {
                        DataType ac_ = CSection?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;
                        return ae_;
                    }


                    bool v_() {
                        DataType af_ = CSection?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                        return ah_;
                    }

                    if (s_())
                    {
                        DataType ai_ = CSection?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return (aj_ as CqlDateTime) as object;
                    }
                    else if (t_())
                    {
                        DataType ak_ = CSection?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return (al_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (u_())
                    {
                        DataType am_ = CSection?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return (an_ as CqlQuantity) as object;
                    }
                    else if (v_())
                    {
                        DataType ao_ = CSection?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return (ap_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, (string)default);
                Code<EventStatus> n_ = CSection?.StatusElement;
                EventStatus? o_ = n_?.Value;
                string p_ = context.Operators.Convert<string>(o_);
                bool? q_ = context.Operators.Equal(p_, "completed");
                bool? r_ = context.Operators.And(m_, q_);
                return r_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure CSection) => ThirtySevenWeeksPlusEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
