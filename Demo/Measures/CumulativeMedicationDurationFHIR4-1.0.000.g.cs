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
		CqlCode[] a_ = new CqlCode[]
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
		CqlCode[] a_ = new CqlCode[]
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
		object a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", "Warning");

		return (string)a_;
	}

    [CqlDeclaration("ErrorLevel")]
	public string ErrorLevel() => 
		__ErrorLevel.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

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
				decimal? b_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? c_ = context.Operators.Divide(24.0m, period?.value);
				decimal? d_ = context.Operators.Multiply(b_, c_);

				return d_;
			}
			else if ((context.Operators.Equal(period?.unit, "min") ?? false))
			{
				decimal? e_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? f_ = context.Operators.Divide(24.0m, period?.value);
				decimal? g_ = context.Operators.Multiply(e_, f_);
				decimal? h_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? i_ = context.Operators.Multiply(g_, h_);

				return i_;
			}
			else if ((context.Operators.Equal(period?.unit, "s") ?? false))
			{
				decimal? j_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? k_ = context.Operators.Divide(24.0m, period?.value);
				decimal? l_ = context.Operators.Multiply(j_, k_);
				decimal? m_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? n_ = context.Operators.Multiply(l_, m_);
				decimal? p_ = context.Operators.Multiply(n_, m_);

				return p_;
			}
			else if ((context.Operators.Equal(period?.unit, "d") ?? false))
			{
				decimal? q_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? r_ = context.Operators.Divide(24.0m, period?.value);
				decimal? s_ = context.Operators.Multiply(q_, r_);
				decimal? t_ = context.Operators.ConvertIntegerToDecimal(24);
				decimal? u_ = context.Operators.Divide(s_, t_);

				return u_;
			}
			else if ((context.Operators.Equal(period?.unit, "wk") ?? false))
			{
				decimal? v_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? w_ = context.Operators.Divide(24.0m, period?.value);
				decimal? x_ = context.Operators.Multiply(v_, w_);
				int? y_ = context.Operators.Multiply(24, 7);
				decimal? z_ = context.Operators.ConvertIntegerToDecimal(y_);
				decimal? aa_ = context.Operators.Divide(x_, z_);

				return aa_;
			}
			else if ((context.Operators.Equal(period?.unit, "mo") ?? false))
			{
				decimal? ab_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ac_ = context.Operators.Divide(24.0m, period?.value);
				decimal? ad_ = context.Operators.Multiply(ab_, ac_);
				int? ae_ = context.Operators.Multiply(24, 30);
				decimal? af_ = context.Operators.ConvertIntegerToDecimal(ae_);
				decimal? ag_ = context.Operators.Divide(ad_, af_);

				return ag_;
			}
			else if ((context.Operators.Equal(period?.unit, "a") ?? false))
			{
				decimal? ah_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ai_ = context.Operators.Divide(24.0m, period?.value);
				decimal? aj_ = context.Operators.Multiply(ah_, ai_);
				int? ak_ = context.Operators.Multiply(24, 365);
				decimal? al_ = context.Operators.ConvertIntegerToDecimal(ak_);
				decimal? am_ = context.Operators.Divide(aj_, al_);

				return am_;
			}
			else if ((context.Operators.Equal(period?.unit, "hour") ?? false))
			{
				decimal? an_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ao_ = context.Operators.Divide(24.0m, period?.value);
				decimal? ap_ = context.Operators.Multiply(an_, ao_);

				return ap_;
			}
			else if ((context.Operators.Equal(period?.unit, "minute") ?? false))
			{
				decimal? aq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ar_ = context.Operators.Divide(24.0m, period?.value);
				decimal? as_ = context.Operators.Multiply(aq_, ar_);
				decimal? at_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? au_ = context.Operators.Multiply(as_, at_);

				return au_;
			}
			else if ((context.Operators.Equal(period?.unit, "second") ?? false))
			{
				decimal? av_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? aw_ = context.Operators.Divide(24.0m, period?.value);
				decimal? ax_ = context.Operators.Multiply(av_, aw_);
				decimal? ay_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? az_ = context.Operators.Multiply(ax_, ay_);
				decimal? bb_ = context.Operators.Multiply(az_, ay_);

				return bb_;
			}
			else if ((context.Operators.Equal(period?.unit, "day") ?? false))
			{
				decimal? bc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? bd_ = context.Operators.Divide(24.0m, period?.value);
				decimal? be_ = context.Operators.Multiply(bc_, bd_);
				decimal? bf_ = context.Operators.ConvertIntegerToDecimal(24);
				decimal? bg_ = context.Operators.Divide(be_, bf_);

				return bg_;
			}
			else if ((context.Operators.Equal(period?.unit, "week") ?? false))
			{
				decimal? bh_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? bi_ = context.Operators.Divide(24.0m, period?.value);
				decimal? bj_ = context.Operators.Multiply(bh_, bi_);
				int? bk_ = context.Operators.Multiply(24, 7);
				decimal? bl_ = context.Operators.ConvertIntegerToDecimal(bk_);
				decimal? bm_ = context.Operators.Divide(bj_, bl_);

				return bm_;
			}
			else if ((context.Operators.Equal(period?.unit, "month") ?? false))
			{
				decimal? bn_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? bo_ = context.Operators.Divide(24.0m, period?.value);
				decimal? bp_ = context.Operators.Multiply(bn_, bo_);
				int? bq_ = context.Operators.Multiply(24, 30);
				decimal? br_ = context.Operators.ConvertIntegerToDecimal(bq_);
				decimal? bs_ = context.Operators.Divide(bp_, br_);

				return bs_;
			}
			else if ((context.Operators.Equal(period?.unit, "year") ?? false))
			{
				decimal? bt_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? bu_ = context.Operators.Divide(24.0m, period?.value);
				decimal? bv_ = context.Operators.Multiply(bt_, bu_);
				int? bw_ = context.Operators.Multiply(24, 365);
				decimal? bx_ = context.Operators.ConvertIntegerToDecimal(bw_);
				decimal? by_ = context.Operators.Divide(bv_, bx_);

				return by_;
			}
			else if ((context.Operators.Equal(period?.unit, "hours") ?? false))
			{
				decimal? bz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ca_ = context.Operators.Divide(24.0m, period?.value);
				decimal? cb_ = context.Operators.Multiply(bz_, ca_);

				return cb_;
			}
			else if ((context.Operators.Equal(period?.unit, "minutes") ?? false))
			{
				decimal? cc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? cd_ = context.Operators.Divide(24.0m, period?.value);
				decimal? ce_ = context.Operators.Multiply(cc_, cd_);
				decimal? cf_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? cg_ = context.Operators.Multiply(ce_, cf_);

				return cg_;
			}
			else if ((context.Operators.Equal(period?.unit, "seconds") ?? false))
			{
				decimal? ch_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? ci_ = context.Operators.Divide(24.0m, period?.value);
				decimal? cj_ = context.Operators.Multiply(ch_, ci_);
				decimal? ck_ = context.Operators.ConvertIntegerToDecimal(60);
				decimal? cl_ = context.Operators.Multiply(cj_, ck_);
				decimal? cn_ = context.Operators.Multiply(cl_, ck_);

				return cn_;
			}
			else if ((context.Operators.Equal(period?.unit, "days") ?? false))
			{
				decimal? co_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? cp_ = context.Operators.Divide(24.0m, period?.value);
				decimal? cq_ = context.Operators.Multiply(co_, cp_);
				decimal? cr_ = context.Operators.ConvertIntegerToDecimal(24);
				decimal? cs_ = context.Operators.Divide(cq_, cr_);

				return cs_;
			}
			else if ((context.Operators.Equal(period?.unit, "weeks") ?? false))
			{
				decimal? ct_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? cu_ = context.Operators.Divide(24.0m, period?.value);
				decimal? cv_ = context.Operators.Multiply(ct_, cu_);
				int? cw_ = context.Operators.Multiply(24, 7);
				decimal? cx_ = context.Operators.ConvertIntegerToDecimal(cw_);
				decimal? cy_ = context.Operators.Divide(cv_, cx_);

				return cy_;
			}
			else if ((context.Operators.Equal(period?.unit, "months") ?? false))
			{
				decimal? cz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? da_ = context.Operators.Divide(24.0m, period?.value);
				decimal? db_ = context.Operators.Multiply(cz_, da_);
				int? dc_ = context.Operators.Multiply(24, 30);
				decimal? dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
				decimal? de_ = context.Operators.Divide(db_, dd_);

				return de_;
			}
			else if ((context.Operators.Equal(period?.unit, "years") ?? false))
			{
				decimal? df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				decimal? dg_ = context.Operators.Divide(24.0m, period?.value);
				decimal? dh_ = context.Operators.Multiply(df_, dg_);
				int? di_ = context.Operators.Multiply(24, 365);
				decimal? dj_ = context.Operators.ConvertIntegerToDecimal(di_);
				decimal? dk_ = context.Operators.Divide(dh_, dj_);

				return dk_;
			}
			else
			{
				string dl_ = this.ErrorLevel();
				string dm_ = context.Operators.Concatenate("Unknown unit ", (period?.unit ?? ""));
				object dn_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownUnit", dl_, dm_);

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
				CqlCode c_ = this.C();
				bool? d_ = context.Operators.Equal(frequency, c_);

				return (d_ ?? false);
			};
			if (b_())
			{
				return 3.0m;
			}
			else
			{
				string e_ = this.ErrorLevel();
				string f_ = context.Operators.Concatenate("Unknown frequency code ", (frequency?.code ?? ""));
				object g_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", e_, f_);

				return (decimal?)g_;
			};
		};

		return a_();
	}

    [CqlDeclaration("MedicationRequestPeriod")]
	public CqlInterval<CqlDateTime> MedicationRequestPeriod(MedicationRequest Request)
	{
		MedicationRequest[] a_ = new MedicationRequest[]
		{
			Request,
		};
		CqlInterval<CqlDateTime> b_(MedicationRequest R)
		{
			CqlInterval<CqlDateTime> e_()
			{
				bool f_()
				{
					Dosage g_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_0_001.ToInterval((g_?.Timing?.Repeat?.Bounds as Period));
					CqlDateTime i_ = context.Operators.End(h_);
					CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_0_001.ToInterval((g_?.Timing?.Repeat?.Bounds as Period));
					CqlDateTime l_ = context.Operators.End(k_);
					CqlDateTime m_ = context.Operators.Maximum<CqlDateTime>();
					bool? n_ = context.Operators.Equal(l_, m_);
					bool? o_ = context.Operators.Or((bool?)(i_ is null), n_);
					bool? p_ = context.Operators.Not(o_);

					return (p_ ?? false);
				};
				if (f_())
				{
					Dosage q_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_0_001.ToInterval((q_?.Timing?.Repeat?.Bounds as Period));
					CqlDateTime s_ = context.Operators.Start(r_);
					CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					CqlDateTime u_ = context.Operators.Start(t_);
					CqlDateTime v_ = FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement);
					CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_0_001.ToInterval((q_?.Timing?.Repeat?.Bounds as Period));
					CqlDateTime y_ = context.Operators.End(x_);
					CqlInterval<CqlDateTime> z_ = context.Operators.Interval(((s_ ?? u_) ?? v_), y_, true, true);

					return z_;
				}
				else
				{
					Dosage aa_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.ToInterval((aa_?.Timing?.Repeat?.Bounds as Period));
					CqlDateTime ac_ = context.Operators.Start(ab_);
					CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					CqlDateTime ae_ = context.Operators.Start(ad_);
					CqlDateTime af_ = FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement);
					CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_0_001.ToInterval((aa_?.Timing?.Repeat?.Bounds as Period));
					CqlDateTime ai_ = context.Operators.Start(ah_);
					CqlDateTime ak_ = context.Operators.Start(ad_);
					CqlQuantity am_ = FHIRHelpers_4_0_001.ToQuantity((R?.DispenseRequest?.ExpectedSupplyDuration as Quantity));
					CqlQuantity an_ = FHIRHelpers_4_0_001.ToQuantity(R?.DispenseRequest?.Quantity);
					Dosage.DoseAndRateComponent ap_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((aa_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					CqlInterval<CqlQuantity> aq_ = FHIRHelpers_4_0_001.ToInterval((ap_?.Dose as Range));
					CqlQuantity ar_ = context.Operators.End(aq_);
					Dosage.DoseAndRateComponent at_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((aa_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					CqlQuantity au_ = FHIRHelpers_4_0_001.ToQuantity((at_?.Dose as Quantity));
					Integer aw_ = context.Operators.Convert<Integer>(aa_?.Timing?.Repeat?.FrequencyMaxElement);
					Integer ay_ = context.Operators.Convert<Integer>(aa_?.Timing?.Repeat?.FrequencyElement);
					int? az_ = FHIRHelpers_4_0_001.ToInteger((aw_ ?? ay_));
					decimal? bb_ = FHIRHelpers_4_0_001.ToDecimal(aa_?.Timing?.Repeat?.PeriodElement);
					string bd_ = context.Operators.Convert<string>(aa_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					decimal? be_ = this.ToDaily(az_, new CqlQuantity(bb_, bd_));
					int? bg_ = context.Operators.Count<Time>((aa_?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>));
					decimal? bh_ = context.Operators.ConvertIntegerToDecimal(bg_);
					CqlQuantity bi_ = context.Operators.ConvertDecimalToQuantity(((be_ ?? bh_) ?? 1.0m));
					CqlQuantity bj_ = context.Operators.Multiply((ar_ ?? au_), bi_);
					CqlQuantity bk_ = context.Operators.Divide(an_, bj_);
					Integer bl_ = context.Operators.Convert<Integer>(R?.DispenseRequest?.NumberOfRepeatsAllowedElement);
					int? bm_ = FHIRHelpers_4_0_001.ToInteger(bl_);
					int? bn_ = context.Operators.Add(1, (bm_ ?? 0));
					CqlQuantity bo_ = context.Operators.ConvertIntegerToQuantity(bn_);
					CqlQuantity bp_ = context.Operators.Multiply((am_ ?? bk_), bo_);
					CqlDateTime bq_ = context.Operators.Add(((ai_ ?? ak_) ?? af_), bp_);
					CqlInterval<CqlDateTime> br_ = context.Operators.Interval(((ac_ ?? ae_) ?? af_), bq_, true, true);

					return br_;
				};
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationDispensePeriod")]
	public CqlInterval<CqlDateTime> MedicationDispensePeriod(MedicationDispense Dispense)
	{
		MedicationDispense[] a_ = new MedicationDispense[]
		{
			Dispense,
		};
		CqlInterval<CqlDateTime> b_(MedicationDispense D)
		{
			CqlDateTime e_ = FHIRHelpers_4_0_001.ToDateTime((D?.WhenHandedOverElement ?? D?.WhenPreparedElement));
			CqlQuantity g_ = FHIRHelpers_4_0_001.ToQuantity(D?.DaysSupply);
			CqlQuantity h_ = FHIRHelpers_4_0_001.ToQuantity(D?.Quantity);
			Dosage i_ = context.Operators.SingletonFrom<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>));
			Dosage.DoseAndRateComponent j_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((i_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			CqlInterval<CqlQuantity> k_ = FHIRHelpers_4_0_001.ToInterval((j_?.Dose as Range));
			CqlQuantity l_ = context.Operators.End(k_);
			Dosage.DoseAndRateComponent n_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((i_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
			CqlQuantity o_ = FHIRHelpers_4_0_001.ToQuantity((n_?.Dose as Quantity));
			Integer q_ = context.Operators.Convert<Integer>(i_?.Timing?.Repeat?.FrequencyMaxElement);
			Integer s_ = context.Operators.Convert<Integer>(i_?.Timing?.Repeat?.FrequencyElement);
			int? t_ = FHIRHelpers_4_0_001.ToInteger((q_ ?? s_));
			decimal? v_ = FHIRHelpers_4_0_001.ToDecimal(i_?.Timing?.Repeat?.PeriodElement);
			string x_ = context.Operators.Convert<string>(i_?.Timing?.Repeat?.PeriodUnitElement?.Value);
			decimal? y_ = this.ToDaily(t_, new CqlQuantity(v_, x_));
			int? aa_ = context.Operators.Count<Time>((i_?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>));
			decimal? ab_ = context.Operators.ConvertIntegerToDecimal(aa_);
			CqlQuantity ac_ = context.Operators.ConvertDecimalToQuantity(((y_ ?? ab_) ?? 1.0m));
			CqlQuantity ad_ = context.Operators.Multiply((l_ ?? o_), ac_);
			CqlQuantity ae_ = context.Operators.Divide(h_, ad_);
			CqlDateTime af_ = context.Operators.Add(e_, (g_ ?? ae_));
			CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(e_, af_, true, true);

			return ag_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("TherapeuticDuration")]
	public CqlQuantity TherapeuticDuration(CqlConcept medication)
	{
		CqlQuantity a_ = context.Operators.Quantity(14m, "days");

		return a_;
	}

    [CqlDeclaration("MedicationAdministrationPeriod")]
	public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(MedicationAdministration Administration)
	{
		MedicationAdministration[] a_ = new MedicationAdministration[]
		{
			Administration,
		};
		CqlInterval<CqlDateTime> b_(MedicationAdministration M)
		{
			CqlInterval<CqlDateTime> e_()
			{
				bool f_()
				{
					CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period));
					CqlDateTime h_ = context.Operators.Start(g_);
					bool? i_ = context.Operators.Not((bool?)(h_ is null));
					CqlConcept j_ = FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept));
					CqlQuantity k_ = this.TherapeuticDuration(j_);
					bool? l_ = context.Operators.Not((bool?)(k_ is null));
					bool? m_ = context.Operators.And(i_, l_);

					return (m_ ?? false);
				};
				if (f_())
				{
					CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.ToInterval((Administration?.Effective as Period));
					CqlDateTime o_ = context.Operators.Start(n_);
					CqlDateTime q_ = context.Operators.Start(n_);
					CqlConcept r_ = FHIRHelpers_4_0_001.ToConcept((Administration?.Medication as CodeableConcept));
					CqlQuantity s_ = this.TherapeuticDuration(r_);
					CqlDateTime t_ = context.Operators.Add(q_, s_);
					CqlInterval<CqlDateTime> u_ = context.Operators.Interval(o_, t_, true, true);

					return u_;
				}
				else
				{
					CqlInterval<CqlDateTime> v_ = null;

					return v_;
				};
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("CumulativeDuration")]
	public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDateTime>> Intervals)
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

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> a_ = null;
		IEnumerable<CqlInterval<CqlDateTime>> b_(IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I)
		{
			CqlInterval<CqlDateTime>[] d_ = new CqlInterval<CqlDateTime>[]
			{
				I,
			};
			CqlInterval<CqlDateTime> e_(CqlInterval<CqlDateTime> X)
			{
				CqlInterval<CqlDateTime> j_ = context.Operators.Last<CqlInterval<CqlDateTime>>(R);
				CqlDateTime k_ = context.Operators.End(j_);
				CqlQuantity l_ = context.Operators.Quantity(1m, "day");
				CqlDateTime m_ = context.Operators.Add(k_, l_);
				CqlDateTime n_ = context.Operators.Start(X);
				CqlDateTime[] o_ = new CqlDateTime[]
				{
					m_,
					n_,
				};
				CqlDateTime p_ = context.Operators.Max<CqlDateTime>((o_ as IEnumerable<CqlDateTime>));
				CqlDateTime r_ = context.Operators.End(j_);
				CqlDateTime t_ = context.Operators.Add(r_, l_);
				CqlDateTime[] v_ = new CqlDateTime[]
				{
					t_,
					n_,
				};
				CqlDateTime w_ = context.Operators.Max<CqlDateTime>((v_ as IEnumerable<CqlDateTime>));
				CqlDateTime y_ = context.Operators.End(X);
				int? z_ = context.Operators.DurationBetween(n_, y_, "day");
				decimal? aa_ = context.Operators.ConvertIntegerToDecimal((z_ ?? 0));
				CqlDateTime ab_ = context.Operators.Add(w_, new CqlQuantity(aa_, "day"));
				CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(p_, ab_, true, true);

				return ac_;
			};
			IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
			CqlInterval<CqlDateTime> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(f_);
			CqlInterval<CqlDateTime>[] h_ = new CqlInterval<CqlDateTime>[]
			{
				g_,
			};
			IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(R, (h_ as IEnumerable<CqlInterval<CqlDateTime>>));

			return i_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Aggregate<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, a_, b_);

		return c_;
	}

    [CqlDeclaration("MedicationPeriod")]
	public CqlInterval<CqlDateTime> MedicationPeriod(object medication)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (medication is MedicationRequest)
			{
				CqlInterval<CqlDateTime> b_ = this.MedicationRequestPeriod((medication as MedicationRequest));

				return b_;
			}
			else if (medication is MedicationDispense)
			{
				CqlInterval<CqlDateTime> c_ = this.MedicationDispensePeriod((medication as MedicationDispense));

				return c_;
			}
			else if (medication is MedicationAdministration)
			{
				CqlInterval<CqlDateTime> d_ = this.MedicationAdministrationPeriod((medication as MedicationAdministration));

				return d_;
			}
			else
			{
				CqlInterval<CqlDateTime> e_ = null;

				return e_;
			};
		};

		return a_();
	}

    [CqlDeclaration("CumulativeMedicationDuration")]
	public int? CumulativeMedicationDuration(IEnumerable<object> Medications)
	{
		bool? a_(object M)
		{
			bool l_ = M is MedicationRequest;

			return (l_ as bool?);
		};
		IEnumerable<object> b_ = context.Operators.Where<object>(Medications, a_);
		CqlInterval<CqlDateTime> c_(object M)
		{
			CqlInterval<CqlDateTime> m_ = this.MedicationPeriod(M);

			return m_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(b_, c_);
		bool? e_(object M)
		{
			bool n_ = M is MedicationDispense;
			bool o_ = M is MedicationAdministration;
			bool? p_ = context.Operators.Or((n_ as bool?), (o_ as bool?));

			return p_;
		};
		IEnumerable<object> f_ = context.Operators.Where<object>(Medications, e_);
		CqlInterval<CqlDateTime> g_(object M)
		{
			CqlInterval<CqlDateTime> q_ = this.MedicationPeriod(M);

			return q_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(f_, g_);
		IEnumerable<CqlInterval<CqlDateTime>> i_ = this.RolloutIntervals(h_);
		IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.ListUnion<CqlInterval<CqlDateTime>>(d_, i_);
		int? k_ = this.CumulativeDuration(j_);

		return k_;
	}

}
