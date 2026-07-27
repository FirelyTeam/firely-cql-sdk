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
            CqlValueSet f_ = this.ED_Visit_and_OB_Triage(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter LastEDOBTriage) {
                Period ae_ = LastEDOBTriage?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.End(af_);
                CqlValueSet ah_ = this.Observation_Services(context);
                IEnumerable<Encounter> ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? aj_(Encounter LastObs) {
                    Period bv_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                    CqlDateTime bx_ = context.Operators.End(bw_);
                    Period by_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                    CqlDateTime ca_ = context.Operators.Start(bz_);
                    CqlQuantity cb_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cc_ = context.Operators.Subtract(ca_, cb_);
                    CqlInterval<CqlDateTime> cd_ = context.Operators.Interval(cc_, ca_, true, true);
                    bool? ce_ = context.Operators.In<CqlDateTime>(bx_, cd_, (string)default);
                    bool? cf_ = context.Operators.Not((bool?)(ca_ is null));
                    bool? cg_ = context.Operators.And(ce_, cf_);
                    Code<Encounter.EncounterStatus> ch_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ci_ = ch_?.Value;
                    Code<Encounter.EncounterStatus> cj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ci_);
                    bool? ck_ = context.Operators.Equal(cj_, "finished");
                    bool? cl_ = context.Operators.And(cg_, ck_);
                    return cl_;
                }

                IEnumerable<Encounter> ak_ = context.Operators.Where<Encounter>(ai_, aj_);

                object al_(Encounter @this) {
                    Period cm_ = @this?.Period;
                    CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                    CqlDateTime co_ = context.Operators.End(cn_);
                    return co_;
                }

                IEnumerable<Encounter> am_ = context.Operators.SortBy<Encounter>(ak_, al_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter an_ = context.Operators.Last<Encounter>(am_);
                Period ao_ = an_?.Period;
                CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
                CqlDateTime aq_ = context.Operators.Start(ap_);
                Period ar_ = Visit?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlQuantity au_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime av_ = context.Operators.Subtract(aq_ ?? at_, au_);

                bool? aw_(Encounter LastObs) {
                    Period cp_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cp_);
                    CqlDateTime cr_ = context.Operators.End(cq_);
                    Period cs_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                    CqlDateTime cu_ = context.Operators.Start(ct_);
                    CqlQuantity cv_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cw_ = context.Operators.Subtract(cu_, cv_);
                    CqlInterval<CqlDateTime> cx_ = context.Operators.Interval(cw_, cu_, true, true);
                    bool? cy_ = context.Operators.In<CqlDateTime>(cr_, cx_, (string)default);
                    bool? cz_ = context.Operators.Not((bool?)(cu_ is null));
                    bool? da_ = context.Operators.And(cy_, cz_);
                    Code<Encounter.EncounterStatus> db_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dc_ = db_?.Value;
                    Code<Encounter.EncounterStatus> dd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dc_);
                    bool? de_ = context.Operators.Equal(dd_, "finished");
                    bool? df_ = context.Operators.And(da_, de_);
                    return df_;
                }

                IEnumerable<Encounter> ax_ = context.Operators.Where<Encounter>(ai_, aw_);

                object ay_(Encounter @this) {
                    Period dg_ = @this?.Period;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.End(dh_);
                    return di_;
                }

                IEnumerable<Encounter> az_ = context.Operators.SortBy<Encounter>(ax_, ay_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter ba_ = context.Operators.Last<Encounter>(az_);
                Period bb_ = ba_?.Period;
                CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(av_, bd_ ?? at_, true, true);
                bool? bf_ = context.Operators.In<CqlDateTime>(ag_, be_, (string)default);

                bool? bg_(Encounter LastObs) {
                    Period dj_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dj_);
                    CqlDateTime dl_ = context.Operators.End(dk_);
                    Period dm_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                    CqlDateTime do_ = context.Operators.Start(dn_);
                    CqlQuantity dp_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime dq_ = context.Operators.Subtract(do_, dp_);
                    CqlInterval<CqlDateTime> dr_ = context.Operators.Interval(dq_, do_, true, true);
                    bool? ds_ = context.Operators.In<CqlDateTime>(dl_, dr_, (string)default);
                    bool? dt_ = context.Operators.Not((bool?)(do_ is null));
                    bool? du_ = context.Operators.And(ds_, dt_);
                    Code<Encounter.EncounterStatus> dv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dw_ = dv_?.Value;
                    Code<Encounter.EncounterStatus> dx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dw_);
                    bool? dy_ = context.Operators.Equal(dx_, "finished");
                    bool? dz_ = context.Operators.And(du_, dy_);
                    return dz_;
                }

                IEnumerable<Encounter> bh_ = context.Operators.Where<Encounter>(ai_, bg_);

                object bi_(Encounter @this) {
                    Period ea_ = @this?.Period;
                    CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                    CqlDateTime ec_ = context.Operators.End(eb_);
                    return ec_;
                }

                IEnumerable<Encounter> bj_ = context.Operators.SortBy<Encounter>(bh_, bi_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bk_ = context.Operators.Last<Encounter>(bj_);
                Period bl_ = bk_?.Period;
                CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                CqlDateTime bn_ = context.Operators.Start(bm_);
                bool? bo_ = context.Operators.Not((bool?)((bn_ ?? at_) is null));
                bool? bp_ = context.Operators.And(bf_, bo_);
                Code<Encounter.EncounterStatus> bq_ = LastEDOBTriage?.StatusElement;
                Encounter.EncounterStatus? br_ = bq_?.Value;
                Code<Encounter.EncounterStatus> bs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(br_);
                bool? bt_ = context.Operators.Equal(bs_, "finished");
                bool? bu_ = context.Operators.And(bp_, bt_);
                return bu_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);

            object j_(Encounter @this) {
                Period ed_ = @this?.Period;
                CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                CqlDateTime ef_ = context.Operators.End(ee_);
                return ef_;
            }

            IEnumerable<Encounter> k_ = context.Operators.SortBy<Encounter>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter l_ = context.Operators.Last<Encounter>(k_);
            Period m_ = l_?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlValueSet p_ = this.Observation_Services(context);
            IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? r_(Encounter LastObs) {
                Period eg_ = LastObs?.Period;
                CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                CqlDateTime ei_ = context.Operators.End(eh_);
                Period ej_ = Visit?.Period;
                CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                CqlDateTime el_ = context.Operators.Start(ek_);
                CqlQuantity em_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime en_ = context.Operators.Subtract(el_, em_);
                CqlInterval<CqlDateTime> eo_ = context.Operators.Interval(en_, el_, true, true);
                bool? ep_ = context.Operators.In<CqlDateTime>(ei_, eo_, (string)default);
                bool? eq_ = context.Operators.Not((bool?)(el_ is null));
                bool? er_ = context.Operators.And(ep_, eq_);
                Code<Encounter.EncounterStatus> es_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? et_ = es_?.Value;
                Code<Encounter.EncounterStatus> eu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(et_);
                bool? ev_ = context.Operators.Equal(eu_, "finished");
                bool? ew_ = context.Operators.And(er_, ev_);
                return ew_;
            }

            IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);

            object t_(Encounter @this) {
                Period ex_ = @this?.Period;
                CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ex_);
                CqlDateTime ez_ = context.Operators.End(ey_);
                return ez_;
            }

            IEnumerable<Encounter> u_ = context.Operators.SortBy<Encounter>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter v_ = context.Operators.Last<Encounter>(u_);
            Period w_ = v_?.Period;
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            Period z_ = Visit?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlDateTime ac_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(o_ ?? y_ ?? ab_, ac_, true, true);
            return ad_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
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
                Code<EventStatus> i_ = DeliveryProcedure?.StatusElement;
                EventStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                bool? l_ = context.Operators.Equal(k_, "completed");

                object m_() {

                    bool s_() {
                        DataType w_ = DeliveryProcedure?.Performed;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        bool y_ = x_ is CqlDateTime;
                        return y_;
                    }


                    bool t_() {
                        DataType z_ = DeliveryProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlQuantity;
                        return ab_;
                    }


                    bool u_() {
                        DataType ac_ = DeliveryProcedure?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                        return ae_;
                    }


                    bool v_() {
                        DataType af_ = DeliveryProcedure?.Performed;
                        object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                        bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                        return ah_;
                    }

                    if (s_())
                    {
                        DataType ai_ = DeliveryProcedure?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return aj_ as CqlDateTime;
                    }
                    else if (t_())
                    {
                        DataType ak_ = DeliveryProcedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return al_ as CqlQuantity;
                    }
                    else if (u_())
                    {
                        DataType am_ = DeliveryProcedure?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return an_ as CqlInterval<CqlDateTime>;
                    }
                    else if (v_())
                    {
                        DataType ao_ = DeliveryProcedure?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        return ap_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = this.hospitalizationWithEDOBTriageObservation(context, EncounterWithAge);
                bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
                bool? r_ = context.Operators.And(l_, q_);
                return r_;
            }

            IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
            bool? h_ = context.Operators.Exists<Procedure>(g_);
            return h_;
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

            object t_() {

                bool aa_() {
                    DataType ad_ = TimeOfDelivery?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlDateTime;
                    return af_;
                }


                bool ab_() {
                    DataType ag_ = TimeOfDelivery?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ac_() {
                    DataType aj_ = TimeOfDelivery?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlDateTime>;
                    return al_;
                }

                if (aa_())
                {
                    DataType am_ = TimeOfDelivery?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return an_ as CqlDateTime;
                }
                else if (ab_())
                {
                    DataType ao_ = TimeOfDelivery?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    return ap_ as CqlDateTime;
                }
                else if (ac_())
                {
                    DataType aq_ = TimeOfDelivery?.Effective;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    return ar_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
            CqlInterval<CqlDateTime> v_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, (string)default);
            bool? x_ = context.Operators.And(s_, w_);
            bool? y_ = context.Operators.In<CqlDateTime>(l_ as CqlDateTime, v_, (string)default);
            bool? z_ = context.Operators.And(x_, y_);
            return z_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {

            object as_() {

                bool au_() {
                    DataType ax_ = @this?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlDateTime;
                    return az_;
                }


                bool av_() {
                    DataType ba_ = @this?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlDateTime;
                    return bc_;
                }


                bool aw_() {
                    DataType bd_ = @this?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlDateTime>;
                    return bf_;
                }

                if (au_())
                {
                    DataType bg_ = @this?.Effective;
                    object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                    return bh_ as CqlDateTime;
                }
                else if (av_())
                {
                    DataType bi_ = @this?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    return bj_ as CqlDateTime;
                }
                else if (aw_())
                {
                    DataType bk_ = @this?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return bl_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime at_ = QICoreCommon_4_0_000.Instance.earliest(context, as_());
            return at_;
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

                bool ad_() {
                    DataType ag_ = EstimatedDateOfDelivery?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    return ai_;
                }


                bool ae_() {
                    DataType aj_ = EstimatedDateOfDelivery?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    return al_;
                }


                bool af_() {
                    DataType am_ = EstimatedDateOfDelivery?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlInterval<CqlDateTime>;
                    return ao_;
                }

                if (ad_())
                {
                    DataType ap_ = EstimatedDateOfDelivery?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlDateTime;
                }
                else if (ae_())
                {
                    DataType ar_ = EstimatedDateOfDelivery?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    return as_ as CqlDateTime;
                }
                else if (af_())
                {
                    DataType at_ = EstimatedDateOfDelivery?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    return au_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_());
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

                bool am_() {
                    DataType ap_ = EstimatedGestationalAge?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlDateTime;
                    return ar_;
                }


                bool an_() {
                    DataType as_ = EstimatedGestationalAge?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlDateTime;
                    return au_;
                }


                bool ao_() {
                    DataType av_ = EstimatedGestationalAge?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                    return ax_;
                }

                if (am_())
                {
                    DataType ay_ = EstimatedGestationalAge?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    return az_ as CqlDateTime;
                }
                else if (an_())
                {
                    DataType ba_ = EstimatedGestationalAge?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    return bb_ as CqlDateTime;
                }
                else if (ao_())
                {
                    DataType bc_ = EstimatedGestationalAge?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    return bd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_());
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

            object ac_() {

                bool be_() {
                    DataType bh_ = EstimatedGestationalAge?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    bool bj_ = bi_ is CqlDateTime;
                    return bj_;
                }


                bool bf_() {
                    DataType bk_ = EstimatedGestationalAge?.Effective;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlDateTime;
                    return bm_;
                }


                bool bg_() {
                    DataType bn_ = EstimatedGestationalAge?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    return bp_;
                }

                if (be_())
                {
                    DataType bq_ = EstimatedGestationalAge?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    return br_ as CqlDateTime;
                }
                else if (bf_())
                {
                    DataType bs_ = EstimatedGestationalAge?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    return bt_ as CqlDateTime;
                }
                else if (bg_())
                {
                    DataType bu_ = EstimatedGestationalAge?.Effective;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    return bv_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_());
            bool? ae_ = context.Operators.SameAs(ad_, l_, "day");

            object af_() {

                bool bw_() {
                    DataType bz_ = EstimatedGestationalAge?.Effective;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlDateTime;
                    return cb_;
                }


                bool bx_() {
                    DataType cc_ = EstimatedGestationalAge?.Effective;
                    object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    bool ce_ = cd_ is CqlDateTime;
                    return ce_;
                }


                bool by_() {
                    DataType cf_ = EstimatedGestationalAge?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                    return ch_;
                }

                if (bw_())
                {
                    DataType ci_ = EstimatedGestationalAge?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    return cj_ as CqlDateTime;
                }
                else if (bx_())
                {
                    DataType ck_ = EstimatedGestationalAge?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    return cl_ as CqlDateTime;
                }
                else if (by_())
                {
                    DataType cm_ = EstimatedGestationalAge?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    return cn_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_());
            CqlInterval<CqlDateTime> ah_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
            bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, (string)default);
            bool? aj_ = context.Operators.And(ae_, ai_);
            bool? ak_ = context.Operators.And(aj_, u_);
            bool? al_ = context.Operators.Or(ab_, ak_);
            return al_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {

            object co_() {

                bool cq_() {
                    DataType ct_ = @this?.Effective;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlDateTime;
                    return cv_;
                }


                bool cr_() {
                    DataType cw_ = @this?.Effective;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    bool cy_ = cx_ is CqlDateTime;
                    return cy_;
                }


                bool cs_() {
                    DataType cz_ = @this?.Effective;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlInterval<CqlDateTime>;
                    return db_;
                }

                if (cq_())
                {
                    DataType dc_ = @this?.Effective;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    return dd_ as CqlDateTime;
                }
                else if (cr_())
                {
                    DataType de_ = @this?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    return df_ as CqlDateTime;
                }
                else if (cs_())
                {
                    DataType dg_ = @this?.Effective;
                    object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                    return dh_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime cp_ = QICoreCommon_4_0_000.Instance.earliest(context, co_());
            return cp_;
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
