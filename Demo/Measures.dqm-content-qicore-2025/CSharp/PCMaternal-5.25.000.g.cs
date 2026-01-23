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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("PCMaternal", "5.25.000")]
public partial class PCMaternal_5_25_000 : ILibrary, ILibraryInternals, ISingleton<PCMaternal_5_25_000>
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
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("PCMaternal-5.25.000", "Measurement Period", null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (9)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Encounter With Age Range")]
    public IEnumerable<Encounter> Encounter_With_Age_Range(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Encounter_With_Age_Range, Encounter_With_Age_Range_Compute, context) ?? Encounter_With_Age_Range_Compute(context);

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
            bool? n_ = context.Operators.In<int?>(l_, m_, default);
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
            CqlValueSet f_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter LastEDOBTriage) {
                Period ag_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                CqlValueSet aj_ = this.Observation_Services(context);
                IEnumerable<Encounter> ak_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? al_(Encounter LastObs) {
                    Period ch_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ch_);
                    CqlDateTime cj_ = context.Operators.End(ci_);
                    Period ck_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                    CqlDateTime cm_ = context.Operators.Start(cl_);
                    CqlQuantity cn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime co_ = context.Operators.Subtract(cm_, cn_);
                    CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                    CqlDateTime cr_ = context.Operators.Start(cq_);
                    CqlInterval<CqlDateTime> cs_ = context.Operators.Interval(co_, cr_, true, true);
                    bool? ct_ = context.Operators.In<CqlDateTime>(cj_, cs_, default);
                    CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                    CqlDateTime cw_ = context.Operators.Start(cv_);
                    bool? cx_ = context.Operators.Not((bool?)(cw_ is null));
                    bool? cy_ = context.Operators.And(ct_, cx_);
                    Code<Encounter.EncounterStatus> cz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? da_ = cz_?.Value;
                    Code<Encounter.EncounterStatus> db_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(da_);
                    bool? dc_ = context.Operators.Equal(db_, "finished");
                    bool? dd_ = context.Operators.And(cy_, dc_);
                    return dd_;
                }

                IEnumerable<Encounter> am_ = context.Operators.Where<Encounter>(ak_, al_);

                object an_(Encounter @this) {
                    Period de_ = @this?.Period;
                    CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, de_);
                    CqlDateTime dg_ = context.Operators.End(df_);
                    return dg_;
                }

                IEnumerable<Encounter> ao_ = context.Operators.SortBy<Encounter>(am_, an_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ap_ = context.Operators.Last<Encounter>(ao_);
                Period aq_ = ap_?.Period;
                CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                CqlDateTime as_ = context.Operators.Start(ar_);
                Period at_ = Visit?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ax_ = context.Operators.Subtract(as_ ?? av_, aw_);
                IEnumerable<Encounter> az_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? ba_(Encounter LastObs) {
                    Period dh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> di_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dh_);
                    CqlDateTime dj_ = context.Operators.End(di_);
                    Period dk_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                    CqlDateTime dm_ = context.Operators.Start(dl_);
                    CqlQuantity dn_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime do_ = context.Operators.Subtract(dm_, dn_);
                    CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                    CqlDateTime dr_ = context.Operators.Start(dq_);
                    CqlInterval<CqlDateTime> ds_ = context.Operators.Interval(do_, dr_, true, true);
                    bool? dt_ = context.Operators.In<CqlDateTime>(dj_, ds_, default);
                    CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                    CqlDateTime dw_ = context.Operators.Start(dv_);
                    bool? dx_ = context.Operators.Not((bool?)(dw_ is null));
                    bool? dy_ = context.Operators.And(dt_, dx_);
                    Code<Encounter.EncounterStatus> dz_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ea_ = dz_?.Value;
                    Code<Encounter.EncounterStatus> eb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ea_);
                    bool? ec_ = context.Operators.Equal(eb_, "finished");
                    bool? ed_ = context.Operators.And(dy_, ec_);
                    return ed_;
                }

                IEnumerable<Encounter> bb_ = context.Operators.Where<Encounter>(az_, ba_);

                object bc_(Encounter @this) {
                    Period ee_ = @this?.Period;
                    CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ee_);
                    CqlDateTime eg_ = context.Operators.End(ef_);
                    return eg_;
                }

                IEnumerable<Encounter> bd_ = context.Operators.SortBy<Encounter>(bb_, bc_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter be_ = context.Operators.Last<Encounter>(bd_);
                Period bf_ = be_?.Period;
                CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bf_);
                CqlDateTime bh_ = context.Operators.Start(bg_);
                CqlInterval<CqlDateTime> bj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(ax_, bh_ ?? bk_, true, true);
                bool? bm_ = context.Operators.In<CqlDateTime>(ai_, bl_, default);
                IEnumerable<Encounter> bo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bp_(Encounter LastObs) {
                    Period eh_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> ei_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eh_);
                    CqlDateTime ej_ = context.Operators.End(ei_);
                    Period ek_ = Visit?.Period;
                    CqlInterval<CqlDateTime> el_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                    CqlDateTime em_ = context.Operators.Start(el_);
                    CqlQuantity en_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime eo_ = context.Operators.Subtract(em_, en_);
                    CqlInterval<CqlDateTime> eq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                    CqlDateTime er_ = context.Operators.Start(eq_);
                    CqlInterval<CqlDateTime> es_ = context.Operators.Interval(eo_, er_, true, true);
                    bool? et_ = context.Operators.In<CqlDateTime>(ej_, es_, default);
                    CqlInterval<CqlDateTime> ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                    CqlDateTime ew_ = context.Operators.Start(ev_);
                    bool? ex_ = context.Operators.Not((bool?)(ew_ is null));
                    bool? ey_ = context.Operators.And(et_, ex_);
                    Code<Encounter.EncounterStatus> ez_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? fa_ = ez_?.Value;
                    Code<Encounter.EncounterStatus> fb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fa_);
                    bool? fc_ = context.Operators.Equal(fb_, "finished");
                    bool? fd_ = context.Operators.And(ey_, fc_);
                    return fd_;
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(bo_, bp_);

                object br_(Encounter @this) {
                    Period fe_ = @this?.Period;
                    CqlInterval<CqlDateTime> ff_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fe_);
                    CqlDateTime fg_ = context.Operators.End(ff_);
                    return fg_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                CqlDateTime bz_ = context.Operators.Start(by_);
                bool? ca_ = context.Operators.Not((bool?)((bw_ ?? bz_) is null));
                bool? cb_ = context.Operators.And(bm_, ca_);
                Code<Encounter.EncounterStatus> cc_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? cd_ = cc_?.Value;
                Code<Encounter.EncounterStatus> ce_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cd_);
                bool? cf_ = context.Operators.Equal(ce_, "finished");
                bool? cg_ = context.Operators.And(cb_, cf_);
                return cg_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

            object j_(Encounter @this) {
                Period fh_ = @this?.Period;
                CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fh_);
                CqlDateTime fj_ = context.Operators.End(fi_);
                return fj_;
            }

            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? r_(Encounter LastObs) {
                Period fk_ = LastObs?.Period;
                CqlInterval<CqlDateTime> fl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fk_);
                CqlDateTime fm_ = context.Operators.End(fl_);
                Period fn_ = Visit?.Period;
                CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fn_);
                CqlDateTime fp_ = context.Operators.Start(fo_);
                CqlQuantity fq_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime fr_ = context.Operators.Subtract(fp_, fq_);
                CqlInterval<CqlDateTime> ft_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fn_);
                CqlDateTime fu_ = context.Operators.Start(ft_);
                CqlInterval<CqlDateTime> fv_ = context.Operators.Interval(fr_, fu_, true, true);
                bool? fw_ = context.Operators.In<CqlDateTime>(fm_, fv_, default);
                CqlInterval<CqlDateTime> fy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fn_);
                CqlDateTime fz_ = context.Operators.Start(fy_);
                bool? ga_ = context.Operators.Not((bool?)(fz_ is null));
                bool? gb_ = context.Operators.And(fw_, ga_);
                Code<Encounter.EncounterStatus> gc_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? gd_ = gc_?.Value;
                Code<Encounter.EncounterStatus> ge_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gd_);
                bool? gf_ = context.Operators.Equal(ge_, "finished");
                bool? gg_ = context.Operators.And(gb_, gf_);
                return gg_;
            }

            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

            object t_(Encounter @this) {
                Period gh_ = @this?.Period;
                CqlInterval<CqlDateTime> gi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gh_);
                CqlDateTime gj_ = context.Operators.End(gi_);
                return gj_;
            }

            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ae_ = context.Operators.End(ad_);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ae_, true, true);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Delivery Encounter With Age Range")]
    public IEnumerable<Encounter> Delivery_Encounter_With_Age_Range(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Delivery_Encounter_With_Age_Range, Delivery_Encounter_With_Age_Range_Compute, context) ?? Delivery_Encounter_With_Age_Range_Compute(context);

    private IEnumerable<Encounter> Delivery_Encounter_With_Age_Range_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Age_Range(context);

        IEnumerable<Encounter> b_(Encounter EncounterWithAge) {
            CqlValueSet d_ = this.Delivery_Procedures(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? f_(Procedure DeliveryProcedure) {
                Code<EventStatus> j_ = DeliveryProcedure?.StatusElement;
                EventStatus? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                bool? m_ = context.Operators.Equal(l_, "completed");

                object n_() {

                    bool t_() {
                        DataType x_ = DeliveryProcedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;
                        return z_;
                    }


                    bool u_() {
                        DataType aa_ = DeliveryProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        return ac_;
                    }


                    bool v_() {
                        DataType ad_ = DeliveryProcedure?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;
                        return af_;
                    }


                    bool w_() {
                        DataType ag_ = DeliveryProcedure?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        return ai_;
                    }

                    if (t_())
                    {
                        DataType aj_ = DeliveryProcedure?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = DeliveryProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = DeliveryProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = DeliveryProcedure?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlInterval<CqlDateTime> q_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? r_ = context.Operators.In<CqlDateTime>(p_, q_, default);
                bool? s_ = context.Operators.And(m_, r_);
                return s_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            Encounter h_(Procedure DeliveryProcedure) => EncounterWithAge;
            IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

            object t_() {

                bool ad_() {
                    DataType ag_ = TimeOfDelivery?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = TimeOfDelivery?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlDateTime>;
                    return al_;
                }


                bool af_() {
                    DataType am_ = TimeOfDelivery?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = TimeOfDelivery?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return (aq_ as CqlDateTime) as object;
                }
                else if (ae_())
                {
                    DataType ar_ = TimeOfDelivery?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (af_())
                {
                    DataType at_ = TimeOfDelivery?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
            CqlInterval<CqlDateTime> v_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, default);
            bool? x_ = context.Operators.And(s_, w_);
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            bool? ab_ = context.Operators.In<CqlDateTime>(z_ as CqlDateTime, v_, default);
            bool? ac_ = context.Operators.And(x_, ab_);
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
                    bool bf_ = be_ is CqlInterval<CqlDateTime>;
                    return bf_;
                }


                bool az_() {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    bool bi_ = bh_ is CqlDateTime;
                    return bi_;
                }

                if (ax_())
                {
                    DataType bj_ = @this?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return (bk_ as CqlDateTime) as object;
                }
                else if (ay_())
                {
                    DataType bl_ = @this?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    return (bm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (az_())
                {
                    DataType bn_ = @this?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    return (bo_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_());
            return aw_;
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

            object t_() {

                bool af_() {
                    DataType ai_ = EstimatedDateOfDelivery?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    return ak_;
                }


                bool ag_() {
                    DataType al_ = EstimatedDateOfDelivery?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlInterval<CqlDateTime>;
                    return an_;
                }


                bool ah_() {
                    DataType ao_ = EstimatedDateOfDelivery?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    return aq_;
                }

                if (af_())
                {
                    DataType ar_ = EstimatedDateOfDelivery?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return (as_ as CqlDateTime) as object;
                }
                else if (ag_())
                {
                    DataType at_ = EstimatedDateOfDelivery?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return (au_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ah_())
                {
                    DataType av_ = EstimatedDateOfDelivery?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
            CqlDateTime v_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity w_ = context.Operators.Quantity(42m, "weeks");
            CqlDateTime x_ = context.Operators.Subtract(v_, w_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(x_, v_, true, true);
            bool? aa_ = context.Operators.In<CqlDateTime>(u_, z_, default);
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
        return j_ as CqlDateTime;
    }


    [CqlExpressionDefinition("Variable Calculated Gestational Age")]
    public IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Variable_Calculated_Gestational_Age, Variable_Calculated_Gestational_Age_Compute, context) ?? Variable_Calculated_Gestational_Age_Compute(context);

    private IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Delivery_Encounter_With_Age_Range(context);

        (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? b_(Encounter DeliveryEncounter) {
            Id e_ = DeliveryEncounter?.IdElement;
            string f_ = e_?.Value;
            int? g_ = this.calculatedGestationalAge(context, DeliveryEncounter);
            (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)? h_ = (CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterID, int? CalculatedCGA)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("lastEstimatedGestationalAge")]
    public CqlQuantity lastEstimatedGestationalAge(CqlContext context, Encounter TheEncounter)
    {
        CqlValueSet a_ = this.Estimated_Gestational_Age_at_Delivery(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-simple-observation"));

        bool? c_(Observation EstimatedGestationalAge) {

            object j_() {

                bool as_() {
                    DataType av_ = EstimatedGestationalAge?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlDateTime;
                    return ax_;
                }


                bool at_() {
                    DataType ay_ = EstimatedGestationalAge?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlInterval<CqlDateTime>;
                    return ba_;
                }


                bool au_() {
                    DataType bb_ = EstimatedGestationalAge?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlDateTime;
                    return bd_;
                }

                if (as_())
                {
                    DataType be_ = EstimatedGestationalAge?.Effective;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    return (bf_ as CqlDateTime) as object;
                }
                else if (at_())
                {
                    DataType bg_ = EstimatedGestationalAge?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    return (bh_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (au_())
                {
                    DataType bi_ = EstimatedGestationalAge?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    return (bj_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_());
            CqlDateTime l_ = this.lastTimeOfDelivery(context, TheEncounter);
            CqlQuantity m_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime n_ = context.Operators.Subtract(l_, m_);
            CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, l_, true, true);
            bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, default);
            bool? s_ = context.Operators.Not((bool?)(l_ is null));
            bool? t_ = context.Operators.And(q_, s_);
            DataType u_ = EstimatedGestationalAge?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            bool? w_ = context.Operators.Not((bool?)(v_ is null));
            bool? x_ = context.Operators.And(t_, w_);
            Code<ObservationStatus> y_ = EstimatedGestationalAge?.StatusElement;
            ObservationStatus? z_ = y_?.Value;
            string aa_ = context.Operators.Convert<string>(z_);
            string[] ab_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
            bool? ad_ = context.Operators.And(x_, ac_);

            object ae_() {

                bool bk_() {
                    DataType bn_ = EstimatedGestationalAge?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlDateTime;
                    return bp_;
                }


                bool bl_() {
                    DataType bq_ = EstimatedGestationalAge?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlDateTime>;
                    return bs_;
                }


                bool bm_() {
                    DataType bt_ = EstimatedGestationalAge?.Effective;
                    object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    bool bv_ = bu_ is CqlDateTime;
                    return bv_;
                }

                if (bk_())
                {
                    DataType bw_ = EstimatedGestationalAge?.Effective;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    return (bx_ as CqlDateTime) as object;
                }
                else if (bl_())
                {
                    DataType by_ = EstimatedGestationalAge?.Effective;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    return (bz_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bm_())
                {
                    DataType ca_ = EstimatedGestationalAge?.Effective;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    return (cb_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_());
            bool? ah_ = context.Operators.SameAs(af_, l_, "day");

            object ai_() {

                bool cc_() {
                    DataType cf_ = EstimatedGestationalAge?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlDateTime;
                    return ch_;
                }


                bool cd_() {
                    DataType ci_ = EstimatedGestationalAge?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    bool ck_ = cj_ is CqlInterval<CqlDateTime>;
                    return ck_;
                }


                bool ce_() {
                    DataType cl_ = EstimatedGestationalAge?.Effective;
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    bool cn_ = cm_ is CqlDateTime;
                    return cn_;
                }

                if (cc_())
                {
                    DataType co_ = EstimatedGestationalAge?.Effective;
                    object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    return (cp_ as CqlDateTime) as object;
                }
                else if (cd_())
                {
                    DataType cq_ = EstimatedGestationalAge?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    return (cr_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ce_())
                {
                    DataType cs_ = EstimatedGestationalAge?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    return (ct_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_());
            CqlInterval<CqlDateTime> ak_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? al_ = context.Operators.In<CqlDateTime>(aj_, ak_, default);
            bool? am_ = context.Operators.And(ah_, al_);
            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
            bool? aq_ = context.Operators.And(am_, ap_);
            bool? ar_ = context.Operators.Or(ad_, aq_);
            return ar_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object cu_() {

                bool cw_() {
                    DataType cz_ = @this?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlDateTime;
                    return db_;
                }


                bool cx_() {
                    DataType dc_ = @this?.Effective;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    bool de_ = dd_ is CqlInterval<CqlDateTime>;
                    return de_;
                }


                bool cy_() {
                    DataType df_ = @this?.Effective;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;
                    return dh_;
                }

                if (cw_())
                {
                    DataType di_ = @this?.Effective;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    return (dj_ as CqlDateTime) as object;
                }
                else if (cx_())
                {
                    DataType dk_ = @this?.Effective;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    return (dl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cy_())
                {
                    DataType dm_ = @this?.Effective;
                    object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                    return (dn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime cv_ = QICoreCommon_4_0_000.Instance.earliest(context, cu_());
            return cv_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        DataType h_ = g_?.Value;
        object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
        return i_ as CqlQuantity;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (5)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Encounter_With_Age_Range = -1;
    private int _cacheIndex_Delivery_Encounter_With_Age_Range = -1;
    private int _cacheIndex_Variable_Calculated_Gestational_Age = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    // Reference to the execution cache instance that initialized this library
    private CqlLibrarySetInvocationCache _cache;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="cache">The execution cache instance performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibrarySetInvocationCache cache,
        int startIndex)
    {
        // Skip if already initialized by this cache instance (allows re-initialization with different cache)
        if (_cache == cache)
            return 0;

        _cache = cache;

        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_Encounter_With_Age_Range = index++;
        _cacheIndex_Delivery_Encounter_With_Age_Range = index++;
        _cacheIndex_Variable_Calculated_Gestational_Age = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private PCMaternal_5_25_000() {}

    public static PCMaternal_5_25_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "PCMaternal";
    public string Version => "5.25.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (1)

    private static CqlTupleMetadata CqlTupleMetadata_DjNbNOhJZXGJDNQeiTBabEOBB = new(
       [typeof(string), typeof(int?)],
       ["EncounterID", "CalculatedCGA"]);

    #endregion CqlTupleMetadata Properties

}
