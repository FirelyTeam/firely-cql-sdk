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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = context.ResolveParameter("CumulativeMedicationDuration-4.0.000", "ErrorLevel", "Warning");

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
				var c_ = context.Operators.Divide(24.0m, period?.value);
				var d_ = context.Operators.Multiply(b_, c_);

				return d_;
			}
			else if ((context.Operators.Equal(period?.unit, "min") ?? false))
			{
				var e_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var f_ = context.Operators.Divide(24.0m, period?.value);
				var g_ = context.Operators.Multiply(e_, f_);
				var h_ = context.Operators.ConvertIntegerToDecimal(60);
				var i_ = context.Operators.Multiply(g_, h_);

				return i_;
			}
			else if ((context.Operators.Equal(period?.unit, "s") ?? false))
			{
				var j_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var k_ = context.Operators.Divide(24.0m, period?.value);
				var l_ = context.Operators.Multiply(j_, k_);
				var m_ = context.Operators.ConvertIntegerToDecimal(60);
				var n_ = context.Operators.Multiply(l_, m_);
				var p_ = context.Operators.Multiply(n_, m_);

				return p_;
			}
			else if ((context.Operators.Equal(period?.unit, "d") ?? false))
			{
				var q_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var r_ = context.Operators.Divide(24.0m, period?.value);
				var s_ = context.Operators.Multiply(q_, r_);
				var t_ = context.Operators.ConvertIntegerToDecimal(24);
				var u_ = context.Operators.Divide(s_, t_);

				return u_;
			}
			else if ((context.Operators.Equal(period?.unit, "wk") ?? false))
			{
				var v_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var w_ = context.Operators.Divide(24.0m, period?.value);
				var x_ = context.Operators.Multiply(v_, w_);
				var y_ = context.Operators.Multiply(24, 7);
				var z_ = context.Operators.ConvertIntegerToDecimal(y_);
				var aa_ = context.Operators.Divide(x_, z_);

				return aa_;
			}
			else if ((context.Operators.Equal(period?.unit, "mo") ?? false))
			{
				var ab_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ac_ = context.Operators.Divide(24.0m, period?.value);
				var ad_ = context.Operators.Multiply(ab_, ac_);
				var ae_ = context.Operators.Multiply(24, 30);
				var af_ = context.Operators.ConvertIntegerToDecimal(ae_);
				var ag_ = context.Operators.Divide(ad_, af_);

				return ag_;
			}
			else if ((context.Operators.Equal(period?.unit, "a") ?? false))
			{
				var ah_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ai_ = context.Operators.Divide(24.0m, period?.value);
				var aj_ = context.Operators.Multiply(ah_, ai_);
				var ak_ = context.Operators.Multiply(24, 365);
				var al_ = context.Operators.ConvertIntegerToDecimal(ak_);
				var am_ = context.Operators.Divide(aj_, al_);

				return am_;
			}
			else if ((context.Operators.Equal(period?.unit, "hour") ?? false))
			{
				var an_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ao_ = context.Operators.Divide(24.0m, period?.value);
				var ap_ = context.Operators.Multiply(an_, ao_);

				return ap_;
			}
			else if ((context.Operators.Equal(period?.unit, "minute") ?? false))
			{
				var aq_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ar_ = context.Operators.Divide(24.0m, period?.value);
				var as_ = context.Operators.Multiply(aq_, ar_);
				var at_ = context.Operators.ConvertIntegerToDecimal(60);
				var au_ = context.Operators.Multiply(as_, at_);

				return au_;
			}
			else if ((context.Operators.Equal(period?.unit, "second") ?? false))
			{
				var av_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var aw_ = context.Operators.Divide(24.0m, period?.value);
				var ax_ = context.Operators.Multiply(av_, aw_);
				var ay_ = context.Operators.ConvertIntegerToDecimal(60);
				var az_ = context.Operators.Multiply(ax_, ay_);
				var bb_ = context.Operators.Multiply(az_, ay_);

				return bb_;
			}
			else if ((context.Operators.Equal(period?.unit, "day") ?? false))
			{
				var bc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bd_ = context.Operators.Divide(24.0m, period?.value);
				var be_ = context.Operators.Multiply(bc_, bd_);
				var bf_ = context.Operators.ConvertIntegerToDecimal(24);
				var bg_ = context.Operators.Divide(be_, bf_);

				return bg_;
			}
			else if ((context.Operators.Equal(period?.unit, "week") ?? false))
			{
				var bh_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bi_ = context.Operators.Divide(24.0m, period?.value);
				var bj_ = context.Operators.Multiply(bh_, bi_);
				var bk_ = context.Operators.Multiply(24, 7);
				var bl_ = context.Operators.ConvertIntegerToDecimal(bk_);
				var bm_ = context.Operators.Divide(bj_, bl_);

				return bm_;
			}
			else if ((context.Operators.Equal(period?.unit, "month") ?? false))
			{
				var bn_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bo_ = context.Operators.Divide(24.0m, period?.value);
				var bp_ = context.Operators.Multiply(bn_, bo_);
				var bq_ = context.Operators.Multiply(24, 30);
				var br_ = context.Operators.ConvertIntegerToDecimal(bq_);
				var bs_ = context.Operators.Divide(bp_, br_);

				return bs_;
			}
			else if ((context.Operators.Equal(period?.unit, "year") ?? false))
			{
				var bt_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var bu_ = context.Operators.Divide(24.0m, period?.value);
				var bv_ = context.Operators.Multiply(bt_, bu_);
				var bw_ = context.Operators.Multiply(24, 365);
				var bx_ = context.Operators.ConvertIntegerToDecimal(bw_);
				var by_ = context.Operators.Divide(bv_, bx_);

				return by_;
			}
			else if ((context.Operators.Equal(period?.unit, "hours") ?? false))
			{
				var bz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ca_ = context.Operators.Divide(24.0m, period?.value);
				var cb_ = context.Operators.Multiply(bz_, ca_);

				return cb_;
			}
			else if ((context.Operators.Equal(period?.unit, "minutes") ?? false))
			{
				var cc_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cd_ = context.Operators.Divide(24.0m, period?.value);
				var ce_ = context.Operators.Multiply(cc_, cd_);
				var cf_ = context.Operators.ConvertIntegerToDecimal(60);
				var cg_ = context.Operators.Multiply(ce_, cf_);

				return cg_;
			}
			else if ((context.Operators.Equal(period?.unit, "seconds") ?? false))
			{
				var ch_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var ci_ = context.Operators.Divide(24.0m, period?.value);
				var cj_ = context.Operators.Multiply(ch_, ci_);
				var ck_ = context.Operators.ConvertIntegerToDecimal(60);
				var cl_ = context.Operators.Multiply(cj_, ck_);
				var cn_ = context.Operators.Multiply(cl_, ck_);

				return cn_;
			}
			else if ((context.Operators.Equal(period?.unit, "days") ?? false))
			{
				var co_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cp_ = context.Operators.Divide(24.0m, period?.value);
				var cq_ = context.Operators.Multiply(co_, cp_);
				var cr_ = context.Operators.ConvertIntegerToDecimal(24);
				var cs_ = context.Operators.Divide(cq_, cr_);

				return cs_;
			}
			else if ((context.Operators.Equal(period?.unit, "weeks") ?? false))
			{
				var ct_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var cu_ = context.Operators.Divide(24.0m, period?.value);
				var cv_ = context.Operators.Multiply(ct_, cu_);
				var cw_ = context.Operators.Multiply(24, 7);
				var cx_ = context.Operators.ConvertIntegerToDecimal(cw_);
				var cy_ = context.Operators.Divide(cv_, cx_);

				return cy_;
			}
			else if ((context.Operators.Equal(period?.unit, "months") ?? false))
			{
				var cz_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var da_ = context.Operators.Divide(24.0m, period?.value);
				var db_ = context.Operators.Multiply(cz_, da_);
				var dc_ = context.Operators.Multiply(24, 30);
				var dd_ = context.Operators.ConvertIntegerToDecimal(dc_);
				var de_ = context.Operators.Divide(db_, dd_);

				return de_;
			}
			else if ((context.Operators.Equal(period?.unit, "years") ?? false))
			{
				var df_ = context.Operators.ConvertIntegerToDecimal(frequency);
				var dg_ = context.Operators.Divide(24.0m, period?.value);
				var dh_ = context.Operators.Multiply(df_, dg_);
				var di_ = context.Operators.Multiply(24, 365);
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
				var aw_ = this.HS();
				var ax_ = context.Operators.Equivalent(frequency, aw_);

				return (ax_ ?? false);
			};
			bool c_()
			{
				var ay_ = this.WAKE();
				var az_ = context.Operators.Equivalent(frequency, ay_);

				return (az_ ?? false);
			};
			bool d_()
			{
				var ba_ = this.C();
				var bb_ = context.Operators.Equivalent(frequency, ba_);

				return (bb_ ?? false);
			};
			bool e_()
			{
				var bc_ = this.CM();
				var bd_ = context.Operators.Equivalent(frequency, bc_);

				return (bd_ ?? false);
			};
			bool f_()
			{
				var be_ = this.CD();
				var bf_ = context.Operators.Equivalent(frequency, be_);

				return (bf_ ?? false);
			};
			bool g_()
			{
				var bg_ = this.CV();
				var bh_ = context.Operators.Equivalent(frequency, bg_);

				return (bh_ ?? false);
			};
			bool h_()
			{
				var bi_ = this.AC();
				var bj_ = context.Operators.Equivalent(frequency, bi_);

				return (bj_ ?? false);
			};
			bool i_()
			{
				var bk_ = this.ACM();
				var bl_ = context.Operators.Equivalent(frequency, bk_);

				return (bl_ ?? false);
			};
			bool j_()
			{
				var bm_ = this.ACD();
				var bn_ = context.Operators.Equivalent(frequency, bm_);

				return (bn_ ?? false);
			};
			bool k_()
			{
				var bo_ = this.ACV();
				var bp_ = context.Operators.Equivalent(frequency, bo_);

				return (bp_ ?? false);
			};
			bool l_()
			{
				var bq_ = this.PC();
				var br_ = context.Operators.Equivalent(frequency, bq_);

				return (br_ ?? false);
			};
			bool m_()
			{
				var bs_ = this.PCM();
				var bt_ = context.Operators.Equivalent(frequency, bs_);

				return (bt_ ?? false);
			};
			bool n_()
			{
				var bu_ = this.PCD();
				var bv_ = context.Operators.Equivalent(frequency, bu_);

				return (bv_ ?? false);
			};
			bool o_()
			{
				var bw_ = this.PCV();
				var bx_ = context.Operators.Equivalent(frequency, bw_);

				return (bx_ ?? false);
			};
			bool p_()
			{
				var by_ = this.MORN();
				var bz_ = context.Operators.Equivalent(frequency, by_);

				return (bz_ ?? false);
			};
			bool q_()
			{
				var ca_ = this.MORN_early();
				var cb_ = context.Operators.Equivalent(frequency, ca_);

				return (cb_ ?? false);
			};
			bool r_()
			{
				var cc_ = this.MORN_late();
				var cd_ = context.Operators.Equivalent(frequency, cc_);

				return (cd_ ?? false);
			};
			bool s_()
			{
				var ce_ = this.NOON();
				var cf_ = context.Operators.Equivalent(frequency, ce_);

				return (cf_ ?? false);
			};
			bool t_()
			{
				var cg_ = this.AFT();
				var ch_ = context.Operators.Equivalent(frequency, cg_);

				return (ch_ ?? false);
			};
			bool u_()
			{
				var ci_ = this.AFT_early();
				var cj_ = context.Operators.Equivalent(frequency, ci_);

				return (cj_ ?? false);
			};
			bool v_()
			{
				var ck_ = this.AFT_late();
				var cl_ = context.Operators.Equivalent(frequency, ck_);

				return (cl_ ?? false);
			};
			bool w_()
			{
				var cm_ = this.EVE();
				var cn_ = context.Operators.Equivalent(frequency, cm_);

				return (cn_ ?? false);
			};
			bool x_()
			{
				var co_ = this.EVE_early();
				var cp_ = context.Operators.Equivalent(frequency, co_);

				return (cp_ ?? false);
			};
			bool y_()
			{
				var cq_ = this.EVE_late();
				var cr_ = context.Operators.Equivalent(frequency, cq_);

				return (cr_ ?? false);
			};
			bool z_()
			{
				var cs_ = this.NIGHT();
				var ct_ = context.Operators.Equivalent(frequency, cs_);

				return (ct_ ?? false);
			};
			bool aa_()
			{
				var cu_ = this.PHS();
				var cv_ = context.Operators.Equivalent(frequency, cu_);

				return (cv_ ?? false);
			};
			bool ab_()
			{
				var cw_ = this.Once_daily__qualifier_value_();
				var cx_ = context.Operators.Equivalent(frequency, cw_);

				return (cx_ ?? false);
			};
			bool ac_()
			{
				var cy_ = this.Twice_a_day__qualifier_value_();
				var cz_ = context.Operators.Equivalent(frequency, cy_);

				return (cz_ ?? false);
			};
			bool ad_()
			{
				var da_ = this.Three_times_daily__qualifier_value_();
				var db_ = context.Operators.Equivalent(frequency, da_);

				return (db_ ?? false);
			};
			bool ae_()
			{
				var dc_ = this.Four_times_daily__qualifier_value_();
				var dd_ = context.Operators.Equivalent(frequency, dc_);

				return (dd_ ?? false);
			};
			bool af_()
			{
				var de_ = this.Every_twenty_four_hours__qualifier_value_();
				var df_ = context.Operators.Equivalent(frequency, de_);

				return (df_ ?? false);
			};
			bool ag_()
			{
				var dg_ = this.Every_twelve_hours__qualifier_value_();
				var dh_ = context.Operators.Equivalent(frequency, dg_);

				return (dh_ ?? false);
			};
			bool ah_()
			{
				var di_ = this.Every_thirty_six_hours__qualifier_value_();
				var dj_ = context.Operators.Equivalent(frequency, di_);

				return (dj_ ?? false);
			};
			bool ai_()
			{
				var dk_ = this.Every_eight_hours__qualifier_value_();
				var dl_ = context.Operators.Equivalent(frequency, dk_);

				return (dl_ ?? false);
			};
			bool aj_()
			{
				var dm_ = this.Every_four_hours__qualifier_value_();
				var dn_ = context.Operators.Equivalent(frequency, dm_);

				return (dn_ ?? false);
			};
			bool ak_()
			{
				var do_ = this.Every_six_hours__qualifier_value_();
				var dp_ = context.Operators.Equivalent(frequency, do_);

				return (dp_ ?? false);
			};
			bool al_()
			{
				var dq_ = this.Every_seventy_two_hours__qualifier_value_();
				var dr_ = context.Operators.Equivalent(frequency, dq_);

				return (dr_ ?? false);
			};
			bool am_()
			{
				var ds_ = this.Every_forty_eight_hours__qualifier_value_();
				var dt_ = context.Operators.Equivalent(frequency, ds_);

				return (dt_ ?? false);
			};
			bool an_()
			{
				var du_ = this.Every_eight_to_twelve_hours__qualifier_value_();
				var dv_ = context.Operators.Equivalent(frequency, du_);

				return (dv_ ?? false);
			};
			bool ao_()
			{
				var dw_ = this.Every_six_to_eight_hours__qualifier_value_();
				var dx_ = context.Operators.Equivalent(frequency, dw_);

				return (dx_ ?? false);
			};
			bool ap_()
			{
				var dy_ = this.Every_three_to_four_hours__qualifier_value_();
				var dz_ = context.Operators.Equivalent(frequency, dy_);

				return (dz_ ?? false);
			};
			bool aq_()
			{
				var ea_ = this.Every_three_to_six_hours__qualifier_value_();
				var eb_ = context.Operators.Equivalent(frequency, ea_);

				return (eb_ ?? false);
			};
			bool ar_()
			{
				var ec_ = this.Every_two_to_four_hours__qualifier_value_();
				var ed_ = context.Operators.Equivalent(frequency, ec_);

				return (ed_ ?? false);
			};
			bool as_()
			{
				var ee_ = this.One_to_four_times_a_day__qualifier_value_();
				var ef_ = context.Operators.Equivalent(frequency, ee_);

				return (ef_ ?? false);
			};
			bool at_()
			{
				var eg_ = this.One_to_three_times_a_day__qualifier_value_();
				var eh_ = context.Operators.Equivalent(frequency, eg_);

				return (eh_ ?? false);
			};
			bool au_()
			{
				var ei_ = this.One_to_two_times_a_day__qualifier_value_();
				var ej_ = context.Operators.Equivalent(frequency, ei_);

				return (ej_ ?? false);
			};
			bool av_()
			{
				var ek_ = this.Two_to_four_times_a_day__qualifier_value_();
				var el_ = context.Operators.Equivalent(frequency, ek_);

				return (el_ ?? false);
			};
			if (b_())
			{
				var em_ = context.Operators.ConvertIntegerToDecimal(1);

				return em_;
			}
			else if (c_())
			{
				var en_ = context.Operators.ConvertIntegerToDecimal(1);

				return en_;
			}
			else if (d_())
			{
				var eo_ = context.Operators.ConvertIntegerToDecimal(3);

				return eo_;
			}
			else if (e_())
			{
				var ep_ = context.Operators.ConvertIntegerToDecimal(1);

				return ep_;
			}
			else if (f_())
			{
				var eq_ = context.Operators.ConvertIntegerToDecimal(1);

				return eq_;
			}
			else if (g_())
			{
				var er_ = context.Operators.ConvertIntegerToDecimal(1);

				return er_;
			}
			else if (h_())
			{
				var es_ = context.Operators.ConvertIntegerToDecimal(3);

				return es_;
			}
			else if (i_())
			{
				var et_ = context.Operators.ConvertIntegerToDecimal(1);

				return et_;
			}
			else if (j_())
			{
				var eu_ = context.Operators.ConvertIntegerToDecimal(1);

				return eu_;
			}
			else if (k_())
			{
				var ev_ = context.Operators.ConvertIntegerToDecimal(1);

				return ev_;
			}
			else if (l_())
			{
				var ew_ = context.Operators.ConvertIntegerToDecimal(3);

				return ew_;
			}
			else if (m_())
			{
				var ex_ = context.Operators.ConvertIntegerToDecimal(1);

				return ex_;
			}
			else if (n_())
			{
				var ey_ = context.Operators.ConvertIntegerToDecimal(1);

				return ey_;
			}
			else if (o_())
			{
				var ez_ = context.Operators.ConvertIntegerToDecimal(1);

				return ez_;
			}
			else if (p_())
			{
				var fa_ = context.Operators.ConvertIntegerToDecimal(1);

				return fa_;
			}
			else if (q_())
			{
				var fb_ = context.Operators.ConvertIntegerToDecimal(1);

				return fb_;
			}
			else if (r_())
			{
				var fc_ = context.Operators.ConvertIntegerToDecimal(1);

				return fc_;
			}
			else if (s_())
			{
				var fd_ = context.Operators.ConvertIntegerToDecimal(1);

				return fd_;
			}
			else if (t_())
			{
				var fe_ = context.Operators.ConvertIntegerToDecimal(1);

				return fe_;
			}
			else if (u_())
			{
				var ff_ = context.Operators.ConvertIntegerToDecimal(1);

				return ff_;
			}
			else if (v_())
			{
				var fg_ = context.Operators.ConvertIntegerToDecimal(1);

				return fg_;
			}
			else if (w_())
			{
				var fh_ = context.Operators.ConvertIntegerToDecimal(1);

				return fh_;
			}
			else if (x_())
			{
				var fi_ = context.Operators.ConvertIntegerToDecimal(1);

				return fi_;
			}
			else if (y_())
			{
				var fj_ = context.Operators.ConvertIntegerToDecimal(1);

				return fj_;
			}
			else if (z_())
			{
				var fk_ = context.Operators.ConvertIntegerToDecimal(1);

				return fk_;
			}
			else if (aa_())
			{
				var fl_ = context.Operators.ConvertIntegerToDecimal(1);

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
				var fm_ = this.ErrorLevel();
				var fn_ = context.Operators.Concatenate("Unknown frequency code ", (frequency?.code ?? ""));
				var fo_ = context.Operators.Message<object>(null, "CMDLogic.ToDaily.UnknownFrequencyCode", fm_, fn_);

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
		var a_ = new MedicationRequest[]
		{
			Request,
		};
		CqlInterval<CqlDate> b_(MedicationRequest R)
		{
			CqlInterval<CqlDate> e_()
			{
				bool f_()
				{
					var h_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)R?.DosageInstruction);
					var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Timing?.Repeat?.Bounds);
					var j_ = context.Operators.Start((i_ as CqlInterval<CqlDateTime>));
					var k_ = context.Operators.DateFrom(j_);
					var l_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					var m_ = context.Operators.DateFrom(l_);
					var n_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var o_ = context.Operators.Start(n_);
					var p_ = context.Operators.DateFrom(o_);
					var q_ = context.Operators.Not((bool?)(((k_ ?? m_) ?? p_) is null));
					var r_ = FHIRHelpers_4_3_000.ToQuantity((Quantity)R?.DispenseRequest?.ExpectedSupplyDuration);
					var s_ = context.Operators.ConvertQuantity(r_, "d");
					var t_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity);
					var v_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)h_?.DoseAndRate);
					var w_ = FHIRHelpers_4_3_000.ToValue(v_?.Dose);
					var x_ = context.Operators.End((w_ as CqlInterval<CqlQuantity>));
					var z_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)h_?.DoseAndRate);
					var aa_ = FHIRHelpers_4_3_000.ToValue(z_?.Dose);
					var af_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(h_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var ag_ = context.Operators.Convert<string>(af_);
					var ah_ = this.Quantity(h_?.Timing?.Repeat?.PeriodElement?.Value, ag_);
					var ai_ = this.ToDaily((h_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? h_?.Timing?.Repeat?.FrequencyElement?.Value), ah_);
					var ak_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(h_?.Timing?.Repeat?.TimeOfDayElement, "value");
					var al_ = context.Operators.Count<CqlTime>(ak_);
					var am_ = context.Operators.ConvertIntegerToDecimal(al_);
					var an_ = context.Operators.Multiply((x_ ?? (aa_ as CqlQuantity))?.value, ((ai_ ?? am_) ?? 1.0m));
					var ao_ = context.Operators.Divide(t_?.value, an_);
					var ap_ = context.Operators.Add(1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? 0));
					var aq_ = context.Operators.ConvertIntegerToDecimal(ap_);
					var ar_ = context.Operators.Multiply((s_?.value ?? ao_), aq_);
					var as_ = context.Operators.Not((bool?)(ar_ is null));
					var at_ = context.Operators.And(q_, as_);

					return (at_ ?? false);
				};
				bool g_()
				{
					var au_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)R?.DosageInstruction);
					var av_ = FHIRHelpers_4_3_000.ToValue(au_?.Timing?.Repeat?.Bounds);
					var aw_ = context.Operators.Start((av_ as CqlInterval<CqlDateTime>));
					var ax_ = context.Operators.DateFrom(aw_);
					var ay_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					var az_ = context.Operators.DateFrom(ay_);
					var ba_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var bb_ = context.Operators.Start(ba_);
					var bc_ = context.Operators.DateFrom(bb_);
					var bd_ = context.Operators.Not((bool?)(((ax_ ?? az_) ?? bc_) is null));
					var bf_ = FHIRHelpers_4_3_000.ToValue(au_?.Timing?.Repeat?.Bounds);
					var bg_ = context.Operators.Not((bool?)((bf_ as CqlInterval<CqlDateTime>)?.high is null));
					var bh_ = context.Operators.And(bd_, bg_);

					return (bh_ ?? false);
				};
				if (f_())
				{
					var bi_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)R?.DosageInstruction);
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_?.Timing?.Repeat?.Bounds);
					var bk_ = context.Operators.Start((bj_ as CqlInterval<CqlDateTime>));
					var bl_ = context.Operators.DateFrom(bk_);
					var bm_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					var bn_ = context.Operators.DateFrom(bm_);
					var bo_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var bp_ = context.Operators.Start(bo_);
					var bq_ = context.Operators.DateFrom(bp_);
					var bs_ = FHIRHelpers_4_3_000.ToValue(bi_?.Timing?.Repeat?.Bounds);
					var bt_ = context.Operators.Start((bs_ as CqlInterval<CqlDateTime>));
					var bu_ = context.Operators.DateFrom(bt_);
					var bw_ = context.Operators.DateFrom(bm_);
					var by_ = context.Operators.Start(bo_);
					var bz_ = context.Operators.DateFrom(by_);
					var ca_ = FHIRHelpers_4_3_000.ToQuantity((Quantity)R?.DispenseRequest?.ExpectedSupplyDuration);
					var cb_ = context.Operators.ConvertQuantity(ca_, "d");
					var cc_ = FHIRHelpers_4_3_000.ToQuantity(R?.DispenseRequest?.Quantity);
					var ce_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bi_?.DoseAndRate);
					var cf_ = FHIRHelpers_4_3_000.ToValue(ce_?.Dose);
					var cg_ = context.Operators.End((cf_ as CqlInterval<CqlQuantity>));
					var ci_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)bi_?.DoseAndRate);
					var cj_ = FHIRHelpers_4_3_000.ToValue(ci_?.Dose);
					var co_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(bi_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var cp_ = context.Operators.Convert<string>(co_);
					var cq_ = this.Quantity(bi_?.Timing?.Repeat?.PeriodElement?.Value, cp_);
					var cr_ = this.ToDaily((bi_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? bi_?.Timing?.Repeat?.FrequencyElement?.Value), cq_);
					var ct_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(bi_?.Timing?.Repeat?.TimeOfDayElement, "value");
					var cu_ = context.Operators.Count<CqlTime>(ct_);
					var cv_ = context.Operators.ConvertIntegerToDecimal(cu_);
					var cw_ = context.Operators.Multiply((cg_ ?? (cj_ as CqlQuantity))?.value, ((cr_ ?? cv_) ?? 1.0m));
					var cx_ = context.Operators.Divide(cc_?.value, cw_);
					var cy_ = context.Operators.Add(1, (R?.DispenseRequest?.NumberOfRepeatsAllowedElement?.Value ?? 0));
					var cz_ = context.Operators.ConvertIntegerToDecimal(cy_);
					var da_ = context.Operators.Multiply((cb_?.value ?? cx_), cz_);
					var db_ = context.Operators.ConvertIntegerToDecimal(1);
					var dc_ = context.Operators.Subtract(da_, db_);
					var dd_ = this.Quantity(dc_, "day");
					var de_ = context.Operators.Add(((bu_ ?? bw_) ?? bz_), dd_);
					var df_ = context.Operators.Interval(((bl_ ?? bn_) ?? bq_), de_, true, true);

					return df_;
				}
				else if (g_())
				{
					var dg_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)R?.DosageInstruction);
					var dh_ = FHIRHelpers_4_3_000.ToValue(dg_?.Timing?.Repeat?.Bounds);
					var di_ = context.Operators.Start((dh_ as CqlInterval<CqlDateTime>));
					var dj_ = context.Operators.DateFrom(di_);
					var dk_ = context.Operators.Convert<CqlDateTime>(R?.AuthoredOnElement);
					var dl_ = context.Operators.DateFrom(dk_);
					var dm_ = FHIRHelpers_4_3_000.ToInterval(R?.DispenseRequest?.ValidityPeriod);
					var dn_ = context.Operators.Start(dm_);
					var do_ = context.Operators.DateFrom(dn_);
					var dq_ = FHIRHelpers_4_3_000.ToValue(dg_?.Timing?.Repeat?.Bounds);
					var dr_ = context.Operators.End((dq_ as CqlInterval<CqlDateTime>));
					var ds_ = context.Operators.DateFrom(dr_);
					var dt_ = context.Operators.Interval(((dj_ ?? dl_) ?? do_), ds_, true, true);

					return dt_;
				}
				else
				{
					return null;
				};
			};

			return e_();
		};
		var c_ = context.Operators.Select<MedicationRequest, CqlInterval<CqlDate>>((IEnumerable<MedicationRequest>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);

		return d_;
	}

    [CqlDeclaration("MedicationDispensePeriod")]
	public CqlInterval<CqlDate> MedicationDispensePeriod(MedicationDispense Dispense)
	{
		var a_ = new MedicationDispense[]
		{
			Dispense,
		};
		CqlInterval<CqlDate> b_(MedicationDispense D)
		{
			CqlInterval<CqlDate> e_()
			{
				bool f_()
				{
					var g_ = context.Operators.Convert<CqlDateTime>(D?.WhenHandedOverElement);
					var h_ = context.Operators.DateFrom(g_);
					var i_ = context.Operators.Convert<CqlDateTime>(D?.WhenPreparedElement);
					var j_ = context.Operators.DateFrom(i_);
					var k_ = context.Operators.Not((bool?)((h_ ?? j_) is null));
					var l_ = FHIRHelpers_4_3_000.ToQuantity(D?.DaysSupply);
					var m_ = context.Operators.ConvertQuantity(l_, "d");
					var n_ = FHIRHelpers_4_3_000.ToQuantity(D?.Quantity);
					var o_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)D?.DosageInstruction);
					var p_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)o_?.DoseAndRate);
					var q_ = FHIRHelpers_4_3_000.ToValue(p_?.Dose);
					var r_ = context.Operators.End((q_ as CqlInterval<CqlQuantity>));
					var t_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)o_?.DoseAndRate);
					var u_ = FHIRHelpers_4_3_000.ToValue(t_?.Dose);
					var z_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(o_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var aa_ = context.Operators.Convert<string>(z_);
					var ab_ = this.Quantity(o_?.Timing?.Repeat?.PeriodElement?.Value, aa_);
					var ac_ = this.ToDaily((o_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? o_?.Timing?.Repeat?.FrequencyElement?.Value), ab_);
					var ae_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(o_?.Timing?.Repeat?.TimeOfDayElement, "value");
					var af_ = context.Operators.Count<CqlTime>(ae_);
					var ag_ = context.Operators.ConvertIntegerToDecimal(af_);
					var ah_ = context.Operators.Multiply((r_ ?? (u_ as CqlQuantity))?.value, ((ac_ ?? ag_) ?? 1.0m));
					var ai_ = context.Operators.Divide(n_?.value, ah_);
					var aj_ = context.Operators.Not((bool?)((m_?.value ?? ai_) is null));
					var ak_ = context.Operators.And(k_, aj_);

					return (ak_ ?? false);
				};
				if (f_())
				{
					var al_ = context.Operators.Convert<CqlDateTime>(D?.WhenHandedOverElement);
					var am_ = context.Operators.DateFrom(al_);
					var an_ = context.Operators.Convert<CqlDateTime>(D?.WhenPreparedElement);
					var ao_ = context.Operators.DateFrom(an_);
					var aq_ = context.Operators.DateFrom(al_);
					var as_ = context.Operators.DateFrom(an_);
					var at_ = FHIRHelpers_4_3_000.ToQuantity(D?.DaysSupply);
					var au_ = context.Operators.ConvertQuantity(at_, "d");
					var av_ = FHIRHelpers_4_3_000.ToQuantity(D?.Quantity);
					var aw_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)D?.DosageInstruction);
					var ax_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)aw_?.DoseAndRate);
					var ay_ = FHIRHelpers_4_3_000.ToValue(ax_?.Dose);
					var az_ = context.Operators.End((ay_ as CqlInterval<CqlQuantity>));
					var bb_ = context.Operators.SingletonFrom<Dosage.DoseAndRateComponent>((IEnumerable<Dosage.DoseAndRateComponent>)aw_?.DoseAndRate);
					var bc_ = FHIRHelpers_4_3_000.ToValue(bb_?.Dose);
					var bh_ = context.Operators.Convert<Code<Timing.UnitsOfTime>>(aw_?.Timing?.Repeat?.PeriodUnitElement?.Value);
					var bi_ = context.Operators.Convert<string>(bh_);
					var bj_ = this.Quantity(aw_?.Timing?.Repeat?.PeriodElement?.Value, bi_);
					var bk_ = this.ToDaily((aw_?.Timing?.Repeat?.FrequencyMaxElement?.Value ?? aw_?.Timing?.Repeat?.FrequencyElement?.Value), bj_);
					var bm_ = context.Operators.LateBoundProperty<IEnumerable<CqlTime>>(aw_?.Timing?.Repeat?.TimeOfDayElement, "value");
					var bn_ = context.Operators.Count<CqlTime>(bm_);
					var bo_ = context.Operators.ConvertIntegerToDecimal(bn_);
					var bp_ = context.Operators.Multiply((az_ ?? (bc_ as CqlQuantity))?.value, ((bk_ ?? bo_) ?? 1.0m));
					var bq_ = context.Operators.Divide(av_?.value, bp_);
					var br_ = context.Operators.ConvertIntegerToDecimal(1);
					var bs_ = context.Operators.Subtract((au_?.value ?? bq_), br_);
					var bt_ = this.Quantity(bs_, "day");
					var bu_ = context.Operators.Add((aq_ ?? as_), bt_);
					var bv_ = context.Operators.Interval((am_ ?? ao_), bu_, true, true);

					return bv_;
				}
				else
				{
					return null;
				};
			};

			return e_();
		};
		var c_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>((IEnumerable<MedicationDispense>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);

		return d_;
	}

    [CqlDeclaration("TherapeuticDuration")]
	public CqlQuantity TherapeuticDuration(CqlConcept medication)
	{
		var a_ = context.Operators.Quantity(14m, "days");

		return a_;
	}

    [CqlDeclaration("MedicationAdministrationPeriod")]
	public CqlInterval<CqlDate> MedicationAdministrationPeriod(MedicationAdministration Administration)
	{
		var a_ = new MedicationAdministration[]
		{
			Administration,
		};
		CqlInterval<CqlDate> b_(MedicationAdministration M)
		{
			CqlInterval<CqlDate> e_()
			{
				bool f_()
				{
					var g_ = FHIRHelpers_4_3_000.ToValue(Administration?.Effective);
					var h_ = context.Operators.Start((g_ as CqlInterval<CqlDateTime>));
					var i_ = context.Operators.DateFrom(h_);
					var j_ = context.Operators.Not((bool?)(i_ is null));
					var k_ = FHIRHelpers_4_3_000.ToValue(Administration?.Medication);
					var l_ = this.TherapeuticDuration((k_ as CqlConcept));
					var m_ = context.Operators.Not((bool?)(l_ is null));
					var n_ = context.Operators.And(j_, m_);

					return (n_ ?? false);
				};
				if (f_())
				{
					var o_ = FHIRHelpers_4_3_000.ToValue(Administration?.Effective);
					var p_ = context.Operators.Start((o_ as CqlInterval<CqlDateTime>));
					var q_ = context.Operators.DateFrom(p_);
					var s_ = context.Operators.Start((o_ as CqlInterval<CqlDateTime>));
					var t_ = context.Operators.DateFrom(s_);
					var u_ = FHIRHelpers_4_3_000.ToValue(Administration?.Medication);
					var v_ = this.TherapeuticDuration((u_ as CqlConcept));
					var w_ = context.Operators.Add(t_, v_);
					var x_ = context.Operators.ConvertIntegerToQuantity(1);
					var y_ = context.Operators.Subtract(w_, x_);
					var z_ = context.Operators.Interval(q_, y_, true, true);

					return z_;
				}
				else
				{
					return null;
				};
			};

			return e_();
		};
		var c_ = context.Operators.Select<MedicationAdministration, CqlInterval<CqlDate>>((IEnumerable<MedicationAdministration>)a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(c_);

		return d_;
	}

    [CqlDeclaration("CumulativeDuration")]
	public int? CumulativeDuration(IEnumerable<CqlInterval<CqlDate>> Intervals)
	{
		int? a_()
		{
			if ((context.Operators.Not((bool?)(Intervals is null)) ?? false))
			{
				var b_ = context.Operators.Collapse(Intervals, "day");
				int? c_(CqlInterval<CqlDate> X)
				{
					var f_ = context.Operators.Start(X);
					var g_ = context.Operators.End(X);
					var h_ = context.Operators.DifferenceBetween(f_, g_, "day");
					var i_ = context.Operators.Add(h_, 1);

					return i_;
				};
				var d_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(b_, c_);
				var e_ = context.Operators.Sum(d_);

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
		IEnumerable<CqlInterval<CqlDate>> a_(IEnumerable<CqlInterval<CqlDate>> R, CqlInterval<CqlDate> I)
		{
			var c_ = new CqlInterval<CqlDate>[]
			{
				I,
			};
			CqlInterval<CqlDate> d_(CqlInterval<CqlDate> X)
			{
				var i_ = context.Operators.Last<CqlInterval<CqlDate>>(R);
				var j_ = context.Operators.End(i_);
				var k_ = context.Operators.Quantity(1m, "day");
				var l_ = context.Operators.Add(j_, k_);
				var m_ = context.Operators.Start(X);
				var n_ = new CqlDate[]
				{
					l_,
					m_,
				};
				var o_ = context.Operators.Max<CqlDate>((n_ as IEnumerable<CqlDate>));
				var q_ = context.Operators.End(i_);
				var s_ = context.Operators.Add(q_, k_);
				var u_ = new CqlDate[]
				{
					s_,
					m_,
				};
				var v_ = context.Operators.Max<CqlDate>((u_ as IEnumerable<CqlDate>));
				var x_ = context.Operators.End(X);
				var y_ = context.Operators.DurationBetween(m_, x_, "day");
				var z_ = context.Operators.ConvertIntegerToDecimal((y_ ?? 0));
				var aa_ = this.Quantity(z_, "day");
				var ab_ = context.Operators.Add(v_, aa_);
				var ac_ = context.Operators.Interval(o_, ab_, true, true);

				return ac_;
			};
			var e_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>((IEnumerable<CqlInterval<CqlDate>>)c_, d_);
			var f_ = context.Operators.SingletonFrom<CqlInterval<CqlDate>>(e_);
			var g_ = new CqlInterval<CqlDate>[]
			{
				f_,
			};
			var h_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(R, (g_ as IEnumerable<CqlInterval<CqlDate>>));

			return h_;
		};
		var b_ = context.Operators.Aggregate<CqlInterval<CqlDate>, IEnumerable<CqlInterval<CqlDate>>>(intervals, a_, null);

		return b_;
	}

    [CqlDeclaration("MedicationPeriod")]
	public CqlInterval<CqlDate> MedicationPeriod(object medication)
	{
		CqlInterval<CqlDate> a_()
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
			else
			{
				return null;
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
		var b_ = context.Operators.Where<object>(Medications, a_);
		CqlInterval<CqlDate> c_(object M)
		{
			var m_ = this.MedicationRequestPeriod((M as MedicationRequest));

			return m_;
		};
		var d_ = context.Operators.Select<object, CqlInterval<CqlDate>>(b_, c_);
		bool? e_(object M)
		{
			var n_ = M is MedicationDispense;

			return (n_ as bool?);
		};
		var f_ = context.Operators.Where<object>(Medications, e_);
		CqlInterval<CqlDate> g_(object M)
		{
			var o_ = this.MedicationDispensePeriod((M as MedicationDispense));

			return o_;
		};
		var h_ = context.Operators.Select<object, CqlInterval<CqlDate>>(f_, g_);
		var i_ = this.RolloutIntervals(h_);
		var j_ = context.Operators.ListUnion<CqlInterval<CqlDate>>(d_, i_);
		var k_ = this.CumulativeDuration(j_);

		return k_;
	}

}
