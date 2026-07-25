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
            object t_;
            DataType ad_ = Gravida?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType ag_ = Gravida?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                t_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType ai_ = Gravida?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                if (ak_)
                {
                    DataType al_ = Gravida?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    t_ = am_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType an_ = Gravida?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlDateTime;
                    if (ap_)
                    {
                        DataType aq_ = Gravida?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        t_ = ar_ as CqlDateTime;
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
            bool? aa_ = context.Operators.Not((bool?)(v_ is null));
            bool? ab_ = context.Operators.And(z_, aa_);
            bool? ac_ = context.Operators.And(s_, ab_);
            return ac_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object as_;
            DataType au_ = @this?.Effective;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                if (bb_)
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType be_ = @this?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlDateTime;
                    if (bg_)
                    {
                        DataType bh_ = @this?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlDateTime;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_;
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
            DataType ad_ = Parity?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType ag_ = Parity?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                k_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType ai_ = Parity?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                if (ak_)
                {
                    DataType al_ = Parity?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    k_ = am_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType an_ = Parity?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlDateTime;
                    if (ap_)
                    {
                        DataType aq_ = Parity?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        k_ = ar_ as CqlDateTime;
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
            object as_;
            DataType au_ = @this?.Effective;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                if (bb_)
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType be_ = @this?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlDateTime;
                    if (bg_)
                    {
                        DataType bh_ = @this?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlDateTime;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_;
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
            DataType ad_ = PretermBirth?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType ag_ = PretermBirth?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                k_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType ai_ = PretermBirth?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                if (ak_)
                {
                    DataType al_ = PretermBirth?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    k_ = am_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType an_ = PretermBirth?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlDateTime;
                    if (ap_)
                    {
                        DataType aq_ = PretermBirth?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        k_ = ar_ as CqlDateTime;
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
            object as_;
            DataType au_ = @this?.Effective;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                if (bb_)
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType be_ = @this?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlDateTime;
                    if (bg_)
                    {
                        DataType bh_ = @this?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlDateTime;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_;
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
            DataType ad_ = TermBirth?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType ag_ = TermBirth?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                k_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType ai_ = TermBirth?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                if (ak_)
                {
                    DataType al_ = TermBirth?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    k_ = am_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType an_ = TermBirth?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlDateTime;
                    if (ap_)
                    {
                        DataType aq_ = TermBirth?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        k_ = ar_ as CqlDateTime;
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
            object as_;
            DataType au_ = @this?.Effective;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType ax_ = @this?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType az_ = @this?.Effective;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                if (bb_)
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType be_ = @this?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlDateTime;
                    if (bg_)
                    {
                        DataType bh_ = @this?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlDateTime;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_;
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
            object d_;
            CqlValueSet u_ = this.Abnormal_Presentation(context);
            IEnumerable<Observation> v_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? w_(Observation AbnormalPresentation) {
                object ae_;
                DataType ao_ = AbnormalPresentation?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                bool aq_ = ap_ is CqlDateTime;
                if (aq_)
                {
                    DataType ar_ = AbnormalPresentation?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    ae_ = as_ as CqlDateTime;
                }
                else
                {
                    DataType at_ = AbnormalPresentation?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    bool av_ = au_ is CqlInterval<CqlDateTime>;
                    if (av_)
                    {
                        DataType aw_ = AbnormalPresentation?.Effective;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        ae_ = ax_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ay_ = AbnormalPresentation?.Effective;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlDateTime;
                        if (ba_)
                        {
                            DataType bb_ = AbnormalPresentation?.Effective;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            ae_ = bc_ as CqlDateTime;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
                CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
                CqlDateTime ag_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                bool? ah_ = context.Operators.SameOrBefore(af_, ag_, (string)default);
                Code<ObservationStatus> ai_ = AbnormalPresentation?.StatusElement;
                ObservationStatus? aj_ = ai_?.Value;
                string ak_ = context.Operators.Convert<string>(aj_);
                string[] al_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                bool? an_ = context.Operators.And(ah_, am_);
                return an_;
            }

            IEnumerable<Observation> x_ = context.Operators.Where<Observation>(v_, w_);

            object y_(Observation @this) {
                object bd_;
                DataType bf_ = @this?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bd_ = bj_ as CqlDateTime;
                }
                else
                {
                    DataType bk_ = @this?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    if (bm_)
                    {
                        DataType bn_ = @this?.Effective;
                        object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        bd_ = bo_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bp_ = @this?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlDateTime;
                        if (br_)
                        {
                            DataType bs_ = @this?.Effective;
                            object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                            bd_ = bt_ as CqlDateTime;
                        }
                        else
                        {
                            bd_ = null;
                        }
                    }
                }
                CqlDateTime be_ = QICoreCommon_4_0_000.Instance.earliest(context, bd_);
                return be_;
            }

            IEnumerable<Observation> z_ = context.Operators.SortBy<Observation>(x_, y_, System.ComponentModel.ListSortDirection.Ascending);
            Observation aa_ = context.Operators.Last<Observation>(z_);
            DataType ab_ = aa_?.Effective;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool ad_ = ac_ is CqlDateTime;
            if (ad_)
            {
                CqlValueSet bu_ = this.Abnormal_Presentation(context);
                IEnumerable<Observation> bv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                bool? bw_(Observation AbnormalPresentation) {
                    object cd_;
                    DataType cn_ = AbnormalPresentation?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlDateTime;
                    if (cp_)
                    {
                        DataType cq_ = AbnormalPresentation?.Effective;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        cd_ = cr_ as CqlDateTime;
                    }
                    else
                    {
                        DataType cs_ = AbnormalPresentation?.Effective;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                        if (cu_)
                        {
                            DataType cv_ = AbnormalPresentation?.Effective;
                            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                            cd_ = cw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType cx_ = AbnormalPresentation?.Effective;
                            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                            bool cz_ = cy_ is CqlDateTime;
                            if (cz_)
                            {
                                DataType da_ = AbnormalPresentation?.Effective;
                                object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                                cd_ = db_ as CqlDateTime;
                            }
                            else
                            {
                                cd_ = null;
                            }
                        }
                    }
                    CqlDateTime ce_ = QICoreCommon_4_0_000.Instance.earliest(context, cd_);
                    CqlDateTime cf_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? cg_ = context.Operators.SameOrBefore(ce_, cf_, (string)default);
                    Code<ObservationStatus> ch_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? ci_ = ch_?.Value;
                    string cj_ = context.Operators.Convert<string>(ci_);
                    string[] ck_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? cl_ = context.Operators.In<string>(cj_, (IEnumerable<string>)ck_);
                    bool? cm_ = context.Operators.And(cg_, cl_);
                    return cm_;
                }

                IEnumerable<Observation> bx_ = context.Operators.Where<Observation>(bv_, bw_);

                object by_(Observation @this) {
                    object dc_;
                    DataType de_ = @this?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlDateTime;
                    if (dg_)
                    {
                        DataType dh_ = @this?.Effective;
                        object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                        dc_ = di_ as CqlDateTime;
                    }
                    else
                    {
                        DataType dj_ = @this?.Effective;
                        object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                        bool dl_ = dk_ is CqlInterval<CqlDateTime>;
                        if (dl_)
                        {
                            DataType dm_ = @this?.Effective;
                            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                            dc_ = dn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType do_ = @this?.Effective;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            bool dq_ = dp_ is CqlDateTime;
                            if (dq_)
                            {
                                DataType dr_ = @this?.Effective;
                                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                                dc_ = ds_ as CqlDateTime;
                            }
                            else
                            {
                                dc_ = null;
                            }
                        }
                    }
                    CqlDateTime dd_ = QICoreCommon_4_0_000.Instance.earliest(context, dc_);
                    return dd_;
                }

                IEnumerable<Observation> bz_ = context.Operators.SortBy<Observation>(bx_, by_, System.ComponentModel.ListSortDirection.Ascending);
                Observation ca_ = context.Operators.Last<Observation>(bz_);
                DataType cb_ = ca_?.Effective;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                d_ = cc_ as CqlDateTime;
            }
            else
            {
                CqlValueSet dt_ = this.Abnormal_Presentation(context);
                IEnumerable<Observation> du_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                bool? dv_(Observation AbnormalPresentation) {
                    object ed_;
                    DataType en_ = AbnormalPresentation?.Effective;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                    bool ep_ = eo_ is CqlDateTime;
                    if (ep_)
                    {
                        DataType eq_ = AbnormalPresentation?.Effective;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        ed_ = er_ as CqlDateTime;
                    }
                    else
                    {
                        DataType es_ = AbnormalPresentation?.Effective;
                        object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                        bool eu_ = et_ is CqlInterval<CqlDateTime>;
                        if (eu_)
                        {
                            DataType ev_ = AbnormalPresentation?.Effective;
                            object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                            ed_ = ew_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ex_ = AbnormalPresentation?.Effective;
                            object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                            bool ez_ = ey_ is CqlDateTime;
                            if (ez_)
                            {
                                DataType fa_ = AbnormalPresentation?.Effective;
                                object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                                ed_ = fb_ as CqlDateTime;
                            }
                            else
                            {
                                ed_ = null;
                            }
                        }
                    }
                    CqlDateTime ee_ = QICoreCommon_4_0_000.Instance.earliest(context, ed_);
                    CqlDateTime ef_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? eg_ = context.Operators.SameOrBefore(ee_, ef_, (string)default);
                    Code<ObservationStatus> eh_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? ei_ = eh_?.Value;
                    string ej_ = context.Operators.Convert<string>(ei_);
                    string[] ek_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? el_ = context.Operators.In<string>(ej_, (IEnumerable<string>)ek_);
                    bool? em_ = context.Operators.And(eg_, el_);
                    return em_;
                }

                IEnumerable<Observation> dw_ = context.Operators.Where<Observation>(du_, dv_);

                object dx_(Observation @this) {
                    object fc_;
                    DataType fe_ = @this?.Effective;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    bool fg_ = ff_ is CqlDateTime;
                    if (fg_)
                    {
                        DataType fh_ = @this?.Effective;
                        object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);
                        fc_ = fi_ as CqlDateTime;
                    }
                    else
                    {
                        DataType fj_ = @this?.Effective;
                        object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                        bool fl_ = fk_ is CqlInterval<CqlDateTime>;
                        if (fl_)
                        {
                            DataType fm_ = @this?.Effective;
                            object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                            fc_ = fn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType fo_ = @this?.Effective;
                            object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                            bool fq_ = fp_ is CqlDateTime;
                            if (fq_)
                            {
                                DataType fr_ = @this?.Effective;
                                object fs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fr_);
                                fc_ = fs_ as CqlDateTime;
                            }
                            else
                            {
                                fc_ = null;
                            }
                        }
                    }
                    CqlDateTime fd_ = QICoreCommon_4_0_000.Instance.earliest(context, fc_);
                    return fd_;
                }

                IEnumerable<Observation> dy_ = context.Operators.SortBy<Observation>(dw_, dx_, System.ComponentModel.ListSortDirection.Ascending);
                Observation dz_ = context.Operators.Last<Observation>(dy_);
                DataType ea_ = dz_?.Effective;
                object eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                bool ec_ = eb_ is CqlInterval<CqlDateTime>;
                if (ec_)
                {
                    CqlValueSet ft_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> fu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ft_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? fv_(Observation AbnormalPresentation) {
                        object gc_;
                        DataType gm_ = AbnormalPresentation?.Effective;
                        object gn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gm_);
                        bool go_ = gn_ is CqlDateTime;
                        if (go_)
                        {
                            DataType gp_ = AbnormalPresentation?.Effective;
                            object gq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gp_);
                            gc_ = gq_ as CqlDateTime;
                        }
                        else
                        {
                            DataType gr_ = AbnormalPresentation?.Effective;
                            object gs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gr_);
                            bool gt_ = gs_ is CqlInterval<CqlDateTime>;
                            if (gt_)
                            {
                                DataType gu_ = AbnormalPresentation?.Effective;
                                object gv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gu_);
                                gc_ = gv_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType gw_ = AbnormalPresentation?.Effective;
                                object gx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gw_);
                                bool gy_ = gx_ is CqlDateTime;
                                if (gy_)
                                {
                                    DataType gz_ = AbnormalPresentation?.Effective;
                                    object ha_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gz_);
                                    gc_ = ha_ as CqlDateTime;
                                }
                                else
                                {
                                    gc_ = null;
                                }
                            }
                        }
                        CqlDateTime gd_ = QICoreCommon_4_0_000.Instance.earliest(context, gc_);
                        CqlDateTime ge_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? gf_ = context.Operators.SameOrBefore(gd_, ge_, (string)default);
                        Code<ObservationStatus> gg_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? gh_ = gg_?.Value;
                        string gi_ = context.Operators.Convert<string>(gh_);
                        string[] gj_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? gk_ = context.Operators.In<string>(gi_, (IEnumerable<string>)gj_);
                        bool? gl_ = context.Operators.And(gf_, gk_);
                        return gl_;
                    }

                    IEnumerable<Observation> fw_ = context.Operators.Where<Observation>(fu_, fv_);

                    object fx_(Observation @this) {
                        object hb_;
                        DataType hd_ = @this?.Effective;
                        object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                        bool hf_ = he_ is CqlDateTime;
                        if (hf_)
                        {
                            DataType hg_ = @this?.Effective;
                            object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                            hb_ = hh_ as CqlDateTime;
                        }
                        else
                        {
                            DataType hi_ = @this?.Effective;
                            object hj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hi_);
                            bool hk_ = hj_ is CqlInterval<CqlDateTime>;
                            if (hk_)
                            {
                                DataType hl_ = @this?.Effective;
                                object hm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hl_);
                                hb_ = hm_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType hn_ = @this?.Effective;
                                object ho_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hn_);
                                bool hp_ = ho_ is CqlDateTime;
                                if (hp_)
                                {
                                    DataType hq_ = @this?.Effective;
                                    object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);
                                    hb_ = hr_ as CqlDateTime;
                                }
                                else
                                {
                                    hb_ = null;
                                }
                            }
                        }
                        CqlDateTime hc_ = QICoreCommon_4_0_000.Instance.earliest(context, hb_);
                        return hc_;
                    }

                    IEnumerable<Observation> fy_ = context.Operators.SortBy<Observation>(fw_, fx_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation fz_ = context.Operators.Last<Observation>(fy_);
                    DataType ga_ = fz_?.Effective;
                    object gb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ga_);
                    d_ = gb_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    CqlValueSet hs_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> ht_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? hu_(Observation AbnormalPresentation) {
                        object ic_;
                        DataType im_ = AbnormalPresentation?.Effective;
                        object in_ = FHIRHelpers_4_4_000.Instance.ToValue(context, im_);
                        bool io_ = in_ is CqlDateTime;
                        if (io_)
                        {
                            DataType ip_ = AbnormalPresentation?.Effective;
                            object iq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ip_);
                            ic_ = iq_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ir_ = AbnormalPresentation?.Effective;
                            object is_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ir_);
                            bool it_ = is_ is CqlInterval<CqlDateTime>;
                            if (it_)
                            {
                                DataType iu_ = AbnormalPresentation?.Effective;
                                object iv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iu_);
                                ic_ = iv_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType iw_ = AbnormalPresentation?.Effective;
                                object ix_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iw_);
                                bool iy_ = ix_ is CqlDateTime;
                                if (iy_)
                                {
                                    DataType iz_ = AbnormalPresentation?.Effective;
                                    object ja_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iz_);
                                    ic_ = ja_ as CqlDateTime;
                                }
                                else
                                {
                                    ic_ = null;
                                }
                            }
                        }
                        CqlDateTime id_ = QICoreCommon_4_0_000.Instance.earliest(context, ic_);
                        CqlDateTime ie_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? if_ = context.Operators.SameOrBefore(id_, ie_, (string)default);
                        Code<ObservationStatus> ig_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ih_ = ig_?.Value;
                        string ii_ = context.Operators.Convert<string>(ih_);
                        string[] ij_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ik_ = context.Operators.In<string>(ii_, (IEnumerable<string>)ij_);
                        bool? il_ = context.Operators.And(if_, ik_);
                        return il_;
                    }

                    IEnumerable<Observation> hv_ = context.Operators.Where<Observation>(ht_, hu_);

                    object hw_(Observation @this) {
                        object jb_;
                        DataType jd_ = @this?.Effective;
                        object je_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jd_);
                        bool jf_ = je_ is CqlDateTime;
                        if (jf_)
                        {
                            DataType jg_ = @this?.Effective;
                            object jh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jg_);
                            jb_ = jh_ as CqlDateTime;
                        }
                        else
                        {
                            DataType ji_ = @this?.Effective;
                            object jj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ji_);
                            bool jk_ = jj_ is CqlInterval<CqlDateTime>;
                            if (jk_)
                            {
                                DataType jl_ = @this?.Effective;
                                object jm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jl_);
                                jb_ = jm_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType jn_ = @this?.Effective;
                                object jo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jn_);
                                bool jp_ = jo_ is CqlDateTime;
                                if (jp_)
                                {
                                    DataType jq_ = @this?.Effective;
                                    object jr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jq_);
                                    jb_ = jr_ as CqlDateTime;
                                }
                                else
                                {
                                    jb_ = null;
                                }
                            }
                        }
                        CqlDateTime jc_ = QICoreCommon_4_0_000.Instance.earliest(context, jb_);
                        return jc_;
                    }

                    IEnumerable<Observation> hx_ = context.Operators.SortBy<Observation>(hv_, hw_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation hy_ = context.Operators.Last<Observation>(hx_);
                    DataType hz_ = hy_?.Effective;
                    object ia_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hz_);
                    bool ib_ = ia_ is CqlDateTime;
                    if (ib_)
                    {
                        CqlValueSet js_ = this.Abnormal_Presentation(context);
                        IEnumerable<Observation> jt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, js_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                        bool? ju_(Observation AbnormalPresentation) {
                            object kb_;
                            DataType kl_ = AbnormalPresentation?.Effective;
                            object km_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kl_);
                            bool kn_ = km_ is CqlDateTime;
                            if (kn_)
                            {
                                DataType ko_ = AbnormalPresentation?.Effective;
                                object kp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ko_);
                                kb_ = kp_ as CqlDateTime;
                            }
                            else
                            {
                                DataType kq_ = AbnormalPresentation?.Effective;
                                object kr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kq_);
                                bool ks_ = kr_ is CqlInterval<CqlDateTime>;
                                if (ks_)
                                {
                                    DataType kt_ = AbnormalPresentation?.Effective;
                                    object ku_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kt_);
                                    kb_ = ku_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType kv_ = AbnormalPresentation?.Effective;
                                    object kw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kv_);
                                    bool kx_ = kw_ is CqlDateTime;
                                    if (kx_)
                                    {
                                        DataType ky_ = AbnormalPresentation?.Effective;
                                        object kz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ky_);
                                        kb_ = kz_ as CqlDateTime;
                                    }
                                    else
                                    {
                                        kb_ = null;
                                    }
                                }
                            }
                            CqlDateTime kc_ = QICoreCommon_4_0_000.Instance.earliest(context, kb_);
                            CqlDateTime kd_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                            bool? ke_ = context.Operators.SameOrBefore(kc_, kd_, (string)default);
                            Code<ObservationStatus> kf_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? kg_ = kf_?.Value;
                            string kh_ = context.Operators.Convert<string>(kg_);
                            string[] ki_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? kj_ = context.Operators.In<string>(kh_, (IEnumerable<string>)ki_);
                            bool? kk_ = context.Operators.And(ke_, kj_);
                            return kk_;
                        }

                        IEnumerable<Observation> jv_ = context.Operators.Where<Observation>(jt_, ju_);

                        object jw_(Observation @this) {
                            object la_;
                            DataType lc_ = @this?.Effective;
                            object ld_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lc_);
                            bool le_ = ld_ is CqlDateTime;
                            if (le_)
                            {
                                DataType lf_ = @this?.Effective;
                                object lg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lf_);
                                la_ = lg_ as CqlDateTime;
                            }
                            else
                            {
                                DataType lh_ = @this?.Effective;
                                object li_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lh_);
                                bool lj_ = li_ is CqlInterval<CqlDateTime>;
                                if (lj_)
                                {
                                    DataType lk_ = @this?.Effective;
                                    object ll_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lk_);
                                    la_ = ll_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    DataType lm_ = @this?.Effective;
                                    object ln_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lm_);
                                    bool lo_ = ln_ is CqlDateTime;
                                    if (lo_)
                                    {
                                        DataType lp_ = @this?.Effective;
                                        object lq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lp_);
                                        la_ = lq_ as CqlDateTime;
                                    }
                                    else
                                    {
                                        la_ = null;
                                    }
                                }
                            }
                            CqlDateTime lb_ = QICoreCommon_4_0_000.Instance.earliest(context, la_);
                            return lb_;
                        }

                        IEnumerable<Observation> jx_ = context.Operators.SortBy<Observation>(jv_, jw_, System.ComponentModel.ListSortDirection.Ascending);
                        Observation jy_ = context.Operators.Last<Observation>(jx_);
                        DataType jz_ = jy_?.Effective;
                        object ka_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jz_);
                        d_ = ka_ as CqlDateTime;
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
            IEnumerable<Condition> h_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? i_(Condition @this) {
                CodeableConcept lr_ = @this?.Code;
                CqlConcept ls_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lr_);
                bool? lt_ = context.Operators.Not((bool?)(ls_ is null));
                return lt_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);

            CqlConcept k_(Condition @this) {
                CodeableConcept lu_ = @this?.Code;
                CqlConcept lv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lu_);
                return lv_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<Condition, CqlConcept>(j_, k_);
            CqlValueSet m_ = this.Abnormal_Presentation(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            bool? o_ = context.Operators.Or(g_, n_);
            List<CodeableConcept> p_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept q_(CodeableConcept @this) {
                CqlConcept lw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return lw_;
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
                object j_;
                DataType r_ = CSection?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    DataType u_ = CSection?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    j_ = v_ as CqlDateTime;
                }
                else
                {
                    DataType w_ = CSection?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlInterval<CqlDateTime>;
                    if (y_)
                    {
                        DataType z_ = CSection?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        j_ = aa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ab_ = CSection?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlQuantity;
                        if (ad_)
                        {
                            DataType ae_ = CSection?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            j_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ag_ = CSection?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                DataType aj_ = CSection?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                j_ = ak_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                j_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
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
