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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			if ((context.Operators.Equal(period?.unit, "h") ?? false))
			{
				var b_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var c_ = period?.value;
				var d_ = context.Operators.Divide((decimal?)24.0m, c_);
				var e_ = context.Operators.Multiply(b_, d_);

				return e_;
			}
			else if ((context.Operators.Equal(period?.unit, "min") ?? false))
			{
				var f_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var g_ = period?.value;
				var h_ = context.Operators.Divide((decimal?)24.0m, g_);
				var i_ = context.Operators.Multiply(f_, h_);
				var j_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var k_ = context.Operators.Multiply(i_, j_);

				return k_;
			}
			else if ((context.Operators.Equal(period?.unit, "s") ?? false))
			{
				var l_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var m_ = period?.value;
				var n_ = context.Operators.Divide((decimal?)24.0m, m_);
				var o_ = context.Operators.Multiply(l_, n_);
				var p_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var q_ = context.Operators.Multiply(o_, p_);
				var s_ = context.Operators.Multiply(q_, p_);

				return s_;
			}
			else if ((context.Operators.Equal(period?.unit, "d") ?? false))
			{
				var t_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var u_ = period?.value;
				var v_ = context.Operators.Divide((decimal?)24.0m, u_);
				var w_ = context.Operators.Multiply(t_, v_);
				var x_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var y_ = context.Operators.Divide(w_, x_);

				return y_;
			}
			else if ((context.Operators.Equal(period?.unit, "wk") ?? false))
			{
				var z_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var aa_ = period?.value;
				var ab_ = context.Operators.Divide((decimal?)24.0m, aa_);
				var ac_ = context.Operators.Multiply(z_, ab_);
				var ad_ = context.Operators.Multiply((int?)24, (int?)7);
				var ae_ = context.Operators.ConvertIntegerToDecimal(ad_);
				var af_ = context.Operators.Divide(ac_, ae_);

				return af_;
			}
			else if ((context.Operators.Equal(period?.unit, "mo") ?? false))
			{
				var ag_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ah_ = period?.value;
				var ai_ = context.Operators.Divide((decimal?)24.0m, ah_);
				var aj_ = context.Operators.Multiply(ag_, ai_);
				var ak_ = context.Operators.Multiply((int?)24, (int?)30);
				var al_ = context.Operators.ConvertIntegerToDecimal(ak_);
				var am_ = context.Operators.Divide(aj_, al_);

				return am_;
			}
			else if ((context.Operators.Equal(period?.unit, "a") ?? false))
			{
				var an_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ao_ = period?.value;
				var ap_ = context.Operators.Divide((decimal?)24.0m, ao_);
				var aq_ = context.Operators.Multiply(an_, ap_);
				var ar_ = context.Operators.Multiply((int?)24, (int?)365);
				var as_ = context.Operators.ConvertIntegerToDecimal(ar_);
				var at_ = context.Operators.Divide(aq_, as_);

				return at_;
			}
			else if ((context.Operators.Equal(period?.unit, "hour") ?? false))
			{
				var au_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var av_ = period?.value;
				var aw_ = context.Operators.Divide((decimal?)24.0m, av_);
				var ax_ = context.Operators.Multiply(au_, aw_);

				return ax_;
			}
			else if ((context.Operators.Equal(period?.unit, "minute") ?? false))
			{
				var ay_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var az_ = period?.value;
				var ba_ = context.Operators.Divide((decimal?)24.0m, az_);
				var bb_ = context.Operators.Multiply(ay_, ba_);
				var bc_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var bd_ = context.Operators.Multiply(bb_, bc_);

				return bd_;
			}
			else if ((context.Operators.Equal(period?.unit, "second") ?? false))
			{
				var be_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bf_ = period?.value;
				var bg_ = context.Operators.Divide((decimal?)24.0m, bf_);
				var bh_ = context.Operators.Multiply(be_, bg_);
				var bi_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var bj_ = context.Operators.Multiply(bh_, bi_);
				var bl_ = context.Operators.Multiply(bj_, bi_);

				return bl_;
			}
			else if ((context.Operators.Equal(period?.unit, "day") ?? false))
			{
				var bm_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bn_ = period?.value;
				var bo_ = context.Operators.Divide((decimal?)24.0m, bn_);
				var bp_ = context.Operators.Multiply(bm_, bo_);
				var bq_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var br_ = context.Operators.Divide(bp_, bq_);

				return br_;
			}
			else if ((context.Operators.Equal(period?.unit, "week") ?? false))
			{
				var bs_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bt_ = period?.value;
				var bu_ = context.Operators.Divide((decimal?)24.0m, bt_);
				var bv_ = context.Operators.Multiply(bs_, bu_);
				var bw_ = context.Operators.Multiply((int?)24, (int?)7);
				var bx_ = context.Operators.ConvertIntegerToDecimal(bw_);
				var by_ = context.Operators.Divide(bv_, bx_);

				return by_;
			}
			else if ((context.Operators.Equal(period?.unit, "month") ?? false))
			{
				var bz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ca_ = period?.value;
				var cb_ = context.Operators.Divide((decimal?)24.0m, ca_);
				var cc_ = context.Operators.Multiply(bz_, cb_);
				var cd_ = context.Operators.Multiply((int?)24, (int?)30);
				var ce_ = context.Operators.ConvertIntegerToDecimal(cd_);
				var cf_ = context.Operators.Divide(cc_, ce_);

				return cf_;
			}
			else if ((context.Operators.Equal(period?.unit, "year") ?? false))
			{
				var cg_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ch_ = period?.value;
				var ci_ = context.Operators.Divide((decimal?)24.0m, ch_);
				var cj_ = context.Operators.Multiply(cg_, ci_);
				var ck_ = context.Operators.Multiply((int?)24, (int?)365);
				var cl_ = context.Operators.ConvertIntegerToDecimal(ck_);
				var cm_ = context.Operators.Divide(cj_, cl_);

				return cm_;
			}
			else if ((context.Operators.Equal(period?.unit, "hours") ?? false))
			{
				var cn_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var co_ = period?.value;
				var cp_ = context.Operators.Divide((decimal?)24.0m, co_);
				var cq_ = context.Operators.Multiply(cn_, cp_);

				return cq_;
			}
			else if ((context.Operators.Equal(period?.unit, "minutes") ?? false))
			{
				var cr_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cs_ = period?.value;
				var ct_ = context.Operators.Divide((decimal?)24.0m, cs_);
				var cu_ = context.Operators.Multiply(cr_, ct_);
				var cv_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var cw_ = context.Operators.Multiply(cu_, cv_);

				return cw_;
			}
			else if ((context.Operators.Equal(period?.unit, "seconds") ?? false))
			{
				var cx_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cy_ = period?.value;
				var cz_ = context.Operators.Divide((decimal?)24.0m, cy_);
				var da_ = context.Operators.Multiply(cx_, cz_);
				var db_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var dc_ = context.Operators.Multiply(da_, db_);
				var de_ = context.Operators.Multiply(dc_, db_);

				return de_;
			}
			else if ((context.Operators.Equal(period?.unit, "days") ?? false))
			{
				var df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dg_ = period?.value;
				var dh_ = context.Operators.Divide((decimal?)24.0m, dg_);
				var di_ = context.Operators.Multiply(df_, dh_);
				var dj_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var dk_ = context.Operators.Divide(di_, dj_);

				return dk_;
			}
			else if ((context.Operators.Equal(period?.unit, "weeks") ?? false))
			{
				var dl_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dm_ = period?.value;
				var dn_ = context.Operators.Divide((decimal?)24.0m, dm_);
				var do_ = context.Operators.Multiply(dl_, dn_);
				var dp_ = context.Operators.Multiply((int?)24, (int?)7);
				var dq_ = context.Operators.ConvertIntegerToDecimal(dp_);
				var dr_ = context.Operators.Divide(do_, dq_);

				return dr_;
			}
			else if ((context.Operators.Equal(period?.unit, "months") ?? false))
			{
				var ds_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dt_ = period?.value;
				var du_ = context.Operators.Divide((decimal?)24.0m, dt_);
				var dv_ = context.Operators.Multiply(ds_, du_);
				var dw_ = context.Operators.Multiply((int?)24, (int?)30);
				var dx_ = context.Operators.ConvertIntegerToDecimal(dw_);
				var dy_ = context.Operators.Divide(dv_, dx_);

				return dy_;
			}
			else if ((context.Operators.Equal(period?.unit, "years") ?? false))
			{
				var dz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ea_ = period?.value;
				var eb_ = context.Operators.Divide((decimal?)24.0m, ea_);
				var ec_ = context.Operators.Multiply(dz_, eb_);
				var ed_ = context.Operators.Multiply((int?)24, (int?)365);
				var ee_ = context.Operators.ConvertIntegerToDecimal(ed_);
				var ef_ = context.Operators.Divide(ec_, ee_);

				return ef_;
			}
			else
			{
				var eg_ = this.ErrorLevel();
				var eh_ = period?.unit;
				var ei_ = context.Operators.Concatenate("Unknown unit ", (eh_ ?? ""));
				var ej_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", eg_, ei_);

				return (decimal?)ej_;
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
				var b_ = this.ErrorLevel();
				var c_ = frequency?.code;
				var d_ = context.Operators.Concatenate("Unknown frequency code ", (c_ ?? ""));
				var e_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", b_, d_);

				return (decimal?)e_;
			};
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
				if ((context.Operators.Not(context.Operators.Or((bool?)(context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))) is null), context.Operators.Equal(context.Operators.End(FHIRHelpers_4_0_001.ToInterval(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as Period))), context.Operators.Maximum<CqlDateTime>()))) ?? false))
				{
					var f_ = R?.DosageInstruction;
					var g_ = context.Operators.SingleOrNull<Dosage>((f_ as IEnumerable<Dosage>));
					var h_ = g_?.Timing;
					var i_ = h_?.Repeat;
					var j_ = i_?.Bounds;
					var k_ = FHIRHelpers_4_0_001.ToInterval((j_ as Period));
					var l_ = context.Operators.Start(k_);
					var m_ = R?.DispenseRequest;
					var n_ = m_?.ValidityPeriod;
					var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
					var p_ = context.Operators.Start(o_);
					var q_ = R?.AuthoredOnElement;
					var r_ = FHIRHelpers_4_0_001.ToDateTime(q_);
					var t_ = context.Operators.SingleOrNull<Dosage>((f_ as IEnumerable<Dosage>));
					var u_ = t_?.Timing;
					var v_ = u_?.Repeat;
					var w_ = v_?.Bounds;
					var x_ = FHIRHelpers_4_0_001.ToInterval((w_ as Period));
					var y_ = context.Operators.End(x_);
					var z_ = context.Operators.Interval(((l_ ?? p_) ?? r_), y_, true, true);

					return z_;
				}
				else
				{
					var aa_ = R?.DosageInstruction;
					var ab_ = context.Operators.SingleOrNull<Dosage>((aa_ as IEnumerable<Dosage>));
					var ac_ = ab_?.Timing;
					var ad_ = ac_?.Repeat;
					var ae_ = ad_?.Bounds;
					var af_ = FHIRHelpers_4_0_001.ToInterval((ae_ as Period));
					var ag_ = context.Operators.Start(af_);
					var ah_ = R?.DispenseRequest;
					var ai_ = ah_?.ValidityPeriod;
					var aj_ = FHIRHelpers_4_0_001.ToInterval(ai_);
					var ak_ = context.Operators.Start(aj_);
					var al_ = R?.AuthoredOnElement;
					var am_ = FHIRHelpers_4_0_001.ToDateTime(al_);
					var ao_ = context.Operators.SingleOrNull<Dosage>((aa_ as IEnumerable<Dosage>));
					var ap_ = ao_?.Timing;
					var aq_ = ap_?.Repeat;
					var ar_ = aq_?.Bounds;
					var as_ = FHIRHelpers_4_0_001.ToInterval((ar_ as Period));
					var at_ = context.Operators.Start(as_);
					var av_ = ah_?.ValidityPeriod;
					var aw_ = FHIRHelpers_4_0_001.ToInterval(av_);
					var ax_ = context.Operators.Start(aw_);
					var az_ = FHIRHelpers_4_0_001.ToDateTime(al_);
					var bb_ = ah_?.ExpectedSupplyDuration;
					var bc_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)bb_);
					var be_ = ah_?.Quantity;
					var bf_ = FHIRHelpers_4_0_001.ToQuantity(be_);
					var bh_ = context.Operators.SingleOrNull<Dosage>((aa_ as IEnumerable<Dosage>));
					var bi_ = bh_?.DoseAndRate;
					var bj_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((bi_ as IEnumerable<Dosage.DoseAndRateComponent>));
					var bk_ = bj_?.Dose;
					var bl_ = FHIRHelpers_4_0_001.ToInterval((bk_ as Range));
					var bm_ = context.Operators.End(bl_);
					var bo_ = context.Operators.SingleOrNull<Dosage>((aa_ as IEnumerable<Dosage>));
					var bp_ = bo_?.DoseAndRate;
					var bq_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((bp_ as IEnumerable<Dosage.DoseAndRateComponent>));
					var br_ = bq_?.Dose;
					var bs_ = FHIRHelpers_4_0_001.ToQuantity((br_ as Quantity));
					var bu_ = context.Operators.SingleOrNull<Dosage>((aa_ as IEnumerable<Dosage>));
					var bv_ = bu_?.Timing;
					var bw_ = bv_?.Repeat;
					var bx_ = bw_?.FrequencyMaxElement;
					var by_ = context.Operators.Convert<Integer>(bx_);
					var ca_ = context.Operators.SingleOrNull<Dosage>((aa_ as IEnumerable<Dosage>));
					var cb_ = ca_?.Timing;
					var cc_ = cb_?.Repeat;
					var cd_ = cc_?.FrequencyElement;
					var ce_ = context.Operators.Convert<Integer>(cd_);
					var cf_ = FHIRHelpers_4_0_001.ToInteger((by_ ?? ce_));
					var cg_ = this.ToDaily(cf_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodElement), context.Operators.Convert<string>(((((context.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodUnitElement)?.Value)));
					var ci_ = context.Operators.SingleOrNull<Dosage>((aa_ as IEnumerable<Dosage>));
					var cj_ = ci_?.Timing;
					var ck_ = cj_?.Repeat;
					var cl_ = ck_?.TimeOfDayElement;
					var cm_ = context.Operators.CountOrNull<Time>((cl_ as IEnumerable<Time>));
					var cn_ = context.Operators.ConvertIntegerToDecimal(cm_);
					var co_ = context.Operators.ConvertDecimalToQuantity(((cg_ ?? cn_) ?? (decimal?)1.0m));
					var cp_ = context.Operators.Multiply((bm_ ?? bs_), co_);
					var cq_ = context.Operators.Divide(bf_, cp_);
					var cs_ = ah_?.NumberOfRepeatsAllowedElement;
					var ct_ = context.Operators.Convert<Integer>(cs_);
					var cu_ = FHIRHelpers_4_0_001.ToInteger(ct_);
					var cv_ = context.Operators.Add((int?)1, (cu_ ?? (int?)0));
					var cw_ = context.Operators.ConvertIntegerToQuantity(cv_);
					var cx_ = context.Operators.Multiply((bc_ ?? cq_), cw_);
					var cy_ = context.Operators.Add(((at_ ?? ax_) ?? az_), cx_);
					var cz_ = context.Operators.Interval(((ag_ ?? ak_) ?? am_), cy_, true, true);

					return cz_;
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
			var p_ = context.Operators.SingleOrNull<Dosage>((o_ as IEnumerable<Dosage>));
			var q_ = p_?.DoseAndRate;
			var r_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((q_ as IEnumerable<Dosage.DoseAndRateComponent>));
			var s_ = r_?.Dose;
			var t_ = FHIRHelpers_4_0_001.ToInterval((s_ as Range));
			var u_ = context.Operators.End(t_);
			var w_ = context.Operators.SingleOrNull<Dosage>((o_ as IEnumerable<Dosage>));
			var x_ = w_?.DoseAndRate;
			var y_ = context.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((x_ as IEnumerable<Dosage.DoseAndRateComponent>));
			var z_ = y_?.Dose;
			var aa_ = FHIRHelpers_4_0_001.ToQuantity((z_ as Quantity));
			var ac_ = context.Operators.SingleOrNull<Dosage>((o_ as IEnumerable<Dosage>));
			var ad_ = ac_?.Timing;
			var ae_ = ad_?.Repeat;
			var af_ = ae_?.FrequencyMaxElement;
			var ag_ = context.Operators.Convert<Integer>(af_);
			var ai_ = context.Operators.SingleOrNull<Dosage>((o_ as IEnumerable<Dosage>));
			var aj_ = ai_?.Timing;
			var ak_ = aj_?.Repeat;
			var al_ = ak_?.FrequencyElement;
			var am_ = context.Operators.Convert<Integer>(al_);
			var an_ = FHIRHelpers_4_0_001.ToInteger((ag_ ?? am_));
			var ao_ = this.ToDaily(an_, new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal((((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodElement), context.Operators.Convert<string>(((((context.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodUnitElement)?.Value)));
			var aq_ = context.Operators.SingleOrNull<Dosage>((o_ as IEnumerable<Dosage>));
			var ar_ = aq_?.Timing;
			var as_ = ar_?.Repeat;
			var at_ = as_?.TimeOfDayElement;
			var au_ = context.Operators.CountOrNull<Time>((at_ as IEnumerable<Time>));
			var av_ = context.Operators.ConvertIntegerToDecimal(au_);
			var aw_ = context.Operators.ConvertDecimalToQuantity(((ao_ ?? av_) ?? (decimal?)1.0m));
			var ax_ = context.Operators.Multiply((u_ ?? aa_), aw_);
			var ay_ = context.Operators.Divide(n_, ax_);
			var az_ = context.Operators.Add(j_, (l_ ?? ay_));
			var ba_ = context.Operators.Interval(g_, az_, true, true);

			return ba_;
		};
		var c_ = context.Operators.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
				if ((context.Operators.And(context.Operators.Not((bool?)(context.Operators.Start(FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period))) is null)), context.Operators.Not((bool?)(this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept))) is null))) ?? false))
				{
					var f_ = Administration?.Effective;
					var g_ = FHIRHelpers_4_0_001.ToInterval((f_ as Period));
					var h_ = context.Operators.Start(g_);
					var j_ = FHIRHelpers_4_0_001.ToInterval((f_ as Period));
					var k_ = context.Operators.Start(j_);
					var l_ = Administration?.Medication;
					var m_ = FHIRHelpers_4_0_001.ToConcept((l_ as CodeableConcept));
					var n_ = this.TherapeuticDuration(m_);
					var o_ = context.Operators.Add(k_, n_);
					var p_ = context.Operators.Interval(h_, o_, true, true);

					return p_;
				}
				else
				{
					CqlInterval<CqlDateTime> q_ = null;

					return (q_ as CqlInterval<CqlDateTime>);
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationAdministration, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

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
		var c_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(a_, b_);
		var d_ = context.Operators.Sum(c_);

		return d_;
	}

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = null;
		IEnumerable<CqlInterval<CqlDateTime>> b_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
		{
			var d_ = new CqlInterval<CqlDateTime>[]
			{
				I,
			};
			CqlInterval<CqlDateTime> e_(CqlInterval<CqlDateTime> X)
			{
				var j_ = context.Operators.LastOfList<CqlInterval<CqlDateTime>>(R);
				var k_ = context.Operators.End(j_);
				var l_ = context.Operators.Quantity(1m, "day");
				var m_ = context.Operators.Add(k_, l_);
				var n_ = context.Operators.Start(X);
				var o_ = new CqlDateTime[]
				{
					m_,
					n_,
				};
				var p_ = context.Operators.MaxOrNull<CqlDateTime>((o_ as IEnumerable<CqlDateTime>));
				var r_ = context.Operators.End(j_);
				var t_ = context.Operators.Add(r_, l_);
				var v_ = new CqlDateTime[]
				{
					t_,
					n_,
				};
				var w_ = context.Operators.MaxOrNull<CqlDateTime>((v_ as IEnumerable<CqlDateTime>));
				var x_ = context.Operators.Add(w_, new CqlQuantity(context.Operators.ConvertIntegerToDecimal((context.Operators.DurationBetween(context.Operators.Start(X), context.Operators.End(X), "day") ?? (int?)0)), "day"));
				var y_ = context.Operators.Interval(p_, x_, true, true);

				return y_;
			};
			var f_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
			var g_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(f_);
			var h_ = new CqlInterval<CqlDateTime>[]
			{
				g_,
			};
			var i_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(R, (h_ as IEnumerable<CqlInterval<CqlDateTime>>));

			return i_;
		};
		var c_ = context.Operators.AggregateOrNull<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, (a_ as IEnumerable<CqlInterval<CqlDateTime>>), b_);

		return c_;
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
		bool? a_(object M)
		{
			var l_ = M is MedicationRequest;

			return (l_ as bool?);
		};
		var b_ = context.Operators.WhereOrNull<object>(Medications, a_);
		CqlInterval<CqlDateTime> c_(object M)
		{
			var m_ = this.MedicationPeriod(M);

			return m_;
		};
		var d_ = context.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(b_, c_);
		bool? e_(object M)
		{
			var n_ = M is MedicationDispense;
			var o_ = M is MedicationAdministration;
			var p_ = context.Operators.Or((n_ as bool?), (o_ as bool?));

			return p_;
		};
		var f_ = context.Operators.WhereOrNull<object>(Medications, e_);
		CqlInterval<CqlDateTime> g_(object M)
		{
			var q_ = this.MedicationPeriod(M);

			return q_;
		};
		var h_ = context.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(f_, g_);
		var i_ = this.RolloutIntervals(h_);
		var j_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(d_, i_);
		var k_ = this.CumulativeDuration(j_);

		return k_;
	}

}