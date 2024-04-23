using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
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
			if ((context.Operators.Equal(period?.unit, "h") ?? false))
			{
				var b_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var c_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var d_ = context.Operators.Multiply(b_, c_);

				return d_;
			}
			else if ((context.Operators.Equal(period?.unit, "min") ?? false))
			{
				var e_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var f_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var g_ = context.Operators.Multiply(e_, f_);
				var h_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var i_ = context.Operators.Multiply(g_, h_);

				return i_;
			}
			else if ((context.Operators.Equal(period?.unit, "s") ?? false))
			{
				var j_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var k_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var l_ = context.Operators.Multiply(j_, k_);
				var m_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var n_ = context.Operators.Multiply(l_, m_);
				var p_ = context.Operators.Multiply(n_, m_);

				return p_;
			}
			else if ((context.Operators.Equal(period?.unit, "d") ?? false))
			{
				var q_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var r_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var s_ = context.Operators.Multiply(q_, r_);
				var t_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var u_ = context.Operators.Divide(s_, t_);

				return u_;
			}
			else if ((context.Operators.Equal(period?.unit, "wk") ?? false))
			{
				var v_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var w_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var x_ = context.Operators.Multiply(v_, w_);
				var y_ = context.Operators.Multiply((int?)24, (int?)7);
				var z_ = context.Operators.ConvertIntegerToDecimal(y_);
				var aa_ = context.Operators.Divide(x_, z_);

				return aa_;
			}
			else if ((context.Operators.Equal(period?.unit, "mo") ?? false))
			{
				var ab_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ac_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ad_ = context.Operators.Multiply(ab_, ac_);
				var ae_ = context.Operators.Multiply((int?)24, (int?)30);
				var af_ = context.Operators.ConvertIntegerToDecimal(ae_);
				var ag_ = context.Operators.Divide(ad_, af_);

				return ag_;
			}
			else if ((context.Operators.Equal(period?.unit, "a") ?? false))
			{
				var ah_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ai_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var aj_ = context.Operators.Multiply(ah_, ai_);
				var ak_ = context.Operators.Multiply((int?)24, (int?)365);
				var al_ = context.Operators.ConvertIntegerToDecimal(ak_);
				var am_ = context.Operators.Divide(aj_, al_);

				return am_;
			}
			else if ((context.Operators.Equal(period?.unit, "hour") ?? false))
			{
				var an_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ao_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ap_ = context.Operators.Multiply(an_, ao_);

				return ap_;
			}
			else if ((context.Operators.Equal(period?.unit, "minute") ?? false))
			{
				var aq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ar_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var as_ = context.Operators.Multiply(aq_, ar_);
				var at_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var au_ = context.Operators.Multiply(as_, at_);

				return au_;
			}
			else if ((context.Operators.Equal(period?.unit, "second") ?? false))
			{
				var av_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var aw_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ax_ = context.Operators.Multiply(av_, aw_);
				var ay_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var az_ = context.Operators.Multiply(ax_, ay_);
				var bb_ = context.Operators.Multiply(az_, ay_);

				return bb_;
			}
			else if ((context.Operators.Equal(period?.unit, "day") ?? false))
			{
				var bc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bd_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var be_ = context.Operators.Multiply(bc_, bd_);
				var bf_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var bg_ = context.Operators.Divide(be_, bf_);

				return bg_;
			}
			else if ((context.Operators.Equal(period?.unit, "week") ?? false))
			{
				var bh_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bi_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var bj_ = context.Operators.Multiply(bh_, bi_);
				var bk_ = context.Operators.Multiply((int?)24, (int?)7);
				var bl_ = context.Operators.ConvertIntegerToDecimal(bk_);
				var bm_ = context.Operators.Divide(bj_, bl_);

				return bm_;
			}
			else if ((context.Operators.Equal(period?.unit, "month") ?? false))
			{
				var bn_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bo_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var bp_ = context.Operators.Multiply(bn_, bo_);
				var bq_ = context.Operators.Multiply((int?)24, (int?)30);
				var br_ = context.Operators.ConvertIntegerToDecimal(bq_);
				var bs_ = context.Operators.Divide(bp_, br_);

				return bs_;
			}
			else if ((context.Operators.Equal(period?.unit, "year") ?? false))
			{
				var bt_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bu_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var bv_ = context.Operators.Multiply(bt_, bu_);
				var bw_ = context.Operators.Multiply((int?)24, (int?)365);
				var bx_ = context.Operators.ConvertIntegerToDecimal(bw_);
				var by_ = context.Operators.Divide(bv_, bx_);

				return by_;
			}
			else if ((context.Operators.Equal(period?.unit, "hours") ?? false))
			{
				var bz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ca_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cb_ = context.Operators.Multiply(bz_, ca_);

				return cb_;
			}
			else if ((context.Operators.Equal(period?.unit, "minutes") ?? false))
			{
				var cc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cd_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var ce_ = context.Operators.Multiply(cc_, cd_);
				var cf_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var cg_ = context.Operators.Multiply(ce_, cf_);

				return cg_;
			}
			else if ((context.Operators.Equal(period?.unit, "seconds") ?? false))
			{
				var ch_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ci_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cj_ = context.Operators.Multiply(ch_, ci_);
				var ck_ = context.Operators.ConvertIntegerToDecimal((int?)60);
				var cl_ = context.Operators.Multiply(cj_, ck_);
				var cn_ = context.Operators.Multiply(cl_, ck_);

				return cn_;
			}
			else if ((context.Operators.Equal(period?.unit, "days") ?? false))
			{
				var co_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cp_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cq_ = context.Operators.Multiply(co_, cp_);
				var cr_ = context.Operators.ConvertIntegerToDecimal((int?)24);
				var cs_ = context.Operators.Divide(cq_, cr_);

				return cs_;
			}
			else if ((context.Operators.Equal(period?.unit, "weeks") ?? false))
			{
				var ct_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cu_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var cv_ = context.Operators.Multiply(ct_, cu_);
				var cw_ = context.Operators.Multiply((int?)24, (int?)7);
				var cx_ = context.Operators.ConvertIntegerToDecimal(cw_);
				var cy_ = context.Operators.Divide(cv_, cx_);

				return cy_;
			}
			else if ((context.Operators.Equal(period?.unit, "months") ?? false))
			{
				var cz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var da_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var db_ = context.Operators.Multiply(cz_, da_);
				var dc_ = context.Operators.Multiply((int?)24, (int?)30);
				var dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
				var de_ = context.Operators.Divide(db_, dd_);

				return de_;
			}
			else if ((context.Operators.Equal(period?.unit, "years") ?? false))
			{
				var df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dg_ = context.Operators.Divide((decimal?)24.0m, period?.value);
				var dh_ = context.Operators.Multiply(df_, dg_);
				var di_ = context.Operators.Multiply((int?)24, (int?)365);
				var dj_ = context.Operators.ConvertIntegerToDecimal(di_);
				var dk_ = context.Operators.Divide(dh_, dj_);

				return dk_;
			}
			else
			{
				var dl_ = this.ErrorLevel();
				var dm_ = context.Operators.Concatenate("Unknown unit ", (period?.unit ?? ""));
				var dn_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", dl_, dm_);

				return (decimal?)dn_;
			};
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
				return (decimal?)3.0m;
			}
			else
			{
				var e_ = this.ErrorLevel();
				var f_ = context.Operators.Concatenate("Unknown frequency code ", (frequency?.code ?? ""));
				var g_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", e_, f_);

				return (decimal?)g_;
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
				bool f_()
				{
					var g_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					var h_ = FHIRHelpers_4_0_001.ToInterval((g_?.Timing?.Repeat?.Bounds as Period));
					var i_ = context.Operators.End(h_);
					var k_ = FHIRHelpers_4_0_001.ToInterval((g_?.Timing?.Repeat?.Bounds as Period));
					var l_ = context.Operators.End(k_);
					var m_ = context.Operators.Maximum<CqlDateTime>();
					var n_ = context.Operators.Equal(l_, m_);
					var o_ = context.Operators.Or((bool?)(i_ is null), n_);
					var p_ = context.Operators.Not(o_);

					return (p_ ?? false);
				};
				if (f_())
				{
					var q_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					var r_ = FHIRHelpers_4_0_001.ToInterval((q_?.Timing?.Repeat?.Bounds as Period));
					var s_ = context.Operators.Start(r_);
					var t_ = FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var u_ = context.Operators.Start(t_);
					var v_ = FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement);
					var x_ = FHIRHelpers_4_0_001.ToInterval((q_?.Timing?.Repeat?.Bounds as Period));
					var y_ = context.Operators.End(x_);
					var z_ = context.Operators.Interval(((s_ ?? u_) ?? v_), y_, (bool?)true, (bool?)true);

					return z_;
				}
				else
				{
					var aa_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					var ab_ = FHIRHelpers_4_0_001.ToInterval((aa_?.Timing?.Repeat?.Bounds as Period));
					var ac_ = context.Operators.Start(ab_);
					var ad_ = FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var ae_ = context.Operators.Start(ad_);
					var af_ = FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement);
					var ah_ = FHIRHelpers_4_0_001.ToInterval((aa_?.Timing?.Repeat?.Bounds as Period));
					var ai_ = context.Operators.Start(ah_);
					var ak_ = context.Operators.Start(ad_);
					var am_ = FHIRHelpers_4_0_001.ToQuantity((R?.DispenseRequest?.ExpectedSupplyDuration as Quantity));
					var an_ = FHIRHelpers_4_0_001.ToQuantity(R?.DispenseRequest?.Quantity);
					var ap_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((aa_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var aq_ = FHIRHelpers_4_0_001.ToInterval((ap_?.Dose as Range));
					var ar_ = context.Operators.End(aq_);
					var at_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((aa_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					var au_ = FHIRHelpers_4_0_001.ToQuantity((at_?.Dose as Quantity));
					var aw_ = context.Operators.Convert<Integer>(aa_?.Timing?.Repeat?.FrequencyMaxElement);
					var ay_ = context.Operators.Convert<Integer>(aa_?.Timing?.Repeat?.FrequencyElement);
					var az_ = FHIRHelpers_4_0_001.ToInteger((aw_ ?? ay_));
					var bb_ = FHIRHelpers_4_0_001.ToDecimal(aa_?.Timing?.Repeat?.PeriodElement);
					var bd_ = context.Operators.Convert<string>(aa_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var be_ = this.ToDaily(az_, new CqlQuantity(bb_, bd_));
					var bg_ = context.Operators.Count<Time>((aa_?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>));
					var bh_ = context.Operators.ConvertIntegerToDecimal(bg_);
					var bi_ = context.Operators.ConvertDecimalToQuantity(((be_ ?? bh_) ?? (decimal?)1.0m));
					var bj_ = context.Operators.Multiply((ar_ ?? au_), bi_);
					var bk_ = context.Operators.Divide(an_, bj_);
					var bl_ = context.Operators.Convert<Integer>(R?.DispenseRequest?.NumberOfRepeatsAllowedElement);
					var bm_ = FHIRHelpers_4_0_001.ToInteger(bl_);
					var bn_ = context.Operators.Add((int?)1, (bm_ ?? (int?)0));
					var bo_ = context.Operators.ConvertIntegerToQuantity(bn_);
					var bp_ = context.Operators.Multiply((am_ ?? bk_), bo_);
					var bq_ = context.Operators.Add(((ai_ ?? ak_) ?? af_), bp_);
					var br_ = context.Operators.Interval(((ac_ ?? ae_) ?? af_), bq_, (bool?)true, (bool?)true);

					return br_;
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(a_, b_);
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
			var e_ = FHIRHelpers_4_0_001.ToDateTime((D?.WhenHandedOverElement ?? D?.WhenPreparedElement));
			var g_ = FHIRHelpers_4_0_001.ToQuantity(D?.DaysSupply);
			var h_ = FHIRHelpers_4_0_001.ToQuantity(D?.Quantity);
			var i_ = context.Operators.SingletonFrom<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>));
			var j_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((i_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			var k_ = FHIRHelpers_4_0_001.ToInterval((j_?.Dose as Range));
			var l_ = context.Operators.End(k_);
			var n_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((i_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			var o_ = FHIRHelpers_4_0_001.ToQuantity((n_?.Dose as Quantity));
			var q_ = context.Operators.Convert<Integer>(i_?.Timing?.Repeat?.FrequencyMaxElement);
			var s_ = context.Operators.Convert<Integer>(i_?.Timing?.Repeat?.FrequencyElement);
			var t_ = FHIRHelpers_4_0_001.ToInteger((q_ ?? s_));
			var v_ = FHIRHelpers_4_0_001.ToDecimal(i_?.Timing?.Repeat?.PeriodElement);
			var x_ = context.Operators.Convert<string>(i_?.Timing?.Repeat?.PeriodUnitElement?.Value);
			var y_ = this.ToDaily(t_, new CqlQuantity(v_, x_));
			var aa_ = context.Operators.Count<Time>((i_?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>));
			var ab_ = context.Operators.ConvertIntegerToDecimal(aa_);
			var ac_ = context.Operators.ConvertDecimalToQuantity(((y_ ?? ab_) ?? (decimal?)1.0m));
			var ad_ = context.Operators.Multiply((l_ ?? o_), ac_);
			var ae_ = context.Operators.Divide(h_, ad_);
			var af_ = context.Operators.Add(e_, (g_ ?? ae_));
			var ag_ = context.Operators.Interval(e_, af_, (bool?)true, (bool?)true);

			return ag_;
		};
		var c_ = context.Operators.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("TherapeuticDuration")]
	public CqlQuantity TherapeuticDuration(CqlConcept medication)
	{
		var a_ = context.Operators.Quantity((decimal?)14m, "days");

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
					var g_ = FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period));
					var h_ = context.Operators.Start(g_);
					var i_ = context.Operators.Not((bool?)(h_ is null));
					var j_ = FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept));
					var k_ = this.TherapeuticDuration(j_);
					var l_ = context.Operators.Not((bool?)(k_ is null));
					var m_ = context.Operators.And(i_, l_);

					return (m_ ?? false);
				};
				if (f_())
				{
					var n_ = FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period));
					var o_ = context.Operators.Start(n_);
					var q_ = context.Operators.Start(n_);
					var r_ = FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept));
					var s_ = this.TherapeuticDuration(r_);
					var t_ = context.Operators.Add(q_, s_);
					var u_ = context.Operators.Interval(o_, t_, (bool?)true, (bool?)true);

					return u_;
				}
				else
				{
					CqlInterval<CqlDateTime> v_ = null;

					return (v_ as CqlInterval<CqlDateTime>);
				};
			};

			return e_();
		};
		var c_ = context.Operators.SelectOrNull<MedicationAdministration, CqlInterval<CqlDateTime>>(a_, b_);
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
				var j_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
				var k_ = context.Operators.End(j_);
				var l_ = context.Operators.Quantity((decimal?)1m, "day");
				var m_ = context.Operators.Add(k_, l_);
				var n_ = context.Operators.Start(X);
				var o_ = new CqlDateTime[]
				{
					m_,
					n_,
				};
				var p_ = context.Operators.Max<CqlDateTime>((o_ as IEnumerable<CqlDateTime>));
				var r_ = context.Operators.End(j_);
				var t_ = context.Operators.Add(r_, l_);
				var v_ = new CqlDateTime[]
				{
					t_,
					n_,
				};
				var w_ = context.Operators.Max<CqlDateTime>((v_ as IEnumerable<CqlDateTime>));
				var y_ = context.Operators.End(X);
				var z_ = context.Operators.DurationBetween(n_, y_, "day");
				var aa_ = context.Operators.ConvertIntegerToDecimal((z_ ?? (int?)0));
				var ab_ = context.Operators.Add(w_, new CqlQuantity(aa_, "day"));
				var ac_ = context.Operators.Interval(p_, ab_, (bool?)true, (bool?)true);

				return ac_;
			};
			var f_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
			var g_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(f_);
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
