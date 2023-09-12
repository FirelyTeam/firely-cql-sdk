using System;
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

    private CqlCode AC_Value()
    {
        return new CqlCode("AC", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("AC")]
    public CqlCode AC() => __AC.Value;

    private CqlCode ACD_Value()
    {
        return new CqlCode("ACD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("ACD")]
    public CqlCode ACD() => __ACD.Value;

    private CqlCode ACM_Value()
    {
        return new CqlCode("ACM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("ACM")]
    public CqlCode ACM() => __ACM.Value;

    private CqlCode ACV_Value()
    {
        return new CqlCode("ACV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("ACV")]
    public CqlCode ACV() => __ACV.Value;

    private CqlCode AFT_Value()
    {
        return new CqlCode("AFT", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("AFT")]
    public CqlCode AFT() => __AFT.Value;

    private CqlCode AFT_early_Value()
    {
        return new CqlCode("AFT.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("AFT.early")]
    public CqlCode AFT_early() => __AFT_early.Value;

    private CqlCode AFT_late_Value()
    {
        return new CqlCode("AFT.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("AFT.late")]
    public CqlCode AFT_late() => __AFT_late.Value;

    private CqlCode C_Value()
    {
        return new CqlCode("C", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("C")]
    public CqlCode C() => __C.Value;

    private CqlCode CD_Value()
    {
        return new CqlCode("CD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("CD")]
    public CqlCode CD() => __CD.Value;

    private CqlCode CM_Value()
    {
        return new CqlCode("CM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("CM")]
    public CqlCode CM() => __CM.Value;

    private CqlCode CV_Value()
    {
        return new CqlCode("CV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("CV")]
    public CqlCode CV() => __CV.Value;

    private CqlCode EVE_Value()
    {
        return new CqlCode("EVE", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("EVE")]
    public CqlCode EVE() => __EVE.Value;

    private CqlCode EVE_early_Value()
    {
        return new CqlCode("EVE.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("EVE.early")]
    public CqlCode EVE_early() => __EVE_early.Value;

    private CqlCode EVE_late_Value()
    {
        return new CqlCode("EVE.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("EVE.late")]
    public CqlCode EVE_late() => __EVE_late.Value;

    private CqlCode HS_Value()
    {
        return new CqlCode("HS", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("HS")]
    public CqlCode HS() => __HS.Value;

    private CqlCode MORN_Value()
    {
        return new CqlCode("MORN", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("MORN")]
    public CqlCode MORN() => __MORN.Value;

    private CqlCode MORN_early_Value()
    {
        return new CqlCode("MORN.early", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("MORN.early")]
    public CqlCode MORN_early() => __MORN_early.Value;

    private CqlCode MORN_late_Value()
    {
        return new CqlCode("MORN.late", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("MORN.late")]
    public CqlCode MORN_late() => __MORN_late.Value;

    private CqlCode NIGHT_Value()
    {
        return new CqlCode("NIGHT", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("NIGHT")]
    public CqlCode NIGHT() => __NIGHT.Value;

    private CqlCode NOON_Value()
    {
        return new CqlCode("NOON", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("NOON")]
    public CqlCode NOON() => __NOON.Value;

    private CqlCode PC_Value()
    {
        return new CqlCode("PC", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("PC")]
    public CqlCode PC() => __PC.Value;

    private CqlCode PCD_Value()
    {
        return new CqlCode("PCD", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("PCD")]
    public CqlCode PCD() => __PCD.Value;

    private CqlCode PCM_Value()
    {
        return new CqlCode("PCM", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("PCM")]
    public CqlCode PCM() => __PCM.Value;

    private CqlCode PCV_Value()
    {
        return new CqlCode("PCV", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

    [CqlDeclaration("PCV")]
    public CqlCode PCV() => __PCV.Value;

    private CqlCode PHS_Value()
    {
        return new CqlCode("PHS", 
			"http://hl7.org/fhir/event-timing", 
			null, 
			null);
    }

    [CqlDeclaration("PHS")]
    public CqlCode PHS() => __PHS.Value;

    private CqlCode WAKE_Value()
    {
        return new CqlCode("WAKE", 
			"http://terminology.hl7.org/CodeSystem/v3-TimingEvent", 
			null, 
			null);
    }

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

    private string ErrorLevel_Value()
    {
        return ((string)context.ResolveParameter("CumulativeMedicationDurationFHIR4-1.0.000", 
			"ErrorLevel", 
			("Warning" as object)));
    }

    [CqlDeclaration("ErrorLevel")]
    public string ErrorLevel() => __ErrorLevel.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("ToDaily")]
    public decimal? ToDaily(int? frequency, CqlQuantity period)
    {
        if ((context?.Operators.Equal((period?.unit as object), 
				("h" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                return context?.Operators.Multiply(a__, 
					c__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("min" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)60));
                return context?.Operators.Multiply(d__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("s" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)60));
                var f__ = context?.Operators.Multiply(d__, 
					e__);
                return context?.Operators.Multiply(f__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("d" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)24));
                return context?.Operators.Divide(d__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("wk" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)7));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("mo" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)30));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("a" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)365));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("hour" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                return context?.Operators.Multiply(a__, 
					c__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("minute" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)60));
                return context?.Operators.Multiply(d__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("second" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)60));
                var f__ = context?.Operators.Multiply(d__, 
					e__);
                return context?.Operators.Multiply(f__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("day" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)24));
                return context?.Operators.Divide(d__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("week" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)7));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("month" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)30));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("year" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)365));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("hours" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                return context?.Operators.Multiply(a__, 
					c__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("minutes" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)60));
                return context?.Operators.Multiply(d__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("seconds" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)60));
                var f__ = context?.Operators.Multiply(d__, 
					e__);
                return context?.Operators.Multiply(f__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("days" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.ConvertIntegerToDecimal(((int?)24));
                return context?.Operators.Divide(d__, 
					e__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("weeks" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)7));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("months" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)30));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else if ((context?.Operators.Equal((period?.unit as object), 
				("years" as object)) ?? false))
            {
                var a__ = context?.Operators.ConvertIntegerToDecimal(frequency);
                var b__ = period?.value;
                var c__ = context?.Operators.Divide(((decimal?)24.0m), 
					b__);
                var d__ = context?.Operators.Multiply(a__, 
					c__);
                var e__ = context?.Operators.Multiply(((int?)24), 
					((int?)365));
                var f__ = context?.Operators.ConvertIntegerToDecimal(e__);
                return context?.Operators.Divide(d__, 
					f__);
            }
        else 
            return ((decimal?)context?.Operators.Message<object>((null as object), 
				"CMDLogic.ToDaily.UnknownUnit", 
				this.ErrorLevel(), 
				context?.Operators.Concatenate(("Unknown unit " ?? ""), 
					(period?.unit ?? ""))));

    }


    [CqlDeclaration("ToDaily")]
    public decimal? ToDaily(CqlCode frequency)
    {
        if ((context?.Operators.Equal((frequency as object), 
				(this.C() as object)) ?? false))
            return ((decimal?)3.0m);

        else 
            return ((decimal?)context?.Operators.Message<object>((null as object), 
				"CMDLogic.ToDaily.UnknownFrequencyCode", 
				this.ErrorLevel(), 
				context?.Operators.Concatenate(("Unknown frequency code " ?? ""), 
					(frequency?.code ?? ""))));

    }


    [CqlDeclaration("MedicationRequestPeriod")]
    public CqlInterval<CqlDateTime> MedicationRequestPeriod(MedicationRequest Request)
    {
        var b_ = Request;
        var a_ = new MedicationRequest[]
		{
			b_,
		};
        Func<MedicationRequest,CqlInterval<CqlDateTime>> c_ = (R) => (((context?.Operators.Not(context?.Operators.Or(((bool?)(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval((((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as object) as Period))) == null)), 
					context?.Operators.Equal((context?.Operators.End(FHIRHelpers_4_0_001.ToInterval((((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as object) as Period))) as object), 
						(context?.Operators.Maximum<CqlDateTime>() as object)))) ?? false))
				? (context?.Operators.Interval(((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as object) as Period))) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), 
						context?.Operators.End(FHIRHelpers_4_0_001.ToInterval((((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as object) as Period))), 
						true, 
						true))
				: (context?.Operators.Interval(((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as object) as Period))) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), 
						context?.Operators.Add(((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.Bounds as object) as Period))) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(R?.DispenseRequest?.ValidityPeriod))) ?? FHIRHelpers_4_0_001.ToDateTime(R?.AuthoredOnElement)), 
							context?.Operators.Multiply((FHIRHelpers_4_0_001.ToQuantity(((Quantity)R?.DispenseRequest?.ExpectedSupplyDuration)) ?? context?.Operators.Divide(FHIRHelpers_4_0_001.ToQuantity(R?.DispenseRequest?.Quantity), 
									context?.Operators.Multiply((context?.Operators.End(FHIRHelpers_4_0_001.ToInterval((((context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose as object) as Range))) ?? FHIRHelpers_4_0_001.ToQuantity((((context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose as object) as Quantity))), 
										context?.Operators.ConvertDecimalToQuantity(((this.ToDaily(FHIRHelpers_4_0_001.ToInteger((context?.Operators.Convert<Integer>(((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyMaxElement as object)) ?? context?.Operators.Convert<Integer>(((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyElement as object)))), 
												new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodElement), 
													context?.Operators.Convert<string>((((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodUnitElement)?.Value as object)))) ?? context?.Operators.ConvertIntegerToDecimal(context?.Operators.CountOrNull<Time>(((((context?.Operators.SingleOrNull<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.TimeOfDayElement as IEnumerable<Time>)))) ?? ((decimal?)1.0m)))))), 
								context?.Operators.ConvertIntegerToQuantity(context?.Operators.Add(((int?)1), 
										(FHIRHelpers_4_0_001.ToInteger(context?.Operators.Convert<Integer>((R?.DispenseRequest?.NumberOfRepeatsAllowedElement as object))) ?? ((int?)0)))))), 
						true, 
						true)))
;
        var d_ = context?.Operators.SelectOrNull<MedicationRequest, CqlInterval<CqlDateTime>>(a_, 
			c_);
        return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
    }

    [CqlDeclaration("MedicationDispensePeriod")]
    public CqlInterval<CqlDateTime> MedicationDispensePeriod(MedicationDispense Dispense)
    {
        var b_ = Dispense;
        var a_ = new MedicationDispense[]
		{
			b_,
		};
        Func<MedicationDispense,CqlInterval<CqlDateTime>> ab_ = (D) => 
        {
            var c_ = (D?.WhenHandedOverElement ?? D?.WhenPreparedElement);
            var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
            var h_ = D?.DaysSupply;
            var i_ = D?.Quantity;
            var j_ = FHIRHelpers_4_0_001.ToQuantity(i_);
            var l_ = (((context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context?.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose as object) as Range);
            var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
            var n_ = (((context?.Operators.SingleOrNull<Dosage.DoseAndRateComponent>(((context?.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>)))?.Dose as object) as Quantity);
            var k_ = (context?.Operators.End(m_) ?? FHIRHelpers_4_0_001.ToQuantity(n_));
            var q_ = ((((context?.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyMaxElement as object);
            var r_ = ((((context?.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.FrequencyElement as object);
            var p_ = (context?.Operators.Convert<Integer>(q_) ?? context?.Operators.Convert<Integer>(r_));
            var s_ = FHIRHelpers_4_0_001.ToInteger(p_);
            var u_ = (((context?.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodElement;
            var v_ = (((((context?.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.PeriodUnitElement)?.Value as object);
            var t_ = new CqlQuantity(FHIRHelpers_4_0_001.ToDecimal(u_), 
				context?.Operators.Convert<string>(v_));
            var w_ = ((((context?.Operators.SingleOrNull<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>)))?.Timing)?.Repeat)?.TimeOfDayElement as IEnumerable<Time>);
            var x_ = context?.Operators.CountOrNull<Time>(w_);
            var o_ = ((this.ToDaily(s_, 
				t_) ?? context?.Operators.ConvertIntegerToDecimal(x_)) ?? ((decimal?)1.0m));
            var y_ = context?.Operators.ConvertDecimalToQuantity(o_);
            var z_ = context?.Operators.Multiply(k_, 
				y_);
            var g_ = (FHIRHelpers_4_0_001.ToQuantity(h_) ?? context?.Operators.Divide(j_, 
				z_));
            var aa_ = context?.Operators.Add(d_, 
				g_);
            return context?.Operators.Interval(d_, 
				aa_, 
				true, 
				true);
        };
        var ac_ = context?.Operators.SelectOrNull<MedicationDispense, CqlInterval<CqlDateTime>>(a_, 
			ab_);
        return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(ac_);
    }

    [CqlDeclaration("TherapeuticDuration")]
    public CqlQuantity TherapeuticDuration(CqlConcept medication)
    {
        return context?.Operators.Quantity(14m, 
			"days");
    }

    [CqlDeclaration("MedicationAdministrationPeriod")]
    public CqlInterval<CqlDateTime> MedicationAdministrationPeriod(MedicationAdministration Administration)
    {
        var b_ = Administration;
        var a_ = new MedicationAdministration[]
		{
			b_,
		};
        Func<MedicationAdministration,CqlInterval<CqlDateTime>> c_ = (M) => (((context?.Operators.And(context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((Administration?.Effective as object) as Period))) == null))), 
				context?.Operators.Not(((bool?)(this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept(((Administration?.Medication as object) as CodeableConcept))) == null)))) ?? false))
				? (context?.Operators.Interval(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((Administration?.Effective as object) as Period))), 
						context?.Operators.Add(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(((Administration?.Effective as object) as Period))), 
							this.TherapeuticDuration(FHIRHelpers_4_0_001.ToConcept(((Administration?.Medication as object) as CodeableConcept)))), 
						true, 
						true))
				: ((null as CqlInterval<CqlDateTime>)))
;
        var d_ = context?.Operators.SelectOrNull<MedicationAdministration, CqlInterval<CqlDateTime>>(a_, 
			c_);
        return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
    }

    [CqlDeclaration("CumulativeDuration")]
    public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDateTime>> Intervals)
    {
        var a_ = context?.Operators.Collapse(Intervals, 
			"day");
        Func<CqlInterval<CqlDateTime>,int?> d_ = (X) => 
        {
            var b_ = context?.Operators.Start(X);
            var c_ = context?.Operators.End(X);
            return context?.Operators.DifferenceBetween(b_, 
				c_, 
				"day");
        };
        var e_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, int?>(a_, 
			d_);
        return context?.Operators.Sum(e_);
    }

    [CqlDeclaration("RolloutIntervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> RolloutIntervals(IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        var a_ = (null as IEnumerable<CqlInterval<CqlDateTime>>);
        Func<IEnumerable<CqlInterval<CqlDateTime>>,CqlInterval<CqlDateTime>,IEnumerable<CqlInterval<CqlDateTime>>> aa_ = (R, I) => 
        {
            var e_ = I;
            var d_ = new CqlInterval<CqlDateTime>[]
			{
				e_,
			};
            Func<CqlInterval<CqlDateTime>,CqlInterval<CqlDateTime>> y_ = (X) => 
            {
                var h_ = context?.Operators.LastOfList<CqlInterval<CqlDateTime>>(R);
                var i_ = context?.Operators.End(h_);
                var j_ = context?.Operators.Quantity(1m, 
					"day");
                var g_ = context?.Operators.Add(i_, 
					j_);
                var k_ = context?.Operators.Start(X);
                var f_ = (new CqlDateTime[]
				{
					g_,
					k_,
				} as IEnumerable<CqlDateTime>);
                var l_ = context?.Operators.MaxOrNull<CqlDateTime>(f_);
                var w_ = context?.Operators.End(X);
                var u_ = (context?.Operators.DurationBetween(k_, 
					w_, 
					"day") ?? ((int?)0));
                var t_ = new CqlQuantity(context?.Operators.ConvertIntegerToDecimal(u_), 
					"day");
                var x_ = context?.Operators.Add(l_, 
					t_);
                return context?.Operators.Interval(l_, 
					x_, 
					true, 
					true);
            };
            var z_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, 
				y_);
            var c_ = context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(z_);
            var b_ = (new CqlInterval<CqlDateTime>[]
			{
				c_,
			} as IEnumerable<CqlInterval<CqlDateTime>>);
            return context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(R, 
				b_);
        };
        return context?.Operators.AggregateOrNull<CqlInterval<CqlDateTime>, IEnumerable<CqlInterval<CqlDateTime>>>(intervals, 
			a_, 
			aa_);
    }

    [CqlDeclaration("MedicationPeriod")]
    public CqlInterval<CqlDateTime> MedicationPeriod(object medication)
    {
        if (((medication is MedicationRequest as bool?) ?? false))
            {
                var a__ = (medication as MedicationRequest);
                return this.MedicationRequestPeriod(a__);
            }
        else if (((medication is MedicationDispense as bool?) ?? false))
            {
                var a__ = (medication as MedicationDispense);
                return this.MedicationDispensePeriod(a__);
            }
        else if (((medication is MedicationAdministration as bool?) ?? false))
            {
                var a__ = (medication as MedicationAdministration);
                return this.MedicationAdministrationPeriod(a__);
            }
        else 
            return (null as CqlInterval<CqlDateTime>);

    }


    [CqlDeclaration("CumulativeMedicationDuration")]
    public int? CumulativeMedicationDuration(IEnumerable<object> Medications)
    {
        Func<object,bool?> a_ = (M) => (M is MedicationRequest as bool?);
        var b_ = context?.Operators.WhereOrNull<object>(Medications, 
			a_);
        Func<object,CqlInterval<CqlDateTime>> c_ = (M) => 
        {
            return this.MedicationPeriod(M);
        };
        var d_ = context?.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(b_, 
			c_);
        Func<object,bool?> g_ = (M) => 
        {
            var e_ = (M is MedicationDispense as bool?);
            var f_ = (M is MedicationAdministration as bool?);
            return context?.Operators.Or(e_, 
				f_);
        };
        var h_ = context?.Operators.WhereOrNull<object>(Medications, 
			g_);
        var j_ = context?.Operators.SelectOrNull<object, CqlInterval<CqlDateTime>>(h_, 
			c_);
        var k_ = this.RolloutIntervals(j_);
        var l_ = context?.Operators.ListUnion<CqlInterval<CqlDateTime>>(d_, 
			k_);
        return this.CumulativeDuration(l_);
    }

}