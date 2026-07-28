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

            object k_() {

                bool t_() {
                    DataType x_ = ChemoAdministration?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlDateTime;
                    return z_;
                }


                bool u_() {
                    DataType aa_ = ChemoAdministration?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlQuantity;
                    return ac_;
                }


                bool v_() {
                    DataType ad_ = ChemoAdministration?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    return af_;
                }


                bool w_() {
                    DataType ag_ = ChemoAdministration?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                    return ai_;
                }

                if (t_())
                {
                    DataType aj_ = ChemoAdministration?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    return ak_ as CqlDateTime;
                }
                else if (u_())
                {
                    DataType al_ = ChemoAdministration?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    return am_ as CqlQuantity;
                }
                else if (v_())
                {
                    DataType an_ = ChemoAdministration?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    return ao_ as CqlInterval<CqlDateTime>;
                }
                else if (w_())
                {
                    DataType ap_ = ChemoAdministration?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    return aq_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
            bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, (string)default);
            Code<EventStatus> n_ = ChemoAdministration?.StatusElement;
            EventStatus? o_ = n_?.Value;
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "completed",
                "in-progress",
            ];
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
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
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? s_ = (CqlTupleMetadata_BbTIICcXRIYUQAVPLggHEjGOe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
            return s_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?> m_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?>(k_, l_);

        bool? n_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc) {
            CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_eweddbdxxszcpujsdbltgdxcc?.CancerDx);
            Period u_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            bool? w_ = context.Operators.Overlaps(t_, v_, "day");

            object x_() {

                bool bf_() {
                    DataType bj_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    bool bl_ = bk_ is CqlDateTime;
                    return bl_;
                }


                bool bg_() {
                    DataType bm_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlQuantity;
                    return bo_;
                }


                bool bh_() {
                    DataType bp_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlInterval<CqlDateTime>;
                    return br_;
                }


                bool bi_() {
                    DataType bs_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                    return bu_;
                }

                if (bf_())
                {
                    DataType bv_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return bw_ as CqlDateTime;
                }
                else if (bg_())
                {
                    DataType bx_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return by_ as CqlQuantity;
                }
                else if (bh_())
                {
                    DataType bz_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return ca_ as CqlInterval<CqlDateTime>;
                }
                else if (bi_())
                {
                    DataType cb_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return cc_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDateTime aa_ = context.Operators.End(v_);
            CqlQuantity ab_ = context.Operators.Quantity(30m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(ac_, aa_, true, true);
            bool? ae_ = context.Operators.In<CqlDateTime>(z_, ad_, "day");
            bool? af_ = context.Operators.Not((bool?)(aa_ is null));
            bool? ag_ = context.Operators.And(ae_, af_);
            bool? ah_ = context.Operators.And(w_, ag_);

            object ai_() {

                bool cd_() {
                    DataType ch_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlDateTime;
                    return cj_;
                }


                bool ce_() {
                    DataType ck_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlQuantity;
                    return cm_;
                }


                bool cf_() {
                    DataType cn_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlInterval<CqlDateTime>;
                    return cp_;
                }


                bool cg_() {
                    DataType cq_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlQuantity>;
                    return cs_;
                }

                if (cd_())
                {
                    DataType ct_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return cu_ as CqlDateTime;
                }
                else if (ce_())
                {
                    DataType cv_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    return cw_ as CqlQuantity;
                }
                else if (cf_())
                {
                    DataType cx_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                    return cy_ as CqlInterval<CqlDateTime>;
                }
                else if (cg_())
                {
                    DataType cz_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return da_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_());
            CqlDateTime ak_ = context.Operators.Start(aj_);
            CqlDateTime al_ = context.Operators.Add(aa_, ab_);
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aa_, al_, true, true);
            bool? an_ = context.Operators.In<CqlDateTime>(ak_, am_, "day");
            bool? ao_ = context.Operators.And(an_, af_);
            bool? ap_ = context.Operators.And(ah_, ao_);

            object aq_() {

                bool db_() {
                    DataType df_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    bool dh_ = dg_ is CqlDateTime;
                    return dh_;
                }


                bool dc_() {
                    DataType di_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                    bool dk_ = dj_ is CqlQuantity;
                    return dk_;
                }


                bool dd_() {
                    DataType dl_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    bool dn_ = dm_ is CqlInterval<CqlDateTime>;
                    return dn_;
                }


                bool de_() {
                    DataType do_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                    bool dq_ = dp_ is CqlInterval<CqlQuantity>;
                    return dq_;
                }

                if (db_())
                {
                    DataType dr_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                    return ds_ as CqlDateTime;
                }
                else if (dc_())
                {
                    DataType dt_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);
                    return du_ as CqlQuantity;
                }
                else if (dd_())
                {
                    DataType dv_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                    return dw_ as CqlInterval<CqlDateTime>;
                }
                else if (de_())
                {
                    DataType dx_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    return dy_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_());

            object as_() {

                bool dz_() {
                    DataType ed_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ee_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ed_);
                    bool ef_ = ee_ is CqlDateTime;
                    return ef_;
                }


                bool ea_() {
                    DataType eg_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                    bool ei_ = eh_ is CqlQuantity;
                    return ei_;
                }


                bool eb_() {
                    DataType ej_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                    bool el_ = ek_ is CqlInterval<CqlDateTime>;
                    return el_;
                }


                bool ec_() {
                    DataType em_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    bool eo_ = en_ is CqlInterval<CqlQuantity>;
                    return eo_;
                }

                if (dz_())
                {
                    DataType ep_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);
                    return eq_ as CqlDateTime;
                }
                else if (ea_())
                {
                    DataType er_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    return es_ as CqlQuantity;
                }
                else if (eb_())
                {
                    DataType et_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                    return eu_ as CqlInterval<CqlDateTime>;
                }
                else if (ec_())
                {
                    DataType ev_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ew_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ev_);
                    return ew_ as CqlInterval<CqlQuantity>;
                }
                else
                {
                    return null;
                }
            }

            CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_());
            bool? au_ = context.Operators.SameAs<CqlDateTime>(ar_, at_, "day");
            bool? av_ = context.Operators.Not(au_);
            bool? aw_ = context.Operators.And(ap_, av_);
            CqlInterval<CqlDateTime> ax_ = this.Measurement_Period(context);
            bool? ay_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ax_, v_, "day");
            bool? az_ = context.Operators.And(aw_, ay_);
            Code<Encounter.EncounterStatus> ba_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? bb_ = ba_?.Value;
            Code<Encounter.EncounterStatus> bc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bb_);
            bool? bd_ = context.Operators.Equal(bc_, "finished");
            bool? be_ = context.Operators.And(az_, bd_);
            return be_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?> o_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?>(m_, n_);
        Encounter p_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc) => tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> q_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?, Encounter>(o_, p_);
        IEnumerable<Encounter> r_ = context.Operators.Distinct<Encounter>(q_);
        return r_;
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
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerDx);
                Period o_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.Overlaps(n_, p_, "day");
                return q_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            return m_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        bool? e_(Encounter RadiationTreatmentManagement) {
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            Period s_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
            bool? u_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, t_, "day");
            Code<Encounter.EncounterStatus> v_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? w_ = v_?.Value;
            Code<Encounter.EncounterStatus> x_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(w_);
            bool? y_ = context.Operators.Equal(x_, "finished");
            bool? z_ = context.Operators.And(u_, y_);
            return z_;
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
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            return g_;
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
                Period h_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                DataType j_ = PainAssessed?.Effective;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");
                return m_;
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            bool? g_ = context.Operators.Exists<Observation>(f_);
            return g_;
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

                bool? h_() {

                    bool i_() {
                        List<CodeableConcept> j_ = RadiationManagementEncounter?.Type;

                        CqlConcept k_(CodeableConcept @this) {
                            CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                            return p_;
                        }

                        IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);

                        bool? m_(CqlConcept RadiationManagement) {
                            CqlCode q_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                            bool? s_ = context.Operators.Equivalent(RadiationManagement, r_);
                            return s_;
                        }

                        IEnumerable<CqlConcept> n_ = context.Operators.Where<CqlConcept>(l_, m_);
                        bool? o_ = context.Operators.Exists<CqlConcept>(n_);
                        return o_ ?? false;
                    }

                    if (i_())
                    {
                        DataType t_ = PainAssessed?.Effective;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
                        CqlDateTime w_ = context.Operators.End(v_);
                        Period x_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                        CqlDateTime z_ = context.Operators.Start(y_);
                        CqlQuantity aa_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
                        CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(ab_, z_, true, true);
                        bool? ad_ = context.Operators.In<CqlDateTime>(w_, ac_, "day");
                        bool? ae_ = context.Operators.Not((bool?)(z_ is null));
                        bool? af_ = context.Operators.And(ad_, ae_);
                        return af_;
                    }
                    else
                    {
                        Period ag_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                        DataType ai_ = PainAssessed?.Effective;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                        bool? al_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, ak_, "day");
                        return al_;
                    }
                }

                return h_();
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            bool? g_ = context.Operators.Exists<Observation>(f_);
            return g_;
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
