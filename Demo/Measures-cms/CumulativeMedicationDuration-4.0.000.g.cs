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
[CqlLibrary("CumulativeMedicationDuration", "4.0.000")]
public class CumulativeMedicationDuration_4_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode> __HS;
    internal Lazy<CqlCode> __WAKE;
    internal Lazy<CqlCode> __C;
    internal Lazy<CqlCode> __CM;
    internal Lazy<CqlCode> __CD;
    internal Lazy<CqlCode> __CV;
    internal Lazy<CqlCode> __AC;
    internal Lazy<CqlCode> __ACM;
    internal Lazy<CqlCode> __ACD;
    internal Lazy<CqlCode> __ACV;
    internal Lazy<CqlCode> __PC;
    internal Lazy<CqlCode> __PCM;
    internal Lazy<CqlCode> __PCD;
    internal Lazy<CqlCode> __PCV;
    internal Lazy<CqlCode> __MORN;
    internal Lazy<CqlCode> __MORN_early;
    internal Lazy<CqlCode> __MORN_late;
    internal Lazy<CqlCode> __NOON;
    internal Lazy<CqlCode> __AFT;
    internal Lazy<CqlCode> __AFT_early;
    internal Lazy<CqlCode> __AFT_late;
    internal Lazy<CqlCode> __EVE;
    internal Lazy<CqlCode> __EVE_early;
    internal Lazy<CqlCode> __EVE_late;
    internal Lazy<CqlCode> __NIGHT;
    internal Lazy<CqlCode> __PHS;
    internal Lazy<CqlCode> __Every_eight_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_eight_to_twelve_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_forty_eight_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_forty_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_four_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_seventy_two_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_six_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_six_to_eight_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_thirty_six_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_three_to_four_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_three_to_six_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_twelve_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_twenty_four_hours__qualifier_value_;
    internal Lazy<CqlCode> __Every_two_to_four_hours__qualifier_value_;
    internal Lazy<CqlCode> __Four_times_daily__qualifier_value_;
    internal Lazy<CqlCode> __Once_daily__qualifier_value_;
    internal Lazy<CqlCode> __One_to_four_times_a_day__qualifier_value_;
    internal Lazy<CqlCode> __One_to_three_times_a_day__qualifier_value_;
    internal Lazy<CqlCode> __One_to_two_times_a_day__qualifier_value_;
    internal Lazy<CqlCode> __Three_times_daily__qualifier_value_;
    internal Lazy<CqlCode> __Twice_a_day__qualifier_value_;
    internal Lazy<CqlCode> __Two_to_four_times_a_day__qualifier_value_;
    internal Lazy<CqlCode[]> __V3TimingEvent;
    internal Lazy<CqlCode[]> __EventTiming;
    internal Lazy<string> __ErrorLevel;
    internal Lazy<Patient> __Patient;

    #endregion
    public CumulativeMedicationDuration_4_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __HS = new Lazy<CqlCode>(this.HS_Value);
        __WAKE = new Lazy<CqlCode>(this.WAKE_Value);
        __C = new Lazy<CqlCode>(this.C_Value);
        __CM = new Lazy<CqlCode>(this.CM_Value);
        __CD = new Lazy<CqlCode>(this.CD_Value);
        __CV = new Lazy<CqlCode>(this.CV_Value);
        __AC = new Lazy<CqlCode>(this.AC_Value);
        __ACM = new Lazy<CqlCode>(this.ACM_Value);
        __ACD = new Lazy<CqlCode>(this.ACD_Value);
        __ACV = new Lazy<CqlCode>(this.ACV_Value);
        __PC = new Lazy<CqlCode>(this.PC_Value);
        __PCM = new Lazy<CqlCode>(this.PCM_Value);
        __PCD = new Lazy<CqlCode>(this.PCD_Value);
        __PCV = new Lazy<CqlCode>(this.PCV_Value);
        __MORN = new Lazy<CqlCode>(this.MORN_Value);
        __MORN_early = new Lazy<CqlCode>(this.MORN_early_Value);
        __MORN_late = new Lazy<CqlCode>(this.MORN_late_Value);
        __NOON = new Lazy<CqlCode>(this.NOON_Value);
        __AFT = new Lazy<CqlCode>(this.AFT_Value);
        __AFT_early = new Lazy<CqlCode>(this.AFT_early_Value);
        __AFT_late = new Lazy<CqlCode>(this.AFT_late_Value);
        __EVE = new Lazy<CqlCode>(this.EVE_Value);
        __EVE_early = new Lazy<CqlCode>(this.EVE_early_Value);
        __EVE_late = new Lazy<CqlCode>(this.EVE_late_Value);
        __NIGHT = new Lazy<CqlCode>(this.NIGHT_Value);
        __PHS = new Lazy<CqlCode>(this.PHS_Value);
        __Every_eight_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_eight_hours__qualifier_value__Value);
        __Every_eight_to_twelve_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_eight_to_twelve_hours__qualifier_value__Value);
        __Every_forty_eight_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_forty_eight_hours__qualifier_value__Value);
        __Every_forty_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_forty_hours__qualifier_value__Value);
        __Every_four_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_four_hours__qualifier_value__Value);
        __Every_seventy_two_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_seventy_two_hours__qualifier_value__Value);
        __Every_six_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_six_hours__qualifier_value__Value);
        __Every_six_to_eight_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_six_to_eight_hours__qualifier_value__Value);
        __Every_thirty_six_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_thirty_six_hours__qualifier_value__Value);
        __Every_three_to_four_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_three_to_four_hours__qualifier_value__Value);
        __Every_three_to_six_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_three_to_six_hours__qualifier_value__Value);
        __Every_twelve_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_twelve_hours__qualifier_value__Value);
        __Every_twenty_four_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_twenty_four_hours__qualifier_value__Value);
        __Every_two_to_four_hours__qualifier_value_ = new Lazy<CqlCode>(this.Every_two_to_four_hours__qualifier_value__Value);
        __Four_times_daily__qualifier_value_ = new Lazy<CqlCode>(this.Four_times_daily__qualifier_value__Value);
        __Once_daily__qualifier_value_ = new Lazy<CqlCode>(this.Once_daily__qualifier_value__Value);
        __One_to_four_times_a_day__qualifier_value_ = new Lazy<CqlCode>(this.One_to_four_times_a_day__qualifier_value__Value);
        __One_to_three_times_a_day__qualifier_value_ = new Lazy<CqlCode>(this.One_to_three_times_a_day__qualifier_value__Value);
        __One_to_two_times_a_day__qualifier_value_ = new Lazy<CqlCode>(this.One_to_two_times_a_day__qualifier_value__Value);
        __Three_times_daily__qualifier_value_ = new Lazy<CqlCode>(this.Three_times_daily__qualifier_value__Value);
        __Twice_a_day__qualifier_value_ = new Lazy<CqlCode>(this.Twice_a_day__qualifier_value__Value);
        __Two_to_four_times_a_day__qualifier_value_ = new Lazy<CqlCode>(this.Two_to_four_times_a_day__qualifier_value__Value);
        __V3TimingEvent = new Lazy<CqlCode[]>(this.V3TimingEvent_Value);
        __EventTiming = new Lazy<CqlCode[]>(this.EventTiming_Value);
        __ErrorLevel = new Lazy<string>(this.ErrorLevel_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlCode HS_Value() => 
		new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("HS")]
	public CqlCode HS() => 
		__HS.Value;

	private CqlCode WAKE_Value() => 
		new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("WAKE")]
	public CqlCode WAKE() => 
		__WAKE.Value;

	private CqlCode C_Value() => 
		new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("C")]
	public CqlCode C() => 
		__C.Value;

	private CqlCode CM_Value() => 
		new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CM")]
	public CqlCode CM() => 
		__CM.Value;

	private CqlCode CD_Value() => 
		new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CD")]
	public CqlCode CD() => 
		__CD.Value;

	private CqlCode CV_Value() => 
		new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("CV")]
	public CqlCode CV() => 
		__CV.Value;

	private CqlCode AC_Value() => 
		new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("AC")]
	public CqlCode AC() => 
		__AC.Value;

	private CqlCode ACM_Value() => 
		new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACM")]
	public CqlCode ACM() => 
		__ACM.Value;

	private CqlCode ACD_Value() => 
		new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACD")]
	public CqlCode ACD() => 
		__ACD.Value;

	private CqlCode ACV_Value() => 
		new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("ACV")]
	public CqlCode ACV() => 
		__ACV.Value;

	private CqlCode PC_Value() => 
		new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PC")]
	public CqlCode PC() => 
		__PC.Value;

	private CqlCode PCM_Value() => 
		new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCM")]
	public CqlCode PCM() => 
		__PCM.Value;

	private CqlCode PCD_Value() => 
		new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCD")]
	public CqlCode PCD() => 
		__PCD.Value;

	private CqlCode PCV_Value() => 
		new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null);

    [CqlDeclaration("PCV")]
	public CqlCode PCV() => 
		__PCV.Value;

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

	private CqlCode NOON_Value() => 
		new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NOON")]
	public CqlCode NOON() => 
		__NOON.Value;

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

	private CqlCode NIGHT_Value() => 
		new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("NIGHT")]
	public CqlCode NIGHT() => 
		__NIGHT.Value;

	private CqlCode PHS_Value() => 
		new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null);

    [CqlDeclaration("PHS")]
	public CqlCode PHS() => 
		__PHS.Value;

	private CqlCode Every_eight_hours__qualifier_value__Value() => 
		new CqlCode("307469008", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every eight hours (qualifier value)")]
	public CqlCode Every_eight_hours__qualifier_value_() => 
		__Every_eight_hours__qualifier_value_.Value;

	private CqlCode Every_eight_to_twelve_hours__qualifier_value__Value() => 
		new CqlCode("396140003", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every eight to twelve hours (qualifier value)")]
	public CqlCode Every_eight_to_twelve_hours__qualifier_value_() => 
		__Every_eight_to_twelve_hours__qualifier_value_.Value;

	private CqlCode Every_forty_eight_hours__qualifier_value__Value() => 
		new CqlCode("396131002", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every forty eight hours (qualifier value)")]
	public CqlCode Every_forty_eight_hours__qualifier_value_() => 
		__Every_forty_eight_hours__qualifier_value_.Value;

	private CqlCode Every_forty_hours__qualifier_value__Value() => 
		new CqlCode("396130001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every forty hours (qualifier value)")]
	public CqlCode Every_forty_hours__qualifier_value_() => 
		__Every_forty_hours__qualifier_value_.Value;

	private CqlCode Every_four_hours__qualifier_value__Value() => 
		new CqlCode("225756002", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every four hours (qualifier value)")]
	public CqlCode Every_four_hours__qualifier_value_() => 
		__Every_four_hours__qualifier_value_.Value;

	private CqlCode Every_seventy_two_hours__qualifier_value__Value() => 
		new CqlCode("396143001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every seventy two hours (qualifier value)")]
	public CqlCode Every_seventy_two_hours__qualifier_value_() => 
		__Every_seventy_two_hours__qualifier_value_.Value;

	private CqlCode Every_six_hours__qualifier_value__Value() => 
		new CqlCode("307468000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every six hours (qualifier value)")]
	public CqlCode Every_six_hours__qualifier_value_() => 
		__Every_six_hours__qualifier_value_.Value;

	private CqlCode Every_six_to_eight_hours__qualifier_value__Value() => 
		new CqlCode("396139000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every six to eight hours (qualifier value)")]
	public CqlCode Every_six_to_eight_hours__qualifier_value_() => 
		__Every_six_to_eight_hours__qualifier_value_.Value;

	private CqlCode Every_thirty_six_hours__qualifier_value__Value() => 
		new CqlCode("396126004", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every thirty six hours (qualifier value)")]
	public CqlCode Every_thirty_six_hours__qualifier_value_() => 
		__Every_thirty_six_hours__qualifier_value_.Value;

	private CqlCode Every_three_to_four_hours__qualifier_value__Value() => 
		new CqlCode("225754004", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every three to four hours (qualifier value)")]
	public CqlCode Every_three_to_four_hours__qualifier_value_() => 
		__Every_three_to_four_hours__qualifier_value_.Value;

	private CqlCode Every_three_to_six_hours__qualifier_value__Value() => 
		new CqlCode("396127008", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every three to six hours (qualifier value)")]
	public CqlCode Every_three_to_six_hours__qualifier_value_() => 
		__Every_three_to_six_hours__qualifier_value_.Value;

	private CqlCode Every_twelve_hours__qualifier_value__Value() => 
		new CqlCode("307470009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every twelve hours (qualifier value)")]
	public CqlCode Every_twelve_hours__qualifier_value_() => 
		__Every_twelve_hours__qualifier_value_.Value;

	private CqlCode Every_twenty_four_hours__qualifier_value__Value() => 
		new CqlCode("396125000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every twenty four hours (qualifier value)")]
	public CqlCode Every_twenty_four_hours__qualifier_value_() => 
		__Every_twenty_four_hours__qualifier_value_.Value;

	private CqlCode Every_two_to_four_hours__qualifier_value__Value() => 
		new CqlCode("225752000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Every two to four hours (qualifier value)")]
	public CqlCode Every_two_to_four_hours__qualifier_value_() => 
		__Every_two_to_four_hours__qualifier_value_.Value;

	private CqlCode Four_times_daily__qualifier_value__Value() => 
		new CqlCode("307439001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Four times daily (qualifier value)")]
	public CqlCode Four_times_daily__qualifier_value_() => 
		__Four_times_daily__qualifier_value_.Value;

	private CqlCode Once_daily__qualifier_value__Value() => 
		new CqlCode("229797004", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Once daily (qualifier value)")]
	public CqlCode Once_daily__qualifier_value_() => 
		__Once_daily__qualifier_value_.Value;

	private CqlCode One_to_four_times_a_day__qualifier_value__Value() => 
		new CqlCode("396109005", "http://snomed.info/sct", null, null);

    [CqlDeclaration("One to four times a day (qualifier value)")]
	public CqlCode One_to_four_times_a_day__qualifier_value_() => 
		__One_to_four_times_a_day__qualifier_value_.Value;

	private CqlCode One_to_three_times_a_day__qualifier_value__Value() => 
		new CqlCode("396108002", "http://snomed.info/sct", null, null);

    [CqlDeclaration("One to three times a day (qualifier value)")]
	public CqlCode One_to_three_times_a_day__qualifier_value_() => 
		__One_to_three_times_a_day__qualifier_value_.Value;

	private CqlCode One_to_two_times_a_day__qualifier_value__Value() => 
		new CqlCode("396107007", "http://snomed.info/sct", null, null);

    [CqlDeclaration("One to two times a day (qualifier value)")]
	public CqlCode One_to_two_times_a_day__qualifier_value_() => 
		__One_to_two_times_a_day__qualifier_value_.Value;

	private CqlCode Three_times_daily__qualifier_value__Value() => 
		new CqlCode("229798009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Three times daily (qualifier value)")]
	public CqlCode Three_times_daily__qualifier_value_() => 
		__Three_times_daily__qualifier_value_.Value;

	private CqlCode Twice_a_day__qualifier_value__Value() => 
		new CqlCode("229799001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Twice a day (qualifier value)")]
	public CqlCode Twice_a_day__qualifier_value_() => 
		__Twice_a_day__qualifier_value_.Value;

	private CqlCode Two_to_four_times_a_day__qualifier_value__Value() => 
		new CqlCode("396111001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Two to four times a day (qualifier value)")]
	public CqlCode Two_to_four_times_a_day__qualifier_value_() => 
		__Two_to_four_times_a_day__qualifier_value_.Value;

	private CqlCode[] V3TimingEvent_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("HS", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("WAKE", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("C", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("CV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("AC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("ACV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PC", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCM", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCD", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
			new CqlCode("PCV", "http://terminology.hl7.org/CodeSystem/v3-TimingEvent", null, null),
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
			new CqlCode("MORN", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("MORN.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("NOON", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("AFT", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("AFT.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("AFT.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE.early", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("EVE.late", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("NIGHT", "http://hl7.org/fhir/event-timing", null, null),
			new CqlCode("PHS", "http://hl7.org/fhir/event-timing", null, null),
		};

		return a_;
	}

    [CqlDeclaration("EventTiming")]
	public CqlCode[] EventTiming() => 
		__EventTiming.Value;

	private string ErrorLevel_Value()
	{
		object a_ = context.ResolveParameter("CumulativeMedicationDuration-4.0.000", "ErrorLevel", "Warning");

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
				CqlCode aw_ = this.HS();
				bool? ax_ = context.Operators.Equivalent(frequency, aw_);

				return (ax_ ?? false);
			};
			bool c_()
			{
				CqlCode ay_ = this.WAKE();
				bool? az_ = context.Operators.Equivalent(frequency, ay_);

				return (az_ ?? false);
			};
			bool d_()
			{
				CqlCode ba_ = this.C();
				bool? bb_ = context.Operators.Equivalent(frequency, ba_);

				return (bb_ ?? false);
			};
			bool e_()
			{
				CqlCode bc_ = this.CM();
				bool? bd_ = context.Operators.Equivalent(frequency, bc_);

				return (bd_ ?? false);
			};
			bool f_()
			{
				CqlCode be_ = this.CD();
				bool? bf_ = context.Operators.Equivalent(frequency, be_);

				return (bf_ ?? false);
			};
			bool g_()
			{
				CqlCode bg_ = this.CV();
				bool? bh_ = context.Operators.Equivalent(frequency, bg_);

				return (bh_ ?? false);
			};
			bool h_()
			{
				CqlCode bi_ = this.AC();
				bool? bj_ = context.Operators.Equivalent(frequency, bi_);

				return (bj_ ?? false);
			};
			bool i_()
			{
				CqlCode bk_ = this.ACM();
				bool? bl_ = context.Operators.Equivalent(frequency, bk_);

				return (bl_ ?? false);
			};
			bool j_()
			{
				CqlCode bm_ = this.ACD();
				bool? bn_ = context.Operators.Equivalent(frequency, bm_);

				return (bn_ ?? false);
			};
			bool k_()
			{
				CqlCode bo_ = this.ACV();
				bool? bp_ = context.Operators.Equivalent(frequency, bo_);

				return (bp_ ?? false);
			};
			bool l_()
			{
				CqlCode bq_ = this.PC();
				bool? br_ = context.Operators.Equivalent(frequency, bq_);

				return (br_ ?? false);
			};
			bool m_()
			{
				CqlCode bs_ = this.PCM();
				bool? bt_ = context.Operators.Equivalent(frequency, bs_);

				return (bt_ ?? false);
			};
			bool n_()
			{
				CqlCode bu_ = this.PCD();
				bool? bv_ = context.Operators.Equivalent(frequency, bu_);

				return (bv_ ?? false);
			};
			bool o_()
			{
				CqlCode bw_ = this.PCV();
				bool? bx_ = context.Operators.Equivalent(frequency, bw_);

				return (bx_ ?? false);
			};
			bool p_()
			{
				CqlCode by_ = this.MORN();
				bool? bz_ = context.Operators.Equivalent(frequency, by_);

				return (bz_ ?? false);
			};
			bool q_()
			{
				CqlCode ca_ = this.MORN_early();
				bool? cb_ = context.Operators.Equivalent(frequency, ca_);

				return (cb_ ?? false);
			};
			bool r_()
			{
				CqlCode cc_ = this.MORN_late();
				bool? cd_ = context.Operators.Equivalent(frequency, cc_);

				return (cd_ ?? false);
			};
			bool s_()
			{
				CqlCode ce_ = this.NOON();
				bool? cf_ = context.Operators.Equivalent(frequency, ce_);

				return (cf_ ?? false);
			};
			bool t_()
			{
				CqlCode cg_ = this.AFT();
				bool? ch_ = context.Operators.Equivalent(frequency, cg_);

				return (ch_ ?? false);
			};
			bool u_()
			{
				CqlCode ci_ = this.AFT_early();
				bool? cj_ = context.Operators.Equivalent(frequency, ci_);

				return (cj_ ?? false);
			};
			bool v_()
			{
				CqlCode ck_ = this.AFT_late();
				bool? cl_ = context.Operators.Equivalent(frequency, ck_);

				return (cl_ ?? false);
			};
			bool w_()
			{
				CqlCode cm_ = this.EVE();
				bool? cn_ = context.Operators.Equivalent(frequency, cm_);

				return (cn_ ?? false);
			};
			bool x_()
			{
				CqlCode co_ = this.EVE_early();
				bool? cp_ = context.Operators.Equivalent(frequency, co_);

				return (cp_ ?? false);
			};
			bool y_()
			{
				CqlCode cq_ = this.EVE_late();
				bool? cr_ = context.Operators.Equivalent(frequency, cq_);

				return (cr_ ?? false);
			};
			bool z_()
			{
				CqlCode cs_ = this.NIGHT();
				bool? ct_ = context.Operators.Equivalent(frequency, cs_);

				return (ct_ ?? false);
			};
			bool aa_()
			{
				CqlCode cu_ = this.PHS();
				bool? cv_ = context.Operators.Equivalent(frequency, cu_);

				return (cv_ ?? false);
			};
			bool ab_()
			{
				CqlCode cw_ = this.Once_daily__qualifier_value_();
				bool? cx_ = context.Operators.Equivalent(frequency, cw_);

				return (cx_ ?? false);
			};
			bool ac_()
			{
				CqlCode cy_ = this.Twice_a_day__qualifier_value_();
				bool? cz_ = context.Operators.Equivalent(frequency, cy_);

				return (cz_ ?? false);
			};
			bool ad_()
			{
				CqlCode da_ = this.Three_times_daily__qualifier_value_();
				bool? db_ = context.Operators.Equivalent(frequency, da_);

				return (db_ ?? false);
			};
			bool ae_()
			{
				CqlCode dc_ = this.Four_times_daily__qualifier_value_();
				bool? dd_ = context.Operators.Equivalent(frequency, dc_);

				return (dd_ ?? false);
			};
			bool af_()
			{
				CqlCode de_ = this.Every_twenty_four_hours__qualifier_value_();
				bool? df_ = context.Operators.Equivalent(frequency, de_);

				return (df_ ?? false);
			};
			bool ag_()
			{
				CqlCode dg_ = this.Every_twelve_hours__qualifier_value_();
				bool? dh_ = context.Operators.Equivalent(frequency, dg_);

				return (dh_ ?? false);
			};
			bool ah_()
			{
				CqlCode di_ = this.Every_thirty_six_hours__qualifier_value_();
				bool? dj_ = context.Operators.Equivalent(frequency, di_);

				return (dj_ ?? false);
			};
			bool ai_()
			{
				CqlCode dk_ = this.Every_eight_hours__qualifier_value_();
				bool? dl_ = context.Operators.Equivalent(frequency, dk_);

				return (dl_ ?? false);
			};
			bool aj_()
			{
				CqlCode dm_ = this.Every_four_hours__qualifier_value_();
				bool? dn_ = context.Operators.Equivalent(frequency, dm_);

				return (dn_ ?? false);
			};
			bool ak_()
			{
				CqlCode do_ = this.Every_six_hours__qualifier_value_();
				bool? dp_ = context.Operators.Equivalent(frequency, do_);

				return (dp_ ?? false);
			};
			bool al_()
			{
				CqlCode dq_ = this.Every_seventy_two_hours__qualifier_value_();
				bool? dr_ = context.Operators.Equivalent(frequency, dq_);

				return (dr_ ?? false);
			};
			bool am_()
			{
				CqlCode ds_ = this.Every_forty_eight_hours__qualifier_value_();
				bool? dt_ = context.Operators.Equivalent(frequency, ds_);

				return (dt_ ?? false);
			};
			bool an_()
			{
				CqlCode du_ = this.Every_eight_to_twelve_hours__qualifier_value_();
				bool? dv_ = context.Operators.Equivalent(frequency, du_);

				return (dv_ ?? false);
			};
			bool ao_()
			{
				CqlCode dw_ = this.Every_six_to_eight_hours__qualifier_value_();
				bool? dx_ = context.Operators.Equivalent(frequency, dw_);

				return (dx_ ?? false);
			};
			bool ap_()
			{
				CqlCode dy_ = this.Every_three_to_four_hours__qualifier_value_();
				bool? dz_ = context.Operators.Equivalent(frequency, dy_);

				return (dz_ ?? false);
			};
			bool aq_()
			{
				CqlCode ea_ = this.Every_three_to_six_hours__qualifier_value_();
				bool? eb_ = context.Operators.Equivalent(frequency, ea_);

				return (eb_ ?? false);
			};
			bool ar_()
			{
				CqlCode ec_ = this.Every_two_to_four_hours__qualifier_value_();
				bool? ed_ = context.Operators.Equivalent(frequency, ec_);

				return (ed_ ?? false);
			};
			bool as_()
			{
				CqlCode ee_ = this.One_to_four_times_a_day__qualifier_value_();
				bool? ef_ = context.Operators.Equivalent(frequency, ee_);

				return (ef_ ?? false);
			};
			bool at_()
			{
				CqlCode eg_ = this.One_to_three_times_a_day__qualifier_value_();
				bool? eh_ = context.Operators.Equivalent(frequency, eg_);

				return (eh_ ?? false);
			};
			bool au_()
			{
				CqlCode ei_ = this.One_to_two_times_a_day__qualifier_value_();
				bool? ej_ = context.Operators.Equivalent(frequency, ei_);

				return (ej_ ?? false);
			};
			bool av_()
			{
				CqlCode ek_ = this.Two_to_four_times_a_day__qualifier_value_();
				bool? el_ = context.Operators.Equivalent(frequency, ek_);

				return (el_ ?? false);
			};
			if (b_())
			{
				decimal? em_ = context.Operators.ConvertIntegerToDecimal(1);

				return em_;
			}
			else if (c_())
			{
				decimal? en_ = context.Operators.ConvertIntegerToDecimal(1);

				return en_;
			}
			else if (d_())
			{
				decimal? eo_ = context.Operators.ConvertIntegerToDecimal(3);

				return eo_;
			}
			else if (e_())
			{
				decimal? ep_ = context.Operators.ConvertIntegerToDecimal(1);

				return ep_;
			}
			else if (f_())
			{
				decimal? eq_ = context.Operators.ConvertIntegerToDecimal(1);

				return eq_;
			}
			else if (g_())
			{
				decimal? er_ = context.Operators.ConvertIntegerToDecimal(1);

				return er_;
			}
			else if (h_())
			{
				decimal? es_ = context.Operators.ConvertIntegerToDecimal(3);

				return es_;
			}
			else if (i_())
			{
				decimal? et_ = context.Operators.ConvertIntegerToDecimal(1);

				return et_;
			}
			else if (j_())
			{
				decimal? eu_ = context.Operators.ConvertIntegerToDecimal(1);

				return eu_;
			}
			else if (k_())
			{
				decimal? ev_ = context.Operators.ConvertIntegerToDecimal(1);

				return ev_;
			}
			else if (l_())
			{
				decimal? ew_ = context.Operators.ConvertIntegerToDecimal(3);

				return ew_;
			}
			else if (m_())
			{
				decimal? ex_ = context.Operators.ConvertIntegerToDecimal(1);

				return ex_;
			}
			else if (n_())
			{
				decimal? ey_ = context.Operators.ConvertIntegerToDecimal(1);

				return ey_;
			}
			else if (o_())
			{
				decimal? ez_ = context.Operators.ConvertIntegerToDecimal(1);

				return ez_;
			}
			else if (p_())
			{
				decimal? fa_ = context.Operators.ConvertIntegerToDecimal(1);

				return fa_;
			}
			else if (q_())
			{
				decimal? fb_ = context.Operators.ConvertIntegerToDecimal(1);

				return fb_;
			}
			else if (r_())
			{
				decimal? fc_ = context.Operators.ConvertIntegerToDecimal(1);

				return fc_;
			}
			else if (s_())
			{
				decimal? fd_ = context.Operators.ConvertIntegerToDecimal(1);

				return fd_;
			}
			else if (t_())
			{
				decimal? fe_ = context.Operators.ConvertIntegerToDecimal(1);

				return fe_;
			}
			else if (u_())
			{
				decimal? ff_ = context.Operators.ConvertIntegerToDecimal(1);

				return ff_;
			}
			else if (v_())
			{
				decimal? fg_ = context.Operators.ConvertIntegerToDecimal(1);

				return fg_;
			}
			else if (w_())
			{
				decimal? fh_ = context.Operators.ConvertIntegerToDecimal(1);

				return fh_;
			}
			else if (x_())
			{
				decimal? fi_ = context.Operators.ConvertIntegerToDecimal(1);

				return fi_;
			}
			else if (y_())
			{
				decimal? fj_ = context.Operators.ConvertIntegerToDecimal(1);

				return fj_;
			}
			else if (z_())
			{
				decimal? fk_ = context.Operators.ConvertIntegerToDecimal(1);

				return fk_;
			}
			else if (aa_())
			{
				decimal? fl_ = context.Operators.ConvertIntegerToDecimal(1);

				return fl_;
			}
			else if (ab_())
			{
				return 1.0m;
			}
			else if (ac_())
			{
				return 2.0m;
			}
			else if (ad_())
			{
				return 3.0m;
			}
			else if (ae_())
			{
				return 4.0m;
			}
			else if (af_())
			{
				return 1.0m;
			}
			else if (ag_())
			{
				return 2.0m;
			}
			else if (ah_())
			{
				return 0.67m;
			}
			else if (ai_())
			{
				return 3.0m;
			}
			else if (aj_())
			{
				return 6.0m;
			}
			else if (ak_())
			{
				return 4.0m;
			}
			else if (al_())
			{
				return 0.33m;
			}
			else if (am_())
			{
				return 0.5m;
			}
			else if (an_())
			{
				return 3.0m;
			}
			else if (ao_())
			{
				return 4.0m;
			}
			else if (ap_())
			{
				return 8.0m;
			}
			else if (aq_())
			{
				return 8.0m;
			}
			else if (ar_())
			{
				return 12.0m;
			}
			else if (as_())
			{
				return 4.0m;
			}
			else if (at_())
			{
				return 3.0m;
			}
			else if (au_())
			{
				return 2.0m;
			}
			else if (av_())
			{
				return 4.0m;
			}
			else
			{
				string fm_ = this.ErrorLevel();
				string fn_ = context.Operators.Concatenate("Unknown frequency code ", (frequency?.code ?? ""));
				object fo_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", fm_, fn_);

				return (decimal?)fo_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Quantity")]
	public CqlQuantity Quantity(decimal? value, string unit) => 
		((context.Operators.Not((bool?)(value is null)) ?? false)
			? (new CqlQuantity(value, unit))
			: null);

    [CqlDeclaration("MedicationRequestPeriod")]
	public CqlInterval<CqlDate> MedicationRequestPeriod(MedicationRequest Request)
	{
		MedicationRequest[] a_ = new MedicationRequest[]
		{
			Request,
		};
		CqlInterval<CqlDate> b_(MedicationRequest R)
		{
			CqlInterval<CqlDate> e_()
			{
				bool f_()
				{
					Dosage h_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					object i_ = FHIRHelpers_4_3_000.ToValue(h_?.Timing?.Repeat?.Bounds);
					CqlDateTime j_ = context.Operators.Start((i_ as CqlInterval<CqlDateTime>));
					CqlDate k_ = context.Operators.DateFrom(j_);
					CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					CqlDate m_ = context.Operators.DateFrom(l_);
					CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					CqlDateTime o_ = context.Operators.Start(n_);
					CqlDate p_ = context.Operators.DateFrom(o_);
					bool? q_ = context.Operators.Not((bool?)(((k_ ?? m_) ?? p_) is null));
					CqlQuantity r_ = FHIRHelpers_4_3_000.ToQuantity((R?.DispenseRequest?.ExpectedSupplyDuration as Quantity));
					CqlQuantity s_ = context.Operators.ConvertQuantity(r_, "d");
					CqlQuantity t_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity);
					Dosage.DoseAndRateComponent v_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((h_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object w_ = FHIRHelpers_4_3_000.ToValue(v_?.Dose);
					CqlQuantity x_ = context.Operators.End((w_ as CqlInterval<CqlQuantity>));
					Dosage.DoseAndRateComponent z_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((h_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Dose);
					Code<Timing.UnitsOfTime> af_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(h_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					string ag_ = context.Operators.Convert<string>(af_);
					CqlQuantity ah_ = this.Quantity(h_?.Timing?.Repeat?.PeriodElement?.Value, ag_);
					decimal? ai_ = this.ToDaily((h_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? h_?.Timing?.Repeat?.FrequencyElement?.Value), ah_);
					IEnumerable<CqlTime> ak_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(h_?.Timing?.Repeat?.TimeOfDayElement, "value");
					int? al_ = context.Operators.Count<CqlTime>(ak_);
					decimal? am_ = context.Operators.ConvertIntegerToDecimal(al_);
					decimal? an_ = context.Operators.Multiply((x_ ?? (aa_ as CqlQuantity))?.value, ((ai_ ?? am_) ?? 1.0m));
					decimal? ao_ = context.Operators.Divide(t_?.value, an_);
					int? ap_ = context.Operators.Add(1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? 0));
					decimal? aq_ = context.Operators.ConvertIntegerToDecimal(ap_);
					decimal? ar_ = context.Operators.Multiply((s_?.value ?? ao_), aq_);
					bool? as_ = context.Operators.Not((bool?)(ar_ is null));
					bool? at_ = context.Operators.And(q_, as_);

					return (at_ ?? false);
				};
				bool g_()
				{
					Dosage au_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					object av_ = FHIRHelpers_4_3_000.ToValue(au_?.Timing?.Repeat?.Bounds);
					CqlDateTime aw_ = context.Operators.Start((av_ as CqlInterval<CqlDateTime>));
					CqlDate ax_ = context.Operators.DateFrom(aw_);
					CqlDateTime ay_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					CqlDate az_ = context.Operators.DateFrom(ay_);
					CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					CqlDateTime bb_ = context.Operators.Start(ba_);
					CqlDate bc_ = context.Operators.DateFrom(bb_);
					bool? bd_ = context.Operators.Not((bool?)(((ax_ ?? az_) ?? bc_) is null));
					object bf_ = FHIRHelpers_4_3_000.ToValue(au_?.Timing?.Repeat?.Bounds);
					bool? bg_ = context.Operators.Not((bool?)((bf_ as CqlInterval<CqlDateTime>)?.high is null));
					bool? bh_ = context.Operators.And(bd_, bg_);

					return (bh_ ?? false);
				};
				if (f_())
				{
					Dosage bi_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					object bj_ = FHIRHelpers_4_3_000.ToValue(bi_?.Timing?.Repeat?.Bounds);
					CqlDateTime bk_ = context.Operators.Start((bj_ as CqlInterval<CqlDateTime>));
					CqlDate bl_ = context.Operators.DateFrom(bk_);
					CqlDateTime bm_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					CqlDate bn_ = context.Operators.DateFrom(bm_);
					CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					CqlDateTime bp_ = context.Operators.Start(bo_);
					CqlDate bq_ = context.Operators.DateFrom(bp_);
					object bs_ = FHIRHelpers_4_3_000.ToValue(bi_?.Timing?.Repeat?.Bounds);
					CqlDateTime bt_ = context.Operators.Start((bs_ as CqlInterval<CqlDateTime>));
					CqlDate bu_ = context.Operators.DateFrom(bt_);
					CqlDate bw_ = context.Operators.DateFrom(bm_);
					CqlDateTime by_ = context.Operators.Start(bo_);
					CqlDate bz_ = context.Operators.DateFrom(by_);
					CqlQuantity ca_ = FHIRHelpers_4_3_000.ToQuantity((R?.DispenseRequest?.ExpectedSupplyDuration as Quantity));
					CqlQuantity cb_ = context.Operators.ConvertQuantity(ca_, "d");
					CqlQuantity cc_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity);
					Dosage.DoseAndRateComponent ce_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((bi_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object cf_ = FHIRHelpers_4_3_000.ToValue(ce_?.Dose);
					CqlQuantity cg_ = context.Operators.End((cf_ as CqlInterval<CqlQuantity>));
					Dosage.DoseAndRateComponent ci_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((bi_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object cj_ = FHIRHelpers_4_3_000.ToValue(ci_?.Dose);
					Code<Timing.UnitsOfTime> co_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(bi_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					string cp_ = context.Operators.Convert<string>(co_);
					CqlQuantity cq_ = this.Quantity(bi_?.Timing?.Repeat?.PeriodElement?.Value, cp_);
					decimal? cr_ = this.ToDaily((bi_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? bi_?.Timing?.Repeat?.FrequencyElement?.Value), cq_);
					IEnumerable<CqlTime> ct_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bi_?.Timing?.Repeat?.TimeOfDayElement, "value");
					int? cu_ = context.Operators.Count<CqlTime>(ct_);
					decimal? cv_ = context.Operators.ConvertIntegerToDecimal(cu_);
					decimal? cw_ = context.Operators.Multiply((cg_ ?? (cj_ as CqlQuantity))?.value, ((cr_ ?? cv_) ?? 1.0m));
					decimal? cx_ = context.Operators.Divide(cc_?.value, cw_);
					int? cy_ = context.Operators.Add(1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? 0));
					decimal? cz_ = context.Operators.ConvertIntegerToDecimal(cy_);
					decimal? da_ = context.Operators.Multiply((cb_?.value ?? cx_), cz_);
					decimal? db_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? dc_ = context.Operators.Subtract(da_, db_);
					CqlQuantity dd_ = this.Quantity(dc_, "day");
					CqlDate de_ = context.Operators.Add(((bu_ ?? bw_) ?? bz_), dd_);
					CqlInterval<CqlDate> df_ = context.Operators.Interval(((bl_ ?? bn_) ?? bq_), de_, true, true);

					return df_;
				}
				else if (g_())
				{
					Dosage dg_ = context.Operators.SingletonFrom<Dosage>((R?.DosageInstruction as IEnumerable<Dosage>));
					object dh_ = FHIRHelpers_4_3_000.ToValue(dg_?.Timing?.Repeat?.Bounds);
					CqlDateTime di_ = context.Operators.Start((dh_ as CqlInterval<CqlDateTime>));
					CqlDate dj_ = context.Operators.DateFrom(di_);
					CqlDateTime dk_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					CqlDate dl_ = context.Operators.DateFrom(dk_);
					CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					CqlDateTime dn_ = context.Operators.Start(dm_);
					CqlDate do_ = context.Operators.DateFrom(dn_);
					object dq_ = FHIRHelpers_4_3_000.ToValue(dg_?.Timing?.Repeat?.Bounds);
					CqlDateTime dr_ = context.Operators.End((dq_ as CqlInterval<CqlDateTime>));
					CqlDate ds_ = context.Operators.DateFrom(dr_);
					CqlInterval<CqlDate> dt_ = context.Operators.Interval(((dj_ ?? dl_) ?? do_), ds_, true, true);

					return dt_;
				}
				else
				{
					CqlInterval<CqlDate> du_ = null;

					return du_;
				};
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>(a_, b_);
		CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationDispensePeriod")]
	public CqlInterval<CqlDate> MedicationDispensePeriod(MedicationDispense Dispense)
	{
		MedicationDispense[] a_ = new MedicationDispense[]
		{
			Dispense,
		};
		CqlInterval<CqlDate> b_(MedicationDispense D)
		{
			CqlInterval<CqlDate> e_()
			{
				bool f_()
				{
					CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(D?.WhenHandedOverElement);
					CqlDate h_ = context.Operators.DateFrom(g_);
					CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(D?.WhenPreparedElement);
					CqlDate j_ = context.Operators.DateFrom(i_);
					bool? k_ = context.Operators.Not((bool?)((h_ ?? j_) is null));
					CqlQuantity l_ = FHIRHelpers_4_3_000.ToQuantity(D?.DaysSupply);
					CqlQuantity m_ = context.Operators.ConvertQuantity(l_, "d");
					CqlQuantity n_ = FHIRHelpers_4_3_000.ToQuantity(D?.Quantity);
					Dosage o_ = context.Operators.SingletonFrom<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>));
					Dosage.DoseAndRateComponent p_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((o_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object q_ = FHIRHelpers_4_3_000.ToValue(p_?.Dose);
					CqlQuantity r_ = context.Operators.End((q_ as CqlInterval<CqlQuantity>));
					Dosage.DoseAndRateComponent t_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((o_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object u_ = FHIRHelpers_4_3_000.ToValue(t_?.Dose);
					Code<Timing.UnitsOfTime> z_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(o_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					string aa_ = context.Operators.Convert<string>(z_);
					CqlQuantity ab_ = this.Quantity(o_?.Timing?.Repeat?.PeriodElement?.Value, aa_);
					decimal? ac_ = this.ToDaily((o_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? o_?.Timing?.Repeat?.FrequencyElement?.Value), ab_);
					IEnumerable<CqlTime> ae_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(o_?.Timing?.Repeat?.TimeOfDayElement, "value");
					int? af_ = context.Operators.Count<CqlTime>(ae_);
					decimal? ag_ = context.Operators.ConvertIntegerToDecimal(af_);
					decimal? ah_ = context.Operators.Multiply((r_ ?? (u_ as CqlQuantity))?.value, ((ac_ ?? ag_) ?? 1.0m));
					decimal? ai_ = context.Operators.Divide(n_?.value, ah_);
					bool? aj_ = context.Operators.Not((bool?)((m_?.value ?? ai_) is null));
					bool? ak_ = context.Operators.And(k_, aj_);

					return (ak_ ?? false);
				};
				if (f_())
				{
					CqlDateTime al_ = context.Operators.Convert<CqlDateTime>(D?.WhenHandedOverElement);
					CqlDate am_ = context.Operators.DateFrom(al_);
					CqlDateTime an_ = context.Operators.Convert<CqlDateTime>(D?.WhenPreparedElement);
					CqlDate ao_ = context.Operators.DateFrom(an_);
					CqlDate aq_ = context.Operators.DateFrom(al_);
					CqlDate as_ = context.Operators.DateFrom(an_);
					CqlQuantity at_ = FHIRHelpers_4_3_000.ToQuantity(D?.DaysSupply);
					CqlQuantity au_ = context.Operators.ConvertQuantity(at_, "d");
					CqlQuantity av_ = FHIRHelpers_4_3_000.ToQuantity(D?.Quantity);
					Dosage aw_ = context.Operators.SingletonFrom<Dosage>((D?.DosageInstruction as IEnumerable<Dosage>));
					Dosage.DoseAndRateComponent ax_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((aw_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object ay_ = FHIRHelpers_4_3_000.ToValue(ax_?.Dose);
					CqlQuantity az_ = context.Operators.End((ay_ as CqlInterval<CqlQuantity>));
					Dosage.DoseAndRateComponent bb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((aw_?.DoseAndRate as IEnumerable<Dosage.DoseAndRateComponent>));
					object bc_ = FHIRHelpers_4_3_000.ToValue(bb_?.Dose);
					Code<Timing.UnitsOfTime> bh_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(aw_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					string bi_ = context.Operators.Convert<string>(bh_);
					CqlQuantity bj_ = this.Quantity(aw_?.Timing?.Repeat?.PeriodElement?.Value, bi_);
					decimal? bk_ = this.ToDaily((aw_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? aw_?.Timing?.Repeat?.FrequencyElement?.Value), bj_);
					IEnumerable<CqlTime> bm_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(aw_?.Timing?.Repeat?.TimeOfDayElement, "value");
					int? bn_ = context.Operators.Count<CqlTime>(bm_);
					decimal? bo_ = context.Operators.ConvertIntegerToDecimal(bn_);
					decimal? bp_ = context.Operators.Multiply((az_ ?? (bc_ as CqlQuantity))?.value, ((bk_ ?? bo_) ?? 1.0m));
					decimal? bq_ = context.Operators.Divide(av_?.value, bp_);
					decimal? br_ = context.Operators.ConvertIntegerToDecimal(1);
					decimal? bs_ = context.Operators.Subtract((au_?.value ?? bq_), br_);
					CqlQuantity bt_ = this.Quantity(bs_, "day");
					CqlDate bu_ = context.Operators.Add((aq_ ?? as_), bt_);
					CqlInterval<CqlDate> bv_ = context.Operators.Interval((am_ ?? ao_), bu_, true, true);

					return bv_;
				}
				else
				{
					CqlInterval<CqlDate> bw_ = null;

					return bw_;
				};
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(a_, b_);
		CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);

		return d_;
	}

    [CqlDeclaration("TherapeuticDuration")]
	public CqlQuantity TherapeuticDuration(CqlConcept medication)
	{
		CqlQuantity a_ = context.Operators.Quantity(14m, "days");

		return a_;
	}

    [CqlDeclaration("MedicationAdministrationPeriod")]
	public CqlInterval<CqlDate> MedicationAdministrationPeriod(MedicationAdministration Administration)
	{
		MedicationAdministration[] a_ = new MedicationAdministration[]
		{
			Administration,
		};
		CqlInterval<CqlDate> b_(MedicationAdministration M)
		{
			CqlInterval<CqlDate> e_()
			{
				bool f_()
				{
					object g_ = FHIRHelpers_4_3_000.ToValue(Administration?.Effective);
					CqlDateTime h_ = context.Operators.Start((g_ as CqlInterval<CqlDateTime>));
					CqlDate i_ = context.Operators.DateFrom(h_);
					bool? j_ = context.Operators.Not((bool?)(i_ is null));
					object k_ = FHIRHelpers_4_3_000.ToValue(Administration?.Medication);
					CqlQuantity l_ = this.TherapeuticDuration((k_ as CqlConcept));
					bool? m_ = context.Operators.Not((bool?)(l_ is null));
					bool? n_ = context.Operators.And(j_, m_);

					return (n_ ?? false);
				};
				if (f_())
				{
					object o_ = FHIRHelpers_4_3_000.ToValue(Administration?.Effective);
					CqlDateTime p_ = context.Operators.Start((o_ as CqlInterval<CqlDateTime>));
					CqlDate q_ = context.Operators.DateFrom(p_);
					CqlDateTime s_ = context.Operators.Start((o_ as CqlInterval<CqlDateTime>));
					CqlDate t_ = context.Operators.DateFrom(s_);
					object u_ = FHIRHelpers_4_3_000.ToValue(Administration?.Medication);
					CqlQuantity v_ = this.TherapeuticDuration((u_ as CqlConcept));
					CqlDate w_ = context.Operators.Add(t_, v_);
					CqlQuantity x_ = context.Operators.ConvertIntegerToQuantity(1);
					CqlDate y_ = context.Operators.Subtract(w_, x_);
					CqlInterval<CqlDate> z_ = context.Operators.Interval(q_, y_, true, true);

					return z_;
				}
				else
				{
					CqlInterval<CqlDate> aa_ = null;

					return aa_;
				};
			};

			return e_();
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>(a_, b_);
		CqlInterval<CqlDate> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);

		return d_;
	}

    [CqlDeclaration("CumulativeDuration")]
	public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		int? a_()
		{
			if ((context.Operators.Not((bool?)(Intervals is null)) ?? false))
			{
				IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Collapse(Intervals, "day");
				int? c_(CqlInterval<CqlDate> X)
				{
					CqlDate f_ = context.Operators.Start(X);
					CqlDate g_ = context.Operators.End(X);
					int? h_ = context.Operators.DifferenceBetween(f_, g_, "day");
					int? i_ = context.Operators.Add(h_, 1);

					return i_;
				};
				IEnumerable<int?> d_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(b_, c_);
				int? e_ = context.Operators.Sum(d_);

				return e_;
			}
			else
			{
				return default;
			};
		};

		return a_();
	}

    [CqlDeclaration("RolloutIntervals")]
	public IEnumerable<CqlInterval<CqlDate>> RolloutIntervals(IEnumerable<CqlInterval<CqlDate>> intervals)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = null;
		IEnumerable<CqlInterval<CqlDate>> b_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
		{
			CqlInterval<CqlDate>[] d_ = new CqlInterval<CqlDate>[]
			{
				I,
			};
			CqlInterval<CqlDate> e_(CqlInterval<CqlDate> X)
			{
				CqlInterval<CqlDate> j_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
				CqlDate k_ = context.Operators.End(j_);
				CqlQuantity l_ = context.Operators.Quantity(1m, "day");
				CqlDate m_ = context.Operators.Add(k_, l_);
				CqlDate n_ = context.Operators.Start(X);
				CqlDate[] o_ = new CqlDate[]
				{
					m_,
					n_,
				};
				CqlDate p_ = context.Operators.Max<CqlDate>((o_ as IEnumerable<CqlDate>));
				CqlDate r_ = context.Operators.End(j_);
				CqlDate t_ = context.Operators.Add(r_, l_);
				CqlDate[] v_ = new CqlDate[]
				{
					t_,
					n_,
				};
				CqlDate w_ = context.Operators.Max<CqlDate>((v_ as IEnumerable<CqlDate>));
				CqlDate y_ = context.Operators.End(X);
				int? z_ = context.Operators.DurationBetween(n_, y_, "day");
				decimal? aa_ = context.Operators.ConvertIntegerToDecimal((z_ ?? 0));
				CqlQuantity ab_ = this.Quantity(aa_, "day");
				CqlDate ac_ = context.Operators.Add(w_, ab_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(p_, ac_, true, true);

				return ad_;
			};
			IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(d_, e_);
			CqlInterval<CqlDate> g_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(f_);
			CqlInterval<CqlDate>[] h_ = new CqlInterval<CqlDate>[]
			{
				g_,
			};
			IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(R, (h_ as IEnumerable<CqlInterval<CqlDate>>));

			return i_;
		};
		IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, b_);

		return c_;
	}

    [CqlDeclaration("MedicationPeriod")]
	public CqlInterval<CqlDate> MedicationPeriod(object medication)
	{
		CqlInterval<CqlDate> a_()
		{
			if (medication is MedicationRequest)
			{
				CqlInterval<CqlDate> b_ = this.MedicationRequestPeriod((medication as MedicationRequest));

				return b_;
			}
			else if (medication is MedicationDispense)
			{
				CqlInterval<CqlDate> c_ = this.MedicationDispensePeriod((medication as MedicationDispense));

				return c_;
			}
			else
			{
				CqlInterval<CqlDate> d_ = null;

				return d_;
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
		CqlInterval<CqlDate> c_(object M)
		{
			CqlInterval<CqlDate> m_ = this.MedicationRequestPeriod((M as MedicationRequest));

			return m_;
		};
		IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Select<object, CqlInterval<CqlDate>>(b_, c_);
		bool? e_(object M)
		{
			bool n_ = M is MedicationDispense;

			return (n_ as bool?);
		};
		IEnumerable<object> f_ = context.Operators.Where<object>(Medications, e_);
		CqlInterval<CqlDate> g_(object M)
		{
			CqlInterval<CqlDate> o_ = this.MedicationDispensePeriod((M as MedicationDispense));

			return o_;
		};
		IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Select<object, CqlInterval<CqlDate>>(f_, g_);
		IEnumerable<CqlInterval<CqlDate>> i_ = this.RolloutIntervals(h_);
		IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(d_, i_);
		int? k_ = this.CumulativeDuration(j_);

		return k_;
	}

}
