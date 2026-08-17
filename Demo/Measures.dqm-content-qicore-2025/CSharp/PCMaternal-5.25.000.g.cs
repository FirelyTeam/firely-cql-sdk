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
                        bq_ = bp_ & (!((bool?)(bl_ is null)));
                    }
                    // CQL 'and' (53:9-54:41): right operand skipped when left is false
                    if (bq_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<Encounter.EncounterStatus> br_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? bs_ = br_?.Value;
                        Code<Encounter.EncounterStatus> bt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bs_);
                        bool? bu_ = context.Operators.Equal(bt_, "finished");
                        return bq_ & bu_;
                    }
                }

                IEnumerable<Encounter> aj_ = context.Operators.Where<Encounter>(ah_, ai_);

                object ak_(Encounter @this) {
                    Period bv_ = @this?.Period;
                    CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                    CqlDateTime bx_ = context.Operators.End(bw_);
                    return bx_;
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
                    Period by_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                    CqlDateTime ca_ = context.Operators.End(bz_);
                    Period cb_ = Visit?.Period;
                    CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.Start(cc_);
                    CqlQuantity ce_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime cf_ = context.Operators.Subtract(cd_, ce_);
                    CqlInterval<CqlDateTime> cg_ = context.Operators.Interval(cf_, cd_, true, true);
                    bool? ch_ = context.Operators.In<CqlDateTime>(ca_, cg_, (string)default);
                    bool? ci_;
                    // CQL 'and' (53:15-53:83): right operand skipped when left is false
                    if (ch_ is false)
                    {
                        ci_ = false;
                    }
                    else
                    {
                        ci_ = ch_ & (!((bool?)(cd_ is null)));
                    }
                    // CQL 'and' (53:9-54:41): right operand skipped when left is false
                    if (ci_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<Encounter.EncounterStatus> cj_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ck_ = cj_?.Value;
                        Code<Encounter.EncounterStatus> cl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ck_);
                        bool? cm_ = context.Operators.Equal(cl_, "finished");
                        return ci_ & cm_;
                    }
                }

                IEnumerable<Encounter> aw_ = context.Operators.Where<Encounter>(ah_, av_);

                object ax_(Encounter @this) {
                    Period cn_ = @this?.Period;
                    CqlInterval<CqlDateTime> co_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cn_);
                    CqlDateTime cp_ = context.Operators.End(co_);
                    return cp_;
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

                    bool? cq_(Encounter LastObs) {
                        Period cy_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cy_);
                        CqlDateTime da_ = context.Operators.End(cz_);
                        Period db_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, db_);
                        CqlDateTime dd_ = context.Operators.Start(dc_);
                        CqlQuantity de_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime df_ = context.Operators.Subtract(dd_, de_);
                        CqlInterval<CqlDateTime> dg_ = context.Operators.Interval(df_, dd_, true, true);
                        bool? dh_ = context.Operators.In<CqlDateTime>(da_, dg_, (string)default);
                        bool? di_;
                        // CQL 'and' (53:15-53:83): right operand skipped when left is false
                        if (dh_ is false)
                        {
                            di_ = false;
                        }
                        else
                        {
                            di_ = dh_ & (!((bool?)(dd_ is null)));
                        }
                        // CQL 'and' (53:9-54:41): right operand skipped when left is false
                        if (di_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Code<Encounter.EncounterStatus> dj_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? dk_ = dj_?.Value;
                            Code<Encounter.EncounterStatus> dl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dk_);
                            bool? dm_ = context.Operators.Equal(dl_, "finished");
                            return di_ & dm_;
                        }
                    }

                    IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(ah_, cq_);

                    object cs_(Encounter @this) {
                        Period dn_ = @this?.Period;
                        CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                        CqlDateTime dp_ = context.Operators.End(do_);
                        return dp_;
                    }

                    IEnumerable<Encounter> ct_ = context.Operators.SortBy<Encounter>(cr_, cs_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter cu_ = context.Operators.Last<Encounter>(ct_);
                    Period cv_ = cu_?.Period;
                    CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    bf_ = be_ & (!((bool?)((cx_ ?? as_) is null)));
                }
                // CQL 'and' (60:9-61:48): right operand skipped when left is false
                if (bf_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> dq_ = LastEDOBTriage?.StatusElement;
                    Encounter.EncounterStatus? dr_ = dq_?.Value;
                    Code<Encounter.EncounterStatus> ds_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dr_);
                    bool? dt_ = context.Operators.Equal(ds_, "finished");
                    return bf_ & dt_;
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period du_ = @this?.Period;
                CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                CqlDateTime dw_ = context.Operators.End(dv_);
                return dw_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Period dx_ = LastObs?.Period;
                CqlInterval<CqlDateTime> dy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dx_);
                CqlDateTime dz_ = context.Operators.End(dy_);
                Period ea_ = Visit?.Period;
                CqlInterval<CqlDateTime> eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                CqlDateTime ec_ = context.Operators.Start(eb_);
                CqlQuantity ed_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ee_ = context.Operators.Subtract(ec_, ed_);
                CqlInterval<CqlDateTime> ef_ = context.Operators.Interval(ee_, ec_, true, true);
                bool? eg_ = context.Operators.In<CqlDateTime>(dz_, ef_, (string)default);
                bool? eh_;
                // CQL 'and' (53:15-53:83): right operand skipped when left is false
                if (eg_ is false)
                {
                    eh_ = false;
                }
                else
                {
                    eh_ = eg_ & (!((bool?)(ec_ is null)));
                }
                // CQL 'and' (53:9-54:41): right operand skipped when left is false
                if (eh_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> ei_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ej_ = ei_?.Value;
                    Code<Encounter.EncounterStatus> ek_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ej_);
                    bool? el_ = context.Operators.Equal(ek_, "finished");
                    return eh_ & el_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period em_ = @this?.Period;
                CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime eo_ = context.Operators.End(en_);
                return eo_;
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
                        l_ = r_ as CqlDateTime;
                    }
                    else
                    {
                        bool t_ = r_ is CqlQuantity;
                        if (t_)
                        {
                            l_ = r_ as CqlQuantity;
                        }
                        else
                        {
                            bool u_ = r_ is CqlInterval<CqlDateTime>;
                            if (u_)
                            {
                                l_ = r_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool v_ = r_ is CqlInterval<CqlQuantity>;
                                if (v_)
                                {
                                    l_ = r_ as CqlInterval<CqlQuantity>;
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
                CqlInterval<CqlDateTime> ac_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                bool? ad_ = context.Operators.In<CqlDateTime>(l_ as CqlDateTime, ac_, (string)default);
                return o_ & ad_;
            }
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
                    t_ = ac_ as CqlDateTime;
                }
                else
                {
                    if (ad_)
                    {
                        t_ = ac_ as CqlDateTime;
                    }
                    else
                    {
                        bool ae_ = ac_ is CqlInterval<CqlDateTime>;
                        if (ae_)
                        {
                            t_ = ac_ as CqlInterval<CqlDateTime>;
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
                    aa_ = z_ & (!((bool?)(v_ is null)));
                }
                return n_ & aa_;
            }
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            object af_;
            DataType ah_ = @this?.Effective;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            bool aj_ = ai_ is CqlDateTime;
            if (aj_)
            {
                af_ = ai_ as CqlDateTime;
            }
            else
            {
                if (aj_)
                {
                    af_ = ai_ as CqlDateTime;
                }
                else
                {
                    bool ak_ = ai_ is CqlInterval<CqlDateTime>;
                    if (ak_)
                    {
                        af_ = ai_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        af_ = null;
                    }
                }
            }
            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
            return ag_;
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
            bool? p_ = context.Operators.In<CqlDateTime>(k_, o_, (string)default);
            bool? q_;
            // CQL 'and' (82:4-82:77): right operand skipped when left is false
            if (p_ is false)
            {
                q_ = false;
            }
            else
            {
                q_ = p_ & (!((bool?)(l_ is null)));
            }
            bool? r_;
            // CQL 'and' (82:4-83:47): right operand skipped when left is false
            if (q_ is false)
            {
                r_ = false;
            }
            else
            {
                DataType x_ = EstimatedGestationalAge?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                r_ = q_ & (!((bool?)(y_ is null)));
            }
            bool? s_;
            // CQL 'and' (82:3-84:76): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                Code<ObservationStatus> z_ = EstimatedGestationalAge?.StatusElement;
                ObservationStatus? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                string[] ac_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
                s_ = r_ & ad_;
            }
            // CQL 'or' (81:64-87:52): right operand skipped when left is true
            if (s_ is true)
            {
                return true;
            }
            else
            {
                object ae_;
                DataType aj_ = EstimatedGestationalAge?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool al_ = ak_ is CqlDateTime;
                if (al_)
                {
                    ae_ = ak_ as CqlDateTime;
                }
                else
                {
                    if (al_)
                    {
                        ae_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        bool am_ = ak_ is CqlInterval<CqlDateTime>;
                        if (am_)
                        {
                            ae_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
                CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
                bool? ag_ = context.Operators.SameAs(af_, l_, "day");
                bool? ah_;
                // CQL 'and' (85:8-86:82): right operand skipped when left is false
                if (ag_ is false)
                {
                    ah_ = false;
                }
                else
                {
                    object an_;
                    DataType ar_ = EstimatedGestationalAge?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    if (at_)
                    {
                        an_ = as_ as CqlDateTime;
                    }
                    else
                    {
                        if (at_)
                        {
                            an_ = as_ as CqlDateTime;
                        }
                        else
                        {
                            bool au_ = as_ is CqlInterval<CqlDateTime>;
                            if (au_)
                            {
                                an_ = as_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                an_ = null;
                            }
                        }
                    }
                    CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                    CqlInterval<CqlDateTime> ap_ = this.hospitalizationWithEDOBTriageObservation(context, TheEncounter);
                    bool? aq_ = context.Operators.In<CqlDateTime>(ao_, ap_, (string)default);
                    ah_ = ag_ & aq_;
                }
                bool? ai_;
                // CQL 'and' (85:7-87:52): right operand skipped when left is false
                if (ah_ is false)
                {
                    ai_ = false;
                }
                else
                {
                    DataType av_ = EstimatedGestationalAge?.Value;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    ai_ = ah_ & (!((bool?)(aw_ is null)));
                }
                return s_ | ai_;
            }
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            object ax_;
            DataType az_ = @this?.Effective;
            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            bool bb_ = ba_ is CqlDateTime;
            if (bb_)
            {
                ax_ = ba_ as CqlDateTime;
            }
            else
            {
                if (bb_)
                {
                    ax_ = ba_ as CqlDateTime;
                }
                else
                {
                    bool bc_ = ba_ is CqlInterval<CqlDateTime>;
                    if (bc_)
                    {
                        ax_ = ba_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        ax_ = null;
                    }
                }
            }
            CqlDateTime ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_);
            return ay_;
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
