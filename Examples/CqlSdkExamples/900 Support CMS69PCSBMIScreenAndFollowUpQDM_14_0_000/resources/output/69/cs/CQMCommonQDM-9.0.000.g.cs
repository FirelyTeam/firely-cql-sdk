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
using TestConsoleAppFhir.resources.output;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CQMCommonQDM", "9.0.000")]
public partial class CQMCommonQDM_9_0_000 : ILibrary, ISingleton<CQMCommonQDM_9_0_000>
{
    private CQMCommonQDM_9_0_000() {}

    public static CQMCommonQDM_9_0_000 Instance { get; } = new();

    #region ILibrary Implementation

public string Name => "CQMCommonQDM";
public string Version => "9.0.000";
    public ILibrary[] Dependencies => [];

#endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "urn:oid:2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("urn:oid:2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "urn:oid:2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("urn:oid:2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Intensive Care Unit", valueSetId: "urn:oid:2.16.840.1.113762.1.4.1029.206", valueSetVersion: null)]
public CqlValueSet Intensive_Care_Unit(CqlContext _) => _Intensive_Care_Unit;
private static readonly CqlValueSet _Intensive_Care_Unit = new CqlValueSet("urn:oid:2.16.840.1.113762.1.4.1029.206", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "urn:oid:2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
private static readonly CqlValueSet _Observation_Services = new CqlValueSet("urn:oid:2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Outpatient Surgery Service", valueSetId: "urn:oid:2.16.840.1.113762.1.4.1110.38", valueSetVersion: null)]
public CqlValueSet Outpatient_Surgery_Service(CqlContext _) => _Outpatient_Surgery_Service;
private static readonly CqlValueSet _Outpatient_Surgery_Service = new CqlValueSet("urn:oid:2.16.840.1.113762.1.4.1110.38", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CQMCommonQDM-9.0.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("ED Encounter")]
    public IEnumerable<PositiveEncounterPerformed> ED_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Emergency_Department_Visit(context);
        IEnumerable<PositiveEncounterPerformed> b_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, a_, default, "PositiveEncounterPerformed"));

        return b_;
    }


    [CqlFunctionDefinition("Earliest")]
    public CqlDateTime Earliest(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_()
        {
            if ((this.HasStart(context, period)) ?? false)
            {
                CqlDateTime b_ = context.Operators.Start(period);

                return b_;
            }
            else
            {
                CqlDateTime c_ = context.Operators.End(period);

                return c_;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("EarliestOf")]
    public CqlDateTime EarliestOf(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> period)
    {
        CqlInterval<CqlDateTime> a_ = this.NormalizeInterval(context, pointInTime, period);
        CqlDateTime b_ = this.Earliest(context, a_);

        return b_;
    }


    [CqlFunctionDefinition("EmergencyDepartmentArrivalTime")]
    public CqlDateTime EmergencyDepartmentArrivalTime(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        IEnumerable<FacilityLocation> a_ = this.HospitalizationLocations(context, Encounter);
        bool? b_(FacilityLocation HospitalLocation)
        {
            CqlCode i_ = context.Operators.LateBoundProperty<CqlCode>(HospitalLocation, "code");
            CqlValueSet j_ = this.Emergency_Department_Visit(context);
            bool? k_ = context.Operators.CodeInValueSet(i_, j_);

            return k_;
        };
        IEnumerable<FacilityLocation> c_ = context.Operators.Where<FacilityLocation>(a_, b_);
        object d_(FacilityLocation @this)
        {
            CqlInterval<CqlDateTime> l_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "locationPeriod");
            CqlDateTime m_ = context.Operators.Start(l_);

            return m_;
        };
        IEnumerable<FacilityLocation> e_ = context.Operators.SortBy<FacilityLocation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        FacilityLocation f_ = context.Operators.First<FacilityLocation>(e_);
        CqlInterval<CqlDateTime> g_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(f_, "locationPeriod");
        CqlDateTime h_ = context.Operators.Start(g_);

        return h_;
    }


    [CqlFunctionDefinition("FirstInpatientIntensiveCareUnit")]
    public FacilityLocation FirstInpatientIntensiveCareUnit(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        IEnumerable<FacilityLocation> a_ = context.Operators.LateBoundProperty<IEnumerable<FacilityLocation>>(Encounter, "facilityLocations");
        bool? b_(FacilityLocation HospitalLocation)
        {
            CqlCode g_ = context.Operators.LateBoundProperty<CqlCode>(HospitalLocation, "code");
            CqlValueSet h_ = this.Intensive_Care_Unit(context);
            bool? i_ = context.Operators.CodeInValueSet(g_, h_);
            CqlInterval<CqlDateTime> j_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Encounter, "relevantPeriod");
            CqlInterval<CqlDateTime> k_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(HospitalLocation, "locationPeriod");
            bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, k_, default);
            bool? m_ = context.Operators.And(i_, l_);

            return m_;
        };
        IEnumerable<FacilityLocation> c_ = context.Operators.Where<FacilityLocation>(a_, b_);
        object d_(FacilityLocation @this)
        {
            CqlInterval<CqlDateTime> n_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "locationPeriod");
            CqlDateTime o_ = context.Operators.Start(n_);

            return o_;
        };
        IEnumerable<FacilityLocation> e_ = context.Operators.SortBy<FacilityLocation>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        FacilityLocation f_ = context.Operators.First<FacilityLocation>(e_);

        return f_;
    }


    [CqlFunctionDefinition("HasEnd")]
    public bool? HasEnd(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.End(period);
        CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);

        return f_;
    }


    [CqlFunctionDefinition("HasStart")]
    public bool? HasStart(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
        bool? d_ = context.Operators.Equal(a_, c_);
        bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
        bool? f_ = context.Operators.Not(e_);

        return f_;
    }


    [CqlFunctionDefinition("HospitalAdmissionTime")]
    public CqlDateTime HospitalAdmissionTime(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, Encounter);
        CqlDateTime b_ = context.Operators.Start(a_);

        return b_;
    }


    [CqlFunctionDefinition("HospitalArrivalTime")]
    public CqlDateTime HospitalArrivalTime(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        IEnumerable<FacilityLocation> a_ = this.HospitalizationLocations(context, Encounter);
        object b_(FacilityLocation @this)
        {
            CqlInterval<CqlDateTime> g_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "locationPeriod");
            CqlDateTime h_ = context.Operators.Start(g_);

            return h_;
        };
        IEnumerable<FacilityLocation> c_ = context.Operators.SortBy<FacilityLocation>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        FacilityLocation d_ = context.Operators.First<FacilityLocation>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(d_, "locationPeriod");
        CqlDateTime f_ = context.Operators.Start(e_);

        return f_;
    }


    [CqlFunctionDefinition("HospitalDepartureTime")]
    public CqlDateTime HospitalDepartureTime(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        IEnumerable<FacilityLocation> a_ = this.HospitalizationLocations(context, Encounter);
        object b_(FacilityLocation @this)
        {
            CqlInterval<CqlDateTime> g_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "locationPeriod");
            CqlDateTime h_ = context.Operators.Start(g_);

            return h_;
        };
        IEnumerable<FacilityLocation> c_ = context.Operators.SortBy<FacilityLocation>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        FacilityLocation d_ = context.Operators.Last<FacilityLocation>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(d_, "locationPeriod");
        CqlDateTime f_ = context.Operators.End(e_);

        return f_;
    }


    [CqlFunctionDefinition("HospitalDischargeTime")]
    public CqlDateTime HospitalDischargeTime(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        CqlInterval<CqlDateTime> a_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Encounter, "relevantPeriod");
        CqlDateTime b_ = context.Operators.End(a_);

        return b_;
    }


    [CqlFunctionDefinition("Hospitalization")]
    public CqlInterval<CqlDateTime> Hospitalization(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        PositiveEncounterPerformed[] a_ = [
            Encounter,
        ];
        CqlInterval<CqlDateTime> b_(PositiveEncounterPerformed Visit)
        {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<PositiveEncounterPerformed> g_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, f_, default, "PositiveEncounterPerformed"));
            bool? h_(PositiveEncounterPerformed LastED)
            {
                CqlInterval<CqlDateTime> t_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                CqlDateTime u_ = context.Operators.End(t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlQuantity x_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlDateTime aa_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(y_, aa_, true, true);
                bool? ac_ = context.Operators.In<CqlDateTime>(u_, ab_, default);
                CqlDateTime ae_ = context.Operators.Start(v_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ac_, af_);

                return ag_;
            };
            IEnumerable<PositiveEncounterPerformed> i_ = context.Operators.Where<PositiveEncounterPerformed>(g_, h_);
            object j_(PositiveEncounterPerformed @this)
            {
                CqlInterval<CqlDateTime> ah_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                CqlDateTime ai_ = context.Operators.End(ah_);

                return ai_;
            };
            IEnumerable<PositiveEncounterPerformed> k_ = context.Operators.SortBy<PositiveEncounterPerformed>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            PositiveEncounterPerformed l_ = context.Operators.Last<PositiveEncounterPerformed>(k_);
            CqlInterval<CqlDateTime> m_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(l_, "relevantPeriod");
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlInterval<CqlDateTime> o_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlDateTime r_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(n_ ?? p_, r_, true, true);

            return s_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<PositiveEncounterPerformed, CqlInterval<CqlDateTime>>((IEnumerable<PositiveEncounterPerformed>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

        return e_;
    }


    [CqlFunctionDefinition("HospitalizationLengthofStay")]
    public int? HospitalizationLengthofStay(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        CqlInterval<CqlDateTime> a_ = this.Hospitalization(context, Encounter);
        int? b_ = this.LengthInDays(context, a_);

        return b_;
    }


    [CqlFunctionDefinition("HospitalizationLocations")]
    public IEnumerable<FacilityLocation> HospitalizationLocations(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        PositiveEncounterPerformed[] a_ = [
            Encounter,
        ];
        IEnumerable<FacilityLocation> b_(PositiveEncounterPerformed Visit)
        {
            IEnumerable<FacilityLocation> f_()
            {
                bool g_()
                {
                    CqlValueSet h_ = this.Emergency_Department_Visit(context);
                    IEnumerable<PositiveEncounterPerformed> i_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, h_, default, "PositiveEncounterPerformed"));
                    bool? j_(PositiveEncounterPerformed LastED)
                    {
                        CqlInterval<CqlDateTime> o_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                        CqlDateTime p_ = context.Operators.End(o_);
                        CqlInterval<CqlDateTime> q_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime r_ = context.Operators.Start(q_);
                        CqlQuantity s_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                        CqlDateTime v_ = context.Operators.Start(q_);
                        CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);
                        bool? x_ = context.Operators.In<CqlDateTime>(p_, w_, default);
                        CqlDateTime z_ = context.Operators.Start(q_);
                        bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                        bool? ab_ = context.Operators.And(x_, aa_);

                        return ab_;
                    };
                    IEnumerable<PositiveEncounterPerformed> k_ = context.Operators.Where<PositiveEncounterPerformed>(i_, j_);
                    object l_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> ac_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime ad_ = context.Operators.End(ac_);

                        return ad_;
                    };
                    IEnumerable<PositiveEncounterPerformed> m_ = context.Operators.SortBy<PositiveEncounterPerformed>(k_, l_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed n_ = context.Operators.Last<PositiveEncounterPerformed>(m_);

                    return n_ is null;
                };
                if (g_())
                {
                    IEnumerable<FacilityLocation> ae_ = context.Operators.LateBoundProperty<IEnumerable<FacilityLocation>>(Visit, "facilityLocations");

                    return ae_;
                }
                else
                {
                    CqlValueSet af_ = this.Emergency_Department_Visit(context);
                    IEnumerable<PositiveEncounterPerformed> ag_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, af_, default, "PositiveEncounterPerformed"));
                    bool? ah_(PositiveEncounterPerformed LastED)
                    {
                        CqlInterval<CqlDateTime> aq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                        CqlDateTime ar_ = context.Operators.End(aq_);
                        CqlInterval<CqlDateTime> as_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime at_ = context.Operators.Start(as_);
                        CqlQuantity au_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime av_ = context.Operators.Subtract(at_, au_);
                        CqlDateTime ax_ = context.Operators.Start(as_);
                        CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(av_, ax_, true, true);
                        bool? az_ = context.Operators.In<CqlDateTime>(ar_, ay_, default);
                        CqlDateTime bb_ = context.Operators.Start(as_);
                        bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                        bool? bd_ = context.Operators.And(az_, bc_);

                        return bd_;
                    };
                    IEnumerable<PositiveEncounterPerformed> ai_ = context.Operators.Where<PositiveEncounterPerformed>(ag_, ah_);
                    object aj_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> be_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime bf_ = context.Operators.End(be_);

                        return bf_;
                    };
                    IEnumerable<PositiveEncounterPerformed> ak_ = context.Operators.SortBy<PositiveEncounterPerformed>(ai_, aj_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed al_ = context.Operators.Last<PositiveEncounterPerformed>(ak_);
                    IEnumerable<FacilityLocation> am_ = context.Operators.LateBoundProperty<IEnumerable<FacilityLocation>>(al_, "facilityLocations");
                    IEnumerable<FacilityLocation> an_ = context.Operators.LateBoundProperty<IEnumerable<FacilityLocation>>(Visit, "facilityLocations");
                    IEnumerable<FacilityLocation>[] ao_ = [
                        am_,
                        an_,
                    ];
                    IEnumerable<FacilityLocation> ap_ = context.Operators.Flatten<FacilityLocation>((IEnumerable<IEnumerable<FacilityLocation>>)ao_);

                    return ap_;
                }
            };

            return f_();
        };
        IEnumerable<IEnumerable<FacilityLocation>> c_ = context.Operators.Select<PositiveEncounterPerformed, IEnumerable<FacilityLocation>>((IEnumerable<PositiveEncounterPerformed>)a_, b_);
        IEnumerable<IEnumerable<FacilityLocation>> d_ = context.Operators.Distinct<IEnumerable<FacilityLocation>>(c_);
        IEnumerable<FacilityLocation> e_ = context.Operators.SingletonFrom<IEnumerable<FacilityLocation>>(d_);

        return e_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        PositiveEncounterPerformed[] a_ = [
            Encounter,
        ];
        CqlInterval<CqlDateTime> b_(PositiveEncounterPerformed Visit)
        {
            CqlValueSet f_ = this.Emergency_Department_Visit(context);
            IEnumerable<PositiveEncounterPerformed> g_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, f_, default, "PositiveEncounterPerformed"));
            bool? h_(PositiveEncounterPerformed LastED)
            {
                CqlInterval<CqlDateTime> ac_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlValueSet ae_ = this.Observation_Services(context);
                IEnumerable<PositiveEncounterPerformed> af_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, ae_, default, "PositiveEncounterPerformed"));
                bool? ag_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> br_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime bs_ = context.Operators.End(br_);
                    CqlInterval<CqlDateTime> bt_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime bu_ = context.Operators.Start(bt_);
                    CqlQuantity bv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bw_ = context.Operators.Subtract(bu_, bv_);
                    CqlDateTime by_ = context.Operators.Start(bt_);
                    CqlInterval<CqlDateTime> bz_ = context.Operators.Interval(bw_, by_, true, true);
                    bool? ca_ = context.Operators.In<CqlDateTime>(bs_, bz_, default);
                    CqlDateTime cc_ = context.Operators.Start(bt_);
                    bool? cd_ = context.Operators.Not((bool?)(cc_ is null));
                    bool? ce_ = context.Operators.And(ca_, cd_);

                    return ce_;
                };
                IEnumerable<PositiveEncounterPerformed> ah_ = context.Operators.Where<PositiveEncounterPerformed>(af_, ag_);
                object ai_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> cf_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime cg_ = context.Operators.End(cf_);

                    return cg_;
                };
                IEnumerable<PositiveEncounterPerformed> aj_ = context.Operators.SortBy<PositiveEncounterPerformed>(ah_, ai_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed ak_ = context.Operators.Last<PositiveEncounterPerformed>(aj_);
                CqlInterval<CqlDateTime> al_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(ak_, "relevantPeriod");
                CqlDateTime am_ = context.Operators.Start(al_);
                CqlInterval<CqlDateTime> an_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlQuantity ap_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime aq_ = context.Operators.Subtract(am_ ?? ao_, ap_);
                IEnumerable<PositiveEncounterPerformed> as_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, ae_, default, "PositiveEncounterPerformed"));
                bool? at_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> ch_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime ci_ = context.Operators.End(ch_);
                    CqlInterval<CqlDateTime> cj_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime ck_ = context.Operators.Start(cj_);
                    CqlQuantity cl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cm_ = context.Operators.Subtract(ck_, cl_);
                    CqlDateTime co_ = context.Operators.Start(cj_);
                    CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(cm_, co_, true, true);
                    bool? cq_ = context.Operators.In<CqlDateTime>(ci_, cp_, default);
                    CqlDateTime cs_ = context.Operators.Start(cj_);
                    bool? ct_ = context.Operators.Not((bool?)(cs_ is null));
                    bool? cu_ = context.Operators.And(cq_, ct_);

                    return cu_;
                };
                IEnumerable<PositiveEncounterPerformed> au_ = context.Operators.Where<PositiveEncounterPerformed>(as_, at_);
                object av_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> cv_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime cw_ = context.Operators.End(cv_);

                    return cw_;
                };
                IEnumerable<PositiveEncounterPerformed> aw_ = context.Operators.SortBy<PositiveEncounterPerformed>(au_, av_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed ax_ = context.Operators.Last<PositiveEncounterPerformed>(aw_);
                CqlInterval<CqlDateTime> ay_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(ax_, "relevantPeriod");
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlDateTime bb_ = context.Operators.Start(an_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(aq_, az_ ?? bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(ad_, bc_, default);
                IEnumerable<PositiveEncounterPerformed> bf_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, ae_, default, "PositiveEncounterPerformed"));
                bool? bg_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> cx_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime cy_ = context.Operators.End(cx_);
                    CqlInterval<CqlDateTime> cz_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime da_ = context.Operators.Start(cz_);
                    CqlQuantity db_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dc_ = context.Operators.Subtract(da_, db_);
                    CqlDateTime de_ = context.Operators.Start(cz_);
                    CqlInterval<CqlDateTime> df_ = context.Operators.Interval(dc_, de_, true, true);
                    bool? dg_ = context.Operators.In<CqlDateTime>(cy_, df_, default);
                    CqlDateTime di_ = context.Operators.Start(cz_);
                    bool? dj_ = context.Operators.Not((bool?)(di_ is null));
                    bool? dk_ = context.Operators.And(dg_, dj_);

                    return dk_;
                };
                IEnumerable<PositiveEncounterPerformed> bh_ = context.Operators.Where<PositiveEncounterPerformed>(bf_, bg_);
                object bi_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> dl_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime dm_ = context.Operators.End(dl_);

                    return dm_;
                };
                IEnumerable<PositiveEncounterPerformed> bj_ = context.Operators.SortBy<PositiveEncounterPerformed>(bh_, bi_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed bk_ = context.Operators.Last<PositiveEncounterPerformed>(bj_);
                CqlInterval<CqlDateTime> bl_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(bk_, "relevantPeriod");
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlDateTime bo_ = context.Operators.Start(an_);
                bool? bp_ = context.Operators.Not((bool?)((bm_ ?? bo_) is null));
                bool? bq_ = context.Operators.And(bd_, bp_);

                return bq_;
            };
            IEnumerable<PositiveEncounterPerformed> i_ = context.Operators.Where<PositiveEncounterPerformed>(g_, h_);
            object j_(PositiveEncounterPerformed @this)
            {
                CqlInterval<CqlDateTime> dn_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                CqlDateTime do_ = context.Operators.End(dn_);

                return do_;
            };
            IEnumerable<PositiveEncounterPerformed> k_ = context.Operators.SortBy<PositiveEncounterPerformed>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            PositiveEncounterPerformed l_ = context.Operators.Last<PositiveEncounterPerformed>(k_);
            CqlInterval<CqlDateTime> m_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(l_, "relevantPeriod");
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<PositiveEncounterPerformed> p_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, o_, default, "PositiveEncounterPerformed"));
            bool? q_(PositiveEncounterPerformed LastObs)
            {
                CqlInterval<CqlDateTime> dp_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                CqlDateTime dq_ = context.Operators.End(dp_);
                CqlInterval<CqlDateTime> dr_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                CqlDateTime ds_ = context.Operators.Start(dr_);
                CqlQuantity dt_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime du_ = context.Operators.Subtract(ds_, dt_);
                CqlDateTime dw_ = context.Operators.Start(dr_);
                CqlInterval<CqlDateTime> dx_ = context.Operators.Interval(du_, dw_, true, true);
                bool? dy_ = context.Operators.In<CqlDateTime>(dq_, dx_, default);
                CqlDateTime ea_ = context.Operators.Start(dr_);
                bool? eb_ = context.Operators.Not((bool?)(ea_ is null));
                bool? ec_ = context.Operators.And(dy_, eb_);

                return ec_;
            };
            IEnumerable<PositiveEncounterPerformed> r_ = context.Operators.Where<PositiveEncounterPerformed>(p_, q_);
            object s_(PositiveEncounterPerformed @this)
            {
                CqlInterval<CqlDateTime> ed_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                CqlDateTime ee_ = context.Operators.End(ed_);

                return ee_;
            };
            IEnumerable<PositiveEncounterPerformed> t_ = context.Operators.SortBy<PositiveEncounterPerformed>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            PositiveEncounterPerformed u_ = context.Operators.Last<PositiveEncounterPerformed>(t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(u_, "relevantPeriod");
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDateTime aa_ = context.Operators.End(x_);
            CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(n_ ?? w_ ?? y_, aa_, true, true);

            return ab_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<PositiveEncounterPerformed, CqlInterval<CqlDateTime>>((IEnumerable<PositiveEncounterPerformed>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

        return e_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        PositiveEncounterPerformed[] a_ = [
            Encounter,
        ];
        CqlInterval<CqlDateTime> b_(PositiveEncounterPerformed Visit)
        {
            CqlValueSet f_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<PositiveEncounterPerformed> g_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, f_, default, "PositiveEncounterPerformed"));
            bool? h_(PositiveEncounterPerformed LastSurgeryOP)
            {
                CqlInterval<CqlDateTime> al_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastSurgeryOP, "relevantPeriod");
                CqlDateTime am_ = context.Operators.End(al_);
                CqlValueSet an_ = this.Emergency_Department_Visit(context);
                IEnumerable<PositiveEncounterPerformed> ao_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, an_, default, "PositiveEncounterPerformed"));
                bool? ap_(PositiveEncounterPerformed LastED)
                {
                    CqlInterval<CqlDateTime> db_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                    CqlDateTime dc_ = context.Operators.End(db_);
                    CqlValueSet dd_ = this.Observation_Services(context);
                    IEnumerable<PositiveEncounterPerformed> de_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, dd_, default, "PositiveEncounterPerformed"));
                    bool? df_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> eq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime er_ = context.Operators.End(eq_);
                        CqlInterval<CqlDateTime> es_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime et_ = context.Operators.Start(es_);
                        CqlQuantity eu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ev_ = context.Operators.Subtract(et_, eu_);
                        CqlDateTime ex_ = context.Operators.Start(es_);
                        CqlInterval<CqlDateTime> ey_ = context.Operators.Interval(ev_, ex_, true, true);
                        bool? ez_ = context.Operators.In<CqlDateTime>(er_, ey_, default);
                        CqlDateTime fb_ = context.Operators.Start(es_);
                        bool? fc_ = context.Operators.Not((bool?)(fb_ is null));
                        bool? fd_ = context.Operators.And(ez_, fc_);

                        return fd_;
                    };
                    IEnumerable<PositiveEncounterPerformed> dg_ = context.Operators.Where<PositiveEncounterPerformed>(de_, df_);
                    object dh_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> fe_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime ff_ = context.Operators.End(fe_);

                        return ff_;
                    };
                    IEnumerable<PositiveEncounterPerformed> di_ = context.Operators.SortBy<PositiveEncounterPerformed>(dg_, dh_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed dj_ = context.Operators.Last<PositiveEncounterPerformed>(di_);
                    CqlInterval<CqlDateTime> dk_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(dj_, "relevantPeriod");
                    CqlDateTime dl_ = context.Operators.Start(dk_);
                    CqlInterval<CqlDateTime> dm_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime dn_ = context.Operators.Start(dm_);
                    CqlQuantity do_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dp_ = context.Operators.Subtract(dl_ ?? dn_, do_);
                    IEnumerable<PositiveEncounterPerformed> dr_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, dd_, default, "PositiveEncounterPerformed"));
                    bool? ds_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> fg_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime fh_ = context.Operators.End(fg_);
                        CqlInterval<CqlDateTime> fi_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime fj_ = context.Operators.Start(fi_);
                        CqlQuantity fk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime fl_ = context.Operators.Subtract(fj_, fk_);
                        CqlDateTime fn_ = context.Operators.Start(fi_);
                        CqlInterval<CqlDateTime> fo_ = context.Operators.Interval(fl_, fn_, true, true);
                        bool? fp_ = context.Operators.In<CqlDateTime>(fh_, fo_, default);
                        CqlDateTime fr_ = context.Operators.Start(fi_);
                        bool? fs_ = context.Operators.Not((bool?)(fr_ is null));
                        bool? ft_ = context.Operators.And(fp_, fs_);

                        return ft_;
                    };
                    IEnumerable<PositiveEncounterPerformed> dt_ = context.Operators.Where<PositiveEncounterPerformed>(dr_, ds_);
                    object du_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> fu_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime fv_ = context.Operators.End(fu_);

                        return fv_;
                    };
                    IEnumerable<PositiveEncounterPerformed> dv_ = context.Operators.SortBy<PositiveEncounterPerformed>(dt_, du_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed dw_ = context.Operators.Last<PositiveEncounterPerformed>(dv_);
                    CqlInterval<CqlDateTime> dx_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(dw_, "relevantPeriod");
                    CqlDateTime dy_ = context.Operators.Start(dx_);
                    CqlDateTime ea_ = context.Operators.Start(dm_);
                    CqlInterval<CqlDateTime> eb_ = context.Operators.Interval(dp_, dy_ ?? ea_, true, true);
                    bool? ec_ = context.Operators.In<CqlDateTime>(dc_, eb_, default);
                    IEnumerable<PositiveEncounterPerformed> ee_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, dd_, default, "PositiveEncounterPerformed"));
                    bool? ef_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> fw_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime fx_ = context.Operators.End(fw_);
                        CqlInterval<CqlDateTime> fy_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime fz_ = context.Operators.Start(fy_);
                        CqlQuantity ga_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime gb_ = context.Operators.Subtract(fz_, ga_);
                        CqlDateTime gd_ = context.Operators.Start(fy_);
                        CqlInterval<CqlDateTime> ge_ = context.Operators.Interval(gb_, gd_, true, true);
                        bool? gf_ = context.Operators.In<CqlDateTime>(fx_, ge_, default);
                        CqlDateTime gh_ = context.Operators.Start(fy_);
                        bool? gi_ = context.Operators.Not((bool?)(gh_ is null));
                        bool? gj_ = context.Operators.And(gf_, gi_);

                        return gj_;
                    };
                    IEnumerable<PositiveEncounterPerformed> eg_ = context.Operators.Where<PositiveEncounterPerformed>(ee_, ef_);
                    object eh_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> gk_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime gl_ = context.Operators.End(gk_);

                        return gl_;
                    };
                    IEnumerable<PositiveEncounterPerformed> ei_ = context.Operators.SortBy<PositiveEncounterPerformed>(eg_, eh_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed ej_ = context.Operators.Last<PositiveEncounterPerformed>(ei_);
                    CqlInterval<CqlDateTime> ek_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(ej_, "relevantPeriod");
                    CqlDateTime el_ = context.Operators.Start(ek_);
                    CqlDateTime en_ = context.Operators.Start(dm_);
                    bool? eo_ = context.Operators.Not((bool?)((el_ ?? en_) is null));
                    bool? ep_ = context.Operators.And(ec_, eo_);

                    return ep_;
                };
                IEnumerable<PositiveEncounterPerformed> aq_ = context.Operators.Where<PositiveEncounterPerformed>(ao_, ap_);
                object ar_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> gm_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime gn_ = context.Operators.End(gm_);

                    return gn_;
                };
                IEnumerable<PositiveEncounterPerformed> as_ = context.Operators.SortBy<PositiveEncounterPerformed>(aq_, ar_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed at_ = context.Operators.Last<PositiveEncounterPerformed>(as_);
                CqlInterval<CqlDateTime> au_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(at_, "relevantPeriod");
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlValueSet aw_ = this.Observation_Services(context);
                IEnumerable<PositiveEncounterPerformed> ax_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, aw_, default, "PositiveEncounterPerformed"));
                bool? ay_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> go_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime gp_ = context.Operators.End(go_);
                    CqlInterval<CqlDateTime> gq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime gr_ = context.Operators.Start(gq_);
                    CqlQuantity gs_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime gt_ = context.Operators.Subtract(gr_, gs_);
                    CqlDateTime gv_ = context.Operators.Start(gq_);
                    CqlInterval<CqlDateTime> gw_ = context.Operators.Interval(gt_, gv_, true, true);
                    bool? gx_ = context.Operators.In<CqlDateTime>(gp_, gw_, default);
                    CqlDateTime gz_ = context.Operators.Start(gq_);
                    bool? ha_ = context.Operators.Not((bool?)(gz_ is null));
                    bool? hb_ = context.Operators.And(gx_, ha_);

                    return hb_;
                };
                IEnumerable<PositiveEncounterPerformed> az_ = context.Operators.Where<PositiveEncounterPerformed>(ax_, ay_);
                object ba_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> hc_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime hd_ = context.Operators.End(hc_);

                    return hd_;
                };
                IEnumerable<PositiveEncounterPerformed> bb_ = context.Operators.SortBy<PositiveEncounterPerformed>(az_, ba_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed bc_ = context.Operators.Last<PositiveEncounterPerformed>(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(bc_, "relevantPeriod");
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlInterval<CqlDateTime> bf_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                CqlDateTime bg_ = context.Operators.Start(bf_);
                CqlQuantity bh_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime bi_ = context.Operators.Subtract(av_ ?? be_ ?? bg_, bh_);
                IEnumerable<PositiveEncounterPerformed> bk_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, an_, default, "PositiveEncounterPerformed"));
                bool? bl_(PositiveEncounterPerformed LastED)
                {
                    CqlInterval<CqlDateTime> he_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                    CqlDateTime hf_ = context.Operators.End(he_);
                    CqlValueSet hg_ = this.Observation_Services(context);
                    IEnumerable<PositiveEncounterPerformed> hh_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, hg_, default, "PositiveEncounterPerformed"));
                    bool? hi_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> it_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime iu_ = context.Operators.End(it_);
                        CqlInterval<CqlDateTime> iv_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime iw_ = context.Operators.Start(iv_);
                        CqlQuantity ix_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime iy_ = context.Operators.Subtract(iw_, ix_);
                        CqlDateTime ja_ = context.Operators.Start(iv_);
                        CqlInterval<CqlDateTime> jb_ = context.Operators.Interval(iy_, ja_, true, true);
                        bool? jc_ = context.Operators.In<CqlDateTime>(iu_, jb_, default);
                        CqlDateTime je_ = context.Operators.Start(iv_);
                        bool? jf_ = context.Operators.Not((bool?)(je_ is null));
                        bool? jg_ = context.Operators.And(jc_, jf_);

                        return jg_;
                    };
                    IEnumerable<PositiveEncounterPerformed> hj_ = context.Operators.Where<PositiveEncounterPerformed>(hh_, hi_);
                    object hk_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> jh_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime ji_ = context.Operators.End(jh_);

                        return ji_;
                    };
                    IEnumerable<PositiveEncounterPerformed> hl_ = context.Operators.SortBy<PositiveEncounterPerformed>(hj_, hk_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed hm_ = context.Operators.Last<PositiveEncounterPerformed>(hl_);
                    CqlInterval<CqlDateTime> hn_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(hm_, "relevantPeriod");
                    CqlDateTime ho_ = context.Operators.Start(hn_);
                    CqlInterval<CqlDateTime> hp_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime hq_ = context.Operators.Start(hp_);
                    CqlQuantity hr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime hs_ = context.Operators.Subtract(ho_ ?? hq_, hr_);
                    IEnumerable<PositiveEncounterPerformed> hu_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, hg_, default, "PositiveEncounterPerformed"));
                    bool? hv_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> jj_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime jk_ = context.Operators.End(jj_);
                        CqlInterval<CqlDateTime> jl_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime jm_ = context.Operators.Start(jl_);
                        CqlQuantity jn_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime jo_ = context.Operators.Subtract(jm_, jn_);
                        CqlDateTime jq_ = context.Operators.Start(jl_);
                        CqlInterval<CqlDateTime> jr_ = context.Operators.Interval(jo_, jq_, true, true);
                        bool? js_ = context.Operators.In<CqlDateTime>(jk_, jr_, default);
                        CqlDateTime ju_ = context.Operators.Start(jl_);
                        bool? jv_ = context.Operators.Not((bool?)(ju_ is null));
                        bool? jw_ = context.Operators.And(js_, jv_);

                        return jw_;
                    };
                    IEnumerable<PositiveEncounterPerformed> hw_ = context.Operators.Where<PositiveEncounterPerformed>(hu_, hv_);
                    object hx_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> jx_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime jy_ = context.Operators.End(jx_);

                        return jy_;
                    };
                    IEnumerable<PositiveEncounterPerformed> hy_ = context.Operators.SortBy<PositiveEncounterPerformed>(hw_, hx_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed hz_ = context.Operators.Last<PositiveEncounterPerformed>(hy_);
                    CqlInterval<CqlDateTime> ia_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(hz_, "relevantPeriod");
                    CqlDateTime ib_ = context.Operators.Start(ia_);
                    CqlDateTime id_ = context.Operators.Start(hp_);
                    CqlInterval<CqlDateTime> ie_ = context.Operators.Interval(hs_, ib_ ?? id_, true, true);
                    bool? if_ = context.Operators.In<CqlDateTime>(hf_, ie_, default);
                    IEnumerable<PositiveEncounterPerformed> ih_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, hg_, default, "PositiveEncounterPerformed"));
                    bool? ii_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> jz_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime ka_ = context.Operators.End(jz_);
                        CqlInterval<CqlDateTime> kb_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime kc_ = context.Operators.Start(kb_);
                        CqlQuantity kd_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ke_ = context.Operators.Subtract(kc_, kd_);
                        CqlDateTime kg_ = context.Operators.Start(kb_);
                        CqlInterval<CqlDateTime> kh_ = context.Operators.Interval(ke_, kg_, true, true);
                        bool? ki_ = context.Operators.In<CqlDateTime>(ka_, kh_, default);
                        CqlDateTime kk_ = context.Operators.Start(kb_);
                        bool? kl_ = context.Operators.Not((bool?)(kk_ is null));
                        bool? km_ = context.Operators.And(ki_, kl_);

                        return km_;
                    };
                    IEnumerable<PositiveEncounterPerformed> ij_ = context.Operators.Where<PositiveEncounterPerformed>(ih_, ii_);
                    object ik_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> kn_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime ko_ = context.Operators.End(kn_);

                        return ko_;
                    };
                    IEnumerable<PositiveEncounterPerformed> il_ = context.Operators.SortBy<PositiveEncounterPerformed>(ij_, ik_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed im_ = context.Operators.Last<PositiveEncounterPerformed>(il_);
                    CqlInterval<CqlDateTime> in_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(im_, "relevantPeriod");
                    CqlDateTime io_ = context.Operators.Start(in_);
                    CqlDateTime iq_ = context.Operators.Start(hp_);
                    bool? ir_ = context.Operators.Not((bool?)((io_ ?? iq_) is null));
                    bool? is_ = context.Operators.And(if_, ir_);

                    return is_;
                };
                IEnumerable<PositiveEncounterPerformed> bm_ = context.Operators.Where<PositiveEncounterPerformed>(bk_, bl_);
                object bn_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> kp_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime kq_ = context.Operators.End(kp_);

                    return kq_;
                };
                IEnumerable<PositiveEncounterPerformed> bo_ = context.Operators.SortBy<PositiveEncounterPerformed>(bm_, bn_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed bp_ = context.Operators.Last<PositiveEncounterPerformed>(bo_);
                CqlInterval<CqlDateTime> bq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(bp_, "relevantPeriod");
                CqlDateTime br_ = context.Operators.Start(bq_);
                IEnumerable<PositiveEncounterPerformed> bt_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, aw_, default, "PositiveEncounterPerformed"));
                bool? bu_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> kr_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime ks_ = context.Operators.End(kr_);
                    CqlInterval<CqlDateTime> kt_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime ku_ = context.Operators.Start(kt_);
                    CqlQuantity kv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime kw_ = context.Operators.Subtract(ku_, kv_);
                    CqlDateTime ky_ = context.Operators.Start(kt_);
                    CqlInterval<CqlDateTime> kz_ = context.Operators.Interval(kw_, ky_, true, true);
                    bool? la_ = context.Operators.In<CqlDateTime>(ks_, kz_, default);
                    CqlDateTime lc_ = context.Operators.Start(kt_);
                    bool? ld_ = context.Operators.Not((bool?)(lc_ is null));
                    bool? le_ = context.Operators.And(la_, ld_);

                    return le_;
                };
                IEnumerable<PositiveEncounterPerformed> bv_ = context.Operators.Where<PositiveEncounterPerformed>(bt_, bu_);
                object bw_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> lf_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime lg_ = context.Operators.End(lf_);

                    return lg_;
                };
                IEnumerable<PositiveEncounterPerformed> bx_ = context.Operators.SortBy<PositiveEncounterPerformed>(bv_, bw_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed by_ = context.Operators.Last<PositiveEncounterPerformed>(bx_);
                CqlInterval<CqlDateTime> bz_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(by_, "relevantPeriod");
                CqlDateTime ca_ = context.Operators.Start(bz_);
                CqlDateTime cc_ = context.Operators.Start(bf_);
                CqlInterval<CqlDateTime> cd_ = context.Operators.Interval(bi_, br_ ?? ca_ ?? cc_, true, true);
                bool? ce_ = context.Operators.In<CqlDateTime>(am_, cd_, default);
                IEnumerable<PositiveEncounterPerformed> cg_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, an_, default, "PositiveEncounterPerformed"));
                bool? ch_(PositiveEncounterPerformed LastED)
                {
                    CqlInterval<CqlDateTime> lh_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                    CqlDateTime li_ = context.Operators.End(lh_);
                    CqlValueSet lj_ = this.Observation_Services(context);
                    IEnumerable<PositiveEncounterPerformed> lk_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, lj_, default, "PositiveEncounterPerformed"));
                    bool? ll_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> mw_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime mx_ = context.Operators.End(mw_);
                        CqlInterval<CqlDateTime> my_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime mz_ = context.Operators.Start(my_);
                        CqlQuantity na_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nb_ = context.Operators.Subtract(mz_, na_);
                        CqlDateTime nd_ = context.Operators.Start(my_);
                        CqlInterval<CqlDateTime> ne_ = context.Operators.Interval(nb_, nd_, true, true);
                        bool? nf_ = context.Operators.In<CqlDateTime>(mx_, ne_, default);
                        CqlDateTime nh_ = context.Operators.Start(my_);
                        bool? ni_ = context.Operators.Not((bool?)(nh_ is null));
                        bool? nj_ = context.Operators.And(nf_, ni_);

                        return nj_;
                    };
                    IEnumerable<PositiveEncounterPerformed> lm_ = context.Operators.Where<PositiveEncounterPerformed>(lk_, ll_);
                    object ln_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> nk_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime nl_ = context.Operators.End(nk_);

                        return nl_;
                    };
                    IEnumerable<PositiveEncounterPerformed> lo_ = context.Operators.SortBy<PositiveEncounterPerformed>(lm_, ln_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed lp_ = context.Operators.Last<PositiveEncounterPerformed>(lo_);
                    CqlInterval<CqlDateTime> lq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(lp_, "relevantPeriod");
                    CqlDateTime lr_ = context.Operators.Start(lq_);
                    CqlInterval<CqlDateTime> ls_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime lt_ = context.Operators.Start(ls_);
                    CqlQuantity lu_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime lv_ = context.Operators.Subtract(lr_ ?? lt_, lu_);
                    IEnumerable<PositiveEncounterPerformed> lx_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, lj_, default, "PositiveEncounterPerformed"));
                    bool? ly_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> nm_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime nn_ = context.Operators.End(nm_);
                        CqlInterval<CqlDateTime> no_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime np_ = context.Operators.Start(no_);
                        CqlQuantity nq_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime nr_ = context.Operators.Subtract(np_, nq_);
                        CqlDateTime nt_ = context.Operators.Start(no_);
                        CqlInterval<CqlDateTime> nu_ = context.Operators.Interval(nr_, nt_, true, true);
                        bool? nv_ = context.Operators.In<CqlDateTime>(nn_, nu_, default);
                        CqlDateTime nx_ = context.Operators.Start(no_);
                        bool? ny_ = context.Operators.Not((bool?)(nx_ is null));
                        bool? nz_ = context.Operators.And(nv_, ny_);

                        return nz_;
                    };
                    IEnumerable<PositiveEncounterPerformed> lz_ = context.Operators.Where<PositiveEncounterPerformed>(lx_, ly_);
                    object ma_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> oa_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime ob_ = context.Operators.End(oa_);

                        return ob_;
                    };
                    IEnumerable<PositiveEncounterPerformed> mb_ = context.Operators.SortBy<PositiveEncounterPerformed>(lz_, ma_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed mc_ = context.Operators.Last<PositiveEncounterPerformed>(mb_);
                    CqlInterval<CqlDateTime> md_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(mc_, "relevantPeriod");
                    CqlDateTime me_ = context.Operators.Start(md_);
                    CqlDateTime mg_ = context.Operators.Start(ls_);
                    CqlInterval<CqlDateTime> mh_ = context.Operators.Interval(lv_, me_ ?? mg_, true, true);
                    bool? mi_ = context.Operators.In<CqlDateTime>(li_, mh_, default);
                    IEnumerable<PositiveEncounterPerformed> mk_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, lj_, default, "PositiveEncounterPerformed"));
                    bool? ml_(PositiveEncounterPerformed LastObs)
                    {
                        CqlInterval<CqlDateTime> oc_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                        CqlDateTime od_ = context.Operators.End(oc_);
                        CqlInterval<CqlDateTime> oe_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                        CqlDateTime of_ = context.Operators.Start(oe_);
                        CqlQuantity og_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime oh_ = context.Operators.Subtract(of_, og_);
                        CqlDateTime oj_ = context.Operators.Start(oe_);
                        CqlInterval<CqlDateTime> ok_ = context.Operators.Interval(oh_, oj_, true, true);
                        bool? ol_ = context.Operators.In<CqlDateTime>(od_, ok_, default);
                        CqlDateTime on_ = context.Operators.Start(oe_);
                        bool? oo_ = context.Operators.Not((bool?)(on_ is null));
                        bool? op_ = context.Operators.And(ol_, oo_);

                        return op_;
                    };
                    IEnumerable<PositiveEncounterPerformed> mm_ = context.Operators.Where<PositiveEncounterPerformed>(mk_, ml_);
                    object mn_(PositiveEncounterPerformed @this)
                    {
                        CqlInterval<CqlDateTime> oq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                        CqlDateTime or_ = context.Operators.End(oq_);

                        return or_;
                    };
                    IEnumerable<PositiveEncounterPerformed> mo_ = context.Operators.SortBy<PositiveEncounterPerformed>(mm_, mn_, System.ComponentModel.ListSortDirection.Ascending);
                    PositiveEncounterPerformed mp_ = context.Operators.Last<PositiveEncounterPerformed>(mo_);
                    CqlInterval<CqlDateTime> mq_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(mp_, "relevantPeriod");
                    CqlDateTime mr_ = context.Operators.Start(mq_);
                    CqlDateTime mt_ = context.Operators.Start(ls_);
                    bool? mu_ = context.Operators.Not((bool?)((mr_ ?? mt_) is null));
                    bool? mv_ = context.Operators.And(mi_, mu_);

                    return mv_;
                };
                IEnumerable<PositiveEncounterPerformed> ci_ = context.Operators.Where<PositiveEncounterPerformed>(cg_, ch_);
                object cj_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> os_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime ot_ = context.Operators.End(os_);

                    return ot_;
                };
                IEnumerable<PositiveEncounterPerformed> ck_ = context.Operators.SortBy<PositiveEncounterPerformed>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed cl_ = context.Operators.Last<PositiveEncounterPerformed>(ck_);
                CqlInterval<CqlDateTime> cm_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(cl_, "relevantPeriod");
                CqlDateTime cn_ = context.Operators.Start(cm_);
                IEnumerable<PositiveEncounterPerformed> cp_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, aw_, default, "PositiveEncounterPerformed"));
                bool? cq_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> ou_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime ov_ = context.Operators.End(ou_);
                    CqlInterval<CqlDateTime> ow_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime ox_ = context.Operators.Start(ow_);
                    CqlQuantity oy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime oz_ = context.Operators.Subtract(ox_, oy_);
                    CqlDateTime pb_ = context.Operators.Start(ow_);
                    CqlInterval<CqlDateTime> pc_ = context.Operators.Interval(oz_, pb_, true, true);
                    bool? pd_ = context.Operators.In<CqlDateTime>(ov_, pc_, default);
                    CqlDateTime pf_ = context.Operators.Start(ow_);
                    bool? pg_ = context.Operators.Not((bool?)(pf_ is null));
                    bool? ph_ = context.Operators.And(pd_, pg_);

                    return ph_;
                };
                IEnumerable<PositiveEncounterPerformed> cr_ = context.Operators.Where<PositiveEncounterPerformed>(cp_, cq_);
                object cs_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> pi_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime pj_ = context.Operators.End(pi_);

                    return pj_;
                };
                IEnumerable<PositiveEncounterPerformed> ct_ = context.Operators.SortBy<PositiveEncounterPerformed>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed cu_ = context.Operators.Last<PositiveEncounterPerformed>(ct_);
                CqlInterval<CqlDateTime> cv_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(cu_, "relevantPeriod");
                CqlDateTime cw_ = context.Operators.Start(cv_);
                CqlDateTime cy_ = context.Operators.Start(bf_);
                bool? cz_ = context.Operators.Not((bool?)((cn_ ?? cw_ ?? cy_) is null));
                bool? da_ = context.Operators.And(ce_, cz_);

                return da_;
            };
            IEnumerable<PositiveEncounterPerformed> i_ = context.Operators.Where<PositiveEncounterPerformed>(g_, h_);
            object j_(PositiveEncounterPerformed @this)
            {
                CqlInterval<CqlDateTime> pk_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                CqlDateTime pl_ = context.Operators.End(pk_);

                return pl_;
            };
            IEnumerable<PositiveEncounterPerformed> k_ = context.Operators.SortBy<PositiveEncounterPerformed>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            PositiveEncounterPerformed l_ = context.Operators.Last<PositiveEncounterPerformed>(k_);
            CqlInterval<CqlDateTime> m_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(l_, "relevantPeriod");
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<PositiveEncounterPerformed> p_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, o_, default, "PositiveEncounterPerformed"));
            bool? q_(PositiveEncounterPerformed LastED)
            {
                CqlInterval<CqlDateTime> pm_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastED, "relevantPeriod");
                CqlDateTime pn_ = context.Operators.End(pm_);
                CqlValueSet po_ = this.Observation_Services(context);
                IEnumerable<PositiveEncounterPerformed> pp_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, po_, default, "PositiveEncounterPerformed"));
                bool? pq_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> rb_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime rc_ = context.Operators.End(rb_);
                    CqlInterval<CqlDateTime> rd_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime re_ = context.Operators.Start(rd_);
                    CqlQuantity rf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rg_ = context.Operators.Subtract(re_, rf_);
                    CqlDateTime ri_ = context.Operators.Start(rd_);
                    CqlInterval<CqlDateTime> rj_ = context.Operators.Interval(rg_, ri_, true, true);
                    bool? rk_ = context.Operators.In<CqlDateTime>(rc_, rj_, default);
                    CqlDateTime rm_ = context.Operators.Start(rd_);
                    bool? rn_ = context.Operators.Not((bool?)(rm_ is null));
                    bool? ro_ = context.Operators.And(rk_, rn_);

                    return ro_;
                };
                IEnumerable<PositiveEncounterPerformed> pr_ = context.Operators.Where<PositiveEncounterPerformed>(pp_, pq_);
                object ps_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> rp_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime rq_ = context.Operators.End(rp_);

                    return rq_;
                };
                IEnumerable<PositiveEncounterPerformed> pt_ = context.Operators.SortBy<PositiveEncounterPerformed>(pr_, ps_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed pu_ = context.Operators.Last<PositiveEncounterPerformed>(pt_);
                CqlInterval<CqlDateTime> pv_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(pu_, "relevantPeriod");
                CqlDateTime pw_ = context.Operators.Start(pv_);
                CqlInterval<CqlDateTime> px_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                CqlDateTime py_ = context.Operators.Start(px_);
                CqlQuantity pz_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime qa_ = context.Operators.Subtract(pw_ ?? py_, pz_);
                IEnumerable<PositiveEncounterPerformed> qc_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, po_, default, "PositiveEncounterPerformed"));
                bool? qd_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> rr_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime rs_ = context.Operators.End(rr_);
                    CqlInterval<CqlDateTime> rt_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime ru_ = context.Operators.Start(rt_);
                    CqlQuantity rv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime rw_ = context.Operators.Subtract(ru_, rv_);
                    CqlDateTime ry_ = context.Operators.Start(rt_);
                    CqlInterval<CqlDateTime> rz_ = context.Operators.Interval(rw_, ry_, true, true);
                    bool? sa_ = context.Operators.In<CqlDateTime>(rs_, rz_, default);
                    CqlDateTime sc_ = context.Operators.Start(rt_);
                    bool? sd_ = context.Operators.Not((bool?)(sc_ is null));
                    bool? se_ = context.Operators.And(sa_, sd_);

                    return se_;
                };
                IEnumerable<PositiveEncounterPerformed> qe_ = context.Operators.Where<PositiveEncounterPerformed>(qc_, qd_);
                object qf_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> sf_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime sg_ = context.Operators.End(sf_);

                    return sg_;
                };
                IEnumerable<PositiveEncounterPerformed> qg_ = context.Operators.SortBy<PositiveEncounterPerformed>(qe_, qf_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed qh_ = context.Operators.Last<PositiveEncounterPerformed>(qg_);
                CqlInterval<CqlDateTime> qi_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(qh_, "relevantPeriod");
                CqlDateTime qj_ = context.Operators.Start(qi_);
                CqlDateTime ql_ = context.Operators.Start(px_);
                CqlInterval<CqlDateTime> qm_ = context.Operators.Interval(qa_, qj_ ?? ql_, true, true);
                bool? qn_ = context.Operators.In<CqlDateTime>(pn_, qm_, default);
                IEnumerable<PositiveEncounterPerformed> qp_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, po_, default, "PositiveEncounterPerformed"));
                bool? qq_(PositiveEncounterPerformed LastObs)
                {
                    CqlInterval<CqlDateTime> sh_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                    CqlDateTime si_ = context.Operators.End(sh_);
                    CqlInterval<CqlDateTime> sj_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                    CqlDateTime sk_ = context.Operators.Start(sj_);
                    CqlQuantity sl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime sm_ = context.Operators.Subtract(sk_, sl_);
                    CqlDateTime so_ = context.Operators.Start(sj_);
                    CqlInterval<CqlDateTime> sp_ = context.Operators.Interval(sm_, so_, true, true);
                    bool? sq_ = context.Operators.In<CqlDateTime>(si_, sp_, default);
                    CqlDateTime ss_ = context.Operators.Start(sj_);
                    bool? st_ = context.Operators.Not((bool?)(ss_ is null));
                    bool? su_ = context.Operators.And(sq_, st_);

                    return su_;
                };
                IEnumerable<PositiveEncounterPerformed> qr_ = context.Operators.Where<PositiveEncounterPerformed>(qp_, qq_);
                object qs_(PositiveEncounterPerformed @this)
                {
                    CqlInterval<CqlDateTime> sv_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                    CqlDateTime sw_ = context.Operators.End(sv_);

                    return sw_;
                };
                IEnumerable<PositiveEncounterPerformed> qt_ = context.Operators.SortBy<PositiveEncounterPerformed>(qr_, qs_, System.ComponentModel.ListSortDirection.Ascending);
                PositiveEncounterPerformed qu_ = context.Operators.Last<PositiveEncounterPerformed>(qt_);
                CqlInterval<CqlDateTime> qv_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(qu_, "relevantPeriod");
                CqlDateTime qw_ = context.Operators.Start(qv_);
                CqlDateTime qy_ = context.Operators.Start(px_);
                bool? qz_ = context.Operators.Not((bool?)((qw_ ?? qy_) is null));
                bool? ra_ = context.Operators.And(qn_, qz_);

                return ra_;
            };
            IEnumerable<PositiveEncounterPerformed> r_ = context.Operators.Where<PositiveEncounterPerformed>(p_, q_);
            object s_(PositiveEncounterPerformed @this)
            {
                CqlInterval<CqlDateTime> sx_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                CqlDateTime sy_ = context.Operators.End(sx_);

                return sy_;
            };
            IEnumerable<PositiveEncounterPerformed> t_ = context.Operators.SortBy<PositiveEncounterPerformed>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            PositiveEncounterPerformed u_ = context.Operators.Last<PositiveEncounterPerformed>(t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(u_, "relevantPeriod");
            CqlDateTime w_ = context.Operators.Start(v_);
            CqlValueSet x_ = this.Observation_Services(context);
            IEnumerable<PositiveEncounterPerformed> y_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, x_, default, "PositiveEncounterPerformed"));
            bool? z_(PositiveEncounterPerformed LastObs)
            {
                CqlInterval<CqlDateTime> sz_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(LastObs, "relevantPeriod");
                CqlDateTime ta_ = context.Operators.End(sz_);
                CqlInterval<CqlDateTime> tb_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
                CqlDateTime tc_ = context.Operators.Start(tb_);
                CqlQuantity td_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime te_ = context.Operators.Subtract(tc_, td_);
                CqlDateTime tg_ = context.Operators.Start(tb_);
                CqlInterval<CqlDateTime> th_ = context.Operators.Interval(te_, tg_, true, true);
                bool? ti_ = context.Operators.In<CqlDateTime>(ta_, th_, default);
                CqlDateTime tk_ = context.Operators.Start(tb_);
                bool? tl_ = context.Operators.Not((bool?)(tk_ is null));
                bool? tm_ = context.Operators.And(ti_, tl_);

                return tm_;
            };
            IEnumerable<PositiveEncounterPerformed> aa_ = context.Operators.Where<PositiveEncounterPerformed>(y_, z_);
            object ab_(PositiveEncounterPerformed @this)
            {
                CqlInterval<CqlDateTime> tn_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(@this, "relevantPeriod");
                CqlDateTime to_ = context.Operators.End(tn_);

                return to_;
            };
            IEnumerable<PositiveEncounterPerformed> ac_ = context.Operators.SortBy<PositiveEncounterPerformed>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
            PositiveEncounterPerformed ad_ = context.Operators.Last<PositiveEncounterPerformed>(ac_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(ad_, "relevantPeriod");
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(Visit, "relevantPeriod");
            CqlDateTime ah_ = context.Operators.Start(ag_);
            CqlDateTime aj_ = context.Operators.End(ag_);
            CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(n_ ?? w_ ?? af_ ?? ah_, aj_, true, true);

            return ak_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<PositiveEncounterPerformed, CqlInterval<CqlDateTime>>((IEnumerable<PositiveEncounterPerformed>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

        return e_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationLengthofStay")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, PositiveEncounterPerformed Encounter)
    {
        CqlInterval<CqlDateTime> a_ = this.HospitalizationWithObservation(context, Encounter);
        int? b_ = this.LengthInDays(context, a_);

        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<PositiveEncounterPerformed> Inpatient_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<PositiveEncounterPerformed> b_ = context.Operators.Retrieve<PositiveEncounterPerformed>(new RetrieveParameters(default, a_, default, "PositiveEncounterPerformed"));
        bool? c_(PositiveEncounterPerformed EncounterInpatient)
        {
            CqlInterval<CqlDateTime> e_ = context.Operators.LateBoundProperty<CqlInterval<CqlDateTime>>(EncounterInpatient, "relevantPeriod");
            CqlDateTime f_ = context.Operators.End(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");

            return h_;
        };
        IEnumerable<PositiveEncounterPerformed> d_ = context.Operators.Where<PositiveEncounterPerformed>(b_, c_);

        return d_;
    }


    [CqlFunctionDefinition("Latest")]
    public CqlDateTime Latest(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_()
        {
            if ((this.HasEnd(context, period)) ?? false)
            {
                CqlDateTime b_ = context.Operators.End(period);

                return b_;
            }
            else
            {
                CqlDateTime c_ = context.Operators.Start(period);

                return c_;
            }
        };

        return a_();
    }


    [CqlFunctionDefinition("LatestOf")]
    public CqlDateTime LatestOf(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> period)
    {
        CqlInterval<CqlDateTime> a_ = this.NormalizeInterval(context, pointInTime, period);
        CqlDateTime b_ = this.Latest(context, a_);

        return b_;
    }


    [CqlFunctionDefinition("LengthInDays")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime> Value)
    {
        CqlDateTime a_ = context.Operators.Start(Value);
        CqlDateTime b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

        return c_;
    }


    [CqlFunctionDefinition("NormalizeInterval")]
    public CqlInterval<CqlDateTime> NormalizeInterval(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> period)
    {
        CqlInterval<CqlDateTime> a_()
        {
            if ((context.Operators.Not((bool?)(pointInTime is null))) ?? false)
            {
                CqlInterval<CqlDateTime> b_ = context.Operators.Interval(pointInTime, pointInTime, true, true);

                return b_;
            }
            else if ((context.Operators.Not((bool?)(period is null))) ?? false)
            {
                return period;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return a_();
    }


    [CqlExpressionDefinition("Patient")]
    public PatientDetails Patient(CqlContext context)
    {
        IEnumerable<PatientDetails> a_ = context.Operators.Retrieve<PatientDetails>(new RetrieveParameters(default, default, default, "Patient"));
        PatientDetails b_ = context.Operators.SingletonFrom<PatientDetails>(a_);

        return b_;
    }


    [CqlFunctionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier as part of a\ntiming phrase is preferred to communicate intent to perform day-level comparison, as well as for\ngeneral readability.")]
    public CqlInterval<CqlDate> ToDateInterval(CqlContext context, CqlInterval<CqlDateTime> period)
    {
        CqlDateTime a_ = context.Operators.Start(period);
        CqlDate b_ = context.Operators.DateFrom(a_);
        CqlDateTime c_ = context.Operators.End(period);
        CqlDate d_ = context.Operators.DateFrom(c_);
        CqlInterval<CqlDate> e_ = context.Operators.Interval(b_, d_, true, true);

        return e_;
    }


    #endregion Functions and Expressions

}
