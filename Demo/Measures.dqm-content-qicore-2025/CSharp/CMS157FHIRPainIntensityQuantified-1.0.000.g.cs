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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS157FHIRPainIntensityQuantified", "1.0.000")]
public partial class CMS157FHIRPainIntensityQuantified_1_0_000 : ILibrary, ISingleton<CMS157FHIRPainIntensityQuantified_1_0_000>
{
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

    private readonly Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS157FHIRPainIntensityQuantified-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private readonly Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private readonly Cached<IEnumerable<Procedure>> _Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Chemotherapy Within 31 Days Prior and During Measurement Period")]
    public IEnumerable<Procedure> Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(CqlContext context) =>
        _Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Chemotherapy_Administration(context);
                IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? c_(Procedure ChemoAdministration) {
                    CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                    CqlDateTime f_ = context.Operators.Start(e_);
                    CqlQuantity g_ = context.Operators.Quantity(31m, "days");
                    CqlDateTime h_ = context.Operators.Subtract(f_, g_);
                    CqlDateTime j_ = context.Operators.End(e_);
                    CqlInterval<CqlDateTime> k_ = context.Operators.Interval(h_, j_, true, true);

                    object l_() {

                        bool u_() {
                            DataType y_ = ChemoAdministration?.Performed;
                            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                            bool aa_ = z_ is CqlDateTime;
                            return aa_;
                        }


                        bool v_() {
                            DataType ab_ = ChemoAdministration?.Performed;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                            return ad_;
                        }


                        bool w_() {
                            DataType ae_ = ChemoAdministration?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            bool ag_ = af_ is CqlQuantity;
                            return ag_;
                        }


                        bool x_() {
                            DataType ah_ = ChemoAdministration?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                            return aj_;
                        }

                        if (u_())
                        {
                            DataType ak_ = ChemoAdministration?.Performed;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            return (al_ as CqlDateTime) as object;
                        }
                        else if (v_())
                        {
                            DataType am_ = ChemoAdministration?.Performed;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            return (an_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (w_())
                        {
                            DataType ao_ = ChemoAdministration?.Performed;
                            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                            return (ap_ as CqlQuantity) as object;
                        }
                        else if (x_())
                        {
                            DataType aq_ = ChemoAdministration?.Performed;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            return (ar_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_());
                    bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, default);
                    Code<EventStatus> o_ = ChemoAdministration?.StatusElement;
                    EventStatus? p_ = o_?.Value;
                    string q_ = context.Operators.Convert<string>(p_);
                    string[] r_ = [
                        "completed",
                        "in-progress",
                    ];
                    bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                    bool? t_ = context.Operators.And(n_, s_);
                    return t_;
                }

                IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
                return d_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Cached = new();

    [CqlExpressionDefinition("Face to Face or Telehealth Encounter with Ongoing Chemotherapy")]
    public IEnumerable<Encounter> Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(CqlContext context) =>
        _Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Audio_Visual_Telehealth_Encounter(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                IEnumerable<Procedure> f_ = this.Chemotherapy_Within_31_Days_Prior_and_During_Measurement_Period(context);
                CqlValueSet h_ = this.Cancer(context);
                IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> l_ = context.Operators.Union<object>(i_ as IEnumerable<object>, k_ as IEnumerable<object>);
                IEnumerable<ValueTuple<Encounter, Procedure, Procedure, object>> m_ = context.Operators.CrossJoin<Encounter, Procedure, Procedure, object>(e_, f_, f_, l_);

                (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)? n_(ValueTuple<Encounter, Procedure, Procedure, object> _valueTuple) {
                    (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)? u_ = (CqlTupleMetadata_HUZMaBjXYCAiGTiLLUTReObKb, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
                    return u_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)?> o_ = context.Operators.Select<ValueTuple<Encounter, Procedure, Procedure, object>, (CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)?>(m_, n_);

                bool? p_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)? tuple_gjjpxhacftczdvrnpdupakjlc) {
                    CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, tuple_gjjpxhacftczdvrnpdupakjlc?.CancerDx);
                    Period w_ = tuple_gjjpxhacftczdvrnpdupakjlc?.FaceToFaceOrTelehealthEncounter?.Period;
                    CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    bool? y_ = context.Operators.Overlaps(v_, x_, "day");

                    object z_() {

                        bool cc_() {
                            DataType cg_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            bool ci_ = ch_ is CqlDateTime;
                            return ci_;
                        }


                        bool cd_() {
                            DataType cj_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            bool cl_ = ck_ is CqlInterval<CqlDateTime>;
                            return cl_;
                        }


                        bool ce_() {
                            DataType cm_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            bool co_ = cn_ is CqlQuantity;
                            return co_;
                        }


                        bool cf_() {
                            DataType cp_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            bool cr_ = cq_ is CqlInterval<CqlQuantity>;
                            return cr_;
                        }

                        if (cc_())
                        {
                            DataType cs_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                            return (ct_ as CqlDateTime) as object;
                        }
                        else if (cd_())
                        {
                            DataType cu_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                            return (cv_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ce_())
                        {
                            DataType cw_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                            return (cx_ as CqlQuantity) as object;
                        }
                        else if (cf_())
                        {
                            DataType cy_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                            return (cz_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    CqlQuantity af_ = context.Operators.Quantity(30m, "days");
                    CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime aj_ = context.Operators.End(ai_);
                    CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ag_, aj_, true, true);
                    bool? al_ = context.Operators.In<CqlDateTime>(ab_, ak_, "day");
                    CqlInterval<CqlDateTime> an_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime ao_ = context.Operators.End(an_);
                    bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
                    bool? aq_ = context.Operators.And(al_, ap_);
                    bool? ar_ = context.Operators.And(y_, aq_);

                    object as_() {

                        bool da_() {
                            DataType de_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            bool dg_ = df_ is CqlDateTime;
                            return dg_;
                        }


                        bool db_() {
                            DataType dh_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                            bool dj_ = di_ is CqlInterval<CqlDateTime>;
                            return dj_;
                        }


                        bool dc_() {
                            DataType dk_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                            bool dm_ = dl_ is CqlQuantity;
                            return dm_;
                        }


                        bool dd_() {
                            DataType dn_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                            bool dp_ = do_ is CqlInterval<CqlQuantity>;
                            return dp_;
                        }

                        if (da_())
                        {
                            DataType dq_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                            return (dr_ as CqlDateTime) as object;
                        }
                        else if (db_())
                        {
                            DataType ds_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                            return (dt_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (dc_())
                        {
                            DataType du_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                            return (dv_ as CqlQuantity) as object;
                        }
                        else if (dd_())
                        {
                            DataType dw_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
                            return (dx_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.toInterval(context, as_());
                    CqlDateTime au_ = context.Operators.Start(at_);
                    CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime ax_ = context.Operators.End(aw_);
                    CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime ba_ = context.Operators.End(az_);
                    CqlDateTime bc_ = context.Operators.Add(ba_, af_);
                    CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ax_, bc_, true, true);
                    bool? be_ = context.Operators.In<CqlDateTime>(au_, bd_, "day");
                    CqlInterval<CqlDateTime> bg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime bh_ = context.Operators.End(bg_);
                    bool? bi_ = context.Operators.Not((bool?)(bh_ is null));
                    bool? bj_ = context.Operators.And(be_, bi_);
                    bool? bk_ = context.Operators.And(ar_, bj_);

                    object bl_() {

                        bool dy_() {
                            DataType ec_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                            bool ee_ = ed_ is CqlDateTime;
                            return ee_;
                        }


                        bool dz_() {
                            DataType ef_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                            bool eh_ = eg_ is CqlInterval<CqlDateTime>;
                            return eh_;
                        }


                        bool ea_() {
                            DataType ei_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                            bool ek_ = ej_ is CqlQuantity;
                            return ek_;
                        }


                        bool eb_() {
                            DataType el_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object em_ = FHIRHelpers_4_4_000.Instance.ToValue(context, el_);
                            bool en_ = em_ is CqlInterval<CqlQuantity>;
                            return en_;
                        }

                        if (dy_())
                        {
                            DataType eo_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object ep_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eo_);
                            return (ep_ as CqlDateTime) as object;
                        }
                        else if (dz_())
                        {
                            DataType eq_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                            return (er_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ea_())
                        {
                            DataType es_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object et_ = FHIRHelpers_4_4_000.Instance.ToValue(context, es_);
                            return (et_ as CqlQuantity) as object;
                        }
                        else if (eb_())
                        {
                            DataType eu_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoAfterEncounter?.Performed;
                            object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                            return (ev_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());

                    object bn_() {

                        bool ew_() {
                            DataType fa_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                            bool fc_ = fb_ is CqlDateTime;
                            return fc_;
                        }


                        bool ex_() {
                            DataType fd_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                            bool ff_ = fe_ is CqlInterval<CqlDateTime>;
                            return ff_;
                        }


                        bool ey_() {
                            DataType fg_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object fh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fg_);
                            bool fi_ = fh_ is CqlQuantity;
                            return fi_;
                        }


                        bool ez_() {
                            DataType fj_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object fk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fj_);
                            bool fl_ = fk_ is CqlInterval<CqlQuantity>;
                            return fl_;
                        }

                        if (ew_())
                        {
                            DataType fm_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object fn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fm_);
                            return (fn_ as CqlDateTime) as object;
                        }
                        else if (ex_())
                        {
                            DataType fo_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object fp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fo_);
                            return (fp_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (ey_())
                        {
                            DataType fq_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object fr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fq_);
                            return (fr_ as CqlQuantity) as object;
                        }
                        else if (ez_())
                        {
                            DataType fs_ = tuple_gjjpxhacftczdvrnpdupakjlc?.ChemoBeforeEncounter?.Performed;
                            object ft_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fs_);
                            return (ft_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_());
                    bool? bp_ = context.Operators.SameAs<CqlDateTime>(bm_, bo_, "day");
                    bool? bq_ = context.Operators.Not(bp_);
                    bool? br_ = context.Operators.And(bk_, bq_);
                    CqlInterval<CqlDateTime> bs_ = this.Measurement_Period(context);
                    CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    bool? bv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bs_, bu_, "day");
                    bool? bw_ = context.Operators.And(br_, bv_);
                    Code<Encounter.EncounterStatus> bx_ = tuple_gjjpxhacftczdvrnpdupakjlc?.FaceToFaceOrTelehealthEncounter?.StatusElement;
                    Encounter.EncounterStatus? by_ = bx_?.Value;
                    Code<Encounter.EncounterStatus> bz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(by_);
                    bool? ca_ = context.Operators.Equal(bz_, "finished");
                    bool? cb_ = context.Operators.And(bw_, ca_);
                    return cb_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)?> q_ = context.Operators.Where<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)?>(o_, p_);
                Encounter r_((CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)? tuple_gjjpxhacftczdvrnpdupakjlc) => tuple_gjjpxhacftczdvrnpdupakjlc?.FaceToFaceOrTelehealthEncounter;
                IEnumerable<Encounter> s_ = context.Operators.Select<(CqlTupleMetadata, Encounter FaceToFaceOrTelehealthEncounter, Procedure ChemoBeforeEncounter, Procedure ChemoAfterEncounter, object CancerDx)?, Encounter>(q_, r_);
                IEnumerable<Encounter> t_ = context.Operators.Distinct<Encounter>(s_);
                return t_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Initial_Population_1_Cached = new();

    [CqlExpressionDefinition("Initial Population 1")]
    public IEnumerable<Encounter> Initial_Population_1(CqlContext context) =>
        _Initial_Population_1_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);
                return a_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Denominator_1_Cached = new();

    [CqlExpressionDefinition("Denominator 1")]
    public IEnumerable<Encounter> Denominator_1(CqlContext context) =>
        _Denominator_1_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Initial_Population_1(context);
                return a_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Radiation Treatment Management During Measurement Period with Cancer Diagnosis")]
    public IEnumerable<Encounter> Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(CqlContext context) =>
        _Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Radiation_Treatment_Management(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                IEnumerable<Encounter> c_(Encounter RadiationTreatmentManagement) {
                    CqlValueSet g_ = this.Cancer(context);
                    IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                    IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                    IEnumerable<object> k_ = context.Operators.Union<object>(h_ as IEnumerable<object>, j_ as IEnumerable<object>);

                    bool? l_(object CancerDx) {
                        CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CancerDx);
                        Period q_ = RadiationTreatmentManagement?.Period;
                        CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                        bool? s_ = context.Operators.Overlaps(p_, r_, "day");
                        return s_;
                    }

                    IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
                    Encounter n_(object CancerDx) => RadiationTreatmentManagement;
                    IEnumerable<Encounter> o_ = context.Operators.Select<object, Encounter>(m_, n_);
                    return o_;
                }

                IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

                bool? e_(Encounter RadiationTreatmentManagement) {
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    Period u_ = RadiationTreatmentManagement?.Period;
                    CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                    bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, "day");
                    Code<Encounter.EncounterStatus> x_ = RadiationTreatmentManagement?.StatusElement;
                    Encounter.EncounterStatus? y_ = x_?.Value;
                    Code<Encounter.EncounterStatus> z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(y_);
                    bool? aa_ = context.Operators.Equal(z_, "finished");
                    bool? ab_ = context.Operators.And(w_, aa_);
                    return ab_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                return f_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Initial_Population_2_Cached = new();

    [CqlExpressionDefinition("Initial Population 2")]
    public IEnumerable<Encounter> Initial_Population_2(CqlContext context) =>
        _Initial_Population_2_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);
                return a_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Denominator_2_Cached = new();

    [CqlExpressionDefinition("Denominator 2")]
    public IEnumerable<Encounter> Denominator_2(CqlContext context) =>
        _Denominator_2_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Initial_Population_2(context);
                return a_;
            });


    private readonly Cached<IEnumerable<Observation>> _Standard_Pain_Assessment_with_Result_Cached = new();

    [CqlExpressionDefinition("Standard Pain Assessment with Result")]
    public IEnumerable<Observation> Standard_Pain_Assessment_with_Result(CqlContext context) =>
        _Standard_Pain_Assessment_with_Result_Cached.GetOrReplace(
            context,
            () => {
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
            });


    private readonly Cached<IEnumerable<Encounter>> _Numerator_1_Cached = new();

    [CqlExpressionDefinition("Numerator 1")]
    public IEnumerable<Encounter> Numerator_1(CqlContext context) =>
        _Numerator_1_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Face_to_Face_or_Telehealth_Encounter_with_Ongoing_Chemotherapy(context);

                IEnumerable<Encounter> b_(Encounter FaceToFaceOrTelehealthEncounterWithChemo) {
                    IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);

                    bool? e_(Observation PainAssessed) {
                        Period i_ = FaceToFaceOrTelehealthEncounterWithChemo?.Period;
                        CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                        DataType k_ = PainAssessed?.Effective;
                        object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                        CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                        bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, "day");
                        return n_;
                    }

                    IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
                    Encounter g_(Observation PainAssessed) => FaceToFaceOrTelehealthEncounterWithChemo;
                    IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Numerator_2_Cached = new();

    [CqlExpressionDefinition("Numerator 2")]
    public IEnumerable<Encounter> Numerator_2(CqlContext context) =>
        _Numerator_2_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Encounter> a_ = this.Radiation_Treatment_Management_During_Measurement_Period_with_Cancer_Diagnosis(context);

                IEnumerable<Encounter> b_(Encounter RadiationManagementEncounter) {
                    IEnumerable<Observation> d_ = this.Standard_Pain_Assessment_with_Result(context);

                    bool? e_(Observation PainAssessed) {

                        bool? i_() {

                            bool j_() {
                                List<CodeableConcept> k_ = RadiationManagementEncounter?.Type;

                                CqlConcept l_(CodeableConcept @this) {
                                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                                    return q_;
                                }

                                IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);

                                bool? n_(CqlConcept RadiationManagement) {
                                    CqlCode r_ = this.Radiation_treatment_management__5_treatments(context);
                                    CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                                    bool? t_ = context.Operators.Equivalent(RadiationManagement, s_);
                                    return t_;
                                }

                                IEnumerable<CqlConcept> o_ = context.Operators.Where<CqlConcept>(m_, n_);
                                bool? p_ = context.Operators.Exists<CqlConcept>(o_);
                                return p_ ?? false;
                            }

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
                            };
                        }

                        return i_();
                    }

                    IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
                    Encounter g_(Observation PainAssessed) => RadiationManagementEncounter;
                    IEnumerable<Encounter> h_ = context.Operators.Select<Observation, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private readonly Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private readonly Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private readonly Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private readonly Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    #endregion Functions and Expressions

    private CMS157FHIRPainIntensityQuantified_1_0_000() {}

    public static CMS157FHIRPainIntensityQuantified_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS157FHIRPainIntensityQuantified";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_HUZMaBjXYCAiGTiLLUTReObKb = new(
       [typeof(Encounter), typeof(Procedure), typeof(Procedure), typeof(object)],
       ["FaceToFaceOrTelehealthEncounter", "ChemoBeforeEncounter", "ChemoAfterEncounter", "CancerDx"]);

    #endregion CqlTupleMetadata Properties

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

}
