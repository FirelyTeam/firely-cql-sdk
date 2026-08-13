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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 5445798036144351774L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS157FHIRPainIntensityQuantified-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (15)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 669900998892653617L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period, Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Compute);

    private const long _cacheIndex_Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period = -6279289550066187025L;

    private IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure ChemoAdministration) {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlQuantity g_ = context.Operators.Quantity(31m, "days");
            CqlDateTime h_ = context.Operators.Subtract(f_, g_);
            CqlDateTime i_ = context.Operators.End(e_);
            CqlInterval<CqlDateTime> j_ = context.Operators.Interval(h_, i_, true, true);
            object k_;
            DataType n_ = ChemoAdministration?.Performed;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                DataType q_ = ChemoAdministration?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                k_ = r_ as CqlDateTime;
            }
            else
            {
                DataType s_ = ChemoAdministration?.Performed;
                object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlQuantity;
                if (u_)
                {
                    DataType v_ = ChemoAdministration?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    k_ = w_ as CqlQuantity;
                }
                else
                {
                    DataType x_ = ChemoAdministration?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlInterval<CqlDateTime>;
                    if (z_)
                    {
                        DataType aa_ = ChemoAdministration?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        k_ = ab_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ac_ = ChemoAdministration?.Performed;
                        object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                        bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                        if (ae_)
                        {
                            DataType af_ = ChemoAdministration?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            k_ = ag_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            k_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
            bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, (string)default);
            // CQL 'and' (40:5-41:70): right operand skipped when left is false
            if (m_ is false)
            {
                return false;
            }
            else
            {
                Code<EventStatus> ah_ = ChemoAdministration?.StatusElement;
                EventStatus? ai_ = ah_?.Value;
                string aj_ = context.Operators.Convert<string>(ai_);
                string[] ak_ = [
                    "completed",
                    "in-progress",
                ];
                bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                return m_ & al_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy, Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Compute);

    private const long _cacheIndex_Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy = 2050822187251213769L;

    private IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Audio_Visual_Telehealth_Encounter(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Procedure> f_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet g_ = this.Cancer(context);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> k_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(e_, f_, f_, j_);

        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? l_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple) {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? q_ = (CqlTupleMetadata_BbTIICcXRIYUQAVPLggHEjGOe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
            return q_;
        }


        bool? m_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc) {
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_eweddbdxxszcpujsdbltgdxcc?.CancerDx);
            Period s_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            bool? u_ = context.Operators.Overlaps(r_, t_, "day");
            bool? v_;
            // CQL 'and' (51:11-52:144): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object z_;
                DataType ak_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool am_ = al_ is CqlDateTime;
                if (am_)
                {
                    DataType an_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    z_ = ao_ as CqlDateTime;
                }
                else
                {
                    DataType ap_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlQuantity;
                    if (ar_)
                    {
                        DataType as_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        z_ = at_ as CqlQuantity;
                    }
                    else
                    {
                        DataType au_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlDateTime>;
                        if (aw_)
                        {
                            DataType ax_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            z_ = ay_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType az_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            bool bb_ = ba_ is CqlInterval<CqlQuantity>;
                            if (bb_)
                            {
                                DataType bc_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                                object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                                z_ = bd_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                z_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                Period ac_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.End(ad_);
                CqlQuantity af_ = context.Operators.Quantity(30m, "days");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ag_, ae_, true, true);
                bool? ai_ = context.Operators.In<CqlDateTime>(ab_, ah_, "day");
                bool? aj_;
                // CQL 'and' (52:11-52:144): right operand skipped when left is false
                if (ai_ is false)
                {
                    aj_ = false;
                }
                else
                {
                    Period be_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                    CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                    CqlDateTime bg_ = context.Operators.End(bf_);
                    aj_ = ai_ & (!((bool?)(bg_ is null)));
                }
                v_ = u_ & aj_;
            }
            bool? w_;
            // CQL 'and' (51:11-53:142): right operand skipped when left is false
            if (v_ is false)
            {
                w_ = false;
            }
            else
            {
                object bh_;
                DataType bs_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType bv_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bh_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType bx_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlQuantity;
                    if (bz_)
                    {
                        DataType ca_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bh_ = cb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cc_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType cf_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            bh_ = cg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ch_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            bool cj_ = ci_ is CqlInterval<CqlQuantity>;
                            if (cj_)
                            {
                                DataType ck_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                                bh_ = cl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bh_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                Period bk_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.End(bl_);
                CqlQuantity bn_ = context.Operators.Quantity(30m, "days");
                CqlDateTime bo_ = context.Operators.Add(bm_, bn_);
                CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bm_, bo_, true, true);
                bool? bq_ = context.Operators.In<CqlDateTime>(bj_, bp_, "day");
                bool? br_;
                // CQL 'and' (53:11-53:142): right operand skipped when left is false
                if (bq_ is false)
                {
                    br_ = false;
                }
                else
                {
                    Period cm_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                    CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                    CqlDateTime co_ = context.Operators.End(cn_);
                    br_ = bq_ & (!((bool?)(co_ is null)));
                }
                w_ = v_ & br_;
            }
            bool? x_;
            // CQL 'and' (51:11-54:120): right operand skipped when left is false
            if (w_ is false)
            {
                x_ = false;
            }
            else
            {
                object cp_;
                DataType cu_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                bool cw_ = cv_ is CqlDateTime;
                if (cw_)
                {
                    DataType cx_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    cp_ = cy_ as CqlDateTime;
                }
                else
                {
                    DataType cz_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    bool db_ = da_ is CqlQuantity;
                    if (db_)
                    {
                        DataType dc_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        cp_ = dd_ as CqlQuantity;
                    }
                    else
                    {
                        DataType de_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                        object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                        bool dg_ = df_ is CqlInterval<CqlDateTime>;
                        if (dg_)
                        {
                            DataType dh_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            cp_ = di_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType dj_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                            object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                            bool dl_ = dk_ is CqlInterval<CqlQuantity>;
                            if (dl_)
                            {
                                DataType dm_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                                cp_ = dn_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cp_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_);
                object cr_;
                DataType do_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                bool dq_ = dp_ is CqlDateTime;
                if (dq_)
                {
                    DataType dr_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    cr_ = ds_ as CqlDateTime;
                }
                else
                {
                    DataType dt_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    bool dv_ = du_ is CqlQuantity;
                    if (dv_)
                    {
                        DataType dw_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                        cr_ = dx_ as CqlQuantity;
                    }
                    else
                    {
                        DataType dy_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                        object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                        bool ea_ = dz_ is CqlInterval<CqlDateTime>;
                        if (ea_)
                        {
                            DataType eb_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                            object ec_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eb_);
                            cr_ = ec_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ed_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                            object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                            bool ef_ = ee_ is CqlInterval<CqlQuantity>;
                            if (ef_)
                            {
                                DataType eg_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                                cr_ = eh_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cr_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
                bool? ct_ = context.Operators.SameAs<CqlDateTime>(cq_, cs_, "day");
                x_ = w_ & !ct_;
            }
            bool? y_;
            // CQL 'and' (51:11-55:83): right operand skipped when left is false
            if (x_ is false)
            {
                y_ = false;
            }
            else
            {
                CqlInterval<CqlDateTime> ei_ = this.Measurement_Period(context);
                Period ej_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                bool? el_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ei_, ek_, "day");
                y_ = x_ & el_;
            }
            // CQL 'and' (51:5-56:61): right operand skipped when left is false
            if (y_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> em_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.StatusElement;
                Encounter.EncounterStatus? en_ = em_?.Value;
                Code<Encounter.EncounterStatus> eo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(en_);
                bool? ep_ = context.Operators.Equal(eo_, "finished");
                return y_ & ep_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?> n_ = context.Operators.SelectWhere<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?>(k_, l_, m_);
        Encounter o_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc) => tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> p_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?, Encounter>(n_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_1, Initial_Population_1_Compute);

    private const long _cacheIndex_Initial_Population_1 = 6943285436870065662L;

    private IEnumerable<Encounter> Initial_Population_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = 5218841999648045884L;

    private IEnumerable<Encounter> Denominator_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population_1(context);
        return a_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis, Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Compute);

    private const long _cacheIndex_Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis = 8751664804723539959L;

    private IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter RadiationTreatmentManagement) {
            CqlValueSet g_ = this.Cancer(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);

            bool? k_(Condition CancerDx) {
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerDx);
                Period n_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.Overlaps(m_, o_, "day");
                return p_;
            }

            bool? l_ = context.Operators.WhereAny<Condition>(j_, k_);
            return l_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        bool? e_(Encounter RadiationTreatmentManagement) {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            Period r_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, "day");
            // CQL 'and' (69:5-70:58): right operand skipped when left is false
            if (t_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> u_ = RadiationTreatmentManagement?.StatusElement;
                Encounter.EncounterStatus? v_ = u_?.Value;
                Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                bool? x_ = context.Operators.Equal(w_, "finished");
                return t_ & x_;
            }
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population_2, Initial_Population_2_Compute);

    private const long _cacheIndex_Initial_Population_2 = 5292503655619133850L;

    private IEnumerable<Encounter> Initial_Population_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = -8485148921491715243L;

    private IEnumerable<Encounter> Denominator_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population_2(context);
        return a_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Standard_Pain_Assessment_with_Result, Standard_Pain_Assessment_with_Result_Compute);

    private const long _cacheIndex_Standard_Pain_Assessment_with_Result = -6362953295150502911L;

    private IEnumerable<Observation> Standard_Pain_Assessment_with_Result_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? c_(Observation AssessedPain) {
            DataType e_ = AssessedPain?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            return !((bool?)(f_ is null));
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -6851193730119213038L;

    private IEnumerable<Encounter> Numerator_1_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        bool? b_(Encounter FaceToFaceOrTelehealthEncounterWithChemo) {
            IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);

            bool? e_(Observation PainAssessed) {
                Period g_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                DataType i_ = PainAssessed?.Effective;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                bool? l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, "day");
                return l_;
            }

            bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -3723168001165270308L;

    private IEnumerable<Encounter> Numerator_2_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        bool? b_(Encounter RadiationManagementEncounter) {
            IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);

            bool? e_(Observation PainAssessed) {
                List<CodeableConcept> g_ = RadiationManagementEncounter?.Type;

                CqlConcept h_(CodeableConcept @this) {
                    CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return l_;
                }


                bool? i_(CqlConcept RadiationManagement) {
                    CqlCode m_ = this.Radiation_treatment_management__5_treatments(context);
                    CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                    bool? o_ = context.Operators.Equivalent(RadiationManagement, n_);
                    return o_;
                }

                IEnumerable<CqlConcept> j_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_, i_);
                bool? k_ = context.Operators.Exists<CqlConcept>(j_);
                if (k_ ?? false)
                {
                    DataType p_ = PainAssessed?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    CqlDateTime s_ = context.Operators.End(r_);
                    Period t_ = RadiationManagementEncounter?.Period;
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                    CqlDateTime v_ = context.Operators.Start(u_);
                    CqlQuantity w_ = context.Operators.Quantity(6m, "days");
                    CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                    CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, v_, true, true);
                    bool? z_ = context.Operators.In<CqlDateTime>(s_, y_, "day");
                    // CQL 'and' (78:16-78:132): right operand skipped when left is false
                    if (z_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period aa_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                        CqlDateTime ac_ = context.Operators.Start(ab_);
                        return z_ & (!((bool?)(ac_ is null)));
                    }
                }
                else
                {
                    Period ad_ = RadiationManagementEncounter?.Period;
                    CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                    DataType af_ = PainAssessed?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                    bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ah_, "day");
                    return ai_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Observation>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4766569364205240576L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 9094594467394759244L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -7396799417959384540L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 5032108411701830267L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
