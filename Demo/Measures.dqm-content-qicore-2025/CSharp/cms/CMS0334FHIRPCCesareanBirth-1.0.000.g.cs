#nullable enable

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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5698456684161873684L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS0334FHIRPCCesareanBirth-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (24)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5961161382796943919L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Calculated Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter?>? Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks, Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks = 5379338720289974308L;

    private IEnumerable<Encounter?>? Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter? DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? e_ = context.Operators.GreaterOrEqual(d_, 37);
            return e_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Estimated Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter?>? Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks, Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks = -4717178607510065377L;

    private IEnumerable<Encounter?>? Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter? DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity? e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity? f_ = context.Operators.Quantity(37m, "weeks");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            bool? h_ = context.Operators.And((bool?)(d_ is null), g_);
            return h_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks Based On Coding")]
    public IEnumerable<Encounter?>? Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding, Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding = -4599066492291871118L;

    private IEnumerable<Encounter?>? Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter? DeliveryEncounter) {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity? e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
            List<CodeableConcept>? g_ = DeliveryEncounter?.ReasonCode;

            CqlConcept? h_(CodeableConcept? @this) {
                CqlConcept? s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return s_;
            }

            IEnumerable<CqlConcept?>? i_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)g_, h_);
            CqlValueSet? j_ = this._37_to_42_Plus_Weeks_Gestation(context);
            bool? k_ = context.Operators.ConceptsInValueSet(i_, j_);
            IEnumerable<Condition?>? l_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? m_(Condition? @this) {
                CodeableConcept? t_ = @this?.Code;
                CqlConcept? u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                bool? v_ = context.Operators.Not((bool?)(u_ is null));
                return v_;
            }


            CqlConcept? n_(Condition? @this) {
                CodeableConcept? w_ = @this?.Code;
                CqlConcept? x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                return x_;
            }

            IEnumerable<CqlConcept?>? o_ = context.Operators.WhereSelect<Condition?, CqlConcept?>(l_, m_, n_);
            bool? p_ = context.Operators.ConceptsInValueSet(o_, j_);
            bool? q_ = context.Operators.Or(k_, p_);
            bool? r_ = context.Operators.And(f_, q_);
            return r_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter?>? Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks, Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks = 31587007512521178L;

    private IEnumerable<Encounter?>? Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter?>? b_ = this.Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter?>(a_, b_);
        IEnumerable<Encounter?>? d_ = this.Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding(context);
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With Singleton Delivery")]
    public IEnumerable<Encounter?>? Encounter_With_Singleton_Delivery(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Singleton_Delivery, Encounter_With_Singleton_Delivery_Compute);

    private const long _cacheIndex_Encounter_With_Singleton_Delivery = -277690994937978653L;

    private IEnumerable<Encounter?>? Encounter_With_Singleton_Delivery_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        bool? b_(Encounter? DeliveryEncounter) {
            List<CodeableConcept>? d_ = DeliveryEncounter?.ReasonCode;

            CqlConcept? e_(CodeableConcept? @this) {
                CqlConcept? o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept?>? f_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)d_, e_);
            CqlValueSet? g_ = this.Delivery_of_Singleton(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition?>? i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);

            bool? j_(Condition? @this) {
                CodeableConcept? p_ = @this?.Code;
                CqlConcept? q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                bool? r_ = context.Operators.Not((bool?)(q_ is null));
                return r_;
            }


            CqlConcept? k_(Condition? @this) {
                CodeableConcept? s_ = @this?.Code;
                CqlConcept? t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                return t_;
            }

            IEnumerable<CqlConcept?>? l_ = context.Operators.WhereSelect<Condition?, CqlConcept?>(i_, j_, k_);
            bool? m_ = context.Operators.ConceptsInValueSet(l_, g_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("lastGravida")]
    public int? lastGravida(CqlContext context, Encounter? TheEncounter)
    {
        CqlCode? a_ = this.____Pregnancies(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation? Gravida) {
            DataType? k_ = Gravida?.Value;
            object? l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            bool? m_ = context.Operators.Not((bool?)(l_ is null));
            Code<ObservationStatus>? n_ = Gravida?.StatusElement;
            ObservationStatus? o_ = n_?.Value;
            string? p_ = context.Operators.Convert<string?>(o_);
            string?[]? q_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? r_ = context.Operators.In<string?>(p_, (IEnumerable<string?>?)q_);
            bool? s_ = context.Operators.And(m_, r_);
            object? t_;
            DataType? ad_ = Gravida?.Effective;
            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType? ag_ = Gravida?.Effective;
                object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                t_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType? ai_ = Gravida?.Effective;
                object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    DataType? al_ = Gravida?.Effective;
                    object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    t_ = am_ as CqlDateTime;
                }
                else
                {
                    DataType? an_ = Gravida?.Effective;
                    object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType? aq_ = Gravida?.Effective;
                        object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        t_ = ar_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        t_ = null;
                    }
                }
            }
            CqlDateTime? u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            CqlDateTime? v_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity? w_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime? x_ = context.Operators.Subtract(v_, w_);
            CqlInterval<CqlDateTime?>? y_ = context.Operators.Interval(x_, v_, true, false);
            bool? z_ = context.Operators.In<CqlDateTime?>(u_, y_, (string?)default);
            bool? aa_ = context.Operators.Not((bool?)(v_ is null));
            bool? ab_ = context.Operators.And(z_, aa_);
            bool? ac_ = context.Operators.And(s_, ab_);
            return ac_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.Where<Observation?>(c_, d_);

        object f_(Observation? @this) {
            object? as_;
            DataType? au_ = @this?.Effective;
            object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType? ax_ = @this?.Effective;
                object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType? az_ = @this?.Effective;
                object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType? bc_ = @this?.Effective;
                    object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlDateTime;
                }
                else
                {
                    DataType? be_ = @this?.Effective;
                    object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    if (bg_)
                    {
                        DataType? bh_ = @this?.Effective;
                        object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime? at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_!;
        }

        IEnumerable<Observation?>? g_ = context.Operators.SortBy<Observation?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? h_ = context.Operators.Last<Observation?>(g_!);
        DataType? i_ = h_?.Value;
        object? j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlFunctionDefinition("lastParity")]
    public int? lastParity(CqlContext context, Encounter? TheEncounter)
    {
        CqlCode? a_ = this.____Parity(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation? Parity) {
            object? k_;
            DataType? ad_ = Parity?.Effective;
            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType? ag_ = Parity?.Effective;
                object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                k_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType? ai_ = Parity?.Effective;
                object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    DataType? al_ = Parity?.Effective;
                    object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    k_ = am_ as CqlDateTime;
                }
                else
                {
                    DataType? an_ = Parity?.Effective;
                    object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType? aq_ = Parity?.Effective;
                        object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        k_ = ar_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        k_ = null;
                    }
                }
            }
            CqlDateTime? l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_);
            CqlDateTime? m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity? n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime?>(l_, p_, (string?)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            Code<ObservationStatus>? t_ = Parity?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string? v_ = context.Operators.Convert<string?>(u_);
            string?[]? w_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? x_ = context.Operators.In<string?>(v_, (IEnumerable<string?>?)w_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType? z_ = Parity?.Value;
            object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(y_, ab_);
            return ac_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.Where<Observation?>(c_, d_);

        object f_(Observation? @this) {
            object? as_;
            DataType? au_ = @this?.Effective;
            object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType? ax_ = @this?.Effective;
                object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType? az_ = @this?.Effective;
                object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType? bc_ = @this?.Effective;
                    object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlDateTime;
                }
                else
                {
                    DataType? be_ = @this?.Effective;
                    object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    if (bg_)
                    {
                        DataType? bh_ = @this?.Effective;
                        object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime? at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_!;
        }

        IEnumerable<Observation?>? g_ = context.Operators.SortBy<Observation?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? h_ = context.Operators.Last<Observation?>(g_!);
        DataType? i_ = h_?.Value;
        object? j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlFunctionDefinition("lastHistoryPretermBirth")]
    public int? lastHistoryPretermBirth(CqlContext context, Encounter? TheEncounter)
    {
        CqlCode? a_ = this.____Births_preterm(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation? PretermBirth) {
            object? k_;
            DataType? ad_ = PretermBirth?.Effective;
            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType? ag_ = PretermBirth?.Effective;
                object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                k_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType? ai_ = PretermBirth?.Effective;
                object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    DataType? al_ = PretermBirth?.Effective;
                    object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    k_ = am_ as CqlDateTime;
                }
                else
                {
                    DataType? an_ = PretermBirth?.Effective;
                    object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType? aq_ = PretermBirth?.Effective;
                        object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        k_ = ar_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        k_ = null;
                    }
                }
            }
            CqlDateTime? l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_);
            CqlDateTime? m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity? n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime?>(l_, p_, (string?)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            Code<ObservationStatus>? t_ = PretermBirth?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string? v_ = context.Operators.Convert<string?>(u_);
            string?[]? w_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? x_ = context.Operators.In<string?>(v_, (IEnumerable<string?>?)w_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType? z_ = PretermBirth?.Value;
            object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(y_, ab_);
            return ac_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.Where<Observation?>(c_, d_);

        object f_(Observation? @this) {
            object? as_;
            DataType? au_ = @this?.Effective;
            object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType? ax_ = @this?.Effective;
                object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType? az_ = @this?.Effective;
                object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType? bc_ = @this?.Effective;
                    object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlDateTime;
                }
                else
                {
                    DataType? be_ = @this?.Effective;
                    object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    if (bg_)
                    {
                        DataType? bh_ = @this?.Effective;
                        object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime? at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_!;
        }

        IEnumerable<Observation?>? g_ = context.Operators.SortBy<Observation?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? h_ = context.Operators.Last<Observation?>(g_!);
        DataType? i_ = h_?.Value;
        object? j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlFunctionDefinition("lastHistoryTermBirth")]
    public int? lastHistoryTermBirth(CqlContext context, Encounter? TheEncounter)
    {
        CqlCode? a_ = this.____Births_term(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode?>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation? TermBirth) {
            object? k_;
            DataType? ad_ = TermBirth?.Effective;
            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType? ag_ = TermBirth?.Effective;
                object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                k_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType? ai_ = TermBirth?.Effective;
                object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    DataType? al_ = TermBirth?.Effective;
                    object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    k_ = am_ as CqlDateTime;
                }
                else
                {
                    DataType? an_ = TermBirth?.Effective;
                    object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType? aq_ = TermBirth?.Effective;
                        object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        k_ = ar_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        k_ = null;
                    }
                }
            }
            CqlDateTime? l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_);
            CqlDateTime? m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity? n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime? o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(o_, m_, true, false);
            bool? q_ = context.Operators.In<CqlDateTime?>(l_, p_, (string?)default);
            bool? r_ = context.Operators.Not((bool?)(m_ is null));
            bool? s_ = context.Operators.And(q_, r_);
            Code<ObservationStatus>? t_ = TermBirth?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string? v_ = context.Operators.Convert<string?>(u_);
            string?[]? w_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? x_ = context.Operators.In<string?>(v_, (IEnumerable<string?>?)w_);
            bool? y_ = context.Operators.And(s_, x_);
            DataType? z_ = TermBirth?.Value;
            object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ac_ = context.Operators.And(y_, ab_);
            return ac_;
        }

        IEnumerable<Observation?>? e_ = context.Operators.Where<Observation?>(c_, d_);

        object f_(Observation? @this) {
            object? as_;
            DataType? au_ = @this?.Effective;
            object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            bool aw_ = av_ is CqlDateTime;
            if (aw_)
            {
                DataType? ax_ = @this?.Effective;
                object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                as_ = ay_ as CqlDateTime;
            }
            else
            {
                DataType? az_ = @this?.Effective;
                object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType? bc_ = @this?.Effective;
                    object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlDateTime;
                }
                else
                {
                    DataType? be_ = @this?.Effective;
                    object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    if (bg_)
                    {
                        DataType? bh_ = @this?.Effective;
                        object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        as_ = null;
                    }
                }
            }
            CqlDateTime? at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_);
            return at_!;
        }

        IEnumerable<Observation?>? g_ = context.Operators.SortBy<Observation?>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation? h_ = context.Operators.Last<Observation?>(g_!);
        DataType? i_ = h_?.Value;
        object? j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as int?;
    }


    [CqlExpressionDefinition("Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter?>? Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births, Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Compute);

    private const long _cacheIndex_Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births = -1799350301391375704L;

    private IEnumerable<Encounter?>? Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter?>? b_ = this.Encounter_With_Singleton_Delivery(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Intersect<Encounter?>(a_, b_);

        bool? d_(Encounter? SingletonEncounterGE37Weeks) {
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

        IEnumerable<Encounter?>? e_ = context.Operators.Where<Encounter?>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With Abnormal Presentation")]
    public IEnumerable<Encounter?>? Encounter_With_Abnormal_Presentation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Abnormal_Presentation, Encounter_With_Abnormal_Presentation_Compute);

    private const long _cacheIndex_Encounter_With_Abnormal_Presentation = 4272829473243556987L;

    private IEnumerable<Encounter?>? Encounter_With_Abnormal_Presentation_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        bool? b_(Encounter? ThirtySevenWeeksPlusEncounter) {
            object? d_;
            CqlValueSet? t_ = this.Abnormal_Presentation(context);
            IEnumerable<Observation?>? u_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

            bool? v_(Observation? AbnormalPresentation) {
                object? ad_;
                DataType? an_ = AbnormalPresentation?.Effective;
                object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                bool ap_ = ao_ is CqlDateTime;
                if (ap_)
                {
                    DataType? aq_ = AbnormalPresentation?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    ad_ = ar_ as CqlDateTime;
                }
                else
                {
                    DataType? as_ = AbnormalPresentation?.Effective;
                    object? at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlDateTime;
                    if (au_)
                    {
                        DataType? av_ = AbnormalPresentation?.Effective;
                        object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        ad_ = aw_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? ax_ = AbnormalPresentation?.Effective;
                        object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        bool az_ = ay_ is CqlInterval<CqlDateTime>;
                        if (az_)
                        {
                            DataType? ba_ = AbnormalPresentation?.Effective;
                            object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                            ad_ = bb_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            ad_ = null;
                        }
                    }
                }
                CqlDateTime? ae_ = QICoreCommon_4_0_000.Instance.earliest(context, ad_);
                CqlDateTime? af_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                bool? ag_ = context.Operators.SameOrBefore(ae_, af_, (string?)default);
                Code<ObservationStatus>? ah_ = AbnormalPresentation?.StatusElement;
                ObservationStatus? ai_ = ah_?.Value;
                string? aj_ = context.Operators.Convert<string?>(ai_);
                string?[]? ak_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? al_ = context.Operators.In<string?>(aj_, (IEnumerable<string?>?)ak_);
                bool? am_ = context.Operators.And(ag_, al_);
                return am_;
            }

            IEnumerable<Observation?>? w_ = context.Operators.Where<Observation?>(u_, v_);

            object x_(Observation? @this) {
                object? bc_;
                DataType? be_ = @this?.Effective;
                object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                bool bg_ = bf_ is CqlDateTime;
                if (bg_)
                {
                    DataType? bh_ = @this?.Effective;
                    object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bc_ = bi_ as CqlDateTime;
                }
                else
                {
                    DataType? bj_ = @this?.Effective;
                    object? bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlDateTime;
                    if (bl_)
                    {
                        DataType? bm_ = @this?.Effective;
                        object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bc_ = bn_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? bo_ = @this?.Effective;
                        object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlInterval<CqlDateTime>;
                        if (bq_)
                        {
                            DataType? br_ = @this?.Effective;
                            object? bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                            bc_ = bs_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            bc_ = null;
                        }
                    }
                }
                CqlDateTime? bd_ = QICoreCommon_4_0_000.Instance.earliest(context, bc_);
                return bd_!;
            }

            IEnumerable<Observation?>? y_ = context.Operators.SortBy<Observation?>(w_, x_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? z_ = context.Operators.Last<Observation?>(y_!);
            DataType? aa_ = z_?.Effective;
            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                CqlValueSet? bt_ = this.Abnormal_Presentation(context);
                IEnumerable<Observation?>? bu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                bool? bv_(Observation? AbnormalPresentation) {
                    object? cc_;
                    DataType? cm_ = AbnormalPresentation?.Effective;
                    object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlDateTime;
                    if (co_)
                    {
                        DataType? cp_ = AbnormalPresentation?.Effective;
                        object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        cc_ = cq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cr_ = AbnormalPresentation?.Effective;
                        object? cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        bool ct_ = cs_ is CqlDateTime;
                        if (ct_)
                        {
                            DataType? cu_ = AbnormalPresentation?.Effective;
                            object? cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                            cc_ = cv_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? cw_ = AbnormalPresentation?.Effective;
                            object? cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                            bool cy_ = cx_ is CqlInterval<CqlDateTime>;
                            if (cy_)
                            {
                                DataType? cz_ = AbnormalPresentation?.Effective;
                                object? da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                                cc_ = da_ as CqlInterval<CqlDateTime?>;
                            }
                            else
                            {
                                cc_ = null;
                            }
                        }
                    }
                    CqlDateTime? cd_ = QICoreCommon_4_0_000.Instance.earliest(context, cc_);
                    CqlDateTime? ce_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? cf_ = context.Operators.SameOrBefore(cd_, ce_, (string?)default);
                    Code<ObservationStatus>? cg_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? ch_ = cg_?.Value;
                    string? ci_ = context.Operators.Convert<string?>(ch_);
                    string?[]? cj_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ck_ = context.Operators.In<string?>(ci_, (IEnumerable<string?>?)cj_);
                    bool? cl_ = context.Operators.And(cf_, ck_);
                    return cl_;
                }

                IEnumerable<Observation?>? bw_ = context.Operators.Where<Observation?>(bu_, bv_);

                object bx_(Observation? @this) {
                    object? db_;
                    DataType? dd_ = @this?.Effective;
                    object? de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlDateTime;
                    if (df_)
                    {
                        DataType? dg_ = @this?.Effective;
                        object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        db_ = dh_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? di_ = @this?.Effective;
                        object? dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlDateTime;
                        if (dk_)
                        {
                            DataType? dl_ = @this?.Effective;
                            object? dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            db_ = dm_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? dn_ = @this?.Effective;
                            object? do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                            bool dp_ = do_ is CqlInterval<CqlDateTime>;
                            if (dp_)
                            {
                                DataType? dq_ = @this?.Effective;
                                object? dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                                db_ = dr_ as CqlInterval<CqlDateTime?>;
                            }
                            else
                            {
                                db_ = null;
                            }
                        }
                    }
                    CqlDateTime? dc_ = QICoreCommon_4_0_000.Instance.earliest(context, db_);
                    return dc_!;
                }

                IEnumerable<Observation?>? by_ = context.Operators.SortBy<Observation?>(bw_, bx_, System.ComponentModel.ListSortDirection.Ascending);
                Observation? bz_ = context.Operators.Last<Observation?>(by_!);
                DataType? ca_ = bz_?.Effective;
                object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                d_ = cb_ as CqlDateTime;
            }
            else
            {
                CqlValueSet? ds_ = this.Abnormal_Presentation(context);
                IEnumerable<Observation?>? dt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ds_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                bool? du_(Observation? AbnormalPresentation) {
                    object? ec_;
                    DataType? em_ = AbnormalPresentation?.Effective;
                    object? en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlDateTime;
                    if (eo_)
                    {
                        DataType? ep_ = AbnormalPresentation?.Effective;
                        object? eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                        ec_ = eq_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? er_ = AbnormalPresentation?.Effective;
                        object? es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                        bool et_ = es_ is CqlDateTime;
                        if (et_)
                        {
                            DataType? eu_ = AbnormalPresentation?.Effective;
                            object? ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                            ec_ = ev_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? ew_ = AbnormalPresentation?.Effective;
                            object? ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                            bool ey_ = ex_ is CqlInterval<CqlDateTime>;
                            if (ey_)
                            {
                                DataType? ez_ = AbnormalPresentation?.Effective;
                                object? fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                                ec_ = fa_ as CqlInterval<CqlDateTime?>;
                            }
                            else
                            {
                                ec_ = null;
                            }
                        }
                    }
                    CqlDateTime? ed_ = QICoreCommon_4_0_000.Instance.earliest(context, ec_);
                    CqlDateTime? ee_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                    bool? ef_ = context.Operators.SameOrBefore(ed_, ee_, (string?)default);
                    Code<ObservationStatus>? eg_ = AbnormalPresentation?.StatusElement;
                    ObservationStatus? eh_ = eg_?.Value;
                    string? ei_ = context.Operators.Convert<string?>(eh_);
                    string?[]? ej_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ek_ = context.Operators.In<string?>(ei_, (IEnumerable<string?>?)ej_);
                    bool? el_ = context.Operators.And(ef_, ek_);
                    return el_;
                }

                IEnumerable<Observation?>? dv_ = context.Operators.Where<Observation?>(dt_, du_);

                object dw_(Observation? @this) {
                    object? fb_;
                    DataType? fd_ = @this?.Effective;
                    object? fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlDateTime;
                    if (ff_)
                    {
                        DataType? fg_ = @this?.Effective;
                        object? fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                        fb_ = fh_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? fi_ = @this?.Effective;
                        object? fj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fi_);
                        bool fk_ = fj_ is CqlDateTime;
                        if (fk_)
                        {
                            DataType? fl_ = @this?.Effective;
                            object? fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);
                            fb_ = fm_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? fn_ = @this?.Effective;
                            object? fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);
                            bool fp_ = fo_ is CqlInterval<CqlDateTime>;
                            if (fp_)
                            {
                                DataType? fq_ = @this?.Effective;
                                object? fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                                fb_ = fr_ as CqlInterval<CqlDateTime?>;
                            }
                            else
                            {
                                fb_ = null;
                            }
                        }
                    }
                    CqlDateTime? fc_ = QICoreCommon_4_0_000.Instance.earliest(context, fb_);
                    return fc_!;
                }

                IEnumerable<Observation?>? dx_ = context.Operators.SortBy<Observation?>(dv_, dw_, System.ComponentModel.ListSortDirection.Ascending);
                Observation? dy_ = context.Operators.Last<Observation?>(dx_!);
                DataType? dz_ = dy_?.Effective;
                object? ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                bool eb_ = ea_ is CqlDateTime;
                if (eb_)
                {
                    CqlValueSet? fs_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation?>? ft_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? fu_(Observation? AbnormalPresentation) {
                        object? gb_;
                        DataType? gl_ = AbnormalPresentation?.Effective;
                        object? gm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gl_);
                        bool gn_ = gm_ is CqlDateTime;
                        if (gn_)
                        {
                            DataType? go_ = AbnormalPresentation?.Effective;
                            object? gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);
                            gb_ = gp_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? gq_ = AbnormalPresentation?.Effective;
                            object? gr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gq_);
                            bool gs_ = gr_ is CqlDateTime;
                            if (gs_)
                            {
                                DataType? gt_ = AbnormalPresentation?.Effective;
                                object? gu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gt_);
                                gb_ = gu_ as CqlDateTime;
                            }
                            else
                            {
                                DataType? gv_ = AbnormalPresentation?.Effective;
                                object? gw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gv_);
                                bool gx_ = gw_ is CqlInterval<CqlDateTime>;
                                if (gx_)
                                {
                                    DataType? gy_ = AbnormalPresentation?.Effective;
                                    object? gz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gy_);
                                    gb_ = gz_ as CqlInterval<CqlDateTime?>;
                                }
                                else
                                {
                                    gb_ = null;
                                }
                            }
                        }
                        CqlDateTime? gc_ = QICoreCommon_4_0_000.Instance.earliest(context, gb_);
                        CqlDateTime? gd_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ge_ = context.Operators.SameOrBefore(gc_, gd_, (string?)default);
                        Code<ObservationStatus>? gf_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? gg_ = gf_?.Value;
                        string? gh_ = context.Operators.Convert<string?>(gg_);
                        string?[]? gi_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? gj_ = context.Operators.In<string?>(gh_, (IEnumerable<string?>?)gi_);
                        bool? gk_ = context.Operators.And(ge_, gj_);
                        return gk_;
                    }

                    IEnumerable<Observation?>? fv_ = context.Operators.Where<Observation?>(ft_, fu_);

                    object fw_(Observation? @this) {
                        object? ha_;
                        DataType? hc_ = @this?.Effective;
                        object? hd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hc_);
                        bool he_ = hd_ is CqlDateTime;
                        if (he_)
                        {
                            DataType? hf_ = @this?.Effective;
                            object? hg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hf_);
                            ha_ = hg_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? hh_ = @this?.Effective;
                            object? hi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hh_);
                            bool hj_ = hi_ is CqlDateTime;
                            if (hj_)
                            {
                                DataType? hk_ = @this?.Effective;
                                object? hl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hk_);
                                ha_ = hl_ as CqlDateTime;
                            }
                            else
                            {
                                DataType? hm_ = @this?.Effective;
                                object? hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);
                                bool ho_ = hn_ is CqlInterval<CqlDateTime>;
                                if (ho_)
                                {
                                    DataType? hp_ = @this?.Effective;
                                    object? hq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hp_);
                                    ha_ = hq_ as CqlInterval<CqlDateTime?>;
                                }
                                else
                                {
                                    ha_ = null;
                                }
                            }
                        }
                        CqlDateTime? hb_ = QICoreCommon_4_0_000.Instance.earliest(context, ha_);
                        return hb_!;
                    }

                    IEnumerable<Observation?>? fx_ = context.Operators.SortBy<Observation?>(fv_, fw_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation? fy_ = context.Operators.Last<Observation?>(fx_!);
                    DataType? fz_ = fy_?.Effective;
                    object? ga_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fz_);
                    d_ = ga_ as CqlDateTime;
                }
                else
                {
                    CqlValueSet? hr_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation?>? hs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                    bool? ht_(Observation? AbnormalPresentation) {
                        object? ib_;
                        DataType? il_ = AbnormalPresentation?.Effective;
                        object? im_ = FHIRHelpers_4_4_000.Instance.ToValue(context, il_);
                        bool in_ = im_ is CqlDateTime;
                        if (in_)
                        {
                            DataType? io_ = AbnormalPresentation?.Effective;
                            object? ip_ = FHIRHelpers_4_4_000.Instance.ToValue(context, io_);
                            ib_ = ip_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? iq_ = AbnormalPresentation?.Effective;
                            object? ir_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iq_);
                            bool is_ = ir_ is CqlDateTime;
                            if (is_)
                            {
                                DataType? it_ = AbnormalPresentation?.Effective;
                                object? iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);
                                ib_ = iu_ as CqlDateTime;
                            }
                            else
                            {
                                DataType? iv_ = AbnormalPresentation?.Effective;
                                object? iw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iv_);
                                bool ix_ = iw_ is CqlInterval<CqlDateTime>;
                                if (ix_)
                                {
                                    DataType? iy_ = AbnormalPresentation?.Effective;
                                    object? iz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, iy_);
                                    ib_ = iz_ as CqlInterval<CqlDateTime?>;
                                }
                                else
                                {
                                    ib_ = null;
                                }
                            }
                        }
                        CqlDateTime? ic_ = QICoreCommon_4_0_000.Instance.earliest(context, ib_);
                        CqlDateTime? id_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ie_ = context.Operators.SameOrBefore(ic_, id_, (string?)default);
                        Code<ObservationStatus>? if_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ig_ = if_?.Value;
                        string? ih_ = context.Operators.Convert<string?>(ig_);
                        string?[]? ii_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ij_ = context.Operators.In<string?>(ih_, (IEnumerable<string?>?)ii_);
                        bool? ik_ = context.Operators.And(ie_, ij_);
                        return ik_;
                    }

                    IEnumerable<Observation?>? hu_ = context.Operators.Where<Observation?>(hs_, ht_);

                    object hv_(Observation? @this) {
                        object? ja_;
                        DataType? jc_ = @this?.Effective;
                        object? jd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jc_);
                        bool je_ = jd_ is CqlDateTime;
                        if (je_)
                        {
                            DataType? jf_ = @this?.Effective;
                            object? jg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jf_);
                            ja_ = jg_ as CqlDateTime;
                        }
                        else
                        {
                            DataType? jh_ = @this?.Effective;
                            object? ji_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jh_);
                            bool jj_ = ji_ is CqlDateTime;
                            if (jj_)
                            {
                                DataType? jk_ = @this?.Effective;
                                object? jl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jk_);
                                ja_ = jl_ as CqlDateTime;
                            }
                            else
                            {
                                DataType? jm_ = @this?.Effective;
                                object? jn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jm_);
                                bool jo_ = jn_ is CqlInterval<CqlDateTime>;
                                if (jo_)
                                {
                                    DataType? jp_ = @this?.Effective;
                                    object? jq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jp_);
                                    ja_ = jq_ as CqlInterval<CqlDateTime?>;
                                }
                                else
                                {
                                    ja_ = null;
                                }
                            }
                        }
                        CqlDateTime? jb_ = QICoreCommon_4_0_000.Instance.earliest(context, ja_);
                        return jb_!;
                    }

                    IEnumerable<Observation?>? hw_ = context.Operators.SortBy<Observation?>(hu_, hv_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation? hx_ = context.Operators.Last<Observation?>(hw_!);
                    DataType? hy_ = hx_?.Effective;
                    object? hz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hy_);
                    bool ia_ = hz_ is CqlInterval<CqlDateTime>;
                    if (ia_)
                    {
                        CqlValueSet? jr_ = this.Abnormal_Presentation(context);
                        IEnumerable<Observation?>? js_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

                        bool? jt_(Observation? AbnormalPresentation) {
                            object? ka_;
                            DataType? kk_ = AbnormalPresentation?.Effective;
                            object? kl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kk_);
                            bool km_ = kl_ is CqlDateTime;
                            if (km_)
                            {
                                DataType? kn_ = AbnormalPresentation?.Effective;
                                object? ko_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kn_);
                                ka_ = ko_ as CqlDateTime;
                            }
                            else
                            {
                                DataType? kp_ = AbnormalPresentation?.Effective;
                                object? kq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kp_);
                                bool kr_ = kq_ is CqlDateTime;
                                if (kr_)
                                {
                                    DataType? ks_ = AbnormalPresentation?.Effective;
                                    object? kt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ks_);
                                    ka_ = kt_ as CqlDateTime;
                                }
                                else
                                {
                                    DataType? ku_ = AbnormalPresentation?.Effective;
                                    object? kv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ku_);
                                    bool kw_ = kv_ is CqlInterval<CqlDateTime>;
                                    if (kw_)
                                    {
                                        DataType? kx_ = AbnormalPresentation?.Effective;
                                        object? ky_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kx_);
                                        ka_ = ky_ as CqlInterval<CqlDateTime?>;
                                    }
                                    else
                                    {
                                        ka_ = null;
                                    }
                                }
                            }
                            CqlDateTime? kb_ = QICoreCommon_4_0_000.Instance.earliest(context, ka_);
                            CqlDateTime? kc_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                            bool? kd_ = context.Operators.SameOrBefore(kb_, kc_, (string?)default);
                            Code<ObservationStatus>? ke_ = AbnormalPresentation?.StatusElement;
                            ObservationStatus? kf_ = ke_?.Value;
                            string? kg_ = context.Operators.Convert<string?>(kf_);
                            string?[]? kh_ = [
                                "final",
                                "amended",
                                "corrected",
                            ];
                            bool? ki_ = context.Operators.In<string?>(kg_, (IEnumerable<string?>?)kh_);
                            bool? kj_ = context.Operators.And(kd_, ki_);
                            return kj_;
                        }

                        IEnumerable<Observation?>? ju_ = context.Operators.Where<Observation?>(js_, jt_);

                        object jv_(Observation? @this) {
                            object? kz_;
                            DataType? lb_ = @this?.Effective;
                            object? lc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lb_);
                            bool ld_ = lc_ is CqlDateTime;
                            if (ld_)
                            {
                                DataType? le_ = @this?.Effective;
                                object? lf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, le_);
                                kz_ = lf_ as CqlDateTime;
                            }
                            else
                            {
                                DataType? lg_ = @this?.Effective;
                                object? lh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lg_);
                                bool li_ = lh_ is CqlDateTime;
                                if (li_)
                                {
                                    DataType? lj_ = @this?.Effective;
                                    object? lk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lj_);
                                    kz_ = lk_ as CqlDateTime;
                                }
                                else
                                {
                                    DataType? ll_ = @this?.Effective;
                                    object? lm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ll_);
                                    bool ln_ = lm_ is CqlInterval<CqlDateTime>;
                                    if (ln_)
                                    {
                                        DataType? lo_ = @this?.Effective;
                                        object? lp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lo_);
                                        kz_ = lp_ as CqlInterval<CqlDateTime?>;
                                    }
                                    else
                                    {
                                        kz_ = null;
                                    }
                                }
                            }
                            CqlDateTime? la_ = QICoreCommon_4_0_000.Instance.earliest(context, kz_);
                            return la_!;
                        }

                        IEnumerable<Observation?>? jw_ = context.Operators.SortBy<Observation?>(ju_, jv_, System.ComponentModel.ListSortDirection.Ascending);
                        Observation? jx_ = context.Operators.Last<Observation?>(jw_!);
                        DataType? jy_ = jx_?.Effective;
                        object? jz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jy_);
                        d_ = jz_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        d_ = null;
                    }
                }
            }
            CqlDateTime? e_ = QICoreCommon_4_0_000.Instance.earliest(context, d_);
            CqlInterval<CqlDateTime?>? f_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
            bool? g_ = context.Operators.In<CqlDateTime?>(e_, f_, (string?)default);
            IEnumerable<Condition?>? h_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? i_(Condition? @this) {
                CodeableConcept? lq_ = @this?.Code;
                CqlConcept? lr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lq_);
                bool? ls_ = context.Operators.Not((bool?)(lr_ is null));
                return ls_;
            }


            CqlConcept? j_(Condition? @this) {
                CodeableConcept? lt_ = @this?.Code;
                CqlConcept? lu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lt_);
                return lu_;
            }

            IEnumerable<CqlConcept?>? k_ = context.Operators.WhereSelect<Condition?, CqlConcept?>(h_, i_, j_);
            CqlValueSet? l_ = this.Abnormal_Presentation(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            bool? n_ = context.Operators.Or(g_, m_);
            List<CodeableConcept>? o_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept? p_(CodeableConcept? @this) {
                CqlConcept? lv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return lv_;
            }

            IEnumerable<CqlConcept?>? q_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)o_, p_);
            bool? r_ = context.Operators.ConceptsInValueSet(q_, l_);
            bool? s_ = context.Operators.Or(n_, r_);
            return s_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter?>? Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum, Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute);

    private const long _cacheIndex_Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum = -2782160851625608974L;

    private IEnumerable<Encounter?>? Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        bool? b_(Encounter? ThirtySevenWeeksPlusEncounter) {
            IEnumerable<Condition?>? d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);

            bool? e_(Condition? @this) {
                CodeableConcept? y_ = @this?.Code;
                CqlConcept? z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                return aa_;
            }


            CqlConcept? f_(Condition? @this) {
                CodeableConcept? ab_ = @this?.Code;
                CqlConcept? ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
                return ac_;
            }

            IEnumerable<CqlConcept?>? g_ = context.Operators.WhereSelect<Condition?, CqlConcept?>(d_, e_, f_);
            CqlValueSet? h_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);

            bool? j_(Condition? @this) {
                CodeableConcept? ad_ = @this?.Code;
                CqlConcept? ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                return af_;
            }


            CqlConcept? k_(Condition? @this) {
                CodeableConcept? ag_ = @this?.Code;
                CqlConcept? ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);
                return ah_;
            }

            IEnumerable<CqlConcept?>? l_ = context.Operators.WhereSelect<Condition?, CqlConcept?>(d_, j_, k_);
            CqlValueSet? m_ = this.Genital_Herpes(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            bool? o_ = context.Operators.Or(i_, n_);
            List<CodeableConcept>? p_ = ThirtySevenWeeksPlusEncounter?.ReasonCode;

            CqlConcept? q_(CodeableConcept? @this) {
                CqlConcept? ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ai_;
            }

            IEnumerable<CqlConcept?>? r_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)p_, q_);
            bool? s_ = context.Operators.ConceptsInValueSet(r_, m_);
            bool? t_ = context.Operators.Or(o_, s_);

            CqlConcept? u_(CodeableConcept? @this) {
                CqlConcept? aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return aj_;
            }

            IEnumerable<CqlConcept?>? v_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)p_, u_);
            bool? w_ = context.Operators.ConceptsInValueSet(v_, h_);
            bool? x_ = context.Operators.Or(t_, w_);
            return x_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter?>? Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum, Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum = 8000357963463375481L;

    private IEnumerable<Encounter?>? Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_With_Abnormal_Presentation(context);
        IEnumerable<Encounter?>? b_ = this.Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter?>? c_ = context.Operators.Union<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -8664603006890304414L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter?>? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2734807720100010848L;

    private IEnumerable<Encounter?>? Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(context);
        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter?>? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1892918681008019555L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);
        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Cesarean Birth")]
    public IEnumerable<Encounter?>? Delivery_Encounter_With_Cesarean_Birth(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Cesarean_Birth, Delivery_Encounter_With_Cesarean_Birth_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Cesarean_Birth = 4719930836019446583L;

    private IEnumerable<Encounter?>? Delivery_Encounter_With_Cesarean_Birth_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        bool? b_(Encounter? ThirtySevenWeeksPlusEncounter) {
            CqlValueSet? d_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure? CSection) {
                CqlInterval<CqlDateTime?>? h_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
                object? i_;
                DataType? q_ = CSection?.Performed;
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlDateTime;
                if (s_)
                {
                    DataType? t_ = CSection?.Performed;
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    i_ = u_ as CqlDateTime;
                }
                else
                {
                    DataType? v_ = CSection?.Performed;
                    object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType? y_ = CSection?.Performed;
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        i_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType? aa_ = CSection?.Performed;
                        object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        if (ac_)
                        {
                            DataType? ad_ = CSection?.Performed;
                            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            i_ = ae_ as CqlInterval<CqlDateTime?>;
                        }
                        else
                        {
                            DataType? af_ = CSection?.Performed;
                            object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                DataType? ai_ = CSection?.Performed;
                                object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                i_ = aj_ as CqlInterval<CqlQuantity?>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(h_, j_, (string?)default);
                Code<EventStatus>? l_ = CSection?.StatusElement;
                EventStatus? m_ = l_?.Value;
                string? n_ = context.Operators.Convert<string?>(m_);
                bool? o_ = context.Operators.Equal(n_, "completed");
                bool? p_ = context.Operators.And(k_, o_);
                return p_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure?>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 3728176582968890656L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Delivery_Encounter_With_Cesarean_Birth(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 9142028828367787573L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7839211395831048092L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -930507570789787426L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 6216205408863169115L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string? EncounterID, int? CalculatedCGA)?>? SDE_Variable_Calculated_Gestational_Age(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Variable_Calculated_Gestational_Age, SDE_Variable_Calculated_Gestational_Age_Compute);

    private const long _cacheIndex_SDE_Variable_Calculated_Gestational_Age = -5401214914748415782L;

    private IEnumerable<(CqlTupleMetadata, string? EncounterID, int? CalculatedCGA)?>? SDE_Variable_Calculated_Gestational_Age_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string? EncounterID, int? CalculatedCGA)?>? a_ = PCMaternal_5_25_000.Instance.Variable_Calculated_Gestational_Age(context);
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
