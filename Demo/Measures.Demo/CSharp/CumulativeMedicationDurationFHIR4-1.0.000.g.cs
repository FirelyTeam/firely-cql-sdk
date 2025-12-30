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
[CqlLibrary("CumulativeMedicationDurationFHIR4", "1.0.000")]
public partial class CumulativeMedicationDurationFHIR4_1_0_000 : ILibrary, ISingleton<CumulativeMedicationDurationFHIR4_1_0_000>
{
    private CumulativeMedicationDurationFHIR4_1_0_000() {}

    public static CumulativeMedicationDurationFHIR4_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CumulativeMedicationDurationFHIR4";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheToken, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            if (cqlContext.CacheToken is null)
            {
                // No caching
                CacheToken = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheToken, cqlContext.CacheToken))
            {
                return CachedValue;
            }
            else
            {
                var value = factory();
                CachedValue = value;
                CacheToken = cqlContext.CacheToken;
                return value;
            }
        }
    }

    #endregion

    #region Codes

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

    #region CodeSystems

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

    #region Parameters

    private Cached<string> _ErrorLevel_Cached = new();

    [CqlParameterDefinition("ErrorLevel")]
    public string ErrorLevel(CqlContext context) =>
        _ErrorLevel_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");
                return (string)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, int? frequency, CqlQuantity period)
    {
        decimal? a_()
        {
            bool b_()
            {
                string w_ = period?.unit;
                bool? x_ = context.Operators.Equal(w_, "h");
                return x_ ?? false;
            };
            bool c_()
            {
                string y_ = period?.unit;
                bool? z_ = context.Operators.Equal(y_, "min");
                return z_ ?? false;
            };
            bool d_()
            {
                string aa_ = period?.unit;
                bool? ab_ = context.Operators.Equal(aa_, "s");
                return ab_ ?? false;
            };
            bool e_()
            {
                string ac_ = period?.unit;
                bool? ad_ = context.Operators.Equal(ac_, "d");
                return ad_ ?? false;
            };
            bool f_()
            {
                string ae_ = period?.unit;
                bool? af_ = context.Operators.Equal(ae_, "wk");
                return af_ ?? false;
            };
            bool g_()
            {
                string ag_ = period?.unit;
                bool? ah_ = context.Operators.Equal(ag_, "mo");
                return ah_ ?? false;
            };
            bool h_()
            {
                string ai_ = period?.unit;
                bool? aj_ = context.Operators.Equal(ai_, "a");
                return aj_ ?? false;
            };
            bool i_()
            {
                string ak_ = period?.unit;
                bool? al_ = context.Operators.Equal(ak_, "hour");
                return al_ ?? false;
            };
            bool j_()
            {
                string am_ = period?.unit;
                bool? an_ = context.Operators.Equal(am_, "minute");
                return an_ ?? false;
            };
            bool k_()
            {
                string ao_ = period?.unit;
                bool? ap_ = context.Operators.Equal(ao_, "second");
                return ap_ ?? false;
            };
            bool l_()
            {
                string aq_ = period?.unit;
                bool? ar_ = context.Operators.Equal(aq_, "day");
                return ar_ ?? false;
            };
            bool m_()
            {
                string as_ = period?.unit;
                bool? at_ = context.Operators.Equal(as_, "week");
                return at_ ?? false;
            };
            bool n_()
            {
                string au_ = period?.unit;
                bool? av_ = context.Operators.Equal(au_, "month");
                return av_ ?? false;
            };
            bool o_()
            {
                string aw_ = period?.unit;
                bool? ax_ = context.Operators.Equal(aw_, "year");
                return ax_ ?? false;
            };
            bool p_()
            {
                string ay_ = period?.unit;
                bool? az_ = context.Operators.Equal(ay_, "hours");
                return az_ ?? false;
            };
            bool q_()
            {
                string ba_ = period?.unit;
                bool? bb_ = context.Operators.Equal(ba_, "minutes");
                return bb_ ?? false;
            };
            bool r_()
            {
                string bc_ = period?.unit;
                bool? bd_ = context.Operators.Equal(bc_, "seconds");
                return bd_ ?? false;
            };
            bool s_()
            {
                string be_ = period?.unit;
                bool? bf_ = context.Operators.Equal(be_, "days");
                return bf_ ?? false;
            };
            bool t_()
            {
                string bg_ = period?.unit;
                bool? bh_ = context.Operators.Equal(bg_, "weeks");
                return bh_ ?? false;
            };
            bool u_()
            {
                string bi_ = period?.unit;
                bool? bj_ = context.Operators.Equal(bi_, "months");
                return bj_ ?? false;
            };
            bool v_()
            {
                string bk_ = period?.unit;
                bool? bl_ = context.Operators.Equal(bk_, "years");
                return bl_ ?? false;
            };
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
                decimal? cd_ = context.Operators.Multiply(cb_, ca_);
                return cd_;
            }
            else if (e_())
            {
                decimal? ce_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cf_ = period?.value;
                decimal? cg_ = context.Operators.Divide(24.0m, cf_);
                decimal? ch_ = context.Operators.Multiply(ce_, cg_);
                decimal? ci_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? cj_ = context.Operators.Divide(ch_, ci_);
                return cj_;
            }
            else if (f_())
            {
                decimal? ck_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cl_ = period?.value;
                decimal? cm_ = context.Operators.Divide(24.0m, cl_);
                decimal? cn_ = context.Operators.Multiply(ck_, cm_);
                int? co_ = context.Operators.Multiply(24, 7);
                decimal? cp_ = context.Operators.ConvertIntegerToDecimal(co_);
                decimal? cq_ = context.Operators.Divide(cn_, cp_);
                return cq_;
            }
            else if (g_())
            {
                decimal? cr_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cs_ = period?.value;
                decimal? ct_ = context.Operators.Divide(24.0m, cs_);
                decimal? cu_ = context.Operators.Multiply(cr_, ct_);
                int? cv_ = context.Operators.Multiply(24, 30);
                decimal? cw_ = context.Operators.ConvertIntegerToDecimal(cv_);
                decimal? cx_ = context.Operators.Divide(cu_, cw_);
                return cx_;
            }
            else if (h_())
            {
                decimal? cy_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? cz_ = period?.value;
                decimal? da_ = context.Operators.Divide(24.0m, cz_);
                decimal? db_ = context.Operators.Multiply(cy_, da_);
                int? dc_ = context.Operators.Multiply(24, 365);
                decimal? dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
                decimal? de_ = context.Operators.Divide(db_, dd_);
                return de_;
            }
            else if (i_())
            {
                decimal? df_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dg_ = period?.value;
                decimal? dh_ = context.Operators.Divide(24.0m, dg_);
                decimal? di_ = context.Operators.Multiply(df_, dh_);
                return di_;
            }
            else if (j_())
            {
                decimal? dj_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dk_ = period?.value;
                decimal? dl_ = context.Operators.Divide(24.0m, dk_);
                decimal? dm_ = context.Operators.Multiply(dj_, dl_);
                decimal? dn_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? do_ = context.Operators.Multiply(dm_, dn_);
                return do_;
            }
            else if (k_())
            {
                decimal? dp_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dq_ = period?.value;
                decimal? dr_ = context.Operators.Divide(24.0m, dq_);
                decimal? ds_ = context.Operators.Multiply(dp_, dr_);
                decimal? dt_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? du_ = context.Operators.Multiply(ds_, dt_);
                decimal? dw_ = context.Operators.Multiply(du_, dt_);
                return dw_;
            }
            else if (l_())
            {
                decimal? dx_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? dy_ = period?.value;
                decimal? dz_ = context.Operators.Divide(24.0m, dy_);
                decimal? ea_ = context.Operators.Multiply(dx_, dz_);
                decimal? eb_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? ec_ = context.Operators.Divide(ea_, eb_);
                return ec_;
            }
            else if (m_())
            {
                decimal? ed_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ee_ = period?.value;
                decimal? ef_ = context.Operators.Divide(24.0m, ee_);
                decimal? eg_ = context.Operators.Multiply(ed_, ef_);
                int? eh_ = context.Operators.Multiply(24, 7);
                decimal? ei_ = context.Operators.ConvertIntegerToDecimal(eh_);
                decimal? ej_ = context.Operators.Divide(eg_, ei_);
                return ej_;
            }
            else if (n_())
            {
                decimal? ek_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? el_ = period?.value;
                decimal? em_ = context.Operators.Divide(24.0m, el_);
                decimal? en_ = context.Operators.Multiply(ek_, em_);
                int? eo_ = context.Operators.Multiply(24, 30);
                decimal? ep_ = context.Operators.ConvertIntegerToDecimal(eo_);
                decimal? eq_ = context.Operators.Divide(en_, ep_);
                return eq_;
            }
            else if (o_())
            {
                decimal? er_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? es_ = period?.value;
                decimal? et_ = context.Operators.Divide(24.0m, es_);
                decimal? eu_ = context.Operators.Multiply(er_, et_);
                int? ev_ = context.Operators.Multiply(24, 365);
                decimal? ew_ = context.Operators.ConvertIntegerToDecimal(ev_);
                decimal? ex_ = context.Operators.Divide(eu_, ew_);
                return ex_;
            }
            else if (p_())
            {
                decimal? ey_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ez_ = period?.value;
                decimal? fa_ = context.Operators.Divide(24.0m, ez_);
                decimal? fb_ = context.Operators.Multiply(ey_, fa_);
                return fb_;
            }
            else if (q_())
            {
                decimal? fc_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fd_ = period?.value;
                decimal? fe_ = context.Operators.Divide(24.0m, fd_);
                decimal? ff_ = context.Operators.Multiply(fc_, fe_);
                decimal? fg_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fh_ = context.Operators.Multiply(ff_, fg_);
                return fh_;
            }
            else if (r_())
            {
                decimal? fi_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fj_ = period?.value;
                decimal? fk_ = context.Operators.Divide(24.0m, fj_);
                decimal? fl_ = context.Operators.Multiply(fi_, fk_);
                decimal? fm_ = context.Operators.ConvertIntegerToDecimal(60);
                decimal? fn_ = context.Operators.Multiply(fl_, fm_);
                decimal? fp_ = context.Operators.Multiply(fn_, fm_);
                return fp_;
            }
            else if (s_())
            {
                decimal? fq_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fr_ = period?.value;
                decimal? fs_ = context.Operators.Divide(24.0m, fr_);
                decimal? ft_ = context.Operators.Multiply(fq_, fs_);
                decimal? fu_ = context.Operators.ConvertIntegerToDecimal(24);
                decimal? fv_ = context.Operators.Divide(ft_, fu_);
                return fv_;
            }
            else if (t_())
            {
                decimal? fw_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? fx_ = period?.value;
                decimal? fy_ = context.Operators.Divide(24.0m, fx_);
                decimal? fz_ = context.Operators.Multiply(fw_, fy_);
                int? ga_ = context.Operators.Multiply(24, 7);
                decimal? gb_ = context.Operators.ConvertIntegerToDecimal(ga_);
                decimal? gc_ = context.Operators.Divide(fz_, gb_);
                return gc_;
            }
            else if (u_())
            {
                decimal? gd_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? ge_ = period?.value;
                decimal? gf_ = context.Operators.Divide(24.0m, ge_);
                decimal? gg_ = context.Operators.Multiply(gd_, gf_);
                int? gh_ = context.Operators.Multiply(24, 30);
                decimal? gi_ = context.Operators.ConvertIntegerToDecimal(gh_);
                decimal? gj_ = context.Operators.Divide(gg_, gi_);
                return gj_;
            }
            else if (v_())
            {
                decimal? gk_ = context.Operators.ConvertIntegerToDecimal(frequency);
                decimal? gl_ = period?.value;
                decimal? gm_ = context.Operators.Divide(24.0m, gl_);
                decimal? gn_ = context.Operators.Multiply(gk_, gm_);
                int? go_ = context.Operators.Multiply(24, 365);
                decimal? gp_ = context.Operators.ConvertIntegerToDecimal(go_);
                decimal? gq_ = context.Operators.Divide(gn_, gp_);
                return gq_;
            }
            else
            {
                string gr_ = this.ErrorLevel(context);
                string gs_ = period?.unit;
                string gt_ = context.Operators.Concatenate("Unknown unit ", gs_ ?? "");
                object gu_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gr_, gt_);
                return gu_ as decimal?;
            }
        };
        return a_();
    }


    [CqlFunctionDefinition("ToDaily")]
    public decimal? ToDaily(CqlContext context, CqlCode frequency)
    {
        decimal? a_()
        {
            bool b_()
            {
                CqlCode c_ = this.C(context);
                bool? d_ = context.Operators.Equal(frequency, c_);
                return d_ ?? false;
            };
            if (b_())
            {
                return 3.0m;
            }
            else
            {
                string e_ = this.ErrorLevel(context);
                string f_ = frequency?.code;
                string g_ = context.Operators.Concatenate("Unknown frequency code ", f_ ?? "");
                object h_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", e_, g_);
                return h_ as decimal?;
            }
        };
        return a_();
    }


    [CqlFunctionDefinition("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(CqlContext context, MedicationRequest Request)
    {
        MedicationRequest[] a_ = [
            Request,
        ];
        CqlInterval<CqlDateTime> b_(MedicationRequest R)
        {
            CqlInterval<CqlDateTime> f_()
            {
                bool g_()
                {
                    List<Dosage> h_ = R?.DosageInstruction;
                    Dosage i_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
                    Timing j_ = i_?.Timing;
                    Timing.RepeatComponent k_ = j_?.Repeat;
                    DataType l_ = k_?.Bounds;
                    CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_ as Period);
                    CqlDateTime n_ = context.Operators.End(m_);
                    Dosage p_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)h_);
                    Timing q_ = p_?.Timing;
                    Timing.RepeatComponent r_ = q_?.Repeat;
                    DataType s_ = r_?.Bounds;
                    CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, s_ as Period);
                    CqlDateTime u_ = context.Operators.End(t_);
                    CqlDateTime v_ = context.Operators.MaxValue<CqlDateTime>();
                    bool? w_ = context.Operators.Equal(u_, v_);
                    bool? x_ = context.Operators.Or((bool?)(n_ is null), w_);
                    bool? y_ = context.Operators.Not(x_);
                    return y_ ?? false;
                };
                if (g_())
                {
                    List<Dosage> z_ = R?.DosageInstruction;
                    Dosage aa_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)z_);
                    Timing ab_ = aa_?.Timing;
                    Timing.RepeatComponent ac_ = ab_?.Repeat;
                    DataType ad_ = ac_?.Bounds;
                    CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ad_ as Period);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    MedicationRequest.DispenseRequestComponent ag_ = R?.DispenseRequest;
                    Period ah_ = ag_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ah_);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    FhirDateTime ak_ = R?.AuthoredOnElement;
                    CqlDateTime al_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, ak_);
                    Dosage an_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)z_);
                    Timing ao_ = an_?.Timing;
                    Timing.RepeatComponent ap_ = ao_?.Repeat;
                    DataType aq_ = ap_?.Bounds;
                    CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, aq_ as Period);
                    CqlDateTime as_ = context.Operators.End(ar_);
                    CqlInterval<CqlDateTime> at_ = context.Operators.Interval((af_ ?? aj_) ?? al_, as_, true, true);
                    return at_;
                }
                else
                {
                    List<Dosage> au_ = R?.DosageInstruction;
                    Dosage av_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    Timing aw_ = av_?.Timing;
                    Timing.RepeatComponent ax_ = aw_?.Repeat;
                    DataType ay_ = ax_?.Bounds;
                    CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ay_ as Period);
                    CqlDateTime ba_ = context.Operators.Start(az_);
                    MedicationRequest.DispenseRequestComponent bb_ = R?.DispenseRequest;
                    Period bc_ = bb_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bc_);
                    CqlDateTime be_ = context.Operators.Start(bd_);
                    FhirDateTime bf_ = R?.AuthoredOnElement;
                    CqlDateTime bg_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bf_);
                    Dosage bi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    Timing bj_ = bi_?.Timing;
                    Timing.RepeatComponent bk_ = bj_?.Repeat;
                    DataType bl_ = bk_?.Bounds;
                    CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bl_ as Period);
                    CqlDateTime bn_ = context.Operators.Start(bm_);
                    Period bp_ = bb_?.ValidityPeriod;
                    CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, bp_);
                    CqlDateTime br_ = context.Operators.Start(bq_);
                    CqlDateTime bt_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, bf_);
                    Duration bv_ = bb_?.ExpectedSupplyDuration;
                    CqlQuantity bw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bv_);
                    Quantity by_ = bb_?.Quantity;
                    CqlQuantity bz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, by_);
                    Dosage cb_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    List<Dosage.DoseAndRateComponent> cc_ = cb_?.DoseAndRate;
                    Dosage.DoseAndRateComponent cd_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cc_);
                    DataType ce_ = cd_?.Dose;
                    CqlInterval<CqlQuantity> cf_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ce_ as Range);
                    CqlQuantity cg_ = context.Operators.End(cf_);
                    Dosage ci_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    List<Dosage.DoseAndRateComponent> cj_ = ci_?.DoseAndRate;
                    Dosage.DoseAndRateComponent ck_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cj_);
                    DataType cl_ = ck_?.Dose;
                    CqlQuantity cm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, cl_ as Quantity);
                    Dosage co_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    Timing cp_ = co_?.Timing;
                    Timing.RepeatComponent cq_ = cp_?.Repeat;
                    PositiveInt cr_ = cq_?.FrequencyMaxElement;
                    Integer cs_ = context.Operators.Convert<Integer>(cr_);
                    Dosage cu_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    Timing cv_ = cu_?.Timing;
                    Timing.RepeatComponent cw_ = cv_?.Repeat;
                    PositiveInt cx_ = cw_?.FrequencyElement;
                    Integer cy_ = context.Operators.Convert<Integer>(cx_);
                    int? cz_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, cs_ ?? cy_);
                    Dosage db_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    Timing dc_ = db_?.Timing;
                    Timing.RepeatComponent dd_ = dc_?.Repeat;
                    FhirDecimal de_ = dd_?.PeriodElement;
                    decimal? df_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, de_);
                    Dosage dh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    Timing di_ = dh_?.Timing;
                    Timing.RepeatComponent dj_ = di_?.Repeat;
                    Code<Timing.UnitsOfTime> dk_ = dj_?.PeriodUnitElement;
                    Timing.UnitsOfTime? dl_ = dk_?.Value;
                    string dm_ = context.Operators.Convert<string>(dl_);
                    decimal? dn_ = this.ToDaily(context, cz_, new CqlQuantity(df_, dm_));
                    Dosage dp_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)au_);
                    Timing dq_ = dp_?.Timing;
                    Timing.RepeatComponent dr_ = dq_?.Repeat;
                    List<Time> ds_ = dr_?.TimeOfDayElement;
                    int? dt_ = context.Operators.Count<Time>((IEnumerable<Time>)ds_);
                    decimal? du_ = context.Operators.ConvertIntegerToDecimal(dt_);
                    CqlQuantity dv_ = context.Operators.ConvertDecimalToQuantity((dn_ ?? du_) ?? 1.0m);
                    CqlQuantity dw_ = context.Operators.Multiply(cg_ ?? cm_, dv_);
                    CqlQuantity dx_ = context.Operators.Divide(bz_, dw_);
                    UnsignedInt dz_ = bb_?.NumberOfRepeatsAllowedElement;
                    Integer ea_ = context.Operators.Convert<Integer>(dz_);
                    int? eb_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ea_);
                    int? ec_ = context.Operators.Add(1, eb_ ?? 0);
                    CqlQuantity ed_ = context.Operators.ConvertIntegerToQuantity(ec_);
                    CqlQuantity ee_ = context.Operators.Multiply(bw_ ?? dx_, ed_);
                    CqlDateTime ef_ = context.Operators.Add((bn_ ?? br_) ?? bt_, ee_);
                    CqlInterval<CqlDateTime> eg_ = context.Operators.Interval((ba_ ?? be_) ?? bg_, ef_, true, true);
                    return eg_;
                }
            };
            return f_();
        };
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
        CqlInterval<CqlDateTime> b_(MedicationDispense D)
        {
            FhirDateTime f_ = D?.WhenHandedOverElement;
            FhirDateTime g_ = D?.WhenPreparedElement;
            CqlDateTime h_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, f_ ?? g_);
            CqlDateTime k_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, f_ ?? g_);
            Quantity l_ = D?.DaysSupply;
            CqlQuantity m_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, l_);
            Quantity n_ = D?.Quantity;
            CqlQuantity o_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, n_);
            List<Dosage> p_ = D?.DosageInstruction;
            Dosage q_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)p_);
            List<Dosage.DoseAndRateComponent> r_ = q_?.DoseAndRate;
            Dosage.DoseAndRateComponent s_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)r_);
            DataType t_ = s_?.Dose;
            CqlInterval<CqlQuantity> u_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, t_ as Range);
            CqlQuantity v_ = context.Operators.End(u_);
            Dosage x_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)p_);
            List<Dosage.DoseAndRateComponent> y_ = x_?.DoseAndRate;
            Dosage.DoseAndRateComponent z_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)y_);
            DataType aa_ = z_?.Dose;
            CqlQuantity ab_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, aa_ as Quantity);
            Dosage ad_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)p_);
            Timing ae_ = ad_?.Timing;
            Timing.RepeatComponent af_ = ae_?.Repeat;
            PositiveInt ag_ = af_?.FrequencyMaxElement;
            Integer ah_ = context.Operators.Convert<Integer>(ag_);
            Dosage aj_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)p_);
            Timing ak_ = aj_?.Timing;
            Timing.RepeatComponent al_ = ak_?.Repeat;
            PositiveInt am_ = al_?.FrequencyElement;
            Integer an_ = context.Operators.Convert<Integer>(am_);
            int? ao_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ah_ ?? an_);
            Dosage aq_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)p_);
            Timing ar_ = aq_?.Timing;
            Timing.RepeatComponent as_ = ar_?.Repeat;
            FhirDecimal at_ = as_?.PeriodElement;
            decimal? au_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, at_);
            Dosage aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)p_);
            Timing ax_ = aw_?.Timing;
            Timing.RepeatComponent ay_ = ax_?.Repeat;
            Code<Timing.UnitsOfTime> az_ = ay_?.PeriodUnitElement;
            Timing.UnitsOfTime? ba_ = az_?.Value;
            string bb_ = context.Operators.Convert<string>(ba_);
            decimal? bc_ = this.ToDaily(context, ao_, new CqlQuantity(au_, bb_));
            Dosage be_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)p_);
            Timing bf_ = be_?.Timing;
            Timing.RepeatComponent bg_ = bf_?.Repeat;
            List<Time> bh_ = bg_?.TimeOfDayElement;
            int? bi_ = context.Operators.Count<Time>((IEnumerable<Time>)bh_);
            decimal? bj_ = context.Operators.ConvertIntegerToDecimal(bi_);
            CqlQuantity bk_ = context.Operators.ConvertDecimalToQuantity((bc_ ?? bj_) ?? 1.0m);
            CqlQuantity bl_ = context.Operators.Multiply(v_ ?? ab_, bk_);
            CqlQuantity bm_ = context.Operators.Divide(o_, bl_);
            CqlDateTime bn_ = context.Operators.Add(k_, m_ ?? bm_);
            CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(h_, bn_, true, true);
            return bo_;
        };
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
        CqlInterval<CqlDateTime> b_(MedicationAdministration M)
        {
            CqlInterval<CqlDateTime> f_()
            {
                bool g_()
                {
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
                };
                if (g_())
                {
                    DataType q_ = Administration?.Effective;
                    CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, q_ as Period);
                    CqlDateTime s_ = context.Operators.Start(r_);
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, q_ as Period);
                    CqlDateTime v_ = context.Operators.Start(u_);
                    DataType w_ = Administration?.Medication;
                    CqlConcept x_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, w_ as CodeableConcept);
                    CqlQuantity y_ = this.TherapeuticDuration(context, x_);
                    CqlDateTime z_ = context.Operators.Add(v_, y_);
                    CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(s_, z_, true, true);
                    return aa_;
                }
                else
                {
                    return null as CqlInterval<CqlDateTime>;
                }
            };
            return f_();
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("CumulativeDuration")]
    public int? CumulativeDuration(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = context.Operators.Collapse(Intervals, "day");
        int? b_(CqlInterval<CqlDateTime> X)
        {
            CqlDateTime e_ = context.Operators.Start(X);
            CqlDateTime f_ = context.Operators.End(X);
            int? g_ = context.Operators.DifferenceBetween(e_, f_, "day");
            return g_;
        };
        IEnumerable<int?> c_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(a_, b_);
        int? d_ = context.Operators.Sum(c_);
        return d_;
    }


    [CqlFunctionDefinition("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
        {
            CqlInterval<CqlDateTime>[] c_ = [
                I,
            ];
            CqlInterval<CqlDateTime> d_(CqlInterval<CqlDateTime> X)
            {
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
                CqlDateTime r_ = context.Operators.End(j_);
                CqlDateTime t_ = context.Operators.Add(r_, l_);
                CqlDateTime[] v_ = [
                    t_,
                    n_,
                ];
                CqlDateTime w_ = context.Operators.Max<CqlDateTime>((IEnumerable<CqlDateTime>)v_);
                CqlDateTime y_ = context.Operators.End(X);
                int? z_ = context.Operators.DurationBetween(n_, y_, "day");
                decimal? aa_ = context.Operators.ConvertIntegerToDecimal(z_ ?? 0);
                CqlDateTime ab_ = context.Operators.Add(w_, new CqlQuantity(aa_, "day"));
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(p_, ab_, true, true);
                return ac_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)c_, d_);
            IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(e_);
            CqlInterval<CqlDateTime> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(f_);
            CqlInterval<CqlDateTime>[] h_ = [
                g_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, (IEnumerable<CqlInterval<CqlDateTime>>)h_);
            return i_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> b_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, a_, null as IEnumerable<CqlInterval<CqlDateTime>>);
        return b_;
    }


    [CqlFunctionDefinition("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(CqlContext context, object medication)
    {
        CqlInterval<CqlDateTime> a_()
        {
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
        };
        return a_();
    }


    [CqlFunctionDefinition("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(CqlContext context, IEnumerable<object> Medications)
    {
        bool? a_(object M)
        {
            bool n_ = M is MedicationRequest;
            return n_ as bool?;
        };
        IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);
        CqlInterval<CqlDateTime> c_(object M)
        {
            CqlInterval<CqlDateTime> o_ = this.MedicationPeriod(context, M);
            return o_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(b_, c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(d_);
        bool? f_(object M)
        {
            bool p_ = M is MedicationDispense;
            bool q_ = M is MedicationAdministration;
            bool? r_ = context.Operators.Or(p_ as bool?, q_ as bool?);
            return r_;
        };
        IEnumerable<object> g_ = context.Operators.Where<object>(Medications, f_);
        CqlInterval<CqlDateTime> h_(object M)
        {
            CqlInterval<CqlDateTime> s_ = this.MedicationPeriod(context, M);
            return s_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(g_, h_);
        IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(i_);
        IEnumerable<CqlInterval<CqlDateTime>> k_ = this.RolloutIntervals(context, j_);
        IEnumerable<CqlInterval<CqlDateTime>> l_ = context.Operators.Union<CqlInterval<CqlDateTime>>(e_, k_);
        int? m_ = this.CumulativeDuration(context, l_);
        return m_;
    }


    #endregion Functions and Expressions

}
