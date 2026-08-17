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
            DataType o_ = ChemoAdministration?.Performed;
            object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            bool q_ = p_ is CqlDateTime;
            if (q_)
            {
                k_ = p_ as CqlDateTime;
            }
            else
            {
                bool r_ = p_ is CqlQuantity;
                if (r_)
                {
                    k_ = p_ as CqlQuantity;
                }
                else
                {
                    bool s_ = p_ is CqlInterval<CqlDateTime>;
                    if (s_)
                    {
                        k_ = p_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool t_ = p_ is CqlInterval<CqlQuantity>;
                        if (t_)
                        {
                            k_ = p_ as CqlInterval<CqlQuantity>;
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

            bool? n_() {
                Code<EventStatus> u_ = ChemoAdministration?.StatusElement;
                EventStatus? v_ = u_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                string[] x_ = [
                    "completed",
                    "in-progress",
                ];
                bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                return (bool?)((CqlBoolean)y_);
            }

            return (bool?)(/* CQL 'and' (40:5-41:70) */ ((CqlBoolean)m_
                && (CqlBoolean)n_()));
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

            bool? v_() {
                object aa_;
                DataType al_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    aa_ = am_ as CqlDateTime;
                }
                else
                {
                    bool ao_ = am_ is CqlQuantity;
                    if (ao_)
                    {
                        aa_ = am_ as CqlQuantity;
                    }
                    else
                    {
                        bool ap_ = am_ is CqlInterval<CqlDateTime>;
                        if (ap_)
                        {
                            aa_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool aq_ = am_ is CqlInterval<CqlQuantity>;
                            if (aq_)
                            {
                                aa_ = am_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                aa_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                Period ad_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlDateTime af_ = context.Operators.End(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(30m, "days");
                CqlDateTime ah_ = context.Operators.Subtract(af_, ag_);
                CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ah_, af_, true, true);
                bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, "day");

                bool? ak_() {
                    Period ar_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                    CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                    CqlDateTime at_ = context.Operators.End(as_);
                    return (bool?)((CqlBoolean)(!((bool?)(at_ is null))));
                }

                return (bool?)(/* CQL 'and' (52:11-52:144) */ ((CqlBoolean)aj_
                    && (CqlBoolean)ak_()));
            }


            bool? w_() {
                object au_;
                DataType bf_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    au_ = bg_ as CqlDateTime;
                }
                else
                {
                    bool bi_ = bg_ is CqlQuantity;
                    if (bi_)
                    {
                        au_ = bg_ as CqlQuantity;
                    }
                    else
                    {
                        bool bj_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            au_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bk_ = bg_ is CqlInterval<CqlQuantity>;
                            if (bk_)
                            {
                                au_ = bg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                au_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                Period ax_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.End(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(30m, "days");
                CqlDateTime bb_ = context.Operators.Add(az_, ba_);
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(az_, bb_, true, true);
                bool? bd_ = context.Operators.In<CqlDateTime>(aw_, bc_, "day");

                bool? be_() {
                    Period bl_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                    CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                    CqlDateTime bn_ = context.Operators.End(bm_);
                    return (bool?)((CqlBoolean)(!((bool?)(bn_ is null))));
                }

                return (bool?)(/* CQL 'and' (53:11-53:142) */ ((CqlBoolean)bd_
                    && (CqlBoolean)be_()));
            }


            bool? x_() {
                object bo_;
                DataType bt_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                bool bv_ = bu_ is CqlDateTime;
                if (bv_)
                {
                    bo_ = bu_ as CqlDateTime;
                }
                else
                {
                    bool bw_ = bu_ is CqlQuantity;
                    if (bw_)
                    {
                        bo_ = bu_ as CqlQuantity;
                    }
                    else
                    {
                        bool bx_ = bu_ is CqlInterval<CqlDateTime>;
                        if (bx_)
                        {
                            bo_ = bu_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool by_ = bu_ is CqlInterval<CqlQuantity>;
                            if (by_)
                            {
                                bo_ = bu_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bo_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
                object bq_;
                DataType bz_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlDateTime;
                if (cb_)
                {
                    bq_ = ca_ as CqlDateTime;
                }
                else
                {
                    bool cc_ = ca_ is CqlQuantity;
                    if (cc_)
                    {
                        bq_ = ca_ as CqlQuantity;
                    }
                    else
                    {
                        bool cd_ = ca_ is CqlInterval<CqlDateTime>;
                        if (cd_)
                        {
                            bq_ = ca_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ce_ = ca_ is CqlInterval<CqlQuantity>;
                            if (ce_)
                            {
                                bq_ = ca_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bq_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                bool? bs_ = context.Operators.SameAs<CqlDateTime>(bp_, br_, "day");
                return (bool?)((CqlBoolean)!bs_);
            }


            bool? y_() {
                CqlInterval<CqlDateTime> cf_ = this.Measurement_Period(context);
                Period cg_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cg_);
                bool? ci_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(cf_, ch_, "day");
                return (bool?)((CqlBoolean)ci_);
            }


            bool? z_() {
                Code<Encounter.EncounterStatus> cj_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.StatusElement;
                Encounter.EncounterStatus? ck_ = cj_?.Value;
                Code<Encounter.EncounterStatus> cl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ck_);
                bool? cm_ = context.Operators.Equal(cl_, "finished");
                return (bool?)((CqlBoolean)cm_);
            }

            return (bool?)(/* CQL 'and' (51:5-56:61) */ (/* CQL 'and' (51:11-55:83) */ (/* CQL 'and' (51:11-54:120) */ (/* CQL 'and' (51:11-53:142) */ (/* CQL 'and' (51:11-52:144) */ ((CqlBoolean)u_
                && (CqlBoolean)v_())
                && (CqlBoolean)w_())
                && (CqlBoolean)x_())
                && (CqlBoolean)y_())
                && (CqlBoolean)z_()));
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

            bool? u_() {
                Code<Encounter.EncounterStatus> v_ = RadiationTreatmentManagement?.StatusElement;
                Encounter.EncounterStatus? w_ = v_?.Value;
                Code<Encounter.EncounterStatus> x_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(w_);
                bool? y_ = context.Operators.Equal(x_, "finished");
                return (bool?)((CqlBoolean)y_);
            }

            return (bool?)(/* CQL 'and' (69:5-70:58) */ ((CqlBoolean)t_
                && (CqlBoolean)u_()));
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

                    bool? aa_() {
                        Period ab_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                        CqlDateTime ad_ = context.Operators.Start(ac_);
                        return (bool?)((CqlBoolean)(!((bool?)(ad_ is null))));
                    }

                    return (bool?)(/* CQL 'and' (78:16-78:132) */ ((CqlBoolean)z_
                        && (CqlBoolean)aa_()));
                }
                else
                {
                    Period ae_ = RadiationManagementEncounter?.Period;
                    CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                    DataType ag_ = PainAssessed?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                    bool? aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(af_, ai_, "day");
                    return aj_;
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
