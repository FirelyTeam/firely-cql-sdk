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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.4.0")]
[CqlLibrary("CumulativeMedicationDurationFHIR4", "1.0.000")]
public partial class CumulativeMedicationDurationFHIR4_1_0_000 : ILibrary, ISingleton<CumulativeMedicationDurationFHIR4_1_0_000>
{
    #region Codes (26)

    [CqlCodeDefinition("AC", codeId: "AC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode AC(CqlContext _) => _AC;
    private static readonly CqlCode _AC = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACD", codeId: "ACD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACD(CqlContext _) => _ACD;
    private static readonly CqlCode _ACD = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACM", codeId: "ACM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACM(CqlContext _) => _ACM;
    private static readonly CqlCode _ACM = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("ACV", codeId: "ACV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode ACV(CqlContext _) => _ACV;
    private static readonly CqlCode _ACV = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("AFT", codeId: "AFT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT(CqlContext _) => _AFT;
    private static readonly CqlCode _AFT = new CqlCode("AFT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.early", codeId: "AFT.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_early(CqlContext _) => _AFT_early;
    private static readonly CqlCode _AFT_early = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("AFT.late", codeId: "AFT.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode AFT_late(CqlContext _) => _AFT_late;
    private static readonly CqlCode _AFT_late = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("C", codeId: "C", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode C(CqlContext _) => _C;
    private static readonly CqlCode _C = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CD", codeId: "CD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CD(CqlContext _) => _CD;
    private static readonly CqlCode _CD = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CM", codeId: "CM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CM(CqlContext _) => _CM;
    private static readonly CqlCode _CM = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("CV", codeId: "CV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode CV(CqlContext _) => _CV;
    private static readonly CqlCode _CV = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("EVE", codeId: "EVE", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE(CqlContext _) => _EVE;
    private static readonly CqlCode _EVE = new CqlCode("EVE", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.early", codeId: "EVE.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_early(CqlContext _) => _EVE_early;
    private static readonly CqlCode _EVE_early = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("EVE.late", codeId: "EVE.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode EVE_late(CqlContext _) => _EVE_late;
    private static readonly CqlCode _EVE_late = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("HS", codeId: "HS", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode HS(CqlContext _) => _HS;
    private static readonly CqlCode _HS = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("MORN", codeId: "MORN", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN(CqlContext _) => _MORN;
    private static readonly CqlCode _MORN = new CqlCode("MORN", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.early", codeId: "MORN.early", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_early(CqlContext _) => _MORN_early;
    private static readonly CqlCode _MORN_early = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("MORN.late", codeId: "MORN.late", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode MORN_late(CqlContext _) => _MORN_late;
    private static readonly CqlCode _MORN_late = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NIGHT", codeId: "NIGHT", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NIGHT(CqlContext _) => _NIGHT;
    private static readonly CqlCode _NIGHT = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("NOON", codeId: "NOON", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode NOON(CqlContext _) => _NOON;
    private static readonly CqlCode _NOON = new CqlCode("NOON", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("PC", codeId: "PC", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PC(CqlContext _) => _PC;
    private static readonly CqlCode _PC = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCD", codeId: "PCD", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCD(CqlContext _) => _PCD;
    private static readonly CqlCode _PCD = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCM", codeId: "PCM", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCM(CqlContext _) => _PCM;
    private static readonly CqlCode _PCM = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PCV", codeId: "PCV", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode PCV(CqlContext _) => _PCV;
    private static readonly CqlCode _PCV = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    [CqlCodeDefinition("PHS", codeId: "PHS", codeSystem: "http://hl7.org/fhir/event-timing")]
    public CqlCode PHS(CqlContext _) => _PHS;
    private static readonly CqlCode _PHS = new CqlCode("PHS", "http://hl7.org/fhir/event-timing");

    [CqlCodeDefinition("WAKE", codeId: "WAKE", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent")]
    public CqlCode WAKE(CqlContext _) => _WAKE;
    private static readonly CqlCode _WAKE = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("V3TimingEvent", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", codeSystemVersion: null)]
    public CqlCodeSystem V3TimingEvent(CqlContext _) => _V3TimingEvent;
    private static readonly CqlCodeSystem _V3TimingEvent =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, [
          _AC,
          _ACD,
          _ACM,
          _ACV,
          _C,
          _CD,
          _CM,
          _CV,
          _HS,
          _PC,
          _PCD,
          _PCM,
          _PCV,
          _WAKE]);

    [CqlCodeSystemDefinition("EventTiming", codeSystemId: "http://hl7.org/fhir/event-timing", codeSystemVersion: null)]
    public CqlCodeSystem EventTiming(CqlContext _) => _EventTiming;
    private static readonly CqlCodeSystem _EventTiming =
      new CqlCodeSystem("http://hl7.org/fhir/event-timing", null, [
          _AFT,
          _AFT_early,
          _AFT_late,
          _EVE,
          _EVE_early,
          _EVE_late,
          _MORN,
          _MORN_early,
          _MORN_late,
          _NIGHT,
          _NOON,
          _PHS]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_ErrorLevel, ErrorLevel_Compute);

    private const long _cacheIndex_ErrorLevel = -3474294828027834309L;

    private string ErrorLevel_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");
        return (string)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (11)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 489454038755907576L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {

        decimal? a_() {

            bool b_() {
                string w_ = period?.unit;
                bool? x_ = context.Operators.Equal(w_, "h");
                return x_ ?? false;
            }


            bool c_() {
                string y_ = period?.unit;
                bool? z_ = context.Operators.Equal(y_, "min");
                return z_ ?? false;
            }


            bool d_() {
                string aa_ = period?.unit;
                bool? ab_ = context.Operators.Equal(aa_, "s");
                return ab_ ?? false;
            }


            bool e_() {
                string ac_ = period?.unit;
                bool? ad_ = context.Operators.Equal(ac_, "d");
                return ad_ ?? false;
            }


            bool f_() {
                string ae_ = period?.unit;
                bool? af_ = context.Operators.Equal(ae_, "wk");
                return af_ ?? false;
            }


            bool g_() {
                string ag_ = period?.unit;
                bool? ah_ = context.Operators.Equal(ag_, "mo");
                return ah_ ?? false;
            }


            bool h_() {
                string ai_ = period?.unit;
                bool? aj_ = context.Operators.Equal(ai_, "a");
                return aj_ ?? false;
            }


            bool i_() {
                string ak_ = period?.unit;
                bool? al_ = context.Operators.Equal(ak_, "hour");
                return al_ ?? false;
            }


            bool j_() {
                string am_ = period?.unit;
                bool? an_ = context.Operators.Equal(am_, "minute");
                return an_ ?? false;
            }


            bool k_() {
                string ao_ = period?.unit;
                bool? ap_ = context.Operators.Equal(ao_, "second");
                return ap_ ?? false;
            }


            bool l_() {
                string aq_ = period?.unit;
                bool? ar_ = context.Operators.Equal(aq_, "day");
                return ar_ ?? false;
            }


            bool m_() {
                string as_ = period?.unit;
                bool? at_ = context.Operators.Equal(as_, "week");
                return at_ ?? false;
            }


            bool n_() {
                string au_ = period?.unit;
                bool? av_ = context.Operators.Equal(au_, "month");
                return av_ ?? false;
            }


            bool o_() {
                string aw_ = period?.unit;
                bool? ax_ = context.Operators.Equal(aw_, "year");
                return ax_ ?? false;
            }


            bool p_() {
                string ay_ = period?.unit;
                bool? az_ = context.Operators.Equal(ay_, "hours");
                return az_ ?? false;
            }


            bool q_() {
                string ba_ = period?.unit;
                bool? bb_ = context.Operators.Equal(ba_, "minutes");
                return bb_ ?? false;
            }


            bool r_() {
                string bc_ = period?.unit;
                bool? bd_ = context.Operators.Equal(bc_, "seconds");
                return bd_ ?? false;
            }


            bool s_() {
                string be_ = period?.unit;
                bool? bf_ = context.Operators.Equal(be_, "days");
                return bf_ ?? false;
            }


            bool t_() {
                string bg_ = period?.unit;
                bool? bh_ = context.Operators.Equal(bg_, "weeks");
                return bh_ ?? false;
            }


            bool u_() {
                string bi_ = period?.unit;
                bool? bj_ = context.Operators.Equal(bi_, "months");
                return bj_ ?? false;
            }


            bool v_() {
                string bk_ = period?.unit;
                bool? bl_ = context.Operators.Equal(bk_, "years");
                return bl_ ?? false;
            }

            if (b_())
            {
                decimal? bm_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bn_ = period?.value;
                decimal? bo_ = context.Operators.Divide(24.0m, bn_);
                decimal? bp_ = context.Operators.Multiply(bm_, bo_);
                return bp_;
            }
            else if (c_())
            {
                decimal? bq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? br_ = period?.value;
                decimal? bs_ = context.Operators.Divide(24.0m, br_);
                decimal? bt_ = context.Operators.Multiply(bq_, bs_);
                decimal? bu_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? bv_ = context.Operators.Multiply(bt_, bu_);
                return bv_;
            }
            else if (d_())
            {
                decimal? bw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? bx_ = period?.value;
                decimal? by_ = context.Operators.Divide(24.0m, bx_);
                decimal? bz_ = context.Operators.Multiply(bw_, by_);
                decimal? ca_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? cb_ = context.Operators.Multiply(bz_, ca_);
                decimal? cc_ = context.Operators.Multiply(cb_, ca_);
                return cc_;
            }
            else if (e_())
            {
                decimal? cd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ce_ = period?.value;
                decimal? cf_ = context.Operators.Divide(24.0m, ce_);
                decimal? cg_ = context.Operators.Multiply(cd_, cf_);
                decimal? ch_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ci_ = context.Operators.Divide(cg_, ch_);
                return ci_;
            }
            else if (f_())
            {
                decimal? cj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ck_ = period?.value;
                decimal? cl_ = context.Operators.Divide(24.0m, ck_);
                decimal? cm_ = context.Operators.Multiply(cj_, cl_);
                int? cn_ = context.Operators.Multiply(24, 7);
                decimal? co_ = context.Operators.ConvertIntegerToDecimal(cn_);
                decimal? cp_ = context.Operators.Divide(cm_, co_);
                return cp_;
            }
            else if (g_())
            {
                decimal? cq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cr_ = period?.value;
                decimal? cs_ = context.Operators.Divide(24.0m, cr_);
                decimal? ct_ = context.Operators.Multiply(cq_, cs_);
                int? cu_ = context.Operators.Multiply(24, 30);
                decimal? cv_ = context.Operators.ConvertIntegerToDecimal(cu_);
                decimal? cw_ = context.Operators.Divide(ct_, cv_);
                return cw_;
            }
            else if (h_())
            {
                decimal? cx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cy_ = period?.value;
                decimal? cz_ = context.Operators.Divide(24.0m, cy_);
                decimal? da_ = context.Operators.Multiply(cx_, cz_);
                int? db_ = context.Operators.Multiply(24, 365);
                decimal? dc_ = context.Operators.ConvertIntegerToDecimal(db_);
                decimal? dd_ = context.Operators.Divide(da_, dc_);
                return dd_;
            }
            else if (i_())
            {
                decimal? de_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? df_ = period?.value;
                decimal? dg_ = context.Operators.Divide(24.0m, df_);
                decimal? dh_ = context.Operators.Multiply(de_, dg_);
                return dh_;
            }
            else if (j_())
            {
                decimal? di_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dj_ = period?.value;
                decimal? dk_ = context.Operators.Divide(24.0m, dj_);
                decimal? dl_ = context.Operators.Multiply(di_, dk_);
                decimal? dm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? dn_ = context.Operators.Multiply(dl_, dm_);
                return dn_;
            }
            else if (k_())
            {
                decimal? do_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dp_ = period?.value;
                decimal? dq_ = context.Operators.Divide(24.0m, dp_);
                decimal? dr_ = context.Operators.Multiply(do_, dq_);
                decimal? ds_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? dt_ = context.Operators.Multiply(dr_, ds_);
                decimal? du_ = context.Operators.Multiply(dt_, ds_);
                return du_;
            }
            else if (l_())
            {
                decimal? dv_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dw_ = period?.value;
                decimal? dx_ = context.Operators.Divide(24.0m, dw_);
                decimal? dy_ = context.Operators.Multiply(dv_, dx_);
                decimal? dz_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ea_ = context.Operators.Divide(dy_, dz_);
                return ea_;
            }
            else if (m_())
            {
                decimal? eb_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ec_ = period?.value;
                decimal? ed_ = context.Operators.Divide(24.0m, ec_);
                decimal? ee_ = context.Operators.Multiply(eb_, ed_);
                int? ef_ = context.Operators.Multiply(24, 7);
                decimal? eg_ = context.Operators.ConvertIntegerToDecimal(ef_);
                decimal? eh_ = context.Operators.Divide(ee_, eg_);
                return eh_;
            }
            else if (n_())
            {
                decimal? ei_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ej_ = period?.value;
                decimal? ek_ = context.Operators.Divide(24.0m, ej_);
                decimal? el_ = context.Operators.Multiply(ei_, ek_);
                int? em_ = context.Operators.Multiply(24, 30);
                decimal? en_ = context.Operators.ConvertIntegerToDecimal(em_);
                decimal? eo_ = context.Operators.Divide(el_, en_);
                return eo_;
            }
            else if (o_())
            {
                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? eq_ = period?.value;
                decimal? er_ = context.Operators.Divide(24.0m, eq_);
                decimal? es_ = context.Operators.Multiply(ep_, er_);
                int? et_ = context.Operators.Multiply(24, 365);
                decimal? eu_ = context.Operators.ConvertIntegerToDecimal(et_);
                decimal? ev_ = context.Operators.Divide(es_, eu_);
                return ev_;
            }
            else if (p_())
            {
                decimal? ew_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ex_ = period?.value;
                decimal? ey_ = context.Operators.Divide(24.0m, ex_);
                decimal? ez_ = context.Operators.Multiply(ew_, ey_);
                return ez_;
            }
            else if (q_())
            {
                decimal? fa_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fb_ = period?.value;
                decimal? fc_ = context.Operators.Divide(24.0m, fb_);
                decimal? fd_ = context.Operators.Multiply(fa_, fc_);
                decimal? fe_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? ff_ = context.Operators.Multiply(fd_, fe_);
                return ff_;
            }
            else if (r_())
            {
                decimal? fg_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fh_ = period?.value;
                decimal? fi_ = context.Operators.Divide(24.0m, fh_);
                decimal? fj_ = context.Operators.Multiply(fg_, fi_);
                decimal? fk_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fl_ = context.Operators.Multiply(fj_, fk_);
                decimal? fm_ = context.Operators.Multiply(fl_, fk_);
                return fm_;
            }
            else if (s_())
            {
                decimal? fn_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fo_ = period?.value;
                decimal? fp_ = context.Operators.Divide(24.0m, fo_);
                decimal? fq_ = context.Operators.Multiply(fn_, fp_);
                decimal? fr_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fs_ = context.Operators.Divide(fq_, fr_);
                return fs_;
            }
            else if (t_())
            {
                decimal? ft_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fu_ = period?.value;
                decimal? fv_ = context.Operators.Divide(24.0m, fu_);
                decimal? fw_ = context.Operators.Multiply(ft_, fv_);
                int? fx_ = context.Operators.Multiply(24, 7);
                decimal? fy_ = context.Operators.ConvertIntegerToDecimal(fx_);
                decimal? fz_ = context.Operators.Divide(fw_, fy_);
                return fz_;
            }
            else if (u_())
            {
                decimal? ga_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gb_ = period?.value;
                decimal? gc_ = context.Operators.Divide(24.0m, gb_);
                decimal? gd_ = context.Operators.Multiply(ga_, gc_);
                int? ge_ = context.Operators.Multiply(24, 30);
                decimal? gf_ = context.Operators.ConvertIntegerToDecimal(ge_);
                decimal? gg_ = context.Operators.Divide(gd_, gf_);
                return gg_;
            }
            else if (v_())
            {
                decimal? gh_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gi_ = period?.value;
                decimal? gj_ = context.Operators.Divide(24.0m, gi_);
                decimal? gk_ = context.Operators.Multiply(gh_, gj_);
                int? gl_ = context.Operators.Multiply(24, 365);
                decimal? gm_ = context.Operators.ConvertIntegerToDecimal(gl_);
                decimal? gn_ = context.Operators.Divide(gk_, gm_);
                return gn_;
            }
            else
            {
                string go_ = this.ErrorLevel(context);
                string gp_ = period?.unit;
                string gq_ = context.Operators.Concatenate("Unknown unit ", gp_ ?? "");
                object gr_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownUnit", go_, gq_);
                return gr_ as decimal?;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {

        decimal? a_() {

            bool b_() {
                CqlCode c_ = this.C(context);
                bool? d_ = context.Operators.Equal(frequency, c_);
                return d_ ?? false;
            }

            if (b_())
            {
                return 3.0m;
            }
            else
            {
                string e_ = this.ErrorLevel(context);
                string f_ = frequency?.code;
                string g_ = context.Operators.Concatenate("Unknown frequency code ", f_ ?? "");
                object h_ = context.Operators.Message<object>((object)null, "CMDLogic.ToDaily.UnknownFrequencyCode", e_, g_);
                return h_ as decimal?;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];

        CqlInterval<CqlDateTime> b_(MedicationRequest R) {

            CqlInterval<CqlDateTime> f_() {

                bool g_() {
                    List<Dosage> h_ = R?.DosageInstruction;
                    Dosage i_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
                    Timing j_ = i_?.Timing;
                    Timing.RepeatComponent k_ = j_?.Repeat;
                    DataType l_ = k_?.Bounds;
                    CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_ as Period);
                    CqlDateTime n_ = context.Operators.End(m_);
                    CqlDateTime o_ = context.Operators.MaxValue<CqlDateTime>();
                    bool? p_ = context.Operators.Equal(n_, o_);
                    bool? q_ = context.Operators.Or((bool?)(n_ is null), p_);
                    bool? r_ = context.Operators.Not(q_);
                    return r_ ?? false;
                }

                if (g_())
                {
                    List<Dosage> s_ = R?.DosageInstruction;
                    Dosage t_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)s_);
                    Timing u_ = t_?.Timing;
                    Timing.RepeatComponent v_ = u_?.Repeat;
                    DataType w_ = v_?.Bounds;
                    CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, w_ as Period);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    MedicationRequest.DispenseRequestComponent z_ = R?.DispenseRequest;
                    Period aa_ = z_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    FhirDateTime ad_ = R?.AuthoredOnElement;
                    CqlDateTime ae_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ad_);
                    CqlDateTime af_ = context.Operators.End(x_);
                    CqlInterval<CqlDateTime> ag_ = context.Operators.Interval((y_ ?? ac_) ?? ae_, af_, true, true);
                    return ag_;
                }
                else
                {
                    List<Dosage> ah_ = R?.DosageInstruction;
                    Dosage ai_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)ah_);
                    Timing aj_ = ai_?.Timing;
                    Timing.RepeatComponent ak_ = aj_?.Repeat;
                    DataType al_ = ak_?.Bounds;
                    CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, al_ as Period);
                    CqlDateTime an_ = context.Operators.Start(am_);
                    MedicationRequest.DispenseRequestComponent ao_ = R?.DispenseRequest;
                    Period ap_ = ao_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ap_);
                    CqlDateTime ar_ = context.Operators.Start(aq_);
                    FhirDateTime as_ = R?.AuthoredOnElement;
                    CqlDateTime at_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, as_);
                    Duration au_ = ao_?.ExpectedSupplyDuration;
                    CqlQuantity av_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, au_);
                    Quantity aw_ = ao_?.Quantity;
                    CqlQuantity ax_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aw_);
                    List<Dosage.DoseAndRateComponent> ay_ = ai_?.DoseAndRate;
                    Dosage.DoseAndRateComponent az_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ay_);
                    DataType ba_ = az_?.Dose;
                    CqlInterval<CqlQuantity> bb_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ba_ as Range);
                    CqlQuantity bc_ = context.Operators.End(bb_);
                    CqlQuantity bd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ba_ as Quantity);
                    PositiveInt be_ = ak_?.FrequencyMaxElement;
                    Integer bf_ = context.Operators.Convert<Integer>(be_);
                    PositiveInt bg_ = ak_?.FrequencyElement;
                    Integer bh_ = context.Operators.Convert<Integer>(bg_);
                    int? bi_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bf_ ?? bh_);
                    FhirDecimal bj_ = ak_?.PeriodElement;
                    decimal? bk_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bj_);
                    Code<Timing.UnitsOfTime> bl_ = ak_?.PeriodUnitElement;
                    Timing.UnitsOfTime? bm_ = bl_?.Value;
                    string bn_ = context.Operators.Convert<string>(bm_);
                    decimal? bo_ = this.ToDaily(context, bi_, new CqlQuantity(bk_, bn_));
                    List<Time> bp_ = ak_?.TimeOfDayElement;
                    int? bq_ = context.Operators.Count<Time>((IEnumerable<Time>)bp_);
                    decimal? br_ = context.Operators.ConvertIntegerToDecimal(bq_);
                    CqlQuantity bs_ = context.Operators.ConvertDecimalToQuantity((bo_ ?? br_) ?? 1.0m);
                    CqlQuantity bt_ = context.Operators.Multiply(bc_ ?? bd_, bs_);
                    CqlQuantity bu_ = context.Operators.Divide(ax_, bt_);
                    UnsignedInt bv_ = ao_?.NumberOfRepeatsAllowedElement;
                    Integer bw_ = context.Operators.Convert<Integer>(bv_);
                    int? bx_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bw_);
                    int? by_ = context.Operators.Add(1, bx_ ?? 0);
                    CqlQuantity bz_ = context.Operators.ConvertIntegerToQuantity(by_);
                    CqlQuantity ca_ = context.Operators.Multiply(av_ ?? bu_, bz_);
                    CqlDateTime cb_ = context.Operators.Add((an_ ?? ar_) ?? at_, ca_);
                    CqlInterval<CqlDateTime> cc_ = context.Operators.Interval((an_ ?? ar_) ?? at_, cb_, true, true);
                    return cc_;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(CqlContext context, MedicationDispense Dispense)
    {
        MedicationDispense[] a_ = [
            Dispense,
        ];

        CqlInterval<CqlDateTime> b_(MedicationDispense D) {
            FhirDateTime f_ = D?.WhenHandedOverElement;
            FhirDateTime g_ = D?.WhenPreparedElement;
            CqlDateTime h_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, f_ ?? g_);
            Quantity i_ = D?.DaysSupply;
            CqlQuantity j_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, i_);
            Quantity k_ = D?.Quantity;
            CqlQuantity l_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, k_);
            List<Dosage> m_ = D?.DosageInstruction;
            Dosage n_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)m_);
            List<Dosage.DoseAndRateComponent> o_ = n_?.DoseAndRate;
            Dosage.DoseAndRateComponent p_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)o_);
            DataType q_ = p_?.Dose;
            CqlInterval<CqlQuantity> r_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, q_ as Range);
            CqlQuantity s_ = context.Operators.End(r_);
            CqlQuantity t_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, q_ as Quantity);
            Timing u_ = n_?.Timing;
            Timing.RepeatComponent v_ = u_?.Repeat;
            PositiveInt w_ = v_?.FrequencyMaxElement;
            Integer x_ = context.Operators.Convert<Integer>(w_);
            PositiveInt y_ = v_?.FrequencyElement;
            Integer z_ = context.Operators.Convert<Integer>(y_);
            int? aa_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, x_ ?? z_);
            FhirDecimal ab_ = v_?.PeriodElement;
            decimal? ac_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, ab_);
            Code<Timing.UnitsOfTime> ad_ = v_?.PeriodUnitElement;
            Timing.UnitsOfTime? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            decimal? ag_ = this.ToDaily(context, aa_, new CqlQuantity(ac_, af_));
            List<Time> ah_ = v_?.TimeOfDayElement;
            int? ai_ = context.Operators.Count<Time>((IEnumerable<Time>)ah_);
            decimal? aj_ = context.Operators.ConvertIntegerToDecimal(ai_);
            CqlQuantity ak_ = context.Operators.ConvertDecimalToQuantity((ag_ ?? aj_) ?? 1.0m);
            CqlQuantity al_ = context.Operators.Multiply(s_ ?? t_, ak_);
            CqlQuantity am_ = context.Operators.Divide(l_, al_);
            CqlDateTime an_ = context.Operators.Add(h_, j_ ?? am_);
            CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(h_, an_, true, true);
            return ao_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlContext context, CqlConcept medication)
    {
        CqlQuantity a_ = context.Operators.Quantity(14m, "days");
        return a_;
    }


    [CqlFunctionDefinition("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(CqlContext context, MedicationAdministration Administration)
    {
        MedicationAdministration[] a_ = [
            Administration,
        ];

        CqlInterval<CqlDateTime> b_(MedicationAdministration M) {

            CqlInterval<CqlDateTime> f_() {

                bool g_() {
                    DataType h_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_ as Period);
                    CqlDateTime j_ = context.Operators.Start(i_);
                    bool? k_ = context.Operators.Not((bool?)(j_ is null));
                    DataType l_ = Administration?.Medication;
                    CqlConcept m_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, l_ as CodeableConcept);
                    CqlQuantity n_ = this.TherapeuticDuration(context, m_);
                    bool? o_ = context.Operators.Not((bool?)(n_ is null));
                    bool? p_ = context.Operators.And(k_, o_);
                    return p_ ?? false;
                }

                if (g_())
                {
                    DataType q_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, q_ as Period);
                    CqlDateTime s_ = context.Operators.Start(r_);
                    DataType t_ = Administration?.Medication;
                    CqlConcept u_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, t_ as CodeableConcept);
                    CqlQuantity v_ = this.TherapeuticDuration(context, u_);
                    CqlDateTime w_ = context.Operators.Add(s_, v_);
                    CqlInterval<CqlDateTime> x_ = context.Operators.Interval(s_, w_, true, true);
                    return x_;
                }
                else
                {
                    return null as CqlInterval<CqlDateTime>;
                }
            }

            return f_();
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = context.Operators.Collapse(Intervals, "day");

        int? b_(CqlInterval<CqlDateTime> X) {
            CqlDateTime e_ = context.Operators.Start(X);
            CqlDateTime f_ = context.Operators.End(X);
            int? g_ = context.Operators.DifferenceBetween(e_, f_, "day");
            return g_;
        }

        IEnumerable<int?> c_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(a_, b_);
        int? d_ = context.Operators.Sum(c_);
        return d_;
    }


    [CqlFunctionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {

        IEnumerable<CqlInterval<CqlDateTime>> a_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I) {
            CqlInterval<CqlDateTime>[] c_ = [
                I,
            ];

            CqlInterval<CqlDateTime> d_(CqlInterval<CqlDateTime> X) {
                CqlInterval<CqlDateTime> j_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlQuantity l_ = context.Operators.Quantity(1m, "day");
                CqlDateTime m_ = context.Operators.Add(k_, l_);
                CqlDateTime n_ = context.Operators.Start(X);
                CqlDateTime[] o_ = [
                    m_,
                    n_,
                ];
                CqlDateTime p_ = context.Operators.Max<CqlDateTime>((IEnumerable<CqlDateTime>)o_);
                CqlDateTime q_ = context.Operators.End(X);
                int? r_ = context.Operators.DurationBetween(n_, q_, "day");
                decimal? s_ = context.Operators.ConvertIntegerToDecimal(r_ ?? 0);
                CqlDateTime t_ = context.Operators.Add(p_, new CqlQuantity(s_, "day"));
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
                return u_;
            }

            IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)c_, d_);
            IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(e_);
            CqlInterval<CqlDateTime> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(f_);
            CqlInterval<CqlDateTime>[] h_ = [
                g_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, (IEnumerable<CqlInterval<CqlDateTime>>)h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> b_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDateTime>>);
        return b_;
    }


    [CqlFunctionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {

        CqlInterval<CqlDateTime> a_() {
            if (medication is MedicationRequest)
            {
                CqlInterval<CqlDateTime> b_ = this.MedicationRequestPeriod(context, medication as MedicationRequest);
                return b_;
            }
            else if (medication is MedicationDispense)
            {
                CqlInterval<CqlDateTime> c_ = this.MedicationDispensePeriod(context, medication as MedicationDispense);
                return c_;
            }
            else if (medication is MedicationAdministration)
            {
                CqlInterval<CqlDateTime> d_ = this.MedicationAdministrationPeriod(context, medication as MedicationAdministration);
                return d_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        }

        return a_();
    }


    [CqlFunctionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {

        bool? a_(object M) {
            bool n_ = M is MedicationRequest;
            return n_ as bool?;
        }

        IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);

        CqlInterval<CqlDateTime> c_(object M) {
            CqlInterval<CqlDateTime> o_ = this.MedicationPeriod(context, M);
            return o_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(b_, c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(d_);

        bool? f_(object M) {
            bool p_ = M is MedicationDispense;
            bool q_ = M is MedicationAdministration;
            bool? r_ = context.Operators.Or(p_ as bool?, q_ as bool?);
            return r_;
        }

        IEnumerable<object> g_ = context.Operators.Where<object>(Medications, f_);

        CqlInterval<CqlDateTime> h_(object M) {
            CqlInterval<CqlDateTime> s_ = this.MedicationPeriod(context, M);
            return s_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(g_, h_);
        IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(i_);
        IEnumerable<CqlInterval<CqlDateTime>> k_ = this.RolloutIntervals(context, j_);
        IEnumerable<CqlInterval<CqlDateTime>> l_ = context.Operators.Union<CqlInterval<CqlDateTime>>(e_, k_);
        int? m_ = this.CumulativeDuration(context, l_);
        return m_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CumulativeMedicationDurationFHIR4_1_0_000() {}

    public static CumulativeMedicationDurationFHIR4_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CumulativeMedicationDurationFHIR4";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

}
