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
[CqlLibrary("PCMaternal", "5.25.000")]
public partial class PCMaternal_5_25_000 : ILibrary, ISingleton<PCMaternal_5_25_000>
{
    #region ValueSets (5)

    [CqlValueSetDefinition("Delivery Procedures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", valueSetVersion: null)]
    public CqlValueSet Delivery_Procedures(CqlContext _) => _Delivery_Procedures;
    private static readonly CqlValueSet _Delivery_Procedures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlValueSetDefinition("ED Visit and OB Triage", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", valueSetVersion: null)]
    public CqlValueSet ED_Visit_and_OB_Triage(CqlContext _) => _ED_Visit_and_OB_Triage;
    private static readonly CqlValueSet _ED_Visit_and_OB_Triage = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Estimated Gestational Age at Delivery", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", valueSetVersion: null)]
    public CqlValueSet Estimated_Gestational_Age_at_Delivery(CqlContext _) => _Estimated_Gestational_Age_at_Delivery;
    private static readonly CqlValueSet _Estimated_Gestational_Age_at_Delivery = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.26", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Date and time of obstetric delivery", codeId: "93857-1", codeSystem: "http://loinc.org")]
    public CqlCode Date_and_time_of_obstetric_delivery(CqlContext _) => _Date_and_time_of_obstetric_delivery;
    private static readonly CqlCode _Date_and_time_of_obstetric_delivery = new CqlCode("93857-1", "http://loinc.org");

    [CqlCodeDefinition("Delivery date Estimated", codeId: "11778-8", codeSystem: "http://loinc.org")]
    public CqlCode Delivery_date_Estimated(CqlContext _) => _Delivery_date_Estimated;
    private static readonly CqlCode _Delivery_date_Estimated = new CqlCode("11778-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Date_and_time_of_obstetric_delivery,
          _Delivery_date_Estimated]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 859669092182870447L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("PCMaternal-5.25.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (9)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3137100805743588519L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Encounter With Age Range")]
    public IEnumerable<Encounter> Encounter_With_Age_Range(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Age_Range, Encounter_With_Age_Range_Compute);

    private const long _cacheIndex_Encounter_With_Age_Range = -1742568757353030109L;

    private IEnumerable<Encounter> Encounter_With_Age_Range_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            CqlInterval<int?> m_ = context.Operators.Interval(8, 65, true, false);
            CqlBoolean n_ = context.Operators.In<int?>(l_, m_, (string)default);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("hospitalizationWithEDOBTriageObservation")]
    public CqlInterval<CqlDateTime> hospitalizationWithEDOBTriageObservation(CqlContext context, Encounter TheEncounter)
    {
        Encounter[] a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime> b_(Encounter Visit) {
            CqlValueSet e_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter LastEDOBTriage) {
                Period ad_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlDateTime af_ = context.Operators.End(ae_);
                CqlValueSet ag_ = this.Observation_Services(context);
                IEnumerable<Encounter> ah_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? ai_(Encounter LastObs) {
                    Period bt_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                    CqlDateTime bv_ = context.Operators.End(bu_);
                    Period bw_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                    CqlDateTime by_ = context.Operators.Start(bx_);
                    CqlQuantity bz_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ca_ = context.Operators.Subtract(by_, bz_);
                    CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(ca_, by_, true, true);
                    CqlBoolean cc_ = context.Operators.In<CqlDateTime>(bv_, cb_, (string)default);
                    CqlBoolean cd_ = (CqlBoolean)(by_ is not null);
                    Code<Encounter.EncounterStatus> ce_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cf_ = ce_?.Value;
                    Code<Encounter.EncounterStatus> cg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cf_);
                    CqlBoolean ch_ = context.Operators.Equal(cg_, "finished");
                    CqlBoolean ci_ = ch_;
                    return cc_
                        /* CQL 'and' (53:15-53:83) */ && cd_
                        /* CQL 'and' (53:9-54:41) */ && ci_;
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period cj_ = @this?.Period;
                    CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                    CqlDateTime cl_ = context.Operators.End(ck_);
                    return cl_;
                }

                IEnumerable<Encounter> al_ = context.Operators.SortBy<Encounter>(aj_, ak_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter am_ = context.Operators.Last<Encounter>(al_);
                Period an_ = am_?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                Period aq_ = Visit?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                CqlQuantity at_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime au_ = context.Operators.Subtract(ap_ ?? as_, at_);

                bool? av_(Encounter LastObs) {
                    Period cm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                    CqlDateTime co_ = context.Operators.End(cn_);
                    Period cp_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                    CqlDateTime cr_ = context.Operators.Start(cq_);
                    CqlQuantity cs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ct_ = context.Operators.Subtract(cr_, cs_);
                    CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(ct_, cr_, true, true);
                    CqlBoolean cv_ = context.Operators.In<CqlDateTime>(co_, cu_, (string)default);
                    CqlBoolean cw_ = (CqlBoolean)(cr_ is not null);
                    Code<Encounter.EncounterStatus> cx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cy_ = cx_?.Value;
                    Code<Encounter.EncounterStatus> cz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cy_);
                    CqlBoolean da_ = context.Operators.Equal(cz_, "finished");
                    CqlBoolean db_ = da_;
                    return cv_
                        /* CQL 'and' (53:15-53:83) */ && cw_
                        /* CQL 'and' (53:9-54:41) */ && db_;
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period dc_ = @this?.Period;
                    CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.End(dd_);
                    return de_;
                }

                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(au_, bc_ ?? as_, true, true);
                CqlBoolean be_ = context.Operators.In<CqlDateTime>(af_, bd_, (string)default);

                bool? bf_(Encounter LastObs) {
                    Period df_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, df_);
                    CqlDateTime dh_ = context.Operators.End(dg_);
                    Period di_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                    CqlDateTime dk_ = context.Operators.Start(dj_);
                    CqlQuantity dl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dm_ = context.Operators.Subtract(dk_, dl_);
                    CqlInterval<CqlDateTime> dn_ = context.Operators.Interval(dm_, dk_, true, true);
                    CqlBoolean do_ = context.Operators.In<CqlDateTime>(dh_, dn_, (string)default);
                    CqlBoolean dp_ = (CqlBoolean)(dk_ is not null);
                    Code<Encounter.EncounterStatus> dq_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dr_ = dq_?.Value;
                    Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                    CqlBoolean dt_ = context.Operators.Equal(ds_, "finished");
                    CqlBoolean du_ = dt_;
                    return do_
                        /* CQL 'and' (53:15-53:83) */ && dp_
                        /* CQL 'and' (53:9-54:41) */ && du_;
                }

                IEnumerable<Encounter> bg_ = context.Operators.Where<Encounter>(ah_, bf_);

                object bh_(Encounter @this) {
                    Period dv_ = @this?.Period;
                    CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                    CqlDateTime dx_ = context.Operators.End(dw_);
                    return dx_;
                }

                IEnumerable<Encounter> bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bj_ = context.Operators.Last<Encounter>(bi_);
                Period bk_ = bj_?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlBoolean bn_ = (CqlBoolean)((bm_ ?? as_) is not null);
                Code<Encounter.EncounterStatus> bo_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? bp_ = bo_?.Value;
                Code<Encounter.EncounterStatus> bq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bp_);
                CqlBoolean br_ = context.Operators.Equal(bq_, "finished");
                CqlBoolean bs_ = br_;
                return be_
                    /* CQL 'and' (60:15-60:79) */ && bn_
                    /* CQL 'and' (60:9-61:48) */ && bs_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period dy_ = @this?.Period;
                CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                CqlDateTime ea_ = context.Operators.End(dz_);
                return ea_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Period eb_ = LastObs?.Period;
                CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                CqlDateTime ed_ = context.Operators.End(ec_);
                Period ee_ = Visit?.Period;
                CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                CqlDateTime eg_ = context.Operators.Start(ef_);
                CqlQuantity eh_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ei_ = context.Operators.Subtract(eg_, eh_);
                CqlInterval<CqlDateTime> ej_ = context.Operators.Interval(ei_, eg_, true, true);
                CqlBoolean ek_ = context.Operators.In<CqlDateTime>(ed_, ej_, (string)default);
                CqlBoolean el_ = (CqlBoolean)(eg_ is not null);
                Code<Encounter.EncounterStatus> em_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? en_ = em_?.Value;
                Code<Encounter.EncounterStatus> eo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(en_);
                CqlBoolean ep_ = context.Operators.Equal(eo_, "finished");
                CqlBoolean eq_ = ep_;
                return ek_
                    /* CQL 'and' (53:15-53:83) */ && el_
                    /* CQL 'and' (53:9-54:41) */ && eq_;
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period er_ = @this?.Period;
                CqlInterval<CqlDateTime> es_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, er_);
                CqlDateTime et_ = context.Operators.End(es_);
                return et_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            Period y_ = Visit?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime aa_ = context.Operators.Start(z_);
            CqlDateTime ab_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ab_, true, true);
            return ac_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Age_Range(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Age_Range, Delivery_Encounter_With_Age_Range_Compute);

    private const long _cacheIndex_Delivery_Encounter_With_Age_Range = 6284105905977930602L;

    private IEnumerable<Encounter> Delivery_Encounter_With_Age_Range_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_Range(context);

        bool? b_(Encounter EncounterWithAge) {
            CqlValueSet d_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure DeliveryProcedure) {
                Code<EventStatus> h_ = DeliveryProcedure?.StatusElement;
                EventStatus? i_ = h_?.Value;
                string j_ = context.Operators.Convert<string>(i_);
                CqlBoolean k_ = context.Operators.Equal(j_, "completed");
                object l_;
                DataType r_ = DeliveryProcedure?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    l_ = s_ as CqlDateTime;
                }
                else
                {
                    bool u_ = s_ is CqlQuantity;
                    if (u_)
                    {
                        l_ = s_ as CqlQuantity;
                    }
                    else
                    {
                        bool v_ = s_ is CqlInterval<CqlDateTime>;
                        if (v_)
                        {
                            l_ = s_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool w_ = s_ is CqlInterval<CqlQuantity>;
                            if (w_)
                            {
                                l_ = s_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                l_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                CqlBoolean q_ = p_;
                return k_
                    /* CQL 'and' (27:27-28:138) */ && q_;
            }

            CqlBoolean g_ = context.Operators.WhereAny<Procedure>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("calculatedGestationalAge")]
    public int? calculatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlDateTime a_ = this.lastTimeOfDelivery(context, TheEncounter);
        CqlDateTime b_ = this.lastEstimatedDeliveryDate(context, TheEncounter);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        int? d_ = context.Operators.Subtract(280, c_);
        int? e_ = context.Operators.TruncatedDivide(d_, 7);
        return e_;
    }


    [CqlFunctionDefinition("lastTimeOfDelivery")]
    public CqlDateTime lastTimeOfDelivery(CqlContext context, Encounter TheEncounter)
    {
        CqlCode a_ = this.Date_and_time_of_obstetric_delivery(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation TimeOfDelivery) {
            DataType k_ = TimeOfDelivery?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            Code<ObservationStatus> m_ = TimeOfDelivery?.StatusElement;
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
            DataType z_ = TimeOfDelivery?.Effective;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool ab_ = aa_ is CqlDateTime;
            if (ab_)
            {
                s_ = aa_ as CqlDateTime;
            }
            else
            {
                if (ab_)
                {
                    s_ = aa_ as CqlDateTime;
                }
                else
                {
                    bool ac_ = aa_ is CqlInterval<CqlDateTime>;
                    if (ac_)
                    {
                        s_ = aa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        s_ = null;
                    }
                }
            }
            CqlDateTime t_ = QICoreCommon_4_0_000.Instance.earliest(context, s_);
            CqlInterval<CqlDateTime> u_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            CqlBoolean v_ = context.Operators.In<CqlDateTime>(t_, u_, (string)default);
            CqlBoolean w_ = v_;
            CqlBoolean x_ = context.Operators.In<CqlDateTime>(l_ as CqlDateTime, u_, (string)default);
            CqlBoolean y_ = x_;
            return (CqlBoolean)((l_ as CqlDateTime) is not null)
                /* CQL 'and' (93:13-94:72) */ && r_
                /* CQL 'and' (93:13-95:112) */ && w_
                /* CQL 'and' (93:7-96:107) */ && y_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ad_;
            DataType af_ = @this?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            bool ah_ = ag_ is CqlDateTime;
            if (ah_)
            {
                ad_ = ag_ as CqlDateTime;
            }
            else
            {
                if (ah_)
                {
                    ad_ = ag_ as CqlDateTime;
                }
                else
                {
                    bool ai_ = ag_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        ad_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ad_ = null;
                    }
                }
            }
            CqlDateTime ae_ = QICoreCommon_4_0_000.Instance.earliest(context, ad_);
            return ae_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        DataType i_ = h_?.Value;
        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
        return j_ as CqlDateTime;
    }


    [CqlFunctionDefinition("lastEstimatedDeliveryDate")]
    public CqlDateTime lastEstimatedDeliveryDate(CqlContext context, Encounter TheEncounter)
    {
        CqlCode a_ = this.Delivery_date_Estimated(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? d_(Observation EstimatedDateOfDelivery) {
            DataType k_ = EstimatedDateOfDelivery?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            Code<ObservationStatus> m_ = EstimatedDateOfDelivery?.StatusElement;
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
            DataType aa_ = EstimatedDateOfDelivery?.Effective;
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
            CqlDateTime u_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity v_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime w_ = context.Operators.Subtract(u_, v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, u_, true, true);
            CqlBoolean y_ = context.Operators.In<CqlDateTime>(t_, x_, (string)default);
            CqlBoolean z_ = y_
                /* CQL 'and' (74:13-74:123) */ && ((this.lastTimeOfDelivery(context, TheEncounter)) is not null);
            return (CqlBoolean)((l_ as CqlDateTime) is not null)
                /* CQL 'and' (72:13-73:81) */ && r_
                /* CQL 'and' (72:7-74:123) */ && z_;
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
        return j_ as CqlDateTime;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Variable_Calculated_Gestational_Age, Variable_Calculated_Gestational_Age_Compute);

    private const long _cacheIndex_Variable_Calculated_Gestational_Age = 5194648618977956313L;

    private IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Age_Range(context);

        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? b_(Encounter DeliveryEncounter) {
            Id d_ = DeliveryEncounter?.IdElement;
            string e_ = d_?.Value;
            int? f_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? g_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet a_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? c_(Observation EstimatedGestationalAge) {
            object j_;
            DataType ai_ = EstimatedGestationalAge?.Effective;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            bool ak_ = aj_ is CqlDateTime;
            if (ak_)
            {
                j_ = aj_ as CqlDateTime;
            }
            else
            {
                if (ak_)
                {
                    j_ = aj_ as CqlDateTime;
                }
                else
                {
                    bool al_ = aj_ is CqlInterval<CqlDateTime>;
                    if (al_)
                    {
                        j_ = aj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        j_ = null;
                    }
                }
            }
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlDateTime l_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity m_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime n_ = context.Operators.Subtract(l_, m_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(n_, l_, true, true);
            CqlBoolean p_ = context.Operators.In<CqlDateTime>(k_, o_, (string)default);
            DataType q_ = EstimatedGestationalAge?.Value;
            object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
            CqlBoolean s_ = (CqlBoolean)(r_ is not null);
            Code<ObservationStatus> t_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? u_ = t_?.Value;
            string v_ = context.Operators.Convert<string>(u_);
            string[] w_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
            CqlBoolean y_ = x_;
            object z_;
            DataType am_ = EstimatedGestationalAge?.Effective;
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            bool ao_ = an_ is CqlDateTime;
            if (ao_)
            {
                z_ = an_ as CqlDateTime;
            }
            else
            {
                if (ao_)
                {
                    z_ = an_ as CqlDateTime;
                }
                else
                {
                    bool ap_ = an_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        z_ = an_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        z_ = null;
                    }
                }
            }
            CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
            CqlBoolean ab_ = context.Operators.SameAs(aa_, l_, "day");
            object ac_;
            DataType aq_ = EstimatedGestationalAge?.Effective;
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            bool as_ = ar_ is CqlDateTime;
            if (as_)
            {
                ac_ = ar_ as CqlDateTime;
            }
            else
            {
                if (as_)
                {
                    ac_ = ar_ as CqlDateTime;
                }
                else
                {
                    bool at_ = ar_ is CqlInterval<CqlDateTime>;
                    if (at_)
                    {
                        ac_ = ar_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ac_ = null;
                    }
                }
            }
            CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_);
            CqlInterval<CqlDateTime> ae_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            CqlBoolean af_ = context.Operators.In<CqlDateTime>(ad_, ae_, (string)default);
            CqlBoolean ag_ = af_;
            CqlBoolean ah_ = ab_
                /* CQL 'and' (85:8-86:82) */ && ag_
                /* CQL 'and' (85:7-87:52) */ && s_;
            return (p_
                /* CQL 'and' (82:4-82:77) */ && ((this.lastTimeOfDelivery(context, TheEncounter)) is not null)
                /* CQL 'and' (82:4-83:47) */ && s_
                /* CQL 'and' (82:3-84:76) */ && y_)
                /* CQL 'or' (81:64-87:52) */ || ah_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object au_;
            DataType aw_ = @this?.Effective;
            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
            bool ay_ = ax_ is CqlDateTime;
            if (ay_)
            {
                au_ = ax_ as CqlDateTime;
            }
            else
            {
                if (ay_)
                {
                    au_ = ax_ as CqlDateTime;
                }
                else
                {
                    bool az_ = ax_ is CqlInterval<CqlDateTime>;
                    if (az_)
                    {
                        au_ = ax_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        au_ = null;
                    }
                }
            }
            CqlDateTime av_ = QICoreCommon_4_0_000.Instance.earliest(context, au_);
            return av_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private PCMaternal_5_25_000() {}

    public static PCMaternal_5_25_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "PCMaternal";
    public string Version => "5.25.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
       [typeof(string), typeof(int?)],
       ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
