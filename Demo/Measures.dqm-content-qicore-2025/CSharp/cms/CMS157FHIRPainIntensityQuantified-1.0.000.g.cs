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
[CqlLibrary("CMS157FHIRPainIntensityQuantified", "1.0.000")]
public partial class CMS157FHIRPainIntensityQuantified_1_0_000 : ILibrary, ISingleton<CMS157FHIRPainIntensityQuantified_1_0_000>
{
    #region ValueSets (6)

    [CqlValueSetDefinition("Audio Visual Telehealth Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.1444.5.215", valueSetVersion: null)]
    public CqlValueSet Audio_Visual_Telehealth_Encounter(CqlContext _) => _Audio_Visual_Telehealth_Encounter;
    private static readonly CqlValueSet _Audio_Visual_Telehealth_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.1444.5.215", null);

    [CqlValueSetDefinition("Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", valueSetVersion: null)]
    public CqlValueSet Cancer(CqlContext _) => _Cancer;
    private static readonly CqlValueSet _Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1010", null);

    [CqlValueSetDefinition("Chemotherapy Administration", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", valueSetVersion: null)]
    public CqlValueSet Chemotherapy_Administration(CqlContext _) => _Chemotherapy_Administration;
    private static readonly CqlValueSet _Chemotherapy_Administration = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1027", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Radiation Treatment Management", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", valueSetVersion: null)]
    public CqlValueSet Radiation_Treatment_Management(CqlContext _) => _Radiation_Treatment_Management;
    private static readonly CqlValueSet _Radiation_Treatment_Management = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1026", null);

    [CqlValueSetDefinition("Standardized Pain Assessment Tool", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", valueSetVersion: null)]
    public CqlValueSet Standardized_Pain_Assessment_Tool(CqlContext _) => _Standardized_Pain_Assessment_Tool;
    private static readonly CqlValueSet _Standardized_Pain_Assessment_Tool = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1028", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Radiation treatment management, 5 treatments", codeId: "77427", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Radiation_treatment_management__5_treatments(CqlContext _) => _Radiation_treatment_management__5_treatments;
    private static readonly CqlCode _Radiation_treatment_management__5_treatments = new CqlCode("77427", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Radiation_treatment_management__5_treatments]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5445798036144351774L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS157FHIRPainIntensityQuantified-1.0.000"!, ("Measurement Period")!, c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (15)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 669900998892653617L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure?>? Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period, Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Compute);

    private const long _cacheIndex_Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period = -6279289550066187025L;

    private IEnumerable<Procedure?>? Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure? ChemoAdministration) {
            CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
            CqlDateTime? f_ = context.Operators.Start(e_);
            CqlQuantity? g_ = context.Operators.Quantity(31m, "days");
            CqlDateTime? h_ = context.Operators.Subtract(f_, g_);
            CqlDateTime? i_ = context.Operators.End(e_);
            CqlInterval<CqlDateTime?>? j_ = context.Operators.Interval(h_, i_, true, true);
            object? k_;
            DataType? t_ = ChemoAdministration?.Performed;
            object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                DataType? w_ = ChemoAdministration?.Performed;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                k_ = x_ as CqlDateTime;
            }
            else
            {
                DataType? y_ = ChemoAdministration?.Performed;
                object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlQuantity;
                if (aa_)
                {
                    DataType? ab_ = ChemoAdministration?.Performed;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    k_ = ac_ as CqlQuantity;
                }
                else
                {
                    DataType? ad_ = ChemoAdministration?.Performed;
                    object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType? ag_ = ChemoAdministration?.Performed;
                        object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        k_ = ah_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ai_ = ChemoAdministration?.Performed;
                        object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                        if (ak_)
                        {
                            DataType? al_ = ChemoAdministration?.Performed;
                            object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            k_ = am_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            k_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(j_, l_, (string?)default);
            Code<EventStatus>? n_ = ChemoAdministration?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string? p_ = context.Operators.Convert<string?>(o_);
            string?[]? q_ = [
                "completed",
                "in-progress",
            ];
            bool? r_ = context.Operators.In<string?>(p_, (IEnumerable<string?>?)q_);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
        }

        IEnumerable<Procedure?>? d_ = context.Operators.Where<Procedure?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter?>? Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy, Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Compute);

    private const long _cacheIndex_Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy = 2050822187251213769L;

    private IEnumerable<Encounter?>? Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? c_ = this.Audio_Visual_Telehealth_Encounter(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter?>(b_, d_);
        IEnumerable<Procedure?>? f_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet? g_ = this.Cancer(context);
        IEnumerable<Condition?>? h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? j_ = context.Operators.Union<Condition?>(h_ as IEnumerable<Condition?>, i_ as IEnumerable<Condition?>);
        IEnumerable<ValueTuple<Encounter?, Procedure?, Procedure?, Condition?>>? k_ = context.Operators.CrossJoin<Encounter?, Procedure?, Procedure?, Condition?>(e_, f_, f_, j_);

        (CqlTupleMetadata, Encounter? FaceToFaceOrTelehealthEncounter, Procedure? ChemoBeforeEncounter, Procedure? ChemoAfterEncounter, Condition? CancerDx)? l_(ValueTuple<Encounter?, Procedure?, Procedure?, Condition?> _valueTuple) {
            (CqlTupleMetadata, Encounter? FaceToFaceOrTelehealthEncounter, Procedure? ChemoBeforeEncounter, Procedure? ChemoAfterEncounter, Condition? CancerDx)? q_ = (CqlTupleMetadata_BbTIICcXRIYUQAVPLggHEjGOe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
            return q_;
        }


        bool? m_((CqlTupleMetadata, Encounter? FaceToFaceOrTelehealthEncounter, Procedure? ChemoBeforeEncounter, Procedure? ChemoAfterEncounter, Condition? CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc) {
            CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_eweddbdxxszcpujsdbltgdxcc?.CancerDx);
            Period? s_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime?>? t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            bool? u_ = context.Operators.Overlaps(r_!, t_!, "day");
            object? v_;
            DataType? bd_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
            object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                DataType? bg_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                v_ = bh_ as CqlDateTime;
            }
            else
            {
                DataType? bi_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    DataType? bl_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object? bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    v_ = bm_ as CqlQuantity;
                }
                else
                {
                    DataType? bn_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    bool bp_ = bo_ is CqlInterval<CqlDateTime>;
                    if (bp_)
                    {
                        DataType? bq_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object? br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        v_ = br_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? bs_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        if (bu_)
                        {
                            DataType? bv_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                            object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                            v_ = bw_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            CqlDateTime? y_ = context.Operators.End(t_);
            CqlQuantity? z_ = context.Operators.Quantity(30m, "days");
            CqlDateTime? aa_ = context.Operators.Subtract(y_, z_);
            CqlInterval<CqlDateTime?>? ab_ = context.Operators.Interval(aa_, y_, true, true);
            bool? ac_ = context.Operators.In<CqlDateTime?>(x_, ab_, "day");
            bool? ad_ = context.Operators.Not((bool?)(y_ is null));
            bool? ae_ = context.Operators.And(ac_, ad_);
            bool? af_ = context.Operators.And(u_, ae_);
            object? ag_;
            DataType? bx_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
            object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool bz_ = by_ is CqlDateTime;
            if (bz_)
            {
                DataType? ca_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                ag_ = cb_ as CqlDateTime;
            }
            else
            {
                DataType? cc_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool ce_ = cd_ is CqlQuantity;
                if (ce_)
                {
                    DataType? cf_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    ag_ = cg_ as CqlQuantity;
                }
                else
                {
                    DataType? ch_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object? ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    if (cj_)
                    {
                        DataType? ck_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object? cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        ag_ = cl_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? cm_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlInterval<CqlQuantity>;
                        if (co_)
                        {
                            DataType? cp_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                            object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            ag_ = cq_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ag_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime? ai_ = context.Operators.Start(ah_);
            CqlDateTime? aj_ = context.Operators.Add(y_, z_);
            CqlInterval<CqlDateTime?>? ak_ = context.Operators.Interval(y_, aj_, true, true);
            bool? al_ = context.Operators.In<CqlDateTime?>(ai_, ak_, "day");
            bool? am_ = context.Operators.And(al_, ad_);
            bool? an_ = context.Operators.And(af_, am_);
            object? ao_;
            DataType? cr_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
            object? cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
            bool ct_ = cs_ is CqlDateTime;
            if (ct_)
            {
                DataType? cu_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object? cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                ao_ = cv_ as CqlDateTime;
            }
            else
            {
                DataType? cw_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object? cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                bool cy_ = cx_ is CqlQuantity;
                if (cy_)
                {
                    DataType? cz_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object? da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    ao_ = da_ as CqlQuantity;
                }
                else
                {
                    DataType? db_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object? dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlInterval<CqlDateTime>;
                    if (dd_)
                    {
                        DataType? de_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object? df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        ao_ = df_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? dg_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        bool di_ = dh_ is CqlInterval<CqlQuantity>;
                        if (di_)
                        {
                            DataType? dj_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                            object? dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            ao_ = dk_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            ao_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            object? aq_;
            DataType? dl_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
            object? dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
            bool dn_ = dm_ is CqlDateTime;
            if (dn_)
            {
                DataType? do_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object? dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                aq_ = dp_ as CqlDateTime;
            }
            else
            {
                DataType? dq_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object? dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                bool ds_ = dr_ is CqlQuantity;
                if (ds_)
                {
                    DataType? dt_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object? du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    aq_ = du_ as CqlQuantity;
                }
                else
                {
                    DataType? dv_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object? dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    bool dx_ = dw_ is CqlInterval<CqlDateTime>;
                    if (dx_)
                    {
                        DataType? dy_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object? dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        aq_ = dz_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        DataType? ea_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object? eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                        bool ec_ = eb_ is CqlInterval<CqlQuantity>;
                        if (ec_)
                        {
                            DataType? ed_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                            object? ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            aq_ = ee_ as CqlInterval<CqlQuantity?>;
                        }
                        else
                        {
                            aq_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            bool? as_ = context.Operators.SameAs<CqlDateTime?>(ap_!, ar_!, "day");
            bool? at_ = context.Operators.Not(as_);
            bool? au_ = context.Operators.And(an_, at_);
            CqlInterval<CqlDateTime?>? av_ = this.Measurement_Period(context);
            bool? aw_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(av_, t_, "day");
            bool? ax_ = context.Operators.And(au_, aw_);
            Code<Encounter.EncounterStatus>? ay_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? az_ = ay_?.Value;
            Code<Encounter.EncounterStatus>? ba_ = context.Operators.Convert<Code<Encounter.EncounterStatus>?>(az_);
            bool? bb_ = context.Operators.Equal(ba_, "finished");
            bool? bc_ = context.Operators.And(ax_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? FaceToFaceOrTelehealthEncounter, Procedure? ChemoBeforeEncounter, Procedure? ChemoAfterEncounter, Condition? CancerDx)?>? n_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Procedure?, Procedure?, Condition?>, (CqlTupleMetadata, Encounter? FaceToFaceOrTelehealthEncounter, Procedure? ChemoBeforeEncounter, Procedure? ChemoAfterEncounter, Condition? CancerDx)?>((IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>>?)k_, l_, m_);
        Encounter? o_((CqlTupleMetadata, Encounter? FaceToFaceOrTelehealthEncounter, Procedure? ChemoBeforeEncounter, Procedure? ChemoAfterEncounter, Condition? CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc) => tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter?>? p_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? FaceToFaceOrTelehealthEncounter, Procedure? ChemoBeforeEncounter, Procedure? ChemoAfterEncounter, Condition? CancerDx)?, Encounter?>(n_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter?>? Initial_Population_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_1, Initial_Population_1_Compute);

    private const long _cacheIndex_Initial_Population_1 = 6943285436870065662L;

    private IEnumerable<Encounter?>? Initial_Population_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter?>? Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = 5218841999648045884L;

    private IEnumerable<Encounter?>? Denominator_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population_1(context);
        return a_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter?>? Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis, Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis = 8751664804723539959L;

    private IEnumerable<Encounter?>? Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? RadiationTreatmentManagement) {
            CqlValueSet? g_ = this.Cancer(context);
            IEnumerable<Condition?>? h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? j_ = context.Operators.Union<Condition?>(h_ as IEnumerable<Condition?>, i_ as IEnumerable<Condition?>);

            bool? k_(Condition? CancerDx) {
                CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerDx);
                Period? n_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.Overlaps(m_!, o_!, "day");
                return p_;
            }

            bool? l_ = context.Operators.WhereAny<Condition?>(j_, k_);
            return l_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter?>(b_, c_);

        bool? e_(Encounter? RadiationTreatmentManagement) {
            CqlInterval<CqlDateTime?>? q_ = this.Measurement_Period(context);
            Period? r_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime?>? s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(q_, s_, "day");
            Code<Encounter.EncounterStatus>? u_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus>? w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>?>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            bool? y_ = context.Operators.And(t_, x_);
            return y_;
        }

        IEnumerable<Encounter?>? f_ = context.Operators.Where<Encounter?>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter?>? Initial_Population_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_2, Initial_Population_2_Compute);

    private const long _cacheIndex_Initial_Population_2 = 5292503655619133850L;

    private IEnumerable<Encounter?>? Initial_Population_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter?>? Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = -8485148921491715243L;

    private IEnumerable<Encounter?>? Denominator_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population_2(context);
        return a_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation?>? Standard_Pain_Assessment_with_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Standard_Pain_Assessment_with_Result, Standard_Pain_Assessment_with_Result_Compute);

    private const long _cacheIndex_Standard_Pain_Assessment_with_Result = -6362953295150502911L;

    private IEnumerable<Observation?>? Standard_Pain_Assessment_with_Result_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation?>? b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? c_(Observation? AssessedPain) {
            DataType? e_ = AssessedPain?.Value;
            object? f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            return g_;
        }

        IEnumerable<Observation?>? d_ = context.Operators.Where<Observation?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter?>? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -6851193730119213038L;

    private IEnumerable<Encounter?>? Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        bool? b_(Encounter? FaceToFaceOrTelehealthEncounterWithChemo) {
            IEnumerable<Observation?>? d_ = this.Standard_Pain_Assessment_with_Result(context);

            bool? e_(Observation? PainAssessed) {
                Period? g_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime?>? h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                DataType? i_ = PainAssessed?.Effective;
                object? j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime?>? k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(h_, k_, "day");
                return l_;
            }

            bool? f_ = context.Operators.WhereAny<Observation?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter?>? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -3723168001165270308L;

    private IEnumerable<Encounter?>? Numerator_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        bool? b_(Encounter? RadiationManagementEncounter) {
            IEnumerable<Observation?>? d_ = this.Standard_Pain_Assessment_with_Result(context);

            bool? e_(Observation? PainAssessed) {
                List<CodeableConcept>? g_ = RadiationManagementEncounter?.Type;

                CqlConcept? h_(CodeableConcept? @this) {
                    CqlConcept? l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return l_;
                }


                bool? i_(CqlConcept? RadiationManagement) {
                    CqlCode? m_ = this.Radiation_treatment_management__5_treatments(context);
                    CqlConcept? n_ = context.Operators.ConvertCodeToConcept(m_);
                    bool? o_ = context.Operators.Equivalent(RadiationManagement, n_);
                    return o_;
                }

                IEnumerable<CqlConcept?>? j_ = context.Operators.SelectWhere<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)g_, h_, i_);
                bool? k_ = context.Operators.Exists<CqlConcept?>(j_!);
                if (k_ ?? false)
                {
                    DataType? p_ = PainAssessed?.Effective;
                    object? q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    CqlDateTime? s_ = context.Operators.End(r_);
                    Period? t_ = RadiationManagementEncounter?.Period;
                    CqlInterval<CqlDateTime?>? u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                    CqlDateTime? v_ = context.Operators.Start(u_);
                    CqlQuantity? w_ = context.Operators.Quantity(6m, "days");
                    CqlDateTime? x_ = context.Operators.Subtract(v_, w_);
                    CqlInterval<CqlDateTime?>? y_ = context.Operators.Interval(x_, v_, true, true);
                    bool? z_ = context.Operators.In<CqlDateTime?>(s_, y_, "day");
                    bool? aa_ = context.Operators.Not((bool?)(v_ is null));
                    bool? ab_ = context.Operators.And(z_, aa_);
                    return ab_;
                }
                else
                {
                    Period? ac_ = RadiationManagementEncounter?.Period;
                    CqlInterval<CqlDateTime?>? ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    DataType? ae_ = PainAssessed?.Effective;
                    object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    CqlInterval<CqlDateTime?>? ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                    bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime?>(ad_, ag_, "day");
                    return ah_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Observation?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4766569364205240576L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 9094594467394759244L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -7396799417959384540L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5032108411701830267L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS157FHIRPainIntensityQuantified_1_0_000() {}

    public static CMS157FHIRPainIntensityQuantified_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS157FHIRPainIntensityQuantified";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BbTIICcXRIYUQAVPLggHEjGOe = new(
       [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
       ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "CancerDx"]);

    #endregion CqlTupleMetadata Properties

}
