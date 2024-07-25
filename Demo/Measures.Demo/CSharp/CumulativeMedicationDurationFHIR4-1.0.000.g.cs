using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("CumulativeMedicationDurationFHIR4", "1.0.000")]
public class CumulativeMedicationDurationFHIR4_1_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode> __AC;
    internal Lazy<CqlCode> __ACD;
    internal Lazy<CqlCode> __ACM;
    internal Lazy<CqlCode> __ACV;
    internal Lazy<CqlCode> __AFT;
    internal Lazy<CqlCode> __AFT_early;
    internal Lazy<CqlCode> __AFT_late;
    internal Lazy<CqlCode> __C;
    internal Lazy<CqlCode> __CD;
    internal Lazy<CqlCode> __CM;
    internal Lazy<CqlCode> __CV;
    internal Lazy<CqlCode> __EVE;
    internal Lazy<CqlCode> __EVE_early;
    internal Lazy<CqlCode> __EVE_late;
    internal Lazy<CqlCode> __HS;
    internal Lazy<CqlCode> __MORN;
    internal Lazy<CqlCode> __MORN_early;
    internal Lazy<CqlCode> __MORN_late;
    internal Lazy<CqlCode> __NIGHT;
    internal Lazy<CqlCode> __NOON;
    internal Lazy<CqlCode> __PC;
    internal Lazy<CqlCode> __PCD;
    internal Lazy<CqlCode> __PCM;
    internal Lazy<CqlCode> __PCV;
    internal Lazy<CqlCode> __PHS;
    internal Lazy<CqlCode> __WAKE;
    internal Lazy<CqlCode[]> __V3TimingEvent;
    internal Lazy<CqlCode[]> __EventTiming;
    internal Lazy<string> __ErrorLevel;
    internal Lazy<Patient> __Patient;

    #endregion
    public CumulativeMedicationDurationFHIR4_1_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __AC = new Lazy<CqlCode>(this.AC_Value);
        __ACD = new Lazy<CqlCode>(this.ACD_Value);
        __ACM = new Lazy<CqlCode>(this.ACM_Value);
        __ACV = new Lazy<CqlCode>(this.ACV_Value);
        __AFT = new Lazy<CqlCode>(this.AFT_Value);
        __AFT_early = new Lazy<CqlCode>(this.AFT_early_Value);
        __AFT_late = new Lazy<CqlCode>(this.AFT_late_Value);
        __C = new Lazy<CqlCode>(this.C_Value);
        __CD = new Lazy<CqlCode>(this.CD_Value);
        __CM = new Lazy<CqlCode>(this.CM_Value);
        __CV = new Lazy<CqlCode>(this.CV_Value);
        __EVE = new Lazy<CqlCode>(this.EVE_Value);
        __EVE_early = new Lazy<CqlCode>(this.EVE_early_Value);
        __EVE_late = new Lazy<CqlCode>(this.EVE_late_Value);
        __HS = new Lazy<CqlCode>(this.HS_Value);
        __MORN = new Lazy<CqlCode>(this.MORN_Value);
        __MORN_early = new Lazy<CqlCode>(this.MORN_early_Value);
        __MORN_late = new Lazy<CqlCode>(this.MORN_late_Value);
        __NIGHT = new Lazy<CqlCode>(this.NIGHT_Value);
        __NOON = new Lazy<CqlCode>(this.NOON_Value);
        __PC = new Lazy<CqlCode>(this.PC_Value);
        __PCD = new Lazy<CqlCode>(this.PCD_Value);
        __PCM = new Lazy<CqlCode>(this.PCM_Value);
        __PCV = new Lazy<CqlCode>(this.PCV_Value);
        __PHS = new Lazy<CqlCode>(this.PHS_Value);
        __WAKE = new Lazy<CqlCode>(this.WAKE_Value);
        __V3TimingEvent = new Lazy<CqlCode[]>(this.V3TimingEvent_Value);
        __EventTiming = new Lazy<CqlCode[]>(this.EventTiming_Value);
        __ErrorLevel = new Lazy<string>(this.ErrorLevel_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

	private CqlCode AC_Value() => 
		new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("AC")]
	public CqlCode AC() => 
		__AC.Value;

	private CqlCode ACD_Value() => 
		new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACD")]
	public CqlCode ACD() => 
		__ACD.Value;

	private CqlCode ACM_Value() => 
		new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACM")]
	public CqlCode ACM() => 
		__ACM.Value;

	private CqlCode ACV_Value() => 
		new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACV")]
	public CqlCode ACV() => 
		__ACV.Value;

	private CqlCode AFT_Value() => 
		new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT")]
	public CqlCode AFT() => 
		__AFT.Value;

	private CqlCode AFT_early_Value() => 
		new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT.early")]
	public CqlCode AFT_early() => 
		__AFT_early.Value;

	private CqlCode AFT_late_Value() => 
		new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT.late")]
	public CqlCode AFT_late() => 
		__AFT_late.Value;

	private CqlCode C_Value() => 
		new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("C")]
	public CqlCode C() => 
		__C.Value;

	private CqlCode CD_Value() => 
		new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CD")]
	public CqlCode CD() => 
		__CD.Value;

	private CqlCode CM_Value() => 
		new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CM")]
	public CqlCode CM() => 
		__CM.Value;

	private CqlCode CV_Value() => 
		new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CV")]
	public CqlCode CV() => 
		__CV.Value;

	private CqlCode EVE_Value() => 
		new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE")]
	public CqlCode EVE() => 
		__EVE.Value;

	private CqlCode EVE_early_Value() => 
		new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE.early")]
	public CqlCode EVE_early() => 
		__EVE_early.Value;

	private CqlCode EVE_late_Value() => 
		new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE.late")]
	public CqlCode EVE_late() => 
		__EVE_late.Value;

	private CqlCode HS_Value() => 
		new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("HS")]
	public CqlCode HS() => 
		__HS.Value;

	private CqlCode MORN_Value() => 
		new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN")]
	public CqlCode MORN() => 
		__MORN.Value;

	private CqlCode MORN_early_Value() => 
		new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN.early")]
	public CqlCode MORN_early() => 
		__MORN_early.Value;

	private CqlCode MORN_late_Value() => 
		new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN.late")]
	public CqlCode MORN_late() => 
		__MORN_late.Value;

	private CqlCode NIGHT_Value() => 
		new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NIGHT")]
	public CqlCode NIGHT() => 
		__NIGHT.Value;

	private CqlCode NOON_Value() => 
		new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NOON")]
	public CqlCode NOON() => 
		__NOON.Value;

	private CqlCode PC_Value() => 
		new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PC")]
	public CqlCode PC() => 
		__PC.Value;

	private CqlCode PCD_Value() => 
		new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCD")]
	public CqlCode PCD() => 
		__PCD.Value;

	private CqlCode PCM_Value() => 
		new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCM")]
	public CqlCode PCM() => 
		__PCM.Value;

	private CqlCode PCV_Value() => 
		new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCV")]
	public CqlCode PCV() => 
		__PCV.Value;

	private CqlCode PHS_Value() => 
		new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("PHS")]
	public CqlCode PHS() => 
		__PHS.Value;

	private CqlCode WAKE_Value() => 
		new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("WAKE")]
	public CqlCode WAKE() => 
		__WAKE.Value;

	private CqlCode[] V3TimingEvent_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
		};

		return a_;
	}

    [CqlDeclaration("V3TimingEvent")]
	public CqlCode[] V3TimingEvent() => 
		__V3TimingEvent.Value;

	private CqlCode[] EventTiming_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null),
		};

		return a_;
	}

    [CqlDeclaration("EventTiming")]
	public CqlCode[] EventTiming() => 
		__EventTiming.Value;

	private string ErrorLevel_Value()
	{
		var a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

		return (string)a_;
	}

    [CqlDeclaration("ErrorLevel")]
	public string ErrorLevel() => 
		__ErrorLevel.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("ToDaily")]
	public decimal? ToDaily(int? frequency, CqlQuantity period)
	{
		decimal? a_()
		{
			bool b_()
			{
				var w_ = period?.unit;
				var x_ = context.Operators.Equal(w_, "h");

				return (x_ ?? false);
			};
			bool c_()
			{
				var y_ = period?.unit;
				var z_ = context.Operators.Equal(y_, "min");

				return (z_ ?? false);
			};
			bool d_()
			{
				var aa_ = period?.unit;
				var ab_ = context.Operators.Equal(aa_, "s");

				return (ab_ ?? false);
			};
			bool e_()
			{
				var ac_ = period?.unit;
				var ad_ = context.Operators.Equal(ac_, "d");

				return (ad_ ?? false);
			};
			bool f_()
			{
				var ae_ = period?.unit;
				var af_ = context.Operators.Equal(ae_, "wk");

				return (af_ ?? false);
			};
			bool g_()
			{
				var ag_ = period?.unit;
				var ah_ = context.Operators.Equal(ag_, "mo");

				return (ah_ ?? false);
			};
			bool h_()
			{
				var ai_ = period?.unit;
				var aj_ = context.Operators.Equal(ai_, "a");

				return (aj_ ?? false);
			};
			bool i_()
			{
				var ak_ = period?.unit;
				var al_ = context.Operators.Equal(ak_, "hour");

				return (al_ ?? false);
			};
			bool j_()
			{
				var am_ = period?.unit;
				var an_ = context.Operators.Equal(am_, "minute");

				return (an_ ?? false);
			};
			bool k_()
			{
				var ao_ = period?.unit;
				var ap_ = context.Operators.Equal(ao_, "second");

				return (ap_ ?? false);
			};
			bool l_()
			{
				var aq_ = period?.unit;
				var ar_ = context.Operators.Equal(aq_, "day");

				return (ar_ ?? false);
			};
			bool m_()
			{
				var as_ = period?.unit;
				var at_ = context.Operators.Equal(as_, "week");

				return (at_ ?? false);
			};
			bool n_()
			{
				var au_ = period?.unit;
				var av_ = context.Operators.Equal(au_, "month");

				return (av_ ?? false);
			};
			bool o_()
			{
				var aw_ = period?.unit;
				var ax_ = context.Operators.Equal(aw_, "year");

				return (ax_ ?? false);
			};
			bool p_()
			{
				var ay_ = period?.unit;
				var az_ = context.Operators.Equal(ay_, "hours");

				return (az_ ?? false);
			};
			bool q_()
			{
				var ba_ = period?.unit;
				var bb_ = context.Operators.Equal(ba_, "minutes");

				return (bb_ ?? false);
			};
			bool r_()
			{
				var bc_ = period?.unit;
				var bd_ = context.Operators.Equal(bc_, "seconds");

				return (bd_ ?? false);
			};
			bool s_()
			{
				var be_ = period?.unit;
				var bf_ = context.Operators.Equal(be_, "days");

				return (bf_ ?? false);
			};
			bool t_()
			{
				var bg_ = period?.unit;
				var bh_ = context.Operators.Equal(bg_, "weeks");

				return (bh_ ?? false);
			};
			bool u_()
			{
				var bi_ = period?.unit;
				var bj_ = context.Operators.Equal(bi_, "months");

				return (bj_ ?? false);
			};
			bool v_()
			{
				var bk_ = period?.unit;
				var bl_ = context.Operators.Equal(bk_, "years");

				return (bl_ ?? false);
			};
			if (b_())
			{
				var bm_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bn_ = period?.value;
				var bo_ = context.Operators.Divide(24.0m, bn_);
				var bp_ = context.Operators.Multiply(bm_, bo_);

				return bp_;
			}
			else if (c_())
			{
				var bq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var br_ = period?.value;
				var bs_ = context.Operators.Divide(24.0m, br_);
				var bt_ = context.Operators.Multiply(bq_, bs_);
				var bu_ = context.Operators.ConvertIntegerToDecimal(60);
				var bv_ = context.Operators.Multiply(bt_, bu_);

				return bv_;
			}
			else if (d_())
			{
				var bw_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bx_ = period?.value;
				var by_ = context.Operators.Divide(24.0m, bx_);
				var bz_ = context.Operators.Multiply(bw_, by_);
				var ca_ = context.Operators.ConvertIntegerToDecimal(60);
				var cb_ = context.Operators.Multiply(bz_, ca_);
				var cd_ = context.Operators.Multiply(cb_, ca_);

				return cd_;
			}
			else if (e_())
			{
				var ce_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cf_ = period?.value;
				var cg_ = context.Operators.Divide(24.0m, cf_);
				var ch_ = context.Operators.Multiply(ce_, cg_);
				var ci_ = context.Operators.ConvertIntegerToDecimal(24);
				var cj_ = context.Operators.Divide(ch_, ci_);

				return cj_;
			}
			else if (f_())
			{
				var ck_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cl_ = period?.value;
				var cm_ = context.Operators.Divide(24.0m, cl_);
				var cn_ = context.Operators.Multiply(ck_, cm_);
				var co_ = context.Operators.Multiply(24, 7);
				var cp_ = context.Operators.ConvertIntegerToDecimal(co_);
				var cq_ = context.Operators.Divide(cn_, cp_);

				return cq_;
			}
			else if (g_())
			{
				var cr_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cs_ = period?.value;
				var ct_ = context.Operators.Divide(24.0m, cs_);
				var cu_ = context.Operators.Multiply(cr_, ct_);
				var cv_ = context.Operators.Multiply(24, 30);
				var cw_ = context.Operators.ConvertIntegerToDecimal(cv_);
				var cx_ = context.Operators.Divide(cu_, cw_);

				return cx_;
			}
			else if (h_())
			{
				var cy_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cz_ = period?.value;
				var da_ = context.Operators.Divide(24.0m, cz_);
				var db_ = context.Operators.Multiply(cy_, da_);
				var dc_ = context.Operators.Multiply(24, 365);
				var dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
				var de_ = context.Operators.Divide(db_, dd_);

				return de_;
			}
			else if (i_())
			{
				var df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dg_ = period?.value;
				var dh_ = context.Operators.Divide(24.0m, dg_);
				var di_ = context.Operators.Multiply(df_, dh_);

				return di_;
			}
			else if (j_())
			{
				var dj_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dk_ = period?.value;
				var dl_ = context.Operators.Divide(24.0m, dk_);
				var dm_ = context.Operators.Multiply(dj_, dl_);
				var dn_ = context.Operators.ConvertIntegerToDecimal(60);
				var do_ = context.Operators.Multiply(dm_, dn_);

				return do_;
			}
			else if (k_())
			{
				var dp_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dq_ = period?.value;
				var dr_ = context.Operators.Divide(24.0m, dq_);
				var ds_ = context.Operators.Multiply(dp_, dr_);
				var dt_ = context.Operators.ConvertIntegerToDecimal(60);
				var du_ = context.Operators.Multiply(ds_, dt_);
				var dw_ = context.Operators.Multiply(du_, dt_);

				return dw_;
			}
			else if (l_())
			{
				var dx_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dy_ = period?.value;
				var dz_ = context.Operators.Divide(24.0m, dy_);
				var ea_ = context.Operators.Multiply(dx_, dz_);
				var eb_ = context.Operators.ConvertIntegerToDecimal(24);
				var ec_ = context.Operators.Divide(ea_, eb_);

				return ec_;
			}
			else if (m_())
			{
				var ed_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ee_ = period?.value;
				var ef_ = context.Operators.Divide(24.0m, ee_);
				var eg_ = context.Operators.Multiply(ed_, ef_);
				var eh_ = context.Operators.Multiply(24, 7);
				var ei_ = context.Operators.ConvertIntegerToDecimal(eh_);
				var ej_ = context.Operators.Divide(eg_, ei_);

				return ej_;
			}
			else if (n_())
			{
				var ek_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var el_ = period?.value;
				var em_ = context.Operators.Divide(24.0m, el_);
				var en_ = context.Operators.Multiply(ek_, em_);
				var eo_ = context.Operators.Multiply(24, 30);
				var ep_ = context.Operators.ConvertIntegerToDecimal(eo_);
				var eq_ = context.Operators.Divide(en_, ep_);

				return eq_;
			}
			else if (o_())
			{
				var er_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var es_ = period?.value;
				var et_ = context.Operators.Divide(24.0m, es_);
				var eu_ = context.Operators.Multiply(er_, et_);
				var ev_ = context.Operators.Multiply(24, 365);
				var ew_ = context.Operators.ConvertIntegerToDecimal(ev_);
				var ex_ = context.Operators.Divide(eu_, ew_);

				return ex_;
			}
			else if (p_())
			{
				var ey_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ez_ = period?.value;
				var fa_ = context.Operators.Divide(24.0m, ez_);
				var fb_ = context.Operators.Multiply(ey_, fa_);

				return fb_;
			}
			else if (q_())
			{
				var fc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fd_ = period?.value;
				var fe_ = context.Operators.Divide(24.0m, fd_);
				var ff_ = context.Operators.Multiply(fc_, fe_);
				var fg_ = context.Operators.ConvertIntegerToDecimal(60);
				var fh_ = context.Operators.Multiply(ff_, fg_);

				return fh_;
			}
			else if (r_())
			{
				var fi_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fj_ = period?.value;
				var fk_ = context.Operators.Divide(24.0m, fj_);
				var fl_ = context.Operators.Multiply(fi_, fk_);
				var fm_ = context.Operators.ConvertIntegerToDecimal(60);
				var fn_ = context.Operators.Multiply(fl_, fm_);
				var fp_ = context.Operators.Multiply(fn_, fm_);

				return fp_;
			}
			else if (s_())
			{
				var fq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fr_ = period?.value;
				var fs_ = context.Operators.Divide(24.0m, fr_);
				var ft_ = context.Operators.Multiply(fq_, fs_);
				var fu_ = context.Operators.ConvertIntegerToDecimal(24);
				var fv_ = context.Operators.Divide(ft_, fu_);

				return fv_;
			}
			else if (t_())
			{
				var fw_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var fx_ = period?.value;
				var fy_ = context.Operators.Divide(24.0m, fx_);
				var fz_ = context.Operators.Multiply(fw_, fy_);
				var ga_ = context.Operators.Multiply(24, 7);
				var gb_ = context.Operators.ConvertIntegerToDecimal(ga_);
				var gc_ = context.Operators.Divide(fz_, gb_);

				return gc_;
			}
			else if (u_())
			{
				var gd_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ge_ = period?.value;
				var gf_ = context.Operators.Divide(24.0m, ge_);
				var gg_ = context.Operators.Multiply(gd_, gf_);
				var gh_ = context.Operators.Multiply(24, 30);
				var gi_ = context.Operators.ConvertIntegerToDecimal(gh_);
				var gj_ = context.Operators.Divide(gg_, gi_);

				return gj_;
			}
			else if (v_())
			{
				var gk_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var gl_ = period?.value;
				var gm_ = context.Operators.Divide(24.0m, gl_);
				var gn_ = context.Operators.Multiply(gk_, gm_);
				var go_ = context.Operators.Multiply(24, 365);
				var gp_ = context.Operators.ConvertIntegerToDecimal(go_);
				var gq_ = context.Operators.Divide(gn_, gp_);

				return gq_;
			}
			else
			{
				var gr_ = this.ErrorLevel();
				var gs_ = context.Operators.Concatenate("Unknown unit ", (period?.unit ?? ""));
				var gt_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", gr_, gs_);

				return (gt_ as decimal?);
			}
		};

		return a_();
	}

    [CqlDeclaration("ToDaily")]
	public decimal? ToDaily(CqlCode frequency)
	{
		decimal? a_()
		{
			bool b_()
			{
				var c_ = this.C();
				var d_ = context.Operators.Equal(frequency, c_);

				return (d_ ?? false);
			};
			if (b_())
			{
				return 3.0m;
			}
			else
			{
				var e_ = this.ErrorLevel();
				var f_ = context.Operators.Concatenate("Unknown frequency code ", (frequency?.code ?? ""));
				var g_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", e_, f_);

				return (g_ as decimal?);
			}
		};

		return a_();
	}

    [CqlDeclaration("MedicationRequestPeriod")]
	public CqlInterval<CqlDateTime> MedicationRequestPeriod(MedicationRequest Request)
	{
		var a_ = new MedicationRequest[]
		{
			Request,
		};
		CqlInterval<CqlDateTime> b_(MedicationRequest R)
		{
			CqlInterval<CqlDateTime> e_()
			{
				bool f_()
				{
					var g_ = R?.DosageInstruction;
					var h_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)g_);
					var i_ = h_?.Timing;
					var j_ = i_?.Repeat;
					var k_ = j_?.Bounds;
					var l_ = FHIRHelpers_4_0_001.ToInterval((k_ as Period));
					var m_ = context.Operators.End(l_);
					var o_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)g_);
					var p_ = o_?.Timing;
					var q_ = p_?.Repeat;
					var r_ = q_?.Bounds;
					var s_ = FHIRHelpers_4_0_001.ToInterval((r_ as Period));
					var t_ = context.Operators.End(s_);
					var u_ = context.Operators.MaxValue<CqlDateTime>();
					var v_ = context.Operators.Equal(t_, u_);
					var w_ = context.Operators.Or((bool?)(m_ is null), v_);
					var x_ = context.Operators.Not(w_);

					return (x_ ?? false);
				};
				if (f_())
				{
					var y_ = R?.DosageInstruction;
					var z_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)y_);
					var aa_ = z_?.Timing;
					var ab_ = aa_?.Repeat;
					var ac_ = ab_?.Bounds;
					var ad_ = FHIRHelpers_4_0_001.ToInterval((ac_ as Period));
					var ae_ = context.Operators.Start(ad_);
					var af_ = R?.DispenseRequest;
					var ag_ = af_?.ValidityPeriod;
					var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
					var ai_ = context.Operators.Start(ah_);
					var aj_ = R?.AuthoredOnElement;
					var ak_ = FHIRHelpers_4_0_001.ToDateTime(aj_);
					var am_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)y_);
					var an_ = am_?.Timing;
					var ao_ = an_?.Repeat;
					var ap_ = ao_?.Bounds;
					var aq_ = FHIRHelpers_4_0_001.ToInterval((ap_ as Period));
					var ar_ = context.Operators.End(aq_);
					var as_ = context.Operators.Interval(((ae_ ?? ai_) ?? ak_), ar_, true, true);

					return as_;
				}
				else
				{
					var at_ = R?.DosageInstruction;
					var au_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var av_ = au_?.Timing;
					var aw_ = av_?.Repeat;
					var ax_ = aw_?.Bounds;
					var ay_ = FHIRHelpers_4_0_001.ToInterval((ax_ as Period));
					var az_ = context.Operators.Start(ay_);
					var ba_ = R?.DispenseRequest;
					var bb_ = ba_?.ValidityPeriod;
					var bc_ = FHIRHelpers_4_0_001.ToInterval(bb_);
					var bd_ = context.Operators.Start(bc_);
					var be_ = R?.AuthoredOnElement;
					var bf_ = FHIRHelpers_4_0_001.ToDateTime(be_);
					var bh_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var bi_ = bh_?.Timing;
					var bj_ = bi_?.Repeat;
					var bk_ = bj_?.Bounds;
					var bl_ = FHIRHelpers_4_0_001.ToInterval((bk_ as Period));
					var bm_ = context.Operators.Start(bl_);
					var bo_ = ba_?.ValidityPeriod;
					var bp_ = FHIRHelpers_4_0_001.ToInterval(bo_);
					var bq_ = context.Operators.Start(bp_);
					var bs_ = FHIRHelpers_4_0_001.ToDateTime(be_);
					var bu_ = ba_?.ExpectedSupplyDuration;
					var bv_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)bu_);
					var bx_ = ba_?.Quantity;
					var by_ = FHIRHelpers_4_0_001.ToQuantity(bx_);
					var ca_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var cb_ = ca_?.DoseAndRate;
					var cc_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)cb_);
					var cd_ = cc_?.Dose;
					var ce_ = FHIRHelpers_4_0_001.ToInterval((cd_ as Range));
					var cf_ = context.Operators.End(ce_);
					var ch_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var ci_ = ch_?.DoseAndRate;
					var cj_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)ci_);
					var ck_ = cj_?.Dose;
					var cl_ = FHIRHelpers_4_0_001.ToQuantity((ck_ as Quantity));
					var cn_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var co_ = cn_?.Timing;
					var cp_ = co_?.Repeat;
					var cq_ = cp_?.FrequencyMaxElement;
					var cr_ = context.Operators.Convert<Integer>(cq_);
					var ct_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var cu_ = ct_?.Timing;
					var cv_ = cu_?.Repeat;
					var cw_ = cv_?.FrequencyElement;
					var cx_ = context.Operators.Convert<Integer>(cw_);
					var cy_ = FHIRHelpers_4_0_001.ToInteger((cr_ ?? cx_));
					var da_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var db_ = da_?.Timing;
					var dc_ = db_?.Repeat;
					var dd_ = dc_?.PeriodElement;
					var de_ = FHIRHelpers_4_0_001.ToDecimal(dd_);
					var dg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var dh_ = dg_?.Timing;
					var di_ = dh_?.Repeat;
					var dj_ = di_?.PeriodUnitElement;
					var dk_ = dj_?.Value;
					var dl_ = context.Operators.Convert<string>(dk_);
					var dm_ = this.ToDaily(cy_, new CqlQuantity(de_, dl_));
					var do_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)at_);
					var dp_ = do_?.Timing;
					var dq_ = dp_?.Repeat;
					var dr_ = dq_?.TimeOfDayElement;
					var ds_ = context.Operators.Count<Time>((IEnumerable<Time>)dr_);
					var dt_ = context.Operators.ConvertIntegerToDecimal(ds_);
					var du_ = context.Operators.ConvertDecimalToQuantity(((dm_ ?? dt_) ?? 1.0m));
					var dv_ = context.Operators.Multiply((cf_ ?? cl_), du_);
					var dw_ = context.Operators.Divide(by_, dv_);
					var dy_ = ba_?.NumberOfRepeatsAllowedElement;
					var dz_ = context.Operators.Convert<Integer>(dy_);
					var ea_ = FHIRHelpers_4_0_001.ToInteger(dz_);
					var eb_ = context.Operators.Add(1, (ea_ ?? 0));
					var ec_ = context.Operators.ConvertIntegerToQuantity(eb_);
					var ed_ = context.Operators.Multiply((bv_ ?? dw_), ec_);
					var ee_ = context.Operators.Add(((bm_ ?? bq_) ?? bs_), ed_);
					var ef_ = context.Operators.Interval(((az_ ?? bd_) ?? bf_), ee_, true, true);

					return ef_;
				}
			};

			return e_();
		};
		var c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>((IEnumerable<MedicationRequest>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationDispensePeriod")]
	public CqlInterval<CqlDateTime> MedicationDispensePeriod(MedicationDispense Dispense)
	{
		var a_ = new MedicationDispense[]
		{
			Dispense,
		};
		CqlInterval<CqlDateTime> b_(MedicationDispense D)
		{
			var e_ = D?.WhenHandedOverElement;
			var f_ = D?.WhenPreparedElement;
			var g_ = FHIRHelpers_4_0_001.ToDateTime((e_ ?? f_));
			var j_ = FHIRHelpers_4_0_001.ToDateTime((e_ ?? f_));
			var k_ = D?.DaysSupply;
			var l_ = FHIRHelpers_4_0_001.ToQuantity(k_);
			var m_ = D?.Quantity;
			var n_ = FHIRHelpers_4_0_001.ToQuantity(m_);
			var o_ = D?.DosageInstruction;
			var p_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
			var q_ = p_?.DoseAndRate;
			var r_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)q_);
			var s_ = r_?.Dose;
			var t_ = FHIRHelpers_4_0_001.ToInterval((s_ as Range));
			var u_ = context.Operators.End(t_);
			var w_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
			var x_ = w_?.DoseAndRate;
			var y_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)x_);
			var z_ = y_?.Dose;
			var aa_ = FHIRHelpers_4_0_001.ToQuantity((z_ as Quantity));
			var ac_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
			var ad_ = ac_?.Timing;
			var ae_ = ad_?.Repeat;
			var af_ = ae_?.FrequencyMaxElement;
			var ag_ = context.Operators.Convert<Integer>(af_);
			var ai_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
			var aj_ = ai_?.Timing;
			var ak_ = aj_?.Repeat;
			var al_ = ak_?.FrequencyElement;
			var am_ = context.Operators.Convert<Integer>(al_);
			var an_ = FHIRHelpers_4_0_001.ToInteger((ag_ ?? am_));
			var ap_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
			var aq_ = ap_?.Timing;
			var ar_ = aq_?.Repeat;
			var as_ = ar_?.PeriodElement;
			var at_ = FHIRHelpers_4_0_001.ToDecimal(as_);
			var av_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
			var aw_ = av_?.Timing;
			var ax_ = aw_?.Repeat;
			var ay_ = ax_?.PeriodUnitElement;
			var az_ = ay_?.Value;
			var ba_ = context.Operators.Convert<string>(az_);
			var bb_ = this.ToDaily(an_, new CqlQuantity(at_, ba_));
			var bd_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)o_);
			var be_ = bd_?.Timing;
			var bf_ = be_?.Repeat;
			var bg_ = bf_?.TimeOfDayElement;
			var bh_ = context.Operators.Count<Time>((IEnumerable<Time>)bg_);
			var bi_ = context.Operators.ConvertIntegerToDecimal(bh_);
			var bj_ = context.Operators.ConvertDecimalToQuantity(((bb_ ?? bi_) ?? 1.0m));
			var bk_ = context.Operators.Multiply((u_ ?? aa_), bj_);
			var bl_ = context.Operators.Divide(n_, bk_);
			var bm_ = context.Operators.Add(j_, (l_ ?? bl_));
			var bn_ = context.Operators.Interval(g_, bm_, true, true);

			return bn_;
		};
		var c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>((IEnumerable<MedicationDispense>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("TherapeuticDuration")]
	public CqlQuantity TherapeuticDuration(CqlConcept medication)
	{
		var a_ = context.Operators.Quantity(14m, "days");

		return a_;
	}

    [CqlDeclaration("MedicationAdministrationPeriod")]
	public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(MedicationAdministration Administration)
	{
		var a_ = new MedicationAdministration[]
		{
			Administration,
		};
		CqlInterval<CqlDateTime> b_(MedicationAdministration M)
		{
			CqlInterval<CqlDateTime> e_()
			{
				bool f_()
				{
					var g_ = Administration?.Effective;
					var h_ = FHIRHelpers_4_0_001.ToInterval((g_ as Period));
					var i_ = context.Operators.Start(h_);
					var j_ = context.Operators.Not((bool?)(i_ is null));
					var k_ = Administration?.Medication;
					var l_ = FHIRHelpers_4_0_001.ToConcept((k_ as CodeableConcept));
					var m_ = this.TherapeuticDuration(l_);
					var n_ = context.Operators.Not((bool?)(m_ is null));
					var o_ = context.Operators.And(j_, n_);

					return (o_ ?? false);
				};
				if (f_())
				{
					var p_ = Administration?.Effective;
					var q_ = FHIRHelpers_4_0_001.ToInterval((p_ as Period));
					var r_ = context.Operators.Start(q_);
					var t_ = FHIRHelpers_4_0_001.ToInterval((p_ as Period));
					var u_ = context.Operators.Start(t_);
					var v_ = Administration?.Medication;
					var w_ = FHIRHelpers_4_0_001.ToConcept((v_ as CodeableConcept));
					var x_ = this.TherapeuticDuration(w_);
					var y_ = context.Operators.Add(u_, x_);
					var z_ = context.Operators.Interval(r_, y_, true, true);

					return z_;
				}
				else
				{
					return (null as CqlInterval<CqlDateTime>);
				}
			};

			return e_();
		};
		var c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>((IEnumerable<MedicationAdministration>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("CumulativeDuration")]
	public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDateTime>> Intervals)
	{
		var a_ = context.Operators.Collapse(Intervals, "day");
		int? b_(CqlInterval<CqlDateTime> X)
		{
			var e_ = context.Operators.Start(X);
			var f_ = context.Operators.End(X);
			var g_ = context.Operators.DifferenceBetween(e_, f_, "day");

			return g_;
		};
		var c_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(a_, b_);
		var d_ = context.Operators.Sum(c_);

		return d_;
	}

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
		{
			var c_ = new CqlInterval<CqlDateTime>[]
			{
				I,
			};
			CqlInterval<CqlDateTime> d_(CqlInterval<CqlDateTime> X)
			{
				var i_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
				var j_ = context.Operators.End(i_);
				var k_ = context.Operators.Quantity(1m, "day");
				var l_ = context.Operators.Add(j_, k_);
				var m_ = context.Operators.Start(X);
				var n_ = new CqlDateTime[]
				{
					l_,
					m_,
				};
				var o_ = context.Operators.Max<CqlDateTime>((n_ as IEnumerable<CqlDateTime>));
				var q_ = context.Operators.End(i_);
				var s_ = context.Operators.Add(q_, k_);
				var u_ = new CqlDateTime[]
				{
					s_,
					m_,
				};
				var v_ = context.Operators.Max<CqlDateTime>((u_ as IEnumerable<CqlDateTime>));
				var x_ = context.Operators.End(X);
				var y_ = context.Operators.DurationBetween(m_, x_, "day");
				var z_ = context.Operators.ConvertIntegerToDecimal((y_ ?? 0));
				var aa_ = context.Operators.Add(v_, new CqlQuantity(z_, "day"));
				var ab_ = context.Operators.Interval(o_, aa_, true, true);

				return ab_;
			};
			var e_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>((IEnumerable<CqlInterval<CqlDateTime>>)c_, d_);
			var f_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(e_);
			var g_ = new CqlInterval<CqlDateTime>[]
			{
				f_,
			};
			var h_ = context.Operators.Union<CqlInterval<CqlDateTime>>(R, (g_ as IEnumerable<CqlInterval<CqlDateTime>>));

			return h_;
		};
		var b_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, a_, (null as IEnumerable<CqlInterval<CqlDateTime>>));

		return b_;
	}

    [CqlDeclaration("MedicationPeriod")]
	public CqlInterval<CqlDateTime> MedicationPeriod(object medication)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (medication is MedicationRequest)
			{
				var b_ = this.MedicationRequestPeriod((medication as MedicationRequest));

				return b_;
			}
			else if (medication is MedicationDispense)
			{
				var c_ = this.MedicationDispensePeriod((medication as MedicationDispense));

				return c_;
			}
			else if (medication is MedicationAdministration)
			{
				var d_ = this.MedicationAdministrationPeriod((medication as MedicationAdministration));

				return d_;
			}
			else
			{
				return (null as CqlInterval<CqlDateTime>);
			}
		};

		return a_();
	}

    [CqlDeclaration("CumulativeMedicationDuration")]
	public int? CumulativeMedicationDuration(IEnumerable<object> Medications)
	{
		bool? a_(object M)
		{
			var l_ = M is MedicationRequest;

			return (l_ as bool?);
		};
		var b_ = context.Operators.Where<object>(Medications, a_);
		CqlInterval<CqlDateTime> c_(object M)
		{
			var m_ = this.MedicationPeriod(M);

			return m_;
		};
		var d_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(b_, c_);
		bool? e_(object M)
		{
			var n_ = M is MedicationDispense;
			var o_ = M is MedicationAdministration;
			var p_ = context.Operators.Or((n_ as bool?), (o_ as bool?));

			return p_;
		};
		var f_ = context.Operators.Where<object>(Medications, e_);
		CqlInterval<CqlDateTime> g_(object M)
		{
			var q_ = this.MedicationPeriod(M);

			return q_;
		};
		var h_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(f_, g_);
		var i_ = this.RolloutIntervals(h_);
		var j_ = context.Operators.Union<CqlInterval<CqlDateTime>>(d_, i_);
		var k_ = this.CumulativeDuration(j_);

		return k_;
	}

}
