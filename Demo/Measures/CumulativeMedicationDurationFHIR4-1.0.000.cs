using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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

    private CqlCode AC_Value()
	{
		var a_ = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("AC")]
    public CqlCode AC() => __AC.Value;

    private CqlCode ACD_Value()
	{
		var a_ = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("ACD")]
    public CqlCode ACD() => __ACD.Value;

    private CqlCode ACM_Value()
	{
		var a_ = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("ACM")]
    public CqlCode ACM() => __ACM.Value;

    private CqlCode ACV_Value()
	{
		var a_ = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("ACV")]
    public CqlCode ACV() => __ACV.Value;

    private CqlCode AFT_Value()
	{
		var a_ = new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("AFT")]
    public CqlCode AFT() => __AFT.Value;

    private CqlCode AFT_early_Value()
	{
		var a_ = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("AFT.early")]
    public CqlCode AFT_early() => __AFT_early.Value;

    private CqlCode AFT_late_Value()
	{
		var a_ = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("AFT.late")]
    public CqlCode AFT_late() => __AFT_late.Value;

    private CqlCode C_Value()
	{
		var a_ = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("C")]
    public CqlCode C() => __C.Value;

    private CqlCode CD_Value()
	{
		var a_ = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("CD")]
    public CqlCode CD() => __CD.Value;

    private CqlCode CM_Value()
	{
		var a_ = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("CM")]
    public CqlCode CM() => __CM.Value;

    private CqlCode CV_Value()
	{
		var a_ = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("CV")]
    public CqlCode CV() => __CV.Value;

    private CqlCode EVE_Value()
	{
		var a_ = new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("EVE")]
    public CqlCode EVE() => __EVE.Value;

    private CqlCode EVE_early_Value()
	{
		var a_ = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("EVE.early")]
    public CqlCode EVE_early() => __EVE_early.Value;

    private CqlCode EVE_late_Value()
	{
		var a_ = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("EVE.late")]
    public CqlCode EVE_late() => __EVE_late.Value;

    private CqlCode HS_Value()
	{
		var a_ = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("HS")]
    public CqlCode HS() => __HS.Value;

    private CqlCode MORN_Value()
	{
		var a_ = new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("MORN")]
    public CqlCode MORN() => __MORN.Value;

    private CqlCode MORN_early_Value()
	{
		var a_ = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("MORN.early")]
    public CqlCode MORN_early() => __MORN_early.Value;

    private CqlCode MORN_late_Value()
	{
		var a_ = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("MORN.late")]
    public CqlCode MORN_late() => __MORN_late.Value;

    private CqlCode NIGHT_Value()
	{
		var a_ = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("NIGHT")]
    public CqlCode NIGHT() => __NIGHT.Value;

    private CqlCode NOON_Value()
	{
		var a_ = new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("NOON")]
    public CqlCode NOON() => __NOON.Value;

    private CqlCode PC_Value()
	{
		var a_ = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("PC")]
    public CqlCode PC() => __PC.Value;

    private CqlCode PCD_Value()
	{
		var a_ = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("PCD")]
    public CqlCode PCD() => __PCD.Value;

    private CqlCode PCM_Value()
	{
		var a_ = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("PCM")]
    public CqlCode PCM() => __PCM.Value;

    private CqlCode PCV_Value()
	{
		var a_ = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("PCV")]
    public CqlCode PCV() => __PCV.Value;

    private CqlCode PHS_Value()
	{
		var a_ = new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null);

		return a_;
	}

    [CqlDeclaration("PHS")]
    public CqlCode PHS() => __PHS.Value;

    private CqlCode WAKE_Value()
	{
		var a_ = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

		return a_;
	}

    [CqlDeclaration("WAKE")]
    public CqlCode WAKE() => __WAKE.Value;

    private CqlCode[] V3TimingEvent_Value()
	{
		var a_ = new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var b_ = new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var c_ = new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var d_ = new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var e_ = new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var f_ = new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var g_ = new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var h_ = new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var i_ = new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var j_ = new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var k_ = new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var l_ = new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var m_ = new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var n_ = new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);
		var o_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
			g_,
			h_,
			i_,
			j_,
			k_,
			l_,
			m_,
			n_,
		};

		return o_;
	}

    [CqlDeclaration("V3TimingEvent")]
    public CqlCode[] V3TimingEvent() => __V3TimingEvent.Value;

    private CqlCode[] EventTiming_Value()
	{
		var a_ = new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null);
		var b_ = new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null);
		var c_ = new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null);
		var d_ = new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null);
		var e_ = new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null);
		var f_ = new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null);
		var g_ = new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null);
		var h_ = new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null);
		var i_ = new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null);
		var j_ = new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null);
		var k_ = new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null);
		var l_ = new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null);
		var m_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
			g_,
			h_,
			i_,
			j_,
			k_,
			l_,
		};

		return m_;
	}

    [CqlDeclaration("EventTiming")]
    public CqlCode[] EventTiming() => __EventTiming.Value;

    private string ErrorLevel_Value()
	{
		var a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

		return (string)a_;
	}

    [CqlDeclaration("ErrorLevel")]
    public string ErrorLevel() => __ErrorLevel.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("ToDaily")]
    public decimal? ToDaily(int? frequency, CqlQuantity period)
	{
		decimal? a_()
		{
			if ((context.Operators.Equal(period?.unit, "h") ?? false))
			{
				var b_ = context.Operators;
				var c_ = b_.ConvertIntegerToDecimal(frequency);
				var d_ = period?.value;
				var f_ = b_.Divide((decimal?)24.0m, d_);
				var h_ = b_.Multiply(c_, f_);

				return h_;
			}
			else if ((context.Operators.Equal(period?.unit, "min") ?? false))
			{
				var i_ = context.Operators;
				var j_ = i_.ConvertIntegerToDecimal(frequency);
				var k_ = period?.value;
				var m_ = i_.Divide((decimal?)24.0m, k_);
				var o_ = i_.Multiply(j_, m_);
				var q_ = i_.ConvertIntegerToDecimal((int?)60);
				var s_ = i_.Multiply(o_, q_);

				return s_;
			}
			else if ((context.Operators.Equal(period?.unit, "s") ?? false))
			{
				var t_ = context.Operators;
				var u_ = t_.ConvertIntegerToDecimal(frequency);
				var v_ = period?.value;
				var x_ = t_.Divide((decimal?)24.0m, v_);
				var z_ = t_.Multiply(u_, x_);
				var ab_ = t_.ConvertIntegerToDecimal((int?)60);
				var ad_ = t_.Multiply(z_, ab_);
				var af_ = t_.ConvertIntegerToDecimal((int?)60);
				var ah_ = t_.Multiply(ad_, af_);

				return ah_;
			}
			else if ((context.Operators.Equal(period?.unit, "d") ?? false))
			{
				var ai_ = context.Operators;
				var aj_ = ai_.ConvertIntegerToDecimal(frequency);
				var ak_ = period?.value;
				var am_ = ai_.Divide((decimal?)24.0m, ak_);
				var ao_ = ai_.Multiply(aj_, am_);
				var aq_ = ai_.ConvertIntegerToDecimal((int?)24);
				var as_ = ai_.Divide(ao_, aq_);

				return as_;
			}
			else if ((context.Operators.Equal(period?.unit, "wk") ?? false))
			{
				var at_ = context.Operators;
				var au_ = at_.ConvertIntegerToDecimal(frequency);
				var av_ = period?.value;
				var ax_ = at_.Divide((decimal?)24.0m, av_);
				var az_ = at_.Multiply(au_, ax_);
				var bb_ = at_.Multiply((int?)24, (int?)7);
				var bd_ = at_.ConvertIntegerToDecimal(bb_);
				var bf_ = at_.Divide(az_, bd_);

				return bf_;
			}
			else if ((context.Operators.Equal(period?.unit, "mo") ?? false))
			{
				var bg_ = context.Operators;
				var bh_ = bg_.ConvertIntegerToDecimal(frequency);
				var bi_ = period?.value;
				var bk_ = bg_.Divide((decimal?)24.0m, bi_);
				var bm_ = bg_.Multiply(bh_, bk_);
				var bo_ = bg_.Multiply((int?)24, (int?)30);
				var bq_ = bg_.ConvertIntegerToDecimal(bo_);
				var bs_ = bg_.Divide(bm_, bq_);

				return bs_;
			}
			else if ((context.Operators.Equal(period?.unit, "a") ?? false))
			{
				var bt_ = context.Operators;
				var bu_ = bt_.ConvertIntegerToDecimal(frequency);
				var bv_ = period?.value;
				var bx_ = bt_.Divide((decimal?)24.0m, bv_);
				var bz_ = bt_.Multiply(bu_, bx_);
				var cb_ = bt_.Multiply((int?)24, (int?)365);
				var cd_ = bt_.ConvertIntegerToDecimal(cb_);
				var cf_ = bt_.Divide(bz_, cd_);

				return cf_;
			}
			else if ((context.Operators.Equal(period?.unit, "hour") ?? false))
			{
				var cg_ = context.Operators;
				var ch_ = cg_.ConvertIntegerToDecimal(frequency);
				var ci_ = period?.value;
				var ck_ = cg_.Divide((decimal?)24.0m, ci_);
				var cm_ = cg_.Multiply(ch_, ck_);

				return cm_;
			}
			else if ((context.Operators.Equal(period?.unit, "minute") ?? false))
			{
				var cn_ = context.Operators;
				var co_ = cn_.ConvertIntegerToDecimal(frequency);
				var cp_ = period?.value;
				var cr_ = cn_.Divide((decimal?)24.0m, cp_);
				var ct_ = cn_.Multiply(co_, cr_);
				var cv_ = cn_.ConvertIntegerToDecimal((int?)60);
				var cx_ = cn_.Multiply(ct_, cv_);

				return cx_;
			}
			else if ((context.Operators.Equal(period?.unit, "second") ?? false))
			{
				var cy_ = context.Operators;
				var cz_ = cy_.ConvertIntegerToDecimal(frequency);
				var da_ = period?.value;
				var dc_ = cy_.Divide((decimal?)24.0m, da_);
				var de_ = cy_.Multiply(cz_, dc_);
				var dg_ = cy_.ConvertIntegerToDecimal((int?)60);
				var di_ = cy_.Multiply(de_, dg_);
				var dk_ = cy_.ConvertIntegerToDecimal((int?)60);
				var dm_ = cy_.Multiply(di_, dk_);

				return dm_;
			}
			else if ((context.Operators.Equal(period?.unit, "day") ?? false))
			{
				var dn_ = context.Operators;
				var do_ = dn_.ConvertIntegerToDecimal(frequency);
				var dp_ = period?.value;
				var dr_ = dn_.Divide((decimal?)24.0m, dp_);
				var dt_ = dn_.Multiply(do_, dr_);
				var dv_ = dn_.ConvertIntegerToDecimal((int?)24);
				var dx_ = dn_.Divide(dt_, dv_);

				return dx_;
			}
			else if ((context.Operators.Equal(period?.unit, "week") ?? false))
			{
				var dy_ = context.Operators;
				var dz_ = dy_.ConvertIntegerToDecimal(frequency);
				var ea_ = period?.value;
				var ec_ = dy_.Divide((decimal?)24.0m, ea_);
				var ee_ = dy_.Multiply(dz_, ec_);
				var eg_ = dy_.Multiply((int?)24, (int?)7);
				var ei_ = dy_.ConvertIntegerToDecimal(eg_);
				var ek_ = dy_.Divide(ee_, ei_);

				return ek_;
			}
			else if ((context.Operators.Equal(period?.unit, "month") ?? false))
			{
				var el_ = context.Operators;
				var em_ = el_.ConvertIntegerToDecimal(frequency);
				var en_ = period?.value;
				var ep_ = el_.Divide((decimal?)24.0m, en_);
				var er_ = el_.Multiply(em_, ep_);
				var et_ = el_.Multiply((int?)24, (int?)30);
				var ev_ = el_.ConvertIntegerToDecimal(et_);
				var ex_ = el_.Divide(er_, ev_);

				return ex_;
			}
			else if ((context.Operators.Equal(period?.unit, "year") ?? false))
			{
				var ey_ = context.Operators;
				var ez_ = ey_.ConvertIntegerToDecimal(frequency);
				var fa_ = period?.value;
				var fc_ = ey_.Divide((decimal?)24.0m, fa_);
				var fe_ = ey_.Multiply(ez_, fc_);
				var fg_ = ey_.Multiply((int?)24, (int?)365);
				var fi_ = ey_.ConvertIntegerToDecimal(fg_);
				var fk_ = ey_.Divide(fe_, fi_);

				return fk_;
			}
			else if ((context.Operators.Equal(period?.unit, "hours") ?? false))
			{
				var fl_ = context.Operators;
				var fm_ = fl_.ConvertIntegerToDecimal(frequency);
				var fn_ = period?.value;
				var fp_ = fl_.Divide((decimal?)24.0m, fn_);
				var fr_ = fl_.Multiply(fm_, fp_);

				return fr_;
			}
			else if ((context.Operators.Equal(period?.unit, "minutes") ?? false))
			{
				var fs_ = context.Operators;
				var ft_ = fs_.ConvertIntegerToDecimal(frequency);
				var fu_ = period?.value;
				var fw_ = fs_.Divide((decimal?)24.0m, fu_);
				var fy_ = fs_.Multiply(ft_, fw_);
				var ga_ = fs_.ConvertIntegerToDecimal((int?)60);
				var gc_ = fs_.Multiply(fy_, ga_);

				return gc_;
			}
			else if ((context.Operators.Equal(period?.unit, "seconds") ?? false))
			{
				var gd_ = context.Operators;
				var ge_ = gd_.ConvertIntegerToDecimal(frequency);
				var gf_ = period?.value;
				var gh_ = gd_.Divide((decimal?)24.0m, gf_);
				var gj_ = gd_.Multiply(ge_, gh_);
				var gl_ = gd_.ConvertIntegerToDecimal((int?)60);
				var gn_ = gd_.Multiply(gj_, gl_);
				var gp_ = gd_.ConvertIntegerToDecimal((int?)60);
				var gr_ = gd_.Multiply(gn_, gp_);

				return gr_;
			}
			else if ((context.Operators.Equal(period?.unit, "days") ?? false))
			{
				var gs_ = context.Operators;
				var gt_ = gs_.ConvertIntegerToDecimal(frequency);
				var gu_ = period?.value;
				var gw_ = gs_.Divide((decimal?)24.0m, gu_);
				var gy_ = gs_.Multiply(gt_, gw_);
				var ha_ = gs_.ConvertIntegerToDecimal((int?)24);
				var hc_ = gs_.Divide(gy_, ha_);

				return hc_;
			}
			else if ((context.Operators.Equal(period?.unit, "weeks") ?? false))
			{
				var hd_ = context.Operators;
				var he_ = hd_.ConvertIntegerToDecimal(frequency);
				var hf_ = period?.value;
				var hh_ = hd_.Divide((decimal?)24.0m, hf_);
				var hj_ = hd_.Multiply(he_, hh_);
				var hl_ = hd_.Multiply((int?)24, (int?)7);
				var hn_ = hd_.ConvertIntegerToDecimal(hl_);
				var hp_ = hd_.Divide(hj_, hn_);

				return hp_;
			}
			else if ((context.Operators.Equal(period?.unit, "months") ?? false))
			{
				var hq_ = context.Operators;
				var hr_ = hq_.ConvertIntegerToDecimal(frequency);
				var hs_ = period?.value;
				var hu_ = hq_.Divide((decimal?)24.0m, hs_);
				var hw_ = hq_.Multiply(hr_, hu_);
				var hy_ = hq_.Multiply((int?)24, (int?)30);
				var ia_ = hq_.ConvertIntegerToDecimal(hy_);
				var ic_ = hq_.Divide(hw_, ia_);

				return ic_;
			}
			else if ((context.Operators.Equal(period?.unit, "years") ?? false))
			{
				var id_ = context.Operators;
				var ie_ = id_.ConvertIntegerToDecimal(frequency);
				var if_ = period?.value;
				var ih_ = id_.Divide((decimal?)24.0m, if_);
				var ij_ = id_.Multiply(ie_, ih_);
				var il_ = id_.Multiply((int?)24, (int?)365);
				var in_ = id_.ConvertIntegerToDecimal(il_);
				var ip_ = id_.Divide(ij_, in_);

				return ip_;
			}
			else
			{
				var iq_ = this.ErrorLevel();
				var ir_ = ("Unknown unit " ?? "");
				var is_ = period?.unit;
				var it_ = (is_ ?? "");
				var iu_ = context.Operators;
				var iv_ = iu_.Concatenate(ir_, it_);
				var ix_ = iu_.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", iq_, iv_);

				return (decimal?)ix_;
			}
;
		};

		return a_();
	}


    [CqlDeclaration("ToDaily")]
    public decimal? ToDaily(CqlCode frequency)
	{
		decimal? a_()
		{
			if ((context.Operators.Equal(frequency, this.C()) ?? false))
				return (decimal?)3.0m;

			else
			{
				var b_ = this.ErrorLevel();
				var c_ = ("Unknown frequency code " ?? "");
				var d_ = frequency?.code;
				var e_ = (d_ ?? "");
				var f_ = context.Operators;
				var g_ = f_.Concatenate(c_, e_);
				var i_ = f_.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", b_, g_);

				return (decimal?)i_;
			}
;
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
		CqlInterval<CqlDateTime> b_(MedicationRequest R) => (((context.Operators.Not(context.Operators.Or((bool?)(context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))) is null), context.Operators.Equal(context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))), context.Operators.Maximum<CqlDateTime>()))) ?? false))
			? (context.Operators.Interval(((context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))) ?? context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))), true, true))
			: (context.Operators.Interval(((context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))) ?? context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), context.Operators.Add(((context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))) ?? context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), context.Operators.Multiply((FHIRHelpers_4_0_001.ToQuantity((Quantity)R?.DispenseRequest?.ExpectedSupplyDuration) ?? context.Operators.Divide(FHIRHelpers_4_0_001.ToQuantity(R?.DispenseRequest?.Quantity), context.Operators.Multiply((context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose as Range))) ?? FHIRHelpers_4_0_001.ToQuantity(((context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose as Quantity))), context.Operators.ConvertDecimalToQuantity(((this.ToDaily(FHIRHelpers_4_0_001.ToInteger((context.Operators.TypeConverter.Convert<Integer>((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyMaxElement) ?? context.Operators.TypeConverter.Convert<Integer>((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyElement))), new CqlQuantity
											{
												value = FHIRHelpers_4_0_001.ToDecimal((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodElement),
												unit = context.Operators.TypeConverter.Convert<string>(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodUnitElement)?.Value),
											}) ?? context.Operators.ConvertIntegerToDecimal(context.Operators.CountOrNull<Time>(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.TimeOfDayElement as IEnumerable<Time>)))) ?? (decimal?)1.0m))))), context.Operators.ConvertIntegerToQuantity(context.Operators.Add((int?)1, (FHIRHelpers_4_0_001.ToInteger(context.Operators.TypeConverter.Convert<Integer>(R?.DispenseRequest?.NumberOfRepeatsAllowedElement)) ?? (int?)0))))), true, true)));
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(a_, b_);
		var f_ = c_.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

		return f_;
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
			var g_ = D?.WhenHandedOverElement;
			var h_ = D?.WhenPreparedElement;
			var i_ = (g_ ?? h_);
			var j_ = FHIRHelpers_4_0_001.ToDateTime(i_);
			var m_ = (g_ ?? h_);
			var n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
			var o_ = D?.DaysSupply;
			var p_ = FHIRHelpers_4_0_001.ToQuantity(o_);
			var q_ = D?.Quantity;
			var r_ = FHIRHelpers_4_0_001.ToQuantity(q_);
			var s_ = D?.DosageInstruction;
			var t_ = context.Operators;
			var u_ = t_.SingleOrNull<Dosage>((s_ as IEnumerable<Dosage>));
			var v_ = u_?.DoseAndRate;
			var x_ = t_.SingleOrNull<Dosage.DoseAndRateComponent>((v_ as IEnumerable<Dosage.DoseAndRateComponent>));
			var y_ = x_?.Dose;
			var z_ = FHIRHelpers_4_0_001.ToInterval((y_ as Range));
			var ab_ = t_.End(z_);
			var ae_ = t_.SingleOrNull<Dosage>((s_ as IEnumerable<Dosage>));
			var af_ = ae_?.DoseAndRate;
			var ah_ = t_.SingleOrNull<Dosage.DoseAndRateComponent>((af_ as IEnumerable<Dosage.DoseAndRateComponent>));
			var ai_ = ah_?.Dose;
			var aj_ = FHIRHelpers_4_0_001.ToQuantity((ai_ as Quantity));
			var ak_ = (ab_ ?? aj_);
			var an_ = t_.SingleOrNull<Dosage>((s_ as IEnumerable<Dosage>));
			var ao_ = an_?.Timing;
			var ap_ = ao_?.Repeat;
			var aq_ = ap_?.FrequencyMaxElement;
			var as_ = t_.TypeConverter;
			var at_ = as_.Convert<Integer>(aq_);
			var aw_ = t_.SingleOrNull<Dosage>((s_ as IEnumerable<Dosage>));
			var ax_ = aw_?.Timing;
			var ay_ = ax_?.Repeat;
			var az_ = ay_?.FrequencyElement;
			var bb_ = t_.TypeConverter;
			var bc_ = bb_.Convert<Integer>(az_);
			var bd_ = (at_ ?? bc_);
			var be_ = FHIRHelpers_4_0_001.ToInteger(bd_);
			var bh_ = t_.SingleOrNull<Dosage>((s_ as IEnumerable<Dosage>));
			var bi_ = bh_?.Timing;
			var bj_ = bi_?.Repeat;
			var bk_ = bj_?.PeriodElement;
			var bl_ = FHIRHelpers_4_0_001.ToDecimal(bk_);
			var bo_ = t_.SingleOrNull<Dosage>((s_ as IEnumerable<Dosage>));
			var bp_ = bo_?.Timing;
			var bq_ = bp_?.Repeat;
			var br_ = bq_?.PeriodUnitElement;
			var bs_ = br_?.Value;
			var bu_ = t_.TypeConverter;
			var bv_ = bu_.Convert<string>(bs_);
			var bw_ = new CqlQuantity
			{
				value = bl_,
				unit = bv_,
			};
			var bx_ = this.ToDaily(be_, bw_);
			var ca_ = t_.SingleOrNull<Dosage>((s_ as IEnumerable<Dosage>));
			var cb_ = ca_?.Timing;
			var cc_ = cb_?.Repeat;
			var cd_ = cc_?.TimeOfDayElement;
			var cf_ = t_.CountOrNull<Time>((cd_ as IEnumerable<Time>));
			var ch_ = t_.ConvertIntegerToDecimal(cf_);
			var ci_ = (bx_ ?? ch_);
			var cj_ = (ci_ ?? (decimal?)1.0m);
			var cl_ = t_.ConvertDecimalToQuantity(cj_);
			var cn_ = t_.Multiply(ak_, cl_);
			var cp_ = t_.Divide(r_, cn_);
			var cq_ = (p_ ?? cp_);
			var cs_ = t_.Add(n_, cq_);
			var cu_ = t_.Interval(j_, cs_, true, true);

			return cu_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(a_, b_);
		var f_ = c_.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

		return f_;
	}


    [CqlDeclaration("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlConcept medication)
	{
		var a_ = context.Operators;
		var b_ = a_.Quantity(14m, "days");

		return b_;
	}


    [CqlDeclaration("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(MedicationAdministration Administration)
	{
		var a_ = new MedicationAdministration[]
		{
			Administration,
		};
		CqlInterval<CqlDateTime> b_(MedicationAdministration M) => (((context.Operators.And(context.Operators.Not((bool?)(context.Operators.Start(FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period))) is null)), context.Operators.Not((bool?)(this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept))) is null))) ?? false))
			? (context.Operators.Interval(context.Operators.Start(FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period))), context.Operators.Add(context.Operators.Start(FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period))), this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept)))), true, true))
			: ((null as CqlInterval<CqlDateTime>)));
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<MedicationAdministration, CqlInterval<CqlDateTime>>(a_, b_);
		var f_ = c_.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

		return f_;
	}


    [CqlDeclaration("CumulativeDuration")]
    public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDateTime>> Intervals)
	{
		var a_ = context.Operators;
		var b_ = a_.Collapse(Intervals, "day");
		int? c_(CqlInterval<CqlDateTime> X)
		{
			var h_ = context.Operators;
			var i_ = h_.Start(X);
			var k_ = h_.End(X);
			var m_ = h_.DifferenceBetween(i_, k_, "day");

			return m_;
		};
		var e_ = a_.SelectOrNull<CqlInterval<CqlDateTime>, int?>(b_, c_);
		var g_ = a_.Sum(e_);

		return g_;
	}


    [CqlDeclaration("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = null;
		IEnumerable<CqlInterval<CqlDateTime>> b_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
		{
			var e_ = new CqlInterval<CqlDateTime>[]
			{
				I,
			};
			CqlInterval<CqlDateTime> f_(CqlInterval<CqlDateTime> X)
			{
				var n_ = context.Operators;
				var o_ = n_.LastOfList<CqlInterval<CqlDateTime>>(R);
				var q_ = n_.End(o_);
				var s_ = n_.Quantity(1m, "day");
				var u_ = n_.Add(q_, s_);
				var w_ = n_.Start(X);
				var x_ = new CqlDateTime[]
				{
					u_,
					w_,
				};
				var z_ = n_.MaxOrNull<CqlDateTime>((x_ as IEnumerable<CqlDateTime>));
				var ab_ = n_.LastOfList<CqlInterval<CqlDateTime>>(R);
				var ad_ = n_.End(ab_);
				var af_ = n_.Quantity(1m, "day");
				var ah_ = n_.Add(ad_, af_);
				var aj_ = n_.Start(X);
				var ak_ = new CqlDateTime[]
				{
					ah_,
					aj_,
				};
				var am_ = n_.MaxOrNull<CqlDateTime>((ak_ as IEnumerable<CqlDateTime>));
				var ao_ = n_.Start(X);
				var aq_ = n_.End(X);
				var as_ = n_.DurationBetween(ao_, aq_, "day");
				var at_ = (as_ ?? (int?)0);
				var av_ = n_.ConvertIntegerToDecimal(at_);
				var aw_ = new CqlQuantity
				{
					value = av_,
					unit = "day",
				};
				var ay_ = n_.Add(am_, aw_);
				var ba_ = n_.Interval(z_, ay_, true, true);

				return ba_;
			};
			var g_ = context.Operators;
			var h_ = g_.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(e_, f_);
			var j_ = g_.SingleOrNull<CqlInterval<CqlDateTime>>(h_);
			var k_ = new CqlInterval<CqlDateTime>[]
			{
				j_,
			};
			var m_ = g_.ListUnion<CqlInterval<CqlDateTime>>(R, (k_ as IEnumerable<CqlInterval<CqlDateTime>>));

			return m_;
		};
		var c_ = context.Operators;
		var d_ = c_.AggregateOrNull<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, (a_ as IEnumerable<CqlInterval<CqlDateTime>>), b_);

		return d_;
	}


    [CqlDeclaration("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(object medication)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (((medication is MedicationRequest as bool?) ?? false))
			{
				var b_ = this.MedicationRequestPeriod((medication as MedicationRequest));

				return b_;
			}
			else if (((medication is MedicationDispense as bool?) ?? false))
			{
				var c_ = this.MedicationDispensePeriod((medication as MedicationDispense));

				return c_;
			}
			else if (((medication is MedicationAdministration as bool?) ?? false))
			{
				var d_ = this.MedicationAdministrationPeriod((medication as MedicationAdministration));

				return d_;
			}
			else
			{
				CqlInterval<CqlDateTime> e_ = null;

				return (e_ as CqlInterval<CqlDateTime>);
			}
;
		};

		return a_();
	}


    [CqlDeclaration("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(IEnumerable<object> Medications)
	{
		bool? a_(object M)
		{
			var q_ = M is MedicationRequest;

			return (q_ as bool?);
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<object>(Medications, a_);
		CqlInterval<CqlDateTime> d_(object M)
		{
			var r_ = this.MedicationPeriod(M);

			return r_;
		};
		var f_ = b_.SelectOrNull<object, CqlInterval<CqlDateTime>>(c_, d_);
		bool? g_(object M)
		{
			var s_ = M is MedicationDispense;
			var t_ = M is MedicationAdministration;
			var u_ = context.Operators;
			var v_ = u_.Or((s_ as bool?), (t_ as bool?));

			return v_;
		};
		var i_ = b_.WhereOrNull<object>(Medications, g_);
		CqlInterval<CqlDateTime> j_(object M)
		{
			var w_ = this.MedicationPeriod(M);

			return w_;
		};
		var l_ = b_.SelectOrNull<object, CqlInterval<CqlDateTime>>(i_, j_);
		var m_ = this.RolloutIntervals(l_);
		var o_ = b_.ListUnion<CqlInterval<CqlDateTime>>(f_, m_);
		var p_ = this.CumulativeDuration(o_);

		return p_;
	}


}