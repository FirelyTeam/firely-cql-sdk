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
    public CqlCode AC() => __AC.Value;

    private CqlCode ACD_Value() =>
		new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACD")]
    public CqlCode ACD() => __ACD.Value;

    private CqlCode ACM_Value() =>
		new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACM")]
    public CqlCode ACM() => __ACM.Value;

    private CqlCode ACV_Value() =>
		new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACV")]
    public CqlCode ACV() => __ACV.Value;

    private CqlCode AFT_Value() =>
		new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT")]
    public CqlCode AFT() => __AFT.Value;

    private CqlCode AFT_early_Value() =>
		new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT.early")]
    public CqlCode AFT_early() => __AFT_early.Value;

    private CqlCode AFT_late_Value() =>
		new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("AFT.late")]
    public CqlCode AFT_late() => __AFT_late.Value;

    private CqlCode C_Value() =>
		new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("C")]
    public CqlCode C() => __C.Value;

    private CqlCode CD_Value() =>
		new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CD")]
    public CqlCode CD() => __CD.Value;

    private CqlCode CM_Value() =>
		new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CM")]
    public CqlCode CM() => __CM.Value;

    private CqlCode CV_Value() =>
		new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CV")]
    public CqlCode CV() => __CV.Value;

    private CqlCode EVE_Value() =>
		new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE")]
    public CqlCode EVE() => __EVE.Value;

    private CqlCode EVE_early_Value() =>
		new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE.early")]
    public CqlCode EVE_early() => __EVE_early.Value;

    private CqlCode EVE_late_Value() =>
		new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("EVE.late")]
    public CqlCode EVE_late() => __EVE_late.Value;

    private CqlCode HS_Value() =>
		new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("HS")]
    public CqlCode HS() => __HS.Value;

    private CqlCode MORN_Value() =>
		new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN")]
    public CqlCode MORN() => __MORN.Value;

    private CqlCode MORN_early_Value() =>
		new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN.early")]
    public CqlCode MORN_early() => __MORN_early.Value;

    private CqlCode MORN_late_Value() =>
		new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("MORN.late")]
    public CqlCode MORN_late() => __MORN_late.Value;

    private CqlCode NIGHT_Value() =>
		new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NIGHT")]
    public CqlCode NIGHT() => __NIGHT.Value;

    private CqlCode NOON_Value() =>
		new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NOON")]
    public CqlCode NOON() => __NOON.Value;

    private CqlCode PC_Value() =>
		new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PC")]
    public CqlCode PC() => __PC.Value;

    private CqlCode PCD_Value() =>
		new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCD")]
    public CqlCode PCD() => __PCD.Value;

    private CqlCode PCM_Value() =>
		new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCM")]
    public CqlCode PCM() => __PCM.Value;

    private CqlCode PCV_Value() =>
		new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCV")]
    public CqlCode PCV() => __PCV.Value;

    private CqlCode PHS_Value() =>
		new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("PHS")]
    public CqlCode PHS() => __PHS.Value;

    private CqlCode WAKE_Value() =>
		new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

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

    private string ErrorLevel_Value()
	{
		var a_ = context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", "ErrorLevel", ("Warning" as object));

		return (string)a_;
	}

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
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);

			return context?.Operators.Multiply(a__, c__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("min" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(d__, e__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("s" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)60);
			var f__ = context?.Operators.Multiply(d__, e__);
			var g__ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(f__, g__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("d" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)24);

			return context?.Operators.Divide(d__, e__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("wk" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)7);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("mo" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)30);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("a" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)365);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("hour" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);

			return context?.Operators.Multiply(a__, c__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("minute" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(d__, e__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("second" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)60);
			var f__ = context?.Operators.Multiply(d__, e__);
			var g__ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(f__, g__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("day" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)24);

			return context?.Operators.Divide(d__, e__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("week" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)7);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("month" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)30);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("year" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)365);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("hours" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);

			return context?.Operators.Multiply(a__, c__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("minutes" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(d__, e__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("seconds" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)60);
			var f__ = context?.Operators.Multiply(d__, e__);
			var g__ = context?.Operators.ConvertIntegerToDecimal((int?)60);

			return context?.Operators.Multiply(f__, g__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("days" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.ConvertIntegerToDecimal((int?)24);

			return context?.Operators.Divide(d__, e__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("weeks" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)7);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("months" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)30);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else if ((context?.Operators.Equal((period?.unit as object), ("years" as object)) ?? false))
		{
			var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
			var b__ = period?.value;
			var c__ = context?.Operators.Divide((decimal?)24.0m, b__);
			var d__ = context?.Operators.Multiply(a__, c__);
			var e__ = context?.Operators.Multiply((int?)24, (int?)365);
			var f__ = context?.Operators.ConvertIntegerToDecimal(e__);

			return context?.Operators.Divide(d__, f__);
		}
        else
		{
			var a__ = this.ErrorLevel();
			var b__ = ("Unknown unit " ?? "");
			var c__ = period?.unit;
			var d__ = (c__ ?? "");
			var e__ = context?.Operators.Concatenate(b__, d__);
			var f__ = context?.Operators.Message<object>((null as object), "CMDLogic.ToDaily.UnknownUnit", a__, e__);

			return (decimal?)f__;
		}
    }


    [CqlDeclaration("ToDaily")]
    public decimal? ToDaily(CqlCode frequency)
    {
        if ((context?.Operators.Equal((frequency as object), (this.C() as object)) ?? false))
            return (decimal?)3.0m;
        else
		{
			var a__ = this.ErrorLevel();
			var b__ = ("Unknown frequency code " ?? "");
			var c__ = frequency?.code;
			var d__ = (c__ ?? "");
			var e__ = context?.Operators.Concatenate(b__, d__);
			var f__ = context?.Operators.Message<object>((null as object), "CMDLogic.ToDaily.UnknownFrequencyCode", a__, e__);

			return (decimal?)f__;
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
												unit = context?.Operators?.TypeConverter.Convert<string>(context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.PeriodUnitElement?.Value),
											}) ?? context?.Operators.ConvertIntegerToDecimal(context?.Operators.CountOrNull<Time>((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>))?.Timing?.Repeat?.TimeOfDayElement as IEnumerable<Time>)))) ?? (decimal?)1.0m))))), context?.Operators.ConvertIntegerToQuantity(context?.Operators.Add((int?)1, (FHIRHelpers_4_0_001.ToInteger(context?.Operators?.TypeConverter.Convert<Integer>((R?.DispenseRequest?.NumberOfRepeatsAllowedElement as object))) ?? (int?)0))))), true, true)))
;
		var d_ = context?.Operators.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(b_, c_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
	}


    [CqlDeclaration("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(MedicationDispense Dispense)
	{
		var ci_ = Dispense;
		var cj_ = new MedicationDispense[]
		{
			ci_,
		};
		var ck_ = (MedicationDispense D) =>
		{
			var a_ = D?.WhenHandedOverElement;
			var b_ = D?.WhenPreparedElement;
			var c_ = (a_ ?? b_);
			var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
			var e_ = D?.WhenHandedOverElement;
			var f_ = D?.WhenPreparedElement;
			var g_ = (e_ ?? f_);
			var h_ = FHIRHelpers_4_0_001.ToDateTime(g_);
			var i_ = D?.DaysSupply;
			var j_ = FHIRHelpers_4_0_001.ToQuantity(i_);
			var k_ = D?.Quantity;
			var l_ = FHIRHelpers_4_0_001.ToQuantity(k_);
			var m_ = D?.DosageInstruction;
			var n_ = (m_ as IEnumerable<Dosage>);
			var o_ = context?.Operators.SingleOrNull<Dosage>(n_);
			var p_ = o_?.DoseAndRate;
			var q_ = (p_ as IEnumerable<Dosage.DoseAndRateComponent>);
			var r_ = context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(q_);
			var s_ = r_?.Dose;
			var t_ = (s_ as object);
			var u_ = (t_ as Range);
			var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
			var w_ = context?.Operators.End(v_);
			var x_ = D?.DosageInstruction;
			var y_ = (x_ as IEnumerable<Dosage>);
			var z_ = context?.Operators.SingleOrNull<Dosage>(y_);
			var aa_ = z_?.DoseAndRate;
			var ab_ = (aa_ as IEnumerable<Dosage.DoseAndRateComponent>);
			var ac_ = context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(ab_);
			var ad_ = ac_?.Dose;
			var ae_ = (ad_ as object);
			var af_ = (ae_ as Quantity);
			var ag_ = FHIRHelpers_4_0_001.ToQuantity(af_);
			var ah_ = (w_ ?? ag_);
			var ai_ = D?.DosageInstruction;
			var aj_ = (ai_ as IEnumerable<Dosage>);
			var ak_ = context?.Operators.SingleOrNull<Dosage>(aj_);
			var al_ = ak_?.Timing;
			var am_ = al_?.Repeat;
			var an_ = am_?.FrequencyMaxElement;
			var ao_ = (an_ as object);
			var ap_ = context?.Operators?.TypeConverter.Convert<Integer>(ao_);
			var aq_ = D?.DosageInstruction;
			var ar_ = (aq_ as IEnumerable<Dosage>);
			var as_ = context?.Operators.SingleOrNull<Dosage>(ar_);
			var at_ = as_?.Timing;
			var au_ = at_?.Repeat;
			var av_ = au_?.FrequencyElement;
			var aw_ = (av_ as object);
			var ax_ = context?.Operators?.TypeConverter.Convert<Integer>(aw_);
			var ay_ = (ap_ ?? ax_);
			var az_ = FHIRHelpers_4_0_001.ToInteger(ay_);
			var ba_ = D?.DosageInstruction;
			var bb_ = (ba_ as IEnumerable<Dosage>);
			var bc_ = context?.Operators.SingleOrNull<Dosage>(bb_);
			var bd_ = bc_?.Timing;
			var be_ = bd_?.Repeat;
			var bf_ = be_?.PeriodElement;
			var bg_ = FHIRHelpers_4_0_001.ToDecimal(bf_);
			var bh_ = D?.DosageInstruction;
			var bi_ = (bh_ as IEnumerable<Dosage>);
			var bj_ = context?.Operators.SingleOrNull<Dosage>(bi_);
			var bk_ = bj_?.Timing;
			var bl_ = bk_?.Repeat;
			var bm_ = bl_?.PeriodUnitElement;
			var bn_ = bm_?.Value;
			var bo_ = bn_;
			var bp_ = context?.Operators?.TypeConverter.Convert<string>(bo_);
			var bq_ = new CqlQuantity
			{
				value = bg_,
				unit = bp_,
			};
			var br_ = this.ToDaily(az_, bq_);
			var bs_ = D?.DosageInstruction;
			var bt_ = (bs_ as IEnumerable<Dosage>);
			var bu_ = context?.Operators.SingleOrNull<Dosage>(bt_);
			var bv_ = bu_?.Timing;
			var bw_ = bv_?.Repeat;
			var bx_ = bw_?.TimeOfDayElement;
			var by_ = (bx_ as IEnumerable<Time>);
			var bz_ = context?.Operators.CountOrNull<Time>(by_);
			var ca_ = context?.Operators.ConvertIntegerToDecimal(bz_);
			var cb_ = (br_ ?? ca_);
			var cc_ = (cb_ ?? (decimal?)1.0m);
			var cd_ = context?.Operators.ConvertDecimalToQuantity(cc_);
			var ce_ = context?.Operators.Multiply(ah_, cd_);
			var cf_ = context?.Operators.Divide(l_, ce_);
			var cg_ = (j_ ?? cf_);
			var ch_ = context?.Operators.Add(h_, cg_);

			return context?.Operators.Interval(d_, ch_, true, true);
		};
		var cl_ = context?.Operators.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(cj_, ck_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(cl_);
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
		var c_ = context?.Operators.Collapse(Intervals, "day");
		var d_ = (CqlInterval<CqlDateTime> X) =>
		{
			var a_ = context?.Operators.Start(X);
			var b_ = context?.Operators.End(X);

			return context?.Operators.DifferenceBetween(a_, b_, "day");
		};
		var e_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(c_, d_);

		return context?.Operators.Sum(e_);
	}


    [CqlDeclaration("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
	{
		IEnumerable<CqlInterval<CqlDateTime>> af_ = null;
		var ag_ = (af_ as IEnumerable<CqlInterval<CqlDateTime>>);
		var ah_ = (IEnumerable<CqlInterval<CqlDateTime>> R, CqlInterval<CqlDateTime> I) =>
		{
			var y_ = I;
			var z_ = new CqlInterval<CqlDateTime>[]
			{
				y_,
			};
			var aa_ = (CqlInterval<CqlDateTime> X) =>
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
			var ab_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(z_, aa_);
			var ac_ = context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(ab_);
			var ad_ = new CqlInterval<CqlDateTime>[]
			{
				ac_,
			};
			var ae_ = (ad_ as IEnumerable<CqlInterval<CqlDateTime>>);

			return context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(R, ae_);
		};

		return context?.Operators.AggregateOrNull<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, ag_, ah_);
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
		{
			CqlInterval<CqlDateTime> a__ = null;

			return (a__ as CqlInterval<CqlDateTime>);
		}
    }


    [CqlDeclaration("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(IEnumerable<object> Medications)
	{
		var f_ = (object M) =>
		{
			var a_ = M is MedicationRequest;

			return (a_ as bool?);
		};
		var g_ = context?.Operators.WhereOrNull<object>(Medications, f_);
		var h_ = (object M) => this.MedicationPeriod(M);
		var i_ = context?.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(g_, h_);
		var j_ = (object M) =>
		{
			var b_ = M is MedicationDispense;
			var c_ = (b_ as bool?);
			var d_ = M is MedicationAdministration;
			var e_ = (d_ as bool?);

			return context?.Operators.Or(c_, e_);
		};
		var k_ = context?.Operators.WhereOrNull<object>(Medications, j_);
		var l_ = (object M) => this.MedicationPeriod(M);
		var m_ = context?.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(k_, l_);
		var n_ = this.RolloutIntervals(m_);
		var o_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(i_, n_);

		return this.CumulativeDuration(o_);
	}


}