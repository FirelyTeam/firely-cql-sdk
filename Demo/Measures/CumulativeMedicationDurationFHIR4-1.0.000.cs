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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("ToDaily")]
	public decimal? ToDaily(int? frequency, CqlQuantity period)
	{
		decimal? a_()
		{
			if ((context.Operators.Equal(period?.unit, "h") ?? false))
			{
				var b_ = context.Operators;
				var d_ = b_.ConvertIntegerToDecimal(frequency);
				var f_ = period?.value;
				var g_ = b_.Divide((decimal?)24.0m, f_);
				var h_ = b_.Multiply(d_, g_);

				return h_;
			}
			else if ((context.Operators.Equal(period?.unit, "min") ?? false))
			{
				var i_ = context.Operators;
				var l_ = i_.ConvertIntegerToDecimal(frequency);
				var n_ = period?.value;
				var o_ = i_.Divide((decimal?)24.0m, n_);
				var p_ = i_.Multiply(l_, o_);
				var r_ = i_.ConvertIntegerToDecimal((int?)60);
				var s_ = i_.Multiply(p_, r_);

				return s_;
			}
			else if ((context.Operators.Equal(period?.unit, "s") ?? false))
			{
				var t_ = context.Operators;
				var x_ = t_.ConvertIntegerToDecimal(frequency);
				var z_ = period?.value;
				var aa_ = t_.Divide((decimal?)24.0m, z_);
				var ab_ = t_.Multiply(x_, aa_);
				var ad_ = t_.ConvertIntegerToDecimal((int?)60);
				var ae_ = t_.Multiply(ab_, ad_);
				var ag_ = t_.ConvertIntegerToDecimal((int?)60);
				var ah_ = t_.Multiply(ae_, ag_);

				return ah_;
			}
			else if ((context.Operators.Equal(period?.unit, "d") ?? false))
			{
				var ai_ = context.Operators;
				var al_ = ai_.ConvertIntegerToDecimal(frequency);
				var an_ = period?.value;
				var ao_ = ai_.Divide((decimal?)24.0m, an_);
				var ap_ = ai_.Multiply(al_, ao_);
				var ar_ = ai_.ConvertIntegerToDecimal((int?)24);
				var as_ = ai_.Divide(ap_, ar_);

				return as_;
			}
			else if ((context.Operators.Equal(period?.unit, "wk") ?? false))
			{
				var at_ = context.Operators;
				var aw_ = at_.ConvertIntegerToDecimal(frequency);
				var ay_ = period?.value;
				var az_ = at_.Divide((decimal?)24.0m, ay_);
				var ba_ = at_.Multiply(aw_, az_);
				var bd_ = at_.Multiply((int?)24, (int?)7);
				var be_ = at_.ConvertIntegerToDecimal(bd_);
				var bf_ = at_.Divide(ba_, be_);

				return bf_;
			}
			else if ((context.Operators.Equal(period?.unit, "mo") ?? false))
			{
				var bg_ = context.Operators;
				var bj_ = bg_.ConvertIntegerToDecimal(frequency);
				var bl_ = period?.value;
				var bm_ = bg_.Divide((decimal?)24.0m, bl_);
				var bn_ = bg_.Multiply(bj_, bm_);
				var bq_ = bg_.Multiply((int?)24, (int?)30);
				var br_ = bg_.ConvertIntegerToDecimal(bq_);
				var bs_ = bg_.Divide(bn_, br_);

				return bs_;
			}
			else if ((context.Operators.Equal(period?.unit, "a") ?? false))
			{
				var bt_ = context.Operators;
				var bw_ = bt_.ConvertIntegerToDecimal(frequency);
				var by_ = period?.value;
				var bz_ = bt_.Divide((decimal?)24.0m, by_);
				var ca_ = bt_.Multiply(bw_, bz_);
				var cd_ = bt_.Multiply((int?)24, (int?)365);
				var ce_ = bt_.ConvertIntegerToDecimal(cd_);
				var cf_ = bt_.Divide(ca_, ce_);

				return cf_;
			}
			else if ((context.Operators.Equal(period?.unit, "hour") ?? false))
			{
				var cg_ = context.Operators;
				var ci_ = cg_.ConvertIntegerToDecimal(frequency);
				var ck_ = period?.value;
				var cl_ = cg_.Divide((decimal?)24.0m, ck_);
				var cm_ = cg_.Multiply(ci_, cl_);

				return cm_;
			}
			else if ((context.Operators.Equal(period?.unit, "minute") ?? false))
			{
				var cn_ = context.Operators;
				var cq_ = cn_.ConvertIntegerToDecimal(frequency);
				var cs_ = period?.value;
				var ct_ = cn_.Divide((decimal?)24.0m, cs_);
				var cu_ = cn_.Multiply(cq_, ct_);
				var cw_ = cn_.ConvertIntegerToDecimal((int?)60);
				var cx_ = cn_.Multiply(cu_, cw_);

				return cx_;
			}
			else if ((context.Operators.Equal(period?.unit, "second") ?? false))
			{
				var cy_ = context.Operators;
				var dc_ = cy_.ConvertIntegerToDecimal(frequency);
				var de_ = period?.value;
				var df_ = cy_.Divide((decimal?)24.0m, de_);
				var dg_ = cy_.Multiply(dc_, df_);
				var di_ = cy_.ConvertIntegerToDecimal((int?)60);
				var dj_ = cy_.Multiply(dg_, di_);
				var dl_ = cy_.ConvertIntegerToDecimal((int?)60);
				var dm_ = cy_.Multiply(dj_, dl_);

				return dm_;
			}
			else if ((context.Operators.Equal(period?.unit, "day") ?? false))
			{
				var dn_ = context.Operators;
				var dq_ = dn_.ConvertIntegerToDecimal(frequency);
				var ds_ = period?.value;
				var dt_ = dn_.Divide((decimal?)24.0m, ds_);
				var du_ = dn_.Multiply(dq_, dt_);
				var dw_ = dn_.ConvertIntegerToDecimal((int?)24);
				var dx_ = dn_.Divide(du_, dw_);

				return dx_;
			}
			else if ((context.Operators.Equal(period?.unit, "week") ?? false))
			{
				var dy_ = context.Operators;
				var eb_ = dy_.ConvertIntegerToDecimal(frequency);
				var ed_ = period?.value;
				var ee_ = dy_.Divide((decimal?)24.0m, ed_);
				var ef_ = dy_.Multiply(eb_, ee_);
				var ei_ = dy_.Multiply((int?)24, (int?)7);
				var ej_ = dy_.ConvertIntegerToDecimal(ei_);
				var ek_ = dy_.Divide(ef_, ej_);

				return ek_;
			}
			else if ((context.Operators.Equal(period?.unit, "month") ?? false))
			{
				var el_ = context.Operators;
				var eo_ = el_.ConvertIntegerToDecimal(frequency);
				var eq_ = period?.value;
				var er_ = el_.Divide((decimal?)24.0m, eq_);
				var es_ = el_.Multiply(eo_, er_);
				var ev_ = el_.Multiply((int?)24, (int?)30);
				var ew_ = el_.ConvertIntegerToDecimal(ev_);
				var ex_ = el_.Divide(es_, ew_);

				return ex_;
			}
			else if ((context.Operators.Equal(period?.unit, "year") ?? false))
			{
				var ey_ = context.Operators;
				var fb_ = ey_.ConvertIntegerToDecimal(frequency);
				var fd_ = period?.value;
				var fe_ = ey_.Divide((decimal?)24.0m, fd_);
				var ff_ = ey_.Multiply(fb_, fe_);
				var fi_ = ey_.Multiply((int?)24, (int?)365);
				var fj_ = ey_.ConvertIntegerToDecimal(fi_);
				var fk_ = ey_.Divide(ff_, fj_);

				return fk_;
			}
			else if ((context.Operators.Equal(period?.unit, "hours") ?? false))
			{
				var fl_ = context.Operators;
				var fn_ = fl_.ConvertIntegerToDecimal(frequency);
				var fp_ = period?.value;
				var fq_ = fl_.Divide((decimal?)24.0m, fp_);
				var fr_ = fl_.Multiply(fn_, fq_);

				return fr_;
			}
			else if ((context.Operators.Equal(period?.unit, "minutes") ?? false))
			{
				var fs_ = context.Operators;
				var fv_ = fs_.ConvertIntegerToDecimal(frequency);
				var fx_ = period?.value;
				var fy_ = fs_.Divide((decimal?)24.0m, fx_);
				var fz_ = fs_.Multiply(fv_, fy_);
				var gb_ = fs_.ConvertIntegerToDecimal((int?)60);
				var gc_ = fs_.Multiply(fz_, gb_);

				return gc_;
			}
			else if ((context.Operators.Equal(period?.unit, "seconds") ?? false))
			{
				var gd_ = context.Operators;
				var gh_ = gd_.ConvertIntegerToDecimal(frequency);
				var gj_ = period?.value;
				var gk_ = gd_.Divide((decimal?)24.0m, gj_);
				var gl_ = gd_.Multiply(gh_, gk_);
				var gn_ = gd_.ConvertIntegerToDecimal((int?)60);
				var go_ = gd_.Multiply(gl_, gn_);
				var gq_ = gd_.ConvertIntegerToDecimal((int?)60);
				var gr_ = gd_.Multiply(go_, gq_);

				return gr_;
			}
			else if ((context.Operators.Equal(period?.unit, "days") ?? false))
			{
				var gs_ = context.Operators;
				var gv_ = gs_.ConvertIntegerToDecimal(frequency);
				var gx_ = period?.value;
				var gy_ = gs_.Divide((decimal?)24.0m, gx_);
				var gz_ = gs_.Multiply(gv_, gy_);
				var hb_ = gs_.ConvertIntegerToDecimal((int?)24);
				var hc_ = gs_.Divide(gz_, hb_);

				return hc_;
			}
			else if ((context.Operators.Equal(period?.unit, "weeks") ?? false))
			{
				var hd_ = context.Operators;
				var hg_ = hd_.ConvertIntegerToDecimal(frequency);
				var hi_ = period?.value;
				var hj_ = hd_.Divide((decimal?)24.0m, hi_);
				var hk_ = hd_.Multiply(hg_, hj_);
				var hn_ = hd_.Multiply((int?)24, (int?)7);
				var ho_ = hd_.ConvertIntegerToDecimal(hn_);
				var hp_ = hd_.Divide(hk_, ho_);

				return hp_;
			}
			else if ((context.Operators.Equal(period?.unit, "months") ?? false))
			{
				var hq_ = context.Operators;
				var ht_ = hq_.ConvertIntegerToDecimal(frequency);
				var hv_ = period?.value;
				var hw_ = hq_.Divide((decimal?)24.0m, hv_);
				var hx_ = hq_.Multiply(ht_, hw_);
				var ia_ = hq_.Multiply((int?)24, (int?)30);
				var ib_ = hq_.ConvertIntegerToDecimal(ia_);
				var ic_ = hq_.Divide(hx_, ib_);

				return ic_;
			}
			else if ((context.Operators.Equal(period?.unit, "years") ?? false))
			{
				var id_ = context.Operators;
				var ig_ = id_.ConvertIntegerToDecimal(frequency);
				var ii_ = period?.value;
				var ij_ = id_.Divide((decimal?)24.0m, ii_);
				var ik_ = id_.Multiply(ig_, ij_);
				var in_ = id_.Multiply((int?)24, (int?)365);
				var io_ = id_.ConvertIntegerToDecimal(in_);
				var ip_ = id_.Divide(ik_, io_);

				return ip_;
			}
			else
			{
				var iq_ = context.Operators;
				var ir_ = this.ErrorLevel();
				var it_ = ("Unknown unit " ?? "");
				var iu_ = period?.unit;
				var iv_ = (iu_ ?? "");
				var iw_ = iq_.Concatenate(it_, iv_);
				var ix_ = iq_.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", ir_, iw_);

				return (decimal?)ix_;
			};
		};

		return a_();
	}

    [CqlDeclaration("ToDaily")]
	public decimal? ToDaily(CqlCode frequency)
	{
		decimal? a_()
		{
			if ((context.Operators.Equal(frequency, this.C()) ?? false))
			{
				return (decimal?)3.0m;
			}
			else
			{
				var b_ = context.Operators;
				var c_ = this.ErrorLevel();
				var e_ = ("Unknown frequency code " ?? "");
				var f_ = frequency?.code;
				var g_ = (f_ ?? "");
				var h_ = b_.Concatenate(e_, g_);
				var i_ = b_.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", c_, h_);

				return (decimal?)i_;
			};
		};

		return a_();
	}

    [CqlDeclaration("MedicationRequestPeriod")]
	public CqlInterval<CqlDateTime> MedicationRequestPeriod(MedicationRequest Request)
	{
		var a_ = context.Operators;
		var c_ = new MedicationRequest[]
		{
			Request,
		};
		CqlInterval<CqlDateTime> d_(MedicationRequest R)
		{
			CqlInterval<CqlDateTime> g_()
			{
				if ((context.Operators.Not(context.Operators.Or((bool?)(context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))) is null), context.Operators.Equal(context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))), context.Operators.Maximum<CqlDateTime>()))) ?? false))
				{
					var h_ = context.Operators;
					var k_ = R?.DosageInstruction;
					var l_ = h_.SingleOrNull<Dosage>((k_ as IEnumerable<Dosage>));
					var m_ = l_?.Timing;
					var n_ = m_?.Repeat;
					var o_ = n_?.Bounds;
					var p_ = FHIRHelpers_4_0_001.ToInterval((o_ as Period));
					var q_ = h_.Start(p_);
					var s_ = R?.DispenseRequest;
					var t_ = s_?.ValidityPeriod;
					var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
					var v_ = h_.Start(u_);
					var w_ = (q_ ?? v_);
					var x_ = R?.AuthoredOnElement;
					var y_ = FHIRHelpers_4_0_001.ToDateTime(x_);
					var z_ = (w_ ?? y_);
					var ad_ = h_.SingleOrNull<Dosage>((k_ as IEnumerable<Dosage>));
					var ae_ = ad_?.Timing;
					var af_ = ae_?.Repeat;
					var ag_ = af_?.Bounds;
					var ah_ = FHIRHelpers_4_0_001.ToInterval((ag_ as Period));
					var ai_ = h_.End(ah_);
					var aj_ = h_.Interval(z_, ai_, true, true);

					return aj_;
				}
				else
				{
					var ak_ = context.Operators;
					var an_ = R?.DosageInstruction;
					var ao_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var ap_ = ao_?.Timing;
					var aq_ = ap_?.Repeat;
					var ar_ = aq_?.Bounds;
					var as_ = FHIRHelpers_4_0_001.ToInterval((ar_ as Period));
					var at_ = ak_.Start(as_);
					var av_ = R?.DispenseRequest;
					var aw_ = av_?.ValidityPeriod;
					var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
					var ay_ = ak_.Start(ax_);
					var az_ = (at_ ?? ay_);
					var ba_ = R?.AuthoredOnElement;
					var bb_ = FHIRHelpers_4_0_001.ToDateTime(ba_);
					var bc_ = (az_ ?? bb_);
					var bh_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var bi_ = bh_?.Timing;
					var bj_ = bi_?.Repeat;
					var bk_ = bj_?.Bounds;
					var bl_ = FHIRHelpers_4_0_001.ToInterval((bk_ as Period));
					var bm_ = ak_.Start(bl_);
					var bp_ = av_?.ValidityPeriod;
					var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
					var br_ = ak_.Start(bq_);
					var bs_ = (bm_ ?? br_);
					var bu_ = FHIRHelpers_4_0_001.ToDateTime(ba_);
					var bv_ = (bs_ ?? bu_);
					var by_ = av_?.ExpectedSupplyDuration;
					var bz_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)by_);
					var cc_ = av_?.Quantity;
					var cd_ = FHIRHelpers_4_0_001.ToQuantity(cc_);
					var cj_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var ck_ = cj_?.DoseAndRate;
					var cl_ = ak_.SingleOrNull<Dosage.DoseAndRateComponent>((ck_ as IEnumerable<Dosage.DoseAndRateComponent>));
					var cm_ = cl_?.Dose;
					var cn_ = FHIRHelpers_4_0_001.ToInterval((cm_ as Range));
					var co_ = ak_.End(cn_);
					var cs_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var ct_ = cs_?.DoseAndRate;
					var cu_ = ak_.SingleOrNull<Dosage.DoseAndRateComponent>((ct_ as IEnumerable<Dosage.DoseAndRateComponent>));
					var cv_ = cu_?.Dose;
					var cw_ = FHIRHelpers_4_0_001.ToQuantity((cv_ as Quantity));
					var cx_ = (co_ ?? cw_);
					var da_ = ak_.TypeConverter;
					var dd_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var de_ = dd_?.Timing;
					var df_ = de_?.Repeat;
					var dg_ = df_?.FrequencyMaxElement;
					var dh_ = da_.Convert<Integer>(dg_);
					var dj_ = ak_.TypeConverter;
					var dm_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var dn_ = dm_?.Timing;
					var do_ = dn_?.Repeat;
					var dp_ = do_?.FrequencyElement;
					var dq_ = dj_.Convert<Integer>(dp_);
					var dr_ = (dh_ ?? dq_);
					var ds_ = FHIRHelpers_4_0_001.ToInteger(dr_);
					var dv_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var dw_ = dv_?.Timing;
					var dx_ = dw_?.Repeat;
					var dy_ = dx_?.PeriodElement;
					var dz_ = FHIRHelpers_4_0_001.ToDecimal(dy_);
					var eb_ = ak_.TypeConverter;
					var ee_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var ef_ = ee_?.Timing;
					var eg_ = ef_?.Repeat;
					var eh_ = eg_?.PeriodUnitElement;
					var ei_ = eh_?.Value;
					var ej_ = eb_.Convert<string>(ei_);
					var ek_ = new CqlQuantity
					{
						value = dz_,
						unit = ej_,
					};
					var el_ = this.ToDaily(ds_, ek_);
					var eq_ = ak_.SingleOrNull<Dosage>((an_ as IEnumerable<Dosage>));
					var er_ = eq_?.Timing;
					var es_ = er_?.Repeat;
					var et_ = es_?.TimeOfDayElement;
					var eu_ = ak_.CountOrNull<Time>((et_ as IEnumerable<Time>));
					var ev_ = ak_.ConvertIntegerToDecimal(eu_);
					var ew_ = (el_ ?? ev_);
					var ex_ = (ew_ ?? (decimal?)1.0m);
					var ey_ = ak_.ConvertDecimalToQuantity(ex_);
					var ez_ = ak_.Multiply(cx_, ey_);
					var fa_ = ak_.Divide(cd_, ez_);
					var fb_ = (bz_ ?? fa_);
					var ff_ = ak_.TypeConverter;
					var fh_ = av_?.NumberOfRepeatsAllowedElement;
					var fi_ = ff_.Convert<Integer>(fh_);
					var fj_ = FHIRHelpers_4_0_001.ToInteger(fi_);
					var fk_ = (fj_ ?? (int?)0);
					var fl_ = ak_.Add((int?)1, fk_);
					var fm_ = ak_.ConvertIntegerToQuantity(fl_);
					var fn_ = ak_.Multiply(fb_, fm_);
					var fo_ = ak_.Add(bv_, fn_);
					var fp_ = ak_.Interval(bc_, fo_, true, true);

					return fp_;
				};
			};

			return g_();
		};
		var e_ = a_.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(c_, d_);
		var f_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(e_);

		return f_;
	}

    [CqlDeclaration("MedicationDispensePeriod")]
	public CqlInterval<CqlDateTime> MedicationDispensePeriod(MedicationDispense Dispense)
	{
		var a_ = context.Operators;
		var c_ = new MedicationDispense[]
		{
			Dispense,
		};
		CqlInterval<CqlDateTime> d_(MedicationDispense D)
		{
			var g_ = context.Operators;
			var h_ = D?.WhenHandedOverElement;
			var i_ = D?.WhenPreparedElement;
			var j_ = (h_ ?? i_);
			var k_ = FHIRHelpers_4_0_001.ToDateTime(j_);
			var o_ = (h_ ?? i_);
			var p_ = FHIRHelpers_4_0_001.ToDateTime(o_);
			var q_ = D?.DaysSupply;
			var r_ = FHIRHelpers_4_0_001.ToQuantity(q_);
			var t_ = D?.Quantity;
			var u_ = FHIRHelpers_4_0_001.ToQuantity(t_);
			var z_ = D?.DosageInstruction;
			var aa_ = g_.SingleOrNull<Dosage>((z_ as IEnumerable<Dosage>));
			var ab_ = aa_?.DoseAndRate;
			var ac_ = g_.SingleOrNull<Dosage.DoseAndRateComponent>((ab_ as IEnumerable<Dosage.DoseAndRateComponent>));
			var ad_ = ac_?.Dose;
			var ae_ = FHIRHelpers_4_0_001.ToInterval((ad_ as Range));
			var af_ = g_.End(ae_);
			var aj_ = g_.SingleOrNull<Dosage>((z_ as IEnumerable<Dosage>));
			var ak_ = aj_?.DoseAndRate;
			var al_ = g_.SingleOrNull<Dosage.DoseAndRateComponent>((ak_ as IEnumerable<Dosage.DoseAndRateComponent>));
			var am_ = al_?.Dose;
			var an_ = FHIRHelpers_4_0_001.ToQuantity((am_ as Quantity));
			var ao_ = (af_ ?? an_);
			var ar_ = g_.TypeConverter;
			var au_ = g_.SingleOrNull<Dosage>((z_ as IEnumerable<Dosage>));
			var av_ = au_?.Timing;
			var aw_ = av_?.Repeat;
			var ax_ = aw_?.FrequencyMaxElement;
			var ay_ = ar_.Convert<Integer>(ax_);
			var ba_ = g_.TypeConverter;
			var bd_ = g_.SingleOrNull<Dosage>((z_ as IEnumerable<Dosage>));
			var be_ = bd_?.Timing;
			var bf_ = be_?.Repeat;
			var bg_ = bf_?.FrequencyElement;
			var bh_ = ba_.Convert<Integer>(bg_);
			var bi_ = (ay_ ?? bh_);
			var bj_ = FHIRHelpers_4_0_001.ToInteger(bi_);
			var bm_ = g_.SingleOrNull<Dosage>((z_ as IEnumerable<Dosage>));
			var bn_ = bm_?.Timing;
			var bo_ = bn_?.Repeat;
			var bp_ = bo_?.PeriodElement;
			var bq_ = FHIRHelpers_4_0_001.ToDecimal(bp_);
			var bs_ = g_.TypeConverter;
			var bv_ = g_.SingleOrNull<Dosage>((z_ as IEnumerable<Dosage>));
			var bw_ = bv_?.Timing;
			var bx_ = bw_?.Repeat;
			var by_ = bx_?.PeriodUnitElement;
			var bz_ = by_?.Value;
			var ca_ = bs_.Convert<string>(bz_);
			var cb_ = new CqlQuantity
			{
				value = bq_,
				unit = ca_,
			};
			var cc_ = this.ToDaily(bj_, cb_);
			var ch_ = g_.SingleOrNull<Dosage>((z_ as IEnumerable<Dosage>));
			var ci_ = ch_?.Timing;
			var cj_ = ci_?.Repeat;
			var ck_ = cj_?.TimeOfDayElement;
			var cl_ = g_.CountOrNull<Time>((ck_ as IEnumerable<Time>));
			var cm_ = g_.ConvertIntegerToDecimal(cl_);
			var cn_ = (cc_ ?? cm_);
			var co_ = (cn_ ?? (decimal?)1.0m);
			var cp_ = g_.ConvertDecimalToQuantity(co_);
			var cq_ = g_.Multiply(ao_, cp_);
			var cr_ = g_.Divide(u_, cq_);
			var cs_ = (r_ ?? cr_);
			var ct_ = g_.Add(p_, cs_);
			var cu_ = g_.Interval(k_, ct_, true, true);

			return cu_;
		};
		var e_ = a_.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(c_, d_);
		var f_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(e_);

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
		var a_ = context.Operators;
		var c_ = new MedicationAdministration[]
		{
			Administration,
		};
		CqlInterval<CqlDateTime> d_(MedicationAdministration M)
		{
			CqlInterval<CqlDateTime> g_()
			{
				if ((context.Operators.And(context.Operators.Not((bool?)(context.Operators.Start(FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period))) is null)), context.Operators.Not((bool?)(this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept))) is null))) ?? false))
				{
					var h_ = context.Operators;
					var j_ = Administration?.Effective;
					var k_ = FHIRHelpers_4_0_001.ToInterval((j_ as Period));
					var l_ = h_.Start(k_);
					var p_ = FHIRHelpers_4_0_001.ToInterval((j_ as Period));
					var q_ = h_.Start(p_);
					var r_ = Administration?.Medication;
					var s_ = FHIRHelpers_4_0_001.ToConcept((r_ as CodeableConcept));
					var t_ = this.TherapeuticDuration(s_);
					var u_ = h_.Add(q_, t_);
					var v_ = h_.Interval(l_, u_, true, true);

					return v_;
				}
				else
				{
					CqlInterval<CqlDateTime> w_ = null;

					return (w_ as CqlInterval<CqlDateTime>);
				};
			};

			return g_();
		};
		var e_ = a_.SelectOrNull<MedicationAdministration, CqlInterval<CqlDateTime>>(c_, d_);
		var f_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(e_);

		return f_;
	}

    [CqlDeclaration("CumulativeDuration")]
	public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDateTime>> Intervals)
	{
		var a_ = context.Operators;
		var d_ = a_.Collapse(Intervals, "day");
		int? e_(CqlInterval<CqlDateTime> X)
		{
			var h_ = context.Operators;
			var j_ = h_.Start(X);
			var l_ = h_.End(X);
			var m_ = h_.DifferenceBetween(j_, l_, "day");

			return m_;
		};
		var f_ = a_.SelectOrNull<CqlInterval<CqlDateTime>, int?>(d_, e_);
		var g_ = a_.Sum(f_);

		return g_;
	}

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		var a_ = context.Operators;
		IEnumerable<CqlInterval<CqlDateTime>> b_ = null;
		IEnumerable<CqlInterval<CqlDateTime>> c_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
		{
			var e_ = context.Operators;
			var h_ = new CqlInterval<CqlDateTime>[]
			{
				I,
			};
			CqlInterval<CqlDateTime> i_(CqlInterval<CqlDateTime> X)
			{
				var n_ = context.Operators;
				var s_ = n_.LastOfList<CqlInterval<CqlDateTime>>(R);
				var t_ = n_.End(s_);
				var v_ = n_.Quantity(1m, "day");
				var w_ = n_.Add(t_, v_);
				var y_ = n_.Start(X);
				var z_ = new CqlDateTime[]
				{
					w_,
					y_,
				};
				var aa_ = n_.MaxOrNull<CqlDateTime>((z_ as IEnumerable<CqlDateTime>));
				var ag_ = n_.LastOfList<CqlInterval<CqlDateTime>>(R);
				var ah_ = n_.End(ag_);
				var aj_ = n_.Quantity(1m, "day");
				var ak_ = n_.Add(ah_, aj_);
				var am_ = n_.Start(X);
				var an_ = new CqlDateTime[]
				{
					ak_,
					am_,
				};
				var ao_ = n_.MaxOrNull<CqlDateTime>((an_ as IEnumerable<CqlDateTime>));
				var as_ = n_.Start(X);
				var au_ = n_.End(X);
				var av_ = n_.DurationBetween(as_, au_, "day");
				var aw_ = (av_ ?? (int?)0);
				var ax_ = n_.ConvertIntegerToDecimal(aw_);
				var ay_ = new CqlQuantity
				{
					value = ax_,
					unit = "day",
				};
				var az_ = n_.Add(ao_, ay_);
				var ba_ = n_.Interval(aa_, az_, true, true);

				return ba_;
			};
			var j_ = e_.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(h_, i_);
			var k_ = e_.SingleOrNull<CqlInterval<CqlDateTime>>(j_);
			var l_ = new CqlInterval<CqlDateTime>[]
			{
				k_,
			};
			var m_ = e_.ListUnion<CqlInterval<CqlDateTime>>(R, (l_ as IEnumerable<CqlInterval<CqlDateTime>>));

			return m_;
		};
		var d_ = a_.AggregateOrNull<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, (b_ as IEnumerable<CqlInterval<CqlDateTime>>), c_);

		return d_;
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
				CqlInterval<CqlDateTime> e_ = null;

				return (e_ as CqlInterval<CqlDateTime>);
			};
		};

		return a_();
	}

    [CqlDeclaration("CumulativeMedicationDuration")]
	public int? CumulativeMedicationDuration(IEnumerable<object> Medications)
	{
		var a_ = context.Operators;
		bool? d_(object M)
		{
			var q_ = M is MedicationRequest;

			return (q_ as bool?);
		};
		var e_ = a_.WhereOrNull<object>(Medications, d_);
		CqlInterval<CqlDateTime> f_(object M)
		{
			var r_ = this.MedicationPeriod(M);

			return r_;
		};
		var g_ = a_.SelectOrNull<object, CqlInterval<CqlDateTime>>(e_, f_);
		bool? j_(object M)
		{
			var s_ = context.Operators;
			var t_ = M is MedicationDispense;
			var u_ = M is MedicationAdministration;
			var v_ = s_.Or((t_ as bool?), (u_ as bool?));

			return v_;
		};
		var k_ = a_.WhereOrNull<object>(Medications, j_);
		CqlInterval<CqlDateTime> l_(object M)
		{
			var w_ = this.MedicationPeriod(M);

			return w_;
		};
		var m_ = a_.SelectOrNull<object, CqlInterval<CqlDateTime>>(k_, l_);
		var n_ = this.RolloutIntervals(m_);
		var o_ = a_.ListUnion<CqlInterval<CqlDateTime>>(g_, n_);
		var p_ = this.CumulativeDuration(o_);

		return p_;
	}

}