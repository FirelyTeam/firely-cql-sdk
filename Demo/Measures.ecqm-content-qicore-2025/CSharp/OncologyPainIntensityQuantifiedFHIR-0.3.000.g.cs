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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("OncologyPainIntensityQuantifiedFHIR", "0.3.000")]
public partial class OncologyPainIntensityQuantifiedFHIR_0_3_000 : ILibrary, ISingleton<OncologyPainIntensityQuantifiedFHIR_0_3_000>
{
    private OncologyPainIntensityQuantifiedFHIR_0_3_000() {}

    public static OncologyPainIntensityQuantifiedFHIR_0_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "OncologyPainIntensityQuantifiedFHIR";
    public string Version => "0.3.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Radiation treatment management, 5 treatments", codeId: "77427", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Radiation_treatment_management__5_treatments(CqlContext _) => _Radiation_treatment_management__5_treatments;
    private static readonly CqlCode _Radiation_treatment_management__5_treatments = new CqlCode("77427", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Radiation_treatment_management__5_treatments]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("OncologyPainIntensityQuantifiedFHIR-0.3.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Chemotherapy_Administration(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? c_(Procedure ChemoAdministration)
        {
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlQuantity g_ = context.Operators.Quantity(31m, "days");
            CqlDateTime h_ = context.Operators.Subtract(f_, g_);
            CqlDateTime j_ = context.Operators.End(e_);
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);
            object l_()
            {
                bool t_()
                {
                    DataType x_ = ChemoAdministration?.Performed;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlDateTime;

                    return z_;
                };
                bool u_()
                {
                    DataType aa_ = ChemoAdministration?.Performed;
                    object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                    bool ac_ = ab_ is CqlInterval<CqlDateTime>;

                    return ac_;
                };
                bool v_()
                {
                    DataType ad_ = ChemoAdministration?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlQuantity;

                    return af_;
                };
                bool w_()
                {
                    DataType ag_ = ChemoAdministration?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlInterval<CqlQuantity>;

                    return ai_;
                };
                if (t_())
                {
                    DataType aj_ = ChemoAdministration?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);

                    return (ak_ as CqlDateTime) as object;
                }
                else if (u_())
                {
                    DataType al_ = ChemoAdministration?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);

                    return (am_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (v_())
                {
                    DataType an_ = ChemoAdministration?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);

                    return (ao_ as CqlQuantity) as object;
                }
                else if (w_())
                {
                    DataType ap_ = ChemoAdministration?.Performed;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);

                    return (aq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_());
            bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, default);
            Code<EventStatus> o_ = ChemoAdministration?.StatusElement;
            EventStatus? p_ = o_?.Value;
            string q_ = context.Operators.Convert<string>(p_);
            bool? r_ = context.Operators.Equal(q_, "completed");
            bool? s_ = context.Operators.And(n_, r_);

            return s_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Audio_Visual_Telehealth_Encounter(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Procedure> f_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
        CqlValueSet h_ = this.Cancer(context);
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<ValueTuple<Encounter, Procedure, Procedure, Condition>> j_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, Condition>(e_, f_, f_, i_);
        (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? k_(ValueTuple<Encounter, Procedure, Procedure, Condition> _valueTuple)
        {
            (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? r_ = (CqlTupleMetadata_BbTIICcXRIYUQAVPLggHEjGOe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);

            return r_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?> l_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, Condition>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?>(j_, k_);
        bool? m_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc)
        {
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_eweddbdxxszcpujsdbltgdxcc?.CancerDx as object);
            Period t_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            bool? v_ = context.Operators.Overlaps(s_, u_, default);
            object w_()
            {
                bool bz_()
                {
                    DataType cd_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlDateTime;

                    return cf_;
                };
                bool ca_()
                {
                    DataType cg_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlInterval<CqlDateTime>;

                    return ci_;
                };
                bool cb_()
                {
                    DataType cj_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlQuantity;

                    return cl_;
                };
                bool cc_()
                {
                    DataType cm_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlInterval<CqlQuantity>;

                    return co_;
                };
                if (bz_())
                {
                    DataType cp_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);

                    return (cq_ as CqlDateTime) as object;
                }
                else if (ca_())
                {
                    DataType cr_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);

                    return (cs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cb_())
                {
                    DataType ct_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);

                    return (cu_ as CqlQuantity) as object;
                }
                else if (cc_())
                {
                    DataType cv_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);

                    return (cw_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_());
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            CqlQuantity ac_ = context.Operators.Quantity(30m, "days");
            CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
            CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(y_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ai_, am_);
            bool? ao_ = context.Operators.And(v_, an_);
            object ap_()
            {
                bool cx_()
                {
                    DataType db_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlDateTime;

                    return dd_;
                };
                bool cy_()
                {
                    DataType de_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlDateTime>;

                    return dg_;
                };
                bool cz_()
                {
                    DataType dh_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlQuantity;

                    return dj_;
                };
                bool da_()
                {
                    DataType dk_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    bool dm_ = dl_ is CqlInterval<CqlQuantity>;

                    return dm_;
                };
                if (cx_())
                {
                    DataType dn_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);

                    return (do_ as CqlDateTime) as object;
                }
                else if (cy_())
                {
                    DataType dp_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object dq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dp_);

                    return (dq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cz_())
                {
                    DataType dr_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);

                    return (ds_ as CqlQuantity) as object;
                }
                else if (da_())
                {
                    DataType dt_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object du_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dt_);

                    return (du_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_());
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime au_ = context.Operators.End(at_);
            CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlDateTime az_ = context.Operators.Add(ax_, ac_);
            CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(au_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDateTime>(ar_, ba_, "day");
            CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            CqlDateTime be_ = context.Operators.End(bd_);
            bool? bf_ = context.Operators.Not((bool?)(be_ is null));
            bool? bg_ = context.Operators.And(bb_, bf_);
            bool? bh_ = context.Operators.And(ao_, bg_);
            object bi_()
            {
                bool dv_()
                {
                    DataType dz_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;

                    return eb_;
                };
                bool dw_()
                {
                    DataType ec_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlInterval<CqlDateTime>;

                    return ee_;
                };
                bool dx_()
                {
                    DataType ef_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    bool eh_ = eg_ is CqlQuantity;

                    return eh_;
                };
                bool dy_()
                {
                    DataType ei_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    bool ek_ = ej_ is CqlInterval<CqlQuantity>;

                    return ek_;
                };
                if (dv_())
                {
                    DataType el_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);

                    return (em_ as CqlDateTime) as object;
                }
                else if (dw_())
                {
                    DataType en_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);

                    return (eo_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (dx_())
                {
                    DataType ep_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object eq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ep_);

                    return (eq_ as CqlQuantity) as object;
                }
                else if (dy_())
                {
                    DataType er_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoAfterEncounter?.Performed;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);

                    return (es_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_());
            object bk_()
            {
                bool et_()
                {
                    DataType ex_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlDateTime;

                    return ez_;
                };
                bool eu_()
                {
                    DataType fa_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    bool fc_ = fb_ is CqlInterval<CqlDateTime>;

                    return fc_;
                };
                bool ev_()
                {
                    DataType fd_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                    bool ff_ = fe_ is CqlQuantity;

                    return ff_;
                };
                bool ew_()
                {
                    DataType fg_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                    bool fi_ = fh_ is CqlInterval<CqlQuantity>;

                    return fi_;
                };
                if (et_())
                {
                    DataType fj_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);

                    return (fk_ as CqlDateTime) as object;
                }
                else if (eu_())
                {
                    DataType fl_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object fm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fl_);

                    return (fm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ev_())
                {
                    DataType fn_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object fo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fn_);

                    return (fo_ as CqlQuantity) as object;
                }
                else if (ew_())
                {
                    DataType fp_ = tuple_eweddbdxxszcpujsdbltgdxcc?.ChemoBeforeEncounter?.Performed;
                    object fq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fp_);

                    return (fq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_());
            bool? bm_ = context.Operators.SameAs<CqlDateTime>(bj_, bl_, "day");
            bool? bn_ = context.Operators.Not(bm_);
            bool? bo_ = context.Operators.And(bh_, bn_);
            CqlInterval<CqlDateTime> bp_ = this.Measurement_Period(context);
            CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            bool? bs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bp_, br_, default);
            bool? bt_ = context.Operators.And(bo_, bs_);
            Code<Encounter.EncounterStatus> bu_ = tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter?.StatusElement;
            Encounter.EncounterStatus? bv_ = bu_?.Value;
            Code<Encounter.EncounterStatus> bw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bv_);
            bool? bx_ = context.Operators.Equal(bw_, "finished");
            bool? by_ = context.Operators.And(bt_, bx_);

            return by_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?> n_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?>(l_, m_);
        Encounter o_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)? tuple_eweddbdxxszcpujsdbltgdxcc) =>
            tuple_eweddbdxxszcpujsdbltgdxcc?.FaceToFaceOrTelehealthEncounter;
        IEnumerable<Encounter> p_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, Condition CancerDx)?, Encounter>(n_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Distinct<Encounter>(p_);

        return q_;
    }


    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population_1(context);

        return a_;
    }


    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Radiation_Treatment_Management(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_(Encounter RadiationTreatmentManagement)
        {
            CqlValueSet g_ = this.Cancer(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? i_(Condition CancerDx)
            {
                bool? m_ = QICoreCommon_4_0_000.Instance.isActive(context, CancerDx as object);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerDx as object);
                Period o_ = RadiationTreatmentManagement?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.Overlaps(n_, p_, default);
                bool? r_ = context.Operators.And(m_, q_);

                return r_;
            };
            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            Encounter k_(Condition CancerDx) =>
                RadiationTreatmentManagement;
            IEnumerable<Encounter> l_ = context.Operators.Select<Condition, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);
        bool? e_(Encounter RadiationTreatmentManagement)
        {
            CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
            Period t_ = RadiationTreatmentManagement?.Period;
            CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
            bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(s_, u_, default);
            Code<Encounter.EncounterStatus> w_ = RadiationTreatmentManagement?.StatusElement;
            Encounter.EncounterStatus? x_ = w_?.Value;
            Code<Encounter.EncounterStatus> y_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(x_);
            bool? z_ = context.Operators.Equal(y_, "finished");
            bool? aa_ = context.Operators.And(v_, z_);

            return aa_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population_2(context);

        return a_;
    }


    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context)
    {
        CqlValueSet a_ = this.Standardized_Pain_Assessment_Tool(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        bool? c_(Observation AssessedPain)
        {
            DataType e_ = AssessedPain?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            Code<ObservationStatus> h_ = AssessedPain?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            bool? k_ = context.Operators.Equal(j_, "final");
            bool? l_ = context.Operators.And(g_, k_);

            return l_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
        IEnumerable<Encounter> b_(Encounter FaceToFaceOrTelehealthEncounterWithChemo)
        {
            IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? e_(Observation PainAssessed)
            {
                Period i_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                DataType k_ = PainAssessed?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, default);

                return n_;
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            Encounter g_(Observation PainAssessed) =>
                FaceToFaceOrTelehealthEncounterWithChemo;
            IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
        IEnumerable<Encounter> b_(Encounter RadiationManagementEncounter)
        {
            IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);
            bool? e_(Observation PainAssessed)
            {
                bool? i_()
                {
                    bool j_()
                    {
                        List<CodeableConcept> k_ = RadiationManagementEncounter?.Type;
                        CqlConcept l_(CodeableConcept @this)
                        {
                            CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                            return q_;
                        };
                        IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
                        bool? n_(CqlConcept RadiationManagement)
                        {
                            CqlCode r_ = this.Radiation_treatment_management__5_treatments(context);
                            CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                            bool? t_ = context.Operators.Equivalent(RadiationManagement, s_);

                            return t_;
                        };
                        IEnumerable<CqlConcept> o_ = context.Operators.Where<CqlConcept>(m_, n_);
                        bool? p_ = context.Operators.Exists<CqlConcept>(o_);

                        return p_ ?? false;
                    };
                    if (j_())
                    {
                        DataType u_ = PainAssessed?.Effective;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                        CqlDateTime x_ = context.Operators.End(w_);
                        Period y_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        CqlDateTime aa_ = context.Operators.Start(z_);
                        CqlQuantity ab_ = context.Operators.Quantity(6m, "days");
                        CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
                        CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        CqlDateTime af_ = context.Operators.Start(ae_);
                        CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ac_, af_, true, true);
                        bool? ah_ = context.Operators.In<CqlDateTime>(x_, ag_, "day");
                        CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                        CqlDateTime ak_ = context.Operators.Start(aj_);
                        bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                        bool? am_ = context.Operators.And(ah_, al_);

                        return am_;
                    }
                    else
                    {
                        Period an_ = RadiationManagementEncounter?.Period;
                        CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                        DataType ap_ = PainAssessed?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
                        bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ar_, "day");

                        return as_;
                    }
                };

                return i_();
            };
            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
            Encounter g_(Observation PainAssessed) =>
                RadiationManagementEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BbTIICcXRIYUQAVPLggHEjGOe = new(
      [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(Condition)],
      ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "CancerDx"]);

    #endregion CqlTupleMetadata Properties

}
