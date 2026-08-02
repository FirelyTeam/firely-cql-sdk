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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.8.0")]
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
            bool? n_ = context.Operators.In<int?>(l_, m_, (string)default);
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
                    Period bu_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                    CqlDateTime bw_ = context.Operators.End(bv_);
                    Period bx_ = Visit?.Period;
                    CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.Start(by_);
                    CqlQuantity ca_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cb_ = context.Operators.Subtract(bz_, ca_);
                    CqlInterval<CqlDateTime> cc_ = context.Operators.Interval(cb_, bz_, true, true);
                    bool? cd_ = context.Operators.In<CqlDateTime>(bw_, cc_, (string)default);
                    bool? ce_ = context.Operators.Not((bool?)(bz_ is null));
                    bool? cf_ = context.Operators.And(cd_, ce_);
                    Code<Encounter.EncounterStatus> cg_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ch_ = cg_?.Value;
                    Code<Encounter.EncounterStatus> ci_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ch_);
                    bool? cj_ = context.Operators.Equal(ci_, "finished");
                    bool? ck_ = context.Operators.And(cf_, cj_);
                    return ck_;
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period cl_ = @this?.Period;
                    CqlInterval<CqlDateTime> cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                    CqlDateTime cn_ = context.Operators.End(cm_);
                    return cn_;
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
                    Period co_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                    CqlDateTime cq_ = context.Operators.End(cp_);
                    Period cr_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cr_);
                    CqlDateTime ct_ = context.Operators.Start(cs_);
                    CqlQuantity cu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cv_ = context.Operators.Subtract(ct_, cu_);
                    CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(cv_, ct_, true, true);
                    bool? cx_ = context.Operators.In<CqlDateTime>(cq_, cw_, (string)default);
                    bool? cy_ = context.Operators.Not((bool?)(ct_ is null));
                    bool? cz_ = context.Operators.And(cx_, cy_);
                    Code<Encounter.EncounterStatus> da_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? db_ = da_?.Value;
                    Code<Encounter.EncounterStatus> dc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(db_);
                    bool? dd_ = context.Operators.Equal(dc_, "finished");
                    bool? de_ = context.Operators.And(cz_, dd_);
                    return de_;
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period df_ = @this?.Period;
                    CqlInterval<CqlDateTime> dg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, df_);
                    CqlDateTime dh_ = context.Operators.End(dg_);
                    return dh_;
                }

                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(au_, bc_ ?? as_, true, true);
                bool? be_ = context.Operators.In<CqlDateTime>(af_, bd_, (string)default);

                bool? bf_(Encounter LastObs) {
                    Period di_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, di_);
                    CqlDateTime dk_ = context.Operators.End(dj_);
                    Period dl_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dl_);
                    CqlDateTime dn_ = context.Operators.Start(dm_);
                    CqlQuantity do_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dp_ = context.Operators.Subtract(dn_, do_);
                    CqlInterval<CqlDateTime> dq_ = context.Operators.Interval(dp_, dn_, true, true);
                    bool? dr_ = context.Operators.In<CqlDateTime>(dk_, dq_, (string)default);
                    bool? ds_ = context.Operators.Not((bool?)(dn_ is null));
                    bool? dt_ = context.Operators.And(dr_, ds_);
                    Code<Encounter.EncounterStatus> du_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dv_ = du_?.Value;
                    Code<Encounter.EncounterStatus> dw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dv_);
                    bool? dx_ = context.Operators.Equal(dw_, "finished");
                    bool? dy_ = context.Operators.And(dt_, dx_);
                    return dy_;
                }

                IEnumerable<Encounter> bg_ = context.Operators.Where<Encounter>(ah_, bf_);

                object bh_(Encounter @this) {
                    Period dz_ = @this?.Period;
                    CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                    CqlDateTime eb_ = context.Operators.End(ea_);
                    return eb_;
                }

                IEnumerable<Encounter> bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bj_ = context.Operators.Last<Encounter>(bi_);
                Period bk_ = bj_?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                bool? bn_ = context.Operators.Not((bool?)((bm_ ?? as_) is null));
                bool? bo_ = context.Operators.And(be_, bn_);
                Code<Encounter.EncounterStatus> bp_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? bq_ = bp_?.Value;
                Code<Encounter.EncounterStatus> br_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bq_);
                bool? bs_ = context.Operators.Equal(br_, "finished");
                bool? bt_ = context.Operators.And(bo_, bs_);
                return bt_;
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period ec_ = @this?.Period;
                CqlInterval<CqlDateTime> ed_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ec_);
                CqlDateTime ee_ = context.Operators.End(ed_);
                return ee_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Period ef_ = LastObs?.Period;
                CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                CqlDateTime eh_ = context.Operators.End(eg_);
                Period ei_ = Visit?.Period;
                CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.Start(ej_);
                CqlQuantity el_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime em_ = context.Operators.Subtract(ek_, el_);
                CqlInterval<CqlDateTime> en_ = context.Operators.Interval(em_, ek_, true, true);
                bool? eo_ = context.Operators.In<CqlDateTime>(eh_, en_, (string)default);
                bool? ep_ = context.Operators.Not((bool?)(ek_ is null));
                bool? eq_ = context.Operators.And(eo_, ep_);
                Code<Encounter.EncounterStatus> er_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? es_ = er_?.Value;
                Code<Encounter.EncounterStatus> et_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(es_);
                bool? eu_ = context.Operators.Equal(et_, "finished");
                bool? ev_ = context.Operators.And(eq_, eu_);
                return ev_;
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period ew_ = @this?.Period;
                CqlInterval<CqlDateTime> ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ew_);
                CqlDateTime ey_ = context.Operators.End(ex_);
                return ey_;
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
                bool? k_ = context.Operators.Equal(j_, "completed");
                object l_;
                DataType r_ = DeliveryProcedure?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    DataType u_ = DeliveryProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    l_ = v_ as CqlDateTime;
                }
                else
                {
                    DataType w_ = DeliveryProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlQuantity;
                    if (y_)
                    {
                        DataType z_ = DeliveryProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        l_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ab_ = DeliveryProcedure?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ad_)
                        {
                            DataType ae_ = DeliveryProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            l_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ag_ = DeliveryProcedure?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                DataType aj_ = DeliveryProcedure?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                l_ = ak_ as CqlInterval<CqlQuantity>;
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
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                bool? q_ = context.Operators.And(k_, p_);
                return q_;
            }

            bool? g_ = context.Operators.WhereAny<Procedure>(e_, f_);
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
            bool? m_ = context.Operators.Not((bool?)((l_ as CqlDateTime) is null));
            Code<ObservationStatus> n_ = TimeOfDelivery?.StatusElement;
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
            DataType aa_ = TimeOfDelivery?.Effective;
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool ac_ = ab_ is CqlDateTime;
            if (ac_)
            {
                DataType ad_ = TimeOfDelivery?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                t_ = ae_ as CqlDateTime;
            }
            else
            {
                DataType af_ = TimeOfDelivery?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    DataType ai_ = TimeOfDelivery?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    t_ = aj_ as CqlDateTime;
                }
                else
                {
                    DataType ak_ = TimeOfDelivery?.Effective;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlInterval<CqlDateTime>;
                    if (am_)
                    {
                        DataType an_ = TimeOfDelivery?.Effective;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        t_ = ao_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        t_ = null;
                    }
                }
            }
            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
            CqlInterval<CqlDateTime> v_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, (string)default);
            bool? x_ = context.Operators.And(s_, w_);
            bool? y_ = context.Operators.In<CqlDateTime>(l_ as CqlDateTime, v_, (string)default);
            bool? z_ = context.Operators.And(x_, y_);
            return z_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ap_;
            DataType ar_ = @this?.Effective;
            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            bool at_ = as_ is CqlDateTime;
            if (at_)
            {
                DataType au_ = @this?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                ap_ = av_ as CqlDateTime;
            }
            else
            {
                DataType aw_ = @this?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = @this?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    ap_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = @this?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        DataType be_ = @this?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        ap_ = bf_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ap_ = null;
                    }
                }
            }
            CqlDateTime aq_ = QICoreCommon_4_0_000.Instance.earliest(context, ap_);
            return aq_;
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
            bool? m_ = context.Operators.Not((bool?)((l_ as CqlDateTime) is null));
            Code<ObservationStatus> n_ = EstimatedDateOfDelivery?.StatusElement;
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
            DataType ad_ = EstimatedDateOfDelivery?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            bool af_ = ae_ is CqlDateTime;
            if (af_)
            {
                DataType ag_ = EstimatedDateOfDelivery?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                t_ = ah_ as CqlDateTime;
            }
            else
            {
                DataType ai_ = EstimatedDateOfDelivery?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                bool ak_ = aj_ is CqlDateTime;
                if (ak_)
                {
                    DataType al_ = EstimatedDateOfDelivery?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    t_ = am_ as CqlDateTime;
                }
                else
                {
                    DataType an_ = EstimatedDateOfDelivery?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                    if (ap_)
                    {
                        DataType aq_ = EstimatedDateOfDelivery?.Effective;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        t_ = ar_ as CqlInterval<CqlDateTime>;
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
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType bc_ = @this?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    as_ = bd_ as CqlDateTime;
                }
                else
                {
                    DataType be_ = @this?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    if (bg_)
                    {
                        DataType bh_ = @this?.Effective;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        as_ = bi_ as CqlInterval<CqlDateTime>;
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
            DataType am_ = EstimatedGestationalAge?.Effective;
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            bool ao_ = an_ is CqlDateTime;
            if (ao_)
            {
                DataType ap_ = EstimatedGestationalAge?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                j_ = aq_ as CqlDateTime;
            }
            else
            {
                DataType ar_ = EstimatedGestationalAge?.Effective;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                bool at_ = as_ is CqlDateTime;
                if (at_)
                {
                    DataType au_ = EstimatedGestationalAge?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    j_ = av_ as CqlDateTime;
                }
                else
                {
                    DataType aw_ = EstimatedGestationalAge?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlInterval<CqlDateTime>;
                    if (ay_)
                    {
                        DataType az_ = EstimatedGestationalAge?.Effective;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        j_ = ba_ as CqlInterval<CqlDateTime>;
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
            bool? p_ = context.Operators.In<CqlDateTime>(k_, o_, (string)default);
            bool? q_ = context.Operators.Not((bool?)(l_ is null));
            bool? r_ = context.Operators.And(p_, q_);
            DataType s_ = EstimatedGestationalAge?.Value;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool? u_ = context.Operators.Not((bool?)(t_ is null));
            bool? v_ = context.Operators.And(r_, u_);
            Code<ObservationStatus> w_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            bool? ab_ = context.Operators.And(v_, aa_);
            object ac_;
            DataType bb_ = EstimatedGestationalAge?.Effective;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                DataType be_ = EstimatedGestationalAge?.Effective;
                object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                ac_ = bf_ as CqlDateTime;
            }
            else
            {
                DataType bg_ = EstimatedGestationalAge?.Effective;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool bi_ = bh_ is CqlDateTime;
                if (bi_)
                {
                    DataType bj_ = EstimatedGestationalAge?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    ac_ = bk_ as CqlDateTime;
                }
                else
                {
                    DataType bl_ = EstimatedGestationalAge?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                    if (bn_)
                    {
                        DataType bo_ = EstimatedGestationalAge?.Effective;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        ac_ = bp_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ac_ = null;
                    }
                }
            }
            CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_);
            bool? ae_ = context.Operators.SameAs(ad_, l_, "day");
            object af_;
            DataType bq_ = EstimatedGestationalAge?.Effective;
            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
            bool bs_ = br_ is CqlDateTime;
            if (bs_)
            {
                DataType bt_ = EstimatedGestationalAge?.Effective;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                af_ = bu_ as CqlDateTime;
            }
            else
            {
                DataType bv_ = EstimatedGestationalAge?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                bool bx_ = bw_ is CqlDateTime;
                if (bx_)
                {
                    DataType by_ = EstimatedGestationalAge?.Effective;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    af_ = bz_ as CqlDateTime;
                }
                else
                {
                    DataType ca_ = EstimatedGestationalAge?.Effective;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                    if (cc_)
                    {
                        DataType cd_ = EstimatedGestationalAge?.Effective;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        af_ = ce_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        af_ = null;
                    }
                }
            }
            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
            CqlInterval<CqlDateTime> ah_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, (string)default);
            bool? aj_ = context.Operators.And(ae_, ai_);
            bool? ak_ = context.Operators.And(aj_, u_);
            bool? al_ = context.Operators.Or(ab_, ak_);
            return al_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object cf_;
            DataType ch_ = @this?.Effective;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            bool cj_ = ci_ is CqlDateTime;
            if (cj_)
            {
                DataType ck_ = @this?.Effective;
                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                cf_ = cl_ as CqlDateTime;
            }
            else
            {
                DataType cm_ = @this?.Effective;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool co_ = cn_ is CqlDateTime;
                if (co_)
                {
                    DataType cp_ = @this?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    cf_ = cq_ as CqlDateTime;
                }
                else
                {
                    DataType cr_ = @this?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    bool ct_ = cs_ is CqlInterval<CqlDateTime>;
                    if (ct_)
                    {
                        DataType cu_ = @this?.Effective;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        cf_ = cv_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        cf_ = null;
                    }
                }
            }
            CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
            return cg_;
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
