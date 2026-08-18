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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
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
                    Period bh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    CqlDateTime bj_ = context.Operators.End(bi_);
                    Period bk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                    CqlDateTime bm_ = context.Operators.Start(bl_);
                    CqlQuantity bn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bo_ = context.Operators.Subtract(bm_, bn_);
                    CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bo_, bm_, true, true);
                    CqlBoolean bq_ = context.Operators.In<CqlDateTime>(bj_, bp_, (string)default);

                    CqlBoolean br_() {
                        Period bt_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                        CqlDateTime bv_ = context.Operators.Start(bu_);
                        return !((bool?)(bv_ is null));
                    }


                    CqlBoolean bs_() {
                        Code<Encounter.EncounterStatus> bw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bx_ = bw_?.Value;
                        Code<Encounter.EncounterStatus> by_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bx_);
                        CqlBoolean bz_ = context.Operators.Equal(by_, "finished");
                        return bz_;
                    }

                    return /* CQL 'and' (53:9-54:41) */ (/* CQL 'and' (53:15-53:83) */ (bq_
                        && br_())
                        && bs_());
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period ca_ = @this?.Period;
                    CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ca_);
                    CqlDateTime cc_ = context.Operators.End(cb_);
                    return cc_;
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
                    Period cd_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                    CqlDateTime cf_ = context.Operators.End(ce_);
                    Period cg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                    CqlDateTime ci_ = context.Operators.Start(ch_);
                    CqlQuantity cj_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ck_ = context.Operators.Subtract(ci_, cj_);
                    CqlInterval<CqlDateTime> cl_ = context.Operators.Interval(ck_, ci_, true, true);
                    CqlBoolean cm_ = context.Operators.In<CqlDateTime>(cf_, cl_, (string)default);

                    CqlBoolean cn_() {
                        Period cp_ = Visit?.Period;
                        CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                        CqlDateTime cr_ = context.Operators.Start(cq_);
                        return !((bool?)(cr_ is null));
                    }


                    CqlBoolean co_() {
                        Code<Encounter.EncounterStatus> cs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ct_ = cs_?.Value;
                        Code<Encounter.EncounterStatus> cu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ct_);
                        CqlBoolean cv_ = context.Operators.Equal(cu_, "finished");
                        return cv_;
                    }

                    return /* CQL 'and' (53:9-54:41) */ (/* CQL 'and' (53:15-53:83) */ (cm_
                        && cn_())
                        && co_());
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period cw_ = @this?.Period;
                    CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cw_);
                    CqlDateTime cy_ = context.Operators.End(cx_);
                    return cy_;
                }

                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(au_, bc_ ?? as_, true, true);
                CqlBoolean be_ = context.Operators.In<CqlDateTime>(af_, bd_, (string)default);

                CqlBoolean bf_() {
                    CqlValueSet cz_ = this.Observation_Services(context);
                    IEnumerable<Encounter> da_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, cz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? db_(Encounter LastObs) {
                        Period dm_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                        CqlDateTime do_ = context.Operators.End(dn_);
                        Period dp_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dp_);
                        CqlDateTime dr_ = context.Operators.Start(dq_);
                        CqlQuantity ds_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime dt_ = context.Operators.Subtract(dr_, ds_);
                        CqlInterval<CqlDateTime> du_ = context.Operators.Interval(dt_, dr_, true, true);
                        CqlBoolean dv_ = context.Operators.In<CqlDateTime>(do_, du_, (string)default);

                        CqlBoolean dw_() {
                            Period dy_ = Visit?.Period;
                            CqlInterval<CqlDateTime> dz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dy_);
                            CqlDateTime ea_ = context.Operators.Start(dz_);
                            return !((bool?)(ea_ is null));
                        }


                        CqlBoolean dx_() {
                            Code<Encounter.EncounterStatus> eb_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? ec_ = eb_?.Value;
                            Code<Encounter.EncounterStatus> ed_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ec_);
                            CqlBoolean ee_ = context.Operators.Equal(ed_, "finished");
                            return ee_;
                        }

                        return /* CQL 'and' (53:9-54:41) */ (/* CQL 'and' (53:15-53:83) */ (dv_
                            && dw_())
                            && dx_());
                    }

                    IEnumerable<Encounter> dc_ = context.Operators.Where<Encounter>(da_, db_);

                    object dd_(Encounter @this) {
                        Period ef_ = @this?.Period;
                        CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                        CqlDateTime eh_ = context.Operators.End(eg_);
                        return eh_;
                    }

                    IEnumerable<Encounter> de_ = context.Operators.SortBy<Encounter>(dc_, dd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter df_ = context.Operators.Last<Encounter>(de_);
                    Period dg_ = df_?.Period;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.Start(dh_);
                    Period dj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                    CqlDateTime dl_ = context.Operators.Start(dk_);
                    return !((bool?)((di_ ?? dl_) is null));
                }


                CqlBoolean bg_() {
                    Code<Encounter.EncounterStatus> ei_ = LastEDOBTriage?.StatusElement;
                    Encounter.EncounterStatus? ej_ = ei_?.Value;
                    Code<Encounter.EncounterStatus> ek_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ej_);
                    CqlBoolean el_ = context.Operators.Equal(ek_, "finished");
                    return el_;
                }

                return /* CQL 'and' (60:9-61:48) */ (/* CQL 'and' (60:15-60:79) */ (be_
                    && bf_())
                    && bg_());
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period em_ = @this?.Period;
                CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime eo_ = context.Operators.End(en_);
                return eo_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Period ep_ = LastObs?.Period;
                CqlInterval<CqlDateTime> eq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ep_);
                CqlDateTime er_ = context.Operators.End(eq_);
                Period es_ = Visit?.Period;
                CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, es_);
                CqlDateTime eu_ = context.Operators.Start(et_);
                CqlQuantity ev_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ew_ = context.Operators.Subtract(eu_, ev_);
                CqlInterval<CqlDateTime> ex_ = context.Operators.Interval(ew_, eu_, true, true);
                CqlBoolean ey_ = context.Operators.In<CqlDateTime>(er_, ex_, (string)default);

                CqlBoolean ez_() {
                    Period fb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> fc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fb_);
                    CqlDateTime fd_ = context.Operators.Start(fc_);
                    return !((bool?)(fd_ is null));
                }


                CqlBoolean fa_() {
                    Code<Encounter.EncounterStatus> fe_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ff_ = fe_?.Value;
                    Code<Encounter.EncounterStatus> fg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ff_);
                    CqlBoolean fh_ = context.Operators.Equal(fg_, "finished");
                    return fh_;
                }

                return /* CQL 'and' (53:9-54:41) */ (/* CQL 'and' (53:15-53:83) */ (ey_
                    && ez_())
                    && fa_());
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period fi_ = @this?.Period;
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                CqlDateTime fk_ = context.Operators.End(fj_);
                return fk_;
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

                CqlBoolean l_() {
                    object m_;
                    DataType r_ = DeliveryProcedure?.Performed;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    bool t_ = s_ is CqlDateTime;
                    if (t_)
                    {
                        m_ = s_ as CqlDateTime;
                    }
                    else
                    {
                        bool u_ = s_ is CqlQuantity;
                        if (u_)
                        {
                            m_ = s_ as CqlQuantity;
                        }
                        else
                        {
                            bool v_ = s_ is CqlInterval<CqlDateTime>;
                            if (v_)
                            {
                                m_ = s_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool w_ = s_ is CqlInterval<CqlQuantity>;
                                if (w_)
                                {
                                    m_ = s_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    m_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlInterval<CqlDateTime> p_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                    CqlBoolean q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                    return q_;
                }

                return /* CQL 'and' (27:27-28:138) */ (k_
                    && l_());
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

            CqlBoolean m_() {
                Code<ObservationStatus> p_ = TimeOfDelivery?.StatusElement;
                ObservationStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                string[] s_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                return t_;
            }


            CqlBoolean n_() {
                object u_;
                DataType y_ = TimeOfDelivery?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    u_ = z_ as CqlDateTime;
                }
                else
                {
                    if (aa_)
                    {
                        u_ = z_ as CqlDateTime;
                    }
                    else
                    {
                        bool ab_ = z_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            u_ = z_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
                CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
                CqlInterval<CqlDateTime> w_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                CqlBoolean x_ = context.Operators.In<CqlDateTime>(v_, w_, (string)default);
                return x_;
            }


            CqlBoolean o_() {
                DataType ac_ = TimeOfDelivery?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                CqlInterval<CqlDateTime> ae_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                CqlBoolean af_ = context.Operators.In<CqlDateTime>(ad_ as CqlDateTime, ae_, (string)default);
                return af_;
            }

            return /* CQL 'and' (93:7-96:107) */ (/* CQL 'and' (93:13-95:112) */ (/* CQL 'and' (93:13-94:72) */ ((CqlBoolean)(!((bool?)((l_ as CqlDateTime) is null)))
                && m_())
                && n_())
                && o_());
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ag_;
            DataType ai_ = @this?.Effective;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            bool ak_ = aj_ is CqlDateTime;
            if (ak_)
            {
                ag_ = aj_ as CqlDateTime;
            }
            else
            {
                if (ak_)
                {
                    ag_ = aj_ as CqlDateTime;
                }
                else
                {
                    bool al_ = aj_ is CqlInterval<CqlDateTime>;
                    if (al_)
                    {
                        ag_ = aj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ag_ = null;
                    }
                }
            }
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            return ah_;
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

            CqlBoolean m_() {
                Code<ObservationStatus> o_ = EstimatedDateOfDelivery?.StatusElement;
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
                DataType aa_ = EstimatedDateOfDelivery?.Effective;
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
                CqlDateTime v_ = this.lastTimeOfDelivery(context, TheEncounter);
                CqlQuantity w_ = context.Operators.Quantity(42m, "weeks");
                CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, v_, true, true);
                CqlBoolean z_ = context.Operators.In<CqlDateTime>(u_, y_, (string)default);
                return /* CQL 'and' (74:13-74:123) */ (z_
                    && !((bool?)((this.lastTimeOfDelivery(context, TheEncounter)) is null)));
            }

            return /* CQL 'and' (72:7-74:123) */ (/* CQL 'and' (72:13-73:81) */ ((CqlBoolean)(!((bool?)((l_ as CqlDateTime) is null)))
                && m_())
                && n_());
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
            DataType t_ = EstimatedGestationalAge?.Effective;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                j_ = u_ as CqlDateTime;
            }
            else
            {
                if (v_)
                {
                    j_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlInterval<CqlDateTime>;
                    if (w_)
                    {
                        j_ = u_ as CqlInterval<CqlDateTime>;
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

            CqlBoolean q_() {
                DataType x_ = EstimatedGestationalAge?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                return !((bool?)(y_ is null));
            }


            CqlBoolean r_() {
                Code<ObservationStatus> z_ = EstimatedGestationalAge?.StatusElement;
                ObservationStatus? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                string[] ac_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
                return ad_;
            }


            CqlBoolean s_() {
                object ae_;
                DataType ak_ = EstimatedGestationalAge?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    ae_ = al_ as CqlDateTime;
                }
                else
                {
                    if (am_)
                    {
                        ae_ = al_ as CqlDateTime;
                    }
                    else
                    {
                        bool an_ = al_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            ae_ = al_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
                CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
                CqlDateTime ag_ = this.lastTimeOfDelivery(context, TheEncounter);
                CqlBoolean ah_ = context.Operators.SameAs(af_, ag_, "day");

                CqlBoolean ai_() {
                    object ao_;
                    DataType as_ = EstimatedGestationalAge?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlDateTime;
                    if (au_)
                    {
                        ao_ = at_ as CqlDateTime;
                    }
                    else
                    {
                        if (au_)
                        {
                            ao_ = at_ as CqlDateTime;
                        }
                        else
                        {
                            bool av_ = at_ is CqlInterval<CqlDateTime>;
                            if (av_)
                            {
                                ao_ = at_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                ao_ = null;
                            }
                        }
                    }
                    CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_);
                    CqlInterval<CqlDateTime> aq_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                    CqlBoolean ar_ = context.Operators.In<CqlDateTime>(ap_, aq_, (string)default);
                    return ar_;
                }


                CqlBoolean aj_() {
                    DataType aw_ = EstimatedGestationalAge?.Value;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return !((bool?)(ax_ is null));
                }

                return /* CQL 'and' (85:7-87:52) */ (/* CQL 'and' (85:8-86:82) */ (ah_
                    && ai_())
                    && aj_());
            }

            return /* CQL 'or' (81:64-87:52) */ (/* CQL 'and' (82:3-84:76) */ (/* CQL 'and' (82:4-83:47) */ (/* CQL 'and' (82:4-82:77) */ (p_
                && !((bool?)((this.lastTimeOfDelivery(context, TheEncounter)) is null)))
                && q_())
                && r_())
                || s_());
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object ay_;
            DataType ba_ = @this?.Effective;
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            bool bc_ = bb_ is CqlDateTime;
            if (bc_)
            {
                ay_ = bb_ as CqlDateTime;
            }
            else
            {
                if (bc_)
                {
                    ay_ = bb_ as CqlDateTime;
                }
                else
                {
                    bool bd_ = bb_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        ay_ = bb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ay_ = null;
                    }
                }
            }
            CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_);
            return az_;
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
