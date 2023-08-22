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
		new CqlCode("AC", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("AC")]
    public CqlCode AC() => __AC.Value;

    private CqlCode ACD_Value() =>
		new CqlCode("ACD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("ACD")]
    public CqlCode ACD() => __ACD.Value;

    private CqlCode ACM_Value() =>
		new CqlCode("ACM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("ACM")]
    public CqlCode ACM() => __ACM.Value;

    private CqlCode ACV_Value() =>
		new CqlCode("ACV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("ACV")]
    public CqlCode ACV() => __ACV.Value;

    private CqlCode AFT_Value() =>
		new CqlCode("AFT", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("AFT")]
    public CqlCode AFT() => __AFT.Value;

    private CqlCode AFT_early_Value() =>
		new CqlCode("AFT.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("AFT.early")]
    public CqlCode AFT_early() => __AFT_early.Value;

    private CqlCode AFT_late_Value() =>
		new CqlCode("AFT.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("AFT.late")]
    public CqlCode AFT_late() => __AFT_late.Value;

    private CqlCode C_Value() =>
		new CqlCode("C", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("C")]
    public CqlCode C() => __C.Value;

    private CqlCode CD_Value() =>
		new CqlCode("CD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("CD")]
    public CqlCode CD() => __CD.Value;

    private CqlCode CM_Value() =>
		new CqlCode("CM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("CM")]
    public CqlCode CM() => __CM.Value;

    private CqlCode CV_Value() =>
		new CqlCode("CV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("CV")]
    public CqlCode CV() => __CV.Value;

    private CqlCode EVE_Value() =>
		new CqlCode("EVE", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("EVE")]
    public CqlCode EVE() => __EVE.Value;

    private CqlCode EVE_early_Value() =>
		new CqlCode("EVE.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("EVE.early")]
    public CqlCode EVE_early() => __EVE_early.Value;

    private CqlCode EVE_late_Value() =>
		new CqlCode("EVE.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("EVE.late")]
    public CqlCode EVE_late() => __EVE_late.Value;

    private CqlCode HS_Value() =>
		new CqlCode("HS", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("HS")]
    public CqlCode HS() => __HS.Value;

    private CqlCode MORN_Value() =>
		new CqlCode("MORN", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("MORN")]
    public CqlCode MORN() => __MORN.Value;

    private CqlCode MORN_early_Value() =>
		new CqlCode("MORN.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("MORN.early")]
    public CqlCode MORN_early() => __MORN_early.Value;

    private CqlCode MORN_late_Value() =>
		new CqlCode("MORN.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("MORN.late")]
    public CqlCode MORN_late() => __MORN_late.Value;

    private CqlCode NIGHT_Value() =>
		new CqlCode("NIGHT", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("NIGHT")]
    public CqlCode NIGHT() => __NIGHT.Value;

    private CqlCode NOON_Value() =>
		new CqlCode("NOON", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("NOON")]
    public CqlCode NOON() => __NOON.Value;

    private CqlCode PC_Value() =>
		new CqlCode("PC", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("PC")]
    public CqlCode PC() => __PC.Value;

    private CqlCode PCD_Value() =>
		new CqlCode("PCD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("PCD")]
    public CqlCode PCD() => __PCD.Value;

    private CqlCode PCM_Value() =>
		new CqlCode("PCM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("PCM")]
    public CqlCode PCM() => __PCM.Value;

    private CqlCode PCV_Value() =>
		new CqlCode("PCV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("PCV")]
    public CqlCode PCV() => __PCV.Value;

    private CqlCode PHS_Value() =>
		new CqlCode("PHS", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

    [CqlDeclaration("PHS")]
    public CqlCode PHS() => __PHS.Value;

    private CqlCode WAKE_Value() =>
		new CqlCode("WAKE", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

    [CqlDeclaration("WAKE")]
    public CqlCode WAKE() => __WAKE.Value;

    private CqlCode[] V3TimingEvent_Value()
	{
		var a_ = new CqlCode("AC", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var b_ = new CqlCode("ACD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var c_ = new CqlCode("ACM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var d_ = new CqlCode("ACV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var e_ = new CqlCode("C", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var f_ = new CqlCode("CD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var g_ = new CqlCode("CM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var h_ = new CqlCode("CV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var i_ = new CqlCode("HS", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var j_ = new CqlCode("PC", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var k_ = new CqlCode("PCD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var l_ = new CqlCode("PCM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var m_ = new CqlCode("PCV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
		var n_ = new CqlCode("WAKE", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);

		return new CqlCode[]
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
	}

    [CqlDeclaration("V3TimingEvent")]
    public CqlCode[] V3TimingEvent() => __V3TimingEvent.Value;

    private CqlCode[] EventTiming_Value()
	{
		var a_ = new CqlCode("AFT", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var b_ = new CqlCode("AFT.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var c_ = new CqlCode("AFT.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var d_ = new CqlCode("EVE", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var e_ = new CqlCode("EVE.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var f_ = new CqlCode("EVE.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var g_ = new CqlCode("MORN", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var h_ = new CqlCode("MORN.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var i_ = new CqlCode("MORN.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var j_ = new CqlCode("NIGHT", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var k_ = new CqlCode("NOON", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
		var l_ = new CqlCode("PHS", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);

		return new CqlCode[]
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
	}

    [CqlDeclaration("EventTiming")]
    public CqlCode[] EventTiming() => __EventTiming.Value;

    private string ErrorLevel_Value() =>
		(string)context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", ("Warning" as object));

    [CqlDeclaration("ErrorLevel")]
    public string ErrorLevel() => __ErrorLevel.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("ToDaily")]
    public decimal? ToDaily(int? frequency, CqlQuantity period)
    {
        if ((context?.Operators.Equal((period?.unit as object), ("h" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);

			return context?.Operators.Multiply(a_, c_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("min" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(d_, e_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("s" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)60);
			var f_ = context?.Operators.Multiply(d_, e_);
			var g_ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(f_, g_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("d" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)24);

			return context?.Operators.Divide(d_, e_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("wk" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)7);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("mo" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)30);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("a" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)365);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("hour" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);

			return context?.Operators.Multiply(a_, c_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("minute" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(d_, e_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("second" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)60);
			var f_ = context?.Operators.Multiply(d_, e_);
			var g_ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(f_, g_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("day" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)24);

			return context?.Operators.Divide(d_, e_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("week" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)7);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("month" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)30);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("year" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)365);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("hours" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);

			return context?.Operators.Multiply(a_, c_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("minutes" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(d_, e_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("seconds" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)60);
			var f_ = context?.Operators.Multiply(d_, e_);
			var g_ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(f_, g_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("days" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.ConvertIntegerToDecimal((int?)24);

			return context?.Operators.Divide(d_, e_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("weeks" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)7);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("months" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)30);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("years" as object)) ?? false))
		{
			var a_ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b_ = period?.value;
			var c_ = context?.Operators.Divide((decimal?)24.0m, b_);
			var d_ = context?.Operators.Multiply(a_, c_);
			var e_ = context?.Operators.Multiply((int?)24, (int?)365);
			var f_ = context?.Operators.ConvertIntegerToDecimal(e_);

			return context?.Operators.Divide(d_, f_);
		}
        else
		{
			var a_ = this.ErrorLevel();
			var b_ = ("Unknown unit " ?? "");
			var c_ = (period?.unit ?? "");
			var d_ = context?.Operators.Concatenate(b_, c_);
			var e_ = context?.Operators.Message<object>((null as object), "CMDLogic.ToDaily.UnknownUnit", a_, d_);

			return (decimal?)e_;
		}
    }


    [CqlDeclaration("ToDaily")]
    public decimal? ToDaily(CqlCode frequency)
    {
        if ((context?.Operators.Equal((frequency as object), (this.C() as object)) ?? false))
            return (decimal?)3.0m;
        else
		{
			var a_ = this.ErrorLevel();
			var b_ = ("Unknown frequency code " ?? "");
			var c_ = (frequency?.code ?? "");
			var d_ = context?.Operators.Concatenate(b_, c_);
			var e_ = context?.Operators.Message<object>((null as object), "CMDLogic.ToDaily.UnknownFrequencyCode", a_, d_);

			return (decimal?)e_;
		}
    }


    [CqlDeclaration("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(MedicationRequest Request)
	{
		var a_ = Request;
		var b_ = new MedicationRequest[]
		{
			a_,
		};
		var c_ = (MedicationRequest R) => (((context?.Operators.Not(context?.Operators.Or((bool?)(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.Bounds as object) as Period))) == null), context?.Operators.Equal((context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.Bounds as object) as Period))) as object), (context?.Operators.Maximum<CqlDateTime>() as object)))) ?? false))
			? (context?.Operators.Interval(((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.Bounds as object) as Period))) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.Bounds as object) as Period))), true, true))
			: (context?.Operators.Interval(((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.Bounds as object) as Period))) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), context?.Operators.Add(((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.Bounds as object) as Period))) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), context?.Operators.Multiply((FHIRHelpers_4_0_001.ToQuantity((Quantity)R?.DispenseRequest?.ExpectedSupplyDuration) ?? context?.Operators.Divide(FHIRHelpers_4_0_001.ToQuantity(R?.DispenseRequest?.Quantity), context?.Operators.Multiply((context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(((context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>))?.Dose as object) as Range))) ?? FHIRHelpers_4_0_001.ToQuantity(((context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>))?.Dose as object) as Quantity))), context?.Operators.ConvertDecimalToQuantity(((this.ToDaily(FHIRHelpers_4_0_001.ToInteger((context?.Operators?.TypeConverter.Convert<Integer>((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.FrequencyMaxElement as object)) ?? context?.Operators?.TypeConverter.Convert<Integer>((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.FrequencyElement as object)))), new CqlQuantity
											{
												value = FHIRHelpers_4_0_001.ToDecimal(context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.PeriodElement),
												unit = context?.Operators?.TypeConverter.Convert<string>((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.PeriodUnitElement?.Value as object)),
											}) ?? context?.Operators.ConvertIntegerToDecimal(context?.Operators.CountOrNull<Time>((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>)))) ?? (decimal?)1.0m))))), context?.Operators.ConvertIntegerToQuantity(context?.Operators.Add((int?)1, (FHIRHelpers_4_0_001.ToInteger(context?.Operators?.TypeConverter.Convert<Integer>((R?.DispenseRequest?.NumberOfRepeatsAllowedElement as object))) ?? (int?)0))))), true, true)))
;
		var d_ = context?.Operators.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(b_, c_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
	}


    [CqlDeclaration("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(MedicationDispense Dispense)
	{
		var a_ = Dispense;
		var b_ = new MedicationDispense[]
		{
			a_,
		};
		var c_ = (MedicationDispense D) =>
		{
			var a_ = (D?.WhenHandedOverElement ?? D?.WhenPreparedElement);
			var b_ = FHIRHelpers_4_0_001.ToDateTime(a_);
			var c_ = (D?.WhenHandedOverElement ?? D?.WhenPreparedElement);
			var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
			var e_ = D?.DaysSupply;
			var f_ = FHIRHelpers_4_0_001.ToQuantity(e_);
			var g_ = D?.Quantity;
			var h_ = FHIRHelpers_4_0_001.ToQuantity(g_);
			var i_ = (D?.DosageInstruction as IEnumerable<Dosage>);
			var j_ = context?.Operators.SingleOrNull<Dosage>(i_);
			var k_ = (j_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>);
			var l_ = context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(k_);
			var m_ = ((l_?.Dose as object) as Range);
			var n_ = FHIRHelpers_4_0_001.ToInterval(m_);
			var o_ = context?.Operators.End(n_);
			var p_ = (D?.DosageInstruction as IEnumerable<Dosage>);
			var q_ = context?.Operators.SingleOrNull<Dosage>(p_);
			var r_ = (q_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>);
			var s_ = context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(r_);
			var t_ = ((s_?.Dose as object) as Quantity);
			var u_ = FHIRHelpers_4_0_001.ToQuantity(t_);
			var v_ = (o_ ?? u_);
			var w_ = (D?.DosageInstruction as IEnumerable<Dosage>);
			var x_ = context?.Operators.SingleOrNull<Dosage>(w_);
			var y_ = (x_?.Timing?.Repeat?.FrequencyMaxElement as object);
			var z_ = context?.Operators?.TypeConverter.Convert<Integer>(y_);
			var aa_ = (D?.DosageInstruction as IEnumerable<Dosage>);
			var ab_ = context?.Operators.SingleOrNull<Dosage>(aa_);
			var ac_ = (ab_?.Timing?.Repeat?.FrequencyElement as object);
			var ad_ = context?.Operators?.TypeConverter.Convert<Integer>(ac_);
			var ae_ = (z_ ?? ad_);
			var af_ = FHIRHelpers_4_0_001.ToInteger(ae_);
			var ag_ = (D?.DosageInstruction as IEnumerable<Dosage>);
			var ah_ = context?.Operators.SingleOrNull<Dosage>(ag_);
			var ai_ = ah_?.Timing?.Repeat?.PeriodElement;
			var aj_ = FHIRHelpers_4_0_001.ToDecimal(ai_);
			var ak_ = (D?.DosageInstruction as IEnumerable<Dosage>);
			var al_ = context?.Operators.SingleOrNull<Dosage>(ak_);
			var am_ = (al_?.Timing?.Repeat?.PeriodUnitElement?.Value as object);
			var an_ = context?.Operators?.TypeConverter.Convert<string>(am_);
			var ao_ = new CqlQuantity
			{
				value = aj_,
				unit = an_,
			};
			var ap_ = this.ToDaily(af_, ao_);
			var aq_ = (D?.DosageInstruction as IEnumerable<Dosage>);
			var ar_ = context?.Operators.SingleOrNull<Dosage>(aq_);
			var as_ = (ar_?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>);
			var at_ = context?.Operators.CountOrNull<Time>(as_);
			var au_ = context?.Operators.ConvertIntegerToDecimal(at_);
			var av_ = ((ap_ ?? au_) ?? (decimal?)1.0m);
			var aw_ = context?.Operators.ConvertDecimalToQuantity(av_);
			var ax_ = context?.Operators.Multiply(v_, aw_);
			var ay_ = context?.Operators.Divide(h_, ax_);
			var az_ = (f_ ?? ay_);
			var ba_ = context?.Operators.Add(d_, az_);

			return context?.Operators.Interval(b_, ba_, true, true);
		};
		var d_ = context?.Operators.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(b_, c_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
	}


    [CqlDeclaration("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlConcept medication) =>
		context?.Operators.Quantity(14m, "days");


    [CqlDeclaration("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(MedicationAdministration Administration)
	{
		var a_ = Administration;
		var b_ = new MedicationAdministration[]
		{
			a_,
		};
		var c_ = (MedicationAdministration M) => (((context?.Operators.And(context?.Operators.Not((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((Administration?.Effective as object) as Period))) == null)), context?.Operators.Not((bool?)(this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept(((Administration?.Medication as object) as CodeableConcept))) == null))) ?? false))
			? (context?.Operators.Interval(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((Administration?.Effective as object) as Period))), context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((Administration?.Effective as object) as Period))), this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept(((Administration?.Medication as object) as CodeableConcept)))), true, true))
			: ((null as CqlInterval<CqlDateTime>)))
;
		var d_ = context?.Operators.SelectOrNull<MedicationAdministration, CqlInterval<CqlDateTime>>(b_, c_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
	}


    [CqlDeclaration("CumulativeDuration")]
    public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDateTime>> Intervals)
	{
		var a_ = context?.Operators.Collapse(Intervals, "day");
		var b_ = (CqlInterval<CqlDateTime> X) =>
		{
			var a_ = context?.Operators.Start(X);
			var b_ = context?.Operators.End(X);

			return context?.Operators.DifferenceBetween(a_, b_, "day");
		};
		var c_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(a_, b_);

		return context?.Operators.Sum(c_);
	}


    [CqlDeclaration("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		var a_ = (null as IEnumerable<CqlInterval<CqlDateTime>>);
		var b_ = (IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I) =>
		{
			var a_ = I;
			var b_ = new CqlInterval<CqlDateTime>[]
			{
				a_,
			};
			var c_ = (CqlInterval<CqlDateTime> X) =>
			{
				var a_ = context?.Operators.LastOfList<CqlInterval<CqlDateTime>>(R);
				var b_ = context?.Operators.End(a_);
				var c_ = context?.Operators.Quantity(1m, "day");
				var d_ = context?.Operators.Add(b_, c_);
				var e_ = context?.Operators.Start(X);
				var f_ = new CqlDateTime[]
				{
					d_,
					e_,
				};
				var g_ = (f_ as IEnumerable<CqlDateTime>);
				var h_ = context?.Operators.MaxOrNull<CqlDateTime>(g_);
				var i_ = context?.Operators.LastOfList<CqlInterval<CqlDateTime>>(R);
				var j_ = context?.Operators.End(i_);
				var k_ = context?.Operators.Quantity(1m, "day");
				var l_ = context?.Operators.Add(j_, k_);
				var m_ = context?.Operators.Start(X);
				var n_ = new CqlDateTime[]
				{
					l_,
					m_,
				};
				var o_ = (n_ as IEnumerable<CqlDateTime>);
				var p_ = context?.Operators.MaxOrNull<CqlDateTime>(o_);
				var q_ = context?.Operators.Start(X);
				var r_ = context?.Operators.End(X);
				var s_ = context?.Operators.DurationBetween(q_, r_, "day");
				var t_ = (s_ ?? (int?)0);
				var u_ = context?.Operators.ConvertIntegerToDecimal(t_);
				var v_ = "day";
				var w_ = new CqlQuantity
				{
					value = u_,
					unit = v_,
				};
				var x_ = context?.Operators.Add(p_, w_);

				return context?.Operators.Interval(h_, x_, true, true);
			};
			var d_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(b_, c_);
			var e_ = context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
			var f_ = new CqlInterval<CqlDateTime>[]
			{
				e_,
			};
			var g_ = (f_ as IEnumerable<CqlInterval<CqlDateTime>>);

			return context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(R, g_);
		};

		return context?.Operators.AggregateOrNull<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, a_, b_);
	}


    [CqlDeclaration("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(object medication)
    {
        if (((medication is MedicationRequest as bool?) ?? false))
            return this.MedicationRequestPeriod((medication as MedicationRequest));
        else if (((medication is MedicationDispense as bool?) ?? false))
            return this.MedicationDispensePeriod((medication as MedicationDispense));
        else if (((medication is MedicationAdministration as bool?) ?? false))
            return this.MedicationAdministrationPeriod((medication as MedicationAdministration));
        else
            return (null as CqlInterval<CqlDateTime>);
    }


    [CqlDeclaration("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(IEnumerable<object> Medications)
	{
		var a_ = (object M) => (M is MedicationRequest as bool?);
		var b_ = context?.Operators.WhereOrNull<object>(Medications, a_);
		var c_ = (object M) => this.MedicationPeriod(M);
		var d_ = context?.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(b_, c_);
		var e_ = (object M) =>
		{
			var a_ = (M is MedicationDispense as bool?);
			var b_ = (M is MedicationAdministration as bool?);

			return context?.Operators.Or(a_, b_);
		};
		var f_ = context?.Operators.WhereOrNull<object>(Medications, e_);
		var g_ = (object M) => this.MedicationPeriod(M);
		var h_ = context?.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(f_, g_);
		var i_ = this.RolloutIntervals(h_);
		var j_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(d_, i_);

		return this.CumulativeDuration(j_);
	}


}