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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS0334FHIRPCCesareanBirth", "0.6.000")]
public partial class CMS0334FHIRPCCesareanBirth_0_6_000 : ILibrary, ISingleton<CMS0334FHIRPCCesareanBirth_0_6_000>
{
    private CMS0334FHIRPCCesareanBirth_0_6_000() {}

    public static CMS0334FHIRPCCesareanBirth_0_6_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS0334FHIRPCCesareanBirth";
    public string Version => "0.6.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, PCMaternal_5_25_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Abnormal Presentation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", valueSetVersion: null)]
    public CqlValueSet Abnormal_Presentation(CqlContext _) => _Abnormal_Presentation;
    private static readonly CqlValueSet _Abnormal_Presentation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", null);

    [CqlValueSetDefinition("Cesarean Birth", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", valueSetVersion: null)]
    public CqlValueSet Cesarean_Birth(CqlContext _) => _Cesarean_Birth;
    private static readonly CqlValueSet _Cesarean_Birth = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", null);

    [CqlValueSetDefinition("Delivery of Singleton", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", valueSetVersion: null)]
    public CqlValueSet Delivery_of_Singleton(CqlContext _) => _Delivery_of_Singleton;
    private static readonly CqlValueSet _Delivery_of_Singleton = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", null);

    [CqlValueSetDefinition("Delivery Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext _) => _Delivery_Procedures;
    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

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

    #region Codes

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

    [CqlCodeDefinition("Date and time of obstetric delivery", codeId: "93857-1", codeSystem: "http://loinc.org")]
    public CqlCode Date_and_time_of_obstetric_delivery(CqlContext _) => _Date_and_time_of_obstetric_delivery;
    private static readonly CqlCode _Date_and_time_of_obstetric_delivery = new CqlCode("93857-1", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _____Births_preterm,
          _____Births_term,
          _____Parity,
          _____Pregnancies,
          _Date_and_time_of_obstetric_delivery]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS0334FHIRPCCesareanBirth-0.6.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Calculated Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            bool? e_ = context.Operators.GreaterOrEqual(d_, 37);

            return e_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Estimated Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity f_ = context.Operators.Quantity(37m, "weeks");
            bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
            bool? h_ = context.Operators.And((bool?)(d_ is null), g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks Based On Coding")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            int? d_ = PCMaternal_5_25_000.Instance.calculatedGestationalAge(context, DeliveryEncounter);
            CqlQuantity e_ = PCMaternal_5_25_000.Instance.lastEstimatedGestationalAge(context, DeliveryEncounter);
            bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
            IEnumerable<object> g_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? h_(object EncounterDiagnosis)
            {
                object l_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_ as CodeableConcept);
                CqlValueSet n_ = this._37_to_42_Plus_Weeks_Gestation(context);
                bool? o_ = context.Operators.ConceptInValueSet(m_, n_);

                return o_;
            };
            IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
            bool? j_ = context.Operators.Exists<object>(i_);
            bool? k_ = context.Operators.And(f_, j_);

            return k_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Calculated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter> b_ = this.Delivery_Encounter_With_Estimated_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks_Based_On_Coding(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Encounter With Singleton Delivery")]
    public IEnumerable<Encounter> Encounter_With_Singleton_Delivery(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);
        bool? b_(Encounter DeliveryEncounter)
        {
            List<CodeableConcept> d_ = DeliveryEncounter?.ReasonCode;
            CqlConcept e_(CodeableConcept @this)
            {
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return q_;
            };
            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Delivery_of_Singleton(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<object> i_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, DeliveryEncounter);
            bool? j_(object @this)
            {
                object r_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                bool? t_ = context.Operators.Not((bool?)(s_ is null));

                return t_;
            };
            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);
            CqlConcept l_(object @this)
            {
                object u_ = context.Operators.LateBoundProperty<object>(@this, "code");
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);

                return v_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<object, CqlConcept>(k_, l_);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? p_ = context.Operators.Or(h_, o_);

            return p_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlFunctionDefinition("lastGravida")]
    public int? lastGravida(CqlContext context, Encounter TheEncounter)
    {
        CqlCode a_ = this.____Pregnancies(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
        bool? d_(Observation Gravida)
        {
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
            bool? r_ = context.Operators.In<string>(p_, q_ as IEnumerable<string>);
            bool? s_ = context.Operators.And(m_, r_);
            object t_()
            {
                bool af_()
                {
                    DataType ai_ = Gravida?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;

                    return ak_;
                };
                bool ag_()
                {
                    DataType al_ = Gravida?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;

                    return an_;
                };
                bool ah_()
                {
                    DataType ao_ = Gravida?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;

                    return aq_;
                };
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
                }
            };
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
            CqlDateTime v_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity w_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime x_ = context.Operators.Subtract(v_, w_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(x_, v_, true, false);
            bool? aa_ = context.Operators.In<CqlDateTime>(u_, z_, default);
            bool? ac_ = context.Operators.Not((bool?)(v_ is null));
            bool? ad_ = context.Operators.And(aa_, ac_);
            bool? ae_ = context.Operators.And(s_, ad_);

            return ae_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object ax_()
            {
                bool az_()
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;

                    return be_;
                };
                bool ba_()
                {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;

                    return bh_;
                };
                bool bb_()
                {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;

                    return bk_;
                };
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
                }
            };
            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());

            return ay_;
        };
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
        bool? d_(Observation Parity)
        {
            object k_()
            {
                bool af_()
                {
                    DataType ai_ = Parity?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;

                    return ak_;
                };
                bool ag_()
                {
                    DataType al_ = Parity?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;

                    return an_;
                };
                bool ah_()
                {
                    DataType ao_ = Parity?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;

                    return aq_;
                };
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
                }
            };
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, default);
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
            bool? z_ = context.Operators.In<string>(x_, y_ as IEnumerable<string>);
            bool? aa_ = context.Operators.And(u_, z_);
            DataType ab_ = Parity?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);

            return ae_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object ax_()
            {
                bool az_()
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;

                    return be_;
                };
                bool ba_()
                {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;

                    return bh_;
                };
                bool bb_()
                {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;

                    return bk_;
                };
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
                }
            };
            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());

            return ay_;
        };
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
        bool? d_(Observation PretermBirth)
        {
            object k_()
            {
                bool af_()
                {
                    DataType ai_ = PretermBirth?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;

                    return ak_;
                };
                bool ag_()
                {
                    DataType al_ = PretermBirth?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;

                    return an_;
                };
                bool ah_()
                {
                    DataType ao_ = PretermBirth?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;

                    return aq_;
                };
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
                }
            };
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, default);
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
            bool? z_ = context.Operators.In<string>(x_, y_ as IEnumerable<string>);
            bool? aa_ = context.Operators.And(u_, z_);
            DataType ab_ = PretermBirth?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);

            return ae_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object ax_()
            {
                bool az_()
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;

                    return be_;
                };
                bool ba_()
                {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;

                    return bh_;
                };
                bool bb_()
                {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;

                    return bk_;
                };
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
                }
            };
            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());

            return ay_;
        };
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
        bool? d_(Observation TermBirth)
        {
            object k_()
            {
                bool af_()
                {
                    DataType ai_ = TermBirth?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;

                    return ak_;
                };
                bool ag_()
                {
                    DataType al_ = TermBirth?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;

                    return an_;
                };
                bool ah_()
                {
                    DataType ao_ = TermBirth?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;

                    return aq_;
                };
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
                }
            };
            CqlDateTime l_ = QICoreCommon_4_0_000.Instance.earliest(context, k_());
            CqlDateTime m_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, default);
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
            bool? z_ = context.Operators.In<string>(x_, y_ as IEnumerable<string>);
            bool? aa_ = context.Operators.And(u_, z_);
            DataType ab_ = TermBirth?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);

            return ae_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            object ax_()
            {
                bool az_()
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;

                    return be_;
                };
                bool ba_()
                {
                    DataType bf_ = @this?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlDateTime>;

                    return bh_;
                };
                bool bb_()
                {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;

                    return bk_;
                };
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
                }
            };
            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_());

            return ay_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);

        return j_ as int?;
    }


    [CqlExpressionDefinition("Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
    public IEnumerable<Encounter> Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Gestational_Age_Greater_Than_Or_Equal_To_37_Weeks(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Singleton_Delivery(context);
        IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);
        bool? d_(Encounter SingletonEncounterGE37Weeks)
        {
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
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Encounter With Abnormal Presentation")]
    public IEnumerable<Encounter> Encounter_With_Abnormal_Presentation(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? b_(Encounter ThirtySevenWeeksPlusEncounter)
        {
            object d_()
            {
                bool m_()
                {
                    CqlValueSet p_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
                    bool? r_(Observation AbnormalPresentation)
                    {
                        object z_()
                        {
                            bool aj_()
                            {
                                DataType am_ = AbnormalPresentation?.Effective;
                                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                                bool ao_ = an_ is CqlDateTime;

                                return ao_;
                            };
                            bool ak_()
                            {
                                DataType ap_ = AbnormalPresentation?.Effective;
                                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                                bool ar_ = aq_ is CqlInterval<CqlDateTime>;

                                return ar_;
                            };
                            bool al_()
                            {
                                DataType as_ = AbnormalPresentation?.Effective;
                                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                                bool au_ = at_ is CqlDateTime;

                                return au_;
                            };
                            if (aj_())
                            {
                                DataType av_ = AbnormalPresentation?.Effective;
                                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);

                                return (aw_ as CqlDateTime) as object;
                            }
                            else if (ak_())
                            {
                                DataType ax_ = AbnormalPresentation?.Effective;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                                return (ay_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (al_())
                            {
                                DataType az_ = AbnormalPresentation?.Effective;
                                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);

                                return (ba_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_());
                        CqlDateTime ab_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ac_ = context.Operators.SameOrBefore(aa_, ab_, default);
                        Code<ObservationStatus> ad_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ae_ = ad_?.Value;
                        string af_ = context.Operators.Convert<string>(ae_);
                        string[] ag_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ah_ = context.Operators.In<string>(af_, ag_ as IEnumerable<string>);
                        bool? ai_ = context.Operators.And(ac_, ah_);

                        return ai_;
                    };
                    IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
                    object t_(Observation @this)
                    {
                        object bb_()
                        {
                            bool bd_()
                            {
                                DataType bg_ = @this?.Effective;
                                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                                bool bi_ = bh_ is CqlDateTime;

                                return bi_;
                            };
                            bool be_()
                            {
                                DataType bj_ = @this?.Effective;
                                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                                bool bl_ = bk_ is CqlInterval<CqlDateTime>;

                                return bl_;
                            };
                            bool bf_()
                            {
                                DataType bm_ = @this?.Effective;
                                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                                bool bo_ = bn_ is CqlDateTime;

                                return bo_;
                            };
                            if (bd_())
                            {
                                DataType bp_ = @this?.Effective;
                                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);

                                return (bq_ as CqlDateTime) as object;
                            }
                            else if (be_())
                            {
                                DataType br_ = @this?.Effective;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);

                                return (bs_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bf_())
                            {
                                DataType bt_ = @this?.Effective;
                                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);

                                return (bu_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime bc_ = QICoreCommon_4_0_000.Instance.earliest(context, bb_());

                        return bc_;
                    };
                    IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation v_ = context.Operators.Last<Observation>(u_);
                    DataType w_ = v_?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlDateTime;

                    return y_;
                };
                bool n_()
                {
                    CqlValueSet bv_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> bw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
                    bool? bx_(Observation AbnormalPresentation)
                    {
                        object cf_()
                        {
                            bool cp_()
                            {
                                DataType cs_ = AbnormalPresentation?.Effective;
                                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                                bool cu_ = ct_ is CqlDateTime;

                                return cu_;
                            };
                            bool cq_()
                            {
                                DataType cv_ = AbnormalPresentation?.Effective;
                                object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                                bool cx_ = cw_ is CqlInterval<CqlDateTime>;

                                return cx_;
                            };
                            bool cr_()
                            {
                                DataType cy_ = AbnormalPresentation?.Effective;
                                object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                                bool da_ = cz_ is CqlDateTime;

                                return da_;
                            };
                            if (cp_())
                            {
                                DataType db_ = AbnormalPresentation?.Effective;
                                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);

                                return (dc_ as CqlDateTime) as object;
                            }
                            else if (cq_())
                            {
                                DataType dd_ = AbnormalPresentation?.Effective;
                                object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);

                                return (de_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (cr_())
                            {
                                DataType df_ = AbnormalPresentation?.Effective;
                                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);

                                return (dg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_());
                        CqlDateTime ch_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ci_ = context.Operators.SameOrBefore(cg_, ch_, default);
                        Code<ObservationStatus> cj_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ck_ = cj_?.Value;
                        string cl_ = context.Operators.Convert<string>(ck_);
                        string[] cm_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? cn_ = context.Operators.In<string>(cl_, cm_ as IEnumerable<string>);
                        bool? co_ = context.Operators.And(ci_, cn_);

                        return co_;
                    };
                    IEnumerable<Observation> by_ = context.Operators.Where<Observation>(bw_, bx_);
                    object bz_(Observation @this)
                    {
                        object dh_()
                        {
                            bool dj_()
                            {
                                DataType dm_ = @this?.Effective;
                                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                                bool do_ = dn_ is CqlDateTime;

                                return do_;
                            };
                            bool dk_()
                            {
                                DataType dp_ = @this?.Effective;
                                object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);
                                bool dr_ = dq_ is CqlInterval<CqlDateTime>;

                                return dr_;
                            };
                            bool dl_()
                            {
                                DataType ds_ = @this?.Effective;
                                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                                bool du_ = dt_ is CqlDateTime;

                                return du_;
                            };
                            if (dj_())
                            {
                                DataType dv_ = @this?.Effective;
                                object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);

                                return (dw_ as CqlDateTime) as object;
                            }
                            else if (dk_())
                            {
                                DataType dx_ = @this?.Effective;
                                object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);

                                return (dy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dl_())
                            {
                                DataType dz_ = @this?.Effective;
                                object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);

                                return (ea_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime di_ = QICoreCommon_4_0_000.Instance.earliest(context, dh_());

                        return di_;
                    };
                    IEnumerable<Observation> ca_ = context.Operators.SortBy<Observation>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation cb_ = context.Operators.Last<Observation>(ca_);
                    DataType cc_ = cb_?.Effective;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool ce_ = cd_ is CqlInterval<CqlDateTime>;

                    return ce_;
                };
                bool o_()
                {
                    CqlValueSet eb_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> ec_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, eb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
                    bool? ed_(Observation AbnormalPresentation)
                    {
                        object el_()
                        {
                            bool ev_()
                            {
                                DataType ey_ = AbnormalPresentation?.Effective;
                                object ez_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ey_);
                                bool fa_ = ez_ is CqlDateTime;

                                return fa_;
                            };
                            bool ew_()
                            {
                                DataType fb_ = AbnormalPresentation?.Effective;
                                object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                                bool fd_ = fc_ is CqlInterval<CqlDateTime>;

                                return fd_;
                            };
                            bool ex_()
                            {
                                DataType fe_ = AbnormalPresentation?.Effective;
                                object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                                bool fg_ = ff_ is CqlDateTime;

                                return fg_;
                            };
                            if (ev_())
                            {
                                DataType fh_ = AbnormalPresentation?.Effective;
                                object fi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fh_);

                                return (fi_ as CqlDateTime) as object;
                            }
                            else if (ew_())
                            {
                                DataType fj_ = AbnormalPresentation?.Effective;
                                object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);

                                return (fk_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ex_())
                            {
                                DataType fl_ = AbnormalPresentation?.Effective;
                                object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);

                                return (fm_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime em_ = QICoreCommon_4_0_000.Instance.earliest(context, el_());
                        CqlDateTime en_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? eo_ = context.Operators.SameOrBefore(em_, en_, default);
                        Code<ObservationStatus> ep_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? eq_ = ep_?.Value;
                        string er_ = context.Operators.Convert<string>(eq_);
                        string[] es_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? et_ = context.Operators.In<string>(er_, es_ as IEnumerable<string>);
                        bool? eu_ = context.Operators.And(eo_, et_);

                        return eu_;
                    };
                    IEnumerable<Observation> ee_ = context.Operators.Where<Observation>(ec_, ed_);
                    object ef_(Observation @this)
                    {
                        object fn_()
                        {
                            bool fp_()
                            {
                                DataType fs_ = @this?.Effective;
                                object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                                bool fu_ = ft_ is CqlDateTime;

                                return fu_;
                            };
                            bool fq_()
                            {
                                DataType fv_ = @this?.Effective;
                                object fw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fv_);
                                bool fx_ = fw_ is CqlInterval<CqlDateTime>;

                                return fx_;
                            };
                            bool fr_()
                            {
                                DataType fy_ = @this?.Effective;
                                object fz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fy_);
                                bool ga_ = fz_ is CqlDateTime;

                                return ga_;
                            };
                            if (fp_())
                            {
                                DataType gb_ = @this?.Effective;
                                object gc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gb_);

                                return (gc_ as CqlDateTime) as object;
                            }
                            else if (fq_())
                            {
                                DataType gd_ = @this?.Effective;
                                object ge_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gd_);

                                return (ge_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fr_())
                            {
                                DataType gf_ = @this?.Effective;
                                object gg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gf_);

                                return (gg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime fo_ = QICoreCommon_4_0_000.Instance.earliest(context, fn_());

                        return fo_;
                    };
                    IEnumerable<Observation> eg_ = context.Operators.SortBy<Observation>(ee_, ef_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation eh_ = context.Operators.Last<Observation>(eg_);
                    DataType ei_ = eh_?.Effective;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    bool ek_ = ej_ is CqlDateTime;

                    return ek_;
                };
                if (m_())
                {
                    CqlValueSet gh_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> gi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
                    bool? gj_(Observation AbnormalPresentation)
                    {
                        object gq_()
                        {
                            bool ha_()
                            {
                                DataType hd_ = AbnormalPresentation?.Effective;
                                object he_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hd_);
                                bool hf_ = he_ is CqlDateTime;

                                return hf_;
                            };
                            bool hb_()
                            {
                                DataType hg_ = AbnormalPresentation?.Effective;
                                object hh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hg_);
                                bool hi_ = hh_ is CqlInterval<CqlDateTime>;

                                return hi_;
                            };
                            bool hc_()
                            {
                                DataType hj_ = AbnormalPresentation?.Effective;
                                object hk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hj_);
                                bool hl_ = hk_ is CqlDateTime;

                                return hl_;
                            };
                            if (ha_())
                            {
                                DataType hm_ = AbnormalPresentation?.Effective;
                                object hn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hm_);

                                return (hn_ as CqlDateTime) as object;
                            }
                            else if (hb_())
                            {
                                DataType ho_ = AbnormalPresentation?.Effective;
                                object hp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ho_);

                                return (hp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hc_())
                            {
                                DataType hq_ = AbnormalPresentation?.Effective;
                                object hr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hq_);

                                return (hr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gr_ = QICoreCommon_4_0_000.Instance.earliest(context, gq_());
                        CqlDateTime gs_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? gt_ = context.Operators.SameOrBefore(gr_, gs_, default);
                        Code<ObservationStatus> gu_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? gv_ = gu_?.Value;
                        string gw_ = context.Operators.Convert<string>(gv_);
                        string[] gx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? gy_ = context.Operators.In<string>(gw_, gx_ as IEnumerable<string>);
                        bool? gz_ = context.Operators.And(gt_, gy_);

                        return gz_;
                    };
                    IEnumerable<Observation> gk_ = context.Operators.Where<Observation>(gi_, gj_);
                    object gl_(Observation @this)
                    {
                        object hs_()
                        {
                            bool hu_()
                            {
                                DataType hx_ = @this?.Effective;
                                object hy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hx_);
                                bool hz_ = hy_ is CqlDateTime;

                                return hz_;
                            };
                            bool hv_()
                            {
                                DataType ia_ = @this?.Effective;
                                object ib_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ia_);
                                bool ic_ = ib_ is CqlInterval<CqlDateTime>;

                                return ic_;
                            };
                            bool hw_()
                            {
                                DataType id_ = @this?.Effective;
                                object ie_ = FHIRHelpers_4_4_000.Instance.ToValue(context, id_);
                                bool if_ = ie_ is CqlDateTime;

                                return if_;
                            };
                            if (hu_())
                            {
                                DataType ig_ = @this?.Effective;
                                object ih_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ig_);

                                return (ih_ as CqlDateTime) as object;
                            }
                            else if (hv_())
                            {
                                DataType ii_ = @this?.Effective;
                                object ij_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ii_);

                                return (ij_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hw_())
                            {
                                DataType ik_ = @this?.Effective;
                                object il_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ik_);

                                return (il_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ht_ = QICoreCommon_4_0_000.Instance.earliest(context, hs_());

                        return ht_;
                    };
                    IEnumerable<Observation> gm_ = context.Operators.SortBy<Observation>(gk_, gl_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation gn_ = context.Operators.Last<Observation>(gm_);
                    DataType go_ = gn_?.Effective;
                    object gp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, go_);

                    return (gp_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    CqlValueSet im_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> in_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, im_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
                    bool? io_(Observation AbnormalPresentation)
                    {
                        object iv_()
                        {
                            bool jf_()
                            {
                                DataType ji_ = AbnormalPresentation?.Effective;
                                object jj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ji_);
                                bool jk_ = jj_ is CqlDateTime;

                                return jk_;
                            };
                            bool jg_()
                            {
                                DataType jl_ = AbnormalPresentation?.Effective;
                                object jm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jl_);
                                bool jn_ = jm_ is CqlInterval<CqlDateTime>;

                                return jn_;
                            };
                            bool jh_()
                            {
                                DataType jo_ = AbnormalPresentation?.Effective;
                                object jp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jo_);
                                bool jq_ = jp_ is CqlDateTime;

                                return jq_;
                            };
                            if (jf_())
                            {
                                DataType jr_ = AbnormalPresentation?.Effective;
                                object js_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jr_);

                                return (js_ as CqlDateTime) as object;
                            }
                            else if (jg_())
                            {
                                DataType jt_ = AbnormalPresentation?.Effective;
                                object ju_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jt_);

                                return (ju_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jh_())
                            {
                                DataType jv_ = AbnormalPresentation?.Effective;
                                object jw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jv_);

                                return (jw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime iw_ = QICoreCommon_4_0_000.Instance.earliest(context, iv_());
                        CqlDateTime ix_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? iy_ = context.Operators.SameOrBefore(iw_, ix_, default);
                        Code<ObservationStatus> iz_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? ja_ = iz_?.Value;
                        string jb_ = context.Operators.Convert<string>(ja_);
                        string[] jc_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? jd_ = context.Operators.In<string>(jb_, jc_ as IEnumerable<string>);
                        bool? je_ = context.Operators.And(iy_, jd_);

                        return je_;
                    };
                    IEnumerable<Observation> ip_ = context.Operators.Where<Observation>(in_, io_);
                    object iq_(Observation @this)
                    {
                        object jx_()
                        {
                            bool jz_()
                            {
                                DataType kc_ = @this?.Effective;
                                object kd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kc_);
                                bool ke_ = kd_ is CqlDateTime;

                                return ke_;
                            };
                            bool ka_()
                            {
                                DataType kf_ = @this?.Effective;
                                object kg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kf_);
                                bool kh_ = kg_ is CqlInterval<CqlDateTime>;

                                return kh_;
                            };
                            bool kb_()
                            {
                                DataType ki_ = @this?.Effective;
                                object kj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ki_);
                                bool kk_ = kj_ is CqlDateTime;

                                return kk_;
                            };
                            if (jz_())
                            {
                                DataType kl_ = @this?.Effective;
                                object km_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kl_);

                                return (km_ as CqlDateTime) as object;
                            }
                            else if (ka_())
                            {
                                DataType kn_ = @this?.Effective;
                                object ko_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kn_);

                                return (ko_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kb_())
                            {
                                DataType kp_ = @this?.Effective;
                                object kq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kp_);

                                return (kq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jy_ = QICoreCommon_4_0_000.Instance.earliest(context, jx_());

                        return jy_;
                    };
                    IEnumerable<Observation> ir_ = context.Operators.SortBy<Observation>(ip_, iq_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation is_ = context.Operators.Last<Observation>(ir_);
                    DataType it_ = is_?.Effective;
                    object iu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, it_);

                    return (iu_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    CqlValueSet kr_ = this.Abnormal_Presentation(context);
                    IEnumerable<Observation> ks_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));
                    bool? kt_(Observation AbnormalPresentation)
                    {
                        object la_()
                        {
                            bool lk_()
                            {
                                DataType ln_ = AbnormalPresentation?.Effective;
                                object lo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ln_);
                                bool lp_ = lo_ is CqlDateTime;

                                return lp_;
                            };
                            bool ll_()
                            {
                                DataType lq_ = AbnormalPresentation?.Effective;
                                object lr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lq_);
                                bool ls_ = lr_ is CqlInterval<CqlDateTime>;

                                return ls_;
                            };
                            bool lm_()
                            {
                                DataType lt_ = AbnormalPresentation?.Effective;
                                object lu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lt_);
                                bool lv_ = lu_ is CqlDateTime;

                                return lv_;
                            };
                            if (lk_())
                            {
                                DataType lw_ = AbnormalPresentation?.Effective;
                                object lx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lw_);

                                return (lx_ as CqlDateTime) as object;
                            }
                            else if (ll_())
                            {
                                DataType ly_ = AbnormalPresentation?.Effective;
                                object lz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ly_);

                                return (lz_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lm_())
                            {
                                DataType ma_ = AbnormalPresentation?.Effective;
                                object mb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ma_);

                                return (mb_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lb_ = QICoreCommon_4_0_000.Instance.earliest(context, la_());
                        CqlDateTime lc_ = PCMaternal_5_25_000.Instance.lastTimeOfDelivery(context, ThirtySevenWeeksPlusEncounter);
                        bool? ld_ = context.Operators.SameOrBefore(lb_, lc_, default);
                        Code<ObservationStatus> le_ = AbnormalPresentation?.StatusElement;
                        ObservationStatus? lf_ = le_?.Value;
                        string lg_ = context.Operators.Convert<string>(lf_);
                        string[] lh_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? li_ = context.Operators.In<string>(lg_, lh_ as IEnumerable<string>);
                        bool? lj_ = context.Operators.And(ld_, li_);

                        return lj_;
                    };
                    IEnumerable<Observation> ku_ = context.Operators.Where<Observation>(ks_, kt_);
                    object kv_(Observation @this)
                    {
                        object mc_()
                        {
                            bool me_()
                            {
                                DataType mh_ = @this?.Effective;
                                object mi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mh_);
                                bool mj_ = mi_ is CqlDateTime;

                                return mj_;
                            };
                            bool mf_()
                            {
                                DataType mk_ = @this?.Effective;
                                object ml_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mk_);
                                bool mm_ = ml_ is CqlInterval<CqlDateTime>;

                                return mm_;
                            };
                            bool mg_()
                            {
                                DataType mn_ = @this?.Effective;
                                object mo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mn_);
                                bool mp_ = mo_ is CqlDateTime;

                                return mp_;
                            };
                            if (me_())
                            {
                                DataType mq_ = @this?.Effective;
                                object mr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mq_);

                                return (mr_ as CqlDateTime) as object;
                            }
                            else if (mf_())
                            {
                                DataType ms_ = @this?.Effective;
                                object mt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ms_);

                                return (mt_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mg_())
                            {
                                DataType mu_ = @this?.Effective;
                                object mv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mu_);

                                return (mv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime md_ = QICoreCommon_4_0_000.Instance.earliest(context, mc_());

                        return md_;
                    };
                    IEnumerable<Observation> kw_ = context.Operators.SortBy<Observation>(ku_, kv_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation kx_ = context.Operators.Last<Observation>(kw_);
                    DataType ky_ = kx_?.Effective;
                    object kz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ky_);

                    return (kz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime e_ = QICoreCommon_4_0_000.Instance.earliest(context, d_());
            CqlInterval<CqlDateTime> f_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
            bool? g_ = context.Operators.In<CqlDateTime>(e_, f_, default);
            IEnumerable<object> h_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);
            bool? i_(object EncounterDiagnosis)
            {
                object mw_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                CqlConcept mx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mw_ as CodeableConcept);
                CqlValueSet my_ = this.Abnormal_Presentation(context);
                bool? mz_ = context.Operators.ConceptInValueSet(mx_, my_);

                return mz_;
            };
            IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
            bool? k_ = context.Operators.Exists<object>(j_);
            bool? l_ = context.Operators.Or(g_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter With Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        bool? b_(Encounter ThirtySevenWeeksPlusEncounter)
        {
            IEnumerable<object> d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, ThirtySevenWeeksPlusEncounter);
            bool? e_(object EncounterDiagnosis)
            {
                object h_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_ as CodeableConcept);
                CqlValueSet j_ = this.Placenta_Accreta_Spectrum_Previa_or_Vasa_Previa(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_ as CodeableConcept);
                CqlValueSet n_ = this.Genital_Herpes(context);
                bool? o_ = context.Operators.ConceptInValueSet(m_, n_);
                bool? p_ = context.Operators.Or(k_, o_);

                return p_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Abnormal_Presentation(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_Or_Placenta_Accreta_Spectrum(context);

        return a_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = PCMaternal_5_25_000.Instance.Delivery_Encounter_With_Age_Range(context);

        return a_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Cesarean Birth")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Cesarean_Birth(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_At_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births(context);
        IEnumerable<Encounter> b_(Encounter ThirtySevenWeeksPlusEncounter)
        {
            CqlValueSet d_ = this.Cesarean_Birth(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            bool? f_(Procedure CSection)
            {
                CqlInterval<CqlDateTime> j_ = PCMaternal_5_25_000.Instance.hospitalizationWithEDOBTriageObservation(context, ThirtySevenWeeksPlusEncounter);
                object k_()
                {
                    bool s_()
                    {
                        DataType w_ = CSection?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;

                        return y_;
                    };
                    bool t_()
                    {
                        DataType z_ = CSection?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;

                        return ab_;
                    };
                    bool u_()
                    {
                        DataType ac_ = CSection?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlQuantity;

                        return ae_;
                    };
                    bool v_()
                    {
                        DataType af_ = CSection?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;

                        return ah_;
                    };
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
                    }
                };
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, default);
                Code<EventStatus> n_ = CSection?.StatusElement;
                EventStatus? o_ = n_?.Value;
                string p_ = context.Operators.Convert<string>(o_);
                bool? q_ = context.Operators.Equal(p_, "completed");
                bool? r_ = context.Operators.And(m_, q_);

                return r_;
            };
            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure CSection) =>
                ThirtySevenWeeksPlusEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Cesarean_Birth(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> SDE_Variable_Calculated_Gestational_Age(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> a_ = PCMaternal_5_25_000.Instance.Variable_Calculated_Gestational_Age(context);

        return a_;
    }


    #endregion Functions and Expressions

}
