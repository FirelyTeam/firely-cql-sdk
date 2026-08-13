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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
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
                    Period bg_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                    CqlDateTime bi_ = context.Operators.End(bh_);
                    Period bj_ = Visit?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    CqlQuantity bm_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                    CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bn_, bl_, true, true);
                    bool? bp_ = context.Operators.In<CqlDateTime>(bi_, bo_, (string)default);
                    bool? bq_;
                    // CQL 'and' (53:15-53:83): right operand skipped when left is false
                    if (bp_ is false)
                    {
                        bq_ = false;
                    }
                    else
                    {
                        Period br_ = Visit?.Period;
                        CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, br_);
                        CqlDateTime bt_ = context.Operators.Start(bs_);
                        bq_ = bp_ & (!((bool?)(bt_ is null)));
                    }
                    // CQL 'and' (53:9-54:41): right operand skipped when left is false
                    if (bq_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<Encounter.EncounterStatus> bu_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bv_ = bu_?.Value;
                        Code<Encounter.EncounterStatus> bw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bv_);
                        bool? bx_ = context.Operators.Equal(bw_, "finished");
                        return bq_ & bx_;
                    }
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period by_ = @this?.Period;
                    CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                    CqlDateTime ca_ = context.Operators.End(bz_);
                    return ca_;
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
                    Period cb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.End(cc_);
                    Period ce_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ce_);
                    CqlDateTime cg_ = context.Operators.Start(cf_);
                    CqlQuantity ch_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ci_ = context.Operators.Subtract(cg_, ch_);
                    CqlInterval<CqlDateTime> cj_ = context.Operators.Interval(ci_, cg_, true, true);
                    bool? ck_ = context.Operators.In<CqlDateTime>(cd_, cj_, (string)default);
                    bool? cl_;
                    // CQL 'and' (53:15-53:83): right operand skipped when left is false
                    if (ck_ is false)
                    {
                        cl_ = false;
                    }
                    else
                    {
                        Period cm_ = Visit?.Period;
                        CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                        CqlDateTime co_ = context.Operators.Start(cn_);
                        cl_ = ck_ & (!((bool?)(co_ is null)));
                    }
                    // CQL 'and' (53:9-54:41): right operand skipped when left is false
                    if (cl_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<Encounter.EncounterStatus> cp_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? cq_ = cp_?.Value;
                        Code<Encounter.EncounterStatus> cr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cq_);
                        bool? cs_ = context.Operators.Equal(cr_, "finished");
                        return cl_ & cs_;
                    }
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period ct_ = @this?.Period;
                    CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                    CqlDateTime cv_ = context.Operators.End(cu_);
                    return cv_;
                }

                IEnumerable<Encounter> ay_ = context.Operators.SortBy<Encounter>(aw_, ax_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter az_ = context.Operators.Last<Encounter>(ay_);
                Period ba_ = az_?.Period;
                CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(au_, bc_ ?? as_, true, true);
                bool? be_ = context.Operators.In<CqlDateTime>(af_, bd_, (string)default);
                bool? bf_;
                // CQL 'and' (60:15-60:79): right operand skipped when left is false
                if (be_ is false)
                {
                    bf_ = false;
                }
                else
                {
                    CqlValueSet cw_ = this.Observation_Services(context);
                    IEnumerable<Encounter> cx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, cw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? cy_(Encounter LastObs) {
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
                        bool? dt_;
                        // CQL 'and' (53:15-53:83): right operand skipped when left is false
                        if (ds_ is false)
                        {
                            dt_ = false;
                        }
                        else
                        {
                            Period du_ = Visit?.Period;
                            CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                            CqlDateTime dw_ = context.Operators.Start(dv_);
                            dt_ = ds_ & (!((bool?)(dw_ is null)));
                        }
                        // CQL 'and' (53:9-54:41): right operand skipped when left is false
                        if (dt_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<Encounter.EncounterStatus> dx_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dy_ = dx_?.Value;
                            Code<Encounter.EncounterStatus> dz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dy_);
                            bool? ea_ = context.Operators.Equal(dz_, "finished");
                            return dt_ & ea_;
                        }
                    }

                    IEnumerable<Encounter> cz_ = context.Operators.Where<Encounter>(cx_, cy_);

                    object da_(Encounter @this) {
                        Period eb_ = @this?.Period;
                        CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eb_);
                        CqlDateTime ed_ = context.Operators.End(ec_);
                        return ed_;
                    }

                    IEnumerable<Encounter> db_ = context.Operators.SortBy<Encounter>(cz_, da_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter dc_ = context.Operators.Last<Encounter>(db_);
                    Period dd_ = dc_?.Period;
                    CqlInterval<CqlDateTime> de_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dd_);
                    CqlDateTime df_ = context.Operators.Start(de_);
                    Period dg_ = Visit?.Period;
                    CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                    CqlDateTime di_ = context.Operators.Start(dh_);
                    bf_ = be_ & (!((bool?)((df_ ?? di_) is null)));
                }
                // CQL 'and' (60:9-61:48): right operand skipped when left is false
                if (bf_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> ee_ = LastEDOBTriage?.StatusElement;
                    Encounter.EncounterStatus? ef_ = ee_?.Value;
                    Code<Encounter.EncounterStatus> eg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ef_);
                    bool? eh_ = context.Operators.Equal(eg_, "finished");
                    return bf_ & eh_;
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period ei_ = @this?.Period;
                CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.End(ej_);
                return ek_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Period el_ = LastObs?.Period;
                CqlInterval<CqlDateTime> em_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, el_);
                CqlDateTime en_ = context.Operators.End(em_);
                Period eo_ = Visit?.Period;
                CqlInterval<CqlDateTime> ep_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eo_);
                CqlDateTime eq_ = context.Operators.Start(ep_);
                CqlQuantity er_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime es_ = context.Operators.Subtract(eq_, er_);
                CqlInterval<CqlDateTime> et_ = context.Operators.Interval(es_, eq_, true, true);
                bool? eu_ = context.Operators.In<CqlDateTime>(en_, et_, (string)default);
                bool? ev_;
                // CQL 'and' (53:15-53:83): right operand skipped when left is false
                if (eu_ is false)
                {
                    ev_ = false;
                }
                else
                {
                    Period ew_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ew_);
                    CqlDateTime ey_ = context.Operators.Start(ex_);
                    ev_ = eu_ & (!((bool?)(ey_ is null)));
                }
                // CQL 'and' (53:9-54:41): right operand skipped when left is false
                if (ev_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> ez_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? fa_ = ez_?.Value;
                    Code<Encounter.EncounterStatus> fb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fa_);
                    bool? fc_ = context.Operators.Equal(fb_, "finished");
                    return ev_ & fc_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period fd_ = @this?.Period;
                CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fd_);
                CqlDateTime ff_ = context.Operators.End(fe_);
                return ff_;
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
                // CQL 'and' (27:27-28:138): right operand skipped when left is false
                if (k_ is false)
                {
                    return false;
                }
                else
                {
                    object l_;
                    DataType q_ = DeliveryProcedure?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;
                    if (s_)
                    {
                        DataType t_ = DeliveryProcedure?.Performed;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        l_ = u_ as CqlDateTime;
                    }
                    else
                    {
                        DataType v_ = DeliveryProcedure?.Performed;
                        object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        bool x_ = w_ is CqlQuantity;
                        if (x_)
                        {
                            DataType y_ = DeliveryProcedure?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            l_ = z_ as CqlQuantity;
                        }
                        else
                        {
                            DataType aa_ = DeliveryProcedure?.Performed;
                            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                            if (ac_)
                            {
                                DataType ad_ = DeliveryProcedure?.Performed;
                                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                                l_ = ae_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType af_ = DeliveryProcedure?.Performed;
                                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                bool ah_ = ag_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    DataType ai_ = DeliveryProcedure?.Performed;
                                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                                    l_ = aj_ as CqlInterval<CqlQuantity>;
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
                    return k_ & p_;
                }
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
            bool? m_ = !((bool?)((l_ as CqlDateTime) is null));
            bool? n_;
            // CQL 'and' (93:13-94:72): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                Code<ObservationStatus> p_ = TimeOfDelivery?.StatusElement;
                ObservationStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                string[] s_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                n_ = m_ & t_;
            }
            bool? o_;
            // CQL 'and' (93:13-95:112): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                object u_;
                DataType y_ = TimeOfDelivery?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = TimeOfDelivery?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    u_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = TimeOfDelivery?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlDateTime;
                    if (af_)
                    {
                        DataType ag_ = TimeOfDelivery?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        u_ = ah_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ai_ = TimeOfDelivery?.Effective;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;
                        if (ak_)
                        {
                            DataType al_ = TimeOfDelivery?.Effective;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            u_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
                CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
                CqlInterval<CqlDateTime> w_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, (string)default);
                o_ = n_ & x_;
            }
            // CQL 'and' (93:7-96:107): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                DataType an_ = TimeOfDelivery?.Value;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlInterval<CqlDateTime> ap_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                bool? aq_ = context.Operators.In<CqlDateTime>(ao_ as CqlDateTime, ap_, (string)default);
                return o_ & aq_;
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ar_;
            DataType at_ = @this?.Effective;
            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
            bool av_ = au_ is CqlDateTime;
            if (av_)
            {
                DataType aw_ = @this?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                ar_ = ax_ as CqlDateTime;
            }
            else
            {
                DataType ay_ = @this?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    DataType bb_ = @this?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    ar_ = bc_ as CqlDateTime;
                }
                else
                {
                    DataType bd_ = @this?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        DataType bg_ = @this?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        ar_ = bh_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ar_ = null;
                    }
                }
            }
            CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
            return as_;
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
            bool? m_ = !((bool?)((l_ as CqlDateTime) is null));
            bool? n_;
            // CQL 'and' (72:13-73:81): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                Code<ObservationStatus> o_ = EstimatedDateOfDelivery?.StatusElement;
                ObservationStatus? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                string[] r_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                n_ = m_ & s_;
            }
            // CQL 'and' (72:7-74:123): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                object t_;
                DataType ab_ = EstimatedDateOfDelivery?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    DataType ae_ = EstimatedDateOfDelivery?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    t_ = af_ as CqlDateTime;
                }
                else
                {
                    DataType ag_ = EstimatedDateOfDelivery?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    if (ai_)
                    {
                        DataType aj_ = EstimatedDateOfDelivery?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        t_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        DataType al_ = EstimatedDateOfDelivery?.Effective;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlInterval<CqlDateTime>;
                        if (an_)
                        {
                            DataType ao_ = EstimatedDateOfDelivery?.Effective;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            t_ = ap_ as CqlInterval<CqlDateTime>;
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
                bool? aa_;
                // CQL 'and' (74:13-74:123): right operand skipped when left is false
                if (z_ is false)
                {
                    aa_ = false;
                }
                else
                {
                    CqlDateTime aq_ = this.lastTimeOfDelivery(context, TheEncounter);
                    aa_ = z_ & (!((bool?)(aq_ is null)));
                }
                return n_ & aa_;
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object ar_;
            DataType at_ = @this?.Effective;
            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
            bool av_ = au_ is CqlDateTime;
            if (av_)
            {
                DataType aw_ = @this?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                ar_ = ax_ as CqlDateTime;
            }
            else
            {
                DataType ay_ = @this?.Effective;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    DataType bb_ = @this?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    ar_ = bc_ as CqlDateTime;
                }
                else
                {
                    DataType bd_ = @this?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        DataType bg_ = @this?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        ar_ = bh_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ar_ = null;
                    }
                }
            }
            CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
            return as_;
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
                DataType w_ = EstimatedGestationalAge?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                j_ = x_ as CqlDateTime;
            }
            else
            {
                DataType y_ = EstimatedGestationalAge?.Effective;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    DataType ab_ = EstimatedGestationalAge?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    j_ = ac_ as CqlDateTime;
                }
                else
                {
                    DataType ad_ = EstimatedGestationalAge?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType ag_ = EstimatedGestationalAge?.Effective;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        j_ = ah_ as CqlInterval<CqlDateTime>;
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
            bool? q_;
            // CQL 'and' (82:4-82:77): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                CqlDateTime ai_ = this.lastTimeOfDelivery(context, TheEncounter);
                q_ = p_ & (!((bool?)(ai_ is null)));
            }
            bool? r_;
            // CQL 'and' (82:4-83:47): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType aj_ = EstimatedGestationalAge?.Value;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                r_ = q_ & (!((bool?)(ak_ is null)));
            }
            bool? s_;
            // CQL 'and' (82:3-84:76): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                Code<ObservationStatus> al_ = EstimatedGestationalAge?.StatusElement;
                ObservationStatus? am_ = al_?.Value;
                string an_ = context.Operators.Convert<string>(am_);
                string[] ao_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
                s_ = r_ & ap_;
            }
            // CQL 'or' (81:64-87:52): right operand skipped when left is true
            if (s_ is true)
            {
                return true;
            }
            else
            {
                object aq_;
                DataType aw_ = EstimatedGestationalAge?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType az_ = EstimatedGestationalAge?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    aq_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType bb_ = EstimatedGestationalAge?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlDateTime;
                    if (bd_)
                    {
                        DataType be_ = EstimatedGestationalAge?.Effective;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        aq_ = bf_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bg_ = EstimatedGestationalAge?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            DataType bj_ = EstimatedGestationalAge?.Effective;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            aq_ = bk_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
                CqlDateTime ar_ = QICoreCommon_4_0_000.Instance.earliest(context, aq_);
                CqlDateTime as_ = this.lastTimeOfDelivery(context, TheEncounter);
                bool? at_ = context.Operators.SameAs(ar_, as_, "day");
                bool? au_;
                // CQL 'and' (85:8-86:82): right operand skipped when left is false
                if (at_ is false)
                {
                    au_ = false;
                }
                else
                {
                    object bl_;
                    DataType bp_ = EstimatedGestationalAge?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlDateTime;
                    if (br_)
                    {
                        DataType bs_ = EstimatedGestationalAge?.Effective;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bl_ = bt_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bu_ = EstimatedGestationalAge?.Effective;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlDateTime;
                        if (bw_)
                        {
                            DataType bx_ = EstimatedGestationalAge?.Effective;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            bl_ = by_ as CqlDateTime;
                        }
                        else
                        {
                            DataType bz_ = EstimatedGestationalAge?.Effective;
                            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                            bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                            if (cb_)
                            {
                                DataType cc_ = EstimatedGestationalAge?.Effective;
                                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                                bl_ = cd_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bl_ = null;
                            }
                        }
                    }
                    CqlDateTime bm_ = QICoreCommon_4_0_000.Instance.earliest(context, bl_);
                    CqlInterval<CqlDateTime> bn_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                    bool? bo_ = context.Operators.In<CqlDateTime>(bm_, bn_, (string)default);
                    au_ = at_ & bo_;
                }
                bool? av_;
                // CQL 'and' (85:7-87:52): right operand skipped when left is false
                if (au_ is false)
                {
                    av_ = false;
                }
                else
                {
                    DataType ce_ = EstimatedGestationalAge?.Value;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    av_ = au_ & (!((bool?)(cf_ is null)));
                }
                return s_ | av_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object cg_;
            DataType ci_ = @this?.Effective;
            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
            bool ck_ = cj_ is CqlDateTime;
            if (ck_)
            {
                DataType cl_ = @this?.Effective;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                cg_ = cm_ as CqlDateTime;
            }
            else
            {
                DataType cn_ = @this?.Effective;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                bool cp_ = co_ is CqlDateTime;
                if (cp_)
                {
                    DataType cq_ = @this?.Effective;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    cg_ = cr_ as CqlDateTime;
                }
                else
                {
                    DataType cs_ = @this?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                    if (cu_)
                    {
                        DataType cv_ = @this?.Effective;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        cg_ = cw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        cg_ = null;
                    }
                }
            }
            CqlDateTime ch_ = QICoreCommon_4_0_000.Instance.earliest(context, cg_);
            return ch_;
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
